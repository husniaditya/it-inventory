using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DevExpress.XtraTreeList;
using DevExpress.Utils.Menu;
using KASLibrary;
using DevExpress.XtraGrid.Columns;

namespace CAS.Fungsi
{
    public partial class FrmUserGroup : Master.BaseMaster
    {
        MySqlDataAdapter daPerms, daModuld;
        DataRow selectedRow;
        DataTable dtModul;

        private string FocusedMenuId
        {
            get { return treeMenu.FocusedNode.GetValue("menuid").ToString(); }
        }

        public FrmUserGroup()
        {
            InitializeComponent();

            tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            tsbtnRefresh.Click += new EventHandler(tsbtnRefresh_Click);

            dtModul = DB.sql.Select("select noseri, menuid, remark from modul");
            casDataSet.moduld.Columns.Add("Keterangan");
            casDataSet.moduld.Columns.Add("Menu ID");

            gcxModuld.ExTitleLabel.Text = "Assigned No Seri";
            gcxModuld.ExGridControl.DataSource = casDataSet.moduld;
            gcxModuld.ExGridView.OptionsView.ShowGroupPanel = false;
            gcxModuld.ExToolStrip.Items["printToolStripButton"].Visible = gcxModuld.ExToolStrip.Items["saveToolStripButton"].Visible = false;
            gcxModuld.ExStatusStrip.Visible = false;
            gcxModuld.ExGridView.Columns["role"].Caption = "Role";
            gcxModuld.ExGridView.Columns["role"].Visible = gcxModuld.ExGridView.Columns["Menu ID"].Visible = false;
            gcxModuld.ExGridView.Columns["noseri"].Caption = "No Seri";
            gcxModuld.ExGridView.Columns["noseri"].ColumnEdit = new GridLookUpEx(DB.sql, "", "", "", gcxModuld.ExGridView, "", true, true, "Unassigned No Seri");
            gcxModuld.ExGridView.Columns["noseri"].ColumnEdit.Enter += new EventHandler(noseriColumnEdit_Enter);

            gcxModuld.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(gcxModuld_tsbtnNew_Click);
            gcxModuld.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(gcxModuld_tsbtnDelete_Click);
            gcxModuld.ExToolStrip.Items["tsbtnNew"].Enabled = gcxModuld.ExToolStrip.Items["tsbtnDelete"].Enabled = false;

            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
            tsbtnNew.Click += new EventHandler(tsbtnEdit_Click);
        }

        private void FrmUserGroup_Load(object sender, EventArgs e)
        {
            PopulateTreeMenu();
            usrlevelBindingSource.PositionChanged += new EventHandler(usrlevelBindingSource_PositionChanged);
            PopulatePerms();
            PopulateCheckBoxes(treeMenu.Nodes[0]["menuid"].ToString());
            PopulateNoSeri();
        }

        private void PopulateTreeMenu()
        {
            DataTable dtMenu = DB.sql.Select("select menuid, caption from menuid");

            dtMenu.Columns.Add("parent");

            foreach (DataRow drMenu in dtMenu.Rows)
            {
                string menuId = drMenu["menuid"].ToString();
                if (menuId.Length == 0)
                    drMenu["parent"] = "0";
                else
                    drMenu["parent"] = menuId.Substring(0, menuId.Length - 1);
            }

            treeMenu.DataSource = dtMenu;
        }

        private void usrlevelBindingSource_PositionChanged(object sender, EventArgs e)
        {
            PopulatePerms();
            PopulateCheckBoxes(FocusedMenuId);
            PopulateNoSeri();
        }

        private void PopulatePerms()
        {
            daPerms = DB.sql.SelectAdapter("select * from perms where role='" + roleTextEdit.EditValue + "'");
            casDataSet.perms.Clear();
            daPerms.Fill(casDataSet.perms);
        }

        private void treeMenu_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            PopulateCheckBoxes(e.Node.GetValue("menuid").ToString());
            gcxModuld.ExGridView.Columns["Menu ID"].FilterInfo = new ColumnFilterInfo("[Menu ID] LIKE '" + FocusedMenuId + "%'","");
            gcxModuld.ExGridView.BestFitColumns();
        }

        private void PopulateCheckBoxes(string menuId)
        {
            int rowIndex = permsBindingSource.Find("menuid", menuId);

            if (rowIndex < 0)
            {
                selectedRow = null;
                chkSelect.Checked = chkInsert.Checked = chkUpdate.Checked = chkDelete.Checked = chkPrint.Checked = chkApprove.Checked = false;
            }
            else
            {
                selectedRow = casDataSet.perms[rowIndex];
                chkSelect.Checked = Convert.ToBoolean(selectedRow["select"]);
                chkInsert.Checked = Convert.ToBoolean(selectedRow["insert"]);
                chkUpdate.Checked = Convert.ToBoolean(selectedRow["update"]);
                chkDelete.Checked = Convert.ToBoolean(selectedRow["delete"]);
                chkPrint.Checked = Convert.ToBoolean(selectedRow["print"]);
                chkApprove.Checked = Convert.ToBoolean(selectedRow["approve"]);
                chkJurnal.Checked = Convert.ToBoolean(selectedRow["jurnal"]);
            }
        }

        private void chkSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (roleTextEdit.Text == "")
            {
                (sender as CheckBox).Checked = false;
                return;
            }
            //if (selectedRow == null && (!chkSelect.Checked || // if chkSelect is unchecked, uncheck other operations as well
            //    (!chkInsert.Checked && !chkUpdate.Checked && !chkInsert.Checked && !chkDelete.Checked)))
            if (!chkSelect.Checked)
                chkInsert.Checked = chkUpdate.Checked = chkDelete.Checked = chkPrint.Checked = chkApprove.Checked = chkJurnal.Checked = chkSelect.Checked;

            UpdateSelectedRow(sender);
        }

        private void chkInsert_CheckedChanged(object sender, EventArgs e)
        {
            if (roleTextEdit.Text == "")
            {
                (sender as CheckBox).Checked = false;
                return;
            }

            //if (!chkSelect.Checked && (sender as CheckBox).Checked)
            //    chkSelect.Checked = true;

            UpdateSelectedRow(sender);
        }

        private void UpdateSelectedRow(object sender)
        {
            if (this.mode == Mode.View) return;

            if (selectedRow == null)
            {
                selectedRow = casDataSet.perms.NewRow();
                selectedRow["role"] = roleTextEdit.EditValue;
                selectedRow["menuid"] = treeMenu.FocusedNode.GetValue("menuid");
                if (selectedRow["role"] != DBNull.Value)
                    casDataSet.perms.Rows.Add(selectedRow);
                selectedRow["select"] = selectedRow["insert"] = selectedRow["update"] = selectedRow["delete"] = selectedRow["print"] = selectedRow["approve"] = selectedRow["jurnal"] = 0;
            }

            selectedRow[(sender as CheckBox).Tag.ToString()] = Convert.ToUInt64((sender as CheckBox).Checked);
            //selectedRow["select"] = Convert.ToUInt64(chkSelect.Checked);
            //selectedRow["insert"] = Convert.ToUInt64(chkInsert.Checked);
            //selectedRow["update"] = Convert.ToUInt64(chkUpdate.Checked);
            //selectedRow["delete"] = Convert.ToUInt64(chkDelete.Checked);
            //selectedRow["print"] = Convert.ToUInt64(chkPrint.Checked);

            if ((sender as CheckBox).Tag.ToString() != "select") return;

            if (Convert.ToUInt64(selectedRow["select"]) == 0)
            {
                // remove select on children menu
                DataRow[] childRows = casDataSet.perms.Select("menuid like '" + selectedRow["menuid"].ToString() + "%'");
                foreach (DataRow childRow in childRows)
                {
                    childRow["select"] = Convert.ToUInt64(0);
                }
            }
            else
            {
                // apply select on parents menu
                string menuid = selectedRow["menuid"].ToString();
                for (int i = 1; i < menuid.Length; i++)
                {
                    // use substring to get parents' menuids
                    DataRow[] parentRows = casDataSet.perms.Select("menuid='" + menuid.Substring(0, i) + "'");
                    
                    if (parentRows.Length == 0)
                    {
                        // Create new perms row
                        DataRow parentRow = casDataSet.perms.NewRow();
                        parentRow["role"] = roleTextEdit.EditValue;
                        parentRow["menuid"] = menuid.Substring(0, i);
                        parentRow["select"] = Convert.ToUInt64(1);
                        casDataSet.perms.Rows.Add(parentRow);
                    }
                    else
                        parentRows[0]["select"] = Convert.ToUInt64(1);
                }
            }
        }

        void tsbtnCancel_Click(object sender, EventArgs e)
        {
            casDataSet.perms.RejectChanges();
            PopulateCheckBoxes(FocusedMenuId);
            casDataSet.moduld.RejectChanges();
            gcxModuld.ExGridView.OptionsBehavior.Editable = false;
            gcxModuld.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            gcxModuld.ExToolStrip.Items["tsbtnNew"].Enabled = gcxModuld.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                base.tsbtnSave_Click(sender, e);
                permsBindingSource.EndEdit();
                daPerms.Update(casDataSet.perms);
                moduldBindingSource.EndEdit();
                daModuld.Update(casDataSet.moduld);
                gcxModuld.ExGridView.OptionsBehavior.Editable = false;
                gcxModuld.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                gcxModuld.ExToolStrip.Items["tsbtnNew"].Enabled = gcxModuld.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void treeMenu_ShowTreeListMenu(object sender, DevExpress.XtraTreeList.TreeListMenuEventArgs e)
        {
            TreeListHitInfo hitInfo = treeMenu.CalcHitInfo(e.Point);
            if (hitInfo.HitInfoType == HitInfoType.Column)
            {
                e.Menu.Items.Clear();
                e.Menu.Items.Add(new DXMenuItem("Expand All", new EventHandler(this.expandAllNodesClick)));
                e.Menu.Items.Add(new DXMenuItem("Collapse All", new EventHandler(this.collapseAllNodesClick)));
            }
        }

        private void expandAllNodesClick(object sender, EventArgs e)
        {
            treeMenu.ExpandAll();
        }

        private void collapseAllNodesClick(object sender, EventArgs e)
        {
            treeMenu.CollapseAll();
        }

        void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            PopulatePerms();
            PopulateCheckBoxes(FocusedMenuId);
            PopulateNoSeri();
        }

        private void PopulateNoSeri()
        {
            daModuld = DB.sql.SelectAdapter("select * from moduld where role='" + roleTextEdit.EditValue + "'");
            casDataSet.moduld.Clear();
            daModuld.Fill(casDataSet.moduld);

            foreach (DataRow dRow in casDataSet.moduld.Rows)
            {
                dRow["Keterangan"] = dtModul.Select("noseri='" + dRow["noseri"].ToString() + "'")[0]["remark"];
                dRow["Menu ID"] = dtModul.Select("noseri='" + dRow["noseri"].ToString() + "'")[0]["menuid"];
            }
            gcxModuld.ExGridView.BestFitColumns();
        }

        void gcxModuld_tsbtnDelete_Click(object sender, EventArgs e)
        {
            gcxModuld.ExGridView.DeleteSelectedRows();
        }

        void gcxModuld_tsbtnNew_Click(object sender, EventArgs e)
        {
            noseriColumnEdit_Enter(sender, new EventArgs());
            ((GridLookUpEx)gcxModuld.ExGridView.Columns["noseri"].ColumnEdit).ClickButton();
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            gcxModuld.ExGridView.OptionsBehavior.Editable = true;
            gcxModuld.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gcxModuld.ExToolStrip.Items["tsbtnNew"].Enabled = gcxModuld.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
        }

        void noseriColumnEdit_Enter(object sender, EventArgs e)
        {
            string query = "select '" + roleTextEdit.Text + "' as Role, menuid as `Menu ID`, noseri as `No Seri`, remark as `Keterangan` from modul where menuid like '" + FocusedMenuId + "%' and noseri not in (select noseri from moduld where trim(role)='" + roleTextEdit.Text + "')";
               //   if (roleTextEdit.Text != "")
        //        ((GridLookUpEx)gcxModuld.ExGridView.Columns["noseri"].ColumnEdit).Query =
       //             query.Replace("0", "noseri not in (select noseri from moduld where trim(role)='" + roleTextEdit.Text + "')");
                 ((GridLookUpEx)gcxModuld.ExGridView.Columns["noseri"].ColumnEdit).Query = query;
        }
    }
}
