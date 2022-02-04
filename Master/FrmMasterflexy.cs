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
    public partial class FrmMasterflexy : CAS.Master.BaseMaster
    {
        public FrmMasterflexy()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlDetail, DB.sql);

         //   tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            //open Mtp Dialog
      //      mtpTextBoxEx.SendKey(new KeyEventArgs(Keys.Enter));
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();

            // Check if Group Number matches Material Type
            //if (!jenisTextEdit.Text.StartsWith(mtpTextBoxEx.Text))
            //{
            //    MessageBox.Show("Group Number (Kode Jenis) does not match Material Type (Mtp)!");
            //    return;
            //}
            ((DataRowView)MasterBindingSource.Current).Row["jenis"] = "flexi";
            base.tsbtnSave_Click(sender, e);
        }

        private void FrmMasterflexy_Load(object sender, EventArgs e)
        {
            
        }

        private void invLabel_Click(object sender, EventArgs e)
        {

        }

        private void invTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (invTextBoxEx.Text != "")
                {
                    remarkTextEdit.EditValue = invTextBoxEx.ExGetDataRow()["name"].ToString();
                }
            }
            catch {
                remarkTextEdit.EditValue = "";
            };

        }

        private void subTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (subTextBoxEx.Text != "")
                {
                    nameTextEdit.EditValue = subTextBoxEx.ExGetDataRow()["name"].ToString();
                }
            }
            catch
            {
                nameTextEdit.EditValue = "";
            };
        }

      
    }
}

