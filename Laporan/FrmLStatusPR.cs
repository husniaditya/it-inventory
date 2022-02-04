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
    public partial class FrmLStatusPR : CAS.Laporan.BaseLaporan
    {
        public FrmLStatusPR()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
        }

        private void FrmLStatusPR_Load(object sender, EventArgs e)
        {
           // dtpTglAwal.DateTime = dtpTglAkhir.DateTime = DB.loginDate;
            dtpTglAwal.DateTime = Utility.FirstDateInMonth(DB.loginDate);
            dtpTglAkhir.DateTime = Utility.LastDateInMonth(DB.loginDate);

            rgStatusPO.SelectedIndex = 2;
            if (this.Tag.ToString() == "6a92")
            {
                    this.ReportName = "RepStockOrderBeli";
                    rgStatusPO.Visible = false;
                    label4.Visible = false;
                    txtPrqAkhir.Visible = false;
                    txtPrqAwal.Visible = false;
                    label2.Visible = false;
            }

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                CollectData();
                if (this.Tag.ToString() == "6a92")
                    this.ReportName = "RepStockOrderBeli";
                else
                    if (this.Tag.ToString() == "63113")
                        this.ReportName = "RepStatusPRTanpaNilai";
                    else
                         this.ReportName = "RepStatusPR";

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
            string invAwal = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 0);
            string invAkhir = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 1);
            string prqAwal = DB.GetRangeValue(txtPrqAwal, txtPrqAkhir, 0);
            string prqAkhir = DB.GetRangeValue(txtPrqAwal, txtPrqAkhir, 1);
            string jnsAwal = DB.GetRangeValue(txtJenisAwal, txtJenisAkhir, 0);
            string jnsAkhir = DB.GetRangeValue(txtJenisAwal, txtJenisAkhir, 1);
            string locAwal = DB.GetRangeValue(txtLocAwal, txtLocAkhir, 0);
            string locAkhir = DB.GetRangeValue(txtLocAwal, txtLocAkhir, 1);
            dtResult = new DataTable();
            string query = "";
            if (this.Tag.ToString() == "6a92")
            {
                query = "CALL Sp_StockOrderBeli(" + tglAwal + "," + tglAkhir + ",'" + invAwal + "','" + invAkhir + "','" + locAwal + "','" + locAkhir + "')";
            }
            else
            {
                query = "Call SP_PrqOut1(@tglawal,@tglakhir,'@invawal','@invakhir',@statusPO,'@prqawal','@prqakhir','@jenisawal','@jenisakhir')";
                // replace params
                query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir);
                query = query.Replace("@invawal", invAwal).Replace("@invakhir", invAkhir);
                query = query.Replace("@prqawal", prqAwal).Replace("@prqakhir", prqAkhir);
                query = query.Replace("@jenisawal",jnsAwal).Replace("@jenisakhir", jnsAkhir);
                query = query.Replace("@locawal", locAwal).Replace("@locakhir", locAkhir);
                query = query.Replace("@statusPO", rgStatusPO.EditValue.ToString());
            }
            dtResult = DB.sql.Select(query);
        }

        private void UpdateReport()
        {
            if (this.Tag.ToString() == "6a92")
            {
                string periode2 = dtpTglAkhir.DateTime.ToString("dd MMMM yyyy");
                this.Report.Bands[BandKind.ReportHeader].Controls["xrLabel1"].Text = "Per : " + periode2;
            }
            else
            {
                string tanggal = "Tanggal: " + dtpTglAwal.DateTime.ToString("dd/MM/yyyy") + " - " + dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
                this.Report.Bands[BandKind.PageHeader].Controls["xrTanggal"].Text = tanggal;
                this.Report.Bands[BandKind.PageFooter].Controls["xrLabelUser"].Text = DB.casUser.Name;
                if (rgStatusPO.EditValue.ToString() == "2")
                    this.Report.Bands[BandKind.PageHeader].Controls["xrStatusPO"].Text = "Status PR: Open";
                else if (rgStatusPO.EditValue.ToString() == "1")
                    this.Report.Bands[BandKind.PageHeader].Controls["xrStatusPO"].Text = "Status PR: Close";
                else if (rgStatusPO.EditValue.ToString() == "4")
                    this.Report.Bands[BandKind.PageHeader].Controls["xrStatusPO"].Text = "Status PR: NOT Aprove 1";
                else if (rgStatusPO.EditValue.ToString() == "5")
                    this.Report.Bands[BandKind.PageHeader].Controls["xrStatusPO"].Text = "Status PR: NOT Aprove 2";
                else
                    this.Report.Bands[BandKind.PageHeader].Controls["xrStatusPO"].Text = "Status PR: All";

            }
        }
    }
}