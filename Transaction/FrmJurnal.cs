using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using KASLibrary;
using DevExpress.Utils;

namespace CAS.Transaction
{
    public partial class FrmJurnal : XtraForm
    {
        string m_jurnal;

        public FrmJurnal(string jurnal)
        {
            InitializeComponent();
            m_jurnal = jurnal;
        }

        private void FrmJurnal_Load(object sender, EventArgs e)
        {
            try { Utility.ApplySkin(this); }
            catch { }
            DataTable dtJurnal = DB.sql.Select("SELECT acd.acc, acc.name, dk, round(val,2) as val, 0 as saldo" 
                + " FROM acd, acc WHERE acd.acc=acc.acc and jurnal='" + m_jurnal + "' order by dk");

            double saldo = 0;
            foreach (DataRow drJurnal in dtJurnal.Rows)
            {
                if (drJurnal["dk"].ToString() == "D")
                {
                    saldo += (double)drJurnal["val"];
                    drJurnal["saldo"] = saldo;
                }
                else
                {
                    saldo -= (double)drJurnal["val"];
                    drJurnal["saldo"] = saldo;
                }
            }

            gcxAcd.ExGridControl.DataSource = dtJurnal;
            gcxAcd.ExTitleLabel.Text = "Jurnal " + m_jurnal;

            gcxAcd.ExGridView.Columns["acc"].Caption = "Account";
            gcxAcd.ExGridView.Columns["name"].Caption = "Nama Account";
            gcxAcd.ExGridView.Columns["dk"].Caption = "D/K";
            gcxAcd.ExGridView.Columns["val"].Caption = "Value";
            gcxAcd.ExGridView.Columns["val"].DisplayFormat.FormatType = FormatType.Numeric;
            gcxAcd.ExGridView.Columns["val"].DisplayFormat.FormatString = "N2";
            gcxAcd.ExGridView.Columns["saldo"].Caption = "Saldo";
            gcxAcd.ExGridView.Columns["saldo"].DisplayFormat.FormatType = FormatType.Numeric;
            gcxAcd.ExGridView.Columns["saldo"].DisplayFormat.FormatString = "N2";
            gcxAcd.ExGridView.BestFitColumns();
        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            double aaa = 0;
            string txt = aaa.ToString("0:#,0.0");
        }
    }
}