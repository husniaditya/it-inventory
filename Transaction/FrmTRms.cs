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
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraReports.UI;

namespace CAS.Transaction
{
    public partial class FrmTRms : CAS.Transaction.BaseTransaction
    {
        private bool isDetailChanged = false;
        private double qty1OldValue = 0;
        private DataTable copyDetailTable = new DataTable();

        public FrmTRms()
        {
            InitializeComponent();

            DetailTable.Columns.Add("Unit Base", typeof(String));
            MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);

            rmaTextBoxEx.ExSqlInstance = DB.sql;

            gcxRmd.ExGridControl.DataSource = rmdBindingSource;
            gcxRmd.ExTitleLabel.Text = "Detail Retur / Jasa Pembelian";
            gcxRmd.ExGridView.OptionsView.ShowGroupPanel = false;
            gcxRmd.ExGridView.OptionsCustomization.AllowSort = false;
           
            gcxRmd.ExGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(ExGridView_InitNewRow);
            gcxRmd.ExGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(ExGridView_CellValueChanged);
            //gcPrq.ExGridView.ValidateRow += new ValidateRowEventHandler(ExGridView_ValidateRow);            

            gcxRmd.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
            gcxRmd.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
            gcxRmd.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gcxRmd.ExToolStrip.Items["tsbtnNew"].Enabled = false;

            gcxRmd.ExGridView.Columns["rms"].Visible = false;
            //gcxRmd.ExGridView.Columns["cct"].OptionsColumn.AllowEdit = false;
            gcxRmd.ExGridView.Columns["remark"].OptionsColumn.AllowEdit = false;
            //gcxRmd.ExGridView.Columns["acc"].OptionsColumn.AllowEdit = false;
            gcxRmd.ExGridView.Columns["loc"].OptionsColumn.AllowEdit = false;
            gcxRmd.ExGridView.Columns["valpph21"].OptionsColumn.AllowEdit = false;
            gcxRmd.ExGridView.Columns["valpph22"].OptionsColumn.AllowEdit = false;
            gcxRmd.ExGridView.Columns["valpph23"].OptionsColumn.AllowEdit = false;
            gcxRmd.ExGridView.Columns["valpph42"].OptionsColumn.AllowEdit = false;

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
            gcxRmd.ExGridView.Columns["val"].ColumnEdit = new GridNumEx(false, true, 0, 500, 1, false);
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
            gcxRmd.ExGridView.Columns["toleransi"].Caption = "Tol (%)";
            gcxRmd.ExGridView.Columns["disc"].Caption = "Disc (%)";
            gcxRmd.ExGridView.Columns["pph21"].Caption = "PPH 21";
            gcxRmd.ExGridView.Columns["pph22"].Caption = "PPH 22";
            gcxRmd.ExGridView.Columns["pph23"].Caption = "PPH 23";
            gcxRmd.ExGridView.Columns["pph42"].Caption = "PPH 4(2)";
            gcxRmd.ExGridView.Columns["valpph21"].Caption = "Nilai PPH 21";
            gcxRmd.ExGridView.Columns["valpph22"].Caption = "Nilai PPH 22";
            gcxRmd.ExGridView.Columns["valpph23"].Caption = "Nilai PPH 23";
            gcxRmd.ExGridView.Columns["valpph42"].Caption = "Nilai PPH 42";
            gcxRmd.ExGridView.Columns["val"].Caption = "Val";
            gcxRmd.ExGridView.Columns["acc"].Caption = "Kode Transaksi";
            gcxRmd.ExGridView.Columns["etd"].Caption = "Keterangan";

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
            tsbtnDelete.Click += new EventHandler(tsbtnDelete_Click);

            gcxRmd.ExGridView.Columns["inv"].VisibleIndex = 0;
            gcxRmd.ExGridView.Columns["remark"].VisibleIndex = 1;
            gcxRmd.ExGridView.Columns["loc"].VisibleIndex = 2;
            gcxRmd.ExGridView.Columns["qty1"].VisibleIndex = 3;
            gcxRmd.ExGridView.Columns["unit"].VisibleIndex = 4;
            gcxRmd.ExGridView.Columns["qty"].VisibleIndex = 5;
            gcxRmd.ExGridView.Columns["Unit Base"].VisibleIndex = 6;
            gcxRmd.ExGridView.Columns["price"].VisibleIndex = 7;
            gcxRmd.ExGridView.Columns["disc"].VisibleIndex = 8;
            gcxRmd.ExGridView.Columns["pph21"].VisibleIndex = 9;
            gcxRmd.ExGridView.Columns["pph22"].VisibleIndex = 10;
            gcxRmd.ExGridView.Columns["pph23"].VisibleIndex = 11;
            gcxRmd.ExGridView.Columns["pph42"].VisibleIndex = 12;
            gcxRmd.ExGridView.Columns["valpph21"].VisibleIndex = 13;
            gcxRmd.ExGridView.Columns["valpph22"].VisibleIndex = 14;
            gcxRmd.ExGridView.Columns["valpph23"].VisibleIndex = 15;
            gcxRmd.ExGridView.Columns["valpph42"].VisibleIndex = 16;
            gcxRmd.ExGridView.Columns["etd"].VisibleIndex = 17;
            gcxRmd.ExGridView.Columns["val"].VisibleIndex = 18;
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
            if (rmaTextBoxEx.EditValue.ToString() != "")
            {
                GridLookUpEx invLookUp = (GridLookUpEx)gcxRmd.ExGridView.Columns["inv"].ColumnEdit;
                //invLookUp.Query = "select * from rmb where rma='" + rmaTextBoxEx.EditValue.ToString() + "'";
                invLookUp.Query = "Call SP_SelectSjrDetailforRms('" + rmaTextBoxEx.EditValue.ToString() + "')";
                invLookUp.TableName = "rmd";
            }
            else
            {
                GridLookUpEx invLookUp = (GridLookUpEx)gcxRmd.ExGridView.Columns["inv"].ColumnEdit;
                invLookUp.Query = "Call SP_LookUp('inv')";
                invLookUp.TableName = "inv";
            }
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

        protected override void tsbtnDelete_Click(object sender, EventArgs e)
        {
            base.tsbtnDelete_Click(sender, e);
            if (Convert.ToInt32(MasterTable.Rows[MasterBindingSource.Position]["delete"]) == 1)
                DB.sql.Execute("Call SP_Delete('RSK','" + NoDocument + "')");
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
            rmaTextBoxEx.ExAutoCheck = true;
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
            DataRow row = casDataSet.rmd.NewRow();
            row["rms"] = NoDocument;
            row["qty"] = 0;
            row["qty1"] = 0;
            row["inv"] = "";
            row["loc"] = "";
            row["unit"] = "";
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            casDataSet.rmd.Rows.Add(row);

            DB.InsertDetailRows(gcxRmd.ExGridView, row);
        }

        void ExGridView_Delete_Click(object sender, EventArgs e)
        {
            bool canDeleteitem, canDelete = true;
            int[] selectedIndex = gcxRmd.ExGridView.GetSelectedRows();
            for (int i = 0; i < selectedIndex.Length; i++)
            {
                string prq = gcxRmd.ExGridView.GetDataRow(selectedIndex[i])["rms"].ToString();
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
                rmaTextBoxEx.ExAutoCheck = false;
            }
        }

        private bool isEditAllowed(string rms, int no)
        {
            string query = "Select FCanDeleteLineItem('" + DetailTable.TableName.ToString() + "','" + rms + "'," + no.ToString() + ")";
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
                    throw new Exception ("Please select Supplier");

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
                ((DataRowView)MasterBindingSource.Current).Row["duedate"] = ((DateTime)dateDate.EditValue).AddDays(Convert.ToDouble(TOPSpinEdit.EditValue));

                base.tsbtnSave_Click(sender, e);

                if (rmaTextBoxEx.EditValue.ToString() != "")
                    ClosePRRetur();

                if (this.mode == Mode.View)
                {
                    DB.sql.Execute("Call SP_Save(00000000, 'RSK','" + ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text + "')");

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
                    rmaTextBoxEx.ExAutoCheck = false;
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
                DetailBindingSource.EndEdit();
                DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
                return;
            }
            if (e.Column.FieldName == "unit" || e.Column.FieldName == "qty1")
            {
                DetailBindingSource.EndEdit();
               
                string inv = (string)gcxRmd.ExGridView.GetFocusedRowCellValue("inv");
                string unit = (string)gcxRmd.ExGridView.GetFocusedRowCellValue("unit");
                double qty1 = (double)gcxRmd.ExGridView.GetFocusedRowCellValue("qty1");
                if (inv != "" && unit != "")
                {
                    gcxRmd.ExGridView.SetFocusedRowCellValue(gcxRmd.ExGridView.Columns["qty"], DB.GetQtyInBaseUom(inv, unit, qty1));
                    if (e.Column.FieldName == "qty1")
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
                            if (oldQty1 != 0 && oldQty1 != qty1)
                            {
                                if (!isEditAllowed(rms, no))
                                {
                                    MessageBox.Show("Edit qty tidak diperbolehkan karena sudah ada SPM!");
                                    gcxRmd.ExGridView.SetFocusedRowCellValue(gcxRmd.ExGridView.Columns["qty1"], oldQty1);
                                    return;
                                }
                                else
                                {
                                    if (qty1 < oldQty1)
                                    {
                                        MessageBox.Show("Qty tidak valid!");
                                        gcxRmd.ExGridView.SetFocusedRowCellValue(gcxRmd.ExGridView.Columns["qty1"], oldQty1);
                                        ReCalculateTotal();
                                        return;
                                    }
                                    isDetailChanged = true;
                                }
                            }
                        }
                        else
                            isDetailChanged = true;
                        double price = (double)gcxRmd.ExGridView.GetFocusedRowCellValue("price");
                        double disc = (double)gcxRmd.ExGridView.GetFocusedRowCellValue("disc");
                        double val = price * qty1 * ((100 - disc) / 100);
                        gcxRmd.ExGridView.SetFocusedRowCellValue(gcxRmd.ExGridView.Columns["val"], val);
                        ReCalculateTotal();
                    }
                }
            }
            else if (e.Column.FieldName == "price"||e.Column.FieldName == "disc")
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
                    if (!isEditAllowed(rms, no) && oldPrice != 0 && oldPrice != price)
                    {
                        MessageBox.Show("Edit price tidak diperbolehkan karena sudah ada SPM!");
                        gcxRmd.ExGridView.SetFocusedRowCellValue(gcxRmd.ExGridView.Columns["price"], oldPrice);
                        return;
                    }
                    else
                        isDetailChanged = true;
                }
                price = (double)gcxRmd.ExGridView.GetFocusedRowCellValue("price");
                double qty1 = (double)gcxRmd.ExGridView.GetFocusedRowCellValue("qty1");
                double disc = (double)gcxRmd.ExGridView.GetFocusedRowCellValue("disc");
                double val = price * qty1 * ((100 - disc) / 100);
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
            row["rms"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
            //row["no"] = DetailTable.Rows.Count + 1;
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            row["toleransi"] = DB.GetToleransi(ctrlSub.txtSub.EditValue.ToString());
        }

        private void FrmTRms_Load(object sender, EventArgs e)
        {
            ctrlSub.txtSub.DataBindings.Add("EditValue", MasterBindingSource, "sub");
            ctrlSub.txtSub.EditValueChanged += new EventHandler(txtSub_EditValueChanged);
            Utility.SetNumberFormat(pnlTotal, "n2");
            ReCalculateTotal();
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
            if (MasterBindingSource.Position == MasterTable.Rows.Count)
            {
                ppnCheckBox.Checked = true;
                rmaTextBoxEx.ExAutoCheck = true;
            }
            else
                rmaTextBoxEx.ExAutoCheck = false;
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

        private void rmaTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {
            if (rmaTextBoxEx.EditValue.ToString() == "")
                return;

            DataRow row = rmaTextBoxEx.ExGetDataRow();
            if (row == null)
                return;
         
            ctrlSub.txtSub.EditValue = row["Kode Supplier"];

            GridLookUpEx invLookUp = (GridLookUpEx)gcxRmd.ExGridView.Columns["inv"].ColumnEdit;
            //invLookUp.Query = "select * from rmb where rma='" + rmaTextBoxEx.EditValue.ToString() + "'";
            invLookUp.Query = "Call SP_SelectPorDetailforRms('" + rmaTextBoxEx.EditValue.ToString() + "')";
            invLookUp.TableName = "rmd";

            if (MasterBindingSource.Position == MasterTable.Rows.Count)
            {
                DetailTable.Clear();
                invLookUp.ClickButton();
            }
        }
        
        private void txtNo_EditValueChanged(object sender, EventArgs e)
        {
            if (MasterBindingSource.Position != MasterTable.Rows.Count)
            {
                DateTime date = (DateTime)MasterTable.Rows[MasterBindingSource.Position]["date"];
                DateTime dueDate;
                if (MasterTable.Rows[MasterBindingSource.Position]["duedate"] != DBNull.Value)
                    dueDate = (DateTime)MasterTable.Rows[MasterBindingSource.Position]["duedate"];
                else
                    dueDate = date;
                TOPSpinEdit.EditValue = ((TimeSpan)dueDate.Subtract(date)).TotalDays;
            }
            ReCalculateTotal();
        }

        private void ppnCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ReCalculateTotal();
        }

        private void discSpinEdit_EditValueChanged(object sender, EventArgs e)
        {
            ReCalculateTotal();
        }

        void tsbtnPrint_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepReturbeli" + ".repx";
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
        }
    }
}

