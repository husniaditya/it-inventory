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
    public partial class FrmPInvIT : XtraForm
    {
        private GridColumn selectedCol;
        private DataTable dtTransaction;

        public string Action
        {
            get { return rgAction.Properties.Items[rgAction.SelectedIndex].Description; }
        }
    
        public FrmPInvIT()
        {
            InitializeComponent();
        }

        private void FrmPInvIT_Load(object sender, EventArgs e)
        {
            try { Utility.ApplySkin(this); }
            catch { }

            rgAction.SelectedIndex = 0;
            dateFrom.DateTime = Utility.FirstDateInMonth(DB.loginDate);
            dateTo.DateTime = Utility.LastDateInMonth(DB.loginDate);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter masterAdapter = DB.sql.SelectAdapter(BuildMasterQuery());
            MySqlDataAdapter detailAdapter = DB.sql.SelectAdapter(BuildDetailQuery());

            DataSet dataSetMain = new DataSet();
            masterAdapter.Fill(dataSetMain, "Master");
            detailAdapter.Fill(dataSetMain, "Detail");

            DataColumn keyColumn = dataSetMain.Tables["Master"].Columns[0];
            DataColumn foreignKeyColumn = dataSetMain.Tables["Detail"].Columns[0];


            if (rgAction.EditValue.ToString() == "arrive" || rgAction.EditValue.ToString() == "all")
            {
                gcxResult.ExGridControl.DataSource = dataSetMain.Tables["Master"];
                GridView detailView = new GridView(gcxResult.ExGridControl);
            }
            if (rgAction.EditValue.ToString() == "po_it")
            {
                dataSetMain.Relations.Add("MasterDetail", keyColumn, foreignKeyColumn);
                gcxResult.ExGridControl.DataSource = dataSetMain.Tables["Master"];
                GridView detailView = new GridView(gcxResult.ExGridControl);
                gcxResult.ExGridControl.LevelTree.Nodes.Add("MasterDetail", detailView);
                detailView.PopulateColumns(dataSetMain.Tables["Detail"]);
                detailView.OptionsView.ShowGroupPanel = false;
                detailView.OptionsBehavior.Editable = false;
            }

            gcxResult.ExGridView.OptionsView.ShowGroupPanel = false;
            gcxResult.ExGridView.OptionsBehavior.Editable = true;
            foreach (GridColumn col in gcxResult.ExGridView.Columns)
            {
                if (col.FieldName != Action)
                    col.OptionsColumn.AllowEdit = false;
            }
            gcxResult.ExGridView.MouseDown += new MouseEventHandler(ExGridView_MouseDown);
     //       gcxResult.ExToolStrip.Items["tsbtnShowDetail"].Text = "Show Details";

            btnAction.Text = Action + " &All";
            btnAction.Visible = false;
        }

        private string BuildMasterQuery()
        {
            string query = "";
            query = "select prq as `No Doc`, `date` as `Tgl PR`, `remark` as `Keterangan`, @action from prq where @action=0 ";
            if (rgAction.EditValue.ToString() == "all")
            {
              //  query = "select prq as `No Doc`, `date` as `Tgl PR`, `remark` as `Keterangan`, po_it , arrive from prq where 1 ";
                query = "select prq.date tglpr,prq.prq `No Doc`,oms.date `Tgl Po`,omd.oms `No PO`,omd.inv `Kode Brg`,omd.remark `Nama Brg`,omd.qty `Qty`,prq.po_it, omd.arrive from prq inner join omd on omd.prq=prq.prq ";
                query += " left outer join oms on omd.oms=oms.oms where 1";
            }
            else //po it
            {
                if (rgAction.EditValue.ToString() == "po_it")
                {
                    query = query.Replace("@action", "`" + rgAction.EditValue.ToString() + "`");
                }
                else
                {
                    //arrive
                    query = "select prq.date tglpr,prq.prq,oms.date,omd.oms,omd.inv,omd.remark,omd.qty,omd.arrive from prq inner join omd on omd.prq=prq.prq ";
                    query += " left outer join oms on omd.oms=oms.oms ";
                    query += " where omd.oms is not null and (omd.arrive is null or omd.arrive=0) ";
                }
            }

            query += " and prq.date between " + dateFrom.DateTime.ToString("yyyyMMdd") + " and " + dateTo.DateTime.AddDays(1).ToString("yyyyMMdd");

            if (rgAction.EditValue.ToString() != "po_it")
                query += " and po_it=1";

            return query;
        }

        private string BuildDetailQuery()
        {
            string query = "";
            query = "select prd.prq as `No Doc`, inv as `Kode Barang`, prd.remark as `Keterangan`, prd.loc as `Loc`, qty as `Quantity`, unit as `Unit`, dateneed as `Date Need` from prq, prd where prq.prq=prd.prq";
            query += " and  po_it=0 and prq.date between " + dateFrom.DateTime.ToString("yyyyMMdd") + " and " + dateTo.DateTime.AddDays(1).ToString("yyyyMMdd");
            return query;
        }

        //void gridView_CheckColumn(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        DXMenuItem menuItem = sender as DXMenuItem;
        //        if (menuItem == null) return;

        //        bool value = (menuItem.Caption == "Check All");

        //        CheckAll(selectedCol, value);
        //    }
        //    catch { }
        //}
        //void CheckAll(GridColumn column, bool value)
        //{
        //    for (int i = 0; i < gcxResult.ExGridView.RowCount; i++)
        //    {
        //        gcxResult.ExGridView.SetRowCellValue(i, column, value);
        //    }
        //}
        void ExGridView_MouseDown(object sender, MouseEventArgs e)
        {
            // obtaining hit info
            GridHitInfo hitInfo = gcxResult.ExGridView.CalcHitInfo(new Point(e.X, e.Y));
            selectedCol = hitInfo.Column;
          
            if (e.Button == MouseButtons.Left && e.Clicks == 2 && (hitInfo.InRow) && (!gcxResult.ExGridView.IsGroupRow(hitInfo.RowHandle)))
            {
                // switching focus
                gcxResult.ExGridView.FocusedRowHandle = hitInfo.RowHandle;

                string noJurnal = gcxResult.ExGridView.GetFocusedDisplayText();
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

        public Form CreateForm(string formName)
        {
            Type frmType = Assembly.GetExecutingAssembly().GetType(formName);

            if (frmType != null)
                return (Form)Activator.CreateInstance(frmType);
            else
                return null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string message = "", jurnal = "", inv = "", updateQuery = "",remark="";
            string action = rgAction.EditValue.ToString();
            if (action=="all")
            {
                MessageBox.Show("Update tidak bisa dalam kondisi All");
                return;
            }
            if (action == "po_it")
            {
                if (gcxResult.ExGridView.Columns[3].Name != "col" + action)
                {
                    MessageBox.Show("Click Show terlebih dahulu");
                    return;
                }
            }
            if (action == "arrive")
            {
                if (gcxResult.ExGridView.Columns[7].Name != "col" + action)
                {
                    MessageBox.Show("Click Show terlebih dahulu");
                    return;
                }
            }
            for (int i = 0; i < gcxResult.ExGridView.RowCount; i++)
            {
                if (gcxResult.ExGridView.GetDataRow(i)[Action].ToString() == "0" || gcxResult.ExGridView.GetDataRow(i)[Action].ToString() == "")
                        continue;           
 
                try
                {
                    if (action == "po_it")
                    {
                        jurnal = (gcxResult.ExGridView.GetDataRow(i)[0]).ToString();
                        inv = "";
                        remark = "";
                    }
                    else
                    {
                        jurnal = (gcxResult.ExGridView.GetDataRow(i)[3]).ToString();
                        inv = (gcxResult.ExGridView.GetDataRow(i)[4]).ToString();
                        remark = (gcxResult.ExGridView.GetDataRow(i)[5]).ToString();
                    }

                    updateQuery = BuildSaveQuery(jurnal,inv,remark);

                                    
                    DB.sql.Execute(updateQuery);
                    message += jurnal + ":" + updateQuery + "; ok \r\n";

                }
                catch(Exception ex)
                {
                    message += jurnal + ":" + updateQuery + "; gagal \r\n";
                }
            }
            
            Utility.ShowMessage(message, "Result message: ");
            btnShow_Click(sender, e);
        }

        private string BuildSaveQuery(string jurnal,string inv,string remark)
        {
            string query = "";
            string action = rgAction.EditValue.ToString();
            if (action == "po_it")
              query = "update prq set `" + action + "`=1 where prq ='" + jurnal + "'";
            else
              query = "update omd set `" + action + "`=1 where oms ='" + jurnal + "' and inv='" + inv +"' and remark='"+remark+"'";
            
            return query;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {

        }

     }
}
