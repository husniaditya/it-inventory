using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using KASLibrary;
using DevExpress.XtraEditors;

namespace CAS.Master
{
    public partial class FrmUserLoc : Master.BaseMaster
    {
        MySqlDataAdapter daPeriod = DB.sql.SelectAdapter("select * from usrloc order by userid");

        public FrmUserLoc()
        { 
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridControlEx));
            InitializeComponent();
            gcPeriod.ExToolStrip.Items["tsbtnShow"].Visible = false;
            gcPeriod.ExToolStrip.Items["copyToolStripButton"].Visible = false;
            gcPeriod.ExToolStrip.Items["helpToolStripButton"].Visible = false;
            gcPeriod.ExToolStrip.Items["tsbtnNew"].Visible = false;
        //    gcPeriod.ExToolStrip.Items.Add(tsbtnSave);
            daPeriod.Fill(casDataSet.usrloc);
            gcPeriod.ExGridControl.DataSource = casDataSet.usrloc;
            gcPeriod.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
            gcPeriod.ExGridView.OptionsBehavior.Editable = true;
            gcPeriod.ExGridView.Columns["no"].VisibleIndex = 0;
            gcPeriod.ExGridView.Columns["no"].OptionsColumn.AllowEdit = false;
            gcPeriod.ExGridView.Columns["loc"].Width=300;
            gcPeriod.ExGridView.Columns["userid"].Visible  = false;
            gcPeriod.ExGridView.Columns["form"].Visible = false;
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
            tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            gcPeriod.ExGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(ExGridView_InitNewRow);
          
       
        }
        private void PopulatePerms()
        {
            daPeriod = DB.sql.SelectAdapter("select * from usrloc where userid='" + userTextEdit.EditValue + "'");
            casDataSet.usrloc.Clear();
            daPeriod.Fill(casDataSet.usrloc);
        }
        //void tsbtnCancel_Click(object sender, EventArgs e)
        //{
        //    gcPeriod.ExGridView.OptionsBehavior.Editable = true;
        //    gcPeriod.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
        //    gcPeriod.ExToolStrip.Items["tsbtnNew"].Enabled = gcPeriod.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
        //}
        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            gcPeriod.ExGridView.OptionsBehavior.Editable = true;
            gcPeriod.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;           
            gcPeriod.ExToolStrip.Items["tsbtnNew"].Enabled = gcPeriod.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
        }
        void tsbtnCancel_Click(object sender, EventArgs e)
        {
            casDataSet.usr.RejectChanges();
            casDataSet.usrloc.RejectChanges();
            gcPeriod.ExGridView.OptionsBehavior.Editable = false;
            gcPeriod.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            gcPeriod.ExToolStrip.Items["tsbtnNew"].Enabled = gcPeriod.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            tsbtnDelete.Enabled = false;
            tsbtnNew.Enabled = false;
            tsbtnEdit.Enabled = DB.casUser.AllowUpdate(this.Tag.ToString());
            tsbtnSave.Enabled = false;
            tsbtnCancel.Enabled = false;
            tsbtnPrint.Enabled = DB.casUser.AllowDelete(this.Tag.ToString());
           
        }
        void ExGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gcPeriod.ExGridView.SetFocusedRowCellValue(gcPeriod.ExGridView.Columns["userid"], userTextEdit.EditValue);
            gcPeriod.ExGridView.SetFocusedRowCellValue(gcPeriod.ExGridView.Columns["no"], DB.GetRowCount(casDataSet.usrloc) + 1);

     //       DataRow row = casDataSet.usrloc.NewRow();
            //string b = userTextEdit.EditValue.ToString();
            //try
            //{
            //    row["userid"] = b;
            //    row["loc"] = "";
            //    row["keterangan"] = "";
            //    row["form"] = "";
            //    //row["chtime"] = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            //    row["no"] = DB.GetRowCount(casDataSet.usrloc) + 1;
            //    casDataSet.usrloc.Rows.Add(row);
            //    //   DB.InsertDetailRows(gcPeriod.ExGridView, row);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        private void FrmMasterProsenBOP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'casDataSet.usr' table. You can move, or remove it, as needed.
         ///   this.usrTableAdapter.Fill(this.casDataSet.usr);
            // TODO: This line of code loads data into the 'casDataSet.usrloc' table. You can move, or remove it, as needed.
          //  this.usrlocTableAdapter.Fill(this.casDataSet.usrloc);
            // TODO: This line of code loads data into the 'casDataSet.prosenbop' table. You can move, or remove it, as needed.
            //this.prosenbopTableAdapter.Fill(this.casDataSet.prosenbop);
            // TODO: This line of code loads data into the 'casDataSet._close' table. You can move, or remove it, as needed.
            //this._closeTableAdapter.Fill(this.casDataSet._close);
            usrBindingSource.PositionChanged += new EventHandler(usrBindingSource_PositionChanged);
            PopulatePerms();
            gcPeriod.ExGridView.Columns["loc"].ColumnEdit = new GridLookUpEx(DB.sql, "select loc as `Lokasi`,left(name,45) as `Nama Lokasi` from loc ", "loc", "loc", gcPeriod.ExGridView, "", true, true, "Cost Center");
            gcPeriod.ExGridView.Columns["loc"].Caption = "Lokasi";
            gcPeriod.ExGridView.Columns["keterangan"].Caption = "Keterangan";
            gcPeriod.ExGridView.BestFitColumns();
            gcPeriod.ExGridView.Columns["loc"].Width = 70;
        }

        private void usrBindingSource_PositionChanged(object sender, EventArgs e)
        {
            PopulatePerms();            
        }
       
        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
             //   base.tsbtnSave_Click(sender, e);
                for (int i = casDataSet.usrloc.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = casDataSet.usrloc.Rows[i];
                    if (row != null && row.RowState != DataRowState.Deleted)
                    {
                        casDataSet.usrloc.Rows[i]["no"] = i+1;
                    }
                }
                usrlocBindingSource.EndEdit();
                daPeriod.Update(casDataSet.usrloc);
                gcPeriod.ExGridView.OptionsBehavior.Editable = false;
                gcPeriod.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                
                base.tsbtnRefresh_Click(sender, e);
                this.mode=Mode.View;
                gcPeriod.ExToolStrip.Items["tsbtnNew"].Enabled = gcPeriod.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                
                //  Refresh();
               tsbtnDelete.Enabled = false;
                tsbtnEdit.Enabled = DB.casUser.AllowUpdate(this.Tag.ToString());
                tsbtnSave.Enabled = false;
                tsbtnCancel.Enabled = false;
                tsbtnPrint.Enabled = DB.casUser.AllowDelete(this.Tag.ToString());
                
        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void ExGridView_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this item?", "Confirmation",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                DB.DeleteDetailRows2(gcPeriod.ExGridView);
            //    daPeriod.Update(casDataSet._close);
            }
           
        }
        

        
        
      }
}