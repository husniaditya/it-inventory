using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KASLibrary;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using MySql.Data.MySqlClient;
using DevExpress.XtraReports.UI;

namespace CAS.Transaction
{
    public partial class FrmTKlr : BaseTransaction
    {
        MySqlDataAdapter kllAdapter, umkAdapter, kldAdapter,sjdAdapter;
        DataTable dtResult = new DataTable();
        DataTable dtBaseUnit = new DataTable();
        double totinv = 0;
        RepositoryItemComboBox Cinvo = new RepositoryItemComboBox();

        public FrmTKlr()
        {
            InitializeComponent();
            maskfpj.Culture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);
        
            //customize button print
            ToolStripMenuItem tsmiPreviewInv = new ToolStripMenuItem("Preview Invoice", null, new EventHandler(tsmiPreviewInv_Click));
            ToolStripMenuItem tsmiPrintInv = new ToolStripMenuItem("Print Invoice", null, new EventHandler(tsmiPrintInv_Click));
            ToolStripSeparator tsSeparator1 = new ToolStripSeparator();
            ToolStripMenuItem tsmiPreviewFP = new ToolStripMenuItem("Preview FP Standard", null, new EventHandler(tsmiPreviewFP_Click));
            ToolStripMenuItem tsmiPrintFP = new ToolStripMenuItem("Print FP Standard", null, new EventHandler(tsmiPrintFP_Click));
            ToolStripSeparator tsSeparator2 = new ToolStripSeparator();
            ToolStripMenuItem tsmiPreviewSimpleFP = new ToolStripMenuItem("Preview Rekap SJ", null, new EventHandler(tsmiPreviewSimpleFP_Click));
            ToolStripMenuItem tsmiPrintSimpleFP = new ToolStripMenuItem("Print Rekap SJ", null, new EventHandler(tsmiPrintSimpleFP_Click));
            ToolStripSeparator tsSeparator3 = new ToolStripSeparator();
            ToolStripMenuItem tsmiPreviewEx = new ToolStripMenuItem("Preview Invoice Export", null, new EventHandler(tsmiPreviewEx_Click));
            ToolStripMenuItem tsmiPrintEx = new ToolStripMenuItem("Print Invoice Export", null, new EventHandler(tsmiPrintEx_Click));
            ToolStripDropDownButton tsbtnPrint = new ToolStripDropDownButton("Print", null, tsmiPreviewInv, tsmiPrintInv, tsSeparator1, tsmiPreviewFP, tsmiPrintFP, tsSeparator2, tsmiPreviewSimpleFP, tsmiPrintSimpleFP, tsSeparator3, tsmiPreviewEx, tsmiPrintEx);
           
            tsbtnPrint.Image = MasterNavigator.Items["tsbtnPrint"].Image;
            MasterNavigator.Items.Insert(MasterNavigator.Items.IndexOfKey("tsbtnPrint"), tsbtnPrint);
            MasterNavigator.Items.RemoveByKey("tsbtnPrint");

            // SO
            gcxKll.ExTitleLabel.Text = "Detail SO";
            gcxKll.ExGridControl.DataSource = kllBindingSource;
            gcxKll.ExGridView.OptionsView.ShowGroupPanel = false;
            gcxKll.ExGridView.OptionsCustomization.AllowSort = false;
            gcxKll.ExGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(gcxKll_InitNewRow);           
            gcxKll.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(gcxKll_tsbtnDelete_Click);
            gcxKll.ExGridView.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(gcxKll_SelectionChanged);
            gcxKll.ExGridView.Columns["klr"].Visible = gcxKll.ExGridView.Columns["no"].Visible = false;
            gcxKll.ExGridView.Columns["okl"].Caption = "Sales Order";
            gcxKll.ExGridView.Columns["sjh"].Caption = "Penjualan Barang";
            gcxKll.ExGridView.Columns["sjh"].ColumnEdit = new GridLookUpEx(DB.sql, "select distinct sjh,date as Tanggal from (select sjd.sjh,sjh.date,kll.sjh as sjhkll from sjd left outer join sjh on sjd.sjh=sjh.sjh left outer join kll on sjd.sjh=kll.sjh where sjd.okl='') as xtemp where xtemp.sjhkll is null", "sjh", "sjh", gcxKll.ExGridView, "Sjl", true, true, "Surat Jalan");
            gcxKll.ExGridView.Columns["date"].Caption = "Tanggal";
            gcxKll.ExGridView.Columns["inv"].Caption = "MaterialCode";
            gcxKll.ExGridView.Columns["remark"].Caption = "Keterangan";
            gcxKll.ExGridView.Columns["val"].Caption = "Val";
            DB.SetNumberFormat(gcxKll.ExGridView, "n2");
            
            // Invoice
            gcxKld.ExTitleLabel.Text = "Invoice";
            gcxKld.ExGridControl.DataSource = kldBindingSource;
            gcxKld.ExGridView.OptionsView.ShowGroupPanel = false;
            gcxKll.ExGridView.OptionsCustomization.AllowSort = false;
            gcxKld.ExGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(gcxKld_InitNewRow);
            gcxKld.ExGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(ExGridView_CellValueChanged);
            gcxKld.ExGridView.Columns["val"].OptionsColumn.AllowEdit = false;
            gcxKld.ExGridView.Columns["kurs"].OptionsColumn.AllowEdit = false;
            gcxKld.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(gcxKld_tsbtnDelete_Click);
            gcxKld.ExGridView.Columns["klr"].Visible = gcxKld.ExGridView.Columns["no"].Visible = false;
            gcxKld.ExGridView.Columns["okl"].ColumnEdit = new RepositoryItemComboBox();
            (gcxKld.ExGridView.Columns["okl"].ColumnEdit as RepositoryItemComboBox).TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            gcxKld.ExGridView.Columns["okl"].Caption = "Sales Order";
            gcxKld.ExGridView.Columns["invo"].Caption = "Invoice";
            gcxKld.ExGridView.Columns["invo"].Visible = false;
            gcxKld.ExGridView.Columns["inv"].Caption = "MaterialCode";
            gcxKld.ExGridView.Columns["nofp"].Caption = "No Faktur Pajak";
            gcxKld.ExGridView.Columns["nofp"].Visible = false;
            gcxKld.ExGridView.Columns["tglfp"].Caption = "Tanggal Faktur Pajak";
            gcxKld.ExGridView.Columns["tglfp"].Visible = false;
            gcxKld.ExGridView.Columns["tglsfp"].Caption = "Tgl Setor Faktur Pajak";
            gcxKld.ExGridView.Columns["tglsfp"].Visible = false;
            gcxKld.ExGridView.Columns["kurs"].Caption = "Kurs";
            gcxKld.ExGridView.Columns["kurs"].Visible = false;
            gcxKld.ExGridView.Columns["dpp"].Caption = "DPP";
            gcxKld.ExGridView.Columns["dpp"].ColumnEdit = new GridNumEx();
            gcxKld.ExGridView.Columns["ppn"].Caption = "PPN";
            gcxKld.ExGridView.Columns["ppn"].ColumnEdit = new GridNumEx();
            gcxKld.ExGridView.Columns["val"].Caption = "Val";
            gcxKld.ExGridView.Columns["remark"].Caption = "Keterangan";
            gcxKld.ExGridView.Columns["qty"].Caption = "Qty";
            gcxKld.ExGridView.Columns["qty"].ColumnEdit = new GridNumEx();
            gcxKld.ExGridView.Columns["price"].Caption = "Harga";
            gcxKld.ExGridView.Columns["qty"].VisibleIndex = gcxKld.ExGridView.Columns["price"].VisibleIndex = gcxKld.ExGridView.Columns["dpp"].VisibleIndex;
            DB.SetNumberFormat(gcxKld.ExGridView, "n2");
     //       gcxKld.ExGridView.Columns["price"].DisplayFormat.FormatString = "n3";

            // Debet Kredit ComboBox
            RepositoryItemComboBox cboDK = new RepositoryItemComboBox();
            cboDK.Items.AddRange(new string[] { "D", "K" });
            cboDK.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            
            // Penjualan Barang
            casDataSet.sjd.Columns.Add("Unit Base", typeof(String));
            gcxSjd.ExTitleLabel.Text = "Detail Penjualan Barang";
            gcxSjd.ExGridControl.DataSource = casDataSet.sjd;
          
            gcxSjd.ExGridView.OptionsView.ShowGroupPanel = false;
            gcxSjd.ExGridView.OptionsCustomization.AllowSort = false;
            gcxSjd.ExGridView.Columns["mor"].Visible = false;
            gcxSjd.ExGridView.Columns["okl"].Visible = false;
            gcxSjd.ExGridView.Columns["nopoc"].Visible = false;
            gcxSjd.ExGridView.Columns["sjh"].Caption = "Surat Jalan";
            gcxSjd.ExGridView.Columns["nodsg"].Caption = "No Design";
            gcxSjd.ExGridView.Columns["inv"].Caption = "Kode Barang";
            gcxSjd.ExGridView.Columns["remark"].Caption = "Nama Barang";
            gcxSjd.ExGridView.Columns["loc"].Caption = "Loc";
            gcxSjd.ExGridView.Columns["qty"].Caption = "Qty Base";
            gcxSjd.ExGridView.Columns["qty1"].Caption = "Qty";
            gcxSjd.ExGridView.Columns["unit"].Caption = "Unit";
            gcxSjd.ExGridView.Columns["price"].Caption = "Harga";
            gcxSjd.ExGridView.Columns["val"].Caption = "Nilai";
            gcxSjd.ExGridView.Columns["no"].Visible = false;
            gcxSjd.ExGridView.Columns["sjh"].OptionsColumn.AllowEdit = false;
            gcxSjd.ExGridView.Columns["nodsg"].OptionsColumn.AllowEdit = false;
            gcxSjd.ExGridView.Columns["inv"].OptionsColumn.AllowEdit = false;
            gcxSjd.ExGridView.Columns["remark"].OptionsColumn.AllowEdit = false;
            gcxSjd.ExGridView.Columns["loc"].OptionsColumn.AllowEdit = false;
            gcxSjd.ExGridView.Columns["qty"].OptionsColumn.AllowEdit = false;
            gcxSjd.ExGridView.Columns["qty1"].OptionsColumn.AllowEdit = false;
            gcxSjd.ExGridView.Columns["unit"].OptionsColumn.AllowEdit = false;
            gcxSjd.ExGridView.Columns["Unit Base"].VisibleIndex = casDataSet.sjd.Columns.IndexOf("qty") + 1;
            gcxSjd.ExGridView.Columns["Unit Base"].Visible = false;
            gcxSjd.ExGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(gvSjd_CellValueChanged);
           

            DB.SetNumberFormat(gcxSjd.ExGridView, "n2");
   
            // Uang Muka
            casDataSet.umk.Columns.Add("debet", typeof(String));
            gcxUmk.ExTitleLabel.Text = "Uang Muka";
            gcxUmk.ExGridControl.DataSource = umkBindingSource;
            gcxUmk.ExGridView.OptionsView.ShowGroupPanel = false;
            gcxUmk.ExGridView.OptionsCustomization.AllowSort = false;
            gcxUmk.ExGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(gcxUmk_InitNewRow);
            gcxUmk.ExGridView.Columns["acc"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_Lookup('acc')", "acc", "acc", gcxUmk.ExGridView, "", true, false, "Perkiraan");
            gcxUmk.ExGridView.Columns["jurnal"].ColumnEdit = new GridLookUpEx(DB.sql, "call SP_OutRhp('" + ctrlSub.txtSub.Text + "','" + ctrlSub.txtSub.Text + "'," + Utility.FirstDateInMonth(dateDate.DateTime).ToString("yyyyMMdd") + "," + ((DateTime)dateDate.EditValue).AddDays(1).ToString("yyyyMMdd") + ",'" + ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text + "','2')", "rhp", "jurnal", gcxUmk.ExGridView, "", true, true, "Detail Hutang");
            gcxUmk.ExGridView.Columns["jurnal"].ColumnEdit.Enter += new EventHandler(ExGridView_jurnalColumnEdit_Enter);
            gcxUmk.ExGridView.Columns["cct"].ColumnEdit = new GridLookUpEx(DB.sql, "select cct, name from cct", "cct", "cct", gcxUmk.ExGridView, "", false, false, "Cost Center");
            gcxUmk.ExGridView.Columns["dk"].ColumnEdit = cboDK;
            gcxUmk.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(gcxUmk_tsbtnDelete_Click);
            gcxUmk.ExGridView.Columns["klr"].Visible = gcxUmk.ExGridView.Columns["no"].Visible = false;
            gcxUmk.ExGridView.Columns["debet"].Visible = false;
            gcxUmk.ExGridView.Columns["invoice"].Visible = false;
            gcxUmk.ExGridView.Columns["invo"].Visible =false;
            gcxUmk.ExGridView.Columns["invoice"].Caption = "Invoice";
            gcxUmk.ExGridView.Columns["jurnal"].Caption = "Jurnal";
            gcxUmk.ExGridView.Columns["acc"].Caption = "Perkiraan";
            gcxUmk.ExGridView.Columns["remark"].Caption = "Keterangan";
            gcxUmk.ExGridView.Columns["cct"].Caption = "Cost Center";
            gcxUmk.ExGridView.Columns["dk"].Caption = "Debet/Kredit";
            gcxUmk.ExGridView.Columns["debet"].Caption = "D/K";
            gcxUmk.ExGridView.Columns["val"].Caption = "Nilai";
            gcxUmk.ExGridView.Columns["kurs"].Caption = "Kurs";
            gcxUmk.ExGridView.Columns["val"].ColumnEdit = new GridNumEx();
            gcxUmk.ExGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(gvUmk_CellValueChanged);
            DB.SetNumberFormat(gcxUmk.ExGridView, "n2");

            gcxUmk.ExGridView.Columns["invoice"].ColumnEdit = Cinvo;
        
            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
            //tsbtnDelete.Click += new EventHandler(tsbtnDelete_Click);

            Utility.SetReadOnly(pnlTotal, true);
            Utility.SetNumberFormat(pnlTotal, "n2");
        }

        void tsmiPrintInv_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "InvoicePenj" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            int rowcount = 7;
            int oldrow = 0;
            int pagejum = 1;
            string suratjln = "";
            DataTable temp = DB.sql.Select("call SP_PrintInvoice('Transaction.FrmTKlr','" + this.NoDocument + "')");
            DataTable temp1 = DB.sql.Select("select kll.sjh from kll where kll.klr='" + this.NoDocument + "' order by kll.sjh");
            //for (int y = 0; y < temp1.Rows.Count; y++)
            //{
            //    if (suratjln == "")
            //        suratjln = temp1.Rows[y]["sjh"].ToString();
            //    else
            //    {
            //        if (suratjln.IndexOf(temp1.Rows[y]["sjh"].ToString()) == -1) suratjln = suratjln + ", " + temp1.Rows[y]["sjh"].ToString();
            //    }
            //}
            //suratjln = "SJ : " + suratjln;
            int nowrowcount = temp.Rows.Count;
            while (nowrowcount > rowcount)
            {
                DataRow data;
                data = temp.NewRow();
                double jum = 0;
                for (int i = oldrow; i < rowcount; i++)
                {
                    jum += Convert.ToDouble(temp.Rows[i]["isitable2f"].ToString());
                }
                for (int i = 0; i < 18; i++)
                {
                    data[i] = temp.Rows[0][i];
                }
                data["isitable2d2"] = "SALDO DIPINDAHKAN ";
                data["isitable2f"] = jum;
                temp.Rows.InsertAt(data, rowcount);
                data = temp.NewRow();
                data["isitable2d2"] = "SALDO PINDAHAN dari hal." + pagejum.ToString();
                data["isitable2f"] = jum;
                jum = 0;
                rowcount += 1;
                temp.Rows.InsertAt(data, rowcount);
                pagejum++;
                oldrow = rowcount;
                nowrowcount++;
                rowcount += 7;
                data["DPP"] = jum;

            }
            pagejum = 0;
            temp.Columns.Add("page");
            int j = 0;
            foreach (DataRow dl in temp.Rows)
            {
                dl["page"] = j / 7;
                j++;
            }
            report.DataSource = temp;
            // report.Bands[BandKind.GroupFooter].Controls["xrLabelSJ"].Text = suratjln;
            report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
            //  report.Bands[BandKind.PageFooter].Controls["lblSummary"].Visible = false;
            //  report.Bands[BandKind.PageFooter].Controls["lblSummary2"].Visible = false;
            report.Bands[BandKind.PageFooter].Controls["xrLblTotalPage"].Text = (((j - 1) / 8) + 1).ToString();
            report.Bands[BandKind.PageFooter].Controls["lblUM"].Text = txtUangMuka.Text;
            report.Bands[BandKind.PageFooter].Controls["xrLabel34"].Text = txtSubTotal.Text;
            report.Bands[BandKind.PageFooter].Controls["xrLabel10"].Text = txtPPN.Text;
            report.Bands[BandKind.PageFooter].Controls["xrLabel33"].Text = txtTotal.Text;
            
            //report.Bands[BandKind.PageFooter].Controls["lblUMText"].Visible = false;
            //report.Bands[BandKind.PageFooter].Controls["lblUM"].Visible = false;
            //report.Bands[BandKind.PageFooter].Controls["lblDPPText"].Visible = false;
            //report.Bands[BandKind.PageFooter].Controls["lblDPP"].Visible = false;
            //report.Bands[BandKind.PageFooter].Controls["lblPPNText"].Visible = false;
            //report.Bands[BandKind.PageFooter].Controls["lblPPN"].Visible = false;
            //report.Bands[BandKind.PageFooter].Controls["lblTotal"].Visible = false;
            report.PrintingSystem.ShowMarginsWarning = false;
            report.PaperName = "1/2A4";
            report.Print();
            DB.sql.Execute("insert into printed values ('" + NoDocument + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',1)");
            lblprint.Visible = true;
        }

        void tsmiPreviewInv_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "InvoicePenj" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            int rowcount = 7;
            int oldrow = 0;
            int pagejum = 1;
            string suratjln="";
            DataTable temp = DB.sql.Select("call SP_PrintInvoice('Transaction.FrmTKlr','" + this.NoDocument + "')");
            DataTable temp1 = DB.sql.Select("select kll.sjh from kll where kll.klr='" + this.NoDocument + "' order by kll.sjh");
            //for (int y = 0; y < temp1.Rows.Count; y++)
            //{
            //    if (suratjln == "")
            //        suratjln = temp1.Rows[y]["sjh"].ToString();
            //    else
            //    {
            //        if (suratjln.IndexOf(temp1.Rows[y]["sjh"].ToString()) == -1) suratjln = suratjln + ", " + temp1.Rows[y]["sjh"].ToString();
            //    }
            //}
            //suratjln = "SJ : " + suratjln;
            int nowrowcount = temp.Rows.Count;
            while (nowrowcount > rowcount)
            {
                DataRow data;
                data = temp.NewRow();
                double jum = 0;
                for (int i = oldrow; i < rowcount; i++)
                {
                    jum += Convert.ToDouble(temp.Rows[i]["isitable2f"].ToString());
                }
                for (int i = 0; i < 18; i++)
                {
                    data[i] = temp.Rows[0][i];
                }
                data["isitable2d2"] = "SALDO DIPINDAHKAN ";
                data["isitable2f"] = jum;
                temp.Rows.InsertAt(data, rowcount);
                data = temp.NewRow();
                data["isitable2d2"] = "SALDO PINDAHAN dari hal." + pagejum.ToString();
                data["isitable2f"] = jum;
                jum = 0;
                rowcount += 1;
                temp.Rows.InsertAt(data, rowcount);
                pagejum++;
                oldrow = rowcount;
                nowrowcount++;
                rowcount += 7;
                data["DPP"] = jum;
                
            }
            pagejum = 0;
            temp.Columns.Add("page");
            int j = 0;
            foreach (DataRow dl in temp.Rows)
            {
                dl["page"] = j / 7;
                j++;
            }
            report.DataSource = temp;
           // report.Bands[BandKind.GroupFooter].Controls["xrLabelSJ"].Text = suratjln;
            //report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
          //  report.Bands[BandKind.PageFooter].Controls["lblSummary"].Visible = false;
          //  report.Bands[BandKind.PageFooter].Controls["lblSummary2"].Visible = false;
              //report.Bands[BandKind.PageFooter].Controls["xrLblTotalPage"].Text = (((j - 1) / 8) + 1).ToString();
              //report.Bands[BandKind.PageFooter].Controls["lblUM"].Text = txtUangMuka.Text;
              //report.Bands[BandKind.PageFooter].Controls["xrLabel34"].Text = txtSubTotal.Text;
              //report.Bands[BandKind.PageFooter].Controls["xrLabel10"].Text = txtPPN.Text;
              //report.Bands[BandKind.PageFooter].Controls["xrLabel33"].Text = txtTotal.Text;
            //report.Bands[BandKind.PageFooter].Controls["lblUMText"].Visible = false;
            //report.Bands[BandKind.PageFooter].Controls["lblUM"].Visible = false;
            //report.Bands[BandKind.PageFooter].Controls["lblDPPText"].Visible = false;
            //report.Bands[BandKind.PageFooter].Controls["lblDPP"].Visible = false;
            //report.Bands[BandKind.PageFooter].Controls["lblPPNText"].Visible = false;
            //report.Bands[BandKind.PageFooter].Controls["lblPPN"].Visible = false;
            //report.Bands[BandKind.PageFooter].Controls["lblTotal"].Visible = false;
              report.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.PrintDirect, DevExpress.XtraPrinting.CommandVisibility.None);
              report.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.Print, DevExpress.XtraPrinting.CommandVisibility.None);
              report.ShowPreview();
           
        }

        void PrintFP(ref XtraReport report)
        {
            string path = Application.StartupPath + "\\Reports\\FakturPajakStandar.repx";
            report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('Transaction.FrmTKlr','" + this.NoDocument + "')");
            dt = SplitInvName(dt, 37);
            //modify data table (1 page report = 10 detail, add subtotal from prev page)
            DateTime fpjDate;// = DateTime.Today;
            DataTable dtRep = dt.Clone();
            if (dt.Rows.Count > 15)
            {
                double subtotal = 0;
                int rowcount = 1;
                foreach (DataRow dr in dt.Rows)
                {
                    fpjDate = (DateTime)dr["fpjdate"];
                    subtotal = subtotal + Convert.ToDouble(dr["subtotal"]);
                    if (rowcount % 15 == 0)
                    {
                        dtRep.ImportRow(dr);
                        //add new row
                        DataRow drRep = dtRep.NewRow();
                        drRep["invname"] = "Subtotal dari halaman: ";
                        drRep["subtotal"] = subtotal;
                        drRep["umk"] = 0;
                        drRep["dpp"] = 0;
                        drRep["ppn"] = 0;
                        drRep["disc"] = 0;
                        drRep["fpjdate"] = fpjDate;
                        drRep["kurs"] = dtRep.Rows[0]["kurs"];
                        drRep["cur"] = dtRep.Rows[0]["cur"];
                        drRep["kmkno"] = dtRep.Rows[0]["kmkno"];
                        dtRep.Rows.Add(drRep);
                        rowcount = 2;
                    }
                    else
                    {
                        dtRep.ImportRow(dr);
                        rowcount++;
                    }
                }
            }
            else
                dtRep = dt.Copy();

            //to add empty rows to datatable 
            int jumToAdd = 15 - (dtRep.Rows.Count % 15);
            //add empty rows
            for (int i = 0; i < jumToAdd; i++)
            {
                DataRow drRep = dtRep.NewRow();
                drRep["invname"] = "";
                drRep["subtotal"] = 0;
                drRep["umk"] = 0;
                drRep["dpp"] = 0;
                drRep["ppn"] = 0;
                drRep["disc"] = 0;
                //seragamkan tgl FP dgn record lainnya
                drRep["fpjdate"] = dtRep.Rows[0]["fpjdate"];
                drRep["kurs"] = dtRep.Rows[0]["kurs"];
                drRep["cur"] = dtRep.Rows[0]["cur"];
                drRep["kmkno"] = dtRep.Rows[0]["kmkno"];

                dtRep.Rows.Add(drRep);
            }

            report.DataSource = dtRep;
            report.Bands[BandKind.PageHeader].Controls["lblNamaKenaPajak"].Text = Utility.GetConfig("CompanyName");
        //    report.Bands[BandKind.PageHeader].Controls["lblAlamatKenaPajak"].Text = Utility.GetConfig("CompanyAddr");
            report.Bands[BandKind.PageHeader].Controls["lblNPWP"].Text = Utility.GetConfig("CompanyNPWP");
          //  report.Bands[BandKind.PageHeader].Controls["lblTglPKP"].Text = Utility.GetConfig("CompanyTglPKP");
            report.Bands[BandKind.PageFooter].Controls["lblNama"].Text = Utility.GetConfig("KabagAcc");
        }

        void tsmiPrintFP_Click(object sender, EventArgs e)
        {
            if (maskfpj.Text.Substring(0, 1) == "0")
            {
                XtraReport report = new XtraReport();
                PrintFP(ref report);
                report.PrintingSystem.ShowMarginsWarning = false;
                report.PaperName = "FP";
                report.Print();
            }
        }

        void tsmiPreviewFP_Click(object sender, EventArgs e)
        {
            if (maskfpj.Text.Substring(0, 1) == "0")
            {
                XtraReport report = new XtraReport();
                PrintFP(ref report);
                report.ShowPreview();
            }
            //report.RunDesigner();
        }

        private DataTable SplitInvName(DataTable dt, int charLen)
        {
            DataTable retDt = dt.Clone();
            foreach (DataRow dr in dt.Rows)
            {
                string invname = dr["invname"].ToString();
                DataRow retDr;
                int ctr = 1;
                while (invname.Length > charLen)
                {                    
                    retDr = retDt.NewRow();
                    foreach (DataColumn col in dt.Columns)
                        retDr[col.ColumnName] = dr[col.ColumnName];
                    retDr["invname"] = invname.Substring(0, charLen);
                    //empty inv, qty, unit, subtotal on second, third, ... record
                    if (ctr > 1)
                    {
                        retDr["inv"] = "";
                        retDr["qty"] = 0;
                        retDr["unit"] = "";
                        retDr["subtotal"] = 0;
                        retDr["ppn"] = 0;
                        retDr["dpp"] = 0;
                    }
                    retDt.Rows.Add(retDr);
                    invname = invname.Substring(charLen);
                    ctr++;
                } 
                retDr = retDt.NewRow();
                foreach (DataColumn col in dt.Columns)
                    retDr[col.ColumnName] = dr[col.ColumnName];
                retDr["invname"] = invname;
                if (ctr > 1)
                {
                    retDr["inv"] = "";
                    retDr["qty"] = 0;
                    retDr["unit"] = "";
                    retDr["subtotal"] = 0;
                    retDr["ppn"] = 0;
                    retDr["dpp"] = 0;
                }
                retDt.Rows.Add(retDr);
            }
            return retDt;
        }

        //split inv name to length 25 to suit column nama barang
        //void PrintSimpleFP(ref XtraReport report)
        //{
        //    string path = Application.StartupPath + "\\Reports\\FakturPajakSederhana.repx";
        //    report = new XtraReport();
        //    report.LoadState(path);
        //    DataTable dt = DB.sql.Select("call SP_Print('Transaction.FrmTKlr','" + this.NoDocument + "')");
        //    //modify data table (1 page report = 10 detail, add subtotal from prev page)            
        //    dt = SplitInvName(dt, 25);
        //    DateTime fpjDate = DateTime.Today;
        //    DataTable dtRep = dt.Clone();
        //    int pageNo = 1;
        //    if (dt.Rows.Count > 8)
        //    {
        //        double subtotal = 0;
        //        int rowcount = 1;
        //        foreach (DataRow dr in dt.Rows)
        //        {
        //            fpjDate = (DateTime)dr["fpjdate"];
        //            subtotal = subtotal + Convert.ToDouble(dr["subtotal"]);
        //            dr["pageno"] = pageNo;
        //            if (rowcount % 8 == 0)
        //            {
        //                dtRep.ImportRow(dr);
        //                //add new row
        //                pageNo++;
        //                DataRow drRep = dtRep.NewRow();
        //                drRep["inv"] = "";
        //                drRep["invname"] = "Subtotal dari halaman : " + (pageNo - 1).ToString();
        //                drRep["subtotal"] = subtotal;
        //                drRep["umk"] = 0;
        //                drRep["dpp"] = 0;
        //                drRep["ppn"] = 0;
        //                drRep["disc"] = 0;
        //                drRep["fpjdate"] = fpjDate;
        //                drRep["pageno"] = pageNo;
        //                dtRep.Rows.Add(drRep);
        //                rowcount = 2;
        //            }
        //            else
        //            {
        //                dtRep.ImportRow(dr);
        //                rowcount++;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        foreach (DataRow dr in dt.Rows)
        //            dr["pageno"] = pageNo;
        //        dtRep = dt.Copy();
        //    }

        //    //to add empty rows to datatable 
        //    //int jumToAdd = 8 - (dtRep.Rows.Count % 8);
        //    ////add empty rows
        //    //for (int i = 0; i < jumToAdd; i++)
        //    //{
        //    //    DataRow drRep = dtRep.NewRow();
        //    //    drRep["invname"] = "";
        //    //    drRep["subtotal"] = 0;
        //    //    drRep["umk"] = 0;
        //    //    drRep["dpp"] = 0;
        //    //    drRep["ppn"] = 0;
        //    //    drRep["disc"] = 0;
        //    //    drRep["fpjdate"] = fpjDate;
        //    //    dtRep.Rows.Add(drRep);
        //    //}
        //    report.DataSource = dtRep;
        //    report.Bands[BandKind.PageHeader].Controls["lblNamaKenaPajak"].Text = Utility.GetConfig("CompanyName");
        //    report.Bands[BandKind.PageHeader].Controls["lblAlamatKenaPajak"].Text = Utility.GetConfig("CompanyAddr");
        //    report.Bands[BandKind.PageHeader].Controls["lblNPWP"].Text = Utility.GetConfig("CompanyNPWP");
        //    report.Bands[BandKind.PageHeader].Controls["lblTglPKP"].Text = Utility.GetConfig("CompanyTglPKP");
        //    report.Bands[BandKind.GroupFooter].Controls["lblTotalPage"].Text = pageNo.ToString();
        //    report.Bands[BandKind.GroupFooter].Controls["lblNama"].Text = Utility.GetConfig("KabagAcc");
        //}

        void Printrekapsj(ref XtraReport report)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepRekapSJ" + ".repx";
            report = new XtraReport();
            report.LoadState(path);
            DataTable temp = DB.sql.Select("call sp_rekapklr('" + this.NoDocument + "')");
            report.DataSource = temp;       
        }


        void tsmiPreviewSimpleFP_Click(object sender, EventArgs e)
        {
            XtraReport report = new XtraReport();
            Printrekapsj(ref report);
            report.ShowPreview();
            //report.RunDesigner();
        }

        void tsmiPrintSimpleFP_Click(object sender, EventArgs e)
        {
            XtraReport report = new XtraReport();
            Printrekapsj(ref report);
            report.PrintingSystem.ShowMarginsWarning = false;
            report.PaperName = "SimpleFP";
            report.Print();
        }

        void tsmiPreviewEx_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "invoiceexport" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable temp = DB.sql.Select("call SP_PrintInvoice('Transaction.FrmTKlrEx','" + this.NoDocument + "')");
            report.DataSource = temp;
            report.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.PrintDirect, DevExpress.XtraPrinting.CommandVisibility.None);
            report.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.Print, DevExpress.XtraPrinting.CommandVisibility.None);
            report.ShowPreview();
        }
        void tsmiPrintEx_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "invoiceexport" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable temp = DB.sql.Select("call SP_PrintInvoice('Transaction.FrmTKlrEx','" + this.NoDocument + "')");
            report.DataSource = temp;
            report.Print();
            DB.sql.Execute("insert into printed values ('" + this.NoDocument + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',1)");
            lblprint.Visible = true;
        }
        void ExGridView_jurnalColumnEdit_Enter(object sender, EventArgs e)
        {
            string query = "call SP_OutRhp('" + ctrlSub.txtSub.Text + "','" + ctrlSub.txtSub.Text + "'," + Utility.FirstDateInMonth(dateDate.DateTime).ToString("yyyyMMdd") + "," + ((DateTime)dateDate.EditValue).AddDays(1).ToString("yyyyMMdd") + ",'" + ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text + "','1')";
            ((GridLookUpEx)gcxUmk.ExGridView.Columns["jurnal"].ColumnEdit).Query = query;
        }
       

        protected override void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            base.tsbtnRefresh_Click(sender, e);
            PopulateDetails();
        }
        //void tsbtnDelete_Click(object sender, EventArgs e)
        protected override void  tsbtnDelete_Click(object sender, EventArgs e)
        {
 	        base.tsbtnDelete_Click(sender, e);
            if (Convert.ToInt32(MasterTable.Rows[MasterBindingSource.Position]["delete"]) == 1)
                DB.sql.Execute("Call SP_Delete('KLR'" + ",'" + NoDocument + "')");
            if (MasterBindingSource.Position == -1)
                tsbtnNew.PerformClick();

            //if (MessageBox.Show("Are you sure you want to delete this item?", "Confirmation",
            //    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            //    MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            //{
            //    string okl = MasterTable.Rows[MasterBindingSource.Position][0].ToString();

            //    DB.sql.BeginTransaction();

            //    MasterBindingSource.RemoveCurrent();
            //    MasterAdapter.Update(MasterTable);

            //    try
            //    {
            //        //DB.sql.Execute("Call Sp_DelDetailInvoicePemb('" + msk + "')");
            //    }
            //    catch (Exception ex)
            //    {
            //        DB.sql.RollbackTransaction();
            //        MessageBox.Show("Delete error: " + ex.Message + ". Transaction is rollbacked!");
            //    }
            //    //DB.sql.Execute("delete from msl where msk='" + msk + "'");
            //    //DB.sql.Execute("delete from msd where msk='" + msk + "'");
            //    //DB.sql.Execute("delete from msx where msk='" + msk + "'");

            //    DB.sql.CommitTransaction();

            //    string jurnal = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
            //    DB.sql.Execute("Call SP_Delete('KLR'" + ",'" + jurnal + "')");

            //    if (MasterBindingSource.Position == -1)
            //    {
            //        //string query = "select * from " + MasterTable.TableName + " where period='" + DB.loginPeriod + "'";
            //        //MasterAdapter = DB.sql.SelectAdapter(query);
            //        //MasterAdapter.Fill(MasterTable);
            //        tsbtnNew.PerformClick();
            //    }
            //}          
        }

        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            PopulateDetails();
            ReCalculateTotal();
        }

        void RePopulate_List_Cbo_Okl()
        {
            dtResult.Clear();

            //add by gita 08/07/08
            //populate Oms to listOms
            listOkl.Items.Clear();
            foreach (DataRow drKll in casDataSet.kll.Rows)
            {
                if (listOkl.Items.IndexOf(drKll["okl"]) == -1)
                {
                    listOkl.Items.Add(drKll["okl"].ToString());
                    DataTable dt = DB.sql.Select("Select * from okl where okl='" + drKll["okl"].ToString() + "' and `delete`=0");
                    //jika invoice ngambil SO
                    if (dt.Rows.Count > 0)
                        chkMO.Checked = false;
                    else //jika invoice ngambil MO
                    {
                        dt = DB.sql.Select("Select mor.mor as okl, okl.date, "
                                + "okl.duedate, okl.sub, okl.ppn, okl.disc, "
                                + "mor.remark, 0 as val, mor.chtime, mor.chusr, "
                                + "mor.period, okl.cur, okl.kurs, okl.loc, "
                                + "okl.nopoc, okl.shiptoname, okl.shiptoaddress, "
                                + "okl.close, okl.valkg, okl.delete "
                                + "from mor, okl where mor.okl=okl.okl "
                                + "and mor.delete=0 and okl.delete=0 and mor.mor='" + drKll["okl"].ToString() + "'");

                        chkMO.Checked = true;
                    }
                    if (dt.Rows.Count > 0)
                        dtResult.ImportRow(dt.Rows[0]);
                }
            }
            //populate listOms to cboOms in Invoice
            RepositoryItemComboBox cboOkl = (RepositoryItemComboBox)gcxKld.ExGridView.Columns["okl"].ColumnEdit;
            cboOkl.Items.Clear();
            cboOkl.Items.AddRange(listOkl.Items);
        }

        private void PopulateDetails()
        {
            try
            {
                bool newEntry = (MasterBindingSource.Position == MasterTable.Rows.Count);
                string query = "";

                // Kld
                casDataSet.kld.Clear();
                if (newEntry)
                    query = "select * from kld where 0";
                else
                    query = "select * from kld where klr='" + MasterTable.Rows[MasterBindingSource.Position][0].ToString() + "'";
                kldAdapter = DB.sql.SelectAdapter(query);
                kldAdapter.Fill(casDataSet.kld);
                gcxKld.ExGridView.BestFitColumns();

                // Kll
                casDataSet.kll.Clear();
                if (newEntry)
                    query = "select * from kll where 0";
                else
                    query = "select * from kll where klr='" + MasterTable.Rows[MasterBindingSource.Position][0].ToString() + "'";
                kllAdapter = DB.sql.SelectAdapter(query);
                kllAdapter.Fill(casDataSet.kll);
                gcxKll.ExGridView.BestFitColumns();

                RePopulate_List_Cbo_Okl();

                // Sjd
                casDataSet.sjd.Clear();
                foreach (DataRow drKll in casDataSet.kll.Rows)
                {
                    DataTable dtSjd = DB.sql.Select("select  sjd.* from sjd where sjh='" + drKll["sjh"].ToString() + "' and inv='" + drKll["inv"].ToString() + "'");
                    foreach (DataRow drSjd in dtSjd.Rows)
                    {
                    //    drSjd["no"] = casDataSet.sjd.Rows.Count + 1;
                        casDataSet.sjd.ImportRow(drSjd);
                    }
                  //  query ="select sjd.*, inv.unit as `Unit Base` from sjd, inv where sjd.inv=inv.inv and sjh='" + drKll["sjh"].ToString() + "' and (okl='" + drKll["okl"] + "' or mor='" + drKll["okl"] +"')";
                    query = "select sjd.* from sjd where sjh='" + drKll["sjh"].ToString() + "'";
                   
                }
                sjdAdapter = DB.sql.SelectAdapter(query);
                sjdAdapter.Fill(casDataSet.sjd);
                gcxSjd.ExGridView.BestFitColumns();

                // Umk
                casDataSet.umk.Clear();
                if (newEntry)
                    query = "select * from umk where 0";
                else
                    query = "select * from umk where klr='" + MasterTable.Rows[MasterBindingSource.Position][0].ToString() + "'";
                umkAdapter = DB.sql.SelectAdapter(query);
                umkAdapter.Fill(casDataSet.umk);
                gcxUmk.ExGridView.BestFitColumns();

                DataTable dtprint = DB.sql.Select("select jurnal from printed where jurnal='" + NoDocument + "'");
                if (dtprint.Rows.Count > 0)
                    lblprint.Visible = true;
                else
                    lblprint.Visible = false;  
            }
            catch (Exception ex)
            {
                //remarked bcoz raised DataReader exception
                //MessageBox.Show(ex.Message);                
            }
        }

        void gcxKld_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gcxKld.ExGridView.GetDataRow(e.RowHandle);
            row["klr"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
            row["no"] = gcxKld.ExGridView.RowCount;
            row["kurs"] = 1;
        }

        void gcxUmk_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gcxUmk.ExGridView.GetDataRow(e.RowHandle);
            row["klr"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
            row["no"] = gcxUmk.ExGridView.RowCount;
            row["kurs"] = 1;
        }

        void gcxKll_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gcxKll.ExGridView.GetDataRow(e.RowHandle);
            row["klr"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
            row["no"] = gcxKll.ExGridView.RowCount;
            row["kurs"] = 1;
           // FillKldSjd();
          
        }
        void ExGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "dpp" || e.Column.FieldName == "ppn" || e.Column.FieldName == "disc")
            {
                double dpp = (double)gcxKld.ExGridView.GetRowCellValue(e.RowHandle, gcxKld.ExGridView.Columns["dpp"]);
                double ppn = (double)gcxKld.ExGridView.GetRowCellValue(e.RowHandle, gcxKld.ExGridView.Columns["ppn"]);
                //double disc = (double)gcxKld.ExGridView.GetRowCellValue(e.RowHandle, gcxKld.ExGridView.Columns["disc"]);
                //double totdisc = (dpp * disc) / 100;
                //double val = dpp + ppn - totdisc;
                double val = dpp + ppn;
                //gcxKld.ExGridView.SetRowCellValue(e.RowHandle, gcxKld.ExGridView.Columns["disc_val"], totdisc);
                gcxKld.ExGridView.SetRowCellValue(e.RowHandle, gcxKld.ExGridView.Columns["val"], val);

                ReCalculateTotal();
            }
            if (e.Column.FieldName == "qty" || e.Column.FieldName == "price")
            {
                double price = (double)gcxKld.ExGridView.GetRowCellValue(e.RowHandle, gcxKld.ExGridView.Columns["price"]);
                double qty = (double)gcxKld.ExGridView.GetRowCellValue(e.RowHandle, gcxKld.ExGridView.Columns["qty"]);
                double dpp = price * qty;
                gcxKld.ExGridView.SetRowCellValue(e.RowHandle, gcxKld.ExGridView.Columns["dpp"], dpp);           
                             
            }
            //if (e.Column.FieldName == "dpp")
            //{
            //    double dpp = (double)gcxKld.ExGridView.GetRowCellValue(e.RowHandle, gcxKld.ExGridView.Columns["dpp"]);
            //    double ppn = (double)gcxKld.ExGridView.GetRowCellValue(e.RowHandle, gcxKld.ExGridView.Columns["dpp"])*0.1;
            //    double val = dpp + ppn;
            //    gcxKld.ExGridView.SetRowCellValue(e.RowHandle, gcxKld.ExGridView.Columns["ppn"], ppn);           
            //    gcxKld.ExGridView.SetRowCellValue(e.RowHandle, gcxKld.ExGridView.Columns["val"], val);           
            //    ReCalculateTotal();
            //}
            //if (e.Column.FieldName == "ppn")
            //{
            //    double dpp = (double)gcxKld.ExGridView.GetRowCellValue(e.RowHandle, gcxKld.ExGridView.Columns["dpp"]);
            //    double ppn = (double)gcxKld.ExGridView.GetRowCellValue(e.RowHandle, gcxKld.ExGridView.Columns["ppn"]);
            //    double val = dpp + ppn;
            //    gcxKld.ExGridView.SetRowCellValue(e.RowHandle, gcxKld.ExGridView.Columns["val"], val);
            //    ReCalculateTotal();
            //}
            else if (e.Column.FieldName == "tglfp")
            {
                //tgl setor faktur pajak = tgl 15 berikutnya setelah tgl faktur pajak
                DateTime tglFP = (DateTime)gcxKld.ExGridView.GetFocusedRowCellValue("tglfp");
                DateTime tglSetorFP = new DateTime(tglFP.Year, tglFP.Month, 15);
                if (tglFP.Day > 15)
                    tglSetorFP = tglSetorFP.AddMonths(1);
                gcxKld.ExGridView.SetRowCellValue(e.RowHandle, gcxKld.ExGridView.Columns["tglsfp"], tglSetorFP);
            }
        }
        void gvSjd_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "price")
            {
                double price = (double)gcxSjd.ExGridView.GetFocusedRowCellValue("price");
                double qty = (double)gcxSjd.ExGridView.GetFocusedRowCellValue("qty1");
                double val = price * qty;
                gcxSjd.ExGridView.SetFocusedRowCellValue(gcxSjd.ExGridView.Columns["val"], val);

            }
            
        }
        void gvUmk_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "val")
                ReCalculateTotal();
            if (e.Column.FieldName == "debet")
            {
                string debet = "D";
                if (gcxUmk.ExGridView.GetFocusedRowCellValue(gcxUmk.ExGridView.Columns["debet"]).ToString() == "D") debet = "K";
                gcxUmk.ExGridView.SetFocusedRowCellValue(gcxUmk.ExGridView.Columns["dk"], debet);            
            }
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            gcxKld.ExGridView.OptionsBehavior.Editable = true;
            gcxKld.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

            gcxUmk.ExGridView.OptionsBehavior.Editable = true;
            gcxUmk.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

            gcxSjd.ExGridView.OptionsBehavior.Editable = false;

            gcxKll.ExGridView.OptionsBehavior.Editable = true;
            gcxKll.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

         
            btnAddOkl.Enabled = true;
            btnDeleteOkl.Enabled = true;

            chkMO.Checked = true;
            chkMO.Enabled = true;

            ReCalculateTotal();

            Utility.SetReadOnly(pnlTotal,true);
            fpjdateDateEdit.DateTime = DateTime.Today;
            tglproformaDateEdit.DateTime = DateTime.Today;
          /*
            string lastnum = NoDocument.Substring(0, 9) + Convert.ToString(Convert.ToInt64(NoDocument.Substring(9, 6)) - 1).PadLeft(6, '0');
            DataTable dtMaxFP = DB.sql.Select("select fpj from klr where substr(fpj,12,8)<>'' and substr(klr,5,2)="+DB.loginDate.ToString("yy")+" order by right(fpj,11) desc limit 1");
            DataTable dtMaxFP2 = DB.sql.Select("select nofpj from fpjumk where substr(nofpj,12,8)<>'' and substr(nofpj,9,2)=" + DB.loginDate.ToString("yy") + " order by right(nofpj,11) desc limit 1");
                   
            string numfp = "";
            string numfp2 = "";

            if (dtMaxFP.Rows.Count > 0)
            {
                numfp = dtMaxFP.Rows[0][0].ToString();
           //     lastnum = "";
                if (dtMaxFP2.Rows.Count > 0 && dtMaxFP2.Rows[0][0].ToString() != "")
                {
                    numfp2 = dtMaxFP2.Rows[dtMaxFP2.Rows.Count - 1][0].ToString();
                    if (Convert.ToInt64(numfp.Substring(11, 8)) < Convert.ToInt64(numfp2.Substring(11, 8)))
                        numfp = numfp2;
                }

                numfp = Convert.ToString(Convert.ToInt64(numfp.Substring(11, 8)) + 1).PadLeft(8, '0');
                //numfp = numfp.Substring(
            }
   //         maskfpj.Text = Utility.GetConfig("SeriFakturPajak") + DB.loginDate.ToString("yy") + "." + numfp;
            dateJatuhTempo.Enabled = false;

            //get new number of FP sederhana
            int lastNum = 1;
            DataTable dtMaxNum = DB.sql.Select("select max(fpjsederhana) from klr");
            if (dtMaxNum.Rows.Count > 0)
                if (dtMaxNum.Rows[0][0].ToString() == "")
                    lastNum = 0;
                else
                lastNum = int.Parse(dtMaxNum.Rows[0][0].ToString()) + 1;
            maskfpjsederhana.Text = lastNum.ToString("00000");
          */
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            gcxKld.ExGridView.OptionsBehavior.Editable = true;
            gcxKld.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

            gcxUmk.ExGridView.OptionsBehavior.Editable = true;
            gcxUmk.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

            gcxSjd.ExGridView.OptionsBehavior.Editable = false;

            gcxKll.ExGridView.OptionsBehavior.Editable = true;
            gcxKll.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

            btnAddOkl.Enabled = true;
            btnDeleteOkl.Enabled = true;
            Utility.SetReadOnly(pnlTotal, true);
            dateJatuhTempo.Enabled = false;
        }

        private void FrmTKlr_Load(object sender, EventArgs e)
        {
            dtResult = casDataSet.okl.Clone();
            dateDate.Properties.MinValue = Utility.FirstDateInMonth(DB.loginDate);
            dateDate.Properties.MaxValue = Utility.LastDateInMonth(DB.loginDate).AddMonths(8);

            if (MasterBindingSource.Position == MasterTable.Rows.Count)
            {
                btnAddOkl.Enabled = true;
                btnDeleteOkl.Enabled = true;
                fpjdateDateEdit.DateTime = DateTime.Today;
                chkMO.Checked = true;
            }
            else
            {
                btnAddOkl.Enabled = false;
                btnDeleteOkl.Enabled = false;
            }
            Utility.SetSqlInstance(pnlDetail, DB.sql);
            ctrlSub.txtSub.DataBindings.Add("EditValue", klrBindingSource, "sub");
            ctrlSub.txtSub.EditValueChanged += new EventHandler(txtSub_EditValueChanged);
            PopulateDetails();
            Utility.SetNumberFormat(pnlTotal, "n2");
            ReCalculateTotal();

       //     curcur.Properties.ReadOnly = true;
            dateJatuhTempo.Enabled = false;

            dtBaseUnit = DB.GetBaseUnitTable();
        //    base.tsbtnRefresh_Click(sender, e);
          
        }

        private void FillKldSjd()
        {
          //  casDataSet.sjd.Clear();
            DataTable dtKld = DetailTable.Copy();
          //  casDataSet.kld.Clear();
            string noSO = "";
            string query = "";
            foreach (DataRow sjhRow in casDataSet.kll.Rows)
            {
                casDataSet.sjd.Clear();
                if (sjhRow.RowState != DataRowState.Deleted)
                {
                         noSO = sjhRow["okl"].ToString();

                        //// Add Inventories to Penerimaan Barang
                         
                         foreach (DataRow drKll in casDataSet.kll.Rows)
                         {
                             if (drKll.RowState != DataRowState.Deleted)
                             {
                                DataTable dtSjd = DB.sql.Select("select sjd.* from sjd where sjh='" + drKll["sjh"].ToString() + "'");
                                 foreach (DataRow drSjd in dtSjd.Rows)
                                 {
                                     drSjd["no"] = casDataSet.sjd.Rows.Count + 1;
                                     casDataSet.sjd.ImportRow(drSjd);
                                 }
                                 //  query ="select sjd.*, inv.unit as `Unit Base` from sjd, inv where sjd.inv=inv.inv and sjh='" + drKll["sjh"].ToString() + "' and (okl='" + drKll["okl"] + "' or mor='" + drKll["okl"] +"')";
                                 query = "select sjd.* from sjd where sjh='" + drKll["sjh"].ToString() + "'";
                             }
                         }
                         sjdAdapter = DB.sql.SelectAdapter(query);
                         sjdAdapter.Fill(casDataSet.sjd);
                         gcxSjd.ExGridView.BestFitColumns();
                        // DataTable dtSjd = new DataTable();
                        // dtSjd = DB.sql.Select("select * from sjd where sjh='" + sjhRow["sjh"].ToString() + "'");

                        // foreach (DataRow sjdRow in dtSjd.Rows)
                        // {
                        //     DataRow sjdNewRow = casDataSet.sjd.NewRow();
                        //     foreach (DataColumn sjdCol in casDataSet.sjd.Columns)
                        //     {
                        //         if (sjdCol.ColumnName.ToString() == "Unit Base")
                        //             sjdNewRow[sjdCol.ColumnName] = dtBaseUnit.Select("inv='" + sjdNewRow["inv"].ToString() + "'")[0]["unit"];
                        //         else
                        //             if (sjdCol.ColumnName.ToString() == "klr" || sjdCol.ColumnName.ToString() == "date") ;
                        //             else
                        //                 sjdNewRow[sjdCol.ColumnName] = sjdRow[sjdCol.ColumnName];
                        //     }
                        //     //reset item number
                        ////     sjdNewRow["no"] = casDataSet.sjd.Rows.Count + 1;
                        //     casDataSet.sjd.Rows.Add(sjdNewRow);
                        // }
                        // gcxSjd.ExGridView.BestFitColumns();

                        // Add SOs to Invoice Tab                
                        /*DataRow kldRow = casDataSet.kld.NewRow();
                        if (casDataSet.kld.Select("okl='" + noSO + "'").Length > 0)
                            kldRow = casDataSet.kld.Select("okl='" + noSO + "'")[0];
                        else
                        {
                            kldRow["klr"] = sjhRow["klr"];
                            kldRow["no"] = casDataSet.kld.Rows.Count + 1;
                            kldRow["okl"] = sjhRow["okl"];
                            kldRow["kurs"] = dtResult.Select("okl='" + noSO + "'")[0]["kurs"];//omsRow["kurs"];
                            kldRow["dpp"] = 0;
                            casDataSet.kld.Rows.Add(kldRow);
                        }
                        kldRow["dpp"] = Convert.ToDouble(kldRow["dpp"]) + Convert.ToDouble(sjhRow["val"]);
                        if (Convert.ToInt64(dtResult.Select("okl='" + noSO + "'")[0]["ppn"]) == 1)//omsRow["ppn"]) == 1)
                            kldRow["ppn"] = Convert.ToDouble(kldRow["dpp"]) * 0.1;
                        else
                            kldRow["ppn"] = 0;
                        kldRow["val"] = Convert.ToDouble(kldRow["dpp"]) + Convert.ToDouble(kldRow["ppn"]);*/

                        DataRow kldRow = casDataSet.kld.NewRow();
                        DataRow[] drKld = dtKld.Select("okl='" + noSO + "'");
                        //if (drKld.Length > 0)
                        //{
                        //    for (int j = 0; j < drKld.Length; j++)
                        //    {
                        //        for (int i = 0; i < casDataSet.kld.Columns.Count - 1; i++)
                        //            kldRow[i] = drKld[0][i];
                        //    }
                        //}
                        //else
                        //{
                        kldRow["klr"] = sjhRow["klr"];
                        kldRow["okl"] = sjhRow["okl"];
                        kldRow["qty"] = sjhRow["qty"];
                        kldRow["inv"] = sjhRow["inv"];
                        if (sjhRow["okl"].ToString() != "")
                        {
                            kldRow["kurs"] = dtResult.Select("okl='" + noSO + "'")[0]["kurs"];
                            kldRow["dpp"] = Convert.ToDouble(kldRow["dpp"]) + Convert.ToDouble(sjhRow["val"]);
                            kldRow["price"] = Convert.ToDouble(kldRow["dpp"]) / Convert.ToDouble(kldRow["qty"]);
                            if (Convert.ToInt64(dtResult.Select("okl='" + noSO + "'")[0]["ppn"]) == 1)
                                kldRow["ppn"] = Convert.ToDouble(kldRow["dpp"]) * 0.1;
                            else
                                kldRow["ppn"] = 0;
                            kldRow["val"] = Convert.ToDouble(kldRow["dpp"]) + Convert.ToDouble(kldRow["ppn"]);
                        }
                        kldRow["no"] = casDataSet.kld.Rows.Count + 1;
                        casDataSet.kld.Rows.Add(kldRow);
                    }
                }

                gcxKld.ExGridView.BestFitColumns();
         }

        private void btnAddOkl_Click(object sender, EventArgs e)
        {
            FrmDialog oklDialog;

            if (!checkBox1.Checked)
                oklDialog = new FrmDialog("SO", DB.sql, "Call SP_SelectforInvoice('SO','" + ctrlSub.txtSub.EditValue.ToString() + "')");
            else
                oklDialog = new FrmDialog("SO", DB.sql, "Call SP_SelectforInvoice('SOS','" + ctrlSub.txtSub.EditValue.ToString() + "')");
            
            string orderNo = "";
            string sjNO = "";

            if (oklDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (DataRow oklRow in oklDialog.ResultRows)
                {
                 //   if (!chkMO.Checked)
                        orderNo = oklRow["SO"].ToString();
                        sjNO = oklRow["sj"].ToString();
                    //else
                    //    orderNo = oklRow["MO"].ToString();

                        if (dtResult.Rows.Find(orderNo) == null)
                        {

                            DataRow drResult = dtResult.NewRow();
                            drResult["okl"] = orderNo;
                            drResult["date"] = oklRow["Tanggal"];
                            drResult["remark"] = oklRow["Keterangan"];
                            drResult["kurs"] = oklRow["Kurs"];
                            drResult["ppn"] = oklRow["PPN"];
                            drResult["sub"] = oklRow["Customer"];
                            drResult["period"] = "";
                            drResult["cur"] = "";
                            drResult["chtime"] = "";
                            drResult["chusr"] = "";
                            drResult["nopoc"] = oklRow["No PO Cust"];
                            drResult["shiptoname"] = oklRow["Ship To"];
                            dtResult.Rows.Add(drResult);
                            listOkl.Items.Add(orderNo);
                        }
                        string query = "";
                        //     if (!chkMO.Checked)
                        //      {
                        if (!checkBox1.Checked)
                          query = "Call SP_SelectSOSJforKLR('@klr','@okl', 'SO','@sjl')";
                        else
                          query = "Call SP_SelectSOSJforKLR('@klr','@okl', 'SOS','@sjl')";
                       
                        query = query.Replace("@klr", NoDocument);
                        query = query.Replace("@okl", orderNo);
                        query = query.Replace("@sjl", sjNO);

                        //}
                        //else
                        //{
                        //    query = "Call SP_SelectSOSJforKLR('@klr','@mor', 'MO')";
                        //    query = query.Replace("@klr", NoDocument);
                        //    query = query.Replace("@mor", orderNo);
                        //        }
                        DataTable dtSjh = DB.sql.Select(query);

                        foreach (DataRow sjhRow in dtSjh.Rows)
                        {
                            DataRow kllRow = casDataSet.kll.NewRow();
                            foreach (DataColumn kllCol in casDataSet.kll.Columns)
                            {
                                kllRow[kllCol.ColumnName] = sjhRow[kllCol.ColumnName];
                            }
                            kllRow["no"] = casDataSet.kll.Rows.Count + 1;
                            casDataSet.kll.Rows.Add(kllRow);
                        }
                        gcxKll.ExGridView.BestFitColumns();
                        isiexport(orderNo); 
                }
                FillKldSjd();
               // FillSjdOkl();
                ReCalculateTotal();
                chkMO.Enabled = false;

               
            }

            RepositoryItemComboBox cboOms = (RepositoryItemComboBox)gcxKld.ExGridView.Columns["okl"].ColumnEdit;
            cboOms.Items.Clear();
            cboOms.Items.AddRange(listOkl.Items);
        }

        private void FillSjdOkl()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        private void isiexport(string okl)
        {
               DataRow row = ctrlSub.txtSub.ExGetDataRow();
               memoBank.Text = " PT.BANK MANDIRI (PERSERO) TBK  \n SURABAYA GENTENGKALI NO.93-95 SURABAYA - INDONESIA \n IN FAVOR OF PT. KARYAINDAH ALAM SEJAHTERA" +
                               " \n" + "USD ACCOUNT NO : 1410010618015 " + " \n " + "SWIFT CODE : BMRIIDJA851 ";
               string nama = row["nama"].ToString(); 
               string alamat = row["alamat"].ToString();
               memoMessrs.Text = nama + " \n" + alamat;
               memoNotify.Text  = nama + " \n" + alamat;

        }

        private void btnDeleteOkl_Click(object sender, EventArgs e)
        {
            if (listOkl.SelectedIndex < 0) return;

            // Remove POs from Invoice Tab
            DB.DeleteDetailRows(gcxKld.ExGridView);

            // Remove Inventories from Penerimaan Barang
            DB.DeleteDetailRows(gcxSjd.ExGridView);

            DB.DeleteDetailRows(gcxKll.ExGridView);

            int pos = listOkl.SelectedIndex;
            listOkl.SelectedIndex = -1;
            //listOms.Items.RemoveAt(listOms.SelectedIndex);
            listOkl.Items.RemoveAt(pos);
            dtResult.Rows.Remove(dtResult.Rows[pos]);

            RepositoryItemComboBox cboOms = (RepositoryItemComboBox)gcxKld.ExGridView.Columns["okl"].ColumnEdit;
            cboOms.Items.Clear();
            cboOms.Items.AddRange(listOkl.Items);
        }

        void gcxKll_tsbtnDelete_Click(object sender, EventArgs e)
        {
            // Remove Inventories from Penerimaan Barang
          //  DB.DeleteDetailRows(gcxSjd.ExGridView);

            DB.DeleteDetailRows(gcxKll.ExGridView);

            FillKldSjd();
            ReCalculateTotal();
        }

        void gcxKld_tsbtnDelete_Click(object sender, EventArgs e)
        {
            DB.DeleteDetailRows(gcxKld.ExGridView);
        }

        void gcxUmk_tsbtnDelete_Click(object sender, EventArgs e)
        {
            DB.DeleteDetailRows(gcxUmk.ExGridView);
        }

        private void txtSub_EditValueChanged(object sender, EventArgs e)
        {
            DataRow row = ctrlSub.txtSub.ExGetDataRow();
           /*
            if (row == null)
            {
                curcur.EditValue = "";
                return;
            }

            curcur.EditValue = row["cur"].ToString();
            
            spinTOP.EditValue = row["top"].ToString();
            */

            if (MasterBindingSource.Position == MasterTable.Rows.Count)
            btnAddOkl.PerformClick();

        if (DB.loginDate >= new DateTime(2013, 4, 1) && this.mode == Mode.New)
            maskfpj.Text = DB.sql.Select("SELECT F_getnopajak1('" + ctrlSub.txtSub.EditValue + "')").Rows[0][0].ToString();

        if (this.mode != Mode.View && row!= null)
        {
            string numfp = maskfpj.Text;
            DataTable dtseriFP = DB.sql.Select("select kodefp from sub where sub='" + ctrlSub.txtSub.EditValue.ToString() + "'");
            maskfpj.Text = dtseriFP.Rows[0][0].ToString() + numfp.Substring(3, 16);
            if (dtseriFP.Rows[0][0].ToString().Trim() == "")
                maskfpj.Text = "";

        }
        }

        private void listOkl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listOkl.SelectedIndex >= 0)
            {
                string oms = listOkl.SelectedItem.ToString();
                gcxKll.UnselectAll();
                for (int i = 0; i < gcxKll.ExGridView.RowCount; i++)
                {
                    if (gcxKll.ExGridView.GetDataRow(i) == null)
                    {
                        gcxKld.UnselectAll();
                          for (int j = 0; j < gcxKld.ExGridView.RowCount; j++)
                     {
                     if (gcxKld.ExGridView.GetDataRow(j) == null) return;
                     if ((gcxKld.ExGridView.GetDataRow(j) as DataRow)["okl"].ToString() == oms)
                        gcxKld.ExGridView.SelectRow(j);
                }
                    }
                    if (((gcxKll.ExGridView.GetDataRow(i) as DataRow)["okl"].ToString() == oms))
                    {
                        gcxKll.ExGridView.SelectRow(i);
                    }
                }

               
            }
        }


        void gcxKll_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            gcxSjd.UnselectAll();

            int[] selectedIndices = gcxKll.ExGridView.GetSelectedRows();
            if (selectedIndices == null) return;


            for (int i = 0; i < selectedIndices.Length; i++)
            {
                string okl = (gcxKll.ExGridView.GetDataRow(selectedIndices[i]) as DataRow)["okl"].ToString();          
                string sjh = (gcxKll.ExGridView.GetDataRow(selectedIndices[i]) as DataRow)["sjh"].ToString();
                for (int j = 0; j < gcxSjd.ExGridView.RowCount; j++)
                {
                    if ((gcxSjd.ExGridView.GetDataRow(j) as DataRow)["sjh"].ToString() == sjh)
                        gcxSjd.ExGridView.SelectRow(j);
                }       
            }
        }

        void ReCalculateTotal()
        {
            DetailBindingSource.EndEdit();
            double subTotal = 0;
            double ppn = 0;
            for (int i = 0; i < DetailTable.Rows.Count; i++)
            {
                if (DetailTable.Rows[i] != null && DetailTable.Rows[i].RowState != DataRowState.Deleted)
                {
                    subTotal = subTotal + (double)DetailTable.Rows[i]["dpp"];
                    //if (maskfpj.Text.Substring(0, 1) != " ")
                    ppn = ppn + (double)DetailTable.Rows[i]["ppn"];
                }
            }
            txtSubTotal.EditValue = subTotal;
            // ini ditutup    txtPPN.EditValue = ppn;

            // Collect Uang Muka
            umkBindingSource.EndEdit();
            double uangMuka = 0;
            double umppn = 0;
            for (int i = 0; i < casDataSet.umk.Rows.Count; i++)
            {
                if (casDataSet.umk.Rows[i] != null && casDataSet.umk.Rows[i].RowState != DataRowState.Deleted)
                {
                    uangMuka = uangMuka + (double)casDataSet.umk.Rows[i]["val"];
                    // ini dibuka
                    if (maskfpj.Text.Substring(0, 1) != "")
                        umppn = uangMuka * 0.1;
                }
                else
                    uangMuka = 0;
            }
            txtUangMuka.EditValue = uangMuka;

            /*  ini ditutup
                // Collect kld
                kldBindingSource.EndEdit();
                double kldppn = 0;
                for (int i = 0; i < casDataSet.kld.Rows.Count; i++)
                {
                    if (casDataSet.kld.Rows[i] != null && casDataSet.kld.Rows[i].RowState != DataRowState.Deleted && maskfpj.Text.Substring(0, 1).trim() != "")
                    {
                        //uangMuka = uangMuka + (double)casDataSet.umk.Rows[i]["val"];
                        kldppn = (double)DetailTable.Rows[i]["dpp"] * 0.1;
                    }
                    else
                        uangMuka = 0;
                }
            */

            double total = 0;
            if (maskfpj.Text.Substring(0, 1) == " ")
                total = subTotal - uangMuka;
            else
                total = subTotal + ((subTotal - uangMuka) * 0.1) - uangMuka;

            txtTotal.EditValue = total;

            if (uangMuka != 0)
                txtPPN.EditValue = ppn - umppn;
            else
                txtPPN.EditValue = ppn;

            textEdit1.EditValue = subTotal + ppn - uangMuka;

            //txtPPH.EditValue = pph;
            txtUangMuka.EditValue = uangMuka;
            total = subTotal + ppn - uangMuka;
            txtTotal.EditValue = total;
            txtSubTotal.EditValue = subTotal;
            txtPPN.EditValue = ppn;
            
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        { 
            int n = 0;
            try
            {
                // Validate controls
                this.Validate(); 
                this.ValidateChildren();
                  
                ((DataRowView)MasterBindingSource.Current).Row["duedate"] = ((DateTime)dateDate.EditValue).AddDays(Convert.ToDouble(spinTOP.EditValue));
                //((DataRowView)MasterBindingSource.Current).Row["mers"] = memoMessrs.Text;
              //  ((DataRowView)MasterBindingSource.Current).Row["bank"] = memoBank.Text;
              //  ((DataRowView)MasterBindingSource.Current).Row["notify"] = memoNotify.Text;
              //  ((DataRowView)MasterBindingSource.Current).Row["mark"] = memoMark.Text;
              //  ((DataRowView)MasterBindingSource.Current).Row["notes"] = memoNotes.Text; 
                //if (fpjTextEdit.EditValue.ToString().Trim().Length != 19)
                //    throw new Exception("Format no faktur pajak tidak valid");

                //loop DetailTable
                
                foreach (DataRow dr in DetailTable.Rows)
                {                    
                    if (dr != null && dr.RowState != DataRowState.Deleted)
                    {
                        n = n + 1;
                        if (dr.RowState == DataRowState.Added)
                            DB.sql.Execute("Delete from kld where klr='" + NoDocument + "' and okl='" + dr["okl"].ToString() + "'");
                        dr["invo"] = NoDocument;
                        dr["no"] = n ;
                        //dr["nofp"] = fpjTextEdit.EditValue.ToString();
                        dr["nofp"] = maskfpj.Text;
                        dr["tglfp"] = fpjdateDateEdit.EditValue;
                        dr["tglsfp"] = sfpjdateDateEdit.EditValue;
                        //if ((double)dr["ppn"] > 0 && dr["nofp"].ToString() == "")
                          //  throw new Exception("Harap mengisi nomor Faktur Pajak");
                        //if ((double)dr["ppn"] > 0 && dr["nofp"].ToString() != "" && dr["tglfp"].ToString() == "")
                          //  throw new Exception("Harap mengisi tanggal FP");
                    }
                }
                /*
                double totinv = 0; 
                foreach (DataRow dr in casDataSet.sjd.Rows)
                {
              if (dr != null && dr.RowState != DataRowState.Deleted)
                    {
                        totinv = totinv + (double)(dr["val"]);
                        //if ((double)dr["ppn"] > 0 && dr["nofp"].ToString() == "")
                        //  throw new Exception("Harap mengisi nomor Faktur Pajak");
                        //if ((double)dr["ppn"] > 0 && dr["nofp"].ToString() != "" && dr["tglfp"].ToString() == "")
                        //  throw new Exception("Harap mengisi tanggal FP");
                    }
                }
              
                if (totinv != (double) this.txtSubTotal.EditValue)
                    throw new Exception("DPP di kolom Invoice tidak sama dengan harga di penerimaan barang");
               */

                base.tsbtnSave_Click(sender, e);
                if (this.mode == Mode.View)
                {
                    // Update NoDocument
                    for (int i = 0; i < casDataSet.kll.Rows.Count; i++)
                       if (casDataSet.kll.Rows[i].RowState != DataRowState.Deleted)
                            casDataSet.kll.Rows[i][0] = NoDocument;
                    for (int i = 0; i < casDataSet.umk.Rows.Count; i++)
                       if (casDataSet.umk.Rows[i].RowState != DataRowState.Deleted)
                            casDataSet.umk.Rows[i][0] = NoDocument;

                    kllBindingSource.EndEdit();
                    kllAdapter.Update(casDataSet.kll);
                    umkBindingSource.EndEdit();
                    umkAdapter.Update(casDataSet.umk);

             //       sjdBindingSource.EndEdit();
             //       sjdAdapter.Update(casDataSet.sjd);

                    string date = ((DateTime)(dateDate.EditValue)).ToString("yyyyMMdd");
                    DB.sql.Execute("Call SP_Save(" + date + ",'KLR'" + ",'" + NoDocument + "')");

                    btnAddOkl.Enabled = false;
                    btnDeleteOkl.Enabled = false;

                    // disable all GridControls
                    gcxKld.ExGridView.OptionsBehavior.Editable = false;
                    gcxKld.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;

                    gcxUmk.ExGridView.OptionsBehavior.Editable = false;
                    gcxUmk.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;

                    gcxSjd.ExGridView.OptionsBehavior.Editable = false;
                    gcxSjd.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected override void tsbtnCancel_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;

            casDataSet.kll.RejectChanges();
      //      casDataSet.sjd.RejectChanges();
            casDataSet.umk.RejectChanges();
            base.tsbtnCancel_Click(sender, e);

            if (this.mode == Mode.View)
            {
                RePopulate_List_Cbo_Okl();
                btnAddOkl.Enabled = false;
                btnDeleteOkl.Enabled = false;
                ReCalculateTotal();

                // disable all GridControls
                gcxKld.ExGridView.OptionsBehavior.Editable = false;
                gcxKld.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;

                gcxUmk.ExGridView.OptionsBehavior.Editable = false;
                gcxUmk.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;

                gcxSjd.ExGridView.OptionsBehavior.Editable = false;
                gcxSjd.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;

                gcxKll.ExGridView.OptionsBehavior.Editable = false;
                gcxKll.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;

            }
        }

        private void txtNo_EditValueChanged(object sender, EventArgs e)
        {
            ReCalculateTotal();
            if (MasterBindingSource.Position != MasterTable.Rows.Count)
            {
                DateTime dueDate = ((DateTime)MasterTable.Rows[MasterBindingSource.Position]["duedate"]).Date;
                DateTime date = ((DateTime)MasterTable.Rows[MasterBindingSource.Position]["date"]).Date;
                spinTOP.EditValue = ((TimeSpan)dueDate.Subtract(date)).TotalDays;
            }
        }

        private void tabDetails_Click(object sender, EventArgs e)
        {
            kldBindingSource.EndEdit();
            Cinvo.Items.Clear();
            for (int i = 0; i < casDataSet.kld.Rows.Count; i++)
            {
                if (casDataSet.kld.Rows[i] != null && casDataSet.kld.Rows[i].RowState != DataRowState.Deleted)
                {
                    string invc = (string)DetailTable.Rows[i]["invo"];
                    Cinvo.Items.Add(invc);

                }
            }
        }

        private void fpjdateDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (fpjdateDateEdit.EditValue.ToString() != "")
            {
                DateTime tglFP = (DateTime)fpjdateDateEdit.EditValue;
                DateTime tglSetorFP = new DateTime(tglFP.Year, tglFP.Month, 15);
                if (tglFP.Day > 15)
                    tglSetorFP = tglSetorFP.AddMonths(1);
                sfpjdateDateEdit.DateTime = tglSetorFP;
            }
        }

        private void dateDate_EditValueChanged(object sender, EventArgs e)
        {
            dateJatuhTempo.DateTime = dateDate.DateTime.AddDays(Convert.ToDouble(spinTOP.EditValue));
        }

        private void spinTOP_EditValueChanged(object sender, EventArgs e)
        {
            dateJatuhTempo.DateTime = dateDate.DateTime.AddDays(Convert.ToDouble(spinTOP.EditValue));
        }

        private void btnDocFlow_Click(object sender, EventArgs e)
        {

        }

        private void ctrlSub_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            DataTable dt_oto = DB.sql.Select("SELECT usr.* FROM usr,usrlevel where usr.role=usrlevel.role and trim(user) ='" + DB.casUser.User.ToString() + "'");

            if (this.mode == Mode.Edit && dt_oto.Rows[0]["pswd"].ToString().Trim() == "")
            {
                PassOto frmDoc = new PassOto();
                if (frmDoc.ShowDialog() == DialogResult.OK)
                {

                }
                else
                {
                    checkBox1.Checked = false; 
                }
            }
        }

        private void memoMessrs_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void memoBank_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void curcur_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}