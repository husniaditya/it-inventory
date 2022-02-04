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
using DevExpress.XtraReports.UI;

namespace CAS.Transaction
{
    public partial class FrmTSpm : CAS.Transaction.BaseTransaction
    {
        private int[] selectedIndex = new int[0];
        private bool isDetailValid = true;
        public FrmTSpm()
        {
            InitializeComponent();

            ToolStripMenuItem tsmiPrintPreview = new ToolStripMenuItem("Print Preview", null, new EventHandler(tsmiPrintPreview_Click));
            ToolStripMenuItem tsmiPrintDirectly = new ToolStripMenuItem("Print Directly", null, new EventHandler(tsmiPrintDirectly_Click));
            ToolStripDropDownButton tsbtnPrint = new ToolStripDropDownButton("Print", null, tsmiPrintPreview, tsmiPrintDirectly);
            tsbtnPrint.Image = MasterNavigator.Items["tsbtnPrint"].Image;
            MasterNavigator.Items.Insert(MasterNavigator.Items.IndexOfKey("tsbtnPrint"), tsbtnPrint);
            MasterNavigator.Items.RemoveByKey("tsbtnPrint");

            DetailTable.Columns.Add("Unit Base Dikirim", typeof(String));
            MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);

            Utility.SetSqlInstance(pnlDetail, DB.sql);
            gcSpm.ExGridControl.DataSource = spdBindingSource;
            gcSpm.ExTitleLabel.Text = "Surat Perintah Muat";
            gcSpm.ExGridView.OptionsView.ShowGroupPanel = false;
            gcSpm.ExGridView.OptionsCustomization.AllowSort = false;

            gcSpm.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
            gcSpm.ExGridView.CellValueChanged += new CellValueChangedEventHandler(ExGridView_CellValueChanged);
            //gcSpm.ExGridView.ValidateRow += new ValidateRowEventHandler(ExGridView_ValidateRow);

            gcSpm.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
            gcSpm.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
            gcSpm.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gcSpm.ExToolStrip.Items["tsbtnNew"].Enabled = false;

            gcSpm.ExGridView.Columns["spm"].OptionsColumn.AllowEdit = false;
            gcSpm.ExGridView.Columns["qty"].OptionsColumn.AllowEdit = false;
                        
            gcSpm.ExGridView.Columns["no"].Visible = false;
            gcSpm.ExGridView.Columns["spm"].Visible = false;
            //gcSpm.ExGridView.Columns["okl"].Visible = false;
            gcSpm.ExGridView.Columns["cct"].Visible = false;
            //gcSpm.ExGridView.Columns["nodsg"].Visible = false;
            gcSpm.ExGridView.Columns["mor"].Visible = false;

            gcSpm.ExGridView.Columns["inv"].ColumnEdit = new GridLookUpEx(DB.sql, "", "", "inv", gcSpm.ExGridView, "", true, true, "");
            gcSpm.ExGridView.Columns["inv"].ColumnEdit.Enter += new EventHandler(ExGridView_InvColumnEdit_Enter);
            gcSpm.ExGridView.Columns["loc"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('loc')", "loc", "loc", gcSpm.ExGridView, "",false, false, "Location");
            gcSpm.ExGridView.Columns["unit"].ColumnEdit = new GridLookUpUnit(gcSpm.ExGridView);
            gcSpm.ExGridView.Columns["unitgudang"].ColumnEdit = new GridLookUpUnit(gcSpm.ExGridView, "Unit Dikirim");
            gcSpm.ExGridView.Columns["nodsg"].ColumnEdit = new GridLookUpEx(DB.sql, "Call Sp_GetStockBatch(" + DateTime.Now.ToString("yyyyMMdd") + ",'')", "", "No Batch", gcSpm.ExGridView, "", true, true, "Batch");
            gcSpm.ExGridView.Columns["nodsg"].ColumnEdit.Enter += new EventHandler(DsgColumnEdit_Enter);
            
            gcSpm.ExGridView.Columns["qty1"].ColumnEdit = new GridNumEx();
            gcSpm.ExGridView.Columns["qtygudang"].ColumnEdit = new GridNumEx();
        
            gcSpm.ExGridView.OptionsBehavior.Editable = true;
            gcSpm.ExGridView.OptionsSelection.MultiSelect = true;

            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            //tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);

            gcSpm.ExGridView.Columns["okl"].Caption = "Purchase Order";
            gcSpm.ExGridView.Columns["inv"].Caption = "Kode Barang";
            gcSpm.ExGridView.Columns["remark"].Caption = "Nama Barang";
            gcSpm.ExGridView.Columns["loc"].Caption = "Loc";
            gcSpm.ExGridView.Columns["qty"].Caption = "Qty Base Dikirim";
            gcSpm.ExGridView.Columns["unit"].Caption = "Unit";
            gcSpm.ExGridView.Columns["qty1"].Caption = "Qty";
            gcSpm.ExGridView.Columns["qtygudang"].Caption = "Qty Dikirim";
            gcSpm.ExGridView.Columns["unitgudang"].Caption = "Unit Dikirim";
            gcSpm.ExGridView.Columns["etd"].Caption = "Keterangan";
            gcSpm.ExGridView.Columns["nodsg"].Caption = "No Batch";
            gcSpm.ExGridView.Columns["spesifikasi"].Caption = "Spesifikasi";

            gcSpm.ExGridView.Columns["okl"].VisibleIndex = 0;
            gcSpm.ExGridView.Columns["inv"].VisibleIndex = 1;
            gcSpm.ExGridView.Columns["remark"].VisibleIndex = 2;
            gcSpm.ExGridView.Columns["spesifikasi"].VisibleIndex = 3;
            gcSpm.ExGridView.Columns["loc"].VisibleIndex = 4;
            gcSpm.ExGridView.Columns["nodsg"].VisibleIndex = 5;
            gcSpm.ExGridView.Columns["expired"].VisibleIndex = 6;
            gcSpm.ExGridView.Columns["qty1"].VisibleIndex = 7;
            gcSpm.ExGridView.Columns["unit"].VisibleIndex = 8;
            gcSpm.ExGridView.Columns["qtygudang"].VisibleIndex = 9;
            gcSpm.ExGridView.Columns["unitgudang"].VisibleIndex = 10;
            gcSpm.ExGridView.Columns["qty"].VisibleIndex = 11;
            gcSpm.ExGridView.Columns["Unit Base Dikirim"].VisibleIndex = 12;//DetailTable.Columns.IndexOf("qty");
            gcSpm.ExGridView.Columns["etd"].VisibleIndex = 13;
            gcSpm.ExGridView.Columns["Unit Base Dikirim"].OptionsColumn.AllowEdit = false;
          
            gcSpm.ExGridView.BestFitColumns();
       //     tsbtnBrowse.Click += new EventHandler(tsbtnbrowse_Click);
        }


        protected override void tsbtnBrowse_Click(object sender, EventArgs e)
        {
            string query="";
            string keyfield = MasterTable.Columns[0].ColumnName;
            if (this.Tag.ToString() == "25k")
               query = "Call SP_Browse('SPM Transfer','" + DB.loginPeriod + "')";
            else
               query = "Call SP_Browse('" + this.Name + "','" + DB.loginPeriod + "')";

            FrmDialog frmDialog = new FrmDialog(this.Text, DB.sql, query);
            if (frmDialog.ShowDialog() == DialogResult.OK)
            {
                MasterBindingSource.Position = MasterBindingSource.Find(keyfield, frmDialog.ResultRows[0][0].ToString());
            }
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
            inv = gcSpm.ExGridView.GetFocusedRowCellValue("inv").ToString();
            if (gcSpm.ExGridView.GetFocusedRowCellValue("inv") != null)
                (gcSpm.ExGridView.Columns["nodsg"].ColumnEdit as GridLookUpEx).Query = "Call Sp_GetStockBatch(" + DateTime.Now.ToString("yyyyMMdd") + ",'" + inv + "')";
        }

        void tsmiPrintDirectly_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepSpmJual" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_Print('Transaction.FrmTSpmJual','" + this.NoDocument + "')");
            report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
            /*
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
            report.PrintingSystem.ShowMarginsWarning = false;;
            report.PaperName = "1/2A4";
            report.Print();
        }

        void tsmiPrintPreview_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepSpmJual" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_Print('Transaction.FrmTSpmJual','" + this.NoDocument + "')");
            report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
            /*
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
            report.ShowPreview();
        }

        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base Dikirim");
            if (this.mode == Mode.View)
                okl_rmaTextBoxEx.ExAutoCheck = false;
            gcSpm.ExGridView.BestFitColumns();
        }

        void ExGridView_InvColumnEdit_Enter(object sender, EventArgs e)
        {
            GridLookUpEx invLookUp = gcSpm.ExGridView.Columns["inv"].ColumnEdit as GridLookUpEx;
            //invLookUp.Query = "select rma,inv,remark,loc,unit,qty1,qty,cct,no from rmb where rma='" + okl_rmaTextBoxEx.Text + "'";
            //invLookUp.Query = "Call SP_OutSpm('" + okl_rmaTextBoxEx.EditValue.ToString() + "', 2)";
            //invLookUp.TableName = "rmb_in";
            invLookUp.Query = "Call SP_LookUp('invspm')";
            invLookUp.TableName = "inv";
        }

        void ExGridView_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            if (((DataRowView)e.Row).Row["inv"].ToString() == "" ||
                ((DataRowView)e.Row).Row["loc"].ToString() == "")
            {
                e.Valid = false;
                e.ErrorText = "Invalid Kode Barang/Location.";
                isDetailValid = false;
            }
            else
            { isDetailValid = true; }
        }

        void ExGridView_New_Click(object sender, EventArgs e)
        {
            DataRow row = casDataSet.spd.NewRow();
            row["spm"] = NoDocument;
            row["qty"] = 0;
            row["qty1"] = 0;
            row["inv"] = "";
            row["loc"] = "";
            row["unit"] = "";
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            casDataSet.spd.Rows.Add(row);

            DB.InsertDetailRows(gcSpm.ExGridView, row);
        }

        void ExGridView_Delete_Click(object sender, EventArgs e)
        {
            bool canDeleteitem, canDelete = true;
            int[] selectedIndex = gcSpm.ExGridView.GetSelectedRows();
            for (int i = 0; i < selectedIndex.Length; i++)
            {
                string prq = gcSpm.ExGridView.GetDataRow(selectedIndex[i])["spm"].ToString();
                int no = Convert.ToInt32(gcSpm.ExGridView.GetDataRow(selectedIndex[i])["no"]);
                canDeleteitem = DeleteLineItem(prq, no);
                if (canDeleteitem == false) canDelete = false;
            }
            if (canDelete) DB.DeleteDetailRows(gcSpm.ExGridView);
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            if (this.mode == Mode.Edit)
            {
                ctrlSub.ReadOnly = false;
                //okl_rkaTextBoxEx.Properties.ReadOnly = true;
                okl_rmaTextBoxEx.ExAutoCheck = true;
                gcSpm.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
                gcSpm.ExToolStrip.Items["tsbtnNew"].Enabled = true;
                gcSpm.ExGridView.OptionsBehavior.Editable = true;
                gcSpm.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            }
        }

        protected override void tsbtnCancel_Click(object sender, EventArgs e)
        {
            DB.CancelDetailRows(DetailTable);

            base.tsbtnCancel_Click(sender, new EventArgs());

            if (this.mode == Mode.View)
            {
                gcSpm.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                gcSpm.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                gcSpm.ExGridView.OptionsBehavior.Editable = false;
                gcSpm.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                ctrlSub.ReadOnly = true;
                DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base Dikirim");
                okl_rmaTextBoxEx.ExAutoCheck = false;
            }
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            ctrlSub.ReadOnly = false;
            okl_rmaTextBoxEx.Properties.ReadOnly = false;
            okl_rmaTextBoxEx.ExAutoCheck = true;
            DetailTable.Clear();
            gcSpm.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcSpm.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcSpm.ExGridView.OptionsBehavior.Editable = true;
            gcSpm.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            okl_rmaTextBoxEx.Select();
        }

        private double GetAvailableStock(double qty, string inv, string nodsg, string loc)
        {
            //cek stock
            string tgla = ((DateTime)dateDate.EditValue).ToString("yyyyMMdd");
            string tglz = ((DateTime)dateDate.EditValue).AddDays(1).ToString("yyyyMMdd");
            string query = "Call SP_KartuStock(" + tgla + "," + (tglz) + ",'','','" + inv + "','" + inv + "','" + loc + "','" + loc + "','" + nodsg + "','" + nodsg + "')";
            DataTable dtStock = DB.sql.Select(query);
            double qtyBalance = 0;
            try
            {
                DataRow[] drBalance = dtStock.Select("rem='BALANCE'");
                if (drBalance.Length > 0)
                {
                    qtyBalance = Convert.ToDouble(drBalance[0]["qdebet"]);
                    if (qtyBalance == 0)
                        qtyBalance = -1 * Convert.ToDouble(drBalance[0]["qkredit"]);
                }
                DataRow[] drInOut = dtStock.Select("(rem<>'BALANCE' or rem is null) and jurnal<>'" + NoDocument + "'");
                //cek qty available
                for (int j = 0; j < drInOut.Length; j++)
                {
                    if (drInOut[j]["dk"].ToString() == "K")
                        qtyBalance = qtyBalance - Convert.ToDouble(drInOut[j]["qkredit"]);
                    else
                        qtyBalance = qtyBalance + Convert.ToDouble(drInOut[j]["qdebet"]);
                }
            }
            catch { }
            return qtyBalance;
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate controls
                this.ValidateChildren();

                // COBA CEK STOK WAKTU SAVE COK !
                if (gcSpm.ExGridView.EditingValue != null)
                    gcSpm.ExGridView.SetFocusedValue(gcSpm.ExGridView.EditingValue);

                DetailBindingSource.EndEdit();

                foreach (DataRow row in DetailTable.Rows)
                {
                    if (row != null && row.RowState != DataRowState.Deleted)
                    {
                        //ExGridView_ValidateRow(sender, new ValidateRowEventArgs(i, gctrm.ExGridView.GetRow(i)));
                        //if (!isDetailValid)
                        //{
                        //    MessageBox.Show("Invalid Kode Barang. Please correct the value");
                        //    return;
                        //}

                        double qty = Convert.ToDouble(row["qty"]);
                        string inv = (string)row["inv"];
                        string nodsg = (string)row["nodsg"];
                        string loc = (string)row["loc"];

                        if (inv.Substring(0, 1) != "9")
                        {
                            double availableStock = GetAvailableStock(qty, inv, nodsg, loc);
                            if (Math.Ceiling(qty) > Math.Ceiling(availableStock))
                            {
                                MessageBox.Show("Qty max " + inv + " = " + availableStock + " " + row["Unit"].ToString());
                                return;
                            }
                        }
                    }
                }
                // END CEK STOK WAKTU SAVE COK !

                // Check Required Entries
                if (nopolTextEdit.Text.Trim() == "")
                    throw new Exception("No polisi harus diisi");

                if (this.Tag.ToString() == "25k")
                {
                    // set group_ to 3
                    ((DataRowView)MasterBindingSource.Current).Row["group_"] = 3;
                }
                else
                {
                    // set group_ to 2
                    ((DataRowView)MasterBindingSource.Current).Row["group_"] = 2;
                }
                DetailBindingSource.EndEdit();
              
                //double totVal = 0;
                bool isDuplicate = false;
                for (int i = DetailTable.Rows.Count - 1; i >= 0; i--)
                {
                    string loc = DetailTable.Rows[0]["loc"].ToString();
                    DataRow row = DetailTable.Rows[i];
                    if (row != null && row.RowState != DataRowState.Deleted)
                    {
                        row[0] = NoDocument;
                        if (row["inv"].ToString() == "" || row["loc"].ToString() == "" || loc != row["loc"].ToString())
                            throw new Exception("Kode Barang/Loc tidak valid");
                        //cek duplicate SPM Retur
                        if (MasterBindingSource.Position == MasterTable.Rows.Count)
                        {
                            string query = "select spd.* from spm, spd "
                                + "where spm.okl_rms='" + okl_rmaTextBoxEx.EditValue.ToString()
                                + "' and spm.spm = spd.spm and "
                                + "spd.inv='" + row["inv"].ToString() + "' "
                                + "and spd.remark='" + row["remark"].ToString().Replace("'", "''")
                                + "' and spm.spm not in (select spm from sjr)";
                            DataTable dt = DB.sql.Select(query);
                            if (dt.Rows.Count > 0)
                                isDuplicate = true;
                        }
                        //row["no"] = i + 1;
                        //totVal = totVal + (double)row["val"];
                    }
                }

                if (isDuplicate)
                {
                    //MessageBox.Show("SPM dengan detail yang sama sudah ada, dan belum dibuat SJ-nya", "Warning", MessageBoxButtons.OK);
                    DialogResult dlgResult = MessageBox.Show("SPM dengan detail yang sama sudah ada, dan belum dibuat SJ-nya. Anda yakin untuk menyimpan?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dlgResult != DialogResult.Yes)
                        return;
                }                

                base.tsbtnSave_Click(sender, e);

                string kategori = okl_rmaTextBoxEx.EditValue.ToString().Substring(0,3);
                if (kategori == "POJ")
                {
                    string date = ((DateTime)(dateDate.EditValue)).ToString("yyyyMMdd");
                   
                    DB.sql.Execute("Call SP_Save(" + date + ",'SPJ','" + NoDocument + "')");
                }

                if (this.mode == Mode.View)
                {
                    gcSpm.ExGridView.OptionsBehavior.Editable = false;
                    gcSpm.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                    gcSpm.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                    gcSpm.ExToolStrip.Items["tsbtnNew"].Enabled = false;

                    okl_rmaTextBoxEx.Properties.ReadOnly = true;
                    okl_rmaTextBoxEx.ExAutoCheck = false;
                    ctrlSub.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private decimal GetMaxValueQtyDikirim(string unit)
        {
            string rms = okl_rmaTextBoxEx.EditValue.ToString();
            string inv = gcSpm.ExGridView.GetFocusedRowCellValue("inv").ToString();
            string remark = gcSpm.ExGridView.GetFocusedRowCellValue("remark").ToString();
            //string unitgd = gcSpm.ExGridView.GetFocusedRowCellValue("unitgudang").ToString();
            string baseUnit = (string)gcSpm.ExGridView.GetFocusedRowCellValue("Unit Base Dikirim");
            DataTable dtOutSpm = DB.sql.Select("Call SP_OutSpm('" + rms + "',2)");
            decimal maxValue = 0;
            try
            {
                DataRow dr = dtOutSpm.Select("`Kode Barang`='" + inv + "' and `Nama Barang`='" + remark + "'")[0];
                string query = "select toleransi, sum(qty) as qty from rmd where rms='" + rms + "' and inv='" + inv + "' and remark='" + remark + "' group by rms";
                //double qtyToleransi = DB.GetQtyToleransi("rmd", "rms", rms, inv, remark, unit, "Retur");
                decimal qtySisa = Convert.ToDecimal(dr["Qty SJ"]);
                double qtyToleransi = DB.GetQtyToleransi(query, inv, unit, baseUnit);
                if (unit != dr["Unit SJ"].ToString())
                    //convert Qty & unit dari OutSpm ke Qty & unit inputan di SPM
                    qtySisa = Convert.ToDecimal(DB.GetQtyInAlternativeUom(inv, dr["Unit SJ"].ToString(), Convert.ToDouble(qtySisa), unit));
                maxValue = qtySisa + Convert.ToDecimal(qtyToleransi);
            }
            catch (Exception ex)
            {
                //do nothing
                MessageBox.Show(ex.Message);
            }
            return maxValue;
        }

        void ExGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "inv")
            {
                DetailBindingSource.EndEdit();
                DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base Dikirim");
                return;
            }
            
            string getinv = (string)gcSpm.ExGridView.GetFocusedRowCellValue("inv");
            if (getinv.Substring(0, 1) != "9")
            {
                if (e.Column.FieldName == "unitgudang" || e.Column.FieldName == "qtygudang")
                {
                    DetailBindingSource.EndEdit();
                    string inv = (string)gcSpm.ExGridView.GetFocusedRowCellValue("inv");
                    string unitDikirim = (string)gcSpm.ExGridView.GetFocusedRowCellValue("unitgudang");
                    double qtyDikirim = (double)gcSpm.ExGridView.GetFocusedRowCellValue("qtygudang");
                    if (inv != "" && unitDikirim != "")
                        gcSpm.ExGridView.SetFocusedRowCellValue(gcSpm.ExGridView.Columns["qty"], DB.GetQtyInBaseUom(inv, unitDikirim, qtyDikirim));
                    //if (qtyDikirim > 0 && unitDikirim != "")
                    //{
                    //    decimal maxQty = GetMaxValueQtyDikirim(unitDikirim);
                    //    if (Convert.ToDecimal(qtyDikirim) > maxQty)
                    //    {
                    //        MessageBox.Show("Qty Dikirim melebihi batas toleransi PO Retur. Max qty dikirim: " + maxQty.ToString() + " " + unitDikirim);
                    //        gcSpm.ExGridView.SetFocusedRowCellValue(gcSpm.ExGridView.Columns["qtygudang"], maxQty);
                    //    }
                    //}
                }
            }

            //if (e.Column.FieldName == "qty1" || e.Column.FieldName == "unit")
            //{
            //    string unitSJ = (string)gcSpm.ExGridView.GetFocusedRowCellValue("unit");
            //    double qtySJ = (double)gcSpm.ExGridView.GetFocusedRowCellValue("qty1");
            //    if (unitSJ != "" && qtySJ > 0)
            //    {
            //        decimal maxQty = GetMaxValueQtyDikirim(unitSJ);
            //        if (Convert.ToDecimal(qtySJ) > maxQty)
            //        {
            //            MessageBox.Show("Qty SJ melebihi batas toleransi PO Retur. Max qty SJ: " + maxQty.ToString() + " " + unitSJ);
            //            gcSpm.ExGridView.SetFocusedRowCellValue(gcSpm.ExGridView.Columns["qty1"], maxQty);
            //        }
            //    }
            //}
        }

        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gcSpm.ExGridView.GetDataRow(e.RowHandle);
            row["spm"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
            //row["no"] = DetailTable.Rows.Count + 1;
            row["no"] = DB.GetRowCount(DetailTable) + 1;
        }


        private void FrmTSpm_Load(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "25k")
            {
                //MasterTable.Clear();

                //MasterAdapter = DB.sql.SelectAdapter("select * from spm where sendgd=1 and aprov=0 and period='"+DB.loginPeriod+"'");
                //MasterAdapter.Fill(MasterTable);
                Filter = "group_= 3";
                DataTable temp = MasterTable.Copy();
                DataRow[] dRows = temp.Select(Filter);
                MasterTable.Clear();
                foreach (DataRow dr in dRows) MasterTable.ImportRow(dr);
                if (MasterTable.Rows.Count == 0)
                {
                    setMode(Mode.View);
                }
               
                ctrlSub.txtSub.DataBindings.Add("EditValue", MasterBindingSource, "sub");
                ctrlSub.txtSub.EditValueChanged += new EventHandler(txtSub_EditValueChanged);

                PopulateDetail();
            }
            else
            {
                Filter = "group_= 2";
                DataTable temp = MasterTable.Copy();
                DataRow[] dRows = temp.Select(Filter);
                MasterTable.Clear();
                foreach (DataRow dr in dRows) MasterTable.ImportRow(dr);
                if (MasterTable.Rows.Count == 0)
                {
                    setMode(Mode.View);
                }

                ctrlSub.txtSub.DataBindings.Add("EditValue", MasterBindingSource, "sub");
                ctrlSub.txtSub.EditValueChanged += new EventHandler(txtSub_EditValueChanged);

                PopulateDetail();
               // ctrlSub.txtSub.DataBindings.Add("EditValue", MasterBindingSource, "sub");
               // DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base Dikirim");
            }
            //ctrlSub.txtSub.EditValueChanged += new EventHandler(txtSub_EditValueChanged);
            //ctrlSub.txtSub.Select();
            //DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base Dikirim");
            //gcSpm.ExGridView.BestFitColumns();
            if (MasterBindingSource.Count == 0)
            {
                if (DB.casUser.AllowInsert(this.Tag.ToString()))
                    tsbtnNew.PerformClick();
                else
                    setMode(Mode.View);
            }
        }

        private void PopulateDetail()
        {
            DetailTable.Clear();
            //DetailAdapter = null;
            string query = "";
            if (MasterBindingSource.Position < 0 || MasterTable.Rows.Count == 0) return;
         
            query = "select * from " + DetailTable.TableName + " where " + DetailTable.Columns[0].ColumnName + "='" + MasterTable.Rows[MasterBindingSource.Position][0].ToString() + "'";
      
            DetailAdapter = DB.sql.SelectAdapter(query);
            try
            {
                DetailAdapter.Fill(DetailTable);
            }
            catch (Exception ex)
            {
            }
        }
        void txtSub_EditValueChanged(object sender, EventArgs e)
        {
            //okl_rmaTextBoxEx.ExSqlQuery = "select * from rms where sub='" + ctrlSub.txtSub.Text + "' and rms not in (select okl_rma as rms from spm)"; 
            //okl_rmaTextBoxEx.ExSqlQuery = "Call SP_OutSpm('" + ctrlSupplier1.txtSub.Text + "', 2)";
        }                       

        private void okl_rkaTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {
             DataRow row = okl_rmaTextBoxEx.ExGetDataRow();
            if (row == null)
                return;

        //    rmaTextEdit.EditValue = row["PR Retur"];
            ctrlSub.txtSub.EditValue = row["Kode Supplier"];

            if (MasterBindingSource.Position == MasterTable.Select(MasterBindingSource.Filter).Length)
            {
                DetailTable.Clear();
                GridLookUpEx invLookUp = gcSpm.ExGridView.Columns["inv"].ColumnEdit as GridLookUpEx;
                //invLookUp.Query = "select rma,inv,remark,loc,unit,qty1,qty,cct,no from rmb where rma='" + okl_rmaTextBoxEx.Text + "'";
                invLookUp.Query = "Call SP_OutSpmT('" + okl_rmaTextBoxEx.EditValue.ToString() + "', 3)";
                invLookUp.TableName = "rmb_in";
                invLookUp.ClickButton();
            }
       }

        private void appspmCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!aprovCheckBox.Enabled || !aprovCheckBox.Checked) return;
            bool canapprove = true;
            for (int i = 0; i <= DetailTable.Rows.Count - 1; i++)
            {
                if (Convert.ToDouble(DetailTable.Rows[i]["qtygudang"]) == 0)
                {
                    canapprove = false;
                }
            }
            if (!canapprove)
            {
                aprovCheckBox.Checked = false;
                MessageBox.Show("SPM tidak dapat diapprove karena ada item detail SPM yang memiliki qty 0");
            }
        }

        private void appspmLabel_Click(object sender, EventArgs e)
        {

        }

        private void nodocTextBoxEx_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            nodocTextBoxEx.ExSqlQuery = "SELECT nodoc,datedoc,no_bc,nopen FROM docp,docpd where docp.docp=docpd.docp and docp.oms = (select por.por from por where por='" + okl_rmaTextBoxEx.EditValue.ToString() + "')";

        }

        private void dateDate_EditValueChanged(object sender, EventArgs e)
        {
            if (this.mode != Mode.View)
            {
                tglbc.EditValue = dateDate.EditValue.ToString();
            }
        }

    
    }
}




