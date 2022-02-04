using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using KASLibrary;

namespace CAS.Laporan
{
    public partial class FrmLLPBRetur : BaseLaporan
    {
        public FrmLLPBRetur()
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
            string tglAwal = dtpTglAwal.DateTime.ToString("yyyyMMdd");
            string tglAkhir = dtpTglAkhir.DateTime.ToString("yyyyMMdd");
            string subAwal = DB.GetRangeValue(txtSubAwal, txtSubAkhir, 0);
            string subAkhir = DB.GetRangeValue(txtSubAwal, txtSubAkhir, 1);
            string invAwal = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 0);
            string invAkhir = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 1);
            string dsgAwal = DB.GetRangeValue(txtDsgAwal, txtDsgAkhir, 0);
            string dsgAkhir = DB.GetRangeValue(txtDsgAwal, txtDsgAkhir, 1);
            string sorAwal = DB.GetRangeValue(txtSOAwal, txtSOAkhir, 0);
            string sorAkhir = DB.GetRangeValue(txtSOAwal, txtSOAkhir, 1);
            string sprAwal = DB.GetRangeValue(txtSPBAwal, txtSPBAkhir, 0);
            string sprAkhir = DB.GetRangeValue(txtSPBAwal, txtSPBAkhir, 1);
            dtResult = new DataTable();
            string query = "Call SP_LapLPBRetur('@invawal','@invakhir',@tglawal, @tglakhir,'@subawal','@subakhir','@dsgawal','@dsgakhir','@sorawal','@sorakhir','@sprawal','@sprakhir')";
            // replace params
            query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir);
            query = query.Replace("@subawal", subAwal).Replace("@subakhir", subAkhir);
            query = query.Replace("@invawal", invAwal).Replace("@invakhir", invAkhir);
            query = query.Replace("@dsgawal", dsgAwal).Replace("@dsgakhir", dsgAkhir);
            query = query.Replace("@sorawal", sorAwal).Replace("@sorakhir", sorAkhir);
            query = query.Replace("@sprawal", sprAwal).Replace("@sprakhir", sprAkhir);
            //query = query.Replace("@period", DB.loginPeriod);
            dtResult = DB.sql.Select(query);
        }

        private void UpdateReport()
        {
            string periode1 = dtpTglAwal.DateTime.ToString("MMMM yyyy");
            string periode2 = dtpTglAkhir.DateTime.ToString("MMMM yyyy");
            string periode3 = periode1;
            if (periode1 != periode2) periode3 += " - " + periode2;
            this.Report.Bands[BandKind.ReportHeader].Controls["xrLabelPeriode"].Text = "Periode : " + periode3;
            this.Report.Bands[BandKind.ReportHeader].Controls["xrLabelTanggal"].Text = dtpTglAwal.DateTime.ToString("dd/MM/yyyy") + " - " + dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
            this.Report.Bands[BandKind.PageFooter].Controls["xrLabelUser"].Text = DB.casUser.Name;
        }

        private void FrmLLPBRetur_Load(object sender, EventArgs e)
        {
            dtpTglAwal.DateTime = Utility.FirstDateInMonth(DB.loginDate);
            dtpTglAkhir.DateTime = Utility.LastDateInMonth(DB.loginDate);
            this.ReportName = "RepLPBRetur";
        }
    }
}