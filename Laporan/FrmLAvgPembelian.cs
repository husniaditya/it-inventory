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
    public partial class FrmLAvgPembelian : CAS.Laporan.BaseLaporan
    {
        public FrmLAvgPembelian()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
        }

        private void FrmLAvgPembelian_Load(object sender, EventArgs e)
        {
            dtpTglAwal.DateTime = dtpTglAkhir.DateTime = DB.loginDate;
            this.ReportName = "RepAnalisaPembelian";
                  
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
            DateTime tglawal1 = Utility.FirstDateInMonth(dtpTglAwal.DateTime);
            DateTime tglakhir1 = Utility.LastDateInMonth(dtpTglAkhir.DateTime);

            string tglAwal = tglawal1.ToString("yyyyMMdd");
            string tglAkhir = tglakhir1.ToString("yyyyMMdd");
            string invAwal = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 0);
            string invAkhir = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 1);
            string jnsAwal = DB.GetRangeValue(txtJenisAwal, txtJenisAkhir, 0);
            string jnsAkhir = DB.GetRangeValue(txtJenisAwal, txtJenisAkhir, 1);
            dtResult = new DataTable();
            string query = "";
            query = "call Sp_AnalisaPembelian (@tglawal,@tglakhir,'@jnsawal','@jnsakhir','@invawal','@invakhir')";
                // replace params
                query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir);
                query = query.Replace("@invawal", invAwal).Replace("@invakhir", invAkhir);
                query = query.Replace("@jnsawal", jnsAwal).Replace("@jnsakhir", jnsAkhir);
                dtResult = DB.sql.Select(query); 
        }

        private void UpdateReport()
        {
            DateTime tglawal1 = Utility.FirstDateInMonth(dtpTglAwal.DateTime);
            DateTime tglakhir1 = Utility.LastDateInMonth(dtpTglAkhir.DateTime);
            string tanggal = "Tanggal: " + tglawal1.ToString("dd/MM/yyyy") + " - " + tglakhir1.ToString("dd/MM/yyyy");
            this.Report.Bands[BandKind.ReportHeader].Controls["xrLabel1"].Text = tanggal;
        }
    }
}