namespace CAS.Transaction
{
    partial class FrmTSpm
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
            System.Windows.Forms.Label appspmLabel;
            System.Windows.Forms.Label angkutanLabel;
            System.Windows.Forms.Label tglproformaLabel;
            System.Windows.Forms.Label label3;
            this.casDataSet = new CAS.casDataSet();
            this.spmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nopolTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.aprovCheckBox = new System.Windows.Forms.CheckBox();
            this.spdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gcSpm = new KASLibrary.GridControlEx();
            this.remarkMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.ctrlSub = new CAS.Transaction.CtrlSub();
            this.spmTableAdapter = new CAS.casDataSetTableAdapters.spmTableAdapter();
            this.angkutanTextBoxEx = new KASLibrary.TextBoxEx();
            this.rmsLinkToForm = new CAS.linkToForm();
            this.okl_rmaTextBoxEx = new KASLibrary.TextBoxEx();
            this.tglbc = new DevExpress.XtraEditors.DateEdit();
            this.nodocTextBoxEx = new KASLibrary.TextBoxEx();
            remarkLabel = new System.Windows.Forms.Label();
            nopolLabel = new System.Windows.Forms.Label();
            appspmLabel = new System.Windows.Forms.Label();
            angkutanLabel = new System.Windows.Forms.Label();
            tglproformaLabel = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.spmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nopolTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angkutanTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okl_rmaTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglbc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodocTextBoxEx.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(286, 20);
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(237, 20);
            // 
            // ludSeri
            // 
            this.ludSeri.Location = new System.Drawing.Point(160, 20);
            this.ludSeri.Size = new System.Drawing.Size(71, 26);
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.nodocTextBoxEx);
            this.pnlDetail.Controls.Add(label3);
            this.pnlDetail.Controls.Add(this.angkutanTextBoxEx);
            this.pnlDetail.Controls.Add(angkutanLabel);
            this.pnlDetail.Controls.Add(nopolLabel);
            this.pnlDetail.Controls.Add(this.nopolTextEdit);
            this.pnlDetail.Controls.Add(this.rmsLinkToForm);
            this.pnlDetail.Controls.Add(this.okl_rmaTextBoxEx);
            this.pnlDetail.Controls.Add(tglproformaLabel);
            this.pnlDetail.Controls.Add(this.gcSpm);
            this.pnlDetail.Controls.Add(this.tglbc);
            this.pnlDetail.Controls.Add(this.remarkMemoEdit);
            this.pnlDetail.Controls.Add(this.aprovCheckBox);
            this.pnlDetail.Controls.Add(remarkLabel);
            this.pnlDetail.Controls.Add(this.ctrlSub);
            this.pnlDetail.Controls.Add(appspmLabel);
            this.pnlDetail.Location = new System.Drawing.Point(0, 88);
            this.pnlDetail.Size = new System.Drawing.Size(822, 465);
            this.pnlDetail.Controls.SetChildIndex(appspmLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.ctrlSub, 0);
            this.pnlDetail.Controls.SetChildIndex(remarkLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.aprovCheckBox, 0);
            this.pnlDetail.Controls.SetChildIndex(this.remarkMemoEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(this.tglbc, 0);
            this.pnlDetail.Controls.SetChildIndex(this.gcSpm, 0);
            this.pnlDetail.Controls.SetChildIndex(tglproformaLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.okl_rmaTextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(this.rmsLinkToForm, 0);
            this.pnlDetail.Controls.SetChildIndex(this.nopolTextEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(nopolLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(angkutanLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.angkutanTextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateDate, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curcur, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curkurs, 0);
            this.pnlDetail.Controls.SetChildIndex(this.kursLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curLabel1, 0);
            this.pnlDetail.Controls.SetChildIndex(label3, 0);
            this.pnlDetail.Controls.SetChildIndex(this.nodocTextBoxEx, 0);
            // 
            // pnlKey
            // 
            this.pnlKey.Size = new System.Drawing.Size(822, 56);
            // 
            // dateDate
            // 
            this.dateDate.EditValue = new System.DateTime(((long)(0)));
            this.dateDate.Location = new System.Drawing.Point(464, 9);
            this.dateDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateDate.Properties.Mask.IgnoreMaskBlank = false;
            this.dateDate.EditValueChanged += new System.EventHandler(this.dateDate_EditValueChanged);
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(412, 12);
            // 
            // curkurs
            // 
            this.curkurs.Location = new System.Drawing.Point(619, 185);
            this.curkurs.Visible = false;
            // 
            // curcur
            // 
            this.curcur.Location = new System.Drawing.Point(520, 185);
            this.curcur.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.curcur.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.curcur.Properties.Appearance.Options.UseBackColor = true;
            this.curcur.Properties.Appearance.Options.UseForeColor = true;
            this.curcur.Visible = false;
            // 
            // curLabel1
            // 
            this.curLabel1.Location = new System.Drawing.Point(489, 188);
            this.curLabel1.Visible = false;
            // 
            // kursLabel
            // 
            this.kursLabel.Location = new System.Drawing.Point(583, 188);
            this.kursLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(106, 23);
            // 
            // btnDocFlow
            // 
            this.btnDocFlow.Visible = true;
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(396, 104);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(63, 13);
            remarkLabel.TabIndex = 34;
            remarkLabel.Text = "Keterangan";
            // 
            // nopolLabel
            // 
            nopolLabel.AutoSize = true;
            nopolLabel.Location = new System.Drawing.Point(407, 38);
            nopolLabel.Name = "nopolLabel";
            nopolLabel.Size = new System.Drawing.Size(46, 13);
            nopolLabel.TabIndex = 46;
            nopolLabel.Text = "No Polisi";
            // 
            // appspmLabel
            // 
            appspmLabel.AutoSize = true;
            appspmLabel.Location = new System.Drawing.Point(270, 166);
            appspmLabel.Name = "appspmLabel";
            appspmLabel.Size = new System.Drawing.Size(48, 13);
            appspmLabel.TabIndex = 53;
            appspmLabel.Text = "Approve";
            appspmLabel.Click += new System.EventHandler(this.appspmLabel_Click);
            // 
            // angkutanLabel
            // 
            angkutanLabel.AutoSize = true;
            angkutanLabel.Location = new System.Drawing.Point(402, 64);
            angkutanLabel.Name = "angkutanLabel";
            angkutanLabel.Size = new System.Drawing.Size(53, 13);
            angkutanLabel.TabIndex = 101;
            angkutanLabel.Text = "Angkutan";
            // 
            // tglproformaLabel
            // 
            tglproformaLabel.AutoSize = true;
            tglproformaLabel.Location = new System.Drawing.Point(594, 13);
            tglproformaLabel.Name = "tglproformaLabel";
            tglproformaLabel.Size = new System.Drawing.Size(101, 13);
            tglproformaLabel.TabIndex = 134;
            tglproformaLabel.Text = "Tgl Rekam Beacukai";
            tglproformaLabel.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(594, 42);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(104, 13);
            label3.TabIndex = 136;
            label3.Text = "Dokumen Pelabuhan";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spmBindingSource
            // 
            this.spmBindingSource.DataMember = "spm";
            this.spmBindingSource.DataSource = this.casDataSet;
            this.spmBindingSource.Filter = "";
            // 
            // nopolTextEdit
            // 
            this.nopolTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spmBindingSource, "nopol", true));
            this.nopolTextEdit.Location = new System.Drawing.Point(464, 35);
            this.nopolTextEdit.Name = "nopolTextEdit";
            this.nopolTextEdit.Size = new System.Drawing.Size(100, 20);
            this.nopolTextEdit.TabIndex = 47;
            // 
            // aprovCheckBox
            // 
            this.aprovCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.spmBindingSource, "aprov", true));
            this.aprovCheckBox.Location = new System.Drawing.Point(341, 161);
            this.aprovCheckBox.Name = "aprovCheckBox";
            this.aprovCheckBox.Size = new System.Drawing.Size(19, 24);
            this.aprovCheckBox.TabIndex = 54;
            this.aprovCheckBox.CheckedChanged += new System.EventHandler(this.appspmCheckBox_CheckedChanged);
            // 
            // spdBindingSource
            // 
            this.spdBindingSource.DataMember = "spd";
            this.spdBindingSource.DataSource = this.casDataSet;
            // 
            // gcSpm
            // 
            this.gcSpm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcSpm.BestFitColumn = true;
            this.gcSpm.ExAutoSize = false;
            this.gcSpm.Location = new System.Drawing.Point(12, 191);
            this.gcSpm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gcSpm.Name = "gcSpm";
            this.gcSpm.Size = new System.Drawing.Size(798, 225);
            this.gcSpm.TabIndex = 61;
            // 
            // remarkMemoEdit
            // 
            this.remarkMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spmBindingSource, "remark", true));
            this.remarkMemoEdit.Location = new System.Drawing.Point(464, 102);
            this.remarkMemoEdit.Name = "remarkMemoEdit";
            this.remarkMemoEdit.Size = new System.Drawing.Size(228, 60);
            this.remarkMemoEdit.TabIndex = 86;
            // 
            // ctrlSub
            // 
            this.ctrlSub.Location = new System.Drawing.Point(22, 39);
            this.ctrlSub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlSub.Name = "ctrlSub";
            this.ctrlSub.ReadOnly = true;
            this.ctrlSub.Size = new System.Drawing.Size(335, 115);
            this.ctrlSub.TabIndex = 87;
            this.ctrlSub.Type = CAS.Transaction.CtrlSub.SubType.All;
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
            this.angkutanTextBoxEx.Location = new System.Drawing.Point(464, 61);
            this.angkutanTextBoxEx.Name = "angkutanTextBoxEx";
            this.angkutanTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.angkutanTextBoxEx.Size = new System.Drawing.Size(100, 20);
            this.angkutanTextBoxEx.TabIndex = 102;
            // 
            // rmsLinkToForm
            // 
            this.rmsLinkToForm.AutoSize = true;
            this.rmsLinkToForm.FormName = "FrmTRms";
            this.rmsLinkToForm.Location = new System.Drawing.Point(33, 12);
            this.rmsLinkToForm.Name = "rmsLinkToForm";
            this.rmsLinkToForm.Size = new System.Drawing.Size(51, 13);
            this.rmsLinkToForm.TabIndex = 88;
            this.rmsLinkToForm.TabStop = true;
            this.rmsLinkToForm.Text = "PO Retur";
            this.rmsLinkToForm.TxtKode = this.okl_rmaTextBoxEx;
            // 
            // okl_rmaTextBoxEx
            // 
            this.okl_rmaTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spmBindingSource, "okl_rms", true));
            this.okl_rmaTextBoxEx.ExAllowEmptyString = true;
            this.okl_rmaTextBoxEx.ExAllowNonDBData = false;
            this.okl_rmaTextBoxEx.ExAutoCheck = false;
            this.okl_rmaTextBoxEx.ExAutoShowResult = false;
            this.okl_rmaTextBoxEx.ExCondition = "";
            this.okl_rmaTextBoxEx.ExDialogTitle = "PO Retur";
            this.okl_rmaTextBoxEx.ExFieldName = "PO Retur";
            this.okl_rmaTextBoxEx.ExFilterFields = new string[0];
            this.okl_rmaTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.okl_rmaTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.okl_rmaTextBoxEx.ExLabelContainer = null;
            this.okl_rmaTextBoxEx.ExLabelField = "";
            this.okl_rmaTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.okl_rmaTextBoxEx.ExLabelText = "";
            this.okl_rmaTextBoxEx.ExLabelVisible = false;
            this.okl_rmaTextBoxEx.ExSelectFields = new string[0];
            this.okl_rmaTextBoxEx.ExShowDialog = true;
            this.okl_rmaTextBoxEx.ExSimpleMode = true;
            this.okl_rmaTextBoxEx.ExSqlInstance = null;
            this.okl_rmaTextBoxEx.ExSqlQuery = "Call SP_SelectRmsForSpm()";
            this.okl_rmaTextBoxEx.ExTableName = "rms";
            this.okl_rmaTextBoxEx.Location = new System.Drawing.Point(90, 9);
            this.okl_rmaTextBoxEx.Name = "okl_rmaTextBoxEx";
            this.okl_rmaTextBoxEx.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.okl_rmaTextBoxEx.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.okl_rmaTextBoxEx.Properties.Appearance.Options.UseBackColor = true;
            this.okl_rmaTextBoxEx.Properties.Appearance.Options.UseForeColor = true;
            this.okl_rmaTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.okl_rmaTextBoxEx.Size = new System.Drawing.Size(130, 20);
            this.okl_rmaTextBoxEx.TabIndex = 63;
            this.okl_rmaTextBoxEx.EditValueChanged += new System.EventHandler(this.okl_rkaTextBoxEx_EditValueChanged);
            // 
            // tglbc
            // 
            this.tglbc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spmBindingSource, "tgl_bc", true));
            this.tglbc.EditValue = null;
            this.tglbc.Location = new System.Drawing.Point(701, 9);
            this.tglbc.Name = "tglbc";
            this.tglbc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tglbc.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.tglbc.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.tglbc.Properties.EditFormat.FormatString = "d";
            this.tglbc.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.tglbc.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.tglbc.Size = new System.Drawing.Size(100, 23);
            this.tglbc.TabIndex = 135;
            this.tglbc.Visible = false;
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
            this.nodocTextBoxEx.Location = new System.Drawing.Point(598, 61);
            this.nodocTextBoxEx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nodocTextBoxEx.Name = "nodocTextBoxEx";
            this.nodocTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.nodocTextBoxEx.Size = new System.Drawing.Size(200, 20);
            this.nodocTextBoxEx.TabIndex = 137;
            this.nodocTextBoxEx.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.nodocTextBoxEx_ButtonPressed);
            // 
            // FrmTSpm
            // 
            this.ClientSize = new System.Drawing.Size(822, 616);
            this.DetailBindingSource = this.spdBindingSource;
            this.DetailTable = this.casDataSet.spd;
            this.MasterBindingSource = this.spmBindingSource;
            this.MasterTable = this.casDataSet.spm;
            this.Name = "FrmTSpm";
            this.Text = "SPM Pengiriman Retur";
            this.Load += new System.EventHandler(this.FrmTSpm_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.spmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nopolTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angkutanTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okl_rmaTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglbc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodocTextBoxEx.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource spmBindingSource;
        private System.Windows.Forms.CheckBox aprovCheckBox;
        private DevExpress.XtraEditors.TextEdit nopolTextEdit;
        private System.Windows.Forms.BindingSource spdBindingSource;
        private KASLibrary.GridControlEx gcSpm;
        private DevExpress.XtraEditors.MemoEdit remarkMemoEdit;
        private CtrlSub ctrlSub;
        private CAS.casDataSetTableAdapters.spmTableAdapter spmTableAdapter;
        private KASLibrary.TextBoxEx angkutanTextBoxEx;
        private linkToForm rmsLinkToForm;
        private KASLibrary.TextBoxEx okl_rmaTextBoxEx;
        private DevExpress.XtraEditors.DateEdit tglbc;
        private KASLibrary.TextBoxEx nodocTextBoxEx;
    }
}
