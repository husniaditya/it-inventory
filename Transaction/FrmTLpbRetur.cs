using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KASLibrary;
using DevExpress.XtraReports.UI;

namespace CAS.Transaction
{
    public partial class FrmTLpbRetur : CAS.Transaction.BaseTransaction
    {
        public FrmTLpbRetur()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlDetail, DB.sql);

            ToolStripMenuItem tsmiPrintPreview = new ToolStripMenuItem("Print Preview", null, new EventHandler(tsmiPrintPreview_Click));
            ToolStripMenuItem tsmiPrintDirectly = new ToolStripMenuItem("Print Directly", null, new EventHandler(tsmiPrintDirectly_Click));
            ToolStripDropDownButton tsbtnPrint = new ToolStripDropDownButton("Print", null, tsmiPrintPreview, tsmiPrintDirectly);
            tsbtnPrint.Image = MasterNavigator.Items["tsbtnPrint"].Image;
            MasterNavigator.Items.Insert(MasterNavigator.Items.IndexOfKey("tsbtnPrint"), tsbtnPrint);
            MasterNavigator.Items.RemoveByKey("tsbtnPrint");

            DetailTable.Columns.Add("Unit Base Diterima", typeof(String));
            MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);

            gcxRkb.ExGridControl.DataSource = DetailTable;
            gcxRkb.ExTitleLabel.Text = "Detail Penerimaan Retur Barang";
            gcxRkb.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gcxRkb.ExToolStrip.Items["tsbtnNew"].Enabled = false;

            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);

            DevExpress.XtraEditors.Controls.EditorButton btnReload = new DevExpress.XtraEditors.Controls.EditorButton();
            btnReload.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Redo;
            btnReload.ToolTip = "Reload data";
            sprTextBoxEx.Properties.Buttons.Add(btnReload);
            sprTextBoxEx.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(sprTextBoxEx_ButtonClick);
            SetGridViewSetting();
            //tsbtnPrint.Click += new EventHandler(tsbtnPrint_Click);
        }

        void tsmiPrintDirectly_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "Invoice" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_PrintInvoice('Transaction.FrmTLpbRetur','" + this.NoDocument + "')");
            report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
            report.Bands[BandKind.PageFooter].Controls["lblSummary"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblSummary2"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblUMText"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblUM"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblDPPText"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblDPP"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblPPNText"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblPPN"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblTotal"].Visible = false;
            report.PrintingSystem.ShowMarginsWarning = false;
            report.PaperName = "1/2A4";
            report.Print();
        }

        void tsmiPrintPreview_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "Invoice" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_PrintInvoice('Transaction.FrmTLpbRetur','" + this.NoDocument + "')");
            report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
            report.Bands[BandKind.PageFooter].Controls["lblSummary"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblSummary2"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblUMText"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblUM"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblDPPText"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblDPP"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblPPNText"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblPPN"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["lblTotal"].Visible = false;
            report.ShowPreview();
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
           rsmTextEdit.Properties.ReadOnly = true;
        }

        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base Diterima");
        }

        void SetGridViewSetting()
        {
            gcxRkb.ExGridView.OptionsBehavior.Editable = false;
            gcxRkb.ExGridView.Columns["nodsg"].OptionsColumn.AllowEdit = false;
            gcxRkb.ExGridView.Columns["inv"].OptionsColumn.AllowEdit = false;
            gcxRkb.ExGridView.Columns["remark"].OptionsColumn.AllowEdit = false;
            gcxRkb.ExGridView.Columns["loc"].OptionsColumn.AllowEdit = false;
            gcxRkb.ExGridView.Columns["qty"].OptionsColumn.AllowEdit = false;
            gcxRkb.ExGridView.Columns["qty1"].OptionsColumn.AllowEdit = false;
            gcxRkb.ExGridView.Columns["loc"].OptionsColumn.AllowEdit = false;
            gcxRkb.ExGridView.Columns["unit"].OptionsColumn.AllowEdit = false;
            gcxRkb.ExGridView.Columns["etd"].OptionsColumn.AllowEdit = true;
            gcxRkb.ExGridView.OptionsView.ShowGroupPanel = false;
            gcxRkb.ExGridView.OptionsCustomization.AllowSort = false;

            gcxRkb.ExGridView.Columns["Unit Base Diterima"].VisibleIndex = DetailTable.Columns.IndexOf("qty") + 1;
            gcxRkb.ExGridView.Columns["Unit Base Diterima"].OptionsColumn.AllowEdit = false;

            gcxRkb.ExGridView.Columns["rka"].Visible = false;
            gcxRkb.ExGridView.Columns["nodsg"].Caption = "No Design";
            gcxRkb.ExGridView.Columns["inv"].Caption = "Kode Barang";
            gcxRkb.ExGridView.Columns["remark"].Caption = "Nama Barang";
            gcxRkb.ExGridView.Columns["loc"].Caption = "Loc";
            gcxRkb.ExGridView.Columns["qty"].Caption = "Qty Diterima Base";
            gcxRkb.ExGridView.Columns["qty1"].Caption = "Qty Diterima";
            gcxRkb.ExGridView.Columns["unit"].Caption = "Unit";
            gcxRkb.ExGridView.Columns["etd"].Caption = "Keterangan";
            gcxRkb.ExGridView.Columns["no"].Visible = false;

            gcxRkb.ExGridView.BestFitColumns();

            //DevExpress.XtraEditors.Controls.EditorButton btnReload = new DevExpress.XtraEditors.Controls.EditorButton();
            //btnReload.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Redo;
            //btnReload.ToolTip = "Reload data";
            //sprTextBoxEx.Properties.Buttons.Add(btnReload);
            //sprTextBoxEx.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(sprTextBoxEx_ButtonClick);

        }

        void sprTextBoxEx_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index > 0)
                sprTextBoxEx_EditValueChanged(sender, new EventArgs());
        }

        protected override void tsbtnCancel_Click(object sender, EventArgs e)
        {
            base.tsbtnCancel_Click(sender, e);
            if (this.mode == Mode.View)
            {
                sprTextBoxEx.ExAutoCheck = false;
                DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base Diterima");
            }
        }

        bool isSOReturStillOpen()
        {
            DataTable dt = DB.sql.Select("Call SP_OutSpr('" + rsmTextEdit.EditValue.ToString() + "')");
            if (dt.Rows.Count == 0)
                return false;
            else
                return true;
        }

        void CloseSORetur()
        {
            if (!isSOReturStillOpen())
                DB.sql.Execute("update rsm set close=1 where rsm='" + rsmTextEdit.EditValue.ToString() + "'");
        }

        protected override void tsbtnDelete_Click(object sender, EventArgs e)
        {
            base.tsbtnDelete_Click(sender, e);
            if (Convert.ToInt32(MasterTable.Rows[MasterBindingSource.Position]["delete"]) == 1)
                DB.sql.Execute("Call SP_Delete('RKA','" + NoDocument + "')");
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //cek masih ada outstanding PO atau PR
                //if (MasterBindingSource.Position == MasterTable.Rows.Count && !isSOReturStillOpen())
                //{
                //    MessageBox.Show(rsmTextEdit.EditValue.ToString() + " sudah terpenuhi");
                //    return;
                //}

                base.tsbtnSave_Click(sender, e);

                if (this.mode == Mode.View)
                {
                    string date = Convert.ToDateTime(dateDate.EditValue).ToString("yyyyMMdd");
                    DB.sql.Execute("Call SP_Save(" + date + ",'RKA','" + NoDocument + "')");
                    CloseSORetur();
                    sprTextBoxEx.ExAutoCheck = false;
                    rsmTextEdit.Properties.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            DetailTable.Rows.Clear();
            sprTextBoxEx.ExAutoCheck = true;
            //sprTextBoxEx.SendKey(new KeyEventArgs(Keys.Enter));
            rsmTextEdit.Properties.ReadOnly = true;
        }

        private void FrmTLpbRetur_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'casDataSet.spr' table. You can move, or remove it, as needed.
           // this.sprTableAdapter.Fill(this.casDataSet.spr);
            tglbc.Properties.MinValue = Utility.FirstDateInMonth((DateTime)dateDate.EditValue);
            tglbc.Properties.MaxValue = Utility.LastDateInMonth((DateTime)dateDate.EditValue).AddHours(23);

            ctrlSub.txtSub.DataBindings.Add("EditValue", rkaBindingSource, "sub");
            DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base Diterima");
            rsmTextEdit.Properties.ReadOnly = true;
            if (MasterBindingSource.Position != MasterTable.Rows.Count)
                sprTextBoxEx.ExAutoCheck = false;
        }

        private void sprTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {
            if (sprTextBoxEx.Text == "" || !sprTextBoxEx.ExIsValid())
                return;

            // if new record
       //     if (MasterBindingSource.Position == MasterTable.Rows.Count)
        //    {
                ctrlSub.txtSub.EditValue = sprTextBoxEx.ExGetDataRow()["Kode Customer"].ToString();
                rsmTextEdit.EditValue = sprTextBoxEx.ExGetDataRow()["SO Retur"];
                nopolTextEdit.EditValue = sprTextBoxEx.ExGetDataRow()["No Polisi"];
                remarkMemoEdit.EditValue = sprTextBoxEx.ExGetDataRow()["Keterangan"];
               
               gcxRkb.ExGridControl.DataSource = null;
            //    DetailTable.Clear();
               int tNo = 9999;
               foreach (DataRow dr in DetailTable.Rows)
               {
                   dr["no"] = tNo;
                   dr.Delete();
                   tNo++;
               }
                DataTable dtSprd = DB.sql.Select("select * from sprd where spr='" + sprTextBoxEx.Text + "'");
                int no = 1;
                foreach (DataRow drSprd in dtSprd.Rows)
                {
                    DataRow drRkb = DetailTable.NewRow();
                    drRkb["rka"] = NoDocument;
                    drRkb["no"] = no;
                    drRkb["nodsg"] = drSprd["nodsg"];
                    drRkb["inv"] = drSprd["inv"];
                    drRkb["remark"] = drSprd["remark"];
                    drRkb["loc"] = drSprd["loc"];
                    drRkb["unit"] = drSprd["unitgd"];
                    drRkb["qty1"] = drSprd["qtygd"];
                    drRkb["qty"] = DB.GetQtyInBaseUom(drRkb["inv"].ToString(), drRkb["unit"].ToString(), Convert.ToDouble(drRkb["qty1"]));
                    drRkb["etd"] = drSprd["etd"];
                    DetailTable.Rows.Add(drRkb);
                    no++;
                }
                DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base Diterima");
                gcxRkb.ExGridControl.DataSource = DetailTable;
                SetGridViewSetting();
            //}
            //else
            //    DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base Diterima");
        }

        private void sprTextBoxEx_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            sprTextBoxEx.ExSqlQuery = "Call SP_SelectSPBReturforLPBRetur('" + sprTextBoxEx.EditValue.ToString() + "')";
        }

        private void pnlDetail_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateDate_EditValueChanged(object sender, EventArgs e)
        {
            if (this.mode != Mode.View)
            {
                tglbc.EditValue = dateDate.EditValue.ToString();
            }
        }
    }
}

