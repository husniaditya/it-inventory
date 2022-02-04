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
    public partial class FrmTSpmJual : CAS.Transaction.BaseTransaction
    {
        private SqlConnection conn;
        private int[] selectedIndex = new int[0];
        private bool isDetailValid = true;
        private DataTable copyDetailTable = new DataTable();
        Int32 manualspm = 0;
        public FrmTSpmJual()
        {
            InitializeComponent();

            ToolStripMenuItem tsmiPrintPreview = new ToolStripMenuItem("Print Preview Detail", null, new EventHandler(tsmiPrintPreview_Click));
            ToolStripMenuItem tsmiPrintPreviewGlobal = new ToolStripMenuItem("Print Preview Global", null, new EventHandler(tsmiPrintPreviewGlobal_Click));
            ToolStripMenuItem tsmiPrintDirectly = new ToolStripMenuItem("Print Directly", null, new EventHandler(tsmiPrintDirectly_Click));
            ToolStripDropDownButton tsbtnPrint = new ToolStripDropDownButton("Print", null, tsmiPrintPreview, tsmiPrintPreviewGlobal, tsmiPrintDirectly);
            tsbtnPrint.Image = MasterNavigator.Items["tsbtnPrint"].Image;
            MasterNavigator.Items.Insert(MasterNavigator.Items.IndexOfKey("tsbtnPrint"), tsbtnPrint);
            MasterNavigator.Items.RemoveByKey("tsbtnPrint");

            DetailTable.Columns.Add("Unit Base Dikirim", typeof(String));
            DetailTable.Columns.Add("Beda", typeof(String));

            MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);

            Utility.SetSqlInstance(pnlDetail, DB.sql);

            gcSpm.ExGridControl.DataSource = spdBindingSource;
            gcSpm.ExTitleLabel.Text = "Surat Perintah Muat";
            gcSpm.ExGridView.OptionsCustomization.AllowSort = false;
            gcSpm.ExGridView.OptionsView.ShowGroupPanel = false;

            gcSpm.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
            gcSpm.ExGridView.CellValueChanged += new CellValueChangedEventHandler(ExGridView_CellValueChanged);
            //gcSpm.ExGridView.ValidateRow += new ValidateRowEventHandler(ExGridView_ValidateRow);

            gcSpm.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
            gcSpm.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
            gcSpm.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gcSpm.ExToolStrip.Items["tsbtnNew"].Enabled = false;

            gcSpm.ExGridView.Columns["spm"].OptionsColumn.AllowEdit = false;
            gcSpm.ExGridView.Columns["qty"].OptionsColumn.AllowEdit = false;

            gcSpm.ExGridView.Columns["no"].Visible = false;
            gcSpm.ExGridView.Columns["spm"].Visible = false;
            gcSpm.ExGridView.Columns["cct"].Visible = false;
            gcSpm.ExGridView.Columns["mor"].Visible = false;
            gcSpm.ExGridView.Columns["nodsg"].Visible = false;

            //gcSpm.ExGridView.Columns["mor"].ColumnEdit = new GridLookUpEx(DB.sql, "", "", "mor", gcSpm.ExGridView, "", true, true, "");
            //gcSpm.ExGridView.Columns["mor"].ColumnEdit.Enter += new EventHandler(morColumnEdit_Enter);

            gcSpm.ExGridView.Columns["nodsg"].ColumnEdit = new GridLookUpEx(DB.sql, "Call Sp_GetStockBatch(" + DateTime.Now.ToString("yyyyMMdd") + ",'')", "", "No Batch", gcSpm.ExGridView, "", true, true, "Batch");
            gcSpm.ExGridView.Columns["nodsg"].ColumnEdit.Enter += new EventHandler(DsgColumnEdit_Enter);

            gcSpm.ExGridView.Columns["okl"].ColumnEdit = new GridLookUpEx(DB.sql, "", "", "okl", gcSpm.ExGridView, "", true, true, "");
            gcSpm.ExGridView.Columns["okl"].ColumnEdit.Enter += new EventHandler(oklColumnEdit_Enter);
            gcSpm.ExGridView.Columns["okl"].ColumnEdit.KeyPress += new KeyPressEventHandler(ExGridView_UnitColumnEdit_KeyPress);
          
            gcSpm.ExGridView.Columns["inv"].ColumnEdit = new GridLookUpEx(DB.sql, "", "", "inv", gcSpm.ExGridView, "", true, true, "Inventory");
            gcSpm.ExGridView.Columns["inv"].ColumnEdit.Enter += new EventHandler(ExGridView_InvColumnEdit_Enter);
            gcSpm.ExGridView.Columns["inv"].ColumnEdit.KeyPress += new KeyPressEventHandler(ExGridView_UnitColumnEdit_KeyPress);
          
        //    gcSpm.ExGridView.Columns["loc"].ColumnEdit = new GridLookUpEx(DB.sql, "", "loc", "loc", gcSpm.ExGridView, "", false, false, "Location");
            gcSpm.ExGridView.Columns["loc"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUpLoc('" + DB.casUser.User + "')", "", "loc", gcSpm.ExGridView, "", false, false, "Location");
            gcSpm.ExGridView.Columns["loc"].ColumnEdit.KeyPress += new KeyPressEventHandler(ExGridView_LocColumnEdit_KeyPress);
           
            gcSpm.ExGridView.Columns["unit"].ColumnEdit = new GridLookUpUnit(gcSpm.ExGridView);
            gcSpm.ExGridView.Columns["unit"].ColumnEdit.KeyPress += new KeyPressEventHandler(ExGridView_UnitColumnEdit_KeyPress);
          
            gcSpm.ExGridView.Columns["unitgudang"].ColumnEdit = new GridLookUpUnit(gcSpm.ExGridView, "Unit Dikirim");
            gcSpm.ExGridView.Columns["unitgudang"].ColumnEdit.KeyPress += new KeyPressEventHandler(ExGridView_UnitColumnEdit_KeyPress);
          
            gcSpm.ExGridView.Columns["qty1"].ColumnEdit = new GridNumEx();
            gcSpm.ExGridView.Columns["qty1"].ColumnEdit.Enter += new EventHandler(Qty1ColumnEdit_Enter);
            gcSpm.ExGridView.Columns["qtygudang"].ColumnEdit = new GridNumEx();

            gcSpm.ExGridView.OptionsBehavior.Editable = false;
            gcSpm.ExGridView.OptionsSelection.MultiSelect = true;

            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            //tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);

            gcSpm.ExGridView.Columns["mor"].Caption = "MO";
            gcSpm.ExGridView.Columns["okl"].Caption = "Sales Order";
            gcSpm.ExGridView.Columns["nodsg"].Caption = "No Batch";
            gcSpm.ExGridView.Columns["inv"].Caption = "Kode Barang";
            gcSpm.ExGridView.Columns["remark"].Caption = "Nama Barang";
            gcSpm.ExGridView.Columns["loc"].Caption = "Loc";
            gcSpm.ExGridView.Columns["qty"].Caption = "Qty Base Dikirim";
            gcSpm.ExGridView.Columns["unit"].Caption = "Unit";
            gcSpm.ExGridView.Columns["qty1"].Caption = "Qty";
            gcSpm.ExGridView.Columns["qtygudang"].Caption = "Qty Dikirim";
            gcSpm.ExGridView.Columns["unitgudang"].Caption = "Unit Dikirim";
            gcSpm.ExGridView.Columns["qtytim"].Caption = "Qty Tim";
            gcSpm.ExGridView.Columns["etd"].Caption = "Keterangan";

            gcSpm.ExGridView.Columns["expired"].Caption = "Expired";

            gcSpm.ExGridView.Columns["okl"].VisibleIndex = 0;
            gcSpm.ExGridView.Columns["inv"].VisibleIndex = 1;
            gcSpm.ExGridView.Columns["remark"].VisibleIndex = 2;
            gcSpm.ExGridView.Columns["spesifikasi"].VisibleIndex = 3;
            gcSpm.ExGridView.Columns["loc"].VisibleIndex = 4;
            gcSpm.ExGridView.Columns["nodsg"].VisibleIndex = 5;
            gcSpm.ExGridView.Columns["expired"].VisibleIndex = 6;
            gcSpm.ExGridView.Columns["qty1"].VisibleIndex = 7;
            gcSpm.ExGridView.Columns["unit"].VisibleIndex = 8;
            gcSpm.ExGridView.Columns["qtygudang"].VisibleIndex = 9;
            gcSpm.ExGridView.Columns["unitgudang"].VisibleIndex = 10;
            gcSpm.ExGridView.Columns["qty"].VisibleIndex = 11;
            gcSpm.ExGridView.Columns["Unit Base Dikirim"].VisibleIndex = 12;
            gcSpm.ExGridView.Columns["qtytim"].VisibleIndex = 13;
            gcSpm.ExGridView.Columns["etd"].VisibleIndex = 14;
            gcSpm.ExGridView.Columns["Beda"].VisibleIndex = 15;

            gcSpm.ExGridView.Columns["Unit Base Dikirim"].OptionsColumn.AllowEdit = false;
            gcSpm.ExGridView.Columns["qtytim"].OptionsColumn.AllowEdit = false;
            //gcSpm.ExGridView.Columns["Beda"].VisibleIndex = DetailTable.Columns.IndexOf("etd");
            gcSpm.ExGridView.Columns["Beda"].OptionsColumn.AllowEdit = false;

            if (cpoCheckBox.Checked = true)
            {
                // for trial di open dulu qty flownya
                gcSpm.ExGridView.Columns["qtygudang"].OptionsColumn.AllowEdit = true;
                gcSpm.ExGridView.Columns["unitgudang"].OptionsColumn.AllowEdit = true;
            }
            else
            {
                gcSpm.ExGridView.Columns["qtygudang"].OptionsColumn.AllowEdit = true;
                gcSpm.ExGridView.Columns["unitgudang"].OptionsColumn.AllowEdit = true;

            }
            gcSpm.ExGridView.BestFitColumns();
            //tsbtnPrint.Click += new EventHandler(tsbtnPrint_Click);
        }
        private void ExGridView_LocColumnEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(0);
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
            inv = gcSpm.ExGridView.GetFocusedRowCellValue("inv").ToString();
            if (gcSpm.ExGridView.GetFocusedRowCellValue("inv") != null)
                (gcSpm.ExGridView.Columns["nodsg"].ColumnEdit as GridLookUpEx).Query = "Call Sp_GetStockBatch(" + DateTime.Now.ToString("yyyyMMdd") + ",'" + inv + "')";
        }

        void morColumnEdit_Enter(object sender, EventArgs e)
        {
            if (gcSpm.ExGridView.GetFocusedRowCellValue("okl") != null && gcSpm.ExGridView.GetFocusedRowCellValue("okl").ToString() != "")
            {
                GridLookUpEx morLookUp = (GridLookUpEx)gcSpm.ExGridView.Columns["mor"].ColumnEdit;
                morLookUp.Query = "Call SP_SelectMOforSPM(" + Convert.ToDateTime(dateDate.EditValue).ToString("yyyyMMdd") + ",'" + gcSpm.ExGridView.GetFocusedRowCellValue("okl").ToString() + "')";
                ((ButtonEdit)sender).Enabled = true;
            }
            else
                ((ButtonEdit)sender).Enabled = false;
        }

        void tsmiPrintDirectly_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepSpmJual" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_Print('Transaction.FrmTSpmJual','" + this.NoDocument + "')");
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
           */
            report.PaperName = "1/2A4";
            report.PrintingSystem.ShowMarginsWarning = false;
            report.Print();
        }

        void tsmiPrintPreview_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepSpmJual" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_Print('Transaction.FrmTSpmJual','" + this.NoDocument + "')");
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
             */
            report.ShowPreview();
        }

        void tsmiPrintPreviewGlobal_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepSpmJualGlobal" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_Print('Transaction.FrmTSpmJualGlobal','" + this.NoDocument + "')");
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
             */
            report.ShowPreview();
        }

        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base Dikirim");
            DetailTable = DB.PopulateSelisih(DetailTable, "SPM");
            gcSpm.ExGridView.BestFitColumns();
        }

        //void qty1ColumnEdit_Enter(object sender, EventArgs e)
        //{
        //    ((DevExpress.XtraEditors.SpinEdit)sender).Properties.MaxValue = GetMaxValueQtyDikirim();
        //}

        void oklColumnEdit_Enter(object sender, EventArgs e)
        {
            ((ButtonEdit)sender).Enabled = true;
            GridLookUpEx oklLookUp = (GridLookUpEx)gcSpm.ExGridView.Columns["okl"].ColumnEdit;
            oklLookUp.Query = "Call SP_SelectSOforSPM(" + Convert.ToDateTime(dateDate.EditValue).ToString("yyyyMMdd") + ",'" + ctrlSub.txtSub.EditValue.ToString() + "')";
            //if (gcSpm.ExGridView.GetFocusedRowCellValue("mor") == null)
            //{
            //    ((ButtonEdit)sender).Enabled = true;
            //    GridLookUpEx oklLookUp = (GridLookUpEx)gcSpm.ExGridView.Columns["okl"].ColumnEdit;
            //    oklLookUp.Query = "Call SP_SelectSOforSPM(" + Convert.ToDateTime(dateDate.EditValue).ToString("yyyyMMdd") + ",'" + ctrlSub.txtSub.EditValue.ToString() + "')";
            //    return;
            //}

            //if (gcSpm.ExGridView.GetFocusedRowCellValue("mor").ToString() == "")
            //{
            //    ((ButtonEdit)sender).Enabled = true;
            //    GridLookUpEx oklLookUp = (GridLookUpEx)gcSpm.ExGridView.Columns["okl"].ColumnEdit;
            //    oklLookUp.Query = "Call SP_SelectSOforSPM(" + Convert.ToDateTime(dateDate.EditValue).ToString("yyyyMMdd") + ",'" + ctrlSub.txtSub.EditValue.ToString() + "')";
            //}
            //else
            //    ((ButtonEdit)sender).Enabled = false;
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
            DataRow row = casDataSet.spd.NewRow();
            row["spm"] = NoDocument;
            row["qty"] = 0;
            row["qty1"] = 0;
            row["inv"] = "";
            row["loc"] = "";
            row["unit"] = "";
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            casDataSet.spd.Rows.Add(row);

            DB.InsertDetailRows(gcSpm.ExGridView, row);
        }

        void ExGridView_Delete_Click(object sender, EventArgs e)
        {
            DB.DeleteDetailRows(gcSpm.ExGridView);
        }

        private void FrmTSpmJual_Load(object sender, EventArgs e)
        {
            Utility.SetReadOnly(txtTotalqty, true);
            Utility.SetReadOnly(txtTotalqtykemasan, true);
            //tglbc.Properties.MinValue = Utility.FirstDateInMonth((DateTime)dateDate.EditValue);
            //tglbc.Properties.MaxValue = Utility.LastDateInMonth((DateTime)dateDate.EditValue).AddHours(23);
            //try
            //{
            //    conn = new SqlConnection("Data Source = " + Utility.GetConfig("server2") + "\\SQLEXPRESS; " +
            //            "Initial Catalog = loading_unloading; " + "User Id = sa; Password = database;");
            //    conn.Open();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Komputer anda tidak terhubung dengan PLC, Hubungi IT");
               manualspm = 1;
            //}

            if (this.Tag.ToString() == "256")
            {
                ctrlSub.txtSub.DataBindings.Add("EditValue", MasterBindingSource, "sub");
                ctrlSub.txtSub.EditValueChanged += new EventHandler(txtSub_EditValueChanged);
                DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base Dikirim");
                DetailTable = DB.PopulateSelisih(DetailTable, "SPM");
                if (cpoCheckBox.Checked)
                {
                    if (manualspm == 1)
                    {
                        gcSpm.ExGridView.Columns["qtygudang"].OptionsColumn.AllowEdit = true;
                        gcSpm.ExGridView.Columns["unitgudang"].OptionsColumn.AllowEdit = true;
                        gcSpm.ExGridView.Columns["qtygudang"].Caption = "Qty Flow";
                    }
                }
                else
                {
                    gcSpm.ExGridView.Columns["qtygudang"].Caption = "Qty Gdg";
                    gcSpm.ExGridView.Columns["qtygudang"].OptionsColumn.AllowEdit = true;
                    gcSpm.ExGridView.Columns["unitgudang"].OptionsColumn.AllowEdit = true;

                }
            }
            else
                if (this.Tag.ToString() == "257")
                {
                    //MasterTable.Clear();

                    //MasterAdapter = DB.sql.SelectAdapter("select * from spm where sendgd=1 and aprov=0 and period='"+DB.loginPeriod+"'");
                    //MasterAdapter.Fill(MasterTable);
                    Filter = "sendgd=0 and aprov=0 and period='" + DB.loginPeriod + "'";
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

                    gcSpm.ExGridView.Columns["qty"].Visible = false;
                    gcSpm.ExGridView.Columns["qty1"].Visible = false;
                    gcSpm.ExGridView.Columns["unit"].OptionsColumn.AllowEdit = false;
                    gcSpm.ExGridView.Columns["unitgudang"].OptionsColumn.AllowEdit = true;
                    gcSpm.ExGridView.Columns["okl"].OptionsColumn.AllowEdit = false;
                    gcSpm.ExGridView.Columns["loc"].OptionsColumn.AllowEdit = false;
                    ctrlSub.txtSub.Enabled = false;
                    dateDate.Enabled = false;
                    label2.Visible = false;
                    angkutanTextBoxEx.Enabled = false;
                    aprovCheckBox.Visible = false;
                    sendgdCheckBox.Visible = false;
                    //gcjin.Enabled = false;
                    gcSpm.ExGridView.BestFitColumns();
                    tsbtnNew.Enabled = false;
                    tsbtnDelete.Enabled = false;
                }

        }


        private void PopulateDetail()
        {
            DetailTable.Clear();
            //DetailAdapter = null;

            if (MasterBindingSource.Position < 0 || MasterTable.Rows.Count == 0) return;

            string query = "select * from " + DetailTable.TableName + " where " + DetailTable.Columns[0].ColumnName + "='" + MasterTable.Rows[MasterBindingSource.Position][0].ToString() + "'";
            DetailAdapter = DB.sql.SelectAdapter(query);
            try
            {
                DetailAdapter.Fill(DetailTable);
            }
            catch (Exception ex)
            {
            }
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            //DataTable dt_oto = DB.sql.Select("SELECT usr.* FROM usr,usrlevel where usr.role=usrlevel.role and trim(user) ='" + DB.casUser.User.ToString() + "'");

            //if (this.mode == Mode.Edit && dt_oto.Rows[0]["pswd"].ToString().Trim() == "")
            //{   
            //       PassOto frmDoc = new PassOto();
            //       if (frmDoc.ShowDialog() == DialogResult.OK)
            //       {
            //DataTable cantedit = DB.sql.Select("select sjh from  sjh where sjh.spm = '"+ NoDocument +"' and sjh.delete=0");
            //if (this.mode == Mode.Edit && (cantedit.Rows.Count <= 0 || DB.casUser.User.ToString() == "Hartofa" || DB.casUser.User.ToString() == "Anton"))
            //{
                gcSpm.ExGridView.Columns["qty1"].OptionsColumn.AllowEdit = true;
                gcSpm.ExGridView.Columns["qtygudang"].OptionsColumn.AllowEdit = true;
                gcSpm.ExGridView.Columns["qtytim"].OptionsColumn.AllowEdit = true;
                //}
                //else
                //{
                //    gcSpm.ExGridView.Columns["qty1"].OptionsColumn.AllowEdit = false;
                //    gcSpm.ExGridView.Columns["qtygudang"].OptionsColumn.AllowEdit = false;
                //    gcSpm.ExGridView.Columns["qtytim"].OptionsColumn.AllowEdit = false; 
                //}

                Utility.SetReadOnly(txtTotalqty, true);
                Utility.SetReadOnly(txtTotalqtykemasan, true);
                ctrlSub.ReadOnly = false;
                //okl_rkaTextBoxEx.Properties.ReadOnly = true;
                gcSpm.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
                gcSpm.ExToolStrip.Items["tsbtnNew"].Enabled = true;
                gcSpm.ExGridView.OptionsBehavior.Editable = true;
                gcSpm.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                copyDetailTable.Clear();
                copyDetailTable = DetailTable.Copy();
            //}
            //else
            //{
            //    MessageBox.Show("Dokumen Sudah Dipakai Transaksi Surat Jalan, hapus reference transaksi di SJL");
            //    base.tsbtnCancel_Click(sender, e);
            //}
              
        }

        protected override void tsbtnCancel_Click(object sender, EventArgs e)
        {
            DB.CancelDetailRows(DetailTable);

            base.tsbtnCancel_Click(sender, new EventArgs());

            if (this.mode == Mode.View)
            {
                DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base Dikirim");
                gcSpm.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                gcSpm.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                gcSpm.ExGridView.OptionsBehavior.Editable = false;
                gcSpm.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                gcSpm.ExGridView.BestFitColumns();

                ctrlSub.ReadOnly = true;

                DetailTable = DB.PopulateSelisih(DetailTable, "SPM");
            }

        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            Utility.SetReadOnly(txtTotalqty, true);
            Utility.SetReadOnly(txtTotalqtykemasan, true);
            gcSpm.ExGridView.Columns["qty1"].OptionsColumn.AllowEdit = true; 
            cpoCheckBox.Checked = true;
            ctrlSub.ReadOnly = false;
            no_conTextEdit.Text = " ";
            DetailTable.Clear();
            gcSpm.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcSpm.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcSpm.ExGridView.OptionsBehavior.Editable = true;
            gcSpm.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
        }

        private double GetAvailableStock(double qty, string inv, string nodsg, string loc)
        {
            //cek stock
            string tgla = ((DateTime)dateDate.EditValue).ToString("yyyyMMdd");
            string tglz = ((DateTime)dateDate.EditValue).AddDays(1).ToString("yyyyMMdd");
            string query = "Call SP_KartuStock(" + tgla + "," + (tglz) + ",'','','" + inv + "','" + inv + "','" + loc + "','" + loc + "','" + nodsg + "','" + nodsg + "')";
            DataTable dtStock = DB.sql.Select(query);
            double qtyBalance = 0;
            try
            {
                DataRow[] drBalance = dtStock.Select("rem='BALANCE'");
                if (drBalance.Length > 0)
                {
                    qtyBalance = Convert.ToDouble(drBalance[0]["qdebet"]);
                    if (qtyBalance == 0)
                        qtyBalance = -1 * Convert.ToDouble(drBalance[0]["qkredit"]);
                }
                DataRow[] drInOut = dtStock.Select("(rem<>'BALANCE' or rem is null) and jurnal<>'" + NoDocument + "'");
                //cek qty available
                for (int j = 0; j < drInOut.Length; j++)
                {
                    if (drInOut[j]["dk"].ToString() == "K")
                        qtyBalance = qtyBalance - Convert.ToDouble(drInOut[j]["qkredit"]);
                    else
                        qtyBalance = qtyBalance + Convert.ToDouble(drInOut[j]["qdebet"]);
                }
            }
            catch { }
            return qtyBalance;
        }


        protected override void tsbtnDelete_Click(object sender, EventArgs e)
        {
            base.tsbtnDelete_Click(sender, e);
            if (Convert.ToInt32(MasterTable.Rows[MasterBindingSource.Position]["delete"]) == 1)
                DB.sql.Execute("Call SP_Delete('SPM','" + NoDocument + "')");
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate controls
                this.ValidateChildren();
                //if (gcSpm.ExGridView.EditingValue != null)
                //    gcSpm.ExGridView.SetFocusedValue(gcSpm.ExGridView.EditingValue);

                // COBA CEK STOK WAKTU SAVE COK !
                if (this.mode == Mode.New)
                {
                    if (gcSpm.ExGridView.EditingValue != null)
                        gcSpm.ExGridView.SetFocusedValue(gcSpm.ExGridView.EditingValue);

                    DetailBindingSource.EndEdit();

                    foreach (DataRow row in DetailTable.Rows)
                    {
                        if (row != null && row.RowState != DataRowState.Deleted)
                        {
                            //ExGridView_ValidateRow(sender, new ValidateRowEventArgs(i, gctrm.ExGridView.GetRow(i)));
                            //if (!isDetailValid)
                            //{
                            //    MessageBox.Show("Invalid Kode Barang. Please correct the value");
                            //    return;
                            //}

                            double qty = Convert.ToDouble(row["qty"]);
                            string inv = (string)row["inv"];
                            string nodsg = (string)row["nodsg"];
                            string loc = (string)row["loc"];

                            double availableStock = GetAvailableStock(qty, inv, nodsg, loc);
                            if (Math.Ceiling(qty) > Math.Ceiling(availableStock))
                            {
                                MessageBox.Show("Qty max " + inv + " = " + availableStock + " " + row["Unit"].ToString());
                                return;
                            }
                        }
                    }
                }
                // END CEK STOK WAKTU SAVE COK !

                // Check Required Entries
                if (nopolTextEdit.Text.Trim() == "")
                    throw new Exception("No Polisi harus diisi");

                //if (angkutanTextBoxEx.EditValue.ToString() == "")
                //    throw new Exception("Angkutan harus diisi");

                DetailBindingSource.EndEdit();

                string query;
                bool isDuplicate = false;
                for (int i = DetailTable.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = DetailTable.Rows[i];
                    if (row != null && row.RowState != DataRowState.Deleted)
                    {
                        string loc = row["loc"].ToString();
                        row[0] = NoDocument;
                        if (row["inv"].ToString() == "" || row["loc"].ToString() == "")
                            throw new Exception("Kode Barang/Loc tidak valid");
                        if (row["unit"].ToString().Trim() == "" || row["unitgudang"].ToString().Trim() == "")
                            throw new Exception("Unit dan Unit Gudang harus di isi");

                        if ((double)(row["qty"]) == 0 && aprovCheckBox.Checked)
                        {
                            ((DataRowView)MasterBindingSource.Current).Row["aprov"] = 0;
                            MessageBox.Show("SPM tidak dapat diapprove karena ada item detail SPM yang memiliki qty 0");
                        }
/*
                        if (!row["inv"].ToString().StartsWith("7")) // exception for kertas afal
                        {
                            //cek stock
                            DataTable dtstock;
                            query = "select F_GetStock(@tgl,'@inv','@loc','@nodsg')";
                            query = query.Replace("@tgl", ((DateTime)dateDate.EditValue).ToString("yyyyMMdd"));
                            query = query.Replace("@inv", row["inv"].ToString()).Replace("@loc", row["loc"].ToString());
                            query = query.Replace("@nodsg", row["nodsg"].ToString());
                            double stockQty = 0;
                            //dtstock = DB.sql.Select(query);
                            if (this.mode == Mode.Edit)
                                stockQty = Convert.ToDouble(DetailTable.Rows[i]["qty"]);
                            if (DB.sql.Select(query).Rows[0][0] != DBNull.Value)
                                stockQty = stockQty + Convert.ToDouble(DB.sql.Select(query).Rows[0][0]);
                            string errMsg = "";
                            if (row["nodsg"].ToString() != "")
                                errMsg = row["nodsg"].ToString() + " - ";
                            errMsg = errMsg + row["inv"].ToString() + " - " + row["loc"].ToString();
                            if (stockQty < (double)(row["qty"]))
                            {
                                MessageBox.Show("Stock " + errMsg + " tidak mencukupi");
                                throw new Exception("Stock " + errMsg + " tidak mencukupi");
                            }
                        }
 */

                        //cek duplicate SPM Jual -> warning
                        if (MasterBindingSource.Position == MasterTable.Rows.Count)
                        {
                            query = "select spd.* from spd, spm "
                                + "where spd.mor='" + row["mor"].ToString() + "' "
                                + "and spd.okl='" + row["okl"].ToString() + "' "
                                + "and spd.inv='" + row["inv"].ToString() + "' "
                                + "and spd.remark='" + row["remark"].ToString().Replace("'", "''") + "'"
                                + "and spd.spm not in (select spm from sjh) "
                                + "and spm.spm=spd.spm and spm.delete=0";
                            DataTable dt = DB.sql.Select(query);
                            if (dt.Rows.Count > 0)
                                isDuplicate = true;
                        }
                    }
                }

                // set group_ to 1
                ((DataRowView)MasterBindingSource.Current).Row["group_"] = 1;

                if (isDuplicate)
                {
                    //throw new Exception("SPM dengan detail yang sama sudah ada, dan belum dibuat SJ-nya");
                    DialogResult dlgResult = MessageBox.Show("SPM dengan detail yang sama sudah ada, dan belum dibuat SJ-nya. Anda yakin untuk menyimpan?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dlgResult != DialogResult.Yes)
                        return;
                }

                base.tsbtnSave_Click(sender, e);

                string date = ((DateTime)(dateDate.EditValue)).ToString("yyyyMMdd");

                DataTable dtTpb = DB.sql.Select("SELECT docp.jnsp AS jenis,docpd.no_bc AS nobc FROM docp,docpd WHERE docp.docp = docpd.docp AND docpd.nodoc = '" + NoDocument + "' LIMIT 1");
                foreach (DataRow drTpb in dtTpb.Rows)
                {
                    string jenis = drTpb["jenis"].ToString();
                    string nobc = drTpb["nobc"].ToString();

                    if (jenis == "BC 3.0")
                    {
                        DB.sql.Execute("Call SP_SaveBCKeluar30('" + nobc + "')");
                    }
                    else
                    {
                        DB.sql.Execute("Call SP_Save(" + date + ",'SPM','" + NoDocument + "')");
                    }
                }

                if (this.mode == Mode.View)
                {
                    gcSpm.ExGridView.OptionsBehavior.Editable = false;
                    gcSpm.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                    gcSpm.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                    gcSpm.ExToolStrip.Items["tsbtnNew"].Enabled = false;

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
            decimal maxValue = 0;

            try
            {
                string mor = gcSpm.ExGridView.GetFocusedRowCellValue("mor").ToString();
                string okl = gcSpm.ExGridView.GetFocusedRowCellValue("okl").ToString();
                string inv = gcSpm.ExGridView.GetFocusedRowCellValue("inv").ToString();
                string loc = gcSpm.ExGridView.GetFocusedRowCellValue("loc").ToString();
                string nodsg = gcSpm.ExGridView.GetFocusedRowCellValue("nodsg").ToString();
                string baseUnit = gcSpm.ExGridView.GetFocusedRowCellValue("Unit Base Dikirim").ToString();
                string doh = oklTextBoxEx.EditValue.ToString();
              
                DataTable dtOutSpm;
                if (mor.Trim() == "")
                {
                    dtOutSpm = DB.sql.Select("Call SP_OutSpm('" + doh + "',10)");
                    DataRow[] drSelect = dtOutSpm.Select("`Kode Barang`='" + inv + "'");
                    if (drSelect.Length > 0)
                    {
                        //double qtyToleransi = DB.GetQtyToleransi("okd", "okl", okl, inv, loc, unit, "SO");
                        //request felix tgl 19/07/2016 default toleransi 2% dihilangkan
                        string query = "select sum(qty) as qty, if(toleransi=0,0,toleransi) as toleransi from okd where okl='" + okl + "' and nodsg='" + nodsg + "' and inv='" + inv + "' group by okl";
                        decimal qtySisa = Convert.ToDecimal(drSelect[0]["Qty"]);
                        double qtyToleransi = DB.GetQtyToleransi(query, inv, unit, baseUnit);
                        //maxValue = Convert.ToDecimal(dr["Qty"]) + Convert.ToDecimal(dr["Toleransi"]);                        
                        if (unit != drSelect[0]["Unit"].ToString())
                            qtySisa = Convert.ToDecimal(DB.GetQtyInAlternativeUom(inv, drSelect[0]["Unit"].ToString(), Convert.ToDouble(qtySisa), unit));
                        maxValue = qtySisa + Convert.ToDecimal(qtyToleransi);
                    }
                }
                else
                {
                    dtOutSpm = DB.sql.Select("Call SP_OutSpm('" + mor + "',12)");
                    DataRow[] drSelect = dtOutSpm.Select("`No Design`='" + nodsg + "'");
                    if (drSelect.Length > 0)
                    {
                        maxValue = Convert.ToDecimal(drSelect[0]["Qty"]);
                        if (unit != drSelect[0]["Unit"].ToString())
                            maxValue = Convert.ToDecimal(DB.GetQtyInAlternativeUom(inv, drSelect[0]["Unit"].ToString(), Convert.ToDouble(maxValue), unit));
                    }
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
            if (e.Column.FieldName == "qtygudang" || e.Column.FieldName == "unitgudang")
            {
                DetailBindingSource.EndEdit();
                string inv = (string)gcSpm.ExGridView.GetFocusedRowCellValue("inv");
                string unitgd = (string)gcSpm.ExGridView.GetFocusedRowCellValue("unitgudang");
                string unitbase = (string)gcSpm.ExGridView.GetFocusedRowCellValue("unit");
                double qtygd = Convert.ToDouble(gcSpm.ExGridView.GetFocusedRowCellValue("qtygudang"));
                int no = Convert.ToInt32(gcSpm.ExGridView.GetFocusedRowCellValue("no"));
                string okl = gcSpm.ExGridView.GetFocusedRowCellValue("okl").ToString();
                string mor = gcSpm.ExGridView.GetFocusedRowCellValue("mor").ToString();
                string nodsg = gcSpm.ExGridView.GetFocusedRowCellValue("nodsg").ToString();

                if (inv != "" && unitgd != "")
                {
                    gcSpm.ExGridView.SetFocusedRowCellValue(gcSpm.ExGridView.Columns["qty"], DB.GetQtyInBaseUom(inv, unitgd, qtygd));
                    gcSpm.ExGridView.SetFocusedRowCellValue(gcSpm.ExGridView.Columns["qtytim"], DB.GetQtyInBaseUom(inv, unitgd, qtygd));
                }
                if (qtygd > 0 && unitgd != "")
                {
                    decimal maxQty = GetMaxValueQtyDikirim(unitgd);
                    if (this.mode == Mode.Edit)
                    {
                        //jika mode=edit, maxQty = maxQty from select + curr qty
                        try
                        {
                            DataRow drCopyDetailTable;
                            drCopyDetailTable = copyDetailTable.Select("okl='" + okl + "' and no=" + no.ToString())[0];
                            maxQty = maxQty;// + Convert.ToDecimal(drCopyDetailTable["qtygudang"]);
                        }
                        catch { }
                    }
                    if (Convert.ToDecimal(qtygd) > maxQty && okl != "")
                    {
                        MessageBox.Show("Qty Dikirim melebihi batas toleransi SO. Max qty dikirim: " + maxQty.ToString() + " " + unitbase);
                        gcSpm.ExGridView.SetFocusedRowCellValue(gcSpm.ExGridView.Columns["qtygudang"], maxQty);
                    }
                }

            }
            else if (e.Column.FieldName == "unit" || e.Column.FieldName == "qty1")
            {
                string unit = (string)gcSpm.ExGridView.GetFocusedRowCellValue("unit");
                double qty1 = Convert.ToDouble(gcSpm.ExGridView.GetFocusedRowCellValue("qty1"));
                int no = Convert.ToInt32(gcSpm.ExGridView.GetFocusedRowCellValue("no"));
                string okl1 = gcSpm.ExGridView.GetFocusedRowCellValue("okl").ToString();

                if (unit != "" && qty1 > 0)
                {
                    decimal maxQty = GetMaxValueQtyDikirim(unit);
                    if (this.mode == Mode.Edit)
                    {
                        try
                        {
                            DataRow drCopyDetailTable;
                            drCopyDetailTable = copyDetailTable.Select("no=" + no.ToString())[0];
                            maxQty = maxQty + Convert.ToDecimal(drCopyDetailTable["qty1"]); ;
                        }
                        catch { }
                    }
                    if (Convert.ToDecimal(qty1) > maxQty && okl1 != "")
                    {
                        MessageBox.Show("Qty SJ melebihi batas toleransi SO. Max qty SJ: " + maxQty.ToString() + " " + unit);
                          gcSpm.ExGridView.SetFocusedRowCellValue(gcSpm.ExGridView.Columns["qty1"], maxQty);
                    }
                }
            }
            else if (e.Column.FieldName == "okl")
            {
                if (ctrlSub.txtSub.EditValue.ToString() == "")
                    ctrlSub.txtSub.EditValue = DB.sql.Select("select sub from okl where okl='" + e.Value.ToString() + "'").Rows[0][0];
                gcSpm.ExGridView.SetRowCellValue(gcSpm.ExGridView.FocusedRowHandle, "mor", "");
                gcSpm.ExGridView.SetRowCellValue(gcSpm.ExGridView.FocusedRowHandle, "nodsg", "");
                gcSpm.ExGridView.SetRowCellValue(gcSpm.ExGridView.FocusedRowHandle, "inv", "");
                gcSpm.ExGridView.SetRowCellValue(gcSpm.ExGridView.FocusedRowHandle, "remark", "");
                gcSpm.ExGridView.SetRowCellValue(gcSpm.ExGridView.FocusedRowHandle, "loc", "");
                gcSpm.ExGridView.SetRowCellValue(gcSpm.ExGridView.FocusedRowHandle, "qty", 0);
                gcSpm.ExGridView.SetRowCellValue(gcSpm.ExGridView.FocusedRowHandle, "unit", "");
                gcSpm.ExGridView.SetRowCellValue(gcSpm.ExGridView.FocusedRowHandle, "qty1", 0);
                gcSpm.ExGridView.SetRowCellValue(gcSpm.ExGridView.FocusedRowHandle, "qtygudang", 0);
                gcSpm.ExGridView.SetRowCellValue(gcSpm.ExGridView.FocusedRowHandle, "unitgudang", "");
                gcSpm.ExGridView.SetRowCellValue(gcSpm.ExGridView.FocusedRowHandle, "etd", "");
                gcSpm.ExGridView.SetRowCellValue(gcSpm.ExGridView.FocusedRowHandle, "Unit Base Dikirim", "");
                //     DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base Dikirim");
            }
            else if (e.Column.FieldName == "qtygudang" || e.Column.FieldName == "qtytim")
            {
                DetailTable = DB.PopulateSelisih(DetailTable, "SPM");
            }

            ReCalculateTotal();
        }

        void ReCalculateTotal()
        {
            DetailBindingSource.EndEdit();

            double Totalqty = 0;
            double Totalqtykemasan = 0;
            for (int i = 0; i < DetailTable.Rows.Count; i++)
            {
                if (DetailTable.Rows[i] != null && DetailTable.Rows[i].RowState != DataRowState.Deleted)
                {
                    Totalqty = Totalqty + (double)DetailTable.Rows[i]["qty"];
                    Totalqtykemasan = Totalqtykemasan + (double)DetailTable.Rows[i]["qtygudang"];
                }
            }
            txtTotalqty.EditValue = Totalqty;
            txtTotalqtykemasan.EditValue = Totalqtykemasan;
        }


        void ExGridView_InvColumnEdit_Enter(object sender, EventArgs e)
        {
              
            GridLookUpEx invLookUp = gcSpm.ExGridView.Columns["inv"].ColumnEdit as GridLookUpEx;
            {
                invLookUp.Query = "Call SP_LookUp('invspm')";
                invLookUp.TableName = "inv";
            }
        }

        void Qty1ColumnEdit_Enter(object sender, EventArgs e)
        {
         //   double qty1 = Convert.ToDouble(gcSpm.ExGridView.GetFocusedRowCellValue("qty1"));
          
         //   PassOto frmDoc = new PassOto();
         //   if (frmDoc.ShowDialog() == DialogResult.OK)
         //   {
         ////       gcSpm.ExGridView.SetFocusedRowCellValue(gcSpm.ExGridView.Columns["qty1"], qty1);
         //       return;
         //   }
         //   else
         //   {
         //     //  gcSpm.ExGridView.SetFocusedRowCellValue(gcSpm.ExGridView.Columns["qty1"], qty1);
         //       gcSpm.ExGridView.FocusedColumn.AbsoluteIndex = 7;
         //   }
        }
        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gcSpm.ExGridView.GetDataRow(e.RowHandle);
            row["spm"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
            //row["no"] = DetailTable.Rows.Count + 1;
            row["no"] = DB.GetRowCount(DetailTable) + 1;
        }

        void txtSub_EditValueChanged(object sender, EventArgs e)
        {
            /*if (MasterBindingSource.Position == MasterTable.Rows.Count)
            {
                DetailBindingSource.EndEdit();
                if (ctrlSub.txtSub.Text != "" && ctrlSub.txtSub.ExIsValid())
                {
                    if (DetailTable.Rows.Count == 0)
                    {
                        GridLookUpEx morLookUp = (GridLookUpEx)gcSpm.ExGridView.Columns["mor"].ColumnEdit;
                        morLookUp.Query = "Call SP_SelectMOforSPM(" + Convert.ToDateTime(dateDate.EditValue).ToString("yyyyMMdd") + ",'" + ctrlSub.txtSub.EditValue.ToString() + "')";
                        morLookUp.ClickButton();
                    }
                }
            }*/
        }

        private void appspmCheckBox_CheckedChanged(object sender, EventArgs e)
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
                MessageBox.Show("SPM tidak dapat diapprove karena ada item detail SPM yang memiliki qty 0");
            }
        }



        private void comboStation_Click(object sender, EventArgs e)
        {
            if (DetailTable.Rows.Count > 0)
            {
                string material = DetailTable.Rows[0]["remark"].ToString().Trim();

                //   DataTable dtloading = DB.sql.Select("select station,material,status,reserved from loading_station where status='A' and reserved='F' and material='" + material + "'");
                string query = "select station,material,status,reserved from loading_station where status='A' and reserved='F' and rtrim(material)=rtrim('" + material + "')";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dtloading = new DataTable();
                adapter.Fill(dtloading);

                comboStation.Items.Clear();
                //if (DetailTable.Rows[0]["inv"].TookString().Substring(0, 1) == "4")
                //{
                   for (int y = 0; y < dtloading.Rows.Count; y++)
                    {
                        comboStation.Items.Add(dtloading.Rows[y]["station"]);
                    }
               // }
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
                string material = DetailTable.Rows[0]["remark"].ToString().Trim();
                double qtyspm = Convert.ToDouble(DetailTable.Rows[0]["qty1"].ToString());
                //cek apakah data spb di plc sudah ada untuk menghindari status edit dan doble klick di send plc
                //DataTable dtcekloading = DB.sql.Select("select SPM_Num,SPM_Station from loading_orders where Spm_Num ='" + NoDocument + "'");
                string query = "select SPM_Num,SPM_Station from loading_orders where Spm_Num ='" + NoDocument + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dtloading = new DataTable();
                adapter.Fill(dtloading);
                if (dtloading.Rows.Count >= 1)
                {
                    MessageBox.Show("Nomor SPM Sudah ada di Plc");
                    sendgdCheckBox.Checked = true;
                }
                else
                {
                    // cek jika ada yg cenntang send plcnya terlambat sehingga ada kemungkinan sama
                    //  DataTable dtloading = DB.sql.Select("select station,material,status,reserved from loading_station where status='A' and reserved='F' and material='" + material + "' and station=" + comboStation.Text);
                    string query1 = "select station,material,status,reserved from loading_station where status='A' and reserved='F' and material='" + material + "' and station=" + comboStation.Text;
                    SqlDataAdapter adapter1 = new SqlDataAdapter(query1, conn);
                    DataTable dtloading1 = new DataTable();
                    adapter1.Fill(dtloading1);

                    if (dtloading1.Rows.Count < 1)
                    {
                        MessageBox.Show("Station Masih dipakai (Bussy) tunggu sampai proses Done");
                        sendgdCheckBox.Checked = false;
                    }
                    else
                    {
                        string query2 = "insert into loading_orders (SPM_Num,SPM_DateTime,SPM_Station,SPM_Material,SPM_Quantity) Values " +
                        "('" + NoDocument + "',getdate()," + Convert.ToInt16(comboStation.Text) + ",'" + material + "'," + qtyspm + ")";
                        SqlCommand adapter2 = new SqlCommand(query2, conn);
                        adapter2.ExecuteNonQuery();
                        MessageBox.Show("Suksess, Spm Telah Terkirim Di PLC");
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double qtyflow;
            if (DetailTable.Rows.Count > 0)
            {
                // DataTable dtloading = DB.sql.Select("select * from loading_summary where SPM_Num='" + NoDocument + "'");
                string query1 = "select * from loading_summary where SPM_Num='" + NoDocument + "'";
                SqlDataAdapter adapter1 = new SqlDataAdapter(query1, conn);
                DataTable dtloading = new DataTable();
                adapter1.Fill(dtloading);
                if (dtloading.Rows.Count < 1)
                {
                    MessageBox.Show("SPM Masih Dalam Proses PLC (Bussy) tunggu sampai proses Done");
                }
                else
                {
                    qtyflow = (double)dtloading.Rows[0]["Act_quantity"];
                    DB.sql.Execute("update spd set qtygudang=" + qtyflow + ",qty=" + qtyflow + " where spm='" + NoDocument + "'");
                    tsbtnRefresh_Click(sender, e);

                }

                DetailTable = DB.PopulateSelisih(DetailTable, "SPM");
            }
        }

        private void cpoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //disable enable for station and qty gudang
            //{
            comboStation.Enabled = (cpoCheckBox.Checked);
            Stationlabel.Enabled = cpoCheckBox.Checked;
            sendgdCheckBox.Enabled = cpoCheckBox.Checked;
            //}
            if (cpoCheckBox.Checked)
            {
                if (manualspm == 0)
                {
                    // trial testing sementara qty flow di open
                    gcSpm.ExGridView.Columns["qtygudang"].OptionsColumn.AllowEdit = true;
                    gcSpm.ExGridView.Columns["unitgudang"].OptionsColumn.AllowEdit = true;
                    gcSpm.ExGridView.Columns["qtygudang"].Caption = "Qty Flow";
                }
            }
            else
            {
                gcSpm.ExGridView.Columns["qtygudang"].Caption = "Qty Gdg";
                gcSpm.ExGridView.Columns["qtygudang"].OptionsColumn.AllowEdit = true;
                gcSpm.ExGridView.Columns["unitgudang"].OptionsColumn.AllowEdit = true;

            }
        }

        private void oklTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {
            DataRow row = oklTextBoxEx.ExGetDataRow();
            if (row == null)
                return;

            ctrlSub.txtSub.EditValue = row["Customer"];

           // DetailTable.Clear();
            int tNo = 9999;
            foreach (DataRow dr in DetailTable.Rows)
            {
                dr["no"] = tNo;
                dr.Delete();
                tNo++;
            }

          //  DataTable dtSpd = DB.sql.Select("select * from dod where doh='" + oklTextBoxEx.Text + "'");
            if (this.mode != Mode.View)
            {

                DataTable dtSpd = DB.sql.Select("Call SP_SelectSPMforSJ_SPM(3,'" + oklTextBoxEx.Text + "')");
                int no = DB.GetRowCount(DetailTable) + 1;
                foreach (DataRow drSpd in dtSpd.Rows)
                {
                    DataRow drSjd = DetailTable.NewRow();
                    drSjd["spm"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
                    drSjd["no"] = no;
                    drSjd["inv"] = drSpd["inv"];
                    drSjd["remark"] = drSpd["remark"];
                    drSjd["okl"] = drSpd["okl"];
                    drSjd["loc"] = drSpd["loc"];
                    drSjd["unit"] = drSpd["unit"];
                    drSjd["qty1"] = drSpd["qty"];
                    drSjd["qty"] = 0;
                    drSjd["nodsg"] = drSpd["nodsg"];
                    drSjd["qtygudang"] = drSpd["qtys"];
                    drSjd["unitgudang"] = drSpd["units"];
                    drSjd["Unit Base Dikirim"] = drSpd["units"];
                    drSjd["qtytim"] = drSpd["qtys"];
                    drSjd["beda"] = 0;
                    drSjd["unit"] = drSpd["unit"];
                    drSjd["qty"] = drSpd["qty"];

                    gcSpm.ExGridView.Columns["Unit Base Dikirim"].OptionsColumn.AllowEdit = false;
                    gcSpm.ExGridView.Columns["qtytim"].OptionsColumn.AllowEdit = false;
                    gcSpm.ExGridView.Columns["Beda"].VisibleIndex = DetailTable.Columns.IndexOf("etd");
                    gcSpm.ExGridView.Columns["Beda"].OptionsColumn.AllowEdit = false;
                  //  drSjd["qty"] = DB.GetQtyInBaseUom(drSjd["inv"].ToString(), drSjd["unit"].ToString(), Convert.ToDouble(drSjd["qty1"]));
                    DetailTable.Rows.Add(drSjd);
                    no++;

                    ReCalculateTotal();
                }
           }
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base Dikirim");
        }

        private void comboStation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sendgdCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nodocTextBoxEx_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            nodocTextBoxEx.ExSqlQuery = "SELECT nodoc,datedoc,no_bc,nopen FROM docp,docpd where docp.docp=docpd.docp and docp.oms = (select doh.okl from doh where doh='" + oklTextBoxEx.EditValue.ToString() + "') and docpd.nodoc = '" + NoDocument + "'";
    
        }

        private void ExGridView_UnitColumnEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(0);
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