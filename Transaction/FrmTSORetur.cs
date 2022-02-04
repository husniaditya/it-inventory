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

namespace CAS.Transaction
{
    public partial class FrmTSORetur : CAS.Transaction.BaseTransaction
    {
        //bool isDetailChanged = false;
        private DataTable copyDetailTable = new DataTable();

        public FrmTSORetur()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlDetail, DB.sql);

            DetailTable.Columns.Add("Unit Base", typeof(String));
            MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);

            gcxRsmd.ExGridControl.DataSource = rsmdBindingSource;
            gcxRsmd.ExTitleLabel.Text = "Detail Retur Penjualan";
            gcxRsmd.ExGridView.OptionsView.ShowGroupPanel = false;
            gcxRsmd.ExGridView.OptionsCustomization.AllowSort = false;

            gcxRsmd.ExGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(ExGridView_InitNewRow);
            gcxRsmd.ExGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(ExGridView_CellValueChanged);

            gcxRsmd.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
            gcxRsmd.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
            gcxRsmd.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gcxRsmd.ExToolStrip.Items["tsbtnNew"].Enabled = false;

            gcxRsmd.ExGridView.Columns["rsm"].Visible = false;
            gcxRsmd.ExGridView.Columns["remark"].OptionsColumn.AllowEdit = false;
            gcxRsmd.ExGridView.Columns["loc"].OptionsColumn.AllowEdit = false;
            //gcxRsmd.ExGridView.Columns["inv"].OptionsColumn.AllowEdit = false;
            gcxRsmd.ExGridView.Columns["klr"].OptionsColumn.AllowEdit = false;
            gcxRsmd.ExGridView.Columns["okl"].OptionsColumn.AllowEdit = false;

            //gcxRsmd.ExGridView.Columns["klr"].ColumnEdit = new GridLookUpEx(DB.sql, "", "klr", "klr", gcxRsmd.ExGridView, "", true, true, "Penjualan");
            //gcxRsmd.ExGridView.Columns["klr"].ColumnEdit.Enter += new EventHandler(klrColumnEdit_Enter);
            gcxRsmd.ExGridView.Columns["nodsg"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('dsg')", "dsg", "nodsg", gcxRsmd.ExGridView, "", true, true, "Inventory");            
            gcxRsmd.ExGridView.Columns["inv"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('inv')", "inv", "inv", gcxRsmd.ExGridView, "", true, true, "Inventory");
            gcxRsmd.ExGridView.Columns["inv"].ColumnEdit.Enter += new EventHandler(InvColumnEdit_Enter);
            gcxRsmd.ExGridView.Columns["loc"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('loc')", "loc", "loc", gcxRsmd.ExGridView, "", false, false, "Location");
            gcxRsmd.ExGridView.Columns["unit"].ColumnEdit = new GridLookUpUnit(gcxRsmd.ExGridView);
            gcxRsmd.ExGridView.Columns["no"].Visible = false;
            gcxRsmd.ExGridView.Columns["qty1"].ColumnEdit = new GridNumEx();
            gcxRsmd.ExGridView.Columns["qty"].OptionsColumn.AllowEdit = false;
            gcxRsmd.ExGridView.Columns["disc"].ColumnEdit = new GridNumEx(false, true, 0, 100, 1, false);
            gcxRsmd.ExGridView.Columns["price"].ColumnEdit = new GridNumEx(false,true, 0, Int32.MaxValue, 500, false);
            gcxRsmd.ExGridView.Columns["val"].OptionsColumn.AllowEdit = false;

            gcxRsmd.ExGridView.Columns["klr"].Caption = "Penjualan";
            gcxRsmd.ExGridView.Columns["okl"].Caption = "SO";
            gcxRsmd.ExGridView.Columns["klr"].Visible = false;
            gcxRsmd.ExGridView.Columns["okl"].Visible = false;

            gcxRsmd.ExGridView.Columns["nodsg"].Caption = "No Design";
            gcxRsmd.ExGridView.Columns["inv"].Caption = "Kode Barang";
            gcxRsmd.ExGridView.Columns["remark"].Caption = "Nama Barang";
            gcxRsmd.ExGridView.Columns["loc"].Caption = "Loc";
            gcxRsmd.ExGridView.Columns["qty1"].Caption = "Qty";
            gcxRsmd.ExGridView.Columns["qty"].Caption = "Qty Base";
            gcxRsmd.ExGridView.Columns["unit"].Caption = "Unit";
            gcxRsmd.ExGridView.Columns["price"].Caption = "Price";
            gcxRsmd.ExGridView.Columns["toleransi"].Caption = "Tol(%)";
            gcxRsmd.ExGridView.Columns["disc"].Caption = "Disc(%)";
            gcxRsmd.ExGridView.Columns["val"].Caption = "Val";
            gcxRsmd.ExGridView.Columns["etd"].Caption = "Keterangan";

            gcxRsmd.ExGridView.BestFitColumns();
            gcxRsmd.ExGridView.OptionsBehavior.Editable = false;
            gcxRsmd.ExGridView.OptionsSelection.MultiSelect = true;
            gcxRsmd.ExGridView.OptionsCustomization.AllowSort = false;

            DB.SetNumberFormat(gcxRsmd.ExGridView, "n2");

            TOPSpinEdit.Properties.MinValue = 0;
            TOPSpinEdit.Properties.MaxValue = Int32.MaxValue;

            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);

            gcxRsmd.ExGridView.Columns["Unit Base"].VisibleIndex = DetailTable.Columns.IndexOf("qty");
            gcxRsmd.ExGridView.Columns["Unit Base"].OptionsColumn.AllowEdit = false;
            //tsbtnDelete.Click += new EventHandler(tsbtnDelete_Click);
        }

        void InvColumnEdit_Enter(object sender, EventArgs e)
        {
            if (gcxRsmd.ExGridView.GetFocusedRowCellValue("nodsg") == null)
            {
                ((ButtonEdit)sender).Enabled = true;
                return;
            }

            if (gcxRsmd.ExGridView.GetFocusedRowCellValue("nodsg").ToString() == "")
                ((ButtonEdit)sender).Enabled = true;
            else
                ((ButtonEdit)sender).Enabled = false;

           
        }

        void klrColumnEdit_Enter(object sender, EventArgs e)
        {
            (gcxRsmd.ExGridView.Columns["klr"].ColumnEdit as GridLookUpEx).Query = "Call SP_SelectKlrforRsm(" + Convert.ToDateTime(dateDate.EditValue).ToString("yyyyMMdd") + ",'" + ctrlSub.txtSub.EditValue.ToString() + "')";
        }

        void SetMode(Mode mode)
        {
            gcxRsmd.ExGridView.OptionsBehavior.Editable = (mode == Mode.Edit) ? true : false;
            gcxRsmd.ExGridView.OptionsView.NewItemRowPosition = (mode == Mode.Edit) ? NewItemRowPosition.Bottom : NewItemRowPosition.None;
            gcxRsmd.ExToolStrip.Items["tsbtnDelete"].Enabled = (mode == Mode.Edit) ? true : false;
            gcxRsmd.ExToolStrip.Items["tsbtnNew"].Enabled = (mode == Mode.Edit) ? true : false;
            ctrlSub.ReadOnly = (mode == Mode.Edit) ? false : true;
        }

        protected override void tsbtnCancel_Click(object sender, EventArgs e)
        {
            DB.CancelDetailRows(DetailTable);
            base.tsbtnCancel_Click(sender, e);
            if (this.mode == Mode.View)
            {
                //SetMode(Mode.View);
                ReCalculateTotal();
                //isDetailChanged = false;
                DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
            }
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidateChildren();

                if (ctrlSub.txtSub.EditValue.ToString() == "")
                    throw new Exception("Harap mengisi customer!");

                DetailBindingSource.EndEdit();

                double totVal = 0;
                for (int i = DetailTable.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = DetailTable.Rows[i];
                    if (row != null && row.RowState != DataRowState.Deleted)
                    {
                        row[0] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
                        //row["no"] = i + 1;
                        totVal = totVal + (double)row["val"];
                        // check price
                        if ((double)row["price"] == 0)
                            throw new Exception("Harap mengisi harga!");

                        //check price validity
                        //harga untuk material yg sama harus sama
                        string inv = row["inv"].ToString();
                        string remark = row["remark"].ToString().Replace("'","''");
                        DataRow[] drDetail = DetailTable.Select("inv='" + inv + "' and remark='" + remark + "'");
                        for (int j = 0; j < drDetail.Length; j++)
                        {
                            if (drDetail[j] != null && drDetail[j].RowState != DataRowState.Deleted)
                                if (Convert.ToDouble(row["price"]) != Convert.ToDouble(drDetail[j]["price"]))
                                    throw new Exception("Price untuk material: " + inv + "-" + remark + " tidak sama");
                        }
                    }
                }

                ((DataRowView)MasterBindingSource.Current).Row["val"] = totVal;
                ((DataRowView)MasterBindingSource.Current).Row["duedate"] = ((DateTime)dateDate.EditValue).AddDays(Convert.ToDouble(TOPSpinEdit.EditValue));

                base.tsbtnSave_Click(sender, e);

                if (this.mode == Mode.View)
                {
                    //jika mode=edit & SO retur sudah approve, qty1 & price diubah, set approv = 0
                    //if (isDetailChanged && MasterBindingSource.Position != MasterTable.Rows.Count)
                    //    ((DataRowView)MasterBindingSource.Current).Row["approve"] = Convert.ToInt64(false);
                    SetMode(Mode.View);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            SetMode(Mode.Edit);
            copyDetailTable.Clear();
            copyDetailTable = DetailTable.Copy();

            if ( ctrlSub.txtSub.EditValue.ToString()  == "1110002")
                gcxRsmd.ExGridView.Columns["inv"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('inv')", "inv", "inv", gcxRsmd.ExGridView, "", true, true, "Inventory");
            else
                gcxRsmd.ExGridView.Columns["inv"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('invpenj')", "inv", "inv", gcxRsmd.ExGridView, "", true, true, "Inventory");
         

        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            DetailTable.Clear();
            SetMode(Mode.Edit);
            ReCalculateTotal();
            ppnCheckBox.Checked = true;
        }       

        void ExGridView_New_Click(object sender, EventArgs e)
        {
            DataRow row = casDataSet.rsmd.NewRow();
            row["rsm"] = NoDocument;
            row["qty"] = 0;
            row["qty1"] = 0;
            row["inv"] = "";
            row["loc"] = "";
            row["unit"] = "";
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            casDataSet.rsmd.Rows.Add(row);

            DB.InsertDetailRows(gcxRsmd.ExGridView, row);
        }

        void ExGridView_Delete_Click(object sender, EventArgs e)
        {
            bool canDeleteitem, canDelete = true;
            int[] selectedIndex = gcxRsmd.ExGridView.GetSelectedRows();
            for (int i = 0; i < selectedIndex.Length; i++)
            {
                string rsm = gcxRsmd.ExGridView.GetDataRow(selectedIndex[i])["rsm"].ToString();
                int no = Convert.ToInt32(gcxRsmd.ExGridView.GetDataRow(selectedIndex[i])["no"]);
                canDeleteitem = DeleteLineItem(rsm, no);
                if (canDeleteitem == false) canDelete = false;
            }
            if (canDelete) DB.DeleteDetailRows(gcxRsmd.ExGridView);
        }

        private bool isEditAllowed(int no)
        {
            string query = "Select FCanDeleteLineItem('" + DetailTable.TableName.ToString() + "','" + NoDocument + "'," + no.ToString() + ")";
            if (DB.sql.Select(query).Rows[0][0].ToString() == "False")
                return false;
            else
                return true;
        }

        void ExGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            double price = 0;
            if (e.Column.FieldName == "inv")
            {
                DetailBindingSource.EndEdit();
                DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
                string query = "Select F_GetPrice('" + gcxRsmd.ExGridView.GetFocusedRowCellValue("inv").ToString() + "'," + Convert.ToDateTime(dateDate.EditValue).ToString("yyyyMMdd") + ")";
                if (DB.sql.Select(query).Rows.Count > 0)
                    if (DB.sql.Select(query).Rows[0][0].ToString() != "")
                      gcxRsmd.ExGridView.SetFocusedRowCellValue(gcxRsmd.ExGridView.Columns["price"], (double)DB.sql.Select(query).Rows[0][0]);
    
            }
            else if (e.Column.FieldName == "unit" || e.Column.FieldName == "qty1")
            {

                DetailBindingSource.EndEdit();
                string inv = (string)gcxRsmd.ExGridView.GetFocusedRowCellValue("inv");
                string unit = (string)gcxRsmd.ExGridView.GetFocusedRowCellValue("unit");
                double qty1 = (double)gcxRsmd.ExGridView.GetFocusedRowCellValue("qty1");
                string query = "Select F_GetPrice('" + gcxRsmd.ExGridView.GetFocusedRowCellValue("inv").ToString() + "'," + Convert.ToDateTime(dateDate.EditValue).ToString("yyyyMMdd") + ")";
                if (DB.sql.Select(query).Rows.Count > 0 )
                    if (DB.sql.Select(query).Rows[0][0].ToString()!="")
                       price = (double)DB.sql.Select(query).Rows[0][0];

                if (inv != "" && unit != "")
                {
                    gcxRsmd.ExGridView.SetFocusedRowCellValue(gcxRsmd.ExGridView.Columns["qty"], DB.GetQtyInBaseUom(inv, unit, qty1));
                    
                    if (e.Column.FieldName == "qty1")
                    {
                        int no = Convert.ToInt32(gcxRsmd.ExGridView.GetFocusedRowCellValue("no"));
                        double oldQty1 = 0;
                        try
                        {
                            DataRow drCopyDetailTable;
                            drCopyDetailTable = copyDetailTable.Select("no=" + no.ToString())[0];
                            oldQty1 = Convert.ToDouble(drCopyDetailTable["qty1"]);
                        }
                        catch { }
                        if (MasterBindingSource.Position != MasterTable.Rows.Count &&
                            !isEditAllowed(no) && oldQty1 != 0 && oldQty1 != qty1)
                        {
                            MessageBox.Show("Edit item SO Retur tidak diperbolehkan karena sudah di-SPB");
                            gcxRsmd.ExGridView.SetFocusedRowCellValue(gcxRsmd.ExGridView.Columns["qty1"], oldQty1);
                            return;
                        }
                        price = (double)gcxRsmd.ExGridView.GetFocusedRowCellValue("price");
                        double disc = (double)gcxRsmd.ExGridView.GetFocusedRowCellValue("disc");
                        double val = price * qty1 * ((100 - disc) / 100);
                        gcxRsmd.ExGridView.SetFocusedRowCellValue(gcxRsmd.ExGridView.Columns["val"], val);
                        ReCalculateTotal();
                    }
                      if (e.Column.FieldName == "unit" && ctrlSub.txtSub.EditValue.ToString() == "1110002")
                    {
                            DataTable dt = DB.sql.Select("Select * from konversi where inv='" + inv + "' and unit='" + unit + "'");
                            if (dt.Rows[0]["konversi"] != DBNull.Value)
                              price = (double)dt.Rows[0]["konversi"] * price;
                              gcxRsmd.ExGridView.SetFocusedRowCellValue(gcxRsmd.ExGridView.Columns["price"], price);
                    }

                }
            }
            else if (e.Column.FieldName == "price" || e.Column.FieldName == "disc")
            {
                DetailBindingSource.EndEdit();

                //cek apakah sudah di-SPM atau tidak
                //jika sudah, harga tidak boleh diedit
                int no = Convert.ToInt32(gcxRsmd.ExGridView.GetFocusedRowCellValue("no"));

                double oldPrice = 0;
                try
                {
                    DataRow drCopyDetailTable;
                    drCopyDetailTable = copyDetailTable.Select("no=" + no.ToString())[0];
                    oldPrice = Convert.ToDouble(drCopyDetailTable["price"]);
                }
                catch { }
                if (oldPrice != 0 && oldPrice != Convert.ToDouble(e.Value) && !isEditAllowed(no))
                {
                    MessageBox.Show("Edit item SO Retur tidak diperbolehkan karena sudah di-SPB");
                    gcxRsmd.ExGridView.SetFocusedRowCellValue(gcxRsmd.ExGridView.Columns["price"], oldPrice);
                    return;
                }       
                 try
                {
                price = (double)gcxRsmd.ExGridView.GetFocusedRowCellValue("price");
                double qty1 = (double)gcxRsmd.ExGridView.GetFocusedRowCellValue("qty1");
                double disc = (double)gcxRsmd.ExGridView.GetFocusedRowCellValue("disc");
                double val = price * qty1 * ((100 - disc) / 100);
                gcxRsmd.ExGridView.SetFocusedRowCellValue(gcxRsmd.ExGridView.Columns["val"], val);
                ReCalculateTotal();
                }
                 catch { }
            }
            //else if (e.Column.FieldName == "qty")
            //{
            //    string inv = (string)gcxRsmd.ExGridView.GetFocusedRowCellValue("inv");
            //    string unit = (string)gcxRsmd.ExGridView.GetFocusedRowCellValue("unit");
            //    double qty = (double)e.Value;//(double)gcOmd.ExGridView.GetFocusedRowCellValue("qty");
            //    double qty1 = (double)gcxRsmd.ExGridView.GetFocusedRowCellValue("qty1");
            //    if (DB.GetQtyInAlternativeUom(inv, unit, qty) != qty1)
            //        gcxRsmd.ExGridView.SetFocusedRowCellValue(gcxRsmd.ExGridView.Columns["qty1"], DB.GetQtyInAlternativeUom(inv, unit, qty));
            //}
        }

        void ExGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gcxRsmd.ExGridView.GetDataRow(e.RowHandle);
            row["rsm"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            row["toleransi"] = DB.GetToleransi(ctrlSub.txtSub.EditValue.ToString());
        }

        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
            ReCalculateTotal();
        }

        void ReCalculateTotal()
        {
            double subTotal = 0;
            for (int i = 0; i < DetailTable.Rows.Count; i++)
            {
                if (DetailTable.Rows[i] != null && DetailTable.Rows[i].RowState != DataRowState.Deleted)
                    subTotal = subTotal + (double)DetailTable.Rows[i]["val"];
            }
            txtSubtotal.EditValue = subTotal;

            double disc = 0;
            //double disc = subTotal * (Convert.ToDouble(discSpinEdit.EditValue)) / 100;
            //txtDisc.EditValue = disc;

            double ppn = 0;
            if (ppnCheckBox.Checked)
                ppn = (subTotal - disc) * 0.1;
            txtPPN.EditValue = ppn;

            double total = subTotal - disc + ppn;
            txtTotal.EditValue = total;
            gcxRsmd.ExGridView.BestFitColumns();
        }

        private void FrmTSORetur_Load(object sender, EventArgs e)
        {
            ctrlSub.txtSub.DataBindings.Add("EditValue", MasterBindingSource, "sub");
            ctrlSub.txtSub.EditValueChanged += new EventHandler(txtSub_EditValueChanged);
            Utility.SetNumberFormat(pnlTotal, "n2");
            ReCalculateTotal();
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
            if (MasterBindingSource.Position == MasterTable.Rows.Count)
            {
                ppnCheckBox.Checked = true;
                copyDetailTable.Clear();
                copyDetailTable = DetailTable.Copy();
                SetMode(Mode.Edit);
            }
        }

        void txtSub_EditValueChanged(object sender, EventArgs e)
        {
            DataRow row = ctrlSub.txtSub.ExGetDataRow();
            if (row == null)
                return;
            curcur.EditValue = row["cur"].ToString();
            TOPSpinEdit.EditValue = row["top"].ToString();

            if (ctrlSub.txtSub.EditValue.ToString() == "1110002")
                gcxRsmd.ExGridView.Columns["inv"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('inv')", "inv", "inv", gcxRsmd.ExGridView, "", true, true, "Inventory");
            else
                gcxRsmd.ExGridView.Columns["inv"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('invpenj')", "inv", "inv", gcxRsmd.ExGridView, "", true, true, "Inventory");
         
        }

        private void txtNo_EditValueChanged(object sender, EventArgs e)
        {
            if (MasterBindingSource.Position != MasterTable.Rows.Count)
            {
                DateTime dueDate = ((DateTime)MasterTable.Rows[MasterBindingSource.Position]["duedate"]).Date;
                DateTime date = ((DateTime)MasterTable.Rows[MasterBindingSource.Position]["date"]).Date;
                TOPSpinEdit.EditValue = ((TimeSpan)dueDate.Subtract(date)).TotalDays;
            }
        }
    }
}

