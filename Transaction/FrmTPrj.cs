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
using DevExpress.XtraReports.UI;

namespace CAS.Transaction
{
    public partial class FrmTPrj : CAS.Transaction.BaseTransaction
    {
        private int[] selectedIndex = new int[0];
        private bool isDetailValid = true;

        public FrmTPrj()
        {
            InitializeComponent();

            DetailTable.Columns.Add("Unit Base", typeof(String));
            MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);

            gcRma.ExGridControl.DataSource = rmbBindingSource ;
            gcRma.ExTitleLabel.Text = "Pengembalian Barang";
            gcRma.ExGridView.OptionsView.ShowGroupPanel = false;
            gcRma.ExGridView.OptionsCustomization.AllowSort = false;

            gcRma.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
            gcRma.ExGridView.CellValueChanged += new CellValueChangedEventHandler(ExGridView_CellValueChanged);
            
            gcRma.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
            gcRma.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
            gcRma.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gcRma.ExToolStrip.Items["tsbtnNew"].Enabled = false;

            gcRma.ExGridView.Columns["rma"].OptionsColumn.AllowEdit = false;
            gcRma.ExGridView.Columns["qty"].OptionsColumn.AllowEdit = false;

            gcRma.ExGridView.Columns["no"].Visible = false;
            gcRma.ExGridView.Columns["rma"].Visible = false;

            gcRma.ExGridView.Columns["inv"].ColumnEdit = new GridLookUpEx(DB.sql," Call SP_LookUp('inv')", "inv", "inv", gcRma.ExGridView, "remark", true, true, "Inventory");
            
            gcRma.ExGridView.Columns["loc"].ColumnEdit = new GridLookUpEx(DB.sql, "", "loc", "loc", gcRma.ExGridView, "", false, false, "Location");

            gcRma.ExGridView.Columns["cct"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('cct')", "", "cct", gcRma.ExGridView, "", false, false, "Cost Center");
            gcRma.ExGridView.Columns["cct"].ColumnEdit.Enter += new EventHandler(cctColumnEdit_Enter);
            
            gcRma.ExGridView.Columns["unit"].ColumnEdit = new GridLookUpUnit(gcRma.ExGridView);
            gcRma.ExGridView.Columns["unit"].ColumnEdit.ReadOnly = true;

            gcRma.ExGridView.Columns["qty1"].ColumnEdit = new GridNumEx();

            gcRma.ExGridView.Columns["remark"].ColumnEdit = new RepositoryItemTextEdit();
            gcRma.ExGridView.Columns["remark"].ColumnEdit.Enter += new EventHandler(remarkColumnEdit_Enter);
            
            gcRma.ExGridView.Columns["acc"].ColumnEdit = new GridLookUpEx(DB.sql, "", "acc", "acc", gcRma.ExGridView, "", false, false, "Account");
            gcRma.ExGridView.Columns["acc"].ColumnEdit.Enter += new EventHandler(accColumnEdit_Enter);

            gcRma.ExGridView.OptionsBehavior.Editable = false;
            gcRma.ExGridView.OptionsSelection.MultiSelect = true;

            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            //tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
            tsbtnPrint.Click += new EventHandler(tsbtnPrint_Click);

            gcRma.ExGridView.Columns["inv"].Caption = "Kode Barang";
            gcRma.ExGridView.Columns["remark"].Caption = "Nama Barang";
            gcRma.ExGridView.Columns["loc"].Caption = "Loc";
            gcRma.ExGridView.Columns["cct"].Caption = "Cost Center";
            gcRma.ExGridView.Columns["acc"].Caption = "Kode Transaksi";
            gcRma.ExGridView.Columns["qty"].Caption = "Qty Base";
            gcRma.ExGridView.Columns["unit"].Caption = "Unit";
            gcRma.ExGridView.Columns["qty1"].Caption = "Qty";
            gcRma.ExGridView.Columns["etd"].Caption = "Keterangan";

            gcRma.ExGridView.Columns["Unit Base"].VisibleIndex = DetailTable.Columns.IndexOf("qty");
            gcRma.ExGridView.Columns["Unit Base"].OptionsColumn.AllowEdit = false;

            gcRma.ExGridView.BestFitColumns();
        }

        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
            gcRma.ExGridView.BestFitColumns();
        }

        void cctColumnEdit_Enter(object sender, EventArgs e)
        {
            if (gcRma.ExGridView.GetFocusedRowCellValue("inv") != null)
            {
                string kodeBarang = gcRma.ExGridView.GetFocusedRowCellValue("inv").ToString();
                if (DB.isBiaya(kodeBarang))
                    ((ButtonEdit)sender).Enabled = true;
                else
                    ((ButtonEdit)sender).Enabled = false;
            }
            else
                ((ButtonEdit)sender).Enabled = false;
        }

        void accColumnEdit_Enter(object sender, EventArgs e)
        {
            if (gcRma.ExGridView.GetFocusedRowCellValue("cct") != null &&
               gcRma.ExGridView.GetFocusedRowCellValue("inv") != null)
            {
                string cct = gcRma.ExGridView.GetFocusedRowCellValue("cct").ToString();
                string kodeBarang = gcRma.ExGridView.GetFocusedRowCellValue("inv").ToString();
                if (DB.isBiaya(kodeBarang))
                {
                    //string query = "Select kode.acc as `Account`, acc.name as `Name` from cca, kode, acc where cca.kode = kode.kode and left(cca.cct,1)='" + cct.Substring(0, 1) + "' and kode.acc = acc.acc";
                    //((GridLookUpEx)gcRma.ExGridView.Columns["acc"].ColumnEdit).Query = query;
                    ((GridLookUpEx)gcRma.ExGridView.Columns["acc"].ColumnEdit).Query = "Call SP_LookUpCca('" + (string)gcRma.ExGridView.GetFocusedRowCellValue("cct") + "')";
                    ((ButtonEdit)sender).Enabled = true;
                }
                else
                {
                    ((GridLookUpEx)gcRma.ExGridView.Columns["acc"].ColumnEdit).Query = "";
                    ((ButtonEdit)sender).Enabled = false;
                }
            }
            else
            {
                ((GridLookUpEx)gcRma.ExGridView.Columns["acc"].ColumnEdit).Query = "";
                ((ButtonEdit)sender).Enabled = false;
            }
        }

        void remarkColumnEdit_Enter(object sender, EventArgs e)
        {
            if (gcRma.ExGridView.GetFocusedRowCellValue("inv") != null)
            {
                string kodeBarang = gcRma.ExGridView.GetFocusedRowCellValue("inv").ToString();
                if (DB.isBiaya(kodeBarang))
                    ((TextEdit)sender).Properties.ReadOnly = false;
                else
                    ((TextEdit)sender).Properties.ReadOnly = true;
            }
            else
                ((TextEdit)sender).Properties.ReadOnly = true;
        }

        private void FrmTPrj_Load(object sender, EventArgs e)
        {
            //ctrlSub.txtSub.DataBindings.Add("EditValue", rmaBindingSource, "sub");
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
            gcRma.ExGridView.BestFitColumns();
        }

        void ExGridView_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            if (((DataRowView)e.Row).Row["inv"].ToString() == "" ||
                ((DataRowView)e.Row).Row["loc"].ToString() == "" ||
                ((DataRowView)e.Row).Row["unit"].ToString() == "")
            {
                e.Valid = false;
                e.ErrorText = "Invalid Kode Barang/Location/Unit";
                isDetailValid = false;
            }
            else
            { isDetailValid = true; }
        }

        void ExGridView_New_Click(object sender, EventArgs e)
        {
            DataRow row = casDataSet.rmb.NewRow();
            row["rma"] = NoDocument;
            row["qty"] = 0;
            row["qty1"] = 0;
            row["inv"] = "";
            row["loc"] = "";
            row["unit"] = "";
            row["cct"] = "";
            row["remark"] = "";
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            casDataSet.rmb.Rows.Add(row);

            DB.InsertDetailRows(gcRma.ExGridView, row);
        }

        void ExGridView_Delete_Click(object sender, EventArgs e)
        {
            bool canDeleteitem, canDelete = true;
            int[] selectedIndex = gcRma.ExGridView.GetSelectedRows();
            for (int i = 0; i < selectedIndex.Length; i++)
            {
                string prq = gcRma.ExGridView.GetDataRow(selectedIndex[i])["rma"].ToString();
                int no = Convert.ToInt32(gcRma.ExGridView.GetDataRow(selectedIndex[i])["no"]);
                canDeleteitem = DeleteLineItem(prq, no);
                if (canDeleteitem == false) canDelete = false;
            }
            if (canDelete) DB.DeleteDetailRows(gcRma.ExGridView);
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            if (this.mode == Mode.Edit)
                setMode(Mode.Edit);
        }

        protected override void tsbtnCancel_Click(object sender, EventArgs e)
        {
            DB.CancelDetailRows(DetailTable);

            base.tsbtnCancel_Click(sender, new EventArgs());

            if (this.mode == Mode.View)
            {
                //setMode(Mode.View);
                DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
            }
        }

        void tsbtnPrint_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepPRJasa" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("Call SP_Print('" + this.Name + "','" + this.NoDocument + "')");
            report.Bands[BandKind.GroupFooter].Controls["lblUser"].Text = DB.casUser.Name;
            report.ShowPreview();

        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            DetailTable.Clear();
            setMode(Mode.Edit);
            if (MasterBindingSource.Position == 0)
                this.Show();
            //ctrlSub.txtSub.SendKey(new KeyEventArgs(Keys.Enter));
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate controls
                this.ValidateChildren();
                DetailBindingSource.EndEdit();

                //if ((!ctrlSub.txtSub.ExIsValid()) || (ctrlSub.txtSub.Text == ""))
                //{
                //    MessageBox.Show("Inputan Supplier tidak valid");
                //    return;
                //}
                //bool kosong = false;
                //for (int i = 0; i <= DetailTable.Rows.Count-1; i++)
                //{
                //    if (DetailTable.Rows[i].ItemArray[5].ToString() == "") kosong = true; 
                //} 
                //if (kosong)
                //{
                //    MessageBox.Show("Inputan Unit ada yang belum diisi");
                //    return;
                //}


                //for (int i = 0; i < gcRma.ExGridView.RowCount; i++)
                //{
                //    if (gcRma.ExGridView.GetDataRow(i) != null)
                //        if (gcRma.ExGridView.GetDataRow(i).RowState != DataRowState.Deleted)
                //        {
                //            ExGridView_ValidateRow(sender, new ValidateRowEventArgs(i, gcRma.ExGridView.GetRow(i)));
                //            if (!isDetailValid)
                //            {
                //                MessageBox.Show("Invalid Kode Barang/Location. Please correct the value");
                //                return;
                //            }
                //        }
                //}

                for (int i = DetailTable.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = DetailTable.Rows[i];
                    if (row != null && row.RowState != DataRowState.Deleted)
                    {
                        if (row["inv"].ToString() == "" && row["loc"].ToString() == "" && row["unit"].ToString() == "")
                        {
                            MessageBox.Show("Invalid Kode Barang/Location/Unit. Please correct the value");
                            return;
                        }
                        // Check quantity
                        if (Convert.ToDouble(row["qty"]) == 0)
                        {
                            MessageBox.Show("Please enter item quantity");
                            return;
                        }
                        row[0] = this.NoDocument;
                    }
                }

                //((DataRowView)MasterBindingSource.Current).Row["sub"] = ctrlSub.txtSub.Text;
                ((DataRowView)MasterBindingSource.Current).Row["group_"] = 2;

                base.tsbtnSave_Click(sender, e);
                if (this.mode == Mode.View)
                {
                    setMode(Mode.View);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected override void tsbtnDelete_Click(object sender, EventArgs e)
        {
            base.tsbtnDelete_Click(sender, e);
        }

        void ExGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            //if (e.Column.FieldName == "inv")
            //{
            //    DetailBindingSource.EndEdit();
            //    //DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
            //    return;
            //}
            if (e.Column.FieldName == "unit" || e.Column.FieldName == "qty1")
            {
                DetailBindingSource.EndEdit();
                DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
                if (gcRma.ExGridView.GetFocusedRowCellValue("unit") != null &&
                    gcRma.ExGridView.GetFocusedRowCellValue("qty1") != null &&
                    gcRma.ExGridView.GetFocusedRowCellValue("inv") != null &&
                    gcRma.ExGridView.GetFocusedRowCellValue("unit") != DBNull.Value &&
                    gcRma.ExGridView.GetFocusedRowCellValue("qty1") != DBNull.Value)
                {
                    string inv = (string)gcRma.ExGridView.GetFocusedRowCellValue("inv");
                    string unit = (string)gcRma.ExGridView.GetFocusedRowCellValue("unit");
                    double qty1 = (double)gcRma.ExGridView.GetFocusedRowCellValue("qty1");
                    if (inv != "" && unit != "")
                        gcRma.ExGridView.SetRowCellValue(e.RowHandle, gcRma.ExGridView.Columns["qty"], DB.GetQtyInBaseUom(inv, unit, qty1));
                }
            }
        }

        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gcRma.ExGridView.GetDataRow(e.RowHandle);
            row["rma"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
            //row["no"] = DetailTable.Rows.Count + 1;
            row["no"] = DB.GetRowCount(DetailTable) + 1;
        }

        private void setMode(Mode mode)
        {
            gcRma.ExGridView.OptionsBehavior.Editable = (mode == Mode.Edit) ? true : false;
            gcRma.ExGridView.OptionsView.NewItemRowPosition = (mode == Mode.Edit) ? NewItemRowPosition.Bottom : NewItemRowPosition.None;
            gcRma.ExToolStrip.Items["tsbtnDelete"].Enabled = (mode == Mode.Edit) ? true : false;
            gcRma.ExToolStrip.Items["tsbtnNew"].Enabled = (mode == Mode.Edit) ? true : false;
            //ctrlSub.ReadOnly = (mode == Mode.Edit) ? false : true;
        }
    }
}

