using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KASLibrary;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;

namespace CAS.Transaction
{
    public partial class FrmJournalEntry : XtraForm
    {
        public FrmJournalEntry()
        {
            InitializeComponent();
            periodTextEdit.Text = DB.loginPeriod;
            DataTable dt = DB.sql.Select("CALL SP_JournalEntries('"+DB.loginPeriod+"','1')");
            gridControl1.DataSource = dt;

            DataTable dt2 = DB.sql.Select("CALL SP_JournalEntries('" + DB.loginPeriod + "','2')");
            gridControl2.DataSource = dt2;

        
            gridView1.GroupFooterShowMode = GroupFooterShowMode.VisibleAlways;
            // Create and setup the first summary item.
            GridGroupSummaryItem item = new GridGroupSummaryItem();
            item.FieldName = "D";
            item.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            item.DisplayFormat = "{0:c2}";
            item.ShowInGroupColumnFooter = D;
            gridView1.GroupSummary.Add(item);
            // Create and setup the second summary item.
            GridGroupSummaryItem item1 = new GridGroupSummaryItem();
            item1.FieldName = "K";
            item1.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            item1.DisplayFormat = "{0:c2}";
            item1.ShowInGroupColumnFooter = K;
            gridView1.GroupSummary.Add(item1);

            GridGroupSummaryItem item5 = new GridGroupSummaryItem();            
            item5.FieldName = "cct";
            item5.SummaryType = DevExpress.Data.SummaryItemType.Max;
            item5.DisplayFormat = "TOTAL";
            item5.ShowInGroupColumnFooter = cct;
            gridView1.GroupSummary.Add(item5);

            gridView1.Columns["name"].Width = 130;
            gridView1.Columns["cct"].Width = 30;
            gridView1.Columns["acc"].Width = 55;
            gridView2.Columns["name"].Width = 120;
            gridView2.Columns["acc"].Width = 55;
            
             GridView View = gridView2;

// Create and setup the first summary item. 
GridGroupSummaryItem item2 = new GridGroupSummaryItem();
item2.FieldName = "D";
item2.SummaryType = DevExpress.Data.SummaryItemType.Sum;
item2.DisplayFormat = "Sum = {0}";
// Add the summary item to the collection 
View.GroupSummary.Add(item2);
// Create and setup the second summary item 
GridGroupSummaryItem item3 = new GridGroupSummaryItem();
item3.FieldName = "K";
item3.SummaryType = DevExpress.Data.SummaryItemType.Sum;
item3.DisplayFormat = "Sum = {0:c2}";
item3.ShowInGroupColumnFooter = View.Columns["K"];
// Add the summary item to the collection 
View.GroupSummary.Add(item3);

        }

             private void periodTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime tglawal = Utility.FirstDateInMonth(DB.loginDate);
            DateTime tglakhir = Utility.LastDateInMonth(DB.loginDate);

            string query = "Call SP_LJurnal(" + tglawal.ToString("yyyMMdd") + "," + tglakhir.ToString("yyyyMMdd") + ",'ADJ','ADJ')";
            DataTable dtResult = DB.sql.Select(query);

            // add column Saldo
            dtResult.Columns.Add("saldo", typeof(double));

            double saldo = 0;
            string jurnal = "";

            foreach (DataRow drResult in dtResult.Rows)
            {
                if (jurnal != drResult["jurnal"].ToString())
                    saldo = 0;

                // loop dtResult, fill in Saldo
                if (drResult["dk"].ToString() == "D")
                {
                    saldo += (double)drResult["debet"];
                    drResult["saldo"] = saldo;
                }
                else
                {
                    saldo -= (double)drResult["kredit"];
                    drResult["saldo"] = saldo;
                }
                jurnal = drResult["jurnal"].ToString();
            }

            string path = Application.StartupPath + "\\Reports\\" + "RepJurnal" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = dtResult;
            string tanggal = "Tanggal: " + tglawal.ToString("dd/MM/yyyy") + " - " + tglakhir.ToString("dd/MM/yyyy");
            report.Bands[BandKind.ReportHeader].Controls["xrTanggal"].Text = tanggal;
            report.Bands[BandKind.ReportHeader].Controls["xrLabel2"].Text = "Laporan Jurnal Entry";
            report.ShowPreview();
        }

    }
}

