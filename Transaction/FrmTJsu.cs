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
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraReports.UI;
using MySql.Data.MySqlClient;

namespace CAS.Transaction
{
    public partial class FrmTJsu : BaseTransaction
    {
        public FrmTJsu()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlDetail, DB.sql);
            ToolStripMenuItem tsmiPrintPreview = new ToolStripMenuItem("Preview Jurnal Memo", null, new EventHandler(tsmiPrintPreview_Click));
            ToolStripMenuItem tsmiPrintDirectly = new ToolStripMenuItem("Print Jurnal Memo", null, new EventHandler(tsmiPrintDirectly_Click));
             ToolStripSeparator tsSeparator1 = new ToolStripSeparator();
            ToolStripMenuItem tsmiPreviewCN = new ToolStripMenuItem("Preview Credit Note", null, new EventHandler(tsmiPreviewCN_Click));
            ToolStripMenuItem tsmiPrintCN = new ToolStripMenuItem("Print Credit Note", null, new EventHandler(tsmiPrintCN_Click));

            ToolStripDropDownButton tsbtnPrint = new ToolStripDropDownButton("Print", null, tsmiPrintPreview, tsmiPrintDirectly, tsSeparator1, tsmiPreviewCN, tsmiPrintCN);
            tsbtnPrint.Image = MasterNavigator.Items["tsbtnPrint"].Image;
            MasterNavigator.Items.Insert(MasterNavigator.Items.IndexOfKey("tsbtnPrint"), tsbtnPrint);
            MasterNavigator.Items.RemoveByKey("tsbtnPrint");

            gcJsd.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
        
            MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);

            InitializeGridControl();

  
            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);

        }

        private void FrmTJsu_Load(object sender, EventArgs e)
        {
            spinTOP.Properties.MinValue = 0;
            spinTOP.Properties.MaxValue = Int32.MaxValue;

            ctrlSub.txtSub.DataBindings.Add("EditValue", jsuBindingSource, "sub");
            ctrlSub.txtSub.EditValueChanged += new EventHandler(subTextBoxEx_EditValueChanged);

            gcJsd.ExGridView.BestFitColumns();
            Utility.SetNumberFormat(pnlTotal, "n2");
            ReCalculateTotal();

            if (MasterBindingSource.Position == MasterTable.Rows.Count)
            {
                sspdateDateEdit.DateTime = DateTime.Today;
                fakdateDateEdit.DateTime = DateTime.Today;
            }
        }

        void tsmiPrintDirectly_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepMemoDebetKredit" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_PrintInvoice('Transaction.FrmTJsu','" + this.NoDocument + "')");
            report.PrintingSystem.ShowMarginsWarning = false;
            report.PaperName = "1/2A4";
            report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
            report.Print();
        }

        void tsmiPrintPreview_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepMemoDebetKredit" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_PrintInvoice('Transaction.FrmTJsu','" + this.NoDocument + "')");
            //report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
            report.ShowPreview();
        }

        public static string terbilang(object spin, string kurs)
        {
            string result = "";
            if (kurs == "IDR")
            {
                double angka = Convert.ToDouble(spin);
                double depankoma = Math.Floor(angka);
                double belakangkoma = Math.Round((angka - depankoma), 2) * 100;
                result = Utility.NumberToText(depankoma);
                int blakangkoma = Convert.ToInt32(belakangkoma);
                string blakangkoma1 = Math.Round((double)spin, 2).ToString().Substring(spin.ToString().IndexOf(',') + 1);
                if (blakangkoma > 0)
                    result += "koma " + Utility.NumberToTextPecahan(blakangkoma1) + " Rupiah";
                else
                    result += " Rupiah";
            }
            else if (kurs == "USD")
            {
                double angka = Convert.ToDouble(spin);
                int depankoma = Convert.ToInt32(Math.Floor(angka));
                int belakangkoma = Convert.ToInt32(Math.Round((angka - depankoma), 2) * 100);
                result = Utility.NumberToTextEN(depankoma);
                if (belakangkoma > 0)
                    result += "point " + Utility.NumberToTextEN(belakangkoma) + "Cent USD";
                else
                    result += " USD";
            }
            return result;
        }

        void tsmiPrintCN_Click(object sender, EventArgs e)
        {
            string terbilangnya = terbilang(Convert.ToDouble(valSpinEdit.Text), curcur.Text);
            string path = Application.StartupPath + "\\Reports\\" + "RepCreditMemo" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_Print('Transaction.FrmTMemo','" + this.NoDocument + "')");
            report.PrintingSystem.ShowMarginsWarning = false;
            report.PaperName = "1/2A4";
            report.Bands[BandKind.GroupFooter].Controls["xrTerbilang"].Text = Utility.ToTitleCase(terbilangnya).Trim();
            report.Print();
        }

        void tsmiPreviewCN_Click(object sender, EventArgs e)
        {
            string terbilangnya = terbilang(Convert.ToDouble(valSpinEdit.Text), curcur.Text);
            string path = Application.StartupPath + "\\Reports\\" + "RepCreditMemo" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_Print('Transaction.FrmTMemo','" + this.NoDocument + "')");
            report.Bands[BandKind.GroupFooter].Controls["xrTerbilang"].Text = Utility.ToTitleCase(terbilangnya).Trim() ;
            report.PaperName = "1/2A4";
            report.ShowPreview();
        }
        void ExGridView_Delete_Click(object sender, EventArgs e)
        {
            DB.DeleteDetailRows(gcJsd.ExGridView);
            ReCalculateTotal();
        }
        private void InitializeGridControl()
        {
            gcJsd.ExGridControl.DataSource = jsdBindingSource;
            gcJsd.ExTitleLabel.Text = "Jurnal Memo Detail";

            gcJsd.ExGridView.OptionsBehavior.Editable = false;
            gcJsd.ExGridView.OptionsSelection.MultiSelect = true;
            gcJsd.ExGridView.OptionsCustomization.AllowSort = false;
            gcJsd.ExGridView.OptionsView.ShowGroupPanel = false;

            gcJsd.ExGridView.Columns["okl"].Caption = "No SO";
            gcJsd.ExGridView.Columns["cad"].Caption = "No Cadangan";
            gcJsd.ExGridView.Columns["acc"].Caption = "Kode Akun";
            gcJsd.ExGridView.Columns["cct"].Caption = "Cost Center";
            gcJsd.ExGridView.Columns["remark"].Caption = "Keterangan";
            gcJsd.ExGridView.Columns["dk"].Caption = "D/K";
            gcJsd.ExGridView.Columns["val"].Caption = "Nilai";
            gcJsd.ExGridView.Columns["invoice"].Caption = "Invoice";

            gcJsd.ExGridView.Columns["jsu"].Visible = false;
            gcJsd.ExGridView.Columns["no"].Visible = false;
            gcJsd.ExGridView.Columns["cad"].Visible = false;

            gcJsd.ExGridView.Columns["acc"].ColumnEdit = new GridLookUpEx(DB.sql, "select acc as `Kode Akun`, name as `Nama Rekening` from acc where detil=1", "acc", "acc", gcJsd.ExGridView, "", true, true, "Account");
            gcJsd.ExGridView.Columns["cct"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('cct')", "cct", "cct", gcJsd.ExGridView, "", true, true, "Cost Center");
            gcJsd.ExGridView.Columns["ino"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('ino')", "ino", "ino", gcJsd.ExGridView, "", true, false, "Internal Order");
            gcJsd.ExGridView.Columns["ino"].ColumnEdit.Enter += new EventHandler(ExGridView_inoColumnEdit_Enter);
            gcJsd.ExGridView.Columns["okl"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('oklmsk')", "okl", "okl", gcJsd.ExGridView, "", true, false, "Nomor SO");
            gcJsd.ExGridView.Columns["okl"].ColumnEdit.Enter += new EventHandler(ExGridView_oklColumnEdit_Enter);

            gcJsd.ExGridView.Columns["val"].ColumnEdit = new GridNumEx();
            //gcJsd.ExGridView.Columns["val"]

            RepositoryItemComboBox cboDK = new RepositoryItemComboBox();
            cboDK.Items.AddRange(new string[] { "D", "K" });
            cboDK.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            gcJsd.ExGridView.Columns["dk"].ColumnEdit = cboDK;

            gcJsd.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
            gcJsd.ExGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(ExGridView_CellValueChanged);

            gcJsd.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
            gcJsd.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gcJsd.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
            gcJsd.ExToolStrip.Items["tsbtnNew"].Enabled = false;

            gcJsd.ExGridView.BestFitColumns();
            gcJsd.ExGridView.Columns["okl"].VisibleIndex = 0;
            gcJsd.ExGridView.Columns["cad"].VisibleIndex = 0;
            gcJsd.ExGridView.Columns["ino"].VisibleIndex = 1;
            gcJsd.ExGridView.Columns["acc"].VisibleIndex = 2;
            gcJsd.ExGridView.Columns["cct"].VisibleIndex = 4;
            gcJsd.ExGridView.Columns["remark"].VisibleIndex = 3;
            gcJsd.ExGridView.Columns["dk"].VisibleIndex = 5;
            gcJsd.ExGridView.Columns["val"].VisibleIndex = 6;
            DB.SetNumberFormat(gcJsd.ExGridView, "n2");
        }

        void ExGridView_oklColumnEdit_Enter(object sender, EventArgs e)
        {
            string sub = ctrlSub.txtSub.EditValue.ToString(); 
            string query = "Call SP_LookUp('oklmsk" +sub+"')";
            ((GridLookUpEx)gcJsd.ExGridView.Columns["okl"].ColumnEdit).Query = query;
        }

        void ExGridView_inoColumnEdit_Enter(object sender, EventArgs e)
        {
            //string query = "Call SP_LookUp('ino')";
            //((GridLookUpEx)gcJsd.ExGridView.Columns["ino"].ColumnEdit).Query = query;
        }

        void ExGridView_New_Click(object sender, EventArgs e)
        {
            DataRow row = casDataSet.jsd.NewRow();
            row["jsu"] = NoDocument;
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            row["dk"] = (jenisRadioGroup.SelectedIndex == 0) ? "K" : "D";
            casDataSet.jsd.Rows.Add(row);

            DB.InsertDetailRows(gcJsd.ExGridView, row);
        }

        void ExGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "val" || e.Column.FieldName == "dk")
            {
                ReCalculateTotal();
            }
        }

        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gcJsd.ExGridView.GetDataRow(e.RowHandle);
            row["jsu"] = NoDocument;
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            row["dk"] = (jenisRadioGroup.SelectedIndex == 0) ? "K" : "D";
        }

        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (MasterBindingSource.Position != MasterTable.Rows.Count)
            {
                DateTime dueDate = (DateTime)MasterTable.Rows[MasterBindingSource.Position]["duedate"];
                DateTime date = (DateTime)MasterTable.Rows[MasterBindingSource.Position]["date"];
                spinTOP.EditValue = ((TimeSpan)dueDate.Subtract(date)).TotalDays;
                ReCalculateTotal();
            }
        }

        private void ReCalculateTotal()
        {
            DetailBindingSource.EndEdit();

            double debet = 0, kredit = 0;

            if (jenisRadioGroup.SelectedIndex == 0) // Debet
                debet = Convert.ToDouble(valSpinEdit.EditValue);
            else
                kredit = Convert.ToDouble(valSpinEdit.EditValue);

            for (int i = 0; i < DetailTable.Rows.Count; i++)
            {
                if (DetailTable.Rows[i] != null && DetailTable.Rows[i].RowState != DataRowState.Deleted)
                {
                    if (DetailTable.Rows[i]["dk"].ToString() == "D")
                        debet += (double)DetailTable.Rows[i]["val"];
                    else
                        kredit += (double)DetailTable.Rows[i]["val"];
                }
            }

            txtDebet.EditValue = debet;
            txtKredit.EditValue = kredit;

            txtDiff.EditValue = debet - kredit;
        }

        private void subTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {
            DataRow row = ctrlSub.txtSub.ExGetDataRow();
            //if (row == null)
            //{
            //    curcur.EditValue = "";
            //    return;
            //}
            //curcur.EditValue = row["cur"].ToString();
           // spinTOP.EditValue = row["top"].ToString();
            //if (row["Kode"].ToString().StartsWith("1")) // Customer
            //    jenisRadioGroup.SelectedIndex = 0; // Debet
            //else // Supplier
            //    jenisRadioGroup.SelectedIndex = 1; // Kredit
        }


        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            gcJsd.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcJsd.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcJsd.ExGridView.OptionsBehavior.Editable = true;
            gcJsd.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
        //    curcur.Properties.ReadOnly = true;
            ctrlSub.ReadOnly = false;
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            DetailTable.Clear();
            sspdateDateEdit.EditValue = DateTime.Now;
            fakdateDateEdit.EditValue = DateTime.Now;
            gcJsd.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcJsd.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcJsd.ExGridView.OptionsBehavior.Editable = true;
            gcJsd.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            jenisRadioGroup.EditValue = "D";
            ReCalculateTotal();
            ctrlSub.ReadOnly = false;
        }

        protected override void tsbtnCancel_Click(object sender, EventArgs e)
        {
            DB.CancelDetailRows(DetailTable);

            base.tsbtnCancel_Click(sender, new EventArgs());

            if (this.mode == Mode.View)
            {
                ReCalculateTotal();

                gcJsd.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                gcJsd.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                gcJsd.ExGridView.OptionsBehavior.Editable = false;
                gcJsd.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;

                ctrlSub.ReadOnly = true;
            }
        }

        protected override void tsbtnDelete_Click(object sender, EventArgs e)
        {
            base.tsbtnDelete_Click(sender, e);
            if (Convert.ToInt32(MasterTable.Rows[MasterBindingSource.Position]["delete"]) == 1)
                DB.sql.Execute("Call SP_Delete('MMO'" + ",'" + NoDocument + "')");
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidateChildren();

                ((DataRowView)MasterBindingSource.Current).Row["duedate"] = ((DateTime)dateDate.EditValue).AddDays(Convert.ToDouble(spinTOP.EditValue));
                ((DataRowView)MasterBindingSource.Current).Row["dk"] = jenisRadioGroup.EditValue;

                ReCalculateTotal();

                for (int i = 0; i < DetailTable.Rows.Count; i++)
                {
                    if (DetailTable.Rows[i] != null && DetailTable.Rows[i].RowState != DataRowState.Deleted)
                    {
                      if (DetailTable.Rows[i]["acc"].ToString().Substring(0,4)  == "2107")
                           if (DetailTable.Rows[i]["okl"].ToString().Trim()  == "")
                               throw new Exception("Akun Uang Muka harus mengisi Nomor Order !");
                    }
                }

                if (Math.Round((double)txtDiff.EditValue,2) != 0)
                    throw new Exception("Selisih Debet dan Kredit harus 0!");

                base.tsbtnSave_Click(sender, e);

                DB.sql.Execute("Call SP_Save(" + dateDate.DateTime.ToString("yyyyMMdd") + ",'MMO'" + ",'" + NoDocument + "')");
             
                gcJsd.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                gcJsd.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                gcJsd.ExGridView.OptionsBehavior.Editable = false;
                gcJsd.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;

                ctrlSub.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void valSpinEdit_EditValueChanged(object sender, EventArgs e)
        {
            ReCalculateTotal();
        }

        private void jenisRadioGroup_EditValueChanged(object sender, EventArgs e)
        {
            ReCalculateTotal();
        }

        private void curcur_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}