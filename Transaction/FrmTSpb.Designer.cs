namespace CAS.Transaction
{
    partial class FrmTSpb
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
            System.Windows.Forms.Label nopolLabel;
            System.Windows.Forms.Label nosjLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label withPOLabel;
            System.Windows.Forms.Label aprovLabel;
            System.Windows.Forms.Label cpoLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label tglproformaLabel;
            System.Windows.Forms.Label label4;
            this.sendgdLabel = new System.Windows.Forms.Label();
            this.spbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casDataSet = new CAS.casDataSet();
            this.nopolTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nosjTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.remarkMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.gcSpb = new KASLibrary.GridControlEx();
            this.spbdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.omsTextBoxEx = new KASLibrary.TextBoxEx();
            this.withPOCheckBox = new System.Windows.Forms.CheckBox();
            this.aprovCheckBox = new System.Windows.Forms.CheckBox();
            this.ctrlSub = new CAS.Transaction.CtrlSub();
            this.linkToOms = new CAS.linkToForm();
            this.sendgdCheckBox = new System.Windows.Forms.CheckBox();
            this.cpoCheckBox = new System.Windows.Forms.CheckBox();
            this.comboStation = new System.Windows.Forms.ComboBox();
            this.Stationlabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.spbTableAdapter = new CAS.casDataSetTableAdapters.spbTableAdapter();
            this.nodocTextBoxEx = new KASLibrary.TextBoxEx();
            this.tglbc = new DevExpress.XtraEditors.DateEdit();
            this.jetiCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.shipperTextEdit = new DevExpress.XtraEditors.TextEdit();
            nopolLabel = new System.Windows.Forms.Label();
            nosjLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            withPOLabel = new System.Windows.Forms.Label();
            aprovLabel = new System.Windows.Forms.Label();
            cpoLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            tglproformaLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludSeri.Properties)).BeginInit();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curkurs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curcur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nopolTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nosjTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spbdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.omsTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodocTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglbc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jetiCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipperTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNo
            // 
            this.txtNo.Size = new System.Drawing.Size(85, 26);
            this.txtNo.EditValueChanged += new System.EventHandler(this.txtNo_EditValueChanged);
            // 
            // txtPeriod
            // 
            this.txtPeriod.Size = new System.Drawing.Size(43, 26);
            this.txtPeriod.EditValueChanged += new System.EventHandler(this.txtPeriod_EditValueChanged);
            // 
            // ludSeri
            // 
            this.ludSeri.Size = new System.Drawing.Size(71, 26);
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.shipperTextEdit);
            this.pnlDetail.Controls.Add(label4);
            this.pnlDetail.Controls.Add(this.jetiCheckEdit);
            this.pnlDetail.Controls.Add(tglproformaLabel);
            this.pnlDetail.Controls.Add(this.tglbc);
            this.pnlDetail.Controls.Add(this.nodocTextBoxEx);
            this.pnlDetail.Controls.Add(label3);
            this.pnlDetail.Controls.Add(this.Stationlabel);
            this.pnlDetail.Controls.Add(this.comboStation);
            this.pnlDetail.Controls.Add(cpoLabel);
            this.pnlDetail.Controls.Add(this.cpoCheckBox);
            this.pnlDetail.Controls.Add(this.sendgdLabel);
            this.pnlDetail.Controls.Add(this.sendgdCheckBox);
            this.pnlDetail.Controls.Add(this.gcSpb);
            this.pnlDetail.Controls.Add(this.omsTextBoxEx);
            this.pnlDetail.Controls.Add(label2);
            this.pnlDetail.Controls.Add(this.linkToOms);
            this.pnlDetail.Controls.Add(this.nosjTextEdit);
            this.pnlDetail.Controls.Add(this.nopolTextEdit);
            this.pnlDetail.Controls.Add(this.remarkMemoEdit);
            this.pnlDetail.Controls.Add(nosjLabel);
            this.pnlDetail.Controls.Add(withPOLabel);
            this.pnlDetail.Controls.Add(this.withPOCheckBox);
            this.pnlDetail.Controls.Add(aprovLabel);
            this.pnlDetail.Controls.Add(this.aprovCheckBox);
            this.pnlDetail.Controls.Add(this.ctrlSub);
            this.pnlDetail.Controls.Add(nopolLabel);
            this.pnlDetail.Size = new System.Drawing.Size(899, 550);
            this.pnlDetail.Controls.SetChildIndex(nopolLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.ctrlSub, 0);
            this.pnlDetail.Controls.SetChildIndex(this.aprovCheckBox, 0);
            this.pnlDetail.Controls.SetChildIndex(aprovLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.withPOCheckBox, 0);
            this.pnlDetail.Controls.SetChildIndex(withPOLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(nosjLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.remarkMemoEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(this.nopolTextEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(this.nosjTextEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(this.linkToOms, 0);
            this.pnlDetail.Controls.SetChildIndex(label2, 0);
            this.pnlDetail.Controls.SetChildIndex(this.omsTextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(this.gcSpb, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateDate, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curcur, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curkurs, 0);
            this.pnlDetail.Controls.SetChildIndex(this.kursLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curLabel1, 0);
            this.pnlDetail.Controls.SetChildIndex(this.sendgdCheckBox, 0);
            this.pnlDetail.Controls.SetChildIndex(this.sendgdLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.cpoCheckBox, 0);
            this.pnlDetail.Controls.SetChildIndex(cpoLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.comboStation, 0);
            this.pnlDetail.Controls.SetChildIndex(this.Stationlabel, 0);
            this.pnlDetail.Controls.SetChildIndex(label3, 0);
            this.pnlDetail.Controls.SetChildIndex(this.nodocTextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(this.tglbc, 0);
            this.pnlDetail.Controls.SetChildIndex(tglproformaLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.jetiCheckEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(label4, 0);
            this.pnlDetail.Controls.SetChildIndex(this.shipperTextEdit, 0);
            // 
            // pnlKey
            // 
            this.pnlKey.Controls.Add(this.button1);
            this.pnlKey.Size = new System.Drawing.Size(899, 50);
            this.pnlKey.Controls.SetChildIndex(this.button1, 0);
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
            this.dateDate.Location = new System.Drawing.Point(445, 6);
            this.dateDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateDate.Properties.Mask.IgnoreMaskBlank = false;
            this.dateDate.Size = new System.Drawing.Size(100, 26);
            this.dateDate.EditValueChanged += new System.EventHandler(this.dateDate_EditValueChanged);
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(394, 9);
            // 
            // curkurs
            // 
            this.curkurs.Location = new System.Drawing.Point(652, 56);
            this.curkurs.Visible = false;
            // 
            // curcur
            // 
            this.curcur.Location = new System.Drawing.Point(553, 56);
            this.curcur.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.curcur.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.curcur.Properties.Appearance.Options.UseBackColor = true;
            this.curcur.Properties.Appearance.Options.UseForeColor = true;
            this.curcur.Size = new System.Drawing.Size(57, 26);
            this.curcur.Visible = false;
            // 
            // curLabel1
            // 
            this.curLabel1.Location = new System.Drawing.Point(525, 59);
            this.curLabel1.Visible = false;
            // 
            // kursLabel
            // 
            this.kursLabel.Location = new System.Drawing.Point(616, 59);
            this.kursLabel.Visible = false;
            // 
            // btnDocFlow
            // 
            this.btnDocFlow.Location = new System.Drawing.Point(637, 16);
            this.btnDocFlow.Visible = true;
            // 
            // nopolLabel
            // 
            nopolLabel.AutoSize = true;
            nopolLabel.Location = new System.Drawing.Point(391, 102);
            nopolLabel.Name = "nopolLabel";
            nopolLabel.Size = new System.Drawing.Size(71, 19);
            nopolLabel.TabIndex = 50;
            nopolLabel.Text = "No Polisi";
            // 
            // nosjLabel
            // 
            nosjLabel.AutoSize = true;
            nosjLabel.Location = new System.Drawing.Point(394, 77);
            nosjLabel.Name = "nosjLabel";
            nosjLabel.Size = new System.Drawing.Size(68, 19);
            nosjLabel.TabIndex = 52;
            nosjLabel.Text = "No S.Jln";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(9, 161);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(88, 19);
            label2.TabIndex = 68;
            label2.Text = "Keterangan";
            // 
            // withPOLabel
            // 
            withPOLabel.AutoSize = true;
            withPOLabel.Location = new System.Drawing.Point(391, 56);
            withPOLabel.Name = "withPOLabel";
            withPOLabel.Size = new System.Drawing.Size(67, 19);
            withPOLabel.TabIndex = 79;
            withPOLabel.Text = "With PO";
            // 
            // aprovLabel
            // 
            aprovLabel.AutoSize = true;
            aprovLabel.Location = new System.Drawing.Point(299, 14);
            aprovLabel.Name = "aprovLabel";
            aprovLabel.Size = new System.Drawing.Size(69, 19);
            aprovLabel.TabIndex = 80;
            aprovLabel.Text = "Approve";
            // 
            // cpoLabel
            // 
            cpoLabel.AutoSize = true;
            cpoLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            cpoLabel.Location = new System.Drawing.Point(21, 14);
            cpoLabel.Name = "cpoLabel";
            cpoLabel.Size = new System.Drawing.Size(127, 22);
            cpoLabel.TabIndex = 84;
            cpoLabel.Text = "Material CPO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(634, 116);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(155, 19);
            label3.TabIndex = 91;
            label3.Text = "Dokumen Pelabuhan";
            // 
            // tglproformaLabel
            // 
            tglproformaLabel.AutoSize = true;
            tglproformaLabel.Location = new System.Drawing.Point(612, 9);
            tglproformaLabel.Name = "tglproformaLabel";
            tglproformaLabel.Size = new System.Drawing.Size(151, 19);
            tglproformaLabel.TabIndex = 130;
            tglproformaLabel.Text = "Tgl Rekam Beacukai";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(634, 85);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(63, 19);
            label4.TabIndex = 134;
            label4.Text = "Shipper";
            // 
            // sendgdLabel
            // 
            this.sendgdLabel.AutoSize = true;
            this.sendgdLabel.Location = new System.Drawing.Point(466, 171);
            this.sendgdLabel.Name = "sendgdLabel";
            this.sendgdLabel.Size = new System.Drawing.Size(95, 19);
            this.sendgdLabel.TabIndex = 83;
            this.sendgdLabel.Text = "Send to PLC";
            this.sendgdLabel.Click += new System.EventHandler(this.sendgdLabel_Click);
            // 
            // spbBindingSource
            // 
            this.spbBindingSource.DataMember = "spb";
            this.spbBindingSource.DataSource = this.casDataSet;
            this.spbBindingSource.PositionChanged += new System.EventHandler(this.spbBindingSource_PositionChanged);
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nopolTextEdit
            // 
            this.nopolTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spbBindingSource, "nopol", true));
            this.nopolTextEdit.Location = new System.Drawing.Point(445, 99);
            this.nopolTextEdit.Name = "nopolTextEdit";
            this.nopolTextEdit.Size = new System.Drawing.Size(100, 26);
            this.nopolTextEdit.TabIndex = 52;
            // 
            // nosjTextEdit
            // 
            this.nosjTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spbBindingSource, "nosj", true));
            this.nosjTextEdit.Location = new System.Drawing.Point(445, 74);
            this.nosjTextEdit.Name = "nosjTextEdit";
            this.nosjTextEdit.Size = new System.Drawing.Size(100, 26);
            this.nosjTextEdit.TabIndex = 51;
            // 
            // remarkMemoEdit
            // 
            this.remarkMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spbBindingSource, "remark", true));
            this.remarkMemoEdit.Location = new System.Drawing.Point(77, 159);
            this.remarkMemoEdit.Name = "remarkMemoEdit";
            this.remarkMemoEdit.Size = new System.Drawing.Size(280, 38);
            this.remarkMemoEdit.TabIndex = 53;
            // 
            // gcSpb
            // 
            this.gcSpb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcSpb.BestFitColumn = true;
            this.gcSpb.ExAutoSize = false;
            this.gcSpb.Location = new System.Drawing.Point(12, 222);
            this.gcSpb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gcSpb.Name = "gcSpb";
            this.gcSpb.Size = new System.Drawing.Size(875, 322);
            this.gcSpb.TabIndex = 71;
            // 
            // spbdBindingSource
            // 
            this.spbdBindingSource.DataMember = "spbd";
            this.spbdBindingSource.DataSource = this.casDataSet;
            // 
            // omsTextBoxEx
            // 
            this.omsTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spbBindingSource, "oms", true));
            this.omsTextBoxEx.ExAllowEmptyString = true;
            this.omsTextBoxEx.ExAllowNonDBData = false;
            this.omsTextBoxEx.ExAutoCheck = false;
            this.omsTextBoxEx.ExAutoShowResult = false;
            this.omsTextBoxEx.ExCondition = "";
            this.omsTextBoxEx.ExDialogTitle = "Purchase Order";
            this.omsTextBoxEx.ExFieldName = "oms";
            this.omsTextBoxEx.ExFilterFields = new string[0];
            this.omsTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.omsTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.omsTextBoxEx.ExLabelContainer = null;
            this.omsTextBoxEx.ExLabelField = "";
            this.omsTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.omsTextBoxEx.ExLabelText = "";
            this.omsTextBoxEx.ExLabelVisible = false;
            this.omsTextBoxEx.ExSelectFields = new string[0];
            this.omsTextBoxEx.ExShowDialog = true;
            this.omsTextBoxEx.ExSimpleMode = true;
            this.omsTextBoxEx.ExSqlInstance = null;
            this.omsTextBoxEx.ExSqlQuery = "";
            this.omsTextBoxEx.ExTableName = "oms";
            this.omsTextBoxEx.Location = new System.Drawing.Point(445, 32);
            this.omsTextBoxEx.Name = "omsTextBoxEx";
            this.omsTextBoxEx.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.omsTextBoxEx.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.omsTextBoxEx.Properties.Appearance.Options.UseBackColor = true;
            this.omsTextBoxEx.Properties.Appearance.Options.UseForeColor = true;
            this.omsTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.omsTextBoxEx.Size = new System.Drawing.Size(129, 26);
            this.omsTextBoxEx.TabIndex = 73;
            this.omsTextBoxEx.EditValueChanged += new System.EventHandler(this.omsTextBoxEx_EditValueChanged);
            this.omsTextBoxEx.Enter += new System.EventHandler(this.omsTextBoxEx_Enter);
            // 
            // withPOCheckBox
            // 
            this.withPOCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.spbBindingSource, "withPO", true));
            this.withPOCheckBox.Location = new System.Drawing.Point(445, 51);
            this.withPOCheckBox.Name = "withPOCheckBox";
            this.withPOCheckBox.Size = new System.Drawing.Size(42, 24);
            this.withPOCheckBox.TabIndex = 80;
            this.withPOCheckBox.CheckedChanged += new System.EventHandler(this.withPOCheckBox_CheckedChanged);
            // 
            // aprovCheckBox
            // 
            this.aprovCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.spbBindingSource, "aprov", true));
            this.aprovCheckBox.Location = new System.Drawing.Point(281, 9);
            this.aprovCheckBox.Name = "aprovCheckBox";
            this.aprovCheckBox.Size = new System.Drawing.Size(23, 24);
            this.aprovCheckBox.TabIndex = 81;
            this.aprovCheckBox.CheckedChanged += new System.EventHandler(this.aprovCheckBox_CheckedChanged);
            // 
            // ctrlSub
            // 
            this.ctrlSub.Location = new System.Drawing.Point(12, 38);
            this.ctrlSub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlSub.Name = "ctrlSub";
            this.ctrlSub.ReadOnly = true;
            this.ctrlSub.Size = new System.Drawing.Size(335, 115);
            this.ctrlSub.TabIndex = 82;
            this.ctrlSub.Type = CAS.Transaction.CtrlSub.SubType.Supplier;
            this.ctrlSub.Load += new System.EventHandler(this.ctrlSub_Load);
            // 
            // linkToOms
            // 
            this.linkToOms.AutoSize = true;
            this.linkToOms.FormName = "";
            this.linkToOms.Location = new System.Drawing.Point(382, 33);
            this.linkToOms.Name = "linkToOms";
            this.linkToOms.Size = new System.Drawing.Size(80, 19);
            this.linkToOms.TabIndex = 83;
            this.linkToOms.TabStop = true;
            this.linkToOms.Text = "No. Order";
            this.linkToOms.TxtKode = this.omsTextBoxEx;
            // 
            // sendgdCheckBox
            // 
            this.sendgdCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.spbBindingSource, "sendgd", true));
            this.sendgdCheckBox.Location = new System.Drawing.Point(447, 166);
            this.sendgdCheckBox.Name = "sendgdCheckBox";
            this.sendgdCheckBox.Size = new System.Drawing.Size(104, 24);
            this.sendgdCheckBox.TabIndex = 84;
            this.sendgdCheckBox.Click += new System.EventHandler(this.sendgdCheckBox_Click);
            this.sendgdCheckBox.CheckedChanged += new System.EventHandler(this.sendgdCheckBox_CheckedChanged);
            // 
            // cpoCheckBox
            // 
            this.cpoCheckBox.Checked = true;
            this.cpoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cpoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.spbBindingSource, "cpo", true));
            this.cpoCheckBox.Location = new System.Drawing.Point(112, 10);
            this.cpoCheckBox.Name = "cpoCheckBox";
            this.cpoCheckBox.Size = new System.Drawing.Size(22, 24);
            this.cpoCheckBox.TabIndex = 85;
            this.cpoCheckBox.CheckedChanged += new System.EventHandler(this.cpoCheckBox_CheckedChanged);
            // 
            // comboStation
            // 
            this.comboStation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spbBindingSource, "station", true));
            this.comboStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStation.FormattingEnabled = true;
            this.comboStation.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboStation.Location = new System.Drawing.Point(445, 132);
            this.comboStation.Name = "comboStation";
            this.comboStation.Size = new System.Drawing.Size(73, 28);
            this.comboStation.TabIndex = 86;
            this.comboStation.SelectedIndexChanged += new System.EventHandler(this.comboStation_SelectedIndexChanged);
            this.comboStation.Click += new System.EventHandler(this.comboStation_Click);
            // 
            // Stationlabel
            // 
            this.Stationlabel.AutoSize = true;
            this.Stationlabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Stationlabel.Location = new System.Drawing.Point(377, 135);
            this.Stationlabel.Name = "Stationlabel";
            this.Stationlabel.Size = new System.Drawing.Size(92, 22);
            this.Stationlabel.TabIndex = 87;
            this.Stationlabel.Text = "STATION";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(465, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 22);
            this.button1.TabIndex = 11;
            this.button1.Text = "Check Flow Meter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // spbTableAdapter
            // 
            this.spbTableAdapter.ClearBeforeFill = true;
            // 
            // nodocTextBoxEx
            // 
            this.nodocTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spbBindingSource, "nodoc", true));
            this.nodocTextBoxEx.ExAllowEmptyString = true;
            this.nodocTextBoxEx.ExAllowNonDBData = false;
            this.nodocTextBoxEx.ExAutoCheck = true;
            this.nodocTextBoxEx.ExAutoShowResult = false;
            this.nodocTextBoxEx.ExCondition = "";
            this.nodocTextBoxEx.ExDialogTitle = "";
            this.nodocTextBoxEx.ExFieldName = "nopen";
            this.nodocTextBoxEx.ExFilterFields = new string[0];
            this.nodocTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.nodocTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.nodocTextBoxEx.ExLabelContainer = null;
            this.nodocTextBoxEx.ExLabelField = "no_bc";
            this.nodocTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.nodocTextBoxEx.ExLabelText = "";
            this.nodocTextBoxEx.ExLabelVisible = true;
            this.nodocTextBoxEx.ExSelectFields = new string[0];
            this.nodocTextBoxEx.ExShowDialog = true;
            this.nodocTextBoxEx.ExSimpleMode = true;
            this.nodocTextBoxEx.ExSqlInstance = null;
            this.nodocTextBoxEx.ExSqlQuery = "select docpd.nodoc,docpd.datedoc,docpd.no_bc,docpd.nopen from docpd,docp WHERE do" +
                "cp.docp = docpd.docp AND docp.delete = 0";
            this.nodocTextBoxEx.ExTableName = "docpd";
            this.nodocTextBoxEx.Location = new System.Drawing.Point(637, 134);
            this.nodocTextBoxEx.Name = "nodocTextBoxEx";
            this.nodocTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.nodocTextBoxEx.Size = new System.Drawing.Size(133, 26);
            this.nodocTextBoxEx.TabIndex = 92;
            this.nodocTextBoxEx.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.nodocTextBoxEx_ButtonPressed);
            // 
            // tglbc
            // 
            this.tglbc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spbBindingSource, "tgl_bc", true));
            this.tglbc.EditValue = null;
            this.tglbc.Location = new System.Drawing.Point(719, 5);
            this.tglbc.Name = "tglbc";
            this.tglbc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tglbc.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.tglbc.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.tglbc.Properties.EditFormat.FormatString = "d";
            this.tglbc.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.tglbc.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.tglbc.Size = new System.Drawing.Size(100, 26);
            this.tglbc.TabIndex = 131;
            // 
            // jetiCheckEdit
            // 
            this.jetiCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spbBindingSource, "jeti", true));
            this.jetiCheckEdit.Location = new System.Drawing.Point(160, 12);
            this.jetiCheckEdit.Name = "jetiCheckEdit";
            this.jetiCheckEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.jetiCheckEdit.Properties.Appearance.Options.UseFont = true;
            this.jetiCheckEdit.Properties.Caption = "Jeti";
            this.jetiCheckEdit.Size = new System.Drawing.Size(75, 26);
            this.jetiCheckEdit.TabIndex = 132;
            // 
            // shipperTextEdit
            // 
            this.shipperTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spbBindingSource, "shipper", true));
            this.shipperTextEdit.Location = new System.Drawing.Point(697, 82);
            this.shipperTextEdit.Name = "shipperTextEdit";
            this.shipperTextEdit.Properties.ReadOnly = true;
            this.shipperTextEdit.Size = new System.Drawing.Size(100, 26);
            this.shipperTextEdit.TabIndex = 133;
            // 
            // FrmTSpb
            // 
            this.ClientSize = new System.Drawing.Size(899, 695);
            this.DetailBindingSource = this.spbdBindingSource;
            this.DetailTable = this.casDataSet.spbd;
            this.MasterBindingSource = this.spbBindingSource;
            this.MasterTable = this.casDataSet.spb;
            this.Name = "FrmTSpb";
            this.Text = "Surat Perintah Bongkar";
            this.Load += new System.EventHandler(this.FrmTSpb_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.spbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nopolTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nosjTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spbdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.omsTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodocTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglbc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jetiCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipperTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource spbBindingSource;
        private DevExpress.XtraEditors.TextEdit nopolTextEdit;
        private DevExpress.XtraEditors.TextEdit nosjTextEdit;
        private DevExpress.XtraEditors.MemoEdit remarkMemoEdit;
        private System.Windows.Forms.BindingSource spbdBindingSource;
        private KASLibrary.GridControlEx gcSpb;
        private KASLibrary.TextBoxEx omsTextBoxEx;
        private System.Windows.Forms.CheckBox withPOCheckBox;
        private System.Windows.Forms.CheckBox aprovCheckBox;
        private CtrlSub ctrlSub;
        private linkToForm linkToOms;
        private System.Windows.Forms.CheckBox sendgdCheckBox;
        private System.Windows.Forms.Label sendgdLabel;
        private System.Windows.Forms.CheckBox cpoCheckBox;
        private System.Windows.Forms.ComboBox comboStation;
        private System.Windows.Forms.Label Stationlabel;
        private System.Windows.Forms.Button button1;
        private CAS.casDataSetTableAdapters.spbTableAdapter spbTableAdapter;
        private KASLibrary.TextBoxEx nodocTextBoxEx;
        private DevExpress.XtraEditors.DateEdit tglbc;
        private DevExpress.XtraEditors.CheckEdit jetiCheckEdit;
        private DevExpress.XtraEditors.TextEdit shipperTextEdit;
    }
}
