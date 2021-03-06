using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using KASLibrary;
using DevExpress.XtraEditors.Repository;
using MySql.Data.MySqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace CAS.Transaction
{  
    public partial class FrmTCsi : CAS.Transaction.BaseTransaction
    {
        MySqlDataAdapter csaAdapter,cslAdapter,csbAdapter,omdAdapter;
        public FrmTCsi()
        {
            InitializeComponent();
            omsTextBoxEx.ExSqlInstance = DB.sql;
            omsTextBoxEx.ExSqlQuery = "select distinct oms,'' reff,name,date,remark from ( " +
            " select lph.oms,sub.name,oms.date,oms.remark,lph.lph,csl.lph as lphcsi from lph left outer join csl on lph.lph=csl.lph" +
            " inner join (select oms.oms,oms.sub,oms.date,oms.remark from oms where `delete`=0 and group_=1) oms on lph.oms=oms.oms" +
            " left outer join sub on oms.sub=sub.sub where lph.oms<>'' and lph.`delete`=0 and lph.date > adddate(now(),-300)" +
            " ) as x where lphcsi is null";
            //omsTextBoxEx.ExSqlQuery = "select oms,name,oms.date from oms left outer join sub on oms.sub=sub.sub where oms.`delete`=0 and oms.group_=1 and oms.`close`=0";
            MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);

            //tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            //tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);

            //csa invoice
            gccsa.ExGridControl.DataSource = csaBindingSource;
            gccsa.ExGridView.Columns["invo"].ColumnEdit = new GridLookUpEx(DB.sql, "select invo as `No. Invoice`,'' as Reff, remark as `Keterangan`,val as `Nilai Invoice` from msd where 0", "invo", "invo", gccsa.ExGridView, "", true, true, "Invoice");
            gccsa.ExGridView.Columns["invo"].ColumnEdit.Enter += new EventHandler(ExGridView_invoColumnEdit_Enter);
            gccsa.ExGridView.Columns["invo"].OptionsColumn.AllowEdit = false;
            gccsa.ExGridView.Columns["reff"].ColumnEdit = new GridLookUpEx(DB.sql, "select invo as `No. Invoice`,'' as `No. Reference`,'' as remark as `Keterangan`,val as `Nilai Invoice` from msd where 0", "invo", "invo", gccsa.ExGridView, "", true, true, "Invoice");
            gccsa.ExGridView.Columns["reff"].ColumnEdit.Enter += new EventHandler(ExGridView_reffColumnEdit_Enter);
            gccsa.ExGridView.Columns["reff"].OptionsColumn.AllowEdit = true;
            gccsa.ExGridView.Columns["csi"].Visible = gccsa.ExGridView.Columns["no"].Visible = false;
            gccsa.ExGridView.Columns["invo"].Caption = "No. Invoice";
            gccsa.ExGridView.Columns["reff"].Caption = "No. Reference";
            gccsa.ExGridView.Columns["remark"].Caption = "Keterangan";
            gccsa.ExGridView.Columns["val"].Caption = "Nilai Invoice";

            gccsa.ExGridView.Columns["invo"].VisibleIndex = 1;
            gccsa.ExGridView.Columns["reff"].VisibleIndex = 2;
            gccsa.ExGridView.Columns["remark"].VisibleIndex = 3;
            gccsa.ExGridView.Columns["remark"].VisibleIndex = 4;
            gccsa.ExGridView.Columns["val"].VisibleIndex = 5;

            gccsa.ExGridView.OptionsBehavior.Editable = false;
            gccsa.ExGridView.OptionsSelection.MultiSelect = true;
            gccsa.ExGridView.OptionsCustomization.AllowSort = false;
            gccsa.ExGridView.OptionsView.ShowGroupPanel = false;
         
            //csl penerimaan barang
            gccsl.ExGridControl.DataSource = cslBindingSource;
            string queri = "select lph.lph as `No. LPB`, lph.date,lpd.inv,left(lph.remark,50) as `Keterangan`,0 as `val` from lph left outer join lpd on lph.lph=lpd.lph where lph.`delete`=false";     
             gccsl.ExGridView.Columns["lph"].ColumnEdit = new GridLookUpEx(DB.sql, queri, "lph", "lph", gccsl.ExGridView, "", true, true, "LPH");
            gccsl.ExGridView.Columns["lph"].ColumnEdit.Enter += new EventHandler(ExGridView_lphColumnEdit_Enter);
            gccsl.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(gccsl_tsbtnDelete_Click);
            gccsl.ExGridView.Columns["csi"].Visible = gccsl.ExGridView.Columns["no"].Visible = false;
                   
            gccsl.ExGridView.Columns["lph"].Caption = "No. LPB";
            gccsl.ExGridView.Columns["qty"].Caption = "QtyBase";
            gccsl.ExGridView.Columns["qty1"].Caption = "QtyLpb";
            gccsl.ExGridView.Columns["unit"].Caption = "Unit";
            gccsl.ExGridView.Columns["inv"].Caption = "inv";
            gccsl.ExGridView.Columns["remark"].Caption = "Keterangan";
            gccsl.ExGridView.OptionsBehavior.Editable = false;
            gccsl.ExGridView.OptionsSelection.MultiSelect = true;
            gccsl.ExGridView.OptionsCustomization.AllowSort = false;
            gccsl.ExGridView.OptionsView.ShowGroupPanel = false;
            
            gccsl.ExGridView.Columns["lph"].VisibleIndex = 1;
            gccsl.ExGridView.Columns["date"].VisibleIndex = 2;
            gccsl.ExGridView.Columns["inv"].VisibleIndex = 3;
            gccsl.ExGridView.Columns["remark"].VisibleIndex = 4;
            gccsl.ExGridView.Columns["qty1"].VisibleIndex = 5;
            gccsl.ExGridView.Columns["unit"].VisibleIndex = 6;
            gccsl.ExGridView.Columns["qty"].VisibleIndex = 7;
            gccsl.ExGridView.Columns["price"].VisibleIndex = 8;
            gccsl.ExGridView.BestFitColumns();
            
            //csb
           //  gccsl.ExGridView.Columns["prq"].Visible = gccsl.ExGridView.Columns["noprd"].Visible = gccsl.ExGridView.Columns["loc"].Visible = false;
           //  gccsl.ExGridView.Columns["cct"].Visible = gccsl.ExGridView.Columns["acc"].Visible = gccsl.ExGridView.Columns["qty"].Visible = false;
            // gccsl.ExGridView.Columns["no"].Visible = gccsl.ExGridView.Columns["etd"].Visible = gccsl.ExGridView.Columns["toleransi"].Visible = false;

            gccsb.ExGridControl.DataSource = csbBindingSource;
            gccsb.ExGridView.Columns["csi"].Visible = gccsb.ExGridView.Columns["no"].Visible = false;
          //  gccsb.ExGridView.OptionsBehavior.Editable = false;
          //  gccsb.ExGridView.OptionsSelection.MultiSelect = true;
          //  gccsb.ExGridView.OptionsCustomization.AllowSort = false;
        //    gccsb.ExGridView.OptionsView.ShowGroupPanel = false;
            gccsb.ExGridView.Columns["date"].Caption = "Tanggal";
            gccsb.ExGridView.Columns["invo"].Caption = "No. Reference";
            gccsb.ExGridView.Columns["remark"].Caption = "Keterangan";
            gccsb.ExGridView.Columns["val"].Caption = "Nilai Invoice";
            gccsb.ExGridView.Columns["mby"].Caption = "kode_by";           
            gccsb.ExGridView.Columns["mby"].ColumnEdit = new GridLookUpEx(DB.sql, "select * from mby", "mby", "mby", gccsb.ExGridView, "", false, false, "MBY");
            gccsb.ExGridView.Columns["mby"].ColumnEdit.Enter += new EventHandler(ExGridView_mbyColumnEdit_Enter);
            gccsb.ExGridView.Columns["invo"].Caption = "No. Reference";
            gccsb.ExGridView.Columns["invo"].ColumnEdit = new GridLookUpEx(DB.sql, "select * from csb where 0", "csb", "invo", gccsb.ExGridView, "", true, true, "Perjalanan");
            gccsb.ExGridView.Columns["invo"].ColumnEdit.Enter += new EventHandler(ExGridView_invoiceColumnEdit_Enter);

            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
            gccsa.ExGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(gccsa_InitNewRow);
            gccsl.ExGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(gccsl_InitNewRow);
            gccsb.ExGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(gccsb_InitNewRow);

            gccsa.ExGridView.BestFitColumns();
            DB.SetNumberFormat(gccsa.ExGridView, "n2");

            gccsb.ExGridView.BestFitColumns();
            DB.SetNumberFormat(gccsb.ExGridView, "n2");    
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            gccsa.ExGridView.OptionsBehavior.Editable = true;
            gccsa.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

            gccsl.ExGridView.OptionsBehavior.Editable = true;
            gccsl.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

            gccsb.ExGridView.OptionsBehavior.Editable = true;
            gccsb.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

            SetMode(Mode.Edit);
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            gccsa.ExGridView.OptionsBehavior.Editable = true;
            gccsa.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

            gccsl.ExGridView.OptionsBehavior.Editable = true;
            gccsl.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

            gccsb.ExGridView.OptionsBehavior.Editable = true;
            gccsb.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

            SetMode(Mode.Edit);
        }

        void gccsa_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gccsa.ExGridView.GetDataRow(e.RowHandle);
            row["csi"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
            row["no"] = gccsa.ExGridView.RowCount;
            row["val"] = 0;
        }
        void gccsl_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gccsl.ExGridView.GetDataRow(e.RowHandle);
            row["csi"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
            row["no"] = gccsl.ExGridView.RowCount;
            row["val"] = 0;
        }
        void gccsb_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gccsb.ExGridView.GetDataRow(e.RowHandle);
            row["csi"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
            row["no"] = gccsb.ExGridView.RowCount;
            row["val"] = 0;
        }
        private void SetMode(Mode mode)
        {
            gccsa.ExToolStrip.Items["tsbtnDelete"].Enabled = (mode == Mode.Edit) ? true : false;
            gccsa.ExToolStrip.Items["tsbtnNew"].Enabled = (mode == Mode.Edit) ? true : false;
            gccsl.ExToolStrip.Items["tsbtnDelete"].Enabled = (mode == Mode.Edit) ? true : false;
            gccsl.ExToolStrip.Items["tsbtnNew"].Enabled = (mode == Mode.Edit) ? true : false;
            gccsb.ExToolStrip.Items["tsbtnDelete"].Enabled = (mode == Mode.Edit) ? true : false;
            gccsb.ExToolStrip.Items["tsbtnNew"].Enabled = (mode == Mode.Edit) ? true : false;
        }
        private void FrmTCsi_Load(object sender, EventArgs e)
        {
            PopulateDetails();
            Utility.SetNumberFormat(paneltotal, "n2");
            gccsa.ExGridView.BestFitColumns();
            DB.SetNumberFormat(gccsa.ExGridView, "n2");
            gccsb.ExGridView.BestFitColumns();
            DB.SetNumberFormat(gccsb.ExGridView, "n2");
            ReCalculateTotal();
        }

        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            PopulateDetails();
            ReCalculateTotal();
        }

        private void PopulateDetails()
        {
            try
            {
                bool newEntry = (MasterBindingSource.Position == MasterTable.Rows.Count);
                string query = "";

                // csa 
                casDataSet.csa.Clear();
                if (newEntry)
                    query = "select * from csa where 0";
                else
                    query = "select * from csa where csi='" + MasterTable.Rows[MasterBindingSource.Position][0].ToString() + "'";
                csaAdapter = DB.sql.SelectAdapter(query);
                csaAdapter.Fill(casDataSet.csa);
                gccsa.ExGridView.BestFitColumns();

                // csl
                casDataSet.csl.Clear();
                if (newEntry)
                    query = "select * from csl where 0";
                else
                    query = "select * from csl where csi='" + MasterTable.Rows[MasterBindingSource.Position][0].ToString() + "'";
                cslAdapter = DB.sql.SelectAdapter(query);
                cslAdapter.Fill(casDataSet.csl);
                gccsl.ExGridView.BestFitColumns();
                //query = "select no,omd.oms,omd.inv,omd.remark,omd.qty1,omd.unit,omd.price*oms.kurs as price,omd.val*oms.kurs as val,omd.dateneed from omd,oms where omd.oms=oms.oms and omd.oms='" + omsTextBoxEx.EditValue.ToString() + "'";
                //omdAdapter = DB.sql.SelectAdapter(query);
                //omdAdapter.Fill(casDataSet.omd);
                //gccsl.ExGridView.BestFitColumns();
                
                //DataTable dtOmd = DB.sql.Select("select * from omd where oms='" + drMsl["lph"] + "'");
                //    foreach (DataRow drLpd in dtLpd.Rows)
                //        casDataSet.lpd.ImportRow(drLpd);
                
                //gcxLpd.ExGridControl.DataSource = casDataSet.lpd;
                
                // csb
                casDataSet.csb.Clear();
                if (newEntry)
                    query = "select * from csb where 0";
                else
                    query = "select * from csb where csi='" + MasterTable.Rows[MasterBindingSource.Position][0].ToString() + "'";
                csbAdapter = DB.sql.SelectAdapter(query);
                csbAdapter.Fill(casDataSet.csb);
                gccsb.ExGridView.BestFitColumns();
                gccsa.ExGridView.BestFitColumns();
                DB.SetNumberFormat(gccsa.ExGridView, "n2");

                gccsb.ExGridView.BestFitColumns();
                DB.SetNumberFormat(gccsb.ExGridView, "n2");

            }
            catch (Exception ex)
            {
                //remarked: caused by an Open DataReader error
                //MessageBox.Show(ex.Message);
            }
        }

      
        void ExGridView_invoColumnEdit_Enter(object sender, EventArgs e)
        {
            string query = "select invo as `No. Invoice`,msd.remark as `Keterangan`,msd.val*msd.kurs as `Nilai Invoice` from msd left outer join msk on msd.msk=msk.msk where msd.oms='" + omsTextBoxEx.Text + "' and msd.invo not in "+
                "(select invo from csa left outer join csi on csa.csi=csi.csi where  csi.oms='" + omsTextBoxEx.Text + "' and csi.delete=0)";
            ((GridLookUpEx)gccsa.ExGridView.Columns["invo"].ColumnEdit).Query = query;
        }

        void ExGridView_reffColumnEdit_Enter(object sender, EventArgs e)
        {
            string query = "call sp_CSIreff ('" + omsTextBoxEx.Text + "'," + dateDate.DateTime.ToString("yyyyMMdd")  +")";
            ((GridLookUpEx)gccsa.ExGridView.Columns["reff"].ColumnEdit).Query = query;
        }

        void ExGridView_mbyColumnEdit_Enter(object sender, EventArgs e)
        {
            string query = "select * from mby";
            ((GridLookUpEx)gccsb.ExGridView.Columns["mby"].ColumnEdit).Query = query;
        }

        void ExGridView_invoiceColumnEdit_Enter(object sender, EventArgs e)
        {
            string query = "call sp_CSIreff ('" + omsTextBoxEx.Text + "'," + dateDate.DateTime.ToString("yyyyMMdd") + ")";
            ((GridLookUpEx)gccsb.ExGridView.Columns["invo"].ColumnEdit).Query = query;
      
        }

        void ExGridView_lphColumnEdit_Enter(object sender, EventArgs e)
        {
            //  string query = "select lph as `No. LPB`,(select sum(qty) from lpd where lpd.lph=lph.lph) as qty, lph.date,remark as `Keterangan`,val as `Nilai LPB` from lph where oms='"+omsTextBoxEx.Text+"'";
            string query = "select lph.lph as `No. LPB`,qty1 as QtyLpb, lph.date,lpd.inv,left(lph.remark,50) as `Keterangan`,lpd.qty as `QtyBase`,lpd.unit as Unit,((select oms_in.price*oms.kurs from oms_in left outer join oms on oms_in.oms=oms.oms where oms_in.oms='" + omsTextBoxEx.Text + "' and oms_in.inv=lpd.inv)*lpd.qty) as `val` from lph left outer join lpd on lph.lph=lpd.lph where lph.oms='" + omsTextBoxEx.Text + "'"+
                           " and lph.`delete`=0 and lph.lph not in (select lph from csl,csi where csl.csi=csi.csi and oms='" + omsTextBoxEx.Text + "')";
            ((GridLookUpEx)gccsl.ExGridView.Columns["lph"].ColumnEdit).Query = query;
        }
        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {               
                // Validate controls
                this.ValidateChildren();
                ReCalculateTotal();
                DetailBindingSource.EndEdit();

                if (gccsa.ExGridView.EditingValue != null)
                    gccsa.ExGridView.SetFocusedValue(gccsa.ExGridView.EditingValue);

                if (gccsl.ExGridView.EditingValue != null)
                    gccsl.ExGridView.SetFocusedValue(gccsl.ExGridView.EditingValue);

                if (gccsb.ExGridView.EditingValue != null)
                    gccsb.ExGridView.SetFocusedValue(gccsb.ExGridView.EditingValue);

           
                //loop DetailTable
                foreach (DataRow dr in DetailTable.Rows)
                {
                      if (dr.RowState != DataRowState.Deleted && dr != null)
                    {
                        if (dr["invo"].ToString() == "")
                            throw new Exception("Harap mengisi no invoice");
                    }
                }


                base.tsbtnSave_Click(sender, e);

                // Update NoDocument dan harga
                for (int i = 0; i < casDataSet.csl.Rows.Count; i++)
                {
                    DataRow row = casDataSet.csl.Rows[i];
                    if (row != null && row.RowState != DataRowState.Deleted)
                    {
                        casDataSet.csl.Rows[i][0] = NoDocument;
                        casDataSet.csl.Rows[i]["price"] = Convert.ToDouble(texttotnilai.EditValue) / Convert.ToDouble(texttotqty.EditValue);
                        casDataSet.csl.Rows[i]["val"] = (Convert.ToDouble(texttotnilai.EditValue) / Convert.ToDouble(texttotqty.EditValue)) * (double)casDataSet.csl.Rows[i]["qty1"];
                    }
                }
                for (int i = 0; i < casDataSet.csb.Rows.Count; i++)
                {
                    DataRow row1 = casDataSet.csb.Rows[i];
                    if (row1 != null && row1.RowState != DataRowState.Deleted)
                        casDataSet.csb.Rows[i][0] = NoDocument;
                }

                cslBindingSource.EndEdit();
                if (casDataSet.csl.GetChanges() != null)
                cslAdapter.Update(casDataSet.csl);
                csbBindingSource.EndEdit();
                csbAdapter.Update(casDataSet.csb);

                gccsa.ExGridView.OptionsBehavior.Editable = false;
                gccsa.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;

                gccsb.ExGridView.OptionsBehavior.Editable = false;
                gccsb.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;

                gccsl.ExGridView.OptionsBehavior.Editable = false;
                gccsl.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;

                SetMode(Mode.View);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ReCalculateTotal();
        }

        void ReCalculateTotal()
        {
            double subTotal = 0;
            double subTotal1 = 0;
            double totqty = 0;
            for (int i = 0; i < DetailTable.Rows.Count; i++)
            {
                if (DetailTable.Rows[i] != null && DetailTable.Rows[i].RowState != DataRowState.Deleted)
                {
                    subTotal = subTotal + (double)DetailTable.Rows[i]["val"];
                }
            }
            for (int i = 0; i < casDataSet.csb.Rows.Count; i++)
            {
                if (casDataSet.csb.Rows[i] != null && casDataSet.csb.Rows[i].RowState != DataRowState.Deleted)
                {
                    subTotal1 = subTotal1 + (double)casDataSet.csb.Rows[i]["val"] ;
                }
            }
            texttotnilai.EditValue = subTotal + subTotal1;
            txttotalbiaya.EditValue = subTotal1;
            
            // Collect qtylpb
            cslBindingSource.EndEdit();
            double qtylpb = 0;
            double totval = 0;
            for (int i = 0; i < casDataSet.csl.Rows.Count; i++)
            {
                if (casDataSet.csl.Rows[i] != null && casDataSet.csl.Rows[i].RowState != DataRowState.Deleted)
                {
                    qtylpb = qtylpb + (double)casDataSet.csl.Rows[i]["qty1"];
                    totval = totval + (double)casDataSet.csl.Rows[i]["val"];
                }
            }
            texttotqty.EditValue = qtylpb;
            textval.EditValue = (subTotal+subTotal1)/qtylpb;
       
        
        }
       
        void gccsa_tsbtnDelete_Click(object sender, EventArgs e)
        {
            DB.DeleteDetailRows(gccsa.ExGridView);
            ReCalculateTotal();
        }

        private void omsTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {
         //   DetailTable.Clear();
            DetailTable.RejectChanges();
            int tNo = 9999;
            foreach (DataRow dr in DetailTable.Rows)
            {
                dr["no"] = tNo;
                dr.Delete();
                tNo++;
            }
           
            DataTable dtcsa = DB.sql.Select("select oms.oms,sub.name,sum(omd.price*omd.qty1*oms.kurs) as val from oms left outer join sub on oms.sub=sub.sub left outer join omd on oms.oms=omd.oms where " +
                              "oms.oms='" + omsTextBoxEx.Text + "' group by oms.oms ");
            int no = 1;
            foreach (DataRow drokl in dtcsa.Rows)
            {
                DataRow drcsa = DetailTable.NewRow();
                drcsa["csi"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
                drcsa["no"] = no;
                drcsa["invo"] = drokl["oms"];
                drcsa["remark"] = drokl["name"];
                drcsa["val"] = drokl["val"];
                drcsa["reff"] = "";
                DetailTable.Rows.Add(drcsa);
                no++;
            }
            gccsa.ExGridView.BestFitColumns();

                casDataSet.omd.Clear();
                 string query = "select no,omd.oms,omd.inv,omd.remark,omd.qty1,omd.unit,omd.price*oms.kurs as price,omd.val*oms.kurs as val,omd.dateneed from omd,oms where omd.oms=oms.oms and omd.oms='" + omsTextBoxEx.EditValue.ToString() + "'";
                omdAdapter = DB.sql.SelectAdapter(query);
                omdAdapter.Fill(casDataSet.omd);
                gccsl.ExGridView.BestFitColumns();
      
        }

        protected override void tsbtnCancel_Click(object sender, EventArgs e)
        {
            base.tsbtnCancel_Click(sender, e);
            DetailTable.RejectChanges();
            casDataSet.csb.RejectChanges();
            PopulateDetails();
        }

        void gccsl_tsbtnDelete_Click(object sender, EventArgs e)
        {
                DB.DeleteDetailRows(gccsl.ExGridView);
                ReCalculateTotal();
        }
                
    }
}

