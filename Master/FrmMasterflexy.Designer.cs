namespace CAS.Master
{
    partial class FrmMasterflexy
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
            System.Windows.Forms.Label invLabel;
            System.Windows.Forms.Label remarkLabel;
            System.Windows.Forms.Label subLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label specLabel;
            System.Windows.Forms.Label fcodeLabel;
            System.Windows.Forms.Label weightLabel;
            System.Windows.Forms.Label procodeLabel;
            System.Windows.Forms.Label prodescLabel;
            System.Windows.Forms.Label widthLabel;
            System.Windows.Forms.Label pitchLabel;
            System.Windows.Forms.Label lengLabel;
            System.Windows.Forms.Label jenisLabel;
            System.Windows.Forms.Label qtyinboxLabel;
            System.Windows.Forms.Label fdescLabel;
            System.Windows.Forms.Label gusseteLabel;
            System.Windows.Forms.Label wnocoreLabel;
            this.casDataSet = new CAS.casDataSet();
            this.mspecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mspecTableAdapter = new CAS.casDataSetTableAdapters.mspecTableAdapter();
            this.invTextBoxEx = new KASLibrary.TextBoxEx();
            this.remarkTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.specTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.fcodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.weightSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.procodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.widthSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.pitchSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.lengSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.jenisTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.subTextBoxEx = new KASLibrary.TextBoxEx();
            this.qtyinboxSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.fdescTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.gusseteSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.wnocoreSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.prodescTextEdit = new DevExpress.XtraEditors.TextEdit();
            invLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            subLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            specLabel = new System.Windows.Forms.Label();
            fcodeLabel = new System.Windows.Forms.Label();
            weightLabel = new System.Windows.Forms.Label();
            procodeLabel = new System.Windows.Forms.Label();
            prodescLabel = new System.Windows.Forms.Label();
            widthLabel = new System.Windows.Forms.Label();
            pitchLabel = new System.Windows.Forms.Label();
            lengLabel = new System.Windows.Forms.Label();
            jenisLabel = new System.Windows.Forms.Label();
            qtyinboxLabel = new System.Windows.Forms.Label();
            fdescLabel = new System.Windows.Forms.Label();
            gusseteLabel = new System.Windows.Forms.Label();
            wnocoreLabel = new System.Windows.Forms.Label();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mspecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fcodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitchSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenisTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyinboxSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fdescTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gusseteSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wnocoreSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodescTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.prodescTextEdit);
            this.pnlDetail.Controls.Add(wnocoreLabel);
            this.pnlDetail.Controls.Add(this.wnocoreSpinEdit);
            this.pnlDetail.Controls.Add(gusseteLabel);
            this.pnlDetail.Controls.Add(this.gusseteSpinEdit);
            this.pnlDetail.Controls.Add(fdescLabel);
            this.pnlDetail.Controls.Add(this.fdescTextEdit);
            this.pnlDetail.Controls.Add(qtyinboxLabel);
            this.pnlDetail.Controls.Add(this.qtyinboxSpinEdit);
            this.pnlDetail.Controls.Add(this.invTextBoxEx);
            this.pnlDetail.Controls.Add(invLabel);
            this.pnlDetail.Controls.Add(this.subTextBoxEx);
            this.pnlDetail.Controls.Add(remarkLabel);
            this.pnlDetail.Controls.Add(this.remarkTextEdit);
            this.pnlDetail.Controls.Add(subLabel);
            this.pnlDetail.Controls.Add(nameLabel);
            this.pnlDetail.Controls.Add(this.nameTextEdit);
            this.pnlDetail.Controls.Add(specLabel);
            this.pnlDetail.Controls.Add(this.specTextEdit);
            this.pnlDetail.Controls.Add(fcodeLabel);
            this.pnlDetail.Controls.Add(this.fcodeTextEdit);
            this.pnlDetail.Controls.Add(weightLabel);
            this.pnlDetail.Controls.Add(this.weightSpinEdit);
            this.pnlDetail.Controls.Add(procodeLabel);
            this.pnlDetail.Controls.Add(this.procodeTextEdit);
            this.pnlDetail.Controls.Add(prodescLabel);
            this.pnlDetail.Controls.Add(widthLabel);
            this.pnlDetail.Controls.Add(this.widthSpinEdit);
            this.pnlDetail.Controls.Add(pitchLabel);
            this.pnlDetail.Controls.Add(this.pitchSpinEdit);
            this.pnlDetail.Controls.Add(lengLabel);
            this.pnlDetail.Controls.Add(this.lengSpinEdit);
            this.pnlDetail.Controls.Add(jenisLabel);
            this.pnlDetail.Controls.Add(this.jenisTextEdit);
            this.pnlDetail.Location = new System.Drawing.Point(0, 53);
            this.pnlDetail.Size = new System.Drawing.Size(524, 550);
            // 
            // pnlKey
            // 
            this.pnlKey.Size = new System.Drawing.Size(524, 28);
            // 
            // pnlChInfo
            // 
            this.pnlChInfo.Location = new System.Drawing.Point(0, 603);
            this.pnlChInfo.Size = new System.Drawing.Size(524, 45);
            // 
            // invLabel
            // 
            invLabel.AutoSize = true;
            invLabel.Location = new System.Drawing.Point(65, 11);
            invLabel.Name = "invLabel";
            invLabel.Size = new System.Drawing.Size(73, 13);
            invLabel.TabIndex = 0;
            invLabel.Text = "Material Code";
            invLabel.Click += new System.EventHandler(this.invLabel_Click);
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(63, 37);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(75, 13);
            remarkLabel.TabIndex = 2;
            remarkLabel.Text = "Material Name";
            // 
            // subLabel
            // 
            subLabel.AutoSize = true;
            subLabel.Location = new System.Drawing.Point(69, 67);
            subLabel.Name = "subLabel";
            subLabel.Size = new System.Drawing.Size(69, 13);
            subLabel.TabIndex = 4;
            subLabel.Text = "Vendor Code";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(67, 89);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(71, 13);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Vendor Name";
            // 
            // specLabel
            // 
            specLabel.AutoSize = true;
            specLabel.Location = new System.Drawing.Point(73, 115);
            specLabel.Name = "specLabel";
            specLabel.Size = new System.Drawing.Size(65, 13);
            specLabel.TabIndex = 8;
            specLabel.Text = "Specificaton";
            // 
            // fcodeLabel
            // 
            fcodeLabel.AutoSize = true;
            fcodeLabel.Location = new System.Drawing.Point(79, 141);
            fcodeLabel.Name = "fcodeLabel";
            fcodeLabel.Size = new System.Drawing.Size(59, 13);
            fcodeLabel.TabIndex = 10;
            fcodeLabel.Text = "Form Code";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new System.Drawing.Point(75, 350);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(63, 13);
            weightLabel.TabIndex = 12;
            weightLabel.Text = "Weight (kg)";
            // 
            // procodeLabel
            // 
            procodeLabel.AutoSize = true;
            procodeLabel.Location = new System.Drawing.Point(46, 194);
            procodeLabel.Name = "procodeLabel";
            procodeLabel.Size = new System.Drawing.Size(92, 13);
            procodeLabel.TabIndex = 14;
            procodeLabel.Text = "Product Cat Code";
            // 
            // prodescLabel
            // 
            prodescLabel.AutoSize = true;
            prodescLabel.Location = new System.Drawing.Point(48, 220);
            prodescLabel.Name = "prodescLabel";
            prodescLabel.Size = new System.Drawing.Size(90, 13);
            prodescLabel.TabIndex = 16;
            prodescLabel.Text = "Product Cat Desc";
            // 
            // widthLabel
            // 
            widthLabel.AutoSize = true;
            widthLabel.Location = new System.Drawing.Point(76, 246);
            widthLabel.Name = "widthLabel";
            widthLabel.Size = new System.Drawing.Size(62, 13);
            widthLabel.TabIndex = 18;
            widthLabel.Text = "Width (mm)";
            // 
            // pitchLabel
            // 
            pitchLabel.AutoSize = true;
            pitchLabel.Location = new System.Drawing.Point(81, 272);
            pitchLabel.Name = "pitchLabel";
            pitchLabel.Size = new System.Drawing.Size(57, 13);
            pitchLabel.TabIndex = 20;
            pitchLabel.Text = "Pitch (mm)";
            // 
            // lengLabel
            // 
            lengLabel.AutoSize = true;
            lengLabel.Location = new System.Drawing.Point(79, 298);
            lengLabel.Name = "lengLabel";
            lengLabel.Size = new System.Drawing.Size(59, 13);
            lengLabel.TabIndex = 22;
            lengLabel.Text = "Lenght (M)";
            // 
            // jenisLabel
            // 
            jenisLabel.AutoSize = true;
            jenisLabel.Location = new System.Drawing.Point(427, 216);
            jenisLabel.Name = "jenisLabel";
            jenisLabel.Size = new System.Drawing.Size(31, 13);
            jenisLabel.TabIndex = 24;
            jenisLabel.Text = "Jenis";
            jenisLabel.Visible = false;
            // 
            // qtyinboxLabel
            // 
            qtyinboxLabel.AutoSize = true;
            qtyinboxLabel.Location = new System.Drawing.Point(82, 402);
            qtyinboxLabel.Name = "qtyinboxLabel";
            qtyinboxLabel.Size = new System.Drawing.Size(56, 13);
            qtyinboxLabel.TabIndex = 26;
            qtyinboxLabel.Text = "Qty Inbox";
            // 
            // fdescLabel
            // 
            fdescLabel.AutoSize = true;
            fdescLabel.Location = new System.Drawing.Point(51, 166);
            fdescLabel.Name = "fdescLabel";
            fdescLabel.Size = new System.Drawing.Size(87, 13);
            fdescLabel.TabIndex = 28;
            fdescLabel.Text = "Form Description";
            // 
            // gusseteLabel
            // 
            gusseteLabel.AutoSize = true;
            gusseteLabel.Location = new System.Drawing.Point(65, 324);
            gusseteLabel.Name = "gusseteLabel";
            gusseteLabel.Size = new System.Drawing.Size(73, 13);
            gusseteLabel.TabIndex = 30;
            gusseteLabel.Text = "Gussete (mm)";
            // 
            // wnocoreLabel
            // 
            wnocoreLabel.AutoSize = true;
            wnocoreLabel.Location = new System.Drawing.Point(33, 376);
            wnocoreLabel.Name = "wnocoreLabel";
            wnocoreLabel.Size = new System.Drawing.Size(105, 13);
            wnocoreLabel.TabIndex = 32;
            wnocoreLabel.Text = "Weight No Core (kg)";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mspecBindingSource
            // 
            this.mspecBindingSource.DataMember = "mspec";
            this.mspecBindingSource.DataSource = this.casDataSet;
            // 
            // mspecTableAdapter
            // 
            this.mspecTableAdapter.ClearBeforeFill = true;
            // 
            // invTextBoxEx
            // 
            this.invTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mspecBindingSource, "inv", true));
            this.invTextBoxEx.ExAllowEmptyString = true;
            this.invTextBoxEx.ExAllowNonDBData = false;
            this.invTextBoxEx.ExAutoCheck = true;
            this.invTextBoxEx.ExAutoShowResult = false;
            this.invTextBoxEx.ExCondition = "";
            this.invTextBoxEx.ExDialogTitle = "";
            this.invTextBoxEx.ExFieldName = "inv";
            this.invTextBoxEx.ExFilterFields = new string[0];
            this.invTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.invTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.invTextBoxEx.ExLabelContainer = null;
            this.invTextBoxEx.ExLabelField = "";
            this.invTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.invTextBoxEx.ExLabelText = "";
            this.invTextBoxEx.ExLabelVisible = false;
            this.invTextBoxEx.ExSelectFields = new string[0];
            this.invTextBoxEx.ExShowDialog = true;
            this.invTextBoxEx.ExSimpleMode = false;
            this.invTextBoxEx.ExSqlInstance = null;
            this.invTextBoxEx.ExSqlQuery = "select inv,name from inv where left(inv,1)<\'5\'";
            this.invTextBoxEx.ExTableName = "inv";
            this.invTextBoxEx.Location = new System.Drawing.Point(154, 8);
            this.invTextBoxEx.Name = "invTextBoxEx";
            this.invTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.invTextBoxEx.Size = new System.Drawing.Size(109, 20);
            this.invTextBoxEx.TabIndex = 1;
            this.invTextBoxEx.EditValueChanged += new System.EventHandler(this.invTextBoxEx_EditValueChanged);
            // 
            // remarkTextEdit
            // 
            this.remarkTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mspecBindingSource, "remark", true));
            this.remarkTextEdit.Location = new System.Drawing.Point(154, 34);
            this.remarkTextEdit.Name = "remarkTextEdit";
            this.remarkTextEdit.Size = new System.Drawing.Size(340, 20);
            this.remarkTextEdit.TabIndex = 3;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mspecBindingSource, "name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(154, 86);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(340, 20);
            this.nameTextEdit.TabIndex = 7;
            // 
            // specTextEdit
            // 
            this.specTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mspecBindingSource, "spec", true));
            this.specTextEdit.Location = new System.Drawing.Point(154, 112);
            this.specTextEdit.Name = "specTextEdit";
            this.specTextEdit.Size = new System.Drawing.Size(233, 20);
            this.specTextEdit.TabIndex = 9;
            // 
            // fcodeTextEdit
            // 
            this.fcodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mspecBindingSource, "fcode", true));
            this.fcodeTextEdit.Location = new System.Drawing.Point(154, 138);
            this.fcodeTextEdit.Name = "fcodeTextEdit";
            this.fcodeTextEdit.Size = new System.Drawing.Size(53, 20);
            this.fcodeTextEdit.TabIndex = 11;
            // 
            // weightSpinEdit
            // 
            this.weightSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mspecBindingSource, "weight", true));
            this.weightSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.weightSpinEdit.Location = new System.Drawing.Point(153, 347);
            this.weightSpinEdit.Name = "weightSpinEdit";
            this.weightSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.weightSpinEdit.Properties.UseCtrlIncrement = false;
            this.weightSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.weightSpinEdit.TabIndex = 13;
            // 
            // procodeTextEdit
            // 
            this.procodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mspecBindingSource, "procode", true));
            this.procodeTextEdit.Location = new System.Drawing.Point(154, 191);
            this.procodeTextEdit.Name = "procodeTextEdit";
            this.procodeTextEdit.Properties.MaxLength = 15;
            this.procodeTextEdit.Size = new System.Drawing.Size(100, 20);
            this.procodeTextEdit.TabIndex = 15;
            // 
            // widthSpinEdit
            // 
            this.widthSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mspecBindingSource, "width", true));
            this.widthSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.widthSpinEdit.Location = new System.Drawing.Point(154, 243);
            this.widthSpinEdit.Name = "widthSpinEdit";
            this.widthSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.widthSpinEdit.Properties.UseCtrlIncrement = false;
            this.widthSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.widthSpinEdit.TabIndex = 19;
            // 
            // pitchSpinEdit
            // 
            this.pitchSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mspecBindingSource, "pitch", true));
            this.pitchSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.pitchSpinEdit.Location = new System.Drawing.Point(154, 269);
            this.pitchSpinEdit.Name = "pitchSpinEdit";
            this.pitchSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.pitchSpinEdit.Properties.UseCtrlIncrement = false;
            this.pitchSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.pitchSpinEdit.TabIndex = 21;
            // 
            // lengSpinEdit
            // 
            this.lengSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mspecBindingSource, "leng", true));
            this.lengSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.lengSpinEdit.Location = new System.Drawing.Point(154, 295);
            this.lengSpinEdit.Name = "lengSpinEdit";
            this.lengSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.lengSpinEdit.Properties.UseCtrlIncrement = false;
            this.lengSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.lengSpinEdit.TabIndex = 23;
            // 
            // jenisTextEdit
            // 
            this.jenisTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mspecBindingSource, "jenis", true));
            this.jenisTextEdit.Location = new System.Drawing.Point(478, 213);
            this.jenisTextEdit.Name = "jenisTextEdit";
            this.jenisTextEdit.Size = new System.Drawing.Size(131, 20);
            this.jenisTextEdit.TabIndex = 25;
            this.jenisTextEdit.Visible = false;
            // 
            // subTextBoxEx
            // 
            this.subTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mspecBindingSource, "sub", true));
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
            this.subTextBoxEx.ExLabelField = "sub";
            this.subTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.subTextBoxEx.ExLabelText = "";
            this.subTextBoxEx.ExLabelVisible = false;
            this.subTextBoxEx.ExSelectFields = new string[0];
            this.subTextBoxEx.ExShowDialog = true;
            this.subTextBoxEx.ExSimpleMode = true;
            this.subTextBoxEx.ExSqlInstance = null;
            this.subTextBoxEx.ExSqlQuery = "select * from sub";
            this.subTextBoxEx.ExTableName = "sub";
            this.subTextBoxEx.Location = new System.Drawing.Point(154, 60);
            this.subTextBoxEx.Name = "subTextBoxEx";
            this.subTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.subTextBoxEx.Size = new System.Drawing.Size(109, 20);
            this.subTextBoxEx.TabIndex = 26;
            this.subTextBoxEx.EditValueChanged += new System.EventHandler(this.subTextBoxEx_EditValueChanged);
            // 
            // qtyinboxSpinEdit
            // 
            this.qtyinboxSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mspecBindingSource, "qtyinbox", true));
            this.qtyinboxSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.qtyinboxSpinEdit.Location = new System.Drawing.Point(153, 399);
            this.qtyinboxSpinEdit.Name = "qtyinboxSpinEdit";
            this.qtyinboxSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.qtyinboxSpinEdit.Properties.UseCtrlIncrement = false;
            this.qtyinboxSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.qtyinboxSpinEdit.TabIndex = 27;
            // 
            // fdescTextEdit
            // 
            this.fdescTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mspecBindingSource, "fdesc", true));
            this.fdescTextEdit.Location = new System.Drawing.Point(153, 163);
            this.fdescTextEdit.Name = "fdescTextEdit";
            this.fdescTextEdit.Size = new System.Drawing.Size(100, 20);
            this.fdescTextEdit.TabIndex = 29;
            // 
            // gusseteSpinEdit
            // 
            this.gusseteSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mspecBindingSource, "gussete", true));
            this.gusseteSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.gusseteSpinEdit.Location = new System.Drawing.Point(154, 321);
            this.gusseteSpinEdit.Name = "gusseteSpinEdit";
            this.gusseteSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.gusseteSpinEdit.Properties.UseCtrlIncrement = false;
            this.gusseteSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.gusseteSpinEdit.TabIndex = 31;
            // 
            // wnocoreSpinEdit
            // 
            this.wnocoreSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mspecBindingSource, "wnocore", true));
            this.wnocoreSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.wnocoreSpinEdit.Location = new System.Drawing.Point(154, 373);
            this.wnocoreSpinEdit.Name = "wnocoreSpinEdit";
            this.wnocoreSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.wnocoreSpinEdit.Properties.UseCtrlIncrement = false;
            this.wnocoreSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.wnocoreSpinEdit.TabIndex = 33;
            // 
            // prodescTextEdit
            // 
            this.prodescTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mspecBindingSource, "prodesc", true));
            this.prodescTextEdit.Location = new System.Drawing.Point(154, 217);
            this.prodescTextEdit.Name = "prodescTextEdit";
            this.prodescTextEdit.Properties.MaxLength = 25;
            this.prodescTextEdit.Size = new System.Drawing.Size(180, 20);
            this.prodescTextEdit.TabIndex = 34;
            // 
            // FrmMasterflexy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(524, 670);
            this.MasterBindingSource = this.mspecBindingSource;
            this.MasterQuery = "select * from mspec where jenis=\'flexi\' order by inv";
            this.MasterTable = this.casDataSet.mspec;
            this.Name = "FrmMasterflexy";
            this.Text = "Master Spesification Flexible";
            this.Load += new System.EventHandler(this.FrmMasterflexy_Load);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mspecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fcodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitchSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenisTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyinboxSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fdescTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gusseteSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wnocoreSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodescTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource mspecBindingSource;
        private CAS.casDataSetTableAdapters.mspecTableAdapter mspecTableAdapter;
        private KASLibrary.TextBoxEx invTextBoxEx;
        private DevExpress.XtraEditors.TextEdit remarkTextEdit;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.TextEdit specTextEdit;
        private DevExpress.XtraEditors.TextEdit fcodeTextEdit;
        private DevExpress.XtraEditors.SpinEdit weightSpinEdit;
        private DevExpress.XtraEditors.TextEdit procodeTextEdit;
        private DevExpress.XtraEditors.SpinEdit widthSpinEdit;
        private DevExpress.XtraEditors.SpinEdit pitchSpinEdit;
        private DevExpress.XtraEditors.SpinEdit lengSpinEdit;
        private DevExpress.XtraEditors.TextEdit jenisTextEdit;
        private KASLibrary.TextBoxEx subTextBoxEx;
        private DevExpress.XtraEditors.SpinEdit qtyinboxSpinEdit;
        private DevExpress.XtraEditors.TextEdit fdescTextEdit;
        private DevExpress.XtraEditors.SpinEdit gusseteSpinEdit;
        private DevExpress.XtraEditors.SpinEdit wnocoreSpinEdit;
        private DevExpress.XtraEditors.TextEdit prodescTextEdit;
    }
}
