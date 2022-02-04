namespace CAS.Transaction
{
    partial class FrmTSpmJual
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
            System.Windows.Forms.Label nopolLabel;
            System.Windows.Forms.Label angkutanLabel;
            System.Windows.Forms.Label cpoLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label no_conLabel;
            System.Windows.Forms.Label tglproformaLabel;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.spmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casDataSet = new CAS.casDataSet();
            this.remarkMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.aprovCheckBox = new System.Windows.Forms.CheckBox();
            this.nopolTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.spdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spmTableAdapter = new CAS.casDataSetTableAdapters.spmTableAdapter();
            this.angkutanTextBoxEx = new KASLibrary.TextBoxEx();
            this.gcSpm = new KASLibrary.GridControlEx();
            this.sendgdCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.angkutanTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.cpoCheckBox = new System.Windows.Forms.CheckBox();
            this.Stationlabel = new System.Windows.Forms.Label();
            this.comboStation = new System.Windows.Forms.ComboBox();
            this.rmsLinkToForm = new CAS.linkToForm();
            this.oklTextBoxEx = new KASLibrary.TextBoxEx();
            this.nodocTextBoxEx = new KASLibrary.TextBoxEx();
            this.no_conTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tglbc = new DevExpress.XtraEditors.DateEdit();
            this.ctrlSub = new CAS.Transaction.CtrlSub();
            this.txtTotalqty = new DevExpress.XtraEditors.TextEdit();
            this.globalBoxEx = new KASLibrary.TextBoxEx();
            this.txtTotalqtykemasan = new DevExpress.XtraEditors.TextEdit();
            remarkLabel = new System.Windows.Forms.Label();
            nopolLabel = new System.Windows.Forms.Label();
            angkutanLabel = new System.Windows.Forms.Label();
            cpoLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            no_conLabel = new System.Windows.Forms.Label();
            tglproformaLabel = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludSeri.Properties)).BeginInit();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curkurs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curcur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nopolTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angkutanTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angkutanTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oklTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodocTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_conTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglbc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalqty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalqtykemasan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(326, 22);
            this.txtNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNo.Size = new System.Drawing.Size(128, 26);
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(252, 22);
            this.txtPeriod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPeriod.Size = new System.Drawing.Size(64, 26);
            // 
            // ludSeri
            // 
            this.ludSeri.Location = new System.Drawing.Point(136, 22);
            this.ludSeri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ludSeri.Size = new System.Drawing.Size(106, 26);
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.txtTotalqtykemasan);
            this.pnlDetail.Controls.Add(label5);
            this.pnlDetail.Controls.Add(this.globalBoxEx);
            this.pnlDetail.Controls.Add(label4);
            this.pnlDetail.Controls.Add(this.txtTotalqty);
            this.pnlDetail.Controls.Add(label6);
            this.pnlDetail.Controls.Add(tglproformaLabel);
            this.pnlDetail.Controls.Add(this.tglbc);
            this.pnlDetail.Controls.Add(no_conLabel);
            this.pnlDetail.Controls.Add(this.no_conTextEdit);
            this.pnlDetail.Controls.Add(this.nodocTextBoxEx);
            this.pnlDetail.Controls.Add(label3);
            this.pnlDetail.Controls.Add(this.rmsLinkToForm);
            this.pnlDetail.Controls.Add(this.oklTextBoxEx);
            this.pnlDetail.Controls.Add(this.Stationlabel);
            this.pnlDetail.Controls.Add(this.comboStation);
            this.pnlDetail.Controls.Add(cpoLabel);
            this.pnlDetail.Controls.Add(this.cpoCheckBox);
            this.pnlDetail.Controls.Add(this.angkutanTextEdit);
            this.pnlDetail.Controls.Add(this.label2);
            this.pnlDetail.Controls.Add(this.sendgdCheckBox);
            this.pnlDetail.Controls.Add(this.gcSpm);
            this.pnlDetail.Controls.Add(this.angkutanTextBoxEx);
            this.pnlDetail.Controls.Add(this.aprovCheckBox);
            this.pnlDetail.Controls.Add(nopolLabel);
            this.pnlDetail.Controls.Add(this.nopolTextEdit);
            this.pnlDetail.Controls.Add(angkutanLabel);
            this.pnlDetail.Controls.Add(this.ctrlSub);
            this.pnlDetail.Controls.Add(this.remarkMemoEdit);
            this.pnlDetail.Controls.Add(remarkLabel);
            this.pnlDetail.Location = new System.Drawing.Point(0, 100);
            this.pnlDetail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlDetail.Size = new System.Drawing.Size(1224, 763);
            this.pnlDetail.Controls.SetChildIndex(remarkLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.remarkMemoEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(this.ctrlSub, 0);
            this.pnlDetail.Controls.SetChildIndex(angkutanLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.nopolTextEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(nopolLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.aprovCheckBox, 0);
            this.pnlDetail.Controls.SetChildIndex(this.angkutanTextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(this.gcSpm, 0);
            this.pnlDetail.Controls.SetChildIndex(this.sendgdCheckBox, 0);
            this.pnlDetail.Controls.SetChildIndex(this.label2, 0);
            this.pnlDetail.Controls.SetChildIndex(this.angkutanTextEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(this.cpoCheckBox, 0);
            this.pnlDetail.Controls.SetChildIndex(cpoLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.comboStation, 0);
            this.pnlDetail.Controls.SetChildIndex(this.Stationlabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.oklTextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(this.rmsLinkToForm, 0);
            this.pnlDetail.Controls.SetChildIndex(label3, 0);
            this.pnlDetail.Controls.SetChildIndex(this.nodocTextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(this.no_conTextEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(no_conLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.tglbc, 0);
            this.pnlDetail.Controls.SetChildIndex(tglproformaLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateDate, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curcur, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curkurs, 0);
            this.pnlDetail.Controls.SetChildIndex(this.kursLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curLabel1, 0);
            this.pnlDetail.Controls.SetChildIndex(label6, 0);
            this.pnlDetail.Controls.SetChildIndex(this.txtTotalqty, 0);
            this.pnlDetail.Controls.SetChildIndex(label4, 0);
            this.pnlDetail.Controls.SetChildIndex(this.globalBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(label5, 0);
            this.pnlDetail.Controls.SetChildIndex(this.txtTotalqtykemasan, 0);
            // 
            // pnlKey
            // 
            this.pnlKey.Controls.Add(this.button1);
            this.pnlKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlKey.Size = new System.Drawing.Size(1224, 68);
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
            this.dateDate.Location = new System.Drawing.Point(694, 11);
            this.dateDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateDate.Properties.Mask.IgnoreMaskBlank = false;
            this.dateDate.Size = new System.Drawing.Size(150, 26);
            this.dateDate.EditValueChanged += new System.EventHandler(this.dateDate_EditValueChanged);
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(616, 14);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // curkurs
            // 
            this.curkurs.Location = new System.Drawing.Point(962, 146);
            this.curkurs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.curkurs.Size = new System.Drawing.Size(110, 26);
            this.curkurs.Visible = false;
            // 
            // curcur
            // 
            this.curcur.Location = new System.Drawing.Point(813, 146);
            this.curcur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.curcur.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.curcur.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.curcur.Properties.Appearance.Options.UseBackColor = true;
            this.curcur.Properties.Appearance.Options.UseForeColor = true;
            this.curcur.Size = new System.Drawing.Size(86, 26);
            this.curcur.Visible = false;
            // 
            // curLabel1
            // 
            this.curLabel1.Location = new System.Drawing.Point(766, 151);
            this.curLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.curLabel1.Visible = false;
            // 
            // kursLabel
            // 
            this.kursLabel.Location = new System.Drawing.Point(908, 151);
            this.kursLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kursLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(74, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // btnDocFlow
            // 
            this.btnDocFlow.Location = new System.Drawing.Point(694, 18);
            this.btnDocFlow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDocFlow.Size = new System.Drawing.Size(129, 35);
            this.btnDocFlow.Visible = true;
            // 
            // lblDeleted
            // 
            this.lblDeleted.Location = new System.Drawing.Point(524, 22);
            this.lblDeleted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(36, 225);
            remarkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(88, 19);
            remarkLabel.TabIndex = 88;
            remarkLabel.Text = "Keterangan";
            // 
            // nopolLabel
            // 
            nopolLabel.AutoSize = true;
            nopolLabel.Location = new System.Drawing.Point(609, 55);
            nopolLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nopolLabel.Name = "nopolLabel";
            nopolLabel.Size = new System.Drawing.Size(71, 19);
            nopolLabel.TabIndex = 93;
            nopolLabel.Text = "No Polisi";
            // 
            // angkutanLabel
            // 
            angkutanLabel.AutoSize = true;
            angkutanLabel.Location = new System.Drawing.Point(602, 100);
            angkutanLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            angkutanLabel.Name = "angkutanLabel";
            angkutanLabel.Size = new System.Drawing.Size(77, 19);
            angkutanLabel.TabIndex = 95;
            angkutanLabel.Text = "Angkutan";
            // 
            // cpoLabel
            // 
            cpoLabel.AutoSize = true;
            cpoLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            cpoLabel.Location = new System.Drawing.Point(374, 12);
            cpoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cpoLabel.Name = "cpoLabel";
            cpoLabel.Size = new System.Drawing.Size(127, 22);
            cpoLabel.TabIndex = 108;
            cpoLabel.Text = "Material CPO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(880, 96);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(155, 19);
            label3.TabIndex = 117;
            label3.Text = "Dokumen Pelabuhan";
            // 
            // no_conLabel
            // 
            no_conLabel.AutoSize = true;
            no_conLabel.Location = new System.Drawing.Point(874, 60);
            no_conLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            no_conLabel.Name = "no_conLabel";
            no_conLabel.Size = new System.Drawing.Size(102, 19);
            no_conLabel.TabIndex = 118;
            no_conLabel.Text = "No Container";
            // 
            // tglproformaLabel
            // 
            tglproformaLabel.AutoSize = true;
            tglproformaLabel.Location = new System.Drawing.Point(896, 17);
            tglproformaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tglproformaLabel.Name = "tglproformaLabel";
            tglproformaLabel.Size = new System.Drawing.Size(151, 19);
            tglproformaLabel.TabIndex = 132;
            tglproformaLabel.Text = "Tgl Rekam Beacukai";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(1099, 248);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(75, 19);
            label6.TabIndex = 135;
            label6.Text = "Total Qty";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(880, 160);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(108, 19);
            label4.TabIndex = 136;
            label4.Text = "Barang Global";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(864, 248);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(102, 19);
            label5.TabIndex = 139;
            label5.Text = "Qty Kemasan";
            // 
            // spmBindingSource
            // 
            this.spmBindingSource.DataMember = "spm";
            this.spmBindingSource.DataSource = this.casDataSet;
            this.spmBindingSource.Filter = "group_=1";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // remarkMemoEdit
            // 
            this.remarkMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spmBindingSource, "remark", true));
            this.remarkMemoEdit.Location = new System.Drawing.Point(136, 220);
            this.remarkMemoEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.remarkMemoEdit.Name = "remarkMemoEdit";
            this.remarkMemoEdit.Size = new System.Drawing.Size(406, 63);
            this.remarkMemoEdit.TabIndex = 91;
            // 
            // aprovCheckBox
            // 
            this.aprovCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.spmBindingSource, "aprov", true));
            this.aprovCheckBox.Location = new System.Drawing.Point(694, 145);
            this.aprovCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aprovCheckBox.Name = "aprovCheckBox";
            this.aprovCheckBox.Size = new System.Drawing.Size(52, 37);
            this.aprovCheckBox.TabIndex = 98;
            this.aprovCheckBox.CheckedChanged += new System.EventHandler(this.appspmCheckBox_CheckedChanged);
            // 
            // nopolTextEdit
            // 
            this.nopolTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spmBindingSource, "nopol", true));
            this.nopolTextEdit.Location = new System.Drawing.Point(694, 51);
            this.nopolTextEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nopolTextEdit.Name = "nopolTextEdit";
            this.nopolTextEdit.Size = new System.Drawing.Size(150, 26);
            this.nopolTextEdit.TabIndex = 94;
            // 
            // spdBindingSource
            // 
            this.spdBindingSource.DataMember = "spd";
            this.spdBindingSource.DataSource = this.casDataSet;
            // 
            // spmTableAdapter
            // 
            this.spmTableAdapter.ClearBeforeFill = true;
            // 
            // angkutanTextBoxEx
            // 
            this.angkutanTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spmBindingSource, "angkutan", true));
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
            this.angkutanTextBoxEx.Location = new System.Drawing.Point(694, 95);
            this.angkutanTextBoxEx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.angkutanTextBoxEx.Name = "angkutanTextBoxEx";
            this.angkutanTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.angkutanTextBoxEx.Size = new System.Drawing.Size(150, 26);
            this.angkutanTextBoxEx.TabIndex = 100;
            // 
            // gcSpm
            // 
            this.gcSpm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcSpm.BestFitColumn = true;
            this.gcSpm.ExAutoSize = false;
            this.gcSpm.Location = new System.Drawing.Point(18, 289);
            this.gcSpm.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.gcSpm.Name = "gcSpm";
            this.gcSpm.Size = new System.Drawing.Size(1188, 461);
            this.gcSpm.TabIndex = 101;
            // 
            // sendgdCheckBox
            // 
            this.sendgdCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.spmBindingSource, "sendgd", true));
            this.sendgdCheckBox.Location = new System.Drawing.Point(694, 240);
            this.sendgdCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sendgdCheckBox.Name = "sendgdCheckBox";
            this.sendgdCheckBox.Size = new System.Drawing.Size(150, 37);
            this.sendgdCheckBox.TabIndex = 102;
            this.sendgdCheckBox.Text = "Send to PLC";
            this.sendgdCheckBox.Click += new System.EventHandler(this.sendgdCheckBox_Click);
            this.sendgdCheckBox.CheckedChanged += new System.EventHandler(this.sendgdCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(612, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 103;
            this.label2.Text = "Approve";
            // 
            // angkutanTextEdit
            // 
            this.angkutanTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spmBindingSource, "angkutan", true));
            this.angkutanTextEdit.Location = new System.Drawing.Point(858, 95);
            this.angkutanTextEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.angkutanTextEdit.Name = "angkutanTextEdit";
            this.angkutanTextEdit.Size = new System.Drawing.Size(280, 26);
            this.angkutanTextEdit.TabIndex = 105;
            this.angkutanTextEdit.Visible = false;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(874, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 34);
            this.button1.TabIndex = 106;
            this.button1.Text = "Check Flow Meter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cpoCheckBox
            // 
            this.cpoCheckBox.Checked = true;
            this.cpoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cpoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spmBindingSource, "cpo", true));
            this.cpoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.spmBindingSource, "cpo", true));
            this.cpoCheckBox.Location = new System.Drawing.Point(510, 6);
            this.cpoCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cpoCheckBox.Name = "cpoCheckBox";
            this.cpoCheckBox.Size = new System.Drawing.Size(33, 37);
            this.cpoCheckBox.TabIndex = 110;
            this.cpoCheckBox.CheckedChanged += new System.EventHandler(this.cpoCheckBox_CheckedChanged);
            // 
            // Stationlabel
            // 
            this.Stationlabel.AutoSize = true;
            this.Stationlabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Stationlabel.Location = new System.Drawing.Point(591, 203);
            this.Stationlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Stationlabel.Name = "Stationlabel";
            this.Stationlabel.Size = new System.Drawing.Size(92, 22);
            this.Stationlabel.TabIndex = 112;
            this.Stationlabel.Text = "STATION";
            // 
            // comboStation
            // 
            this.comboStation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spmBindingSource, "station", true));
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
            this.comboStation.Location = new System.Drawing.Point(693, 198);
            this.comboStation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboStation.Name = "comboStation";
            this.comboStation.Size = new System.Drawing.Size(108, 28);
            this.comboStation.TabIndex = 111;
            this.comboStation.SelectedIndexChanged += new System.EventHandler(this.comboStation_SelectedIndexChanged);
            this.comboStation.Click += new System.EventHandler(this.comboStation_Click);
            // 
            // rmsLinkToForm
            // 
            this.rmsLinkToForm.AutoSize = true;
            this.rmsLinkToForm.FormName = "FrmTRms";
            this.rmsLinkToForm.Location = new System.Drawing.Point(14, 12);
            this.rmsLinkToForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rmsLinkToForm.Name = "rmsLinkToForm";
            this.rmsLinkToForm.Size = new System.Drawing.Size(112, 19);
            this.rmsLinkToForm.TabIndex = 114;
            this.rmsLinkToForm.TabStop = true;
            this.rmsLinkToForm.Text = "Delivery Order";
            this.rmsLinkToForm.TxtKode = this.oklTextBoxEx;
            // 
            // oklTextBoxEx
            // 
            this.oklTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spmBindingSource, "okl_rms", true));
            this.oklTextBoxEx.ExAllowEmptyString = true;
            this.oklTextBoxEx.ExAllowNonDBData = false;
            this.oklTextBoxEx.ExAutoCheck = false;
            this.oklTextBoxEx.ExAutoShowResult = false;
            this.oklTextBoxEx.ExCondition = "";
            this.oklTextBoxEx.ExDialogTitle = "DO Number";
            this.oklTextBoxEx.ExFieldName = "DO Number";
            this.oklTextBoxEx.ExFilterFields = new string[0];
            this.oklTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.oklTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.oklTextBoxEx.ExLabelContainer = null;
            this.oklTextBoxEx.ExLabelField = "DO Number";
            this.oklTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.oklTextBoxEx.ExLabelText = "";
            this.oklTextBoxEx.ExLabelVisible = false;
            this.oklTextBoxEx.ExSelectFields = new string[0];
            this.oklTextBoxEx.ExShowDialog = true;
            this.oklTextBoxEx.ExSimpleMode = true;
            this.oklTextBoxEx.ExSqlInstance = null;
            this.oklTextBoxEx.ExSqlQuery = "Call SP_SelectOklForSpm(\'tdo\')";
            this.oklTextBoxEx.ExTableName = "okl_rms";
            this.oklTextBoxEx.Location = new System.Drawing.Point(136, 9);
            this.oklTextBoxEx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.oklTextBoxEx.Name = "oklTextBoxEx";
            this.oklTextBoxEx.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.oklTextBoxEx.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.oklTextBoxEx.Properties.Appearance.Options.UseBackColor = true;
            this.oklTextBoxEx.Properties.Appearance.Options.UseForeColor = true;
            this.oklTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.oklTextBoxEx.Size = new System.Drawing.Size(195, 26);
            this.oklTextBoxEx.TabIndex = 113;
            this.oklTextBoxEx.EditValueChanged += new System.EventHandler(this.oklTextBoxEx_EditValueChanged);
            // 
            // nodocTextBoxEx
            // 
            this.nodocTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spmBindingSource, "nodoc", true));
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
            this.nodocTextBoxEx.Location = new System.Drawing.Point(884, 124);
            this.nodocTextBoxEx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nodocTextBoxEx.Name = "nodocTextBoxEx";
            this.nodocTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.nodocTextBoxEx.Size = new System.Drawing.Size(200, 26);
            this.nodocTextBoxEx.TabIndex = 118;
            this.nodocTextBoxEx.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.nodocTextBoxEx_ButtonPressed);
            // 
            // no_conTextEdit
            // 
            this.no_conTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spmBindingSource, "no_con", true));
            this.no_conTextEdit.Location = new System.Drawing.Point(986, 55);
            this.no_conTextEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.no_conTextEdit.Name = "no_conTextEdit";
            this.no_conTextEdit.Size = new System.Drawing.Size(150, 26);
            this.no_conTextEdit.TabIndex = 119;
            // 
            // tglbc
            // 
            this.tglbc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spmBindingSource, "tgl_bc", true));
            this.tglbc.EditValue = null;
            this.tglbc.Location = new System.Drawing.Point(1056, 11);
            this.tglbc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tglbc.Name = "tglbc";
            this.tglbc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tglbc.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.tglbc.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.tglbc.Properties.EditFormat.FormatString = "d";
            this.tglbc.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.tglbc.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.tglbc.Size = new System.Drawing.Size(150, 26);
            this.tglbc.TabIndex = 133;
            // 
            // ctrlSub
            // 
            this.ctrlSub.Location = new System.Drawing.Point(40, 38);
            this.ctrlSub.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.ctrlSub.Name = "ctrlSub";
            this.ctrlSub.ReadOnly = true;
            this.ctrlSub.Size = new System.Drawing.Size(502, 175);
            this.ctrlSub.TabIndex = 92;
            this.ctrlSub.Type = CAS.Transaction.CtrlSub.SubType.Customer;
            // 
            // txtTotalqty
            // 
            this.txtTotalqty.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spmBindingSource, "totqty", true));
            this.txtTotalqty.Location = new System.Drawing.Point(1180, 244);
            this.txtTotalqty.Name = "txtTotalqty";
            this.txtTotalqty.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtTotalqty.Properties.Appearance.Options.UseFont = true;
            this.txtTotalqty.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotalqty.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotalqty.Size = new System.Drawing.Size(121, 27);
            this.txtTotalqty.TabIndex = 134;
            // 
            // globalBoxEx
            // 
            this.globalBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spmBindingSource, "kodeglobal", true));
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
            this.globalBoxEx.ExSqlQuery = "select inv,name from inv where group_ = 5 AND remark = \'GLOBAL\'";
            this.globalBoxEx.ExTableName = "inv";
            this.globalBoxEx.Location = new System.Drawing.Point(884, 187);
            this.globalBoxEx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.globalBoxEx.Name = "globalBoxEx";
            this.globalBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.globalBoxEx.Size = new System.Drawing.Size(200, 26);
            this.globalBoxEx.TabIndex = 137;
            // 
            // txtTotalqtykemasan
            // 
            this.txtTotalqtykemasan.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spmBindingSource, "totqtykemasan", true));
            this.txtTotalqtykemasan.Location = new System.Drawing.Point(972, 244);
            this.txtTotalqtykemasan.Name = "txtTotalqtykemasan";
            this.txtTotalqtykemasan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtTotalqtykemasan.Properties.Appearance.Options.UseFont = true;
            this.txtTotalqtykemasan.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotalqtykemasan.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotalqtykemasan.Size = new System.Drawing.Size(121, 27);
            this.txtTotalqtykemasan.TabIndex = 138;
            // 
            // FrmTSpmJual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 926);
            this.DetailBindingSource = this.spdBindingSource;
            this.DetailTable = this.casDataSet.spd;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MasterBindingSource = this.spmBindingSource;
            this.MasterTable = this.casDataSet.spm;
            this.Name = "FrmTSpmJual";
            this.Text = "SPM Penjualan";
            this.Load += new System.EventHandler(this.FrmTSpmJual_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.spmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nopolTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angkutanTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angkutanTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oklTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodocTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_conTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglbc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalqty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalqtykemasan.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit remarkMemoEdit;
        private System.Windows.Forms.CheckBox aprovCheckBox;
        private DevExpress.XtraEditors.TextEdit nopolTextEdit;
        private System.Windows.Forms.BindingSource spmBindingSource;
        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource spdBindingSource;
        private KASLibrary.TextBoxEx angkutanTextBoxEx;
        private CAS.casDataSetTableAdapters.spmTableAdapter spmTableAdapter;
        private KASLibrary.GridControlEx gcSpm;
        private System.Windows.Forms.CheckBox sendgdCheckBox;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit angkutanTextEdit;
        private System.Windows.Forms.CheckBox cpoCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Stationlabel;
        private System.Windows.Forms.ComboBox comboStation;
        private linkToForm rmsLinkToForm;
        private KASLibrary.TextBoxEx oklTextBoxEx;
        private KASLibrary.TextBoxEx nodocTextBoxEx;
        private DevExpress.XtraEditors.TextEdit no_conTextEdit;
        private DevExpress.XtraEditors.DateEdit tglbc;
        private CtrlSub ctrlSub;
        private DevExpress.XtraEditors.TextEdit txtTotalqty;
        private KASLibrary.TextBoxEx globalBoxEx;
        private DevExpress.XtraEditors.TextEdit txtTotalqtykemasan;
    }
}