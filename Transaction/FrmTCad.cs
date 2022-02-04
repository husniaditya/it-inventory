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

namespace CAS.Transaction
{
    public partial class FrmTCad : CAS.Transaction.BaseTransaction
    {
        private int[] selectedIndex = new int[0];
        private bool isDetailValid = true;
        public FrmTCad()
        {
            InitializeComponent();
       
            gccad.ExGridControl.DataSource = cadetBindingSource;
            gccad.ExGridView.OptionsView.ShowGroupPanel = false;
            gccad.ExTitleLabel.Text = "Detail Pencadangan";
            gccad.ExGridView.OptionsCustomization.AllowSort = false;

            gccad.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
            gccad.ExGridView.CellValueChanged += new CellValueChangedEventHandler(ExGridView_CellValueChanged);
          
            gccad.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
            gccad.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
            gccad.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gccad.ExToolStrip.Items["tsbtnNew"].Enabled = false;

            gccad.ExGridView.Columns["cad"].OptionsColumn.AllowEdit = false;
            gccad.ExGridView.Columns["remark"].OptionsColumn.AllowEdit = true;
            gccad.ExGridView.Columns["no"].Visible = false;
            gccad.ExGridView.Columns["cad"].Visible = false;
           
             gccad.ExGridView.Columns["acc"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('acc')", "acc", "acc", gccad.ExGridView, "", true, true, "Perkiraan");
            gccad.ExGridView.Columns["cct"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('cct')", "cct", "cct", gccad.ExGridView, "", true, true, "Cost Center");

            // Debet Kredit ComboBox
            RepositoryItemComboBox cboDK = new RepositoryItemComboBox();
            cboDK.Items.AddRange(new string[] { "D", "K" });
            cboDK.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            gccad.ExGridView.Columns["dk"].ColumnEdit = cboDK;

            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            //tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            tsbtnDelete.Click += new EventHandler(tsbtnDelete_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);

            gccad.ExGridView.Columns["nocad"].Caption = "No Cad";
            gccad.ExGridView.Columns["acc"].Caption = "Kode Akun";
            gccad.ExGridView.Columns["remark"].Caption = "Keterangan";
            gccad.ExGridView.Columns["cct"].Caption = "Cost Center";
            gccad.ExGridView.Columns["dk"].Caption = "D/K";
            gccad.ExGridView.Columns["val"].Caption = "Nilai";

            gccad.ExGridView.Columns["nocad"].VisibleIndex = 1;
            gccad.ExGridView.Columns["acc"].VisibleIndex = 0;
            gccad.ExGridView.Columns["cct"].VisibleIndex = 2;
            gccad.ExGridView.Columns["remark"].VisibleIndex = 3;
            gccad.ExGridView.Columns["dk"].VisibleIndex = 4;
            gccad.ExGridView.Columns["val"].VisibleIndex = 5;
     
            gccad.ExGridView.Columns["val"].Width = 150;
            gccad.ExGridView.Columns["nocad"].Width = 100;
            gccad.ExGridView.Columns["acc"].Width = 100;
            gccad.ExGridView.Columns["remark"].Width = 200;
            gccad.ExGridView.Columns["cct"].Width = 100;
            gccad.ExGridView.Columns["dk"].Width = 100;

            gccad.ExGridView.OptionsBehavior.Editable = false;
            gccad.ExGridView.OptionsSelection.MultiSelect = true;
            gccad.ExGridView.OptionsCustomization.AllowSort = false;
            DB.SetNumberFormat(gccad.ExGridView, "n2");
        }

        private void FrmTCad_Load(object sender, EventArgs e)
        {
            Utility.SetSqlInstance(pnlDetail, DB.sql);
            ctrlSub.txtSub.DataBindings.Add("EditValue", MasterBindingSource, "sub");
         
            // TODO: This line of code loads data into the 'casDataSet.cadet' table. You can move, or remove it, as needed.
         //   this.cadetTableAdapter.Fill(this.casDataSet.cadet);
            // TODO: This line of code loads data into the 'casDataSet.cad' table. You can move, or remove it, as needed.
           // this.cadTableAdapter.Fill(this.casDataSet.cad);

        }
        void ExGridView_New_Click(object sender, EventArgs e)
        {
            DataRow row = casDataSet.cadet.NewRow();
            row["nocad"] = "";
            row["cad"] = NoDocument;
            row["acc"] = "";
            row["remark"] = "";
            row["cct"] = "";
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            casDataSet.cadet.Rows.Add(row);

            DB.InsertDetailRows(gccad.ExGridView, row);

        }

        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gccad.ExGridView.GetDataRow(e.RowHandle);
            row["cad"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
            //row["no"] = DetailTable.Rows.Count + 1;
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            row["val"] = 0;
        }

        void ExGridView_Delete_Click(object sender, EventArgs e)
        {
            DB.DeleteDetailRows(gccad.ExGridView);
            ReCalculateTotal();
        }
        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            gccad.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gccad.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gccad.ExGridView.OptionsBehavior.Editable = true;
            gccad.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
        }

        protected override void tsbtnDelete_Click(object sender, EventArgs e)
        {
            base.tsbtnDelete_Click(sender, e);
            if (Convert.ToInt32(MasterTable.Rows[MasterBindingSource.Position]["delete"]) == 1)
            DB.sql.Execute("Call Sp_Delete('CAD'" + ",'" + NoDocument + "')");
        }

        protected override void tsbtnCancel_Click(object sender, EventArgs e)
        {
            DB.CancelDetailRows(DetailTable);

            base.tsbtnCancel_Click(sender, new EventArgs());

            if (this.mode == Mode.View)
            {
                gccad.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                gccad.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                gccad.ExGridView.OptionsBehavior.Editable = false;
                gccad.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            }
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            curcur.Text = "";
            curkurs.EditValue = 1;
            DetailTable.Clear();
            gccad.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gccad.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gccad.ExGridView.OptionsBehavior.Editable = true;
            gccad.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            ReCalculateTotal();

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

        void ExGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "val" || e.Column.FieldName == "dk")
            {
                ReCalculateTotal();
                if (e.Column.FieldName == "dk")
                {
                    if ((double)gccad.ExGridView.GetFocusedRowCellValue("val") == 0)
                    {
                        if ((string)gccad.ExGridView.GetFocusedRowCellValue("dk") == "D" && Convert.ToDouble(txtSelisih.EditValue) < 0)
                            gccad.ExGridView.SetFocusedRowCellValue(gccad.ExGridView.Columns["val"], Convert.ToString(Convert.ToDouble(txtSelisih.EditValue.ToString()) * -1));
                        if ((string)gccad.ExGridView.GetFocusedRowCellValue("dk") == "K" && Convert.ToDouble(txtSelisih.EditValue) > 0)
                            gccad.ExGridView.SetFocusedRowCellValue(gccad.ExGridView.Columns["val"], txtSelisih.EditValue.ToString());

                    }
                }
            }
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
                if (curcur.EditValue.ToString() == "")
                    throw new Exception("Harap mengisi Currency!");

                if (gccad.ExGridView.EditingValue != null)
                    gccad.ExGridView.SetFocusedValue(gccad.ExGridView.EditingValue);

                DetailBindingSource.EndEdit();

                for (int i = 0; i < gccad.ExGridView.RowCount; i++)
                {
                    if (gccad.ExGridView.GetDataRow(i) != null)
                        if (gccad.ExGridView.GetDataRow(i).RowState != DataRowState.Deleted)
                        {
                            ExGridView_ValidateRow(sender, new ValidateRowEventArgs(i, gccad.ExGridView.GetRow(i)));
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
                    DB.sql.Execute("Call SP_Save(" + date + ",'CAD'" + ",'" + jurnal + "')");

                    gccad.ExGridView.OptionsBehavior.Editable = false;
                    gccad.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                    gccad.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                    gccad.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNo_EditValueChanged(object sender, EventArgs e)
        {
            ReCalculateTotal();
        }

       
    }
}

