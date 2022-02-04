using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CAS.Master
{
    public partial class FrmMasterMtp : CAS.Master.BaseMaster
    {
        public FrmMasterMtp()
        {
            InitializeComponent();
        }

        private void FrmMasterMtp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'casDataSet.mtp' table. You can move, or remove it, as needed.
           // this.mtpTableAdapter.Fill(this.casDataSet.mtp);

        }
    }
}

