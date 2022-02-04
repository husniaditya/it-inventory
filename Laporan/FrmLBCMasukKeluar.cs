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
    public partial class FrmLBCMasukKeluar : CAS.Laporan.BaseLaporan
    {
        public FrmLBCMasukKeluar()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
          
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                CollectData();
                if (this.Tag.ToString() == "6i1")
                {
                    if (DB.casUser.User =="sherly")  
                        this.ReportName = "LapBCPemasukanPO";
                    else
                        this.ReportName = "LapBCPemasukan";
                }
                else
                {
                    this.ReportName = "LapBCPengeluaran";
                }

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
            string docAwal = DB.GetRangeValue(textboxexbca, textboxexbcb, 0);
            string docAkhir = DB.GetRangeValue(textboxexbca, textboxexbcb, 1);
            string inva = DB.GetRangeValue(txtInvAwal, txtInvAkhir , 0);
            string invz = DB.GetRangeValue(txtInvAwal, txtInvAkhir , 1);
            string jnsa = DB.GetRangeValue(jnspaTextBoxEx, jnspzTextBoxEx, 0);
            string jnsz = DB.GetRangeValue(jnspaTextBoxEx, jnspzTextBoxEx, 1);

           
            string query="";
            dtResult = new DataTable();
            if (this.Tag.ToString() == "6i1")
            {
                if (checkweb.Checked)
                    query = "Call Sp_BC_penerimaanWeb(@tglawal, @tglakhir, '@subawal','@subakhir','@invawal','@invakhir','@doca','@docz','@jnsa','@jnsz')";
                else
                    query = "Call Sp_BC_penerimaan(@tglawal, @tglakhir, '@subawal','@subakhir','@invawal','@invakhir','@doca','@docz','@jnsa','@jnsz')";
            }
            else
            {
                if (checkweb.Checked)                  
                    query = "Call Sp_BC_pengeluaranWeb(@tglawal, @tglakhir, '@subawal','@subakhir','@invawal','@invakhir','@doca','@docz','@jnsa','@jnsz')";
                else
                    query = "Call Sp_BC_pengeluaran(@tglawal, @tglakhir, '@subawal','@subakhir','@invawal','@invakhir','@doca','@docz','@jnsa','@jnsz')";

            }
            // replace params
            query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir);
            query = query.Replace("@subawal", subAwal).Replace("@subakhir", subAkhir);
            query = query.Replace("@invawal", inva).Replace("@invakhir", invz);
            query = query.Replace("@doca", docAwal).Replace("@docz", docAkhir);
            query = query.Replace("@jnsa", jnsa).Replace("@jnsz", jnsz);
            dtResult = DB.sql.Select(query);       
        }

        private void UpdateData()
        {
          
        }

        private void UpdateReport()
        {
           // this.Report.Bands[BandKind.ReportHeader].Controls["xrLabelTanggal"].Text = dtpTglAwal.DateTime.ToString("dd/MM/yyyy") + " - " + dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
        //    this.Report.Bands[BandKind.PageFooter].Controls["xrLabelUser"].Text = DB.casUser.User;
              string tanggal = dtpTglAwal.DateTime.ToString("dd/MM/yyyy") + " - " + dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
              this.Report.Bands[BandKind.PageHeader].Controls["lblperiod"].Text = tanggal;       
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
        }

        private void FrmLBCMasukKeluar_Load(object sender, EventArgs e)
        {
            dtpTglAwal.DateTime = dtpTglAkhir.DateTime = DB.loginDate;
            if (this.Tag.ToString() == "6i1")
            {
                txtSubAwal.ExSqlQuery = "Call SP_LookUp('supplier')";
                txtSubAkhir.ExSqlQuery = "Call SP_LookUp('supplier')";
                textboxexbca.ExSqlQuery = "select no_bc 'docp',datedoc Tanggal,remmark Keterangan,docp Doc from docpd";
                textboxexbcb.ExSqlQuery = "select no_bc 'docp',datedoc Tanggal,remmark Keterangan,docp Doc from docpd";
                label2.Text = "Supplier";
            }
            else
            {
                textboxexbca.ExSqlQuery = "select no_bc 'docp',datedoc Tanggal,remmark Keterangan,docp Doc from docpd";
                textboxexbcb.ExSqlQuery = "select no_bc 'docp',datedoc Tanggal,remmark Keterangan,docp Doc from docpd";
                txtSubAwal.ExSqlQuery = "Call SP_LookUp('customer')";
                txtSubAkhir.ExSqlQuery = "Call SP_LookUp('customer')";
                label2.Text = "Customer";
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

       
       
    }
}

