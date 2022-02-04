using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KASLibrary;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using MySql.Data.MySqlClient;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace CAS.Transaction
{
    public partial class FrmTKlrImport : BaseTransaction
    {
        public FrmTKlrImport()
        {
            InitializeComponent();

            //customize button print
            ToolStripMenuItem tsmiPreviewInv = new ToolStripMenuItem("Preview Invoice", null, new EventHandler(tsmiPreviewInv_Click));
            ToolStripMenuItem tsmiPrintInv = new ToolStripMenuItem("Print Invoice", null, new EventHandler(tsmiPrintInv_Click));
            ToolStripSeparator tsSeparator1 = new ToolStripSeparator();
            ToolStripMenuItem tsmiPreviewPL = new ToolStripMenuItem("Preview Packing List", null, new EventHandler(tsmiPreviewPL_Click));
            ToolStripMenuItem tsmiPrintPL = new ToolStripMenuItem("Print Packing List", null, new EventHandler(tsmiPrintPL_Click));
            ToolStripDropDownButton tsbtnPrint = new ToolStripDropDownButton("Print", null, tsmiPreviewInv, tsmiPrintInv, tsSeparator1, tsmiPreviewPL, tsmiPrintPL);
            tsbtnPrint.Image = MasterNavigator.Items["tsbtnPrint"].Image;
            MasterNavigator.Items.Insert(MasterNavigator.Items.IndexOfKey("tsbtnPrint"), tsbtnPrint);
            MasterNavigator.Items.RemoveByKey("tsbtnPrint");

            gckon.ExGridControl.DataSource = klridBindingSource;

            gckon.ExGridView.OptionsView.ShowGroupPanel = false;
            gckon.ExTitleLabel.Text = "Detail Invoice";
            gckon.ExGridView.OptionsCustomization.AllowSort = false;

            gckon.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
            gckon.ExGridView.CellValueChanged += new CellValueChangedEventHandler(ExGridView_CellValueChanged);


            gckon.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
            gckon.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
            gckon.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gckon.ExToolStrip.Items["tsbtnNew"].Enabled = false;

            gckon.ExGridView.Columns["klri"].OptionsColumn.AllowEdit = false;
            gckon.ExGridView.Columns["inv"].OptionsColumn.AllowEdit = true;
            gckon.ExGridView.Columns["val"].OptionsColumn.AllowEdit = false;
            gckon.ExGridView.Columns["remark"].OptionsColumn.AllowEdit = true;
            gckon.ExGridView.Columns["no"].Visible = false;
            gckon.ExGridView.Columns["klri"].Visible = false;
            gckon.ExGridView.Columns["inv"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('inv')", "", "inv", gckon.ExGridView, "", true, true, "Inventory");
            gckon.ExGridView.Columns["unit"].ColumnEdit = new GridLookUpUnit(gckon.ExGridView);

            gckon.ExGridView.Columns["price"].ColumnEdit = new GridNumEx(500);
            gckon.ExGridView.Columns["grossweight"].ColumnEdit = new GridNumEx(500);
            gckon.ExGridView.Columns["netweight"].ColumnEdit = new GridNumEx(500);
            gckon.ExGridView.Columns["val"].ColumnEdit = new GridNumEx(2000);

            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);

            gckon.ExGridView.Columns["inv"].Caption = "Kode Barang";
            gckon.ExGridView.Columns["remark"].Caption = "Nama Barang";
            gckon.ExGridView.Columns["qty"].Caption = "Quantity";
            gckon.ExGridView.Columns["unit"].Caption = "Unit";
            gckon.ExGridView.Columns["price"].Caption = "Harga";
            gckon.ExGridView.Columns["val"].Caption = "Total";
            gckon.ExGridView.Columns["grossweight"].Caption = "Gross Weight";
            gckon.ExGridView.Columns["netweight"].Caption = "Net Weight";

            gckon.ExGridView.BestFitColumns();
            gckon.ExGridView.Columns["val"].Width = 100;
            gckon.ExGridView.Columns["remark"].Width = 300;
            gckon.ExGridView.OptionsBehavior.Editable = false;
            gckon.ExGridView.OptionsSelection.MultiSelect = true;
            gckon.ExGridView.OptionsCustomization.AllowSort = false;
            DB.SetNumberFormat(gckon.ExGridView, "n2");
        }


        void ExGridView_Delete_Click(object sender, EventArgs e)
        {
            DB.DeleteDetailRows(gckon.ExGridView);
        }

        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gckon.ExGridView.GetDataRow(e.RowHandle);
            row["klri"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
            //row["no"] = DetailTable.Rows.Count + 1;
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            row["price"] = 0;
            row["qty"] = 0;
            row["grossweight"] = 0;
            row["netweight"] = 0;
            //row["kurs"] = 1;

        }

        void ExGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "price" || e.Column.FieldName == "qty")
            {
                double price = (double)gckon.ExGridView.GetFocusedRowCellValue("price");
                double qty = (double)gckon.ExGridView.GetFocusedRowCellValue("qty");
                double val = price * qty;
                gckon.ExGridView.SetFocusedRowCellValue(gckon.ExGridView.Columns["val"], val);
            }
            ReCalculateTotal();
        }

        void ExGridView_New_Click(object sender, EventArgs e)
        {
            DataRow row = casDataSet.pnd.NewRow();
            row["klri"] = NoDocument;
            row["inv"] = "";
            row["remark"] = "";
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            casDataSet.pnd.Rows.Add(row);

            DB.InsertDetailRows(gckon.ExGridView, row);
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            DetailTable.Clear();
            gckon.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gckon.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gckon.ExGridView.OptionsBehavior.Editable = true;
            gckon.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            Utility.SetReadOnly(txtSubtotal, true);
          
            Utility.SetReadOnly(txtTotal, true);
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            gckon.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gckon.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gckon.ExGridView.OptionsBehavior.Editable = true;
            gckon.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            Utility.SetReadOnly(txtSubtotal, true);
          
            Utility.SetReadOnly(txtTotal, true);
        }

        private void FrmTKlrImport_Load(object sender, EventArgs e)
        {
            Utility.SetSqlInstance(pnlDetail, DB.sql);

            ctrlSub.txtSub.DataBindings.Add("EditValue", klriBindingSource, "sub");
            Utility.SetNumberFormat(pnlTotal, "n2");
            if (this.mode == Mode.View)
                 freightSpinEdit.EditValue = (double)MasterTable.Rows[0]["freight"];

            //ReCalculateTotal();

        }


        void ReCalculateTotal()
        {
            
            DetailBindingSource.EndEdit();

            double subTotal = 0;
            double freight = 0;

            if (pnvTextBoxEx.Text != "")
            {
                DataTable dtpnv = DB.sql.Select("select pnv.*,shp.noso,shp.refno,'Indonesia' as country,shp.port,shp.feeder,shp.vessel from pnv left outer join shp on pnv.pnv=shp.pnv where pnv.pnv='" + pnvTextBoxEx.Text + "' limit 1");
                subTotal = (double)dtpnv.Rows[0]["feepackaging"];

                string jenisdok = pnvTextBoxEx.Text.Substring(0, 3);

                if (pnvTextBoxEx.Text == "" || !pnvTextBoxEx.ExIsValid())
                    return;

                if (jenisdok == "PEB")
                {
                    for (int i = 0; i < DetailTable.Rows.Count; i++)
                    {
                        if (DetailTable.Rows[i] != null && DetailTable.Rows[i].RowState != DataRowState.Deleted)
                        {
                            subTotal = subTotal + (double)DetailTable.Rows[i]["val"];
                        }
                    }
                }
            }
            //for (int i = 0; i < DetailTable.Rows.Count; i++)
            //{
            //    if (DetailTable.Rows[i] != null && DetailTable.Rows[i].RowState != DataRowState.Deleted)
            //    {
            //        subTotal = subTotal + (double)DetailTable.Rows[i]["val"];
            //    }
            //}

            //if(pnvTextBoxEx.Text != ""){
            //    DataTable dtpnv = DB.sql.Select("select pnv.*,shp.noso,shp.refno,'Indonesia' as country,shp.port,shp.feeder,shp.vessel from pnv left outer join shp on pnv.pnv=shp.pnv where pnv.pnv='" + pnvTextBoxEx.Text + "' limit 1");
            //    subTotal = (double)dtpnv.Rows[0]["feepackaging"];
            //}

            txtSubtotal.EditValue = subTotal;
            //subTotal = (double)txtSubtotal.EditValue;
            freight = (double)freightSpinEdit.Value;

            double total = subTotal + freight;
            txtTotal.EditValue = total;
        }


        private void discSpinEdit_EditValueChanged(object sender, EventArgs e)
        {
            ReCalculateTotal();
        }

        private void pnlDetail_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ppnCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ReCalculateTotal();
        }

        private void btnDocFlow_Click(object sender, EventArgs e)
        {

        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate controls
                this.ValidateChildren();

                DetailBindingSource.EndEdit();

                for (int i = DetailTable.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = DetailTable.Rows[i];
                    if (row != null && row.RowState != DataRowState.Deleted)
                    {
                        row[0] = NoDocument;
                        row["no"] = i + 1;
                    }
                }

                ((DataRowView)MasterBindingSource.Current).Row["freight"] = freightSpinEdit.Value;

                base.tsbtnSave_Click(sender, e);
                if (this.mode == Mode.View)
                {
                    gckon.ExGridView.OptionsBehavior.Editable = false;
                    gckon.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                    gckon.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                    gckon.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                }

                string date = ((DateTime)(dateDate.EditValue)).ToString("yyyyMMdd");
                DB.sql.Execute("Call SP_Save(" + date + ",'KLE'" + ",'" + NoDocument + "')");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ReCalculateTotal();
        }

        protected override void tsbtnCancel_Click(object sender, EventArgs e)
        {
            base.tsbtnCancel_Click(sender, e);
            if (this.mode == Mode.View)
            {
                SetDetailEditable(false);
            }
            //ctrlSub.ReadOnly = true;
        }

        void SetDetailEditable(bool mode)
        {
            gckon.ExToolStrip.Items["tsbtnDelete"].Enabled = mode;
            gckon.ExToolStrip.Items["tsbtnNew"].Enabled = mode;
           
        }
        private void pnvTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {
            if (this.mode != Mode.View && this.pnvTextBoxEx.Text != "")
            {
                double feepack = 0;
                ctrlSub.txtSub.EditValue = pnvTextBoxEx.ExGetDataRow()["Kode"].ToString();
                notifyMemoEdit.EditValue = pnvTextBoxEx.ExGetDataRow()["Notify"];
                DataTable dtpnv = DB.sql.Select("select pnv.*,shp.noso,shp.refno,'Indonesia' as country,shp.port,shp.feeder,shp.vessel from pnv left outer join shp on pnv.pnv=shp.pnv where pnv.pnv='" + pnvTextBoxEx.Text + "' limit 1");
               // DataTable dtpnv = DB.sql.Select("select * from pnv where pnv='" + pnvTextBoxEx.Text + "'");
              //  DataRow drpnv = dtpnv.Rows[0];
               // notifyMemoEdit.EditValue = dtpnv.Rows[0]["notify"].ToString();
                ShippingMemoEdit.EditValue = dtpnv.Rows[0]["shipingmark"].ToString();
                bankMemoEdit.EditValue = dtpnv.Rows[0]["bank"].ToString(); 
                addnoteMemoEdit.EditValue = dtpnv.Rows[0]["other"].ToString();
                yourrefTextEdit.EditValue = dtpnv.Rows[0]["ponum"];
                ourrefTextEdit.EditValue = dtpnv.Rows[0]["noso"];
                coriginTextEdit.EditValue = dtpnv.Rows[0]["country"];
                pdischargeTextEdit.EditValue = dtpnv.Rows[0]["port"];
                feederTextEdit.EditValue = dtpnv.Rows[0]["feeder"];
                motherTextEdit.EditValue = dtpnv.Rows[0]["vessel"];
                incotermTextEdit.EditValue = dtpnv.Rows[0]["incoterm"];
                paymentTextEdit.EditValue = dtpnv.Rows[0]["payment"];
                curcur.EditValue = dtpnv.Rows[0]["cur"];
                noconTextEdit.EditValue = dtpnv.Rows[0]["nocon"];
                freightSpinEdit.EditValue = dtpnv.Rows[0]["freight"];

                feepack = (double)dtpnv.Rows[0]["feepackaging"];

                if (feepack > 0)
                {
                    txtSubtotal.EditValue = dtpnv.Rows[0]["feepackaging"];
                    txtTotal.EditValue = dtpnv.Rows[0]["feepackaging"];
                }
                
                 int tNo = 999;
                 foreach (DataRow dr in DetailTable.Rows)
                 {
                     dr["no"] = tNo;
                     dr.Delete();
                     tNo++;
                 }

                DataTable dtpnd = DB.sql.Select("select * from pnd where pnv='" + pnvTextBoxEx.Text + "'");
                int no = 1;
                foreach (DataRow drpnd in dtpnd.Rows)
                {
                    DataRow drklrid = DetailTable.NewRow();
                    drklrid["klri"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
                    drklrid["no"] = no;
                    drklrid["inv"] = drpnd["inv"];
                    drklrid["remark"] = drpnd["remark"];
                    drklrid["qty"] = drpnd["qty"];
                    drklrid["unit"] = drpnd["unit"];
                    drklrid["price"] = drpnd["price"];
                    drklrid["val"] = drpnd["val"];
                    DetailTable.Rows.Add(drklrid);
                    no++;
                }
                gckon.ExGridControl.DataSource = DetailTable;
                gckon.ExGridView.Columns["inv"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('inv')", "", "inv", gckon.ExGridView, "", true, true, "Inventory");
                gckon.ExGridView.Columns["unit"].ColumnEdit = new GridLookUpUnit(gckon.ExGridView);
                gckon.ExGridView.Columns["inv"].Caption = "Kode Barang";
                gckon.ExGridView.Columns["remark"].Caption = "Nama Barang";
                gckon.ExGridView.Columns["qty"].Caption = "Quantity";
                gckon.ExGridView.Columns["unit"].Caption = "Unit";
                gckon.ExGridView.Columns["price"].Caption = "Price";
                gckon.ExGridView.Columns["val"].Caption = "Value";
                gckon.ExGridView.Columns["netweight"].Caption = "Net Weight";
                gckon.ExGridView.Columns["grossweight"].Caption = "Gross Weight";
                gckon.ExGridView.BestFitColumns();
                gckon.ExGridView.Columns["remark"].Width = 300;
                gckon.ExGridView.OptionsSelection.MultiSelect = true;
                gckon.ExGridView.OptionsCustomization.AllowSort = false;
                DB.SetNumberFormat(gckon.ExGridView, "n2");
                gckon.ExGridView.OptionsBehavior.Editable = true;
                gckon.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                gckon.ExGridView.Columns["no"].Visible = false;
                gckon.ExGridView.Columns["klri"].Visible = false;

            }
                       ReCalculateTotal();
        }

        private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
        {

        }


        void tsmiPrintInv_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepInvoiceImport" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_Print('Transaction.FrmTKlrImport','" + this.NoDocument + "')");
            report.Print();
            
        }

        void tsmiPreviewInv_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepInvoiceImport" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_Print('Transaction.FrmTKlrImport','" + this.NoDocument + "')");
            report.ShowPreview();
        }

        void tsmiPrintPL_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepPackingList" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_Print('Transaction.FrmTKlrImport','" + this.NoDocument + "')");
            report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
         
            report.Print();
            
        }

        void tsmiPreviewPL_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepPackingList" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_Print('Transaction.FrmTKlrImport','" + this.NoDocument + "')");
            report.Bands[BandKind.PageFooter].Controls["lbluser"].Text = DB.casUser.Name;
         
            report.ShowPreview();
        }

        private void freightSpinEdit_EditValueChanged(object sender, EventArgs e)
        {
            ReCalculateTotal();
        }
    }
}

