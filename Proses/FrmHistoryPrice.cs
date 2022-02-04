using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;

namespace CAS.Proses
{
    public partial class FrmHistoryPrice : Form
    {
        string m_mat,m_doc;
        public FrmHistoryPrice(string material,string document)
        {
            InitializeComponent();
            m_mat = material;
            m_doc = document;
        }

    

        private void gcHistory_Load(object sender, EventArgs e)
        {
            DataTable dtJurnal = DB.sql.Select("select oms.oms,sub.name as vendor,oms.date,omd.inv Kode,omd.remark as `Nama Barang`,omd.qty,omd.unit,oms.cur,oms.kurs,omd.price from omd left outer join oms on omd.oms=oms.oms left outer join sub on oms.sub=sub.sub where trim(omd.remark)='" + m_mat.Trim().Replace("'","''")  + "' and omd.oms < '"+ m_doc +"' order by oms.date desc limit 5 ");
            gcHistory.ExGridControl.DataSource = dtJurnal;
            gcHistory.ExGridView.Columns["qty"].DisplayFormat.FormatType = FormatType.Numeric;
            gcHistory.ExGridView.Columns["qty"].DisplayFormat.FormatString = "N2";
            gcHistory.ExGridView.Columns["price"].DisplayFormat.FormatType = FormatType.Numeric;
            gcHistory.ExGridView.Columns["price"].DisplayFormat.FormatString = "N2";
            gcHistory.ExGridView.BestFitColumns(); 
        }

    }
}