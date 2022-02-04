using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KASLibrary;
using DevExpress.XtraEditors;

namespace CAS.Master
{
    public partial class FrmMasterHJL : XtraForm
    {
        DataTable dt;
        public FrmMasterHJL()
        {
            InitializeComponent();
         //   Utility.SetSqlInstance(textBoxEx1, DB.sql);

         //   gcHJL.ExGridControl.DataSource = hjlBindingSource;
            dtpTglAwal.DateTime = Utility.FirstDateInMonth(DB.loginDate);
            dtpTglAkhir.DateTime = Utility.LastDateInMonth(DB.loginDate);

            dt = DB.sql.Select("select okl.date,sub.name as subname,okd.inv,okd.remark,okd.price*okd.qty1/okd.qty as price,inv.unit,okd.disc,(select price from hjl where tanggal<=okl.date and hjl.inv=okd.inv order by tanggal desc limit 1) as pricej from okd,okl,sub,inv where okd.okl=okl.okl and okl.sub=sub.sub and okd.inv=inv.inv and okl.date between " + dtpTglAwal.DateTime.ToString("yyyyMMdd") + " and adddate(" + dtpTglAkhir.DateTime.ToString("yyyyMMdd") + ",1)");
            gcHJL.DataSource = dt;
          
/*
            gcHJL.ExGridView.Columns["sub"].VisibleIndex = 0;
            gcHJL.ExGridView.Columns["subname"].VisibleIndex = 1;
            gcHJL.ExGridView.Columns["no_po"].VisibleIndex = 2;
            gcHJL.ExGridView.Columns["tanggal"].VisibleIndex = 3;
            gcHJL.ExGridView.Columns["satuan"].VisibleIndex = 4;
            gcHJL.ExGridView.Columns["price"].VisibleIndex = 5;
            gcHJL.ExGridView.Columns["remark"].VisibleIndex = 6;
            gcHJL.ExGridView.Columns["disc"].VisibleIndex = 7;
            gcHJL.ExGridView.Columns["cur"].VisibleIndex = 8;

            gcHJL.ExGridView.Columns["sub"].Visible = true;
            gcHJL.ExGridView.Columns["subname"].Visible = true;
            gcHJL.ExGridView.Columns["no_po"].Visible = true;
            gcHJL.ExGridView.Columns["tanggal"].Visible = true;
            gcHJL.ExGridView.Columns["satuan"].Visible = true;
            gcHJL.ExGridView.Columns["price"].Visible = true;
            gcHJL.ExGridView.Columns["remark"].Visible = true;
            gcHJL.ExGridView.Columns["disc"].Visible = true;
            gcHJL.ExGridView.Columns["cur"].Visible = true;
            gcHJL.ExGridView.Columns["inv"].Visible = false;

            string sqlText;
            sqlText = "Call SP_BrowseHJL('" + textBoxEx1.Text + "')";
            gcHJL.ExGridView.Columns["sub"].ColumnEdit = new GridLookUpEx(DB.sql, sqlText, "hjl", "inv", gcHJL.ExGridView, "sub", true, true, "Kode Supplier");

            gcHJL.ExGridView.Columns["sub"].Caption = "Kode Supplier";
            gcHJL.ExGridView.Columns["subname"].Caption = "Nama Supplier";
            gcHJL.ExGridView.Columns["no_po"].Caption = "No PO";
            gcHJL.ExGridView.Columns["tanggal"].Caption = "Tanggal";
            gcHJL.ExGridView.Columns["satuan"].Caption = "Satuan";
            gcHJL.ExGridView.Columns["price"].Caption = "Harga";
            gcHJL.ExGridView.Columns["remark"].Caption = "Remark";
            gcHJL.ExGridView.Columns["disc"].Caption = "Discount";
            gcHJL.ExGridView.Columns["cur"].Caption = "Currency";
 * */
        }

        private void FrmMasterHJL_Load(object sender, EventArgs e)
        {
           

        }

        private void textBoxEx1_EditValueChanged(object sender, EventArgs e)
        {
            //string kode = textBoxEx1.Text;
            //DataTable dt = DB.sql.Select("CALL SP_BrowseHJL('"+kode+"')");
            //gcHJLDataSource = dt;
        }

        private void dtpTglAwal_EditValueChanged(object sender, EventArgs e)
        {
            //dtpTglAwal.DateTime = Utility.FirstDateInMonth(DB.loginDate);
            //dtpTglAkhir.DateTime = Utility.LastDateInMonth(DB.loginDate);

            dt = DB.sql.Select("select okl.date,sub.name as subname,okd.inv,okd.remark,okd.price*okd.qty1/okd.qty as price,inv.unit,okd.disc,(select price from hjl where addtime(tanggal,time)<=okl.date order by tanggal desc limit 1) as pricej from okd,okl,sub,inv where okd.okl=okl.okl and okl.sub=sub.sub and okd.inv=inv.inv and okl.date between " + dtpTglAwal.DateTime.ToString("yyyyMMdd") + " and adddate(" + dtpTglAkhir.DateTime.ToString("yyyyMMdd") + ",1)");
            gcHJL.DataSource = dt;
        }

        private void dtpTglAkhir_EditValueChanged(object sender, EventArgs e)
        {
            //dtpTglAwal.DateTime = Utility.FirstDateInMonth(DB.loginDate);
            //dtpTglAkhir.DateTime = Utility.LastDateInMonth(DB.loginDate);

            dt = DB.sql.Select("select okl.date,sub.name as subname,okd.inv,okd.remark,okd.price*okd.qty1/okd.qty as price,inv.unit,okd.disc,(select price from hjl where addtime(tanggal,time)<=okl.date order by tanggal desc limit 1) as pricej from okd,okl,sub,inv where okd.okl=okl.okl and okl.sub=sub.sub and okd.inv=inv.inv and okl.date between " + dtpTglAwal.DateTime.ToString("yyyyMMdd") + " and adddate(" + dtpTglAkhir.DateTime.ToString("yyyyMMdd") + ",1)");
            gcHJL.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gcHJL.ShowPrintPreview();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            savFile.FileName = "";
            savFile.Filter = "Excel File|*.xls";
            if (savFile.ShowDialog() == DialogResult.OK)
            {
                string fileName = savFile.FileName;
                if (fileName.EndsWith("xls"))
                {
                    gcHJL.ExportToExcel(fileName);
                }
               
            }
            
        }
    }
}