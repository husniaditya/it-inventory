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
    public partial class FrmMasterDesign : CAS.Master.BaseMaster
    {        
        public FrmMasterDesign()
        {
            InitializeComponent();

            Utility.SetSqlInstance(tabControl1, DB.sql);
            SetSpinEditMinMaxValue();
            //PopulateGroup();
            PopulateTypeFinishing();
            PopulateKwalitet();

            MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);
        }

        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            btnCopyDesign.Visible = (MasterBindingSource.Position == MasterTable.Rows.Count);
        }

        private void PopulateKwalitet()
        {
            kwalitetComboBox.Items.Clear();

            DataTable dtKwalitet = new DataTable();
            dtKwalitet = DB.sql.Select("Select * from kwalitet");

            DataTable dtCBKwalitet = new DataTable();
            dtCBKwalitet.Columns.Add("no", typeof(Int32));
            dtCBKwalitet.Columns.Add("kwalitet", typeof(String));

            string[] kode = new string[5];
            string kwalitet = "";
            foreach (DataRow row in dtKwalitet.Rows)
            {                
                kode = row["kode"].ToString().Split('-');
                kwalitet = kode[0] + "/";
                if (kode[1] != " ")
                    kwalitet = kwalitet + kode[1];

                if (kode[2] != " " && kode[1] != " ")
                    kwalitet = kwalitet + "x" + kode[2];
                else if (kode[2] != " " && kode[1] == " ")
                    kwalitet = kwalitet + kode[2];

                if (kode[3] != " " && kode[2] != " ") 
                    kwalitet = kwalitet + "x" + kode[3];
                else if (kode[3] != " " && kode[2] == " ") 
                    kwalitet = kwalitet + kode[3];

                if (kode[1] != " " || kode[2] != " " || kode[3] != " ")
                    kwalitet = kwalitet + "/";

                if (kode[4] != " ")
                    kwalitet = kwalitet + kode[4];

                kwalitet = kwalitet + "-" + row["lapis"].ToString();
                DataRow cbRow = dtCBKwalitet.NewRow();
                cbRow["kwalitet"] = kwalitet;
                cbRow["no"] = row["no"];
                dtCBKwalitet.Rows.Add(cbRow);
            }

            kwalitetComboBox.DataSource = dtCBKwalitet;
            kwalitetComboBox.DisplayMember = "kwalitet";
            kwalitetComboBox.ValueMember = "no";
        }

        //private void PopulateGroup()
        //{
        //    DataTable dtGroup = new DataTable();
        //    dtGroup = DB.GetMasterSetting("Group");
        //    grpComboBox.DataSource = dtGroup;
        //    grpComboBox.DisplayMember = "value";
        //    grpComboBox.ValueMember = "value";
        //}

        private void PopulateTypeFinishing()
        {
            DataTable dtTypeFinishing = new DataTable();
            dtTypeFinishing = DB.GetMasterSetting("Type Finishing");
            glueComboBox.DataSource = dtTypeFinishing;
            glueComboBox.DisplayMember = "value";
            glueComboBox.ValueMember = "value";
        }

        private void SetSpinEditMinMaxValue()
        {
            //tab specs
            pjgSpinEdit.Properties.MinValue = lbrSpinEdit.Properties.MinValue = tigSpinEdit.Properties.MinValue = 0;
            pjgSpinEdit.Properties.MaxValue = lbrSpinEdit.Properties.MaxValue = tigSpinEdit.Properties.MaxValue = Int32.MaxValue;
            jmlstichSpinEdit.Properties.MinValue = stichSpinEdit.Properties.MinValue = 0;
            jmlstichSpinEdit.Properties.MaxValue = stichSpinEdit.Properties.MaxValue = Int32.MaxValue ;
            jmlkrtSpinEdit.Properties.MinValue = 0;
            jmlkrtSpinEdit.Properties.MaxValue = Int32.MaxValue;
            sflexoSpinEdit.Properties.MinValue = sglueSpinEdit.Properties.MinValue = sstichSpinEdit.Properties.MinValue = 0;
            sflexoSpinEdit.Properties.MaxValue = sglueSpinEdit.Properties.MaxValue = sstichSpinEdit.Properties.MaxValue = Int32.MaxValue;

            //tab ukuran
            pSpinEdit.Properties.MinValue = lSpinEdit.Properties.MinValue = 0;
            pSpinEdit.Properties.MaxValue = lSpinEdit.Properties.MaxValue = Int32.MaxValue;
            l1SpinEdit.Properties.MinValue = tSpinEdit1.Properties.MinValue = l2SpinEdit.Properties.MinValue = 0;
            l1SpinEdit.Properties.MaxValue = tSpinEdit1.Properties.MaxValue = l2SpinEdit.Properties.MaxValue = Int32.MaxValue;
            dikaliSpinEdit.Properties.MinValue = tambahSpinEdit.Properties.MinValue = 0;
            dikaliSpinEdit.Properties.MaxValue = tambahSpinEdit.Properties.MaxValue = Int32.MaxValue;
            lKertasSpinEdit.Properties.MinValue = pKertasSpinEdit.Properties.MinValue = 0;
            lKertasSpinEdit.Properties.MaxValue = pKertasSpinEdit.Properties.MaxValue = Int32.MaxValue;
            kaliSpinEdit.Properties.MinValue = kalipSpinEdit.Properties.MinValue = jmlbundelSpinEdit.Properties.MinValue = 0;
            kaliSpinEdit.Properties.MaxValue = kalipSpinEdit.Properties.MaxValue = jmlbundelSpinEdit.Properties.MaxValue = Int32.MaxValue;
            beratSpinEdit.Properties.MinValue = tambahrpSpinEdit.Properties.MinValue = 0;
            beratSpinEdit.Properties.MaxValue = tambahrpSpinEdit.Properties.MaxValue = Int32.MaxValue;
            jmlprodSpinEdit.Properties.MinValue = counterSpinEdit.Properties.MinValue = hrgjualSpinEdit.Properties.MinValue = 0;
            jmlprodSpinEdit.Properties.MaxValue = counterSpinEdit.Properties.MaxValue = hrgjualSpinEdit.Properties.MaxValue = Int32.MaxValue;
        }

        private void FrmMasterDesign_Load(object sender, EventArgs e)
        {
            //Utility.SetSqlInstance(tabControl1, DB.sql);

        }

        private void glueComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (glueComboBox.SelectedValue.ToString() == "Glue")
            {
                lblStich.Visible = false;
                jmlstichSpinEdit.Visible = false;
                lblX.Visible = false;
                stichSpinEdit.Visible = false;
                sstichSpinEdit.Enabled = false;
            }
            else
            {
                lblStich.Visible = true;
                jmlstichSpinEdit.Visible = true;
                lblX.Visible = true;
                stichSpinEdit.Visible = true;
                sstichSpinEdit.Enabled = true;
            }
        }

        private void btnCopyDesign_Click(object sender, EventArgs e)
        {
            if (nodsgTextEdit.Text == "")
            {
                MessageBox.Show("Please enter new No Design!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FrmDialog frmDialog = new FrmDialog("Master Design", DB.sql, "Call SP_LookUp('dsg')");

            if (frmDialog.ShowDialog() == DialogResult.OK)
            {
                string nodsg = frmDialog.ResultRows[0]["No Design"].ToString();

                DataRow drDsg = MasterTable.Select("nodsg='" + nodsg + "'")[0];

                foreach (DataColumn dCol in MasterTable.Columns)
                {
                    if (dCol.ColumnName != "nodsg")
                        (MasterBindingSource.Current as DataRowView).Row[dCol] = drDsg[dCol];
                }
                MasterBindingSource.EndEdit();

                // Comment: Repeat Filling in Info's
                foreach (DataColumn dCol in MasterTable.Columns)
                {
                    if (dCol.ColumnName != "nodsg")
                        (MasterBindingSource.Current as DataRowView).Row[dCol] = drDsg[dCol];
                }
                MasterBindingSource.EndEdit();
            }
        } 
    }
}