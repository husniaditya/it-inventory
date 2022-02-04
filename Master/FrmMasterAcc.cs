using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using KASLibrary;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraEditors;

namespace CAS.Master
{
    public partial class FrmMasterAcc : XtraForm
    {
        public enum Mode { Edit, View };

        MySqlDataAdapter daAcc = DB.sql.SelectAdapter("select * from acc");
        MySqlDataAdapter daAcb = new MySqlDataAdapter();
        DataTable dtTree;
        TreeListNode lastNode, editNode;

        public FrmMasterAcc()
        {
            InitializeComponent();
            daAcc.Fill(casDataSet.acc);

            PopulateTreeAcc();
            Utility.SetMaxLengths(pnlDetail);
            Utility.SetMaxLengths(pnlChInfo);
            this.accBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);
            int groupacc = Convert.ToInt32(casDataSet.acc.Rows[accBindingSource.Position]["Group_"]);
            group_ComboBoxEdit.SelectedIndex = groupacc - 1;

            gcxAcb.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(gcxAcb_tsbtnDelete_Click);
            gcxAcb.ExTitleLabel.Text = "Detail Cost Center Budgeting";
        }

        void gcxAcb_tsbtnDelete_Click(object sender, EventArgs e)
        {
            if (!tsbtnEdit.Enabled)
                gcxAcb.ExGridView.DeleteSelectedRows();
        }

        private void PopulateTreeAcc()
        {
            dtTree = casDataSet.acc.Clone();
            dtTree.Columns["name"].MaxLength += dtTree.Columns["acc"].MaxLength + 2;

            foreach (DataRow dRow in casDataSet.acc)
            {
                DataRow drTree = dtTree.NewRow();
                foreach (DataColumn dCol in casDataSet.acc.Columns)
                {
                    if (dCol.ColumnName == "name")
                        drTree["name"] = dRow["acc"].ToString() + " " + dRow["name"].ToString();
                    else
                        drTree[dCol.ColumnName] = dRow[dCol.ColumnName];
                }
                dtTree.Rows.Add(drTree);
            }

            treeAcc.DataSource = dtTree;
            treeAcc.Refresh();
            treeAcc.BestFitColumns();
        }

        private void FrmMasterAcc_Load(object sender, EventArgs e)
        {
            try { Utility.ApplySkin(this); }
            catch { }
            PopulateGcxAcb();
            setMode(Mode.View);
        }

        private void FrmMasterAcb_Load(object sender, EventArgs e)
        {
            try { Utility.ApplySkin(this); }
            catch { }
            PopulateGcxAcb();
            setMode(Mode.View);
        }

        private void PopulateGcxAcb()
        {
            try
            {
                gcxAcb.ExGridControl.DataSource = null;
                if (treeAcc.FocusedNode.Level == 0) return;
                casDataSet.acb.Clear();
                daAcb = DB.sql.SelectAdapter("select * from acb where acc='" + accTextEdit.EditValue + "'");
                daAcb.Fill(casDataSet.acb);
                gcxAcb.ExGridControl.DataSource = acbBindingSource;

                gcxAcb.ExGridView.Columns["acc"].Visible = false;
                gcxAcb.ExGridView.Columns["accname"].Visible = false;
                gcxAcb.ExGridView.Columns["urut"].Visible = false;
                gcxAcb.ExGridView.Columns["cct"].Caption = "Cost Center";
                gcxAcb.ExGridView.Columns["cctname"].Caption = "Remark";
                gcxAcb.ExGridView.Columns["budget"].Caption = "Budget";

                gcxAcb.ExGridView.Columns["budget"].ColumnEdit = new GridNumEx(700);
                gcxAcb.ExGridView.Columns["cct"].Width = 100;
                gcxAcb.ExGridView.Columns["cctname"].Width = 200;

                gcxAcb.ExGridView.Columns["cct"].ColumnEdit = new GridLookUpEx(DB.sql, "select cct as `Cost Center`,name as Remark from cct",
                    "cct", "Cost Center", gcxAcb.ExGridView, "Nama", true, true, "Cost Center");
                gcxAcb.ExGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(ExGridView_InitNewRow);
            }
            catch { }
        }

        void ExGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gcxAcb.ExGridView.SetFocusedRowCellValue(gcxAcb.ExGridView.Columns["acc"], accTextEdit.EditValue);
            gcxAcb.ExGridView.SetFocusedRowCellValue(gcxAcb.ExGridView.Columns["accname"], nameTextEdit.EditValue);
        }

        private void treeAcc_BeforeFocusNode(object sender, DevExpress.XtraTreeList.BeforeFocusNodeEventArgs e)
        {
            e.CanFocus = tsbtnEdit.Enabled;
        }

        private void treeAcc_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if (accBindingSource.Position < treeAcc.AllNodesCount)
                accBindingSource.Position = e.Node.Id;
        }

        private void accBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (accBindingSource.Position == casDataSet.acc.Rows.Count) // new entry
                return;

            treeAcc.SetFocusedNode(treeAcc.FindNodeByID(accBindingSource.Position));
            PopulateGcxAcb();
        }

        private void tsbtnBrowse_Click(object sender, EventArgs e)
        {
            string keyfield = "acc";
            string condition = "";
            FrmDialog frmDialog = new FrmDialog(this.Text, DB.sql,
                    "Call SP_BrowseM('Master.FrmMasterAcc')");
            if (frmDialog.ShowDialog() == DialogResult.OK)
            {
                accBindingSource.Position = accBindingSource.Find(keyfield, frmDialog.ResultRows[0]["Nomor Akun"].ToString());
            }
        }

        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            lastNode = editNode = treeAcc.FocusedNode;
            setMode(Mode.Edit);
        }

        private void tsbtnNewRoot_Click(object sender, EventArgs e)
        {
            lastNode = treeAcc.FocusedNode;
            accBindingSource.AddNew();
            parentTextEdit.EditValue = lastNode.GetValue("parent");
            level_SpinEdit.EditValue = lastNode.GetValue("level_");
            group_ComboBoxEdit.EditValue = lastNode.GetValue("group_");
            
            editNode = treeAcc.AppendNode(new object[] { "new acc", "( new acc )", lastNode.GetValue("parent"), 1, lastNode.GetValue("level_"), lastNode.GetValue("group_") }, lastNode.ParentNode);
            treeAcc.FocusedNode = editNode;
            setMode(Mode.Edit);
        }

        private void tsbtnNewChild_Click(object sender, EventArgs e)
        {
            lastNode = treeAcc.FocusedNode;
            accBindingSource.AddNew();
            parentTextEdit.EditValue = lastNode.GetValue("acc");
            level_SpinEdit.EditValue = (Int16)lastNode.GetValue("level_") + 1;
            group_ComboBoxEdit.EditValue = lastNode.GetValue("group_");
            
            // set parent detil to 0
            DataRow parentRow = casDataSet.acc.Rows.Find(lastNode.GetValue("acc"));
            parentRow["detil"] = 0;
            editNode = treeAcc.AppendNode(new object[] { "new acc", "( new acc )", lastNode.GetValue("acc"), 1, (Int16)lastNode.GetValue("level_") + 1, lastNode.GetValue("group_") }, lastNode);
            treeAcc.FocusedNode = editNode;
            PopulateGcxAcb();
            setMode(Mode.Edit);
        }

        private void tsbtnCancel_Click(object sender, EventArgs e)
        {
            setMode(Mode.View);
            casDataSet.acc.RejectChanges();
            accBindingSource.CancelEdit();
            if (accBindingSource.Find("acc", editNode.GetValue("acc")) < 0)
                treeAcc.DeleteNode(editNode);
            treeAcc.FocusedNode = lastNode;
            PopulateGcxAcb();
        }

        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();
            if (gcxAcb.ExGridView.EditingValue != null)
                gcxAcb.ExGridView.SetFocusedValue(gcxAcb.ExGridView.EditingValue);
            if (casDataSet.acc.Rows.Count < accBindingSource.Position)
            {
                daAcc.Update(casDataSet.acc);
            }
            ((DataRowView)accBindingSource[accBindingSource.Position]).Row["group_"] = group_ComboBoxEdit.SelectedIndex + 1;
            txtChUser.Text = DB.casUser.User;
            txtChTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            accBindingSource.EndEdit();
            daAcc.Update(casDataSet.acc);
            acbBindingSource.EndEdit();
            daAcb.Update(casDataSet.acb);
            setMode(Mode.View);
        }

        private void setMode(Mode mode)
        {
            switch (mode)
            {
                case Mode.Edit:
                    Utility.SetReadOnly(pnlDetail, false);
                    tsbtnSave.Enabled = true;
                    tsbtnCancel.Enabled = true;
                    tsbtnEdit.Enabled = false;
                    tsbtnNew.Enabled = false;
                    tsbtnBrowse.Enabled = false;

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
                    pnlDetail.Focus();
                    accTextEdit.Select();
                    parentTextEdit.Properties.ReadOnly = true;

                    if (editNode.Level > 0)
                    {
                        gcxAcb.ExGridView.OptionsBehavior.Editable = true;
                        gcxAcb.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
                        gcxAcb.ExGridView.Columns["cctname"].OptionsColumn.AllowEdit = false;
                    }
                    break;
                case Mode.View:
                    Utility.SetReadOnly(pnlDetail, true);
                    tsbtnSave.Enabled = false;
                    tsbtnCancel.Enabled = false;
                    tsbtnNew.Enabled = true;
                    tsbtnEdit.Enabled = true;
                    tsbtnBrowse.Enabled = true;

                    foreach (ToolStripItem tsItem in MasterNavigator.Items)
                    {
                        string itemName = tsItem.Name;
                        switch (itemName)
                        {
                            case "tsbtnFirst":
                            case "tsbtnPrev":
                                if (accBindingSource.Position > 0)
                                    tsItem.Enabled = true;
                                break;
                            case "tsbtnNext":
                            case "tsbtnLast":
                                if (accBindingSource.Position >= 0 && accBindingSource.Position < accBindingSource.Count - 1)
                                    tsItem.Enabled = true;
                                break;
                        }
                    }
                    gcxAcb.ExGridView.OptionsBehavior.Editable = false;
                    gcxAcb.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                    break;
            }
        }

        private void accTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (!tsbtnEdit.Enabled)
            {
                editNode.SetValue("name", accTextEdit.EditValue + " " + nameTextEdit.EditValue);
                editNode.SetValue("acc", accTextEdit.EditValue);
            }
        }

        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            if (treeAcc.FocusedNode.HasChildren)
            {
                MessageBox.Show("Node has children, cannot be deleted!");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {    
                treeAcc.DeleteNode(treeAcc.FocusedNode);   
                accBindingSource.RemoveCurrent();
                daAcc.Update(casDataSet.acc);
            }
        }

        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (accBindingSource.Position > casDataSet.acc.Rows.Count - 1)
            {                
                return;
            }
            int groupacc = Convert.ToInt32(casDataSet.acc.Rows[accBindingSource.Position]["Group_"] );
            group_ComboBoxEdit.SelectedIndex = groupacc - 1;
        }
    }
}