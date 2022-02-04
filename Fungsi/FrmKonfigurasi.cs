using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KASLibrary;

namespace CAS.Fungsi
{
    public partial class FrmKonfigurasi : Form
    {
        public FrmKonfigurasi()
        {
            InitializeComponent();
            Utility.SetSqlInstance(tabKeuangan, DB.sql);
        }

        private void FrmKonfigurasi_Load(object sender, EventArgs e)
        {
            LoadAccgl();
        }

        private void LoadAccgl()
        {
            DataTable dtAccgl = DB.sql.Select("select * from accgl");

            foreach (Control control in tabKeuangan.Controls)
            {
                if (!(control is TextBoxEx)) continue;

                TextBoxEx acc = control as TextBoxEx;
                DataRow[] accRow = dtAccgl.Select("remark='" + acc.Name + "'");
                if (accRow.Length > 0)
                    acc.EditValue = accRow[0]["acc"].ToString();
            }
        }

        private void tsbtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            string query = "";
            foreach (Control control in tabKeuangan.Controls)
            {
                if (!(control is TextBoxEx)) continue;

                TextBoxEx acc = control as TextBoxEx;
                if (!acc.ExIsValid())
                {
                    MessageBox.Show("Please correct invalid Acc!");
                    return;
                }
                query += "delete from accgl where remark='@remark';";
                query += "insert into accgl values('@remark','@acc');";
                query = query.Replace("@remark", acc.Name).Replace("@acc", acc.Text);
            }
            try
            {
                bool logData = DB.sql.LogData;
                DB.sql.LogData = false;
                DB.sql.Execute(query);
                DB.sql.LogData = logData;
                MessageBox.Show("Kode Perkiraan saved");
            }
            catch { }
        }
    }
}