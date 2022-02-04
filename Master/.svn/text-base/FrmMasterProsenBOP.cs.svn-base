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
    public partial class FrmMasterProsenBOP : XtraForm
    {
        MySqlDataAdapter daPeriod = DB.sql.SelectAdapter("select * from prosenbop order by period");

        public FrmMasterProsenBOP()
        { 
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridControlEx));
            InitializeComponent();
            gcPeriod.ExToolStrip.Items["tsbtnShow"].Visible = false;
            gcPeriod.ExToolStrip.Items["copyToolStripButton"].Visible = false;
            gcPeriod.ExToolStrip.Items["helpToolStripButton"].Visible = false;
            ToolStripButton tsbtnSave = new System.Windows.Forms.ToolStripButton("Save", ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image"))), (ExGridView_Save_Click), "tsbtnSave");
            gcPeriod.ExToolStrip.Items.Add(tsbtnSave);
            daPeriod.Fill(casDataSet.prosenbop);
            gcPeriod.ExGridControl.DataSource = casDataSet.prosenbop;
            gcPeriod.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
            gcPeriod.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
            gcPeriod.ExGridView.OptionsBehavior.Editable = true;
            //gcPeriod.ExGridView.Columns["no"].Visible = false;
            gcPeriod.ExGridView.Columns["period"].OptionsColumn.AllowEdit = true;
        }
        
        private void FrmMasterProsenBOP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'casDataSet.prosenbop' table. You can move, or remove it, as needed.
            //this.prosenbopTableAdapter.Fill(this.casDataSet.prosenbop);
            // TODO: This line of code loads data into the 'casDataSet._close' table. You can move, or remove it, as needed.
            //this._closeTableAdapter.Fill(this.casDataSet._close);
            gcPeriod.ExGridView.Columns["cct"].ColumnEdit = new GridLookUpEx(DB.sql, "select cct as `Cost Center`,left(name,45) as `Cost Center Name` from cct where detil=1", "cct", "cct", gcPeriod.ExGridView, "", true, true, "Cost Center");
            gcPeriod.ExGridView.Columns["period"].Caption = "Period";
            gcPeriod.ExGridView.Columns["nama"].Caption = "Nama";
            gcPeriod.ExGridView.Columns["cct"].Caption = "Cost Center";
            gcPeriod.ExGridView.Columns["prosen"].Caption = "Prosentase";
            gcPeriod.ExGridView.BestFitColumns();
        }

        void ExGridView_Save_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();
            daPeriod.Update(casDataSet.prosenbop);
            MessageBox.Show("Data telah berhasil di simpan!");
        }

        void ExGridView_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this item?", "Confirmation",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                DB.DeleteDetailRows2(gcPeriod.ExGridView);
            //    daPeriod.Update(casDataSet._close);
            }
           
        }

        void ExGridView_New_Click(object sender, EventArgs e)
        {
            //string query = "select max(period) from prosenbop ";
            //DataTable dtperiod = DB.sql.Select(query);
         
            DataRow row = casDataSet.prosenbop.NewRow();
            string b = "";
            //if (dtperiod.Rows[0][0].ToString() != "")
            //{
            //    string a = dtperiod.Rows[0][0].ToString();
                
            //    if (a.Substring(2, 2) == "12")
            //    {
            //        b = string.Concat(Convert.ToString(Convert.ToInt32((Convert.ToString(Convert.ToInt32(a) + 1).PadLeft(4, '0')).Substring(0, 2)) + 1), "01");
            //    }
            //    else
            //    {
            //        b = Convert.ToString(Convert.ToInt32(a) + 1).PadLeft(4, '0');
            //    }
            //}
            //else
         //   {
                b = DB.loginPeriod;
           // }

            try
            {
                row["period"] = b;
                row["nama"] = "";
                row["cct"] = "";
                row["prosen"] = 0;
                //row["chtime"] = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                //row["no"] = DB.GetRowCount(casDataSet.prosenbop) + 1;
                casDataSet.prosenbop.Rows.Add(row);
                //   DB.InsertDetailRows(gcPeriod.ExGridView, row);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        private void FrmMasterProsenBOP_FormClosing(object sender, FormClosingEventArgs e)
        {
            daPeriod.Update(casDataSet.prosenbop);
        }
      }
}