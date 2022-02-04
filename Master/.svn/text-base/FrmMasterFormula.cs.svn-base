using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KASLibrary;
using MySql.Data.MySqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace CAS.Master
{
    public partial class FrmMasterFormula : CAS.Master.BaseMaster
    {
        MySqlDataAdapter daFmd = new MySqlDataAdapter();
        MySqlDataAdapter daFmc = new MySqlDataAdapter();

        public FrmMasterFormula()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlDetail, DB.sql);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
            tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnDelete.Click += new EventHandler(tsbtnDelete_Click);

            gcfmd.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(FrmMasterCustomer_Click);
            gcfmc.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(FrmMasterCustomer_Click);
            gcfmd.ExGridView.OptionsSelection.MultiSelect = true;
            gcfmc.ExGridView.OptionsSelection.MultiSelect = true;

            SetEditableGridControl(false);
        }

        void SetEditableGridControl(bool mode)
        {
            gcfmd.ExGridView.OptionsBehavior.Editable = mode;
            gcfmd.ExToolStrip.Items["tsbtnDelete"].Enabled = mode;
            gcfmc.ExGridView.OptionsBehavior.Editable = mode;
            gcfmc.ExToolStrip.Items["tsbtnDelete"].Enabled = mode;
        }

        private void FrmMasterFormula_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'casDataSet.fmc' table. You can move, or remove it, as needed.
            //this.fmcTableAdapter.Fill(this.casDataSet.fmc);
            // TODO: This line of code loads data into the 'casDataSet.fmd' table. You can move, or remove it, as needed.
            //this.fmdTableAdapter.Fill(this.casDataSet.fmd);
            // TODO: This line of code loads data into the 'casDataSet.fml' table. You can move, or remove it, as needed.
            //this.fmlTableAdapter.Fill(this.casDataSet.fml);

            casDataSet.fmd.Clear();
            daFmd = DB.sql.SelectAdapter("Select * from fmd where fml='" + fmlTextEdit.EditValue + "'");
            daFmd.Fill(casDataSet.fmd);
            gcfmd.ExGridControl.DataSource = fmdBindingSource;

            gcfmd.ExTitleLabel.Text = "Account";
            gcfmd.ExGridView.Columns["acc"].ColumnEdit = new GridLookUpEx(DB.sql, "select acc as `Account`,left(name,45) as `Account Name` from acc where detil=1", "acc", "acc", gcfmd.ExGridView, "", true, true, "Account");
            gcfmd.ExGridView.Columns["acc"].Caption = "Account";
            gcfmd.ExGridView.Columns["fml"].Visible = false;
            gcfmd.ExGridView.Columns["name"].OptionsColumn.AllowEdit = false;
            gcfmd.ExGridView.Columns["name"].Caption = "Account Name";
            gcfmd.ExGridView.Columns["operator"].Caption = "Operator";
            gcfmd.ExGridView.Columns["value"].Caption = "Value";
            
            casDataSet.fmc.Clear();
            daFmc = DB.sql.SelectAdapter("Select * from fmc where fml='" + fmlTextEdit.EditValue + "'");
            daFmc.Fill(casDataSet.fmc);
            gcfmc.ExGridControl.DataSource = fmcBindingSource;

            gcfmc.ExTitleLabel.Text = "Cost Center";
            gcfmc.ExGridView.Columns["cct"].ColumnEdit = new GridLookUpEx(DB.sql, "select cct as `Cost Center`,left(name,45) as `Cost Center Name` from cct where detil=1", "cct", "cct", gcfmc.ExGridView, "", true, true, "Cost Center");
            gcfmc.ExGridView.Columns["cct"].Caption = "Cost Center";
            gcfmc.ExGridView.Columns["fml"].Visible = false;
            gcfmc.ExGridView.Columns["remark"].Caption = "Cost Center Name";

            gcfmd.ExGridView.OptionsView.ShowGroupPanel = false;
            gcfmc.ExGridView.OptionsView.ShowGroupPanel = false;

            gcfmd.ExGridView.BestFitColumns();
            gcfmc.ExGridView.BestFitColumns();
        }

        private void fmlTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            casDataSet.fmd.Clear();
            daFmd = DB.sql.SelectAdapter("Select * from fmd where fml='" + fmlTextEdit.EditValue + "'");
            daFmd.Fill(casDataSet.fmd);
            gcfmd.ExGridControl.DataSource = fmdBindingSource;
            gcfmd.ExGridView.Columns["fml"].OptionsColumn.AllowEdit = true;
            gcfmd.ExGridView.BestFitColumns();

            casDataSet.fmc.Clear();
            daFmc = DB.sql.SelectAdapter("Select * from fmc where fml='" + fmlTextEdit.EditValue + "'");
            daFmc.Fill(casDataSet.fmc);
            gcfmc.ExGridControl.DataSource = fmcBindingSource;
            gcfmc.ExGridView.Columns["fml"].OptionsColumn.AllowEdit = false;
            gcfmc.ExGridView.BestFitColumns();
        }

        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row1 = gcfmd.ExGridView.GetDataRow(e.RowHandle);
            if (row1 != null) row1["fml"] = fmlTextEdit.EditValue;
            DataRow row2 = gcfmc.ExGridView.GetDataRow(e.RowHandle);
            if (row2 != null) row2["fml"] = fmlTextEdit.EditValue;
        }

        void tsbtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this item?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {
                    DB.sql.BeginTransaction();
                    DB.sql.Execute("delete from fmd where fml='" + fmlTextEdit.EditValue + "'");
                    DB.sql.Execute("delete from fmc where fml='" + fmlTextEdit.EditValue + "'");
                    DB.sql.Execute("delete from fml where fml='" + fmlTextEdit.EditValue + "'");
                    DB.sql.CommitTransaction();
                    base.tsbtnRefresh_Click(sender, e);
                }
                catch (Exception ex)
                {
                    DB.sql.RollbackTransaction();
                    MessageBox.Show("Proses delete gagal");
                }
            }

            if (gcfmd.ExGridView.OptionsBehavior.Editable)
                SetEditableGridControl(false);
            if (gcfmc.ExGridView.OptionsBehavior.Editable)
                SetEditableGridControl(false);
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            fmdBindingSource.AllowNew = true;
            fmcBindingSource.AllowNew = true;
            SetEditableGridControl(true);
            gcfmd.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gcfmc.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gcfmd.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
            gcfmc.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            SetEditableGridControl(true);
            //subTextEdit_EditValueChanged(sender, new EventArgs());
            gcfmd.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gcfmc.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gcfmd.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
            gcfmc.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);

        }

        void tsbtnCancel_Click(object sender, EventArgs e)
        {
            if (gcfmd.ExGridView.OptionsBehavior.Editable)
            {
                casDataSet.fmd.RejectChanges();
                //subTextEdit_EditValueChanged(sender, new EventArgs());
                //SetEditableGridControl(false);
                gcfmd.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            }
            if (gcfmc.ExGridView.OptionsBehavior.Editable)
            {
                casDataSet.fmc.RejectChanges();
                //subTextEdit_EditValueChanged(sender, new EventArgs());
                //SetEditableGridControl(false);
                gcfmc.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            }
            SetEditableGridControl(false);
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();

            if (gcfmd.ExGridView.EditingValue != null)
                gcfmd.ExGridView.SetFocusedValue(gcfmd.ExGridView.EditingValue);

            if (gcfmc.ExGridView.EditingValue != null)
                gcfmc.ExGridView.SetFocusedValue(gcfmc.ExGridView.EditingValue);

            base.tsbtnSave_Click(sender, e);
            fmdBindingSource.EndEdit();
            fmcBindingSource.EndEdit();
            daFmd.Update(casDataSet.fmd);
            daFmc.Update(casDataSet.fmc);
            //subTextEdit_EditValueChanged(sender, new EventArgs());
            SetEditableGridControl(false);
        }

        void FrmMasterCustomer_Click(object sender, EventArgs e)
        {
            gcfmd.ExGridView.DeleteSelectedRows();
            gcfmc.ExGridView.DeleteSelectedRows();
        }

    }
}

