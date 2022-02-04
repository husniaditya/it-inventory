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
    public partial class FrmLPiutangXInvoice : BaseLaporan
    {
        public FrmLPiutangXInvoice()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                CollectData();
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
           // string tglAwal = dtpTglAwal.DateTime.ToString("yyyyMMdd");
            string tglAkhir = dtpTglAkhir.DateTime.ToString("yyyyMMdd");
            string subAwal = DB.GetRangeValue(txtSubAwal, txtSubAkhir, 0);
            string subAkhir = DB.GetRangeValue(txtSubAwal, txtSubAkhir, 1);
            dtResult = new DataTable();
            string query = "Call SP_LapSJHXInvoice(@tglawal, @tglakhir,'@subawal','@subakhir')";
            // replace params
            query = query.Replace("@tglawal", "20100101").Replace("@tglakhir", tglAkhir);
            query = query.Replace("@subawal", subAwal).Replace("@subakhir", subAkhir);
            //query = query.Replace("@period", DB.loginPeriod);
            dtResult = DB.sql.Select(query);
        }

        private void UpdateReport()
        {
          //  string periode1 = dtpTglAwal.DateTime.ToString("MMMM yyyy");
            string periode2 = dtpTglAkhir.DateTime.ToString("MMMM yyyy");
        //    string periode3 = periode1;
         //   if (periode1 != periode2) periode3 += " - " + periode2;
         //   this.Report.Bands[BandKind.ReportHeader].Controls["xrLabelPeriode"].Text = "Periode : " + periode3;
            this.Report.Bands[BandKind.ReportHeader].Controls["xrLabelTanggal"].Text =  dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
            this.Report.Bands[BandKind.PageFooter].Controls["xrLabelUser"].Text = DB.casUser.Name;
        }

        private void FrmLPiutangXInvoice_Load(object sender, EventArgs e)
        {
        //    dtpTglAwal.DateTime = Utility.FirstDateInMonth(DB.loginDate);
            dtpTglAkhir.DateTime = Utility.LastDateInMonth(DB.loginDate);
            this.ReportName = "RepLSJHXInvoice";
        }
    }
}