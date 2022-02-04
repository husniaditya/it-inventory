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
    public partial class FrmLBukuBesar : BaseLaporan
    {
        string noacc="";
        
        public FrmLBukuBesar()
        {
            InitializeComponent();
             Utility.SetSqlInstance(pnlFilter, DB.sql);
        }

        private void FrmLBukuBesar_Load(object sender, EventArgs e)
        {
            dtpTglAwal.DateTime = Utility.FirstDateInMonth(DateTime.Now.Date);
            dtpTglAkhir.DateTime = DateTime.Now.Date;
            if (this.Tag.ToString() == "6572")
            {
                txtAccAwal.ExSqlQuery = "select 'KIAS' as `Kode Akun`, '' Keterangan union select 'JETI','' union select 'ALL','' ";
            }
            switch (this.Tag.ToString())
            {
                case "6541": // Buku Besar Pembantu Global
                    this.ReportName = "RepBukuBantuDetail";
                    txtAccAwal.ExSqlQuery = "select acc as `Kode Akun`, name as `Keterangan` from acc where detil=0";
                    txtAccAkhir.Visible = false;
                    break;
                case "6542": // Buku Besar Pembantu Detail
                    this.ReportName = "RepBukuBantuDetail"; 
                    break;
                case "6572": // Buku Besar Pembantu Detail
                    this.ReportName = "rugilaba_jeti";
                    Cct2BoxEx.Visible= false;
                    Cct1BoxEx.Visible = false;
                    txtAccAwal.Visible = true;
                    txtAccAkhir.Visible = false;
                    dtpTglAkhir.Visible = false; 
                    label2.Visible = true;
                    label2.Text = "Area";

                    break;
                case "661": // Buku Besar Pembantu Detail
                    this.ReportName = "RepSubDetilCct";
                    labelCct.Visible = true;
                    Cct1BoxEx.Visible = true;
                    Cct2BoxEx.Visible = true;
                    break;
                case "6d9":
                case "6d4": // Buku Besar Pembantu Detail
                    this.ReportName = "RepBukuBantuDetailPajak";
                    break;
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                CollectData();
                if (Tag.ToString() != "6572")
                    ProcessData();

                LoadReport();
                UpdateReport();
                PreviewReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+noacc);
            }
        }

        private void CollectData()
        {
            string tglAwal = dtpTglAwal.DateTime.ToString("yyyyMMdd");
            string tglAkhir = dtpTglAkhir.DateTime.ToString("yyyyMMdd");
            string accAwal = DB.GetRangeValue(txtAccAwal, txtAccAkhir, 0);
            string accAkhir = DB.GetRangeValue(txtAccAwal, txtAccAkhir, 1);
            string cctAwal = DB.GetRangeValue(Cct1BoxEx, Cct2BoxEx, 0);
            string cctAkhir = DB.GetRangeValue(Cct1BoxEx, Cct2BoxEx, 1);

            dtResult = new DataTable();
            string query = "";
            switch (this.Tag.ToString())
            {
                case "6541": // Buku Besar Pembantu Global
                    query = "Call SP_LBukuBantuGlobal(@tglawal,@tglakhir,'@accawal')";
                    break;
                case "6542": // Buku Besar Pembantu Detail
                    query = "Call SP_LBukuBantuDetail(@tglawal,@tglakhir,'@accawal','@accakhir')"; 
                    break;
                case "6572": //Rugi laba jeti
                    query = "Call SP_RLJeti(" + tglAwal + ")";
                    break;
                case "661": // Buku Besar Pembantu Detail
                    query = "Call SP_LACCPerCCT(@tglawal,@tglakhir,'@accawal','@accakhir','@ccta','@cctz')";
                    break;
                case "6d9":
                case "6d4": // Buku Besar Pembantu Detail
                    query = "Call SP_LBukuBantuDetail(@tglawal,@tglakhir,'@accawal','@accakhir')";
                    break;
            }
            
            // replace params
            if (Tag.ToString() != "6572")
            {
                query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir);
                query = query.Replace("@accawal", accAwal).Replace("@accakhir", accAkhir);
                if (Tag.ToString() == "661")
                    query = query.Replace("@ccta", cctAwal).Replace("@cctz", cctAkhir);
            }
          
            dtResult = DB.sql.Select(query);
        }

        private void ProcessData()
        {
            // add column Saldo
            dtResult.Columns.Add("saldo", typeof(double));

            double saldo = 0;
            string acc = "";
            string cct = "";

            foreach (DataRow drResult in dtResult.Rows)
            {
                if (acc != drResult["acc"].ToString())
                    saldo = 0;
                if (Tag.ToString() == "661")
                {
                    if (cct != drResult["cct"].ToString())
                        saldo = 0;
                }

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
                    saldo += (double)drResult["debet"]-(double)drResult["kredit"];
                    drResult["saldo"] = saldo;
                    drResult["debet"]=0;
                    drResult["kredit"]=0;
                }
                acc = drResult["acc"].ToString();
                if (Tag.ToString() == "661")
                    cct = drResult["cct"].ToString();

            
            }
        }

        private void UpdateReport()
        {
            if (Tag.ToString() != "6572")
            {
                string tanggal = "Tanggal: " + dtpTglAwal.DateTime.ToString("dd/MM/yyyy") + " - " + dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
                this.Report.Bands[BandKind.ReportHeader].Controls["xrTanggal"].Text = tanggal;
                if (this.Tag.ToString() == "6541")
                    this.Report.Bands[BandKind.ReportHeader].Controls["xrLabel2"].Text = "Buku Besar Global";
                else if (this.Tag.ToString() == "661")
                    this.Report.Bands[BandKind.ReportHeader].Controls["xrLabel2"].Text = "Buku Pembantu Detil Per Cost Center";
                else if (this.Tag.ToString() == "6d4" || this.Tag.ToString() == "6d9")
                    this.Report.Bands[BandKind.ReportHeader].Controls["xrLabel2"].Text = "Buku Besar";
                else
                    this.Report.Bands[BandKind.ReportHeader].Controls["xrLabel2"].Text = "Buku Besar Pembantu Detil";
            }

        }
    }
}