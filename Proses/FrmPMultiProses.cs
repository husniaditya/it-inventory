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
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid;
using CAS.Proses ;
using System.IO;
namespace CAS.Proses
{
    public partial class FrmPMultiProses : XtraForm
    {
        private GridColumn selectedCol;
        private DataTable dtTransaction;
        //private ArrayList tableNames = new ArrayList(new string[] {"prq","oms import", "oms lokal", "spb", "lph", "", "okl", "memopr", "spm", "sjl", "", "rma", "rms", "spm", "sjr", "", "rsm", "spr", "rka"});
        private ArrayList menuIds = new ArrayList(new string[] { "231", "235", "239", "23a", "232", "251", "252", "255", "256", "233", "236", "237", "23b", "23c", "", "253", "257", "258"});
     //   private ArrayList menuIds = new ArrayList(new string[] { "231", "232" });

        public string Action
        {
            get { return rgAction.Properties.Items[rgAction.SelectedIndex].Description; }
        }

        public FrmPMultiProses()
        {
            InitializeComponent();
        }

        private void FrmPMultiProses_Load(object sender, EventArgs e)
        {
            try { Utility.ApplySkin(this); }
            catch { }

            rgAction.SelectedIndex = 0;
            dateFrom.DateTime = Utility.FirstDateInMonth(DB.loginDate);
            dateTo.DateTime = Utility.LastDateInMonth(DB.loginDate);

            ToolStripButton tsbtnShowDetail = new ToolStripButton("Show Details", null, new EventHandler(tsbtnShowDetail_Click), "tsbtnShowDetail");
            gcxResult.ExToolStrip.Items.Add(tsbtnShowDetail);

            FillLudTransactions();
            ConditionsAdjustment();
        }

        //<gridControl1>
        private void ConditionsAdjustment()
        {
            StyleFormatCondition cn;
            cn = new StyleFormatCondition(FormatConditionEnum.GreaterOrEqual, gcxResult.ExGridView.Columns["total"], null, Utility.GetConfig("MinPORelease"));
            cn.ApplyToRow = false;
            cn.Appearance.BackColor = Color.Yellow;
            gcxResult.ExGridView.FormatConditions.Add(cn);
            gcxResult.ExGridView.BestFitColumns();
        }
        //</gridControl1>

        private void FillLudTransactions()
        {
            string query = "select menuid.menuid, menuid.caption, menuid.tablename from menuid, perms ";
            query += "where perms.menuid=menuid.menuid and ";
            query += "perms.role='" + DB.casUser.Role + "' and ";
            query += "(perms.update=1 or perms.delete=1 or perms.approve=1) and ";
            query += "perms.menuid in (";
            for (int i = 0; i < menuIds.Count-1; i++)
            {
                if (menuIds[i].ToString() != "")
                    query += "'" + menuIds[i].ToString() + "',";
            }
            query += "'" + menuIds[menuIds.Count-1].ToString() + "')";
            dtTransaction = DB.sql.Select(query);
            ludTransactions.Properties.DataSource = dtTransaction;
            ludTransactions.Properties.DisplayMember = "caption";
            ludTransactions.Properties.ValueMember = "menuid";
            ludTransactions.Properties.PopulateColumns();
            ludTransactions.Properties.Columns["caption"].Caption = "Transactions";
            ludTransactions.Properties.Columns["menuid"].Visible = false;
            ludTransactions.Properties.Columns["tablename"].Visible = false;
            ludTransactions.Properties.AutoSearchColumnIndex = 1;
            ludTransactions.ItemIndex = 0;
        }

        private void chkPeriode_CheckedChanged(object sender, EventArgs e)
        {
            dateFrom.Enabled = dateTo.Enabled = chkPeriode.Checked;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                //check User privelege
               // CheckUserPrivelege();
                MySqlDataAdapter masterAdapter = DB.sql.SelectAdapter(BuildMasterQuery());
                MySqlDataAdapter detailAdapter = DB.sql.SelectAdapter(BuildDetailQuery());

                 //Create DataTable objects for representing database's tables
                DataSet dataSetMain = new DataSet();
                masterAdapter.Fill(dataSetMain, "Master");
                if (detailAdapter.SelectCommand.CommandText!="")
                detailAdapter.Fill(dataSetMain, "Detail");

                //Set up a master-detail relationship between the DataTables
                DataColumn keyColumn = dataSetMain.Tables["Master"].Columns[0];
                if (detailAdapter.SelectCommand.CommandText != "")
                {
                    DataColumn foreignKeyColumn = dataSetMain.Tables["Detail"].Columns[0];
                    dataSetMain.Relations.Add("MasterDetail", keyColumn, foreignKeyColumn);
                }
                //Bind the grid control to the data source
                gcxResult.ExGridControl.DataSource = dataSetMain.Tables["Master"];

                //Assign a Detail View to the relationship
                GridView detailView = new GridView(gcxResult.ExGridControl);
                gcxResult.ExGridControl.LevelTree.Nodes.Add("MasterDetail", detailView);
                if (detailAdapter.SelectCommand.CommandText != "")
                {
                    detailView.PopulateColumns(dataSetMain.Tables["Detail"]);
                    detailView.Columns[0].Visible = false;
                    detailView.OptionsView.ShowGroupPanel = false;
                    detailView.OptionsBehavior.Editable = false;
                    DB.SetNumberFormat(detailView, "n2");
                }
                gcxResult.ExGridView.OptionsView.ShowGroupPanel = false;
                gcxResult.ExGridView.OptionsBehavior.Editable = true;
                DB.SetNumberFormat(gcxResult.ExGridView, "n2");
                foreach (GridColumn col in gcxResult.ExGridView.Columns)
                {
                    if (col.FieldName != Action)
                        col.OptionsColumn.AllowEdit = false;
                }

                gcxResult.ExGridView.MouseDown += new MouseEventHandler(ExGridView_MouseDown);
                gcxResult.ExGridView.FocusedRowChanged += new FocusedRowChangedEventHandler(ExGridView_SelectionChanged);
                detailView.MouseDown += new MouseEventHandler(ExGridView_MouseDownDetil);
                if (gcxResult.ExGridView.RowCount >= 1)
                    ExGridView_SelectionChanged(sender, e);

                gcxResult.ExToolStrip.Items["tsbtnShowDetail"].Text = "Show Details";
                if (Action == "Print")
                {
                    checkapp.Text = "Print PDF "; 
                    gcxResult.ExGridView.OptionsView.ShowAutoFilterRow = true;
                    gcxResult.ExGridView.Columns["Print"].OptionsFilter.AllowAutoFilter = false;
                    gcxResult.ExGridView.Columns["printed"].FilterInfo = new ColumnFilterInfo("0");
                    CheckAll(gcxResult.ExGridView.Columns[rgAction.Properties.Items[rgAction.SelectedIndex].Description], false);
                    btnAction.Text = "Select All";
                    btnAction.Visible = true;
                    btnSave.Text = "Print";
                }
                else
                {
                    checkapp.Text = "Show all aproval PO Transaction";
                    gcxResult.ExGridView.OptionsView.ShowAutoFilterRow = false;
                    btnSave.Text = "Save";

                    if (ludTransactions.EditValue.ToString() == "235")
                    {
                        btnAction.Visible = false;
                        // color for aprov otorization
                        if (Action == "Approve")
                            ConditionsAdjustment();
                        //         for (int i = 0; i < gcxResult.ExGridView.RowCount; i++)
                        //             gcxResult.ExGridView.ExpandMasterRow(i);

                    }
                    else
                    {
                        btnAction.Text = Action + " &All";
                        btnAction.Visible = true;
                    }
                }

                //     if (ludTransactions.EditValue.ToString() == "232" )
                //     {
                //         btnAction.Visible = false;
                ////         for (int i = 0; i < gcxResult.ExGridView.RowCount; i++)
                ////             gcxResult.ExGridView.ExpandMasterRow(i);

                //     }
                //     else
                //     {
                //         btnAction.Text = Action + " &All";
                //         btnAction.Visible = true;
                //     }
         
                gcxResult.ExGridView.BestFitColumns();
                gcxResult.ExGridView.Columns["Keterangan"].Width = 250;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(Action + " Action cannot be applied to this Transaction");// + "\r\n" + ex.Message);
                gcxResult.ExGridControl.DataSource = null;
                gcxResult.ExGridView.PopulateColumns();
            }
        }

        private void ExGridView_SelectionChanged(object sender, EventArgs e)
        {
            
            double subtotal = Convert.ToDouble(gcxResult.ExGridView.GetFocusedRowCellValue("total"));
            if (subtotal > Convert.ToDouble(Utility.GetConfig("MinPORelease")) && ludTransactions.EditValue.ToString() == "235" && Action == "Approve" && DB.casUser.Oto != "True")
            {
                gcxResult.ExGridView.OptionsBehavior.Editable = true;
            }
            else
                gcxResult.ExGridView.OptionsBehavior.Editable = true;
             
        }

        void ExGridView_MouseDown(object sender, MouseEventArgs e)
        {
            // obtaining hit info
            GridHitInfo hitInfo = gcxResult.ExGridView.CalcHitInfo(new Point(e.X, e.Y));
            selectedCol = hitInfo.Column;
            if (e.Button == MouseButtons.Right && (hitInfo.InColumn) && (hitInfo.Column.FieldName == Action))
            {
                gcxResult.ExGridView.OptionsMenu.EnableColumnMenu = false;
                // showing the custom context menu
                ViewMenu menu = new ViewMenu(gcxResult.ExGridView);
                DXMenuItem menuItem = new DXMenuItem("Check All", new EventHandler(gridView_CheckColumn));
                menu.Items.Add(menuItem);
                menuItem = new DXMenuItem("Clear All", new EventHandler(gridView_CheckColumn));
                menu.Items.Add(menuItem);
                menu.Show(hitInfo.HitPoint);
            }
            else
            {
                gcxResult.ExGridView.OptionsMenu.EnableColumnMenu = true;
            }

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

                 //   string query = "select * from _close where period='" + DB.loginPeriod + "'";
                 //   DataTable CPeriod = DB.sql.Select(query);

                 //   if (formName.Contains("Transaction") && CPeriod.Rows.Count <= 0)
                    if (formName.Contains("Transaction"))
                   {
                       if (noJurnal.Substring(4, 4) == DB.loginPeriod.ToString())
                       {
                           ((Transaction.BaseTransaction)newForm).NoJurnal = noJurnal;
                           ((Transaction.BaseTransaction)newForm).Viewonly = "True";
                       }
                       else
                       {
                           ((Transaction.BaseTransaction)newForm).NoJurnal = noJurnal;
                           ((Transaction.BaseTransaction)newForm).Viewonly = "False";

                           //      MessageBox.Show("Periode harus sama");
                           //      return;
                       }
                        newForm.Show();
                   }
                    else if (formName.Contains("Master"))
                   {
                        ((Master.BaseMaster)newForm).NoKode = noJurnal;
                       newForm.Show();
                    }
                }
            }
        }

        void ExGridView_MouseDownDetil(object sender, MouseEventArgs e)
        {
            // obtaining hit info


            if (e.Button == MouseButtons.Left && e.Clicks == 2 && ludTransactions.EditValue.ToString() == "235")
            {
                if (((DevExpress.XtraGrid.Views.Grid.GridView)(sender)).FocusedColumn.Caption == "Keterangan")
                {
                    string material = ((DevExpress.XtraGrid.Views.Grid.GridView)(sender)).FocusedValue.ToString();
                   // int focusrow = ((DevExpress.XtraGrid.Views.Grid.GridView)(sender)).GetSelectedRows()[0];
                    string document = ((DevExpress.XtraGrid.Views.Grid.GridView)(sender)).GetDataRow(0).ItemArray[0].ToString();
                    FrmHistoryPrice frmhistory = new FrmHistoryPrice(material,document);
                    frmhistory.ShowDialog();
                }
                // switching focus          
            }
        }

        void gridView_CheckColumn(object sender, EventArgs e)
        {
            try
            {
                DXMenuItem menuItem = sender as DXMenuItem;
                if (menuItem == null) return;

                bool value = (menuItem.Caption == "Check All");

                CheckAll(selectedCol, value);
            }
            catch { }
        }

        void CheckAll(GridColumn column, bool value)
        {
            for (int i = 0; i < gcxResult.ExGridView.RowCount; i++)
            {                
                gcxResult.ExGridView.SetRowCellValue(i, column, value);               
            }
        }

        private string BuildMasterQuery()
        {
            string query = "";
            string tablename = dtTransaction.Select("menuid='" + ludTransactions.EditValue.ToString() + "'")[0]["tablename"].ToString();

            switch (ludTransactions.EditValue.ToString())
            {
                case "231":     // PR
                    query = "select prq as `No Doc`, `date` as `Tgl Dibutuhkan`, `remark` as `Keterangan`,prq.cct as `User Request`,@action from prq";
                     break;
                 case "233":     // MemoPR
                     query = "select mpr as `No Doc`, `date` as `Tanggal`, `remark` as `Keterangan`,mpr.usrpr `User Request` , @action from mpr inner join (select usrpr.usrpr from usrpr where kabag='"+DB.casUser.User.ToString() +"') usrpr on mpr.usrpr=usrpr.usrpr ";
                     break;
                case "232":     // Pur Contract
                case "235":     // PO
                case "239":     // SPB
                case "23a":     // LPB
                case "236":     // PR Retur
                case "237":     // PO Retur
                case "23b":     // SPM Retur
                case "23c":     // SJ Retur
                //    query = "select @table as `No Doc`,@table.Person as Pemesan, sub.name as `Nama Supplier`, @table.`date` as `Tanggal`, @table.`remark` as `Keterangan`, @table.cur, @table.kurs,@table.val as subtotal,if(@table.ppn=1,@table.val*0.1,0) ppn,if(@table.ppn=1,round(@table.val*1.1,2),@table.val) total, @table.@action from @table, sub where @table.sub=sub.sub";
                //    break;

                    if (Action == "Close Item PO")
                    {
                        query = "select omd.oms `No Doc`,sub.name as Supplier, inv as `Kode Barang`, omd.remark as `Keterangan`,omd.price as `Price`,qty1 as `Quantity`, unit as `Unit`,omd.price*qty1 as jumlah,prq.cct as Requisitioner, oms.close as `Close Item PO` from oms inner join omd on omd.oms=oms.oms " +
                                " left outer join prq on omd.prq=prq.prq left outer join sub on oms.sub=sub.sub where oms.`delete`=0 and oms.aprov=1 and oms.close=0 ";
                        break;
                    }
                    else
                    {
                        if (Action == "Print")
                        {
                            gcxResult.ExGridView.OptionsView.ShowAutoFilterRow = true;
                            query = "select @table as `No Doc`,@table.Person as Pemesan, sub.name as `Nama Supplier`, @table.`date` as `Tanggal`, @table.`remark` as `Keterangan`, @table.cur, @table.kurs,@table.val as subtotal,if(@table.ppn=1,@table.val*0.1,0) ppn,if(@table.ppn=1,round(@table.val*1.1,2),@table.val) total,ifnull(printed.reprint,0) as printed, @action from oms left outer join " +
                                "(select jurnal,sum(reprint) as reprint from printed group by jurnal) as printed on oms.oms=printed.jurnal, sub where @table.sub=sub.sub";
                            break;
                        }
                        else
                        {
                            if (DB.casUser.Oto == "True" && ludTransactions.EditValue.ToString() == "235" && Action == "Approve" && checkapp.Checked == false )
                                query = "select @table as `No Doc`,@table.Person as Pemesan, sub.name as `Nama Supplier`, @table.`date` as `Tanggal`, @table.`remark` as `Keterangan`, @table.cur, @table.kurs,@table.val as subtotal,if(@table.ppn=1,@table.val*0.1,0) ppn,if(@table.ppn=1,round(@table.val*1.1,2),@table.val) total,  @table.@action from @table, sub where @table.sub=sub.sub and if(@table.ppn=1,round(@table.val*1.1,2),@table.val) >= " + (Utility.GetConfig("MinPORelease")).ToString() + " and oms.aprov1=1 ";
                            else
                                query = "select @table as `No Doc`,@table.Person as Pemesan, sub.name as `Nama Supplier`, @table.`date` as `Tanggal`, @table.`remark` as `Keterangan`, @table.cur, @table.kurs,@table.val as subtotal,if(@table.ppn=1,@table.val*0.1,0) ppn,if(@table.ppn=1,round(@table.val*1.1,2),@table.val) total,  @table.@action from @table, sub where @table.sub=sub.sub";
                            break;
                        }
                    
                    }
                case "251":     // SO
                case "255":     // SPM
                case "256":     // SJ
                case "253":     // SO Retur
                case "257":     // SPB Retur
                case "258":     // LPB Retur
                    query = "select @table as `No Doc`, sub.name as `Nama Customer`, @table.`date` as `Tanggal`, @table.`remark` as `Keterangan`, @table.@action from @table, sub where @table.sub=sub.sub";
                    break;
                case "252":     // MO
                    query = "select mor as `No Doc`, sub.name as `Nama Customer`, mor.`date` as `Tanggal`, mor.remark as `Keterangan`, mor.@action from mor, okl, sub where mor.okl=okl.okl and okl.sub=sub.sub";
                    break;
            }
            query = query.Replace("@table", tablename);
            if (Action == "Print")
            {
                query = query.Replace("@action", "oms.aprov as " + Action + "");
            }
            else
                query = query.Replace("@action", "`" + rgAction.EditValue.ToString() + "` as `" + Action + "`");

            if (query.IndexOf("where") < 0)
                query += " where ";
            else
                query += " and ";

            // add aprov/close/delete
            if (Action == "Print")
                query += tablename + ".aprov = 1";
            else
                if (Action == "Close Item PO")
                    query += " (omd.closeitem = 0 or omd.closeitem is null)";
                else
                    query += tablename + ".`" + rgAction.EditValue.ToString() + "`=0";

            if (chkPeriode.Checked)
                query += " and "+ tablename + ".`delete`=0 and " + tablename + ".date between " + dateFrom.DateTime.ToString("yyyyMMdd") + " and " + dateTo.DateTime.AddDays(1).ToString("yyyyMMdd");
            else
                query += " and " + tablename + ".period='" + DB.loginPeriod + "' and "+ tablename + ".`delete`=0 ";
                if (ludTransactions.EditValue.ToString() == "231" && Action == "Approve")
                    query += " and prq.aprov=0 ";
                if (ludTransactions.EditValue.ToString() == "235")
                {
                    query += " and oms.group_= 3";
                    if ((DB.casUser.Oto == "False" || DB.casUser.Oto == "") && Action == "Approve")
                          query += " and (oms.aprov1 = 0 or oms.aprov1 is null)";
                }
            if (ludTransactions.EditValue.ToString() == "232")
            {
                query += " and oms.group_= 1";
                if ((DB.casUser.Oto == "False" || DB.casUser.Oto == "") && Action == "Approve")
                    query += " and (oms.aprov1 = 0 or oms.aprov1 is null)";
            };

            return query;
        }


        private string BuildDetailQuery()
        {
            string query = "";
            string tablename = dtTransaction.Select("menuid='" + ludTransactions.EditValue.ToString() + "'")[0]["tablename"].ToString();
            if (Action != "Close Item PO")
            {
                switch (ludTransactions.EditValue.ToString())
                {
                    case "231":     // PR
                        query = "select prd.prq, inv as `Kode Barang`, prd.remark as `Keterangan`, prd.loc as `Loc`,prd.dept as Department, qty1 as `Quantity`, unit as `Unit`, dateneed as `Date Need` from prq, prd where prq.prq=prd.prq";
                        break;
                    case "232":    //PO Contract
                        query = "select omd.oms, inv as `Kode Barang`, omd.remark as `Keterangan`, omd.loc as `Loc`,oms.cur Currency,oms.kurs Kurs,omd.price as `Price`,qty1 as `Quantity`, unit as `Unit`,omd.price*qty1 as jumlah, rsn as reason ,prq.cct as Requisitioner from oms,omd " +
                              " left outer join prq on omd.prq=prq.prq where oms.oms=omd.oms and group_=1";
                        break;
                    case "233":    //MemoPR
                        query = "select mpd.mpr, inv as `Kode Barang`, mpd.remark as `Keterangan`, qty as `Quantity`, unit as `Unit` from mpd, mpr, (select usrpr.usrpr from usrpr where kabag='"+DB.casUser.User.ToString()+"') usrpr where mpd.mpr=mpr.mpr and mpr.usrpr=usrpr.usrpr ";
                        break;
                    case "235":     // PO
                        //       query = "select omd.oms, inv as `Kode Barang`, omd.remark as `Keterangan`, omd.loc as `Loc`,oms.cur Currency,oms.kurs Kurs,omd.price as `Price`,qty1 as `Quantity`, unit as `Unit`,omd.price*qty1 as jumlah, rsn as Reason,prq.cct as Requisitioner from oms,omd " +
                        //       " left outer join prq on omd.prq=prq.prq where oms.oms=omd.oms";
                        query = "select omd.oms, inv as `Kode Barang`, omd.remark as `Keterangan`, omd.loc as `Loc`,oms.cur Currency,oms.kurs Kurs,omd.price as `Price`,qty1 as `Quantity`, unit as `Unit`,omd.price*qty1 as jumlah, rsn as reason ,prq.cct as Requisitioner from oms,omd " +
                              " left outer join prq on omd.prq=prq.prq where oms.oms=omd.oms and group_=3";
                        break;
                    case "239":     // SPB
                        query = "select spbd.spb, inv as `Kode Barang`, spbd.remark as `Keterangan`, spbd.loc as `Loc`, qty as `Quantity`, unit as `Unit` from spb, spbd where spb.spb=spbd.spb";
                        break;
                    case "23a":     // LPB
                        query = "select lpd.lph, inv as `Kode Barang`, lpd.remark as `Keterangan`, lpd.loc as `Loc`, qty as `Quantity`, unit as `Unit` from lph, lpd where lph.lph=lpd.lph";
                        break;
                    case "251":     // SO
                        query = "select okd.okl, nodsg as `No Design`, inv as `Kode Barang`, okd.remark as `Keterangan`, okd.loc as `Loc`, qty as `Quantity`, unit as `Unit`, dateneed as `Date Need` from okl, okd where okl.okl=okd.okl";
                        break;
                    case "252":     // MO
                        query = "select mor.mor, nodsg as `No Design`, inv as `Kode Barang`, remark as `Keterangan`, qty as `Quantity`, unit as `Unit` from mor";
                        break;
                    case "255":     // SPM
                        query = "select spd.spm, nodsg as `No Design`, inv as `Kode Barang`, spd.remark as `Keterangan`, spd.loc as `Loc`, qty as `Quantity`, unit as `Unit` from spm, spd where spm.spm=spd.spm";
                        break;
                    case "256":     // SJ
                        query = "select sjd.sjh, nodsg as `No Design`, inv as `Kode Barang`, sjd.remark as `Keterangan`, sjd.loc as `Loc`, qty as `Quantity`, unit as `Unit` from sjh, sjd where sjh.sjh=sjd.sjh";
                        break;
                    case "236":     // PR Retur
                        query = "select rma.rma, inv as `Kode Barang`, rmb.remark as `Keterangan`, rmb.loc as `Loc`, qty as `Quantity`, unit as `Unit`, date as `Date` from rma, rmb where rma.rma=rmb.rma";
                        break;
                    case "237":     // PO Retur
                        query = "select rms.rms, inv as `Kode Barang`, rmd.remark as `Keterangan`, rmd.loc as `Loc`, qty as `Quantity`, unit as `Unit` from rms, rmd where rms.rms=rmd.rms";
                        break;
                    case "23b":     // SPM Retur
                        query = "select spd.spm, inv as `Kode Barang`, spd.remark as `Keterangan`, spd.loc as `Loc`, qty as `Quantity`, unit as `Unit` from spm, spd where spm.spm=spd.spm";
                        break;
                    case "23c":     // SJ Retur
                        query = "select sjr.sjr, inv as `Kode Barang`, sjrd.remark as `Keterangan`, sjrd.loc as `Loc`, qty as `Quantity`, unit as `Unit` from sjr, sjrd where sjr.sjr=sjrd.sjr";
                        break;
                    case "253":     // SO Retur
                        query = "select rsm.rsm, nodsg as `No Design`, inv as `Kode Barang`, rsmd.remark as `Keterangan`, rsmd.loc as `Loc`, qty as `Quantity`, unit as `Unit` from rsm, rsmd where rsm.rsm=rsmd.rsm";
                        break;
                    case "257":     // SPB Retur
                        query = "select spr.spr, inv as `Kode Barang`, sprd.remark as `Keterangan`, sprd.loc as `Loc`, qty as `Quantity`, unit as `Unit` from spr, sprd where spr.spr=sprd.spr";
                        break;
                    case "258":     // LPB Retur
                        query = "select rka.rka, inv as `Kode Barang`, rkb.remark as `Keterangan`, rkb.loc as `Loc`, qty as `Quantity`, unit as `Unit` from rka, rkb where rka.rka=rkb.rka";
                        break;
                }

                if (query.IndexOf("where") < 0)
                    query += " where ";
                else
                    query += " and ";

                //Print
                if (Action == "Print")
                {
                    query += tablename + ".aprov=1";
                }
                else
                {
                    // add aprov/close/delete
                    query += tablename + ".`" + rgAction.EditValue.ToString() + "`=0";
                    if (Action == "Approve" && DB.casUser.Oto == "True" && (ludTransactions.EditValue.ToString() == "235" ) && checkapp.Checked == false)
                    {
                        query += " and oms.aprov1=1 and if(oms.ppn=1,round(oms.val*1.1,2),oms.val) >= " + (Utility.GetConfig("MinPORelease")).ToString();
                    }
                    if ((ludTransactions.EditValue.ToString() == "235" || ludTransactions.EditValue.ToString() == "232") && (DB.casUser.Oto == "False" || DB.casUser.Oto == ""))
                        query += "  and (oms.aprov1=0 or oms.aprov1 is null)";
                }
                if (chkPeriode.Checked)
                    query += " and "+ tablename + ".`delete`=0 and " + tablename + ".date between " + dateFrom.DateTime.ToString("yyyyMMdd") + " and " + dateTo.DateTime.AddDays(1).ToString("yyyyMMdd");
                else
                    query += " and " + tablename + ".period='" + DB.loginPeriod + "' and "+ tablename + ".`delete`=0";

                if (ludTransactions.EditValue.ToString() == "231" && Action == "Approve")
                       query += " and prq.aprov = 0";             

            }
            return query;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (Action == "Print")
            {
                if (btnAction.Text == "Select All")
                {
                    btnAction.Text = "Deselect all";
                    CheckAll(gcxResult.ExGridView.Columns[rgAction.Properties.Items[rgAction.SelectedIndex].Description], true);
                }
                else
                {
                    btnAction.Text = "Select All";
                    CheckAll(gcxResult.ExGridView.Columns[rgAction.Properties.Items[rgAction.SelectedIndex].Description], false);
                }

            }
            else
                CheckAll(gcxResult.ExGridView.Columns[rgAction.Properties.Items[rgAction.SelectedIndex].Description], true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                CheckUserPrivelege();
                //if (!DB.casUser.AllowApprove(ludTransactions.EditValue.ToString()))
                //{              
                //        MessageBox.Show("You don't have privelege to approve,closse or delete this Transaction");
                //        return ;
                //}             
                string message = "", jurnal = "", updateQuery = "";
                string tablename = dtTransaction.Select("menuid='" + ludTransactions.EditValue.ToString() + "'")[0]["tablename"].ToString();
                string action = rgAction.EditValue.ToString();
                string inv = "";
                string invname = "";

                for (int i = 0; i < gcxResult.ExGridView.RowCount; i++)
                {
                    if (gcxResult.ExGridView.GetDataRow(i)[Action].ToString() == "0")
                        continue;

                    try
                    {
                        jurnal = (gcxResult.ExGridView.GetDataRow(i)[0]).ToString();
                        inv    = (gcxResult.ExGridView.GetDataRow(i)[2]).ToString();
                        invname = (gcxResult.ExGridView.GetDataRow(i)[3]).ToString();

                        if (rgAction.EditValue.ToString() == "print")
                        {
                            printdoc("Transaction.FrmTOrderbeli", jurnal);
                            message += "Printing :" + jurnal + "\r\n";

                        }
                        else
                        {
                            if (tablename == "oms" && action == "closeitem")
                            {
                                updateQuery = "update omd set `" + action + "`=1 where omd.oms ='" + jurnal + "' and inv = '" + inv + "' and remark = '" + invname + "'";
                                DB.sql.Execute("insert into historymdu.datalog values(date(now()),time(now()),'" + DB.casUser.User + "',' update " + tablename + " set " + action + "=1 where " + tablename.ToString() + " =" + jurnal + "')");
                            }
                            else
                                updateQuery = BuildSaveQuery(jurnal);

                            if (rgAction.EditValue.ToString() == "delete")
                            {
                                string query = "Select FCekDeleted('" + tablename + "','" + jurnal + "')";
                                if (DB.sql.Select(query).Rows[0][0].ToString() == "False")
                                    throw new Exception("Can't Delete this transaction");
                            }

                            DB.sql.Execute(updateQuery);

                            if (rgAction.EditValue.ToString() == "delete")
                            {
                                DB.sql.Execute("Call SP_Delete('" + tablename + "','" + jurnal + "')");
                                DB.sql.Execute("Call SP_OpenTransaction('" + tablename + "','" + jurnal + "')");
                            }
                            message += jurnal + ":" + Action + "d";
                        }
                    }
                    catch (Exception ex)
                    {
                        message += jurnal + ":" + updateQuery + "; " + ex.Message + "\r\n";
                    }
                }

                Utility.ShowMessage(message, "Result message: ");
            }

            catch (Exception ex)
            {
                MessageBox.Show(Action + " Action cannot be applied to this Transaction");// + "\r\n" + ex.Message);
                //   gcxResult.ExGridControl.DataSource = null;
                //  gcxResult.ExGridView.PopulateColumns();
            }
        }

        private string BuildSaveQuery(string jurnal)
        {
            string namaaprov = "";
            string query = "";
            string maxpo = "";
            string tablename = dtTransaction.Select("menuid='" + ludTransactions.EditValue.ToString() + "'")[0]["tablename"].ToString();
            string action = rgAction.EditValue.ToString();
            namaaprov = DB.sql.Select("select aprovname from usr where user ='" + DB.casUser.User.ToString().Trim() + "'").Rows[0][0].ToString();
           
            if ((ludTransactions.EditValue.ToString() == "235" || ludTransactions.EditValue.ToString() == "232" ) && Action == "Approve")
            {
                maxpo = (Utility.GetConfig("MinPORelease")).ToString();
                if (DB.casUser.Oto == "True")
                    query = "update " + tablename + " set `" + action + "`=1, aprovby ='" + namaaprov + "' where " + tablename + "='" + jurnal + "'";
                else
                    query = "update " + tablename + " set aprov1 = 1, aprov = if(oms.val < "+ maxpo +",1,0),aprovby1 ='" + namaaprov + "',   aprovby =if(oms.val < "+ maxpo +",'" + namaaprov + "','') where " + tablename + "='" + jurnal + "'";

            }
            else
                if (ludTransactions.EditValue.ToString() == "231" && Action == "Approve" )
                {
                   string apdate = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                   query = "update " + tablename + " set `" + action + "`=1, apdate = '"+ apdate + "' where " + tablename + "='" + jurnal + "'";
                }
                else
                   query = "update " + tablename + " set `" + action + "`=1 where " + tablename + "='" + jurnal + "'";

            DB.sql.Execute("insert into historymdu.datalog values(date(now()),time(now()),'" + DB.casUser.User + "',' update " + tablename + " set " + action + "=1 where " + tablename.ToString() + " =" + jurnal + "')");

            return query;
        }

        private void tsbtnShowDetail_Click(object sender, EventArgs e)
        {
            if ((sender as ToolStripButton).Text == "Show Details")
            {
                for (int i = 0; i < gcxResult.ExGridView.RowCount; i++)
                    gcxResult.ExGridView.ExpandMasterRow(i);

                (sender as ToolStripButton).Text = "Hide Details";
            }
            else
            {
                gcxResult.ExGridView.CollapseAllDetails();

                (sender as ToolStripButton).Text = "Show Details";
            }
        }

        private string GetNextFileName(string fileName)
        {
            string extension = Path.GetExtension(fileName);
            string pathName = Path.GetDirectoryName(fileName);
            string fileNameOnly = Path.Combine(pathName, Path.GetFileNameWithoutExtension(fileName));
            int i = 0;
            // If the file exists, keep trying until it doesn't
            while (File.Exists(fileName))
            {
                i += 1;
                fileName = string.Format("{0}({1}){2}", fileNameOnly, i, extension);
            }
            return fileName;
        }

        private void printdoc(string formname, string jurnal)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepPO" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("Call SP_Print('" + formname + "','" + jurnal + "')");
            DataTable dtRep = dt.Clone();
            dtRep.Columns.Add("pageno", typeof(string));
            //report.DataSource = DB.sql.Select("Call SP_Print('" + this.Name + "','" + this.NoDocument + "')");
            int recordsCount = 0;
            int pageno = 1;
            DataRow drRep;
            double subtotal = 0;
            foreach (DataRow dr in dt.Rows)
            {
                recordsCount++;
                string remark = dr["remark"].ToString() + " - " + dr["etd"].ToString();
                //1 row kolom nama barang max 30 karakter
                while (remark.Length > 30)
                {
                    recordsCount++;
                    remark = remark.Substring(0, 30);
                }
                if ((recordsCount > 50 && pageno == 1) || (recordsCount > 50 && pageno > 1))
                {
                    pageno++;
                    recordsCount = 1;
                }
                //saldo dipindahkan
                if (pageno > 1 && recordsCount == 1)
                {
                    drRep = dtRep.NewRow();
                    drRep["remark"] = "Dipindahkan";
                    drRep["val"] = subtotal;
                    drRep["pageno"] = pageno;
                    dtRep.Rows.Add(drRep);
                    recordsCount++;
                }
                drRep = dtRep.NewRow();
                foreach (DataColumn col in dt.Columns)
                    drRep[col.ColumnName] = dr[col.ColumnName];
                drRep["pageno"] = pageno;
                dtRep.Rows.Add(drRep);
                subtotal = subtotal + Convert.ToDouble(dr["val"]);
            }

            DB.sql.Execute("insert into printed values ('" + jurnal + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',1)");
            report.DataSource = dtRep;
            // report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
            //  report.Bands[BandKind.PageFooter].Controls["xrLblTotalPage"].Text = pageno.ToString();
            report.Controls[6].Controls["lblUser"].Text = DB.casUser.Name;
            report.Controls[6].Controls["xrLblTotalPage"].Text = pageno.ToString();

            report.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.PrintDirect, DevExpress.XtraPrinting.CommandVisibility.None);
            report.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.Print, DevExpress.XtraPrinting.CommandVisibility.None);

            if (checkapp.Checked == true)
            {
            //    string dir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string dir = "E:\\PO";
                string nama = dtRep.Rows[0]["name"].ToString().Replace(" ", "_").PadRight(25, ' ').Substring(0, 25).Trim();
                string filename = dir + "\\PO_KIAS_" + jurnal.Replace("-", "") + "_" + nama + ".pdf";
                report.CreatePdfDocument(GetNextFileName(filename));
            }
            else
                report.Print();
           //  report.ShowPreview();
            //report.RunDesigner();
        }
        public Form CreateForm(string formName)
        {
            Type frmType = Assembly.GetExecutingAssembly().GetType(formName);

            if (frmType != null)
                return (Form)Activator.CreateInstance(frmType);
            else
                return null;
        }

        private void CheckUserPrivelege()
        {
            switch (rgAction.EditValue.ToString())
            {
                case "aprov":
                    if (!DB.casUser.AllowApprove(ludTransactions.EditValue.ToString())) //ludTransactions.EditValue.ToString()))
                        throw new Exception("You don't have privelege to Approve this Transaction");
                    break;
           //     case "closeitem":
                case "close":
                    if (!DB.casUser.AllowUpdate(ludTransactions.EditValue.ToString())) //ludTransactions.EditValue.ToString()))
                        throw new Exception("You don't have privelege to Close this Transaction");
                    break;
                case "delete":
                    if (!DB.casUser.AllowApprove(ludTransactions.EditValue.ToString())) //ludTransactions.EditValue.ToString()))
                        throw new Exception("You don't have privelege to Delete this Transaction");
                    break;
            }
        }
    }
}