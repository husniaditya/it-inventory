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
    public partial class FrmLLPB : CAS.Laporan.BaseLaporan
    {
        public FrmLLPB()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
        }

        private void FrmLLPB_Load(object sender, EventArgs e)
        {
            dtpTglAwal.DateTime = Utility.FirstDateInMonth(DB.loginDate);
            dtpTglAkhir.DateTime = Utility.LastDateInMonth(DB.loginDate);

            switch (this.Tag.ToString())
            {
                case "63141":
                    this.ReportName = "RepLLPB";
                    break;
                case "63142":
                    this.ReportName = "RepLLPBTanpaHarga";
                    break;
                case "63143":
                    this.ReportName = "RepListLPB";
                    break;
                case "6d5":
                    this.ReportName = "RepLLPBPajak";
                    break;

            }
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
            string query = "";
            string tglAwal = dtpTglAwal.DateTime.ToString("yyyyMMdd");
            string tglAkhir = dtpTglAkhir.DateTime.ToString("yyyyMMdd");
            string subAwal = DB.GetRangeValue(txtSubAwal, txtSubAkhir, 0);
            string subAkhir = DB.GetRangeValue(txtSubAwal, txtSubAkhir, 1);
            string invAwal = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 0);
            string invAkhir = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 1);
            string lpbAwal = DB.GetRangeValue(txtLPBawal, txtLPBAkhir, 0);
            string lpbAkhir = DB.GetRangeValue(txtLPBawal, txtLPBAkhir, 1);
            string loca = DB.GetRangeValue(txtLocAwal, txtLocAkhir, 0);
            string locz = DB.GetRangeValue(txtLocAwal, txtLocAkhir, 1);
            dtResult = new DataTable();
            if (this.Tag.ToString() != "6d5")
            {
                query = "Call SP_LapLPB('@invawal','@invakhir',@tglawal, @tglakhir,'@subawal','@subakhir','@lpbawal','@lpbakhir','@PO','@loca','@locz')";
            }
            else
            {
               query = "Call SP_LapLPBPajak('@invawal','@invakhir',@tglawal, @tglakhir,'@subawal','@subakhir','@lpbawal','@lpbakhir','@PO','@loca','@locz')";
            }
            // replace params
            query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir);
            query = query.Replace("@subawal", subAwal).Replace("@subakhir", subAkhir);
            query = query.Replace("@invawal", invAwal).Replace("@invakhir", invAkhir);
            query = query.Replace("@lpbawal", lpbAwal).Replace("@lpbakhir", lpbAkhir);
            query = query.Replace("@PO", txtOmsAwal.Text);
            query = query.Replace("@loca", loca).Replace("@locz", locz);

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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtLocAwal_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtLocAkhir_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}