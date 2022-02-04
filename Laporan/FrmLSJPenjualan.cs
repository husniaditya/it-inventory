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
    public partial class FrmLSJPenjualan : CAS.Laporan.BaseLaporan
    {
        public FrmLSJPenjualan()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
            dtpTglAwal.DateTime = Utility.FirstDateInMonth(DateTime.Today);
            dtpTglAkhir.DateTime = Utility.LastDateInMonth(DateTime.Today);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                CollectData();
                if (this.Tag.ToString() == "63381") 
                    this.ReportName = "RepSJPenjualan";
                else
                    if (this.Tag.ToString() == "63383")
                        this.ReportName = "RepSJPerSOBarang";
                     else
                        if (this.Tag.ToString() == "6d7")
                            this.ReportName = "RepSJPajak";
                        else
                           this.ReportName = "RepSJPerPersediaan";
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
            string tglAwal, tglAkhir, invAwal, invAkhir, subAwal, subAkhir, dsgAwal, dsgAkhir;
            string query;
            query = "";
            tglAwal = dtpTglAwal.DateTime.ToString("yyyyMMdd");
            tglAkhir = dtpTglAkhir.DateTime.ToString("yyyyMMdd");
            invAwal = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 0);
            invAkhir = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 1);
            subAwal = DB.GetRangeValue(txtSubAwal, txtSubAkhir, 0);
            subAkhir = DB.GetRangeValue(txtSubAwal, txtSubAkhir, 1);
            dsgAwal = DB.GetRangeValue(txtDsgAwal, txtDsgAkhir, 0);
            dsgAkhir = DB.GetRangeValue(txtDsgAwal, txtDsgAkhir, 1);
            string doAwal = DB.GetRangeValue(txtOmsAwal, txtOmsAkhir, 0);
            string doAkhir = DB.GetRangeValue(txtOmsAwal, txtOmsAkhir, 1);

            dtResult = new DataTable();
            if (this.Tag.ToString() == "6d7")
              query = "Call SP_LapSJPenjualanPajak(@tglawal,@tglakhir,'@subawal','@subakhir','@dsgawal','@dsgakhir','@invawal','@invakhir')";
            else
              query = "Call SP_LapSJPenjualan(@tglawal,@tglakhir,'@subawal','@subakhir','@dsgawal','@dsgakhir','@invawal','@invakhir','@doawal','@doakhir')";
            // replace params
            query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir);
            query = query.Replace("@subawal", subAwal).Replace("@subakhir", subAkhir);
            query = query.Replace("@invawal", invAwal).Replace("@invakhir", invAkhir);
            query = query.Replace("@dsgawal", dsgAwal).Replace("@dsgakhir", dsgAkhir);
            query = query.Replace("@doawal", doAwal).Replace("@doakhir", doAwal);

            dtResult = DB.sql.Select(query);
        }

        private void UpdateReport()
        {
            string periode = "Periode: " + dtpTglAwal.DateTime.ToString("dd/MM/yyyy") + " - " + dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
            this.Report.Bands[BandKind.ReportHeader].Controls["xrLabel1"].Text = periode;
            this.Report.Bands[BandKind.PageFooter].Controls["xrLabelUser"].Text = DB.casUser.Name;
      
        }

        private void txtOmsAwal_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDsgAwal_EditValueChanged(object sender, EventArgs e)
        {
            string pokla = txtDsgAwal.Text;
            string poklb = txtDsgAkhir.Text;
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

        private void txtDsgAkhir_EditValueChanged(object sender, EventArgs e)
        {
            string pokla = txtDsgAwal.Text;
            string poklb = txtDsgAkhir.Text;
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
    }
}

