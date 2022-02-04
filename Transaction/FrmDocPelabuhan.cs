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

namespace CAS.Transaction
{
    public partial class FrmDocPelabuhan : BaseTransaction
    {
        string modenya = "";
        public FrmDocPelabuhan()
        {
            InitializeComponent();
            Utility.SetSqlInstance(pnlDetail, DB.sql);
            omsTextBoxEx.ExSqlQuery = "call sp_sopo()";
            gcRFD.ExGridControl.DataSource = docpdBindingSource;
            gcRFD.ExGridView.Columns["docp"].Visible = false;
            gcRFD.ExGridView.Columns["no"].Visible = false;
            gcRFD.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gcRFD.ExToolStrip.Items["tsbtnNew"].Enabled = false;
            
            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            tsbtnDelete.Click += new EventHandler(tsbtnDelete_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);

            gcRFD.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
            gcRFD.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
            gcRFD.ExGridView.CellValueChanged += new CellValueChangedEventHandler(ExGridView_CellValueChanged);
            gcRFD.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);

            gcRFD.ExGridView.Columns["nodoc"].ColumnEdit = new GridLookUpEx(DB.sql, "Call Sp_GetDocTpb(" + ((DateTime)dateDate.EditValue).ToString("yyyyMMdd") + ")", "", "nodoc", gcRFD.ExGridView, "", true, true, "Nomor Dokumen");
            gcRFD.ExGridView.Columns["nodoc"].ColumnEdit.Enter += new EventHandler(ExGridView_NoDocColumnEdit_Enter);
          
            
            gcRFD.ExTitleLabel.Text = "Detail Pelunasan";
            gcRFD.ExGridView.Columns["nodoc"].Caption = "No. reff doc";
            gcRFD.ExGridView.Columns["nopen"].Caption = "No. Pendaftaran";
            gcRFD.ExGridView.Columns["datedoc"].Caption = "Tanggal Doc";
            gcRFD.ExGridView.Columns["remmark"].Caption = "Keterangan";
            gcRFD.ExGridView.Columns["no_bc"].Caption = "No. Document Pelabuhan";

            gcRFD.ExGridView.BestFitColumns();
            gcRFD.ExGridView.OptionsBehavior.Editable = false;
            gcRFD.ExGridView.OptionsSelection.MultiSelect = true;
            gcRFD.ExGridView.OptionsCustomization.AllowSort = false;
            gcRFD.ExGridView.OptionsView.ShowGroupPanel = false;
            DB.SetNumberFormat(gcRFD.ExGridView, "n2");
            tsbtnPrint.Click += new EventHandler(tsbtnPrint_Click);           
        }

        void ExGridView_NoDocColumnEdit_Enter(object sender, EventArgs e)
        {
            if (jnspTextBoxEx.EditValue.ToString() == "BC 3.0")
            {
                (gcRFD.ExGridView.Columns["nodoc"].ColumnEdit as GridLookUpEx).Query = "Call Sp_GetDocPeb(" + ((DateTime)dateDate.EditValue).ToString("yyyyMMdd") + ")";
            }
            else {
                (gcRFD.ExGridView.Columns["nodoc"].ColumnEdit as GridLookUpEx).Query = "Call Sp_GetDocTpb(" + ((DateTime)dateDate.EditValue).ToString("yyyyMMdd") + ")";
            }
        }
        void tsbtnNew_Click(object sender, EventArgs e)
        {
            DetailTable.Clear();
            casDataSet.docpd.Clear();
            gcRFD.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcRFD.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcRFD.ExGridView.OptionsBehavior.Editable = true;
            gcRFD.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
           
         }

        void tsbtnPrint_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepRFP" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_RFP('" + this.NoDocument + "')");
       //     report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
            report.ShowPreview();
        }

        void ExGridView_New_Click(object sender, EventArgs e)
        {
            modenya = "new";
            DataRow row = casDataSet.docpd.NewRow();
            row["docp"] = NoDocument;
            row["nodoc"] = "";
            row["no"] = DB.GetRowCount(casDataSet.docpd) + 1;
            casDataSet.docpd.Rows.Add(row);

            DB.InsertDetailRows(gcRFD.ExGridView, row);
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            modenya = "edit";
            if (this.mode == Mode.Edit)
            {
                gcRFD.ExGridView.OptionsBehavior.Editable = true;
                gcRFD.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                gcRFD.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
                gcRFD.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            }
        }
        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gcRFD.ExGridView.GetDataRow(e.RowHandle);
            row["docp"] = NoDocument;
            row["no"] = DB.GetRowCount(casDataSet.docpd) + 1;
        }

        void ExGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
           
        }

        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {

            try
            {
                // Validate controls
                this.ValidateChildren();

                // Check Required Entries
                //if (nopolTextEdit.Text.Trim() == "")
                //    throw new Exception("No polisi harus diisi");

                // set group_ to 2

                DetailBindingSource.EndEdit();

                //double totVal = 0;


                base.tsbtnSave_Click(sender, e);

                //DB.sql.Execute("update oms set stat_bc=1 where oms='" + omsTextBoxEx.EditValue.ToString() + "'");

                if (this.mode == Mode.View)
                {
                    gcRFD.ExGridView.BestFitColumns();
                    gcRFD.ExGridView.OptionsBehavior.Editable = false;
                    gcRFD.ExGridView.OptionsSelection.MultiSelect = true;
                    gcRFD.ExGridView.OptionsCustomization.AllowSort = false;
                    gcRFD.ExGridView.OptionsView.ShowGroupPanel = false;
                    gcRFD.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                    gcRFD.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                    gcRFD.ExToolStrip.Items["tsbtnNew"].Enabled = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string kategori = omsTextBoxEx.EditValue.ToString().Substring(0,2);
            string jenis = jnspTextBoxEx.EditValue.ToString();

            if (jenis == "BC 2.6.1")
            {
                for (int i = 0; i < DetailTable.Rows.Count; i++)
                {
                    string nodoc = DetailTable.Rows[i]["no_bc"].ToString();
                    string lpb = DetailTable.Rows[i]["nodoc"].ToString();
                    //string datedoc = DetailTable.Rows[i]["datedoc"].ToString();
                    //Format Tanggal
                    string datedoc = Convert.ToDateTime(DetailTable.Rows[i]["datedoc"]).ToString("yyyy-MM-dd");
                    string dok = omsTextBoxEx.EditValue.ToString();

                    //DataTable dtTpb = DB.sql.Select("select ifnull(JUMLAH_SATUAN,0) as JUMLAH_SATUAN,ifnull(HARGA_INVOICE,0) as HARGA_INVOICE,ifnull(HARGA_SATUAN,0) as HARGA_SATUAN,NETTO,KODE_SATUAN,KODE_KEMASAN,KODE_BARANG,ifnull(JUMLAH_KEMASAN,0) as JUMLAH_KEMASAN,ifnull(CIF_RUPIAH,0) as CIF_RUPIAH,URAIAN from tpbdb.tpb_barang where ID_HEADER = (select ID from tpbdb.tpb_header where NOMOR_AJU = '" + nodoc + "')");
                    //foreach (DataRow drTpb in dtTpb.Rows)
                    //{
                    //    double qty = Convert.ToDouble(drTpb["JUMLAH_SATUAN"]);
                    //    double valbrg = Convert.ToDouble(drTpb["HARGA_INVOICE"]);
                    //    double price = Convert.ToDouble(drTpb["HARGA_SATUAN"]);
                    //    //tpbRow["remark"] = drTpb["KODE_SATUAN"];
                    //    string unit = drTpb["KODE_KEMASAN"].ToString();
                    //    string inv = drTpb["KODE_BARANG"].ToString();
                    //    string remark = drTpb["URAIAN"].ToString();
                    //    double qty1 = Convert.ToDouble(drTpb["JUMLAH_KEMASAN"]);
                    //    double valtotal = Convert.ToDouble(drTpb["CIF_RUPIAH"]);

                    //    double hitung = valtotal / qty;
                    //    DataTable daTpb = DB.sql.Select("select qtygd from spbd where spb = '" + lpb + "'");
                    //    foreach (DataRow dbTpb in daTpb.Rows)
                    //    {
                    //        double qtyz = Convert.ToDouble(dbTpb["qtygd"]);
                    //        double totalval = hitung * qtyz;
                    //        DB.sql.Execute("update bckeluar set val = '" + totalval + "' where nodoc = '" + nodoc + "' and (inv = '" + inv + "' or remark like '%" + remark + "%')");
                    //    }
                    //}

                    DB.sql.Execute("update bckeluar set jenis = '" + jnspTextBoxEx.EditValue.ToString() + "', nodoc = '" + nodoc + "', datedoc = '" + datedoc + "' where sjh = '" + lpb + "'");
                }
            }

            if (jenis == "BC 2.6.2")
            {
                for (int i = 0; i < DetailTable.Rows.Count; i++)
                {
                    string nodoc = DetailTable.Rows[i]["no_bc"].ToString();
                    string lpb = DetailTable.Rows[i]["nodoc"].ToString();
                    //Format Tanggal
                    string datedoc = Convert.ToDateTime(DetailTable.Rows[i]["datedoc"]).ToString("yyyy-MM-dd");

                    //DataTable dtTpb = DB.sql.Select("select IFNULL(b.JUMLAH_SATUAN,0) as JUMLAH_SATUAN,IFNULL(b.HARGA_INVOICE,0) as HARGA_INVOICE,IFNULL(b.HARGA_SATUAN,0) as HARGA_SATUAN,b.NETTO,b.KODE_SATUAN,b.KODE_KEMASAN,b.KODE_BARANG,IFNULL(b.JUMLAH_KEMASAN,0) as JUMLAH_KEMASAN,IFNULL(h.CIF_RUPIAH,0) as CIF_RUPIAH,URAIAN,h.NETTO,ifnull(b.CIF,0) as CIF from tpbdb.tpb_barang b, tpbdb.tpb_header h WHERE h.ID = b.ID_HEADER and b.ID_HEADER = (select ID from tpbdb.tpb_header WHERE NOMOR_AJU = '" + nodoc + "')");
                    //foreach (DataRow drTpb in dtTpb.Rows)
                    //{
                    //    double qty = Convert.ToDouble(drTpb["JUMLAH_SATUAN"]);
                    //    //double valbrg = Convert.ToDouble(drTpb["HARGA_INVOICE"]);
                    //    //double price = Convert.ToDouble(drTpb["HARGA_SATUAN"]);
                    //    //tpbRow["remark"] = drTpb["KODE_SATUAN"];
                    //    string unit = drTpb["KODE_KEMASAN"].ToString();
                    //    string inv = drTpb["KODE_BARANG"].ToString();
                    //    string remark = drTpb["URAIAN"].ToString();
                    //    double qty1 = Convert.ToDouble(drTpb["JUMLAH_KEMASAN"]);
                    //    double valtotal = Convert.ToDouble(drTpb["CIF_RUPIAH"]);
                    //    double valsubkon = Convert.ToDouble(drTpb["CIF"]);
                    //    double netto = Convert.ToDouble(drTpb["NETTO"]);

                    //    //DB.sql.Execute("update okd set price = '" + price + "', val = '" + valbrg + "' where okl = '" + omsTextBoxEx.EditValue.ToString() + "' and (inv = '" + inv + "' or remark like '%" + remark + "%')");
                    //    //DB.sql.Execute("update okl set val = '" + valsubkon + "' where okl = '" + omsTextBoxEx.EditValue.ToString() + "'");

                    //    //double hitung = valsubkon / qty;
                    //    //DataTable daTpb = DB.sql.Select("select qtygudang from spd where spm = '" + lpb + "'");
                    //    //foreach (DataRow dbTpb in daTpb.Rows)
                    //    //{
                    //    //    double qtyz = Convert.ToDouble(dbTpb["qtygudang"]);
                    //    //    double totalval = hitung * qtyz;
                    //    //    DB.sql.Execute("update bckeluar set val = '" + totalval + "' where nodoc = '" + nodoc + "' and (inv = '" + inv + "' or remark like '%" + remark + "%')");
                    //    //}
                    //    DB.sql.Execute("update bcmasuk set val = '" + valsubkon + "' where nodoc = '" + nodoc + "' and (inv = '" + inv + "' or remark like '%" + remark + "%')");
                    //}

                    DB.sql.Execute("update bcmasuk set jenis = '" + jnspTextBoxEx.EditValue.ToString() + "', nodoc = '" + nodoc + "', datedoc = '" + datedoc + "' where lpb = '" + lpb + "'");
                }
            }

            if ((jenis == "BC 4.0" || jenis == "BC 2.3" || jenis == "BC 2.7") && kategori == "PO")
            {
                for (int i = 0; i < DetailTable.Rows.Count; i++)
                {
                    string nodoc = DetailTable.Rows[i]["no_bc"].ToString();
                    string lpb = DetailTable.Rows[i]["nodoc"].ToString();
                    //Format Tanggal
                    string datedoc = Convert.ToDateTime(DetailTable.Rows[i]["datedoc"]).ToString("yyyy-MM-dd");
                    string dok = omsTextBoxEx.EditValue.ToString();

                    if (jenis == "BC 2.3" || jenis == "BC 2.7")
                    {
                        DataTable dtTpb = DB.sql.Select("select ifnull(JUMLAH_SATUAN,0) as JUMLAH_SATUAN,ifnull(HARGA_INVOICE,0) as HARGA_INVOICE,ifnull(HARGA_SATUAN,0) as HARGA_SATUAN,NETTO,KODE_SATUAN,KODE_KEMASAN,KODE_BARANG,ifnull(JUMLAH_KEMASAN,0) as JUMLAH_KEMASAN,ifnull(CIF_RUPIAH,0) as CIF_RUPIAH,URAIAN from tpbdb.tpb_barang where ID_HEADER = (select ID from tpbdb.tpb_header where NOMOR_AJU = '" + nodoc + "')");
                        foreach (DataRow drTpb in dtTpb.Rows)
                        {
                            double qty = Convert.ToDouble(drTpb["JUMLAH_SATUAN"]);
                            double valbrg = Convert.ToDouble(drTpb["HARGA_INVOICE"]);
                            double price = Convert.ToDouble(drTpb["HARGA_SATUAN"]);
                            //tpbRow["remark"] = drTpb["KODE_SATUAN"];
                            string unit = drTpb["KODE_KEMASAN"].ToString();
                            string inv = drTpb["KODE_BARANG"].ToString();
                            string remark = drTpb["URAIAN"].ToString();
                            double qty1 = Convert.ToDouble(drTpb["JUMLAH_KEMASAN"]);
                            double valtotal = Convert.ToDouble(drTpb["CIF_RUPIAH"]);

                            DB.sql.Execute("update omd set qty = '" + qty + "', unit = '" + unit + "', qty1 = '" + qty1 + "', price = '" + price + "', val = '" + valbrg + "' where oms = '" + omsTextBoxEx.EditValue.ToString() + "' and (inv = '" + inv + "' or remark like '%" + remark + "%')");
                            DB.sql.Execute("update oms_in set qty = '" + qty + "', price = '" + price + "', val = '" + valbrg + "' where oms = '" + omsTextBoxEx.EditValue.ToString() + "' and (inv = '" + inv + "' or remark like '%" + remark + "%')");
                            DB.sql.Execute("update oms set val = '" + valtotal + "' where oms = '" + omsTextBoxEx.EditValue.ToString() + "'");

                            double hitung = valtotal / qty;
                            DataTable daTpb = DB.sql.Select("select qtygd from spbd where spb = '" + lpb + "'");
                            foreach (DataRow dbTpb in daTpb.Rows)
                            {
                                double qtyz = Convert.ToDouble(dbTpb["qtygd"]);
                                double totalval = hitung * qtyz;
                                DB.sql.Execute("update bcmasuk set val = '" + totalval + "' where nodoc = '" + nodoc + "' and (inv = '" + inv + "' or remark like '%" + remark + "%')");
                            }
                        }
                    }

                    DB.sql.Execute("update bcmasuk set jenis = '" + jnspTextBoxEx.EditValue.ToString() + "', nodoc = '" + nodoc + "', datedoc = '" + datedoc + "' where lpb = '" + lpb + "'");
                }
            }
            if ((jenis == "BC 3.0" || jenis == "BC 4.1" || jenis == "BC 2.5" || jenis == "BC 2.7") && kategori == "SO")
            {
                for (int i = 0; i < DetailTable.Rows.Count; i++)
                {
                    string nodoc = DetailTable.Rows[i]["no_bc"].ToString();
                    string lpb = DetailTable.Rows[i]["nodoc"].ToString();
                    //Format Tanggal
                    string datedoc = Convert.ToDateTime(DetailTable.Rows[i]["datedoc"]).ToString("yyyy-MM-dd");

                    //if (jenis == "BC 2.7")
                    //{
                    //    DataTable dtTpb = DB.sql.Select("select IFNULL(b.JUMLAH_SATUAN,0) as JUMLAH_SATUAN,IFNULL(b.HARGA_INVOICE,0) as HARGA_INVOICE,IFNULL(b.HARGA_SATUAN,0) as HARGA_SATUAN,b.NETTO,b.KODE_SATUAN,b.KODE_KEMASAN,b.KODE_BARANG,IFNULL(b.JUMLAH_KEMASAN,0) as JUMLAH_KEMASAN,IFNULL(h.CIF_RUPIAH,0) as CIF_RUPIAH,URAIAN,h.NETTO,ifnull(b.CIF,0) as CIF from tpbdb.tpb_barang b, tpbdb.tpb_header h WHERE h.ID = b.ID_HEADER and b.ID_HEADER = (select ID from tpbdb.tpb_header WHERE NOMOR_AJU = '" + nodoc + "')");
                    //    foreach (DataRow drTpb in dtTpb.Rows)
                    //    {
                    //        double qty = Convert.ToDouble(drTpb["JUMLAH_SATUAN"]);
                    //        //double valbrg = Convert.ToDouble(drTpb["HARGA_INVOICE"]);
                    //        //double price = Convert.ToDouble(drTpb["HARGA_SATUAN"]);
                    //        //tpbRow["remark"] = drTpb["KODE_SATUAN"];
                    //        string unit = drTpb["KODE_KEMASAN"].ToString();
                    //        string inv = drTpb["KODE_BARANG"].ToString();
                    //        string remark = drTpb["URAIAN"].ToString();
                    //        double qty1 = Convert.ToDouble(drTpb["JUMLAH_KEMASAN"]);
                    //        double valtotal = Convert.ToDouble(drTpb["CIF_RUPIAH"]);
                    //        double valsubkon = Convert.ToDouble(drTpb["CIF"]);
                    //        double netto = Convert.ToDouble(drTpb["NETTO"]);

                    //        DB.sql.Execute("update okd set price = '" + price + "', val = '" + valbrg + "' where okl = '" + omsTextBoxEx.EditValue.ToString() + "' and (inv = '" + inv + "' or remark like '%" + remark + "%')");
                    //        DB.sql.Execute("update okl set val = '" + valsubkon + "' where okl = '" + omsTextBoxEx.EditValue.ToString() + "'");

                    //        //double hitung = valsubkon / qty;
                    //        //DataTable daTpb = DB.sql.Select("select qtygudang from spd where spm = '" + lpb + "'");
                    //        //foreach (DataRow dbTpb in daTpb.Rows)
                    //        //{
                    //        //    double qtyz = Convert.ToDouble(dbTpb["qtygudang"]);
                    //        //    double totalval = hitung * qtyz;
                    //        //    DB.sql.Execute("update bckeluar set val = '" + totalval + "' where nodoc = '" + nodoc + "' and (inv = '" + inv + "' or remark like '%" + remark + "%')");
                    //        //}
                    //        DB.sql.Execute("update bckeluar set val = '" + valsubkon + "' where nodoc = '" + nodoc + "' and (inv = '" + inv + "' or remark like '%" + remark + "%')");
                    //    }
                    //}

                    DB.sql.Execute("update bckeluar set jenis = '" + jnspTextBoxEx.EditValue.ToString() + "', nodoc = '" + nodoc + "', datedoc = '" + datedoc + "' where sjh = '" + lpb + "'");
                }
            }
        }
        private void CalculateTotalRFD()
        {
           
        }

        void ExGridView_Delete_Click(object sender, EventArgs e)
        {
             int[] selectedIndex = gcRFD.ExGridView.GetSelectedRows();
            if (selectedIndex.Length > 0)
            {
               DB.DeleteDetailRows(gcRFD.ExGridView);
            }
        }

        private void FrmDocP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'casDataSet.docpd' table. You can move, or remove it, as needed.
         //   this.docpdTableAdapter.Fill(this.casDataSet.docpd);
            // TODO: This line of code loads data into the 'casDataSet.docp' table. You can move, or remove it, as needed.
         //   this.docpTableAdapter.Fill(this.casDataSet.docp);
        //    DetailTable = DB.PopulateNamaRekening(DetailTable, "nama");
           
         //   ctrlSub.txtSub.DataBindings.Add("EditValue", MasterBindingSource, "sub");
            if (MasterBindingSource.Position == MasterTable.Rows.Count)
            {
                // gcRFD.ExGridView.OptionsBehavior.Editable = true;
                gcRFD.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                //gcRFD.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
                //gcRFD.ExToolStrip.Items["tsbtnNew"].Enabled = true;
             //   kembalidateDateEdit.EditValue = DB.loginDate;
              //  terimadateDateEdit.EditValue = DB.loginDate;
            }
            gcRFD.ExGridView.BestFitColumns();
            CalculateTotalRFD();
        }

       
        protected override void tsbtnCancel_Click(object sender, EventArgs e)
        {
            DB.CancelDetailRows(DetailTable);
           
            base.tsbtnCancel_Click(sender, new EventArgs());

            if (this.mode == Mode.View)
            {
                CalculateTotalRFD();

                gcRFD.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                gcRFD.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                gcRFD.ExGridView.OptionsBehavior.Editable = false;
                gcRFD.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;

             }
        }

        private void curcur_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void omsTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}