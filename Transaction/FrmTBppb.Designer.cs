namespace CAS.Transaction
{
    partial class FrmTBppb
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
            System.Windows.Forms.Label locLabel;
            System.Windows.Forms.Label cctLabel;
            System.Windows.Forms.Label remarkLabel;
            System.Windows.Forms.Label sperpartLabel;
            System.Windows.Forms.Label kodeLabel;
            System.Windows.Forms.Label accLabel;
            System.Windows.Forms.Label group_Label;
            System.Windows.Forms.Label plantLabel;
            System.Windows.Forms.Label bsaLabel;
            this.locTextBoxEx = new KASLibrary.TextBoxEx();
            this.jinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casDataSet = new CAS.casDataSet();
            this.cctTextBoxEx = new KASLibrary.TextBoxEx();
            this.remarkTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.jinTableAdapter = new CAS.casDataSetTableAdapters.jinTableAdapter();
            this.jidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jidTableAdapter = new CAS.casDataSetTableAdapters.jidTableAdapter();
            this.gcjin = new KASLibrary.GridControlEx();
            this.sperpartCheckBox = new System.Windows.Forms.CheckBox();
            this.group_TextBoxEx = new KASLibrary.TextBoxEx();
            this.kodeTextBoxEx = new KASLibrary.TextBoxEx();
            this.txtKodeAccount = new KASLibrary.TextBoxEx();
            this.plantComboBox = new System.Windows.Forms.ComboBox();
            this.bsaTextBoxEx = new KASLibrary.TextBoxEx();
            locLabel = new System.Windows.Forms.Label();
            cctLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            sperpartLabel = new System.Windows.Forms.Label();
            kodeLabel = new System.Windows.Forms.Label();
            accLabel = new System.Windows.Forms.Label();
            group_Label = new System.Windows.Forms.Label();
            plantLabel = new System.Windows.Forms.Label();
            bsaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludSeri.Properties)).BeginInit();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curkurs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curcur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cctTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jidBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.group_TextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kodeTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKodeAccount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsaTextBoxEx.Properties)).BeginInit();
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
            this.pnlDetail.Controls.Add(bsaLabel);
            this.pnlDetail.Controls.Add(this.bsaTextBoxEx);
            this.pnlDetail.Controls.Add(plantLabel);
            this.pnlDetail.Controls.Add(this.plantComboBox);
            this.pnlDetail.Controls.Add(this.txtKodeAccount);
            this.pnlDetail.Controls.Add(this.sperpartCheckBox);
            this.pnlDetail.Controls.Add(this.kodeTextBoxEx);
            this.pnlDetail.Controls.Add(group_Label);
            this.pnlDetail.Controls.Add(this.group_TextBoxEx);
            this.pnlDetail.Controls.Add(accLabel);
            this.pnlDetail.Controls.Add(kodeLabel);
            this.pnlDetail.Controls.Add(sperpartLabel);
            this.pnlDetail.Controls.Add(this.gcjin);
            this.pnlDetail.Controls.Add(locLabel);
            this.pnlDetail.Controls.Add(this.locTextBoxEx);
            this.pnlDetail.Controls.Add(cctLabel);
            this.pnlDetail.Controls.Add(this.cctTextBoxEx);
            this.pnlDetail.Controls.Add(remarkLabel);
            this.pnlDetail.Controls.Add(this.remarkTextEdit);
            this.pnlDetail.Size = new System.Drawing.Size(739, 410);
            this.pnlDetail.Controls.SetChildIndex(this.dateDate, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curcur, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curkurs, 0);
            this.pnlDetail.Controls.SetChildIndex(this.kursLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curLabel1, 0);
            this.pnlDetail.Controls.SetChildIndex(this.remarkTextEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(remarkLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.cctTextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(cctLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.locTextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(locLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.gcjin, 0);
            this.pnlDetail.Controls.SetChildIndex(sperpartLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(kodeLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(accLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.group_TextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(group_Label, 0);
            this.pnlDetail.Controls.SetChildIndex(this.kodeTextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(this.sperpartCheckBox, 0);
            this.pnlDetail.Controls.SetChildIndex(this.txtKodeAccount, 0);
            this.pnlDetail.Controls.SetChildIndex(this.plantComboBox, 0);
            this.pnlDetail.Controls.SetChildIndex(plantLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.bsaTextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(bsaLabel, 0);
            // 
            // pnlKey
            // 
            this.pnlKey.Size = new System.Drawing.Size(739, 50);
            // 
            // dateDate
            // 
            this.dateDate.EditValue = new System.DateTime(((long)(0)));
            this.dateDate.Location = new System.Drawing.Point(466, 4);
            this.dateDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.dateDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateDate.Properties.Mask.EditMask = "dd/MM/yyyy HH:mm:ss";
            this.dateDate.Properties.Mask.IgnoreMaskBlank = false;
            this.dateDate.Size = new System.Drawing.Size(135, 26);
            // 
            // dateLabel
            // 
            this.dateLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dateLabel.Location = new System.Drawing.Point(411, 8);
            // 
            // curkurs
            // 
            this.curkurs.Location = new System.Drawing.Point(642, 132);
            this.curkurs.Visible = false;
            // 
            // curcur
            // 
            this.curcur.Location = new System.Drawing.Point(543, 132);
            this.curcur.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.curcur.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.curcur.Properties.Appearance.Options.UseBackColor = true;
            this.curcur.Properties.Appearance.Options.UseForeColor = true;
            this.curcur.Size = new System.Drawing.Size(57, 26);
            this.curcur.Visible = false;
            // 
            // curLabel1
            // 
            this.curLabel1.Location = new System.Drawing.Point(512, 135);
            this.curLabel1.Visible = false;
            // 
            // kursLabel
            // 
            this.kursLabel.Location = new System.Drawing.Point(606, 135);
            this.kursLabel.Visible = false;
            // 
            // btnDocFlow
            // 
            this.btnDocFlow.Visible = true;
            // 
            // locLabel
            // 
            locLabel.AutoSize = true;
            locLabel.Location = new System.Drawing.Point(62, 57);
            locLabel.Name = "locLabel";
            locLabel.Size = new System.Drawing.Size(64, 19);
            locLabel.TabIndex = 41;
            locLabel.Text = "Gudang";
            // 
            // cctLabel
            // 
            cctLabel.AutoSize = true;
            cctLabel.Location = new System.Drawing.Point(41, 32);
            cctLabel.Name = "cctLabel";
            cctLabel.Size = new System.Drawing.Size(91, 19);
            cctLabel.TabIndex = 38;
            cctLabel.Text = "Cost Center";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(43, 129);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(88, 19);
            remarkLabel.TabIndex = 37;
            remarkLabel.Text = "Keterangan";
            // 
            // sperpartLabel
            // 
            sperpartLabel.AutoSize = true;
            sperpartLabel.Location = new System.Drawing.Point(387, 36);
            sperpartLabel.Name = "sperpartLabel";
            sperpartLabel.Size = new System.Drawing.Size(104, 19);
            sperpartLabel.TabIndex = 43;
            sperpartLabel.Text = "Non Produksi";
            // 
            // kodeLabel
            // 
            kodeLabel.AutoSize = true;
            kodeLabel.Location = new System.Drawing.Point(27, 81);
            kodeLabel.Name = "kodeLabel";
            kodeLabel.Size = new System.Drawing.Size(116, 19);
            kodeLabel.TabIndex = 45;
            kodeLabel.Text = "Kode Transaksi";
            // 
            // accLabel
            // 
            accLabel.AutoSize = true;
            accLabel.Location = new System.Drawing.Point(33, 105);
            accLabel.Name = "accLabel";
            accLabel.Size = new System.Drawing.Size(106, 19);
            accLabel.TabIndex = 46;
            accLabel.Text = "Kode Account";
            // 
            // group_Label
            // 
            group_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            group_Label.AutoSize = true;
            group_Label.Location = new System.Drawing.Point(529, 84);
            group_Label.Name = "group_Label";
            group_Label.Size = new System.Drawing.Size(104, 19);
            group_Label.TabIndex = 47;
            group_Label.Text = "Jenis Material";
            group_Label.Visible = false;
            // 
            // plantLabel
            // 
            plantLabel.AutoSize = true;
            plantLabel.Location = new System.Drawing.Point(426, 62);
            plantLabel.Name = "plantLabel";
            plantLabel.Size = new System.Drawing.Size(44, 19);
            plantLabel.TabIndex = 50;
            plantLabel.Text = "Plant";
            // 
            // bsaLabel
            // 
            bsaLabel.AutoSize = true;
            bsaLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            bsaLabel.ForeColor = System.Drawing.Color.Red;
            bsaLabel.Location = new System.Drawing.Point(37, 6);
            bsaLabel.Name = "bsaLabel";
            bsaLabel.Size = new System.Drawing.Size(105, 21);
            bsaLabel.TabIndex = 139;
            bsaLabel.Text = "Bisnis Area";
            // 
            // locTextBoxEx
            // 
            this.locTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jinBindingSource, "loc", true));
            this.locTextBoxEx.ExAllowEmptyString = true;
            this.locTextBoxEx.ExAllowNonDBData = false;
            this.locTextBoxEx.ExAutoCheck = true;
            this.locTextBoxEx.ExAutoShowResult = false;
            this.locTextBoxEx.ExCondition = "";
            this.locTextBoxEx.ExDialogTitle = "";
            this.locTextBoxEx.ExFieldName = "Loc";
            this.locTextBoxEx.ExFilterFields = new string[0];
            this.locTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.locTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.locTextBoxEx.ExLabelContainer = null;
            this.locTextBoxEx.ExLabelField = "Nama Lokasi";
            this.locTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.locTextBoxEx.ExLabelText = "";
            this.locTextBoxEx.ExLabelVisible = true;
            this.locTextBoxEx.ExSelectFields = new string[0];
            this.locTextBoxEx.ExShowDialog = true;
            this.locTextBoxEx.ExSimpleMode = true;
            this.locTextBoxEx.ExSqlInstance = null;
            this.locTextBoxEx.ExSqlQuery = "Call SP_LookUp(\"loc\")";
            this.locTextBoxEx.ExTableName = "loc";
            this.locTextBoxEx.Location = new System.Drawing.Point(114, 53);
            this.locTextBoxEx.Name = "locTextBoxEx";
            this.locTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.locTextBoxEx.Size = new System.Drawing.Size(100, 26);
            this.locTextBoxEx.TabIndex = 42;
            this.locTextBoxEx.EditValueChanged += new System.EventHandler(this.locTextBoxEx_EditValueChanged);
            // 
            // jinBindingSource
            // 
            this.jinBindingSource.DataMember = "jin";
            this.jinBindingSource.DataSource = this.casDataSet;
            this.jinBindingSource.Filter = "group_=2";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cctTextBoxEx
            // 
            this.cctTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jinBindingSource, "cct", true));
            this.cctTextBoxEx.ExAllowEmptyString = true;
            this.cctTextBoxEx.ExAllowNonDBData = false;
            this.cctTextBoxEx.ExAutoCheck = true;
            this.cctTextBoxEx.ExAutoShowResult = false;
            this.cctTextBoxEx.ExCondition = "";
            this.cctTextBoxEx.ExDialogTitle = "";
            this.cctTextBoxEx.ExFieldName = "Cost Center";
            this.cctTextBoxEx.ExFilterFields = new string[0];
            this.cctTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.cctTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.cctTextBoxEx.ExLabelContainer = null;
            this.cctTextBoxEx.ExLabelField = "Nama";
            this.cctTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.cctTextBoxEx.ExLabelText = "";
            this.cctTextBoxEx.ExLabelVisible = true;
            this.cctTextBoxEx.ExSelectFields = new string[0];
            this.cctTextBoxEx.ExShowDialog = true;
            this.cctTextBoxEx.ExSimpleMode = true;
            this.cctTextBoxEx.ExSqlInstance = null;
            this.cctTextBoxEx.ExSqlQuery = "Call SP_LookUp(\'cct\')";
            this.cctTextBoxEx.ExTableName = "cct";
            this.cctTextBoxEx.Location = new System.Drawing.Point(114, 28);
            this.cctTextBoxEx.Name = "cctTextBoxEx";
            this.cctTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.cctTextBoxEx.Size = new System.Drawing.Size(100, 26);
            this.cctTextBoxEx.TabIndex = 40;
            this.cctTextBoxEx.EditValueChanged += new System.EventHandler(this.cctTextBoxEx_EditValueChanged);
            // 
            // remarkTextEdit
            // 
            this.remarkTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jinBindingSource, "remark", true));
            this.remarkTextEdit.Location = new System.Drawing.Point(114, 125);
            this.remarkTextEdit.Name = "remarkTextEdit";
            this.remarkTextEdit.Size = new System.Drawing.Size(370, 26);
            this.remarkTextEdit.TabIndex = 39;
            // 
            // jinTableAdapter
            // 
            this.jinTableAdapter.ClearBeforeFill = true;
            // 
            // jidBindingSource
            // 
            this.jidBindingSource.DataMember = "jid";
            this.jidBindingSource.DataSource = this.casDataSet;
            // 
            // jidTableAdapter
            // 
            this.jidTableAdapter.ClearBeforeFill = true;
            // 
            // gcjin
            // 
            this.gcjin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcjin.BestFitColumn = true;
            this.gcjin.ExAutoSize = false;
            this.gcjin.Location = new System.Drawing.Point(23, 158);
            this.gcjin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gcjin.Name = "gcjin";
            this.gcjin.Size = new System.Drawing.Size(695, 219);
            this.gcjin.TabIndex = 43;
            // 
            // sperpartCheckBox
            // 
            this.sperpartCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.jinBindingSource, "sperpart", true));
            this.sperpartCheckBox.Location = new System.Drawing.Point(466, 31);
            this.sperpartCheckBox.Name = "sperpartCheckBox";
            this.sperpartCheckBox.Size = new System.Drawing.Size(35, 24);
            this.sperpartCheckBox.TabIndex = 44;
            this.sperpartCheckBox.CheckedChanged += new System.EventHandler(this.sperpartCheckBox_CheckedChanged);
            // 
            // group_TextBoxEx
            // 
            this.group_TextBoxEx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.group_TextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jinBindingSource, "jenis", true));
            this.group_TextBoxEx.ExAllowEmptyString = true;
            this.group_TextBoxEx.ExAllowNonDBData = false;
            this.group_TextBoxEx.ExAutoCheck = true;
            this.group_TextBoxEx.ExAutoShowResult = false;
            this.group_TextBoxEx.ExCondition = "";
            this.group_TextBoxEx.ExDialogTitle = "";
            this.group_TextBoxEx.ExFieldName = "Jenis";
            this.group_TextBoxEx.ExFilterFields = new string[0];
            this.group_TextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.group_TextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.group_TextBoxEx.ExLabelContainer = null;
            this.group_TextBoxEx.ExLabelField = "Name";
            this.group_TextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.group_TextBoxEx.ExLabelText = "";
            this.group_TextBoxEx.ExLabelVisible = true;
            this.group_TextBoxEx.ExSelectFields = new string[0];
            this.group_TextBoxEx.ExShowDialog = true;
            this.group_TextBoxEx.ExSimpleMode = true;
            this.group_TextBoxEx.ExSqlInstance = null;
            this.group_TextBoxEx.ExSqlQuery = "Select jenis as Jenis, name as Name, remark as Keterangan from jenis";
            this.group_TextBoxEx.ExTableName = "jenis";
            this.group_TextBoxEx.Location = new System.Drawing.Point(609, 81);
            this.group_TextBoxEx.Name = "group_TextBoxEx";
            this.group_TextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.group_TextBoxEx.Size = new System.Drawing.Size(100, 26);
            this.group_TextBoxEx.TabIndex = 48;
            this.group_TextBoxEx.Visible = false;
            this.group_TextBoxEx.EditValueChanged += new System.EventHandler(this.group_TextBoxEx_EditValueChanged);
            // 
            // kodeTextBoxEx
            // 
            this.kodeTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jinBindingSource, "kode", true));
            this.kodeTextBoxEx.ExAllowEmptyString = true;
            this.kodeTextBoxEx.ExAllowNonDBData = false;
            this.kodeTextBoxEx.ExAutoCheck = true;
            this.kodeTextBoxEx.ExAutoShowResult = false;
            this.kodeTextBoxEx.ExCondition = "";
            this.kodeTextBoxEx.ExDialogTitle = "";
            this.kodeTextBoxEx.ExFieldName = "Kode Transaksi";
            this.kodeTextBoxEx.ExFilterFields = new string[0];
            this.kodeTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.kodeTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.kodeTextBoxEx.ExLabelContainer = null;
            this.kodeTextBoxEx.ExLabelField = "Nama";
            this.kodeTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.kodeTextBoxEx.ExLabelText = "";
            this.kodeTextBoxEx.ExLabelVisible = true;
            this.kodeTextBoxEx.ExSelectFields = new string[0];
            this.kodeTextBoxEx.ExShowDialog = true;
            this.kodeTextBoxEx.ExSimpleMode = true;
            this.kodeTextBoxEx.ExSqlInstance = null;
            this.kodeTextBoxEx.ExSqlQuery = "select kode as Kode, name as Name from kode";
            this.kodeTextBoxEx.ExTableName = "kode";
            this.kodeTextBoxEx.Location = new System.Drawing.Point(114, 77);
            this.kodeTextBoxEx.Name = "kodeTextBoxEx";
            this.kodeTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.kodeTextBoxEx.Size = new System.Drawing.Size(100, 26);
            this.kodeTextBoxEx.TabIndex = 49;
            this.kodeTextBoxEx.EditValueChanged += new System.EventHandler(this.kodeTextBoxEx_EditValueChanged);
            // 
            // txtKodeAccount
            // 
            this.txtKodeAccount.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jinBindingSource, "acc", true));
            this.txtKodeAccount.ExAllowEmptyString = true;
            this.txtKodeAccount.ExAllowNonDBData = false;
            this.txtKodeAccount.ExAutoCheck = true;
            this.txtKodeAccount.ExAutoShowResult = false;
            this.txtKodeAccount.ExCondition = "";
            this.txtKodeAccount.ExDialogTitle = "";
            this.txtKodeAccount.ExFieldName = "Kode Akun";
            this.txtKodeAccount.ExFilterFields = new string[0];
            this.txtKodeAccount.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtKodeAccount.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtKodeAccount.ExLabelContainer = null;
            this.txtKodeAccount.ExLabelField = "Keterangan";
            this.txtKodeAccount.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.txtKodeAccount.ExLabelText = "";
            this.txtKodeAccount.ExLabelVisible = true;
            this.txtKodeAccount.ExSelectFields = new string[0];
            this.txtKodeAccount.ExShowDialog = false;
            this.txtKodeAccount.ExSimpleMode = true;
            this.txtKodeAccount.ExSqlInstance = null;
            this.txtKodeAccount.ExSqlQuery = "Call SP_LookUp(\"acc\")";
            this.txtKodeAccount.ExTableName = "kode";
            this.txtKodeAccount.Location = new System.Drawing.Point(114, 101);
            this.txtKodeAccount.Name = "txtKodeAccount";
            this.txtKodeAccount.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtKodeAccount.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtKodeAccount.Properties.Appearance.Options.UseBackColor = true;
            this.txtKodeAccount.Properties.Appearance.Options.UseForeColor = true;
            this.txtKodeAccount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtKodeAccount.Properties.ReadOnly = true;
            this.txtKodeAccount.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtKodeAccount.Size = new System.Drawing.Size(100, 26);
            this.txtKodeAccount.TabIndex = 50;
            // 
            // plantComboBox
            // 
            this.plantComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jinBindingSource, "plant", true));
            this.plantComboBox.FormattingEnabled = true;
            this.plantComboBox.Location = new System.Drawing.Point(466, 59);
            this.plantComboBox.Name = "plantComboBox";
            this.plantComboBox.Size = new System.Drawing.Size(121, 28);
            this.plantComboBox.TabIndex = 51;
            // 
            // bsaTextBoxEx
            // 
            this.bsaTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jinBindingSource, "bsa", true));
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
            this.bsaTextBoxEx.Location = new System.Drawing.Point(114, 3);
            this.bsaTextBoxEx.Name = "bsaTextBoxEx";
            this.bsaTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.bsaTextBoxEx.Size = new System.Drawing.Size(81, 26);
            this.bsaTextBoxEx.TabIndex = 140;
            // 
            // FrmTBppb
            // 
            this.ClientSize = new System.Drawing.Size(739, 555);
            this.DetailBindingSource = this.jidBindingSource;
            this.DetailTable = this.casDataSet.jid;
            this.MasterBindingSource = this.jinBindingSource;
            this.MasterTable = this.casDataSet.jin;
            this.Name = "FrmTBppb";
            this.Text = "Pemakaian Barang";
            this.Load += new System.EventHandler(this.FrmTBppb_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.locTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cctTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jidBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.group_TextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kodeTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKodeAccount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsaTextBoxEx.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KASLibrary.TextBoxEx locTextBoxEx;
        private KASLibrary.TextBoxEx cctTextBoxEx;
        private DevExpress.XtraEditors.TextEdit remarkTextEdit;
        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource jinBindingSource;
        private CAS.casDataSetTableAdapters.jinTableAdapter jinTableAdapter;
        private System.Windows.Forms.BindingSource jidBindingSource;
        private CAS.casDataSetTableAdapters.jidTableAdapter jidTableAdapter;
        private KASLibrary.GridControlEx gcjin;
        private System.Windows.Forms.CheckBox sperpartCheckBox;
        private KASLibrary.TextBoxEx group_TextBoxEx;
        private KASLibrary.TextBoxEx kodeTextBoxEx;
        private KASLibrary.TextBoxEx txtKodeAccount;
        private System.Windows.Forms.ComboBox plantComboBox;
        private KASLibrary.TextBoxEx bsaTextBoxEx;
    }
}
