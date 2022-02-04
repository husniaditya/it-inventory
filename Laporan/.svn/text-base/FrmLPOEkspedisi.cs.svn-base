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
    public partial class FrmLPOEkspedisi : CAS.Laporan.BaseLaporan
    {
        public FrmLPOEkspedisi()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlFilter, DB.sql);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                CollectData();
                this.ReportName = "RepPOEkspedisi";
                LoadReport();
                UpdateReport();
                PreviewReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmLPOEkspedisi_Load(object sender, EventArgs e)
        {
            switch (this.Tag.ToString())
            {
                case "63127":
                    this.Text = "Laporan PO Tanpa Harga";
                    txtOmsAwal.ExSqlQuery = txtOmsAkhir.ExSqlQuery = "select oms.oms as `No PO`, oms.`date` as Tanggal, oms.sub as `Kode Supplier`, sub.name as `Nama Supplier`,concat(loc.name,' (',omd.loc,')') as Storloc, concat(omd.inv,' - ',omd.remark) as Barang, concat(ifnull(omd.qty1,0),' ',omd.unit) as Jumlah, omd.prq as `No PR`  from loc,oms,omd,sub where oms.`delete`=0 and left(oms.oms,3)='POL' and oms.oms=omd.oms and omd.loc=loc.loc and oms.sub=sub.sub";
                    break;
                case "63128":
                    this.ReportName = "Laporan PO IMPORT Tanpa Harga";
                    txtOmsAwal.ExSqlQuery = txtOmsAkhir.ExSqlQuery = "select oms.oms as `No PO`, oms.`date` as Tanggal, oms.sub as `Kode Supplier`, sub.name as `Nama Supplier`,ifnull(concat(loc.name,' (',omd.loc,')'),'') as Storloc, concat(omd.inv,' - ',omd.remark) as Barang, concat(ifnull(omd.qty1,0),' ',omd.unit) as Jumlah, omd.prq as `No PR`  from oms,sub,omd left join loc on omd.loc=loc.loc where oms.`delete`=0 and left(oms.oms,3)='POI' and oms.oms=omd.oms and oms.sub=sub.sub";
                    break;
            }
        }
        private void CollectData()
        {
            string query = "";
            string omsawal = txtOmsAwal.Text;
            string omsakhir = txtOmsAkhir.Text;
            if (omsakhir == "") omsakhir = "Z";
            query = txtOmsAwal.ExSqlQuery;
            query = query + " and oms.oms between '@omsawal' and '@omsakhir'";
            query = query.Replace("@omsawal", omsawal).Replace("@omsakhir", omsakhir);
            dtResult = new DataTable();
            dtResult = DB.sql.Select(query);
        }

        private void UpdateReport()
        {
            switch (this.Tag.ToString())
            {
                case "63127":
                    this.Report.Bands[BandKind.ReportHeader].Controls["xrLabelJudul"].Text = "Laporan PO Tanpa Harga";
                    break;
                case "63128":
                    this.Report.Bands[BandKind.ReportHeader].Controls["xrLabelJudul"].Text = "Laporan PO IMPORT Tanpa Harga";
                    break;
            }
            this.Report.Bands[BandKind.PageFooter].Controls["xrLabelUser"].Text = DB.casUser.Name;
        }
    }
}