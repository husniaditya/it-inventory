namespace CAS.Laporan
{
    partial class FrmLHistorySO
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
            this.txtSubAkhir = new KASLibrary.TextBoxEx();
            this.txtSubAwal = new KASLibrary.TextBoxEx();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOklAwal = new KASLibrary.TextBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOklAkhir = new KASLibrary.TextBoxEx();
            this.dtpTglAkhir = new DevExpress.XtraEditors.DateEdit();
            this.dtpTglAwal = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rgStatusSO = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubAwal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOklAwal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOklAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAwal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgStatusSO.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(636, 130);
            this.btnClose.LookAndFeel.SkinName = "";
            this.btnClose.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.LookAndFeel.UseWindowsXPTheme = false;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(555, 130);
            this.btnPreview.LookAndFeel.SkinName = "";
            this.btnPreview.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btnPreview.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnPreview.LookAndFeel.UseWindowsXPTheme = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // printControl
            // 
            this.printControl.Location = new System.Drawing.Point(0, 188);
            this.printControl.Size = new System.Drawing.Size(718, 332);
            // 
            // printPreviewBar
            // 
            this.printPreviewBar.Location = new System.Drawing.Point(0, 160);
            this.printPreviewBar.Size = new System.Drawing.Size(718, 28);
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.label4);
            this.pnlFilter.Controls.Add(this.rgStatusSO);
            this.pnlFilter.Controls.Add(this.dtpTglAkhir);
            this.pnlFilter.Controls.Add(this.dtpTglAwal);
            this.pnlFilter.Controls.Add(this.label3);
            this.pnlFilter.Controls.Add(this.txtOklAkhir);
            this.pnlFilter.Controls.Add(this.txtOklAwal);
            this.pnlFilter.Controls.Add(this.label1);
            this.pnlFilter.Controls.Add(this.txtSubAkhir);
            this.pnlFilter.Controls.Add(this.txtSubAwal);
            this.pnlFilter.Controls.Add(this.label2);
            this.pnlFilter.LookAndFeel.SkinName = "";
            this.pnlFilter.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.pnlFilter.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlFilter.LookAndFeel.UseWindowsXPTheme = false;
            this.pnlFilter.Size = new System.Drawing.Size(718, 160);
            this.pnlFilter.Controls.SetChildIndex(this.btnPreview, 0);
            this.pnlFilter.Controls.SetChildIndex(this.btnClose, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label2, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtSubAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtSubAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label1, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtOklAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtOklAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label3, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dtpTglAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dtpTglAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.rgStatusSO, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label4, 0);
            // 
            // txtSubAkhir
            // 
            this.txtSubAkhir.ExAllowEmptyString = true;
            this.txtSubAkhir.ExAllowNonDBData = false;
            this.txtSubAkhir.ExAutoCheck = true;
            this.txtSubAkhir.ExAutoShowResult = false;
            this.txtSubAkhir.ExCondition = "";
            this.txtSubAkhir.ExDialogTitle = "Customer";
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
            this.txtSubAkhir.ExSqlQuery = "Call SP_LookUp(\'customer\')";
            this.txtSubAkhir.ExTableName = "";
            this.txtSubAkhir.Location = new System.Drawing.Point(319, 47);
            this.txtSubAkhir.Name = "txtSubAkhir";
            this.txtSubAkhir.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtSubAkhir.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtSubAkhir.Properties.Appearance.Options.UseBackColor = true;
            this.txtSubAkhir.Properties.Appearance.Options.UseForeColor = true;
            this.txtSubAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtSubAkhir.Size = new System.Drawing.Size(114, 20);
            this.txtSubAkhir.TabIndex = 124;
            // 
            // txtSubAwal
            // 
            this.txtSubAwal.ExAllowEmptyString = true;
            this.txtSubAwal.ExAllowNonDBData = false;
            this.txtSubAwal.ExAutoCheck = true;
            this.txtSubAwal.ExAutoShowResult = false;
            this.txtSubAwal.ExCondition = "";
            this.txtSubAwal.ExDialogTitle = "Customer";
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
            this.txtSubAwal.ExSqlQuery = "Call SP_LookUp(\'customer\')";
            this.txtSubAwal.ExTableName = "";
            this.txtSubAwal.Location = new System.Drawing.Point(130, 47);
            this.txtSubAwal.Name = "txtSubAwal";
            this.txtSubAwal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtSubAwal.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtSubAwal.Properties.Appearance.Options.UseBackColor = true;
            this.txtSubAwal.Properties.Appearance.Options.UseForeColor = true;
            this.txtSubAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtSubAwal.Size = new System.Drawing.Size(114, 20);
            this.txtSubAwal.TabIndex = 123;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 122;
            this.label2.Text = "Customer";
            // 
            // txtOklAwal
            // 
            this.txtOklAwal.ExAllowEmptyString = true;
            this.txtOklAwal.ExAllowNonDBData = false;
            this.txtOklAwal.ExAutoCheck = true;
            this.txtOklAwal.ExAutoShowResult = false;
            this.txtOklAwal.ExCondition = "";
            this.txtOklAwal.ExDialogTitle = "Order Penjualan";
            this.txtOklAwal.ExFieldName = "No SO";
            this.txtOklAwal.ExFilterFields = new string[0];
            this.txtOklAwal.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtOklAwal.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtOklAwal.ExLabelContainer = null;
            this.txtOklAwal.ExLabelField = "";
            this.txtOklAwal.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtOklAwal.ExLabelText = "";
            this.txtOklAwal.ExLabelVisible = false;
            this.txtOklAwal.ExSelectFields = new string[0];
            this.txtOklAwal.ExShowDialog = true;
            this.txtOklAwal.ExSimpleMode = true;
            this.txtOklAwal.ExSqlInstance = null;
            this.txtOklAwal.ExSqlQuery = "select okl as `No SO`, `date` as Tanggal, remark as Keterangan from okl where `de" +
                "lete`=0";
            this.txtOklAwal.ExTableName = "okl";
            this.txtOklAwal.Location = new System.Drawing.Point(130, 88);
            this.txtOklAwal.Name = "txtOklAwal";
            this.txtOklAwal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtOklAwal.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtOklAwal.Properties.Appearance.Options.UseBackColor = true;
            this.txtOklAwal.Properties.Appearance.Options.UseForeColor = true;
            this.txtOklAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtOklAwal.Size = new System.Drawing.Size(114, 20);
            this.txtOklAwal.TabIndex = 126;
            this.txtOklAwal.Enter += new System.EventHandler(this.txtOklAwal_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 125;
            this.label1.Text = "No SO";
            // 
            // txtOklAkhir
            // 
            this.txtOklAkhir.ExAllowEmptyString = true;
            this.txtOklAkhir.ExAllowNonDBData = false;
            this.txtOklAkhir.ExAutoCheck = true;
            this.txtOklAkhir.ExAutoShowResult = false;
            this.txtOklAkhir.ExCondition = "";
            this.txtOklAkhir.ExDialogTitle = "Order Penjualan";
            this.txtOklAkhir.ExFieldName = "No SO";
            this.txtOklAkhir.ExFilterFields = new string[0];
            this.txtOklAkhir.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtOklAkhir.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtOklAkhir.ExLabelContainer = null;
            this.txtOklAkhir.ExLabelField = "";
            this.txtOklAkhir.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtOklAkhir.ExLabelText = "";
            this.txtOklAkhir.ExLabelVisible = false;
            this.txtOklAkhir.ExSelectFields = new string[0];
            this.txtOklAkhir.ExShowDialog = true;
            this.txtOklAkhir.ExSimpleMode = true;
            this.txtOklAkhir.ExSqlInstance = null;
            this.txtOklAkhir.ExSqlQuery = "select okl as `No SO`, `date` as Tanggal, remark as Keterangan from okl where `de" +
                "lete`=0";
            this.txtOklAkhir.ExTableName = "okl";
            this.txtOklAkhir.Location = new System.Drawing.Point(319, 88);
            this.txtOklAkhir.Name = "txtOklAkhir";
            this.txtOklAkhir.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtOklAkhir.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtOklAkhir.Properties.Appearance.Options.UseBackColor = true;
            this.txtOklAkhir.Properties.Appearance.Options.UseForeColor = true;
            this.txtOklAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtOklAkhir.Size = new System.Drawing.Size(114, 20);
            this.txtOklAkhir.TabIndex = 127;
            this.txtOklAkhir.Enter += new System.EventHandler(this.txtOklAkhir_Enter);
            // 
            // dtpTglAkhir
            // 
            this.dtpTglAkhir.EditValue = new System.DateTime(2008, 8, 20, 15, 40, 28, 0);
            this.dtpTglAkhir.Location = new System.Drawing.Point(319, 21);
            this.dtpTglAkhir.Name = "dtpTglAkhir";
            this.dtpTglAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTglAkhir.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAkhir.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAkhir.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAkhir.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAkhir.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtpTglAkhir.Size = new System.Drawing.Size(114, 20);
            this.dtpTglAkhir.TabIndex = 130;
            this.dtpTglAkhir.EditValueChanged += new System.EventHandler(this.dtpTglAkhir_EditValueChanged);
            // 
            // dtpTglAwal
            // 
            this.dtpTglAwal.EditValue = new System.DateTime(2008, 8, 20, 15, 40, 28, 0);
            this.dtpTglAwal.Location = new System.Drawing.Point(130, 21);
            this.dtpTglAwal.Name = "dtpTglAwal";
            this.dtpTglAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTglAwal.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAwal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAwal.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAwal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAwal.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtpTglAwal.Size = new System.Drawing.Size(114, 20);
            this.dtpTglAwal.TabIndex = 129;
            this.dtpTglAwal.EditValueChanged += new System.EventHandler(this.dtpTglAwal_EditValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 128;
            this.label3.Text = "Tanggal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 132;
            this.label4.Text = "Status SO";
            // 
            // rgStatusSO
            // 
            this.rgStatusSO.EditValue = 3;
            this.rgStatusSO.Location = new System.Drawing.Point(130, 126);
            this.rgStatusSO.Name = "rgStatusSO";
            this.rgStatusSO.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Open"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Close"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "All")});
            this.rgStatusSO.Size = new System.Drawing.Size(173, 27);
            this.rgStatusSO.TabIndex = 131;
            // 
            // FrmLHistorySO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(718, 542);
            this.LookAndFeel.SkinName = "";
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.UseWindowsXPTheme = false;
            this.Name = "FrmLHistorySO";
            this.Load += new System.EventHandler(this.FrmLHistorySO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubAwal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOklAwal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOklAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAwal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgStatusSO.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KASLibrary.TextBoxEx txtSubAkhir;
        private KASLibrary.TextBoxEx txtSubAwal;
        private System.Windows.Forms.Label label2;
        private KASLibrary.TextBoxEx txtOklAwal;
        private System.Windows.Forms.Label label1;
        private KASLibrary.TextBoxEx txtOklAkhir;
        private DevExpress.XtraEditors.DateEdit dtpTglAkhir;
        private DevExpress.XtraEditors.DateEdit dtpTglAwal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.RadioGroup rgStatusSO;
    }
}
