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
    public partial class FrmLMskPerTanggal : CAS.Laporan.BaseLaporan
    {
        public FrmLMskPerTanggal()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
        }

        private void FrmLMskPerTanggal_Load(object sender, EventArgs e)
        {
            dtpTglAwal.DateTime = Utility.FirstDateInMonth(DateTime.Now.Date);
            dtpTglAkhir.DateTime = Utility.LastDateInMonth(DateTime.Now.Date);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                CollectData();
                 if (this.Tag.ToString() == "63161" )
                       this.ReportName = "RepMSK";
                 if (this.Tag.ToString() == "63165")
                       this.ReportName = "RepMSKLPB";

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
            dtResult = new DataTable();
            string query = "Call SP_MskOut(@tglawal,@tglakhir,'@subawal','@subakhir')";
            // replace params
            query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir);
            query = query.Replace("@subawal", subAwal).Replace("@subakhir", subAkhir);
            dtResult = DB.sql.Select(query);
        }

        private void UpdateReport()
        {
            string tanggal = "Periode: " + dtpTglAwal.DateTime.ToString("dd/MM/yyyy") + " - " + dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
            string supplier = "Supplier: " + txtSubAwal.Text + " - " + txtSubAkhir.Text;
            this.Report.Bands[BandKind.PageHeader].Controls["xrTanggal"].Text = tanggal;
            this.Report.Bands[BandKind.PageHeader].Controls["xrSupplier"].Text = supplier;
            this.Report.Bands[BandKind.PageFooter].Controls["xrLabelUser"].Text = DB.casUser.Name;
         
        }
    }
}