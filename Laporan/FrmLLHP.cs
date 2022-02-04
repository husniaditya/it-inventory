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
    public partial class FrmLLHP : BaseLaporan
    {
        public FrmLLHP()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
        }

        private void FrmLLHP_Load(object sender, EventArgs e)
        {
            //dateDate1.DateTime = Utility.FirstDateInMonth(DB.loginDate.Date);
            //dateDate2.DateTime = Utility.LastDateInMonth(DB.loginDate.Date);
            dateDate1.DateTime = dateDate2.DateTime = DB.loginDate;
            switch (this.Tag.ToString())
            {
                case "6ad1":
                    this.ReportName = "RepLLHP"; break;
                case "6ad2":
                    this.ReportName = "RepLLHPTanpaNilai"; break;
                case "6ad3":
                    this.ReportName = "RepLLHPTanpaNilaiMesin"; break;
                case "6ad4":
                    this.ReportName = "RepLLHPTanpaNilaiCct"; break;
                case "6ae1":
                    this.ReportName = "RepLBPPB"; break;
                case "6ae2":
                    this.ReportName = "RepLBPPBTanpaNilai"; break;
                case "6ae3":
                    this.ReportName = "RepRekapBPPBTL"; break;
                case "6ag":
                    this.ReportName = "RepLJIN"; break;
            }
            switch (this.Tag.ToString())
            {
                case "6ad1":
                case "6ad2":
                    panelLhp.Visible = true;
                    label6.Text = "LHP";
                    txtLHPAwal.ExSqlQuery = "Call SP_LookUp('lhp')";
                    txtLHPAkhir.ExSqlQuery = "Call SP_LookUp('lhp')";
                    txtLHPAwal.ExDialogTitle = txtLHPAkhir.ExDialogTitle = "Laporan Hasil Produksi";
                    txtLHPAwal.ExFieldName = txtLHPAkhir.ExFieldName = "LHP";
                    break;
                case "6ae1":
                case "6ae2":
                    panelLhp.Visible = false;
                    pnlFilter.Height = 170;
                    label6.Text = "BPPB";
                    txtLHPAwal.ExSqlQuery = "Call SP_LookUp('bppb')";
                    txtLHPAkhir.ExSqlQuery = "Call SP_LookUp('bppb')";
                    txtLHPAwal.ExDialogTitle = txtLHPAkhir.ExDialogTitle = "Bukti Pengeluaran Pemakaian Bahan";
                    txtLHPAwal.ExFieldName = txtLHPAkhir.ExFieldName = "BPPB";
                    break;
                case "6ae3":
                    dateDate2.DateTime = Utility.LastDateInMonth(DB.loginDate.Date);
                    dateDate1.DateTime = Utility.FirstDateInMonth(dateDate2.DateTime.AddMonths(-5));
                    //panelLhp.Visible = true;
                    //label3.Visible = false;
                    //radioGroup1.Visible = false;
                    //pnlFilter.Height = 220;
                    checkBox1.Visible = true;
                    label6.Text = "BPPB";
                    txtLHPAwal.ExSqlQuery = "Call SP_LookUp('bppb')";
                    txtLHPAkhir.ExSqlQuery = "Call SP_LookUp('bppb')";
                    txtLHPAwal.ExDialogTitle = txtLHPAkhir.ExDialogTitle = "Bukti Pengeluaran Pemakaian Bahan";
                    txtLHPAwal.ExFieldName = txtLHPAkhir.ExFieldName = "BPPB";
                    break;
                case "6ag":
                    panelLhp.Visible = false;
                    pnlFilter.Height = 170;
                    label6.Text = "Koreksi";
                    txtLHPAwal.ExSqlQuery = "Call SP_LookUp('jin')";
                    txtLHPAkhir.ExSqlQuery = "Call SP_LookUp('jin')";
                    txtLHPAwal.ExDialogTitle = txtLHPAkhir.ExDialogTitle = "Koreksi Persediaan";
                    txtLHPAwal.ExFieldName = txtLHPAkhir.ExFieldName = "jin";
                    break;
            }
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
            string msnAwal = DB.GetRangeValue(txtmesinAwal, txtmesinAkhir, 0);
            string msnAkhir = DB.GetRangeValue(txtmesinAwal, txtmesinAkhir, 1);
            string cctAwal = DB.GetRangeValue(txtcctAwal, txtcctAkhir, 0);
            string cctAkhir = DB.GetRangeValue(txtcctAwal, txtcctAkhir, 1);
            string lhpAwal = DB.GetRangeValue(txtLHPAwal, txtLHPAkhir, 0);
            string lhpAkhir = DB.GetRangeValue(txtLHPAwal, txtLHPAkhir, 1); 

            string query = "";
            switch (this.Tag.ToString())
            {
                case "6ad1":
                    query += "Call SP_LhpOut1(";
                    query += dateDate1.DateTime.ToString("yyyyMMdd") + "," + dateDate2.DateTime.AddDays(1).ToString("yyyyMMdd") + ",'" + locAwal + "','" + locAkhir + "','" + invAwal + "','" + invAkhir + "','" + lhpAwal + "','" + lhpAkhir + "','" + msnAwal + "','" + msnAkhir + "','" + cctAwal + "','" + cctAkhir + "'," + radioGroup1.EditValue.ToString() + ")";
                    break;
                case "6ad2":
                case "6ad3":
                case "6ad4":
                    query += "Call SP_LhpOut(";
                    query += dateDate1.DateTime.ToString("yyyyMMdd") + "," + dateDate2.DateTime.AddDays(1).ToString("yyyyMMdd") + ",'" + locAwal + "','" + locAkhir + "','" + invAwal + "','" + invAkhir + "','" + lhpAwal + "','" + lhpAkhir + "','" + msnAwal + "','" + msnAkhir + "','" + cctAwal + "','" + cctAkhir + "',"+radioGroup1.EditValue.ToString()+ ")";
                    break;
                case "6ae1":
                case "6ae2":
                    query += "Call SP_LBPPB(";
                    query += dateDate1.DateTime.ToString("yyyyMMdd") + "," + dateDate2.DateTime.AddDays(1).ToString("yyyyMMdd") + ",'" + locAwal + "','" + locAkhir + "','" + invAwal + "','" + invAkhir + "','" + lhpAwal + "','" + lhpAkhir + "','" + cctAwal + "','" + cctAkhir + "')";
                    break;
                case "6ae3":
                    int nol = 0;
                    if (checkBox1.Checked)
                        nol = 1;
                    else
                        nol = 0;
                    if (radioGroup1.EditValue.ToString() == "0")
                    {
                        query += "Call SP_LBPPBTLperMonth(";
                        query += dateDate1.DateTime.ToString("yyyyMMdd") + "," + dateDate2.DateTime.AddDays(1).ToString("yyyyMMdd") + ",'" + locAwal + "','" + locAkhir + "','" + invAwal + "','" + invAkhir + "','" + lhpAwal + "','" + lhpAkhir + "','" + cctAwal + "','" + cctAkhir + "','" + msnAwal + "','" + msnAkhir + "'," + nol + ")";
                    }
                    else
                    {
                        query += "Call SP_LBPPBTLperMonth_Besar(";
                        query += dateDate1.DateTime.ToString("yyyyMMdd") + "," + dateDate2.DateTime.AddDays(1).ToString("yyyyMMdd") + ",'" + locAwal + "','" + locAkhir + "','" + invAwal + "','" + invAkhir + "','" + lhpAwal + "','" + lhpAkhir + "','" + cctAwal + "','" + cctAkhir + "','" + msnAwal + "','" + msnAkhir + "'," + nol + ")";

                    }
                    break; 
                case "6ag":
                    query += "Call SP_LJIN(";
                    query += dateDate1.DateTime.ToString("yyyyMMdd") + "," + dateDate2.DateTime.AddDays(1).ToString("yyyyMMdd") + ",'" + locAwal + "','" + locAkhir + "','" + invAwal + "','" + invAkhir + "','" + lhpAwal + "','" + lhpAkhir + "','" + cctAwal + "','" + cctAkhir + "')";
                    break;
            }
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
            if (this.Tag.ToString() == "6ae3")
            {
                dateDate1.DateTime = Utility.FirstDateInMonth(dateDate2.DateTime.AddMonths(-5));
                dateDate1.Enabled = false;
                panelLhp.Visible = true;
                pnlFilter.Height = 220;
                label6.Text = "BPPB";
                txtLHPAwal.ExSqlQuery = "Call SP_LookUp('bppb')";
                txtLHPAkhir.ExSqlQuery = "Call SP_LookUp('bppb')";
                txtLHPAwal.ExDialogTitle = txtLHPAkhir.ExDialogTitle = "Bukti Pengeluaran Pemakaian Bahan";
                txtLHPAwal.ExFieldName = txtLHPAkhir.ExFieldName = "BPPB";
            }
        }
    }
}