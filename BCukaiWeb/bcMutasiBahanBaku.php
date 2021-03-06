<?php
require("header.php");
require "Lib/tcpdf/PDF.php";

$txtInvA = "";
$txtInvZ = "";

if (isset($_POST["btnPreview"])) {
    $txtInvA = $_POST["txtInvA"];
    $txtInvZ = $_POST["txtInvZ"];
}

if ($koolajax->isCallback == false)
    unset($_SESSION["searchQuery"]);
?>

    <!-- Modal -->
    <!-- Persediaan A -->    
    <div class="modal fade" id="mdlInvA" tabindex="-1" role="dialog" aria-labelledby="mdlInvA" aria-hidden="true">
        <div class="modal-dialog" style="width:800px">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title" id="mdlInvA">Lookup Persediaan</h4>
                </div>
                <div class="modal-body">
                    <table id="lookupIA" class="table table-bordered table-hover table-striped">
                        <thead>
                            <tr>
                                <th>Kode</th>
                                <th>Persediaan</th>
                            </tr>
                        </thead>
                       <tbody>
                            <?php
                            $sql = mysql_query('SELECT inv AS Kode, name AS Persediaan FROM inv WHERE flag = 0 and left(inv,2) = 11 ;');
                            while ($r = mysql_fetch_array($sql)) {
                                ?>
                                <tr class="pilihIA" datainv="<?php echo $r['Kode']; ?>">
                                    <td><?php echo $r['Kode']; ?></td>
                                    <td><?php echo $r['Persediaan']; ?></td>
                                </tr>
                                <?php
                            }
                            ?>
                        </tbody>
                    </table>  
                </div>
            </div>
        </div>
    </div>

    <!-- Persediaan Z -->    
    <div class="modal fade" id="mdlInvZ" tabindex="-1" role="dialog" aria-labelledby="mdlInvZ" aria-hidden="true">
        <div class="modal-dialog" style="width:800px">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title" id="mdlInvZ">Lookup Persediaan</h4>
                </div>
                <div class="modal-body">
                    <table id="lookupIZ" class="table table-bordered table-hover table-striped">
                        <thead>
                            <tr>
                                <th>Kode</th>
                                <th>Persediaan</th>
                            </tr>
                        </thead>
                       <tbody>
                            <?php
                            $sql = mysql_query('SELECT inv AS Kode, name AS Persediaan FROM inv WHERE flag = 0 and left(inv,2) = 11;'); 
                            while ($r = mysql_fetch_array($sql)) {
                                ?>
                                <tr class="pilihIZ" datainv="<?php echo $r['Kode']; ?>">
                                    <td><?php echo $r['Kode']; ?></td>
                                    <td><?php echo $r['Persediaan']; ?></td>
                                </tr>
                                <?php
                            }
                            ?>
                        </tbody>
                    </table>  
                </div>
            </div>
        </div>
    </div>
     <!-- modal -->
     
<div id="page-wrapper">   
    <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header" style="font-size: 25px;">BC Mutasi Bahan Baku</h1>
        </div>
    </div>

    <!-- /.search -->  
    <div class="row">
        <form method="post">	
            <div class="form-group" style="position: relative; left:20px;">
                <div class="row">
                    <div class="col-sm-1">
                        <label for="varchar">Tanggal</label>
                    </div>
                    <div class="col-sm-2">
                        <?php echo(CreateDatePicker("tglAwal", "")); ?>                      
                    </div>
                    <div class="col-sm-2">
                        <?php echo(CreateDatePicker("tglAkhir", "")); ?>                       
                    </div>                    
                </div>                
                <br />
                <div class="row">
                    <div class="col-sm-1">
                        <label for="varchar">Persediaan</label>
                    </div>
                    <div class="col-sm-2">
                        <div class="input-group input-group-sm">
                            <input type="text" class="form-control" name="txtInvA" id="txtInvA" value="<?php echo $txtInvA;?>"/>
                            <span class="input-group-btn"><button type="button" class="btn btn-primary" data-toggle="modal" data-target="#mdlInvA"><i class="glyphicon glyphicon-search"></i></button></span>                        </span>
                        </div>
                    </div>
                    <div class="col-sm-2">
                        <div class="input-group input-group-sm">
                            <input type="text" class="form-control" name="txtInvZ" id="txtInvZ" value="<?php echo $txtInvZ;?>"/>
                            <span class="input-group-btn"><button type="button" class="btn btn-primary" data-toggle="modal" data-target="#mdlInvZ"><i class="glyphicon glyphicon-search"></i></button></span>
                        </div>
                    </div>                    
                </div>
                <br /><br />
                  <div class="row">       
                    <div class="col-sm-4 col-sm-offset-1">
                        <input id="btnPreview" name="btnPreview" type="submit" value="Preview" class="btn btn-primary">&nbsp;
                        <input id="btnCSV" name="btnCSV" type="submit" value="Export to Excel" class="btn btn-primary">&nbsp;
                        <input id="btnPDF" name="btnPDF" type="submit" value="Export to PDF" class="btn btn-primary">
                    </div> 
                </div>
            </div>
        </form>
    </div>
    <hr />
    <div class="panel-default">
        <?php
        
        if (isset($_POST["btnPreview"]) || isset($_POST["btnCSV"] ) || isset($_POST["btnPDF"] ) ) {
            $tglAwal = new DateTime($_POST["tglAwal"]);
            $period = $tglAwal->format("ym");
            $awal = $tglAwal->format("d/m/Y");
            $tglAwal = $tglAwal->format("Ymd");
            $tglAkhir = new DateTime($_POST["tglAkhir"]);
            $akhir = $tglAkhir->format("d/m/Y");
            $tglAkhir = $tglAkhir->format("Ymd");

            $query = "select @num := @num + 1 AS no, temp.* from ( ";
            $query .= "select invname,inv,date,jurnal,'' rem, format(sum(s_awal),2) s_awal, format(sum(qdebet),2) qdebet, format(sum(qkredit),2) qkredit, ";
            $query .= " format(sum(qadjust),2) qadjust, format(sum(qopn),2) selisih, max(unit) unit,  format(sum(s_awal) + sum(qdebet) - sum(qkredit) +  sum(qadjust),2) as sakhir, ";
            $query .= "   format(if(sum(qopn) <> 0 , sum(s_awal) + sum(qdebet) - sum(qkredit) +  sum(qadjust) + sum(qopn),0),2) as opname,'-' as ket from ";
            $query .= "( ";
            $query .= " select name as invname,inv,'' as loc, date(" . $tglAwal . ") as `date`, '' as jurnal, ";
            $query .= " convert('BALANCE' using latin1) as rem, sum(qlast) as s_awal,  0 as qdebet, 0 as qkredit, ";
            $query .= "       0 as qadjust, 0  as qopn, convert(' ' using latin1) as dk,unit,1 as urut,nodsg ";
            $query .= "  from  ( ";
            $query .= "     select rin.inv,inv.name, rin.qlast, rin.vlast,rin.nodsg,inv.unit2,inv.unit ";
            $query .= "       from rin left outer join inv on rin.inv=inv.inv ";
            $query .= "      where rin.period='" . $period . "' and (left(rin.inv,2)='11') ";
            $query .= "     union all ";
            $query .= "      select bcmasuk.inv,bcmasuk.remark, bcmasuk.qty as qlast , bcmasuk.val as vlast, ";
            $query .= "     '',inv.unit2,inv.unit ";
            $query .= "      from bcmasuk left outer join inv on bcmasuk.inv=inv.inv  ";
            $query .= "      where lpbdate < " . $tglAwal . " and month(lpbdate)=month(" . $tglAwal . ") and year(lpbdate)=year(" . $tglAwal . ")  and (left(bcmasuk.inv,2)='11') ";
            $query .= "  ) as oawal  ";
            if ($_POST["txtInvA"] == "") {
                if ($_POST["txtInvZ"] == "")
                    $query .= " where (inv BETWEEN '' and 'zzz') ";
                else
                    $query .= " where (inv BETWEEN '" . $_POST["txtInvZ"] . "' and '" . $_POST["txtInvZ"] . "') ";
            }
            else {
                if ($_POST["txtInvZ"] == "")
                    $query .= " where (inv BETWEEN '" . $_POST["txtInvA"] . "' and '" . $_POST["txtInvA"] . "') ";
                else
                    $query .= " where (inv BETWEEN '" . $_POST["txtInvA"] . "' and '" . $_POST["txtInvZ"] . "') ";
            }
            $query .= " group by inv";
            $query .= "  union all ";
            $query .= " select inv.name as invname, ind.inv, '' as loc, ";
            $query .= "       ind.date as date, ind.jurnal as jurnal, ifnull(ind.rem,'') as rem, 0 as s_awal, ";
            $query .= "       if (ind.dk='D' and ind.subjurnal in ('LHP') , ind.qty , 0) as qdebet, ";
            $query .= "       if (ind.dk='K' and ind.subjurnal not in ('OPN','JIN') , ind.qty , 0) as qkredit, ";
            $query .= "       if (ind.subjurnal='JIN' ,if(ind.dk='K', -ind.qty , ind.qty),0) as qadjust, ";
            $query .= "       if (ind.dk='D' and ind.subjurnal='OPN', ind.qty ,if (ind.dk='K' and ind.subjurnal='OPN',-ind.qty,0)) as qopn, ";
            $query .= "       ind.dk as dk, inv.unit, if (ind.subjurnal='OPN' , 2 , 1)  as urut,ind.nodsg ";
            $query .= "       from ind ";
            $query .= "       left outer join inv on ind.inv=inv.inv ";
            $query .= "       where (ind.date>=" . $tglAwal . " and ind.date<adddate(" . $tglAkhir . ",1)) ";
            if ($_POST["txtInvA"] == "") {
                if ($_POST["txtInvZ"] == "")
                    $query .= " AND (ind.inv BETWEEN '' and 'zzz') ";
                else
                    $query .= " AND (ind.inv BETWEEN '" . $_POST["txtInvZ"] . "' and '" . $_POST["txtInvZ"] . "') ";
            }
            else {
                if ($_POST["txtInvZ"] == "")
                    $query .= " AND (ind.inv BETWEEN '" . $_POST["txtInvA"] . "' and '" . $_POST["txtInvA"] . "') ";
                else
                    $query .= " AND (ind.inv BETWEEN '" . $_POST["txtInvA"] . "' and '" . $_POST["txtInvZ"] . "') ";
            }
           
            $query .= "  and (left(ind.inv,2) = '11') and left(ind.jurnal,3) in ('OPN','JIN','BPP','SJL','LHP') ";
            $query .= " union all ";
            $query .= " select bcmasuk.remark as invname,bcmasuk.inv,'' as loc, ";
            $query .= "       bcmasuk.lpbdate,bcmasuk.lpb,'' as rem,0 as s_awal, ";
            $query .= "      0 as qdebet,bcmasuk.qty as qkredit,0 as qadjust,0 as opn, ";
            $query .= "       'D' as dk,bcmasuk.unit,1 as urut,'' as nodsg ";
            $query .= "      from bcmasuk ";
            $query .= "      where bcmasuk.nodoc between '' and 'z' ";
              if ($_POST["txtInvA"] == "") {
                if ($_POST["txtInvZ"] == "")
                    $query .= " AND (bcmasuk.inv BETWEEN '' and 'zzz') ";
                else
                    $query .= " AND (bcmasuk.inv BETWEEN '" . $_POST["txtInvZ"] . "' and '" . $_POST["txtInvZ"] . "') ";
            }
            else {
                if ($_POST["txtInvZ"] == "")
                    $query .= " AND (bcmasuk.inv BETWEEN '" . $_POST["txtInvA"] . "' and '" . $_POST["txtInvA"] . "') ";
                else
                    $query .= " AND (bcmasuk.inv BETWEEN '" . $_POST["txtInvA"] . "' and '" . $_POST["txtInvZ"] . "') ";
            }
            $query .= "     and lpbdate >= " . $tglAwal . " and lpbdate < adddate(" . $tglAkhir . ",1) and left(bcmasuk.lpb,3)='LPJ' ";
            $query .= "     and (left(bcmasuk.inv,2) = '11') ";
            $query .= " union all ";
            $query .= " select bcmasuk.remark as invname,bcmasuk.inv,'' as loc, ";
            $query .= "       bcmasuk.lpbdate,bcmasuk.lpb,'' as rem,0 as s_awal, ";
            $query .= "       bcmasuk.qty as qdebet,0 as qkredit,0 as qadjust,0 as opn, ";
            $query .= "       'D' as dk,bcmasuk.unit,1 as urut,'' as nodsg ";
            $query .= "      from bcmasuk ";
            $query .= "      where bcmasuk.nodoc between '' and 'z' ";
              if ($_POST["txtInvA"] == "") {
                if ($_POST["txtInvZ"] == "")
                    $query .= " AND (bcmasuk.inv BETWEEN '' and 'zzz') ";
                else
                    $query .= " AND (bcmasuk.inv BETWEEN '" . $_POST["txtInvZ"] . "' and '" . $_POST["txtInvZ"] . "') ";
            }
            else {
                if ($_POST["txtInvZ"] == "")
                    $query .= " AND (bcmasuk.inv BETWEEN '" . $_POST["txtInvA"] . "' and '" . $_POST["txtInvA"] . "') ";
                else
                    $query .= " AND (bcmasuk.inv BETWEEN '" . $_POST["txtInvA"] . "' and '" . $_POST["txtInvZ"] . "') ";
            }
            $query .= "      and lpbdate >= " . $tglAwal . " and lpbdate < adddate(" . $tglAkhir . ",1) ";
              $query .= "     and (left(bcmasuk.inv,2) = '11') ";
            $query .= ") as x group by inv ";
            $query .= " order by  inv ) as temp left outer JOIN (SELECT @num :=0) AS n ON 1=1 ";
            
            $_SESSION["searchQuery"] = $query;
        } else {
            if (isset($_SESSION["searchQuery"])) {
                $query = $_SESSION["searchQuery"];
            }
        }

        if (isset($_POST["btnPreview"]) || isset($_SESSION["searchQuery"]) ) {
            
            echo '<p><strong>LAPORAN PERTANGGUNG JAWABAN MUTASI BAHAN BAKU</strong></p>';
            echo '<p>KAWASAN BERIKAT Wage Biro Technic</p>';
            echo '<p>LAPORAN PERTANGGUNG JAWABAN MUTASI BAHAN BAKU</p>';
            echo '<p>PERIODE : ' .$awal. ' - ' .$akhir. '</p>';
            
            $ds = new MySQLDataSource($db_con);
            $ds->SelectCommand = $query;

            $grid = new KoolGrid("grid");
            $grid->DataSource = $ds;
            $grid->AllowInserting = false;
            $grid->AllowEditing = false;
            $grid->AllowDeleting = false;
            $grid->MasterTable->ShowFunctionPanel = false;
            
            $column = new GridBoundColumn();
            $column->HeaderText = "NO";
            $column->DataField = "no";
            $column->Width = "20px";
            $column->Valign = "top";
            $grid->MasterTable->AddColumn($column);

            $column = new GridBoundColumn();
            $column->HeaderText = "KODE BARANG";
            $column->DataField = "inv";
            $column->AllowExporting = true;
            $column->Valign = "top";
            $column->Wrap = true;
            $grid->MasterTable->AddColumn($column);

            $column = new GridBoundColumn();
            $column->HeaderText = "NAMA BARANG";
            $column->DataField = "invname";
            $column->AllowExporting = true;
            $column->Valign = "top";
            $grid->MasterTable->AddColumn($column);

            $column = new GridBoundColumn();
            $column->HeaderText = "SAT";
            $column->DataField = "unit";
            $column->AllowExporting = true;
            $column->Valign = "top";
            $column->Width = "50px";
            $grid->MasterTable->AddColumn($column);

            $column = new gridnumbercolumn();
            $column->HeaderText = "SALDO AWAL";
            $column->DataField = "s_awal";
            $column->Valign = "top";
            $column->Align = "right";
            $column->Width = "80px";
            $column->Wrap = true;
            $column->DecimalNumber = "2";
            $column->DecimalPoint = ",";
            $column->ThousandSeperate = ".";
            $grid->MasterTable->AddColumn($column);

            $column = new gridnumbercolumn();
            $column->HeaderText = "PEMASUKAN";
            $column->DataField = "qdebet";
            $column->Valign = "top";
            $column->Align = "right";
            $column->Width = "80px";
            $column->DecimalNumber = "2";
            $column->DecimalPoint = ",";
            $column->ThousandSeperate = ".";
            $grid->MasterTable->AddColumn($column);

            $column = new gridnumbercolumn();
            $column->HeaderText = "PENGELUARAN";
            $column->DataField = "qkredit";
            $column->Valign = "top";
            $column->Width = "80px";
            $column->Align = "right";
            $column->DecimalNumber = "2";
            $column->DecimalPoint = ",";
            $column->ThousandSeperate = ".";
            $grid->MasterTable->AddColumn($column);

            $column = new gridnumbercolumn();
            $column->HeaderText = "ADJUSTMENT";
            $column->DataField = "qadjust";
            $column->Width = "50px";
            $column->Valign = "top";
            $column->Align = "right";
            $column->DecimalNumber = "2";
            $column->DecimalPoint = ",";
            $column->ThousandSeperate = ".";
            $grid->MasterTable->AddColumn($column);

            $column = new gridnumbercolumn();
            $column->HeaderText = "SALDO BUKU";
            $column->DataField = "sakhir";
            $column->Valign = "top";
            $column->Width = "100px";
            $column->Align = "right";
            $column->DecimalNumber = "2";
            $column->DecimalPoint = ",";
            $column->ThousandSeperate = ".";
            $grid->MasterTable->AddColumn($column);

            $column = new GridBoundColumn();
            $column->HeaderText = "STOCK OPNAME";
            $column->DataField = "opname";
            $column->Valign = "top";
            $column->Width = "50px";
            $column->Wrap = true;
            $grid->MasterTable->AddColumn($column);

            $column = new GridBoundColumn();
            $column->HeaderText = "SELISIH";
            $column->DataField = "selisih";
            $column->Valign = "top";
            $column->Width = "50px";
            $grid->MasterTable->AddColumn($column);

            $column = new GridBoundColumn();
            $column->HeaderText = "KET";
            $column->DataField = "ket";
            $column->Valign = "top";
            $column->Width = "50px";
            $grid->MasterTable->AddColumn($column);
                        
            echo ShowGrid($grid, false);
        }
                  
        if (isset($_POST["btnCSV"])) {     
            $fetch = mysql_query($query, $db_con) or
                    die(mysql_error());
            $num = Mysql_num_rows($fetch);
           
            if ($num > 0) {
                $html = "<table id='expTab' class='table table-striped table-bordered'>";
                $html .= "<tr><p><strong>LAPORAN PERTANGGUNG JAWABAN MUTASI BAHAN BAKU</strong></p>";
                $html .= "<p>KAWASAN BERIKAT Wage Biro Technic</p>";
                $html .= "<p>LAPORAN PERTANGGUNG JAWABAN MUTASI BAHAN BAKU</p>";
                $html .= "<p>PERIODE : " . $awal . " - " . $akhir . "</p></tr>";
                                          
                $html .= "<tr>"
                . "<th>NO</th><th>KODE BARANG</th><th>NAMA BARANG</th>"
                . "<th>SATUAN</th><th>SALDO AWAL</th><th>PEMASUKAN</th>"
                . "<th>PENGELUARAN</th><th>ADJUSTMENT</th><th>SALDO BUKU</th>"
                . "<th>STOCK OPNAME</th><th>SELISIH</th><th>KET</th>"
                . "</tr>";
                for ($i = 0; $i < $num; $i++) {
                    $row = mysql_fetch_row($fetch);
                    $html .= "<tr>";
                    $html .= "<td>$row[0]</td>";
                    $html .= "<td>$row[2]</td>";
                    $html .= "<td>$row[1]</td>";
                    $html .= "<td>$row[11]</td>";
                    $html .= "<td>$row[6]</td>";
                    $html .= "<td>$row[7]</td>";
                    $html .= "<td>$row[8]</td>";
                    $html .= "<td>$row[9]</td>";
                    $html .= "<td>$row[12]</td>";
                    $html .= "<td>$row[13]</td>";
                    $html .= "<td>$row[10]</td>";
                    $html .= "<td>$row[14]</td>";
                    $html .= "</tr>";
                }
                $html .= "</table>";
            }
                
            ob_clean();
            header("Content-type: application/vnd-ms-excel");
            header("Content-Disposition: attachment; filename=BC_Laporan_PertanggungJawaban_Mutasi_Bahan_Baku.xls");
            echo $html;            
        }
        
        if (isset($_POST["btnPDF"])) {
            ob_clean();
  
            require_once dirname(__FILE__) . '/Lib/tcpdf/tcpdf.php';
            require_once dirname(__FILE__) . '/Lib/tcpdf/config/lang/eng.php';

            $pdf = new PDF("L", PDF_UNIT, "A4", true, 'UTF-8', false); 
            $pdf->SetFont('times', '', 9, '', 'false');
            // add a page
            $pdf->AddPage();
            
            $header = '<br /><br /><h2><strong>LAPORAN PERTANGGUNG JAWABAN MUTASI BAHAN BAKU</strong></h2>';
            $header .= '<h3>KAWASAN BERIKAT Wage Biro Technic</h3>';
            $header .= '<h3>LAPORAN PERTANGGUNG JAWABAN MUTASI BAHAN BAKU</h3>';
            $header .= "<h3>PERIODE : " . $awal . " - " . $akhir . "</h3><br /><br /><br />";
                        
            $sql = mysql_query($query);
            $sData = array();
            $num = 0;
            while($row = mysql_fetch_assoc($sql)){
                $sData[$num]['no'] = $row['no'];
                $sData[$num]['inv'] = $row['inv'];
                $sData[$num]['invname'] = $row['invname'];
                $sData[$num]['unit'] = $row['unit'];
                $sData[$num]['s_awal'] = $row['s_awal'];
                $sData[$num]['qdebet'] = $row['qdebet'];
                $sData[$num]['qkredit'] = $row['qkredit'];
                $sData[$num]['qadjust'] = $row['qadjust'];
                $sData[$num]['sakhir'] = $row['sakhir'];
                $sData[$num]['opname'] = $row['opname'];
                $sData[$num]['selisih'] = $row['selisih'];
                $sData[$num]['ket'] = $row['ket'];
                $num++;
            }
            
            $tablehead = array('NO', 'KODE BARANG', 'NAMA BARANG', 'SAT',
                'SALDO AWAL', 'PEMASUKAN', 'PENGELUARAN', 'ADJUSTMENT',
                'SALDO BUKU', 'STOK OPNAME', 'SELISIH', 'KET');
            
            $pdf->writeHTML($header, true, false, true, false, '');
            
            $pdf->brgscrapTbl($tablehead, $sData);
       
            $pdf->Output('BC_Laporan_PertanggungJawaban_Mutasi_Bahan_Baku.pdf', 'D');     
        }
                
        ?>	      
    </div>

    <script src="js/jquery-1.11.2.min.js"></script>
    <script src="bootstrap/js/bootstrap.js"></script>
    <script src="datatables/jquery.dataTables.js"></script>
    <script src="datatables/dataTables.bootstrap.js"></script>

   
    <script type="text/javascript">
        $(document).on('click', '.pilihIA', function (e) {
            document.getElementById("txtInvA").value = $(this).attr('datainv');
            $('#mdlInvA').hide();
            $('body').removeClass('modal-open');
            $('.modal-backdrop').remove();
        });

        $(function () {
            $("#lookupIA").dataTable();
        });

        $(document).on('click', '.pilihIZ', function (e) {
            document.getElementById("txtInvZ").value = $(this).attr('datainv');
            $('#mdlInvZ').hide();
            $('body').removeClass('modal-open');
            $('.modal-backdrop').remove();
        });

        $(function () {
            $("#lookupIZ").dataTable();
        });
                            
    </script> 
</div>
<?php
require("footer.php");
?>