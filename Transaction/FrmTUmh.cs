using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using KASLibrary;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;

namespace CAS.Transaction
{
    public partial class FrmTUmh : CAS.Transaction.BaseTransaction
    {
        private int[] selectedIndex = new int[0];
        private bool isDetailValid = true;
        public FrmTUmh()
        {
            InitializeComponent();

            ToolStripMenuItem tsmiPrintPreview = new ToolStripMenuItem("Print Preview", null, new EventHandler(tsmiPrintPreview_Click));
            ToolStripMenuItem tsmiPrintDirectly = new ToolStripMenuItem("Print Directly", null, new EventHandler(tsmiPrintDirectly_Click));
            ToolStripDropDownButton tsbtnPrint = new ToolStripDropDownButton("Print", null, tsmiPrintPreview, tsmiPrintDirectly);
            tsbtnPrint.Image = MasterNavigator.Items["tsbtnPrint"].Image;
            MasterNavigator.Items.Insert(MasterNavigator.Items.IndexOfKey("tsbtnPrint"), tsbtnPrint);
            MasterNavigator.Items.RemoveByKey("tsbtnPrint");

            DetailTable.Columns.Add("debet", typeof(String));

            gcumh.ExGridControl.DataSource = umdBindingSource;
            gcumh.ExGridView.OptionsView.ShowGroupPanel = false;
            gcumh.ExTitleLabel.Text = "Detail General Ledger";
            gcumh.ExGridView.OptionsCustomization.AllowSort = false;

            gcumh.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
            gcumh.ExGridView.CellValueChanged += new CellValueChangedEventHandler(ExGridView_CellValueChanged);
            //gcumh.ExGridView.ValidateRow += new ValidateRowEventHandler(ExGridView_ValidateRow);            

            gcumh.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
            gcumh.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
            gcumh.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gcumh.ExToolStrip.Items["tsbtnNew"].Enabled = false;

            gcumh.ExGridView.Columns["umh"].OptionsColumn.AllowEdit = false;
            gcumh.ExGridView.Columns["remark"].OptionsColumn.AllowEdit = true;
            gcumh.ExGridView.Columns["no"].Visible = false;
            gcumh.ExGridView.Columns["umh"].Visible = false;
            gcumh.ExGridView.Columns["debet"].Visible = false;

            gcumh.ExGridView.Columns["jurnal"].ColumnEdit = new GridLookUpEx(DB.sql, "call SP_OutRhp('" + ctrlSub.txtSub.Text + "','" + ctrlSub.txtSub.Text + "'," + Utility.FirstDateInMonth(dateDate.DateTime).ToString("yyyyMMdd") + "," + ((DateTime)dateDate.EditValue).AddDays(1).ToString("yyyyMMdd") + ",'" + ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text + "','2')", "rhp", "jurnal", gcumh.ExGridView, "", true, true, "Jurnal");
            gcumh.ExGridView.Columns["jurnal"].ColumnEdit.Enter += new EventHandler(ExGridView_JurnalColumnEdit_Enter);
            gcumh.ExGridView.Columns["acc"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('acc')", "acc", "acc", gcumh.ExGridView, "", true, true, "Perkiraan");
            gcumh.ExGridView.Columns["cct"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('cct')", "cct", "cct", gcumh.ExGridView, "", true, true, "Cost Center");
            gcumh.ExGridView.Columns["cad"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('cad')", "cad", "cad", gcumh.ExGridView, "", true, false, "Cadangan");
            gcumh.ExGridView.Columns["cad"].ColumnEdit.Enter += new EventHandler(ExGridView_cadColumnEdit_Enter);
           
            gcumh.ExGridView.Columns["okl"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('oklmsk')", "okl", "okl", gcumh.ExGridView, "", true, false, "Nomor SO");
            gcumh.ExGridView.Columns["okl"].ColumnEdit.Enter += new EventHandler(ExGridView_oklColumnEdit_Enter);

            gcumh.ExGridView.Columns["ino"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('ino')", "ino", "ino", gcumh.ExGridView, "", true, false, "Internal Order");
            gcumh.ExGridView.Columns["ino"].ColumnEdit.Enter += new EventHandler(ExGridView_inoColumnEdit_Enter);

            // Debet Kredit ComboBox
            RepositoryItemComboBox cboDK = new RepositoryItemComboBox();
            cboDK.Items.AddRange(new string[] { "D", "K" });
            cboDK.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            gcumh.ExGridView.Columns["dk"].ColumnEdit = cboDK;
            
            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            //tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);

            gcumh.ExGridView.Columns["jurnal"].Caption = "AP/APR";
            gcumh.ExGridView.Columns["acc"].Caption = "Kode Akun";
            gcumh.ExGridView.Columns["remark"].Caption = "Keterangan";
            gcumh.ExGridView.Columns["cct"].Caption = "Cost Center";
            gcumh.ExGridView.Columns["dk"].Caption = "Debet/Kredit";
            gcumh.ExGridView.Columns["debet"].Caption = "D/K";
            gcumh.ExGridView.Columns["val"].Caption = "Nilai";
            gcumh.ExGridView.Columns["okl"].Caption = "No SO";
            gcumh.ExGridView.Columns["invo"].Caption = "Invoice";

            gcumh.ExGridView.BestFitColumns();

            gcumh.ExGridView.Columns["cad"].Width = 100;
            gcumh.ExGridView.Columns["val"].Width = 150;
            gcumh.ExGridView.Columns["jurnal"].Width = 100;
            gcumh.ExGridView.Columns["acc"].Width = 100;
            gcumh.ExGridView.Columns["remark"].Width = 200;
            gcumh.ExGridView.Columns["cct"].Width = 100;
            gcumh.ExGridView.Columns["dk"].Width = 100;
            gcumh.ExGridView.Columns["debet"].Width = 100;
            gcumh.ExGridView.Columns["okl"].Width = 100;
            gcumh.ExGridView.Columns["invo"].Width = 100;

            gcumh.ExGridView.OptionsBehavior.Editable = false;
            gcumh.ExGridView.OptionsSelection.MultiSelect = true;
            gcumh.ExGridView.OptionsCustomization.AllowSort = false;
            gcumh.ExGridView.Columns["jurnal"].VisibleIndex = 0;
            gcumh.ExGridView.Columns["cad"].VisibleIndex = 0;
            gcumh.ExGridView.Columns["ino"].VisibleIndex = 1;
            gcumh.ExGridView.Columns["acc"].VisibleIndex = 2;
            gcumh.ExGridView.Columns["cct"].VisibleIndex = 4;
            gcumh.ExGridView.Columns["remark"].VisibleIndex = 3;
            gcumh.ExGridView.Columns["dk"].VisibleIndex = 5;
            gcumh.ExGridView.Columns["val"].VisibleIndex = 6;
            gcumh.ExGridView.Columns["okl"].VisibleIndex = 7;
            gcumh.ExGridView.Columns["ino"].VisibleIndex = 8;

            DB.SetNumberFormat(gcumh.ExGridView, "n2");
        }

        void ExGridView_cadColumnEdit_Enter(object sender, EventArgs e)
        {
            string query = "Call SP_LookUp('cad" + ctrlSub.txtSub.Text + "')";
            ((GridLookUpEx)gcumh.ExGridView.Columns["cad"].ColumnEdit).Query = query;
        }

        void ExGridView_oklColumnEdit_Enter(object sender, EventArgs e)
        {
            string query = "Call SP_LookUp('oklmsk')";
            ((GridLookUpEx)gcumh.ExGridView.Columns["okl"].ColumnEdit).Query = query;
        }

        void tsmiPrintDirectly_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepJurnalPerkiraan" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_PrintInvoice('Transaction.FrmTUmh','" + this.NoDocument + "')");
            report.PrintingSystem.ShowMarginsWarning = false;
            report.PaperName = "1/2A4";
            report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
            report.Print();
        }

        void tsmiPrintPreview_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepJurnalPerkiraan" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_PrintInvoice('Transaction.FrmTUmh','" + this.NoDocument + "')");
            report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
            report.ShowPreview();
        }
        void ExGridView_JurnalColumnEdit_Enter(object sender, EventArgs e)
        {
            GridLookUpEx jurnalLookUp = (GridLookUpEx)gcumh.ExGridView.Columns["jurnal"].ColumnEdit;
            jurnalLookUp.Query = "call SP_OutRhp('" + ctrlSub.txtSub.Text + "','" + ctrlSub.txtSub.Text + "'," + Utility.FirstDateInMonth(dateDate.DateTime).ToString("yyyyMMdd") + "," + ((DateTime)dateDate.EditValue).AddDays(1).ToString("yyyyMMdd") + ",'" + ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text + "','3')";
        }

        void ReCalculateTotal()
        {
            decimal totalDebet = 0;
            decimal totalKredit = 0;
            double selisih = 0;

            DetailBindingSource.EndEdit();
            for (int i = 0; i < DetailTable.Rows.Count; i++)
            {
                if (DetailTable.Rows[i] != null && DetailTable.Rows[i].RowState != DataRowState.Deleted)
                {
                    if (DetailTable.Rows[i]["dk"].ToString() == "D")
                        totalDebet += Convert.ToDecimal(DetailTable.Rows[i]["val"]);
                    else if (DetailTable.Rows[i]["dk"].ToString() == "K")
                        totalKredit += Convert.ToDecimal((DetailTable.Rows[i]["val"]));
                }
            }

            selisih = Convert.ToDouble(totalDebet - totalKredit);

            txtTotalDebet.EditValue = totalDebet;
            txtTotalKredit.EditValue = totalKredit;
            txtSelisih.EditValue = selisih;
        }

        void ExGridView_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            if (((DataRowView)e.Row).Row["acc"].ToString() == "") 
            {
                e.Valid = false;
                e.ErrorText = "Invalid Kode Account";
                isDetailValid = false;
            }
            else
            { isDetailValid = true; }
        }
       
        void ExGridView_New_Click(object sender, EventArgs e)
        {
            //int idx = gcumh.ExGridView.FocusedRowHandle;
            DataRow row = casDataSet.umd.NewRow();
            row["umh"] = NoDocument;
            row["acc"] = "";
            row["remark"] = "";
            row["cct"] = "";
            //row["no"] = DetailTable.Rows.Count + 1;
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            casDataSet.umd.Rows.Add(row);

            DB.InsertDetailRows(gcumh.ExGridView, row);

            //for (int i = DetailTable.Rows.Count-1; i >= idx; i--)
            //{
            //    if (DetailTable.Rows[i] != null &&
            //        DetailTable.Rows[i].RowState != DataRowState.Deleted)
            //    {
            //        foreach (DataColumn col in DetailTable.Columns)
            //        {
            //            if (i == idx)
            //            {
            //                if (col.ColumnName != "umh" && col.ColumnName != "no")
            //                    DetailTable.Rows[i][col] = col.DefaultValue;
            //            }
            //            else
            //            {
            //                if (col.ColumnName != "no")
            //                    DetailTable.Rows[i][col] = DetailTable.Rows[i - 1][col];
            //            }
            //        }
            //    }
            //}           
        }

        void ExGridView_Delete_Click(object sender, EventArgs e)
        {            
            DB.DeleteDetailRows(gcumh.ExGridView);
            ReCalculateTotal();
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            gcumh.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcumh.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcumh.ExGridView.OptionsBehavior.Editable = true;
            gcumh.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
        }

        protected override void tsbtnCancel_Click(object sender, EventArgs e)
        {
            DB.CancelDetailRows(DetailTable);
            
            base.tsbtnCancel_Click(sender, new EventArgs());

            if (this.mode == Mode.View)
            {
                gcumh.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                gcumh.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                gcumh.ExGridView.OptionsBehavior.Editable = false;
                gcumh.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            }
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            curcur.Text = "IDR";
            curkurs.EditValue = 1;
            DetailTable.Clear();
            sspdateDateEdit.EditValue = DB.loginDate;
            fakdateDateEdit.EditValue = DB.loginDate;
            gcumh.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcumh.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcumh.ExGridView.OptionsBehavior.Editable = true;
            gcumh.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            ReCalculateTotal();
        }

        protected override void tsbtnDelete_Click(object sender, EventArgs e)
        {            
            base.tsbtnDelete_Click(sender, e);
            if (Convert.ToInt32(MasterTable.Rows[MasterBindingSource.Position]["delete"]) == 1)
                DB.sql.Execute("Call SP_Delete('UMH','" + NoDocument + "')");
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidateChildren();
                if (Convert.ToDouble(txtSelisih.EditValue) != 0)
                {
                    MessageBox.Show("Selisih tidak imbang!");
                    return;
                }

                if (gcumh.ExGridView.EditingValue != null)
                    gcumh.ExGridView.SetFocusedValue(gcumh.ExGridView.EditingValue);

                DetailBindingSource.EndEdit();

                for (int i = 0; i < gcumh.ExGridView.RowCount; i++)
                {
                    if (gcumh.ExGridView.GetDataRow(i) != null)
                        if (gcumh.ExGridView.GetDataRow(i).RowState != DataRowState.Deleted)
                        {
                            ExGridView_ValidateRow(sender, new ValidateRowEventArgs(i, gcumh.ExGridView.GetRow(i)));
                            if (!isDetailValid)
                            {
                                MessageBox.Show("Invalid Kode Account. Please correct the value");
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
                        row[0] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
                        //row["no"] = i + 1;
                        //totVal = totVal + (double)row["val"];
                    }
                }

                base.tsbtnSave_Click(sender, e);
                if (this.mode == Mode.View)
                {
                    string date = ((DateTime)(dateDate.EditValue)).ToString("yyyyMMdd");
                    string jurnal = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
                    DB.sql.Execute("Call SP_Save(" + date + ",'UMH'" + ",'" + jurnal + "')");

                    gcumh.ExGridView.OptionsBehavior.Editable = false;
                    gcumh.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                    gcumh.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                    gcumh.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void ExGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "debet")
            {
                string debet = "D";
                if (gcumh.ExGridView.GetFocusedRowCellValue(gcumh.ExGridView.Columns["debet"]).ToString() == "D") debet = "K";
                gcumh.ExGridView.SetFocusedRowCellValue(gcumh.ExGridView.Columns["dk"], debet);
            }
            if (e.Column.FieldName == "val" || e.Column.FieldName == "dk")
            {
                ReCalculateTotal();
                if (e.Column.FieldName == "dk")
                {
                    if ((double)gcumh.ExGridView.GetFocusedRowCellValue("val") == 0)
                    {
                       if ((string)gcumh.ExGridView.GetFocusedRowCellValue("dk")=="D" && Convert.ToDouble(txtSelisih.EditValue) < 0)
                         gcumh.ExGridView.SetFocusedRowCellValue(gcumh.ExGridView.Columns["val"], Convert.ToString(Convert.ToDouble(txtSelisih.EditValue.ToString())*-1));
                       if ((string)gcumh.ExGridView.GetFocusedRowCellValue("dk") == "K" && Convert.ToDouble(txtSelisih.EditValue) > 0)
                         gcumh.ExGridView.SetFocusedRowCellValue(gcumh.ExGridView.Columns["val"], txtSelisih.EditValue.ToString());   
   
                    }
                }
            }
        }
      
        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gcumh.ExGridView.GetDataRow(e.RowHandle);
            row["umh"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
            //row["no"] = DetailTable.Rows.Count + 1;
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            row["val"] = 0;
        }

        private void FrmTUmh_Load(object sender, EventArgs e)
        {
            Utility.SetSqlInstance(pnlDetail, DB.sql);
            ctrlSub.txtSub.DataBindings.Add("EditValue", MasterBindingSource, "sub");
            //ctrlSub1.ReadOnly = true;
            if (MasterBindingSource.Position == MasterTable.Rows.Count)
            {
                gcumh.ExGridView.OptionsBehavior.Editable = true;
                gcumh.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                gcumh.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
                gcumh.ExToolStrip.Items["tsbtnNew"].Enabled = true;
                sspdateDateEdit.EditValue = DB.loginDate;
                fakdateDateEdit.EditValue = DB.loginDate;
            }
            ctrlSub.txtSub.EditValueChanged += new EventHandler(txtSub_EditValueChanged);
            Utility.SetNumberFormat(pnlTotal, "n2");
            ReCalculateTotal();
        }

        void txtSub_EditValueChanged(object sender, EventArgs e)
        {
            //DataRow row = ctrlSub.txtSub.ExGetDataRow();
            //if (row == null)
            //    return;
            //curcur.EditValue = row["cur"].ToString();
        }

        private void omsTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {
            if (omsTextBoxEx.ExSqlInstance == null)
                return;
            DataRow row = omsTextBoxEx.ExGetDataRow();
            if (row == null)
                return;
            ctrlSub.txtSub.EditValue = row["sub"].ToString();
        }

        private void txtNo_EditValueChanged(object sender, EventArgs e)
        {
            ReCalculateTotal();
        }


        void ExGridView_inoColumnEdit_Enter(object sender, EventArgs e)
        {
            string query = "Call SP_LookUp('ino')";
            ((GridLookUpEx)gcumh.ExGridView.Columns["ino"].ColumnEdit).Query = query;
        }
/*
        void ColumnEdit_Enter(object sender, EventArgs e)
        {

            if (gcumh.ExGridView.GetFocusedRowCellValue("dk") != null)
            {
                double val = Convert.ToDouble(DetailTable.Columns["val"]);
                string dk = Convert.ToString(DetailTable.Columns["dk"]);
               if (val == 0)
                  if (dk == "D" || Convert.ToDouble(txtSelisih.Text) < 0)
                      DetailTable.Columns["val"] = Convert.ToDouble(txtSelisih.Text);
               if (dk == "K" || Convert.ToDouble(txtSelisih.Text) > 0)
                  DetailTable.Columns["val"] = Convert.ToDouble(txtSelisih.Text);
    
    
            }
        }
*/
    }
}
