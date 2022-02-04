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
    public partial class FrmMasterKGr : CAS.Master.BaseMaster
    {
        public FrmMasterKGr()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlDetail, DB.sql);
            tsbtnDelete.Click += new EventHandler(tsbtnDelete_Click);
            this.MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);
        }

        private void FrmMasterKGr_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'casDataSet.accbank' table. You can move, or remove it, as needed.
         //   this.accbankTableAdapter.Fill(this.casDataSet.accbank);
            if (this.Tag.ToString() == "39")
            {
                this.Name = "REKENINGPENGIRIM";
                MasterBindingSource.Filter = "group_=1";
                MasterTable.Clear();
                MasterAdapter = DB.sql.SelectAdapter("select nomor,no_rek,bank,sub,acc,chtime,chusr,gironame,namavendor,adressbank,citybank,group_ from accbank where group_=1 order by no_rek,sub ");
                MasterAdapter.Fill(MasterTable);
               
                base.setMode(Mode.View);
                MasterBindingSource.MoveLast();
            }
            if (this.Tag.ToString() == "3l")
            {
                this.Name = "REKENINGVENDOR";
                MasterBindingSource.Filter = "group_=2";
                MasterTable.Clear();
                MasterAdapter = DB.sql.SelectAdapter("select nomor,no_rek,bank,sub,acc,chtime,chusr,gironame,namavendor,adressbank,citybank,group_ from accbank where group_=2 order by no_rek,sub");
                MasterAdapter.Fill(MasterTable);

                textBoxEx1.ExSqlQuery = "Call SP_LookUp('vendor')";
                textBoxEx1.ExSqlInstance = DB.sql;

                base.setMode(Mode.View);
                MasterBindingSource.MoveLast();
            }
        }

        void tsbtnDelete_Click(object sender, EventArgs e)
        {
            DB.sql.Execute("update accbank set group_= '0' where no_rek ='" + no_rekTextEdit.Text + "'");
            MessageBox.Show("Nomor rekening sudah terhapus!");
            MasterBindingSource.MoveLast();
        }

        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
      
         }

        private void namavendorLabel_Click(object sender, EventArgs e)
        {

        }

        private void citybankLabel_Click(object sender, EventArgs e)
        {

        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();
            if (this.Tag.ToString() == "39")
            {
                ((DataRowView)MasterBindingSource.Current).Row["group_"] = 1;
            }
            if (this.Tag.ToString() == "3l")
            {
                ((DataRowView)MasterBindingSource.Current).Row["group_"] = 2;
            }
            base.tsbtnSave_Click(sender, e);
        }

        private void textBoxEx1_EditValueChanged(object sender, EventArgs e)
        {
             DataRow row = textBoxEx1.ExGetDataRow();
          //  no_kon.ExSqlQuery = "Call SP_LookUpnokon('" + ctrlSub.txtSub.Text + "','','1')";
             if (row != null)
             {
                 namavendorTextEdit.EditValue = row[1].ToString();
             }
       
        }

        private void namavendorTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(0);
        }
        protected override void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            int curPos = MasterBindingSource.Position; ;
            if (this.Tag.ToString() == "39")
            {
                this.Name = "REKENINGPENGIRIM";
                MasterBindingSource.Filter = "group_=1";
                MasterTable.Clear();
                MasterAdapter = DB.sql.SelectAdapter("select nomor,no_rek,bank,sub,acc,chtime,chusr,gironame,namavendor,adressbank,citybank,group_ from accbank where group_=1 order by no_rek,sub ");
                MasterAdapter.Fill(MasterTable);
            }
            if (this.Tag.ToString() == "3l")
            {
                this.Name = "REKENINGVENDOR";
                MasterBindingSource.Filter = "group_=2";
                MasterTable.Clear();
                MasterAdapter = DB.sql.SelectAdapter("select nomor,no_rek,bank,sub,acc,chtime,chusr,gironame,namavendor,adressbank,citybank,group_ from accbank where group_=2 order by no_rek,sub");
                MasterAdapter.Fill(MasterTable);
            }
            MasterBindingSource.Position = curPos;
         //   tslblRecord.Text = "Record " + (MasterBindingSource.Position + 1).ToString() + " of " + MasterTable.Rows.Count;
 
        }
 }
 
}