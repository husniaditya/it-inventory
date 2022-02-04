using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KASLibrary;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using MySql.Data.MySqlClient;
using DevExpress.XtraReports.UI;

namespace CAS.Transaction
{
    public partial class FrmTRkl : CAS.Transaction.BaseTransaction
    {
        MySqlDataAdapter rllAdapter, rkdAdapter;
        DataTable dtResult = new DataTable();
        DataTable dtBaseUnit = new DataTable();

        public FrmTRkl()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlDetail, DB.sql);
            MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);

            // SO Retur
            gcxRll.ExTitleLabel.Text = "Detail SO Retur";
            gcxRll.ExGridControl.DataSource = rllBindingSource;
            gcxRll.ExGridView.OptionsView.ShowGroupPanel = false;
            gcxRll.ExGridView.OptionsCustomization.AllowSort = false;
            gcxRll.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(gcxRll_tsbtnDelete_Click);
            gcxRll.ExGridView.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(gcxRll_SelectionChanged);
            gcxRll.ExGridView.Columns["rkl"].Visible = gcxRll.ExGridView.Columns["no"].Visible = false;
            gcxRll.ExGridView.Columns["rsm"].Caption = "SO Retur";
            gcxRll.ExGridView.Columns["rka"].Caption = "LPB Retur";
            gcxRll.ExGridView.Columns["date"].Caption = "Tanggal";
            gcxRll.ExGridView.Columns["remark"].Caption = "Keterangan";
            gcxRll.ExGridView.Columns["val"].Caption = "Val";
           

            DB.SetNumberFormat(gcxRll.ExGridView, "n2");

            // Invoice
            gcxRkd.ExTitleLabel.Text = "Invoice";
            gcxRkd.ExGridControl.DataSource = rkdBindingSource;
            gcxRkd.ExGridView.OptionsView.ShowGroupPanel = false;
            gcxRll.ExGridView.OptionsCustomization.AllowSort = false;
            gcxRkd.ExGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(gcxRkd_InitNewRow);
            gcxRkd.ExGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(ExGridView_CellValueChanged);

            gcxRkd.ExGridView.Columns["invo"].ColumnEdit = new GridLookUpEx(DB.sql, "select * from kld where 0", "klr", "invo", gcxRkd.ExGridView, "", true, true, "Detail Invoice");
            gcxRkd.ExGridView.Columns["invo"].ColumnEdit.Enter += new EventHandler(ExGridView_invoColumnEdit_Enter);           

            gcxRkd.ExGridView.Columns["val"].OptionsColumn.AllowEdit = false;
        //    gcxRkd.ExGridView.Columns["kurs"].OptionsColumn.AllowEdit = false;
            gcxRkd.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(gcxRkd_tsbtnDelete_Click);
            gcxRkd.ExGridView.Columns["rkl"].Visible = gcxRkd.ExGridView.Columns["no"].Visible = false;
            gcxRkd.ExGridView.Columns["rsm"].ColumnEdit = new RepositoryItemComboBox();
            (gcxRkd.ExGridView.Columns["rsm"].ColumnEdit as RepositoryItemComboBox).TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            gcxRkd.ExGridView.Columns["rsm"].Caption = "SO Retur";
            gcxRkd.ExGridView.Columns["rsm"].Visible = false;
            gcxRkd.ExGridView.Columns["invo"].Caption = "Invoice";
            gcxRkd.ExGridView.Columns["nofp"].Caption = "No Faktur Pajak";
            gcxRkd.ExGridView.Columns["tglfp"].Caption = "Tanggal Faktur Pajak";
            gcxRkd.ExGridView.Columns["tglsfp"].Caption = "Tgl Setor Faktur Pajak";
            gcxRkd.ExGridView.Columns["kurs"].Caption = "Kurs";
            gcxRkd.ExGridView.Columns["dpp"].Caption = "DPP";
            gcxRkd.ExGridView.Columns["dpp"].ColumnEdit = new GridNumEx();
            gcxRkd.ExGridView.Columns["ppn"].Caption = "PPN";
            gcxRkd.ExGridView.Columns["ppn"].ColumnEdit = new GridNumEx();
            gcxRkd.ExGridView.Columns["val"].Caption = "Val";
            gcxRkd.ExGridView.Columns["remark"].Caption = "Keterangan";
            DB.SetNumberFormat(gcxRkd.ExGridView, "n2");
            // Penerimaan Barang
            casDataSet.rkb.Columns.Add("Unit Base", typeof(String));
            gcxRkb.ExTitleLabel.Text = "Detail Laporan Penerimaan Barang";
            gcxRkb.ExGridControl.DataSource = casDataSet.rkb;
            gcxRkb.ExGridView.OptionsView.ShowGroupPanel = false;
            gcxRkb.ExGridView.OptionsCustomization.AllowSort = false;
            gcxRkb.ExGridView.Columns["rka"].Caption = "LPB Retur";
            gcxRkb.ExGridView.Columns["nodsg"].Caption = "No Design";
            gcxRkb.ExGridView.Columns["inv"].Caption = "Kode Barang";
            gcxRkb.ExGridView.Columns["remark"].Caption = "Nama Barang";
            gcxRkb.ExGridView.Columns["loc"].Caption = "Loc";
            gcxRkb.ExGridView.Columns["qty"].Caption = "Qty Base";
            gcxRkb.ExGridView.Columns["qty1"].Caption = "Qty";
            gcxRkb.ExGridView.Columns["unit"].Caption = "Unit";
            gcxRkb.ExGridView.Columns["etd"].Caption = "Keterangan";
            gcxRkb.ExGridView.Columns["no"].Visible = false;
            gcxRkb.ExGridView.Columns["Unit Base"].VisibleIndex = casDataSet.rkb.Columns.IndexOf("qty") + 1;

            gcxRkd.ExGridView.Columns["invo"].VisibleIndex = 1;
            gcxRkd.ExGridView.Columns["nofp"].VisibleIndex = 2;
            gcxRkd.ExGridView.Columns["tglfp"].VisibleIndex = 3;
            gcxRkd.ExGridView.Columns["tglsfp"].VisibleIndex = 4;
            gcxRkd.ExGridView.Columns["qty"].VisibleIndex = 5;
            gcxRkd.ExGridView.Columns["unit"].VisibleIndex = 6;
            gcxRkd.ExGridView.Columns["price"].VisibleIndex = 7;
            gcxRkd.ExGridView.Columns["kurs"].VisibleIndex = 8;
            gcxRkd.ExGridView.Columns["dpp"].VisibleIndex = 9;
            gcxRkd.ExGridView.Columns["ppn"].VisibleIndex = 10;
            gcxRkd.ExGridView.Columns["val"].VisibleIndex = 11;
          
            DB.SetNumberFormat(gcxRkb.ExGridView, "n2");

            tsbtnPrint.Click += new EventHandler(tsbtnPrint_Click);
            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
        }

        void ExGridView_invoColumnEdit_Enter(object sender, EventArgs e)
        {
            string material =  gcxRkd.ExGridView.GetDataRow(DetailBindingSource.Position)["inv"].ToString();
            string uom =  gcxRkd.ExGridView.GetDataRow(DetailBindingSource.Position)["unit"].ToString();
            double qtynya = (double)gcxRkd.ExGridView.GetDataRow(DetailBindingSource.Position)["qty"];
            string supplier = ctrlSub.txtSub.Text;

            double harga = (double) gcxRkd.ExGridView.GetDataRow(DetailBindingSource.Position)["dpp"]/DB.GetQtyInBaseUom(material,uom,qtynya);
        //    string query = "select klr.klr as  `Invoice`,klr.fpj as `No Faktur Pajak`,fpjdate as `Tanggal Faktur Pajak`,sfpjdate as `Tgl Setor Faktur Pajak` from kld,klr,okd where klr.klr=kld.klr and okd.okl=kld.okl and okd.inv=kld.inv and sub='" + ctrlSub.txtSub.EditValue.ToString() + "' and round(okd.val/okd.qty,2)=round(" + harga.ToString().Replace(",", ".") + ",2) and klr.date <= " + ((DateTime)dateDate.EditValue).ToString("yyyyMMdd");
            string query = "select klr.klr as  `Invoice`,klr.fpj as `No Faktur Pajak`,fpjdate as `Tanggal Faktur Pajak`,sfpjdate as `Tgl Setor Faktur Pajak` from kld,klr,okd where klr.klr=kld.klr and okd.okl=kld.okl and okd.inv=kld.inv and sub='" + ctrlSub.txtSub.EditValue.ToString() + "' and date(klr.date) <= " + ((DateTime)dateDate.EditValue).ToString("yyyyMMdd") +" and kld.inv ='" + material + "' and klr.sub='"+ supplier +"'"; 
            ((GridLookUpEx)gcxRkd.ExGridView.Columns["invo"].ColumnEdit).Query = query;
        }

        protected override void tsbtnDelete_Click(object sender, EventArgs e)
        {
            base.tsbtnDelete_Click(sender, e);
            if (Convert.ToInt32(MasterTable.Rows[MasterBindingSource.Position]["delete"]) == 1)
                DB.sql.Execute("Call SP_Delete('RKL'" + ",'" + NoDocument + "')");
            if (MasterBindingSource.Position == -1)
                tsbtnNew.PerformClick();
        }

        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            PopulateDetails();
        }

        void RePopulate_List_Cbo_Rsm()
        {
            dtResult.Clear();

            listRsm.Items.Clear();
            foreach (DataRow drRll in casDataSet.rll.Rows)
            {
                if (listRsm.Items.IndexOf(drRll["rsm"]) == -1)
                {
                    listRsm.Items.Add(drRll["rsm"].ToString());
               //     DataTable dt = DB.sql.Select("Select * from rka where rka='" + drRll["rka"].ToString() + "'");
               //     dtResult.ImportRow(dt.Rows[0]);
                }
            }
            //populate listRms to cboRms in Invoice
            RepositoryItemComboBox cboRsm = (RepositoryItemComboBox)gcxRkd.ExGridView.Columns["rsm"].ColumnEdit;
            cboRsm.Items.Clear();
            cboRsm.Items.AddRange(listRsm.Items);
        }

        protected override void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            base.tsbtnRefresh_Click(sender, e);
            PopulateDetails();
        }

        private void PopulateDetails()
        {
            try
            {
                bool newEntry = (MasterBindingSource.Position == MasterTable.Rows.Count);
                string query = "";

                // Rkd
                casDataSet.rkd.Clear();
                if (newEntry)
                    query = "select * from rkd where 0";
                else
                    query = "select * from rkd where rkl='" + MasterTable.Rows[MasterBindingSource.Position][0].ToString() + "'";
                rkdAdapter = DB.sql.SelectAdapter(query);
                rkdAdapter.Fill(casDataSet.rkd);
                gcxRkd.ExGridView.BestFitColumns();

                // Rll
                casDataSet.rll.Clear();
                if (newEntry)
                    query = "select * from rll where 0";
                else
                    query = "select * from rll where rkl='" + MasterTable.Rows[MasterBindingSource.Position][0].ToString() + "'";
                rllAdapter = DB.sql.SelectAdapter(query);
                rllAdapter.Fill(casDataSet.rll);
                gcxRll.ExGridView.BestFitColumns();

                RePopulate_List_Cbo_Rsm();

                // Rkb
                casDataSet.rkb.Clear();
                foreach (DataRow drRll in casDataSet.rll.Rows)
                {
                    DataTable dtRkb = DB.sql.Select("select rkb.*, inv.unit as `Unit Base` from rkb, inv where rkb.inv=inv.inv and rka='" + drRll["rka"] + "' and  rkb.inv ='" + drRll["inv"] + "'");
                   
                    foreach (DataRow drRkb in dtRkb.Rows)
                    {
                        drRkb["no"] = casDataSet.rkb.Rows.Count + 1;
                        casDataSet.rkb.ImportRow(drRkb);
                    }
                }
                gcxRkb.ExGridView.BestFitColumns();
            }
            catch (Exception ex)
            {
            }
        }

        void gcxRkd_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gcxRkd.ExGridView.GetDataRow(e.RowHandle);
            row["rkl"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
            row["no"] = gcxRkd.ExGridView.RowCount;
        }

        void ExGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "dpp" || e.Column.FieldName == "ppn")
            {
                double dpp = (double)gcxRkd.ExGridView.GetRowCellValue(e.RowHandle, gcxRkd.ExGridView.Columns["dpp"]);
                double ppn = (double)gcxRkd.ExGridView.GetRowCellValue(e.RowHandle, gcxRkd.ExGridView.Columns["ppn"]);
                double val = dpp + ppn;
                gcxRkd.ExGridView.SetRowCellValue(e.RowHandle, gcxRkd.ExGridView.Columns["val"], val);

                ReCalculateTotal();
            }
            else if (e.Column.FieldName == "tglfp")
            {
                //tgl setor faktur pajak = tgl 15 berikutnya setelah tgl faktur pajak
                DateTime tglFP = (DateTime)gcxRkd.ExGridView.GetFocusedRowCellValue("tglfp");
                DateTime tglSetorFP = new DateTime(tglFP.Year, tglFP.Month, 15);
                if (tglFP.Day > 15)
                    tglSetorFP = tglSetorFP.AddMonths(1);
                gcxRkd.ExGridView.SetRowCellValue(e.RowHandle, gcxRkd.ExGridView.Columns["tglsfp"], tglSetorFP);
            }
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            gcxRkd.ExGridView.OptionsBehavior.Editable = true;
            gcxRkd.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

            btnAddRsm.Enabled = true;
            btnDeleteRsm.Enabled = true;
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            gcxRkd.ExGridView.OptionsBehavior.Editable = true;
            gcxRkd.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

            btnAddRsm.Enabled = true;
            btnDeleteRsm.Enabled = true;
        }

        private void FrmTRkl_Load(object sender, EventArgs e)
        {
            dtResult = casDataSet.rsm.Clone();

            if (MasterBindingSource.Position == MasterTable.Rows.Count)
            {
                btnAddRsm.Enabled = true;
                btnDeleteRsm.Enabled = true;
            }
            else
            {
                btnAddRsm.Enabled = false;
                btnDeleteRsm.Enabled = false;
            }
            Utility.SetSqlInstance(pnlDetail, DB.sql);
            ctrlSub.txtSub.DataBindings.Add("EditValue", rklBindingSource, "sub");
            ctrlSub.txtSub.EditValueChanged += new EventHandler(txtSub_EditValueChanged);
            PopulateDetails();
            Utility.SetNumberFormat(pnlTotal, "n2");
            ReCalculateTotal();

         //   curcur.Properties.ReadOnly = true;

            dtBaseUnit = DB.GetBaseUnitTable();
        }

        private void FillRkdRkb()
        {
            casDataSet.rkb.Clear();
            casDataSet.rkd.Clear();
            string noSO = "";
            foreach (DataRow rkaRow in casDataSet.rll.Rows)
            {
                if (rkaRow.RowState != DataRowState.Deleted)
                {
                    noSO = rkaRow["rka"].ToString();

                    // Add Inventories to Penerimaan Barang
                    DataTable dtRkb = DB.sql.Select("select rka, nodsg, inv, loc, remark, qty, no, qty1, unit, etd"
                        + " from rkb where rka='" + rkaRow["rka"].ToString() + "' and inv='"+ rkaRow["inv"].ToString() +"'");
                    foreach (DataRow rkbRow in dtRkb.Rows)
                    {
                        DataRow rkbNewRow = casDataSet.rkb.NewRow();
                        foreach (DataColumn rkbCol in casDataSet.rkb.Columns)
                        {
                            if (rkbCol.ColumnName.ToString() == "Unit Base")
                                rkbNewRow[rkbCol.ColumnName] = dtBaseUnit.Select("inv='" + rkbNewRow["inv"].ToString() + "'")[0]["unit"];
                            else
                                rkbNewRow[rkbCol.ColumnName] = rkbRow[rkbCol.ColumnName];
                        }
                        casDataSet.rkb.Rows.Add(rkbNewRow);
                    }
                    gcxRkb.ExGridView.BestFitColumns();
/*
                    // Add SOs to Invoice Tab                
                    DataRow rkdRow = casDataSet.rkd.NewRow();
                    if (casDataSet.rkd.Select("rsm='" + noSO + "'").Length > 0)
                        rkdRow = casDataSet.rkd.Select("rsm='" + noSO + "'")[0];
                    else
                    {
                        DataTable dtinvo = DB.sql.Select("select kll.klr,klr.fpj,klr.fpjdate,klr.sfpjdate from kll,klr where klr.klr=kll.klr and kll.sjh='" + rkaRow["rsm"].ToString() + "'");
                        rkdRow["invo"] = dtinvo.Rows[0]["klr"].ToString() ;
                        rkdRow["rkl"] = rkaRow["rkl"];
                        rkdRow["nofp"] = dtinvo.Rows[0]["fpj"];
                        rkdRow["tglfp"] = dtinvo.Rows[0]["fpjdate"];
                        rkdRow["tglsfp"] = dtinvo.Rows[0]["sfpjdate"];
                        rkdRow["no"] = casDataSet.rkd.Rows.Count + 1;
                        rkdRow["rsm"] = rkaRow["rsm"];
                        rkdRow["qty"] = rkaRow["qty"];
                        rkdRow["unit"] = rkaRow["unit"];
                        rkdRow["price"] = rkaRow["price"];
                        rkdRow["kurs"] = 1;
                        rkdRow["dpp"] = 0;
                        casDataSet.rkd.Rows.Add(rkdRow);
                    }
                    rkdRow["dpp"] = Convert.ToDouble(rkdRow["price"]) * Convert.ToDouble(rkdRow["qty"]);
                    //if (Convert.ToInt64(dtResult.Select("rsm='" + noSO + "'")[0]["ppn"]) == 1)
                        rkdRow["ppn"] = Convert.ToDouble(rkdRow["dpp"]) * 0.1;
                   // else
                    //    rkdRow["ppn"] = 0;
                    rkdRow["val"] = Convert.ToDouble(rkdRow["dpp"]) + Convert.ToDouble(rkdRow["ppn"]);
 */
                    DataRow rkdRow = casDataSet.rkd.NewRow();
                    rkdRow["rkl"] = rkaRow["rkl"];
                    rkdRow["price"] = rkaRow["price"];
                    rkdRow["dpp"] = rkaRow["val"];
                    rkdRow["qty"] = rkaRow["qty"];
                    rkdRow["inv"] = rkaRow["inv"];
                    rkdRow["kurs"] = 1;
                    rkdRow["ppn"] = (double)rkaRow["val"]*0.1;
                    rkdRow["val"] = (double)rkdRow["dpp"] + (double)rkdRow["ppn"];
                    rkdRow["unit"] = rkaRow["unit"];
                    rkdRow["remark"] = rkaRow["remark"];
                    rkdRow["no"] = casDataSet.rkd.Rows.Count + 1;
                    casDataSet.rkd.Rows.Add(rkdRow);
                }
            }
                   
            gcxRkd.ExGridView.BestFitColumns();
        }


        private void btnAddRsm_Click(object sender, EventArgs e)
        {
            FrmDialog rsmDialog = new FrmDialog("SO Retur", DB.sql, "Call SP_SelectforInvoice('RKA','" + ctrlSub.txtSub.Text + "')");

            string SORetur = "";
            if (rsmDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (DataRow rsmRow in rsmDialog.ResultRows)
                {
                    SORetur = rsmRow["SO Retur"].ToString();
                    if (dtResult.Rows.Find(SORetur) != null)
                    {
                        //MessageBox.Show("Data sudah ada");
                        return;
                    }
                    DataRow drResult = dtResult.NewRow();
                    drResult["rsm"] = SORetur;
                    drResult["date"] = rsmRow["Tanggal"];
                    drResult["remark"] = rsmRow["Keterangan"];
                //    drResult["kurs"] = 1;
                    drResult["ppn"] = 0;
                    drResult["sub"] = "";
                    drResult["period"] = "";
                 //   drResult["cur"] = "";
                    drResult["chtime"] = "";
                    drResult["chusr"] = "";
                    drResult["nopoc"] = "";
                    //dtResult.ImportRow(rmsRow);
                    dtResult.Rows.Add(drResult);

                    if (listRsm.Items.IndexOf(SORetur) < 0)
                    {
                        listRsm.Items.Add(SORetur);

                        string rkl = ludSeri.Text +  "-" + txtPeriod.Text + "-" + txtNo.Text;
                        string query = "Call SP_SelectSOLPBReturforRKL('@rkl','@rsm')";
                        query = query.Replace("@rkl", rkl);
                        query = query.Replace("@rsm", SORetur);
                        DataTable dtRka = DB.sql.Select(query);

                        foreach (DataRow rkaRow in dtRka.Rows)
                        {
                            DataRow rllRow = casDataSet.rll.NewRow();
                            foreach (DataColumn rllCol in casDataSet.rll.Columns)
                            {
                                rllRow[rllCol.ColumnName] = rkaRow[rllCol.ColumnName];
                            }
                            rllRow["no"] = casDataSet.rll.Rows.Count + 1;
                            casDataSet.rll.Rows.Add(rllRow);
                        }
                        gcxRll.ExGridView.BestFitColumns();
                    }
                }
                FillRkdRkb();
                ReCalculateTotal();
            }

            RepositoryItemComboBox cboRsm = (RepositoryItemComboBox)gcxRkd.ExGridView.Columns["rsm"].ColumnEdit;
            cboRsm.Items.Clear();
            cboRsm.Items.AddRange(listRsm.Items);
        }

        private void btnDeleteRsm_Click(object sender, EventArgs e)
        {
            if (listRsm.SelectedIndex < 0) return;

            // Remove SOs from Invoice Tab
            DB.DeleteDetailRows(gcxRkd.ExGridView);

            // Remove Inventories from Penerimaan Barang
            DB.DeleteDetailRows(gcxRkb.ExGridView);

            DB.DeleteDetailRows(gcxRll.ExGridView);

            int pos = listRsm.SelectedIndex;
            listRsm.SelectedIndex = -1;
            //listRms.Items.RemoveAt(listRms.SelectedIndex);
            listRsm.Items.RemoveAt(pos);
          //  dtResult.Rows.Remove(dtResult.Rows[pos]);

            RepositoryItemComboBox cboRsm = (RepositoryItemComboBox)gcxRkd.ExGridView.Columns["rsm"].ColumnEdit;
            cboRsm.Items.Clear();
            cboRsm.Items.AddRange(listRsm.Items);
        }

        void gcxRll_tsbtnDelete_Click(object sender, EventArgs e)
        {
            // Remove Inventories from Penerimaan Barang
            DB.DeleteDetailRows(gcxRkb.ExGridView);

            DB.DeleteDetailRows(gcxRll.ExGridView);

            FillRkdRkb();
            ReCalculateTotal();
        }

        void gcxRkd_tsbtnDelete_Click(object sender, EventArgs e)
        {
            DB.DeleteDetailRows(gcxRkd.ExGridView);
        }

        private void txtSub_EditValueChanged(object sender, EventArgs e)
        {
            DataRow row = ctrlSub.txtSub.ExGetDataRow();

            //if (row == null)
            //{
            //    curcur.EditValue = "";
            //    return;
            //}

            //curcur.EditValue = row["cur"].ToString();
           // spinTOP.EditValue = row["top"].ToString();

            if (MasterBindingSource.Position == MasterTable.Rows.Count)
                btnAddRsm.PerformClick();
        }

        private void listRsm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listRsm.SelectedIndex >= 0)
            {
                string rkl = listRsm.SelectedItem.ToString();
                gcxRll.UnselectAll();
                gcxRkd.UnselectAll();
                for (int i = 0; i < gcxRll.ExGridView.RowCount; i++)
                {
                    if ((gcxRll.ExGridView.GetDataRow(i) as DataRow)["rsm"].ToString() == rkl)
                    {
                        gcxRll.ExGridView.SelectRow(i);
                        gcxRkd.ExGridView.SelectRow(i);
                    }
                }

                //gcxRkd.UnselectAll();
                //for (int i = 0; i < gcxRkd.ExGridView.RowCount; i++)
                //{
                //    if (gcxRkd.ExGridView.GetDataRow(i) == null) return;

                //    if ((gcxRkd.ExGridView.GetDataRow(i) as DataRow)["rka"].ToString() == rka)
                //        gcxRkd.ExGridView.SelectRow(i);
                //}
            }
        }


        void gcxRll_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            gcxRkb.UnselectAll();

            int[] selectedIndices = gcxRll.ExGridView.GetSelectedRows();
            if (selectedIndices == null) return;

            for (int i = 0; i < selectedIndices.Length; i++)
            {
                string rka = (gcxRll.ExGridView.GetDataRow(selectedIndices[i]) as DataRow)["rka"].ToString();
                for (int j = 0; j < gcxRkb.ExGridView.RowCount; j++)
                {
                    if ((gcxRkb.ExGridView.GetDataRow(j) as DataRow)["rka"].ToString() == rka)
                        gcxRkb.ExGridView.SelectRow(j);
                }
            }
        }

        void ReCalculateTotal()
        {
            DetailBindingSource.EndEdit();
            double subTotal = 0;
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
            double total = subTotal + ppn;
            txtTotal.EditValue = total;
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate controls
                this.Validate();
                this.ValidateChildren();

                ((DataRowView)MasterBindingSource.Current).Row["duedate"] = ((DateTime)dateDate.EditValue).AddDays(Convert.ToDouble(spinTOP.EditValue));

                if (gcxRkd.ExGridView.EditingValue != null)
                    gcxRkd.ExGridView.SetFocusedValue(gcxRkd.ExGridView.EditingValue);

                //loop DetailTable
                foreach (DataRow dr in DetailTable.Rows)
                {
                    if (dr.RowState == DataRowState.Added)
                        DB.sql.Execute("Delete from rkd where rkl='" + NoDocument + "' and rsm='" + dr["rsm"].ToString() + "'");
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

                base.tsbtnSave_Click(sender, e);

                if (this.mode == Mode.View)
                {
                    // Update NoDocument
                    for (int i = 0; i < casDataSet.rll.Rows.Count; i++)
                        if (casDataSet.rll.Rows[i].RowState != DataRowState.Deleted)
                          casDataSet.rll.Rows[i][0] = NoDocument;

                    rllBindingSource.EndEdit();
                    rllAdapter.Update(casDataSet.rll);

                    string date = ((DateTime)(dateDate.EditValue)).ToString("yyyyMMdd");
                    DB.sql.Execute("Call SP_Save(" + date + ",'RKL'" + ",'" + NoDocument + "')");

                    btnAddRsm.Enabled = false;
                    btnDeleteRsm.Enabled = false;

                    // disable all GridControls
                    gcxRkd.ExGridView.OptionsBehavior.Editable = false;
                    gcxRkd.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected override void tsbtnCancel_Click(object sender, EventArgs e)
        {
            casDataSet.rll.RejectChanges();
            casDataSet.rkb.RejectChanges();
            base.tsbtnCancel_Click(sender, e);
            if (this.mode == Mode.View)
            {
             //   RePopulate_List_Cbo_Rsm();
                btnAddRsm.Enabled = false;
                btnDeleteRsm.Enabled = false;
                ReCalculateTotal();

                // disable all GridControls
                gcxRkd.ExGridView.OptionsBehavior.Editable = false;
                gcxRkd.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            }
        }

        void tsbtnPrint_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepNotaRetur" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_Print('Transaction.FrmTRkl','" + this.NoDocument + "')");
            // report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
            report.ShowPreview();
        }

        private void txtNo_EditValueChanged(object sender, EventArgs e)
        {
            ReCalculateTotal();
        }

        private void ctrlSub_Load(object sender, EventArgs e)
        {

        }
    }
}

