using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KASLibrary;

namespace CAS.Laporan
{
    public partial class FrmLMAktiva : CAS.Laporan.BaseLaporan
    {
        public FrmLMAktiva()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                CollectData();
                this.ReportName = "RepMAktiva";
                LoadReport();
                // UpdateReport();
                PreviewReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CollectData()
        {
            string invAwal = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 0);
            string invAkhir = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 1);
            string accAwal = DB.GetRangeValue(txtAccAwal, txtAccAkhir, 0);
            string accAkhir = DB.GetRangeValue(txtAccAwal, txtAccAkhir, 1);
            string cctAwal = DB.GetRangeValue(txtcctAwal, txtcctAkhir, 0);
            string cctAkhir = DB.GetRangeValue(txtcctAwal, txtcctAkhir, 1);
            string query;
            dtResult = new DataTable();
            query = "select akt.*,akd.cct,(select name from cct where cct = trim(akd.cct)) as cctname,akt.harga*akd.prosent/100 as hargabeli,acc.name as jenis,if(tglbeli<>tgljual,tgljual,tglstop) tglend from akt left join acc on akt.`acc` =acc.`acc` inner join akd on akd.akt=akt.akt where akt.akt between '@aktawal' and '@aktakhir' and akt.acc between '@accawal' and '@accakhir' and akd.cct between '@cctawal' and '@cctakhir' and harga>0 order by jenis,akd.cct, akt.akt ";

            // replace params
            query = query.Replace("@aktawal", invAwal).Replace("@aktakhir", invAkhir);
            query = query.Replace("@accawal", accAwal).Replace("@accakhir", accAkhir);
            query = query.Replace("@cctawal", cctAwal).Replace("@cctakhir", cctAkhir);
            dtResult = DB.sql.Select(query);
        }
    }
}