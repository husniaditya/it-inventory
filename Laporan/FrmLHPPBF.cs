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
    public partial class FrmLHPPBF : BaseLaporan
    {
        string noacc = "";
        string query = "";

        public FrmLHPPBF()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);

        }

        private void FrmLHPPBF_Load(object sender, EventArgs e)
        {
            dtpTglAwal.DateTime = Utility.FirstDateInMonth(DateTime.Now.Date);
            dtpTglAkhir.DateTime = DateTime.Now.Date;

            this.ReportName = "LapHPPBF";
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
                MessageBox.Show(ex.Message + noacc);
            }

        }

        private void CollectData()
        {
            string tglAwal = dtpTglAwal.DateTime.ToString("yyyyMMdd");
            string tglAkhir = dtpTglAkhir.DateTime.ToString("yyyyMMdd");
          
            dtResult = new DataTable();

            query = "Call SP_LapHppBF(@tglawal,@tglakhir)";

            // replace params
            query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir);
            dtResult = DB.sql.Select(query);
        }

        private void ProcessData()
        {
        }

        private void UpdateReport()
        {
            string tanggal = "Tanggal: " + dtpTglAwal.DateTime.ToString("dd/MM/yyyy") + " - " + dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
            this.Report.Bands[BandKind.ReportHeader].Controls["xrLabel1"].Text = tanggal;
            /*if (this.Tag.ToString() == "6541")
                this.Report.Bands[BandKind.ReportHeader].Controls["xrLabel2"].Text = "Buku Besar Global";
            else
                this.Report.Bands[BandKind.ReportHeader].Controls["xrLabel2"].Text = "Buku Besar Pembantu Detil";*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CollectData();
            GridReport frmDoc = new GridReport(query);
            frmDoc.ShowDialog();
        }
    }
}