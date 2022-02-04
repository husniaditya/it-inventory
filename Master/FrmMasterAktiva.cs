using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KASLibrary;
using MySql.Data.MySqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace CAS.Master
{
    public partial class FrmMasterAktiva : CAS.Master.BaseMaster
    {
       MySqlDataAdapter daAkd = new MySqlDataAdapter();
        public FrmMasterAktiva()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlDetail, DB.sql);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
            tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnDelete.Click += new EventHandler(tsbtnDelete_Click);
            gcakd.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(FrmMasterCustomer_Click);
            gcakd.ExGridView.OptionsSelection.MultiSelect = true;
            SetEditableGridControl(false);
        }

        void SetEditableGridControl(bool mode)
        {
            gcakd.ExGridView.OptionsBehavior.Editable = mode;
            gcakd.ExToolStrip.Items["tsbtnDelete"].Enabled = mode;
        }

        void FrmMasterCustomer_Click(object sender, EventArgs e)
        {
            gcakd.ExGridView.DeleteSelectedRows();
        }

        private void FrmMasterAktiva_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'casDataSet.akd' table. You can move, or remove it, as needed.
            //this.akdTableAdapter.Fill(this.casDataSet.akd);
            // TODO: This line of code loads data into the 'casDataSet.akt' table. You can move, or remove it, as needed.
          //  this.aktTableAdapter.Fill(this.casDataSet.akt);
            casDataSet.akd.Clear();
            daAkd = DB.sql.SelectAdapter("Select * from akd where akt='" + aktTextEdit.EditValue + "'");
            daAkd.Fill(casDataSet.akd);
            gcakd.ExGridControl.DataSource = akdBindingSource;
            gcakd.ExTitleLabel.Text = "Cost Center";
            gcakd.ExGridView.Columns["cct"].ColumnEdit = new GridLookUpEx(DB.sql, "select cct as `Cost Center`,left(name,45) as `Cost Center Name` from cct where detil=1", "cct", "cct", gcakd.ExGridView, "", true, true, "Cost Center");
            gcakd.ExGridView.Columns["akt"].Visible = false;
            gcakd.ExGridView.Columns["akt"].OptionsColumn.AllowEdit = false;
            gcakd.ExGridView.Columns["cct"].Caption = "Cost Center";
            gcakd.ExGridView.Columns["prosent"].Caption = "Prosen(%)";
            gcakd.ExGridView.Columns["remark"].Caption = "Cost Center Name";
            gcakd.ExGridView.BestFitColumns();
        }

        private void aktTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            casDataSet.akd.Clear();
            daAkd = DB.sql.SelectAdapter("Select * from akd where akt='" + aktTextEdit.EditValue + "'");
            daAkd.Fill(casDataSet.akd);
            gcakd.ExGridControl.DataSource = akdBindingSource;
          //  gcakd.ExGridView.Columns["akt"].OptionsColumn.AllowEdit = false;
          //  gcakd.ExGridView.BestFitColumns();
        }

        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gcakd.ExGridView.GetDataRow(e.RowHandle);
            row["akt"] = aktTextEdit.EditValue ;
        }

        void tsbtnDelete_Click(object sender, EventArgs e)
        {
            if (gcakd.ExGridView.OptionsBehavior.Editable)
                SetEditableGridControl(false);
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            akdBindingSource.AllowNew = true;
            SetEditableGridControl(true);
            gcakd.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gcakd.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            SetEditableGridControl(true);
            akdBindingSource.AllowNew = true;
            //subTextEdit_EditValueChanged(sender, new EventArgs());
            gcakd.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gcakd.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);

        }

        void tsbtnCancel_Click(object sender, EventArgs e)
        {
            if (gcakd.ExGridView.OptionsBehavior.Editable)
            {
                casDataSet.akd.RejectChanges();
                //subTextEdit_EditValueChanged(sender, new EventArgs());
                SetEditableGridControl(false);
                gcakd.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            }
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            ((DataRowView)MasterBindingSource.Current).Row["tglbeli"] = tglbeliDateTimePicker.Value;
            ((DataRowView)MasterBindingSource.Current).Row["tgljual"] = tgljualDateTimePicker.Value;
            ((DataRowView)MasterBindingSource.Current).Row["tglstop"] = tglstopDateTimePicker.Value;
            this.ValidateChildren();

            if (gcakd.ExGridView.EditingValue != null)
                gcakd.ExGridView.SetFocusedValue(gcakd.ExGridView.EditingValue);
           
            akdBindingSource.EndEdit();
            daAkd.Update(casDataSet.akd);

            base.tsbtnSave_Click(sender, e);
            
           // akdBindingSource.EndEdit();
           // daAkd.Update(casDataSet.akd);
            //subTextEdit_EditValueChanged(sender, new EventArgs());
            SetEditableGridControl(false);
        }

        private void prosentaseSpinEdit_EditValueChanged(object sender, EventArgs e)
        {
            double prosen = (1200/Convert.ToDouble(prosentaseSpinEdit.EditValue));
            int masa = Convert.ToInt16(prosen);
            tglstopDateTimePicker.Value = Utility.FirstDateInMonth(tglbeliDateTimePicker.Value.AddMonths(masa));
        }
    }
}

