using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CAS.Master
{
    public partial class FrmMasterGroup : CAS.Master.BaseMaster
    {
        public FrmMasterGroup()
        {
            InitializeComponent();
            this.accTextBoxEx.ExSqlInstance = DB.sql;
            this.accumbfTextBoxEx.ExSqlInstance = DB.sql;
            this.accumTextBoxEx.ExSqlInstance = DB.sql;
            this.accppnTextBoxEx.ExSqlInstance = DB.sql;
            this.accppnbmTextBoxEx.ExSqlInstance = DB.sql;
            this.acchtbftextBoxEx1.ExSqlInstance = DB.sql;
            this.accinvjltextBoxEx2.ExSqlInstance = DB.sql;
            this.textBoxEx1.ExSqlInstance = DB.sql;
            this.textBoxEx2.ExSqlInstance = DB.sql;
            this.accrevTextBoxEx.ExSqlInstance = DB.sql;
            this.accrevbhn.ExSqlInstance = DB.sql;
            this.acclainex.ExSqlInstance = DB.sql;

        }

        private void FrmMasterGroup_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'casDataSet.grp' table. You can move, or remove it, as needed.
            //this.grpTableAdapter.Fill(this.casDataSet.grp);

        }

        private void accTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void accrevTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void accinvjllokLabel_Click(object sender, EventArgs e)
        {

        }

        private void pnlDetail_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

