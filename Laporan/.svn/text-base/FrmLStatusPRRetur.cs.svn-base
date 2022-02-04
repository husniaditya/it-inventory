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
    public partial class FrmLStatusPRRetur : CAS.Laporan.BaseLaporan
    {
        public FrmLStatusPRRetur()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                CollectData();
                this.ReportName = "RepStatusPRRetur";
                LoadReport();
                UpdateReport();
                PreviewReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmLStatusPRRetur_Load(object sender, EventArgs e)
        {
            dtpTglAwal.DateTime = dtpTglAkhir.DateTime = DB.loginDate;
            rgStatusPRRetur.SelectedIndex = 2; //all
        }

        private void CollectData()
        {
            string tglAwal = dtpTglAwal.DateTime.ToString("yyyyMMdd");
            string tglAkhir = dtpTglAkhir.DateTime.ToString("yyyyMMdd");
            string subAwal = DB.GetRangeValue(txtSubAwal, txtSubAkhir, 0);
            string subAkhir = DB.GetRangeValue(txtSubAwal, txtSubAkhir, 1);
            string invAwal = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 0);
            string invAkhir = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 1);
            dtResult = new DataTable();
            string query = "Call SP_LapStatusPRRetur(@tglawal,@tglakhir,'@subawal','@subakhir','@invawal','@invakhir',@statusPRRetur)";
            // replace params
            query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir);
            query = query.Replace("@subawal", subAwal).Replace("@subakhir", subAkhir);
            query = query.Replace("@invawal", invAwal).Replace("@invakhir", invAkhir);
            query = query.Replace("@statusPRRetur", rgStatusPRRetur.SelectedIndex.ToString());
            dtResult = DB.sql.Select(query);
        }

        private void UpdateReport()
        {
            string tanggal = "Tanggal: " + dtpTglAwal.DateTime.ToString("dd/MM/yyyy") + " - " + dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
            string supplier = "Supplier: " + txtSubAwal.Text + " - " + txtSubAkhir.Text;
            string persediaan = "Persediaan: " + txtInvAwal.Text + " - " + txtInvAkhir.Text;
            this.Report.Bands[BandKind.PageHeader].Controls["xrTanggal"].Text = tanggal;
            this.Report.Bands[BandKind.PageHeader].Controls["xrSupplier"].Text = supplier;
            this.Report.Bands[BandKind.PageHeader].Controls["xrPersediaan"].Text = persediaan;
            if (rgStatusPRRetur.SelectedIndex == 0)
                this.Report.Bands[BandKind.PageHeader].Controls["xrStatusPRRetur"].Text = "Status PR Retur: Open";
            else if (rgStatusPRRetur.SelectedIndex == 1)
                this.Report.Bands[BandKind.PageHeader].Controls["xrStatusPRRetur"].Text = "Status PR Retur: Close";
            else
                this.Report.Bands[BandKind.PageHeader].Controls["xrStatusPRRetur"].Text = "Status PR Retur: All";
        }
    }
}

