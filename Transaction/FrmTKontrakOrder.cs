using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KASLibrary;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using MySql.Data.MySqlClient;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace CAS.Transaction
{
    public partial class FrmTKontrakOrder : CAS.Transaction.BaseTransaction
    {
        public FrmTKontrakOrder()
        {
            InitializeComponent();
            gckon.ExGridControl.DataSource = vpdBindingSource;

            gckon.ExGridView.OptionsView.ShowGroupPanel = false; 
            gckon.ExTitleLabel.Text = "Detail Kontrak";
            gckon.ExGridView.OptionsCustomization.AllowSort = false;

            gckon.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
            gckon.ExGridView.CellValueChanged += new CellValueChangedEventHandler(ExGridView_CellValueChanged);
           
         
            gckon.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
            gckon.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
            gckon.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gckon.ExToolStrip.Items["tsbtnNew"].Enabled = false;

            gckon.ExGridView.Columns["vpo"].OptionsColumn.AllowEdit = false;
            gckon.ExGridView.Columns["inv"].OptionsColumn.AllowEdit = true;
            gckon.ExGridView.Columns["val"].OptionsColumn.AllowEdit = false;
            gckon.ExGridView.Columns["remark"].OptionsColumn.AllowEdit = true;
            gckon.ExGridView.Columns["no"].Visible = false;
            gckon.ExGridView.Columns["vpo"].Visible = false;
            gckon.ExGridView.Columns["inv"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('inv')", "", "inv", gckon.ExGridView, "", true, true, "Inventory");
            gckon.ExGridView.Columns["unit"].ColumnEdit = new GridLookUpUnit(gckon.ExGridView);
          
            gckon.ExGridView.Columns["price"].ColumnEdit = new GridNumEx(500);
            gckon.ExGridView.Columns["val"].ColumnEdit = new GridNumEx(2000);
            
            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);

            gckon.ExGridView.Columns["inv"].Caption = "Kode Barang";
            gckon.ExGridView.Columns["remark"].Caption = "Nama Barang";
            gckon.ExGridView.Columns["qty"].Caption = "Quantity";
            gckon.ExGridView.Columns["unit"].Caption = "Unit";
            gckon.ExGridView.Columns["price"].Caption = "Harga";
            gckon.ExGridView.Columns["val"].Caption = "Total";

            gckon.ExGridView.BestFitColumns();
            gckon.ExGridView.Columns["val"].Width = 100;
            gckon.ExGridView.Columns["remark"].Width = 300;
            gckon.ExGridView.OptionsBehavior.Editable = false;
            gckon.ExGridView.OptionsSelection.MultiSelect = true;
            gckon.ExGridView.OptionsCustomization.AllowSort = false;
            DB.SetNumberFormat(gckon.ExGridView, "n2");
       }


        void ExGridView_Delete_Click(object sender, EventArgs e)
        {
            DB.DeleteDetailRows(gckon.ExGridView);
        }

        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gckon.ExGridView.GetDataRow(e.RowHandle);
            row["vpo"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
            //row["no"] = DetailTable.Rows.Count + 1;
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            row["price"] = 0;
            row["qty"] = 0;
        }

        void ExGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "price" || e.Column.FieldName == "qty")
            {
                double price = (double)gckon.ExGridView.GetFocusedRowCellValue("price");
                double qty = (double)gckon.ExGridView.GetFocusedRowCellValue("qty");
                double val = price * qty;
                gckon.ExGridView.SetFocusedRowCellValue(gckon.ExGridView.Columns["val"], val);
            }
            ReCalculateTotal();
        }

        void ExGridView_New_Click(object sender, EventArgs e)
        {
            DataRow row = casDataSet.vpd.NewRow();
            row["vpo"] = NoDocument;
            row["inv"] = "";
            row["remark"] = "";
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            casDataSet.vpd.Rows.Add(row);

            DB.InsertDetailRows(gckon.ExGridView, row);
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            DetailTable.Clear();
            gckon.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gckon.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gckon.ExGridView.OptionsBehavior.Editable = true;
            gckon.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            Utility.SetReadOnly(txtSubtotal, true);
            Utility.SetReadOnly(txtDisc, true);
            Utility.SetReadOnly(txtPPN, true);
            Utility.SetReadOnly(txtTotal, true);
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            gckon.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gckon.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gckon.ExGridView.OptionsBehavior.Editable = true;
            gckon.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            Utility.SetReadOnly(txtSubtotal, true);
            Utility.SetReadOnly(txtDisc, true);
            Utility.SetReadOnly(txtPPN, true);
            Utility.SetReadOnly(txtTotal, true);
        }

        private void FrmTKontrakOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'casDataSet.vpd' table. You can move, or remove it, as needed.
           // this.vpdTableAdapter.Fill(this.casDataSet.vpd);
            // TODO: This line of code loads data into the 'casDataSet.vpo' table. You can move, or remove it, as needed.
           // this.vpoTableAdapter.Fill(this.casDataSet.vpo);
            Utility.SetSqlInstance(pnlDetail, DB.sql);

            ctrlSub.txtSub.DataBindings.Add("EditValue", vpoBindingSource, "sub");
           
            Utility.SetNumberFormat(pnlTotal, "n2");
            ReCalculateTotal();

        }

      
        void ReCalculateTotal()
        {
            DetailBindingSource.EndEdit();

            double subTotal = 0;
            for (int i = 0; i < DetailTable.Rows.Count; i++)
            {
                if (DetailTable.Rows[i] != null && DetailTable.Rows[i].RowState != DataRowState.Deleted)
                {
                    subTotal = subTotal + (double)DetailTable.Rows[i]["val"];
                }
            }
            txtSubtotal.EditValue = subTotal;

            double disc = subTotal * (Convert.ToDouble(discSpinEdit.EditValue)) / 100;
            txtDisc.EditValue = disc;

            double ppn = 0;
            if (ppnCheckBox.Checked)
                ppn = (subTotal - disc) * 0.1;
            txtPPN.EditValue = ppn;

            double total = subTotal - disc + ppn;
            txtTotal.EditValue = total;
        }

      
        private void discSpinEdit_EditValueChanged(object sender, EventArgs e)
        {
            ReCalculateTotal();
        }

        private void pnlDetail_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ppnCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ReCalculateTotal();
        }
    }
}

