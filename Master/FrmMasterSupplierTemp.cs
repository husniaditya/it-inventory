using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CAS.Master
{
    public partial class FrmMasterSupplierTemp : CAS.Master.BaseMaster
    {
        MySqlDataAdapter daSub = new MySqlDataAdapter();

        public FrmMasterSupplierTemp()
        {
            InitializeComponent();
            grpTextBoxEx.ExSqlInstance = DB.sql;
            txtCur.ExSqlInstance = DB.sql;
            spinTOP.Properties.MinValue = 0;
            spinTOP.Properties.MaxValue = Int32.MaxValue;
            casDataSet.subtemp.Columns["group_"].DefaultValue = 1;

            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnDelete.Click += new EventHandler(tsbtnDelete_Click);
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            //grpTextBoxEx.SendKey(new KeyEventArgs(Keys.Enter));
        }

        void tsbtnDelete_Click(object sender, EventArgs e)
        {
            MasterTable.Rows[MasterBindingSource.Position].Delete();
            MasterBindingSource.EndEdit();
            MasterAdapter.Update(MasterTable);
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();
            if (aktifCheckBox.Checked)
            {
                //delete from sub temp and then insert into sub
                DataRow dr = casDataSet.sub.NewRow();
                MasterBindingSource.EndEdit();
                foreach (DataColumn col in MasterTable.Columns)
                {
                    if (col.ColumnName != "no")
                        dr[col.ColumnName] = MasterTable.Rows[MasterBindingSource.Position][col];
                }
                string query = "select MaxNo('sub','@grp')";
                query = query.Replace("@grp", MasterTable.Rows[MasterBindingSource.Position]["grp"].ToString());
                dr["sub"] = DB.sql.Select(query).Rows[0][0].ToString();
                casDataSet.sub.Rows.Add(dr);
                //subBindingSource.EndEdit();
                daSub.Update(casDataSet.sub);

                tsbtnDelete_Click(sender, new EventArgs());
                
                base.setMode(Mode.View);

            }
            else
                base.tsbtnSave_Click(sender, e);
        }

        private void FrmMasterSupplierTemp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'casDataSet.sub' table. You can move, or remove it, as needed.
            //this.subTableAdapter.Fill(this.casDataSet.sub);
            // TODO: This line of code loads data into the 'casDataSet.subtemp' table. You can move, or remove it, as needed.
            //this.subtempTableAdapter.Fill(this.casDataSet.subtemp);
            daSub = DB.sql.SelectAdapter("Select * from sub where group_=1");
        }
    }
}

