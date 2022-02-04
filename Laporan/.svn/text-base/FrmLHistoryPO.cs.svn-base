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
    public partial class FrmLHistoryPO : CAS.Laporan.BaseLaporan
    {
        public FrmLHistoryPO()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
            //txtOmsAwal.ExSqlQuery = txtOmsAkhir.ExSqlQuery = "select oms as `No PO`, `date` as Tanggal, remark as Keterangan from oms where `delete`=0 and period='" + DB.loginPeriod + "'";
            dtpTglAwal.DateTime = dtpTglAkhir.DateTime = DB.loginDate;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                CollectData();
                LoadReport();
                UpdateData();
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
            string omsAwal = DB.GetRangeValue(txtOmsAwal, txtOmsAkhir, 0);
            string omsAkhir = DB.GetRangeValue(txtOmsAwal, txtOmsAkhir, 1);
            string invAwal = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 0);
            string invAkhir = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 1);
            dtResult = new DataTable();
            string query = "Call SP_LapHistoryPO(@tglawal, @tglakhir, '@subawal','@subakhir','@omsawal','@omsakhir',@status,@lokal,'@invawal','@invakhir')";
            // replace params
            query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir);
            query = query.Replace("@subawal", subAwal).Replace("@subakhir", subAkhir);
            query = query.Replace("@omsawal", omsAwal).Replace("@omsakhir", omsAkhir);
            query = query.Replace("@invawal", invAwal).Replace("@invakhir", invAkhir);
            switch (this.Tag.ToString())
            {
                case "63126":
                    query = query.Replace("@status", "3");
                    query = query.Replace("@lokal", "3");
                    break;
                case "63127":
                    query = query.Replace("@status", "3");
                    query = query.Replace("@lokal", "3");
                    break;
                case "63128":
                    query = query.Replace("@status", rgStatusPO.EditValue.ToString());
                    query = query.Replace("@lokal", "1");
                    break;
                case "63129":
                    query = query.Replace("@status", rgStatusPO.EditValue.ToString());
                    query = query.Replace("@lokal", "2");
                    break;
                case "6a92":
                    query = "CALL Sp_StockOrderBeli()";
                     break;
            }
            //query = query.Replace("@period", DB.loginPeriod);
            dtResult = DB.sql.Select(query);       
        }

        private void UpdateData()
        {
            if (this.Tag.ToString() != "6a92")
            {
                string oms = "";
                string remark = "";
                double qtypo = 0;
                foreach (DataRow dr in dtResult.Rows)
                {
                    if (oms != dr["oms"].ToString() || remark != dr["remark"].ToString())
                    {
                        oms = dr["oms"].ToString();
                        qtypo = (double)dr["qtypo"];
                        remark = dr["remark"].ToString();
                    }

                    qtypo = qtypo - (double)dr["qtylpb"];
                    dr["saldo"] = qtypo;

                }
            }
        }

        private void UpdateReport()
        {
            switch (this.Tag.ToString())
            {
                case "63128":
                    this.Report.Bands[BandKind.ReportHeader].Controls["xrLabelJudul"].Text = "Laporan PO LOKAL";
                    break;
                case "63129":
                    this.Report.Bands[BandKind.ReportHeader].Controls["xrLabelJudul"].Text = "Laporan PO IMPORT";
                    break;
                case "6a92":
                    string periode2 = dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
                    this.Report.Bands[BandKind.ReportHeader].Controls["xrLabel1"].Text = "Per : "+periode2;
                    break;
                   
            }
            if (this.Tag.ToString() != "6a92")
            {
                string periode1 = dtpTglAwal.DateTime.ToString("dd/MM/yyyy");
                string periode2 = dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
                this.Report.Bands[BandKind.ReportHeader].Controls["xrLabel1"].Text = "Periode : " + periode1 + " s/d " + periode2;
                this.Report.Bands[BandKind.PageFooter].Controls["xrLabelUser"].Text = DB.casUser.Name;
            }
        }

        private void FrmLHistoryPO_Load(object sender, EventArgs e)
        {
            switch (this.Tag.ToString())
            {
                case "63126":
                    txtOmsAwal.ExSqlQuery = txtOmsAkhir.ExSqlQuery = "select oms as `No PO`, `date` as Tanggal, remark as Keterangan from oms where `delete`=0";
                    this.ReportName = "RepHistoryPO";
                    rgStatusPO.Visible = false;
                    label4.Visible = false;
                    break;
                case "63128":
                    txtOmsAwal.ExSqlQuery = txtOmsAkhir.ExSqlQuery = "select oms as `No PO`, `date` as Tanggal, remark as Keterangan from oms where `delete`=0 ";
                    this.ReportName = "RepPOEkspedisi";
                    rgStatusPO.Visible = true;
                    label4.Visible = true;
                    break;
                case "63129":
                    txtOmsAwal.ExSqlQuery = txtOmsAkhir.ExSqlQuery = "select oms as `No PO`, `date` as Tanggal, remark as Keterangan from oms where `delete`=0 ";
                    this.ReportName = "RepPOEkspedisi";
                    rgStatusPO.Visible = true;
                    label4.Visible = true;
                    break;
                case "63127":
                    txtOmsAwal.ExSqlQuery = txtOmsAkhir.ExSqlQuery = "select oms as `No PO`, `date` as Tanggal, remark as Keterangan from oms where `delete`=0";
                    this.ReportName = "RepHistoryPOTanpaNilai";
                    rgStatusPO.Visible = false;
                    label4.Visible = false;
                    break;
                case "6a92":
                    txtOmsAwal.ExSqlQuery = txtOmsAkhir.ExSqlQuery = "select oms as `No PO`, `date` as Tanggal, remark as Keterangan from oms where `delete`=0 ";
                    this.ReportName = "RepStockOrderBeli";
                    rgStatusPO.Visible = false;
                    label4.Visible = false;
                    break;
            }
        }

        private void txtSubAwal_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}

