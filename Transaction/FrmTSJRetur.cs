using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KASLibrary;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using MySql.Data.MySqlClient;

namespace CAS.Transaction
{
    public partial class FrmTSJRetur : CAS.Transaction.BaseTransaction
    {
        public FrmTSJRetur()
        {
            InitializeComponent();

            Utility.SetSqlInstance(pnlDetail, DB.sql);

            ToolStripMenuItem tsmiPrintPreview = new ToolStripMenuItem("Print Preview", null, new EventHandler(tsmiPrintPreview_Click));
            ToolStripMenuItem tsmiPrintDirectly = new ToolStripMenuItem("Print Directly", null, new EventHandler(tsmiPrintDirectly_Click));
            ToolStripDropDownButton tsbtnPrint = new ToolStripDropDownButton("Print", null, tsmiPrintPreview, tsmiPrintDirectly);
            tsbtnPrint.Image = MasterNavigator.Items["tsbtnPrint"].Image;
            MasterNavigator.Items.Insert(MasterNavigator.Items.IndexOfKey("tsbtnPrint"), tsbtnPrint);
            MasterNavigator.Items.RemoveByKey("tsbtnPrint");

            DetailTable.Columns.Add("Unit Base", typeof(String));
            MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);

            //gcxSjrd.ExGridControl.DataSource = sjrdBindingSource;
            gcxSjrd.ExGridControl.DataSource = DetailTable;
            gcxSjrd.ExTitleLabel.Text = "Detail Surat Jalan Retur / Jasa";
            gcxSjrd.ExGridView.OptionsBehavior.Editable = false;
            gcxSjrd.ExGridView.OptionsView.ShowGroupPanel = false;
            gcxSjrd.ExGridView.OptionsCustomization.AllowSort = false;
            
            gcxSjrd.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gcxSjrd.ExToolStrip.Items["tsbtnNew"].Enabled = false;
            
            //gcxSjrd.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
            //gcxSjrd.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            //gcxSjrd.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
            //gcxSjrd.ExToolStrip.Items["tsbtnNew"].Enabled = false;

            //gcxSjrd.ExGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(ExGridView_InitNewRow);
            //gcxSjrd.ExGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(ExGridView_CellValueChanged);

            //gcxSjrd.ExGridView.Columns["inv"].ColumnEdit = new GridLookUpEx(DB.sql, "", "spd", "inv", gcxSjrd.ExGridView, "", true, true, "");
            //gcxSjrd.ExGridView.Columns["inv"].ColumnEdit.Enter += new EventHandler(ExGridView_InvColumnEdit_Enter);

            gcxSjrd.ExGridView.Columns["no"].Visible = false;
            gcxSjrd.ExGridView.Columns["sjr"].Visible = false;
            gcxSjrd.ExGridView.Columns["price"].Visible = false;
            gcxSjrd.ExGridView.Columns["val"].Visible = false;

            SetGridViewCaption();

            //gcxSjrd.ExGridView.Columns["Unit Base"].VisibleIndex = DetailTable.Columns.IndexOf("qty");
            gcxSjrd.ExGridView.Columns["Unit Base"].OptionsColumn.AllowEdit = false;

            gcxSjrd.ExGridView.BestFitColumns();
            gcxSjrd.ExGridView.OptionsBehavior.Editable = false;
            gcxSjrd.ExGridView.OptionsSelection.MultiSelect = true;
            gcxSjrd.ExGridView.OptionsCustomization.AllowSort = false;

            gcxSjrd.ExGridView.Columns["okl"].Caption = "Purchase Order";
            gcxSjrd.ExGridView.Columns["inv"].Caption = "Kode Barang";
            gcxSjrd.ExGridView.Columns["remark"].Caption = "Nama Barang";
            gcxSjrd.ExGridView.Columns["loc"].Caption = "Loc";
            gcxSjrd.ExGridView.Columns["qty"].Caption = "Qty Base Dikirim";
            gcxSjrd.ExGridView.Columns["unit"].Caption = "Unit";
            gcxSjrd.ExGridView.Columns["qty1"].Caption = "Qty";
            gcxSjrd.ExGridView.Columns["nodsg"].Caption = "No Batch";

            gcxSjrd.ExGridView.Columns["okl"].VisibleIndex = 0;
            gcxSjrd.ExGridView.Columns["inv"].VisibleIndex = 1;
            gcxSjrd.ExGridView.Columns["remark"].VisibleIndex = 2;
            gcxSjrd.ExGridView.Columns["loc"].VisibleIndex = 3;
            gcxSjrd.ExGridView.Columns["nodsg"].VisibleIndex = 4;
            gcxSjrd.ExGridView.Columns["expired"].VisibleIndex = 5;
            gcxSjrd.ExGridView.Columns["qty1"].VisibleIndex = 6;
            gcxSjrd.ExGridView.Columns["unit"].VisibleIndex = 7;
            gcxSjrd.ExGridView.Columns["qty"].VisibleIndex = 8;
            gcxSjrd.ExGridView.Columns["Unit Base"].VisibleIndex = 9;//DetailTable.Columns.IndexOf("qty");

            spinTOP.Properties.MinValue = 0;
            spinTOP.Properties.MaxValue = Int32.MaxValue;

            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);

            DevExpress.XtraEditors.Controls.EditorButton btnReload = new DevExpress.XtraEditors.Controls.EditorButton();
            btnReload.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Redo;
            btnReload.ToolTip = "Reload data";
            spmTextBoxEx.Properties.Buttons.Add(btnReload);
            spmTextBoxEx.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(spmTextBoxEx_ButtonClick);
            //tsbtnPrint.Click += new EventHandler(tsbtnPrint_Click);
        }

        void tsmiPrintDirectly_Click(object sender, EventArgs e)
        {
            XtraReport report = new XtraReport();
            if (this.Tag.ToString() == "25l")
            {
                // set group_ to 2 SJT
                string path = Application.StartupPath + "\\Reports\\" + "InvoiceSJ" + ".repx";
                report.LoadState(path);
                report.DataSource = DB.sql.Select("call SP_PrintInvoice('Transaction.FrmTSJTransfer','" + this.NoDocument + "')");
            }
            else
            {
                string path = Application.StartupPath + "\\Reports\\" + "Invoice" + ".repx";
                report.LoadState(path);
                report.DataSource = DB.sql.Select("call SP_PrintInvoice('Transaction.FrmTSJRetur','" + this.NoDocument + "')");
                report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
                report.Bands[BandKind.PageFooter].Controls["xrLblKet"].Text = "KETERANGAN : " + remarkMemoEdit.EditValue.ToString();
                report.Bands[BandKind.PageFooter].Controls["lblSummary"].Visible = false;
                report.Bands[BandKind.PageFooter].Controls["lblSummary2"].Visible = true;
                report.Bands[BandKind.PageFooter].Controls["lblUMText"].Visible = false;
                report.Bands[BandKind.PageFooter].Controls["lblUM"].Visible = false;
                report.Bands[BandKind.PageFooter].Controls["lblDPPText"].Visible = false;
                report.Bands[BandKind.PageFooter].Controls["lblDPP"].Visible = false;
                report.Bands[BandKind.PageFooter].Controls["lblPPNText"].Visible = false;
                report.Bands[BandKind.PageFooter].Controls["lblPPN"].Visible = false;
                report.Bands[BandKind.PageFooter].Controls["lblTotal"].Visible = false;
            }
            report.PrintingSystem.ShowMarginsWarning = false;
            report.PaperName = "1/2A4";
            report.Print();
        }

        void tsmiPrintPreview_Click(object sender, EventArgs e)
        {
            XtraReport report = new XtraReport();
            if (this.Tag.ToString() == "25l")
            {
                // set group_ to 2 SJT
                string path = Application.StartupPath + "\\Reports\\" + "InvoiceSJ" + ".repx";
                report.LoadState(path);
                report.DataSource = DB.sql.Select("call SP_PrintInvoice('Transaction.FrmTSJTransfer','" + this.NoDocument + "')");
            }
            else
            {
                string path = Application.StartupPath + "\\Reports\\" + "Invoice" + ".repx";
                report.LoadState(path);
                report.DataSource = DB.sql.Select("call SP_PrintInvoice('Transaction.FrmTSJRetur','" + this.NoDocument + "')");
                report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
                report.Bands[BandKind.PageFooter].Controls["xrLblKet"].Text = "KETERANGAN : " + remarkMemoEdit.EditValue.ToString();
                report.Bands[BandKind.PageFooter].Controls["lblSummary"].Visible = false;
                report.Bands[BandKind.PageFooter].Controls["lblSummary2"].Visible = true;
                report.Bands[BandKind.PageFooter].Controls["lblUMText"].Visible = false;
                report.Bands[BandKind.PageFooter].Controls["lblUM"].Visible = false;
                report.Bands[BandKind.PageFooter].Controls["lblDPPText"].Visible = false;
                report.Bands[BandKind.PageFooter].Controls["lblDPP"].Visible = false;
                report.Bands[BandKind.PageFooter].Controls["lblPPNText"].Visible = false;
                report.Bands[BandKind.PageFooter].Controls["lblPPN"].Visible = false;
                report.Bands[BandKind.PageFooter].Controls["lblTotal"].Visible = false;
            }
            report.ShowPreview();
        }

        void spmTextBoxEx_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index > 0)
                spmTextBoxEx_EditValueChanged(sender, new EventArgs());
        }

        void SetGridViewCaption()
        {
            gcxSjrd.ExGridView.Columns["okl"].Caption = "Purchase Order";
            gcxSjrd.ExGridView.Columns["inv"].Caption = "Kode Barang";
            gcxSjrd.ExGridView.Columns["remark"].Caption = "Nama Barang";
            gcxSjrd.ExGridView.Columns["loc"].Caption = "Loc";
            gcxSjrd.ExGridView.Columns["qty1"].Caption = "Qty";
            gcxSjrd.ExGridView.Columns["unit"].Caption = "Unit";
            gcxSjrd.ExGridView.Columns["qty"].Caption = "Qty Base";
        }
        
        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
            gcxSjrd.ExGridView.BestFitColumns();
        }
        
        void ExGridView_New_Click(object sender, EventArgs e)
        {
            int idx = gcxSjrd.ExGridView.FocusedRowHandle;

            DataRow row = casDataSet.sjrd.NewRow();
            row["sjr"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
            row["qty"] = 0;
            row["qty1"] = 0;
            row["inv"] = "";
            row["loc"] = "";
            row["unit"] = "";
            row["no"] = DetailTable.Rows.Count + 1;
            casDataSet.sjrd.Rows.Add(row);

            for (int i = DetailTable.Rows.Count - 1; i >= idx; i--)
            {
                if (DetailTable.Rows[i] != null &&
                    DetailTable.Rows[i].RowState != DataRowState.Deleted)
                {
                    foreach (DataColumn col in DetailTable.Columns)
                    {
                        if (i == idx)
                        {
                            if (col.ColumnName != "sjr" && col.ColumnName != "no")
                                DetailTable.Rows[i][col] = col.DefaultValue;
                        }
                        else
                        {
                            if (col.ColumnName != "no")
                                DetailTable.Rows[i][col] = DetailTable.Rows[i - 1][col];
                        }
                    }
                }
            }
        }

        //void nopoTextEditQuery()
        //{
        //    String supplier = ctrlSub.txtSub.Text;
        //    nopoTextEdit.ExSqlQuery = "select oms.oms as PO, date as `Tanggal`, remark as Keterangan, sub as `Supplier`, aprov as `Approve`, oms.close as `Close` from oms  " +
        //                              "left outer join (select distinct oms,`close` from openpo where `close`=0) as openpo on oms.oms=openpo.oms where (oms.close=0 or (oms.close=1 and openpo.`close`=0)) and " +
        //                              " aprov=1 and `delete`=0 and jenispo<>1 and date<=" + ((DateTime)dateDate.EditValue).AddDays(1).ToString("yyyyMMdd");

        //    if (supplier != "") nopoTextEdit.ExSqlQuery += " and sub='" + supplier + "'";
        //    nopoTextEdit.ExFieldName = "PO";
        //}

        //private void nopoTextEdit_Enter(object sender, EventArgs e)
        //{
        //    nopoTextEditQuery();
        //}

        void ExGridView_Delete_Click(object sender, EventArgs e)
        {
            DB.DeleteDetailRows(gcxSjrd.ExGridView);
        }

        void SetDetailEditable(bool mode)
        {
            gcxSjrd.ExToolStrip.Items["tsbtnDelete"].Enabled = mode;
            gcxSjrd.ExToolStrip.Items["tsbtnNew"].Enabled = mode;
            //gcxSjrd.ExGridView.OptionsBehavior.Editable = mode;
            //if (mode)
            //    gcxSjrd.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            //else
            //    gcxSjrd.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            SetDetailEditable(true);
            //ctrlSupplier1.ReadOnly = false;
            spmTextBoxEx.ExAutoCheck = true;
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            nopoTextEdit.ExAutoCheck = true;
            //ctrlSupplier1.ReadOnly = false;
            spmTextBoxEx.ExAutoCheck = true;
            SetDetailEditable(true);
            DetailTable.Clear();
        }

        protected override void tsbtnCancel_Click(object sender, EventArgs e)
        {
            base.tsbtnCancel_Click(sender, e);
            if (this.mode == Mode.View)
            {
                SetDetailEditable(false);
                DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
                spmTextBoxEx.ExAutoCheck = false;
            }
        }

        void ClosePORetur()
        {
            string query = "select okl_rms from spm where spm='" + spmTextBoxEx.EditValue.ToString() + "'";
            string noPORetur = DB.sql.Select(query).Rows[0][0].ToString();
            DataTable dt = DB.sql.Select("Call SP_OutSpm('" + noPORetur + "',2)");
            if (dt.Rows.Count == 0)
            {
                query = "update rms set close=1 where rms='" + noPORetur + "'";
                DB.sql.Execute(query);
            }
        }

        protected override void tsbtnDelete_Click(object sender, EventArgs e)
        {
            base.tsbtnDelete_Click(sender, e);
            if (Convert.ToInt32(MasterTable.Rows[MasterBindingSource.Position]["delete"]) == 1)
            {
                DB.sql.Execute("Call SP_Delete('SJR','" + NoDocument + "')");
                DB.sql.Execute("Call SP_OpenTransaction('SJR','" + MasterTable.Rows[MasterBindingSource.Position]["spm"].ToString() + "')");
            }
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidateChildren();
                if (this.Tag.ToString() == "25l")
                {
                    // set group_ to 2 SJT
                    ((DataRowView)MasterBindingSource.Current).Row["group_"] = 2;
                }
                else
                {
                    // set group_ to 1 SJR
                    ((DataRowView)MasterBindingSource.Current).Row["group_"] = 1;
                }
                DetailBindingSource.EndEdit();
                if (gcxSjrd.ExGridView.EditingValue != null)
                    gcxSjrd.ExGridView.SetFocusedValue(gcxSjrd.ExGridView.EditingValue);
                DetailBindingSource.EndEdit();

                for (int i = DetailTable.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = DetailTable.Rows[i];
                    if (row != null && row.RowState != DataRowState.Deleted)
                        row[0] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;                      
                }

                ((DataRowView)MasterBindingSource.Current).Row["spm"] = spmTextBoxEx.Text;
                ((DataRowView)MasterBindingSource.Current).Row["duedate"] = ((DateTime)dateDate.EditValue).AddDays(Convert.ToDouble(spinTOP.EditValue));

                //cek apakah masih ada outstanding PO retur
                //if (MasterBindingSource.Position == MasterTable.Rows.Count)
                //{
                //    string spm = spmTextBoxEx.EditValue.ToString();
                //    string query = "select rms.rms from rms, spm where rms.rms=spm.okl_rms and spm.spm='" + spm + "'";
                //    string noPORetur = DB.sql.Select(query).Rows[0][0].ToString();
                //    DataTable dtOutSpm = DB.sql.Select("Call SP_OutSpm('" + noPORetur + "',2)");
                //    if (dtOutSpm.Rows.Count == 0)
                //    {
                //        MessageBox.Show("PO Retur: " + noPORetur + " sudah terpenuhi");
                //        return;
                //    }
                //}

                base.tsbtnSave_Click(sender, e);
                if (ctrlSub.txtSub.Text == "1120115")
                    button1_Click(sender, e);

                if (this.mode == Mode.View)
                {
                    ClosePORetur();
                    string date = Convert.ToDateTime(dateDate.EditValue).ToString("yyyyMMdd");
                    string no = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
                    if (this.Tag.ToString() == "25l")
                    {
                        DB.sql.Execute("Call SP_Save(" + date + ",'SJT','" + no + "')");
                    }
                    else
                    {
                        DB.sql.Execute("Call SP_Save(" + date + ",'SJR','" + no + "')");
                    }
                    
                    spmTextBoxEx.ExAutoCheck = false;
                    SetDetailEditable(false);
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
                string inv = (string)gcxSjrd.ExGridView.GetFocusedRowCellValue("inv");
                string unit = (string)gcxSjrd.ExGridView.GetFocusedRowCellValue("unit");
                double qty1 = (double)gcxSjrd.ExGridView.GetFocusedRowCellValue("qty1");

                if (inv.Substring(0, 1) != "9")
                {
                    if (inv != "" && unit != "")
                        gcxSjrd.ExGridView.SetFocusedRowCellValue(gcxSjrd.ExGridView.Columns["qty"], DB.GetQtyInBaseUom(inv, unit, qty1));
                    //ExGridView_ValidateRow(sender, new ValidateRowEventArgs(gcOmd.ExGridView.FocusedRowHandle, gcOmd.ExGridView.GetRow(gcOmd.ExGridView.FocusedRowHandle)));
                }
            }
        }

        void ExGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gcxSjrd.ExGridView.GetDataRow(e.RowHandle);
            row["sjr"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
            row["no"] = DetailTable.Rows.Count + 1;
        }

        void ExGridView_InvColumnEdit_Enter(object sender, EventArgs e)
        {
            GridLookUpEx invLookUp = (GridLookUpEx)gcxSjrd.ExGridView.Columns["inv"].ColumnEdit;
            invLookUp.Query = "Select spm, inv, loc, remark, qtygudang as qty1, unit, no from spd where spm='" + spmTextBoxEx.EditValue.ToString() + "'";
        }

        private void FrmTSJRetur_Load(object sender, EventArgs e)
        {
            tglbc.Properties.MinValue = Utility.FirstDateInMonth((DateTime)dateDate.EditValue);
            tglbc.Properties.MaxValue = Utility.LastDateInMonth((DateTime)dateDate.EditValue).AddHours(23);

            if (this.Tag.ToString() == "25l")
            {
                    Filter = "group_= 2";
            }
            else
            {
                 Filter = "group_= 1";
            }
                DataTable temp = MasterTable.Copy();
                DataRow[] dRows = temp.Select(Filter);
                MasterTable.Clear();
                foreach (DataRow dr in dRows) MasterTable.ImportRow(dr);
                if (MasterTable.Rows.Count == 0)
                {
                    setMode(Mode.View);
                }

                ctrlSub.txtSub.DataBindings.Add("EditValue", MasterBindingSource, "sub");
                ctrlSub.txtSub.EditValueChanged += new EventHandler(txtSub_EditValueChanged);

                PopulateDetail();
            //ctrlSub.txtSub.DataBindings.Add("EditValue", MasterBindingSource, "sub");
            //ctrlSub.txtSub.EditValueChanged += new EventHandler(txtSub_EditValueChanged);
            txtSub_EditValueChanged(ctrlSub.txtSub, new EventArgs());            
            //spmTextBoxEx.ExSqlQuery = "Call SP_SelectSPMforSJ(2,'" + spmTextBoxEx.EditValue.ToString() + "')";
            //spmTextBoxEx.ExFieldName = "SPM";
            if (MasterBindingSource.Position == MasterTable.Rows.Count)
                spmTextBoxEx.ExAutoCheck = true;
            else
                spmTextBoxEx.ExAutoCheck = false;
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
            gcxSjrd.ExGridView.BestFitColumns();

            if (MasterBindingSource.Count == 0)
            {
                if (DB.casUser.AllowInsert(this.Tag.ToString()))
                    tsbtnNew.PerformClick();
                else
                    setMode(Mode.View);
            }
        }

        private void PopulateDetail()
        {
            DetailTable.Clear();
            //DetailAdapter = null;
            string query = "";
            if (MasterBindingSource.Position < 0 || MasterTable.Rows.Count == 0) return;

            query = "select * from " + DetailTable.TableName + " where " + DetailTable.Columns[0].ColumnName + "='" + MasterTable.Rows[MasterBindingSource.Position][0].ToString() + "'";

            DetailAdapter = DB.sql.SelectAdapter(query);
            try
            {
                DetailAdapter.Fill(DetailTable);
            }
            catch (Exception ex)
            {
            }
        }

        void txtSub_EditValueChanged(object sender, EventArgs e)
        {
            DataRow row = ctrlSub.txtSub.ExGetDataRow();
            if (row == null)
                return;
            curcur.EditValue = row["cur"].ToString();
            spinTOP.EditValue = row["Top"].ToString();
            //if (MasterBindingSource.Position == MasterTable.Rows.Count)
            //{
            //    shiptoaddressMemoEdit.EditValue = row["Ship Address"];
            //    shiptonameTextEdit.EditValue = row["Ship To"];
            //    if (shiptonameTextEdit.EditValue.ToString() == "")
            //        shiptonameTextEdit.EditValue = row["Nama"].ToString();
            //}

            String supplier = ctrlSub.txtSub.Text;

            string query = "select d.oms,d.inv,d.remark,d.qty,d.loc from omd d, oms s where d.oms = s.oms and s.sub='" + supplier + "'";
            nopoTextEdit.ExFieldName = "oms";

            nopoTextEdit.ExSqlQuery = query;
        }
      
        private void spmTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {
            if (spmTextBoxEx.ExSqlInstance == null)
                return;

            DataRow row = spmTextBoxEx.ExGetDataRow();
            if (row == null)
                return;

            ctrlSub.txtSub.EditValue = row["Kode Supplier"];
            nopolTextEdit.EditValue = row["No Polisi"];
            angkutanTextEdit.EditValue = row["Angkutan"];
            remarkMemoEdit.EditValue = row["Keterangan"];

            //if (MasterBindingSource.Position == MasterTable.Select(MasterBindingSource.Filter).Length)
            if (this.mode != Mode.View)
            {
                //DetailTable.Clear();
                int tNo = 9999;
                foreach (DataRow dr in DetailTable.Rows)
                {
                    dr["no"] = tNo;
                    dr.Delete();
                    tNo++;
                }
                string query = "Select * from spd where spm='" + spmTextBoxEx.EditValue.ToString() + "'";
                DataTable dtSjrd = DB.sql.Select(query);
                int no = 1;
                foreach (DataRow dr in dtSjrd.Rows)
                {
                    DataRow drSjrd = DetailTable.NewRow();
                    drSjrd["sjr"] = ludSeri.EditValue.ToString() + "-" + txtPeriod.EditValue.ToString() + "-" + txtNo.EditValue.ToString();
                    drSjrd["okl"] = dr["okl"];
                    drSjrd["inv"] = dr["inv"];
                    drSjrd["loc"] = dr["loc"];
                    drSjrd["remark"] = dr["remark"];
                    drSjrd["unit"] = dr["unitgudang"];
                    drSjrd["qty1"] = dr["qtygudang"];
                    drSjrd["qty"] = dr["qty"];
                    drSjrd["nodsg"] = dr["nodsg"];
                    drSjrd["expired"] = dr["expired"];
                    drSjrd["no"] = no;

                    DataTable dtprice = DB.sql.Select("select * from pord where por='" + drSjrd["okl"] + "' and inv='" + drSjrd["inv"] + "' and remark ='" + drSjrd["remark"] + "'");
                    if (dtprice.Rows.Count > 0)
                    {
                        if (drSjrd["unit"].ToString() == dtprice.Rows[0]["unit"].ToString())
                            drSjrd["price"] = dtprice.Rows[0]["price"];
                        else
                            drSjrd["price"] = (double)dtprice.Rows[0]["val"] / (DB.GetQtyInBaseUom(drSjrd["inv"].ToString(), drSjrd["unit"].ToString(), (double)dtprice.Rows[0]["qty"]));
                    }
                    drSjrd["val"] = (double)drSjrd["qty1"] * (double)drSjrd["price"];
                    drSjrd["loc"] = drSjrd["loc"];
                    drSjrd["unit"] = drSjrd["unit"];
                    drSjrd["qty1"] = drSjrd["qty1"];
                    drSjrd["qty"] = DB.GetQtyInBaseUom(drSjrd["inv"].ToString(), drSjrd["unit"].ToString(), Convert.ToDouble(drSjrd["qty1"]));
                    DetailTable.Rows.Add(drSjrd);
                    no++;
                }
                gcxSjrd.ExGridControl.DataSource = DetailTable;
                DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
            }
        }

        private void txtAlias_EditValueChanged(object sender, EventArgs e)
        {
            //if (txtAlias.ExSqlInstance == null)
            //    return;

            //DataRow row = txtAlias.ExGetDataRow();
            //if (row == null)
            //{
            //    //shiptonameTextEdit.Text = "";
            //    //shiptoaddressMemoEdit.Text = "";
            //    return;
            //}
            //shiptonameTextEdit.Text = row["Ship To"].ToString();
            //shiptoaddressMemoEdit.Text = row["Ship Address"].ToString();
        }

        private void spmTextBoxEx_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (this.Tag.ToString() == "25l")
            {
                spmTextBoxEx.ExSqlQuery = "Call SP_SelectSPMforSJ(4,'" + spmTextBoxEx.EditValue.ToString() + "')";
            }
            else
            {
                spmTextBoxEx.ExSqlQuery = "Call SP_SelectSPMforSJ(2,'" + spmTextBoxEx.EditValue.ToString() + "')";
         
            }
            spmTextBoxEx.ExFieldName = "SPM";
        }

        private void dateDate_EditValueChanged(object sender, EventArgs e)
        {
            if (this.mode != Mode.View)
            {
                tglbc.EditValue = dateDate.EditValue.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inv = "" ;
            double qty1 = 0;
            string unit = "";

            MySqlConnection conn1 = null;
            conn1 = new MySqlConnection("server = 192.168.15.203; database= pssa ; userid=root; pwd=database");
            conn1.Open();
            string date = Convert.ToDateTime(dateDate.EditValue).ToString("yyyyMMdd");
            foreach (DataRow dr in DetailTable.Rows)
            {
               inv = dr["inv"].ToString() ;
               qty1 = (double) dr["qty1"];
               unit = dr["unit"].ToString();

            }
            string query = "SELECT F_MakeLPB('" + NoDocument + "','2120251',''," + date + ",'" + inv + "'," + qty1 + ", '" + unit + "', 0, 'Remark test', 'L 1233','" + nopoTextEdit.Text + "')";
            MySqlCommand command = new MySqlCommand(query, conn1);
            command.ExecuteNonQuery(); 


        }
    }
}

