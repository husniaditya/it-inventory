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
    public partial class FrmLFlexCor : BaseLaporan
    {
        double grandtotal = 0;
        public FrmLFlexCor()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
        }

        private void FrmLKartuStock_Load(object sender, EventArgs e)
        {
            dtpTglAwal.DateTime = Utility.FirstDateInMonth(DB.loginDate);
            dtpTglAkhir.DateTime = Utility.LastDateInMonth(DB.loginDate);
            if (this.Tag.ToString() == "63121")
            {
                this.Text = "Report Corrugated Packaging";
            }
            else
                this.Text = "Report Flexible Packaging";

        }
        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
              
                btnPreview.Enabled = false;
                CollectData();
                ProcessData();
                if (this.Tag.ToString() == "63121")
                {
                    switch (cbstage.Text)
                    {
                        case "1": // Tanpa Nilai
                            this.ReportName = "descorst1"; break;
                        case "2": // Dengan Nilai
                            this.ReportName = "descorst2"; break;
                        case "3":
                            this.ReportName = "descorst3"; break;
                    }
                }

                if (this.Tag.ToString() == "63122")
                {
                    switch (cbstage.Text)
                    {
                        case "1": // Tanpa Nilai
                            this.ReportName = "desflexst1"; break;
                        case "2": // Dengan Nilai
                            this.ReportName = "desflexst2"; break;
                        case "3":
                            this.ReportName = "desflexst3"; break;
                    }
                }
             
                LoadReport();
                UpdateReport();
                PreviewReport();
                btnPreview.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                btnPreview.Enabled = true;
            }
        }

        private void CollectData()
        {
            string tglAwal = dtpTglAwal.DateTime.ToString("yyyyMMdd");
            string tglAkhir = dtpTglAkhir.DateTime.AddDays(1).ToString("yyyyMMdd");
            string jenisAwal = DB.GetRangeValue(txtJenisAwal, txtJenisAkhir, 0);
            string jenisAkhir = DB.GetRangeValue(txtJenisAwal, txtJenisAkhir, 1);
            string invAwal = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 0);
            string invAkhir = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 1);
       
            dtResult = new DataTable();

            string query = "Call SP_desaincor('@invawal','@invakhir','@jenisawal','@jenisakhir',@tglawal,@tglakhir,'@stage')";
          
            // replace params
            query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir);
            query = query.Replace("@jenisawal", jenisAwal).Replace("@jenisakhir", jenisAkhir);
            query = query.Replace("@invawal", invAwal).Replace("@invakhir", invAkhir);
            query = query.Replace("@stage", cbstage.Text);
                        
            dtResult = DB.sql.Select(query);
        }

        private void ProcessData()
        {
         
        }

        private void UpdateReport()
        {
            string tanggal = "Periode: " + dtpTglAwal.DateTime.ToString("dd/MM/yyyy") + " - " + dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
            this.Report.Bands[BandKind.ReportHeader].Controls["xrPeriod"].Text = tanggal;
      
        }

      
    }
}