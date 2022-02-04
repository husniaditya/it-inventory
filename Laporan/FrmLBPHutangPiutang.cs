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
    public partial class FrmLBPHutangPiutang : BaseLaporan
    {
        public FrmLBPHutangPiutang()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
        }

        private void FrmLBPHutangPiutang_Load(object sender, EventArgs e)
        {
            dtpTglAwal.DateTime = Utility.FirstDateInMonth(DB.loginDate);
            dtpTglAkhir.DateTime = Utility.LastDateInMonth(DB.loginDate);
            switch (this.Tag.ToString())
            {
                case "682":
                    this.Text = "Laporan Buku Pembantu Hutang";
                    label3.Text = "Supplier";
                    txtSubAkhir.ExSqlQuery = txtSubAwal.ExSqlQuery = "call SP_Lookup('supplier')";
                    this.ReportName = "RepLBPHutang";
                    break;
                case "68a":
                    this.ReportName = "Laporan Buku Pembantu Piutang";
                    label3.Text = "Customer";
                    txtSubAkhir.ExSqlQuery = txtSubAwal.ExSqlQuery = "call SP_Lookup('customer')";
                    this.ReportName = "RepLBPHutang";
                    break;
                case "681":
                    this.Text = "Laporan Saldo Hutang";
                    label3.Text = "Supplier";
                    txtSubAkhir.ExSqlQuery = txtSubAwal.ExSqlQuery = "call SP_Lookup('supplier')";
                    this.ReportName = "RepLHutang";
                    break;
                case "689":
                    this.Text = "Laporan Saldo Piutang";
                    label3.Text = "Customer";
                    txtSubAkhir.ExSqlQuery = txtSubAwal.ExSqlQuery = "call SP_Lookup('customer')";
                    this.ReportName = "RepLHutang";
                    break;
                case "6db":
                    this.Text = "Laporan PPH";
                    label3.Text = "Supplier";
                    txtSubAkhir.ExSqlQuery = txtSubAwal.ExSqlQuery = "call SP_Lookup('supplier')";
                    this.ReportName = "lapPPH";
                    break;
            }
            
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                CollectData();
                if (this.Tag.ToString() == "682" || this.Tag.ToString() == "68a")
                ProcessData();
                LoadReport();
                UpdateReport();
                PreviewReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CollectData()
        {
            string tgl = Utility.FirstDateInMonth(dtpTglAwal.DateTime).ToString("yyyyMMdd");
            string tglAwal = dtpTglAwal.DateTime.ToString("yyyyMMdd");
            string tglAkhir = dtpTglAkhir.DateTime.AddDays(1).ToString("yyyyMMdd");
            string invAwal = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 0);
            string invAkhir = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 1);
            string subAwal = DB.GetRangeValue(txtSubAwal, txtSubAkhir, 0);
            string subAkhir = DB.GetRangeValue(txtSubAwal, txtSubAkhir, 1);
            string group = "";
            if (invAwal == "") invAwal = "00000000";
            if (invAkhir == "") invAkhir = "99999999";
            if (subAwal == "") subAwal = "00000000";
            if (subAkhir == "") subAkhir = "99999999";
            string query = "";
            switch (this.Tag.ToString())
            {
                case "681":
                    group = "1";
                    query = "Call SP_rsb('@subawal','@subakhir',@tgl,@tglawal,@tglakhir,@group,'@invawal','@invakhir')";
                    break;
                case "682":
                    group = "1";
                    query = "Call SP_submut('@subawal','@subakhir',@tgl,@tglawal,@tglakhir,@group,'@invawal','@invakhir')";
                    break;
                case "689":
                    group = "2";
                    query = "Call SP_rsb('@subawal','@subakhir',@tgl,@tglawal,@tglakhir,@group,'@invawal','@invakhir')";
                    break;
                case "68a":       
                    group = "2";
                    query = "Call SP_submut('@subawal','@subakhir',@tgl,@tglawal,@tglakhir,@group,'@invawal','@invakhir')";
                    break;
                case "6db":
                    group = "2";
                    query = "Call SP_LapPPH(@tglawal,@tglakhir,'@subawal','@subakhir','@invawal','@invakhir')";
                    break;
            }
            
            dtResult = new DataTable();
            // replace params
            query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir).Replace("@tgl",tgl);
            query = query.Replace("@invawal", invAwal).Replace("@invakhir", invAkhir);
            query = query.Replace("@subawal", subAwal).Replace("@subakhir", subAkhir);
            query = query.Replace("@group", group);
            dtResult = DB.sql.Select(query);
        }

        private void ProcessData()
        {
            dtResult.Columns.Add("vsaldo", typeof(double));

            double vsaldo = 0;
            string acc = "", sub = "";
            double debet = 0;
            double kredit = 0;
            foreach (DataRow drResult in dtResult.Rows)
            {
                if (acc != drResult["acc"].ToString() || sub != drResult["sub"].ToString())
                {
                    vsaldo = 0;
                }
                if (drResult["vdebet"] == DBNull.Value) debet = 0;
                else debet = (double)drResult["vdebet"];
                if (drResult["vkredit"] == DBNull.Value)
                   kredit = 0;
                else
                    kredit = (double)drResult["vkredit"];
                drResult["vdebet"] = debet;
                drResult["vkredit"] = kredit;
                vsaldo += debet - kredit;
                drResult["vsaldo"] = vsaldo;
                if (drResult["rem"].ToString().Trim()=="Saldo Awal")
                {
                 drResult["vdebet"] = 0;
                 drResult["vkredit"] = 0;
                }

                acc = drResult["acc"].ToString();
                sub = drResult["sub"].ToString();
            }
        }

        private void UpdateReport()
        {
            string periode1 = dtpTglAwal.DateTime.ToString("MMMM yyyy");
            string periode2 = dtpTglAkhir.DateTime.ToString("MMMM yyyy");
            string periode3 = periode1;
            if (periode1 != periode2) periode3 += " - " + periode2;
            this.Report.Bands[BandKind.ReportHeader].Controls["xrLabelPeriode"].Text = "Periode : " + periode3;
            this.Report.Bands[BandKind.ReportHeader].Controls["xrLabelTanggal"].Text = dtpTglAwal.DateTime.ToString("dd/MM/yyyy") + " - " + dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
            this.Report.Bands[BandKind.PageFooter].Controls["xrLabelUser"].Text = DB.casUser.Name;
            switch (this.Tag.ToString())
            {
                case "681":
                    this.Report.Bands[BandKind.ReportHeader].Controls["xrLabelJudul"].Text = "Laporan Saldo Hutang";
                    break;
                case "682":
                    this.Report.Bands[BandKind.GroupHeader].Controls["xrLabelSupplier"].Text = "Supplier";
                    this.Report.Bands[BandKind.ReportHeader].Controls["xrLabelJudul"].Text = "Buku Pembantu Hutang";
                    break;
                case "689":
                    this.Report.Bands[BandKind.ReportHeader].Controls["xrLabelJudul"].Text = "Laporan Saldo Piutang";
                    break;
                case "68a":
                    this.Report.Bands[BandKind.GroupHeader].Controls["xrLabelSupplier"].Text = "Customer";
                    this.Report.Bands[BandKind.ReportHeader].Controls["xrLabelJudul"].Text = "Buku Pembantu Piutang";
                    break;
            }
        }

    }
}