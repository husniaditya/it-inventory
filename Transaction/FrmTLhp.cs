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
using MySql.Data.MySqlClient;
using System.Globalization;
using System.Threading;

namespace CAS.Transaction
{
    public partial class FrmTLhp : CAS.Transaction.BaseTransaction
    {
        private int[] selectedIndex = new int[0];
        private DataTable copyDetailTable = new DataTable();
        MySqlDataAdapter lhcAdapter; 
        DataTable dtMor;
        
        public FrmTLhp()
        {
            InitializeComponent();
            DetailTable.Columns.Add("Unit Base", typeof(String));
            DetailTable.Columns.Add("Sales Order", typeof(String));

            MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);

            locTextBoxEx.ExSqlInstance = DB.sql;

            // grid Detail hasil produksi
            gclhp.ExGridControl.DataSource = lhdBindingSource;
            gclhp.ExGridView.OptionsView.ShowGroupPanel = false;
            gclhp.ExTitleLabel.Text = "Detail Hasil Produksi";
            gclhp.ExGridView.OptionsCustomization.AllowSort = false;

            gclhp.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
            gclhp.ExGridView.CellValueChanged += new CellValueChangedEventHandler(ExGridView_CellValueChanged);
            //gclhp.ExGridView.ValidateRow += new ValidateRowEventHandler(ExGridView_ValidateRow);            
          
            gclhp.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
            gclhp.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
            gclhp.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gclhp.ExToolStrip.Items["tsbtnNew"].Enabled = false;
 
            gclhp.ExGridView.Columns["lhp"].OptionsColumn.AllowEdit = false;
            gclhp.ExGridView.Columns["qty"].OptionsColumn.AllowEdit = false;
            //gclhp.ExGridView.Columns["nodsg"].OptionsColumn.AllowEdit = false;
            gclhp.ExGridView.Columns["inv"].OptionsColumn.AllowEdit = true;
            gclhp.ExGridView.Columns["remark"].OptionsColumn.AllowEdit = false;

            gclhp.ExGridView.Columns["no"].Visible = false;
            gclhp.ExGridView.Columns["lhp"].Visible = false;
            gclhp.ExGridView.Columns["price"].Visible = false;
            gclhp.ExGridView.Columns["val"].Visible = false;
            gclhp.ExGridView.Columns["mor"].Visible = false;
            gclhp.ExGridView.Columns["Sales Order"].Visible = false;

            gclhp.ExGridView.Columns["mor"].ColumnEdit = new GridLookUpEx(DB.sql, "CALL SP_BPPB()", "bppb", "bppb", gclhp.ExGridView, "", true, true, "bppb");
            gclhp.ExGridView.Columns["mor"].ColumnEdit.KeyPress += new KeyPressEventHandler(ExGridView_morColumnEdit_KeyPress);

            //gclhp.ExGridView.Columns["nodsg"].ColumnEdit = new GridLookUpEx(DB.sql, "Call Sp_GetStockBatch(" + DateTime.Now.ToString("yyyyMMdd") + ",'')", "", "No Batch", gclhp.ExGridView, "", true, true, "Batch");
            //gclhp.ExGridView.Columns["nodsg"].ColumnEdit.Enter += new EventHandler(DsgColumnEdit_Enter);
            gclhp.ExGridView.Columns["inv"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUpLhpp()", "", "inv", gclhp.ExGridView, "", true, true, "Inventory");
            gclhp.ExGridView.Columns["unit"].ColumnEdit = new GridLookUpUnit(gclhp.ExGridView);

            gclhp.ExGridView.Columns["qty1"].ColumnEdit = new GridNumEx();
            gclhp.ExGridView.OptionsBehavior.Editable = false;
            gclhp.ExGridView.OptionsSelection.MultiSelect = true;

            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            //tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);

            gclhp.ExGridView.Columns["mor"].Caption = "No.Ref_Central";
            gclhp.ExGridView.Columns["inv"].Caption = "Kode Barang";
            gclhp.ExGridView.Columns["remark"].Caption = "Nama Barang";
            gclhp.ExGridView.Columns["nodsg"].Caption = "No Batch";
            gclhp.ExGridView.Columns["expired"].Caption = "Expired";

            gclhp.ExGridView.Columns["nodsg"].VisibleIndex = 3;
            gclhp.ExGridView.Columns["expired"].VisibleIndex = 3;

            gclhp.ExGridView.Columns["qty"].Caption = "Qty Base";
            gclhp.ExGridView.Columns["unit"].Caption = "Unit";
            gclhp.ExGridView.Columns["qty1"].Caption = "Qty";

            gclhp.ExGridView.Columns["Unit Base"].VisibleIndex = DetailTable.Columns.IndexOf("qty") + 1;
            // gclhp.ExGridView.Columns["Sales Order"].VisibleIndex = DetailTable.Columns.IndexOf("mor");

            gclhp.ExGridView.Columns["Unit Base"].OptionsColumn.AllowEdit = false;
            //  gclhp.ExGridView.Columns["Sales Order"].OptionsColumn.AllowEdit = false;

            gclhp.ExGridView.BestFitColumns();
            tsbtnPrint.Click += new EventHandler(tsbtnPrint_Click);

            // grid BPPB

            gcbppb.ExGridControl.DataSource = lhcBindingSource;
            gcbppb.ExGridView.OptionsView.ShowGroupPanel = false;
            gcbppb.ExTitleLabel.Text = "BPPB";
            gcbppb.ExGridView.OptionsCustomization.AllowSort = false;

            gcbppb.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow_bppb);
            //gcbppb.ExGridView.CellValueChanged += new CellValueChangedEventHandler(ExGridView_CellValueChanged);
            //gcbppb.ExGridView.ValidateRow += new ValidateRowEventHandler(ExGridView_ValidateRow);            

            gcbppb.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_BPPB_Click);
            gcbppb.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_bppb_Click);
            gcbppb.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gcbppb.ExToolStrip.Items["tsbtnNew"].Enabled = false;

            gcbppb.ExGridView.Columns["no"].Visible = false;
            gcbppb.ExGridView.Columns["lhp"].Visible = false;
            gcbppb.ExGridView.Columns["jin"].OptionsColumn.AllowEdit = true;
            gcbppb.ExGridView.Columns["loc"].OptionsColumn.AllowEdit = false;
            gcbppb.ExGridView.Columns["qty"].OptionsColumn.AllowEdit = true;
            gcbppb.ExGridView.Columns["unit"].OptionsColumn.AllowEdit = false;
            gcbppb.ExGridView.Columns["nodsg"].OptionsColumn.AllowEdit = false;

            gcbppb.ExGridView.Columns["jin"].ColumnEdit = new GridLookUpEx(DB.sql, "CALL SP_BPPB()", "jin", "jin", gcbppb.ExGridView, "", true, true, "Pemakaian Bahan");
            
            gcbppb.ExGridView.OptionsBehavior.Editable = false;
            gcbppb.ExGridView.OptionsSelection.MultiSelect = true;

            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            //tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);

            gcbppb.ExGridView.Columns["jin"].Caption = "No BPPB";
            gcbppb.ExGridView.Columns["loc"].Caption = "Gudang";
            gcbppb.ExGridView.Columns["qty"].Caption = "Total Qty";
            gcbppb.ExGridView.Columns["unit"].Caption = "Unit";
            gcbppb.ExGridView.Columns["nodsg"].Caption = "No Batch";
            
            gcbppb.ExGridView.BestFitColumns();
            

            //select no SO from MO
            //select MO where period = last 2 period
            string period = "";
            int curMonth = DB.loginDate.Month;
            int prevMonth = curMonth - 1;
            int year = DB.loginDate.Year;
            if (prevMonth == 0)
            {
                prevMonth = 12;
                year = DB.loginDate.Year - 1;
                period = year.ToString().Substring(2, 2) + prevMonth.ToString("00");
            }
            else
                period = year.ToString().Substring(2, 2) + prevMonth.ToString("00");
            dtMor = DB.sql.Select("select mor, okl from mor where `delete`=0");
        }

        void tsbtnPrint_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepLhp" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_Print('Transaction.FrmTLhp','" + this.NoDocument + "')");
            report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
            report.ShowPreview();
        }

        private void PopulateLhc()
        {
            try
            {
                bool newEntry = (MasterBindingSource.Position == MasterTable.Rows.Count);
                string query = "";

                casDataSet.lhc.Clear();
                if (newEntry)
                    query = "select * from lhc where 0";
                else
                    query = "select * from lhc where lhp='" + MasterTable.Rows[MasterBindingSource.Position][0].ToString() + "'";
                lhcAdapter = DB.sql.SelectAdapter(query);
                lhcAdapter.Fill(casDataSet.lhc);
                gcbppb.ExGridView.BestFitColumns();
            }
            catch
            {

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
            inv = gclhp.ExGridView.GetFocusedRowCellValue("inv").ToString();
            if (gclhp.ExGridView.GetFocusedRowCellValue("inv") != null)
                (gclhp.ExGridView.Columns["nodsg"].ColumnEdit as GridLookUpEx).Query = "Call Sp_GetStockBatch(" + DateTime.Now.ToString("yyyyMMdd") + ",'" + inv + "')";
        }

        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
            PopulateLhc(); 
            FillOkl();
        }

        private void FillOkl()
        {
            foreach (DataRow dRow in DetailTable.Rows)
            {
                DataRow[] drMor = dtMor.Select("mor='" + dRow["mor"].ToString() + "'");
                if (drMor.Length > 0)
                {
                    dRow["Sales Order"] = drMor[0]["okl"].ToString();
                }
            }
            gclhp.ExGridView.BestFitColumns();
        }

        void ExGridView_New_Click(object sender, EventArgs e)
        {
            DataRow row = casDataSet.lhd.NewRow();
            row["lhp"] = NoDocument;
            row["inv"] = "";
            row["remark"] = "";
            //row["no"] = DetailTable.Rows.Count + 1;
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            casDataSet.lhd.Rows.Add(row);

            DB.InsertDetailRows(gclhp.ExGridView, row);
        }

        void ExGridView_New_bppb_Click(object sender, EventArgs e)
        {
            DataRow row = casDataSet.lhc.NewRow();
            row["lhp"] = NoDocument;
            row["jin"] = "";
            row["loc"] = "";
            row["qty"] = 0;
            row["unit"] = "";
            row["no"] = DB.GetRowCount(casDataSet.lhc) + 1;
            casDataSet.lhc.Rows.Add(row);

            DB.InsertDetailRows(gcbppb.ExGridView, row);
        }

        void ExGridView_Delete_Click(object sender, EventArgs e)
        {
            DB.DeleteDetailRows(gclhp.ExGridView);
        }

        void ExGridView_Delete_BPPB_Click(object sender, EventArgs e)
        {
            DB.DeleteDetailRows(gcbppb.ExGridView);
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            gclhp.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gclhp.ExToolStrip.Items["tsbtnNew"].Enabled = false;
            gclhp.ExGridView.OptionsBehavior.Editable = true;
            gclhp.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            
            
            // new row grid bppb
            gcbppb.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcbppb.ExToolStrip.Items["tsbtnNew"].Enabled = false;
            gcbppb.ExGridView.OptionsBehavior.Editable = true;
            gcbppb.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            //copyDetailTable.Clear();
            //copyDetailTable = DetailTable.Copy();

            copyDetailTable.Clear();
            copyDetailTable = DetailTable.Copy();
        }

        protected override void tsbtnCancel_Click(object sender, EventArgs e)
        {
            DB.CancelDetailRows(DetailTable);

            base.tsbtnCancel_Click(sender, new EventArgs());

            if (this.mode == Mode.View)
            {
                // cancel grid bppb
                gcbppb.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                gcbppb.ExToolStrip.Items["tsbtnNew"].Enabled = false;

  
                gcbppb.ExGridView.OptionsBehavior.Editable = false;
                gcbppb.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;

                PopulateLhc(); 
                FillOkl();
            }
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            DetailTable.Clear();
            plantComboBox.Text = "PLANT 1";
            gclhp.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gclhp.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gclhp.ExGridView.OptionsBehavior.Editable = true;
            gclhp.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            //nambah row baru pd grid bppb
            gcbppb.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcbppb.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcbppb.ExGridView.OptionsBehavior.Editable = true;
            gcbppb.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
        }

        protected override void tsbtnDelete_Click(object sender, EventArgs e)
        {
            base.tsbtnDelete_Click(sender, e);
            if (Convert.ToInt32(MasterTable.Rows[MasterBindingSource.Position]["delete"]) == 1)
                DB.sql.Execute("Call SP_Delete('LHP','" + NoDocument + "')");
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidateChildren();
                lhcBindingSource.EndEdit();


                DataTable dtChanged;
                dtChanged = casDataSet.lhc.GetChanges();

                if (casDataSet.lhc.GetChanges() != null)
                    lhcAdapter.Update(casDataSet.lhc);

                if (gclhp.ExGridView.EditingValue != null)
                    gclhp.ExGridView.SetFocusedValue(gclhp.ExGridView.EditingValue);

                DetailBindingSource.EndEdit();

                if (locTextBoxEx.Text == "" || !locTextBoxEx.ExIsValid())
                    throw new Exception("Please entry valid Loc");

                //for (int i = 0; i < gclhp.ExGridView.RowCount; i++)
                //{
                //    if (gclhp.ExGridView.GetDataRow(i) != null)
                //        if (gclhp.ExGridView.GetDataRow(i).RowState != DataRowState.Deleted)
                //        {
                //            ExGridView_ValidateRow(sender, new ValidateRowEventArgs(i, gclhp.ExGridView.GetRow(i)));
                //            if (!isDetailValid)
                //            {
                //                MessageBox.Show("Invalid Kode Barang. Please correct the value");
                //                return;
                //            }
                //        }
                //}


                //double totVal = 0;
                for (int i = DetailTable.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = DetailTable.Rows[i];
                    if (row != null && row.RowState != DataRowState.Deleted)
                    {
                        row[0] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
                        //totVal = totVal + (double)row["val"];
                    }

                    DetailBindingSource.EndEdit();
                    string inv = (string)gclhp.ExGridView.GetFocusedRowCellValue("inv");
                    string unit1 = (string)gclhp.ExGridView.GetFocusedRowCellValue("unit");
                    double qty1 = (double)gclhp.ExGridView.GetFocusedRowCellValue("qty1");
                    if (inv != "" && unit1 != "")
                        gclhp.ExGridView.SetFocusedRowCellValue(gclhp.ExGridView.Columns["qty"], DB.GetQtyInBaseUom(inv, unit1, qty1));

                }

                base.tsbtnSave_Click(sender, e);

                string date = ((DateTime)(dateDate.EditValue)).ToString("yyyyMMdd");
                string jurnal = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
                DB.sql.Execute("Call SP_Save(" + date + ",'LHP'" + ",'" + jurnal + "')");

                gclhp.ExGridView.OptionsBehavior.Editable = false;
                gclhp.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                gclhp.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                gclhp.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                gcbppb.ExGridView.OptionsBehavior.Editable = false;
                gcbppb.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                gcbppb.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                gcbppb.ExToolStrip.Items["tsbtnNew"].Enabled = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void ExGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            /*
                  if (e.Column.FieldName == "inv")
                  {
                      DetailBindingSource.EndEdit();
                      DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base Dikirim");
                      return;
                  }
             */
            if (e.Column.FieldName == "unit" || e.Column.FieldName == "qty1")
            {
                DetailBindingSource.EndEdit();
                string inv = (string)gclhp.ExGridView.GetFocusedRowCellValue("inv");
                string unit = (string)gclhp.ExGridView.GetFocusedRowCellValue("unit");
                double qty1 = (double)gclhp.ExGridView.GetFocusedRowCellValue("qty1");
                int no = Convert.ToInt32(gclhp.ExGridView.GetFocusedRowCellValue("no"));
                string mor = gclhp.ExGridView.GetFocusedRowCellValue("mor").ToString();
                string nodsg = gclhp.ExGridView.GetFocusedRowCellValue("nodsg").ToString();

                double qty = 0;
                if (inv != "" && unit != "")
                {
                    qty = DB.GetQtyInBaseUom(inv, unit, qty1);
                    gclhp.ExGridView.SetFocusedRowCellValue(gclhp.ExGridView.Columns["qty"], qty);
                }

                //if (qty1 > 0 && unit != "")
                //{
                //    double maxQty = Math.Floor(GetMaxValueQtyMO(unit));
                //    //get current qty if mode edit, add maxQty with currQty
                //    if (this.mode == Mode.Edit)
                //    {
                //        try
                //        {
                //            DataRow drCopyDetailTable;
                //            drCopyDetailTable = copyDetailTable.Select("no=" + no.ToString() + " and mor='" + mor + "' and nodsg='" + nodsg + "'")[0];
                //            maxQty = maxQty + Convert.ToDouble(drCopyDetailTable["qty1"]); ;
                //        }
                //        catch { }
                //    }
                //    if (qty1 > maxQty)
                //    {
                //        MessageBox.Show("Qty melebihi batas toleransi SO. Max qty LHP: " + maxQty.ToString() + " " + unit);
                //        gclhp.ExGridView.SetFocusedRowCellValue(gclhp.ExGridView.Columns["qty1"], maxQty);
                //    }
                //}
            }
        }

        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gclhp.ExGridView.GetDataRow(e.RowHandle);
            row["lhp"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
            //row["no"] = DetailTable.Rows.Count + 1;
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            row["val"] = 0;
            row["qty1"] = 0;
            row["qty"] = 0;
        }

        void ExGridView_InitNewRow_bppb(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gcbppb.ExGridView.GetDataRow(e.RowHandle);
            row["lhp"] = NoDocument;
            row["jin"] = "";
            row["no"] = DB.GetRowCount(casDataSet.lhc) + 1;
            row["loc"] = "";
            row["qty"] = 0;
            row["unit"] = "";
        }
 
        private void FrmTLhp_Load(object sender, EventArgs e)
        {
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");

            DataTable dtPlant;
            dtPlant = DB.sql.Select("select * from plant");
            for (int i = 0; i < dtPlant.Rows.Count; i++)
            {
                plantComboBox.Items.Add(dtPlant.Rows[i][1].ToString());
            }
    
            Utility.SetSqlInstance(pnlDetail, DB.sql);
            //ctrlSub1.ReadOnly = true;
            if (MasterBindingSource.Position == MasterTable.Rows.Count)
            {
                gclhp.ExGridView.OptionsBehavior.Editable = true;
                gclhp.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                gclhp.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
                gclhp.ExToolStrip.Items["tsbtnNew"].Enabled = true;

                //nambah row baru pd grid bppb
                gcbppb.ExGridView.OptionsBehavior.Editable = true;
                gcbppb.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                gcbppb.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
                gcbppb.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            }
            PopulateLhc();
            FillOkl();
        }

        private double GetMaxValueQtyMO(string unit)
        {
            double maxValue = 0;

            string mor = gclhp.ExGridView.GetFocusedRowCellValue("mor").ToString();
            string okl = gclhp.ExGridView.GetFocusedRowCellValue("Sales Order").ToString();
            string inv = gclhp.ExGridView.GetFocusedRowCellValue("inv").ToString();
            string nodsg = gclhp.ExGridView.GetFocusedRowCellValue("nodsg").ToString();
            string baseUnit = gclhp.ExGridView.GetFocusedRowCellValue("Unit Base").ToString();

            try
            {
                DataTable dtOutMor;
                dtOutMor = DB.sql.Select("Call SP_OutLhp('" + mor + "')");
                DataRow[] drSelect = dtOutMor.Select("`MO`='" + mor + "'");
                if (drSelect.Length > 0)
                {
                    double qtySisa = Convert.ToDouble(drSelect[0]["Qty"]);
                    //double qtyToleransi = Convert.ToDouble(drSelect[0]["QtyToleransi"]);
                    //maxValue = qtySisa + qtyToleransi;
                    maxValue = qtySisa;
                }
            }
            catch (Exception ex)
            {
                //do nothing
                MessageBox.Show(ex.Message);
            }

            return DB.GetQtyInAlternativeUom(inv,unit,maxValue);
        }

        private void pnlDetail_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ExGridView_morColumnEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(0);
        }
    }
}
