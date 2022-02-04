using System;
using System.Collections.Generic;
using System.Windows.Forms;
using KASLibrary;

namespace CAS
{
    static class Program
    {
        public static FrmWait frmWait;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMainMenu());
        }

        public static void ShowWait(Form Caller)
        {
            frmWait.Show();
            frmWait.Refresh();
            Caller.Cursor = Cursors.WaitCursor;
        }

        public static void EndWait(Form Caller)
        {
            frmWait.Hide();
            Caller.Cursor = Cursors.Default;
        }
    }
}