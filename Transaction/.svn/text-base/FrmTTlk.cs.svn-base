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
    public partial class FrmTTlk : BaseMaster
    {
        public FrmTTlk()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlDetail, DB.sql);
            //this.nobgTextBoxEx.ExSqlInstance = DB.sql;
            this.nobgTextBoxEx.ExSqlQuery = "select kag.nobg as `No BG`,kag.duedate as `Tgl.Jatuh Tempo`,kag.acc as `Perkiraan`,sub.name as `Keterangan`,kag.val as `Nilai` from kas,kag,sub where kag.kas = kas.kas and kas.sub=sub.sub";
            this.tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            this.tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
            this.tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            this.MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);
            this.Load += new EventHandler(FrmTTlk_Load);
            txtNo.Properties.ReadOnly = true;
            txtPeriod.Properties.ReadOnly = true;
        }

        void FrmTTlk_Load(object sender, EventArgs e)
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
            // TODO: This line of code loads data into the 'casDataSet.tlk' table. You can move, or remove it, as needed.
            //this.tlkTableAdapter.Fill(this.casDataSet.tlk);
            tsbtnNew.PerformClick();
            tsbtnCancel.PerformClick();
        }

        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (MasterBindingSource.Position < 0)
                //MasterBindingSource.Position = 0;
                return;


            if (MasterBindingSource.Position >= MasterTable.Rows.Count) return;
            ParseNoSeri();
        }

        void tsbtnCancel_Click(object sender, EventArgs e)
        {
            if (this.mode == Mode.View)
            {
                ParseNoSeri();
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
            bgvalSpinEdit.Properties.ReadOnly = true;
            txtNo.Properties.ReadOnly = true;
            txtPeriod.Properties.ReadOnly = true;
        }

        private void ludSeri_EditValueChanged(object sender, EventArgs e)
        {
            if (ludSeri.EditValue == null) return;
            //txtNo.EditValue = DB.GetNewKeyCode(MasterTable.TableName, ludSeri.EditValue.ToString());
            //MessageBox.Show(txtNo.Text + " a");
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

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();
            if (((DataRowView)MasterBindingSource.Current).Row.RowState == DataRowState.Detached)
            {
                txtNo.Text = DB.GetNewKeyCode(MasterTable.TableName, ludSeri.EditValue.ToString());
                //string newKeyCode = NoDocument;
                ((DataRowView)MasterBindingSource.Current).Row[0] = NoDocument;
            }
            else
                ((DataRowView)MasterBindingSource.Current).Row[0] = NoDocument;
            ((DataRowView)MasterBindingSource.Current).Row["period"] = txtPeriod.Text;
            ((DataRowView)MasterBindingSource.Current).Row["dk"] = jenisRadioGroup.SelectedIndex;
            base.tsbtnSave_Click(sender, e);
        }


        private void nobgTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {
            DataTable info = DB.sql.Select("select kag.nobg,kas.date,kas.sub,kag.bank,kag.acbank,kag.duedate,kag.val,kag.acc from kas,kag where kag.kas = kas.kas and kag.nobg='" + nobgTextBoxEx.Text + "'");
            if (info.Rows.Count == 1)
            {
                bankTextEdit.Text = info.Rows[0]["bank"].ToString();
                acbankTextEdit.Text = info.Rows[0]["acbank"].ToString();
                bgdateDateEdit.DateTime = Convert.ToDateTime(info.Rows[0]["date"]);
                bgduedateDateEdit.DateTime = Convert.ToDateTime(info.Rows[0]["duedate"]);
                bgvalSpinEdit.EditValue = Convert.ToInt32(info.Rows[0]["val"]);
                subTextBoxEx.Text = info.Rows[0]["sub"].ToString();
                accbankTextBoxEx.Text = info.Rows[0]["acc"].ToString();
            }
            else
            {
                tsbtnCancel.PerformClick();
                if (nobgTextBoxEx.Text != "")
                    MessageBox.Show("Data BG tidak valid");
            }
                //accTextBoxEx.Text = info.Rows[0].ItemArray[2].ToString();
        }

        private void txtNo_EditValueChanged(object sender, EventArgs e)
        {
            if (MasterBindingSource.Position != MasterTable.Rows.Count)
            {
                int jenisgiro = Convert.ToInt32(MasterTable.Rows[MasterBindingSource.Position]["dk"]);
                jenisRadioGroup.SelectedIndex = jenisgiro;
            }
        }
    }
}