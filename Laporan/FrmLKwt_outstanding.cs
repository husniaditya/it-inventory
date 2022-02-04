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
    public partial class FrmLKwt_outstanding : CAS.Laporan.BaseLaporan
    {
        public FrmLKwt_outstanding()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
            dtpTglAwal.DateTime = dtpTglAkhir.DateTime = DB.loginDate;
        }

        private void UpdateReport()
        {
            string periode1 = dtpTglAwal.DateTime.ToString("dd/MM/yyyy");
            string periode2 = dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
            string status = "";
            if (rgStatusKwt.EditValue.ToString() == "1")
                status = "OPEN";
            else
                if (rgStatusKwt.EditValue.ToString() == "2")
                {
                    status = "ClOSE";
                    this.Report.Bands[BandKind.ReportHeader].Controls["xrLabel10"].Text = "REKAP PIUTANG YANG SUDAH TERLUNASI ";
                }
                else
                    status = "ALL";

            this.Report.Bands[BandKind.ReportHeader].Controls["xrLabelTanggal"].Text = "Periode : " + periode1 + " s/d " + periode2 +" Status : " + status;
            this.Report.Bands[BandKind.PageFooter].Controls["xrLabelUser"].Text = DB.casUser.Name;

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
            dtResult = new DataTable();
            string query = "Call Sp_Kwt_outstanding(@tglawal,@tglakhir,'@subawal','@subakhir',@status)";
            // replace params
            query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir);
            query = query.Replace("@subawal", subAwal).Replace("@subakhir", subAkhir);
            query = query.Replace("@status", rgStatusKwt.EditValue.ToString());
                 
 
            
            
            dtResult = DB.sql.Select(query);
        }

     

        private void FrmLKwt_outstanding_Load(object sender, EventArgs e)
        {
                    this.ReportName = "RepLkwt_out";
        }

      
     
       
    }
}

