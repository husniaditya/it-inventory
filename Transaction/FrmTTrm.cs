using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using KASLibrary;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;


namespace CAS.Transaction
{
    public partial class FrmTTrm : CAS.Transaction.BaseTransaction
    {
        private int[] selectedIndex = new int[0];
        private bool isDetailValid = true;
      
        public FrmTTrm()
        {
            InitializeComponent();
            lockTextBoxEx.ExSqlQuery = "Call SP_LookUpLoc('" + DB.casUser.User + "')";
            lockTextBoxEx.ExSqlInstance = DB.sql;
            locdTextBoxEx.ExSqlInstance = DB.sql;

            DetailTable.Columns.Add("Unit Base", typeof(String));

            gctrm.ExGridControl.DataSource = trdBindingSource;
            gctrm.ExGridView.OptionsView.ShowGroupPanel = false;
            gctrm.ExTitleLabel.Text = "Detail Bukti Pemindahan Barang";
            gctrm.ExGridView.OptionsCustomization.AllowSort = false;

            gctrm.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
            gctrm.ExGridView.CellValueChanged += new CellValueChangedEventHandler(ExGridView_CellValueChanged);
            //gctrm.ExGridView.ValidateRow += new ValidateRowEventHandler(ExGridView_ValidateRow);            

            gctrm.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
            gctrm.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
            gctrm.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gctrm.ExToolStrip.Items["tsbtnNew"].Enabled = false;

            gctrm.ExGridView.Columns["trm"].OptionsColumn.AllowEdit = false;
            gctrm.ExGridView.Columns["inv"].OptionsColumn.AllowEdit = true;
            gctrm.ExGridView.Columns["remark"].OptionsColumn.AllowEdit = false;
            gctrm.ExGridView.Columns["qty"].OptionsColumn.AllowEdit = false;
            gctrm.ExGridView.Columns["no"].Visible = false;
            gctrm.ExGridView.Columns["trm"].Visible = false;
            
            // gctrm.ExGridView.Columns["inv"].ColumnEdit = new GridLookUpEx(DB.sql, "", "inv", "inv", gctrm.ExGridView, "", true, false, "Inventory");
            gctrm.ExGridView.Columns["nodsg"].ColumnEdit = new GridLookUpEx(DB.sql, "Call Sp_GetStockBatch(" + DateTime.Now.ToString("yyyyMMdd") + ",'')", "", "No Batch", gctrm.ExGridView, "", true, true, "Batch");
            gctrm.ExGridView.Columns["nodsg"].ColumnEdit.Enter += new EventHandler(DsgColumnEdit_Enter);
            gctrm.ExGridView.Columns["inv"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('invexcludedsg')", "", "inv", gctrm.ExGridView, "", true, true, "Inventory");
            gctrm.ExGridView.Columns["inv"].ColumnEdit.Enter += new EventHandler(ColumnEdit_Enter);
            gctrm.ExGridView.Columns["qty1"].ColumnEdit = new GridNumEx();
            gctrm.ExGridView.Columns["unit"].ColumnEdit = new GridLookUpUnit(gctrm.ExGridView);

            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            //tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);

            gctrm.ExGridView.Columns["inv"].Caption = "Kode Barang";
            gctrm.ExGridView.Columns["remark"].Caption = "Nama Barang";
            gctrm.ExGridView.Columns["nodsg"].Caption = "No Batch";
            gctrm.ExGridView.Columns["expired"].Caption = "Expired";
            gctrm.ExGridView.Columns["qty"].Caption = "Qty Base";
            gctrm.ExGridView.Columns["qty1"].Caption = "Qty";
            gctrm.ExGridView.Columns["unit"].Caption = "Unit";

            gctrm.ExGridView.Columns["nodsg"].VisibleIndex = 3; 
            gctrm.ExGridView.Columns["expired"].VisibleIndex = 3; 

            gctrm.ExGridView.Columns["Unit Base"].VisibleIndex = DetailTable.Columns.IndexOf("qty");
            gctrm.ExGridView.Columns["Unit Base"].OptionsColumn.AllowEdit = false;

            gctrm.ExGridView.BestFitColumns();
            gctrm.ExGridView.OptionsBehavior.Editable = false;
            gctrm.ExGridView.OptionsSelection.MultiSelect = true;
            gctrm.ExGridView.OptionsCustomization.AllowSort = false;
            DB.SetNumberFormat(gctrm.ExGridView, "n2");
            tsbtnPrint.Click += new EventHandler(tsbtnPrint_Click);

            MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);
        }

        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
            gctrm.ExGridView.BestFitColumns();
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
            inv = gctrm.ExGridView.GetFocusedRowCellValue("inv").ToString();
            if (gctrm.ExGridView.GetFocusedRowCellValue("inv") != null)
                (gctrm.ExGridView.Columns["nodsg"].ColumnEdit as GridLookUpEx).Query = "Call Sp_BppbGetStockBatch(" + DateTime.Now.ToString("yyyyMMdd") + ",'" + inv + "')";
        }

        void ColumnEdit_Enter(object sender, EventArgs e)
        {
            if (gctrm.ExGridView.GetFocusedRowCellValue("nodsg") == null)
            {
                ((ButtonEdit)sender).Enabled = true;
                return;
            }
            if (gctrm.ExGridView.GetFocusedRowCellValue("nodsg").ToString() == "")
                ((ButtonEdit)sender).Enabled = true;
            else
                ((ButtonEdit)sender).Enabled = false;
        }

        void ExGridView_New_Click(object sender, EventArgs e)
        {
            //int idx = gctrm.ExGridView.FocusedRowHandle;
            DetailBindingSource.EndEdit();

            DataRow row = casDataSet.trd.NewRow();
            row["trm"] = NoDocument;
            row["inv"] = "";
            row["remark"] = "";
            //row["no"] = DetailTable.Rows.Count + 1;
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            casDataSet.trd.Rows.Add(row);

            DB.InsertDetailRows(gctrm.ExGridView, row);
        }

        void ExGridView_Delete_Click(object sender, EventArgs e)
        {
            DB.DeleteDetailRows(gctrm.ExGridView);
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            gctrm.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gctrm.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gctrm.ExGridView.OptionsBehavior.Editable = true;
            gctrm.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            txtLhp.Enabled = false;
        }

        protected override void tsbtnCancel_Click(object sender, EventArgs e)
        {
            DB.CancelDetailRows(DetailTable);

            base.tsbtnCancel_Click(sender, new EventArgs());

            if (this.mode == Mode.View)
            {
                gctrm.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                gctrm.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                gctrm.ExGridView.OptionsBehavior.Editable = false;
                gctrm.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            }
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            DetailTable.Clear();
            gctrm.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gctrm.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gctrm.ExGridView.OptionsBehavior.Editable = true;
            gctrm.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            txtLhp.Enabled = true;
        }

        void ExGridView_ValidateRow(object sender, ValidateRowEventArgs e)
        {

        }
        private double GetAvailableStock(double qty, string inv, string nodsg)
        {
            //cek stock
            string tgla = ((DateTime)dateDate.EditValue).ToString("yyyyMMdd");
            string tglz = ((DateTime)dateDate.EditValue).AddDays(1).ToString("yyyyMMdd");
            string query = "Call SP_KartuStock(" + tgla + "," + (tglz) + ",'','','" + inv + "','" + inv + "','" + lockTextBoxEx.EditValue.ToString() + "','" + lockTextBoxEx.EditValue.ToString() + "','" + nodsg + "','" + nodsg + "')";
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

        protected override void tsbtnDelete_Click(object sender, EventArgs e)
        {
            base.tsbtnDelete_Click(sender, e);
            if (Convert.ToInt32(MasterTable.Rows[MasterBindingSource.Position]["delete"]) == 1)
                DB.sql.Execute("Call SP_Delete('TRM','" + NoDocument + "')");
        }

        void tsbtnPrint_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepTRM" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_Print('Transaction.FrmTTrm','" + this.NoDocument + "')");
            report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
            report.ShowPreview();
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidateChildren();

                if (gctrm.ExGridView.EditingValue != null)
                    gctrm.ExGridView.SetFocusedValue(gctrm.ExGridView.EditingValue);

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

                        double availableStock = GetAvailableStock(qty, inv, nodsg);
                        if (Math.Ceiling(qty) > Math.Ceiling(availableStock))
                        {
                            MessageBox.Show("Qty max " + inv + " = " + availableStock + " " + row["Unit"].ToString());
                            return;
                        }
                    }
                }

                //double totVal = 0;
                for (int i = DetailTable.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = DetailTable.Rows[i];
                    if (row != null && row.RowState != DataRowState.Deleted)
                    {
                        row[0] = NoDocument;
                        //totVal = totVal + (double)row["val"];
                    }
                }

                base.tsbtnSave_Click(sender, e);
                string date = ((DateTime)(dateDate.EditValue)).ToString("yyyyMMdd");
                string jurnal = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
                DB.sql.Execute("Call SP_Save(" + date + ",'TRM'" + ",'" + jurnal + "')");

                gctrm.ExGridView.OptionsBehavior.Editable = false;
                gctrm.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                gctrm.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                gctrm.ExToolStrip.Items["tsbtnNew"].Enabled = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void ExGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "unit" || e.Column.FieldName == "qty1")
            {
                DetailBindingSource.EndEdit();

                if (gctrm.ExGridView.GetFocusedRowCellValue("inv") != null &&
                    gctrm.ExGridView.GetFocusedRowCellValue("unit") != null &&
                    gctrm.ExGridView.GetFocusedRowCellValue("qty1") != null)
                {
                    string inv = (string)gctrm.ExGridView.GetFocusedRowCellValue("inv");
                    string unit = (string)gctrm.ExGridView.GetFocusedRowCellValue("unit");
                    double qty1 = (double)gctrm.ExGridView.GetFocusedRowCellValue("qty1");
                    if (inv != "" && unit != "")
                        gctrm.ExGridView.SetFocusedRowCellValue(gctrm.ExGridView.Columns["qty"], DB.GetQtyInBaseUom(inv, unit, qty1));
                }
            }
        }

        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gctrm.ExGridView.GetDataRow(e.RowHandle);
            row["trm"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
            //row["no"] = DetailTable.Rows.Count + 1;
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            row["qty"] = 0;
        }

        private void FrmTTrm_Load(object sender, EventArgs e)
        {
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
            Utility.SetSqlInstance(pnlDetail, DB.sql);
            txtLhp.ExSqlQuery = "Call SP_LookUpLhp('" + DB.loginPeriod + "')";
            //ctrlSub1.ReadOnly = true;
            if (MasterBindingSource.Position == MasterTable.Rows.Count)
            {
                gctrm.ExGridView.OptionsBehavior.Editable = true;
                gctrm.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                gctrm.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
                gctrm.ExToolStrip.Items["tsbtnNew"].Enabled = true;
                txtLhp.Enabled = true;
            }
        }

        private void txtLhp_EditValueChanged(object sender, EventArgs e)
        {
            if (txtLhp.Text != "")
            {
                DataTable dtLHP = DB.sql.Select("Call SP_SelectLHPforBPB('" + txtLhp.Text + "')");
                int ctr = 0;
                foreach (DataRow dr in dtLHP.Rows)
                {
                    ctr++;
                    DataRow drDetail = DetailTable.NewRow();
                    drDetail["nodsg"] = dr["No Dsg"];
                    drDetail["inv"] = dr["Kode Barang"];
                    drDetail["remark"] = dr["Nama Barang"];
                    drDetail["qty1"] = dr["Qty"];
                    drDetail["unit"] = dr["Unit"];
                    drDetail["no"] = ctr;
                    drDetail["trm"] = NoDocument;
                    drDetail["qty"] = dr["Qty Base"];
                    DetailTable.Rows.Add(drDetail);
                }
                DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
                //txtLhp.EditValue = "";
            }
        }
     
    }
}
    

