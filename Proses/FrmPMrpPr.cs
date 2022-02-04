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

namespace CAS.Proses
{
    public partial class FrmPMrpPr : XtraForm
    {
        private MySqlDataAdapter dtAdapter;
        private DataTable datatable1;
        int no = 0;
        public FrmPMrpPr()
        {
            InitializeComponent();
            txtInvAwal.ExSqlInstance = DB.sql ;
            txtInvAkhir.ExSqlInstance = DB.sql; 
            dtAdapter = DB.sql.SelectAdapter("Select * from mrppr where 0");
            this.lblTgl.Text = DateTime.Now.ToString("dd MMMM yyyy");
            dtAdapter.Fill(casDataSet.mrppr);
            //Bind the grid control to the data source
            gcxResult.ExGridControl.DataSource = mrpprBindingSource;

            gcxResult.ExTitleLabel.Text = "Create Purchase Request";
            gcxResult.ExGridView.Columns["notrac"].Caption = "Nomor Urut";
            gcxResult.ExGridView.Columns["notrac"].Visible = false;
            gcxResult.ExGridView.Columns["app"].Caption = "Approve";
            gcxResult.ExGridView.Columns["no_pr"].Caption = "Nomor Pr";
            gcxResult.ExGridView.Columns["no_pr"].Visible = false;
            gcxResult.ExGridView.Columns["tgl_proses"].Caption = "Tanggal";
            gcxResult.ExGridView.Columns["inv"].Caption = "Kode Material";
            gcxResult.ExGridView.Columns["invname"].Caption = "Remmark";
            gcxResult.ExGridView.Columns["loc"].Caption = "Location";
            gcxResult.ExGridView.Columns["qtymin"].Caption = "Qty minimum";
            gcxResult.ExGridView.Columns["qtynow"].Caption = "Qty Sekarang";
            gcxResult.ExGridView.Columns["prout"].Caption = "Outstanding PR";
            gcxResult.ExGridView.Columns["poout"].Caption = "Outstanding PO";
            gcxResult.ExGridView.Columns["lotsz"].Caption = "Lot Size";
            gcxResult.ExGridView.Columns["grpmat"].Caption = "Grup Material";
            gcxResult.ExGridView.Columns["leadtm"].Caption = "Lead Time";

            gcxResult.ExGridView.OptionsView.ShowGroupPanel = false;
            gcxResult.ExGridView.OptionsBehavior.Editable = true;
          //  gcxResult.ExGridView.Columns["app"].OptionsColumn.AllowEdit = true; 
            foreach (GridColumn col in gcxResult.ExGridView.Columns)
            {
                if (col.FieldName != "app")
                    col.OptionsColumn.AllowEdit = false;
            }
            gcxResult.ExGridView.BestFitColumns();
        }

        private void FrmPMrpPr_Load(object sender, EventArgs e)
        {
            try { Utility.ApplySkin(this); }
            catch { }
           
        }

        
        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                casDataSet.mrppr.Clear();
              //dtAdapter = DB.sql.SelectAdapter(BuildQuery());
              datatable1 = new DataTable();
              datatable1  = DB.sql.Select(BuildQuery());
              
              DataTable dtNoTrac;
              dtNoTrac = DB.sql.Select("Select ifnull(MAX(cast(notrac as decimal)),0) as notrac from mrppr");
              no = Convert.ToInt32(dtNoTrac.Rows[0][0].ToString())+1;

              for (int i = 0; i < datatable1.Rows.Count ; i++)
               {
                   DataRow rowmrppr = casDataSet.mrppr.NewRow();
                   rowmrppr["notrac"] = no;
                   rowmrppr["app"] =  Convert.ToUInt32(0);
                   rowmrppr["no_pr"] = " ";
                   rowmrppr["tgl_proses"] = DateTime.Now;
                   rowmrppr["inv"] = datatable1.Rows[i]["inv"];
                   rowmrppr["invname"] = datatable1.Rows[i]["name"];
                   rowmrppr["loc"] = datatable1.Rows[i]["loc"];
                   rowmrppr["qtymin"] = datatable1.Rows[i]["qtymin"];
                   rowmrppr["qtynow"] = datatable1.Rows[i]["qlast"];
                   rowmrppr["prout"] = datatable1.Rows[i]["outpr"];
                   rowmrppr["poout"] = datatable1.Rows[i]["outpo"];
                   rowmrppr["lotsz"] = datatable1.Rows[i]["lotsz"];
                   rowmrppr["grpmat"] = datatable1.Rows[i]["grpmat"];
                   rowmrppr["leadtm"] = datatable1.Rows[i]["leadtm"];
                   casDataSet.mrppr.Rows.Add(rowmrppr);
               }
                gcxResult.ExGridControl.DataSource = mrpprBindingSource;
            
                gcxResult.ExGridView.OptionsView.ShowGroupPanel = false;
                gcxResult.ExGridView.OptionsBehavior.Editable = true;
                //  gcxResult.ExGridView.Columns["app"].OptionsColumn.AllowEdit = true; 
                foreach (GridColumn col in gcxResult.ExGridView.Columns)
                {
                    if (col.FieldName != "app")
                        col.OptionsColumn.AllowEdit = false;
                }
                gcxResult.ExGridView.BestFitColumns();
                btnProses.Enabled = true;
           
            }
            catch(Exception ex)
            {
                gcxResult.ExGridControl.DataSource = null;
                gcxResult.ExGridView.PopulateColumns();
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

        private string BuildQuery()
        {
            string query = "call sp_createpr('" + txtInvAwal.Text + "','" + txtInvAkhir.Text+"')";
            return query;
        }

        private void btnProses_Click(object sender, EventArgs e)
        { 
            try
            {

              mrpprBindingSource.EndEdit();
              DataTable dtChanged = casDataSet.mrppr.GetChanges();
              dtAdapter.Update(casDataSet.mrppr);
              if (DB.sql.Execute("Call SP_Createpr1('" + DB.casUser.User + "'," + no + ")") == 1)
              {
                DataTable dtnopr;
                String nomornya = "";
                int i = 0;
                dtnopr = DB.sql.Select("Select distinct no_pr as nopr from mrppr where notrac ='"+ no +"' and no_pr <> ''");
                for (i = 0; i < dtnopr.Rows.Count; i++)
                {
                    nomornya = nomornya + " " + dtnopr.Rows[i][0].ToString();
                }
                MessageBox.Show("Generate Purchase reguest sukses dengan nomor : " + nomornya);
              }
              btnProses.Enabled = false;
            }

            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message);
            }          
        }

    }
}