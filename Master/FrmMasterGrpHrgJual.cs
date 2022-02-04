using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using KASLibrary;

namespace CAS.Master
{
    public partial class FrmMasterGrpHrgJual : CAS.Master.BaseMaster
    {
        MySqlDataAdapter daSubto = new MySqlDataAdapter();
        public FrmMasterGrpHrgJual()
        {
            InitializeComponent();
           
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
            tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnDelete.Click += new EventHandler(tsbtnDelete_Click);
            gcsubto.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(FrmMasterGrpHrgJual_Click);
            gcsubto.ExGridView.OptionsSelection.MultiSelect = true;          
            
            gcsubto.ExGridControl.DataSource = grphrgjldBindingSource;
            gcsubto.ExGridView.Columns["grphrgjl"].OptionsColumn.AllowEdit = false;
            gcsubto.ExGridView.Columns["grphrgjl"].Caption = "Kode Group Customer";
            gcsubto.ExGridView.Columns["sub"].Caption = "Kode";
            gcsubto.ExGridView.Columns["remark"].Caption = "Nama";
            gcsubto.ExGridView.Columns["sub"].ColumnEdit = new GridLookUpEx(DB.sql, "", "sub", "sub", gcsubto.ExGridView, "", true, true, "Customer");
            gcsubto.ExGridView.Columns["sub"].ColumnEdit.Enter += new EventHandler(ExGridView_subColumnEdit_Enter);           
            gcsubto.ExGridView.BestFitColumns();
            SetEditableGridControl(false);

        }



        void ExGridView_subColumnEdit_Enter(object sender, EventArgs e)
        {
           
            string query = "call sp_lookup('customer');";
            ((GridLookUpEx)gcsubto.ExGridView.Columns["sub"].ColumnEdit).Query = query;
           
        }

        void SetEditableGridControl(bool mode)
        {
            gcsubto.ExGridView.OptionsBehavior.Editable = mode;
            gcsubto.ExToolStrip.Items["tsbtnDelete"].Enabled = mode;
        }
        void FrmMasterGrpHrgJual_Click(object sender, EventArgs e)
        {
            gcsubto.ExGridView.DeleteSelectedRows();
        }

        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gcsubto.ExGridView.GetDataRow(e.RowHandle);
            row["grphrgjl"] = grphrgjlTextEdit.Text;
        }

        void tsbtnDelete_Click(object sender, EventArgs e)
        {
            if (gcsubto.ExGridView.OptionsBehavior.Editable)
                SetEditableGridControl(false);
        }
        
        private void FrmMasterGrpHrgJual_Load(object sender, EventArgs e)
        {       
            
            gcsubto.ExTitleLabel.Visible = false;
            gcsubto.ExToolStrip.Items["tsbtnNew"].Enabled = false;
            gcsubto.ExGridView.OptionsBehavior.Editable = false;
            grphrgjlTextEdit_EditValueChanged(sender, new EventArgs());
        
        }
        void tsbtnNew_Click(object sender, EventArgs e)
        {
            SetEditableGridControl(true);
            //subTextEdit_EditValueChanged(sender, new EventArgs());
            gcsubto.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gcsubto.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);

            
        }

        void tsbtnCancel_Click(object sender, EventArgs e)
        {
            if (gcsubto.ExGridView.OptionsBehavior.Editable)
            {
                casDataSet.grphrgjld.RejectChanges();
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
            base.tsbtnSave_Click(sender, e);
            grphrgjldBindingSource.EndEdit();
            daSubto.Update(casDataSet.grphrgjld);
          
            SetEditableGridControl(false);
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            grphrgjldBindingSource.AllowNew = true;
            SetEditableGridControl(true);
            gcsubto.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gcsubto.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
        }

        

        private void grphrgjlTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            casDataSet.grphrgjld.Clear();
            daSubto = DB.sql.SelectAdapter("Select * from grphrgjld where grphrgjl='" + grphrgjlTextEdit.Text + "'");
            daSubto.Fill(casDataSet.grphrgjld);
            gcsubto.ExGridControl.DataSource = grphrgjldBindingSource;
            gcsubto.ExGridView.Columns["grphrgjl"].OptionsColumn.AllowEdit = false;
            gcsubto.ExGridView.BestFitColumns();

        }

        
        
        
                
        

    }
}

