using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DevExpress.XtraGrid.Views.Grid;

 

namespace CAS.Master
{

    public partial class FrmMasterCustomer : CAS.Master.BaseMaster
    {
        MySqlDataAdapter daSubto = new MySqlDataAdapter();
       
        public FrmMasterCustomer()
        {
            InitializeComponent();
            grpTextBoxEx.ExSqlInstance = DB.sql ;
            salesTextBoxEx.ExSqlInstance = DB.sql;
            curTextBoxEx.ExSqlInstance = DB.sql;
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
            tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnDelete.Click += new EventHandler(tsbtnDelete_Click);
            gcsubto.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(FrmMasterCustomer_Click);
            gcsubto.ExGridView.OptionsSelection.MultiSelect = true;
            SetEditableGridControl(false);
        }


        void SetEditableGridControl(bool mode)
        {
            gcsubto.ExGridView.OptionsBehavior.Editable = mode;
            gcsubto.ExToolStrip.Items["tsbtnDelete"].Enabled = mode;
        }
        void FrmMasterCustomer_Click(object sender, EventArgs e)
        {
            gcsubto.ExGridView.DeleteSelectedRows();
        }

        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gcsubto.ExGridView.GetDataRow(e.RowHandle);
            row["sub"] = subTextEdit.Text;
        }

        void tsbtnDelete_Click(object sender, EventArgs e)
        {
            if (gcsubto.ExGridView.OptionsBehavior.Editable)
                SetEditableGridControl(false);
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            SetEditableGridControl(true);
            //subTextEdit_EditValueChanged(sender, new EventArgs());
            gcsubto.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gcsubto.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);

            budgettextEdit.EditValue = 0;

            //open Group Dialog
            grpTextBoxEx.SendKey(new KeyEventArgs(Keys.Enter));
        }

        void tsbtnCancel_Click(object sender, EventArgs e)
        {
             if (gcsubto.ExGridView.OptionsBehavior.Editable)
            {
                casDataSet.subto.RejectChanges();
                //subTextEdit_EditValueChanged(sender, new EventArgs());
                SetEditableGridControl(false);
                gcsubto.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            }
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();


            if (gcsubto.ExGridView.EditingValue != null)
                gcsubto.ExGridView.SetFocusedValue(gcsubto.ExGridView.EditingValue);

            // check Sub no with Group
            if (!subTextEdit.Text.StartsWith(grpTextBoxEx.Text))
            {
                MessageBox.Show("Customer No does not match Customer Group!");
                return;
            }
            subtoBindingSource.EndEdit();
            daSubto.Update(casDataSet.subto); 

            ((DataRowView)MasterBindingSource.Current).Row["group_"] = 2;
             base.tsbtnSave_Click(sender, e);
            //subTextEdit_EditValueChanged(sender, new EventArgs());
            SetEditableGridControl(false);            
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            subtoBindingSource.AllowNew = true;
            SetEditableGridControl(true);
            gcsubto.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gcsubto.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);                      
        }

        private void FrmMasterCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'casDataSet.subto' table. You can move, or remove it, as needed.
            //this.subtoTableAdapter.Fill(this.casDataSet.subto);
            // TODO: This line of code loads data into the 'casDataSet.sub' table. You can move, or remove it, as needed.
           // this.subTableAdapter.Fill(this.casDataSet.sub);
            gcsubto.ExTitleLabel.Visible = false;
            gcsubto.ExToolStrip.Items["tsbtnNew"].Enabled = false;
            gcsubto.ExGridView.OptionsBehavior.Editable = false;
        }

        private void subTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            casDataSet.subto.Clear();
            daSubto = DB.sql.SelectAdapter("Select * from subto where sub='" + subTextEdit.Text + "'");
            daSubto.Fill(casDataSet.subto);
            gcsubto.ExGridControl.DataSource = subtoBindingSource;
            gcsubto.ExGridView.Columns["sub"].OptionsColumn.AllowEdit = false;
            gcsubto.ExGridView.BestFitColumns();
           
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

       
    }
}

