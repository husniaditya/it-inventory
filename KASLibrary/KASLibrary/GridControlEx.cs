using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.XtraEditors.Repository; 
using DevExpress.XtraGrid;  
using DevExpress.XtraGrid.Views.Grid;
using System.Collections;
using DevExpress.XtraGrid.Menu;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Views.Grid.ViewInfo; 

namespace KASLibrary
{
    public partial class GridControlEx : UserControl
    {
        private bool autoGrow;
        private bool bestFitColumn;
        private ArrayList visibleCols;

        public GridControl ExGridControl
        {
            get { return gridControl; }
        }

        public GridView ExGridView
        {
            get { return gridView; }
        }

        public Label ExTitleLabel
        {
            get { return lblTitle; }
        }

        public bool ExAutoSize
        {
            get { return autoGrow; }
            set { autoGrow = value; }
        }

        public bool BestFitColumn
        {
            get { return bestFitColumn; }
            set { bestFitColumn = value; }
        }

        public ToolStrip ExToolStrip
        {
            get { return toolStrip1; }
        }

        public StatusStrip ExStatusStrip
        {
            get { return statusStrip1; }
        }

        public GridControlEx()
        {
            InitializeComponent();
            autoGrow = false;
            bestFitColumn = true;
            gridControl.DataSourceChanged += new EventHandler(gridControl_DataSourceChanged);
            tsmiShowGroupHeader.Checked = gridView.OptionsView.ShowGroupPanel;
            tsmiShowFilterRow.Checked = gridView.OptionsView.ShowAutoFilterRow;
        }

        private void gridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tslblRow.Text = gridView.RowCount.ToString() + " row(s) returned. " +
                gridView.SelectedRowsCount + " row(s) selected."; 
        }

        private void gridControl_DataSourceChanged(object sender, EventArgs e)
        {
            if (gridControl.DataSource == null)
            {
                tslblRow.Text = "0 row(s) returned. 0 row(s) selected."; 
                return;
            }
            gridView = new GridView();
            gridControl.MainView = gridView; 
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsView.ColumnAutoWidth = false;
            gridView.OptionsSelection.MultiSelect = true;
            gridView.OptionsSelection.UseIndicatorForSelection = true;
            gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView.SelectionChanged += new SelectionChangedEventHandler(gridView_SelectionChanged);
            gridView.ColumnFilterChanged += new EventHandler(gridView_ColumnFilterChanged);
            gridView.MouseUp += new MouseEventHandler(gridView_MouseUp);
            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                if (gridView.Columns[i].ColumnType == typeof(UInt64))
                {
                    RepositoryItemCheckEdit riCheckEdit = new RepositoryItemCheckEdit();
                    riCheckEdit.ValueChecked = (UInt64)1;
                    riCheckEdit.ValueUnchecked = (UInt64)0;
                    gridView.Columns[i].ColumnEdit = riCheckEdit;  
                }
                if (gridView.Columns[i].ColumnType == typeof(DateTime))
                {
                    gridView.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                    if (Utility.GetConfig("LanguageID") != "")
                        gridView.Columns[i].DisplayFormat.Format = System.Globalization.CultureInfo.CreateSpecificCulture(Utility.GetConfig("LanguageID")).DateTimeFormat;
                    if (Utility.GetConfig("DateFormat") != "")
                        gridView.Columns[i].DisplayFormat.FormatString = Utility.GetConfig("DateFormat");
                }
            }
            
            if (bestFitColumn)
                gridView.BestFitColumns();

            if (autoGrow)
            {
                int totalWidth = 0;
                for (int i = 0; i < gridView.Columns.Count; i++)
                    totalWidth += gridView.Columns[i].VisibleWidth;
                if(totalWidth+50 > this.Width)   
                    this.Width = totalWidth + 50;
            }

            tslblRow.Text = gridView.RowCount.ToString() + " row(s) returned. " +
                gridView.SelectedRowsCount + " row(s) selected."; 
        }

        void gridView_ColumnFilterChanged(object sender, EventArgs e)
        {
            tslblRow.Text = gridView.RowCount.ToString() + " row(s) returned. " +
                gridView.SelectedRowsCount + " row(s) selected."; 
        }

        private void tsbtnSelectAll_ButtonClick(object sender, EventArgs e)
        {
            gridView.SelectAll();
            if (gridView.Columns.ColumnByFieldName("Check") != null)
            {
                for (int i=0;i<gridView.RowCount;i++)
                {
                    gridView.GetDataRow(i)["Check"] = true;
                }
            }
        }

        private void tsmiSelectNone_Click(object sender, EventArgs e)
        {
            UnselectAll();
        }

        public void UnselectAll()
        {
            if (gridView.SelectedRowsCount > 0)
            {
                foreach (int rowHandle in gridView.GetSelectedRows())
                    gridView.UnselectRow(rowHandle);
            }
            if (gridView.Columns.ColumnByFieldName("Check") != null)
            {
                for (int i = 0; i < gridView.RowCount; i++)
                {
                    gridView.GetDataRow(i)["Check"] = false;
                }
            }
        }

        private void tsmiSelectInverse_Click(object sender, EventArgs e)
        {
            if (gridView.Columns.ColumnByFieldName("Check") != null)
            {
                for (int i = 0; i < gridView.RowCount; i++)
                {
                    gridView.GetDataRow(i)["Check"] = !(Convert.ToBoolean(gridView.GetDataRow(i)["Check"]));
                    if (Convert.ToBoolean(gridView.GetDataRow(i)["Check"]))
                        gridView.SelectRow(i);
                    else
                        gridView.UnselectRow(i);
                }
            }
            else
            {
                for (int i = 0; i < gridView.RowCount; i++)
                {
                    gridView.InvertRowSelection(i);
                }
            }
        }

        private void saveToolStripButton_ButtonClick(object sender, EventArgs e)
        {
            savFile.FileName = "";
            savFile.Filter = "Excel File|*.xls|Text File|*.txt|HTML File|*.html";
            ExportGrid();
        }

        private void tsmiSaveExcel_Click(object sender, EventArgs e)
        {
            savFile.FileName = "";
            savFile.Filter = "Excel File|*.xls";
            ExportGrid();
        }

        private void tsmiSaveText_Click(object sender, EventArgs e)
        {
            savFile.FileName = "";
            savFile.Filter = "Text File|*.txt";
            ExportGrid();
        }

        private void tsmiSaveHTML_Click(object sender, EventArgs e)
        {
            savFile.FileName = "";
            savFile.Filter = "HTML File|*.html";
            ExportGrid();
        }

        private void ExportGrid()
        {
            if (savFile.ShowDialog() == DialogResult.OK)
            {
                string fileName = savFile.FileName;
                if (fileName.EndsWith("xls"))
                {
                    gridView.ExportToExcel(fileName);
                }
                else if (fileName.EndsWith("txt"))
                {
                    gridView.ExportToText(fileName);
                }
                else if (fileName.EndsWith("html"))
                {
                    gridView.ExportToHtml(fileName);
                }
            }
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            gridControl.ShowPrintPreview();
        }

        private void tsmiCopyCell_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView.FocusedValue != null)
                    Clipboard.SetText(gridView.FocusedValue.ToString());
            }
            catch { }
        }

        private void tsmiCopyRow_Click(object sender, EventArgs e)
        {
            try
            {
                gridView.CopyToClipboard();
            }
            catch { }
        }

        private void tsmiShowFilterRow_CheckedChanged(object sender, EventArgs e)
        {
            gridView.OptionsView.ShowAutoFilterRow = tsmiShowFilterRow.Checked;
        }

        private void tsmiShowGroupHeader_CheckedChanged(object sender, EventArgs e)
        {
            gridView.OptionsView.ShowGroupPanel = tsmiShowGroupHeader.Checked;
        }

        private void tsmiShowColumnChooser_Click(object sender, EventArgs e)
        {
            gridView.ColumnsCustomization();
        }

        private void tsmiShowAllColumns_CheckedChanged(object sender, EventArgs e)
        {
            if (tsmiShowAllColumns.Checked)
            {
                visibleCols = new ArrayList(gridView.VisibleColumns.Count);
                for (int i = 0; i < gridView.Columns.Count; i++)
                {
                    if (gridView.Columns[i].Visible) 
                        visibleCols.Add(i);
                    else
                        gridView.Columns[i].Visible = true;
                }
            }
            else
            {
                for (int i = 0; i < gridView.Columns.Count; i++)
                {
                    if (!visibleCols.Contains(i))
                        gridView.Columns[i].Visible = false;
                }
            }
        }

        void gridView_MouseUp(object sender, MouseEventArgs e)
        {
            // obtaining hit info
            GridHitInfo hitInfo = gridView.CalcHitInfo(new Point(e.X, e.Y));
            if (e.Button == MouseButtons.Right && (hitInfo.InRow && hitInfo.InRowCell) && (!gridView.IsGroupRow(hitInfo.RowHandle)))
            {
                // switching focus
                gridView.UnselectRow(gridView.FocusedRowHandle);
                gridView.SelectRow(hitInfo.RowHandle);

                // showing the custom context menu
                ViewMenu menu = new ViewMenu(gridView);
                DXMenuItem menuItem = new DXMenuItem("Copy Cell", new EventHandler(gridView_RClick_Copy));
                menu.Items.Add(menuItem);
                menuItem = new DXMenuItem("Copy Row", new EventHandler(gridView_RClick_Copy));
                menu.Items.Add(menuItem);
                menu.Show(hitInfo.HitPoint);
            }
        }

        void gridView_RClick_Copy(object sender, EventArgs e)
        {
            try
            {
                DXMenuItem menuItem = sender as DXMenuItem;
                if (menuItem == null) return;

                if (menuItem.Caption == "Copy Cell")
                    Clipboard.SetText(gridView.FocusedValue.ToString());
                else
                    gridView.CopyToClipboard();
            }
            catch { }
        }
    }
}
