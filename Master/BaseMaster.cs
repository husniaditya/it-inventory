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

namespace CAS.Master
{
    public partial class BaseMaster : XtraForm
    {
        public enum Mode { Edit, View, New };
        protected Mode mode;

        private MySqlDataAdapter m_daMaster = null;
        private DataTable m_dtMaster = null;
        private BindingSource m_bsMaster = null;
        private String m_query = "";

        private int lastPos = 0;
        private string m_noKode;

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

        public string MasterQuery
        {
            set { m_query = value; }
            get { return m_query; }
        }

        public string NoKode
        {
            set { m_noKode = value; }
            get { return m_noKode; }
        }

        public BaseMaster()
        {
            InitializeComponent();
        }

        private void BaseMaster_Load(object sender, EventArgs e)
        {
            if (DB.sql == null) return;

            try { Utility.ApplySkin(this); }
            catch { }

            try
            {
                MasterAdapter = DB.sql.SelectAdapter(m_query);
                MasterAdapter.Fill(MasterTable);

                Utility.SetMaxLengths(pnlDetail);
                Utility.SetMaxLengths(pnlKey);
                txtChUser.DataBindings.Add("EditValue", MasterBindingSource, "chusr");
                txtChTime.DataBindings.Add("EditValue", MasterBindingSource, "chtime");
                Utility.SetReadOnly(pnlChInfo, true);

                if (MasterBindingSource.Count == 0)
                {
                    tsbtnDelete.Enabled = false;
                    if (DB.casUser.AllowInsert(this.Tag.ToString()))
                        tsbtnNew.PerformClick();
                    else
                        setMode(Mode.View);
                }
                else
                {
                  //  setMode(Mode.View);
                    int findIndex = MasterBindingSource.Find(MasterTable.Columns[0].ColumnName, NoKode);
                    if (findIndex < 0)
                        MasterBindingSource.MoveLast();
                    else
                        MasterBindingSource.Position = findIndex;
                    setMode(Mode.View);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void GetData()
        {
            // Display a wait cursor while the dataset is loaded.
            Cursor.Current = Cursors.WaitCursor;

            //Load DataSet via Data Access Component
            MasterAdapter = DB.sql.SelectAdapter(m_query);
            MasterAdapter.Fill(MasterTable);

            //Reset Cursor
            Cursor.Current = Cursors.Default;
        }

        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            //if (MasterBindingSource.Position == MasterTable.Rows.Count)
            if (mode == Mode.New)
            {
                tslblRecord.Text = "Nerw record - Record " + (MasterBindingSource.Position + 1).ToString();
                return;
            }
            tslblRecord.Text = "Record " + (MasterBindingSource.Position + 1).ToString() + " of " + MasterTable.Rows.Count;
            if (this.mode == Mode.View)
                        lastPos = MasterBindingSource.Position;
            
            if (MasterTable.Columns.Contains("delete"))
            {
                if (Convert.ToUInt64(((DataRowView)MasterBindingSource.Current).Row["delete"]) == 1)
                    tsbtnEdit.Enabled = false;
                else 
                  if (DB.casUser.AllowUpdate(this.Tag.ToString()) == false) 
                    tsbtnEdit.Enabled = true;
            }
        }

        protected virtual void tsbtnSave_Click(object sender, EventArgs e)
        {
            //GetData();
            try
            {
                // post an editor's value
                this.ValidateChildren();

                txtChUser.Text = DB.casUser.User;
                txtChTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                MasterBindingSource.EndEdit();
                
                DataTable dtChanged = MasterTable.GetChanges();
                MasterAdapter.Update(MasterTable);

         //       DB.SaveDatalog(dtChanged);

                setMode(Mode.View);
                tsbtnRefresh_Click(sender,e);
            }
            //catch concurrency exceptions
            catch (DBConcurrencyException exception)
            {
                //alert user and offer choice on how to handle - note the use of exception.Message to display the specific error
                if (MessageBox.Show("Data telah diupdate oleh user lain", "ADO.NET Concurrency Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    //Clear Errors
                    ResetAllErrs(MasterTable.DataSet);

                    // refresh dataset
                    GetData();
                    setMode(Mode.View);
                }
            }
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        
        public void ResetAllErrs(DataSet myDataSet)
        {
            DataRow[] rowsInError;

            foreach (DataTable myTable in myDataSet.Tables)
            {
                // Test if the table has errors. If not, skip it.
                if (myTable.HasErrors)
                {
                    // Get an array of all rows with errors.
                    rowsInError = myTable.GetErrors();
                    // Print the error of each column in each row.
                    for (int i = 0; i < rowsInError.Length; i++)
                    {
                        foreach (DataColumn myCol in myTable.Columns)
                        {
                            Console.WriteLine(myCol.ColumnName + " " +
                            rowsInError[i].GetColumnError(myCol));
                        }
                        // Clear the row errors
                        rowsInError[i].ClearErrors();
                    }
                }
            }
        }
        
        private void tsbtnNew_Click(object sender, EventArgs e)
        {
            mode = Mode.New;
            MasterBindingSource.AddNew();
            setMode(Mode.New);
            Utility.SetReadOnly(pnlKey, false);
            Utility.FocusFirstTextBox(pnlKey);
            Utility.ClearTexts(pnlDetail);
        }

        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            tsbtnRefresh_Click(sender, e);
            setMode(Mode.Edit);
            Utility.FocusFirstTextBox(pnlDetail);
        }

        private void tsbtnCancel_Click(object sender, EventArgs e)
        {
            if (MasterTable.Rows.Count == 0)
            {
                this.Close();
                return;
            }
            MasterTable.RejectChanges();
            MasterBindingSource.CancelEdit();
            setMode(Mode.View);
            MasterBindingSource.Position = lastPos;
        }

        protected virtual void setMode(Mode newMode)
        {
            this.mode = newMode;
            switch (newMode)
            {
                case Mode.New:
                case Mode.Edit:
                    Utility.SetReadOnly(pnlKey, true);
                    Utility.SetReadOnly(pnlDetail, false);
                    tsbtnSave.Enabled = true;
                    tsbtnCancel.Enabled = true;
                    tsbtnEdit.Enabled = false;
                    tsbtnNew.Enabled = false;
                    tsbtnBrowse.Enabled = false;
                    tsbtnRefresh.Enabled = false;

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
                    Utility.FocusFirstTextBox(pnlDetail);
                    break;
                case Mode.View:
                    Utility.SetReadOnly(pnlKey, true);
                    Utility.SetReadOnly(pnlDetail, true);
                    tsbtnSave.Enabled = false;
                    tsbtnCancel.Enabled = false;
                    tsbtnNew.Enabled = DB.casUser.AllowInsert(this.Tag.ToString());
                    tsbtnEdit.Enabled = DB.casUser.AllowUpdate(this.Tag.ToString());
                    tsbtnDelete.Enabled = DB.casUser.AllowDelete(this.Tag.ToString());
                    tsbtnPrint.Enabled = DB.casUser.AllowDelete(this.Tag.ToString());
                    tsbtnBrowse.Enabled = true;
                    tsbtnRefresh.Enabled = true;
                    
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
                                if (MasterBindingSource.Position >=0 && MasterBindingSource.Position < MasterBindingSource.Count - 1)
                                    tsItem.Enabled = true;
                                break;
                        }
                    }
                    break;
            }
        }

        protected virtual void tsbtnBrowse_Click(object sender, EventArgs e)
        {
            string keyfield = MasterTable.Columns[0].ColumnName;
            string query = "Call SP_BrowseM('" + this.Name + "')";
            FrmDialog frmDialog = new FrmDialog(this.Text, DB.sql, query);
            if (frmDialog.ShowDialog() == DialogResult.OK)
            {
                MasterBindingSource.Position = MasterBindingSource.Find(keyfield, frmDialog.ResultRows[0][0].ToString());
            }
        }

        protected virtual void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            int curPos = MasterBindingSource.Position;
            MasterBindingSource.RaiseListChangedEvents = false;
            MasterTable.Clear();
            MasterAdapter = DB.sql.SelectAdapter(m_query);
            MasterAdapter.Fill(MasterTable);
            MasterBindingSource.RaiseListChangedEvents = true;
            MasterBindingSource.ResetBindings(false);
            MasterBindingSource.Position = curPos;
            tslblRecord.Text = "Record " + (MasterBindingSource.Position + 1).ToString() + " of " + MasterTable.Rows.Count;
            
            //MasterAdapter = DB.sql.SelectAdapter(m_query);
            //MasterAdapter.Fill(MasterTable);
        }

        private void BaseMaster_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tsbtnSave.Enabled)
            {
                this.BringToFront();
                DialogResult dlgResult = MessageBox.Show("Do you want to save your editing?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dlgResult == DialogResult.Yes)
                {
                    try
                    {
                        tsbtnSave_Click(tsbtnSave, new EventArgs());
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
            }
        }

        protected virtual void tsbtnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete");
        }

        private void tsbtnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
