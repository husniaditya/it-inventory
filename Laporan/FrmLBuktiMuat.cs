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
    public partial class FrmLBuktiMuat : CAS.Laporan.BaseLaporan
    {
        public FrmLBuktiMuat()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
            rbtnDA.Checked = true;
        }

        private void FrmLBuktiMuat_Load(object sender, EventArgs e)
        {
            dtpTglAwal.DateTime = Utility.FirstDateInMonth(DB.loginDate);
            dtpTglAkhir.DateTime = Utility.LastDateInMonth(DB.loginDate);
            //this.ReportName = "RepBuktiMuat";

            switch (this.Tag.ToString())
            {
                case "63382":
                    this.ReportName = "RepBuktiMuat";
                    break;
                case "63g1":
                    this.ReportName = "RepTransaksiAngkutanPerSupplier";
                    break;
                case "63g2":
                    this.ReportName = "RepTransaksiAngkutanPerTujuan";
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
            string tglAwal = dtpTglAwal.DateTime.ToString("yyyyMMdd");
            string tglAkhir = dtpTglAkhir.DateTime.ToString("yyyyMMdd");
            string subAwal = DB.GetRangeValue(txtSubAwal, txtSubAkhir, 0);
            string subAkhir = DB.GetRangeValue(txtSubAwal, txtSubAkhir, 1);
            string angAwal = DB.GetRangeValue(txtAngkutanAwal, txtAngkutanAkhir, 0);
            string angAkhir = DB.GetRangeValue(txtAngkutanAwal, txtAngkutanAkhir, 1);
            string ang;
            if (rbtnDA.Checked)
            {
                ang = "DA";
            }
            else if (rbtnTA.Checked)
            {
                ang = "TA";
            }
            else ang = "AL";
            dtResult = new DataTable();
            string query = "";
            switch (this.Tag.ToString())
            {
                case "63382":
                    query = "Call SP_BuktiMuat(@tglawal, @tglakhir, '@angawal','@angakhir','@subawal','@subakhir')";
                    break;
                case "63g1":
                case "63g2":
                    query = "Call SP_LapTransaksiAngkutan(@tglawal, @tglakhir, '@angawal','@angakhir','@subawal','@subakhir','@ang')";
                    break;
            }

            // replace params
            query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir);
            query = query.Replace("@subawal", subAwal).Replace("@subakhir", subAkhir);
            query = query.Replace("@angawal", angAwal).Replace("@angakhir", angAkhir);
            query = query.Replace("@ang", ang);
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

        private void txtSubAkhir_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}