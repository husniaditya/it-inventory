using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DevExpress.XtraEditors.Repository;
using KASLibrary;

namespace CAS.Transaction
{
    public partial class FrmTRsk : BaseTransaction
    {
        MySqlDataAdapter rslAdapter, rsdAdapter;
        DataTable dtResult = new DataTable();
        DataTable dtBaseUnit = new DataTable();

        public FrmTRsk()
        {
            InitializeComponent();

            MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);

            // PO Retur
            gcxRsl.ExTitleLabel.Text = "Detail PO Retur";
            gcxRsl.ExGridControl.DataSource = rslBindingSource;
            gcxRsl.ExGridView.OptionsView.ShowGroupPanel = false;
            gcxRsl.ExGridView.OptionsCustomization.AllowSort = false;
            gcxRsl.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(gcxRsl_tsbtnDelete_Click);
            gcxRsl.ExGridView.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(gcxRsl_SelectionChanged);
            gcxRsl.ExGridView.Columns["rsk"].Visible = gcxRsl.ExGridView.Columns["no"].Visible = false;
        //    gcxRsl.ExGridView.Columns["rms"].Caption = "PO Retur";
            gcxRsl.ExGridView.Columns["rms"].Visible = false;
            gcxRsl.ExGridView.Columns["sjr"].Caption = "SJ Pengiriman Barang";
            gcxRsl.ExGridView.Columns["date"].Caption = "Tanggal";
            gcxRsl.ExGridView.Columns["remark"].Caption = "Keterangan";
            gcxRsl.ExGridView.Columns["val"].Caption = "Val";
            DB.SetNumberFormat(gcxRsl.ExGridView, "n2");
            
            // Invoice
            gcxRsd.ExTitleLabel.Text = "Invoice";
            gcxRsd.ExGridControl.DataSource = rsdBindingSource;
            gcxRsd.ExGridView.OptionsView.ShowGroupPanel = false;
            gcxRsl.ExGridView.OptionsCustomization.AllowSort = false;
            gcxRsd.ExGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(gcxRsd_InitNewRow);
            gcxRsd.ExGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(ExGridView_CellValueChanged);
            gcxRsd.ExGridView.Columns["val"].OptionsColumn.AllowEdit = false;
         //   gcxRsd.ExGridView.Columns["kurs"].OptionsColumn.AllowEdit = false;
            gcxRsd.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(gcxRsd_tsbtnDelete_Click);
            gcxRsd.ExGridView.Columns["rsk"].Visible = gcxRsd.ExGridView.Columns["no"].Visible = false;
            gcxRsd.ExGridView.Columns["rms"].ColumnEdit = new RepositoryItemComboBox();
            (gcxRsd.ExGridView.Columns["rms"].ColumnEdit as RepositoryItemComboBox).TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
         //   gcxRsd.ExGridView.Columns["rms"].Caption = "PO Retur";
            gcxRsd.ExGridView.Columns["rms"].Visible = false;
            gcxRsd.ExGridView.Columns["invo"].Caption = "Invoice";
            gcxRsd.ExGridView.Columns["invo"].Visible = false;
            gcxRsd.ExGridView.Columns["nofp"].Caption = "No Faktur Pajak";
            gcxRsd.ExGridView.Columns["nofp"].Visible = false;
            gcxRsd.ExGridView.Columns["tglfp"].Caption = "Tanggal Faktur Pajak";
            gcxRsd.ExGridView.Columns["tglfp"].Visible = false;
            gcxRsd.ExGridView.Columns["tglsfp"].Caption = "Tgl Setor Faktur Pajak";
            gcxRsd.ExGridView.Columns["tglsfp"].Visible = false;
            gcxRsd.ExGridView.Columns["kurs"].Caption = "Kurs";
            gcxRsd.ExGridView.Columns["dpp"].Caption = "DPP";
            gcxRsd.ExGridView.Columns["dpp"].ColumnEdit = new GridNumEx();
            gcxRsd.ExGridView.Columns["ppn"].Caption = "PPN";
            gcxRsd.ExGridView.Columns["ppn"].ColumnEdit = new GridNumEx();
            gcxRsd.ExGridView.Columns["val"].Caption = "Val";
            gcxRsd.ExGridView.Columns["remark"].Caption = "Keterangan";
            DB.SetNumberFormat(gcxRsd.ExGridView, "n2");
            
            // Pengiriman Barang
            casDataSet.sjrd.Columns.Add("Unit Base", typeof(String));
            gcxSjrd.ExTitleLabel.Text = "Detail SJ Pengiriman Barang";
            gcxSjrd.ExGridControl.DataSource = casDataSet.sjrd;
            gcxSjrd.ExGridView.OptionsView.ShowGroupPanel = false;
            gcxSjrd.ExGridView.OptionsCustomization.AllowSort = false;
            gcxSjrd.ExGridView.Columns["sjr"].Caption = "SJR";
            gcxSjrd.ExGridView.Columns["inv"].Caption = "Kode Barang";
            gcxSjrd.ExGridView.Columns["remark"].Caption = "Nama Barang";
            gcxSjrd.ExGridView.Columns["loc"].Caption = "Loc";
            gcxSjrd.ExGridView.Columns["qty"].Caption = "Qty Base";
            gcxSjrd.ExGridView.Columns["qty1"].Caption = "Qty";
            gcxSjrd.ExGridView.Columns["unit"].Caption = "Unit";
            gcxSjrd.ExGridView.Columns["no"].Visible = false;
            gcxSjrd.ExGridView.Columns["Unit Base"].VisibleIndex = casDataSet.sjrd.Columns.IndexOf("qty") + 1;
            DB.SetNumberFormat(gcxSjrd.ExGridView, "n2");

            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
            //tsbtnDelete.Click += new EventHandler(tsbtnDelete_Click);
        } 
       
        protected override void  tsbtnDelete_Click(object sender, EventArgs e)
        {
 	        base.tsbtnDelete_Click(sender, e);
            if (Convert.ToInt32(MasterTable.Rows[MasterBindingSource.Position]["delete"]) == 1)
                DB.sql.Execute("Call SP_Delete('RSK'" + ",'" + NoDocument + "')");
            if (MasterBindingSource.Position == -1)
                tsbtnNew.PerformClick();

            //if (MessageBox.Show("Are you sure you want to delete this item?", "Confirmation",
            //    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            //    MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            //{
            //    string rsk = MasterTable.Rows[MasterBindingSource.Position][0].ToString();

            //    DB.sql.BeginTransaction();

            //    MasterBindingSource.RemoveCurrent();
            //    MasterAdapter.Update(MasterTable);

            //    try
            //    {
            //        //DB.sql.Execute("Call Sp_DelDetailInvoiceRetur('" + rsk + "')");
            //    }
            //    catch (Exception ex)
            //    {
            //        DB.sql.RollbackTransaction();
            //        MessageBox.Show("Delete error: " + ex.Message + ". Transaction is rollbacked!");
            //    }

            //    DB.sql.CommitTransaction();

            //    string jurnal = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
            //    DB.sql.Execute("Call SP_Delete('RSK'" + ",'" + jurnal + "')");

            //    if (MasterBindingSource.Position == -1)
            //    {
            //        //string query = "select * from " + MasterTable.TableName + " where period='" + DB.loginPeriod + "'";
            //        //MasterAdapter = DB.sql.SelectAdapter(query);
            //        //MasterAdapter.Fill(MasterTable);
            //        tsbtnNew.PerformClick();
            //    }
            //}          
        }

        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            PopulateDetails();
        }

        void RePopulate_List_Cbo_Rms()
        {
            dtResult.Clear();

            //add by gita 08/07/08
            //populate Rms to listRms
            listRms.Items.Clear();
            foreach (DataRow drMsl in casDataSet.rsl.Rows)
            {
                if (listRms.Items.IndexOf(drMsl["sjr"]) == -1)
                {
                    listRms.Items.Add(drMsl["sjr"].ToString());
                    DataTable dt = DB.sql.Select("Select * from sjr where rms='" + drMsl["rms"].ToString() + "'");
                    dtResult.ImportRow(dt.Rows[0]);
                }
            }
            //populate listRms to cboRms in Invoice
            RepositoryItemComboBox cboRms = (RepositoryItemComboBox)gcxRsd.ExGridView.Columns["rms"].ColumnEdit;
            cboRms.Items.Clear();
            cboRms.Items.AddRange(listRms.Items);
        }

        private void PopulateDetails()
        {
            try
            {
                bool newEntry = (MasterBindingSource.Position == MasterTable.Rows.Count);
                string query = "";

                // Rsd -> add by gita 08/07/08
                casDataSet.rsd.Clear();
                if (newEntry)
                    query = "select * from rsd where 0";
                else
                    query = "select * from rsd where rsk='" + MasterTable.Rows[MasterBindingSource.Position][0].ToString() + "'";
                rsdAdapter = DB.sql.SelectAdapter(query);
                rsdAdapter.Fill(casDataSet.rsd);
                gcxRsd.ExGridView.BestFitColumns();

                // Rsl
                casDataSet.rsl.Clear();
                if (newEntry)
                    query = "select * from rsl where 0";
                else
                    query = "select * from rsl where rsk='" + MasterTable.Rows[MasterBindingSource.Position][0].ToString() + "'";
                rslAdapter = DB.sql.SelectAdapter(query);
                rslAdapter.Fill(casDataSet.rsl);
                gcxRsl.ExGridView.BestFitColumns();

                RePopulate_List_Cbo_Rms();

                // Sjrd
                casDataSet.sjrd.Clear();
                foreach (DataRow drRsl in casDataSet.rsl.Rows)
                {
                    DataTable dtSjrd = DB.sql.Select("select sjrd.*, inv.unit as `Unit Base` from sjrd, inv where sjrd.inv=inv.inv and sjr='" + drRsl["sjr"] + "'");
                    foreach (DataRow drSjrd in dtSjrd.Rows)                    
                        casDataSet.sjrd.ImportRow(drSjrd);
                }
                gcxSjrd.ExGridView.BestFitColumns();
            }
            catch (Exception ex)
            {
            }
        }

        void gcxRsd_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gcxRsd.ExGridView.GetDataRow(e.RowHandle);
            row["rsk"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
            row["no"] = gcxRsd.ExGridView.RowCount;
        }

        void ExGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "dpp" || e.Column.FieldName == "ppn")
            {
                double dpp = (double)gcxRsd.ExGridView.GetRowCellValue(e.RowHandle, gcxRsd.ExGridView.Columns["dpp"]);
                double ppn = (double)gcxRsd.ExGridView.GetRowCellValue(e.RowHandle, gcxRsd.ExGridView.Columns["ppn"]);
                double val = dpp + ppn;
                gcxRsd.ExGridView.SetRowCellValue(e.RowHandle, gcxRsd.ExGridView.Columns["val"], val);

                ReCalculateTotal();
            }
            else if (e.Column.FieldName == "tglfp")
            {
                //tgl setor faktur pajak = tgl 15 berikutnya setelah tgl faktur pajak
                DateTime tglFP = (DateTime)gcxRsd.ExGridView.GetFocusedRowCellValue("tglfp");
                DateTime tglSetorFP = new DateTime(tglFP.Year, tglFP.Month, 15);
                if (tglFP.Day > 15)
                    tglSetorFP = tglSetorFP.AddMonths(1);
                gcxRsd.ExGridView.SetRowCellValue(e.RowHandle, gcxRsd.ExGridView.Columns["tglsfp"], tglSetorFP);
            }
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            gcxRsd.ExGridView.OptionsBehavior.Editable = true;
            gcxRsd.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

            btnAddRms.Enabled = true;
            btnDeleteRms.Enabled = true;
            nofpTextEdit.EditValue = Utility.GetConfig("SeriFakturPajak");
            tglfpDateEdit.DateTime = DateTime.Now;
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            gcxRsd.ExGridView.OptionsBehavior.Editable = true;
            gcxRsd.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

            btnAddRms.Enabled = true;
            btnDeleteRms.Enabled = true;
        }

        private void FrmTRsk_Load(object sender, EventArgs e)
        {
            dtResult = casDataSet.rms.Clone();

            if (MasterBindingSource.Position == MasterTable.Rows.Count)
            {
                btnAddRms.Enabled = true;
                btnDeleteRms.Enabled = true;
            }
            else
            {
                btnAddRms.Enabled = false;
                btnDeleteRms.Enabled = false;
            }
            Utility.SetSqlInstance(pnlDetail, DB.sql);
            ctrlSub.txtSub.DataBindings.Add("EditValue", rskBindingSource, "sub");
            ctrlSub.txtSub.EditValueChanged += new EventHandler(txtSub_EditValueChanged);
            PopulateDetails();
            Utility.SetNumberFormat(pnlTotal, "n2");
            ReCalculateTotal();

           //curcur.Properties.ReadOnly = true;

            dtBaseUnit = DB.GetBaseUnitTable();
        }

        private void FillRsdSjrd()
        {
            casDataSet.sjrd.Clear();
            casDataSet.rsd.Clear();
            string noPO = "";
            foreach (DataRow sjrRow in casDataSet.rsl.Rows)
            {
                if (sjrRow.RowState != DataRowState.Deleted)
                {
                    noPO = sjrRow["sjr"].ToString();

                    // Add Inventories to Penerimaan Barang
                    DataTable dtSjrd = DB.sql.Select("select sjr, inv, loc, remark, qty, no, qty1, unit"
                        + " from sjrd where sjr='" + sjrRow["sjr"].ToString() + "'");
                    foreach (DataRow sjrdRow in dtSjrd.Rows)
                    {
                        DataRow sjrdNewRow = casDataSet.sjrd.NewRow();
                        foreach (DataColumn sjrdCol in casDataSet.sjrd.Columns)
                        {
                            if (sjrdCol.ColumnName.ToString() == "Unit Base")
                                sjrdNewRow[sjrdCol.ColumnName] = dtBaseUnit.Select("inv='" + sjrdNewRow["inv"].ToString()+ "'")[0]["unit"];
                            else
                                sjrdNewRow[sjrdCol.ColumnName] = sjrdRow[sjrdCol.ColumnName];
                        }
                        casDataSet.sjrd.Rows.Add(sjrdNewRow);
                    }
                    gcxSjrd.ExGridView.BestFitColumns();

                    // Add POs to Invoice Tab                
                    DataRow msdRow = casDataSet.rsd.NewRow();
                    if (casDataSet.rsd.Select("rms='" + noPO + "'").Length > 0)
                        msdRow = casDataSet.rsd.Select("rms='" + noPO + "'")[0];
                    else
                    {
                        msdRow["rsk"] = sjrRow["rsk"];
                        msdRow["no"] = casDataSet.rsd.Rows.Count + 1;
                        msdRow["rms"] = sjrRow["rms"];
                        msdRow["kurs"] = 1;                        
                        msdRow["dpp"] = 0;
                        casDataSet.rsd.Rows.Add(msdRow);
                    }
                    msdRow["dpp"] = Convert.ToDouble(msdRow["dpp"]) + Convert.ToDouble(sjrRow["val"]);
                        msdRow["ppn"] = Convert.ToDouble(msdRow["dpp"]) * 0.1;
                       msdRow["val"] = Convert.ToDouble(msdRow["dpp"]) + Convert.ToDouble(msdRow["ppn"]);
                }
            }

            gcxRsd.ExGridView.BestFitColumns();
        }

        private void btnAddRms_Click(object sender, EventArgs e)
        {
            //FrmDialog rmsDialog = new FrmDialog("PO Retur", DB.sql, "select * from rms where approve=1 and sub='" + ctrlSub.txtSub.Text + "'");
            FrmDialog rmsDialog = new FrmDialog("SJ Retur", DB.sql, "Call SP_SelectforInvoice('RMS','" + ctrlSub.txtSub.Text + "')");

            string PORetur = "";
            if (rmsDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (DataRow rmsRow in rmsDialog.ResultRows)
                {
                    PORetur = rmsRow["SJ_Retur"].ToString();
                    if (dtResult.Rows.Find(PORetur) != null)
                    {
                        //MessageBox.Show("Data sudah ada");
                        return;
                    }
                    DataRow drResult = dtResult.NewRow();
                    drResult["rms"] = PORetur;
                    drResult["date"] = rmsRow["Tanggal"];
                    drResult["remark"] = rmsRow["Keterangan"];
                    drResult["kurs"] = 1;
                    drResult["ppn"] = 0;
                    drResult["sub"] = "";
                    drResult["period"] = "";
                    drResult["cur"] = "";
                    drResult["chtime"] = "";
                    drResult["chusr"] = "";
                    //dtResult.ImportRow(rmsRow);
                    dtResult.Rows.Add(drResult);

                    if (listRms.Items.IndexOf(PORetur) < 0)
                    {
                        listRms.Items.Add(PORetur);

                        string rsk = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
                        //string query = "select '@rsk' as rsk, spm.okl_rms as rms, sjr.sjr, sjr.date, sjr.remark, sum(ind.val) as val, 0 as no " +
                        //    "from sjr, spm, ind where spm.okl_rms='@rms' and sjr.spm=spm.spm and ind.jurnal=sjr.sjr and sjr.sjr not in (select sjr from rsl) group by ind.jurnal";
                        string query = "Call SP_SelectPOSJReturforRSK('@sjr','@rsk')";
                        query = query.Replace("@sjr", PORetur);
                        query = query.Replace("@rsk", rsk);
                        DataTable dtLph = DB.sql.Select(query);

                        foreach (DataRow lphRow in dtLph.Rows)
                        {
                            DataRow mslRow = casDataSet.rsl.NewRow();
                            foreach (DataColumn mslCol in casDataSet.rsl.Columns)
                            {
                                mslRow[mslCol.ColumnName] = lphRow[mslCol.ColumnName];
                            }
                            mslRow["no"] = casDataSet.rsl.Rows.Count + 1;                           
                            casDataSet.rsl.Rows.Add(mslRow);                                                  
                        }
                        gcxRsl.ExGridView.BestFitColumns();
                    }
                }
                FillRsdSjrd();
                ReCalculateTotal();
            }

            RepositoryItemComboBox cboRms = (RepositoryItemComboBox)gcxRsd.ExGridView.Columns["rms"].ColumnEdit;
            cboRms.Items.Clear();
            cboRms.Items.AddRange(listRms.Items);
        }

        private void btnDeleteRms_Click(object sender, EventArgs e)
        {
            if (listRms.SelectedIndex < 0) return;

            // Remove POs from Invoice Tab
            DB.DeleteDetailRows(gcxRsd.ExGridView);

            // Remove Inventories from Penerimaan Barang
            DB.DeleteDetailRows(gcxSjrd.ExGridView);

            DB.DeleteDetailRows(gcxRsl.ExGridView);

            int pos = listRms.SelectedIndex;
            listRms.SelectedIndex = -1;
            //listRms.Items.RemoveAt(listRms.SelectedIndex);
            listRms.Items.RemoveAt(pos);
            dtResult.Rows.Remove(dtResult.Rows[pos]);

            RepositoryItemComboBox cboRms = (RepositoryItemComboBox)gcxRsd.ExGridView.Columns["rms"].ColumnEdit;
            cboRms.Items.Clear();
            cboRms.Items.AddRange(listRms.Items);
        }

        void gcxRsl_tsbtnDelete_Click(object sender, EventArgs e)
        {
            // Remove Inventories from Penerimaan Barang
            DB.DeleteDetailRows(gcxSjrd.ExGridView);

            DB.DeleteDetailRows(gcxRsl.ExGridView);

            FillRsdSjrd();
            ReCalculateTotal();
        }

        void gcxRsd_tsbtnDelete_Click(object sender, EventArgs e)
        {
            DB.DeleteDetailRows(gcxRsd.ExGridView);
        }

        private void txtSub_EditValueChanged(object sender, EventArgs e)
        {
            DataRow row = ctrlSub.txtSub.ExGetDataRow();

            if (row == null)
            {
                curcur.EditValue = "";
                return;
            }

            curcur.EditValue = row["cur"].ToString();
            spinTOP.EditValue = row["top"].ToString();

            if (MasterBindingSource.Position == MasterTable.Rows.Count)
            btnAddRms.PerformClick();
        }

        private void listRms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listRms.SelectedIndex >= 0)
            {
                string rms = listRms.SelectedItem.ToString();
                gcxRsl.UnselectAll();
                for (int i = 0; i < gcxRsl.ExGridView.RowCount; i++)
                {
                    if ((gcxRsl.ExGridView.GetDataRow(i) as DataRow)["rms"].ToString() == rms)
                    {
                        gcxRsl.ExGridView.SelectRow(i);
                    }
                }

                gcxRsd.UnselectAll();
                for (int i = 0; i < gcxRsd.ExGridView.RowCount; i++)
                {
                    if (gcxRsd.ExGridView.GetDataRow(i) == null) return;

                    if ((gcxRsd.ExGridView.GetDataRow(i) as DataRow)["rms"].ToString() == rms)
                        gcxRsd.ExGridView.SelectRow(i);
                }
            }
        }


        void gcxRsl_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            gcxSjrd.UnselectAll();

            int[] selectedIndices = gcxRsl.ExGridView.GetSelectedRows();
            if (selectedIndices == null) return;

            for (int i = 0; i < selectedIndices.Length; i++)
            {
                string lph = (gcxRsl.ExGridView.GetDataRow(selectedIndices[i]) as DataRow)["sjr"].ToString();
                for (int j = 0; j < gcxSjrd.ExGridView.RowCount; j++)
                {
                    if ((gcxSjrd.ExGridView.GetDataRow(j) as DataRow)["sjr"].ToString() == lph)
                        gcxSjrd.ExGridView.SelectRow(j);
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

        void CloseValPO()
        {            
            //foreach (DataRow row in casDataSet.rsd)
            //{
            //    //string query = "select * from lph where oms='" +
            //    //    row["rms"].ToString() + "' and lph not in " +
            //    //    "(select lph from msl where oms='" +  row["rms"].ToString() + "')";
            //    string query = "Call SP_OutSpb('" + row["rms"].ToString() + "')";
            //    DataTable dt = DB.sql.Select(query);
            //    if (dt.Rows.Count == 0)
            //        DB.sql.Execute("update oms set closedval=1 where oms='" + row["rms"].ToString() + "' and closed=1");
            //}
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate controls
                this.ValidateChildren();

                ((DataRowView)MasterBindingSource.Current).Row["duedate"] = ((DateTime)dateDate.EditValue).AddDays(Convert.ToDouble(spinTOP.EditValue));

                if (gcxRsd.ExGridView.EditingValue != null)
                    gcxRsd.ExGridView.SetFocusedValue(gcxRsd.ExGridView.EditingValue);

                if (nofpTextEdit.EditValue.ToString().Trim().Length != 19)
                    throw new Exception("Format no retur faktur pajak tidak valid");

                //loop DetailTable
                foreach (DataRow dr in DetailTable.Rows)
                {
                    if (dr.RowState == DataRowState.Added)
                        DB.sql.Execute("Delete from rsd where rsk='" + NoDocument + "' and rms='" + dr["rms"].ToString() + "'");
                    if (dr.RowState != DataRowState.Deleted && dr != null)
                    {
                       /*if (dr["invo"].ToString() == "")
                            throw new Exception("Harap mengisi no invoice");
                        if ((double)dr["ppn"] > 0 && dr["nofp"].ToString() != "" && dr["tglfp"].ToString() == "")
                            throw new Exception("Harap mengisi tanggal FP");
                        if ((double)dr["ppn"] > 0 && dr["nofp"].ToString() == "")
                            throw new Exception("Harap mengisi nomor Faktur Pajak");*/
                        dr["invo"] = NoDocument;
                        dr["nofp"] = nofpTextEdit.EditValue.ToString();
                        dr["tglfp"] = tglfpDateEdit.EditValue;
                        dr["tglsfp"] = tglsfpDateEdit.EditValue;
                    }
                }

                base.tsbtnSave_Click(sender, e);

                // Update NoDocument
                for (int i = 0; i < casDataSet.rsl.Rows.Count; i++)
                    casDataSet.rsl.Rows[i][0] = NoDocument;

                rslBindingSource.EndEdit();
                rslAdapter.Update(casDataSet.rsl);

                string date = ((DateTime)(dateDate.EditValue)).ToString("yyyyMMdd");
                DB.sql.Execute("Call SP_Save(" + date + ",'RSK'" + ",'" + NoDocument + "')");

                //cek close val PO
                //CloseValPO();

                btnAddRms.Enabled = false;
                btnDeleteRms.Enabled = false;

                // disable all GridControls
                gcxRsd.ExGridView.OptionsBehavior.Editable = false;
                gcxRsd.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected override void tsbtnCancel_Click(object sender, EventArgs e)
        {
            casDataSet.rsl.RejectChanges();
            casDataSet.sjrd.RejectChanges();
            base.tsbtnCancel_Click(sender, e);
            if (this.mode == Mode.View)
            {
             //   RePopulate_List_Cbo_Rms();
                btnAddRms.Enabled = false;
                btnDeleteRms.Enabled = false;
                ReCalculateTotal();

                // disable all GridControls
                gcxRsd.ExGridView.OptionsBehavior.Editable = false;
                gcxRsd.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            }
        }

        private void txtNo_EditValueChanged(object sender, EventArgs e)
        {
            ReCalculateTotal();            
        }

        private void tglfpDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (tglfpDateEdit.EditValue.ToString() != "")
            {
                DateTime tglFP = (DateTime)tglfpDateEdit.EditValue;
                DateTime tglSetorFP = new DateTime(tglFP.Year, tglFP.Month, 15);
                if (tglFP.Day > 15)
                    tglSetorFP = tglSetorFP.AddMonths(1);
                tglsfpDateEdit.DateTime = tglSetorFP;
            }
        }
    }
}