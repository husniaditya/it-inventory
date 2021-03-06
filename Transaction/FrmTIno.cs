using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KASLibrary;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using MySql.Data.MySqlClient;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace CAS.Transaction
{
    public partial class FrmTIno : CAS.Transaction.BaseTransaction
    {
        MySqlDataAdapter inodAdapter;   
        public FrmTIno()
        {
            InitializeComponent();
            gcinc.ExGridControl.DataSource = inocBindingSource;
            gcind.ExGridControl.DataSource = inodBindingSource;
            
            MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);

            gcinc.ExGridView.OptionsView.ShowGroupPanel = false;
            gcind.ExGridView.OptionsView.ShowGroupPanel = false;
            gcinc.ExTitleLabel.Text = "Detail Kontrak";
            gcind.ExTitleLabel.Text = "";
            gcinc.ExGridView.OptionsCustomization.AllowSort = false;
            gcind.ExGridView.OptionsCustomization.AllowSort = false;
            //gcind.ExGridControl.Visible = true;


            gcinc.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
            gcinc.ExGridView.CellValueChanged += new CellValueChangedEventHandler(ExGridView_CellValueChanged);


            gcinc.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
            gcinc.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
            gcinc.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gcinc.ExToolStrip.Items["tsbtnNew"].Enabled = false;

            gcinc.ExGridView.Columns["ino"].OptionsColumn.AllowEdit = false;
            gcinc.ExGridView.Columns["sub"].OptionsColumn.AllowEdit = true;
            gcinc.ExGridView.Columns["val"].OptionsColumn.AllowEdit = true;
            gcinc.ExGridView.Columns["remark"].OptionsColumn.AllowEdit = true;
            gcinc.ExGridView.Columns["no"].Visible = false;
            gcinc.ExGridView.Columns["ino"].Visible = false;
            gcinc.ExGridView.Columns["sub"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('supplier')", "", "sub", gcinc.ExGridView, "", true, true, "Supplier");
            gcinc.ExGridView.Columns["val"].ColumnEdit = new GridNumEx(500);

            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);

            gcinc.ExGridView.Columns["sub"].Caption = "Kode Supplier";
            gcinc.ExGridView.Columns["remark"].Caption = "Keterangan";
            gcinc.ExGridView.Columns["no_kon"].Caption = "Nomor KOntrak";
            gcinc.ExGridView.Columns["tgl"].Caption = "Tanggal";
            gcinc.ExGridView.Columns["val"].Caption = "Total";

            gcinc.ExGridView.BestFitColumns();
            gcinc.ExGridView.Columns["val"].Width = 100;
            gcinc.ExGridView.Columns["remark"].Width = 300;
            gcinc.ExGridView.OptionsBehavior.Editable = false;
            gcinc.ExGridView.OptionsSelection.MultiSelect = true;
            gcinc.ExGridView.OptionsCustomization.AllowSort = false;

            gcinc.ExGridView.Columns["sub"].VisibleIndex = 0;
            gcinc.ExGridView.Columns["tgl"].VisibleIndex = 1;
            gcinc.ExGridView.Columns["no_kon"].VisibleIndex = 2;
            gcinc.ExGridView.Columns["remark"].VisibleIndex = 3;
            gcinc.ExGridView.Columns["val"].VisibleIndex = 4;
            gcind.ExGridView.Columns["ino"].Visible = false;
            gcind.ExGridView.Columns["no"].Visible = false;
            gcind.ExGridView.Columns["jurnal"].Caption = "Jurnal";
            gcind.ExGridView.Columns["date"].Caption = "Tanggal";
            gcind.ExGridView.Columns["acc"].Caption = "Kode Akun";
            gcind.ExGridView.Columns["rem"].Caption = "Keterangan";
            gcind.ExGridView.Columns["dk"].Caption = "D/K";
            gcind.ExGridView.Columns["val"].Caption = "Total";

            DB.SetNumberFormat(gcinc.ExGridView, "n2");
            Utility.SetNumberFormat(valproSpinEdit, "n2");
            Utility.SetNumberFormat(valSpinEdit, "n2");
            Utility.SetNumberFormat(spinEdit1, "n2");
            gcind.ExGridView.BestFitColumns();
        }

        private void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (MasterBindingSource.Position < 0)
                return;

            if (MasterBindingSource.Position >= MasterTable.Rows.Count) return;
            PopulateINOD();
            CalculateTotalINOD();
            ReCalculateTotal();

        }

        private void PopulateINOD()
        {
            try
            {
                bool newEntry = (MasterBindingSource.Position == MasterTable.Rows.Count);
                string query = "";

                casDataSet.inod.Clear();
                if (newEntry)
                    query = "select * from inod where 0";
                else
                    query = "call Sp_outino('" + NoDocument + "')";
                inodAdapter = DB.sql.SelectAdapter(query);
                inodAdapter.Fill(casDataSet.inod);
                gcind.ExGridView.BestFitColumns();
            }
            catch
            {

            }

        }

        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gcinc.ExGridView.GetDataRow(e.RowHandle);
            row["ino"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
            //row["no"] = DetailTable.Rows.Count + 1;
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            row["val"] = 0;
        }

        void ExGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
          ReCalculateTotal();
        }

        void ExGridView_New_Click(object sender, EventArgs e)
        {
            DataRow row = casDataSet.inoc.NewRow();
            row["ino"] = NoDocument;
            row["sub"] = "";
            row["remark"] = "";
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            casDataSet.inoc.Rows.Add(row);

            DB.InsertDetailRows(gcinc.ExGridView, row);
        }

        void CalculateTotalINOD()
        {
            try
            {
                inodBindingSource.EndEdit();

                double totalINOD = 0;
                for (int i = 0; i < casDataSet.inod.Rows.Count; i++)
                {
                    if (casDataSet.inod.Rows[i] != null && casDataSet.inod.Rows[i].RowState != DataRowState.Deleted)
                    {
                        if ((string)casDataSet.inod.Rows[i]["DK"] == "K")
                            totalINOD = totalINOD - (double)casDataSet.inod.Rows[i]["val"];
                        else
                            totalINOD = totalINOD + (double)casDataSet.inod.Rows[i]["val"];
                        if (casDataSet.inod.Rows[i]["dk"].ToString() == "") throw new Exception("No Jurnal pada Detail Kas salah");
                    }
                }
                spinEdit1.EditValue = totalINOD;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            DetailTable.Clear();
            gcinc.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcinc.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcinc.ExGridView.OptionsBehavior.Editable = true;
            gcinc.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            //Utility.SetReadOnly(txtSubtotal, true);
            //Utility.SetReadOnly(txtDisc, true);
            //Utility.SetReadOnly(txtPPN, true);
            //Utility.SetReadOnly(txtTotal, true);
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            gcinc.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcinc.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcinc.ExGridView.OptionsBehavior.Editable = true;
            gcinc.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            //Utility.SetReadOnly(txtSubtotal, true);
            //Utility.SetReadOnly(txtDisc, true);
            //Utility.SetReadOnly(txtPPN, true);
            //Utility.SetReadOnly(txtTotal, true);
        }

        private void FrmTIno_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'casDataSet.inod' table. You can move, or remove it, as needed.
         //   this.inodTableAdapter.Fill(this.casDataSet.inod);
            // TODO: This line of code loads data into the 'casDataSet.inoc' table. You can move, or remove it, as needed.
       //     this.inocTableAdapter.Fill(this.casDataSet.inoc);
            // TODO: This line of code loads data into the 'casDataSet.ino' table. You can move, or remove it, as needed.
         //   this.inoTableAdapter.Fill(this.casDataSet.ino);
            // TODO: This line of code loads data into the 'casDataSet.ino' table. You can move, or remove it, as needed.

            Utility.SetSqlInstance(pnlDetail, DB.sql);
            textBoxEx1.DataBindings.Add("EditValue", inoBindingSource, "cct");
            textBoxEx2.DataBindings.Add("EditValue", inoBindingSource,"acc");
            PopulateINOD();
            CalculateTotalINOD();
            //DataTable dtino = DB.sql.Select("call Sp_outino('" + NoDocument + "')");

            //foreach (DataRow inoRow in dtino.Rows)
            //{
            //    DataRow inodRow = casDataSet.inod.NewRow();
            //    foreach (DataColumn inodCol in casDataSet.inod.Columns)
            //    {
            //        inodRow[inodCol.ColumnName] = inoRow[inodCol.ColumnName];
            //    }
            //    inodRow["no"] = casDataSet.inod.Rows.Count + 1;
            //    casDataSet.inod.Rows.Add(inodRow);
            //}
            //gcind.ExGridView.BestFitColumns();
   
        }

        void ReCalculateTotal()
        {
            DetailBindingSource.EndEdit();

            double subTotal = 0;
            for (int i = 0; i < DetailTable.Rows.Count; i++)
            {
                if (DetailTable.Rows[i] != null && DetailTable.Rows[i].RowState != DataRowState.Deleted)
                {
                    subTotal = subTotal + (double)DetailTable.Rows[i]["val"];
                }
            }
            valSpinEdit.EditValue = subTotal;

        }

        void ExGridView_Delete_Click(object sender, EventArgs e)
        {
            DB.DeleteDetailRows(gcinc.ExGridView);
        }

        private void pronameTextEdit_EditValueChanged(object sender, EventArgs e)
        {
       
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string dobel = "tidak_ada";
                if (pronameTextEdit.EditValue.ToString() == "")
                    throw new Exception("Harap mengisi Nama Project");
                if (textBoxEx2.EditValue.ToString() == "")
                    throw new Exception("Harap mengisi Jenis Aktiva!");
               
                if (settleCheckBox.Checked == true)
                    {
                        //if (Math.Round(Convert.ToDecimal(valproSpinEdit.EditValue), 2) > Math.Round(Convert.ToDecimal(spinEdit1.EditValue), 2))
                        //{
                        //    settleCheckBox.Checked = false;
                        //    throw new Exception("Maaf Beribu Ribu Maaf Nilai Proyek Belum Terpenuhi, Tidak dapat diSettle!");

                            DataTable dt = DB.sql.Select("select akt from akt where akt ='" + aktTextEdit.EditValue.ToString() + "'");
                            if (dt.Rows.Count > 0)
                            {
                                dobel = "ada";
                                if (MessageBox.Show("Maaf Kode Aktiva Sudah Ada, Anda ingin Membuat Kode Baru ?",
                                         "Confirmation",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                         MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                                {
                                    aktTextEdit.Focus();
                                    return;
                                }
                            }
                        //}
                    }
                base.tsbtnSave_Click(sender, e);

                string date = ((DateTime)(dateDate.EditValue)).ToString("yyyyMMdd");
                DB.sql.Execute("Call SP_Save(" + date + ",'INO'" + ",'" + NoDocument + "')");

                            if (this.mode == Mode.View && settleCheckBox.Checked==true && dobel=="tidak_ada" && aktTextEdit.EditValue.ToString()!="")
                            {
                               string perintah="insert into akt (akt,name,harga,acc,tglbeli,tglstop,remark) " +
                                        "select akt,proname,"+Convert.ToDecimal(spinEdit1.EditValue)+" as val,acc,datez,'19000101'," +
                                        "'JL. RAYA SUKOMULYO KM. 24 KAV. 5, MANYAR - GRESIK ' as remark from ino where ino.ino='"+NoDocument+"'";
                              DB.sql.Execute(perintah);
                              MessageBox.Show("Data Sudah Terkirim di Master Aktiva");
                            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

