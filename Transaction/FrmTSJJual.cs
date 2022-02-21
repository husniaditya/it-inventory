using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using KASLibrary;
using DevExpress.XtraReports.UI;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace CAS.Transaction
{
    public partial class FrmTSJJual : BaseTransaction
    {

        Boolean first = false;
        public FrmTSJJual()
        {
            InitializeComponent();

            ToolStripMenuItem tsmiPrintPreview = new ToolStripMenuItem("Print Preview Detail", null, new EventHandler(tsmiPrintPreview_Click));
            ToolStripMenuItem tsmiPrintPreviewGlobal = new ToolStripMenuItem("Print Preview Global", null, new EventHandler(tsmiPrintPreviewGlobal_Click));
            ToolStripMenuItem tsmiPrintDirectly = new ToolStripMenuItem("Print Directly", null, new EventHandler(tsmiPrintDirectly_Click));
            ToolStripDropDownButton tsbtnPrint = new ToolStripDropDownButton("Print", null, tsmiPrintPreview, tsmiPrintPreviewGlobal, tsmiPrintDirectly);
            tsbtnPrint.Image = MasterNavigator.Items["tsbtnPrint"].Image;
            MasterNavigator.Items.Insert(MasterNavigator.Items.IndexOfKey("tsbtnPrint"), tsbtnPrint);
            MasterNavigator.Items.RemoveByKey("tsbtnPrint");

            DetailTable.Columns.Add("Unit Base", typeof(String));
            MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);

            Utility.SetSqlInstance(pnlDetail, DB.sql);

            gcxSjd.ExGridControl.DataSource = sjdBindingSource;
            gcxSjd.ExTitleLabel.Text = "Detail Surat Jalan Penjualan";
            
            gcxSjd.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcxSjd.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
            
            //gcxSjd.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
            gcxSjd.ExToolStrip.Items["tsbtnNew"].Enabled = false;

            //gcxSjd.ExGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(ExGridView_InitNewRow);
            //gcxSjd.ExGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(ExGridView_CellValueChanged);

            //gcxSjd.ExGridView.Columns["inv"].ColumnEdit = new GridLookUpEx(DB.sql, "", "spd", "inv", gcxSjd.ExGridView, "", true, true, "Inventory");
            //gcxSjd.ExGridView.Columns["inv"].ColumnEdit.Enter += new EventHandler(ExGridView_InvColumnEdit_Enter);

            gcxSjd.ExGridView.Columns["no"].Visible = false;
            gcxSjd.ExGridView.Columns["sjh"].Visible = false;
            gcxSjd.ExGridView.Columns["mor"].Visible = false;
            gcxSjd.ExGridView.Columns["price"].Visible = false;
            gcxSjd.ExGridView.Columns["val"].Visible = false;

            gcxSjd.ExGridView.Columns["mor"].Caption = "MO";
            gcxSjd.ExGridView.Columns["okl"].Caption = "Sales Order";
            gcxSjd.ExGridView.Columns["nodsg"].Caption = "No Batch";
            gcxSjd.ExGridView.Columns["inv"].Caption = "Kode Barang";
            gcxSjd.ExGridView.Columns["remark"].Caption = "Nama Barang";
            gcxSjd.ExGridView.Columns["loc"].Caption = "Loc";
            gcxSjd.ExGridView.Columns["qty1"].Caption = "Qty";
            gcxSjd.ExGridView.Columns["unit"].Caption = "Unit";
            gcxSjd.ExGridView.Columns["qty"].Caption = "Qty Base";
            gcxSjd.ExGridView.Columns["nopoc"].Caption = "No PO Cust";
            gcxSjd.ExGridView.Columns["nopoc"].OptionsColumn.AllowEdit = false;

            gcxSjd.ExGridView.Columns["okl"].VisibleIndex = 0;
            gcxSjd.ExGridView.Columns["nopoc"].VisibleIndex = 1;
            gcxSjd.ExGridView.Columns["inv"].VisibleIndex = 2;
            gcxSjd.ExGridView.Columns["remark"].VisibleIndex = 3;
            gcxSjd.ExGridView.Columns["loc"].VisibleIndex = 4;
            gcxSjd.ExGridView.Columns["nodsg"].VisibleIndex = 5;
            gcxSjd.ExGridView.Columns["expired"].VisibleIndex = 6;
            gcxSjd.ExGridView.Columns["qty1"].VisibleIndex = 7;
            gcxSjd.ExGridView.Columns["unit"].VisibleIndex = 8;
            gcxSjd.ExGridView.Columns["qty"].VisibleIndex = 9;
            gcxSjd.ExGridView.Columns["Unit Base"].VisibleIndex = 10;

            gcxSjd.ExGridView.Columns["nodsg"].ColumnEdit = new GridLookUpEx(DB.sql, "Call Sp_GetStockBatch(" + DateTime.Now.ToString("yyyyMMdd") + ",'')", "", "No Batch", gcxSjd.ExGridView, "", true, true, "Batch");
            gcxSjd.ExGridView.Columns["nodsg"].ColumnEdit.Enter += new EventHandler(DsgColumnEdit_Enter);

            //gcxSjd.ExGridView.Columns["Unit Base"].VisibleIndex = DetailTable.Columns.IndexOf("qty");
            gcxSjd.ExGridView.Columns["Unit Base"].OptionsColumn.AllowEdit = false;

            gcxSjd.ExGridView.BestFitColumns();
            gcxSjd.ExGridView.OptionsBehavior.Editable = false;
            gcxSjd.ExGridView.OptionsSelection.MultiSelect = true;
            gcxSjd.ExGridView.OptionsCustomization.AllowSort = false;
            gcxSjd.ExGridView.OptionsView.ShowGroupPanel = false;

            spinTOP.Properties.MinValue = 0;
            spinTOP.Properties.MaxValue = Int32.MaxValue;

            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
            tsbtnRefresh.Click += new EventHandler(tsbtnRefresh_Click);

            DevExpress.XtraEditors.Controls.EditorButton btnReload = new DevExpress.XtraEditors.Controls.EditorButton();
            btnReload.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Redo;
            btnReload.ToolTip = "Reload data";
            spmTextBoxEx.Properties.Buttons.Add(btnReload);
            spmTextBoxEx.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(spmTextBoxEx_ButtonClick);
        }

        void spmTextBoxEx_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index > 0)
            {          
                 if (this.mode == Mode.Edit)
                 DB.sql.Execute("delete from sjd where sjh='" + NoDocument + "'");
                 spmTextBoxEx_EditValueChanged(sender, new EventArgs());
            }

        }

        void ExGridView_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                DB.DeleteDetailRows(gcxSjd.ExGridView);
            }
            catch (Exception ex)
            {
                DB.sql.Execute("delete from sjd where sjh='" + NoDocument + "'");
                spmTextBoxEx.EditValue = "";
            }
        }

        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
            gcxSjd.ExGridView.BestFitColumns();
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
            inv = gcxSjd.ExGridView.GetFocusedRowCellValue("inv").ToString();
            if (gcxSjd.ExGridView.GetFocusedRowCellValue("inv") != null)
                (gcxSjd.ExGridView.Columns["nodsg"].ColumnEdit as GridLookUpEx).Query = "Call Sp_GetStockBatch(" + DateTime.Now.ToString("yyyyMMdd") + ",'" + inv + "')";
        }

        private void FrmTSJJual_Load(object sender, EventArgs e)
        {
            Utility.SetReadOnly(txtTotalqty, true);
            Utility.SetReadOnly(globalBoxEx, true);
            Utility.SetReadOnly(txtTotalqtykemasan, true);

            ctrlSub.txtSub.DataBindings.Add("EditValue", MasterBindingSource, "sub");
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
            ctrlSub.txtSub.EditValueChanged += new EventHandler(txtSub_EditValueChanged);
            //txtSub_EditValueChanged(ctrlSub.txtSub, new EventArgs());
            //spmTextBoxEx.ExSqlQuery = "select spm as SPM, date as Tanggal, sub as Customer, remark as Keterangan, nopol as `No Polisi`, angkutan as Angkutan, appspm as Approve from spm where spm not in (select spm from sjh) and appspm=1 and group_=1";
            //spmTextBoxEx.ExSqlQuery = "Call SP_SelectSPMforSJ(1,'" + spmTextBoxEx.EditValue.ToString() + "')";
            //spmTextBoxEx.ExFieldName = "SPM";
            spmTextBoxEx.ExAutoCheck = false;

            if (first == false)
            {
                ceksentsmu();
                first = true;
            }

        }

        void txtSub_EditValueChanged(object sender, EventArgs e)
        {
            /*
            string txtsjlnya = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
            string strbtnSMU = "select left(nopoc,1) as nopoc from sjd,sjh,inv where sjh.sjh='" + txtsjlnya + "' and sjd.sjh=sjh.sjh and sjh.sub='1110003' and trim(sjd.mor)='' and sjd.inv=inv.inv and trim(inv.oldinv1)<>''";
            DataTable dtSMU = DB.sql.Select(strbtnSMU);
            string txtnopocnya = "";
            if (dtSMU.Rows.Count > 0)
            {
                txtnopocnya = dtSMU.Rows[0]["nopoc"].ToString();
            }
             if (ctrlSub.txtSub.Text.Trim() == "1110003")
                buttonCallSMU.Enabled = true;
            else
                buttonCallSMU.Enabled = false;
               
            */
            txtAlias.ExSqlQuery = "Call SP_LookUpSubto('" + ctrlSub.txtSub.EditValue.ToString() + "')";

        }

        private void spmTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {
            if (spmTextBoxEx.Text == "" || !spmTextBoxEx.ExIsValid())
                return;

            //if (MasterBindingSource.Position == MasterTable.Select(MasterBindingSource.Filter).Length)
            if (this.mode != Mode.View)
            {
                // Fill in Supplier Info
                DataRow row = spmTextBoxEx.ExGetDataRow();
                ctrlSub.txtSub.EditValue = row["Customer"];
                nopolTextEdit.EditValue = row["No Polisi"];
                angkutanTextBoxEx.EditValue = row["Angkutan"];
                remarkMemoEdit.EditValue = row["Keterangan"];
                no_conTextEdit.EditValue = row["No Container"];
                globalBoxEx.EditValue = row["kodeglobal"];
                txtTotalqtykemasan.EditValue = row["totqtykemasan"];
                txtTotalqty.EditValue = row["totqty"];
                // Get ShipTo Info
                if (ctrlSub.txtSub.Text.Trim() != "1110003")
                {
                    string shiptoQuery = "select shiptoname, shiptoaddress as shiptoaddress from okl where okl = (select okl from spd where spm='" + row["SPM"].ToString() + "' limit 1)";
                    DataTable dtShipto = DB.sql.Select(shiptoQuery);
                    if (dtShipto.Rows.Count > 0)
                    {
                        shiptonameTextBoxEx.EditValue = dtShipto.Rows[0]["shiptoname"];
                        shiptoaddressMemoEdit.EditValue = dtShipto.Rows[0]["shiptoaddress"];
                    }
                }
                //DetailTable.Clear();
                //DetailBindingSource.EndEdit();
                int tNo = 9999;
                foreach (DataRow dr in DetailTable.Rows)
                {
                    dr["no"] = tNo;
                    dr.Delete();
                    tNo++;
                }

                DataTable dtSpd = DB.sql.Select("select * from spd where spm='" + spmTextBoxEx.Text + "'");
                int no = 1;
                foreach (DataRow drSpd in dtSpd.Rows)
                {
                    DataRow drSjd = DetailTable.NewRow();
                    drSjd["sjh"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
                    drSjd["no"] = no;
                    drSjd["nodsg"] = drSpd["nodsg"];
                    drSjd["inv"] = drSpd["inv"];
                    drSjd["remark"] = drSpd["remark"];
                    drSjd["okl"] = drSpd["okl"];
                    drSjd["mor"] = drSpd["mor"];
                    DataTable dtNoPoC = DB.sql.Select("select * from okl where okl='" + drSpd["okl"]+ "'");
                    if (dtNoPoC.Rows.Count > 0)
                    {
                        drSjd["nopoc"] = dtNoPoC.Rows[0]["nopoc"];
                    }
                    DataTable dtprice = DB.sql.Select("select * from okd where okl='" + drSpd["okl"] + "' and inv='"+ drSpd["inv"] +"' and remark ='"+ drSpd["remark"] +"'");
                    if (dtprice.Rows.Count > 0)
                    {
                        if (drSpd["unitgudang"].ToString() == dtprice.Rows[0]["unit"].ToString())
                            drSjd["price"] = dtprice.Rows[0]["price"];
                        else
                            drSjd["price"] = (double)dtprice.Rows[0]["val"] / (DB.GetQtyInBaseUom(drSjd["inv"].ToString(), drSjd["unit"].ToString(), (double)dtprice.Rows[0]["qty"]));
                    }
                    drSjd["val"] = (double)drSpd["qtygudang"] * (double)drSjd["price"];                    
                    drSjd["loc"] = drSpd["loc"];
                    drSjd["unit"] = drSpd["unitgudang"];
                    drSjd["qty1"] = drSpd["qtygudang"];
                    drSjd["qty"] = DB.GetQtyInBaseUom(drSjd["inv"].ToString(), drSjd["unit"].ToString(), Convert.ToDouble(drSjd["qty1"]));
                    DetailTable.Rows.Add(drSjd);
                    no++;
                }
                DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
            }
        }

        void SetDetailEditable(bool mode)
        {
            gcxSjd.ExToolStrip.Items["tsbtnDelete"].Enabled = mode;
            gcxSjd.ExToolStrip.Items["tsbtnNew"].Enabled = mode;
            //gcxSjd.ExGridView.OptionsBehavior.Editable = mode;
            //if (mode)
            //    gcxSjd.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            //else
            //    gcxSjd.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
        }

        void tsmiPrintDirectly_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "InvoiceSJ" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_PrintInvoice('Transaction.FrmTSJJual','" + this.NoDocument + "')");
            report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
            /*
            report.Bands[BandKind.PageFooter].Controls["lblSummary"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblSummary2"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblUMText"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblUM"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblDPPText"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblDPP"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblPPNText"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblPPN"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblTotal"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["xrLblKet"].Text = "Ket: " + remarkMemoEdit.Text;
             */
            report.PrintingSystem.ShowMarginsWarning = false;
            report.PaperName = "1/2A4";
            report.Print();
        }

        void tsmiPrintPreview_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "InvoiceSJ" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_PrintInvoice('Transaction.FrmTSJJual','" + this.NoDocument + "')");
            report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
            /*
            report.Bands[BandKind.PageFooter].Controls["lblSummary"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblSummary2"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblUMText"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblUM"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblDPPText"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblDPP"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblPPNText"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblPPN"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblTotal"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["xrLblKet"].Text = "Ket: " + remarkMemoEdit.Text;
             */
            report.ShowPreview();
        }

        void tsmiPrintPreviewGlobal_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "InvoiceSJGlobal" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_PrintInvoice('Transaction.FrmTSJJualGlobal','" + this.NoDocument + "')");
            report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
            /*
            report.Bands[BandKind.PageFooter].Controls["lblSummary"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblSummary2"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblUMText"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblUM"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblDPPText"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblDPP"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblPPNText"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblPPN"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblTotal"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["xrLblKet"].Text = "Ket: " + remarkMemoEdit.Text;
             */
            report.ShowPreview();
        }

        void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            base.tsbtnRefresh_Click(sender, e);
            ceksentsmu();
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            
            SetDetailEditable(true);
            //ctrlSub.ReadOnly = false;
            DataTable dt_oto = DB.sql.Select("SELECT usr.* FROM usr,usrlevel where usr.role=usrlevel.role and trim(user) ='" + DB.casUser.User.ToString() + "'");
            DataTable cantedit = DB.sql.Select("SELECT klr FROM kll where kll.sjh='"+ NoDocument +"'");


            if (this.mode == Mode.Edit && dt_oto.Rows[0]["pswd"].ToString().Trim() == "" && (cantedit.Rows.Count > 0 || DB.casUser.ToString() == "Hartofa" ))
            {
                if (cantedit.Rows.Count > 0)
                {
                    MessageBox.Show("Dokumen Sudah di Invoicekan, hapus reference transaksi di Invoice Penjualan");
                    base.tsbtnCancel_Click(sender, e);
                }
                else
                {
                    PassOto frmDoc = new PassOto();
                    if (frmDoc.ShowDialog() == DialogResult.OK)
                    {
                        /*
                        ctrlSub.ReadOnly = false;
                        gcxSjd.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
                        gcxSjd.ExToolStrip.Items["tsbtnNew"].Enabled = true;
                        gcxSjd.ExGridView.OptionsBehavior.Editable = true;
                        gcxSjd.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                        copyDetailTable.Clear();
                        copyDetailTable = DetailTable.Copy();
                         */
                        base.tsbtnEdit_Click(sender, e);
                    }
                    else
                    {
                        base.tsbtnCancel_Click(sender, e);
                    }
                }
            }
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            //ctrlSub.ReadOnly = false;
            Utility.SetReadOnly(txtTotalqty, true);
            Utility.SetReadOnly(globalBoxEx, true);
            Utility.SetReadOnly(txtTotalqtykemasan, true);
            spmTextBoxEx.ExAutoCheck = true;
            SetDetailEditable(true);
            DetailTable.Clear();
        }

        protected override void tsbtnCancel_Click(object sender, EventArgs e)
        {            
            spmTextBoxEx.ExAutoCheck = false;
            base.tsbtnCancel_Click(sender, e);
            if (this.mode == Mode.View)
            {
                SetDetailEditable(false);
            }
            //ctrlSub.ReadOnly = true;
        }

        void CloseSO()
        {
            foreach (DataRow row in DetailTable.Rows)
            {
                string query = "Call Sp_OutSpm('" + row["okl"].ToString() + "',11)";
                DataTable dt = DB.sql.Select(query);
                if (dt.Rows.Count == 0)
                    DB.sql.Execute("update okl set close=1 where okl='" + row["okl"].ToString() + "'");
            }
        }

        protected override void tsbtnDelete_Click(object sender, EventArgs e)
        {
            base.tsbtnDelete_Click(sender, e);
            if (Convert.ToInt32(MasterTable.Rows[MasterBindingSource.Position]["delete"]) == 1)
                DB.sql.Execute("Call SP_Delete('SJL','" + NoDocument + "')");
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate Controls
                this.ValidateChildren();

                // START CEK DATA SUDAH DI TPB
                DataTable dtTpb = DB.sql.Select("select spm.nodoc as nodoc,COUNT(spd.inv) AS kount from spm,spd WHERE spm.spm = spd.spm and spm.spm = '" + spmTextBoxEx.Text + "' AND LEFT(spd.inv,2) BETWEEN 11 AND 81 and left(sub,3) != '121' GROUP BY spm.spm");
                foreach (DataRow drTpb in dtTpb.Rows)
                {
                    double kount = Convert.ToDouble(drTpb["kount"]);
                    string nodoc = drTpb["nodoc"].ToString();

                    if (nodoc == "" && kount > 0)
                    {
                        throw new Exception("Transaksi " + spmTextBoxEx.Text + " harap diinput TPB terlebih dahulu");
                        //MessageBox.Show("Detail Transaksi belum terisi");
                        //return;
                    }
                }
                // END CEK DATA SUDAH DI TPB

                // Check Required Entries
                if (nopolTextEdit.Text.Trim() == "")
                    throw new Exception("No polisi harus diisi!");
                if (ctrlSub.txtSub.Text.Trim() == "1110003")
                {
                    if (shiptonameTextBoxEx.Text.Trim() == "")
                        throw new Exception("shipto PT.SMU harus di isi!");
                }
                DetailBindingSource.EndEdit();
                
                for (int i = DetailTable.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = DetailTable.Rows[i];
                    if (row != null && row.RowState != DataRowState.Deleted)
                    {
                        if (spmTextBoxEx.EditValue.ToString().Trim() == "")
                            throw new Exception("Anda harus mendelete detil barang terlebih dahulu jika nomor SPM kosong ");

                /*           
                        row[0] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;

                        //cek stock
                        string query = "select F_GetStock(@tgl,'@inv','@loc','@nodsg')";
                        query = query.Replace("@tgl", ((DateTime)dateDate.EditValue).ToString("yyyyMMdd"));
                        query = query.Replace("@inv", row["inv"].ToString()).Replace("@loc", row["loc"].ToString());
                        query = query.Replace("@nodsg", row["nodsg"].ToString());
                        double stockQty = 0;
                        if (this.mode == Mode.Edit)
                            stockQty = Convert.ToDouble(row["qty"]);
                        if (DB.sql.Select(query).Rows[0][0] != DBNull.Value)
                            stockQty = stockQty + Convert.ToDouble(DB.sql.Select(query).Rows[0][0]);
                        string errMsg = "";
                        if (row["nodsg"].ToString() != "")
                            errMsg = row["nodsg"].ToString() + " - ";
                        errMsg = errMsg + row["inv"].ToString() + " - " + row["loc"].ToString();
                        if (stockQty < (double)(row["qty"]) && !row["inv"].ToString().StartsWith("7"))
                        {
                            //     MessageBox.Show("Stock " + errMsg + " tidak mencukupi");
                            throw new Exception("Stock " + errMsg + " tidak mencukupi");
                        }
                        //          MessageBox.Show("Stock " + errMsg + " tidak mencukupi");

                */
                        //cek apakah masih ada outstanding SO/MO atau tidak u/ new record
                        //tidak bisa cek status close krn close manual 
                        string okl = row["okl"].ToString();
                        string mor = row["mor"].ToString();
                        //if (MasterBindingSource.Position == MasterTable.Rows.Count)
                        //{
                        //    if (mor == "")
                        //    {
                        //        DataTable dtOutSpm = DB.sql.Select("Call SP_OutSpm('" + okl + "',11)");
                        //        if (dtOutSpm.Rows.Count == 0 && okl != "")
                        //            throw new Exception("SO: " + okl + " sudah terpenuhi");
                        //    }
                        //    else
                        //    {
                        //        DataTable dtOutSpm = DB.sql.Select("Call SP_OutSpm('" + mor + "',12)");
                        //        if (dtOutSpm.Rows.Count == 0)
                        //            throw new Exception("MO: " + mor + " sudah terpenuhi");
                        //    }
                        //}
                    }
                }

                ((DataRowView)MasterBindingSource.Current).Row["duedate"] = ((DateTime)dateDate.EditValue).AddDays(Convert.ToDouble(spinTOP.EditValue));
                 base.tsbtnSave_Click(sender, e);

                //save it inventory
                 string datez = ((DateTime)(dateDate.EditValue)).ToString("yyyyMMdd");

                 DataTable dtTpbdb = DB.sql.Select("SELECT docp.jnsp AS jenis,docpd.no_bc AS nobc FROM docp,docpd WHERE docp.docp = docpd.docp AND docpd.nodoc = '" + spmTextBoxEx.Text + "' LIMIT 1");
                 foreach (DataRow drTpbdb in dtTpbdb.Rows)
                 {
                     string jenis = drTpbdb["jenis"].ToString();
                     string nobc = drTpbdb["nobc"].ToString();

                     if (jenis == "BC 3.0")
                     {
                         DB.sql.Execute("Call SP_SaveBCKeluar30('" + nobc + "')");
                     }
                     else
                     {
                         DB.sql.Execute("Call SP_Save(" + datez + ",'SPM','" + spmTextBoxEx.Text + "')");
                     }
                 }

                //save jurnal
                string date = Convert.ToDateTime(dateDate.EditValue).ToString("yyyyMMdd");
                string no = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
                DB.sql.Execute("Call SP_Save(" + date + ",'SJL','" + no + "')");
                ceksentsmu();
                //cek close SO
                CloseSO();

                spmTextBoxEx.ExAutoCheck = false;
                SetDetailEditable(false);
                tsbtnRefresh_Click(sender, e);
                //ctrlSub.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
        }

        //void ExGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        //{
        //    if (e.Column.FieldName == "unit" || e.Column.FieldName == "qty1")
        //    {
        //        DetailBindingSource.EndEdit();
        //        string inv = (string)gcxSjd.ExGridView.GetFocusedRowCellValue("inv");
        //        string unit = (string)gcxSjd.ExGridView.GetFocusedRowCellValue("unit");
        //        double qty1 = (double)gcxSjd.ExGridView.GetFocusedRowCellValue("qty1");
        //        if (inv != "" && unit != "")
        //            gcxSjd.ExGridView.SetFocusedRowCellValue(gcxSjd.ExGridView.Columns["qty"], DB.GetQtyInBaseUom(inv, unit, qty1));
        //        //ExGridView_ValidateRow(sender, new ValidateRowEventArgs(gcOmd.ExGridView.FocusedRowHandle, gcOmd.ExGridView.GetRow(gcOmd.ExGridView.FocusedRowHandle)));
        //    }
        //}

        //void ExGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        //{
        //    DataRow row = gcxSjd.ExGridView.GetDataRow(e.RowHandle);
        //    row["sjh"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
        //    row["no"] = DetailTable.Rows.Count + 1;
        //}

        //void ExGridView_InvColumnEdit_Enter(object sender, EventArgs e)
        //{
        //    GridLookUpEx invLookUp = (GridLookUpEx)gcxSjd.ExGridView.Columns["inv"].ColumnEdit;
        //    invLookUp.Query = "Select * from spd where spm='" + spmTextBoxEx.EditValue.ToString() + "'";
        //}

        private void txtAlias_EditValueChanged(object sender, EventArgs e)
        {
            DataRow row = txtAlias.ExGetDataRow();
            if (row == null)
            {
                shiptonameTextBoxEx.Text = "";
                shiptoaddressMemoEdit.Text = "";
                return;
            }
            shiptonameTextBoxEx.Text = row["Ship To"].ToString();
            shiptoaddressMemoEdit.Text = row["Ship Address"].ToString();
        }        

        private void spmTextBoxEx_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            spmTextBoxEx.ExSqlQuery = "Call SP_SelectSPMforSJ(1,'" + spmTextBoxEx.EditValue.ToString() + "')";
            spmTextBoxEx.ExFieldName = "SPM";
        }

      

        private void linkToForm1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnDocFlow_Click(object sender, EventArgs e)
        {

        }

        private void buttonCallSMU_Click(object sender, EventArgs e)
        {
            
            //DataTable result = func.Tables["GI_LIPS"].ToADOTable();
        }

        void ceksentsmu()
        {

        }

        private void txtNo_EditValueChanged(object sender, EventArgs e)
        {

            string txtsjlnya = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
            //string strbtnSMU = "select left(nopoc,1) as nopoc from sjd,sjh,inv where sjh.sjh='" + txtsjlnya + "' and sjd.sjh=sjh.sjh and sjh.sub='1110003' and trim(sjd.mor)='' and sjd.inv=inv.inv and trim(inv.oldinv1)<>''";
            //DataTable dtSMU = DB.sql.Select(strbtnSMU);
            //string txtnopocnya = "";
            //if (dtSMU.Rows.Count > 0)
            //{
            //    txtnopocnya = dtSMU.Rows[0]["nopoc"].ToString();
            //}
            //if (dtSMU.Rows.Count > 0 && ctrlSub.txtSub.Text.Trim() == "1110003")
            //    buttonCallSMU.Enabled = true;
            //else
            //    buttonCallSMU.Enabled = false;


          }
    }
}
