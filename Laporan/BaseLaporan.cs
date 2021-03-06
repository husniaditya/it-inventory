using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.XtraEditors;
using KASLibrary;

namespace CAS.Laporan
{
    public partial class BaseLaporan : XtraForm
    {
        protected DataTable dtResult;

        private string reportName;

        public string ReportName
        {
            get { return reportName; }
            set { reportName = value; }
        }

        private XtraReport xrReport;

        public XtraReport Report
        {
            set { xrReport = value; }
            get { return xrReport; }
        }
	
        public BaseLaporan()
        {
            InitializeComponent();
            dtResult = new DataTable();
            reportName = "";
            xrReport = new XtraReport();
            ToolBarButton tsbtnHide = new ToolBarButton();
            tsbtnHide.Name = "tsbtnHide";
            tsbtnHide.ToolTipText = "Hide Filters";
            tsbtnHide.ImageIndex = 19;
            
            printPreviewBar.Buttons.Add(tsbtnHide);
            printPreviewBar.ButtonClick += new ToolBarButtonClickEventHandler(printPreviewBar_ButtonClick);

            try { Utility.ApplySkin(this); }
            catch { }
        }

        void printPreviewBar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            if (e.Button.Name == "tsbtnHide" && e.Button.ToolTipText == "Hide Filters")
            {
                pnlFilter.Hide();
                e.Button.ToolTipText = "Show Filters";
            }
            else if (e.Button.Name == "tsbtnHide" && e.Button.ToolTipText == "Show Filters")
            {
                pnlFilter.Show();
                e.Button.ToolTipText = "Hide Filters";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected void LoadReport()
        {
            
            
            string path = Application.StartupPath + "\\Reports\\" + reportName + ".repx";
            if (!System.IO.File.Exists(path))
                throw new Exception("Error! Report " + reportName + " does not exist!");

            if (reportName == "RepSJPajak" | ReportName == "RepBOP")
            {
                xrReport = new XtraReport();
                xrReport.LoadState(path);
                xrReport.DataSource = dtResult;
                Image img = Image.FromFile(Application.StartupPath + "\\logo.gif");
                int lebar = 300;
                int tinggi = 210;
                if ((Report.Bands[BandKind.PageHeader] != null && Report.Bands[BandKind.PageHeader].Controls["xrPictureBox1"] != null))
                {
                    ((XRPictureBox)(Report.Bands[BandKind.PageHeader].Controls["xrPictureBox1"])).ImageUrl = (Application.StartupPath + "\\logo.gif");
                    ((XRPictureBox)(Report.Bands[BandKind.PageHeader].Controls["xrPictureBox1"])).Width = lebar;
                    ((XRPictureBox)(Report.Bands[BandKind.PageHeader].Controls["xrPictureBox1"])).Height = tinggi;
                    ((XRPictureBox)(Report.Bands[BandKind.PageHeader].Controls["xrPictureBox1"])).Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
                    int left = ((XRPictureBox)(Report.Bands[BandKind.PageHeader].Controls["xrPictureBox1"])).Left;
                    Report.Bands[BandKind.PageHeader].Controls["xrLabel3"].Left = img.Width + left + 100;
                    Report.Bands[BandKind.PageHeader].Controls["xrLabel4"].Left = img.Width + left + 100;
                    Report.Bands[BandKind.PageHeader].Controls["xrLabel5"].Left = img.Width + left + 100;
                    Report.Bands[BandKind.PageHeader].Controls["xrLabel5"].Width = 1500;
                    Report.Bands[BandKind.PageHeader].Controls["xrLabel4"].Width = 1200;
                    Report.Bands[BandKind.PageHeader].Controls["xrLabel5"].Text = Utility.GetConfig("CompanyName");
                    Report.Bands[BandKind.PageHeader].Controls["xrLabel4"].Text = Utility.GetConfig("CompanyAddr");
                    Report.Bands[BandKind.PageHeader].Controls["xrLabel3"].Text = Utility.GetConfig("CompanyContact");
                }
                if (Report.Bands[BandKind.ReportHeader].Controls["xrPictureBox1"] != null)
                {
                    ((XRPictureBox)(Report.Bands[BandKind.ReportHeader].Controls["xrPictureBox1"])).ImageUrl = (Application.StartupPath + "\\logo.gif");
                    ((XRPictureBox)(Report.Bands[BandKind.ReportHeader].Controls["xrPictureBox1"])).Width = lebar;
                    ((XRPictureBox)(Report.Bands[BandKind.ReportHeader].Controls["xrPictureBox1"])).Height = tinggi;
                    ((XRPictureBox)(Report.Bands[BandKind.ReportHeader].Controls["xrPictureBox1"])).Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
                    //int left = ((XRPictureBox)(Report.Bands[BandKind.PageHeader].Controls["xrPictureBox1"])).Left;
                    //Report.Bands[BandKind.PageHeader].Controls["xrLabel3"].Left = img.Width + left + 10;
                    //Report.Bands[BandKind.PageHeader].Controls["xrLabel4"].Left = img.Width + left + 10;
                    //Report.Bands[BandKind.PageHeader].Controls["xrLabel5"].Left = img.Width + left + 10;
                    Report.Bands[BandKind.ReportHeader].Controls["xrLabel5"].Width = 500;
                    Report.Bands[BandKind.ReportHeader].Controls["xrLabel4"].Width = 400;
                    Report.Bands[BandKind.ReportHeader].Controls["xrLabel5"].Text = Utility.GetConfig("CompanyName");
                    Report.Bands[BandKind.ReportHeader].Controls["xrLabel4"].Text = Utility.GetConfig("CompanyAddr");
                    Report.Bands[BandKind.ReportHeader].Controls["xrLabel3"].Text = Utility.GetConfig("CompanyContact");

                }
            }

            else if (reportName == "RepJurnal")
            {
                xrReport = new XtraReport();
                xrReport.LoadState(path);
                xrReport.DataSource = dtResult;
                Image img = Image.FromFile(Application.StartupPath + "\\logo.gif");
                int lebar = 100;
                int tinggi = 70;
                if ((Report.Bands[BandKind.PageHeader] != null && Report.Bands[BandKind.PageHeader].Controls["xrPictureBox1"] != null))
                {
                    ((XRPictureBox)(Report.Bands[BandKind.PageHeader].Controls["xrPictureBox1"])).ImageUrl = (Application.StartupPath + "\\logo.gif");
                    ((XRPictureBox)(Report.Bands[BandKind.PageHeader].Controls["xrPictureBox1"])).Width = lebar;
                    ((XRPictureBox)(Report.Bands[BandKind.PageHeader].Controls["xrPictureBox1"])).Height = tinggi;
                    ((XRPictureBox)(Report.Bands[BandKind.PageHeader].Controls["xrPictureBox1"])).Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
                    int left = ((XRPictureBox)(Report.Bands[BandKind.PageHeader].Controls["xrPictureBox1"])).Left;
                    Report.Bands[BandKind.PageHeader].Controls["xrLabel3"].Left = img.Width + left + 10;
                    Report.Bands[BandKind.PageHeader].Controls["xrLabel4"].Left = img.Width + left + 10;
                    Report.Bands[BandKind.PageHeader].Controls["xrLabel5"].Left = img.Width + left + 10;
                    Report.Bands[BandKind.PageHeader].Controls["xrLabel5"].Width = 500;
                    Report.Bands[BandKind.PageHeader].Controls["xrLabel4"].Width = 400;
                    Report.Bands[BandKind.PageHeader].Controls["xrLabel5"].Text = Utility.GetConfig("CompanyName");
                    Report.Bands[BandKind.PageHeader].Controls["xrLabel4"].Text = Utility.GetConfig("CompanyAddr");
                    Report.Bands[BandKind.PageHeader].Controls["xrLabel3"].Text = Utility.GetConfig("CompanyContact");
                }
                if (Report.Bands[BandKind.ReportHeader].Controls["xrPictureBox1"] != null)
                {
                    ((XRPictureBox)(Report.Bands[BandKind.ReportHeader].Controls["xrPictureBox1"])).ImageUrl = (Application.StartupPath + "\\logo.gif");
                    ((XRPictureBox)(Report.Bands[BandKind.ReportHeader].Controls["xrPictureBox1"])).Width = lebar;
                    ((XRPictureBox)(Report.Bands[BandKind.ReportHeader].Controls["xrPictureBox1"])).Height = tinggi;
                    ((XRPictureBox)(Report.Bands[BandKind.ReportHeader].Controls["xrPictureBox1"])).Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
                    //int left = ((XRPictureBox)(Report.Bands[BandKind.PageHeader].Controls["xrPictureBox1"])).Left;
                    //Report.Bands[BandKind.PageHeader].Controls["xrLabel3"].Left = img.Width + left + 10;
                    //Report.Bands[BandKind.PageHeader].Controls["xrLabel4"].Left = img.Width + left + 10;
                    //Report.Bands[BandKind.PageHeader].Controls["xrLabel5"].Left = img.Width + left + 10;
                    Report.Bands[BandKind.ReportHeader].Controls["xrLabel5"].Width = 500;
                    Report.Bands[BandKind.ReportHeader].Controls["xrLabel4"].Width = 400;
                    Report.Bands[BandKind.ReportHeader].Controls["xrLabel5"].Text = Utility.GetConfig("CompanyName");
                    Report.Bands[BandKind.ReportHeader].Controls["xrLabel4"].Text = Utility.GetConfig("CompanyAddr");
                    Report.Bands[BandKind.ReportHeader].Controls["xrLabel3"].Text = Utility.GetConfig("CompanyContact");

                }
            }
            else {
                xrReport = new XtraReport();
                xrReport.LoadState(path);
                xrReport.DataSource = dtResult;
                Image img = Image.FromFile(Application.StartupPath + "\\logo.gif");
                int lebar = 100;
                int tinggi = 70;
                if ((Report.Bands[BandKind.PageHeader] != null && Report.Bands[BandKind.PageHeader].Controls["xrPictureBox1"] != null))
                {
                    ((XRPictureBox)(Report.Bands[BandKind.PageHeader].Controls["xrPictureBox1"])).ImageUrl = (Application.StartupPath + "\\logo.gif");
                    ((XRPictureBox)(Report.Bands[BandKind.PageHeader].Controls["xrPictureBox1"])).Width = lebar;
                    ((XRPictureBox)(Report.Bands[BandKind.PageHeader].Controls["xrPictureBox1"])).Height = tinggi;
                    ((XRPictureBox)(Report.Bands[BandKind.PageHeader].Controls["xrPictureBox1"])).Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
                    //int left = ((XRPictureBox)(Report.Bands[BandKind.PageHeader].Controls["xrPictureBox1"])).Left;
                    //Report.Bands[BandKind.PageHeader].Controls["xrLabel3"].Left = img.Width + left + 10;
                    //Report.Bands[BandKind.PageHeader].Controls["xrLabel4"].Left = img.Width + left + 10;
                    //Report.Bands[BandKind.PageHeader].Controls["xrLabel5"].Left = img.Width + left + 10;
                    Report.Bands[BandKind.PageHeader].Controls["xrLabel5"].Width = 500;
                    Report.Bands[BandKind.PageHeader].Controls["xrLabel4"].Width = 400;
                    Report.Bands[BandKind.PageHeader].Controls["xrLabel5"].Text = Utility.GetConfig("CompanyName");
                    Report.Bands[BandKind.PageHeader].Controls["xrLabel4"].Text = Utility.GetConfig("CompanyAddr");
                    Report.Bands[BandKind.PageHeader].Controls["xrLabel3"].Text = Utility.GetConfig("CompanyContact");
                }
                if (Report.Bands[BandKind.ReportHeader].Controls["xrPictureBox1"] != null)
                {
                    ((XRPictureBox)(Report.Bands[BandKind.ReportHeader].Controls["xrPictureBox1"])).ImageUrl = (Application.StartupPath + "\\logo.gif");
                    ((XRPictureBox)(Report.Bands[BandKind.ReportHeader].Controls["xrPictureBox1"])).Width = lebar;
                    ((XRPictureBox)(Report.Bands[BandKind.ReportHeader].Controls["xrPictureBox1"])).Height = tinggi;
                    ((XRPictureBox)(Report.Bands[BandKind.ReportHeader].Controls["xrPictureBox1"])).Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
                    //int left = ((XRPictureBox)(Report.Bands[BandKind.ReportHeader].Controls["xrPictureBox1"])).Left;
                    //Report.Bands[BandKind.ReportHeader].Controls["xrLabel3"].Left = lebar + left + 10;
                    //Report.Bands[BandKind.ReportHeader].Controls["xrLabel4"].Left = lebar + left + 10;
                    //Report.Bands[BandKind.ReportHeader].Controls["xrLabel5"].Left = lebar + left + 10;
                    Report.Bands[BandKind.ReportHeader].Controls["xrLabel5"].Width = 500;
                    Report.Bands[BandKind.ReportHeader].Controls["xrLabel4"].Width = 400;
                    Report.Bands[BandKind.ReportHeader].Controls["xrLabel5"].Text = Utility.GetConfig("CompanyName");
                    Report.Bands[BandKind.ReportHeader].Controls["xrLabel4"].Text = Utility.GetConfig("CompanyAddr");
                    Report.Bands[BandKind.ReportHeader].Controls["xrLabel3"].Text = Utility.GetConfig("CompanyContact");

                }
            }           
        }

        protected void PreviewReport()
        {
            printingSystem.ClearContent();
            if (dtResult.Rows.Count != 0)
            {
                xrReport.PrintingSystem = printingSystem;
                xrReport.CreateDocument();
            }
            else
                MessageBox.Show("No data found");
        }

        private void pnlFilter_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}