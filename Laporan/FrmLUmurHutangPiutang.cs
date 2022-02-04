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
    public partial class FrmLUmurHutangPiutang : BaseLaporan
    {
        public FrmLUmurHutangPiutang()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
        }

        private void FrmLUmurHutangPiutang_Load(object sender, EventArgs e)
        {
            dtpTglAwal.DateTime = Utility.FirstDateInMonth(DB.loginDate);
            dtpTglAkhir.DateTime = DateTime.Now ;
            switch (this.Tag.ToString())
            {
                case "6832":
                    this.Text = "Laporan Umur Hutang";
                    label3.Text = "Supplier";
                    txtSubAkhir.ExSqlQuery = txtSubAwal.ExSqlQuery = "call SP_Lookup('supplier')";
                    this.ReportName = "RepUmurHutangPiutang";
                    break;
                case "68b2":
                    this.ReportName = "Laporan Umur Piutang";
                    label3.Text = "Customer";
                    txtSubAkhir.ExSqlQuery = txtSubAwal.ExSqlQuery = "call SP_Lookup('customer')";
                    this.ReportName = "RepUmurHutangPiutang";
                    break;
                case "6831":
                    this.Text = "Laporan Buku Pembantu Hutang Global";
                    label3.Text = "Supplier";
                    txtSubAkhir.ExSqlQuery = txtSubAwal.ExSqlQuery = "call SP_Lookup('supplier')";
                    this.ReportName = "RepUmurHutangPiutangG";
                    break;
                case "68b1":
                    this.ReportName = "Laporan Buku Pembantu Piutang Global";
                    label3.Text = "Customer";
                    txtSubAkhir.ExSqlQuery = txtSubAwal.ExSqlQuery = "call SP_Lookup('customer')";
                    this.ReportName = "RepUmurHutangPiutangG";
                    break;
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                CollectData();
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
            string tglAwal  = dtpTglAwal.DateTime.ToString("yyyyMMdd");
            string tglAkhir = dtpTglAkhir.DateTime.ToString("yyyyMMdd");
            string invAwal = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 0);
            string invAkhir = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 1);
            string subAwal = DB.GetRangeValue(txtSubAwal, txtSubAkhir, 0);
            string subAkhir = DB.GetRangeValue(txtSubAwal, txtSubAkhir, 1);
            if (invAwal == "") invAwal = "00000000";
            if (invAkhir == "") invAkhir = "99999999";
            if (subAwal == "") subAwal = "00000000";
            if (subAkhir == "") subAkhir = "99999999";
            string query = "";
            string group = "1";
            if (this.Tag.ToString() == "6832" || this.Tag.ToString() == "68b2")

            {
                query = "Call SP_LapJatuhTempo('@subawal','@subakhir',@tglawal,@tglakhir,@group,'@invawal','@invakhir',@intv)";
                if (this.Tag.ToString() == "68b2") group = "2";
            }
            else
            {
                query = "Call SP_LapJatuhTempo2('@subawal','@subakhir',@tglawal,@tglakhir,@group,'@invawal','@invakhir',@intv)";
                if (this.Tag.ToString() == "68b1") group = "2";
            }
            
            string intv = IntvSpinEdit.EditValue.ToString();
            dtResult = new DataTable();
            // replace params
            query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir);
            query = query.Replace("@invawal", invAwal).Replace("@invakhir", invAkhir);
            query = query.Replace("@subawal", subAwal).Replace("@subakhir", subAkhir);
            query = query.Replace("@group", group);
            query = query.Replace("@intv", intv);
            dtResult = DB.sql.Select(query);
        }
        private void UpdateReport()
        {
        }
    }
}