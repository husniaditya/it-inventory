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
    public partial class FrmLStatusPO : CAS.Laporan.BaseLaporan
    {
        public FrmLStatusPO()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
        }

        private void FrmLStatusPO_Load(object sender, EventArgs e)
        {
            dtpTglAwal.DateTime = Utility.FirstDateInMonth(DB.loginDate);
            dtpTglAkhir.DateTime = Utility.LastDateInMonth(DB.loginDate);
            rgStatusPO.SelectedIndex = 2; //all
            switch (this.Tag.ToString())
            {
                case "63124":
                    this.ReportName = "RepStatusPOTanpaNilai";
                    panelPO.Visible = true;
                    break;
                case "63125":
                    this.ReportName = "RepStatusPO";
                    panelPO.Visible = true;
                    break;
                //case "63221":
                case "63183":
                    this.ReportName = "RepStatusPORetur";
                    panelPO.Visible = false;
                    label4.Top = 133;
                    rgStatusPO.Top = 133;
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
            string invAwal = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 0);
            string invAkhir = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 1);
            string omsAwal = "";
            string omsAkhir = "";
            dtResult = new DataTable();
            string query = "";
            switch (this.Tag.ToString())
            {
                case "63124":
                case "63125":
                    omsAwal = DB.GetRangeValue(txtOmsAwal, txtOmsAkhir, 0);
                    omsAkhir = DB.GetRangeValue(txtOmsAwal, txtOmsAkhir, 1);
                    query = "Call SP_OmsOut(@tglawal,@tglakhir,'@subawal','@subakhir','@invawal','@invakhir',@statusPO,'@omsawal','@omsakhir','"+ personTextBoxEx.Text.Trim() +"')";
                    query = query.Replace("@omsawal", omsAwal).Replace("@omsakhir", omsAkhir);
                    break;
                case "63183":
                //case "63221":
                    query = "Call SP_LapStatusPORetur(@tglawal,@tglakhir,'@subawal','@subakhir','@invawal','@invakhir',@statusPO)";
                    break;
            }
            // replace params
            query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir);
            query = query.Replace("@subawal", subAwal).Replace("@subakhir", subAkhir);
            query = query.Replace("@invawal", invAwal).Replace("@invakhir", invAkhir);
            query = query.Replace("@statusPO", rgStatusPO.SelectedIndex.ToString());
            dtResult = DB.sql.Select(query);        
        }

        private void UpdateReport()
        {
            string tanggal = "Tanggal: " + dtpTglAwal.DateTime.ToString("dd/MM/yyyy") + " - " + dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
            string supplier = "Supplier: " + (txtSubAwal.Text=="" && txtSubAkhir.Text == "" ? "All" : (txtSubAwal.Text + " - " + txtSubAkhir.Text));
            string persediaan = "Persediaan: " +( txtInvAwal.Text=="" && txtInvAkhir.Text=="" ?"All" : txtInvAwal.Text + " - "  + txtInvAkhir.Text);
            this.Report.Bands[BandKind.PageHeader].Controls["xrTanggal"].Text = tanggal;
            this.Report.Bands[BandKind.PageHeader].Controls["xrSupplier"].Text = supplier;
            this.Report.Bands[BandKind.PageHeader].Controls["xrPersediaan"].Text = persediaan;
            if (rgStatusPO.SelectedIndex == 0)
                this.Report.Bands[BandKind.PageHeader].Controls["xrStatusPO"].Text = "Status PO: Open";
            else if (rgStatusPO.SelectedIndex == 1)
                this.Report.Bands[BandKind.PageHeader].Controls["xrStatusPO"].Text = "Status PO: Close";
            else
                this.Report.Bands[BandKind.PageHeader].Controls["xrStatusPO"].Text = "Status PO: All";

            this.Report.Bands[BandKind.PageFooter].Controls["xrLabelUser"].Text = DB.casUser.Name;
        }
    }
}

