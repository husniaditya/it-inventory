using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CAS.Master
{
    public partial class FrmMasterMsn : CAS.Master.BaseMaster
    {
        public FrmMasterMsn()
        {
            InitializeComponent();
        }

        private void FrmMasterMtp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'casDataSet.msn' table. You can move, or remove it, as needed.
           // this.msnTableAdapter.Fill(this.casDataSet.msn);
            // TODO: This line of code loads data into the 'casDataSet.mtp' table. You can move, or remove it, as needed.
           // this.mtpTableAdapter.Fill(this.casDataSet.mtp);

        }
    }
}

