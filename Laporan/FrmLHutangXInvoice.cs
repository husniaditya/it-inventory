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
    public partial class FrmLHutangXInvoice : BaseLaporan
    {
        public FrmLHutangXInvoice()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
        }

        private void FrmLHutangXInvoice_Load(object sender, EventArgs e)
        {
            dtpTglAwal.DateTime = Utility.FirstDateInMonth(DB.loginDate);
            dtpTglAkhir.DateTime = Utility.LastDateInMonth(DB.loginDate);
            if (this.Tag.ToString() == "6j1")
            {
                this.ReportName = "RepLTTF";
                dtpTglAwal.DateTime = DB.loginDate;
                dtpTglAkhir.DateTime = DB.loginDate;
            }
            else
                this.ReportName = "RepLLPBXInvoice";
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
            string tglAwal = dtpTglAwal.DateTime.ToString("yyyyMMdd");
            string tglAkhir = dtpTglAkhir.DateTime.ToString("yyyyMMdd");
            string subAwal = DB.GetRangeValue(txtSubAwal, txtSubAkhir, 0);
            string subAkhir = DB.GetRangeValue(txtSubAwal, txtSubAkhir, 1);
            string query="";

            dtResult = new DataTable();
             if (this.Tag.ToString() == "6j1")
                 query = "Call sp_rekapttf('@subawal','@subakhir',@tglawal, @tglakhir)"; 
             else
               query = "Call SP_LapLPBXInvoice(@tglawal, @tglakhir,'@subawal','@subakhir')";
            
            // replace params
            query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir);
            query = query.Replace("@subawal", subAwal).Replace("@subakhir", subAkhir);
            //query = query.Replace("@period", DB.loginPeriod);
            dtResult = DB.sql.Select(query);
        }

        private void UpdateReport()
        {
            string periode1 = dtpTglAwal.DateTime.ToString("MMMM yyyy");
            string periode2 = dtpTglAkhir.DateTime.ToString("MMMM yyyy");
            string periode3 = periode1;
            if (periode1 != periode2) periode3 += " - " + periode2;
            if (this.Tag.ToString() == "6j1")
            {
                this.Report.Bands[BandKind.ReportHeader].Controls["xrLabelTanggal"].Text = dtpTglAwal.DateTime.ToString("dd/MM/yyyy") + " - " + dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
            }
            else
            {
                this.Report.Bands[BandKind.ReportHeader].Controls["xrLabelPeriode"].Text = "Periode : " + periode3;
                this.Report.Bands[BandKind.ReportHeader].Controls["xrLabelTanggal"].Text = dtpTglAwal.DateTime.ToString("dd/MM/yyyy") + " - " + dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
                this.Report.Bands[BandKind.PageFooter].Controls["xrLabelUser"].Text = DB.casUser.Name;
            }
        }
    }
}