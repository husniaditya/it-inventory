using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;  
using DevExpress.Data; 
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Menu;
using DevExpress.Utils.Menu;   

namespace KASLibrary
{
    public partial class FrmDialog : DevExpress.XtraEditors.XtraForm   
    {
        private string tableName = "";
        private string fieldName = "";
        private string fieldValue = "";
        private string condition = "";
        private string boxbutton = "";

        private string[] selectFields;
        private string[] filterFields;
        private DataTable dataSource;
        private Label[] lblCaption;
        private CheckBox[] chkUse;
        private ComboBox[] cboOperator;
        private Control[] ctrlValue;
        private DataRow[] resultRows;
        private SQL sql;
        private FrmWait fWait;

        /// <summary>
        /// Dialog Form to search and choose one or more DataRow(s)
        /// </summary>
        /// <param name="sql">SQL used for select query</param>
        /// <param name="tableName">database table name</param>
        /// <param name="fieldName">search field name</param>
        /// <param name="fieldValue">the initial value of the search field</param>
        /// <param name="condition">additional condition in the where clause of the select query</param>
        /// <param name="fields">database fields to be used in the select query</param>
        /// <param name="autoShowResult">whether to show query result on opening Dialog</param>
        public FrmDialog(string title, SQL sql, string tableName, string fieldName, string fieldValue,
            string condition, string[] filterFields, string[] selectFields, bool autoShowResult)
        {
            InitializeComponent();
            this.sql = sql;
            this.tableName = tableName;
            this.fieldName = fieldName;
            this.fieldValue = fieldValue;
            this.selectFields = selectFields;
            this.filterFields = filterFields;
            this.condition = condition;
            gcResult.ExTitleLabel.Text = title;
            gcResult.ExGridControl.KeyDown += new KeyEventHandler(ExGridControl_KeyDown);
            gcResult.ExGridControl.MouseDown += new MouseEventHandler(ExGridControl_MouseDown);

            fWait = new FrmWait();
            BuildInterface();
            Utility.ApplySkin(this);
            if (fieldValue.Trim() != "" || autoShowResult)
                ShowResult();
            else
                ctrlValue[0].Select();
        }
        
        public FrmDialog(string title, SQL sql, string tableName, string fieldName, string fieldValue,
            string condition, string[] filterFields, string[] selectFields)
            : this(title, sql, tableName, fieldName, fieldValue, condition, filterFields, selectFields, false)
        {

        }

        public FrmDialog(string title, SQL sql, string tableName, string fieldName, string fieldValue,
            string condition)
        {
            InitializeComponent();
            this.sql = sql;
            this.tableName = tableName;
            this.fieldName = fieldName;
            this.fieldValue = fieldValue;
            this.selectFields = this.filterFields = new string[] { };
            this.condition = condition;

            gcResult.ExTitleLabel.Text = title;
            gcResult.ExGridControl.KeyDown += new KeyEventHandler(ExGridControl_KeyDown);
            gcResult.ExGridControl.MouseDown += new MouseEventHandler(ExGridControl_MouseDown);

            fWait = new FrmWait();

            string query = "select * from " + tableName;
            if (condition.Trim() != "") query += " where " + condition;
            dataSource = sql.Select(query);

            BuildSimpleInterface();
        }

        public FrmDialog(string title, SQL sql, string query)
        {
            InitializeComponent();
            this.sql = sql;

            gcResult.ExTitleLabel.Text = title;
            gcResult.ExGridControl.KeyDown += new KeyEventHandler(ExGridControl_KeyDown);
            gcResult.ExGridControl.MouseDown += new MouseEventHandler(ExGridControl_MouseDown);

            fWait = new FrmWait();

   
            dataSource = sql.Select(query);

            BuildSimpleInterface();
        }

        public FrmDialog(string title, SQL sql, string query, string boxbutton)
        {
            InitializeComponent();
            this.sql = sql;

            gcResult.ExTitleLabel.Text = title;

         //   gcResult.ExGridControl.KeyDown += new KeyEventHandler(ExGridControl_KeyDown);
            gcResult.ExGridControl.MouseDown += new MouseEventHandler(ExGridControl_MouseDown);

            fWait = new FrmWait();

            dataSource = sql.Select(query);

            BuildSimpleInterface();
            this.ControlBox = false;

        }


        public FrmDialog(string title, SQL sql, string query, bool checkCol)
        {
            InitializeComponent();
            this.sql = sql;
            
            gcResult.ExTitleLabel.Text = title;
            gcResult.ExGridControl.KeyDown += new KeyEventHandler(ExGridControl_KeyDown);
            gcResult.ExGridControl.MouseDown += new MouseEventHandler(ExGridControl_MouseDown);

            fWait = new FrmWait();

            dataSource = sql.Select(query);

            if (checkCol)
            {
                // Create a checkbox column
                DataColumn colCheck = new DataColumn("Check", typeof(bool));
                colCheck.DefaultValue = false;
                dataSource.Columns.Add(colCheck);
            }

            BuildSimpleInterface();

            if (checkCol)
            {
                // Enable Check column edit
                gcResult.ExGridView.Columns["Check"].VisibleIndex = 0;
                gcResult.ExGridView.OptionsBehavior.Editable = true;
                gcResult.ExGridView.Columns["Check"].OptionsFilter.AllowFilter = false;
                gcResult.ExGridView.Columns["Check"].OptionsFilter.AllowAutoFilter = false;
                
                foreach (GridColumn gCol in gcResult.ExGridView.Columns)
                {
                    gCol.OptionsColumn.AllowEdit = (gCol.FieldName == "Check");
                }
                gcResult.ExGridView.MouseDown += new MouseEventHandler(ExGridView_MouseDown);
            }
        }

        void ExGridView_MouseDown(object sender, MouseEventArgs e)
        {
            // obtaining hit info
            GridHitInfo hitInfo = gcResult.ExGridView.CalcHitInfo(new Point(e.X, e.Y));
            if (e.Button == MouseButtons.Right && (hitInfo.InColumn) && (hitInfo.Column.FieldName == "Check"))
            {
                gcResult.ExGridView.OptionsMenu.EnableColumnMenu = false;
                // showing the custom context menu
                ViewMenu menu = new ViewMenu(gcResult.ExGridView);
                DXMenuItem menuItem = new DXMenuItem("Check All", new EventHandler(gridView_CheckColumn));
                menu.Items.Add(menuItem);
                menuItem = new DXMenuItem("Clear All", new EventHandler(gridView_CheckColumn));
                menu.Items.Add(menuItem);
                menu.Show(hitInfo.HitPoint);
            }
            else
            {
                gcResult.ExGridView.OptionsMenu.EnableColumnMenu = true;
            }
        }

        void gridView_CheckColumn(object sender, EventArgs e)
        {
            try
            {
                DXMenuItem menuItem = sender as DXMenuItem;
                if (menuItem == null) return;

                bool value = (menuItem.Caption == "Check All");

                for (int i = 0; i < gcResult.ExGridView.RowCount; i++)
                {
                    gcResult.ExGridView.SetRowCellValue(i, "Check" , value);
                }
            }
            catch { }
        }

        public DataTable DataSource
        {
            get { return dataSource; }
        }

        public DataRow[] ResultRows
        {
            get { return resultRows; }
        }


        private void BuildSimpleInterface()
        {
            btnShow.Visible = btnSelect.Visible = btnCancel.Visible = false;

            // add Select button on ToolStrip
            ToolStripButton tsbtnSelect = new ToolStripButton("&Select", null, btnSelect_Click, "tsbtnSelect");
            tsbtnSelect.DisplayStyle = ToolStripItemDisplayStyle.Text;
            gcResult.ExToolStrip.Items.Insert(3, tsbtnSelect);
            
            // hide tsbtnNew & tsbtnDelete
            gcResult.ExToolStrip.Items["tsbtnNew"].Visible = gcResult.ExToolStrip.Items["tsbtnDelete"].Visible = false;

            gcResult.ExGridControl.DataSource = dataSource;
            gcResult.ExAutoSize = true;
            gcResult.Dock = DockStyle.Fill;
            gcResult.ExGridView.OptionsView.ShowAutoFilterRow = true;
            gcResult.ExGridView.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle;
            gcResult.ExGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(ExGridView_FocusedRowChanged);

            gcResult.ExGridView.SetFocusedRowCellValue(gcResult.ExGridView.Columns[fieldName], fieldValue);
        }

        void ExGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            // select row after moving from filterrow
            if (gcResult.ExGridView.IsFilterRow(e.PrevFocusedRowHandle))
                gcResult.ExGridView.SelectRow(e.FocusedRowHandle);
        }

        private void BuildInterface()
        {
            string query = "select ";
            if (filterFields.Length == 0)
            {
                query += "*";
            }
            else
            {
                foreach (string f in filterFields)
                {
                    query += "`" + f + "`,";
                }
                query = query.Substring(0, query.Length - 1);  
            }
            query += " from " + tableName + " where aktif=1";
            dataSource = sql.Select(query);

            if (filterFields.Length == 0)
            {
                filterFields = new string[dataSource.Columns.Count];
                for (int i = 0; i < dataSource.Columns.Count; i++)
                    filterFields[i] = dataSource.Columns[i].ColumnName;   
            }

            int left = 10;
            int maxWidth = 0;
            int rowHeight = 25;

            chkUse = new CheckBox[dataSource.Columns.Count];
            for (int i = 0; i < chkUse.Length; i++)
            {
                chkUse[i] = new CheckBox();
                chkUse[i].Left = left;
                chkUse[i].Top = 10 + rowHeight * i;
                chkUse[i].Width = 20;
                if (filterFields[i] == fieldName)
                    chkUse[i].Checked = true;
                this.Controls.Add(chkUse[i]);   
            }

            left += 20;
            maxWidth = 0;
            lblCaption = new Label[dataSource.Columns.Count];
            Graphics g = Graphics.FromHwnd(this.Handle);  
            for (int i = 0; i < lblCaption.Length; i++)
            {
                lblCaption[i] = new Label();
                lblCaption[i].AutoSize = true;  
                lblCaption[i].Text = filterFields[i];
                lblCaption[i].Left = left;
                lblCaption[i].Top = 15 + rowHeight * i;
                lblCaption[i].Width = (int)g.MeasureString(lblCaption[i].Text, lblCaption[i].Font).Width;     
                if (lblCaption[i].Width > maxWidth) maxWidth = lblCaption[i].Width;     
                this.Controls.Add(lblCaption[i]);  
            }

            left += maxWidth + 10;
            cboOperator = new ComboBox[dataSource.Columns.Count];
            for (int i = 0; i < cboOperator.Length; i++)
            {
                if (dataSource.Columns[i].DataType == typeof(UInt64)) //UInt64 -> bool
                    continue;
                cboOperator[i] = new ComboBox();
                if(dataSource.Columns[i].DataType == typeof(string))
                    cboOperator[i].Items.Add("LIKE");
                cboOperator[i].Items.Add("=");
                cboOperator[i].Items.Add("<>");
                cboOperator[i].Items.Add("<");
                cboOperator[i].Items.Add("<=");
                cboOperator[i].Items.Add(">");
                cboOperator[i].Items.Add(">=");
            
                cboOperator[i].Left = left;
                cboOperator[i].Top = 10 + rowHeight * i;
                cboOperator[i].Width = 60;
                cboOperator[i].SelectedIndex = 0;
                cboOperator[i].DropDownStyle = ComboBoxStyle.DropDownList;   
                this.Controls.Add(cboOperator[i]);
            }

            ctrlValue = new Control[dataSource.Columns.Count];
            for (int i = 0; i < ctrlValue.Length; i++)
            {
                if (dataSource.Columns[i].DataType == typeof(UInt64))
                {
                    ctrlValue[i] = new CheckBox();
                }
                else if (dataSource.Columns[i].DataType == typeof(DateTime))
                {
                    ctrlValue[i] = new DateTimePicker();
                }
                else
                {
                    ctrlValue[i] = new TextBox(); 
                }

                if (cboOperator[i] != null)
                    ctrlValue[i].Left = left + 70;
                else
                    ctrlValue[i].Left = left;
                ctrlValue[i].Top = 10 + rowHeight * i;
                ctrlValue[i].KeyDown += new KeyEventHandler(ctrlValue_KeyDown);

                if (dataSource.Columns[i].ColumnName == fieldName)
                {
                    if (dataSource.Columns[i].DataType == typeof(string))
                        ctrlValue[i].Text = fieldValue;
                }
                this.Controls.Add(ctrlValue[i]);
            }

            btnShow.Top = ctrlValue[ctrlValue.Length - 1].Bottom + 10;
            btnSelect.Top = ctrlValue[ctrlValue.Length - 1].Bottom + 10;
            btnCancel.Top = ctrlValue[ctrlValue.Length - 1].Bottom + 10; 

            gcResult.ExAutoSize = true; 
            gcResult.Left = 10;
            gcResult.Width = this.Width - 20;
            gcResult.Top = btnShow.Bottom + 10;
            gcResult.Height = this.Height - btnShow.Bottom - 40;
            if (gcResult.Height < 300)
            {
                this.Height += 300 - gcResult.Height;
                gcResult.Height = this.Height - btnShow.Bottom - 40;
            }
        }

        private void ctrlValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
                Close(); 
            }
            if (e.KeyCode == Keys.Enter)
            {
                ShowResult();
            }
        }

        private void ShowResult()
        {
            string query = "select ";
            if (selectFields.Length == 0)
            {
                query += "*";
            }
            else
            {
                foreach (string f in selectFields)
                {
                    string f2 = f;
                    if (f2.ToLower().StartsWith("distinct "))
                        f2 = f2.Substring(9); 
                    query += "`" + f2 + "`,";
                }
                query = query.Substring(0, query.Length - 1);
            }
            query += " from " + tableName;

            for(int i=0;i<chkUse.Length;i++)
                if (chkUse[i].Checked || condition.Trim()!="")
                {
                    query += " where ";
                    if (condition.Trim() != "")
                        query += condition + " and "; 
                    break;
                }

            for (int i = 0; i < chkUse.Length; i++)
            {
                if (!chkUse[i].Checked) continue;
                query += "`" + lblCaption[i].Text + "` ";
                if (cboOperator[i] != null)
                    query += cboOperator[i].Text + " ";
                else
                    query += "= ";
                if (ctrlValue[i] is TextBox)
                {
                    if (dataSource.Columns[i].DataType == typeof(string))
                    {
                        if(cboOperator[i].Text == "LIKE")
                            query += "\"" + ctrlValue[i].Text + "%\"";
                        else
                            query += "\"" + ctrlValue[i].Text + "\"";
                    }
                    else
                    {
                        query += ctrlValue[i].Text;
                    }
                }
                else if (ctrlValue[i] is CheckBox)
                {
                    if(((CheckBox)ctrlValue[i]).Checked)
                        query += "1";
                    else
                        query += "0";
                }
                else
                {
                    query += ((DateTimePicker)ctrlValue[i]).Value.ToString("yyyyMMdd");
                }
                query += " and ";
            }
            if (query.EndsWith(" and ")) query = query.Substring(0, query.Length - 5);
            query += " order by `" + fieldName + "`";

            this.Cursor = Cursors.WaitCursor;
            fWait.StartPosition = FormStartPosition.Manual;
            fWait.Location = new Point(this.Location.X + gcResult.Location.X + (gcResult.Width - fWait.Width) / 2, 
                this.Location.Y + gcResult.Location.Y + (gcResult.Height - fWait.Height) / 2);
            fWait.Show();
            fWait.Refresh();

            dataSource = sql.Select(query);
            gcResult.ExGridControl.DataSource = dataSource;
           
            this.Width = gcResult.Width + 20;

            this.Invalidate();
            gcResult.Refresh();
            gcResult.Focus();
            gcResult.ExGridView.SelectRow(0);

            fWait.Hide();
            this.Cursor = Cursors.Default;
        }

        private void ExGridControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
                Close(); 
            }
            if (e.KeyCode == Keys.Enter)
            {
                this.ValidateChildren();
                if (gcResult.ExGridControl.DataSource == null)
                {
                    ShowResult();
                    return;
                }
                int[] index;// = gcResult.ExGridView.GetSelectedRows();

                if (dataSource.Columns.IndexOf("Check") >= 0)
                {
                    DataRow[] dRow = dataSource.Select("Check=true");
                    resultRows = new DataRow[dRow.Length];
                    for (int i=0;i<dRow.Length;i++)
                    {
                        resultRows[i] = dRow[i];
                    }

                    if (resultRows.Length > 0)
                    {
                        DialogResult = DialogResult.OK;
                        Close();
                        return;
                    }
                }
                
                index = gcResult.ExGridView.GetSelectedRows();

                if (index==null) return;

                resultRows = new DataRow[index.Length];
                for (int i = 0; i < index.Length;i++)
                {
                    resultRows[i] = gcResult.ExGridView.GetDataRow(index[i]);
                }
                DialogResult = DialogResult.OK;
                Close(); 
            }
        }

        private void ExGridControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 2 && e.Button == MouseButtons.Left)
            {
                ExGridControl_KeyDown(gcResult, new KeyEventArgs(Keys.Enter));    
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowResult(); 
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            ExGridControl_KeyDown(gcResult, new KeyEventArgs(Keys.Enter));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ExGridControl_KeyDown(gcResult, new KeyEventArgs(Keys.Escape));
        }

        private void FrmDialog_KeyDown(object sender, KeyEventArgs e)
        {
            ExGridControl_KeyDown(gcResult, e);
        }
    }
}
