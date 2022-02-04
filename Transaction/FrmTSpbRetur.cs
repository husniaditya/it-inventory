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
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;

namespace CAS.Transaction
{
    public partial class FrmTSpbRetur : CAS.Transaction.BaseTransaction
    {
        public FrmTSpbRetur()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlDetail, DB.sql);

            ToolStripMenuItem tsmiPrintPreview = new ToolStripMenuItem("Print Preview", null, new EventHandler(tsmiPrintPreview_Click));
            ToolStripMenuItem tsmiPrintDirectly = new ToolStripMenuItem("Print Directly", null, new EventHandler(tsmiPrintDirectly_Click));
            ToolStripDropDownButton tsbtnPrint = new ToolStripDropDownButton("Print", null, tsmiPrintPreview, tsmiPrintDirectly);
            tsbtnPrint.Image = MasterNavigator.Items["tsbtnPrint"].Image;
            MasterNavigator.Items.Insert(MasterNavigator.Items.IndexOfKey("tsbtnPrint"), tsbtnPrint);
            MasterNavigator.Items.RemoveByKey("tsbtnPrint");

            DetailTable.Columns.Add("Unit Base Diterima", typeof(String));
            MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);

            gcxSprd.ExGridControl.DataSource = sprdBindingSource;
            gcxSprd.ExTitleLabel.Text = "SPB Retur";
            gcxSprd.ExGridView.OptionsCustomization.AllowSort = false;
            gcxSprd.ExGridView.OptionsView.ShowGroupPanel = false;

            gcxSprd.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
            gcxSprd.ExGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(ExGridView_CellValueChanged);

            gcxSprd.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
            gcxSprd.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
            gcxSprd.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gcxSprd.ExToolStrip.Items["tsbtnNew"].Enabled = false;

            gcxSprd.ExGridView.Columns["spr"].OptionsColumn.AllowEdit = false;
            gcxSprd.ExGridView.Columns["qty"].OptionsColumn.AllowEdit = false;
            gcxSprd.ExGridView.Columns["remark"].OptionsColumn.AllowEdit = false;

            gcxSprd.ExGridView.Columns["no"].Visible = false;
            gcxSprd.ExGridView.Columns["spr"].Visible = false;

            gcxSprd.ExGridView.Columns["inv"].ColumnEdit = new GridLookUpEx(DB.sql, "", "inv", "inv", gcxSprd.ExGridView, "", true, true, "Inventory");
            gcxSprd.ExGridView.Columns["inv"].ColumnEdit.Enter += new EventHandler(InvColumnEdit_Enter);

            gcxSprd.ExGridView.Columns["nodsg"].ColumnEdit = new GridLookUpEx(DB.sql, "", "dsg", "nodsg", gcxSprd.ExGridView, "", true, true, "Inventory");
            gcxSprd.ExGridView.Columns["nodsg"].ColumnEdit.Enter += new EventHandler(DsgColumnEdit_Enter);  
          
            gcxSprd.ExGridView.Columns["loc"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('loc')", "", "loc", gcxSprd.ExGridView, "", false, false, "Location");
            gcxSprd.ExGridView.Columns["unit"].ColumnEdit = new GridLookUpUnit(gcxSprd.ExGridView, "Unit SJ");
            gcxSprd.ExGridView.Columns["unitgd"].ColumnEdit = new GridLookUpUnit(gcxSprd.ExGridView, "Unit Diterima");

            gcxSprd.ExGridView.Columns["qty1"].ColumnEdit = new GridNumEx();
            gcxSprd.ExGridView.Columns["qtygd"].ColumnEdit = new GridNumEx();

            gcxSprd.ExGridView.OptionsBehavior.Editable = false;
            gcxSprd.ExGridView.OptionsSelection.MultiSelect = true;

            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);

            gcxSprd.ExGridView.Columns["nodsg"].Caption = "No Design";
            gcxSprd.ExGridView.Columns["inv"].Caption = "Kode Barang";
            gcxSprd.ExGridView.Columns["remark"].Caption = "Nama Barang";
            gcxSprd.ExGridView.Columns["loc"].Caption = "Loc";
            gcxSprd.ExGridView.Columns["qty"].Caption = "Qty Base Diterima";
            gcxSprd.ExGridView.Columns["unit"].Caption = "Unit SJ";
            gcxSprd.ExGridView.Columns["qty1"].Caption = "Qty SJ";
            gcxSprd.ExGridView.Columns["qtygd"].Caption = "Qty Diterima";
            gcxSprd.ExGridView.Columns["unitgd"].Caption = "Unit Diterima";
            gcxSprd.ExGridView.Columns["etd"].Caption = "Keterangan";

            gcxSprd.ExGridView.Columns["Unit Base Diterima"].VisibleIndex = DetailTable.Columns.IndexOf("qty");
            gcxSprd.ExGridView.Columns["Unit Base Diterima"].OptionsColumn.AllowEdit = false;

            gcxSprd.ExGridView.BestFitColumns();
            //tsbtnPrint.Click += new EventHandler(tsbtnPrint_Click);
        }
        void tsmiPrintDirectly_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "Invoice" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_PrintInvoice('Transaction.FrmTspbRetur','" + this.NoDocument + "')");
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
            report.PrintingSystem.ShowMarginsWarning = false; ;
            report.PaperName = "1/2A4";
            report.Print();
        }
        
        void tsmiPrintPreview_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "Invoice" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_PrintInvoice('Transaction.FrmTspbRetur','" + this.NoDocument + "')");
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

        void DsgColumnEdit_Enter(object sender, EventArgs e)
        {
            if (rsmTextBoxEx.EditValue.ToString() == "")
                ((GridLookUpEx)gcxSprd.ExGridView.Columns["nodsg"].ColumnEdit).Query = "Call SP_LookUp('dsg')";
            else
                ((GridLookUpEx)gcxSprd.ExGridView.Columns["nodsg"].ColumnEdit).Query = "Call SP_OutSpr('" + rsmTextBoxEx.EditValue.ToString() + "')";
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidateChildren();

                if (nosjTextEdit.Text == "")
                    throw new Exception("Harap mengisi surat jalan");

                if (nopolTextEdit.Text == "")
                    throw new Exception("Harap mengisi nomor kendaraan");

                DetailBindingSource.EndEdit();

                bool isApproved = true;
                bool isDuplicate = false;
                for (int i = DetailTable.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = DetailTable.Rows[i];
                    string loc = DetailTable.Rows[0]["loc"].ToString();
                    if (row != null && row.RowState != DataRowState.Deleted)
                    {
                        row[0] = NoDocument;
                        if (row["inv"].ToString() == "" || row["loc"].ToString() == "" || loc != row["loc"].ToString())
                            throw new Exception("Kode Barang/Loc tidak valid");
                       
                        //cek qty diterima jika 0
                        if (Convert.ToDouble(row["qtygd"]) == 0)
                            isApproved = false;

                        //check duplicate SPB Retur
                        if (rsmTextBoxEx.EditValue.ToString() != "" && MasterBindingSource.Position == MasterTable.Rows.Count)
                        {
                            string query = "select sprd.* from spr, sprd "
                                + "where spr.rsm='" + rsmTextBoxEx.EditValue.ToString() + "' " 
                                + "and spr.spr = sprd.spr "
                                + "and sprd.nodsg='" + row["nodsg"].ToString() + "' "
                                + "and sprd.inv='" + row["inv"].ToString() + "' "
                                + "and sprd.remark='" + row["remark"].ToString().Replace("'","''") + "' " 
                                + "and spr.spr not in (select spr from rka) "
                                + "and spr.delete=0";
                            DataTable dt = DB.sql.Select(query);
                            if (dt.Rows.Count > 0)
                                isDuplicate = true;
                        }
                    }
                }

                if (!isApproved)
                {
                    ((DataRowView)MasterBindingSource.Current).Row["aprov"] = 0;
                    if (aprovCheckBox.Checked)
                        MessageBox.Show("Qty diterima=0. Approve ditolak");
                }

                //cek jika tidak ada SO retur tidak boleh di-approve
                //if (rsmTextBoxEx.EditValue.ToString() == "")
                //{
                //    ((DataRowView)MasterBindingSource.Current).Row["aprov"] = 0;
                //    if (aprovCheckBox.Checked)
                //        MessageBox.Show("SPB Retur non SO Retur. Approve ditolak");
                //}

                if (isDuplicate)
                {
                    DialogResult dlgResult = MessageBox.Show("SPB Retur dengan detail yang sama sudah ada, dan belum dibuat LPB Retur-nya. Anda yakin untuk menyimpan?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dlgResult != DialogResult.Yes)                        
                        return;
                }                 
            
                base.tsbtnSave_Click(sender, e);

                if (this.mode == Mode.View)
                {
                    SetMode(Mode.View);
                    rsmTextBoxEx.ExAutoCheck = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            SetMode(Mode.Edit);
        }

        protected override void tsbtnCancel_Click(object sender, EventArgs e)
        {
            DB.CancelDetailRows(DetailTable);
            base.tsbtnCancel_Click(sender, e);
            if (this.mode == Mode.View)
            {
                //SetMode(Mode.View);
                rsmTextBoxEx.ExAutoCheck = false;
                DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base Diterima");
            }
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            DetailTable.Clear();
            SetMode(Mode.Edit);
            rsmTextBoxEx.ExAutoCheck = true;
        }

        void InvColumnEdit_Enter(object sender, EventArgs e)
        {
            GridLookUpEx invLookUp = gcxSprd.ExGridView.Columns["inv"].ColumnEdit as GridLookUpEx;
            if (rsmTextBoxEx.EditValue.ToString() != "")
                invLookUp.Query = "Call SP_OutSpr('" + rsmTextBoxEx.EditValue.ToString() + "')";
            //SPB retur bisa langsung input kode barang
            //SO Retur menyusul
            else
                invLookUp.Query = "Call SP_LookUp('invpenj')";
        }

        void ExGridView_New_Click(object sender, EventArgs e)
        {
            DataRow row = casDataSet.spbd.NewRow();
            row["spr"] = NoDocument;
            row["qty"] = 0;
            row["qty1"] = 0;
            row["inv"] = "";
            row["loc"] = "";
            row["unit"] = "";
            row["remark"] = "";
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            casDataSet.sprd.Rows.Add(row);

            DB.InsertDetailRows(gcxSprd.ExGridView, row);
        }

        void ExGridView_Delete_Click(object sender, EventArgs e)
        {
            bool canDeleteitem, canDelete = true;
            int[] selectedIndex = gcxSprd.ExGridView.GetSelectedRows();
            for (int i = 0; i < selectedIndex.Length; i++)
            {
                string spr = gcxSprd.ExGridView.GetDataRow(selectedIndex[i])["spr"].ToString();
                int no = Convert.ToInt32(gcxSprd.ExGridView.GetDataRow(selectedIndex[i])["no"]);
                canDeleteitem = DeleteLineItem(spr, no);
                if (canDeleteitem == false) canDelete = false;
            }
            if (canDelete) DB.DeleteDetailRows(gcxSprd.ExGridView);
        }
        
        private decimal GetMaxValueQtyDikirim(string unit)
        {
            decimal maxValue = 0;

            try
            {
                string nodsg = gcxSprd.ExGridView.GetFocusedRowCellValue("nodsg").ToString();
                string inv = gcxSprd.ExGridView.GetFocusedRowCellValue("inv").ToString();
                string rsm = rsmTextBoxEx.EditValue.ToString();
                string baseUnit = gcxSprd.ExGridView.GetFocusedRowCellValue("Unit Base Diterima").ToString();

                DataTable dtOutSpr = DB.sql.Select("Call SP_OutSpr1('" + rsm + "')");
                DataRow[] drSelect;
                if (nodsg != "")
                    drSelect = dtOutSpr.Select("`No Design`='" + nodsg + "'");
                else
                    drSelect = dtOutSpr.Select("`Kode Barang`='" + inv + "' and `No Design`=''");

                if (drSelect.Length > 0)
                {
                    string query = "select toleransi, sum(qty) as qty from rsmd where rsm='" + rsm + "' and nodsg='" + nodsg + "' and inv='" + inv + "' group by rsm";
                    decimal qtySisa = Convert.ToDecimal(drSelect[0]["Qty SJ"]);
                    double qtyToleransi = DB.GetQtyToleransi(query, inv, unit, baseUnit);
                    //maxValue = Convert.ToDecimal(dr["Qty"]) + Convert.ToDecimal(dr["Toleransi"]);                    
                    if (unit != drSelect[0]["Unit SJ"].ToString())
                        qtySisa = Convert.ToDecimal(DB.GetQtyInAlternativeUom(inv, drSelect[0]["Unit Diterima"].ToString(), Convert.ToDouble(qtySisa), unit));
                    maxValue = qtySisa + Convert.ToDecimal(qtyToleransi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return maxValue;
        }

        void ExGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //DetailBindingSource.EndEdit();
            if (e.Column.FieldName == "inv")
            {
                //DetailBindingSource.EndEdit();
                DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base Diterima");
            }
            else if (e.Column.FieldName == "unitgd" || e.Column.FieldName == "qtygd")
            {
                //DetailBindingSource.EndEdit();
                string inv = (string)gcxSprd.ExGridView.GetFocusedRowCellValue("inv");
                string unitgd = (string)gcxSprd.ExGridView.GetFocusedRowCellValue("unitgd");
                double qtygd = Convert.ToDouble(gcxSprd.ExGridView.GetFocusedRowCellValue("qtygd"));
                if (inv != "" && unitgd != "")
                    gcxSprd.ExGridView.SetFocusedRowCellValue(gcxSprd.ExGridView.Columns["qty"], DB.GetQtyInBaseUom(inv, unitgd, qtygd));
                //if (qtygd > 0 && unitgd != "")
                //{
                //    decimal maxQty = GetMaxValueQtyDikirim(unitgd);
                //    if (Convert.ToDecimal(qtygd) > maxQty)
                //    {
                //        MessageBox.Show("Qty Diretur melebihi batas toleransi SO Retur. Max qty dikirim: " + maxQty.ToString() + " " + unitgd);
                //        gcxSprd.ExGridView.SetFocusedRowCellValue(gcxSprd.ExGridView.Columns["qtygd"], maxQty);
                //    }
                //}
            }
            else if (e.Column.FieldName == "unit" || e.Column.FieldName == "qty1")
            {
                //DetailBindingSource.EndEdit();
                string unitsj = (string)gcxSprd.ExGridView.GetFocusedRowCellValue("unit");
                double qtysj = Convert.ToDouble(gcxSprd.ExGridView.GetFocusedRowCellValue("qty1"));
                //if (qtysj > 0 && unitsj != "")
                //{
                //    decimal maxQty = GetMaxValueQtyDikirim(unitsj);
                //    if (Convert.ToDecimal(qtysj) > maxQty)
                //    {
                //        MessageBox.Show("Qty SJ melebihi batas toleransi SO Retur. Max qty dikirim: " + maxQty.ToString() + " " + unitsj);
                //        gcxSprd.ExGridView.SetFocusedRowCellValue(gcxSprd.ExGridView.Columns["qty1"], maxQty);
                //    }
                //}
            }
          //  DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base Diterima");
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base Diterima");
        }

        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gcxSprd.ExGridView.GetDataRow(e.RowHandle);
            row["spr"] = NoDocument;
            row["spr"] = NoDocument;
            row["qty"] = 0;
            row["qty1"] = 0;
            row["inv"] = "";
            row["loc"] = "";
            row["unit"] = "";
            row["remark"] ="";
            row["no"] = DB.GetRowCount(DetailTable) + 1;
        }

        void SetMode(Mode mode)
        {
            gcxSprd.ExGridView.OptionsBehavior.Editable = (mode == Mode.Edit) ? true : false;
            gcxSprd.ExGridView.OptionsView.NewItemRowPosition = (mode == Mode.Edit) ? NewItemRowPosition.Bottom : NewItemRowPosition.None;
            gcxSprd.ExToolStrip.Items["tsbtnDelete"].Enabled = (mode == Mode.Edit) ? true : false;
            gcxSprd.ExToolStrip.Items["tsbtnNew"].Enabled = (mode == Mode.Edit) ? true : false;
            ctrlSub.ReadOnly = (mode == Mode.Edit) ? false : true;
            rsmTextBoxEx.Properties.ReadOnly = (mode == Mode.Edit) ? false : true;
        }

        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base Diterima");
        }

        private void FrmTSpbRetur_Load(object sender, EventArgs e)
        {
            if (MasterBindingSource.Position == MasterTable.Rows.Count)
            {
                SetMode(Mode.Edit);
                rsmTextBoxEx.ExAutoCheck = true;
            }
            else
                rsmTextBoxEx.ExAutoCheck = false;
            ctrlSub.txtSub.DataBindings.Add("EditValue", MasterBindingSource, "sub");
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base Diterima");
        }

        private void rsmTextBoxEx_Enter(object sender, EventArgs e)
        {
            /* Tarik SJ aja
            rsmTextBoxEx.ExSqlQuery = "select sjh as `SJ Retur`, date as `Tanggal`, sjh.remark as Keterangan, sjh.sub as `Customer`, sub.name as `Nama Customer` from sjh, sub where sjh.sub=sub.sub";
            if (ctrlSub.txtSub.Text != "") 
                rsmTextBoxEx.ExSqlQuery += " and sjh.sub='" + ctrlSub.txtSub.EditValue.ToString() + "'";
            rsmTextBoxEx.ExFieldName = "SJ Retur";
            
            Tarik SO Retur aja
            
            rsmTextBoxEx.ExSqlQuery = "select rsm as `SO Retur`, date as `Tanggal`, rsm.remark as Keterangan, rsm.sub as `Customer`, sub.name as `Nama Customer`, close as `Close` from rsm, sub where rsm.sub=sub.sub and close=0 and rsm.`delete`=0";
            if (ctrlSub.txtSub.Text != "")
                rsmTextBoxEx.ExSqlQuery += " and rsm.sub='" + ctrlSub.txtSub.EditValue.ToString() + "'";
            rsmTextBoxEx.ExFieldName = "SO Retur";
            */
            //Tarik SPM
            rsmTextBoxEx.ExSqlQuery = "SELECT * FROM (select rsm as `SO Retur`, date as `Tanggal`, rsm.remark as Keterangan, rsm.sub as `Customer`, sub.name as `Nama Customer`, close as `Close` from rsm, sub where rsm.sub=sub.sub and close=0 and rsm.`delete`=0 UNION all SELECT spm.spm AS `SO Retur`,spm.date AS `Tanggal`,spm.remark AS Keterangan,spm.sub AS `Customer`,sub.name AS `Nama Customer`, '' AS `Close` FROM spm,sub WHERE spm.sub = sub.sub AND spm.`delete` = 0 AND spm.spm NOT IN (SELECT rsm FROM spr) ORDER BY `SO Retur` DESC) x";
            if (ctrlSub.txtSub.Text != "")
                rsmTextBoxEx.ExSqlQuery += " where Customer='" + ctrlSub.txtSub.EditValue.ToString() + "'";
            rsmTextBoxEx.ExFieldName = "SO Retur";
        }

        private void rsmTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {
            if (rsmTextBoxEx.Text != "")
            {
                string jenis = rsmTextBoxEx.Text.Substring(0,3);
                if (rsmTextBoxEx.Text == "" || !rsmTextBoxEx.ExIsValid())
                    return;

                if (ctrlSub.txtSub.Text == "")
                ctrlSub.txtSub.Text = rsmTextBoxEx.ExGetDataRow()["Customer"].ToString();

                remarkMemoEdit.EditValue = rsmTextBoxEx.ExGetDataRow()["Keterangan"].ToString();

                GridLookUpEx invLookUp = gcxSprd.ExGridView.Columns["inv"].ColumnEdit as GridLookUpEx;

                if (jenis == "SPM")
                {
                    // Tarik Detail SPM
                    invLookUp.Query = "Call SP_OutSpr2('" + rsmTextBoxEx.EditValue.ToString() + "')";
                    invLookUp.TableName = "spm";
                }
                else
                {
                    // Tarik Detail SO Retur
                    invLookUp.Query = "Call SP_OutSpr1('" + rsmTextBoxEx.EditValue.ToString() + "')";
                    invLookUp.TableName = "rsm";
                }
                if (MasterBindingSource.Position == MasterTable.Rows.Count)
                {
                    DetailTable.Clear();
                    invLookUp.ClickButton();
                }
            }  
        }

        private void dateDate_EditValueChanged(object sender, EventArgs e)
        {
            if (this.mode != Mode.View)
            {
                tglbc.EditValue = dateDate.EditValue.ToString();
            }
        }

        private void txtPeriod_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNo_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void linkToForm1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}

