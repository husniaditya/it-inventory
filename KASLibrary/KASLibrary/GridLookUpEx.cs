using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using KASLibrary;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;

namespace KASLibrary
{
    public partial class GridLookUpEx : RepositoryItemButtonEdit
    {
        private string m_table;
        private string m_field;
        private string m_descColumn;
        private string m_query;
        private string m_title;
        private GridView m_gridView;
        SQL m_sql;
        private bool m_autoFill;
        private bool m_multiSelect;

        public string TableName
        {
            get { return m_table; }
            set { m_table = value; }
        }

        public string FieldName
        {
            get { return m_field; }
            set { m_field = value; }
        }

        public string DescColumn
        {
            get { return m_descColumn; }
            set { m_descColumn = value; }
        }

        public string Query
        {
            get { return m_query; }
            set { m_query = value; }
        }

        public string DialogTitle
        {
            get { return m_title; }
            set { m_title = value; }
        }

        public GridView GridView
        {
            get { return m_gridView; }
            set { m_gridView = value; }
        }

        public bool AutoFill
        {
            get { return m_autoFill; }
            set { m_autoFill = value; }
        }
        
        public bool MultiSelect
        {
            get { return m_multiSelect; }
            set { m_multiSelect = value; }
        }

        public GridLookUpEx(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public GridLookUpEx(SQL sql, string query, string table, string field, GridView gridView, string descColumn, bool autoFill, bool multiSelect, string title)
        {
            InitializeComponent();
            m_sql = sql;
            m_query = query;
            m_table = table;
            m_field = field;
            m_descColumn = descColumn;
            m_gridView = gridView;
            m_autoFill = autoFill;
            m_multiSelect = multiSelect;
            m_title = title;
            this.Buttons[0].Shortcut = new DevExpress.Utils.KeyShortcut(Keys.F4);
            this.Leave += new EventHandler(GridLookUpEx_Leave);
        }

        public void ClickButton()
        {
            GridLookUpEx_DoubleClick(this, new EventArgs());
        }

        private void GridLookUpEx_DoubleClick(object sender, EventArgs e)
        {
            FrmDialog frmDialog = null;

            if (m_query != "")
                frmDialog = new FrmDialog(m_title, m_sql, m_query, true);
            else
                frmDialog = new FrmDialog(m_title, m_sql, m_table, m_field, "", "");
            
            if (frmDialog.ShowDialog() == DialogResult.OK)
            {
                if (m_gridView == null)
                {
                    MessageBox.Show("GridView is not defined!");
                    return;
                }

                if (m_gridView.FocusedRowHandle >= 0 || !m_multiSelect)
                {
                    // not a new row

                    // only retrieve the first ResultRow
                    DataRow drKode = frmDialog.ResultRows[0];

                    if ((sender as TextEdit).EditValue == null)
                        (sender as TextEdit).EditValue = ""; // check if null so the ToString() below would not fail
                    if ((sender as TextEdit).EditValue.ToString() != drKode[0].ToString())
                    {
                        //(sender as TextEdit).EditValue = drKode[0];
                        (sender as TextEdit).EditValue = drKode[m_gridView.FocusedColumn.Caption];

                        if (m_autoFill)
                        {
                            foreach (DataColumn col in frmDialog.DataSource.Columns)
                            {
//                                if (m_gridView.Columns.ColumnByFieldName(col.ColumnName) != null)
//                                    m_gridView.SetFocusedRowCellValue(m_gridView.Columns[col.ColumnName], drKode[col.ColumnName]);
                                GridColumn temp = Utility.GetColumnByCaption(m_gridView, col.ColumnName);
                                if (temp != null)
                                {
                                    m_gridView.SetFocusedRowCellValue(temp, drKode[col.ColumnName]);
                                }
                            }
                        }

                       // if (m_descColumn != "")
                       //     m_gridView.SetFocusedRowCellValue(m_gridView.Columns[m_descColumn], drKode["name"]);
                    }
                }
                else
                {
                    // adding new row(s)
                    foreach (DataRow drKode in frmDialog.ResultRows)
                    {
                        m_gridView.AddNewRow();

                        object newRow = m_gridView.GetRow(m_gridView.FocusedRowHandle);
                        
                        m_gridView.SetFocusedRowCellValue(m_gridView.Columns[m_field], drKode[0]);
                        if (m_autoFill)
                        {
                            foreach (DataColumn col in frmDialog.DataSource.Columns)
                            {
                               // if (m_gridView.Columns.ColumnByFieldName(col.ColumnName) != null)
                               //     m_gridView.SetFocusedRowCellValue(m_gridView.Columns[col.ColumnName], drKode[col.ColumnName]);
                                GridColumn temp = Utility.GetColumnByCaption(m_gridView, col.ColumnName);
                                if (temp != null)
                                {
                                    m_gridView.SetFocusedRowCellValue(temp, drKode[col.ColumnName]);
                                }
                            }
                        }
                        //if (m_descColumn != "")
                        //    m_gridView.SetFocusedRowCellValue(m_gridView.Columns[m_descColumn], drKode["name"]);

                        //Accept the new row
                        //The row moves to a new position according to the current group settings
                        m_gridView.UpdateCurrentRow();
                        //Locate the new row
                        for (int n = 0; n < m_gridView.DataRowCount; n++)
                        {
                            if (m_gridView.GetRow(n).Equals(newRow))
                                m_gridView.FocusedRowHandle = n;
                        }
                    }
                }

                //m_gridView.BestFitColumns();
            }
        }

        void GridLookUpEx_Leave(object sender, EventArgs e)
        {
            if (!m_autoFill) return;
            if ((sender as TextEdit).EditValue == null) return;

            string query = m_query;
            if (query == "") query = "select * from " + m_table;

            DataTable dtTemp = m_sql.Select(query);

            DataRow[] drSelect = dtTemp.Select("`" + dtTemp.Columns[0].ColumnName + "`='" + (sender as TextEdit).EditValue.ToString() + "'");

            if (drSelect.Length == 1)
            {
                DataRow drKode = drSelect[0];
                {
                    foreach (DataColumn col in dtTemp.Columns)
                    {
                        GridColumn temp = Utility.GetColumnByCaption(m_gridView, col.ColumnName);
                        if (temp != null)
                        {
                            m_gridView.SetFocusedRowCellValue(temp, drKode[col.ColumnName]);
                        }
                    }
                }
            }
     //       m_gridView.BestFitColumns();
        }
    }
}
