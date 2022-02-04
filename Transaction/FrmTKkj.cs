using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KASLibrary;
using DevExpress.XtraReports.UI;

namespace CAS.Transaction
{

    public partial class FrmTKkj : CAS.Master.BaseMaster
    {
        Boolean scroll = false;

        public FrmTKkj()
        {
           
            InitializeComponent();
            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
            tsbtnDelete.Click += new EventHandler(tsbtnDelete_Click);
            cctTextBoxEx.ExSqlInstance = DB.sql;
            tsbtnPrint.Click += new EventHandler(tsbtnPrint_Click);
            MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);

        }

        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            calculate_total(); 
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            periodTextEdit.EditValue = DB.loginPeriod;
        }

        void calculate_total()
        {
            tot6.EditValue = ((double)spinEdit6.Value + (double)spinEdit10.Value) /
                            (((double)spinEdit3.Value * (double)rm2.Value) + ((double)spinEdit4.Value * (double)rm3.Value) + ((double)spinEdit14.Value * (double)rm4.Value)) * 100;
            if (cctTextBoxEx.EditValue != null)
            {
                if (cctTextBoxEx.EditValue.ToString() == "111101" || cctTextBoxEx.EditValue.ToString() == "111105" || cctTextBoxEx.EditValue.ToString() == "111106" || cctTextBoxEx.EditValue.ToString() == "111111" || cctTextBoxEx.EditValue.ToString() == "111123")  //untuk refinery
                {
                    tot7.EditValue = ((double)spinEdit7.Value + (double)spinEdit11.Value) /
                                (((double)spinEdit3.Value * (double)rm2.Value) + ((double)spinEdit4.Value * (double)rm3.Value) + ((double)spinEdit14.Value * (double)rm4.Value)) * 100;
                }
                else
                    tot7.EditValue = ((double)spinEdit7.Value + (double)spinEdit11.Value) /
                                 (((double)spinEdit3.Value * (double)pack2.Value) + ((double)spinEdit4.Value * (double)pack3.Value) + ((double)spinEdit14.Value * (double)pack4.Value)) * 100;

                tot11.EditValue = ((double)spinEdit21.Value) /
                                          (((double)spinEdit3.Value * (double)pack2.Value) + ((double)spinEdit4.Value * (double)pack3.Value) + ((double)spinEdit14.Value * (double)pack4.Value)) * 100 ;
                tot8.EditValue = ((double)spinEdit8.Value + (double)spinEdit12.Value) /
                                         (((double)spinEdit3.Value * (double)dl2.Value) + ((double)spinEdit4.Value * (double)dl3.Value)) * 100;
                tot9.EditValue = (((double)spinEdit9.Value + (double)spinEdit13.Value) /
                                      (((double)spinEdit3.Value * (double)foh2.Value) + ((double)spinEdit4.Value * (double)foh3.Value) + ((double)spinEdit14.Value * (double)foh4.Value))) * 100;
                tot10.EditValue = (double)tot6.Value + (double)tot7.Value + (double)tot11.Value + (double)tot8.Value + (double)tot9.Value;

                spinEdit20.EditValue = (double)tot10.Value * (double)spinEdit3.Value;
                spinEdit22.EditValue = (double)tot10.Value * (double)spinEdit14.Value;
                spinEdit15.EditValue = (double)spinEdit4.Value * (double)rm3.Value * (double)tot6.Value / 100;
                spinEdit16.EditValue = (double)spinEdit4.Value * (double)rm3.Value * (double)tot7.Value / 100;
                spinEdit19.EditValue = (double)spinEdit4.Value * (double)dl3.Value * (double)tot8.Value / 100;
                spinEdit17.EditValue = (double)spinEdit4.Value * (double)foh3.Value * (double)tot9.Value / 100;
                spinEdit18.EditValue = (double)spinEdit15.Value + (double)spinEdit16.Value + (double)spinEdit17.Value + (double)spinEdit19.Value;
                tspinEdit10.EditValue = (double)spinEdit20.Value + (double)spinEdit22.Value + (double)spinEdit18.Value;

                tot1.EditValue = (double)spinEdit1.Value + (double)spinEdit2.Value;
                spinEdit5.EditValue = (double)spinEdit1.Value + (double)spinEdit2.Value - (double)spinEdit3.Value - (double)spinEdit4.Value - (double)spinEdit14.Value;
                tot2.EditValue = (double)spinEdit3.Value + (double)spinEdit4.Value + (double)spinEdit5.Value + (double)spinEdit14.Value;
                tot3.EditValue = (double)spinEdit6.Value + (double)spinEdit7.Value + (double)spinEdit8.Value + (double)spinEdit9.Value;
                tot4.EditValue = (double)spinEdit10.Value + (double)spinEdit11.Value + (double)spinEdit21.Value + (double)spinEdit12.Value + (double)spinEdit13.Value;
                tot5.EditValue = (double)tot3.Value + (double)tot4.Value;
            }
        }


        private void cctTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {
            if (cctTextBoxEx.EditValue.ToString() == "111101" || cctTextBoxEx.EditValue.ToString() == "111105" || cctTextBoxEx.EditValue.ToString() == "111106" || cctTextBoxEx.EditValue.ToString() == "111107" || cctTextBoxEx.EditValue.ToString() == "111110" || cctTextBoxEx.EditValue.ToString() == "111111" || cctTextBoxEx.EditValue.ToString() == "111122" || cctTextBoxEx.EditValue.ToString() == "111123")  //untuk refinery
            {
                label17.Text = label24.Text = label30.Text = "Raw material additional";
                label11.Text = label50.Text = "Finish & transfer to fraction";
            }

            if (cctTextBoxEx.EditValue.ToString() == "111102")  //untuk refinery
             {
                label11.Text = label50.Text = "Finish & transfer";

                label17.Text = label24.Text = "Pakaging";
             }

             if (cctTextBoxEx.EditValue.ToString() != "" )
            {               
                periodTextEdit.EditValue = DB.loginPeriod;
                DateTime dtptglawal = Utility.FirstDateInMonth(DB.loginDate);
                string periodlalu = dtptglawal.AddDays(-2).ToString("yyMM");

                DataTable dtkkhlalu = DB.sql.Select("select * from kkh where cct='" + cctTextBoxEx.EditValue.ToString() + "' and period='" + periodlalu + "'");
                DataTable dtlhp = DB.sql.Select("select sum(qty) as qty from lhd,lhp where lhd.lhp=lhp.lhp and lhp.period='" + DB.loginPeriod + "' and lhp.cct='" + cctTextBoxEx.EditValue.ToString() + "' and `delete` = 0");
                DataTable dthppr = DB.sql.Select("call sp_cost_analisys ('" + DB.loginPeriod +"','" + cctTextBoxEx.EditValue.ToString() + "')");
                DataTable dtovh = DB.sql.Select("Call SP_BOP('" + periodTextEdit.EditValue.ToString() + "',2)");
                DataTable dtprosenovh = DB.sql.Select("select prosen/100 as prosent from prosenbop where cct='" + cctTextBoxEx.EditValue.ToString() + "' and period= '" +DB.loginPeriod + "' and nama='foh'");
                DataTable dtprosenovhfrak = DB.sql.Select("select prosen/100 as prosent from prosenbop where cct='" + cctTextBoxEx.EditValue.ToString() + "' and period= '" + DB.loginPeriod + "' and nama='foh fraksinasi'");
                DataTable dtprosenovhkemasan = DB.sql.Select("select prosen/100 as prosent from prosenbop where cct='" + cctTextBoxEx.EditValue.ToString() + "' and period= '" + DB.loginPeriod + "' and nama='foh_kemasan'");
                DataTable dtprosenovhmarsho = DB.sql.Select("select prosen/100 as prosent from prosenbop where cct='" + cctTextBoxEx.EditValue.ToString() + "' and period= '" + DB.loginPeriod + "' and nama='foh_marsho'");
                DataTable dtprosenovhplastik = DB.sql.Select("select prosen/100 as prosent from prosenbop where cct='" + cctTextBoxEx.EditValue.ToString() + "' and period= '" + DB.loginPeriod + "' and nama='foh_plastik'");
            
                DataTable dtkonplastik = DB.sql.Select("SELECT * FROM prosenbop where period='" + DB.loginPeriod + "' and nama='kgplastik' and cct='111104'");
                string konpcsplas = dtkonplastik.Rows[0]["prosen"].ToString().Replace(",",".");
                DataTable dtlhp_plastik = DB.sql.Select("select sum(if(lhd.unit <> 'KG',qty * "+ konpcsplas +",qty)) as qty from lhd,lhp where lhd.lhp=lhp.lhp and lhp.period='" + DB.loginPeriod + "' and lhp.cct='111104'");
               
                if (dtkkhlalu != null && dtkkhlalu.Rows.Count==1)
                {
                    spinEdit1.EditValue = dtkkhlalu.Rows[0]["qwipbl"];
                    spinEdit6.EditValue = dtkkhlalu.Rows[0]["carm3"];
                    spinEdit7.EditValue = dtkkhlalu.Rows[0]["capack3"];
                    spinEdit8.EditValue = dtkkhlalu.Rows[0]["cadl3"];
                    spinEdit9.EditValue = dtkkhlalu.Rows[0]["caovh3"];
                }
                if (dtlhp != null && dtlhp.Rows[0]["qty"].ToString() != "")
                {
                    if (cctTextBoxEx.EditValue.ToString() == "111104")
                        spinEdit14.EditValue = Convert.ToDouble(dtlhp_plastik.Rows[0]["qty"]);
                    //* Convert.ToDouble(dtkonplastik.Rows[0]["prosen"]);
                    else
                        spinEdit14.EditValue = dtlhp.Rows[0]["qty"];
                }

                if (dthppr != null && dthppr.Rows.Count>=1)
                {
                    spinEdit10.EditValue = dthppr.Rows[0]["val"];
                    if (cctTextBoxEx.EditValue.ToString() == "111101" || cctTextBoxEx.EditValue.ToString() == "111105" || cctTextBoxEx.EditValue.ToString() == "111106" || cctTextBoxEx.EditValue.ToString() == "111107" || cctTextBoxEx.EditValue.ToString() == "111110" || cctTextBoxEx.EditValue.ToString() == "111111" || cctTextBoxEx.EditValue.ToString() == "111123")  //untuk refinery
                    {
                        spinEdit11.EditValue = dthppr.Rows[5]["val"];
                    }
                    else
                    {
                        if (cctTextBoxEx.EditValue.ToString() == "111104")
                            spinEdit10.EditValue = dthppr.Rows[5]["val"];
                        else
                        {
                            spinEdit11.EditValue = dthppr.Rows[1]["val"];
                        }
                    }
                    spinEdit21.EditValue = dthppr.Rows[2]["val"];
                    spinEdit12.EditValue = dthppr.Rows[3]["val"];

                    if (cctTextBoxEx.EditValue.ToString() == "111101" )
                       spinEdit13.EditValue = (double)dtovh.Rows[0]["refinery"];
                    if (cctTextBoxEx.EditValue.ToString() == "111105" || cctTextBoxEx.EditValue.ToString() == "111106" )
                         spinEdit13.EditValue = (double)dtovh.Rows[0]["refinery"] *(double)dtprosenovh.Rows[0]["prosent"];
                     if (cctTextBoxEx.EditValue.ToString() == "111111" || cctTextBoxEx.EditValue.ToString() == "111123")
                        spinEdit13.EditValue = ((double)dtovh.Rows[0]["refinery"] * (double)dtprosenovh.Rows[0]["prosent"]) + ((double)dtovh.Rows[0]["fraksinasi"] * (double)dtprosenovhfrak.Rows[0]["prosent"]);
                    if (cctTextBoxEx.EditValue.ToString() == "111107" || cctTextBoxEx.EditValue.ToString() == "111110")
                       spinEdit13.EditValue = (double)dtovh.Rows[0]["marsho"] * (double)dtprosenovhmarsho.Rows[0]["prosent"];
                    if (cctTextBoxEx.EditValue.ToString() == "111102")
                        spinEdit13.EditValue = (double)dtovh.Rows[0]["Fraksinasi"] * (double)dtprosenovhfrak.Rows[0]["prosent"];
                    if (Convert.ToInt32(DB.loginPeriod) < 1508)
                    {
                        if (cctTextBoxEx.EditValue.ToString() == "111104")
                            spinEdit13.EditValue = dtovh.Rows[0]["plastik"];
                    }
                    else
                    {
                        if (cctTextBoxEx.EditValue.ToString() == "111117" || cctTextBoxEx.EditValue.ToString() == "111116" || cctTextBoxEx.EditValue.ToString() == "111118" || cctTextBoxEx.EditValue.ToString() == "111119" || cctTextBoxEx.EditValue.ToString() == "111120" || cctTextBoxEx.EditValue.ToString() == "111121")
                            spinEdit13.EditValue = (double)dtovh.Rows[0]["plastik"] * (double)dtprosenovhplastik.Rows[0]["prosent"];
                    }
                    if (cctTextBoxEx.EditValue.ToString() == "111103")
                        spinEdit13.EditValue = 0;
                       //spinEdit13.EditValue = dtovh.Rows[0]["kemasan"];
                    if (cctTextBoxEx.EditValue.ToString() == "111112" || cctTextBoxEx.EditValue.ToString() == "111113" || cctTextBoxEx.EditValue.ToString() == "111114" || cctTextBoxEx.EditValue.ToString() == "111122")
                       spinEdit13.EditValue = (double)dtovh.Rows[0]["kemasan"] * (double)dtprosenovhkemasan.Rows[0]["prosent"];
                //    spinEdit6.Value = dtkkhlalu.Rows[0]["carm1"].ToString();
                //    spinEdit7.Value = dtkkhlalu.Rows[0]["capack1"].ToString();
                //    spinEdit8.Value = dtkkhlalu.Rows[0]["cadll"].ToString();
                //    spinEdit9.Value = dtkkhlalu.Rows[0]["caovh1"].ToString();
                }
           }
        //   calculate_total();
        }

        private void Prosess_Click(object sender, EventArgs e)
        {
           calculate_total();           
        }

        private void spinEdit4_EditValueChanged(object sender, EventArgs e)
        {
            spinEdit5.EditValue = (double)spinEdit2.Value - (double)spinEdit3.Value - (double)spinEdit4.Value - (double)spinEdit14.Value;
            calculate_total();
        }

        private void spinEdit2_EditValueChanged(object sender, EventArgs e)
        {
            tot1.EditValue = (double)spinEdit1.Value + (double)spinEdit2.Value;
            calculate_total();
        }

        private void rm1_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            scroll = true;
        }

        private void rm1_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            e.Cancel = scroll;
            scroll = false;
        }

        void setreadonly()
        {            
            Utility.SetReadOnly(tot1, true);
         // Utility.SetReadOnly(spinEdit14, true);
            Utility.SetReadOnly(spinEdit6, true);
            Utility.SetReadOnly(spinEdit7, true);
            Utility.SetReadOnly(spinEdit8, true);
            Utility.SetReadOnly(spinEdit9, true);
            Utility.SetReadOnly(tot2, true);
            Utility.SetReadOnly(tot3, true);
            Utility.SetReadOnly(spinEdit10, true);
            Utility.SetReadOnly(spinEdit11, true);
            Utility.SetReadOnly(spinEdit12, true);
            Utility.SetReadOnly(spinEdit13, true);
            Utility.SetReadOnly(spinEdit21, true);
            Utility.SetReadOnly(tot4, true);
            Utility.SetReadOnly(tot5, true);
            Utility.SetReadOnly(spinEdit20, true);
            Utility.SetReadOnly(spinEdit15, true);
         // Utility.SetReadOnly(spinEdit16, true);
            Utility.SetReadOnly(spinEdit17, true);
            Utility.SetReadOnly(spinEdit18, true);
            Utility.SetReadOnly(spinEdit19, true);
            Utility.SetReadOnly(tspinEdit10, true);
            Utility.SetReadOnly(tot6, true);
            Utility.SetReadOnly(tot7, true);
            Utility.SetReadOnly(tot8, true);
            Utility.SetReadOnly(tot9, true);
            Utility.SetReadOnly(tot10, true);
            Utility.SetReadOnly(tot11, true);             
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            if (this.mode == Mode.Edit)
            {
                setreadonly();
            }
        }

        void tsbtnDelete_Click(object sender, EventArgs e)
        {
            if (DB.loginPeriod.ToString() == periodTextEdit.Text)
            {
                if (MessageBox.Show("Are you sure you want to delete this item?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    DB.sql.Execute("delete from kkh where period='" + periodTextEdit.Text + "' and cct='" + cctTextBoxEx.Text + "'");
                    MessageBox.Show("Cost Center: " + cctTextBoxEx.Text + " periode ini Berhasil Dihapus");
                    ////tsbtnLast.PerformClick();
                    tsbtnRefresh.PerformClick();
                }
            }
            else
                MessageBox.Show("periode yg dihapus tidak sama");
               
        }
        void tsbtnPrint_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "repkkj" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_kertaskerja ('"+ cctTextBoxEx.EditValue.ToString()+"','"+periodTextEdit.EditValue.ToString()+"')");
            report.Controls["PageHeader"].Controls["tot1"].Text = tot1.Text;
            report.Controls["PageHeader"].Controls["tot2"].Text = tot2.Text;
            report.Controls["PageHeader"].Controls["tot3"].Text = tot3.Text;
            report.Controls["PageHeader"].Controls["tot4"].Text = tot4.Text;
            report.Controls["PageHeader"].Controls["tot5"].Text = tot5.Text;
            report.Controls["PageHeader"].Controls["tot10"].Text = tot10.Text;
            report.Controls["PageHeader"].Controls["spinedit20"].Text = spinEdit20.Text;
            report.Controls["PageHeader"].Controls["spinedit18"].Text = spinEdit18.Text;
            report.Controls["PageHeader"].Controls["tspinedit10"].Text = tspinEdit10.Text;

            if (cctTextBoxEx.EditValue.ToString() == "111101" || cctTextBoxEx.EditValue.ToString() == "111105" || cctTextBoxEx.EditValue.ToString() == "111106")  //untuk refinery
            {
                report.Controls["PageHeader"].Controls["xrLabel28"].Text = report.Controls["PageHeader"].Controls["xrLabel43"].Text = report.Controls["PageHeader"].Controls["xrLabel52"].Text = "Raw material additional";
                report.Controls["PageHeader"].Controls["xrLabel23"].Text = report.Controls["PageHeader"].Controls["xrLabel44"].Text = "Finish & transfer to fraction";
            }
            report.ShowPreview();

        }

        private void FrmTKkj_Load(object sender, EventArgs e)
        {
            DataTable dtPlant;
            dtPlant = DB.sql.Select("select * from plant");
            for (int i = 0; i < dtPlant.Rows.Count; i++)
            {
                plantComboBox.Items.Add(dtPlant.Rows[i][1].ToString());
            }
            MasterBindingSource.Filter = "period ='"+ DB.loginPeriod.ToString() +"'";
            MasterTable.Clear();
            if ( Convert.ToInt32(DB.loginPeriod) <= 1508)
                 MasterAdapter = DB.sql.SelectAdapter("select * from kkh where period='" + DB.loginPeriod.ToString() + "'");
            else
                 MasterAdapter = DB.sql.SelectAdapter("select * from kkh where period='" + DB.loginPeriod.ToString() + "' and plant = '" + plantComboBox.Text + "'");

            MasterAdapter.Fill(MasterTable);

            MasterBindingSource.MoveLast();
        }

        private void pnlDetail_Paint(object sender, PaintEventArgs e)
        {

        }

        private void plantComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}

