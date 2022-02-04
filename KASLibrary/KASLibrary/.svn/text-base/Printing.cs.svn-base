using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Data;
using System.Collections;
using System.Windows.Forms;  

namespace KASLibrary
{
    public class Printer
    {
        private string printerName;

        public Printer(string printerName)
        {
            this.printerName = printerName;
        }

        public void PrintFile(string filename)
        {
            FileStream fs = File.Open(filename,FileMode.Open);
            byte[] buffer = new byte[(int)fs.Length];
            fs.Read(buffer, 0, (int)fs.Length);
            fs.Close(); 
            PrintBytes(buffer);
        }

        public void PrintBytes(byte[] arr)
        {
            IntPtr hPrinter = new IntPtr();
            PRINTER_DEFAULTS pd = new PRINTER_DEFAULTS();

            if (OpenPrinter(printerName, out hPrinter, ref pd))
            {
                DOCINFOW di = new DOCINFOW();
                if (StartDocPrinter(hPrinter, 1, ref di))
                {
                    if (StartPagePrinter(hPrinter))
                    {
                        IntPtr pBytes;
                        int dwWritten = 0;
                        pBytes = Marshal.AllocCoTaskMem(arr.Length);
                        Marshal.Copy(arr, 0, pBytes, arr.Length);
                        WritePrinter(hPrinter, pBytes, arr.Length, out dwWritten);
                        EndPagePrinter(hPrinter);
                        Marshal.FreeCoTaskMem(pBytes);
                    }
                    else
                    {
                        throw new Exception("Printer Error: Start Page failed!");
                    }
                    EndDocPrinter(hPrinter);
                }
                else
                {
                    throw new Exception("Printer Error: Start Document failed!");
                }

                ClosePrinter(hPrinter);
            }
            else
            {
                throw new Exception("Printer Error: Open Printer failed!");
            }
        }

        public void PrintString(string output)
        {
            IntPtr hPrinter = new IntPtr();
            PRINTER_DEFAULTS pd = new PRINTER_DEFAULTS();

            if (OpenPrinter(printerName, out hPrinter, ref pd))
            {
                DOCINFOW di = new DOCINFOW();
                if (StartDocPrinter(hPrinter, 1, ref di))
                {
                    if (StartPagePrinter(hPrinter))
                    {
                        IntPtr pBytes;
                        int dwWritten = 0;
                        byte[] arr = System.Text.ASCIIEncoding.ASCII.GetBytes(output);
                        pBytes = Marshal.AllocCoTaskMem(arr.Length);
                        Marshal.Copy(arr, 0, pBytes, arr.Length);
                        WritePrinter(hPrinter, pBytes, arr.Length, out dwWritten);
                        EndPagePrinter(hPrinter);
                        Marshal.FreeCoTaskMem(pBytes);
                    }
                    else
                    {
                        throw new Exception("Printer Error: Start Page failed!");
                    }
                    EndDocPrinter(hPrinter);
                }
                else
                {
                    throw new Exception("Printer Error: Start Document failed!");
                }

                ClosePrinter(hPrinter);
            }
            else
            {
                throw new Exception("Printer Error: Open Printer failed!");
            }
        }

        #region winspool.Drv functions
        [StructLayout(LayoutKind.Sequential)]
        private struct PRINTER_DEFAULTS
        {
            public int pDatatype;
            public int pDevMode;
            public int DesiredAccess;
        }

        private struct DOCINFOW
        {
            [MarshalAs(UnmanagedType.LPWStr)]
            public string pDocName;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string pOutputFile;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string pDataType;
        }

        [DllImport("winspool.Drv")]
        private static extern bool
            OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter,
            out IntPtr hPrinter, ref PRINTER_DEFAULTS pd);

        [DllImport("winspool.drv")]
        private static extern bool ClosePrinter(IntPtr hPrinter);

        [DllImport("winspool.drv")]
        private static extern bool StartDocPrinter(IntPtr hPrinter, int level, ref DOCINFOW pDI);

        [DllImport("winspool.drv")]
        private static extern bool EndDocPrinter(IntPtr hPrinter);

        [DllImport("winspool.drv")]
        private static extern bool StartPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.drv")]
        private static extern bool EndPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.drv")]
        private static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, int dwCount, out int dwWritten);
        #endregion
    }

    public class TextReportField
    {
        private string name;
        private string column;
        private string alignment; //LEFT, CENTER, RIGHT
        private string format;
        private int size;
        private string lastData; //to be used when in group header region
        private string summary;
        private double minimum;
        private double maximum;
        private int count;
        private double total;
        private double grandMinimum;
        private double grandMaximum;
        private int grandCount;
        private double grandTotal;


        public TextReportField() 
        {
            name = "";
            column = "";
            alignment = "LEFT";
            format = "";
            size = 0;
            lastData = "";
            summary = "";
            ClearSummary(); 
        }

        public TextReportField(string name, string column, string alignment,
            string format, int size)
        {
            this.name = name;
            this.column = column;
            this.alignment = alignment;
            this.format = format;
            this.size = size;
            lastData = "";
            summary = "";
            ClearSummary(); 
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Column
        {
            get { return column; }
            set { column = value; }
        }

        public string Alignment
        {
            get { return alignment; }
            set { alignment = value; } 
        }

        public string Format
        {
            get { return format; }
            set { format = value; }
        }

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public string LastData
        {
            get { return lastData; }
            set { lastData = value; }
        }

        public string Summary
        {
            get { return summary; }
            set { summary = value; }
        }

        public double Minimum
        {
            get { return minimum; }
            set { minimum = value; }
        }

        public double Maximum
        {
            get { return maximum; }
            set { maximum = value; }
        }

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public double Total
        {
            get { return total; }
            set { total = value; }
        }

        public double Average
        {
            get 
            {
                if (count == 0) return 0;
                return total / count;
            }
        }

        public double GrandMinimum
        {
            get { return grandMinimum; }
            set { grandMinimum = value; }
        }

        public double GrandMaximum
        {
            get { return grandMaximum; }
            set { grandMaximum = value; }
        }

        public int GrandCount
        {
            get { return grandCount; }
            set { grandCount = value; }
        }

        public double GrandTotal
        {
            get { return grandTotal; }
            set { grandTotal = value; }
        }

        public double GrandAverage
        {
            get 
            {
                if (grandCount == 0) return 0;
                return grandTotal / grandCount;
            }
        }
        
        public void ClearSummary()
        {
            minimum = 0;
            maximum = 0;
            count = 0;
            total = 0;
            grandMinimum = 0;
            grandMaximum = 0;
            grandCount = 0;
            grandTotal = 0;
        }

        public override string ToString()
        {
            return name;
        }
    }

    public class TextReport
    {
        private string reportFilename;
        private int totalColumn;
        private int totalRow;
        #region Controls
        private ProgressBar generateBar;  
        private bool showGrid;
        private bool colorRegion;
        private bool pageBreakOnGroup;
        private bool split;
        private int splitPage;
        private int splitColumn;
        #endregion
        #region Regions
        private int reportHeaderLine;
        private int groupHeaderLine;
        private int pageHeaderLine;
        private int detailLine;
        private int pageFooterLine;
        private int groupFooterLine;
        private int reportFooterLine;
        #endregion
        #region Fields
        private ArrayList fields;
        private Hashtable variables;
        #endregion
        #region Document Map (map)
        private char[,] map;
        #endregion
        #region PrinterControls
        private string[,] controls;
        private bool usePrinterControl;
        private Hashtable symbols;
        #endregion

        public TextReport()
        {
            reportFilename = "default.trpt";
            totalColumn = 130;
            totalRow = 63; 
            #region Controls
            generateBar = null;
            showGrid = true;
            colorRegion = true;
            pageBreakOnGroup = false;
            split = false;
            splitPage = 2;
            splitColumn = 0;
            #endregion
            #region Regions
            reportHeaderLine = 2;
            groupHeaderLine = 5;
            pageHeaderLine = 8;
            detailLine = 9;
            pageFooterLine = 12;
            groupFooterLine = 15;
            reportFooterLine = 17;
            #endregion
            #region Fields
            fields = new ArrayList();
            variables = new Hashtable(); 
            #endregion
            #region Document Map (map)
            map = new char[totalColumn,totalRow];
            for (int i = 0; i < totalColumn; i++)
                for (int j = 0; j < totalRow; j++)
                    map[i, j] = ' ';
            #endregion
            #region PrinterControls
            controls = new string[totalColumn,totalRow];
            usePrinterControl = true;
            symbols = new Hashtable();
            symbols.Add(1, 218);
            symbols.Add(2, 191);
            symbols.Add(3, 192);
            symbols.Add(4, 217);
            symbols.Add(5, 179);
            symbols.Add(6, 196);
            symbols.Add(21, 193);
            symbols.Add(22, 194);
            symbols.Add(23, 180);
            symbols.Add(25, 195);
            symbols.Add(16, 197); 
            #endregion
        }

        public string ReportFilename
        {
            get { return reportFilename; }
            set { reportFilename = value; }
        }
      
        public int TotalColumn
        {
            get { return totalColumn; }
            set { totalColumn = value;}
        }

        public int TotalRow
        {
            get { return totalRow; }
            set { totalRow = value;}
        }

        #region Controls
        public ProgressBar GenerateBar
        {
            get { return generateBar; }
            set { generateBar = value; }
        }
        public bool ShowGrid
        {
            get { return showGrid; }
            set { showGrid = value; }
        }
        public bool ColorRegion
        {
            get { return colorRegion; }
            set { colorRegion = value; }
        }
        public bool PageBreakOnGroup
        {
            get { return pageBreakOnGroup; }
            set { pageBreakOnGroup = value; }
        }
        public bool Split
        {
            get { return split; }
            set { split = value; }
        }
        public int SplitPage
        {
            get { return splitPage; }
            set { splitPage = value; }
        }
        public int SplitColumn
        {
            get { return splitColumn; }
            set { splitColumn = value; }
        }
        #endregion
        #region Regions
        public int ReportHeaderLine
        {
            get { return reportHeaderLine;}
            set { reportHeaderLine = value; }
        }
        public int GroupHeaderLine
        {
            get { return groupHeaderLine; }
            set { groupHeaderLine = value; }
        }
        public int PageHeaderLine
        {
            get { return pageHeaderLine; }
            set { pageHeaderLine = value; }
        }
        public int DetailLine
        {
            get { return detailLine; }
            set { detailLine = value; }
        }
        public int PageFooterLine
        {
            get { return pageFooterLine; }
            set { pageFooterLine = value; }
        }
        public int GroupFooterLine
        {
            get { return groupFooterLine; }
            set { groupFooterLine = value; }
        }
        public int ReportFooterLine
        {
            get { return reportFooterLine; }
            set { reportFooterLine = value; }
        }
        #endregion
        #region Fields
        public ArrayList Fields
        {
            get { return fields; }
            set { fields = value; }
        }
        public Hashtable Variables
        {
            get { return variables; }
            set { variables = value; }
        }
        #endregion
        #region Document Map (map)
        public char[,] Map
        {
            get { return map; }
            set { map = value; }
        }
        #endregion
        #region PrinterControls
        public string[,] Controls
        {
            get { return controls; }
            set { controls = value; }
        }
        public bool UsePrinterControl
        {
            get { return usePrinterControl; }
            set { usePrinterControl = value; }
        }
        public Hashtable Symbols
        {
            get { return symbols; }
            set { symbols = value; }
        }
        #endregion

        public void UpdateSize()
        {
            char[,] temp = map;
            map = new char[totalColumn, TotalRow];
            for(int i=0;i<totalColumn;i++)
                for(int j=0;j<TotalRow;j++)
                {
                    if (i < temp.GetLength(0) && j < temp.GetLength(1))
                    {
                        map[i, j] = temp[i, j];
                    }
                    else
                    {
                        map[i, j] = ' ';
                    }
                }
            string[,] temp2 = controls;
            controls = new string[totalColumn, TotalRow];
            for (int i = 0; i < totalColumn; i++)
                for (int j = 0; j < TotalRow; j++)
                {
                    if (i < temp2.GetLength(0) && j < temp2.GetLength(1))
                    {
                        controls[i, j] = temp2[i, j];
                    }
                    else
                    {
                        controls[i, j] = null;
                    }
                }
        }

        public void Load(string filename)
        {
            reportFilename = filename;
            StreamReader sr = File.OpenText(filename);
            totalColumn = int.Parse(sr.ReadLine());
            totalRow = int.Parse(sr.ReadLine()); 
            #region Controls
            showGrid = bool.Parse(sr.ReadLine());
            colorRegion = bool.Parse(sr.ReadLine());
            pageBreakOnGroup = bool.Parse(sr.ReadLine());
            split = bool.Parse(sr.ReadLine());
            splitPage = int.Parse(sr.ReadLine());
            splitColumn = int.Parse(sr.ReadLine());
            #endregion
            #region Regions
            reportHeaderLine = int.Parse(sr.ReadLine());
            groupHeaderLine = int.Parse(sr.ReadLine());
            pageHeaderLine = int.Parse(sr.ReadLine());
            detailLine = int.Parse(sr.ReadLine());
            pageFooterLine = int.Parse(sr.ReadLine());
            groupFooterLine = int.Parse(sr.ReadLine());
            reportFooterLine = int.Parse(sr.ReadLine());
            #endregion
            #region Fields
            int totalField = int.Parse(sr.ReadLine());
            fields.Clear();
            for (int i = 0; i < totalField; i++)
            {
                TextReportField field = new TextReportField();
                field.Name = sr.ReadLine();
                field.Column = sr.ReadLine();
                field.Alignment = sr.ReadLine();
                field.Format = sr.ReadLine();
                field.Size = int.Parse(sr.ReadLine());
                field.LastData = sr.ReadLine();
                field.Summary = sr.ReadLine(); 
                fields.Add(field);
            }
            #endregion
            #region Document Map (map)
            map = new char[totalColumn, totalRow];  
            for (int j = 0; j < totalRow; j++)
            {
                string aline = sr.ReadLine();
                for (int i = 0; i < totalColumn; i++)
                {
                    map[i, j] = aline[i];
                }
            }
            #endregion
            #region Printer Controls
            controls = new string[totalColumn, totalRow];
            while (!sr.EndOfStream)
            {
                string aline = sr.ReadLine();
                if (aline != "")
                {
                    int i = int.Parse(aline.Substring(0, aline.IndexOf(",")));
                    int j = int.Parse(aline.Substring(aline.IndexOf(",") + 1, aline.IndexOf(":") - aline.IndexOf(",") - 1));
                    controls[i, j] = aline.Substring(aline.IndexOf(":") + 1);
                }
            }
            #endregion
            sr.Close();
        }

        public void Save(string filename)
        {
            reportFilename = filename;
            if (File.Exists(filename))
                File.Delete(filename);
            StreamWriter sw = File.CreateText(filename);
            sw.WriteLine(totalColumn);
            sw.WriteLine(totalRow);

            #region report.Controls
            sw.WriteLine(showGrid.ToString());
            sw.WriteLine(colorRegion.ToString());
            sw.WriteLine(pageBreakOnGroup.ToString());
            sw.WriteLine(split.ToString());
            sw.WriteLine(splitPage.ToString());
            sw.WriteLine(splitColumn.ToString());
            #endregion
            #region Regions
            sw.WriteLine(reportHeaderLine.ToString());
            sw.WriteLine(groupHeaderLine.ToString());
            sw.WriteLine(pageHeaderLine.ToString());
            sw.WriteLine(detailLine.ToString());
            sw.WriteLine(pageFooterLine.ToString());
            sw.WriteLine(groupFooterLine.ToString());
            sw.WriteLine(reportFooterLine.ToString());
            #endregion
            #region Fields
            sw.WriteLine(fields.Count);
            for (int i = 0; i < fields.Count; i++)
            {
                TextReportField field = (TextReportField)fields[i];
                sw.WriteLine(field.Name);
                sw.WriteLine(field.Column);
                sw.WriteLine(field.Alignment);
                sw.WriteLine(field.Format);
                sw.WriteLine(field.Size);
                sw.WriteLine(field.LastData);
                sw.WriteLine(field.Summary);
            }
            #endregion
            #region Document Map (map)
            for (int j = 0; j < totalRow; j++)
            {
                for (int i = 0; i < totalColumn; i++)
                {
                    sw.Write(map[i, j]);
                }
                sw.WriteLine();
            }
            #endregion
            #region Printer report.Controls
            for (int j = 0; j < TotalRow; j++)
            {
                for (int i = 0; i < totalColumn; i++)
                {
                    if (controls[i, j] != null)
                        sw.WriteLine(i.ToString() + "," + j.ToString() + ":" + controls[i, j]);
                }
            }
            #endregion
            sw.Close();
        }

        public string Generate(DataTable tblSource)
        {
            string tempFilename = Application.StartupPath + "\\temp.tmp"; 
            StreamWriter sw = File.CreateText(tempFilename);
            StreamReader sr;
            string report = "";
            string data;
            bool breakHere = false;
            int page = 1; //current page Number
            int totalRowAtCurrentPage = 0; //current total Row generated at the current page
            int index = 0; //index at the dataTable
            int regionStart;
            int regionEnd;
            ArrayList activeGroupFields = new ArrayList();

            #region Clear Summary Before Start
            foreach (TextReportField f in fields)
            {
                if (f.Summary != "")
                    f.ClearSummary(); 
            }
            #endregion
            #region Report Header
            regionStart = 0;
            regionEnd = reportHeaderLine;
            for (int row = regionStart; row < regionEnd; row++)
            {
                for (int col = 0; col < totalColumn; col++)
                {
                    sw.Write( GetControlAt(col, row));
                    if (map[col, row] == '@')
                    {
                        data = GetDataAt(col, row, ref tblSource, index,page);
                        sw.Write( data);
                        col += data.Length - 1;
                    }
                    else
                    {
                        sw.Write( map[col, row].ToString());
                    }
                }
                totalRowAtCurrentPage++;
                sw.Write( "\r\n");
            }
            #endregion
            if (generateBar != null)
            {
                generateBar.Minimum = 0;
                generateBar.Maximum = tblSource.Rows.Count;
            }
            
            int tempIndex = -1;

            while (index < tblSource.Rows.Count)
            {
                if (generateBar != null)
                    generateBar.Value = index; 
                int lastIndex = index; 
                //lastIndex is to check whether this index is increasing after reaching group footer or not
                //if yes then do nothing
                //if not then there must be no database field in the detail and we must advance the index to avoid infinite loop.

                #region Group Header
                //Move to next page if not enough space for group header until group footer with one data
                if (totalRowAtCurrentPage + groupFooterLine - groupHeaderLine >= totalRow)
                {
                    totalRowAtCurrentPage = 0;
                    page++;
                    sw.Write((char)12);
                }
                regionStart = reportHeaderLine;
                regionEnd = groupHeaderLine;
                for (int row = regionStart; row < regionEnd; row++)
                {
                    for (int col = 0; col < totalColumn; col++)
                    {
                        sw.Write( GetControlAt(col, row));
                        if (map[col, row] == '@')
                        {
                            TextReportField f = GetFieldAt(col, row);
                            if (f.Column.Trim() != "")
                            {
                                f.LastData = tblSource.Rows[index][f.Column].ToString();
                                if (!activeGroupFields.Contains(f)) activeGroupFields.Add(f);
                            }
                            data = GetDataAt(col, row, ref tblSource, index,page);  
                            sw.Write( data);
                            col += data.Length - 1;
                        }
                        else
                        {
                            sw.Write( map[col, row].ToString());
                        }
                    }
                    totalRowAtCurrentPage++;
                    sw.Write( "\r\n");
                }
                #region Reset Group Summary
                foreach (TextReportField f in fields)
                {
                    if (f.Summary != "")
                    {
                        f.Minimum = 0;
                        f.Maximum = 0;
                        f.Count = 0;
                        f.Total = 0;
                    }
                }
                #endregion
                #endregion
                #region Page Header
                regionStart = groupHeaderLine;
                regionEnd = pageHeaderLine;
                for (int row = regionStart; row < regionEnd; row++)
                {
                    for (int col = 0; col < totalColumn; col++)
                    {
                        sw.Write( GetControlAt(col, row));
                        if (map[col, row] == '@')
                        {
                            data = GetDataAt(col, row, ref tblSource, index,page);
                            sw.Write( data);
                            col += data.Length - 1;
                        }
                        else
                        {
                            sw.Write( map[col, row].ToString());
                        }
                    }
                    totalRowAtCurrentPage++;
                    sw.Write( "\r\n");
                }
                #endregion
                #region Detail
            Detail:
                
                regionStart = pageHeaderLine;
                regionEnd = detailLine;
                for (int row = regionStart; row < regionEnd; row++)
                {
                    for (int col = 0; col < totalColumn; col++)
                    {
                        sw.Write( GetControlAt(col, row));
                        if (map[col, row] == '@')
                        {
                            data = GetDataAt(col, row, ref tblSource, index,page);
                            sw.Write( data);
                            col += data.Length - 1;
                        }
                        else
                        {
                            sw.Write( map[col, row].ToString());
                        }
                    }
                    totalRowAtCurrentPage++;                   
                    sw.Write("\r\n");
                }
                #region Update Summary
                //TODO: 
                //TODO: Calculate here therefore no need field with the same column
                //exist in the detail. Don't calculate if summary is false
                foreach (TextReportField f in fields)
                {
                    if (f.Summary != "")
                    {
                        f.Count++;
                        f.GrandCount++;
                        double val = double.Parse(tblSource.Rows[index][f.Column].ToString()); 
                        f.Total += val;
                        f.GrandTotal += val;
                        if (f.Minimum > val) f.Minimum = val;
                        if (f.GrandMinimum > val) f.GrandMinimum = val;
                        if (f.Maximum < val) f.Maximum = val;
                        if (f.GrandMaximum < val) f.GrandMaximum = val; 
                    }
                }
                #endregion
                if (index < tblSource.Rows.Count - 1) //If there is still data available
                {
                    index++; //Increase the index
                    //If space is not available then break here and continue in the next page
                    if (totalRowAtCurrentPage + (pageFooterLine - detailLine) >= totalRow)
                    {
                        breakHere = true;
                    }
                    else
                    {
                        //Space is available so check whether the group data is changed
                        foreach (TextReportField f in activeGroupFields)
                        {
                            if (f.LastData != tblSource.Rows[index][f.Column].ToString())
                            {
                                //Group data is changed then close this group with pageFooter and groupFooter
                                goto PageFooter;
                            }
                        }
                        //Still the same group continue with the detail
                        goto Detail;
                    }
                }
                else
                {
                    tempIndex = index + 1;
                }
                #endregion
                #region Page Footer
            PageFooter:
                regionStart = detailLine;
                regionEnd = pageFooterLine;
                for (int row = regionStart; row < regionEnd; row++)
                {
                    for (int col = 0; col < totalColumn; col++)
                    {
                        sw.Write( GetControlAt(col, row));
                        if (map[col, row] == '@')
                        {
                            data = GetDataAt(col, row, ref tblSource, index - 1,page);//this page data not the next one
                            sw.Write( data);
                            col += data.Length - 1;
                        }
                        else
                        {
                            sw.Write( map[col, row].ToString());
                        }
                    }
                    totalRowAtCurrentPage++;
                    sw.Write( "\r\n");
                }
                if (breakHere)
                {
                    totalRowAtCurrentPage = 0;
                    page++;
                    sw.Write( ((char)12).ToString());
                    breakHere = false;
                    foreach (TextReportField f in activeGroupFields)
                    {
                        if (f.LastData != tblSource.Rows[index][f.Column].ToString())
                        {
                            //Group data is changed then close this group with groupFooter
                            goto GroupFooter;
                        }
                    }
                    continue; //bypass the group footer
                }
                #endregion
                #region Group Footer
            GroupFooter:
                //Move to next page if not enough space for group footer
                if (totalRowAtCurrentPage + groupFooterLine - pageFooterLine >= totalRow)
                {
                    totalRowAtCurrentPage = 0;
                    page++;
                    sw.Write((char)12);
                }
                regionStart = pageFooterLine;
                regionEnd = groupFooterLine;
                for (int row = regionStart; row < regionEnd; row++)
                {
                    for (int col = 0; col < totalColumn; col++)
                    {
                        sw.Write( GetControlAt(col, row));
                        if (map[col, row] == '@')
                        {
                            data = GetDataAt(col, row, ref tblSource, index-1,page);//this group data not the next one
                            sw.Write( data);
                            col += data.Length - 1;
                        }
                        else
                        {
                            sw.Write( map[col, row].ToString());
                        }
                    }
                    totalRowAtCurrentPage++;
                    sw.Write( "\r\n");
                }
                if (pageBreakOnGroup)
                {
                    totalRowAtCurrentPage = 0;
                    page++;
                    sw.Write( ((char)12).ToString());
                }
                #endregion

                //added by gita 07/07/08
                //spy record terakhir tdk dicetak 2x saat pindah kolom
                if (index == tblSource.Rows.Count - 1 && tempIndex > index)
                    lastIndex = index;

                if (lastIndex == index) 
                    index++; 
            }
            #region Report Footer
            //Move to next page if not enough space for report footer
            if (totalRowAtCurrentPage+reportFooterLine-groupFooterLine >= totalRow)
            {
                totalRowAtCurrentPage = 0;
                page++;
                sw.Write((char)12);
            }
            regionStart = groupFooterLine;
            regionEnd = reportFooterLine;
            for (int row = regionStart; row < regionEnd; row++)
            {
                for (int col = 0; col < totalColumn; col++)
                {
                    sw.Write( GetControlAt(col, row));
                    if (map[col, row] == '@')
                    {
                        data = GetDataAt(col, row, ref tblSource, index - 1,page);//this report data not the next one
                        sw.Write( data);
                        col += data.Length - 1;
                    }
                    else
                    {
                        sw.Write( map[col, row].ToString());
                    }
                }
                totalRowAtCurrentPage++;
                sw.Write( "\r\n");   
            }
            sw.Write( ((char)12).ToString());
            sw.Close(); 
            #endregion
        
            Trim(tempFilename); 
            if (split)
                SetPageLayout(tempFilename, splitPage, splitColumn);
            
            sr = File.OpenText(tempFilename);
            report = sr.ReadToEnd();
            sr.Close();
            File.Delete(tempFilename);
  
            return report;
        }

        public void Print(DataTable tblSource, string printerName,int startPage,int endPage)
        {
            usePrinterControl = true;
            string report = Generate(tblSource);
            report = report.Substring(0, report.LastIndexOf((char)12));
            string[] pages = report.Split((char)12);

            string result = "";
            for (int i = startPage; i <= endPage; i++)
            {
                result += pages[i - 1] + ((char)12).ToString(); 
            }

            #region Convert symbols
            byte[] arr = new byte[result.Length];
            for (int i = 0; i < result.Length; i++)
            {
                if (symbols.ContainsKey((int)result[i]))
                {
                    byte realSymbol = (byte)((int)symbols[(int)result[i]]);
                    arr[i] = realSymbol;
                }
                else
                {
                    arr[i] = (byte)result[i];
                }
            }
            #endregion

            Printer printer = new Printer(printerName);
            printer.PrintBytes(arr); 
        }

        public string GetDataAt(int col, int row, ref DataTable tblSource,int index,int page)
        {
            TextReportField f = GetFieldAt(col, row);
            string data;
            object temp = "";

            if (f.Column.Trim() != "") // From Database
            {
                if (f.Summary == "")temp = tblSource.Rows[index][f.Column];
                if (f.Summary == "MINIMUM") temp = f.Minimum;
                if (f.Summary == "MAXIMUM") temp = f.Maximum;
                if (f.Summary == "COUNT") temp = f.Count;
                if (f.Summary == "TOTAL") temp = f.Total;
                if (f.Summary == "AVERAGE") temp = f.Average;  
                if (f.Summary == "GRAND MINIMUM") temp = f.GrandMinimum;
                if (f.Summary == "GRAND MAXIMUM") temp = f.GrandMaximum;
                if (f.Summary == "GRAND COUNT") temp = f.GrandCount;
                if (f.Summary == "GRAND TOTAL") temp = f.GrandTotal;
                if (f.Summary == "GRAND AVERAGE") temp = f.GrandAverage;  
            }
            else if (f.Name == "@pg#") //Special variable - page number
            {
                temp = page; 
            }
            else if (f.Name == "@r#") //Special variable - row number
            {
                temp = index+1;
            }
            else //From Report Variable
            {
                if (!variables.ContainsKey(f.Name))
                {
                    throw new Exception("Variable " + f.Name + " can't be found in TextReport.Variables !");
                }
                temp = variables[f.Name];
            }

            #region Format
            if (temp is double)
                data = ((double)temp).ToString(f.Format);
            else if (temp is float)
                data = ((float)temp).ToString(f.Format);
            else if (temp is Int16)
                data = ((Int16)temp).ToString(f.Format);
            else if (temp is Int32)
                data = ((Int32)temp).ToString(f.Format);
            else if (temp is Int64)
                data = ((Int64)temp).ToString(f.Format);
            else if (temp is DateTime)
                data = ((DateTime)temp).ToString(f.Format);
            else
                data = temp.ToString(); 
            #endregion

            #region Alignment
            if (f.Alignment == "LEFT")
            {
                data = data.PadRight(f.Size, ' ');
            }
            else if (f.Alignment == "RIGHT")
            {
                data = data.PadLeft(f.Size, ' ');
            }
            else //CENTER ALIGNMENT
            {
                if (data.Length < f.Size)
                {
                    data = data.PadRight(data.Length + (f.Size - data.Length) / 2, ' ');
                    data = data.PadLeft(f.Size, ' ');
                }
            }
            #endregion
            
            if (data.Length > f.Size) data = data.Substring(0, f.Size - 1) + ".";
            
            return data;
        }

        public TextReportField GetFieldAt(int col, int row)
        {
            string fieldName = map[col, row].ToString();
            for (int i = col + 1; i < totalColumn; i++)
            {
                fieldName += map[i, row].ToString();
                if (map[i, row] == '#') break;
            }
            foreach (TextReportField f in fields)
            {
                if (f.Name == fieldName)
                {
                    return f;
                }
            }
            return null;
        }

        public string GetControlAt(int col, int row)
        {
            if (controls[col, row] == null || !usePrinterControl) return "";
            string[] printControl = controls[col, row].ToUpper().Split(',');
            string result = "";
            foreach (string pc in printControl)
            {
                if (pc == "BOLD") result += ((char)27).ToString() + ((char)69).ToString();
                if (pc == "UNBOLD") result += ((char)27).ToString() + ((char)70).ToString();
                if (pc == "ITALIC") result += ((char)27).ToString() + ((char)52).ToString();
                if (pc == "UNITALIC") result += ((char)27).ToString() + ((char)53).ToString();
                if (pc == "DOUBLESTRIKE") result += ((char)27).ToString() + ((char)71).ToString();
                if (pc == "UNDOUBLESTRIKE") result += ((char)27).ToString() + ((char)72).ToString();
                if (pc == "UNDERLINE") result += ((char)27).ToString() + ((char)45).ToString() + ((char)1).ToString();
                if (pc == "UNUNDERLINE") result += ((char)27).ToString() + ((char)45).ToString() + ((char)0).ToString();
                if (pc == "SUPERSCRIPT") result += ((char)27).ToString() + ((char)83).ToString() + ((char)0).ToString();
                if (pc == "UNSUPERSCRIPT") result += ((char)27).ToString() + ((char)84).ToString();
                if (pc == "SUBSCRIPT") result += ((char)27).ToString() + ((char)83).ToString() + ((char)1).ToString();
                if (pc == "UNSUBSCRIPT") result += ((char)27).ToString() + ((char)84).ToString();
                if (pc == "CONDENSED") result += ((char)15).ToString();
                if (pc == "UNCONDENSED") result += ((char)18).ToString();
                if (pc == "DOUBLEWIDTH") result += ((char)27).ToString() + ((char)87).ToString() + ((char)1).ToString();
                if (pc == "UNDOUBLEWIDTH") result += ((char)27).ToString() + ((char)87).ToString() + ((char)0).ToString();
                if (pc == "DOUBLEHEIGHT") result += ((char)27).ToString() + ((char)119).ToString() + ((char)1).ToString();
                if (pc == "UNDOUBLEHEIGHT") result += ((char)27).ToString() + ((char)119).ToString() + ((char)0).ToString();
                if (pc == "10CPI") result += ((char)27).ToString() + ((char)80).ToString();
                if (pc == "12CPI") result += ((char)27).ToString() + ((char)77).ToString();
                if (pc == "15CPI") result += ((char)27).ToString() + ((char)103).ToString();
            }
            return result;
        }

        private void Trim(string file)
        {
            StreamReader sr = File.OpenText(file);
            string content = sr.ReadToEnd();
            sr.Close();

            StreamWriter sw = File.CreateText(file);
            content = content.Replace("\r\n", "\n"); 
            foreach(string line in content.Split('\n'))
            {
                sw.WriteLine(line.TrimEnd(' '));
            }
            sw.Close();
        }

        private void SetPageLayout(string file, int noPage, int noColumn)
        {
            StreamReader sr = File.OpenText(file);
            string report = sr.ReadToEnd();
            sr.Close();
 
            report = report.Replace("\r\n", "\n");//remove \r so easy to split  
            report = report.Substring(0, report.LastIndexOf((char)12));  
            string[] pages = report.Split((char)12);
            

            //Find maximum width in a page
            int maxWidth = noColumn; //use the user supplied width
            if (maxWidth == 0) //Calculate the maximum width if zero
            {
                string[] temp = pages[0].Split('\n');
                foreach (string line in temp)
                    if (line.TrimEnd(' ').Length > maxWidth) maxWidth = line.TrimEnd(' ').Length;
            }

            //Build the new report
            StreamWriter sw = File.CreateText(file); 
            string[][] lines = new string[noPage][];
            int max; //no of pages combined into one page
            for (int i = 0; i < pages.Length; i++)
            {
                //Find maximum available pages to be combined into single page
                if (i + noPage - 1 < pages.Length)
                    max = noPage;
                else
                    max = pages.Length - i;

                //Find maximum lines of the available pages
                int maxLine = 0;
                for (int j = 0; j < max; j++)
                {
                    lines[j] = pages[i + j].Split('\n');
                    if (lines[j].Length > maxLine) maxLine = lines[j].Length;
                }

                //Combine the available pages into single page
                for (int k = 0; k < maxLine; k++)
                {
                    for (int j = 0; j < max; j++)
                    {
                        if (k < lines[j].Length)
                            sw.Write(lines[j][k].PadRight(maxWidth, ' '));
                        else
                            sw.Write(" ".PadRight(maxWidth, ' '));
                    }
                    sw.Write("\r\n");
                }
                sw.Write(((char)12).ToString());
                i += max - 1;
            }
            sw.Close(); 
        }
    }
}
