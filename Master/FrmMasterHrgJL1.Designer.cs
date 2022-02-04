namespace CAS.Master
{
    partial class FrmMasterHrgJL1
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
            System.Windows.Forms.Label hrgjlLabel;
            System.Windows.Forms.Label grphrgjlLabel;
            System.Windows.Forms.Label tglakhirLabel;
            System.Windows.Forms.Label tglawalLabel;
            System.Windows.Forms.Label aktifLabel;
            System.Windows.Forms.Label label1;
            this.hrgjlTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hrgjlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casDataSet = new CAS.casDataSet();
            this.grphrgjlTextBoxEx = new KASLibrary.TextBoxEx();
            this.gcsubto = new KASLibrary.GridControlEx();
            this.tglakhirDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.tglawalDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.hrgjldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hrgjlTableAdapter = new CAS.casDataSetTableAdapters.hrgjlTableAdapter();
            this.aktifCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxEx1 = new KASLibrary.TextBoxEx();
            hrgjlLabel = new System.Windows.Forms.Label();
            grphrgjlLabel = new System.Windows.Forms.Label();
            tglakhirLabel = new System.Windows.Forms.Label();
            tglawalLabel = new System.Windows.Forms.Label();
            aktifLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hrgjlTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrgjlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grphrgjlTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglakhirDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglawalDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrgjldBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxEx1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.textBoxEx1);
            this.pnlDetail.Controls.Add(this.button1);
            this.pnlDetail.Controls.Add(label1);
            this.pnlDetail.Controls.Add(aktifLabel);
            this.pnlDetail.Controls.Add(this.aktifCheckBox);
            this.pnlDetail.Controls.Add(grphrgjlLabel);
            this.pnlDetail.Controls.Add(this.grphrgjlTextBoxEx);
            this.pnlDetail.Controls.Add(this.gcsubto);
            this.pnlDetail.Controls.Add(tglakhirLabel);
            this.pnlDetail.Controls.Add(this.tglakhirDateEdit);
            this.pnlDetail.Controls.Add(tglawalLabel);
            this.pnlDetail.Controls.Add(this.tglawalDateEdit);
            this.pnlDetail.Location = new System.Drawing.Point(0, 78);
            this.pnlDetail.Size = new System.Drawing.Size(800, 458);
            // 
            // pnlKey
            // 
            this.pnlKey.Controls.Add(hrgjlLabel);
            this.pnlKey.Controls.Add(this.hrgjlTextEdit);
            this.pnlKey.Size = new System.Drawing.Size(800, 53);
            // 
            // hrgjlLabel
            // 
            hrgjlLabel.AutoSize = true;
            hrgjlLabel.Location = new System.Drawing.Point(76, 20);
            hrgjlLabel.Name = "hrgjlLabel";
            hrgjlLabel.Size = new System.Drawing.Size(76, 13);
            hrgjlLabel.TabIndex = 2;
            hrgjlLabel.Text = "Kode Price List";
            // 
            // grphrgjlLabel
            // 
            grphrgjlLabel.AutoSize = true;
            grphrgjlLabel.Location = new System.Drawing.Point(67, 75);
            grphrgjlLabel.Name = "grphrgjlLabel";
            grphrgjlLabel.Size = new System.Drawing.Size(85, 13);
            grphrgjlLabel.TabIndex = 65;
            grphrgjlLabel.Text = "Group Customer";
            // 
            // tglakhirLabel
            // 
            tglakhirLabel.AutoSize = true;
            tglakhirLabel.Location = new System.Drawing.Point(80, 49);
            tglakhirLabel.Name = "tglakhirLabel";
            tglakhirLabel.Size = new System.Drawing.Size(72, 13);
            tglakhirLabel.TabIndex = 63;
            tglakhirLabel.Text = "Tanggal Akhir";
            // 
            // tglawalLabel
            // 
            tglawalLabel.AutoSize = true;
            tglawalLabel.Location = new System.Drawing.Point(81, 23);
            tglawalLabel.Name = "tglawalLabel";
            tglawalLabel.Size = new System.Drawing.Size(71, 13);
            tglawalLabel.TabIndex = 61;
            tglawalLabel.Text = "Tanggal Awal";
            // 
            // aktifLabel
            // 
            aktifLabel.AutoSize = true;
            aktifLabel.Location = new System.Drawing.Point(330, 23);
            aktifLabel.Name = "aktifLabel";
            aktifLabel.Size = new System.Drawing.Size(29, 13);
            aktifLabel.TabIndex = 67;
            aktifLabel.Text = "Aktif";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(484, 71);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(59, 13);
            label1.TabIndex = 69;
            label1.Text = "Copy From";
            // 
            // hrgjlTextEdit
            // 
            this.hrgjlTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hrgjlBindingSource, "hrgjl", true));
            this.hrgjlTextEdit.Location = new System.Drawing.Point(158, 17);
            this.hrgjlTextEdit.Name = "hrgjlTextEdit";
            this.hrgjlTextEdit.Size = new System.Drawing.Size(125, 20);
            this.hrgjlTextEdit.TabIndex = 3;
            this.hrgjlTextEdit.EditValueChanged += new System.EventHandler(this.hrgjlTextEdit_EditValueChanged);
            this.hrgjlTextEdit.Click += new System.EventHandler(this.hrgjlTextEdit_EditValueChanged);
            // 
            // hrgjlBindingSource
            // 
            this.hrgjlBindingSource.DataMember = "hrgjl";
            this.hrgjlBindingSource.DataSource = this.casDataSet;
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grphrgjlTextBoxEx
            // 
            this.grphrgjlTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hrgjlBindingSource, "grphrgjl", true));
            this.grphrgjlTextBoxEx.ExAllowEmptyString = true;
            this.grphrgjlTextBoxEx.ExAllowNonDBData = false;
            this.grphrgjlTextBoxEx.ExAutoCheck = true;
            this.grphrgjlTextBoxEx.ExAutoShowResult = false;
            this.grphrgjlTextBoxEx.ExCondition = "";
            this.grphrgjlTextBoxEx.ExDialogTitle = "";
            this.grphrgjlTextBoxEx.ExFieldName = "grphrgjl";
            this.grphrgjlTextBoxEx.ExFilterFields = new string[0];
            this.grphrgjlTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.grphrgjlTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.grphrgjlTextBoxEx.ExLabelContainer = null;
            this.grphrgjlTextBoxEx.ExLabelField = "keterangan";
            this.grphrgjlTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.grphrgjlTextBoxEx.ExLabelText = "";
            this.grphrgjlTextBoxEx.ExLabelVisible = false;
            this.grphrgjlTextBoxEx.ExSelectFields = new string[0];
            this.grphrgjlTextBoxEx.ExShowDialog = true;
            this.grphrgjlTextBoxEx.ExSimpleMode = false;
            this.grphrgjlTextBoxEx.ExSqlInstance = null;
            this.grphrgjlTextBoxEx.ExSqlQuery = "select grphrgjl,keterangan from grphrgjl";
            this.grphrgjlTextBoxEx.ExTableName = "grhrgjl";
            this.grphrgjlTextBoxEx.Location = new System.Drawing.Point(158, 72);
            this.grphrgjlTextBoxEx.Name = "grphrgjlTextBoxEx";
            this.grphrgjlTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.grphrgjlTextBoxEx.Size = new System.Drawing.Size(125, 20);
            this.grphrgjlTextBoxEx.TabIndex = 67;
            // 
            // gcsubto
            // 
            this.gcsubto.BestFitColumn = true;
            this.gcsubto.ExAutoSize = false;
            this.gcsubto.Location = new System.Drawing.Point(28, 109);
            this.gcsubto.Name = "gcsubto";
            this.gcsubto.Size = new System.Drawing.Size(760, 343);
            this.gcsubto.TabIndex = 66;
            // 
            // tglakhirDateEdit
            // 
            this.tglakhirDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hrgjlBindingSource, "tglakhir", true));
            this.tglakhirDateEdit.EditValue = null;
            this.tglakhirDateEdit.Location = new System.Drawing.Point(158, 46);
            this.tglakhirDateEdit.Name = "tglakhirDateEdit";
            this.tglakhirDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tglakhirDateEdit.Size = new System.Drawing.Size(125, 23);
            this.tglakhirDateEdit.TabIndex = 64;
            // 
            // tglawalDateEdit
            // 
            this.tglawalDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hrgjlBindingSource, "tglawal", true));
            this.tglawalDateEdit.EditValue = null;
            this.tglawalDateEdit.Location = new System.Drawing.Point(158, 20);
            this.tglawalDateEdit.Name = "tglawalDateEdit";
            this.tglawalDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tglawalDateEdit.Size = new System.Drawing.Size(125, 23);
            this.tglawalDateEdit.TabIndex = 62;
            // 
            // hrgjldBindingSource
            // 
            this.hrgjldBindingSource.DataMember = "hrgjld";
            this.hrgjldBindingSource.DataSource = this.casDataSet;
            // 
            // hrgjlTableAdapter
            // 
            this.hrgjlTableAdapter.ClearBeforeFill = true;
            // 
            // aktifCheckBox
            // 
            this.aktifCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.hrgjlBindingSource, "aktif", true));
            this.aktifCheckBox.Location = new System.Drawing.Point(365, 18);
            this.aktifCheckBox.Name = "aktifCheckBox";
            this.aktifCheckBox.Size = new System.Drawing.Size(104, 24);
            this.aktifCheckBox.TabIndex = 68;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(679, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 20);
            this.button1.TabIndex = 71;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxEx1
            // 
            this.textBoxEx1.ExAllowEmptyString = true;
            this.textBoxEx1.ExAllowNonDBData = false;
            this.textBoxEx1.ExAutoCheck = true;
            this.textBoxEx1.ExAutoShowResult = false;
            this.textBoxEx1.ExCondition = "";
            this.textBoxEx1.ExDialogTitle = "";
            this.textBoxEx1.ExFieldName = "hrgjl";
            this.textBoxEx1.ExFilterFields = new string[0];
            this.textBoxEx1.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.textBoxEx1.ExInvalidForeColor = System.Drawing.Color.Black;
            this.textBoxEx1.ExLabelContainer = null;
            this.textBoxEx1.ExLabelField = "";
            this.textBoxEx1.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.textBoxEx1.ExLabelText = "";
            this.textBoxEx1.ExLabelVisible = false;
            this.textBoxEx1.ExSelectFields = new string[0];
            this.textBoxEx1.ExShowDialog = true;
            this.textBoxEx1.ExSimpleMode = false;
            this.textBoxEx1.ExSqlInstance = null;
            this.textBoxEx1.ExSqlQuery = "select * from hrgjl";
            this.textBoxEx1.ExTableName = "hrgjl";
            this.textBoxEx1.Location = new System.Drawing.Point(549, 69);
            this.textBoxEx1.Name = "textBoxEx1";
            this.textBoxEx1.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxEx1.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.textBoxEx1.Properties.Appearance.Options.UseBackColor = true;
            this.textBoxEx1.Properties.Appearance.Options.UseForeColor = true;
            this.textBoxEx1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.textBoxEx1.Size = new System.Drawing.Size(123, 20);
            this.textBoxEx1.TabIndex = 72;
            // 
            // FrmMasterHrgJL1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 603);
            this.MasterBindingSource = this.hrgjlBindingSource;
            this.MasterQuery = "select * from hrgjl";
            this.MasterTable = this.casDataSet.hrgjl;
            this.Name = "FrmMasterHrgJL1";
            this.Load += new System.EventHandler(this.FrmMasterHrgJL1_Load);
            this.Click += new System.EventHandler(this.FrmMasterHrgJL1_Click);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.pnlKey.ResumeLayout(false);
            this.pnlKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hrgjlTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrgjlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grphrgjlTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglakhirDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglawalDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrgjldBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxEx1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit hrgjlTextEdit;
        private KASLibrary.TextBoxEx grphrgjlTextBoxEx;
        private KASLibrary.GridControlEx gcsubto;
        private DevExpress.XtraEditors.DateEdit tglakhirDateEdit;
        private DevExpress.XtraEditors.DateEdit tglawalDateEdit;
        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource hrgjldBindingSource;
        private System.Windows.Forms.BindingSource hrgjlBindingSource;
        private CAS.casDataSetTableAdapters.hrgjlTableAdapter hrgjlTableAdapter;
        private System.Windows.Forms.CheckBox aktifCheckBox;
        private System.Windows.Forms.Button button1;
        private KASLibrary.TextBoxEx textBoxEx1;
    }
}
