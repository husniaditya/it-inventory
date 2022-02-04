using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KASLibrary;

namespace CAS.Master
{
    public partial class FrmMasterUsrPr : CAS.Master.BaseMaster
    {
        public FrmMasterUsrPr()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlDetail, DB.sql);
            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
        }

        private void FrmMasterUsrPr_Load(object sender, EventArgs e)
        {
          
        }
        void tsbtnNew_Click(object sender, EventArgs e)
        {
            aktifCheckBox.Checked = true;
        }

       
    }
}

