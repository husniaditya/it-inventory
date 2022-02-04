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
    public partial class FrmLGiro : CAS.Laporan.BaseLaporan
    {
        public FrmLGiro()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
        }

        private void FrmLGiro_Load(object sender, EventArgs e)
        {
            dtpTglAwal.DateTime = Utility.FirstDateInMonth(DB.loginDate);
            dtpTglAkhir.DateTime = Utility.LastDateInMonth(DB.loginDate);
            jtdateEdit2.DateTime = Utility.LastDateInMonth(DB.loginDate);

            rgStatus.SelectedIndex = 2;
            rgJenis.SelectedIndex = 2;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                CollectData();
                this.ReportName = "RepLGiro";
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
            string accAwal = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 0);
            string accAkhir = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 1);
            string subAwal = DB.GetRangeValue(txtSubAwal, txtSubAkhir, 0);
            string subAkhir = DB.GetRangeValue(txtSubAwal, txtSubAkhir, 1);
            string giroAwal = DB.GetRangeValue(nobgEx1, nobgEx2, 0);
            string giroAkhir = DB.GetRangeValue(nobgEx1, nobgEx2, 1);
            string jtawal = jtdateEdit1.DateTime.ToString("yyyyMMdd");
            string jtakhir = jtdateEdit2.DateTime.ToString("yyyyMMdd");

            dtResult = new DataTable();
            string query ="";
            if (this.Tag.ToString() == "6c1")
                query = "call SP_LapGiro2('@accawal','@accakhir',@tglawal,@tglakhir,@group,@status,'1','@subawal','@subakhir','@giroawal','@giroakhir','@jtawal','@jtakhir');";
            else
               query = "call SP_LapGiro1('@accawal','@accakhir',@tglawal,@tglakhir,@group,@status,'2','@subawal','@subakhir','@giroawal','@giroakhir');";
      
            // replace params
            query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir);
            query = query.Replace("@accawal", accAwal).Replace("@accakhir", accAkhir);
            query = query.Replace("@group", (rgStatus.SelectedIndex+1).ToString());
            query = query.Replace("@status", (rgJenis.SelectedIndex + 1).ToString());
            query = query.Replace("@subawal", subAwal).Replace("@subakhir", subAkhir);
            query = query.Replace("@giroawal", giroAwal).Replace("@giroakhir", giroAkhir);
            query = query.Replace("@jtawal", jtawal).Replace("@jtakhir", jtakhir);
       
            dtResult = DB.sql.Select(query);
        }

        private void UpdateReport()
        {
            string periode1 = dtpTglAwal.DateTime.ToString("MMMM yyyy");
            string periode2 = dtpTglAkhir.DateTime.ToString("MMMM yyyy");
            string periode3 = periode1;
            if (periode1 != periode2) periode3 += " - " + periode2;
            this.Report.Bands[BandKind.ReportHeader].Controls["xrLabelPeriode"].Text = "Periode : " + periode3;
            this.Report.Bands[BandKind.ReportHeader].Controls["xrLabelTanggal"].Text = dtpTglAwal.DateTime.ToString("dd/MM/yyyy") + " - " + dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
            this.Report.Bands[BandKind.PageFooter].Controls["xrLabelUser"].Text = DB.casUser.User;
        }

        private void rgJenis_SelectedIndexChanged(object sender, EventArgs e)
        {
   
            switch (rgJenis.SelectedIndex.ToString())
            {
                case "0":
                    labelJudul.Text = "Customer";
                    txtSubAkhir.ExSqlQuery = txtSubAwal.ExSqlQuery = "call SP_Lookup('customer')";
                    break;
                case "1":
                    labelJudul.Text = "Supplier";
                    txtSubAkhir.ExSqlQuery = txtSubAwal.ExSqlQuery = "call SP_Lookup('supplier')";
                    break;
                case "2":
                    labelJudul.Text = "Cust / Sup.";
                    txtSubAkhir.ExSqlQuery = txtSubAwal.ExSqlQuery = "call SP_Lookup('sub')";
                    break;

            }
            refreshnobg();            
        }

        private void refreshnobg()
        {
            string subAwal = DB.GetRangeValue(txtSubAwal, txtSubAkhir, 0);
            string subAkhir = DB.GetRangeValue(txtSubAwal, txtSubAkhir, 1);
            nobgEx1.ExSqlQuery = nobgEx2.ExSqlQuery = "select nobg,kas.kas,sub.name from kag,kas,sub where kas.kas=kag.kas and kas.sub=sub.sub " +
            " and  kas.date >= " + dtpTglAwal.DateTime.ToString("yyyyMMdd") + " and  kas.date < adddate(" + dtpTglAkhir.DateTime.ToString("yyyyMMdd") + ",1)" +
            " and kas.sub between '" + subAwal + "' and '" + subAkhir + "'";
        }

        private void txtSubAwal_EditValueChanged(object sender, EventArgs e)
        {
            refreshnobg();
        }

        private void txtSubAkhir_EditValueChanged(object sender, EventArgs e)
        {

            refreshnobg();

        }
    }
}