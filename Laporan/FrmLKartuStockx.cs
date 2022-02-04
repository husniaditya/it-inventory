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
    public partial class FrmLKartuStock : BaseLaporan
    {
        public FrmLKartuStock()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
        }

        private void FrmLKartuStock_Load(object sender, EventArgs e)
        {
            dtpTglAwal.DateTime = Utility.FirstDateInMonth(DB.loginDate);
            dtpTglAkhir.DateTime = Utility.LastDateInMonth(DB.loginDate);
            if (this.Tag.ToString() == "6a11" || this.Tag.ToString() == "6a13")
                label3.Visible = txtLocAwal.Visible = txtLocAkhir.Visible = true;
            else
                label3.Visible = txtLocAwal.Visible = txtLocAkhir.Visible = false;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                CollectData();
                ProcessData();
                switch (this.Tag.ToString())
                {
                    case "6a11": // Tanpa Nilai
                        this.ReportName = "RepKartuStockQ"; break;
                    case "6a13": // Dengan Nilai
                        this.ReportName = "RepKartuStockV"; break;
                    case "6a31":
                        this.ReportName = "RepKartuStockGlobalQ"; break;
                    case "6a33":
                        this.ReportName = "RepKartuStockGlobalV"; break;
                    case "6a51" :
                        this.ReportName = "RepRekapPersediaan"; break;
                }

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
            string tglAkhir = dtpTglAkhir.DateTime.AddDays(1).ToString("yyyyMMdd");
            string jenisAwal = DB.GetRangeValue(txtJenisAwal, txtJenisAkhir, 0);
            string jenisAkhir = DB.GetRangeValue(txtJenisAwal, txtJenisAkhir, 1);
            string invAwal = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 0);
            string invAkhir = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 1);
            string locAwal = DB.GetRangeValue(txtLocAwal, txtLocAkhir, 0);
            string locAkhir = DB.GetRangeValue(txtLocAwal, txtLocAkhir, 1);
            string dsgAwal = DB.GetRangeValue(txtDsgAwal, txtDsgAkhir, 0);
            string dsgAkhir = DB.GetRangeValue(txtDsgAwal, txtDsgAkhir, 1);

            dtResult = new DataTable();
            string query;
            if (this.Tag.ToString() == "6a51")
              query = "Call SP_MutasiKartuStock(@tglawal,@tglakhir,'@jenisawal','@jenisakhir','@invawal','@invakhir','@locawal','@locakhir','@dsgawal','@dsgakhir')";
            else if (this.Tag.ToString() == "6a11" || this.Tag.ToString() == "6a13")
              query = "Call SP_KartuStock(@tglawal,@tglakhir,'@jenisawal','@jenisakhir','@invawal','@invakhir','@locawal','@locakhir','@dsgawal','@dsgakhir')";
            else
              query = "Call SP_KartuStockGlobal(@tglawal,@tglakhir,'@jenisawal','@jenisakhir','@invawal','@invakhir','@dsgawal','@dsgakhir')";
            // replace params
            query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir);
            query = query.Replace("@jenisawal", jenisAwal).Replace("@jenisakhir", jenisAkhir);
            query = query.Replace("@invawal", invAwal).Replace("@invakhir", invAkhir);
            query = query.Replace("@locawal", locAwal).Replace("@locakhir", locAkhir);
            query = query.Replace("@dsgawal", dsgAwal).Replace("@dsgakhir", dsgAkhir);            
            dtResult = DB.sql.Select(query);
        }

        private void ProcessData()
        {
            if (this.Tag.ToString() == "6a51")
                return;
            // add column Saldo
            dtResult.Columns.Add("qsaldo", typeof(double));
            dtResult.Columns.Add("vsaldo", typeof(double));
            dtResult.Columns.Add("price", typeof(double));
            dtResult.Columns.Add("priceD", typeof(double));
            dtResult.Columns.Add("priceK", typeof(double));

            double qsaldo = 0, vsaldo = 0, price = 0, priceD=0 , priceK = 0;
            string inv = "", loc = "", nodsg="" ;

            foreach (DataRow drResult in dtResult.Rows)
            {
                if (inv != drResult["inv"].ToString() || loc != drResult["loc"].ToString() || nodsg != drResult["nodsg"].ToString())
                    qsaldo = vsaldo = 0;

                //saldo awal
                if (drResult["dk"].ToString() == " ")
                {
                    qsaldo += (double)drResult["qdebet"] - (double)drResult["qkredit"];
                    drResult["qsaldo"] = qsaldo;
                    vsaldo += (double)drResult["vdebet"] - (double)drResult["vkredit"];
                    drResult["vsaldo"] = vsaldo;
                    drResult["price"] = vsaldo/qsaldo;
                }
                // loop dtResult, fill in Saldo
                else if (drResult["dk"].ToString() == "D" )
                {
                    qsaldo += (double)drResult["qdebet"];
                    drResult["qsaldo"] = qsaldo;
                    vsaldo += (double)drResult["vdebet"];
                    drResult["vsaldo"] = vsaldo;
                    drResult["priceD"] = (double)drResult["vdebet"] / (double)drResult["qdebet"];
                    drResult["price"] = vsaldo / qsaldo;
                    drResult["priceK"] = 0;

                }
                else
                {
                    qsaldo -= (double)drResult["qkredit"];
                    drResult["qsaldo"] = qsaldo;
                    vsaldo -= (double)drResult["vkredit"];
                    drResult["vsaldo"] = vsaldo;
                    drResult["priceK"] = (double)drResult["vkredit"] / (double)drResult["qkredit"]; ;
                    drResult["price"] = vsaldo / qsaldo;            
                    drResult["priceD"] = 0;
                }
                if (qsaldo == 0)
                {
                    drResult["vsaldo"] = 0;
                    drResult["price"] = 0;
                };
              
                inv = drResult["inv"].ToString();
                loc = drResult["loc"].ToString();
                nodsg = drResult["nodsg"].ToString();

            }
        }

        private void UpdateReport()
        {
            string tanggal = "";

            if (this.Tag.ToString() != "6a51")
            {
                tanggal = "Periode: " + dtpTglAwal.DateTime.ToString("dd/MM/yyyy") + " - " + dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
                this.Report.Bands[BandKind.ReportHeader].Controls["xrTanggal"].Text = tanggal;
            }
            else
            {
                tanggal = dtpTglAwal.DateTime.ToString("dd/MM/yyyy") + " - " + dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
                this.Report.Bands[BandKind.GroupHeader].Controls["xrLabelPeriode"].Text = tanggal;
            }
            this.Report.Bands[BandKind.PageFooter].Controls["xrLabelUser"].Text = DB.casUser.Name;
       
        }
    }
}