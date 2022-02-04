using System;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Collections;
using System.Globalization;
using System.Threading;
using System.Reflection;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.IO;
using DevExpress.LookAndFeel; 
using DevExpress.XtraNavBar;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DevExpress.XtraGrid;
using System.Net;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace KASLibrary
{
    public static partial class Utility
    {
        #region " View and Skin "
        public static void ApplyView(NavBarControl navBarControl)
        {
            string view = GetConfig("View");
            for (int i = 0; i < navBarControl.AvailableNavBarViews.Count; i++)
            {
                if (navBarControl.AvailableNavBarViews[i].ViewName == view)
                {
                    navBarControl.View = navBarControl.AvailableNavBarViews[i];
                    break;
                }
            }
        }

        public static void ApplySkin(ISupportLookAndFeel control)
        { 
            if (GetConfig("Skin") == "None")
            {
                control.LookAndFeel.UseDefaultLookAndFeel = true;
                control.LookAndFeel.SkinName = "";
            }
            else
            {
                control.LookAndFeel.UseDefaultLookAndFeel = false;
                control.LookAndFeel.UseWindowsXPTheme = false;
                control.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
                control.LookAndFeel.SkinName = GetConfig("Skin");
            }
            if (control is Control)
            {
                foreach (Control ctrl in ((Control)control).Controls)
                {
                    if (ctrl is ISupportLookAndFeel)
                        ApplySkin((ISupportLookAndFeel)ctrl); 
                }
            }
            //Not needed
            /*if (control is XtraForm)
            {
                ApplyDateTimePickerFormat((Control)control);
            }*/
        }

        /*public static void ApplyDateTimePickerFormat(Control control)
        {
            if(control is DateTimePicker)
            {
                DateTimePicker dtp = (DateTimePicker)control;
                dtp.Format = DateTimePickerFormat.Custom;
                dtp.CustomFormat = "dd MMM yyyy";
            }
            foreach(Control ctrl in control.Controls)
            {
                ApplyDateTimePickerFormat(ctrl);
            }
            if (control is TabControl)
            {
                TabControl tc = (TabControl)control;
                foreach (TabPage tp in tc.TabPages)
                {
                    ApplyDateTimePickerFormat(tp); 
                }
            }
            if (control is XtraTabControl)
            {
                XtraTabControl tc = (XtraTabControl)control;
                foreach (XtraTabPage tp in tc.TabPages)
                {
                    ApplyDateTimePickerFormat(tp);
                }
            }
        }*/

        public static void SetReadOnly(Control control, bool isReadOnly)
        {
            if (control.Tag != null && control.Tag.ToString() == "ReadOnly")
                isReadOnly = true;

            if (control is TextEdit || control is TextBoxEx || control is SpinEdit)
            {
                ((TextEdit)control).Properties.ReadOnly = isReadOnly;
                ((TextEdit)control).BackColor = (isReadOnly) ? System.Drawing.SystemColors.Control : System.Drawing.SystemColors.Window;
            }
            else if (control is TextBox)
            {
                ((TextBox)control).ReadOnly = isReadOnly;
            }
            else if (control is CheckBox)
                ((CheckBox)control).Enabled = !isReadOnly;
            else if (control is RadioGroup)
                ((RadioGroup)control).Enabled = !isReadOnly;
            else if (control is System.Windows.Forms.ComboBox)
                ((System.Windows.Forms.ComboBox)control).Enabled = !isReadOnly;
            else if (control is System.Windows.Forms.MaskedTextBox)
                ((System.Windows.Forms.MaskedTextBox)control).Enabled = !isReadOnly;
            else if (control is System.Windows.Forms.CheckedListBox)
                ((System.Windows.Forms.CheckedListBox)control).Enabled = !isReadOnly;

            else if (control.Controls.Count > 0)
            {
                foreach (Control ctrl in control.Controls)
                {
                    SetReadOnly(ctrl, isReadOnly);
                }
            }
        }

        public static void SetMaxLengths(Control control)
        {
            if (control is TextBox)
            {
                Binding b = control.DataBindings["Text"];
                if (b != null)
                {
                    BindingSource bs = (BindingSource)b.DataSource;
                    int maxLength = ((DataSet)bs.DataSource).Tables[bs.DataMember].Columns[b.BindingMemberInfo.BindingField].MaxLength;
                    if (maxLength >= 0)
                        (control as TextBox).MaxLength = maxLength;
                }
            }
            else if (control is TextEdit || control is TextBoxEx)
            {
                Binding b = control.DataBindings["EditValue"];
                if (b != null)
                {
                    BindingSource bs = (BindingSource)b.DataSource;
                    int maxLength = ((DataSet)bs.DataSource).Tables[bs.DataMember].Columns[b.BindingMemberInfo.BindingField].MaxLength;
                    if (maxLength >= 0)
                        (control as TextEdit).Properties.MaxLength = maxLength;
                }
            }
            else if (control.Controls.Count > 0)
            {
                foreach (Control ctrl in control.Controls)
                {
                    SetMaxLengths(ctrl);
                }
            }
        }

        public static void FocusFirstTextBox(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is TextBox || control is TextEdit || control is TextBoxEx)
                {
                    control.Select();
                    return;
                }
            }
        }

        public static void ClearTexts(Control control)
        {
            if (control is TextEdit || control is TextBoxEx)
                ((TextEdit)control).EditValue = "";
            else if (control is TextBox)
                ((TextBox)control).Clear();
            else if (control.Controls.Count > 0)
            {
                foreach (Control ctrl in control.Controls)
                {
                    ClearTexts(ctrl);
                }
            }
        }

        public static void SetSqlInstance(Control control, SQL sql)
        {
            if (control is TextBoxEx)
                (control as TextBoxEx).ExSqlInstance = sql;

            else if (control.Controls.Count > 0)
            {
                foreach (Control ctrl in control.Controls)
                {
                    SetSqlInstance(ctrl, sql);
                }
            }
        }

        public static void ValidateEditor(Control activeCtrl)
        {
            // post Active Editor's value
            while (activeCtrl is ContainerControl)
                activeCtrl = ((ContainerControl)activeCtrl).ActiveControl;
            if (activeCtrl is DevExpress.XtraEditors.TextBoxMaskBox)
                activeCtrl = activeCtrl.Parent;
            if (activeCtrl is DevExpress.XtraEditors.BaseEdit)
                ((DevExpress.XtraEditors.BaseEdit)activeCtrl).DoValidate();
        }

        public static void SetNumberFormat(Control control, string formatString, string languageId)
        {
            if (control is TextEdit || control is TextBoxEx || control is SpinEdit)
            {
                ((TextEdit)control).EditValue = "";
                ((TextEdit)control).Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                if (languageId != "")
                    ((TextEdit)control).Properties.DisplayFormat.Format = System.Globalization.CultureInfo.CreateSpecificCulture(languageId).NumberFormat;
                ((TextEdit)control).Properties.DisplayFormat.FormatString = formatString;
                
            }
            else if (control.Controls.Count > 0)
            {
                foreach (Control ctrl in control.Controls)
                {
                    SetNumberFormat(ctrl, formatString);
                }
            }
        }

        public static void SetNumberFormat(Control control, string formatString)
        {
            string id = Utility.GetConfig("LanguageID");
            SetNumberFormat(control, formatString, id);
        }
        #endregion

        #region " Configuration File "

        /// <summary>
        /// Retrieve value of a given key in App.Config file
        /// </summary>
        /// <param name="key">Key to find</param>
        /// <returns>Value of the key</returns>
        public static string GetConfig(string key)
        {
            return ConfigurationManager.AppSettings.Get(key) + "";
        }

        /// <summary>
        /// Change key-value pair in App.Config file, add new key-value pair if not already in App.Config file
        /// </summary>
        /// <param name="key">Key to add</param>
        /// <param name="value">Value to add</param>
        public static void SetConfig(string key, string value)
        {
            // Open Exe Configuration File
            Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
 
            if (ConfigurationManager.AppSettings.Get(key) == null)
            {
                // Add new key-value pair setting
                configFile.AppSettings.Settings.Add(key, value);
            }
            else
            {
                configFile.AppSettings.Settings[key].Value = value;
            }

            // Save modified Config File
            configFile.Save(ConfigurationSaveMode.Modified);

            // Reload Settings
            ConfigurationManager.RefreshSection("appSettings");
        }

        #endregion

        #region " Number related functions "
        
        /// <summary>
        /// Indonesian pronunciation of numbers.
        /// </summary>
        /// <param name="number">Number to pronounce</param>
        /// <returns>String of number pronunciation</returns>
        /// <example>NumberToText(5231)="lima ribu dua ratus tiga puluh satu "</example>
        ///
        public static string NumberToTextPecahan(string n)
        {
            string text = "";
            string[] numArray = {"nol","satu","dua","tiga","empat","lima","enam","tujuh","delapan",
                  "sembilan"};
            string elsenumber = n.Substring(1);
            string number = n.Substring(0, 1);
            if (elsenumber == "")
                text = numArray[Convert.ToInt16(number)];
            else
                text = numArray[Convert.ToInt16(number)] + " " + NumberToTextPecahan(elsenumber);
            return text;        
        }


        public static string NumberToTextEN(int n)
        {
            if (n < 0)
                return "Minus " + NumberToTextEN(-n);
            else if (n == 0)
                return "";
            else if (n <= 19)
                return new string[] {"One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", 
         "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", 
         "Seventeen", "Eighteen", "Nineteen"}[n - 1] + " ";
            else if (n <= 99)
                return new string[] {"Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", 
         "Eighty", "Ninety"}[n / 10 - 2] + " " + NumberToTextEN(n % 10);
            else if (n <= 199)
                return "One Hundred " + NumberToTextEN(n % 100);
            else if (n <= 999)
                return NumberToTextEN(n / 100) + "Hundred " + NumberToTextEN(n % 100);
            else if (n <= 1999)
                return "One Thousand " + NumberToTextEN(n % 1000);
            else if (n <= 999999)
                return NumberToTextEN(n / 1000) + "Thousand " + NumberToTextEN(n % 1000);
            else if (n <= 1999999)
                return "One Million " + NumberToTextEN(n % 1000000);
            else if (n <= 999999999)
                return NumberToTextEN(n / 1000000) + "Million " + NumberToTextEN(n % 1000000);
            else if (n <= 1999999999)
                return "One Billion " + NumberToText(n % 1000000000);
            else
                return NumberToTextEN(n / 1000000000) + "Billion " + NumberToTextEN(n % 1000000000);
        }

        public static string NumberToText(double number)
        {
            string text = "";
            string[] numArray = {"","satu","dua","tiga","empat","lima","enam","tujuh","delapan",
                  "sembilan","sepuluh","sebelas"};

            if (number == 0)
                return "";

            if (number < 0)
                return "minus " + NumberToText(-number);

            if (number < 12)
                text = numArray[Convert.ToInt32(number)] + " ";
            else if (number < 20)
                text = NumberToText(number - 10) + "belas ";
            else if (number < 100)
                text = NumberToText(Math.Floor(number / 10)) + "Puluh " + NumberToText(number % 10);
            else if (number < 200)
                text = "seratus " + NumberToText(number % 100);
            else if (number < 1000)
                text = NumberToText(Math.Floor(number / 100)) + "ratus " + NumberToText(number % 100);
            else if (number < 2000)
                text = "seribu " + NumberToText(number % 1000);
            else if (number < 1000000)
                text = NumberToText(Math.Floor(number / 1000)) + "ribu " + NumberToText(number % 1000);
            else if (number < 1000000000)
                text = NumberToText(Math.Floor(number / 1000000)) + "juta " + NumberToText(number % 1000000);
            else if (number < 1000000000000)
                text = NumberToText(Math.Floor(number / 1000000000)) + "miliar " + NumberToText(number % 1000000000);
            else if (number < 1000000000000000)
                text = NumberToText(Math.Floor(number / 1000000000000)) + "triliun " + NumberToText(number % 1000000000000);
            return text;
        }

        /// <summary>
        /// Split a number to a series of smaller values
        /// </summary>
        /// <param name="number">Number to split</param>
        /// <param name="currency">Array of numbers to split into</param>
        /// <returns>Hashtable with Value-Count pairs</returns>
        public static Hashtable Denomination(double number, double[] currency)
        {
            Hashtable denominationHT = new Hashtable();

            foreach (double value in currency)
            {
                denominationHT.Add(value, Math.Floor(number / value));
                number = number % value;
            }
            
            return denominationHT;
        }

        public static Hashtable Pecahan(double number)
        {
            // default Indonesian currency denomination
            double[] currency = { 100000, 50000, 20000, 10000, 5000, 1000, 500, 200, 100 };
            return Denomination(number, currency);
        }

        public static Hashtable Pecahan(double number, double[] currency)
        {
            return Denomination(number, currency);
        }

        /// <summary>
        /// Round a number to closest rounder.
        /// </summary>
        /// <param name="number">Number to round</param>
        /// <param name="rounder">Number to round to</param>
        /// <returns>Rounded number</returns>
        /// <example>RoundTo(1234,100)=1200, RoundTo(1234,50)=1250</example>
        public static double RoundTo(double number, double rounder)
        {
            return Math.Round(number/rounder) * rounder;
        }
        #endregion


        #region " String related functions "
        /// <summary>
        /// Convert Text To Title Case
        /// </summary>
        /// <param name="text">Input Text</param>
        /// <returns>Text in Title Case</returns>
        public static string ToTitleCase(string text)
        {
            TextInfo txtInfo = Thread.CurrentThread.CurrentCulture.TextInfo;
            return txtInfo.ToTitleCase(text.ToLower());
        }
        #endregion

        #region " Date related functions "
        /// <summary>
        /// Convert strings of Date and Time to DateTime
        /// </summary>
        /// <param name="strDate">Input Date string</param>
        /// <param name="strTime">Input Time string</param>
        /// <returns>DateTime</returns>
        public static DateTime StringToDate(string strDate, string strTime)
        {
            return Convert.ToDateTime(strDate).Add(Convert.ToDateTime(strTime).TimeOfDay);
        }
        
        /// <summary>
        /// Get first date of a given month
        /// </summary>
        /// <param name="inputDate">Any date in any month</param>
        /// <returns>First date of the month</returns>
        public static DateTime FirstDateInMonth(DateTime inputDate)
        {
            return new DateTime(inputDate.Year, inputDate.Month, 1);
        }

        /// <summary>
        /// Get last date of a given month
        /// </summary>
        /// <param name="inputDate">Any date in any month</param>
        /// <returns>Last date of the month</returns>
        public static DateTime LastDateInMonth(DateTime inputDate)
        {
            return new DateTime(inputDate.Year, inputDate.Month, 
                DateTime.DaysInMonth(inputDate.Year, inputDate.Month));
        }
        #endregion

        #region " Export/Import to Excel/OO "
        /// <summary>
        /// Read an XLS (Excel) File and import the table to a DataTable
        /// </summary>
        /// <param name="filename">Path of xls file to open</param>
        /// <returns>DataTable representation</returns>
        public static DataTable XLSToDataTable(string filename)
        {
            return XLSToDataTable(filename, "Sheet1");
        }

        public static DataTable XLSToDataTable(string filename, string sheetname)
        {
            DataTable newDataTable = new DataTable();
            OleDbConnection dbConnection = new OleDbConnection();

            try
            {
                // Open OLEDB Connection to Excel
                dbConnection = new OleDbConnection(
                "provider=Microsoft.Jet.OLEDB.4.0; " +
                "data source=" + filename + "; " +
                "Extended Properties='Excel 8.0;HRD=Yes;IMEX=1';");

                // Select the data from Sheet1 of the workbook.
                OleDbDataAdapter dbCommand = new OleDbDataAdapter(
                    "select * from [" + sheetname + "$]", dbConnection);

                // Fill the datatable
                dbCommand.Fill(newDataTable);
            }
            catch
            {
                newDataTable = null;
            }
            finally
            {
                dbConnection.Close();
            }

            return newDataTable;
        }

        /// <summary>
        /// Export DataTable to OpenOffice Calc by COM OpenOffice Automation
        /// </summary>
        /// <param name="dTable">DataTable</param>
        /// <remarks>Reference: http://opendocument4all.com/content/view/68/47/</remarks>
        public static void DataTableToOO(DataTable dTable)
        {
            try
            {
                Object oServiceManager, oDesktop, oDoc;
                
                // Creating service manager
                oServiceManager = Activator.CreateInstance(
                    Type.GetTypeFromProgID("com.sun.star.ServiceManager"));

                // Creating a Desktop to open files
                // oDesktop = oServiceManager.CreateInstance("com.sun.star.frame.Desktop");
                oDesktop = InvokeMethod(oServiceManager, "createinstance", "com.sun.star.frame.Desktop");

                //Create an array for our load parameter  
                Object[] arg = new Object[4];  
                arg[0] = "private:factory/scalc";    // Open openCalc ("swriter" for OpenWriter)
                arg[1] = "_blank";                   // Open a blank file
                arg[2] = 0; 
                arg[3] = new Object[] {};  
                oDoc = InvokeMethod(oDesktop, "loadComponentFromURL", arg);

                Object oSheet = InvokeMethod(oDoc, "getSheets", null);
                Object oSheet1 = InvokeMethod(oSheet, "getByIndex", 0);

                Object oCell;

                int colIndex = 0;
                int rowIndex = 0;
                foreach (DataColumn dcol in dTable.Columns)
                {
                    oCell = InvokeMethod(oSheet1, "getCellByPosition", new Object[2] { colIndex, rowIndex });
                    SetProperty(oCell, "String", dcol.ColumnName);
                    colIndex += 1;
                }

                foreach (DataRow drow in dTable.Rows)
                {
                    rowIndex += 1;
                    colIndex = 0;
                    foreach (DataColumn dcol in dTable.Columns)
                    {
                        oCell = InvokeMethod(oSheet1, "getCellByPosition", new Object[2] { colIndex, rowIndex });
                        if (dcol.DataType == typeof(String))
                            SetProperty(oCell, "String", drow[dcol.ColumnName].ToString());
                        else
                            SetProperty(oCell, "Formula", drow[dcol.ColumnName]);
                        colIndex += 1;
                    }
                }

                Object oCols = InvokeMethod(oSheet1, "getColumns", null);
                SetProperty(oCols, "OptimalWidth", true);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Export to OOCalc Error: " + ex.Message);
            }
        }
            
        #endregion

        #region " COM Wrappers "
        //Used by COM Objects, currently for OpenOffice Automation above, may also be used for Excel Automation

        private static void SetProperty(object obj, string sProperty, object oValue)
        {
            /*if (oValue == DBNull.Value)
                oValue = "";
            if (oValue.GetType() == typeof(DateTime))
                oValue = Convert.ToDateTime(oValue).ToString("dd/MM/yyyy");*/
            object[] oParam = new object[1] { oValue };
            obj.GetType().InvokeMember(sProperty, BindingFlags.SetProperty, null, obj, oParam);
        }
        private static object GetProperty(object obj, string sProperty, object oValue)
        {
            object[] oParam = new object[1] { oValue };
            return obj.GetType().InvokeMember(sProperty, BindingFlags.GetProperty, null, obj, oParam);
        }
        private static object InvokeMethod(object obj, string sMethod, object[] oParam)
        {
            return obj.GetType().InvokeMember(sMethod, BindingFlags.InvokeMethod, null, obj, oParam);
        }
        private static object InvokeMethod(object obj, string sMethod, object oValue)
        {
            object[] oParam = new object[1] { oValue };
            return obj.GetType().InvokeMember(sMethod, BindingFlags.InvokeMethod, null, obj, oParam);
        }
        #endregion

        #region " Encrypt/Decrypt Functions "
        // Source code translated from MSDN: http://support.microsoft.com/kb/317535

        /// <summary>
        /// MD5 String Encryption
        /// </summary>
        /// <param name="sIn">String to encrypt</param>
        /// <param name="sKey">Encryption key</param>
        /// <returns>Encrypted string</returns>
        public static string EncryptTripleDES(string sIn, string sKey)
        {
            TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider hashMD5 = new MD5CryptoServiceProvider();

            // Compute the MD5 hash.
            DES.Key = hashMD5.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(sKey));
            // Set the cipher mode.
            DES.Mode = CipherMode.ECB;
            // Create the encryptor.
            ICryptoTransform DESEncrypt = DES.CreateEncryptor();
            // Get a byte array of the string.
            Byte[] Buffer = System.Text.ASCIIEncoding.ASCII.GetBytes(sIn);
            // Transform and return the string.
            return Convert.ToBase64String(DESEncrypt.TransformFinalBlock(Buffer, 0, Buffer.Length));
        }
        
        /// <summary>
        /// MD5 String Decription
        /// </summary>
        /// <param name="sOut">String to decrypt</param>
        /// <param name="sKey">Encryption key</param>
        /// <returns>Decrypted string</returns>
        public static string DecryptTripleDES(string sOut, string sKey)
        {
            TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider hashMD5 = new MD5CryptoServiceProvider();

            // Compute the MD5 hash.
            DES.Key = hashMD5.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(sKey));
            // Set the cipher mode.
            DES.Mode = CipherMode.ECB;
            // Create the encryptor.
            ICryptoTransform DESDecrypt = DES.CreateDecryptor();
            Byte[] Buffer = Convert.FromBase64String(sOut);
            // Transform and return the string.
            return System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypt.TransformFinalBlock(Buffer, 0, Buffer.Length));
        }
        
        #endregion

        #region " Network Functions "
        /// <summary>
        /// Get this machine first available IP address 
        /// </summary>
        /// <returns>IP address</returns>
        public static string GetIPAddress()
        {
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.GetIPProperties().UnicastAddresses.Count > 0)
                    return ni.GetIPProperties().UnicastAddresses[0].Address.ToString();   
            }
            return "";
        }
        
        /// <summary>
        /// Get this machine host name
        /// </summary>
        /// <returns>Hostname</returns>
        public static string GetHostName()
        {
            return System.Net.Dns.GetHostName();
        }
        /// <summary>
        /// Check whether the URL Exist or not
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static bool CheckURLExist(string url)
        {
            StartingPoint:
            bool result = false;
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.KeepAlive = false;
            request.Method = "HEAD";
            HttpWebResponse response = null;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
                result = true;
                response.Close();
                response = null;
                request = null;
            }
            catch (Exception ex)
            {
                if (response != null) response.Close();
                response = null;
                request.Abort();
                request = null;
                if (!ex.Message.Contains("404"))
                {
                    //Must be: Unable to Connect to Server which is bug so try again
                    goto StartingPoint;
                }
            }
            return result;
        }
        #endregion

        #region " Error Handling Functions "
        /// <summary>
        /// The maximum depth level for expanding the content of the variable
        /// </summary>
        public static int maxDepth = 4;

        /// <summary>
        /// To be called in the catch block. It dumps data into file "exception-[date]-[time].log".
        /// </summary>
        /// <param name="ex">The exception from the catch block</param>
        /// <param name="data">Data to be written into the file. It always in pairs of the variable name and the variable itself.</param>
        public static void ExceptionHandler(Exception ex,params object[] data)
        {
            string filename = Application.StartupPath + "\\exception " + DateTime.Now.ToString().Replace("/","-").Replace(":","-") + ".log";    
            if (File.Exists(filename))
                File.Delete(filename);
            StreamWriter sw = File.CreateText(filename);
            sw.WriteLine(Application.ProductName.ToUpper() + " version " + Application.ProductVersion);
            sw.WriteLine("Run on machine " + GetIPAddress());  
            sw.WriteLine("[EXCEPTION MESSAGE]"); 
            sw.WriteLine(ex.Message);
            sw.WriteLine("[EXCEPTION SOURCE]");
            sw.WriteLine(ex.Source);
            sw.WriteLine("[EXCEPTION STACKTRACE]");
            sw.WriteLine(ex.StackTrace);
            for (int i = 0; i < data.Length; i++)
            {
                if (i % 2 == 0)
                    sw.WriteLine("[" + data[i].ToString() + "]");
                else
                    sw.Write(GetObjectInformation(data[i], 0, 0, true, true).Replace("\n", "\r\n"));
            }
            sw.Close();
            MessageBox.Show("Exception is occured. Details are saved in " + filename + ".\n" +
                "Please send this file to the IT department for further assistance.", "EXCEPTION",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);   
        }

        /// <summary>
        /// Return string representation of an object or a variable.
        /// It can be used with MessageBox to analyze the content of the variable during run time without breakpoint/tracepoint.
        /// If it is from System namespace then only public fields and properties are listed.
        /// If it is not from System namespace then both public and private fields as well as properties are listed.
        /// </summary>
        /// <param name="obj">The variable / object to be analyzed.</param>
        /// <param name="tabCount">The number of tab in the output. Normally is set to 0.</param>
        /// <param name="depth">The starting depth. It will stop probing for further information when it is greater than maxDepth.</param>
        /// <param name="showSelf">True to show the type and value of the object. False to show only fields and properties of the object. Normal value is true</param>
        /// <param name="customProcessing">True to enable custom processing. False to disable custom processing. Normal value is true</param>
        /// <returns>Information about the content of an object or a variable.</returns>
        public static string GetObjectInformation(object obj,int tabCount,int depth,bool showSelf, bool customProcessing)
        {
            if (obj == null || depth > maxDepth) return ""; 
            string result = "";
            string tabs = "";
            if (!showSelf) tabCount--; //reduce tabCount since heading is not shown 
            for (int i = 0; i < tabCount; i++) tabs += "\t"; 
            Type type = obj.GetType();
            if (showSelf)//to avoid duplication when expanding fields or properties
            {
                result += tabs;
                result += type.ToString() + " ";
                result += type.Name + " = ";
                result += (obj == null ? "null" : obj.ToString()) + "\n";
            }

            if (customProcessing)
            {
                #region Custom processing if available
                //Try to call Get*Information methods if available.
                //If available this will surpress the standard output style
                string methodName = "Get" + obj.GetType().Name + "Information";
                object[] args = new object[] { obj, tabCount + 1, depth + 1 };

                Type utilityType = typeof(Utility);
                try
                {
                    result += (string)utilityType.InvokeMember(methodName, BindingFlags.InvokeMethod, null, null, args);
                    return result;
                }
                catch
                {
                    //Do nothing, just continue with the standard processing
                }
                #endregion
            }

            #region Standard processing for Array, Collection, and Classes (not base type and not string)
            if (type.IsArray)
            {
                //Array arr = (Array)obj;
                result += GetArrayInformation((Array)obj, tabCount+1, depth+1);

            }
            else if(type.GetInterface("ICollection") != null)
            {
                result += GetCollectionInformation((ICollection)obj,tabCount+1,depth+1);  
            }
            else if(!type.IsPrimitive && type.FullName!="System.String")   
            {
                if (type.FullName.StartsWith("System"))
                {
                    result += GetFieldsInformation(obj, tabCount + 1, depth + 1, BindingFlags.Public);
                    result += GetPropertiesInformation(obj, tabCount + 1, depth + 1, BindingFlags.Public);
                }
                else
                {
                    result += GetFieldsInformation(obj, tabCount + 1, depth + 1, BindingFlags.Public | BindingFlags.NonPublic);
                    result += GetPropertiesInformation(obj, tabCount + 1, depth + 1, BindingFlags.Public | BindingFlags.NonPublic);
                }
            }
            #endregion

            return result;
        }

        /// <summary>
        /// Get the content of an array. This is a helper function used by GetObjectInformation.
        /// You should use GetObjectInformation instead of using this one.
        /// </summary>
        /// <param name="arr">The array to be probed.</param>
        /// <param name="tabCount">The number of tab in the output string.</param>
        /// <param name="depth">The current depth. If depth is greater than maxDepth then it will return empty string.</param>
        /// <returns>Information about the content of the array.</returns>
        public static string GetArrayInformation(Array arr, int tabCount,int depth)
        {
            if (arr==null || depth > maxDepth) return ""; 
            string result = "";
            string tabs = "";
            for (int x = 0; x < tabCount; x++) tabs += "\t"; 
            IEnumerator iEnum = arr.GetEnumerator();
            int[] index = new int[arr.Rank];
            int i = 0; //one dimensional counter
            int temp = 0; //copy of one dimensional counter for calculation
            int div = 1; //divider value in the calculation
            while (iEnum.MoveNext())
            {
                temp = i; //copy the dimensional counter into temp
                div = 1; //initialize divider into 1
                //calculate dimension indexes from back to front
                for (int j = arr.Rank-1; j >=0; j--)
                {
                    
                    //last index therefore use modulo
                    if (j == arr.Rank - 1)
                    {
                        index[j] = temp % (arr.GetUpperBound(j) + 1);
                    }
                    else
                    {
                        //not last one then divide by prev lengths
                        index[j] = temp / div;
                    }
                    div = div * (arr.GetUpperBound(j) + 1); //Update divider to include this length
                }
                result += tabs;
                //Print the indexes
                for(int j=0;j<arr.Rank;j++)
                    result += "[" + index[j].ToString() + "]";
                result += " = ";
                result += iEnum.Current.ToString() + "\n";
                //if not base type then expand  
                if (!iEnum.Current.GetType().IsPrimitive)
                    result += GetObjectInformation(iEnum.Current, tabCount+1, depth + 1,true, true);   
                i++;//increase the one dimensional counter
            }   
            return result;
        }

        /// <summary>
        /// Get the content of a collection. This is a helper function to be used by GetObjectInformation.
        /// You should use GetObjectInformation instead of using this one.
        /// </summary>
        /// <param name="col">The collection to be probed.</param>
        /// <param name="tabCount">The number of tab in the output string.</param>
        /// <param name="depth">The current depth. If depth is greater than maxDepth then it will return empty string.</param>
        /// <returns>Information about the content of the collection.</returns>
        public static string GetCollectionInformation(ICollection col,int tabCount,int depth)
        {
            if (col == null || depth > maxDepth) return "";
            string result = "";
            string tabs = "";
            for (int x = 0; x < tabCount; x++) tabs += "\t"; 
            IEnumerator iEnum = col.GetEnumerator();
            int i = 0;
            while (iEnum.MoveNext())
            {
                result += tabs + "[" + i.ToString() + "] = " + iEnum.Current.ToString() + "\n";     
                result += GetObjectInformation(iEnum.Current,tabCount+1,depth,true, true);
                i++;
            }
            return result;
        }
        
        /// <summary>
        /// Get the fields information of a class. This is a helper function to be used by GetObjectInformation.
        /// You should use GetObjectInformation instead of using this one.
        /// </summary>
        /// <param name="obj">The class to be probed.</param>
        /// <param name="tabCount">The number of tab in the output string.</param>
        /// <param name="depth">The current depth. If depth is greater than maxDepth then it will return empty string.</param>
        /// <param name="bindingAttr">Can be BindingFlags.Public or BindingFlags.NonPublic or both.</param>
        /// <returns>Information about the fields of the class.</returns>
        public static string GetFieldsInformation(object obj, int tabCount,int depth,BindingFlags bindingAttr)
        {
            if (obj == null || depth > maxDepth) return "";
            string result = "";
            string tabs = "";
            for (int i = 0; i < tabCount; i++) tabs += "\t"; 
            Type type = obj.GetType();
            foreach (FieldInfo fieldInfo in type.GetFields(BindingFlags.Instance | bindingAttr ))
            {
                if(result=="")result += tabs + "[FIELDS]\n";
                result += tabs;
                if (fieldInfo.IsPublic)
                    result += "public ";
                else
                    result += "private ";
                result += fieldInfo.FieldType.ToString() + " ";
                result += fieldInfo.Name + " = ";
                if (fieldInfo.GetValue(obj) == null)
                {
                    result += "null\n";
                }
                else
                {
                    result += fieldInfo.GetValue(obj).ToString() + "\n";
                    if(!fieldInfo.FieldType.IsPrimitive)  
                        result += GetObjectInformation(fieldInfo.GetValue(obj), tabCount + 1, depth + 1,false, true);
                }
            }
            return result;
        }

        /// <summary>
        /// Get the properties information of a class. This is a helper function to be used by GetObjectInformation.
        /// You should use GetObjectInformation instead of using this one.
        /// </summary>
        /// <param name="obj">The class to be probed.</param>
        /// <param name="tabCount">The number of tab in the output string.</param>
        /// <param name="depth">The current depth. If depth is greater than maxDepth then it will return empty string.</param>
        /// <param name="bindingAttr">Can be BindingFlags.Public or BindingFlags.NonPublic or both.</param>
        /// <returns>Information about the properties of the class.</returns>
        public static string GetPropertiesInformation(object obj,int tabCount,int depth,BindingFlags bindingAttr)
        {
            if (obj == null || depth > maxDepth) return "";
            string result = "";
            string tabs = "";
            for (int i = 0; i < tabCount; i++) tabs += "\t"; 
            Type type = obj.GetType();
            foreach (PropertyInfo propertyInfo in type.GetProperties(BindingFlags.Instance | bindingAttr))
            {
                if(result=="")result += tabs + "[PROPERTIES]\n";
                result += tabs;
                result += "public "; 
                result += propertyInfo.PropertyType.ToString() + " ";
                result += propertyInfo.Name + " = ";
                if (propertyInfo.ToString().IndexOf("[") >= 0)
                {
                    result += "[INDEX]\n";
                    try
                    {
                        result += GetArrayInformation((Array)propertyInfo.GetValue(obj, null), tabCount + 1, depth + 1);
                    }
                    catch 
                    {
                        //can't be expanded
                    }
                }
                else
                {
                    try
                    {
                        result += (propertyInfo.GetValue(obj, null) == null ? "null" : propertyInfo.GetValue(obj, null).ToString()) + "\n";
                        if (!propertyInfo.PropertyType.IsPrimitive)
                            result += GetObjectInformation(propertyInfo.GetValue(obj, null), tabCount + 1, depth + 1, false, true);
                    }
                    catch 
                    {
                        result += "[SET ONLY]\n";
                    }
                }
                
            }
            return result;
        }

        #region Custom Processing Methods
        public static string GetDataTableInformation(DataTable tbl, int tabCount, int depth)
        {
            string result = "";
            string tabs = "";
            for (int i = 0; i < tabCount; i++) tabs += "\t"; 
            if (tbl == null || depth > maxDepth) return "";
            
            result += GetObjectInformation(tbl, tabCount, depth, true, false);
    
            result += tabs + "[DATA]\n";
            result += tabs;
            foreach (DataColumn col in tbl.Columns)
            {
                result += col.ColumnName + "\t";
            }
            result += "\n";
            
            foreach (DataRow row in tbl.Rows)
            {
                result += tabs;
                foreach (object obj in row.ItemArray)
                {
                    result += obj.ToString() + "\t"; 
                }
                result += "\n";
                
            }
            return result;
        }
        #endregion
        #endregion

        public static GridColumn GetColumnByCaption(GridView grid, String caption)
        {
            GridColumn result = null;
            for (int i = 0; i <= grid.Columns.Count - 1; i++)
            {
                if (grid.Columns[i].Caption == caption) result = grid.Columns[i];
            }
            return result;
        }

        public static void ShowMessage(string text)
        {
            FrmMessageBox frmMsgBox = new FrmMessageBox();
            frmMsgBox.txtMessage.Text = text;
            frmMsgBox.ShowDialog();
        }

        public static void ShowMessage(string text, string lblmsgtext)
        {
            FrmMessageBox frmMsgBox = new FrmMessageBox();
            frmMsgBox.lblMessage.Text = lblmsgtext;
            frmMsgBox.txtMessage.Text = text;
            frmMsgBox.ShowDialog();
        }
    }
}
