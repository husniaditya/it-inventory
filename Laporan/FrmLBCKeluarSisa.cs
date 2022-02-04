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
    public partial class FrmLBCKeluarSisa : CAS.Laporan.BaseLaporan
    {
        public FrmLBCKeluarSisa()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
           
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                CollectData();
                switch (this.Tag.ToString())
                {
                    case "6i3":
                        this.ReportName = "LapBCPertanggunganbrgjadi";
                        break;
                    case "6i4":
                        this.ReportName = "LapBCPertanggunganbahan";
                        break;
                    case "6i5":
                        this.ReportName = "LapBCPertanggunganScrap";
                        break;
                    case "6i6":
                        this.ReportName = "LapBCPertanggunganMesinAlat";
                        break;
                    case "6i7":
                        this.ReportName = "LapBCPosisiWIP";
                        break;
                    case "6i8":
                        this.ReportName = "LapBCKeluarSisa";
                        break;
                }

                //if (this.Tag.ToString() == "6i3")
                //{
                //    this.ReportName = "LapBCPertanggunganbrgjadi";
                //}
                //else
                //{
                //    this.ReportName = "LapBCPertanggunganbahan";
                //}

                LoadReport();
                UpdateData();
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
            string inva = DB.GetRangeValue(txtInvAwal, txtInvAkhir , 0);
            string invz = DB.GetRangeValue(txtInvAwal, txtInvAkhir , 1);
           
            string query="";
            dtResult = new DataTable();
             switch (this.Tag.ToString())
                {
                    case "6i3":
                      query = "Call Sp_BCBrgJadiweb(@tglawal, @tglakhir,'@invawal','@invakhir')";
                      break ;
                   case "6i4":
                      query = "Call Sp_BCBahanWeb(@tglawal, @tglakhir, '@invawal','@invakhir')";
                      break ;
                  case "6i5":
                      query = "Call Sp_BC_scrap(@tglawal, @tglakhir, '','z','','z','','z','','z')";
                      break;
                  case "6i6":
                      query = "Call Sp_BCMesin(@tglawal, @tglakhir, '@invawal','@invakhir')";
                      break;
                  case "6i7":
                      query = "Call Sp_BCWIP(@tglawal, @tglakhir)";
                      break;
                  case "6i8":
                      query = "Call Sp_BCPengeluaranSisa(@tglawal, @tglakhir)";
                      break;

             }

            //{
            //    query = "Call Sp_BCBrgJadi(@tglawal, @tglakhir,'@invawal','@invakhir')";
            //}
            //else
            //{
            //    query = "Call Sp_BCBahan(@tglawal, @tglakhir, '@invawal','@invakhir')";
            //}
            // replace params
            query = query.Replace("@tglawal", tglAwal).Replace("@tglakhir", tglAkhir);
            query = query.Replace("@invawal", inva).Replace("@invakhir", invz);
            dtResult = DB.sql.Select(query);    
    
        }

        private void UpdateData()
        {
          
        }

        private void UpdateReport()
        {
           // this.Report.Bands[BandKind.ReportHeader].Controls["xrLabelTanggal"].Text = dtpTglAwal.DateTime.ToString("dd/MM/yyyy") + " - " + dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
        //    this.Report.Bands[BandKind.PageFooter].Controls["xrLabelUser"].Text = DB.casUser.User;
            string tanggal = dtpTglAwal.DateTime.ToString("dd/MM/yyyy") + " - " + dtpTglAkhir.DateTime.ToString("dd/MM/yyyy");
            this.Report.Bands[BandKind.PageHeader].Controls["lblperiod"].Text = tanggal;
        }

        private void txtSubAwal_EditValueChanged(object sender, EventArgs e)
        {
          
        
        }

       private void txtSubAkhir_EditValueChanged(object sender, EventArgs e)
       {
           
       }

        private void FrmLBCMasukKeluar_Load(object sender, EventArgs e)
        {
            dtpTglAwal.DateTime = dtpTglAkhir.DateTime = DB.loginDate;
            if (this.Tag.ToString() == "6i7")
            {
                label5.Visible = false;
                txtInvAwal.Visible = false;
                txtInvAkhir.Visible = false;
            }
            if (this.Tag.ToString() == "6i6")
            {
                txtInvAwal.ExSqlQuery = "select akt as `Kode Barang`, name as `Nama Barang` from akt where akt.acc not in ('12030101','12030102','12030104') and akt.name <>''";
                txtInvAkhir.ExSqlQuery = "select akt as `Kode Barang`, name as `Nama Barang` from akt where akt.acc not in ('12030101','12030102','12030104') and akt.name <>''";
            }
        }

       
       
    }
}

