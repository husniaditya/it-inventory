using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DevExpress.XtraTreeList.Nodes;
using KASLibrary;
using DevExpress.XtraEditors;

namespace CAS.Master
{
    public partial class FrmMasterCct : XtraForm
    {
        public enum Mode { Edit, View };

        MySqlDataAdapter daCct = DB.sql.SelectAdapter("select * from cct");
        MySqlDataAdapter daCca = new MySqlDataAdapter();
        MySqlDataAdapter daAcb = new MySqlDataAdapter();
        DataTable dtTree;
        TreeListNode lastNode, editNode;

        public FrmMasterCct()
        {
            InitializeComponent();

            daCct.Fill(casDataSet.cct);
            PopulateTreeCct();
           
            Utility.SetMaxLengths(pnlDetail);
            Utility.SetMaxLengths(pnlChInfo);
            Utility.SetReadOnly(pnlChInfo, true);

            gcxCca.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(gcxCca_tsbtnDelete_Click);
            gcxCca.ExTitleLabel.Text = "Detail Cost Center";

            gcxAcb.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(gcxAcb_tsbtnDelete_Click);
            gcxAcb.ExTitleLabel.Text = "Detail Account Budgeting";
        }

        void gcxAcb_tsbtnDelete_Click(object sender, EventArgs e)
        {
            if (!tsbtnEdit.Enabled)
                gcxAcb.ExGridView.DeleteSelectedRows();
        }

        private void FrmMasterCct_Load(object sender, EventArgs e)
        {
            try { Utility.ApplySkin(this); }
            catch { }
            PopulateGcxCca();
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
                //if (treeCct.FocusedNode.Level == 0) return;
                casDataSet.acb.Clear();
                daAcb = DB.sql.SelectAdapter("select * from acb where cct='" + cctTextEdit.EditValue + "'");
                daAcb.Fill(casDataSet.acb);
                gcxAcb.ExGridControl.DataSource = acbBindingSource;

                gcxAcb.ExGridView.Columns["cct"].Visible = false;
                gcxAcb.ExGridView.Columns["cctname"].Visible = false;
                gcxAcb.ExGridView.Columns["urut"].Visible = false;
                //gcxAcb.ExGridView.Columns["cct"].Caption = "Cost Center";
                //gcxAcb.ExGridView.Columns["cctname"].Caption = "Name";
                gcxAcb.ExGridView.Columns["acc"].Caption = "Kode Akun";
                gcxAcb.ExGridView.Columns["accname"].Caption = "Remark";
                gcxAcb.ExGridView.Columns["budget"].Caption = "Budget";

                gcxAcb.ExGridView.Columns["budget"].ColumnEdit = new GridNumEx(700);
                gcxAcb.ExGridView.Columns["acc"].Width = 100;
                gcxAcb.ExGridView.Columns["accname"].Width = 200;

                gcxAcb.ExGridView.Columns["acc"].ColumnEdit = new GridLookUpEx(DB.sql, "select acc as `Kode Akun`,name as Remark from acc where detil = 1",
                    "acc", "Kode Akun", gcxAcb.ExGridView, "Nama", true, true, "Kode Akun");
                gcxAcb.ExGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(ExGridView_InitNewRow);
            }
            catch { }
        }

        private void PopulateTreeCct()
        {
            dtTree = casDataSet.cct.Clone();
            dtTree.Columns["name"].MaxLength += dtTree.Columns["cct"].MaxLength + 2;

            foreach (DataRow dRow in casDataSet.cct)
            {
                DataRow drTree = dtTree.NewRow();
                foreach (DataColumn dCol in casDataSet.cct.Columns)
                {
                    if (dCol.ColumnName == "name")
                        drTree["name"] = dRow["cct"].ToString() + " " + dRow["name"].ToString();
                    else
                        drTree[dCol.ColumnName] = dRow[dCol.ColumnName];
                }
                dtTree.Rows.Add(drTree);
            }

            treeCct.DataSource = dtTree;
            treeCct.Refresh();
            treeCct.BestFitColumns();
        }

        private void treeCct_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if (cctBindingSource.Position < treeCct.AllNodesCount)
                cctBindingSource.Position = e.Node.Id;
        }

        private void treeCct_BeforeFocusNode(object sender, DevExpress.XtraTreeList.BeforeFocusNodeEventArgs e)
        {
            e.CanFocus = tsbtnEdit.Enabled;
        }

        private void cctBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (cctBindingSource.Position == casDataSet.cct.Rows.Count) // new entry
                return;

            treeCct.SetFocusedNode(treeCct.FindNodeByID(cctBindingSource.Position));
            PopulateGcxCca();
            PopulateGcxAcb();
        }

        private void PopulateGcxCca()
        {
            try
            {
                gcxCca.ExGridControl.DataSource = null;
                if (treeCct.FocusedNode.Level > 0) return;
                casDataSet.cca.Clear();
                daCca = DB.sql.SelectAdapter("select * from cca where cct='" + cctTextEdit.EditValue + "'");
                daCca.Fill(casDataSet.cca);
                gcxCca.ExGridControl.DataSource = ccaBindingSource;

                gcxCca.ExGridView.Columns["cct"].Visible = false;
                gcxCca.ExGridView.Columns["kode"].Caption = "Kode";
                gcxCca.ExGridView.Columns["name"].Caption = "Nama";
                gcxCca.ExGridView.Columns["kode"].ColumnEdit = new GridLookUpEx(DB.sql, "select kode as `Kode`, kode.name as `Nama`, kode.acc as `Account`, acc.name as `Nama Account` from kode, acc where kode.acc=acc.acc",
                    "kode", "Kode", gcxCca.ExGridView, "Nama", true, true, "Perkiraan");
                gcxCca.ExGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(ExGridView_InitNewRow);
            }
            catch { }
        }

        void ExGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gcxCca.ExGridView.SetFocusedRowCellValue(gcxCca.ExGridView.Columns["cct"], cctTextEdit.EditValue);
            gcxAcb.ExGridView.SetFocusedRowCellValue(gcxAcb.ExGridView.Columns["cct"], cctTextEdit.EditValue);
            gcxAcb.ExGridView.SetFocusedRowCellValue(gcxAcb.ExGridView.Columns["cctname"], nameTextEdit.EditValue);
        }

        void gcxCca_tsbtnDelete_Click(object sender, EventArgs e)
        {
            if (!tsbtnEdit.Enabled)
                gcxCca.ExGridView.DeleteSelectedRows();
        }

        private void tsbtnBrowse_Click(object sender, EventArgs e)
        {
            string keyfield = "cct";
            string condition = "";
            FrmDialog frmDialog = new FrmDialog(this.Text, DB.sql,
                    "Call SP_BrowseM('Master.FrmMasterCct')");
            if (frmDialog.ShowDialog() == DialogResult.OK)
            {
                cctBindingSource.Position = cctBindingSource.Find(keyfield, frmDialog.ResultRows[0]["Cost Center"].ToString());
            }
        }

        private void tsbtnNewRoot_Click(object sender, EventArgs e)
        {
            lastNode = treeCct.FocusedNode;
            cctBindingSource.AddNew();
            parentTextEdit.EditValue = lastNode.GetValue("parent");
            level_SpinEdit.EditValue = lastNode.GetValue("level_");

            editNode = treeCct.AppendNode(new object[] { "new cct", "( new cct )", lastNode.GetValue("parent"), 1, lastNode.GetValue("level_") }, lastNode.ParentNode);
            treeCct.FocusedNode = editNode;
            setMode(Mode.Edit);
        }

        private void tsbtnNewChild_Click(object sender, EventArgs e)
        {
            lastNode = treeCct.FocusedNode;
            cctBindingSource.AddNew();
            parentTextEdit.EditValue = lastNode.GetValue("cct");
            level_SpinEdit.EditValue = (Int16)lastNode.GetValue("level_") + 1;
            detilCheckBox.Checked = true;

            // set parent detil to 0
            DataRow parentRow = casDataSet.cct.Rows.Find(lastNode.GetValue("cct"));
            parentRow["detil"] = 0;
            editNode = treeCct.AppendNode(new object[] { "new cct", "( new cct )", lastNode.GetValue("cct"), 1, (Int16)lastNode.GetValue("level_") + 1 }, lastNode);
            treeCct.FocusedNode = editNode;
            PopulateGcxCca();
            PopulateGcxAcb();
            setMode(Mode.Edit);
        }

        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            lastNode = editNode = treeCct.FocusedNode;
            setMode(Mode.Edit);
        }

        private void tsbtnCancel_Click(object sender, EventArgs e)
        {
            setMode(Mode.View);
            casDataSet.cct.RejectChanges();
            casDataSet.cca.RejectChanges();

            if (cctBindingSource.Find("cct", editNode.GetValue("cct")) < 0)
            {
                treeCct.DeleteNode(editNode);
                cctBindingSource.RemoveCurrent();
            }
            treeCct.FocusedNode = lastNode;
            PopulateGcxCca();
            PopulateGcxAcb();
        }

        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();
            if (gcxAcb.ExGridView.EditingValue != null)
                gcxAcb.ExGridView.SetFocusedValue(gcxAcb.ExGridView.EditingValue);
            if (gcxCca.ExGridView.EditingValue != null)
                gcxCca.ExGridView.SetFocusedValue(gcxCca.ExGridView.EditingValue);
            txtChUser.Text = DB.casUser.User;
            txtChTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            cctBindingSource.EndEdit();
            daCct.Update(casDataSet.cct);
            ccaBindingSource.EndEdit();
            daCca.Update(casDataSet.cca);
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
                    cctTextEdit.Select();
                    parentTextEdit.Properties.ReadOnly = true;

                    if (editNode.Level == 0)
                    {
                        gcxCca.ExGridView.OptionsBehavior.Editable = true;
                        gcxCca.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
                        gcxCca.ExGridView.Columns["name"].OptionsColumn.AllowEdit = false;
                    }

                    gcxAcb.ExGridView.OptionsBehavior.Editable = true;
                    gcxAcb.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
                    gcxAcb.ExGridView.Columns["accname"].OptionsColumn.AllowEdit = false;
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
                                if (cctBindingSource.Position > 0)
                                    tsItem.Enabled = true;
                                break;
                            case "tsbtnNext":
                            case "tsbtnLast":
                                if (cctBindingSource.Position >= 0 && cctBindingSource.Position < cctBindingSource.Count)
                                    tsItem.Enabled = true;
                                break;
                        }
                    }

                    gcxCca.ExGridView.OptionsBehavior.Editable = false;
                    gcxCca.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;

                    gcxAcb.ExGridView.OptionsBehavior.Editable = false;
                    gcxAcb.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                    break;
            }
        }

        private void cctTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (!tsbtnEdit.Enabled)
            {
                editNode.SetValue("name", cctTextEdit.EditValue + " " + nameTextEdit.EditValue);
                editNode.SetValue("cct", cctTextEdit.EditValue);
            }
        }

        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            if (treeCct.FocusedNode.HasChildren)
            {
                MessageBox.Show("Node has children, cannot be deleted!");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this item?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                treeCct.DeleteNode(treeCct.FocusedNode);
                cctBindingSource.RemoveCurrent();
                daCct.Update(casDataSet.cct);
            }
        }
    }
}
