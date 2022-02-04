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
    public partial class FrmLNeracaSaldo : BaseLaporan
    {
        public FrmLNeracaSaldo()
        {
            InitializeComponent();
            txtarea.ExSqlQuery = "select 'KIAS' as `Kode Akun`, '' Keterangan union select 'JETI','' union select 'ALL','' ";
         
            Utility.SetSqlInstance(pnlFilter, DB.sql);
        }

        private void FrmLNeracaSaldo_Load(object sender, EventArgs e)
        {
            dateDate1.DateTime = Utility.FirstDateInMonth(DB.loginDate.Date);
            dateDate2.DateTime = Utility.LastDateInMonth(DB.loginDate.Date);
            this.ReportName = "RepLNeracaSaldo";
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
            string query = "Call SP_trial(" + dateDate1.DateTime.ToString("yyyyMMdd") + "," + dateDate2.DateTime.AddDays(1).ToString("yyyyMMdd") + "," + spinLvl.Value.ToString() + ")";
            dtResult = DB.sql.Select(query);
        }

        private void UpdateReport()
        {
            string periode1 = dateDate1.DateTime.ToString("MMMM yyyy");
            string periode2 = dateDate2.DateTime.ToString("MMMM yyyy");
            string periode3 = periode1;
            if (periode1 != periode2) periode3 += " - " + periode2;
            this.Report.Bands[BandKind.ReportHeader].Controls["xrLabel1"].Text = "Periode : "+periode3.Trim();
            this.Report.Bands[BandKind.ReportHeader].Controls["xrLabelTanggal"].Text = dateDate1.DateTime.ToString("dd/MM/yyyy") + " - " + dateDate2.DateTime.ToString("dd/MM/yyyy");
            this.Report.Bands[BandKind.PageFooter].Controls["xrLabelUser"].Text = DB.casUser.User;
        }
    }
}