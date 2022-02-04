using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CAS.Master;
using KASLibrary;

namespace CAS.Transaction
{
    public partial class FrmTCGr : BaseMaster
    {
        //string query;
        bool close = false;
        public FrmTCGr()
        {
            InitializeComponent();

            this.MasterQuery = "select * from cgr where period='" + DB.loginPeriod + "'";
            Utility.SetSqlInstance(pnlDetail, DB.sql);

            //query = "select kag.nobg as `No BG`, "
            //            + "kas.date as Tanggal, kag.duedate as `Jatuh Tempo`, "
            //            + "kag.bank as Bank, kag.acbank as `AC Bank`, kag.val as `Nilai`, "
            //            + "kas.sub as `Supplier/Customer`, "
            //            + "sub.name as `Nama Supplier/Customer`, "
            //            + "kag.acc as `Acc Giro`, kgr.accbank as `Acc Bank` "
            //            + "from kag left join (kas left join sub on kas.sub=sub.sub) "
            //            + "on kas.kas = kag.kas "
            //            + "left join kgr on kag.acc=kgr.acc where cgr.period='" + DB.loginPeriod + "'";

            //this.nobgTextBoxEx.ExSqlQuery = "select cgr.nobg as `No BG` from cgr,kag where cgr.nobg=kag.nobg";
            this.nobgTextBoxEx.ExSqlQuery = "select nobg as `No BG` from cgr";
            
            this.tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            this.tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
            this.tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            this.MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);
            this.Load += new EventHandler(FrmTCGr_Load);
            System.Windows.Forms.ToolStripButton tsbtnJurnal = new System.Windows.Forms.ToolStripButton("Jurnal", null, tsbtnJurnal_Click, "tsbtnJurnal");            
            this.MasterNavigator.Items.Insert(MasterNavigator.Items.IndexOfKey("tsbtnPrint")+1,tsbtnJurnal);
            txtNo.Properties.ReadOnly = true;
            txtPeriod.Properties.ReadOnly = true;            
        }

        protected override void setMode(BaseMaster.Mode newMode)
        {
            string query = "select * from _close where period='" + DB.loginPeriod + "'";
            DataTable CPeriod = DB.sql.Select(query);

            if (MasterTable.Rows.Count == 0 && DB.casUser.AllowInsert(this.Tag.ToString()))
                newMode = Mode.New;

            if (CPeriod.Rows.Count > 0)
            {
                newMode = Mode.View;
                close = true;
            }
            base.setMode(newMode);
            if (CPeriod.Rows.Count > 0)
            {
                tsbtnNew.Enabled = false;
                tsbtnEdit.Enabled = false;
                tsbtnDelete.Enabled = false;
            }
        }

        private void FrmTCGr_Load(object sender, EventArgs e)
        {
            if (DB.sql == null) return;
            string query = "select noseri from moduld where role='" + DB.casUser.Role + "' and noseri in (select noseri from modul where menuid='" + this.Tag.ToString() + "')";

            ludSeri.Properties.DataSource = DB.sql.Select(query);
            ludSeri.Properties.DisplayMember = "noseri";
            ludSeri.Properties.ValueMember = "noseri";

            //txtPeriod.DataBindings.Add("EditValue", MasterBindingSource, "period");
            txtPeriod.EditValue = DB.loginPeriod;
            ludSeri.ItemIndex = 0;
            ludSeri_EditValueChanged(sender, e);

            MasterNavigator.Items["tsbtnJurnal"].Enabled = DB.casUser.AllowJurnal(this.Tag.ToString());
            setMode(Mode.View);
        }

        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (close)
            {
                tsbtnEdit.Enabled = false;
            }
            if (MasterBindingSource.Position < 0)
                //MasterBindingSource.Position = 0;
                return;
            if (MasterBindingSource.Position >= MasterTable.Rows.Count) return;
            ParseNoSeri();
            nobgTextBoxEx.ExSqlQuery = "select nobg as `No BG` from cgr";
            
        }

        void tsbtnJurnal_Click(object sender, EventArgs e)
        {
            if (MasterBindingSource.Current == null) return;

            FrmJurnal frmJurnal = new FrmJurnal(((DataRowView)MasterBindingSource.Current).Row[0].ToString());
            frmJurnal.ShowDialog();
        }

        void tsbtnCancel_Click(object sender, EventArgs e)
        {
            if (this.mode == Mode.View)
            {
                ParseNoSeri();
                //nobgTextBoxEx.ExSqlQuery = query;
                nobgTextBoxEx.ExSqlQuery = "select nobg as `No BG` from cgr";
            }
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
           
            subTextBoxEx.Properties.ReadOnly = true;
            accTextBoxEx.Properties.ReadOnly = true;
            accbankTextBoxEx.Properties.ReadOnly = true;
            bankTextEdit.Properties.ReadOnly = true;
            acbankTextEdit.Properties.ReadOnly = true;
            bgdateDateEdit.Properties.ReadOnly = true;
            bgduedateDateEdit.Properties.ReadOnly = true;
            bgvalSpinEdit.Properties.ReadOnly = true;
            txtNo.Properties.ReadOnly = true;
            txtPeriod.Properties.ReadOnly = true;       
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            txtPeriod.EditValue = DB.loginPeriod;
            ludSeri.ItemIndex = 0;
            if (ludSeri.ItemIndex == -1)
            {
                txtNo.EditValue = DB.GetNewKeyCode(MasterTable.TableName, "TLK");
            }
            else
            {
                txtNo.EditValue = DB.GetNewKeyCode(MasterTable.TableName, ludSeri.EditValue.ToString());
            }
            subTextBoxEx.Properties.ReadOnly = true;
            accbankTextBoxEx.Properties.ReadOnly = true;
            accTextBoxEx.Properties.ReadOnly = true;
            acbankTextEdit.Properties.ReadOnly = true;
            bankTextEdit.Properties.ReadOnly = true;
            bgdateDateEdit.Properties.ReadOnly = true;
            bgduedateDateEdit.Properties.ReadOnly = true;
            bgduedateDateEdit.DateTime = dateDateEdit.DateTime = DateTime.Today;
            bgvalSpinEdit.Properties.ReadOnly = true;
            txtNo.Properties.ReadOnly = true;
            txtPeriod.Properties.ReadOnly = true;
        }

        private void txtNo_EditValueChanged(object sender, EventArgs e)
        {
            if (MasterBindingSource.Position != MasterTable.Rows.Count)
            {
                int jenisgiro = Convert.ToInt32(MasterTable.Rows[MasterBindingSource.Position]["dk"]);
                jenisRadioGroup.SelectedIndex = jenisgiro;
            }
        }

        private void nobgTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {
            //DataTable info = DB.sql.Select("select kag.nobg,kas.date,kas.sub,kag.bank,kag.acbank,kag.duedate,kag.val,kag.acc from kas,kag where kag.kas = kas.kas and kag.nobg='" + nobgTextBoxEx.Text + "'");
            //if (info.Rows.Count == 1)
            //{
            //    bankTextEdit.Text = info.Rows[0]["bank"].ToString();
            //    acbankTextEdit.Text = info.Rows[0]["acbank"].ToString();
            //    bgdateDateEdit.DateTime = Convert.ToDateTime(info.Rows[0]["date"]);
            //    bgduedateDateEdit.DateTime = Convert.ToDateTime(info.Rows[0]["duedate"]);
            //    bgvalSpinEdit.EditValue = Convert.ToInt32(info.Rows[0]["val"]);
            //    subTextBoxEx.Text = info.Rows[0]["sub"].ToString();
            //    accbankTextBoxEx.Text = info.Rows[0]["acc"].ToString();
            //}
            //else
            //{
            //    tsbtnCancel.PerformClick();
            //    if (nobgTextBoxEx.Text != "")
            //        MessageBox.Show("Data BG tidak valid");
            //}

            if (!nobgTextBoxEx.Properties.ReadOnly)
            //if (nobgTextBoxEx
            {
                DataRow row = nobgTextBoxEx.ExGetDataRow();
                if (row == null)
                {
                    bankTextEdit.EditValue = "";
                    acbankTextEdit.EditValue = "";
                    bgdateDateEdit.DateTime = DateTime.Today;
                    bgduedateDateEdit.DateTime = DateTime.Today;
                    bgvalSpinEdit.EditValue = 0;
                    subTextBoxEx.EditValue = "";
                    accbankTextBoxEx.EditValue = "";
                    return;
                }
                bankTextEdit.EditValue = row["Bank"].ToString();
                acbankTextEdit.EditValue = row["AC Bank"].ToString();
                bgdateDateEdit.DateTime = Convert.ToDateTime(row["Tanggal"]);
                if (row["Jatuh Tempo"] != DBNull.Value)
                    bgduedateDateEdit.DateTime = Convert.ToDateTime(row["Jatuh Tempo"]);
                bgvalSpinEdit.EditValue = Convert.ToDouble(row["Nilai"]);
                subTextBoxEx.EditValue = row["Supplier/Customer"].ToString();
                accbankTextBoxEx.EditValue = row["Acc Bank"].ToString();
                accTextBoxEx.EditValue = row["Acc Giro"].ToString();
            }
        }

        private void ludSeri_EditValueChanged(object sender, EventArgs e)
        {
            if (ludSeri.EditValue == null) return;
        }

        public string NoDocument
        {
            get { return ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text; }
        }

        private void ParseNoSeri()
        {
            if (MasterBindingSource.Position < 0) return;

            string no = MasterTable.Rows[MasterBindingSource.Position][0].ToString();
            ludSeri.EditValue = no.Split('-')[0];
            txtPeriod.EditValue = no.Split('-')[1];
            txtNo.EditValue = no.Split('-')[2];
        }
        
        protected override void tsbtnBrowse_Click(object sender, EventArgs e)
        {
            string keyfield = MasterTable.Columns[0].ColumnName;
            //string condition = "";
            //int indexOfWhere = MasterQuery.ToLower().IndexOf("where");
            //if (indexOfWhere > 0)
            //    condition = MasterQuery.Substring(indexOfWhere + 6);
            string query = "Call SP_Browse('" + this.Name + "','" + DB.loginPeriod + "')";
            FrmDialog frmDialog = new FrmDialog(this.Text, DB.sql, query);
            if (frmDialog.ShowDialog() == DialogResult.OK)
            {
                MasterBindingSource.Position = MasterBindingSource.Find(keyfield, frmDialog.ResultRows[0][0].ToString());
            }
        }

        protected override void tsbtnDelete_Click(object sender, EventArgs e)
        {
            base.tsbtnDelete_Click(sender, e);
            if (Convert.ToInt32(MasterTable.Rows[MasterBindingSource.Position]["delete"]) == 1)
                DB.sql.Execute("Call SP_Delete('CGR'" + ",'" + NoDocument + "')");
        }
        
        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidateChildren();
                if (bgduedateDateEdit.EditValue.ToString() == "")
                    throw new Exception("Harap mengisi tanggal jatuh tempo");

                if (((DataRowView)MasterBindingSource.Current).Row.RowState == DataRowState.Detached)
                {
                    txtNo.Text = DB.GetNewKeyCode(MasterTable.TableName, ludSeri.EditValue.ToString());
                    //string newKeyCode = NoDocument;
                    ((DataRowView)MasterBindingSource.Current).Row[0] = NoDocument;
                }
                else
                    ((DataRowView)MasterBindingSource.Current).Row[0] = NoDocument;
                //if (MasterBindingSource.Position == MasterTable.Rows.Count)
                dateDateEdit.DateTime = dateDateEdit.DateTime.Add(DateTime.Now.TimeOfDay);
                ((DataRowView)MasterBindingSource.Current).Row["period"] = txtPeriod.Text;
                ((DataRowView)MasterBindingSource.Current).Row["dk"] = jenisRadioGroup.SelectedIndex;
                base.tsbtnSave_Click(sender, e);
                //nobgTextBoxEx.ExSqlQuery = query;
                nobgTextBoxEx.ExSqlQuery = "select nobg as `No BG` from cgr";
                string date = ((DateTime)(dateDateEdit.EditValue)).ToString("yyyyMMdd");
                string jurnal = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
                DB.sql.Execute("Call SP_Save(" + date + ",'CGR'" + ",'" + jurnal + "')");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        

        private void nobgTextBoxEx_Enter(object sender, EventArgs e)
        {
            //jika mode edit
            if (!nobgTextBoxEx.Properties.ReadOnly)
            {
                string tglAwal = Utility.FirstDateInMonth(DB.loginDate).ToString("yyyyMMdd");
                string tglAkhir = Utility.LastDateInMonth(DB.loginDate).ToString("yyyyMMdd");
                //giro masuk = piutang
                if (jenisRadioGroup.SelectedIndex == 0)
                    nobgTextBoxEx.ExSqlQuery = "Call SP_LookUpCgr('" + DB.loginPeriod + "'," + tglAwal + "," + tglAkhir + ",'2')";
                else
                    nobgTextBoxEx.ExSqlQuery = "Call SP_LookUpCgr('" + DB.loginPeriod + "'," + tglAwal + "," + tglAkhir + ",'1')";
            }
        }
    }
}
