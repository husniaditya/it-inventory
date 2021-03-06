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
    public partial class FrmLStatusDO : CAS.Laporan.BaseLaporan
    {
        public FrmLStatusDO()
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
                if (this.Tag.ToString() == "63331")
                    this.ReportName = "RepLStatusDO";
                else
                    this.ReportName = "RepLDO";
                

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
            string invAwal = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 0);
            string invAkhir = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 1);
            string omsAwal = DB.GetRangeValue(txtOmsAwal, txtOmsAkhir, 0);
            string omsAkhir = DB.GetRangeValue(txtOmsAwal, txtOmsAkhir, 1);
           
            string query="";
            dtResult = new DataTable();
            if (this.Tag.ToString() == "63331")
                query = "Call SP_LapDO(@tglawal, @tglakhir, '@subawal','@subakhir','@oklawal','@oklakhir','@doa','@doz','@inva','@invz',@grup,2)";
            else
                query = "Call SP_LapDO(@tglawal, @tglakhir, '@subawal','@subakhir','@oklawal','@oklakhir','@doa','@doz','@inva','@invz',@grup,1)";
            
            // replace params
            query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir);
            query = query.Replace("@subawal", subAwal).Replace("@subakhir", subAkhir);
            query = query.Replace("@oklawal", oklAwal).Replace("@oklakhir", oklAkhir);
            query = query.Replace("@inva", invAwal).Replace("@invz", invAkhir);
            query = query.Replace("@doa", omsAwal).Replace("@doz", omsAkhir);
            query = query.Replace("@grup", rgStatusPO.EditValue.ToString());
            //query = query.Replace("@period", DB.loginPeriod);
            dtResult = DB.sql.Select(query);       
        }

        private void UpdateData()
        {
          
        }

        private void UpdateReport()
        {
            
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

        private void textboxexoklb_EditValueChanged(object sender, EventArgs e)
        {
            string pokla = textboxexokla.Text;
            string poklb = textboxexoklb.Text;
            if (pokla == "" && poklb == "")
                poklb = "Z";
            else
            {
                if (pokla == "")
                    pokla = poklb;
                if (poklb == "")
                    poklb = pokla;
            }
            txtOmsAwal.ExSqlQuery = txtOmsAkhir.ExSqlQuery = "select doh as `No DO`, `date` as Tanggal, remark as Keterangan from doh where `delete`=0 and okl between '" + pokla + "' and '" + poklb + "'";
        }

        private void txtOmsAwal_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textboxexokla_EditValueChanged(object sender, EventArgs e)
        {
            string pokla = textboxexokla.Text;
            string poklb = textboxexoklb.Text;
            if (pokla == "" && poklb == "")
                poklb = "Z";
            else
            {
                if (pokla == "")
                    pokla = poklb;
                if (poklb == "")
                    poklb = pokla;
            }
            txtOmsAwal.ExSqlQuery = txtOmsAkhir.ExSqlQuery = "select doh as `No DO`, `date` as Tanggal, remark as Keterangan from doh where `delete`=0 and okl between '" + pokla + "' and '" + poklb + "'";

        }

        private void txtOmsAkhir_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

