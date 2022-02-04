namespace CAS.Transaction
{
    partial class FrmTSJRetur
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
            System.Windows.Forms.Label remarkLabel;
            System.Windows.Forms.Label shiptonameLabel;
            System.Windows.Forms.Label angkutanLabel;
            System.Windows.Forms.Label nopolLabel;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label tglproformaLabel;
            System.Windows.Forms.Label nopoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTSJRetur));
            this.remarkMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.sjrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casDataSet = new CAS.casDataSet();
            this.shiptonameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.spmTextBoxEx = new KASLibrary.TextBoxEx();
            this.nopolTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.spinTOP = new DevExpress.XtraEditors.SpinEdit();
            this.gcxSjrd = new KASLibrary.GridControlEx();
            this.sjrdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ctrlSub = new CAS.Transaction.CtrlSub();
            this.shiptoaddressMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.linkToForm1 = new CAS.linkToForm();
            this.sjrTableAdapter = new CAS.casDataSetTableAdapters.sjrTableAdapter();
            this.txtAlias = new KASLibrary.TextBoxEx();
            this.spmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spmTableAdapter = new CAS.casDataSetTableAdapters.spmTableAdapter();
            this.angkutanTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tglbc = new DevExpress.XtraEditors.DateEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.nopoTextEdit = new KASLibrary.TextBoxEx();
            remarkLabel = new System.Windows.Forms.Label();
            shiptonameLabel = new System.Windows.Forms.Label();
            angkutanLabel = new System.Windows.Forms.Label();
            nopolLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            tglproformaLabel = new System.Windows.Forms.Label();
            nopoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludSeri.Properties)).BeginInit();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curkurs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curcur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sjrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiptonameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spmTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nopolTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTOP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sjrdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiptoaddressMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlias.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angkutanTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglbc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nopoTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNo
            // 
            this.txtNo.Size = new System.Drawing.Size(85, 26);
            // 
            // txtPeriod
            // 
            this.txtPeriod.Size = new System.Drawing.Size(43, 26);
            // 
            // ludSeri
            // 
            this.ludSeri.Size = new System.Drawing.Size(71, 26);
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.nopoTextEdit);
            this.pnlDetail.Controls.Add(nopoLabel);
            this.pnlDetail.Controls.Add(tglproformaLabel);
            this.pnlDetail.Controls.Add(this.tglbc);
            this.pnlDetail.Controls.Add(this.angkutanTextEdit);
            this.pnlDetail.Controls.Add(this.txtAlias);
            this.pnlDetail.Controls.Add(this.linkToForm1);
            this.pnlDetail.Controls.Add(this.shiptoaddressMemoEdit);
            this.pnlDetail.Controls.Add(this.ctrlSub);
            this.pnlDetail.Controls.Add(this.gcxSjrd);
            this.pnlDetail.Controls.Add(angkutanLabel);
            this.pnlDetail.Controls.Add(nopolLabel);
            this.pnlDetail.Controls.Add(this.nopolTextEdit);
            this.pnlDetail.Controls.Add(this.spinTOP);
            this.pnlDetail.Controls.Add(label5);
            this.pnlDetail.Controls.Add(remarkLabel);
            this.pnlDetail.Controls.Add(this.remarkMemoEdit);
            this.pnlDetail.Controls.Add(shiptonameLabel);
            this.pnlDetail.Controls.Add(this.shiptonameTextEdit);
            this.pnlDetail.Controls.Add(this.spmTextBoxEx);
            this.pnlDetail.Location = new System.Drawing.Point(0, 88);
            this.pnlDetail.Size = new System.Drawing.Size(943, 536);
            this.pnlDetail.Controls.SetChildIndex(this.dateDate, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curcur, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curkurs, 0);
            this.pnlDetail.Controls.SetChildIndex(this.kursLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curLabel1, 0);
            this.pnlDetail.Controls.SetChildIndex(this.spmTextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(this.shiptonameTextEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(shiptonameLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.remarkMemoEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(remarkLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(label5, 0);
            this.pnlDetail.Controls.SetChildIndex(this.spinTOP, 0);
            this.pnlDetail.Controls.SetChildIndex(this.nopolTextEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(nopolLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(angkutanLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.gcxSjrd, 0);
            this.pnlDetail.Controls.SetChildIndex(this.ctrlSub, 0);
            this.pnlDetail.Controls.SetChildIndex(this.shiptoaddressMemoEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(this.linkToForm1, 0);
            this.pnlDetail.Controls.SetChildIndex(this.txtAlias, 0);
            this.pnlDetail.Controls.SetChildIndex(this.angkutanTextEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(this.tglbc, 0);
            this.pnlDetail.Controls.SetChildIndex(tglproformaLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(nopoLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.nopoTextEdit, 0);
            // 
            // pnlKey
            // 
            this.pnlKey.Controls.Add(this.button1);
            this.pnlKey.Size = new System.Drawing.Size(943, 56);
            this.pnlKey.Controls.SetChildIndex(this.button1, 0);
            this.pnlKey.Controls.SetChildIndex(this.label1, 0);
            this.pnlKey.Controls.SetChildIndex(this.ludSeri, 0);
            this.pnlKey.Controls.SetChildIndex(this.txtNo, 0);
            this.pnlKey.Controls.SetChildIndex(this.txtPeriod, 0);
            this.pnlKey.Controls.SetChildIndex(this.btnDocFlow, 0);
            this.pnlKey.Controls.SetChildIndex(this.lblDeleted, 0);
            // 
            // dateDate
            // 
            this.dateDate.EditValue = new System.DateTime(((long)(0)));
            this.dateDate.Location = new System.Drawing.Point(477, 9);
            this.dateDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.dateDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateDate.Properties.Mask.EditMask = "dd/MM/yyyy HH:mm:ss";
            this.dateDate.Properties.Mask.IgnoreMaskBlank = false;
            this.dateDate.Size = new System.Drawing.Size(122, 26);
            this.dateDate.EditValueChanged += new System.EventHandler(this.dateDate_EditValueChanged);
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(421, 12);
            // 
            // curkurs
            // 
            this.curkurs.Location = new System.Drawing.Point(548, 194);
            this.curkurs.Visible = false;
            // 
            // curcur
            // 
            this.curcur.Location = new System.Drawing.Point(443, 194);
            this.curcur.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.curcur.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.curcur.Properties.Appearance.Options.UseBackColor = true;
            this.curcur.Properties.Appearance.Options.UseForeColor = true;
            this.curcur.Size = new System.Drawing.Size(57, 26);
            this.curcur.Visible = false;
            // 
            // curLabel1
            // 
            this.curLabel1.Location = new System.Drawing.Point(414, 194);
            this.curLabel1.Visible = false;
            // 
            // kursLabel
            // 
            this.kursLabel.Location = new System.Drawing.Point(514, 194);
            this.kursLabel.Visible = false;
            // 
            // btnDocFlow
            // 
            this.btnDocFlow.Visible = true;
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(28, 165);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(88, 19);
            remarkLabel.TabIndex = 58;
            remarkLabel.Text = "Keterangan";
            // 
            // shiptonameLabel
            // 
            shiptonameLabel.AutoSize = true;
            shiptonameLabel.Location = new System.Drawing.Point(429, 90);
            shiptonameLabel.Name = "shiptonameLabel";
            shiptonameLabel.Size = new System.Drawing.Size(59, 19);
            shiptonameLabel.TabIndex = 54;
            shiptonameLabel.Text = "Ship to";
            // 
            // angkutanLabel
            // 
            angkutanLabel.AutoSize = true;
            angkutanLabel.Location = new System.Drawing.Point(416, 64);
            angkutanLabel.Name = "angkutanLabel";
            angkutanLabel.Size = new System.Drawing.Size(77, 19);
            angkutanLabel.TabIndex = 63;
            angkutanLabel.Text = "Angkutan";
            // 
            // nopolLabel
            // 
            nopolLabel.AutoSize = true;
            nopolLabel.Location = new System.Drawing.Point(421, 38);
            nopolLabel.Name = "nopolLabel";
            nopolLabel.Size = new System.Drawing.Size(71, 19);
            nopolLabel.TabIndex = 62;
            nopolLabel.Text = "No Polisi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(286, 12);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(40, 19);
            label5.TabIndex = 60;
            label5.Text = "TOP";
            label5.Visible = false;
            // 
            // tglproformaLabel
            // 
            tglproformaLabel.AutoSize = true;
            tglproformaLabel.Location = new System.Drawing.Point(695, 16);
            tglproformaLabel.Name = "tglproformaLabel";
            tglproformaLabel.Size = new System.Drawing.Size(151, 19);
            tglproformaLabel.TabIndex = 136;
            tglproformaLabel.Text = "Tgl Rekam Beacukai";
            // 
            // nopoLabel
            // 
            nopoLabel.AutoSize = true;
            nopoLabel.Location = new System.Drawing.Point(744, 67);
            nopoLabel.Name = "nopoLabel";
            nopoLabel.Size = new System.Drawing.Size(55, 19);
            nopoLabel.TabIndex = 139;
            nopoLabel.Text = "No PO";
            // 
            // remarkMemoEdit
            // 
            this.remarkMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sjrBindingSource, "remark", true));
            this.remarkMemoEdit.Location = new System.Drawing.Point(95, 163);
            this.remarkMemoEdit.Name = "remarkMemoEdit";
            this.remarkMemoEdit.Size = new System.Drawing.Size(276, 48);
            this.remarkMemoEdit.TabIndex = 59;
            // 
            // sjrBindingSource
            // 
            this.sjrBindingSource.DataMember = "sjr";
            this.sjrBindingSource.DataSource = this.casDataSet;
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shiptonameTextEdit
            // 
            this.shiptonameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sjrBindingSource, "shiptoname", true));
            this.shiptonameTextEdit.Location = new System.Drawing.Point(477, 87);
            this.shiptonameTextEdit.Name = "shiptonameTextEdit";
            this.shiptonameTextEdit.Size = new System.Drawing.Size(191, 26);
            this.shiptonameTextEdit.TabIndex = 56;
            // 
            // spmTextBoxEx
            // 
            this.spmTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sjrBindingSource, "spm", true));
            this.spmTextBoxEx.ExAllowEmptyString = true;
            this.spmTextBoxEx.ExAllowNonDBData = false;
            this.spmTextBoxEx.ExAutoCheck = false;
            this.spmTextBoxEx.ExAutoShowResult = false;
            this.spmTextBoxEx.ExCondition = "";
            this.spmTextBoxEx.ExDialogTitle = "Surat Perintah Muat";
            this.spmTextBoxEx.ExFieldName = "spm";
            this.spmTextBoxEx.ExFilterFields = new string[0];
            this.spmTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.spmTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.spmTextBoxEx.ExLabelContainer = null;
            this.spmTextBoxEx.ExLabelField = "";
            this.spmTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.spmTextBoxEx.ExLabelText = "";
            this.spmTextBoxEx.ExLabelVisible = false;
            this.spmTextBoxEx.ExSelectFields = new string[0];
            this.spmTextBoxEx.ExShowDialog = true;
            this.spmTextBoxEx.ExSimpleMode = true;
            this.spmTextBoxEx.ExSqlInstance = null;
            this.spmTextBoxEx.ExSqlQuery = "";
            this.spmTextBoxEx.ExTableName = "spm";
            this.spmTextBoxEx.Location = new System.Drawing.Point(95, 9);
            this.spmTextBoxEx.Name = "spmTextBoxEx";
            this.spmTextBoxEx.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.spmTextBoxEx.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.spmTextBoxEx.Properties.Appearance.Options.UseBackColor = true;
            this.spmTextBoxEx.Properties.Appearance.Options.UseForeColor = true;
            this.spmTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.spmTextBoxEx.Size = new System.Drawing.Size(140, 26);
            this.spmTextBoxEx.TabIndex = 46;
            this.spmTextBoxEx.EditValueChanged += new System.EventHandler(this.spmTextBoxEx_EditValueChanged);
            this.spmTextBoxEx.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.spmTextBoxEx_ButtonPressed);
            // 
            // nopolTextEdit
            // 
            this.nopolTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sjrBindingSource, "nopol", true));
            this.nopolTextEdit.Location = new System.Drawing.Point(477, 35);
            this.nopolTextEdit.Name = "nopolTextEdit";
            this.nopolTextEdit.Size = new System.Drawing.Size(100, 26);
            this.nopolTextEdit.TabIndex = 64;
            // 
            // spinTOP
            // 
            this.spinTOP.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinTOP.Location = new System.Drawing.Point(323, 9);
            this.spinTOP.Name = "spinTOP";
            this.spinTOP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinTOP.Properties.UseCtrlIncrement = false;
            this.spinTOP.Size = new System.Drawing.Size(66, 26);
            this.spinTOP.TabIndex = 61;
            this.spinTOP.Visible = false;
            // 
            // gcxSjrd
            // 
            this.gcxSjrd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcxSjrd.BestFitColumn = true;
            this.gcxSjrd.ExAutoSize = false;
            this.gcxSjrd.Location = new System.Drawing.Point(12, 217);
            this.gcxSjrd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gcxSjrd.Name = "gcxSjrd";
            this.gcxSjrd.Size = new System.Drawing.Size(919, 313);
            this.gcxSjrd.TabIndex = 66;
            // 
            // sjrdBindingSource
            // 
            this.sjrdBindingSource.DataMember = "sjrd";
            this.sjrdBindingSource.DataSource = this.casDataSet;
            // 
            // ctrlSub
            // 
            this.ctrlSub.Location = new System.Drawing.Point(31, 35);
            this.ctrlSub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlSub.Name = "ctrlSub";
            this.ctrlSub.ReadOnly = true;
            this.ctrlSub.Size = new System.Drawing.Size(335, 115);
            this.ctrlSub.TabIndex = 67;
            this.ctrlSub.Type = CAS.Transaction.CtrlSub.SubType.All;
            // 
            // shiptoaddressMemoEdit
            // 
            this.shiptoaddressMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sjrBindingSource, "shiptoaddress", true));
            this.shiptoaddressMemoEdit.Location = new System.Drawing.Point(477, 112);
            this.shiptoaddressMemoEdit.Name = "shiptoaddressMemoEdit";
            this.shiptoaddressMemoEdit.Size = new System.Drawing.Size(211, 49);
            this.shiptoaddressMemoEdit.TabIndex = 128;
            // 
            // linkToForm1
            // 
            this.linkToForm1.AutoSize = true;
            this.linkToForm1.FormName = "FrmTSpm";
            this.linkToForm1.Location = new System.Drawing.Point(42, 12);
            this.linkToForm1.Name = "linkToForm1";
            this.linkToForm1.Size = new System.Drawing.Size(64, 19);
            this.linkToForm1.TabIndex = 129;
            this.linkToForm1.TabStop = true;
            this.linkToForm1.Text = "No SPM";
            this.linkToForm1.TxtKode = this.spmTextBoxEx;
            // 
            // sjrTableAdapter
            // 
            this.sjrTableAdapter.ClearBeforeFill = true;
            // 
            // txtAlias
            // 
            this.txtAlias.ExAllowEmptyString = true;
            this.txtAlias.ExAllowNonDBData = false;
            this.txtAlias.ExAutoCheck = true;
            this.txtAlias.ExAutoShowResult = false;
            this.txtAlias.ExCondition = "";
            this.txtAlias.ExDialogTitle = "";
            this.txtAlias.ExFieldName = "Alias";
            this.txtAlias.ExFilterFields = new string[0];
            this.txtAlias.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtAlias.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtAlias.ExLabelContainer = null;
            this.txtAlias.ExLabelField = "";
            this.txtAlias.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtAlias.ExLabelText = "";
            this.txtAlias.ExLabelVisible = false;
            this.txtAlias.ExSelectFields = new string[0];
            this.txtAlias.ExShowDialog = true;
            this.txtAlias.ExSimpleMode = true;
            this.txtAlias.ExSqlInstance = null;
            this.txtAlias.ExSqlQuery = "Call SP_LookUp(\'subto\')";
            this.txtAlias.ExTableName = "subto";
            this.txtAlias.Location = new System.Drawing.Point(666, 114);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtAlias.Size = new System.Drawing.Size(22, 26);
            this.txtAlias.TabIndex = 132;
            this.txtAlias.Visible = false;
            this.txtAlias.EditValueChanged += new System.EventHandler(this.txtAlias_EditValueChanged);
            // 
            // spmBindingSource
            // 
            this.spmBindingSource.DataMember = "spm";
            this.spmBindingSource.DataSource = this.casDataSet;
            // 
            // spmTableAdapter
            // 
            this.spmTableAdapter.ClearBeforeFill = true;
            // 
            // angkutanTextEdit
            // 
            this.angkutanTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sjrBindingSource, "angkutan", true));
            this.angkutanTextEdit.Location = new System.Drawing.Point(477, 61);
            this.angkutanTextEdit.Name = "angkutanTextEdit";
            this.angkutanTextEdit.Size = new System.Drawing.Size(191, 26);
            this.angkutanTextEdit.TabIndex = 133;
            // 
            // tglbc
            // 
            this.tglbc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sjrBindingSource, "tgl_bc", true));
            this.tglbc.EditValue = null;
            this.tglbc.Location = new System.Drawing.Point(802, 12);
            this.tglbc.Name = "tglbc";
            this.tglbc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tglbc.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.tglbc.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.tglbc.Properties.EditFormat.FormatString = "d";
            this.tglbc.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.tglbc.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.tglbc.Size = new System.Drawing.Size(100, 26);
            this.tglbc.TabIndex = 137;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(645, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "Send To LPB PSSA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nopoTextEdit
            // 
            this.nopoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sjrBindingSource, "spm", true));
            this.nopoTextEdit.ExAllowEmptyString = true;
            this.nopoTextEdit.ExAllowNonDBData = false;
            this.nopoTextEdit.ExAutoCheck = false;
            this.nopoTextEdit.ExAutoShowResult = false;
            this.nopoTextEdit.ExCondition = "";
            this.nopoTextEdit.ExDialogTitle = "Surat Perintah Muat";
            this.nopoTextEdit.ExFieldName = "oms";
            this.nopoTextEdit.ExFilterFields = new string[0];
            this.nopoTextEdit.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.nopoTextEdit.ExInvalidForeColor = System.Drawing.Color.Black;
            this.nopoTextEdit.ExLabelContainer = null;
            this.nopoTextEdit.ExLabelField = "";
            this.nopoTextEdit.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.nopoTextEdit.ExLabelText = "";
            this.nopoTextEdit.ExLabelVisible = false;
            this.nopoTextEdit.ExSelectFields = new string[0];
            this.nopoTextEdit.ExShowDialog = true;
            this.nopoTextEdit.ExSimpleMode = true;
            this.nopoTextEdit.ExSqlInstance = null;
            this.nopoTextEdit.ExSqlQuery = resources.GetString("nopoTextEdit.ExSqlQuery");
            this.nopoTextEdit.ExTableName = "oms";
            this.nopoTextEdit.Location = new System.Drawing.Point(791, 63);
            this.nopoTextEdit.Name = "nopoTextEdit";
            this.nopoTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.nopoTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.nopoTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.nopoTextEdit.Properties.Appearance.Options.UseForeColor = true;
            this.nopoTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.nopoTextEdit.Size = new System.Drawing.Size(140, 26);
            this.nopoTextEdit.TabIndex = 141;
            // 
            // FrmTSJRetur
            // 
            this.ClientSize = new System.Drawing.Size(943, 687);
            this.DetailBindingSource = this.sjrdBindingSource;
            this.DetailTable = this.casDataSet.sjrd;
            this.MasterBindingSource = this.sjrBindingSource;
            this.MasterTable = this.casDataSet.sjr;
            this.Name = "FrmTSJRetur";
            this.Text = "Surat Jalan Retur";
            this.Load += new System.EventHandler(this.FrmTSJRetur_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sjrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiptonameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spmTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nopolTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTOP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sjrdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiptoaddressMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlias.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angkutanTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglbc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nopoTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit remarkMemoEdit;
        private DevExpress.XtraEditors.TextEdit shiptonameTextEdit;
        private KASLibrary.TextBoxEx spmTextBoxEx;
        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource sjrBindingSource;
        private DevExpress.XtraEditors.TextEdit nopolTextEdit;
        private DevExpress.XtraEditors.SpinEdit spinTOP;
        private KASLibrary.GridControlEx gcxSjrd;
        private System.Windows.Forms.BindingSource sjrdBindingSource;
        private CtrlSub ctrlSub;
        private DevExpress.XtraEditors.MemoEdit shiptoaddressMemoEdit;
        private linkToForm linkToForm1;
        private CAS.casDataSetTableAdapters.sjrTableAdapter sjrTableAdapter;
        private KASLibrary.TextBoxEx txtAlias;
        private System.Windows.Forms.BindingSource spmBindingSource;
        private CAS.casDataSetTableAdapters.spmTableAdapter spmTableAdapter;
        private DevExpress.XtraEditors.TextEdit angkutanTextEdit;
        private DevExpress.XtraEditors.DateEdit tglbc;
        private System.Windows.Forms.Button button1;
        private KASLibrary.TextBoxEx nopoTextEdit;
    }
}
