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
using KASLibrary;
using DevExpress.XtraEditors;

namespace CAS.Master
{
    public partial class FrmMasterNoPjkS : CAS.Master.BaseMaster
    {
        MySqlDataAdapter daPjks = new MySqlDataAdapter();
        int prevRowHandle = 0;

        public FrmMasterNoPjkS()
        {
            InitializeComponent();
            tsbtnNew.Visible = false;
            tsbtnDelete.Visible = false;
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
            tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            //tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnDelete.Click += new EventHandler(tsbtnDelete_Click);
            gcPjks.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(FrmMasterNoPjks_Click);
            gcPjks.ExGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(ExGridView_FocusedRowChanged);
            gcPjks.ExGridView.OptionsSelection.MultiSelect = true;
            gcPjks.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gcPjks.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
            SetEditableGridControl(false);
        }

        void ExGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle == gcPjks.ExGridView.RowCount - 1)
                prevRowHandle = e.PrevFocusedRowHandle;
        }

        void SetEditableGridControl(bool mode)
        {
            gcPjks.ExGridView.OptionsBehavior.Editable = mode;
            gcPjks.ExToolStrip.Items["tsbtnDelete"].Enabled = mode;
        }

        void FrmMasterNoPjks_Click(object sender, EventArgs e)
        {
            gcPjks.ExGridView.DeleteSelectedRows();
        }

        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gcPjks.ExGridView.GetDataRow(e.RowHandle);
            row["sub"] = subTextEdit.Text;
            row["chusr"] = DB.casUser.User;
            row["chtime"] = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

        }

        void tsbtnDelete_Click(object sender, EventArgs e)
        {
            if (gcPjks.ExGridView.OptionsBehavior.Editable)
                SetEditableGridControl(false);
        }


        void tsbtnCancel_Click(object sender, EventArgs e)
        {
            if (gcPjks.ExGridView.OptionsBehavior.Editable)
            {
                //gcKhr.ExGridView.CancelUpdateCurrentRow();
                //curTextEdit_EditValueChanged(sender, new EventArgs());
                casDataSet.no_pjks.RejectChanges();
                //khrBindingSource.CancelEdit();
                SetEditableGridControl(false);
                gcPjks.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            }
        }


        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();
            if (gcPjks.ExGridView.EditingValue != null)
                gcPjks.ExGridView.SetFocusedValue(gcPjks.ExGridView.EditingValue);
            MasterBindingSource.EndEdit();
            DataTable dtChanged = MasterTable.GetChanges();
            // MasterAdapter.Update(MasterTable);

            DB.SaveDatalog(dtChanged);

            setMode(Mode.View);
            no_pjksBindingSource.EndEdit();
            daPjks.Update(casDataSet.no_pjks);
            //curTextEdit_EditValueChanged(sender, new EventArgs());
            SetEditableGridControl(false);
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            namaTextEdit.Enabled = false;
            no_pjksBindingSource.AllowNew = true;
            SetEditableGridControl(true);
            gcPjks.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gcPjks.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
        }

        private void FrmMasterNoPjks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'casDataSet.no_pjks' table. You can move, or remove it, as needed.
           // this.no_pjksTableAdapter.Fill(this.casDataSet.no_pjks);
            //// TODO: This line of code loads data into the 'casDataSet.khr' table. You can move, or remove it, as needed.
            //this.khrTableAdapter.Fill(this.casDataSet.khr);
            //// TODO: This line of code loads data into the 'casDataSet.cur' table. You can move, or remove it, as needed.
            //this.curTableAdapter.Fill(this.casDataSet.cur);
            gcPjks.ExGridView.Columns["sub"].Visible = false;
            gcPjks.ExTitleLabel.Visible = false;
            gcPjks.ExToolStrip.Items["tsbtnNew"].Enabled = false;
            gcPjks.ExGridView.OptionsBehavior.Editable = false;
        }

        private void subTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            casDataSet.no_pjks.Clear();
            daPjks = DB.sql.SelectAdapter("Select sub, `tgl awal`, `tgl akhir`, `no awal`, `no akhir`, chusr, chtime from no_pjks where sub='" + subTextEdit.Text + "'");
            daPjks.Fill(casDataSet.no_pjks);
            gcPjks.ExGridControl.DataSource = no_pjksBindingSource;
            string filter = "[period]='" + DB.loginPeriod + "'";
            gcPjks.ExGridView.Columns["period"].FilterInfo = new ColumnFilterInfo(filter, "");

            gcPjks.ExGridView.Columns["name"].OptionsColumn.AllowEdit = false;
            gcPjks.ExGridView.BestFitColumns();
        }

       
    }
}

