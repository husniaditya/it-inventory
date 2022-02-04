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
    public partial class FrmLHistoryPORetur : CAS.Laporan.BaseLaporan
    {
        public FrmLHistoryPORetur()
        {
            InitializeComponent();
            dtpTglAwal.DateTime = dtpTglAkhir.DateTime = DB.loginDate;
            Utility.SetSqlInstance(pnlFilter, DB.sql);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                CollectData();
                //this.ReportName = "RepHistoryPORetur";
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

        private void UpdateData()
        {
            string rms = "";
            string inv = "";
            double qtypo = 0;
            foreach (DataRow dr in dtResult.Rows)
            {
                if (rms != dr["rms"].ToString() || inv != dr["inv"].ToString())
                    qtypo = (double)dr["qtypo"];
                if (rms != dr["rms"].ToString())
                    rms = dr["rms"].ToString();
                if (inv != dr["inv"].ToString())
                    inv = dr["inv"].ToString();                                    
                if (dr["nosjr"].ToString().Trim() != "")
                    qtypo = qtypo - (double)dr["qtyspm"];
                dr["saldo"] = qtypo;
            }

        }

        private void CollectData()
        {
            string tglAwal = dtpTglAwal.DateTime.ToString("yyyyMMdd");
            string tglAkhir = dtpTglAkhir.DateTime.ToString("yyyyMMdd");
            string subAwal = DB.GetRangeValue(txtSubAwal, txtSubAkhir, 0);
            string subAkhir = DB.GetRangeValue(txtSubAwal, txtSubAkhir, 1);
            string rmsAwal = DB.GetRangeValue(txtRmsAwal, txtRmsAkhir, 0);
            string rmsAkhir = DB.GetRangeValue(txtRmsAwal, txtRmsAkhir, 1);
            string invAwal = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 0);
            string invAkhir = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 1);
            dtResult = new DataTable();
            string query = "Call SP_LapHistoryPORetur(@tglawal, @tglakhir, '@subawal','@subakhir','@rmsawal','@rmsakhir','@invawal','@invakhir',@status)";
            // replace params
            query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir);
            query = query.Replace("@subawal", subAwal).Replace("@subakhir", subAkhir);
            query = query.Replace("@rmsawal", rmsAwal).Replace("@rmsakhir", rmsAkhir);
            query = query.Replace("@invawal", invAwal).Replace("@invakhir", invAkhir);
            //query = query.Replace("@period", DB.loginPeriod);
            switch (this.Tag.ToString())
            {
                case "63184":
                //case "63222":
                    query = query.Replace("@status","3");
                    break;
                case "63185":
                //case "63223":
                    query = query.Replace("@status", rgStatusPO.EditValue.ToString());
                    break;
            }
            dtResult = DB.sql.Select(query);
        }

        private void UpdateReport()
        {
            string periode1 = dtpTglAwal.DateTime.ToString("dd/MM/yyyy");
            string periode2 = dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
            this.Report.Bands[BandKind.ReportHeader].Controls["xrLabel1"].Text = "Periode : " + periode1 + " s/d " + periode2;
            this.Report.Bands[BandKind.PageFooter].Controls["xrLabelUser"].Text = DB.casUser.Name;
        }

        private void FrmLHistoryPORetur_Load(object sender, EventArgs e)
        {
            switch (this.Tag.ToString())
            {
                case "63184":
                //case "63222":
                    this.ReportName = "RepHistoryPORetur";
                    rgStatusPO.Visible = false;
                    label5.Visible = false;
                    break;
                case "63185":
                //case "63223":
                    this.ReportName = "RepPOReturTanpaHarga";
                    rgStatusPO.Visible = true;
                    label5.Visible = true;
                    break;
            }
        }

        private void txtRmsAkhir_Enter(object sender, EventArgs e)
        {
            txtRmsAkhir.ExSqlQuery = "select rms as `No PO Retur`, `date` as Tanggal, remark as Keterangan from rms where `delete`=0 and date>=" + Convert.ToDateTime(dtpTglAwal.EditValue).ToString("yyyyMMdd") + " and date<=" + Convert.ToDateTime(dtpTglAkhir.EditValue).ToString("yyyyMMdd");
        }

        private void txtRmsAwal_Enter(object sender, EventArgs e)
        {
            txtRmsAwal.ExSqlQuery = "select rms as `No PO Retur`, `date` as Tanggal, remark as Keterangan from rms where `delete`=0 and date>=" + Convert.ToDateTime(dtpTglAwal.EditValue).ToString("yyyyMMdd") + " and date<=" + Convert.ToDateTime(dtpTglAkhir.EditValue).ToString("yyyyMMdd");
        }
    }
}

