namespace CAS.Transaction
{
    partial class FrmDocPelabuhan
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label jnspLabel;
            System.Windows.Forms.Label omsLabel;
            System.Windows.Forms.Label formLabel;
            this.casDataSet = new CAS.casDataSet();
            this.remarkMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.docpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gcRFD = new KASLibrary.GridControlEx();
            this.docpTableAdapter = new CAS.casDataSetTableAdapters.docpTableAdapter();
            this.docpdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.docpdTableAdapter = new CAS.casDataSetTableAdapters.docpdTableAdapter();
            this.omsTextBoxEx = new KASLibrary.TextBoxEx();
            this.jnspTextBoxEx = new KASLibrary.TextBoxEx();
            this.formTextEdit = new DevExpress.XtraEditors.TextEdit();
            label2 = new System.Windows.Forms.Label();
            jnspLabel = new System.Windows.Forms.Label();
            omsLabel = new System.Windows.Forms.Label();
            formLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludSeri.Properties)).BeginInit();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curkurs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curcur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docpdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.omsTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jnspTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNo
            // 
            // 
            // txtPeriod
            // 
            // 
            // ludSeri
            // 
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(formLabel);
            this.pnlDetail.Controls.Add(this.formTextEdit);
            this.pnlDetail.Controls.Add(this.jnspTextBoxEx);
            this.pnlDetail.Controls.Add(omsLabel);
            this.pnlDetail.Controls.Add(this.omsTextBoxEx);
            this.pnlDetail.Controls.Add(jnspLabel);
            this.pnlDetail.Controls.Add(this.gcRFD);
            this.pnlDetail.Controls.Add(this.remarkMemoEdit);
            this.pnlDetail.Controls.Add(label2);
            this.pnlDetail.Size = new System.Drawing.Size(798, 479);
            this.pnlDetail.Controls.SetChildIndex(this.curcur, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curkurs, 0);
            this.pnlDetail.Controls.SetChildIndex(this.kursLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curLabel1, 0);
            this.pnlDetail.Controls.SetChildIndex(label2, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.remarkMemoEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateDate, 0);
            this.pnlDetail.Controls.SetChildIndex(this.gcRFD, 0);
            this.pnlDetail.Controls.SetChildIndex(jnspLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.omsTextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(omsLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.jnspTextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(this.formTextEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(formLabel, 0);
            // 
            // pnlKey
            // 
            this.pnlKey.Size = new System.Drawing.Size(798, 50);
            // 
            // dateDate
            // 
            this.dateDate.EditValue = new System.DateTime(((long)(0)));
            this.dateDate.Location = new System.Drawing.Point(488, 9);
            this.dateDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateDate.Properties.Mask.IgnoreMaskBlank = false;
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(436, 12);
            // 
            // curkurs
            // 
            this.curkurs.Location = new System.Drawing.Point(587, 35);
            this.curkurs.Visible = false;
            // 
            // curcur
            // 
            this.curcur.Location = new System.Drawing.Point(488, 35);
            this.curcur.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.curcur.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.curcur.Properties.Appearance.Options.UseBackColor = true;
            this.curcur.Properties.Appearance.Options.UseForeColor = true;
            this.curcur.Visible = false;
            this.curcur.EditValueChanged += new System.EventHandler(this.curcur_EditValueChanged);
            // 
            // curLabel1
            // 
            this.curLabel1.Location = new System.Drawing.Point(457, 38);
            this.curLabel1.Visible = false;
            // 
            // kursLabel
            // 
            this.kursLabel.Location = new System.Drawing.Point(551, 38);
            this.kursLabel.Visible = false;
            // 
            // btnDocFlow
            // 
            this.btnDocFlow.Visible = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(43, 109);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(63, 13);
            label2.TabIndex = 117;
            label2.Text = "Keterangan";
            // 
            // jnspLabel
            // 
            jnspLabel.AutoSize = true;
            jnspLabel.Location = new System.Drawing.Point(15, 81);
            jnspLabel.Name = "jnspLabel";
            jnspLabel.Size = new System.Drawing.Size(91, 13);
            jnspLabel.TabIndex = 131;
            jnspLabel.Text = "Jenis Doc Pabean";
            // 
            // omsLabel
            // 
            omsLabel.AutoSize = true;
            omsLabel.Location = new System.Drawing.Point(50, 34);
            omsLabel.Name = "omsLabel";
            omsLabel.Size = new System.Drawing.Size(56, 13);
            omsLabel.TabIndex = 132;
            omsLabel.Text = "No Orders";
            // 
            // formLabel
            // 
            formLabel.AutoSize = true;
            formLabel.Location = new System.Drawing.Point(436, 93);
            formLabel.Name = "formLabel";
            formLabel.Size = new System.Drawing.Size(90, 13);
            formLabel.TabIndex = 134;
            formLabel.Text = "Keterangan Form";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // remarkMemoEdit
            // 
            this.remarkMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.docpBindingSource, "remmark", true));
            this.remarkMemoEdit.Location = new System.Drawing.Point(115, 104);
            this.remarkMemoEdit.Name = "remarkMemoEdit";
            this.remarkMemoEdit.Size = new System.Drawing.Size(271, 56);
            this.remarkMemoEdit.TabIndex = 118;
            // 
            // docpBindingSource
            // 
            this.docpBindingSource.DataMember = "docp";
            this.docpBindingSource.DataSource = this.casDataSet;
            // 
            // gcRFD
            // 
            this.gcRFD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcRFD.BestFitColumn = true;
            this.gcRFD.ExAutoSize = false;
            this.gcRFD.Location = new System.Drawing.Point(18, 186);
            this.gcRFD.Name = "gcRFD";
            this.gcRFD.Size = new System.Drawing.Size(765, 287);
            this.gcRFD.TabIndex = 129;
            // 
            // docpTableAdapter
            // 
            this.docpTableAdapter.ClearBeforeFill = true;
            // 
            // docpdBindingSource
            // 
            this.docpdBindingSource.DataMember = "docpd";
            this.docpdBindingSource.DataSource = this.casDataSet;
            // 
            // docpdTableAdapter
            // 
            this.docpdTableAdapter.ClearBeforeFill = true;
            // 
            // omsTextBoxEx
            // 
            this.omsTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.docpBindingSource, "oms", true));
            this.omsTextBoxEx.ExAllowEmptyString = true;
            this.omsTextBoxEx.ExAllowNonDBData = false;
            this.omsTextBoxEx.ExAutoCheck = true;
            this.omsTextBoxEx.ExAutoShowResult = false;
            this.omsTextBoxEx.ExCondition = "";
            this.omsTextBoxEx.ExDialogTitle = "";
            this.omsTextBoxEx.ExFieldName = "oms";
            this.omsTextBoxEx.ExFilterFields = new string[0];
            this.omsTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.omsTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.omsTextBoxEx.ExLabelContainer = null;
            this.omsTextBoxEx.ExLabelField = "name";
            this.omsTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.omsTextBoxEx.ExLabelText = "";
            this.omsTextBoxEx.ExLabelVisible = true;
            this.omsTextBoxEx.ExSelectFields = new string[0];
            this.omsTextBoxEx.ExShowDialog = true;
            this.omsTextBoxEx.ExSimpleMode = true;
            this.omsTextBoxEx.ExSqlInstance = null;
            this.omsTextBoxEx.ExSqlQuery = "select oms,name from oms,sub where oms.sub=sub.sub";
            this.omsTextBoxEx.ExTableName = "";
            this.omsTextBoxEx.Location = new System.Drawing.Point(115, 31);
            this.omsTextBoxEx.Name = "omsTextBoxEx";
            this.omsTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.omsTextBoxEx.Size = new System.Drawing.Size(143, 20);
            this.omsTextBoxEx.TabIndex = 133;
            this.omsTextBoxEx.EditValueChanged += new System.EventHandler(this.omsTextBoxEx_EditValueChanged);
            // 
            // jnspTextBoxEx
            // 
            this.jnspTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.docpBindingSource, "jnsp", true));
            this.jnspTextBoxEx.ExAllowEmptyString = true;
            this.jnspTextBoxEx.ExAllowNonDBData = false;
            this.jnspTextBoxEx.ExAutoCheck = true;
            this.jnspTextBoxEx.ExAutoShowResult = false;
            this.jnspTextBoxEx.ExCondition = "";
            this.jnspTextBoxEx.ExDialogTitle = "";
            this.jnspTextBoxEx.ExFieldName = "jnsp";
            this.jnspTextBoxEx.ExFilterFields = new string[0];
            this.jnspTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.jnspTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.jnspTextBoxEx.ExLabelContainer = null;
            this.jnspTextBoxEx.ExLabelField = "jnsp";
            this.jnspTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.jnspTextBoxEx.ExLabelText = "";
            this.jnspTextBoxEx.ExLabelVisible = false;
            this.jnspTextBoxEx.ExSelectFields = new string[0];
            this.jnspTextBoxEx.ExShowDialog = true;
            this.jnspTextBoxEx.ExSimpleMode = true;
            this.jnspTextBoxEx.ExSqlInstance = null;
            this.jnspTextBoxEx.ExSqlQuery = "select * from jnsp";
            this.jnspTextBoxEx.ExTableName = "";
            this.jnspTextBoxEx.Location = new System.Drawing.Point(115, 78);
            this.jnspTextBoxEx.Name = "jnspTextBoxEx";
            this.jnspTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.jnspTextBoxEx.Size = new System.Drawing.Size(100, 20);
            this.jnspTextBoxEx.TabIndex = 134;
            // 
            // formTextEdit
            // 
            this.formTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.docpBindingSource, "form", true));
            this.formTextEdit.Location = new System.Drawing.Point(532, 90);
            this.formTextEdit.Name = "formTextEdit";
            this.formTextEdit.Properties.MaxLength = 50;
            this.formTextEdit.Size = new System.Drawing.Size(254, 20);
            this.formTextEdit.TabIndex = 135;
            //this.formTextEdit.Click += new System.EventHandler(this.formTextEdit_Click);
            // 
            // FrmDocPelabuhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 609);
            this.DetailBindingSource = this.docpdBindingSource;
            this.DetailTable = this.casDataSet.docpd;
            this.MasterBindingSource = this.docpBindingSource;
            this.MasterTable = this.casDataSet.docp;
            this.Name = "FrmDocPelabuhan";
            this.Text = "Frm Document Pabean";
            this.Load += new System.EventHandler(this.FrmDocP_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docpdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.omsTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jnspTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private DevExpress.XtraEditors.MemoEdit remarkMemoEdit;
        private KASLibrary.GridControlEx gcRFD;
        private System.Windows.Forms.BindingSource docpBindingSource;
        private CAS.casDataSetTableAdapters.docpTableAdapter docpTableAdapter;
        private System.Windows.Forms.BindingSource docpdBindingSource;
        private CAS.casDataSetTableAdapters.docpdTableAdapter docpdTableAdapter;
        private KASLibrary.TextBoxEx omsTextBoxEx;
        private KASLibrary.TextBoxEx jnspTextBoxEx;
        private DevExpress.XtraEditors.TextEdit formTextEdit;
    }
}