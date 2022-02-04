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
    public partial class FrmLStatusSO : CAS.Laporan.BaseLaporan
    {
        string tglAwal, tglAkhir, subAwal, subAkhir, dsgAwal, dsgAkhir, invAwal, invAkhir, SOAwal, SOAkhir;

        public FrmLStatusSO()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
        }

        private void FrmLStatusSO_Load(object sender, EventArgs e)
        {
            dtpTglAwal.DateTime = dtpTglAkhir.DateTime = DB.loginDate;
            rgStatusSO.SelectedIndex = 2; //all
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                CollectData();
                this.ReportName = "RepStatusSO";
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
            tglAwal = dtpTglAwal.DateTime.ToString("yyyyMMdd");
            tglAkhir = dtpTglAkhir.DateTime.ToString("yyyyMMdd");
            invAwal = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 0);
            invAkhir = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 1);
            subAwal = DB.GetRangeValue(txtSubAwal, txtSubAkhir, 0);
            subAkhir = DB.GetRangeValue(txtSubAwal, txtSubAkhir, 1);
            dsgAwal = DB.GetRangeValue(txtDsgAwal, txtDsgAkhir, 0);
            dsgAkhir = DB.GetRangeValue(txtDsgAwal, txtDsgAkhir, 1);
            SOAwal = DB.GetRangeValue(txtSOAwal, txtSOAkhir, 0);
            SOAkhir = DB.GetRangeValue(txtSOAwal, txtSOAkhir, 1);

            dtResult = new DataTable();
            string query = "Call SP_OklOut(@tglawal,@tglakhir,'@subawal','@subakhir','@invawal','@invakhir','@dsgawal','@dsgakhir','@SOawal', '@SOakhir', @statusSO)";
            // replace params
            query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir);
            query = query.Replace("@subawal", subAwal).Replace("@subakhir", subAkhir);
            query = query.Replace("@invawal", invAwal).Replace("@invakhir", invAkhir);
            query = query.Replace("@dsgawal", dsgAwal).Replace("@dsgakhir", dsgAkhir);
            query = query.Replace("@SOawal", SOAwal).Replace("@SOakhir", SOAkhir);
            query = query.Replace("@statusSO", rgStatusSO.SelectedIndex.ToString());
            dtResult = DB.sql.Select(query);
          
        }

        private void UpdateReport()
        {
            string tanggal = "Tanggal: " + dtpTglAwal.DateTime.ToString("dd/MM/yyyy") + " - " + dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
            string customer = "Customer: " + DB.SetFilterText(txtSubAwal.Text, txtSubAkhir.Text, (txtSubAwal.Text!="" ? txtSubAwal.ExGetDataRow() : new DataTable().NewRow()), (txtSubAkhir.Text != ""? txtSubAkhir.ExGetDataRow() : new DataTable().NewRow()), "Nama");
            string design = "Design: " + DB.SetFilterText(txtDsgAwal.Text, txtDsgAkhir.Text, (txtDsgAwal.Text != "" ? txtDsgAwal.ExGetDataRow() : new DataTable().NewRow()), (txtDsgAkhir.Text != "" ? txtDsgAkhir.ExGetDataRow() : new DataTable().NewRow()), "Nama");
            string persediaan = "Persediaan: " + DB.SetFilterText(txtInvAwal.Text, txtInvAkhir.Text, (txtInvAwal.Text != "" ? txtInvAwal.ExGetDataRow() : new DataTable().NewRow()), (txtInvAkhir.Text != "" ? txtInvAkhir.ExGetDataRow() : new DataTable().NewRow()), "Nama Barang");
            string SO = "SO: ";
            if (txtSOAwal.Text == "" && txtSOAkhir.Text == "")
                SO = SO + "All";
            else if ((txtSOAwal.Text != "" && txtSOAkhir.Text == "") || (txtSOAwal.Text == "" && txtSOAkhir.Text != ""))
                SO = SO + SOAwal;
            else
                SO = SO + SOAwal + " - " + SOAkhir;
            this.Report.Bands[BandKind.ReportHeader].Controls["xrTanggal"].Text = tanggal;
            this.Report.Bands[BandKind.ReportHeader].Controls["xrCustomer"].Text = customer;
            this.Report.Bands[BandKind.ReportHeader].Controls["xrDesign"].Text = design;
            this.Report.Bands[BandKind.ReportHeader].Controls["xrPersediaan"].Text = persediaan;
            this.Report.Bands[BandKind.ReportHeader].Controls["xrSO"].Text = SO;
            if (rgStatusSO.SelectedIndex == 0)
                this.Report.Bands[BandKind.ReportHeader].Controls["xrStatusSO"].Text = "Status SO: Open";
            else if (rgStatusSO.SelectedIndex == 1)
                this.Report.Bands[BandKind.ReportHeader].Controls["xrStatusSO"].Text = "Status SO: Close";
            else
                this.Report.Bands[BandKind.ReportHeader].Controls["xrStatusSO"].Text = "Status SO: All";
            this.Report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
        }

       
    }
}

