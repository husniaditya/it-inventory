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
    public partial class FrmTLpb : CAS.Transaction.BaseTransaction
    {
        private string modenya = "";
        string querynya = "";

        public FrmTLpb()
        {
            InitializeComponent();

            ToolStripMenuItem tsmiPrintPreview = new ToolStripMenuItem("Print Preview", null, new EventHandler(tsmiPrintPreview_Click));
            ToolStripMenuItem tsmiPrintDirectly = new ToolStripMenuItem("Print Directly", null, new EventHandler(tsmiPrintDirectly_Click));
            ToolStripDropDownButton tsbtnPrint = new ToolStripDropDownButton("Print", null, tsmiPrintPreview, tsmiPrintDirectly);
            tsbtnPrint.Image = MasterNavigator.Items["tsbtnPrint"].Image;
            MasterNavigator.Items.Insert(MasterNavigator.Items.IndexOfKey("tsbtnPrint"), tsbtnPrint);
            MasterNavigator.Items.RemoveByKey("tsbtnPrint");

            DetailTable.Columns.Add("Unit Base Diterima", typeof(String));
           // DetailTable.Columns.Add("Qty Selisih", typeof(Double));
            MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);

            Utility.SetSqlInstance(pnlDetail, DB.sql);
            //spbTextBoxEx.ExCondition = "spb not in (select spb from lph) and aprov=1";           

            gcLpd.ExGridControl.DataSource = DetailTable;
            gcLpd.ExTitleLabel.Text = "Detail Penerimaan Barang";
            gcLpd.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gcLpd.ExToolStrip.Items["tsbtnNew"].Enabled = false;
            gcLpd.ExGridView.OptionsBehavior.Editable = false;
            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
            SetGridViewSetting();

            //tsbtnPrint.Click += new EventHandler(tsbtnPrint_Click);

            DevExpress.XtraEditors.Controls.EditorButton btnReload = new DevExpress.XtraEditors.Controls.EditorButton();
            btnReload.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Redo;
            btnReload.ToolTip = "Reload data";
            spbTextBoxEx.Properties.Buttons.Add(btnReload);
            spbTextBoxEx.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(spbTextBoxEx_ButtonClick);
            //mode = Mode.View;
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            modenya = "edit";
            gcLpd.ExGridView.OptionsBehavior.Editable = true;
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            modenya = "new";
            gcLpd.ExGridView.OptionsBehavior.Editable = true;
            DetailTable.Clear();
        }

        void spbTextBoxEx_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index > 0)
                spbTextBoxEx_EditValueChanged(sender, new EventArgs());
        }

        void tsmiPrintDirectly_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepLpb" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_Print('Transaction.FrmTLpb','" + this.NoDocument + "')");
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
            report.PrintingSystem.ShowMarginsWarning = false;
            //report.PrintingSystem.Document.PrintingSystem.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            //report.PrintingSystem.Document.PrintingSystem.PageSettings.PaperName = "1/2A4";
            //report.PrintingSystem.Document.PrintingSystem.PageSettings.RightMargin = 0;
             */
            report.PaperName = "1/2A4";
            report.PrintingSystem.ShowMarginsWarning = false;
            report.Print();
        }

        void tsmiPrintPreview_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepLpb" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_Print('Transaction.FrmTLpb','" + this.NoDocument + "')");
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

        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base Diterima");
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

        void SetGridViewSetting()
        {
            //if (mode == Mode.View)
            //    gcLpd.ExGridView.OptionsBehavior.Editable = false;
            //else
            //    gcLpd.ExGridView.OptionsBehavior.Editable = true;
            gcLpd.ExGridView.CellValueChanged += new CellValueChangedEventHandler(ExGridView_CellValueChanged);
            gcLpd.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
            gcLpd.ExGridView.Columns["inv"].OptionsColumn.AllowEdit = false;
            gcLpd.ExGridView.Columns["remark"].OptionsColumn.AllowEdit = false;
            gcLpd.ExGridView.Columns["spesifikasi"].OptionsColumn.AllowEdit = false;
            gcLpd.ExGridView.Columns["loc"].OptionsColumn.AllowEdit = false;
            gcLpd.ExGridView.Columns["qty"].OptionsColumn.AllowEdit = false;
            gcLpd.ExGridView.Columns["qty1"].OptionsColumn.AllowEdit = false;
            gcLpd.ExGridView.Columns["loc"].OptionsColumn.AllowEdit = false;
            gcLpd.ExGridView.Columns["unit"].OptionsColumn.AllowEdit = false;
            gcLpd.ExGridView.Columns["cct"].OptionsColumn.AllowEdit = false;
            gcLpd.ExGridView.Columns["etd"].OptionsColumn.AllowEdit = true;
            gcLpd.ExGridView.Columns["qtyc"].OptionsColumn.AllowEdit = true;
            gcLpd.ExGridView.OptionsView.ShowGroupPanel = false;
            gcLpd.ExGridView.OptionsCustomization.AllowSort = false;

            gcLpd.ExGridView.Columns["qtyc"].ColumnEdit = new GridNumEx();

            gcLpd.ExGridView.Columns["Unit Base Diterima"].VisibleIndex = DetailTable.Columns.IndexOf("qty") + 1;
            gcLpd.ExGridView.Columns["Unit Base Diterima"].OptionsColumn.AllowEdit = false;

            gcLpd.ExGridView.Columns["lph"].Visible = false;
            gcLpd.ExGridView.Columns["inv"].Caption = "Kode Barang";
            gcLpd.ExGridView.Columns["remark"].Caption = "Nama Barang";
            gcLpd.ExGridView.Columns["spesifikasi"].Caption = "Spesifikasi";
            gcLpd.ExGridView.Columns["loc"].Caption = "Loc";
            gcLpd.ExGridView.Columns["qty"].Caption = "Qty Diterima Base";
            gcLpd.ExGridView.Columns["qty1"].Caption = "Qty Diterima";
            gcLpd.ExGridView.Columns["unit"].Caption = "Unit";
            gcLpd.ExGridView.Columns["etd"].Caption = "Keterangan";
            gcLpd.ExGridView.Columns["cct"].Caption = "Cost Center";
            gcLpd.ExGridView.Columns["qtyc"].Caption = "Qty Container";
            gcLpd.ExGridView.Columns["qtyc"].VisibleIndex = gcLpd.ExGridView.Columns["cct"].VisibleIndex;
            gcLpd.ExGridView.Columns["no"].Visible = false;

            gcLpd.ExGridView.Columns["expired"].Caption = "Expired";
            gcLpd.ExGridView.Columns["nodsg"].Caption = "No Batch";

            gcLpd.ExGridView.Columns["spesifikasi"].VisibleIndex = 3;
            gcLpd.ExGridView.Columns["nodsg"].VisibleIndex = 4; 
            gcLpd.ExGridView.Columns["expired"].VisibleIndex = 5;
            gcLpd.ExGridView.Columns["loc"].VisibleIndex = 6;

            //gcLpd.ExGridView.Columns["nodsg"].ColumnEdit = new GridLookUpEx(DB.sql, "Call Sp_GetStockBatch(''," + DateTime.Today + ")", "", "nodsg", gcLpd.ExGridView, "", true, true, "Batch");
            //gcLpd.ExGridView.Columns["nodsg"].ColumnEdit.Enter += new EventHandler(DsgColumnEdit_Enter);

        //    gcLpd.ExGridView.Columns["Qty Selisih"].VisibleIndex = gcLpd.ExGridView.Columns["cct"].VisibleIndex;
        //    gcLpd.ExGridView.Columns["Qty Selisih"].OptionsColumn.AllowEdit = false;

            gcLpd.ExGridView.BestFitColumns();
        }

        void ExGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "qty" || e.Column.FieldName == "qtyc")
            {
                DetailTable = DB.PopulateSelisih(DetailTable,"LPB");
            }
        }

        private void FrmTLpb_Load(object sender, EventArgs e)
        {
            ctrlSub.txtSub.DataBindings.Add("EditValue", lphBindingSource, "sub");
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base Diterima");
            DetailTable = DB.PopulateSelisih(DetailTable,"LPB");
            if (MasterBindingSource.Position == MasterTable.Rows.Count)
                spbTextBoxEx.ExAutoCheck = true;
            else
                spbTextBoxEx.ExAutoCheck = false;
        }

        void ClosePO()
        {
            DB.sql.Execute("call SP_ClosePOitemonLPB('" + omsTextEdit.Text + "')");

            string query = "Call Sp_OutSpb1('" + omsTextEdit.Text + "',2)";
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
            
            try
            {
                // START CEK DATA SUDAH DI TPB
                DataTable dtTpb = DB.sql.Select("select spb.nodoc as nodoc,COUNT(spbd.inv) AS kount from spb,spbd WHERE spb.spb = spbd.spb and spb.spb = '" + spbTextBoxEx.Text + "' AND LEFT(spbd.inv,2) BETWEEN 11 AND 81 GROUP BY spb.spb");
                foreach (DataRow drTpb in dtTpb.Rows)
                {
                    double kount = Convert.ToDouble(drTpb["kount"]);
                    string nodoc = drTpb["nodoc"].ToString();

                    if (nodoc == "" && kount > 0)
                    {
                        throw new Exception("Transaksi " + spbTextBoxEx.Text + " harap diinput TPB terlebih dahulu");
                        //MessageBox.Show("Detail Transaksi belum terisi");
                        //return;
                    }
                }
                // END CEK DATA SUDAH DI TPB

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
                if (DetailTable.Rows.Count == 0 && spbTextBoxEx.EditValue.ToString()!="")
                {
                    throw new Exception("Detail Transaksi belum terisi");
                    //MessageBox.Show("Detail Transaksi belum terisi");
                    //return;
                }
                if (spbTextBoxEx.Text != "" && !spbTextBoxEx.ExIsValid())
                {
                    throw new Exception("Nomor SPB salah");
                    //MessageBox.Show("Detail Transaksi belum terisi");
                    //return;
                }

                //String dbname2 = Utility.GetConfig("Database2");
                //String querynya = "";
                //{
                //    if (modenya == "new")
                //    {
                //        querynya = "insert into " + dbname2 + ".tpb_header (ALAMAT_PENGIRIM,ALAMAT_PENGUSAHA,ASAL_DATA,BRUTO,HARGA_PENYERAHAN,ID_MODUL,ID_PENGIRIM,ID_PENGUSAHA,JABATAN_TTD,JUMLAH_BARANG,JUMLAH_KEMASAN,KODE_DOKUMEN_PABEAN,KODE_ID_PENGIRIM,KODE_ID_PENGUSAHA,KODE_JENIS_TPB,KODE_KANTOR,KODE_STATUS,KODE_TUJUAN_PENGIRIMAN,KOTA_TTD,NAMA_PENGANGKUT,NAMA_PENGIRIM,NAMA_PENGUSAHA,NAMA_TTD,NETTO,NOMOR_IJIN_TPB,NOMOR_POLISI,TANGGAL_TTD,VERSI_MODUL) values ('" + invTextEdit.EditValue.ToString().Trim() + "','" + nameTextEdit.EditValue.ToString().Trim() + "')";
                //        DB.sql.Execute(querynya);
                //    }

                //    if (modenya == "edit")
                //    {
                //        querynya = "update " + dbname2 + ".referensi_kode_barang set URAIAN_BARANG ='" + nameTextEdit.EditValue.ToString().Trim() + "' where KODE_BARANG = '" + invTextEdit.EditValue.ToString().Trim() + "'";
                //        DB.sql.Execute(querynya);
                //    }
                //}
             
                base.tsbtnSave_Click(sender, e);
                if (spbTextBoxEx.Text == "" )
                {
                    DB.sql.Execute("Delete from lpd where lph='" + NoDocument + "'");
                }

                if (this.mode == Mode.View)
                {
                    string date = ((DateTime)(dateDate.EditValue)).ToString("yyyyMMdd");
                    string jurnal = NoDocument;

                    // Check if LPB is from PR, no need to call SP_Save
                    if (DB.sql.Select("select * from oms where oms='" + omsTextEdit.Text + "'").Rows.Count > 0)
                    {
                        DB.sql.Execute("Call SP_Save(" + date + ",'LPH'" + ",'" + jurnal + "')");

                        if (modenya == "new")
                        {
                            querynya = "update lph set status_bc = 0 where lph = '" + NoDocument + "'";
                            DB.sql.Execute(querynya);
                        }

                        ClosePO();
                    }
                    else
                        ClosePR();

                    spbTextBoxEx.ExAutoCheck = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            gcLpd.ExGridView.OptionsBehavior.Editable = false;
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

        private void spbTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {
            if (spbTextBoxEx.Text == "" || !spbTextBoxEx.ExIsValid())
            {
                if (spbTextBoxEx.Text == "")
                {
                    omsTextEdit.EditValue = "";
                    DetailTable.Clear();
                }
                return;
            }
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
                    drLpd["spesifikasi"] = drSpbd["spesifikasi"];
                    drLpd["loc"] = drSpbd["loc"];
                    //drLpd["qty"] = drSpbd["qty"];
                    //drLpd["qty1"] = drSpbd["qty1"];
                    drLpd["unit"] = drSpbd["unitgd"];
                    drLpd["qty1"] = drSpbd["qty1"];
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

        private void pnlDetail_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}

