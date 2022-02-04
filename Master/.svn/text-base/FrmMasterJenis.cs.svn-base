using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KASLibrary;

namespace CAS.Master
{
    public partial class FrmMasterJenis : CAS.Master.BaseMaster
    {
        public FrmMasterJenis()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlDetail, DB.sql);

            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            //open Mtp Dialog
            mtpTextBoxEx.SendKey(new KeyEventArgs(Keys.Enter));
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();
            // Check if Group Number matches Material Type
            if (!jenisTextEdit.Text.StartsWith(mtpTextBoxEx.Text))
            {
                MessageBox.Show("Group Number (Kode Jenis) does not match Material Type (Mtp)!");
                return;
            }

            base.tsbtnSave_Click(sender, e);
        }

        private void FrmMasterJenis_Load(object sender, EventArgs e)
        {
            
        }

        private void jenisTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            // check if new
            if (MasterBindingSource.Position == MasterTable.Rows.Count)
            {
                if (jenisTextEdit.Text.Length == 3)
                {
                    // Generate number
                    string query = "select MaxJenisNo('@jenis')";
                    query = query.Replace("@jenis", jenisTextEdit.Text);
                    jenisTextEdit.EditValue = DB.sql.Select(query).Rows[0][0].ToString();
                    jenisTextEdit.DoValidate();
                    jenisTextEdit.Select(1, 4);
                }
            }
        }

        private void mtpTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {
            // if new record
            if (MasterBindingSource.Position == MasterTable.Rows.Count)
            {
                jenisTextEdit.EditValue = mtpTextBoxEx.Text.Trim();
                jenisTextEdit.SelectionStart = jenisTextEdit.Text.Length;
            }
        }
    }
}

