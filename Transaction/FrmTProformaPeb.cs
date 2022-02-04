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
using System.Threading;
using System.Globalization;

namespace CAS.Transaction
{
    public partial class FrmTProformaPeb : BaseTransaction
    {
        public FrmTProformaPeb()
        {
            InitializeComponent();
            ToolStripMenuItem tsmiPrintPreviewInv = new ToolStripMenuItem("Print Preview Invoice", null, new EventHandler(tsmiPrintPreviewInv_Click));
            ToolStripMenuItem tsmiPrintPreviewPL = new ToolStripMenuItem("Print Preview Packing List", null, new EventHandler(tsmiPrintPreviewPL_Click));
            ToolStripDropDownButton tsbtnPrint = new ToolStripDropDownButton("Print", null, tsmiPrintPreviewInv, tsmiPrintPreviewPL);
            tsbtnPrint.Image = MasterNavigator.Items["tsbtnPrint"].Image;
            MasterNavigator.Items.Insert(MasterNavigator.Items.IndexOfKey("tsbtnPrint"), tsbtnPrint);
            MasterNavigator.Items.RemoveByKey("tsbtnPrint");

            gckon.ExGridControl.DataSource = pndBindingSource;

            gckon.ExGridView.OptionsView.ShowGroupPanel = false;
            gckon.ExTitleLabel.Text = "Detail Invoice / Packing List EMKL";
            gckon.ExGridView.OptionsCustomization.AllowSort = false;

            gckon.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
            gckon.ExGridView.CellValueChanged += new CellValueChangedEventHandler(ExGridView_CellValueChanged);


            gckon.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
            gckon.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
            gckon.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gckon.ExToolStrip.Items["tsbtnNew"].Enabled = false;

            gckon.ExGridView.Columns["pnv"].OptionsColumn.AllowEdit = false;
            gckon.ExGridView.Columns["inv"].OptionsColumn.AllowEdit = true;
            //gckon.ExGridView.Columns["val"].OptionsColumn.AllowEdit = false;
            //gckon.ExGridView.Columns["gross"].OptionsColumn.AllowEdit = false;
            gckon.ExGridView.Columns["remark"].OptionsColumn.AllowEdit = true;
            gckon.ExGridView.Columns["no"].Visible = false;
            gckon.ExGridView.Columns["pnv"].Visible = false;
            gckon.ExGridView.Columns["konv"].Visible = false;
            gckon.ExGridView.Columns["process"].Visible = false;
            gckon.ExGridView.Columns["packaging"].Visible = false;
            gckon.ExGridView.Columns["kode"].Visible = false;
            gckon.ExGridView.Columns["inv"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('inv')", "", "inv", gckon.ExGridView, "", true, true, "Inventory");
            gckon.ExGridView.Columns["inv"].ColumnEdit.Enter += new EventHandler(ExGridView_InvColumnEdit_Enter);
            gckon.ExGridView.Columns["unit"].ColumnEdit = new GridLookUpUnit(gckon.ExGridView);

            gckon.ExGridView.Columns["price"].ColumnEdit = new GridNumEx(500);
            gckon.ExGridView.Columns["val"].ColumnEdit = new GridNumEx(2000);

            gckon.ExGridView.Columns["net"].ColumnEdit = new GridNumEx(500);
            //gckon.ExGridView.Columns["konv"].ColumnEdit = new GridNumEx(500);
            gckon.ExGridView.Columns["gross"].ColumnEdit = new GridNumEx(500);

            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);

            gckon.ExGridView.Columns["inv"].Caption = "Kode Barang";
            gckon.ExGridView.Columns["remark"].Caption = "Nama Barang";
            gckon.ExGridView.Columns["qty"].Caption = "Quantity";
            gckon.ExGridView.Columns["unit"].Caption = "Unit";
            gckon.ExGridView.Columns["price"].Caption = "Harga";
            gckon.ExGridView.Columns["val"].Caption = "Total";
            gckon.ExGridView.Columns["net"].Caption = "Net Weight";
            //gckon.ExGridView.Columns["konv"].Caption = "Konversi";
            gckon.ExGridView.Columns["gross"].Caption = "Gross Weight";
            gckon.ExGridView.Columns["process"].Caption = "Process";
            gckon.ExGridView.Columns["packaging"].Caption = "Packaging";
            gckon.ExGridView.Columns["spesifikasi"].Caption = "Spesifikasi";

            gckon.ExGridView.Columns["inv"].VisibleIndex = 0;
            gckon.ExGridView.Columns["remark"].VisibleIndex = 1;
            gckon.ExGridView.Columns["spesifikasi"].Visible = false;
            gckon.ExGridView.Columns["qty"].VisibleIndex = 3;
            gckon.ExGridView.Columns["unit"].VisibleIndex = 4;
            gckon.ExGridView.Columns["net"].VisibleIndex = 5;
            //gckon.ExGridView.Columns["konv"].VisibleIndex = 5;
            gckon.ExGridView.Columns["gross"].VisibleIndex = 6;
            gckon.ExGridView.Columns["price"].VisibleIndex = 7;
            gckon.ExGridView.Columns["process"].VisibleIndex = 8;
            gckon.ExGridView.Columns["packaging"].VisibleIndex = 9;
            gckon.ExGridView.Columns["val"].VisibleIndex = 10;

            gckon.ExGridView.BestFitColumns();
            gckon.ExGridView.Columns["val"].Width = 100;
            gckon.ExGridView.Columns["price"].Width = 100;
            gckon.ExGridView.Columns["net"].Width = 100;
            //gckon.ExGridView.Columns["konv"].Width = 100;
            gckon.ExGridView.Columns["gross"].Width = 100;
            gckon.ExGridView.Columns["qty"].Width = 100;
            gckon.ExGridView.Columns["unit"].Width = 100;
            gckon.ExGridView.Columns["process"].Width = 100;
            gckon.ExGridView.Columns["packaging"].Width = 100;
            gckon.ExGridView.Columns["remark"].Width = 300;
            gckon.ExGridView.Columns["spesifikasi"].Width = 300;
            gckon.ExGridView.OptionsBehavior.Editable = false;
            gckon.ExGridView.OptionsSelection.MultiSelect = true;
            gckon.ExGridView.OptionsCustomization.AllowSort = false;
            DB.SetNumberFormat(gckon.ExGridView, "n3");
        }


        void ExGridView_Delete_Click(object sender, EventArgs e)
        {
            DB.DeleteDetailRows(gckon.ExGridView);
        }

        void ExGridView_InvColumnEdit_Enter(object sender, EventArgs e)
        {
            GridLookUpEx invLookUp = (GridLookUpEx)gckon.ExGridView.Columns["inv"].ColumnEdit;
            invLookUp.Query = "Call SP_LookUp('invpl')";
            invLookUp.TableName = "inv";

        }

        private void omsTextBoxEx_Enter(object sender, EventArgs e)
        {
            SetomsTextBoxExQuery();
        }

        void SetomsTextBoxExQuery()
        {
            omsTextBoxEx.ExSqlQuery = "SELECT okl.okl,date(okl.date) AS `Tgl SO`,okl.sub,sub.name,okl.cur,okl.kurs,okl.ppn,okl.delivery_from AS podate,okl.nopoc AS ponum FROM okl,sub WHERE okl.sub = sub.sub AND okl.`close` = 0 AND okl.`delete` = 0 AND okl.aprov = 1 and okl.date<=" + ((DateTime)dateDate.EditValue).AddDays(1).ToString("yyyyMMdd") + " order by okl.okl desc";
            omsTextBoxEx.ExFieldName = "okl";
        }

        private void omsTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {
            if (omsTextBoxEx.Text == "" || !omsTextBoxEx.ExIsValid())
                return;

            ctrlSub.txtSub.EditValue = omsTextBoxEx.ExGetDataRow()["sub"].ToString();
            curcur.EditValue = omsTextBoxEx.ExGetDataRow()["cur"].ToString();
            curkurs.EditValue = omsTextBoxEx.ExGetDataRow()["kurs"].ToString();
            double ppn = Convert.ToDouble(omsTextBoxEx.ExGetDataRow()["ppn"]);
            if (ppn == 1)
                ppnCheckBox.Checked = true;
            else
                ppnCheckBox.Checked = false;
            podateDateEdit.EditValue = omsTextBoxEx.ExGetDataRow()["podate"].ToString();
            ponumTextEdit.EditValue = omsTextBoxEx.ExGetDataRow()["ponum"].ToString();

            GridLookUpEx invLookUp = gckon.ExGridView.Columns["inv"].ColumnEdit as GridLookUpEx;

            invLookUp.Query = "call sp_outoklglobal('" + omsTextBoxEx.Text + "')";
            invLookUp.TableName = "okl";

            if (MasterBindingSource.Position == MasterTable.Rows.Count || this.mode == Mode.Edit)
            {
                DetailTable.Clear();
                invLookUp.ClickButton();
            }

        }

        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gckon.ExGridView.GetDataRow(e.RowHandle);
            row["pnv"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
            //row["no"] = DetailTable.Rows.Count + 1;
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            row["price"] = 0;
            row["qty"] = 0;
            row["net"] = 0;
            row["konv"] = 0;
            row["gross"] = 0;
            row["process"] = 0;
            row["packaging"] = 0;
        }

        void ExGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "val" || e.Column.FieldName == "qty" || e.Column.FieldName == "process" || e.Column.FieldName == "packaging")
            {
                double val = (double)gckon.ExGridView.GetFocusedRowCellValue("val");
                double qty = (double)gckon.ExGridView.GetFocusedRowCellValue("qty");
                double process = (double)gckon.ExGridView.GetFocusedRowCellValue("process");
                double packaging = (double)gckon.ExGridView.GetFocusedRowCellValue("packaging");
                double val1 = val / qty;
                double price = process + packaging + val1;
                gckon.ExGridView.SetFocusedRowCellValue(gckon.ExGridView.Columns["price"], price);
            }
            ReCalculateTotal();
        }

        void ExGridView_New_Click(object sender, EventArgs e)
        {
            DataRow row = casDataSet.pnd.NewRow();
            row["pnv"] = NoDocument;
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

        private void FrmTProformaPeb_Load(object sender, EventArgs e)
        {

            Utility.SetSqlInstance(pnlDetail, DB.sql);

            ctrlSub.txtSub.DataBindings.Add("EditValue", pnvBindingSource, "sub");
            //freightSpinEdit.DataBindings.Add("EditValue", pnvBindingSource, "freight");
            //feePackEdit.DataBindings.Add("EditValue", pnvBindingSource, "feepackaging");

            Utility.SetNumberFormat(pnlTotal, "n2");
            //Utility.SetNumberFormat(txtTotal, "n2");
            //Utility.SetNumberFormat(txtPPN, "n2");
            ReCalculateTotal();

        }


        void ReCalculateTotal()
        {
            DetailBindingSource.EndEdit();

            double subTotal = 0;
            for (int i = 0; i < DetailTable.Rows.Count; i++)
            {
                if (DetailTable.Rows[i] != null && DetailTable.Rows[i].RowState != DataRowState.Deleted)
                {
                    subTotal = subTotal + (double)DetailTable.Rows[i]["val"];
                }
            }
            txtSubtotal.EditValue = subTotal;

            double ppn = 0;
            if (ppnCheckBox.Checked)
                ppn = (subTotal) * 0.1;
            txtPPN.EditValue = ppn;

            double total = subTotal + ppn + (double)freightSpinEdit.Value + (double)feePackEdit.Value;
            txtTotal.EditValue = total;
        }


        private void discSpinEdit_EditValueChanged(object sender, EventArgs e)
        {
            ReCalculateTotal();
        }

        private void freightSpinEdit_EditValueChanged(object sender, EventArgs e)
        {
            ReCalculateTotal();
        }

        private void feePackEdit_EditValueChanged(object sender, EventArgs e)
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

                ((DataRowView)MasterBindingSource.Current).Row["feepackaging"] = feePackEdit.Text;
                ((DataRowView)MasterBindingSource.Current).Row["freight"] = freightSpinEdit.Text; ;
                ((DataRowView)MasterBindingSource.Current).Row["hscode"] = hscodetextEdit.Text;

                if (this.Tag.ToString() == "252a")
                {
                    ((DataRowView)MasterBindingSource.Current).Row["group_"] = 1;
                }
                else
                    if (this.Tag.ToString() == "252b")
                    {
                        ((DataRowView)MasterBindingSource.Current).Row["group_"] = 2;
                    }

                for (int i = DetailTable.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = DetailTable.Rows[i];
                    if (row != null && row.RowState != DataRowState.Deleted)
                    {
                        row[0] = NoDocument;
                        row["no"] = i + 1;
                    }
                }

                base.tsbtnSave_Click(sender, e);

                //string ppnr = txtPPN.Text.Replace(",", ".");
                //string totalr = txtTotal.Text.Replace(",", ".");

                //string ppnr = txtPPN.Text;
                //string totalr = txtTotal.Text;

                //string query = "update pnv set taxvalue = '" + ppnr + "', totalvalue = '" + totalr + "' where pnv = '" + NoDocument + "'";
                //DB.sql.Select(query);

                if (this.mode == Mode.View)
                {
                    gckon.ExGridView.OptionsBehavior.Editable = false;
                    gckon.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                    gckon.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                    gckon.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void tsmiPrintDirectly_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepProforma" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_Print('Transaction.FrmTProformaPeb','" + this.NoDocument + "')");
          //  report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
            report.Print();
        }

        void tsmiPrintPreviewInv_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepProformaPeb" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_Print('Transaction.FrmTProforma','" + this.NoDocument + "')");
         //   report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
           
            report.ShowPreview();
        }

        void tsmiPrintPreviewPL_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepPackingListPeb" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_Print('Transaction.FrmTProforma','" + this.NoDocument + "')");
            //   report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;

            report.ShowPreview();
        }

    }
}

