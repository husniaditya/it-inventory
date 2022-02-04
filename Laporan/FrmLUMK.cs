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
    public partial class FrmLUMK : CAS.Laporan.BaseLaporan
    {
        public FrmLUMK()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
            dtpTglAwal.DateTime = dtpTglAkhir.DateTime = DB.loginDate;
        }

        private void UpdateReport()
        {
            string periode1 = dtpTglAwal.DateTime.ToString("dd/MM/yyyy");
            string periode2 = dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
           
            this.Report.Bands[BandKind.ReportHeader].Controls["xrLabelTanggal"].Text = "Periode : " + periode1 + " s/d " + periode2 ;
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
            string query = "select fpjumk.*,sub.name,fpjumk.umk*fpjumk.kurs as dpprp, " + 
                           "(fpjumk.umk*fpjumk.kurs/10) as ppnrp,(fpjumk.umk*fpjumk.kurs)* 1.1 as valrp " +
                           "from fpjumk,sub where fpjumk.sub=sub.sub and fpjumk.date>=@tglawal and fpjumk.date< adddate(@tglakhir,1)" +
                           " and fpjumk.sub between '@subawal' and '@subakhir' ";
            // replace params
            query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir);
            query = query.Replace("@subawal", subAwal).Replace("@subakhir", subAkhir);
                 
            dtResult = DB.sql.Select(query);
        }

     

        private void FrmLUMK_Load(object sender, EventArgs e)
        {
                    this.ReportName = "RepKlrUmk";
        }

      
     
       
    }
}

