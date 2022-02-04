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
using DevExpress.XtraReports.UI;

namespace CAS.Laporan
{
    public partial class FrmMPerkiraan : CAS.Laporan.BaseLaporan
    {
        MySqlDataAdapter daAcc = DB.sql.SelectAdapter("select * from acc");
        DataTable dttree;
        public FrmMPerkiraan()
        {
            InitializeComponent();
            daAcc.Fill(casDataSet.acc);
        }

        private void FrmMPerkiraan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'casDataSet.acc' table. You can move, or remove it, as needed.
            //this.accTableAdapter.Fill(this.casDataSet.acc);

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (DevExpress.XtraPrinting.PrintHelper.IsPrintingAvailable)
                DevExpress.XtraPrinting.PrintHelper.ShowPreview(this.treeList1);
            else
                MessageBox.Show("XtraPrinting Library is not found...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Cursor.Current = Cursors.Default;
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
                treeList1.ExpandAll();
            else
                treeList1.CollapseAll();

        }

        private void level_SpinEdit_EditValueChanged(object sender, EventArgs e)
        {
            dttree = DB.sql.Select("select * from acc where level_<="+level_SpinEdit.Value);
            treeList1.DataSource = dttree;

            if (this.checkBox1.Checked)
                treeList1.ExpandAll();
            else
                treeList1.CollapseAll();
        }

        private void treeList1_NodeCellStyle(object sender, DevExpress.XtraTreeList.GetCustomNodeCellStyleEventArgs e)
        {

            if (checkBox2.Checked )
            {
                switch (e.Node[2].ToString())
                {
                    case "0":
                        e.Appearance.BackColor = Color.MediumSpringGreen;
                        break;
                    case "1":
                        e.Appearance.BackColor = Color.LightSkyBlue;
                        break;
                    case "2":
                        e.Appearance.BackColor = Color.Yellow;
                        break;
                    case "3":
                        e.Appearance.BackColor = Color.Lime;
                        break;
                    case "4":
                        e.Appearance.BackColor = Color.Tomato;
                        break;
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
                treeList1.ExpandAll();
            else
                treeList1.CollapseAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GridReport frmDoc = new GridReport("select * from acc where level_<=" + level_SpinEdit.Value);
            frmDoc.ShowDialog();
        }

        
    }
}

