namespace CAS.Transaction
{
    partial class FrmTMsk
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label duedateLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label bsaLabel;
            System.Windows.Forms.Label label4;
            this.casDataSet = new CAS.casDataSet();
            this.mskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remarkMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.tabDetails = new DevExpress.XtraTab.XtraTabControl();
            this.tabPO = new DevExpress.XtraTab.XtraTabPage();
            this.chkPR = new System.Windows.Forms.CheckBox();
            this.gcxMsl = new KASLibrary.GridControlEx();
            this.listOms = new DevExpress.XtraEditors.ListBoxControl();
            this.btnDeleteOms = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddOms = new DevExpress.XtraEditors.SimpleButton();
            this.tabInvoice = new DevExpress.XtraTab.XtraTabPage();
            this.gcxMsd = new KASLibrary.GridControlEx();
            this.tabJurnal = new DevExpress.XtraTab.XtraTabPage();
            this.gcxMsx = new KASLibrary.GridControlEx();
            this.tabBarang = new DevExpress.XtraTab.XtraTabPage();
            this.gcxLpd = new KASLibrary.GridControlEx();
            this.tabUangMuka = new DevExpress.XtraTab.XtraTabPage();
            this.gcxUmkp = new KASLibrary.GridControlEx();
            this.txtSubTotal = new DevExpress.XtraEditors.TextEdit();
            this.txtUangMuka = new DevExpress.XtraEditors.TextEdit();
            this.spinTOP = new DevExpress.XtraEditors.SpinEdit();
            this.mslBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.msdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.msxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.umkpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mskTableAdapter = new CAS.casDataSetTableAdapters.mskTableAdapter();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.txtPPN = new DevExpress.XtraEditors.TextEdit();
            this.ctrlSub = new CAS.Transaction.CtrlSub();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.txtPPH = new DevExpress.XtraEditors.TextEdit();
            this.dateJatuhTempo = new DevExpress.XtraEditors.DateEdit();
            this.bsaTextBoxEx = new KASLibrary.TextBoxEx();
            this.txtDisc = new DevExpress.XtraEditors.TextEdit();
            duedateLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            bsaLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludSeri.Properties)).BeginInit();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curkurs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curcur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabDetails)).BeginInit();
            this.tabDetails.SuspendLayout();
            this.tabPO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOms)).BeginInit();
            this.tabInvoice.SuspendLayout();
            this.tabJurnal.SuspendLayout();
            this.tabBarang.SuspendLayout();
            this.tabUangMuka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUangMuka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTOP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mslBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.umkpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPPN.Properties)).BeginInit();
            this.pnlTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPPH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateJatuhTempo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsaTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDisc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(215, 21);
            this.txtNo.Size = new System.Drawing.Size(85, 26);
            this.txtNo.EditValueChanged += new System.EventHandler(this.txtNo_EditValueChanged);
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(166, 21);
            this.txtPeriod.Size = new System.Drawing.Size(43, 26);
            // 
            // ludSeri
            // 
            this.ludSeri.Location = new System.Drawing.Point(89, 21);
            this.ludSeri.Size = new System.Drawing.Size(71, 26);
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.txtDisc);
            this.pnlDetail.Controls.Add(label4);
            this.pnlDetail.Controls.Add(bsaLabel);
            this.pnlDetail.Controls.Add(this.bsaTextBoxEx);
            this.pnlDetail.Controls.Add(this.ctrlSub);
            this.pnlDetail.Controls.Add(label12);
            this.pnlDetail.Controls.Add(this.dateJatuhTempo);
            this.pnlDetail.Controls.Add(this.pnlTotal);
            this.pnlDetail.Controls.Add(label11);
            this.pnlDetail.Controls.Add(this.spinTOP);
            this.pnlDetail.Controls.Add(this.tabDetails);
            this.pnlDetail.Controls.Add(this.remarkMemoEdit);
            this.pnlDetail.Controls.Add(label2);
            this.pnlDetail.Controls.Add(duedateLabel);
            this.pnlDetail.Location = new System.Drawing.Point(0, 88);
            this.pnlDetail.Size = new System.Drawing.Size(775, 553);
            this.pnlDetail.Controls.SetChildIndex(this.dateDate, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curcur, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curkurs, 0);
            this.pnlDetail.Controls.SetChildIndex(this.kursLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curLabel1, 0);
            this.pnlDetail.Controls.SetChildIndex(duedateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(label2, 0);
            this.pnlDetail.Controls.SetChildIndex(this.remarkMemoEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(this.tabDetails, 0);
            this.pnlDetail.Controls.SetChildIndex(this.spinTOP, 0);
            this.pnlDetail.Controls.SetChildIndex(label11, 0);
            this.pnlDetail.Controls.SetChildIndex(this.pnlTotal, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateJatuhTempo, 0);
            this.pnlDetail.Controls.SetChildIndex(label12, 0);
            this.pnlDetail.Controls.SetChildIndex(this.ctrlSub, 0);
            this.pnlDetail.Controls.SetChildIndex(this.bsaTextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(bsaLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(label4, 0);
            this.pnlDetail.Controls.SetChildIndex(this.txtDisc, 0);
            // 
            // pnlKey
            // 
            this.pnlKey.Size = new System.Drawing.Size(775, 56);
            // 
            // dateDate
            // 
            this.dateDate.EditValue = new System.DateTime(((long)(0)));
            this.dateDate.Location = new System.Drawing.Point(472, 6);
            this.dateDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.dateDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateDate.Properties.Mask.EditMask = "dd/MM/yyyy HH:mm:ss";
            this.dateDate.Properties.Mask.IgnoreMaskBlank = false;
            this.dateDate.Size = new System.Drawing.Size(120, 26);
            this.dateDate.EditValueChanged += new System.EventHandler(this.dateDate_EditValueChanged);
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(423, 9);
            // 
            // curkurs
            // 
            this.curkurs.Location = new System.Drawing.Point(571, 32);
            this.curkurs.Visible = false;
            // 
            // curcur
            // 
            this.curcur.Location = new System.Drawing.Point(472, 32);
            this.curcur.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.curcur.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.curcur.Properties.Appearance.Options.UseBackColor = true;
            this.curcur.Properties.Appearance.Options.UseForeColor = true;
            this.curcur.Size = new System.Drawing.Size(57, 26);
            this.curcur.EditValueChanged += new System.EventHandler(this.curcur_EditValueChanged);
            // 
            // curLabel1
            // 
            this.curLabel1.Location = new System.Drawing.Point(446, 35);
            // 
            // kursLabel
            // 
            this.kursLabel.Location = new System.Drawing.Point(535, 35);
            this.kursLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(48, 24);
            // 
            // btnDocFlow
            // 
            this.btnDocFlow.Visible = true;
            // 
            // lblDeleted
            // 
            this.lblDeleted.Location = new System.Drawing.Point(348, 18);
            // 
            // duedateLabel
            // 
            duedateLabel.AutoSize = true;
            duedateLabel.Location = new System.Drawing.Point(440, 58);
            duedateLabel.Name = "duedateLabel";
            duedateLabel.Size = new System.Drawing.Size(40, 19);
            duedateLabel.TabIndex = 32;
            duedateLabel.Text = "TOP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(404, 83);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(88, 19);
            label2.TabIndex = 63;
            label2.Text = "Keterangan";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(10, 5);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(77, 19);
            label6.TabIndex = 92;
            label6.Text = "Sub Total";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(10, 26);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(88, 19);
            label7.TabIndex = 93;
            label7.Text = "Uang Muka";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(10, 48);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(38, 19);
            label8.TabIndex = 94;
            label8.Text = "PPN";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(11, 95);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(45, 19);
            label9.TabIndex = 95;
            label9.Text = "Total";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(532, 57);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(43, 19);
            label11.TabIndex = 112;
            label11.Text = "Days";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(569, 58);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(102, 19);
            label12.TabIndex = 123;
            label12.Text = "Jatuh Tempo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(11, 71);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(38, 19);
            label3.TabIndex = 115;
            label3.Text = "PPH";
            // 
            // bsaLabel
            // 
            bsaLabel.AutoSize = true;
            bsaLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            bsaLabel.ForeColor = System.Drawing.Color.Red;
            bsaLabel.Location = new System.Drawing.Point(14, 5);
            bsaLabel.Name = "bsaLabel";
            bsaLabel.Size = new System.Drawing.Size(105, 21);
            bsaLabel.TabIndex = 139;
            bsaLabel.Text = "Bisnis Area";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(577, 414);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(38, 19);
            label4.TabIndex = 142;
            label4.Text = "Disc";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mskBindingSource
            // 
            this.mskBindingSource.DataMember = "msk";
            this.mskBindingSource.DataSource = this.casDataSet;
            this.mskBindingSource.Filter = "group_=1";
            // 
            // remarkMemoEdit
            // 
            this.remarkMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mskBindingSource, "remark", true));
            this.remarkMemoEdit.Location = new System.Drawing.Point(472, 81);
            this.remarkMemoEdit.Name = "remarkMemoEdit";
            this.remarkMemoEdit.Size = new System.Drawing.Size(253, 56);
            this.remarkMemoEdit.TabIndex = 65;
            // 
            // tabDetails
            // 
            this.tabDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabDetails.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.True;
            this.tabDetails.Location = new System.Drawing.Point(12, 150);
            this.tabDetails.Name = "tabDetails";
            this.tabDetails.SelectedTabPage = this.tabPO;
            this.tabDetails.Size = new System.Drawing.Size(751, 279);
            this.tabDetails.TabIndex = 86;
            this.tabDetails.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPO,
            this.tabInvoice,
            this.tabJurnal,
            this.tabBarang,
            this.tabUangMuka});
            this.tabDetails.Text = "List PO";
            this.tabDetails.Click += new System.EventHandler(this.tabDetails_Click);
            // 
            // tabPO
            // 
            this.tabPO.AutoScroll = true;
            this.tabPO.Controls.Add(this.chkPR);
            this.tabPO.Controls.Add(this.gcxMsl);
            this.tabPO.Controls.Add(this.listOms);
            this.tabPO.Controls.Add(this.btnDeleteOms);
            this.tabPO.Controls.Add(this.btnAddOms);
            this.tabPO.Name = "tabPO";
            this.tabPO.Size = new System.Drawing.Size(743, 245);
            this.tabPO.Text = "List PO/PR";
            // 
            // chkPR
            // 
            this.chkPR.AutoSize = true;
            this.chkPR.Location = new System.Drawing.Point(22, 26);
            this.chkPR.Name = "chkPR";
            this.chkPR.Size = new System.Drawing.Size(54, 23);
            this.chkPR.TabIndex = 4;
            this.chkPR.Text = "PR";
            this.chkPR.UseVisualStyleBackColor = true;
            // 
            // gcxMsl
            // 
            this.gcxMsl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcxMsl.BestFitColumn = true;
            this.gcxMsl.ExAutoSize = false;
            this.gcxMsl.Location = new System.Drawing.Point(173, 3);
            this.gcxMsl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gcxMsl.Name = "gcxMsl";
            this.gcxMsl.Size = new System.Drawing.Size(555, 239);
            this.gcxMsl.TabIndex = 3;
            this.gcxMsl.Load += new System.EventHandler(this.gcxMsl_Load);
            // 
            // listOms
            // 
            this.listOms.Location = new System.Drawing.Point(22, 49);
            this.listOms.Name = "listOms";
            this.listOms.Size = new System.Drawing.Size(129, 163);
            this.listOms.TabIndex = 2;
            this.listOms.SelectedIndexChanged += new System.EventHandler(this.listOms_SelectedIndexChanged);
            // 
            // btnDeleteOms
            // 
            this.btnDeleteOms.Location = new System.Drawing.Point(50, 218);
            this.btnDeleteOms.Name = "btnDeleteOms";
            this.btnDeleteOms.Size = new System.Drawing.Size(22, 20);
            this.btnDeleteOms.TabIndex = 1;
            this.btnDeleteOms.Text = "—";
            this.btnDeleteOms.Click += new System.EventHandler(this.btnDeleteOms_Click);
            // 
            // btnAddOms
            // 
            this.btnAddOms.Location = new System.Drawing.Point(22, 218);
            this.btnAddOms.Name = "btnAddOms";
            this.btnAddOms.Size = new System.Drawing.Size(22, 20);
            this.btnAddOms.TabIndex = 1;
            this.btnAddOms.Text = "+";
            this.btnAddOms.Click += new System.EventHandler(this.btnAddOms_Click);
            // 
            // tabInvoice
            // 
            this.tabInvoice.Controls.Add(this.gcxMsd);
            this.tabInvoice.Name = "tabInvoice";
            this.tabInvoice.Size = new System.Drawing.Size(743, 245);
            this.tabInvoice.Text = "Invoice";
            // 
            // gcxMsd
            // 
            this.gcxMsd.BestFitColumn = true;
            this.gcxMsd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcxMsd.ExAutoSize = false;
            this.gcxMsd.Location = new System.Drawing.Point(0, 0);
            this.gcxMsd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gcxMsd.Name = "gcxMsd";
            this.gcxMsd.Size = new System.Drawing.Size(743, 245);
            this.gcxMsd.TabIndex = 83;
            // 
            // tabJurnal
            // 
            this.tabJurnal.Controls.Add(this.gcxMsx);
            this.tabJurnal.Name = "tabJurnal";
            this.tabJurnal.Size = new System.Drawing.Size(743, 245);
            this.tabJurnal.Text = "Jurnal";
            // 
            // gcxMsx
            // 
            this.gcxMsx.BestFitColumn = true;
            this.gcxMsx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcxMsx.ExAutoSize = false;
            this.gcxMsx.Location = new System.Drawing.Point(0, 0);
            this.gcxMsx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gcxMsx.Name = "gcxMsx";
            this.gcxMsx.Size = new System.Drawing.Size(743, 245);
            this.gcxMsx.TabIndex = 0;
            // 
            // tabBarang
            // 
            this.tabBarang.Controls.Add(this.gcxLpd);
            this.tabBarang.Name = "tabBarang";
            this.tabBarang.Size = new System.Drawing.Size(743, 245);
            this.tabBarang.Text = "Penerimaan Barang";
            // 
            // gcxLpd
            // 
            this.gcxLpd.BestFitColumn = true;
            this.gcxLpd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcxLpd.ExAutoSize = false;
            this.gcxLpd.Location = new System.Drawing.Point(0, 0);
            this.gcxLpd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gcxLpd.Name = "gcxLpd";
            this.gcxLpd.Size = new System.Drawing.Size(743, 245);
            this.gcxLpd.TabIndex = 0;
            // 
            // tabUangMuka
            // 
            this.tabUangMuka.Controls.Add(this.gcxUmkp);
            this.tabUangMuka.Name = "tabUangMuka";
            this.tabUangMuka.Size = new System.Drawing.Size(743, 245);
            this.tabUangMuka.Text = "Uang Muka";
            // 
            // gcxUmkp
            // 
            this.gcxUmkp.BestFitColumn = true;
            this.gcxUmkp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcxUmkp.ExAutoSize = false;
            this.gcxUmkp.Location = new System.Drawing.Point(0, 0);
            this.gcxUmkp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gcxUmkp.Name = "gcxUmkp";
            this.gcxUmkp.Size = new System.Drawing.Size(743, 245);
            this.gcxUmkp.TabIndex = 0;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Location = new System.Drawing.Point(76, 3);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSubTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSubTotal.Size = new System.Drawing.Size(121, 26);
            this.txtSubTotal.TabIndex = 88;
            // 
            // txtUangMuka
            // 
            this.txtUangMuka.Enabled = false;
            this.txtUangMuka.Location = new System.Drawing.Point(76, 24);
            this.txtUangMuka.Name = "txtUangMuka";
            this.txtUangMuka.Properties.Appearance.Options.UseTextOptions = true;
            this.txtUangMuka.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtUangMuka.Size = new System.Drawing.Size(121, 26);
            this.txtUangMuka.TabIndex = 89;
            // 
            // spinTOP
            // 
            this.spinTOP.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinTOP.Location = new System.Drawing.Point(472, 55);
            this.spinTOP.Name = "spinTOP";
            this.spinTOP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinTOP.Properties.UseCtrlIncrement = false;
            this.spinTOP.Size = new System.Drawing.Size(56, 26);
            this.spinTOP.TabIndex = 111;
            this.spinTOP.EditValueChanged += new System.EventHandler(this.spinTOP_EditValueChanged);
            // 
            // mslBindingSource
            // 
            this.mslBindingSource.DataMember = "msl";
            this.mslBindingSource.DataSource = this.casDataSet;
            // 
            // msdBindingSource
            // 
            this.msdBindingSource.DataMember = "msd";
            this.msdBindingSource.DataSource = this.casDataSet;
            // 
            // msxBindingSource
            // 
            this.msxBindingSource.DataMember = "msx";
            this.msxBindingSource.DataSource = this.casDataSet;
            // 
            // umkpBindingSource
            // 
            this.umkpBindingSource.DataMember = "umkp";
            this.umkpBindingSource.DataSource = this.casDataSet;
            // 
            // mskTableAdapter
            // 
            this.mskTableAdapter.ClearBeforeFill = true;
            // 
            // txtTotal
            // 
            this.txtTotal.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mskBindingSource, "val", true));
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(77, 92);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotal.Size = new System.Drawing.Size(121, 26);
            this.txtTotal.TabIndex = 113;
            // 
            // txtPPN
            // 
            this.txtPPN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mskBindingSource, "ppn", true));
            this.txtPPN.Enabled = false;
            this.txtPPN.Location = new System.Drawing.Point(76, 46);
            this.txtPPN.Name = "txtPPN";
            this.txtPPN.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPPN.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtPPN.Size = new System.Drawing.Size(121, 26);
            this.txtPPN.TabIndex = 114;
            // 
            // ctrlSub
            // 
            this.ctrlSub.Location = new System.Drawing.Point(3, 28);
            this.ctrlSub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlSub.Name = "ctrlSub";
            this.ctrlSub.ReadOnly = true;
            this.ctrlSub.Size = new System.Drawing.Size(348, 116);
            this.ctrlSub.TabIndex = 115;
            this.ctrlSub.Type = CAS.Transaction.CtrlSub.SubType.Supplier;
            // 
            // pnlTotal
            // 
            this.pnlTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTotal.Controls.Add(this.txtPPH);
            this.pnlTotal.Controls.Add(label3);
            this.pnlTotal.Controls.Add(this.txtSubTotal);
            this.pnlTotal.Controls.Add(this.txtUangMuka);
            this.pnlTotal.Controls.Add(this.txtPPN);
            this.pnlTotal.Controls.Add(label6);
            this.pnlTotal.Controls.Add(this.txtTotal);
            this.pnlTotal.Controls.Add(label7);
            this.pnlTotal.Controls.Add(label8);
            this.pnlTotal.Controls.Add(label9);
            this.pnlTotal.Location = new System.Drawing.Point(544, 435);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(200, 125);
            this.pnlTotal.TabIndex = 116;
            // 
            // txtPPH
            // 
            this.txtPPH.Enabled = false;
            this.txtPPH.Location = new System.Drawing.Point(77, 68);
            this.txtPPH.Name = "txtPPH";
            this.txtPPH.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPPH.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtPPH.Size = new System.Drawing.Size(121, 26);
            this.txtPPH.TabIndex = 116;
            // 
            // dateJatuhTempo
            // 
            this.dateJatuhTempo.EditValue = null;
            this.dateJatuhTempo.Location = new System.Drawing.Point(644, 55);
            this.dateJatuhTempo.Name = "dateJatuhTempo";
            this.dateJatuhTempo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateJatuhTempo.Size = new System.Drawing.Size(100, 26);
            this.dateJatuhTempo.TabIndex = 122;
            // 
            // bsaTextBoxEx
            // 
            this.bsaTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mskBindingSource, "bsa", true));
            this.bsaTextBoxEx.ExAllowEmptyString = true;
            this.bsaTextBoxEx.ExAllowNonDBData = false;
            this.bsaTextBoxEx.ExAutoCheck = true;
            this.bsaTextBoxEx.ExAutoShowResult = false;
            this.bsaTextBoxEx.ExCondition = "";
            this.bsaTextBoxEx.ExDialogTitle = "";
            this.bsaTextBoxEx.ExFieldName = "Kode Area";
            this.bsaTextBoxEx.ExFilterFields = new string[0];
            this.bsaTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.bsaTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.bsaTextBoxEx.ExLabelContainer = null;
            this.bsaTextBoxEx.ExLabelField = "Area";
            this.bsaTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.bsaTextBoxEx.ExLabelText = "";
            this.bsaTextBoxEx.ExLabelVisible = true;
            this.bsaTextBoxEx.ExSelectFields = new string[0];
            this.bsaTextBoxEx.ExShowDialog = true;
            this.bsaTextBoxEx.ExSimpleMode = true;
            this.bsaTextBoxEx.ExSqlInstance = null;
            this.bsaTextBoxEx.ExSqlQuery = "select bsa `Kode Area`, Area from bsa";
            this.bsaTextBoxEx.ExTableName = "bsa";
            this.bsaTextBoxEx.Location = new System.Drawing.Point(89, 2);
            this.bsaTextBoxEx.Name = "bsaTextBoxEx";
            this.bsaTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.bsaTextBoxEx.Size = new System.Drawing.Size(81, 26);
            this.bsaTextBoxEx.TabIndex = 140;
            // 
            // txtDisc
            // 
            this.txtDisc.Enabled = false;
            this.txtDisc.Location = new System.Drawing.Point(619, 412);
            this.txtDisc.Name = "txtDisc";
            this.txtDisc.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDisc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtDisc.Size = new System.Drawing.Size(121, 26);
            this.txtDisc.TabIndex = 141;
            // 
            // FrmTMsk
            // 
            this.ClientSize = new System.Drawing.Size(775, 704);
            this.DetailBindingSource = this.msdBindingSource;
            this.DetailTable = this.casDataSet.msd;
            this.MasterBindingSource = this.mskBindingSource;
            this.MasterTable = this.casDataSet.msk;
            this.Name = "FrmTMsk";
            this.Text = "Invoice Pembelian";
            this.Load += new System.EventHandler(this.FrmTMsk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludSeri.Properties)).EndInit();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.pnlKey.ResumeLayout(false);
            this.pnlKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curkurs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curcur.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabDetails)).EndInit();
            this.tabDetails.ResumeLayout(false);
            this.tabPO.ResumeLayout(false);
            this.tabPO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOms)).EndInit();
            this.tabInvoice.ResumeLayout(false);
            this.tabJurnal.ResumeLayout(false);
            this.tabBarang.ResumeLayout(false);
            this.tabUangMuka.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUangMuka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTOP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mslBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.umkpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPPN.Properties)).EndInit();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPPH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateJatuhTempo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsaTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDisc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource mskBindingSource;
        private DevExpress.XtraEditors.MemoEdit remarkMemoEdit;
        private DevExpress.XtraTab.XtraTabControl tabDetails;
        private DevExpress.XtraTab.XtraTabPage tabInvoice;
        private KASLibrary.GridControlEx gcxMsd;
        private DevExpress.XtraTab.XtraTabPage tabJurnal;
        private KASLibrary.GridControlEx gcxMsx;
        private DevExpress.XtraTab.XtraTabPage tabBarang;
        private KASLibrary.GridControlEx gcxLpd;
        private DevExpress.XtraTab.XtraTabPage tabUangMuka;
        private KASLibrary.GridControlEx gcxUmkp;
        private DevExpress.XtraEditors.TextEdit txtUangMuka;
        private DevExpress.XtraEditors.TextEdit txtSubTotal;
        private DevExpress.XtraTab.XtraTabPage tabPO;
        private KASLibrary.GridControlEx gcxMsl;
        private DevExpress.XtraEditors.ListBoxControl listOms;
        private DevExpress.XtraEditors.SimpleButton btnDeleteOms;
        private DevExpress.XtraEditors.SimpleButton btnAddOms;
        private DevExpress.XtraEditors.SpinEdit spinTOP;
        private System.Windows.Forms.BindingSource mslBindingSource;
        private System.Windows.Forms.BindingSource msdBindingSource;
        private System.Windows.Forms.BindingSource msxBindingSource;
        private System.Windows.Forms.BindingSource umkpBindingSource;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private CAS.casDataSetTableAdapters.mskTableAdapter mskTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtPPN;
        private CtrlSub ctrlSub;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.CheckBox chkPR;
        private DevExpress.XtraEditors.DateEdit dateJatuhTempo;
        private DevExpress.XtraEditors.TextEdit txtPPH;
        private KASLibrary.TextBoxEx bsaTextBoxEx;
        private DevExpress.XtraEditors.TextEdit txtDisc;
    }
}
