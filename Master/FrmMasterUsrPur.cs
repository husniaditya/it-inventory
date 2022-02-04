using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CAS.Master
{
    public partial class FrmMasterUsrP : CAS.Master.BaseMaster
    {
        public FrmMasterUsrP()
        {
            InitializeComponent();
            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            textBoxEx1.ExSqlInstance = DB.sql;
        }

        private void FrmMasterUsrP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'casDataSet.usrp' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'casDataSet.mtp' table. You can move, or remove it, as needed.
           // this.mtpTableAdapter.Fill(this.casDataSet.mtp);

        }
        void tsbtnNew_Click(object sender, EventArgs e)
        {
            aktifCheckBox.Checked = true;
        }
    }
}

