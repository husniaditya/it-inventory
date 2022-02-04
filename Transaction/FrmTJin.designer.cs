namespace CAS.Transaction
{
    partial class FrmTJin
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
            System.Windows.Forms.Label jenisLabel;
            System.Windows.Forms.Label plantLabel;
            System.Windows.Forms.Label bsaLabel;
            this.cctLabel = new System.Windows.Forms.Label();
            this.locLabel = new System.Windows.Forms.Label();
            this.remarkTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.jinBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.casDataSet = new CAS.casDataSet();
            this.jinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cctTextBoxEx = new KASLibrary.TextBoxEx();
            this.locTextBoxEx = new KASLibrary.TextBoxEx();
            this.gcjin = new KASLibrary.GridControlEx();
            this.jinTableAdapter = new CAS.casDataSetTableAdapters.jinTableAdapter();
            this.jidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jidTableAdapter = new CAS.casDataSetTableAdapters.jidTableAdapter();
            this.jenisCheckBox = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.plantComboBox = new System.Windows.Forms.ComboBox();
            this.bsaTextBoxEx = new KASLibrary.TextBoxEx();
            remarkLabel = new System.Windows.Forms.Label();
            jenisLabel = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.remarkTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jinBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cctTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jidBindingSource)).BeginInit();
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
            this.pnlDetail.Controls.Add(this.plantComboBox);
            this.pnlDetail.Controls.Add(plantLabel);
            this.pnlDetail.Controls.Add(this.richTextBox1);
            this.pnlDetail.Controls.Add(this.jenisCheckBox);
            this.pnlDetail.Controls.Add(jenisLabel);
            this.pnlDetail.Controls.Add(this.gcjin);
            this.pnlDetail.Controls.Add(this.locLabel);
            this.pnlDetail.Controls.Add(this.locTextBoxEx);
            this.pnlDetail.Controls.Add(this.cctLabel);
            this.pnlDetail.Controls.Add(this.cctTextBoxEx);
            this.pnlDetail.Controls.Add(remarkLabel);
            this.pnlDetail.Controls.Add(this.remarkTextEdit);
            this.pnlDetail.Size = new System.Drawing.Size(706, 415);
            this.pnlDetail.Controls.SetChildIndex(this.dateDate, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curcur, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curkurs, 0);
            this.pnlDetail.Controls.SetChildIndex(this.kursLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curLabel1, 0);
            this.pnlDetail.Controls.SetChildIndex(this.remarkTextEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(remarkLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.cctTextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(this.cctLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.locTextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(this.locLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.gcjin, 0);
            this.pnlDetail.Controls.SetChildIndex(jenisLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.jenisCheckBox, 0);
            this.pnlDetail.Controls.SetChildIndex(this.richTextBox1, 0);
            this.pnlDetail.Controls.SetChildIndex(plantLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.plantComboBox, 0);
            this.pnlDetail.Controls.SetChildIndex(this.bsaTextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(bsaLabel, 0);
            // 
            // pnlKey
            // 
            this.pnlKey.Controls.Add(this.button1);
            this.pnlKey.Size = new System.Drawing.Size(706, 50);
            this.pnlKey.Controls.SetChildIndex(this.label1, 0);
            this.pnlKey.Controls.SetChildIndex(this.button1, 0);
            this.pnlKey.Controls.SetChildIndex(this.ludSeri, 0);
            this.pnlKey.Controls.SetChildIndex(this.txtNo, 0);
            this.pnlKey.Controls.SetChildIndex(this.txtPeriod, 0);
            this.pnlKey.Controls.SetChildIndex(this.btnDocFlow, 0);
            this.pnlKey.Controls.SetChildIndex(this.lblDeleted, 0);
            // 
            // dateDate
            // 
            this.dateDate.EditValue = new System.DateTime(((long)(0)));
            this.dateDate.Location = new System.Drawing.Point(504, 6);
            this.dateDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.dateDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateDate.Properties.Mask.EditMask = "dd/MM/yyyy HH:mm:ss";
            this.dateDate.Properties.Mask.IgnoreMaskBlank = false;
            this.dateDate.Size = new System.Drawing.Size(150, 26);
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(452, 9);
            // 
            // curkurs
            // 
            this.curkurs.Location = new System.Drawing.Point(603, 32);
            this.curkurs.Visible = false;
            // 
            // curcur
            // 
            this.curcur.Location = new System.Drawing.Point(504, 32);
            this.curcur.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.curcur.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.curcur.Properties.Appearance.Options.UseBackColor = true;
            this.curcur.Properties.Appearance.Options.UseForeColor = true;
            this.curcur.Size = new System.Drawing.Size(57, 26);
            this.curcur.Visible = false;
            // 
            // curLabel1
            // 
            this.curLabel1.Location = new System.Drawing.Point(473, 35);
            this.curLabel1.Visible = false;
            // 
            // kursLabel
            // 
            this.kursLabel.Location = new System.Drawing.Point(567, 35);
            this.kursLabel.Visible = false;
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(24, 104);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(88, 19);
            remarkLabel.TabIndex = 32;
            remarkLabel.Text = "Keterangan";
            // 
            // jenisLabel
            // 
            jenisLabel.AutoSize = true;
            jenisLabel.Location = new System.Drawing.Point(519, 111);
            jenisLabel.Name = "jenisLabel";
            jenisLabel.Size = new System.Drawing.Size(123, 19);
            jenisLabel.TabIndex = 43;
            jenisLabel.Text = "Moving Average";
            // 
            // plantLabel
            // 
            plantLabel.AutoSize = true;
            plantLabel.Location = new System.Drawing.Point(24, 59);
            plantLabel.Name = "plantLabel";
            plantLabel.Size = new System.Drawing.Size(44, 19);
            plantLabel.TabIndex = 45;
            plantLabel.Text = "Plant";
            // 
            // bsaLabel
            // 
            bsaLabel.AutoSize = true;
            bsaLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            bsaLabel.ForeColor = System.Drawing.Color.Red;
            bsaLabel.Location = new System.Drawing.Point(24, 10);
            bsaLabel.Name = "bsaLabel";
            bsaLabel.Size = new System.Drawing.Size(105, 21);
            bsaLabel.TabIndex = 139;
            bsaLabel.Text = "Bisnis Area";
            // 
            // cctLabel
            // 
            this.cctLabel.AutoSize = true;
            this.cctLabel.Location = new System.Drawing.Point(24, 32);
            this.cctLabel.Name = "cctLabel";
            this.cctLabel.Size = new System.Drawing.Size(91, 19);
            this.cctLabel.TabIndex = 33;
            this.cctLabel.Text = "Cost Center";
            // 
            // locLabel
            // 
            this.locLabel.AutoSize = true;
            this.locLabel.Location = new System.Drawing.Point(24, 82);
            this.locLabel.Name = "locLabel";
            this.locLabel.Size = new System.Drawing.Size(64, 19);
            this.locLabel.TabIndex = 34;
            this.locLabel.Text = "Gudang";
            // 
            // remarkTextEdit
            // 
            this.remarkTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jinBindingSource, "remark", true));
            this.remarkTextEdit.Location = new System.Drawing.Point(96, 104);
            this.remarkTextEdit.Name = "remarkTextEdit";
            this.remarkTextEdit.Size = new System.Drawing.Size(370, 26);
            this.remarkTextEdit.TabIndex = 33;
            // 
            // jinBindingSource1
            // 
            this.jinBindingSource1.DataMember = "jin";
            this.jinBindingSource1.DataSource = this.casDataSet;
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jinBindingSource
            // 
            this.jinBindingSource.DataMember = "jin";
            this.jinBindingSource.DataSource = this.casDataSet;
            this.jinBindingSource.Filter = "group_=1";
            // 
            // cctTextBoxEx
            // 
            this.cctTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jinBindingSource, "cct", true));
            this.cctTextBoxEx.ExAllowEmptyString = true;
            this.cctTextBoxEx.ExAllowNonDBData = false;
            this.cctTextBoxEx.ExAutoCheck = true;
            this.cctTextBoxEx.ExAutoShowResult = false;
            this.cctTextBoxEx.ExCondition = "detil=1";
            this.cctTextBoxEx.ExDialogTitle = "";
            this.cctTextBoxEx.ExFieldName = "cct";
            this.cctTextBoxEx.ExFilterFields = new string[0];
            this.cctTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.cctTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.cctTextBoxEx.ExLabelContainer = null;
            this.cctTextBoxEx.ExLabelField = "name";
            this.cctTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.cctTextBoxEx.ExLabelText = "";
            this.cctTextBoxEx.ExLabelVisible = true;
            this.cctTextBoxEx.ExSelectFields = new string[0];
            this.cctTextBoxEx.ExShowDialog = true;
            this.cctTextBoxEx.ExSimpleMode = true;
            this.cctTextBoxEx.ExSqlInstance = null;
            this.cctTextBoxEx.ExSqlQuery = "";
            this.cctTextBoxEx.ExTableName = "cct";
            this.cctTextBoxEx.Location = new System.Drawing.Point(96, 32);
            this.cctTextBoxEx.Name = "cctTextBoxEx";
            this.cctTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.cctTextBoxEx.Size = new System.Drawing.Size(100, 26);
            this.cctTextBoxEx.TabIndex = 34;
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
            this.locTextBoxEx.ExFieldName = "loc";
            this.locTextBoxEx.ExFilterFields = new string[0];
            this.locTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.locTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.locTextBoxEx.ExLabelContainer = null;
            this.locTextBoxEx.ExLabelField = "name";
            this.locTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.locTextBoxEx.ExLabelText = "";
            this.locTextBoxEx.ExLabelVisible = false;
            this.locTextBoxEx.ExSelectFields = new string[0];
            this.locTextBoxEx.ExShowDialog = true;
            this.locTextBoxEx.ExSimpleMode = true;
            this.locTextBoxEx.ExSqlInstance = null;
            this.locTextBoxEx.ExSqlQuery = "";
            this.locTextBoxEx.ExTableName = "loc";
            this.locTextBoxEx.Location = new System.Drawing.Point(96, 82);
            this.locTextBoxEx.Name = "locTextBoxEx";
            this.locTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.locTextBoxEx.Size = new System.Drawing.Size(100, 26);
            this.locTextBoxEx.TabIndex = 35;
            // 
            // gcjin
            // 
            this.gcjin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcjin.BestFitColumn = true;
            this.gcjin.ExAutoSize = false;
            this.gcjin.Location = new System.Drawing.Point(24, 125);
            this.gcjin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gcjin.Name = "gcjin";
            this.gcjin.Size = new System.Drawing.Size(670, 284);
            this.gcjin.TabIndex = 36;
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
            // jenisCheckBox
            // 
            this.jenisCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.jinBindingSource, "jenis", true));
            this.jenisCheckBox.Location = new System.Drawing.Point(498, 106);
            this.jenisCheckBox.Name = "jenisCheckBox";
            this.jenisCheckBox.Size = new System.Drawing.Size(15, 23);
            this.jenisCheckBox.TabIndex = 44;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(498, 66);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(167, 34);
            this.richTextBox1.TabIndex = 45;
            this.richTextBox1.Text = "Centang jika posisi debetnya mengikuti harga moving average";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(604, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 38);
            this.button1.TabIndex = 46;
            this.button1.Text = "update price 0";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // plantComboBox
            // 
            this.plantComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jinBindingSource, "plant", true));
            this.plantComboBox.FormattingEnabled = true;
            this.plantComboBox.Location = new System.Drawing.Point(96, 56);
            this.plantComboBox.Name = "plantComboBox";
            this.plantComboBox.Size = new System.Drawing.Size(121, 28);
            this.plantComboBox.TabIndex = 46;
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
            this.bsaTextBoxEx.Location = new System.Drawing.Point(96, 6);
            this.bsaTextBoxEx.Name = "bsaTextBoxEx";
            this.bsaTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.bsaTextBoxEx.Size = new System.Drawing.Size(81, 26);
            this.bsaTextBoxEx.TabIndex = 140;
            // 
            // FrmTJin
            // 
            this.ClientSize = new System.Drawing.Size(706, 560);
            this.DetailBindingSource = this.jidBindingSource;
            this.DetailTable = this.casDataSet.jid;
            this.MasterBindingSource = this.jinBindingSource;
            this.MasterTable = this.casDataSet.jin;
            this.Name = "FrmTJin";
            this.Text = "Koreksi Persediaan";
            this.Load += new System.EventHandler(this.FrmTjin_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.remarkTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jinBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cctTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jidBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsaTextBoxEx.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource jinBindingSource;
        private CAS.casDataSetTableAdapters.jinTableAdapter jinTableAdapter;
        private DevExpress.XtraEditors.TextEdit remarkTextEdit;
        private KASLibrary.TextBoxEx locTextBoxEx;
        private KASLibrary.TextBoxEx cctTextBoxEx;
        private KASLibrary.GridControlEx gcjin;
        private System.Windows.Forms.BindingSource jidBindingSource;
        private CAS.casDataSetTableAdapters.jidTableAdapter jidTableAdapter;
        private System.Windows.Forms.Label cctLabel;
        private System.Windows.Forms.Label locLabel;
        private System.Windows.Forms.CheckBox jenisCheckBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox plantComboBox;
        private KASLibrary.TextBoxEx bsaTextBoxEx;
        private System.Windows.Forms.BindingSource jinBindingSource1;
    }
}
