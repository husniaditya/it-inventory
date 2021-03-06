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
    public partial class FrmTDO : BaseTransaction
    {
        private int[] selectedIndex = new int[0];
        private bool isDetailValid = true;
        private DataTable copyDetailTable = new DataTable();

        public FrmTDO()
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
            gcDO.ExGridControl.DataSource = dodBindingSource;
            gcDO.ExTitleLabel.Text = "Delivery Order";
            gcDO.ExGridView.OptionsView.ShowGroupPanel = false;
            gcDO.ExGridView.OptionsCustomization.AllowSort = false;

            gcDO.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
            gcDO.ExGridView.CellValueChanged += new CellValueChangedEventHandler(ExGridView_CellValueChanged);
            //gcDO.ExGridView.ValidateRow += new ValidateRowEventHandler(ExGridView_ValidateRow);

            gcDO.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
            gcDO.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
            gcDO.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gcDO.ExToolStrip.Items["tsbtnNew"].Enabled = false;

            gcDO.ExGridView.Columns["doh"].OptionsColumn.AllowEdit = false;
            gcDO.ExGridView.Columns["qty"].OptionsColumn.AllowEdit = false;
            gcDO.ExGridView.Columns["nodsg"].OptionsColumn.AllowEdit = false;
            gcDO.ExGridView.Columns["spesifikasi"].OptionsColumn.AllowEdit = false;
                        
            gcDO.ExGridView.Columns["no"].Visible = false;
            gcDO.ExGridView.Columns["doh"].Visible = false;
            gcDO.ExGridView.Columns["okl"].Visible = false;

            gcDO.ExGridView.Columns["inv"].ColumnEdit = new GridLookUpEx(DB.sql, "select inv as `Kode Barang`, name as `Nama Barang`,spesifikasi as Spesifikasi,unit as `Unit Base Dikirim` from inv", "inv", "inv", gcDO.ExGridView, "", true, true, "Master Material");
            gcDO.ExGridView.Columns["inv"].ColumnEdit.Enter += new EventHandler(ExGridView_InvColumnEdit_Enter);
            gcDO.ExGridView.Columns["loc"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('loc')", "loc", "loc", gcDO.ExGridView, "",false, false, "Location");
            gcDO.ExGridView.Columns["unit"].ColumnEdit = new GridLookUpUnit(gcDO.ExGridView);
            
            gcDO.ExGridView.Columns["qty1"].ColumnEdit = new GridNumEx();
         
            gcDO.ExGridView.OptionsBehavior.Editable = false;
            gcDO.ExGridView.OptionsSelection.MultiSelect = true;

            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            //tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);

            gcDO.ExGridView.Columns["inv"].Caption = "Kode Barang";
            gcDO.ExGridView.Columns["remark"].Caption = "Nama Barang";
            gcDO.ExGridView.Columns["nodsg"].Caption = "No Batch";
            gcDO.ExGridView.Columns["spesifikasi"].Caption = "Spesifikasi";
            gcDO.ExGridView.Columns["loc"].Caption = "Loc";
            gcDO.ExGridView.Columns["qty"].Caption = "Qty Base Dikirim";
            gcDO.ExGridView.Columns["unit"].Caption = "Unit";
            gcDO.ExGridView.Columns["qty1"].Caption = "Qty";
            gcDO.ExGridView.Columns["etd"].Caption = "Keterangan";

            gcDO.ExGridView.Columns["inv"].VisibleIndex = 0;
            gcDO.ExGridView.Columns["remark"].VisibleIndex = 1;
            gcDO.ExGridView.Columns["spesifikasi"].VisibleIndex = 2;
            gcDO.ExGridView.Columns["nodsg"].VisibleIndex = 3;
            gcDO.ExGridView.Columns["loc"].VisibleIndex = 4;
            gcDO.ExGridView.Columns["qty1"].VisibleIndex = 5;
            gcDO.ExGridView.Columns["unit"].VisibleIndex = 6;
            gcDO.ExGridView.Columns["qty"].VisibleIndex = 7;

            gcDO.ExGridView.Columns["Unit Base Dikirim"].VisibleIndex = 8;//DetailTable.Columns.IndexOf("qty");
            gcDO.ExGridView.Columns["Unit Base Dikirim"].OptionsColumn.AllowEdit = false;
          
            gcDO.ExGridView.BestFitColumns();
            //tsbtnPrint.Click += new EventHandler(tsbtnPrint_Click);
        }

      
        void tsmiPrintDirectly_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepDo" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_Print('Transaction.FrmTDo','" + this.NoDocument + "')");
            report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
         
            report.PrintingSystem.ShowMarginsWarning = false;;
            report.PaperName = "1/2A4";
            report.Print();
        }

        void tsmiPrintPreview_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepDo" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_Print('Transaction.FrmTDo','" + this.NoDocument + "')");
            report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
         
            report.ShowPreview();
        }

        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base Dikirim");
            if (this.mode == Mode.View)
                okl_texboxex.ExAutoCheck = false;
            gcDO.ExGridView.BestFitColumns();
        }

        void ExGridView_InvColumnEdit_Enter(object sender, EventArgs e)
        {
            GridLookUpEx invLookUp = gcDO.ExGridView.Columns["inv"].ColumnEdit as GridLookUpEx;
            if (okl_texboxex.EditValue.ToString() != "")
            {
                invLookUp.Query = "Call SP_LookUpSPBPO_TDO('invokl','" + okl_texboxex.EditValue.ToString() + "')";
                invLookUp.TableName = "inv";
            }
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
            DataRow row = casDataSet.dod.NewRow();
            row["doh"] = NoDocument;
            row["qty"] = 0;
            row["qty1"] = 0;
            row["inv"] = "";
            row["loc"] = "";
            row["unit"] = "";
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            casDataSet.dod.Rows.Add(row);

            DB.InsertDetailRows(gcDO.ExGridView, row);
        }

        void ExGridView_Delete_Click(object sender, EventArgs e)
        {
            bool canDeleteitem, canDelete = true;
            int[] selectedIndex = gcDO.ExGridView.GetSelectedRows();
            for (int i = 0; i < selectedIndex.Length; i++)
            {
                string prq = gcDO.ExGridView.GetDataRow(selectedIndex[i])["doh"].ToString();
                int no = Convert.ToInt32(gcDO.ExGridView.GetDataRow(selectedIndex[i])["no"]);
                canDeleteitem = DeleteLineItem(prq, no);
                if (canDeleteitem == false) canDelete = false;
            }
            if (canDelete) DB.DeleteDetailRows(gcDO.ExGridView);
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            if (this.mode == Mode.Edit)
            {
                ctrlSub.ReadOnly = false;
                //okl_rkaTextBoxEx.Properties.ReadOnly = true;
                okl_texboxex.ExAutoCheck = true;
                gcDO.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
                gcDO.ExToolStrip.Items["tsbtnNew"].Enabled = true;
                gcDO.ExGridView.OptionsBehavior.Editable = true;
                gcDO.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            }
        }

        protected override void tsbtnCancel_Click(object sender, EventArgs e)
        {
            DB.CancelDetailRows(DetailTable);

            base.tsbtnCancel_Click(sender, new EventArgs());

            if (this.mode == Mode.View)
            {
                gcDO.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                gcDO.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                gcDO.ExGridView.OptionsBehavior.Editable = false;
                gcDO.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                ctrlSub.ReadOnly = true;
                DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base Dikirim");
                okl_texboxex.ExAutoCheck = false;
            }
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            ctrlSub.ReadOnly = false;
            okl_texboxex.Properties.ReadOnly = false;
            okl_texboxex.ExAutoCheck = true;
            DetailTable.Clear();
            gcDO.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcDO.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcDO.ExGridView.OptionsBehavior.Editable = true;
            gcDO.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            okl_texboxex.Select();
          
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate controls
                this.ValidateChildren();

                // Check Required Entries
                //if (nopolTextEdit.Text.Trim() == "")
                //    throw new Exception("No polisi harus diisi");

                // set group_ to 2
                ((DataRowView)MasterBindingSource.Current).Row["group_"] = 1;

                DetailBindingSource.EndEdit();
              
                //double totVal = 0;
                for (int i = DetailTable.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = DetailTable.Rows[i];

                    if (row != null && row.RowState != DataRowState.Deleted)
                    {
                        row["okl"] = okl_texboxex.EditValue.ToString();
                    }
                }

                base.tsbtnSave_Click(sender, e);

                if (this.mode == Mode.View)
                {
                    gcDO.ExGridView.OptionsBehavior.Editable = false;
                    gcDO.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                    gcDO.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                    gcDO.ExToolStrip.Items["tsbtnNew"].Enabled = false;

                    okl_texboxex.Properties.ReadOnly = true;
                    okl_texboxex.ExAutoCheck = false;
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
            string rms = okl_texboxex.EditValue.ToString();
            string inv = gcDO.ExGridView.GetFocusedRowCellValue("inv").ToString();
            string remark = gcDO.ExGridView.GetFocusedRowCellValue("remark").ToString();
            //string unitgd = gcDO.ExGridView.GetFocusedRowCellValue("unitgudang").ToString();
            string baseUnit = (string)gcDO.ExGridView.GetFocusedRowCellValue("Unit Base Dikirim");
            DataTable dtOutdoh = DB.sql.Select("Call SP_Outspm('" + okl_texboxex.EditValue.ToString() + "',20)");
            decimal maxValue = 0;
            decimal qtySisa = 0;
            try
            {
                if (dtOutdoh.Rows.Count == 0)
                    qtySisa = 0;
                else
                {
                    DataRow dr = dtOutdoh.Select("`Kode Barang`='" + inv + "' and `Nama Barang`='" + remark + "'")[0];
                    //double qtyToleransi = DB.GetQtyToleransi("rmd", "rms", rms, inv, remark, unit, "Retur");
                    qtySisa = Convert.ToDecimal(dr["Qty"]);
                    //if (unit != dr["Unit"].ToString())
                    //    //convert Qty & unit dari Outdoh ke Qty & unit inputan di doh
                    //    qtySisa = Convert.ToDecimal(DB.GetQtyInAlternativeUom(inv, dr["Unit"].ToString(), Convert.ToDouble(qtySisa), unit));

                }
                string query = "select toleransi as toleransi, sum(qty) as qty from okd where okl='" + rms + "' and inv='" + inv + "' and remark='" + remark + "' group by okl";
                double qtyToleransi = DB.GetQtyToleransi(query, inv, unit, baseUnit);
                //if (unit != dr["Unit"].ToString())
                //    //convert Qty & unit dari Outdoh ke Qty & unit inputan di doh
                //    qtySisa = Convert.ToDecimal(DB.GetQtyInAlternativeUom(inv, dr["Unit"].ToString(), Convert.ToDouble(qtySisa), unit));
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
            string inv = (string)gcDO.ExGridView.GetFocusedRowCellValue("inv");
            string unit = (string)gcDO.ExGridView.GetFocusedRowCellValue("unit");
            double qty = Convert.ToDouble(gcDO.ExGridView.GetFocusedRowCellValue("qty1"));
                   
            if (e.Column.FieldName == "inv")
            {
                DetailBindingSource.EndEdit();
                DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base Dikirim");
                return;
            }

            if (e.Column.FieldName == "qty1" || e.Column.FieldName == "unit")
            {
                //if (inv != "" && unit != "")
                //    gcDO.ExGridView.SetFocusedRowCellValue(gcDO.ExGridView.Columns["qty"], DB.GetQtyInBaseUom(inv, unit, qty));
                string okl1 = okl_texboxex.EditValue.ToString() ;
                int no = Convert.ToInt32(gcDO.ExGridView.GetFocusedRowCellValue("no"));
             
                if (unit != "" && qty > 0)
                {
                    decimal maxQty = GetMaxValueQtyDikirim(unit);
                    if (this.mode == Mode.Edit)
                    {
                        try
                        {
                            DataRow drCopyDetailTable;
                            drCopyDetailTable = copyDetailTable.Select("no=" + no.ToString())[0];
                            maxQty = maxQty + Convert.ToDecimal(drCopyDetailTable["qty1"]); ;
                        }
                        catch { }
                    }
                    if (Convert.ToDecimal(qty) > maxQty && okl1 != "")
                    {
                        MessageBox.Show("Qty SJ melebihi batas toleransi SO. Max qty SJ: " + maxQty.ToString() + " " + unit);
                        gcDO.ExGridView.SetFocusedRowCellValue(gcDO.ExGridView.Columns["qty1"], maxQty);
                        qty = Convert.ToDouble(maxQty);
          
                    }
                }
                if (inv != "" && unit != "")
                    gcDO.ExGridView.SetFocusedRowCellValue(gcDO.ExGridView.Columns["qty"], DB.GetQtyInBaseUom(inv, unit, qty));
               
                
            }
          
          
        }

        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gcDO.ExGridView.GetDataRow(e.RowHandle);
            row["doh"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
            //row["no"] = DetailTable.Rows.Count + 1;
            row["no"] = DB.GetRowCount(DetailTable) + 1;
        }


        private void FrmTdoh_Load(object sender, EventArgs e)
        {
            ctrlSub.txtSub.DataBindings.Add("EditValue", MasterBindingSource, "sub");
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base Dikirim");
            ctrlSub.txtSub.EditValueChanged += new EventHandler(txtSub_EditValueChanged);
            ctrlSub.txtSub.Select();
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base Dikirim");
            gcDO.ExGridView.BestFitColumns();
            
         }

        void txtSub_EditValueChanged(object sender, EventArgs e)
        {
            //okl_rmaTextBoxEx.ExSqlQuery = "select * from rms where sub='" + ctrlSub.txtSub.Text + "' and rms not in (select okl_rma as rms from doh)"; 
            //okl_rmaTextBoxEx.ExSqlQuery = "Call SP_Outdoh('" + ctrlSupplier1.txtSub.Text + "', 2)";
        }                       


        private void appdohLabel_Click(object sender, EventArgs e)
        {

        }

        private void nopolTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void angkutanTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void okl_texboxex_EditValueChanged(object sender, EventArgs e)
        {
            DataRow row = okl_texboxex.ExGetDataRow();
            if (row == null)
                return;
           
            ctrlSub.txtSub.EditValue = row["Kode Customer"];
            DetailTable.Clear();
            GridLookUpEx invLookUp = gcDO.ExGridView.Columns["inv"].ColumnEdit as GridLookUpEx;
            if (okl_texboxex.EditValue.ToString() != "" && this.mode != Mode.View)
            {
                invLookUp.Query = "Call SP_LookUpSPBPO_TDO('invokl','" + okl_texboxex.EditValue.ToString() + "')";
                invLookUp.TableName = "inv";
                invLookUp.ClickButton();
            }
         }    
    
    }
}




