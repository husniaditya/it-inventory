using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Reflection;

namespace CAS.Master
{
    public partial class FrmMasterModul : CAS.Master.BaseMaster
    {
        MySqlDataAdapter daMenuId = new MySqlDataAdapter();
        MySqlDataAdapter daModuld = new MySqlDataAdapter();
        MySqlDataAdapter daRole = new MySqlDataAdapter();

        public FrmMasterModul()
        {
            InitializeComponent();

            lstAvailableRole.SelectionMode = SelectionMode.MultiSimple;
            lstAssignedRole.SelectionMode = SelectionMode.MultiSimple;

            tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            RefreshForm(true);
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            moduldBindingSource.AllowNew = true;
            RefreshForm(true);
        }

        void tsbtnCancel_Click(object sender, EventArgs e)
        {
            //casDataSet.moduld.RejectChanges();
            //casDataSet.usrlevel.RejectChanges();\
            txtNoSeri_EditValueChanged(sender, new EventArgs());
            RefreshForm(false);

        }

        private void RefreshForm(bool mode)
        {
            lstAvailableRole.Enabled = lstAssignedRole.Enabled = mode;
            btnMoveR.Enabled = btnMoveRAll.Enabled = mode;
            btnMoveL.Enabled = btnMoveLAll.Enabled = mode;
        }

        private void FrmMasterModul_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'casDataSet.moduld' table. You can move, or remove it, as needed.
            //this.moduldTableAdapter.Fill(this.casDataSet.moduld);
            // TODO: This line of code loads data into the 'casDataSet.usrlevel' table. You can move, or remove it, as needed.
           // this.usrlevelTableAdapter.Fill(this.casDataSet.usrlevel);
            // TODO: This line of code loads data into the 'casDataSet.menuid' table. You can move, or remove it, as needed.
            //this.menuidTableAdapter.Fill(this.casDataSet.menuid);
            // TODO: This line of code loads data into the 'casDataSet.modul' table. You can move, or remove it, as needed.
            //this.modulTableAdapter.Fill(this.casDataSet.modul);
            // TODO: This line of code loads data into the 'casDataSet1.usrlevel' table. You can move, or remove it, as needed.
            //this.usrlevelTableAdapter.Fill(this.casDataSet1.usrlevel);

            //get menuid
            casDataSet.menuid.Clear();
            daMenuId = DB.sql.SelectAdapter("Select menuid, caption from menuid where formname <> ''");
            daMenuId.Fill(casDataSet.menuid);

            lookupMenuId.Properties.BestFit();

            RefreshForm(false);
        }
        
        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            base.tsbtnSave_Click(sender, e);
            moduldBindingSource1.EndEdit();
            daModuld.Update(casDataSet.moduld);
            RefreshForm(false);
        }

        private void txtNoSeri_EditValueChanged(object sender, EventArgs e)
        {           
            casDataSet.moduld.Clear();
            daModuld = DB.sql.SelectAdapter("select * from moduld where noseri='" + txtNoSeri.Text + "'");
            daModuld.Fill(casDataSet.moduld);

            //get roles
            casDataSet.usrlevel.Clear();
            daRole = DB.sql.SelectAdapter("Select * from usrlevel where role not in (select role from moduld where noseri='" + txtNoSeri.Text + "')");
            daRole.Fill(casDataSet.usrlevel); 
        }

        private void btnMoveR_Click(object sender, EventArgs e)
        {
            if (lstAvailableRole.SelectedIndex >= 0)
            {
                DataRow[] rows = new DataRow[lstAvailableRole.SelectedIndices.Count];
                for (int i = 0; i < lstAvailableRole.SelectedIndices.Count; i++)
                {
                    rows[i] = casDataSet.usrlevel.Rows[lstAvailableRole.SelectedIndices[i]];
                }
                foreach (DataRow row in rows)
                {
                    casDataSet.moduld.AddmoduldRow(txtNoSeri.Text, row["role"].ToString());
                    casDataSet.usrlevel.Rows.Remove(row);
                }
                //casDataSet.usrlevel.AcceptChanges();
                //casDataSet.moduld.AcceptChanges();            
            }
            else
            {
                MessageBox.Show("Please select role(s) first");
            }
        }

        private void btnMoveRAll_Click(object sender, EventArgs e)
        {
            if (lstAvailableRole.ItemCount > 0)
            {
                DataRow[] rows = new DataRow[lstAvailableRole.ItemCount];

                for (int i = 0; i < lstAvailableRole.ItemCount; i++)
                {
                    rows[i] = casDataSet.usrlevel.Rows[i];
                }

                foreach (DataRow row in rows)
                {
                    casDataSet.moduld.AddmoduldRow(txtNoSeri.Text, row["role"].ToString());
                    casDataSet.usrlevel.Rows.Remove(row);
                }
                //casDataSet.usrlevel.AcceptChanges();
                //casDataSet.moduld.AcceptChanges();
            }
            else
            {
                MessageBox.Show("No role available");
            }
        }

        private void btnMoveLAll_Click(object sender, EventArgs e)
        {
            if (lstAssignedRole.ItemCount > 0)
            {
                DataRow[] rows = new DataRow[lstAssignedRole.ItemCount];

                for (int i = 0; i < lstAssignedRole.ItemCount; i++)
                {
                    rows[i] = casDataSet.moduld.Rows[i];
                }

                foreach (DataRow row in rows)
                {
                    casDataSet.usrlevel.AddusrlevelRow(row["role"].ToString(), "", "", "", 0);
                    //casDataSet.moduld.Rows.Remove(row);
                    row.Delete();
                }
                //casDataSet.moduld.AcceptChanges();
            }
            else
            {
                MessageBox.Show("No role assgined");
            }
        }

        private void btnMoveL_Click(object sender, EventArgs e)
        {
            if (lstAssignedRole.SelectedIndex >= 0)
            {
                DataRow[] rows = new DataRow[lstAssignedRole.SelectedIndices.Count];
                int idx = lstAssignedRole.SelectedIndices[0];
                for (int i = 0; i < lstAssignedRole.SelectedIndices.Count; i++)
                {
                    if (idx >= lstAssignedRole.SelectedIndices[i] && i > 0)
                        idx++;
                    else
                        idx = lstAssignedRole.SelectedIndices[i];
                    //rows[i] = casDataSet.moduld.Rows[lstAssignedRole.SelectedIndices[i]];
                    rows[i] = casDataSet.moduld.Rows[idx];
                    while (rows[i].RowState == DataRowState.Deleted && (i < lstAssignedRole.SelectedIndices.Count - 1 || i == 0))
                    {
                        idx++;
                        rows[i] = casDataSet.moduld.Rows[idx];
                    }
                }
                foreach (DataRow row in rows)
                {
                    casDataSet.usrlevel.AddusrlevelRow(row["role"].ToString(), "", "", "", 0);
                    //casDataSet.moduld.Rows.Remove(row);
                    row.Delete();
                }     
            }
            else
            {
                MessageBox.Show("Please select role(s) first");
            }
        }

        private void lstAssignedRole_MouseClick(object sender, MouseEventArgs e)
        {
            //int idx = 
        }

    }
}

