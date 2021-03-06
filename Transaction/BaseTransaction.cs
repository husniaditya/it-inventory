using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using KASLibrary;
using DevExpress.XtraEditors;

namespace CAS.Transaction
{
    public partial class BaseTransaction : XtraForm
    {
        public enum Mode { Edit, View, New };
        protected Mode mode;

        private MySqlDataAdapter m_daMaster = null;
        private DataTable m_dtMaster = null;
        private BindingSource m_bsMaster = null;
        private string m_query = "";

        public MySqlDataAdapter MasterAdapter
        {
            set { m_daMaster = value; }
            get { return m_daMaster; }
        }

        public DataTable MasterTable
        {
            set { m_dtMaster = value; }
            get { return m_dtMaster; }
        }

        public BindingSource MasterBindingSource
        {
            set
            {
                m_bsMaster = value;
                m_bsMaster.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);
                MasterNavigator.BindingSource = MasterBindingSource;
            }
            get { return m_bsMaster; }
        }

        private string MasterQuery
        {
            set { m_query = value; }
            get { return m_query; }
        }

        private MySqlDataAdapter m_daDetail = null;
        private DataTable m_dtDetail = null;
        private BindingSource m_bsDetail = null;
        private string m_Filter = null;

        public MySqlDataAdapter DetailAdapter
        {
            set { m_daDetail = value; }
            get { return m_daDetail; }
        }

        public DataTable DetailTable
        {
            set { m_dtDetail = value; }
            get { return m_dtDetail; }
        }

        public BindingSource DetailBindingSource
        {
            set { m_bsDetail = value; }
            get { return m_bsDetail; }
        }

        private int lastPos = 0;

        private string m_noJurnal;
        private string m_viewonly;

        public string NoJurnal
        {
            set { m_noJurnal = value; }
            get { return m_noJurnal; }
        }

        public string Viewonly
        {
            set { m_viewonly = value; }
            get { return m_viewonly; }
        }

        public string Filter
        {
            set { m_Filter = value; }
            get { return m_Filter; }
        }

        public string NoDocument
        {
            get { return ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text; }
        }

        public BaseTransaction()
        {
            InitializeComponent();
            curcur.ExSqlInstance = DB.sql;
            curkurs.Properties.MaxValue = Int32.MaxValue;
            m_noJurnal = "";
            DB.dtUnit = DB.GetBaseUnitTable();
        }

        private void ParseNoSeri()
        {
            if (MasterBindingSource.Position < 0) return;

            string no = MasterTable.Rows[MasterBindingSource.Position][0].ToString();
            ludSeri.EditValue = no.Split('-')[0];
            txtPeriod.EditValue = no.Split('-')[1];
            txtNo.EditValue = no.Split('-')[2];
        }

        private void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        //protected void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (MasterBindingSource.Position < 0)
                //MasterBindingSource.Position = 0;
                return;

            //if (MasterBindingSource.Position == MasterTable.Rows.Count)
            //if (MasterBindingSource.Position == MasterTable.Select(MasterBindingSource.Filter).Length)
            if (mode == Mode.New)
            {
                lblDeleted.Visible = false;
                tslblRecord.Text = "New record - Record " + (MasterBindingSource.Position + 1).ToString();
                DetailAdapter = DB.sql.SelectAdapter("select * from " + DetailTable.TableName + " where 0");
                return;
            }

            tslblRecord.Text = "Record " + (MasterBindingSource.Position + 1).ToString() + " of " + MasterTable.Rows.Count;
            //tslblRecord.Text = "Record " + (MasterBindingSource.Position + 1).ToString() + " of " + MasterTable.Select(MasterBindingSource.Filter).Length;
            if (this.mode == Mode.View)
            {
                lastPos = MasterBindingSource.Position;
                setMode(Mode.View);
            }
            if (Convert.ToUInt64(((DataRowView)MasterBindingSource.Current).Row["delete"]) == 1)
            {
                lblDeleted.Visible = true;
                //tsbtnEdit.Enabled = false;
                //tsbtnDelete.Enabled = false;
                //tsbtnPrint.Enabled = false;
            }
            else
            {
                lblDeleted.Visible = false;
                //tsbtnDelete.Enabled = true;
                //tsbtnEdit.Enabled = true;
                //tsbtnPrint.Enabled = true;


            }

            if (DetailTable == null) return;
            if (MasterBindingSource.Position >= MasterTable.Rows.Count) return;

            PopulateDetail();
            ParseNoSeri();
        }

        private void PopulateDetail()
        {
            DetailTable.Clear();
            //DetailAdapter = null;

            if (MasterBindingSource.Position < 0) return;

            string query = "select * from " + DetailTable.TableName + " where " + DetailTable.Columns[0].ColumnName + "='" + MasterTable.Rows[MasterBindingSource.Position][0].ToString() + "'";
            DetailAdapter = DB.sql.SelectAdapter(query);
            try
            {
                DetailAdapter.Fill(DetailTable);
            }
            catch (Exception ex)
            {
            }
        }

        private void BaseTransaction_Load(object sender, EventArgs e)
        {
            if (DB.sql == null) return;

            try { Utility.ApplySkin(this); }
            catch { }

            try
            {
                if (NoJurnal == "")
                    MasterQuery = "select * from " + MasterTable.TableName + " where period='" + DB.loginPeriod + "'";
                else
                    MasterQuery = "select * from " + MasterTable.TableName + " where " + MasterTable.Columns[0].ColumnName.ToString() + "='" + NoJurnal + "'";

                if (MasterBindingSource.Filter != null && MasterBindingSource.Filter != "")
                    MasterQuery += " and " + MasterBindingSource.Filter;

                MasterAdapter = DB.sql.SelectAdapter(MasterQuery);
                MasterAdapter.Fill(MasterTable);

                if (Filter != null)
                {
                    DataTable temp = MasterTable.Copy();
                    DataRow[] dRows = temp.Select(Filter);
                    MasterTable.Clear();
                    foreach (DataRow dr in dRows) MasterTable.ImportRow(dr);
                }

                Utility.SetMaxLengths(pnlDetail);
                Utility.SetMaxLengths(pnlKey);

                txtPeriod.DataBindings.Add("EditValue", MasterBindingSource, "period");
                txtChUser.DataBindings.Add("EditValue", MasterBindingSource, "chusr");
                txtChTime.DataBindings.Add("EditValue", MasterBindingSource, "chtime");
                dateDate.DataBindings.Add("EditValue", MasterBindingSource, "date");
                curcur.DataBindings.Add("EditValue", MasterBindingSource, "cur");
                curkurs.DataBindings.Add("EditValue", MasterBindingSource, "kurs");
                if (NoJurnal != "")
                {
                    dateDate.Properties.MinValue = Utility.FirstDateInMonth((DateTime)dateDate.EditValue);
                    dateDate.Properties.MaxValue = Utility.LastDateInMonth((DateTime)dateDate.EditValue).AddHours(23);

                }
                else
                {
                    dateDate.Properties.MinValue = Utility.FirstDateInMonth(DB.loginDate);
                    dateDate.Properties.MaxValue = Utility.LastDateInMonth(DB.loginDate).AddHours(23);
                }
                curkurs.Properties.MaxValue = Int32.MaxValue;

                string query = "select noseri from moduld where role='" + DB.casUser.Role + "' and noseri in (select noseri from modul where menuid='" + this.Tag.ToString() + "')";

                ludSeri.Properties.DataSource = DB.sql.Select(query);
                ludSeri.Properties.DisplayMember = "noseri";
                ludSeri.Properties.ValueMember = "noseri";

                Utility.SetReadOnly(pnlChInfo, true);

                if (MasterBindingSource.Count == 0)
                {
                    if (DB.casUser.AllowInsert(this.Tag.ToString()))
                        tsbtnNew.PerformClick();
                    else
                        setMode(Mode.View);
                }
                else
                {
                    setMode(Mode.View);
                    MasterBindingSource.MoveLast();
                    PopulateDetail();

                    // Check if opened from Link
                    if (NoJurnal != "")
                    {
                        // disable all Updating Buttons
                        tsbtnBrowse.Enabled = tsbtnCancel.Enabled = tsbtnDelete.Enabled
                            = tsbtnNew.Enabled = tsbtnEdit.Enabled = tsbtnSave.Enabled = false;
                    }
                    if (m_viewonly == "True")
                    {
                        setMode(Mode.View);
                        tsbtnNew.Enabled = tsbtnDelete.Enabled = tsbtnBrowse.Enabled = false;
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected virtual void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate controls
                this.ValidateChildren();

                if (DetailTable.Rows.Count == 0 && DetailTable.TableName != "kag")
                {
                    if (DetailTable.TableName != "lpd")
                    {
                        throw new Exception("Detail Transaksi belum terisi");
                        //MessageBox.Show("Detail Transaksi belum terisi");
                        //return;
                    }
                }

                txtChUser.Text = DB.casUser.User;
                txtChTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

                // Set Transaction time for New record
                if (MasterBindingSource.Position == MasterTable.Rows.Count)
                    dateDate.DateTime = dateDate.DateTime.Add(DateTime.Now.TimeOfDay);

                if (((DataRowView)MasterBindingSource.Current).Row.RowState == DataRowState.Detached)
                {
                    txtNo.Text = DB.GetNewKeyCode(MasterTable.TableName, ludSeri.EditValue.ToString());
                    //string newKeyCode = NoDocument;
                    ((DataRowView)MasterBindingSource.Current).Row[0] = NoDocument;
                    for (int i = 0; i < DetailTable.Rows.Count; i++)
                        DetailTable.Rows[i][0] = NoDocument;
                }
                else
                    ((DataRowView)MasterBindingSource.Current).Row[0] = NoDocument;

                ((DataRowView)MasterBindingSource.Current).Row["chtime"] = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                MasterBindingSource.EndEdit();

                DataTable dtChanged = MasterTable.GetChanges();
                //     MasterAdapter.ContinueUpdateOnError= true;
                if (dtChanged != null)
                    MasterAdapter.Update(MasterTable);

                DB.SaveDatalog(dtChanged);

                DetailBindingSource.EndEdit();
                dtChanged = DetailTable.GetChanges();

                if (DetailTable.GetChanges() != null)
                {
                    DetailAdapter.Update(DetailTable);
                }

                DB.SaveDatalog(dtChanged);

                setMode(Mode.View);
                tslblRecord.Text = "Record " + (MasterBindingSource.Position + 1).ToString() + " of " + MasterTable.Rows.Count;

                DB.sql.Execute("delete from proses where jurnal='" + this.NoDocument + "'");

                MessageBox.Show("Document " + this.NoDocument + " is successfully saved!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ConstraintException cex)
            {
                string lastKode = MasterTable.Rows[MasterTable.Rows.Count - 1][0].ToString();
                string strLastNo = lastKode.Split('-')[2];
                int nextNo = Convert.ToInt32(strLastNo) + 1;
                MessageBox.Show("Duplicate Entry. Try no: " + nextNo.ToString("000000") + " for new record");
            }
            catch (DBConcurrencyException exception)
            {
                //alert user and offer choice on how to handle - note the use of exception.Message to display the specific error
                //      MessageBox.Show("Data telah diupdate oleh user lain");
                MessageBox.Show(exception.Message);

                tsbtnRefresh_Click(sender, e);
            }
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        //private void tsbtnNew_Click(object sender, EventArgs e)
        protected void tsbtnNew_Click(object sender, EventArgs e)
        {
            mode = Mode.New;
            MasterBindingSource.AddNew();
            setMode(Mode.New);
            Utility.ClearTexts(pnlDetail);

            //if (MasterTable.Rows.Count == 0)
            //    tsbtnCancel.Enabled = false;

            // initialize default values

            lblDeleted.Visible = false;
            dateDate.EditValue = DB.loginDate;
            txtPeriod.EditValue = DB.loginPeriod;
            curcur.EditValue = "IDR";
            curkurs.EditValue = 1;
            ludSeri.ItemIndex = 0;
            ludSeri_EditValueChanged(sender, e);
        }

        protected bool DeleteLineItem(string kode, int no)
        {
            bool temp = true;
            string query = "Select FCanDeleteLineItem('" + DetailTable.TableName.ToString() + "','" + kode + "'," + no.ToString() + ")";
            if (DB.sql.Select(query).Rows[0][0].ToString() == "False")
            {
                MessageBox.Show("Item ke-" + no.ToString() + " tidak bisa di-delete karena telah digunakan pada tahap transaksi setelahnya");
                temp = false;
            }
            return temp;
        }

        protected void tsbtnEdit_Click(object sender, EventArgs e)
        {
            Boolean canEdit = true;
            Control[] aprov = this.Controls.Find("aprovCheckBox", true);
            if (aprov.Length != 0)
            {
                if (((CheckBox)aprov[0]).Checked == true) canEdit = false;
            }
            if ((DB.casUser.AllowApprove(this.Tag.ToString()) == false && canEdit == false) && MasterTable.TableName != "oms")
            {
                MessageBox.Show("Dokumen tidak dapat diedit karena berada pada kondisi APPROVE, harap melepas dahulu kondisi APPROVE");
                return;
            }

            string query1 = "Select FCekEdited('" + MasterTable.TableName.ToString() + "','" + NoDocument + "')";
            if (DB.sql.Select(query1).Rows[0][0].ToString() == "False")
            {
                MessageBox.Show("Can't Edit this transaction");
                setMode(Mode.View);
                return;
            }
            // check Proses table
            string query = "Select FCekProses('" + DB.casUser.User + "','" + NoDocument + "')";
            string chuser = DB.sql.Select(query).Rows[0][0].ToString();
            if (chuser != DB.casUser.User)
            {
                MessageBox.Show("User " + chuser + " is currently editing this document");
                return;
            }

            setMode(Mode.Edit);
            //dateDate.Enabled = false;   // disable Transaction date editing            
        }

        //private void tsbtnCancel_Click(object sender, EventArgs e)
        protected virtual void tsbtnCancel_Click(object sender, EventArgs e)
        {
            if (MasterTable.Rows.Count == 0)
            {
                this.Close();
                return;
            }

            DetailTable.RejectChanges();
            DetailBindingSource.CancelEdit();
            MasterTable.RejectChanges();
            MasterBindingSource.CancelEdit();
            setMode(Mode.View);
            if (MasterBindingSource.Position == lastPos)
                MasterBindingSource_PositionChanged(MasterBindingSource, new EventArgs());
            else
                MasterBindingSource.Position = lastPos;

            DB.sql.Execute("delete from proses where jurnal='" + this.NoDocument + "'");
        }

        //private void setMode(Mode newMode)
        protected void setMode(Mode newMode)
        {
            try
            {

                this.mode = newMode;
                // check table close
                string query = "select * from _close where period='" + DB.loginPeriod + "'";
                DataTable CPeriod = DB.sql.Select(query);
                if (CPeriod.Rows.Count > 0)
                {
                    newMode = Mode.View;
                }

                switch (newMode)
                {
                    case Mode.New:
                    case Mode.Edit:
                        //Utility.SetReadOnly(pnlKey, false);
                        ludSeri.Properties.ReadOnly = false;
                        Utility.SetReadOnly(pnlDetail, false);
                        tsbtnSave.Enabled = true;
                        tsbtnCancel.Enabled = true;
                        tsbtnEdit.Enabled = false;
                        tsbtnNew.Enabled = false;
                        tsbtnBrowse.Enabled = false;
                        tsbtnRefresh.Enabled = false;
                        tsbtnPrint.Enabled = false;
                        tsbtnDelete.Enabled = false;

                        txtChUser.Text = DB.casUser.User;
                        txtChTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

                        foreach (ToolStripItem tsItem in MasterNavigator.Items)
                        {
                            string itemName = tsItem.Name;
                            switch (itemName)
                            {
                                case "tsbtnFirst":
                                case "tsbtnPrev":
                                case "tsbtnNext":
                                case "tsbtnLast":
                                    tsItem.Enabled = false;
                                    break;
                            }
                        }

                        Control[] aprov = this.Controls.Find("aprovCheckBox", true);
                        if (aprov.Length != 0)
                            ((CheckBox)aprov[0]).Enabled = DB.casUser.AllowApprove(this.Tag.ToString());

                        //txtNo.Select();
                        break;
                    case Mode.View:
                        //Utility.SetReadOnly(pnlKey, true);
                        ludSeri.Properties.ReadOnly = true;
                        Utility.SetReadOnly(pnlDetail, true);
                        tsbtnSave.Enabled = false;
                        tsbtnCancel.Enabled = false;
                        tsbtnNew.Enabled = DB.casUser.AllowInsert(this.Tag.ToString());
                        tsbtnEdit.Enabled = DB.casUser.AllowUpdate(this.Tag.ToString());
                        tsbtnDelete.Enabled = DB.casUser.AllowDelete(this.Tag.ToString());
                        if (CPeriod.Rows.Count > 0)
                        {
                            tsbtnNew.Enabled = false;
                            tsbtnEdit.Enabled = false;
                            tsbtnDelete.Enabled = false;
                        }

                        tsbtnBrowse.Enabled = (MasterTable.Rows.Count > 0);
                        tsbtnRefresh.Enabled = true;
                        tsbtnPrint.Enabled = DB.casUser.AllowPrint(this.Tag.ToString());
                        tsbtnJurnal.Enabled = DB.casUser.AllowJurnal(this.Tag.ToString());

                        foreach (ToolStripItem tsItem in MasterNavigator.Items)
                        {
                            string itemName = tsItem.Name;
                            switch (itemName)
                            {
                                case "tsbtnFirst":
                                case "tsbtnPrev":
                                    if (MasterBindingSource.Position > 0)
                                        tsItem.Enabled = true;
                                    break;
                                case "tsbtnNext":
                                case "tsbtnLast":
                                    if (MasterBindingSource.Position >= 0 && MasterBindingSource.Position < MasterBindingSource.Count - 1)
                                        tsItem.Enabled = true;
                                    break;
                            }
                        }
                        break;
                }
            }
            catch
            { }
        }

        protected virtual void tsbtnBrowse_Click(object sender, EventArgs e)
        {
            string keyfield = MasterTable.Columns[0].ColumnName;
            string query = "Call SP_Browse('" + this.Name + "','" + DB.loginPeriod + "')";
            FrmDialog frmDialog = new FrmDialog(this.Text, DB.sql, query);
            if (frmDialog.ShowDialog() == DialogResult.OK)
            {
                MasterBindingSource.Position = MasterBindingSource.Find(keyfield, frmDialog.ResultRows[0][0].ToString());
            }
        }

        private void ludSeri_EditValueChanged(object sender, EventArgs e)
        {
            if (ludSeri.EditValue == null) return;
            txtNo.EditValue = DB.GetNewKeyCode(MasterTable.TableName, ludSeri.EditValue.ToString());
        }

        private void txtCur_EditValueChanged(object sender, EventArgs e)
        {
            //  if (MasterTable.TableName == "klr" || MasterTable.TableName == "okl" || MasterTable.TableName == "fpjumk")
            //      curkurs.EditValue = DB.GetKursPJK(curcur.Text.Trim(), dateDate.DateTime.Date);
            //  else
            curkurs.EditValue = DB.GetKurs(curcur.Text.Trim(), dateDate.DateTime.Date);
        }

        private void tsbtnJurnal_Click(object sender, EventArgs e)
        {
            if (MasterBindingSource.Current == null) return;

            FrmJurnal frmJurnal = new FrmJurnal(((DataRowView)MasterBindingSource.Current).Row[0].ToString());
            frmJurnal.ShowDialog();
        }

        protected virtual void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            int curPos = MasterBindingSource.Position;
            MasterBindingSource.RaiseListChangedEvents = false;
            MasterTable.Clear();
            MasterAdapter = DB.sql.SelectAdapter(MasterQuery);
            MasterAdapter.Fill(MasterTable);

            if (Filter != null)
            {
                DataTable temp = MasterTable.Copy();
                DataRow[] dRows = temp.Select(Filter);
                MasterTable.Clear();
                foreach (DataRow dr in dRows) MasterTable.ImportRow(dr);
            }

            MasterBindingSource.RaiseListChangedEvents = true;
            MasterBindingSource.ResetBindings(false);
            MasterBindingSource.Position = curPos;
            tslblRecord.Text = "Record " + (MasterBindingSource.Position + 1).ToString() + " of " + MasterTable.Rows.Count;
            PopulateDetail();
            if (DetailTable.Columns.IndexOf("Unit Base") != -1)
            {
                DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
                return;
            }
            if (DetailTable.Columns.IndexOf("Unit Base Diterima") != -1)
            {
                DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base Diterima");
                return;
            }
            if (DetailTable.Columns.IndexOf("Unit Base Dikirim") != -1)
                DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base Dikirim");
        }

        protected virtual void tsbtnDelete_Click(object sender, EventArgs e)
        {
            Boolean canEdit = true;
            Control[] aprov = this.Controls.Find("aprovCheckBox", true);
            if (aprov.Length != 0)
            {
                if (((CheckBox)aprov[0]).Checked == true) canEdit = false;
            }
            if (DB.casUser.AllowApprove(this.Tag.ToString()) == false && canEdit == false)
            {
                MessageBox.Show("Dokumen tidak dapat didelete karena berada pada kondisi APPROVE, harap melepas dahulu kondisi APPROVE");
                return;
            }
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
                lblDeleted.Visible = true;
                ((DataRowView)MasterBindingSource.Current).Row["delete"] = 1;
                ((DataRowView)MasterBindingSource.Current).Row["chusr"] = DB.casUser.User;
                ((DataRowView)MasterBindingSource.Current).Row["chtime"] = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

                //MasterBindingSource.RemoveCurrent();
                MasterAdapter.Update(MasterTable);
                //call SP_Delete
                DB.sql.Execute("Call SP_Delete('" + MasterTable.TableName.ToString() + "','" + NoDocument + "')");
                //DB.sql.Execute("Call SP_OpenTransaction('" + MasterTable.TableName.ToString() + "','" + NoDocument + "')");
                ////query = "Delete from " + DetailTable.TableName.ToString() + " where " + DetailTable.Columns[0].ColumnName.ToString() + " ='" + kodetrans + "'";
                ////DB.sql.Execute(query);
                MessageBox.Show("Kode: " + NoDocument + " Deleted Successfully");
                ////tsbtnLast.PerformClick();
                tsbtnRefresh.PerformClick();
            }
        }

        private void btnDocFlow_Click(object sender, EventArgs e)
        {
            FrmDocFlow frmDoc = new FrmDocFlow(this.NoDocument);
            //frmDoc.MdiParent = this.MdiParent;
            frmDoc.ShowDialog();
        }

        private void BaseTransaction_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tsbtnSave.Enabled)
            {
                this.BringToFront();
                DialogResult dlgResult = MessageBox.Show("Do you want to save your editing?", this.NoDocument, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dlgResult == DialogResult.Yes)
                {
                    try
                    {
                        tsbtnSave_Click(tsbtnSave, new EventArgs());
                        // if Save failed
                        if (tsbtnSave.Enabled)
                            e.Cancel = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        e.Cancel = true;
                        return;
                    }
                }
                else if (dlgResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
                else
                {
                    DB.sql.Execute("delete from proses where jurnal='" + this.NoDocument + "'");
                }
            }
        }

        private void pnlDetail_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tsbtnFirst_Click(object sender, EventArgs e)
        {

        }

        private void dateDate_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}