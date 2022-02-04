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
    public partial class FrmLNeraca : BaseLaporan
    {
        public FrmLNeraca()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
        }

        private void FrmLNeraca_Load(object sender, EventArgs e)
        {
            dateDate1.DateTime = Utility.FirstDateInMonth(DB.loginDate.Date);
            dateDate2.DateTime = Utility.LastDateInMonth(DB.loginDate.Date);
            switch (this.Tag.ToString())
            {
                case "6561":
                    this.ReportName = "RepLNeraca";
                    break;
                case "6571":
                    this.ReportName = "RepLLabaRugi";
                    break;
                case "6e1":
                    this.ReportName = "RepBOP";
                    this.spinLvl.Visible = false;
                    this.Level.Visible = false;
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
            string query = "";
            switch (this.Tag.ToString())
            {
                case "6561":
                    query = "Call SP_neraca(" + dateDate1.DateTime.ToString("yyyyMMdd") + "," + dateDate2.DateTime.AddDays(1).ToString("yyyyMMdd") + "," + spinLvl.Value.ToString() + ")";
                    break;
                case "6571":
                    query = "Call SP_rugilaba(" + dateDate1.DateTime.ToString("yyyyMMdd") + "," + dateDate2.DateTime.AddDays(1).ToString("yyyyMMdd") + "," + spinLvl.Value.ToString() + ")";
                    break;
                case "6e1":
                    query = "Call SP_BOP('" + dateDate1.DateTime.ToString("yyMM")+ "',1)";
                    break;
            }
            dtResult = DB.sql.Select(query);
        }

        private void UpdateReport()
        {
            if (this.Tag.ToString() != "6e1")
            {
                string periode1 = dateDate1.DateTime.ToString("MMMM yyyy");
                string periode2 = dateDate2.DateTime.ToString("MMMM yyyy");
                string periode3 = periode1;
                if (periode1 != periode2) periode3 += " - " + periode2;
                this.Report.Bands[BandKind.ReportHeader].Controls["xrLabelPeriode"].Text = "Periode : " + periode3;
                this.Report.Bands[BandKind.ReportHeader].Controls["xrLabelTanggal"].Text = dateDate1.DateTime.ToString("dd/MM/yyyy") + " - " + dateDate2.DateTime.ToString("dd/MM/yyyy");
                this.Report.Bands[BandKind.PageFooter].Controls["xrLabelUser"].Text = DB.casUser.User;
            }
        }
    }
}