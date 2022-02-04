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

namespace CAS.Transaction
{
    public partial class FrmTKBM : CAS.Transaction.BaseTransaction
    {
        public FrmTKBM()
        {
            InitializeComponent();
            DetailTable.Columns.Add("Nama", typeof(String));
            MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);

            Utility.SetSqlInstance(pnlDetail, DB.sql);
            gcKBM.ExGridControl.DataSource = kadBindingSource;
            
            gcKBM.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
            gcKBM.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
            gcKBM.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gcKBM.ExToolStrip.Items["tsbtnNew"].Enabled = false;
            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            //tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
            //tsbtnDelete.Click += new EventHandler(tsbtnDelete_Click);
     
            gcKBM.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
            gcKBM.ExGridView.CellValueChanged += new CellValueChangedEventHandler(ExGridView_CellValueChanged);

            gcKBM.ExGridView.Columns["kas"].Visible = false;
            gcKBM.ExGridView.Columns["no"].Visible = false;
            gcKBM.ExGridView.Columns["group_"].Visible = false;
            gcKBM.ExGridView.Columns["est"].Visible = false;
            gcKBM.ExGridView.Columns["jurnal"].Visible = true;
            gcKBM.ExGridView.Columns["invoice"].Visible = false;
            gcKBM.ExGridView.Columns["rfp"].Visible = false;
            gcKBM.ExGridView.Columns["okl"].Visible = false;
            
            RepositoryItemComboBox cboDK = new RepositoryItemComboBox();
            cboDK.Items.AddRange(new string[] { "D", "K" });
            cboDK.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;

            gcKBM.ExGridView.Columns["cct"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('cct')", "cct", "cct", gcKBM.ExGridView, "", true, true, "Cost Center");
            gcKBM.ExGridView.Columns["acc"].ColumnEdit = new GridLookUpEx(DB.sql, "select acc as `Kode Akun`, name as `Nama Rekening` from acc where detil=1", "acc", "acc", gcKBM.ExGridView, "", true, true, "Account");
            gcKBM.ExGridView.Columns["dk"].ColumnEdit = cboDK;
            gcKBM.ExGridView.Columns["jurnal"].ColumnEdit = new GridLookUpEx(DB.sql, "call SP_OutRhp('" + txtCustomer.Text + "','" + txtCustomer.Text + "'," + Utility.FirstDateInMonth(dateDate.DateTime).ToString("yyyyMMdd") + "," + ((DateTime)dateDate.EditValue).AddDays(1).ToString("yyyyMMdd") + ",'" + ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text + "','1')", "rhp", "jurnal", gcKBM.ExGridView, "", true, true, "Detail Transaksi");
            gcKBM.ExGridView.Columns["jurnal"].ColumnEdit.Enter += new EventHandler(ExGridView_jurnalColumnEdit_Enter);

            gcKBM.ExTitleLabel.Text = "Detail Kas/Bank Masuk";
            gcKBM.ExGridView.Columns["jurnal"].Caption = "Jurnal";
            gcKBM.ExGridView.Columns["cct"].Caption = "Cost Center";
            gcKBM.ExGridView.Columns["kode"].Caption = "Kd. Transaksi";
            gcKBM.ExGridView.Columns["acc"].Caption = "No. Rekening";
            gcKBM.ExGridView.Columns["remark"].Caption = "Keterangan";
            gcKBM.ExGridView.Columns["dk"].Caption = "D/K";
            gcKBM.ExGridView.Columns["val"].Caption = "Nilai";
            gcKBM.ExGridView.Columns["val"].ColumnEdit = new GridNumEx();
            gcKBM.ExGridView.Columns["invoice"].Caption = "No. Order";
            gcKBM.ExGridView.Columns["Nama"].Caption = "Nama Rekening";

            gcKBM.ExGridView.Columns["cct"].VisibleIndex = 1;
            gcKBM.ExGridView.Columns["kode"].VisibleIndex = 2;
            gcKBM.ExGridView.Columns["acc"].VisibleIndex = 3;
            gcKBM.ExGridView.Columns["Nama"].VisibleIndex = 4;
            gcKBM.ExGridView.Columns["remark"].VisibleIndex = 5;
            gcKBM.ExGridView.Columns["dk"].VisibleIndex = 6;
            gcKBM.ExGridView.Columns["val"].VisibleIndex = 7;
            gcKBM.ExGridView.BestFitColumns();

            gcKBM.ExGridView.OptionsBehavior.Editable = false;
            gcKBM.ExGridView.OptionsSelection.MultiSelect = true;
            gcKBM.ExGridView.OptionsCustomization.AllowSort = false;
            gcKBM.ExGridView.OptionsView.ShowGroupPanel = false;
            gcKBM.ExGridView.Columns["Nama"].OptionsColumn.AllowEdit = false;

            DB.SetNumberFormat(gcKBM.ExGridView, "n2");
            tsbtnPrint.Click += new EventHandler(tsbtnPrint_Click);

            spinEditNilaiKasBank.Properties.MinValue = 0;
            spinEditNilaiKasBank.Properties.MaxValue = Decimal.MaxValue;
            //spinEditNilaiKasBank.Properties.DisplayFormat = ;
        }
        
        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DetailTable = DB.PopulateNamaRekening(DetailTable, "Nama");
            CalculateTotal();
        }

        void ExGridView_jurnalColumnEdit_Enter(object sender, EventArgs e)
        {
            string query = "call SP_OutRhp('" + txtCustomer.Text + "','" + txtCustomer.Text + "'," + Utility.FirstDateInMonth(dateDate.DateTime).ToString("yyyyMMdd") + "," + ((DateTime)dateDate.EditValue).AddDays(1).ToString("yyyyMMdd") + ",'" + ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text + "','1')";
            ((GridLookUpEx)gcKBM.ExGridView.Columns["jurnal"].ColumnEdit).Query = query;
        }

        private void FrmTKBM_Load(object sender, EventArgs e)
        {
            DetailTable=DB.PopulateNamaRekening(DetailTable,"Nama");
            Utility.SetNumberFormat(pnlTotal, "n2");
            //Utility.SetNumberFormat(textEditAkumulasi, "n2");
            Utility.SetNumberFormat(spinEditNilaiKasBank, "n2");
            CalculateTotal();
            // TODO: This line of code loads data into the 'casDataSet.kad' table. You can move, or remove it, as needed.
            //this.kadTableAdapter.Fill(this.casDataSet.kad);
            // TODO: This line of code loads data into the 'casDataSet.kas' table. You can move, or remove it, as needed.
            //this.kasTableAdapter.Fill(this.casDataSet.kas);

        }
        
        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gcKBM.ExGridView.GetDataRow(e.RowHandle);
            row["kas"] = NoDocument;
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            row["dk"] = "K";
            row["remark"] = this.remarkTextBox.Text; 
        }

        void ExGridView_Delete_Click(object sender, EventArgs e)
        {
            DB.DeleteDetailRows(gcKBM.ExGridView);
        }

        protected override void tsbtnDelete_Click(object sender, EventArgs e)
        {
            base.tsbtnDelete_Click(sender, new EventArgs());
            if (Convert.ToInt32(MasterTable.Rows[MasterBindingSource.Position]["delete"]) == 1)
                DB.sql.Execute("Call SP_Delete('KBM','" + NoDocument + "')");
        }

        void ExGridView_New_Click(object sender, EventArgs e)
        {
            DataRow row = casDataSet.kad.NewRow();
            row["kas"] = NoDocument;
            row["val"] = 0;
            row["jurnal"] = "";
            row["remark"] = "";
            row["dk"] = "";
            row["acc"] = "";
            row["cct"] = "";
            row["group_"] = "1";
            row["kode"] = "";
            row["est"] = 0;
            row["invoice"] = "";
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            casDataSet.kad.Rows.Add(row);

            DB.InsertDetailRows(gcKBM.ExGridView, row);
        }

        void tsbtnPrint_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "BKM" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('Transaction.FrmTKBM','" + this.NoDocument + "')");
            report.DataSource = dt;
            //if data found, show terbilang
            string terbilang = "";
            if (dt.Rows.Count > 0)
            {
                try
                {
                    if (curcur.Text == "IDR")
                        //terbilang = Utility.NumberToText(Convert.ToDouble(textEditAkumulasi.Text));
                        terbilang = Utility.NumberToText(Convert.ToDouble(spinEditNilaiKasBank.EditValue));
                    else if (curcur.Text == "USD")
                        //terbilang = Utility.NumberToTextEN(Convert.ToInt32(textEditAkumulasi.Text));
                        terbilang = Utility.NumberToTextEN(Convert.ToInt32(spinEditNilaiKasBank.EditValue));
                }
                catch { }
            }
            //report.Bands[BandKind.PageHeader].Controls[0].Controls[0].Controls[1].Text = "BUKTI KAS KECIL MASUK";
            //report.Bands[BandKind.PageHeader].Controls[0].Controls[2].Controls[1].Text = terbilang;
            //DataTable bg = DB.sql.Select("select kag.* from kag, kas where kag.kas='" + this.NoDocument + "' and kag.kas=kas.kas and kas.`delete`=0");
            //if (bg.Rows.Count > 0)
            //{
            //    report.Bands[BandKind.ReportFooter].Controls["xrTableCellGiroCek"].Text = bg.Rows[0]["nobg"].ToString();
            //    report.Bands[BandKind.ReportFooter].Controls["xrTableCellJTP"].Text = Convert.ToDateTime(bg.Rows[0]["duedate"]).ToString("dd/MM/yyyy");
            //}

            report.PaperName = "1/2A4";
            report.ShowPreview();
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            gcKBM.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcKBM.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcKBM.ExGridView.OptionsBehavior.Editable = true;
            gcKBM.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
        }

        protected override void tsbtnCancel_Click(object sender, EventArgs e)
        {
            DB.CancelDetailRows(DetailTable);

            base.tsbtnCancel_Click(sender, new EventArgs());

            if (this.mode == Mode.View)
            {
                gcKBM.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                gcKBM.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                gcKBM.ExGridView.OptionsBehavior.Editable = false;
                gcKBM.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;

                DetailTable = DB.PopulateNamaRekening(DetailTable, "Nama");
                CalculateTotal();
            }
        }
        
        protected override void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            base.tsbtnRefresh_Click(sender, new EventArgs());
            DetailTable=DB.PopulateNamaRekening(DetailTable,"Nama");
            CalculateTotal();
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            curcur.Text = "IDR";
            curkurs.EditValue = 1;
            DetailTable.Clear();
            CalculateTotal();
            gcKBM.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcKBM.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcKBM.ExGridView.OptionsBehavior.Editable = true;
            gcKBM.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
        }

        void ExGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "cct")
            {
                DetailBindingSource.EndEdit();
                //string query = "Call SP_LookUpCcaAcc('" + (string)gcKBK.ExGridView.GetFocusedRowCellValue("cct") + "')";
                gcKBM.ExGridView.SetFocusedRowCellValue(gcKBM.ExGridView.Columns["kode"], "");
                gcKBM.ExGridView.SetFocusedRowCellValue(gcKBM.ExGridView.Columns["acc"], "");
                gcKBM.ExGridView.SetFocusedRowCellValue(gcKBM.ExGridView.Columns["Nama"], "");
                gcKBM.ExGridView.Columns["kode"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUpCcaAcc('" + (string)gcKBM.ExGridView.GetFocusedRowCellValue("cct")+ "')", "cct", "cct", gcKBM.ExGridView, "", true, true, "Kd. Transaksi");
                return;
            }
            if (e.Column.FieldName == "val" || e.Column.FieldName == "dk")
            {
                CalculateTotal();
            }

        }
        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate controls
                this.ValidateChildren();

                DetailBindingSource.EndEdit();
                CalculateTotal();
                if (textBoxEx1.Text == "" && spinEditNilaiKasBank.Value != 0)
                {
                    MessageBox.Show("Invalid Account Header Name. Please correct the value");
                    return;
                }

                for (int i = DetailTable.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = DetailTable.Rows[i];
                    if (row != null && row.RowState != DataRowState.Deleted)
                    {
                        row[0] = NoDocument;
                        if (row["acc"].ToString().Trim() == "")
                        {
                            MessageBox.Show("Invalid Account Name. Please correct the value");
                            return;
                        }
                    }
                }
                //if ((double)textEditAkumulasi.EditValue < 0 )
                //{
                //    MessageBox.Show("Value For Credit Must be Higher");
                //    return;
                //}
                ((DataRowView)MasterBindingSource.Current).Row["group_"] = 4;
                base.tsbtnSave_Click(sender, e);
                string date = ((DateTime)(dateDate.EditValue)).ToString("yyyyMMdd");
                string jurnal = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
                DB.sql.Execute("Call SP_Save(" + date + ",'KBM'" + ",'" + jurnal + "')");

                if (this.mode == Mode.View)
                {
                    gcKBM.ExGridView.OptionsBehavior.Editable = false;
                    gcKBM.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                    gcKBM.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                    gcKBM.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void CalculateTotal()
        { 
            DetailBindingSource.EndEdit();

            double debet = 0;
            double kredit = 0;
            for (int i = 0; i < DetailTable.Rows.Count; i++)
            {
                if (DetailTable.Rows[i]["dk"] != System.DBNull.Value && DetailTable.Rows[i]["val"] != System.DBNull.Value && DetailTable.Rows[i] != null && DetailTable.Rows[i].RowState != DataRowState.Deleted)
                {
                    if ((string)DetailTable.Rows[i]["dk"] == "D")
                    {
                        debet = debet + (double)DetailTable.Rows[i]["val"];
                    }
                    else
                    {
                        kredit = kredit + (double)DetailTable.Rows[i]["val"];
                    }
                }
            }
            textEditDebet.EditValue = debet;
            textEditKredit.EditValue = kredit;
            //textEditAkumulasi.EditValue = kredit -debet;
            spinEditNilaiKasBank.EditValue = kredit - debet;
        }
    }
}
