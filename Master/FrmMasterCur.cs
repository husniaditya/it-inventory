using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;

namespace CAS.Master
{
    public partial class FrmMasterCur : CAS.Master.BaseMaster
    {
        MySqlDataAdapter daKhr = new MySqlDataAdapter();
        int prevRowHandle = 0;

        public FrmMasterCur()
        {
            InitializeComponent();
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
            tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnDelete.Click += new EventHandler(tsbtnDelete_Click);
            gcKhr.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(FrmMasterCur_Click);
            gcKhr.ExGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(ExGridView_FocusedRowChanged);
            gcKhr.ExGridView.OptionsSelection.MultiSelect = true;
            SetEditableGridControl(false);            
        }

        void ExGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(e.FocusedRowHandle == gcKhr.ExGridView.RowCount - 1) 
                prevRowHandle = e.PrevFocusedRowHandle;
        }

        void SetEditableGridControl(bool mode)
        {
            gcKhr.ExGridView.OptionsBehavior.Editable = mode;
            gcKhr.ExToolStrip.Items["tsbtnDelete"].Enabled = mode;
        }

        void FrmMasterCur_Click(object sender, EventArgs e)
        {
            gcKhr.ExGridView.DeleteSelectedRows();
        }

        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gcKhr.ExGridView.GetDataRow(e.RowHandle);
            row["cur"] = curTextEdit.Text;
            row["date"] = DB.loginDate;
            row["period"] = DB.loginPeriod;
            row["no_sk"] = "";
        }

        void tsbtnDelete_Click(object sender, EventArgs e)
        {
            if (gcKhr.ExGridView.OptionsBehavior.Editable)
                SetEditableGridControl(false);
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            SetEditableGridControl(true);
            //curTextEdit_EditValueChanged(sender, new EventArgs());
            gcKhr.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gcKhr.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);            
        }

        void tsbtnCancel_Click(object sender, EventArgs e)
        {
            if (gcKhr.ExGridView.OptionsBehavior.Editable)
            {
                //gcKhr.ExGridView.CancelUpdateCurrentRow();
                //curTextEdit_EditValueChanged(sender, new EventArgs());
                casDataSet.khr.RejectChanges();
                //khrBindingSource.CancelEdit();
                SetEditableGridControl(false);
                gcKhr.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            }
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();
            if (gcKhr.ExGridView.EditingValue != null)
                gcKhr.ExGridView.SetFocusedValue(gcKhr.ExGridView.EditingValue);
            base.tsbtnSave_Click(sender, e);
            khrBindingSource.EndEdit();
            daKhr.Update(casDataSet.khr);
            //curTextEdit_EditValueChanged(sender, new EventArgs());
            SetEditableGridControl(false);
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            khrBindingSource.AllowNew = true;
            SetEditableGridControl(true);
            gcKhr.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gcKhr.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);            
        }
        
        private void FrmMasterCur_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'casDataSet.khr' table. You can move, or remove it, as needed.
            //this.khrTableAdapter.Fill(this.casDataSet.khr);
            //// TODO: This line of code loads data into the 'casDataSet.cur' table. You can move, or remove it, as needed.
            //this.curTableAdapter.Fill(this.casDataSet.cur);
            gcKhr.ExTitleLabel.Visible = false;
            gcKhr.ExToolStrip.Items["tsbtnNew"].Enabled = false;
            gcKhr.ExGridView.OptionsBehavior.Editable = false;
        }   

        private void curTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            casDataSet.khr.Clear();
            daKhr = DB.sql.SelectAdapter("Select * from khr where cur='" + curTextEdit.Text + "'");
            daKhr.Fill(casDataSet.khr);
            gcKhr.ExGridControl.DataSource = khrBindingSource;
            string filter = "[period]='" + DB.loginPeriod + "'";
            gcKhr.ExGridView.Columns["period"].FilterInfo = new ColumnFilterInfo(filter, "");
            gcKhr.ExGridView.Columns["cur"].OptionsColumn.AllowEdit = false;
            gcKhr.ExGridView.BestFitColumns();
        }
      
    }
}

