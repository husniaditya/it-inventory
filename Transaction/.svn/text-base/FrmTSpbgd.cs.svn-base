using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using KASLibrary;
using DevExpress.XtraReports.UI;

namespace CAS.Transaction
{
    public partial class FrmTSpbgd : CAS.Transaction.BaseTransaction
    {
        public FrmTSpbgd()
        {
            {
                InitializeComponent();

                ToolStripMenuItem tsmiPrintPreview = new ToolStripMenuItem("Print Preview", null, new EventHandler(tsmiPrintPreview_Click));
                ToolStripMenuItem tsmiPrintDirectly = new ToolStripMenuItem("Print Directly", null, new EventHandler(tsmiPrintDirectly_Click));
                ToolStripDropDownButton tsbtnPrint = new ToolStripDropDownButton("Print", null, tsmiPrintPreview, tsmiPrintDirectly);
                tsbtnPrint.Image = MasterNavigator.Items["tsbtnPrint"].Image;
                MasterNavigator.Items.Insert(MasterNavigator.Items.IndexOfKey("tsbtnPrint"), tsbtnPrint);
                MasterNavigator.Items.RemoveByKey("tsbtnPrint");

                DetailTable.Columns.Add("Unit Base Diterima", typeof(String));
                MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);

                omsTextBoxEx.ExSqlInstance = DB.sql;
                gcSpb.ExGridControl.DataSource = spbdBindingSource;
                gcSpb.ExTitleLabel.Text = "Surat Perintah Bongkar";
                gcSpb.ExGridView.OptionsCustomization.AllowSort = false;
                gcSpb.ExGridView.OptionsView.ShowGroupPanel = false;

                gcSpb.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
                gcSpb.ExGridView.CellValueChanged += new CellValueChangedEventHandler(ExGridView_CellValueChanged);
                //gcSpb.ExGridView.ValidateRow += new ValidateRowEventHandler(ExGridView_ValidateRow);

                gcSpb.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
                gcSpb.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
                gcSpb.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                gcSpb.ExToolStrip.Items["tsbtnNew"].Enabled = false;

                gcSpb.ExGridView.Columns["spb"].OptionsColumn.AllowEdit = false;
                gcSpb.ExGridView.Columns["qty"].OptionsColumn.AllowEdit = false;
                gcSpb.ExGridView.Columns["qty1"].OptionsColumn.AllowEdit = false;
                gcSpb.ExGridView.Columns["remark"].OptionsColumn.AllowEdit = false;
                gcSpb.ExGridView.Columns["inv"].OptionsColumn.AllowEdit = false;
                gcSpb.ExGridView.Columns["unit"].OptionsColumn.AllowEdit = false;
                gcSpb.ExGridView.Columns["loc"].OptionsColumn.AllowEdit = false;

                gcSpb.ExGridView.Columns["no"].Visible = false;
                gcSpb.ExGridView.Columns["spb"].Visible = false;
                gcSpb.ExGridView.Columns["cct"].Visible = false;
                gcSpb.ExGridView.Columns["qty1"].Visible = false;

                gcSpb.ExGridView.Columns["inv"].ColumnEdit = new GridLookUpEx(DB.sql, "", "", "inv", gcSpb.ExGridView, "", true, true, "Inventory");
                gcSpb.ExGridView.Columns["inv"].ColumnEdit.Enter += new EventHandler(ExGridView_InvColumnEdit_Enter);
                gcSpb.ExGridView.Columns["loc"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('loc')", "", "loc", gcSpb.ExGridView, "", false, false, "Location");
                //    gcSpb.ExGridView.Columns["cct"].ColumnEdit = new GridLookUpEx("cct", DB.sql, "cct", gcSpb.ExGridView, "",false);
                gcSpb.ExGridView.Columns["unit"].ColumnEdit = new GridLookUpUnit(gcSpb.ExGridView, "Unit SJ");
                gcSpb.ExGridView.Columns["unitgd"].ColumnEdit = new GridLookUpUnit(gcSpb.ExGridView, "Unit Diterima");

                gcSpb.ExGridView.Columns["qty1"].ColumnEdit = new GridNumEx();
                //gcSpb.ExGridView.Columns["qty1"].ColumnEdit.Enter += new EventHandler(ExGridView_Qty1ColumnEdit_Enter);
                gcSpb.ExGridView.Columns["qtygd"].ColumnEdit = new GridNumEx();
                //gcSpb.ExGridView.Columns["qtygd"].ColumnEdit.Enter += new EventHandler(ExGridView_QtygdColumnEdit_Enter);

                gcSpb.ExGridView.OptionsBehavior.Editable = false;
                //gcSpb.ExGridView.OptionsView.ColumnAutoWidth = true;
                gcSpb.ExGridView.OptionsSelection.MultiSelect = true;

                tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
                //tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
                tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);

                gcSpb.ExGridView.Columns["inv"].Caption = "Kode Barang";
                gcSpb.ExGridView.Columns["remark"].Caption = "Nama Barang";
                gcSpb.ExGridView.Columns["loc"].Caption = "Loc";
                gcSpb.ExGridView.Columns["cct"].Caption = "Cost Center";
                gcSpb.ExGridView.Columns["qty"].Caption = "Qty Base Diterima";
                gcSpb.ExGridView.Columns["unit"].Caption = "Unit SJ";
                gcSpb.ExGridView.Columns["qty1"].Caption = "Qty SJ";
                gcSpb.ExGridView.Columns["qtygd"].Caption = "Qty Diterima";
                gcSpb.ExGridView.Columns["unitgd"].Caption = "Unit Diterima";
                gcSpb.ExGridView.Columns["etd"].Caption = "Keterangan";

                gcSpb.ExGridView.Columns["Unit Base Diterima"].VisibleIndex = DetailTable.Columns.IndexOf("qty");
                gcSpb.ExGridView.Columns["Unit Base Diterima"].OptionsColumn.AllowEdit = false;

                gcSpb.ExGridView.BestFitColumns();
                //gcSpb.ExGridView.RowCellStyle += new RowCellStyleEventHandler(ExGridView_RowCellStyle);
                //tsbtnPrint.Click += new EventHandler(tsbtnPrint_Click);
            }
        }
        void tsbtnNew_Click(object sender, EventArgs e)
        {
            ctrlSub.ReadOnly = false;
            omsTextBoxEx.Properties.ReadOnly = false;

            DetailTable.Clear();
            gcSpb.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcSpb.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcSpb.ExGridView.OptionsBehavior.Editable = true;
            gcSpb.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            withPOCheckBox.Checked = true;
            omsTextBoxEx.ExAutoCheck = true;
            //   isDetailValid = true;
        }
        void tsmiPrintDirectly_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "Invoice" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_PrintInvoice('Transaction.FrmTSpb','" + this.NoDocument + "')");
            report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
            report.Bands[BandKind.PageFooter].Controls["lblSummary"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblSummary2"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblUMText"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblUM"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblDPPText"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblDPP"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblPPNText"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblPPN"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblTotal"].Visible = false;
            report.PrintingSystem.ShowMarginsWarning = false;
            //report.PrintingSystem.Document.PrintingSystem.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            //report.PrintingSystem.Document.PrintingSystem.PageSettings.PaperName = "1/2A4";
            //report.PrintingSystem.Document.PrintingSystem.PageSettings.RightMargin = 0;
            report.PaperName = "1/2A4";
            report.Print();
        }

        void tsmiPrintPreview_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "Invoice" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_PrintInvoice('Transaction.FrmTSpb','" + this.NoDocument + "')");
            report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
            report.Bands[BandKind.PageFooter].Controls["lblSummary"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblSummary2"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblUMText"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblUM"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblDPPText"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblDPP"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblPPNText"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblPPN"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblTotal"].Visible = false;
            report.ShowPreview();
        }
        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base Diterima");
            gcSpb.ExGridView.BestFitColumns();
        }
        
        void ExGridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (e.Column.FieldName == "qty1")
            {
                DetailBindingSource.EndEdit();
                if (gcSpb.ExGridView.GetRowCellValue(e.RowHandle, "inv") != null)
                {
                    DataRow dr = GetDetailPO(omsTextBoxEx.EditValue.ToString(), gcSpb.ExGridView.GetRowCellValue(e.RowHandle, "inv").ToString());
                    if (dr != null)
                    {
                        double qty1po = Convert.ToDouble(dr["qty1"]);
                        double qty1 = Convert.ToDouble(gcSpb.ExGridView.GetRowCellValue(e.RowHandle,"qty1"));
                        if (qty1 > qty1po)
                        {
                            e.Appearance.BackColor = Color.Red;
                        }
                    }
                }
            }
        }

        void ExGridView_InvColumnEdit_Enter(object sender, EventArgs e)
        {
            GridLookUpEx invLookUp = gcSpb.ExGridView.Columns["inv"].ColumnEdit as GridLookUpEx;
            if (omsTextBoxEx.EditValue.ToString() != "")
            {
                if (withPOCheckBox.Checked)
                {
                    //subTextBoxEx.EditValue = omsTextBoxEx.ExGetDataRow()["sub"].ToString();
                    //invLookUp.Query = "select * from oms_in where oms='" + omsTextBoxEx.Text + "'";
                    invLookUp.Query = "Call SP_OutSpb('" + omsTextBoxEx.EditValue.ToString() + "')";
                    invLookUp.TableName = "oms_in";
                }
                else
                {
                    //invLookUp.Query = "select * from prd where prq='" + omsTextBoxEx.Text + "'";
                    invLookUp.Query = "Call SP_SelectPRforSpb('" + omsTextBoxEx.Text + "')";
                    invLookUp.TableName = "prd";
                }
            }
                //SPB bisa langsung input kode barang
                //PO/PR menyusul
            else
            {
                invLookUp.Query = "Call SP_LookUp('invspb')";
                invLookUp.TableName = "inv";
            }
        }

        void SetMaxValue(object sender)
        {
            //DataRow dr = GetDetailPO(omsTextBoxEx.EditValue.ToString(), gcSpb.ExGridView.GetFocusedRowCellValue("inv").ToString());
            //if (dr != null)
            //{
            //    double qty1po = Convert.ToDouble(dr["qty1"]);
            //    double toleransi = Convert.ToDouble(dr["toleransi"]);
            //    decimal maxValue = Convert.ToDecimal(qty1po + (qty1po * (toleransi / 100)));
            //    ((SpinEdit)sender).Properties.MaxValue = maxValue;               
            //}
            //((SpinEdit)sender).Properties.MaxValue = GetMaxValueQtyDiterima();   
        }

        private decimal GetMaxValueQtyDiterima(string unit)
        {
            decimal maxValue = 0;
            string inv = gcSpb.ExGridView.GetFocusedRowCellValue("inv").ToString();
            string loc = gcSpb.ExGridView.GetFocusedRowCellValue("loc").ToString();
            //string unit = gcSpb.ExGridView.GetFocusedRowCellValue("unit").ToString();            
            //string unit = gcSpb.ExGridView.GetFocusedRowCellValue("unitgd").ToString();     
            string remark = gcSpb.ExGridView.GetFocusedRowCellValue("remark").ToString().Replace("'","''");
            DataTable dtOutSpb = DB.sql.Select("Call SP_OutSpb('" + omsTextBoxEx.EditValue.ToString() + "')");
            if (dtOutSpb.Rows.Count > 0)
            {
                try
                {
                    //DataRow dr = dtOutSpb.Select("`Kode Barang`='" + inv + "' and Loc='" + loc + "'")[0];
                    DataRow dr = dtOutSpb.Select("`Kode Barang`='" + inv + "' and `Nama Barang`='" + remark + "'")[0];
                    //double qtyToleransi = DB.GetQtyToleransi("omd", "oms", omsTextBoxEx.EditValue.ToString(), inv, loc, unit);

                    double toleransi = Convert.ToDouble(dr["Toleransi"]);
                    //convert toleransi dari outSpb yg dalam unit base ke unit spb
                    if (unit != DB.GetBaseUnit(inv))
                        toleransi = DB.GetQtyInAlternativeUom(inv, unit, toleransi);

                    double qtySisa = Convert.ToDouble(dr["Qty SJ"]);
                    //convert qty dari outSpb yg dalam unit base ke unit spb
                    if (unit != DB.GetBaseUnit(inv))
                        qtySisa = DB.GetQtyInAlternativeUom(inv, unit, qtySisa);

                    maxValue = Convert.ToDecimal(qtySisa + toleransi);
                }
                catch (Exception ex)
                {
                    //do nothing
                    MessageBox.Show(ex.Message);
                }
            }
            return maxValue;

            //DataRow dr = GetDetailPO(omsTextBoxEx.EditValue.ToString(), gcSpb.ExGridView.GetFocusedRowCellValue("inv").ToString());
            //decimal maxValue = 0;
            //if (dr != null)
            //{
            //    double qty1po = Convert.ToDouble(dr["qty1"]);
            //    double toleransi = Convert.ToDouble(dr["toleransi"]);
            //    maxValue = Convert.ToDecimal(qty1po + (qty1po * (toleransi / 100)));
            //}
            //return maxValue;
        }   

        void ExGridView_Qty1ColumnEdit_Enter(object sender, EventArgs e)
        {
            //if (gcSpb.ExGridView.GetFocusedRowCellValue("inv").ToString() != "")
            //    SetMaxValue(sender);
        }

        void ExGridView_QtygdColumnEdit_Enter(object sender, EventArgs e)
        {
            //if (gcSpb.ExGridView.GetFocusedRowCellValue("inv") != null)
            //    SetMaxValue(sender);
        }

        void ExGridView_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            if (((DataRowView)e.Row).Row["inv"].ToString() == "" ||
                ((DataRowView)e.Row).Row["loc"].ToString() == "")
            {
                e.Valid = false;
                e.ErrorText = "Invalid Kode Barang/Location.";
             //   isDetailValid  = false;
            }
           // else
          //  { isDetailValid = true; }
        }

        void ExGridView_New_Click(object sender, EventArgs e)
        {
            DataRow row = casDataSet.spbd.NewRow();
            row["spb"] = NoDocument;
            row["qty"] = 0;
            row["qty1"] = 0;
            row["inv"] = "";
            row["loc"] = "";
            row["unit"] = "";
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            casDataSet.spbd.Rows.Add(row);

            DB.InsertDetailRows(gcSpb.ExGridView, row);
        }

        void ExGridView_Delete_Click(object sender, EventArgs e)
        {
            bool canDeleteitem, canDelete = true;
            int[] selectedIndex = gcSpb.ExGridView.GetSelectedRows();
            for (int i = 0; i < selectedIndex.Length; i++)
            {
                string prq = gcSpb.ExGridView.GetDataRow(selectedIndex[i])["spb"].ToString();
                int no = Convert.ToInt32(gcSpb.ExGridView.GetDataRow(selectedIndex[i])["no"]);
                canDeleteitem = DeleteLineItem(prq, no);
                if (canDeleteitem == false) canDelete = false;
            }
            if (canDelete) DB.DeleteDetailRows(gcSpb.ExGridView);
            //cek apakah line item PR sudah di proses ke PO
            //int[] selectedIndex = gcSpb.ExGridView.GetSelectedRows();
            //for (int i = 0; i < selectedIndex.Length; i++)
            //{
            //    string spb = gcSpb.ExGridView.GetDataRow(selectedIndex[i])["spb"].ToString();
            //    string inv = gcSpb.ExGridView.GetDataRow(selectedIndex[i])["inv"].ToString();
            //    string remark = gcSpb.ExGridView.GetDataRow(selectedIndex[i])["remark"].ToString();
            //    string query = "Select * from lpd, lph where lph.lph=lpd.lph and lph.spb='" + spb + "' and lpd.inv='" + inv + "' and lpd.remark='" + remark + "'";
            //    DataTable dtLpd = DB.sql.Select(query);
            //    if (dtLpd.Rows.Count > 0)
            //    {
            //        int itemNo = selectedIndex[i] + 1;
            //        MessageBox.Show("Item SPB ke-" + itemNo.ToString() + " tidak bisa di-delete karena sudah ada LPB");
            //        return;
            //    }
            //}            
            //DB.DeleteDetailRows(gcSpb.ExGridView);
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            if (this.mode == Mode.Edit)
            {
                ctrlSub.ReadOnly = false;
                //omsTextBoxEx.Properties.ReadOnly = true;
                gcSpb.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
                gcSpb.ExToolStrip.Items["tsbtnNew"].Enabled = true;
                gcSpb.ExGridView.OptionsBehavior.Editable = true;
                gcSpb.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            //    isDetailValid = true;
            }
        }

        protected override void tsbtnCancel_Click(object sender, EventArgs e)
        {
            DB.CancelDetailRows(DetailTable);

            base.tsbtnCancel_Click(sender, new EventArgs());

            if (this.mode == Mode.View)
            {
                gcSpb.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                gcSpb.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                gcSpb.ExGridView.OptionsBehavior.Editable = false;
                gcSpb.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;

                ctrlSub.ReadOnly = true;
                omsTextBoxEx.ExAutoCheck = false;
             //   isDetailValid = true;

                DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base Diterima");
            }
        }



        //void ClosePR()
        //{
        //    DataTable dt = DB.sql.Select("Call SP_SelectPRforSpb('" + omsTextBoxEx.EditValue.ToString() + "')");
        //    if (dt.Rows.Count == 0)
        //        DB.sql.Execute("update prq set close=1 where prq='" + omsTextBoxEx.EditValue.ToString() + "'");
        //}       

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate controls
                this.ValidateChildren();
                
                if (ctrlSub.txtSub.EditValue.ToString() == "")
                    throw new Exception ("Harap mengisi supplier!");

                if (nosjTextEdit.Text == "")
                    throw new Exception("Harap mengisi surat jalan!");

                if (nopolTextEdit.Text == "")
                    throw new Exception("Harap mengisi nomor kendaraan!");

                DetailBindingSource.EndEdit();
               
                bool isApproved1 = true;
                bool isApproved2 = true;
                bool isDuplicate = false;            
                //get the first loc
                string loc = "";
                foreach (DataRow dr in DetailTable.Rows)
                {
                    if (dr != null && dr.RowState != DataRowState.Deleted)
                    {
                        loc = dr["loc"].ToString();
                        break;
                    }
                }
                for (int i = DetailTable.Rows.Count - 1; i >= 0; i--)
                {                    
                    DataRow row = DetailTable.Rows[i];
                    if (row != null && row.RowState != DataRowState.Deleted)
                    {
                        row[0] = NoDocument;
                        if (row["inv"].ToString() == "" || row["loc"].ToString() == "" )
                            throw new Exception("Kode Barang/Loc tidak valid");

                        //cek qty diterima jika 0
                        if (Convert.ToDouble(row["qtygd"]) == 0)
                        {
                            //jika qty diterima = 0, approve di-uncheck
                            isApproved1 = false;
                        }

                        //check duplicate SPB
                        if (omsTextBoxEx.EditValue.ToString() != "" && MasterBindingSource.Position == MasterTable.Rows.Count)
                        {
                            string query = "select spbd.* from spb, spbd "
                                + "where spb.oms='" + omsTextBoxEx.EditValue.ToString()
                                + "' and spb.spb = spbd.spb and "
                                + "spbd.inv='" + row["inv"].ToString() + "' "
                                + "and spbd.remark='" + row["remark"].ToString().Replace("'","''") 
                                + "' and spb.spb not in (select spb from lph) "
                                + "and spb.delete=0";
                            DataTable dt = DB.sql.Select(query);
                            if (dt.Rows.Count > 0)
                                isDuplicate = true;
                        }
                    }
                }

                //qty diterima = 0
                if (!isApproved1)
                {
                    ((DataRowView)MasterBindingSource.Current).Row["aprov"] = 0;
                    if (aprovCheckBox.Checked)
                        MessageBox.Show("Qty diterima=0. Approve ditolak");
                }

                //cek jika tidak ada PR/PO tidak boleh di-approve
                if (omsTextBoxEx.EditValue.ToString() == "")
                {
                    ((DataRowView)MasterBindingSource.Current).Row["aprov"] = 0;
                    if (aprovCheckBox.Checked)
                        MessageBox.Show("SPB non PR/PO. Approve ditolak");
                }

                if (isDuplicate)
                {
                    //MessageBox.Show("SPB dengan detail yang sama sudah ada, dan belum dibuat LPB-nya", "Warning", MessageBoxButtons.OK);
                    DialogResult dlgResult = MessageBox.Show("SPB dengan detail yang sama sudah ada, dan belum dibuat LPB-nya. Anda yakin untuk menyimpan?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dlgResult != DialogResult.Yes)
                        return;
                }                
                
                base.tsbtnSave_Click(sender, e);

                if (this.mode == Mode.View)
                {
                    gcSpb.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                    gcSpb.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                    gcSpb.ExGridView.OptionsBehavior.Editable = false;
                    gcSpb.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;

                    omsTextBoxEx.Properties.ReadOnly = true;
                    omsTextBoxEx.ExAutoCheck = false;
                    ctrlSub.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private DataRow GetDetailPO(string oms, string inv)
        {
            DataTable dt = (DB.sql.Select("select * from omd where oms='" + oms + "' and inv='" + inv + "'"));
            if (dt.Rows.Count > 0)
                return dt.Rows[0];
            return null;
        }

        void ExGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "unitgd" || e.Column.FieldName == "qtygd")
            {
                DetailBindingSource.EndEdit();
                string inv = (string)gcSpb.ExGridView.GetFocusedRowCellValue("inv");
                string unitgd = (string)gcSpb.ExGridView.GetFocusedRowCellValue("unitgd");
                //double qty1 = (double)gcSpb.ExGridView.GetFocusedRowCellValue("qty1");
                double qtygd = Convert.ToDouble(gcSpb.ExGridView.GetFocusedRowCellValue("qtygd"));           
                if (inv != "" && unitgd != "")
                    gcSpb.ExGridView.SetFocusedRowCellValue(gcSpb.ExGridView.Columns["qty"], DB.GetQtyInBaseUom(inv, unitgd, qtygd));
            /*
                if (unitgd != "" && qtygd > 0 && withPOCheckBox.Checked && omsTextBoxEx.EditValue.ToString() != "")
                {
                    decimal maxQty = GetMaxValueQtyDiterima(unitgd);
                    if (Convert.ToDecimal(qtygd) > maxQty)
                    {
                        MessageBox.Show("Qty Diterima melebihi batas toleransi PO. Max qty diterima: " + maxQty.ToString() + " " + unitgd);
                        gcSpb.ExGridView.SetFocusedRowCellValue(gcSpb.ExGridView.Columns["qtygd"], maxQty);
                    }
                }
             */
            }

            if (e.Column.FieldName == "qty1" || e.Column.FieldName == "unit")
            {
                double qtysj = Convert.ToDouble(gcSpb.ExGridView.GetFocusedRowCellValue("qty1"));
                string unitsj = (string)gcSpb.ExGridView.GetFocusedRowCellValue("unit");
                /*
                if (unitsj != "" && qtysj > 0 && withPOCheckBox.Checked && omsTextBoxEx.EditValue.ToString() != "")
                {
                    decimal maxQty = GetMaxValueQtyDiterima(unitsj);
                    if (Convert.ToDecimal(qtysj) > maxQty)
                    {
                        MessageBox.Show("Qty SJ melebihi batas toleransi PO. Max qty SJ: " + maxQty.ToString() + " " + unitsj);
                        gcSpb.ExGridView.SetFocusedRowCellValue(gcSpb.ExGridView.Columns["qty1"], maxQty);
                    }
                }
                */
            }
            //else if (e.Column.FieldName == "qtygd" && withPOCheckBox.Checked)
            //{

            //    decimal qtygd = Convert.ToDecimal(gcSpb.ExGridView.GetFocusedRowCellValue("qtygd"));
            //    decimal maxQty = GetMaxValueQtyDiterima();
            //    if (qtygd > maxQty)
            //    {
            //        MessageBox.Show("Qty Diterima melebihi batas toleransi PO. Max qty diterima: " + maxQty.ToString());
            //        gcSpb.ExGridView.SetFocusedRowCellValue(gcSpb.ExGridView.Columns["qtygd"], maxQty);
            //    }
            //}
        }

        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gcSpb.ExGridView.GetDataRow(e.RowHandle);
            row["spb"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
            //row["no"] = DetailTable.Rows.Count + 1;
            row["no"] = DB.GetRowCount(DetailTable) + 1;
        }


      
        private void omsTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {
            if (omsTextBoxEx.Text == "" || !omsTextBoxEx.ExIsValid())
                return;

            if (ctrlSub.txtSub.Text == "" && withPOCheckBox.Checked) 
                ctrlSub.txtSub.Text = omsTextBoxEx.ExGetDataRow()["Supplier"].ToString();

            remarkMemoEdit.EditValue = omsTextBoxEx.ExGetDataRow()["Keterangan"].ToString();

            GridLookUpEx invLookUp = gcSpb.ExGridView.Columns["inv"].ColumnEdit as GridLookUpEx;
            if (withPOCheckBox.Checked)
            {
                //subTextBoxEx.EditValue = omsTextBoxEx.ExGetDataRow()["sub"].ToString();
                //invLookUp.Query = "select * from oms_in where oms='" + omsTextBoxEx.Text + "'";
                invLookUp.Query = "Call SP_OutSpb('" + omsTextBoxEx.EditValue.ToString() + "')";
                invLookUp.TableName = "oms_in";
            }
            else
            {
                //invLookUp.Query = "select * from prd where prq='" + omsTextBoxEx.Text + "'";
                //invLookUp.Query = "Call SP_SelectPRforSpb(" + ((DateTime)dateDate.EditValue).ToString("yyyyMMdd") + ")";
                invLookUp.Query = "Call SP_SelectPRforSpb('" + omsTextBoxEx.EditValue.ToString() + "')";
                invLookUp.TableName = "prd";
            }

            if (MasterBindingSource.Position == MasterTable.Rows.Count)
            {
                DetailTable.Clear();
                invLookUp.ClickButton();
            }
        }

        void SetOmsTextBoxQuery()
        {
            if (withPOCheckBox.Checked)
            {
                //omsTextBoxEx.ExFieldName = "oms";
                //omsTextBoxEx.ExTableName = "oms";
                //omsTextBoxEx.ExCondition = "closed=0 and aprov=1 and sub='" + ctrlSub.txtSub.EditValue.ToString() + "'";
                omsTextBoxEx.ExSqlQuery = "select oms as PO, date as `Tanggal`, remark as Keterangan, sub as `Supplier`, aprov as `Approve`, close as `Close` from oms where close=0 and aprov=1 and `delete`=0"; 
                if (ctrlSub.txtSub.Text != "") omsTextBoxEx.ExSqlQuery += " and sub='" + ctrlSub.txtSub.EditValue.ToString() + "'";
                omsTextBoxEx.ExFieldName = "PO";
            }
            else
            {
                //omsTextBoxEx.ExFieldName = "prq";
                //omsTextBoxEx.ExTableName = "prq";
                //omsTextBoxEx.ExCondition = "withPO=0 and aprov=1 and close=0";                
                omsTextBoxEx.ExSqlQuery = "select prq.prq as PR, date as Tanggal, prq.remark as Keterangan,prd.remark as `Nama Barang`,prd.qty as `Qty`, aprov as Approve, close as Close from prq,prd where prq.prq=prd.prq and withPO=0 and aprov=1 and close=0 and `delete`=0";
                omsTextBoxEx.ExFieldName = "PR";
            }
        }

        private void withPOCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetOmsTextBoxQuery();
        }

        private void omsTextBoxEx_Enter(object sender, EventArgs e)
        {
            SetOmsTextBoxQuery();
        }

        private void spbBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base Diterima");
        }

        private void txtNo_EditValueChanged(object sender, EventArgs e)
        {
            if (MasterBindingSource.Position != MasterTable.Rows.Count)
                DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base Diterima");
        }

        private void aprovCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!aprovCheckBox.Enabled || !aprovCheckBox.Checked) return;
            bool canapprove = true;
            for (int i = 0; i <= DetailTable.Rows.Count-1; i++)
            {
                if (Convert.ToInt32(DetailTable.Rows[i]["qtygd"]) == 0)
                {
                    canapprove = false;
                }
            }
            if (!canapprove)
            {
                aprovCheckBox.Checked = false;
                MessageBox.Show("SPB tidak dapat diapprove karena ada item detail SPB yang memiliki qty 0");
            }
        }

        private void nosjTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmTSpbgd_Load(object sender, EventArgs e)
        {
              ctrlSub.txtSub.DataBindings.Add("EditValue", MasterBindingSource, "sub");     
            if (MasterBindingSource.Position == MasterTable.Rows.Count)
                omsTextBoxEx.ExAutoCheck = true;
            else
                omsTextBoxEx.ExAutoCheck = false;
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base Diterima");
        }   
    }
    
}

