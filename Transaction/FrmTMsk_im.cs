using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using KASLibrary;
using DevExpress.XtraEditors.Repository;
using MySql.Data.MySqlClient;
using DevExpress.XtraReports.UI;

namespace CAS.Transaction
{
    public partial class FrmTMsk_im : CAS.Transaction.BaseTransaction
    {
        MySqlDataAdapter mslAdapter, msxAdapter, umkpAdapter, msdAdapter;
        string deletedMsk = "";
        DataTable dtResult = new DataTable();
        DataTable dtKodeTransaksi = new DataTable();
        DataTable dtBaseUnit = new DataTable();

        RepositoryItemComboBox Cinvo = new RepositoryItemComboBox();

        public FrmTMsk_im()
        {
            InitializeComponent();
            ToolStripMenuItem tsmiPrintPreview = new ToolStripMenuItem("Print Preview", null, new EventHandler(tsmiPrintPreview_Click));
            ToolStripMenuItem tsmiPrintDirectly = new ToolStripMenuItem("Print Directly", null, new EventHandler(tsmiPrintDirectly_Click));
            ToolStripDropDownButton tsbtnPrint = new ToolStripDropDownButton("Print", null, tsmiPrintPreview, tsmiPrintDirectly);
            tsbtnPrint.Image = MasterNavigator.Items["tsbtnPrint"].Image;
            MasterNavigator.Items.Insert(MasterNavigator.Items.IndexOfKey("tsbtnPrint"), tsbtnPrint);
            MasterNavigator.Items.RemoveByKey("tsbtnPrint");

            MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);

            // PO
            gcxMsl.ExTitleLabel.Text = "Detail PO";
            gcxMsl.ExGridControl.DataSource = mslBindingSource;
            gcxMsl.ExGridView.OptionsView.ShowGroupPanel = false;
            gcxMsl.ExGridView.OptionsCustomization.AllowSort = false;
            gcxMsl.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(gcxMsl_tsbtnDelete_Click);
            gcxMsl.ExGridView.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(gcxMsl_SelectionChanged);
            gcxMsl.ExGridView.Columns["msk"].Visible = gcxMsl.ExGridView.Columns["no"].Visible = false;
            gcxMsl.ExGridView.Columns["oms"].Caption = "Purchase Order";
            gcxMsl.ExGridView.Columns["lph"].Caption = "Penerimaan Barang";
            gcxMsl.ExGridView.Columns["date"].Caption = "Tanggal";
            gcxMsl.ExGridView.Columns["remark"].Caption = "Keterangan";
            gcxMsl.ExGridView.Columns["val"].Caption = "Val";
            DB.SetNumberFormat(gcxMsl.ExGridView, "n2");

            // Invoice
            gcxMsd.ExTitleLabel.Text = "Invoice";
            gcxMsd.ExGridControl.DataSource = msdBindingSource;
            gcxMsd.ExGridView.OptionsView.ShowGroupPanel = false;
            gcxMsl.ExGridView.OptionsCustomization.AllowSort = false;
            gcxMsd.ExGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(gcxMsd_InitNewRow);
            gcxMsd.ExGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(ExGridView_CellValueChanged);
            gcxMsd.ExGridView.Columns["val"].OptionsColumn.AllowEdit = false;
            // gcxMsd.ExGridView.Columns["kurs"].OptionsColumn.AllowEdit = false;
            gcxMsd.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(gcxMsd_tsbtnDelete_Click);
            gcxMsd.ExGridView.Columns["msk"].Visible = gcxMsd.ExGridView.Columns["no"].Visible = false;
            gcxMsd.ExGridView.Columns["oms"].ColumnEdit = new RepositoryItemComboBox();
            (gcxMsd.ExGridView.Columns["oms"].ColumnEdit as RepositoryItemComboBox).TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            gcxMsd.ExGridView.Columns["oms"].Caption = "Purchase Order";
            gcxMsd.ExGridView.Columns["invo"].Caption = "Invoice";
            gcxMsd.ExGridView.Columns["nofp"].Caption = "No Faktur Pajak";
            gcxMsd.ExGridView.Columns["tglfp"].Caption = "Tanggal Faktur Pajak";
            gcxMsd.ExGridView.Columns["tglsfp"].Caption = "Tgl Setor Faktur Pajak";
            gcxMsd.ExGridView.Columns["kurs"].Caption = "Kurs";
            gcxMsd.ExGridView.Columns["dpp"].Caption = "DPP";
            gcxMsd.ExGridView.Columns["dpp"].ColumnEdit = new GridNumEx();
            gcxMsd.ExGridView.Columns["ppn"].Caption = "PPN";
            gcxMsd.ExGridView.Columns["ppn"].OptionsColumn.AllowEdit = true;
            gcxMsd.ExGridView.Columns["ppn"].ColumnEdit = new GridNumEx();
            gcxMsd.ExGridView.Columns["val"].Caption = "Val";
            gcxMsd.ExGridView.Columns["remark"].Caption = "Keterangan";
            DB.SetNumberFormat(gcxMsd.ExGridView, "n2");

            // Debet Kredit ComboBox
            RepositoryItemComboBox cboDK = new RepositoryItemComboBox();
            cboDK.Items.AddRange(new string[] { "D", "K" });
            cboDK.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;

            // Biaya
            gcxMsx.ExTitleLabel.Text = "Jurnal";
            gcxMsx.ExGridControl.DataSource = msxBindingSource;
            gcxMsx.ExGridView.OptionsView.ShowGroupPanel = false;
            gcxMsx.ExGridView.OptionsCustomization.AllowSort = false;
            gcxMsx.ExGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(gcxMsx_InitNewRow);
            gcxMsx.ExGridView.Columns["acc"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('acc')", "acc", "acc", gcxMsx.ExGridView, "", true, false, "Perkiraan");
            gcxMsx.ExGridView.Columns["cct"].ColumnEdit = new GridLookUpEx(DB.sql, "select cct as `Cost Center` , name from cct", "cct", "cct", gcxMsx.ExGridView, "", false, false, "Cost Center");
            gcxMsx.ExGridView.Columns["dk"].ColumnEdit = cboDK;
            gcxMsx.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(gcxMsx_tsbtnDelete_Click);
            gcxMsx.ExGridView.Columns["msk"].Visible = gcxMsx.ExGridView.Columns["no"].Visible = false;
            gcxMsx.ExGridView.Columns["acc"].Caption = "Account";
            gcxMsx.ExGridView.Columns["remark"].Caption = "Keterangan";
            gcxMsx.ExGridView.Columns["cct"].Caption = "Cost Center";
            gcxMsx.ExGridView.Columns["dk"].Caption = "D/K";
            gcxMsx.ExGridView.Columns["val"].Caption = "Nilai";
            gcxMsx.ExGridView.Columns["val"].ColumnEdit = new GridNumEx();
            DB.SetNumberFormat(gcxMsx.ExGridView, "n2");

            gcxMsx.ExGridView.Columns["cad"].VisibleIndex = 1;
            gcxMsx.ExGridView.Columns["ino"].VisibleIndex = 2;
            gcxMsx.ExGridView.Columns["acc"].VisibleIndex = 3;
            gcxMsx.ExGridView.Columns["cct"].VisibleIndex = 4;
            gcxMsx.ExGridView.Columns["remark"].VisibleIndex = 5;
            gcxMsx.ExGridView.Columns["dk"].VisibleIndex = 6;
            gcxMsx.ExGridView.Columns["val"].VisibleIndex = 7;
            gcxMsx.ExGridView.Columns["kurs"].VisibleIndex = 8;
            gcxMsx.ExGridView.Columns["tarif"].VisibleIndex = 9;
            gcxMsx.ExGridView.Columns["pph23"].VisibleIndex = 10;
            gcxMsx.ExGridView.Columns["pph4ay2"].VisibleIndex = 11;
            gcxMsx.ExGridView.Columns["pph15"].VisibleIndex = 12;
            gcxMsx.ExGridView.Columns["okl"].VisibleIndex = 13;

            gcxMsx.ExGridView.Columns["acc"].Caption = "Kode Akun";
            gcxMsx.ExGridView.Columns["val"].Caption = "Nilai";
            gcxMsx.ExGridView.Columns["pph23"].Caption = "PPH23";
            gcxMsx.ExGridView.Columns["pph4ay2"].Caption = "PPH4ay2";
            gcxMsx.ExGridView.Columns["pph15"].Caption = "PPH15";

            // Penerimaan Barang
            casDataSet.lpd.Columns.Add("Unit Base", typeof(String));
            gcxLpd.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gcxLpd.ExToolStrip.Items["tsbtnNew"].Enabled = false;
            gcxLpd.ExTitleLabel.Text = "Detail Penerimaan Barang";
            gcxLpd.ExGridControl.DataSource = casDataSet.lpd;
            gcxLpd.ExGridView.OptionsView.ShowGroupPanel = false;
            gcxLpd.ExGridView.OptionsCustomization.AllowSort = false;
            gcxLpd.ExGridView.Columns["lph"].Caption = "LPB";
            gcxLpd.ExGridView.Columns["inv"].Caption = "Kode Barang";
            gcxLpd.ExGridView.Columns["remark"].Caption = "Nama Barang";
            gcxLpd.ExGridView.Columns["loc"].Caption = "Loc";
            gcxLpd.ExGridView.Columns["qty"].Caption = "Qty Base";
            gcxLpd.ExGridView.Columns["qty1"].Caption = "Qty";
            gcxLpd.ExGridView.Columns["unit"].Caption = "Unit";
            gcxLpd.ExGridView.Columns["etd"].Caption = "Keterangan";
            gcxLpd.ExGridView.Columns["cct"].Caption = "Cost Center";
            gcxLpd.ExGridView.Columns["no"].Visible = false;
            gcxLpd.ExGridView.Columns["Unit Base"].VisibleIndex = casDataSet.lpd.Columns.IndexOf("qty") + 1;
            DB.SetNumberFormat(gcxLpd.ExGridView, "n2");

            // Uang Muka
            casDataSet.umkp.Columns.Add("debet", typeof(String));
            gcxUmkp.ExTitleLabel.Text = "Uang Muka";
            gcxUmkp.ExGridControl.DataSource = umkpBindingSource;
            gcxUmkp.ExGridView.OptionsView.ShowGroupPanel = false;
            gcxUmkp.ExGridView.OptionsCustomization.AllowSort = false;
            gcxUmkp.ExGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(gcxUmkp_InitNewRow);
            gcxUmkp.ExGridView.Columns["acc"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_Lookup('acc')", "acc", "acc", gcxUmkp.ExGridView, "", true, false, "Perkiraan");
            gcxUmkp.ExGridView.Columns["jurnal"].ColumnEdit = new GridLookUpEx(DB.sql, "call SP_OutRhp('" + ctrlSub.txtSub.Text + "','" + ctrlSub.txtSub.Text + "'," + Utility.FirstDateInMonth(dateDate.DateTime).ToString("yyyyMMdd") + "," + ((DateTime)dateDate.EditValue).AddDays(1).ToString("yyyyMMdd") + ",'" + ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text + "','2')", "rhp", "jurnal", gcxUmkp.ExGridView, "", true, true, "Detail Hutang");
            gcxUmkp.ExGridView.Columns["jurnal"].ColumnEdit.Enter += new EventHandler(ExGridView_jurnalColumnEdit_Enter);
            gcxUmkp.ExGridView.Columns["cct"].ColumnEdit = new GridLookUpEx(DB.sql, "select cct, name from cct", "cct", "cct", gcxUmkp.ExGridView, "", false, false, "Cost Center");

            gcxUmkp.ExGridView.Columns["invoice"].ColumnEdit = Cinvo;

            gcxUmkp.ExGridView.Columns["dk"].ColumnEdit = cboDK;
            gcxUmkp.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(gcxUmkp_tsbtnDelete_Click);
            gcxUmkp.ExGridView.Columns["msk"].Visible = gcxUmkp.ExGridView.Columns["no"].Visible = false;
            gcxUmkp.ExGridView.Columns["debet"].Visible = false;
            gcxUmkp.ExGridView.Columns["invoice"].Visible = true;
            gcxUmkp.ExGridView.Columns["invo"].Visible = false;
            gcxUmkp.ExGridView.Columns["invoice"].Caption = "Invoice";
            gcxUmkp.ExGridView.Columns["jurnal"].Caption = "Jurnal";
            gcxUmkp.ExGridView.Columns["acc"].Caption = "Perkiraan";
            gcxUmkp.ExGridView.Columns["remark"].Caption = "Keterangan";
            gcxUmkp.ExGridView.Columns["cct"].Caption = "Cost Center";
            gcxUmkp.ExGridView.Columns["dk"].Caption = "Debet/Kredit";
            gcxUmkp.ExGridView.Columns["debet"].Caption = "D/K";
            gcxUmkp.ExGridView.Columns["val"].Caption = "Nilai";
            gcxUmkp.ExGridView.Columns["kurs"].Caption = "Kurs";
            gcxUmkp.ExGridView.Columns["val"].ColumnEdit = new GridNumEx();

            gcxUmkp.ExGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(gvUmkp_CellValueChanged);
            DB.SetNumberFormat(gcxUmkp.ExGridView, "n2");

            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
            //tsbtnDelete.Click += new EventHandler(tsbtnDelete_Click);

        }

        //void ExGridView_jurnalColumnEdit_Enter(object sender, EventArgs e)
        //{
        //    string query = "call SP_OutRhp('" + ctrlSub.txtSub.Text + "','" + ctrlSub.txtSub.Text + "'," + Utility.FirstDateInMonth(dateDate.DateTime).ToString("yyyyMMdd") + "," + ((DateTime)dateDate.EditValue).AddDays(1).ToString("yyyyMMdd") + ",'" + ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text + "','2')";
        //    ((GridLookUpEx)gcxUmkp.ExGridView.Columns["jurnal"].ColumnEdit).Query = query;
        //}


        void tsmiPrintDirectly_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "BuktiUtang" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_PrintInvoice('Transaction.FrmTMsk','" + this.NoDocument + "')");
            report.PrintingSystem.ShowMarginsWarning = false;
            //report.PrintingSystem.Document.PrintingSystem.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            //report.PrintingSystem.Document.PrintingSystem.PageSettings.PaperName = "1/2A4";
            //report.PrintingSystem.Document.PrintingSystem.PageSettings.RightMargin = 0;
            report.PaperName = "1/2A4";
            report.Print();
        }

        void tsmiPrintPreview_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "BuktiUtangImport" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_PrintInvoice('Transaction.FrmTMsk','" + this.NoDocument + "')");
            report.ShowPreview();
        }
        //set button New & Delete mode on GridView
        private void SetMode(Mode mode)
        {
            gcxMsl.ExToolStrip.Items["tsbtnDelete"].Enabled = (mode == Mode.Edit) ? true : false;
            gcxMsl.ExToolStrip.Items["tsbtnNew"].Enabled = (mode == Mode.Edit) ? true : false;
            gcxMsd.ExToolStrip.Items["tsbtnDelete"].Enabled = (mode == Mode.Edit) ? true : false;
            gcxMsd.ExToolStrip.Items["tsbtnNew"].Enabled = (mode == Mode.Edit) ? true : false;
            gcxMsx.ExToolStrip.Items["tsbtnDelete"].Enabled = (mode == Mode.Edit) ? true : false;
            gcxMsx.ExToolStrip.Items["tsbtnNew"].Enabled = (mode == Mode.Edit) ? true : false;
            gcxUmkp.ExToolStrip.Items["tsbtnDelete"].Enabled = (mode == Mode.Edit) ? true : false;
            gcxUmkp.ExToolStrip.Items["tsbtnNew"].Enabled = (mode == Mode.Edit) ? true : false;
        }

        void msxExGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "tarif")
            {

                double val = (double)gcxMsx.ExGridView.GetRowCellValue(e.RowHandle, gcxMsx.ExGridView.Columns["val"]);
                double kurs = (double)gcxMsx.ExGridView.GetRowCellValue(e.RowHandle, gcxMsx.ExGridView.Columns["kurs"]);
                double tarif = (double)gcxMsx.ExGridView.GetRowCellValue(e.RowHandle, gcxMsx.ExGridView.Columns["tarif"]);
                if (tarif > 0)
                {
                    double pph = val * kurs * tarif / 100;
                    pph = pph - pph % 1;
                    gcxMsx.ExGridView.SetRowCellValue(e.RowHandle, gcxMsx.ExGridView.Columns["pph23"], pph);
                    gcxMsx.ExGridView.SetRowCellValue(e.RowHandle, gcxMsx.ExGridView.Columns["pph4ay2"], 0);
                    gcxMsx.ExGridView.SetRowCellValue(e.RowHandle, gcxMsx.ExGridView.Columns["pph15"], 0);
                }
                ReCalculateTotal();
            }
            if (e.Column.FieldName == "pph23" || e.Column.FieldName == "pph4ay2" || e.Column.FieldName == "pph15")
            {
                ReCalculateTotal();
            }
        }

        void ExGridView_jurnalColumnEdit_Enter(object sender, EventArgs e)
        {
            string query = "call SP_OutRhp('" + ctrlSub.txtSub.Text + "','" + ctrlSub.txtSub.Text + "'," + Utility.FirstDateInMonth(dateDate.DateTime).ToString("yyyyMMdd") + "," + ((DateTime)dateDate.EditValue).AddDays(1).ToString("yyyyMMdd") + ",'" + ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text + "','2')";
            ((GridLookUpEx)gcxUmkp.ExGridView.Columns["jurnal"].ColumnEdit).Query = query;
        }

        protected override void tsbtnDelete_Click(object sender, EventArgs e)
        {
            base.tsbtnDelete_Click(sender, e);
            if (Convert.ToInt32(MasterTable.Rows[MasterBindingSource.Position]["delete"]) == 1)
            {
                DB.sql.Execute("Call SP_Delete('MSK'" + ",'" + NoDocument + "')");
                DB.sql.Execute("Call SP_OpenTransaction('MSK','" + NoDocument + "')");
            }
            if (MasterBindingSource.Position == -1)
                tsbtnNew.PerformClick();
        }

        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            PopulateDetails();
            ReCalculateTotal();
        }

        void RePopulate_List_Cbo_Oms()
        {
            dtResult.Clear();

            //add by gita 08/07/08
            //populate Oms to listOms
            listOms.Items.Clear();
            foreach (DataRow drMsl in casDataSet.msl.Rows)
            {
                if (listOms.Items.IndexOf(drMsl["oms"]) == -1)
                {
                    listOms.Items.Add(drMsl["oms"].ToString());
                    DataTable dt = DB.sql.Select("Select * from oms where oms='" + drMsl["oms"].ToString() + "'");
                    if (dt.Rows.Count > 0)
                        chkPR.Checked = false;
                    else
                    {
                        dt = DB.sql.Select("Select prq as oms, date, remark, '' as sub, '' as cur, 0 as kurs, 0 as ppn, '' as period, '' as chtime, '' as chusr from prq where prq='" + drMsl["oms"].ToString() + "'");
                        chkPR.Checked = true;
                    }
                    dtResult.ImportRow(dt.Rows[0]);
                }
            }
            //populate listOms to cboOms in Invoice
            RepositoryItemComboBox cboOms = (RepositoryItemComboBox)gcxMsd.ExGridView.Columns["oms"].ColumnEdit;
            cboOms.Items.Clear();
            cboOms.Items.AddRange(listOms.Items);
        }

        private void PopulateDetails()
        {
            try
            {
                bool newEntry = (MasterBindingSource.Position == MasterTable.Rows.Count);
                string query = "";

                // Msd -> add by gita 08/07/08
                casDataSet.msd.Clear();
                if (newEntry)
                    query = "select * from msd where 0";
                else
                    query = "select * from msd where msk='" + MasterTable.Rows[MasterBindingSource.Position][0].ToString() + "'";
                msdAdapter = DB.sql.SelectAdapter(query);
                msdAdapter.Fill(casDataSet.msd);
                gcxMsd.ExGridView.BestFitColumns();

                // Msl
                casDataSet.msl.Clear();
                if (newEntry)
                    query = "select * from msl where 0";
                else
                    query = "select * from msl where msk='" + MasterTable.Rows[MasterBindingSource.Position][0].ToString() + "'";
                mslAdapter = DB.sql.SelectAdapter(query);
                mslAdapter.Fill(casDataSet.msl);
                gcxMsl.ExGridView.BestFitColumns();

                RePopulate_List_Cbo_Oms();

                // Lpd
                casDataSet.lpd.Clear();
                foreach (DataRow drMsl in casDataSet.msl.Rows)
                {
                    DataTable dtLpd = DB.sql.Select("select lpd.*, inv.unit as `Unit Base` from lpd, inv where lpd.inv=inv.inv and lph='" + drMsl["lph"] + "'");
                    foreach (DataRow drLpd in dtLpd.Rows)
                        casDataSet.lpd.ImportRow(drLpd);
                }
                //gcxLpd.ExGridControl.DataSource = casDataSet.lpd;
                gcxLpd.ExGridView.BestFitColumns();

                // Msx
                casDataSet.msx.Clear();
                if (newEntry)
                    query = "select * from msx where 0";
                else
                    query = "select * from msx where msk='" + MasterTable.Rows[MasterBindingSource.Position][0].ToString() + "'";
                msxAdapter = DB.sql.SelectAdapter(query);
                msxAdapter.Fill(casDataSet.msx);
                gcxMsx.ExGridView.BestFitColumns();

                // Umkp
                casDataSet.umkp.Clear();
                if (newEntry)
                    query = "select * from umkp where 0";
                else
                    query = "select * from umkp where msk='" + MasterTable.Rows[MasterBindingSource.Position][0].ToString() + "'";
                umkpAdapter = DB.sql.SelectAdapter(query);
                umkpAdapter.Fill(casDataSet.umkp);
                gcxUmkp.ExGridView.BestFitColumns();

            }
            catch (Exception ex)
            {
                //remarked: caused by an Open DataReader error
                //MessageBox.Show(ex.Message);
            }
        }

        void gcxMsd_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gcxMsd.ExGridView.GetDataRow(e.RowHandle);
            row["msk"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
            row["no"] = gcxMsd.ExGridView.RowCount;
            row["kurs"] = 1;
        }

        void gcxMsx_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gcxMsx.ExGridView.GetDataRow(e.RowHandle);
            row["msk"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
            row["no"] = gcxMsx.ExGridView.RowCount;
            row["pph23"] = 0;
            row["pph4ay2"] = 0;
            row["pph15"] = 0;
            row["kurs"] = 1;
        }

        void gcxUmkp_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gcxUmkp.ExGridView.GetDataRow(e.RowHandle);
            row["msk"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
            row["no"] = gcxUmkp.ExGridView.RowCount;
            row["kurs"] = 1;

        }

        void ExGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "dpp" || e.Column.FieldName == "ppn")
            {
                double dpp = (double)gcxMsd.ExGridView.GetRowCellValue(e.RowHandle, gcxMsd.ExGridView.Columns["dpp"]);
                double ppn = (double)gcxMsd.ExGridView.GetRowCellValue(e.RowHandle, gcxMsd.ExGridView.Columns["ppn"]);
                //double disc = (double)gcxMsd.ExGridView.GetRowCellValue(e.RowHandle, gcxMsd.ExGridView.Columns["disc"]);
                //double totdisc = (dpp * disc) / 100;
                //double val = dpp + ppn - totdisc;
                double val = dpp + ppn;
                //gcxMsd.ExGridView.SetRowCellValue(e.RowHandle, gcxMsd.ExGridView.Columns["disc_val"], totdisc);
                gcxMsd.ExGridView.SetRowCellValue(e.RowHandle, gcxMsd.ExGridView.Columns["val"], val);

                ReCalculateTotal();
            }
            //else if (e.Column.FieldName == "oms")
            //{
            //    double kurs = (double)gcxMsd.ExGridView.GetRowCellValue(e.RowHandle, gcxMsd.ExGridView.Columns["kurs"]);
            //    if (kurs == 0)
            //    {
            //        //load kurs, dpp, ppn, val

            //    }
            //}
            else if (e.Column.FieldName == "tglfp")
            {
                //tgl setor faktur pajak = tgl 15 berikutnya setelah tgl faktur pajak
                DateTime tglFP = (DateTime)gcxMsd.ExGridView.GetFocusedRowCellValue("tglfp");
                DateTime tglSetorFP = new DateTime(tglFP.Year, tglFP.Month, 15);
                if (tglFP.Day > 15)
                    tglSetorFP = tglSetorFP.AddMonths(1);
                gcxMsd.ExGridView.SetRowCellValue(e.RowHandle, gcxMsd.ExGridView.Columns["tglsfp"], tglSetorFP);
            }
        }

        void gvUmkp_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "val")
                ReCalculateTotal();
            if (e.Column.FieldName == "debet")
            {
                string debet = "D";
                if (gcxUmkp.ExGridView.GetFocusedRowCellValue(gcxUmkp.ExGridView.Columns["debet"]).ToString() == "D") debet = "K";
                gcxUmkp.ExGridView.SetFocusedRowCellValue(gcxUmkp.ExGridView.Columns["dk"], debet);
            }
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            gcxMsd.ExGridView.OptionsBehavior.Editable = true;
            gcxMsd.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

            gcxMsx.ExGridView.OptionsBehavior.Editable = true;
            gcxMsx.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

            gcxUmkp.ExGridView.OptionsBehavior.Editable = true;
            gcxUmkp.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

            btnAddOms.Enabled = true;
            btnDeleteOms.Enabled = true;

            chkPR.Checked = false;
            chkPR.Enabled = true;

            SetMode(Mode.Edit);
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            gcxMsd.ExGridView.OptionsBehavior.Editable = true;
            gcxMsd.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

            gcxMsx.ExGridView.OptionsBehavior.Editable = true;
            gcxMsx.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

            gcxUmkp.ExGridView.OptionsBehavior.Editable = true;
            gcxUmkp.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

            btnAddOms.Enabled = true;
            btnDeleteOms.Enabled = true;

            SetMode(Mode.Edit);
        }

        private void FrmTMsk_im_Load(object sender, EventArgs e)
        {
            dtResult = casDataSet.oms.Clone();

            if (MasterBindingSource.Position == MasterTable.Rows.Count)
            {
                btnAddOms.Enabled = true;
                btnDeleteOms.Enabled = true;
                SetMode(Mode.Edit);
            }
            else
            {
                btnAddOms.Enabled = false;
                btnDeleteOms.Enabled = false;
                SetMode(Mode.View);
            }
            Utility.SetSqlInstance(pnlDetail, DB.sql);
            ctrlSub.Type = CtrlSub.SubType.SupplierImport;
            ctrlSub.txtSub.DataBindings.Add("EditValue", mskBindingSource, "sub");
            ctrlSub.txtSub.EditValueChanged += new EventHandler(txtSub_EditValueChanged);
            PopulateDetails();
            Utility.SetNumberFormat(pnlTotal, "n2");
            ReCalculateTotal();

         //   curcur.Properties.ReadOnly = true;

            //get master table Kode Transaksi & Material Unit
            dtKodeTransaksi = DB.GetKodeTransaksiTable();
            dtBaseUnit = DB.GetBaseUnitTable();
        }

        private void FillMsdLpd()
        {
            casDataSet.lpd.Clear();
            casDataSet.msd.Clear();
            casDataSet.msx.Clear();
            string noPO = "";

            foreach (DataRow lphRow in casDataSet.msl.Rows)
            {
                if (lphRow.RowState != DataRowState.Deleted)
                {
                    noPO = lphRow["oms"].ToString();

                    // Add Inventories to Penerimaan Barang
                    DataTable dtLpd = DB.sql.Select("select lph, inv, loc, remark,qtyc, qty, no, qty1, unit, cct, etd"
                        + " from lpd where lph='" + lphRow["lph"].ToString() + "'");
                    foreach (DataRow lpdRow in dtLpd.Rows)
                    {
                        //casDataSet.lpd.ImportRow(lpdRow);
                        DataRow lpdNewRow = casDataSet.lpd.NewRow();
                        foreach (DataColumn lpdCol in casDataSet.lpd.Columns)
                        {
                            if (lpdCol.ColumnName.ToString() == "Unit Base")
                                lpdNewRow[lpdCol.ColumnName] = dtBaseUnit.Select("inv='" + lpdNewRow["inv"].ToString() + "'")[0]["unit"];
                            else
                                lpdNewRow[lpdCol.ColumnName] = lpdRow[lpdCol.ColumnName];
                        }
                        casDataSet.lpd.Rows.Add(lpdNewRow);
                    }
                    //casDataSet.lpd = DB.PopulateUnitBase(casDataSet.lpd, "Unit Base");
                    gcxLpd.ExGridView.BestFitColumns();

                    // Add POs to Invoice Tab                
                    DataRow msdRow = casDataSet.msd.NewRow();
                    if (casDataSet.msd.Select("oms='" + noPO + "'").Length > 0)
                        msdRow = casDataSet.msd.Select("oms='" + noPO + "'")[0];
                    else
                    {
                        msdRow["msk"] = lphRow["msk"];
                        msdRow["no"] = casDataSet.msd.Rows.Count + 1;
                        msdRow["oms"] = lphRow["oms"];
                        if (chkPR.Checked)
                            msdRow["kurs"] = curkurs.EditValue;
                        else
                            msdRow["kurs"] = dtResult.Select("oms='" + noPO + "'")[0]["kurs"];//omsRow["kurs"];
                        msdRow["dpp"] = 0;
                        casDataSet.msd.Rows.Add(msdRow);
                    }
                    msdRow["dpp"] = Convert.ToDouble(msdRow["dpp"]) + Convert.ToDouble(lphRow["val"]);
                    //if (Convert.ToInt64(dtResult.Select("oms='" + noPO + "'")[0]["ppn"]) == 1)//omsRow["ppn"]) == 1)
                    //    msdRow["ppn"] = Convert.ToDouble(msdRow["dpp"]) * 0.1;
                    msdRow["val"] = Convert.ToDouble(msdRow["dpp"]) + Convert.ToDouble(msdRow["ppn"]);

                    // Add jurnals to Jurnal Tab
                    //      if (chkPR.Checked)
                    //    {
                    DataTable dtMsx = DB.sql.Select("call SP_carijurnalprq ('" + lphRow["lph"].ToString() + "')");
                    //      DataTable dtMsx = DB.sql.Select("select * from prd "
                    //          + "where prq='" + noPO + "' and inv in (select inv from lpd where lph='" + lphRow["lph"].ToString() + "')");
                    foreach (DataRow drMsx in dtMsx.Rows)
                    {
                        DataRow msxRow = casDataSet.msx.NewRow();
                        msxRow["msk"] = lphRow["msk"];
                        //find acc from kode transaksi
                        try
                        {
                            msxRow["acc"] = drMsx["acc"];
                            msxRow["remark"] = drMsx["name"];
                        }
                        catch (Exception ex)
                        {
                            msxRow["acc"] = "";
                        }
                        msxRow["cct"] = drMsx["cct"];
                        msxRow["val"] = 0;
                        msxRow["kurs"] = drMsx["kurs"];
                        msxRow["dk"] = "D";
                        msxRow["no"] = casDataSet.msx.Rows.Count + 1;
                        casDataSet.msx.Rows.Add(msxRow);
                    }
                    //    }
                }
            }
            gcxMsd.ExGridView.BestFitColumns();
        }

        private void btnAddOms_Click(object sender, EventArgs e)
        {
            if (ctrlSub.txtSub.Text == "")
                throw new Exception("Please select Supplier!");

            FrmDialog omsDialog;

            if (!chkPR.Checked)
                //omsDialog = new FrmDialog("PO", DB.sql, "select * from oms where aprov=1 and closedval=0 and sub='" +
                //    ctrlSub.txtSub.Text + "' and oms in (select oms from lph where lph not in (select lph from msl))");
                omsDialog = new FrmDialog("PO", DB.sql, "Call SP_SelectforInvoice('POI','" + ctrlSub.txtSub.EditValue.ToString() + "')");
            else
                omsDialog = new FrmDialog("PR", DB.sql, "Call SP_SelectforInvoice('PR','')");

            string PO_PR_no;
            if (omsDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (DataRow omsRow in omsDialog.ResultRows)
                {
                    //dtResult.ImportRow(omsRow);
                    DataRow drResult = dtResult.NewRow();
                    if (!chkPR.Checked)
                    {
                        PO_PR_no = omsRow["PO"].ToString();
                        drResult["cur"] = omsRow["cur"];
                        drResult["val"] = omsRow["nilai"];
                        drResult["kurs"] = omsRow["Kurs"];
                    }
                    else
                    {
                        PO_PR_no = omsRow["PR"].ToString();
                        drResult["cur"] = "IDR";
                        drResult["val"] = 0;
                        drResult["kurs"] = 1;
                    }
                    if (dtResult.Rows.Find(PO_PR_no) != null)
                    {
                        //MessageBox.Show("Data sudah ada !!");
                        return;
                    }
                    drResult["oms"] = PO_PR_no;
                    drResult["date"] = omsRow["Tanggal"];
                    drResult["remark"] = omsRow["Keterangan"];
                    drResult["ppn"] = omsRow["PPN"];
                    drResult["sub"] = "";
                    drResult["period"] = "";
                    drResult["chtime"] = "";
                    drResult["chusr"] = "";
                    dtResult.Rows.Add(drResult);

                    //if (listOms.Items.IndexOf(omsRow["oms"].ToString()) < 0)
                    if (listOms.Items.IndexOf(PO_PR_no) < 0)
                    {
                        listOms.Items.Add(PO_PR_no);

                        string query = "";
                        if (!chkPR.Checked)
                            query = "select '@msk' as msk, lph.oms, lph.lph, lph.date, lph.remark, sum(ind.val) as val, 0 as no " +
                                "from lph, ind where oms='@oms' and ind.jurnal=lph.lph and lph.lph not in (select msl.lph from msl,msk where msl.msk=msk.msk and msk.`delete`=0) group by ind.jurnal";
                        else
                            query = "select '@msk' as msk, lph.oms, lph.lph, lph.date, lph.remark, 0 as val, 0 as no " +
                                "from lph where oms='@oms' and lph.lph not in (select lph from msl) and lph.`delete`=0";

                        query = query.Replace("@msk", NoDocument);
                        query = query.Replace("@oms", PO_PR_no);
                        DataTable dtLph = DB.sql.Select(query);

                        //double total = 0;
                        foreach (DataRow lphRow in dtLph.Rows)
                        {
                            DataRow mslRow = casDataSet.msl.NewRow();
                            foreach (DataColumn mslCol in casDataSet.msl.Columns)
                            {
                                mslRow[mslCol.ColumnName] = lphRow[mslCol.ColumnName];
                            }
                            mslRow["val"] = (double)mslRow["val"] / (double)drResult["kurs"];
                            mslRow["no"] = casDataSet.msl.Rows.Count + 1;
                            casDataSet.msl.Rows.Add(mslRow);
                        }
                        gcxMsl.ExGridView.BestFitColumns();
                    }
                    if (casDataSet.msl.Rows.Count > 1)
                        FillMsdLpd();
                    else
                    {
                        DataRow msdRow = casDataSet.msd.NewRow();
                        msdRow["msk"] = NoDocument;
                        msdRow["oms"] = dtResult.Select("oms='" + PO_PR_no + "'")[0]["oms"];
                        msdRow["kurs"] = dtResult.Select("oms='" + PO_PR_no + "'")[0]["kurs"];
                        msdRow["dpp"] = dtResult.Select("oms='" + PO_PR_no + "'")[0]["val"];
                        msdRow["val"] = dtResult.Select("oms='" + PO_PR_no + "'")[0]["val"];
                        msdRow["no"] = casDataSet.msd.Rows.Count + 1;
                        curcur.EditValue = dtResult.Select("oms='" + PO_PR_no + "'")[0]["cur"];
                        curkurs.EditValue = dtResult.Select("oms='" + PO_PR_no + "'")[0]["kurs"];
                        casDataSet.msd.Rows.Add(msdRow);
                    }       
                }
                  
                   
                ReCalculateTotal();
                chkPR.Enabled = false;
            }

            RepositoryItemComboBox cboOms = (RepositoryItemComboBox)gcxMsd.ExGridView.Columns["oms"].ColumnEdit;
            cboOms.Items.Clear();
            cboOms.Items.AddRange(listOms.Items);
        }

        private void btnDeleteOms_Click(object sender, EventArgs e)
        {
            if (listOms.SelectedIndex < 0) return;

            // Remove POs from Invoice Tab
            DB.DeleteDetailRows(gcxMsd.ExGridView);

            // Remove Inventories from Penerimaan Barang
            DB.DeleteDetailRows(gcxLpd.ExGridView);

            DB.DeleteDetailRows(gcxMsl.ExGridView);

            if (listOms.Items.Count == 1)
                gcxMsx.ExGridView.SelectAll();
            DB.DeleteDetailRows(gcxMsx.ExGridView);

            int pos = listOms.SelectedIndex;
            listOms.SelectedIndex = -1;
            //listOms.Items.RemoveAt(listOms.SelectedIndex);
            listOms.Items.RemoveAt(pos);
            dtResult.Rows.Remove(dtResult.Rows[pos]);

            RepositoryItemComboBox cboOms = (RepositoryItemComboBox)gcxMsd.ExGridView.Columns["oms"].ColumnEdit;
            cboOms.Items.Clear();
            cboOms.Items.AddRange(listOms.Items);

            if (listOms.Items.Count == 0)
                chkPR.Enabled = true;
        }

        void gcxMsl_tsbtnDelete_Click(object sender, EventArgs e)
        {
            // Remove Inventories from Penerimaan Barang
            DB.DeleteDetailRows(gcxLpd.ExGridView);

            DB.DeleteDetailRows(gcxMsl.ExGridView);

            FillMsdLpd();
            ReCalculateTotal();
        }

        void gcxMsd_tsbtnDelete_Click(object sender, EventArgs e)
        {
            DB.DeleteDetailRows(gcxMsd.ExGridView);
        }

        void gcxMsx_tsbtnDelete_Click(object sender, EventArgs e)
        {
            DB.DeleteDetailRows(gcxMsx.ExGridView);
        }

        void gcxUmkp_tsbtnDelete_Click(object sender, EventArgs e)
        {
            DB.DeleteDetailRows(gcxUmkp.ExGridView);
        }

        private void txtSub_EditValueChanged(object sender, EventArgs e)
        {
        //    DataRow row = ctrlSub.txtSub.ExGetDataRow();

      //      if (row == null)
      //      {
      //          curcur.EditValue = "";
      //          return;
      //      }

      //      curcur.EditValue = row["cur"].ToString();
       //     spinTOP.EditValue = row["top"].ToString();

            if (MasterBindingSource.Position == MasterTable.Rows.Count)
                btnAddOms.PerformClick();
        }

        private void listOms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listOms.SelectedIndex >= 0)
            {
                string oms = listOms.SelectedItem.ToString();
                gcxMsl.UnselectAll();
                for (int i = 0; i < gcxMsl.ExGridView.RowCount; i++)
                {
                    if ((gcxMsl.ExGridView.GetDataRow(i) as DataRow)["oms"].ToString() == oms)
                    {
                        gcxMsl.ExGridView.SelectRow(i);
                    }
                }

                gcxMsd.UnselectAll();
                for (int i = 0; i < gcxMsd.ExGridView.RowCount; i++)
                {
                    if (gcxMsd.ExGridView.GetDataRow(i) == null) return;

                    if ((gcxMsd.ExGridView.GetDataRow(i) as DataRow)["oms"].ToString() == oms)
                        gcxMsd.ExGridView.SelectRow(i);
                }
            }
        }


        void gcxMsl_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            gcxLpd.UnselectAll();

            int[] selectedIndices = gcxMsl.ExGridView.GetSelectedRows();
            if (selectedIndices == null) return;

            for (int i = 0; i < selectedIndices.Length; i++)
            {
                string lph = (gcxMsl.ExGridView.GetDataRow(selectedIndices[i]) as DataRow)["lph"].ToString();
                for (int j = 0; j < gcxLpd.ExGridView.RowCount; j++)
                {
                    if ((gcxLpd.ExGridView.GetDataRow(j) as DataRow)["lph"].ToString() == lph)
                        gcxLpd.ExGridView.SelectRow(j);
                }
            }
        }

        void ReCalculateTotal()
        {
            DetailBindingSource.EndEdit();
            double subTotal = 0;
            txtPPH.EditValue = 0;
            double ppn = 0;
            for (int i = 0; i < DetailTable.Rows.Count; i++)
            {
                if (DetailTable.Rows[i] != null && DetailTable.Rows[i].RowState != DataRowState.Deleted)
                {
                    subTotal = subTotal + (double)DetailTable.Rows[i]["dpp"];
                    ppn = ppn + (double)DetailTable.Rows[i]["ppn"];
                }
            }
            txtSubTotal.EditValue = subTotal;
            txtPPN.EditValue = ppn;

            // Collect Uang Muka
            umkpBindingSource.EndEdit();
            double uangMuka = 0;
            for (int i = 0; i < casDataSet.umkp.Rows.Count; i++)
            {
                if (casDataSet.umkp.Rows[i] != null && casDataSet.umkp.Rows[i].RowState != DataRowState.Deleted)
                {
                    uangMuka = uangMuka + (double)casDataSet.umkp.Rows[i]["val"];
                }
            }
            txtUangMuka.EditValue = uangMuka;

            double total = subTotal + ppn - uangMuka;
            txtTotal.EditValue = total;

            msxBindingSource.EndEdit();
            double pph = 0;
            for (int i = 0; i < casDataSet.msx.Rows.Count; i++)
            {
                if (casDataSet.msx.Rows[i] != null && casDataSet.msx.Rows[i].RowState != DataRowState.Deleted)
                {
                    if (casDataSet.msx.Rows[i]["pph23"].ToString() != "")
                        pph = pph + (double)casDataSet.msx.Rows[i]["pph23"];
                    if (casDataSet.msx.Rows[i]["pph4ay2"].ToString() != "")
                        pph = pph + (double)casDataSet.msx.Rows[i]["pph4ay2"];
                    if (casDataSet.msx.Rows[i]["pph15"].ToString() != "")
                        pph = pph + (double)casDataSet.msx.Rows[i]["pph15"];

                }
            }
            txtPPH.EditValue = pph;
            txtUangMuka.EditValue = uangMuka;
            total = subTotal + ppn - uangMuka - pph;
            txtTotal.EditValue = total;
            txtSubTotal.EditValue = subTotal;
            txtPPN.EditValue = ppn;
        }

        void CloseValPO()
        {
            foreach (DataRow row in casDataSet.msd)
            {
                //string query = "select * from lph where oms='" +
                //    row["oms"].ToString() + "' and lph not in " +
                //    "(select lph from msl where oms='" +  row["oms"].ToString() + "')";
                string query = "Call SP_OutSpb('" + row["oms"].ToString() + "')";
                DataTable dt = DB.sql.Select(query);
                if (dt.Rows.Count == 0)
                    DB.sql.Execute("update oms set closedval=1 where oms='" + row["oms"].ToString() + "' and close=1");
            }
        }

        protected override void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            base.tsbtnRefresh_Click(sender, e);
            PopulateDetails();
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate controls
                this.ValidateChildren();

                if (gcxMsd.ExGridView.EditingValue != null)
                    gcxMsd.ExGridView.SetFocusedValue(gcxMsd.ExGridView.EditingValue);

                if (gcxUmkp.ExGridView.EditingValue != null)
                    gcxUmkp.ExGridView.SetFocusedValue(gcxUmkp.ExGridView.EditingValue);

                if (gcxMsx.ExGridView.EditingValue != null)
                    gcxMsx.ExGridView.SetFocusedValue(gcxMsx.ExGridView.EditingValue);

                ((DataRowView)MasterBindingSource.Current).Row["duedate"] = ((DateTime)dateDate.EditValue).AddDays(Convert.ToDouble(spinTOP.EditValue));
                ((DataRowView)MasterBindingSource.Current).Row["group_"] = '2';
                
                // delete msd
               // DB.sql.Execute("Delete from msd where msk='" + NoDocument + "'");
                //loop DetailTable
                foreach (DataRow dr in DetailTable.Rows)
                {
                    if (dr.RowState == DataRowState.Added)
                        DB.sql.Execute("Delete from msd where msk='" + NoDocument + "'");
                    if (dr.RowState != DataRowState.Deleted && dr != null)
                    {
                        if (dr["invo"].ToString() == "")
                            throw new Exception("Harap mengisi no invoice");
                        if ((double)dr["ppn"] > 0 && dr["nofp"].ToString() != "" && dr["tglfp"].ToString() == "")
                            throw new Exception("Harap mengisi tanggal FP");
                        if ((double)dr["ppn"] > 0 && dr["nofp"].ToString() == "")
                            throw new Exception("Harap mengisi nomor Faktur Pajak");
                    }
                }

                //if ((double)txtTotal.EditValue == 0)
                //    throw new Exception("Invoice Value is 0");

                base.tsbtnSave_Click(sender, e);

                mslBindingSource.EndEdit();
                mslAdapter.Update(casDataSet.msl);
                msdBindingSource.EndEdit();
                msdAdapter.Update(casDataSet.msd);
                msxBindingSource.EndEdit();
                msxAdapter.Update(casDataSet.msx);
                umkpBindingSource.EndEdit();
                umkpAdapter.Update(casDataSet.umkp);

                string date = ((DateTime)(dateDate.EditValue)).ToString("yyyyMMdd");
                DB.sql.Execute("Call SP_Save(" + date + ",'MSK'" + ",'" + NoDocument + "')");

                //cek close val PO
                CloseValPO();

                btnAddOms.Enabled = false;
                btnDeleteOms.Enabled = false;

                // disable all GridControls
                gcxMsd.ExGridView.OptionsBehavior.Editable = false;
                gcxMsd.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;

                gcxMsx.ExGridView.OptionsBehavior.Editable = false;
                gcxMsx.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;

                gcxUmkp.ExGridView.OptionsBehavior.Editable = false;
                gcxUmkp.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;

                SetMode(Mode.View);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected override void tsbtnCancel_Click(object sender, EventArgs e)
        {
            casDataSet.msl.RejectChanges();
            casDataSet.lpd.RejectChanges();
            casDataSet.msx.RejectChanges();
            casDataSet.umkp.RejectChanges();
            base.tsbtnCancel_Click(sender, e);
            if (this.mode == Mode.View)
            {
                RePopulate_List_Cbo_Oms();
                btnAddOms.Enabled = false;
                btnDeleteOms.Enabled = false;
                ReCalculateTotal();

                // disable all GridControls
                gcxMsd.ExGridView.OptionsBehavior.Editable = false;
                gcxMsd.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;

                gcxMsx.ExGridView.OptionsBehavior.Editable = false;
                gcxMsx.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;

                gcxUmkp.ExGridView.OptionsBehavior.Editable = false;
                gcxUmkp.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;

                SetMode(Mode.View);
            }
        }

        private void txtNo_EditValueChanged(object sender, EventArgs e)
        {
            //ReCalculateTotal();            
        }

            private void tabDetails_Click(object sender, EventArgs e)
        {
            msdBindingSource.EndEdit();
            Cinvo.Items.Clear();
            for (int i = 0; i < casDataSet.msd.Rows.Count; i++)
            {
                if (casDataSet.msd.Rows[i]["invo"] != null)
                {
                    string invc = (string)DetailTable.Rows[i]["invo"];
                    Cinvo.Items.Add(invc);
                }
            }
        }
    }
}

