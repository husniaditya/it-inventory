using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using KASLibrary;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraReports.UI;
using MySql.Data.MySqlClient;
using System.Globalization;
using System.Threading;

namespace CAS.Transaction
{
    public partial class FrmTPHutang : CAS.Transaction.BaseTransaction
    {
        MySqlDataAdapter kadAdapter;
        string path = Application.StartupPath + "\\Reports\\" + "temp" + ".repx";
      
        public FrmTPHutang()
        {
            string Querynya;
            InitializeComponent();
            ToolStripMenuItem tsmiPreviewBkk = new ToolStripMenuItem("Preview BKK", null, new EventHandler(tsmiPreviewBkk_Click));
            ToolStripMenuItem tsmiPrintBkk = new ToolStripMenuItem("Print BKK", null, new EventHandler(tsmiPrintBkk_Click));
            ToolStripSeparator tsSeparator1 = new ToolStripSeparator();
            ToolStripMenuItem tsmiPreviewGiro= new ToolStripMenuItem("Preview Giro", null, new EventHandler(tsmiPreviewGiro_Click));
            ToolStripMenuItem tsmiPrintGiro = new ToolStripMenuItem("Print Giro", null, new EventHandler(tsmiPrintGiro_Click));
            ToolStripSeparator tsSeparator2 = new ToolStripSeparator();
            ToolStripMenuItem tsmiPreviewCek = new ToolStripMenuItem("Preview Cek Ekonomi", null, new EventHandler(tsmiPreviewCek_Click));
            ToolStripMenuItem tsmiPrintCek = new ToolStripMenuItem("Print Cek Ekonomi", null, new EventHandler(tsmiPrintCek_Click));
            ToolStripSeparator tsSeparator3 = new ToolStripSeparator();
            ToolStripMenuItem tsmiPreviewDraft = new ToolStripMenuItem("Preview BankDraft Ekonomi", null, new EventHandler(tsmiPreviewDraft_Click));
            ToolStripMenuItem tsmiPrintDraft = new ToolStripMenuItem("Print BankDraft Ekonomi", null, new EventHandler(tsmiPrintDraft_Click));
            ToolStripSeparator tsSeparator4 = new ToolStripSeparator();
            ToolStripMenuItem tsmiPreviewDraftBca = new ToolStripMenuItem("Preview BankDraft BCA", null, new EventHandler(tsmiPreviewDraftBca_Click));
            ToolStripMenuItem tsmiPrintDraftBca = new ToolStripMenuItem("Print BankDraft BCA", null, new EventHandler(tsmiPrintDraftBca_Click));
            ToolStripSeparator tsSeparator5 = new ToolStripSeparator();
            ToolStripMenuItem tsmiPreviewGiroBca = new ToolStripMenuItem("Preview Giro BCA", null, new EventHandler(tsmiPreviewGiroBca_Click));
            ToolStripMenuItem tsmiPrintGiroBca = new ToolStripMenuItem("Print Giro BCA", null, new EventHandler(tsmiPrintGiroBca_Click));
            ToolStripSeparator tsSeparator6 = new ToolStripSeparator();
            ToolStripMenuItem tsmiPreviewCekBca = new ToolStripMenuItem("Preview Cek BCA", null, new EventHandler(tsmiPreviewCekBca_Click));
            ToolStripMenuItem tsmiPrintCekBca = new ToolStripMenuItem("Print Cek BCA", null, new EventHandler(tsmiPrintCekBca_Click));
            ToolStripSeparator tsSeparator7 = new ToolStripSeparator();
            ToolStripMenuItem tsmiPreviewCekMdr = new ToolStripMenuItem("Preview Cek Mandiri", null, new EventHandler(tsmiPreviewCekMdr_Click));
            ToolStripMenuItem tsmiPrintCekMdr = new ToolStripMenuItem("Print Cek Mandiri", null, new EventHandler(tsmiPrintCekMdr_Click));
            ToolStripSeparator tsSeparator8 = new ToolStripSeparator();
            ToolStripMenuItem tsmiPreviewGiroMdr = new ToolStripMenuItem("Preview Giro Mandiri", null, new EventHandler(tsmiPreviewGiroMdr_Click));
            ToolStripMenuItem tsmiPrintGiroMdr = new ToolStripMenuItem("Print Giro Mandiri", null, new EventHandler(tsmiPrintGiroMdr_Click));
            ToolStripSeparator tsSeparator9 = new ToolStripSeparator();
            ToolStripMenuItem tsmiPreviewDraftMdr = new ToolStripMenuItem("Preview Draft Mandiri", null, new EventHandler(tsmiPreviewDraftMdr_Click));
            ToolStripMenuItem tsmiPrintDraftMdr = new ToolStripMenuItem("Print Draft Mandiri", null, new EventHandler(tsmiPrintDraftMdr_Click));
            ToolStripSeparator tsSeparator12 = new ToolStripSeparator();
            ToolStripMenuItem tsmiPreviewGiroJatim = new ToolStripMenuItem("Preview Giro Jatim", null, new EventHandler(tsmiPreviewGiroJatim_Click));
            ToolStripMenuItem tsmiPrintGiroJatim = new ToolStripMenuItem("Print Giro Jatim", null, new EventHandler(tsmiPrintGiroJatim_Click));
            ToolStripSeparator tsSeparator10 = new ToolStripSeparator();
            ToolStripMenuItem tsmiPreviewGiroUOB = new ToolStripMenuItem("Preview Giro UOB", null, new EventHandler(tsmiPreviewGiroUOB_Click));
            ToolStripMenuItem tsmiPrintGiroUOB = new ToolStripMenuItem("Print Giro UOB", null, new EventHandler(tsmiPrintGiroUOB_Click));
            ToolStripSeparator tsSeparator11 = new ToolStripSeparator();
            ToolStripMenuItem tsmiPreviewCekUOB = new ToolStripMenuItem("Preview Cek UOB", null, new EventHandler(tsmiPreviewCekUOB_Click));
            ToolStripMenuItem tsmiPrintCekUOB = new ToolStripMenuItem("Print Cek UOB", null, new EventHandler(tsmiPrintCekUOB_Click));
            ToolStripSeparator tsSeparator15 = new ToolStripSeparator();
            ToolStripMenuItem tsmiPreviewTransfer = new ToolStripMenuItem("Preview Slip Transfer", null, new EventHandler(tsmiPreviewTransfer_Click));
            ToolStripMenuItem tsmiPrintTransfer = new ToolStripMenuItem("Print Slip Transfer", null, new EventHandler(tsmiPrintTransfer_Click));
            ToolStripSeparator tsSeparator13 = new ToolStripSeparator();
            ToolStripMenuItem tsmiPreviewGiroMAS = new ToolStripMenuItem("Preview Giro MAS", null, new EventHandler(tsmiPreviewGiroMAS_Click));
            ToolStripMenuItem tsmiPrintGiroMAS = new ToolStripMenuItem("Print Giro MAS", null, new EventHandler(tsmiPrintGiroMAS_Click));
            ToolStripSeparator tsSeparator14 = new ToolStripSeparator();
            ToolStripMenuItem tsmiPreviewCekMAS = new ToolStripMenuItem("Preview Cek MAS", null, new EventHandler(tsmiPreviewCekMAS_Click));
            ToolStripMenuItem tsmiPrintCekMAS = new ToolStripMenuItem("Print Cek MAS", null, new EventHandler(tsmiPrintCekMAS_Click));
            ToolStripSeparator tsSeparator16 = new ToolStripSeparator();
            ToolStripMenuItem tsmiPreviewTransferMas = new ToolStripMenuItem("Preview Transfer MAS", null, new EventHandler(tsmiPreviewTransferMas_Click));
            ToolStripMenuItem tsmiPrintTransferMas = new ToolStripMenuItem("Print Transfer MAS", null, new EventHandler(tsmiPrintTransferMas_Click));
            ToolStripSeparator tsSeparator17 = new ToolStripSeparator();
            ToolStripMenuItem tsmiPreviewGiroNiaga = new ToolStripMenuItem("Preview Giro Niaga", null, new EventHandler(tsmiPreviewGiroNiaga_Click));
            ToolStripMenuItem tsmiPrintGiroNiaga = new ToolStripMenuItem("Print Giro Niaga", null, new EventHandler(tsmiPrintGiroNiaga_Click));
            ToolStripSeparator tsSeparator18 = new ToolStripSeparator();
            ToolStripMenuItem tsmiPreviewCekNiaga = new ToolStripMenuItem("Preview Cek Niaga", null, new EventHandler(tsmiPreviewCekNiaga_Click));
            ToolStripMenuItem tsmiPrintCekNiaga = new ToolStripMenuItem("Print Cek Niaga", null, new EventHandler(tsmiPrintCekNiaga_Click));
            ToolStripSeparator tsSeparator19 = new ToolStripSeparator();
            ToolStripMenuItem tsmiPreviewSlipNiaga = new ToolStripMenuItem("Preview Slip Transfer Niaga", null, new EventHandler(tsmiPreviewSlipNiaga_Click));
            ToolStripMenuItem tsmiPrintSlipNiaga = new ToolStripMenuItem("Print Slip Transfer Niaga", null, new EventHandler(tsmiPrintSlipNiaga_Click));
            ToolStripSeparator tsSeparator20 = new ToolStripSeparator(); 
            ToolStripMenuItem tsmiPreviewTransferBCA = new ToolStripMenuItem("Preview Transfer BCA", null, new EventHandler(tsmiPreviewTransferBCA_Click));
            ToolStripMenuItem tsmiPrintTransferBCA = new ToolStripMenuItem("Print Transfer BCA", null, new EventHandler(tsmiPrintTransferBCA_Click));
            ToolStripSeparator tsSeparator21 = new ToolStripSeparator();
            ToolStripMenuItem tsmiPreviewTransferMandiri = new ToolStripMenuItem("Preview Transfer Mandiri", null, new EventHandler(tsmiPreviewTransferMandiri_Click));
            ToolStripMenuItem tsmiPrintTransferMandiri = new ToolStripMenuItem("Print Transfer Mandiri", null, new EventHandler(tsmiPrintTransferMandiri_Click));
            ToolStripSeparator tsSeparator22 = new ToolStripSeparator();        
            ToolStripMenuItem tsmiPreviewTransferNiaga = new ToolStripMenuItem("Preview Slip Transfer Niaga", null, new EventHandler(tsmiPreviewTransferNiaga_Click));
            ToolStripMenuItem tsmiPrintTransferNiaga = new ToolStripMenuItem("Print Slip Transfer Niaga", null, new EventHandler(tsmiPrintTransferNiaga_Click));
            ToolStripSeparator tsSeparator23 = new ToolStripSeparator();
            ToolStripMenuItem tsmiPreviewBuktiSetorBCA = new ToolStripMenuItem("Preview Bukti Setor BCA", null, new EventHandler(tsmiPreviewBuktiSetorBCA_Click));
            ToolStripMenuItem tsmiPrintBuktiSetorBCA = new ToolStripMenuItem("Print Bukti Setor BCA", null, new EventHandler(tsmiPrintBuktiSetorBCA_Click));
            ToolStripSeparator tsSeparator24 = new ToolStripSeparator();
            ToolStripMenuItem tsmiPreviewTransferMastiti = new ToolStripMenuItem("Preview Transfer MAS TITI", null, new EventHandler(tsmiPreviewTransferMasTiti_Click));
            ToolStripMenuItem tsmiPrintTransferMastiti = new ToolStripMenuItem("Print Transfer MAS TITI", null, new EventHandler(tsmiPrintTransferMasTiti_Click));
            ToolStripSeparator tsSeparator25 = new ToolStripSeparator();
            ToolStripMenuItem tsmiPreviewCekMay = new ToolStripMenuItem("Preview Cek MayBank", null, new EventHandler(tsmiPreviewCekMay_Click));
            ToolStripMenuItem tsmiPrintCekMay = new ToolStripMenuItem("Print Cek MayBank", null, new EventHandler(tsmiPrintCekMay_Click));
            ToolStripSeparator tsSeparator26 = new ToolStripSeparator();
            ToolStripMenuItem tsmiPreviewGiroMay = new ToolStripMenuItem("Preview Giro MayBank", null, new EventHandler(tsmiPreviewGiroMay_Click));
            ToolStripMenuItem tsmiPrintGiroMay = new ToolStripMenuItem("Print Giro MayBank", null, new EventHandler(tsmiPrintGiroMay_Click));
            ToolStripSeparator tsSeparator27 = new ToolStripSeparator();
            ToolStripMenuItem tsmiPreviewTransferMay = new ToolStripMenuItem("Preview Slip Transfer MayBank", null, new EventHandler(tsmiPreviewTransferMay_Click));
            ToolStripMenuItem tsmiPrintTransferMay = new ToolStripMenuItem("Print Slip Transfer MayBank", null, new EventHandler(tsmiPrintTransferMay_Click));
           
            //ToolStripDropDownButton tsbtnPrint3 = new ToolStripDropDownButton("MAS", null, tsmiPreviewBkk, tsmiPrintBkk, tsSeparator1, tsmiPreviewGiro, tsmiPrintGiro, tsSeparator2, tsmiPreviewCek, tsmiPrintCek, tsSeparator3, tsmiPreviewDraft, tsmiPrintDraft, tsSeparator4, tsmiPreviewGiroBca, tsmiPrintGiroBca, tsSeparator5,
            //      tsmiPreviewDraftBca, tsmiPrintDraftBca, tsSeparator6, tsmiPreviewCekBca, tsmiPrintCekBca, tsSeparator7, tsmiPreviewCekMdr, tsmiPrintCekMdr, tsSeparator8, tsmiPreviewGiroMdr, tsmiPrintGiroMdr, tsSeparator9, tsmiPreviewDraftMdr, tsmiPrintDraftMdr, tsSeparator12, tsmiPreviewGiroJatim, tsmiPrintGiroJatim, tsSeparator10, tsmiPreviewGiroUOB, tsmiPrintGiroUOB, tsSeparator11,
            //      tsmiPreviewCekUOB, tsmiPrintCekUOB, tsSeparator13, tsmiPreviewGiroMAS, tsmiPrintGiroMAS, tsSeparator14, tsmiPreviewCekMAS, tsmiPrintCekMAS, tsSeparator15, tsmiPreviewTransfer, tsmiPrintTransfer, tsSeparator16, tsmiPreviewTransferMas, tsmiPrintTransferMas, tsSeparator17, tsmiPreviewGiroNiaga, tsmiPrintGiroNiaga, tsSeparator18, tsmiPreviewCekNiaga, tsmiPrintCekNiaga,
            //      tsSeparator19, tsmiPreviewSlipNiaga, tsmiPrintSlipNiaga);

            ToolStripDropDownButton tsbtnPrint1 = new ToolStripDropDownButton("EKONOMI", null, tsmiPreviewGiro, tsmiPrintGiro, tsSeparator2, tsmiPreviewCek, tsmiPrintCek, tsSeparator3, tsmiPreviewDraft, tsmiPrintDraft, tsSeparator4, tsmiPreviewTransfer, tsmiPrintTransfer);
            ToolStripDropDownButton tsbtnPrint2 = new ToolStripDropDownButton("BCA", null, tsmiPreviewGiroBca, tsmiPrintGiroBca, tsSeparator5, tsmiPreviewDraftBca, tsmiPrintDraftBca, tsSeparator6, tsmiPreviewCekBca, tsmiPrintCekBca, tsSeparator20, tsmiPreviewTransferBCA, tsmiPrintTransferBCA, tsSeparator23, tsmiPreviewBuktiSetorBCA, tsmiPrintBuktiSetorBCA);
            ToolStripDropDownButton tsbtnPrint3 = new ToolStripDropDownButton("MANDIRI", null, tsmiPreviewCekMdr, tsmiPrintCekMdr, tsSeparator8, tsmiPreviewGiroMdr, tsmiPrintGiroMdr, tsSeparator9, tsmiPreviewDraftMdr, tsmiPrintDraftMdr, tsSeparator21, tsmiPreviewTransferMandiri, tsmiPrintTransferMandiri);
            ToolStripDropDownButton tsbtnPrint4 = new ToolStripDropDownButton("JATIM", null, tsmiPreviewGiroJatim, tsmiPrintGiroJatim);
            ToolStripDropDownButton tsbtnPrint5 = new ToolStripDropDownButton("UOB", null, tsmiPreviewGiroUOB, tsmiPrintGiroUOB);
            ToolStripDropDownButton tsbtnPrint6 = new ToolStripDropDownButton("MAS", null, tsmiPreviewGiroMAS, tsmiPrintGiroMAS, tsSeparator14, tsmiPreviewCekMAS, tsmiPrintCekMAS, tsSeparator15, tsmiPreviewTransferMas, tsmiPrintTransferMas, tsSeparator24, tsmiPreviewTransferMastiti, tsmiPrintTransferMastiti);
            ToolStripDropDownButton tsbtnPrint7 = new ToolStripDropDownButton("NIAGA", null, tsmiPreviewGiroNiaga, tsmiPrintGiroNiaga, tsSeparator18, tsmiPreviewCekNiaga, tsmiPrintCekNiaga, tsSeparator19, tsmiPreviewTransferNiaga, tsmiPrintTransferNiaga);
            ToolStripDropDownButton tsbtnPrint8 = new ToolStripDropDownButton("MAYBANK", null, tsmiPreviewGiroMay, tsmiPrintGiroMay, tsSeparator25, tsmiPreviewCekMay, tsmiPrintCekMay, tsSeparator26, tsmiPreviewTransferMay, tsmiPrintTransferMay);

            ToolStripDropDownButton tsbtnPrint = new ToolStripDropDownButton("Print", null, tsmiPreviewBkk, tsmiPrintBkk, tsbtnPrint1, tsbtnPrint2, tsbtnPrint3, tsbtnPrint4, tsbtnPrint5, tsbtnPrint6, tsbtnPrint7, tsbtnPrint8);
            //ToolStripDropDownButton tsbtnPrint = new ToolStripDropDownButton("Print", null, tsmiPreviewBkk, tsmiPrintBkk, tsSeparator1, tsmiPreviewGiro, tsmiPrintGiro, tsSeparator2);
            tsbtnPrint.Image = MasterNavigator.Items["tsbtnPrint"].Image;
            MasterNavigator.Items.Insert(MasterNavigator.Items.IndexOfKey("tsbtnPrint"), tsbtnPrint);
            MasterNavigator.Items.RemoveByKey("tsbtnPrint");

            casDataSet.kad.Columns.Add("debet", typeof(String));

            Utility.SetSqlInstance(pnlDetail, DB.sql);
            gcKAG.ExGridControl.DataSource = kagBindingSource;
            gcKAD.ExGridControl.DataSource = kadBindingSource;

            MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);

            gcKAG.ExGridView.Columns["kas"].Visible = false;
            gcKAG.ExGridView.Columns["no"].Visible = false;
            gcKAG.ExGridView.Columns["group_"].Visible = false;

            gcKAD.ExGridView.Columns["kas"].Visible = false;
            gcKAD.ExGridView.Columns["debet"].Visible = false;
            gcKAD.ExGridView.Columns["no"].Visible = false;
            gcKAD.ExGridView.Columns["group_"].Visible = false;
            gcKAD.ExGridView.Columns["kode"].Visible = false;
            gcKAD.ExGridView.Columns["est"].Visible = false;
            gcKAD.ExGridView.Columns["kurs"].Visible = false;
            gcKAD.ExGridView.Columns["invoice"].Visible = false;

            gcKAG.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gcKAG.ExToolStrip.Items["tsbtnNew"].Enabled = false;
            gcKAD.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
            gcKAD.ExToolStrip.Items["tsbtnNew"].Enabled = false;

            tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            //tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
            tsbtnDelete.Click += new EventHandler(tsbtnDelete_Click);
           
            gcKAG.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView_New_Click);
            gcKAD.ExToolStrip.Items["tsbtnNew"].Click += new EventHandler(ExGridView2_New_Click);
            gcKAG.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView_Delete_Click);
            gcKAD.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ExGridView2_Delete_Click);
            
            gcKAG.ExGridView.CellValueChanged += new CellValueChangedEventHandler(ExGridView_CellValueChanged);
            gcKAD.ExGridView.CellValueChanged += new CellValueChangedEventHandler(ExGridView2_CellValueChanged);

            gcKAG.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView_InitNewRow);
            gcKAD.ExGridView.InitNewRow += new InitNewRowEventHandler(ExGridView2_InitNewRow);

            //gcKAG.ExGridView.Columns["acc"].ColumnEdit = new GridLookUpEx(DB.sql, "select acc as `Kode Akun`, name as `Nama Rekening` from acc where detil=1 and name like '%giro%' and name like '%hutang%'", "acc", "acc", gcKAG.ExGridView, "", true, true, "Account");
            gcKAG.ExGridView.Columns["acc"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('kgrhutang')", "kgr", "acc", gcKAG.ExGridView, "", true, true, "Account Giro");
            gcKAG.ExGridView.Columns["acc"].ColumnEdit.Enter += new EventHandler(kag_acc_ColumnEdit_Enter);
            gcKAG.ExGridView.Columns["nobg"].ColumnEdit = new RepositoryItemTextEdit();
            gcKAG.ExGridView.Columns["nobg"].ColumnEdit.Enter += new EventHandler(kag_nobg_ColumnEdit_Enter);
            gcKAG.ExGridView.Columns["bank"].ColumnEdit = new RepositoryItemTextEdit();
            gcKAG.ExGridView.Columns["bank"].ColumnEdit.Enter += new EventHandler(kag_bank_ColumnEdit_Enter);
            gcKAG.ExGridView.Columns["duedate"].ColumnEdit = new RepositoryItemDateEdit();
            gcKAG.ExGridView.Columns["duedate"].ColumnEdit.Enter += new EventHandler(kag_duedate_ColumnEdit_Enter);
          //  gcKAG.ExGridView.Columns["acbank"].ColumnEdit = new RepositoryItemTextEdit();
            gcKAG.ExGridView.Columns["acbank"].ColumnEdit = new GridLookUpEx(DB.sql, "select no_rek as `AC.Bank`,bank as Bank,namavendor as Vendor,gironame as `Nama Rekening` from accbank where sub ='" + txtSupplier.Text + "'", "accbank", "acbank", gcKAG.ExGridView, "", true, true, "Detail Rekening");
            gcKAG.ExGridView.Columns["acbank"].ColumnEdit.Enter += new EventHandler(kag_acbank_ColumnEdit_Enter);
            gcKAG.ExGridView.Columns["accbank"].Visible = false;

            //gcKAG.ExGridView.Columns["accbank"].ColumnEdit = new RepositoryItemTextEdit();
            //gcKAG.ExGridView.Columns["accbank"].ColumnEdit.Enter += new EventHandler(kag_accbank_ColumnEdit_Enter);
            gcKAG.ExGridView.Columns["val"].ColumnEdit = new GridNumEx();
            gcKAG.ExGridView.Columns["val"].ColumnEdit.Enter += new EventHandler(kag_val_ColumnEdit_Enter);
            
            gcKAD.ExGridView.Columns["jurnal"].ColumnEdit = new GridLookUpEx(DB.sql, "call SP_OutRhp('" + txtSupplier.Text + "','" + txtSupplier.Text + "'," + Utility.FirstDateInMonth(dateDate.DateTime).ToString("yyyyMMdd") + "," + ((DateTime)dateDate.EditValue).AddDays(1).ToString("yyyyMMdd") + ",'" + ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text + "','1')", "rhp", "jurnal", gcKAD.ExGridView, "", true, true, "Detail Hutang");
            gcKAD.ExGridView.Columns["jurnal"].ColumnEdit.Enter += new EventHandler(ExGridView_jurnalColumnEdit_Enter);           
            gcKAD.ExGridView.Columns["acc"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('acc')", "acc", "acc", gcKAD.ExGridView, "", true, true, "Perkiraan");
            gcKAD.ExGridView.Columns["acc"].ColumnEdit.Enter += new EventHandler(kad_acc_ColumnEdit_Enter);
            gcKAD.ExGridView.Columns["cct"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('cct')", "cct", "cct", gcKAD.ExGridView, "", true, true, "Cost Center");
            gcKAD.ExGridView.Columns["okl"].ColumnEdit = new GridLookUpEx(DB.sql, "Call SP_LookUp('oklmsk')", "okl", "okl", gcKAD.ExGridView, "", true, false, "Nomor SO");
            Querynya = "select * from (select rfd.rfp as `No. RFP`,rfd.nodoc as `No. Hutang`,rfd.val as Nilai,rfd.acc as `Kode Akun`,rfd.remark as keterangan, ";
            Querynya = Querynya + "tkad.kas as reff,rfd.invoice as `Invoice`,if(rhp.dk='D','K','D') as `Debet/Kredit`,from rfd inner join rfp on rfd.rfp=rfp.rfp left outer join rhp on rfd.nodoc=rhp.jurnal and rfd.invoice=rhp.invoice left outer join ";
            Querynya= Querynya+ "(select kad.* from kad,kas where kad.kas=kas.kas and kas.`delete`=0) as tkad on tkad.rfp=rfd.rfp and tkad.jurnal=rfd.nodoc where rfp.`delete`=0 and rfp.sub ='" + txtSupplier.Text + "') as Trfp where Trfp.reff is null order by Trfp.`No. RFP`";
            gcKAD.ExGridView.Columns["rfp"].ColumnEdit = new GridLookUpEx(DB.sql, Querynya, "rfp", "rfp", gcKAD.ExGridView, "", true, true, "Request For Payment");
            gcKAD.ExGridView.Columns["rfp"].ColumnEdit.Enter += new EventHandler(ExGridView_rfpColumnEdit_Enter);           
            
            // Debet Kredit ComboBox
            RepositoryItemComboBox cboDK = new RepositoryItemComboBox();
            cboDK.Items.AddRange(new string[] { "D", "K" });
            cboDK.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            gcKAD.ExGridView.Columns["dk"].ColumnEdit = cboDK;
            
            gcKAG.ExTitleLabel.Text = "Detail Giro";
            gcKAG.ExGridView.Columns["nobg"].Caption = "No. BG";
            gcKAG.ExGridView.Columns["acc"].Caption = "Perk. Giro";
            gcKAG.ExGridView.Columns["bank"].Caption = "Bank";
            gcKAG.ExGridView.Columns["duedate"].Caption = "J.Tempo";
            gcKAG.ExGridView.Columns["acbank"].Caption = "AC.Bank";
            gcKAG.ExGridView.Columns["val"].Caption = "Nilai";
            gcKAG.ExGridView.Columns["accbank"].Caption = "Perk. Bank";
            gcKAG.ExGridView.Columns["gironame"].Caption = "Nama Rekening";


            gcKAD.ExTitleLabel.Text = "Detail Pelunasan";
            gcKAD.ExGridView.Columns["rfp"].Caption = "No. RFP";
            gcKAD.ExGridView.Columns["okl"].Caption = "No SO";
            gcKAD.ExGridView.Columns["jurnal"].Caption = "No. Hutang";
            gcKAD.ExGridView.Columns["remark"].Caption = "Keterangan";
            gcKAD.ExGridView.Columns["debet"].Caption = "D/K";
            gcKAD.ExGridView.Columns["dk"].Caption = "Debet/Kredit";
            gcKAD.ExGridView.Columns["acc"].Caption = "Kode Akun";
            gcKAD.ExGridView.Columns["cct"].Caption = "Cost Center";
            gcKAD.ExGridView.Columns["val"].Caption = "Nilai";
            gcKAD.ExGridView.Columns["invoice"].Caption = "Invoice";
            gcKAD.ExGridView.Columns["invoice"].OptionsColumn.AllowEdit = false;
            gcKAD.ExGridView.Columns["kurs"].Caption = "Kurs";
            gcKAD.ExGridView.Columns["val"].ColumnEdit = new GridNumEx();                   

            gcKAG.ExGridView.Columns["acc"].VisibleIndex = 0;
            gcKAG.ExGridView.Columns["acbank"].VisibleIndex = 1;
            gcKAG.ExGridView.Columns["bank"].VisibleIndex = 2;
            gcKAG.ExGridView.Columns["duedate"].VisibleIndex = 3;

            gcKAD.ExGridView.Columns["rfp"].VisibleIndex = 0;
            gcKAD.ExGridView.Columns["okl"].VisibleIndex = 1;
            gcKAD.ExGridView.Columns["jurnal"].VisibleIndex = 1;
            gcKAD.ExGridView.Columns["invoice"].VisibleIndex = 2;
            gcKAD.ExGridView.Columns["cct"].VisibleIndex = 3;
            gcKAD.ExGridView.Columns["acc"].VisibleIndex = 4;            
            gcKAD.ExGridView.Columns["remark"].VisibleIndex = 5;
            gcKAD.ExGridView.Columns["dk"].VisibleIndex = 6;
            gcKAD.ExGridView.Columns["val"].VisibleIndex = 7;
            gcKAD.ExGridView.Columns["kurs"].VisibleIndex = 8;
           
           // gcKAG.ExGridView.BestFitColumns();
            gcKAG.ExGridView.Columns["acc"].Width = 100;
            gcKAG.ExGridView.Columns["nobg"].Width = 100;
            gcKAG.ExGridView.Columns["bank"].Width = 100;
            gcKAG.ExGridView.Columns["val"].Width = 100;
            gcKAG.ExGridView.Columns["acbank"].Width = 100;
            gcKAG.ExGridView.Columns["duedate"].Width = 100;


            gcKAG.ExGridView.OptionsBehavior.Editable = false;
            gcKAG.ExGridView.OptionsSelection.MultiSelect = true;
            gcKAG.ExGridView.OptionsCustomization.AllowSort = false;
            gcKAG.ExGridView.OptionsView.ShowGroupPanel = false;

            gcKAD.ExGridView.BestFitColumns();
            gcKAD.ExGridView.OptionsBehavior.Editable = false;
            gcKAD.ExGridView.OptionsSelection.MultiSelect = true;
            gcKAD.ExGridView.OptionsCustomization.AllowSort = false;
            gcKAD.ExGridView.OptionsView.ShowGroupPanel = false;
          
            DB.SetNumberFormat(gcKAG.ExGridView, "n2");
            DB.SetNumberFormat(gcKAD.ExGridView, "n2");   
            Utility.SetNumberFormat(spinEditVal, "n2");
            spinEditVal.Properties.MinValue = 0;
            spinEditVal.Properties.MaxValue = Decimal.MaxValue;
        //    tsbtnPrint.Click += new EventHandler(tsbtnPrint_Click);

            PopulateKAD();
            gcKAD.ExGridView.Columns["val"].Width = 150;
        }

        void kad_acc_ColumnEdit_Enter(object sender, EventArgs e)
        {
            if (gcKAD.ExGridView.GetFocusedRowCellValue("cct") != null)
            {
                //--auto costcenter to acc
                //if (gcKAD.ExGridView.GetFocusedRowCellValue("cct").ToString() != "")
                //{
                //    string cct = gcKAD.ExGridView.GetFocusedRowCellValue("cct").ToString();
                //    ((GridLookUpEx)gcKAD.ExGridView.Columns["acc"].ColumnEdit).Query = "select kode.acc as Perkiraan, acc.name as Keterangan from cca,kode,acc "
                //        + "where left(cct,1) = left(" + cct + ",1) and cca.kode=kode.kode and kode.acc=acc.acc";
                //}
                //else
                    ((GridLookUpEx)gcKAD.ExGridView.Columns["acc"].ColumnEdit).Query = "Call SP_LookUp('acc')";
            }
            else
                ((GridLookUpEx)gcKAD.ExGridView.Columns["acc"].ColumnEdit).Query = "Call SP_LookUp('acc')";
        }

        void kag_val_ColumnEdit_Enter(object sender, EventArgs e)
        {
            //if (gcKAG.ExGridView.GetFocusedRowCellValue("nobg") != null)
            //    ((SpinEdit)sender).Enabled = !isGiroCleared(gcKAG.ExGridView.GetFocusedRowCellValue("nobg").ToString());
            //else
            //    ((SpinEdit)sender).Enabled = false ;
        }

        //void kag_accbank_ColumnEdit_Enter(object sender, EventArgs e)
        //{
        //    if (gcKAG.ExGridView.GetFocusedRowCellValue("nobg") != null)
        //        ((TextEdit)sender).Properties.ReadOnly = isGiroCleared(gcKAG.ExGridView.GetFocusedRowCellValue("nobg").ToString());
        //    else
        //        ((TextEdit)sender).Properties.ReadOnly = false;
        //}

        void kag_acbank_ColumnEdit_Enter(object sender, EventArgs e)
        {
            string query = "select no_rek as `AC.Bank`,bank as Bank,namavendor as Vendor,gironame as `Nama Rekening` from accbank where sub ='" + txtSupplier.Text + "'"  ;
            ((GridLookUpEx)gcKAG.ExGridView.Columns["acbank"].ColumnEdit).Query = query;
            //if (gcKAG.ExGridView.GetFocusedRowCellValue("nobg") != null)
            //    ((TextEdit)sender).Properties.ReadOnly = isGiroCleared(gcKAG.ExGridView.GetFocusedRowCellValue("nobg").ToString());
            //else
            //    ((TextEdit)sender).Properties.ReadOnly = false;
        }

        void kag_duedate_ColumnEdit_Enter(object sender, EventArgs e)
        {
            //if (gcKAG.ExGridView.GetFocusedRowCellValue("nobg") != null)
            //    ((DateEdit)sender).Enabled = !isGiroCleared(gcKAG.ExGridView.GetFocusedRowCellValue("nobg").ToString());
            //else
            //    ((DateEdit)sender).Enabled = false;
        }

        void kag_bank_ColumnEdit_Enter(object sender, EventArgs e)
        {
            //if (gcKAG.ExGridView.GetFocusedRowCellValue("nobg") != null)
            //    ((TextEdit)sender).Properties.ReadOnly = isGiroCleared(gcKAG.ExGridView.GetFocusedRowCellValue("nobg").ToString());
            //else
            //    ((TextEdit)sender).Properties.ReadOnly = false;
        }

        void kag_nobg_ColumnEdit_Enter(object sender, EventArgs e)
        {
            //if (gcKAG.ExGridView.GetFocusedRowCellValue("nobg") != null)
            //    ((TextEdit)sender).Properties.ReadOnly = isGiroCleared(gcKAG.ExGridView.GetFocusedRowCellValue("nobg").ToString());
            //else
            //    ((TextEdit)sender).Properties.ReadOnly = false;
        }

        private bool isGiroCleared(string noGiro)
        {
            //if (DB.sql.Select("select * from cgr where nobg='" + noGiro + "'").Rows.Count > 0)
            //    return true;
            return false;
        }

        void kag_acc_ColumnEdit_Enter(object sender, EventArgs e)
        {
            //if (gcKAG.ExGridView.GetFocusedRowCellValue("nobg") != null)
            //    ((ButtonEdit)sender).Enabled = !isGiroCleared(gcKAG.ExGridView.GetFocusedRowCellValue("nobg").ToString());
            //else
            //    ((ButtonEdit)sender).Enabled = true;
        }
       
        void ExGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "val") CalculateTotalKAG();
        }

        void ExGridView_Delete_Click(object sender, EventArgs e)
        {
            bool canDeleteitem, canDelete = true;
            int[] selectedIndex = gcKAG.ExGridView.GetSelectedRows();
            if (selectedIndex.Length > 0)
            {
                for (int i = 0; i < selectedIndex.Length; i++)
                {
                    string prq = gcKAG.ExGridView.GetDataRow(selectedIndex[i])["kas"].ToString();
                    int no = Convert.ToInt32(gcKAG.ExGridView.GetDataRow(selectedIndex[i])["no"]);
                    canDeleteitem = DeleteLineItem(prq, no);
                    if (canDeleteitem == false) canDelete = false;
                }
                if (canDelete)
                {
                    DB.DeleteDetailRows(gcKAG.ExGridView);
                    CalculateTotalKAG();
                    if (DetailTable.GetChanges() != null)
                        DetailAdapter.Update(DetailTable);
                }
            }
        }

        void ExGridView2_Delete_Click(object sender, EventArgs e)
        {
            bool temp = true;
            string query = "";
            bool canDeleteitem, canDelete = true;
            int[] selectedIndex = gcKAD.ExGridView.GetSelectedRows();
            if (selectedIndex.Length > 0)
            {
                for (int i = 0; i < selectedIndex.Length; i++)
                {
                    string prq = gcKAD.ExGridView.GetDataRow(selectedIndex[i])["kas"].ToString();
                    int no = Convert.ToInt32(gcKAD.ExGridView.GetDataRow(selectedIndex[i])["no"]);

                    temp = true;
                    query = "Select FCanDeleteLineItem('kad','" + prq + "'," + no.ToString() + ")";
                    if (DB.sql.Select(query).Rows[0][0].ToString() == "False")
                    {
                        MessageBox.Show("Item ke-" + no.ToString() + " tidak bisa di-delete karena telah digunakan pada tahap transaksi setelahnya");
                        temp = false;
                    }

                    if (temp == false) canDelete = false;
                }
                if (canDelete)
                {
                    DB.DeleteDetailRows(gcKAD.ExGridView);
                    CalculateTotalKAD();
                    if (casDataSet.kad.GetChanges() != null)
                        kadAdapter.Update(casDataSet.kad);
                }
            }
        }

        void ExGridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "debet")
            {
                string debet = "D";
              //  if (gcKAD.ExGridView.GetFocusedRowCellValue(gcKAD.ExGridView.Columns["debet"].ToString()) == "D") debet = "K";
                if (e.Value.ToString() == "D") 
                    debet = "K";

                gcKAD.ExGridView.SetFocusedRowCellValue(gcKAD.ExGridView.Columns["dk"], debet);
            }
            if (e.Column.FieldName == "val" || e.Column.FieldName == "dk" || e.Column.FieldName == "kurs") CalculateTotalKAD();
        }

        private void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (MasterBindingSource.Position < 0)
                return;

            if (MasterBindingSource.Position >= MasterTable.Rows.Count) return;
            PopulateKAD();

            if (tcsiCheckBox.Checked == true)
                gcKAD.ExGridView.Columns["kurs"].Visible = true;
            else
                gcKAD.ExGridView.Columns["kurs"].Visible = false;

            CalculateTotalKAD();
            CalculateTotalKAG();

        }

        void ExGridView_jurnalColumnEdit_Enter(object sender, EventArgs e)
        {
            string query = "call SP_OutRhp('" + txtSupplier.Text + "','" + txtSupplier.Text + "'," + Utility.FirstDateInMonth(dateDate.DateTime).ToString("yyyyMMdd") + "," + ((DateTime)dateDate.EditValue).AddDays(1).ToString("yyyyMMdd") + ",'" + ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text + "','1')";
            ((GridLookUpEx)gcKAD.ExGridView.Columns["jurnal"].ColumnEdit).Query = query;
        }

        void ExGridView_rfpColumnEdit_Enter(object sender, EventArgs e)
        {
            string query = "select * from (select rfd.rfp as `No. RFP`,rfd.nodoc as `No. Hutang`,rfd.val as Nilai,rfd.acc as `Kode Akun`,rfd.remark as keterangan, tkad.kas as reff "
                + ",rfd.invoice as `Invoice`,if(rhp.dk='D','K','D') as `Debet/Kredit` "
                + "from rfd inner join rfp on rfd.rfp=rfp.rfp left outer join rhp on rfd.nodoc=rhp.jurnal and rfd.invoice=rhp.invoice  left outer join (select kad.* from kad,kas where kad.kas=kas.kas and kas.`delete`=0) as tkad on tkad.rfp=rfd.rfp and tkad.jurnal=rfd.nodoc "
                + "where rfp.`delete`=0 and rfp.sub ='" + txtSupplier.EditValue.ToString() + "') as Trfp where Trfp.reff is null order by Trfp.`No. RFP`";
            ((GridLookUpEx)gcKAD.ExGridView.Columns["rfp"].ColumnEdit).Query = query;
        }

        private void PopulateKAD()
        {
            try
            {
                bool newEntry = (MasterBindingSource.Position == MasterTable.Rows.Count);
                string query = "";

                casDataSet.kad.Clear();
                if (newEntry)
                    query = "select * from kad where 0";
                else
                    query = "select * from kad where kas='" + MasterTable.Rows[MasterBindingSource.Position][0].ToString() + "'";
                kadAdapter = DB.sql.SelectAdapter(query);
                kadAdapter.Fill(casDataSet.kad);
                gcKAD.ExGridView.BestFitColumns();
                gcKAD.ExGridView.Columns["val"].Width = 150;
            }
            catch
            { 
            
            }
        
        }

        private void FrmTPHutang_Load(object sender, EventArgs e)
        {
            Utility.SetNumberFormat(txtTotalKAD, "n2");
            Utility.SetNumberFormat(txtTotalKAG, "n2");            

            if (MasterBindingSource.Position == MasterTable.Rows.Count)
            {
                castoRadioGroup.SelectedIndex = 0;
                chargetoRadioGroup.SelectedIndex = 0;
                txtTotalKAG.Text = "0";
                txtTotalKAD.Text = "0";
                spinEditVal.EditValue = 0;
            }
            PopulateKAD();
            CalculateTotalKAD();
            CalculateTotalKAG();
            if (txtRFP.Text != "") txtTotalKAD.EditValue = Convert.ToDouble(txtTotalKAG.EditValue.ToString()) + Convert.ToDouble(spinEditVal.EditValue.ToString());
        }
        
        protected override void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            base.tsbtnRefresh_Click(sender, new EventArgs());
            PopulateKAD();
        }

        protected override void tsbtnCancel_Click(object sender, EventArgs e)
        {
            DB.CancelDetailRows(DetailTable);
            remarkTextBox.Focus();
            base.tsbtnCancel_Click(sender, new EventArgs());

            if (this.mode == Mode.View)
            {
                gcKAG.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                gcKAG.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                gcKAG.ExGridView.OptionsBehavior.Editable = false;
                gcKAG.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;

                DB.CancelDetailRows(casDataSet.kad);
                casDataSet.kad.RejectChanges();
                kadBindingSource.CancelEdit();
                gcKAD.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                gcKAD.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                gcKAD.ExGridView.OptionsBehavior.Editable = false;
                gcKAD.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            }
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
            gcKAG.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcKAG.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcKAG.ExGridView.OptionsBehavior.Editable = true;
            gcKAG.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            gcKAD.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcKAD.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcKAD.ExGridView.OptionsBehavior.Editable = true;
            gcKAD.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            Utility.SetReadOnly(txtTotalKAD, true);
            Utility.SetReadOnly(txtTotalKAG, true);

        }

        protected override void tsbtnDelete_Click(object sender, EventArgs e)
        {
            base.tsbtnDelete_Click(sender, e);
            if (Convert.ToInt32(MasterTable.Rows[MasterBindingSource.Position]["delete"]) == 1)
                DB.sql.Execute("Call SP_Delete('KPH','" + NoDocument + "')");
        }

        void ExGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gcKAG.ExGridView.GetDataRow(e.RowHandle);
            row["kas"] = NoDocument;
            row["nobg"] = "";
            row["no"] = DB.GetRowCount(DetailTable) + 1;
        }

        void ExGridView2_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gcKAD.ExGridView.GetDataRow(e.RowHandle);
            row["kas"] = NoDocument;
            row["no"] = DB.GetRowCount(casDataSet.kad) + 1;
            row["dk"] = "D";
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            DetailTable.Clear();
            casDataSet.kad.Clear();
            spinEditVal.EditValue = 0;
            tcsiCheckBox.Checked = false;
            //CalculateTotalKAD();
            //CalculateTotalKAG();
            txtTotalKAD.EditValue = 0;
            txtTotalKAG.EditValue = 0;
            bilusLabel2.Text = "-";
            gcKAG.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcKAG.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcKAG.ExGridView.OptionsBehavior.Editable = true;
            gcKAG.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            gcKAD.ExToolStrip.Items["tsbtnDelete"].Enabled = true;
            gcKAD.ExToolStrip.Items["tsbtnNew"].Enabled = true;
            gcKAD.ExGridView.OptionsBehavior.Editable = true;
            gcKAD.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            Utility.SetReadOnly(txtTotalKAD, true);
            Utility.SetReadOnly(txtTotalKAG, true);
        }

        void ExGridView_New_Click(object sender, EventArgs e)
        {
            DataRow row = casDataSet.kag.NewRow();
            row["kas"] = NoDocument;
            row["val"] = 0;
            row["nobg"] = "";
            row["acbank"] = "";
            row["bank"] = "";
            row["duedate"] = Utility.LastDateInMonth(DB.loginDate);
            row["group_"] = "1";
            row["acc"] = "";
            row["no"] = DB.GetRowCount(DetailTable) + 1;
            casDataSet.kag.Rows.Add(row);

            DB.InsertDetailRows(gcKAG.ExGridView, row);
        }
        
        void ExGridView2_New_Click(object sender, EventArgs e)
        {
            DataRow row = casDataSet.kad.NewRow();
            row["kas"] = NoDocument;
            row["val"] = 0;
            row["jurnal"] = "";
            row["remark"] = "";
            row["dk"] = "";
            row["acc"] = "";
            row["group_"] = "1";
            row["cct"] = "";
            row["kode"] = "";
            row["est"] = 0;
            row["invoice"] = "";
            row["no"] = DB.GetRowCount(casDataSet.kad) + 1;
            casDataSet.kad.Rows.Add(row);

            DB.InsertDetailRows(gcKAD.ExGridView, row);
        }
     
        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            remarkTextBox.Focus();
            try
            {
                this.ValidateChildren();

                kadBindingSource.EndEdit();
                DetailBindingSource.EndEdit();
                
                //if (txtSupplier.EditValue.ToString().Trim() != "" && txtRFP.EditValue.ToString().Trim() == "" )
                //    throw new Exception("No Request For Payment harus diisi");

                if (spinEditVal.Value != 0 && txtNoAkun.Text.Trim() == "")
                    throw new Exception("No akun harus diisi");

                for (int i = 0; i < casDataSet.kad.Rows.Count; i++)
                {
                    if (casDataSet.kad.Rows[i]["dk"].ToString().Trim() == "")
                        throw new Exception("Tentukan posisi Debet Kredit pada detail pelunasan ke-" + i.ToString());
                    if (Convert.ToDouble(casDataSet.kad.Rows[i]["val"].ToString()) > 0
                        && casDataSet.kad.Rows[i]["acc"].ToString().Trim() == "")
                        throw new Exception("Nomor Account pada Detail Pelunasan ke-" + i.ToString() + " belum terisi");
                    if (Convert.ToInt16(casDataSet.kad.Rows[i]["acc"].ToString().Substring(0, 1)) == 6 && casDataSet.kad.Rows[i]["cct"].ToString().Trim() == "")
                        throw new Exception("Cost Center pada Detail Pelunasan ke-" + i.ToString() + " belum terisi");
                   //sementara ditutup untuk input proyek awal
                    //if (casDataSet.kad.Rows[i]["jurnal"].ToString().Trim() != "" && casDataSet.kad.Rows[i]["rfp"].ToString().Trim() == "" )
                    //    throw new Exception("Nomor RFP pada Detail Pelunasan ke-" + i.ToString() + " belum terisi");
              
                }

                if (casDataSet.kad.Rows.Count == 0)
                    throw new Exception("Detail Kas belum terisi");

                if (DetailTable.Rows.Count == 0)
                    txtTotalKAG.Text = "0";

                for (int i = 0; i < DetailTable.Rows.Count - 1; i++)
                {
                    for (int j = i + 1; j < DetailTable.Rows.Count; j++)
                    {
                        if (DetailTable.Rows[i] != null && DetailTable.Rows[j] != null &&
                            DetailTable.Rows[i].RowState != DataRowState.Deleted &&
                            DetailTable.Rows[j].RowState != DataRowState.Deleted)
                        {
                            if (DetailTable.Rows[i]["nobg"].ToString() == DetailTable.Rows[j]["nobg"].ToString())
                                throw new Exception("No Bg pada detail item ke-" + Convert.ToString(j) + " sudah ada");
                        }
                    }
                }

                DataTable checkKAG = new DataTable();
                checkKAG = DB.sql.Select("select * from kag ");
                for (int i = 0; i < DetailTable.Rows.Count; i++)
                {
                    if (DetailTable.Rows[i] != null && DetailTable.Rows[i].RowState != DataRowState.Deleted)
                    {
                        DetailTable.Rows[i][0] = NoDocument;
                        if (DetailTable.Rows[i]["acc"].ToString().Trim() != "" && DetailTable.Rows[i]["nobg"].ToString().Trim() == "") throw new Exception("No Bg pada Detail Giro ke-" + Convert.ToString(i) + " belum terisi");
                        if (Convert.ToDouble(DetailTable.Rows[i]["val"].ToString()) > 0 && DetailTable.Rows[i]["acc"].ToString().Trim() == "") throw new Exception("Nomor Account pada Detail Giro ke-" + i.ToString() + " belum terisi");
                        DataRow[] cekRow = checkKAG.Select("nobg='" + DetailTable.Rows[i].ItemArray[1].ToString() + "' and kas<>'" + DetailTable.Rows[i].ItemArray[0].ToString() + "'");
                        if (cekRow.Length > 0)
                            throw new Exception("No Bg pada detail item ke-" + Convert.ToString(i) + " sudah pernah diinputkan");
                    }
                }

                for (int i = casDataSet.kad.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = casDataSet.kad.Rows[i];
                    if (row != null && row.RowState != DataRowState.Deleted)
                        row[0] = NoDocument;
                }

                for (int i = 0; i < casDataSet.kad.Rows.Count; i++)
                {
                    string kodeRfp = casDataSet.kad.Rows[i]["rfp"].ToString();
                    DB.sql.Execute("update rfp set stat_rfp = 1 where rfp = '" + kodeRfp + "'");

                }

                if (tcsiCheckBox.Checked)
                {
                    if (Math.Round(Convert.ToDecimal(txtTotalKAD.EditValue),2) != Math.Round((Convert.ToDecimal(txtTotalKAG.EditValue) + (Convert.ToDecimal(spinEditVal.EditValue)*Convert.ToDecimal(curkurs.EditValue))),2))
                    throw new Exception("Journal Not Balance. Please check the value");
                }
                else
                    if (Math.Round(Convert.ToDecimal(txtTotalKAD.EditValue), 2) != Math.Round((Convert.ToDecimal(txtTotalKAG.EditValue) + (Convert.ToDecimal(spinEditVal.EditValue))), 2))
                        throw new Exception("Journal Not Balance. Please check the value");
                
                if (curcur.EditValue.ToString().Trim()=="")
                    throw new Exception("Currency Harus di Isi");

                ((DataRowView)MasterBindingSource.Current).Row["casto"] = castoRadioGroup.SelectedIndex;
                ((DataRowView)MasterBindingSource.Current).Row["chargeto"] = chargetoRadioGroup.SelectedIndex;
                ((DataRowView)MasterBindingSource.Current).Row["group_"] = 1;
                base.tsbtnSave_Click(sender, e);
                DataTable dtChanged;
                dtChanged = casDataSet.kad.GetChanges();

                if (casDataSet.kad.GetChanges() != null)
                    kadAdapter.Update(casDataSet.kad);

                DB.SaveDatalog(dtChanged);

                // Update NoDocument
                for (int i = 0; i < casDataSet.kad.Rows.Count; i++)
                    casDataSet.kad.Rows[i][0] = NoDocument;

                kadBindingSource.EndEdit();
                if (casDataSet.kad.GetChanges() != null)
                    kadAdapter.Update(casDataSet.kad);

                string date = ((DateTime)(dateDate.EditValue)).ToString("yyyyMMdd");
                string jurnal = ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text;
                DB.sql.Execute("Call SP_Save(" + date + ",'KPH'" + ",'" + jurnal + "')");                               

                if (this.mode == Mode.View)
                {
                    gcKAG.ExGridView.OptionsBehavior.Editable = false;
                    gcKAG.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                    gcKAG.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                    gcKAG.ExToolStrip.Items["tsbtnNew"].Enabled = false;

                    gcKAD.ExGridView.OptionsBehavior.Editable = false;
                    gcKAD.ExGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                    gcKAD.ExToolStrip.Items["tsbtnDelete"].Enabled = false;
                    gcKAD.ExToolStrip.Items["tsbtnNew"].Enabled = false;
                }
                tsbtnRefresh.PerformClick();
                CalculateTotalKAD();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxEx1_EditValueChanged(object sender, EventArgs e)
        {
            /*
            DataRow row = txtSupplier.ExGetDataRow();
            if (row == null)
            {
                curcur.EditValue = "";
                return;
            }
            curcur.EditValue = row["cur"].ToString();
         
            //gcKAD.ExGridView.Columns["jurnal"].ColumnEdit = new GridLookUpEx(DB.sql, "call SP_OutRhp('" + textBoxEx1.Text + "','" + textBoxEx1.Text + "'," + Utility.FirstDateInMonth(dateDate.DateTime).ToString("yyyyMMdd") + "," + ((DateTime)dateDate.EditValue).AddDays(1).ToString("yyyyMMdd") + ",'" + ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text + "','1')", "rhp", "jurnal", gcKAD.ExGridView, "", true, true, "Detail Hutang");
            ((GridLookUpEx)gcKAD.ExGridView.Columns["jurnal"].ColumnEdit).Query = "call SP_OutRhp('" + txtSupplier.Text + "','" + txtSupplier.Text + "'," + Utility.FirstDateInMonth(dateDate.DateTime).ToString("yyyyMMdd") + "," + ((DateTime)dateDate.EditValue).AddDays(1).ToString("yyyyMMdd") + ",'" + NoDocument + "','1')";
            //spinTOP.EditValue = row["top"].ToString();
            ((GridLookUpEx)gcKAD.ExGridView.Columns["rfp"].ColumnEdit).Query = "select * from (select rfd.rfp as `No. RFP`,rfd.nodoc as `No. Hutang`,rfd.val as Nilai,rfd.acc as `Kode Akun`,rfd.remark as keterangan, tkad.kas as reff "
                + ",rfd.invoice as `Invoice`,if(rhp.dk='D','K','D') as `Debet/Kredit` "
                + "from rfd inner join rfp on rfd.rfp=rfp.rfp left outer join rhp on rfd.nodoc=rhp.jurnal and rfd.invoice=rhp.invoice  left outer join (select kad.* from kad,kas where kad.kas=kas.kas and kas.`delete`=0) as tkad on tkad.rfp=rfd.rfp and tkad.jurnal=rfd.nodoc "
                + "where rfp.`delete`=0 and rfp.sub ='" + txtSupplier.EditValue.ToString() + "') as Trfp where Trfp.reff is null order by Trfp.`No. RFP`" ;
        
             */
            string query = "select no_rek as `AC.Bank`,bank as Bank,namavendor as Vendor,gironame as `NamaRekening` from accbank where sub ='" + txtSupplier.Text + "'";
            txtRFP.ExSqlQuery = query; 
        }

        private void curcur_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                bilusLabel2.Text = terbilang(spinEditVal.EditValue, curcur.Text);
            }
            catch
            { }
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

        private void txtNo_EditValueChanged(object sender, EventArgs e)
        {
            if (MasterBindingSource.Position != MasterTable.Rows.Count)
            {
                int casto = Convert.ToInt32(MasterTable.Rows[MasterBindingSource.Position]["casto"]);
                int chargeto = Convert.ToInt32(MasterTable.Rows[MasterBindingSource.Position]["chargeto"]);
                castoRadioGroup.SelectedIndex = casto;
                chargetoRadioGroup.SelectedIndex = chargeto;
                CalculateTotalKAG();
                CalculateTotalKAD();
            }
        }

        void tsbtnPrint_Click(object sender, EventArgs e)
        {
        //    string path = Application.StartupPath + "\\Reports\\" + "BKK" + ".repx";
        //    XtraReport report = new XtraReport();
        //    report.LoadState(path);
        //    DataTable dt = DB.sql.Select("call SP_Print('Transaction.FrmTKBK','" + this.NoDocument + "')");
        //    report.DataSource = dt;
        //    string terbilangkag = "";
        //    string terbilangkagn = "";
        //    string terbilang= "";
        //    try
        //    {
        //        if (curcur.Text == "IDR")
        //        {
        //            terbilangkag = Utility.NumberToText(Convert.ToDouble(txtTotalKAG.EditValue));
        //            terbilangkagn = terbilangkag + "rupiah";
        //            terbilang = Utility.NumberToText(Convert.ToDouble(spinEditVal.EditValue)) + " rupiah";
        //        }
        //        else if (curcur.Text == "USD")
        //            terbilangkagn = Utility.NumberToText(Convert.ToInt32(txtTotalKAG.EditValue) * Convert.ToInt32(curkurs.EditValue)) + " rupiah";
        //            terbilang = Utility.NumberToText(Convert.ToDouble(spinEditVal.EditValue) * Convert.ToInt32(curkurs.EditValue)) + " rupiah";
        //    }
        //    catch { }
        ////     report.Bands[BandKind.PageHeader].Controls[0].Controls[4].Controls[3].Text = this.txtTotalKAD.Text;
    
        //    if ((dt.Rows.Count > 0) && (dt.Rows[0]["terbilang"].ToString() !="-"))
        //    {
        //        string kas = "";
        //        if (terbilangkag != "")
        //        {
        //            report.Bands[BandKind.PageFooter].Controls[0].Controls[1].Controls[1].Text = "Giro : " + terbilangkagn;
        //            kas = "kas : ";
        //        }
        //        report.Bands[BandKind.PageFooter].Controls[0].Controls[2].Controls[1].Text = kas + terbilang;
        //    }
        //    else
        //        report.Bands[BandKind.PageFooter].Controls[0].Controls[1].Controls[1].Text = "Giro : " + terbilangkagn;
        //        DataTable bg = DB.sql.Select("select * from kag where kas='" + this.NoDocument + "'");
        //    if (bg.Rows.Count > 0)
        //    {
        //       report.Bands[BandKind.PageFooter].Controls[0].Controls[1].Controls[1].Text = "Giro : " + terbilangkagn;
        //       report.Bands[BandKind.PageFooter].Controls[0].Controls[0].Controls[1].Text = bg.Rows[0]["nobg"].ToString();
        //       if (bg.Rows[0]["duedate"].ToString() != "")
        //        {
        //          report.Bands[BandKind.PageFooter].Controls[0].Controls[0].Controls[2].Text = Convert.ToDateTime(bg.Rows[0]["duedate"]).ToString("dd/MM/yyyy");
        //        }
        //    }
        //    report.ShowPreview();
        }

        void CalculateTotalKAG()
        {
            try
            {
                DetailBindingSource.EndEdit();

                double totalKAG = 0;
                for (int i = 0; i < DetailTable.Rows.Count; i++)
                {
                    if (DetailTable.Rows[i] != null && DetailTable.Rows[i].RowState != DataRowState.Deleted)
                    {
                        totalKAG = totalKAG + (double)DetailTable.Rows[i]["val"];
                    }
                }
                txtTotalKAG.EditValue = totalKAG;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        void CalculateTotalKAD()
        {
            try
            {
                kadBindingSource.EndEdit();

                double totalKAD = 0;
                double kursnya = 0;
                for (int i = 0; i < casDataSet.kad.Rows.Count; i++)
                {
                    if (casDataSet.kad.Rows[i] != null && casDataSet.kad.Rows[i].RowState != DataRowState.Deleted)
                    {
                        if ((double)casDataSet.kad.Rows[i]["kurs"] == 0 || tcsiCheckBox.Checked==false)
                            kursnya = 1;
                        else
                            kursnya = (double)casDataSet.kad.Rows[i]["kurs"];

                        if ((string)casDataSet.kad.Rows[i]["DK"] == "K")
                            totalKAD = totalKAD - ((double)casDataSet.kad.Rows[i]["val"]*kursnya);
                        else
                            totalKAD = totalKAD + ((double)casDataSet.kad.Rows[i]["val"]*kursnya);
                        if (casDataSet.kad.Rows[i]["dk"].ToString() == "") throw new Exception("No Jurnal pada Detail Kas salah");
                    }
                }
                txtTotalKAD.EditValue =totalKAD;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        private void spinEditVal_Leave(object sender, EventArgs e)
        {
            try
            {
                bilusLabel2.Text = terbilang(spinEditVal.EditValue, curcur.Text);
            }
            catch { }
        }

        private void txtRFP_EditValueChanged(object sender, EventArgs e)
        {
            //DataRow row = txtRFP.ExGetDataRow();
            //if (row == null)
            //{
            //    txtTotalKAD.EditValue = 0;
            //    return;
            //}
            ////txtTotalKAD.EditValue = Convert.ToDouble(row["Nilai"].ToString());
            //txtSupplier.Text = row["Kode Supplier"].ToString();
            //casDataSet.kad.Clear();
            //DataTable dtRFD = DB.sql.Select("select rfd.*,rhp.dk from rfd left outer join rhp on rfd.nodoc=rhp.jurnal where rfp='"+txtRFP.Text+"'");
            //foreach (DataRow rfdRow in dtRFD.Rows)
            //{
            //    DataRow kadRow = casDataSet.kad.NewRow();
            //    //kadRow[""]
            //    kadRow["jurnal"] = rfdRow["nodoc"];
            //    kadRow["acc"] = rfdRow["acc"];
            //    kadRow["val"] = rfdRow["val"];
            //    kadRow["no"] = casDataSet.kad.Rows.Count + 1;
            //    if(rfdRow["dk"].ToString()=="D")
            //       kadRow["dk"] = "K";
            //    else
            //       kadRow["dk"] = "D";

            //    casDataSet.kad.Rows.Add(kadRow);
            //    CalculateTotalKAD();
            //}
            ////gcKAD.ExGridView.AddNewRow(
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
    
        }

        private void tcsiCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (tcsiCheckBox.Checked == true)
                gcKAD.ExGridView.Columns["kurs"].Visible = true;
            else
                gcKAD.ExGridView.Columns["kurs"].Visible = false;
        }

        void tsmiPreviewBkk_Click(object sender, EventArgs e)
        {
            path = Application.StartupPath + "\\Reports\\" + "BBK" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable temp = DB.sql.Select("call SP_Print('Transaction.FrmTKBK','" + this.NoDocument + "')");
            //report.DataSource = dt;
            string terbilangkag = "";
            string terbilangkagn = "";

            int rowcount = 10;
            int oldrow = 0;
            int pagejum = 1;
            int jum1 = 1;
            int nowrowcount = temp.Rows.Count;
            while (nowrowcount > rowcount)
            {
                DataRow data;
                data = temp.NewRow();
                double jum = 0;
                for (int i = oldrow; i < rowcount; i++)
                {
                    jum += Convert.ToDouble(temp.Rows[i]["val"].ToString());
                }
                for (int i = 0; i < 20; i++)
                {
                    data[i] = temp.Rows[0][i];
                }
                data["detailacc"] = data["dk"] = "";
                data["accname"] = "                         Total dari hal." + pagejum.ToString();
                data["val"] = jum;
                temp.Rows.InsertAt(data, rowcount);
                data = temp.NewRow();
                data["accname"] = "                         SALDO PINDAHAN dari hal." + pagejum.ToString();
                data["val"] = jum;
                jum = 0;
                rowcount += 1;
                temp.Rows.InsertAt(data, rowcount);
                pagejum++;
                oldrow = rowcount;
                nowrowcount++;
                rowcount += 10;
            }
            DataRow data1;
            data1 = temp.NewRow();
            temp.Rows.InsertAt(data1, rowcount);
            data1["accname"] = "                         TOTAL :";
            // data1["val"] = Convert.ToDouble(txtTotalKAD.EditValue.ToString());
            data1["val"] = temp.Rows[0]["totalval"].ToString();
            data1 = temp.NewRow();
            rowcount += 1;
            temp.Rows.InsertAt(data1, rowcount);
            data1["accname"] = " Ket:";
            data1 = temp.NewRow();
            rowcount += 1;
            temp.Rows.InsertAt(data1, rowcount);
            //    data1["accname"] = remarkTextBox.Text.Trim();
            data1["accname"] = temp.Rows[0]["remark"].ToString();

            report.DataSource = temp;
            //report.Bands[BandKind.PageHeader].Controls[0].Controls[2].Controls[1].Text = terbilang(Convert.ToDouble(temp.Rows[0]["totalval"].ToString()), curcur.Text);
            //report.Bands[BandKind.PageFooter].Controls[0].Controls[0].Controls[1].Text = temp.Rows[0]["Giro"].ToString() ;
            //if (temp.Rows[0]["Giro"].ToString()!="")
            //{
            //report.Bands[BandKind.PageFooter].Controls[0].Controls[0].Controls[2].Text = ((System.DateTime)(temp.Rows[0]["TglJT"])).ToString("dd/MM/yyyy");
            //}
            //report.Bands[BandKind.PageFooter].Controls[0].Controls[0].Controls[3].Text = temp.Rows[0]["TobePaid"].ToString();
            report.PaperName = "1/2A4";
            report.ShowPreview();
        }

        void tsmiPrintBkk_Click(object sender, EventArgs e)
        {
            path = Application.StartupPath + "\\Reports\\" + "BKK" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable temp = DB.sql.Select("call SP_Print('Transaction.FrmTKBK','" + this.NoDocument + "')");
            //report.DataSource = dt;
            string terbilangkag = "";
            string terbilangkagn = "";

            int rowcount = 10;
            int oldrow = 0;
            int pagejum = 1;
            int jum1 = 1;
            int nowrowcount = temp.Rows.Count;
            while (nowrowcount > rowcount)
            {
                DataRow data;
                data = temp.NewRow();
                double jum = 0;
                for (int i = oldrow; i < rowcount; i++)
                {
                    jum += Convert.ToDouble(temp.Rows[i]["val"].ToString());
                }
                for (int i = 0; i < 20; i++)
                {
                    data[i] = temp.Rows[0][i];
                }
                data["detailacc"] = data["dk"] = "";
                data["accname"] = "                         Total dari hal." + pagejum.ToString();
                data["val"] = jum;
                temp.Rows.InsertAt(data, rowcount);
                data = temp.NewRow();
                data["accname"] = "                         SALDO PINDAHAN dari hal." + pagejum.ToString();
                data["val"] = jum;
                jum = 0;
                rowcount += 1;
                temp.Rows.InsertAt(data, rowcount);
                pagejum++;
                oldrow = rowcount;
                nowrowcount++;
                rowcount += 10;
            }
            DataRow data1;
            data1 = temp.NewRow();
            temp.Rows.InsertAt(data1, rowcount);
            data1["accname"] = "                         TOTAL :";
            // data1["val"] = Convert.ToDouble(txtTotalKAD.EditValue.ToString());
            data1["val"] = temp.Rows[0]["totalval"].ToString();
            data1 = temp.NewRow();
            rowcount += 1;
            temp.Rows.InsertAt(data1, rowcount);
            data1["accname"] = " Ket:";
            data1 = temp.NewRow();
            rowcount += 1;
            temp.Rows.InsertAt(data1, rowcount);
            //    data1["accname"] = remarkTextBox.Text.Trim();
            data1["accname"] = temp.Rows[0]["remark"].ToString();

            report.DataSource = temp;
            report.Bands[BandKind.PageHeader].Controls[0].Controls[2].Controls[1].Text = terbilang(Convert.ToDouble(temp.Rows[0]["totalval"].ToString()), curcur.Text);
            report.Bands[BandKind.PageFooter].Controls[0].Controls[0].Controls[1].Text = temp.Rows[0]["Giro"].ToString();
            if (temp.Rows[0]["Giro"].ToString() != "")
            {
                report.Bands[BandKind.PageFooter].Controls[0].Controls[0].Controls[2].Text = ((System.DateTime)(temp.Rows[0]["TglJT"])).ToString("dd/MM/yyyy");
            }
            report.Bands[BandKind.PageFooter].Controls[0].Controls[0].Controls[3].Text = temp.Rows[0]["TobePaid"].ToString();
            report.PrintingSystem.ShowMarginsWarning = false; 
            report.PaperName = "1/2A4";
            report.Print();
        }

        void tsmiPreviewGiro_Click(object sender, EventArgs e)
        {
            string terbilangkag = terbilang(Convert.ToDouble(txtTotalKAG.EditValue), curcur.Text);
            path = Application.StartupPath + "\\Reports\\" + "RepGiroEk" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('giro','" + this.NoDocument + "')");
            report.DataSource = dt;
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = "#"+Utility.ToTitleCase(terbilangkag).Trim()+"#" ;
            report.ShowPreview();
        }
        void tsmiPrintGiro_Click(object sender, EventArgs e)
        {
            string terbilangkag = terbilang(Convert.ToDouble(txtTotalKAG.EditValue), curcur.Text);
            path = Application.StartupPath + "\\Reports\\" + "RepGiroEk" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('giro','" + this.NoDocument + "')");
            report.DataSource = dt;
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = "#" + Utility.ToTitleCase(terbilangkag).Trim() + "#";
            report.PrintingSystem.ShowMarginsWarning = false; ;
            report.PaperName = "custom1";
            report.Print();
        }

        void tsmiPreviewCek_Click(object sender, EventArgs e)
        {
            string terbilangkag = terbilang(Convert.ToDouble(txtTotalKAG.EditValue), curcur.Text);
            path = Application.StartupPath + "\\Reports\\" + "RepCekEk" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('giro','" + this.NoDocument + "')");
            report.DataSource = dt;
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = "#" + Utility.ToTitleCase(terbilangkag).Trim() + "#" ;
            report.ShowPreview();
        }
        void tsmiPrintCek_Click(object sender, EventArgs e)
        {
            string terbilangkag = terbilang(Convert.ToDouble(txtTotalKAG.EditValue), curcur.Text);
            path = Application.StartupPath + "\\Reports\\" + "RepCekEk" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('giro','" + this.NoDocument + "')");
            report.DataSource = dt;
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = "#" + Utility.ToTitleCase(terbilangkag).Trim() + "#";
            report.PrintingSystem.ShowMarginsWarning = false; ;
            report.PaperName = "custom1";
            report.Print();
        }
        void tsmiPreviewCekMay_Click(object sender, EventArgs e)
        {
            string terbilangkag = terbilang(Convert.ToDouble(txtTotalKAG.EditValue), curcur.Text);
            path = Application.StartupPath + "\\Reports\\" + "RepCekMayBank" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('giro','" + this.NoDocument + "')");
            report.DataSource = dt;
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = "#" + Utility.ToTitleCase(terbilangkag).Trim() + "#";
            report.ShowPreview();
        }
        void tsmiPrintCekMay_Click(object sender, EventArgs e)
        {
            string terbilangkag = terbilang(Convert.ToDouble(txtTotalKAG.EditValue), curcur.Text);
            path = Application.StartupPath + "\\Reports\\" + "RepCekMayBank" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('giro','" + this.NoDocument + "')");
            report.DataSource = dt;
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = "#" + Utility.ToTitleCase(terbilangkag).Trim() + "#";
            report.PrintingSystem.ShowMarginsWarning = false; ;
            report.PaperName = "custom1";
            report.Print();
        }
        void tsmiPreviewCekMdr_Click(object sender, EventArgs e)
        {
            string terbilangkag = terbilang(Convert.ToDouble(txtTotalKAG.EditValue), curcur.Text);
            path = Application.StartupPath + "\\Reports\\" + "RepCekMandiri" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('giro','" + this.NoDocument + "')");
            report.DataSource = dt;
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = "#" + Utility.ToTitleCase(terbilangkag).Trim() + "#";
            report.ShowPreview();
        }
        void tsmiPrintCekMdr_Click(object sender, EventArgs e)
        {
            string terbilangkag = terbilang(Convert.ToDouble(txtTotalKAG.EditValue), curcur.Text);
            path = Application.StartupPath + "\\Reports\\" + "RepCekMandiri" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('giro','" + this.NoDocument + "')");
            report.DataSource = dt;
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = "#" + Utility.ToTitleCase(terbilangkag).Trim() + "#";
            report.PrintingSystem.ShowMarginsWarning = false; ;
            report.PaperName = "custom1";
            report.Print();
        }
        void tsmiPreviewDraft_Click(object sender, EventArgs e)
        {
            string terbilangkag = terbilang(Math.Round(Convert.ToDouble(txtTotalKAG.EditValue),2), curcur.Text);
            path = Application.StartupPath + "\\Reports\\" + "RepDraftkEk" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('giro','" + this.NoDocument + "')");
            report.DataSource = dt;
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = terbilangkag;
            report.ShowPreview();
        }

        void tsmiPreviewDraftBca_Click(object sender, EventArgs e)
        {
            string terbilangkag = terbilang(Math.Round(Convert.ToDouble(txtTotalKAG.EditValue), 2), curcur.Text);
            path = Application.StartupPath + "\\Reports\\" + "RepDraftkBca" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('giro','" + this.NoDocument + "')");
            report.DataSource = dt;
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = terbilangkag;
            report.ShowPreview();
        }

        void tsmiPrintDraft_Click(object sender, EventArgs e)
        {
            string terbilangkag = terbilang(Math.Round(Convert.ToDouble(txtTotalKAG.EditValue), 2), curcur.Text);
            path = Application.StartupPath + "\\Reports\\" + "RepDraftkEk" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('giro','" + this.NoDocument + "')");
            report.DataSource = dt;
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = terbilangkag;
            report.PrintingSystem.ShowMarginsWarning = false;
           // report.PrintingSystem.PageSettings.Landscape = true;
            report.PaperName = "custom1";
            report.Print();
        }

        void tsmiPrintDraftBca_Click(object sender, EventArgs e)
        {
            string terbilangkag = terbilang(Math.Round(Convert.ToDouble(txtTotalKAG.EditValue), 2), curcur.Text);
            path = Application.StartupPath + "\\Reports\\" + "RepDraftkBca" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('giro','" + this.NoDocument + "')");
            report.DataSource = dt;
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = terbilangkag;
            report.PrintingSystem.ShowMarginsWarning = false;
            // report.PrintingSystem.PageSettings.Landscape = true;
            report.PaperName = "custom1";
            report.Print();
        }

        void tsmiPreviewGiroBca_Click(object sender, EventArgs e)
        {
            string terbilangkag = terbilang(Convert.ToDouble(txtTotalKAG.EditValue), curcur.Text);
            path = Application.StartupPath + "\\Reports\\" + "RepGiroBca" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('giro','" + this.NoDocument + "')");
            report.DataSource = dt;
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = "#" + Utility.ToTitleCase(terbilangkag).Trim() + "#"; 
            report.ShowPreview();
        }
        void tsmiPrintGiroBca_Click(object sender, EventArgs e)
        {
            string terbilangkag = terbilang(Convert.ToDouble(txtTotalKAG.EditValue), curcur.Text);
            path = Application.StartupPath + "\\Reports\\" + "RepGiroBca" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('giro','" + this.NoDocument + "')");
            report.DataSource = dt;
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = "#" + Utility.ToTitleCase(terbilangkag).Trim() + "#"; 
            report.PrintingSystem.ShowMarginsWarning = false; 
            report.PaperName = "custom1";
            report.Print();
        }
        void tsmiPreviewCekBca_Click(object sender, EventArgs e)
        {
            string terbilangkag = terbilang(Convert.ToDouble(txtTotalKAG.EditValue), curcur.Text);
            path = Application.StartupPath + "\\Reports\\" + "RepCekBca" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('giro','" + this.NoDocument + "')");
            report.DataSource = dt;
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = "#" + Utility.ToTitleCase(terbilangkag).Trim() + "#"; 
            report.ShowPreview();
        }
        void tsmiPrintCekBca_Click(object sender, EventArgs e)
        {
            string terbilangkag = terbilang(Convert.ToDouble(txtTotalKAG.EditValue), curcur.Text);
            path = Application.StartupPath + "\\Reports\\" + "RepCekBca" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('giro','" + this.NoDocument + "')");
            report.DataSource = dt;
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = "#" + Utility.ToTitleCase(terbilangkag).Trim() + "#"; 
            report.PrintingSystem.ShowMarginsWarning = false; ;
            report.PaperName = "custom1";
            report.Print();
        }
        void tsmiPrintGiroMdr_Click(object sender, EventArgs e)
        {
            string terbilangkag = terbilang(Convert.ToDouble(txtTotalKAG.EditValue), curcur.Text);
            path = Application.StartupPath + "\\Reports\\" + "RepGiroMandiri" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('giro','" + this.NoDocument + "')");
            report.DataSource = dt;
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = "#" + Utility.ToTitleCase(terbilangkag).Trim() + "#";
            report.PrintingSystem.ShowMarginsWarning = false; 
            report.PaperName = "custom1";
            report.Print();
        }

        void tsmiPreviewGiroMdr_Click(object sender, EventArgs e)
        {
            string terbilangkag = terbilang(Convert.ToDouble(txtTotalKAG.EditValue), curcur.Text);
            path = Application.StartupPath + "\\Reports\\" + "RepGiroMandiri" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('giro','" + this.NoDocument + "')");
            report.DataSource = dt;
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = "#" + Utility.ToTitleCase(terbilangkag).Trim() + "#";
            report.ShowPreview();
        }

        void tsmiPrintGiroMay_Click(object sender, EventArgs e)
        {
            string terbilangkag = terbilang(Convert.ToDouble(txtTotalKAG.EditValue), curcur.Text);
            path = Application.StartupPath + "\\Reports\\" + "RepGiroMayBank" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('giro','" + this.NoDocument + "')");
            report.DataSource = dt;
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = "#" + Utility.ToTitleCase(terbilangkag).Trim() + "#";
            report.PrintingSystem.ShowMarginsWarning = false;
            report.PaperName = "custom1";
            report.Print();
        }

        void tsmiPreviewGiroMay_Click(object sender, EventArgs e)
        {
            string terbilangkag = terbilang(Convert.ToDouble(txtTotalKAG.EditValue), curcur.Text);
            path = Application.StartupPath + "\\Reports\\" + "RepGiroMayBank" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('giro','" + this.NoDocument + "')");
            report.DataSource = dt;
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = "#" + Utility.ToTitleCase(terbilangkag).Trim() + "#";
            report.ShowPreview();
        }
        void tsmiPrintDraftMdr_Click(object sender, EventArgs e)
        {
            string terbilangkag = terbilang(Convert.ToDouble(txtTotalKAG.EditValue), curcur.Text);
            path = Application.StartupPath + "\\Reports\\" + "RepDraftMandiri" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('giro','" + this.NoDocument + "')");
            report.DataSource = dt;
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = "#" + Utility.ToTitleCase(terbilangkag).Trim() + "#";
            report.PrintingSystem.ShowMarginsWarning = false; 
            report.PaperName = "custom1";
            report.Print();
        }

        void tsmiPreviewDraftMdr_Click(object sender, EventArgs e)
        {
            string terbilangkag = terbilang(Convert.ToDouble(txtTotalKAG.EditValue), curcur.Text);
            path = Application.StartupPath + "\\Reports\\" + "RepDraftMandiri" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('giro','" + this.NoDocument + "')");
            report.DataSource = dt;
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = "#" + Utility.ToTitleCase(terbilangkag).Trim() + "#";
            report.ShowPreview();
        }

        void tsmiPreviewGiroJatim_Click(object sender, EventArgs e)
        {
            string terbilangkag = terbilang(Convert.ToDouble(txtTotalKAG.EditValue), curcur.Text);
            path = Application.StartupPath + "\\Reports\\" + "RepGiroJatim" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('giro','" + this.NoDocument + "')");
            report.DataSource = dt;
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = "#" + Utility.ToTitleCase(terbilangkag).Trim() + "#";
            report.ShowPreview();
        }
        void tsmiPrintGiroJatim_Click(object sender, EventArgs e)
        {
            string terbilangkag = terbilang(Convert.ToDouble(txtTotalKAG.EditValue), curcur.Text);
            path = Application.StartupPath + "\\Reports\\" + "RepGiroJatim" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('giro','" + this.NoDocument + "')");
            report.DataSource = dt;
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = "#" + Utility.ToTitleCase(terbilangkag).Trim() + "#";
            report.PrintingSystem.ShowMarginsWarning = false; ;
            report.PaperName = "custom1";
            report.Print();
        }

        void tsmiPreviewGiroUOB_Click(object sender, EventArgs e)
        {
            string terbilangkag = terbilang(Convert.ToDouble(txtTotalKAG.EditValue), curcur.Text);
            path = Application.StartupPath + "\\Reports\\" + "RepGiroUOB" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('giro','" + this.NoDocument + "')");
            report.DataSource = dt;
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = "#" + Utility.ToTitleCase(terbilangkag).Trim() + "#"; 
            report.ShowPreview();
        }
        void tsmiPrintGiroUOB_Click(object sender, EventArgs e)
        {
            string terbilangkag = terbilang(Convert.ToDouble(txtTotalKAG.EditValue), curcur.Text);
            path = Application.StartupPath + "\\Reports\\" + "RepGiroUOB" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('giro','" + this.NoDocument + "')");
            report.DataSource = dt;
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = "#" + Utility.ToTitleCase(terbilangkag).Trim() + "#"; 
            report.PrintingSystem.ShowMarginsWarning = false; 
            report.PaperName = "custom1";
            report.Print();
        }
        void tsmiPreviewGiroMAS_Click(object sender, EventArgs e)
        {
            string terbilangkag = terbilang(Convert.ToDouble(txtTotalKAG.EditValue), curcur.Text);
            path = Application.StartupPath + "\\Reports\\" + "RepGiroMAS" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('giro','" + this.NoDocument + "')");
            report.DataSource = dt;
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = "#" + Utility.ToTitleCase(terbilangkag).Trim() + "#"; 
            report.ShowPreview();
        }

        void tsmiPrintGiroMAS_Click(object sender, EventArgs e)
        {
            string terbilangkag = terbilang(Convert.ToDouble(txtTotalKAG.EditValue), curcur.Text);
            path = Application.StartupPath + "\\Reports\\" + "RepGiroMAS" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('giro','" + this.NoDocument + "')");
            report.DataSource = dt;
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = "#" + Utility.ToTitleCase(terbilangkag).Trim() + "#"; 
            report.PrintingSystem.ShowMarginsWarning = false; 
            report.PaperName = "custom1";
            report.Print();
        }

        void tsmiPreviewGiroNiaga_Click(object sender, EventArgs e)
        {
            string terbilangkag = terbilang(Convert.ToDouble(txtTotalKAG.EditValue), curcur.Text);
            path = Application.StartupPath + "\\Reports\\" + "RepGiroNiaga" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('giro','" + this.NoDocument + "')");
            report.DataSource = dt;
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = "#" + Utility.ToTitleCase(terbilangkag).Trim() + "#";
            report.ShowPreview();
        }

        void tsmiPrintGiroNiaga_Click(object sender, EventArgs e)
        {
            string terbilangkag = terbilang(Convert.ToDouble(txtTotalKAG.EditValue), curcur.Text);
            path = Application.StartupPath + "\\Reports\\" + "RepGiroNiaga" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('giro','" + this.NoDocument + "')");
            report.DataSource = dt;
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = "#" + Utility.ToTitleCase(terbilangkag).Trim() + "#";
            report.PrintingSystem.ShowMarginsWarning = false;
            report.PaperName = "custom1";
            report.Print();
        }

        void tsmiPreviewCekNiaga_Click(object sender, EventArgs e)
        {
            string terbilangkag = terbilang(Convert.ToDouble(txtTotalKAG.EditValue), curcur.Text);
            path = Application.StartupPath + "\\Reports\\" + "RepCekNiaga" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('giro','" + this.NoDocument + "')");
            report.DataSource = dt;
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = "#" + Utility.ToTitleCase(terbilangkag).Trim() + "#";
            report.ShowPreview();
        }

        void tsmiPrintSlipNiaga_Click(object sender, EventArgs e)
        {
            string terbilangkag = terbilang(Convert.ToDouble(txtTotalKAG.EditValue), curcur.Text);
            path = Application.StartupPath + "\\Reports\\" + "RepSlipNiaga" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('giro','" + this.NoDocument + "')");
            report.DataSource = dt;
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = "#" + Utility.ToTitleCase(terbilangkag).Trim() + "#";
            report.PrintingSystem.ShowMarginsWarning = false;
            report.PaperName = "custom1";
            report.Print();
        }

        void tsmiPreviewSlipNiaga_Click(object sender, EventArgs e)
        {
            string terbilangkag = terbilang(Convert.ToDouble(txtTotalKAG.EditValue), curcur.Text);
            path = Application.StartupPath + "\\Reports\\" + "RepSlipNiaga" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('giro','" + this.NoDocument + "')");
            report.DataSource = dt;
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = "#" + Utility.ToTitleCase(terbilangkag).Trim() + "#";
            report.ShowPreview();
        }

        void tsmiPrintCekNiaga_Click(object sender, EventArgs e)
        {
            string terbilangkag = terbilang(Convert.ToDouble(txtTotalKAG.EditValue), curcur.Text);
            path = Application.StartupPath + "\\Reports\\" + "RepCekNiaga" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('giro','" + this.NoDocument + "')");
            report.DataSource = dt;
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = "#" + Utility.ToTitleCase(terbilangkag).Trim() + "#";
            report.PrintingSystem.ShowMarginsWarning = false;
            report.PaperName = "custom1";
            report.Print();
        }

        void tsmiPreviewCekUOB_Click(object sender, EventArgs e)
        {
            string terbilangkag = terbilang(Convert.ToDouble(txtTotalKAG.EditValue), curcur.Text);
            path = Application.StartupPath + "\\Reports\\" + "RepCekUOB" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('giro','" + this.NoDocument + "')");
            report.DataSource = dt;
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = "#" + Utility.ToTitleCase(terbilangkag).Trim() + "#"; 
            report.ShowPreview();
        }
        void tsmiPrintCekUOB_Click(object sender, EventArgs e)
        {
            string terbilangkag = terbilang(Convert.ToDouble(txtTotalKAG.EditValue), curcur.Text);
            path = Application.StartupPath + "\\Reports\\" + "RepCekUOB" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('giro','" + this.NoDocument + "')");
            report.DataSource = dt;
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = "#" + Utility.ToTitleCase(terbilangkag).Trim() + "#"; 
            report.PrintingSystem.ShowMarginsWarning = false; 
            report.PaperName = "custom1";
            report.Print();
        }

        void tsmiPreviewCekMAS_Click(object sender, EventArgs e)
        {
            string terbilangkag = terbilang(Convert.ToDouble(txtTotalKAG.EditValue), curcur.Text);
            path = Application.StartupPath + "\\Reports\\" + "RepCekMAS" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('giro','" + this.NoDocument + "')");
            report.DataSource = dt;
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = "#" + Utility.ToTitleCase(terbilangkag).Trim() + "#"; 
            report.ShowPreview();
        }
        void tsmiPrintCekMAS_Click(object sender, EventArgs e)
        {
            string terbilangkag = terbilang(Convert.ToDouble(txtTotalKAG.EditValue), curcur.Text);
            path = Application.StartupPath + "\\Reports\\" + "RepCekMAS" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('giro','" + this.NoDocument + "')");
            report.DataSource = dt;
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = "#" + Utility.ToTitleCase(terbilangkag).Trim() + "#"; 
            report.PrintingSystem.ShowMarginsWarning = false; 
            report.PaperName = "custom1";
            report.Print();
        }

        void tsmiPreviewTransfer_Click(object sender, EventArgs e)
        {
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            string terbilangkag = terbilang(Math.Round(Convert.ToDouble(txtTotalKAG.EditValue), 2), curcur.Text);
            path = Application.StartupPath + "\\Reports\\" + "transferekonomi" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('transfer','" + this.NoDocument + "')");
            report.DataSource = dt;
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = ti.ToTitleCase(terbilangkag.Trim());
            //   report.Bands[BandKind.PageHeader].Controls["xrLabel41"].Text = "        ." + terbilangkag.Trim() + "";
            report.PaperName = "Folio";
            report.ShowPreview();
        }
        void tsmiPrintTransfer_Click(object sender, EventArgs e)
        {
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            string terbilangkag = terbilang(Math.Round(Convert.ToDouble(txtTotalKAG.EditValue), 2), curcur.Text);
            path = Application.StartupPath + "\\Reports\\" + "transferekonomi" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('transfer','" + this.NoDocument + "')");
            report.DataSource = dt;
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = ti.ToTitleCase(terbilangkag.Trim());
            report.PrintingSystem.ShowMarginsWarning = false;
            // report.PrintingSystem.PageSettings.Landscape = true;
          //  report.PaperName = "custom1";// width 25,4  height 27,94 
            report.PaperName = "Folio";
            report.Print();
        }
        void tsmiPreviewTransferMas_Click(object sender, EventArgs e)
        {
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            path = Application.StartupPath + "\\Reports\\" + "transferMas" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('transfer','" + this.NoDocument + "')");
            report.DataSource = dt;
            string terbilangkag = terbilang(Math.Round((double)dt.Rows[0]["totalval"], 2), curcur.Text);
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = ti.ToTitleCase(terbilangkag.Trim());
            //   report.Bands[BandKind.PageHeader].Controls["xrLabel41"].Text = "        ." + terbilangkag.Trim() + "";
            //  report.PaperName = "custom1";
            report.ShowPreview();
        }
        void tsmiPrintTransferMas_Click(object sender, EventArgs e)
        {
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            path = Application.StartupPath + "\\Reports\\" + "transferMas" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('transfer','" + this.NoDocument + "')");
            report.DataSource = dt;
            string terbilangkag = terbilang(Math.Round((double)dt.Rows[0]["totalval"], 2), curcur.Text);
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = ti.ToTitleCase(terbilangkag.Trim());
            report.PrintingSystem.ShowMarginsWarning = false;
            // report.PrintingSystem.PageSettings.Landscape = true;
            //  report.PaperName = "custom1";// width 25,4  height 27,94 
            //report.PaperName = "A4";
            report.Print();
        }
        void tsmiPreviewTransferMasTiti_Click(object sender, EventArgs e)
        {
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            string terbilangkag = "";
            path = Application.StartupPath + "\\Reports\\" + "transferMasTiti" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('transfertiti','" + this.NoDocument + "')");
            report.DataSource = dt;
            if (((double)dt.Rows[0]["kurs"] > 1) && (dt.Rows[0]["tcsi"].ToString()=="False"))
                    terbilangkag = terbilang(Math.Round((double)dt.Rows[0]["totalus"], 2), curcur.Text);
            else
                    terbilangkag = terbilang(Math.Round((double)dt.Rows[0]["totalval"], 2), curcur.Text);
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = ti.ToTitleCase(terbilangkag.Trim());
            //   report.Bands[BandKind.PageHeader].Controls["xrLabel41"].Text = "        ." + terbilangkag.Trim() + "";
            //  report.PaperName = "custom1";
            report.ShowPreview();
        }
        void tsmiPrintTransferMasTiti_Click(object sender, EventArgs e)
        {
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            string terbilangkag = "";
            path = Application.StartupPath + "\\Reports\\" + "transferMasTiti" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('transfertiti','" + this.NoDocument + "')");
            report.DataSource = dt;
            if (((double)dt.Rows[0]["kurs"] > 1) && (dt.Rows[0]["tcsi"].ToString() == "False"))
                terbilangkag = terbilang(Math.Round((double)dt.Rows[0]["totalus"], 2), curcur.Text);
            else
                terbilangkag = terbilang(Math.Round((double)dt.Rows[0]["totalval"], 2), curcur.Text);
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = ti.ToTitleCase(terbilangkag.Trim());
            report.PrintingSystem.ShowMarginsWarning = false;
            // report.PrintingSystem.PageSettings.Landscape = true;
            //  report.PaperName = "custom1";// width 25,4  height 27,94 
            //report.PaperName = "A4";
            report.Print();
        }
        void tsmiPreviewTransferBCA_Click(object sender, EventArgs e)
        {
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            path = Application.StartupPath + "\\Reports\\" + "transferBCA" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('transfer','" + this.NoDocument + "')");
            report.DataSource = dt;
            string terbilangkag = terbilang(Math.Round((double)dt.Rows[0]["totalval"], 2), curcur.Text);
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = ti.ToTitleCase(terbilangkag.Trim());
            //   report.Bands[BandKind.PageHeader].Controls["xrLabel41"].Text = "        ." + terbilangkag.Trim() + "";
            //  report.PaperName = "custom1";
            report.ShowPreview();
        }
        void tsmiPrintTransferBCA_Click(object sender, EventArgs e)
        {
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            path = Application.StartupPath + "\\Reports\\" + "transferBCA" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('transfer','" + this.NoDocument + "')");
            report.DataSource = dt;
            string terbilangkag = terbilang(Math.Round((double)dt.Rows[0]["totalval"], 2), curcur.Text);
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = ti.ToTitleCase(terbilangkag.Trim());
            report.PrintingSystem.ShowMarginsWarning = false;
            // report.PrintingSystem.PageSettings.Landscape = true;
            //  report.PaperName = "custom1";// width 25,4  height 27,94 
            //report.PaperName = "A4";
            report.Print();
        }
        void tsmiPreviewBuktiSetorBCA_Click(object sender, EventArgs e)
        {
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            path = Application.StartupPath + "\\Reports\\" + "BuktiSetorBCA" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('transfer','" + this.NoDocument + "')");
            report.DataSource = dt;
            string terbilangkag = terbilang(Math.Round((double)dt.Rows[0]["totalval"], 2), curcur.Text);
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = ti.ToTitleCase(terbilangkag.Trim());
            //   report.Bands[BandKind.PageHeader].Controls["xrLabel41"].Text = "        ." + terbilangkag.Trim() + "";
            //  report.PaperName = "custom1";
            report.ShowPreview();
        }
        void tsmiPrintBuktiSetorBCA_Click(object sender, EventArgs e)
        {
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            path = Application.StartupPath + "\\Reports\\" + "BuktiSetorBCA" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('transfer','" + this.NoDocument + "')");
            report.DataSource = dt;
            string terbilangkag = terbilang(Math.Round((double)dt.Rows[0]["totalval"], 2), curcur.Text);
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = ti.ToTitleCase(terbilangkag.Trim());
            report.PrintingSystem.ShowMarginsWarning = false;
            // report.PrintingSystem.PageSettings.Landscape = true;
            //  report.PaperName = "custom1";// width 25,4  height 27,94 
            //report.PaperName = "A4";
            report.Print();
        }

        void tsmiPreviewTransferMay_Click(object sender, EventArgs e)
        {
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            path = Application.StartupPath + "\\Reports\\" + "transferMayBank" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('transfer','" + this.NoDocument + "')");
            report.DataSource = dt;
            string terbilangkag = terbilang(Math.Round((double)dt.Rows[0]["totalval"], 2), curcur.Text);
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = ti.ToTitleCase(terbilangkag.Trim());
            //   report.Bands[BandKind.PageHeader].Controls["xrLabel41"].Text = "        ." + terbilangkag.Trim() + "";
            //  report.PaperName = "custom1";
            report.ShowPreview();
        }
        void tsmiPrintTransferMay_Click(object sender, EventArgs e)
        {
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            path = Application.StartupPath + "\\Reports\\" + "transferMayBank" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('transfer','" + this.NoDocument + "')");
            report.DataSource = dt;
            string terbilangkag = terbilang(Math.Round((double)dt.Rows[0]["totalval"], 2), curcur.Text);
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = ti.ToTitleCase(terbilangkag.Trim());
            report.PrintingSystem.ShowMarginsWarning = false;
            // report.PrintingSystem.PageSettings.Landscape = true;
            //  report.PaperName = "custom1";// width 25,4  height 27,94 kopi tem
            //report.PaperName = "A4";
            report.Print();
        }
        void tsmiPreviewTransferMandiri_Click(object sender, EventArgs e)
        {
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            path = Application.StartupPath + "\\Reports\\" + "transferMandiri" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('transfer','" + this.NoDocument + "')");
            report.DataSource = dt;
            string terbilangkag = terbilang(Math.Round((double)dt.Rows[0]["totalval"], 2), curcur.Text);
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = ti.ToTitleCase(terbilangkag.Trim());
            //   report.Bands[BandKind.PageHeader].Controls["xrLabel41"].Text = "        ." + terbilangkag.Trim() + "";
            //  report.PaperName = "custom1";
            report.ShowPreview();
        }
        void tsmiPrintTransferMandiri_Click(object sender, EventArgs e)
        {
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            path = Application.StartupPath + "\\Reports\\" + "transferMandiri" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('transfer','" + this.NoDocument + "')");
            report.DataSource = dt;
            string terbilangkag = terbilang(Math.Round((double)dt.Rows[0]["totalval"], 2), curcur.Text);
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = ti.ToTitleCase(terbilangkag.Trim());
            report.PrintingSystem.ShowMarginsWarning = false;
            // report.PrintingSystem.PageSettings.Landscape = true;
            //  report.PaperName = "custom1";// width 25,4  height 27,94 kopi tem
            //report.PaperName = "A4";
            report.Print();
        }
        void tsmiPreviewTransferNiaga_Click(object sender, EventArgs e)
        {
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            path = Application.StartupPath + "\\Reports\\" + "transferNiaga" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('transfer','" + this.NoDocument + "')");
            report.DataSource = dt;
            string terbilangkag = terbilang(Math.Round((double)dt.Rows[0]["totalval"], 2), curcur.Text);
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = ti.ToTitleCase(terbilangkag.Trim());
            //   report.Bands[BandKind.PageHeader].Controls["xrLabel41"].Text = "        ." + terbilangkag.Trim() + "";
            //  report.PaperName = "custom1";
            report.ShowPreview();
        }
        void tsmiPrintTransferNiaga_Click(object sender, EventArgs e)
        {
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            path = Application.StartupPath + "\\Reports\\" + "transferNiaga" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            DataTable dt = DB.sql.Select("call SP_Print('transfer','" + this.NoDocument + "')");
            report.DataSource = dt;
            string terbilangkag = terbilang(Math.Round((double)dt.Rows[0]["totalval"], 2), curcur.Text);
            report.Bands[BandKind.PageHeader].Controls["xrTerbilang"].Text = ti.ToTitleCase(terbilangkag.Trim());
            report.PrintingSystem.ShowMarginsWarning = false;
            // report.PrintingSystem.PageSettings.Landscape = true;
            //  report.PaperName = "custom1";// width 25,4  height 27,94 
            //report.PaperName = "A4";
            report.Print();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            XtraReport report = XtraReport.FromFile(path, true);
            report.RunDesigner();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}