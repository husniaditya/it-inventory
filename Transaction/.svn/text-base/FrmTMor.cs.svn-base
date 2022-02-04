using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CAS.Master;
using KASLibrary;
using DevExpress.XtraReports.UI;

namespace CAS.Transaction
{
    public partial class FrmTMor : BaseMaster
    {
        public FrmTMor()
        {
            
            InitializeComponent();
            Utility.SetSqlInstance(pnlDetail, DB.sql);
            
            this.MasterQuery = "select * from mor where period='" + DB.loginPeriod + "' and group_=1";
            this.MasterBindingSource.Filter = "period = '" + DB.loginPeriod + "' and group_=1";
            
            this.tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            this.tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
            this.tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            this.MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);

            tsbtnPrint.Click += new EventHandler(tsbtnPrint_Click);

            nosoTextBoxEx.ExSqlQuery = "call SP_SelectSOforMO(adddate(" + DB.loginDate.ToString("yyyyMMdd") + ",1))";
            nosoTextBoxEx.ExAutoCheck = false;
        }

        private void PopulateNoSeri()
        {
            if (DB.sql == null) return;
            string query = "select noseri from moduld where role='" + DB.casUser.Role + "' and noseri in (select noseri from modul where menuid='" + this.Tag.ToString() + "')";

            ludSeri.Properties.DataSource = DB.sql.Select(query);
            ludSeri.Properties.DisplayMember = "noseri";
            ludSeri.Properties.ValueMember = "noseri";
            ludSeri.ItemIndex = 0;
            //ludSeri_EditValueChanged(sender, e);
        }

        private void FrmTMor_Load(object sender, EventArgs e)
        {
            dateDate.Properties.MinValue = Utility.FirstDateInMonth(DB.loginDate);
            dateDate.Properties.MaxValue = Utility.LastDateInMonth(DB.loginDate);
            txtPeriod.EditValue = DB.loginPeriod;
            PopulateNoSeri();
            if (this.mode == Mode.New)
                dateDate.EditValue = DB.loginDate;
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
            report.DataSource = DB.sql.Select("call SP_Print('Transaction.FrmTMOR','" + this.NoDocument + "')");
            report.Bands[BandKind.Detail].Controls["lblUser"].Text = DB.casUser.Name;
            report.ShowPreview();
        }

        private void PopulateSOInfo()
        {
            try
            {
                DataTable info1 = DB.sql.Select("select okl.okl as `Kode Sales Order`,sub.name as `Nama Customer`,okl.nopoc as `Kode PO`,okl.date as `Tanggal`,okl.duedate as `Tanggal Jatuh Tempo` from okl,sub where okl.sub = sub.sub and okl.okl='" + nosoTextBoxEx.Text + "'");
                if (info1.Rows.Count > 0)
                {
                    TextEditCust.Text = info1.Rows[0]["Nama Customer"].ToString();
                    textEditPO.Text = info1.Rows[0]["Kode PO"].ToString();
                    sodateDateEdit.DateTime = Convert.ToDateTime(info1.Rows[0]["Tanggal"]);
                }
            }
            catch
            { }
        }

        private void PopulateDetailInfo()
        {
            decimal jumso = 0;
            decimal jummo = 0;
            try
            {
                DataTable info = DB.sql.Select("select dsg.inv as `Kode Barang`,dsg.inv as `Kode Barang`,inv.name as `Nama Barang`,okd.unit as `Unit`, okd.toleransi from okd,inv,dsg where dsg.nodsg=okd.nodsg and okd.inv = inv.inv and okd.okl='" + nosoTextBoxEx.Text + "' and okd.nodsg='" + textBoxExDesain.Text + "'");
                if (info.Rows.Count == 1)
                {
                    textBoxExUnit.Properties.ReadOnly = false;
                    textBoxExUnit.Enabled = true;
                    invTextBoxEx.Text = info.Rows[0]["Kode Barang"].ToString();
                    textBoxExUnit.ExSqlQuery = "select unit as Unit, konversi as Konversi from konversi where inv='" + invTextBoxEx.Text + "'";
                    textBoxExUnit.Text = info.Rows[0]["Unit"].ToString();
                    if (mode != Mode.View)
                    calcEdit2.Value = Convert.ToInt32(info.Rows[0]["toleransi"].ToString());
                    if (mode == Mode.New || mode==Mode.Edit)
                    {
                        DataTable qtyokl = DB.sql.Select("select okd.qty as jumso from okd where okd.okl='" + nosoTextBoxEx.Text + "' and okd.nodsg='" + textBoxExDesain.Text + "'");
                        DataTable qtymor = DB.sql.Select("select sum(qty) as jummo from mor where mor.okl='" + nosoTextBoxEx.Text + "' and mor.nodsg='" + textBoxExDesain.Text + "' and mor.delete=false group by okl,inv");
                        if (qtyokl.Rows.Count == 1) jumso = Convert.ToDecimal(qtyokl.Rows[0]["jumso"]);
                        if (qtymor.Rows.Count == 1) jummo = Convert.ToDecimal(qtymor.Rows[0]["jummo"]);
                        calcEdit1.Value = jumso - jummo;
                    }
                }
            }
            catch { }
        }

        private void ludSeri_EditValueChanged(object sender, EventArgs e)
        {
            if (ludSeri.EditValue == null) return;
        }

        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            //if (MasterBindingSource.Position < 0)
            //    return;
            //if (MasterBindingSource.Position == MasterTable.Rows.Count)
            //    dateDate.DateTime = dateDate.DateTime.Add(DateTime.Now.TimeOfDay);

            if (mode == Mode.New)
                return;

            ParseNoSeri();
            lblDeleted.Visible = (Convert.ToInt16(MasterTable.Rows[MasterBindingSource.Position]["delete"])==1) ? true:false;

            PopulateSOInfo();
            PopulateDetailInfo();
        }

        void tsbtnCancel_Click(object sender, EventArgs e)
        {
            if (this.mode == Mode.View)
            {
                nosoTextBoxEx.ExAutoCheck = false;
                Utility.SetReadOnly(nosoTextBoxEx, true);
                ParseNoSeri();
                tsbtnRefresh.PerformClick();
                PopulateSOInfo();
                PopulateDetailInfo();
            }
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            calcEdit2.Value = 0;
            
            txtPeriod.EditValue = DB.loginPeriod;
            sodateDateEdit.EditValue = DB.loginDate;
            if (ludSeri.EditValue == null)
                PopulateNoSeri();
            txtNo.EditValue = DB.GetNewKeyCode(MasterTable.TableName, ludSeri.EditValue.ToString());
            dateDate.EditValue = DB.loginDate;
            nosoTextBoxEx.ExAutoCheck = true;
            lblDeleted.Visible = false;
            dateDate.EditValue = DB.loginDate;
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
            string query = "Call SP_Browse('" + this.Name + "','" + DB.loginPeriod + "')";
            FrmDialog frmDialog = new FrmDialog(this.Text, DB.sql, query);
            if (frmDialog.ShowDialog() == DialogResult.OK)
            {
                MasterBindingSource.Position = MasterBindingSource.Find(keyfield, frmDialog.ResultRows[0][0].ToString());
            }
        }
        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidateChildren();
                if (TextEditCust.Text == "") throw new Exception("Inputkan SO");
                if (textBoxExUnit.Text == "") throw new Exception("Inputkan KodeDesain/Unit");
                if (calcEdit1.Value == 0) throw new Exception("Inputkan Qty Manufactur");
                int maxqty = 0;
                int nowqty = 0;
                int currentqty = 0;
                double qty = DB.GetQtyInBaseUom(invTextBoxEx.Text, textBoxExUnit.Text, Convert.ToDouble(calcEdit1.Value));
                //DataTable info = DB.sql.Select("select qty as maxqty from okd where okl='" + nosoTextBoxEx.Text + "' and inv='" + invTextBoxEx.Text + "'");
                DataTable info = DB.sql.Select("select qty as maxqty from okd where okl='" + nosoTextBoxEx.Text + "' and nodsg='" + textBoxExDesain.Text + "'");
                if (info.Rows.Count == 1) maxqty = Convert.ToInt32(info.Rows[0]["maxqty"].ToString());
                //info = DB.sql.Select("select ifnull(sum(qty),0) as nowqty from mor where mor.delete=false and okl='" + nosoTextBoxEx.Text + "' and inv='" + invTextBoxEx.Text + "'");
                info = DB.sql.Select("select ifnull(sum(qty),0) as nowqty from mor where mor.delete=false and okl='" + nosoTextBoxEx.Text + "' and nodsg='" + textBoxExDesain.Text + "'");
                if (info.Rows.Count == 1) nowqty = Convert.ToInt32(info.Rows[0]["nowqty"].ToString());
                info = DB.sql.Select("select qty as curqty from mor where mor.delete=false and mor='"+NoDocument+"' and okl='"+nosoTextBoxEx.Text+"'");
                if (info.Rows.Count == 1) currentqty = Convert.ToInt32(info.Rows[0]["curqty"].ToString());
                if (nowqty - currentqty + qty > maxqty)
                {
                    decimal jumso = 0;
                    decimal jummo = 0;
                    DataTable qtyokl = DB.sql.Select("select okd.qty as jumso from okd where okd.okl='" + nosoTextBoxEx.Text + "' and okd.nodsg='" + textBoxExDesain.Text + "'");
                    DataTable qtymor = DB.sql.Select("select sum(qty) as jummo from mor where mor.okl='" + nosoTextBoxEx.Text + "' and mor.nodsg='" + textBoxExDesain.Text + "' and mor.delete=false group by okl,inv");
                    if (qtyokl.Rows.Count == 1) jumso = Convert.ToDecimal(qtyokl.Rows[0]["jumso"]);
                    if (qtymor.Rows.Count == 1) jummo = Convert.ToDecimal(qtymor.Rows[0]["jummo"]);
                    calcEdit1.Value = jumso - jummo;
                    throw new Exception("Qty lebih besar dari Qty Sales Order");
                }
                if (((DataRowView)MasterBindingSource.Current).Row.RowState == DataRowState.Detached)
                {
                    txtNo.Text = DB.GetNewKeyCode(MasterTable.TableName, ludSeri.EditValue.ToString());
                    ((DataRowView)MasterBindingSource.Current).Row[0] = NoDocument;
                }
                else
                    ((DataRowView)MasterBindingSource.Current).Row[0] = NoDocument;
                ((DataRowView)MasterBindingSource.Current).Row["period"] = txtPeriod.Text;
                ((DataRowView)MasterBindingSource.Current).Row["qty"] = qty;
                ((DataRowView)MasterBindingSource.Current).Row["group_"] = 1;
                string nomorso = nosoTextBoxEx.Text;
                base.tsbtnSave_Click(sender, e);

                bool close = true;
                DataTable cek = DB.sql.Select("select okd.nodsg,(okd.qty-ifnull(a.qtymo,0)) as sisa from okd left join (select nodsg,sum(qty) as qtymo from mor where okl='"+nomorso+"' and mor.delete=false group by nodsg) as a on okd.nodsg=a.nodsg where okd.okl='"+nomorso+"'");
                for (int i = 0; i < cek.Rows.Count;i++ )
                {
                    if (cek.Rows[i]["sisa"] != DBNull.Value)
                        if (Convert.ToDecimal(cek.Rows[i]["sisa"]) > 0) close = false;
                }
                //DB.sql.Execute("update okl set close="+close+" where okl='"+nomorso+"'");

                MessageBox.Show("Document " + this.NoDocument + " is successfully saved!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //DataTable qtyokl = DB.sql.Select("select okd.qty as jumso from okd where okd.okl='" + nosoTextBoxEx.Text + "' and okd.nodsg='" + textBoxExDesain.Text + "'");
                //DataTable qtymor = DB.sql.Select("select sum(qty) as jummo from mor where mor.okl='" + nosoTextBoxEx.Text + "' and mor.nodsg='" + textBoxExDesain.Text + "' group by okl,inv");
                //if (qtyokl.Rows.Count == 1) jumso = Convert.ToDecimal(qtyokl.Rows[0]["jumso"]);
                //if (qtymor.Rows.Count == 1) jummo = Convert.ToDecimal(qtymor.Rows[0]["jummo"]);
                //calcEdit1.Value = jumso - jummo;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnDocFlow_Click(object sender, EventArgs e)
        {
            FrmDocFlow frmDoc = new FrmDocFlow(this.NoDocument);
            frmDoc.MdiParent = this.MdiParent;
            frmDoc.Show();
        }

        protected override void tsbtnDelete_Click(object sender, EventArgs e)
        {
            string query = "Select FCekDeleted('" + MasterTable.TableName.ToString() + "','" + NoDocument + "')";
            if (DB.sql.Select(query).Rows[0][0].ToString() == "False")
            {
                MessageBox.Show("Can't Delete this transaction");
                return;
            }
            if (MessageBox.Show("Are you sure you want to delete this item?", "Confirmation",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                DB.sql.Execute("update mor set `delete`=true where mor='" + NoDocument + "'");
                string nomorso = nosoTextBoxEx.Text;
                bool close = true;
                DataTable cek = DB.sql.Select("select okd.nodsg,(ifnull(okd.qty,0)-ifnull(a.qtymo,0)) as sisa from okd left join (select nodsg,sum(qty) as qtymo from mor where okl='" + nomorso + "' and mor.delete=false group by nodsg) as a on okd.nodsg=a.nodsg where okd.okl='" + nomorso + "'");
                for (int i = 0; i < cek.Rows.Count; i++)
                {
                    if (Convert.ToDecimal(cek.Rows[i]["sisa"]) > 0) close = false;
                }
                DB.sql.Execute("update okl set close=" + close + " where okl='" + nomorso + "'");
                tsbtnRefresh.PerformClick();
                lblDeleted.Visible = true;
            }
        }

        private void textBoxExDesain_Enter(object sender, EventArgs e)
        {
            if (this.mode == Mode.New || this.mode == Mode.Edit)
                textBoxExDesain.ExSqlQuery = "call SP_SelectNoDsgforMO('" + nosoTextBoxEx.Text + "')";
        }

        private void nosoTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {
            PopulateSOInfo();
        }

        private void textBoxExDesain_EditValueChanged(object sender, EventArgs e)
        {
            PopulateDetailInfo();
        }
    }
}
