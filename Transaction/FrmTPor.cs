using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KASLibrary;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraReports.UI;

namespace CAS.Transaction
{
    public partial class FrmTPor : CAS.Transaction.BaseTransaction
    {
        private bool isDetailChanged = false;
        private double qty1OldValue = 0;
        private DataTable copyDetailTable = new DataTable();

        public FrmTPor()
        {
            InitializeComponent();

            ToolStripMenuItem tsmiPrintPreview = new ToolStripMenuItem("Print Preview", null, new EventHandler(tsmiPrintPreview_Click));
            ToolStripMenuItem tsmiPrintDirectly = new ToolStripMenuItem("Print Directly", null, new EventHandler(tsmiPrintDirectly_Click));
            ToolStripDropDownButton tsbtnPrint = new ToolStripDropDownButton("Print", null, tsmiPrintPreview, tsmiPrintDirectly);
            tsbtnPrint.Image = MasterNavigator.Items["tsbtnPrint"].Image;
            MasterNavigator.Items.Insert(MasterNavigator.Items.IndexOfKey("tsbtnPrint"), tsbtnPrint);
            MasterNavigator.Items.RemoveByKey("tsbtnPrint");

            DetailTable.Columns.Add("Unit Base", typeof(String));
            MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);

            //rmaTextBoxEx.ExSqlInstance = DB.sql;

            gcxRmd.ExGridControl.DataSource = pordBindingSource;
            gcxRmd.ExTitleLabel.Text = "Detail PO Retur";
            gcxRmd.ExGridView.OptionsView.ShowGroupPanel = false;
            gcxRmd.ExGridView.OptionsCustomization.AllowSort = false;

            gcxRmd.ExGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(ExGridView_InitNewRow);
            gcxRmd.ExGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(ExGridView_CellValueChanged);
            //gcPrq.ExGridView.ValidateRow += new ValidateRowEventHandler(ExGridView_ValidateRow);            

            gcxRmd.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
            gcxRmd.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
            gcxRmd.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gcxRmd.ExToolStrip.Items["tsbtnNew"].Enabled = false;

            gcxRmd.ExGridView.Columns["por"].Visible = false;
            //gcxRmd.ExGridView.Columns["cct"].OptionsColumn.AllowEdit = false;
            gcxRmd.ExGridView.Columns["remark"].OptionsColumn.AllowEdit = false;
            //gcxRmd.ExGridView.Columns["acc"].OptionsColumn.AllowEdit = false;
           // gcxRmd.ExGridView.Columns["loc"].OptionsColumn.AllowEdit = false;

            gcxRmd.ExGridView.Columns["inv"].ColumnEdit = new GridLookUpEx(DB.sql, "select inv, name as 'Nama Barang', unit as Unit, qtymin from inv", "inv", "inv", gcxRmd.ExGridView, "remark", true, true, "Inventory");
            gcxRmd.ExGridView.Columns["inv"].ColumnEdit.Enter += new EventHandler(ExGridView_InvColumnEdit_Enter);

            gcxRmd.ExGridView.Columns["loc"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('loc')", "loc", "loc", gcxRmd.ExGridView, "", false, false, "Location");
            gcxRmd.ExGridView.Columns["unit"].ColumnEdit = new GridLookUpUnit(gcxRmd.ExGridView);
            gcxRmd.ExGridView.Columns["no"].Visible = false;
            gcxRmd.ExGridView.Columns["toleransi"].Visible = false;
            gcxRmd.ExGridView.Columns["cct"].Visible = false;
            gcxRmd.ExGridView.Columns["acc"].Visible = false;
            gcxRmd.ExGridView.Columns["qty1"].ColumnEdit = new GridNumEx();
            gcxRmd.ExGridView.Columns["qty1"].ColumnEdit.Enter += new EventHandler(qty1ColumnEdit_Enter);
            //gcxRmd.ExGridView.Columns["qty1"].ColumnEdit.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(ColumnEdit_EditValueChanging);
            gcxRmd.ExGridView.Columns["qty"].OptionsColumn.AllowEdit = false;
            gcxRmd.ExGridView.Columns["disc"].ColumnEdit = new GridNumEx(false, true, 0, 100, 1, false);
            //  gcxRmd.ExGridView.Columns["price"].ColumnEdit = new GridNumEx(false, false, 0, MaxValue, 500, false);
            gcxRmd.ExGridView.Columns["toleransi"].ColumnEdit = new GridNumEx(false, true, 0, 100, 1, false);
            gcxRmd.ExGridView.Columns["val"].OptionsColumn.AllowEdit = false;

            gcxRmd.ExGridView.Columns["cct"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('cct')", "", "cct", gcxRmd.ExGridView, "", false, false, "Cost Center");
            gcxRmd.ExGridView.Columns["cct"].ColumnEdit.Enter += new EventHandler(cctColumnEdit_Enter);

            gcxRmd.ExGridView.Columns["acc"].ColumnEdit = new GridLookUpEx(DB.sql, "", "acc", "acc", gcxRmd.ExGridView, "", false, false, "Account");
            gcxRmd.ExGridView.Columns["acc"].ColumnEdit.Enter += new EventHandler(accColumnEdit_Enter);

            gcxRmd.ExGridView.Columns["inv"].Caption = "Kode Barang";
            gcxRmd.ExGridView.Columns["remark"].Caption = "Nama Barang";
            gcxRmd.ExGridView.Columns["loc"].Caption = "Loc";
            gcxRmd.ExGridView.Columns["qty1"].Caption = "Qty";
            gcxRmd.ExGridView.Columns["qty"].Caption = "Qty Base";
            gcxRmd.ExGridView.Columns["unit"].Caption = "Unit";
            gcxRmd.ExGridView.Columns["cct"].Caption = "Cost Center";
            gcxRmd.ExGridView.Columns["price"].Caption = "Price";
            gcxRmd.ExGridView.Columns["per"].Caption = "Per";
            gcxRmd.ExGridView.Columns["toleransi"].Caption = "Tol (%)";
            gcxRmd.ExGridView.Columns["disc"].Caption = "Disc (%)";
            gcxRmd.ExGridView.Columns["val"].Caption = "Val";
            gcxRmd.ExGridView.Columns["acc"].Caption = "Kode Transaksi";
            gcxRmd.ExGridView.Columns["etd"].Caption = "Keterangan";

           // gcSpm.ExGridView.Columns["mor"].VisibleIndex = 1;
            gcxRmd.ExGridView.Columns["inv"].VisibleIndex = 2;
            gcxRmd.ExGridView.Columns["remark"].VisibleIndex = 3;
            gcxRmd.ExGridView.Columns["loc"].VisibleIndex = 4;
            gcxRmd.ExGridView.Columns["qty1"].VisibleIndex =5;
            gcxRmd.ExGridView.Columns["unit"].VisibleIndex = 6;
            gcxRmd.ExGridView.Columns["cct"].VisibleIndex = 7;
            gcxRmd.ExGridView.Columns["price"].VisibleIndex = 8;
            gcxRmd.ExGridView.Columns["per"].VisibleIndex = 8;
            gcxRmd.ExGridView.Columns["toleransi"].VisibleIndex = 9;
            gcxRmd.ExGridView.Columns["disc"].VisibleIndex = 10;
            gcxRmd.ExGridView.Columns["val"].VisibleIndex = 11;
            gcxRmd.ExGridView.Columns["acc"].VisibleIndex = 14;
           
            gcxRmd.ExGridView.Columns["qty"].VisibleIndex = 12;           
            gcxRmd.ExGridView.Columns["Unit Base"].VisibleIndex = 13;//DetailTable.Columns.IndexOf("qty");
            gcxRmd.ExGridView.Columns["etd"].VisibleIndex = 15;

            gcxRmd.ExGridView.BestFitColumns();
            gcxRmd.ExGridView.OptionsBehavior.Editable = false;
            gcxRmd.ExGridView.OptionsSelection.MultiSelect = true;
            gcxRmd.ExGridView.OptionsCustomization.AllowSort = false;

            DB.SetNumberFormat(gcxRmd.ExGridView, "n2");

            TOPSpinEdit.Properties.MinValue = 0;
            TOPSpinEdit.Properties.MaxValue = Int32.MaxValue;
            discSpinEdit.Properties.MinValue = 0;
            discSpinEdit.Properties.MaxValue = Int32.MaxValue;

            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
            tsbtnPrint.Click += new EventHandler(tsbtnPrint_Click);

       //     gcxRmd.ExGridView.Columns["Unit Base"].VisibleIndex = DetailTable.Columns.IndexOf("qty");
            gcxRmd.ExGridView.Columns["Unit Base"].OptionsColumn.AllowEdit = false;
            //tsbtnDelete.Click += new EventHandler(tsbtnDelete_Click);
        }

        void cctColumnEdit_Enter(object sender, EventArgs e)
        {
            if (gcxRmd.ExGridView.GetFocusedRowCellValue("inv") != null)
            {
                string kodeBarang = gcxRmd.ExGridView.GetFocusedRowCellValue("inv").ToString();
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
            if (gcxRmd.ExGridView.GetFocusedRowCellValue("cct") != null &&
               gcxRmd.ExGridView.GetFocusedRowCellValue("inv") != null)
            {
                string cct = gcxRmd.ExGridView.GetFocusedRowCellValue("cct").ToString();
                string kodeBarang = gcxRmd.ExGridView.GetFocusedRowCellValue("inv").ToString();
                if (DB.isBiaya(kodeBarang))
                {
                    //string query = "Select kode.acc as `Account`, acc.name as `Name` from cca, kode, acc where cca.kode = kode.kode and left(cca.cct,1)='" + cct.Substring(0, 1) + "' and kode.acc = acc.acc";
                    //((GridLookUpEx)gcxRmd.ExGridView.Columns["acc"].ColumnEdit).Query = query;
                    ((GridLookUpEx)gcxRmd.ExGridView.Columns["acc"].ColumnEdit).Query = "Call SP_LookUpCca('" + (string)gcxRmd.ExGridView.GetFocusedRowCellValue("cct") + "')";
                    ((ButtonEdit)sender).Enabled = true;
                }
                else
                {
                    ((GridLookUpEx)gcxRmd.ExGridView.Columns["acc"].ColumnEdit).Query = "";
                    ((ButtonEdit)sender).Enabled = false;
                }
            }
            else
            {
                ((GridLookUpEx)gcxRmd.ExGridView.Columns["acc"].ColumnEdit).Query = "";
                ((ButtonEdit)sender).Enabled = false;
            }
        }

        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
            gcxRmd.ExGridView.BestFitColumns();
        }


        void ColumnEdit_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (e.NewValue.ToString() != "")
            {
                if (Convert.ToDouble(e.NewValue) < Convert.ToDouble(qty1OldValue))
                    e.NewValue = qty1OldValue;
                else if (Convert.ToDouble(e.NewValue) > Convert.ToDouble(qty1OldValue))
                    isDetailChanged = true;
            }
        }

        void qty1ColumnEdit_Enter(object sender, EventArgs e)
        {
            qty1OldValue = Convert.ToDouble((sender as DevExpress.XtraEditors.SpinEdit).EditValue);
        }

        void ExGridView_InvColumnEdit_Enter(object sender, EventArgs e)
        {
                GridLookUpEx invLookUp = (GridLookUpEx)gcxRmd.ExGridView.Columns["inv"].ColumnEdit;
                invLookUp.Query = "Call SP_LookUp('inv')";
                invLookUp.TableName = "inv";
          
        }

        void ReCalculateTotal()
        {
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

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            if (this.mode == Mode.Edit)
            {
                isDetailChanged = false;
                gcxRmd.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
                gcxRmd.ExToolStrip.Items["tsbtnNew"].Enabled = true;
                gcxRmd.ExGridView.OptionsBehavior.Editable = true;
                gcxRmd.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                copyDetailTable.Clear();
                copyDetailTable = DetailTable.Copy();
                Utility.SetReadOnly(txtSubtotal, true);
                Utility.SetReadOnly(txtTotal, true);
                Utility.SetReadOnly(txtPPN, true);
            }
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            fpjdateDateEdit.EditValue = DB.loginDate;
            DetailTable.Clear();
            gcxRmd.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcxRmd.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcxRmd.ExGridView.OptionsBehavior.Editable = true;
            gcxRmd.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            ReCalculateTotal();
            ppnCheckBox.Checked = true;
            Utility.SetReadOnly(txtSubtotal, true);
            Utility.SetReadOnly(txtTotal, true);
            Utility.SetReadOnly(txtPPN, true);
        }

        void ExGridView_New_Click(object sender, EventArgs e)
        {
            DataRow row = casDataSet.pord.NewRow();
            row["por"] = NoDocument;
            row["qty"] = 0;
            row["qty1"] = 0;
            row["per"] = 1;
            row["inv"] = "";
            row["loc"] = "";
            row["unit"] = "";
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            casDataSet.pord.Rows.Add(row);

            DB.InsertDetailRows(gcxRmd.ExGridView, row);
        }

        void ExGridView_Delete_Click(object sender, EventArgs e)
        {
            bool canDeleteitem, canDelete = true;
            int[] selectedIndex = gcxRmd.ExGridView.GetSelectedRows();
            for (int i = 0; i < selectedIndex.Length; i++)
            {
                string prq = gcxRmd.ExGridView.GetDataRow(selectedIndex[i])["por"].ToString();
                int no = Convert.ToInt32(gcxRmd.ExGridView.GetDataRow(selectedIndex[i])["no"]);
                canDeleteitem = DeleteLineItem(prq, no);
                if (canDeleteitem == false) canDelete = false;
            }
            if (canDelete) DB.DeleteDetailRows(gcxRmd.ExGridView);
        }

        protected override void tsbtnCancel_Click(object sender, EventArgs e)
        {
            DB.CancelDetailRows(DetailTable);
            remarkMemoEdit.Focus();

            base.tsbtnCancel_Click(sender, new EventArgs());

            if (this.mode == Mode.View)
            {
                gcxRmd.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                gcxRmd.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                gcxRmd.ExGridView.OptionsBehavior.Editable = false;
                gcxRmd.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;

                ReCalculateTotal();
                isDetailChanged = false;

                DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
            }
        }

        private bool isEditAllowed(string por, int no)
        {
            string query = "Select FCanDeleteLineItem('" + DetailTable.TableName.ToString() + "','" + por + "'," + no.ToString() + ")";
            if (DB.sql.Select(query).Rows[0][0].ToString() == "False")
                return false;
            else
                return true;

            //string query = "select d.* from spm m, spd d " +
            //    "where m.spm = d.spm and m.appspm=1 and m.okl_rms='" + rms + "'";
            //DataTable dt = DB.sql.Select(query);
            //if (dt.Rows.Count > 0)
            //    return false;
            //return true;
        }

        void ClosePRRetur()
        {
            //DataTable dt = DB.sql.Select("Call SP_SelectSjrDetailforRms('" + rmaTextBoxEx.EditValue.ToString() + "')");
            //if (dt.Rows.Count == 0)
            //{
            //    string query = "update rma set close=1 where rma='" + rmaTextBoxEx.EditValue.ToString() + "'";
            //    DB.sql.Execute(query);
            //}
        }

        //private bool isPRReturClosed()
        //{
        //    DataTable dt = DB.sql.Select("select `close` from rma where rma='" + rmaTextBoxEx.EditValue.ToString() + "'");
        //    if (Convert.ToInt16(dt.Rows[0][0]) == 1)
        //        return true;
        //    return false;
        //}

        protected override void tsbtnDelete_Click(object sender, EventArgs e)
        {
            base.tsbtnDelete_Click(sender, e);
            if (Convert.ToInt32(MasterTable.Rows[MasterBindingSource.Position]["delete"]) == 1)
                DB.sql.Execute("Call SP_OpenTransaction('POR','" + MasterTable.Rows[MasterBindingSource.Position]["rma"].ToString() + "')");
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            remarkMemoEdit.Focus();
            try
            {
                // Validate controls
                this.ValidateChildren();

                if (gcxRmd.ExGridView.EditingValue != null)
                    gcxRmd.ExGridView.SetFocusedValue(gcxRmd.ExGridView.EditingValue);

                //check if PR Retur is closed
                //if (isPRReturClosed() && mode == Mode.New)
                //    throw new Exception("PR Retur: " + rmaTextBoxEx.EditValue.ToString() + " sudah close");

                if (ctrlSub.txtSub.EditValue.ToString() == "")
                    throw new Exception("Please select Supplier");

                DetailBindingSource.EndEdit();

                //isDetailValid = true;
                //cek empty entry

                double totVal = 0;
                for (int i = DetailTable.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = DetailTable.Rows[i];
                    if (row != null && row.RowState != DataRowState.Deleted)
                    {
                        row[0] = NoDocument;
                        //row["no"] = i + 1;
                        totVal = totVal + (double)row["val"];
                        // check price
                        if ((double)row["val"] == 0)
                            throw new Exception("Harap mengisi price dan quantity!");
                        //check price validity
                        //harga untuk material yg sama harus sama
                        string inv = row["inv"].ToString();
                        string remark = row["remark"].ToString();
                        DataRow[] drDetail = DetailTable.Select("inv='" + inv + "' and remark='" + remark + "'");
                        for (int j = 0; j < drDetail.Length; j++)
                        {
                            if (drDetail[j] != null && drDetail[j].RowState != DataRowState.Deleted)
                            {
                                if (Convert.ToDouble(row["price"]) != Convert.ToDouble(drDetail[j]["price"]))
                                    throw new Exception("Price untuk material: " + inv + "-" + remark + " tidak sama");
                            }
                        }
                    }
                }

                if (isDetailChanged == true)
                    ((DataRowView)MasterBindingSource.Current).Row["aprov"] = 0;

                ((DataRowView)MasterBindingSource.Current).Row["val"] = totVal;
                ((DataRowView)MasterBindingSource.Current).Row["group_"] = 2;
                ((DataRowView)MasterBindingSource.Current).Row["duedate"] = ((DateTime)dateDate.EditValue).AddDays(Convert.ToDouble(TOPSpinEdit.EditValue));

                base.tsbtnSave_Click(sender, e);

           
                if (this.mode == Mode.View)
                {
                    //DB.sql.Execute("Call SP_Save(00000000, 'RSK','" + ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text + "')");

                    //jika mode=edit & PO retur sudah approve, qty1 & price diubah, set approv & close = 0
                    if (isDetailChanged && MasterBindingSource.Position != MasterTable.Rows.Count)
                    {
                        ((DataRowView)MasterBindingSource.Current).Row["aprov"] = Convert.ToInt64(false);
                        ((DataRowView)MasterBindingSource.Current).Row["close"] = Convert.ToInt64(false);
                    }

                    gcxRmd.ExGridView.OptionsBehavior.Editable = false;
                    gcxRmd.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                    gcxRmd.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                    gcxRmd.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                  }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void ExGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "inv")
            {
                //DetailBindingSource.EndEdit();
                DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
                return;
            }
            if (e.Column.FieldName == "unit" || e.Column.FieldName == "qty1" )
            {
                //DetailBindingSource.EndEdit();

                string inv = (string)gcxRmd.ExGridView.GetFocusedRowCellValue("inv");
                string unit = (string)gcxRmd.ExGridView.GetFocusedRowCellValue("unit");
                double qty1 = (double)gcxRmd.ExGridView.GetFocusedRowCellValue("qty1");
                double per = (double)gcxRmd.ExGridView.GetFocusedRowCellValue("per");
                       
                if (per == 0)
                    per = 1;
                if (inv != "" && unit != "")
                {
                    gcxRmd.ExGridView.SetFocusedRowCellValue(gcxRmd.ExGridView.Columns["qty"], DB.GetQtyInBaseUom(inv, unit, qty1));
                    if (e.Column.FieldName == "qty1" || e.Column.FieldName == "per")
                    {
                        int no = Convert.ToInt32(gcxRmd.ExGridView.GetFocusedRowCellValue("no"));
                        if (MasterBindingSource.Position != MasterTable.Rows.Count)
                        {
                            string rms = ludSeri.EditValue.ToString() + "-" + txtPeriod.EditValue.ToString() + "-" + txtNo.EditValue.ToString();
                            double oldQty1 = 0;
                            try
                            {
                                DataRow drCopyDetailTable;
                                drCopyDetailTable = copyDetailTable.Select("no=" + no.ToString())[0];
                                oldQty1 = Convert.ToDouble(drCopyDetailTable["qty1"]);
                            }
                            catch { }
                        }
                        else
                            isDetailChanged = true;
                       
                        double price = (double)gcxRmd.ExGridView.GetFocusedRowCellValue("price");
                        double disc = (double)gcxRmd.ExGridView.GetFocusedRowCellValue("disc");
                        double val = price / per * qty1 * ((100 - disc) / 100);
                        gcxRmd.ExGridView.SetFocusedRowCellValue(gcxRmd.ExGridView.Columns["val"], val);
                        ReCalculateTotal();
                    }
                }
            }
            else if (e.Column.FieldName == "price" || e.Column.FieldName == "disc" || e.Column.FieldName == "per")
            {
                DetailBindingSource.EndEdit();
                double price = 0;
                //cek apakah sudah di-SPM atau tidak
                //jika sudah, harga tidak boleh diedit
                if (e.Column.FieldName == "price" && MasterBindingSource.Position != MasterTable.Rows.Count)
                {
                    string rms = ludSeri.EditValue.ToString() + "-" + txtPeriod.EditValue.ToString() + "-" + txtNo.EditValue.ToString();
                    int no = Convert.ToInt32(gcxRmd.ExGridView.GetFocusedRowCellValue("no"));
                    price = (double)gcxRmd.ExGridView.GetFocusedRowCellValue("price");
                    double oldPrice = 0;
                    try
                    {
                        DataRow drCopyDetailTable;
                        drCopyDetailTable = copyDetailTable.Select("no=" + no.ToString())[0];
                        oldPrice = Convert.ToDouble(drCopyDetailTable["price"]);
                    }
                    catch { }

                    isDetailChanged = true;
                }
                price = (double)gcxRmd.ExGridView.GetFocusedRowCellValue("price");
                double qty1 = (double)gcxRmd.ExGridView.GetFocusedRowCellValue("qty1");
                double disc = (double)gcxRmd.ExGridView.GetFocusedRowCellValue("disc");
                double per = (double)gcxRmd.ExGridView.GetFocusedRowCellValue("per");                    
                double val = price / per * qty1 * ((100 - disc) / 100);
                gcxRmd.ExGridView.SetFocusedRowCellValue(gcxRmd.ExGridView.Columns["val"], val);
                ReCalculateTotal();
            }
            else if (e.Column.FieldName == "qty")
            {
                string inv = (string)gcxRmd.ExGridView.GetFocusedRowCellValue("inv");
                string unit = (string)gcxRmd.ExGridView.GetFocusedRowCellValue("unit");
                double qty = (double)e.Value;//(double)gcOmd.ExGridView.GetFocusedRowCellValue("qty");
                double qty1 = (double)gcxRmd.ExGridView.GetFocusedRowCellValue("qty1");
                if (DB.GetQtyInAlternativeUom(inv, unit, qty) != qty1)
                    gcxRmd.ExGridView.SetFocusedRowCellValue(gcxRmd.ExGridView.Columns["qty1"], DB.GetQtyInAlternativeUom(inv, unit, qty));
            }
        }

        void ExGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gcxRmd.ExGridView.GetDataRow(e.RowHandle);
            row["por"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
            row["per"] =  1;
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            row["toleransi"] = DB.GetToleransi(ctrlSub.txtSub.EditValue.ToString());
        }


        private void FrmTPor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'casDataSet.pord' table. You can move, or remove it, as needed.
            //this.pordTableAdapter.Fill(this.casDataSet.pord);
            // TODO: This line of code loads data into the 'casDataSet.por' table. You can move, or remove it, as needed.
            //this.porTableAdapter.Fill(this.casDataSet.por);
            // TODO: This line of code loads data into the 'casDataSet.pord' table. You can move, or remove it, as needed.
            //this.pordTableAdapter.Fill(this.casDataSet.pord);
            // TODO: This line of code loads data into the 'casDataSet.por' table. You can move, or remove it, as needed.
            //this.porTableAdapter.Fill(this.casDataSet.por);
            Utility.SetSqlInstance(pnlDetail, DB.sql);
            ctrlSub.txtSub.DataBindings.Add("EditValue", MasterBindingSource, "sub");
            ctrlSub.txtSub.EditValueChanged += new EventHandler(txtSub_EditValueChanged);
            Utility.SetNumberFormat(pnlTotal, "n2");
            ReCalculateTotal();
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
            if (MasterBindingSource.Position == MasterTable.Rows.Count)
            {
                ppnCheckBox.Checked = true;
            }

            gcxRmd.ExGridView.BestFitColumns();
        }

        void txtSub_EditValueChanged(object sender, EventArgs e)
        {
            DataRow row = ctrlSub.txtSub.ExGetDataRow();
            if (row == null)
                return;
            curcur.EditValue = row["cur"].ToString();
            TOPSpinEdit.EditValue = row["top"].ToString();
        }

     

        private void txtNo_EditValueChanged(object sender, EventArgs e)
        {
            if (MasterBindingSource.Position != MasterTable.Rows.Count)
            {
                DateTime date = ((DateTime)MasterTable.Rows[MasterBindingSource.Position]["date"]).Date;
                DateTime dueDate;
                if (MasterTable.Rows[MasterBindingSource.Position]["duedate"] != DBNull.Value)
                    dueDate = ((DateTime)MasterTable.Rows[MasterBindingSource.Position]["duedate"]).Date;
                else
                    dueDate = date;
                TOPSpinEdit.EditValue = ((TimeSpan)dueDate.Subtract(date)).TotalDays;
            }
            ReCalculateTotal();
        }

        void tsbtnPrint_Click(object sender, EventArgs e)
        {
            /*string path = Application.StartupPath + "\\Reports\\" + "RepReturbeli" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable temp = DB.sql.Select("call sp_print ('Transaction.FrmTRms','" + this.NoDocument + "')");

            int rowcount = 10;
            int nowrowcount = temp.Rows.Count;
            while (nowrowcount < rowcount)
            {
                DataRow data;
                data = temp.NewRow();

                temp.Rows.InsertAt(data, rowcount);
                nowrowcount++;
            }


            report.DataSource = temp;
            report.ShowPreview();
            */
            
        }

        void tsmiPrintDirectly_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepPor" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            /*report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
            
            report.Bands[BandKind.PageFooter].Controls["lblSummary"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblSummary2"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblUMText"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblUM"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblDPPText"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblDPP"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblPPNText"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblPPN"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblTotal"].Visible = false;
             */

            DataTable dt = DB.sql.Select("Call SP_Print('Transaction.FrmTPor','" + this.NoDocument + "')");
            DataTable dtRep = dt.Clone();
            dtRep.Columns.Add("pageno", typeof(string));
            //report.DataSource = DB.sql.Select("Call SP_Print('" + this.Name + "','" + this.NoDocument + "')");
            int recordsCount = 0;
            int pageno = 1;
            DataRow drRep;
            double subtotal = 0;
            foreach (DataRow dr in dt.Rows)
            {
                recordsCount++;
                string remark = dr["remark"].ToString() + " - " + dr["etd"].ToString();
                //1 row kolom nama barang max 30 karakter
                while (remark.Length > 30)
                {
                    recordsCount++;
                    remark = remark.Substring(0, 30);
                }
                if ((recordsCount > 41 && pageno == 1) || (recordsCount > 40 && pageno > 1))
                {
                    pageno++;
                    recordsCount = 1;
                }
                //saldo dipindahkan
                if (pageno > 1 && recordsCount == 1)
                {
                    drRep = dtRep.NewRow();
                    drRep["remark"] = "Dipindahkan";
                    drRep["val"] = subtotal;
                    drRep["pageno"] = pageno;
                    dtRep.Rows.Add(drRep);
                    recordsCount++;
                }
                drRep = dtRep.NewRow();
                foreach (DataColumn col in dt.Columns)
                    drRep[col.ColumnName] = dr[col.ColumnName];
                drRep["pageno"] = pageno;
                dtRep.Rows.Add(drRep);
                subtotal = subtotal + Convert.ToDouble(dr["val"]);
            }
            report.DataSource = dtRep;
            report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
            report.Bands[BandKind.PageFooter].Controls["xrLblTotalPage"].Text = pageno.ToString();

            report.PrintingSystem.ShowMarginsWarning = false; 
            report.PaperName = "1/2A4";
            report.Print();
        }

        void tsmiPrintPreview_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepPor" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            //report.DataSource = DB.sql.Select("call SP_Print('Transaction.FrmTPor','" + this.NoDocument + "')");
            /*report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
            
            report.Bands[BandKind.PageFooter].Controls["lblSummary"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblSummary2"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblUMText"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblUM"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblDPPText"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblDPP"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblPPNText"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblPPN"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblTotal"].Visible = false;
             */


            DataTable dt = DB.sql.Select("Call SP_Print('Transaction.FrmTPor','" + this.NoDocument + "')");
            DataTable dtRep = dt.Clone();
            dtRep.Columns.Add("pageno", typeof(string));
            //report.DataSource = DB.sql.Select("Call SP_Print('" + this.Name + "','" + this.NoDocument + "')");
            int recordsCount = 0;
            int pageno = 1;
            DataRow drRep;
            double subtotal = 0;
            foreach (DataRow dr in dt.Rows)
            {
                recordsCount++;
                string remark = dr["remark"].ToString() + " - " + dr["etd"].ToString();
                //1 row kolom nama barang max 30 karakter
                while (remark.Length > 30)
                {
                    recordsCount++;
                    remark = remark.Substring(0, 30);
                }
                if ((recordsCount > 41 && pageno == 1) || (recordsCount > 40 && pageno > 1))
                {
                    pageno++;
                    recordsCount = 1;
                }
                //saldo dipindahkan
                if (pageno > 1 && recordsCount == 1)
                {
                    drRep = dtRep.NewRow();
                    drRep["remark"] = "Dipindahkan";
                    drRep["val"] = subtotal;
                    drRep["pageno"] = pageno;
                    dtRep.Rows.Add(drRep);
                    recordsCount++;
                }
                drRep = dtRep.NewRow();
                foreach (DataColumn col in dt.Columns)
                    drRep[col.ColumnName] = dr[col.ColumnName];
                drRep["pageno"] = pageno;
                dtRep.Rows.Add(drRep);
                subtotal = subtotal + Convert.ToDouble(dr["val"]);
            }
            report.DataSource = dtRep;
            report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
            report.Bands[BandKind.PageFooter].Controls["xrLblTotalPage"].Text = pageno.ToString();
         //   report.Bands[BandKind.PageFooter].Text = pageno.ToString();
            report.ShowPreview();
        }


        private void ppnCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ReCalculateTotal();
        }

        private void discSpinEdit_EditValueChanged(object sender, EventArgs e)
        {
            ReCalculateTotal();
        }

        private void aprovCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkToForm1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void remarkLabel_Click(object sender, EventArgs e)
        {

        }

        private void remarkMemoEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pnlDetail_Paint(object sender, PaintEventArgs e)
        {

        }

       
        

        
    }
}

