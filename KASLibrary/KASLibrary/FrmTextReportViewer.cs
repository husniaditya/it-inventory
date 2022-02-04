using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace KASLibrary
{
    public partial class FrmTextReportViewer : Form
    {
        private TextReport report;
        private DataTable tblSource;
        private string content;
        private string[] pages;
        private Font font = new Font("Lucida Console", 8);
        private int charWidth;
        private int charHeight;
        private int documentWidth;
        private int documentHeight;
        private Bitmap bitmap;

        public FrmTextReportViewer(string stringContent)
        {
            InitializeComponent();
            this.report = null;
            this.tblSource = null;
            content = stringContent;
            Initialize();
        }

        public FrmTextReportViewer(TextReport report,DataTable tblSource)
        {
            InitializeComponent();
            this.report = report;
            this.tblSource = tblSource; 
            this.report.UsePrinterControl = false;
            content = this.report.Generate(tblSource);
            Initialize();
        }

        private void Initialize()
        {
            content = content.Replace("\r\n", "\n");
            content = content.Substring(0, content.LastIndexOf((char)12));
            pages = content.Split((char)12);
            
            Graphics g = Graphics.FromHwnd(this.Handle);
            SizeF s = g.MeasureString("A", font);
            charWidth = (int)s.Width;
            charHeight = (int)s.Height;
            if (report != null)
            {
                documentWidth = charWidth * this.report.TotalColumn;
                documentHeight = charHeight * this.report.TotalRow;
            }
            else
            {
                int maxWidth = 0;
                int maxHeight = 0;
                foreach (string page in pages)
                {
                    string[] lines = page.Split('\n');
                    if (lines.Length > maxHeight) maxHeight = lines.Length;
                    foreach (string line in lines)
                    {
                        if (line.Length > maxWidth) maxWidth = line.Length;
                    }
                }
                documentWidth = charWidth * maxWidth;
                documentHeight = charHeight * maxHeight;
            }
            bitmap = new Bitmap(documentWidth, documentHeight);
            bitmap.SetResolution(120, 72);
            pctDocument.Image = bitmap;
            pctDocument.Top = 0;
            pctDocument.Left = 0;

            txtPage.Value = 1;
            txtPage.Minimum = 1;
            txtPage.Maximum = pages.Length;
            lblPage.Text = "/" + pages.Length;

            vScrollBar1.Maximum = pctDocument.Height - pnlDocument.Height + 50;
            hScrollBar1.Maximum = pctDocument.Width - pnlDocument.Width + 50;
            Draw();    
        }

        private void Draw()
        {
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
            string[] lines = pages[(int)txtPage.Value-1].Split('\n');
            int row = 0;
            foreach (string line in lines)
            {
                if (line.ToLower().Contains(txtFind.Text.ToLower()))
                {
                    g.FillRectangle(Brushes.Yellow, line.ToLower().IndexOf(txtFind.Text.ToLower()) * charWidth,
                        row * charHeight, txtFind.Text.Length * charWidth, charHeight);
                }
                for (int col = 0; col < line.Length; col++)
                {
                    Point point = new Point(col * charWidth, row * charHeight);  
                    g.DrawString(line[col].ToString(), font, Brushes.Black, point);
                }
                row++;
            }
            pctDocument.Refresh();  
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            pctDocument.Top = -vScrollBar1.Value;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            pctDocument.Left = -hScrollBar1.Value;
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            txtPage.Value = txtPage.Minimum;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (txtPage.Value > txtPage.Minimum)
            {
                txtPage.Value--;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (txtPage.Value < txtPage.Maximum)
            {
                txtPage.Value++;
            }
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            txtPage.Value = txtPage.Maximum;
        }

        private void txtPage_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //FrmTextReportPrintDialog frm = new FrmTextReportPrintDialog(report,tblSource,(int)txtPage.Maximum);
            //frm.ShowDialog();
            if (this.tblSource != null)
            {
                //Use DataTable (standard)
                FrmTextReportPrintDialog frm = new FrmTextReportPrintDialog(report, tblSource, (int)txtPage.Maximum);
                frm.ShowDialog();
            }
            else
            {
                //No DataTable such as from TraceResult
                FrmTextReportPrintDialog frm = new FrmTextReportPrintDialog(content, (int)txtPage.Maximum);
                frm.ShowDialog();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)  | *.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = File.CreateText(saveFileDialog.FileName);
                string textContent = content.Replace("\n", "\r\n");
                sw.Write(textContent); 
                sw.Close();
                MessageBox.Show("Report is exported successfully.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            int curpage = (int)txtPage.Value;
            while (curpage < txtPage.Maximum)
            {
                curpage++;
                if (pages[curpage - 1].ToLower().Contains(txtFind.Text.ToLower()))
                {
                    txtPage.Value = curpage;
                    this.Cursor = Cursors.Default;
                    return;
                }
            }
            txtPage.Value = curpage;
            this.Cursor = Cursors.Default;
            MessageBox.Show("End of report has been reached!", "Warning", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            Draw();
        }
    }
}