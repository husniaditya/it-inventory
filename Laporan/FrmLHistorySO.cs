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
    public partial class FrmLHistorySO : CAS.Laporan.BaseLaporan
    {
        public FrmLHistorySO()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
            //txtOklAwal.ExSqlQuery = txtOklAkhir.ExSqlQuery = "select okl as `No SO`, `date` as Tanggal, remark as Keterangan from okl where `delete`=0 and period='" + DB.loginPeriod + "'";
            txtOklAwal.ExSqlQuery = txtOklAkhir.ExSqlQuery = "select okl as `No SO`, `date` as Tanggal, remark as Keterangan from okl where `delete`=0";
            dtpTglAwal.DateTime = dtpTglAkhir.DateTime = DB.loginDate;
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
            string oklAwal = DB.GetRangeValue(txtOklAwal, txtOklAkhir, 0);
            string oklAkhir = DB.GetRangeValue(txtOklAwal, txtOklAkhir, 1);
            dtResult = new DataTable();
            string query = "Call SP_LapHistorySO(@tglawal,@tglakhir,'@subawal','@subakhir','@oklawal','@oklakhir',@status)";
            // replace params
            query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir);
            query = query.Replace("@subawal", subAwal).Replace("@subakhir", subAkhir);
            query = query.Replace("@oklawal", oklAwal).Replace("@oklakhir", oklAkhir);
            switch (this.Tag.ToString())
            {
                case "63316":
                //case "63416":
                    query = query.Replace("@status", "3");
                    break;
                case "63317":
                //case "63417":
                    query = query.Replace("@status", rgStatusSO.EditValue.ToString());
                    break;
            }
            query = query.Replace("@period", DB.loginPeriod);
            dtResult = DB.sql.Select(query);
        }

        private void UpdateReport()
        {
            string periode1 = dtpTglAwal.DateTime.ToString("dd/MM/yyyy");
            string periode2 = dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
            string status = "";
            this.Report.Bands[BandKind.ReportHeader].Controls["xrLabel1"].Text = "Periode : " + periode1 + " s/d " + periode2;
            this.Report.Bands[BandKind.PageFooter].Controls["xrLabelUser"].Text = DB.casUser.Name;
        
        }

        private void FrmLHistorySO_Load(object sender, EventArgs e)
        {
            switch (this.Tag.ToString())
            {
                case "63316":
                //case "63416":
                    //txtOklAwal.ExSqlQuery = txtOklAkhir.ExSqlQuery = "select oms as `No PO`, `date` as Tanggal, remark as Keterangan from oms where `delete`=0";
                    this.ReportName = "RepHistorySO";
                    rgStatusSO.Visible = false;
                    label4.Visible = false;
                    break;
                case "63317":
                //case "63417":
                    //txtOklAwal.ExSqlQuery = txtOklAkhir.ExSqlQuery = "select oms as `No PO`, `date` as Tanggal, remark as Keterangan from oms where `delete`=0 and left(oms,3)='POL'";
                    this.ReportName = "RepSOTanpaHarga";
                    rgStatusSO.Visible = true;
                    label4.Visible = true;
                    break;
            }
        }

        private void txtOklAwal_Enter(object sender, EventArgs e)
        {
            txtOklAwal.ExSqlQuery = "select okl as `No SO`, `date` as Tanggal, remark as Keterangan from okl where `delete`=0 and date>=" + Convert.ToDateTime(dtpTglAwal.EditValue).ToString("yyyyMMdd") + " and date<=" + Convert.ToDateTime(dtpTglAkhir.EditValue).ToString("yyyyMMdd");
        }

        private void txtOklAkhir_Enter(object sender, EventArgs e)
        {
            txtOklAwal.ExSqlQuery = "select okl as `No SO`, `date` as Tanggal, remark as Keterangan from okl where `delete`=0 and date>=" + Convert.ToDateTime(dtpTglAwal.EditValue).ToString("yyyyMMdd") + " and date<=" + Convert.ToDateTime(dtpTglAkhir.EditValue).ToString("yyyyMMdd");
        }

        private void dtpTglAwal_EditValueChanged(object sender, EventArgs e)
        {
            txtOklAwal.EditValue = "";
            txtOklAkhir.EditValue = "";
        }

        private void dtpTglAkhir_EditValueChanged(object sender, EventArgs e)
        {
            txtOklAwal.EditValue = "";
            txtOklAkhir.EditValue = "";
        }
       
    }
}

