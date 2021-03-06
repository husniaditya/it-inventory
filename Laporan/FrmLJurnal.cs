using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KASLibrary;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid.Columns;

namespace CAS.Laporan
{
    public partial class FrmLJurnal : BaseLaporan
    {
        public FrmLJurnal()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
        }

        private void FrmLJurnal_Load(object sender, EventArgs e)
        {
            dtpTglAwal.DateTime = Utility.FirstDateInMonth(DateTime.Now.Date);
            dtpTglAkhir.DateTime = DateTime.Now.Date;

            this.ReportName = "RepJurnal";
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                CollectData();
                ProcessData();
                LoadReport();
                PreviewReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CollectData()
        {
            string tglAwal = dtpTglAwal.DateTime.ToString("yyyyMMdd");
            string tglAkhir = dtpTglAkhir.DateTime.ToString("yyyyMMdd");
            string noseriAwal = DB.GetRangeValue(txtNoSeriAwal, txtNoSeriAkhir, 0);
            string noseriAkhir = DB.GetRangeValue(txtNoSeriAwal, txtNoSeriAkhir, 1);

            dtResult = new DataTable();
            string query = "Call SP_LJurnal(@tglawal,@tglakhir,'@noseriawal','@noseriakhir')";
            
            // replace params
            query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir);
            query = query.Replace("@noseriawal", noseriAwal).Replace("@noseriakhir", noseriAkhir);
            dtResult = DB.sql.Select(query);
        }

        private void ProcessData()
        {
            // add column Saldo
            dtResult.Columns.Add("saldo", typeof(double));

            double saldo = 0;
            string jurnal = "";

            foreach (DataRow drResult in dtResult.Rows)
            {
                if (jurnal != drResult["jurnal"].ToString())
                    saldo = 0;

                // loop dtResult, fill in Saldo
                if (drResult["dk"].ToString() == "D")
                {
                    saldo += (double)drResult["debet"];
                    drResult["saldo"] = saldo;
                }
                else
                {
                    saldo -= (double)drResult["kredit"];
                    drResult["saldo"] = saldo;
                }
                jurnal = drResult["jurnal"].ToString();
            }
        }

        private void UpdateReport()
        {
            //string tanggal = "Tanggal: " + dtpTglAwal.DateTime.ToString("dd/MM/yyyy") + " - " + dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
            //this.Report.Bands[BandKind.ReportHeader].Controls["xrTanggal"].Text = tanggal;
        }
    }
}