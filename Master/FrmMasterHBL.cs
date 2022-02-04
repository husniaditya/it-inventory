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
    public partial class FrmMasterHBL : XtraForm
      {
        DataTable dt;
        public FrmMasterHBL()
        {
            InitializeComponent();

            dtpTglAwal.DateTime = Utility.FirstDateInMonth(DB.loginDate);
            dtpTglAkhir.DateTime = Utility.LastDateInMonth(DB.loginDate);

            dt = DB.sql.Select("select oms.date,sub.name as subname,omd.inv,omd.remark,omd.price,omd.unit,omd.disc  from omd,oms,sub where omd.oms=oms.oms and oms.sub=sub.sub and date between " + dtpTglAwal.DateTime.ToString("yyyyMMdd") + " and adddate(" + dtpTglAkhir.DateTime.ToString("yyyyMMdd") + ",1)");
            gcHJL.DataSource = dt;
       }


        private void FrmMasterHBL_Load(object sender, EventArgs e)
        {
            gridView2.BestFitColumns();
        }


        private void dtpTglAwal_EditValueChanged(object sender, EventArgs e)
        {
            //dtpTglAwal.DateTime = Utility.FirstDateInMonth(DB.loginDate);
            //dtpTglAkhir.DateTime = Utility.LastDateInMonth(DB.loginDate);

            dt = DB.sql.Select("select oms.date,sub.name as subname,omd.inv,omd.remark,omd.price,omd.unit,omd.disc from omd,oms,sub where omd.oms=oms.oms and oms.sub=sub.sub and date between " + dtpTglAwal.DateTime.ToString("yyyyMMdd") + " and adddate(" + dtpTglAkhir.DateTime.ToString("yyyyMMdd") + ",1)");
            gcHJL.DataSource = dt;
        }

        private void dtpTglAkhir_EditValueChanged(object sender, EventArgs e)
        {
            //dtpTglAwal.DateTime = Utility.FirstDateInMonth(DB.loginDate);
            //dtpTglAkhir.DateTime = Utility.LastDateInMonth(DB.loginDate);

            dt = DB.sql.Select("select oms.date,sub.name as subname,omd.inv,omd.remark,omd.price,omd.unit,omd.disc from omd,oms,sub where omd.oms=oms.oms and oms.sub=sub.sub and date between " + dtpTglAwal.DateTime.ToString("yyyyMMdd") + " and adddate(" + dtpTglAkhir.DateTime.ToString("yyyyMMdd") + ",1)");
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