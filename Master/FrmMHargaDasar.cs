using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using KASLibrary;
using DevExpress.XtraGrid.Views.Grid;

namespace CAS.Master
{
    public partial class FrmMHargaDasar : CAS.Master.BaseMaster
    {
        MySqlDataAdapter daDHrgDasar = new MySqlDataAdapter();
        DataTable dtMSetting = new DataTable();
        DataTable dtGrp = new DataTable();
        double pengaliCF, pengaliBF;

        public FrmMHargaDasar()
        {
            InitializeComponent();

            Utility.SetSqlInstance(pnlDetail, DB.sql);

            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
         //   tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            //tsbtnDelete.Click += new EventHandler(tsbtnDelete_Click);
            gcDHarga.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(gvDelete_Click);
            //gcDHarga.ExGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(ExGridView_FocusedRowChanged);
            gcDHarga.ExGridView.OptionsSelection.MultiSelect = true;
            SetEditableGridControl(false);
        }

        private void FrmMHargaDasar_Load(object sender, EventArgs e)
        {
            gcDHarga.ExTitleLabel.Visible = false;
            //gcDHarga.ExGridView.OptionsBehavior.Editable = false;
            hrgdasarBindingSource_PositionChanged(sender, new EventArgs());
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            dhrgdasarBindingSource.AllowNew = true;
            SetEditableGridControl(true);
            gcDHarga.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gcDHarga.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
        }

      
        void tsbtnNew_Click(object sender, EventArgs e)
        {
            tglawalDateEdit.EditValue = tglakhirDateEdit.EditValue = DB.loginDate;

            SetEditableGridControl(true);
            ((DataRowView)MasterBindingSource.Current).Row["kode"] = "";
            gcDHarga.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gcDHarga.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
        }

        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gcDHarga.ExGridView.GetDataRow(e.RowHandle);
            row["kode"] = "";
            row["inv"] = "";
            row["remark"] = "";
            row["harga"] = 0;
            //row["grp"] = "";
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();
            if (gcDHarga.ExGridView.EditingValue != null)
                gcDHarga.ExGridView.SetFocusedValue(gcDHarga.ExGridView.EditingValue);
            DataTable maxNum = DB.sql.Select("select max(right(kode,3)) from hrgdasar");
            int lastNum = 1;
            if (maxNum.Rows[0][0] != DBNull.Value)
                lastNum = int.Parse(maxNum.Rows[0][0].ToString()) + 1;
            string kode = "H" + tglawalDateEdit.DateTime.Year.ToString().Substring(2) + tglawalDateEdit.DateTime.Month.ToString("00") + lastNum.ToString("000");
            ((DataRowView)MasterBindingSource.Current).Row["kode"] = kode;
            foreach (DataRow dr in casDataSet.dhrgdasar)
                dr["kode"] = kode;
            base.tsbtnSave_Click(sender, e);
            dhrgdasarBindingSource.EndEdit();
            daDHrgDasar.Update(casDataSet.dhrgdasar);
            SetEditableGridControl(false);
        }

        //void tsbtnDelete_Click(object sender, EventArgs e)
        //{
        //}

        void gvDelete_Click(object sender, EventArgs e)
        {
        }

        void SetEditableGridControl(bool mode)
        {
            gcDHarga.ExGridView.OptionsBehavior.Editable = mode;
            gcDHarga.ExToolStrip.Items["tsbtnDelete"].Enabled = mode;
        }

        private void hrgdasarBindingSource_PositionChanged(object sender, EventArgs e)
        {
            try
            {
                casDataSet.dhrgdasar.Clear();
                daDHrgDasar = DB.sql.SelectAdapter("Select * from dhrgdasar where kode='" + ((DataRowView)MasterBindingSource.Current).Row["kode"].ToString() + "'");
                daDHrgDasar.Fill(casDataSet.dhrgdasar);
                gcDHarga.ExGridControl.DataSource = dhrgdasarBindingSource;
                //gcDHarga.ExGridView.OptionsBehavior.Editable = true;
                gcDHarga.ExGridView.Columns["kode"].Visible = false;
                gcDHarga.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                gcDHarga.ExGridView.Columns["inv"].Caption = "Kode Barang";
                gcDHarga.ExGridView.Columns["remark"].Caption = "Nama Barang";
                gcDHarga.ExGridView.Columns["harga"].Caption = "Harga";
          
                gcDHarga.ExGridView.Columns["inv"].ColumnEdit = new GridLookUpEx(DB.sql, "select inv as `Kode Barang`, name as `Nama Barang` from inv ", "mkertas", "kode", gcDHarga.ExGridView, "", true, false, "Material");

                gcDHarga.ExGridView.Columns["remark"].Caption = "Nama Barang";
            //    gcDHarga.ExGridView.Columns["kertas"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('mkertas')", "mkertas", "kode", gcDHarga.ExGridView, "", false, false, "Tipe Kertas");
                gcDHarga.ExGridView.Columns["harga"].Caption = "Harga";
                gcDHarga.ExGridView.Columns["harga"].ColumnEdit = new GridNumEx(500);
                gcDHarga.ExGridView.BestFitColumns();
            }
            catch { }
        }

        private double GetMValue(string value, string lapis)
        {
            if (lapis.Contains("BF"))
                return Convert.ToDouble(value) * pengaliBF;
            else
                return Convert.ToDouble(value) * pengaliCF;
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            if (!aktifCheckBox.Checked)
            {
                MessageBox.Show("Harga sudah tidak berlaku");
                return;
            }

            try
            {
                //get pengali
                dtMSetting = DB.sql.Select("select * from msetting");
                //get group
                dtGrp = DB.sql.Select("select * from grphrgdasar");

                pengaliCF = Convert.ToDouble((dtMSetting.Select("name='Pengali CF'"))[0]["value"]);
                pengaliBF = Convert.ToDouble((dtMSetting.Select("name='Pengali BF'"))[0]["value"]);
                //double paperCost = Convert.ToDouble((dtMSetting.Select("name='Paper Cost'"))[0]["value"]);
                double tambahHargaJKT = Convert.ToDouble((dtMSetting.Select("name='Tambah Harga JKT'"))[0]["value"]);

                //get harga dasar
                DataTable dtHrgDasar = casDataSet.dhrgdasar;

                //proses hitung harga group
                string[] kwa = new string[5];
                string lapis;
                double bk, m, valBK, valM, harga, paperCost;
                bool leftIsM, rightIsM;
                DataTable dtKwa = DB.sql.Select("select no, kode, lapis, berat from kwalitet");
                
                //foreach (DataRow drGrp in dtGrp.Rows)
                //{
                    foreach (DataRow dr in dtKwa.Rows)
                    {
                        //m = 0;
                        //kwa[0] = M5, kwa[1]=M4, kwa[2]=M3, kwa[3]=M2, kwa[4]=M1
                        kwa = dr["kode"].ToString().Split('-');
                        lapis = dr["lapis"].ToString();

                        leftIsM = rightIsM = false;
                        m = DB.GetMediumValue(pengaliBF, pengaliCF, kwa, lapis, ref leftIsM, ref rightIsM);

                        harga=0;
                        if (dtHrgDasar.Select("kertas='M'").Length > 0)
                            harga = Convert.ToDouble(dtHrgDasar.Select("kertas='M'")[0]["harga"]);
                        valM = m * harga / 1000;

                        bk = 0;
                        valBK = 0;
                        if (!leftIsM)
                        {
                            string tipe = kwa[0].ToString().Substring(3, kwa[0].ToString().Length - 3);
                            bk = Convert.ToDouble(kwa[0].ToString().Substring(0, 3));
                            if (bk == 127) bk = 125;
                            harga = 0;
                            if (dtHrgDasar.Select("kertas='" + tipe + "'").Length > 0)
                                harga = Convert.ToDouble(dtHrgDasar.Select("kertas='" + tipe + "'")[0]["harga"]);
                            valBK = bk * harga / 1000;
                        }
                        if (!rightIsM)
                        {
                            string tipe = kwa[4].ToString().Substring(3, kwa[4].ToString().Length - 3);
                            double tbk = Convert.ToDouble(kwa[4].ToString().Substring(0, 3));
                            if (tbk == 127) tbk = 125;
                            harga = 0;
                            if (dtHrgDasar.Select("kertas='" + tipe + "'").Length > 0)
                                harga = Convert.ToDouble(dtHrgDasar.Select("kertas='" + tipe + "'")[0]["harga"]);
                            //untuk saat ini asumsinya tipe kiri dan kanan sama                        
                            bk = bk + tbk;
                            valBK = valBK + tbk * harga / 1000;
                        }

                        string grp = ((DataRowView)MasterBindingSource.Current).Row["grp"].ToString();
                        paperCost = Convert.ToDouble(dtGrp.Select("kode='" + grp + "'")[0]["ongkos"]);
                        double hargaKg= Math.Round((1000 / (bk + m)) * (valM + valBK) + paperCost);
                        double hargaM2 = Math.Round(hargaKg * Convert.ToDouble(dr["berat"]) / 1000);

                        string query = "replace into dhrggroup values('@kode',@kwalitet,@hrgm2,@hrgkg)";
                        query = query.Replace("@kode", dtHrgDasar.Rows[0][0].ToString());
                        query = query.Replace("@kwalitet", dr["no"].ToString());
                        query = query.Replace("@hrgm2", hargaM2.ToString());
                        query = query.Replace("@hrgkg", hargaKg.ToString());

                        DB.sql.Execute(query);
                    }
               // }                

                MessageBox.Show("Proses selesai");
            }     
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

