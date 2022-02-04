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
    public partial class FrmTMOx : CAS.Master.BaseMaster
    {
        public FrmTMOx()
        {
            InitializeComponent();

            Utility.SetSqlInstance(pnlDetail, DB.sql);
            this.MasterQuery = "select * from mor where period='" + DB.loginPeriod + "' and group_=2";
            //this.MasterBindingSource.Filter = "period = '" + DB.loginPeriod + "'";

            this.tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            this.tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
            this.tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            this.MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);

            tsbtnPrint.Click += new EventHandler(tsbtnPrint_Click);
        }

        public string NoDocument
        {
            get { return ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text; }
        }

        private void PopulateNoSeri()
        {
            if (DB.sql == null) return;
            string query = "select noseri from moduld where role='" + DB.casUser.Role + "' and noseri in (select noseri from modul where menuid='" + this.Tag.ToString() + "')";
            ludSeri.Properties.DataSource = DB.sql.Select(query);
            ludSeri.Properties.DisplayMember = "noseri";
            ludSeri.Properties.ValueMember = "noseri";
            ludSeri.ItemIndex = 0;            
        }

        private void FrmTMOx_Load(object sender, EventArgs e)
        {
            dateDate.Properties.MinValue = Utility.FirstDateInMonth(DB.loginDate);
            dateDate.Properties.MaxValue = Utility.LastDateInMonth(DB.loginDate);
            txtPeriod.EditValue = DB.loginPeriod;
            PopulateNoSeri();
            if (this.mode == Mode.New)
                dateDate.EditValue = DB.loginDate;
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            calcEditQty.Value = 0;
            txtPeriod.EditValue = DB.loginPeriod;
            if (ludSeri.EditValue == null)
                PopulateNoSeri();
            txtNo.EditValue = DB.GetNewKeyCode(MasterTable.TableName, ludSeri.EditValue.ToString());
            dateDate.EditValue = DB.loginDate;
            lblDeleted.Visible = false;
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {

        }

        void tsbtnCancel_Click(object sender, EventArgs e)
        {

        }

        void tsbtnPrint_Click(object sender, EventArgs e)
        {
            if (MasterBindingSource.Position == MasterTable.Rows.Count)
            {
                MessageBox.Show("Data belum tersimpan. Lakukan dahulu penyimpanan data.");
                return;
            }
            string path = Application.StartupPath + "\\Reports\\" + "RepMO" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_Print('Transaction.FrmTMOP','" + this.NoDocument + "')");
            report.Bands[BandKind.Detail].Controls["lblUser"].Text = DB.casUser.Name;
            report.ShowPreview();
        }

        private void ParseNoSeri()
        {
            if (MasterBindingSource.Position < 0) return;
            string no = MasterTable.Rows[MasterBindingSource.Position][0].ToString();
            ludSeri.EditValue = no.Split('-')[0];
            txtPeriod.EditValue = no.Split('-')[1];
            txtNo.EditValue = no.Split('-')[2];
        }

        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (mode == Mode.New)
                return;
            ParseNoSeri();
            lblDeleted.Visible = (Convert.ToInt16(MasterTable.Rows[MasterBindingSource.Position]["delete"]) == 1) ? true : false;
        }

        private void textBoxExDesain_EditValueChanged(object sender, EventArgs e)
        {
            DataRow dr = textBoxExDesain.ExGetDataRow();
            if (dr != null)
                invTextBoxEx.EditValue = dr["Kode Barang"];
        }

        private void textBoxExUnit_Enter(object sender, EventArgs e)
        {
            textBoxExUnit.ExSqlQuery = "select inv as `Kode Barang`, unit as Unit, konversi as Konversi from konversi where inv='" + invTextBoxEx.EditValue.ToString() + "'";
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidateChildren();
                if (((DataRowView)MasterBindingSource.Current).Row.RowState == DataRowState.Detached)
                {
                    txtNo.Text = DB.GetNewKeyCode(MasterTable.TableName, ludSeri.EditValue.ToString());
                    ((DataRowView)MasterBindingSource.Current).Row[0] = NoDocument;
                }
                else
                    ((DataRowView)MasterBindingSource.Current).Row[0] = NoDocument;
                ((DataRowView)MasterBindingSource.Current).Row["period"] = txtPeriod.Text;
                double qty = DB.GetQtyInBaseUom(invTextBoxEx.Text, textBoxExUnit.Text, Convert.ToDouble(calcEditQty.Value));
                ((DataRowView)MasterBindingSource.Current).Row["qty"] = qty;
                ((DataRowView)MasterBindingSource.Current).Row["group_"] = 2;
                base.tsbtnSave_Click(sender, e);
                MessageBox.Show("Document " + this.NoDocument + " is successfully saved!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

