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
    public partial class FrmLMutasiKASBank : CAS.Laporan.BaseLaporan
    {
        public FrmLMutasiKASBank()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                //if (txtAccAwal.EditValue == null || txtAccAwal.EditValue.ToString() == "")
                //{
                //    MessageBox.Show("Harap mengisi perkiraan");
                //    return;
                //}
                CollectData();
                this.ReportName = "RepMutasiKASBank";
                LoadReport();
                //UpdateReport();
                PreviewReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmLMutasiKASBank_Load(object sender, EventArgs e)
        {
            dtpTglAwal.DateTime = dtpTglAkhir.DateTime = DateTime.Now.Date;
        }

        private void CollectData()
        {
            string tglAwal = dtpTglAwal.DateTime.ToString("yyyyMMdd");
            string tglAkhir = dtpTglAkhir.DateTime.ToString("yyyyMMdd");
            string accAwal = (txtAccAwal.EditValue == null? "" : txtAccAwal.EditValue.ToString());
            dtResult = new DataTable();
            string firstDate = Utility.FirstDateInMonth(dtpTglAwal.DateTime).ToString("yyyyMMdd");
            string query = "Call SP_MutasiKASBank(@firstdate,@tglawal,@tglakhir,'@acc','@period',@tipe)";
            // replace params
            query = query.Replace("@firstdate", firstDate);
            query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir);
            query = query.Replace("@acc", accAwal);
            query = query.Replace("@period", DB.loginPeriod);
            if (this.Tag.ToString() == "6c5")
                query = query.Replace("@tipe", "0");
            else
                query = query.Replace("@tipe", "1");
            dtResult = DB.sql.Select(query);
        }
    }
}

