namespace CAS.Transaction
{
    partial class FrmTCGr
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
            System.Windows.Forms.Label accLabel;
            System.Windows.Forms.Label accbankLabel;
            System.Windows.Forms.Label subLabel;
            System.Windows.Forms.Label bgvalLabel;
            System.Windows.Forms.Label bgduedateLabel;
            System.Windows.Forms.Label bgdateLabel;
            System.Windows.Forms.Label acbankLabel;
            System.Windows.Forms.Label bankLabel;
            System.Windows.Forms.Label nobgLabel;
            System.Windows.Forms.Label jenisLabel;
            System.Windows.Forms.Label dateLabel;
            this.remarkMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.cgrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casDataSet = new CAS.casDataSet();
            this.accTextBoxEx = new KASLibrary.TextBoxEx();
            this.accbankTextBoxEx = new KASLibrary.TextBoxEx();
            this.subTextBoxEx = new KASLibrary.TextBoxEx();
            this.bgvalSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.bgduedateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.bgdateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.acbankTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.bankTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nobgTextBoxEx = new KASLibrary.TextBoxEx();
            this.jenisRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.dateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.txtPeriod = new DevExpress.XtraEditors.TextEdit();
            this.txtNo = new DevExpress.XtraEditors.TextEdit();
            this.ludSeri = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.cgrTableAdapter = new CAS.casDataSetTableAdapters.cgrTableAdapter();
            remarkLabel = new System.Windows.Forms.Label();
            accLabel = new System.Windows.Forms.Label();
            accbankLabel = new System.Windows.Forms.Label();
            subLabel = new System.Windows.Forms.Label();
            bgvalLabel = new System.Windows.Forms.Label();
            bgduedateLabel = new System.Windows.Forms.Label();
            bgdateLabel = new System.Windows.Forms.Label();
            acbankLabel = new System.Windows.Forms.Label();
            bankLabel = new System.Windows.Forms.Label();
            nobgLabel = new System.Windows.Forms.Label();
            jenisLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cgrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accbankTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgvalSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgduedateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgdateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acbankTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nobgTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenisRadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludSeri.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(remarkLabel);
            this.pnlDetail.Controls.Add(this.remarkMemoEdit);
            this.pnlDetail.Controls.Add(this.dateDateEdit);
            this.pnlDetail.Controls.Add(accLabel);
            this.pnlDetail.Controls.Add(dateLabel);
            this.pnlDetail.Controls.Add(this.accTextBoxEx);
            this.pnlDetail.Controls.Add(this.jenisRadioGroup);
            this.pnlDetail.Controls.Add(accbankLabel);
            this.pnlDetail.Controls.Add(jenisLabel);
            this.pnlDetail.Controls.Add(this.accbankTextBoxEx);
            this.pnlDetail.Controls.Add(this.nobgTextBoxEx);
            this.pnlDetail.Controls.Add(subLabel);
            this.pnlDetail.Controls.Add(nobgLabel);
            this.pnlDetail.Controls.Add(this.subTextBoxEx);
            this.pnlDetail.Controls.Add(this.bankTextEdit);
            this.pnlDetail.Controls.Add(bgvalLabel);
            this.pnlDetail.Controls.Add(bankLabel);
            this.pnlDetail.Controls.Add(this.bgvalSpinEdit);
            this.pnlDetail.Controls.Add(this.acbankTextEdit);
            this.pnlDetail.Controls.Add(bgduedateLabel);
            this.pnlDetail.Controls.Add(acbankLabel);
            this.pnlDetail.Controls.Add(this.bgduedateDateEdit);
            this.pnlDetail.Controls.Add(this.bgdateDateEdit);
            this.pnlDetail.Controls.Add(bgdateLabel);
            this.pnlDetail.Size = new System.Drawing.Size(578, 363);
            // 
            // pnlKey
            // 
            this.pnlKey.Controls.Add(this.txtPeriod);
            this.pnlKey.Controls.Add(this.txtNo);
            this.pnlKey.Controls.Add(this.label1);
            this.pnlKey.Controls.Add(this.ludSeri);
            this.pnlKey.Size = new System.Drawing.Size(578, 56);
            // 
            // pnlChInfo
            // 
            this.pnlChInfo.Location = new System.Drawing.Point(0, 444);
            this.pnlChInfo.Size = new System.Drawing.Size(578, 45);
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(66, 306);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(70, 13);
            remarkLabel.TabIndex = 150;
            remarkLabel.Text = "Keterangan :";
            // 
            // accLabel
            // 
            accLabel.AutoSize = true;
            accLabel.Location = new System.Drawing.Point(56, 281);
            accLabel.Name = "accLabel";
            accLabel.Size = new System.Drawing.Size(81, 13);
            accLabel.TabIndex = 148;
            accLabel.Text = "Perkiraan Giro :";
            // 
            // accbankLabel
            // 
            accbankLabel.AutoSize = true;
            accbankLabel.Location = new System.Drawing.Point(50, 255);
            accbankLabel.Name = "accbankLabel";
            accbankLabel.Size = new System.Drawing.Size(85, 13);
            accbankLabel.TabIndex = 146;
            accbankLabel.Text = "Perkiraan Bank :";
            // 
            // subLabel
            // 
            subLabel.AutoSize = true;
            subLabel.Location = new System.Drawing.Point(72, 229);
            subLabel.Name = "subLabel";
            subLabel.Size = new System.Drawing.Size(64, 13);
            subLabel.TabIndex = 144;
            subLabel.Text = "Cust / Sup :";
            // 
            // bgvalLabel
            // 
            bgvalLabel.AutoSize = true;
            bgvalLabel.Location = new System.Drawing.Point(103, 203);
            bgvalLabel.Name = "bgvalLabel";
            bgvalLabel.Size = new System.Drawing.Size(33, 13);
            bgvalLabel.TabIndex = 142;
            bgvalLabel.Text = "Nilai :";
            // 
            // bgduedateLabel
            // 
            bgduedateLabel.AutoSize = true;
            bgduedateLabel.Location = new System.Drawing.Point(62, 177);
            bgduedateLabel.Name = "bgduedateLabel";
            bgduedateLabel.Size = new System.Drawing.Size(72, 13);
            bgduedateLabel.TabIndex = 140;
            bgduedateLabel.Text = "Tanggal JTP :";
            // 
            // bgdateLabel
            // 
            bgdateLabel.AutoSize = true;
            bgdateLabel.Location = new System.Drawing.Point(62, 151);
            bgdateLabel.Name = "bgdateLabel";
            bgdateLabel.Size = new System.Drawing.Size(74, 13);
            bgdateLabel.TabIndex = 138;
            bgdateLabel.Text = "Tanggal Giro :";
            // 
            // acbankLabel
            // 
            acbankLabel.AutoSize = true;
            acbankLabel.Location = new System.Drawing.Point(90, 125);
            acbankLabel.Name = "acbankLabel";
            acbankLabel.Size = new System.Drawing.Size(44, 13);
            acbankLabel.TabIndex = 136;
            acbankLabel.Text = "No AC :";
            // 
            // bankLabel
            // 
            bankLabel.AutoSize = true;
            bankLabel.Location = new System.Drawing.Point(96, 99);
            bankLabel.Name = "bankLabel";
            bankLabel.Size = new System.Drawing.Size(37, 13);
            bankLabel.TabIndex = 134;
            bankLabel.Text = "Bank :";
            // 
            // nobgLabel
            // 
            nobgLabel.AutoSize = true;
            nobgLabel.Location = new System.Drawing.Point(89, 73);
            nobgLabel.Name = "nobgLabel";
            nobgLabel.Size = new System.Drawing.Size(43, 13);
            nobgLabel.TabIndex = 132;
            nobgLabel.Text = "No BG :";
            // 
            // jenisLabel
            // 
            jenisLabel.AutoSize = true;
            jenisLabel.Location = new System.Drawing.Point(75, 44);
            jenisLabel.Name = "jenisLabel";
            jenisLabel.Size = new System.Drawing.Size(60, 13);
            jenisLabel.TabIndex = 133;
            jenisLabel.Text = "Jenis Giro :";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(82, 17);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(52, 13);
            dateLabel.TabIndex = 129;
            dateLabel.Text = "Tanggal :";
            // 
            // remarkMemoEdit
            // 
            this.remarkMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cgrBindingSource, "remark", true));
            this.remarkMemoEdit.Location = new System.Drawing.Point(142, 304);
            this.remarkMemoEdit.Name = "remarkMemoEdit";
            this.remarkMemoEdit.Size = new System.Drawing.Size(225, 53);
            this.remarkMemoEdit.TabIndex = 152;
            // 
            // cgrBindingSource
            // 
            this.cgrBindingSource.DataMember = "cgr";
            this.cgrBindingSource.DataSource = this.casDataSet;
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accTextBoxEx
            // 
            this.accTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cgrBindingSource, "acc", true));
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
            this.accTextBoxEx.ExLabelText = "";
            this.accTextBoxEx.ExLabelVisible = true;
            this.accTextBoxEx.ExSelectFields = new string[0];
            this.accTextBoxEx.ExShowDialog = false;
            this.accTextBoxEx.ExSimpleMode = false;
            this.accTextBoxEx.ExSqlInstance = null;
            this.accTextBoxEx.ExSqlQuery = "select * from acc";
            this.accTextBoxEx.ExTableName = "acc";
            this.accTextBoxEx.Location = new System.Drawing.Point(142, 278);
            this.accTextBoxEx.Name = "accTextBoxEx";
            this.accTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.accTextBoxEx.Size = new System.Drawing.Size(100, 20);
            this.accTextBoxEx.TabIndex = 151;
            // 
            // accbankTextBoxEx
            // 
            this.accbankTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cgrBindingSource, "accbank", true));
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
            this.accbankTextBoxEx.ExLabelText = "";
            this.accbankTextBoxEx.ExLabelVisible = true;
            this.accbankTextBoxEx.ExSelectFields = new string[0];
            this.accbankTextBoxEx.ExShowDialog = false;
            this.accbankTextBoxEx.ExSimpleMode = false;
            this.accbankTextBoxEx.ExSqlInstance = null;
            this.accbankTextBoxEx.ExSqlQuery = "select * from acc";
            this.accbankTextBoxEx.ExTableName = "acc";
            this.accbankTextBoxEx.Location = new System.Drawing.Point(142, 252);
            this.accbankTextBoxEx.Name = "accbankTextBoxEx";
            this.accbankTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.accbankTextBoxEx.Size = new System.Drawing.Size(100, 20);
            this.accbankTextBoxEx.TabIndex = 149;
            // 
            // subTextBoxEx
            // 
            this.subTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cgrBindingSource, "sub", true));
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
            this.subTextBoxEx.ExLabelText = "";
            this.subTextBoxEx.ExLabelVisible = true;
            this.subTextBoxEx.ExSelectFields = new string[0];
            this.subTextBoxEx.ExShowDialog = false;
            this.subTextBoxEx.ExSimpleMode = true;
            this.subTextBoxEx.ExSqlInstance = null;
            this.subTextBoxEx.ExSqlQuery = "select * from sub";
            this.subTextBoxEx.ExTableName = "sub";
            this.subTextBoxEx.Location = new System.Drawing.Point(142, 226);
            this.subTextBoxEx.Name = "subTextBoxEx";
            this.subTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.subTextBoxEx.Size = new System.Drawing.Size(100, 20);
            this.subTextBoxEx.TabIndex = 147;
            // 
            // bgvalSpinEdit
            // 
            this.bgvalSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cgrBindingSource, "bgval", true));
            this.bgvalSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.bgvalSpinEdit.Location = new System.Drawing.Point(142, 200);
            this.bgvalSpinEdit.Name = "bgvalSpinEdit";
            this.bgvalSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bgvalSpinEdit.Properties.UseCtrlIncrement = false;
            this.bgvalSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.bgvalSpinEdit.TabIndex = 145;
            // 
            // bgduedateDateEdit
            // 
            this.bgduedateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cgrBindingSource, "bgduedate", true));
            this.bgduedateDateEdit.EditValue = null;
            this.bgduedateDateEdit.Location = new System.Drawing.Point(142, 174);
            this.bgduedateDateEdit.Name = "bgduedateDateEdit";
            this.bgduedateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bgduedateDateEdit.Size = new System.Drawing.Size(100, 23);
            this.bgduedateDateEdit.TabIndex = 143;
            // 
            // bgdateDateEdit
            // 
            this.bgdateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cgrBindingSource, "bgdate", true));
            this.bgdateDateEdit.EditValue = null;
            this.bgdateDateEdit.Location = new System.Drawing.Point(142, 148);
            this.bgdateDateEdit.Name = "bgdateDateEdit";
            this.bgdateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bgdateDateEdit.Size = new System.Drawing.Size(100, 23);
            this.bgdateDateEdit.TabIndex = 141;
            // 
            // acbankTextEdit
            // 
            this.acbankTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cgrBindingSource, "acbank", true));
            this.acbankTextEdit.Location = new System.Drawing.Point(142, 122);
            this.acbankTextEdit.Name = "acbankTextEdit";
            this.acbankTextEdit.Size = new System.Drawing.Size(100, 20);
            this.acbankTextEdit.TabIndex = 139;
            // 
            // bankTextEdit
            // 
            this.bankTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cgrBindingSource, "bank", true));
            this.bankTextEdit.Location = new System.Drawing.Point(142, 96);
            this.bankTextEdit.Name = "bankTextEdit";
            this.bankTextEdit.Size = new System.Drawing.Size(100, 20);
            this.bankTextEdit.TabIndex = 137;
            // 
            // nobgTextBoxEx
            // 
            this.nobgTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cgrBindingSource, "nobg", true));
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
            this.nobgTextBoxEx.ExLabelText = "";
            this.nobgTextBoxEx.ExLabelVisible = false;
            this.nobgTextBoxEx.ExSelectFields = new string[0];
            this.nobgTextBoxEx.ExShowDialog = true;
            this.nobgTextBoxEx.ExSimpleMode = false;
            this.nobgTextBoxEx.ExSqlInstance = null;
            this.nobgTextBoxEx.ExSqlQuery = "";
            this.nobgTextBoxEx.ExTableName = "cgr";
            this.nobgTextBoxEx.Location = new System.Drawing.Point(142, 70);
            this.nobgTextBoxEx.Name = "nobgTextBoxEx";
            this.nobgTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.nobgTextBoxEx.Size = new System.Drawing.Size(100, 20);
            this.nobgTextBoxEx.TabIndex = 135;
            this.nobgTextBoxEx.EditValueChanged += new System.EventHandler(this.nobgTextBoxEx_EditValueChanged);
            this.nobgTextBoxEx.Enter += new System.EventHandler(this.nobgTextBoxEx_Enter);
            // 
            // jenisRadioGroup
            // 
            this.jenisRadioGroup.EditValue = 1;
            this.jenisRadioGroup.Location = new System.Drawing.Point(142, 40);
            this.jenisRadioGroup.Name = "jenisRadioGroup";
            this.jenisRadioGroup.Properties.Columns = 2;
            this.jenisRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Giro Masuk"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Giro Keluar")});
            this.jenisRadioGroup.Size = new System.Drawing.Size(197, 24);
            this.jenisRadioGroup.TabIndex = 131;
            // 
            // dateDateEdit
            // 
            this.dateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cgrBindingSource, "date", true));
            this.dateDateEdit.EditValue = null;
            this.dateDateEdit.Location = new System.Drawing.Point(142, 14);
            this.dateDateEdit.Name = "dateDateEdit";
            this.dateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDateEdit.Size = new System.Drawing.Size(100, 23);
            this.dateDateEdit.TabIndex = 130;
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(219, 18);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Properties.ReadOnly = true;
            this.txtPeriod.Size = new System.Drawing.Size(43, 20);
            this.txtPeriod.TabIndex = 14;
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(268, 18);
            this.txtNo.Name = "txtNo";
            this.txtNo.Properties.ReadOnly = true;
            this.txtNo.Size = new System.Drawing.Size(85, 20);
            this.txtNo.TabIndex = 15;
            this.txtNo.EditValueChanged += new System.EventHandler(this.txtNo_EditValueChanged);
            // 
            // ludSeri
            // 
            this.ludSeri.Location = new System.Drawing.Point(142, 18);
            this.ludSeri.Name = "ludSeri";
            this.ludSeri.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ludSeri.Properties.NullText = "???";
            this.ludSeri.Size = new System.Drawing.Size(71, 23);
            this.ludSeri.TabIndex = 13;
            this.ludSeri.EditValueChanged += new System.EventHandler(this.ludSeri_EditValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nomer";
            // 
            // cgrTableAdapter
            // 
            this.cgrTableAdapter.ClearBeforeFill = true;
            // 
            // FrmTCGr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 511);
            this.MasterBindingSource = this.cgrBindingSource;
            this.MasterQuery = "select * from cgr ";
            this.MasterTable = this.casDataSet.cgr;
            this.Name = "FrmTCGr";
            this.Text = "Pencairan Giro";
            this.Load += new System.EventHandler(this.FrmTCGr_Load);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.pnlKey.ResumeLayout(false);
            this.pnlKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cgrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accbankTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgvalSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgduedateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgdateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acbankTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nobgTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenisRadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludSeri.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private DevExpress.XtraEditors.RadioGroup jenisRadioGroup;
        private DevExpress.XtraEditors.DateEdit dateDateEdit;
        protected DevExpress.XtraEditors.TextEdit txtPeriod;
        protected DevExpress.XtraEditors.TextEdit txtNo;
        protected System.Windows.Forms.Label label1;
        protected DevExpress.XtraEditors.LookUpEdit ludSeri;
        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource cgrBindingSource;
        private CAS.casDataSetTableAdapters.cgrTableAdapter cgrTableAdapter;
    }
}