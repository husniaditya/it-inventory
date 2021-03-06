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
    public partial class FrmLHistoryPR : CAS.Laporan.BaseLaporan
    {
        public FrmLHistoryPR()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                CollectData();
                LoadReport();
                //UpdateData();
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
            string prqAwal = DB.GetRangeValue(txtPrqAwal, txtPrqAkhir, 0);
            string prqAkhir = DB.GetRangeValue(txtPrqAwal, txtPrqAkhir, 1);
            string subAwal = DB.GetRangeValue(txtSubAwal, txtSubAkhir, 0);
            string subAkhir = DB.GetRangeValue(txtSubAwal, txtSubAkhir, 1);
            dtResult = new DataTable();
            string query = "";

            switch (this.Tag.ToString())
            {
                case "63112":
                    query = "Call SP_LapHistoryPR(@tglawal, @tglakhir, '@prqawal','@prqakhir')";
                    break;
                //case "63212":
                case "63182":
                    query = "Call SP_LapHistoryPRRetur(@tglawal, @tglakhir, '@prqawal','@prqakhir', '@subawal', '@subakhir')";
                    break;
            }
            // replace params
            query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir);
            query = query.Replace("@prqawal", prqAwal).Replace("@prqakhir", prqAkhir);
            query = query.Replace("@subawal", subAwal).Replace("@subakhir", subAkhir);
            //query = query.Replace("@period", DB.loginPeriod);
            dtResult = DB.sql.Select(query);
        }

        private void UpdateReport()
        {
            string periode1 = dtpTglAwal.DateTime.ToString("dd/MM/yyyy");
            string periode2 = dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
            this.Report.Bands[BandKind.ReportHeader].Controls["xrLabel1"].Text = "Periode : " + periode1 + " s/d " + periode2;
            this.Report.Bands[BandKind.PageFooter].Controls["xrLabelUser"].Text = DB.casUser.Name;
       
        }

        private void FrmLHistoryPR_Load(object sender, EventArgs e)
        {
            dtpTglAwal.DateTime = Utility.FirstDateInMonth(DB.loginDate);
            dtpTglAkhir.DateTime = Utility.LastDateInMonth(DB.loginDate);
            switch (this.Tag.ToString())
            {
                case "63112":
                    this.ReportName = "RepHistoryPR";
                    txtPrqAwal.ExSqlQuery = txtPrqAkhir.ExSqlQuery = txtPrqAkhir.ExSqlQuery = "select prq.prq as `PR`, prd.inv as `Kode Barang`, prd.remark as `Nama Barang`, prq.date as `Tgl Dibutuhkan`, aprov as `Approve`, close as `Closed`, withPO as `With PO` from prd, prq where prd.prq=prq.prq and `delete` = 0";
                    lblSupplier.Visible = false;
                    txtSubAwal.Visible = false;
                    txtSubAkhir.Visible = false;
                    break;
                case "63182":
                //case "63212":
                    this.ReportName = "RepHistoryPRRetur";
                    txtPrqAwal.ExSqlQuery = txtPrqAkhir.ExSqlQuery = "select rma as `No PR`, `date` as Tanggal, remark as Keterangan from rma where `delete`=0";
                    lblSupplier.Visible = true;
                    txtSubAwal.Visible = true;
                    txtSubAkhir.Visible = true;
                    break;
            }
        }


    }
}

