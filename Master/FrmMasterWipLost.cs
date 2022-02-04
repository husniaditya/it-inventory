using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DevExpress.XtraEditors;
using KASLibrary;

namespace CAS.Master
{
    public partial class FrmMasterWipLost : XtraForm
    {
        MySqlDataAdapter daWip;
        public FrmMasterWipLost()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridControlEx));
            InitializeComponent();
            daWip = DB.sql.SelectAdapter("select * from wip_lost order by date");
     
            gcwip.ExToolStrip.Items["tsbtnShow"].Visible = false;
            gcwip.ExToolStrip.Items["copyToolStripButton"].Visible = false;
            gcwip.ExToolStrip.Items["helpToolStripButton"].Visible = false;
            ToolStripButton tsbtnSave = new System.Windows.Forms.ToolStripButton("Save", ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image"))), (ExGridView_Save_Click), "tsbtnSave");
            gcwip.ExToolStrip.Items.Add(tsbtnSave);
            daWip.Fill(casDataSet.wip_lost);
            gcwip.ExGridControl.DataSource = casDataSet.wip_lost;
           
            gcwip.ExGridView.Columns["cct"].ColumnEdit = new GridLookUpEx(DB.sql, "select cct,name as remmark from cct where cct like '111%'", "", "cct", gcwip.ExGridView, "", true, true, "Cost Center");
            gcwip.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
            gcwip.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
         //   gcwip.ExToolStrip.Items["tsbtnSave"].Click += new EventHandler(ExGridView_Save_Click);
            gcwip.ExGridView.OptionsBehavior.Editable = true;
            gcwip.ExGridView.Columns["no"].Visible = false;
            gcwip.ExGridView.Columns["period"].OptionsColumn.AllowEdit = true;
            gcwip.ExGridView.Columns["remmark"].OptionsColumn.AllowEdit = true;
          
        }

        void ExGridView_New_Click(object sender, EventArgs e)
        {
            string query = "select max(date) from wip_lost ";
            DataTable dttgl = DB.sql.Select(query);

            DataRow row = casDataSet.wip_lost.NewRow();
            DateTime a;
            if (dttgl.Rows[0][0].ToString() != "")
            {
                a = (DateTime) dttgl.Rows[0][0];
                a = a.AddDays(1); 
            }
            else
            {
                a = DateTime.Now ;
            }
            row["date"] = a;
            row["period"] = dateperiod.Text.Substring(2,4) ;
            row["remmark"] = "";
            row["chusr"] = DB.casUser.User;
            row["chtime"] = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            row["no"] = DB.GetRowCount(casDataSet.wip_lost) + 1;
            casDataSet.wip_lost.Rows.Add(row);
            //   DB.InsertDetailRows(gcPeriod.ExGridView, row);
        }

        private void FrmMasterWipLost_Load(object sender, EventArgs e)
        {
    
        }

        void ExGridView_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this item?", "Confirmation",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                DB.DeleteDetailRows(gcwip.ExGridView);
                //    daPeriod.Update(casDataSet._close);
            }

        }

        void ExGridView_Save_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();
            daWip.Update(casDataSet.wip_lost);
            MessageBox.Show("Data telah berhasil di simpan!");
        }

        private void dateperiod_ValueChanged(object sender, EventArgs e)
        {
            daWip = DB.sql.SelectAdapter("select * from wip_lost where period = right(" +dateperiod.Text + ",4) order by date");
            casDataSet.wip_lost.Clear();
            daWip.Fill(casDataSet.wip_lost);
            gcwip.ExGridControl.DataSource = casDataSet.wip_lost;
            gcwip.Refresh();
        }
    }
}