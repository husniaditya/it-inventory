using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Menu;
using DevExpress.Utils.Menu;
using System.Collections;
using DevExpress.XtraGrid.Views.Grid;
using MySql.Data.MySqlClient;
using System.Reflection;
using KASLibrary;
using DevExpress.XtraEditors;

namespace CAS.Master
{
    public partial class FrmMasterInvFlow : XtraForm
      {
        string fileName = Application.StartupPath + "\\XtraGrid_SaveLayoutToXML.xml";
        private GridColumn selectedCol;
        private DataTable dtTransaction;
        DataTable dt;
        public FrmMasterInvFlow()
        {
            InitializeComponent();
            
            dtpTglAwal.DateTime = Utility.FirstDateInMonth(DB.loginDate);
            dtpTglAkhir.DateTime = Utility.LastDateInMonth(DB.loginDate);

          //  dt = DB.sql.Select("call Sp_ArusInventory (" + dtpTglAwal.DateTime.ToString("yyyyMMdd") + "," + dtpTglAkhir.DateTime.ToString("yyyyMMdd") + ")");
            dt = DB.sql.Select("select ''");
            gcHJL.DataSource = dt;
            gcHJL.MouseDown += new MouseEventHandler(ExGridView_MouseDown);
       }


        private void FrmMasterInvFlow_Load(object sender, EventArgs e)
        {
            gridView2.BestFitColumns();
            gcHJL.ForceInitialize();
            gcHJL.MainView.RestoreLayoutFromXml(fileName);
            gcHJL.Refresh(); 
        }


        private void dtpTglAwal_EditValueChanged(object sender, EventArgs e)
        {
            //dtpTglAwal.DateTime = Utility.FirstDateInMonth(DB.loginDate);
            //dtpTglAkhir.DateTime = Utility.LastDateInMonth(DB.loginDate);

            // 2 baris bawah di pindah ke button update grid
            //dt = DB.sql.Select("call Sp_ArusInventory (" + dtpTglAwal.DateTime.ToString("yyyyMMdd") + "," + dtpTglAkhir.DateTime.ToString("yyyyMMdd") + ")");
            //gcHJL.DataSource = dt;

       //     gcHJL.MouseDown += new MouseEventHandler(ExGridView_MouseDown);
        }

        private void dtpTglAkhir_EditValueChanged(object sender, EventArgs e)
        {
            //dtpTglAwal.DateTime = Utility.FirstDateInMonth(DB.loginDate);
            //dtpTglAkhir.DateTime = Utility.LastDateInMonth(DB.loginDate);
            
            // 2 baris bawah di pindah ke button update grid
            //dt = DB.sql.Select("call Sp_ArusInventory (" + dtpTglAwal.DateTime.ToString("yyyyMMdd") + "," + dtpTglAkhir.DateTime.ToString("yyyyMMdd") + ")");
            //gcHJL.DataSource = dt;
        }

          private void button1_Click(object sender, EventArgs e)
        {
            gcHJL.ShowPrintPreview();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            savFile.FileName = "";
            savFile.Filter = "Excel File|*.xls";
            if (savFile.ShowDialog() == DialogResult.OK)
            {
                string fileName = savFile.FileName;
                if (fileName.EndsWith("xls"))
                {
                    gcHJL.ExportToExcel(fileName);
                }
            }
        }

        public Form CreateForm(string formName)
        {
            Type frmType = Assembly.GetExecutingAssembly().GetType(formName);

            if (frmType != null)
                return (Form)Activator.CreateInstance(frmType);
            else
                return null;
        }

        void ExGridView_MouseDown(object sender, MouseEventArgs e)
        {
            // obtaining hit info
            GridHitInfo hitInfo = gridView2.CalcHitInfo(new Point(e.X, e.Y));
            selectedCol = hitInfo.Column;

            if (e.Button == MouseButtons.Left && e.Clicks == 2 && (hitInfo.InRow) && (!gridView2.IsGroupRow(hitInfo.RowHandle)))
            {
                // switching focus
                gridView2.FocusedRowHandle = hitInfo.RowHandle;

                string noJurnal = gridView2.GetFocusedDisplayText();
                if (noJurnal.IndexOf("-") < 0) return;

                DataTable dtMenu = DB.sql.Select("select m.menuid, m.formname from menuid m, modul d where m.menuid=d.menuid and noseri='" + noJurnal.Substring(0, 3) + "'");

                if (dtMenu.Rows.Count == 1)
                {
                    string formName = "CAS." + dtMenu.Rows[0]["formname"].ToString();
                    Form newForm = CreateForm(formName);

                    if (newForm == null) return;

                    newForm.Name = dtMenu.Rows[0]["formname"].ToString();
                    newForm.Tag = dtMenu.Rows[0]["menuid"].ToString();
                    newForm.MdiParent = this.MdiParent;

                    if (formName.Contains("Transaction"))
                        ((Transaction.BaseTransaction)newForm).NoJurnal = noJurnal;
                    else if (formName.Contains("Master"))
                        ((Master.BaseMaster)newForm).NoKode = noJurnal;

                    newForm.Show();
                }
            }
        }

        private void btnUpdateGrid_Click(object sender, EventArgs e)
        {
            if (jenisRadioGroup.EditValue.ToString() == "0")
                dt = DB.sql.Select("call Sp_ArusInventory (" + dtpTglAwal.DateTime.ToString("yyyyMMdd") + "," + dtpTglAkhir.DateTime.ToString("yyyyMMdd") + ")");
            else
                dt = DB.sql.Select("call Sp_ArusInventoryP (" + dtpTglAwal.DateTime.ToString("yyyyMMdd") + "," + dtpTglAkhir.DateTime.ToString("yyyyMMdd") + ")");
            gcHJL.DataSource = dt;
        }

        private void FrmMasterInvFlow_Load_1(object sender, EventArgs e)
        {

        }

        private void FrmMasterInvFlow_FormClosing(object sender, FormClosingEventArgs e)
        {
            gcHJL.MainView.SaveLayoutToXml(fileName);
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
    }
}