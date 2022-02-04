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
    public partial class FrmLBKK : CAS.Laporan.BaseLaporan
    {
        public FrmLBKK()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
            dtpTglAwal.DateTime = dtpTglAkhir.DateTime = DB.loginDate;
        }

        private void UpdateReport()
        {
            string periode1 = dtpTglAwal.DateTime.ToString("dd/MM/yyyy");
            string periode2 = dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
           
            this.Report.Bands[BandKind.ReportHeader].Controls["xrPeriod"].Text = "Periode : " + periode1 + " s/d " + periode2 ;

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
            string pbbka = DB.GetRangeValue(BBKEx1, BBKEx2, 0);
            string pbbkz = DB.GetRangeValue(BBKEx1, BBKEx2, 1);

            dtResult = new DataTable();
            string query = "call Sp_LapBKK(@tglawal,@tglakhir,'@subawal','@subakhir', '@pbbka', '@pbbkz') ";
            // replace params
            query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir);
            query = query.Replace("@subawal", subAwal).Replace("@subakhir", subAkhir);
            query = query.Replace("@pbbka", pbbka).Replace("@pbbkz", pbbkz);
                             
            dtResult = DB.sql.Select(query);
        }     

        private void FrmLBKK_Load(object sender, EventArgs e)
        {
                    this.ReportName = "lapBKK";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

      
     
       
    }
}

