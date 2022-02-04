using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DevExpress.XtraReports.UI;
using KASLibrary;

namespace CAS.Master
{
    public partial class FrmMHrgGroup : CAS.Master.BaseMaster
    {
        DataTable DetailTable = new DataTable();

        public FrmMHrgGroup()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlKey, DB.sql);
            tsbtnPrint.Click += new EventHandler(tsbtnPrint_Click);
            gcDHargaGroup.ExTitleLabel.Visible = false;
        }

        void tsbtnPrint_Click(object sender, EventArgs e)
        {
            if (Convert.ToUInt64(((DataRowView)MasterBindingSource.Current).Row["aktif"]) == 1)
            {
                string tglAwal = ((DateTime)tglawalDateEdit.EditValue).ToString("yyyyMMdd");
                string tglAkhir = ((DateTime)tglakhirDateEdit.EditValue).ToString("yyyyMMdd"); 
                DataSet dsharga = new DataSet();
                string kode = ((DataRowView)MasterBindingSource.Current).Row["kode"].ToString();
                string query = "select hd.harga, concat('Harga ', m.nama) as nama from ";
                query += "dhrgdasar hd, hrgdasar h, mkertas m where h.kode='" + kode + "' and ";
                query += "hd.kode=h.kode and hd.kertas=m.kode and h.tglawal=" + tglAwal + " and ";
                query += "h.tglakhir=" + tglAkhir;
                DataTable dtHargaDasar = DB.sql.Select(query) ;                
                DataTable dtHargaGroup = DB.sql.Select("Call SP_Printharga(0,'" + kode + "')");
                dsharga.Tables.Add(dtHargaDasar);
                dsharga.Tables.Add(dtHargaGroup);
                string path = Application.StartupPath + "\\Reports\\" + "RepHargaGroup" + ".repx";
                XtraReport report = new XtraReport();
                report.LoadState(path);                
                report.DataSource = dsharga;
                report.Bands[BandKind.PageHeader].Controls["lblBerlaku"].Text = "Berlaku per tgl: " + ((DateTime)tglawalDateEdit.EditValue).ToString("dd MMMM yyyy");
                report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;

                report.ShowPreview();
                //for report editing
                //report.RunDesignerDialog();
            }
            else
                MessageBox.Show("Harga sudah tidak berlaku");
        }
        
        private void FrmMHrgGroup_Load(object sender, EventArgs e)
        {
            MasterNavigator.Items["tsbtnNew"].Enabled = false;
            MasterNavigator.Items["tsbtnEdit"].Enabled = false;
            MasterNavigator.Items["tsbtnSave"].Enabled = false;
            MasterNavigator.Items["tsbtnCancel"].Enabled = false;
            MasterNavigator.Items["tsbtnDelete"].Enabled = false;

            hrgdasarBindingSource_PositionChanged(sender, new EventArgs());
        }

        private void hrgdasarBindingSource_PositionChanged(object sender, EventArgs e)
        {
            try
            {
                DetailTable.Clear();
                string query = "select distinct (concat(k.kode,' ',k.lapis)) as kwalitet, ";
                query += "k.berat, d.hrgm2, d.hrgkg from ";
                query += "dhrggroup d, kwalitet k where d.kode='";
                query += ((DataRowView)MasterBindingSource.Current).Row["kode"] + "' and ";
                query += "d.kwalitet=k.no";
                DetailTable = DB.sql.Select(query);
                gcDHargaGroup.ExGridControl.DataSource = DetailTable;
                gcDHargaGroup.ExGridView.Columns["kwalitet"].Caption = "Substance";
                gcDHargaGroup.ExGridView.Columns["berat"].Caption = "Grammatur";
                gcDHargaGroup.ExGridView.Columns["hrgm2"].Caption = "Harga M2";
                gcDHargaGroup.ExGridView.Columns["hrgkg"].Caption = "Harga Kg";
                gcDHargaGroup.ExGridView.BestFitColumns();
            }
            catch { }
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            if (!aktifCheckBox.Checked)
            {
                MessageBox.Show("Harga sudah tidak berlaku");
                return;
            }

            //hitung harga per brg jadi
            try
            {
                string kode = ((DataRowView)MasterBindingSource.Current).Row["kode"].ToString();
                string grp = ((DataRowView)MasterBindingSource.Current).Row["grp"].ToString();
                DataTable dtHrgGroup = DB.sql.Select("select * from dhrggroup where kode='" + kode + "'");
                DataTable dtDsg = DB.sql.Select("select * from dsg where aktif=1 and grp='" + grp + "'");
                foreach (DataRow dr in dtDsg.Rows)
                {
                    double A = Convert.ToDouble(dr["PKertas"]) * Convert.ToDouble(dr["LKertas"]) / 1000000;
                    double hrgM2 = 0;                    
                    if (dtHrgGroup.Select("kwalitet=" + dr["kwalitet"].ToString()).Length>0)
                      hrgM2 = Convert.ToDouble((dtHrgGroup.Select("kwalitet=" + dr["kwalitet"].ToString())[0]["hrgm2"]));
                    double hrgJual = Math.Round(A * hrgM2 * (Convert.ToDouble(dr["counter"]) / 1000));
                    hrgJual = Utility.RoundTo(hrgJual, 5);
                    string query = "replace into dhrgdsg values('@kode','@nodsg',@harga)";
                    query = query.Replace("@kode",kode);
                    query = query.Replace("@nodsg", dr["nodsg"].ToString());
                    query = query.Replace("@harga", hrgJual.ToString());
                    DB.sql.Execute(query);
                }

                MessageBox.Show("Hitung harga selesai");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrintPriceList_Click(object sender, EventArgs e)
        {
            if (!aktifCheckBox.Checked)
            {
                MessageBox.Show("Harga sudah tidak berlaku");
                return;
            }
            string tglAwal = ((DateTime)tglawalDateEdit.EditValue).ToString("yyyyMMdd");
            string tglAkhir = ((DateTime)tglakhirDateEdit.EditValue).ToString("yyyyMMdd");
            string kode = ((DataRowView)MasterBindingSource.Current).Row["kode"].ToString();
            DataTable dtHargaDsg = DB.sql.Select("Call SP_Printharga(1,'" + kode + "')");
            string path = Application.StartupPath + "\\Reports\\" + "RepPriceList" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = dtHargaDsg;
            report.Bands[BandKind.GroupHeader].Controls["lblBerlaku"].Text = "Berlaku per tgl: " + ((DateTime)tglawalDateEdit.EditValue).ToString("dd MMMM yyyy");
            report.Bands[BandKind.GroupFooter].Controls["lblUser"].Text = DB.casUser.Name;
            report.ShowPreview();
        }
    }
}

