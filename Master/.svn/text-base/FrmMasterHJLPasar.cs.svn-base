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
    public partial class FrmMasterHJLPasar : CAS.Master.BaseMaster
    {
        MySqlDataAdapter dahjl = new MySqlDataAdapter();
        int prevRowHandle = 0;

        public FrmMasterHJLPasar()
        {
            InitializeComponent();
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
            tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnDelete.Click += new EventHandler(tsbtnDelete_Click);
          
            gcHjl.ExGridControl.DataSource = "Select * from hjl";
            gcHjl.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(FrmMasterHJL_Click);
            gcHjl.ExGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(ExGridView_FocusedRowChanged);
            gcHjl.ExGridView.OptionsSelection.MultiSelect = true;

            
         

            SetEditableGridControl(false);            
        }

        void SetEditableGridControl(bool mode)
        {
            gcHjl.ExGridView.OptionsBehavior.Editable = mode;
            gcHjl.ExToolStrip.Items["tsbtnDelete"].Enabled = mode;
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            hjlBindingSource.AllowNew = true;
            SetEditableGridControl(true);
            gcHjl.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gcHjl.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
        }

        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gcHjl.ExGridView.GetDataRow(e.RowHandle);
            row["inv"] = invTextEdit.Text;
            row["remark"] = nameTextEdit.Text;
            row["tanggal"] = DB.loginDate;
        }

        void tsbtnCancel_Click(object sender, EventArgs e)
        {
            if (gcHjl.ExGridView.OptionsBehavior.Editable)
            {
                 casDataSet.hjl.RejectChanges();
                //khrBindingSource.CancelEdit();
                SetEditableGridControl(false);
                gcHjl.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            }
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            SetEditableGridControl(true);
            //curTextEdit_EditValueChanged(sender, new EventArgs());
            gcHjl.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gcHjl.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
        }

        void tsbtnDelete_Click(object sender, EventArgs e)
        {
            if (gcHjl.ExGridView.OptionsBehavior.Editable)
                SetEditableGridControl(false);
        }

        void FrmMasterHJL_Click(object sender, EventArgs e)
        {
            gcHjl.ExGridView.DeleteSelectedRows();
        }

        void ExGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle == gcHjl.ExGridView.RowCount - 1)
                prevRowHandle = e.PrevFocusedRowHandle;
        }

        private void FrmMasterHJLPasar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'casDataSet.hjl' table. You can move, or remove it, as needed.
         //   this.hjlTableAdapter.Fill(this.casDataSet.hjl);
            // TODO: This line of code loads data into the 'casDataSet.inv' table. You can move, or remove it, as needed.
         //   this.invTableAdapter.Fill(this.casDataSet.inv);
            gcHjl.ExGridView.Columns["inv"].Visible = false;
            gcHjl.ExGridView.Columns["remark"].Visible = false;
            gcHjl.ExGridView.Columns["tanggal"].DisplayFormat.FormatString = "dd/MM/yyyy";
            gcHjl.ExGridView.Columns["tanggal"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            gcHjl.ExGridView.Columns["time"].VisibleIndex= 1;
            gcHjl.ExGridView.Columns["time"].DisplayFormat.FormatString = "HH:mm:ss";
            //gcHjl.ExGridView.Columns["tanggal"].ColumnEdit.EditFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            //gcHjl.ExGridView.Columns["tanggal"].ColumnEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
           
        }

        private void invTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            casDataSet.hjl.Clear();
            dahjl = DB.sql.SelectAdapter("Select * from hjl where inv='" + invTextEdit.Text + "'");
            dahjl.Fill(casDataSet.hjl);
            gcHjl.ExGridControl.DataSource = hjlBindingSource;
            gcHjl.ExGridView.BestFitColumns();
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();
            if (gcHjl.ExGridView.EditingValue != null)
                gcHjl.ExGridView.SetFocusedValue(gcHjl.ExGridView.EditingValue);
            base.tsbtnSave_Click(sender, e);
            hjlBindingSource.EndEdit();
            dahjl.Update(casDataSet.hjl);
            //curTextEdit_EditValueChanged(sender, new EventArgs());
            SetEditableGridControl(false);
        }
    }
}

