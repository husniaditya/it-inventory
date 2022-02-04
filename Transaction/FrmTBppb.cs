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
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using DevExpress.XtraEditors;

namespace CAS.Transaction
{
    public partial class FrmTBppb : CAS.Transaction.BaseTransaction
    {
        private int[] selectedIndex = new int[0];
        private bool isDetailValid = true;

       
        public FrmTBppb()
        {
            InitializeComponent();

            Utility.SetSqlInstance(pnlDetail, DB.sql);

            DetailTable.Columns.Add("Unit Base", typeof(String));
            MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);

            group_TextBoxEx.ExSqlInstance = DB.sql; 
            locTextBoxEx.ExSqlInstance = DB.sql;
            cctTextBoxEx.ExSqlInstance = DB.sql;
            kodeTextBoxEx.ExSqlInstance = DB.sql;

            gcjin.ExGridControl.DataSource = jidBindingSource;
            gcjin.ExGridView.OptionsView.ShowGroupPanel = false;
            gcjin.ExTitleLabel.Text = "Detail Bukti Pemakaian Bahan";
            gcjin.ExGridView.OptionsCustomization.AllowSort = false;

            gcjin.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
            gcjin.ExGridView.CellValueChanged += new CellValueChangedEventHandler(ExGridView_CellValueChanged);

            gcjin.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
            gcjin.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
            gcjin.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gcjin.ExToolStrip.Items["tsbtnNew"].Enabled = false;

            gcjin.ExGridView.Columns["jin"].OptionsColumn.AllowEdit = false;
            gcjin.ExGridView.Columns["price"].OptionsColumn.AllowEdit = false;
            gcjin.ExGridView.Columns["inv"].OptionsColumn.AllowEdit = true;
            gcjin.ExGridView.Columns["dk"].OptionsColumn.AllowEdit = false;
            gcjin.ExGridView.Columns["remark"].OptionsColumn.AllowEdit = false;
            gcjin.ExGridView.Columns["spesifikasi"].OptionsColumn.AllowEdit = false;
             gcjin.ExGridView.Columns["no"].Visible = false;
            gcjin.ExGridView.Columns["jin"].Visible = false;
            gcjin.ExGridView.Columns["price"].Visible = false;
            gcjin.ExGridView.Columns["dk"].Visible = false;

            gcjin.ExGridView.Columns["inv"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('invexcludedsg')", "", "inv", gcjin.ExGridView, "", true, true, "Inventory");
            gcjin.ExGridView.Columns["inv"].ColumnEdit.Enter += new EventHandler(InvColumnEdit_Enter);
            gcjin.ExGridView.Columns["nodsg"].ColumnEdit = new GridLookUpEx(DB.sql, "Call Sp_BppbLocGetStockBatch(" + ((DateTime)dateDate.EditValue).ToString("yyyyMMdd") + ",'','')", "", "No Batch", gcjin.ExGridView, "", true, true, "Batch");
            gcjin.ExGridView.Columns["nodsg"].ColumnEdit.Enter += new EventHandler(DsgColumnEdit_Enter);
         //   gcjin.ExGridView.Columns["mor"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('mor')", "", "inv", gcjin.ExGridView, "", true, true, "Manufacturing Order");
            gcjin.ExGridView.Columns["unit"].ColumnEdit = new GridLookUpUnit(gcjin.ExGridView);
            gcjin.ExGridView.Columns["qty1"].ColumnEdit = new GridNumEx(500);
            gcjin.ExGridView.Columns["price"].ColumnEdit = new GridNumEx(500);
          
            // Debet Kredit ComboBox
            RepositoryItemComboBox cboDK = new RepositoryItemComboBox();
            cboDK.Items.AddRange(new string[] { "D", "K" });
            cboDK.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            gcjin.ExGridView.Columns["dk"].ColumnEdit = cboDK;

            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            //tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);

            gcjin.ExGridView.Columns["mor"].Caption = "No.Reff_Central";
            gcjin.ExGridView.Columns["nodsg"].Caption = "No Batch";

            gcjin.ExGridView.Columns["mor"].Visible = false;
            gcjin.ExGridView.Columns["inv"].VisibleIndex = 1;
            gcjin.ExGridView.Columns["remark"].VisibleIndex = 2;
            gcjin.ExGridView.Columns["nodsg"].VisibleIndex = 3;
            gcjin.ExGridView.Columns["spesifikasi"].VisibleIndex = 4; 
            gcjin.ExGridView.Columns["expired"].VisibleIndex = 5;
            gcjin.ExGridView.Columns["qty1"].VisibleIndex = 6;
            gcjin.ExGridView.Columns["unit"].VisibleIndex = 8;
            gcjin.ExGridView.Columns["qty"].VisibleIndex = 9; 

            gcjin.ExGridView.Columns["inv"].Caption = "Kode Barang";
            gcjin.ExGridView.Columns["remark"].Caption = "Nama Barang";
            gcjin.ExGridView.Columns["spesifikasi"].Caption = "Spesifikasi";
            gcjin.ExGridView.Columns["qty1"].Caption = "qty";
            gcjin.ExGridView.Columns["unit"].Caption = "Unit";
            gcjin.ExGridView.Columns["dk"].Caption = "D/K";
            gcjin.ExGridView.Columns["val"].Caption = "Nilai";
            gcjin.ExGridView.Columns["val"].Visible = false;
            gcjin.ExGridView.Columns["qty"].Caption = "Quantity Base";

            gcjin.ExGridView.Columns["Unit Base"].VisibleIndex = 10;
            gcjin.ExGridView.Columns["Unit Base"].OptionsColumn.AllowEdit = false;
            gcjin.ExGridView.Columns["spesifikasi"].OptionsColumn.AllowEdit = false;
           
            gcjin.ExGridView.BestFitColumns();
            gcjin.ExGridView.OptionsBehavior.Editable = false;
            gcjin.ExGridView.OptionsSelection.MultiSelect = true;
            gcjin.ExGridView.OptionsCustomization.AllowSort = false;
            DB.SetNumberFormat(gcjin.ExGridView, "n2");
            tsbtnPrint.Click += new EventHandler(tsbtnPrint_Click);
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
            inv = gcjin.ExGridView.GetFocusedRowCellValue("inv").ToString();
            if (gcjin.ExGridView.GetFocusedRowCellValue("inv") != null)
                (gcjin.ExGridView.Columns["nodsg"].ColumnEdit as GridLookUpEx).Query = "Call Sp_BppbLocGetStockBatch(" + DateTime.Now.ToString("yyyyMMdd") + ",'" + inv + "','" + locTextBoxEx.Text + "')";
        }

        void InvColumnEdit_Enter(object sender, EventArgs e)
        {
            if (gcjin.ExGridView.GetFocusedRowCellValue("nodsg") == null)
            {
                ((ButtonEdit)sender).Enabled = true;
                return;
            }
            if (gcjin.ExGridView.GetFocusedRowCellValue("nodsg").ToString() == "")
                ((ButtonEdit)sender).Enabled = true;
            else
                ((ButtonEdit)sender).Enabled = false;
        }

        void tsbtnPrint_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepBPPB" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_Print('Transaction.FrmTBPPB','" + this.NoDocument + "')");
            report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
            report.ShowPreview();
        }

        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
            gcjin.ExGridView.BestFitColumns();           
        }

        void ExGridView_New_Click(object sender, EventArgs e)
        {
            DataRow row = casDataSet.jid.NewRow();
            row["jin"] = NoDocument;
            row["mor"] = "";
            row["nodsg"] = "";
            row["inv"] = "";
            row["remark"] = "";
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            casDataSet.jid.Rows.Add(row);

            DB.InsertDetailRows(gcjin.ExGridView, row);
        }

        void ExGridView_Delete_Click(object sender, EventArgs e)
        {
            DB.DeleteDetailRows(gcjin.ExGridView);
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            if (this.mode == Mode.Edit)
            {
                gcjin.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
                gcjin.ExToolStrip.Items["tsbtnNew"].Enabled = true;
                gcjin.ExGridView.OptionsBehavior.Editable = true;
                gcjin.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            }
        }

        protected override void tsbtnCancel_Click(object sender, EventArgs e)
        {
            DB.CancelDetailRows(DetailTable);

            base.tsbtnCancel_Click(sender, new EventArgs());

            if (this.mode == Mode.View)
            {
                gcjin.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                gcjin.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                gcjin.ExGridView.OptionsBehavior.Editable = false;
                gcjin.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            }
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            sperpartCheckBox.Checked = false;
            sperpartCheckBox_CheckedChanged(sperpartCheckBox, new EventArgs());
            DetailTable.Clear();
            plantComboBox.Text = "PLANT 1";
            gcjin.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcjin.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcjin.ExGridView.OptionsBehavior.Editable = true;
            gcjin.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            kodeTextBoxEx.Enabled = false;    
        }

        private double GetAvailableStock(double qty, string inv, string nodsg)
        {
            //cek stock
            string tgla = ((DateTime)dateDate.EditValue).ToString("yyyyMMdd");
            string tglz = ((DateTime)dateDate.EditValue).AddDays(1).ToString("yyyyMMdd");
            string query = "Call SP_KartuStock(" + tgla + "," + (tglz) + ",'','','" + inv + "','" + inv + "','" + locTextBoxEx.EditValue.ToString() + "','" + locTextBoxEx.EditValue.ToString() + "','"+ nodsg +"','"+ nodsg +"')";
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
                DB.sql.Execute("Call Sp_Delete('BPP'" + ",'" + NoDocument + "')");
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidateChildren();

                if (gcjin.ExGridView.EditingValue != null)
                    gcjin.ExGridView.SetFocusedValue(gcjin.ExGridView.EditingValue);

                DetailBindingSource.EndEdit();

                if (sperpartCheckBox.Checked && kodeTextBoxEx.Text == "")
                    throw new Exception("Harap mengisi kode transaksi!");

                ((DataRowView)MasterBindingSource.Current).Row["group_"] = 2;

                for (int i = 0; i < DetailTable.Rows.Count; i++)
                {
                    DataRow row = DetailTable.Rows[i];
                    if (DetailTable.Rows[i] != null && DetailTable.Rows[i].RowState != DataRowState.Deleted)
                    {
                        if (DetailTable.Rows[i]["inv"].ToString() == "")
                            throw new Exception("Kode barang tidak valid");
                        if (Convert.ToDouble(DetailTable.Rows[i]["qty"]) == 0)
                            throw new Exception("Qty tidak valid");
                        if (DetailTable.Rows[i]["inv"].ToString().Substring(0,1) == "6" && (cctTextBoxEx.Text == "111107" ||cctTextBoxEx.Text=="111110" ))
                            throw new Exception("Kode barang 6 tidak boleh di cost center margarin atau shortening");
                       // cek stock
                        //double qty = Convert.ToDouble(DetailTable.Rows[i]["qty"]);
                        //string inv = (string)DetailTable.Rows[i]["inv"];
                        //string nodsg = (string)DetailTable.Rows[i]["nodsg"];

                        //double availableStock = GetAvailableStock(qty, inv, nodsg);
                        //if (qty > availableStock)
                        //    throw new Exception("Qty max " + inv + " = " + availableStock + " " + DetailTable.Rows[i]["Unit Base"].ToString());

                        DetailTable.Rows[i][0] = NoDocument;
                        DetailTable.Rows[i]["dk"] = "K";
                        string query = "select F_GetStock(@tgl,'@inv','@loc','@nodsg')";
                        query = query.Replace("@tgl", ((DateTime)dateDate.EditValue).ToString("yyyyMMdd"));
                        query = query.Replace("@inv", row["inv"].ToString()).Replace("@loc",locTextBoxEx.EditValue.ToString());
                        query = query.Replace("@nodsg", row["nodsg"].ToString());
                        double stockQty = 0;
                        if (this.mode == Mode.Edit)
                            stockQty = Convert.ToDouble(row["qty"]);
                        if (DB.sql.Select(query).Rows[0][0] != DBNull.Value)
                            stockQty = stockQty + Convert.ToDouble(DB.sql.Select(query).Rows[0][0]);
                        string errMsg = "";
                        if (row["nodsg"].ToString() != "")
                            errMsg = row["nodsg"].ToString() + " - ";
                        errMsg = errMsg + row["inv"].ToString() + " - " + locTextBoxEx.EditValue.ToString();
                        if (Math.Ceiling(stockQty) < Math.Ceiling((double)(row["qty"])) && !row["inv"].ToString().StartsWith("7"))
                        {
                       //     MessageBox.Show("Stock " + errMsg + " tidak mencukupi");
                            throw new Exception("Stock " + errMsg + " tidak mencukupi");
                        }
                    }
                }

                //((DataRowView)MasterBindingSource.Current).Row["acc"] = txtKodeAccount.Text;
                base.tsbtnSave_Click(sender, e);

                string date = ((DateTime)(dateDate.EditValue)).ToString("yyyyMMdd");
                //string jurnal = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
                DB.sql.Execute("Call SP_Save(" + date + ",'BPP'" + ",'" + NoDocument + "')");

                gcjin.ExGridView.OptionsBehavior.Editable = false;
                gcjin.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                gcjin.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                gcjin.ExToolStrip.Items["tsbtnNew"].Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void ExGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "unit" || e.Column.FieldName == "qty1")
            {
                //DetailBindingSource.EndEdit();                
                //if (e.Column.FieldName == "unit")
                //{
                //    gcjin.ExGridView.SetFocusedRowCellValue(gcjin.ExGridView.Columns["unit1"], (string)gcjin.ExGridView.GetFocusedRowCellValue("unit"));
                //}

                DetailBindingSource.EndEdit();
                string inv = (string)gcjin.ExGridView.GetFocusedRowCellValue("inv");
                string unit = (string)gcjin.ExGridView.GetFocusedRowCellValue("unit");
                double qty1 = (double)gcjin.ExGridView.GetFocusedRowCellValue("qty1");
               
                if (inv != "" && unit != "")
                    gcjin.ExGridView.SetFocusedRowCellValue(gcjin.ExGridView.Columns["qty"], DB.GetQtyInBaseUom(inv, unit, qty1));
                if (e.Column.FieldName == "qty1")
                {
                    double qty = (double)gcjin.ExGridView.GetFocusedRowCellValue("qty");
                    string nodsg = gcjin.ExGridView.GetFocusedRowCellValue("nodsg").ToString();
                    double availableQty = GetAvailableStock(qty, inv, nodsg);
                    if (qty > availableQty)
                    {
                        MessageBox.Show("Qty max=" + availableQty.ToString() + " " + gcjin.ExGridView.GetFocusedRowCellValue("Unit Base").ToString());
                        gcjin.ExGridView.SetFocusedRowCellValue(gcjin.ExGridView.Columns["qty"], availableQty);
                        gcjin.ExGridView.SetFocusedRowCellValue(gcjin.ExGridView.Columns["qty1"], DB.GetQtyInAlternativeUom(inv, unit, availableQty));
                    }
                }
            }
            else if (e.Column.FieldName == "inv")
            {
                //DetailTable = DB.Se
            }
        }

        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gcjin.ExGridView.GetDataRow(e.RowHandle);
            row["jin"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
            //row["no"] = DetailTable.Rows.Count + 1;
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            row["val"] = 0;
            row["qty"] = 0;
            row["qty1"] = 0;

        }

        private void FrmTBppb_Load(object sender, EventArgs e)
        {
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");

            DataTable dtPlant;
            dtPlant = DB.sql.Select("select * from plant");
            for (int i = 0; i < dtPlant.Rows.Count; i++)
            {
                plantComboBox.Items.Add(dtPlant.Rows[i][1].ToString());
            }

            //ctrlSub1.ReadOnly = true;
            if (MasterBindingSource.Position == MasterTable.Rows.Count)
            {
                gcjin.ExGridView.OptionsBehavior.Editable = true;
                gcjin.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                gcjin.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
                gcjin.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            }
                  
        }

        /*private void omsTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {
            if (locTextBoxEx.ExSqlInstance == null)
                return;
            DataRow row = locTextBoxEx.ExGetDataRow();
            if (row == null)
                return;
        }

        private void kodeLabel_Click(object sender, EventArgs e)
        {

        }*/

        private void sperpartCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sperpartCheckBox.Checked)
            {
                //utk sparepart disable jenis material
                //enable kode tarnsaksi
                group_TextBoxEx.EditValue = " ";
                group_TextBoxEx.Enabled = false;
                kodeTextBoxEx.Enabled = true;
                //kodeTextBoxEx.Properties.ReadOnly = false; 
            }
            else
            {
                group_TextBoxEx.Enabled = true;
                kodeTextBoxEx.EditValue = " ";
                kodeTextBoxEx.Enabled = false;                
                //odeTextBoxEx.Properties.ReadOnly = true;                
            }
        }

        private void cctTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {
            //select from cca
            kodeTextBoxEx.ExSqlQuery = "Call SP_LookUpCca('" + cctTextBoxEx.Text + "')";
        }

        private void group_TextBoxEx_EditValueChanged(object sender, EventArgs e)
        {
            //if (sperpartCheckBox.Checked == false)
            //{
            //    DataTable dtjenis = DB.sql.Select("select accmt,name from jenis where jenis ='" + group_TextBoxEx.Text + "'");
            //    if (dtjenis.Rows.Count > 0)
            //    {
            //        txtKodeAccount.Enabled = true;
            //        txtKodeAccount.EditValue = dtjenis.Rows[0][0].ToString();
            //        //txtKodeAccount.Enabled = false;
            //    }
            ////    ((GridLookUpEx)gcjin.ExGridView.Columns["inv"].ColumnEdit).Query = "select inv as `Kode Barang`, name as `Nama Barang`, unit as Unit, unit as `Unit Base` from inv where flag=0 and group_=1 and jenis='" + group_TextBoxEx.EditValue.ToString() + "'";
            //    ((GridLookUpEx)gcjin.ExGridView.Columns["inv"].ColumnEdit).Query = "select inv as `Kode Barang`, name as `Nama Barang`, unit as Unit, unit as `Unit Base` from inv where flag=0 ";
            // }
            //else
            //{
            //    ((GridLookUpEx)gcjin.ExGridView.Columns["inv"].ColumnEdit).Query = "Call SP_LookUp('inv')";
            //    txtKodeAccount.Enabled = true;
            //    txtKodeAccount.EditValue = "";
            //    //txtKodeAccount.Enabled = false;
            //};
        }

        private void kodeTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {
            //if (sperpartCheckBox.Checked)
            if (((DataRowView)MasterBindingSource.Current)["sperpart"].ToString() == "1")
            {
                DataTable dtjenis = DB.sql.Select("select kode,acc.acc from kode,acc where kode.acc=acc.acc and kode ='" + kodeTextBoxEx.Text + "'");
                if (dtjenis.Rows.Count > 0)
                {
                    //txtKodeAccount.Enabled = false;
                    txtKodeAccount.EditValue = dtjenis.Rows[0][1].ToString();
                    //txtKodeAccount.Enabled = false;
                }
            }
            else
            {
                //txtKodeAccount.Readonly = true;
                //txtKodeAccount.Enabled = true;
                txtKodeAccount.EditValue = "";
                //txtKodeAccount.Enabled = false;
            }
        }

        private void locTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {
            //DetailBindingSource.EndEdit();
            //for (int i = 0; i < DetailTable.Rows.Count; i++)
            //{
            //    double qty = Convert.ToDouble(DetailTable.Rows[i]["qty"]);
            //    string inv = (string)DetailTable.Rows[i]["inv"];
            //    double availableStock = GetAvailableStock(qty, inv,"");
            //    if (qty > availableStock)
            //    {
            //        MessageBox.Show("Qty max " + inv + " = " + availableStock + " " + DetailTable.Rows[i]["Unit Base"].ToString());
            //        return;
            //    }
            //}
        }


    }

}

