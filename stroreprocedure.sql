
CREATE     procedure FA_vs_SALDO @datea datetime, @datez datetime
as
declare @perioda char(4)
declare @periodz char(4)
set @perioda=dbo.date2period(@datea)
set @periodz=dbo.date2period(@datez)


select acc.acc,acc.name,rac.period,abs(rac.vlast) as awal,abs(rac.vdebet-rac.vkredit) as mutasi,
abs(rac.vlast+(rac.vdebet-rac.vkredit)) as akhir,rac.vdebet,rac.vkredit
into #FA 
from acc left outer join rac on acc.acc=rac.acc where (rac.acc in (select distinct accakm from loc where  group_=2) ) and (period between @perioda and @periodz)
--from acc left outer join rac on acc.acc=rac.acc where (parent='12990400' or parent='12040100') and (period between @perioda and @periodz)

select acc,period,sum(val) as val into #PY from acd where subjurnal='jin' and (period between @perioda and @periodz) and left(jurnal,1)='.' and acd.acc in (select acc from #fa)
group by acc,period

select #FA.*,isnull(#PY.val,0) as Penyusutan from #FA left outer join #PY on #FA.acc=#PY.acc and #FA.period=#PY.period order by #FA.period,#FA.acc







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO



CREATE   procedure cekbiaya @datea datetime
as

declare @period char(4)
set @period = dbo.date2period(@datea)

select 'BIAYA' as group_,jsd.jsu as jurnal,jsu.date,space(20) as invo,jsd.cct,jsd.remark as rem,jsd.dk,jsd.val*jsu.kurs as val from jsd left outer join jsu on jsd.jsu=jsu.jsu where jsd.acc='11050701' and substring(jsd.jsu,5,4)=@period
union all
select 'BIAYA',jsu.jsu,jsu.date,'','',jsu.remark,case when dk=2 then 'K' else 'D' end,jsu.val*jsu.kurs from jsu where jsu.acc='11050701' and jsu.period=@period
union all
select 'BIAYA',umd.umh,umh.date,'',umd.cct,umd.remark,umd.dk,umd.val*umh.kurs from umd left outer join umh on umd.umh=umh.umh where substring(umd.umh,5,4)=@period and umd.acc='11050701' 
union all
select 'BIAYA',msx.msk,msk.date,'',msx.cct,msx.remark,'D',msx.val*msk.kurs 
from msx left outer join msk on msx.msk=msk.msk where  msx.acc='11050701' and
substring(msx.msk,5,4)=@period 
union all
select 'COSSHEET',csb.csi as jurnal,csb.date,csa.remark,csb.invo,csb.remark,'D',csb.val from csb left outer join csa on csb.csi=csa.csi where substring(csb.csi,5,4)=@period




GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO







CREATE      procedure hystory @pdatea datetime, @pdatez datetime,@pacca varchar(15),@paccz varchar(15),@psuba varchar(15),@psubz varchar(15),@flag char(1)
as

select * into #payhp from payhp where (payhp.date between @pdatea and @pdatez)
select reff,abs(sum(val*case when dk='K' then -1 else 1 end))  as val into #A from payhp  where date<=@pdatez group by reff
if @flag='1'
begin 
 select rhp.*,rhp.val-#a.val as val1 into #kon from rhp left outer join #a on rhp.jurnal=#a.reff where
 rhp.val-#a.val is null or rhp.val-#a.val<>0 and abs(rhp.val-#a.val)>1
end
if @flag='2'
begin 
 select rhp.*,rhp.val-#a.val as val1 into #kon1 from rhp left outer join #a on rhp.jurnal=#a.reff where
 rhp.val-#a.val=0 
end

--all
if @flag='3'
begin
select rhp.jurnal,isnull(#payhp.jurnal,'') as pelunasan,rhp.duedate,rhp.subjurnal,rhp.remark,rhp.date,rhp.acc,acc.name as accname,rhp.kurs,
rhp.sub,sub.name as subname,rhp.dk,rhp.val,isnull(#payhp.date,'') as tglpay,isnull(#payhp.val,0) as valpay from rhp left outer join #payhp 
on rhp.jurnal+rtrim(rhp.acc)+rtrim(rhp.sub)=#payhp.reff+rtrim(#payhp.acc)+rtrim(#payhp.sub) left outer join sub on rhp.sub=sub.sub 
left outer join acc on rhp.acc=acc.acc 
where (rhp.acc between @pacca and @paccz)
and (rhp.date between @pdatea and @pdatez)  and (rhp.sub between @psuba and @psubz)
order by rhp.acc,rhp.sub,rhp.date,rhp.jurnal
end

--open
if @flag='1'
begin
select rhp.jurnal,isnull(#payhp.jurnal,'') as pelunasan,rhp.duedate,rhp.subjurnal,rhp.remark,rhp.date,rhp.acc,acc.name as accname,rhp.kurs,
rhp.sub,sub.name as subname,rhp.dk,rhp.val,isnull(#payhp.date,'') as tglpay,isnull(#payhp.val,0) as valpay into #rhpopen from rhp left outer join #payhp 
on rhp.jurnal+rtrim(rhp.acc)+rtrim(rhp.sub)=#payhp.reff+rtrim(#payhp.acc)+rtrim(#payhp.sub) left outer join sub on rhp.sub=sub.sub 
left outer join acc on rhp.acc=acc.acc
where (rhp.acc between @pacca and @paccz)
and (rhp.date between @pdatea and @pdatez)  and (rhp.sub between @psuba and @psubz)
order by rhp.acc,rhp.sub,rhp.date,rhp.jurnal

select * from #rhpopen where  jurnal in (select jurnal from #kon) order by acc,sub,date,jurnal
end

--close
if @flag='2'
begin
select rhp.jurnal,isnull(#payhp.jurnal,'') as pelunasan,rhp.duedate,rhp.subjurnal,rhp.remark,rhp.date,rhp.acc,acc.name as accname,rhp.kurs,
rhp.sub,sub.name as subname,rhp.dk,rhp.val,isnull(#payhp.date,'') as tglpay,isnull(#payhp.val,0) as valpay into #rhpclose from rhp left outer join #payhp 
on rhp.jurnal+rtrim(rhp.acc)+rtrim(rhp.sub)=#payhp.reff+rtrim(#payhp.acc)+rtrim(#payhp.sub) left outer join sub on rhp.sub=sub.sub 
left outer join acc on rhp.acc=acc.acc
where (rhp.acc between @pacca and @paccz)
and (rhp.date between @pdatea and @pdatez) and (rhp.sub between @psuba and @psubz) 
order by rhp.acc,rhp.sub,rhp.date,rhp.jurnal

select * from #rhpclose where  jurnal in (select #kon1.jurnal from #kon1) order by jurnal,acc,sub,date

end
--exec hystory '20070701','20071231','','z','','z','1' 




GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO






CREATE      procedure hystory1 @pdatea datetime, @pdatez datetime,@pacca varchar(15),@paccz varchar(15),@psuba varchar(15),@psubz varchar(15),@flag char(1)
as

select * into #payhp from payhp where (payhp.date between @pdatea and @pdatez)
select reff,abs(sum(val*case when dk='K' then -1 else 1 end))  as val into #A from payhp  where date<=@pdatez group by reff
if @flag='1'
begin 
 select rhp.*,rhp.val-#a.val as val1 into #kon from rhp left outer join #a on rhp.jurnal=#a.reff where
 rhp.val-#a.val is null or rhp.val-#a.val<>0 and abs(rhp.val-#a.val)>1
end
if @flag='2'
begin 
 select rhp.*,rhp.val-#a.val as val1 into #kon1 from rhp left outer join #a on rhp.jurnal=#a.reff where
 rhp.val-#a.val=0 
end

--all
if @flag='3'
begin
select rhp.jurnal,isnull(#payhp.jurnal,'') as pelunasan,rhp.duedate,rhp.subjurnal,rhp.remark,rhp.date,rhp.acc,acc.name as accname,rhp.kurs,
rhp.sub,sub.name as subname,rhp.dk,rhp.val*(case when rhp.dk='K' then -1 else 1 end) as val,isnull(#payhp.date,'') as tglpay,isnull(#payhp.val,0)*(case when #payhp.dk='K' then -1 else 1 end) as valpay from rhp left outer join #payhp 
on RTRIM(rhp.jurnal)+RTRIM(rhp.acc)+RTRIM(rhp.sub)=RTRIM(#payhp.reff)+RTRIM(#payhp.acc)+RTRIM(#payhp.sub) left outer join sub on rhp.sub=sub.sub 
left outer join acc on rhp.acc=acc.acc 
where (rhp.acc between @pacca and @paccz)
and (rhp.date between @pdatea and @pdatez)  and (rhp.sub between @psuba and @psubz)
order by rhp.acc,rhp.sub,rhp.date,rhp.jurnal
end

--open
if @flag='1'
begin
select rhp.jurnal,isnull(#payhp.jurnal,'') as pelunasan,rhp.duedate,rhp.subjurnal,rhp.remark,rhp.date,rhp.acc,acc.name as accname,rhp.kurs,
rhp.sub,sub.name as subname,rhp.dk,rhp.val*(case when rhp.dk='K' then -1 else 1 end) as val,isnull(#payhp.date,'') as tglpay,isnull(#payhp.val,0)*(case when #payhp.dk='K' then -1 else 1 end) as valpay into #rhpopen from rhp left outer join #payhp 
on RTRIM(rhp.jurnal)+RTRIM(rhp.acc)+RTRIM(rhp.sub)=RTRIM(#payhp.reff)+RTRIM(#payhp.acc)+RTRIM(#payhp.sub) left outer join sub on rhp.sub=sub.sub 
left outer join acc on rhp.acc=acc.acc
where (rhp.acc between @pacca and @paccz)
and (rhp.date between @pdatea and @pdatez)  and (rhp.sub between @psuba and @psubz)
order by rhp.acc,rhp.sub,rhp.date,rhp.jurnal

select * from #rhpopen where  jurnal in (select jurnal from #kon) order by acc,sub,date,jurnal
end

--close
if @flag='2'
begin
select rhp.jurnal,isnull(#payhp.jurnal,'') as pelunasan,rhp.duedate,rhp.subjurnal,rhp.remark,rhp.date,rhp.acc,acc.name as accname,rhp.kurs,
rhp.sub,sub.name as subname,rhp.dk,rhp.val*(case when rhp.dk='K' then -1 else 1 end) as val,isnull(#payhp.date,'') as tglpay,isnull(#payhp.val,0)*(case when #payhp.dk='K' then -1 else 1 end) as valpay into #rhpclose from rhp left outer join #payhp 
on RTRIM(rhp.jurnal)+RTRIM(rhp.acc)+RTRIM(rhp.sub)=RTRIM(#payhp.reff)+RTRIM(#payhp.acc)+RTRIM(#payhp.sub) left outer join sub on rhp.sub=sub.sub 
left outer join acc on rhp.acc=acc.acc
where (rhp.acc between @pacca and @paccz)
and (rhp.date between @pdatea and @pdatez) and (rhp.sub between @psuba and @psubz) 
order by rhp.acc,rhp.sub,rhp.date,rhp.jurnal

select * from #rhpclose where  jurnal in (select #kon1.jurnal from #kon1) order by acc,sub,date,jurnal

end
--exec hystory '20070701','20071231','','z','','z','2'




GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO







CREATE   procedure hystory2 @pdatea datetime, @pdatez datetime,@pacca varchar(15),@paccz varchar(15),@psuba char(15),@psubz char(15)
as
declare @period char(4)
declare @kursbi float
set @period = dbo.date2period(@pdatea)
set @kursBI=(select top 1 valbi from khr where date=@pdatez and cur='USD')

select period,jurnal,date,sub,acc,dk,val,payment,duedate,subjurnal,remark,kurs into #RHP from rsb
where rsb.sub between @psuba and @psubz and rsb.period=@period and rsb.acc between @pacca and @paccz and kurs<>1 and rsb.val<>0
union all
select period,jurnal,date,sub,acc,dk,val,payment,duedate,subjurnal,remark,kurs from rhp
where rhp.sub between @psuba and @psubz and rhp.date>=@pdatea and  rhp.date<=@pdatez and rhp.acc between @pacca and @paccz and rhp.kurs<>1

select jurnal,reff,date,sub,acc,dk,(val*case when payhp.dk='K' then -1 else 1 end) as val,period into #payhp from payhp  
where payhp.sub between @psuba and @psubz and payhp.date>=@pdatea and  payhp.date<=@pdatez and payhp.acc between @pacca and @paccz

--select reff,sum(val*case when dk='K' then -1 else 1 end) as val into #A from #payhp  group by reff

begin 
 select #rhp.period,#rhp.jurnal,#rhp.date,#rhp.acc,#rhp.kurs,#rhp.dk,#rhp.sub,sub.name,acc.name as accname,
(isnull(#rhp.val,0)*case when #rhp.dk='K' then -1 else 1 end) as val,isnull(#payhp.val,0) as val1 into #kon from #rhp left outer join #payhp on #rhp.jurnal=#payhp.reff 
 left outer join sub on #rhp.sub=sub.sub left outer join acc on #rhp.acc=acc.acc
 --where((#rhp.val*case when #rhp.dk='K' then -1 else 1 end)+#payhp.val)<>0 
end

--select *,@kursBI as kursBI from #kon order by acc,sub,jurnal
select period,jurnal,date,acc,accname,kurs,dk,sub,name,round(val,2) val,round(sum(val1),2) as val1, @kursBI as kursBI 
into #valuasi from #kon
group by period,jurnal,date,acc,accname,kurs,dk,sub,name,val

select * from #valuasi where #valuasi.val+#valuasi.val1<>0  and acc in
('11030101','21020101','21020102','21020201','21020202') order by acc,sub,date,jurnal
--exec hystory2 '20080101','20080131','','z','11020001','11020001'





GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO


create procedure kasmut 
  @lcdate0 datetime,
  @lcdatea datetime,
  @lcdatez datetime,	
  @lcacc varchar(15),
  @lcperiod varchar(4)
as 

SELECT Acd.acc, Acd.jurnal, Acd.period, Acd.rem, 
Acd.date AS tanggal, Acd.val AS value, (rac.vlast)+(select isnull(sum(val*case when acd.dk='D' then 1 else -1 end),0) as saldo from acd 
where acc= @lcacc and acd.date>=@lcdate0 and acd.date < @lcdatea)  as saldo, Acd.dk 
 FROM acd full join rac on acd.period+acd.acc=rac.period+rac.acc 
 WHERE acd.period=@lcperiod and Acd.date >= @lcdatea
 AND Acd.acc = @lcacc
  AND Acd.date <=@lcdatez
ORDER BY Acd.date, Acd.jurnal 




GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO


CREATE   procedure mskvslpb @pdatea datetime,@pdatez datetime,@suba varchar(15),@subz varchar(15)
as
declare @perioda char(4)
declare @periodz char(4)
set @perioda=dbo.date2period(@pdatea)
set @periodz=dbo.date2period(@pdatez)


select * from 
( 
SELECT max(lph.oms) as oms,(select top 1 kurs as kurs from oms where oms.oms=lph.oms) as kurs,lph.lph as jurnal, isnull((select acc from accgl where remark='ACCPAY'),space(15)) as acc, lph.date, 
	sum((((lpd.price*case when inv.unit=lpd.unit then lpd.qty else lpd.qty/inv.besar end)*(100.00-lph.disc)/100.00)*(100.00-lpd.disc)/100.00)*lph.kurs*case when lph.ppn=2 then 10.00/11.00 else 1 end) as val,   
	 lph.remark,'K' as dk, 0 as adj
	FROM lpd
	left outer join lph on lpd.lph=lph.lph
	left outer join inv on lpd.inv=inv.inv
	WHERE lph.period between @perioda and @periodz  and (select top 1 isnull(aprov,0) from oms where oms.oms=lph.oms)<>1
	and (select group_ from oms where oms.oms=lph.oms)=1
         GROUP BY lph.lph, lph.period, lph.date,lph.oms, lph.remark
union all
SELECT msk.oms,msk.kurs as kurs,msk.msk AS jurnal, isnull((select acc from accgl where remark=
	case when msk.group_=1 then 'ACCPAY' else
		case when (select aprov from oms where oms.oms=msk.oms) =2 then 'ACCMAT' else
			case when (select aprov from oms where oms.oms=msk.oms) =3 then 'ACCFA ' else ' '
			end
		end
	end
	),space(15)) as acc, msk.date, 
	(msd.val-msd.ppn)*msk.kurs as val,   
	 msd.remark, 'D' as dk, 0 as adj
	FROM msd left outer join msk on msd.msk=msk.msk	
	WHERE msk.period between @perioda and @periodz and (select top 1 isnull(aprov,0) from oms where oms.oms=msk.oms)<>1
        and (select group_ from oms where oms.oms=msk.oms)=1
union all
SELECT msk.oms,msk.kurs,msk.msk AS jurnal,isnull((select acc from accgl where remark='ACCPAY'),space(15)) as acc, msk.date, 
	msx.val*msk.kurs as val,   
	('Jurnal Biaya'+rtrim(msx.remark)) as remark, 'K' as dk, 0 as adj
	FROM msx
	left outer join msk on msx.msk=msk.msk	
	WHERE msk.period between @perioda and @periodz and (select top 1 isnull(aprov,0) from oms where oms.oms=msk.oms)<>1
) as lpbmsk order by oms,dk


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO


CREATE  procedure oklout2 @okla char(20), @oklz char(20)
as
begin
select sjd.*,sjh.date as sjldate,okl.nopoc,okl.kurs,okl.date,inv.name as invname,(select sum(qty) from okd where okd.okl=okl.okl)as qtyso 
,(select top 1 (okd.price*case when okd.unit=inv.unit then 1 else 1/inv.besar end)) as priceso
,(select sum(okd1.qty) from okd okd1 left outer join okl okl1 on okd1.okl=okl1.okl where okl1.nopoc=okl.nopoc) as totpo
from okl left outer join sjd on okl.okl=sjd.okl 
left outer join okd on okl.okl=okd.okl
left outer join sjh on sjd.sjh=sjh.sjh 
left outer join inv on okd.inv=inv.inv
where okl.okl in (select okl from okl where nopoc between @okla and @oklz)
end



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

create  procedure omslistR @suba char(15), @subz char(15), @pdatea datetime, @pdatez datetime
as

select okl.date,okl.sub,okl.okl,okl.nopoc,max(okd.remark) as remark,sum(okd.qty) as qty,
sum(okd.val*okl.kurs) as dpp,sum(okd.val*okl.kurs*case when okl.ppn<>3 then 0 else 1.00/10.00 end) as ppn,
okl.val*okl.kurs as total 
into #cokl from okl left outer join okd on okl.okl=okd.okl where okl.date between @pdatea and @pdatez
group by okl.okl,okl.date,okl.nopoc,okd.remark,okl.val,okl.ppn,okl.sub,okl.kurs


select #cokl.*,klr.klr,sub.name,klr.val*klr.kurs as klrval from #cokl left outer join klr on #cokl.okl=klr.okl
left outer join sub on #cokl.sub=sub.sub
where (#cokl.sub between @suba and @subz) order by #cokl.okl


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE procedure outino @jurnal char(15)
as
begin
select umh.umh,umh.date,umd.acc,umh.remark,umd.dk,umd.val from 
umd left outer join umh on umd.umh=umh.umh 
where umd.ino=@jurnal
union all
select msx.msk,msk.date,msx.acc,msx.remark,'D',msx.val from 
msx left outer join msk on msx.msk=msk.msk 
where msx.ino=@jurnal
union all
select jsu.jsu,jsu.date,jsd.acc,jsu.remark,jsd.dk,jsd.val from 
jsd left outer join jsu on jsd.jsu=jsu.jsu 
where jsd.ino=@jurnal 
end


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

create procedure outprq
as
begin
  select prq,date,remark,loc,cct from prq where prq.aprov=1 and prq.period<'0801' order by prq,date
end



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO













CREATE           PROCEDURE prosesfa @period char(4),@date datetime
AS
delete from jin where period=@period and group_=4
declare @jnl char(15)

set @jnl='.FA-'+@period+'-000001'

select max(@period) as period, loc, inv, sum(qty) as qty, sum(isnull(val,0)) as val into #rin from (
select rin.period,rin.loc,rin.inv,qlast as qty,rin.vlast as val from rin left outer join inv on inv.inv=rin.inv where period=@period  
and inv.group_='5'  
union all
select ind.period,ind.loc,ind.inv,ind.qty*case when dk='D' then 2 else -1 end as qty,
isnull(ind.val,0) *case when dk='D' then 1 else -1 end as val from ind left outer join inv on inv.inv=ind.inv 
where ind.period=@period   and inv.group_='5'    and left(ind.jurnal,1)<>'.' and subjurnal<>'MSK'
) as tmp group by inv,loc

---susut

select nilaiawal-(select sum(#rin.val) from #rin where #rin.period=@period and #rin.inv=susut.inv) as buku,susut.* into #ctmp from (
/* Jika garis lurus
   Nilai diambil dari nilai aktiva tetap 
   Biaya penyusutan   */

select max(inv.valbeli) as residu, @jnl as jin, 0 as qty, inv.inv, sum(inv.valjual)*max(inv.prosen)/1200 as price,valjual as nilaiawal, 
  max(inv.accsls) as acc, max(inv.name) as rem, 'D' as dk, space(15) as spk from inv 
  left outer join #rin on #rin.inv=inv.inv where inv.group_='5' and inv.flag=1 and inv.date<=@date --and dateadd(year,(100/inv.prosen),inv.tglb)>@date
  and (inv.tgle>@date or inv.tgle is null or inv.tgle<'20000101') 
  group BY INV.INV,valjual,inv.prosen,inv.tglb
) as susut where susut.price<>0 


--nilai buku
select jin,inv,qty, case when buku=0 then 0 else
  case when buku<0  then
   case when buku-price>residu  then buku else price end 
  else
   case when buku-price<residu  then 
     case when buku-price> 0 then price-(residu-(buku-price)) else abs(buku-residu) end 
   else price end 
  end end as price,
  acc,rem,dk,spk into #ctmp2 from #ctmp 

insert into jin (jin, date, acc, remark, group_, period, chusr, chtime) 
  values(@jnl, @date, ' ', 'Fixed Asset Depreciation', '4',@period, '', getdate())

insert into jid
  select jin,inv,' ' as loc,rem,dk,1 as qty,price,price,1,0,1,'' from #ctmp2 where price<>0 

/*
exec prosesfa '0802','20080201'
select * from jin where group_=4
select * from jid where jin in (select jin from jin where group_=4)

*/


--SELECT * FROM INV WHERE PROSEN=0 AND GROUP_=5









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

create procedure prqomslpb
as
begin
select prd.prq,prq.date,prd.inv,prd.remark,prd.qty1 qty,prd.unit,prd.dateneed into #PRD from prd
left outer join prq on prd.prq=prq.prq
select oms.date,oms.oms,oms.prq,omd.remark,omd.qty1 as qty,omd.unit Into #OMD from omd left outer join oms on omd.oms=oms.oms
select lph.oms,lpd.lph,lpd.remark,lph.date,lpd.qty1 as qty,lpd.unit Into #LPD from lpd left outer join lph on lpd.lph=lph.lph

select #omd.*,#lpd.qty as qtylpb,#lpd.unit as unitlpb,#lpd.lph as lpb,#lpd.date as datelpb into #omdlpb from #omd left outer join #lpd on #omd.oms+#omd.remark=#lpd.oms+#lpd.remark 

select #prd.prq,#prd.date dateprq,#prd.remark namabrg,#prd.qty prdqty,#prd.unit unitprd,#prd.dateneed,
isnull(#omdlpb.date,0) date,isnull(#omdlpb.oms,space(15)) oms,isnull(#omdlpb.remark,space(50)) remark,isnull(#omdlpb.qty,0) qty,isnull(#omdlpb.unit,'') unit,
isnull(#omdlpb.qtylpb,0) qtylpb,isnull(#omdlpb.lpb,space(15)) lpb,isnull(#omdlpb.datelpb,0) datelpb
from #prd left outer join #omdlpb on #prd.prq+#prd.remark=#omdlpb.prq+#omdlpb.remark

end


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO



create procedure satuan @inv varchar(15)
as
select unit from inv where inv=@inv
union
select unit2 from inv where inv=@inv



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO






















CREATE                   PROCEDURE sp_SaveInv  @subjurnal char(15), @jurnal char(15)  AS

declare @v0koma1 float
declare @v1bagi11 float
declare @v1koma1 float
DECLARE @V10BAGI11 FLOAT
set @v0koma1=0.1000
set @v1bagi11=1.0000/11.0000
set @v1koma1=1.1000
SET @V10BAGI11=10.0000/11.0000

/*If @subjurnal='MSK'  
Begin  
insert into ind select * from (  
        SELECT msk.msk AS jurnal, dbo.date2period(msk.date) AS period, msd.inv, msd.loc, msk.date,
        msd.qty,(((msd.price*msd.qty)*(100.00-msk.disc)/100.00)*(100.00-msd.disc)/100.00)*case when msk.ppn=2 then @V10Bagi11 else 1 end as val,   
        msk.remark as rem, 'D' as dk , 'MSK' as subjurnal
        FROM msd left outer join msk on msk.msk=msd.msk 
        left outer join inv on msd.inv=inv.inv	
        WHERE msd.msk=@jurnal and msd.qty>0 and isnull(inv.acc,space(15))=' '
) as xacd  
End
*/
If @subjurnal='LPB'  --LPB LOKAL
Begin  
insert into ind select * from (  
        SELECT lph.lph AS jurnal, dbo.date2period(lph.date) AS period, lpd.inv, lph.loc, lph.date,
        lpd.qty,(((lpd.price*case when lpd.unit=inv.unit then lpd.qty else lpd.qty/inv.besar end )*(100.00-lph.disc)/100.00)*(100.00-lpd.disc)/100.00)*lph.kurs*case when lph.ppn=2 then @V10Bagi11 else 1 end as val,   
        lph.remark as rem, 'D' as dk , 'LPB' as subjurnal
        FROM lpd left outer join lph on lph.lph=lpd.lph 
       -- left outer join oms on lph.oms=oms.oms
        left outer join inv on lpd.inv=inv.inv	
        WHERE lpd.lph=@jurnal and lpd.qty>0 and isnull(inv.acc,space(15))=' ' 
--	and oms.group_='1'
) as xacd  
End  
If @subjurnal='POO'  ----LPB IMPORT 
Begin  
insert into ind select * from (  
        SELECT lph.lph AS jurnal, dbo.date2period(lph.date) AS period, lpd.inv, lph.loc, lph.date,
        lpd.qty,isnull((select price from csl where csl.lph=lph.lph),0)*lpd.qty as val,   
--        lpd.qty,((((dbo.CariEstperbrg(lph.oms))*(lpd.price*LPH.KURS)*case when lpd.unit=inv.unit then lpd.qty else lpd.qty1*inv.besar end)*(100.00-lph.disc)/100.00)*(100.00-lpd.disc)/100.00)*case when lph.ppn=2 then @V10Bagi11 else 1 end as val,   
        lph.remark as rem, 'D' as dk , 'POO' as subjurnal
        FROM lpd left outer join lph on lph.lph=lpd.lph 
	left outer join oms on lph.oms=oms.oms 
        left outer join inv on lpd.inv=inv.inv	
        WHERE lpd.lph=@jurnal and lpd.qty>0 and isnull(inv.acc,space(15))=' ' and oms.group_='2'
) as xacd  

End  

If @subjurnal='RMA'  
Begin  
insert into ind select * from (  
        SELECT rma.rma AS jurnal, dbo.date2period(rma.date) AS period, rmb.inv, rma.loc, rma.date,
        rmb.qty, dbo.carihpp(rma.loc,rmb.inv,rma.date)*rmb.qty as val,   
        rmb.remark as rem, 'K' as dk , 'RMA' as subjurnal
        FROM rmb left outer join rma on rma.rma=rmb.rma 
        WHERE rmb.rma=@jurnal and rmb.qty>0 
) as xacd  
End


If @subjurnal='RMS'  
Begin  
insert into ind select * from (  
        SELECT rms.rms AS jurnal, dbo.date2period(rms.date) AS period, rmd.inv, rmd.loc, rms.date,
        rmd.qty, dbo.carihpp(rmd.loc,rmd.inv,rms.date)*rmd.qty as val,   
        rms.remark as rem, 'K' as dk , 'RMS' as subjurnal
        FROM rmd left outer join rms on rms.rms=rmd.rms 
        WHERE rmd.rms=@jurnal and rmd.qty>0 
) as xacd  
End

/*If @subjurnal='KLR'  
Begin  
insert into ind select * from (  
        SELECT klr.klr AS jurnal, dbo.date2period(klr.date) AS period, kld.inv, kld.loc, klr.date,
        kld.qty, dbo.carihpp(kld.loc,kld.inv,klr.date)*kld.qty as val,   
        klr.remark as rem, 'K' as dk , 'KLR' as subjurnal
        FROM kld left outer join klr on klr.klr=kld.klr 
        WHERE kld.klr=@jurnal and kld.qty>0 
) as xacd  
End*/

If @subjurnal='SJH'  
Begin  
insert into ind select * from (  
        SELECT sjh.sjh AS jurnal, dbo.date2period(sjh.date) AS period, sjd.inv, sjh.loc, sjh.date,
        sjd.qty, dbo.carihpp(sjh.loc,sjd.inv,sjh.date)*sjd.qty as val,   
        sjh.remark as rem, 'K' as dk , 'SJH' as subjurnal
        FROM sjd left outer join sjh on sjd.sjh=sjh.sjh
        WHERE sjd.sjh=@jurnal and sjd.qty>0 
) as xacd  
End

If @subjurnal='RKA'  
Begin  
insert into ind select * from (  
        SELECT rka.rka AS jurnal, dbo.date2period(rka.date) AS period, rkb.inv, rka.loc, rka.date,
        rkb.qty, dbo.carihpp(rka.loc,rkb.inv,rka.date)*rkb.qty as val,   
        rka.remark as rem, 'D' as dk , 'RKA' as subjurnal
        FROM rkb left outer join rka on rka.rka=rkb.rka
        WHERE rkb.rka=@jurnal and rkb.qty>0 
) as xacd  
End

/*If @subjurnal='RKL'  
Begin  
insert into ind select * from (  
        SELECT rkl.rkl AS jurnal, dbo.date2period(rkl.date) AS period, rkd.inv, rkd.loc, rkl.date,
        rkd.qty,
        case when dbo.carihpp(rkd.loc,rkd.inv,rkl.date) = 0  
        	then 	
        		(((rkd.price*rkd.qty)*(100.00-rkl.disc)/100.00)*(100.00-rkd.disc)/100.00)*case when rkl.ppn=2 then @V10Bagi11 else 1 end 
	else
		dbo.carihpp(rkd.loc,rkd.inv,rkl.date)*rkd.qty
	end
        as val,   
        rkl.remark as rem, 'D' as dk , 'RKL' as subjurnal
        FROM rkd left outer join rkl on rkl.rkl=rkd.rkl 
        WHERE rkd.rkl=@jurnal and rkd.qty>0 
) as xacd  
End */


If @subjurnal='JIN'  
Begin  
insert into ind select * from (  
        SELECT jin.jin AS jurnal, dbo.date2period(jin.date) AS period, jid.inv, isnull(jid.loc,space(15)) as loc, jin.date,
        jid.qty, case when dk='D' then jid.val else dbo.carihpp(jid.loc,jid.inv,jin.date)*jid.qty end as val,   
        jin.remark as rem, jid.dk as dk , 'JIN' as subjurnal
        FROM jid left outer join jin on jin.jin=jid.jin 
        WHERE jin.jin=@jurnal and jid.qty>0 
) as xacd  
End

If @subjurnal='LHP'  
Begin  
insert into ind select * from (  
        SELECT lhp.lhp AS jurnal, dbo.date2period(lhp.date) AS period, lhd.inv, lhd.loc, lhp.date,
        lhd.qty, lhd.price*lhd.qty as val,   
        lhp.remark as rem, 'D' as dk , 'lhp' as subjurnal
        FROM lhd left outer join lhp on lhp.lhp=lhd.lhp 
        WHERE lhp.lhp=@jurnal and lhd.qty>0 
) as xacd  
End

If @subjurnal='TRM'  
Begin  
insert into ind select * from (  
        SELECT trm.trm AS jurnal, dbo.date2period(trm.date) AS period, trd.inv, trm.locd as loc, trm.date,
        trd.qty, dbo.carihpp(trm.lock,trd.inv,trm.date)*trd.qty  as val,   
        trm.remark as rem, 'D' as dk , 'TRM' as subjurnal
        FROM trd left outer join trm on trm.trm=trd.trm 
        WHERE trm.trm=@jurnal and trd.qty>0
) as xacd  

insert into ind select * from (  
        SELECT trm.trm AS jurnal, dbo.date2period(trm.date) AS period, trd.inv, trm.lock as loc, trm.date,
        trd.qty, dbo.carihpp(trm.lock,trd.inv,trm.date)*trd.qty  as val,   
        trm.remark as rem, 'K' as dk , 'TRM' as subjurnal
        FROM trd left outer join trm on trm.trm=trd.trm 
        WHERE trm.trm=@jurnal and trd.qty>0
) as xacd  
End

If @subjurnal='OPN'  
Begin  
        select *  into #opn
        from 
        ( select opd.opn, opn.date, opd.inv, opn.loc, round(opd.qty,2) as qty, round(opd.val,2) as val, opn.remark,   
	dbo.cariopnqtyval(opn.loc,opd.inv,opn.date,'Q')  as qlast,
	dbo.cariopnqtyval(opn.loc,opd.inv,opn.date,'V')  as vlast	
	from opd left outer join opn on opd.opn=opn.opn 
             where opn.opn=@jurnal 
        ) as xopn 

        insert into ind select * from (  
        SELECT #opn.opn AS jurnal, dbo.date2period(#opn.date) AS period, #opn.inv, #opn.loc ,#opn.date,
        round(abs(#opn.qlast*(-1)+#opn.qty),2) as qty, 
        case when #opn.qlast>#opn.qty then round(#opn.val*(-1)+#opn.vlast,2) else
        --case when #opn.qlast=#opn.qty then 0 else 
	round(#opn.vlast*(-1)+#opn.val,2) end as val,
        --#opn.vlast as val,	
        #opn.remark as rem,case when #opn.qlast>=#opn.qty then 'K' else 'D'  end as dk , 'OPN' as subjurnal
        FROM #opn
        ) as xacd  
End









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO





CREATE  PROCEDURE sp_Trial
  @lcdatea datetime,
  @lcdatez datetime,	
  @lclevel float,
  @lcprint0 float,
  @lccloseofmonth float=0

as

declare @lcperiod varchar(4)
declare @lcAccParent varchar(15)

set @lcperiod=dbo.date2period(@lcdatea) 

declare @lcAccDetil varchar(15)
declare @lcDebet float
declare @lcKredit float
declare @lcDebetadj float
declare @lcKreditadj float
declare @lcDebetnetto float
declare @lcKreditnetto float

declare @lcVal float
declare @lcValnetto float

select acc, sum(isnull(vlast,0)) as vlast, sum(isnull(vlastnetto,0)) as vlastnetto  into #awal 
from
( 
  select rac.acc, 
       rac.vlast, 
       rac.vlast as vlastnetto 
       from rac 
       where rac.period=@lcPeriod
  union all
  select acd.acc, 
       sum(val*case when dk='D' then 1 else -1 end) as vlast, 
      sum(case when acd.adj=1 then val*case when dk='D' then 1 else -1 end else 0 end) as vlastnetto  
      from acd 
      where acd.period=@lcperiod and acd.date <@lcdatea group by acd.acc
) 
as oawal group by acc

select acc, 
    sum(val*case when dk='D' then 1 else 0 end) as debet,                             -- nilai debet GL
    sum(val*case when dk='K' then 1 else 0 end) as kredit,			-- nilai kredit GL
    sum(val*case when dk='D' and adj=1 then 1 else 0 end) as debetadj,  	-- nilai debet penyesuaian
    sum(val*case when dk='K' and adj=1 then 1 else 0 end) as kreditadj,  	-- nilai kredit penyesuaian
    sum(val*case when dk='D' and adj=0 then 1 else 0 end) as debetnetto,     -- nilai debet GL - nilai debet penyesuaian
    sum(val*case when dk='K' and adj=0 then 1 else 0 end) as kreditnetto 	-- nilai kredit GL - kredit penyesuaian
    into #mutasi
    from acd 
    where acd.date between @lcdatea  and @lcdatez group by acd.acc

select acc.acc, 
    acc.name, 
    acc.parent, 
    acc.group_, 
    acc.detil, 
    acc.level_, 
    isnull(#awal.vlast,0) as awal, 
    isnull(#awal.vlastnetto,0) as awalnetto, 
    isnull(#mutasi.debet,0) as debet, 
    isnull(#mutasi.kredit,0) as kredit, 
    isnull(#mutasi.debetadj,0) as debetadj, 
    isnull(#mutasi.kreditadj,0) as kreditadj,
    isnull(#mutasi.debetnetto,0) as debetnetto, 
    isnull(#mutasi.kreditnetto,0) as kreditnetto 
    into #saldo1 
    from  #awal 
    right outer join acc 
    left outer join #mutasi
    on acc.acc=#mutasi.acc 
    on #awal.acc=acc.acc

select * into #saldo from #saldo1 

select acc, parent into #saldoparent from #saldo where detil=0

DECLARE #saldodetil CURSOR FOR 
select acc,parent,debet,kredit,debetadj,kreditadj,awal,awalnetto,debetnetto,kreditnetto  from #saldo where detil=1 and abs(awal)+abs(debet)+abs(kredit)>0

OPEN #saldodetil

FETCH FROM #saldodetil into @lcAccDetil, @lcAccParent, @lcDebet, @lcKredit, @lcDebetadj, @lcKreditadj, @lcVal, @lcvalnetto, @lcdebetnetto, @lckreditnetto

WHILE (@@FETCH_STATUS = 0)
BEGIN
  while (@lcAccParent<>space(15))
  begin
      update #saldo set  debet=debet+@lcDebet, kredit=kredit+@lcKredit where acc=@lcAccParent 	
      update #saldo set  debetadj=debetadj+@lcDebetadj, kreditadj=kreditadj+@lcKreditadj where acc=@lcAccParent 	
      update #saldo set  debetnetto=debetnetto+@lcDebetnetto, kreditnetto=kreditnetto+@lcKreditnetto where acc=@lcAccParent 	
      set @lcAccParent=(select parent from #saldoparent where acc=@lcAccParent)
  end 
  FETCH FROM #saldodetil into @lcAccDetil, @lcAccParent, @lcDebet, @lcKredit, @lcDebetadj, @lcKreditadj, @lcVal, @lcValnetto, @lcDebetnetto, @lcKreditnetto
end


if @lccloseofmonth=0
begin
   if   @lcprint0 = 1
       select *, isnull((select acc.name from acc where acc.acc=#saldo.parent),#saldo.name) as parentname, case when parent=' '  then acc else parent end  as parentacc 
            from #saldo 
            where level_= @lclevel or (level_<@lclevel and detil=1)
            order by acc 
   else
        select *,isnull((select acc.name from acc where acc.acc=#saldo.parent),#saldo.name) as parentname, case when parent=' '  then acc else parent end  as parentacc 
            from #saldo 
            where ( level_= @lclevel or (level_<@lclevel and detil=1) ) and (abs(awal)+abs(debet)+abs(kredit)>0)
            order by acc
end
else
       select * from #saldo order by acc




GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO





CREATE PROCEDURE sp_TrialCct
  @lcdatea datetime,
  @lcdatez datetime,	
  @lclevel float,
  @lcprint0 float,
  @lccloseofmonth float=0,
  @lccct varchar(15)

as

declare @lcperiod varchar(4)
declare @lcAccParent varchar(15)

set @lcperiod=dbo.date2period(@lcdatea) 

declare @lcAccDetil varchar(15)
declare @lcDebet float
declare @lcKredit float
declare @lcDebetadj float
declare @lcKreditadj float
declare @lcDebetnetto float
declare @lcKreditnetto float

declare @lcVal float
declare @lcValnetto float

declare @lcacddate datetime

select acc, sum(isnull(vlast,0)) as vlast, sum(isnull(vlastnetto,0)) as vlastnetto  into #awal 
from
( 
  select rac.acc, 
       rac.vlast, 
       rac.vlast as vlastnetto 
       from rac 
       where rac.period=@lcPeriod
/*  union all
  select acd.acc, 
       sum(val*case when dk='D' then 1 else -1 end) as vlast, 
      sum(case when acd.adj=1 then val*case when dk='D' then 1 else -1 end else 0 end) as vlastnetto  
      from acd 
      where acd.period=@lcperiod and acd.date <@lcdatea and acd.cct=@lccct group by acd.acc*/
) 
as oawal group by acc

select acc, date, 
    sum(val*case when dk='D' then 1 else 0 end) as debet,                             -- nilai debet GL
    sum(val*case when dk='K' then 1 else 0 end) as kredit,			-- nilai kredit GL
    sum(val*case when dk='D' and adj=1 then 1 else 0 end) as debetadj,  	-- nilai debet penyesuaian
    sum(val*case when dk='K' and adj=1 then 1 else 0 end) as kreditadj,  	-- nilai kredit penyesuaian
    sum(val*case when dk='D' and adj=0 then 1 else 0 end) as debetnetto,     -- nilai debet GL - nilai debet penyesuaian
    sum(val*case when dk='K' and adj=0 then 1 else 0 end) as kreditnetto 	-- nilai kredit GL - kredit penyesuaian
    into #mutasi
    from acd 
    where acd.date <=@lcdatez and acd.period=@lcperiod
    --between @lcdatea  and @lcdatez and acd.cct=@lccct 
    group by acd.acc, acd.date

select acc.acc, 
    acc.name, 
    acc.parent, 
    acc.group_, 
    acc.detil, 
    acc.level_, 
    isnull(#awal.vlast,0) as awal, 
    isnull(#awal.vlastnetto,0) as awalnetto, 
    isnull(#mutasi.debet,0) as debet, 
    isnull(#mutasi.kredit,0) as kredit, 
    isnull(#mutasi.debetadj,0) as debetadj, 
    isnull(#mutasi.kreditadj,0) as kreditadj,
    isnull(#mutasi.debetnetto,0) as debetnetto, 
    isnull(#mutasi.kreditnetto,0) as kreditnetto,
    isnull(#mutasi.date, '01/01/2001' ) as date
    into #saldo1 
    from  #awal 
    right outer join acc 
    left outer join #mutasi
    on acc.acc=#mutasi.acc 
    on #awal.acc=acc.acc

select * into #saldo from #saldo1 

select acc, parent into #saldoparent from #saldo where detil=0

DECLARE #saldodetil CURSOR FOR 
select acc,parent,debet,kredit,debetadj,kreditadj,awal,awalnetto,debetnetto,kreditnetto, date  from #saldo where detil=1 and abs(awal)+abs(debet)+abs(kredit)>0

OPEN #saldodetil

FETCH FROM #saldodetil into @lcAccDetil, @lcAccParent, @lcDebet, @lcKredit, @lcDebetadj, @lcKreditadj, @lcVal, @lcvalnetto, @lcdebetnetto, @lckreditnetto, @lcacddate

WHILE (@@FETCH_STATUS = 0)
BEGIN
  while (@lcAccParent<>space(15))
  /*begin
      update #saldo set  debet=debet+@lcDebet, kredit=kredit+@lcKredit where acc=@lcAccParent 	
      update #saldo set  debetadj=debetadj+@lcDebetadj, kreditadj=kreditadj+@lcKreditadj where acc=@lcAccParent 	
      update #saldo set  debetnetto=debetnetto+@lcDebetnetto, kreditnetto=kreditnetto+@lcKreditnetto where acc=@lcAccParent 	
      set @lcAccParent=(select parent from #saldoparent where acc=@lcAccParent)
  end */
    begin
      if @lcacddate<@lcdatea
      begin
	update #saldo set awal=awal+@lcdebet-@lckredit where acc=@lcaccparent
	update #saldo set awalnetto=awalnetto+@lcdebet-@lckredit where acc=@lcaccparent
      end	 	
      else
      begin	
	update #saldo set  debet=debet+@lcDebet, kredit=kredit+@lcKredit where acc=@lcAccParent 	
	update #saldo set  debetadj=debetadj+@lcDebetadj, kreditadj=kreditadj+@lcKreditadj where acc=@lcAccParent 	
	update #saldo set  debetnetto=debetnetto+@lcDebetnetto, kreditnetto=kreditnetto+@lcKreditnetto where acc=@lcAccParent 	
      end
      set @lcAccParent=(select parent from #saldoparent where acc=@lcAccParent)
  end 

  FETCH FROM #saldodetil into @lcAccDetil, @lcAccParent, @lcDebet, @lcKredit, @lcDebetadj, @lcKreditadj, @lcVal, @lcValnetto, @lcDebetnetto, @lcKreditnetto, @lcacddate
end


if @lccloseofmonth=0
begin
   if   @lcprint0 = 1
       select *, isnull((select acc.name from acc where acc.acc=#saldo.parent),#saldo.name) as parentname, case when parent=' '  then acc else parent end  as parentacc 
            from #saldo 
            where level_= @lclevel or (level_<@lclevel and detil=1)
            order by acc 
   else
        select *,isnull((select acc.name from acc where acc.acc=#saldo.parent),#saldo.name) as parentname, case when parent=' '  then acc else parent end  as parentacc 
            from #saldo 
            where ( level_= @lclevel or (level_<@lclevel and detil=1) ) and (abs(awal)+abs(debet)+abs(kredit)>0)
            order by acc
end
else
       select * from #saldo order by acc

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO



CREATE    procedure sp_akt @pdatez datetime
as 
--drop table #JID
declare @period char(4)
set @period=dbo.date2period(@pdatez)

SELECT inv.inv as inv1,jid.jin as jurnal, jin.period,inv.accsls as acccct, inv.date,jid.val*mfd.prosent/100 as val,
    	mfd.cct as cct,jid.dk,jid.price
	into #PY from jid left outer join jin on jid.jin=jin.jin left outer join inv on jid.inv=inv.inv
	left outer join mfd on inv.inv=mfd.inv where jin.group_=4 and jin.period=@period
select inv.inv,inv.name as name,inv.unit,inv.prosen ,#py.*,inv.tgle,inv.tglb,inv.acc as acc,acc.name as accname,inv.valjual  from inv left outer join #PY on inv.inv=#py.inv1 
left outer join acc on inv.acc=acc.acc where inv.group_='5'
order by inv.acc,jurnal,inv 





GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO













CREATE             procedure sp_aktiva @pdatez datetime
as 
--drop table #JID
declare @period char(4)
set @period=dbo.date2period(@pdatez)

--select * into #JID from jid where (left(jin,1)='.' and substring(jin,5,4)=@Period)
/*
select inv.inv,inv.name,inv.date,inv.tglb,inv.tgle,inv.unit,inv.acc,acc.name as accname,inv.prosen,inv.valjual
,case when year(inv.tglb)<year(@pdatez) and inv.date<=@pdatez and dateadd(year,(100/case when inv.prosen=0 then 1 else inv.prosen end),inv.tglb)>@pdatez
 and (inv.tgle>@pdatez or inv.tgle is null or inv.tgle<'20000101') 
      then (inv.valjual*inv.prosen/1200)*isnull((cast(('12/31/'+rtrim(year(@Pdatez)-1))-dbo.fBom(inv.tglb) as int)/30),0) else 0 end as psdy,

 case when year(inv.tglb)=year(@pdatez)
 and inv.date<dbo.fbom(@pdatez) and dateadd(year,(100/case when inv.prosen=0 then 1 else inv.prosen end),inv.tglb)>=@pdatez
 and (inv.tgle>=dbo.fbom(@pdatez) or inv.tgle is null or inv.tgle<'20000101') 
      then (inv.valjual*inv.prosen/1200)*isnull((cast(@pdatez-dbo.feom(inv.tglb)as int)/30),0) else 
 case when (inv.tgle>=dbo.fbom(@pdatez) or inv.tgle is null or inv.tgle<'20000101') and dateadd(year,(100/case when inv.prosen=0 then 1 else inv.prosen end),inv.tglb)>=@pdatez
      then (inv.valjual*inv.prosen/1200)*isnull((cast(@pdatez-('01/01/'+rtrim(year(@Pdatez))) as int)/30),0) else 0 end
      end as psdnow 

from inv 
left outer join acc on inv.acc=acc.acc  where inv.group_='5'  and
(inv.tglb<=@pdatez or inv.prosen=0)
--and dateadd(year,(100/case when inv.prosen=0 then 1 else inv.prosen end),inv.tglb)>@pdatez
--and (inv.tgle>@pdatez or inv.tgle is null or inv.tgle<'20000101') 
order by inv.acc

*/

select inv.inv,inv.name,inv.date,inv.tglb,inv.tgle,inv.unit,inv.acc,acc.name as accname,inv.prosen,inv.valjual
,case when year(inv.tglb)<year(@pdatez) and inv.DATE<=@pdatez and dateadd(year,(100/case when inv.prosen=0 then 1 else inv.prosen end),inv.tglb)>@pdatez
 and (inv.tgle>@pdatez or inv.tgle is null or inv.tgle<'20000101') 
      then (inv.valjual*inv.prosen/1200)*isnull((cast(('12/31/'+rtrim(year(@Pdatez)-1))-(case when inv.tglb<'08/01/2007' then '07/31/2007' else dbo.fBom(inv.tglb) end) as int)/30),0)+isnull(peny.f3,0) else 0 end as psdy,
  
    isnull(peny.f3,0) as sa,

 case when year(inv.tglb)=year(@pdatez)
 and dbo.feom(inv.date)<=dbo.fbom(@pdatez) and dateadd(year,(100/case when inv.prosen=0 then 1 else inv.prosen end),inv.tglb)>=@pdatez
 and (inv.tgle>=dbo.fbom(@pdatez) or inv.tgle is null or inv.tgle<'01/01/2000') 
      then (inv.valjual*inv.prosen/1200)*isnull((cast(@pdatez-(case when inv.tglb<'08/01/2007' then '07/31/2007' else dbo.fBom(inv.tglb) end )as int)/30),0)+isnull(peny.f3,0) 
      else 
   case when (inv.tgle>dbo.fbom(@pdatez) or inv.tgle is null or inv.tgle<'20000101') and dateadd(year,(100/case when inv.prosen=0 then 1 else inv.prosen end),inv.tglb)>=@pdatez
   then (inv.valjual*inv.prosen/1200)*isnull((cast(@pdatez-case when year(@pdatez)=2007 and inv.tglb>='08/01/2007' then dbo.fbom(inv.tglb)-day(1) else
	('01/01/'+rtrim(year(@Pdatez))) end as int)/30),0) else 
   CASE when inv.date>dbo.fbom(@pdatez) then (inv.valjual*inv.prosen/1200)*isnull((cast(@pdatez-(case when inv.tglb<'08/01/2007' then '07/31/2007' else dbo.fBom(inv.tglb) end )as int)/30),0)+isnull(peny.f3,0) else 0 end 
 end
 end as psdnow

from inv 
left outer join acc on inv.acc=acc.acc  
left outer join peny on inv.inv=peny.inv
where inv.group_='5'  and
(inv.tglb<=@pdatez or inv.prosen=0)
--and dateadd(year,(100/case when inv.prosen=0 then 1 else inv.prosen end),inv.tglb)>@pdatez
--and (inv.tgle>@pdatez or inv.tgle is null or inv.tgle<'20000101') 
order by inv.acc



--exec  sp_aktiva '20070930' 











GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO





CREATE  PROCEDURE sp_cekerror
  @lcdate datetime

as

declare @lcperiod varchar(4)

set @lcperiod=dbo.date2period(@lcdate) 

select * into #error from
(
select 0 as flag, jurnal, date, space(15) as acc, 'Unbalance Jurnal...!' as rem, space(1) as dk, val from 
(
select jurnal,max(date) as date, sum(acd.val*case when dk='D' then 1 else -1 end) as val
from acd 
where acd.period=@lcperiod
group by jurnal
) as xumd where abs(val)  >=  0.01

)
 as tmperror

insert into dataerror (period,jurnal,date,acc,rem,dk,val)
select @lcperiod,jurnal,date,acc,rem,dk,val from #error



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE procedure sp_csi @pdatea datetime,@pdatez datetime
as
begin
select csa.csi,max(invo) as invo,max(remark)remark,sum(val) as val into #csa from csa group by csa.csi
select csl.csi,sum(qty) as qty into #csl from csl group by csl.csi

select csi.csi,csi.oms,csi.date,#csa.invo,#csa.remark as remarkinv,#csa.val as valinv,#csl.*,csb.*
from csi left outer join #csa on #csa.csi=csi.csi left outer join
#csl on #csl.csi=csi.csi left outer join csb on csb.csi=csi.csi
where csi.date between @pdatea and @pdatez

end



--exec sp_csi '20080101','20080131'

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO











CREATE        PROCEDURE sp_delete  @subjurnal char(15), @jurnal char(15), @period varchar(4)  AS

If @subjurnal='OMS'  
Begin  
     delete outpo where outpo.oms=@jurnal and outpo.period=@period                       
end

If @subjurnal='VPO'  
Begin  
     delete realpo where realpo.jurnal=@jurnal and realpo.period=@period                                              
end

If @subjurnal='LPB'  
Begin  
     delete realpo where realpo.jurnal=@jurnal                        
     delete ind where ind.jurnal=@jurnal and ind.subjurnal=@subjurnal
     delete acd where acd.jurnal=@jurnal and acd.subjurnal=@subjurnal	
end

If @subjurnal='POO'  
Begin  
      delete realpo where realpo.jurnal=@jurnal                        
     delete ind where ind.jurnal=@jurnal and ind.subjurnal=@subjurnal
     delete acd where acd.jurnal=@jurnal and acd.subjurnal=@subjurnal	
end


If @subjurnal='MSK'  
Begin  
     delete payhp where payhp.jurnal=@jurnal and payhp.subjurnal=@subjurnal
     delete rhp where rhp.jurnal=@jurnal and rhp.subjurnal=@subjurnal and rhp.period=@period	
     delete acd where acd.jurnal=@jurnal and acd.subjurnal=@subjurnal	
end
If @subjurnal='MSI'  
Begin  
     delete payhp where payhp.jurnal=@jurnal and payhp.subjurnal=@subjurnal
     delete rhp where rhp.jurnal=@jurnal and rhp.subjurnal=@subjurnal and rhp.period=@period	
     delete acd where acd.jurnal=@jurnal and acd.subjurnal=@subjurnal	
end

If @subjurnal='RMA'  
Begin  
     delete ind where ind.jurnal=@jurnal and ind.subjurnal=@subjurnal     
     delete acd where acd.jurnal=@jurnal and acd.subjurnal=@subjurnal	
end

If @subjurnal='RMS'  
Begin  
     --delete ind where ind.jurnal=@jurnal and ind.subjurnal=@subjurnal
     delete rhp where rhp.jurnal=@jurnal and rhp.subjurnal=@subjurnal and rhp.period=@period		
     delete acd where acd.jurnal=@jurnal and acd.subjurnal=@subjurnal	
end

If @subjurnal='OKL'  
Begin  
     delete outso where outso.okl=@jurnal and outso.period=@period
end

If @subjurnal='VSO'  
Begin  
     delete realso where realso.jurnal=@jurnal  and realso.period=@period
end

If @subjurnal='SJH'  
Begin  
     delete realso where realso.jurnal=@jurnal                        
     delete ind where ind.jurnal=@jurnal and ind.subjurnal=@subjurnal
     delete acd where acd.jurnal=@jurnal and acd.subjurnal=@subjurnal	
end


If @subjurnal='KLR'  
Begin  
     delete payhp where payhp.jurnal=@jurnal and payhp.subjurnal=@subjurnal
     delete rhp where rhp.jurnal=@jurnal and rhp.subjurnal=@subjurnal  and rhp.period=@period		
     delete acd where acd.jurnal=@jurnal and acd.subjurnal=@subjurnal	
end

If @subjurnal='RKA'  
Begin  
     delete ind where ind.jurnal=@jurnal and ind.subjurnal=@subjurnal
     delete acd where acd.jurnal=@jurnal and acd.subjurnal=@subjurnal	
end

If @subjurnal='RKL'  
Begin  
     delete rhp where rhp.jurnal=@jurnal and rhp.subjurnal=@subjurnal  and rhp.period=@period		
     delete acd where acd.jurnal=@jurnal and acd.subjurnal=@subjurnal	
end

If @subjurnal='JIN'  
Begin  
     delete ind where ind.jurnal=@jurnal and ind.subjurnal=@subjurnal
     delete acd where acd.jurnal=@jurnal and acd.subjurnal=@subjurnal	
end

If @subjurnal='LHP'  
Begin  
     delete ind where ind.jurnal=@jurnal and ind.subjurnal=@subjurnal
     delete acd where acd.jurnal=@jurnal and acd.subjurnal=@subjurnal	
end

If @subjurnal='TRM'  
Begin  
     delete ind where ind.jurnal=@jurnal and ind.subjurnal=@subjurnal
     delete acd where acd.jurnal=@jurnal and acd.subjurnal=@subjurnal	
end

If @subjurnal='OPN'  
Begin  
     delete ind where ind.jurnal=@jurnal and ind.subjurnal=@subjurnal
     delete acd where acd.jurnal=@jurnal and acd.subjurnal=@subjurnal	
end

If @subjurnal='UMH'  
Begin  
     delete payhp where payhp.jurnal=@jurnal and payhp.subjurnal=@subjurnal
     delete acd where acd.jurnal=@jurnal and acd.subjurnal=@subjurnal
end
If @subjurnal='CAD'  
Begin  
     delete acd where acd.jurnal=@jurnal and acd.subjurnal=@subjurnal
end

If @subjurnal='JSU'  
Begin  
     delete rhp where rhp.jurnal=@jurnal and rhp.subjurnal=@subjurnal  and rhp.period=@period	
     delete acd where acd.jurnal=@jurnal and acd.subjurnal=@subjurnal	
end

If @subjurnal='TTS'  
Begin  
     delete payhp where payhp.jurnal=@jurnal and payhp.subjurnal=@subjurnal
     delete rhp where rhp.jurnal=@jurnal and rhp.subjurnal=@subjurnal  and rhp.period=@period	
     delete acd where acd.jurnal=@jurnal and acd.subjurnal=@subjurnal	 
end

If @subjurnal='TTC'  
Begin  
     delete payhp where payhp.jurnal=@jurnal and payhp.subjurnal=@subjurnal
     delete rhp where rhp.jurnal=@jurnal and rhp.subjurnal=@subjurnal  and rhp.period=@period	
     delete acd where acd.jurnal=@jurnal and acd.subjurnal=@subjurnal	
end

If @subjurnal='KKK'  
Begin  	
     delete acd where acd.jurnal=@jurnal and acd.subjurnal=@subjurnal	
end

If @subjurnal='KKM'  
Begin  
     delete acd where acd.jurnal=@jurnal and acd.subjurnal=@subjurnal	
end
If @subjurnal='KKG'  
Begin  
     delete acd where acd.jurnal=@jurnal and acd.subjurnal=@subjurnal	
end
If @subjurnal='KKL'  
Begin  	
     delete payhp where payhp.jurnal=@jurnal and payhp.subjurnal=@subjurnal
     delete rhp where rhp.jurnal=@jurnal and rhp.subjurnal=@subjurnal  and rhp.period=@period	
     delete rghp where rghp.jurnal=@jurnal and rghp.subjurnal=@subjurnal
     delete rgr where rgr.jurnal=@jurnal and rgr.subjurnal=@subjurnal  and rgr.period=@period		
     delete acd where acd.jurnal=@jurnal and acd.subjurnal=@subjurnal	
end

If @subjurnal='KMS'  
Begin  
     delete payhp where payhp.jurnal=@jurnal and payhp.subjurnal=@subjurnal
     delete rhp where rhp.jurnal=@jurnal and rhp.subjurnal=@subjurnal  and rhp.period=@period	
     delete rghp where rghp.jurnal=@jurnal and rghp.subjurnal=@subjurnal
     delete rgr where rgr.jurnal=@jurnal and rgr.subjurnal=@subjurnal  and rgr.period=@period		
     delete acd where acd.jurnal=@jurnal and acd.subjurnal=@subjurnal	
end

If @subjurnal='STR'  
Begin  
     delete rghp where rghp.jurnal=@jurnal and rghp.subjurnal=@subjurnal
     delete acd where acd.jurnal=@jurnal and acd.subjurnal=@subjurnal	
end

If @subjurnal='TLK'  
Begin  
     delete rghp where rghp.jurnal=@jurnal and rghp.subjurnal=@subjurnal
     delete rhp where rhp.jurnal=@jurnal and rhp.subjurnal=@subjurnal  and rhp.period=@period	
     delete acd where acd.jurnal=@jurnal and acd.subjurnal=@subjurnal	 
end

If @subjurnal='CGR'  
Begin  
     delete rghp where rghp.jurnal=@jurnal and rghp.subjurnal=@subjurnal
     delete acd where acd.jurnal=@jurnal and acd.subjurnal=@subjurnal	
end

If @subjurnal='INO'  
Begin  
     delete acd where acd.jurnal=@jurnal and acd.subjurnal=@subjurnal	
end
/*
If @subjurnal=space(3) or @subjurnal='MSK'  
Begin  
insert into acd select * from (  
SELECT msk.msk AS jurnal, @period AS period, sub.acc, msk.date,     
           msk.val, space(15) as cct, msk.remark, 'K' as dk, 'MSK' AS subjurnal, 0 as adj
           FROM msk left outer join sub on msk.sub=sub.sub
           WHERE @jurnal=msk.msk
) as xacd  
insert into acd select * from (  
SELECT msk.msk AS jurnal, @period AS period, inv.accloc as acc, msk.date,     
           (((msd.price*msd.qty)*(100.00-msk.disc)/100.00)*(100.00-msd.disc)/100.00)*case when msk.ppn=2 then @V10Bagi11 else 1 end as val, 
           space(15) as cct, msd.remark, 'D' as dk, 'MSK' AS subjurnal, 0 as adj
           FROM msd left outer join msk on msd.msk=msk.msk
           left outer join inv on msd.inv=inv.inv
           WHERE @jurnal=msd.msk and msd.qty>0
) as xacd  
end

If @subjurnal=space(3) or @subjurnal='RMS'  
Begin  
insert into acd select * from (  
SELECT rms.rms AS jurnal, @period AS period, sub.acc, rms.date,     
           rms.val, space(15) as cct, rms.remark, 'D' as dk, 'RMS' AS subjurnal, 0 as adj
           FROM rms left outer join sub on rms.sub=sub.sub
           WHERE @jurnal=rms.rms
) as xacd  
insert into acd select * from (  
SELECT rms.rms AS jurnal, @period AS period, inv.accloc as acc, rms.date,     
           (((rmd.price*rmd.qty)*(100.00-rms.disc)/100.00)*(100.00-rmd.disc)/100.00)*case when rms.ppn=2 then @V10Bagi11 else 1 end as val, 
           space(15) as cct, rmd.remark, 'K' as dk, 'RMS' AS subjurnal, 0 as adj
           FROM rmd left outer join rms on rmd.rms=rms.rms
           left outer join inv on rmd.inv=inv.inv
           WHERE @jurnal=rmd.rms and rmd.qty>0
) as xacd  
end

If @subjurnal=space(3) or @subjurnal='KLR'  
Begin  
insert into acd select * from (  
SELECT klr.klr AS jurnal, @period AS period, sub.acc, klr.date,     
           klr.val, space(15) as cct, klr.remark, 'D' as dk, 'KLR' AS subjurnal, 0 as adj
           FROM klr left outer join sub on klr.sub=sub.sub
           WHERE @jurnal=klr.klr
) as xacd  
insert into acd select * from (  
SELECT klr.klr AS jurnal, @period AS period, inv.accrev as acc, klr.date,     
           (((kld.price*kld.qty)*(100.00-klr.disc)/100.00)*(100.00-kld.disc)/100.00)*case when klr.ppn=2 then @V10Bagi11 else 1 end as val, 
           inv.cctrev as cct, kld.remark, 'K' as dk, 'KLR' AS subjurnal, 0 as adj
           FROM kld left outer join klr on kld.klr=klr.klr
           left outer join inv on kld.inv=inv.inv
           WHERE @jurnal=kld.klr and kld.qty>0
) as xacd  
end

If @subjurnal=space(3) or @subjurnal='RKL'  
Begin  
insert into acd select * from (  
SELECT rkl.rkl AS jurnal, @period AS period, sub.acc, rkl.date,     
           rkl.val, space(15) as cct, rkl.remark, 'K' as dk, 'JSU' AS subjurnal, 0 as adj
           FROM rkl left outer join sub on rkl.sub=sub.sub
           WHERE @jurnal=rkl.rkl
) as xacd  
insert into acd select * from (  
SELECT rkl.rkl AS jurnal, @period AS period, inv.accrev as acc, rkl.date,     
           (((rkd.price*rkd.qty)*(100.00-rkl.disc)/100.00)*(100.00-rkd.disc)/100.00)*case when rkl.ppn=2 then @V10Bagi11 else 1 end as val, 
           inv.cctrev as cct, rkd.remark, 'D' as dk, 'JSU' AS subjurnal, 0 as adj
           FROM rkd left outer join rkl on rkd.rkl=rkl.rkl
           left outer join inv on rkd.inv=inv.inv
           WHERE @jurnal=rkd.rkl and rkd.qty>0
) as xacd  
end

If @subjurnal=space(3) or @subjurnal='JSU'  
Begin  
insert into acd select * from (  
SELECT jsu.jsu AS jurnal, @period AS period, sub.acc, jsu.date,     
           jsu.val, space(15) as cct, jsu.remark, case when jsu.dk=1 then 'K' else 'D' end as dk, 'JSU' AS subjurnal, 0 as adj
           FROM jsu left outer join sub on jsu.sub=sub.sub
           WHERE @jurnal=jsu.jsu
) as xacd  
insert into acd select * from (  
SELECT jsu.jsu AS jurnal, @period AS period, jsu.acc, jsu.date,     
           jsu.val, jsu.cct, jsu.remark, case when jsu.dk=1 then 'D' else 'K' end as dk, 'JSU' AS subjurnal, 0 as adj
           FROM jsu 
           WHERE @jurnal=jsu.jsu
) as xacd  
end

If @subjurnal=space(3) or @subjurnal='KAS'  
Begin  
insert into acd select * from (  
SELECT kas.kas AS jurnal, @period AS period, kas.acc, kas.date,     
           kas.val, space(15) as cct, kas.remark, case when kas.group_=1 then 'K' else 'D' end as dk, 'KAS' AS subjurnal, 0 as adj
           FROM kas
           WHERE @jurnal=kas.kas
) as xacd  

insert into acd select * from (  
SELECT kas.kas AS jurnal, @period AS period, sub.acc, kas.date,     
           abs(kad.val) as val, space(15) as cct, kad.remark,
           case when kas.group_=1 then  
                 case when kad.val>=0 then 'D' else 'K' end
           else
	    case when kad.val>=0 then 'K' else 'D' end
           end as dkl , 
           'KAS' AS subjurnal, 0 as adj
           FROM kad left outer join kas on kad.kas=kas.kas  
           left outer join  sub on kas.acc=sub.acc
           WHERE @jurnal=kad.kas
) as xacd  

end

If @jurnal<>space(15)
  Exec sp_SaveInv @subjurnal,@jurnal
*/








GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO














CREATE           procedure sp_estimasi @oms varchar(15)
as
select * into #umd from
(SELECT UMD.ACC, UMD.EST,umd.remark, umh.kurs*umd.val as estval, isnull(kad.val*kas.kurs,0) as actval FROM UMD
left outer join umh on umd.umh=umh.umh
left outer join kad on umd.est+umd.acc=kad.est+kad.acc
left outer join kas on kad.kas=kas.kas
where umh.oms=@oms and umd.dk='D' 
) as x

select #umd.ACC, #umd.remark, #umd.estval, #umd.actval, (#umd.estval- #umd.actval) as selisih from #umd
union all
SELECT kad.ACC, kad.remark, kad.val*kas.kurs as estval, kad.val*kas.kurs as actval,0 as selisih FROM kad
      left outer join kas on kad.kas=kas.kas
      where kas.oms=@oms and kad.dk='D' and kad.est not in (select est from #umd)
union all
select msk.msk,msd.remark,msd.val*msk.kurs as estval,msd.val*msk.kurs  as actval,0 as selisih from msd 
      left outer join msk on msd.msk=msk.msk where msk.oms=@oms













GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO





CREATE PROCEDURE sp_getoutklr  @pdate datetime, @klr char(15) 

AS

select * into #klr from  
(
select klr.klr, kld.inv, kld.loc, kld.qty as kldqty, kld.price
from kld
left outer join klr on kld.klr=klr.klr
where klr.klr=@klr
) as klr

select * into #rkl from  
(
select rkd.klr, rkd.inv, rkd.loc, sum(rkd.qty) as rkdqty
from rkd
left outer join rkl on rkd.rkl=rkl.rkl
where rkl.date<=@pdate and rkd.klr=@klr
group by rkd.klr, rkd.inv, rkd.loc
) as rkl


select * from 
(
select #klr.*, isnull(#rkl.rkdqty,000000000) as rkdqty
from #klr
left outer join #rkl on #klr.klr+#klr.inv+#klr.loc=#rkl.klr+#rkl.inv+#rkl.loc
) as outklr 
where kldqty-rkdqty > 0




GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO





CREATE PROCEDURE sp_getoutmsk  @pdate datetime, @msk char(15) 

AS

select * into #msk from  
(
select msk.msk, msd.inv, msd.loc, msd.qty as msdqty, msd.price
from msd
left outer join msk on msd.msk=msk.msk
where msk.msk=@msk
) as msk

select * into #rms from  
(
select rmd.msk, rmd.inv, rmd.loc, sum(rmd.qty) as rmdqty
from rmd
left outer join rms on rmd.rms=rms.rms
where rms.date<=@pdate and rmd.msk=@msk
group by rmd.msk, rmd.inv, rmd.loc
) as rms


select * from 
(
select #msk.*, isnull(#rms.rmdqty,000000000) as rmdqty
from #msk
left outer join #rms on #msk.msk+#msk.inv+#msk.loc=#rms.msk+#rms.inv+#rms.loc
) as outmsk 
where msdqty-rmdqty > 0




GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO






CREATE    PROCEDURE sp_getoutokl  @pdate datetime, @okl varchar(15), @jurnal varchar(15) 

AS

declare @period char(4)
set @period=dbo.date2period(@pdate)

select * into #okl from  
(
select okd.*,inv.name,(case when okd.unit=inv.unit2 then inv.besar else 1 end) besar
,inv.unit as unitk, okd.qty as okdqty
 from okd 
  left join inv on okd.inv=inv.inv 
  left join okl on okd.okl=okl.okl where okd.okl=@okl 
) as okl

select * into #rka from  
(
select rka.okl, rka.sub, rkb.inv, max(rka.loc) loc,sum(rkb.qty) as qty
from rkb left outer join rka on rka.rka=rkb.rka 
where rka.date<=@pdate and rka.okl=@okl 
group by rka.okl, rka.sub, rkb.inv
) as rka

select * into #realso from  
(
select realso.okl, realso.inv, max(realso.loc) loc, sum(realso.qty) as realsoqty
from realso
where realso.date<=@pdate and realso.okl=@okl and realso.jurnal<>@jurnal
group by realso.okl, realso.inv
--group by realso.okl, realso.inv, realso.loc
) as realso

select * from 
(
select #okl.*, isnull(#realso.realsoqty,000000000) as realsoqty,isnull(#rka.qty,000000000) as rkaqty
from #okl 
--left outer join #realso on #okl.okl+#okl.inv+#okl.loc=#realso.okl+#realso.inv+#realso.loc
left outer join #realso on #okl.okl+#okl.inv=#realso.okl+#realso.inv
left outer join #rka on #okl.okl+#okl.inv=#rka.okl+#rka.inv
) as outokl 
where okdqty-realsoqty+rkaqty > 0






GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO




CREATE  PROCEDURE sp_getoutoms  @pdate datetime, @oms varchar(15), @jurnal varchar(15) 

AS

declare @period char(4)
set @period=dbo.date2period(@pdate)

select * into #oms from  
(
select omd.*, omd.qty as omdqty,inv.name,
(case when omd.unit=inv.unit2 then inv.besar else 1 end) besar,inv.unit as unitk
from omd
left outer join oms on omd.oms=oms.oms
left outer join inv on omd.inv=inv.inv
where oms.oms=@oms
) as oms

select * into #realpo from  
(
select realpo.oms, realpo.inv, realpo.loc, sum(realpo.qty) as realpoqty
from realpo
where realpo.date<=@pdate and realpo.oms=@oms and realpo.jurnal<>@jurnal
group by realpo.oms, realpo.inv, realpo.loc
) as realpo

select * from 
(
select #oms.*, isnull(#realpo.realpoqty,000000000) as realpoqty
from #oms left outer join #realpo on #oms.oms+#oms.inv+#oms.loc=#realpo.oms+#realpo.inv+#realpo.loc
) as outoms 
where omdqty-realpoqty > 0



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO



CREATE PROCEDURE sp_getrghp @pdate datetime, @nobg varchar(15), @jurnal varchar(15) 

AS

declare @period char(4)
set @period=dbo.date2period(@pdate)

select * into #rgr from  
(
select rgr.nobg,rgr.bank, rgr.acbank, rgr.date, rgr.duedate, rgr.val, rgr.sub, rgr.acc, rgr.remark, rgr.acclawan, rgr.dk
from rgr
where rgr.period=@period and rgr.nobg=@nobg and period<>periodtrans
union all
select rghp.nobg,rghp.bank, rghp.acbank, rghp.date, rghp.duedate, rghp.val, rghp.sub, rghp.acc, rghp.remark, rghp.acclawan, rghp.dk
from rghp
where rghp.duedate <= @pdate and rghp.nobg=@nobg and group_=' '
) as rgr

select * into #outgr from  
(
select rghp.nobg,rghp.bank, rghp.acbank, rghp.date, rghp.duedate, rghp.val, rghp.sub, rghp.acc, rghp.remark, rghp.acclawan
from rghp
where rghp.duedate <= @pdate and rghp.nobg=@nobg and rghp.jurnal<>@jurnal and group_<>' ' and rghp.period=@period
) as outgr

select #rgr.* from #rgr left outer join #outgr on #rgr.nobg+#rgr.acc=#outgr.nobg+#outgr.acc
where #outgr.nobg is null


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO







CREATE    PROCEDURE sp_getrhp  @pdate datetime, @reff varchar(15), @jurnal varchar(15) 

AS

declare @period char(4)
set @period=dbo.date2period(@pdate)

select * into #outrhp from  
(
select rsb.jurnal, rsb.date, rsb.acc, rsb.dk,rsb.val as val, rsb.duedate, rsb.sub,rsb.kurs
from rsb
where rsb.jurnal=@reff and rsb.period=@period
union all
select rhp.jurnal, rhp.date, rhp.acc, rhp.dk, rhp.val, rhp.duedate, rhp.sub,rhp.kurs
from rhp
where rhp.jurnal=@reff and rhp.period=@period
) as outrhp

select * into #payhp from  
(
select payhp.reff as jurnal, payhp.sub, payhp.acc, sum(payhp.val) as val
from payhp
where payhp.reff=@reff and payhp.date <= @pdate and payhp.jurnal<>@jurnal and payhp.period=@period
group by payhp.reff, payhp.sub, payhp.acc
) as payhp

select acc, dk,jurnal,date,val,duedate,kurs from 
(
select #outrhp.acc, #outrhp.dk, #outrhp.jurnal, #outrhp.date, #outrhp.duedate, #outrhp.val-isnull(#payhp.val,000000000) as val,#outrhp.kurs
from #outrhp
left outer join #payhp on #outrhp.jurnal+#outrhp.sub+#outrhp.acc=#payhp.jurnal+#payhp.sub+#payhp.acc
) as outrhp
where val > 0 






GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO




CREATE  PROCEDURE sp_insertrealpo @subjurnal char(15), @jurnal char(15)  AS

If @subjurnal='VPO'  
Begin  
     insert into realpo 
	select @jurnal as jurnal, vpo.oms,vpo.date,vpo.sub,vpd.inv,vpo.loc,sum(vpd.qty) as qty, @subjurnal, vpo.period 
                        from vpd left outer join vpo on vpd.vpo=vpo.vpo
	           where vpd.vpo=@jurnal and vpo.oms<>' '          
                        group by vpo.oms,vpo.date,vpo.sub,vpd.inv,vpo.loc, vpo.period	             
end

/*
If @subjurnal='MSK'  
Begin  
     insert into realpo 
	select @jurnal, msd.oms,msk.date,msk.sub,msd.inv,msd.loc,sum(msd.qty) as qty, @subjurnal , msk.period 
                        from msd left outer join msk on msd.msk=msk.msk
	           where msd.msk=@jurnal and msd.oms<>' '
	           group by msd.oms,msk.date,msk.sub,msd.inv,msd.loc, msk.period
end
*/

If @subjurnal='LPB'  or @subjurnal='POO'
Begin  
     insert into realpo 
	select @jurnal, lpd.oms,lph.date,lph.sub,lpd.inv,lph.loc,sum(lpd.qty) as qty, @subjurnal , lph.period 
                        from lpd left outer join lph on lpd.lph=lph.lph
	           where lpd.lph=@jurnal and lpd.oms<>' '
	           group by lpd.oms,lph.date,lph.sub,lpd.inv,lph.loc, lph.period
end



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE  PROCEDURE sp_insertrealso @subjurnal char(15), @jurnal char(15)  AS
/*
declare @subjurnal char(15)
declare  @jurnal char(15)
set @subjurnal='SJH'
set @jurnal='SJL-0703-000001'
*/

If @subjurnal='VSO'  
Begin  
     insert into realso 
	select @jurnal as jurnal, vsd.okl,vso.date,vso.sub,vsd.inv,vso.loc,sum(vsd.qty) as qty, @subjurnal, vso.period
                        from vsd left outer join vso on vsd.vso=vso.vso
	           where vsd.vso=@jurnal and vsd.okl<>' '          
                        group by vsd.okl,vso.date,vso.sub,vsd.inv,vso.loc, vso.period
end

If @subjurnal='SJH'  
Begin  
     insert into realso 
	select @jurnal, sjd.okl,sjh.date,sjh.sub,sjd.inv,sjh.loc,sum(sjd.qty) as qty, @subjurnal, sjh.period
                        from sjd left outer join sjh on sjd.sjh=sjh.sjh
	           where sjd.sjh=@jurnal and sjd.okl<>' '
	           group by sjd.okl,sjh.date,sjh.sub,sjd.inv,sjh.loc, sjh.period
end

/*If @subjurnal='KLR'  
Begin  
     insert into realso 
	select @jurnal, kld.okl,klr.date,klr.sub,kld.inv,kld.loc,sum(kld.qty) as qty, @subjurnal, klr.period
                        from kld left outer join klr on kld.klr=klr.klr
	           where kld.klr=@jurnal and kld.okl<>' '
	           group by kld.okl,klr.date,klr.sub,kld.inv,kld.loc, klr.period
end*/



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO



CREATE PROCEDURE sp_invbep
  @lcperiod varchar(4),
  @lcloca varchar(15),
  @lclocz varchar(15)

as

select * into  #awal 
from
( 
  select inv.name as invname, rin.inv, loc.name as locname, rin.loc, rin.qlast, rin.vlast, inv.qtymin, inv.unit 
       from rin 
       left outer join inv on rin.inv=inv.inv
       left outer join loc on rin.loc=loc.kode 	
       where rin.period=@lcPeriod and rin.loc between @lcloca and @lclocz
) 
as oawal 

select inv,loc,sum(val) as klrval, sum(qty) as klrqty into #klr
from
( 
select kld.inv, kld.loc, kld.val, kld.qty 
from kld 
left outer join klr on kld.klr=klr.klr 
where kld.loc between @lcloca and @lclocz and klr.period=@lcperiod
union all
select rkd.inv, rkd.loc, rkd.val*-1 as val, rkd.qty*-1 as qty
from rkd
left outer join rkl on rkd.rkl=rkl.rkl 
where rkd.loc between @lcloca and @lclocz and rkl.period=@lcperiod
union all
select jid.inv, jid.loc, jid.val, jid.qty
from jid
left outer join jin on jid.jin=jin.jin
where jid.loc between @lcloca and @lclocz and jin.period=@lcperiod and jid.dk='K'
) 
as oklr group by inv,loc

select inv,loc,sum(val) as mskval, sum(qty) as mskqty into #msk
from
( 
select msd.inv, msd.loc, msd.val, msd.qty
from msd 
left outer join msk on msd.msk=msk.msk 
where msd.loc between @lcloca and @lclocz and msk.period=@lcperiod
union all
select rmd.inv, rmd.loc, rmd.val*-1 as val, rmd.qty*-1 as qty
from rmd
left outer join rms on rmd.rms=rms.rms 
where rmd.loc between @lcloca and @lclocz and rms.period=@lcperiod
union all
select jid.inv, jid.loc, jid.val, jid.qty
from jid
left outer join jin on jid.jin=jin.jin
where jid.loc between @lcloca and @lclocz and jin.period=@lcperiod and jid.dk='D'
) 
as omsk group by inv,loc

select #awal.*, 
       isnull(#msk.mskqty,0.00) as qdebet,
       isnull(#msk.mskval,0.00) as vdebet,	
       isnull(#klr.klrqty,0.00) as qkredit,
       isnull(#klr.klrval,0.00) as vkredit,
       (select top 1 klr.date from klr left outer join kld on klr.klr=kld.klr 
               where kld.loc between @lcloca and @lclocz and klr.period=@lcperiod order by date desc) as klrdate,
       (select top 1 msk.date from msk left outer join msd on msk.msk=msd.msk
               where msd.loc between @lcloca and @lclocz and msk.period=@lcperiod order by date desc) as mskdate
from #awal
left outer join #msk on #awal.loc+#awal.inv=#msk.loc+#msk.inv
left outer join #klr on #awal.loc+#awal.inv=#klr.loc+#klr.inv
order by 3,1


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO









CREATE       PROCEDURE sp_invlaba  @inva char(15), @invz char(15), @loca char(15), @locz char(15), @period varchar(4)

AS


select loc, inv, sum(val) as vjual,sum(qty) as qtyinv into #klr from  
(
select (select loc from sjh where sjh.sjh=kld.sjh) as loc, kld.inv,
(((kld.price*kld.qty1)*(100.00-klr.disc)/100.00)*(100.00-kld.disc)/100.00)*
case when klr.ppn=2 then (10.0000/11.0000) else 1 end *klr.kurs as val , kld.qty
from kld left outer join klr on kld.klr=klr.klr 
where klr.period=@period and kld.inv between @inva and @invz and kld.loc between @loca and @locz
union all
select rkl.loc,rkd.inv, (
(((rkd.price*rkd.qty1)*(100.00-rkl.disc)/100.00)*(100.00-rkd.disc)/100.00)*
case when rkl.ppn=2 then (10.0000/11.0000) else 1 end) * -1 * rkl.kurs as val ,rkd.qty*-1 as qty
from rkd left outer join rkl on rkd.rkl=rkl.rkl 
where rkl.period=@period and rkd.inv between @inva and @invz and rkd.loc between @loca and @locz
) 
as klr group by loc,inv

select loc, inv,sum(val) as vhpp,sum(qtysjh) qtysjh into #ind from  
(
select loc, inv, val * case when dk='K' then 1 else -1 end as val, (ind.qty * case when dk='K' then 1 else -1 end) as qtysjh
from ind
where ind.period=@period and ind.inv between @inva and @invz and ind.loc between @loca and @locz and ind.subjurnal in ('SJH','RKA')
) as ind group by loc, inv

select #klr.*,isnull(#ind.vhpp,0)  as vhpp, inv.name as invname,(select top 1 name from loc where loc.kode=#klr.loc) as locname, inv.unit ,#ind.qtysjh,#klr.qtyinv
from #klr left outer join #ind on #klr.loc+#klr.inv=#ind.loc+#ind.inv
left outer join inv on #klr.inv=inv.inv
order by #klr.loc, #klr.inv






GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO










CREATE        PROCEDURE sp_invlaba1  @inva char(15), @invz char(15), @loca char(15), @locz char(15), @period varchar(4)

AS

select loc, inv, sum(val) as vjual, date, jurnal,sub,sum(qty) as qtyinv into #klr from  
(
select (select loc from sjh where sjh.sjh=kld.sjh) as loc, kld.inv, klr.date, kld.sjh as jurnal, klr.sub ,
(((kld.price*kld.qty1)*(100.00-klr.disc)/100.00)*(100.00-kld.disc)/100.00)*
case when klr.ppn=2 then (10.0000/11.0000) else 1 end * klr.kurs as val,kld.qty
from kld left outer join klr on kld.klr=klr.klr 
where klr.period=@period and kld.inv between @inva and @invz and (select loc from sjh where sjh.sjh=kld.sjh) between @loca and @locz
union all
select rkl.loc,rkd.inv, rkl.date, rkl.rka as jurnal, rkl.sub ,
((((rkd.price*rkd.qty1)*(100.00-rkl.disc)/100.00)*(100.00-rkd.disc)/100.00)*
case when rkl.ppn=2 then (10.0000/11.0000) else 1 end) * -1 *rkl.kurs as val,rkd.qty*-1 as qty
from rkd left outer join rkl on rkd.rkl=rkl.rkl 
where rkl.period=@period and rkd.inv between @inva and @invz and rkd.loc between @loca and @locz
) 
as klr group by loc,inv, date, jurnal, sub

select loc, inv,sum(val) as vhpp, date, jurnal,sum(qty) as qtysjh into #ind from  
(
select loc, inv, val * case when dk='K' then 1 else -1 end as val, ind.date, ind.jurnal,ind.qty*case when dk='K' then 1 else -1 end as qty
from ind
where ind.period=@period and ind.inv between @inva and @invz and ind.loc between @loca and @locz and ind.subjurnal in ('SJH','RKA')
) as ind group by loc, inv, date, jurnal

select #klr.*,isnull(#ind.vhpp,0) as vhpp, inv.name as invname, (select top 1 name from loc where loc.kode=#klr.loc) as locname, sub.name as subname, inv.unit,#klr.qtyinv,#ind.qtysjh 
,(#klr.qtyinv-#ind.qtysjh)*isnull(#ind.vhpp/#ind.qtysjh,0) as varian
from #klr left outer join #ind on #klr.jurnal+#klr.loc+#klr.inv=#ind.jurnal+#ind.loc+#ind.inv
left outer join inv on #klr.inv=inv.inv
left outer join sub on #klr.sub=sub.sub
order by #klr.loc, #klr.inv, #klr.date, #klr.jurnal









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE       PROCEDURE sp_invlaba2  @suba char(15), @subz char(15), @period varchar(4)

AS


select sum(val) as vjual, date, jurnal, sub,sum(qty) as qtyinv into #klr from  
(
select klr.date, kld.sjh as jurnal, klr.sub ,
(((kld.price*kld.qty1)*(100.00-klr.disc)/100.00)*(100.00-kld.disc)/100.00)*
case when klr.ppn=2 then (10.0000/11.0000) else 1 end*klr.kurs as val,kld.qty
from kld left outer join klr on kld.klr=klr.klr 
where klr.period=@period and klr.sub between @suba and @subz 
union all
select rkl.date, rkl.rka as jurnal, rkl.sub ,
((((rkd.price*rkd.qty1)*(100.00-rkl.disc)/100.00)*(100.00-rkd.disc)/100.00)*
case when rkl.ppn=2 then (10.0000/11.0000) else 1 end) * -1 *rkl.kurs as val,rkd.qty*-1 as qty
from rkd left outer join rkl on rkd.rkl=rkl.rkl 
where rkl.period=@period and rkl.sub between @suba and @subz 
) 
as klr group by date, jurnal, sub

select sum(val) as vhpp, date, jurnal,sum(qty) as qtysjh into #ind from  
(
select val * case when dk='K' then 1 else -1 end as val, ind.date, ind.jurnal, ind.qty*case when dk='K' then 1 else -1 end as qty
from ind
where ind.period=@period and ind.subjurnal in ('SJH','RKA')
) as ind group by date, jurnal

select #klr.*,isnull(#ind.vhpp,0) as vhpp, sub.name as subname,#ind.qtysjh,#klr.qtyinv
,(#klr.qtyinv-#ind.qtysjh)*isnull(#ind.vhpp/#ind.qtysjh,0) as varian
from #klr left outer join #ind on #klr.jurnal=#ind.jurnal
left outer join sub on #klr.sub=sub.sub
order by #klr.sub, #klr.date, #klr.jurnal


--exec sp_invlaba2 '','z','0803'






GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO







CREATE     PROCEDURE sp_invlaba3  @suba char(15), @subz char(15), @period varchar(4)

AS


select inv, sum(val) as vjual, date, jurnal, sub,sum(qty) as qtyinv  into #klr from  
(
select kld.inv, klr.date, kld.sjh as jurnal, klr.sub ,
(((kld.price*kld.qty1)*(100.00-klr.disc)/100.00)*(100.00-kld.disc)/100.00)*
case when klr.ppn=2 then (10.0000/11.0000) else 1 end *klr.kurs as val, kld.qty
from kld left outer join klr on kld.klr=klr.klr 
where klr.period=@period and klr.sub between @suba and @subz
union all
select rkd.inv, rkl.date, rkl.rkl as jurnal, rkl.sub ,
((((rkd.price*rkd.qty1)*(100.00-rkl.disc)/100.00)*(100.00-rkd.disc)/100.00)*
case when rkl.ppn=2 then (10.0000/11.0000) else 1 end) * -1 *rkl.kurs as val,rkd.qty*-1 as qty
from rkd left outer join rkl on rkd.rkl=rkl.rkl 
where rkl.period=@period  and rkl.sub between @suba and @subz
) 
as klr group by inv, date, jurnal, sub

select inv,sum(val) as vhpp, date, jurnal,sum(qty) qtysjh  into #ind from  
(
select inv, val * case when dk='K' then 1 else -1 end as val, ind.date, ind.jurnal,ind.qty*case when dk='K' then 1 else -1 end as qty
from ind
where ind.period=@period and ind.subjurnal in ('SJH','RKA')
) as ind group by inv, date, jurnal

select #klr.*,isnull(#ind.vhpp,0) as vhpp, inv.name as invname, sub.name as subname,#ind.qtysjh,#klr.qtyinv
,(#klr.qtyinv-#ind.qtysjh)*isnull(#ind.vhpp/#ind.qtysjh,0) as varian
from #klr left outer join #ind on #klr.jurnal+#klr.inv=#ind.jurnal+#ind.inv
left outer join inv on #klr.inv=inv.inv
left outer join sub on #klr.sub=sub.sub
order by #klr.sub, #klr.date, #klr.jurnal







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO







CREATE     PROCEDURE sp_invlaba4  @inva char(15), @invz char(15), @suba char(15), @subz char(15), @period varchar(4)

AS

/*
select klr,sub, inv, sum(val) as vjual into #klr from  
(
select klr.klr,klr.sub, kld.inv, 
(((kld.price*kld.qty1)*(100.00-klr.disc)/100.00)*(100.00-kld.disc)/100.00)*
case when klr.ppn=2 then (10.0000/11.0000) else 1 end *klr.kurs as val
from kld left outer join klr on kld.klr=klr.klr 
where klr.period=@period and kld.inv between @inva and @invz and klr.sub between @suba and @subz
union all
select rkl.rkl,rkl.sub,rkd.inv, (
(((rkd.price*rkd.qty1)*(100.00-rkl.disc)/100.00)*(100.00-rkd.disc)/100.00)*
case when rkl.ppn=2 then (10.0000/11.0000) else 1 end) * -1*rkl.kurs as val
from rkd left outer join rkl on rkd.rkl=rkl.rkl 
where rkl.period=@period and rkd.inv between @inva and @invz and rkl.sub between @suba and @subz
) 
as klr group by klr,sub,inv

select  jurnal,inv,sum(val) as vhpp into #ind from  
(
select jurnal,inv, val * case when dk='K' then 1 else -1 end as val
from ind
where ind.period=@period and ind.inv between @inva and @invz and ind.subjurnal in ('SJH','RKA')
) as ind group by jurnal,inv


select #klr.*,isnull(#ind.vhpp,0)  as vhpp, inv.name as invname, sub.name as subname, inv.unit 
from #klr left outer join #ind on #klr.klr+#klr.inv=#ind.jurnal+#ind.inv
left outer join inv on #klr.inv=inv.inv
left outer join sub on #klr.sub=sub.sub
order by #klr.sub, #klr.inv

*/
-----

select klr,sub, inv, sum(val) as vjual,sum(qty) as qtyinv into #klr from  
(
select kld.sjh as klr,klr.sub, kld.inv, 
(((kld.price*kld.qty1)*(100.00-klr.disc)/100.00)*(100.00-kld.disc)/100.00)*
case when klr.ppn=2 then (10.0000/11.0000) else 1 end *klr.kurs as val,kld.qty 
from kld left outer join klr on kld.klr=klr.klr 
where klr.period=@period and kld.inv between @inva and @invz and klr.sub between @suba and @subz
union all
select rkl.rkl,rkl.sub,rkd.inv, (
(((rkd.price*rkd.qty1)*(100.00-rkl.disc)/100.00)*(100.00-rkd.disc)/100.00)*
case when rkl.ppn=2 then (10.0000/11.0000) else 1 end) * -1*rkl.kurs as val,rkd.qty*-1
from rkd left outer join rkl on rkd.rkl=rkl.rkl 
where rkl.period=@period and rkd.inv between @inva and @invz and rkl.sub between @suba and @subz
) 
as klr group by klr,sub,inv

select  jurnal,inv,sum(val) as vhpp,sum(qty) as qtysjh into #ind from  
(
select jurnal,inv, val * case when dk='K' then 1 else -1 end as val,ind.qty*case when dk='K' then 1 else -1 end as qty
from ind
where ind.period=@period and ind.inv between @inva and @invz and ind.subjurnal in ('SJH','RKA')
) as ind group by jurnal,inv


select #klr.*,isnull(#ind.vhpp,0)  as vhpp, inv.name as invname, sub.name as subname, inv.unit 
,#ind.qtysjh
into #LBRG from #klr left outer join #ind on #klr.klr+#klr.inv=#ind.jurnal+#ind.inv
left outer join inv on #klr.inv=inv.inv
left outer join sub on #klr.sub=sub.sub
order by #klr.sub, #klr.inv

select sub,inv,sum(vjual) as vjual,sum(vhpp) as vhpp,max(invname) as invname,max(subname) as subname,unit 
,sum(qtyinv) as qtyinv,sum(qtysjh) as qtysjh
from #LBRG
group by sub,inv,unit

--exec sp_invlaba4  '', 'z', '', 'z' , '0803' 




GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO





CREATE   PROCEDURE sp_invlabaqty  @inva char(15), @invz char(15), @loca char(15), @locz char(15), @period varchar(4)

AS


select loc, inv, sum(val) as vjual,sum(qty) as qtysjh into #klr from  
(
select (select loc from sjh where sjh.sjh=kld.sjh) as loc, kld.inv,
(((kld.price*kld.qty1)*(100.00-klr.disc)/100.00)*(100.00-kld.disc)/100.00)*
case when klr.ppn=2 then (10.0000/11.0000) else 1 end *klr.kurs as val , kld.qty
from kld left outer join klr on kld.klr=klr.klr 
where klr.period=@period and kld.inv between @inva and @invz and kld.loc between @loca and @locz
union all
select rkd.loc,rkd.inv, (
(((rkd.price*rkd.qty1)*(100.00-rkl.disc)/100.00)*(100.00-rkd.disc)/100.00)*
case when rkl.ppn=2 then (10.0000/11.0000) else 1 end) * -1 * rkl.kurs as val ,rkd.qty
from rkd left outer join rkl on rkd.rkl=rkl.rkl 
where rkl.period=@period and rkd.inv between @inva and @invz and rkd.loc between @loca and @locz
) 
as klr group by loc,inv

select loc, inv,sum(val) as vhpp,sum(qtyinv) qtyinv into #ind from  
(
select loc, inv, val * case when dk='K' then 1 else -1 end as val, (ind.qty * case when dk='K' then 1 else -1 end) as qtyinv
from ind
where ind.period=@period and ind.inv between @inva and @invz and ind.loc between @loca and @locz and ind.subjurnal in ('SJH','RKA')
) as ind group by loc, inv

select #klr.*,isnull(#ind.vhpp,0)  as vhpp, inv.name as invname,(select top 1 name from loc where loc.kode=#klr.loc) as locname, inv.unit ,#ind.qtyinv,#klr.qtysjh
from #klr left outer join #ind on #klr.loc+#klr.inv=#ind.loc+#ind.inv
left outer join inv on #klr.inv=inv.inv
order by #klr.loc, #klr.inv





GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO









CREATE      PROCEDURE sp_invmut
  @lcdatea datetime,
  @lcdatez datetime,	
  @lcinva varchar(15),
  @lcinvz varchar(15),
  @lcloca varchar(15),
  @lclocz varchar(15)

as

declare @lcperiod varchar(4)

set @lcperiod=dbo.date2period(@lcdatea) 


select inv,loc, sum(qlast) as qlast, sum(vlast) as vlast into  #awal 
from
( 
  select rin.inv, rin.loc, rin.qlast, rin.vlast 
       from rin 
       where rin.period=@lcPeriod and rin.inv between @lcinva and @lcinvz and rin.loc between @lcloca and @lclocz
  union all
  select ind.inv, ind.loc, sum(qty*case when dk='D' then 1 else -1 end) as qlast , sum(val*case when dk='D' then 1 else -1 end) as vlast 
      from ind
      where ind.period=@lcperiod and ind.date <@lcdatea and  ind.inv between @lcinva and @lcinvz and ind.loc between @lcloca and @lclocz group by ind.inv, ind.loc
) 
as oawal group by inv,loc

select inv.name as invname, #awal.inv, loc.name as locname, #awal.loc, 
       @lcdatea as date, space(15) as jurnal, 'BALANCE' as rem, 
       case when #awal.qlast >= 0 then #awal.qlast else 0.00 end as qdebet,
       case when #awal.vlast >= 0 then #awal.vlast else 0.00 end as vdebet, 
       (case when #awal.qlast < 0 then #awal.qlast else 0.00 end ) * -1 as qkredit,
       (case when #awal.vlast < 0 then #awal.vlast else 0.00 end ) * -1 as vkredit,
       ' ' as dk, inv.unit, 1 as urut,inv.unit2,inv.besar  
       from #awal
       left outer join inv on #awal.inv=inv.inv
       left outer join loc on #awal.loc=loc.kode
union all
select inv.name as invname, ind.inv, loc.name as locname, ind.loc, 
       ind.date as date, ind.jurnal as jurnal, ind.rem as rem, 
       case when ind.dk='D' then ind.qty else 0.00 end as qdebet, 
       case when ind.dk='D' then ind.val else 0.00 end as vdebet, 
       case when ind.dk='K' then ind.qty else 0.00 end as qkredit,
       case when ind.dk='K' then ind.val else 0.00 end as vkredit,
       ind.dk as dk, inv.unit, case when ind.subjurnal='OPN' then 2 else 1 end as urut,
       inv.unit2,inv.besar
       from ind
       left outer join inv on ind.inv=inv.inv
       left outer join loc on ind.loc=loc.kode 	
       where ind.inv between @lcinva and @lcinvz and 
       ind.date between @lcdatea and @lcdatez and 
       ind.loc between @lcloca and @lclocz  
order by 2,4,5,14,12,6







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO







CREATE    PROCEDURE sp_invpos
  @lcdatea datetime,
  @lcdatez datetime,	
  @lcinva varchar(15),
  @lcinvz varchar(15),
  @lcloca varchar(15),
  @lclocz varchar(15)

as

declare @lcperiod varchar(4)

set @lcperiod=dbo.date2period(@lcdatea) 


select invname, inv, locname, loc, sum(qlast) as qlast, sum(vlast) as vlast, qtymin, unit,unit2,besar  into  #awal 
from
( 
  select inv.name as invname, rin.inv, loc.name as locname, rin.loc, rin.qlast, rin.vlast, inv.qtymin, inv.unit,inv.unit2,inv.besar  
       from rin 
       left outer join inv on rin.inv=inv.inv
       left outer join loc on rin.loc=loc.kode 	
       where rin.period=@lcPeriod and rin.inv between @lcinva and @lcinvz and rin.loc between @lcloca and @lclocz
  union all
  select inv.name as invname, ind.inv, loc.name as locname, ind.loc, sum(qty*case when dk='D' then 1 else -1 end) as qlast , sum(val*case when dk='D' then 1 else -1 end) as vlast,inv.qtymin, inv.unit,inv.unit2,inv.besar   
      from ind
      left outer join inv on ind.inv=inv.inv
      left outer join loc on ind.loc=loc.kode 	
      where ind.period=@lcperiod and ind.date <@lcdatea and  ind.inv between @lcinva and @lcinvz and ind.loc between @lcloca and @lclocz group by inv.name, ind.inv, loc.name, ind.loc,inv.qtymin,inv.unit,inv.unit2,inv.besar   
) 
as oawal group by invname, inv, locname, loc,qtymin, unit,unit2,besar  


select * into  #ind
from
( 
select inv.name as invname, ind.inv, loc.name as locname, ind.loc, 
       sum(case when ind.dk='D' then ind.qty else 0.00 end) as qdebet, 
       sum(case when ind.dk='D' then ind.val else 0.00 end) as vdebet, 
       sum(case when ind.dk='K' then ind.qty else 0.00 end) as qkredit,
       sum(case when ind.dk='K' then ind.val else 0.00 end) as vkredit,
       inv.qtymin, inv.unit,inv.unit2,inv.besar 
       from ind
       left outer join inv on ind.inv=inv.inv
       left outer join loc on ind.loc=loc.kode 	
       where ind.inv between @lcinva and @lcinvz and 
       ind.date between @lcdatea and @lcdatez and 
       ind.loc between @lcloca and @lclocz  
       group by inv.name, ind.inv, loc.name, ind.loc,inv.qtymin,unit,unit2,besar
) 
as oind

select isnull(#awal.inv,#ind.inv) as inv,
       isnull(#awal.invname,#ind.invname) as invname,
       isnull(#awal.loc,#ind.loc) as loc,
       isnull(#awal.locname,#ind.locname) as locname,
       isnull(#awal.qtymin,#ind.qtymin) as qtymin,
       isnull(#awal.unit,#ind.unit) as unit,
       isnull(#awal.qlast,0.00) as qlast,
       isnull(#awal.vlast,0.00) as vlast,
       isnull(#ind.qdebet,0.00) as qdebet,
       isnull(#ind.vdebet,0.00) as vdebet,
       isnull(#ind.qkredit,0.00) as qkredit,
       isnull(#ind.vkredit,0.00) as vkredit,
       isnull(#awal.unit2,#ind.unit2) as unit2,
 	isnull(#awal.besar,#ind.besar) as besar
from #ind 
full outer join #awal on #ind.inv+#ind.loc=#awal.inv+#awal.loc
order by 3,1





GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO



CREATE PROCEDURE sp_invturn
  @lcperiod varchar(4)
as

select invname, inv, sum(qlast) as qlast, unit  into  #awal 
from
( 
  select inv.name as invname, rin.inv, rin.qlast, inv.qtymin, inv.unit  
       from rin 
       left outer join inv on rin.inv=inv.inv
       where rin.period=@lcPeriod 
) 
as oawal group by invname, inv, unit


select * into  #ind
from
( 
select inv.name as invname, ind.inv, 
       sum(case when ind.dk='D' then ind.qty else 0.00 end) as qdebet, 
       sum(case when ind.dk='K' then ind.qty else 0.00 end) as qkredit,
       inv.unit 
       from ind
       left outer join inv on ind.inv=inv.inv       
       where ind.period=@lcperiod
       group by inv.name, ind.inv,unit
) 
as oind

select * into #ind1
from
(
select isnull(#awal.inv,#ind.inv) as inv,
       isnull(#awal.invname,#ind.invname) as invname,
       isnull(#awal.unit,#ind.unit) as unit,
       isnull(#awal.qlast,0.00) as qlast,
       isnull(#ind.qdebet,0.00) as qdebet,
       isnull(#ind.qkredit,0.00) as qkredit
from #ind 
full outer join #awal on #ind.inv=#awal.inv
) as ind1

select inv,invname,unit,qlast,qdebet,qkredit,
        case when (qlast+qdebet-qkredit)=0 then 0 else (qdebet*2)/(qlast+qdebet-qkredit) end as qtyputar
        from #ind1


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO



CREATE     PROCEDURE sp_kasBUS @pdatea datetime,@pdatez datetime, @pacca varchar(15), @paccz varchar(15) ,@flag varchar(1)
AS
declare @period char(4)
set @period=dbo.date2period(@pdatea)

select cgr.cgr as jurnal,kag.val,kas.acc,kas.kurs into #ACDUS1 from cgr inner join kag 
on cgr.nobg=kag.nobg inner join kas on kag.kas=kas.kas where cgr.period=@period and kas.kurs>1 and kas.acc like '1101%'
union all
select umh.umh,umd.val,umd.acc,umh.kurs from umh left outer join umd on umh.umh=umd.umh where umh.kurs>1 and period=@period and umd.acc like '1101%'
union all
select kas.kas,kas.val,kas.acc,kas.kurs from kas where kas.kurs>1 and period=@period and acc like '1101%' and kas.acc like '1101%' and kas.val<>0
union all
select kad.kas,kad.val,kad.acc,kas.kurs from kad left outer join kas on kad.kas=kas.kas where kas.kurs>1 and kas.period=@period and kad.acc like '1101%'
union all
select jsu.jsu,jsu.val,jsu.acc,jsu.kurs from jsu where jsu.kurs>1 and period=@period and acc like '1101%' and jsu.acc like '1101%'
union all
select jsd.jsu,jsd.val,jsd.acc,jsu.kurs from jsu left outer join jsd on jsu.jsu=jsd.jsu where jsu.kurs>1 and jsu.period=@period and jsd.acc like '1101%'
union all
select kad.kas,kad.est,kad.acc,isnull(kad.est,0)/kad.val from kad left outer join kas on kad.kas=kas.kas where kad.est<>0 and kas.period=@period and kad.acc like '1101%'
 
--select #acdus1
select #acdUS1.*,acd.period,acd.rem,acd.date,acd.dk,acd.val as valrp into #acdus from #acdus1 left outer join ACD on #acdus1.jurnal=acd.jurnal and #acdus1.acc=acd.acc
where acd.acc like '1101%' and period=@period 
union all
--saldo awal
select '',isnull(racus.val,0) val,racus.acc,isnull(racus.valrp,0)/isnull(racus.val,1),racus.period,'Saldo Awal',@pdatea,case when racus.val<0 then 'K' else 'D' end,racus.valrp from racus where racus.period=@period and racus.acc like '1101%' 

if @flag='0'
begin
  select *,(case when  #acdUS.dk='K' then #acdUS.val else 0 end) as kredit,
 (case when  #acdUS.dk='D' then #acdUS.val else 0 end) as debet
  from #acdus where (#acdus.acc between @pacca and @paccz) order by #acdus.acc,#acdus.date,#acdus.jurnal
end

if @flag='1'
begin
delete from racus where racus.period=(select dbo.nextperiod(@period,1))
insert into racus 
  select dbo.nextperiod(#acdus.period,1)as period,acc,sum(case when  #acdUS.dk='D' then #acdUS.val else 0 end) as debet,
  sum(case when  #acdUS.dk='K' then #acdUS.val else 0 end) as kredit,
  sum(case when  #acdUS.dk='D' then #acdUS.val else -#acdUS.val end) as val,sum(valrp) as valrp from #acdus
  group by #acdus.period,#acdus.acc
end







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO







--exec sp_oklout '20070801','20070820','','z','','z'


CREATE        PROCEDURE sp_oklout @pdatea datetime, @pdatez datetime, @suba char(15), @subz char(15), @inva char(15), @invz char(15)

AS

declare @period char(4)
set @period=dbo.date2period(@pdatea)

select okl,date,sub,inv,sum(qtyso-qty) as qtyso into #outso from  
(
select rso.okl,rso.date, rso.sub,rso.inv,rso.qty as qtyso,rso.qtyout as qty
from rso
where rso.sub between @suba and @subz and rso.inv between @inva and @invz and rso.period=@period
union all
select outso.okl,outso.date, outso.sub,outso.inv,outso.qty as qtyso, 0 as qty
from outso
where outso.sub between @suba and @subz and outso.inv between @inva and @invz and outso.date between @pdatea and  @pdatez
) as outso
group by okl,date,sub,inv

select * into #realso from  
(
select realso.okl, realso.sub, realso.inv, sum(realso.qty) as qty
from realso
where realso.sub between @suba and @subz and realso.date between @pdatea and  @pdatez and realso.inv between @inva and @invz
group by realso.okl, realso.sub, realso.inv
) as realso

select * into #rka from  
(
select rka.okl, rka.sub, rkb.inv, max(rka.loc) loc,sum(rkb.qty) as qty
from rkb left outer join rka on rka.rka=rkb.rka 
where rka.sub between @suba and @subz and rkb.inv between @inva and @invz and rka.date between @pdatea and  @pdatez
group by rka.okl, rka.sub, rkb.inv
) as rka

select #outso.okl as jurnal, #outso.date, #outso.sub,okl.shiptoaddress, #outso.inv, 
#outso.qtyso ,isnull(#rka.qty,0)as rkaqty,isnull(#realso.qty,0) as qtyklr,sub.name as subname, inv.name as invname,
isnull(subto.aliasname,'') as aliasname,okl.nopoc,
(select top 1 (price*case when okd.unit=inv.unit then 1 else 1/inv.besar end)
from okd where okd.okl=#outso.okl and #outso.inv=okd.inv) as price,okl.cur
from #outso
left outer join #realso on #outso.okl+#outso.inv=#realso.okl+#realso.inv
left outer join #rka on #outso.okl+#outso.inv=#rka.okl+#rka.inv
left outer join sub on #outso.sub=sub.sub
left outer join inv on #outso.inv=inv.inv
left outer join okl on okl.okl=#outso.okl
left outer join subto on cast(okl.shiptoaddress as char(80))=cast(subto.shiptoaddress as char(80))

order by 3,2,1






GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO






CREATE    PROCEDURE sp_oklout1 @suba char(15), @subz char(15), @okla char(15), @oklz char(15), @period varchar(4)

AS

select okl,date,sub,inv,sum(qtyso-qty) as qtyso into #outso from  
(
select rso.okl,rso.date, rso.sub,rso.inv,rso.qty as qtyso,rso.qtyout as qty
from rso
where rso.sub between @suba and @subz and rso.okl between @okla and @oklz and rso.period=@period
union all
select outso.okl,outso.date, outso.sub,outso.inv,outso.qty as qtyso, 0 as qty
from outso
where outso.sub between @suba and @subz and outso.okl between @okla and @oklz and dbo.date2period(outso.date)=@period
) as outso
group by okl,date,sub,inv

select * into #realso from  
(
select realso.okl, realso.sub, realso.inv, realso.qty, realso.jurnal as klr, realso.date
from realso
where realso.sub between @suba and @subz  --and dbo.date2period(realso.date)=@period
      and realso.okl between @okla and @oklz
union all
select rka.okl, rka.sub, rkb.inv,-rkb.qty,rka.rka,rka.date
from rkb left outer join rka on rka.rka=rkb.rka 
where rka.sub  between @suba and @subz   
      and rka.okl between @okla and @oklz

) as realso

select #outso.sub, #outso.date, #outso.okl as jurnal, #outso.qtyso, #outso.inv, inv.name as invname, 
isnull(#realso.date,space(20)) as klrdate, isnull(#realso.klr,space(15)) as klr, sub.name as subname,
isnull(#realso.qty,0) as qtyklr, 0 as saldo,okl.nopoc,isnull(subto.aliasname,'') as aliasname,
(select top 1 (price*case when okd.unit=inv.unit then 1 else 1/inv.besar end)
from okd where okd.okl=#outso.okl and #outso.inv=okd.inv) as price,okl.cur
from #outso
left outer join #realso on #outso.okl+#outso.inv=#realso.okl+#realso.inv
left outer join sub on #outso.sub=sub.sub
left outer join inv on #outso.inv=inv.inv
left outer join okl on #outso.okl=okl.okl
left outer join subto on cast(okl.shiptoaddress as char(80))=cast(subto.shiptoaddress as char(80))
order by 1,2,3,4,5,7




GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO



CREATE PROCEDURE sp_omsout @pdatea datetime, @pdatez datetime, @suba char(15), @subz char(15), @inva char(15), @invz char(15)

AS

declare @period char(4)
set @period=dbo.date2period(@pdatea)

select oms,date,sub,inv,sum(qtypo-qty) as qtypo into #outpo from  
(
select rpo.oms,rpo.date, rpo.sub,rpo.inv,rpo.qty as qtypo,rpo.qtyout as qty
from rpo
where rpo.sub between @suba and @subz and rpo.inv between @inva and @invz and rpo.period=@period
union all
select outpo.oms,outpo.date, outpo.sub,outpo.inv,outpo.qty as qtypo, 0 as qty
from outpo
where outpo.sub between @suba and @subz and outpo.inv between @inva and @invz and outpo.date between @pdatea and  @pdatez
) as outpo
group by oms,date,sub,inv

select * into #realpo from  
(
select realpo.oms, realpo.sub, realpo.inv, sum(realpo.qty) as qty
from realpo
where realpo.sub between @suba and @subz and realpo.date between @pdatea and  @pdatez and realpo.inv between @inva and @invz
group by realpo.oms, realpo.sub, realpo.inv
) as realpo



select #outpo.oms as jurnal, #outpo.date, #outpo.sub, #outpo.inv, 
#outpo.qtypo , isnull(#realpo.qty,0) as qtymsk,sub.name as subname, inv.name as invname
from #outpo
left outer join #realpo on #outpo.oms+#outpo.inv=#realpo.oms+#realpo.inv
left outer join sub on #outpo.sub=sub.sub
left outer join inv on #outpo.inv=inv.inv


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO



CREATE PROCEDURE sp_omsout1 @suba char(15), @subz char(15), @omsa char(15), @omsz char(15), @period varchar(4)

AS

select oms,date,sub,inv,sum(qtypo-qty) as qtypo into #outpo from  
(
select rpo.oms,rpo.date, rpo.sub,rpo.inv,rpo.qty as qtypo,rpo.qtyout as qty
from rpo
where rpo.sub between @suba and @subz and rpo.oms between @omsa and @omsz and rpo.period=@period
union all
select outpo.oms,outpo.date, outpo.sub,outpo.inv,outpo.qty as qtypo,0 as qty
from outpo
where outpo.sub between @suba and @subz and outpo.oms between @omsa and @omsz and dbo.date2period(outpo.date)=@period
) as outpo
group by oms,date,sub,inv

select * into #realpo from  
(
select realpo.oms, realpo.sub, realpo.inv, realpo.qty, realpo.jurnal as msk, realpo.date
from realpo
where realpo.sub between @suba and @subz 
--and dbo.date2period(realpo.date)=@period 
and realpo.oms between @omsa and @omsz
) as realpo

select #outpo.sub, #outpo.date, #outpo.oms as jurnal, #outpo.qtypo, #outpo.inv, inv.name as invname, 
isnull(#realpo.date,space(20)) as mskdate, isnull(#realpo.msk,space(15)) as msk, sub.name as subname,
isnull(#realpo.qty,0) as qtymsk, 0 as saldo
from #outpo
left outer join #realpo on #outpo.oms+#outpo.inv=#realpo.oms+#realpo.inv
left outer join sub on #outpo.sub=sub.sub
left outer join inv on #outpo.inv=inv.inv
order by 1,2,3,4,5,7


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO



CREATE  PROCEDURE sp_omsout2 @suba char(15), @subz char(15), @prqa char(15), @prqz char(15),@inva char(15), @invz char(15)
as
begin
select prd.inv,prq.prq,prq.date,prd.qty,prd.unit,prq.duedate as dateneed into  #prq from prd left outer join prq on prd.prq=prq.prq
where (prd.inv between @inva and @invz) and (prq.prq between @prqa and @prqz)
select oms.sub,omd.inv,omd.oms,oms.date,omd.qty,omd.unit,oms.prq,omd.price into #oms from omd left outer join oms on omd.oms=oms.oms
where (oms.sub between @suba and @subz) and (oms.prq between @prqa and @prqz)
select lpd.inv,lph.lph,lph.date,lpd.qty,lpd.unit,lph.oms into #lpb from lpd left outer join lph on lpd.lph=lph.lph
where (lph.sub between @suba and @subz)

select #prq.inv,inv.name as invname,#prq.prq,#prq.date,#prq.qty,#prq.unit,#prq.dateneed,
#oms.oms,#oms.sub,sub.name as subname,#oms.date as dateoms,#oms.qty as omsqty,#oms.unit as unitoms,#oms.price, 
#lpb.lph,#lpb.date as lpbdate,#lpb.qty as qtylpb,#lpb.unit as unitlpb
from #prq left outer join #oms on #prq.prq+#prq.inv=#oms.prq+#oms.inv
left outer join #lpb on #oms.oms+#oms.inv=#lpb.oms+#lpb.inv   
left outer join inv on #prq.inv=inv.inv
left outer join sub on #oms.sub=sub.sub
end



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO





CREATE PROCEDURE sp_outklr  @sub char(15), @pdate datetime, @klr char(15) 

AS


select * into #klr from  
(
select kld.klr, klr.date, klr.sub, kld.inv, kld.loc, sum(kld.qty) as kldqty, klr.remark
from kld
left outer join klr on kld.klr=klr.klr
where klr.sub=@sub and klr.date<=@pdate
group by kld.klr, klr.date, klr.sub, kld.inv, kld.loc, klr.remark
) as klr


select * into #rkl from  
(
select rkd.klr, rkl.date, rkl.sub, rkd.inv, rkd.loc, sum(rkd.qty) as rkdqty
from rkd
left outer join rkl on rkd.rkl=rkl.rkl
where rkl.sub=@sub and rkl.date<=@pdate and rkd.klr<>' ' and rkd.klr<>@klr
group by rkd.klr, rkl.date, rkl.sub, rkd.inv, rkd.loc
) as rkl


select date,klr,remark from 
(
select #klr.*, isnull(#rkl.rkdqty,000000000) as rkdqty
from #klr
left outer join #rkl on #klr.klr+#klr.inv+#klr.loc=#rkl.klr+#rkl.inv+#rkl.loc
) as outklr 
where kldqty-rkdqty > 0
group by klr, date,remark
order by date, klr




GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









create  PROCEDURE sp_outklr1  @klr char(15) 

AS

select kld.*,inv.name,(case when kld.unit=inv.unit2 then inv.besar else 1 end) besar
,inv.unit as unitk,kld.price
 from kld left join inv on kld.inv=inv.inv left join klr on kld.klr=klr.klr where kld.klr=@klr 







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO






CREATE     PROCEDURE sp_outlpb1  @oms char(15) ,@sub char(15)

AS

select lpd.*,inv.name,lph.date 
from lpd 
left join inv on lpd.inv=inv.inv 
left join lph on lph.lph=lpd.lph 
where lph.oms=@oms and lph.sub=@sub

/*
select max(lph.lph)lph,max(lph.sub)sub,max(lph.remark)remark,max(lph.loc)loc,sum(lpd.qty)qty,sum(lpd.price*lpd.qty)val 
from lpd 
left join inv on lpd.inv=inv.inv 
left join lph on lph.lph=lpd.lph 
where lph.oms=@oms and lph.sub=@sub
group by lpd.lph
*/






GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE sp_outmsk  @sub char(15), @pdate datetime, @msk char(15) 

AS


select * into #msk from  
(
select msd.msk, msk.date, msk.sub, msd.inv, msd.loc, sum(msd.qty) as msdqty, msk.remark
from msd
left outer join msk on msd.msk=msk.msk
where msk.sub=@sub and msk.date<=@pdate
group by msd.msk, msk.date, msk.sub, msd.inv, msd.loc, msk.remark
) as msk


select * into #rms from  
(
select rmd.msk, rms.date, rms.sub, rmd.inv, rmd.loc, sum(rmd.qty) as rmdqty
from rmd
left outer join rms on rmd.rms=rms.rms
where rms.sub=@sub and rms.date<=@pdate and rmd.msk<>' ' and rmd.msk<>@msk
group by rmd.msk, rms.date, rms.sub, rmd.inv, rmd.loc
) as rms


select date,msk,remark from 
(
select #msk.*, isnull(#rms.rmdqty,000000000) as rmdqty
from #msk
left outer join #rms on #msk.msk+#msk.inv+#msk.loc=#rms.msk+#rms.inv+#rms.loc
) as outmsk 
where msdqty-rmdqty > 0
group by msk, date,remark
order by date, msk





GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO



CREATE PROCEDURE sp_outokl  @suba char(15), @subz char(15), @pdatea datetime, @pdatez datetime, @jurnal char(15) 

AS

declare @period char(4)
set @period=dbo.date2period(@pdatea)

select * into #outso from  
(
select rso.okl,rso.date, rso.sub,rso.inv,rso.loc,rso.qty as qtypo, rso.qtyout as qty, rso.remark
from rso
where rso.sub between @suba and @subz and rso.period=@period
union all
select outso.okl,outso.date, outso.sub,outso.inv,outso.loc,outso.qty as qtypo, 0 as qty, outso.remark
from outso
where outso.sub between @suba and @subz and outso.date between @pdatea and  @pdatez
) as outso

select * into #realso from  
(
select realso.okl, realso.sub, realso.inv, realso.loc, sum(realso.qty) as qty
from realso
where realso.sub between @suba and @subz and realso.date between @pdatea and  @pdatez and realso.jurnal<>@jurnal
group by realso.okl, realso.sub, realso.inv, realso.loc
) as realso


select date,okl,remark from 
(
select #outso.*, isnull(#realso.qty,000000000) as realsoqty
from #outso
left outer join #realso on #outso.okl+#outso.inv+#outso.loc=#realso.okl+#realso.inv+#realso.loc
) as outokl 
where qtypo-(qty+realsoqty) > 0
group by okl, date,remark
order by date, okl


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO







CREATE   PROCEDURE sp_outokl2  @okl char(15) 

AS

select okd.*,inv.name,(case when okd.unit=inv.unit2 then inv.besar else 1 end) besar
,inv.unit as unitk,okd.price
 from okd left join inv on okd.inv=inv.inv left join okl on okd.okl=okl.okl where okd.okl=@okl 





GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE      PROCEDURE sp_outoklB  @pdatea datetime, @pdatez datetime, @jurnal char(15) 

AS
declare @period char(4)
set @period=dbo.date2period(@pdatea)

select * into #outso from  
(
select rso.okl,rso.date, rso.sub,rso.inv,rso.loc,rso.qty as qtypo, rso.qtyout as qty, rso.remark
from rso
where rso.period=@period
union all
select outso.okl,outso.date, outso.sub,outso.inv,outso.loc,outso.qty as qtypo, 0 as qty, outso.remark
from outso
where outso.date between @pdatea and  @pdatez
) as outso

select * into #realso from  
(
select realso.okl, realso.sub, realso.inv, max(realso.loc) loc, sum(realso.qty) as qty
from realso
where realso.date between @pdatea and  @pdatez and realso.jurnal<>@jurnal
group by realso.okl, realso.sub, realso.inv
) as realso


select * into #rka from  
(
select rka.okl, rka.sub, rkb.inv, max(rka.loc) loc,sum(rkb.qty) as qty
from rkb left outer join rka on rka.rka=rkb.rka 
where rka.date between @pdatea and  @pdatez and rka.rka<>@jurnal
group by rka.okl, rka.sub, rkb.inv
) as rka

select date,okl,remark into #tmp from 
(
select #outso.*, isnull(#realso.qty,000000000) as realsoqty,isnull(#rka.qty,000000000) as rkaqty
from #outso
left outer join #realso on #outso.okl+#outso.inv=#realso.okl+#realso.inv
left outer join #rka on #outso.okl+#outso.inv=#rka.okl+#rka.inv
) as outokl 
where qtypo-(qty+realsoqty)+rkaqty > 0
group by okl, date,remark
order by date, okl


select okl.okl,okl.date,okl.remark,okl.loc,sub.sub,sub.name,
kurs,cur,sub.address,sub.city,okl.shiptoname,okl.shiptoaddress from okl 
left outer join sub on okl.sub=sub.sub
where ((okl.okl in (select okl from #tmp)) or okl=@jurnal) and okl.closed<>1





GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO



CREATE PROCEDURE sp_outoms  @suba char(15), @subz char(15), @pdatea datetime, @pdatez datetime, @jurnal char(15) 

AS

declare @period char(4)
set @period=dbo.date2period(@pdatea)

select * into #outpo from  
(
select rpo.oms,rpo.date, rpo.sub,rpo.inv,rpo.loc,rpo.qty as qtypo, rpo.qtyout as qty, rpo.remark
from rpo
where rpo.sub between @suba and @subz and rpo.period=@period
union all
select outpo.oms,outpo.date, outpo.sub,outpo.inv,outpo.loc,outpo.qty as qtypo, 0 as qty, outpo.remark
from outpo
where outpo.sub between @suba and @subz and outpo.date between @pdatea and  @pdatez
) as outpo

select * into #realpo from  
(
select realpo.oms, realpo.sub, realpo.inv, realpo.loc, sum(realpo.qty) as qty
from realpo
where realpo.sub between @suba and @subz and realpo.date between @pdatea and  @pdatez and realpo.jurnal<>@jurnal
group by realpo.oms, realpo.sub, realpo.inv, realpo.loc
) as realpo


select date,oms,remark from 
(
select #outpo.*, isnull(#realpo.qty,000000000) as realpoqty
from #outpo
left outer join #realpo on #outpo.oms+#outpo.inv+#outpo.loc=#realpo.oms+#realpo.inv+#realpo.loc
) as outoms 
where qtypo-(qty+realpoqty) > 0
group by oms, date,remark
order by date, oms


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO











CREATE       PROCEDURE sp_outoms1  @oms char(15) 
AS

select omd.*,inv.name,(case when omd.unit=inv.unit2 then inv.besar else 1 end) besar
,inv.unit as unitk,omd.price
 from omd left join inv on omd.inv=inv.inv left join oms on omd.oms=oms.oms where omd.oms=@oms 




GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO










CREATE      PROCEDURE sp_outomsA  @pdate datetime,@group int
AS
begin
   select oms.oms,oms.date,oms.cur,oms.kurs,oms.ppn,oms.disc,oms.remark,
       oms.loc,oms.cct,oms.sub,sub.name as subname, sub.address,sub.city,sub.ceknpwp from oms 
       left outer join sub on oms.sub=sub.sub  
   where oms.closedval<>1
       and oms.date<=@pdate and oms.group_=@group 
   order by oms.oms,oms.date
end









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO











CREATE        procedure sp_outomsB  @pdatea datetime,@Pdatez datetime, @jurnal varchar(15)
AS

declare @period char(4)
set @period=dbo.date2period(@pdatea)

select * into #outpo from  
(
select rpo.oms,rpo.date, rpo.sub,rpo.inv,rpo.loc,rpo.qty as qtypo, rpo.qtyout as qty, rpo.remark
from rpo
where rpo.period=@period
union all
select outpo.oms,outpo.date, outpo.sub,outpo.inv,outpo.loc,outpo.qty as qtypo, 0 as qty, outpo.remark
from outpo
where outpo.date between @pdatea and  @pdatez
) as outpo

select * into #realpo from  
(
select realpo.oms, realpo.sub, realpo.inv, realpo.loc, sum(realpo.qty) as qty
from realpo
where realpo.date between @pdatea and  @pdatez and realpo.jurnal<>@jurnal
group by realpo.oms, realpo.sub, realpo.inv, realpo.loc
) as realpo


select date,oms,remark into #tmp from 
(
select #outpo.*, isnull(#realpo.qty,000000000) as realpoqty
from #outpo
left outer join #realpo on #outpo.oms+#outpo.inv+#outpo.loc=#realpo.oms+#realpo.inv+#realpo.loc
) as outoms 
where qtypo-(qty+realpoqty) > 0 
group by oms, date,remark
order by date, oms

----tambahan
select oms.oms,sub.name as subname,oms.date,oms.remark,oms.loc,oms.cct,oms.sub,oms.cur,
   oms.kurs,oms.ppn,oms.disc, sub.address,sub.city 
   from oms left outer join sub on oms.sub=sub.sub  
where ((oms in (select oms from #tmp )) or oms=@jurnal) and oms.closed<>1












GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO











CREATE       PROCEDURE sp_outprq  @prq char(15) ,@date datetime,@cur varchar(6)
AS

select prd.*,inv.name,(case when prd.unit=inv.unit2 then inv.besar else 1 end) besar ,
(case when prd.unit=inv.unit2 then 
  (select top 1 isnull(price2,0) from hrd where hrd.inv=prd.inv and hrd.tgl<=@date and hrd.cur=@cur order by tgl desc) 
 else 
  (select top 1 isnull(price1,0) from hrd where hrd.inv=prd.inv and hrd.tgl<=@date and hrd.cur=@cur order by tgl desc) end) as pricek
,inv.unit as unitk
from prd left join inv on prd.inv=inv.inv left join prq on prd.prq=prq.prq 
where prq.prq=@prq








GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO







CREATE PROCEDURE sp_outrghp @pdatea datetime, @pdatez datetime, @dk varchar(1), @jurnal varchar(15), @subjurnal varchar(3) 

AS

declare @period char(4)
set @period=dbo.date2period(@pdatea)

select * into #rgr from  
(

--select rgr.nobg,rgr.date, rgr.acc, rgr.remark, rgr.val, rgr.dk
select rgr.nobg, rgr.date, rgr.acc, rgr.remark, rgr.val, rgr.dk,rgr.bank, rgr.acbank, rgr.duedate, rgr.sub, rgr.acclawan, rgr.jurnal, rgr.subjurnal
from rgr
where rgr.period=@period and rgr.dk=@dk and period<>periodtrans
union all
--select rghp.nobg,rghp.date, rghp.acc, rghp.remark, rghp.val, rghp.dk
select rghp.nobg, rghp.date, rghp.acc, rghp.remark, rghp.val, rghp.dk,rghp.bank, rghp.acbank, rghp.duedate, rghp.sub, rghp.acclawan, rghp.jurnal, rghp.subjurnal
from rghp
where rghp.date between @pdatea and  @pdatez and rghp.group_=' ' and rghp.dk=@dk
) as rgr

select * into #outgr from  
(
select rghp.nobg,rghp.date, rghp.acc, rghp.remark, rghp.val
from rghp
where rghp.date between @pdatea and  @pdatez and rghp.group_<>' ' and jurnal<>@jurnal and rghp.dk=case when @dk='D' then 'K' else 'D' end
) as outgr

select #rgr.nobg, #rgr.duedate,  #rgr.acc, sub.name as subname, #rgr.val, #rgr.bank, #rgr.acbank, #rgr.date, #rgr.sub, #rgr.acclawan, #rgr.dk, #rgr.jurnal, 
#rgr.remark, acc.name as accname
from #rgr left outer join #outgr on #rgr.nobg+#rgr.acc=#outgr.nobg+#outgr.acc
left outer join sub on #rgr.sub=sub.sub
left outer join acc on #rgr.acc=acc.acc
where #outgr.nobg is null and #rgr.subjurnal<>@subjurnal
order by #rgr.nobg



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO








CREATE     PROCEDURE sp_outrhp  @suba char(15), @subz char(15), @pdatea datetime, @pdatez datetime, @jurnal char(15) 

AS

declare @period char(4)
set @period=dbo.date2period(@pdatea)

select * into #outrhp from  
(
select rsb.jurnal,rsb.date, rsb.val, rsb.remark, rsb.duedate, rsb.acc, rsb.dk, rsb.sub
from rsb
where rsb.sub between @suba and @subz and rsb.period=@period
union all
select rhp.jurnal,rhp.date, rhp.val, rhp.remark, rhp.duedate, rhp.acc, rhp.dk, rhp.sub
from rhp
where rhp.sub between @suba and @subz and rhp.date between @pdatea and  @pdatez
) as outrhp

select * into #payhp from  
(
select payhp.reff as jurnal, payhp.sub, payhp.acc, sum(payhp.val) as val
from payhp
where payhp.sub between @suba and @subz and payhp.date between @pdatea and  @pdatez and payhp.jurnal<>@jurnal
group by payhp.reff, payhp.sub, payhp.acc
) as payhp

select date,jurnal,val,remark, duedate from 
(
select #outrhp.date,#outrhp.jurnal,#outrhp.remark, #outrhp.duedate, #outrhp.val-isnull(#payhp.val,000000000) as val
from #outrhp
left outer join #payhp on #outrhp.jurnal+rtrim(#outrhp.sub)+rtrim(#outrhp.acc)=#payhp.jurnal+rtrim(#payhp.sub)+rtrim(#payhp.acc)
) as outrhp
where val > 0
group by date,jurnal,remark,duedate,val
order by date, jurnal







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO





CREATE  PROCEDURE sp_outrhpum  @suba char(15), @subz char(15), @pdatea datetime, @pdatez datetime, @jurnal char(15) 

AS

declare @period char(4)
set @period=dbo.date2period(@pdatea)

select * into #outrhp from  
(
select rsb.jurnal,rsb.date, rsb.val, rsb.remark, rsb.duedate, rsb.acc, rsb.dk, rsb.sub
from rsb left outer join sub on rsb.sub=sub.sub left outer join grp on sub.grp=grp.grp
where rsb.sub between @suba and @subz and rsb.period=@period and (rsb.acc=grp.accum or rsb.acc=grp.accumbf)
union all
select rhp.jurnal,rhp.date, rhp.val, rhp.remark, rhp.duedate, rhp.acc, rhp.dk, rhp.sub
from rhp left outer join sub on rhp.sub=sub.sub left outer join grp on sub.grp=grp.grp
where rhp.sub between @suba and @subz and rhp.date between @pdatea and @pdatez and (rhp.acc=grp.accum or rhp.acc=grp.accumbf)
) as outrhp

select * into #payhp from  
(
select payhp.reff as jurnal, payhp.sub, payhp.acc, sum(payhp.val) as val
from payhp left outer join sub on payhp.sub=sub.sub left outer join grp on sub.grp=grp.grp
where payhp.sub between @suba and @subz and payhp.date between @pdatea and  @pdatez and payhp.jurnal<>@jurnal
and (payhp.acc=grp.accum or payhp.acc=grp.accumbf)
group by payhp.reff, payhp.sub, payhp.acc
) as payhp

select date,jurnal,val,remark, duedate from 
(
select #outrhp.date,#outrhp.jurnal,#outrhp.remark, #outrhp.duedate, #outrhp.val-isnull(#payhp.val,000000000) as val
from #outrhp
left outer join #payhp on #outrhp.jurnal+#outrhp.sub+#outrhp.acc=#payhp.jurnal+#payhp.sub+#payhp.acc
) as outrhp
where val > 0
group by date,jurnal,remark,duedate,val
order by date, jurnal




GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO



create PROCEDURE sp_outrka  @pdate datetime 
AS
 select rka.rka,rka.date,rka.loc,rka.sub,sub.name subname,sub.address,sub.city from rka left outer join sub on rka.sub=sub.sub  
 where rka.rka not in (select rka from rkl where rkl.date<=@pdate)
       and rka.date<=@pdate 
   order by rka.rka,rka.date




GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO



create  PROCEDURE sp_outrma  @pdate datetime ,@sub varchar(15)
AS
 select rma,date,loc from rma  
 where rma.rma not in (select rma from rms where rms.date<=@pdate)
       and rma.date<=@pdate and rma.sub=@sub
   order by rma.rma,rma.date




GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO






CREATE    PROCEDURE sp_outsjh @sjh char(15)

AS

select sjd.sjh,sjd.okl as spm,okd.okl,sjd.inv,sjd.loc,sjd.remark,sjd.unit,isnull(sjd.qty,0)qty,isnull(sjd.qty1,0)qty1,
(case when sjd.unit=inv.unit2 then inv.besar else 1 end) besar,isnull(okd.price,0)price,ISNULL(okd.disc,0)disc,inv.name,inv.unit as unitk
from sjd left join inv on sjd.inv=inv.inv left join sjh on sjd.sjh=sjh.sjh 
left join okd on sjd.okl+sjd.inv=okd.okl+okd.inv
where sjd.sjh=@sjh 






GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE    PROCEDURE sp_outspb  @spb char(15)

AS

select spbd.*,inv.name,inv.unit as unitk,inv.besar  from spbd left join inv on spbd.inv=inv.inv left join spb on spbd.spb=spb.spb where spbd.spb=@spb 










GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO










CREATE        PROCEDURE sp_outspbA  @pdate datetime,@jurnal char(15)
AS
select spb.spb,spb.date,spb.remark,spb.loc,spb.nopol,spb.oms,spb.cct,
       spb.sub,spb.ppn,spb.cur,spb.kurs,spb.disc, sub.name ,sub.address,sub.city 
from spb left outer join sub on spb.sub=sub.sub 
where spb.spb not in (select spb from lph where lph.date<=@pdate and lph.lph<>@jurnal union all select spb from rka where rka.date<=@pdate and rka.rka<>@jurnal)
      and spb.date<=@pdate
order by spb.spb,spb.date 











GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO







CREATE    PROCEDURE sp_outspm  @spm char(15)
AS

select spd.*,inv.name,(case when spd.unit=inv.unit2 then inv.besar else 1 end) besar
,inv.unit as unitk,spd.price
 from spd left join inv on spd.inv=inv.inv left join spm on spd.spm=spm.spm where spd.spm=@spm 





GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO






CREATE   PROCEDURE sp_postrhp @subjurnal char(15), @jurnal char(15)  AS

If @subjurnal='TTS'  
Begin  
insert into payhp select * from (  
SELECT ttd.ttr AS jurnal, ttd.jurnal as reff, ttr.date, ttr.sub, 
        (select max(acc) from rhp where rhp.jurnal=ttd.jurnal and rhp.period=period)  as acc, ttd.dk,ttd.val,@subjurnal as subjurnal,ttr.period,space(15) as invoice
	FROM ttd left outer join ttr on ttd.ttr=ttr.ttr
	WHERE @jurnal=ttd.ttr
) as xacd  
end

If @subjurnal='TTC'  
Begin  
insert into payhp select * from (  
SELECT ttd.ttr AS jurnal, ttd.jurnal as reff, ttr.date, ttr.sub, 
        (select max(acc) from rhp where rhp.jurnal=ttd.jurnal and rhp.period=period)  as acc,ttd.dk,ttd.val,@subjurnal  as subjurnal,ttr.period,space(15) as invoice
	FROM ttd left outer join ttr on ttd.ttr=ttr.ttr
	WHERE @jurnal=ttd.ttr
) as xacd  
end

If @subjurnal='KKL'  
Begin  
insert into payhp select * from (  
SELECT kad.kas AS jurnal, kad.jurnal as reff, kas.date, kas.sub, 
        kad.acc,kad.dk,kad.val,@subjurnal as subjurnal,kas.period,space(15) as invoice
	FROM kad left outer join kas on kad.kas=kas.kas
	WHERE @jurnal=kad.kas and kad.jurnal<>' ' and kad.jurnal<>kad.kas
) as xacd  
end

If @subjurnal='KMS'  
Begin  
insert into payhp select * from (  
SELECT kad.kas AS jurnal, kad.jurnal as reff, kas.date, kas.sub, 
        kad.acc,kad.dk,kad.val,@subjurnal as subjurnal,kas.period,space(15) as invoice
	FROM kad left outer join kas on kad.kas=kas.kas
	WHERE @jurnal=kad.kas and kad.jurnal<>' ' and kad.jurnal<>kad.kas
) as xacd  
end

If @subjurnal='KLR'  
Begin  
insert into payhp select * from (  
SELECT umk.klr AS jurnal, umk.jurnal as reff, klr.date, klr.sub, 
        umk.acc, umk.dk,umk.val,@subjurnal as subjurnal,klr.period,space(15) as invoice
	FROM umk left outer join klr on umk.klr=klr.klr
	WHERE @jurnal=umk.klr
union all
       SELECT umk.klr AS jurnal, umk.klr as reff, klr.date, klr.sub, 
        grp.acc, case when umk.dk='K' then 'D' else 'K' end ,umk.val,@subjurnal as subjurnal,klr.period,space(15) as invoice
	FROM umk left outer join klr on umk.klr=klr.klr
        left outer join sub on klr.sub=sub.sub
        left outer join grp on sub.grp=grp.grp
	WHERE @jurnal=umk.klr
) as xacd  
end

If @subjurnal='MSK'  
Begin  
insert into payhp select * from (  
SELECT umkp.msk AS jurnal, umkp.jurnal as reff, msk.date, msk.sub, 
        umkp.acc, umkp.dk,umkp.val,@subjurnal as subjurnal,msk.period,space(15) as invoice
	FROM umkp left outer join msk on umkp.msk=msk.msk
	WHERE @jurnal=umkp.msk
) as xacd  
end

If @subjurnal='MSI'  
Begin  
insert into payhp select * from (  
SELECT umkp.msk AS jurnal, umkp.jurnal as reff, msk.date, msk.sub, 
        umkp.acc, umkp.dk,umkp.val,@subjurnal as subjurnal,msk.period,space(15) as invoice
	FROM umkp left outer join msk on umkp.msk=msk.msk
	WHERE @jurnal=umkp.msk
) as xacd  
end

If @subjurnal='UMH'  
Begin  
insert into payhp select * from (  
SELECT umd.umh AS jurnal, umd.jurnal as reff, umh.date, umh.sub, 
        umd.acc,umd.dk,umd.val,@subjurnal as subjurnal,umh.period,space(15) as invoice
	FROM umd left outer join umh on umd.umh=umh.umh
	WHERE @jurnal=umd.umh and umd.jurnal<>' ' and umd.jurnal<>umd.umh
) as xacd  
end
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO










CREATE       PROCEDURE sp_prqout @suba char(15), @subz char(15), @prqa char(15), @prqz char(15)
AS
select prq,date,sub,inv,max(remark) as remark,sum(qty) as qtyprq,sum(qtyprq) as qty,jurnal from  
(
select prq.prq as prq,prq.date, prq.sub,prd.inv,prd.remark, prd.qty as qty,0 as qtyprq,space(15)as jurnal
from prd left outer join prq on prd.prq=prq.prq
where (prq.sub between @suba and @subz) and (prq.prq between @prqa and @prqz)
union all
select oms.prq,oms.date, oms.sub,omd.inv,omd.remark, 0 as qty,omd.qty as qtyoms,oms.oms
from omd left outer join oms on omd.oms=oms.oms
where (oms.sub between @suba and @subz) and (oms.prq between @prqa and @prqz) and oms.prq<>''
union all
select oms.prq,vpo.date,vpo.sub,vpd.inv,vpd.remark,0 as qty,-vpd.qty as qtyvpo,vpo.vpo
from vpd left outer join vpo on vpd.vpo=vpo.vpo 
left outer join oms on vpo.oms=oms.oms
where (vpo.sub between @suba and @subz)and (oms.prq between @prqa and @prqz) and vpo.oms<>''
) as xxx
group by prq,date,sub,inv,jurnal











GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO







--exec sp_prqout1 '20070801','20070830','','z','','z'


CREATE      PROCEDURE sp_prqout1 @pdatea datetime, @pdatez datetime, @suba char(15), @subz char(15), @inva char(15), @invz char(15)

AS
--select * from rprq 
declare @period char(4)
set @period=dbo.date2period(@pdatea)

select max(date) date,prq,inv,max(remark)as remark,sum(qtyprq) as qtyprq,sum(qty) as qty,isnull(max(duedate),'') as duedate from  
(
select rprq.prq,rprq.date,rprq.sub,rprq.inv,isnull(rprq.remark,0) as remark,rprq.qty as qtyprq,rprq.qtyout as qty,space(15) as jurnal ,space(12) as duedate
from rprq
where rprq.inv between @inva and @invz and rprq.period=@period and rprq.prq<>'' and rprq.qty-rprq.qtyout>0
union all
select prd.prq,prq.date, prq.sub,prd.inv,prd.remark, prd.qty as qty,0 as qtyprq,space(15),convert(char(12),prd.dateneed ,3)
from prd left outer join prq on prd.prq=prq.prq
where prq.sub between @suba and @subz and prd.inv between @inva and @invz and prq.date between @pdatea and  @pdatez and prd.prq<>''
union all
select oms.prq,oms.date, oms.sub,omd.inv,omd.remark, 0 as qty,omd.qty as qtyoms,oms.oms,space(12)
from omd left outer join oms on omd.oms=oms.oms
where oms.sub between @suba and @subz and omd.inv between @inva and @invz and oms.date between @pdatea and  @pdatez and oms.prq<>''
union all
select oms.prq,vpo.date,vpo.sub,vpd.inv,vpd.remark,0 as qty,-vpd.qty as qtyvpo,vpo.vpo,space(12)
from vpd left outer join vpo on vpd.vpo=vpo.vpo 
left outer join oms on vpo.oms=oms.oms
where vpo.sub between @suba and @subz and vpd.inv between @inva and @invz and vpo.date between @pdatea and  @pdatez and oms.prq<>''
) as prq
group by prq,inv


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO





CREATE  PROCEDURE sp_repsubdetil
  @lcdatea datetime,
  @lcdatez datetime,	
  @lcacca varchar(15),
  @lcaccz varchar(15)

as

declare @lcperiod varchar(4)

set @lcperiod=dbo.date2period(@lcdatea) 


select acc, sum(vlast) as vlast into  #awal 
from
( 
  select rac.acc, rac.vlast 
       from rac 
       where rac.period=@lcPeriod and rac.acc between @lcacca and @lcaccz
  union all
  select acd.acc, sum(val*case when dk='D' then 1 else -1 end) as vlast 
      from acd 
      where acd.period=@lcperiod and acd.date <@lcdatea and acd.acc between @lcacca and @lcaccz group by acd.acc
) 
as oawal group by acc

select acc.name, #awal.acc, @lcdatea as date, space(15) as jurnal, 'BALANCE' as rem, 
       case when #awal.vlast >= 0 then #awal.vlast else 0.00 end as debet, 
       (case when #awal.vlast < 0 then #awal.vlast else 0.00 end ) * -1 as kredit,' ' as dk 
       from #awal
       left outer join acc on #awal.acc=acc.acc
       where acc.detil=1 and #awal.vlast<>0
union all
select acc.name, acd.acc, acd.date as date, acd.jurnal as jurnal, acd.rem as rem, 
       case when acd.dk='D' then acd.val else 0.00 end as debet, 
       case when acd.dk='K' then acd.val else 0.00 end as kredit,acd.dk as dk 
       from acd 
       left outer join acc on acd.acc=acc.acc
       where acd.acc between @lcacca and @lcaccz and acd.date between @lcdatea and @lcdatez and acc.detil=1
order by 2,3,8,4



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE sp_repsubdetilcct1
  @lcdatea datetime,
  @lcdatez datetime,	
  @lcccta varchar(15),
  @lccctz varchar(15),
  @lcacc varchar(15)	

as

declare @lcperiod varchar(4)

set @lcperiod=dbo.date2period(@lcdatea) 


select cct, sum(vlast) as vlast into  #awal 
from
( 
  select acd.cct, sum(val*case when dk='D' then 1 else -1 end) as vlast 
      from acd 
      where acd.period=@lcperiod and acd.date <@lcdatea and acd.cct between @lcccta and @lccctz and acd.acc=@lcacc group by acd.cct
) 
as oawal group by cct

select cct.name, #awal.cct, @lcdatea as date, space(15) as jurnal, 'BALANCE' as rem, 
       case when #awal.vlast >= 0 then #awal.vlast else 0.00 end as debet, 
       (case when #awal.vlast < 0 then #awal.vlast else 0.00 end ) * -1 as kredit,' ' as dk 
       from #awal
       left outer join cct on #awal.cct=cct.cct
       where cct.detil=1 and #awal.vlast<>0
union all
select cct.name, acd.cct, acd.date as date, acd.jurnal as jurnal, acd.rem as rem, 
       case when acd.dk='D' then acd.val else 0.00 end as debet, 
       case when acd.dk='K' then acd.val else 0.00 end as kredit,acd.dk as dk 
       from acd 
       left outer join cct on acd.cct=cct.cct
       where acd.cct between @lcccta and @lccctz and acd.date between @lcdatea and @lcdatez and cct.detil=1 and acd.acc=@lcacc
order by 2,3,8


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE sp_repsubdetilcct2
  @lcdatea datetime,
  @lcdatez datetime,	
  @lcacca varchar(15),
  @lcaccz varchar(15),
  @lccct varchar(15)	

as

declare @lcperiod varchar(4)

set @lcperiod=dbo.date2period(@lcdatea) 


select acc, sum(vlast) as vlast into  #awal 
from
( 
  select rac.acc, rac.vlast 
       from rac 
       where rac.period=@lcPeriod and rac.acc between @lcacca and @lcaccz
  union all
  select acd.acc, sum(val*case when dk='D' then 1 else -1 end) as vlast 
      from acd 
      where acd.period=@lcperiod and acd.date <@lcdatea and acd.acc between @lcacca and @lcaccz and acd.cct=@lccct group by acd.acc
) 
as oawal group by acc

select acc.name, #awal.acc, @lcdatea as date, space(15) as jurnal, 'BALANCE' as rem, 
       case when #awal.vlast >= 0 then #awal.vlast else 0.00 end as debet, 
       (case when #awal.vlast < 0 then #awal.vlast else 0.00 end ) * -1 as kredit,' ' as dk 
       from #awal
       left outer join acc on #awal.acc=acc.acc
       where acc.detil=1 and #awal.vlast<>0
union all
select acc.name, acd.acc, acd.date as date, acd.jurnal as jurnal, acd.rem as rem, 
       case when acd.dk='D' then acd.val else 0.00 end as debet, 
       case when acd.dk='K' then acd.val else 0.00 end as kredit,acd.dk as dk 
       from acd 
       left outer join acc on acd.acc=acc.acc
       where acd.acc between @lcacca and @lcaccz and acd.date between @lcdatea and @lcdatez and acc.detil=1 and acd.cct=@lccct
order by 2,3,8


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE sp_repsubglobal
  @lcdatea datetime,
  @lcdatez datetime,	
  @lcacc varchar(15)

as

declare @lcperiod varchar(4)

set @lcperiod=dbo.date2period(@lcdatea) 


select sum(vlast) as vlast into  #awal 
from
( 
  select rac.acc, rac.vlast 
       from rac 
       where rac.period=@lcPeriod and rac.acc = @lcacc
  union all
  select acd.acc, sum(val*case when dk='D' then 1 else -1 end) as vlast 
      from acd 
      where acd.period=@lcperiod and acd.date <@lcdatea and dbo.cekaccparent(acd.acc, @lcacc)=1 group by acd.acc
) 
as oawal 


select @lcdatea as date, space(15) as jurnal, 'BALANCE' as rem, 
       case when #awal.vlast >= 0 then #awal.vlast else 0.00 end as debet, 
       (case when #awal.vlast < 0 then #awal.vlast else 0.00 end ) * -1 as kredit,' ' as dk 
       from #awal where #awal.vlast<>0
union all
select acd.date as date, acd.jurnal as jurnal, acd.rem as rem, 
       case when acd.dk='D' then acd.val else 0.00 end as debet, 
       case when acd.dk='K' then acd.val else 0.00 end as kredit,acd.dk as dk 
       from acd 
       left outer join acc on acd.acc=acc.acc
       where acd.date between @lcdatea and @lcdatez and dbo.cekaccparent(acd.acc, @lcacc)=1
order by 1,6


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO






CREATE    PROCEDURE sp_resetokl  @suba char(15), @subz char(15), @pdatea datetime, @pdatez datetime, @jurnal char(15),  @nextperiod char(4)

AS

declare @period char(4)
set @period=dbo.date2period(@pdatea)

select * into #outso from  
(
select rso.okl,rso.date, rso.sub,rso.inv,rso.loc,rso.qty as qtypo, rso.qtyout as qty, rso.remark
from rso
where rso.sub between @suba and @subz and rso.period=@period
union all
select outso.okl,outso.date, outso.sub,outso.inv,outso.loc,outso.qty as qtypo, 0 as qty, outso.remark
from outso
where outso.sub between @suba and @subz and outso.date between @pdatea and  @pdatez
) as outso

select * into #realso from  
(
select realso.okl, realso.sub, realso.inv, realso.loc, sum(realso.qty) as qty
from realso
where realso.sub between @suba and @subz and realso.date between @pdatea and  @pdatez and realso.jurnal<>@jurnal
group by realso.okl, realso.sub, realso.inv, realso.loc
) as realso

select * into #rka from  
(
select rka.okl, rka.sub, rkb.inv, max(rka.loc) loc,sum(rkb.qty) as qty
from rkb left outer join rka on rka.rka=rkb.rka 
where rka.date between @pdatea and  @pdatez and rka.rka<>@jurnal
group by rka.okl, rka.sub, rkb.inv
) as rka

insert into rso
select @nextperiod,okl,date,sub,inv,loc, qtypo, qty+realsoqty-rkaqty, remark from 
(
select #outso.*, isnull(#realso.qty,000000000) as realsoqty,isnull(#rka.qty,000000000) as rkaqty
from #outso
left outer join #realso on #outso.okl+#outso.inv=#realso.okl+#realso.inv
left outer join #rka on #outso.okl+#outso.inv=#rka.okl+#rka.inv
) as outokl 
where qtypo-qty-realsoqty+rkaqty > 0
--group by okl, date,remark





GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO



CREATE PROCEDURE sp_resetoms  @suba char(15), @subz char(15), @pdatea datetime, @pdatez datetime, @jurnal char(15), @nextperiod char(4) 

AS

declare @period char(4)
set @period=dbo.date2period(@pdatea)

select * into #outpo from  
(
select rpo.oms,rpo.date, rpo.sub,rpo.inv,rpo.loc,rpo.qty as qtypo, rpo.qtyout as qty, rpo.remark
from rpo
where rpo.sub between @suba and @subz and rpo.period=@period
union all
select outpo.oms,outpo.date, outpo.sub,outpo.inv,outpo.loc,outpo.qty as qtypo, 0 as qty, outpo.remark
from outpo
where outpo.sub between @suba and @subz and outpo.date between @pdatea and  @pdatez
) as outpo

select * into #realpo from  
(
select realpo.oms, realpo.sub, realpo.inv, realpo.loc, sum(realpo.qty) as qty
from realpo
where realpo.sub between @suba and @subz and realpo.date between @pdatea and  @pdatez and realpo.jurnal<>@jurnal
group by realpo.oms, realpo.sub, realpo.inv, realpo.loc
) as realpo


insert into rpo
select @nextperiod,oms,date,sub,inv,loc, qtypo, qty+realpoqty, remark from 
(
select #outpo.*, isnull(#realpo.qty,000000000) as realpoqty
from #outpo
left outer join #realpo on #outpo.oms+#outpo.inv+#outpo.loc=#realpo.oms+#realpo.inv+#realpo.loc
) as outoms 
where qtypo-qty-realpoqty > 0
--group by oms, date,remark
order by date, oms


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO







CREATE       PROCEDURE sp_resetprq  @suba char(15), @subz char(15), @pdatea datetime, @pdatez datetime, @jurnal char(15),  @nextperiod char(4)
AS
begin
declare @period char(4)
set @period=dbo.date2period(@pdatea)

select rprq.prq,rprq.date,rprq.sub,rprq.inv,rprq.loc,rprq.qty,isnull(rprq.qtyout,0) as qtyout,rprq.remark
into #rprq from rprq where rprq.period=@period
union all
select prd.prq,prq.date,prq.sub,prd.inv,prq.loc,prd.qty as qtyprq,0,prd.remark 
from prd left outer join prq on prd.prq=prq.prq 
where period=@period

select max(oms) as oms,prq,sub,inv,loc,sum(qty) as qtyoms 
into #oms from (
select omd.oms,oms.prq,oms.sub,omd.inv,oms.loc,omd.qty as qty
from omd left outer join oms on omd.oms=oms.oms 
where oms.prq<>'' and oms.period=@period 
union all
select vpo.oms,oms.prq,vpo.sub,vpd.inv,vpo.loc,-vpd.qty as qty
from vpd left outer join vpo on vpd.vpo=vpo.vpo 
left outer join oms on vpo.oms=oms.oms
where oms.prq<>'' and vpo.period=@period 
) as tmpoms
group by prq,sub,inv,loc
/*
select max(omd.oms) as oms,oms.prq,oms.sub,omd.inv,oms.loc,sum(omd.qty) as qtyoms 
into #oms from omd left outer join oms on omd.oms=oms.oms 
where oms.prq<>'' and oms.period=@period 
group by oms.prq,oms.sub,omd.inv,oms.loc
*/

insert into rprq
select @nextperiod,prq,date,sub,inv,loc, qtyprq, qtyout, remark from 
(
select #rprq.prq,#rprq.date,#rprq.sub,#rprq.inv,#rprq.loc,#rprq.qty as qtyprq,(#rprq.qtyout+#oms.qtyoms) as qtyout,#rprq.remark
from #rprq left outer join #oms on #rprq.prq=#oms.prq 
) as tmpprq
end








GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO



CREATE PROCEDURE sp_resetrgr @pdatea datetime, @pdatez datetime, @jurnal varchar(15) , @nextperiod varchar(4)

AS

declare @period char(4)
set @period=dbo.date2period(@pdatea)

select * into #rgr from  
(
--jurnal,date,duedate,sub,nobg,bank,acbank,acc,dk,val,subjurnal,remark,group_,acclawan
select rgr.jurnal, rgr.date, rgr.duedate, rgr.sub, rgr.nobg,rgr.bank, rgr.acbank, rgr.acc, rgr.dk, rgr.val, rgr.subjurnal, rgr.remark, rgr.group_, rgr.acclawan, rgr.groupasli, rgr.periodtrans
from rgr
where rgr.period=@period and period<>periodtrans
union all
select rghp.jurnal, rghp.date, rghp.duedate, rghp.sub, rghp.nobg,rghp.bank, rghp.acbank, rghp.acc, rghp.dk, rghp.val, rghp.subjurnal, rghp.remark, rghp.group_, rghp.acclawan, rghp.group_ as groupasli, rghp.period as periodtrans
from rghp
where rghp.date between @pdatea and  @pdatez and rghp.group_=' ' 
) as rgr

select * into #outgr from  
(
select rghp.nobg,rghp.date, rghp.acc, rghp.remark, rghp.val
from rghp
where rghp.date between @pdatea and  @pdatez and rghp.group_<>' ' and jurnal<>@jurnal
) as outgr

insert into rgr
select @nextperiod , #rgr.* from #rgr left outer join #outgr on #rgr.nobg+#rgr.acc=#outgr.nobg+#outgr.acc
where #outgr.nobg is null


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO











CREATE        PROCEDURE sp_resetrhp  @suba char(15), @subz char(15), @pdatea datetime, @pdatez datetime, @jurnal char(15), @nextperiod char(15) 

AS

declare @period char(4)
set @period=dbo.date2period(@pdatea)

select * into #outrhp from  
(
select rsb.jurnal,rsb.date, rsb.val as val, rsb.remark, rsb.duedate, rsb.acc, rsb.dk, rsb.sub, rsb.subjurnal, rsb.valasli,rsb.invoice,case when rsb.kurs=0 then 1 else rsb.kurs end as kurs
from rsb
where rsb.sub between @suba and @subz and rsb.period=@period
union all
select rhp.jurnal,rhp.date, rhp.val, rhp.remark, rhp.duedate, rhp.acc, rhp.dk, rhp.sub, rhp.subjurnal, rhp.val as valasli,rhp.invoice,case when rhp.kurs=0 then 1 else rhp.kurs end as kurs
from rhp
where rhp.sub between @suba and @subz and rhp.date between @pdatea and  @pdatez
) as outrhp

select * into #payhp from  
(
select payhp.reff as jurnal, payhp.sub, payhp.acc, sum(payhp.val) as val,payhp.invoice
from payhp
where payhp.sub between @suba and @subz and payhp.date between @pdatea and  @pdatez and payhp.jurnal<>@jurnal
group by payhp.reff, payhp.sub, payhp.acc,payhp.invoice
) as payhp


insert into rsb
select  @nextperiod, jurnal, date, sub, acc, dk,val, 0, duedate,subjurnal,remark,valasli,invoice,kurs  from 
--period, jurnal, date,sub,acc,dk,val,payment,duedate,subjurnal,remark,valasli
(
select 
#outrhp.jurnal,#outrhp.subjurnal,#outrhp.date,#outrhp.sub,#outrhp.acc,#outrhp.dk,
#outrhp.val-isnull(#payhp.val,000000000) as val,#outrhp.duedate, #outrhp.remark, #outrhp.valasli,#outrhp.invoice,#outrhp.kurs
from #outrhp
left outer join #payhp on #outrhp.jurnal+#outrhp.sub+#outrhp.acc=#payhp.jurnal+#payhp.sub+#payhp.acc
) as outrhp
where val > 0 or valasli>0










GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO






CREATE   PROCEDURE sp_resetrin
  @lcdatea datetime,
  @lcdatez datetime,	
  @lcinva varchar(15),
  @lcinvz varchar(15),
  @lcloca varchar(15),
  @lclocz varchar(15),
  @nextperiod varchar(4) 

as

declare @lcperiod varchar(4)

set @lcperiod=dbo.date2period(@lcdatea) 


select invname, inv, locname, loc, sum(qlast) as qlast, sum(vlast) as vlast, qtymin, unit  into  #awal 
from
( 
  select inv.name as invname, rin.inv,  (select top 1 name from loc where kode=rin.loc) as locname, rin.loc, rin.qlast, rin.vlast, inv.qtymin, inv.unit  
       from rin 
       left outer join inv on rin.inv=inv.inv
       where rin.period=@lcPeriod and rin.inv between @lcinva and @lcinvz and rin.loc between @lcloca and @lclocz
  union all
  select inv.name as invname, ind.inv, (select top 1 name from loc where kode=ind.loc) as locname, ind.loc, sum(qty*case when dk='D' then 1 else -1 end) as qlast , sum(val*case when dk='D' then 1 else -1 end) as vlast,inv.qtymin, inv.unit 
      from ind
      left outer join inv on ind.inv=inv.inv
      where ind.period=@lcperiod and ind.date <@lcdatea and  ind.inv between @lcinva and @lcinvz and ind.loc between @lcloca and @lclocz group by inv.name, ind.inv, ind.loc,inv.qtymin,inv.unit
) 
as oawal group by invname, inv, locname, loc,qtymin, unit


select * into  #ind
from
( 
select inv.name as invname, ind.inv, (select top 1 name from loc where kode=ind.loc) as locname, ind.loc, 
       sum(case when ind.dk='D' then ind.qty else 0.00 end) as qdebet, 
       sum(case when ind.dk='D' then ind.val else 0.00 end) as vdebet, 
       sum(case when ind.dk='K' then ind.qty else 0.00 end) as qkredit,
       sum(case when ind.dk='K' then ind.val else 0.00 end) as vkredit,
       inv.qtymin, inv.unit 
       from ind
       left outer join inv on ind.inv=inv.inv
       where ind.inv between @lcinva and @lcinvz and 
       ind.date between @lcdatea and @lcdatez and 
       ind.loc between @lcloca and @lclocz  
       group by inv.name, ind.inv, ind.loc,inv.qtymin,unit
) 
as oind


insert into rin
select isnull(#awal.inv,#ind.inv) as inv,
       isnull(#awal.loc,#ind.loc) as loc,
       @nextperiod as period, 	
       isnull(#awal.vlast,0.00)+isnull(#ind.vdebet,0.00)-isnull(#ind.vkredit,0.00) as vlast,0,0,
       isnull(#awal.qlast,0.00)+isnull(#ind.qdebet,0.00)-isnull(#ind.qkredit,0.00) as qlast,0,0
from #ind 
full outer join #awal on #ind.inv+#ind.loc=#awal.inv+#awal.loc





GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO



CREATE PROCEDURE sp_rghp @pdatea datetime, @pdatez datetime, @pacca varchar(15), @paccz varchar(15)

AS

declare @period char(4)
set @period=dbo.date2period(@pdatea)

select * into #rgr from  
(
select rgr.nobg,rgr.date, rgr.acc, rgr.remark, rgr.val, rgr.dk, rgr.sub,rgr.duedate
from rgr
where rgr.period=@period and period<>periodtrans
union all
select rghp.nobg,rghp.date, rghp.acc, rghp.remark, rghp.val, rghp.dk, rghp.sub, rghp.duedate
from rghp
where rghp.date between @pdatea and  @pdatez and rghp.group_=' ' 
) as rgr

select date, nobg, sub,remark,val, dk, duedate,acc  into #outgr from  
(
select rghp.nobg,rghp.date, rghp.acc, rghp.remark, rghp.val, rghp.sub, rghp.dk,rghp.duedate
from rghp
where rghp.date between @pdatea and  @pdatez and rghp.group_<>' ' 
) as outgr

select #rgr.date, #rgr.nobg, #rgr.sub,#rgr.remark, #rgr.dk,#rgr.val, #rgr.duedate from #rgr left outer join #outgr on #rgr.nobg+#rgr.acc=#outgr.nobg+#outgr.acc
where #outgr.nobg is null and #rgr.acc between @pacca and @paccz
order by #rgr.nobg


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO



CREATE PROCEDURE sp_rgr @pdate0 datetime,@pdatea datetime, @pdatez datetime, @pacca varchar(15), @paccz varchar(15)

AS

declare @period char(4)
set @period=dbo.date2period(@pdatea)

select * into #rgr from  
(
select rgr.nobg,rgr.date, rgr.acc, rgr.remark, rgr.val, rgr.dk
from rgr
where rgr.period=@period and period<>periodtrans
union all
select rghp.nobg,rghp.date, rghp.acc, rghp.remark, rghp.val, rghp.dk
from rghp
where rghp.date between @pdate0 and  @pdatez 
) as rgr


select #rgr.acc,acc.name as accname,
sum(#rgr.val*case when #rgr.dk='D' then 1 else -1 end*case when #rgr.date<@pdatea then 1 else 0 end ) as vlast, 
sum(#rgr.val*case when #rgr.dk='D' and #rgr.date between @pdatea and @pdatez then 1 else 0 end ) as vdebet, 
sum(#rgr.val*case when #rgr.dk='K' and #rgr.date between @pdatea and @pdatez then 1 else 0 end ) as vkredit
from #rgr left outer join acc on #rgr.acc=acc.acc
group by #rgr.acc,acc.name
order by acc.name,#rgr.acc


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO






CREATE    PROCEDURE sp_rhp @suba char(15), @subz char(15), @pdatea datetime, @pdatez datetime, @group_ varchar(1), @pacca char(15), @paccz char(15)

AS

declare @period char(4)
set @period=dbo.date2period(@pdatea)

select * into #outrhp from  
(
select rsb.jurnal,rsb.date, rsb.val, rsb.remark, rsb.duedate, rsb.acc, rsb.dk, rsb.sub,rsb.invoice, rsb.kurs
from rsb
where rsb.sub between @suba and @subz and rsb.period=@period and rsb.acc between @pacca and @paccz
union all
select rhp.jurnal,rhp.date, rhp.val, rhp.remark, rhp.duedate, rhp.acc, rhp.dk, rhp.sub, rhp.invoice, rhp.kurs
from rhp
where rhp.sub between @suba and @subz and rhp.date between @pdatea and  @pdatez and rhp.acc between @pacca and @paccz
) as outrhp

select * into #payhp from  
(
select payhp.reff as jurnal, payhp.sub, payhp.acc, sum(payhp.val) as val,max(payhp.invoice) invoice
from payhp
where payhp.sub between @suba and @subz and payhp.date between @pdatea and  @pdatez and payhp.acc between @pacca and @paccz
group by payhp.reff, payhp.sub, payhp.acc
) as payhp

select dk,sub, acc, date,jurnal,remark, val, duedate, kurs into #rhp from 
(
select #outrhp.date,#outrhp.jurnal,#outrhp.remark, #outrhp.duedate, #outrhp.val-isnull(#payhp.val,000000000) as val,#outrhp.sub,#outrhp.dk, #outrhp.acc, #outrhp.kurs
from #outrhp
left outer join #payhp on #outrhp.jurnal+#outrhp.sub+#outrhp.acc=#payhp.jurnal+#payhp.sub+#payhp.acc
) as outrhp
where val > 0
group by dk,sub, date,jurnal,remark,val,duedate,acc, kurs

select #rhp.date,#rhp.jurnal,#rhp.remark,#rhp.val*#rhp.kurs as val, #rhp.duedate,#rhp.dk,
#rhp.sub, #rhp.acc,sub.name as subname, acc.name as accname
from #rhp 
left outer join sub on #rhp.sub=sub.sub 
left outer join acc on #rhp.acc=acc.acc
where sub.group_=@group_
order by date, jurnal

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO




CREATE  PROCEDURE sp_rsb  @suba char(15), @subz char(15), @pdate0 datetime, @pdatea datetime, @pdatez datetime, @group_ varchar(1), @pacca char(15), @paccz char(15)

AS


declare @period char(4)
declare @lcdk char(1)

set @period=dbo.date2period(@pdatea)

select * into #rsb 
from  
(
select rsb.jurnal,rsb.date, rsb.val, rsb.acc, rsb.dk, rsb.sub,rsb.invoice, rsb.kurs
from rsb
where rsb.sub between @suba and @subz and rsb.period=@period and rsb.acc between @pacca and @paccz
union all
select rhp.jurnal,rhp.date, rhp.val, rhp.acc, rhp.dk, rhp.sub,rhp.invoice, rhp.kurs
from rhp
where rhp.sub between @suba and @subz and rhp.date between @pdate0 and  @pdatez and rhp.acc between @pacca and @paccz
union all
select payhp.jurnal , payhp.date, payhp.val, payhp.acc, payhp.dk ,payhp.sub,payhp.invoice, (select top 1 kurs from rhp where rhp.jurnal=payhp.reff)  as kurs
from payhp
where payhp.sub between @suba and @subz and payhp.date between @pdate0 and  @pdatez and payhp.acc between @pacca and @paccz
) as rsb 

select #rsb.sub, sub.name as subname, #rsb.acc, acc.name as accname,  
sum(#rsb.val*case when #rsb.dk='D' then 1 else -1 end*case when #rsb.date<@pdatea then 1 else 0 end*#rsb.kurs ) as vlast, 
sum(#rsb.val*case when #rsb.dk='D' and #rsb.date between @pdatea and @pdatez then 1 else 0 end*#rsb.kurs  ) as vdebet, 
sum(#rsb.val*case when #rsb.dk='K' and #rsb.date between @pdatea and @pdatez then 1 else 0 end *#rsb.kurs ) as vkredit
from #rsb
left outer join acc on #rsb.acc=acc.acc
left outer join sub on #rsb.sub=sub.sub 
where sub.group_=@group_
group by #rsb.sub,#rsb.acc, sub.name, acc.name 
order by sub.name, #rsb.acc

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO










CREATE                            PROCEDURE sp_save  @pdate datetime, @subjurnal char(15), @jurnal char(15) AS

declare @period varchar(4)
set @period=dbo.date2period(@pdate)

exec sp_delete  @subjurnal,@jurnal,@period

If @subjurnal='OMS' and @pdate>'20070731'
Begin  
----outpo untuk po yang masuk
----realpo untuk pelunasan po
     insert into outpo 
	select oms.oms,oms.date,oms.sub,omd.inv,omd.loc,sum(omd.qty) as qty, oms.remark, oms.period 
                        from omd left outer join oms on omd.oms=oms.oms
	           where omd.oms=@jurnal                        
	           group by oms.oms,oms.date,oms.sub,omd.inv,omd.loc, oms.remark, oms.period
end

If @subjurnal='VPO' and @pdate>'20070731'
Begin  
     exec sp_insertrealpo @subjurnal,@jurnal
end


If @subjurnal='LPB' and @pdate>'20070731'
Begin  
--update nilai lpb lokal
   update lpd set lpd.price=omd.price*(case when lpd.unit=omd.unit then 1.00 else (case when omd.unit=inv.unit2 then 1/inv.besar else inv.besar end) end)
   from lpd 
   left outer join omd on lpd.oms+lpd.inv+lpd.unit=omd.oms+omd.inv+lpd.unit
   left outer join inv on lpd.inv=inv.inv
   where lpd.lph=@jurnal and lpd.oms<>'' and substring(lpd.lph,5,4)= @period

     exec sp_insertrealpo @subjurnal,@jurnal
     exec sp_SaveInv @subjurnal,@jurnal	
     --exec sp_SaveRhp @subjurnal,@jurnal	
     exec sp_SaveAcd @subjurnal,@jurnal	 
end
If @subjurnal='POO' and @pdate>'20070731' 
Begin  
--update nilai lpb impor

  update lpd set lpd.price=omd.price*(case when lpd.unit=omd.unit then 1.00 else (case when omd.unit=inv.unit2 then 1/inv.besar else inv.besar end) end)
   from lpd 
   left outer join omd on lpd.oms+lpd.inv+lpd.unit=omd.oms+omd.inv+lpd.unit
   left outer join inv on lpd.inv=inv.inv
   where lpd.lph=@jurnal and lpd.oms<>'' and substring(lpd.lph,5,4)= @period

     exec sp_insertrealpo @subjurnal,@jurnal
     exec sp_SaveInv @subjurnal,@jurnal	
     --exec sp_SaveRhp @subjurnal,@jurnal	
     exec sp_SaveAcd @subjurnal,@jurnal	 
end

If @subjurnal='MSK' and @pdate>'20070731' --pembelian lokal
Begin  
--     exec sp_insertrealpo @subjurnal,@jurnal
--     exec sp_SaveInv @subjurnal,@jurnal	
    exec sp_PostRhp @subjurnal,@jurnal	
     exec sp_SaveRhp @subjurnal,@jurnal	
     exec sp_SaveAcd @subjurnal,@jurnal	 
end
If @subjurnal='MSI' and @pdate>'20070731' ---pembelian import
Begin  
--     exec sp_insertrealpo @subjurnal,@jurnal
--     exec sp_SaveInv @subjurnal,@jurnal	
    exec sp_PostRhp @subjurnal,@jurnal	
     exec sp_SaveRhp @subjurnal,@jurnal	
     exec sp_SaveAcd @subjurnal,@jurnal	 
end
If @subjurnal='RMA' and @pdate>'20070731' 
Begin  
     exec sp_SaveInv @subjurnal,@jurnal	 
     exec sp_SaveAcd @subjurnal,@jurnal	 
end

If @subjurnal='RMS' and @pdate>'20070731'
Begin  
     --exec sp_SaveInv @subjurnal,@jurnal	 
     exec sp_SaveRhp @subjurnal,@jurnal		
     exec sp_SaveAcd @subjurnal,@jurnal	 
end

If @subjurnal='OKL' and @pdate>'20070731'  
Begin  
     insert into outso 
	select okl.okl,okl.date,okl.sub,okd.inv,okd.loc,sum(okd.qty) as qty, okl.remark, okl.period
                        from okd left outer join okl on okd.okl=okl.okl
  	          where okd.okl=@jurnal                        
	          group by okl.okl,okl.date,okl.sub,okd.inv,okd.loc, okl.remark, okl.period
end

If @subjurnal='VSO' and @pdate>'20070731' 
Begin  
     exec sp_insertrealso @subjurnal,@jurnal
end

If @subjurnal='SJH' and @pdate>'20070731' 
Begin  
     exec sp_insertrealso @subjurnal,@jurnal
     exec sp_SaveInv @subjurnal,@jurnal	
     --exec sp_SaveRhp @subjurnal,@jurnal	
     exec sp_SaveAcd @subjurnal,@jurnal	 
end

If @subjurnal='KLR' and @pdate>'20070731' 
Begin  
     --exec sp_insertrealso @subjurnal,@jurnal
     --exec sp_SaveInv @subjurnal,@jurnal	
    exec sp_PostRhp @subjurnal,@jurnal	
    exec sp_SaveRhp @subjurnal,@jurnal	
    exec sp_SaveAcd @subjurnal,@jurnal	 

end

If @subjurnal='RKA' and @pdate>'20070731' 
Begin  
     exec sp_SaveInv @subjurnal,@jurnal	
     exec sp_SaveAcd @subjurnal,@jurnal	 
     exec sp_insertrealso @subjurnal,@jurnal
end

If @subjurnal='RKL' and @pdate>'20070731' 
Begin  
     --exec sp_SaveInv @subjurnal,@jurnal	
     exec sp_SaveRhp @subjurnal,@jurnal	
     exec sp_SaveAcd @subjurnal,@jurnal	 
end

if @subjurnal='JIN' and @pdate>'20070731'
Begin
    exec sp_SaveInv @subjurnal,@jurnal	
    exec sp_SaveAcd @subjurnal,@jurnal	
End

if @subjurnal='LHP' and @pdate>'20070731'
Begin
    exec sp_SaveInv @subjurnal,@jurnal	
    exec sp_SaveAcd @subjurnal,@jurnal	
End

if @subjurnal='TRM' and @pdate>'20070731'
Begin
    exec sp_SaveInv @subjurnal,@jurnal	
    exec sp_SaveAcd @subjurnal,@jurnal		
End

if @subjurnal='OPN' and @pdate>='20070731'
Begin
    exec sp_SaveInv @subjurnal,@jurnal	
    exec sp_SaveAcd @subjurnal,@jurnal		
End

if @subjurnal='UMH' and @pdate>='20070731'
Begin
    exec sp_SaveAcd @subjurnal,@jurnal	
    exec sp_PostRhp @subjurnal,@jurnal	
 --   exec sp_SaveAcd @subjurnal,@jurnal		
End

if @subjurnal='CAD' and @pdate>='20070731'
Begin
    exec sp_SaveAcd @subjurnal,@jurnal	
--   exec sp_SaveAcd @subjurnal,@jurnal		
End

if @subjurnal='JSU' and @pdate>='20070731'
Begin
    exec sp_SaveRhp @subjurnal,@jurnal	
    exec sp_SaveAcd @subjurnal,@jurnal	 
End

if @subjurnal='TTS' and @pdate>'20070731'
Begin
    exec sp_SaveRhp @subjurnal,@jurnal	
    exec sp_PostRhp @subjurnal,@jurnal	
    exec sp_SaveAcd @subjurnal,@jurnal	 
End

if @subjurnal='TTC' and @pdate>'20070731'
Begin
    exec sp_SaveRhp @subjurnal,@jurnal	
    exec sp_PostRhp @subjurnal,@jurnal	
    exec sp_SaveAcd @subjurnal,@jurnal	 
End

if @subjurnal='KKK' and @pdate>'20070731'
Begin
    exec sp_SaveAcd @subjurnal,@jurnal	 
End

if @subjurnal='KKM' and @pdate>'20070731'
Begin
    exec sp_SaveAcd @subjurnal,@jurnal	 
End

if @subjurnal='KKL' and @pdate>='20070731'
Begin
    exec sp_Savergr @subjurnal,@jurnal	
    exec sp_Saverhp @subjurnal,@jurnal		
    exec sp_PostRhp @subjurnal,@jurnal	
    exec sp_SaveAcd @subjurnal,@jurnal	 
End

if @subjurnal='KKG' and @pdate>'20070731'
Begin
   exec sp_SaveAcd @subjurnal,@jurnal	 
End

if @subjurnal='KMS' and @pdate>'20070731'
Begin
 update kas set kurs=valrp/val where kas.valrp<>0 and kas.val<>0 and kas.kas=@jurnal
    exec sp_Savergr @subjurnal,@jurnal	
    exec sp_Saverhp @subjurnal,@jurnal		
    exec sp_PostRhp @subjurnal,@jurnal	
    exec sp_SaveAcd @subjurnal,@jurnal	 
End

if @subjurnal='INO' and @pdate>'20070731'
Begin
    exec sp_SaveAcd @subjurnal,@jurnal	 
End

if @subjurnal='STR' and @pdate>'20070731'
Begin
    exec sp_Savergr @subjurnal,@jurnal	
    exec sp_SaveAcd @subjurnal,@jurnal	 
End

if @subjurnal='TLK' and @pdate>'20070731'
Begin
    exec sp_Savergr @subjurnal,@jurnal	
    exec sp_SaveRhp @subjurnal,@jurnal		
    exec sp_SaveAcd @subjurnal,@jurnal	 
End

if @subjurnal='CGR' and @pdate>'20070731'
Begin
    exec sp_Savergr @subjurnal,@jurnal	
    exec sp_SaveAcd @subjurnal,@jurnal	 
End
/*
if @jurnal='.FA-0707-000001'
  begin
  insert into acd select * from (  
  SELECT @Jurnal as jurnal, '0707' as period,inv.acc as acc,max(inv.date) as date,sum(inv.valjual) as val,
	' ' as cct, 'initial balance ' as remark,'D' as dk,'JIN' as subjurnal,0 as adj
	from inv where inv.group_=5 group by inv.acc
  union all
  SELECT  @jurnal as jurnal, '0707' as period,(select acc from acc where acc='79000000') as acc,max(inv.date) as date,sum(inv.valjual) as val,
	' ' as cct, 'initial balance ' as remark,'K' as dk,@subjurnal,0 as adj
	from inv where inv.group_=5
  )as xacd
end
*/
/*
If @subjurnal=space(3) or @subjurnal='MSK'  
Begin  
insert into acd select * from (  
SELECT msk.msk AS jurnal, @period AS period, sub.acc, msk.date,     
           msk.val, space(15) as cct, msk.remark, 'K' as dk, 'MSK' AS subjurnal, 0 as adj
           FROM msk left outer join sub on msk.sub=sub.sub
           WHERE @jurnal=msk.msk
) as xacd  
insert into acd select * from (  
SELECT msk.msk AS jurnal, @period AS period, inv.accloc as acc, msk.date,     
           (((msd.price*msd.qty)*(100.00-msk.disc)/100.00)*(100.00-msd.disc)/100.00)*case when msk.ppn=2 then @V10Bagi11 else 1 end as val, 
           space(15) as cct, msd.remark, 'D' as dk, 'MSK' AS subjurnal, 0 as adj
           FROM msd left outer join msk on msd.msk=msk.msk
           left outer join inv on msd.inv=inv.inv
           WHERE @jurnal=msd.msk and msd.qty>0
) as xacd  
end

If @subjurnal=space(3) or @subjurnal='RMS'  
Begin  
insert into acd select * from (  
SELECT rms.rms AS jurnal, @period AS period, sub.acc, rms.date,     
           rms.val, space(15) as cct, rms.remark, 'D' as dk, 'RMS' AS subjurnal, 0 as adj
           FROM rms left outer join sub on rms.sub=sub.sub
           WHERE @jurnal=rms.rms
) as xacd  
insert into acd select * from (  
SELECT rms.rms AS jurnal, @period AS period, inv.accloc as acc, rms.date,     
           (((rmd.price*rmd.qty)*(100.00-rms.disc)/100.00)*(100.00-rmd.disc)/100.00)*case when rms.ppn=2 then @V10Bagi11 else 1 end as val, 
           space(15) as cct, rmd.remark, 'K' as dk, 'RMS' AS subjurnal, 0 as adj
           FROM rmd left outer join rms on rmd.rms=rms.rms
           left outer join inv on rmd.inv=inv.inv
           WHERE @jurnal=rmd.rms and rmd.qty>0
) as xacd  
end

If @subjurnal=space(3) or @subjurnal='KLR'  
Begin  
insert into acd select * from (  
SELECT klr.klr AS jurnal, @period AS period, sub.acc, klr.date,     
           klr.val, space(15) as cct, klr.remark, 'D' as dk, 'KLR' AS subjurnal, 0 as adj
           FROM klr left outer join sub on klr.sub=sub.sub
           WHERE @jurnal=klr.klr
) as xacd  
insert into acd select * from (  
SELECT klr.klr AS jurnal, @period AS period, inv.accrev as acc, klr.date,     
           (((kld.price*kld.qty)*(100.00-klr.disc)/100.00)*(100.00-kld.disc)/100.00)*case when klr.ppn=2 then @V10Bagi11 else 1 end as val, 
           inv.cctrev as cct, kld.remark, 'K' as dk, 'KLR' AS subjurnal, 0 as adj
           FROM kld left outer join klr on kld.klr=klr.klr
           left outer join inv on kld.inv=inv.inv
           WHERE @jurnal=kld.klr and kld.qty>0
) as xacd  
end

If @subjurnal=space(3) or @subjurnal='RKL'  
Begin  
insert into acd select * from (  
SELECT rkl.rkl AS jurnal, @period AS period, sub.acc, rkl.date,     
           rkl.val, space(15) as cct, rkl.remark, 'K' as dk, 'JSU' AS subjurnal, 0 as adj
           FROM rkl left outer join sub on rkl.sub=sub.sub
           WHERE @jurnal=rkl.rkl
) as xacd  
insert into acd select * from (  
SELECT rkl.rkl AS jurnal, @period AS period, inv.accrev as acc, rkl.date,     
           (((rkd.price*rkd.qty)*(100.00-rkl.disc)/100.00)*(100.00-rkd.disc)/100.00)*case when rkl.ppn=2 then @V10Bagi11 else 1 end as val, 
           inv.cctrev as cct, rkd.remark, 'D' as dk, 'JSU' AS subjurnal, 0 as adj
           FROM rkd left outer join rkl on rkd.rkl=rkl.rkl
           left outer join inv on rkd.inv=inv.inv
           WHERE @jurnal=rkd.rkl and rkd.qty>0
) as xacd  
end

If @subjurnal=space(3) or @subjurnal='JSU'  
Begin  
insert into acd select * from (  
SELECT jsu.jsu AS jurnal, @period AS period, sub.acc, jsu.date,     
           jsu.val, space(15) as cct, jsu.remark, case when jsu.dk=1 then 'K' else 'D' end as dk, 'JSU' AS subjurnal, 0 as adj
           FROM jsu left outer join sub on jsu.sub=sub.sub
           WHERE @jurnal=jsu.jsu
) as xacd  
insert into acd select * from (  
SELECT jsu.jsu AS jurnal, @period AS period, jsu.acc, jsu.date,     
           jsu.val, jsu.cct, jsu.remark, case when jsu.dk=1 then 'D' else 'K' end as dk, 'JSU' AS subjurnal, 0 as adj
           FROM jsu 
           WHERE @jurnal=jsu.jsu
) as xacd  
end

If @subjurnal=space(3) or @subjurnal='KAS'  
Begin  
insert into acd select * from (  
SELECT kas.kas AS jurnal, @period AS period, kas.acc, kas.date,     
           kas.val, space(15) as cct, kas.remark, case when kas.group_=1 then 'K' else 'D' end as dk, 'KAS' AS subjurnal, 0 as adj
           FROM kas
           WHERE @jurnal=kas.kas
) as xacd  

insert into acd select * from (  
SELECT kas.kas AS jurnal, @period AS period, sub.acc, kas.date,     
           abs(kad.val) as val, space(15) as cct, kad.remark,
           case when kas.group_=1 then  
                 case when kad.val>=0 then 'D' else 'K' end
           else
	    case when kad.val>=0 then 'K' else 'D' end
           end as dkl , 
           'KAS' AS subjurnal, 0 as adj
           FROM kad left outer join kas on kad.kas=kas.kas  
           left outer join  sub on kas.acc=sub.acc
           WHERE @jurnal=kad.kas
) as xacd  

end

If @jurnal<>space(15)
  Exec sp_SaveInv @subjurnal,@jurnal
*/









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO









































































CREATE                                             PROCEDURE sp_saveacd @subjurnal char(15), @jurnal char(15)  AS

declare @v0koma1 float
declare @v1bagi11 float
declare @v1koma1 float
declare @v10bagi11 FLOAT
declare @slspebulatan char(15)
declare @ppnbedamasa char(15)

set @v0koma1=0.1000
set @v1bagi11=1.0000/11.0000
set @v1koma1=1.1000
set @v10bagi11=10.0000/11.0000

set @slspebulatan='71990301'
set @ppnbedamasa='11070103'
-- jurnal, period, acc, date, val, cct, remark, dk, subjurnal, 

if @subjurnal='LPB'  --LPB LOKAL
Begin
insert into acd select * from (
/*  *** Hutang Belum Difakturkan ***/  
SELECT lph.lph as jurnal, lph.period, isnull((select acc from accgl where remark='ACCPAY'),space(15)) as acc, lph.date, 
	sum((((lpd.price*case when inv.unit=lpd.unit then lpd.qty else lpd.qty/inv.besar end)*(100.00-lph.disc)/100.00)*(100.00-lpd.disc)/100.00)*lph.kurs*case when lph.ppn=2 then @V10Bagi11 else 1 end) as val,   
	space(15) as cct, lph.remark,'K' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM lpd
	left outer join lph on lpd.lph=lph.lph
	left outer join inv on lpd.inv=inv.inv
	WHERE lph.lph=@jurnal and (select top 1 isnull(aprov,0) from oms where oms.oms=lph.oms)<>1
	GROUP BY lph.lph, lph.period, lph.date, lph.remark
union all  
/*  *** Persediaan ***/  
SELECT ind.jurnal, ind.period, isnull(jenis.acc,space(15)) as acc, ind.date, sum(ind.val) as val,   
	space(15) as cct, 'Posting Persediaan' as remark, ind.dk, @subjurnal as  subjurnal, 0 as adj
	FROM ind
	left outer join inv on ind.inv=inv.inv
	left outer join jenis on inv.jenis=jenis.jenis
	WHERE ind.jurnal=@jurnal and jenis.acc<>space(15)
	GROUP BY ind.jurnal, ind.period, jenis.acc, ind.date,ind.dk
) as xacd  
End

if @subjurnal='POO'  ---LPB PO IMPORT
Begin
insert into acd select * from (
/*  *** Persediaan Brg Dalam Perjalanan ***/  
SELECT ind.jurnal, ind.period,isnull((select acc from accgl where remark='ACCMAT'),space(15)) as acc, ind.date, sum(ind.val) as val,   
	space(15) as cct, 'Posting Persediaan Dlm Perjalanan' as remark, 'K' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM ind
	left outer join inv on ind.inv=inv.inv
	WHERE ind.jurnal=@jurnal
	GROUP BY ind.jurnal, ind.period, ind.date,ind.dk
union all  
/*  *** Persediaan ***/  
SELECT ind.jurnal, ind.period, isnull(jenis.acc,space(15)) as acc, ind.date, sum(ind.val) as val,   
	space(15) as cct, 'Posting Persediaan' as remark, ind.dk, @subjurnal as  subjurnal, 0 as adj
	FROM ind
	left outer join inv on ind.inv=inv.inv
	left outer join jenis on inv.jenis=jenis.jenis
	WHERE ind.jurnal=@jurnal
	GROUP BY ind.jurnal, ind.period, jenis.acc, ind.date,ind.dk
) as xacd  
End



if @subjurnal='MSK'
Begin
insert into acd select * from (  
/*  *** Hutang Dagang Belum Difakturkan***/  
	SELECT msk.msk AS jurnal, msk.period, isnull((select acc from accgl where remark=
	case when msk.group_=1 then 'ACCPAY' else
		case when (select aprov from oms where oms.oms=msk.oms) =2 then 'ACCMAT' else
			case when (select aprov from oms where oms.oms=msk.oms) =3 then 'ACCFA ' else ' '
			end
		end
	end
	),space(15)) as acc, msk.date, 
	(msd.val-msd.ppn)*msk.kurs as val,   
	space(15) as cct, msd.remark, 'D' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM msd left outer join msk on msd.msk=msk.msk	
	WHERE msd.msk=@jurnal and (select top 1 isnull(aprov,0) from oms where oms.oms=msk.oms)<>1
union all
/*  *** Hutang Dagang ***/  
	SELECT msk.msk AS jurnal, msk.period,grp.acc, msk.date, 
	(msk.val*msk.kurs) as val,
	space(15) as cct, msk.remark, 'K' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM msk
	-- left outer join msk on msd.msk=msk.msk	
	left outer join sub on msk.sub=sub.sub
	left outer join grp on sub.grp=grp.grp
	WHERE msk.msk=@jurnal 
union all
/*  *** Biaya ***/  
	SELECT msk.msk AS jurnal, msk.period,msx.acc, msk.date, 
	abs(msx.val*msk.kurs) as val,   
	msx.cct as cct, msx.remark,case when msx.val >0 then 'D' else 'K' end as DK, @subjurnal as  subjurnal, 0 as adj
	FROM msx
	left outer join msk on msx.msk=msk.msk	
	WHERE msx.msk=@jurnal and (msx.cad=space(15) or msx.cad is null)
union all
--jika Biaya ada cadangan
SELECT msx.msk as jurnal, msk.period,msx.acc as acc, msk.date, 
        (select cadet.val from cadet where cadet.cad=msx.cad and cadet.nocad<>'') as  val,   
	msx.cct as cct, msx.remark,  msx.dk as dk, @subjurnal as  subjurnal, 0 as adj
	FROM msx left outer join msk on msx.msk=msk.msk
	WHERE  msx.msk=@jurnal and msx.cad<>''
union all
SELECT msx.msk as jurnal, msk.period,@slspebulatan as acc, msk.date, abs((select cadet.val from cadet where cadet.cad=msx.cad and cadet.nocad<>'')-(round(msx.val,2)*msk.kurs)) val,   
	msx.cct as cct, msx.remark,  
	case when ((select cadet.val from cadet where cadet.cad=msx.cad and cadet.nocad<>'')-(round(msx.val,2)*msk.kurs))<0 then 'D' else 'K' end  as dk,@subjurnal as  subjurnal, 0 as adj
	FROM msx left outer join msk on msx.msk=msk.msk 
	WHERE  msx.msk=@jurnal and msx.cad<>'' and (select cadet.val from cadet where cadet.cad=msx.cad and cadet.nocad<>'')-(round(msx.val,2)*msk.kurs)<>0
union all
/*  *** Hutang Belum Difakturkan ***/  
	SELECT msk.msk AS jurnal, msk.period,isnull((select acc from accgl where remark='ACCPAY'),space(15)) as acc, msk.date, 
	msx.val*msk.kurs as val,   
--	space(15) as cct, msx.remark, case when msx.dk='D' then 'K' else 'D' end  as dk, @subjurnal as  subjurnal, 0 as adj
	space(15) as cct, msx.remark, 'K' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM msx
	left outer join msk on msx.msk=msk.msk	
	WHERE msx.msk=@jurnal  and (select top 1 isnull(aprov,0) from oms where oms.oms=msk.oms)<>1
union all
/*  *** PPn ***/ 
SELECT msk.msk AS jurnal, msk.period,grp.accppn, msk.date, 
	msd.ppn*msk.kurs as val,   
	space(15) as cct, msd.remark, 'D' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM msd
	left outer join msk on msd.msk=msk.msk	
	left outer join sub on msk.sub=sub.sub
	left outer join grp on sub.grp=grp.grp
	WHERE msd.msk=@jurnal and msk.ppn>1 and month(msk.date)=month(msd.tglsfp)
union all 
/*  *** PPn beda masa***/ 
	SELECT msk.msk AS jurnal, msk.period,@ppnbedamasa as acc, msk.date, 
	msd.ppn*msk.kurs as val,   
	space(15) as cct, msd.remark, 'D' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM msd
	left outer join msk on msd.msk=msk.msk	
	left outer join sub on msk.sub=sub.sub
	left outer join grp on sub.grp=grp.grp
	WHERE msd.msk=@jurnal and msk.ppn>1 and month(msk.date)<>month(msd.tglsfp)
union all

/*  *** Uang Muka */
	SELECT msk.msk AS jurnal, msk.period, umkp.acc, msk.date, 
	isnull(sum((umkp.val)*msk.kurs),0) as val, 
	space(15) as cct, msk.remark, 'K' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM umkp left outer join msk on umkp.msk=msk.msk
	--left outer join sub on msk.sub=sub.sub
	--left outer join grp on sub.grp=grp.grp
	WHERE umkp.msk=@jurnal and msk.ppn >= 1              
	GROUP BY msk.msk, msk.period, umkp.acc,msk.ppn, msk.date, msk.remark
union all  
 SELECT msk.msk AS jurnal, msk.period, isnull((select acc from accgl where remark=
	case when msk.group_=1 then 'ACCPAY' else
		case when (select aprov from oms where oms.oms=msk.oms) =2 then 'ACCMAT' else
			case when (select aprov from oms where oms.oms=msk.oms) =3 then 'ACCFA ' else ' '
			end
		end
	end
	),space(15)) as acc, msk.date, 
	((umkp.val)*msk.kurs)*(case when msk.ppn=2 then @v1koma1 else case when msk.ppn=3 then @v10bagi11 else 1 end end) as val,   
	space(15) as cct, umkp.remark, 'D' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM umkp left outer join msk on umkp.msk=msk.msk	
	WHERE umkp.msk=@jurnal and msk.group_='2'
) as xacd  
End 

if @subjurnal='MSI'  --Pembelian Import 
Begin
insert into acd select * from (  
/*  *** Hutang Dagang ***/  
	SELECT msk.msk AS jurnal, msk.period,grp.acc, msk.date, 
	msk.val*msk.kurs as val,   
	space(15) as cct, msd.remark, 'K' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM msd
	 left outer join msk on msd.msk=msk.msk	
	left outer join sub on msk.sub=sub.sub
	left outer join grp on sub.grp=grp.grp
	WHERE msd.msk=@jurnal 
union all
SELECT msk.msk AS jurnal, msk.period,isnull((select acc from accgl where remark='ACCMAT'),space(15)) as acc, msk.date, 
	msd.val*msk.kurs as val,   
	space(15) as cct, msd.remark, 'D' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM msd
	 left outer join msk on msd.msk=msk.msk	
	left outer join sub on msk.sub=sub.sub
	WHERE msd.msk=@jurnal and (select count(msx.acc) as tot from msx where msx.msk=@jurnal)<1
union all
/*  *** Uang Muka */
	SELECT msk.msk AS jurnal, msk.period, umkp.acc, msk.date, 
	isnull(sum((umkp.val)*msk.kurs),0)*(case when msk.ppn=2 then @v1koma1 else case when msk.ppn=3 then @v10bagi11 else 1 end end) as val, 
	space(15) as cct, msk.remark, 'K' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM umkp left outer join msk on umkp.msk=msk.msk
	--left outer join sub on msk.sub=sub.sub
	--left outer join grp on sub.grp=grp.grp
	WHERE umkp.msk=@jurnal              
	GROUP BY msk.msk, msk.period,msk.ppn, umkp.acc, msk.date, msk.remark
union all
/*  *** Biaya ***/  
	SELECT msk.msk AS jurnal, msk.period,msx.acc, msk.date, 
	msx.val*msk.kurs as val,   
	msx.cct as cct, msx.remark, 'D', @subjurnal as  subjurnal, 0 as adj
	FROM msx
	left outer join msk on msx.msk=msk.msk	
	WHERE msx.msk=@jurnal and (select count(msx.acc) tot from msx where msx.msk=@jurnal)>=1
--union all  
 /*  *** PPn Uang Muka */
	/*SELECT msk.msk AS jurnal, msk.period, grp.accppn, msk.date, 
	isnull(sum((umkp.val)*case when msk.ppn=2 then @v1bagi11 else case when msk.ppn=3 then @v0koma1 else 0 end end*msk.kurs),0) as val,   
	space(15) as cct, msk.remark, 'K' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM umkp left outer join msk on umkp.msk=msk.msk
	left outer join sub on msk.sub=sub.sub
	left outer join grp on sub.grp=grp.grp
	WHERE umkp.msk=@jurnal and msk.ppn > 1          
	GROUP BY msk.msk, msk.period, grp.accppn, msk.date, msk.remark*/
) as xacd  
End 

if @subjurnal='RMA'
Begin
insert into acd select * from (  
/*  *** Hutang Belum Difakturkan ***/  
SELECT rma.rma as jurnal, rma.period, isnull((select acc from accgl where remark='ACCPAY'),space(15)) as acc, rma.date, 
	(select sum(ind.val) from ind where ind.jurnal=@jurnal) as val,   
	space(15) as cct, rma.remark,'D' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM rma
	WHERE rma.rma=@jurnal	and (select left(max(ind.inv),1) from ind where ind.jurnal=@jurnal)<>'7'
union all  
/*  *** Persediaan ***/  
SELECT ind.jurnal, ind.period, isnull(jenis.acc,space(15)) as acc, ind.date, sum(ind.val) as val,   
	space(15) as cct, 'Posting Persediaan' as remark, ind.dk, @subjurnal as  subjurnal, 0 as adj
	FROM ind
	left outer join inv on ind.inv=inv.inv
	left outer join jenis on inv.jenis=jenis.jenis
	WHERE ind.jurnal=@jurnal and (left(ind.inv,1)<>'7')	
	GROUP BY ind.jurnal, ind.period, jenis.acc, ind.date,ind.dk
) as xacd  
End  

if @subjurnal='RMS' and (select top 1 left(inv,1) from rmd where rms=@jurnal)<>'7'
Begin
insert into acd select * from (  
/*  *** Hutang Dagang ***/  
	SELECT rms.rms AS jurnal, rms.period, grp.acc, rms.date, rms.val*rms.kurs as val,   
	space(15) as cct, rms.remark, 'D' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM rms 
	left outer join sub on rms.sub=sub.sub
	left outer join grp on sub.grp=grp.grp
	WHERE rms.rms=@jurnal           
union all  
/*  *** PPn ***/  
	SELECT rms.rms AS jurnal, rms.period, grp.accppn, rms.date, 
	isnull(sum((((rmd.val)*(100.00-rms.disc)/100.00)*(100.00-rmd.disc)/100.00)*case when rms.ppn=2 then @v1bagi11 else case when rms.ppn=3 then @v0koma1 else 0 end end),0)*rms.kurs as val,   
	--isnull(sum((((rmd.price*case when rmd.unit=inv.unit then rmd.qty else rmd.qty/inv.besar end)*(100.00-rms.disc)/100.00)*(100.00-rmd.disc)/100.00)*case when rms.ppn=2 then @v1bagi11 else case when rms.ppn=3 then @v0koma1 else 0 end end),0)*rms.kurs as val,   
	space(15) as cct, rms.remark, 'K' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM rmd left outer join rms on rmd.rms=rms.rms
	left outer join sub on rms.sub=sub.sub
	left outer join grp on sub.grp=grp.grp
	left outer join inv on rmd.inv=inv.inv
	WHERE rmd.rms=@jurnal and rms.ppn > 1          
	GROUP BY rms.rms, rms.period, grp.accppn, rms.date, rms.remark,rms.kurs
union all  
/*  *** Hutang Belum Difakturkan ***/  
SELECT rms.rms as jurnal, rms.period, isnull((select acc from accgl where remark='ACCPAY'),space(15)) as acc, rms.date, 
	sum((((rmd.val)*(100.00-rms.disc)/100.00)*(100.00-rmd.disc)/100.00)*rms.kurs*case when rms.ppn=2 then @V10Bagi11 else 1 end) as val,   
	space(15) as cct, rms.remark,'K' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM rmd
	left outer join rms on rmd.rms=rms.rms
	left outer join inv on rmd.inv=inv.inv
	WHERE rms.rms=@jurnal
	GROUP BY rms.rms, rms.period, rms.date, rms.remark
union all
/*  *** Selisih Pengembalian Barang dengan Retur Pembelian ***/  
	SELECT jurnal,period, acc,date,sum(abs(rmdval-indval)) as val,cct as cct, 'Posting Selisih Persediaan' as remark, 
	case when (rmdval-indval)>=0 then 'K' else 'D' end  as dk,
	@subjurnal as  subjurnal, 0 as adj
	FROM 
	(
		SELECT rmd.rms as jurnal,rms.period,rms.date, 
		rmd.qty,(((rmd.price*case when rmd.unit=inv.unit then rmd.qty else rmd.qty/inv.besar end)*(100.00-rms.disc)/100.00)*(100.00-rmd.disc)/100.00)*case when rms.ppn=2 then @V10Bagi11 else 1 end*rms.kurs as rmdval,
		ind.val as indval,  rms.cct as cct, 'Posting Selisih Persediaan' as remark, (select acc from accgl where remark='ACCRMS') as acc
		FROM 
		rmd left outer join rms on rmd.rms=rms.rms
		left outer join ind on rms.rma=ind.jurnal
		left outer join inv on rmd.inv=inv.inv
		left outer join jenis on inv.jenis=jenis.jenis
		where rmd.rms=@jurnal and isnull(inv.acc,space(15))=' '
	) as xind 
	GROUP BY jurnal,period,acc,date,cct, rmdval, indval
union all
/*  *** Hutang Belum Difakturkan ***/  
	SELECT jurnal,period,acc,date,sum(abs(rmdval-indval)) as val,space(15) as cct, 'Posting Selisih Persediaan' as remark, 
	case when (rmdval-indval)>=0 then 'D' else 'K' end  as dk,
	@subjurnal as  subjurnal, 0 as adj
	FROM 
	(
		SELECT rmd.rms as jurnal,rms.period,rms.date, 
		rmd.qty,(((rmd.price*case when rmd.unit=inv.unit then rmd.qty else rmd.qty/inv.besar end)*(100.00-rms.disc)/100.00)*(100.00-rmd.disc)/100.00)*case when rms.ppn=2 then @V10Bagi11 else 1 end*rms.kurs as rmdval,
		ind.val as indval,  space(15) as cct, 'Posting Selisih Persediaan' as remark, isnull((select acc from accgl where remark='ACCPAY'),space(15)) as acc
		FROM 
		rmd left outer join rms on rmd.rms=rms.rms
		left outer join ind on rms.rma=ind.jurnal
		left outer join inv on rmd.inv=inv.inv
		where rmd.rms=@jurnal
	) as xind 
	GROUP BY jurnal,period,acc,date, rmdval, indval
) as xacd  
End  

----Return jika jasa
if @subjurnal='RMS' and (select top 1 left(inv,1) from rmd where rms=@jurnal)='7'
Begin
insert into acd select * from (  
/*  *** Hutang Dagang ***/  
	SELECT rms.rms AS jurnal, rms.period, grp.acc, rms.date, rms.val*rms.kurs as val,   
	space(15) as cct, rms.remark, 'D' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM rms 
	left outer join sub on rms.sub=sub.sub
	left outer join grp on sub.grp=grp.grp
	WHERE rms.rms=@jurnal           
union all  
/*  *** PPn ***/  
	SELECT rms.rms AS jurnal, rms.period, grp.accppn, rms.date, 
	isnull(sum((((rmd.price*case when rmd.unit=inv.unit then rmd.qty else rmd.qty/inv.besar end)*(100.00-rms.disc)/100.00)*(100.00-rmd.disc)/100.00)*case when rms.ppn=2 then @v1bagi11 else case when rms.ppn=3 then @v0koma1 else 0 end end),0)*rms.kurs as val,   
	space(15) as cct, rms.remark, 'K' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM rmd left outer join rms on rmd.rms=rms.rms
	left outer join sub on rms.sub=sub.sub
	left outer join grp on sub.grp=grp.grp
	left outer join inv on rmd.inv=inv.inv
	WHERE rmd.rms=@jurnal and rms.ppn > 1          
	GROUP BY rms.rms, rms.period, grp.accppn, rms.date, rms.remark,rms.kurs
/**Biaya able msx  */
union all
SELECT rms.rms AS jurnal, rms.period, rmd.msk, rms.date, 
	rmd.price*rmd.qty*rms.kurs,
	rms.cct  as cct, rms.remark, 'K' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM rmd left outer join rms on rmd.rms=rms.rms
	left outer join sub on rms.sub=sub.sub where rms.rms=@jurnal  
) as xacd  
End  

if @subjurnal='SJH'
Begin
insert into acd select * from (  
/*  *** Harga Pokok Penjualan Belum Difakturkan ***/  
SELECT ind.jurnal, ind.period, isnull((select max(acc) from accgl where remark='ACCHPPT'),space(15)) as acc, ind.date, sum(ind.val) as val,   
	space(15) as cct, 'Posting HPP Belum Difakturkan' as remark, 'D' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM ind
	left outer join inv on ind.inv=inv.inv
	WHERE ind.jurnal=@jurnal
	GROUP BY ind.jurnal, ind.period,  ind.date,ind.dk
union all  
/*  *** Persediaan ***/  
SELECT ind.jurnal, ind.period, isnull(jenis.acc,space(15)) as acc, ind.date, sum(ind.val) as val,   
	space(15) as cct, 'Posting Persediaan' as remark, 'K' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM ind
	left outer join inv on ind.inv=inv.inv
	left outer join jenis on inv.jenis=jenis.jenis
	WHERE ind.jurnal=@jurnal
	GROUP BY ind.jurnal, ind.period, jenis.acc, ind.date,ind.dk
union all
/* POSTING ONGKOS ANGKUT */
SELECT sjh.sjh, sjh.period, sub.acc as acc, sjh.date, sum(sjd.qty)*(select valkg from okl where okl=sjh.nopo) as val,  
	space(15) as cct, sub.name as remark, 'D' as dk, 'SJH' as  subjurnal, 0 as adj
	FROM sjd
	left outer join sjh on sjd.sjh=sjh.sjh
	left outer join sub on sjh.angkutan=sub.sub
	WHERE sjd.sjh=@jurnal and sub.acc<>''
	GROUP BY sjh.sjh, sjh.period,sub.acc,sub.name,sjh.date,sjh.nopo
union all  
/* POSTING LAWAN ONGKOS ANGKUT */
SELECT sjh.sjh, sjh.period, sub.accrev as acc, sjh.date, sum(sjd.qty)*(select valkg from okl where okl=sjh.nopo) as val,  
	space(15) as cct, sub.name as remark, 'K' as dk, 'SJH' as  subjurnal, 0 as adj
	FROM sjd
	left outer join sjh on sjd.sjh=sjh.sjh
	left outer join sub on sjh.angkutan=sub.sub
	WHERE sjd.sjh=@jurnal and sub.acc<>''
	GROUP BY sjh.sjh, sjh.period,sub.name,sub.accrev,sjh.date,sjh.nopo
) as xacd  
End  

if @subjurnal='KLR'
Begin
insert into acd select * from (  
/*  *** Piutang Dagang ***/  
	SELECT klr.klr AS jurnal, klr.period, grp.acc, klr.date, (klr.val*klr.kurs) as val,   
	space(15) as cct, klr.remark, 'D' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM klr 
	left outer join sub on klr.sub=sub.sub
--	left outer join umk on klr.klr=umk.klr
	left outer join grp on sub.grp=grp.grp
	WHERE klr.klr=@jurnal    
union all 
/* ***pelunasan dgn uang muka****/
	SELECT klr.klr AS jurnal, klr.period, grp.acc, klr.date,isnull(umk.val*klr.kurs,0) as val,   
	space(15) as cct, klr.remark, 'K' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM klr 
	left outer join sub on klr.sub=sub.sub
	left outer join umk on klr.klr=umk.klr
	left outer join grp on sub.grp=grp.grp
	WHERE klr.klr=@jurnal and umk.jurnal<>''   

      
union all  
/*  *** Penjualan ***/  
	SELECT klr.klr AS jurnal, klr.period, inv.accrev, klr.date, 
	sum((kld.price*case when kld.unit=inv.unit then kld.qty else kld.qty/inv.besar end)*case when klr.ppn=2 then @v10bagi11 else 1 end*klr.kurs) as valrp,   
	space(15) as cct, klr.remark, 'K' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM kld left outer join klr on kld.klr=klr.klr
	left outer join inv on kld.inv=inv.inv
	WHERE kld.klr=@jurnal
	GROUP BY klr.klr, klr.period, inv.accrev, klr.date, klr.remark
union all  
/*  *** PPn ***/  
select jurnal,period,accppn,date,isnull(val,0)-(select discrp*0.1 from klr where klr.klr=@jurnal),cct,remark,dk,subjurnal,adj from 
(
	SELECT klr.klr AS jurnal, klr.period, grp.accppn, klr.date, 
	isnull(sum((((kld.price*case when kld.unit=inv.unit then kld.qty else kld.qty/inv.besar end)*(100.00-klr.disc)/100.00)*(100.00-kld.disc)/100.00)*case when klr.ppn=2 then @v1bagi11 else case when klr.ppn=3 then @v0koma1 else 0 end end*klr.kurs),0) as val,   
	space(15) as cct,(rtrim(max(sub.name))+' '+ klr.remark)as remark, 'K' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM kld left outer join klr on kld.klr=klr.klr
	left outer join sub on klr.sub=sub.sub
	left outer join grp on sub.grp=grp.grp
	left outer join inv on kld.inv=inv.inv	WHERE kld.klr=@jurnal and klr.ppn > 1          
	GROUP BY klr.klr, klr.period, grp.accppn, klr.date, klr.remark
) as ppnklr
union all  

/*  *** Uang Muka */
	SELECT klr.klr AS jurnal, klr.period, umk.acc, klr.date, 
	isnull(sum((umk.val)*klr.kurs),0) as val, 
	space(15) as cct, max(umk.remark), 'D' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM umk left outer join klr on umk.klr=klr.klr
	--left outer join sub on klr.sub=sub.sub
	--left outer join grp on sub.grp=grp.grp
	WHERE umk.klr=@jurnal and klr.ppn > 1              
	GROUP BY klr.klr, klr.period, umk.acc, klr.date
union all  
 /*  *** PPn Uang Muka */
	SELECT klr.klr AS jurnal, klr.period, grp.accppn, klr.date, 
	isnull(sum((umk.val)*case when klr.ppn=2 then @v1bagi11 else case when klr.ppn=3 then @v0koma1 else 0 end end*klr.kurs),0) as val,   
	space(15) as cct,rtrim(max(sub.name))+' '+klr.remark, 'D' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM umk left outer join klr on umk.klr=klr.klr
	left outer join sub on klr.sub=sub.sub
	left outer join grp on sub.grp=grp.grp
	WHERE umk.klr=@jurnal and klr.ppn > 1          
	GROUP BY klr.klr, klr.period, grp.accppn, klr.date, klr.remark
union all  
/*  *** Discount ***/  
select jurnal,period,accdisc,date,isnull(valrp,0)+(select discrp from klr where klr.klr=@jurnal),cct,remark,dk,subjurnal,adj from (
	SELECT klr.klr AS jurnal, klr.period, inv.accdisc, klr.date, 
	sum((((kld.price*case when kld.unit=inv.unit then kld.qty else kld.qty/inv.besar end)*klr.disc/100.00)+
	((kld.price*case when kld.unit=inv.unit then kld.qty else kld.qty/inv.besar end)-
	((kld.price*case when kld.unit=inv.unit then kld.qty else kld.qty/inv.besar end)*klr.disc/100.00))*kld.disc/100.00)*klr.kurs) as valrp,   
	space(15) as cct, klr.remark, 'D' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM kld left outer join klr on kld.klr=klr.klr
	left outer join inv on kld.inv=inv.inv
	WHERE kld.klr=@jurnal and (klr.disc > 0 or kld.disc > 0 or klr.discrp>0 )
	GROUP BY klr.klr, klr.period, inv.accdisc, klr.date, klr.remark
) as disc
union all  
/*  *** Harga Pokok Penjualan ***/  
SELECT kld.klr, ind.period, isnull(inv.acchpp,space(15)) as acc, ind.date, sum((ind.val/ind.qty)*kld.qty) as val,   
	space(15) as cct, 'Posting HPP' as remark, 'D' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM kld 
             left outer join klr on kld.klr=klr.klr
	left outer join ind on kld.sjh+kld.inv=ind.jurnal+ind.inv
	left outer join inv on ind.inv=inv.inv
	WHERE klr.klr=@jurnal
	GROUP BY kld.klr, ind.period, inv.acchpp, ind.date,ind.dk
union all  
/*  *** Harga Pokok Penjualan Belum Difakturkan *** */
SELECT klr.klr, ind.period, isnull((select max(acc) from accgl where remark='ACCHPPT'),space(15)) as acc, ind.date, sum(ind.val) as val,   
	space(15) as cct, 'Posting HPP Belum Difakturkan' as remark, 'K' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM kld 
        left outer join klr on kld.klr=klr.klr
	left outer join ind on kld.sjh=ind.jurnal
	left outer join inv on ind.inv=inv.inv
	WHERE klr.klr=@jurnal
	GROUP BY klr.klr, ind.period, ind.date,ind.dk
union all
/* *** Harga Pokok Penjualan varian  Belum Difakturkan *** */
SELECT klr,period,acc,date,abs(val-valklr) as val,cct,remark, (case when val<valklr then 'K' else 'D' end) as dk,@subjurnal as subjurnal,0 as adj from
              (select kld.klr, ind.period, isnull((select max(acc) from accgl where remark='ACCHPPV'),space(15)) as acc, ind.date, 
             sum(ind.val) as val,   sum((ind.val/ind.qty)*kld.qty) as valklr, 
	space(15) as cct, 'Posting HPP Varian Belum Difakturkan' as remark, @subjurnal as  subjurnal, 0 as adj
	FROM kld 
	left outer join klr on kld.klr=klr.klr
	left outer join ind on kld.sjh+kld.inv=ind.jurnal+ind.inv
	left outer join inv on ind.inv=inv.inv
	WHERE klr.klr=@jurnal
	GROUP BY kld.klr, ind.period, ind.date,ind.dk	) as HPPV
) as xacd  
End  

if @subjurnal='RKA'
Begin
insert into acd select * from (  
/*  *** Harga Pokok Penjualan Belum Difakturkan ***/  
SELECT ind.jurnal, ind.period, isnull((select max(acc) from accgl where remark='ACCHPPT'),space(15)) as acc, ind.date, sum(ind.val) as val,   
	space(15) as cct, 'Posting HPP Belum Difakturkan' as remark, 'K' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM ind
	left outer join inv on ind.inv=inv.inv
	WHERE ind.jurnal=@jurnal
	GROUP BY ind.jurnal, ind.period,  ind.date,ind.dk
union all  
/*  *** Persediaan ***/  
SELECT ind.jurnal, ind.period, isnull(jenis.acc,space(15)) as acc, ind.date, sum(ind.val) as val,   
	space(15) as cct, 'Posting Persediaan' as remark, 'D' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM ind
	left outer join inv on ind.inv=inv.inv
	left outer join jenis on inv.jenis=jenis.jenis
	WHERE ind.jurnal=@jurnal
	GROUP BY ind.jurnal, ind.period, jenis.acc, ind.date,ind.dk
) as xacd  
End  

if @subjurnal='RKL'
Begin
insert into acd select * from (  
/*  *** Piutang Dagang ***/  
	SELECT rkl.rkl AS jurnal, rkl.period, grp.acc, rkl.date, rkl.val*rkl.kurs as val,   
	space(15) as cct, rkl.remark, 'K' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM rkl 
	left outer join sub on rkl.sub=sub.sub
	left outer join grp on sub.grp=grp.grp
	WHERE rkl.rkl=@jurnal           
union all  
/*  *** Retur Penjualan ***/  
	SELECT rkl.rkl AS jurnal, rkl.period, inv.accreturn, rkl.date, 
	sum((rkd.price*case when rkd.unit=inv.unit then rkd.qty else rkd.qty/inv.besar end)*case when rkl.ppn=2 then @v10bagi11 else 1 end*rkl.kurs) as valrp,   
	space(15) as cct, rkl.remark, 'D' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM rkd left outer join rkl on rkd.rkl=rkl.rkl
	left outer join inv on rkd.inv=inv.inv
	WHERE rkd.rkl=@jurnal      
	GROUP BY rkl.rkl, rkl.period, inv.accreturn, rkl.date, rkl.remark
union all  
/*  *** PPn ***/  
	SELECT rkl.rkl AS jurnal, rkl.period, grp.accppn, rkl.date, 
	isnull(sum((((rkd.price*case when rkd.unit=inv.unit then rkd.qty else rkd.qty/inv.besar end)*(100.00-rkl.disc)/100.00)*(100.00-rkd.disc)/100.00)*case when rkl.ppn=2 then @v1bagi11 else case when rkl.ppn=3 then @v0koma1 else 0 end end*rkl.kurs),0) as val,   
	space(15) as cct, rkl.remark, 'D' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM rkd left outer join rkl on rkd.rkl=rkl.rkl
	left outer join sub on rkl.sub=sub.sub
	left outer join grp on sub.grp=grp.grp
	left outer join inv on rkd.inv=inv.inv
	WHERE rkd.rkl=@jurnal and rkl.ppn > 1          
	GROUP BY rkl.rkl, rkl.period, grp.accppn, rkl.date, rkl.remark
union all  
/*  *** Discount ***/  
	SELECT rkl.rkl AS jurnal, rkl.period, grp.accdisc, rkl.date, 
	sum((((rkd.price*case when rkd.unit=inv.unit then rkd.qty else rkd.qty/inv.besar end)*rkl.disc/100.00)+
	((rkd.price*case when rkd.unit=inv.unit then rkd.qty else rkd.qty/inv.besar end)-
	((rkd.price*case when rkd.unit=inv.unit then rkd.qty else rkd.qty/inv.besar end)*rkl.disc/100.00))*rkd.disc/100.00)*rkl.kurs) as valrp,   
	space(15) as cct, rkl.remark, 'K' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM rkd left outer join rkl on rkd.rkl=rkl.rkl
	left outer join sub on rkl.sub=sub.sub
	left outer join grp on sub.grp=grp.grp
	left outer join inv on rkd.inv=inv.inv
	WHERE rkd.rkl=@jurnal and (rkl.disc > 0 or rkd.disc > 0 )
	GROUP BY rkl.rkl, rkl.period, grp.accdisc, rkl.date, rkl.remark
union all  
/*  *** Harga Pokok Penjualan ***/  
SELECT rkl.rkl, ind.period, isnull((select max(acc) from accgl where remark='ACCHPPT'),space(15)) as acc, ind.date, sum(ind.val) as val,   
	space(15) as cct, 'Posting HPP Belum Difakturkan' as remark, 'D' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM rkl
	left outer join ind on rkl.rka=ind.jurnal
	left outer join inv on ind.inv=inv.inv
	WHERE rkl.rkl=@jurnal
	GROUP BY rkl.rkl, ind.period, ind.date,ind.dk
union all  
/*  *** Persediaan ***/  
SELECT rkl.rkl, ind.period, isnull(inv.acchpp,space(15)) as acc, ind.date, sum(ind.val) as val,   
	space(15) as cct, 'Posting  HPP' as remark, 'K' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM rkl
	left outer join ind on rkl.rka=ind.jurnal
	left outer join inv on ind.inv=inv.inv
	WHERE rkl.rkl=@jurnal
	GROUP BY rkl.rkl, ind.period, inv.acchpp, ind.date,ind.dk
) as xacd  
End  

If @subjurnal='JIN'  
Begin  
insert into acd select * from (  
/*  *** Perkiraan Biaya ***/  
SELECT jurnal, period, acc , date, abs(val) as val,
	cct as cct, 'Posting Jurnal Persediaan Header' as remark, case when val<=0 then 'D' else 'K' end as dk, @subjurnal as  subjurnal, 0 as adj
	FROM
	(	
	/*SELECT ind.jurnal , ind.period, isnull(jenis.accmt,space(15)) as acc, ind.date, sum(ind.val)  as val,
	space(15) as cct, 'Posting Jurnal Persediaan Detail' as remark, ind.dk, @subjurnal as  subjurnal, 0 as adj
	FROM ind
	left outer join loc on ind.loc=loc.kode
        left outer join inv on ind.inv=inv.inv
	left outer join jenis on inv.jenis=jenis.jenis
	WHERE ind.jurnal=@jurnal
	GROUP BY ind.jurnal , ind.period, jenis.accmt,  ind.date, ind.dk*/
	SELECT jid.jin as jurnal, jin.period,(case when jin.group_=2 then jin.acc else jenis.accmt end) as acc, jin.date, sum(ind.val*case when ind.dk='D' then 1 else -1 end) as val,MAX(JIN.CCT) AS CCT
		FROM jid
		left outer join jin on jid.jin=jin.jin
		left outer join inv on jid.inv=inv.inv
		left outer join jenis on inv.jenis=jenis.jenis
        	left outer join 
		(select distinct jurnal,period,inv,loc,date,qty,round(val,5) as val,rem,dk,subjurnal from ind where ind.jurnal=@jurnal) as ind on jid.jin+jid.inv+jid.loc=ind.jurnal+ind.inv+ind.loc and jid.qty=ind.qty
                WHERE jid.jin=@jurnal and jin.group_<>4
		GROUP BY jid.jin, jin.period,(case when jin.group_=2 then jin.acc else jenis.accmt end), jin.date	
) as xind
union all
/*  *** Persediaan ***/  
SELECT ind.jurnal , ind.period, isnull(jenis.acc,space(15)) as acc, ind.date, sum(round(ind.val,5))  as val,
	space(15) as cct, 'Posting Jurnal Persediaan Detail' as remark, ind.dk, @subjurnal as  subjurnal, 0 as adj
	FROM ind
	left outer join loc on ind.loc=loc.kode
        left outer join inv on ind.inv=inv.inv
	left outer join jenis on inv.jenis=jenis.jenis
	WHERE ind.jurnal=@jurnal and left(jurnal,1)<>'.'
	GROUP BY ind.jurnal , ind.period, jenis.acc,  ind.date, ind.dk
union all
--biaya penyusutan aktiva tetap
SELECT jid.jin as jurnal, jin.period,inv.accsls as acc, jin.date,jid.val*prosent/100 as val,
    	mfd.cct as cct, 'B.Penyusutan Akt Tetap '+rtrim(inv.inv) as remark,jid.dk,@subjurnal,0 as adj
	from jid left outer join jin on jid.jin=jin.jin left outer join inv on jid.inv=inv.inv
	left outer join mfd on inv.inv=mfd.inv where jin.group_=4 and jin.jin=@jurnal

--akumulasi penyusutan akt tetap
union all
SELECT jid.jin as jurnal, jin.period,loc.accakm as acc, jin.date,jid.val,
	' ' as cct, 'Akm Peny. Akt Tetap '+rtrim(inv.inv) as remark,case when jid.dk='D' then 'K' else 'D' end,@subjurnal,0 as adj
	from jid left outer join jin on jid.jin=jin.jin left outer join inv on jid.inv=inv.inv
	left outer join loc on inv.acc=loc.acc
	where jin.group_=4 and jin.jin=@jurnal and loc.kode=''
) as xacd
End

If @subjurnal='TRM'  
Begin  
insert into acd select * from (  
/*  *** Persediaan ***/  

SELECT ind.jurnal , ind.period, isnull(jenis.acc,space(15)) as acc, ind.date, sum(ind.val)  as val,
	space(15) as cct, 'Posting Jurnal Transfer Persediaan' as remark, ind.dk, @subjurnal as  subjurnal, 0 as adj
	FROM ind
	left outer join loc on ind.loc=loc.kode
	left outer join inv on ind.inv=inv.inv
	left outer join jenis on inv.jenis=jenis.jenis
	WHERE ind.jurnal=@jurnal
	GROUP BY ind.jurnal , ind.period, jenis.acc,  ind.date, ind.dk
) as xacd
End


If @subjurnal='OPN'  
Begin  
insert into acd select * from (  
/*  *** Selisih Persediaan ***/  
SELECT ind.jurnal, ind.period, isnull(jenis.accsls,space(15)) as acc, ind.date, round(sum(ind.val),2) as val,   
	(select top 1 cct from opn where opn=@jurnal) as cct, 'Posting Selisih HPP Opname' as remark, case when ind.dk='D' then 'K' else 'D' end as dk, @subjurnal as  subjurnal, 0 as adj
	FROM ind
	left outer join loc on ind.loc=loc.kode
	left outer join inv on ind.inv=inv.inv
	left outer join jenis on inv.jenis=jenis.jenis
	WHERE ind.jurnal=@jurnal
	GROUP BY ind.jurnal, ind.period, jenis.accsls, ind.date,ind.dk
union all  
/*  *** Persediaan ***/  
SELECT ind.jurnal, ind.period, isnull(jenis.acc,space(15)) as acc, ind.date, round(sum(ind.val),2) as val,   
	space(15) as cct, 'Posting Opname Persediaan' as remark, ind.dk, @subjurnal as  subjurnal, 0 as adj
	FROM ind
	left outer join loc on ind.loc=loc.kode
	left outer join inv on ind.inv=inv.inv
	left outer join jenis on inv.jenis=jenis.jenis
	WHERE ind.jurnal=@jurnal
	GROUP BY ind.jurnal, ind.period, jenis.acc, ind.date,ind.dk
) as xacd
End

If @subjurnal='JSU'  
Begin  
insert into acd select * from (  
/*  *** Hutang/Piutang ***/  
SELECT jsu.jsu as jurnal, jsu.period,jsu.acc, jsu.date, (jsu.val*jsu.kurs) as val,   
	space(15) as cct, jsu.remark, case when jsu.dk=1 then 'D' else 'K' end as dk, @subjurnal as  subjurnal, 0 as adj
	FROM jsu
	WHERE jsu.jsu=@jurnal
union all  
/*  *** Perk. Lawan ***/  
SELECT jsd.jsu as jurnal, jsu.period,jsd.acc as acc, jsu.date, (jsd.val*jsu.kurs) val,   
	jsd.cct as cct, jsd.remark,  jsd.dk as dk, @subjurnal as  subjurnal, 0 as adj
	FROM jsd left outer join jsu on jsd.jsu=jsu.jsu
	WHERE jsd.jsu=@jurnal and (jsd.cad=space(15) or jsd.cad is null)
union all
--jika ada cadangan
SELECT jsd.jsu as jurnal, jsu.period,jsd.acc as acc, jsu.date, 
        (select cadet.val from cadet where cadet.cad=jsd.cad and cadet.nocad<>'') as  val,   
	jsd.cct as cct, jsd.remark,  jsd.dk as dk, @subjurnal as  subjurnal, 0 as adj
	FROM jsd left outer join jsu on jsd.jsu=jsu.jsu
	WHERE  jsd.jsu=@jurnal and jsd.cad<>''
union all
SELECT jsd.jsu as jurnal, jsu.period,@slspebulatan as acc, jsu.date, abs((select cadet.val from cadet where cadet.cad=jsd.cad and cadet.nocad<>'')-(jsd.val*jsu.kurs)) val,   
	jsd.cct as cct, jsd.remark,  
	case when (select cadet.val from cadet where cadet.cad=jsd.cad and cadet.nocad<>'')-(jsd.val*jsu.kurs)<0 then 'D' else 'K' end  as dk,@subjurnal as  subjurnal, 0 as adj
	FROM jsd left outer join jsu on jsd.jsu=jsu.jsu 
	WHERE  jsd.jsu=@jurnal and jsd.cad<>'' and (select cadet.val from cadet where cadet.cad=jsd.cad and cadet.nocad<>'')-(jsd.val*jsu.kurs)<>0
) as xacd
End

If @subjurnal='UMH'  
Begin  
insert into acd select * from (  
SELECT umd.umh AS jurnal, umh.period, umd.acc, umh.date,     
           (umd.val*umh.kurs)as val, umd.cct, umd.remark, umd.dk, 'UMH' AS subjurnal, umh.adj 
           FROM umd left outer join umh on umd.umh=umh.umh  
           WHERE @jurnal=umh.umh
) as xacd  
End

If @subjurnal='CAD'  
Begin  
insert into acd select * from (  
SELECT cadet.cad AS jurnal, cad.period, cadet.acc, cad.date,     
           (cadet.val*cad.kurs)as val, cadet.cct, cadet.remark, cadet.dk, 'cad' AS subjurnal, cad.adj 
           FROM cadet left outer join cad on cadet.cad=cad.cad  
           WHERE @jurnal=cad.cad
) as xacd  
End

If @subjurnal='TTS'  
Begin  
insert into acd select * from (  
SELECT ttr.ttr AS jurnal, ttr.period, (select acc from sub where sub.sub=ttr.sub) as acc, ttr.date,     
           ttr.val, space(15) as cct, ttr.remark, case when 
		(select sum( ttd.val*case when ttd.dk='K' then -1 else 1 end) from ttd where ttd.ttr=@jurnal group by ttd.ttr)  < 0  
			then 'D' 
			else 'K' end as dk , 'TTS' AS subjurnal, 0 as adj
           FROM ttr
           WHERE @jurnal=ttr.ttr
union all
SELECT ttr.ttr AS jurnal, ttr.period, (select max(acc) from rhp where rhp.jurnal=ttd.jurnal and rhp.period=period)  as acc, ttr.date,     
           ttd.val, space(15) as cct, ttr.remark, ttd.dk , 'TTS' AS subjurnal, 0 as adj
           FROM ttd left outer join ttr on ttd.ttr=ttr.ttr
           WHERE @jurnal=ttd.ttr
) as xacd  
End

If @subjurnal='TTC'  
Begin  
insert into acd select * from (  
SELECT ttr.ttr AS jurnal, ttr.period, (select acc from sub where sub.sub=ttr.sub) as acc, ttr.date,     
           ttr.val, space(15) as cct, ttr.remark,case when 
		(select sum( ttd.val*case when ttd.dk='K' then 1 else -1 end) from ttd where ttd.ttr=@jurnal group by ttd.ttr)  < 0  
			then 'K' 
			else 'D' end as dk , 'TTC' AS subjurnal, 0 as adj
           FROM ttr
           WHERE @jurnal=ttr.ttr
union all
SELECT ttr.ttr AS jurnal, ttr.period,  (select max(acc) from rhp where rhp.jurnal=ttd.jurnal and rhp.period=period)  as acc, ttr.date,     
           ttd.val, space(15) as cct, ttr.remark, ttd.dk , 'TTC' AS subjurnal, 0 as adj
           FROM ttd left outer join ttr on ttd.ttr=ttr.ttr
           WHERE @jurnal=ttd.ttr
) as xacd  
End

If @subjurnal='KKK'  
Begin  
insert into acd select * from (  
SELECT kas.kas AS jurnal, kas.period, kas.acc, kas.date,     
           kas.val, space(15) as cct, kas.remark, 'K' as dk, 'KKK' AS subjurnal, 0 as adj
           FROM kas
           WHERE @jurnal=kas.kas
union all
SELECT kas.kas AS jurnal, kas.period, kad.acc, kas.date,     
           kad.val, kad.cct, kad.remark, kad.dk as dk, 'KKK' AS subjurnal, 0 as adj
           FROM kad left outer join kas on kad.kas=kas.kas
           WHERE @jurnal=kas.kas
) as xacd  
End

If @subjurnal='KKM'  
Begin  
insert into acd select * from (  
SELECT kas.kas AS jurnal, kas.period, kas.acc, kas.date,     
           kas.val, space(15) as cct, kas.remark, 'D' as dk, 'KKM' AS subjurnal, 0 as adj
           FROM kas
           WHERE @jurnal=kas.kas
union all
SELECT kas.kas AS jurnal, kas.period, kad.acc, kas.date,     
           kad.val, kad.cct, kad.remark, kad.dk as dk, 'KKM' AS subjurnal, 0 as adj
           FROM kad left outer join kas on kad.kas=kas.kas
           WHERE @jurnal=kas.kas
) as xacd  
End

If @subjurnal='KKG'  
Begin  
insert into acd select * from (  
SELECT kas.kas AS jurnal, kas.period, kas.acc, kas.date,     
           (isnull(kag.val,0)+kas.val) as val, space(15) as cct, kas.remark, 'K' as dk, 'KKG' AS subjurnal, 0 as adj
           FROM kas left outer join kag on kas.kas=kag.kas
           WHERE @jurnal=kas.kas
union all
SELECT kas.kas AS jurnal, kas.period, kad.acc, kas.date,     
           kad.val, kad.cct, kad.remark, 'D' as dk, 'KKG' AS subjurnal, 0 as adj
           FROM kad left outer join kas on kad.kas=kas.kas
           WHERE @jurnal=kas.kas
) as xacd  
End

If @subjurnal='KKL'  
Begin  
insert into acd select * from (  
SELECT kas.kas AS jurnal, kas.period, kas.acc, kas.date,     
           (kas.val*kas.kurs) as val, space(15) as cct, kas.remark, 'K' as dk, 'KKL' AS subjurnal, 0 as adj
           FROM kas
           WHERE @jurnal=kas.kas and kas.val>0
union all
SELECT kag.kas AS jurnal, kas.period, kag.acc, kas.date,     
           (kag.val*kas.kurs) as val, space(15) as cct, kas.remark, 'K' as dk, 'KKL' AS subjurnal, 0 as adj
           FROM kag left outer join kas on kag.kas=kas.kas
           WHERE @jurnal=kag.kas and kag.val<>0
union all
SELECT kas.kas AS jurnal, kas. period, kad.acc, kas.date,     
           (kad.val*isnull((select top 1 rhp.kurs from rhp where rhp.jurnal=kad.jurnal),kas.kurs)) as val, kad.cct, kad.remark, kad.dk, 'KKL' AS subjurnal, 0 as adj
           FROM kad left outer join kas on kad.kas=kas.kas             
           WHERE @jurnal=kas.kas AND Kad.val<>0
union all
--laba /rugi kurs
SELECT kas.kas AS jurnal, kas.period, (select top 1 acc from kad where kad.kas=@jurnal and kad.val=0), kas.date,     
           abs((kad.val*kas.kurs)-(kad.val*isnull((select top 1 rhp.kurs from rhp where rhp.jurnal=kad.jurnal),kas.kurs))), kad.cct, 
	   case when (kad.val*kas.kurs*case when dk='D' then 1 else -1 end)<(kad.val*case when dk='D' then 1 else -1 end*isnull((select top 1 rhp.kurs from rhp where rhp.jurnal=kad.jurnal),kas.kurs)) then 'LABA KURS' else 'RUGI KURS' end,
	   case when (kad.val*kas.kurs*case when dk='D' then 1 else -1 end)<(kad.val*case when dk='D' then 1 else -1 end*isnull((select top 1 rhp.kurs from rhp where rhp.jurnal=kad.jurnal),kas.kurs)) then 'K' else 'D' end, 'KKL' AS subjurnal, 0 as adj
           FROM kad left outer join kas on kad.kas=kas.kas 
	   WHERE @jurnal=kas.kas and kad.val<>0 and (kad.val*kas.kurs)<>(kad.val*isnull((select top 1 rhp.kurs from rhp where rhp.jurnal=kad.jurnal),kas.kurs))


) as xacd  
End

If @subjurnal='KMS'  
Begin  
insert into acd select * from (  
SELECT kas.kas AS jurnal, kas.period, kas.acc, kas.date,     
           (case when kas.valrp=0 then (kas.val*kas.kurs) else kas.valrp end) as val, space(15) as cct, kas.remark, 'D' as dk, 'KMS' AS subjurnal, 0 as adj
           FROM kas
           WHERE @jurnal=kas.kas and kas.val>0
union all
--jika ppn rupiah
SELECT kas.kas AS jurnal, kas.period, kad.acc, kas.date,     
           (kas.valrp) as val, kad.cct, kad.remark, kad.dk, 'KMS' AS subjurnal, 0 as adj
           FROM kad left outer join kas on kad.kas=kas.kas
	   WHERE @jurnal=kas.kas and kas.valrp<>0
union all
SELECT kas.kas AS jurnal, kas.period, kag.acc, kas.date,     
           (kag.val*kas.kurs) as val, space(15) as cct, kas.remark, 'D' as dk, 'KMS' AS subjurnal, 0 as adj
           FROM kag left outer join kas on kag.kas=kas.kas
           WHERE @jurnal=kag.kas and kag.val<>0 and kas.valrp=0union all
SELECT kas.kas AS jurnal, kas.period, kad.acc, kas.date,     
           (kad.val*isnull((select top 1 rhp.kurs from rhp where rhp.jurnal=kad.jurnal),kas.kurs)) as val, kad.cct, kad.remark, kad.dk, 'KMS' AS subjurnal, 0 as adj
           FROM kad left outer join kas on kad.kas=kas.kas
	   WHERE @jurnal=kas.kas and kad.val<>0 and kas.valrp=0
union all
---rugi/laba kurs
SELECT kas.kas AS jurnal, kas.period, (select top 1 acc from kad where kad.kas=@jurnal and kad.val=0), kas.date,     
           abs((kad.val*kas.kurs)-(kad.val*isnull((select top 1 rhp.kurs from rhp where rhp.jurnal=kad.jurnal),kas.kurs))), kad.cct, 
	   case when (kad.val*kas.kurs*case when dk='K' then 1 else -1 end)>(kad.val*case when dk='K' then 1 else -1 end*isnull((select top 1 rhp.kurs from rhp where rhp.jurnal=kad.jurnal),kas.kurs)) then 'LABA KURS' else 'RUGI KURS' end,
	   case when (kad.val*kas.kurs*case when dk='K' then 1 else -1 end)>(kad.val*case when dk='K' then 1 else -1 end*isnull((select top 1 rhp.kurs from rhp where rhp.jurnal=kad.jurnal),kas.kurs)) then 'K' else 'D' end, 'KMS' AS subjurnal, 0 as adj
             FROM kad left outer join kas on kad.kas=kas.kas
	   WHERE @jurnal=kas.kas and kad.val<>0 and (kad.val*kas.kurs)<>(kad.val*isnull((select top 1 rhp.kurs from rhp where rhp.jurnal=kad.jurnal),kas.kurs))
		and kas.valrp=0 and kas.valrp=0
) as xacd  
end

If @subjurnal='INO'  
Begin  
insert into acd select * from (  
SELECT ino.ino AS jurnal, substring(ino.ino,5,4) as period, ino.acc, ino.date,     
           ino.val, space(15) as cct, ino.proname, 'D' as dk, 'INO' AS subjurnal, 0 as adj
           FROM ino
           WHERE @jurnal=ino.ino
union all
SELECT ino.ino AS jurnal, substring(ino.ino,5,4) as period, inod.acc, ino.date,     
           inod.val, space(15) as cct, inod.rem, inod.dk, 'INO' AS subjurnal, 0 as adj
           FROM inod left outer join ino on inod.ino=ino.ino
           WHERE @jurnal=ino.ino
) as xacd  
end


If @subjurnal='STR'  
Begin  
insert into acd select * from (  
SELECT str.str AS jurnal, str.period, str.acc, str.date,     
           str.val, space(15) as cct, str.remark, 'D' as dk, 'STR' AS subjurnal, 0 as adj
           FROM str
           WHERE @jurnal=str.str
union all
SELECT str.str AS jurnal, str.period, std.acc, str.date,     
           std.val, space(15) as cct, str.remark, 'K' as dk, 'STR' AS subjurnal, 0 as adj
           FROM std left outer join str on std.str=str.str
           WHERE @jurnal=str.str
) as xacd  
End

If @subjurnal='TLK'  
Begin  
insert into acd select * from (  
SELECT tlk.tlk AS jurnal, tlk.period, tlk.accbank, tlk.date,     
           tlk.bgval, space(15) as cct, tlk.remark, case when dk=1 then 'K' else 'D' end  as dk, 'TLK' AS subjurnal, 0 as adj
           FROM tlk
           WHERE @jurnal=tlk.tlk
union all
SELECT tlk.tlk AS jurnal, tlk.period, tlk.acc, tlk.date,     
           tlk.bgval, space(15) as cct, tlk.remark, case when dk=1 then 'D' else 'K' end  as dk, 'TLK' AS subjurnal, 0 as adj
           FROM tlk
           WHERE @jurnal=tlk.tlk
) as xacd  
End

If @subjurnal='CGR'  
Begin  
insert into acd select * from (  
SELECT cgr.cgr AS jurnal, cgr.period,  
	   case when dk=1 then cgr.accbank else (select kas.acc from kag left outer join kas on kag.kas=kas.kas where kag.nobg=cgr.nobg)end as acc, cgr.date,     
 	   cgr.bgval as val,
	   space(15) as cct, cgr.remark, case when dk=1 then 'D' else 'K' end  as dk, 'CGR' AS subjurnal, 0 as adj
           FROM cgr
           WHERE @jurnal=cgr.cgr
union all
SELECT cgr.cgr AS jurnal, cgr.period, cgr.acc, cgr.date,     
           cgr.bgval  as val,
	   space(15) as cct, cgr.remark, case when dk=1 then 'K' else 'D' end  as dk, 'CGR' AS subjurnal, 0 as adj
           FROM cgr
           WHERE @jurnal=cgr.cgr
) as xacd  
End




GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO





































CREATE        PROCEDURE sp_saveacdlama @subjurnal char(15), @jurnal char(15)  AS

declare @v0koma1 float
declare @v1bagi11 float
declare @v1koma1 float
declare @v10bagi11 FLOAT

set @v0koma1=0.1000
set @v1bagi11=1.0000/11.0000
set @v1koma1=1.1000
set @v10bagi11=10.0000/11.0000

-- jurnal, period, acc, date, val, cct, remark, dk, subjurnal, 

if @subjurnal='LPB'  --LPB LOKAL
Begin
insert into acd select * from (
/*  *** Hutang Belum Difakturkan ***/  
SELECT lph.lph as jurnal, lph.period, isnull((select acc from accgl where remark='ACCPAY'),space(15)) as acc, lph.date, 
	sum((((lpd.price*case when inv.unit=lpd.unit then lpd.qty else lpd.qty/inv.besar end)*(100.00-lph.disc)/100.00)*(100.00-lpd.disc)/100.00)*lph.kurs*case when lph.ppn=2 then @V10Bagi11 else 1 end) as val,   
	space(15) as cct, lph.remark,'K' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM lpd
	left outer join lph on lpd.lph=lph.lph
	left outer join inv on lpd.inv=inv.inv
	WHERE lph.lph=@jurnal and (select top 1 isnull(aprov,0) from oms where oms.oms=lph.oms)<>1
	GROUP BY lph.lph, lph.period, lph.date, lph.remark
union all  
/*  *** Persediaan ***/  
SELECT ind.jurnal, ind.period, isnull(jenis.acc,space(15)) as acc, ind.date, sum(ind.val) as val,   
	space(15) as cct, 'Posting Persediaan' as remark, ind.dk, @subjurnal as  subjurnal, 0 as adj
	FROM ind
	left outer join inv on ind.inv=inv.inv
	left outer join jenis on inv.jenis=jenis.jenis
	WHERE ind.jurnal=@jurnal and jenis.acc<>space(15)
	GROUP BY ind.jurnal, ind.period, jenis.acc, ind.date,ind.dk
) as xacd  
End

if @subjurnal='POO'  ---LPB PO IMPORT
Begin
insert into acd select * from (
/*  *** Persediaan Brg Dalam Perjalanan ***/  
SELECT ind.jurnal, ind.period,isnull((select acc from accgl where remark='ACCMAT'),space(15)) as acc, ind.date, sum(ind.val) as val,   
	space(15) as cct, 'Posting Persediaan Dlm Perjalanan' as remark, 'K' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM ind
	left outer join inv on ind.inv=inv.inv
	WHERE ind.jurnal=@jurnal
	GROUP BY ind.jurnal, ind.period, ind.date,ind.dk
union all  
/*  *** Persediaan ***/  
SELECT ind.jurnal, ind.period, isnull(jenis.acc,space(15)) as acc, ind.date, sum(ind.val) as val,   
	space(15) as cct, 'Posting Persediaan' as remark, ind.dk, @subjurnal as  subjurnal, 0 as adj
	FROM ind
	left outer join inv on ind.inv=inv.inv
	left outer join jenis on inv.jenis=jenis.jenis
	WHERE ind.jurnal=@jurnal
	GROUP BY ind.jurnal, ind.period, jenis.acc, ind.date,ind.dk
) as xacd  
End


if @subjurnal='MSK'
Begin
insert into acd select * from (  
/*  *** Hutang Dagang Belum Difakturkan***/  
	SELECT msk.msk AS jurnal, msk.period, isnull((select acc from accgl where remark=
	case when msk.group_=1 then 'ACCPAY' else
		case when (select aprov from oms where oms.oms=msk.oms) =2 then 'ACCMAT' else
			case when (select aprov from oms where oms.oms=msk.oms) =3 then 'ACCFA ' else ' '
			end
		end
	end
	),space(15)) as acc, msk.date, 
	(msd.val-msd.ppn)*msk.kurs as val,   
	space(15) as cct, msd.remark, 'D' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM msd left outer join msk on msd.msk=msk.msk	
	WHERE msd.msk=@jurnal and (select top 1 isnull(aprov,0) from oms where oms.oms=msk.oms)<>1
union all
/*  *** Hutang Dagang ***/  
	SELECT msk.msk AS jurnal, msk.period,grp.acc, msk.date, 
	msd.val*msk.kurs as val,   
	space(15) as cct, msd.remark, 'K' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM msd
	 left outer join msk on msd.msk=msk.msk	
	left outer join sub on msk.sub=sub.sub
	left outer join grp on sub.grp=grp.grp
	WHERE msd.msk=@jurnal 
union all
/*  *** Biaya ***/  
	SELECT msk.msk AS jurnal, msk.period,msx.acc, msk.date, 
	msx.val*msk.kurs as val,   
	msk.cct as cct, msx.remark, 'D', @subjurnal as  subjurnal, 0 as adj
	FROM msx
	left outer join msk on msx.msk=msk.msk	
	WHERE msx.msk=@jurnal 
union all
/*  *** Hutang Belum Difakturkan ***/  
	SELECT msk.msk AS jurnal, msk.period,isnull((select acc from accgl where remark='ACCPAY'),space(15)) as acc, msk.date, 
	msx.val*msk.kurs as val,   
--	space(15) as cct, msx.remark, case when msx.dk='D' then 'K' else 'D' end  as dk, @subjurnal as  subjurnal, 0 as adj
	space(15) as cct, msx.remark, 'K' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM msx
	left outer join msk on msx.msk=msk.msk	
	WHERE msx.msk=@jurnal  and (select top 1 isnull(aprov,0) from oms where oms.oms=msk.oms)<>1
union all
/*  *** PPn ***/  
	SELECT msk.msk AS jurnal, msk.period,grp.accppn, msk.date, 
	msd.ppn*msk.kurs as val,   
	space(15) as cct, msd.remark, 'D' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM msd
	left outer join msk on msd.msk=msk.msk	
	left outer join sub on msk.sub=sub.sub
	left outer join grp on sub.grp=grp.grp
	WHERE msd.msk=@jurnal and msk.ppn>1
union all

/*  *** Uang Muka */
	SELECT msk.msk AS jurnal, msk.period, umkp.acc, msk.date, 
	isnull(sum((umkp.val)*msk.kurs),0)*(case when msk.ppn=2 then @v1koma1 else case when msk.ppn=3 then @v10bagi11 else 1 end end) as val, 
	space(15) as cct, msk.remark, 'K' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM umkp left outer join msk on umkp.msk=msk.msk
	--left outer join sub on msk.sub=sub.sub
	--left outer join grp on sub.grp=grp.grp
	WHERE umkp.msk=@jurnal and msk.ppn >= 1              
	GROUP BY msk.msk, msk.period, umkp.acc,msk.ppn, msk.date, msk.remark
union all  
 SELECT msk.msk AS jurnal, msk.period, isnull((select acc from accgl where remark=
	case when msk.group_=1 then 'ACCPAY' else
		case when (select aprov from oms where oms.oms=msk.oms) =2 then 'ACCMAT' else
			case when (select aprov from oms where oms.oms=msk.oms) =3 then 'ACCFA ' else ' '
			end
		end
	end
	),space(15)) as acc, msk.date, 
	((umkp.val)*msk.kurs)*(case when msk.ppn=2 then @v1koma1 else case when msk.ppn=3 then @v10bagi11 else 1 end end) as val,   
	space(15) as cct, umkp.remark, 'D' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM umkp left outer join msk on umkp.msk=msk.msk	
	WHERE umkp.msk=@jurnal 
) as xacd  
End 

if @subjurnal='MSI'  --Pembelian Import 
Begin
insert into acd select * from (  
/*  *** Hutang Dagang ***/  
	SELECT msk.msk AS jurnal, msk.period,grp.acc, msk.date, 
	msd.val*msk.kurs as val,   
	space(15) as cct, msd.remark, 'K' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM msd
	 left outer join msk on msd.msk=msk.msk	
	left outer join sub on msk.sub=sub.sub
	left outer join grp on sub.grp=grp.grp
	WHERE msd.msk=@jurnal 
union all
SELECT msk.msk AS jurnal, msk.period,isnull((select acc from accgl where remark='ACCMAT'),space(15)) as acc, msk.date, 
	msd.val*msk.kurs as val,   
	space(15) as cct, msd.remark, 'D' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM msd
	 left outer join msk on msd.msk=msk.msk	
	left outer join sub on msk.sub=sub.sub
	WHERE msd.msk=@jurnal 
union all
/*  *** Uang Muka */
	SELECT msk.msk AS jurnal, msk.period, umkp.acc, msk.date, 
	isnull(sum((umkp.val)*msk.kurs),0)*(case when msk.ppn=2 then @v1koma1 else case when msk.ppn=3 then @v10bagi11 else 1 end end) as val, 
	space(15) as cct, msk.remark, 'K' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM umkp left outer join msk on umkp.msk=msk.msk
	--left outer join sub on msk.sub=sub.sub
	--left outer join grp on sub.grp=grp.grp
	WHERE umkp.msk=@jurnal and msk.ppn >= 1              
	GROUP BY msk.msk, msk.period,msk.ppn, umkp.acc, msk.date, msk.remark
--union all  
 /*  *** PPn Uang Muka */
	/*SELECT msk.msk AS jurnal, msk.period, grp.accppn, msk.date, 
	isnull(sum((umkp.val)*case when msk.ppn=2 then @v1bagi11 else case when msk.ppn=3 then @v0koma1 else 0 end end*msk.kurs),0) as val,   
	space(15) as cct, msk.remark, 'K' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM umkp left outer join msk on umkp.msk=msk.msk
	left outer join sub on msk.sub=sub.sub
	left outer join grp on sub.grp=grp.grp
	WHERE umkp.msk=@jurnal and msk.ppn > 1          
	GROUP BY msk.msk, msk.period, grp.accppn, msk.date, msk.remark*/
) as xacd  
End 

if @subjurnal='RMA'
Begin
insert into acd select * from (  
/*  *** Hutang Belum Difakturkan ***/  
SELECT rma.rma as jurnal, rma.period, isnull((select acc from accgl where remark='ACCPAY'),space(15)) as acc, rma.date, 
	(select sum(ind.val) from ind where ind.jurnal=@jurnal) as val,   
	space(15) as cct, rma.remark,'D' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM rma
	WHERE rma.rma=@jurnal	
union all  
/*  *** Persediaan ***/  
SELECT ind.jurnal, ind.period, isnull(jenis.acc,space(15)) as acc, ind.date, sum(ind.val) as val,   
	space(15) as cct, 'Posting Persediaan' as remark, ind.dk, @subjurnal as  subjurnal, 0 as adj
	FROM ind
	left outer join inv on ind.inv=inv.inv
	left outer join jenis on inv.jenis=jenis.jenis
	WHERE ind.jurnal=@jurnal
	GROUP BY ind.jurnal, ind.period, jenis.acc, ind.date,ind.dk
) as xacd  
End  

if @subjurnal='RMS'
Begin
insert into acd select * from (  
/*  *** Hutang Dagang ***/  
	SELECT rms.rms AS jurnal, rms.period, grp.acc, rms.date, rms.val*rms.kurs as val,   
	space(15) as cct, rms.remark, 'D' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM rms 
	left outer join sub on rms.sub=sub.sub
	left outer join grp on sub.grp=grp.grp
	WHERE rms.rms=@jurnal           
union all  
/*  *** PPn ***/  
	SELECT rms.rms AS jurnal, rms.period, grp.accppn, rms.date, 
	isnull(sum((((rmd.price*case when rmd.unit=inv.unit then rmd.qty else rmd.qty/inv.besar end)*(100.00-rms.disc)/100.00)*(100.00-rmd.disc)/100.00)*case when rms.ppn=2 then @v1bagi11 else case when rms.ppn=3 then @v0koma1 else 0 end end),0)*rms.kurs as val,   
	space(15) as cct, rms.remark, 'K' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM rmd left outer join rms on rmd.rms=rms.rms
	left outer join sub on rms.sub=sub.sub
	left outer join grp on sub.grp=grp.grp
	left outer join inv on rmd.inv=inv.inv
	WHERE rmd.rms=@jurnal and rms.ppn > 1          
	GROUP BY rms.rms, rms.period, grp.accppn, rms.date, rms.remark,rms.kurs
union all  
/*  *** Hutang Belum Difakturkan ***/  
SELECT rms.rms as jurnal, rms.period, isnull((select acc from accgl where remark='ACCPAY'),space(15)) as acc, rms.date, 
	sum((((rmd.price*case when rmd.unit=inv.unit then rmd.qty else rmd.qty/inv.besar end)*(100.00-rms.disc)/100.00)*(100.00-rmd.disc)/100.00)*rms.kurs*case when rms.ppn=2 then @V10Bagi11 else 1 end) as val,   
	space(15) as cct, rms.remark,'K' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM rmd
	left outer join rms on rmd.rms=rms.rms
	left outer join inv on rmd.inv=inv.inv
	WHERE rms.rms=@jurnal
	GROUP BY rms.rms, rms.period, rms.date, rms.remark
union all
/*  *** Selisih Pengembalian Barang dengan Retur Pembelian ***/  
	SELECT jurnal,period, acc,date,sum(abs(rmdval-indval)) as val,space(15) as cct, 'Posting Selisih Persediaan' as remark, 
	case when (rmdval-indval)>=0 then 'K' else 'D' end  as dk,
	@subjurnal as  subjurnal, 0 as adj
	FROM 
	(
		SELECT rmd.rms as jurnal,rms.period,rms.date, 
		rmd.qty,(((rmd.price*case when rmd.unit=inv.unit then rmd.qty else rmd.qty/inv.besar end)*(100.00-rms.disc)/100.00)*(100.00-rmd.disc)/100.00)*case when rms.ppn=2 then @V10Bagi11 else 1 end*rms.kurs as rmdval,
		ind.val as indval,  space(15) as cct, 'Posting Selisih Persediaan' as remark, jenis.accsls as acc
		FROM 
		rmd left outer join rms on rmd.rms=rms.rms
		left outer join ind on rms.rma=ind.jurnal
		left outer join inv on rmd.inv=inv.inv
		left outer join jenis on inv.jenis=jenis.jenis
		where rmd.rms=@jurnal and isnull(inv.acc,space(15))=' '
	) as xind 
	GROUP BY jurnal,period,acc,date, rmdval, indval
union all
/*  *** Hutang Belum Difakturkan ***/  
	SELECT jurnal,period,acc,date,sum(abs(rmdval-indval)) as val,space(15) as cct, 'Posting Selisih Persediaan' as remark, 
	case when (rmdval-indval)>=0 then 'D' else 'K' end  as dk,
	@subjurnal as  subjurnal, 0 as adj
	FROM 
	(
		SELECT rmd.rms as jurnal,rms.period,rms.date, 
		rmd.qty,(((rmd.price*case when rmd.unit=inv.unit then rmd.qty else rmd.qty/inv.besar end)*(100.00-rms.disc)/100.00)*(100.00-rmd.disc)/100.00)*case when rms.ppn=2 then @V10Bagi11 else 1 end*rms.kurs as rmdval,
		ind.val as indval,  space(15) as cct, 'Posting Selisih Persediaan' as remark, isnull((select acc from accgl where remark='ACCPAY'),space(15)) as acc
		FROM 
		rmd left outer join rms on rmd.rms=rms.rms
		left outer join ind on rms.rma=ind.jurnal
		left outer join inv on rmd.inv=inv.inv
		where rmd.rms=@jurnal
	) as xind 
	GROUP BY jurnal,period,acc,date, rmdval, indval
) as xacd  
End  

if @subjurnal='SJH'
Begin
insert into acd select * from (  
/*  *** Harga Pokok Penjualan Belum Difakturkan ***/  
SELECT ind.jurnal, ind.period, isnull((select max(acc) from accgl where remark='ACCHPPT'),space(15)) as acc, ind.date, sum(ind.val) as val,   
	space(15) as cct, 'Posting HPP Belum Difakturkan' as remark, 'D' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM ind
	left outer join inv on ind.inv=inv.inv
	WHERE ind.jurnal=@jurnal
	GROUP BY ind.jurnal, ind.period,  ind.date,ind.dk
union all  
/*  *** Persediaan ***/  
SELECT ind.jurnal, ind.period, isnull(jenis.acc,space(15)) as acc, ind.date, sum(ind.val) as val,   
	space(15) as cct, 'Posting Persediaan' as remark, 'K' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM ind
	left outer join inv on ind.inv=inv.inv
	left outer join jenis on inv.jenis=jenis.jenis
	WHERE ind.jurnal=@jurnal
	GROUP BY ind.jurnal, ind.period, jenis.acc, ind.date,ind.dk
union all
/* POSTING ONGKOS ANGKUT */
SELECT sjh.sjh, sjh.period, sub.acc as acc, sjh.date, sum(sjd.qty)*(select valkg from okl where okl=sjh.nopo) as val,  
	space(15) as cct, sub.name as remark, 'D' as dk, 'SJH' as  subjurnal, 0 as adj
	FROM sjd
	left outer join sjh on sjd.sjh=sjh.sjh
	left outer join sub on sjh.angkutan=sub.sub
	WHERE sjd.sjh=@jurnal and sub.acc<>''
	GROUP BY sjh.sjh, sjh.period,sub.acc,sub.name,sjh.date,sjh.nopo
union all  
/* POSTING LAWAN ONGKOS ANGKUT */
SELECT sjh.sjh, sjh.period, sub.accrev as acc, sjh.date, sum(sjd.qty)*(select valkg from okl where okl=sjh.nopo) as val,  
	space(15) as cct, sub.name as remark, 'K' as dk, 'SJH' as  subjurnal, 0 as adj
	FROM sjd
	left outer join sjh on sjd.sjh=sjh.sjh
	left outer join sub on sjh.angkutan=sub.sub
	WHERE sjd.sjh=@jurnal and sub.acc<>''
	GROUP BY sjh.sjh, sjh.period,sub.name,sub.accrev,sjh.date,sjh.nopo
) as xacd  
End  
if @subjurnal='KLR'
Begin
insert into acd select * from (  
/*  *** Piutang Dagang ***/  
	SELECT klr.klr AS jurnal, klr.period, grp.acc, klr.date, (klr.val*klr.kurs) as val,   
	space(15) as cct, klr.remark, 'D' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM klr 
	left outer join sub on klr.sub=sub.sub
	left outer join grp on sub.grp=grp.grp
	WHERE klr.klr=@jurnal    
union all 
/* ***pelunasan dgn uang muka****/
	SELECT klr.klr AS jurnal, klr.period, grp.acc, klr.date,isnull(umk.val*klr.kurs,0) as val,   
	space(15) as cct, klr.remark, 'K' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM klr 
	left outer join sub on klr.sub=sub.sub
	left outer join umk on klr.klr=umk.klr
	left outer join grp on sub.grp=grp.grp
	WHERE klr.klr=@jurnal and umk.jurnal<>space(15)   

      
union all  
/*  *** Penjualan ***/  
	SELECT klr.klr AS jurnal, klr.period, inv.accrev, klr.date, 
	sum((kld.price*case when kld.unit=inv.unit then kld.qty else kld.qty/inv.besar end)*case when klr.ppn=2 then @v10bagi11 else 1 end*klr.kurs) as valrp,   
	space(15) as cct, klr.remark, 'K' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM kld left outer join klr on kld.klr=klr.klr
	left outer join inv on kld.inv=inv.inv
	WHERE kld.klr=@jurnal
	GROUP BY klr.klr, klr.period, inv.accrev, klr.date, klr.remark
union all  
/*  *** PPn ***/  
select jurnal,period,accppn,date,isnull(val,0)-(select discrp*0.1 from klr where klr.klr=@jurnal),cct,remark,dk,subjurnal,adj from 
(
	SELECT klr.klr AS jurnal, klr.period, grp.accppn, klr.date, 
	isnull(sum((((kld.price*case when kld.unit=inv.unit then kld.qty else kld.qty/inv.besar end)*(100.00-klr.disc)/100.00)*(100.00-kld.disc)/100.00)*case when klr.ppn=2 then @v1bagi11 else case when klr.ppn=3 then @v0koma1 else 0 end end*klr.kurs),0) as val,   
	space(15) as cct,(rtrim(max(sub.name))+' '+ klr.remark)as remark, 'K' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM kld left outer join klr on kld.klr=klr.klr
	left outer join sub on klr.sub=sub.sub
	left outer join grp on sub.grp=grp.grp
	left outer join inv on kld.inv=inv.inv	WHERE kld.klr=@jurnal and klr.ppn > 1          
	GROUP BY klr.klr, klr.period, grp.accppn, klr.date, klr.remark
) as ppnklr
union all  
/*  *** Uang Muka */
SELECT klr.klr AS jurnal, klr.period, umk.acc, klr.date, 
	(select isnull(sum(xx.kurs),0) from 
	(select umk.val*(select top 1 kurs from rhp where jurnal =umk.jurnal) as kurs from umk 
	where umk.klr=@jurnal) as xx) as val , 
	space(15) as cct, klr.remark, 'D' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM umk left outer join klr on umk.klr=klr.klr
	WHERE umk.klr=@jurnal and klr.ppn > 1  and umk.jurnal<>space(15)            
	GROUP BY klr.klr, klr.period, umk.acc, klr.date, klr.remark
union all
--sls kurs
SELECT klr.klr AS jurnal, klr.period,(select top 1 acc from umk where umk.jurnal=space(15) and umk.klr=@jurnal) as acc, klr.date, 
	abs(sum(umk.val*klr.kurs)-(select isnull(sum(xx.kurs),0) from 
	(select umk.val*(select top 1 kurs from rhp where jurnal =umk.jurnal) as kurs from umk 
	where umk.klr=@jurnal) as xx)) as val , 
	space(15) as cct, klr.remark, 
        case when sum(umk.val*klr.kurs)>(select isnull(sum(xx.kurs),0) val from 
		(select umk.val*(select top 1 kurs from rhp where jurnal =umk.jurnal) as kurs from umk 
		where umk.klr=@jurnal) as xx) 
         then 'D' else 'K' end as dk,
	@subjurnal as  subjurnal, 0 as adj
	FROM umk left outer join klr on umk.klr=klr.klr
	WHERE umk.klr=@jurnal and klr.ppn > 1  and umk.jurnal<>space(15)  
	GROUP BY klr.klr, klr.period, umk.acc, klr.date, klr.remark
union all  
 /*  *** PPn Uang Muka */
	SELECT klr.klr AS jurnal, klr.period, grp.accppn, klr.date, 
	isnull(sum((umk.val)*case when klr.ppn=2 then @v1bagi11 else case when klr.ppn=3 then @v0koma1 else 0 end end*klr.kurs),0) as val,   
	space(15) as cct,rtrim(max(sub.name))+' '+klr.remark, 'D' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM umk left outer join klr on umk.klr=klr.klr
	left outer join sub on klr.sub=sub.sub
	left outer join grp on sub.grp=grp.grp
	WHERE umk.klr=@jurnal and klr.ppn > 1  and umk.jurnal<>space(15)           
	GROUP BY klr.klr, klr.period, grp.accppn, klr.date, klr.remark
union all  
/*  *** Discount ***/  
select jurnal,period,accdisc,date,isnull(valrp,0)+(select discrp from klr where klr.klr=@jurnal),cct,remark,dk,subjurnal,adj from (
	SELECT klr.klr AS jurnal, klr.period, inv.accdisc, klr.date, 
	sum((((kld.price*case when kld.unit=inv.unit then kld.qty else kld.qty/inv.besar end)*klr.disc/100.00)+
	((kld.price*case when kld.unit=inv.unit then kld.qty else kld.qty/inv.besar end)-
	((kld.price*case when kld.unit=inv.unit then kld.qty else kld.qty/inv.besar end)*klr.disc/100.00))*kld.disc/100.00)*klr.kurs) as valrp,   
	space(15) as cct, klr.remark, 'D' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM kld left outer join klr on kld.klr=klr.klr
	left outer join inv on kld.inv=inv.inv
	WHERE kld.klr=@jurnal and (klr.disc > 0 or kld.disc > 0 or klr.discrp>0 )
	GROUP BY klr.klr, klr.period, inv.accdisc, klr.date, klr.remark
) as disc
union all  
/*  *** Harga Pokok Penjualan ***/  
SELECT kld.klr, ind.period, isnull(inv.acchpp,space(15)) as acc, ind.date, sum((ind.val/ind.qty)*kld.qty) as val,   
	space(15) as cct, 'Posting HPP' as remark, 'D' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM kld 
             left outer join klr on kld.klr=klr.klr
	left outer join ind on kld.sjh+kld.inv=ind.jurnal+ind.inv
	left outer join inv on ind.inv=inv.inv
	WHERE klr.klr=@jurnal
	GROUP BY kld.klr, ind.period, inv.acchpp, ind.date,ind.dk
union all  
/*  *** Harga Pokok Penjualan Belum Difakturkan *** */
SELECT klr.klr, ind.period, isnull((select max(acc) from accgl where remark='ACCHPPT'),space(15)) as acc, ind.date, sum(ind.val) as val,   
	space(15) as cct, 'Posting HPP Belum Difakturkan' as remark, 'K' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM kld 
        left outer join klr on kld.klr=klr.klr
	left outer join ind on kld.sjh=ind.jurnal
	left outer join inv on ind.inv=inv.inv
	WHERE klr.klr=@jurnal
	GROUP BY klr.klr, ind.period, ind.date,ind.dk
union all
/* *** Harga Pokok Penjualan varian  Belum Difakturkan *** */
SELECT klr,period,acc,date,abs(val-valklr) as val,cct,remark, (case when val<valklr then 'K' else 'D' end) as dk,@subjurnal as subjurnal,0 as adj from
              (select kld.klr, ind.period, isnull((select max(acc) from accgl where remark='ACCHPPV'),space(15)) as acc, ind.date, 
             sum(ind.val) as val,   sum((ind.val/ind.qty)*kld.qty) as valklr, 
	space(15) as cct, 'Posting HPP Varian Belum Difakturkan' as remark, @subjurnal as  subjurnal, 0 as adj
	FROM kld 
	left outer join klr on kld.klr=klr.klr
	left outer join ind on kld.sjh+kld.inv=ind.jurnal+ind.inv
	left outer join inv on ind.inv=inv.inv
	WHERE klr.klr=@jurnal
	GROUP BY kld.klr, ind.period, ind.date,ind.dk
	) as HPPV
) as xacd  
End  

if @subjurnal='RKA'
Begin
insert into acd select * from (  
/*  *** Harga Pokok Penjualan Belum Difakturkan ***/  
SELECT ind.jurnal, ind.period, isnull((select max(acc) from accgl where remark='ACCHPPT'),space(15)) as acc, ind.date, sum(ind.val) as val,   
	space(15) as cct, 'Posting HPP Belum Difakturkan' as remark, 'K' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM ind
	left outer join inv on ind.inv=inv.inv
	WHERE ind.jurnal=@jurnal
	GROUP BY ind.jurnal, ind.period,  ind.date,ind.dk
union all  
/*  *** Persediaan ***/  
SELECT ind.jurnal, ind.period, isnull(jenis.acc,space(15)) as acc, ind.date, sum(ind.val) as val,   
	space(15) as cct, 'Posting Persediaan' as remark, 'D' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM ind
	left outer join inv on ind.inv=inv.inv
	left outer join jenis on inv.jenis=jenis.jenis
	WHERE ind.jurnal=@jurnal
	GROUP BY ind.jurnal, ind.period, jenis.acc, ind.date,ind.dk
) as xacd  
End  

if @subjurnal='RKL'
Begin
insert into acd select * from (  
/*  *** Piutang Dagang ***/  
	SELECT rkl.rkl AS jurnal, rkl.period, grp.acc, rkl.date, rkl.val*rkl.kurs as val,   
	space(15) as cct, rkl.remark, 'K' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM rkl 
	left outer join sub on rkl.sub=sub.sub
	left outer join grp on sub.grp=grp.grp
	WHERE rkl.rkl=@jurnal           
union all  
/*  *** Retur Penjualan ***/  
	SELECT rkl.rkl AS jurnal, rkl.period, inv.accreturn, rkl.date, 
	sum((rkd.price*case when rkd.unit=inv.unit then rkd.qty else rkd.qty/inv.besar end)*case when rkl.ppn=2 then @v10bagi11 else 1 end*rkl.kurs) as valrp,   
	space(15) as cct, rkl.remark, 'D' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM rkd left outer join rkl on rkd.rkl=rkl.rkl
	left outer join inv on rkd.inv=inv.inv
	WHERE rkd.rkl=@jurnal      
	GROUP BY rkl.rkl, rkl.period, inv.accreturn, rkl.date, rkl.remark
union all  
/*  *** PPn ***/  
	SELECT rkl.rkl AS jurnal, rkl.period, grp.accppn, rkl.date, 
	isnull(sum((((rkd.price*case when rkd.unit=inv.unit then rkd.qty else rkd.qty/inv.besar end)*(100.00-rkl.disc)/100.00)*(100.00-rkd.disc)/100.00)*case when rkl.ppn=2 then @v1bagi11 else case when rkl.ppn=3 then @v0koma1 else 0 end end*rkl.kurs),0) as val,   
	space(15) as cct, rkl.remark, 'D' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM rkd left outer join rkl on rkd.rkl=rkl.rkl
	left outer join sub on rkl.sub=sub.sub
	left outer join grp on sub.grp=grp.grp
	left outer join inv on rkd.inv=inv.inv
	WHERE rkd.rkl=@jurnal and rkl.ppn > 1          
	GROUP BY rkl.rkl, rkl.period, grp.accppn, rkl.date, rkl.remark
union all  
/*  *** Discount ***/  
	SELECT rkl.rkl AS jurnal, rkl.period, grp.accdisc, rkl.date, 
	sum((((rkd.price*case when rkd.unit=inv.unit then rkd.qty else rkd.qty/inv.besar end)*rkl.disc/100.00)+
	((rkd.price*case when rkd.unit=inv.unit then rkd.qty else rkd.qty/inv.besar end)-
	((rkd.price*case when rkd.unit=inv.unit then rkd.qty else rkd.qty/inv.besar end)*rkl.disc/100.00))*rkd.disc/100.00)*rkl.kurs) as valrp,   
	space(15) as cct, rkl.remark, 'K' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM rkd left outer join rkl on rkd.rkl=rkl.rkl
	left outer join sub on rkl.sub=sub.sub
	left outer join grp on sub.grp=grp.grp
	left outer join inv on rkd.inv=inv.inv
	WHERE rkd.rkl=@jurnal and (rkl.disc > 0 or rkd.disc > 0 )
	GROUP BY rkl.rkl, rkl.period, grp.accdisc, rkl.date, rkl.remark
union all  
/*  *** Harga Pokok Penjualan ***/  
SELECT rkl.rkl, ind.period, isnull((select max(acc) from accgl where remark='ACCHPPT'),space(15)) as acc, ind.date, sum(ind.val) as val,   
	space(15) as cct, 'Posting HPP Belum Difakturkan' as remark, 'D' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM rkl
	left outer join ind on rkl.rka=ind.jurnal
	left outer join inv on ind.inv=inv.inv
	WHERE rkl.rkl=@jurnal
	GROUP BY rkl.rkl, ind.period, ind.date,ind.dk
union all  
/*  *** Persediaan ***/  
SELECT rkl.rkl, ind.period, isnull(inv.acchpp,space(15)) as acc, ind.date, sum(ind.val) as val,   
	space(15) as cct, 'Posting  HPP' as remark, 'K' as dk, @subjurnal as  subjurnal, 0 as adj
	FROM rkl
	left outer join ind on rkl.rka=ind.jurnal
	left outer join inv on ind.inv=inv.inv
	WHERE rkl.rkl=@jurnal
	GROUP BY rkl.rkl, ind.period, inv.acchpp, ind.date,ind.dk
) as xacd  
End  

If @subjurnal='JIN'  
Begin  
insert into acd select * from (  
/*  *** Perkiraan Biaya ***/  
SELECT jurnal, period, acc , date, abs(val) as val,
	space(15) as cct, 'Posting Jurnal Persediaan Header' as remark, case when val<=0 then 'D' else 'K' end as dk, @subjurnal as  subjurnal, 0 as adj
	FROM
	(	
	/*SELECT ind.jurnal , ind.period, isnull(jenis.accmt,space(15)) as acc, ind.date, sum(ind.val)  as val,
	space(15) as cct, 'Posting Jurnal Persediaan Detail' as remark, ind.dk, @subjurnal as  subjurnal, 0 as adj
	FROM ind
	left outer join loc on ind.loc=loc.kode
        left outer join inv on ind.inv=inv.inv
	left outer join jenis on inv.jenis=jenis.jenis
	WHERE ind.jurnal=@jurnal
	GROUP BY ind.jurnal , ind.period, jenis.accmt,  ind.date, ind.dk*/
	SELECT jid.jin as jurnal, jin.period,(case when jin.group_=2 then jin.acc else jenis.accmt end) as acc, jin.date, sum(ind.val*case when ind.dk='D' then 1 else -1 end) as val
		FROM jid
		left outer join jin on jid.jin=jin.jin
		left outer join inv on jid.inv=inv.inv
		left outer join jenis on inv.jenis=jenis.jenis
        	left outer join 
		(select distinct jurnal,period,inv,loc,date,qty,round(val,5) as val,rem,dk,subjurnal from ind where ind.jurnal=@jurnal) as ind on jid.jin+jid.inv+jid.loc=ind.jurnal+ind.inv+ind.loc and jid.qty=ind.qty
                WHERE jid.jin=@jurnal and jin.group_<>4
		GROUP BY jid.jin, jin.period,(case when jin.group_=2 then jin.acc else jenis.accmt end), jin.date	
) as xind
union all
/*  *** Persediaan ***/  
SELECT ind.jurnal , ind.period, isnull(jenis.acc,space(15)) as acc, ind.date, sum(round(ind.val,5))  as val,
	space(15) as cct, 'Posting Jurnal Persediaan Detail' as remark, ind.dk, @subjurnal as  subjurnal, 0 as adj
	FROM ind
	left outer join loc on ind.loc=loc.kode
        left outer join inv on ind.inv=inv.inv
	left outer join jenis on inv.jenis=jenis.jenis
	WHERE ind.jurnal=@jurnal and left(jurnal,1)<>'.'
	GROUP BY ind.jurnal , ind.period, jenis.acc,  ind.date, ind.dk
union all
--biaya penyusutan aktiva tetap
SELECT jid.jin as jurnal, jin.period,inv.accsls as acc, jin.date,jid.val*prosent/100 as val,
    	mfd.cct as cct, 'B.Penyusutan Akt Tetap '+rtrim(inv.inv) as remark,jid.dk,@subjurnal,0 as adj
	from jid left outer join jin on jid.jin=jin.jin left outer join inv on jid.inv=inv.inv
	left outer join mfd on inv.inv=mfd.inv where jin.group_=4 and jin.jin=@jurnal

--akumulasi penyusutan akt tetap
union all
SELECT jid.jin as jurnal, jin.period,loc.accakm as acc, jin.date,jid.val,
	' ' as cct, 'Akm Peny. Akt Tetap '+rtrim(inv.inv) as remark,case when jid.dk='D' then 'K' else 'D' end,@subjurnal,0 as adj
	from jid left outer join jin on jid.jin=jin.jin left outer join inv on jid.inv=inv.inv
	left outer join loc on inv.acc=loc.acc
	where jin.group_=4 and jin.jin=@jurnal and loc.kode=''
) as xacd
End

If @subjurnal='TRM'  
Begin  
insert into acd select * from (  
/*  *** Persediaan ***/  

SELECT ind.jurnal , ind.period, isnull(jenis.acc,space(15)) as acc, ind.date, sum(ind.val)  as val,
	space(15) as cct, 'Posting Jurnal Transfer Persediaan' as remark, ind.dk, @subjurnal as  subjurnal, 0 as adj
	FROM ind
	left outer join loc on ind.loc=loc.kode
	left outer join inv on ind.inv=inv.inv
	left outer join jenis on inv.jenis=jenis.jenis
	WHERE ind.jurnal=@jurnal
	GROUP BY ind.jurnal , ind.period, jenis.acc,  ind.date, ind.dk
) as xacd
End


If @subjurnal='OPN'  
Begin  
insert into acd select * from (  
/*  *** Selisih Persediaan ***/  
SELECT ind.jurnal, ind.period, isnull(jenis.accsls,space(15)) as acc, ind.date, sum(ind.val) as val,   
	space(15) as cct, 'Posting Selisih HPP Opname' as remark, case when ind.dk='D' then 'K' else 'D' end as dk, @subjurnal as  subjurnal, 0 as adj
	FROM ind
	left outer join loc on ind.loc=loc.kode
	left outer join inv on ind.inv=inv.inv
	left outer join jenis on inv.jenis=jenis.jenis
	WHERE ind.jurnal=@jurnal
	GROUP BY ind.jurnal, ind.period, jenis.accsls, ind.date,ind.dk
union all  
/*  *** Persediaan ***/  
SELECT ind.jurnal, ind.period, isnull(jenis.acc,space(15)) as acc, ind.date, sum(ind.val) as val,   
	space(15) as cct, 'Posting Opname Persediaan' as remark, ind.dk, @subjurnal as  subjurnal, 0 as adj
	FROM ind
	left outer join loc on ind.loc=loc.kode
	left outer join inv on ind.inv=inv.inv
	left outer join jenis on inv.jenis=jenis.jenis
	WHERE ind.jurnal=@jurnal
	GROUP BY ind.jurnal, ind.period, jenis.acc, ind.date,ind.dk
) as xacd
End

If @subjurnal='JSU'  
Begin  
insert into acd select * from (  
/*  *** Hutang/Piutang ***/  
SELECT jsu.jsu as jurnal, jsu.period,jsu.acc, jsu.date, (jsu.val*jsu.kurs) as val,   
	space(15) as cct, jsu.remark, case when jsu.dk=1 then 'D' else 'K' end as dk, @subjurnal as  subjurnal, 0 as adj
	FROM jsu
	WHERE jsu.jsu=@jurnal
union all  
/*  *** Perk. Lawan ***/  
SELECT jsd.jsu as jurnal, jsu.period,jsd.acc as acc, jsu.date, (jsd.val*jsu.kurs) val,   
	jsd.cct as cct, jsd.remark,  jsd.dk as dk, @subjurnal as  subjurnal, 0 as adj
	FROM jsd left outer join jsu on jsd.jsu=jsu.jsu
	WHERE jsd.jsu=@jurnal

) as xacd
End

If @subjurnal='UMH'  
Begin  
insert into acd select * from (  
SELECT umd.umh AS jurnal, umh.period, umd.acc, umh.date,     
           (umd.val*umh.kurs)as val, umd.cct, umd.remark, umd.dk, 'UMH' AS subjurnal, umh.adj 
           FROM umd left outer join umh on umd.umh=umh.umh  
           WHERE @jurnal=umh.umh
) as xacd  
End

If @subjurnal='TTS'  
Begin  
insert into acd select * from (  
SELECT ttr.ttr AS jurnal, ttr.period, (select acc from sub where sub.sub=ttr.sub) as acc, ttr.date,     
           ttr.val, space(15) as cct, ttr.remark, case when 
		(select sum( ttd.val*case when ttd.dk='K' then -1 else 1 end) from ttd where ttd.ttr=@jurnal group by ttd.ttr)  < 0  
			then 'D' 
			else 'K' end as dk , 'TTS' AS subjurnal, 0 as adj
           FROM ttr
           WHERE @jurnal=ttr.ttr
union all
SELECT ttr.ttr AS jurnal, ttr.period, (select max(acc) from rhp where rhp.jurnal=ttd.jurnal and rhp.period=period)  as acc, ttr.date,     
           ttd.val, space(15) as cct, ttr.remark, ttd.dk , 'TTS' AS subjurnal, 0 as adj
           FROM ttd left outer join ttr on ttd.ttr=ttr.ttr
           WHERE @jurnal=ttd.ttr
) as xacd  
End

If @subjurnal='TTC'  
Begin  
insert into acd select * from (  
SELECT ttr.ttr AS jurnal, ttr.period, (select acc from sub where sub.sub=ttr.sub) as acc, ttr.date,     
           ttr.val, space(15) as cct, ttr.remark,case when 
		(select sum( ttd.val*case when ttd.dk='K' then 1 else -1 end) from ttd where ttd.ttr=@jurnal group by ttd.ttr)  < 0  
			then 'K' 
			else 'D' end as dk , 'TTC' AS subjurnal, 0 as adj
           FROM ttr
           WHERE @jurnal=ttr.ttr
union all
SELECT ttr.ttr AS jurnal, ttr.period,  (select max(acc) from rhp where rhp.jurnal=ttd.jurnal and rhp.period=period)  as acc, ttr.date,     
           ttd.val, space(15) as cct, ttr.remark, ttd.dk , 'TTC' AS subjurnal, 0 as adj
           FROM ttd left outer join ttr on ttd.ttr=ttr.ttr
           WHERE @jurnal=ttd.ttr
) as xacd  
End

If @subjurnal='KKK'  
Begin  
insert into acd select * from (  
SELECT kas.kas AS jurnal, kas.period, kas.acc, kas.date,     
           kas.val, space(15) as cct, kas.remark, 'K' as dk, 'KKK' AS subjurnal, 0 as adj
           FROM kas
           WHERE @jurnal=kas.kas
union all
SELECT kas.kas AS jurnal, kas.period, kad.acc, kas.date,     
           kad.val, kad.cct, kad.remark, 'D' as dk, 'KKK' AS subjurnal, 0 as adj
           FROM kad left outer join kas on kad.kas=kas.kas
           WHERE @jurnal=kas.kas
) as xacd  
End

If @subjurnal='KKM'  
Begin  
insert into acd select * from (  
SELECT kas.kas AS jurnal, kas.period, kas.acc, kas.date,     
           kas.val, space(15) as cct, kas.remark, 'D' as dk, 'KKM' AS subjurnal, 0 as adj
           FROM kas
           WHERE @jurnal=kas.kas
union all
SELECT kas.kas AS jurnal, kas.period, kad.acc, kas.date,     
           kad.val, kad.cct, kad.remark, 'K' as dk, 'KKM' AS subjurnal, 0 as adj
           FROM kad left outer join kas on kad.kas=kas.kas
           WHERE @jurnal=kas.kas
) as xacd  
End

If @subjurnal='KKG'  
Begin  
insert into acd select * from (  
SELECT kag.kas AS jurnal, kas.period, kas.acc, kas.date,     
           (kag.val+kas.val) as val, space(15) as cct, kas.remark, 'K' as dk, 'KKG' AS subjurnal, 0 as adj
           FROM kag left outer join kas on kag.kas=kas.kas
           WHERE @jurnal=kag.kas
union all
SELECT kas.kas AS jurnal, kas.period, kad.acc, kas.date,     
           kad.val, kad.cct, kad.remark, 'D' as dk, 'KKG' AS subjurnal, 0 as adj
           FROM kad left outer join kas on kad.kas=kas.kas
           WHERE @jurnal=kas.kas
) as xacd  
End

If @subjurnal='KKL'  
Begin  
insert into acd select * from (  
SELECT kas.kas AS jurnal, kas.period, kas.acc, kas.date,     
           (kas.val*kas.kurs) as val, space(15) as cct, kas.remark, 'K' as dk, 'KKL' AS subjurnal, 0 as adj
           FROM kas
           WHERE @jurnal=kas.kas and kas.val>0
union all
SELECT kag.kas AS jurnal, kas.period, kag.acc, kas.date,     
           (kag.val*kas.kurs) as val, space(15) as cct, kas.remark, 'K' as dk, 'KKL' AS subjurnal, 0 as adj
           FROM kag left outer join kas on kag.kas=kas.kas
           WHERE @jurnal=kag.kas and kag.val<>0
union all
SELECT kas.kas AS jurnal, kas. period, kad.acc, kas.date,     
           (kad.val*isnull((select top 1 rhp.kurs from rhp where rhp.jurnal=kad.jurnal),kas.kurs)) as val, kad.cct, kad.remark, kad.dk, 'KKL' AS subjurnal, 0 as adj
           FROM kad left outer join kas on kad.kas=kas.kas             
           WHERE @jurnal=kas.kas AND Kad.val<>0
union all
--laba /rugi kurs
SELECT kas.kas AS jurnal, kas.period, (select top 1 acc from kad where kad.kas=@jurnal and kad.val=0), kas.date,     
           abs((kad.val*kas.kurs)-(kad.val*isnull((select top 1 rhp.kurs from rhp where rhp.jurnal=kad.jurnal),kas.kurs))), kad.cct, 
	   case when (kad.val*kas.kurs*case when dk='D' then 1 else -1 end)<(kad.val*case when dk='D' then 1 else -1 end*isnull((select top 1 rhp.kurs from rhp where rhp.jurnal=kad.jurnal),kas.kurs)) then 'LABA KURS' else 'RUGI KURS' end,
	   case when (kad.val*kas.kurs*case when dk='D' then 1 else -1 end)<(kad.val*case when dk='D' then 1 else -1 end*isnull((select top 1 rhp.kurs from rhp where rhp.jurnal=kad.jurnal),kas.kurs)) then 'K' else 'D' end, 'KKL' AS subjurnal, 0 as adj
           FROM kad left outer join kas on kad.kas=kas.kas 
	   WHERE @jurnal=kas.kas and kad.val<>0 and (kad.val*kas.kurs)<>(kad.val*isnull((select top 1 rhp.kurs from rhp where rhp.jurnal=kad.jurnal),kas.kurs))


) as xacd  
End

If @subjurnal='KMS'  
Begin  
insert into acd select * from (  
SELECT kas.kas AS jurnal, kas.period, kas.acc, kas.date,     
           (kas.val*kas.kurs) as val, space(15) as cct, kas.remark, 'D' as dk, 'KMS' AS subjurnal, 0 as adj
           FROM kas
           WHERE @jurnal=kas.kas and kas.val>0
union all
SELECT kas.kas AS jurnal, kas.period, kag.acc, kas.date,     
           (kag.val*kas.kurs) as val, space(15) as cct, kas.remark, 'D' as dk, 'KMS' AS subjurnal, 0 as adj
           FROM kag left outer join kas on kag.kas=kas.kas
           WHERE @jurnal=kag.kas and kag.val<>0union all
SELECT kas.kas AS jurnal, kas.period, kad.acc, kas.date,     
           (kad.val*isnull((select top 1 rhp.kurs from rhp where rhp.jurnal=kad.jurnal),kas.kurs)) as val, kad.cct, kad.remark, kad.dk, 'KMS' AS subjurnal, 0 as adj
           FROM kad left outer join kas on kad.kas=kas.kas
	   WHERE @jurnal=kas.kas and kad.val<>0
union all
---rugi/laba kurs
SELECT kas.kas AS jurnal, kas.period, (select top 1 acc from kad where kad.kas=@jurnal and kad.val=0), kas.date,     
           abs((kad.val*kas.kurs)-(kad.val*isnull((select top 1 rhp.kurs from rhp where rhp.jurnal=kad.jurnal),kas.kurs))), kad.cct, 
	   case when (kad.val*kas.kurs)>(kad.val*isnull((select top 1 rhp.kurs from rhp where rhp.jurnal=kad.jurnal),kas.kurs)) then 'LABA KURS' else 'RUGI KURS' end,
	   case when (kad.val*kas.kurs)>(kad.val*isnull((select top 1 rhp.kurs from rhp where rhp.jurnal=kad.jurnal),kas.kurs)) then 'K' else 'D' end, 'KMS' AS subjurnal, 0 as adj
           FROM kad left outer join kas on kad.kas=kas.kas
	   WHERE @jurnal=kas.kas and kad.val<>0 and (kad.val*kas.kurs)<>(kad.val*isnull((select top 1 rhp.kurs from rhp where rhp.jurnal=kad.jurnal),kas.kurs))

) as xacd  
end

If @subjurnal='STR'  
Begin  
insert into acd select * from (  
SELECT str.str AS jurnal, str.period, str.acc, str.date,     
           str.val, space(15) as cct, str.remark, 'D' as dk, 'STR' AS subjurnal, 0 as adj
           FROM str
           WHERE @jurnal=str.str
union all
SELECT str.str AS jurnal, str.period, std.acc, str.date,     
           std.val, space(15) as cct, str.remark, 'K' as dk, 'STR' AS subjurnal, 0 as adj
           FROM std left outer join str on std.str=str.str
           WHERE @jurnal=str.str
) as xacd  
End

If @subjurnal='TLK'  
Begin  
insert into acd select * from (  
SELECT tlk.tlk AS jurnal, tlk.period, tlk.accbank, tlk.date,     
           tlk.bgval, space(15) as cct, tlk.remark, case when dk=1 then 'K' else 'D' end  as dk, 'TLK' AS subjurnal, 0 as adj
           FROM tlk
           WHERE @jurnal=tlk.tlk
union all
SELECT tlk.tlk AS jurnal, tlk.period, tlk.acc, tlk.date,     
           tlk.bgval, space(15) as cct, tlk.remark, case when dk=1 then 'D' else 'K' end  as dk, 'TLK' AS subjurnal, 0 as adj
           FROM tlk
           WHERE @jurnal=tlk.tlk
) as xacd  
End

If @subjurnal='CGR'  
Begin  
insert into acd select * from (  
SELECT cgr.cgr AS jurnal, cgr.period,  
	   case when dk=1 then cgr.accbank else (select kas.acc from kag left outer join kas on kag.kas=kas.kas where kag.nobg=cgr.nobg)end as acc, cgr.date,     
 	   (cgr.bgval)*(select kas.kurs from kag left outer join kas on kag.kas=kas.kas where kag.nobg=cgr.nobg) as val,
	   space(15) as cct, cgr.remark, case when dk=1 then 'D' else 'K' end  as dk, 'CGR' AS subjurnal, 0 as adj
           FROM cgr
           WHERE @jurnal=cgr.cgr
union all
SELECT cgr.cgr AS jurnal, cgr.period, cgr.acc, cgr.date,     
           cgr.bgval*(select kas.kurs from kag left outer join kas on kag.kas=kas.kas where kag.nobg=cgr.nobg) as val,
	   space(15) as cct, cgr.remark, case when dk=1 then 'K' else 'D' end  as dk, 'CGR' AS subjurnal, 0 as adj
           FROM cgr
           WHERE @jurnal=cgr.cgr
) as xacd  
End






































GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO




create PROCEDURE sp_savelama  @pdate datetime, @subjurnal char(15), @jurnal char(15)  AS

declare @period varchar(4)
set @period=dbo.date2period(@pdate)

exec sp_delete  @subjurnal,@jurnal,@period

If @subjurnal='OMS'  
Begin  
     insert into outpo 
	select oms.oms,oms.date,oms.sub,omd.inv,omd.loc,sum(omd.qty) as qty, oms.remark, oms.period 
                        from omd left outer join oms on omd.oms=oms.oms
	           where omd.oms=@jurnal                        
	           group by oms.oms,oms.date,oms.sub,omd.inv,omd.loc, oms.remark, oms.period
end

If @subjurnal='VPO'  
Begin  
     exec sp_insertrealpo @subjurnal,@jurnal
end


If @subjurnal='LPB'  
Begin  
     exec sp_insertrealpo @subjurnal,@jurnal
     --exec sp_SaveInv @subjurnal,@jurnal	
     --exec sp_SaveRhp @subjurnal,@jurnal	
     --exec sp_SaveAcd @subjurnal,@jurnal	 
end

If @subjurnal='MSK'  
Begin  
     exec sp_insertrealpo @subjurnal,@jurnal
     exec sp_SaveInv @subjurnal,@jurnal	
     exec sp_SaveRhp @subjurnal,@jurnal	
     exec sp_SaveAcd @subjurnal,@jurnal	 
end

If @subjurnal='RMS'  
Begin  
     exec sp_SaveInv @subjurnal,@jurnal	 
     exec sp_SaveRhp @subjurnal,@jurnal		
     exec sp_SaveAcd @subjurnal,@jurnal	 
end

If @subjurnal='OKL'  
Begin  
     insert into outso 
	select okl.okl,okl.date,okl.sub,okd.inv,okd.loc,sum(okd.qty) as qty, okl.remark, okl.period
                        from okd left outer join okl on okd.okl=okl.okl
  	          where okd.okl=@jurnal                        
	          group by okl.okl,okl.date,okl.sub,okd.inv,okd.loc, okl.remark, okl.period
end

If @subjurnal='VSO'  
Begin  
     exec sp_insertrealso @subjurnal,@jurnal
end

If @subjurnal='KLR'  
Begin  
     exec sp_insertrealso @subjurnal,@jurnal
     exec sp_SaveInv @subjurnal,@jurnal	
     exec sp_SaveRhp @subjurnal,@jurnal	
     exec sp_SaveAcd @subjurnal,@jurnal	 
end

If @subjurnal='RKL'  
Begin  
     exec sp_SaveInv @subjurnal,@jurnal	
     exec sp_SaveRhp @subjurnal,@jurnal	
     exec sp_SaveAcd @subjurnal,@jurnal	 
end

if @subjurnal='JIN'
Begin
    exec sp_SaveInv @subjurnal,@jurnal	
    exec sp_SaveAcd @subjurnal,@jurnal	
End

if @subjurnal='TRM'
Begin
    exec sp_SaveInv @subjurnal,@jurnal	
    exec sp_SaveAcd @subjurnal,@jurnal		
End

if @subjurnal='OPN'
Begin
    exec sp_SaveInv @subjurnal,@jurnal	
    exec sp_SaveAcd @subjurnal,@jurnal		
End

if @subjurnal='UMH'
Begin
    exec sp_SaveAcd @subjurnal,@jurnal	
    exec sp_SaveAcd @subjurnal,@jurnal		
End

if @subjurnal='JSU'
Begin
    exec sp_SaveRhp @subjurnal,@jurnal	
    exec sp_SaveAcd @subjurnal,@jurnal	 
End

if @subjurnal='TTS'
Begin
    exec sp_SaveRhp @subjurnal,@jurnal	
    exec sp_PostRhp @subjurnal,@jurnal	
    exec sp_SaveAcd @subjurnal,@jurnal	 
End

if @subjurnal='TTC'
Begin
    exec sp_SaveRhp @subjurnal,@jurnal	
    exec sp_PostRhp @subjurnal,@jurnal	
    exec sp_SaveAcd @subjurnal,@jurnal	 
End

if @subjurnal='KKK'
Begin
    exec sp_SaveAcd @subjurnal,@jurnal	 
End

if @subjurnal='KKM'
Begin
    exec sp_SaveAcd @subjurnal,@jurnal	 
End

if @subjurnal='KKL'
Begin
    exec sp_Savergr @subjurnal,@jurnal	
    exec sp_Saverhp @subjurnal,@jurnal		
    exec sp_PostRhp @subjurnal,@jurnal	
    exec sp_SaveAcd @subjurnal,@jurnal	 
End

if @subjurnal='KMS'
Begin
    exec sp_Savergr @subjurnal,@jurnal	
    exec sp_Saverhp @subjurnal,@jurnal		
    exec sp_PostRhp @subjurnal,@jurnal	
    exec sp_SaveAcd @subjurnal,@jurnal	 
End

if @subjurnal='STR'
Begin
    exec sp_Savergr @subjurnal,@jurnal	
    exec sp_SaveAcd @subjurnal,@jurnal	 
End

if @subjurnal='TLK'
Begin
    exec sp_Savergr @subjurnal,@jurnal	
    exec sp_SaveRhp @subjurnal,@jurnal		
    exec sp_SaveAcd @subjurnal,@jurnal	 
End

if @subjurnal='CGR'
Begin
    exec sp_Savergr @subjurnal,@jurnal	
    exec sp_SaveAcd @subjurnal,@jurnal	 
End

/*
If @subjurnal=space(3) or @subjurnal='MSK'  
Begin  
insert into acd select * from (  
SELECT msk.msk AS jurnal, @period AS period, sub.acc, msk.date,     
           msk.val, space(15) as cct, msk.remark, 'K' as dk, 'MSK' AS subjurnal, 0 as adj
           FROM msk left outer join sub on msk.sub=sub.sub
           WHERE @jurnal=msk.msk
) as xacd  
insert into acd select * from (  
SELECT msk.msk AS jurnal, @period AS period, inv.accloc as acc, msk.date,     
           (((msd.price*msd.qty)*(100.00-msk.disc)/100.00)*(100.00-msd.disc)/100.00)*case when msk.ppn=2 then @V10Bagi11 else 1 end as val, 
           space(15) as cct, msd.remark, 'D' as dk, 'MSK' AS subjurnal, 0 as adj
           FROM msd left outer join msk on msd.msk=msk.msk
           left outer join inv on msd.inv=inv.inv
           WHERE @jurnal=msd.msk and msd.qty>0
) as xacd  
end

If @subjurnal=space(3) or @subjurnal='RMS'  
Begin  
insert into acd select * from (  
SELECT rms.rms AS jurnal, @period AS period, sub.acc, rms.date,     
           rms.val, space(15) as cct, rms.remark, 'D' as dk, 'RMS' AS subjurnal, 0 as adj
           FROM rms left outer join sub on rms.sub=sub.sub
           WHERE @jurnal=rms.rms
) as xacd  
insert into acd select * from (  
SELECT rms.rms AS jurnal, @period AS period, inv.accloc as acc, rms.date,     
           (((rmd.price*rmd.qty)*(100.00-rms.disc)/100.00)*(100.00-rmd.disc)/100.00)*case when rms.ppn=2 then @V10Bagi11 else 1 end as val, 
           space(15) as cct, rmd.remark, 'K' as dk, 'RMS' AS subjurnal, 0 as adj
           FROM rmd left outer join rms on rmd.rms=rms.rms
           left outer join inv on rmd.inv=inv.inv
           WHERE @jurnal=rmd.rms and rmd.qty>0
) as xacd  
end

If @subjurnal=space(3) or @subjurnal='KLR'  
Begin  
insert into acd select * from (  
SELECT klr.klr AS jurnal, @period AS period, sub.acc, klr.date,     
           klr.val, space(15) as cct, klr.remark, 'D' as dk, 'KLR' AS subjurnal, 0 as adj
           FROM klr left outer join sub on klr.sub=sub.sub
           WHERE @jurnal=klr.klr
) as xacd  
insert into acd select * from (  
SELECT klr.klr AS jurnal, @period AS period, inv.accrev as acc, klr.date,     
           (((kld.price*kld.qty)*(100.00-klr.disc)/100.00)*(100.00-kld.disc)/100.00)*case when klr.ppn=2 then @V10Bagi11 else 1 end as val, 
           inv.cctrev as cct, kld.remark, 'K' as dk, 'KLR' AS subjurnal, 0 as adj
           FROM kld left outer join klr on kld.klr=klr.klr
           left outer join inv on kld.inv=inv.inv
           WHERE @jurnal=kld.klr and kld.qty>0
) as xacd  
end

If @subjurnal=space(3) or @subjurnal='RKL'  
Begin  
insert into acd select * from (  
SELECT rkl.rkl AS jurnal, @period AS period, sub.acc, rkl.date,     
           rkl.val, space(15) as cct, rkl.remark, 'K' as dk, 'JSU' AS subjurnal, 0 as adj
           FROM rkl left outer join sub on rkl.sub=sub.sub
           WHERE @jurnal=rkl.rkl
) as xacd  
insert into acd select * from (  
SELECT rkl.rkl AS jurnal, @period AS period, inv.accrev as acc, rkl.date,     
           (((rkd.price*rkd.qty)*(100.00-rkl.disc)/100.00)*(100.00-rkd.disc)/100.00)*case when rkl.ppn=2 then @V10Bagi11 else 1 end as val, 
           inv.cctrev as cct, rkd.remark, 'D' as dk, 'JSU' AS subjurnal, 0 as adj
           FROM rkd left outer join rkl on rkd.rkl=rkl.rkl
           left outer join inv on rkd.inv=inv.inv
           WHERE @jurnal=rkd.rkl and rkd.qty>0
) as xacd  
end

If @subjurnal=space(3) or @subjurnal='JSU'  
Begin  
insert into acd select * from (  
SELECT jsu.jsu AS jurnal, @period AS period, sub.acc, jsu.date,     
           jsu.val, space(15) as cct, jsu.remark, case when jsu.dk=1 then 'K' else 'D' end as dk, 'JSU' AS subjurnal, 0 as adj
           FROM jsu left outer join sub on jsu.sub=sub.sub
           WHERE @jurnal=jsu.jsu
) as xacd  
insert into acd select * from (  
SELECT jsu.jsu AS jurnal, @period AS period, jsu.acc, jsu.date,     
           jsu.val, jsu.cct, jsu.remark, case when jsu.dk=1 then 'D' else 'K' end as dk, 'JSU' AS subjurnal, 0 as adj
           FROM jsu 
           WHERE @jurnal=jsu.jsu
) as xacd  
end

If @subjurnal=space(3) or @subjurnal='KAS'  
Begin  
insert into acd select * from (  
SELECT kas.kas AS jurnal, @period AS period, kas.acc, kas.date,     
           kas.val, space(15) as cct, kas.remark, case when kas.group_=1 then 'K' else 'D' end as dk, 'KAS' AS subjurnal, 0 as adj
           FROM kas
           WHERE @jurnal=kas.kas
) as xacd  

insert into acd select * from (  
SELECT kas.kas AS jurnal, @period AS period, sub.acc, kas.date,     
           abs(kad.val) as val, space(15) as cct, kad.remark,
           case when kas.group_=1 then  
                 case when kad.val>=0 then 'D' else 'K' end
           else
	    case when kad.val>=0 then 'K' else 'D' end
           end as dkl , 
           'KAS' AS subjurnal, 0 as adj
           FROM kad left outer join kas on kad.kas=kas.kas  
           left outer join  sub on kas.acc=sub.acc
           WHERE @jurnal=kad.kas
) as xacd  

end

If @jurnal<>space(15)
  Exec sp_SaveInv @subjurnal,@jurnal
*/



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO





CREATE   PROCEDURE sp_savergr @subjurnal char(15), @jurnal char(15)  AS

If @subjurnal='KKL'  
Begin  
insert into rghp select * from (  
SELECT kag.kas AS jurnal,  kas.date, kag.duedate, kas.sub, kag.nobg, kag.bank,
	kag.acbank, kag.acc,
	'K' as dk, kag.val*kas.kurs as  val, @subjurnal as subjurnal, kas.remark, ' ' as group_,
 	(select top 1 accbank from kgr where kgr.acc=kag.acc) as acclawan,kas.period
	FROM kag left outer join kas on kag.kas=kas.kas
	WHERE @jurnal=kag.kas
) as xacd  
insert into rgr select * from (  
SELECT kas.period as period, kag.kas AS jurnal,  kas.date, kag.duedate, kas.sub, kag.nobg, kag.bank,
	kag.acbank, kag.acc,
	'K' as dk, kag.val *kas.kurs as  val, @subjurnal as subjurnal, kas.remark, ' ' as group_,
 	(select top 1 accbank from kgr where kgr.acc=kag.acc) as acclawan, ' ' as groupasli, kas.period as periodtrans
	FROM kag left outer join kas on kag.kas=kas.kas
	WHERE @jurnal=kag.kas
) as xacd  
end

If @subjurnal='KMS'  
Begin  
insert into rghp select * from (  
SELECT kag.kas AS jurnal,  kas.date, kag.duedate, kas.sub, kag.nobg, kag.bank,
	kag.acbank, kag.acc,
	'D' as dk, kag.val *kas.kurs as  val, @subjurnal as subjurnal, kas.remark, ' ' as group_, 
 	(select top 1 accbank from kgr where kgr.acc=kag.acc) as acclawan,kas.period
	FROM kag left outer join kas on kag.kas=kas.kas
	WHERE @jurnal=kag.kas
) as xacd
insert into rgr select * from (  
SELECT kas.period as period, kag.kas AS jurnal,  kas.date, kag.duedate, kas.sub, kag.nobg, kag.bank,
	kag.acbank, kag.acc,
	'D' as dk, kag.val*kas.kurs as  val, @subjurnal as subjurnal, kas.remark, ' ' as group_,
 	(select top 1 accbank from kgr where kgr.acc=kag.acc) as acclawan,' ' as groupasli, kas.period  as periodtrans
	FROM kag left outer join kas on kag.kas=kas.kas
	WHERE @jurnal=kag.kas
) as xacd    
end

If @subjurnal='STR'  
Begin  
insert into rghp select * from (  
SELECT std.str AS jurnal,  str.date, std.duedate, (select kas.sub  from kag left outer join kas on kag.kas=kas.kas where kag.nobg=std.nobg and kag.group_='2' ) as sub, std.nobg, std.bank,
	std.acbank, std.acc,
	std.dk, std.val, @subjurnal as subjurnal, str.remark, 'S' as group_, 
 	str.acc as acclawan,str.period
	FROM std left outer join str on std.str=str.str
	WHERE @jurnal=std.str
) as xacd  
insert into rghp select * from (  
SELECT std.str AS jurnal,  std.date, std.duedate, (select kas.sub  from kag left outer join kas on kag.kas=kas.kas where kag.nobg=std.nobg and kag.group_='2' ) as sub, std.nobg, std.bank,
	std.acbank, str.acc,
	case when std.dk='D' then 'K' else 'D' end as dk, std.val, @subjurnal as subjurnal, str.remark, ' ' as group_, 
 	(select accbank from kgr where kgr.acc=str.acc and kgr.group_=1) as acclawan,str.period
	FROM std left outer join str on std.str=str.str
	WHERE @jurnal=std.str
) as xacd  
end

If @subjurnal='TLK'  
Begin  
insert into rghp select * from (  
SELECT tlk.tlk AS jurnal,  tlk.date, tlk.bgduedate, tlk.sub, tlk.nobg, tlk.bank,
	tlk.acbank, tlk.accbank as acc,
	case when tlk.dk=1 then 'K' else 'D' end as dk, tlk.bgval, @subjurnal as subjurnal, tlk.remark, 'T' as group_, 
 	tlk.acc as acclawan,tlk.period
	FROM tlk
	WHERE @jurnal=tlk.tlk
) as xacd  
end

If @subjurnal='CGR'  
Begin  
insert into rghp select * from (  
SELECT cgr.cgr AS jurnal,  cgr.date, cgr.bgduedate, cgr.sub, cgr.nobg, cgr.bank,
	cgr.acbank, cgr.acc ,
	case when cgr.dk=1 then 'K' else 'D' end as dk, cgr.bgval, @subjurnal as subjurnal, cgr.remark, 'C' as group_, 
 	cgr.accbank as acclawan,cgr.period
	FROM cgr
	WHERE @jurnal=cgr.cgr
) as xacd  
end


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO




create  PROCEDURE sp_savergr1 @subjurnal char(15), @jurnal char(15)  AS

If @subjurnal='KKL'  
Begin  
insert into rghp select * from (  
SELECT kag.kas AS jurnal,  kas.date, kag.duedate, kas.sub, kag.nobg, kag.bank,
	kag.acbank, kag.acc,
	'K' as dk, kag.val*kas.kurs as  val, @subjurnal as subjurnal, kas.remark, ' ' as group_,
 	(select top 1 accbank from kgr where kgr.acc=kag.acc) as acclawan,kas.period
	FROM kag left outer join kas on kag.kas=kas.kas
	WHERE @jurnal=kag.kas
) as xacd  
insert into rgr select * from (  
SELECT kas.period as period, kag.kas AS jurnal,  kas.date, kag.duedate, kas.sub, kag.nobg, kag.bank,
	kag.acbank, kag.acc,
	'K' as dk, kag.val *kas.kurs as  val, @subjurnal as subjurnal, kas.remark, ' ' as group_,
 	(select top 1 accbank from kgr where kgr.acc=kag.acc) as acclawan, ' ' as groupasli, kas.period as periodtrans
	FROM kag left outer join kas on kag.kas=kas.kas
	WHERE @jurnal=kag.kas
) as xacd  
end

If @subjurnal='KMS'  
Begin  
insert into rghp select * from (  
SELECT kag.kas AS jurnal,  kas.date, kag.duedate, kas.sub, kag.nobg, kag.bank,
	kag.acbank, kag.acc,
	'D' as dk, kag.val *kas.kurs as  val, @subjurnal as subjurnal, kas.remark, ' ' as group_, 
 	(select top 1 accbank from kgr where kgr.acc=kag.acc) as acclawan,kas.period
	FROM kag left outer join kas on kag.kas=kas.kas
	WHERE @jurnal=kag.kas
) as xacd
insert into rgr select * from (  
SELECT kas.period as period, kag.kas AS jurnal,  kas.date, kag.duedate, kas.sub, kag.nobg, kag.bank,
	kag.acbank, kag.acc,
	'D' as dk, kag.val*kas.kurs as  val, @subjurnal as subjurnal, kas.remark, ' ' as group_,
 	(select top 1 accbank from kgr where kgr.acc=kag.acc) as acclawan,' ' as groupasli, kas.period  as periodtrans
	FROM kag left outer join kas on kag.kas=kas.kas
	WHERE @jurnal=kag.kas
) as xacd    
end

If @subjurnal='STR'  
Begin  
insert into rghp select * from (  
SELECT std.str AS jurnal,  str.date, std.duedate, (select kas.sub  from kag left outer join kas on kag.kas=kas.kas where kag.nobg=std.nobg and kag.group_='2' ) as sub, std.nobg, std.bank,
	std.acbank, std.acc,
	std.dk, std.val, @subjurnal as subjurnal, str.remark, 'S' as group_, 
 	str.acc as acclawan,str.period
	FROM std left outer join str on std.str=str.str
	WHERE @jurnal=std.str
) as xacd  
insert into rghp select * from (  
SELECT std.str AS jurnal,  std.date, std.duedate, (select kas.sub  from kag left outer join kas on kag.kas=kas.kas where kag.nobg=std.nobg and kag.group_='2' ) as sub, std.nobg, std.bank,
	std.acbank, str.acc,
	case when std.dk='D' then 'K' else 'D' end as dk, std.val, @subjurnal as subjurnal, str.remark, ' ' as group_, 
 	(select accbank from kgr where kgr.acc=str.acc and kgr.group_=1) as acclawan,str.period
	FROM std left outer join str on std.str=str.str
	WHERE @jurnal=std.str
) as xacd  
end

If @subjurnal='TLK'  
Begin  
insert into rghp select * from (  
SELECT tlk.tlk AS jurnal,  tlk.date, tlk.bgduedate, tlk.sub, tlk.nobg, tlk.bank,
	tlk.acbank, tlk.accbank as acc,
	case when tlk.dk=1 then 'K' else 'D' end as dk, tlk.bgval, @subjurnal as subjurnal, tlk.remark, 'T' as group_, 
 	tlk.acc as acclawan,tlk.period
	FROM tlk
	WHERE @jurnal=tlk.tlk
) as xacd  
end

If @subjurnal='CGR'  
Begin  
insert into rghp select * from (  
SELECT cgr.cgr AS jurnal,  cgr.date, cgr.bgduedate, cgr.sub, cgr.nobg, cgr.bank,
	cgr.acbank, cgr.acc ,
	case when cgr.dk=1 then 'K' else 'D' end as dk, cgr.bgval, @subjurnal as subjurnal, cgr.remark, 'C' as group_, 
 	cgr.accbank as acclawan,cgr.period
	FROM cgr
	WHERE @jurnal=cgr.cgr
) as xacd  
end

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

















CREATE              PROCEDURE sp_saverhp @subjurnal char(15), @jurnal char(15)  AS

If @subjurnal='MSK'  
Begin  
/*
insert into rhp select * from (  
SELECT msk.msk AS jurnal, @subjurnal as subjurnal, msk.date, 
        msk.sub, grp.acc, 'K'  as dk, msk.val*(case when msk.kurs=0 then 1 else msk.kurs end) as val, msk.duedate, msd.remark, 0 as payment, msk.period,msd. invo as invoice     	
	FROM msd
	left outer join msk on msd.msk=msk.msk
	left outer join sub on msk.sub=sub.sub
	left outer join grp on sub.grp=grp.grp
	WHERE @jurnal=msk.msk
) as xacd  
end
If @subjurnal='MSI'  
Begin  
insert into rhp select * from (  
SELECT msk.msk AS jurnal, @subjurnal as subjurnal, msk.date, 
        msk.sub, grp.acc, 'K'  as dk, msk.val*(case when msk.kurs=0 then 1 else msk.kurs end) as val, msk.duedate, msd.remark, 0 as payment, msk.period,msd. invo as invoice     	
	FROM msd
	left outer join msk on msd.msk=msk.msk
	left outer join sub on msk.sub=sub.sub
	left outer join grp on sub.grp=grp.grp
	WHERE @jurnal=msk.msk
) as xacd  
end
*/
insert into rhp select * from (  
SELECT msk.msk AS jurnal, @subjurnal as subjurnal, msk.date, 
        msk.sub, grp.acc, 'K'  as dk, msk.val as val, msk.duedate, msk.remark, 0 as payment, msk.period,space(15) as invoice,msk.kurs         	
	FROM msk
	left outer join sub on msk.sub=sub.sub
	left outer join grp on sub.grp=grp.grp
	WHERE @jurnal=msk.msk
) as xacd  
end
If @subjurnal='MSI'  
Begin  
insert into rhp select * from (  
SELECT msk.msk AS jurnal, @subjurnal as subjurnal, msk.date, 
        msk.sub, grp.acc, 'K'  as dk, msk.val as val, msk.duedate, msk.remark, 0 as payment, msk.period,space(15) as invoice,msk.kurs     	
	FROM msk
	left outer join sub on msk.sub=sub.sub
	left outer join grp on sub.grp=grp.grp
	WHERE @jurnal=msk.msk
) as xacd  
end

If @subjurnal='RMS'  
Begin  
insert into rhp select * from (  
SELECT rms.rms AS jurnal, @subjurnal as subjurnal, rms.date, 
        rms.sub, grp.acc, 'D'  as dk, rms.val as val, rms.duedate, rms.remark, 0 as payment, rms.period,space(15) as invoice,rms.kurs     	     	
	FROM rms
	left outer join sub on rms.sub=sub.sub
	left outer join grp on sub.grp=grp.grp
	WHERE @jurnal=rms.rms
) as xacd  
end

If @subjurnal='KLR'  
Begin  
insert into rhp select * from (  
SELECT klr.klr AS jurnal, @subjurnal as subjurnal, klr.date, 
             klr.sub, grp.acc, 'D'  as dk, klr.val as val, klr.duedate, klr.remark, 0 as payment, klr.period,space(15) as invoice,klr.kurs
	FROM klr
	left outer join sub on klr.sub=sub.sub
	left outer join grp on sub.grp=grp.grp
	WHERE @jurnal=klr.klr
) as xacd  
end

If @subjurnal='RKL'  
Begin  
insert into rhp select * from (  
SELECT rkl.rkl AS jurnal, @subjurnal as subjurnal, rkl.date, 
             rkl.sub, grp.acc, 'K'  as dk, rkl.val, rkl.duedate, rkl.remark, 0 as payment, rkl.period,space(15) as invoice,rkl.kurs     	     	     	
	FROM rkl
	left outer join sub on rkl.sub=sub.sub
	left outer join grp on sub.grp=grp.grp
	WHERE @jurnal=rkl.rkl
) as xacd  
end

If @subjurnal='JSU'  
Begin  
insert into rhp select * from (  
SELECT jsu.jsu AS jurnal, @subjurnal as subjurnal, jsu.date, 
             jsu.sub, jsu.acc, case when dk=1 then 'D' else 'K' end as dk, jsu.val as val, jsu.duedate, jsu.remark, 0 as payment, jsu.period,space(15) as invoice,jsu.kurs     	     	     	
	FROM jsu  
	WHERE @jurnal=jsu.jsu
) as xacd  
end

If @subjurnal='TTS'  
Begin  
insert into rhp select * from (  
SELECT ttr.ttr AS jurnal, @subjurnal as subjurnal, ttr.date, 
             ttr.sub, (select acc from sub where sub.sub=ttr.sub) as acc, 'K'  as dk, ttr.val, ttr.duedate, ttr.remark, 0 as payment, ttr.period,space(15) as invoice,1.00 as kurs     	     	     	
	FROM ttr
	WHERE @jurnal=ttr.ttr
) as xacd  
end

If @subjurnal='TTC'  
Begin  
insert into rhp select * from (  
SELECT ttr.ttr AS jurnal, @subjurnal as subjurnal, ttr.date, 
             ttr.sub, (select acc from sub where sub.sub=ttr.sub) as acc, 'D'  as dk, ttr.val, ttr.duedate, ttr.remark, 0 as payment, ttr.period,space(15) as invoice,1.00 as kurs     	     	     	
	FROM ttr
	WHERE @jurnal=ttr.ttr
) as xacd  
end

If @subjurnal='KMS'  
Begin 
update kad set kad.jurnal=kad.kas 
	from kad left outer join kas on kad.kas=kas.kas
	where kad.jurnal=' ' and 
 	( kad.acc=(select isnull(grp.accum,space(15)) from sub left outer join grp on sub.grp=grp.grp  where sub.sub=kas.sub)
 	or 
	kad.acc=(select isnull(grp.acc,space(15)) from sub left outer join grp on sub.grp=grp.grp  where sub.sub=kas.sub))
	and  kad.kas=@jurnal
insert into rhp select * from (  
SELECT max(kad.kas) AS jurnal, 'KMS' as subjurnal, max(kas.date)as date, 
             kas.sub, kad.acc,kad. dk, sum(kad.val)as val, max(kas.date) as duedate, max(kad.remark)as remark, 0 as payment, max(kas.period)as period,space(15) as invoice,max(kas.kurs)as kurs
	--case when kas.valrp=0 then kas.kurs else kas.valrp/kas.val end as kurs     	     	     	
	FROM kad left outer join kas on kad.kas=kas.kas
	WHERE @jurnal=kad.kas and kad.jurnal=kad.kas
group by kad.jurnal,kad.acc,kas.sub,kad.dk
) as xacd  
end

If @subjurnal='KKL'  
Begin 
update kad set jurnal=kad.kas 
	from kad left outer join kas on kad.kas=kas.kas
	where kad.jurnal=' ' and 
	(kad.acc=(select isnull(grp.accum,space(15)) from sub left outer join grp on sub.grp=grp.grp  where sub.sub=kas.sub)
	or 
	kad.acc=(select isnull(grp.acc,space(15)) from sub left outer join grp on sub.grp=grp.grp  where sub.sub=kas.sub))
	and  kad.kas=@jurnal
insert into rhp select * from (  
SELECT max(kad.kas) AS jurnal, 'KKL' as subjurnal, max(kas.date) as date, 
             kas.sub, kad.acc,kad. dk,sum(kad.val) as val, max(kas.date) as duedate, max(kas.remark) as remark, 0 as payment, max(kas.period)as period,space(15) as invoice,max(kas.kurs) as kurs     	     	     	
	FROM kad left outer join kas on kad.kas=kas.kas
	WHERE @jurnal=kad.kas and kad.jurnal=kad.kas
group by kad.jurnal,kad.acc,kas.sub,kad.dk) 
as xacd  
insert into rhp select * from (  
SELECT kad.kas AS jurnal,'KKL' as subjurnal, kas.date, 
             kas.sub, grp.accum,'D' as dk ,sum(kad.val*(case when kad.dk='D' then 1 else -1 end)) as val, kas.date as duedate, kas.remark, 0 as payment, kas.period,space(15) as invoice,kas.kurs     	     	     	
	FROM kad left outer join kas on kad.kas=kas.kas
	left outer join sub on kas.sub=sub.sub
	left outer join grp on sub.grp=grp.grp
	WHERE @jurnal=kad.kas and kad.jurnal<>' ' and kad.acc=grp.accumbf
group by kad.kas,kas.date,kas.sub,grp.accum,kas.date,kas.remark,kas.period,kas.kurs
) as xacd  
end

If @subjurnal='TLK'  
Begin  
insert into rhp select * from (  
SELECT tlk.tlk AS jurnal, @subjurnal as subjurnal, tlk.date, 
             tlk.sub, tlk.acc, 'D'  as dk, tlk.bgval, tlk.date as duedate, tlk.remark, 0 as payment, tlk.period,space(15) as invoice,1.00 as kurs     	     	     	
	FROM tlk
	WHERE @jurnal=tlk.tlk
) as xacd  
end






GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO







CREATE     PROCEDURE sp_submut @suba char(15), @subz char(15), @pdate0 datetime, @pdatea datetime, @pdatez datetime, @group_ varchar(1), @pacca varchar(15), @paccz varchar(15)

AS

declare @period char(4)
set @period=dbo.date2period(@pdatea)

select acc,sub, @pdatea-1 as date, 'Saldo Awal' as rem, sum(debet) as vdebet, sum(kredit) as vkredit,' ' as jurnal  into #awal from  
(
select rsb.val*rsb.kurs*case when rsb.dk='D' then 1 else 0 end as debet,
	rsb.val*rsb.kurs*case when rsb.dk='K' then 1 else 0 end as kredit,
	rsb.acc, rsb.sub
from rsb
where rsb.sub between @suba and @subz and rsb.period=@period and rsb.acc between @pacca and @paccz
union all
select rhp.val*rhp.kurs*case when rhp.dk='D' then 1 else 0 end as debet, 
	rhp.val*case when rhp.dk='K' then 1 else 0 end as kredit, 
	rhp.acc, rhp.sub
from rhp
where rhp.sub between @suba and @subz and rhp.date>=@pdate0 and  rhp.date<@pdatea and rhp.acc between @pacca and @paccz
union all
select payhp.val*(select top 1 kurs from rhp where rhp.jurnal=payhp.reff)*case when payhp.dk='D' then 1 else 0 end as debet, 
	payhp.val*(select top 1 kurs from rhp where rhp.jurnal=payhp.reff)*case when payhp.dk='K' then 1 else 0 end as kredit, 
--select payhp.val*(select top 1 kurs from rhp where rhp.jurnal=payhp.jurnal)*case when payhp.dk='D' then 1 else 0 end as debet, 
--	payhp.val*(select top 1 kurs from rhp where rhp.jurnal=payhp.jurnal)*case when payhp.dk='K' then 1 else 0 end as kredit, 

	payhp.acc, payhp.sub
from payhp
where payhp.sub between @suba and @subz and payhp.date>=@pdate0 and  payhp.date<@pdatea and payhp.acc between @pacca and @paccz
) as awal group by acc,sub

select * into #mutasi from  
(
select rhp.acc, rhp.sub, rhp.date, rhp.remark as rem, 
	rhp.val*rhp.kurs*case when rhp.dk='D' then 1 else 0 end as debet, 
	rhp.val*rhp.kurs*case when rhp.dk='K' then 1 else 0 end as kredit, rhp.jurnal
from rhp
where rhp.sub between @suba and @subz and rhp.date>=@pdatea and  rhp.date<=@pdatez and rhp.acc between @pacca and @paccz
union all
select payhp.acc, payhp.sub, payhp.date, 'Pelunasan Nota No. '+payhp.reff as rem, 
	payhp.val*(select top 1 kurs from rhp where rhp.jurnal=payhp.reff)*case when dk='D' then 1 else 0 end as debet, 
	payhp.val*(select top 1 kurs from rhp where rhp.jurnal=payhp.reff)*case when dk='K' then 1 else 0 end as kredit, payhp.jurnal
       --      payhp.val*(select top 1 kurs from rhp where rhp.jurnal=payhp.jurnal)*case when dk='D' then 1 else 0 end as debet, 
 	--payhp.val*(select top 1 kurs from rhp where rhp.jurnal=payhp.jurnal)*case when dk='K' then 1 else 0 end as kredit, payhp.jurnal
from payhp
where payhp.sub between @suba and @subz and payhp.date>=@pdatea and  payhp.date<=@pdatez and payhp.acc between @pacca and @paccz
) as mutasi

select #awal.*, sub.name as subname, acc.name as accname
from #awal
left outer join sub on #awal.sub=sub.sub 
left outer join acc on #awal.acc=acc.acc 
where sub.group_=@group_
union all
select #mutasi.*, sub.name as subname, acc.name as accname
from #mutasi
left outer join sub on #mutasi.sub=sub.sub 
left outer join acc on #mutasi.acc=acc.acc 
where sub.group_=@group_
order by 1,2,3,6

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO










CREATE        PROCEDURE sp_submut1 @suba char(15), @subz char(15), @pdate0 datetime, @pdatea datetime, @pdatez datetime, @group_ varchar(1), @pacca varchar(15), @paccz varchar(15)

AS

declare @period char(4)
set @period=dbo.date2period(@pdatea)

select acc,sub, @pdatea-1 as date, 'Saldo Awal' as rem, sum(debetus) as vdebetUS, sum(kreditus) as vkreditUS, sum(debet) as vdebet, sum(kredit) as vkredit
       ,' ' as jurnal  into #awal from  
(
select rsb.val*case when rsb.dk='D' then 1 else 0 end as debetus,
	rsb.val*case when rsb.dk='K' then 1 else 0 end as kreditus,
	rsb.val*rsb.kurs*case when rsb.dk='D' then 1 else 0 end as debet,
	rsb.val*rsb.kurs*case when rsb.dk='K' then 1 else 0 end as kredit,
	rsb.acc, rsb.sub
from rsb
where rsb.sub between @suba and @subz and rsb.period=@period and (rsb.acc between @pacca and @paccz) and rsb.kurs>1
union all
select rhp.val*case when rhp.dk='D' then 1 else 0 end as debetus, 
	rhp.val*case when rhp.dk='K' then 1 else 0 end as kreditus, 
	rhp.val*rhp.kurs*case when rhp.dk='D' then 1 else 0 end as debet, 
	rhp.val*case when rhp.dk='K' then 1 else 0 end as kredit, 
	rhp.acc, rhp.sub
from rhp
where rhp.sub between @suba and @subz and rhp.date>=@pdate0 and  rhp.date<@pdatea and (rhp.acc between @pacca and @paccz) and rhp.kurs>1
union all
select payhp.val*case when payhp.dk='D' then 1 else 0 end as debetus, 
	payhp.val*case when payhp.dk='K' then 1 else 0 end as kreditus, 
	payhp.val*(select top 1 kurs from rhp where rhp.jurnal=payhp.reff)*case when payhp.dk='D' then 1 else 0 end as debet, 
	payhp.val*(select top 1 kurs from rhp where rhp.jurnal=payhp.reff)*case when payhp.dk='K' then 1 else 0 end as kredit, 
	payhp.acc, payhp.sub
from payhp
where payhp.sub between @suba and @subz and payhp.date>=@pdate0 and  payhp.date<@pdatea and payhp.acc between @pacca and @paccz
and payhp.reff in (select jurnal from rhp where kurs>1)
) as awal group by acc,sub

select * into #mutasi from  
(
select rhp.acc, rhp.sub, rhp.date, rhp.remark as rem, 
	rhp.val*case when rhp.dk='D' then 1 else 0 end as debetus, 
	rhp.val*case when rhp.dk='K' then 1 else 0 end as kreditus, 
	rhp.val*rhp.kurs*case when rhp.dk='D' then 1 else 0 end as debet, 
	rhp.val*rhp.kurs*case when rhp.dk='K' then 1 else 0 end as kredit, rhp.jurnal
from rhp
where rhp.sub between @suba and @subz and rhp.date>=@pdatea and  rhp.date<=@pdatez and (rhp.acc between @pacca and @paccz) and rhp.kurs>1
union all
select payhp.acc, payhp.sub, payhp.date, 'Pelunasan Nota No. '+payhp.reff as rem, 
	payhp.val*case when dk='D' then 1 else 0 end as debetus, 
	payhp.val*case when dk='K' then 1 else 0 end as kreditus, 
	payhp.val*(select top 1 kurs from rhp where rhp.jurnal=payhp.reff)*case when dk='D' then 1 else 0 end as debet, 
	payhp.val*(select top 1 kurs from rhp where rhp.jurnal=payhp.reff)*case when dk='K' then 1 else 0 end as kredit, payhp.jurnal
from payhp
where payhp.sub between @suba and @subz and payhp.date>=@pdatea and  payhp.date<=@pdatez and payhp.acc between @pacca and @paccz
and payhp.reff in (select jurnal from rhp where kurs>1)
) as mutasi

select #awal.*, sub.name as subname, acc.name as accname,sub.group_
from #awal
left outer join sub on #awal.sub=sub.sub 
left outer join acc on #awal.acc=acc.acc 
--where sub.group_=@group_
union all
select #mutasi.*, sub.name as subname, acc.name as accname,sub.group_
from #mutasi
left outer join sub on #mutasi.sub=sub.sub 
left outer join acc on #mutasi.acc=acc.acc 
--where sub.group_=@group_
order by 1,2,3









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO






CREATE   procedure sp_updatelhp @hpro varchar(15),@loc varchar(15),@pdatea datetime, @pdatez datetime
as 
/*
select * from lhp
select * from lhd
select * from hprod

select lhd.*,hprod.price from lhd left outer join lhp on lhd.lhp=lhp.lhp 
left outer join hprod on lhd.inv=hprod.inv 
where hprod.hpro='HPR-0703-000001' and (lhp.date between (01/03/2007) and '20070330') and lhp.loc='GPR2'
*/
select @pdatea=CONVERT(DATETIME,@pdatea,103)
select @pdatez=CONVERT(DATETIME,@pdatez,103)

update lhd set lhd.price=hprod.price from
lhd left outer join lhp on lhd.lhp=lhp.lhp 
left outer join hprod on lhd.inv=hprod.inv 
where hprod.hpro=@hpro  and lhp.loc=@loc and (lhp.date between @pdatea and @pdatez)









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

