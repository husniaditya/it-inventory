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
    public partial class FrmLHistoryMemo : CAS.Laporan.BaseLaporan
    {
        public FrmLHistoryMemo()
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

            dtResult = new DataTable();
            string query = "";          
            query = "Call SP_LapHistoryMPR(@tglawal, @tglakhir, '@prqawal','@prqakhir')";             
            // replace params
            query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir);
            query = query.Replace("@prqawal", prqAwal).Replace("@prqakhir", prqAkhir);
            //query = query.Replace("@period", DB.loginPeriod);
            dtResult = DB.sql.Select(query);
        }

        private void UpdateReport()
        {
           
            string periode1 = dtpTglAwal.DateTime.ToString("dd/MM/yyyy");
            string periode2 = dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
            this.Report.Bands[BandKind.ReportHeader].Controls["xrLabel1"].Text = "Periode : " + periode1 + " s/d " + periode2;
          //  this.Report.Bands[BandKind.PageFooter].Controls["xrLabelUser"].Text = DB.casUser.Name;
            
        }

        private void FrmLHistoryMemo_Load(object sender, EventArgs e)
        {
            dtpTglAwal.DateTime = Utility.FirstDateInMonth(DB.loginDate);
            dtpTglAkhir.DateTime = Utility.LastDateInMonth(DB.loginDate);
            this.ReportName = "RepHistoryMPR";
            txtPrqAwal.ExSqlQuery = txtPrqAkhir.ExSqlQuery = "select Mpr as `Memo PR`, `date` as Tanggal, remark as Keterangan from mpr where `delete`=0";
          
              
           
        }


    }
}

