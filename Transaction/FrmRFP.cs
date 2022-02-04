using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KASLibrary;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraReports.UI;

namespace CAS.Transaction
{
    public partial class FrmRFP : BaseTransaction
    {
        private string modenya = "";
        public FrmRFP()
        {
            InitializeComponent();
            //DetailTable.Columns.Add("nama", typeof(String));
            Utility.SetSqlInstance(pnlDetail, DB.sql);
            gcRFD.ExGridControl.DataSource = rfdBindingSource;
            gcRFD.ExGridView.Columns["rfp"].Visible = false;
            gcRFD.ExGridView.Columns["no"].Visible = false;
            gcRFD.ExGridView.Columns["valrp"].Visible = false;
            gcRFD.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gcRFD.ExToolStrip.Items["tsbtnNew"].Enabled = false;
            
            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnDelete.Click += new EventHandler(tsbtnDelete_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);

            gcRFD.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
            gcRFD.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
            gcRFD.ExGridView.CellValueChanged += new CellValueChangedEventHandler(ExGridView_CellValueChanged);
            gcRFD.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
            gcRFD.ExGridView.Columns["nodoc"].ColumnEdit = new GridLookUpEx(DB.sql, "call SP_OutRhp('" + ctrlSub.txtSub.Text + "','" + ctrlSub.txtSub.Text + "'," + Utility.FirstDateInMonth(dateDate.DateTime).ToString("yyyyMMdd") + "," + ((DateTime)dateDate.EditValue).AddDays(1).ToString("yyyyMMdd") + ",'" + ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text + "','1')", "rhp", "jurnal", gcRFD.ExGridView, "", true, true, "Detail Hutang");
            //gcRFD.ExGridView.Columns["nodoc"].ColumnEdit.Enter += new EventHandler(ExGridView_NoDocColumnEdit_Enter);
              
            
            gcRFD.ExTitleLabel.Text = "Detail Pelunasan";
            gcRFD.ExGridView.Columns["val"].Caption = "Nilai";
            gcRFD.ExGridView.Columns["nodoc"].Caption = "No.Hutang";
            gcRFD.ExGridView.Columns["invoice"].Caption = "Invoice";
            gcRFD.ExGridView.Columns["acc"].Caption = "Kode Akun";
            gcRFD.ExGridView.Columns["nama"].Caption = "Nama Akun";
            gcRFD.ExGridView.Columns["remark"].Caption = "Keterangan";
            gcRFD.ExGridView.Columns["kurs"].Caption = "kurs";
            gcRFD.ExGridView.Columns["valrp"].Caption = "Nilai Rp";
            gcRFD.ExGridView.Columns["dk"].Caption = "D/K";

            gcRFD.ExGridView.Columns["nodoc"].OptionsColumn.AllowEdit = true;
            gcRFD.ExGridView.Columns["valrp"].OptionsColumn.AllowEdit = false;
            gcRFD.ExGridView.Columns["kurs"].OptionsColumn.AllowEdit = false;
            gcRFD.ExGridView.Columns["val"].ColumnEdit = new GridNumEx();

            gcRFD.ExGridView.BestFitColumns();
            gcRFD.ExGridView.OptionsBehavior.Editable = false;
            gcRFD.ExGridView.OptionsSelection.MultiSelect = true;
            gcRFD.ExGridView.OptionsCustomization.AllowSort = false;
            gcRFD.ExGridView.OptionsView.ShowGroupPanel = false;
            DB.SetNumberFormat(gcRFD.ExGridView, "n2");
            tsbtnPrint.Click += new EventHandler(tsbtnPrint_Click);

      
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            modenya = "new";
            DetailTable.Clear();
            casDataSet.rfd.Clear();
            gcRFD.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcRFD.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcRFD.ExGridView.OptionsBehavior.Editable = true;
            gcRFD.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            kembalidateDateEdit.EditValue = DB.loginDate;
            terimadateDateEdit.EditValue = DB.loginDate;

            Utility.SetReadOnly(txtTotal, true);
        }

        void tsbtnPrint_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepRFP" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_RFP('" + this.NoDocument + "')");
       //     report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
            report.ShowPreview();
        }

        void ExGridView_New_Click(object sender, EventArgs e)
        {
            DataRow row = casDataSet.rfd.NewRow();
            row["rfp"] = NoDocument;
            row["val"] = 0;
            row["nodoc"] = "";
            row["no"] = DB.GetRowCount(casDataSet.rfd) + 1;
            casDataSet.rfd.Rows.Add(row);

            DB.InsertDetailRows(gcRFD.ExGridView, row);
        }
        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            if (this.mode == Mode.Edit)
            {
                gcRFD.ExGridView.OptionsBehavior.Editable = true;
                gcRFD.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                gcRFD.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
                gcRFD.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            }
        }
        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gcRFD.ExGridView.GetDataRow(e.RowHandle);
            row["rfp"] = NoDocument;
            row["no"] = DB.GetRowCount(casDataSet.rfd) + 1;
        }

        void ExGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "val" || e.Column.FieldName == "kurs") CalculateTotalRFD();
            if (e.Column.FieldName == "nodoc")
            {
                if (gcRFD.ExGridView.GetFocusedRowCellValue("nodoc") != null)
                {
                    string jurnal = gcRFD.ExGridView.GetFocusedRowCellValue("nodoc").ToString();
                    string query1 = "select duedate from rhp where jurnal='" + jurnal + "'";
                    DataTable dt1 = DB.sql.Select(query1);
                    this.terimadateDateEdit.Text = dt1.Rows[0]["duedate"].ToString();
                }
                string query = "select * from rfd,rfp "
                                   + "where nodoc='" + (string)gcRFD.ExGridView.GetFocusedRowCellValue("nodoc") 
                                   + "' and rfd.rfp=rfp.rfp and rfp.delete=0";
                DataTable dt = DB.sql.Select(query);
                if (dt.Rows.Count > 0)
                    MessageBox.Show("no document Request for payment "+ dt.Rows[0]["nodoc"].ToString()+" sudah pernah dipakai "+ dt.Rows[0]["rfp"].ToString(), "PERINGATAN");
            }
        }

        private void CalculateTotalRFD()
        {
            try
            {
                DetailBindingSource.EndEdit();

                double totalKAG = 0;
                for (int i = 0; i < DetailTable.Rows.Count; i++)
                {
                    if (DetailTable.Rows[i] != null && DetailTable.Rows[i].RowState != DataRowState.Deleted)
                    {
                        if (DetailTable.Rows[i]["dk"].ToString() == "K")
                        {
                            totalKAG = totalKAG + (double)DetailTable.Rows[i]["val"];
                        }
                        else
                        {
                            totalKAG = totalKAG - (double)DetailTable.Rows[i]["val"];
                        }
                        DetailTable.Rows[i]["valrp"] = (double)DetailTable.Rows[i]["val"];
                    }
                }
                txtTotal.EditValue = Math.Round(totalKAG);
            }
            catch (Exception ex)
            { }
        }

        void ExGridView_Delete_Click(object sender, EventArgs e)
        {
            bool canDeleteitem, canDelete = true;
            int[] selectedIndex = gcRFD.ExGridView.GetSelectedRows();
            if (selectedIndex.Length > 0)
            {
                for (int i = 0; i < selectedIndex.Length; i++)
                {
                    string prq = gcRFD.ExGridView.GetDataRow(selectedIndex[i])["rfp"].ToString();
                    int no = Convert.ToInt32(gcRFD.ExGridView.GetDataRow(selectedIndex[i])["no"]);
                    canDeleteitem = DeleteLineItem(prq, no);
                    if (canDeleteitem == false) canDelete = false;
                }
                if (canDelete)
                {
                    DB.DeleteDetailRows(gcRFD.ExGridView);
                    CalculateTotalRFD();
                    //if (DetailTable.GetChanges() != null)
                    //    DetailAdapter.Update(DetailTable);
                }
            }
        }

        private void FrmRFP_Load(object sender, EventArgs e)
        {
            DetailTable = DB.PopulateNamaRekening(DetailTable, "nama");
            ctrlSub.txtSub.DataBindings.Add("EditValue", MasterBindingSource, "sub");
            ctrlSub.txtSub.EditValueChanged += new EventHandler(txtSub_EditValueChanged);
           if (MasterBindingSource.Position == MasterTable.Rows.Count)
            {
                // gcRFD.ExGridView.OptionsBehavior.Editable = true;
                gcRFD.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                //gcRFD.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
                //gcRFD.ExToolStrip.Items["tsbtnNew"].Enabled = true;
                kembalidateDateEdit.EditValue = DB.loginDate;
                terimadateDateEdit.EditValue = DB.loginDate;
            }
           
            gcRFD.ExGridView.BestFitColumns();
            CalculateTotalRFD();
        }


        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateChildren();

                if (gcRFD.ExGridView.EditingValue != null)
                    gcRFD.ExGridView.SetFocusedValue(gcRFD.ExGridView.EditingValue);

                DetailBindingSource.EndEdit();
                
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
                if (modenya == "new")
                {
                    DB.sql.Execute("update rfp set stat_rfp = 0 where rfp = '" + NoDocument + "'");
                }
                if (this.mode == Mode.View)
                {
                     gcRFD.ExGridView.OptionsBehavior.Editable = false;
                     gcRFD.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                     gcRFD.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                     gcRFD.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void txtSub_EditValueChanged(object sender, EventArgs e)
        {
            DataRow row = ctrlSub.txtSub.ExGetDataRow();
            if (row == null)
                return;
            curcur.EditValue = row["cur"].ToString();
            string query = "call SP_OutRhp('" + ctrlSub.txtSub.Text + "','" + ctrlSub.txtSub.Text + "'," + Utility.FirstDateInMonth(dateDate.DateTime).ToString("yyyyMMdd") + "," + ((DateTime)dateDate.EditValue).AddDays(1).ToString("yyyyMMdd") + ",'" + ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text + "','1')";
            gcRFD.ExGridView.Columns["nodoc"].ColumnEdit = new GridLookUpEx(DB.sql, "call SP_OutRhp('" + ctrlSub.txtSub.Text + "','" + ctrlSub.txtSub.Text + "'," + Utility.FirstDateInMonth(dateDate.DateTime).ToString("yyyyMMdd") + "," + ((DateTime)dateDate.EditValue).AddDays(1).ToString("yyyyMMdd") + ",'" + ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text + "','1')", "rhp", "jurnal", gcRFD.ExGridView, "", true, true, "Detail Hutang");

            if (DetailTable.Rows.Count > 0)
            {
                return;
            }
        }

        protected override void tsbtnCancel_Click(object sender, EventArgs e)
        {
            DB.CancelDetailRows(DetailTable);
           
            base.tsbtnCancel_Click(sender, new EventArgs());

            if (this.mode == Mode.View)
            {
                CalculateTotalRFD();

                gcRFD.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                gcRFD.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                gcRFD.ExGridView.OptionsBehavior.Editable = false;
                gcRFD.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;

             }
        }

        private void curcur_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}