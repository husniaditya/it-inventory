using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using MySql.Data.MySqlClient;
using KASLibrary;

namespace CAS.Master
{
    public partial class FrmMasterNoPajak : CAS.Master.BaseMaster
    {
        MySqlDataAdapter dapjkd = new MySqlDataAdapter();
        public FrmMasterNoPajak()
        {
            InitializeComponent();
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
            tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnDelete.Click += new EventHandler(tsbtnDelete_Click);
            gcpjk.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(FrmMasterCustomer_Click);
            gcpjk.ExGridView.OptionsSelection.MultiSelect = true;
            no_pjkdBindingSource.AllowNew = true;
            SetEditableGridControl(true);
            gcpjk.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gcpjk.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
        }

        void FrmMasterCustomer_Click(object sender, EventArgs e)
        {
            gcpjk.ExGridView.DeleteSelectedRows();
        }

        void SetEditableGridControl(bool mode)
        {
            gcpjk.ExGridView.OptionsBehavior.Editable = mode;
            gcpjk.ExToolStrip.Items["tsbtnDelete"].Enabled = mode;
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            no_pjkdBindingSource.AllowNew = true;
            SetEditableGridControl(true);
            gcpjk.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gcpjk.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
        }

        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gcpjk.ExGridView.GetDataRow(e.RowHandle);
            row["no_sk"] = txtNoSk.Text;
            row["tgl"] = dtpTgl.Value;
            row["no"] = gcpjk.ExGridView.RowCount;
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            no_pjkdBindingSource.AllowNew = true;
            SetEditableGridControl(true);
            //subTextEdit_EditValueChanged(sender, new EventArgs());
            gcpjk.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom ;
            gcpjk.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);

        }
        void tsbtnCancel_Click(object sender, EventArgs e)
        {
            if (gcpjk.ExGridView.OptionsBehavior.Editable)
            {
                casDataSet.no_pjkd.RejectChanges();
                //subTextEdit_EditValueChanged(sender, new EventArgs());
                SetEditableGridControl(false);
                gcpjk.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            }
        }
        private void FrmMasterNoPajak_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'casDataSet.no_pjkd' table. You can move, or remove it, as needed.
            //   this.no_pjkdTableAdapter.Fill(this.casDataSet.no_pjkd);
            // TODO: This line of code loads data into the 'casDataSet.no_pjk' table. You can move, or remove it, as needed.
            //  this.no_pjkTableAdapter.Fill(this.casDataSet.no_pjk);
            casDataSet.no_pjkd.Clear();
            dapjkd = DB.sql.SelectAdapter("Select * from no_pjkd where no_sk='" + txtNoSk.Text + "'");
            dapjkd.Fill(casDataSet.no_pjkd);
            gcpjk.ExGridControl.DataSource = no_pjkdBindingSource;
            gcpjk.ExTitleLabel.Text = "Pembagian Nomor";
            gcpjk.ExGridView.Columns["sub"].ColumnEdit = new GridLookUpEx(DB.sql, "select sub as `Kode Customer`,left(name,45) as `Customer Name` from sub where group_=2 and aktif=1 union all select '00000' as sub, 'Lainnya' as subname", "sub", "sub", gcpjk.ExGridView, "", true, true, "Customer");
            gcpjk.ExGridView.Columns["no_sk"].Visible = false;
            gcpjk.ExGridView.Columns["no"].Visible = false;
            gcpjk.ExGridView.Columns["aktif"].OptionsColumn.AllowEdit = true;
            gcpjk.ExGridView.Columns["sub"].Caption = "Kode Customer";
            gcpjk.ExGridView.Columns["remark"].Caption = "Customer Name";
            gcpjk.ExGridView.Columns["no_awal"].Caption = "No Awal";
            gcpjk.ExGridView.Columns["no_akhir"].Caption = "No AKhir";

            gcpjk.ExGridView.BestFitColumns();
            this.dtpTgl.Value = DB.loginDate;
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();
            if (mode == Mode.New)
                ((DataRowView)MasterBindingSource.Current).Row["aktif"] = '0';
            no_pjkdBindingSource.EndEdit();
            dapjkd.Update(casDataSet.no_pjkd);
            //subTextEdit_EditValueChanged(sender, new EventArgs());
            SetEditableGridControl(false);


            base.tsbtnSave_Click(sender, e);

            //      refreshgrid(); 
        }

        private void refreshgrid()
        {
            //gcPajak.DataSource = DB.sql.Select("select * from no_pjkd"); 
            //gcPajak.Refresh();  
        }

     
        private void txtNoSk_TextChanged(object sender, EventArgs e)
        {

            casDataSet.no_pjkd.Clear();
            dapjkd = DB.sql.SelectAdapter("Select * from no_pjkd where no_sk='" + txtNoSk.Text + "'");
            dapjkd.Fill(casDataSet.no_pjkd);
            gcpjk.ExGridControl.DataSource = no_pjkdBindingSource;

        }

     

    }
}

