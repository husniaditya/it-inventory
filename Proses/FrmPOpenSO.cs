using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using KASLibrary;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraReports.UI;

namespace CAS.Proses
{
    public partial class FrmPOpenSO : XtraForm
    {
        MySqlDataAdapter daPeriod ;
        /*= DB.sql.SelectAdapter("select *,(select sum(qty) from spb,spbd where spb.spb=spbd.spb and spb.oms=openpo.oms and spbd.inv=openpo.inv " +
                                       " and spbd.remark=openpo.remark and spb.`delete`=0) as terpenuhi from openpo order by `no`");
          */            
        public FrmPOpenSO()
        {
            InitializeComponent();
            dtpTglAwal.DateTime = Utility.FirstDateInMonth(DB.loginDate);
            dtpTglAkhir.DateTime = Utility.LastDateInMonth(DB.loginDate);
            daPeriod = DB.sql.SelectAdapter("select openpo.*,(select sum(qty) from sjh,sjd where sjh.sjh=sjd.sjh and sjd.okl=openpo.oms and sjd.inv=openpo.inv " +
                                      " and sjd.remark=openpo.remark and sjh.`delete`=0) as terpenuhi from openpo,okl where openpo.oms=okl.okl and date(okl.date) between " + dtpTglAwal.DateTime.ToString("yyyyMMdd") + " and " + dtpTglAkhir.DateTime.ToString("yyyyMMdd") + " order by `no`");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridControlEx));
            
           
            casDataSet.openpo.Columns.Add("terpenuhi", typeof(String));

            gcPeriod.ExToolStrip.Items["tsbtnShow"].Visible = false;
            gcPeriod.ExToolStrip.Items["copyToolStripButton"].Visible = false;
            gcPeriod.ExToolStrip.Items["helpToolStripButton"].Visible = false;
            gcPeriod.ExToolStrip.Items["tsbtnDelete"].Enabled = DB.casUser.AllowDelete("56");
            ToolStripButton tsbtnSave = new System.Windows.Forms.ToolStripButton("Save", ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image"))), (ExGridView_Save_Click), "tsbtnSave");
            gcPeriod.ExToolStrip.Items.Add(tsbtnSave);
            daPeriod.Fill(casDataSet.openpo);
            gcPeriod.ExGridControl.DataSource = casDataSet.openpo;
             //  gcPeriod.ExGridView.Columns["inv"].ColumnEdit = new GridLookUpEx(DB.sql, "select inv as `Kode Barang`,name as `Nama Barang` from inv", "inv", "inv", gcxFpjUM.ExGridView, "Nama Barang", true, true, "Master Barang");
           
            gcPeriod.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
            gcPeriod.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
            gcPeriod.ExGridView.OptionsBehavior.Editable = true;
            gcPeriod.ExGridView.Columns["oms"].ColumnEdit = new GridLookUpEx(DB.sql, "", "oms", "oms", gcPeriod.ExGridView, "", true, true, "Sales Order");
            gcPeriod.ExGridView.Columns["oms"].ColumnEdit.Enter += new EventHandler(ExGridView_OmsColumnEdit_Enter);

            gcPeriod.ExGridView.Columns["no"].Caption = "No";
            gcPeriod.ExGridView.Columns["oms"].Caption = "Nomor PO";
            gcPeriod.ExGridView.Columns["inv"].Caption = "Kode Barang";
            gcPeriod.ExGridView.Columns["remark"].Caption = "Nama Barang";
            gcPeriod.ExGridView.Columns["tol"].Caption = "Toleransi %";
            gcPeriod.ExGridView.Columns["qtypo"].Caption = "Qty PO";
            gcPeriod.ExGridView.Columns["terpenuhi"].Caption = "Terpenuhi";
            gcPeriod.ExGridView.Columns["rate"].Caption = "Rencana Terima";
            gcPeriod.ExGridView.Columns["crate"].Caption = "Count Terima";
            gcPeriod.ExGridView.Columns["qtypo"].ColumnEdit = new GridNumEx();
            gcPeriod.ExGridView.Columns["tol"].ColumnEdit = new GridNumEx(false,true,0,100,1,false);
            gcPeriod.ExGridView.Columns["rate"].ColumnEdit = new GridNumEx();

            DB.SetNumberFormat(gcPeriod.ExGridView, "n2");


            gcPeriod.ExGridView.BestFitColumns();
         //   gcxFpjUM.ExGridView.Columns["price"].Caption = "Price";
            gcPeriod.ExGridView.Columns["no"].OptionsColumn.AllowEdit = false;
            gcPeriod.ExGridView.Columns["chtime"].OptionsColumn.AllowEdit = false;
            gcPeriod.ExGridView.Columns["chusr"].OptionsColumn.AllowEdit = false;
            gcPeriod.ExGridView.Columns["crate"].OptionsColumn.AllowEdit = false;
            gcPeriod.ExGridView.Columns["inv"].OptionsColumn.AllowEdit = false;
            gcPeriod.ExGridView.Columns["remark"].OptionsColumn.AllowEdit = false;
            gcPeriod.ExGridView.Columns["oms"].VisibleIndex = 1;
            gcPeriod.ExGridView.Columns["terpenuhi"].VisibleIndex = 6;
            gcPeriod.ExGridView.Columns["unit"].VisibleIndex = 7;
            gcPeriod.ExGridView.Columns["close"].VisibleIndex = 13;
            gcPeriod.ExGridView.Columns["unit"].OptionsColumn.AllowEdit = false;
            gcPeriod.ExGridView.Columns["qtypo"].OptionsColumn.AllowEdit = false;
            gcPeriod.ExGridView.Columns["terpenuhi"].OptionsColumn.AllowEdit = false;

            gcPeriod.ExGridView.Columns["no"].Visible = false;
        }

        void ExGridView_OmsColumnEdit_Enter(object sender, EventArgs e)
        {

            GridLookUpEx omsLookUp = (GridLookUpEx)gcPeriod.ExGridView.Columns["oms"].ColumnEdit;
            omsLookUp.Query = "select okl.okl as`Nomor PO`,okd.inv as `Kode Barang`,okd.remark as `Nama Barang`,okd.qty as `Qty PO`,okd.toleransi as `Toleransi %`,if(okl.`close`=1,1,0) as close, "+
                              "(select sum(qty) from sjh,sjd where sjh.sjh=sjd.sjh and sjd.okl=okd.okl and sjd.inv=okd.inv and sjd.remark=okd.remark and sjh.`delete`=0) as Terpenuhi, inv.unit as `unit` " +
                              " from okd left outer join okl on okd.okl=okl.okl left outer join inv on okd.inv=inv.inv where date(okl.date) between " + dtpTglAwal.DateTime.ToString("yyyyMMdd") + " and " + dtpTglAkhir.DateTime.ToString("yyyyMMdd") + 
                              " and concat(trim(okd.okl),trim(okd.inv),trim(okd.remark)) not in (select concat(trim(openpo.oms),trim(openpo.inv),trim(openpo.remark)) from openpo) ";
            omsLookUp.TableName = "oms";

        }

        private void FrmPOpenSO_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'casDataSet._close' table. You can move, or remove it, as needed.
            //this._closeTableAdapter.Fill(this.casDataSet._close);

        }

        void ExGridView_Save_Click(object sender, EventArgs e)
        {
            try
            {
                
                this.ValidateChildren();
                for (int i = casDataSet.openpo.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row =  casDataSet.openpo.Rows[i];
                    if (row != null && (row.RowState == DataRowState.Added || row.RowState == DataRowState.Modified))
                    {
                        string toleransi = row["tol"].ToString();
                        string inv = row["inv"].ToString();
                        string remark = row["remark"].ToString().Replace("'", "''");
                        string oms = row["oms"].ToString();
                        string chusr = row["chusr"].ToString();
                        string chtime = row["chtime"].ToString();
                        string open = row["close"].ToString();

                        DB.sql.Execute("update okd set toleransi=" + toleransi + " where okd.okl = '" + oms + "' and okd.inv= '" + inv + "' and okd.remark= '" + remark + "'");
                       DB.sql.Execute("update okl set okl.`close`="+ open +",chusr='" + chusr + "', chtime='" + chtime + "' where okl.okl = '" + oms + "'");

                    }
                }

                daPeriod.Update(casDataSet.openpo);
       
                MessageBox.Show("Data telah berhasil di simpan!");
                casDataSet.openpo.Clear();
                daPeriod = DB.sql.SelectAdapter("select openpo.*,(select sum(qty) from sjh,sjd where sjh.sjh=sjd.sjh and sjd.okl=openpo.oms and sjd.inv=openpo.inv " +
                                        " and sjd.remark=openpo.remark and sjh.`delete`=0) as terpenuhi from openpo,okl where openpo.oms=okl.okl and date(okl.date) between " + dtpTglAwal.DateTime.ToString("yyyyMMdd") + " and " + dtpTglAkhir.DateTime.ToString("yyyyMMdd") + " order by `no`");
                daPeriod.Fill(casDataSet.openpo);
                gcPeriod.ExGridControl.DataSource = casDataSet.openpo;
            }
            
            catch (Exception ex)
            {        
                MessageBox.Show(ex.Message);
            }
        }

        void ExGridView_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this item?", "Confirmation",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                DB.DeleteDetailRows(gcPeriod.ExGridView);
            //    daPeriod.Update(casDataSet._close);
            }
           
        }

        void ExGridView_New_Click(object sender, EventArgs e)
        {
            int maxno;
            if (casDataSet.openpo.Rows.Count != 0)
               maxno = (int) casDataSet.openpo.Compute("MAX(no)", "no>0") + 1;
            else
              maxno= 1  ;
            DataRow row = casDataSet.openpo.NewRow();
                row["no"]=  maxno;
                row["oms"] = "";
                row["remark"] = "";
                row["chusr"] = DB.casUser.User;
                row["chtime"] = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                row["inv"] = "";
                row["tol"] = 0;
                row["close"] = 0;
                row["rate"] = 0;
                row["crate"] = 0;
                casDataSet.openpo.Rows.Add(row);
         //   DB.InsertDetailRows(gcPeriod.ExGridView, row);
        }

        private void FrmPOpenSO_FormClosing(object sender, FormClosingEventArgs e)
        {
            // daPeriod.Update(casDataSet.openpo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            casDataSet.openpo.Clear();
            daPeriod = DB.sql.SelectAdapter("select openpo.*,(select sum(qty) from sjh,sjd where sjh.sjh=sjd.sjh and sjd.okl=openpo.oms and sjd.inv=openpo.inv " +
                                       " and sjd.remark=openpo.remark and sjh.`delete`=0) as terpenuhi from openpo,okl where openpo.oms=okl.okl and date(okl.date) between " + dtpTglAwal.DateTime.ToString("yyyyMMdd") + " and " + dtpTglAkhir.DateTime.ToString("yyyyMMdd") + " order by `no`");
            daPeriod.Fill(casDataSet.openpo);
            gcPeriod.ExGridControl.DataSource = casDataSet.openpo;

        }

     }
}