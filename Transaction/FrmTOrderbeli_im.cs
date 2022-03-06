using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KASLibrary;
using DevExpress.XtraGrid.Views;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraReports.UI;
using System.Globalization;
using System.Threading;

namespace CAS.Transaction
{
    public partial class FrmTOrderbeli_im : CAS.Transaction.BaseTransaction
    {
        public FrmTOrderbeli_im()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("id-ID");

            Utility.SetSqlInstance(pnlDetail, DB.sql);
            ctrlSub.txtSub.ExSqlQuery = "Call SP_LookUp('supplier')";

            DetailTable.Columns.Add("Unit Base", typeof(String));
            MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);

            gcxOmd.ExGridControl.DataSource = omdBindingSource;
            gcxOmd.ExTitleLabel.Text = "Purchase Order Detail";

            gcxOmd.ExGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(ExGridView_InitNewRow);
            gcxOmd.ExGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(ExGridView_CellValueChanged);

            gcxOmd.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
            gcxOmd.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gcxOmd.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
            gcxOmd.ExToolStrip.Items["tsbtnNew"].Enabled = false;

            gcxOmd.ExGridView.Columns["oms"].OptionsColumn.AllowEdit = false;
            gcxOmd.ExGridView.Columns["val"].OptionsColumn.AllowEdit = false;
            gcxOmd.ExGridView.Columns["spesifikasi"].OptionsColumn.AllowEdit = false;
            gcxOmd.ExGridView.Columns["valpph22"].OptionsColumn.AllowEdit = false;
            gcxOmd.ExGridView.Columns["valpph23"].OptionsColumn.AllowEdit = false;
            gcxOmd.ExGridView.Columns["valpph42"].OptionsColumn.AllowEdit = false;
            //gcxOmd.ExGridView.Columns["qty"].OptionsColumn.AllowEdit = false;
            gcxOmd.ExGridView.Columns["inv"].OptionsColumn.AllowEdit = true;
            //gcxOmd.ExGridView.Columns["remark"].OptionsColumn.AllowEdit = false;

            gcxOmd.ExGridView.Columns["no"].Visible = false;
            gcxOmd.ExGridView.Columns["noprd"].Visible = false;
            gcxOmd.ExGridView.Columns["oms"].Visible = false;
            gcxOmd.ExGridView.Columns["arrive"].Visible = false;
            gcxOmd.ExGridView.Columns["rsn"].Visible = false;

            gcxOmd.ExGridView.Columns["prq"].ColumnEdit = new GridLookUpEx(DB.sql, "", "prq", "prq", gcxOmd.ExGridView, "", true, true, "Purchase Request");
            gcxOmd.ExGridView.Columns["prq"].ColumnEdit.Enter += new EventHandler(ExGridView_prqColumnEdit_Enter);

            gcxOmd.ExGridView.Columns["inv"].ColumnEdit = new GridLookUpEx(DB.sql, "", "inv", "inv", gcxOmd.ExGridView, "", true, true, "Persediaan");
            gcxOmd.ExGridView.Columns["inv"].ColumnEdit.Enter += new EventHandler(InvColumnEdit_Enter);

            gcxOmd.ExGridView.Columns["remark"].ColumnEdit = new RepositoryItemTextEdit();
            gcxOmd.ExGridView.Columns["remark"].ColumnEdit.Enter += new EventHandler(remarkColumnEdit_Enter);

            gcxOmd.ExGridView.Columns["loc"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('loc')", "loc", "loc", gcxOmd.ExGridView, "", false, false, "Location");
            
            gcxOmd.ExGridView.Columns["cct"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('cct')", "cct", "cct", gcxOmd.ExGridView, "", false, false, "Cost Center");
            gcxOmd.ExGridView.Columns["cct"].ColumnEdit.Enter += new EventHandler(CctColumnEdit_Enter);
            
            gcxOmd.ExGridView.Columns["acc"].ColumnEdit = new GridLookUpEx(DB.sql, "", "acc", "acc", gcxOmd.ExGridView, "", false, false, "Account");
            gcxOmd.ExGridView.Columns["acc"].ColumnEdit.Enter += new EventHandler(AccColumnEdit_Enter);
            
            gcxOmd.ExGridView.Columns["unit"].ColumnEdit = new GridLookUpUnit(gcxOmd.ExGridView);
            gcxOmd.ExGridView.Columns["unit"].ColumnEdit.Enter += new EventHandler(UnitColumnEdit_Enter);

            gcxOmd.ExGridView.Columns["qty1"].ColumnEdit = new GridNumEx();
            gcxOmd.ExGridView.Columns["qty1"].ColumnEdit.Enter += new EventHandler(Qty1ColumnEdit_Enter);

            gcxOmd.ExGridView.Columns["qty"].ColumnEdit = new GridNumEx();
            gcxOmd.ExGridView.Columns["price"].ColumnEdit = new GridNumEx(500);
            gcxOmd.ExGridView.Columns["disc"].ColumnEdit = new GridNumEx();
            gcxOmd.ExGridView.Columns["toleransi"].ColumnEdit = new GridNumEx();
            gcxOmd.ExGridView.Columns["valpph22"].ColumnEdit = new GridNumEx(500);
            gcxOmd.ExGridView.Columns["valpph23"].ColumnEdit = new GridNumEx(500);
            gcxOmd.ExGridView.Columns["valpph42"].ColumnEdit = new GridNumEx(500);

            gcxOmd.ExGridView.OptionsBehavior.Editable = false;
            gcxOmd.ExGridView.OptionsSelection.MultiSelect = true;
            gcxOmd.ExGridView.OptionsCustomization.AllowSort = false;
            gcxOmd.ExGridView.OptionsView.ShowGroupPanel = false;

            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
            tsbtnDelete.Click += new EventHandler(tsbtnDelete_Click);

            gcxOmd.ExGridView.Columns["prq"].Caption = "Purchase Request";
            gcxOmd.ExGridView.Columns["inv"].Caption = "Kode Barang";
            gcxOmd.ExGridView.Columns["noprd"].Caption = "No Item PR";
            gcxOmd.ExGridView.Columns["remark"].Caption = "Nama Barang";
            gcxOmd.ExGridView.Columns["spesifikasi"].Caption = "Spesifikasi";
            gcxOmd.ExGridView.Columns["loc"].Caption = "Loc";
            //gcxOmd.ExGridView.Columns["batch"].Caption = "Batch";
            gcxOmd.ExGridView.Columns["qty"].Caption = "Qty Base";
            gcxOmd.ExGridView.Columns["unit"].Caption = "Unit";
            gcxOmd.ExGridView.Columns["qty1"].Caption = "Qty";
            gcxOmd.ExGridView.Columns["cct"].Caption = "Cost Center";
            //gcxOmd.ExGridView.Columns["acc"].Caption = "Kode Transaksi";
            gcxOmd.ExGridView.Columns["price"].Caption = "Price";
            gcxOmd.ExGridView.Columns["per"].Caption = "Per";
            //gcxOmd.ExGridView.Columns["expired"].Caption = "Exp.Date";
            gcxOmd.ExGridView.Columns["disc"].Caption = "Disc(%)";
            gcxOmd.ExGridView.Columns["val"].Caption = "Val";
            gcxOmd.ExGridView.Columns["etd"].Caption = "Keterangan";
            gcxOmd.ExGridView.Columns["toleransi"].Caption = "Tol(%)";
            gcxOmd.ExGridView.Columns["pph22"].Caption = "PPH 22(%)";
            gcxOmd.ExGridView.Columns["valpph22"].Caption = "Nilai PPH 22";
            gcxOmd.ExGridView.Columns["pph23"].Caption = "PPH 23 (%)";
            gcxOmd.ExGridView.Columns["valpph23"].Caption = "Nilai PPH 23";
            gcxOmd.ExGridView.Columns["pph42"].Caption = "PPH 4(2) (%)";
            gcxOmd.ExGridView.Columns["valpph42"].Caption = "Nilai PPH 4(2)";

            gcxOmd.ExGridView.Columns["batch"].Visible = false;
            gcxOmd.ExGridView.Columns["acc"].Visible = false;
            gcxOmd.ExGridView.Columns["expired"].Visible = false;

            gcxOmd.ExGridView.Columns["spesifikasi"].VisibleIndex = 4;
            gcxOmd.ExGridView.Columns["pph22"].VisibleIndex = 17;
            gcxOmd.ExGridView.Columns["pph23"].VisibleIndex = 18;
            gcxOmd.ExGridView.Columns["pph42"].VisibleIndex = 19;
            gcxOmd.ExGridView.Columns["valpph22"].VisibleIndex = 20;
            gcxOmd.ExGridView.Columns["valpph23"].VisibleIndex = 21;
            gcxOmd.ExGridView.Columns["valpph42"].VisibleIndex = 22;
            gcxOmd.ExGridView.Columns["val"].VisibleIndex = 23;
            gcxOmd.ExGridView.Columns["per"].VisibleIndex = DetailTable.Columns.IndexOf("price") - 1;
            gcxOmd.ExGridView.Columns["Unit Base"].VisibleIndex = DetailTable.Columns.IndexOf("qty")-2;
            gcxOmd.ExGridView.Columns["Unit Base"].OptionsColumn.AllowEdit = false;
            //gcxOmd.ExGridView.Columns["expired"].VisibleIndex = DetailTable.Columns.IndexOf("batch");
         
            DB.SetNumberFormat(gcxOmd.ExGridView, "n2");

            topSpinEdit.Properties.MinValue = 0;
            topSpinEdit.Properties.MaxValue = Int32.MaxValue;

            tsbtnPrint.Click += new EventHandler(tsbtnPrint_Click);
        }

        void tsbtnPrint_Click(object sender, EventArgs e)
        {
            if (Convert.ToUInt64(((DataRowView)MasterBindingSource.Current).Row["aprov"]) == 1)
            {
                

                this.ReportName = "RepPO_im";
                this.PrintQuery = "Call SP_Print('" + this.Name + "','" + this.NoDocument + "')";

                PrintReport();
            }
            else
                MessageBox.Show("PO belum di-approve");
        }

        protected override void tsbtnDelete_Click(object sender, EventArgs e)
        {
            base.tsbtnDelete_Click(sender, e);
            if (Convert.ToInt32(MasterTable.Rows[MasterBindingSource.Position]["delete"]) == 1)
                DB.sql.Execute("Call SP_Delete('OMS'" + ",'" + NoDocument + "')");
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            remarkMemoEdit.Focus();
            try
            {
                this.ValidateChildren();
                if (gcxOmd.ExGridView.EditingValue != null)
                    gcxOmd.ExGridView.SetFocusedValue(gcxOmd.ExGridView.EditingValue);

                if (ctrlSub.txtSub.EditValue.ToString() == "")
                {
                    MessageBox.Show("Please entry supplier!");
                    return;
                }
                if (curcur.EditValue.ToString() == "")
                    throw new Exception("Please entry Currency!");
                if (curkurs.EditValue.ToString() == "0" || curkurs.EditValue.ToString() == "")
                    throw new Exception("Please entry Kurs!");

                DetailBindingSource.EndEdit();

                //CEK NILAI BUDGET
                string cct = gcxOmd.ExGridView.GetFocusedRowCellValue("cct").ToString();
                double total = 0;
                double budget = 0;
                double valtot = Convert.ToDouble(txtTotal.Text);
                DataTable dtTpb = DB.sql.Select("SELECT (cct.budget - SUM(omd.val)) AS total, cct.budget FROM omd,oms,cct WHERE oms.oms=omd.oms AND omd.cct = cct.cct and left(omd.inv,2) != 11 and left(omd.inv,2) != 41 and left(omd.inv,2) != 51 and (oms.cmv = 0 or oms.cmv is null) and oms.delete = 0 and oms.aprov = 1 AND oms.period = '" + txtPeriod.Text + "' AND omd.cct = '" + cct + "' GROUP BY cct.cct");
                foreach (DataRow drTpb in dtTpb.Rows)
                {
                    total = Convert.ToDouble(drTpb["total"]);
                    budget = Convert.ToDouble(drTpb["budget"]);
                }

                if ((total - valtot) <= 0 && budget > 0)
                    throw new Exception("Transaksi tidak dapat diproses dikarenakan telah melebihi budget. Sisa budget saat ini : '" + total + "'");
                //END CEK NILAI BUDGET

                double totVal = 0;
                for (int i = DetailTable.Rows.Count - 1; i >= 0; i--)
                {
                    double price = (double)gcxOmd.ExGridView.GetFocusedRowCellValue("price");
                    double qty1 = (double)gcxOmd.ExGridView.GetFocusedRowCellValue("qty");
                    double disc = (double)gcxOmd.ExGridView.GetFocusedRowCellValue("disc");
                    double per = (double)gcxOmd.ExGridView.GetFocusedRowCellValue("per");
                    if (per == 0)
                        per = 1;

                    double val = (price/per) * qty1 * ((100 - disc) / 100);
                    gcxOmd.ExGridView.SetFocusedRowCellValue(gcxOmd.ExGridView.Columns["val"], val);

                    DataRow row = DetailTable.Rows[i];
                    if (row != null && row.RowState != DataRowState.Deleted)
                    {
                        row[0] = NoDocument;

                        totVal = totVal + (double)row["val"];
                        if (Convert.ToDouble(row["price"]) == 0)
                        {
                            MessageBox.Show("Please enter price and quantity");
                            return;
                        }
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
                                {
                                    MessageBox.Show("Price untuk material: " + inv + "-" + remark + " tidak sama");
                                    return;
                                }
                            }
                        }
                    }
                }

                ((DataRowView)MasterBindingSource.Current).Row["val"] = totVal;
                ((DataRowView)MasterBindingSource.Current).Row["duedate"] = ((DateTime)dateDate.EditValue).AddDays(Convert.ToDouble(topSpinEdit.EditValue));
                ((DataRowView)MasterBindingSource.Current).Row["group_"] = 1;
                ((DataRowView)MasterBindingSource.Current).Row["jenispo"] = 2;
              //  ((DataRowView)MasterBindingSource.Current).Row["group_"] =  Convert.ToInt32(jenisradioGroup.EditValue);
                this.ValidateChildren();
                MasterBindingSource.EndEdit();  
                base.tsbtnSave_Click(sender, e);

                if (this.mode == Mode.View)
                {
                    DB.sql.Execute("Call SP_Save(00000000, 'OMS','" + ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text + "')");
                    ClosePR();
                    SetMode(Mode.View);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        protected override void tsbtnCancel_Click(object sender, EventArgs e)
        {
            DB.CancelDetailRows(DetailTable);
            remarkMemoEdit.Focus();
            base.tsbtnCancel_Click(sender, e);
            if (this.mode == Mode.View)
            {
                ReCalculateTotal();
                SetMode(Mode.View);
                DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
            }
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {         
            SetMode(Mode.Edit);

            Utility.SetReadOnly(txtSubtotal, true);
            Utility.SetReadOnly(txtPPN, true);
            Utility.SetReadOnly(txtTotal, true);
        }

        void SetMode(Mode mode)
        {
            gcxOmd.ExGridView.OptionsBehavior.Editable = (mode == Mode.Edit) ? true : false;
            gcxOmd.ExGridView.OptionsView.NewItemRowPosition = (mode == Mode.Edit) ? NewItemRowPosition.Bottom : NewItemRowPosition.None;
            gcxOmd.ExToolStrip.Items["tsbtnDelete"].Enabled = (mode == Mode.Edit) ? true : false;
            gcxOmd.ExToolStrip.Items["tsbtnNew"].Enabled = (mode == Mode.Edit) ? true : false;
            ctrlSub.ReadOnly = (mode == Mode.Edit) ? false : true;
            comboBox1.Enabled = true;
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            delivery_fromDateEdit.DateTime = DateTime.Now.Date;
            delivery_toDateEdit.DateTime = DateTime.Now.Date;

            DetailTable.Clear();
            SetMode(Mode.Edit);
            ReCalculateTotal();
            ppnCheckBox.Checked = true;
            curcur.EditValue = "";
            shippingdocMemoEdit.EditValue= "- Signed Commecial Invoice in six folds\r\n" +
                                       "- Signed Packing/Weight List in six folds\r\n" +
                                       "- Signed Bill of Lading in three folds\r\n" +
                                       "- Not Negotiable Bill of Lading in two folds\r\n" +
                                       "- Signed Analysis Certificate in two folds";
            //shippingdocMemoEdit.Text = "aaa";
         //   jenisradioGroup.SelectedIndex = 1;
            Utility.SetReadOnly(txtSubtotal, true);
            Utility.SetReadOnly(txtPPN, true);
            Utility.SetReadOnly(txtTotal, true);
        }

        void Qty1ColumnEdit_Enter(object sender, EventArgs e)
        {
            
        }

        void UnitColumnEdit_Enter(object sender, EventArgs e)
        {
            
        }

        void AccColumnEdit_Enter(object sender, EventArgs e)
        {
            if (gcxOmd.ExGridView.GetFocusedRowCellValue("cct") != null)
            {
                string cct = gcxOmd.ExGridView.GetFocusedRowCellValue("cct").ToString();
                string kodeBarang = gcxOmd.ExGridView.GetFocusedRowCellValue("inv").ToString();
                if (DB.isBiaya(kodeBarang))
                {
                    ((GridLookUpEx)gcxOmd.ExGridView.Columns["acc"].ColumnEdit).Query = "Call SP_LookUpCca('" + (string)gcxOmd.ExGridView.GetFocusedRowCellValue("cct") + "')";
                    ((ButtonEdit)sender).Enabled = true;
                }
                else
                {
                    ((GridLookUpEx)gcxOmd.ExGridView.Columns["acc"].ColumnEdit).Query = "";
                    ((ButtonEdit)sender).Enabled = false;
                }
            }
            else
            {
                ((GridLookUpEx)gcxOmd.ExGridView.Columns["acc"].ColumnEdit).Query = "";
                ((ButtonEdit)sender).Enabled = false;
            }
        }

        void CctColumnEdit_Enter(object sender, EventArgs e)
        {
            if (gcxOmd.ExGridView.GetFocusedRowCellValue("inv") != null)
            {
                string kodeBarang = gcxOmd.ExGridView.GetFocusedRowCellValue("inv").ToString();
                if (DB.isBiaya(kodeBarang))
                    ((ButtonEdit)sender).Enabled = true;
                else
                    ((ButtonEdit)sender).Enabled = false;
            }
            else
                ((ButtonEdit)sender).Enabled = false;
        }

        void InvColumnEdit_Enter(object sender, EventArgs e)
        {
            (gcxOmd.ExGridView.Columns["inv"].ColumnEdit as GridLookUpEx).Query = "Call SP_LookUp('inv')";
        }

        void ExGridView_New_Click(object sender, EventArgs e)
        {
            DataRow row = casDataSet.omd.NewRow();
            row["oms"] = NoDocument;
            row["qty"] = 0;
            row["qty1"] = 0;
            row["inv"] = "";
            row["per"] = 1;
            row["loc"] = "";
            row["unit"] = "";
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            row["pph22"] = 0;
            row["pph23"] = 0;
            row["pph42"] = 0;
            row["valpph22"] = 0;
            row["valpph23"] = 0;
            row["valpph42"] = 0;
            casDataSet.omd.Rows.Add(row);
            DB.InsertDetailRows(gcxOmd.ExGridView, row);
        }

        void ExGridView_Delete_Click(object sender, EventArgs e)
        {
            bool canDeleteitem, canDelete = true;
            int[] selectedIndex = gcxOmd.ExGridView.GetSelectedRows();
            for (int i = 0; i < selectedIndex.Length; i++)
            {
                string oms = gcxOmd.ExGridView.GetDataRow(selectedIndex[i])["oms"].ToString();
                int no = Convert.ToInt32(gcxOmd.ExGridView.GetDataRow(selectedIndex[i])["no"]);
                canDeleteitem = DeleteLineItem(oms, no);
                if (canDeleteitem == false) canDelete = false;
            }
            if (canDelete) DB.DeleteDetailRows(gcxOmd.ExGridView);
        }

        void ExGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "unit" || e.Column.FieldName == "qty1" || e.Column.FieldName == "per")
            {
                DetailBindingSource.EndEdit();
                string inv = (string)gcxOmd.ExGridView.GetFocusedRowCellValue("inv");
                string unit = (string)gcxOmd.ExGridView.GetFocusedRowCellValue("unit");
                double qty1 = (double)gcxOmd.ExGridView.GetFocusedRowCellValue("qty1");
                double price = (double)gcxOmd.ExGridView.GetFocusedRowCellValue("price");
                double disc = (double)gcxOmd.ExGridView.GetFocusedRowCellValue("disc");
                double per = (double)gcxOmd.ExGridView.GetFocusedRowCellValue("per");
                if (per == 0)
                    per = 1;
                double val = (price / per) * qty1 * ((100 - disc) / 100);
                gcxOmd.ExGridView.SetFocusedRowCellValue(gcxOmd.ExGridView.Columns["val"], val);
               
                if (inv != "" && unit != "")
                    gcxOmd.ExGridView.SetFocusedRowCellValue(gcxOmd.ExGridView.Columns["qty"], DB.GetQtyInBaseUom(inv, unit, qty1));
            }
            else if (e.Column.FieldName == "price" || e.Column.FieldName == "disc")
            {
                double price = (double)gcxOmd.ExGridView.GetFocusedRowCellValue("price");
                double qty1 = (double)gcxOmd.ExGridView.GetFocusedRowCellValue("qty");
                double disc = (double)gcxOmd.ExGridView.GetFocusedRowCellValue("disc");
                double per = (double)gcxOmd.ExGridView.GetFocusedRowCellValue("per");
                double pph22 = (double)gcxOmd.ExGridView.GetFocusedRowCellValue("pph22");
                double pph23 = (double)gcxOmd.ExGridView.GetFocusedRowCellValue("pph23");
                double pph42 = (double)gcxOmd.ExGridView.GetFocusedRowCellValue("pph42");
                if (per == 0)
                    per = 1;
                double valprice = (price / per) * qty1 * ((100 - disc) / 100);
                double hitpph22 = (pph22 / 100) * valprice;
                double hitpph23 = (pph23 / 100) * valprice;
                double hitpph42 = (pph42 / 100) * valprice;
                double val = valprice;
                gcxOmd.ExGridView.SetFocusedRowCellValue(gcxOmd.ExGridView.Columns["valpph22"], hitpph22);
                gcxOmd.ExGridView.SetFocusedRowCellValue(gcxOmd.ExGridView.Columns["valpph23"], hitpph23);
                gcxOmd.ExGridView.SetFocusedRowCellValue(gcxOmd.ExGridView.Columns["valpph42"], hitpph42);
                gcxOmd.ExGridView.SetFocusedRowCellValue(gcxOmd.ExGridView.Columns["val"], val);
                ReCalculateTotal();
            }
        }

        void ExGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gcxOmd.ExGridView.GetDataRow(e.RowHandle);
            row["oms"] = NoDocument;
            row["per"] = 1;
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            row["pph22"] = 0;
            row["pph23"] = 0;
            row["pph42"] = 0;
            row["valpph22"] = 0;
            row["valpph23"] = 0;
            row["valpph42"] = 0;
        }

        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
            //if (MasterTable.Rows.Count > 0)
            //{
            //    int jenisPO = Convert.ToInt32(MasterTable.Rows[MasterBindingSource.Position]["group_"])-1;
            //    jenisradioGroup.SelectedIndex = jenisPO;
            //    jenisradioGroup.Refresh();
            //}
            comboBox1.Enabled = true;
        }

        void ReCalculateTotal()
        {
            DetailBindingSource.EndEdit();

            double subTotal = 0;
            double pph = 0;
            for (int i = 0; i < DetailTable.Rows.Count; i++)
            {
                if (DetailTable.Rows[i] != null && DetailTable.Rows[i].RowState != DataRowState.Deleted)
                {
                    subTotal = subTotal + (double)DetailTable.Rows[i]["val"];
                    pph = pph + (double)DetailTable.Rows[i]["valpph22"] + (double)DetailTable.Rows[i]["valpph23"] + (double)DetailTable.Rows[i]["valpph42"];
                }
            }
            txtSubtotal.EditValue = subTotal;
            txtPPH.EditValue = pph;

            double disc = subTotal * (Convert.ToDouble(discSpinEdit.EditValue)) / 100;
            txtDisc.EditValue = disc;

            double ppn = 0;
            if (ppnCheckBox.Checked)
                ppn = (subTotal - disc) * 0.1;
            txtPPN.EditValue = ppn;

            double total = subTotal - disc + ppn + pph;
            txtTotal.EditValue = total;
        }

        private void FrmTOrderbeli_im_Load(object sender, EventArgs e)
        {
            ctrlSub.txtSub.DataBindings.Add("EditValue", omsBindingSource, "sub");
            ctrlSub.txtSub.EditValueChanged += new EventHandler(txtSub_EditValueChanged);
            
            //curcur.Properties.ReadOnly = true;

            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
            gcxOmd.ExGridView.BestFitColumns();

            Utility.SetNumberFormat(pnlTotal, "n2");
            ReCalculateTotal();

            //set default PPN ke-centang u/ record baru
            if (MasterBindingSource.Position == MasterTable.Rows.Count)
            {
                ppnCheckBox.Checked = true;
                byRadioGroup.SelectedIndex = 1;
         //       jenisradioGroup.SelectedIndex = 1;
                SetMode(Mode.Edit);
            }
        }
       
        void txtSub_EditValueChanged(object sender, EventArgs e)
        {
            DataRow row = ctrlSub.txtSub.ExGetDataRow();
            //if (row == null)
            //{
            //    curcur.EditValue = "";
            //    return;
            //}
            //curcur.EditValue = row["Cur"].ToString();
            //topSpinEdit.EditValue = row["Top"].ToString();
        }

        void ExGridView_prqColumnEdit_Enter(object sender, EventArgs e)
        {
            string query = "Call SP_SelectPRforPO(" + ((DateTime)dateDate.EditValue).ToString("yyyyMMdd") + ")";
            ((GridLookUpEx)gcxOmd.ExGridView.Columns["prq"].ColumnEdit).Query = query;
        }

        void ClosePR()
        {
            //cek close PR
            for (int i = 0; i < DetailTable.Rows.Count; i++)
            {
                if (DetailTable.Rows[i]["prq"].ToString() != "")
                {
                    DataTable dt = DB.sql.Select("Call SP_SelectToClosePRonPO('" +
                         DetailTable.Rows[i]["prq"].ToString() + "')");
                    if (dt.Rows.Count == 0)
                        DB.sql.Execute("update prq set close=1 where prq='" + DetailTable.Rows[i]["prq"].ToString() + "'");
                }
            }
        }

        void remarkColumnEdit_Enter(object sender, EventArgs e)
        {
            if (gcxOmd.ExGridView.GetFocusedRowCellValue("inv") != null)
            {
                string kodeBarang = gcxOmd.ExGridView.GetFocusedRowCellValue("inv").ToString();
                if (DB.isBiaya(kodeBarang))
                    ((TextEdit)sender).Properties.ReadOnly = false;
                else
                    ((TextEdit)sender).Properties.ReadOnly = true;
            }
            else
                ((TextEdit)sender).Properties.ReadOnly = true;
        }

        private void txtNo_EditValueChanged(object sender, EventArgs e)
        {
            if (MasterBindingSource.Position != MasterTable.Rows.Count)
            {
                DateTime dueDate = ((DateTime)MasterTable.Rows[MasterBindingSource.Position]["duedate"]).Date;
                DateTime date = ((DateTime)MasterTable.Rows[MasterBindingSource.Position]["date"]).Date;
                topSpinEdit.EditValue = ((TimeSpan)dueDate.Subtract(date)).TotalDays;
                //if (MasterTable.Rows.Count > 0)
                //{
                //    int jenisPO = Convert.ToInt32(MasterTable.Rows[MasterBindingSource.Position]["group_"]);
                //    jenisradioGroup.SelectedIndex = jenisPO;
                //}
                ReCalculateTotal();
                DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
                //DetailTable = DB.PopulateDateNeed(DetailTable, "Tgl Dibutuhkan");
            }
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {
            string aaa = shippingdocMemoEdit.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          DB.sql.Execute("update oms set status='"+ comboBox1.Text +"' where oms='" + ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text + "'");
        }

        private void pnlDetail_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.mode == Mode.Edit)
                DB.sql.Execute("update omd set price=0,val=0 where omd.oms ='" + NoDocument + "'");

        }

        private void aprovCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!aprovCheckBox.Enabled) return;

            string namaaprov = "";
         
            if (mode != Mode.View)
            {
                 if (aprovCheckBox.Checked == true)
                {
                    namaaprov = DB.sql.Select("select aprovname from usr where user ='" + DB.casUser.User.ToString().Trim() + "'").Rows[0][0].ToString();
                    aprovby1TextEdit.EditValue = namaaprov;
                }
                else
                {
                    aprovCheckBox.Checked = false;
                    ((DataRowView)MasterBindingSource.Current).Row["aprovby"] = "";
                    aprovby1TextEdit.EditValue = "";

                }

              

            }
        } 
    }
}

