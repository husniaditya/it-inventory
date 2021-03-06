using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KASLibrary;
using DevExpress.XtraReports.UI;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
using System.Threading;

namespace CAS.Proses
{
    public partial class FrmPReproses : XtraForm
    {
        public Thread thread = null;
        public FrmPReproses()
        {
            InitializeComponent();
            System.Windows.Forms.Form.CheckForIllegalCrossThreadCalls= false;
            try { Utility.ApplySkin(this); }
            catch { }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnProses_Click(object sender, EventArgs e)
        {
            if (chkProsesUlang.Checked == true)
            {
                lbwait.Visible = true;
                thread = new Thread(prosses);
                thread.Priority = ThreadPriority.Highest;
                thread.Start();
            }
            else
                prosses();
        }

        private void prosses()
        {

          string cmd = "select * from _close where period='"+DB.loginPeriod+"'";
          DataTable CPeriod = DB.sql.Select(cmd);
          if (CPeriod.Rows.Count > 0)
          {
              MessageBox.Show("Periode Sudah diTutup");
          }
          else
          {
              if (chkProsesUlang.Checked == true)
              {
                  DB.sql.BeginTransaction();
                  try
                  {
                      if (chkProsesUlang.Checked == true)
                      {
                    //      lbwait.Visible = true;
                          string period = DB.loginPeriod;
                          //DB.sql.Execute("Call SP_reproses('" + period + "')");
                          //lbwait.Visible = false;
                          //DB.sql.CommitTransaction();
                          string query = "";
                          if (checkstock.Checked == true)
                          {
                             query = "Call SP_reprosesinv('" + period + "')";
                          }
                          else
                             query = "Call SP_reproses('" + period + "')";

                          DataTable dtrep = DB.sql.Select(query);
                   
                          for (int i = 0; i < dtrep.Rows.Count; i++)
                          {
                              int procent = i * 100 / dtrep.Rows.Count;
                              string prosses = dtrep.Rows[i]["jurnal"].ToString();
                              progress(procent, prosses);
                              if (checkstock.Checked == true)
                              {
                                  DB.sql.Execute("call sp_save2 (" + Convert.ToDateTime(dtrep.Rows[i]["date"].ToString()).ToString("yyyyMMdd") + ",'" + dtrep.Rows[i]["subjurnal"] + "','" + dtrep.Rows[i]["jurnal"] + "')");
                              }
                              if (checkrhp.Checked == true)
                              {
                                  DB.sql.Execute("call sp_save3 (" + Convert.ToDateTime(dtrep.Rows[i]["date"].ToString()).ToString("yyyyMMdd") + ",'" + dtrep.Rows[i]["subjurnal"] + "','" + dtrep.Rows[i]["jurnal"] + "')");
                              }
                              if (checkrhp.Checked == false && checkstock.Checked == false)
                              {
                                  DB.sql.Execute("call sp_save1 (" + Convert.ToDateTime(dtrep.Rows[i]["date"].ToString()).ToString("yyyyMMdd") + ",'" + dtrep.Rows[i]["subjurnal"] + "','" + dtrep.Rows[i]["jurnal"] + "')");
                              }
                                   //  int procent = i * 100 / dtrep.Rows.Count;

                           //   progress(procent, prosses);
       
                          }
                          DB.sql.Execute("call Sp_SaveRac1 ('"+ period +"')");
                         
                          //Proses deleted ItemActivation acd
                          DataTable dtdel = DB.sql.Select("select distinct jurnal from acd where adj=1 and period='" + period + "'");
                          for (int j = 0; j < dtdel.Rows.Count; j++)
                          {
                              DB.sql.Execute("call Sp_SaveRac ('1','" + dtrep.Rows[j]["jurnal"] + "')");
                          }

                          DB.sql.CommitTransaction();
                          MessageBox.Show("Proses Ulang Telah Selesai ");
                          lbwait.Visible = false;
                 
                      }
                  }
                  catch (Exception ex)
                  {
                      DB.sql.RollbackTransaction();
                      lbwait.Visible = false;
                      MessageBox.Show(ex.Message, "GAGAL REPROSES");
                  }
              }

              if (chkTutupBulan.Checked == true)
              {
                  string period = DB.loginPeriod;
                  DateTime dtptglawal = Utility.FirstDateInMonth(DB.loginDate);
                  DateTime dtptglakhir = Utility.LastDateInMonth(DB.loginDate);
                  string tglawal = dtptglawal.ToString("yyyyMMdd");
                  string tglakhir = dtptglakhir.ToString("yyyyMMdd");
                  lbwait.Visible = true;
                  DB.sql.Execute("Call SP_closeofmonth(" + tglawal + "," + tglakhir + ")");
                  // buka jika ingin laba bulanan jika ditutup laba tahunan
                  DB.sql.Execute("Call Sp_PindahSaldoRL(" + tglawal + "," + tglakhir + ")");
                  DB.sql.Execute("Call SP_KasBUS(" + tglawal + "," + tglakhir + ",'','z','1')");
                  MessageBox.Show("Pindah Saldo Telah Selesai ");

              }

              if (chkCekError.Checked == true)
              {
                  string query = "";
                  query = "Call SP_Dataerror('" + DB.loginPeriod + "')";
                  string path = Application.StartupPath + "\\Reports\\RepLDataError.repx";
                  XtraReport report = new XtraReport();
                  report.LoadState(path);
                  report.DataSource = DB.sql.Select(query);
                  report.ShowPreview();
              }

              if (chkPenyusutan.Checked == true)
              {
                  MySqlDataAdapter penyusutan;
                  penyusutan = DB.sql.SelectAdapter("select * from jid");
                  DataTable source;
                  DataTable peny_awal;
                  DataTable akumulasi;
                  akumulasi = DB.sql.Select("select * from jin where left(jin,3)='.FA' and period='" + DB.loginPeriod + "'");
                  if (akumulasi.Rows.Count > 0)
                  {
                      for (int i = 0; i < akumulasi.Rows.Count; i++)
                      {
                          DB.sql.Execute("delete from jid where jin='" + akumulasi.Rows[i]["jin"].ToString() + "'");
                          DB.sql.Execute("delete from jin where jin='" + akumulasi.Rows[i]["jin"].ToString() + "'");
                          //DB.sql.Execute("update jin set `delete`=true where jin='" + akumulasi.Rows[i]["jin"].ToString() + "'");
                      }
                  }
                  string NoDocument = ".FA-" + DB.loginPeriod + "-" + DB.GetNewKeyCode("JIN", ".FA");
                  bool ada = false;
                  source = DB.sql.Select("select * from akt where akt.tglbeli< " + DB.loginDate.AddDays(1).ToString("yyyyMMdd") + " and akt.tglstop >=" + DB.loginDate.AddDays(1).ToString("yyyyMMdd") + " and (akt.tgljual>" + DB.loginDate.AddDays(1).ToString("yyyyMMdd") + " or tgljual=tglbeli)");
                  int nomor = 1;
                  for (int i = 0; i < source.Rows.Count; i++)
                  {
                      akumulasi = DB.sql.Select("select ifnull(sum(jid.val),0) as akumulasi from jid,jin where jin.date < " + DB.loginDate.AddDays(1).ToString("yyyyMMdd") + " and jin.delete=false and jid.jin=jin.jin and jin.group_=5 and jid.inv='" + (string)source.Rows[i]["akt"] + "'");
                      peny_awal = DB.sql.Select("select ifnull(sum(if(dk='K',jid.val,-jid.val)),0) as akumulasi from jid,jin where jin.date < " + DB.loginDate.AddDays(1).ToString("yyyyMMdd") + " and jin.delete=false and jid.jin=jin.jin and jin.group_=4 and jid.inv='" + (string)source.Rows[i]["akt"] + "'");
                      if (akumulasi.Rows.Count > 0 && Convert.ToDouble(peny_awal.Rows[0]["akumulasi"].ToString()) + Convert.ToDouble(akumulasi.Rows[0]["akumulasi"].ToString()) < Convert.ToDouble(source.Rows[i]["harga"].ToString()))
                      {

                          ada = true;
                          DataRow row = casDataSet.jid.NewRow();
                          row["jin"] = NoDocument;
                          row["inv"] = source.Rows[i]["akt"].ToString();
                          row["remark"] = source.Rows[i]["name"].ToString();
                          row["dk"] = "D";
                          row["no"] = nomor;
                          row["spesifikasi"] = "";
                          row["nodsg"] = "";

                          nomor += 1;
                          double susut = Convert.ToDouble(source.Rows[i]["harga"].ToString()) * Convert.ToDouble(source.Rows[i]["prosentase"].ToString()) / 100 / 12;
                          if (susut > Convert.ToDouble(source.Rows[i]["harga"].ToString()) - Convert.ToDouble(akumulasi.Rows[0]["akumulasi"].ToString()) - Convert.ToDouble(peny_awal.Rows[0]["akumulasi"].ToString()))
                              row["val"] = Convert.ToDouble(source.Rows[i]["harga"].ToString()) - Convert.ToDouble(akumulasi.Rows[0]["akumulasi"].ToString()) - Convert.ToDouble(peny_awal.Rows[0]["akumulasi"].ToString());
                          else
                              row["val"] = susut;
                          casDataSet.jid.Rows.Add(row);
                      }
                  }
                  if (ada)
                  {
                      penyusutan.Update(casDataSet.jid);
                      penyusutan = DB.sql.SelectAdapter("select * from jin");
                      DataRow row = casDataSet.jin.NewRow();
                      row["jin"] = NoDocument;
                      row["date"] = DB.loginDate.Add(DateTime.Now.TimeOfDay);
                      row["chtime"] = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                      row["chusr"] = DB.casUser.User;
                      row["remark"] = "PENYUSUTAN";
                      row["period"] = DB.loginPeriod;
                      row["group_"] = 5;
                      row["plant"] = "";
                      casDataSet.jin.Rows.Add(row);
                      penyusutan.Update(casDataSet.jin);
                      MessageBox.Show("Penghitungan Penyusutan Sukses");
                      DB.sql.Execute("Call SP_Save(" + DateTime.Now.ToString("dd/MM/yyyy") + ",'AKT'" + ",'" + row["jin"] + "')");
                  }
                  else
                  {
                      MessageBox.Show("Proses Selesai, tidak ada penyusutan");
                  }
              }

              if (chkReclass.Checked == true)
              {
                  /*
                  DataTable source1;
                  MySqlDataAdapter detil;
                  detil = DB.sql.SelectAdapter("select * from umd");
                  string NoDocument = "UMH-" + DB.loginPeriod + "-" + DB.GetNewKeyCode("umh", "UMH");
                  string querinya = " select '" + NoDocument + "' as umh,'' as jurnal, acc,(select name from acc where acc.acc=acd.acc) as remark,'' as cct,1 as nomer,";
                  querinya = querinya + "if(sum(val*if(dk='D',1,-1))<0 ,'D','K') as dk,abs(sum(val*if(dk='D',1,-1)))as val from acd where acc like '52%' and period='" + DB.loginPeriod + "' group by acc union all ";
                  querinya = querinya + " select '" + NoDocument + "' as umh,'' as jurnal,convert('11050101' using latin1),(select name from acc where acc.acc='11050101') as remark,'' as cct,1 as nomer,";
                  querinya = querinya + " if(sum(val*if(dk='D',1,-1))<0 ,'K','D') as dk,abs(sum(val*if(dk='D',1,-1)))as val from acd where acc like '52%' and period='" + DB.loginPeriod + "'";

                  source1 = DB.sql.Select(querinya);
                  int nomor1 = 1;
                  for (int i = 0; i < source1.Rows.Count; i++)
                  {
                      DataRow row = casDataSet.umd.NewRow();
                      row["umh"] = NoDocument;
                      row["acc"] = source1.Rows[i]["acc"].ToString();
                      row["remark"] = source1.Rows[i]["remark"].ToString();
                      row["dk"] = source1.Rows[i]["dk"].ToString();
                      row["val"] = source1.Rows[i]["val"].ToString();
                      row["no"] = nomor1;
                      nomor1 += 1;
                      casDataSet.umd.Rows.Add(row);
                  }
                  detil.Update(casDataSet.umd);
                  MySqlDataAdapter header;
                  header = DB.sql.SelectAdapter("select * from umh");
                  DataRow row1 = casDataSet.umh.NewRow();
                  row1["umh"] = NoDocument;
                  row1["cur"] = "IDR";
                  row1["kurs"] = 1;
                  row1["date"] = DB.loginDate.Add(DateTime.Now.TimeOfDay);
                  row1["chtime"] = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                  row1["chusr"] = DB.casUser.User;
                  row1["remark"] = "Reclas HPPR ke Persediaan Brg Jadi";
                  row1["period"] = DB.loginPeriod;
                  casDataSet.umh.Rows.Add(row1);
                  header.Update(casDataSet.umh);
                 */ 
                  DB.sql.Execute("CALL SP_JournalEntries('"+ DB.loginPeriod +"','3')");
                  MessageBox.Show("Reclas Sukses");
                 
              }
          }
        }

        private void progress(int val,string prosses)
        {
            toolStripProgressBar1.Value = val;
            toolStripStatusLabel1.Text = Convert.ToString(val+1)+'%';
            toolStripStatusLabel2.Text= "Last prossesing " +prosses ;
        }

        private void lbwait_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FrmPReproses_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'casDataSet.jid' table. You can move, or remove it, as needed.
          //  this.jidTableAdapter.Fill(this.casDataSet.jid);

        }

    }
}