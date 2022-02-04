using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using KASLibrary;

namespace CAS.Master
{
    public partial class FrmMasterKwalitet : CAS.Master.BaseMaster
    {
        double pengaliBF, pengaliCF = 0;

        public FrmMasterKwalitet()
        {
            InitializeComponent();

            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
            tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
        }

        void tsbtnCancel_Click(object sender, EventArgs e)
        {
            btnProses.Enabled = false;
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            btnProses.Enabled = true;
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            ludKode1.EditValue = ludKode2.EditValue = ludKode3.EditValue = ludKode4.EditValue = ludKode5.EditValue = null;
            txtBerat.EditValue = 0;
            btnProses.Enabled = true;
        }

        private void SetLUDEditValue(DevExpress.XtraEditors.LookUpEdit lud, string kode)
        {
            if (kode == " ")
                lud.EditValue = null;
            else
                lud.EditValue = kode;
        }

        private string GetLUDEditValue(DevExpress.XtraEditors.LookUpEdit lud)
        {
            if (lud.EditValue == null)
               return lud.Properties.NullText;
            else
               return lud.EditValue.ToString();
        }

        private void ParseNoSeri()
        {
            if (MasterBindingSource.Position < 0) return;
            //if (MasterTable.Rows.Count == 0) return;

            string no = MasterTable.Rows[MasterBindingSource.Position][0].ToString();
            SetLUDEditValue(ludKode1, no.Split('-')[0]);
            SetLUDEditValue(ludKode2, no.Split('-')[1]);
            SetLUDEditValue(ludKode3, no.Split('-')[2]);
            SetLUDEditValue(ludKode4, no.Split('-')[3]);
            SetLUDEditValue(ludKode5, no.Split('-')[4]);
        }

        private void FrmMasterKwalitet_Load(object sender, EventArgs e)
        {
            string query = "select kode, ket from ukuran";
            DataTable dtUkuran = DB.sql.Select(query);
            ludKode1.Properties.DataSource = dtUkuran;
            ludKode1.Properties.DisplayMember = "kode";
            ludKode1.Properties.ValueMember = "kode";
            
            ludKode2.Properties.DataSource = dtUkuran;
            ludKode2.Properties.DisplayMember = "kode";
            ludKode2.Properties.ValueMember = "kode";

            ludKode3.Properties.DataSource = dtUkuran;
            ludKode3.Properties.DisplayMember = "kode";
            ludKode3.Properties.ValueMember = "kode";

            ludKode4.Properties.DataSource = dtUkuran;
            ludKode4.Properties.DisplayMember = "kode";
            ludKode4.Properties.ValueMember = "kode";

            ludKode5.Properties.DataSource = dtUkuran;
            ludKode5.Properties.DisplayMember = "kode";
            ludKode5.Properties.ValueMember = "kode";

            lapisTextBoxEx.ExSqlInstance = DB.sql;

            Utility.SetNumberFormat(txtBerat, "n2");
            //ParseNoSeri();
            if (this.mode == Mode.New)
                btnProses.Enabled = true;
            else
                btnProses.Enabled = false;
        }
      
        protected override void  tsbtnSave_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();

            if (GetLUDEditValue(ludKode1) == " " && GetLUDEditValue(ludKode2) == " " &&
                GetLUDEditValue(ludKode3) == " " && GetLUDEditValue(ludKode4) == " " &&
                GetLUDEditValue(ludKode5) == " ")
            {
                MessageBox.Show("Please enter kode");
                return;
            }

            if (isDW() && !lapisTextBoxEx.EditValue.ToString().Contains("DW"))
            {
                MessageBox.Show("Lapis tidak sesuai");
                return;
            }

            string kode = GetLUDEditValue(ludKode1) + "-" + GetLUDEditValue(ludKode2) + "-" +
                GetLUDEditValue(ludKode3) + "-" + GetLUDEditValue(ludKode4) + "-" +
                GetLUDEditValue(ludKode5);
            int lastNum = 1;
            DataTable dtMaxNum = DB.sql.Select("select max(no) from kwalitet");
            if (dtMaxNum.Rows[0][0] != DBNull.Value)
                lastNum = int.Parse(dtMaxNum.Rows[0][0].ToString()) + 1;
            ((DataRowView)MasterBindingSource.Current).Row["no"] = lastNum;
            ((DataRowView)MasterBindingSource.Current).Row["kode"] = kode;
 	        base.tsbtnSave_Click(sender, e);
            if (this.mode == Mode.View)
                btnProses.Enabled = false;
        }

        private void kwalitetBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (MasterBindingSource.Position != MasterTable.Rows.Count)
                ParseNoSeri();
        }

       private bool isDW()
        {
            if (ludKode2.Text != " " && ludKode3.Text != " " && ludKode4.Text != " ")
                return true;
            return false;
        }

        private double GetMValue(string value, string lapis)
        {
            if (lapis.Contains("BF"))
                return Convert.ToDouble(value) * pengaliBF;
            else
                return Convert.ToDouble(value) * pengaliCF;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (lapisTextBoxEx.EditValue.ToString() == "")
                    throw new Exception("Harap mengisi SW/DW");
                DataTable dtMSetting = DB.sql.Select("select * from msetting");
                pengaliCF = Convert.ToDouble((dtMSetting.Select("name='Pengali CF'"))[0]["value"]);
                pengaliBF = Convert.ToDouble((dtMSetting.Select("name='Pengali BF'"))[0]["value"]);
                string[] kwa = new string[5];
                kwa[0] = GetLUDEditValue(ludKode1);
                kwa[1] = GetLUDEditValue(ludKode2);
                kwa[2] = GetLUDEditValue(ludKode3); 
                kwa[3] = GetLUDEditValue(ludKode4); 
                kwa[4] = GetLUDEditValue(ludKode5);
                string lapis = lapisTextBoxEx.EditValue.ToString();
                bool leftIsM = false;
                bool rightIsM = false;
                double m = DB.GetMediumValue(pengaliBF, pengaliCF, kwa, lapis, ref leftIsM, ref rightIsM);
                double bk = 0;
                if (!leftIsM)
                {
                    bk = Convert.ToDouble(kwa[0].ToString().Substring(0, 3));
                    if (bk == 127) bk = 125;
                }
                if (!rightIsM)
                {
                    double tbk = Convert.ToDouble(kwa[4].ToString().Substring(0, 3));
                    if (tbk == 127) tbk = 125;
                    bk = bk + tbk;
                }
                txtBerat.EditValue = (m + bk).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

   }
}

