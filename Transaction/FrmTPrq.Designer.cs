namespace CAS.Transaction
{
    partial class FrmTPrq
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
            System.Windows.Forms.Label withPOLabel;
            System.Windows.Forms.Label aprovLabel;
            System.Windows.Forms.Label closeLabel;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label apdateLabel;
            this.prqBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casDataSet = new CAS.casDataSet();
            this.prdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gcPrq = new KASLibrary.GridControlEx();
            this.prqTableAdapter = new CAS.casDataSetTableAdapters.prqTableAdapter();
            this.memoRemark = new DevExpress.XtraEditors.MemoEdit();
            this.prdTableAdapter = new CAS.casDataSetTableAdapters.prdTableAdapter();
            this.withPOCheckBox = new System.Windows.Forms.CheckBox();
            this.aprov2CheckBox = new System.Windows.Forms.CheckBox();
            this.closeCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.personTextBoxEx = new KASLibrary.TextBoxEx();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEx1 = new KASLibrary.TextBoxEx();
            this.aprovCheckBox = new System.Windows.Forms.CheckBox();
            this.apdateTextEdit = new DevExpress.XtraEditors.TextEdit();
            remarkLabel = new System.Windows.Forms.Label();
            withPOLabel = new System.Windows.Forms.Label();
            aprovLabel = new System.Windows.Forms.Label();
            closeLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            apdateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludSeri.Properties)).BeginInit();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curkurs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curcur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prqBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxEx1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apdateTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(202, 20);
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(153, 20);
            // 
            // ludSeri
            // 
            this.ludSeri.Location = new System.Drawing.Point(76, 19);
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.aprovCheckBox);
            this.pnlDetail.Controls.Add(label4);
            this.pnlDetail.Controls.Add(this.label3);
            this.pnlDetail.Controls.Add(this.textBoxEx1);
            this.pnlDetail.Controls.Add(this.label2);
            this.pnlDetail.Controls.Add(this.personTextBoxEx);
            this.pnlDetail.Controls.Add(closeLabel);
            this.pnlDetail.Controls.Add(this.closeCheckBox);
            this.pnlDetail.Controls.Add(aprovLabel);
            this.pnlDetail.Controls.Add(this.aprov2CheckBox);
            this.pnlDetail.Controls.Add(this.memoRemark);
            this.pnlDetail.Controls.Add(remarkLabel);
            this.pnlDetail.Controls.Add(withPOLabel);
            this.pnlDetail.Controls.Add(this.withPOCheckBox);
            this.pnlDetail.Controls.Add(this.gcPrq);
            this.pnlDetail.Location = new System.Drawing.Point(0, 86);
            this.pnlDetail.Size = new System.Drawing.Size(942, 404);
            this.pnlDetail.Controls.SetChildIndex(this.kursLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curLabel1, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curcur, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curkurs, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateDate, 0);
            this.pnlDetail.Controls.SetChildIndex(this.gcPrq, 0);
            this.pnlDetail.Controls.SetChildIndex(this.withPOCheckBox, 0);
            this.pnlDetail.Controls.SetChildIndex(withPOLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(remarkLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.memoRemark, 0);
            this.pnlDetail.Controls.SetChildIndex(this.aprov2CheckBox, 0);
            this.pnlDetail.Controls.SetChildIndex(aprovLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.closeCheckBox, 0);
            this.pnlDetail.Controls.SetChildIndex(closeLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.personTextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(this.label2, 0);
            this.pnlDetail.Controls.SetChildIndex(this.textBoxEx1, 0);
            this.pnlDetail.Controls.SetChildIndex(this.label3, 0);
            this.pnlDetail.Controls.SetChildIndex(label4, 0);
            this.pnlDetail.Controls.SetChildIndex(this.aprovCheckBox, 0);
            // 
            // pnlKey
            // 
            this.pnlKey.Controls.Add(apdateLabel);
            this.pnlKey.Controls.Add(this.apdateTextEdit);
            this.pnlKey.Size = new System.Drawing.Size(942, 61);
            this.pnlKey.Controls.SetChildIndex(this.apdateTextEdit, 0);
            this.pnlKey.Controls.SetChildIndex(this.label1, 0);
            this.pnlKey.Controls.SetChildIndex(apdateLabel, 0);
            this.pnlKey.Controls.SetChildIndex(this.ludSeri, 0);
            this.pnlKey.Controls.SetChildIndex(this.txtNo, 0);
            this.pnlKey.Controls.SetChildIndex(this.txtPeriod, 0);
            this.pnlKey.Controls.SetChildIndex(this.btnDocFlow, 0);
            this.pnlKey.Controls.SetChildIndex(this.lblDeleted, 0);
            // 
            // dateDate
            // 
            this.dateDate.EditValue = null;
            this.dateDate.Location = new System.Drawing.Point(76, 6);
            this.dateDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateDate.Properties.Mask.IgnoreMaskBlank = false;
            this.dateDate.Size = new System.Drawing.Size(93, 23);
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(24, 9);
            // 
            // curkurs
            // 
            this.curkurs.Location = new System.Drawing.Point(532, 67);
            this.curkurs.Visible = false;
            // 
            // curcur
            // 
            this.curcur.Location = new System.Drawing.Point(437, 65);
            this.curcur.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.curcur.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.curcur.Properties.Appearance.Options.UseBackColor = true;
            this.curcur.Properties.Appearance.Options.UseForeColor = true;
            this.curcur.Visible = false;
            // 
            // curLabel1
            // 
            this.curLabel1.Location = new System.Drawing.Point(406, 70);
            this.curLabel1.Visible = false;
            // 
            // kursLabel
            // 
            this.kursLabel.Location = new System.Drawing.Point(500, 70);
            this.kursLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 23);
            // 
            // btnDocFlow
            // 
            this.btnDocFlow.Location = new System.Drawing.Point(566, 16);
            this.btnDocFlow.Visible = true;
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(326, 7);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(63, 13);
            remarkLabel.TabIndex = 38;
            remarkLabel.Text = "Keterangan";
            // 
            // withPOLabel
            // 
            withPOLabel.AutoSize = true;
            withPOLabel.Location = new System.Drawing.Point(22, 43);
            withPOLabel.Name = "withPOLabel";
            withPOLabel.Size = new System.Drawing.Size(46, 13);
            withPOLabel.TabIndex = 40;
            withPOLabel.Text = "With PO";
            // 
            // aprovLabel
            // 
            aprovLabel.AutoSize = true;
            aprovLabel.Enabled = false;
            aprovLabel.Location = new System.Drawing.Point(199, 45);
            aprovLabel.Name = "aprovLabel";
            aprovLabel.Size = new System.Drawing.Size(57, 13);
            aprovLabel.TabIndex = 41;
            aprovLabel.Text = "Approve 2";
            // 
            // closeLabel
            // 
            closeLabel.AutoSize = true;
            closeLabel.Location = new System.Drawing.Point(312, 43);
            closeLabel.Name = "closeLabel";
            closeLabel.Size = new System.Drawing.Size(33, 13);
            closeLabel.TabIndex = 42;
            closeLabel.Text = "Close";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(102, 45);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(57, 13);
            label4.TabIndex = 127;
            label4.Text = "Approve 1";
            // 
            // apdateLabel
            // 
            apdateLabel.AutoSize = true;
            apdateLabel.Location = new System.Drawing.Point(715, 22);
            apdateLabel.Name = "apdateLabel";
            apdateLabel.Size = new System.Drawing.Size(76, 13);
            apdateLabel.TabIndex = 129;
            apdateLabel.Text = "Approval Date";
            // 
            // prqBindingSource
            // 
            this.prqBindingSource.DataMember = "prq";
            this.prqBindingSource.DataSource = this.casDataSet;
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prdBindingSource
            // 
            this.prdBindingSource.DataMember = "prd";
            this.prdBindingSource.DataSource = this.casDataSet;
            // 
            // gcPrq
            // 
            this.gcPrq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcPrq.BestFitColumn = true;
            this.gcPrq.ExAutoSize = false;
            this.gcPrq.Location = new System.Drawing.Point(12, 96);
            this.gcPrq.Name = "gcPrq";
            this.gcPrq.Size = new System.Drawing.Size(918, 288);
            this.gcPrq.TabIndex = 30;
            // 
            // prqTableAdapter
            // 
            this.prqTableAdapter.ClearBeforeFill = true;
            // 
            // memoRemark
            // 
            this.memoRemark.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.prqBindingSource, "remark", true));
            this.memoRemark.Location = new System.Drawing.Point(401, 7);
            this.memoRemark.Name = "memoRemark";
            this.memoRemark.Size = new System.Drawing.Size(283, 53);
            this.memoRemark.TabIndex = 39;
            // 
            // prdTableAdapter
            // 
            this.prdTableAdapter.ClearBeforeFill = true;
            // 
            // withPOCheckBox
            // 
            this.withPOCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.prqBindingSource, "withPO", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.withPOCheckBox.Location = new System.Drawing.Point(76, 41);
            this.withPOCheckBox.Name = "withPOCheckBox";
            this.withPOCheckBox.Size = new System.Drawing.Size(24, 18);
            this.withPOCheckBox.TabIndex = 41;
            // 
            // aprov2CheckBox
            // 
            this.aprov2CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.prqBindingSource, "aprov", true));
            this.aprov2CheckBox.Enabled = false;
            this.aprov2CheckBox.Location = new System.Drawing.Point(262, 43);
            this.aprov2CheckBox.Name = "aprov2CheckBox";
            this.aprov2CheckBox.Size = new System.Drawing.Size(25, 18);
            this.aprov2CheckBox.TabIndex = 42;
            this.aprov2CheckBox.CheckedChanged += new System.EventHandler(this.aprov2CheckBox_CheckedChanged);
            // 
            // closeCheckBox
            // 
            this.closeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.prqBindingSource, "close", true));
            this.closeCheckBox.Location = new System.Drawing.Point(351, 41);
            this.closeCheckBox.Name = "closeCheckBox";
            this.closeCheckBox.Size = new System.Drawing.Size(25, 18);
            this.closeCheckBox.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 124;
            this.label2.Text = "Nama Requisitioner";
            // 
            // personTextBoxEx
            // 
            this.personTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.prqBindingSource, "cct", true));
            this.personTextBoxEx.ExAllowEmptyString = true;
            this.personTextBoxEx.ExAllowNonDBData = false;
            this.personTextBoxEx.ExAutoCheck = true;
            this.personTextBoxEx.ExAutoShowResult = false;
            this.personTextBoxEx.ExCondition = "";
            this.personTextBoxEx.ExDialogTitle = "";
            this.personTextBoxEx.ExFieldName = "usrpr";
            this.personTextBoxEx.ExFilterFields = new string[0];
            this.personTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.personTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.personTextBoxEx.ExLabelContainer = null;
            this.personTextBoxEx.ExLabelField = "name";
            this.personTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.personTextBoxEx.ExLabelText = "";
            this.personTextBoxEx.ExLabelVisible = true;
            this.personTextBoxEx.ExSelectFields = new string[0];
            this.personTextBoxEx.ExShowDialog = true;
            this.personTextBoxEx.ExSimpleMode = true;
            this.personTextBoxEx.ExSqlInstance = null;
            this.personTextBoxEx.ExSqlQuery = "select * from usrpr where aktif=1";
            this.personTextBoxEx.ExTableName = "usrpr";
            this.personTextBoxEx.Location = new System.Drawing.Point(401, 65);
            this.personTextBoxEx.Name = "personTextBoxEx";
            this.personTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.personTextBoxEx.Size = new System.Drawing.Size(99, 20);
            this.personTextBoxEx.TabIndex = 123;
            this.personTextBoxEx.EditValueChanged += new System.EventHandler(this.personTextBoxEx_EditValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 126;
            this.label3.Text = "Memo Number";
            this.label3.Visible = false;
            // 
            // textBoxEx1
            // 
            this.textBoxEx1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.prqBindingSource, "mpr", true));
            this.textBoxEx1.ExAllowEmptyString = true;
            this.textBoxEx1.ExAllowNonDBData = false;
            this.textBoxEx1.ExAutoCheck = true;
            this.textBoxEx1.ExAutoShowResult = false;
            this.textBoxEx1.ExCondition = "";
            this.textBoxEx1.ExDialogTitle = "";
            this.textBoxEx1.ExFieldName = "mpr";
            this.textBoxEx1.ExFilterFields = new string[0];
            this.textBoxEx1.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.textBoxEx1.ExInvalidForeColor = System.Drawing.Color.Black;
            this.textBoxEx1.ExLabelContainer = null;
            this.textBoxEx1.ExLabelField = "remark";
            this.textBoxEx1.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.textBoxEx1.ExLabelText = "";
            this.textBoxEx1.ExLabelVisible = true;
            this.textBoxEx1.ExSelectFields = new string[0];
            this.textBoxEx1.ExShowDialog = true;
            this.textBoxEx1.ExSimpleMode = true;
            this.textBoxEx1.ExSqlInstance = null;
            this.textBoxEx1.ExSqlQuery = "call sp_memo()";
            this.textBoxEx1.ExTableName = "mpr";
            this.textBoxEx1.Location = new System.Drawing.Point(109, 70);
            this.textBoxEx1.Name = "textBoxEx1";
            this.textBoxEx1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.textBoxEx1.Size = new System.Drawing.Size(149, 20);
            this.textBoxEx1.TabIndex = 125;
            this.textBoxEx1.Visible = false;
            this.textBoxEx1.EditValueChanged += new System.EventHandler(this.textBoxEx1_EditValueChanged);
            // 
            // aprovCheckBox
            // 
            this.aprovCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.prqBindingSource, "aprov1", true));
            this.aprovCheckBox.Location = new System.Drawing.Point(165, 41);
            this.aprovCheckBox.Name = "aprovCheckBox";
            this.aprovCheckBox.Size = new System.Drawing.Size(36, 24);
            this.aprovCheckBox.TabIndex = 129;
            this.aprovCheckBox.CheckedChanged += new System.EventHandler(this.aprovCheckBox_CheckedChanged);
            // 
            // apdateTextEdit
            // 
            this.apdateTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.prqBindingSource, "apdate", true));
            this.apdateTextEdit.Enabled = false;
            this.apdateTextEdit.Location = new System.Drawing.Point(797, 19);
            this.apdateTextEdit.Name = "apdateTextEdit";
            this.apdateTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.apdateTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.apdateTextEdit.Properties.Appearance.Options.UseFont = true;
            this.apdateTextEdit.Properties.Appearance.Options.UseForeColor = true;
            this.apdateTextEdit.Size = new System.Drawing.Size(124, 20);
            this.apdateTextEdit.TabIndex = 130;
            // 
            // FrmTPrq
            // 
            this.ClientSize = new System.Drawing.Size(942, 545);
            this.DetailBindingSource = this.prdBindingSource;
            this.DetailTable = this.casDataSet.prd;
            this.MasterBindingSource = this.prqBindingSource;
            this.MasterTable = this.casDataSet.prq;
            this.Name = "FrmTPrq";
            this.Text = "Purchase Request";
            this.Load += new System.EventHandler(this.FrmTPrq_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.prqBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxEx1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apdateTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource prqBindingSource;
        private System.Windows.Forms.BindingSource prdBindingSource;
        private KASLibrary.GridControlEx gcPrq;
        private CAS.casDataSetTableAdapters.prqTableAdapter prqTableAdapter;
        private DevExpress.XtraEditors.MemoEdit memoRemark;
        private CAS.casDataSetTableAdapters.prdTableAdapter prdTableAdapter;
        private System.Windows.Forms.CheckBox withPOCheckBox;
        private System.Windows.Forms.CheckBox closeCheckBox;
        private System.Windows.Forms.CheckBox aprov2CheckBox;
        private System.Windows.Forms.Label label2;
        private KASLibrary.TextBoxEx personTextBoxEx;
        private System.Windows.Forms.Label label3;
        private KASLibrary.TextBoxEx textBoxEx1;
        private System.Windows.Forms.CheckBox aprovCheckBox;
        private DevExpress.XtraEditors.TextEdit apdateTextEdit;
    }
}
