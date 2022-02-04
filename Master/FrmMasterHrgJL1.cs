using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Text;
using System.Windows.Forms;
using KASLibrary;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace CAS.Master
{
    public partial class FrmMasterHrgJL1 : CAS.Master.BaseMaster
    {
        MySqlDataAdapter daSubto = new MySqlDataAdapter();
        public FrmMasterHrgJL1()
        {
            InitializeComponent();
         //   casDataSet.hrgjld.Columns.Add("unit", typeof(String));
          //  casDataSet.hrgjld.Columns.Add("unit1", typeof(String));
            ToolStripMenuItem tsmiPreviewHrg = new ToolStripMenuItem("Print Daftar Harga", null, new EventHandler(tsmiPreviewHrg_Click));
            ToolStripDropDownButton tsbtnPrint = new ToolStripDropDownButton("Print", null, tsmiPreviewHrg);
            tsbtnPrint.Image = MasterNavigator.Items["tsbtnPrint"].Image;
            MasterNavigator.Items.Insert(MasterNavigator.Items.IndexOfKey("tsbtnPrint"), tsbtnPrint);
            MasterNavigator.Items.RemoveByKey("tsbtnPrint");

            grphrgjlTextBoxEx.ExSqlInstance = DB.sql;
            textBoxEx1.ExSqlInstance = DB.sql;
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
            tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnDelete.Click += new EventHandler(tsbtnDelete_Click);
            gcsubto.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(FrmMasterHrgJL1_Click);
            
            gcsubto.ExGridView.OptionsSelection.MultiSelect = true;
            gcsubto.ExGridControl.DataSource = hrgjldBindingSource;
         //   gcsubto.ExGridView.Columns["harga1"].Visible = false;
            gcsubto.ExGridView.Columns["hrgjl"].OptionsColumn.AllowEdit = false;
            gcsubto.ExGridView.Columns["unit"].OptionsColumn.AllowEdit = false;
            gcsubto.ExGridView.CellValueChanged += new CellValueChangedEventHandler(ExGridView_CellValueChanged);
            gcsubto.ExGridView.Columns["hrgjl"].Caption = "Kode Group Customer";
            gcsubto.ExGridView.Columns["inv"].Caption = "Kode Barang";
            gcsubto.ExGridView.Columns["remark"].Caption = "Nama Barang";
            gcsubto.ExGridView.Columns["harga"].Caption = "Harga Satuan Kecil";
         //   gcsubto.ExGridView.Columns["unit1"].Caption = "UOM Besar";
          //  gcsubto.ExGridView.Columns["harga1"].Caption = "Harga Satuan Kecil";
            gcsubto.ExGridView.Columns["unit"].Caption = "UOM Kecil";
            gcsubto.ExGridView.Columns["harga"].ColumnEdit = new GridNumEx();
         //   gcsubto.ExGridView.Columns["harga1"].ColumnEdit = new GridNumEx();
            gcsubto.ExGridView.Columns["inv"].ColumnEdit = new GridLookUpEx(DB.sql, "", "inv", "inv", gcsubto.ExGridView, "", true, true, "Persediaan");
            gcsubto.ExGridView.Columns["inv"].ColumnEdit.Enter += new EventHandler(ExGridView_invColumnEdit_Enter);
            gcsubto.ExGridView.BestFitColumns();
            SetEditableGridControl(false);
            DB.SetNumberFormat(gcsubto.ExGridView, "n2");
        }

        void tsmiPreviewHrg_Click(object sender, EventArgs e)
        {
            if (aktifCheckBox.Checked)
            {
                string path = Application.StartupPath + "\\Reports\\" + "RepDaftarHargaJual" + ".repx";
                XtraReport report = new XtraReport();
                report.LoadState(path);
                report.DataSource = DB.sql.Select("call SP_Print('Master.FrmMasterHrgJL1','" + hrgjlTextEdit.Text + "')");

                string tanggal = "Periode: " + tglawalDateEdit.DateTime.ToString("dd/MM/yyyy") + " - " + tglakhirDateEdit.DateTime.ToString("dd/MM/yyyy");
                report.Bands[BandKind.ReportHeader].Controls["xrTanggal"].Text = tanggal;
                report.Bands[BandKind.PageFooter].Controls["xrLabelUser"].Text = DB.casUser.Name;
                report.ShowPreview();
            }
        }

        void ExGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
                if (e.Column.FieldName == "harga")
            {
                double price = (double)gcsubto.ExGridView.GetFocusedRowCellValue("harga");
                string tinv = (string)gcsubto.ExGridView.GetFocusedRowCellValue("inv");
                DataTable dta = DB.sql.Select("select konversi from konversi,inv where inv.inv=konversi.inv and inv.unit2=konversi.unit and inv.inv='" + tinv + "';");
                double val = price / (double)dta.Rows[0]["konversi"];
                gcsubto.ExGridView.SetFocusedRowCellValue(gcsubto.ExGridView.Columns["harga1"], Math.Round(val,2));

            }

        }

        void ExGridView_invColumnEdit_Enter(object sender, EventArgs e)
        {

            string query = "call sp_lookup('invpricelist');";
            ((GridLookUpEx)gcsubto.ExGridView.Columns["inv"].ColumnEdit).Query = query;

        }

        private void FrmMasterHrgJL1_Load(object sender, EventArgs e)
        {
           
            gcsubto.ExTitleLabel.Visible = false;
            gcsubto.ExToolStrip.Items["tsbtnNew"].Enabled = false;
            gcsubto.ExGridView.OptionsBehavior.Editable = false;
            hrgjlTextEdit_EditValueChanged(sender, new EventArgs());
            
        }
        
        void SetEditableGridControl(bool mode)
        {
            gcsubto.ExGridView.OptionsBehavior.Editable = mode;
            gcsubto.ExToolStrip.Items["tsbtnDelete"].Enabled = mode;
        }
        void FrmMasterHrgJL1_Click(object sender, EventArgs e)
        {
            gcsubto.ExGridView.DeleteSelectedRows();
        }

        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gcsubto.ExGridView.GetDataRow(e.RowHandle);
            row["hrgjl"] = hrgjlTextEdit.Text;
        }

        void tsbtnDelete_Click(object sender, EventArgs e)
        {
            if (gcsubto.ExGridView.OptionsBehavior.Editable)
                SetEditableGridControl(false);
        }
        
       
        void tsbtnNew_Click(object sender, EventArgs e)
        {
            SetEditableGridControl(true);
            //subTextEdit_EditValueChanged(sender, new EventArgs());
            gcsubto.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gcsubto.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
            tglawalDateEdit.EditValue = DB.loginDate;
            tglakhirDateEdit.EditValue = DB.loginDate;           
        }

        void tsbtnCancel_Click(object sender, EventArgs e)
        {
            if (gcsubto.ExGridView.OptionsBehavior.Editable)
            {
                casDataSet.hrgjld.RejectChanges();
                //subTextEdit_EditValueChanged(sender, new EventArgs());
                SetEditableGridControl(false);
                gcsubto.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            }
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();

            if (gcsubto.ExGridView.EditingValue != null)
                gcsubto.ExGridView.SetFocusedValue(gcsubto.ExGridView.EditingValue);                 
            base.tsbtnSave_Click(sender, e);
            hrgjldBindingSource.EndEdit();
            daSubto.Update(casDataSet.hrgjld);
            //subTextEdit_EditValueChanged(sender, new EventArgs());
            SetEditableGridControl(false);
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            hrgjldBindingSource.AllowNew = true;
            SetEditableGridControl(true);
            gcsubto.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gcsubto.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
        }

        

        private void hrgjlTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            casDataSet.hrgjld.Clear();
            daSubto = DB.sql.SelectAdapter("Select * from hrgjld where hrgjl='" + hrgjlTextEdit.Text + "'");
            daSubto.Fill(casDataSet.hrgjld);
            gcsubto.ExGridControl.DataSource = hrgjldBindingSource;
            gcsubto.ExGridView.Columns["hrgjl"].OptionsColumn.AllowEdit = false;
            gcsubto.ExGridView.BestFitColumns();

        }

        private void textBoxEx1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.mode != Mode.View)
            {
                casDataSet.hrgjld.Clear();
                DataTable dtHjlC = DB.sql.Select("select * from hrgjld where hrgjl='" + textBoxEx1.Text + "'");
                foreach (DataRow drHjlC in dtHjlC.Rows)
                {
                    DataRow drHjl = casDataSet.hrgjld.NewRow();
                    drHjl["hrgjl"] = hrgjlTextEdit.Text;
                    drHjl["inv"] = drHjlC["inv"];
                    drHjl["remark"] = drHjlC["remark"];
                    drHjl["harga"] = drHjlC["harga"]; 
                    drHjl["unit"] = drHjlC["unit"]; 
                    casDataSet.hrgjld.Rows.Add(drHjl);
                }
                gcsubto.ExGridControl.DataSource = hrgjldBindingSource;
            }
        }

        
    }
}

