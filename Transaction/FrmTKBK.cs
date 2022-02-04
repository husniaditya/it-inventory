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
    public partial class FrmTKBK : CAS.Transaction.BaseTransaction
    {
        string Querynyax;
        public FrmTKBK()
        {
            InitializeComponent();
            DetailTable.Columns.Add("Nama", typeof(String));
            DetailTable.Columns.Add("debet", typeof(String));
            MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);
           
            Utility.SetSqlInstance(pnlDetail, DB.sql);
            gcKBK.ExGridControl.DataSource = kadBindingSource;
            
            gcKBK.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
            gcKBK.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
            gcKBK.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gcKBK.ExToolStrip.Items["tsbtnNew"].Enabled = false;
            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            //tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
            //tsbtnDelete.Click += new EventHandler(tsbtnDelete_Click);

            gcKBK.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
            gcKBK.ExGridView.CellValueChanged += new CellValueChangedEventHandler(ExGridView_CellValueChanged);

            
            gcKBK.ExGridView.Columns["kas"].Visible = false;
            gcKBK.ExGridView.Columns["no"].Visible = false;
            gcKBK.ExGridView.Columns["debet"].Visible = false;
            gcKBK.ExGridView.Columns["group_"].Visible = false;
            gcKBK.ExGridView.Columns["est"].Visible = false;
            gcKBK.ExGridView.Columns["okl"].Visible = false;
            //gcKBK.ExGridView.Columns["jurnal"].Visible = true;
        //    gcKBK.ExGridView.Columns["invoice"].Visible = false;
            //gcKBK.ExGridView.Columns["rfp"].Visible = true;
            
            RepositoryItemComboBox cboDK = new RepositoryItemComboBox();
            cboDK.Items.AddRange(new string[] { "D", "K" });
            cboDK.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;

            gcKBK.ExGridView.Columns["cct"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('cct')", "cct", "cct", gcKBK.ExGridView, "", true, true, "Cost Center");
            gcKBK.ExGridView.Columns["acc"].ColumnEdit = new GridLookUpEx(DB.sql, "select acc as `Kode Akun`, name as `Nama Rekening` from acc where detil=1", "acc", "acc", gcKBK.ExGridView, "", true, true, "Account");
            gcKBK.ExGridView.Columns["dk"].ColumnEdit = cboDK;

            gcKBK.ExTitleLabel.Text = "Detail Kas/Bank Keluar";
            gcKBK.ExGridView.Columns["cct"].Caption = "Cost Center";
            gcKBK.ExGridView.Columns["kode"].Caption = "Kd. Transaksi";
            gcKBK.ExGridView.Columns["acc"].Caption = "No. Rekening";
            gcKBK.ExGridView.Columns["remark"].Caption = "Keterangan";
            gcKBK.ExGridView.Columns["debet"].Caption = "D/K";
            gcKBK.ExGridView.Columns["dk"].Caption = "Debet/Kredit";
            gcKBK.ExGridView.Columns["val"].Caption = "Nilai";
            gcKBK.ExGridView.Columns["val"].ColumnEdit = new GridNumEx();
            gcKBK.ExGridView.Columns["invoice"].Caption = "Invoice";
            gcKBK.ExGridView.Columns["Nama"].Caption = "Nama Rekening";
            gcKBK.ExGridView.Columns["okl"].Caption = "NO SO";
            gcKBK.ExGridView.Columns["rfp"].Caption = "No. RFP";
            gcKBK.ExGridView.Columns["jurnal"].Caption = "No. Hutang";

            gcKBK.ExGridView.Columns["rfp"].ColumnEdit = new GridLookUpEx(DB.sql, Querynyax, "rfp", "rfp", gcKBK.ExGridView, "", true, true, "Request For Payment");
            gcKBK.ExGridView.Columns["rfp"].ColumnEdit.Enter += new EventHandler(ExGridView_rfpColumnEdit_Enter);          


            //gcKBK.ExGridView.Columns["jurnal"].ColumnEdit = new GridLookUpEx(DB.sql, "call SP_OutRhp('" + txtSupplier.Text + "','" + txtSupplier.Text + "'," + Utility.FirstDateInMonth(dateDate.DateTime).ToString("yyyyMMdd") + "," + ((DateTime)dateDate.EditValue).AddDays(1).ToString("yyyyMMdd") + ",'" + ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text + "','1')", "rhp", "jurnal", gcKBK.ExGridView, "", true, true, "Detail Hutang");
            //gcKBK.ExGridView.Columns["jurnal"].ColumnEdit.Enter += new EventHandler(ExGridView_jurnalColumnEdit_Enter);           

            gcKBK.ExGridView.Columns["okl"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('oklmsk')", "okl", "okl", gcKBK.ExGridView, "", true, false, "Nomor SO");
            gcKBK.ExGridView.Columns["okl"].ColumnEdit.Enter += new EventHandler(ExGridView_oklColumnEdit_Enter);

            //gcKBK.ExGridView.Columns["okl"].VisibleIndex = 0;
            gcKBK.ExGridView.Columns["rfp"].VisibleIndex = 0;
            gcKBK.ExGridView.Columns["jurnal"].VisibleIndex = 1;
            gcKBK.ExGridView.Columns["cct"].VisibleIndex = 2;
            gcKBK.ExGridView.Columns["kode"].VisibleIndex = 3;
            gcKBK.ExGridView.Columns["acc"].VisibleIndex = 4;
            gcKBK.ExGridView.Columns["Nama"].VisibleIndex = 5;
            gcKBK.ExGridView.Columns["remark"].VisibleIndex = 6;
            gcKBK.ExGridView.Columns["dk"].VisibleIndex = 7;
            gcKBK.ExGridView.Columns["val"].VisibleIndex = 8;
            gcKBK.ExGridView.BestFitColumns();

            gcKBK.ExGridView.OptionsBehavior.Editable = false;
            gcKBK.ExGridView.OptionsSelection.MultiSelect = true;
            gcKBK.ExGridView.OptionsCustomization.AllowSort = false;
            gcKBK.ExGridView.OptionsView.ShowGroupPanel = false;
            gcKBK.ExGridView.Columns["Nama"].OptionsColumn.AllowEdit = false;

            DB.SetNumberFormat(gcKBK.ExGridView, "n2");
            tsbtnPrint.Click += new EventHandler(tsbtnPrint_Click);

            spinEditNilaiKasBank.Properties.MinValue = 0;
            spinEditNilaiKasBank.Properties.MaxValue = Decimal.MaxValue;
        }

        void ExGridView_rfpColumnEdit_Enter(object sender, EventArgs e)
        {
            string query = "select * from (select rfd.rfp as `No. RFP`,rfd.nodoc as `No. Hutang`,rfd.val as Nilai,rfd.acc as `Kode Akun`,rfd.remark as keterangan, tkad.kas as reff "
                + ",rfd.invoice as `Invoice`,if(rhp.dk='D','K','D') as `Debet/Kredit` "
                + "from rfd inner join rfp on rfd.rfp=rfp.rfp left outer join rhp on rfd.nodoc=rhp.jurnal and rfd.invoice=rhp.invoice  left outer join (select kad.* from kad,kas where kad.kas=kas.kas and kas.`delete`=0) as tkad on tkad.rfp=rfd.rfp and tkad.jurnal=rfd.nodoc "
                + "where rfp.`delete`=0 and rfp.sub ='" + txtSupplier.EditValue.ToString() + "') as Trfp where Trfp.reff is null order by Trfp.`No. RFP`";
            ((GridLookUpEx)gcKBK.ExGridView.Columns["rfp"].ColumnEdit).Query = query;
        }

        void ExGridView_oklColumnEdit_Enter(object sender, EventArgs e)
        {
            string query = "Call SP_LookUp('oklmsk')";
            ((GridLookUpEx)gcKBK.ExGridView.Columns["okl"].ColumnEdit).Query = query;
        }

        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DetailTable = DB.PopulateNamaRekening(DetailTable, "Nama");
            CalculateTotal();
        }

        private void FrmTKBK_Load(object sender, EventArgs e)
        {
            DetailTable = DB.PopulateNamaRekening(DetailTable, "Nama");
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
            DataRow row = gcKBK.ExGridView.GetDataRow(e.RowHandle);
            row["kas"] = NoDocument;
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            row["dk"] = "D";
            row["remark"] = this.remarkTextBox.Text; 
        }

        protected override void tsbtnDelete_Click(object sender, EventArgs e)
        {
            base.tsbtnDelete_Click(sender, new EventArgs());
            if (Convert.ToInt32(MasterTable.Rows[MasterBindingSource.Position]["delete"]) == 1)
                DB.sql.Execute("Call SP_Delete('KBK','"+ NoDocument + "')");
        }

        void ExGridView_Delete_Click(object sender, EventArgs e)
        {
            DB.DeleteDetailRows(gcKBK.ExGridView);
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

            DB.InsertDetailRows(gcKBK.ExGridView, row);
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            gcKBK.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcKBK.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcKBK.ExGridView.OptionsBehavior.Editable = true;
            gcKBK.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
        }

        protected override void tsbtnCancel_Click(object sender, EventArgs e)
        {
            DB.CancelDetailRows(DetailTable);

            base.tsbtnCancel_Click(sender, new EventArgs());

            if (this.mode == Mode.View)
            {
                gcKBK.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                gcKBK.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                gcKBK.ExGridView.OptionsBehavior.Editable = false;
                gcKBK.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;

                DetailTable = DB.PopulateNamaRekening(DetailTable, "Nama");
                CalculateTotal();
            }
        }
        
        protected override void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            base.tsbtnRefresh_Click(sender, new EventArgs());
            DetailTable = DB.PopulateNamaRekening(DetailTable, "Nama");
            CalculateTotal();
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            curcur.Text = "IDR";
            curkurs.EditValue = 1;
            DetailTable.Clear();
            CalculateTotal();
            gcKBK.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcKBK.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcKBK.ExGridView.OptionsBehavior.Editable = true;
            gcKBK.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
        }

        void ExGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "debet")
            {
                string debet = "D";
             //   if (gcKBK.ExGridView.GetFocusedRowCellValue(gcKBK.ExGridView.Columns["debet"].ToString()) == "D") debet = "K";
                if (e.Value.ToString() == "D")
                    debet = "K";
                gcKBK.ExGridView.SetFocusedRowCellValue(gcKBK.ExGridView.Columns["dk"], debet);
            }
            if (e.Column.FieldName == "cct")
            {
                DetailBindingSource.EndEdit();
                //string query = "Call SP_LookUpCcaAcc('" + (string)gcKBK.ExGridView.GetFocusedRowCellValue("cct") + "')";
                gcKBK.ExGridView.SetFocusedRowCellValue(gcKBK.ExGridView.Columns["kode"], "");
                gcKBK.ExGridView.SetFocusedRowCellValue(gcKBK.ExGridView.Columns["acc"], "");
                gcKBK.ExGridView.SetFocusedRowCellValue(gcKBK.ExGridView.Columns["Nama"], "");
                gcKBK.ExGridView.Columns["kode"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUpCcaAcc('" + (string)gcKBK.ExGridView.GetFocusedRowCellValue("cct")+ "')", "cct", "cct", gcKBK.ExGridView, "", true, true, "Kd. Transaksi");
                return;
            }
            if (e.Column.FieldName == "val" || e.Column.FieldName == "dk")
            {
                CalculateTotal();
            }
      //      CalculateTotal();
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate controls
                this.ValidateChildren();

                DetailBindingSource.EndEdit();
                if (textBoxEx1.Text=="" && spinEditNilaiKasBank.Value!=0  )  
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
                        if (row["acc"].ToString().Trim() == "" )
                        {
                            MessageBox.Show("Invalid Account Name. Please correct the value");
                            return;
                        }
                    }
                }
             
                ((DataRowView)MasterBindingSource.Current).Row["group_"] = 3;

                for (int i = DetailTable.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = DetailTable.Rows[i];
                    if (row != null && row.RowState != DataRowState.Deleted)
                    {
                        row[0] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
                    }
                }

                for (int i = 0; i < DetailTable.Rows.Count; i++)
                {
                    string kodeRfp = DetailTable.Rows[i]["rfp"].ToString();
                    DB.sql.Execute("update rfp set stat_rfp = 1 where rfp = '" + kodeRfp + "'");
                }

                base.tsbtnSave_Click(sender, e);
                string date = ((DateTime)(dateDate.EditValue)).ToString("yyyyMMdd");
                string jurnal = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
                DB.sql.Execute("Call SP_Save(" + date + ",'KBK'" + ",'" + jurnal + "')");

                if (this.mode == Mode.View)
                {
                    gcKBK.ExGridView.OptionsBehavior.Editable = false;
                    gcKBK.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                    gcKBK.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                    gcKBK.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void tsbtnPrint_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "BKK" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable temp = DB.sql.Select("call SP_Print('Transaction.FrmTKBK','" + this.NoDocument + "')");
            //report.DataSource = dt;
            string terbilangkag = "";
            string terbilangkagn = "";

            int rowcount = 10;
            int oldrow = 0;
            int pagejum = 1;
            int jum1 = 1;
            int nowrowcount = temp.Rows.Count;
            while (nowrowcount > rowcount)
            {
                DataRow data;
                data = temp.NewRow();
                double jum = 0;
                for (int i = oldrow; i < rowcount; i++)
                {
                    jum += Convert.ToDouble(temp.Rows[i]["val"].ToString());
                }
                for (int i = 0; i < 20; i++)
                {
                    data[i] = temp.Rows[0][i];
                }
                data["detailacc"] = data["dk"] = "";
                data["accname"] = "                         Total dari hal." + pagejum.ToString();
                data["val"] = jum;
                temp.Rows.InsertAt(data, rowcount);
                data = temp.NewRow();
                data["accname"] = "                         SALDO PINDAHAN dari hal." + pagejum.ToString();
                data["val"] = jum;
                jum = 0;
                rowcount += 1;
                temp.Rows.InsertAt(data, rowcount);
                pagejum++;
                oldrow = rowcount;
                nowrowcount++;
                rowcount += 10;
            }
            DataRow data1;
            data1 = temp.NewRow();
            temp.Rows.InsertAt(data1, rowcount);
            data1["accname"] = "                         TOTAL :";
            // data1["val"] = Convert.ToDouble(txtTotalKAD.EditValue.ToString());
            data1["val"] = temp.Rows[0]["totalval"].ToString();
            data1 = temp.NewRow();
            rowcount += 1;
            temp.Rows.InsertAt(data1, rowcount);
            data1["accname"] = " Ket:";
            data1 = temp.NewRow();
            rowcount += 1;
            temp.Rows.InsertAt(data1, rowcount);
            //    data1["accname"] = remarkTextBox.Text.Trim();
            data1["accname"] = temp.Rows[0]["remark"].ToString();

            report.DataSource = temp;
            //report.Bands[BandKind.PageHeader].Controls[0].Controls[2].Controls[1].Text = terbilang(Convert.ToDouble(temp.Rows[0]["totalval"].ToString()), curcur.Text);
            //report.Bands[BandKind.PageFooter].Controls[0].Controls[0].Controls[1].Text = temp.Rows[0]["Giro"].ToString();
            //if (temp.Rows[0]["Giro"].ToString() != "")
            //{
            //    report.Bands[BandKind.PageFooter].Controls[0].Controls[0].Controls[2].Text = ((System.DateTime)(temp.Rows[0]["TglJT"])).ToString("dd/MM/yyyy");
            //}
            //report.Bands[BandKind.PageFooter].Controls[0].Controls[0].Controls[3].Text = temp.Rows[0]["TobePaid"].ToString();

            report.PaperName = "1/2A4";
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
                if (belakangkoma > 0)
                    result += "koma " + Utility.NumberToText(belakangkoma) + " Rupiah";
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
                    result += "point " + Utility.NumberToTextEN(belakangkoma) + " USD";
                else
                    result += " USD";
            }
            return result;
        }

        void ExGridView_jurnalColumnEdit_Enter(object sender, EventArgs e)
        {
            string query = "call SP_OutRhp('" + txtSupplier.Text + "','" + txtSupplier.Text + "'," + Utility.FirstDateInMonth(dateDate.DateTime).ToString("yyyyMMdd") + "," + ((DateTime)dateDate.EditValue).AddDays(1).ToString("yyyyMMdd") + ",'" + ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text + "','1')";
            ((GridLookUpEx)gcKBK.ExGridView.Columns["jurnal"].ColumnEdit).Query = query;
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
            //textEditAkumulasi.EditValue = debet - kredit;
            spinEditNilaiKasBank.EditValue = debet - kredit;
        }
    }
}
