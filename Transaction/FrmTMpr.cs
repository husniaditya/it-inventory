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

namespace CAS.Transaction
{
    public partial class FrmTMpr : CAS.Transaction.BaseTransaction
    {
        private int[] selectedIndex = new int[0];
        private bool isDetailValid = true;

        public FrmTMpr()
        {
            InitializeComponent();

            Utility.SetSqlInstance(pnlDetail, DB.sql);
            DetailTable.Columns.Add("Unit Base", typeof(String));
            MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);

            gcPrq.ExGridControl.DataSource = mpdBindingSource;
            gcPrq.ExTitleLabel.Text = "Purchase Request Detail";

            gcPrq.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
            gcPrq.ExGridView.CellValueChanged += new CellValueChangedEventHandler(ExGridView_CellValueChanged);
            //gcPrq.ExGridView.ValidateRow += new ValidateRowEventHandler(ExGridView_ValidateRow);            

            gcPrq.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
            gcPrq.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
            gcPrq.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gcPrq.ExToolStrip.Items["tsbtnNew"].Enabled = true;

            gcPrq.ExGridView.Columns["mpr"].OptionsColumn.AllowEdit = false;
            gcPrq.ExGridView.Columns["qty"].OptionsColumn.AllowEdit = false;
            //gcPrq.ExGridView.Columns["remark"].OptionsColumn.AllowEdit = false;
            gcPrq.ExGridView.Columns["remark"].ColumnEdit = new RepositoryItemTextEdit();
            gcPrq.ExGridView.Columns["remark"].ColumnEdit.Enter += new EventHandler(remarkColumnEdit_Enter);
            
            gcPrq.ExGridView.Columns["no"].Visible = false;
            gcPrq.ExGridView.Columns["mpr"].Visible = false;
         //   gcPrq.ExGridView.Columns["acc"].Visible = false;


            //only select bahan baku
            gcPrq.ExGridView.Columns["inv"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('inv')", "inv", "inv", gcPrq.ExGridView, "", true, true, "Inventory");
            gcPrq.ExGridView.Columns["inv"].ColumnEdit.Enter += new EventHandler(invColumnEdit_Enter);
            gcPrq.ExGridView.Columns["dept"].ColumnEdit = new GridLookUpEx(DB.sql, "select dept as Departement, nama as `Nama Departement` from dept", "dept", "dept", gcPrq.ExGridView, "", false, false, "Departement");
         //   gcPrq.ExGridView.Columns["cct"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('cct')", "cct", "cct", gcPrq.ExGridView, "", false, false, "Cost Center");
         //   gcPrq.ExGridView.Columns["cct"].ColumnEdit.Enter += new EventHandler(cctColumnEdit_Enter);
        //    gcPrq.ExGridView.Columns["acc"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUpCca('')", "acc", "acc", gcPrq.ExGridView, "", false, false, "Account");
        //    gcPrq.ExGridView.Columns["acc"].ColumnEdit.Enter += new EventHandler(accColumnEdit_Enter);
            gcPrq.ExGridView.Columns["unit"].ColumnEdit = new GridLookUpUnit(gcPrq.ExGridView);           
            
            gcPrq.ExGridView.Columns["qty1"].ColumnEdit = new GridNumEx();

            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            //tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
            
            gcPrq.ExGridView.Columns["inv"].VisibleIndex = 0;
            gcPrq.ExGridView.Columns["remark"].VisibleIndex = 1;
          //  gcPrq.ExGridView.Columns["loc"].VisibleIndex = 2;
            gcPrq.ExGridView.Columns["dateneed"].VisibleIndex = 3;
        //    gcPrq.ExGridView.Columns["cct"].VisibleIndex = 4;
            gcPrq.ExGridView.Columns["qty1"].VisibleIndex = 5;
            gcPrq.ExGridView.Columns["unit"].VisibleIndex = 6;
            gcPrq.ExGridView.Columns["qty"].VisibleIndex = 7;
           gcPrq.ExGridView.Columns["dept"].VisibleIndex = 9;
            gcPrq.ExGridView.Columns["etd"].VisibleIndex = 10;

            gcPrq.ExGridView.Columns["inv"].Caption = "Kode Barang";
            gcPrq.ExGridView.Columns["remark"].Caption = "Nama Barang";
         //   gcPrq.ExGridView.Columns["loc"].Caption = "Loc";
        //    gcPrq.ExGridView.Columns["cct"].Caption = "Cost Center";
           gcPrq.ExGridView.Columns["dept"].Caption = "Departement";
            gcPrq.ExGridView.Columns["qty"].Caption = "Qty Base";
            gcPrq.ExGridView.Columns["unit"].Caption = "Unit";
            gcPrq.ExGridView.Columns["qty1"].Caption = "Qty";
            gcPrq.ExGridView.Columns["dateneed"].Caption = "Tgl Dibutuhkan";
            gcPrq.ExGridView.Columns["etd"].Caption = "Keterangan";
            
         //   gcPrq.ExGridView.Columns["Unit Base"].VisibleIndex = DetailTable.Columns.IndexOf("qty");
         //   gcPrq.ExGridView.Columns["Unit Base"].OptionsColumn.AllowEdit = false;

            gcPrq.ExGridView.BestFitColumns();
            gcPrq.ExGridView.OptionsBehavior.Editable = false;
            gcPrq.ExGridView.OptionsSelection.MultiSelect = true;
            gcPrq.ExGridView.OptionsCustomization.AllowSort = false;
            gcPrq.ExGridView.OptionsView.ShowGroupPanel = false;
            tsbtnPrint.Click += new EventHandler(tsbtnPrint_Click);
        }

        void tsbtnPrint_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepPrq" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_Print('Transaction.FrmTPrq','" + this.NoDocument + "')");
            report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
            report.ShowPreview();
        }

        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DetailTable=DB.PopulateUnitBase(DetailTable,"Unit Base");
            gcPrq.ExGridView.BestFitColumns();
        }


        void accColumnEdit_Enter(object sender, EventArgs e)
        {
            if (gcPrq.ExGridView.GetFocusedRowCellValue("cct") != null &&
                gcPrq.ExGridView.GetFocusedRowCellValue("inv") != null)
            {
                string cct = gcPrq.ExGridView.GetFocusedRowCellValue("cct").ToString();
                string kodeBarang = gcPrq.ExGridView.GetFocusedRowCellValue("inv").ToString();
                if (DB.isBiaya(kodeBarang))
                {
                    ((GridLookUpEx)gcPrq.ExGridView.Columns["acc"].ColumnEdit).Query = "Call SP_LookUpCca('" + (string)gcPrq.ExGridView.GetFocusedRowCellValue("cct") + "')";
                    ((ButtonEdit)sender).Enabled = true;
                }
                else
                {
                    ((GridLookUpEx)gcPrq.ExGridView.Columns["acc"].ColumnEdit).Query = "";
                    ((ButtonEdit)sender).Enabled = false;
                }
            }
            else
            {
                ((GridLookUpEx)gcPrq.ExGridView.Columns["acc"].ColumnEdit).Query = "";
                ((ButtonEdit)sender).Enabled = false;
            }
        }

        void cctColumnEdit_Enter(object sender, EventArgs e)
        {
            if (gcPrq.ExGridView.GetFocusedRowCellValue("inv") != null)
            {
                string kodeBarang = gcPrq.ExGridView.GetFocusedRowCellValue("inv").ToString();
                if (DB.isBiaya(kodeBarang))
                    ((ButtonEdit)sender).Enabled = true;
                else
                    ((ButtonEdit)sender).Enabled = false;
            }
            else
                ((ButtonEdit)sender).Enabled = false;
        }

        void remarkColumnEdit_Enter(object sender, EventArgs e)
        {
            if (gcPrq.ExGridView.GetFocusedRowCellValue("inv") != null)
            {
                string kodeBarang = gcPrq.ExGridView.GetFocusedRowCellValue("inv").ToString();
                if (DB.isBiaya(kodeBarang))
                    ((TextEdit)sender).Properties.ReadOnly = false;
                else
                    ((TextEdit)sender).Properties.ReadOnly = true;                               
            }
            else
                ((TextEdit)sender).Properties.ReadOnly = true;
        }

        void ExGridView_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            if (((DataRowView)e.Row).Row["inv"].ToString() == "" ||
                //((DataRowView)e.Row).Row["loc"].ToString() == "" ||
                ((DataRowView)e.Row).Row["dateneed"].ToString() == "")
            {
                e.Valid = false;
                e.ErrorText = "Invalid Kode Barang/Tgl Dibutuhkan.";
                isDetailValid = false;
            }
            else
            { isDetailValid = true; }
        }
       
        void ExGridView_New_Click(object sender, EventArgs e)
        {
            DataRow row = casDataSet.prd.NewRow();
            row["mpr"] = NoDocument;
            row["qty"] = 0;
            row["qty1"] = 0;
            row["inv"] = "";
            row["unit"] = "";
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            casDataSet.prd.Rows.Add(row);
            
            DB.InsertDetailRows(gcPrq.ExGridView, row);         
        }

        void ExGridView_Delete_Click(object sender, EventArgs e)
        {
            bool canDeleteitem, canDelete = true;
            int[] selectedIndex = gcPrq.ExGridView.GetSelectedRows();
            for (int i = 0; i < selectedIndex.Length; i++)
            {
                string prq = gcPrq.ExGridView.GetDataRow(selectedIndex[i])["mpr"].ToString();
                int no = Convert.ToInt32(gcPrq.ExGridView.GetDataRow(selectedIndex[i])["no"]);
                canDeleteitem = DeleteLineItem(prq,no);
                if (canDeleteitem == false) canDelete = false;
            }
            if (canDelete) DB.DeleteDetailRows(gcPrq.ExGridView);
                //DeleteLineItem(gcPrq.ExGridView.GetDataRow());
            //cek apakah line item PR sudah di proses ke PO
            //int[] selectedIndex = gcPrq.ExGridView.GetSelectedRows();
            //for (int i = 0; i < selectedIndex.Length; i++)
            //{
            //    string prq = gcPrq.ExGridView.GetDataRow(selectedIndex[i])["prq"].ToString();
            //    int no = Convert.ToInt32(gcPrq.ExGridView.GetDataRow(selectedIndex[i])["no"]);
            //    string query = "Select * from omd where prq='" + prq + "' and noprd=" + no.ToString();
            //    DataTable dtOmd = DB.sql.Select(query);
            //    if (dtOmd.Rows.Count > 0)
            //    {
            //        MessageBox.Show("Item PR ke-" + no.ToString() + " tidak bisa di-delete karena sudah ada PO");
            //        return;
            //    }
            //}
            
            //DB.DeleteDetailRows(gcPrq.ExGridView);
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            string query = "Select FCanDeleteLineItem('MPD','" + NoDocument + "',1)";
            if (DB.sql.Select(query).Rows[0][0].ToString() == "False")
            {
                MessageBox.Show("Memo PR sudah dibuatkan PR Harap membatalkan dulu transaksi berikutnya");
                tsbtnCancel_Click(sender,e) ;
                return;
            }
            aprovCheckBox.Checked = false;
            if (this.mode == Mode.Edit)
            {
                gcPrq.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
                gcPrq.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                gcPrq.ExGridView.OptionsBehavior.Editable = true;
                gcPrq.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
     //           if (personTextBoxEx.EditValue.ToString() == "MRP")
       //             personTextBoxEx.Enabled = false;
            }
        }

        protected override void tsbtnCancel_Click(object sender, EventArgs e)
        {
            DB.CancelDetailRows(DetailTable);
            
            base.tsbtnCancel_Click(sender, new EventArgs());

            if (this.mode == Mode.View)
            {
                gcPrq.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                gcPrq.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                gcPrq.ExGridView.OptionsBehavior.Editable = false;
                gcPrq.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                personTextBoxEx.Enabled = true;
                DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
            }
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            DetailTable.Clear();
            gcPrq.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcPrq.ExToolStrip.Items["tsbtnNew"].Enabled = false;
            gcPrq.ExGridView.OptionsBehavior.Editable = true;
            gcPrq.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            personTextBoxEx.Enabled = true;
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate controls
                this.ValidateChildren();
             
                if (personTextBoxEx.EditValue.ToString() == "")
                    throw new Exception("Harap mengisi Nama Requesition!");
                
                DetailBindingSource.EndEdit();
                for (int i = 0; i < gcPrq.ExGridView.RowCount; i++)
                {
                    if (gcPrq.ExGridView.GetDataRow(i) != null)
                        if (gcPrq.ExGridView.GetDataRow(i).RowState != DataRowState.Deleted)
                        {
                            ExGridView_ValidateRow(sender, new ValidateRowEventArgs(i, gcPrq.ExGridView.GetRow(i)));
                            if (!isDetailValid)
                            {
                                MessageBox.Show("Invalid Kode Barang/Tgl Dibutuhkan. Please correct the value");
                                return;
                            }
                            else
                            {
                                string kodeBarang = gcPrq.ExGridView.GetDataRow(i)["inv"].ToString();
                                //string cct = gcPrq.ExGridView.GetDataRow(i)["cct"].ToString();
                                //string acc = gcPrq.ExGridView.GetDataRow(i)["acc"].ToString();
                                //if (DB.isBiaya(kodeBarang) && (cct == "" || acc == ""))
                                //{
                                //    MessageBox.Show("Harap mengisi Cost Center dan Account untuk Material Biaya");
                                //    return;
                                //}                            
                            }
                            // Check quantity
                            if (Convert.ToDouble(gcPrq.ExGridView.GetDataRow(i)["qty"]) == 0)
                            {
                                MessageBox.Show("Please enter item quantity");
                                return;
                            }
                        }
                }
               
                for (int i = DetailTable.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = DetailTable.Rows[i];
                    if (row != null && row.RowState != DataRowState.Deleted)
                    {
                        row[0] = NoDocument;
                    }
                }

                ((DataRowView)MasterBindingSource.Current).Row["aprov"] = (aprovCheckBox.Checked) ? 1 : 0;
                
                base.tsbtnSave_Click(sender, e);
                if (this.mode == Mode.View)
                {
                    gcPrq.ExGridView.OptionsBehavior.Editable = false;
                    gcPrq.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                    gcPrq.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                    gcPrq.ExToolStrip.Items["tsbtnNew"].Enabled = true;
                }
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

                //if (e.Column.FieldName == "unit")
                //{
                //    gcPrq.ExGridView.SetFocusedRowCellValue(gcPrq.ExGridView.Columns["unit1"], (string)gcPrq.ExGridView.GetFocusedRowCellValue("unit"));
                //}
                if (gcPrq.ExGridView.GetFocusedRowCellValue("inv") != null &&
                    gcPrq.ExGridView.GetFocusedRowCellValue("unit") != null &&
                    gcPrq.ExGridView.GetFocusedRowCellValue("qty1") != null)
                {
                    string inv = (string)gcPrq.ExGridView.GetFocusedRowCellValue("inv");
                    string unit = (string)gcPrq.ExGridView.GetFocusedRowCellValue("unit");
                    double qty1 = (double)gcPrq.ExGridView.GetFocusedRowCellValue("qty1");
                    if (inv != "" && unit != "")
                        gcPrq.ExGridView.SetFocusedRowCellValue(gcPrq.ExGridView.Columns["qty"], DB.GetQtyInBaseUom(inv, unit, qty1));
                }
                DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
                return;
            }
            if (e.Column.FieldName == "cct")
            {
                ((GridLookUpEx)gcPrq.ExGridView.Columns["acc"].ColumnEdit).Query = "Call SP_LookUpCca('" + (string)gcPrq.ExGridView.GetFocusedRowCellValue("cct") +"')";
            }
        }

      
        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gcPrq.ExGridView.GetDataRow(e.RowHandle);
            row["mpr"] = NoDocument;
            row["qty1"] = 0;
        //    row["aprov"] = 0;
        //    row["close"] = 0;
            row["no"] = DB.GetRowCount(DetailTable) + 1;
        }

        private void FrmTPrq_Load(object sender, EventArgs e)
        {
          DetailTable=DB.PopulateUnitBase(DetailTable,"Unit Base");
        }

        void invColumnEdit_Enter(object sender, EventArgs e)
        {
            string invQuery = "Call SP_LookUp('invpemb')";
            //if (!withPOCheckBox.Checked)
            //    invQuery = "Call SP_LookUp('invjasa')";

            ((GridLookUpEx)gcPrq.ExGridView.Columns["inv"].ColumnEdit).Query = invQuery;
        }

        private void personTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void aprovCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (personTextBoxEx.EditValue.ToString() == "" )
            {
                if (aprovCheckBox.Checked == true)
                {
                    MessageBox.Show("User Purchaser harus di isi");
                    aprovCheckBox.Checked = false;
                    return;
                }
            }
            else
            {
                string namaaprov = DB.sql.Select("select kabag from usrpr where usrpr ='" + personTextBoxEx.EditValue.ToString() + "'").Rows[0][0].ToString().Trim();

                if (!aprovCheckBox.Enabled || !aprovCheckBox.Checked) return;
                bool canapprove = true;
                if (DB.casUser.User.ToString().Trim() != namaaprov)
                {
                    canapprove = false;
                }

                if (!canapprove)
                {
                    aprovCheckBox.Checked = false;
                    MessageBox.Show("Memo tidak dapat diapprove karena anda tidak memiliki otorisasi Approv Memo PR");
                }
            }
        }
   }


}

