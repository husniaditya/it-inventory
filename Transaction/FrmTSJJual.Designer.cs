namespace CAS.Transaction
{
    partial class FrmTSJJual
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
            System.Windows.Forms.Label shiptonameLabel;
            System.Windows.Forms.Label angkutanLabel;
            System.Windows.Forms.Label nopolLabel;
            System.Windows.Forms.Label remarkLabel;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label no_conLabel;
            System.Windows.Forms.Label bsaLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            this.casDataSet = new CAS.casDataSet();
            this.sjhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sjdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shiptonameTextBoxEx = new KASLibrary.TextBoxEx();
            this.shiptoaddressMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.nopolTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.remarkMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.gcxSjd = new KASLibrary.GridControlEx();
            this.spinTOP = new DevExpress.XtraEditors.SpinEdit();
            this.spmTextBoxEx = new KASLibrary.TextBoxEx();
            this.txtAlias = new KASLibrary.TextBoxEx();
            this.angkutanTextBoxEx = new KASLibrary.TextBoxEx();
            this.linkToForm1 = new CAS.linkToForm();
            this.buttonCallSMU = new System.Windows.Forms.Button();
            this.sjhTableAdapter = new CAS.casDataSetTableAdapters.sjhTableAdapter();
            this.no_conTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.bsaTextBoxEx = new KASLibrary.TextBoxEx();
            this.txtTotalqtykemasan = new DevExpress.XtraEditors.TextEdit();
            this.globalBoxEx = new KASLibrary.TextBoxEx();
            this.txtTotalqty = new DevExpress.XtraEditors.TextEdit();
            this.ctrlSub = new CAS.Transaction.CtrlSub();
            shiptonameLabel = new System.Windows.Forms.Label();
            angkutanLabel = new System.Windows.Forms.Label();
            nopolLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            no_conLabel = new System.Windows.Forms.Label();
            bsaLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludSeri.Properties)).BeginInit();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curkurs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curcur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sjhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sjdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiptonameTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiptoaddressMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nopolTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTOP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spmTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlias.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angkutanTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_conTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsaTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalqtykemasan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalqty.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(206, 13);
            this.txtNo.EditValueChanged += new System.EventHandler(this.txtNo_EditValueChanged);
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(157, 13);
            // 
            // ludSeri
            // 
            this.ludSeri.Location = new System.Drawing.Point(80, 13);
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.ctrlSub);
            this.pnlDetail.Controls.Add(this.txtTotalqty);
            this.pnlDetail.Controls.Add(label3);
            this.pnlDetail.Controls.Add(this.globalBoxEx);
            this.pnlDetail.Controls.Add(label4);
            this.pnlDetail.Controls.Add(this.txtTotalqtykemasan);
            this.pnlDetail.Controls.Add(label2);
            this.pnlDetail.Controls.Add(bsaLabel);
            this.pnlDetail.Controls.Add(this.bsaTextBoxEx);
            this.pnlDetail.Controls.Add(no_conLabel);
            this.pnlDetail.Controls.Add(this.no_conTextEdit);
            this.pnlDetail.Controls.Add(this.linkToForm1);
            this.pnlDetail.Controls.Add(this.angkutanTextBoxEx);
            this.pnlDetail.Controls.Add(this.txtAlias);
            this.pnlDetail.Controls.Add(this.spmTextBoxEx);
            this.pnlDetail.Controls.Add(this.spinTOP);
            this.pnlDetail.Controls.Add(label5);
            this.pnlDetail.Controls.Add(this.gcxSjd);
            this.pnlDetail.Controls.Add(remarkLabel);
            this.pnlDetail.Controls.Add(this.remarkMemoEdit);
            this.pnlDetail.Controls.Add(nopolLabel);
            this.pnlDetail.Controls.Add(this.nopolTextEdit);
            this.pnlDetail.Controls.Add(angkutanLabel);
            this.pnlDetail.Controls.Add(this.shiptonameTextBoxEx);
            this.pnlDetail.Controls.Add(shiptonameLabel);
            this.pnlDetail.Controls.Add(this.shiptoaddressMemoEdit);
            this.pnlDetail.Location = new System.Drawing.Point(0, 69);
            this.pnlDetail.Size = new System.Drawing.Size(759, 375);
            this.pnlDetail.Controls.SetChildIndex(this.dateDate, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curcur, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curkurs, 0);
            this.pnlDetail.Controls.SetChildIndex(this.kursLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curLabel1, 0);
            this.pnlDetail.Controls.SetChildIndex(this.shiptoaddressMemoEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(shiptonameLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.shiptonameTextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(angkutanLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.nopolTextEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(nopolLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.remarkMemoEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(remarkLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.gcxSjd, 0);
            this.pnlDetail.Controls.SetChildIndex(label5, 0);
            this.pnlDetail.Controls.SetChildIndex(this.spinTOP, 0);
            this.pnlDetail.Controls.SetChildIndex(this.spmTextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(this.txtAlias, 0);
            this.pnlDetail.Controls.SetChildIndex(this.angkutanTextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(this.linkToForm1, 0);
            this.pnlDetail.Controls.SetChildIndex(this.no_conTextEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(no_conLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.bsaTextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(bsaLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(label2, 0);
            this.pnlDetail.Controls.SetChildIndex(this.txtTotalqtykemasan, 0);
            this.pnlDetail.Controls.SetChildIndex(label4, 0);
            this.pnlDetail.Controls.SetChildIndex(this.globalBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(label3, 0);
            this.pnlDetail.Controls.SetChildIndex(this.txtTotalqty, 0);
            this.pnlDetail.Controls.SetChildIndex(this.ctrlSub, 0);
            // 
            // pnlKey
            // 
            this.pnlKey.Controls.Add(this.buttonCallSMU);
            this.pnlKey.Size = new System.Drawing.Size(759, 44);
            this.pnlKey.Controls.SetChildIndex(this.label1, 0);
            this.pnlKey.Controls.SetChildIndex(this.ludSeri, 0);
            this.pnlKey.Controls.SetChildIndex(this.txtNo, 0);
            this.pnlKey.Controls.SetChildIndex(this.txtPeriod, 0);
            this.pnlKey.Controls.SetChildIndex(this.btnDocFlow, 0);
            this.pnlKey.Controls.SetChildIndex(this.lblDeleted, 0);
            this.pnlKey.Controls.SetChildIndex(this.buttonCallSMU, 0);
            // 
            // dateDate
            // 
            this.dateDate.EditValue = new System.DateTime(((long)(0)));
            this.dateDate.Location = new System.Drawing.Point(470, 3);
            this.dateDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateDate.Properties.Mask.IgnoreMaskBlank = false;
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(418, 6);
            // 
            // curkurs
            // 
            this.curkurs.Location = new System.Drawing.Point(363, 2);
            this.curkurs.Visible = false;
            // 
            // curcur
            // 
            this.curcur.Location = new System.Drawing.Point(264, 2);
            this.curcur.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.curcur.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.curcur.Properties.Appearance.Options.UseBackColor = true;
            this.curcur.Properties.Appearance.Options.UseForeColor = true;
            this.curcur.Visible = false;
            // 
            // curLabel1
            // 
            this.curLabel1.Location = new System.Drawing.Point(233, 5);
            this.curLabel1.Visible = false;
            // 
            // kursLabel
            // 
            this.kursLabel.Location = new System.Drawing.Point(327, 5);
            this.kursLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(26, 16);
            // 
            // btnDocFlow
            // 
            this.btnDocFlow.Location = new System.Drawing.Point(455, 10);
            this.btnDocFlow.Visible = true;
            this.btnDocFlow.Click += new System.EventHandler(this.btnDocFlow_Click);
            // 
            // lblDeleted
            // 
            this.lblDeleted.Location = new System.Drawing.Point(347, 13);
            // 
            // shiptonameLabel
            // 
            shiptonameLabel.AutoSize = true;
            shiptonameLabel.Location = new System.Drawing.Point(414, 127);
            shiptonameLabel.Name = "shiptonameLabel";
            shiptonameLabel.Size = new System.Drawing.Size(42, 13);
            shiptonameLabel.TabIndex = 126;
            shiptonameLabel.Text = "Ship To";
            // 
            // angkutanLabel
            // 
            angkutanLabel.AutoSize = true;
            angkutanLabel.Location = new System.Drawing.Point(409, 84);
            angkutanLabel.Name = "angkutanLabel";
            angkutanLabel.Size = new System.Drawing.Size(53, 13);
            angkutanLabel.TabIndex = 129;
            angkutanLabel.Text = "Angkutan";
            // 
            // nopolLabel
            // 
            nopolLabel.AutoSize = true;
            nopolLabel.Location = new System.Drawing.Point(413, 58);
            nopolLabel.Name = "nopolLabel";
            nopolLabel.Size = new System.Drawing.Size(46, 13);
            nopolLabel.TabIndex = 131;
            nopolLabel.Text = "No Polisi";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(12, 151);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(63, 13);
            remarkLabel.TabIndex = 132;
            remarkLabel.Text = "Keterangan";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(433, 32);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(27, 13);
            label5.TabIndex = 135;
            label5.Text = "TOP";
            // 
            // no_conLabel
            // 
            no_conLabel.AutoSize = true;
            no_conLabel.Location = new System.Drawing.Point(580, 60);
            no_conLabel.Name = "no_conLabel";
            no_conLabel.Size = new System.Drawing.Size(70, 13);
            no_conLabel.TabIndex = 140;
            no_conLabel.Text = "No Container";
            // 
            // bsaLabel
            // 
            bsaLabel.AutoSize = true;
            bsaLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            bsaLabel.ForeColor = System.Drawing.Color.Red;
            bsaLabel.Location = new System.Drawing.Point(589, 18);
            bsaLabel.Name = "bsaLabel";
            bsaLabel.Size = new System.Drawing.Size(69, 13);
            bsaLabel.TabIndex = 142;
            bsaLabel.Text = "Bisnis Area";
            bsaLabel.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(654, 125);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(71, 13);
            label2.TabIndex = 141;
            label2.Text = "Qty Kemasan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(654, 86);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(73, 13);
            label4.TabIndex = 144;
            label4.Text = "Barang Global";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(656, 164);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(25, 13);
            label3.TabIndex = 147;
            label3.Text = "Qty";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sjhBindingSource
            // 
            this.sjhBindingSource.DataMember = "sjh";
            this.sjhBindingSource.DataSource = this.casDataSet;
            // 
            // sjdBindingSource
            // 
            this.sjdBindingSource.DataMember = "sjd";
            this.sjdBindingSource.DataSource = this.casDataSet;
            // 
            // shiptonameTextBoxEx
            // 
            this.shiptonameTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sjhBindingSource, "shiptoname", true));
            this.shiptonameTextBoxEx.ExAllowEmptyString = true;
            this.shiptonameTextBoxEx.ExAllowNonDBData = false;
            this.shiptonameTextBoxEx.ExAutoCheck = true;
            this.shiptonameTextBoxEx.ExAutoShowResult = false;
            this.shiptonameTextBoxEx.ExCondition = "";
            this.shiptonameTextBoxEx.ExDialogTitle = "";
            this.shiptonameTextBoxEx.ExFieldName = "shiptoname";
            this.shiptonameTextBoxEx.ExFilterFields = new string[0];
            this.shiptonameTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.shiptonameTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.shiptonameTextBoxEx.ExLabelContainer = null;
            this.shiptonameTextBoxEx.ExLabelField = "";
            this.shiptonameTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.shiptonameTextBoxEx.ExLabelText = "";
            this.shiptonameTextBoxEx.ExLabelVisible = false;
            this.shiptonameTextBoxEx.ExSelectFields = new string[0];
            this.shiptonameTextBoxEx.ExShowDialog = false;
            this.shiptonameTextBoxEx.ExSimpleMode = true;
            this.shiptonameTextBoxEx.ExSqlInstance = null;
            this.shiptonameTextBoxEx.ExSqlQuery = "";
            this.shiptonameTextBoxEx.ExTableName = "subto";
            this.shiptonameTextBoxEx.Location = new System.Drawing.Point(470, 124);
            this.shiptonameTextBoxEx.Name = "shiptonameTextBoxEx";
            this.shiptonameTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.shiptonameTextBoxEx.Size = new System.Drawing.Size(163, 20);
            this.shiptonameTextBoxEx.TabIndex = 128;
            // 
            // shiptoaddressMemoEdit
            // 
            this.shiptoaddressMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sjhBindingSource, "shiptoaddress", true));
            this.shiptoaddressMemoEdit.Location = new System.Drawing.Point(470, 150);
            this.shiptoaddressMemoEdit.Name = "shiptoaddressMemoEdit";
            this.shiptoaddressMemoEdit.Size = new System.Drawing.Size(181, 38);
            this.shiptoaddressMemoEdit.TabIndex = 127;
            // 
            // nopolTextEdit
            // 
            this.nopolTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sjhBindingSource, "nopol", true));
            this.nopolTextEdit.Location = new System.Drawing.Point(470, 55);
            this.nopolTextEdit.Name = "nopolTextEdit";
            this.nopolTextEdit.Size = new System.Drawing.Size(100, 20);
            this.nopolTextEdit.TabIndex = 132;
            // 
            // remarkMemoEdit
            // 
            this.remarkMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sjhBindingSource, "remark", true));
            this.remarkMemoEdit.Location = new System.Drawing.Point(80, 149);
            this.remarkMemoEdit.Name = "remarkMemoEdit";
            this.remarkMemoEdit.Size = new System.Drawing.Size(293, 40);
            this.remarkMemoEdit.TabIndex = 133;
            // 
            // gcxSjd
            // 
            this.gcxSjd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcxSjd.BestFitColumn = true;
            this.gcxSjd.ExAutoSize = false;
            this.gcxSjd.Location = new System.Drawing.Point(12, 209);
            this.gcxSjd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gcxSjd.Name = "gcxSjd";
            this.gcxSjd.Size = new System.Drawing.Size(739, 179);
            this.gcxSjd.TabIndex = 134;
            // 
            // spinTOP
            // 
            this.spinTOP.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinTOP.Location = new System.Drawing.Point(470, 29);
            this.spinTOP.Name = "spinTOP";
            this.spinTOP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinTOP.Properties.UseCtrlIncrement = false;
            this.spinTOP.Size = new System.Drawing.Size(66, 20);
            this.spinTOP.TabIndex = 136;
            // 
            // spmTextBoxEx
            // 
            this.spmTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sjhBindingSource, "spm", true));
            this.spmTextBoxEx.ExAllowEmptyString = true;
            this.spmTextBoxEx.ExAllowNonDBData = false;
            this.spmTextBoxEx.ExAutoCheck = true;
            this.spmTextBoxEx.ExAutoShowResult = false;
            this.spmTextBoxEx.ExCondition = "spm not in (select spm from sjh) and aprov=1 and group_=1";
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
            this.spmTextBoxEx.Location = new System.Drawing.Point(82, 2);
            this.spmTextBoxEx.Name = "spmTextBoxEx";
            this.spmTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.spmTextBoxEx.Size = new System.Drawing.Size(140, 20);
            this.spmTextBoxEx.TabIndex = 137;
            this.spmTextBoxEx.EditValueChanged += new System.EventHandler(this.spmTextBoxEx_EditValueChanged);
            this.spmTextBoxEx.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.spmTextBoxEx_ButtonPressed);
            // 
            // txtAlias
            // 
            this.txtAlias.ExAllowEmptyString = true;
            this.txtAlias.ExAllowNonDBData = false;
            this.txtAlias.ExAutoCheck = true;
            this.txtAlias.ExAutoShowResult = false;
            this.txtAlias.ExCondition = "";
            this.txtAlias.ExDialogTitle = "";
            this.txtAlias.ExFieldName = "alias";
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
            this.txtAlias.Location = new System.Drawing.Point(630, 124);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtAlias.Size = new System.Drawing.Size(21, 20);
            this.txtAlias.TabIndex = 138;
            this.txtAlias.EditValueChanged += new System.EventHandler(this.txtAlias_EditValueChanged);
            // 
            // angkutanTextBoxEx
            // 
            this.angkutanTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sjhBindingSource, "angkutan", true));
            this.angkutanTextBoxEx.ExAllowEmptyString = true;
            this.angkutanTextBoxEx.ExAllowNonDBData = false;
            this.angkutanTextBoxEx.ExAutoCheck = true;
            this.angkutanTextBoxEx.ExAutoShowResult = false;
            this.angkutanTextBoxEx.ExCondition = "group_=1 and aktif=1";
            this.angkutanTextBoxEx.ExDialogTitle = "Select Supplier Angkutan";
            this.angkutanTextBoxEx.ExFieldName = "Kode";
            this.angkutanTextBoxEx.ExFilterFields = new string[0];
            this.angkutanTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.angkutanTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.angkutanTextBoxEx.ExLabelContainer = null;
            this.angkutanTextBoxEx.ExLabelField = "Nama";
            this.angkutanTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.angkutanTextBoxEx.ExLabelText = "";
            this.angkutanTextBoxEx.ExLabelVisible = true;
            this.angkutanTextBoxEx.ExSelectFields = new string[0];
            this.angkutanTextBoxEx.ExShowDialog = true;
            this.angkutanTextBoxEx.ExSimpleMode = true;
            this.angkutanTextBoxEx.ExSqlInstance = null;
            this.angkutanTextBoxEx.ExSqlQuery = "Call SP_LookUp(\'angkutan\')";
            this.angkutanTextBoxEx.ExTableName = "sub";
            this.angkutanTextBoxEx.Location = new System.Drawing.Point(470, 81);
            this.angkutanTextBoxEx.Name = "angkutanTextBoxEx";
            this.angkutanTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.angkutanTextBoxEx.Size = new System.Drawing.Size(100, 20);
            this.angkutanTextBoxEx.TabIndex = 139;
            // 
            // linkToForm1
            // 
            this.linkToForm1.AutoSize = true;
            this.linkToForm1.FormName = "FrmTSpmJual";
            this.linkToForm1.Location = new System.Drawing.Point(33, 5);
            this.linkToForm1.Name = "linkToForm1";
            this.linkToForm1.Size = new System.Drawing.Size(43, 13);
            this.linkToForm1.TabIndex = 140;
            this.linkToForm1.TabStop = true;
            this.linkToForm1.Text = "No SPM";
            this.linkToForm1.TxtKode = this.spmTextBoxEx;
            this.linkToForm1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkToForm1_LinkClicked);
            // 
            // buttonCallSMU
            // 
            this.buttonCallSMU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCallSMU.BackColor = System.Drawing.Color.HotPink;
            this.buttonCallSMU.Location = new System.Drawing.Point(621, 4);
            this.buttonCallSMU.Name = "buttonCallSMU";
            this.buttonCallSMU.Size = new System.Drawing.Size(125, 38);
            this.buttonCallSMU.TabIndex = 14;
            this.buttonCallSMU.Text = "Call Function SAP-SMU";
            this.buttonCallSMU.UseVisualStyleBackColor = false;
            this.buttonCallSMU.Visible = false;
            this.buttonCallSMU.Click += new System.EventHandler(this.buttonCallSMU_Click);
            // 
            // sjhTableAdapter
            // 
            this.sjhTableAdapter.ClearBeforeFill = true;
            // 
            // no_conTextEdit
            // 
            this.no_conTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sjhBindingSource, "no_con", true));
            this.no_conTextEdit.Location = new System.Drawing.Point(651, 55);
            this.no_conTextEdit.Name = "no_conTextEdit";
            this.no_conTextEdit.Size = new System.Drawing.Size(100, 20);
            this.no_conTextEdit.TabIndex = 141;
            // 
            // bsaTextBoxEx
            // 
            this.bsaTextBoxEx.Enabled = false;
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
            this.bsaTextBoxEx.Location = new System.Drawing.Point(666, 15);
            this.bsaTextBoxEx.Name = "bsaTextBoxEx";
            this.bsaTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.bsaTextBoxEx.Size = new System.Drawing.Size(81, 20);
            this.bsaTextBoxEx.TabIndex = 143;
            this.bsaTextBoxEx.Visible = false;
            // 
            // txtTotalqtykemasan
            // 
            this.txtTotalqtykemasan.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sjhBindingSource, "totqtykemasan", true));
            this.txtTotalqtykemasan.Location = new System.Drawing.Point(657, 141);
            this.txtTotalqtykemasan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotalqtykemasan.Name = "txtTotalqtykemasan";
            this.txtTotalqtykemasan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtTotalqtykemasan.Properties.Appearance.Options.UseFont = true;
            this.txtTotalqtykemasan.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotalqtykemasan.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotalqtykemasan.Size = new System.Drawing.Size(81, 20);
            this.txtTotalqtykemasan.TabIndex = 140;
            // 
            // globalBoxEx
            // 
            this.globalBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sjhBindingSource, "kodeglobal", true));
            this.globalBoxEx.ExAllowEmptyString = true;
            this.globalBoxEx.ExAllowNonDBData = false;
            this.globalBoxEx.ExAutoCheck = true;
            this.globalBoxEx.ExAutoShowResult = false;
            this.globalBoxEx.ExCondition = "";
            this.globalBoxEx.ExDialogTitle = "";
            this.globalBoxEx.ExFieldName = "inv";
            this.globalBoxEx.ExFilterFields = new string[0];
            this.globalBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.globalBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.globalBoxEx.ExLabelContainer = null;
            this.globalBoxEx.ExLabelField = "name";
            this.globalBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.globalBoxEx.ExLabelText = "";
            this.globalBoxEx.ExLabelVisible = true;
            this.globalBoxEx.ExSelectFields = new string[0];
            this.globalBoxEx.ExShowDialog = true;
            this.globalBoxEx.ExSimpleMode = true;
            this.globalBoxEx.ExSqlInstance = null;
            this.globalBoxEx.ExSqlQuery = "select inv,name from inv where group_ = 5";
            this.globalBoxEx.ExTableName = "docpd";
            this.globalBoxEx.Location = new System.Drawing.Point(657, 103);
            this.globalBoxEx.Name = "globalBoxEx";
            this.globalBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.globalBoxEx.Size = new System.Drawing.Size(133, 20);
            this.globalBoxEx.TabIndex = 145;
            // 
            // txtTotalqty
            // 
            this.txtTotalqty.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sjhBindingSource, "totqty", true));
            this.txtTotalqty.Location = new System.Drawing.Point(659, 180);
            this.txtTotalqty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotalqty.Name = "txtTotalqty";
            this.txtTotalqty.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtTotalqty.Properties.Appearance.Options.UseFont = true;
            this.txtTotalqty.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotalqty.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotalqty.Size = new System.Drawing.Size(81, 20);
            this.txtTotalqty.TabIndex = 146;
            // 
            // ctrlSub
            // 
            this.ctrlSub.Location = new System.Drawing.Point(15, 30);
            this.ctrlSub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlSub.Name = "ctrlSub";
            this.ctrlSub.ReadOnly = true;
            this.ctrlSub.Size = new System.Drawing.Size(335, 115);
            this.ctrlSub.TabIndex = 148;
            this.ctrlSub.Type = CAS.Transaction.CtrlSub.SubType.All;
            // 
            // FrmTSJJual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 487);
            this.DetailBindingSource = this.sjdBindingSource;
            this.DetailTable = this.casDataSet.sjd;
            this.MasterBindingSource = this.sjhBindingSource;
            this.MasterTable = this.casDataSet.sjh;
            this.Name = "FrmTSJJual";
            this.Text = "Surat Jalan Penjualan";
            this.Load += new System.EventHandler(this.FrmTSJJual_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.sjhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sjdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiptonameTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiptoaddressMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nopolTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTOP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spmTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlias.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angkutanTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_conTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsaTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalqtykemasan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalqty.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource sjhBindingSource;
        private System.Windows.Forms.BindingSource sjdBindingSource;
        private KASLibrary.TextBoxEx shiptonameTextBoxEx;
        private DevExpress.XtraEditors.MemoEdit shiptoaddressMemoEdit;
        private DevExpress.XtraEditors.MemoEdit remarkMemoEdit;
        private DevExpress.XtraEditors.TextEdit nopolTextEdit;
        private KASLibrary.GridControlEx gcxSjd;
        private DevExpress.XtraEditors.SpinEdit spinTOP;
        private KASLibrary.TextBoxEx spmTextBoxEx;
        private KASLibrary.TextBoxEx txtAlias;
        private KASLibrary.TextBoxEx angkutanTextBoxEx;
        private linkToForm linkToForm1;
        private System.Windows.Forms.Button buttonCallSMU;
        private DevExpress.XtraEditors.TextEdit no_conTextEdit;
        private CAS.casDataSetTableAdapters.sjhTableAdapter sjhTableAdapter;
        private KASLibrary.TextBoxEx bsaTextBoxEx;
        private DevExpress.XtraEditors.TextEdit txtTotalqtykemasan;
        private DevExpress.XtraEditors.TextEdit txtTotalqty;
        private KASLibrary.TextBoxEx globalBoxEx;
        private CtrlSub ctrlSub;
    }
}