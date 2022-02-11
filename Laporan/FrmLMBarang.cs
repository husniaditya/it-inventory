using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KASLibrary;
using DevExpress.XtraReports.UI;

namespace CAS.Laporan
{
    public partial class FrmLMBarang : CAS.Laporan.BaseLaporan
    {
        public FrmLMBarang()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
        }

        private void CollectData()
        {
            string invAwal = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 0);
            string invAkhir = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 1);
            string query;
            dtResult = new DataTable();
            if (checkBox1.Checked)
                query = "select inv,inv.name,unit,qtymin,jenis,group_,mtp.name as mtpname from inv left outer join mtp on inv.group_=mtp.mtp where inv.flag=0 and inv between '@invawal' and '@invakhir' order by group_,inv";
            else
                query = "select inv,inv.name,unit,qtymin,jenis,group_,mtp.name as mtpname from inv left outer join mtp on inv.group_=mtp.mtp where  inv between '@invawal' and '@invakhir' order by group_,inv";
            
            // replace params
            query = query.Replace("@invawal", invAwal).Replace("@invakhir", invAkhir);
            dtResult = DB.sql.Select(query);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                CollectData();
                this.ReportName = "RepMBarang";
                LoadReport();
               // UpdateReport();
                PreviewReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}

