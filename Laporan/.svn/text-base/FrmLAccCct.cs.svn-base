using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KASLibrary;
using DevExpress.XtraReports.UI;


namespace CAS.Laporan
{
    public partial class FrmLAccCct : CAS.Laporan.BaseLaporan
    {
        public FrmLAccCct()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                CollectData();
                ProcessData();
                LoadReport();
                UpdateReport();
                PreviewReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CollectData()
        {
            string tglAwal = dtpTglAwal.DateTime.ToString("yyyyMMdd");
            string tglAkhir = dtpTglAkhir.DateTime.ToString("yyyyMMdd");
            string accAwal = DB.GetRangeValue(txtAccAwal, txtAccAkhir, 0);
            string accAkhir = DB.GetRangeValue(txtAccAwal, txtAccAkhir, 1);
            string cctawal = DB.GetRangeValue(ccta, cctz, 0);
            string cctakhir = DB.GetRangeValue(ccta, cctz, 1);
         
            dtResult = new DataTable();
            string query = "";
            query = "Call SP_Laccpercct(@tglawal,@tglakhir,'@accawal','@accakhir','@cctawal','@cctakhir')";
          
            // replace params
            query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir);
            query = query.Replace("@accawal", accAwal).Replace("@accakhir", accAkhir);
            query = query.Replace("@cctawal", cctawal).Replace("@cctakhir", cctakhir);
            dtResult = DB.sql.Select(query);
        }

        private void ProcessData()
        {
            // add column Saldo
            dtResult.Columns.Add("saldo", typeof(double));

            double saldo = 0;
            string acc = "";

            foreach (DataRow drResult in dtResult.Rows)
            {
                if (acc != drResult["acc"].ToString())
                    saldo = 0;

                // loop dtResult, fill in Saldo
                if (drResult["dk"].ToString() == "D")
                {
                    saldo += (double)drResult["debet"];
                    drResult["saldo"] = saldo;
                }
                else
                    if (drResult["dk"].ToString() == "K")
                    {
                        saldo -= (double)drResult["kredit"];
                        drResult["saldo"] = saldo;
                    }
                    else
                {
                    saldo += (double)drResult["debet"]-(double)drResult["kredit"];
                    drResult["saldo"] = saldo;
                    drResult["debet"]=0;
                    drResult["kredit"]=0;
                }
                acc = drResult["acc"].ToString();
            
            }
        }

        private void UpdateReport()
        {
            string tanggal = "Tanggal: " + dtpTglAwal.DateTime.ToString("dd/MM/yyyy") + " - " + dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
            this.Report.Bands[BandKind.ReportHeader].Controls["xrTanggal"].Text = tanggal;
            this.Report.Bands[BandKind.ReportHeader].Controls["xrLabel2"].Text = "Laporan Perkiraan Per Cost Center";
        }

        private void FrmLAccCct_Load(object sender, EventArgs e)
        {
            dtpTglAwal.DateTime = Utility.FirstDateInMonth(DateTime.Now.Date);
            dtpTglAkhir.DateTime = DateTime.Now.Date;

            this.ReportName = "RepLaccpercct";
            txtAccAwal.ExSqlQuery = "select acc as `Kode Akun`, name as `Keterangan` from acc where detil=0";
        }


    }
}
    


