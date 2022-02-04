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
    public partial class FrmMasterHJual : XtraForm
    {
        public FrmMasterHJual()
        {
            InitializeComponent();
            Utility.SetSqlInstance(textBoxEx1, DB.sql);
  
            gcHBL.ExGridControl.DataSource = hblBindingSource;
            gcHBL.ExTitleLabel.Text = "";
            gcHBL.ExGridView.OptionsView.ShowGroupPanel = false;
            gcHBL.ExGridView.OptionsCustomization.AllowSort = false;
            
            gcHBL.ExGridView.Columns["sub"].VisibleIndex = 0;
            gcHBL.ExGridView.Columns["subname"].VisibleIndex = 1;
            gcHBL.ExGridView.Columns["no_po"].VisibleIndex = 2;
            gcHBL.ExGridView.Columns["tanggal"].VisibleIndex = 3;
            gcHBL.ExGridView.Columns["satuan"].VisibleIndex = 4;
            gcHBL.ExGridView.Columns["price"].VisibleIndex = 5;
            gcHBL.ExGridView.Columns["remark"].VisibleIndex = 6;
            gcHBL.ExGridView.Columns["disc"].VisibleIndex = 7;
            gcHBL.ExGridView.Columns["cur"].VisibleIndex = 8;
            
            gcHBL.ExGridView.Columns["sub"].Visible = true;
            gcHBL.ExGridView.Columns["subname"].Visible = true;
            gcHBL.ExGridView.Columns["no_po"].Visible = true;
            gcHBL.ExGridView.Columns["tanggal"].Visible = true;
            gcHBL.ExGridView.Columns["satuan"].Visible = true;
            gcHBL.ExGridView.Columns["price"].Visible = true;
            gcHBL.ExGridView.Columns["remark"].Visible = true;
            gcHBL.ExGridView.Columns["disc"].Visible = true;
            gcHBL.ExGridView.Columns["cur"].Visible = true;
            gcHBL.ExGridView.Columns["inv"].Visible = false;
            
            gcHBL.ExGridView.OptionsBehavior.Editable = false;
            gcHBL.ExGridView.OptionsSelection.MultiSelect = true;
            
            string sqlText;
            sqlText = "Call SP_BrowseHBL('"+textBoxEx1.Text+"')";
            gcHBL.ExGridView.Columns["sub"].ColumnEdit = new GridLookUpEx(DB.sql, sqlText, "hbl", "inv", gcHBL.ExGridView, "sub", true, true, "Kode Supplier");
            
            gcHBL.ExGridView.Columns["sub"].Caption = "Kode Supplier";
            gcHBL.ExGridView.Columns["subname"].Caption = "Nama Supplier";
            gcHBL.ExGridView.Columns["no_po"].Caption = "No PO";
            gcHBL.ExGridView.Columns["tanggal"].Caption = "Tanggal";
            gcHBL.ExGridView.Columns["satuan"].Caption = "Satuan";
            gcHBL.ExGridView.Columns["price"].Caption = "Harga";
            gcHBL.ExGridView.Columns["remark"].Caption = "Remark";
            gcHBL.ExGridView.Columns["disc"].Caption = "Discount";
            gcHBL.ExGridView.Columns["cur"].Caption = "Currency";
            gcHBL.ExGridView.BestFitColumns();
            
        }

        private void FrmMasterHBL_Load(object sender, EventArgs e)
        {
            gcHBL.ExGridView.BestFitColumns();
        }

        private void textBoxEx1_EditValueChanged(object sender, EventArgs e)
        {
            string kode = textBoxEx1.Text;
            DataTable dt = DB.sql.Select("select * from hbl where inv = '" + kode + "'");
            gcHBL.ExGridControl.DataSource = dt;
        }


    }
}