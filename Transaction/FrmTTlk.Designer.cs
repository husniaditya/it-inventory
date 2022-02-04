namespace CAS.Transaction
{
    partial class FrmTTlk
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
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label jenisLabel;
            System.Windows.Forms.Label nobgLabel;
            System.Windows.Forms.Label bankLabel;
            System.Windows.Forms.Label acbankLabel;
            System.Windows.Forms.Label bgdateLabel;
            System.Windows.Forms.Label bgduedateLabel;
            System.Windows.Forms.Label bgvalLabel;
            System.Windows.Forms.Label subLabel;
            System.Windows.Forms.Label accbankLabel;
            System.Windows.Forms.Label accLabel;
            System.Windows.Forms.Label remarkLabel;
            this.txtPeriod = new DevExpress.XtraEditors.TextEdit();
            this.tlkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casDataSet = new CAS.casDataSet();
            this.txtNo = new DevExpress.XtraEditors.TextEdit();
            this.ludSeri = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.tlkTableAdapter = new CAS.casDataSetTableAdapters.tlkTableAdapter();
            this.dateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.jenisRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.nobgTextBoxEx = new KASLibrary.TextBoxEx();
            this.bankTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.acbankTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.bgdateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.bgduedateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.bgvalSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.subTextBoxEx = new KASLibrary.TextBoxEx();
            this.accbankTextBoxEx = new KASLibrary.TextBoxEx();
            this.accTextBoxEx = new KASLibrary.TextBoxEx();
            this.remarkMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            dateLabel = new System.Windows.Forms.Label();
            jenisLabel = new System.Windows.Forms.Label();
            nobgLabel = new System.Windows.Forms.Label();
            bankLabel = new System.Windows.Forms.Label();
            acbankLabel = new System.Windows.Forms.Label();
            bgdateLabel = new System.Windows.Forms.Label();
            bgduedateLabel = new System.Windows.Forms.Label();
            bgvalLabel = new System.Windows.Forms.Label();
            subLabel = new System.Windows.Forms.Label();
            accbankLabel = new System.Windows.Forms.Label();
            accLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludSeri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenisRadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nobgTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acbankTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgdateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgduedateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgvalSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accbankTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(remarkLabel);
            this.pnlDetail.Controls.Add(this.remarkMemoEdit);
            this.pnlDetail.Controls.Add(accLabel);
            this.pnlDetail.Controls.Add(this.accTextBoxEx);
            this.pnlDetail.Controls.Add(accbankLabel);
            this.pnlDetail.Controls.Add(this.accbankTextBoxEx);
            this.pnlDetail.Controls.Add(subLabel);
            this.pnlDetail.Controls.Add(this.subTextBoxEx);
            this.pnlDetail.Controls.Add(bgvalLabel);
            this.pnlDetail.Controls.Add(this.bgvalSpinEdit);
            this.pnlDetail.Controls.Add(bgduedateLabel);
            this.pnlDetail.Controls.Add(this.bgduedateDateEdit);
            this.pnlDetail.Controls.Add(bgdateLabel);
            this.pnlDetail.Controls.Add(this.bgdateDateEdit);
            this.pnlDetail.Controls.Add(acbankLabel);
            this.pnlDetail.Controls.Add(this.acbankTextEdit);
            this.pnlDetail.Controls.Add(bankLabel);
            this.pnlDetail.Controls.Add(this.bankTextEdit);
            this.pnlDetail.Controls.Add(nobgLabel);
            this.pnlDetail.Controls.Add(this.nobgTextBoxEx);
            this.pnlDetail.Controls.Add(jenisLabel);
            this.pnlDetail.Controls.Add(this.jenisRadioGroup);
            this.pnlDetail.Controls.Add(dateLabel);
            this.pnlDetail.Controls.Add(this.dateDateEdit);
            this.pnlDetail.Size = new System.Drawing.Size(442, 363);
            // 
            // pnlKey
            // 
            this.pnlKey.Controls.Add(this.txtPeriod);
            this.pnlKey.Controls.Add(this.txtNo);
            this.pnlKey.Controls.Add(this.ludSeri);
            this.pnlKey.Controls.Add(this.label1);
            this.pnlKey.Size = new System.Drawing.Size(442, 56);
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(59, 19);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(52, 13);
            dateLabel.TabIndex = 0;
            dateLabel.Text = "Tanggal :";
            // 
            // jenisLabel
            // 
            jenisLabel.AutoSize = true;
            jenisLabel.Location = new System.Drawing.Point(52, 46);
            jenisLabel.Name = "jenisLabel";
            jenisLabel.Size = new System.Drawing.Size(59, 13);
            jenisLabel.TabIndex = 118;
            jenisLabel.Text = "Jenis Giro :";
            // 
            // nobgLabel
            // 
            nobgLabel.AutoSize = true;
            nobgLabel.Location = new System.Drawing.Point(66, 75);
            nobgLabel.Name = "nobgLabel";
            nobgLabel.Size = new System.Drawing.Size(45, 13);
            nobgLabel.TabIndex = 118;
            nobgLabel.Text = "No BG :";
            // 
            // bankLabel
            // 
            bankLabel.AutoSize = true;
            bankLabel.Location = new System.Drawing.Point(73, 101);
            bankLabel.Name = "bankLabel";
            bankLabel.Size = new System.Drawing.Size(38, 13);
            bankLabel.TabIndex = 119;
            bankLabel.Text = "Bank :";
            // 
            // acbankLabel
            // 
            acbankLabel.AutoSize = true;
            acbankLabel.Location = new System.Drawing.Point(67, 127);
            acbankLabel.Name = "acbankLabel";
            acbankLabel.Size = new System.Drawing.Size(44, 13);
            acbankLabel.TabIndex = 120;
            acbankLabel.Text = "No AC :";
            // 
            // bgdateLabel
            // 
            bgdateLabel.AutoSize = true;
            bgdateLabel.Location = new System.Drawing.Point(39, 153);
            bgdateLabel.Name = "bgdateLabel";
            bgdateLabel.Size = new System.Drawing.Size(74, 13);
            bgdateLabel.TabIndex = 121;
            bgdateLabel.Text = "Tanggal Giro :";
            // 
            // bgduedateLabel
            // 
            bgduedateLabel.AutoSize = true;
            bgduedateLabel.Location = new System.Drawing.Point(39, 179);
            bgduedateLabel.Name = "bgduedateLabel";
            bgduedateLabel.Size = new System.Drawing.Size(74, 13);
            bgduedateLabel.TabIndex = 122;
            bgduedateLabel.Text = "Tanggal JTP :";
            // 
            // bgvalLabel
            // 
            bgvalLabel.AutoSize = true;
            bgvalLabel.Location = new System.Drawing.Point(80, 205);
            bgvalLabel.Name = "bgvalLabel";
            bgvalLabel.Size = new System.Drawing.Size(33, 13);
            bgvalLabel.TabIndex = 123;
            bgvalLabel.Text = "Nilai :";
            // 
            // subLabel
            // 
            subLabel.AutoSize = true;
            subLabel.Location = new System.Drawing.Point(49, 231);
            subLabel.Name = "subLabel";
            subLabel.Size = new System.Drawing.Size(64, 13);
            subLabel.TabIndex = 124;
            subLabel.Text = "Cust / Sup :";
            // 
            // accbankLabel
            // 
            accbankLabel.AutoSize = true;
            accbankLabel.Location = new System.Drawing.Point(27, 257);
            accbankLabel.Name = "accbankLabel";
            accbankLabel.Size = new System.Drawing.Size(86, 13);
            accbankLabel.TabIndex = 125;
            accbankLabel.Text = "Perkiraan Bank :";
            // 
            // accLabel
            // 
            accLabel.AutoSize = true;
            accLabel.Location = new System.Drawing.Point(3, 283);
            accLabel.Name = "accLabel";
            accLabel.Size = new System.Drawing.Size(110, 13);
            accLabel.TabIndex = 126;
            accLabel.Text = "Perkiraan Giro Tolak :";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(43, 308);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(68, 13);
            remarkLabel.TabIndex = 127;
            remarkLabel.Text = "Keterangan :";
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(164, 18);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Properties.ReadOnly = true;
            this.txtPeriod.Size = new System.Drawing.Size(43, 20);
            this.txtPeriod.TabIndex = 10;
            // 
            // tlkBindingSource
            // 
            this.tlkBindingSource.DataMember = "tlk";
            this.tlkBindingSource.DataSource = this.casDataSet;
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(213, 18);
            this.txtNo.Name = "txtNo";
            this.txtNo.Properties.ReadOnly = true;
            this.txtNo.Size = new System.Drawing.Size(85, 20);
            this.txtNo.TabIndex = 11;
            this.txtNo.EditValueChanged += new System.EventHandler(this.txtNo_EditValueChanged);
            // 
            // ludSeri
            // 
            this.ludSeri.Location = new System.Drawing.Point(87, 18);
            this.ludSeri.Name = "ludSeri";
            this.ludSeri.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ludSeri.Properties.NullText = "???";
            this.ludSeri.Size = new System.Drawing.Size(71, 20);
            this.ludSeri.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nomer";
            // 
            // tlkTableAdapter
            // 
            this.tlkTableAdapter.ClearBeforeFill = true;
            // 
            // dateDateEdit
            // 
            this.dateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tlkBindingSource, "date", true));
            this.dateDateEdit.EditValue = null;
            this.dateDateEdit.Location = new System.Drawing.Point(119, 16);
            this.dateDateEdit.Name = "dateDateEdit";
            this.dateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDateEdit.Size = new System.Drawing.Size(100, 20);
            this.dateDateEdit.TabIndex = 1;
            // 
            // jenisRadioGroup
            // 
            this.jenisRadioGroup.Location = new System.Drawing.Point(119, 42);
            this.jenisRadioGroup.Name = "jenisRadioGroup";
            this.jenisRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Giro Masuk"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Giro Keluar")});
            this.jenisRadioGroup.Size = new System.Drawing.Size(197, 24);
            this.jenisRadioGroup.TabIndex = 117;
            // 
            // nobgTextBoxEx
            // 
            this.nobgTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tlkBindingSource, "nobg", true));
            this.nobgTextBoxEx.ExAllowEmptyString = true;
            this.nobgTextBoxEx.ExAllowNonDBData = false;
            this.nobgTextBoxEx.ExAutoCheck = true;
            this.nobgTextBoxEx.ExAutoShowResult = false;
            this.nobgTextBoxEx.ExCondition = "";
            this.nobgTextBoxEx.ExDialogTitle = "";
            this.nobgTextBoxEx.ExFieldName = "No BG";
            this.nobgTextBoxEx.ExFilterFields = new string[0];
            this.nobgTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.nobgTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.nobgTextBoxEx.ExLabelContainer = null;
            this.nobgTextBoxEx.ExLabelField = "";
            this.nobgTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.nobgTextBoxEx.ExLabelVisible = false;
            this.nobgTextBoxEx.ExSelectFields = new string[0];
            this.nobgTextBoxEx.ExShowDialog = true;
            this.nobgTextBoxEx.ExSimpleMode = false;
            this.nobgTextBoxEx.ExSqlInstance = null;
            this.nobgTextBoxEx.ExSqlQuery = "";
            this.nobgTextBoxEx.ExTableName = "";
            this.nobgTextBoxEx.Location = new System.Drawing.Point(119, 72);
            this.nobgTextBoxEx.Name = "nobgTextBoxEx";
            this.nobgTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.nobgTextBoxEx.Size = new System.Drawing.Size(100, 20);
            this.nobgTextBoxEx.TabIndex = 119;
            this.nobgTextBoxEx.EditValueChanged += new System.EventHandler(this.nobgTextBoxEx_EditValueChanged);
            // 
            // bankTextEdit
            // 
            this.bankTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tlkBindingSource, "bank", true));
            this.bankTextEdit.Location = new System.Drawing.Point(119, 98);
            this.bankTextEdit.Name = "bankTextEdit";
            this.bankTextEdit.Size = new System.Drawing.Size(100, 20);
            this.bankTextEdit.TabIndex = 120;
            // 
            // acbankTextEdit
            // 
            this.acbankTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tlkBindingSource, "acbank", true));
            this.acbankTextEdit.Location = new System.Drawing.Point(119, 124);
            this.acbankTextEdit.Name = "acbankTextEdit";
            this.acbankTextEdit.Size = new System.Drawing.Size(100, 20);
            this.acbankTextEdit.TabIndex = 121;
            // 
            // bgdateDateEdit
            // 
            this.bgdateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tlkBindingSource, "bgdate", true));
            this.bgdateDateEdit.EditValue = null;
            this.bgdateDateEdit.Location = new System.Drawing.Point(119, 150);
            this.bgdateDateEdit.Name = "bgdateDateEdit";
            this.bgdateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bgdateDateEdit.Size = new System.Drawing.Size(100, 20);
            this.bgdateDateEdit.TabIndex = 122;
            // 
            // bgduedateDateEdit
            // 
            this.bgduedateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tlkBindingSource, "bgduedate", true));
            this.bgduedateDateEdit.EditValue = null;
            this.bgduedateDateEdit.Location = new System.Drawing.Point(119, 176);
            this.bgduedateDateEdit.Name = "bgduedateDateEdit";
            this.bgduedateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bgduedateDateEdit.Size = new System.Drawing.Size(100, 20);
            this.bgduedateDateEdit.TabIndex = 123;
            // 
            // bgvalSpinEdit
            // 
            this.bgvalSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tlkBindingSource, "bgval", true));
            this.bgvalSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.bgvalSpinEdit.Location = new System.Drawing.Point(119, 202);
            this.bgvalSpinEdit.Name = "bgvalSpinEdit";
            this.bgvalSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bgvalSpinEdit.Properties.UseCtrlIncrement = false;
            this.bgvalSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.bgvalSpinEdit.TabIndex = 124;
            // 
            // subTextBoxEx
            // 
            this.subTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tlkBindingSource, "sub", true));
            this.subTextBoxEx.ExAllowEmptyString = true;
            this.subTextBoxEx.ExAllowNonDBData = false;
            this.subTextBoxEx.ExAutoCheck = true;
            this.subTextBoxEx.ExAutoShowResult = false;
            this.subTextBoxEx.ExCondition = "";
            this.subTextBoxEx.ExDialogTitle = "";
            this.subTextBoxEx.ExFieldName = "sub";
            this.subTextBoxEx.ExFilterFields = new string[0];
            this.subTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.subTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.subTextBoxEx.ExLabelContainer = null;
            this.subTextBoxEx.ExLabelField = "name";
            this.subTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.subTextBoxEx.ExLabelVisible = true;
            this.subTextBoxEx.ExSelectFields = new string[0];
            this.subTextBoxEx.ExShowDialog = true;
            this.subTextBoxEx.ExSimpleMode = true;
            this.subTextBoxEx.ExSqlInstance = null;
            this.subTextBoxEx.ExSqlQuery = "select * from sub";
            this.subTextBoxEx.ExTableName = "sub";
            this.subTextBoxEx.Location = new System.Drawing.Point(119, 228);
            this.subTextBoxEx.Name = "subTextBoxEx";
            this.subTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.subTextBoxEx.Size = new System.Drawing.Size(100, 20);
            this.subTextBoxEx.TabIndex = 125;
            // 
            // accbankTextBoxEx
            // 
            this.accbankTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tlkBindingSource, "accbank", true));
            this.accbankTextBoxEx.ExAllowEmptyString = true;
            this.accbankTextBoxEx.ExAllowNonDBData = false;
            this.accbankTextBoxEx.ExAutoCheck = true;
            this.accbankTextBoxEx.ExAutoShowResult = false;
            this.accbankTextBoxEx.ExCondition = "";
            this.accbankTextBoxEx.ExDialogTitle = "";
            this.accbankTextBoxEx.ExFieldName = "acc";
            this.accbankTextBoxEx.ExFilterFields = new string[0];
            this.accbankTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.accbankTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.accbankTextBoxEx.ExLabelContainer = null;
            this.accbankTextBoxEx.ExLabelField = "name";
            this.accbankTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.accbankTextBoxEx.ExLabelVisible = true;
            this.accbankTextBoxEx.ExSelectFields = new string[0];
            this.accbankTextBoxEx.ExShowDialog = true;
            this.accbankTextBoxEx.ExSimpleMode = false;
            this.accbankTextBoxEx.ExSqlInstance = null;
            this.accbankTextBoxEx.ExSqlQuery = "select * from acc";
            this.accbankTextBoxEx.ExTableName = "acc";
            this.accbankTextBoxEx.Location = new System.Drawing.Point(119, 254);
            this.accbankTextBoxEx.Name = "accbankTextBoxEx";
            this.accbankTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.accbankTextBoxEx.Size = new System.Drawing.Size(100, 20);
            this.accbankTextBoxEx.TabIndex = 126;
            // 
            // accTextBoxEx
            // 
            this.accTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tlkBindingSource, "acc", true));
            this.accTextBoxEx.ExAllowEmptyString = true;
            this.accTextBoxEx.ExAllowNonDBData = false;
            this.accTextBoxEx.ExAutoCheck = true;
            this.accTextBoxEx.ExAutoShowResult = false;
            this.accTextBoxEx.ExCondition = "";
            this.accTextBoxEx.ExDialogTitle = "";
            this.accTextBoxEx.ExFieldName = "acc";
            this.accTextBoxEx.ExFilterFields = new string[0];
            this.accTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.accTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.accTextBoxEx.ExLabelContainer = null;
            this.accTextBoxEx.ExLabelField = "name";
            this.accTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.accTextBoxEx.ExLabelVisible = true;
            this.accTextBoxEx.ExSelectFields = new string[0];
            this.accTextBoxEx.ExShowDialog = true;
            this.accTextBoxEx.ExSimpleMode = false;
            this.accTextBoxEx.ExSqlInstance = null;
            this.accTextBoxEx.ExSqlQuery = "select * from acc";
            this.accTextBoxEx.ExTableName = "acc";
            this.accTextBoxEx.Location = new System.Drawing.Point(119, 280);
            this.accTextBoxEx.Name = "accTextBoxEx";
            this.accTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.accTextBoxEx.Size = new System.Drawing.Size(100, 20);
            this.accTextBoxEx.TabIndex = 127;
            // 
            // remarkMemoEdit
            // 
            this.remarkMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tlkBindingSource, "remark", true));
            this.remarkMemoEdit.Location = new System.Drawing.Point(119, 306);
            this.remarkMemoEdit.Name = "remarkMemoEdit";
            this.remarkMemoEdit.Size = new System.Drawing.Size(225, 53);
            this.remarkMemoEdit.TabIndex = 128;
            // 
            // FrmTTlk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 511);
            this.MasterBindingSource = this.tlkBindingSource;
            this.MasterQuery = "select * from tlk";
            this.MasterTable = this.casDataSet.tlk;
            this.Name = "FrmTTlk";
            this.Text = "Tolakan Giro";
            this.Load += new System.EventHandler(this.FrmTTlk_Load);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.pnlKey.ResumeLayout(false);
            this.pnlKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludSeri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenisRadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nobgTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acbankTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgdateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgduedateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgvalSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accbankTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected DevExpress.XtraEditors.TextEdit txtPeriod;
        protected DevExpress.XtraEditors.TextEdit txtNo;
        protected DevExpress.XtraEditors.LookUpEdit ludSeri;
        protected System.Windows.Forms.Label label1;
        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource tlkBindingSource;
        private CAS.casDataSetTableAdapters.tlkTableAdapter tlkTableAdapter;
        private DevExpress.XtraEditors.DateEdit dateDateEdit;
        private DevExpress.XtraEditors.RadioGroup jenisRadioGroup;
        private DevExpress.XtraEditors.MemoEdit remarkMemoEdit;
        private KASLibrary.TextBoxEx accTextBoxEx;
        private KASLibrary.TextBoxEx accbankTextBoxEx;
        private KASLibrary.TextBoxEx subTextBoxEx;
        private DevExpress.XtraEditors.SpinEdit bgvalSpinEdit;
        private DevExpress.XtraEditors.DateEdit bgduedateDateEdit;
        private DevExpress.XtraEditors.DateEdit bgdateDateEdit;
        private DevExpress.XtraEditors.TextEdit acbankTextEdit;
        private DevExpress.XtraEditors.TextEdit bankTextEdit;
        private KASLibrary.TextBoxEx nobgTextBoxEx;
    }
}