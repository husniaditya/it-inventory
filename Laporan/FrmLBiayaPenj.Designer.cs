namespace CAS.Laporan
{
    partial class FrmLBiayaPenj
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccAwal = new KASLibrary.TextBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccAkhir = new KASLibrary.TextBoxEx();
            this.txtSubAkhir = new KASLibrary.TextBoxEx();
            this.txtSubAwal = new KASLibrary.TextBoxEx();
            this.dtpTglAkhir = new DevExpress.XtraEditors.DateEdit();
            this.dtpTglAwal = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxexoklb = new KASLibrary.TextBoxEx();
            this.textboxexokla = new KASLibrary.TextBoxEx();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccAwal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubAwal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAwal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textboxexoklb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textboxexokla.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(636, 190);
            this.btnClose.LookAndFeel.SkinName = "";
            this.btnClose.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.LookAndFeel.UseWindowsXPTheme = false;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(555, 190);
            this.btnPreview.LookAndFeel.SkinName = "";
            this.btnPreview.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btnPreview.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnPreview.LookAndFeel.UseWindowsXPTheme = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // printControl
            // 
            this.printControl.Location = new System.Drawing.Point(0, 248);
            this.printControl.Size = new System.Drawing.Size(718, 272);
            // 
            // printPreviewBar
            // 
            this.printPreviewBar.Location = new System.Drawing.Point(0, 220);
            this.printPreviewBar.Size = new System.Drawing.Size(718, 28);
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.textboxexoklb);
            this.pnlFilter.Controls.Add(this.textboxexokla);
            this.pnlFilter.Controls.Add(this.label6);
            this.pnlFilter.Controls.Add(this.dtpTglAkhir);
            this.pnlFilter.Controls.Add(this.dtpTglAwal);
            this.pnlFilter.Controls.Add(this.label3);
            this.pnlFilter.Controls.Add(this.txtSubAkhir);
            this.pnlFilter.Controls.Add(this.txtSubAwal);
            this.pnlFilter.Controls.Add(this.txtAccAkhir);
            this.pnlFilter.Controls.Add(this.txtAccAwal);
            this.pnlFilter.Controls.Add(this.label1);
            this.pnlFilter.Controls.Add(this.label2);
            this.pnlFilter.LookAndFeel.SkinName = "";
            this.pnlFilter.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.pnlFilter.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlFilter.LookAndFeel.UseWindowsXPTheme = false;
            this.pnlFilter.Size = new System.Drawing.Size(718, 220);
            this.pnlFilter.Controls.SetChildIndex(this.btnPreview, 0);
            this.pnlFilter.Controls.SetChildIndex(this.btnClose, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label2, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label1, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtAccAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtAccAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtSubAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtSubAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label3, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dtpTglAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dtpTglAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label6, 0);
            this.pnlFilter.Controls.SetChildIndex(this.textboxexokla, 0);
            this.pnlFilter.Controls.SetChildIndex(this.textboxexoklb, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Customer";
            // 
            // txtAccAwal
            // 
            this.txtAccAwal.ExAllowEmptyString = true;
            this.txtAccAwal.ExAllowNonDBData = false;
            this.txtAccAwal.ExAutoCheck = true;
            this.txtAccAwal.ExAutoShowResult = false;
            this.txtAccAwal.ExCondition = "";
            this.txtAccAwal.ExDialogTitle = "Nama Account";
            this.txtAccAwal.ExFieldName = "Kode Akun";
            this.txtAccAwal.ExFilterFields = new string[0];
            this.txtAccAwal.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtAccAwal.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtAccAwal.ExLabelContainer = null;
            this.txtAccAwal.ExLabelField = "Keterangan";
            this.txtAccAwal.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtAccAwal.ExLabelText = "";
            this.txtAccAwal.ExLabelVisible = true;
            this.txtAccAwal.ExSelectFields = new string[0];
            this.txtAccAwal.ExShowDialog = true;
            this.txtAccAwal.ExSimpleMode = true;
            this.txtAccAwal.ExSqlInstance = null;
            this.txtAccAwal.ExSqlQuery = "Call SP_LookUp(\'acc\')";
            this.txtAccAwal.ExTableName = "";
            this.txtAccAwal.Location = new System.Drawing.Point(132, 126);
            this.txtAccAwal.Name = "txtAccAwal";
            this.txtAccAwal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtAccAwal.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtAccAwal.Properties.Appearance.Options.UseBackColor = true;
            this.txtAccAwal.Properties.Appearance.Options.UseForeColor = true;
            this.txtAccAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtAccAwal.Size = new System.Drawing.Size(114, 20);
            this.txtAccAwal.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Perkiraan";
            // 
            // txtAccAkhir
            // 
            this.txtAccAkhir.ExAllowEmptyString = true;
            this.txtAccAkhir.ExAllowNonDBData = false;
            this.txtAccAkhir.ExAutoCheck = true;
            this.txtAccAkhir.ExAutoShowResult = false;
            this.txtAccAkhir.ExCondition = "";
            this.txtAccAkhir.ExDialogTitle = "Nama Account";
            this.txtAccAkhir.ExFieldName = "Kode Akun";
            this.txtAccAkhir.ExFilterFields = new string[0];
            this.txtAccAkhir.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtAccAkhir.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtAccAkhir.ExLabelContainer = null;
            this.txtAccAkhir.ExLabelField = "Keterangan";
            this.txtAccAkhir.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtAccAkhir.ExLabelText = "";
            this.txtAccAkhir.ExLabelVisible = true;
            this.txtAccAkhir.ExSelectFields = new string[0];
            this.txtAccAkhir.ExShowDialog = true;
            this.txtAccAkhir.ExSimpleMode = true;
            this.txtAccAkhir.ExSqlInstance = null;
            this.txtAccAkhir.ExSqlQuery = "Call SP_LookUp(\'acc\')";
            this.txtAccAkhir.ExTableName = "";
            this.txtAccAkhir.Location = new System.Drawing.Point(321, 126);
            this.txtAccAkhir.Name = "txtAccAkhir";
            this.txtAccAkhir.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtAccAkhir.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtAccAkhir.Properties.Appearance.Options.UseBackColor = true;
            this.txtAccAkhir.Properties.Appearance.Options.UseForeColor = true;
            this.txtAccAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtAccAkhir.Size = new System.Drawing.Size(114, 20);
            this.txtAccAkhir.TabIndex = 18;
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
            this.txtSubAkhir.ExSqlQuery = "Call SP_LookUp(\'customer\')";
            this.txtSubAkhir.ExTableName = "";
            this.txtSubAkhir.Location = new System.Drawing.Point(321, 54);
            this.txtSubAkhir.Name = "txtSubAkhir";
            this.txtSubAkhir.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtSubAkhir.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtSubAkhir.Properties.Appearance.Options.UseBackColor = true;
            this.txtSubAkhir.Properties.Appearance.Options.UseForeColor = true;
            this.txtSubAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtSubAkhir.Size = new System.Drawing.Size(114, 20);
            this.txtSubAkhir.TabIndex = 20;
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
            this.txtSubAwal.ExSqlQuery = "Call SP_LookUp(\'customer\')";
            this.txtSubAwal.ExTableName = "";
            this.txtSubAwal.Location = new System.Drawing.Point(132, 54);
            this.txtSubAwal.Name = "txtSubAwal";
            this.txtSubAwal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtSubAwal.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtSubAwal.Properties.Appearance.Options.UseBackColor = true;
            this.txtSubAwal.Properties.Appearance.Options.UseForeColor = true;
            this.txtSubAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtSubAwal.Size = new System.Drawing.Size(114, 20);
            this.txtSubAwal.TabIndex = 19;
            this.txtSubAwal.EditValueChanged += new System.EventHandler(this.txtSubAwal_EditValueChanged);
            // 
            // dtpTglAkhir
            // 
            this.dtpTglAkhir.EditValue = new System.DateTime(2008, 10, 11, 0, 0, 0, 0);
            this.dtpTglAkhir.Location = new System.Drawing.Point(321, 25);
            this.dtpTglAkhir.Name = "dtpTglAkhir";
            this.dtpTglAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTglAkhir.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAkhir.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAkhir.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAkhir.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAkhir.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtpTglAkhir.Size = new System.Drawing.Size(114, 20);
            this.dtpTglAkhir.TabIndex = 23;
            // 
            // dtpTglAwal
            // 
            this.dtpTglAwal.EditValue = new System.DateTime(2008, 10, 11, 0, 0, 0, 0);
            this.dtpTglAwal.Location = new System.Drawing.Point(132, 25);
            this.dtpTglAwal.Name = "dtpTglAwal";
            this.dtpTglAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTglAwal.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAwal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAwal.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAwal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAwal.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtpTglAwal.Size = new System.Drawing.Size(114, 20);
            this.dtpTglAwal.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tanggal";
            // 
            // textboxexoklb
            // 
            this.textboxexoklb.ExAllowEmptyString = true;
            this.textboxexoklb.ExAllowNonDBData = false;
            this.textboxexoklb.ExAutoCheck = true;
            this.textboxexoklb.ExAutoShowResult = false;
            this.textboxexoklb.ExCondition = "";
            this.textboxexoklb.ExDialogTitle = "Order Penjualan";
            this.textboxexoklb.ExFieldName = "No SO";
            this.textboxexoklb.ExFilterFields = new string[0];
            this.textboxexoklb.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.textboxexoklb.ExInvalidForeColor = System.Drawing.Color.Black;
            this.textboxexoklb.ExLabelContainer = null;
            this.textboxexoklb.ExLabelField = "";
            this.textboxexoklb.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.textboxexoklb.ExLabelText = "";
            this.textboxexoklb.ExLabelVisible = false;
            this.textboxexoklb.ExSelectFields = new string[0];
            this.textboxexoklb.ExShowDialog = true;
            this.textboxexoklb.ExSimpleMode = true;
            this.textboxexoklb.ExSqlInstance = null;
            this.textboxexoklb.ExSqlQuery = "select * ,okl.okl as `No SO`  from okl ";
            this.textboxexoklb.ExTableName = "okl";
            this.textboxexoklb.Location = new System.Drawing.Point(321, 91);
            this.textboxexoklb.Name = "textboxexoklb";
            this.textboxexoklb.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.textboxexoklb.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.textboxexoklb.Properties.Appearance.Options.UseBackColor = true;
            this.textboxexoklb.Properties.Appearance.Options.UseForeColor = true;
            this.textboxexoklb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.textboxexoklb.Size = new System.Drawing.Size(114, 20);
            this.textboxexoklb.TabIndex = 120;
            // 
            // textboxexokla
            // 
            this.textboxexokla.ExAllowEmptyString = true;
            this.textboxexokla.ExAllowNonDBData = false;
            this.textboxexokla.ExAutoCheck = true;
            this.textboxexokla.ExAutoShowResult = false;
            this.textboxexokla.ExCondition = "";
            this.textboxexokla.ExDialogTitle = "Order Pejualan";
            this.textboxexokla.ExFieldName = "No SO";
            this.textboxexokla.ExFilterFields = new string[0];
            this.textboxexokla.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.textboxexokla.ExInvalidForeColor = System.Drawing.Color.Black;
            this.textboxexokla.ExLabelContainer = null;
            this.textboxexokla.ExLabelField = "";
            this.textboxexokla.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.textboxexokla.ExLabelText = "";
            this.textboxexokla.ExLabelVisible = false;
            this.textboxexokla.ExSelectFields = new string[0];
            this.textboxexokla.ExShowDialog = true;
            this.textboxexokla.ExSimpleMode = true;
            this.textboxexokla.ExSqlInstance = null;
            this.textboxexokla.ExSqlQuery = "select * ,okl.okl as `No SO`  from okl";
            this.textboxexokla.ExTableName = "okl";
            this.textboxexokla.Location = new System.Drawing.Point(132, 91);
            this.textboxexokla.Name = "textboxexokla";
            this.textboxexokla.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.textboxexokla.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.textboxexokla.Properties.Appearance.Options.UseBackColor = true;
            this.textboxexokla.Properties.Appearance.Options.UseForeColor = true;
            this.textboxexokla.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.textboxexokla.Size = new System.Drawing.Size(114, 20);
            this.textboxexokla.TabIndex = 119;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 118;
            this.label6.Text = "No SO";
            // 
            // FrmLBiayaPenj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(718, 542);
            this.LookAndFeel.SkinName = "";
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.UseWindowsXPTheme = false;
            this.Name = "FrmLBiayaPenj";
            this.Load += new System.EventHandler(this.FrmLHistoryPO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccAwal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubAwal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAwal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textboxexoklb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textboxexokla.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KASLibrary.TextBoxEx txtAccAwal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private KASLibrary.TextBoxEx txtAccAkhir;
        private KASLibrary.TextBoxEx txtSubAkhir;
        private KASLibrary.TextBoxEx txtSubAwal;
        private DevExpress.XtraEditors.DateEdit dtpTglAkhir;
        private DevExpress.XtraEditors.DateEdit dtpTglAwal;
        private System.Windows.Forms.Label label3;
        private KASLibrary.TextBoxEx textboxexoklb;
        private KASLibrary.TextBoxEx textboxexokla;
        private System.Windows.Forms.Label label6;
    }
}
