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
    public partial class FrmLPPNPembelian : CAS.Laporan.BaseLaporan
    {
        public FrmLPPNPembelian()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                CollectData();
            //    ProcessData();
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
            string subAwal = DB.GetRangeValue(txtSubAwal , txtSubAkhir, 0);
            string subAkhir = DB.GetRangeValue(txtSubAwal, txtSubAkhir, 1);
            string accAwal = DB.GetRangeValue(txtAccAwal, txtAccAkhir, 0);
            string accAkhir = DB.GetRangeValue(txtAccAwal, txtAccAkhir, 1);
         
            dtResult = new DataTable();
            string query = "";
            if (this.Tag.ToString() == "6d6")
                query = "Call SP_HistorySubPajak(@tglawal,@tglakhir,'@subawal','@subakhir',0,'@accawal','@accakhir')";          
            else
              query = "Call SP_HistorySub(@tglawal,@tglakhir,'@subawal','@subakhir',0,'@accawal','@accakhir')";
          
            // replace params
            query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir);
            query = query.Replace("@accawal", accAwal).Replace("@accakhir", accAkhir);
            query = query.Replace("@subawal", subAwal).Replace("@subakhir", subAkhir);
            dtResult = DB.sql.Select(query);
        }

        private void UpdateReport()
        {
            string tanggal = "Tanggal: " + dtpTglAwal.DateTime.ToString("dd/MM/yyyy") + " - " + dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
            this.Report.Bands[BandKind.PageFooter].Controls["xrLabelUser"].Text = DB.casUser.Name;
            this.Report.Bands[BandKind.ReportHeader].Controls["xrLabelTanggal"].Text = tanggal;
         //   this.Report.Bands[BandKind.ReportFooter].Controls["xrLabelUser"].Text = DB.casUser.ToString()  ;
        }

        private void FrmLPPNPembelian_Load(object sender, EventArgs e)
        {
            dtpTglAwal.DateTime = Utility.FirstDateInMonth(DateTime.Now.Date);
            dtpTglAkhir.DateTime = DateTime.Now.Date;
            if (this.Tag.ToString() == "6d6")
                this.ReportName = "RepBukuPembelianPajak";


            else
               this.ReportName = "RepPPNPembelian";
           // txtAccAwal.ExSqlQuery = "select acc as `Kode Akun`, name as `Keterangan` from acc where detil=0";
        }


    }
}
    


