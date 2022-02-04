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
    public partial class FrmLListMO : CAS.Laporan.BaseLaporan
    {
        public FrmLListMO()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                CollectData();
                this.ReportName = "RepListMO";
                LoadReport();
                UpdateReport();
                PreviewReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmLListMO_Load(object sender, EventArgs e)
        {
            dtpTglAwal.DateTime = Utility.FirstDateInMonth(DB.loginDate);
            dtpTglAkhir.DateTime = Utility.LastDateInMonth(DB.loginDate);
        }

        private void CollectData()
        {
            string tglAwal = dtpTglAwal.DateTime.ToString("yyyyMMdd");
            string tglAkhir = dtpTglAkhir.DateTime.ToString("yyyyMMdd");
            string moAwal = DB.GetRangeValue(txtMOAwal, txtMOAkhir, 0);
            string moAkhir = DB.GetRangeValue(txtMOAwal, txtMOAkhir, 1);
            string dsgAwal = DB.GetRangeValue(txtDsgAwal, txtDsgAkhir, 0);
            string dsgAkhir = DB.GetRangeValue(txtDsgAwal, txtDsgAkhir, 1);
            dtResult = new DataTable();
            string query = "Call SP_LapListMO(@tglawal,@tglakhir,'@moawal','@moakhir','@dsgawal','@dsgakhir')";
            // replace params
            query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir);
            query = query.Replace("@moawal", moAwal).Replace("@moakhir", moAkhir);
            query = query.Replace("@dsgawal", dsgAwal).Replace("@dsgakhir", dsgAkhir);
            dtResult = DB.sql.Select(query);
        }

        private void UpdateReport()
        {
            string tanggal = "Tanggal: " + dtpTglAwal.DateTime.ToString("dd/MM/yyyy") + " - " + dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
            this.Report.Bands[BandKind.ReportHeader].Controls["xrTanggal"].Text = tanggal;
            this.Report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
        }
    }
}

