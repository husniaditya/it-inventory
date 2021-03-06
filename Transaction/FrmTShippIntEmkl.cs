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
    public partial class FrmTShippIntEmkl : BaseTransaction
    {
        public FrmTShippIntEmkl()
        {
            InitializeComponent();
            ToolStripMenuItem tsmiPrintPreview = new ToolStripMenuItem("Print Preview", null, new EventHandler(tsmiPrintPreview_Click));
            ToolStripMenuItem tsmiPrintDirectly = new ToolStripMenuItem("Print Directly", null, new EventHandler(tsmiPrintDirectly_Click));
            ToolStripDropDownButton tsbtnPrint = new ToolStripDropDownButton("Print", null, tsmiPrintPreview, tsmiPrintDirectly);
            tsbtnPrint.Image = MasterNavigator.Items["tsbtnPrint"].Image;
            MasterNavigator.Items.Insert(MasterNavigator.Items.IndexOfKey("tsbtnPrint"), tsbtnPrint);
            MasterNavigator.Items.RemoveByKey("tsbtnPrint");
          
            gckon.ExGridControl.DataSource = shdBindingSource;

            gckon.ExGridView.OptionsView.ShowGroupPanel = false; 
            gckon.ExTitleLabel.Text = "Detail Shipping Intruction";
            gckon.ExGridView.OptionsCustomization.AllowSort = false;

            gckon.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
            gckon.ExGridView.CellValueChanged += new CellValueChangedEventHandler(ExGridView_CellValueChanged);
           
         
            gckon.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
            gckon.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
            gckon.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gckon.ExToolStrip.Items["tsbtnNew"].Enabled = false;

            gckon.ExGridView.Columns["shp"].OptionsColumn.AllowEdit = false;
            gckon.ExGridView.Columns["inv"].OptionsColumn.AllowEdit = true;
            gckon.ExGridView.Columns["numcon"].OptionsColumn.AllowEdit = true;
            gckon.ExGridView.Columns["remark"].OptionsColumn.AllowEdit = true;
            gckon.ExGridView.Columns["no"].Visible = false;
            gckon.ExGridView.Columns["shp"].Visible = false;
            gckon.ExGridView.Columns["inv"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('inv')", "", "inv", gckon.ExGridView, "", true, true, "Inventory");
            gckon.ExGridView.Columns["unit"].ColumnEdit = new GridLookUpUnit(gckon.ExGridView);
          
            
            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);

            gckon.ExGridView.Columns["inv"].Caption = "Kode Barang";
            gckon.ExGridView.Columns["remark"].Caption = "Nama Barang";
            gckon.ExGridView.Columns["qty"].Caption = "Quantity";
            gckon.ExGridView.Columns["unit"].Caption = "Unit";
            gckon.ExGridView.Columns["numcon"].Caption = "Number Of Container";
            gckon.ExGridView.Columns["nocon"].Caption = "Container/Seal No";

            gckon.ExGridView.BestFitColumns();
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
            row["shp"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
             row["no"] = DB.GetRowCount(DetailTable) + 1;
            row["qty"] = 0;
        }

        void ExGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
         
        }

        void ExGridView_New_Click(object sender, EventArgs e)
        {
            DataRow row = casDataSet.shd.NewRow();
            row["shp"] = NoDocument;
            row["inv"] = "";
            row["remark"] = "";
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            casDataSet.shd.Rows.Add(row);

            DB.InsertDetailRows(gckon.ExGridView, row);
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            DetailTable.Clear();
            gckon.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gckon.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gckon.ExGridView.OptionsBehavior.Editable = true;
            gckon.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            Shippermemo.EditValue = "PT BARAMUDA BAHARI \r\n" +
                                      "DESA WONOKOYO, KEC. BEJI \r\n" +
                                      "PASURUAN, JAWA TIMUR \r\n" +
                                      "INDONESIA" ;
                                     
            Utility.SetReadOnly(txtSubtotal, true);
          
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            gckon.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gckon.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gckon.ExGridView.OptionsBehavior.Editable = true;
            gckon.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            Utility.SetReadOnly(txtSubtotal, true);
           
        }

        private void FrmTProforma_Load(object sender, EventArgs e)
        {
    
            Utility.SetSqlInstance(pnlDetail, DB.sql);

            ctrlSub.txtSub.DataBindings.Add("EditValue", shpBindingSource, "sub");
      //      ctrlSub1.txtSub.DataBindings.Add("EditValue", shpBindingSource, "shipper");
            ctrlSub2.txtSub.DataBindings.Add("EditValue", shpBindingSource, "to");
            ctrlSub3.txtSub.DataBindings.Add("EditValue", shpBindingSource, "emkl");
            ctrlSub.txtSub.EditValueChanged += new EventHandler(txtSub_EditValueChanged);
        
            Utility.SetNumberFormat(pnlTotal, "n2");
            ReCalculateTotal();


        }

        void txtSub_EditValueChanged(object sender, EventArgs e)
        {
            DataRow row = ctrlSub.txtSub.ExGetDataRow();
            if (row == null)
                return;
              
        }

      
        void ReCalculateTotal()
        {
            DetailBindingSource.EndEdit();

            double subTotal = 0;
            for (int i = 0; i < DetailTable.Rows.Count; i++)
            {
                if (DetailTable.Rows[i] != null && DetailTable.Rows[i].RowState != DataRowState.Deleted)
                {
                    subTotal = subTotal + (double)DetailTable.Rows[i]["qty"];
                }
            }
            txtSubtotal.EditValue = subTotal;                       

        
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

        private void curcur_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void curLabel1_Click(object sender, EventArgs e)
        {

        }

        private void kursLabel_Click(object sender, EventArgs e)
        {

        }

        private void curkurs_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void xtraTabPage3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnvTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {
            if (this.mode != Mode.View && this.pnvTextBoxEx.Text != "")
            {
                ctrlSub.txtSub.EditValue = pnvTextBoxEx.ExGetDataRow()["Kode"].ToString();
                notifyMemoEdit.EditValue = pnvTextBoxEx.ExGetDataRow()["Notify"];

                DataTable dtpnd = DB.sql.Select("select * from pnd where pnv='" + pnvTextBoxEx.Text + "'");
                
                int tNo = 9999;
                foreach (DataRow dr in DetailTable.Rows)
                {
                    dr["no"] = tNo;
                    dr.Delete();
                    tNo++;
                }

                int no = 1;
                foreach (DataRow drpnd in dtpnd.Rows)
                {
                    DataRow drshd = DetailTable.NewRow();
                    drshd["shp"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
                    drshd["no"] = no;
                    drshd["inv"] = drpnd["inv"];
                    drshd["remark"] = drpnd["remark"];
                    drshd["qty"] = drpnd["qty"];
                    drshd["unit"] = drpnd["unit"];
                    DetailTable.Rows.Add(drshd);
                    no++;
                }
                gckon.ExGridControl.DataSource = DetailTable;
                gckon.ExGridView.Columns["inv"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('inv')", "", "inv", gckon.ExGridView, "", true, true, "Inventory");
                gckon.ExGridView.Columns["unit"].ColumnEdit = new GridLookUpUnit(gckon.ExGridView);
                gckon.ExGridView.Columns["inv"].Caption = "Kode Barang";
                gckon.ExGridView.Columns["remark"].Caption = "Nama Barang";
                gckon.ExGridView.Columns["qty"].Caption = "Quantity";
                gckon.ExGridView.Columns["unit"].Caption = "Unit";
                gckon.ExGridView.Columns["numcon"].Caption = "Number Of Container";
                gckon.ExGridView.Columns["nocon"].Caption = "Container/Seal No";

                gckon.ExGridView.BestFitColumns();
                gckon.ExGridView.Columns["remark"].Width = 300;
                gckon.ExGridView.OptionsSelection.MultiSelect = true;
                gckon.ExGridView.OptionsCustomization.AllowSort = false;
                DB.SetNumberFormat(gckon.ExGridView, "n2");
                gckon.ExGridView.OptionsBehavior.Editable = true;
                gckon.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                gckon.ExGridView.Columns["no"].Visible = false;
                gckon.ExGridView.Columns["shp"].Visible = false;

              
            }
           
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

                base.tsbtnSave_Click(sender, e);
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
            string path = Application.StartupPath + "\\Reports\\" + "RepShipping" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_Print('Transaction.FrmTShippIntEmkl','" + this.NoDocument + "')");
            //  report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
            report.Print();
        }

        void tsmiPrintPreview_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepShipping" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_Print('Transaction.FrmTShippIntEmkl','" + this.NoDocument + "')");
            //   report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;

            report.ShowPreview();
        }

      

      

      

    }
}

