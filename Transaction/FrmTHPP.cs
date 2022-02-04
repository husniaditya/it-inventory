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
    public partial class FrmTHPP : CAS.Transaction.BaseTransaction
    {
        MySqlDataAdapter daHprod = new MySqlDataAdapter();

        public FrmTHPP()
        {
            InitializeComponent();      

            Utility.SetSqlInstance(pnlDetail, DB.sql);
            gcHPP.ExGridControl.DataSource = hprodBindingSource;

            gcHPP.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
            gcHPP.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
            gcHPP.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gcHPP.ExToolStrip.Items["tsbtnNew"].Enabled = false;
            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            //tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);

            gcHPP.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
            //gcHPP.ExGridView.CellValueChanged += new CellValueChangedEventHandler(ExGridView_CellValueChanged);

            gcHPP.ExGridView.Columns["hpro"].Visible = false;
            gcHPP.ExGridView.Columns["okl"].Visible = false;
            gcHPP.ExGridView.Columns["mor"].Visible = false;
            gcHPP.ExGridView.Columns["no"].Visible = false;

            string tgl = DateTime.Today.ToString("yyyyMMdd");
            gcHPP.ExGridView.Columns["inv"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('inv')", "inv", "inv", gcHPP.ExGridView, "", true, true, "Inventory");
            gcHPP.ExGridView.Columns["mor"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUpMO(" + tgl + "," + tgl + ")", "mor", "mor", gcHPP.ExGridView, "", true, true, "Manufacturing Order");
            gcHPP.ExGridView.Columns["mor"].ColumnEdit.Enter += new EventHandler(morColumnEdit_Enter);
            gcHPP.ExGridView.Columns["hargapokokproduksi"].ColumnEdit = new GridNumEx(500);
            gcHPP.ExGridView.Columns["nodsg"].ColumnEdit = new GridLookUpEx(DB.sql, "Call Sp_GetStockBatch(" + DateTime.Now.ToString("yyyyMMdd") + ",'')", "", "No Batch", gcHPP.ExGridView, "", true, true, "Batch");
            gcHPP.ExGridView.Columns["nodsg"].ColumnEdit.Enter += new EventHandler(DsgColumnEdit_Enter);

            gcHPP.ExTitleLabel.Text = "Stok Opname Detail";
            gcHPP.ExGridView.Columns["mor"].Caption = "MO";
            gcHPP.ExGridView.Columns["nodsg"].Caption = "No Batch";
            gcHPP.ExGridView.Columns["inv"].Caption = "Kode Barang";
            gcHPP.ExGridView.Columns["remark"].Caption = "Nama Barang";
            gcHPP.ExGridView.Columns["hargapokokproduksi"].Caption = "Harga Pokok Produksi";
            gcHPP.ExGridView.BestFitColumns();

            //gcHPP.ExGridView.Columns["mor"].VisibleIndex = 0;
            gcHPP.ExGridView.Columns["inv"].VisibleIndex = 1;
            gcHPP.ExGridView.Columns["remark"].VisibleIndex = 2;
            gcHPP.ExGridView.Columns["nodsg"].VisibleIndex = 3;
            gcHPP.ExGridView.Columns["hargapokokproduksi"].VisibleIndex = 4;

            gcHPP.ExGridView.OptionsBehavior.Editable = false;
            gcHPP.ExGridView.OptionsSelection.MultiSelect = true;
            gcHPP.ExGridView.OptionsCustomization.AllowSort = false;
            gcHPP.ExGridView.OptionsView.ShowGroupPanel = false;
            //gcHPP.ExGridView.Columns["nodsg"].OptionsColumn.AllowEdit = true;
            gcHPP.ExGridView.Columns["mor"].OptionsColumn.AllowEdit = false;
            gcHPP.ExGridView.Columns["remark"].OptionsColumn.AllowEdit = false;

            dateEdit1.Properties.MinValue = Utility.FirstDateInMonth(DB.loginDate);
            dateEdit1.Properties.MaxValue = Utility.LastDateInMonth(DB.loginDate);

            DB.SetNumberFormat(gcHPP.ExGridView, "n2");

            MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);
        }

        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            gcHPP.ExGridView.BestFitColumns();
        }

        void morColumnEdit_Enter(object sender, EventArgs e)
        {
            string tglAwal = ((DateTime)dateDate.EditValue).ToString("yyyyMMdd");
            string tglAkhir = ((DateTime)dateEdit1.EditValue).ToString("yyyyMMdd");
            ((GridLookUpEx)gcHPP.ExGridView.Columns["mor"].ColumnEdit).Query = "Call SP_LookUpMO(" + tglAwal + "," + tglAkhir + ")";
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
            inv = gcHPP.ExGridView.GetFocusedRowCellValue("inv").ToString();
            if (gcHPP.ExGridView.GetFocusedRowCellValue("inv") != null)
                (gcHPP.ExGridView.Columns["nodsg"].ColumnEdit as GridLookUpEx).Query = "Call Sp_BppbGetStockBatch(" + DateTime.Now.ToString("yyyyMMdd") + ",'" + inv + "')";
        }

        private void FrmTHPP_Load(object sender, EventArgs e)
        {
            dateDate.Properties.MinValue = dateEdit1.Properties.MinValue = DateTime.MinValue;
            dateDate.Properties.MaxValue = dateEdit1.Properties.MaxValue = DateTime.MaxValue;

            Utility.SetSqlInstance(pnlDetail, DB.sql);
            //ctrlSub1.ReadOnly = true;
            if (MasterBindingSource.Position == MasterTable.Rows.Count)
            {
                gcHPP.ExGridView.OptionsBehavior.Editable = true;
                gcHPP.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                gcHPP.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
                gcHPP.ExToolStrip.Items["tsbtnNew"].Enabled = true;
               //dateEdit1.DataBindings.Add("EditValue", MasterBindingSource, "datez");                   
                dateDate.Properties.MinValue = dateEdit1.Properties.MinValue = DateTime.MinValue;
                dateDate.Properties.MaxValue = dateEdit1.Properties.MaxValue = DateTime.MaxValue;
            }

        }

        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gcHPP.ExGridView.GetDataRow(e.RowHandle);
            row["hpro"] = NoDocument;
            //row["no"] = DetailTable.Rows.Count + 1;
            row["no"] = DB.GetRowCount(DetailTable) + 1;
        }

        void ExGridView_Delete_Click(object sender, EventArgs e)
        {
            DB.DeleteDetailRows(gcHPP.ExGridView);
        }

        void ExGridView_New_Click(object sender, EventArgs e)
        {
            DataRow row = casDataSet.hprod.NewRow();
            row["hpro"] = NoDocument;
            row["hargapokokproduksi"] = 0;
            row["inv"] = "";
            row["remark"] = "";
            casDataSet.opd.Rows.Add(row);

            DB.InsertDetailRows(gcHPP.ExGridView, row);
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            gcHPP.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcHPP.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcHPP.ExGridView.OptionsBehavior.Editable = true;
            gcHPP.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
        }

        protected override void tsbtnCancel_Click(object sender, EventArgs e)
        {
            DB.CancelDetailRows(DetailTable);

            base.tsbtnCancel_Click(sender, new EventArgs());

            if (this.mode == Mode.View)
            {
                gcHPP.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                gcHPP.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                gcHPP.ExGridView.OptionsBehavior.Editable = false;
                gcHPP.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            }
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            DetailTable.Clear();
            gcHPP.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcHPP.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcHPP.ExGridView.OptionsBehavior.Editable = true;
            gcHPP.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            dateEdit1.EditValue = Utility.LastDateInMonth(DB.loginDate);
            dateDate.EditValue = Utility.FirstDateInMonth(DB.loginDate);
        }

        protected override void tsbtnDelete_Click(object sender, EventArgs e)
        {
            base.tsbtnDelete_Click(sender, e);
            if (Convert.ToInt32(MasterTable.Rows[MasterBindingSource.Position]["delete"]) == 1)
                DB.sql.Execute("Call SP_Delete('HPP'" + ",'" + NoDocument + "')");
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
          //      ((DataRowView)MasterBindingSource.Current).Row["datez"] = dateEdit1.EditValue;
                if (mode == Mode.Edit && DetailTable.GetChanges() != null)
                {
                    if (MessageBox.Show("Detail HPP " + NoDocument + " yang lama akan dihapus, lanjutkan?", "Confirmation",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1) != DialogResult.Yes)
                    {
                        return;
                    }
                    else
                    {
                        DB.sql.Execute("delete from hprod where hpro='" + NoDocument + "'");
                    }

                }
                // Validate controls
                this.ValidateChildren();

                DetailBindingSource.EndEdit();

                for (int i = 0; i < gcHPP.ExGridView.RowCount; i++)
                {
                    if (gcHPP.ExGridView.GetDataRow(i) != null)
                        if (gcHPP.ExGridView.GetDataRow(i).RowState != DataRowState.Deleted)
                        {
                            if (gcHPP.ExGridView.GetRowCellValue(i, "inv").ToString() == "")
                            {
                                MessageBox.Show("Invalid Kode Barang. Please correct the value");
                                return;
                            }
                        }
                }
                for (int i = DetailTable.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = DetailTable.Rows[i];
                    if (row != null && row.RowState != DataRowState.Deleted)
                    {
                        row[0] = NoDocument;
                    }
                }
                base.tsbtnSave_Click(sender, e);
                string date = ((DateTime)(dateDate.EditValue)).ToString("yyyyMMdd");
                string jurnal = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
                DB.sql.Execute("Call SP_Save(" + date + ",'HPP'" + ",'" + jurnal + "')");
                if (this.mode == Mode.View)
                {
                    gcHPP.ExGridView.OptionsBehavior.Editable = false;
                    gcHPP.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                    gcHPP.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                    gcHPP.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                }

                if (MessageBox.Show("Apakah anda ingin update CoGS sekarang ?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                  //  DB.sql.Execute("Call SP_Cogs('" + DB.loginPeriod + "')");
                    string query = "Call SP_Cogs('" + DB.loginPeriod + "')";
                    DataTable dtrep = DB.sql.Select(query);

                    for (int i = 0; i < dtrep.Rows.Count; i++)
                    {
                        DB.sql.Execute("call sp_save (" + Convert.ToDateTime(dtrep.Rows[i]["date"].ToString()).ToString("yyyyMMdd") + ",'" + dtrep.Rows[i]["subjurnal"] + "','" + dtrep.Rows[i]["jurnal"] + "')");
                    }
                  //  DB.sql.CommitTransaction();
                    MessageBox.Show("Update CoGS Berhasil..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dateDate_EditValueChanged(object sender, EventArgs e)
        {
            //if (this.mode == Mode.New)
            //    dateEdit1.EditValue = dateDate.EditValue;
        }

        private void txtCct_EditValueChanged(object sender, EventArgs e)
        {
            casDataSet.hprod.Clear();
            daHprod = DB.sql.SelectAdapter("Select hprod.* from hprod, hpro where hprod.hpro=hpro.hpro and period='" + txtPeriod.Text + "' and cct='" + txtCct.Text + "'");
            daHprod.Fill(casDataSet.hprod);
            gcHPP.ExGridControl.DataSource = hprodBindingSource;

            if (mode == Mode.View)
                txtCct.ExSqlQuery = "select * from cct where cct like '111%'";

            if (mode != Mode.New && mode != Mode.Edit) return;

            txtPeriod.Text = DB.loginPeriod;
            casDataSet.ctd.RejectChanges();

            casDataSet.hprod.Clear();
            string sqltext = "";
            if (mode == Mode.New)
            {
                sqltext = " select inv, remark, costperpcs from ctd " +
                    " where period='" + DB.loginPeriod + "' and ctd.cct='" + txtCct.Text + "'" +
                    "   and inv not in (select distinct inv from hprod, hpro where hprod.hpro=hpro.hpro " +
                    "     and hpro.period='" + DB.loginPeriod + "' and hpro.cct='" + txtCct.Text + "') " +
                    " order by inv ";
            }
            else if (mode == Mode.Edit)
            {
                sqltext = " select inv, remark, costperpcs from ctd " +
                    " where period='" + DB.loginPeriod + "' and ctd.cct='" + txtCct.Text + "'" +
                    "   and inv not in (select distinct inv from hprod, hpro where hprod.hpro=hpro.hpro " +
                    "     and hpro.period='" + DB.loginPeriod + "' and hpro.cct='" + txtCct.Text + "' " +
                    "     and hpro.hpro<>'" + NoDocument + "') " +
                    " order by inv ";
            }
            DataTable dtTemp = DB.sql.Select(sqltext);

            for (int i = 0; i < dtTemp.Rows.Count; i++)
            {
                DataRow dr = casDataSet.hprod.NewRow();
                dr["hpro"] = "";
                dr["inv"] = dtTemp.Rows[i]["inv"];
                dr["remark"] = dtTemp.Rows[i]["remark"];
                dr["hargapokokproduksi"] = dtTemp.Rows[i]["costperpcs"];
                dr["mor"] = "";
                dr["okl"] = "";
                dr["nodsg"] = "";
                dr["no"] = i;
                casDataSet.hprod.Rows.Add(dr);
            }
        }
    }
}