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
using System.Globalization;
using System.Threading;

namespace CAS.Transaction
{
    public partial class FrmTOrderjual : CAS.Transaction.BaseTransaction
    {
        private int[] selectedIndex = new int[0];
        private bool isDetailValid = true;
        private DataTable copyDetailTable = new DataTable();


        public FrmTOrderjual()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("id-ID");
            ToolStripMenuItem tsmiPreviewSO = new ToolStripMenuItem("Preview Order Penjualan", null, new EventHandler(tsmiPreviewInv_Click));
            ToolStripMenuItem tsmiPreviewMO = new ToolStripMenuItem("Preview Memo Order Penjualan", null, new EventHandler(tsmiPrintInv_Click));
          //  ToolStripDropDownButton tsbtnPrint = new ToolStripDropDownButton("Print", null, tsmiPreviewInv, tsmiPrintInv);
            DetailTable.Columns.Add("Unit Base", typeof(String));
            MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);

            gcOkl.ExGridControl.DataSource = okdBindingSource;
            gcOkl.ExTitleLabel.Text = "Sales Order Detail";

            gcOkl.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
            gcOkl.ExGridView.CellValueChanged += new CellValueChangedEventHandler(ExGridView_CellValueChanged);
            //gcOkl.ExGridView.ValidateRow += new ValidateRowEventHandler(ExGridView_ValidateRow);

            gcOkl.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
            gcOkl.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gcOkl.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
            gcOkl.ExToolStrip.Items["tsbtnNew"].Enabled = false;

            gcOkl.ExGridView.Columns["okl"].OptionsColumn.AllowEdit = false;
            gcOkl.ExGridView.Columns["val"].OptionsColumn.AllowEdit = false;
            gcOkl.ExGridView.Columns["spesifikasi"].OptionsColumn.AllowEdit = false;
            gcOkl.ExGridView.Columns["expired"].OptionsColumn.AllowEdit = false;
            gcOkl.ExGridView.Columns["qty"].OptionsColumn.AllowEdit = false;
            gcOkl.ExGridView.Columns["remark"].ColumnEdit = new RepositoryItemTextEdit();
            gcOkl.ExGridView.Columns["remark"].ColumnEdit.Enter += new EventHandler(remarkColumnEdit_Enter);
          
            gcOkl.ExGridView.Columns["no"].Visible = false;
            gcOkl.ExGridView.Columns["okl"].Visible = false;
            gcOkl.ExGridView.Columns["packaging"].Visible = false;

            gcOkl.ExGridView.Columns["inv"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('invpenj1')", "inv", "inv", gcOkl.ExGridView, "remark", true, true, "Persediaan");
            gcOkl.ExGridView.Columns["inv"].ColumnEdit.Enter += new EventHandler(InvColumnEdit_Enter);

            gcOkl.ExGridView.Columns["nodsg"].ColumnEdit = new GridLookUpEx(DB.sql, "Call Sp_GetStockBatch(" + DateTime.Now.ToString("yyyyMMdd") + ",'')", "", "No Batch", gcOkl.ExGridView, "", true, true, "Batch");
            gcOkl.ExGridView.Columns["nodsg"].ColumnEdit.Enter += new EventHandler(DsgColumnEdit_Enter);

            gcOkl.ExGridView.Columns["loc"].ColumnEdit = new GridLookUpEx(DB.sql, "", "loc", "loc", gcOkl.ExGridView, "", false, false, "Location");
            gcOkl.ExGridView.Columns["unit"].ColumnEdit = new GridLookUpUnit(gcOkl.ExGridView);

            gcOkl.ExGridView.Columns["qty1"].ColumnEdit = new GridNumEx();
            gcOkl.ExGridView.Columns["qty"].ColumnEdit = new GridNumEx();

            //gcOkl.ExGridView.Columns["price"].OptionsColumn.AllowEdit = false;
            //gcOkl.ExGridView.Columns["price"].ColumnEdit = new GridLookUpEx(DB.sql,"Call SP_LookUpPriceList('')", "dhrgdsg", "price", gcOkl.ExGridView, "", false, false, "Price List");
            gcOkl.ExGridView.Columns["price"].ColumnEdit = new GridLookUpEx(DB.sql, "select * from hjl order by tanggal desc", "hjl", "inv", gcOkl.ExGridView, "price", true, true, "Price");
            gcOkl.ExGridView.Columns["price"].ColumnEdit.Enter += new EventHandler(price_ColumnEdit_Enter); 
            
            gcOkl.ExGridView.Columns["disc"].ColumnEdit = new GridNumEx();
            gcOkl.ExGridView.Columns["toleransi"].ColumnEdit = new GridNumEx();

            gcOkl.ExGridView.OptionsBehavior.Editable = false;
            gcOkl.ExGridView.OptionsSelection.MultiSelect = true;
            gcOkl.ExGridView.OptionsCustomization.AllowSort = false;
            gcOkl.ExGridView.OptionsView.ShowGroupPanel = false;

            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            //tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);

            gcOkl.ExGridView.Columns["inv"].Caption = "Kode Barang";
            gcOkl.ExGridView.Columns["remark"].Caption = "Nama Barang";
            gcOkl.ExGridView.Columns["spesifikasi"].Caption = "Spesifikasi";
            gcOkl.ExGridView.Columns["nodsg"].Caption = "No Batch";
            gcOkl.ExGridView.Columns["expired"].Caption = "Expired";
            gcOkl.ExGridView.Columns["loc"].Caption = "Loc";
            gcOkl.ExGridView.Columns["qty"].Caption = "Qty Base";
            gcOkl.ExGridView.Columns["unit"].Caption = "Unit";
            gcOkl.ExGridView.Columns["qty1"].Caption = "Qty";
            gcOkl.ExGridView.Columns["price"].Caption = "Price";
            gcOkl.ExGridView.Columns["disc"].Caption = "Disc(%)";
            gcOkl.ExGridView.Columns["toleransi"].Caption = "Tol(%)";
            gcOkl.ExGridView.Columns["val"].Caption = "Val";
            gcOkl.ExGridView.Columns["dateneed"].Caption = "Tgl Dibutuhkan";


            //gcOkl.ExGridView.Columns["nodsg"].Visible = false;
            //gcOkl.ExGridView.Columns["expired"].Visible = false;

            gcOkl.ExGridView.Columns["inv"].VisibleIndex = 0;
            gcOkl.ExGridView.Columns["remark"].VisibleIndex = 1;
            gcOkl.ExGridView.Columns["nodsg"].VisibleIndex = 2;
            gcOkl.ExGridView.Columns["expired"].VisibleIndex = 3;
            gcOkl.ExGridView.Columns["spesifikasi"].VisibleIndex = 4;
            gcOkl.ExGridView.Columns["loc"].VisibleIndex = 5;
            gcOkl.ExGridView.Columns["qty1"].VisibleIndex = 6;
            gcOkl.ExGridView.Columns["unit"].VisibleIndex = 7;
            gcOkl.ExGridView.Columns["qty"].VisibleIndex = 8;
            gcOkl.ExGridView.Columns["Unit Base"].VisibleIndex = 9;
            gcOkl.ExGridView.Columns["price"].VisibleIndex = 10;
            gcOkl.ExGridView.Columns["disc"].VisibleIndex = 11;
            gcOkl.ExGridView.Columns["toleransi"].VisibleIndex =12;
            gcOkl.ExGridView.Columns["val"].VisibleIndex = 13;
            gcOkl.ExGridView.Columns["dateneed"].VisibleIndex = 14;

            gcOkl.ExGridView.Columns["Unit Base"].OptionsColumn.AllowEdit = false;
            
            DB.SetNumberFormat(gcOkl.ExGridView, "n2");
            gcOkl.ExGridView.Columns["qty"].DisplayFormat.FormatString = "n2";
            gcOkl.ExGridView.Columns["qty1"].DisplayFormat.FormatString = "n2";
         //   gcOkl.ExGridView.Columns["price"].DisplayFormat.FormatString = "n3";

            gcOkl.ExGridView.BestFitColumns();

            spinTOP.Properties.MinValue = 0;
            spinTOP.Properties.MaxValue = Int32.MaxValue;

            ToolStripDropDownButton tsbtnPrint = new ToolStripDropDownButton("Print", null, tsmiPreviewSO, tsmiPreviewMO);
            //ToolStripDropDownButton tsbtnPrint = new ToolStripDropDownButton("Print", null, tsmiPreviewBkk, tsmiPrintBkk, tsSeparator1, tsmiPreviewGiro, tsmiPrintGiro, tsSeparator2);
            tsbtnPrint.Image = MasterNavigator.Items["tsbtnPrint"].Image;
            MasterNavigator.Items.Insert(MasterNavigator.Items.IndexOfKey("tsbtnPrint"), tsbtnPrint);
            MasterNavigator.Items.RemoveByKey("tsbtnPrint");
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
            inv = gcOkl.ExGridView.GetFocusedRowCellValue("inv").ToString();
            if (gcOkl.ExGridView.GetFocusedRowCellValue("inv") != null)
                (gcOkl.ExGridView.Columns["nodsg"].ColumnEdit as GridLookUpEx).Query = "Call Sp_GetStockBatch(" + DateTime.Now.ToString("yyyyMMdd") + ",'" + inv + "')";
        }

        void price_ColumnEdit_Enter(object sender, EventArgs e)
        {
            if (gcOkl.ExGridView.GetFocusedRowCellValue("inv") != null && gcOkl.ExGridView.GetFocusedRowCellValue("inv").ToString() != "")
            {
                string kodeBarang = gcOkl.ExGridView.GetFocusedRowCellValue("inv").ToString();
                string query = "Select * from hjl where inv = '" + kodeBarang + "' order by tanggal desc";
                (gcOkl.ExGridView.Columns["price"].ColumnEdit as GridLookUpEx).Query = query;
            }
            /*
            if (gcOkl.ExGridView.GetFocusedRowCellValue("nodsg") != null && gcOkl.ExGridView.GetFocusedRowCellValue("nodsg").ToString() != "")
                ((GridLookUpEx)gcOkl.ExGridView.Columns["price"].ColumnEdit).Query = "Call SP_LookUpPriceList('" + gcOkl.ExGridView.GetFocusedRowCellValue("nodsg").ToString() + "')";
            else
                ((GridLookUpEx)gcOkl.ExGridView.Columns["price"].ColumnEdit).Query = "Call SP_LookUpPriceList('')";*/
        }

        void InvColumnEdit_Enter(object sender, EventArgs e)
        {
            //if (gcOkl.ExGridView.GetFocusedRowCellValue("nodsg") == null)
            //{
            //    ((ButtonEdit)sender).Enabled = true;
            //    return;
            //}

            //if (gcOkl.ExGridView.GetFocusedRowCellValue("nodsg").ToString() == "")
            //    ((ButtonEdit)sender).Enabled = true;
            //else
            //    ((ButtonEdit)sender).Enabled = false;

            DataTable dtsub = DB.sql.Select("select kodeinv from sub where sub='"+ctrlSub.txtSub.EditValue.ToString() +"'");     
              if (dtsub.Rows.Count > 0)
                {
                   if (dtsub.Rows[0]["kodeinv"].ToString() == "Kode B")
                      (gcOkl.ExGridView.Columns["inv"].ColumnEdit as GridLookUpEx).Query = "Call SP_LookUp('invpenj1')";
                  else
                      (gcOkl.ExGridView.Columns["inv"].ColumnEdit as GridLookUpEx).Query = "Call SP_LookUp('invpenj')";  
                }

                if (ctrlSub.txtSub.EditValue.ToString() == "1110002")
                {
                    if (gcOkl.ExGridView.GetFocusedRowCellValue("inv") != null)
                    {
                        string kodeBarang = gcOkl.ExGridView.GetFocusedRowCellValue("inv").ToString();
                        DataTable dtprice = DB.sql.Select("select F_GetPrice('" + kodeBarang + "'," + ((DateTime) dateDate.EditValue).ToString("yyyyMMdd") + ")");
                        if (dtprice.Rows.Count > 0)
                        {
                            double price = (double)dtprice.Rows[0][0];
                            gcOkl.ExGridView.SetFocusedRowCellValue(gcOkl.ExGridView.Columns["price"], price);
                        }
                    }
                }
        }

        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
            gcOkl.ExGridView.BestFitColumns();
            comboBox1.Enabled = true;
        }

        void tsmiPrintInv_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepMOSO" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_Print('Transaction.FrmTOrderjual','" + this.NoDocument + "')");
            report.PrintingSystem.ShowMarginsWarning = false;
            report.Controls[6].Controls["lblUser"].Text = DB.casUser.Name;
            report.ShowPreview();
        }

        void tsmiPreviewInv_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepSO" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_Print('Transaction.FrmTOrderjual','" + this.NoDocument + "')");
            report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
           report.ShowPreview();
        }

        void ExGridView_New_Click(object sender, EventArgs e)
        {
            DataRow row = casDataSet.okd.NewRow();
            row["okl"] = NoDocument;
            row["qty"] = 0;
            row["qty1"] = 0;
            row["packaging"] = 0;
            row["inv"] = "";
            row["loc"] = "";
            row["unit"] = "";
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            casDataSet.okd.Rows.Add(row);

            DB.InsertDetailRows(gcOkl.ExGridView, row);
        }

        void ExGridView_Delete_Click(object sender, EventArgs e)
        {
            bool canDeleteitem, canDelete = true;
            int[] selectedIndex = gcOkl.ExGridView.GetSelectedRows();
            for (int i = 0; i < selectedIndex.Length; i++)
            {
                string okl = gcOkl.ExGridView.GetDataRow(selectedIndex[i])["okl"].ToString();
                int no = Convert.ToInt32(gcOkl.ExGridView.GetDataRow(selectedIndex[i])["no"]);
                canDeleteitem = DeleteLineItem(okl, no);
                if (canDeleteitem == false) canDelete = false;
            }
            if (canDelete) DB.DeleteDetailRows(gcOkl.ExGridView);
            ReCalculateTotal();
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            gcOkl.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcOkl.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcOkl.ExGridView.OptionsBehavior.Editable = true;
            gcOkl.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
         //   curcur.Properties.ReadOnly = true;

            copyDetailTable.Clear();
            copyDetailTable = DetailTable.Copy();
        }

        protected override void tsbtnCancel_Click(object sender, EventArgs e)
        {
            DB.CancelDetailRows(DetailTable);

            base.tsbtnCancel_Click(sender, new EventArgs());

            if (this.mode == Mode.View)
            {
                gcOkl.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                gcOkl.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                gcOkl.ExGridView.OptionsBehavior.Editable = false;
                gcOkl.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;

                txtAlias.EditValue = "";

                DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
            }
            comboBox1.Enabled = true;
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            DetailTable.Clear();
            gcOkl.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcOkl.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcOkl.ExGridView.OptionsBehavior.Editable = true;
            gcOkl.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            ReCalculateTotal();
            txtAlias.ExSqlQuery = "";
            Utility.SetReadOnly(pnlTotal, true);
            Cbppn.Checked = true;
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate Controls
                this.ValidateChildren();

                if (ctrlSub.txtSub.EditValue.ToString() == "")
                    throw new Exception("Harap mengisi customer!");
                
                if (curkurs.EditValue.ToString() == "0")
                    throw new Exception("Harap mengisi kurs!");

                if (nopocTextEdit.EditValue.ToString() == "")
                    throw new Exception("Harap mengisi PO customer!");

                if (gcOkl.ExGridView.EditingValue != null)
                    gcOkl.ExGridView.SetFocusedValue(gcOkl.ExGridView.EditingValue);

                DetailBindingSource.EndEdit();

                ////CEK NILAI BUDGET PIUTANG
                //string sub = ctrlSub.txtSub.EditValue.ToString();
                //double total = 0;
                //double budget = 0;
                //double val = Convert.ToDouble(txtTotal.Text);
                //DataTable dtTpb = DB.sql.Select("call SP_CekBudgetPiutang('" + ctrlSub.txtSub.EditValue.ToString() + "')");
                //foreach (DataRow drTpb in dtTpb.Rows)
                //{
                //    total = Convert.ToDouble(drTpb["totalval"]);
                //    budget = Convert.ToDouble(drTpb["budget"]);
                //}

                //if ((budget + total - val) <= 0 && budget > 0)
                //    throw new Exception("Transaksi tidak dapat diproses dikarenakan telah melebihi limit budget. Sisa budget saat ini : '" + total + "'");
                ////END CEK NILAI BUDGET

                isDetailValid = true;

                //if (gcOkl.ExGridView.FocusedRowHandle >= 0)
                //    ExGridView_ValidateRow(sender, new ValidateRowEventArgs(gcOkl.ExGridView.FocusedRowHandle, gcOkl.ExGridView.GetRow(gcOkl.ExGridView.FocusedRowHandle)));

                //if (!isDetailValid)
                //{
                //    MessageBox.Show("Duplicate entry on detail. Please correct the value");
                //    return;
                //}
                string pinv, premark, psub, psubname, psatuan, pno_po, pcur, pchusr, pchtime;
                double pprice, pdisc;
                DateTime ptanggal;
                DataRow row1 = ctrlSub.txtSub.ExGetDataRow();
                double totVal = 0;
                bool harga = false;
                for (int i = DetailTable.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = DetailTable.Rows[i];
                    if (row != null && row.RowState != DataRowState.Deleted)
                    {
                        pinv = row["inv"].ToString();
                        premark = row["remark"].ToString();
                        premark = premark.Replace("'", "''");
                        psub = ctrlSub.txtSub.Text;
                        psubname = row1["nama"].ToString();
                        psubname = psubname.Replace("'", "''");
                        psatuan = row["unit"].ToString();
                        pno_po = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
                        pcur = curcur.Text;
                        pchusr = DB.casUser.Name;
                        pchtime = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                        pprice = Convert.ToDouble(row["price"].ToString().Replace(",","."));
                        pdisc = Convert.ToDouble(row["disc"].ToString());
                        ptanggal = Convert.ToDateTime(dateDate.Text);
                      //  DB.sql.Execute("Call SP_SaveToHJL('" + pinv + "','','" + psub + "','" + psubname + "'," + pprice + ",'" + psatuan + "','" + pno_po + "'," + ptanggal.ToString("yyyyMMdd") + ",'" + pcur + "'," + pdisc + ",'" + pchusr + "','" + pchtime + "')");
                        
                        row[0] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
                        //row["no"] = i + 1;
                        totVal = totVal + (double)row["val"];
                        if (row["dateneed"] == DBNull.Value)
                            throw new Exception("Harap mengisi tanggal dibutuhkan!");
                        if (row["unit"].ToString() == "")
                            throw new Exception("Harap mengisi unit!");
                        if (Convert.ToDouble(row["qty1"]) == 0)
                            throw new Exception("Harap mengisi qty!");
                        if (Convert.ToDouble(row["price"]) == 0)
                        {
                            harga = true;

                        }
                        //if (row["nodsg"].ToString() == "" && withMOCheckBox.Checked)
                        //    throw new Exception("Harap mengisi design!");
                    }
                }
                
                if (harga)
                {
                    MessageBox.Show("Harap Menginputkan Harga");
                }

                ((DataRowView)MasterBindingSource.Current).Row["group_"] = 2;
                ((DataRowView)MasterBindingSource.Current).Row["val"] = totVal;
                ((DataRowView)MasterBindingSource.Current).Row["duedate"] = ((DateTime)dateDate.EditValue).AddDays(Convert.ToDouble(spinTOP.EditValue));

                // added & modified by rendra (08/12/2010)
                double limit = Convert.ToDouble(row1["Limit"]);
                if (totVal > limit && limit != 0 && !DB.casUser.AllowApprove(this.Tag.ToString()))
                {
                    ((DataRowView)MasterBindingSource.Current).Row["aprov"] = Convert.ToInt64(false);
                    MessageBox.Show("Total is greater than Supplier Limit (" + limit.ToString("n") + ")\n\rContact Supervisor for Approving");
                }
                else
                    ((DataRowView)MasterBindingSource.Current).Row["aprov"] = Convert.ToInt64(true);

                base.tsbtnSave_Click(sender, e);
                
                //DB.sql.Execute("Call SP_Save(00000000, 'OKL','" + ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text + "')");

                gcOkl.ExGridView.OptionsBehavior.Editable = false;
                gcOkl.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                gcOkl.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                gcOkl.ExToolStrip.Items["tsbtnNew"].Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

            double disc = subTotal * (Convert.ToDouble(Spindisc.EditValue)) / 100;
            txtDisc.EditValue = disc;

            double ppn = 0;
            if (Cbppn.Checked)
                ppn = (subTotal - disc) * 0.1;
            txtPPN.EditValue = ppn;

            double total = subTotal - disc + ppn;
            txtTotal.EditValue = total;
        }

        private bool isEditAllowed(string okl, int no)
        {
            string query = "Select FCanDeleteLineItem('" + DetailTable.TableName.ToString() + "','" + okl +"'," + no.ToString() + ")";
            if (DB.sql.Select(query).Rows[0][0].ToString() == "False")
                return false;
            else
                return true;
            //string query = "Select FCekDeleted('OKL', '" + okl + "')";
            //if (DB.sql.Select(query).Rows[0][0].ToString() == "False")
            //    return false;
            //else
            //    return true;
        }

        
        void ExGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "price" || e.Column.FieldName == "disc")
            {
                if (e.Column.FieldName == "price" && MasterBindingSource.Position != MasterTable.Rows.Count)
                {
                    string okl = (string)gcOkl.ExGridView.GetFocusedRowCellValue("okl");
                    string inv = (string)gcOkl.ExGridView.GetFocusedRowCellValue("inv");
                    int no = Convert.ToInt32(gcOkl.ExGridView.GetFocusedRowCellValue("no"));
                    double oldPrice = 0;
                    try
                    {
                        DataRow drCopyDetailTable;
                        drCopyDetailTable = copyDetailTable.Select("no=" + no.ToString())[0];
                        oldPrice = Convert.ToDouble(drCopyDetailTable["price"]);
                    }
                    catch { }
                    if (oldPrice != 0 && oldPrice != Convert.ToDouble(e.Value) && !isEditAllowed(okl, no))
                    {
                        MessageBox.Show("Edit item SO tidak diperbolehkan karena sudah di-SPM");
                        gcOkl.ExGridView.SetFocusedRowCellValue(gcOkl.ExGridView.Columns["price"], oldPrice);
                        //DetailTable.RejectChanges();
                        return;
                    }
                }

                double price = (double)gcOkl.ExGridView.GetFocusedRowCellValue("price");
                //double qty1 = (double)gcOkl.ExGridView.GetFocusedRowCellValue("qty1");
                double qty = (double)gcOkl.ExGridView.GetFocusedRowCellValue("qty");
                double disc = (double)gcOkl.ExGridView.GetFocusedRowCellValue("disc");
                double val = price * qty * ((100 - disc) / 100);
                gcOkl.ExGridView.SetFocusedRowCellValue(gcOkl.ExGridView.Columns["val"], val);

                ReCalculateTotal();
            }

            else if (e.Column.FieldName == "unit" || e.Column.FieldName == "qty1")
            {
                DetailBindingSource.EndEdit();
                string inv = (string)gcOkl.ExGridView.GetFocusedRowCellValue("inv");
                string unit = (string)gcOkl.ExGridView.GetFocusedRowCellValue("unit");
                double qty1 = (double)gcOkl.ExGridView.GetFocusedRowCellValue("qty1");
                if (inv != "" && unit != "")
                {
                    gcOkl.ExGridView.SetFocusedRowCellValue(gcOkl.ExGridView.Columns["qty"], DB.GetQtyInBaseUom(inv, unit, qty1));
                    if (e.Column.FieldName == "qty1")
                    {
                        string okl = (string)gcOkl.ExGridView.GetFocusedRowCellValue("okl");
                        int no = Convert.ToInt32(gcOkl.ExGridView.GetFocusedRowCellValue("no"));
                        double oldQty1 = 0;
                        try
                        {
                            DataRow drCopyDetailTable;
                            drCopyDetailTable = copyDetailTable.Select("no=" + no.ToString())[0];
                            oldQty1 = Convert.ToDouble(drCopyDetailTable["qty1"]);
                        }
                        catch { }
                        //if (MasterBindingSource.Position != MasterTable.Rows.Count &&        !isEditQty(okl, no) &&
                        //    oldQty1 != 0 && oldQty1 != qty1)
                        //{
                        //    MessageBox.Show("Edit item SO tidak diperbolehkan karena sudah di-SPM");
                        //    gcOkl.ExGridView.SetFocusedRowCellValue(gcOkl.ExGridView.Columns["qty1"], oldQty1);
                        //    //DetailTable.RejectChanges();
                        //    return;
                        //}
                        //  gcOkl.ExGridView.SetFocusedRowCellValue(gcOkl.ExGridView.Columns["qty1"], oldQty1);
                        double price = (double)gcOkl.ExGridView.GetFocusedRowCellValue("price");
                        double disc = (double)gcOkl.ExGridView.GetFocusedRowCellValue("disc");
                        double qty = (double)gcOkl.ExGridView.GetFocusedRowCellValue("qty");
                        double val = price * qty * ((100 - disc) / 100);
                        gcOkl.ExGridView.SetFocusedRowCellValue(gcOkl.ExGridView.Columns["val"], val);
                        ReCalculateTotal();
                    }
                }
                //ExGridView_ValidateRow(sender, new ValidateRowEventArgs(gcOkl.ExGridView.FocusedRowHandle, gcOkl.ExGridView.GetRow(gcOkl.ExGridView.FocusedRowHandle)));
            }
                 
                /*
                else if (e.Column.FieldName == "qty" || e.Column.FieldName == "unit")
                {
                    string inv = (string)gcOkl.ExGridView.GetFocusedRowCellValue("inv");
                    string unit = (string)gcOkl.ExGridView.GetFocusedRowCellValue("unit");
                    double qty = (double)gcOkl.ExGridView.GetFocusedRowCellValue("qty");
                    double qty1 = (double)gcOkl.ExGridView.GetFocusedRowCellValue("qty1");
                    if (DB.GetQtyInAlternativeUom(inv, unit, qty) != qty1)
                        gcOkl.ExGridView.SetFocusedRowCellValue(gcOkl.ExGridView.Columns["qty1"], DB.GetQtyInAlternativeUom(inv, unit, qty));
                }

                else if (e.Column.FieldName == "qty1")
                {
                    string inv = (string)gcOkl.ExGridView.GetFocusedRowCellValue("inv");
                    string unit = (string)gcOkl.ExGridView.GetFocusedRowCellValue("unit");
                    double qty1 = (double)gcOkl.ExGridView.GetFocusedRowCellValue("qty1");
                    string okl = (string)gcOkl.ExGridView.GetFocusedRowCellValue("okl");
                    int no = Convert.ToInt32(gcOkl.ExGridView.GetFocusedRowCellValue("no"));
                    double oldQty1 = 0;
                    try
                    {
                        DataRow drCopyDetailTable;
                        drCopyDetailTable = copyDetailTable.Select("no=" + no.ToString())[0];
                        oldQty1 = Convert.ToDouble(drCopyDetailTable["qty1"]);
                    }
                    catch { }
                    gcOkl.ExGridView.SetFocusedRowCellValue(gcOkl.ExGridView.Columns["qty"], DB.GetQtyInBaseUom(inv, unit, qty1));
                    double qty = (double)gcOkl.ExGridView.GetFocusedRowCellValue("qty");
                    string unitbase = (string)gcOkl.ExGridView.GetFocusedRowCellValue("Unit Base");
                    string query = "select spd.okl,sum(qty) qtyspm,(select okd.qty from okd where okl=spd.okl and inv=spd.inv) qtySOL from spd where okl='" + okl + "' and inv='" + inv + "' group by spd.okl,spd.inv";
                    try
                    {
                        if ((double)DB.sql.Select(query).Rows[0][1] > qty && (DB.sql.Select(query).Rows.Count > 0))
                        {
                            MessageBox.Show("Quantity Order tidak boleh kurang dari Quantity yang sudah di SPM " + DB.sql.Select(query).Rows[0][1].ToString() + " unit: " + unitbase);
                            gcOkl.ExGridView.SetFocusedRowCellValue(gcOkl.ExGridView.Columns["qty1"], oldQty1);
                            return;
                        }
                    }
                    catch { }
                }
        */
        }

        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gcOkl.ExGridView.GetDataRow(e.RowHandle);
            row["okl"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
            //row["no"] = DetailTable.Rows.Count + 1;
            row["packaging"] = 0;
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            row["toleransi"] = DB.GetToleransi(ctrlSub.txtSub.EditValue.ToString());
        }

           
        private void txtNo_EditValueChanged(object sender, EventArgs e)
        {
            if (MasterBindingSource.Position != MasterTable.Rows.Count)
            {
                DateTime dueDate = ((DateTime)MasterTable.Rows[MasterBindingSource.Position]["duedate"]).Date;
                DateTime date = ((DateTime)MasterTable.Rows[MasterBindingSource.Position]["date"]).Date;
                spinTOP.EditValue = ((TimeSpan)dueDate.Subtract(date)).TotalDays;
                ReCalculateTotal();
            }
        }

       
        private void FrmOrderjual_Load(object sender, EventArgs e)
        {
            Utility.SetSqlInstance(pnlDetail, DB.sql);
            ctrlSub.txtSub.DataBindings.Add("EditValue", MasterBindingSource, "sub");
            ctrlSub.txtSub.EditValueChanged += new EventHandler(txtSub_EditValueChanged);
            txtSub_EditValueChanged(ctrlSub.txtSub, new EventArgs());
            Utility.SetNumberFormat(pnlTotal, "n2");
            ReCalculateTotal();
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
            if (MasterBindingSource.Position == MasterTable.Rows.Count)
            {
                Utility.SetReadOnly(pnlTotal, true);
                Cbppn.Checked = true;
            }
            comboBox1.Enabled = true;
        }

        private void txtSub_EditValueChanged(object sender, EventArgs e)
        {
            DataRow row = ctrlSub.txtSub.ExGetDataRow();
            //if (row == null)
            //{
            //    curcur.EditValue = "";
            //    return;
            //}
            //curcur.EditValue = row["cur"].ToString();
            //spinTOP.EditValue = row["top"].ToString();

            txtAlias.ExSqlQuery = "select aliasname,shiptoname,concat(shiptoaddress,' - ',city) as shiptoaddress  from subto where sub='" + ctrlSub.txtSub.Text + "'";
        }

        private void Cbppn_CheckedChanged(object sender, EventArgs e)
        {
            ReCalculateTotal();
        }

        private void Spindisc_EditValueChanged(object sender, EventArgs e)
        {
            ReCalculateTotal();
        }

        private void txtAlias_TextChanged(object sender, EventArgs e)
        {
            if (txtAlias.ExSqlInstance == null)
                return;

            DataRow row = txtAlias.ExGetDataRow();
            if (row == null)
            {
                shiptonameTextEdit.Text = "";
                Memoshipto.Text = "";
                return;
            }
            shiptonameTextEdit.Text = row["shiptoname"].ToString();
            Memoshipto.Text = row["shiptoaddress"].ToString();
        }

        private void oklBindingSource_PositionChanged(object sender, EventArgs e)
        {
            
        }

        void remarkColumnEdit_Enter(object sender, EventArgs e)
        {
            if (gcOkl.ExGridView.GetFocusedRowCellValue("inv") != null)
            {
                string kodeBarang = gcOkl.ExGridView.GetFocusedRowCellValue("inv").ToString();
                if (kodeBarang.StartsWith("9"))
                    ((TextEdit)sender).Properties.ReadOnly = false;
                else
                    ((TextEdit)sender).Properties.ReadOnly = true;
            }
            else
                ((TextEdit)sender).Properties.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB.sql.Execute("update okl set status='" + comboBox1.Text + "' where okl='" + ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text + "'");
        }

        private void pnlDetail_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nopocTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (nopocTextEdit.Text.Trim() != "" && this.mode != Mode.View)
            {
                DataTable dtpo = DB.sql.Select("select nopoc from okl where trim(nopoc)='" + nopocTextEdit.Text + "'");
                if (dtpo.Rows.Count > 0)
                {
                    MessageBox.Show("Nomor PO sudah ada");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.mode == Mode.Edit)
                DB.sql.Execute("Update okd set price=0, val=0 where okd.okl ='" + NoDocument + "'");
        }
                 
    }
}

