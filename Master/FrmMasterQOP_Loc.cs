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
    public partial class FrmMasterQOP_Loc : XtraForm
    {
        MySqlDataAdapter daPeriod = DB.sql.SelectAdapter("select * from m_qop_loc order by `date` ");

        public FrmMasterQOP_Loc()
        { 
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridControlEx));
            InitializeComponent();
            gcPeriod.ExToolStrip.Items["tsbtnShow"].Visible = false;
            gcPeriod.ExToolStrip.Items["copyToolStripButton"].Visible = false;
            gcPeriod.ExToolStrip.Items["helpToolStripButton"].Visible = false;
            ToolStripButton tsbtnSave = new System.Windows.Forms.ToolStripButton("Save", ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image"))), (ExGridView_Save_Click), "tsbtnSave");
            gcPeriod.ExToolStrip.Items.Add(tsbtnSave);
            daPeriod.Fill(casDataSet.m_qop_loc);
            gcPeriod.ExGridControl.DataSource = casDataSet.m_qop_loc;
            gcPeriod.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
            gcPeriod.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
            gcPeriod.ExGridView.OptionsBehavior.Editable = true;
            
        }

        private void FrmMasterQOP_Loc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'casDataSet.prosenbop' table. You can move, or remove it, as needed.
            //this.prosenbopTableAdapter.Fill(this.casDataSet.prosenbop);
            // TODO: This line of code loads data into the 'casDataSet._close' table. You can move, or remove it, as needed.
            //this._closeTableAdapter.Fill(this.casDataSet._close);
            gcPeriod.ExGridView.Columns["date"].Caption = "Date";
            gcPeriod.ExGridView.Columns["loc"].ColumnEdit = new GridLookUpEx(DB.sql, "select loc as Location,name as locname from loc","Location", "Location", gcPeriod.ExGridView, "", true, true, "Location");
            gcPeriod.ExGridView.Columns["loc"].Caption = "Location";
            gcPeriod.ExGridView.Columns["qop_name"].Caption = "QOP Name";
            gcPeriod.ExGridView.BestFitColumns();
        }

        void ExGridView_Save_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();
            daPeriod.Update(casDataSet.m_qop_loc);
            MessageBox.Show("Data telah berhasil di simpan!");
        }

        void ExGridView_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this item?", "Confirmation",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                DB.DeleteDetailRows2(gcPeriod.ExGridView);
            }
           
        }

        void ExGridView_New_Click(object sender, EventArgs e)
        {
         
            DataRow row = casDataSet.m_qop_loc.NewRow();
           
            try
            {
                row["date"] = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                row["loc"] = "";
                row["qop_name"] = "";
                casDataSet.m_qop_loc.Rows.Add(row);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        private void FrmMasterQOP_Loc_FormClosing(object sender, FormClosingEventArgs e)
        {
            daPeriod.Update(casDataSet.m_qop_loc);
        }
      }
}