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
    public partial class FrmLLabaKotor : BaseLaporan
    {
        public FrmLLabaKotor()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
        }

        private void FrmLLabaKotor_Load(object sender, EventArgs e)
        {
            this.ReportName = "RepLabaKotor";
            dtpTglAwal.DateTime = Utility.FirstDateInMonth(DateTime.Now.Date);
            dtpTglAkhir.DateTime = DateTime.Now.Date;
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
            dtResult = new DataTable();
            string query = "";
            query = "Call SP_invlaba4('" + txtInvAwal.Text + "','" + txtInvAkhir.Text + "','" + txtSubAwal.Text + "','" + txtSubAkhir.Text + "'," + dtpTglAwal.DateTime.ToString("yyyyMMdd") + "," + dtpTglAkhir.DateTime.ToString("yyyyMMdd") + ")";
            dtResult = DB.sql.Select(query);
        }

        private void UpdateReport()
        {  
            string periode1 = dtpTglAwal.DateTime.ToString("MMMM yyyy");
            string periode2 = dtpTglAkhir.DateTime.ToString("MMMM yyyy");
            string periode3 = periode1;
            if (periode1 != periode2) periode3 += " - " + periode2;
            this.Report.Bands[BandKind.ReportHeader].Controls["xrLabelPeriode"].Text = "Periode : "+periode3;
            this.Report.Bands[BandKind.ReportHeader].Controls["xrLabelTanggal"].Text = dtpTglAwal.DateTime.ToString("dd/MM/yyyy") + " - " + dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
            this.Report.Bands[BandKind.PageFooter].Controls["xrLabelUser"].Text = DB.casUser.User;
        }
    }
}