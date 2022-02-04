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
    public partial class FrmMasterSupplier : CAS.Master.BaseMaster
    {
        private string modenya = "";
        public FrmMasterSupplier()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlDetail, DB.sql);
            casDataSet.sub.Columns["group_"].DefaultValue = 1;

            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
            spinTOP.Properties.MinValue = 0;
            spinTOP.Properties.MaxValue = Int32.MaxValue;
            
            txtCur.ExSqlInstance = DB.sql;
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            modenya = "new";
            //open Group Dialog
            grpTextBoxEx.SendKey(new KeyEventArgs(Keys.Space));
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            modenya = "edit";
        }
        
        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();
            // check Sub no with Group
            if (!subTextEdit.Text.StartsWith(grpTextBoxEx.Text))
            {
                MessageBox.Show("Supplier No does not match Supplier Group!");
                return;
            }
            if (grpTextBoxEx.Text == "")
            {
                MessageBox.Show("Supplier Group is Empty");
                return;
            }
            ((DataRowView)MasterBindingSource.Current).Row["group_"] = 1;

            String dbname1 = Utility.GetConfig("Database1");
            String dbname2 = Utility.GetConfig("Database2");
            String querynya = "";
            String KODE_NEGARA = countryTextEdit.Text;
            String npwp = subnpwpTextEdit.Text;
            String KODE_ID = "";

            if (npwp != "")
            {
                KODE_ID = "1";
            }

            if (modenya == "new")
            {
                querynya = "insert into " + dbname2 + ".referensi_pemasok (ALAMAT,NAMA,NPWP,ID_PEMASOK,KODE_ID,KODE_NEGARA) values ('" + addressMemoEdit.EditValue.ToString().Trim() + "','" + nameTextEdit.EditValue.ToString().Trim() + "','" + subnpwpTextEdit.EditValue.ToString().Trim() + "','" + subTextEdit.EditValue.ToString().Trim() + "','" + KODE_ID + "','" + KODE_NEGARA + "')";
                DB.sql.Execute(querynya);
            }

            if (modenya == "edit")
            {
                querynya = "update " + dbname2 + ".referensi_pemasok set ALAMAT ='" + addressMemoEdit.EditValue.ToString().Trim() + "', NAMA ='" + nameTextEdit.EditValue.ToString().Trim() + "', NPWP ='" + subnpwpTextEdit.EditValue.ToString().Trim() + "', KODE_ID ='" + KODE_ID + "', KODE_NEGARA = '" + KODE_NEGARA + "' where ID_PEMASOK = '" + subTextEdit.EditValue.ToString().Trim() + "'";
                DB.sql.Execute(querynya);
            }

            base.tsbtnSave_Click(sender, e);

            querynya = "update " + dbname1 + ".sub set country = '" + countryTextEdit.ExLabelText.ToString().Trim() + "' where sub = '" + subTextEdit.EditValue.ToString().Trim() + "'";
            DB.sql.Execute(querynya);
        }

        private void FrmMasterSupplier_Load(object sender, EventArgs e)
        {

        }

        private void grpTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {
            // if new record
            if (MasterBindingSource.Position == MasterTable.Rows.Count)
            {
                string query = "select MaxNo('sub','@grp')";
                query = query.Replace("@grp", grpTextBoxEx.Text.Trim());
                subTextEdit.EditValue = DB.sql.Select(query).Rows[0][0].ToString();
                nameTextEdit.Select();
            }
        }

        private void grpTextBoxEx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(0);
        }
    }
}

