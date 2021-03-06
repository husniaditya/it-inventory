namespace CAS.Laporan
{
    partial class FrmLAccCct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLAccCct));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccAkhir = new KASLibrary.TextBoxEx();
            this.dtpTglAwal = new DevExpress.XtraEditors.DateEdit();
            this.txtAccAwal = new KASLibrary.TextBoxEx();
            this.dtpTglAkhir = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.cctz = new KASLibrary.TextBoxEx();
            this.ccta = new KASLibrary.TextBoxEx();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAwal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccAwal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cctz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccta.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.LookAndFeel.SkinName = "";
            this.btnClose.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.LookAndFeel.UseWindowsXPTheme = false;
            // 
            // btnPreview
            // 
            this.btnPreview.LookAndFeel.SkinName = "";
            this.btnPreview.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btnPreview.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnPreview.LookAndFeel.UseWindowsXPTheme = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // printControl
            // 
            this.printControl.Location = new System.Drawing.Point(0, 239);
            this.printControl.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.printControl.Size = new System.Drawing.Size(1077, 561);
            // 
            // printPreviewBar
            // 
            this.printPreviewBar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.printPreviewBar.Size = new System.Drawing.Size(1077, 36);
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.label3);
            this.pnlFilter.Controls.Add(this.cctz);
            this.pnlFilter.Controls.Add(this.ccta);
            this.pnlFilter.Controls.Add(this.label1);
            this.pnlFilter.Controls.Add(this.label2);
            this.pnlFilter.Controls.Add(this.txtAccAkhir);
            this.pnlFilter.Controls.Add(this.dtpTglAwal);
            this.pnlFilter.Controls.Add(this.txtAccAwal);
            this.pnlFilter.Controls.Add(this.dtpTglAkhir);
            this.pnlFilter.LookAndFeel.SkinName = "";
            this.pnlFilter.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.pnlFilter.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlFilter.LookAndFeel.UseWindowsXPTheme = false;
            this.pnlFilter.Controls.SetChildIndex(this.btnPreview, 0);
            this.pnlFilter.Controls.SetChildIndex(this.btnClose, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dtpTglAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtAccAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dtpTglAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtAccAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label2, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label1, 0);
            this.pnlFilter.Controls.SetChildIndex(this.ccta, 0);
            this.pnlFilter.Controls.SetChildIndex(this.cctz, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label3, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tanggal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Perkiraan";
            // 
            // txtAccAkhir
            // 
            this.txtAccAkhir.ExAllowEmptyString = true;
            this.txtAccAkhir.ExAllowNonDBData = false;
            this.txtAccAkhir.ExAutoCheck = true;
            this.txtAccAkhir.ExAutoShowResult = false;
            this.txtAccAkhir.ExCondition = "";
            this.txtAccAkhir.ExDialogTitle = "Inventory";
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
            this.txtAccAkhir.Location = new System.Drawing.Point(429, 75);
            this.txtAccAkhir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAccAkhir.Name = "txtAccAkhir";
            this.txtAccAkhir.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtAccAkhir.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtAccAkhir.Properties.Appearance.Options.UseBackColor = true;
            this.txtAccAkhir.Properties.Appearance.Options.UseForeColor = true;
            this.txtAccAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtAccAkhir.Size = new System.Drawing.Size(150, 26);
            this.txtAccAkhir.TabIndex = 17;
            // 
            // dtpTglAwal
            // 
            this.dtpTglAwal.EditValue = new System.DateTime(2008, 8, 20, 15, 40, 28, 0);
            this.dtpTglAwal.Location = new System.Drawing.Point(186, 18);
            this.dtpTglAwal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpTglAwal.Name = "dtpTglAwal";
            this.dtpTglAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTglAwal.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAwal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAwal.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAwal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAwal.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtpTglAwal.Size = new System.Drawing.Size(150, 26);
            this.dtpTglAwal.TabIndex = 14;
            // 
            // txtAccAwal
            // 
            this.txtAccAwal.ExAllowEmptyString = true;
            this.txtAccAwal.ExAllowNonDBData = false;
            this.txtAccAwal.ExAutoCheck = true;
            this.txtAccAwal.ExAutoShowResult = false;
            this.txtAccAwal.ExCondition = "";
            this.txtAccAwal.ExDialogTitle = "Inventory";
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
            this.txtAccAwal.Location = new System.Drawing.Point(186, 75);
            this.txtAccAwal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAccAwal.Name = "txtAccAwal";
            this.txtAccAwal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtAccAwal.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtAccAwal.Properties.Appearance.Options.UseBackColor = true;
            this.txtAccAwal.Properties.Appearance.Options.UseForeColor = true;
            this.txtAccAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtAccAwal.Size = new System.Drawing.Size(150, 26);
            this.txtAccAwal.TabIndex = 16;
            // 
            // dtpTglAkhir
            // 
            this.dtpTglAkhir.EditValue = new System.DateTime(2008, 8, 20, 15, 40, 28, 0);
            this.dtpTglAkhir.Location = new System.Drawing.Point(429, 18);
            this.dtpTglAkhir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpTglAkhir.Name = "dtpTglAkhir";
            this.dtpTglAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTglAkhir.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAkhir.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAkhir.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAkhir.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAkhir.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtpTglAkhir.Size = new System.Drawing.Size(150, 26);
            this.dtpTglAkhir.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Cost Center";
            // 
            // cctz
            // 
            this.cctz.ExAllowEmptyString = true;
            this.cctz.ExAllowNonDBData = false;
            this.cctz.ExAutoCheck = true;
            this.cctz.ExAutoShowResult = false;
            this.cctz.ExCondition = "";
            this.cctz.ExDialogTitle = "cost center";
            this.cctz.ExFieldName = "Cost Center";
            this.cctz.ExFilterFields = new string[0];
            this.cctz.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.cctz.ExInvalidForeColor = System.Drawing.Color.Black;
            this.cctz.ExLabelContainer = null;
            this.cctz.ExLabelField = "nama";
            this.cctz.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.cctz.ExLabelText = "";
            this.cctz.ExLabelVisible = true;
            this.cctz.ExSelectFields = new string[0];
            this.cctz.ExShowDialog = true;
            this.cctz.ExSimpleMode = true;
            this.cctz.ExSqlInstance = null;
            this.cctz.ExSqlQuery = "Call SP_LookUp(\'cct\')";
            this.cctz.ExTableName = "";
            this.cctz.Location = new System.Drawing.Point(429, 135);
            this.cctz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cctz.Name = "cctz";
            this.cctz.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.cctz.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cctz.Properties.Appearance.Options.UseBackColor = true;
            this.cctz.Properties.Appearance.Options.UseForeColor = true;
            this.cctz.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.cctz.Size = new System.Drawing.Size(150, 26);
            this.cctz.TabIndex = 21;
            // 
            // ccta
            // 
            this.ccta.ExAllowEmptyString = true;
            this.ccta.ExAllowNonDBData = false;
            this.ccta.ExAutoCheck = true;
            this.ccta.ExAutoShowResult = false;
            this.ccta.ExCondition = "";
            this.ccta.ExDialogTitle = "cost center";
            this.ccta.ExFieldName = "Cost Center";
            this.ccta.ExFilterFields = new string[0];
            this.ccta.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.ccta.ExInvalidForeColor = System.Drawing.Color.Black;
            this.ccta.ExLabelContainer = null;
            this.ccta.ExLabelField = "nama";
            this.ccta.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.ccta.ExLabelText = "";
            this.ccta.ExLabelVisible = true;
            this.ccta.ExSelectFields = new string[0];
            this.ccta.ExShowDialog = true;
            this.ccta.ExSimpleMode = true;
            this.ccta.ExSqlInstance = null;
            this.ccta.ExSqlQuery = "Call SP_LookUp(\'cct\')";
            this.ccta.ExTableName = "";
            this.ccta.Location = new System.Drawing.Point(186, 135);
            this.ccta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ccta.Name = "ccta";
            this.ccta.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.ccta.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.ccta.Properties.Appearance.Options.UseBackColor = true;
            this.ccta.Properties.Appearance.Options.UseForeColor = true;
            this.ccta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.ccta.Size = new System.Drawing.Size(150, 26);
            this.ccta.TabIndex = 20;
            // 
            // FrmLAccCct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(1077, 834);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "";
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.UseWindowsXPTheme = false;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "FrmLAccCct";
            this.Load += new System.EventHandler(this.FrmLAccCct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAwal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccAwal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cctz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccta.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private KASLibrary.TextBoxEx txtAccAkhir;
        private DevExpress.XtraEditors.DateEdit dtpTglAwal;
        private KASLibrary.TextBoxEx txtAccAwal;
        private DevExpress.XtraEditors.DateEdit dtpTglAkhir;
        private System.Windows.Forms.Label label3;
        private KASLibrary.TextBoxEx cctz;
        private KASLibrary.TextBoxEx ccta;
    }
}
