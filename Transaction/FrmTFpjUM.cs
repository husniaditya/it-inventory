using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KASLibrary;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraReports.UI;

namespace CAS.Transaction
{
    public partial class FrmTFpjUM : CAS.Transaction.BaseTransaction
    {
        private bool isDetailChanged = false;
        private double qty1OldValue = 0;
        private DataTable copyDetailTable = new DataTable();
        private DataColumn[] columns;
         
        public FrmTFpjUM()
        {

            
            InitializeComponent();
            maskfpj.Culture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            ToolStripMenuItem tsmiPrintPreview = new ToolStripMenuItem("Print Preview", null, new EventHandler(tsmiPrintPreview_Click));
            ToolStripMenuItem tsmiPrintDirectly = new ToolStripMenuItem("Print Directly", null, new EventHandler(tsmiPrintDirectly_Click));
            ToolStripDropDownButton tsbtnPrint = new ToolStripDropDownButton("Print", null, tsmiPrintPreview, tsmiPrintDirectly);
            tsbtnPrint.Image = MasterNavigator.Items["tsbtnPrint"].Image;
            MasterNavigator.Items.Insert(MasterNavigator.Items.IndexOfKey("tsbtnPrint"), tsbtnPrint);
            MasterNavigator.Items.RemoveByKey("tsbtnPrint"); 

            MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);

            umkSpinEdit.Enabled = false;
            gcxFpjUM.ExGridControl.DataSource = fpjumdBindingSource;
            gcxFpjUM.ExTitleLabel.Text = "Faktur Pajak Uang Muka Detail";
            gcxFpjUM.ExGridView.OptionsView.ShowGroupPanel = false;
            gcxFpjUM.ExGridView.OptionsCustomization.AllowSort = false;


            gcxFpjUM.ExGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(ExGridView_InitNewRow);
            gcxFpjUM.ExGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(ExGridView_CellValueChanged);

            gcxFpjUM.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
            gcxFpjUM.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
            gcxFpjUM.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gcxFpjUM.ExToolStrip.Items["tsbtnNew"].Enabled = false;

            gcxFpjUM.ExGridView.Columns["fpjumk"].Visible = false;
            gcxFpjUM.ExGridView.Columns["nofpj"].Visible = false;
            gcxFpjUM.ExGridView.Columns["no"].Visible = false;
            gcxFpjUM.ExGridView.Columns["oms"].ColumnEdit = new GridLookUpEx(DB.sql, "", "oms", "oms", gcxFpjUM.ExGridView, "", true, true, "Sales Order");
            //gcxFpjUM.ExGridView.Columns["oms"].ColumnEdit =  new GridLookUpEx(DB.sql, "select oms.oms as `oms`, omd.inv as `Kode Barang` ,omd.remark as `Nama Barang`,omd.val as `Val` from oms,omd where oms.oms=omd.oms","inv", "inv", gcxFpjUM.ExGridView, "remark", true, true, "Inventory");
            gcxFpjUM.ExGridView.Columns["oms"].ColumnEdit.Enter += new EventHandler(ExGridView_OmsColumnEdit_Enter);
            gcxFpjUM.ExGridView.Columns["inv"].ColumnEdit = new GridLookUpEx(DB.sql, "select inv as `Kode Barang`,name as `Nama Barang` from inv", "inv", "inv", gcxFpjUM.ExGridView, "Nama Barang", true, true, "Master Barang");
            
            gcxFpjUM.ExGridView.Columns["inv"].OptionsColumn.AllowEdit = false;
            gcxFpjUM.ExGridView.Columns["remark"].OptionsColumn.AllowEdit = false;
            gcxFpjUM.ExGridView.Columns["val"].OptionsColumn.AllowEdit = true;
            
            gcxFpjUM.ExGridView.Columns["oms"].Caption = "Sales Order";
            gcxFpjUM.ExGridView.Columns["inv"].Caption = "Kode Barang";
            gcxFpjUM.ExGridView.Columns["remark"].Caption = "Nama Barang";
            gcxFpjUM.ExGridView.Columns["val"].Caption = "Nilai";
            gcxFpjUM.ExGridView.Columns["qty"].Caption = "Qty";
            gcxFpjUM.ExGridView.Columns["unit"].Caption = "Unit";
            gcxFpjUM.ExGridView.Columns["price"].Caption = "Price";
  
            columns = new DataColumn[3];
            columns[0] = casDataSet.fpjumd.Columns["oms"];
            columns[1] = casDataSet.fpjumd.Columns["inv"];
            columns[2] = casDataSet.fpjumd.Columns["remark"];
            casDataSet.fpjumd.Constraints.Add("aaaa", columns, true);
            
            gcxFpjUM.ExGridView.BestFitColumns();
            gcxFpjUM.ExGridView.OptionsBehavior.Editable = false;
            gcxFpjUM.ExGridView.OptionsSelection.MultiSelect = true;

            gcxFpjUM.ExGridView.Columns["oms"].VisibleIndex = 0;
            gcxFpjUM.ExGridView.Columns["inv"].VisibleIndex = 1; 
            gcxFpjUM.ExGridView.Columns["remark"].VisibleIndex = 2;
            gcxFpjUM.ExGridView.Columns["qty"].VisibleIndex = 3;
            gcxFpjUM.ExGridView.Columns["unit"].VisibleIndex = 4;
            gcxFpjUM.ExGridView.Columns["price"].VisibleIndex = 5;
            gcxFpjUM.ExGridView.Columns["val"].VisibleIndex = 6;

            DB.SetNumberFormat(gcxFpjUM.ExGridView, "n2");

            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
           // tsbtnPrint.Click += new EventHandler(tsbtnPrint_Click);
            

        }

        private void FrmTFpjUM_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'casDataSet.fpjumd' table. You can move, or remove it, as needed.
            //this.fpjumdTableAdapter.Fill(this.casDataSet.fpjumd);
            // TODO: This line of code loads data into the 'casDataSet.fpjumk' table. You can move, or remove it, as needed.
            //this.fpjumkTableAdapter.Fill(this.casDataSet.fpjumk);
            ctrlSub.txtSub.DataBindings.Add("EditValue", MasterBindingSource, "sub");
            ctrlSub.txtSub.EditValueChanged += new EventHandler(txtSub_EditValueChanged);
            gcxFpjUM.ExGridView.BestFitColumns();
            

        }

        void txtSub_EditValueChanged(object sender, EventArgs e)
        {
            DataRow row = ctrlSub.txtSub.ExGetDataRow();
            //if (row == null)
            //    return;
            //curcur.EditValue = row["cur"].ToString();
            if (this.mode != Mode.View && row != null )
            {
                string numfp = maskfpj.Text;
                DataTable dtseriFP = DB.sql.Select("select kodefp from sub where sub='" + ctrlSub.txtSub.EditValue.ToString() + "'");
                maskfpj.Text = dtseriFP.Rows[0][0].ToString() + numfp.Substring(4, 15);
                if (dtseriFP.Rows[0][0].ToString().Trim() == "")
                    maskfpj.Text = "";
            }
           
        }

        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        { 
            gcxFpjUM.ExGridView.BestFitColumns();
        }


        void ExGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {   DataRow row = gcxFpjUM.ExGridView.GetDataRow(e.RowHandle);
            row["fpjumk"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            row["nofpj"] = maskfpj.Text;
        }

        void ExGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "qty" || e.Column.FieldName == "price")
            {
                double qty = (double)gcxFpjUM.ExGridView.GetFocusedRowCellValue("qty");
                double price = (double)gcxFpjUM.ExGridView.GetFocusedRowCellValue("price");
         
                double val = price * qty ;
                gcxFpjUM.ExGridView.SetFocusedRowCellValue(gcxFpjUM.ExGridView.Columns["val"], val);
          
            }
            if (e.Column.FieldName == "val")
            {
                RecalculateTotal();                
            }

        }


        void RecalculateTotal()
        {
            DetailBindingSource.EndEdit();
            double umk = 0;
            
            for (int i = 0; i < DetailTable.Rows.Count; i++)
            {
                if (DetailTable.Rows[i] != null && DetailTable.Rows[i].RowState != DataRowState.Deleted)
                {
                    umk = umk + (double)DetailTable.Rows[i]["val"];
                    
                }
            }
            umkSpinEdit.EditValue = umk; 
        }
        

        void ExGridView_OmsColumnEdit_Enter(object sender, EventArgs e)
        {
          
                GridLookUpEx omsLookUp = (GridLookUpEx)gcxFpjUM.ExGridView.Columns["oms"].ColumnEdit;
                omsLookUp.Query = "call SP_LookUpOKL('okl','"+ctrlSub.txtSub.EditValue.ToString() + "')";
                omsLookUp.TableName = "okl";
              
                RecalculateTotal();

        }

        void ExGridView_Delete_Click(object sender, EventArgs e)
        { 
            bool canDeleteitem, canDelete = true;
            /*int[] selectedIndex = gcxFpjUM.ExGridView.GetSelectedRows();
            for (int i = 0; i < selectedIndex.Length; i++)
            {
                string oms = gcxFpjUM.ExGridView.GetDataRow(selectedIndex[i])["okl"].ToString();
                int no = Convert.ToInt32(gcxFpjUM.ExGridView.GetDataRow(selectedIndex[i])["no"]);
                canDeleteitem = DeleteLineItem(okl, no);
                if (canDeleteitem == false) canDelete = false;
            }
            */
            if (canDelete) DB.DeleteDetailRows(gcxFpjUM.ExGridView);
            RecalculateTotal();
        }

        void ExGridView_New_Click(object sender, EventArgs e)
        {DataRow row = casDataSet.fpjumd.NewRow();
            row["fpjumk"] = NoDocument;
            row["nofpj"] = "";
            row["oms"] = "";
            row["inv"] = "";
            row["val"] = 0;
            row["price"] = 0;
            row["qty"] = 0;
            row["no"] = 0;
            row["remark"] = "";
            row["unit"] = "";

            casDataSet.fpjumd.Rows.Add(row);

            DB.InsertDetailRows(gcxFpjUM.ExGridView, row);
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
           
            fpjdateDateEdit.EditValue = DB.loginDate;
            DetailTable.Clear();
            gcxFpjUM.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcxFpjUM.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcxFpjUM.ExGridView.OptionsBehavior.Editable = true;
            gcxFpjUM.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            FakturPajakGenerate();
        }

        void FakturPajakGenerate()
        {
         //   string lastnum = NoDocument.Substring(0, 9) + Convert.ToString(Convert.ToInt64(NoDocument.Substring(9, 6)) - 1).PadLeft(6, '0');
            //DataTable dtMaxFP = DB.sql.Select("select fpj from klr where substr(fpj,12,8)<>'' and substr(klr,5,2)=" + DB.loginDate.ToString("yy") + " order by right(fpj,11) desc limit 1");
            //DataTable dtMaxFP2 = DB.sql.Select("select nofpj from fpjumk where substr(nofpj,12,8)<>'' and substr(nofpj,9,2)=" + DB.loginDate.ToString("yy") + " order by right(nofpj,11) desc limit 1");
            
            //string numfp = "";
            //string numfp2 = "";
         
            //if (dtMaxFP.Rows.Count > 0)
            //{
            //    numfp = dtMaxFP.Rows[0][0].ToString();
            //    if (dtMaxFP2.Rows.Count > 0 && dtMaxFP2.Rows[0][0].ToString() != "")
            //    {
            //        numfp2 = dtMaxFP2.Rows[dtMaxFP2.Rows.Count - 1][0].ToString();
            //        if (Convert.ToInt64(numfp.Substring(11, 8)) < Convert.ToInt64(numfp2.Substring(11, 8)))
            //            numfp = numfp2;
            //    }
              
            //    numfp = Convert.ToString(Convert.ToInt64(numfp.Substring(11, 8)) + 1).PadLeft(8, '0');

            //}
            DataRow row = ctrlSub.txtSub.ExGetDataRow();
            if (DB.loginDate >= new DateTime(2013, 4, 1) && this.mode == Mode.New)
                maskfpj.Text = DB.sql.Select("SELECT F_getnopajak1('" + ctrlSub.txtSub.EditValue + "')").Rows[0][0].ToString();

            if (this.mode != Mode.View && row != null)
            {
                string numfp = maskfpj.Text;
                DataTable dtseriFP = DB.sql.Select("select kodefp from sub where sub='" + ctrlSub.txtSub.EditValue.ToString() + "'");
                maskfpj.Text = dtseriFP.Rows[0][0].ToString() + numfp.Substring(4, 15);
                if (dtseriFP.Rows[0][0].ToString().Trim() == "")
                    maskfpj.Text = "";

            }
           // maskfpj.Text = Utility.GetConfig("SeriFakturPajak") + DB.loginDate.ToString("yy") + "." + numfp;
                        
            //dateJatuhTempo.Enabled = false;

            //get new number of FP sederhana
            //int lastNum = 1;
            //DataTable dtMaxNum = DB.sql.Select("select max(fpjsederhana) from klr  where fpjsederhana<>'' and substr(klr,5,2)=" + DB.loginDate.ToString("yy"));
            //if (dtMaxNum.Rows.Count > 0 && dtMaxNum.Rows[0][0].ToString() != "")
            //    lastNum = int.Parse(dtMaxNum.Rows[0][0].ToString()) + 1;
            //maskfpjsederhana.Text = lastNum.ToString("00000");
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            if (this.mode == Mode.Edit)
            {
                isDetailChanged = false;
                gcxFpjUM.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
                gcxFpjUM.ExToolStrip.Items["tsbtnNew"].Enabled = true;
                gcxFpjUM.ExGridView.OptionsBehavior.Editable = true;
                gcxFpjUM.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                copyDetailTable.Clear();
                copyDetailTable = DetailTable.Copy();
               /*
                Utility.SetReadOnly(txtSubtotal, true);
                Utility.SetReadOnly(txtTotal, true);
                Utility.SetReadOnly(txtPPN, true);
               */
            }
        }

        void tsmiPrintPreview_Click(object sender, EventArgs e)
        {
            XtraReport report = new XtraReport();
            PrintFP(ref report);
            report.ShowPreview();
        }

        private void PrintFP(ref XtraReport report)
        {
            string path = "";

            if (jenis.EditValue.ToString()=="0")
            {
                path = Application.StartupPath + "\\Reports\\FakturPajakPengganti.repx";
            }
            else if (jenis.EditValue.ToString() == "1")
            {
                path = Application.StartupPath + "\\Reports\\FakturPajakPengganti.repx";
            }
            else if (jenis.EditValue.ToString() == "3")
            {
                path = Application.StartupPath + "\\Reports\\FakturPajakJasa.repx";
            }            
            else
            {
                path = Application.StartupPath + "\\Reports\\FakturPajakCetakStd.repx";
            }
            report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_PrintFPJ('fpj','" + ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text + "')");
          //  if (fpgantiCheckBox.Checked)
            if (jenis.EditValue.ToString() == "1")
            {
                dt = DB.sql.Select("call SP_PrintFPJ('ganti','" + ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text + "')");
                report.DataSource = dt;
            }
            else if (jenis.EditValue.ToString() == "2")
            {
                dt = DB.sql.Select("call SP_PrintFPJ('standart','" + ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text + "')");
                report.DataSource = dt;
            }
            else if (jenis.EditValue.ToString() == "3")
            {
                dt = DB.sql.Select("call SP_PrintFPJ('standart','" + ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text + "')");
                report.DataSource = dt;
            }
            else
            {
                dt = SplitInvName(dt, 100);
                //modify data table (1 page report = 10 detail, add subtotal from prev page)
                DateTime fpjDate;// = DateTime.Today;
                DataTable dtRep = dt.Clone();
                if (dt.Rows.Count > 15)
                {
                    double subtotal = 0;
                    int rowcount = 1;
                    foreach (DataRow dr in dt.Rows)
                    {
                        fpjDate = (DateTime)dr["fpjdate"];
                        subtotal = subtotal + Convert.ToDouble(dr["subtotal"]);
                        if ((rowcount % 15 == 0) && (dr != dt.Rows[dt.Rows.Count - 1]))
                        {
                            dtRep.ImportRow(dr);
                            //add new row
                            DataRow drRep = dtRep.NewRow();
                            drRep["invname"] = "SALDO HALAMAN : ";
                            drRep["subtotal"] = subtotal;
                            drRep["umk"] = 0;
                            drRep["dpp"] = 0;
                            drRep["ppn"] = 0;
                            drRep["disc"] = 0;
                            drRep["fpjdate"] = fpjDate;
                            drRep["kurs"] = 0;
                            drRep["cur"] = "";
                            drRep["kmkno"] = dt.Rows[0]["kmkno"];
                            dtRep.Rows.Add(drRep);
                            rowcount = 2;
                        }
                        else
                        {
                            dtRep.ImportRow(dr);
                            rowcount++;
                        }
                    }
                }
                else
                    dtRep = dt.Copy();

                //to add empty rows to datatable 
                int jumToAdd = 15 - (dtRep.Rows.Count % 15);
                if (dtRep.Rows.Count % 15 == 0) jumToAdd = 0;
                //add empty rows
                for (int i = 0; i < jumToAdd; i++)
                {
                    DataRow drRep = dtRep.NewRow();
                    drRep["invname"]  = "";
                    drRep["subtotal"] = 0;
                    drRep["umk"] = 0;
                    drRep["dpp"] = 0;
                    drRep["ppn"] = 0;
                    drRep["disc"] = 0;
                    //seragamkan tgl FP dgn record lainnya
                    drRep["fpjdate"] = dtRep.Rows[0]["fpjdate"];
                    drRep["kurs"] = dtRep.Rows[0]["kurs"];
                    drRep["cur"] = dtRep.Rows[0]["cur"];
                    drRep["kmkno"] = dt.Rows[0]["kmkno"];
                    dtRep.Rows.Add(drRep);
                }

                //if (dtRep.Rows[dtRep.Rows.Count - 1]["sub"].ToString() == "")
                //{
                //    dtRep.Rows[dtRep.Rows.Count - 1].Delete();
                //    //pageNo--;
                //}

                report.DataSource = dtRep;
            }
          //  report.Bands[BandKind.PageHeader].Controls["lblNamaKenaPajak"].Text = Utility.GetConfig("CompanyName");
          //  report.Bands[BandKind.PageHeader].Controls["lblAlamatKenaPajak"].Text = Utility.GetConfig("CompanyAddr");
              report.Bands[BandKind.PageHeader].Controls["lblNPWP"].Text = Utility.GetConfig("CompanyNPWP");
            //report.Bands[BandKind.PageHeader].Controls["lblTglPKP"].Text = Utility.GetConfig("CompanyTglPKP");
         //   report.Bands[BandKind.PageFooter].Controls["lblNama"].Text = Utility.GetConfig("KabagAcc");
        }

        private DataTable SplitInvName(DataTable dt, int charLen)
        {
            DataTable retDt = dt.Clone();
            foreach (DataRow dr in dt.Rows)
            {
                string invname = dr["invname"].ToString();
                DataRow retDr;
                int ctr = 1;
                while (invname.Length > charLen)
                {
                    retDr = retDt.NewRow();
                    foreach (DataColumn col in dt.Columns)
                        retDr[col.ColumnName] = dr[col.ColumnName];
                    retDr["invname"] = invname.Substring(0, charLen);
                    //empty inv, qty, unit, subtotal on second, third, ... record
                    if (ctr > 1)
                    {
                        retDr["inv"] = "";
                        retDr["qty"] = 0;
                        retDr["unit"] = "";
                        retDr["subtotal"] = 0;
                        retDr["ppn"] = 0;
                        retDr["dpp"] = 0;
                    }
                    retDt.Rows.Add(retDr);
                    invname = invname.Substring(charLen);
                    ctr++;
                }
                retDr = retDt.NewRow();
                foreach (DataColumn col in dt.Columns)
                    retDr[col.ColumnName] = dr[col.ColumnName];
                retDr["invname"] = invname;
                if (ctr > 1)
                {
                    retDr["inv"] = "";
                    retDr["qty"] = 0;
                    retDr["unit"] = "";
                    retDr["subtotal"] = 0;
                    retDr["ppn"] = 0;
                    retDr["dpp"] = 0;
                }
                retDt.Rows.Add(retDr);
            }
            return retDt;
        }

        void tsmiPrintDirectly_Click(object sender, EventArgs e)
        {
            XtraReport report = new XtraReport();
            PrintFP(ref report);
            report.PrintingSystem.ShowMarginsWarning = false;
            report.PaperName = "FP";
            report.Print();
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (this.mode == Mode.New)
                {
                    FakturPajakGenerate();
                    txtSub_EditValueChanged(sender, e);
                  //  fpgantiCheckBox_CheckedChanged(sender, e); 
 
                }
                // Validate controls
                this.ValidateChildren();

                if (gcxFpjUM.ExGridView.EditingValue != null)
                    gcxFpjUM.ExGridView.SetFocusedValue(gcxFpjUM.ExGridView.EditingValue);

               
                if (ctrlSub.txtSub.EditValue.ToString() == "")
                    throw new Exception("Please select Customer");

                DetailBindingSource.EndEdit();

                
                base.tsbtnSave_Click(sender, e);

                
                if (this.mode == Mode.View)
                {
                
                    gcxFpjUM.ExGridView.OptionsBehavior.Editable = false;
                    gcxFpjUM.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                    gcxFpjUM.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                    gcxFpjUM.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void curcur_EditValueChanged(object sender, EventArgs e)
        {

        }
        
        private void fpgantiCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //if (fpgantiCheckBox.Checked)
            //{
            //    gcxFpjUM.ExGridView.Columns["inv"].OptionsColumn.AllowEdit = true;
            //    gcxFpjUM.ExGridView.Columns["remark"].OptionsColumn.AllowEdit = true;
            //    gcxFpjUM.ExGridView.Columns["val"].OptionsColumn.AllowEdit = true;
            //    gcxFpjUM.ExGridView.Columns["oms"].OptionsColumn.AllowEdit = false;
            //    label2.Text = "Atas Faktur Pajak Nomor";
            //    maskfpj.Text = "011" + maskfpj.Text.Substring(4, 15);
            //}
            //else
            //{
            //    gcxFpjUM.ExGridView.Columns["inv"].OptionsColumn.AllowEdit = false;
            //    gcxFpjUM.ExGridView.Columns["remark"].OptionsColumn.AllowEdit = false;
            //    gcxFpjUM.ExGridView.Columns["val"].OptionsColumn.AllowEdit = true;
            //    gcxFpjUM.ExGridView.Columns["oms"].OptionsColumn.AllowEdit = true;
            //    label2.Text = "Keterangan";
            //    string numfp = maskfpj.Text;
            //    DataTable dtseriFP = DB.sql.Select("select kodefp from sub where sub='" + ctrlSub.txtSub.EditValue.ToString() + "'");
            //    maskfpj.Text = dtseriFP.Rows[0][0].ToString() + numfp.Substring(4, 15);
            //    if (dtseriFP.Rows[0][0].ToString().Trim() == "")
            //        maskfpj.Text = "";
            //  //  maskfpj.Text = "010" + maskfpj.Text.Substring(4, 15);
            //}
          
        }

        private void jenis_SelectedIndexChanged(object sender, EventArgs e)
        {
              if (jenis.EditValue.ToString()=="1")
              {
                gcxFpjUM.ExGridView.Columns["inv"].OptionsColumn.AllowEdit = true;
                gcxFpjUM.ExGridView.Columns["remark"].OptionsColumn.AllowEdit = true;
                gcxFpjUM.ExGridView.Columns["val"].OptionsColumn.AllowEdit = true;
                gcxFpjUM.ExGridView.Columns["oms"].OptionsColumn.AllowEdit = false;
                label2.Text = "Atas Faktur Pajak Nomor";
                maskfpj.Text = "011" + maskfpj.Text.Substring(4, 15);
            }
            else if (jenis.EditValue.ToString()=="0")         
            {
                gcxFpjUM.ExGridView.Columns["inv"].OptionsColumn.AllowEdit = false;
                gcxFpjUM.ExGridView.Columns["remark"].OptionsColumn.AllowEdit = false;
                gcxFpjUM.ExGridView.Columns["val"].OptionsColumn.AllowEdit = true;
                gcxFpjUM.ExGridView.Columns["oms"].OptionsColumn.AllowEdit = true;
                label2.Text = "Keterangan";
                string numfp = maskfpj.Text;
                DataTable dtseriFP = DB.sql.Select("select kodefp from sub where sub='" + ctrlSub.txtSub.EditValue.ToString() + "'");
                maskfpj.Text = dtseriFP.Rows[0][0].ToString() + numfp.Substring(4, 15);
                if (dtseriFP.Rows[0][0].ToString().Trim() == "")
                    maskfpj.Text = "";
                //  maskfpj.Text = "010" + maskfpj.Text.Substring(4, 15);
            }
            else
            {
                gcxFpjUM.ExGridView.Columns["inv"].OptionsColumn.AllowEdit = true;
                gcxFpjUM.ExGridView.Columns["remark"].OptionsColumn.AllowEdit = true;
                gcxFpjUM.ExGridView.Columns["val"].OptionsColumn.AllowEdit = true;
                gcxFpjUM.ExGridView.Columns["oms"].OptionsColumn.AllowEdit = true;
                label2.Text = "Keterangan";
                string numfp = maskfpj.Text;
                DataTable dtseriFP = DB.sql.Select("select kodefp from sub where sub='" + ctrlSub.txtSub.EditValue.ToString() + "'");
                maskfpj.Text = dtseriFP.Rows[0][0].ToString() + numfp.Substring(4, 15);
                if (dtseriFP.Rows[0][0].ToString().Trim() == "")
                    maskfpj.Text = "";
            }
    
        }

    }
}

