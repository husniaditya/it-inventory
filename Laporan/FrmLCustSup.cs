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
    public partial class FrmLCustSup : BaseLaporan
    {
        string query = "";
        public FrmLCustSup()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
            dtpTglAwal.DateTime = Utility.FirstDateInMonth(DB.loginDate);
            dtpTglAkhir.DateTime = Utility.LastDateInMonth(DB.loginDate);
        
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                CollectData();
                gridControlEx1.ExGridControl.DataSource = dtResult;
                DB.SetNumberFormat(gridControlEx1.ExGridView, "n2");
                gridControlEx1.BestFitColumn=true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CollectData()
        {
            
            string subAwal = DB.GetRangeValue(txtSubAwal, txtSubAkhir, 0);
            string subAkhir = DB.GetRangeValue(txtSubAwal, txtSubAkhir, 1);
            string tglAwal = dtpTglAwal.DateTime.ToString("yyyyMMdd");
            string tglAkhir = dtpTglAkhir.DateTime.ToString("yyyyMMdd");
            query = "";
            switch (this.Tag.ToString())
            {
                case "6d1":
                    if (checkefak.Checked)
                      query = "call SP_LapEFAKMASUKAN('@subawal','@subakhir',@tglawal, @tglakhir)";                 
                    else
                      query = "call SP_LapPPNMASUKAN('@subawal','@subakhir',@tglawal, @tglakhir)";
                    break;
                case "6d2":
                    if (checkefak.Checked)
                    {
                        if (expcheck.Checked)
                         query = "call SP_LapEFAKKELUARANEXP('@subawal','@subakhir',@tglawal, @tglakhir)";
                        else
                         query = "call SP_LapEFAKKELUARAN('@subawal','@subakhir',@tglawal, @tglakhir)";
                    }
                    else
                        query = "call SP_LapPPNKELUARAN('@subawal','@subakhir',@tglawal, @tglakhir)";
                    break;
                case "617":
                    query = "select * from sub where group_=1 and sub between '@subawal' and '@subakhir' ";
                    break;
                case "618":
                    query = "select * from sub where group_=2 and sub between '@subawal' and '@subakhir' ";
                    break;
            }

            dtResult = new DataTable();
            // replace params
            query = query.Replace("@subawal", subAwal).Replace("@subakhir", subAkhir);
            query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir);
            dtResult = DB.sql.Select(query);
        }

        private void UpdateReport()
        {
            this.Report.Bands[BandKind.ReportHeader].Controls["xrLabelJudul"].Text = this.Text;
            switch (this.Tag.ToString())
            {
                case "617":
                    this.Report.Bands[BandKind.PageHeader].Controls["xrTableHeader"].Controls["xrTableRowHeader"].Controls["xrTableCellNama"].Text = "Nama Supplier";
                    this.Report.Bands[BandKind.PageHeader].Controls["xrTableHeader"].Controls["xrTableRowHeader"].Controls["xrTableCellAlamat"].Text = "Alamat Supplier";
                    break;
                case "618":
                    this.Report.Bands[BandKind.PageHeader].Controls["xrTableHeader"].Controls["xrTableRowHeader"].Controls["xrTableCellNama"].Text = "Nama Customer";
                    this.Report.Bands[BandKind.PageHeader].Controls["xrTableHeader"].Controls["xrTableRowHeader"].Controls["xrTableCellAlamat"].Text = "Alamat Customer";
                    break;
            }
        }

        private void FrmLCustSup_Load(object sender, EventArgs e)
        {
            this.ReportName = "RepLPPN";
            switch (this.Tag.ToString())
            {
                case "6d1":
                    this.Text = "Laporan PPN Masukan";
                    labelJudul.Text = "Supplier";
                    txtSubAkhir.ExSqlQuery = txtSubAwal.ExSqlQuery = "call SP_Lookup('supplier')";
                    break;
                case "6d2":
                    this.Text = "Laporan PPN Keluaran";
                    labelJudul.Text = "Customer";
                    txtSubAkhir.ExSqlQuery = txtSubAwal.ExSqlQuery = "call SP_Lookup('customer')";
                    break;
                case "617":
                    this.ReportName = "RepLSupplier";
                    this.Text = "Laporan Master Supplier";
                    labelJudul.Text = "Supplier";
                    txtSubAkhir.ExSqlQuery = txtSubAwal.ExSqlQuery = "call SP_Lookup('supplier')";
                    break;
                case "618":
                    this.ReportName = "RepLSupplier";
                    this.Text = "Laporan Master Customer";
                    labelJudul.Text = "Customer";
                    txtSubAkhir.ExSqlQuery = txtSubAwal.ExSqlQuery = "call SP_Lookup('customer')";
                    break;
            }
        }

    }
}