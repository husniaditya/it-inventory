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
    public partial class FrmTScrap : CAS.Transaction.BaseTransaction
    {
        private int[] selectedIndex = new int[0];
        private bool isDetailValid = true;
        public FrmTScrap()
        {
            InitializeComponent();
            DetailTable.Columns.Add("Unit Base", typeof(String));
            locTextBoxEx.ExSqlQuery = "Call SP_LookUp('loc')";
            locTextBoxEx.ExSqlInstance = DB.sql;
            cctTextBoxEx.ExSqlInstance = DB.sql;   
            gcjin.ExGridControl.DataSource = jidBindingSource;

            gcjin.ExGridView.OptionsView.ShowGroupPanel = false;
            gcjin.ExTitleLabel.Text = "Detail Koreksi Persediaan";
            gcjin.ExGridView.OptionsCustomization.AllowSort = false;

            gcjin.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
            gcjin.ExGridView.CellValueChanged += new CellValueChangedEventHandler(ExGridView_CellValueChanged);
            //gcjin.ExGridView.ValidateRow += new ValidateRowEventHandler(ExGridView_ValidateRow);            
            
            //gcjin.ExGridView.Columns["price"].ColumnEdit = new RepositoryItemTextEdit();
         
            gcjin.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
            gcjin.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
            gcjin.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gcjin.ExToolStrip.Items["tsbtnNew"].Enabled = false;
            gcjin.ExGridView.Columns["unit"].ColumnEdit = new GridLookUpUnit(gcjin.ExGridView, "Unit");

            gcjin.ExGridView.Columns["jin"].OptionsColumn.AllowEdit = false;
            gcjin.ExGridView.Columns["inv"].OptionsColumn.AllowEdit = true;
            gcjin.ExGridView.Columns["remark"].OptionsColumn.AllowEdit = true;
        //    gcjin.ExGridView.Columns["unit"].OptionsColumn.AllowEdit = false;
            gcjin.ExGridView.Columns["no"].Visible = false;
            gcjin.ExGridView.Columns["jin"].Visible = false;
            gcjin.ExGridView.Columns["qty"].OptionsColumn.AllowEdit = false;
            gcjin.ExGridView.Columns["mor"].Visible = false;
            gcjin.ExGridView.Columns["nodsg"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('dsg')", "inv", "inv", gcjin.ExGridView, "remark", true, true, "Persediaan");
           // gcjin.ExGridView.Columns["inv"].ColumnEdit = new GridLookUpEx(DB.sql, "", "inv", "inv", gcjin.ExGridView, "", true, false, "Inventory");
            gcjin.ExGridView.Columns["inv"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('invexcludedsg')", "", "inv", gcjin.ExGridView, "", true , true, "Inventory");
            gcjin.ExGridView.Columns["inv"].ColumnEdit.Enter += new EventHandler(InvColumnEdit_Enter);
            gcjin.ExGridView.Columns["qty1"].ColumnEdit = new GridNumEx(500);
            gcjin.ExGridView.Columns["price"].ColumnEdit = new GridNumEx(500);
            gcjin.ExGridView.Columns["val"].ColumnEdit = new GridNumEx(500);

            gcjin.ExGridView.Columns["price"].ColumnEdit.Enter += new EventHandler(priceColumnEdit_Enter);

            // Debet Kredit ComboBox
            RepositoryItemComboBox cboDK = new RepositoryItemComboBox();
            cboDK.Items.AddRange(new string[] { "D", "K" });
            cboDK.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            gcjin.ExGridView.Columns["dk"].ColumnEdit = cboDK;

            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            //tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);

            gcjin.ExGridView.Columns["nodsg"].Caption = "No Design";
            gcjin.ExGridView.Columns["inv"].Caption = "Kode Barang";
            gcjin.ExGridView.Columns["remark"].Caption = "Nama Barang";
            gcjin.ExGridView.Columns["qty1"].Caption = "Quantity";
            gcjin.ExGridView.Columns["unit"].Caption = "Unit";
            gcjin.ExGridView.Columns["qty"].Caption = "Qty Base";
            gcjin.ExGridView.Columns["dk"].Caption = "D/K";
            gcjin.ExGridView.Columns["price"].Caption = "Harga";
            gcjin.ExGridView.Columns["val"].Caption = "Total";

            gcjin.ExGridView.Columns["Unit Base"].VisibleIndex = DetailTable.Columns.IndexOf("qty");
            gcjin.ExGridView.Columns["val"].VisibleIndex = DetailTable.Columns.IndexOf("Unit Base");
            gcjin.ExGridView.Columns["Unit Base"].OptionsColumn.AllowEdit = false;

            gcjin.ExGridView.BestFitColumns();
            gcjin.ExGridView.OptionsBehavior.Editable = false;
            gcjin.ExGridView.OptionsSelection.MultiSelect = true;
            gcjin.ExGridView.OptionsCustomization.AllowSort = false;
            DB.SetNumberFormat(gcjin.ExGridView, "n2");
            tsbtnPrint.Click += new EventHandler(tsbtnPrint_Click);
            MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);
       
          }

        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
            gcjin.ExGridView.BestFitColumns();
        }

        void InvColumnEdit_Enter(object sender, EventArgs e)
        {
            //if (gcjin.ExGridView.GetFocusedRowCellValue("nodsg") == null)
            //{
            //    ((ButtonEdit)sender).Enabled = true;
            //    return;
            //}

            //if (gcjin.ExGridView.GetFocusedRowCellValue("nodsg").ToString() == "")
            //    ((ButtonEdit)sender).Enabled = true;
            //else
            //    ((ButtonEdit)sender).Enabled = false;
        }

        void tsbtnPrint_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepBAP" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_Print('Transaction.FrmTJin','" + this.NoDocument + "')");
            report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
            report.ShowPreview();
        }


      
        void ExGridView_ValidateRow(object sender, ValidateRowEventArgs e)
        {
           
        }

        void ExGridView_New_Click(object sender, EventArgs e)
        {
            //int idx = gcjin.ExGridView.FocusedRowHandle;

            DataRow row = casDataSet.jid.NewRow();
            row["jin"] = NoDocument;
            row["inv"] = "";
            row["remark"] = "";
            //row["no"] = DetailTable.Rows.Count + 1;
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            casDataSet.jid.Rows.Add(row);

            DB.InsertDetailRows(gcjin.ExGridView, row);

        
        }

        void ExGridView_Delete_Click(object sender, EventArgs e)
        {
            DB.DeleteDetailRows(gcjin.ExGridView);
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            gcjin.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcjin.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcjin.ExGridView.OptionsBehavior.Editable = true;
            gcjin.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
        }

        protected override void tsbtnCancel_Click(object sender, EventArgs e)
        {
            DB.CancelDetailRows(DetailTable);

            base.tsbtnCancel_Click(sender, new EventArgs());

            if (this.mode == Mode.View)
            {
                gcjin.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                gcjin.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                gcjin.ExGridView.OptionsBehavior.Editable = false;
                gcjin.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            }
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            DetailTable.Clear();
            plantComboBox.Text = "PLANT 1";
            gcjin.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcjin.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcjin.ExGridView.OptionsBehavior.Editable = true;
            gcjin.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
          
        }

        protected override void tsbtnDelete_Click(object sender, EventArgs e)
        {
            base.tsbtnDelete_Click(sender, e);
            if (Convert.ToInt32(MasterTable.Rows[MasterBindingSource.Position]["delete"]) == 1)
                DB.sql.Execute("Call SP_Delete('JIN'" + ",'" + NoDocument + "')");
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
            
                ((DataRowView)MasterBindingSource.Current).Row["jenis"] = jenisCheckBox.Checked;
      
                this.ValidateChildren();
                if (gcjin.ExGridView.EditingValue != null)
                    gcjin.ExGridView.SetFocusedValue(gcjin.ExGridView.EditingValue);

                 ((DataRowView)MasterBindingSource.Current).Row["group_"] = 6;
             
                for (int i = 0; i < gcjin.ExGridView.RowCount; i++)
                {
                    if (gcjin.ExGridView.GetDataRow(i) != null)
                        if (gcjin.ExGridView.GetDataRow(i).RowState != DataRowState.Deleted)
                        {
                            ExGridView_ValidateRow(sender, new ValidateRowEventArgs(i, gcjin.ExGridView.GetRow(i)));
                            if (!isDetailValid)
                            {
                                throw new Exception("Invalid Kode Barang. Please correct the value");
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
                  //      row["qty"] = (double)row["qty1"];
                    }
                }

                base.tsbtnSave_Click(sender, e);
                string date = ((DateTime)(dateDate.EditValue)).ToString("yyyyMMdd");
                string jurnal = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
                DB.sql.Execute("Call SP_Save(" + date + ",'SCR'" + ",'" + jurnal + "')");

                gcjin.ExGridView.OptionsBehavior.Editable = false;
                gcjin.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                gcjin.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                gcjin.ExToolStrip.Items["tsbtnNew"].Enabled = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void ExGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "inv" && locTextBoxEx.Text != "")
            {
                string query = "select FCariHppScrap('" + locTextBoxEx.Text + "','" + (string)gcjin.ExGridView.GetFocusedRowCellValue("inv") + "'," + dateDate.DateTime.ToString("yyyyMMdd") + ")";
                gcjin.ExGridView.SetFocusedRowCellValue(gcjin.ExGridView.Columns["price"], DB.sql.Select(query).Rows[0][0].ToString());
            }

            if (e.Column.FieldName == "dk")
            {
                if (gcjin.ExGridView.GetFocusedRowCellValue("dk")=="K") 
                {
               //   gcjin.ExGridView.SetFocusedRowCellValue(gcjin.ExGridView.Columns["price"], 0);
                    gcjin.ExGridView.Columns["price"].OptionsColumn.AllowEdit = true;
                    gcjin.ExGridView.Columns["val"].OptionsColumn.AllowEdit = true; 
                }
                 else                 
                {
                    gcjin.ExGridView.Columns["price"].OptionsColumn.AllowEdit = true;
                    gcjin.ExGridView.Columns["val"].OptionsColumn.AllowEdit = true; 
            
                }
                double price = (double)gcjin.ExGridView.GetFocusedRowCellValue("price");
                double qty1 = (double)gcjin.ExGridView.GetFocusedRowCellValue("qty1");
                double val = price * qty1;
                gcjin.ExGridView.SetFocusedRowCellValue(gcjin.ExGridView.Columns["val"], val);
            }
            if (e.Column.FieldName == "qty1" || e.Column.FieldName == "price")
            {
                double price = (double)gcjin.ExGridView.GetFocusedRowCellValue("price");
                double qty1 = (double)gcjin.ExGridView.GetFocusedRowCellValue("qty1");
                double val = price * qty1;
                gcjin.ExGridView.SetFocusedRowCellValue(gcjin.ExGridView.Columns["val"], val);
            }
            if (e.Column.FieldName == "unit" || e.Column.FieldName == "qty1")
            {
                DetailBindingSource.EndEdit();
                string inv = (string)gcjin.ExGridView.GetFocusedRowCellValue("inv");
                string unit = (string)gcjin.ExGridView.GetFocusedRowCellValue("unit");
                double qty1 = (double)gcjin.ExGridView.GetFocusedRowCellValue("qty1");
                if (inv != "" && unit != "")
                    gcjin.ExGridView.SetFocusedRowCellValue(gcjin.ExGridView.Columns["qty"], DB.GetQtyInBaseUom(inv, unit, qty1));
                DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
            }
           //else if (e.Column.FieldName == "val")
             //gcjin.ExGridView.BestFitColumns();

         }

        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gcjin.ExGridView.GetDataRow(e.RowHandle);
            row["jin"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
            //row["no"] = DetailTable.Rows.Count + 1;
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            row["price"] = 0;
            row["qty1"] = 0;
            row["dk"] = "D";
            row["val"] = 0;
            

        }

        private void FrmTScrap_Load(object sender, EventArgs e)
        {
            DataTable dtPlant;
            dtPlant = DB.sql.Select("select * from plant");
            for (int i = 0; i < dtPlant.Rows.Count; i++)
            {
                plantComboBox.Items.Add(dtPlant.Rows[i][1].ToString()); 
            }
   /*
             if (this.Tag.ToString() == "2i2")
                {
                    MasterBindingSource.Filter = "group_=6";
                    MasterTable.Clear();
                    MasterAdapter = DB.sql.SelectAdapter("select * from jin where group_=6 ");
                    MasterAdapter.Fill(MasterTable);

                    base.setMode(Mode.View);
                    MasterBindingSource.MoveLast();

                    PopulateDetail();

                    //gcjin.Enabled = false;
                 }
    */
             Utility.SetSqlInstance(pnlDetail, DB.sql);
             //ctrlSub1.ReadOnly = true;
            if (MasterBindingSource.Position == MasterTable.Rows.Count)
            {
                gcjin.ExGridView.OptionsBehavior.Editable = true;
                gcjin.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                gcjin.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
                gcjin.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            }

            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
         }

        private void PopulateDetail()
        {
            DetailTable.Clear();
            //DetailAdapter = null;

            if (MasterBindingSource.Position < 0 || MasterTable.Rows.Count == 0) return;

            string query = "select * from " + DetailTable.TableName + " where " + DetailTable.Columns[0].ColumnName + "='" + MasterTable.Rows[MasterBindingSource.Position][0].ToString() + "'";
            DetailAdapter = DB.sql.SelectAdapter(query);
            try
            {
                DetailAdapter.Fill(DetailTable);
            }
            catch (Exception ex)
            {
            }
        }

        void priceColumnEdit_Enter(object sender, EventArgs e)
        {
            string dknya = "";
            if (gcjin.ExGridView.GetFocusedRowCellValue("dk") != null)
                dknya = gcjin.ExGridView.GetFocusedRowCellValue("dk").ToString();
             
            if (dknya == "K")
            {
                ((SpinEdit)sender).Properties.ReadOnly = true;
              //  gcjin.ExGridView.Columns["val"].OptionsColumn.AllowEdit = false;
            }
            else
            {
                ((SpinEdit)sender).Properties.ReadOnly =false ;
              //  gcjin.ExGridView.Columns["val"].OptionsColumn.AllowEdit = true;
            }
        }

        private void pnlDetail_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.mode == Mode.Edit)
               DB.sql.Execute("Update jid set price=0, val=0 where jid.jin ='" + NoDocument + "'");

        }

         
    }
}
