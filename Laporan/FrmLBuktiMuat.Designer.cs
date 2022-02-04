namespace CAS.Laporan
{
    partial class FrmLBuktiMuat
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
            System.Windows.Forms.Label angkutanLabel;
            System.Windows.Forms.Label label1;
            this.dtpTglAkhir = new DevExpress.XtraEditors.DateEdit();
            this.dtpTglAwal = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAngkutanAkhir = new KASLibrary.TextBoxEx();
            this.txtAngkutanAwal = new KASLibrary.TextBoxEx();
            this.txtSubAkhir = new KASLibrary.TextBoxEx();
            this.txtSubAwal = new KASLibrary.TextBoxEx();
            this.rbtnDA = new System.Windows.Forms.RadioButton();
            this.rbtnTA = new System.Windows.Forms.RadioButton();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            angkutanLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAwal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAngkutanAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAngkutanAwal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubAwal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.LookAndFeel.SkinName = "";
            this.btnClose.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.LookAndFeel.UseWindowsXPTheme = false;
            this.btnClose.TabIndex = 7;
            // 
            // btnPreview
            // 
            this.btnPreview.LookAndFeel.SkinName = "";
            this.btnPreview.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btnPreview.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnPreview.LookAndFeel.UseWindowsXPTheme = false;
            this.btnPreview.TabIndex = 6;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // printControl
            // 
            this.printControl.Location = new System.Drawing.Point(0, 160);
            this.printControl.Size = new System.Drawing.Size(718, 360);
            // 
            // printPreviewBar
            // 
            this.printPreviewBar.Size = new System.Drawing.Size(718, 28);
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.rbtnAll);
            this.pnlFilter.Controls.Add(this.rbtnTA);
            this.pnlFilter.Controls.Add(this.rbtnDA);
            this.pnlFilter.Controls.Add(label1);
            this.pnlFilter.Controls.Add(this.txtAngkutanAkhir);
            this.pnlFilter.Controls.Add(this.txtAngkutanAwal);
            this.pnlFilter.Controls.Add(angkutanLabel);
            this.pnlFilter.Controls.Add(this.dtpTglAkhir);
            this.pnlFilter.Controls.Add(this.dtpTglAwal);
            this.pnlFilter.Controls.Add(this.label3);
            this.pnlFilter.Controls.Add(this.label2);
            this.pnlFilter.Controls.Add(this.txtSubAkhir);
            this.pnlFilter.Controls.Add(this.txtSubAwal);
            this.pnlFilter.LookAndFeel.SkinName = "";
            this.pnlFilter.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.pnlFilter.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlFilter.LookAndFeel.UseWindowsXPTheme = false;
            this.pnlFilter.Controls.SetChildIndex(this.txtSubAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtSubAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label2, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label3, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dtpTglAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dtpTglAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(angkutanLabel, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtAngkutanAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtAngkutanAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(label1, 0);
            this.pnlFilter.Controls.SetChildIndex(this.rbtnDA, 0);
            this.pnlFilter.Controls.SetChildIndex(this.btnPreview, 0);
            this.pnlFilter.Controls.SetChildIndex(this.btnClose, 0);
            this.pnlFilter.Controls.SetChildIndex(this.rbtnTA, 0);
            this.pnlFilter.Controls.SetChildIndex(this.rbtnAll, 0);
            // 
            // angkutanLabel
            // 
            angkutanLabel.AutoSize = true;
            angkutanLabel.Location = new System.Drawing.Point(44, 75);
            angkutanLabel.Name = "angkutanLabel";
            angkutanLabel.Size = new System.Drawing.Size(53, 13);
            angkutanLabel.TabIndex = 140;
            angkutanLabel.Text = "Angkutan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(13, 104);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(86, 13);
            label1.TabIndex = 141;
            label1.Text = "Pilihan Angkutan";
            // 
            // dtpTglAkhir
            // 
            this.dtpTglAkhir.EditValue = new System.DateTime(2008, 10, 11, 0, 0, 0, 0);
            this.dtpTglAkhir.Location = new System.Drawing.Point(374, 13);
            this.dtpTglAkhir.Name = "dtpTglAkhir";
            this.dtpTglAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTglAkhir.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAkhir.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAkhir.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAkhir.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAkhir.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtpTglAkhir.Size = new System.Drawing.Size(114, 20);
            this.dtpTglAkhir.TabIndex = 1;
            // 
            // dtpTglAwal
            // 
            this.dtpTglAwal.EditValue = new System.DateTime(2008, 10, 11, 0, 0, 0, 0);
            this.dtpTglAwal.Location = new System.Drawing.Point(105, 12);
            this.dtpTglAwal.Name = "dtpTglAwal";
            this.dtpTglAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTglAwal.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAwal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAwal.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAwal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAwal.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtpTglAwal.Size = new System.Drawing.Size(114, 20);
            this.dtpTglAwal.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tanggal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Supplier/Customer";
            // 
            // txtAngkutanAkhir
            // 
            this.txtAngkutanAkhir.ExAllowEmptyString = true;
            this.txtAngkutanAkhir.ExAllowNonDBData = false;
            this.txtAngkutanAkhir.ExAutoCheck = true;
            this.txtAngkutanAkhir.ExAutoShowResult = false;
            this.txtAngkutanAkhir.ExCondition = "group_=1 and aktif=1";
            this.txtAngkutanAkhir.ExDialogTitle = "Select Supplier Angkutan";
            this.txtAngkutanAkhir.ExFieldName = "Kode";
            this.txtAngkutanAkhir.ExFilterFields = new string[0];
            this.txtAngkutanAkhir.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtAngkutanAkhir.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtAngkutanAkhir.ExLabelContainer = null;
            this.txtAngkutanAkhir.ExLabelField = "Nama";
            this.txtAngkutanAkhir.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtAngkutanAkhir.ExLabelText = "";
            this.txtAngkutanAkhir.ExLabelVisible = true;
            this.txtAngkutanAkhir.ExSelectFields = new string[0];
            this.txtAngkutanAkhir.ExShowDialog = true;
            this.txtAngkutanAkhir.ExSimpleMode = true;
            this.txtAngkutanAkhir.ExSqlInstance = null;
            this.txtAngkutanAkhir.ExSqlQuery = "Call SP_LookUp(\'angkutan\')";
            this.txtAngkutanAkhir.ExTableName = "sub";
            this.txtAngkutanAkhir.Location = new System.Drawing.Point(374, 73);
            this.txtAngkutanAkhir.Name = "txtAngkutanAkhir";
            this.txtAngkutanAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtAngkutanAkhir.Size = new System.Drawing.Size(114, 20);
            this.txtAngkutanAkhir.TabIndex = 5;
            // 
            // txtAngkutanAwal
            // 
            this.txtAngkutanAwal.ExAllowEmptyString = true;
            this.txtAngkutanAwal.ExAllowNonDBData = false;
            this.txtAngkutanAwal.ExAutoCheck = true;
            this.txtAngkutanAwal.ExAutoShowResult = false;
            this.txtAngkutanAwal.ExCondition = "group_=1 and aktif=1";
            this.txtAngkutanAwal.ExDialogTitle = "Select Supplier Angkutan";
            this.txtAngkutanAwal.ExFieldName = "Kode";
            this.txtAngkutanAwal.ExFilterFields = new string[0];
            this.txtAngkutanAwal.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtAngkutanAwal.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtAngkutanAwal.ExLabelContainer = null;
            this.txtAngkutanAwal.ExLabelField = "Nama";
            this.txtAngkutanAwal.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtAngkutanAwal.ExLabelText = "";
            this.txtAngkutanAwal.ExLabelVisible = true;
            this.txtAngkutanAwal.ExSelectFields = new string[0];
            this.txtAngkutanAwal.ExShowDialog = true;
            this.txtAngkutanAwal.ExSimpleMode = true;
            this.txtAngkutanAwal.ExSqlInstance = null;
            this.txtAngkutanAwal.ExSqlQuery = "Call SP_LookUp(\'angkutan\')";
            this.txtAngkutanAwal.ExTableName = "sub";
            this.txtAngkutanAwal.Location = new System.Drawing.Point(105, 72);
            this.txtAngkutanAwal.Name = "txtAngkutanAwal";
            this.txtAngkutanAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtAngkutanAwal.Size = new System.Drawing.Size(114, 20);
            this.txtAngkutanAwal.TabIndex = 4;
            // 
            // txtSubAkhir
            // 
            this.txtSubAkhir.ExAllowEmptyString = true;
            this.txtSubAkhir.ExAllowNonDBData = false;
            this.txtSubAkhir.ExAutoCheck = true;
            this.txtSubAkhir.ExAutoShowResult = false;
            this.txtSubAkhir.ExCondition = "";
            this.txtSubAkhir.ExDialogTitle = "Supplier";
            this.txtSubAkhir.ExFieldName = "Kode";
            this.txtSubAkhir.ExFilterFields = new string[0];
            this.txtSubAkhir.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtSubAkhir.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtSubAkhir.ExLabelContainer = null;
            this.txtSubAkhir.ExLabelField = "Nama";
            this.txtSubAkhir.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtSubAkhir.ExLabelText = "";
            this.txtSubAkhir.ExLabelVisible = true;
            this.txtSubAkhir.ExSelectFields = new string[0];
            this.txtSubAkhir.ExShowDialog = true;
            this.txtSubAkhir.ExSimpleMode = true;
            this.txtSubAkhir.ExSqlInstance = null;
            this.txtSubAkhir.ExSqlQuery = "Call SP_LookUp(\'supcus\')";
            this.txtSubAkhir.ExTableName = "";
            this.txtSubAkhir.Location = new System.Drawing.Point(374, 42);
            this.txtSubAkhir.Name = "txtSubAkhir";
            this.txtSubAkhir.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtSubAkhir.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtSubAkhir.Properties.Appearance.Options.UseBackColor = true;
            this.txtSubAkhir.Properties.Appearance.Options.UseForeColor = true;
            this.txtSubAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtSubAkhir.Size = new System.Drawing.Size(114, 20);
            this.txtSubAkhir.TabIndex = 3;
            this.txtSubAkhir.EditValueChanged += new System.EventHandler(this.txtSubAkhir_EditValueChanged);
            // 
            // txtSubAwal
            // 
            this.txtSubAwal.ExAllowEmptyString = true;
            this.txtSubAwal.ExAllowNonDBData = false;
            this.txtSubAwal.ExAutoCheck = true;
            this.txtSubAwal.ExAutoShowResult = false;
            this.txtSubAwal.ExCondition = "";
            this.txtSubAwal.ExDialogTitle = "Supplier";
            this.txtSubAwal.ExFieldName = "Kode";
            this.txtSubAwal.ExFilterFields = new string[0];
            this.txtSubAwal.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtSubAwal.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtSubAwal.ExLabelContainer = null;
            this.txtSubAwal.ExLabelField = "Nama";
            this.txtSubAwal.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtSubAwal.ExLabelText = "";
            this.txtSubAwal.ExLabelVisible = true;
            this.txtSubAwal.ExSelectFields = new string[0];
            this.txtSubAwal.ExShowDialog = true;
            this.txtSubAwal.ExSimpleMode = true;
            this.txtSubAwal.ExSqlInstance = null;
            this.txtSubAwal.ExSqlQuery = "Call SP_LookUp(\'supcus\')";
            this.txtSubAwal.ExTableName = "";
            this.txtSubAwal.Location = new System.Drawing.Point(105, 41);
            this.txtSubAwal.Name = "txtSubAwal";
            this.txtSubAwal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtSubAwal.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtSubAwal.Properties.Appearance.Options.UseBackColor = true;
            this.txtSubAwal.Properties.Appearance.Options.UseForeColor = true;
            this.txtSubAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtSubAwal.Size = new System.Drawing.Size(114, 20);
            this.txtSubAwal.TabIndex = 2;
            // 
            // rbtnDA
            // 
            this.rbtnDA.AutoSize = true;
            this.rbtnDA.Location = new System.Drawing.Point(106, 102);
            this.rbtnDA.Name = "rbtnDA";
            this.rbtnDA.Size = new System.Drawing.Size(111, 17);
            this.rbtnDA.TabIndex = 142;
            this.rbtnDA.TabStop = true;
            this.rbtnDA.Text = "Dengan Angkutan";
            this.rbtnDA.UseVisualStyleBackColor = true;
            // 
            // rbtnTA
            // 
            this.rbtnTA.AutoSize = true;
            this.rbtnTA.Location = new System.Drawing.Point(217, 102);
            this.rbtnTA.Name = "rbtnTA";
            this.rbtnTA.Size = new System.Drawing.Size(104, 17);
            this.rbtnTA.TabIndex = 143;
            this.rbtnTA.TabStop = true;
            this.rbtnTA.Text = "Tanpa Angkutan";
            this.rbtnTA.UseVisualStyleBackColor = true;
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Location = new System.Drawing.Point(323, 102);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(36, 17);
            this.rbtnAll.TabIndex = 144;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "All";
            this.rbtnAll.UseVisualStyleBackColor = true;
            // 
            // FrmLBuktiMuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 542);
            this.LookAndFeel.SkinName = "";
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.UseWindowsXPTheme = false;
            this.Name = "FrmLBuktiMuat";
            this.Text = "FrmLBuktiMuat";
            this.Load += new System.EventHandler(this.FrmLBuktiMuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAwal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAngkutanAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAngkutanAwal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubAwal.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dtpTglAkhir;
        private DevExpress.XtraEditors.DateEdit dtpTglAwal;
        private System.Windows.Forms.Label label3;
        private KASLibrary.TextBoxEx txtSubAkhir;
        private KASLibrary.TextBoxEx txtSubAwal;
        private System.Windows.Forms.Label label2;
        private KASLibrary.TextBoxEx txtAngkutanAkhir;
        private KASLibrary.TextBoxEx txtAngkutanAwal;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.RadioButton rbtnTA;
        private System.Windows.Forms.RadioButton rbtnDA;
    }
}