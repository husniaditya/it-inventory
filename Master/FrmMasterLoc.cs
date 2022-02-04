using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CAS.Master
{
    public partial class FrmMasterLoc : CAS.Master.BaseMaster
    {
        public FrmMasterLoc()
        {
            InitializeComponent();
        }

        private void FrmMasterLoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'casDataSet.loc' table. You can move, or remove it, as needed.
            //this.locTableAdapter.Fill(this.casDataSet.loc);

        }
    }
}

