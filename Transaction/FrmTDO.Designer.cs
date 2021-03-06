namespace CAS.Transaction
{
    partial class FrmTDO
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
            System.Windows.Forms.Label closeLabel;
            this.casDataSet = new CAS.casDataSet();
            this.nopolTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dohBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aprovCheckBox = new System.Windows.Forms.CheckBox();
            this.gcDO = new KASLibrary.GridControlEx();
            this.remarkMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.ctrlSub = new CAS.Transaction.CtrlSub();
            this.angkutanTextBoxEx = new KASLibrary.TextBoxEx();
            this.rmsLinkToForm = new CAS.linkToForm();
            this.okl_texboxex = new KASLibrary.TextBoxEx();
            this.dodTableAdapter = new CAS.casDataSetTableAdapters.dodTableAdapter();
            this.dodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dohTableAdapter = new CAS.casDataSetTableAdapters.dohTableAdapter();
            this.closeCheckBox = new System.Windows.Forms.CheckBox();
            remarkLabel = new System.Windows.Forms.Label();
            nopolLabel = new System.Windows.Forms.Label();
            appspmLabel = new System.Windows.Forms.Label();
            angkutanLabel = new System.Windows.Forms.Label();
            closeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludSeri.Properties)).BeginInit();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curkurs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curcur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nopolTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dohBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angkutanTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okl_texboxex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(286, 20);
            this.txtNo.Size = new System.Drawing.Size(85, 26);
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(237, 20);
            this.txtPeriod.Size = new System.Drawing.Size(43, 26);
            // 
            // ludSeri
            // 
            this.ludSeri.Location = new System.Drawing.Point(160, 20);
            this.ludSeri.Size = new System.Drawing.Size(71, 26);
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(closeLabel);
            this.pnlDetail.Controls.Add(this.closeCheckBox);
            this.pnlDetail.Controls.Add(this.angkutanTextBoxEx);
            this.pnlDetail.Controls.Add(angkutanLabel);
            this.pnlDetail.Controls.Add(nopolLabel);
            this.pnlDetail.Controls.Add(this.nopolTextEdit);
            this.pnlDetail.Controls.Add(this.rmsLinkToForm);
            this.pnlDetail.Controls.Add(this.okl_texboxex);
            this.pnlDetail.Controls.Add(this.gcDO);
            this.pnlDetail.Controls.Add(appspmLabel);
            this.pnlDetail.Controls.Add(this.remarkMemoEdit);
            this.pnlDetail.Controls.Add(this.aprovCheckBox);
            this.pnlDetail.Controls.Add(remarkLabel);
            this.pnlDetail.Controls.Add(this.ctrlSub);
            this.pnlDetail.Location = new System.Drawing.Point(0, 88);
            this.pnlDetail.Size = new System.Drawing.Size(728, 465);
            this.pnlDetail.Controls.SetChildIndex(this.ctrlSub, 0);
            this.pnlDetail.Controls.SetChildIndex(remarkLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.aprovCheckBox, 0);
            this.pnlDetail.Controls.SetChildIndex(this.remarkMemoEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(appspmLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.gcDO, 0);
            this.pnlDetail.Controls.SetChildIndex(this.okl_texboxex, 0);
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
            this.pnlDetail.Controls.SetChildIndex(this.closeCheckBox, 0);
            this.pnlDetail.Controls.SetChildIndex(closeLabel, 0);
            // 
            // pnlKey
            // 
            this.pnlKey.Size = new System.Drawing.Size(728, 56);
            // 
            // dateDate
            // 
            this.dateDate.EditValue = new System.DateTime(((long)(0)));
            this.dateDate.Location = new System.Drawing.Point(464, 9);
            this.dateDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateDate.Properties.Mask.IgnoreMaskBlank = false;
            this.dateDate.Size = new System.Drawing.Size(100, 26);
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
            this.curcur.Size = new System.Drawing.Size(57, 26);
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
            remarkLabel.Size = new System.Drawing.Size(88, 19);
            remarkLabel.TabIndex = 34;
            remarkLabel.Text = "Keterangan";
            // 
            // nopolLabel
            // 
            nopolLabel.AutoSize = true;
            nopolLabel.Location = new System.Drawing.Point(407, 38);
            nopolLabel.Name = "nopolLabel";
            nopolLabel.Size = new System.Drawing.Size(71, 19);
            nopolLabel.TabIndex = 46;
            nopolLabel.Text = "No Polisi";
            // 
            // appspmLabel
            // 
            appspmLabel.AutoSize = true;
            appspmLabel.Location = new System.Drawing.Point(280, 146);
            appspmLabel.Name = "appspmLabel";
            appspmLabel.Size = new System.Drawing.Size(69, 19);
            appspmLabel.TabIndex = 53;
            appspmLabel.Text = "Approve";
            // 
            // angkutanLabel
            // 
            angkutanLabel.AutoSize = true;
            angkutanLabel.Location = new System.Drawing.Point(402, 64);
            angkutanLabel.Name = "angkutanLabel";
            angkutanLabel.Size = new System.Drawing.Size(77, 19);
            angkutanLabel.TabIndex = 101;
            angkutanLabel.Text = "Angkutan";
            // 
            // closeLabel
            // 
            closeLabel.AutoSize = true;
            closeLabel.Location = new System.Drawing.Point(297, 12);
            closeLabel.Name = "closeLabel";
            closeLabel.Size = new System.Drawing.Size(47, 19);
            closeLabel.TabIndex = 102;
            closeLabel.Text = "Close";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nopolTextEdit
            // 
            this.nopolTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dohBindingSource, "nopol", true));
            this.nopolTextEdit.Location = new System.Drawing.Point(464, 35);
            this.nopolTextEdit.Name = "nopolTextEdit";
            this.nopolTextEdit.Size = new System.Drawing.Size(100, 26);
            this.nopolTextEdit.TabIndex = 47;
            // 
            // dohBindingSource
            // 
            this.dohBindingSource.DataMember = "doh";
            this.dohBindingSource.DataSource = this.casDataSet;
            // 
            // aprovCheckBox
            // 
            this.aprovCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.dohBindingSource, "aprov", true));
            this.aprovCheckBox.Location = new System.Drawing.Point(338, 141);
            this.aprovCheckBox.Name = "aprovCheckBox";
            this.aprovCheckBox.Size = new System.Drawing.Size(19, 24);
            this.aprovCheckBox.TabIndex = 54;
            // 
            // gcDO
            // 
            this.gcDO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDO.BestFitColumn = true;
            this.gcDO.ExAutoSize = false;
            this.gcDO.Location = new System.Drawing.Point(12, 168);
            this.gcDO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gcDO.Name = "gcDO";
            this.gcDO.Size = new System.Drawing.Size(704, 248);
            this.gcDO.TabIndex = 61;
            // 
            // remarkMemoEdit
            // 
            this.remarkMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dohBindingSource, "remark", true));
            this.remarkMemoEdit.Location = new System.Drawing.Point(464, 102);
            this.remarkMemoEdit.Name = "remarkMemoEdit";
            this.remarkMemoEdit.Size = new System.Drawing.Size(228, 60);
            this.remarkMemoEdit.TabIndex = 86;
            // 
            // ctrlSub
            // 
            this.ctrlSub.Location = new System.Drawing.Point(22, 29);
            this.ctrlSub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlSub.Name = "ctrlSub";
            this.ctrlSub.ReadOnly = true;
            this.ctrlSub.Size = new System.Drawing.Size(335, 115);
            this.ctrlSub.TabIndex = 87;
            this.ctrlSub.Type = CAS.Transaction.CtrlSub.SubType.Customer;
            // 
            // angkutanTextBoxEx
            // 
            this.angkutanTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dohBindingSource, "angkutan", true));
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
            this.angkutanTextBoxEx.Size = new System.Drawing.Size(100, 26);
            this.angkutanTextBoxEx.TabIndex = 102;
            this.angkutanTextBoxEx.EditValueChanged += new System.EventHandler(this.angkutanTextBoxEx_EditValueChanged);
            // 
            // rmsLinkToForm
            // 
            this.rmsLinkToForm.AutoSize = true;
            this.rmsLinkToForm.FormName = "FrmTRms";
            this.rmsLinkToForm.Location = new System.Drawing.Point(33, 12);
            this.rmsLinkToForm.Name = "rmsLinkToForm";
            this.rmsLinkToForm.Size = new System.Drawing.Size(153, 19);
            this.rmsLinkToForm.TabIndex = 88;
            this.rmsLinkToForm.TabStop = true;
            this.rmsLinkToForm.Text = "Sales Order Number";
            this.rmsLinkToForm.TxtKode = this.okl_texboxex;
            // 
            // okl_texboxex
            // 
            this.okl_texboxex.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dohBindingSource, "okl", true));
            this.okl_texboxex.ExAllowEmptyString = true;
            this.okl_texboxex.ExAllowNonDBData = false;
            this.okl_texboxex.ExAutoCheck = false;
            this.okl_texboxex.ExAutoShowResult = false;
            this.okl_texboxex.ExCondition = "";
            this.okl_texboxex.ExDialogTitle = "No. SO";
            this.okl_texboxex.ExFieldName = "Sales Order";
            this.okl_texboxex.ExFilterFields = new string[0];
            this.okl_texboxex.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.okl_texboxex.ExInvalidForeColor = System.Drawing.Color.Black;
            this.okl_texboxex.ExLabelContainer = null;
            this.okl_texboxex.ExLabelField = "Sales Order";
            this.okl_texboxex.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.okl_texboxex.ExLabelText = "";
            this.okl_texboxex.ExLabelVisible = false;
            this.okl_texboxex.ExSelectFields = new string[0];
            this.okl_texboxex.ExShowDialog = true;
            this.okl_texboxex.ExSimpleMode = true;
            this.okl_texboxex.ExSqlInstance = null;
            this.okl_texboxex.ExSqlQuery = "Call SP_SelectOklForSpm(\'OKL\')";
            this.okl_texboxex.ExTableName = "doh";
            this.okl_texboxex.Location = new System.Drawing.Point(148, 8);
            this.okl_texboxex.Name = "okl_texboxex";
            this.okl_texboxex.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.okl_texboxex.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.okl_texboxex.Properties.Appearance.Options.UseBackColor = true;
            this.okl_texboxex.Properties.Appearance.Options.UseForeColor = true;
            this.okl_texboxex.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.okl_texboxex.Size = new System.Drawing.Size(130, 26);
            this.okl_texboxex.TabIndex = 63;
            this.okl_texboxex.EditValueChanged += new System.EventHandler(this.okl_texboxex_EditValueChanged);
            // 
            // dodTableAdapter
            // 
            this.dodTableAdapter.ClearBeforeFill = true;
            // 
            // dodBindingSource
            // 
            this.dodBindingSource.DataMember = "dod";
            this.dodBindingSource.DataSource = this.casDataSet;
            // 
            // dohTableAdapter
            // 
            this.dohTableAdapter.ClearBeforeFill = true;
            // 
            // closeCheckBox
            // 
            this.closeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.dohBindingSource, "close", true));
            this.closeCheckBox.Location = new System.Drawing.Point(338, 7);
            this.closeCheckBox.Name = "closeCheckBox";
            this.closeCheckBox.Size = new System.Drawing.Size(26, 24);
            this.closeCheckBox.TabIndex = 103;
            // 
            // FrmTDO
            // 
            this.ClientSize = new System.Drawing.Size(728, 616);
            this.DetailBindingSource = this.dodBindingSource;
            this.DetailTable = this.casDataSet.dod;
            this.MasterBindingSource = this.dohBindingSource;
            this.MasterTable = this.casDataSet.doh;
            this.Name = "FrmTDO";
            this.Text = "Delivery Order";
            this.Load += new System.EventHandler(this.FrmTdoh_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.nopolTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dohBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angkutanTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okl_texboxex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private System.Windows.Forms.CheckBox aprovCheckBox;
        private DevExpress.XtraEditors.TextEdit nopolTextEdit;
        private KASLibrary.GridControlEx gcDO;
        private DevExpress.XtraEditors.MemoEdit remarkMemoEdit;
        private CtrlSub ctrlSub;
        private KASLibrary.TextBoxEx angkutanTextBoxEx;
        private linkToForm rmsLinkToForm;
        private CAS.casDataSetTableAdapters.dodTableAdapter dodTableAdapter;
        private System.Windows.Forms.BindingSource dohBindingSource;
        private System.Windows.Forms.BindingSource dodBindingSource;
        private KASLibrary.TextBoxEx okl_texboxex;
        private System.Windows.Forms.CheckBox closeCheckBox;
        private CAS.casDataSetTableAdapters.dohTableAdapter dohTableAdapter;
    }
}
