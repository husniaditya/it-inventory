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
    public partial class FrmLBus : BaseLaporan
    {
        string noacc = "";
        string query = "";

        public FrmLBus()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);

        }

        private void FrmLBus_Load(object sender, EventArgs e)
        {
            dtpTglAwal.DateTime = Utility.FirstDateInMonth(DateTime.Now.Date);
            dtpTglAkhir.DateTime = DateTime.Now.Date;

            this.ReportName = "RepBankUSD";
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                CollectData();
                ProcessData();
                LoadReport();
                UpdateReport();
                PreviewReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + noacc);
            }

        }

        private void CollectData()
        {
            string tglAwal = dtpTglAwal.DateTime.ToString("yyyyMMdd");
            string tglAkhir = dtpTglAkhir.DateTime.ToString("yyyyMMdd");
            string accAwal = DB.GetRangeValue(txtAccAwal, txtAccAkhir, 0);
            string accAkhir = DB.GetRangeValue(txtAccAwal, txtAccAkhir, 1);

            dtResult = new DataTable();
          
            query = "Call SP_KasBUS(@tglawal,@tglakhir,'@accawal','@accakhir','0')";

            // replace params
            query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir);
            query = query.Replace("@accawal", accAwal).Replace("@accakhir", accAkhir);
            dtResult = DB.sql.Select(query);
        }

        private void ProcessData()
        {
            dtResult.Columns.Add("saldo", typeof(double));

            double saldo = 0;
            string acc = "";

            foreach (DataRow drResult in dtResult.Rows)
            {
                if (acc != drResult["acc"].ToString())
                    saldo = 0;

                // loop dtResult, fill in Saldo
                if (drResult["dk"].ToString() == "D")
                {
                    saldo += (double)drResult["debet"];
                    drResult["saldo"] = saldo;
                }
                else
                    if (drResult["dk"].ToString() == "K")
                    {
                        saldo -= (double)drResult["kredit"];
                        drResult["saldo"] = saldo;
                    }
                    else
                    {
                        saldo += (double)drResult["debet"] - (double)drResult["kredit"];
                        drResult["saldo"] = saldo;
                        drResult["debet"] = 0;
                        drResult["kredit"] = 0;
                    }
                acc = drResult["acc"].ToString();
            }
        }

        private void UpdateReport()
        {
            string tanggal = "Tanggal: " + dtpTglAwal.DateTime.ToString("dd/MM/yyyy") + " - " + dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
            this.Report.Bands[BandKind.ReportHeader].Controls["xrLabel1"].Text = tanggal;
            /*if (this.Tag.ToString() == "6541")
                this.Report.Bands[BandKind.ReportHeader].Controls["xrLabel2"].Text = "Buku Besar Global";
            else
                this.Report.Bands[BandKind.ReportHeader].Controls["xrLabel2"].Text = "Buku Besar Pembantu Detil";*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CollectData();
            GridReport frmDoc = new GridReport(query);
            frmDoc.ShowDialog();
        }
    }
}