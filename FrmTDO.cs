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
    public partial class FrmTDO : CAS.Transaction.BaseTransaction
    {
        private int[] selectedIndex = new int[0];
        private bool isDetailValid = true;
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
                        
            gcDO.ExGridView.Columns["no"].Visible = false;
            gcDO.ExGridView.Columns["doh"].Visible = false;
            gcDO.ExGridView.Columns["okl"].Visible = false;
      
            gcDO.ExGridView.Columns["inv"].ColumnEdit = new GridLookUpEx(DB.sql, "", "", "inv", gcDO.ExGridView, "", true, true, "");
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
            gcDO.ExGridView.Columns["loc"].Caption = "Loc";
            gcDO.ExGridView.Columns["qty"].Caption = "Qty Base Dikirim";
            gcDO.ExGridView.Columns["unit"].Caption = "Unit";
            gcDO.ExGridView.Columns["qty1"].Caption = "Qty";
            gcDO.ExGridView.Columns["etd"].Caption = "Keterangan";

            gcDO.ExGridView.Columns["Unit Base Dikirim"].VisibleIndex = 8;//DetailTable.Columns.IndexOf("qty");
            gcDO.ExGridView.Columns["Unit Base Dikirim"].OptionsColumn.AllowEdit = false;
          
            gcDO.ExGridView.BestFitColumns();
            //tsbtnPrint.Click += new EventHandler(tsbtnPrint_Click);
        }

        void tsmiPrintDirectly_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepdohJual" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_Print('Transaction.FrmTdohJual','" + this.NoDocument + "')");
            report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
         
            report.PrintingSystem.ShowMarginsWarning = false;;
            report.PaperName = "1/2A4";
            report.Print();
        }

        void tsmiPrintPreview_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepdohJual" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_Print('Transaction.FrmTdohJual','" + this.NoDocument + "')");
            report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
         
            report.ShowPreview();
        }

        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base Dikirim");
            if (this.mode == Mode.View)
                okl.ExAutoCheck = false;
            gcDO.ExGridView.BestFitColumns();
        }

        void ExGridView_InvColumnEdit_Enter(object sender, EventArgs e)
        {
            GridLookUpEx invLookUp = gcDO.ExGridView.Columns["inv"].ColumnEdit as GridLookUpEx;
           invLookUp.Query = "Call SP_LookUp('inv')";
            invLookUp.TableName = "inv";
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
                okl.ExAutoCheck = true;
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
                okl.ExAutoCheck = false;
            }
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            ctrlSub.ReadOnly = false;
            okl.Properties.ReadOnly = false;
            okl.ExAutoCheck = true;
            DetailTable.Clear();
            gcDO.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcDO.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcDO.ExGridView.OptionsBehavior.Editable = true;
            gcDO.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            okl.Select();
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
                bool isDuplicate = false;
                for (int i = DetailTable.Rows.Count - 1; i >= 0; i--)
                {
                    string loc = DetailTable.Rows[0]["loc"].ToString();
                    DataRow row = DetailTable.Rows[i];
                    if (row != null && row.RowState != DataRowState.Deleted)
                    {
                        row[0] = NoDocument;
                        if (row["inv"].ToString() == "" || row["loc"].ToString() == "" || loc != row["loc"].ToString())
                            throw new Exception("Kode Barang/Loc tidak valid");
                        //cek duplicate doh Retur
                        if (MasterBindingSource.Position == MasterTable.Rows.Count)
                        {
                            string query = "select dod.* from doh, dod "
                                + "where doh.okl_rms='" + okl.EditValue.ToString()
                                + "' and doh.doh = dod.doh and "
                                + "dod.inv='" + row["inv"].ToString() + "' "
                                + "and dod.remark='" + row["remark"].ToString().Replace("'", "''")
                                + "' and doh.doh not in (select doh from spm)";
                            DataTable dt = DB.sql.Select(query);
                            if (dt.Rows.Count > 0)
                                isDuplicate = true;
                        }
                        //row["no"] = i + 1;
                        //totVal = totVal + (double)row["val"];
                    }
                }

                if (isDuplicate)
                {
                    //MessageBox.Show("doh dengan detail yang sama sudah ada, dan belum dibuat SJ-nya", "Warning", MessageBoxButtons.OK);
                    DialogResult dlgResult = MessageBox.Show("doh dengan detail yang sama sudah ada, dan belum dibuat SJ-nya. Anda yakin untuk menyimpan?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dlgResult != DialogResult.Yes)
                        return;
                }                

                base.tsbtnSave_Click(sender, e);

                if (this.mode == Mode.View)
                {
                    gcDO.ExGridView.OptionsBehavior.Editable = false;
                    gcDO.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                    gcDO.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                    gcDO.ExToolStrip.Items["tsbtnNew"].Enabled = false;

                    okl.Properties.ReadOnly = true;
                    okl.ExAutoCheck = false;
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
            string rms = okl.EditValue.ToString();
            string inv = gcDO.ExGridView.GetFocusedRowCellValue("inv").ToString();
            string remark = gcDO.ExGridView.GetFocusedRowCellValue("remark").ToString();
            //string unitgd = gcDO.ExGridView.GetFocusedRowCellValue("unitgudang").ToString();
            string baseUnit = (string)gcDO.ExGridView.GetFocusedRowCellValue("Unit Base Dikirim");
            DataTable dtOutdoh = DB.sql.Select("Call SP_Outspm('" + okl + "',2)");
            decimal maxValue = 0;
            try
            {
                DataRow dr = dtOutdoh.Select("`Kode Barang`='" + inv + "' and `Nama Barang`='" + remark + "'")[0];
                string query = "select toleransi, sum(qty) as qty from rmd where rms='" + rms + "' and inv='" + inv + "' and remark='" + remark + "' group by rms";
                //double qtyToleransi = DB.GetQtyToleransi("rmd", "rms", rms, inv, remark, unit, "Retur");
                decimal qtySisa = Convert.ToDecimal(dr["Qty SJ"]);
                double qtyToleransi = DB.GetQtyToleransi(query, inv, unit, baseUnit);
                if (unit != dr["Unit SJ"].ToString())
                    //convert Qty & unit dari Outdoh ke Qty & unit inputan di doh
                    qtySisa = Convert.ToDecimal(DB.GetQtyInAlternativeUom(inv, dr["Unit SJ"].ToString(), Convert.ToDouble(qtySisa), unit));
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
            if (e.Column.FieldName == "inv")
            {
                DetailBindingSource.EndEdit();
                DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base Dikirim");
                return;
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
            //ctrlSub.txtSub.EditValueChanged += new EventHandler(txtSub_EditValueChanged);
            //ctrlSub.txtSub.Select();
            //DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base Dikirim");
            //gcDO.ExGridView.BestFitColumns();
        }

        void txtSub_EditValueChanged(object sender, EventArgs e)
        {
            //okl_rmaTextBoxEx.ExSqlQuery = "select * from rms where sub='" + ctrlSub.txtSub.Text + "' and rms not in (select okl_rma as rms from doh)"; 
            //okl_rmaTextBoxEx.ExSqlQuery = "Call SP_Outdoh('" + ctrlSupplier1.txtSub.Text + "', 2)";
        }                       

        private void okl_rkaTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {
            DataRow row = okl.ExGetDataRow();
            if (row == null)
                return;

        //    rmaTextEdit.EditValue = row["PR Retur"];
            ctrlSub.txtSub.EditValue = row["Kode Supplier"];

            if (MasterBindingSource.Position == MasterTable.Select(MasterBindingSource.Filter).Length)
            {
                DetailTable.Clear();
                GridLookUpEx invLookUp = gcDO.ExGridView.Columns["inv"].ColumnEdit as GridLookUpEx;
                //invLookUp.Query = "select rma,inv,remark,loc,unit,qty1,qty,cct,no from rmb where rma='" + okl_rmaTextBoxEx.Text + "'";
                invLookUp.Query = "Call SP_Outdoh('" + okl.EditValue.ToString() + "', 2)";
                invLookUp.TableName = "rmb_in";
                invLookUp.ClickButton();
            }
        }

        private void appdohCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!aprovCheckBox.Enabled || !aprovCheckBox.Checked) return;
            bool canapprove = true;
            for (int i = 0; i <= DetailTable.Rows.Count - 1; i++)
            {
                if (Convert.ToDouble(DetailTable.Rows[i]["qtygudang"]) == 0)
                {
                    canapprove = false;
                }
            }
            if (!canapprove)
            {
                aprovCheckBox.Checked = false;
                MessageBox.Show("doh tidak dapat diapprove karena ada item detail doh yang memiliki qty 0");
            }
        }

        private void appdohLabel_Click(object sender, EventArgs e)
        {

        }

        private void nopolTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmTDO_Load(object sender, EventArgs e)
        {

        }

    
    }
}




