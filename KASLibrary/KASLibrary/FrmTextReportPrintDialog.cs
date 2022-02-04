using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KASLibrary
{
    public partial class FrmTextReportPrintDialog : Form
    {
        private TextReport report;
        private DataTable tblSource;
        private int maxPage;
        private string content;

        /// <summary>
        /// TextReport Print Dialog
        /// </summary>
        /// <param name="report">the report</param>
        /// <param name="tblSource">the report source</param>
        /// <param name="maxPage">the maximum page that can be printed</param>
        public FrmTextReportPrintDialog(TextReport report,DataTable tblSource,int maxPage)
        {
            InitializeComponent();
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                cmbPrinterName.Items.Add(printer);
                if (printer.ToLower().Contains("epson l"))
                    cmbPrinterName.SelectedItem = printer;
            }
            this.report = report;
            this.tblSource = tblSource;
            this.maxPage = maxPage;
            txtStartPage.Text = "1";
            txtEndPage.Text = maxPage.ToString();  
        }

        public FrmTextReportPrintDialog(string content, int maxPage)
        {
            InitializeComponent();
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                cmbPrinterName.Items.Add(printer);
                if (printer.ToLower().Contains("epson l"))
                    cmbPrinterName.SelectedItem = printer;
            }
            this.report = null;
            this.tblSource = null;
            this.content = content;
            this.maxPage = maxPage;
            txtStartPage.Text = "1";
            txtEndPage.Text = maxPage.ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (cmbPrinterName.Text == "") 
            {
                MessageBox.Show("Select your printer!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }  
            int startPage = 1;
            int endPage = maxPage;
            if (rbRange.Checked)
            {
                try
                {
                    startPage = int.Parse(txtStartPage.Text);
                    endPage = int.Parse(txtEndPage.Text);
                }
                catch
                {
                    MessageBox.Show("Range only accept numbers such as 1 or 5!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (startPage < 1) startPage = 1;
                if (endPage > maxPage) endPage = maxPage;   
            }
            //report.Print(tblSource, cmbPrinterName.SelectedItem.ToString(), startPage, endPage);
            if (tblSource != null)
            {
                //Use DataTable (standard)
                report.Print(tblSource, cmbPrinterName.SelectedItem.ToString(), startPage, endPage);
            }
            else
            {
                //Do not use DataTable such as TraceResult
                PrintStringContent(cmbPrinterName.SelectedItem.ToString(), startPage, endPage);
            }
            this.Close(); 
        }

        private void rbRange_CheckedChanged(object sender, EventArgs e)
        {
            txtStartPage.Enabled = rbRange.Checked;
            txtEndPage.Enabled = rbRange.Checked;  
        }

        private void PrintStringContent(string printerName, int startPage, int endPage)
        {
            string[] pages = content.Split((char)12);

            string result = "";
            for (int i = startPage; i <= endPage; i++)
            {
                //Remove the last \r\n of a page and change it with page break
                string page = pages[i - 1];
                page = page.TrimEnd(' ');
                if (page.EndsWith("\r\n"))
                    page = page.Substring(0, page.Length - 2);

                result += page + ((char)12).ToString();
            }

            byte[] arr = new byte[result.Length];
            for (int i = 0; i < result.Length; i++)
            {
                arr[i] = (byte)result[i];
            }

            Printer printer = new Printer(printerName);
            printer.PrintBytes(arr);
        }
    }
}