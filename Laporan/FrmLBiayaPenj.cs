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
    public partial class FrmLBiayaPenj : CAS.Laporan.BaseLaporan
    {
        public FrmLBiayaPenj()
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
           
                this.ReportName = "repoklbiaya";
                

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
            string oklAwal = DB.GetRangeValue(textboxexokla, textboxexoklb, 0);
            string oklAkhir = DB.GetRangeValue(textboxexokla, textboxexoklb, 1);
            string AccAwal = DB.GetRangeValue(txtAccAwal, txtAccAkhir, 0);
            string AccAkhir = DB.GetRangeValue(txtAccAwal, txtAccAkhir, 1);
           
            string query="";
            dtResult = new DataTable();
            query = "Call Sp_BiayaPenj(@tglawal, @tglakhir, '@subawal','@subakhir','@oklawal','@oklakhir','@accawal','@accakhir')";
            
            // replace params
            query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir);
            query = query.Replace("@subawal", subAwal).Replace("@subakhir", subAkhir);
            query = query.Replace("@oklawal", oklAwal).Replace("@oklakhir", oklAkhir);
            query = query.Replace("@accawal", AccAwal).Replace("@accakhir", AccAkhir);
            dtResult = DB.sql.Select(query);       
        }

        private void UpdateData()
        {
          
        }

        private void UpdateReport()
        {
           // this.Report.Bands[BandKind.ReportHeader].Controls["xrLabelTanggal"].Text = dtpTglAwal.DateTime.ToString("dd/MM/yyyy") + " - " + dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
            this.Report.Bands[BandKind.PageFooter].Controls["xrLabelUser"].Text = DB.casUser.User;
            string tanggal = dtpTglAwal.DateTime.ToString("dd/MM/yyyy") + " - " + dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
            this.Report.Bands[BandKind.ReportHeader].Controls["xrPeriode"].Text = tanggal;
            this.Report.Bands[BandKind.ReportHeader].Controls["xrNoSo"].Text = textboxexokla.Text.ToString() + " s/d " + textboxexoklb.Text.ToString();
            this.Report.Bands[BandKind.ReportHeader].Controls["xrAcc"].Text = txtAccAwal.ExLabelText + " s/d " + txtAccAkhir.ExLabelText ;

        }

        private void FrmLHistoryPO_Load(object sender, EventArgs e)
        {
           
        }

        private void txtSubAwal_EditValueChanged(object sender, EventArgs e)
        {
            string psuba = txtSubAwal.Text;
            string psubb = txtSubAkhir.Text;
            if (psuba == "" && psubb == "")
              psubb = "Z";
            else
            {
                if (psuba == "")
                    psuba = psubb;
                if (psubb == "")
                    psubb = psuba;
            }
            textboxexokla.ExSqlQuery = textboxexoklb.ExSqlQuery = "select okl as `No SO`, `date` as Tanggal, remark as Keterangan from okl where `delete`=0 and `date`>=" + dtpTglAwal.DateTime.ToString("yyyyMMdd") + " and `date` <" + dtpTglAkhir.DateTime.ToString("yyyyMMdd") + " and sub between '" + psuba + "' and '" + psubb + "'";
        }

       private void txtSubAkhir_EditValueChanged(object sender, EventArgs e)
       {
            string psuba = txtSubAwal.Text;
            string psubb = txtSubAkhir.Text;
            if (psuba == "" && psubb == "")
                psubb = "Z";
            else
            {
                if (psuba == "")
                    psuba = psubb;
                if (psubb == "")
                    psubb = psuba;
            }
           textboxexokla.ExSqlQuery = textboxexoklb.ExSqlQuery = "select okl as `No SO`, `date` as Tanggal, remark as Keterangan from okl where `delete`=0 and `date`>=" + dtpTglAwal.DateTime.ToString("yyyyMMdd") + " and `date` <" + dtpTglAkhir.DateTime.ToString("yyyyMMdd") + " and sub between '" + txtSubAwal.Text + "' and '" + txtSubAkhir.Text + "'";
        }

       
       
    }
}

