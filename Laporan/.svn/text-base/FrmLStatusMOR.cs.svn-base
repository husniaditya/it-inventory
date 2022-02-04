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
    public partial class FrmLStatusMOR : CAS.Laporan.BaseLaporan
    {
        public FrmLStatusMOR()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
        }

        private void FrmLStatusMOR_Load(object sender, EventArgs e)
        {
            dtpTglAwal.DateTime = Utility.FirstDateInMonth(DB.loginDate);
            dtpTglAkhir.DateTime = Utility.LastDateInMonth(DB.loginDate);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                CollectData();
                this.ReportName = "RepStatusMOR";
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
            string oklAwal = DB.GetRangeValue(txtOklAwal, txtOklAkhir, 0);
            string oklAkhir = DB.GetRangeValue(txtOklAwal, txtOklAkhir, 1);
            string morAwal = DB.GetRangeValue(txtMOAwal, txtMOAkhir, 0);
            string morAkhir = DB.GetRangeValue(txtMOAwal, txtMOAkhir, 1);
            string lhpAwal = DB.GetRangeValue(txtLHPAwal, txtLHPAkhir, 0);
            string lhpAkhir = DB.GetRangeValue(txtLHPAwal, txtLHPAkhir, 1);
            dtResult = new DataTable();
            string query = "Call SP_LapStatusMOR(@tglawal,@tglakhir,'@subawal','@subakhir','@invawal','@invakhir','@oklawal','@oklakhir','@morawal','@morakhir','@lhpawal','@lhpakhir')";
            // replace params
            query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir);
            query = query.Replace("@subawal", subAwal).Replace("@subakhir", subAkhir);
            query = query.Replace("@invawal", invAwal).Replace("@invakhir", invAkhir);
            query = query.Replace("@oklawal", oklAwal).Replace("@oklakhir", oklAkhir);
            query = query.Replace("@morawal", morAwal).Replace("@morakhir", morAkhir);
            query = query.Replace("@lhpawal", lhpAwal).Replace("@lhpakhir", lhpAkhir);
            dtResult = DB.sql.Select(query);
        }

        private void UpdateReport()
        {
            string tanggal = "Tanggal: " + dtpTglAwal.DateTime.ToString("dd/MM/yyyy") + " - " + dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
            string supplier = "Customer: " + txtSubAwal.Text + " - " + txtSubAkhir.Text;
            string persediaan = "Persediaan: " + txtInvAwal.Text + " - " + txtInvAkhir.Text;
            this.Report.Bands[BandKind.PageHeader].Controls["xrTanggal"].Text = tanggal;
            this.Report.Bands[BandKind.PageHeader].Controls["xrSupplier"].Text = supplier;
            this.Report.Bands[BandKind.PageHeader].Controls["xrPersediaan"].Text = persediaan;
            this.Report.Bands[BandKind.PageFooter].Controls["xrLabelUser"].Text = DB.casUser.Name;
        }
    }
}