using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KASLibrary;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace CAS.Transaction
{
    public partial class FrmTLpbJasa : CAS.Transaction.BaseTransaction
    {
        public FrmTLpbJasa()
        {
            InitializeComponent();

            ToolStripMenuItem tsmiPrintPreview = new ToolStripMenuItem("Print Preview", null, new EventHandler(tsmiPrintPreview_Click));
            ToolStripMenuItem tsmiPrintDirectly = new ToolStripMenuItem("Print Directly", null, new EventHandler(tsmiPrintDirectly_Click));
            ToolStripDropDownButton tsbtnPrint = new ToolStripDropDownButton("Print", null, tsmiPrintPreview, tsmiPrintDirectly);
            tsbtnPrint.Image = MasterNavigator.Items["tsbtnPrint"].Image;
            MasterNavigator.Items.Insert(MasterNavigator.Items.IndexOfKey("tsbtnPrint"), tsbtnPrint);
            MasterNavigator.Items.RemoveByKey("tsbtnPrint");

            DetailTable.Columns.Add("Unit Base", typeof(String));
           // DetailTable.Columns.Add("Qty Selisih", typeof(Double));
            MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);

            Utility.SetSqlInstance(pnlDetail, DB.sql);
            //spbTextBoxEx.ExCondition = "spb not in (select spb from lph) and aprov=1";           

            gcLpd.ExGridControl.DataSource = DetailTable;
            gcLpd.ExTitleLabel.Text = "Detail Penerimaan Barang";
       //     gcLpd.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gcLpd.ExToolStrip.Items["tsbtnNew"].Enabled = false;
       //     gcLpd.ExGridView.OptionsBehavior.Editable = false;
            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
            SetGridViewSetting();

            //tsbtnPrint.Click += new EventHandler(tsbtnPrint_Click);

            gcLpd.ExGridView.Columns["inv"].Caption = "Kode Barang";
            gcLpd.ExGridView.Columns["remark"].Caption = "Nama Barang";
            gcLpd.ExGridView.Columns["loc"].Caption = "Loc";
            gcLpd.ExGridView.Columns["qty1"].Caption = "Qty Diterima";
            gcLpd.ExGridView.Columns["unit"].Caption = "Unit";
            gcLpd.ExGridView.Columns["qty"].Caption = "Qty Diterima Base";
            gcLpd.ExGridView.Columns["etd"].Caption = "Keterangan";
            gcLpd.ExGridView.Columns["nodsg"].Caption = "No Batch";
            gcLpd.ExGridView.Columns["spesifikasi"].Caption = "Spesifikasi";

            gcLpd.ExGridView.Columns["inv"].VisibleIndex = 0;
            gcLpd.ExGridView.Columns["remark"].VisibleIndex = 1;
            gcLpd.ExGridView.Columns["spesifikasi"].VisibleIndex = 2;
            gcLpd.ExGridView.Columns["loc"].VisibleIndex = 3;
            gcLpd.ExGridView.Columns["nodsg"].VisibleIndex = 4;
            gcLpd.ExGridView.Columns["expired"].VisibleIndex = 5;
            gcLpd.ExGridView.Columns["qty1"].VisibleIndex = 6;
            gcLpd.ExGridView.Columns["unit"].VisibleIndex = 7;
            gcLpd.ExGridView.Columns["qty"].VisibleIndex = 8;
            gcLpd.ExGridView.Columns["Unit Base"].VisibleIndex = 9;//DetailTable.Columns.IndexOf("qty");
            gcLpd.ExGridView.Columns["etd"].VisibleIndex = 10;
            gcLpd.ExGridView.Columns["Unit Base"].OptionsColumn.AllowEdit = false;

            //DevExpress.XtraEditors.Controls.EditorButton btnReload = new DevExpress.XtraEditors.Controls.EditorButton();
            //btnReload.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Redo;
            //btnReload.ToolTip = "Reload data";
            //spbTextBoxEx.Properties.Buttons.Add(btnReload);
            //spbTextBoxEx.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(spbTextBoxEx_ButtonClick);
            //mode = Mode.View;
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            gcLpd.ExGridView.OptionsBehavior.Editable = true;
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            gcLpd.ExGridView.OptionsBehavior.Editable = true;
            DetailTable.Clear();
            gcLpd.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcLpd.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcLpd.ExGridView.OptionsBehavior.Editable = true;
            gcLpd.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
        }

        void spbTextBoxEx_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index > 0)
                spbTextBoxEx_EditValueChanged(sender, new EventArgs());
        }

        void tsmiPrintDirectly_Click(object sender, EventArgs e)
        {
            this.ReportName = "RepLpb";
            this.PrintQuery = "call SP_Print('Transaction.FrmTLpb','" + this.NoDocument + "')";

            PrintDirect();
        }

        void tsmiPrintPreview_Click(object sender, EventArgs e)
        {
            this.ReportName = "RepLpb";
            this.PrintQuery = "call SP_Print('Transaction.FrmTLpb','" + this.NoDocument + "')";

            PrintReport();
        }

        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
            DetailTable = DB.PopulateSelisih(DetailTable,"LPB");
            gcLpd.ExGridView.BestFitColumns();
        }

        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gcLpd.ExGridView.GetDataRow(e.RowHandle);
            row["lph"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
            //row["no"] = DetailTable.Rows.Count + 1;
            row["no"] = DB.GetRowCount(DetailTable) + 1;
        }

        void ExGridView_Delete_Click(object sender, EventArgs e)
        {
            bool canDeleteitem, canDelete = true;
            int[] selectedIndex = gcLpd.ExGridView.GetSelectedRows();
            for (int i = 0; i < selectedIndex.Length; i++)
            {
                string prq = gcLpd.ExGridView.GetDataRow(selectedIndex[i])["lph"].ToString();
                int no = Convert.ToInt32(gcLpd.ExGridView.GetDataRow(selectedIndex[i])["no"]);
                canDeleteitem = DeleteLineItem(prq, no);
                if (canDeleteitem == false) canDelete = false;
            }
            if (canDelete) DB.DeleteDetailRows(gcLpd.ExGridView);
        }

        void SetGridViewSetting()
        {
            //if (mode == Mode.View)
            //    gcLpd.ExGridView.OptionsBehavior.Editable = false;
            //else
            //    gcLpd.ExGridView.OptionsBehavior.Editable = true;
            gcLpd.ExGridView.CellValueChanged += new CellValueChangedEventHandler(ExGridView_CellValueChanged);
            gcLpd.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
            gcLpd.ExGridView.Columns["inv"].OptionsColumn.AllowEdit = true;
            gcLpd.ExGridView.Columns["remark"].OptionsColumn.AllowEdit = true;
            gcLpd.ExGridView.Columns["loc"].OptionsColumn.AllowEdit = true;
            gcLpd.ExGridView.Columns["qty"].OptionsColumn.AllowEdit = true;
            gcLpd.ExGridView.Columns["qty1"].OptionsColumn.AllowEdit = true;
            gcLpd.ExGridView.Columns["loc"].OptionsColumn.AllowEdit = true;
            gcLpd.ExGridView.Columns["unit"].OptionsColumn.AllowEdit = true;
            gcLpd.ExGridView.Columns["cct"].OptionsColumn.AllowEdit = true;
            gcLpd.ExGridView.Columns["etd"].OptionsColumn.AllowEdit = true;
            gcLpd.ExGridView.Columns["qtyc"].OptionsColumn.AllowEdit = true;
            gcLpd.ExGridView.OptionsView.ShowGroupPanel = false;
            gcLpd.ExGridView.OptionsCustomization.AllowSort = false;

            gcLpd.ExGridView.Columns["inv"].ColumnEdit = new GridLookUpEx(DB.sql, "", "", "inv", gcLpd.ExGridView, "", true, true, "Inventory");
            gcLpd.ExGridView.Columns["inv"].ColumnEdit.Enter += new EventHandler(ExGridView_InvColumnEdit_Enter);
            gcLpd.ExGridView.Columns["loc"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('loc')", "", "loc", gcLpd.ExGridView, "", false, false, "Location");
            gcLpd.ExGridView.Columns["unit"].ColumnEdit = new GridLookUpUnit(gcLpd.ExGridView, "Unit");
                   
            gcLpd.ExGridView.Columns["qty1"].ColumnEdit = new GridNumEx();
            //gcSpb.ExGridView.Columns["qty1"].ColumnEdit.Enter += new EventHandler(ExGridView_Qty1ColumnEdit_Enter);
            //gcLpd.ExGridView.Columns["qtygd"].ColumnEdit = new GridNumEx();
           // gcLpd.ExGridView.Columns["qtyc"].ColumnEdit = new GridNumEx();

            gcLpd.ExGridView.Columns["Unit Base"].VisibleIndex = DetailTable.Columns.IndexOf("qty") + 1;
            gcLpd.ExGridView.Columns["Unit Base"].OptionsColumn.AllowEdit = false;

            gcLpd.ExGridView.Columns["lph"].Visible = false;
            gcLpd.ExGridView.Columns["inv"].Caption = "Kode Barang";
            gcLpd.ExGridView.Columns["remark"].Caption = "Nama Barang";
            gcLpd.ExGridView.Columns["loc"].Caption = "Loc";
            gcLpd.ExGridView.Columns["qty"].Caption = "Qty Diterima Base";
            gcLpd.ExGridView.Columns["qty1"].Caption = "Qty Diterima";
            gcLpd.ExGridView.Columns["unit"].Caption = "Unit";
            gcLpd.ExGridView.Columns["etd"].Caption = "Keterangan";
            gcLpd.ExGridView.Columns["cct"].Caption = "Cost Center";
            gcLpd.ExGridView.Columns["qtyc"].Caption = "Qty Container";
            gcLpd.ExGridView.Columns["qtyc"].VisibleIndex = gcLpd.ExGridView.Columns["cct"].VisibleIndex;
            gcLpd.ExGridView.Columns["no"].Visible = false;
            gcLpd.ExGridView.Columns["qtyc"].Visible = false;
            gcLpd.ExGridView.Columns["cct"].Visible = false;
            
        //    gcLpd.ExGridView.Columns["Qty Selisih"].VisibleIndex = gcLpd.ExGridView.Columns["cct"].VisibleIndex;
        //    gcLpd.ExGridView.Columns["Qty Selisih"].OptionsColumn.AllowEdit = false;

            gcLpd.ExGridView.BestFitColumns();
        }

        void ExGridView_InvColumnEdit_Enter(object sender, EventArgs e)
        {
            GridLookUpEx invLookUp = gcLpd.ExGridView.Columns["inv"].ColumnEdit as GridLookUpEx;

                invLookUp.Query = "Call SP_LookUp('inv')";
                invLookUp.TableName = "inv";
           
        }
        void ExGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //if (e.Column.FieldName == "qty" || e.Column.FieldName == "qtyc")
            //{
            //    DetailTable = DB.PopulateSelisih(DetailTable,"LPB");
            //}
            if (e.Column.FieldName == "unit" || e.Column.FieldName == "qty1")
            {

                DetailBindingSource.EndEdit();
                string inv = (string)gcLpd.ExGridView.GetFocusedRowCellValue("inv");
                string unit = (string)gcLpd.ExGridView.GetFocusedRowCellValue("unit");
                //double qty1 = (double)gcSpb.ExGridView.GetFocusedRowCellValue("qty1");
                double qty1 = Convert.ToDouble(gcLpd.ExGridView.GetFocusedRowCellValue("qty1"));
                if (inv != "" && unit != "" && qty1 != 0)
                    gcLpd.ExGridView.SetFocusedRowCellValue(gcLpd.ExGridView.Columns["qty"], DB.GetQtyInBaseUom(inv, unit, qty1));
            }

        }

        private void FrmTLpbJasa_Load(object sender, EventArgs e)
        {
            tglbc.Properties.MinValue = Utility.FirstDateInMonth((DateTime)dateDate.EditValue);
            tglbc.Properties.MaxValue = Utility.LastDateInMonth((DateTime)dateDate.EditValue).AddHours(23);

            ctrlSub.txtSub.DataBindings.Add("EditValue", lphBindingSource, "sub");
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
            DetailTable = DB.PopulateSelisih(DetailTable,"LPB");
            //if (MasterBindingSource.Position == MasterTable.Rows.Count)
            //    spbTextBoxEx.ExAutoCheck = true;
            //else
            //    spbTextBoxEx.ExAutoCheck = false;
        }

        void ClosePO()
        {
            string query = "Call Sp_OutSpb('" + omsTextEdit.Text + "')";
            DataTable dt = DB.sql.Select(query);
            if (dt.Rows.Count == 0)
                DB.sql.Execute("update oms set close=1 where oms='" + omsTextEdit.Text + "'");
        }

        void ClosePR()
        {
            DataTable dt = DB.sql.Select("Call SP_SelectPRforSpb('" + omsTextEdit.EditValue.ToString() + "')");
            if (dt.Rows.Count == 0)
                DB.sql.Execute("update prq set close=1 where prq='" + omsTextEdit.EditValue.ToString() + "'");
        }

        protected override void tsbtnDelete_Click(object sender, EventArgs e)
        {
            gcLpd.ExGridView.OptionsBehavior.Editable = false;
            base.tsbtnDelete_Click(sender, e);
            if (Convert.ToInt32(MasterTable.Rows[MasterBindingSource.Position]["delete"]) == 1)
            {
                DB.sql.Execute("Call SP_Delete('LPH','" + NoDocument + "')");
                DB.sql.Execute("Call SP_OpenTransaction('LPH','" + NoDocument + "')");
            }
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {

            ((DataRowView)MasterBindingSource.Current).Row["nodoc"] = nodocTextBoxEx.Text;
            try
            {
                //cek masih ada outstanding PO atau PR
                /*
                if (MasterBindingSource.Position == MasterTable.Rows.Count)
                {
                    string query = "";
                    string errMsg = "";
                    if (omsTextEdit.EditValue.ToString().Contains("O"))
                    {
                        query = "Call SP_OutSpb('" + omsTextEdit.EditValue.ToString() + "')";
                        errMsg = "PO: ";
                    }
                    else
                    {
                        query = "Call SP_SelectPRforSpb('" + omsTextEdit.EditValue.ToString() + "')";
                        errMsg = "PR: ";
                    }

                    DataTable dtOutSpb = DB.sql.Select(query);
                    if (dtOutSpb.Rows.Count == 0)
                    {
                        MessageBox.Show(errMsg + omsTextEdit.EditValue.ToString() + " sudah terpenuhi");
                        return;
                    }
                }
                
                // sementara pakai untuk testing ntar dirubah
                if (omsTextEdit.Text.Substring(0,3) == "POI")
                {
                    if (textEditPList.Text == "")
                    throw new Exception("Harap mengisi Packinglist!");
                    if (textEditNoCont.Text == "")
                    throw new Exception("Harap mengisi No Container!");
                    if (remarkMemoEdit.Text == "")
                    throw new Exception("Harap mengisi Keterangan!");
                    for (int i = DetailTable.Rows.Count - 1; i >= 0; i--)
                    {
                        DataRow row = DetailTable.Rows[i];
                        if (row != null && row.RowState != DataRowState.Deleted)
                        {
                            if (row["qtyc"].ToString() == "0") throw new Exception("Qty Container tidak boleh nol !!");
                        }
                    }
                }
                */
                ((DataRowView)MasterBindingSource.Current).Row["oms"] = okl_rmaTextBoxEx.Text;
                base.tsbtnSave_Click(sender, e);

                if (this.mode == Mode.View)
                {
                    string date = ((DateTime)(dateDate.EditValue)).ToString("yyyyMMdd");
                    string jurnal = NoDocument;

                    // Check if LPB is from PR, no need to call SP_Save
                 
                    DB.sql.Execute("Call SP_Save(" + date + ",'LPJ'" + ",'" + jurnal + "')");

                    DataTable dtSpb = DB.sql.Select("select nodoc,no_bc,datedoc from docpd where nodoc = '" + jurnal + "'");
                    foreach (DataRow drSpb in dtSpb.Rows)
                    {
                        string nodoc = drSpb["no_bc"].ToString();
                        string lpb = drSpb["nodoc"].ToString();
                        string datedoc = drSpb["datedoc"].ToString();

                        DataTable dtTpb = DB.sql.Select("select IFNULL(b.JUMLAH_SATUAN,0) as JUMLAH_SATUAN,IFNULL(b.HARGA_INVOICE,0) as HARGA_INVOICE,IFNULL(b.HARGA_SATUAN,0) as HARGA_SATUAN,b.NETTO,b.KODE_SATUAN,b.KODE_KEMASAN,b.KODE_BARANG,IFNULL(b.JUMLAH_KEMASAN,0) as JUMLAH_KEMASAN,IFNULL(h.CIF_RUPIAH,0) as CIF_RUPIAH,URAIAN,h.NETTO,ifnull(b.CIF,0) as CIF from tpbdb.tpb_barang b, tpbdb.tpb_header h WHERE h.ID = b.ID_HEADER and b.ID_HEADER = (select ID from tpbdb.tpb_header WHERE NOMOR_AJU = '" + nodoc + "')");
                        foreach (DataRow drTpb in dtTpb.Rows)
                        {
                            double qty = Convert.ToDouble(drTpb["JUMLAH_SATUAN"]);
                            //double valbrg = Convert.ToDouble(drTpb["HARGA_INVOICE"]);
                            //double price = Convert.ToDouble(drTpb["HARGA_SATUAN"]);
                            //tpbRow["remark"] = drTpb["KODE_SATUAN"];
                            string unit = drTpb["KODE_KEMASAN"].ToString();
                            string inv = drTpb["KODE_BARANG"].ToString();
                            string remark = drTpb["URAIAN"].ToString();
                            double qty1 = Convert.ToDouble(drTpb["JUMLAH_KEMASAN"]);
                            double valtotal = Convert.ToDouble(drTpb["CIF_RUPIAH"]);
                            double valsubkon = Convert.ToDouble(drTpb["CIF"]);
                            double netto = Convert.ToDouble(drTpb["NETTO"]);

                            //DB.sql.Execute("update okd set price = '" + price + "', val = '" + valbrg + "' where okl = '" + omsTextBoxEx.EditValue.ToString() + "' and (inv = '" + inv + "' or remark like '%" + remark + "%')");
                            //DB.sql.Execute("update okl set val = '" + valsubkon + "' where okl = '" + omsTextBoxEx.EditValue.ToString() + "'");

                            //double hitung = valsubkon / qty;
                            //DataTable daTpb = DB.sql.Select("select qtygudang from spd where spm = '" + lpb + "'");
                            //foreach (DataRow dbTpb in daTpb.Rows)
                            //{
                            //    double qtyz = Convert.ToDouble(dbTpb["qtygudang"]);
                            //    double totalval = hitung * qtyz;
                            //    DB.sql.Execute("update bckeluar set val = '" + totalval + "' where nodoc = '" + nodoc + "' and (inv = '" + inv + "' or remark like '%" + remark + "%')");
                            //}
                            DB.sql.Execute("update bcmasuk set val = '" + valsubkon + "' where nodoc = '" + nodoc + "' and (inv = '" + inv + "' or remark like '%" + remark + "%')");
                        }
                    }

                    spbTextBoxEx.ExAutoCheck = false;
                }

                string dates = ((DateTime)(dateDate.EditValue)).ToString("yyyyMMdd");

                //DB.sql.Execute("Call SP_Save(" + dates + ",'LPJ'" + ",'" + NoDocument + "')");

                //DB.sql.Execute("update spb set shipper = null where shipper = ''");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            gcLpd.ExGridView.OptionsBehavior.Editable = false;
        }

        private void nodocTextBoxEx_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            nodocTextBoxEx.ExSqlQuery = "SELECT nodoc,datedoc,no_bc,nopen FROM docp,docpd where docp.docp=docpd.docp and docp.oms = '" + okl_rmaTextBoxEx.EditValue.ToString() + "'";

        }

        protected override void tsbtnCancel_Click(object sender, EventArgs e)
        {
            gcLpd.ExGridView.OptionsBehavior.Editable = false;
            base.tsbtnCancel_Click(sender, e);
            if (this.mode == Mode.View)
            {
                spbTextBoxEx.ExAutoCheck = false;
                DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base Diterima");
                DetailTable = DB.PopulateSelisih(DetailTable,"LPB");
            }
        }

        private void okl_rkaTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {
            DataRow row = okl_rmaTextBoxEx.ExGetDataRow();
            if (row == null)
                return;

            //    rmaTextEdit.EditValue = row["PR Retur"];
            ctrlSub.txtSub.EditValue = row["Kode Supplier"];

            if (MasterBindingSource.Position == MasterTable.Select(MasterBindingSource.Filter).Length)
            {
                DetailTable.Clear();
                GridLookUpEx invLookUp = gcLpd.ExGridView.Columns["inv"].ColumnEdit as GridLookUpEx;
                //invLookUp.Query = "select rma,inv,remark,loc,unit,qty1,qty,cct,no from rmb where rma='" + okl_rmaTextBoxEx.Text + "'";
                invLookUp.Query = "Call SP_OutSjT('" + okl_rmaTextBoxEx.EditValue.ToString() + "', 3)";
                invLookUp.TableName = "rmb_in";
                invLookUp.ClickButton();
            }
        }

        private void spbTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {            
            if (spbTextBoxEx.Text == "" || !spbTextBoxEx.ExIsValid())
                return;

            //if (MasterBindingSource.Position == MasterTable.Rows.Count)
            if (this.mode != Mode.View)
            {
                // Fill in Supplier Code
                //ctrlSub.txtSub.EditValue = spbTextBoxEx.ExGetDataRow()["sub"].ToString();
                //omsTextEdit.EditValue = spbTextBoxEx.ExGetDataRow()["oms"];
                //nopolTextEdit.EditValue = spbTextBoxEx.ExGetDataRow()["nopol"];
                //remarkMemoEdit.EditValue = spbTextBoxEx.ExGetDataRow()["remark"];
                ctrlSub.txtSub.EditValue = spbTextBoxEx.ExGetDataRow()["Kode Supplier"].ToString();
                omsTextEdit.EditValue = spbTextBoxEx.ExGetDataRow()["PO"];
                nopolTextEdit.EditValue = spbTextBoxEx.ExGetDataRow()["No Polisi"];
                remarkMemoEdit.EditValue = spbTextBoxEx.ExGetDataRow()["Keterangan"];
                gcLpd.ExGridControl.DataSource = null;
                //DetailTable.Clear();
                int tNo = 9999;
                foreach (DataRow dr in DetailTable.Rows)
                {
                    dr["no"] = tNo;
                    dr.Delete();
                    tNo++;
                }
                DataTable dtSpbd = DB.sql.Select("select * from spbd where spb='" + spbTextBoxEx.Text + "'");
                int no = 1;
                foreach (DataRow drSpbd in dtSpbd.Rows)
                {
                    DataRow drLpd = DetailTable.NewRow();
                    drLpd["lph"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
                    drLpd["no"] = no;
                    drLpd["inv"] = drSpbd["inv"];
                    drLpd["remark"] = drSpbd["remark"];
                    drLpd["loc"] = drSpbd["loc"];
                    //drLpd["qty"] = drSpbd["qty"];
                    //drLpd["qty1"] = drSpbd["qty1"];
                    drLpd["unit"] = drSpbd["unitgd"];
                    drLpd["qty1"] = drSpbd["qtytim"];
                    //drLpd["qty"] = DB.GetQtyInAlternativeUom(drLpd["inv"].ToString(), drLpd["unit"].ToString(), Convert.ToDouble(drLpd["qty1"]));
                    drLpd["qty"] = DB.GetQtyInBaseUom(drLpd["inv"].ToString(), drLpd["unit"].ToString(), Convert.ToDouble(drLpd["qty1"]));
                    drLpd["cct"] = drSpbd["cct"];
                    drLpd["etd"] = drSpbd["etd"];
                    DetailTable.Rows.Add(drLpd);
                    no++;
                }
                gcLpd.ExGridControl.DataSource = DetailTable;
                gcLpd.ExGridView.OptionsBehavior.Editable = true;
                SetGridViewSetting();
            }
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base Diterima");
            DetailTable = DB.PopulateSelisih(DetailTable,"LPB");
        }

        private void spbTextBoxEx_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            spbTextBoxEx.ExSqlQuery = "Call SP_SelectSPBforLPB('" + spbTextBoxEx.EditValue.ToString() + "')";
        }

        private void txtNo_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void jnspaTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dateDate_EditValueChanged(object sender, EventArgs e)
        {
            if (this.mode != Mode.View)
            {
                tglbc.EditValue = dateDate.EditValue.ToString();
            }
        }
    }
}

