using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using KASLibrary;

namespace CAS.Master
{   

    public partial class FrmMasterInv : CAS.Master.BaseMaster
    {
        private string modenya = "";
    //    private MySqlConnection conn;
        MySqlDataAdapter daKon = new MySqlDataAdapter();
        public FrmMasterInv()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlDetail, DB.sql);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click); 
            tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnDelete.Click += new EventHandler(tsbtnDelete_Click);
            
            gcKon.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(FrmMasterInv_Click);
            gcKon.ExGridView.OptionsSelection.MultiSelect = true;
            SetEditableGridControl(false);
        }

        private void FrmMasterInv_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'casDataSet.referensi_satuan' table. You can move, or remove it, as needed.
            //this.referensi_satuanTableAdapter.Fill(this.casDataSet.referensi_satuan);
            daKon = DB.sql.SelectAdapter("Select * from Konversi where inv = '" + invTextEdit.Text + "'");
            daKon.Fill(casDataSet.konversi);
            gcKon.ExGridControl.DataSource = konversiBindingSource;

            gcKon.ExGridView.Columns["unit"].ColumnEdit = new GridLookUpEx(DB.sql, "select KODE_SATUAN as Unit,URAIAN_SATUAN from tpbdb.referensi_satuan", "KODE_SATUAN", "KODE_SATUAN", gcKon.ExGridView, "", true, true, "Data Satuan");
            gcKon.ExGridView.Columns["unit"].ColumnEdit.Enter += new EventHandler(ExGridView_UnitColumnEdit_Enter);

            gcKon.ExTitleLabel.Visible = false;

            gcKon.ExToolStrip.Items["tsbtnNew"].Enabled = false;
            gcKon.ExGridView.OptionsBehavior.Editable = false;
            gcKon.ExGridView.Columns["inv"].Caption = "Kode Barang";
            gcKon.ExGridView.Columns["unit"].Caption = "Unit";
            gcKon.ExGridView.Columns["konversi"].Caption = "Konversi";
            gcKon.ExGridView.BestFitColumns();
        }

        void ExGridView_UnitColumnEdit_Enter(object sender, EventArgs e)
        {
            (gcKon.ExGridView.Columns["unit"].ColumnEdit as GridLookUpEx).Query = "select KODE_SATUAN as Unit,URAIAN_SATUAN from tpbdb.referensi_satuan";
        } 

        void SetEditableGridControl(bool mode)
        {
            gcKon.ExGridView.OptionsBehavior.Editable = mode;
            gcKon.ExToolStrip.Items["tsbtnDelete"].Enabled = mode;
        }

        void FrmMasterInv_Click(object sender, EventArgs e)
        {
            gcKon.ExGridView.DeleteSelectedRows();
        }

        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gcKon.ExGridView.GetDataRow(e.RowHandle);
            row["inv"] = invTextEdit.Text;
        }

        void tsbtnDelete_Click(object sender, EventArgs e)
        {
            if (gcKon.ExGridView.OptionsBehavior.Editable)
                SetEditableGridControl(false);
        }
        
        void tsbtnNew_Click(object sender, EventArgs e)
        {
            modenya = "new";
            SetEditableGridControl(true);
            konversiBindingSource.AllowNew = true;
            invTextEdit_EditValueChanged(sender, new EventArgs());
            gcKon.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gcKon.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);

            //open Jenis Dialog
            jenisTextBoxEx.SendKey(new KeyEventArgs(Keys.Enter));
            oldnameTextEdit.Text = nameTextEdit.Text;
            oldnameTextEdit1.Text = nameTextEdit.Text;

            
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            modenya = "edit";
            konversiBindingSource.AllowNew = true;
            SetEditableGridControl(true);
            gcKon.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gcKon.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);

        }
        void tsbtnCancel_Click(object sender, EventArgs e)
        {
            modenya = "cancel";
            if (gcKon.ExGridView.OptionsBehavior.Editable)
            {
                invTextEdit_EditValueChanged(sender, new EventArgs());
                SetEditableGridControl(false);
            }
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            String querynya = "";
            //MySqlCommand command;
            //conn = new MySqlConnection("server = 172.24.1.39; database= design ; userid=root; pwd=database");
            //conn.Open();

            //string modenya = "";
            //string querynya = "";
            //if (this.mode == Mode.New)
            //    modenya = "baru";
            //else
            //    modenya = "edit";

            this.ValidateChildren();

            if (gcKon.ExGridView.EditingValue != null)
                gcKon.ExGridView.SetFocusedValue(gcKon.ExGridView.EditingValue);

            // Check if Inv Number matches Jenis
            if (!invTextEdit.EditValue.ToString().StartsWith(jenisTextBoxEx.EditValue.ToString().Trim()))
            {
                MessageBox.Show("Inventory Number does not match Inventory Group (Jenis)");
                return;
            }

            //for new record, set group_=1
            //TODO: change group based on inventory type
            if (MasterBindingSource.Position == MasterTable.Rows.Count)
            {
                ((DataRowView)MasterBindingSource.Current).Row["group_"] = ((DataRowView)MasterBindingSource.Current).Row["inv"].ToString().Substring(0, 1);
            }
            ((DataRowView)MasterBindingSource.Current).Row["cct"] = "0";
          //  base.tsbtnSave_Click(sender, e);
            konversiBindingSource.EndEdit();
            daKon.Update(casDataSet.konversi);
            invTextEdit_EditValueChanged(sender, new EventArgs());

            String dbname2 = Utility.GetConfig("Database2");
            SetEditableGridControl(false);
            if (invTextEdit.EditValue.ToString().Substring(0, 2) != "10" && invTextEdit.EditValue.ToString().Substring(0, 2) != "91")
            {
                if (modenya == "new")
                {
                    querynya = "insert into " + dbname2 + ".referensi_kode_barang (KODE_BARANG,URAIAN_BARANG) values ('" + invTextEdit.EditValue.ToString().Trim() + "','" + nameTextEdit.EditValue.ToString().Trim() + "')";
                    DB.sql.Execute(querynya);
                }

                if (modenya == "edit")
                {
                    querynya = "update " + dbname2 + ".referensi_kode_barang set URAIAN_BARANG ='" + nameTextEdit.EditValue.ToString().Trim() + "' where KODE_BARANG = '" + invTextEdit.EditValue.ToString().Trim() + "'";
                    DB.sql.Execute(querynya);
                }
            }

            base.tsbtnSave_Click(sender, e);

            //if (invTextEdit.EditValue.ToString().StartsWith("2"))
            //{
            //    if (modenya == "baru")
            //    {
            //        querynya = "insert into mastermaterial (Location,MaterialCode,Description) values ('KIAS','" + invTextEdit.EditValue.ToString().Trim() + "','" + nameTextEdit.EditValue.ToString().Trim() + "')";
            //        command = new MySqlCommand(querynya, conn);
            //        command.ExecuteNonQuery();
            //    }
            //    //   DB.sql.Execute("insert into tabelnya (kodenya,materialnya) values ('" + invTextEdit.EditValue.ToString().Trim() + "','" + nameTextEdit.EditValue.ToString().Trim() + "')");
            //    if (modenya == "edit")
            //    {
            //        querynya = "update mastermaterial set Description ='" + nameTextEdit.EditValue.ToString().Trim() + "' where MaterialCode = '" + invTextEdit.EditValue.ToString().Trim() + "' and Location='KIAS'";
            //        command = new MySqlCommand(querynya, conn);
            //        command.ExecuteNonQuery();
            //    }
            //    //DB.sql.Execute("update tabelnya set materialnya ='" + nameTextEdit.EditValue.ToString().Trim() + "' where kodenya = '" + invTextEdit.EditValue.ToString().Trim() + "'");
            //}
            //conn.Close(); 
        }

        private void invTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            casDataSet.konversi.Clear();
            daKon = DB.sql.SelectAdapter("Select * from Konversi where inv='" + invTextEdit.Text + "'");
            daKon.Fill(casDataSet.konversi);
            gcKon.ExGridControl.DataSource = konversiBindingSource;
            gcKon.ExGridView.Columns["inv"].OptionsColumn.AllowEdit = false;
            gcKon.ExGridView.BestFitColumns();
        }

        private void jenisTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {
            //if new
            if (MasterBindingSource.Position == MasterTable.Rows.Count)
            {
                string query = "select MaxNo('inv','@jenis')";
                query = query.Replace("@jenis", jenisTextBoxEx.Text.Trim());
                invTextEdit.EditValue = DB.sql.Select(query).Rows[0][0].ToString();

                //string jenisQuery = "select * from jenis where jenis='@jenis'";
                //jenisQuery = jenisQuery.Replace("@jenis", jenisTextBoxEx.Text);
                //DataTable dtJenis = DB.sql.Select(jenisQuery);

                //accdiscTextBoxEx.EditValue = dtJenis.Rows[0]["accdisc"];
                //accrevTextBoxEx.EditValue = dtJenis.Rows[0]["accrev"];
                //accreturnTextBoxEx.EditValue = dtJenis.Rows[0]["accreturn"];
                //acchppTextBoxEx.EditValue = dtJenis.Rows[0]["acchpp"];

                DataRow drJenis = jenisTextBoxEx.ExGetDataRow();
                if (drJenis != null)
                {
                    accdiscTextBoxEx.EditValue = drJenis["Acc.Disc"];
                    accrevTextBoxEx.EditValue = drJenis["Acc.Rev"];
                    accreturnTextBoxEx.EditValue = drJenis["Acc.Return"];
                    acchppTextBoxEx.EditValue = drJenis["Acc.Hpp"];
                }

                nameTextEdit.Select();
            }
        }

        private void nameTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            /*
            oldnameTextEdit.Text = nameTextEdit.Text;
            oldnameTextEdit1.Text = nameTextEdit.Text;
            */
        }
 
       
    }
}

