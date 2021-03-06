using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using KASLibrary;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraReports.UI;

namespace CAS.Transaction
{
    public partial class FrmTOpname : CAS.Transaction.BaseTransaction
    {
        public FrmTOpname()
        {
            InitializeComponent();
            
            DetailTable.Columns.Add("Unit Base", typeof(String));
            MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);

            Utility.SetSqlInstance(pnlDetail, DB.sql);
            gcOpm.ExGridControl.DataSource = opdBindingSource;

            gcOpm.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
            gcOpm.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
            gcOpm.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gcOpm.ExToolStrip.Items["tsbtnNew"].Enabled = false;
            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            //tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);

            gcOpm.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
            gcOpm.ExGridView.CellValueChanged += new CellValueChangedEventHandler(ExGridView_CellValueChanged);

            gcOpm.ExGridView.Columns["opn"].Visible = false;
            gcOpm.ExGridView.Columns["no"].Visible = false;

            gcOpm.ExGridView.Columns["nodsg"].ColumnEdit = new GridLookUpEx(DB.sql, "Call Sp_BppbGetStockBatch(" + ((DateTime)dateDate.EditValue).ToString("yyyyMMdd") + ",'')", "", "No Batch", gcOpm.ExGridView, "", true, true, "Batch");
            gcOpm.ExGridView.Columns["nodsg"].ColumnEdit.Enter += new EventHandler(DsgColumnEdit_Enter);
            gcOpm.ExGridView.Columns["inv"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('invexcludedsg')", "inv", "inv", gcOpm.ExGridView, "", true, true, "Inventory");
            gcOpm.ExGridView.Columns["inv"].ColumnEdit.Enter += new EventHandler(ColumnEdit_Enter);
            gcOpm.ExGridView.Columns["unit"].ColumnEdit = new GridLookUpUnit(gcOpm.ExGridView, "Unit");
        
            gcOpm.ExGridView.Columns["qty"].ColumnEdit = new GridNumEx(500);

            gcOpm.ExTitleLabel.Text = "Stok Opname Detail";
            gcOpm.ExGridView.Columns["nodsg"].Caption = "No Batch";
            gcOpm.ExGridView.Columns["expired"].Caption = "Expired";
            gcOpm.ExGridView.Columns["inv"].Caption = "Kode Barang";
            gcOpm.ExGridView.Columns["remark"].Caption = "Nama Barang";
            gcOpm.ExGridView.Columns["qty"].Caption = "Qty";
            gcOpm.ExGridView.Columns["price"].Caption = "Harga";
            gcOpm.ExGridView.Columns["hpp"].Caption = "HPP";
            gcOpm.ExGridView.Columns["val"].Caption = "Total";

            //gcOpm.ExGridView.Columns["inv"].VisibleIndex = 0;
            //gcOpm.ExGridView.Columns["remark"].VisibleIndex = 1;
            //gcOpm.ExGridView.Columns["nodsg"].VisibleIndex = 2;
            //gcOpm.ExGridView.Columns["expired"].VisibleIndex = 3;


            gcOpm.ExGridView.BestFitColumns();
            
            gcOpm.ExGridView.OptionsBehavior.Editable = false;
            gcOpm.ExGridView.OptionsSelection.MultiSelect = true;
            gcOpm.ExGridView.OptionsCustomization.AllowSort = false;
            gcOpm.ExGridView.OptionsView.ShowGroupPanel = false;
            gcOpm.ExGridView.Columns["Unit Base"].VisibleIndex = DetailTable.Columns.IndexOf("qty");
            gcOpm.ExGridView.Columns["Unit Base"].OptionsColumn.AllowEdit = false;
            gcOpm.ExGridView.Columns["qty"].OptionsColumn.AllowEdit = false;
            gcOpm.ExGridView.Columns["hpp"].OptionsColumn.AllowEdit = false;
            gcOpm.ExGridView.Columns["remark"].OptionsColumn.AllowEdit = false;
            gcOpm.ExGridView.Columns["val"].OptionsColumn.AllowEdit = false;
            tsbtnPrint.Click += new EventHandler(tsbtnPrint_Click);
        }

        void DsgColumnEdit_Enter(object sender, EventArgs e)
        {
            //if (gclhp.ExGridView.GetFocusedRowCellValue("mor") == null)
            //{
            //    ((ButtonEdit)sender).Enabled = true;
            //    return;
            //}
            //if (gclhp.ExGridView.GetFocusedRowCellValue("mor").ToString() == "")
            //    ((ButtonEdit)sender).Enabled = true;
            //else
            //    ((ButtonEdit)sender).Enabled = false;

            string inv;
            inv = gcOpm.ExGridView.GetFocusedRowCellValue("inv").ToString();
            if (gcOpm.ExGridView.GetFocusedRowCellValue("inv") != null)
                (gcOpm.ExGridView.Columns["nodsg"].ColumnEdit as GridLookUpEx).Query = "Call Sp_BppbGetStockBatch(" + DateTime.Now.ToString("yyyyMMdd") + ",'" + inv + "')";
        }

        void ColumnEdit_Enter(object sender, EventArgs e)
        {
            //if (gcOpm.ExGridView.GetFocusedRowCellValue("nodsg") == null)
            //{
            //    ((ButtonEdit)sender).Enabled = true;
            //    return;
            //}

            //if (gcOpm.ExGridView.GetFocusedRowCellValue("nodsg").ToString() == "")
            //    ((ButtonEdit)sender).Enabled = true;
            //else
            //    ((ButtonEdit)sender).Enabled = false;
        }

        void tsbtnPrint_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepOPN" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_Print('Transaction.FrmTOpname','" + this.NoDocument + "')");
            report.ShowPreview();
        }

        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
        }

        private void FrmTOpname_Load(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "274")
            {
                gcOpm.ExGridView.Columns["price"].Visible = false;
                gcOpm.ExGridView.Columns["val"].Visible = false;
                gcOpm.ExGridView.Columns["hpp"].Visible = false;
            }

            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
        }

        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gcOpm.ExGridView.GetDataRow(e.RowHandle);
            row["opn"] = NoDocument;
            //row["no"] = DetailTable.Rows.Count + 1;
            row["no"] = DB.GetRowCount(DetailTable) + 1;
        }

        void ExGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "price" || e.Column.FieldName == "qtc")
            {
                double qty = (double)gcOpm.ExGridView.GetFocusedRowCellValue("qty1");
                double price = (double)gcOpm.ExGridView.GetFocusedRowCellValue("price");
                gcOpm.ExGridView.SetFocusedRowCellValue(gcOpm.ExGridView.Columns["val"], qty * price);
                return;
            }
            if (e.Column.FieldName == "inv")
            {
                if (textBoxExLoc.Text == "") return;
                string query = "select FCariHpp('" + textBoxExLoc.Text + "','" + (string)gcOpm.ExGridView.GetFocusedRowCellValue("inv") + "'," + dateDate.DateTime.ToString("yyyyMMdd") + ",'" + (string)gcOpm.ExGridView.GetFocusedRowCellValue("nodsg") + "')";
                gcOpm.ExGridView.SetFocusedRowCellValue(gcOpm.ExGridView.Columns["hpp"],DB.sql.Select(query).Rows[0][0].ToString());
            }
            if ( e.Column.FieldName == "unit" || e.Column.FieldName == "qty1")
            {
                DetailBindingSource.EndEdit();
                string inv = (string)gcOpm.ExGridView.GetFocusedRowCellValue("inv");
                string unit = (string)gcOpm.ExGridView.GetFocusedRowCellValue("unit");
                double qty1 = (double)gcOpm.ExGridView.GetFocusedRowCellValue("qty1");
                if (inv != "" && unit != "")
                    gcOpm.ExGridView.SetFocusedRowCellValue(gcOpm.ExGridView.Columns["qty"], DB.GetQtyInBaseUom(inv, unit, qty1));
                DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
            }
        }

        void ExGridView_Delete_Click(object sender, EventArgs e)
        {
            DB.DeleteDetailRows(gcOpm.ExGridView);
        }

        void ExGridView_New_Click(object sender, EventArgs e)
        {
            DataRow row = casDataSet.opd.NewRow();
            row["opn"] = NoDocument;
            row["qty"] = 0;
            row["price"] = 0;
            row["hpp"] = 0;
            row["val"] = 0;
            row["inv"] = "";
            row["remark"] = "";
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            casDataSet.opd.Rows.Add(row);

            DB.InsertDetailRows(gcOpm.ExGridView, row);
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            gcOpm.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcOpm.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcOpm.ExGridView.OptionsBehavior.Editable = true;
            gcOpm.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
        }

        protected override void tsbtnCancel_Click(object sender, EventArgs e)
        {
            DB.CancelDetailRows(DetailTable);

            base.tsbtnCancel_Click(sender, new EventArgs());

            if (this.mode == Mode.View)
            {
                gcOpm.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                gcOpm.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                gcOpm.ExGridView.OptionsBehavior.Editable = false;
                gcOpm.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;

                DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
            }
        }
        
        void tsbtnNew_Click(object sender, EventArgs e)
        {
            DetailTable.Clear();
            gcOpm.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcOpm.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcOpm.ExGridView.OptionsBehavior.Editable = true;
            gcOpm.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
        }

        protected override void tsbtnDelete_Click(object sender, EventArgs e)
        {
            base.tsbtnDelete_Click(sender, e);
            if (Convert.ToInt32(MasterTable.Rows[MasterBindingSource.Position]["delete"]) == 1)
                DB.sql.Execute("Call SP_Delete('OPN'" + ",'" + NoDocument + "')");
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate controls
                this.ValidateChildren();

                DetailBindingSource.EndEdit();

                for (int i = 0; i < gcOpm.ExGridView.RowCount; i++)
                {
                    if (gcOpm.ExGridView.GetDataRow(i) != null)
                        if (gcOpm.ExGridView.GetDataRow(i).RowState != DataRowState.Deleted)
                        {
                            if (gcOpm.ExGridView.GetRowCellValue(i,"inv").ToString() == "")
                            {
                                MessageBox.Show("Invalid Kode Barang. Please correct the value");
                                return;
                            }
                            //else
                            //{
                            //    string loc = gcOpm.ExGridView.GetDataRow(i)["loc"].ToString();
                            //    string cct = gcOpm.ExGridView.GetDataRow(i)["cct"].ToString();
                            //    if (cct == "" || loc == "")
                            //    {
                            //        MessageBox.Show("Harap mengisi Cost Center dan Lokasi Gudang untuk Barang yang di Stok Opname");
                            //        return;
                            //    }
                            //}
                        }
                }

                for (int i = DetailTable.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = DetailTable.Rows[i];
                    if (row != null && row.RowState != DataRowState.Deleted)
                    {
                        row[0] = NoDocument;
                    }
                }

                //((DataRowView)MasterBindingSource.Current).Row["aprov"] = (aprovCheckBox.Checked) ? 1 : 0;

                base.tsbtnSave_Click(sender, e);
                string date = ((DateTime)(dateDate.EditValue)).ToString("yyyyMMdd");
                string jurnal = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
                DB.sql.Execute("Call SP_Save(" + date + ",'OPN'" + ",'" + jurnal + "')");

                if (this.mode == Mode.View)
                {
                    gcOpm.ExGridView.OptionsBehavior.Editable = false;
                    gcOpm.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                    gcOpm.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                    gcOpm.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxExLoc_EditValueChanged(object sender, EventArgs e)
        {
            if (gcOpm.ExGridView.RowCount == 0) return;
            for (int i = 0; i < gcOpm.ExGridView.RowCount; i++)
            {
                string query = "select FCariHpp('" + textBoxExLoc.Text + "','" + (string)gcOpm.ExGridView.GetRowCellValue(i, "inv") + "'," + dateDate.DateTime.ToString("yyyyMMdd") + ",'" + (string)gcOpm.ExGridView.GetFocusedRowCellValue("nodsg") + "')";
                gcOpm.ExGridView.SetRowCellValue(i,gcOpm.ExGridView.Columns["hpp"], DB.sql.Select(query).Rows[0][0].ToString());
            }
        }
    }
}