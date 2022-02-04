using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CAS.Proses
{
    public partial class FrmPAdjHpp : CAS.Master.BaseMaster
    {
        public FrmPAdjHpp()
        {
            InitializeComponent();
            MasterQuery = "select * from " + MasterTable.TableName + " where period='" + DB.loginPeriod + "'";
            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnDelete.Click += new EventHandler(tsbtnDelete_Click);
        }

        private void FrmPAdjHpp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'casDataSet.adj' table. You can move, or remove it, as needed.
            //this.adjTableAdapter.Fill(this.casDataSet.adj);
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            /*
            adjTextEdit.EditValue = "ADJHPPR";
            periodTextEdit.EditValue = DB.loginPeriod;
            */

        }

        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this item?", "Confirmation",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                MasterBindingSource.RemoveCurrent();
                MasterAdapter.Update(MasterTable);
            }
        }
      
        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                base.tsbtnSave_Click(sender, e);
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Data adjusment hpp produksi sudah ada, pakai edit untuk merubah");
            }
        }

        private void valSpinEdit_EditValueChanged(object sender, EventArgs e)
        {
            adjTextEdit.EditValue = "ADJHPPR";
            periodTextEdit.EditValue = DB.loginPeriod;
        }
    }
}

