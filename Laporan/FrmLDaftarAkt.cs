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
    public partial class FrmLDaftarAkt : BaseLaporan
    {
        public FrmLDaftarAkt()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                CollectData();
                ProcessData();
                LoadReport();
                UpdateReport();
                PreviewReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmLDaftarAkt_Load(object sender, EventArgs e)
        {
            dtpTglAkhir.DateTime = DateTime.Now.Date;
            this.ReportName = "RepDaftarAktiva";
        }

        private void CollectData()
        {
            string tglAkhir = dtpTglAkhir.DateTime.ToString("yyyyMMdd");

            dtResult = new DataTable();
            string query = "";
            query = "Call SP_DaftarAkt(@datez)";

            // replace params
            query = query.Replace("@datez", tglAkhir);
            dtResult = DB.sql.Select(query);
        }

        private void ProcessData()
        {
            
        }

        private void UpdateReport()
        {
            string tanggal = dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
            string bln = tanggal.Substring(3, 2);
            string thn = tanggal.Substring(6, 4);
            string bulan = "";
            switch (bln) 
            {
                case "01" : bulan = "Januari"; break;
                case "02" : bulan = "Februari"; break;
                case "03" : bulan = "Maret"; break;
                case "04" : bulan = "April"; break;
                case "05" : bulan = "Mei"; break;
                case "06" : bulan = "Juni"; break;
                case "07" : bulan = "Juli"; break;
                case "08" : bulan = "Agustus"; break;
                case "09" : bulan = "September"; break;
                case "10" : bulan = "Oktober"; break;
                case "11" : bulan = "November"; break;
                case "12" : bulan = "Desember"; break;
            }
            this.Report.Bands[BandKind.ReportHeader].Controls["xrLabel1"].Text = "s/d Bulan " + bulan + " " + thn;
            /*if (this.Tag.ToString() == "6541")
                this.Report.Bands[BandKind.ReportHeader].Controls["xrLabel2"].Text = "Buku Besar Global";
            else
                this.Report.Bands[BandKind.ReportHeader].Controls["xrLabel2"].Text = "Buku Besar Pembantu Detil";*/
        }
    }
}