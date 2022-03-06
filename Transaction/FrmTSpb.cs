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
    public partial class FrmTSpb : CAS.Transaction.BaseTransaction
    {
        private int[] selectedIndex = new int[0];
        private bool isDetailValid = true;
        private SqlConnection conn;
        Int32 manual = 0;

        public FrmTSpb()
        {
            InitializeComponent();

            shipperTextEdit.Properties.ReadOnly = true;

            ToolStripMenuItem tsmiPrintPreview = new ToolStripMenuItem("Print Preview", null, new EventHandler(tsmiPrintPreview_Click));
            ToolStripMenuItem tsmiPrintDirectly = new ToolStripMenuItem("Print Directly", null, new EventHandler(tsmiPrintDirectly_Click));
            ToolStripDropDownButton tsbtnPrint = new ToolStripDropDownButton("Print", null, tsmiPrintPreview, tsmiPrintDirectly);
            tsbtnPrint.Image = MasterNavigator.Items["tsbtnPrint"].Image;
            MasterNavigator.Items.Insert(MasterNavigator.Items.IndexOfKey("tsbtnPrint"), tsbtnPrint);
            MasterNavigator.Items.RemoveByKey("tsbtnPrint");

            Utility.SetSqlInstance(pnlDetail, DB.sql);

            DetailTable.Columns.Add("Unit Base", typeof(String));
            DetailTable.Columns.Add("Beda", typeof(String));

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
            gcSpb.ExGridView.Columns["remark"].OptionsColumn.AllowEdit = false;
            gcSpb.ExGridView.Columns["spesifikasi"].OptionsColumn.AllowEdit = false;

            if (cpoCheckBox.Checked = true)
            {
                //testing di trukan dahulu
                gcSpb.ExGridView.Columns["qtygd"].OptionsColumn.AllowEdit = true;
                gcSpb.ExGridView.Columns["unitgd"].OptionsColumn.AllowEdit = true;
            }
            else
            {
                gcSpb.ExGridView.Columns["qtygd"].OptionsColumn.AllowEdit = true;
                gcSpb.ExGridView.Columns["unitgd"].OptionsColumn.AllowEdit = true;

            }
            gcSpb.ExGridView.Columns["no"].Visible = false;
            gcSpb.ExGridView.Columns["spb"].Visible = false;
            gcSpb.ExGridView.Columns["cct"].Visible = false;

            gcSpb.ExGridView.Columns["inv"].ColumnEdit = new GridLookUpEx(DB.sql, "", "", "inv", gcSpb.ExGridView, "", true, true, "Inventory");
            gcSpb.ExGridView.Columns["inv"].ColumnEdit.Enter += new EventHandler(ExGridView_InvColumnEdit_Enter);
            gcSpb.ExGridView.Columns["loc"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUpLoc('" + DB.casUser.User + "')", "", "loc", gcSpb.ExGridView, "", false, false, "Location");
            //gcSpb.ExGridView.Columns["loc"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('loc')", "", "loc", gcSpb.ExGridView, "", false, false, "Location");
            gcSpb.ExGridView.Columns["loc"].ColumnEdit.KeyPress += new KeyPressEventHandler(ExGridView_LocColumnEdit_KeyPress);
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


            //gcSpb.ExGridView.Columns["nodsg"].Caption = "No Batch";
            //gcSpb.ExGridView.Columns["expired"].Caption = "Expired";

            gcSpb.ExGridView.Columns["nodsg"].Visible = false;
            gcSpb.ExGridView.Columns["expired"].Visible = false;

            gcSpb.ExGridView.Columns["inv"].Caption = "Kode Barang";
            gcSpb.ExGridView.Columns["remark"].Caption = "Nama Barang";
            gcSpb.ExGridView.Columns["spesifikasi"].Caption = "Spesifikasi";
            gcSpb.ExGridView.Columns["loc"].Caption = "Loc";
            gcSpb.ExGridView.Columns["cct"].Caption = "Cost Center";
            gcSpb.ExGridView.Columns["qty"].Caption = "Qty Base";
            gcSpb.ExGridView.Columns["unit"].Caption = "Unit SJ";
            gcSpb.ExGridView.Columns["qty1"].Caption = "Qty SJ";
            gcSpb.ExGridView.Columns["qtygd"].Caption = "Qty flow";
            gcSpb.ExGridView.Columns["qtygd"].AppearanceCell.BackColor = Color.LightSkyBlue;
            gcSpb.ExGridView.Columns["unitgd"].Caption = "Unit Diterima";
            gcSpb.ExGridView.Columns["qtytim"].Caption = "Qty Tim";
            gcSpb.ExGridView.Columns["qtytim"].AppearanceCell.BackColor = Color.LightSkyBlue;
            gcSpb.ExGridView.Columns["etd"].Caption = "Keterangan";

            gcSpb.ExGridView.Columns["spesifikasi"].VisibleIndex = 2;

            //gcSpb.ExGridView.Columns["nodsg"].ColumnEdit = new GridLookUpEx(DB.sql, "Call Sp_GetStockBatch(''," + DateTime.Today + ")", "", "nodsg", gcSpb.ExGridView, "", true, true, "Batch");
            //gcSpb.ExGridView.Columns["nodsg"].ColumnEdit.Enter += new EventHandler(DsgColumnEdit_Enter);

            gcSpb.ExGridView.Columns["Unit Base"].VisibleIndex = DetailTable.Columns.IndexOf("qty");
            gcSpb.ExGridView.Columns["Unit Base"].OptionsColumn.AllowEdit = false;
            gcSpb.ExGridView.Columns["Beda"].VisibleIndex = DetailTable.Columns.IndexOf("etd");
            gcSpb.ExGridView.Columns["Beda"].AppearanceCell.BackColor = Color.LightSkyBlue;
            gcSpb.ExGridView.Columns["Beda"].OptionsColumn.AllowEdit = false;

            gcSpb.ExGridView.Columns["qtygd"].OptionsColumn.AllowEdit = false;
            gcSpb.ExGridView.Columns["unitgd"].OptionsColumn.AllowEdit = false;
            gcSpb.ExGridView.BestFitColumns();
            //gcSpb.ExGridView.RowCellStyle += new RowCellStyleEventHandler(ExGridView_RowCellStyle);
            //tsbtnPrint.Click += new EventHandler(tsbtnPrint_Click);
        }

        void tsmiPrintDirectly_Click(object sender, EventArgs e)
        {
            this.ReportName = "RepSpb";
            this.PrintQuery = "call SP_Print('Transaction.FrmTSpb','" + this.NoDocument + "')";

            PrintDirect();
        }

        void tsmiPrintPreview_Click(object sender, EventArgs e)
        {
            this.ReportName = "RepSpb";
            this.PrintQuery = "call SP_Print('Transaction.FrmTSpb','" + this.NoDocument + "')";

            PrintReport();
        }
        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
            DetailTable = DB.PopulateSelisih(DetailTable, "SPB");

            gcSpb.ExGridView.BestFitColumns();
        }

        void DsgColumnEdit_Enter(object sender, EventArgs e)
        {
            //if (gclhp.ExGridView.GetFocusedRowCellValue("mor") == null)
            //{
            //    ((ButtonEdit)sender).Enabled = true;
            //    return;
            //}
            //if (gclhp.ExGridView.GetFocusedRowCellValue("mor").ToString() == "")
            //    ((ButtonEdit)sender).Enabled = true;
            //else
            //    ((ButtonEdit)sender).Enabled = false;

            string inv;
            inv = gcSpb.ExGridView.Columns["inv"].ToString();
            if (gcSpb.ExGridView.GetFocusedRowCellValue("inv") != null)
                (gcSpb.ExGridView.Columns["nodsg"].ColumnEdit as GridLookUpEx).Query = "Call Sp_GetStockBatch('" + inv + "'," + (DateTime)dateDate.EditValue + ")";
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
                        double qty1 = Convert.ToDouble(gcSpb.ExGridView.GetRowCellValue(e.RowHandle, "qty1"));
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
                invLookUp.Query = "Call SP_LookUp('SP_LookUpSPBPO')";
                invLookUp.TableName = "inv";
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
            string remark = gcSpb.ExGridView.GetFocusedRowCellValue("remark").ToString().Replace("'", "''");
            DataTable dtOutSpb = DB.sql.Select("Call SP_OutSpb1('" + omsTextBoxEx.EditValue.ToString() + "',1)");
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
                isDetailValid = false;
            }
            else
            { isDetailValid = true; }
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
                shipperTextEdit.Properties.ReadOnly = true;
                gcSpb.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
                gcSpb.ExToolStrip.Items["tsbtnNew"].Enabled = true;
                gcSpb.ExGridView.OptionsBehavior.Editable = true;
                gcSpb.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                isDetailValid = true;
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
                isDetailValid = true;

                DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
                DetailTable = DB.PopulateSelisih(DetailTable, "SPB");
            }
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            comboStation.Items.Clear();
            cpoCheckBox.Checked = true;
            ctrlSub.ReadOnly = false;
            omsTextBoxEx.Properties.ReadOnly = false;
            shipperTextEdit.Properties.ReadOnly = true;

            DetailTable.Clear();
            gcSpb.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcSpb.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcSpb.ExGridView.OptionsBehavior.Editable = true;
            gcSpb.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            //   DataTable dtloading = DB.sql.Select2("select * from unloading_station");

            withPOCheckBox.Checked = true;
            omsTextBoxEx.ExAutoCheck = true;
            isDetailValid = true;
        }

        //void ClosePR()
        //{
        //    DataTable dt = DB.sql.Select("Call SP_SelectPRforSpb('" + omsTextBoxEx.EditValue.ToString() + "')");
        //    if (dt.Rows.Count == 0)
        //        DB.sql.Execute("update prq set close=1 where prq='" + omsTextBoxEx.EditValue.ToString() + "'");
        //}       

        protected override void tsbtnDelete_Click(object sender, EventArgs e)
        {
            base.tsbtnDelete_Click(sender, e);
            if (Convert.ToInt32(MasterTable.Rows[MasterBindingSource.Position]["delete"]) == 1)
                DB.sql.Execute("Call SP_Delete('SPB','" + NoDocument + "')");
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate controls
                this.ValidateChildren();

                if (ctrlSub.txtSub.EditValue.ToString() == "")
                    throw new Exception("Harap mengisi supplier!");

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
                        if (row["inv"].ToString() == "" || row["loc"].ToString() == "")
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
                                + "and spbd.remark='" + row["remark"].ToString().Replace("'", "''")
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

                if (this.mode == Mode.New)
                {
                    foreach (DataRow dr in DetailTable.Rows)
                    {
                        if (dr != null && dr.RowState != DataRowState.Deleted)
                        {
                            DB.sql.Execute("update openpo set crate = crate+1 where inv='" + dr["inv"].ToString() + "' and oms=('" + omsTextBoxEx.Text + "')");
                            DB.sql.Execute("update openpo set close = 1 where crate >= rate and rate > 0 and inv='" + dr["inv"].ToString() + "' and oms=('" + omsTextBoxEx.Text + "')");
                        }
                    }
                }

                base.tsbtnSave_Click(sender, e);


                string date = ((DateTime)(dateDate.EditValue)).ToString("yyyyMMdd");

                DB.sql.Execute("Call SP_Save(" + date + ",'SPB'" + ",'" + NoDocument + "')");

                DB.sql.Execute("update spb set shipper = null where shipper = ''");

                //DB.sql.Execute("insert into tpbdb.tpb_header (ALAMAT_PEMASOK,ALAMAT_PEMILIK,) values ()");

                // Close openpotoleransi
                DB.sql.Execute("call SP_ClosePOToleransiQty('" + omsTextBoxEx.Text + "')");

                // update count rate and close it if > input ratenya

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

            if (e.Column.FieldName == "qty1" || e.Column.FieldName == "unit")
            {
                double qtysj = Convert.ToDouble(gcSpb.ExGridView.GetFocusedRowCellValue("qty1"));
                string unitsj = gcSpb.ExGridView.GetFocusedRowCellValue("unit").ToString();
                if (unitsj != "" && qtysj > 0 && withPOCheckBox.Checked && omsTextBoxEx.EditValue.ToString() != "")
                {
                    decimal maxQty = GetMaxValueQtyDiterima(unitsj);
                    if (Convert.ToDecimal(qtysj) > maxQty)
                    {
                        MessageBox.Show("Qty SJ melebihi batas toleransi PO. Max qty SJ: " + maxQty.ToString() + " " + unitsj);
                        gcSpb.ExGridView.SetFocusedRowCellValue(gcSpb.ExGridView.Columns["qty1"], maxQty);
                        gcSpb.ExGridView.SetFocusedRowCellValue(gcSpb.ExGridView.Columns["qty"], maxQty);
                    }
                }
            }

            else if (e.Column.FieldName == "inv")
            {

                if (DetailTable.Rows.Count > 0)
                {
                    //     if (DetailTable.Rows[0]["inv"].ToString().Trim().Substring(0, 2) == "11")
                    //      {
                    comboStation.Items.Clear();
                    comboStation.Text = "";
                    //    }
                }
            }

            if (e.Column.FieldName == "unit" || e.Column.FieldName == "qty1")
            {
                DetailBindingSource.EndEdit();
                string inv = (string)gcSpb.ExGridView.GetFocusedRowCellValue("inv");
                string unit = gcSpb.ExGridView.GetFocusedRowCellValue("unit").ToString();
                //double qty1 = (double)gcSpb.ExGridView.GetFocusedRowCellValue("qty1");
                double qty1 = Convert.ToDouble(gcSpb.ExGridView.GetFocusedRowCellValue("qty1"));
                if (inv != "" && unit != "")
                {
                    gcSpb.ExGridView.SetFocusedRowCellValue(gcSpb.ExGridView.Columns["qty"], DB.GetQtyInBaseUom(inv, unit, qty1));
                    gcSpb.ExGridView.SetFocusedRowCellValue(gcSpb.ExGridView.Columns["qtygd"], DB.GetQtyInBaseUom(inv, unit, qty1));
                    gcSpb.ExGridView.SetFocusedRowCellValue(gcSpb.ExGridView.Columns["qtytim"], DB.GetQtyInBaseUom(inv, unit, qty1));
                }
            }

            if (e.Column.FieldName == "qtygd" || e.Column.FieldName == "qtytim")
            {
                DetailTable = DB.PopulateSelisih(DetailTable, "SPB");
            }
        }

        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gcSpb.ExGridView.GetDataRow(e.RowHandle);
            row["spb"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
            //row["no"] = DetailTable.Rows.Count + 1;
            row["no"] = DB.GetRowCount(DetailTable) + 1;
        }


        private void FrmTSpb_Load(object sender, EventArgs e)
        {
            tglbc.Properties.MinValue = Utility.FirstDateInMonth((DateTime)dateDate.EditValue);
            tglbc.Properties.MaxValue = Utility.LastDateInMonth((DateTime)dateDate.EditValue).AddHours(23);

            //try
            //{
            //    conn = new SqlConnection("Data Source = " + Utility.GetConfig("server2") + "\\SQLEXPRESS; " +
            //               "Initial Catalog = loading_unloading; " + "User Id = sa; Password = database;");
            //    conn.Open();
            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show("Komputer anda tidak terhubung dengan PLC, Hubungi IT");
            //    manual = 1;
            //}

            ctrlSub.txtSub.DataBindings.Add("EditValue", MasterBindingSource, "sub");
            if (MasterBindingSource.Position == MasterTable.Rows.Count)
                omsTextBoxEx.ExAutoCheck = true;
            else
                omsTextBoxEx.ExAutoCheck = false;
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
            DetailTable = DB.PopulateSelisih(DetailTable, "SPB");

            if (cpoCheckBox.Checked = true)
            {
                if (manual == 1)
                {
                    gcSpb.ExGridView.Columns["qtygd"].OptionsColumn.AllowEdit = true;
                    gcSpb.ExGridView.Columns["unitgd"].OptionsColumn.AllowEdit = true;
                }
            }
            else
            {
                gcSpb.ExGridView.Columns["qtygd"].OptionsColumn.AllowEdit = true;
                gcSpb.ExGridView.Columns["unitgd"].OptionsColumn.AllowEdit = true;

            }

        }

        private void omsTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {
            if (omsTextBoxEx.Text == "" || !omsTextBoxEx.ExIsValid())
                return;

            if (ctrlSub.txtSub.Text == "" && withPOCheckBox.Checked)
                ctrlSub.txtSub.Text = omsTextBoxEx.ExGetDataRow()["Supplier"].ToString();

            remarkMemoEdit.EditValue = omsTextBoxEx.ExGetDataRow()["Keterangan"].ToString();

            shipperTextEdit.EditValue = omsTextBoxEx.ExGetDataRow()["shipper"].ToString();

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

            nodocTextBoxEx.ExSqlQuery = "SELECT nodoc,datedoc,no_bc,nopen FROM docp,docpd where docp.docp=docpd.docp and docp.oms = '" + omsTextBoxEx.EditValue.ToString() + "' and docp.delete = 0";


            if (MasterBindingSource.Position == MasterTable.Rows.Count || this.mode == Mode.Edit)
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
                omsTextBoxEx.ExSqlQuery = "select oms.oms as PO, date as `Tanggal`, remark as Keterangan, sub as `Supplier`,oms.shipper as shipper, aprov as `Approve`, oms.close as `Close` from oms  " +
                                          "left outer join (select distinct oms,`close` from openpo where `close`=0) as openpo on oms.oms=openpo.oms where (oms.close=0 or (oms.close=1 and openpo.`close`=0)) and " +
                                          " aprov=1 and `delete`=0 and jenispo<>1 and date<=" + ((DateTime)dateDate.EditValue).AddDays(1).ToString("yyyyMMdd");

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
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
            DetailTable = DB.PopulateSelisih(DetailTable, "SPB");
        }

        private void txtNo_EditValueChanged(object sender, EventArgs e)
        {
            if (MasterBindingSource.Position != MasterTable.Rows.Count)
                DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
            DetailTable = DB.PopulateSelisih(DetailTable, "SPB");
        }

        private void aprovCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!aprovCheckBox.Enabled || !aprovCheckBox.Checked) return;
            bool canapprove = true;
            for (int i = 0; i <= DetailTable.Rows.Count - 1; i++)
            {
                if (Convert.ToDouble(DetailTable.Rows[i]["qtygd"]) == 0)
                {
                    canapprove = false;
                }
                if (cpoCheckBox.Checked)
                {
                    if (Math.Abs(Convert.ToDouble(DetailTable.Rows[i]["beda"].ToString().Replace("%", ""))) > (0.3))
                    {
                        MessageBox.Show("Peringatan beda lebih dari 0.3% ");

                        //   canapprove = false;
                    }
                }
                else
                    if (Convert.ToDouble(DetailTable.Rows[i]["qtygd"]) != Convert.ToDouble(DetailTable.Rows[i]["qty1"]))
                    {
                        canapprove = false;
                    }

            }
            if (!canapprove)
            {
                aprovCheckBox.Checked = false;
                MessageBox.Show("SPB tidak dapat diapprove karena ada item detail SPB yang memiliki qty 0 atau QtySPB tidak sama dengan Qty Gudang");
            }
        }


        private void comboStation_Click(object sender, EventArgs e)
        {
            if (DetailTable.Rows.Count > 0 && manual == 0)
            {
                string material = DetailTable.Rows[0]["remark"].ToString().Trim();
                // DataTable dtloading = DB.sql.Select("select station,material,status,reserved from unloading_station where status='A' and reserved='F' and material='" + material + "'");
                string query = "select station,material,status,reserved from unloading_station where status='A' and reserved='F' and rtrim(material)=rtrim('" + material + "')";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dtloading = new DataTable();
                adapter.Fill(dtloading);


                comboStation.Items.Clear();
                //      if (DetailTable.Rows[0]["inv"].ToString().Substring(0, 2) == "11")
                //       {
                for (int y = 0; y < dtloading.Rows.Count; y++)
                {
                    comboStation.Items.Add(dtloading.Rows[y]["station"]);
                }
                //        }
            }
        }


        private void cpoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //disable enable for station and qty gudang
            //{
            comboStation.Enabled = (cpoCheckBox.Checked);
            Stationlabel.Enabled = cpoCheckBox.Checked;
            sendgdCheckBox.Enabled = cpoCheckBox.Checked;
            sendgdLabel.Enabled = cpoCheckBox.Checked;
            //}
            // untuk testing qty flow di buka dahulu
            if (cpoCheckBox.Checked)
            {
                if (manual == 0)
                {
                    gcSpb.ExGridView.Columns["qtygd"].OptionsColumn.AllowEdit = true;
                    gcSpb.ExGridView.Columns["unitgd"].OptionsColumn.AllowEdit = true;
                    gcSpb.ExGridView.Columns["qtygd"].Caption = "Qty Flow";
                }
            }
            else
            {
                gcSpb.ExGridView.Columns["qtygd"].Caption = "Qty Gdg";
                gcSpb.ExGridView.Columns["qtygd"].OptionsColumn.AllowEdit = true;
                gcSpb.ExGridView.Columns["unitgd"].OptionsColumn.AllowEdit = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double qtyflow;
                if (DetailTable.Rows.Count > 0)
                {
                    // DataTable dtloading = DB.sql.Select("select * from unloading_summary where SPB_Num='" + NoDocument + "'");
                    string query = "select * from unloading_summary where SPB_Num='" + NoDocument + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dtloading = new DataTable();
                    adapter.Fill(dtloading);

                    if (dtloading.Rows.Count < 1)
                    {
                        MessageBox.Show("SPB Masih Dalam Proses PLC (Bussy) tunggu sampai proses Done");
                    }
                    else
                    {
                        qtyflow = (double)dtloading.Rows[0]["Act_quantity"];
                        DB.sql.Execute("update spbd set qtygd=" + qtyflow + " where spb='" + NoDocument + "'");
                        tsbtnRefresh_Click(sender, e);

                    }
                }
                DetailTable = DB.PopulateSelisih(DetailTable, "SPB");
                //if (DetailTable.Rows[0]["inv"].ToString().Substring(0, 2) == "11")
                // {
                //     for (int y = 0; y < dtloading.Rows.Count; y++)
                //     {
                //         comboStation.Items.Add(dtloading.Rows[y]["station"]);
                //     }
                // }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi Gagal");
            }
        }



        private void sendgdCheckBox_Click(object sender, EventArgs e)
        {
            if (comboStation.Text == "")
            {
                MessageBox.Show("Station Harus Di isi");
                sendgdCheckBox.Checked = false;
            }

            if (sendgdCheckBox.Checked)
            {
                if (Convert.ToDouble(DetailTable.Rows[0]["Qty1"]) == 0)
                {
                    MessageBox.Show("Quantity spb tidak boleh Kosong");
                    sendgdCheckBox.Checked = false;
                }
                else
                {
                    string material = DetailTable.Rows[0]["remark"].ToString().Trim();
                    double qtyspb = Convert.ToDouble(DetailTable.Rows[0]["qty"].ToString());
                    //cek apakah data spb di plc sudah ada untuk menghindari status edit dan doble klick di send plc

                    //   DataTable dtcekloading = DB.sql.Select("select SPB_Num,SPB_Station from unloading_orders where Spb_Num ='" + NoDocument +"'");
                    string query = "select SPB_Num,SPB_Station from unloading_orders where Spb_Num ='" + NoDocument + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dtcekloading = new DataTable();
                    adapter.Fill(dtcekloading);


                    if (dtcekloading.Rows.Count >= 1)
                    {
                        MessageBox.Show("Nomor SPB Sudah ada di Plc");
                        sendgdCheckBox.Checked = true;
                    }
                    else
                    {
                        // cek jika ada yg cenntang send plcnya terlambat sehingga ada kemungkinan sama
                        //DataTable dtloading = DB.sql.Select("select station,material,status,reserved from unloading_station where status='A' and reserved='F' and material='" + material + "' and station=" + comboStation.Text);
                        string query1 = "select * from unloading_station where status='A' and reserved='F' and material='" + material + "' and station=" + comboStation.Text;
                        SqlDataAdapter adapter1 = new SqlDataAdapter(query1, conn);
                        DataTable dtloading = new DataTable();
                        adapter1.Fill(dtloading);

                        if (dtloading.Rows.Count < 1)
                        {
                            MessageBox.Show("Station Masih dipakai (Bussy) tunggu sampai proses Done");
                            sendgdCheckBox.Checked = false;
                        }
                        else
                        {
                            //DB.sql.Execute("insert into unloading_orders (SPB_Num,SPB_DateTime,SPB_Station,SPB_Material,SPB_Quantity) Values " +
                            //"('" + NoDocument + "',now()," + Convert.ToInt16(comboStation.Text) + ",'" + material + "'," + qtyspb + ")");
                            string query2 = "insert into unloading_orders (SPB_Num,SPB_DateTime,SPB_Station,SPB_Material,SPB_Quantity,status) Values " +
                                           "('" + NoDocument + "',getdate()," + Convert.ToInt16(comboStation.Text) + ",'" + material + "'," + qtyspb + ",'')";
                            SqlCommand adapter2 = new SqlCommand(query2, conn);
                            adapter2.ExecuteNonQuery();

                            MessageBox.Show("Suksess, Spb Telah Terkirim Di PLC");
                            tsbtnSave_Click(sender, e);
                        }
                    }

                }
            }
        }

        private void sendgdCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sendgdLabel_Click(object sender, EventArgs e)
        {

        }

        private void ctrlSub_Load(object sender, EventArgs e)
        {

        }

        private void comboStation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ExGridView_LocColumnEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(0);
        }

        private void nodocTextBoxEx_ButtonPressed(object sender, ButtonPressedEventArgs e)
        {
            nodocTextBoxEx.ExSqlQuery = "SELECT nodoc,datedoc,no_bc,nopen FROM docp,docpd where docp.docp=docpd.docp and docp.oms = '" + omsTextBoxEx.EditValue.ToString() + "' and docpd.nodoc = '" + NoDocument + "' and docp.delete = 0";
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

    }
}

