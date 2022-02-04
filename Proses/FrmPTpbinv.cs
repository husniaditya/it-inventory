using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KASLibrary;
using DevExpress.XtraReports.UI;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;


namespace CAS.Proses
{
    public partial class FrmPTpbinv : XtraForm
    {
      public FrmPTpbinv()
      {
         InitializeComponent();
        
      }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DB.sql.Execute("call sincproduct()");
                MessageBox.Show( "Sinkronisasi Sukses ") ;
            }
             

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sinkronisasi GAGAL ");
            }

        }     

    }
}