using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KASLibrary;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraReports.UI;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using MySql.Data.MySqlClient;


namespace CAS.Transaction
{
    public partial class FrmTKwitansi : CAS.Transaction.BaseTransaction
    {
        double total = 0;
        double penjualan = 0;
        double retur = 0;
        public FrmTKwitansi()
        {
            InitializeComponent();
            DetailTable.Columns.Add("nama", typeof(String));
            Utility.SetSqlInstance(pnlDetail, DB.sql);
            gckwt.ExGridControl.DataSource = kwdBindingSource;
            gckwt.ExGridView.Columns["kwt"].Visible = false;
            gckwt.ExGridView.Columns["no"].Visible = false;
            gckwt.ExGridView.Columns["nama"].Visible = false;
            gckwt.ExGridView.Columns["valdisc"].Visible = false;
            gckwt.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gckwt.ExToolStrip.Items["tsbtnNew"].Enabled = false;

            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnDelete.Click += new EventHandler(tsbtnDelete_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
            tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            tsbtnPrint.Click += new EventHandler(tsbtnPrint_Click);


            gckwt.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
            gckwt.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
            gckwt.ExGridView.CellValueChanged += new CellValueChangedEventHandler(ExGridView_CellValueChanged);
            gckwt.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
            string querykw = "select * from (select klr as `Nomor Invoice`,kld.nofp as `Nomor Faktur Pajak`,kld.remark as Keterangan,";
            querykw = querykw + " kld.dpp as `Nilai DPP`,if(left(kld.nofp,1)='' or left(kld.nofp,3)='070',0,kld.ppn ) as `Nilai PPN`,kld.val as `Nilai Subtotal`,kwd.jurnal from kld  ";
            querykw = querykw + " left outer join kwd on kld.klr=kwd.jurnal where kld.nofp<>'') as tmp where tmp.jurnal is null" +
               " union all " +
               " select * from (select rkd.rkl as `Nomor Invoice`,rkd.nofp as `Nomor Faktur Pajak`,rkd.invo as Keterangan, " +
               " rkd.dpp as `Nilai DPP`,rkd.ppn as `Nilai PPN`,rkd.val as `Nilai Subtotal`,kwd.jurnal from  " +
               " rkd  left outer join kwd on rkd.rkl=kwd.jurnal and rkd.nofp=kwd.fpj) as tmp where tmp.jurnal is null " +
               " union all " +
               " select * from (select fpjumd.oms,fpjumd.nofpj,'' remark,fpjumd.val,fpjumd.val*0.1 as ppn,fpjumd.val*1.1 subtotal,kwd.jurnal from fpjumd " +
               " left outer join kwd on kwd.jurnal=fpjumd.oms and kwd.fpj=fpjumd.nofpj ) as tmp2 where tmp2.jurnal is null";

            gckwt.ExGridView.Columns["jurnal"].ColumnEdit = new GridLookUpEx(DB.sql, querykw, "klr", "klr", gckwt.ExGridView, "", true, true, "Detail kwitansi");
            gckwt.ExGridView.Columns["jurnal"].ColumnEdit.Enter += new EventHandler(jurnalColumnEdit_Enter);

            gckwt.ExGridView.Columns["jsu"].ColumnEdit = new GridLookUpEx(DB.sql, querykw, "jsu", "jsu", gckwt.ExGridView, "", true, true, "Detail Kredit Note");
            gckwt.ExGridView.Columns["jsu"].ColumnEdit.Enter += new EventHandler(jsuColumnEdit_Enter);

            gckwt.ExTitleLabel.Text = "Detail Pelunasan";
            gckwt.ExGridView.Columns["jurnal"].Caption = "Nomor Invoice";
            gckwt.ExGridView.Columns["fpj"].Caption = "Nomor Faktur Pajak";
            gckwt.ExGridView.Columns["jsu"].Caption = "KreditNote";
            gckwt.ExGridView.Columns["rem"].Caption = "Keterangan";
            gckwt.ExGridView.Columns["valdpp"].Caption = "Nilai DPP";
            gckwt.ExGridView.Columns["valppn"].Caption = "Nilai PPN";
            gckwt.ExGridView.Columns["valsubtotal"].Caption = "Nilai Subtotal";

            gckwt.ExGridView.Columns["jurnal"].VisibleIndex = 0;
            gckwt.ExGridView.Columns["rem"].VisibleIndex = 2;
            gckwt.ExGridView.Columns["jsu"].VisibleIndex = 3;
            gckwt.ExGridView.Columns["fpj"].VisibleIndex = 1;
            gckwt.ExGridView.Columns["valdpp"].VisibleIndex = 4;
            gckwt.ExGridView.Columns["valppn"].VisibleIndex = 5;
            gckwt.ExGridView.Columns["valsubtotal"].VisibleIndex = 6;

            // gckwt.ExGridView.BestFitColumns();
            gckwt.ExGridView.OptionsBehavior.Editable = true;
            gckwt.ExGridView.OptionsSelection.MultiSelect = true;
            gckwt.ExGridView.OptionsCustomization.AllowSort = false;
            gckwt.ExGridView.OptionsView.ShowGroupPanel = false;
            gckwt.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            DB.SetNumberFormat(gckwt.ExGridView, "n2");
            gckwt.ExGridView.BestFitColumns();
            //      tsbtnPrint.Click += new EventHandler(tsbtnPrint_Click);


        }
        void settinggrid()
        {
            gckwt.ExGridView.CellValueChanged += new CellValueChangedEventHandler(ExGridView_CellValueChanged);
            gckwt.ExGridView.Columns["jurnal"].ColumnEdit = new GridLookUpEx(DB.sql, "Select 0", "klr", "klr", gckwt.ExGridView, "", true, true, "Detail kwitansi");
            gckwt.ExGridView.Columns["jurnal"].ColumnEdit.Enter += new EventHandler(jurnalColumnEdit_Enter);

            gckwt.ExGridView.Columns["jsu"].ColumnEdit = new GridLookUpEx(DB.sql, "Select 0", "jsu", "jsu", gckwt.ExGridView, "", true, true, "Detail Kredit Note");
            gckwt.ExGridView.Columns["jsu"].ColumnEdit.Enter += new EventHandler(jsuColumnEdit_Enter);

            gckwt.ExGridView.Columns["kwt"].Visible = false;
            gckwt.ExGridView.Columns["no"].Visible = false;
            gckwt.ExGridView.Columns["nama"].Visible = false;
            gckwt.ExGridView.Columns["valdisc"].Visible = false;
            gckwt.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gckwt.ExToolStrip.Items["tsbtnNew"].Enabled = false;
            gckwt.ExTitleLabel.Text = "Detail Pelunasan";
            gckwt.ExGridView.Columns["jurnal"].Caption = "Nomor Invoice";
            gckwt.ExGridView.Columns["fpj"].Caption = "Nomor Faktur Pajak";
            gckwt.ExGridView.Columns["jsu"].Caption = "KreditNote";
            gckwt.ExGridView.Columns["rem"].Caption = "Keterangan";
            gckwt.ExGridView.Columns["valdpp"].Caption = "Nilai DPP";
            gckwt.ExGridView.Columns["valppn"].Caption = "Nilai PPN";
            gckwt.ExGridView.Columns["valsubtotal"].Caption = "Nilai Subtotal";

            gckwt.ExGridView.Columns["jurnal"].VisibleIndex = 0;
            gckwt.ExGridView.Columns["rem"].VisibleIndex = 2;
            gckwt.ExGridView.Columns["jsu"].VisibleIndex = 3;
            gckwt.ExGridView.Columns["fpj"].VisibleIndex = 1;
            gckwt.ExGridView.Columns["valdpp"].VisibleIndex = 4;
            gckwt.ExGridView.Columns["valppn"].VisibleIndex = 5;
            gckwt.ExGridView.Columns["valsubtotal"].VisibleIndex = 6;

            // gckwt.ExGridView.BestFitColumns();
            gckwt.ExGridView.OptionsBehavior.Editable = true;
            gckwt.ExGridView.OptionsSelection.MultiSelect = true;
            gckwt.ExGridView.OptionsCustomization.AllowSort = false;
            gckwt.ExGridView.OptionsView.ShowGroupPanel = false;
            gckwt.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            DB.SetNumberFormat(gckwt.ExGridView, "n2");
            gckwt.ExGridView.BestFitColumns();
        }
        private void subTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {
            if (ctrlSub.txtSub.ExGetDataRow() != null )
            revkwtTextBoxEx.ExSqlQuery = "select kwt,date,sub as kodecustomer,remark from kwt where kwt.date >= adddate(date(now()),interval -1 year) and kwt.sub='" + ctrlSub.txtSub.ExGetDataRow().ItemArray[0].ToString() + "'";
        }
        void tsbtnNew_Click(object sender, EventArgs e)
        {
            DetailTable.Clear();
            casDataSet.kwd.Clear();
            gckwt.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gckwt.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gckwt.ExGridView.OptionsBehavior.Editable = true;
            gckwt.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            ReCalculateTotal();

            Utility.SetReadOnly(txtTotal, true);
        }
        private void FrmTKwitansi_Load(object sender, EventArgs e)
        {
            // Utility.SetNumberFormat(pnlDetail, "n2");
            ctrlSub.txtSub.DataBindings.Add("EditValue", kwtBindingSource, "sub");
            ctrlSub.txtSub.EditValueChanged += new EventHandler(subTextBoxEx_EditValueChanged);
            gckwt.ExGridView.BestFitColumns();
            ReCalculateTotal();
            // TODO: This line of code loads data into the 'casDataSet.kwd' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'casDataSet.kwt' table. You can move, or remove it, as needed.
        }

        void ExGridView_New_Click(object sender, EventArgs e)
        {
            DataRow row = casDataSet.kwd.NewRow();
            row["kwt"] = NoDocument;
            row["valdpp"] = 0;
            row["valsubtotal"] = 0;
            row["valppn"] = 0;
            row["no"] = DB.GetRowCount(casDataSet.kwd) + 1;
            casDataSet.kwd.Rows.Add(row);

            DB.InsertDetailRows(gckwt.ExGridView, row);
            ReCalculateTotal();
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            //if (this.mode == Mode.Edit)
            //{
            //    gckwt.ExGridView.OptionsBehavior.Editable = true;
            //    gckwt.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            //}
            gckwt.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gckwt.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gckwt.ExGridView.OptionsBehavior.Editable = true;
            gckwt.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
        }

        protected override void tsbtnCancel_Click(object sender, EventArgs e)
        {
            DB.CancelDetailRows(DetailTable);
            remarkMemoEdit.Focus();
            base.tsbtnCancel_Click(sender, new EventArgs());

            if (this.mode == Mode.View)
            {
                ReCalculateTotal();

                gckwt.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                gckwt.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                gckwt.ExGridView.OptionsBehavior.Editable = false;
                gckwt.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;

                //isDetailValid = true;
                ctrlSub.ReadOnly = true;
                //isDetailChanged = false;

                //DetailTable = DB.PopulateUnitBase(DetailTable, "Unit Base");
                //DetailTable = DB.PopulateDateNeed(DetailTable, "Tgl Dibutuhkan");
            }
        }

        void tsbtnPrint_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepKwitansi" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("Call SP_Print('" + this.Name + "','" + this.NoDocument + "')");
            //DataTable dt = DB.sql.Select("Call SP_Kwitansi()");
            report.DataSource = dt;

            if (revkwtTextBoxEx.Text.Trim() != "")
            {
                dt.Rows[0]["kwt"] = revkwtTextBoxEx.Text.Trim();
                report.Controls["PageHeader"].Controls["xrLabel15"].Visible = true;
            }
            string fakturpajak, fakturpenjualan, temppjl;
            fakturpajak = "";
            temppjl = "";
            fakturpenjualan = "";
            for (int i = 0; i < DetailTable.Rows.Count; i++)
            {
                if (DetailTable.Rows[i] != null && DetailTable.Rows[i].RowState != DataRowState.Deleted)
                {
                    if (fakturpajak == "")
                    {
                        fakturpajak = fakturpajak + DetailTable.Rows[i]["fpj"].ToString() + ", ";
                        fakturpenjualan = fakturpenjualan + DetailTable.Rows[i]["jurnal"].ToString() + ", ";
                    }
                    else
                    {
                        if (DetailTable.Rows[i]["fpj"].ToString().Length < 19)
                        {
                            fakturpajak = fakturpajak + DetailTable.Rows[i]["fpj"].ToString() + ", ";
                            if (temppjl != DetailTable.Rows[i]["jurnal"].ToString())
                                fakturpenjualan = fakturpenjualan + DetailTable.Rows[i]["jurnal"].ToString() + ", ";
                        }
                        else
                        {
                            if (revkwtTextBoxEx.Text.Trim()=="")   
                                fakturpajak = fakturpajak + DetailTable.Rows[i]["fpj"].ToString().Substring(12, 7) + ", ";
                            else
                                fakturpajak = fakturpajak + DetailTable.Rows[i]["fpj"].ToString() + ", ";
                            
                            fakturpenjualan = fakturpenjualan + DetailTable.Rows[i]["jurnal"].ToString().Substring(4, 11) + ", ";
                        }
                        temppjl = DetailTable.Rows[i]["jurnal"].ToString();
                    }
                }
            }

            //hitung dpp dan ppn dollar
            double DPP = 0;
            double PPN = 0;
            double subtotal = 0;
            double kurs = 0;

            kurs = (double)dt.Rows[0]["kurs"];

            for (int i = 0; i < DetailTable.Rows.Count; i++)
            {
                DPP = DPP + (double)DetailTable.Rows[i]["valdpp"];
                PPN = PPN + (double)DetailTable.Rows[i]["valppn"] * kurs;
            }
            subtotal = PPN + DPP;



            if (fakturpajak != "") fakturpajak = fakturpajak.Substring(0, fakturpajak.Length - 2);
            if (fakturpenjualan != "") fakturpenjualan = fakturpenjualan.Substring(0, fakturpenjualan.Length - 2);

            ReCalculateTotal();
            //    report.Controls["Detail"].Controls["xrLabelTerbilang"].Text = Utility.NumberToText(total).Substring(0, 1).ToUpper() + Utility.NumberToText(total).Substring(1, Utility.NumberToText(total).Length-1) + " rupiah";
            report.Controls["Detail"].Controls["xrLabelFakturPajak"].Text = fakturpajak;
            report.Controls["Detail"].Controls["xrLabelFakturPenjualan"].Text = fakturpenjualan;
            //   report.Controls["Detail"].Controls["xrLabelPenjualan"].Text = penjualan.ToString("#,0.00");
            //   report.Controls["Detail"].Controls["xrLabelRetur"].Text = retur.ToString("#,0.00");
            if (fakturpenjualan.ToString() != " ")
            {
                if (fakturpenjualan.Substring(0, 3) == "SOL")
                    report.Controls["Detail"].Controls["xrLabel20"].Text = "Uang Muka Penjualan dengan Sales Order Nomor : ";
            }
            if (kurs <= 1)
            {
                report.Controls["Detail"].Controls["xrLabelTotal"].Text = subtotal.ToString("#,0.00");
                report.Controls["Detail"].Controls["xrLabelTerbilang"].Text = terbilang(total, "IDR").Substring(0, 1).ToUpper() + terbilang(total, "IDR").Substring(1, terbilang(total, "IDR").Length - 1);
                report.Controls["Detail"].Controls["xrLabelKurs"].Visible = false;
                report.Controls["Detail"].Controls["xrLabel14"].Visible = false;
                report.Controls["Detail"].Controls["xrLabelPPN"].Visible = false;
                report.Controls["Detail"].Controls["xrLabelterbilangppn"].Visible = false;
            }
            else
            {
                report.Controls["Detail"].Controls["xrLabelTerbilang"].Text = "DPP = " + terbilang(DPP, "USD").Substring(0, 1).ToUpper() + terbilang(DPP, "USD").Substring(1, terbilang(DPP, "USD").Length - 1);
                report.Controls["Detail"].Controls["xrLabelterbilangppn"].Text = "PPN = " + terbilang(PPN, "IDR").Substring(0, 1).ToUpper() + terbilang(PPN, "IDR").Substring(1, terbilang(PPN, "IDR").Length - 1);
                report.Controls["Detail"].Controls["xrLabelRp"].Text = "USD";
                report.Controls["Detail"].Controls["xrLabelKurs"].Text = "Kurs Pajak = " + kurs.ToString("#,0.00");
                report.Controls["Detail"].Controls["xrLabelTotal"].Text = DPP.ToString("#,0.00");
                report.Controls["Detail"].Controls["xrLabelPPN"].Text = PPN.ToString("#,0.00");
            }
            report.PaperName = "1/2A4";
            report.ShowPreview();
            //report.RunDesigner();
        }

        public static string terbilang(object spin, string kurs)
        {
            string result = "";
            if (kurs == "IDR")
            {
                double angka = Convert.ToDouble(spin);
                double depankoma = Math.Floor(angka);
                double belakangkoma = Math.Round((angka - depankoma), 2) * 100;
                result = Utility.NumberToText(depankoma);
                int blakangkoma = Convert.ToInt32(belakangkoma);
                string blakangkoma1 = Math.Round((double)spin, 2).ToString().Substring(spin.ToString().IndexOf(',') + 1);
                if (blakangkoma > 0)
                    result += "koma " + Utility.NumberToTextPecahan(blakangkoma1) + " Rupiah";
                else
                    result += " Rupiah";
            }
            else if (kurs == "USD")
            {
                double angka = Convert.ToDouble(spin);
                int depankoma = Convert.ToInt32(Math.Floor(angka));
                int belakangkoma = Convert.ToInt32(Math.Round((angka - depankoma), 2) * 100);
                result = Utility.NumberToTextEN(depankoma);
                if (belakangkoma > 0)
                    result += "point " + Utility.NumberToTextEN(belakangkoma) + "Cent USD";
                else
                    result += " USD";
            }
            return result;
        }
        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gckwt.ExGridView.GetDataRow(e.RowHandle);
            row["kwt"] = NoDocument;
            row["no"] = DB.GetRowCount(casDataSet.kwd) + 1;
        }

        private void CalculateTotalkwt()
        {
            try
            {
                DetailBindingSource.EndEdit();

                double totalkwt = 0;
                for (int i = 0; i < DetailTable.Rows.Count; i++)
                {
                    if (DetailTable.Rows[i] != null && DetailTable.Rows[i].RowState != DataRowState.Deleted)
                    {
                        totalkwt = totalkwt + (double)DetailTable.Rows[i]["valsubtotal"];
                    }
                }
                txtTotal.EditValue = totalkwt;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        void ExGridView_Delete_Click(object sender, EventArgs e)
        {
            bool canDeleteitem, canDelete = true;
            int[] selectedIndex = gckwt.ExGridView.GetSelectedRows();
            if (selectedIndex.Length > 0)
            {
                for (int i = 0; i < selectedIndex.Length; i++)
                {
                    string kwt = gckwt.ExGridView.GetDataRow(selectedIndex[i])["kwt"].ToString();
                    int no = Convert.ToInt32(gckwt.ExGridView.GetDataRow(selectedIndex[i])["no"]);
                    canDeleteitem = DeleteLineItem(kwt, no);
                    if (canDeleteitem == false) canDelete = false;
                }
                if (canDelete)
                {
                    DB.DeleteDetailRows(gckwt.ExGridView);
                    CalculateTotalkwt();
                    //if (DetailTable.GetChanges() != null)
                    //    DetailAdapter.Update(DetailTable);
                }
            }
        }

        void jurnalColumnEdit_Enter(object sender, EventArgs e)
        {
            string querykw = "call `SP_klrkwitansi`('" + ctrlSub.txtSub.EditValue.ToString() + "'," + dateDate.DateTime.ToString("yyyyMMdd") + ")";
            /*
            "select * from (select kld.klr as `Nomor Invoice`,kld.nofp as `Nomor Faktur Pajak`,kld.remark as Keterangan,";
        querykw = querykw + " sum(kld.dpp) as `Nilai DPP`,if(left(kld.nofp,3)='070' or left(kld.nofp,1)=' ',0,sum(kld.ppn)) as `Nilai PPN`,if(left(kld.nofp,3)='070' or left(kld.nofp,1)=' ',sum(kld.dpp),sum(kld.val)) as `Nilai Subtotal`,kwd.jurnal from klr, kld ";
        querykw = querykw + " left outer join kwd on kld.klr=kwd.jurnal " +
            " where klr.klr=kld.klr and klr.sub='" + ctrlSub.txtSub.EditValue.ToString() + "' " +
            " and date_format(date(klr.date),'%Y%m%d')<=" + dateDate.DateTime.ToString("yyyyMMdd") + 
            " group by kld.klr) as tmp where tmp.jurnal is null " +
            " union all " +
            " select * from (select rkd.rkl as `Nomor Invoice`,rkd.nofp as `Nomor Faktur Pajak`,rkd.invo as Keterangan, "+
            " -sum(rkd.dpp) as `Nilai DPP`,-if(left(rkd.nofp,3)='070',0,sum(rkd.ppn)) as `Nilai PPN`,if(left(rkd.nofp,3)='070',sum(rkd.dpp),sum(rkd.val)) as `Nilai Subtotal`,kwd.jurnal from rkl, " +
            " rkd  left outer join kwd on rkd.rkl=kwd.jurnal and rkd.nofp=kwd.fpj  where rkl.rkl=rkd.rkl and rkl.sub='" + ctrlSub.txtSub.EditValue.ToString() + "'" +
            " and date_format(date(rkl.date),'%Y%m%d')<=" + dateDate.DateTime.ToString("yyyyMMdd") + " group by rkd.rkl,rkd.nofp) as tmp where tmp.jurnal is null " +
            " union all " +
           " select * from (select fpjumd.oms,fpjumd.nofpj,'' remark,fpjumd.val,if(left(fpjumd.nofpj,3)='070' or left(fpjumd.nofpj,1)=' ',0,fpjumd.val*0.1) as ppn,fpjumd.val*if(left(fpjumd.nofpj,3)='070' or left(fpjumd.nofpj,1)=' ',1,1.1) subtotal,kwd.jurnal from fpjumd " +
           " left outer join kwd on kwd.jurnal=fpjumd.oms and kwd.fpj=fpjumd.nofpj ) as tmp2 where tmp2.jurnal is null";
        */
            // querykw = querykw + " and tmp.klr=klr.klr and klr.sub='" + ctrlSub.txtSub.EditValue.ToString() + "'";
            // gckwt.ExGridView.Columns["jurnal"].ColumnEdit = new GridLookUpEx(DB.sql, querykw, "klr", "klr", gckwt.ExGridView, "", true, true, "Detail kwitansi");

            (gckwt.ExGridView.Columns["jurnal"].ColumnEdit as GridLookUpEx).Query = querykw;
        }

        void jsuColumnEdit_Enter(object sender, EventArgs e)
        {
            string queryjsu = "select jsu as KreditNote,date,val from jsu where sub ='" + ctrlSub.txtSub.EditValue.ToString() + "'";
           (gckwt.ExGridView.Columns["jsu"].ColumnEdit as GridLookUpEx).Query = queryjsu;
        }

        private void txtNo_EditValueChanged(object sender, EventArgs e)
        {
            if (MasterBindingSource.Position != MasterTable.Rows.Count)
            {
                ReCalculateTotal();
            }
        }

        double ReCalculateTotal()
        {
            //   DetailBindingSource.EndEdit();

            total = 0;
            penjualan = 0;
            retur = 0;
            for (int i = 0; i < DetailTable.Rows.Count; i++)
            {
                if (DetailTable.Rows[i] != null && DetailTable.Rows[i].RowState != DataRowState.Deleted)
                {
                    if (DetailTable.Rows[i]["valsubtotal"] != null)
                        if ((Double)DetailTable.Rows[i]["valsubtotal"] > 0)
                            penjualan = penjualan + (double)DetailTable.Rows[i]["valsubtotal"];
                        else
                            retur = retur + (double)DetailTable.Rows[i]["valsubtotal"];

                    total = total + (double)DetailTable.Rows[i]["valsubtotal"];
                }
            }

            txtTotal.EditValue = total;
            return total;
        }

        void ExGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "jsu")
            {
                if ((string)gckwt.ExGridView.GetFocusedRowCellValue("jsu") != "")
                {
                    gckwt.ExGridView.SetFocusedRowCellValue(gckwt.ExGridView.Columns["fpj"], gckwt.ExGridView.GetFocusedRowCellValue("fpj").ToString().Remove(2, 1).Insert(2, "1"));
                }
            }
            ReCalculateTotal();
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ReCalculateTotal();
                this.ValidateChildren();

                if (gckwt.ExGridView.EditingValue != null)
                    gckwt.ExGridView.SetFocusedValue(gckwt.ExGridView.EditingValue);

                DetailBindingSource.EndEdit();


                //double totVal = 0;
                for (int i = DetailTable.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = DetailTable.Rows[i];
                    if (row != null && row.RowState != DataRowState.Deleted)
                    {
                        row[0] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
                        //row["no"] = i + 1;
                        //totVal = totVal + (double)row["val"];
                    }
                }

                base.tsbtnSave_Click(sender, e);
                if (this.mode == Mode.View)
                {
                    gckwt.ExGridView.OptionsBehavior.Editable = false;
                    gckwt.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                    gckwt.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                    gckwt.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void revkwtTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {
            if (this.mode != Mode.View && revkwtTextBoxEx.EditValue.ToString() !=""  )
            {
                //       remarkMemoEdit.EditValue = revkwtTextBoxEx.ExGetDataRow()["remark"];
                gckwt.ExGridControl.DataSource = null;
                DetailTable.Clear();
                int tNo = 9999;
                foreach (DataRow dr in DetailTable.Rows)
                {
                    dr["no"] = tNo;
                    dr.Delete();
                    tNo++;
                }
                DataTable dtkwt = DB.sql.Select("select * from kwd where kwt='" + revkwtTextBoxEx.Text + "'");
                int no = 1;
                foreach (DataRow drSpbd in dtkwt.Rows)
                {
                    DataRow drLpd = DetailTable.NewRow();
                    drLpd["kwt"] = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
                    drLpd["no"] = no;
                    drLpd["fpj"] = drSpbd["fpj"];
                    drLpd["rem"] = drSpbd["rem"];
                    drLpd["valdpp"] = drSpbd["valdpp"];
                    drLpd["valppn"] = drSpbd["valppn"];
                    drLpd["valdisc"] = drSpbd["valdisc"];
                    drLpd["valsubtotal"] = drSpbd["valsubtotal"];
                    drLpd["jurnal"] = drSpbd["jurnal"];
                    drLpd["jsu"] = "";
                    DetailTable.Rows.Add(drLpd);
                    no++;
                }
                gckwt.ExGridControl.DataSource = DetailTable;
                gckwt.ExGridView.OptionsBehavior.Editable = true;
                settinggrid(); 
            }
        }

        private void remarkMemoEdit_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}

