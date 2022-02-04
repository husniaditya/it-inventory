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
    public partial class FrmMasterHJL1 : CAS.Master.BaseMaster
    {
        MySqlDataAdapter daKon = new MySqlDataAdapter();
        public FrmMasterHJL1()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlDetail, DB.sql);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
            tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnDelete.Click += new EventHandler(tsbtnDelete_Click);

            gcHJL.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(FrmMasterHJL1_Click);
            gcHJL.ExGridView.OptionsSelection.MultiSelect = true;
            hjlBindingSource.AllowNew = true;
            SetEditableGridControl(true);
            gcHJL.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gcHJL.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
        }

        private void FrmMasterHJL1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'casDataSet.hjl' table. You can move, or remove it, as needed.
            //this.hjlTableAdapter.Fill(this.casDataSet.hjl);
            // TODO: This line of code loads data into the 'casDataSet.inv' table. You can move, or remove it, as needed.
            //this.invTableAdapter.Fill(this.casDataSet.inv);
            // TODO: This line of code loads data into the 'casDataSet.hjl' table. You can move, or remove it, as needed.
            //this.hjlTableAdapter.Fill(this.casDataSet.hjl);
            //gcHJL.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(FrmMasterInv_Click);

            gcHJL.ExTitleLabel.Visible = false;
            gcHJL.ExToolStrip.Items["tsbtnNew"].Enabled = false;
            gcHJL.ExGridView.OptionsBehavior.Editable = false;
                       
           

            //gcHJL.ExGridView.Columns["sub"].Caption = "Kode Supplier";
            //gcHJL.ExGridView.Columns["subname"].Caption = "Nama Supplier";
            //gcHJL.ExGridView.Columns["no_po"].Caption = "No PO";
            //gcHJL.ExGridView.Columns["tanggal"].Caption = "Tanggal";
            //gcHJL.ExGridView.Columns["satuan"].Caption = "Satuan";
            //gcHJL.ExGridView.Columns["price"].Caption = "Harga";
            //gcHJL.ExGridView.Columns["remark"].Caption = "Remark";
            //gcHJL.ExGridView.Columns["disc"].Caption = "Discount";
            //gcHJL.ExGridView.Columns["cur"].Caption = "Currency";

            gcHJL.ExGridView.BestFitColumns();
        }

        void SetEditableGridControl(bool mode)
        {
            gcHJL.ExGridView.OptionsBehavior.Editable = mode;
            gcHJL.ExToolStrip.Items["tsbtnDelete"].Enabled = mode;
        }

        void FrmMasterHJL1_Click(object sender, EventArgs e)
        {
            gcHJL.ExGridView.DeleteSelectedRows();
        }

        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gcHJL.ExGridView.GetDataRow(e.RowHandle);
            row["inv"] = invTextBoxEx.Text;
        }

        void tsbtnDelete_Click(object sender, EventArgs e)
        {
            if (gcHJL.ExGridView.OptionsBehavior.Editable)
                SetEditableGridControl(false);
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            SetEditableGridControl(true);
            invTextBoxEx_EditValueChanged(sender, new EventArgs());
            gcHJL.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gcHJL.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);

            //open Jenis Dialog
            //jenisTextBoxEx.SendKey(new KeyEventArgs(Keys.Enter));
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            hjlBindingSource.AllowNew = true;
            SetEditableGridControl(true);
            gcHJL.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gcHJL.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);

        }

        void tsbtnCancel_Click(object sender, EventArgs e)
        {
            if (gcHJL.ExGridView.OptionsBehavior.Editable)
            {
                invTextBoxEx_EditValueChanged(sender, new EventArgs());
                SetEditableGridControl(false);
            }
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();

            if (gcHJL.ExGridView.EditingValue != null)
                gcHJL.ExGridView.SetFocusedValue(gcHJL.ExGridView.EditingValue);

            

            //for new record, set group_=1
            //TODO: change group based on inventory type
            //if (MasterBindingSource.Position == MasterTable.Rows.Count)
           //    ((DataRowView)MasterBindingSource.Current).Row["group_"] = ((DataRowView)MasterBindingSource.Current).Row["inv"].ToString().Substring(0, 1);


            hjlBindingSource.EndEdit();
            daKon.Update(casDataSet.hjl);
            invTextBoxEx_EditValueChanged(sender, new EventArgs());
            SetEditableGridControl(false);

            //base.tsbtnSave_Click(sender, e);
        }

        private void invTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {
            casDataSet.hjl.Clear();
            daKon = DB.sql.SelectAdapter("select * from hjl where inv ='" + invTextBoxEx.Text + "' order by tanggal desc limit 50;");
            daKon.Fill(casDataSet.hjl);
            gcHJL.ExGridControl.DataSource = hjlBindingSource;
            gcHJL.ExGridView.Columns["inv"].OptionsColumn.AllowEdit = false;
            gcHJL.ExGridView.BestFitColumns();
        }

       

        

        
        

    }
}

