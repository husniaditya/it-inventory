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
    public partial class FrmMasterShipper : CAS.Master.BaseMaster
    {
        public FrmMasterShipper()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlDetail, DB.sql);
        }

        private void FrmMasterShipper_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'casDataSet.mtp' table. You can move, or remove it, as needed.
           // this.mtpTableAdapter.Fill(this.casDataSet.mtp);

        }

        private void FrmMasterShipper_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'casDataSet.m_shipper' table. You can move, or remove it, as needed.
            //this.m_shipperTableAdapter.Fill(this.casDataSet.m_shipper);

        }
    }
}

