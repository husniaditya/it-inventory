using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KASLibrary;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;

namespace CAS.Transaction
{
    public partial class FrmTStr : BaseTransaction
    {
        public FrmTStr()
        {
            InitializeComponent();

            Utility.SetSqlInstance(pnlDetail, DB.sql);

            gcStd.ExGridControl.DataSource = stdBindingSource;

            InitializeGridControl();

            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
        }

        private void FrmTStr_Load(object sender, EventArgs e)
        {

        }

        private void InitializeGridControl()
        {
            gcStd.ExTitleLabel.Text = "Detail Giro";
            gcStd.ExGridView.Columns["nobg"].Caption = "No BG";
            gcStd.ExGridView.Columns["bank"].Caption = "Bank";
            gcStd.ExGridView.Columns["date"].Caption = "Date";
            gcStd.ExGridView.Columns["duedate"].Caption = "Due Date";
            gcStd.ExGridView.Columns["acbank"].Caption = "AC Bank";
            gcStd.ExGridView.Columns["val"].Caption = "Nilai";

            gcStd.ExGridView.Columns["str"].Visible = false;
            gcStd.ExGridView.Columns["no"].Visible = false;

            gcStd.ExGridView.OptionsBehavior.Editable = false;
            gcStd.ExGridView.OptionsSelection.MultiSelect = true;
            gcStd.ExGridView.OptionsCustomization.AllowSort = false;
            gcStd.ExGridView.OptionsView.ShowGroupPanel = false;

            //gcStd.ExGridView.Columns["nobg"].ColumnEdit = new GridLookUpEx(DB.sql, "", "", "", gcStd.ExGridView, "", false, false, "");
            gcStd.ExGridView.Columns["nobg"].ColumnEdit = new RepositoryItemTextEdit();
            gcStd.ExGridView.Columns["val"].ColumnEdit = new GridNumEx();

            gcStd.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
            gcStd.ExGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(ExGridView_InitNewRow);
        }

        void ExGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gcStd.ExGridView.GetDataRow(e.RowHandle);
            row["str"] = NoDocument;
            row["nobg"] = "";
            row["no"] = DB.GetRowCount(DetailTable) + 1;
        }

        void ExGridView_New_Click(object sender, EventArgs e)
        {
            DataRow row = casDataSet.kag.NewRow();
            row["str"] = NoDocument;
            row["val"] = 0;
            row["nobg"] = "";
            row["acbank"] = "";
            row["bank"] = "";
            row["duedate"] = Utility.LastDateInMonth(DB.loginDate);
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            casDataSet.kag.Rows.Add(row);

            DB.InsertDetailRows(gcStd.ExGridView, row);
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            DetailTable.Clear();
            gcStd.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcStd.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcStd.ExGridView.OptionsBehavior.Editable = true;
            gcStd.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
        }

        protected override void tsbtnCancel_Click(object sender, EventArgs e)
        {
            DB.CancelDetailRows(DetailTable);

            base.tsbtnCancel_Click(sender, new EventArgs());

            if (this.mode == Mode.View)
            {
                gcStd.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                gcStd.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                gcStd.ExGridView.OptionsBehavior.Editable = false;
                gcStd.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            }
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            gcStd.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcStd.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcStd.ExGridView.OptionsBehavior.Editable = true;
            gcStd.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidateChildren();
                DetailBindingSource.EndEdit();

                DataTable checkKAG = new DataTable();
                checkKAG = DB.sql.Select("select * from kag");
                    
                for (int i = 0; i < DetailTable.Rows.Count; i++)
                {
                    DataRow[] selectBG = DetailTable.Select("nobg='" + DetailTable.Rows[i]["nobg"].ToString() + "'");
                    if (selectBG.Length > 1)
                    {
                        throw new Exception("No Bg: " + DetailTable.Rows[i]["nobg"].ToString() + " tidak bisa diinput lebih dari sekali!");
                    }

                    DataRow[] selectKAG = checkKAG.Select("nobg='" + DetailTable.Rows[i]["nobg"].ToString() + "'");
                    if (selectKAG.Length > 0)
                    {
                        throw new Exception("No Bg: " + DetailTable.Rows[i]["nobg"].ToString() + " sudah pernah diinput di database");
                    }
                }
                
                base.tsbtnSave_Click(sender, e);

                gcStd.ExGridView.OptionsBehavior.Editable = false;
                gcStd.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                gcStd.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                gcStd.ExToolStrip.Items["tsbtnNew"].Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}