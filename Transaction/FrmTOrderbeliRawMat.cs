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
using DevExpress.XtraReports.UI;
using System.Globalization;
using System.Threading;

namespace CAS.Transaction
{    
    public partial class FrmTOrderbeliRM : CAS.Transaction.BaseTransaction
    {
        private int[] selectedIndex = new int[0];
        private bool isDetailValid = true;
        private bool isDetailChanged = false;
        private double qty1OldValue = 0;
        private double qtyOldValue = 0;
        private DataTable copyDetailTable = new DataTable();
        private double priceOldValue = 0;

        public FrmTOrderbeliRM()
        {
            InitializeComponent();
         //   no_kon.ExSqlQuery = "Call SP_LookUpnokon('" + ctrlSub.txtSub.Text + "')";
            Thread.CurrentThread.CurrentCulture = new CultureInfo("id-ID");
  
            no_kon.ExSqlInstance = DB.sql;
            DetailTable.Columns.Add("Unit Base", typeof(String));
            //DetailTable.Columns.Add("Tgl Dibutuhkan", typeof(String));
            MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);

            gcOmd.ExGridControl.DataSource = omdBindingSource;
            gcOmd.ExTitleLabel.Text = "Purchase Order Detail";

            gcOmd.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
            gcOmd.ExGridView.CellValueChanged += new CellValueChangedEventHandler(ExGridView_CellValueChanged);
            //gcOmd.ExGridView.ValidateRow += new ValidateRowEventHandler(ExGridView_ValidateRow);

            gcOmd.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
            gcOmd.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gcOmd.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
            gcOmd.ExToolStrip.Items["tsbtnNew"].Enabled = false;

            gcOmd.ExGridView.Columns["oms"].OptionsColumn.AllowEdit = false;
            gcOmd.ExGridView.Columns["val"].OptionsColumn.AllowEdit = false;
            //gcOmd.ExGridView.Columns["qty"].OptionsColumn.AllowEdit = false;
            gcOmd.ExGridView.Columns["inv"].OptionsColumn.AllowEdit = true;
            //gcOmd.ExGridView.Columns["remark"].OptionsColumn.AllowEdit = false;
            //gcOmd.ExGridView.Columns["aliasname"].Visible = false;

            gcOmd.ExGridView.Columns["no"].Visible = false;
            gcOmd.ExGridView.Columns["noprd"].Visible = false;
            gcOmd.ExGridView.Columns["oms"].Visible = false;
            gcOmd.ExGridView.Columns["closeitem"].Visible = false;
            gcOmd.ExGridView.Columns["dept"].Visible = false;
            gcOmd.ExGridView.Columns["arrive"].Visible = false;
            gcOmd.ExGridView.Columns["qop"].Visible = false;

            gcOmd.ExGridView.Columns["prq"].ColumnEdit = new GridLookUpEx(DB.sql, "", "prq", "prq", gcOmd.ExGridView, "", true, true, "Purchase Request");
            gcOmd.ExGridView.Columns["prq"].ColumnEdit.Enter += new EventHandler(ExGridView_prqColumnEdit_Enter);
            gcOmd.ExGridView.Columns["prq"].ColumnEdit.KeyPress += new KeyPressEventHandler(ExGridView_prqColumnEdit_KeyPress);  
           
            gcOmd.ExGridView.Columns["inv"].ColumnEdit = new GridLookUpEx(DB.sql, "", "inv", "inv", gcOmd.ExGridView, "", true, true, "Persediaan");
            gcOmd.ExGridView.Columns["inv"].ColumnEdit.Enter += new EventHandler(ExGridView_InvColumnEdit_Enter);
            gcOmd.ExGridView.Columns["remark"].ColumnEdit = new RepositoryItemTextEdit();
            gcOmd.ExGridView.Columns["remark"].ColumnEdit.Enter += new EventHandler(remarkColumnEdit_Enter);
            gcOmd.ExGridView.Columns["loc"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('loc')", "loc", "loc", gcOmd.ExGridView, "", false, false, "Location");
            gcOmd.ExGridView.Columns["cct"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('cct')", "cct", "cct", gcOmd.ExGridView, "", false, false, "Cost Center");
            gcOmd.ExGridView.Columns["cct"].ColumnEdit.Enter += new EventHandler(ExGridView_cctColumnEdit_Enter);
            gcOmd.ExGridView.Columns["acc"].ColumnEdit = new GridLookUpEx(DB.sql, "", "acc", "acc", gcOmd.ExGridView, "", false, false, "Account");
            gcOmd.ExGridView.Columns["acc"].ColumnEdit.Enter += new EventHandler(ExGridView_accColumnEdit_Enter);
            gcOmd.ExGridView.Columns["unit"].ColumnEdit = new GridLookUpUnit(gcOmd.ExGridView);
            gcOmd.ExGridView.Columns["unit"].ColumnEdit.Enter += new EventHandler(unitColumnEdit_Enter);
           // gcOmd.ExGridView.Columns["ino"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('ino')", "ino", "ino", gcOmd.ExGridView, "", true, false, "Internal Order");
            //gcOmd.ExGridView.Columns["ino"].ColumnEdit.Enter += new EventHandler(ExGridView_inoColumnEdit_Enter);
            gcOmd.ExGridView.Columns["rsn"].ColumnEdit = new GridLookUpEx(DB.sql, "Select rsn Reason,remmark as Keterangan from rsn", "rsn", "rsn", gcOmd.ExGridView, "", false, false, "Reason"); ;
            gcOmd.ExGridView.Columns["rsn"].ColumnEdit.KeyPress += new KeyPressEventHandler(ExGridView_rsnColumnEdit_KeyPress);

           
            gcOmd.ExGridView.Columns["qty1"].ColumnEdit = new GridNumEx();
            //gcOmd.ExGridView.Columns["qty1"].ColumnEdit.EditValueChanging += new ChangingEventHandler(qty1ColumnEdit_EditValueChanging);
            gcOmd.ExGridView.Columns["qty1"].ColumnEdit.Enter += new EventHandler(qty1ColumnEdit_Enter);
            gcOmd.ExGridView.Columns["qty"].ColumnEdit = new GridNumEx();
            gcOmd.ExGridView.Columns["price"].ColumnEdit = new GridNumEx(500);
            gcOmd.ExGridView.Columns["price"].ColumnEdit = new GridLookUpEx(DB.sql, "select * from hbl order by tanggal desc", "hbl", "inv", gcOmd.ExGridView, "price", true, true, "Price");
            gcOmd.ExGridView.Columns["price"].ColumnEdit.Enter += new EventHandler(ExGridView_priceColumnEdit_Enter);
            gcOmd.ExGridView.Columns["price"].ColumnEdit.EditValueChanging += new ChangingEventHandler(priceColumnEdit_EditValueChanging);
            gcOmd.ExGridView.Columns["disc"].ColumnEdit = new GridNumEx();
            gcOmd.ExGridView.Columns["toleransi"].ColumnEdit = new GridNumEx();
            gcOmd.ExGridView.Columns["per"].ColumnEdit = new GridNumEx(400);
            gcOmd.ExGridView.Columns["per"].ColumnEdit = new GridNumEx();

            gcOmd.ExGridView.OptionsBehavior.Editable = false;
            //gcOmd.ExGridView.OptionsView.ColumnAutoWidth = true;
            gcOmd.ExGridView.OptionsSelection.MultiSelect = true;
            gcOmd.ExGridView.OptionsCustomization.AllowSort = false;
            gcOmd.ExGridView.OptionsView.ShowGroupPanel = false;

            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            //tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
        //    gcOmd.ExGridView.Columns["ino"].VisibleIndex = 3;
            gcOmd.ExGridView.Columns["cct"].VisibleIndex = 16;
            gcOmd.ExGridView.Columns["acc"].VisibleIndex = 17;

            gcOmd.ExGridView.Columns["prq"].Caption = "Purchase Request";
            gcOmd.ExGridView.Columns["inv"].Caption = "Kode Barang";
            gcOmd.ExGridView.Columns["noprd"].Caption = "No Item PR";
            gcOmd.ExGridView.Columns["remark"].Caption = "Nama Barang";
            gcOmd.ExGridView.Columns["loc"].Caption = "Loc";
            gcOmd.ExGridView.Columns["qty"].Caption = "Qty Base";
            gcOmd.ExGridView.Columns["unit"].Caption = "Unit";
            gcOmd.ExGridView.Columns["qty1"].Caption = "Qty";
            gcOmd.ExGridView.Columns["per"].Caption = "Per";
            gcOmd.ExGridView.Columns["cct"].Caption = "Cost Center";
            gcOmd.ExGridView.Columns["acc"].Caption = "Kode Transaksi";
            gcOmd.ExGridView.Columns["price"].Caption = "Price";
            gcOmd.ExGridView.Columns["disc"].Caption = "Disc(%)";
            gcOmd.ExGridView.Columns["val"].Caption = "Val";
            gcOmd.ExGridView.Columns["etd"].Caption = "Keterangan";
            gcOmd.ExGridView.Columns["rsn"].Caption = "Reason";
            gcOmd.ExGridView.Columns["toleransi"].Caption = "Tol(%)";
            gcOmd.ExGridView.Columns["dateneed"].Caption = "Tgl Dibutuhkan";
           // gcOmd.ExGridView.Columns[0].f= "HH: mm: ss.fff";
      
            gcOmd.ExGridView.Columns["qty"].VisibleIndex = 22;
            gcOmd.ExGridView.Columns["per"].VisibleIndex = DetailTable.Columns.IndexOf("price") - 3; 
            gcOmd.ExGridView.Columns["Unit Base"].VisibleIndex = 20;
            gcOmd.ExGridView.Columns["Unit Base"].OptionsColumn.AllowEdit = false;
            //gcOmd.ExGridView.Columns["Tgl Dibutuhkan"].OptionsColumn.AllowEdit = false;

            DB.SetNumberFormat(gcOmd.ExGridView, "n2");

            spinTOP.Properties.MinValue = 0;
            spinTOP.Properties.MaxValue = Int32.MaxValue;

            tsbtnPrint.Click += new EventHandler(tsbtnPrint_Click);
        }

        void priceColumnEdit_EditValueChanging(object sender, ChangingEventArgs e)
        {
            priceOldValue = Convert.ToDouble(e.OldValue);
        }

        void ExGridView_inoColumnEdit_Enter(object sender, EventArgs e)
        {
            if (gcOmd.ExGridView.GetFocusedRowCellValue("inv") != null)
            {
                string kodeBarang = gcOmd.ExGridView.GetFocusedRowCellValue("inv").ToString();
                if (kodeBarang.Substring(0, 3) == "900")
                {
                    ((ButtonEdit)sender).Enabled = true;
                    string query = "Call SP_LookUp('ino')";
                    ((GridLookUpEx)gcOmd.ExGridView.Columns["ino"].ColumnEdit).Query = query;
                }
                else
                    ((ButtonEdit)sender).Enabled = false;
            }
        }

        void ExGridView_priceColumnEdit_Enter(object sender, EventArgs e)
        {
            //if (gcOmd.ExGridView.GetFocusedRowCellValue("inv") != null)
            //{
            //    string kodeBarang = gcOmd.ExGridView.GetFocusedRowCellValue("inv").ToString();
            //    string query = "Select * from hbl where inv = '" + kodeBarang + "' order by tanggal desc";
            //    (gcOmd.ExGridView.Columns["price"].ColumnEdit as GridLookUpEx).Query = query;
                
            //}
        }

        void tsbtnPrint_Click(object sender, EventArgs e)
        {
            if (Convert.ToUInt64(((DataRowView)MasterBindingSource.Current).Row["aprov"]) == 1)
            {
                string path = Application.StartupPath + "\\Reports\\" + "RepPO1" + ".repx";
                XtraReport report = new XtraReport();
                report.LoadState(path);
                DataTable dt = DB.sql.Select("Call SP_Print('Transaction.FrmTOrderbeli','" + this.NoDocument + "')");
                DataTable dtRep = dt.Clone();
                dtRep.Columns.Add("pageno", typeof(string));
                //report.DataSource = DB.sql.Select("Call SP_Print('" + this.Name + "','" + this.NoDocument + "')");
                int recordsCount = 0;
                int pageno = 1;
                DataRow drRep;
                double subtotal = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    recordsCount++;
                    string remark = dr["remark"].ToString() + " - " + dr["etd"].ToString();
                    //1 row kolom nama barang max 30 karakter
                    while (remark.Length > 30)
                    {
                        recordsCount++;
                        remark = remark.Substring(0, 30);
                    }
                    if ((recordsCount > 41 && pageno == 1) || (recordsCount > 40 && pageno > 1))
                    {
                        pageno++;
                        recordsCount = 1;
                    }
                    //saldo dipindahkan
                    if (pageno > 1 && recordsCount == 1)
                    {
                        drRep = dtRep.NewRow();
                        drRep["remark"] = "Dipindahkan";
                        drRep["val"] = subtotal;
                        drRep["pageno"] = pageno;
                        dtRep.Rows.Add(drRep);
                        recordsCount++;
                    }
                    drRep = dtRep.NewRow();
                    foreach (DataColumn col in dt.Columns)
                        drRep[col.ColumnName] = dr[col.ColumnName];
                    drRep["pageno"] = pageno;
                    dtRep.Rows.Add(drRep);
                    subtotal = subtotal + Convert.ToDouble(dr["val"]);
                }
                report.DataSource = dtRep;
                report.Controls[6].Controls["lblUser"].Text = DB.casUser.Name;
                report.Controls[6].Controls["xrLblTotalPage"].Text = pageno.ToString();
                report.ShowPreview();
                //report.RunDesigner();
            }
            else
                MessageBox.Show("PO belum di-approve");
        }

        void unitColumnEdit_Enter(object sender, EventArgs e)
        {
            qtyOldValue = Convert.ToDouble(gcOmd.ExGridView.GetFocusedRowCellValue("qty"));
        }

        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
            //DetailTable = DB.PopulateDateNeed(DetailTable, "Tgl Dibutuhkan");
        }

        void ExGridView_cctColumnEdit_Enter(object sender, EventArgs e)
        {
            if (gcOmd.ExGridView.GetFocusedRowCellValue("inv") != null)
            {
                string kodeBarang = gcOmd.ExGridView.GetFocusedRowCellValue("inv").ToString();
                if (DB.isBiaya(kodeBarang) && kodeBarang.Substring(0,3)!="900" )
                    ((ButtonEdit)sender).Enabled = true;
                else
                    ((ButtonEdit)sender).Enabled = false;
            }
            else
                ((ButtonEdit)sender).Enabled = false;
        }

        void ExGridView_accColumnEdit_Enter(object sender, EventArgs e)
        {
            if (gcOmd.ExGridView.GetFocusedRowCellValue("cct") != null)
            {
                string cct = gcOmd.ExGridView.GetFocusedRowCellValue("cct").ToString();
                string kodeBarang = gcOmd.ExGridView.GetFocusedRowCellValue("inv").ToString();
                if (DB.isBiaya(kodeBarang))
                {
                    ((GridLookUpEx)gcOmd.ExGridView.Columns["acc"].ColumnEdit).Query = "Call SP_LookUpCca('" + (string)gcOmd.ExGridView.GetFocusedRowCellValue("cct") + "')";
                    ((ButtonEdit)sender).Enabled = true;
                }
                else
                {
                    ((GridLookUpEx)gcOmd.ExGridView.Columns["acc"].ColumnEdit).Query = "";
                    ((ButtonEdit)sender).Enabled = false;
                }
            }
            else
            {
                ((GridLookUpEx)gcOmd.ExGridView.Columns["acc"].ColumnEdit).Query = "";
                ((ButtonEdit)sender).Enabled = false;
            }
        }

        void qty1ColumnEdit_Enter(object sender, EventArgs e)
        {
            DetailBindingSource.EndEdit();
            if (gcOmd.ExGridView.FocusedRowHandle >= 0)
            {
                //qty1OldValue = Convert.ToDouble((sender as DevExpress.XtraEditors.SpinEdit).EditValue);
                if (DetailTable.Rows[gcOmd.ExGridView.FocusedRowHandle].RowState != DataRowState.Added &&
                    DetailTable.Rows[gcOmd.ExGridView.FocusedRowHandle].RowState != DataRowState.Deleted)
                    qtyOldValue = Convert.ToDouble(gcOmd.ExGridView.GetFocusedRowCellValue("qty"));
                else
                    qtyOldValue = 0;
            }
            else
                qtyOldValue = 0;
        }

        //void qty1ColumnEdit_EditValueChanging(object sender, ChangingEventArgs e)
        //{
        //    if (e.NewValue.ToString() != "")
        //    {
        //        if (Convert.ToDouble(e.NewValue) < Convert.ToDouble(qty1OldValue))
        //            e.NewValue = qty1OldValue;
        //        else if (Convert.ToDouble(e.NewValue) > Convert.ToDouble(qty1OldValue))
        //            isDetailChanged = true;
        //    }
        //}

        void ExGridView_InvColumnEdit_Enter(object sender, EventArgs e)
        {
            if (gcOmd.ExGridView.GetFocusedRowCellValue("prq") == null)
                (gcOmd.ExGridView.Columns["inv"].ColumnEdit as GridLookUpEx).Query = "Call SP_LookUp('inv')";
            else if (gcOmd.ExGridView.GetFocusedRowCellValue("prq").ToString().Trim() == "")
                (gcOmd.ExGridView.Columns["inv"].ColumnEdit as GridLookUpEx).Query = "Call SP_LookUp('inv')";
            else
            {
                string query = "Call SP_SelectPRforPO(" + ((DateTime)dateDate.EditValue).ToString("yyyyMMdd") + ")";
                (gcOmd.ExGridView.Columns["inv"].ColumnEdit as GridLookUpEx).Query = query;
                //(gcOmd.ExGridView.Columns["inv"].ColumnEdit as GridLookUpEx).Query = "select * from inv where inv=null";
            }  
                      
        }       

        void ExGridView_prqColumnEdit_Enter(object sender, EventArgs e)
        {
            if (jenispoRadioGroup.SelectedIndex ==1)
            {
                string query = "Call SP_SelectPRforPOIT(" + ((DateTime)dateDate.EditValue).ToString("yyyyMMdd") + ")";
                ((GridLookUpEx)gcOmd.ExGridView.Columns["prq"].ColumnEdit).Query = query;
                gcOmd.ExGridView.SetFocusedRowCellValue(gcOmd.ExGridView.Columns["dateneed"], ((DateTime)dateDate.EditValue).AddDays(2));
            }
            else
            {
                string query = "Call SP_SelectPRforPO(" + ((DateTime)dateDate.EditValue).ToString("yyyyMMdd") + ")";
                ((GridLookUpEx)gcOmd.ExGridView.Columns["prq"].ColumnEdit).Query = query;
                gcOmd.ExGridView.SetFocusedRowCellValue(gcOmd.ExGridView.Columns["dateneed"], ((DateTime)dateDate.EditValue).AddDays(2));
         
            }
        }

        void ExGridView_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            DetailBindingSource.EndEdit();
            DataRow row = ((DataRowView)e.Row).Row;
            string prq = (string)row["prq"];
            int noprd = Convert.ToInt32(row["noprd"]);

            //cek duplicate entry on detail
            for (int i = 0; i < DetailTable.Rows.Count; i++)
            {
                DataRow dr = gcOmd.ExGridView.GetDataRow(i);
                if (dr != null && dr.RowState != DataRowState.Deleted)
                {
                    if (e.RowHandle != i && (string)dr["prq"] == prq && Convert.ToInt32(dr["noprd"]) == noprd)
                    {
                        e.Valid = false;
                        e.ErrorText = "Duplicate entry";
                        isDetailValid = false;
                        return;
                    }
                }
            }
        }       

        void ExGridView_New_Click(object sender, EventArgs e)
        {
            DataRow row = casDataSet.omd.NewRow();
            row["oms"] = NoDocument;
            row["qty"] = 0;
            row["qty1"] = 0;
            row["per"] = 0;
            row["inv"] = "";
            row["loc"] = "";
            row["unit"] = "";
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            casDataSet.omd.Rows.Add(row);

            DB.InsertDetailRows(gcOmd.ExGridView, row);

            qtyOldValue = 0;
            priceOldValue = 0;
        
        }

        void ExGridView_Delete_Click(object sender, EventArgs e)
        {
            try
            {

                string nopr1 = "";
                bool canDeleteitem, canDelete = true;
                int[] selectedIndex = gcOmd.ExGridView.GetSelectedRows();
                for (int i = 0; i < selectedIndex.Length; i++)
                {
                    nopr1 = gcOmd.ExGridView.GetDataRow(selectedIndex[i])["prq"].ToString();
                    string prq = gcOmd.ExGridView.GetDataRow(selectedIndex[i])["oms"].ToString();
                    int no = Convert.ToInt32(gcOmd.ExGridView.GetDataRow(selectedIndex[i])["no"]);
                    canDeleteitem = DeleteLineItem(prq, no);
                    if (canDeleteitem == false) canDelete = false;
                }
                if (canDelete) DB.DeleteDetailRows(gcOmd.ExGridView);

                //cek close PR   
                DB.sql.Execute("update prq set close=0 where prq='" + nopr1.ToString() + "'");

                //string oms = ludSeri.EditValue.ToString() + "-" + txtPeriod.EditValue.ToString() + "-" + txtNo.EditValue.ToString();
                //if (!isEditAllowed(oms))
                //{
                //    MessageBox.Show("Delete item PO tidak diperbolehkan karena sudah ada SPB!");
                //    return;
                //}
                //DB.DeleteDetailRows(gcOmd.ExGridView);
                //ReCalculateTotal();
            }
            catch
            { 
            }

        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            if (this.mode == Mode.Edit)
            {
                //txtSubtotal.Properties.ReadOnly = true;
                //txtPPN.Properties.ReadOnly = true;
                //txtTotal.Properties.ReadOnly = true;
                gcOmd.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
                gcOmd.ExToolStrip.Items["tsbtnNew"].Enabled = true;
                gcOmd.ExGridView.OptionsBehavior.Editable = true;
                gcOmd.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                //curcur.Properties.ReadOnly = true;
                isDetailValid = true;
                ctrlSub.ReadOnly = false;
                priceOldValue = 0;
                qtyOldValue = 0;
                copyDetailTable.Clear();
                copyDetailTable = DetailTable.Copy();

                Utility.SetReadOnly(txtSubtotal, true);
                Utility.SetReadOnly(txtPPN, true);
                Utility.SetReadOnly(txtTotal, true);
            }
        }

        protected override void tsbtnCancel_Click(object sender, EventArgs e)
        {
            DB.CancelDetailRows(DetailTable);
            remarkMemoEdit.Focus();
            //txtPPN.Leave();
            //txtTotal.Leave();
            if (this.mode != Mode.View)
            {
                ClosePR();
            }
            base.tsbtnCancel_Click(sender, new EventArgs());

            if (this.mode == Mode.View)
            {
                ReCalculateTotal();

                gcOmd.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                gcOmd.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                gcOmd.ExGridView.OptionsBehavior.Editable = false;
                gcOmd.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;

                isDetailValid = true;
                ctrlSub.ReadOnly = true;
                isDetailChanged = false;

                DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
                //DetailTable = DB.PopulateDateNeed(DetailTable, "Tgl Dibutuhkan");
            }
          
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            DetailTable.Clear();
            gcOmd.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcOmd.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcOmd.ExGridView.OptionsBehavior.Editable = true;
            gcOmd.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            ReCalculateTotal();
            isDetailValid = true;
            ctrlSub.ReadOnly = false;
            isDetailChanged = false;
            cbPPN.Checked = true;

            priceOldValue = 0;
            qtyOldValue = 0;
            curcur.EditValue="";
            Utility.SetReadOnly(txtSubtotal, true);
            Utility.SetReadOnly(txtPPN, true);
            Utility.SetReadOnly(txtTotal, true);
            jenispoRadioGroup.SelectedIndex = 0;
        }

        void ClosePR()
        {
            //cek close PR
            for (int i=0; i< DetailTable.Rows.Count; i++)
            {
                if (DetailTable.Rows[i].RowState != DataRowState.Deleted)
                {
                    if (DetailTable.Rows[i]["prq"].ToString() != "")
                    {
                        DataTable dt = DB.sql.Select("Call SP_SelectToClosePRonPO('" +
                             DetailTable.Rows[i]["prq"].ToString() + "')");
                        if (dt.Rows.Count == 0)
                            DB.sql.Execute("update prq set close=1 where prq='" + DetailTable.Rows[i]["prq"].ToString() + "'");
                    }
                }
            }
        }

        protected override void tsbtnDelete_Click(object sender, EventArgs e)
        {
            base.tsbtnDelete_Click(sender, e);
            if (Convert.ToInt32(MasterTable.Rows[MasterBindingSource.Position]["delete"]) == 1)
            {
                DB.sql.Execute("Call SP_Delete('OMS','" + NoDocument + "')");
                DB.sql.Execute("Call SP_OpenTransaction('OMS','" + NoDocument + "')");
            }
        }

        private bool isPRClosed(string noPR)
        {
            DataTable dt = DB.sql.Select("select `close` from prq where prq='" + noPR + "'");
            if (dt.Rows.Count != 0)
            {
                if (Convert.ToInt16(dt.Rows[0][0]) == 1)
                    return true;
            }
            return false;
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            remarkMemoEdit.Focus();
            string pinv, premark, psub, psubname, psatuan, pno_po, pcur, pchusr, pchtime;
            double pprice, pdisc;
            DateTime ptanggal;
            DataRow row1 = ctrlSub.txtSub.ExGetDataRow();
            try
            {
                this.ValidateChildren();
                if (gcOmd.ExGridView.EditingValue != null)
                    gcOmd.ExGridView.SetFocusedValue(gcOmd.ExGridView.EditingValue);

                if (ctrlSub.txtSub.EditValue.ToString() == "")
                    throw new Exception("Harap mengisi Supplier!");
                if (curkurs.EditValue.ToString() == "0" || curkurs.EditValue.ToString() == "")
                    throw new Exception("Harap mengisi Kurs!");
                if (curcur.EditValue.ToString() == "")
                    throw new Exception("Harap mengisi Currency!");
                if (personTextBoxEx.EditValue.ToString() == "")
                    throw new Exception("Harap mengisi Nama Pemesan!");

                DetailBindingSource.EndEdit();

                double totVal = 0;
                for (int i = DetailTable.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = DetailTable.Rows[i];
                    
                    if (row != null && row.RowState != DataRowState.Deleted)
                    {
                        pinv = row["inv"].ToString();
                        premark = row["remark"].ToString();
                        premark = premark.Replace("'", "''");
                        psub = ctrlSub.txtSub.Text;
                        psubname = row1["nama"].ToString();
                        psubname = psubname.Replace("'", "''");
                        psatuan = row["unit"].ToString();
                        pno_po = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
                        pcur = curcur.Text;
                        pchusr = DB.casUser.Name;
                        pchtime = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                        pprice = Convert.ToDouble(row["price"].ToString().Replace(",","."));
                        pdisc = Convert.ToDouble(row["disc"].ToString());
                        ptanggal = Convert.ToDateTime(dateDate.Text);

                      //  DB.sql.Execute("Call SP_SaveToHBL('" + pinv + "','" + premark + "','" + psub + "','" + psubname + "'," + pprice + ",'" + psatuan + "','" + pno_po + "'," + ptanggal.ToString("yyyyMMdd HH:mm") + ",'" + pcur + "'," + pdisc + ",'" + pchusr + "','" + pchtime + "')");
                        //cek cct & account u/ biaya
                        if (DB.isBiaya(row["inv"].ToString()) && row["inv"].ToString().Substring(0, 3) != "900" &&
                           (row["cct"].ToString() == "" || row["acc"].ToString() == ""))
                            throw new Exception("Harap mengisi Cost Center dan Account untuk Material Biaya");

                        if (row["dateneed"].ToString() == "")
                            throw new Exception("Harap mengisi Tanggal dibutuhkan");

                        row[0] = NoDocument;
                        //check if PR is closed on new record
                        if (mode == Mode.New && row["prq"].ToString() != "" && isPRClosed(row["prq"].ToString()))
                            throw new Exception("PR: " + row["prq"].ToString() + " sudah close");
                        totVal = totVal + (double)row["val"];
                        if (Convert.ToDouble(row["val"]) == 0)
                            throw new Exception("Harap mengisi price dan quantity");

                        string inv = row["inv"].ToString();
                        string remark = row["remark"].ToString().Replace("'", "''");
                     
                        // reason
                        string lastprice = "select sub.name,oms.oms,(price*oms.kurs)/if(per=0,1,per) as price from omd,oms,sub where omd.oms=oms.oms and oms.oms<>'" + NoDocument.ToString() + "' and oms.sub=sub.sub and omd.inv='" + inv + "' and trim(omd.remark)='" + remark + "' order by oms.date desc limit 1";
                        DataTable dtlastprice = DB.sql.Select(lastprice);
                        if (dtlastprice.Rows.Count > 0 && row != null && row.RowState != DataRowState.Deleted)
                        {
                            if (gcOmd.ExGridView.GetFocusedRowCellValue("rsn").ToString().Trim() == "")
                            {
                                double lastpriced = Convert.ToDouble(dtlastprice.Rows[0]["price"]) * 1.25;
                                double price = (double)gcOmd.ExGridView.GetFocusedRowCellValue("price") * (double)curkurs.Value / (double)gcOmd.ExGridView.GetFocusedRowCellValue("per");
                                if (lastpriced <= price)
                                {
                                    //     string message = "anda harus menginputkan reason," + dtlastprice.Rows[0]["name"].ToString() + " nomor PO " + dtlastprice.Rows[0]["oms"].ToString() + " harganya " + dtlastprice.Rows[0]["price"].ToString + "";
                                    string message = "Harga pembelian terakhir Supplier " + dtlastprice.Rows[0]["name"].ToString() + " nomor PO " + dtlastprice.Rows[0]["oms"].ToString() + " harganya ";
                                    message = message + String.Format("{0:n2}", (double)dtlastprice.Rows[0]["price"]) + ", silahkan memilih reason untuk melanjutkan";
                                    MessageBox.Show(message);
                                    gcOmd.ExGridView.SetFocusedRowCellValue(gcOmd.ExGridView.Columns["rsn"], "");
                                    FrmDialog frmDialog = new FrmDialog("Master Reason", DB.sql, "select * from rsn where aktif=1", "boxbuttonfalse");
                                    //frmDialog.ShowDialog();
                                    if (frmDialog.ShowDialog() == DialogResult.OK)
                                    {
                                        frmDialog.ControlBox = false;
                                        //  gcOmd.ExGridView.SetFocusedRowCellValue(gcOmd.ExGridView.Columns["rsn"], frmDialog.ResultRows[0][0].ToString());
                                        row["rsn"] = frmDialog.ResultRows[0][0].ToString();

                                    }

                                }
                            }
                            if (Convert.ToDouble(dtlastprice.Rows[0]["price"]) * 1.25 > (double)gcOmd.ExGridView.GetFocusedRowCellValue("price"))
                            {
                                //  gcOmd.ExGridView.SetFocusedRowCellValue(gcOmd.ExGridView.Columns["rsn"], "");
                                row["rsn"] = "";
                            }
                        }
                        //check price validity
                        //harga untuk material yg sama harus sama
                         DataRow[] drDetail = DetailTable.Select("inv='" + inv + "' and remark='" + remark + "'");
                        for (int j = 0; j < drDetail.Length; j++)
                        {
                            if (drDetail[j] != null && drDetail[j].RowState != DataRowState.Deleted)
                            {
                                if (Convert.ToDouble(row["price"]) != Convert.ToDouble(drDetail[j]["price"]))
                                    throw new Exception("Price untuk material: " + inv + "-" + remark + " tidak sama");
                            }
                        }
                        if (no_kon.Text == "")
                        {
                            DataTable dt = DB.sql.Select("Call SP_LookUpnokon('" + ctrlSub.txtSub.Text+"','" + inv + "','3')");
                            if (dt.Rows.Count > 0 && inv != "")
                            {
                                if (MessageBox.Show("Barang " + inv + "-" + remark.Trim() + " sudah ada di kontrak " + dt.Rows[0]["vpo"].ToString() + " qty=" + dt.Rows[0]["qty"].ToString()+" Anda ingin memakainya ?" ,
                                "Confirmation",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                                {
                                    no_kon.EditValue = dt.Rows[0]["vpo"].ToString();
                                    return;
                                }
                            }
                        }
                    }
                }
                
                ((DataRowView)MasterBindingSource.Current).Row["val"] = totVal;
                ((DataRowView)MasterBindingSource.Current).Row["duedate"] = ((DateTime)dateDate.EditValue).AddDays(Convert.ToDouble(spinTOP.EditValue));
                //((DataRowView)MasterBindingSource.Current).Row["jenispo"] = Convert.ToInt32(jenispoRadioGroup.Text);
                ((DataRowView)MasterBindingSource.Current).Row["aprov"] = aprovCheckBox.Checked ;
                ((DataRowView)MasterBindingSource.Current).Row["group_"] = 2;

                //jika mode=edit & PO sudah approve, qty1 & price diubah, set approv & closed = 0
                //if (isDetailChanged && MasterBindingSource.Position != MasterTable.Rows.Count)
                //{
                //    ((DataRowView)MasterBindingSource.Current).Row["aprov"] = Convert.ToInt64(true);
                //    ((DataRowView)MasterBindingSource.Current).Row["close"] = Convert.ToInt64(false);
                //}

                // added & modified by rendra (08/12/2010)
               //double limit = Convert.ToDouble(row1["Limit"]);
               //if (totVal > limit && limit != 0 && !DB.casUser.AllowApprove(this.Tag.ToString()))
               // {
               //     ((DataRowView)MasterBindingSource.Current).Row["aprov"] = Convert.ToInt64(false);
               //     MessageBox.Show("Total is greater than Supplier Limit (" + limit.ToString("n") + ")\n\rContact Supervisor for Approving");
               // }
          //      else
          //          ((DataRowView)MasterBindingSource.Current).Row["aprov"] = Convert.ToInt64(true);

                if (DB.casUser.AllowApprove(this.Tag.ToString()) == false)
                {
                    ((DataRowView)MasterBindingSource.Current).Row["aprov"] = Convert.ToInt64(false);
               //     ((DataRowView)MasterBindingSource.Current).Row["close"] = Convert.ToInt64(false);
                }
 
                base.tsbtnSave_Click(sender, e);
                if (this.mode == Mode.View)
                {
                    DB.sql.Execute("Call SP_Save(00000000, 'OMS','" + NoDocument + "')");
                    ClosePR();
                    gcOmd.ExGridView.OptionsBehavior.Editable = false;
                    gcOmd.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                    gcOmd.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                    gcOmd.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                    ctrlSub.ReadOnly = true;
                    isDetailChanged = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void ReCalculateTotal()
        {
            DetailBindingSource.EndEdit();

            double subTotal = 0;
            for (int i = 0; i < DetailTable.Rows.Count; i++)
            {
                if (DetailTable.Rows[i] != null && DetailTable.Rows[i].RowState != DataRowState.Deleted)
                {
                    subTotal = subTotal + (double)DetailTable.Rows[i]["val"];
                }           
            }
            txtSubtotal.EditValue = subTotal;

            double disc = subTotal * (Convert.ToDouble(spinDisc.EditValue)) / 100;
            txtDisc.EditValue = disc;

            double ppn = 0;
            if (cbPPN.Checked)
                ppn = (subTotal - disc) * 0.1;
            txtPPN.EditValue = ppn;

            double total = subTotal - disc + ppn;
            txtTotal.EditValue = total;
        }

        private bool isEditAllowed(string oms, int no)
        {
            string query = "Select FCanDeleteLineItem('" + DetailTable.TableName.ToString() + "','" + oms + "'," + no.ToString() + ")";
            if (DB.sql.Select(query).Rows[0][0].ToString() == "False")
                return false;
            else
                return true;
            //string query = "select d.* from spb b, spbd d where b.spb = d.spb and b.aprov=1 and b.oms='" + oms + "' and d.inv='" + inv + "' and d.remark='" + remark + "'";
            //DataTable dt = DB.sql.Select(query);
            //if (dt.Rows.Count > 0)
            //    return false;
            //return true;
        }

        void ExGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "price" || e.Column.FieldName == "disc" || e.Column.FieldName == "per")
            {
                if (e.Column.FieldName == "price")
                {
                    string oms = ludSeri.EditValue.ToString() + "-" + txtPeriod.EditValue.ToString() + "-" + txtNo.EditValue.ToString();
                    string inv = (string)gcOmd.ExGridView.GetFocusedRowCellValue("inv");
                    int no = Convert.ToInt32(gcOmd.ExGridView.GetFocusedRowCellValue("no"));
                    double oldPrice = 0;
                    try
                    {
                        DataRow drCopyDetailTable;
                        drCopyDetailTable = copyDetailTable.Select("no=" + no.ToString())[0];
                        oldPrice = Convert.ToDouble(drCopyDetailTable["price"]);
                    }
                    catch { };
                    //if oldPrice = 0 -> new detail item
                    if (oldPrice != 0 && oldPrice != Convert.ToDouble(e.Value))
                    {
                        if (!isEditAllowed(oms, no))
                        {
                            MessageBox.Show("Edit item PO tidak diperbolehkan karena sudah ada SPB!");
                            gcOmd.ExGridView.SetFocusedRowCellValue(gcOmd.ExGridView.Columns["price"], Convert.ToDouble(oldPrice));
                            return;
                        }
                        else
                            isDetailChanged = true;
                    }
                }

                double price = (double)gcOmd.ExGridView.GetFocusedRowCellValue("price");
                double per = (double)gcOmd.ExGridView.GetFocusedRowCellValue("per");
                if (per == 0)
                    per = 1;

                double qty1 = (double)gcOmd.ExGridView.GetFocusedRowCellValue("qty1");
                double disc = (double)gcOmd.ExGridView.GetFocusedRowCellValue("disc");
                double val = (price / per) * qty1 * ((100 - disc) / 100);
                gcOmd.ExGridView.SetFocusedRowCellValue(gcOmd.ExGridView.Columns["val"], val);

                ReCalculateTotal();
            }
            else if ( e.Column.FieldName == "unit" || e.Column.FieldName == "qty1")
            {
                DetailBindingSource.EndEdit();
                string inv = (string)gcOmd.ExGridView.GetFocusedRowCellValue("inv");
                string unit = (string)gcOmd.ExGridView.GetFocusedRowCellValue("unit");
                double qty1 = (double)gcOmd.ExGridView.GetFocusedRowCellValue("qty1");
                if (inv != "" && unit != "")
                   gcOmd.ExGridView.SetFocusedRowCellValue(gcOmd.ExGridView.Columns["qty"], DB.GetQtyInBaseUom(inv, unit, qty1));
                DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
                //ExGridView_ValidateRow(sender, new ValidateRowEventArgs(gcOmd.ExGridView.FocusedRowHandle, gcOmd.ExGridView.GetRow(gcOmd.ExGridView.FocusedRowHandle)));

                if (mode == Mode.Edit)
                {
                   //if (!isEditAllowed(NoDocument))
                   //{
                   //    MessageBox.Show("Edit item PO tidak diperbolehkan karena sudah ada SPB!");
                   //    DetailTable.RejectChanges();
                   //    return;
                   //}
                   //else
                   //{
                       //edit qty PO ke 
                       //double qty = Convert.ToDouble(gcOmd.ExGridView.GetFocusedRowCellValue("qty"));
                       //if (qty < qtyOldValue)
                       //{
                       //    MessageBox.Show("Qty tidak valid!");
                       //    gcOmd.ExGridView.SetFocusedRowCellValue(gcOmd.ExGridView.Columns["qty1"], DB.GetQtyInAlternativeUom(inv, unit, qtyOldValue));
                       //    ReCalculateTotal();
                       //    return;
                       //}
                   //}

                }

                if (e.Column.FieldName == "qty1")
                {
                    isDetailChanged = true;
                    double price = (double)gcOmd.ExGridView.GetFocusedRowCellValue("price");
                    double per = (double)gcOmd.ExGridView.GetFocusedRowCellValue("per");
                    if (per == 0)
                        per = 1;
                    double disc = (double)gcOmd.ExGridView.GetFocusedRowCellValue("disc");
                    double val = (price / per) * qty1 * ((100 - disc) / 100);
                    gcOmd.ExGridView.SetFocusedRowCellValue(gcOmd.ExGridView.Columns["val"], val);
                    ReCalculateTotal();
                }

            }
            else if (e.Column.FieldName == "qty")
            {
                string inv = (string)gcOmd.ExGridView.GetFocusedRowCellValue("inv");
                string unit = (string)gcOmd.ExGridView.GetFocusedRowCellValue("unit");
                double qty = (double)e.Value;
                double qty1 = (double)gcOmd.ExGridView.GetFocusedRowCellValue("qty1");
                if (DB.GetQtyInAlternativeUom(inv, unit, qty) != qty1)
                    gcOmd.ExGridView.SetFocusedRowCellValue(gcOmd.ExGridView.Columns["qty1"], DB.GetQtyInAlternativeUom(inv, unit, qty));
            }
            else if (e.Column.FieldName == "prq")
            {
                DataTable dtpr = DB.sql.Select("select remark from prq where prq='" + (string)gcOmd.ExGridView.GetFocusedRowCellValue("prq") + "'");
                if (dtpr.Rows.Count > 0)
                {
                    remarkMemoEdit.EditValue = dtpr.Rows[0]["remark"].ToString();
                }
                gcOmd.ExGridView.SetFocusedRowCellValue(gcOmd.ExGridView.Columns["dateneed"], ((DateTime)dateDate.EditValue).AddDays(2));
            
            }
         
        }

        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gcOmd.ExGridView.GetDataRow(e.RowHandle);
            row["oms"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
            //row["no"] = DetailTable.Rows.Count + 1;
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            row["toleransi"] = DB.GetToleransi(ctrlSub.txtSub.EditValue.ToString());
            qtyOldValue = 0;
            priceOldValue = 0;
        }

        private void FrmTOrderbeli_Load(object sender, EventArgs e)
        {
           // curcur.Properties.ReadOnly = true;
            Utility.SetSqlInstance(pnlDetail, DB.sql);
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
            //DetailTable = DB.PopulateDateNeed(DetailTable, "Tgl Dibutuhkan");
            gcOmd.ExGridView.BestFitColumns();

            ctrlSub.txtSub.DataBindings.Add("EditValue", omsBindingSource, "sub");
            ctrlSub.txtSub.EditValueChanged += new EventHandler(subTextBoxEx_EditValueChanged);
            no_kon.DataBindings.Add("EditValue", omsBindingSource, "no_kon");
            //if (MasterBindingSource.Position == MasterTable.Rows.Count)
            //    jenispoRadioGroup.SelectedIndex = 0;
            
            Utility.SetNumberFormat(pnlTotal, "n2");
            ReCalculateTotal();

            //set default PPN ke-centang u/ record baru
            if (MasterBindingSource.Position == MasterTable.Rows.Count)
                cbPPN.Checked = true;
        }                

        private void subTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {
            DataRow row = ctrlSub.txtSub.ExGetDataRow();
          //  no_kon.ExSqlQuery = "Call SP_LookUpnokon('" + ctrlSub.txtSub.Text + "','','1')";
            if (row != null)
            {
                //    curcur.EditValue = "";
                //    return;
                //}
                  if (curcur.EditValue.ToString()=="")
                         curcur.EditValue = row["cur"].ToString();
                //if (this.mode = Mode.New)
                //   spinTOP.EditValue = row["top"].ToString();
            }
        }

        private void txtNo_EditValueChanged(object sender, EventArgs e)
        {
            if (MasterBindingSource.Position != MasterTable.Rows.Count)
            {
                DateTime dueDate = ((DateTime)MasterTable.Rows[MasterBindingSource.Position]["duedate"]).Date;
                DateTime date = ((DateTime)MasterTable.Rows[MasterBindingSource.Position]["date"]).Date;
                spinTOP.EditValue = ((TimeSpan)dueDate.Subtract(date)).TotalDays;
                //int jenisPO = Convert.ToInt32(MasterTable.Rows[MasterBindingSource.Position]["jenispo"]);
                //jenispoRadioGroup.SelectedIndex = jenisPO;
                ReCalculateTotal();
                DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
                //DetailTable = DB.PopulateDateNeed(DetailTable, "Tgl Dibutuhkan");
            }
        }

        private void cbPPN_CheckedChanged(object sender, EventArgs e)
        {
            ReCalculateTotal();
        }

        private void spinDisc_EditValueChanged(object sender, EventArgs e)
        {
            ReCalculateTotal();
        }

        void remarkColumnEdit_Enter(object sender, EventArgs e)
        {
            if (gcOmd.ExGridView.GetFocusedRowCellValue("inv") != null)
            {
                string kodeBarang = gcOmd.ExGridView.GetFocusedRowCellValue("inv").ToString();
                if (DB.isBiaya(kodeBarang))
                    ((TextEdit)sender).Properties.ReadOnly = false;
                else
                    ((TextEdit)sender).Properties.ReadOnly = true;
                     
            }
            else
                ((TextEdit)sender).Properties.ReadOnly = true;
        }

        private void no_kon_EditValueChanged(object sender, EventArgs e)
        {
            no_kon.ExSqlQuery = "Call SP_LookUpnokon('" + ctrlSub.txtSub.Text + "','','1')";
            if (no_kon.Text == "" || !no_kon.ExIsValid())
                return;

            if (ctrlSub.txtSub.Text == "")
                ctrlSub.txtSub.Text = no_kon.ExGetDataRow()["sub"].ToString();

            GridLookUpEx invLookUp = gcOmd.ExGridView.Columns["inv"].ColumnEdit as GridLookUpEx;
            invLookUp.Query = "Call SP_LookUpnokon('" + ctrlSub.txtSub.Text + "','','2')";
            invLookUp.TableName = "vpo";

            if (MasterBindingSource.Position == MasterTable.Rows.Count)
            {
                DetailTable.Clear();
                invLookUp.ClickButton();
            }
        }

        private void no_kon_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            //GridLookUpEx invLookUp = gcOmd.ExGridView.Columns["inv"].ColumnEdit as GridLookUpEx;
            //invLookUp.Query = "Call SP_LookUpnokon('" + ctrlSub.txtSub.Text + "')";
            //invLookUp.TableName = "vpo";
            // DetailTable.Clear();
            // invLookUp.ClickButton();
            
        }

        private void btnDocFlow_Click(object sender, EventArgs e)
        {

        }

        private void aprovCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void jenispoRadioGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.mode == Mode.Edit)
                DB.sql.Execute("Update omd set val=0 where omd.oms ='" + NoDocument + "'");

        }

        private void ExGridView_prqColumnEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(0);
        }

        private void ctrlSub_Load(object sender, EventArgs e)
        {

        }

        private void pnlDetail_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ExGridView_rsnColumnEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(0);
        }
      
    }
}

