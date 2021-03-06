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
    public partial class FrmTPPiutang : CAS.Transaction.BaseTransaction
    {
        MySqlDataAdapter kadAdapter;

        public FrmTPPiutang()
        {
            InitializeComponent();

            ToolStripMenuItem tsmiPrintPreview = new ToolStripMenuItem("Print Preview", null, new EventHandler(tsmiPrintPreview_Click));
            ToolStripMenuItem tsmiPrintDirectly = new ToolStripMenuItem("Print Directly", null, new EventHandler(tsmiPrintDirectly_Click));
            ToolStripDropDownButton tsbtnPrint = new ToolStripDropDownButton("Print", null, tsmiPrintPreview, tsmiPrintDirectly);
            tsbtnPrint.Image = MasterNavigator.Items["tsbtnPrint"].Image;
            MasterNavigator.Items.Insert(MasterNavigator.Items.IndexOfKey("tsbtnPrint"), tsbtnPrint);
            MasterNavigator.Items.RemoveByKey("tsbtnPrint");

            casDataSet.kad.Columns.Add("debet", typeof(String));

            Utility.SetSqlInstance(pnlDetail, DB.sql);
            gcKAG.ExGridControl.DataSource = kagBindingSource;
            gcKAD.ExGridControl.DataSource = kadBindingSource;

            MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);

            gcKAG.ExGridView.Columns["kas"].Visible = false;
            gcKAG.ExGridView.Columns["no"].Visible = false;
            gcKAG.ExGridView.Columns["group_"].Visible = false;
            gcKAD.ExGridView.Columns["kas"].Visible = false;
            gcKAD.ExGridView.Columns["debet"].Visible = false;
            gcKAD.ExGridView.Columns["rfp"].Visible = false;
            gcKAD.ExGridView.Columns["no"].Visible = false;
            gcKAD.ExGridView.Columns["group_"].Visible = false;
            gcKAD.ExGridView.Columns["kode"].Visible = false;
            gcKAD.ExGridView.Columns["est"].Visible = false;
            gcKAD.ExGridView.Columns["kurs"].Visible = false;
            gcKAD.ExGridView.Columns["invoice"].Visible = false;
            gcKAD.ExGridView.Columns["okl"].Visible = false;
            gcKAD.ExGridView.Columns["name"].Visible = false;

            gcKAG.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gcKAG.ExToolStrip.Items["tsbtnNew"].Enabled = false;
            gcKAD.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gcKAD.ExToolStrip.Items["tsbtnNew"].Enabled = false;

            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            //tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
            tsbtnDelete.Click += new EventHandler(tsbtnDelete_Click);
           
            gcKAG.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
            gcKAD.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView2_New_Click);
            gcKAG.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
            gcKAD.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView2_Delete_Click);
            
            gcKAG.ExGridView.CellValueChanged += new CellValueChangedEventHandler(ExGridView_CellValueChanged);
            gcKAD.ExGridView.CellValueChanged += new CellValueChangedEventHandler(ExGridView2_CellValueChanged);

            gcKAG.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
            gcKAD.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView2_InitNewRow);
            
            //gcKAG.ExGridView.Columns["acc"].ColumnEdit = new GridLookUpEx(DB.sql, "select acc as `Kode Akun`, name as `Nama Rekening` from acc where detil=1 and name like '%giro%' and name like '%piutang%'", "acc", "acc", gcKAG.ExGridView, "", true, true, "Account");
            gcKAG.ExGridView.Columns["acc"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('kgrpiutang')", "kgr","acc", gcKAG.ExGridView, "", true, true, "Account Giro");
            gcKAG.ExGridView.Columns["acc"].ColumnEdit.Enter += new EventHandler(kag_acc_ColumnEdit_Enter);
            gcKAG.ExGridView.Columns["nobg"].ColumnEdit = new RepositoryItemTextEdit();
            gcKAG.ExGridView.Columns["nobg"].ColumnEdit.Enter += new EventHandler(kag_nobg_ColumnEdit_Enter);
            gcKAG.ExGridView.Columns["bank"].ColumnEdit = new RepositoryItemTextEdit();
            gcKAG.ExGridView.Columns["bank"].ColumnEdit.Enter += new EventHandler(kag_bank_ColumnEdit_Enter);
            gcKAG.ExGridView.Columns["duedate"].ColumnEdit = new RepositoryItemDateEdit();
            gcKAG.ExGridView.Columns["duedate"].ColumnEdit.Enter += new EventHandler(kag_duedate_ColumnEdit_Enter);
            gcKAG.ExGridView.Columns["acbank"].ColumnEdit = new RepositoryItemTextEdit();
            gcKAG.ExGridView.Columns["acbank"].ColumnEdit.Enter += new EventHandler(kag_acbank_ColumnEdit_Enter);
            gcKAG.ExGridView.Columns["accbank"].ColumnEdit = new RepositoryItemTextEdit();
            gcKAG.ExGridView.Columns["accbank"].ColumnEdit.Enter += new EventHandler(kag_accbank_ColumnEdit_Enter);
            gcKAG.ExGridView.Columns["val"].ColumnEdit = new GridNumEx();
            gcKAG.ExGridView.Columns["val"].ColumnEdit.Enter += new EventHandler(kag_val_ColumnEdit_Enter);

            gcKAD.ExGridView.Columns["acc"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('acc')", "acc", "acc", gcKAD.ExGridView, "", true, true, "Perkiraan");
            gcKAD.ExGridView.Columns["acc"].ColumnEdit.Enter += new EventHandler(kad_acc_ColumnEdit_Enter);
            gcKAD.ExGridView.Columns["cct"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('cct')", "cct", "cct", gcKAD.ExGridView, "", true, true, "Cost Center");
            gcKAD.ExGridView.Columns["jurnal"].ColumnEdit = new GridLookUpEx(DB.sql, "call SP_OutRhp('" + txtCustomer.Text + "','" + txtCustomer.Text + "'," + Utility.FirstDateInMonth(dateDate.DateTime).ToString("yyyyMMdd") + "," + ((DateTime)dateDate.EditValue).AddDays(1).ToString("yyyyMMdd") + ",'" + ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text + "','1')", "rhp", "jurnal", gcKAD.ExGridView, "", true, true, "Detail Hutang");
            gcKAD.ExGridView.Columns["jurnal"].ColumnEdit.Enter += new EventHandler(ExGridView_jurnalColumnEdit_Enter);           
          
            // Debet Kredit ComboBox
            RepositoryItemComboBox cboDK = new RepositoryItemComboBox();
            cboDK.Items.AddRange(new string[] { "D", "K" });
            cboDK.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            gcKAD.ExGridView.Columns["dk"].ColumnEdit = cboDK;
            
            gcKAG.ExTitleLabel.Text = "Detail Giro";
            gcKAG.ExGridView.Columns["nobg"].Caption = "No. BG";
            gcKAG.ExGridView.Columns["acc"].Caption = "Perk. Giro";
            gcKAG.ExGridView.Columns["bank"].Caption = "Bank";
            gcKAG.ExGridView.Columns["duedate"].Caption = "J.Tempo";
            gcKAG.ExGridView.Columns["acbank"].Caption = "AC.Bank";
            gcKAG.ExGridView.Columns["val"].Caption = "Nilai";
            gcKAG.ExGridView.Columns["accbank"].Caption = "Perk. Bank";

            gcKAD.ExTitleLabel.Text = "Detail Pelunasan";
            gcKAD.ExGridView.Columns["jurnal"].Caption = "No. Piutang";
            gcKAD.ExGridView.Columns["remark"].Caption = "Keterangan";
            gcKAD.ExGridView.Columns["dk"].Caption = "Debet/Kredit";
            gcKAD.ExGridView.Columns["debet"].Caption = "D/K";
            gcKAD.ExGridView.Columns["acc"].Caption = "Kode Akun";
            gcKAD.ExGridView.Columns["cct"].Caption = "Cost Center";
            gcKAD.ExGridView.Columns["val"].Caption = "Nilai";
            gcKAD.ExGridView.Columns["invoice"].Caption = "Invoice";
            gcKAD.ExGridView.Columns["invoice"].OptionsColumn.AllowEdit = false;
            gcKAD.ExGridView.Columns["val"].ColumnEdit = new GridNumEx();
            //gcKAD.ExGridView.Columns["oms"].Caption = "No. Order";        

            gcKAG.ExGridView.Columns["acc"].VisibleIndex = 0;
            gcKAG.ExGridView.Columns["acbank"].VisibleIndex = 5;           

           // gcKAD.ExGridView.Columns["oms"].VisibleIndex = 1;
            gcKAD.ExGridView.Columns["jurnal"].VisibleIndex = 0;
            gcKAD.ExGridView.Columns["invoice"].VisibleIndex = 1;
            gcKAD.ExGridView.Columns["cct"].VisibleIndex = 2;
            gcKAD.ExGridView.Columns["acc"].VisibleIndex = 3;
            gcKAD.ExGridView.Columns["remark"].VisibleIndex = 4;
            gcKAD.ExGridView.Columns["dk"].VisibleIndex = 5;
            gcKAD.ExGridView.Columns["val"].VisibleIndex = 6;

            gcKAG.ExGridView.OptionsBehavior.Editable = false;
            gcKAG.ExGridView.OptionsSelection.MultiSelect = true;
            gcKAG.ExGridView.OptionsCustomization.AllowSort = false;
            gcKAG.ExGridView.OptionsView.ShowGroupPanel = false;

            gcKAD.ExGridView.OptionsBehavior.Editable = false;
            gcKAD.ExGridView.OptionsSelection.MultiSelect = true;
            gcKAD.ExGridView.OptionsCustomization.AllowSort = false;
            gcKAD.ExGridView.OptionsView.ShowGroupPanel = false;
            //tsbtnPrint.Click += new EventHandler(tsbtnPrint_Click);
            
            DB.SetNumberFormat(gcKAG.ExGridView, "n2");
            DB.SetNumberFormat(gcKAD.ExGridView, "n2");
            Utility.SetNumberFormat(valSpinEdit, "n2");

            gcKAG.ExGridView.BestFitColumns();
            gcKAD.ExGridView.BestFitColumns();

            valSpinEdit.Properties.MinValue = 0;
            valSpinEdit.Properties.MaxValue = Decimal.MaxValue;

            PopulateKAD();
        }

        void kad_acc_ColumnEdit_Enter(object sender, EventArgs e)
        {
           // if (gcKAD.ExGridView.GetFocusedRowCellValue("cct") != null)
          //  {
                // --auto cost center to acc
                //if (gcKAD.ExGridView.GetFocusedRowCellValue("cct").ToString() != "")
                //{
                //    string cct = gcKAD.ExGridView.GetFocusedRowCellValue("cct").ToString();
                //    ((GridLookUpEx)gcKAD.ExGridView.Columns["acc"].ColumnEdit).Query = "select kode.acc as Perkiraan, acc.name as Keterangan from cca,kode,acc "
                //        + "where left(cct,1) = left(" + cct + ",1) and cca.kode=kode.kode and kode.acc=acc.acc";
                //}
                //else
           //         ((GridLookUpEx)gcKAD.ExGridView.Columns["acc"].ColumnEdit).Query = "Call SP_LookUp('acc')";
        //    }
        //    else
                ((GridLookUpEx)gcKAD.ExGridView.Columns["acc"].ColumnEdit).Query = "Call SP_LookUp('acc')";
        }

        void kag_val_ColumnEdit_Enter(object sender, EventArgs e)
        {
            if (gcKAG.ExGridView.GetFocusedRowCellValue("nobg") != null)
                ((SpinEdit)sender).Enabled = !isGiroCleared(gcKAG.ExGridView.GetFocusedRowCellValue("nobg").ToString());
            else
                ((SpinEdit)sender).Enabled = true;
        }

        void kag_accbank_ColumnEdit_Enter(object sender, EventArgs e)
        {
            if (gcKAG.ExGridView.GetFocusedRowCellValue("nobg") != null)
                ((TextEdit)sender).Properties.ReadOnly = isGiroCleared(gcKAG.ExGridView.GetFocusedRowCellValue("nobg").ToString());
            else
                ((TextEdit)sender).Properties.ReadOnly = false;
        }

        void kag_acbank_ColumnEdit_Enter(object sender, EventArgs e)
        {
            if (gcKAG.ExGridView.GetFocusedRowCellValue("nobg") != null)
                ((TextEdit)sender).Properties.ReadOnly = isGiroCleared(gcKAG.ExGridView.GetFocusedRowCellValue("nobg").ToString());
            else
                ((TextEdit)sender).Properties.ReadOnly = false;
        }

        void kag_duedate_ColumnEdit_Enter(object sender, EventArgs e)
        {
            if (gcKAG.ExGridView.GetFocusedRowCellValue("nobg") != null)
                ((DateEdit)sender).Enabled = !isGiroCleared(gcKAG.ExGridView.GetFocusedRowCellValue("nobg").ToString());
            else
                ((DateEdit)sender).Enabled = true;
        }

        void kag_bank_ColumnEdit_Enter(object sender, EventArgs e)
        {
            if (gcKAG.ExGridView.GetFocusedRowCellValue("nobg") != null)
                ((TextEdit)sender).Properties.ReadOnly = isGiroCleared(gcKAG.ExGridView.GetFocusedRowCellValue("nobg").ToString());
            else
                ((TextEdit)sender).Properties.ReadOnly = false;
        }

        void kag_nobg_ColumnEdit_Enter(object sender, EventArgs e)
        {
            if (gcKAG.ExGridView.GetFocusedRowCellValue("nobg") != null)
                ((TextEdit)sender).Properties.ReadOnly = isGiroCleared(gcKAG.ExGridView.GetFocusedRowCellValue("nobg").ToString());
            else
                ((TextEdit)sender).Properties.ReadOnly = false;
        }

        private bool isGiroCleared(string noGiro)
        {
            if (DB.sql.Select("select * from cgr where nobg='" + noGiro + "'").Rows.Count > 0)
                return true;
            return false;
        }

        void kag_acc_ColumnEdit_Enter(object sender, EventArgs e)
        {
            if (gcKAG.ExGridView.GetFocusedRowCellValue("nobg") != null)
                ((ButtonEdit)sender).Enabled = !isGiroCleared(gcKAG.ExGridView.GetFocusedRowCellValue("nobg").ToString());
            else
                ((ButtonEdit)sender).Enabled = true;
        }


        void ExGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "val") CalculateTotalKAG();
        }
        
        void ExGridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "debet")
            {
                string debet = "D";
                if (gcKAD.ExGridView.GetFocusedRowCellValue(gcKAD.ExGridView.Columns["debet"]).ToString()== "D") debet = "K";
                gcKAD.ExGridView.SetFocusedRowCellValue(gcKAD.ExGridView.Columns["dk"], debet);
            }
            if (e.Column.FieldName == "val" || e.Column.FieldName == "dk") CalculateTotalKAD();
        }

        private void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {

            PopulateKAD();
            CalculateTotalKAD();
            CalculateTotalKAG(); 
        }

        void tsmiPrintPreview_Click(object sender, EventArgs e)
        {

            string path = Application.StartupPath + "\\Reports\\" + "BBM" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable temp = DB.sql.Select("call SP_Print('Transaction.FrmTKBM','" + this.NoDocument + "')");
          //  report.DataSource = dt;
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
                for (int i = 0; i < 18; i++)
                {
                    data[i] = temp.Rows[0][i];
                }
                data["detailacc"] =data["dk"]= "";
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
            data1["accname"] = "                         TOTAL :" ;
            data1["val"] = Convert.ToDouble(txtTotalKAD.EditValue.ToString());
            data1 = temp.NewRow();
            rowcount += 1;
            temp.Rows.InsertAt(data1, rowcount);
            data1["accname"] = " Ket:";
            data1 = temp.NewRow();
            rowcount += 1;
            temp.Rows.InsertAt(data1, rowcount);
            data1["accname"] = remarkTextBox.Text.Trim();
          
            pagejum = 0;
            temp.Columns.Add("page");
            int j = 0;
            foreach (DataRow dl in temp.Rows)
            {
                dl["page"] = j / 5;
                j++;
            }
            report.DataSource = temp;
            //report.Bands[BandKind.PageHeader].Controls[0].Controls[2].Controls[1].Text = terbilang(Convert.ToDouble(txtTotalKAD.EditValue.ToString()), curcur.Text);
            //report.Bands[BandKind.PageFooter].Controls[0].Controls[0].Controls[3].Text = temp.Rows[0]["TobePaid"].ToString();
            report.PaperName = "1/2A4";
            report.ShowPreview();
        }

        void tsmiPrintDirectly_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "BKK" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable temp = DB.sql.Select("call SP_Print('Transaction.FrmTKBK','" + this.NoDocument + "')");
            //  report.DataSource = dt;
            string terbilangkag = "";
            string terbilangkagn = "";
            int rowcount = 9;
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
                for (int i = 0; i < 18; i++)
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
                rowcount += 9;
            }
            DataRow data1;
            data1 = temp.NewRow();
            temp.Rows.InsertAt(data1, rowcount);
            data1["accname"] = "                         TOTAL :";
            data1["val"] = Convert.ToDouble(txtTotalKAD.EditValue.ToString());
            data1 = temp.NewRow();
            rowcount += 1;
            temp.Rows.InsertAt(data1, rowcount);
            data1["accname"] = " Ket:";
            data1 = temp.NewRow();
            rowcount += 1;
            temp.Rows.InsertAt(data1, rowcount);
            data1["accname"] = remarkTextBox.Text.Trim();
          
            pagejum = 0;
            temp.Columns.Add("page");
            int j = 0;
            foreach (DataRow dl in temp.Rows)
            {
                dl["page"] = j / 5;
                j++;
            }
            report.DataSource = temp;
            report.Bands[BandKind.PageHeader].Controls[0].Controls[2].Controls[1].Text = terbilang(Convert.ToDouble(txtTotalKAD.EditValue.ToString()), curcur.Text);
            report.Bands[BandKind.PageFooter].Controls[0].Controls[0].Controls[3].Text = temp.Rows[0]["TobePaid"].ToString();
 
            report.PrintingSystem.ShowMarginsWarning = false; ;
            report.PaperName = "1/2A4";
            report.Print();
        }

        private void PopulateKAD()
        {
            try
            {
                bool newEntry = (MasterBindingSource.Position == MasterTable.Rows.Count);
                string query = "";

                casDataSet.kad.Clear();
                if (newEntry)
                    query = "select * from kad where 0";
                else
                    query = "select * from kad where kas='" + MasterTable.Rows[MasterBindingSource.Position][0].ToString() + "'";
                kadAdapter = DB.sql.SelectAdapter(query);
                kadAdapter.Fill(casDataSet.kad);
                gcKAD.ExGridView.BestFitColumns();
            }
            catch
            { 
            
            }
        
        }

        private void FrmTPiutang_Load(object sender, EventArgs e)
        {
         
        }
        void ExGridView_jurnalColumnEdit_Enter(object sender, EventArgs e)
        {
              string query = "call SP_OutRhp('" + txtCustomer.Text + "','" + txtCustomer.Text + "'," + Utility.FirstDateInMonth(dateDate.DateTime).ToString("yyyyMMdd") + "," + ((DateTime)dateDate.EditValue).AddDays(1).ToString("yyyyMMdd") + ",'" + ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text + "','1')";
            ((GridLookUpEx)gcKAD.ExGridView.Columns["jurnal"].ColumnEdit).Query = query;
        }

        protected override void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            base.tsbtnRefresh_Click(sender, new EventArgs());
            PopulateKAD();
        }

        protected override void tsbtnCancel_Click(object sender, EventArgs e)
        {
            DB.CancelDetailRows(DetailTable);
            remarkTextBox.Focus();

            base.tsbtnCancel_Click(sender, new EventArgs());

            if (this.mode == Mode.View)
            {
                gcKAG.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                gcKAG.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                gcKAG.ExGridView.OptionsBehavior.Editable = false;
                gcKAG.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;

                DB.CancelDetailRows(casDataSet.kad);
                casDataSet.kad.RejectChanges();
                kadBindingSource.CancelEdit();
                gcKAD.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                gcKAD.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                gcKAD.ExGridView.OptionsBehavior.Editable = false;
                gcKAD.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            }
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            gcKAG.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcKAG.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcKAG.ExGridView.OptionsBehavior.Editable = true;
            gcKAG.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            gcKAD.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcKAD.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcKAD.ExGridView.OptionsBehavior.Editable = true;
            gcKAD.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            Utility.SetReadOnly(txtTotalKAD, true);
            Utility.SetReadOnly(txtTotalKAG, true);
        }

        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gcKAG.ExGridView.GetDataRow(e.RowHandle);
            row["kas"] = NoDocument;
            row["nobg"] = "";
            row["no"] = DB.GetRowCount(DetailTable) + 1;
        }

        void ExGridView2_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gcKAD.ExGridView.GetDataRow(e.RowHandle);
            row["kas"] = NoDocument;
            row["no"] = DB.GetRowCount(casDataSet.kad) + 1;
            row["dk"] = "K";
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            DetailTable.Clear();
            casDataSet.kad.Clear();
            CalculateTotalKAD();
            CalculateTotalKAG();
            bilusLabel2.Text = "-";
            gcKAG.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcKAG.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcKAG.ExGridView.OptionsBehavior.Editable = true;
            gcKAG.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            gcKAD.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcKAD.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcKAD.ExGridView.OptionsBehavior.Editable = true;
            gcKAD.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            Utility.SetReadOnly(txtTotalKAD, true);
            Utility.SetReadOnly(txtTotalKAG, true);
        }

        void ExGridView_New_Click(object sender, EventArgs e)
        {
            DataRow row = casDataSet.kag.NewRow();
            row["kas"] = NoDocument;
            row["val"] = 0;
            row["nobg"] = "";
            row["acbank"] = "";
            row["bank"] = "";
            row["duedate"] = Utility.LastDateInMonth(DB.loginDate);
            row["group_"] = "1";
            row["acc"] = "";
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            casDataSet.kag.Rows.Add(row);

            DB.InsertDetailRows(gcKAG.ExGridView, row);
        }

        protected override void tsbtnDelete_Click(object sender, EventArgs e)
        {
            base.tsbtnDelete_Click(sender, e);
            if (Convert.ToInt32(MasterTable.Rows[MasterBindingSource.Position]["delete"]) == 1)
                DB.sql.Execute("Call SP_Delete('KKP','" + NoDocument + "')");
        }
        void ExGridView2_New_Click(object sender, EventArgs e)
        {
            DataRow row = casDataSet.kad.NewRow();
            row["kas"] = NoDocument;
            row["val"] = 0;
            row["jurnal"] = "";
            row["remark"] = "";
            row["dk"] = "";
            row["acc"] = "";
            row["group_"] = "1";
            row["cct"] = "";
            row["kode"] = "";
            row["est"] = 0;
            row["invoice"] = "";
            row["no"] = DB.GetRowCount(casDataSet.kad) + 1;
            casDataSet.kad.Rows.Add(row);

            DB.InsertDetailRows(gcKAD.ExGridView, row);
        }

        void ExGridView_Delete_Click(object sender, EventArgs e)
        {
            bool canDeleteitem, canDelete = true;
            int[] selectedIndex = gcKAG.ExGridView.GetSelectedRows();
            if (selectedIndex.Length > 0)
            {
                for (int i = 0; i < selectedIndex.Length; i++)
                {
                    string prq = gcKAG.ExGridView.GetDataRow(selectedIndex[i])["kas"].ToString();
                    int no = Convert.ToInt32(gcKAG.ExGridView.GetDataRow(selectedIndex[i])["no"]);
                    canDeleteitem = DeleteLineItem(prq, no);
                    if (canDeleteitem == false) canDelete = false;
                }
                if (canDelete)
                {
                    DB.DeleteDetailRows(gcKAG.ExGridView);
                    CalculateTotalKAG();
                    if (DetailTable.GetChanges() != null)
                        DetailAdapter.Update(DetailTable);
                }
            }
        }

        void ExGridView2_Delete_Click(object sender, EventArgs e)
        {
            bool temp = true;
            string query = "";
            bool canDeleteitem, canDelete = true;
            int[] selectedIndex = gcKAD.ExGridView.GetSelectedRows();
            if (selectedIndex.Length > 0)
            {
                for (int i = 0; i < selectedIndex.Length; i++)
                {
                    string prq = gcKAD.ExGridView.GetDataRow(selectedIndex[i])["kas"].ToString();
                    int no = Convert.ToInt32(gcKAD.ExGridView.GetDataRow(selectedIndex[i])["no"]);

                    temp = true;
                    query = "Select FCanDeleteLineItem('kad','" + prq + "'," + no.ToString() + ")";
                    if (DB.sql.Select(query).Rows[0][0].ToString() == "False")
                    {
                        MessageBox.Show("Item ke-" + no.ToString() + " tidak bisa di-delete karena telah digunakan pada tahap transaksi setelahnya");
                        temp = false;
                    }

                    if (temp == false) canDelete = false;
                }
                if (canDelete)
                {
                    DB.DeleteDetailRows(gcKAD.ExGridView);
                    CalculateTotalKAD();
                    if (casDataSet.kad.GetChanges() != null)
                        kadAdapter.Update(casDataSet.kad);
                }
            }
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            remarkTextBox.Focus();
            try
            {
                this.ValidateChildren();
                kadBindingSource.EndEdit();
                DetailBindingSource.EndEdit();
                //casDataSet.kad.AcceptChanges();
                //DetailTable.AcceptChanges();
                //if (txtCustomer.EditValue.ToString().Trim() == "")
                //    throw new Exception("Customer harus diisi");
                if (valSpinEdit.Value != 0 && txtNoAkun.Text == "")
                {
                    throw new Exception("No akun harus diisi");
                }
                for (int i = 0; i < casDataSet.kad.Rows.Count; i++)
                {
                    if (casDataSet.kad.Rows[i]["dk"].ToString().Trim() == "") throw new Exception("Tentukan posisi Debet Kredit pada detail pelunasan ke-" + i.ToString());
                    if (Convert.ToDouble(casDataSet.kad.Rows[i]["val"].ToString()) > 0 && casDataSet.kad.Rows[i]["acc"].ToString().Trim() == "") throw new Exception("Nomor Account pada Detail Pelunasan ke-" + i.ToString() + " belum terisi");
                    if (Convert.ToInt16(casDataSet.kad.Rows[i]["acc"].ToString().Substring(0, 1)) == 6 && casDataSet.kad.Rows[i]["cct"].ToString().Trim() == "") throw new Exception("Cost Center pada Detail Pelunasan ke-" + i.ToString() + " belum terisi");
                }
                if (casDataSet.kad.Rows.Count == 0)
                {
                    throw new Exception("Detail Kas belum terisi");
                }
                if (DetailTable.Rows.Count == 0)
                {
                    txtTotalKAG.Text = "0";
                }
                for (int i = 0; i < DetailTable.Rows.Count - 1; i++)
                {
                    for (int j = i + 1; j < DetailTable.Rows.Count; j++)
                    {
                        if (DetailTable.Rows[i].ItemArray[1].ToString().Trim() == DetailTable.Rows[j].ItemArray[1].ToString().Trim())
                        {
                            throw new Exception("No Bg pada detail item ke-" + Convert.ToString(j) + " sudah ada");
                        }
                    }
                }
                DataTable checkKAG = new DataTable();
                checkKAG = DB.sql.Select("select * from kag ");
                for (int i = 0; i < DetailTable.Rows.Count; i++)
                {
                    if (DetailTable.Rows[i]["acc"].ToString().Trim() != "" && DetailTable.Rows[i]["nobg"].ToString().Trim() == "") throw new Exception("No Bg pada Detail Giro ke-" + Convert.ToString(i) + " belum terisi");
                    if (Convert.ToDouble(DetailTable.Rows[i]["val"].ToString()) > 0 && DetailTable.Rows[i]["acc"].ToString().Trim() == "") throw new Exception("Nomor Account pada Detail Giro ke-" + i.ToString() + " belum terisi");
                    DataRow[] cekRow = checkKAG.Select("nobg='" + DetailTable.Rows[i].ItemArray[1].ToString() + "' and kas<>'" + DetailTable.Rows[i].ItemArray[0].ToString() + "'");
                    if (cekRow.Length > 0)
                    {
                        throw new Exception("No Bg pada detail item ke-" + Convert.ToString(i) + " sudah pernah diinputkan");
                    }
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
                for (int i = casDataSet.kad.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = casDataSet.kad.Rows[i];
                    if (row != null && row.RowState != DataRowState.Deleted)
                    {
                        row[0] = NoDocument;
                        if (row["dk"].ToString() == "")
                        {
                            MessageBox.Show("Invalid Account Name. Please correct the value");
                            return;
                        }
                    }
                }

                if (Convert.ToDecimal(txtTotalKAD.EditValue) != (Convert.ToDecimal(txtTotalKAG.EditValue) + Convert.ToDecimal(valSpinEdit.EditValue)))
                {
                    MessageBox.Show("Journal Not Balance. Please check the value");
                    return;
                }

                if (curcur.EditValue.ToString().Trim() == "")
                    throw new Exception("Currency Harus di Isi");

                ((DataRowView)MasterBindingSource.Current).Row["group_"] = 2;
                base.tsbtnSave_Click(sender, e);

                // Update No Documents
                for (int i = 0; i < casDataSet.kad.Rows.Count; i++)
                    casDataSet.kad.Rows[i][0] = NoDocument;

                kadBindingSource.EndEdit();
                if (casDataSet.kad.GetChanges() != null)
                    kadAdapter.Update(casDataSet.kad);

                string date = ((DateTime)(dateDate.EditValue)).ToString("yyyyMMdd");
                string jurnal = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
                DB.sql.Execute("Call SP_Save(" + date + ",'KKP'" + ",'" + jurnal + "')");

           /*     if (DetailTable.Rows.Count == 0)
                {
                    throw new Exception("Detail Kas belum terisi");
                    //MessageBox.Show("Detail Transaksi belum terisi");
                    //return;
                }
            */
                

                if (this.mode == Mode.View)
                {
                    gcKAG.ExGridView.OptionsBehavior.Editable = false;
                    gcKAG.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                    gcKAG.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                    gcKAG.ExToolStrip.Items["tsbtnNew"].Enabled = false;

                    gcKAD.ExGridView.OptionsBehavior.Editable = false;
                    gcKAD.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                    gcKAD.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                    gcKAD.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                }
               
                tsbtnRefresh.PerformClick();
                CalculateTotalKAD();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }

        private void textBoxEx1_EditValueChanged(object sender, EventArgs e)
        {
            DataRow row = txtCustomer.ExGetDataRow();
            if (row == null)
            {
                curcur.EditValue = "";
                return;
            }
            curcur.EditValue = row["cur"].ToString();
            //spinTOP.EditValue = row["top"].ToString();
        }

        private void curcur_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (curcur.Text == "IDR")
                {
                    double angka = Convert.ToDouble(valSpinEdit.EditValue);
                    double depankoma = Math.Floor(angka);
                    double belakangkoma = Math.Round((angka - depankoma), 2) * 100;
                    bilusLabel2.Text = Utility.NumberToText(depankoma);
                    if (belakangkoma > 0)
                        bilusLabel2.Text += "koma " + Utility.NumberToText(belakangkoma);
                }
                else if (curcur.Text == "USD")
                {
                    double angka = Convert.ToDouble(valSpinEdit.EditValue);
                    int depankoma = Convert.ToInt32(Math.Floor(angka));
                    int belakangkoma = Convert.ToInt32(Math.Round((angka - depankoma), 2) * 100);
                    bilusLabel2.Text = Utility.NumberToTextEN(depankoma);
                    if (belakangkoma > 0)
                        bilusLabel2.Text += "point " + Utility.NumberToTextEN(belakangkoma);
                }
            }
            catch
            { }
        }
        
        private void txtNo_EditValueChanged(object sender, EventArgs e)
        {
            if (MasterBindingSource.Position != MasterTable.Rows.Count)
            {
                CalculateTotalKAG();
                CalculateTotalKAD();
            }
        }

        void CalculateTotalKAG()
        {
            try
            {
                DetailBindingSource.EndEdit();

                double totalKAG = 0;
                for (int i = 0; i < DetailTable.Rows.Count; i++)
                {
                    if (DetailTable.Rows[i] != null && DetailTable.Rows[i].RowState != DataRowState.Deleted)
                    {
                        totalKAG = totalKAG + (double)DetailTable.Rows[i]["val"];
                    }
                }
                txtTotalKAG.EditValue = totalKAG;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        void CalculateTotalKAD()
        {
            try
            {
                kadBindingSource.EndEdit();

                double totalKAD = 0;
                for (int i = 0; i < casDataSet.kad.Rows.Count; i++)
                {
                    if (casDataSet.kad.Rows[i] != null && casDataSet.kad.Rows[i].RowState != DataRowState.Deleted)
                    {
                        if ((string)casDataSet.kad.Rows[i]["DK"] == "D")
                            totalKAD = totalKAD - (double)casDataSet.kad.Rows[i]["val"];
                        else
                            totalKAD = totalKAD + (double)casDataSet.kad.Rows[i]["val"];
                        if (casDataSet.kad.Rows[i]["dk"].ToString() == "") throw new Exception("No Jurnal pada Detail Kas salah");
                    }
                }
                txtTotalKAD.EditValue = totalKAD ;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }     

        private void FrmTPPiutang_Load(object sender, EventArgs e)
        {
            Utility.SetNumberFormat(txtTotalKAD, "n2");
            Utility.SetNumberFormat(txtTotalKAG, "n2");
            if (MasterBindingSource.Position == MasterTable.Rows.Count)
            {
                txtTotalKAG.Text = "0";
                txtTotalKAD.Text = "0";
            }
            PopulateKAD();
            CalculateTotalKAD();
            CalculateTotalKAG();
        }

        private void valSpinEdit_Leave(object sender, EventArgs e)
        {
            try
            {
                if (curcur.Text == "IDR")
                {
                    double angka = Convert.ToDouble(valSpinEdit.EditValue);
                    double depankoma = Math.Floor(angka);
                    double belakangkoma = Math.Round((angka - depankoma), 2) * 100;
                    bilusLabel2.Text = Utility.NumberToText(depankoma);
                    if (belakangkoma > 0)
                        bilusLabel2.Text += "koma " + Utility.NumberToText(belakangkoma);
                }
                else if (curcur.Text == "USD")
                {
                    double angka = Convert.ToDouble(valSpinEdit.EditValue);
                    int depankoma = Convert.ToInt32(Math.Floor(angka));
                    int belakangkoma = Convert.ToInt32(Math.Round((angka - depankoma), 2) * 100);
                    bilusLabel2.Text = Utility.NumberToTextEN(depankoma);
                    if (belakangkoma > 0)
                        bilusLabel2.Text += "point " + Utility.NumberToTextEN(belakangkoma);
                }
            }
            catch { }
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
       
        private void remarkTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

     
    }
}