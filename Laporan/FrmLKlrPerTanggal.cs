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
    public partial class FrmLKlrPerTanggal : CAS.Laporan.BaseLaporan
    {
        public FrmLKlrPerTanggal()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
        }

        private void FrmLKlrPerTanggal_Load(object sender, EventArgs e)
        {
            dtpTglAwal.DateTime = Utility.FirstDateInMonth(DateTime.Now.Date);
            dtpTglAkhir.DateTime = Utility.LastDateInMonth(DateTime.Now.Date);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                CollectData();
                if (this.Tag.ToString() == "6d8")
                    this.ReportName = "RepKlrPajak";
                else
                    this.ReportName = "RepKlr";

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
            string klrA = DB.GetRangeValue(textpjlawal, textpjlakhir, 0);
            string klrZ = DB.GetRangeValue(textpjlawal, textpjlakhir, 1);
            string rklA = DB.GetRangeValue(textretawal, textretakhir, 0);
            string rklZ = DB.GetRangeValue(textretawal, textretakhir, 1);
            string invAwal = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 0);
            string invAkhir = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 1);
            
            string jenis = radioGroup1.EditValue.ToString();  
            dtResult = new DataTable();
            string query = "Call SP_KlrOut(@tglawal,@tglakhir,'@subawal','@subakhir','@Pinva','@Pinvz','@klra','@klrz','@rkla','@rklz','@jenis')";
            if (this.Tag.ToString() == "6d8")
            {
                query = "Call SP_KlrOutPajak1(@tglawal,@tglakhir,'@subawal','@subakhir','@Pinva','@Pinvz','@klra','@klrz','@rkla','@rklz','@jenis')";
            }
            // replace params
            query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir);
            query = query.Replace("@subawal", subAwal).Replace("@subakhir", subAkhir);
            query = query.Replace("@klra", klrA).Replace("@klrz", klrZ);
            query = query.Replace("@rkla", rklA).Replace("@rklz", rklZ);
            query = query.Replace("@Pinva", invAwal).Replace("@Pinvz", invAkhir);
            query = query.Replace("@jenis", jenis);
           
            dtResult = DB.sql.Select(query);
        }

        private void UpdateReport()
        {
            string tanggal = "Tanggal: " + dtpTglAwal.DateTime.ToString("dd/MM/yyyy") + " - " + dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
            string supplier = "Supplier: " + txtSubAwal.Text + " - " + txtSubAkhir.Text;
           
            string periode1 = dtpTglAwal.DateTime.ToString("MMMM yyyy");
            string periode2 = dtpTglAkhir.DateTime.ToString("MMMM yyyy");
            string periode3 = periode1;
            if (periode1 != periode2) periode3 += " - " + periode2;
            this.Report.Bands[BandKind.ReportHeader].Controls["xrLabel6"].Text = "Periode : " + periode3;
            this.Report.Bands[BandKind.ReportHeader].Controls["xrLabel1"].Text = dtpTglAwal.DateTime.ToString("dd/MM/yyyy") + " - " + dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
            this.Report.Bands[BandKind.PageFooter].Controls["xrLabelUser"].Text = DB.casUser.Name;
        }

        private void txtSubAwal_EditValueChanged(object sender, EventArgs e)
        {
            string subA = DB.GetRangeValue(txtSubAwal, txtSubAkhir, 0);
            string subZ = DB.GetRangeValue(txtSubAwal, txtSubAkhir, 1);
            string queryklr = "select klr,date,remark from klr where sub between ?psuba and ?psubz order by klr";
            // replace params
            queryklr = queryklr.Replace("?psuba", subA).Replace("?psubz", subZ);
         
            textpjlawal.ExSqlQuery = queryklr;
            textpjlakhir.ExSqlQuery = queryklr;

            string queryrkl = "select rkl,date,remark from rkl where sub between ?psuba and ?psubz order by rkl";
            // replace params
            queryrkl = queryrkl.Replace("?psuba", subA).Replace("?psubz", subZ);

            textretawal.ExSqlQuery = queryrkl;
            textretakhir.ExSqlQuery = queryrkl;
        }

        private void txtSubAkhir_EditValueChanged(object sender, EventArgs e)
        {
            string subA = DB.GetRangeValue(txtSubAwal, txtSubAkhir, 0);
            string subZ = DB.GetRangeValue(txtSubAwal, txtSubAkhir, 1);
            string queryklr = "select klr,date,remark from klr where sub between ?psuba and ?psubz order by klr";
            // replace params
            queryklr = queryklr.Replace("?psuba", subA).Replace("?psubz", subZ);

            textpjlawal.ExSqlQuery = queryklr;
            textpjlakhir.ExSqlQuery = queryklr;

            string queryrkl = "select rkl,date,remark from rkl where sub between ?psuba and ?psubz order by rkl";
            // replace params
            queryrkl = queryrkl.Replace("?psuba", subA).Replace("?psubz", subZ);

            textretawal.ExSqlQuery = queryrkl;
            textretakhir.ExSqlQuery = queryrkl;
        }
    }
}