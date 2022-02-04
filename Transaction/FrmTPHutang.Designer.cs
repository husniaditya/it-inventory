namespace CAS.Transaction
{
    partial class FrmTPHutang
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
            System.Windows.Forms.Label subLabel;
            System.Windows.Forms.Label accLabel;
            System.Windows.Forms.Label valLabel;
            System.Windows.Forms.Label remarkLabel;
            System.Windows.Forms.Label bilusLabel;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label tcsiLabel;
            System.Windows.Forms.Label valrpLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label5;
            this.casDataSet = new CAS.casDataSet();
            this.kasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remarkTextBox = new System.Windows.Forms.TextBox();
            this.bilusLabel2 = new System.Windows.Forms.Label();
            this.txtSupplier = new KASLibrary.TextBoxEx();
            this.gcKAG = new KASLibrary.GridControlEx();
            this.kagBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gcKAD = new KASLibrary.GridControlEx();
            this.castoRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.chargetoRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.txtTotalKAG = new DevExpress.XtraEditors.TextEdit();
            this.txtTotalKAD = new DevExpress.XtraEditors.TextEdit();
            this.kadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kasTableAdapter = new CAS.casDataSetTableAdapters.kasTableAdapter();
            this.spinEditVal = new DevExpress.XtraEditors.SpinEdit();
            this.txtNoAkun = new KASLibrary.TextBoxEx();
            this.txtRFP = new KASLibrary.TextBoxEx();
            this.tcsiCheckBox = new System.Windows.Forms.CheckBox();
            this.valrpSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.spinEdit2 = new DevExpress.XtraEditors.SpinEdit();
            subLabel = new System.Windows.Forms.Label();
            accLabel = new System.Windows.Forms.Label();
            valLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            bilusLabel = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            tcsiLabel = new System.Windows.Forms.Label();
            valrpLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludSeri.Properties)).BeginInit();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curkurs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curcur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kagBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.castoRadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chargetoRadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalKAG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalKAD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditVal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoAkun.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRFP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valrpSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNo
            // 
            this.txtNo.EditValueChanged += new System.EventHandler(this.txtNo_EditValueChanged);
            // 
            // txtPeriod
            // 
            // 
            // ludSeri
            // 
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(label5);
            this.pnlDetail.Controls.Add(this.spinEdit2);
            this.pnlDetail.Controls.Add(label3);
            this.pnlDetail.Controls.Add(this.spinEdit1);
            this.pnlDetail.Controls.Add(valrpLabel);
            this.pnlDetail.Controls.Add(this.valrpSpinEdit);
            this.pnlDetail.Controls.Add(tcsiLabel);
            this.pnlDetail.Controls.Add(this.tcsiCheckBox);
            this.pnlDetail.Controls.Add(this.txtRFP);
            this.pnlDetail.Controls.Add(label4);
            this.pnlDetail.Controls.Add(this.spinEditVal);
            this.pnlDetail.Controls.Add(this.txtTotalKAD);
            this.pnlDetail.Controls.Add(label2);
            this.pnlDetail.Controls.Add(this.txtTotalKAG);
            this.pnlDetail.Controls.Add(label9);
            this.pnlDetail.Controls.Add(this.chargetoRadioGroup);
            this.pnlDetail.Controls.Add(this.castoRadioGroup);
            this.pnlDetail.Controls.Add(this.gcKAD);
            this.pnlDetail.Controls.Add(this.gcKAG);
            this.pnlDetail.Controls.Add(this.txtNoAkun);
            this.pnlDetail.Controls.Add(this.txtSupplier);
            this.pnlDetail.Controls.Add(this.bilusLabel2);
            this.pnlDetail.Controls.Add(bilusLabel);
            this.pnlDetail.Controls.Add(remarkLabel);
            this.pnlDetail.Controls.Add(this.remarkTextBox);
            this.pnlDetail.Controls.Add(valLabel);
            this.pnlDetail.Controls.Add(accLabel);
            this.pnlDetail.Controls.Add(subLabel);
            this.pnlDetail.Size = new System.Drawing.Size(1027, 584);
            this.pnlDetail.Controls.SetChildIndex(subLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(accLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(valLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.remarkTextBox, 0);
            this.pnlDetail.Controls.SetChildIndex(remarkLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(bilusLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.bilusLabel2, 0);
            this.pnlDetail.Controls.SetChildIndex(this.txtSupplier, 0);
            this.pnlDetail.Controls.SetChildIndex(this.txtNoAkun, 0);
            this.pnlDetail.Controls.SetChildIndex(this.gcKAG, 0);
            this.pnlDetail.Controls.SetChildIndex(this.gcKAD, 0);
            this.pnlDetail.Controls.SetChildIndex(this.castoRadioGroup, 0);
            this.pnlDetail.Controls.SetChildIndex(this.chargetoRadioGroup, 0);
            this.pnlDetail.Controls.SetChildIndex(label9, 0);
            this.pnlDetail.Controls.SetChildIndex(this.txtTotalKAG, 0);
            this.pnlDetail.Controls.SetChildIndex(label2, 0);
            this.pnlDetail.Controls.SetChildIndex(this.txtTotalKAD, 0);
            this.pnlDetail.Controls.SetChildIndex(this.spinEditVal, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curLabel1, 0);
            this.pnlDetail.Controls.SetChildIndex(this.kursLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curkurs, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curcur, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateDate, 0);
            this.pnlDetail.Controls.SetChildIndex(label4, 0);
            this.pnlDetail.Controls.SetChildIndex(this.txtRFP, 0);
            this.pnlDetail.Controls.SetChildIndex(this.tcsiCheckBox, 0);
            this.pnlDetail.Controls.SetChildIndex(tcsiLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.valrpSpinEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(valrpLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.spinEdit1, 0);
            this.pnlDetail.Controls.SetChildIndex(label3, 0);
            this.pnlDetail.Controls.SetChildIndex(this.spinEdit2, 0);
            this.pnlDetail.Controls.SetChildIndex(label5, 0);
            // 
            // pnlKey
            // 
            this.pnlKey.Controls.Add(this.label6);
            this.pnlKey.Size = new System.Drawing.Size(1027, 50);
            this.pnlKey.Controls.SetChildIndex(this.label6, 0);
            this.pnlKey.Controls.SetChildIndex(this.btnDocFlow, 0);
            this.pnlKey.Controls.SetChildIndex(this.label1, 0);
            this.pnlKey.Controls.SetChildIndex(this.ludSeri, 0);
            this.pnlKey.Controls.SetChildIndex(this.txtNo, 0);
            this.pnlKey.Controls.SetChildIndex(this.txtPeriod, 0);
            this.pnlKey.Controls.SetChildIndex(this.lblDeleted, 0);
            // 
            // dateDate
            // 
            this.dateDate.EditValue = new System.DateTime(((long)(0)));
            this.dateDate.Location = new System.Drawing.Point(458, 6);
            this.dateDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.dateDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateDate.Properties.EditFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.dateDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateDate.Properties.Mask.EditMask = "dd/MM/yyyy HH:mm:ss";
            this.dateDate.Properties.Mask.IgnoreMaskBlank = false;
            this.dateDate.Size = new System.Drawing.Size(142, 23);
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(406, 9);
            // 
            // curkurs
            // 
            this.curkurs.Location = new System.Drawing.Point(557, 32);
            // 
            // curcur
            // 
            this.curcur.Location = new System.Drawing.Point(458, 32);
            this.curcur.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.curcur.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.curcur.Properties.Appearance.Options.UseBackColor = true;
            this.curcur.Properties.Appearance.Options.UseForeColor = true;
            this.curcur.EditValueChanged += new System.EventHandler(this.curcur_EditValueChanged);
            // 
            // curLabel1
            // 
            this.curLabel1.Location = new System.Drawing.Point(427, 35);
            // 
            // kursLabel
            // 
            this.kursLabel.Location = new System.Drawing.Point(521, 35);
            // 
            // btnDocFlow
            // 
            this.btnDocFlow.Location = new System.Drawing.Point(623, 12);
            this.btnDocFlow.Visible = true;
            // 
            // subLabel
            // 
            subLabel.AutoSize = true;
            subLabel.Location = new System.Drawing.Point(5, 13);
            subLabel.Name = "subLabel";
            subLabel.Size = new System.Drawing.Size(102, 13);
            subLabel.TabIndex = 28;
            subLabel.Text = "Supplier/Customer :";
            // 
            // accLabel
            // 
            accLabel.AutoSize = true;
            accLabel.Location = new System.Drawing.Point(35, 36);
            accLabel.Name = "accLabel";
            accLabel.Size = new System.Drawing.Size(72, 13);
            accLabel.TabIndex = 29;
            accLabel.Text = "Nomor Akun :";
            // 
            // valLabel
            // 
            valLabel.AutoSize = true;
            valLabel.Location = new System.Drawing.Point(74, 59);
            valLabel.Name = "valLabel";
            valLabel.Size = new System.Drawing.Size(33, 13);
            valLabel.TabIndex = 30;
            valLabel.Text = "Nilai :";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(37, 104);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(70, 13);
            remarkLabel.TabIndex = 31;
            remarkLabel.Text = "Keterangan :";
            // 
            // bilusLabel
            // 
            bilusLabel.AutoSize = true;
            bilusLabel.Location = new System.Drawing.Point(49, 81);
            bilusLabel.Name = "bilusLabel";
            bilusLabel.Size = new System.Drawing.Size(58, 13);
            bilusLabel.TabIndex = 33;
            bilusLabel.Text = "Terbilang :";
            // 
            // label9
            // 
            label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(811, 559);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(31, 13);
            label9.TabIndex = 123;
            label9.Text = "Total";
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(811, 331);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(31, 13);
            label2.TabIndex = 125;
            label2.Text = "Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(37, 161);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(85, 13);
            label4.TabIndex = 128;
            label4.Text = "No Rek Transfer";
            label4.Visible = false;
            // 
            // tcsiLabel
            // 
            tcsiLabel.AutoSize = true;
            tcsiLabel.Location = new System.Drawing.Point(479, 133);
            tcsiLabel.Name = "tcsiLabel";
            tcsiLabel.Size = new System.Drawing.Size(83, 13);
            tcsiLabel.TabIndex = 129;
            tcsiLabel.Text = "Pembelian Dolar";
            // 
            // valrpLabel
            // 
            valrpLabel.AutoSize = true;
            valrpLabel.Location = new System.Drawing.Point(776, 95);
            valrpLabel.Name = "valrpLabel";
            valrpLabel.Size = new System.Drawing.Size(97, 13);
            valrpLabel.TabIndex = 144;
            valrpLabel.Text = "Biaya Transfer Rp.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(776, 23);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(88, 26);
            label3.TabIndex = 146;
            label3.Text = "Biaya Transfer \r\nMata Uang Asing";
            label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(776, 62);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(79, 13);
            label5.TabIndex = 148;
            label5.Text = "Biaya Provision";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kasBindingSource
            // 
            this.kasBindingSource.DataMember = "kas";
            this.kasBindingSource.DataSource = this.casDataSet;
            this.kasBindingSource.Filter = "group_=1";
            // 
            // remarkTextBox
            // 
            this.remarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kasBindingSource, "remark", true));
            this.remarkTextBox.Location = new System.Drawing.Point(110, 104);
            this.remarkTextBox.Multiline = true;
            this.remarkTextBox.Name = "remarkTextBox";
            this.remarkTextBox.Size = new System.Drawing.Size(240, 42);
            this.remarkTextBox.TabIndex = 32;
            // 
            // bilusLabel2
            // 
            this.bilusLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bilusLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kasBindingSource, "bilus", true));
            this.bilusLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bilusLabel2.Location = new System.Drawing.Point(107, 78);
            this.bilusLabel2.Name = "bilusLabel2";
            this.bilusLabel2.Size = new System.Drawing.Size(349, 18);
            this.bilusLabel2.TabIndex = 34;
            this.bilusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSupplier
            // 
            this.txtSupplier.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kasBindingSource, "sub", true));
            this.txtSupplier.ExAllowEmptyString = true;
            this.txtSupplier.ExAllowNonDBData = false;
            this.txtSupplier.ExAutoCheck = true;
            this.txtSupplier.ExAutoShowResult = false;
            this.txtSupplier.ExCondition = "";
            this.txtSupplier.ExDialogTitle = "Supplier";
            this.txtSupplier.ExFieldName = "Kode";
            this.txtSupplier.ExFilterFields = new string[0];
            this.txtSupplier.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtSupplier.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtSupplier.ExLabelContainer = null;
            this.txtSupplier.ExLabelField = "Nama";
            this.txtSupplier.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.txtSupplier.ExLabelText = "";
            this.txtSupplier.ExLabelVisible = true;
            this.txtSupplier.ExSelectFields = new string[0];
            this.txtSupplier.ExShowDialog = true;
            this.txtSupplier.ExSimpleMode = true;
            this.txtSupplier.ExSqlInstance = null;
            this.txtSupplier.ExSqlQuery = "Call SP_LookUp(\'sub\')";
            this.txtSupplier.ExTableName = "";
            this.txtSupplier.Location = new System.Drawing.Point(110, 10);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtSupplier.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtSupplier.Properties.Appearance.Options.UseBackColor = true;
            this.txtSupplier.Properties.Appearance.Options.UseForeColor = true;
            this.txtSupplier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtSupplier.Size = new System.Drawing.Size(100, 20);
            this.txtSupplier.TabIndex = 113;
            this.txtSupplier.EditValueChanged += new System.EventHandler(this.textBoxEx1_EditValueChanged);
            // 
            // gcKAG
            // 
            this.gcKAG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcKAG.BestFitColumn = true;
            this.gcKAG.ExAutoSize = false;
            this.gcKAG.Location = new System.Drawing.Point(16, 177);
            this.gcKAG.Name = "gcKAG";
            this.gcKAG.Size = new System.Drawing.Size(999, 145);
            this.gcKAG.TabIndex = 114;
            // 
            // kagBindingSource
            // 
            this.kagBindingSource.DataMember = "kag";
            this.kagBindingSource.DataSource = this.casDataSet;
            // 
            // gcKAD
            // 
            this.gcKAD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcKAD.BestFitColumn = true;
            this.gcKAD.ExAutoSize = false;
            this.gcKAD.Location = new System.Drawing.Point(15, 380);
            this.gcKAD.Name = "gcKAD";
            this.gcKAD.Size = new System.Drawing.Size(1000, 170);
            this.gcKAD.TabIndex = 115;
            // 
            // castoRadioGroup
            // 
            this.castoRadioGroup.EditValue = 1;
            this.castoRadioGroup.Location = new System.Drawing.Point(458, 58);
            this.castoRadioGroup.Name = "castoRadioGroup";
            this.castoRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Pay in Cash"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Transfer / App"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Transfer / Letter")});
            this.castoRadioGroup.Size = new System.Drawing.Size(119, 64);
            this.castoRadioGroup.TabIndex = 120;
            // 
            // chargetoRadioGroup
            // 
            this.chargetoRadioGroup.EditValue = 1;
            this.chargetoRadioGroup.Location = new System.Drawing.Point(583, 58);
            this.chargetoRadioGroup.Name = "chargetoRadioGroup";
            this.chargetoRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(4, "Beneficiary Account"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(5, "Our Account")});
            this.chargetoRadioGroup.Size = new System.Drawing.Size(126, 64);
            this.chargetoRadioGroup.TabIndex = 121;
            // 
            // txtTotalKAG
            // 
            this.txtTotalKAG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalKAG.Location = new System.Drawing.Point(889, 328);
            this.txtTotalKAG.Name = "txtTotalKAG";
            this.txtTotalKAG.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotalKAG.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotalKAG.Properties.ReadOnly = true;
            this.txtTotalKAG.Size = new System.Drawing.Size(121, 20);
            this.txtTotalKAG.TabIndex = 122;
            // 
            // txtTotalKAD
            // 
            this.txtTotalKAD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalKAD.Location = new System.Drawing.Point(894, 559);
            this.txtTotalKAD.Name = "txtTotalKAD";
            this.txtTotalKAD.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotalKAD.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotalKAD.Properties.ReadOnly = true;
            this.txtTotalKAD.Size = new System.Drawing.Size(121, 20);
            this.txtTotalKAD.TabIndex = 124;
            // 
            // kadBindingSource
            // 
            this.kadBindingSource.DataMember = "kad";
            this.kadBindingSource.DataSource = this.casDataSet;
            // 
            // kasTableAdapter
            // 
            this.kasTableAdapter.ClearBeforeFill = true;
            // 
            // spinEditVal
            // 
            this.spinEditVal.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kasBindingSource, "val", true));
            this.spinEditVal.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditVal.Location = new System.Drawing.Point(110, 55);
            this.spinEditVal.Name = "spinEditVal";
            this.spinEditVal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEditVal.Properties.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.spinEditVal.Properties.UseCtrlIncrement = false;
            this.spinEditVal.Size = new System.Drawing.Size(125, 20);
            this.spinEditVal.TabIndex = 126;
            this.spinEditVal.Leave += new System.EventHandler(this.spinEditVal_Leave);
            // 
            // txtNoAkun
            // 
            this.txtNoAkun.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kasBindingSource, "acc", true));
            this.txtNoAkun.ExAllowEmptyString = true;
            this.txtNoAkun.ExAllowNonDBData = false;
            this.txtNoAkun.ExAutoCheck = true;
            this.txtNoAkun.ExAutoShowResult = false;
            this.txtNoAkun.ExCondition = "";
            this.txtNoAkun.ExDialogTitle = "";
            this.txtNoAkun.ExFieldName = "Nomor Akun";
            this.txtNoAkun.ExFilterFields = new string[0];
            this.txtNoAkun.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtNoAkun.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtNoAkun.ExLabelContainer = null;
            this.txtNoAkun.ExLabelField = "Nama Akun";
            this.txtNoAkun.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.txtNoAkun.ExLabelText = "";
            this.txtNoAkun.ExLabelVisible = true;
            this.txtNoAkun.ExSelectFields = new string[0];
            this.txtNoAkun.ExShowDialog = true;
            this.txtNoAkun.ExSimpleMode = false;
            this.txtNoAkun.ExSqlInstance = null;
            this.txtNoAkun.ExSqlQuery = "Call SP_BrowseM(\'Master.FrmKAS\')";
            this.txtNoAkun.ExTableName = "";
            this.txtNoAkun.Location = new System.Drawing.Point(110, 32);
            this.txtNoAkun.Name = "txtNoAkun";
            this.txtNoAkun.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtNoAkun.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtNoAkun.Properties.Appearance.Options.UseBackColor = true;
            this.txtNoAkun.Properties.Appearance.Options.UseForeColor = true;
            this.txtNoAkun.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtNoAkun.Size = new System.Drawing.Size(100, 20);
            this.txtNoAkun.TabIndex = 113;
            // 
            // txtRFP
            // 
            this.txtRFP.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kasBindingSource, "rfp", true));
            this.txtRFP.ExAllowEmptyString = true;
            this.txtRFP.ExAllowNonDBData = false;
            this.txtRFP.ExAutoCheck = true;
            this.txtRFP.ExAutoShowResult = false;
            this.txtRFP.ExCondition = "";
            this.txtRFP.ExDialogTitle = "Rekening Vendor";
            this.txtRFP.ExFieldName = "AC.Bank";
            this.txtRFP.ExFilterFields = new string[0];
            this.txtRFP.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtRFP.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtRFP.ExLabelContainer = null;
            this.txtRFP.ExLabelField = "NamaRekening";
            this.txtRFP.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.txtRFP.ExLabelText = "";
            this.txtRFP.ExLabelVisible = true;
            this.txtRFP.ExSelectFields = new string[0];
            this.txtRFP.ExShowDialog = true;
            this.txtRFP.ExSimpleMode = true;
            this.txtRFP.ExSqlInstance = null;
            this.txtRFP.ExSqlQuery = "";
            this.txtRFP.ExTableName = "";
            this.txtRFP.Location = new System.Drawing.Point(128, 158);
            this.txtRFP.Name = "txtRFP";
            this.txtRFP.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtRFP.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtRFP.Properties.Appearance.Options.UseBackColor = true;
            this.txtRFP.Properties.Appearance.Options.UseForeColor = true;
            this.txtRFP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtRFP.Size = new System.Drawing.Size(151, 20);
            this.txtRFP.TabIndex = 129;
            this.txtRFP.Visible = false;
            this.txtRFP.EditValueChanged += new System.EventHandler(this.txtRFP_EditValueChanged);
            // 
            // tcsiCheckBox
            // 
            this.tcsiCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.kasBindingSource, "tcsi", true));
            this.tcsiCheckBox.Location = new System.Drawing.Point(458, 128);
            this.tcsiCheckBox.Name = "tcsiCheckBox";
            this.tcsiCheckBox.Size = new System.Drawing.Size(104, 24);
            this.tcsiCheckBox.TabIndex = 130;
            this.tcsiCheckBox.CheckedChanged += new System.EventHandler(this.tcsiCheckBox_CheckedChanged);
            // 
            // valrpSpinEdit
            // 
            this.valrpSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kasBindingSource, "valrp", true));
            this.valrpSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.valrpSpinEdit.Location = new System.Drawing.Point(873, 92);
            this.valrpSpinEdit.Name = "valrpSpinEdit";
            this.valrpSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.valrpSpinEdit.Properties.UseCtrlIncrement = false;
            this.valrpSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.valrpSpinEdit.TabIndex = 145;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(930, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 146;
            this.label6.Text = "o";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // spinEdit1
            // 
            this.spinEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kasBindingSource, "valus", true));
            this.spinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(873, 28);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEdit1.Properties.UseCtrlIncrement = false;
            this.spinEdit1.Size = new System.Drawing.Size(100, 20);
            this.spinEdit1.TabIndex = 147;
            // 
            // spinEdit2
            // 
            this.spinEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kasBindingSource, "valpro", true));
            this.spinEdit2.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit2.Location = new System.Drawing.Point(873, 59);
            this.spinEdit2.Name = "spinEdit2";
            this.spinEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEdit2.Properties.UseCtrlIncrement = false;
            this.spinEdit2.Size = new System.Drawing.Size(100, 20);
            this.spinEdit2.TabIndex = 149;
            // 
            // FrmTPHutang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 714);
            this.DetailBindingSource = this.kagBindingSource;
            this.DetailTable = this.casDataSet.kag;
            this.MasterBindingSource = this.kasBindingSource;
            this.MasterTable = this.casDataSet.kas;
            this.Name = "FrmTPHutang";
            this.Text = "Pelunasan Hutang";
            this.Load += new System.EventHandler(this.FrmTPHutang_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.kasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kagBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.castoRadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chargetoRadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalKAG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalKAD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditVal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoAkun.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRFP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valrpSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource kasBindingSource;
        private System.Windows.Forms.TextBox remarkTextBox;
        private System.Windows.Forms.Label bilusLabel2;
        private KASLibrary.TextBoxEx txtSupplier;
        private KASLibrary.GridControlEx gcKAG;
        private System.Windows.Forms.BindingSource kagBindingSource;
        private KASLibrary.GridControlEx gcKAD;
        private DevExpress.XtraEditors.RadioGroup chargetoRadioGroup;
        private DevExpress.XtraEditors.RadioGroup castoRadioGroup;
        private DevExpress.XtraEditors.TextEdit txtTotalKAD;
        private DevExpress.XtraEditors.TextEdit txtTotalKAG;
        private System.Windows.Forms.BindingSource kadBindingSource;
        private CAS.casDataSetTableAdapters.kasTableAdapter kasTableAdapter;
        private DevExpress.XtraEditors.SpinEdit spinEditVal;
        private KASLibrary.TextBoxEx txtNoAkun;
        private KASLibrary.TextBoxEx txtRFP;
        private System.Windows.Forms.CheckBox tcsiCheckBox;
        private DevExpress.XtraEditors.SpinEdit valrpSpinEdit;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private DevExpress.XtraEditors.SpinEdit spinEdit2;
    }
}
