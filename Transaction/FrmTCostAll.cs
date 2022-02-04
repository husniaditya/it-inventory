using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using KASLibrary;
using DevExpress.XtraReports.UI;

namespace CAS.Transaction
{
    public partial class FrmTCostAll : CAS.Master.BaseMaster
    {
        MySqlDataAdapter daCtd = new MySqlDataAdapter();
        int prevRowHandle = 0;

        public FrmTCostAll()
        {
            InitializeComponent();
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
            tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnDelete.Click += new EventHandler(tsbtnDelete_Click);
            gcCtd.ExGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(ExGridView_FocusedRowChanged);
            gcCtd.ExGridView.OptionsSelection.MultiSelect = true;
            SetEditableGridControl(false);
            
            MasterQuery = "select * from " + MasterTable.TableName + " where period='" + DB.loginPeriod + "'";

            ToolStripMenuItem tsmiPrintPreview = new ToolStripMenuItem("Print Preview", null, new EventHandler(tsmiPrintPreview_Click));
            ToolStripMenuItem tsmiPrintDirectly = new ToolStripMenuItem("Print Directly", null, new EventHandler(tsmiPrintDirectly_Click));
            ToolStripDropDownButton tsbtnPrint = new ToolStripDropDownButton("Print", null, tsmiPrintPreview, tsmiPrintDirectly);
            tsbtnPrint.Image = MasterNavigator.Items["tsbtnPrint"].Image;
            MasterNavigator.Items.Insert(MasterNavigator.Items.IndexOfKey("tsbtnPrint"), tsbtnPrint);
            MasterNavigator.Items.RemoveByKey("tsbtnPrint");
        }

        void tsmiPrintDirectly_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepCostAll" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("select ctd.*, cfit3 from cta left outer join ctd on cta.period=ctd.period and cta.cct=ctd.cct where cta.period='" + DB.loginPeriod + "' and cta.cct='" + txtCct.Text + "'");
            report.DataSource = dt;
            report.Bands[BandKind.ReportHeader].Controls["xrLabelCostCenter"].Text = "COST CENTER : " + txtCct.ExLabelText;
            report.Bands[BandKind.ReportHeader].Controls["xrLabelPeriod"].Text = "PERIODE : " + DB.loginDate.ToString("MMMM yyyy").ToUpper();

            report.Bands[BandKind.GroupFooter].Controls["xrLabelCounter"].Text = Convert.ToDecimal(txtCounter.EditValue).ToString("#,#"); ;
            report.Bands[BandKind.GroupFooter].Controls["xrLabelActual"].Text = Convert.ToDecimal(txtActual.EditValue).ToString("#,#"); ;
            report.Bands[BandKind.GroupFooter].Controls["xrLabelWaste"].Text = Convert.ToDecimal(txtWaste.EditValue).ToString("#,#"); ;
            report.Bands[BandKind.GroupFooter].Controls["xrLabelWastePersen"].Text = Convert.ToDecimal(txtWastePersen.EditValue).ToString("#.## '%");

            report.Bands[BandKind.PageFooter].Controls["xrLabelUser"].Text = DB.casUser.Name;

            report.PrintingSystem.ShowMarginsWarning = false;
            report.PaperName = "A4";
            report.Print();
        }

        void tsmiPrintPreview_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepCostAll" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("select ctd.*, cfit3 from cta left outer join ctd on cta.period=ctd.period and cta.cct=ctd.cct where cta.period='" + DB.loginPeriod + "' and cta.cct='" + txtCct.Text + "'");
            report.DataSource = dt;
            report.Bands[BandKind.ReportHeader].Controls["xrLabelCostCenter"].Text = "COST CENTER : " + txtCct.ExLabelText;
            report.Bands[BandKind.ReportHeader].Controls["xrLabelPeriod"].Text = "PERIODE : " + DB.loginDate.ToString("MMMM yyyy").ToUpper();

            report.Bands[BandKind.GroupFooter].Controls["xrLabelCounter"].Text = Convert.ToDecimal(txtCounter.EditValue).ToString("#,#"); ;
            report.Bands[BandKind.GroupFooter].Controls["xrLabelActual"].Text = Convert.ToDecimal(txtActual.EditValue).ToString("#,#"); ;
            report.Bands[BandKind.GroupFooter].Controls["xrLabelWaste"].Text = Convert.ToDecimal(txtWaste.EditValue).ToString("#,#"); ;
            report.Bands[BandKind.GroupFooter].Controls["xrLabelWastePersen"].Text = Convert.ToDecimal(txtWastePersen.EditValue).ToString("#.## '%");
            
            report.Bands[BandKind.PageFooter].Controls["xrLabelUser"].Text = DB.casUser.Name;
            report.ShowPreview();
        }

        void ExGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(e.FocusedRowHandle == gcCtd.ExGridView.RowCount - 1) 
                prevRowHandle = e.PrevFocusedRowHandle;
        }

        void SetEditableGridControl(bool mode)
        {
            gcCtd.ExGridView.OptionsBehavior.Editable = mode;
            gcCtd.ExToolStrip.Items["tsbtnDelete"].Enabled = mode;
            if (mode == false) return;
            
            for (int i = 0; i < gcCtd.ExGridView.Columns.Count; i++)
            {
                gcCtd.ExGridView.Columns[i].OptionsColumn.AllowEdit =
                    (gcCtd.ExGridView.Columns[i].Name == "colpricebox");
                gcCtd.ExGridView.Columns[i].OptionsFilter.AllowFilter = false;
                gcCtd.ExGridView.Columns[i].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            }
        }       
      
        void tsbtnDelete_Click(object sender, EventArgs e)
        {/*
            if (gcCtd.ExGridView.OptionsBehavior.Editable)
                SetEditableGridControl(false);
           */
            if (MessageBox.Show("Are you sure you want to delete this item?", "Confirmation",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                DB.sql.Execute("delete from cta where period='" + txtPeriod.Text + "' and cct='" + txtCct.Text + "'");
                DB.sql.Execute("delete from ctd where period='" + txtPeriod.Text + "' and cct='" + txtCct.Text + "'");

                MessageBox.Show("Join Cost, Cost Center: " + txtCct.Text + " periode ini Berhasil Dihapus");
                ////tsbtnLast.PerformClick();
                tsbtnRefresh.PerformClick();
            }
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            txtCct.ExSqlQuery = "select * from cct where cct like '111%' and cct not in " +
                        " (select distinct cct from cta where period='" + DB.loginPeriod + "' ) ";

            ctdBindingSource.AllowNew = false;
            SetEditableGridControl(true);
            gcCtd.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;

            Utility.SetReadOnly(pnlDetail, true);
        }

        void tsbtnCancel_Click(object sender, EventArgs e)
        {
            if (gcCtd.ExGridView.OptionsBehavior.Editable)
            {
                //gcKhr.ExGridView.CancelUpdateCurrentRow();
                //curTextEdit_EditValueChanged(sender, new EventArgs());
                casDataSet.ctd.RejectChanges();
                //khrBindingSource.CancelEdit();
                try
                {
                    SetEditableGridControl(false);
                    gcCtd.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                }
                catch { }
            }
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();
            if (gcCtd.ExGridView.EditingValue != null)
                gcCtd.ExGridView.SetFocusedValue(gcCtd.ExGridView.EditingValue);
            ctdBindingSource.EndEdit();

            if (txtCct.Text == "" || !txtCct.ExIsValid())
            {
                MessageBox.Show("Cost Center belum dipilih", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRow[] drError = casDataSet.ctd.GetErrors();
            if (drError.Length > 0)
            {
                MessageBox.Show("Masih ada nilai yang Error pada Grid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (casDataSet.ctd.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada data inventory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                daCtd.Update(casDataSet.ctd);
                base.tsbtnSave_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Proses simpan data gagal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            SetEditableGridControl(false);
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            txtCct.ExSqlQuery = "select * from cct where cct='" + txtCct.Text + "'";

            //khrBindingSource.AllowNew = true;
            SetEditableGridControl(true);
            gcCtd.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;

            Utility.SetReadOnly(pnlDetail, true);
        }
        
        private void FrmTCostAll_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'casDataSet.ctd' table. You can move, or remove it, as needed.
            //this.ctdTableAdapter.Fill(this.casDataSet.ctd);
            // TODO: This line of code loads data into the 'casDataSet.ctd' table. You can move, or remove it, as needed.
            //this.ctdTableAdapter.Fill(this.casDataSet.ctd);
            DataTable dtPlant;
            dtPlant = DB.sql.Select("select * from plant");
            for (int i = 0; i < dtPlant.Rows.Count; i++)
            {
                plantComboBox.Items.Add(dtPlant.Rows[i][1].ToString());
            }
    
            txtCct.ExSqlInstance = DB.sql;
            gcCtd.ExTitleLabel.Visible = false;
            gcCtd.ExToolStrip.Items["tsbtnNew"].Enabled = false;
            gcCtd.ExGridView.OptionsBehavior.Editable = false;
            gcCtd.ExGridView.OptionsView.ShowGroupPanel = false;

            txtPeriod.Properties.ReadOnly = true;
            txtCfit3.Properties.ReadOnly = true;
            RefreshGrid();
            mode = Mode.View;
            setMode(Mode.View);

            if (MasterTable.Rows.Count == 0)
            {
                mode = Mode.New;
                MasterBindingSource.CancelEdit();
                MasterBindingSource.AddNew();
                setMode(Mode.New);
                Utility.SetReadOnly(pnlKey, false);
                Utility.FocusFirstTextBox(pnlKey);
                Utility.ClearTexts(pnlDetail);
                tsbtnNew_Click(this, new EventArgs());
            }
        }

        public void SetNumberFormat(GridView gridView)
        {
            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                if (gridView.Columns[i].FieldName == "pricebox" ||
                    gridView.Columns[i].FieldName == "pricepcs" ||
                    gridView.Columns[i].FieldName == "tsalespcs" ||
                    gridView.Columns[i].FieldName == "qtybox" ||
                    gridView.Columns[i].FieldName == "qtypcs" ||
                    gridView.Columns[i].FieldName == "perbox" ||
                    gridView.Columns[i].FieldName == "costall" ||
                    gridView.Columns[i].FieldName == "gross")
                {
                    gridView.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    if (Utility.GetConfig("LanguageID") != "")
                        gridView.Columns[i].DisplayFormat.Format = System.Globalization.CultureInfo.CreateSpecificCulture(Utility.GetConfig("LanguageID")).NumberFormat;
                    gridView.Columns[i].DisplayFormat.FormatString = "n";
                }
                else if (gridView.Columns[i].FieldName == "costperbox" || gridView.Columns[i].FieldName == "Btl"||
                    gridView.Columns[i].FieldName == "costperpcs")
                {
                    gridView.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    if (Utility.GetConfig("LanguageID") != "")
                        gridView.Columns[i].DisplayFormat.Format = System.Globalization.CultureInfo.CreateSpecificCulture(Utility.GetConfig("LanguageID")).NumberFormat;
                    gridView.Columns[i].DisplayFormat.FormatString = "n2";
                }
                else if (gridView.Columns[i].FieldName == "persensales" ||
                    gridView.Columns[i].FieldName == "ratio")
                {
                    gridView.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    if (Utility.GetConfig("LanguageID") != "")
                        gridView.Columns[i].DisplayFormat.Format = System.Globalization.CultureInfo.CreateSpecificCulture(Utility.GetConfig("LanguageID")).NumberFormat;
                    gridView.Columns[i].DisplayFormat.FormatString = "{0:###.##}%";
                }
            }
        }

        private void LayoutGrid()
        {
            SetNumberFormat(gcCtd.ExGridView);
            gcCtd.ExGridView.Columns["pricebox"].AppearanceCell.BackColor = Color.LightBlue;
            gcCtd.ExGridView.Columns["period"].Visible = false;
            gcCtd.ExGridView.Columns["cct"].Visible = false;

            gcCtd.ExGridView.Columns["inv"].Caption = "Product#";
            gcCtd.ExGridView.Columns["remark"].Caption = "Product Name";
            gcCtd.ExGridView.Columns["qtybox"].Caption = "Qty/TON";
            gcCtd.ExGridView.Columns["qtypcs"].Caption = "Qty/KG";
            gcCtd.ExGridView.Columns["perbox"].Caption = "Pcs/TON";
            gcCtd.ExGridView.Columns["pricepcs"].Caption = "Price/KG";
            gcCtd.ExGridView.Columns["pricebox"].Caption = "Price/TON";
            gcCtd.ExGridView.Columns["tsalespcs"].Caption = "Total Sales/KG";
            gcCtd.ExGridView.Columns["persensales"].Caption = "% Sales";
            gcCtd.ExGridView.Columns["costall"].Caption = "Cost Allocation";
            gcCtd.ExGridView.Columns["costperbox"].Caption = "Cost/TON";
            gcCtd.ExGridView.Columns["costperpcs"].Caption = "Cost/KG";
            gcCtd.ExGridView.Columns["gross"].Caption = "Profit";
            gcCtd.ExGridView.Columns["ratio"].Caption = "% Profit";
            if (txtCct.Text == "111104" || txtCct.Text == "111103" || txtCct.Text == "111116" || txtCct.Text == "111117" || txtCct.Text == "111118" || txtCct.Text == "111119")
            {
                gcCtd.ExGridView.Columns["perbox"].Caption = "Pcs";
                gcCtd.ExGridView.Columns["pricepcs"].Caption = "Price/Pcs";
                gcCtd.ExGridView.Columns["qtypcs"].Caption = "Qty/Pcs";
                gcCtd.ExGridView.Columns["qtybox"].Caption = "Qty/Pcs";
                gcCtd.ExGridView.Columns["pricebox"].Caption = "Price/Pcs";
                 gcCtd.ExGridView.Columns["qtybox"].Caption = "Qty/Pcs";
                gcCtd.ExGridView.Columns["costperbox"].Caption = "Cost/Pcs";

                if (txtCct.Text == "111103")
                {
                    gcCtd.ExGridView.Columns["perbox"].Caption = "Kg";
                    gcCtd.ExGridView.Columns["pricepcs"].Caption = "Price/Kg";
                    gcCtd.ExGridView.Columns["qtypcs"].Caption = "Qty/Kg";
                    gcCtd.ExGridView.Columns["qtybox"].Caption = "Qty/Kg";
                    gcCtd.ExGridView.Columns["pricebox"].Caption = "Price/Kg";
                    gcCtd.ExGridView.Columns["qtybox"].Caption = "Qty/Kg";
                    gcCtd.ExGridView.Columns["costperbox"].Caption = "Cost/Kg";
                }

            }
            if (txtCct.Text == "111113")
            {
                gcCtd.ExGridView.Columns["perbox"].Caption = "Btl";
                gcCtd.ExGridView.Columns["pricepcs"].Caption = "Price/Kg";
                gcCtd.ExGridView.Columns["qtypcs"].Caption = "Qty/Kg";
                gcCtd.ExGridView.Columns["qtybox"].Caption = "Qty/Btl";
                gcCtd.ExGridView.Columns["pricebox"].Caption = "Price/Btl";
                gcCtd.ExGridView.Columns["costperbox"].Caption = "Cost/Btl";
            }
            if (txtCct.Text == "111114")
            {
                gcCtd.ExGridView.Columns["perbox"].Caption = "Pouch";
                gcCtd.ExGridView.Columns["pricepcs"].Caption = "Price/Pouch";
                gcCtd.ExGridView.Columns["qtypcs"].Caption = "Qty/Pouch";
                gcCtd.ExGridView.Columns["qtybox"].Caption = "Qty/Pouch";
                gcCtd.ExGridView.Columns["pricebox"].Caption = "Price/Pouch";
                gcCtd.ExGridView.Columns["costperbox"].Caption = "Cost/Pouch";
                gcCtd.ExGridView.Columns["costperpcs"].Caption = "Cost/Pouch";
            }
            if (txtCct.Text == "111110" || txtCct.Text == "111122")
            {
                gcCtd.ExGridView.Columns["perbox"].Caption = "Dos";
                gcCtd.ExGridView.Columns["pricepcs"].Caption = "Price/Kg";
                gcCtd.ExGridView.Columns["qtypcs"].Caption = "Qty/Kg";
                gcCtd.ExGridView.Columns["qtybox"].Caption = "Qty/Dos";
                gcCtd.ExGridView.Columns["pricebox"].Caption = "Price/Dos";
                gcCtd.ExGridView.Columns["costperbox"].Caption = "Cost/Dos";
                gcCtd.ExGridView.Columns["costperpcs"].Caption = "Cost/Kg";
            }

            gcCtd.ExGridView.OptionsView.ShowFooter = true;
            gcCtd.ExGridView.Columns["qtybox"].SummaryItem.DisplayFormat = "{0:###,##}";
            gcCtd.ExGridView.Columns["qtybox"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gcCtd.ExGridView.Columns["qtypcs"].SummaryItem.DisplayFormat = "{0:###,##}";
            gcCtd.ExGridView.Columns["qtypcs"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gcCtd.ExGridView.Columns["tsalespcs"].SummaryItem.DisplayFormat = "{0:###,##}";
            gcCtd.ExGridView.Columns["tsalespcs"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;

            gcCtd.ExGridView.Columns["persensales"].SummaryItem.DisplayFormat = "{0:###,##}%";
            gcCtd.ExGridView.Columns["persensales"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gcCtd.ExGridView.Columns["costall"].SummaryItem.DisplayFormat = "{0:###,##}";
            gcCtd.ExGridView.Columns["costall"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gcCtd.ExGridView.Columns["ratio"].SummaryItem.DisplayFormat = "{0:###.##}";
           
            gcCtd.ExGridView.Columns["remark"].SummaryItem.DisplayFormat = "TOTAL";
            gcCtd.ExGridView.Columns["remark"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Max;

            gcCtd.ExGridView.BestFitColumns();
            /*
            gcCtd.ExGridView.OptionsBehavior.Editable = true;
            for (int i = 0; i < gcCtd.ExGridView.Columns.Count; i++)
            {
                gcCtd.ExGridView.Columns[i].OptionsColumn.AllowEdit =
                    (gcCtd.ExGridView.Columns[i].Name == "colpricebox" && mode != Mode.View);
                gcCtd.ExGridView.Columns[i].OptionsFilter.AllowFilter = false;
                gcCtd.ExGridView.Columns[i].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            }
             */

            txtActual.Value = 0;
            string tactual = gcCtd.ExGridView.Columns["qtypcs"].SummaryText;
            if (tactual != "") txtActual.Value = Convert.ToDecimal(tactual);
            txtWaste.Value = txtCounter.Value - txtActual.Value;
            if (txtCounter.Value!=0)
            txtWastePersen.Value = txtWaste.Value * 100 / txtCounter.Value;
        }

        private void txtCct_EditValueChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        void RefreshGrid()
        {
            casDataSet.ctd.Clear();
            daCtd = DB.sql.SelectAdapter("Select * from ctd where period='" + txtPeriod.Text + "' and cct='" + txtCct.Text + "'");
            daCtd.Fill(casDataSet.ctd);
            gcCtd.ExGridControl.DataSource = ctdBindingSource;

            txtCounter.EditValue = 0;
            DataTable dtCounter = DB.sql.Select("select qsip from kkh where period='" + DB.loginPeriod + "' and cct='" + txtCct.Text + "'");
            if (dtCounter.Rows.Count > 0)
            {
                decimal tcounter = Convert.ToDecimal(dtCounter.Rows[0][0]);
                txtCounter.EditValue = tcounter;
            }

            if (mode == Mode.View)
                txtCct.ExSqlQuery = "select * from cct where cct like '111%'";

            LayoutGrid();
            //casDataSet.ctd.RowChanging += new DataRowChangeEventHandler(dtCtd_RowChanging);
            casDataSet.ctd.ColumnChanged += new DataColumnChangeEventHandler(dtCtd_ColumnChanged);

            if (mode != Mode.New) return;
            txtPeriod.Text = DB.loginPeriod;
            casDataSet.ctd.RejectChanges();

            string sqltext = "";
        
            sqltext = " select inv.inv, inv.name, sum(lhd.qty) as qtypcs, sum(lhd.qty)/if(konversi.konversi is null,1,konversi.konversi) as qtybox, " +
                "   if(konversi.konversi is null,1,konversi.konversi) as perbox, " +
                "   (select ifnull(sum(cfitf3),0) from kkh where period='" + DB.loginPeriod + "' " +
                "     and cct='" + txtCct.Text + "') as cfit3 " +
                " from cct, lhp, (lhd left outer join inv on lhd.inv=inv.inv) " +
                "   left outer join konversi on inv.inv=konversi.inv " +
                " where if(('" + txtCct.Text + "'='111103' or '" + txtCct.Text + "' = '111104' or '" + txtCct.Text + "' = '111114' or '" + txtCct.Text + "' = '111117' or '" + txtCct.Text + "' = '111118' or '" + txtCct.Text + "' = '111116' or '" + txtCct.Text + "' = '111119'  or '" + txtCct.Text + "' = '111120'  or '" + txtCct.Text + "' = '111121') " +
                " ,konversi.unit=inv.unit,if('" + txtCct.Text + "' = '111113' or '" + txtCct.Text + "' = '111110' or '" + txtCct.Text + "' = '111122',konversi.unit=inv.unit2,konversi.unit='TON')) and (inv.inv like '4%' OR inv.inv like '3%' or inv.inv like '2%') and cct.cct='" + txtCct.Text + "' " +
                "   and lhp.lhp=lhd.lhp and lhp.cct=cct.cct and lhp.period='" + DB.loginPeriod + "' " +
                " and lhp.`delete` = 0 group by inv.inv order by inv.inv ";
                      DataTable dtTemp = DB.sql.Select(sqltext);

            double cfit3 = 0;
            if (dtTemp.Rows.Count > 0)
            {
                cfit3 = (double)dtTemp.Rows[0]["cfit3"];
                txtCfit3.Text = cfit3.ToString();
            }

            for (int i = 0; i < dtTemp.Rows.Count; i++)
            {
                DataRow dr = casDataSet.ctd.NewRow();
                dr["period"] = DB.loginPeriod;
                dr["cct"] = txtCct.Text;
                dr["inv"] = dtTemp.Rows[i]["inv"];
                dr["remark"] = dtTemp.Rows[i]["name"];
                dr["qtybox"] = dtTemp.Rows[i]["qtybox"];
                dr["qtypcs"] = dtTemp.Rows[i]["qtypcs"];
                dr["perbox"] = dtTemp.Rows[i]["perbox"];
                dr["pricepcs"] = 0;
                dr["pricebox"] = 0;
                dr["tsalespcs"] = 0;
                dr["persensales"] = 0;
                dr["costall"] = 0;
                dr["costperbox"] = 0;
                dr["costperpcs"] = 0;
                dr["gross"] = 0;
                dr["ratio"] = 0.00;
                casDataSet.ctd.Rows.Add(dr);
            }
            LayoutGrid();
            casDataSet.ctd.ColumnChanged += new DataColumnChangeEventHandler(dtCtd_ColumnChanged);
        }

        void dtCtd_ColumnChanged(object sender, DataColumnChangeEventArgs e)
        {
            if (e.Column.ColumnName != "pricebox") return;
            DataRow dr = e.Row;
            if ((double)dr["perbox"] == 0) dr["pricepcs"] = 0;
            else dr["pricepcs"] = (double)dr["pricebox"] / (double)dr["perbox"];
            dr["tsalespcs"] = (double)dr["qtypcs"] * (double)dr["pricepcs"];

            double total_tsalespcs = 0;
            for (int i = 0; i < casDataSet.ctd.Rows.Count; i++)
            {
                if (casDataSet.ctd.Rows[i]["tsalespcs"].GetType() != typeof(DBNull))
                    total_tsalespcs += (double)casDataSet.ctd.Rows[i]["tsalespcs"];
            }
            for (int i = 0; i < casDataSet.ctd.Rows.Count; i++)
            {
                double tsalespcs = 0;
                if (casDataSet.ctd.Rows[i]["tsalespcs"].GetType() != typeof(DBNull)) 
                    tsalespcs = (double)casDataSet.ctd.Rows[i]["tsalespcs"];
                if (total_tsalespcs == 0) casDataSet.ctd.Rows[i]["persensales"] = 0;
                else casDataSet.ctd.Rows[i]["persensales"] = tsalespcs * 100 / total_tsalespcs;

                casDataSet.ctd.Rows[i]["costall"] = Convert.ToDouble(txtCfit3.EditValue) * (double)casDataSet.ctd.Rows[i]["persensales"] / 100;

                if ((double)casDataSet.ctd.Rows[i]["qtybox"] == 0) casDataSet.ctd.Rows[i]["costperbox"] = 0;
                else casDataSet.ctd.Rows[i]["costperbox"] = (double)casDataSet.ctd.Rows[i]["costall"] / (double)casDataSet.ctd.Rows[i]["qtybox"];

                if ((double)casDataSet.ctd.Rows[i]["perbox"] == 0) casDataSet.ctd.Rows[i]["costperpcs"] = 0;
                else casDataSet.ctd.Rows[i]["costperpcs"] = (double)casDataSet.ctd.Rows[i]["costperbox"] / (double)casDataSet.ctd.Rows[i]["perbox"];
                
                casDataSet.ctd.Rows[i]["gross"] = (double)casDataSet.ctd.Rows[i]["pricebox"] - (double)casDataSet.ctd.Rows[i]["costperbox"];

                if ((double)casDataSet.ctd.Rows[i]["pricebox"] == 0) casDataSet.ctd.Rows[i]["ratio"] = 0;
                else casDataSet.ctd.Rows[i]["ratio"] = (double)casDataSet.ctd.Rows[i]["gross"] * 100 / (double)casDataSet.ctd.Rows[i]["pricebox"];
            }

            SetEditableGridControl(true);
            gcCtd.ExGridView.BestFitColumns();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (mode != Mode.Edit) return;
              string sqltext = " select inv.inv, inv.name, sum(lhd.qty) as qtypcs, sum(lhd.qty)/if(konversi.konversi is null,1,konversi.konversi) as qtybox, " +
                "   if(konversi.konversi is null,1,konversi.konversi) as perbox, " +
                "   (select ifnull(sum(cfitf3),0) from kkh where period='" + DB.loginPeriod + "' " +
                "     and cct='" + txtCct.Text + "') as cfit3 " +
                " from cct, lhp, (lhd left outer join inv on lhd.inv=inv.inv) " +
                "   left outer join konversi on inv.inv=konversi.inv " +
                " where konversi.unit='TON' and inv.inv like '4%' and cct.cct='" + txtCct.Text + "' " +
                "   and lhp.lhp=lhd.lhp and lhp.cct=cct.cct and lhp.period='" + DB.loginPeriod + "' " +
                " group by inv.inv order by inv.inv ";
            DataTable dtTemp = DB.sql.Select(sqltext);

            double cfit3 = 0;
            if (dtTemp.Rows.Count > 0)
            {
                cfit3 = (double)dtTemp.Rows[0]["cfit3"];
                txtCfit3.Text = cfit3.ToString();
            }

            foreach (DataRow row in dtTemp.Rows)
            {
                DataRow[] drCtd = casDataSet.ctd.Select("inv='" + row["inv"] + "'");
                if (drCtd.Length > 0)
                {
                    drCtd[0]["remark"] = row["name"];
                    drCtd[0]["qtybox"] = row["qtybox"];
                    drCtd[0]["qtypcs"] = row["qtypcs"];
                    drCtd[0]["perbox"] = row["perbox"];
                }
            }
            
        }
    }
}

