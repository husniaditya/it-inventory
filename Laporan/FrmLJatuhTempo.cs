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
    public partial class FrmLJatuhTempo : CAS.Laporan.BaseLaporan
    {
        public FrmLJatuhTempo()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
        }

        private void FrmLJatuhTempo_Load(object sender, EventArgs e)
        {
            dtpTglAwal.DateTime = Utility.FirstDateInMonth(DB.loginDate);
            dtpTglAkhir.DateTime = Utility.LastDateInMonth(DB.loginDate);

            if (this.Tag.ToString() == "687") //hutang jatuh tempo
            {
                txtSubAwal.ExSqlQuery = "Call SP_LookUp('supplier')";
                lblSupCust.Text = "Supplier";
                this.ReportName = "RepJatuhTempo";
            }
            else if (this.Tag.ToString() == "68d" || this.Tag.ToString() == "63356"|| this.Tag.ToString()=="63355") //piutang jatuh tempo
            {
                txtSubAwal.ExSqlQuery = "Call SP_LookUp('customer')";
                txtSubAkhir.ExSqlQuery = "Call SP_LookUp('customer')";
                lblSupCust.Text = "Customer";
                if (this.Tag.ToString() == "68D")
                    this.ReportName = "RepJatuhTempo";
                else
                    if (this.Tag.ToString() == "63355")
                        this.ReportName = "RepPenjualanMandiri";
                    else
                       this.ReportName = "RepHPiutang";
            }
            else if (this.Tag.ToString() == "6851") //valuasi supplier
            {
                txtSubAwal.ExSqlQuery = "Call SP_LookUp('supplier')";
                lblSupCust.Text = "Supplier";
                this.ReportName = "RepValuasiCustomerSupplier";
            }
            else  //valuasi customer
            {
                txtSubAwal.ExSqlQuery = "Call SP_LookUp('customer')";
                txtSubAkhir.ExSqlQuery = "Call SP_LookUp('customer')";
                lblSupCust.Text = "Customer";
                this.ReportName = "RepValuasiCustomerSupplier";
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
            string tglAwal = dtpTglAwal.DateTime.ToString("yyyyMMdd");
            string tglAkhir = dtpTglAkhir.DateTime.ToString("yyyyMMdd");
            string subAwal = DB.GetRangeValue(txtSubAwal, txtSubAkhir, 0);
            string subAkhir = DB.GetRangeValue(txtSubAwal, txtSubAkhir, 1);
            string accAwal = DB.GetRangeValue(txtAccAwal, txtAccAkhir, 0);
            string accAkhir = DB.GetRangeValue(txtAccAwal, txtAccAkhir, 1);
            string perioda = dtpTglAwal.DateTime.ToString("yyMM");
            string periodz = dtpTglAkhir.DateTime.ToString("yyMM");
            
            string query = "";
            dtResult = new DataTable();
            if (this.Tag.ToString() == "68d")
            {
              // query = "Call SP_LapJatuhTempo('@subawal','@subakhir',@tglawal, @tglakhir,@group_,'@accawal','@accakhir',0)";
                query = "Call Sp_PiutangOut('" + subAwal + "','" + subAkhir + "'," + Utility.FirstDateInMonth(dtpTglAkhir.DateTime).ToString("yyyyMMdd") + "," + ((DateTime)dtpTglAkhir.EditValue).AddDays(1).ToString("yyyyMMdd") + ",'','1','@accawal','@accakhir')";
            }
            else
                if (this.Tag.ToString() == "63356")
                {
                   query = "CALL SP_Hpiutang('" + perioda + "','" + periodz + "','" + subAwal + "','" + subAkhir + "','@accawal','@accakhir')";
                }
                else
                {
                    query = "Call SP_ValuasiHutangPiutang('@subawal','@subakhir',@tglawal, @tglakhir,@group_,'@accawal','@accakhir')";
                }

            if (this.Tag.ToString() == "63355")
            {
                query = "Call SP_ValuasiHutangPiutangM('@subawal','@subakhir',@tglawal, @tglakhir,@group_,'@accawal','@accakhir')";
            }  

            // replace params
            query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir);
            query = query.Replace("@subawal", subAwal).Replace("@subakhir", subAkhir);
            query = query.Replace("@accawal", accAwal).Replace("@accakhir", accAkhir);
            if (this.Tag.ToString() == "687" || this.Tag.ToString() == "6851")
                query = query.Replace("@group_", "1");
            else
                query = query.Replace("@group_", "2");
            //query = query.Replace("@period", DB.loginPeriod);
            dtResult = DB.sql.Select(query);
        }

        private void UpdateReport()
        {
            if (this.Tag.ToString() == "687")
            {
                this.Report.Bands[BandKind.ReportHeader].Controls["lblTitle"].Text = "Laporan Hutang Jatuh Tempo";
                this.Report.Bands[BandKind.GroupHeader].Controls["lblSupCust"].Text = "Supplier";
            }
            else if (this.Tag.ToString() == "68d")
            {
                this.Report.Bands[BandKind.ReportHeader].Controls["lblTitle"].Text = "Laporan Piutang Outstanding";
                this.Report.Bands[BandKind.GroupHeader].Controls["lblSupCust"].Text = "Customer";
            }
            else if (this.Tag.ToString() == "6851")
            {
                this.Report.Bands[BandKind.ReportHeader].Controls["lblTitle"].Text = "Laporan Valuasi Supplier";
            }
            else 
            {
                this.Report.Bands[BandKind.ReportHeader].Controls["lblTitle"].Text = "Laporan Valuasi Customer";
            }

            if (this.Tag.ToString() == "63356")
            {
                this.Report.Bands[BandKind.ReportHeader].Controls["lblTitle"].Text = "Laporan History Piutang";
                this.Report.Bands[BandKind.ReportHeader].Controls["lblPeriode"].Text = "Periode : " + dtpTglAwal.DateTime.ToString("MMMM yyyy") + " s/d " + dtpTglAkhir.DateTime.ToString("MMMM yyyy");
            
            }
            else
            {
                this.Report.Bands[BandKind.ReportHeader].Controls["lblPeriode"].Text = "Periode : " + dtpTglAwal.DateTime.ToString("dd-MM-yyyy") + " s/d " + dtpTglAkhir.DateTime.ToString("dd-MM-yyyy");
                this.Report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
            }
        }
    }
}

