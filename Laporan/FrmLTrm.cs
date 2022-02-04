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
    public partial class FrmLTrm : BaseLaporan
    {
        public FrmLTrm()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
        }

        private void FrmLTrm_Load(object sender, EventArgs e)
        {
            //dateDate1.DateTime = Utility.FirstDateInMonth(DB.loginDate.Date);
            //dateDate2.DateTime = Utility.LastDateInMonth(DB.loginDate.Date);
            dateDate1.DateTime = dateDate2.DateTime = DB.loginDate;
            this.ReportName = "RepLBPPB";
            dateDate2.DateTime = Utility.LastDateInMonth(DB.loginDate.Date);
            dateDate1.DateTime = Utility.FirstDateInMonth(dateDate2.DateTime.AddMonths(-5));
            panelLhp.Visible = false;
            //label3.Visible = false;
            //radioGroup1.Visible = false;
            //pnlFilter.Height = 220;
            checkBox1.Visible = true;
            label6.Text = "BPB";
            txtLHPAwal.ExSqlQuery = "Call SP_LookUp('bpb')";
            txtLHPAkhir.ExSqlQuery = "Call SP_LookUp('bpb')";
            txtLHPAwal.ExDialogTitle = txtLHPAkhir.ExDialogTitle = "Bukti Pemindahan Barang";
            txtLHPAwal.ExFieldName = txtLHPAkhir.ExFieldName = "BPB";
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
            dtResult = new DataTable();
            string locAwal = DB.GetRangeValue(txtLocAwal, txtLocAkhir, 0);
            string locAkhir = DB.GetRangeValue(txtLocAwal, txtLocAkhir, 1);
            string invAwal = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 0);
            string invAkhir = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 1);
            string cctAwal = DB.GetRangeValue(txtcctAwal, txtcctAkhir, 0);
            string cctAkhir = DB.GetRangeValue(txtcctAwal, txtcctAkhir, 1);
            string lhpAwal = DB.GetRangeValue(txtLHPAwal, txtLHPAkhir, 0);
            string lhpAkhir = DB.GetRangeValue(txtLHPAwal, txtLHPAkhir, 1); 

            string query = "";
            query += "Call SP_LBPB(";
            query += dateDate1.DateTime.ToString("yyyyMMdd") + "," + dateDate2.DateTime.AddDays(1).ToString("yyyyMMdd") + ",'" + locAwal + "','" + locAkhir + "','" + invAwal + "','" + invAkhir + "','" + lhpAwal + "','" + lhpAkhir + "','" + cctAwal + "','" + cctAkhir + "')";
            dtResult = DB.sql.Select(query);
        }

        private void UpdateReport()
        {
            string periode1 = dateDate1.DateTime.ToString("MMMM yyyy");
            string periode2 = dateDate2.DateTime.ToString("MMMM yyyy");
            string periode3 = periode1;
            if (periode1 != periode2) periode3 += " - " + periode2;
            this.Report.Bands[BandKind.ReportHeader].Controls["xrLabelPeriode"].Text = "Periode : " + periode3;
            this.Report.Bands[BandKind.ReportHeader].Controls["xrLabelTanggal"].Text = dateDate1.DateTime.ToString("dd/MM/yyyy") + " - " + dateDate2.DateTime.ToString("dd/MM/yyyy");
            this.Report.Bands[BandKind.PageFooter].Controls["xrLabelUser"].Text = DB.casUser.User;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void dateDate2_EditValueChanged(object sender, EventArgs e)
        {
            dateDate1.DateTime = Utility.FirstDateInMonth(dateDate2.DateTime.AddMonths(-5));
            //dateDate1.Enabled = false;
            panelLhp.Visible = true;
            pnlFilter.Height = 220;
            label6.Text = "BPB";
            txtLHPAwal.ExSqlQuery = "Call SP_LookUp('bpb')";
            txtLHPAkhir.ExSqlQuery = "Call SP_LookUp('bpb')";
            txtLHPAwal.ExDialogTitle = txtLHPAkhir.ExDialogTitle = "Bukti Pemindahan Barang";
            txtLHPAwal.ExFieldName = txtLHPAkhir.ExFieldName = "BPB";
        }
    }
}