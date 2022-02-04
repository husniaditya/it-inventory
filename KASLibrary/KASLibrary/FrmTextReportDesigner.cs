using System;
using System.Collections; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;  
using System.Text;
using System.Windows.Forms;
using System.IO;
using KASLibrary;

namespace KASLibrary
{
    public partial class FrmTextReportDesigner : Form
    {
        public TextReport report;
        private int documentWidth;
        private int documentHeight;
        private Bitmap bitmap;
        private int charWidth;
        private int charHeight;
        private bool putMode = false;
        private string putType = ""; //text, symbol, field
        private string putText = "";
        public DataTable table;
        private Font font = new Font("Lucida Console", 10); 
        private bool onCut = false;
        private bool onCopy = false;
        private bool onPaste = false;
        private Point copyPoint1 = new Point(-1,-1);
        private Point copyPoint2 = new Point(-1,-1);
        private int mouseX;
        private int mouseY;
        

        public FrmTextReportDesigner(DataTable table)
        {
            InitializeComponent();
            report = new TextReport();
            report.GenerateBar = pbGenerateReport;
            this.table = table;
            ArrangeControls(); 
            Draw();
        }
        public void ArrangeControls()
        {
            Graphics g = Graphics.FromHwnd(this.Handle);
            SizeF s = g.MeasureString("A", font);
            charWidth = (int)s.Width;
            charHeight = (int)s.Height;
            documentWidth = charWidth * report.TotalColumn;
            documentHeight = charHeight * report.TotalRow;
            bitmap = new Bitmap(documentWidth, documentHeight);
            bitmap.SetResolution(120, 72);
            pctDocument.Image = bitmap;
            pctDocument.Top = 0;
            pctDocument.Left = 0;
   
            vScrollBar1.Left = panDocument.Right;
            vScrollBar1.Minimum = 0;
            if (pctDocument.Width - panDocument.Width + 50 > vScrollBar1.Minimum)
                vScrollBar1.Maximum = pctDocument.Width - panDocument.Width + 50;
            else
                vScrollBar1.Maximum = vScrollBar1.Minimum;  
            vScrollBar1.Value = 0;
            hScrollBar1.Minimum = 0;
            if (pctDocument.Width - panDocument.Width + 50 > hScrollBar1.Minimum)
                hScrollBar1.Maximum = pctDocument.Width - panDocument.Width + 50;
            else
                hScrollBar1.Maximum = hScrollBar1.Minimum;
            hScrollBar1.Value = 0;

            panRightControls.Left = this.Width - panRightControls.Width - 10;
            UpdateUIFromReport();

            if (lstField.Items.Count == 0)
            {
                TextReportField f;
                f = new TextReportField();
                f.Name = "@pg#";
                f.Alignment = "RIGHT";
                f.Size = 4;
                lstField.Items.Add(f);
                report.Fields.Add(f);

                f = new TextReportField();
                f.Name = "@r#";
                f.Alignment = "RIGHT";
                f.Size = 4;
                lstField.Items.Add(f);
                report.Fields.Add(f);
            }
        }

        public void Draw()
        {
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);

            #region Draw Color Region
            if (chkColorRegion.Checked)
            {
                g.FillRectangle(Brushes.AliceBlue, 0, 0, report.TotalColumn * charWidth,(report.ReportHeaderLine - 0) * charHeight);
                g.FillRectangle(Brushes.Lavender, 0, report.ReportHeaderLine * charHeight, report.TotalColumn * charWidth, (report.GroupHeaderLine - report.ReportHeaderLine) * charHeight);
                g.FillRectangle(Brushes.Khaki, 0, report.GroupHeaderLine * charHeight, report.TotalColumn * charWidth, (report.PageHeaderLine - report.GroupHeaderLine) * charHeight);
                g.FillRectangle(Brushes.LightPink, 0, report.PageHeaderLine * charHeight, report.TotalColumn * charWidth, (report.DetailLine - report.PageHeaderLine) * charHeight);
                g.FillRectangle(Brushes.Khaki, 0, report.DetailLine * charHeight, report.TotalColumn * charWidth, (report.PageFooterLine - report.DetailLine) * charHeight);
                g.FillRectangle(Brushes.Lavender, 0, report.PageFooterLine * charHeight, report.TotalColumn * charWidth, (report.GroupFooterLine - report.PageFooterLine) * charHeight);
                g.FillRectangle(Brushes.AliceBlue, 0, report.GroupFooterLine * charHeight, report.TotalColumn * charWidth,(report.ReportFooterLine - report.GroupFooterLine) * charHeight);
            }
            #endregion
            #region Draw Cut/Copy Area
            if (copyPoint1.X != -1 && copyPoint2.X != -1)
            {
                Pen copyPen = new Pen(Brushes.Red, 4);
                if (onCopy) copyPen.Brush = Brushes.Blue;   
                copyPen.DashStyle = DashStyle.Dash;
                g.FillRectangle(Brushes.Gray, copyPoint1.X * charWidth, copyPoint1.Y * charHeight,
                    (copyPoint2.X - copyPoint1.X + 1) * charWidth, (copyPoint2.Y - copyPoint1.Y + 1) * charHeight);
                g.DrawRectangle(copyPen, copyPoint1.X * charWidth, copyPoint1.Y * charHeight,
                    (copyPoint2.X - copyPoint1.X + 1) * charWidth, (copyPoint2.Y - copyPoint1.Y + 1) * charHeight);                
            }
            #endregion
            #region Draw Grid
            if (chkShowGrid.Checked)
            {
                for (int i = 0; i < report.TotalColumn; i++)
                    g.DrawLine(Pens.LightGray, i * charWidth, 0, i * charWidth, documentHeight);                
                for (int i = 0; i < report.TotalRow; i++)
                    g.DrawLine(Pens.LightGray, 0, i * charHeight, documentWidth, i * charHeight);
            }
            #endregion
            #region Draw Region Lines
            Pen linePen = new Pen(Color.Blue,2);
            g.DrawLine(linePen, 0, report.ReportHeaderLine * charHeight, report.TotalColumn * charWidth, report.ReportHeaderLine * charHeight);
            g.DrawLine(linePen, 0, report.GroupFooterLine * charHeight, report.TotalColumn * charWidth, report.GroupFooterLine * charHeight);            
            linePen = new Pen(Color.Brown, 2);
            g.DrawLine(linePen, 0, report.GroupHeaderLine * charHeight, report.TotalColumn * charWidth, report.GroupHeaderLine * charHeight);
            g.DrawLine(linePen, 0, report.PageFooterLine * charHeight, report.TotalColumn * charWidth, report.PageFooterLine * charHeight);            
            linePen = new Pen(Color.Red, 2);
            g.DrawLine(linePen, 0, report.PageHeaderLine * charHeight, report.TotalColumn * charWidth, report.PageHeaderLine * charHeight);
            g.DrawLine(linePen, 0, report.DetailLine * charHeight, report.TotalColumn * charWidth, report.DetailLine * charHeight);
            linePen = new Pen(Color.Black, 2);
            g.DrawLine(linePen, 0, report.ReportFooterLine * charHeight, report.TotalColumn * charWidth, report.ReportFooterLine * charHeight);
            #endregion
            #region Draw Paper Width Lines 10CPI, 12CPI, 15CPI
            linePen = new Pen(Color.Black, 2);
            linePen.DashStyle = DashStyle.Dash;   
            g.DrawLine(linePen, 80 * charWidth, 0, 80 * charWidth, report.TotalRow * charHeight);
            g.DrawLine(linePen, 96 * charWidth, 0, 96 * charWidth, report.TotalRow * charHeight);
            g.DrawLine(linePen, 120 * charWidth, 0, 120 * charWidth, report.TotalRow * charHeight);
            #endregion
            #region Draw Split Lines
            if ((int)txtSplitColumn.Value != 0 && chkSplit.Checked)
            {
                linePen = new Pen(Color.Blue, 2);
                linePen.DashStyle = DashStyle.Dot;
                for(int i=1;i<=(int)txtSplitPage.Value;i++)
                    g.DrawLine(linePen, i * (int)txtSplitColumn.Value * charWidth, 0, 
                        i * (int)txtSplitColumn.Value * charWidth, report.TotalRow * charHeight);
               
            }
            #endregion
            #region Map
            for (int j = 0; j < report.TotalRow; j++)
                for (int i=0;i<report.TotalColumn;i++)
                {
                    if (report.Map[i, j] == '@')
                    {
                        TextReportField f = report.GetFieldAt(i, j);
                        if (f.Column.Trim() != "")//From database
                        {
                            if(f.Summary=="")//Normal database field 
                                g.FillRectangle(Brushes.LightGreen, i * charWidth, j * charHeight, f.Size * charWidth, charHeight);
                            else //Summary field
                                g.FillRectangle(Brushes.Cyan, i * charWidth, j * charHeight, f.Size * charWidth, charHeight);
                        }
                        else if (f.Name == "@pg#" || f.Name == "@r#")//Special variable
                        {
                            g.FillRectangle(Brushes.YellowGreen, i * charWidth, j * charHeight, f.Size * charWidth, charHeight);
                        }
                        else //Report variable
                        {
                            g.FillRectangle(Brushes.Yellow, i * charWidth, j * charHeight, f.Size * charWidth, charHeight);
                        }
                        
                    }
                    if (report.Controls[i, j] != null)
                    {
                        g.FillRectangle(Brushes.Yellow, i * charWidth+2, j * charHeight+2, charWidth-4, charHeight-4);
                    }
                    Point point = new Point(i * charWidth, j * charHeight); 
                    g.DrawString(report.Map[i, j].ToString(), font, Brushes.Black, point);
                }
            #endregion
            #region Put Helper
            if (putMode)
            {
                if (putType == "text" || putType == "field")
                {
                    g.DrawRectangle(Pens.DarkBlue, mouseX, mouseY, charWidth * putText.Length, charHeight);
                    g.DrawString(putText, font, Brushes.Black, mouseX,mouseY);
                }
            }
            #endregion
            pctDocument.Refresh();  
        }

        public void SetString(int col, int row, string x)
        {
            for (int i = 0; i < x.Length; i++)
                report.Map[col+i,row] = x[i];
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            pctDocument.Top = -e.NewValue;  
        }

        private void pctDocument_MouseDown(object sender, MouseEventArgs e)
        {
            int x = (int)(e.X / charWidth);
            int y = (int)(e.Y / charHeight);

            if (putMode && e.Button == MouseButtons.Left)
            {


                if (putType == "text")
                {
                    SetString(x, y, txtText.Text);
                    putMode = false;
                    this.Cursor = Cursors.Default;  
                }
                if(putType == "field")
                {
                    SetString(x, y, putText);
                    putMode = false;
                    this.Cursor = Cursors.Default;  
                }
                if (putType == "box")
                {
                    if (putText == "")
                    {
                        putText = x.ToString() + "," + y.ToString();  
                    }
                    else
                    {
                        int x1 = int.Parse(putText.Substring(0, putText.IndexOf(",")));
                        int y1 = int.Parse(putText.Substring(putText.IndexOf(",")+1));
                        DrawBox(x1, y1, x, y);
                        putText = "";
                    }
                }
                if (putType == "line")
                {
                    if (putText == "")
                    {
                        putText = x.ToString() + "," + y.ToString();
                    }
                    else
                    {
                        int x1 = int.Parse(putText.Substring(0, putText.IndexOf(",")));
                        int y1 = int.Parse(putText.Substring(putText.IndexOf(",") + 1));
                        DrawLine(x1, y1, x, y);
                        putText = "";
                    }
                }
                if (putType == "+control")
                {
                    string selectedControls = "";
                    foreach (string selectedControl in lstControl.SelectedItems)
                    {
                        selectedControls += selectedControl + ",";
                    }
                    selectedControls = selectedControls.Substring(0, selectedControls.Length-1);   
                    report.Controls[x, y] = selectedControls; 
                    putMode = false;
                    this.Cursor = Cursors.Default; 
                }
                if (putType == "-control")
                {
                    report.Controls[x, y] = null;
                    putMode = false;
                    this.Cursor = Cursors.Default;
                }
            }
            if (putMode && e.Button == MouseButtons.Right)
            {
                putMode = false;
                this.Cursor = Cursors.Default;
            }
            if ((onCopy || onCut) && e.Button == MouseButtons.Left)
            {
                if (copyPoint1.X == -1)
                {
                    copyPoint1 = new Point(x, y);
                }
                else if (copyPoint2.X == -1)
                {
                    copyPoint2 = new Point(x, y);
                    this.Cursor = Cursors.Default;
                }
            }
            if (onPaste && e.Button == MouseButtons.Left)
            {
                int w = copyPoint2.X - copyPoint1.X + 1;
                int h = copyPoint2.Y - copyPoint1.Y + 1;
                char[,] temp = new char[w, h];
                for (int i = 0; i < w; i++)
                    for (int j = 0; j < h; j++)
                        temp[i, j] = report.Map[copyPoint1.X + i, copyPoint1.Y + j];

                if (onCopy)
                {
                    for (int i = 0; i < w; i++)
                        for (int j = 0; j < h; j++)
                            report.Map[x + i, y + j] = temp[i, j];
                    onCopy = false;
                }
                if (onCut)
                {
                    for (int i = 0; i < w; i++)
                        for (int j = 0; j < h; j++)
                            report.Map[copyPoint1.X + i, copyPoint1.Y + j] = ' ';
                    for (int i = 0; i < w; i++)
                        for (int j = 0; j < h; j++)
                            report.Map[x + i, y + j] = temp[i, j];
                    onCut = false;
                }
                copyPoint1 = new Point(-1, -1);
                copyPoint2 = new Point(-1, -1); 
                onPaste = false;
                this.Cursor = Cursors.Default;
            }
            Draw(); 
        }

        private void DrawLine(int x1, int y1, int x2, int y2)
        {
            if (x1 == x2)
            {
                for (int i = y1; i <= y2; i++)
                    SetString(x1, i, ((char)5).ToString());
            }
            if (y1 == y2)
            {
                for (int i = x1; i <= x2; i++)
                    SetString(i, y1, ((char)6).ToString());
            }
        }

        private void DrawBox(int x1, int y1, int x2, int y2)
        {
            for (int i = x1+1; i < x2; i++)
            {
                switch (report.Map[i, y1])
                {
                    case (char)1: SetString(i, y1, ((char)22).ToString()); break;
                    case (char)2: SetString(i, y1, ((char)22).ToString()); break;
                    case (char)3: SetString(i, y1, ((char)21).ToString()); break;
                    case (char)4: SetString(i, y1, ((char)21).ToString()); break;
                    case (char)5: SetString(i, y1, ((char)16).ToString()); break;
                    case (char)21: SetString(i, y1, ((char)21).ToString()); break;
                    case (char)22: SetString(i, y1, ((char)22).ToString()); break;
                    case (char)23: SetString(i, y1, ((char)16).ToString()); break;
                    case (char)25: SetString(i, y1, ((char)16).ToString()); break;
                    case (char)16: SetString(i, y1, ((char)16).ToString()); break;
                    default: SetString(i, y1, ((char)6).ToString()); break;
                }
                switch (report.Map[i, y2])
                {
                    case (char)1: SetString(i, y2, ((char)22).ToString()); break;
                    case (char)2: SetString(i, y2, ((char)22).ToString()); break;
                    case (char)3: SetString(i, y2, ((char)21).ToString()); break;
                    case (char)4: SetString(i, y2, ((char)21).ToString()); break;
                    case (char)5: SetString(i, y2, ((char)16).ToString()); break;
                    case (char)21: SetString(i, y2, ((char)21).ToString()); break;
                    case (char)22: SetString(i, y2, ((char)22).ToString()); break;
                    case (char)23: SetString(i, y2, ((char)16).ToString()); break;
                    case (char)25: SetString(i, y2, ((char)16).ToString()); break;
                    case (char)16: SetString(i, y2, ((char)16).ToString()); break;
                    default: SetString(i, y2, ((char)6).ToString()); break;
                }
            }
            for (int j = y1+1; j < y2; j++)
            {
                switch (report.Map[x1, j])
                {
                    case (char)1: SetString(x1, j, ((char)25).ToString()); break;
                    case (char)2: SetString(x1, j, ((char)23).ToString()); break;
                    case (char)3: SetString(x1, j, ((char)25).ToString()); break;
                    case (char)4: SetString(x1, j, ((char)23).ToString()); break;
                    case (char)6: SetString(x1, j, ((char)16).ToString()); break;
                    case (char)21: SetString(x1, j, ((char)16).ToString()); break;
                    case (char)22: SetString(x1, j, ((char)16).ToString()); break;
                    case (char)23: SetString(x1, j, ((char)23).ToString()); break;
                    case (char)25: SetString(x1, j, ((char)25).ToString()); break;
                    case (char)16: SetString(x1, j, ((char)16).ToString()); break;
                    default: SetString(x1, j, ((char)5).ToString()); break;
                }
                switch (report.Map[x2, j])
                {
                    case (char)1: SetString(x2, j, ((char)25).ToString()); break;
                    case (char)2: SetString(x2, j, ((char)23).ToString()); break;
                    case (char)3: SetString(x2, j, ((char)25).ToString()); break;
                    case (char)4: SetString(x2, j, ((char)23).ToString()); break;
                    case (char)6: SetString(x2, j, ((char)16).ToString()); break;
                    case (char)21: SetString(x2, j, ((char)16).ToString()); break;
                    case (char)22: SetString(x2, j, ((char)16).ToString()); break;
                    case (char)23: SetString(x2, j, ((char)23).ToString()); break;
                    case (char)25: SetString(x2, j, ((char)25).ToString()); break;
                    case (char)16: SetString(x2, j, ((char)16).ToString()); break;
                    default: SetString(x2, j, ((char)5).ToString()); break;
                }
            }
            #region 1 Top Left
            switch (report.Map[x1, y1])
            {
                case (char)2: SetString(x1, y1, ((char)22).ToString()); break;
                case (char)3: SetString(x1, y1, ((char)25).ToString()); break;
                case (char)4: SetString(x1, y1, ((char)16).ToString()); break;
                case (char)5: SetString(x1, y1, ((char)25).ToString()); break;
                case (char)6: SetString(x1, y1, ((char)22).ToString()); break;
                case (char)21: SetString(x1, y1, ((char)16).ToString()); break;
                case (char)22: SetString(x1, y1, ((char)22).ToString()); break;
                case (char)23: SetString(x1, y1, ((char)16).ToString()); break;
                case (char)25: SetString(x1, y1, ((char)25).ToString()); break;
                case (char)16: SetString(x1, y1, ((char)16).ToString()); break;
                default: SetString(x1, y1, ((char)1).ToString()); break;
            }
            #endregion
            #region 2 Top Right
            switch (report.Map[x2, y1])
            {
                case (char)1: SetString(x2, y1, ((char)22).ToString()); break;
                case (char)3: SetString(x2, y1, ((char)16).ToString()); break;
                case (char)4: SetString(x2, y1, ((char)23).ToString()); break;
                case (char)5: SetString(x2, y1, ((char)23).ToString()); break;
                case (char)6: SetString(x2, y1, ((char)22).ToString()); break;
                case (char)21: SetString(x2, y1, ((char)16).ToString()); break;
                case (char)22: SetString(x2, y1, ((char)22).ToString()); break;
                case (char)23: SetString(x2, y1, ((char)23).ToString()); break;
                case (char)25: SetString(x2, y1, ((char)16).ToString()); break;
                case (char)16: SetString(x2, y1, ((char)16).ToString()); break;
                default: SetString(x2, y1, ((char)2).ToString()); break;
            }
            #endregion
            #region 3 Bottom Left
            switch (report.Map[x1, y2])
            {
                case (char)1: SetString(x1, y2, ((char)25).ToString()); break;
                case (char)2: SetString(x1, y2, ((char)16).ToString()); break;
                case (char)4: SetString(x1, y2, ((char)21).ToString()); break;
                case (char)5: SetString(x1, y2, ((char)25).ToString()); break;
                case (char)6: SetString(x1, y2, ((char)21).ToString()); break;
                case (char)21: SetString(x1, y2, ((char)21).ToString()); break;
                case (char)22: SetString(x1, y2, ((char)16).ToString()); break;
                case (char)23: SetString(x1, y2, ((char)16).ToString()); break;
                case (char)25: SetString(x1, y2, ((char)25).ToString()); break;
                case (char)16: SetString(x1, y2, ((char)16).ToString()); break;
                default: SetString(x1, y2, ((char)3).ToString()); break;
            }
            #endregion
            #region 4 Bottom Right
            switch (report.Map[x2, y2])
            {
                case (char)1: SetString(x2, y2, ((char)16).ToString()); break;
                case (char)2: SetString(x2, y2, ((char)23).ToString()); break;
                case (char)3: SetString(x2, y2, ((char)21).ToString()); break;
                case (char)5: SetString(x2, y2, ((char)23).ToString()); break;
                case (char)6: SetString(x2, y2, ((char)21).ToString()); break;
                case (char)21: SetString(x2, y2, ((char)21).ToString()); break;
                case (char)22: SetString(x2, y2, ((char)16).ToString()); break;
                case (char)23: SetString(x2, y2, ((char)23).ToString()); break;
                case (char)25: SetString(x2, y2, ((char)16).ToString()); break;
                case (char)16: SetString(x2, y2, ((char)16).ToString()); break;
                default: SetString(x2, y2, ((char)4).ToString()); break;
            }
            #endregion
        }

        private void chkShowGrid_CheckedChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void btnAddField_Click(object sender, EventArgs e)
        {
            FrmTextReportAddField frm = new FrmTextReportAddField("ADD",this);
            if (frm.ShowDialog() == DialogResult.OK)
            {
               
            }
        }

        private void btnDeleteField_Click(object sender, EventArgs e)
        {
            if (lstField.SelectedIndex >= 0)
            {
                report.Fields.Remove((TextReportField)lstField.SelectedItem);    
                lstField.Items.RemoveAt(lstField.SelectedIndex);     
            }
        }

        private void btnPutField_Click(object sender, EventArgs e)
        {
            if (lstField.SelectedIndex >= 0)
            {
                putMode = true;
                putType = "field";
                TextReportField f = (TextReportField)lstField.SelectedItem;
                putText = f.Name.PadRight(f.Size, ' ');    
                this.Cursor = Cursors.Cross;
            }
        }

        private void btnBox_Click(object sender, EventArgs e)
        {
            putMode = true;
            putType = "box";
            putText = "";
            this.Cursor = Cursors.Cross;  
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            onCut = true;
            copyPoint1 = new Point(-1,-1);
            copyPoint2 = new Point(-1,-1);
            this.Cursor = Cursors.Cross;  
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            onCopy = true;
            copyPoint1 = new Point(-1,-1);
            copyPoint2 = new Point(-1,-1);
            this.Cursor = Cursors.Cross; 
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            if ((onCut || onCopy) && copyPoint1.X != -1 && copyPoint2.X != -1)
            {
                onPaste = true;
                this.Cursor = Cursors.Cross;  
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (copyPoint1.X != -1 && copyPoint2.X != -1)
            {
                onCut = false;
                onCopy = false;
                onPaste = false;
                this.Cursor = Cursors.Default;
                for (int i = copyPoint1.X; i <= copyPoint2.X; i++)
                    for (int j = copyPoint1.Y; j <= copyPoint2.Y; j++)
                        report.Map[i, j] = ' ';
                copyPoint1 = new Point(-1, -1);
                copyPoint2 = new Point(-1, -1); 
                Draw(); 
            }
        }

        private void txtReportHeader_ValueChanged(object sender, EventArgs e)
        {
            report.ReportHeaderLine = (int)txtReportHeader.Value;
            if (txtReportHeader.Tag == null) 
                txtReportHeader.Tag = txtReportHeader.Value;
            if ((int)txtReportHeader.Tag != (int)txtReportHeader.Value)
            {
                int diff = (int)txtReportHeader.Value - (int)txtReportHeader.Tag;
                txtReportHeader.Tag = (int)txtReportHeader.Value;   
                txtGroupHeader.Value += diff; 
            }
        }

        private void txtGroupHeader_ValueChanged(object sender, EventArgs e)
        {
            report.GroupHeaderLine = (int)txtGroupHeader.Value;
            if (txtGroupHeader.Tag == null)
                txtGroupHeader.Tag = txtGroupHeader.Value;
            if ((int)txtGroupHeader.Tag != (int)txtGroupHeader.Value)
            {
                int diff = (int)txtGroupHeader.Value - (int)txtGroupHeader.Tag;
                txtGroupHeader.Tag = (int)txtGroupHeader.Value;
                txtPageHeader.Value += diff;
            }
        }

        private void txtPageHeader_ValueChanged(object sender, EventArgs e)
        {
            report.PageHeaderLine = (int)txtPageHeader.Value; 
            if (txtPageHeader.Tag == null)
                txtPageHeader.Tag = txtPageHeader.Value;
            if ((int)txtPageHeader.Tag != (int)txtPageHeader.Value)
            {
                int diff = (int)txtPageHeader.Value - (int)txtPageHeader.Tag;
                txtPageHeader.Tag = (int)txtPageHeader.Value;
                txtDetail.Value += diff;
            }
        }

        private void txtDetail_ValueChanged(object sender, EventArgs e)
        {
            report.DetailLine = (int)txtDetail.Value; 
            if (txtDetail.Tag == null)
                txtDetail.Tag = txtDetail.Value;
            if ((int)txtDetail.Tag != (int)txtDetail.Value)
            {
                int diff = (int)txtDetail.Value - (int)txtDetail.Tag;
                txtDetail.Tag = (int)txtDetail.Value;
                txtPageFooter.Value += diff;
            }
        }

        private void txtPageFooter_ValueChanged(object sender, EventArgs e)
        {
            report.PageFooterLine = (int)txtPageFooter.Value; 
            if (txtPageFooter.Tag == null)
                txtPageFooter.Tag = txtPageFooter.Value;
            if ((int)txtPageFooter.Tag != (int)txtPageFooter.Value)
            {
                int diff = (int)txtPageFooter.Value - (int)txtPageFooter.Tag;
                txtPageFooter.Tag = (int)txtPageFooter.Value;
                txtGroupFooter.Value += diff;
            }
        }

        private void txtGroupFooter_ValueChanged(object sender, EventArgs e)
        {
            report.GroupFooterLine = (int)txtGroupFooter.Value; 
            if (txtGroupFooter.Tag == null)
                txtGroupFooter.Tag = txtGroupFooter.Value;
            if ((int)txtGroupFooter.Tag != (int)txtGroupFooter.Value)
            {
                int diff = (int)txtGroupFooter.Value - (int)txtGroupFooter.Tag;
                txtGroupFooter.Tag = (int)txtGroupFooter.Value;
                txtReportFooter.Value += diff;
            }
        }

        private void txtReportFooter_ValueChanged(object sender, EventArgs e)
        {
            report.ReportFooterLine = (int)txtReportFooter.Value;
            Draw();
        }

        private void chkColorRegion_CheckedChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void btnAddControl_Click(object sender, EventArgs e)
        {
            putMode = true;
            putType = "+control";
            putText = "";
            this.Cursor = Cursors.Cross;
        }

        private void pctDocument_MouseMove(object sender, MouseEventArgs e)
        {
            if ((mouseX != e.X || mouseY != e.Y) && putMode)
            {
                mouseX = e.X;
                mouseY = e.Y;
                Draw(); 
            }
            int x = (int)(e.X / charWidth);
            int y = (int)(e.Y / charHeight);
            if (report.Controls[x, y] != null && (string)ttControl.Tag != report.Controls[x, y])
            {
                ttControl.ToolTipTitle = "Printer Control";
                ttControl.Tag = report.Controls[x, y];
                ttControl.Show(report.Controls[x, y], pctDocument, e.X, e.Y,3000);
            }
            if (report.Controls[x, y] == null)
            {
                ttControl.Tag = ""; 
            }
        }

        private void btnDelControl_Click(object sender, EventArgs e)
        {
            putMode = true;
            putType = "-control";
            putText = "";
            this.Cursor = Cursors.Cross;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            pctDocument.Left = -e.NewValue;  
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            putMode = true;
            putType = "line";
            putText = "";
            this.Cursor = Cursors.Cross;  
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            putMode = true;
            putType = "text";
            putText = txtText.Text;
            this.Cursor = Cursors.Cross;  
        }

        private void chkSplit_CheckedChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void txtSplitPage_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void txtSplitColumn_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void btnSaveReport_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.AddExtension = true;
            dialog.Filter = "Text Report File (*.trpt) | *.trpt";
            dialog.FileName = report.ReportFilename;         
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                UpdateReportFromUI();
                report.Save(dialog.FileName);
                MessageBox.Show("Report is saved!");  
            }
        }

        private void btnLoadReport_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.CheckFileExists = true;
            dialog.Filter = "Text Report File (*.trpt) | *.trpt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                report.Load(dialog.FileName);
                this.Text = "Text Report Designer [" + dialog.FileName + "]";
                UpdateUIFromReport();
                Draw();
                MessageBox.Show("Report is loaded!");
            }
        }

        public void UpdateReportFromUI()
        {
            report.TotalColumn = (int)txtTotalColumn.Value;
            report.TotalRow = (int)txtTotalRow.Value;
            report.ReportHeaderLine = (int)txtReportHeader.Value;
            report.GroupHeaderLine = (int)txtGroupHeader.Value;
            report.PageHeaderLine = (int)txtPageHeader.Value;
            report.DetailLine = (int)txtDetail.Value;
            report.PageFooterLine = (int)txtPageFooter.Value;
            report.GroupFooterLine = (int)txtGroupFooter.Value;
            report.ReportFooterLine = (int)txtReportFooter.Value;
            report.ShowGrid = chkShowGrid.Checked;
            report.ColorRegion = chkColorRegion.Checked;
            report.PageBreakOnGroup = chkPageBreakOnGroup.Checked;
            report.Split = chkSplit.Checked;
            report.SplitPage = (int)txtSplitPage.Value;
            report.SplitColumn = (int)txtSplitColumn.Value;
            report.Fields.Clear();  
            foreach (TextReportField field in lstField.Items)
            {
                report.Fields.Add(field);   
            }
        }

        public void UpdateUIFromReport()
        {
            txtTotalColumn.Value = report.TotalColumn;
            txtTotalRow.Value = report.TotalRow;
 
            txtReportHeader.Tag = report.ReportHeaderLine;
            txtGroupHeader.Tag = report.GroupHeaderLine;
            txtPageHeader.Tag = report.PageHeaderLine;
            txtDetail.Tag = report.DetailLine;
            txtPageFooter.Tag = report.PageFooterLine;
            txtGroupFooter.Tag = report.GroupFooterLine;
            txtReportFooter.Tag = report.ReportFooterLine;

            txtReportHeader.Value = report.ReportHeaderLine;
            txtGroupHeader.Value = report.GroupHeaderLine;
            txtPageHeader.Value = report.PageHeaderLine;
            txtDetail.Value = report.DetailLine;
            txtPageFooter.Value = report.PageFooterLine;
            txtGroupFooter.Value = report.GroupFooterLine;
            txtReportFooter.Value = report.ReportFooterLine;

            chkShowGrid.Checked = report.ShowGrid;
            chkColorRegion.Checked = report.ColorRegion;
            chkPageBreakOnGroup.Checked = report.PageBreakOnGroup;
            chkSplit.Checked = report.Split;
            txtSplitPage.Value = report.SplitPage;
            txtSplitColumn.Value = report.SplitColumn;

            lstField.Items.Clear();
            foreach (TextReportField field in report.Fields)
            {
                lstField.Items.Add(field);   
            }
            Draw();
        }

        private void btnPreviewReport_Click(object sender, EventArgs e)
        {
            UpdateReportFromUI();
            FrmTextReportVariables frmVariables = new FrmTextReportVariables(this);
            if(!frmVariables.IsDisposed) 
                frmVariables.ShowDialog();  
            FrmTextReportViewer frmTextReportViewer = new FrmTextReportViewer(report, table);
            frmTextReportViewer.ShowDialog(); 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            report.TotalColumn = (int)txtTotalColumn.Value;
            report.TotalRow = (int)txtTotalRow.Value;
            report.UpdateSize(); 
            ArrangeControls(); 
            Draw();
        }

        private void btnEditField_Click(object sender, EventArgs e)
        {
            if (lstField.SelectedIndex < 0) return;  
            FrmTextReportAddField frm = new FrmTextReportAddField("EDIT",this);
            if (frm.ShowDialog() == DialogResult.OK)
            {

            }
        }




    }
}