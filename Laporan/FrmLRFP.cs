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
    public partial class FrmLRFP : BaseLaporan
    {
        public FrmLRFP()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
        }

        private void FrmLRFP_Load(object sender, EventArgs e)
        {
            dtpTglAwal.DateTime = Utility.FirstDateInMonth(DB.loginDate);
            dtpTglAkhir.DateTime = Utility.LastDateInMonth(DB.loginDate);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                CollectData();
                ProcessData();
                
                this.ReportName = "RepLRFP";

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
            string query = "";
            string tglAwal = dtpTglAwal.DateTime.ToString("yyyyMMdd");
            string tglAkhir = dtpTglAkhir.DateTime.AddDays(1).ToString("yyyyMMdd");
            //string subAwal = (txtSubAwal.EditValue == null ? "" : txtSubAwal.EditValue.ToString());
            //string subAkhir = (txtSubAkhir.EditValue == null ? "" : txtSubAkhir.EditValue.ToString());
            string subAwal = DB.GetRangeValue(txtSubAwal, txtSubAkhir, 0);
            string subAkhir = DB.GetRangeValue(txtSubAwal, txtSubAkhir, 1);

            DataTable dtResult1 = new DataTable();
            dtResult = new DataTable();
            
            if (radioGroup1.EditValue.ToString() == "0")
                query = "Call SP_PRINTRFP(@tglawal,@tglakhir,'@subAwal','@subAkhir','all')";
            else if (radioGroup1.EditValue.ToString() == "1")
                query = "Call SP_PRINTRFP(@tglawal,@tglakhir,'@subAwal','@subAkhir','terbuka')";
            else
                query = "Call SP_PRINTRFP(@tglawal,@tglakhir,'@subAwal','@subAkhir','tertutup')";
            // replace params
            query = query.Replace("@subAwal", subAwal).Replace("@subAkhir", subAkhir);
            query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir);
           
            dtResult = DB.sql.Select(query);
        }

        private void ProcessData()
        {
            //if (this.Tag.ToString() == "6a51" || this.Tag.ToString() == "6a52" || this.Tag.ToString() == "6a54" || this.Tag.ToString() == "6da")
            //    return;

            //// add column Saldo
            //dtResult.Columns.Add("qsaldo", typeof(double));
            //dtResult.Columns.Add("vsaldo", typeof(double));
            //dtResult.Columns.Add("price", typeof(double));
            //dtResult.Columns.Add("priceD", typeof(double));
            //dtResult.Columns.Add("priceK", typeof(double));

            //double qsaldo = 0.0000000, vsaldo = 0.0000000, price = 0.0000000, priceD = 0.0000000, priceK = 0.0000000;
            //string inv = "", loc = "", nodsg = "";

            //foreach (DataRow drResult in dtResult.Rows)
            //{
            //    if (inv != drResult["inv"].ToString() || loc != drResult["loc"].ToString() || nodsg != drResult["nodsg"].ToString())
            //        qsaldo = vsaldo = 0.0000000;

            //    //saldo awal
            //    if (drResult["dk"].ToString() == " ")
            //    {
            //        qsaldo += (double)drResult["qdebet"] - (double)drResult["qkredit"];
            //        drResult["qsaldo"] = qsaldo;
            //        vsaldo += (double)drResult["vdebet"] - (double)drResult["vkredit"];
            //        drResult["vsaldo"] = vsaldo;
            //        drResult["price"] = vsaldo / qsaldo;
            //    }
            //    // loop dtResult, fill in Saldo
            //    else if (drResult["dk"].ToString() == "D")
            //    {
            //        qsaldo += (double)drResult["qdebet"];
            //        drResult["qsaldo"] = qsaldo;
            //        vsaldo += (double)drResult["vdebet"];
            //        drResult["vsaldo"] = vsaldo;
            //        drResult["priceD"] = (double)drResult["vdebet"] / (double)drResult["qdebet"];
            //        drResult["price"] = vsaldo / qsaldo;
            //        drResult["priceK"] = 0.0000000;

            //    }
            //    else
            //    {
            //        qsaldo -= (double)drResult["qkredit"];
            //        drResult["qsaldo"] = qsaldo;
            //        vsaldo -= (double)drResult["vkredit"];
            //        drResult["vsaldo"] = vsaldo;
            //        drResult["priceK"] = (double)drResult["vkredit"] / (double)drResult["qkredit"]; ;
            //        drResult["price"] = vsaldo / qsaldo;
            //        drResult["priceD"] = 0.0000000;
            //    }
            //    if (Math.Round(qsaldo, 2) == 0)
            //    {
            //        //drResult["vsaldo"] = 0;
            //        drResult["price"] = 0.0000000;
            //    };

            //    inv = drResult["inv"].ToString();
            //    loc = drResult["loc"].ToString();
            //    nodsg = drResult["nodsg"].ToString();

            //}
        }

        private void UpdateReport()
        {
            string tanggal = "";
            tanggal = "Periode: " + dtpTglAwal.DateTime.ToString("dd/MM/yyyy") + " - " + dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
            this.Report.Bands[BandKind.ReportHeader].Controls["xrTanggal"].Text = tanggal;
            this.Report.Bands[BandKind.PageFooter].Controls["xrLabelUser"].Text = DB.casUser.Name;

            //string tanggal = "Periode: " + dtpTglAwal.DateTime.ToString("dd/MM/yyyy") + " - " + dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
            //this.Report.Bands[BandKind.ReportHeader].Controls["xrTanggal"].Text = tanggal;
            //this.Report.Bands[BandKind.PageFooter].Controls["xrLabelUser"].Text = DB.casUser.Name;
       
        }
    }
}