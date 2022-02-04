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
    public partial class FrmLSJPenjualanT : CAS.Laporan.BaseLaporan
    {
        public FrmLSJPenjualanT()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
            dtpTglAwal.DateTime = Utility.FirstDateInMonth(DateTime.Today);
            dtpTglAkhir.DateTime = Utility.LastDateInMonth(DateTime.Today);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Tag.ToString() == "63357")
                    this.ReportName = "lapslssj";
                else
                    this.ReportName = "lapsjt";

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
            string tglAwal, tglAkhir, invAwal, invAkhir, subAwal, subAkhir,loca,locz,query;
            tglAwal = dtpTglAwal.DateTime.ToString("yyyyMMdd");
            tglAkhir = dtpTglAkhir.DateTime.ToString("yyyyMMdd");
            invAwal = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 0);
            invAkhir = DB.GetRangeValue(txtInvAwal, txtInvAkhir, 1);
            subAwal = DB.GetRangeValue(txtSubAwal, txtSubAkhir, 0);
            subAkhir = DB.GetRangeValue(txtSubAwal, txtSubAkhir, 1);
            loca = DB.GetRangeValue(txtLocAwal, txtLocAkhir, 0);
            locz = DB.GetRangeValue(txtLocAwal, txtLocAkhir, 1);
        
            dtResult = new DataTable();
            if (this.Tag.ToString() == "63357")
                query = "Call sp_selisihQty(@tglawal,@tglakhir,'@subawal','@subakhir','@invawal','@invakhir')";
            else 
               if (this.Tag.ToString()=="63384")
                  query = "Call SP_LapSJPenjualanT(@tglawal,@tglakhir,'@subawal','@subakhir','@invawal','@invakhir','@loca','@locz',2)";
               else
                  query = "Call SP_LapSJPenjualanT(@tglawal,@tglakhir,'@subawal','@subakhir','@invawal','@invakhir','@loca','@locz',1)";
            // replace params
            query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir);
            query = query.Replace("@subawal", subAwal).Replace("@subakhir", subAkhir);
            query = query.Replace("@invawal", invAwal).Replace("@invakhir", invAkhir);
            query = query.Replace("@loca", loca).Replace("@locz", locz);
            dtResult = DB.sql.Select(query);
            
        }

        private void UpdateReport()
        {
            string periode = "Periode: " + dtpTglAwal.DateTime.ToString("dd/MM/yyyy") + " - " + dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
            this.Report.Bands[BandKind.ReportHeader].Controls["xrLabel1"].Text = periode;
            this.Report.Bands[BandKind.PageFooter].Controls["xrLabelUser"].Text = DB.casUser.Name;
            if (this.Tag.ToString() == "63385")
            this.Report.Bands[BandKind.ReportHeader].Controls["xrLabel2"].Text = "Surat Jalan Retur";
        }

        private void FrmLSJPenjualanT_Load(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "63357")
            {
                txtSubAkhir.ExSqlQuery = txtSubAwal.ExSqlQuery = "call SP_Lookup('customer')";
                label2.Text = "Customer";  

            }
        }
    }
}

