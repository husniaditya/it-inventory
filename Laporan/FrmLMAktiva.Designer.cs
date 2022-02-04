namespace CAS.Laporan
{
    partial class FrmLMAktiva
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
            this.txtInvAkhir = new KASLibrary.TextBoxEx();
            this.txtInvAwal = new KASLibrary.TextBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccAwal = new KASLibrary.TextBoxEx();
            this.txtAccAkhir = new KASLibrary.TextBoxEx();
            this.panelcct = new System.Windows.Forms.Panel();
            this.txtcctAkhir = new KASLibrary.TextBoxEx();
            this.txtcctAwal = new KASLibrary.TextBoxEx();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvAwal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccAwal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccAkhir.Properties)).BeginInit();
            this.panelcct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcctAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcctAwal.Properties)).BeginInit();
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
            this.printControl.Location = new System.Drawing.Point(0, 160);
            this.printControl.Size = new System.Drawing.Size(718, 360);
            // 
            // printPreviewBar
            // 
            this.printPreviewBar.Size = new System.Drawing.Size(718, 28);
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.panelcct);
            this.pnlFilter.Controls.Add(this.txtAccAkhir);
            this.pnlFilter.Controls.Add(this.label1);
            this.pnlFilter.Controls.Add(this.txtAccAwal);
            this.pnlFilter.Controls.Add(this.label2);
            this.pnlFilter.Controls.Add(this.txtInvAkhir);
            this.pnlFilter.Controls.Add(this.txtInvAwal);
            this.pnlFilter.LookAndFeel.SkinName = "";
            this.pnlFilter.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.pnlFilter.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlFilter.LookAndFeel.UseWindowsXPTheme = false;
            this.pnlFilter.Controls.SetChildIndex(this.btnPreview, 0);
            this.pnlFilter.Controls.SetChildIndex(this.btnClose, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtInvAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtInvAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label2, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtAccAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label1, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtAccAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.panelcct, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Aktiva Tetap";
            // 
            // txtInvAkhir
            // 
            this.txtInvAkhir.ExAllowEmptyString = true;
            this.txtInvAkhir.ExAllowNonDBData = false;
            this.txtInvAkhir.ExAutoCheck = true;
            this.txtInvAkhir.ExAutoShowResult = false;
            this.txtInvAkhir.ExCondition = "";
            this.txtInvAkhir.ExDialogTitle = "Inventory";
            this.txtInvAkhir.ExFieldName = "Kode Barang";
            this.txtInvAkhir.ExFilterFields = new string[0];
            this.txtInvAkhir.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtInvAkhir.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtInvAkhir.ExLabelContainer = null;
            this.txtInvAkhir.ExLabelField = "Nama Barang";
            this.txtInvAkhir.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtInvAkhir.ExLabelText = "";
            this.txtInvAkhir.ExLabelVisible = true;
            this.txtInvAkhir.ExSelectFields = new string[0];
            this.txtInvAkhir.ExShowDialog = true;
            this.txtInvAkhir.ExSimpleMode = true;
            this.txtInvAkhir.ExSqlInstance = null;
            this.txtInvAkhir.ExSqlQuery = "Call SP_LookUp(\'aktivatetap\')";
            this.txtInvAkhir.ExTableName = "";
            this.txtInvAkhir.Location = new System.Drawing.Point(300, 12);
            this.txtInvAkhir.Name = "txtInvAkhir";
            this.txtInvAkhir.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtInvAkhir.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtInvAkhir.Properties.Appearance.Options.UseBackColor = true;
            this.txtInvAkhir.Properties.Appearance.Options.UseForeColor = true;
            this.txtInvAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtInvAkhir.Size = new System.Drawing.Size(100, 20);
            this.txtInvAkhir.TabIndex = 15;
            // 
            // txtInvAwal
            // 
            this.txtInvAwal.ExAllowEmptyString = true;
            this.txtInvAwal.ExAllowNonDBData = false;
            this.txtInvAwal.ExAutoCheck = true;
            this.txtInvAwal.ExAutoShowResult = false;
            this.txtInvAwal.ExCondition = "";
            this.txtInvAwal.ExDialogTitle = "Inventory";
            this.txtInvAwal.ExFieldName = "Kode Barang";
            this.txtInvAwal.ExFilterFields = new string[0];
            this.txtInvAwal.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtInvAwal.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtInvAwal.ExLabelContainer = null;
            this.txtInvAwal.ExLabelField = "Nama Barang";
            this.txtInvAwal.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtInvAwal.ExLabelText = "";
            this.txtInvAwal.ExLabelVisible = true;
            this.txtInvAwal.ExSelectFields = new string[0];
            this.txtInvAwal.ExShowDialog = true;
            this.txtInvAwal.ExSimpleMode = true;
            this.txtInvAwal.ExSqlInstance = null;
            this.txtInvAwal.ExSqlQuery = "Call SP_LookUp(\'aktivatetap\')";
            this.txtInvAwal.ExTableName = "";
            this.txtInvAwal.Location = new System.Drawing.Point(138, 12);
            this.txtInvAwal.Name = "txtInvAwal";
            this.txtInvAwal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtInvAwal.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtInvAwal.Properties.Appearance.Options.UseBackColor = true;
            this.txtInvAwal.Properties.Appearance.Options.UseForeColor = true;
            this.txtInvAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtInvAwal.Size = new System.Drawing.Size(100, 20);
            this.txtInvAwal.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Account";
            // 
            // txtAccAwal
            // 
            this.txtAccAwal.ExAllowEmptyString = true;
            this.txtAccAwal.ExAllowNonDBData = false;
            this.txtAccAwal.ExAutoCheck = true;
            this.txtAccAwal.ExAutoShowResult = false;
            this.txtAccAwal.ExCondition = "";
            this.txtAccAwal.ExDialogTitle = "Account";
            this.txtAccAwal.ExFieldName = "Acc";
            this.txtAccAwal.ExFilterFields = new string[0];
            this.txtAccAwal.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtAccAwal.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtAccAwal.ExLabelContainer = null;
            this.txtAccAwal.ExLabelField = "Name";
            this.txtAccAwal.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtAccAwal.ExLabelText = "";
            this.txtAccAwal.ExLabelVisible = true;
            this.txtAccAwal.ExSelectFields = new string[0];
            this.txtAccAwal.ExShowDialog = true;
            this.txtAccAwal.ExSimpleMode = true;
            this.txtAccAwal.ExSqlInstance = null;
            this.txtAccAwal.ExSqlQuery = "Call SP_LookUp(\'accakt\')";
            this.txtAccAwal.ExTableName = "";
            this.txtAccAwal.Location = new System.Drawing.Point(138, 55);
            this.txtAccAwal.Name = "txtAccAwal";
            this.txtAccAwal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtAccAwal.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtAccAwal.Properties.Appearance.Options.UseBackColor = true;
            this.txtAccAwal.Properties.Appearance.Options.UseForeColor = true;
            this.txtAccAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtAccAwal.Size = new System.Drawing.Size(100, 20);
            this.txtAccAwal.TabIndex = 17;
            // 
            // txtAccAkhir
            // 
            this.txtAccAkhir.ExAllowEmptyString = true;
            this.txtAccAkhir.ExAllowNonDBData = false;
            this.txtAccAkhir.ExAutoCheck = true;
            this.txtAccAkhir.ExAutoShowResult = false;
            this.txtAccAkhir.ExCondition = "";
            this.txtAccAkhir.ExDialogTitle = "Account";
            this.txtAccAkhir.ExFieldName = "Acc";
            this.txtAccAkhir.ExFilterFields = new string[0];
            this.txtAccAkhir.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtAccAkhir.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtAccAkhir.ExLabelContainer = null;
            this.txtAccAkhir.ExLabelField = "Name";
            this.txtAccAkhir.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtAccAkhir.ExLabelText = "";
            this.txtAccAkhir.ExLabelVisible = true;
            this.txtAccAkhir.ExSelectFields = new string[0];
            this.txtAccAkhir.ExShowDialog = true;
            this.txtAccAkhir.ExSimpleMode = true;
            this.txtAccAkhir.ExSqlInstance = null;
            this.txtAccAkhir.ExSqlQuery = "Call SP_LookUp(\'accakt\')";
            this.txtAccAkhir.ExTableName = "";
            this.txtAccAkhir.Location = new System.Drawing.Point(300, 55);
            this.txtAccAkhir.Name = "txtAccAkhir";
            this.txtAccAkhir.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtAccAkhir.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtAccAkhir.Properties.Appearance.Options.UseBackColor = true;
            this.txtAccAkhir.Properties.Appearance.Options.UseForeColor = true;
            this.txtAccAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtAccAkhir.Size = new System.Drawing.Size(100, 20);
            this.txtAccAkhir.TabIndex = 20;
            // 
            // panelcct
            // 
            this.panelcct.Controls.Add(this.txtcctAkhir);
            this.panelcct.Controls.Add(this.txtcctAwal);
            this.panelcct.Controls.Add(this.label4);
            this.panelcct.Location = new System.Drawing.Point(55, 92);
            this.panelcct.Name = "panelcct";
            this.panelcct.Size = new System.Drawing.Size(374, 34);
            this.panelcct.TabIndex = 156;
            // 
            // txtcctAkhir
            // 
            this.txtcctAkhir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtcctAkhir.ExAllowEmptyString = true;
            this.txtcctAkhir.ExAllowNonDBData = false;
            this.txtcctAkhir.ExAutoCheck = true;
            this.txtcctAkhir.ExAutoShowResult = false;
            this.txtcctAkhir.ExCondition = "";
            this.txtcctAkhir.ExDialogTitle = "Cost Center";
            this.txtcctAkhir.ExFieldName = "Cost Center";
            this.txtcctAkhir.ExFilterFields = new string[0];
            this.txtcctAkhir.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtcctAkhir.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtcctAkhir.ExLabelContainer = null;
            this.txtcctAkhir.ExLabelField = "";
            this.txtcctAkhir.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtcctAkhir.ExLabelText = "";
            this.txtcctAkhir.ExLabelVisible = false;
            this.txtcctAkhir.ExSelectFields = new string[0];
            this.txtcctAkhir.ExShowDialog = true;
            this.txtcctAkhir.ExSimpleMode = true;
            this.txtcctAkhir.ExSqlInstance = null;
            this.txtcctAkhir.ExSqlQuery = "Call SP_LookUp(\'cct\')";
            this.txtcctAkhir.ExTableName = "";
            this.txtcctAkhir.Location = new System.Drawing.Point(245, 7);
            this.txtcctAkhir.Name = "txtcctAkhir";
            this.txtcctAkhir.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtcctAkhir.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtcctAkhir.Properties.Appearance.Options.UseBackColor = true;
            this.txtcctAkhir.Properties.Appearance.Options.UseForeColor = true;
            this.txtcctAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtcctAkhir.Size = new System.Drawing.Size(100, 20);
            this.txtcctAkhir.TabIndex = 145;
            // 
            // txtcctAwal
            // 
            this.txtcctAwal.AllowDrop = true;
            this.txtcctAwal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtcctAwal.ExAllowEmptyString = true;
            this.txtcctAwal.ExAllowNonDBData = false;
            this.txtcctAwal.ExAutoCheck = true;
            this.txtcctAwal.ExAutoShowResult = false;
            this.txtcctAwal.ExCondition = "";
            this.txtcctAwal.ExDialogTitle = "Cost Center";
            this.txtcctAwal.ExFieldName = "Cost Center";
            this.txtcctAwal.ExFilterFields = new string[0];
            this.txtcctAwal.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtcctAwal.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtcctAwal.ExLabelContainer = null;
            this.txtcctAwal.ExLabelField = "";
            this.txtcctAwal.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtcctAwal.ExLabelText = "";
            this.txtcctAwal.ExLabelVisible = false;
            this.txtcctAwal.ExSelectFields = new string[0];
            this.txtcctAwal.ExShowDialog = true;
            this.txtcctAwal.ExSimpleMode = true;
            this.txtcctAwal.ExSqlInstance = null;
            this.txtcctAwal.ExSqlQuery = "Call SP_LookUp(\'cct\')";
            this.txtcctAwal.ExTableName = "";
            this.txtcctAwal.Location = new System.Drawing.Point(83, 7);
            this.txtcctAwal.Name = "txtcctAwal";
            this.txtcctAwal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtcctAwal.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtcctAwal.Properties.Appearance.Options.UseBackColor = true;
            this.txtcctAwal.Properties.Appearance.Options.UseForeColor = true;
            this.txtcctAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtcctAwal.Size = new System.Drawing.Size(100, 20);
            this.txtcctAwal.TabIndex = 143;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 144;
            this.label4.Text = "Cost Center";
            // 
            // FrmLMAktiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 542);
            this.LookAndFeel.SkinName = "";
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.UseWindowsXPTheme = false;
            this.Name = "FrmLMAktiva";
            this.Text = "Laporan Master Aktiva";
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvAwal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccAwal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccAkhir.Properties)).EndInit();
            this.panelcct.ResumeLayout(false);
            this.panelcct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcctAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcctAwal.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private KASLibrary.TextBoxEx txtInvAkhir;
        private KASLibrary.TextBoxEx txtInvAwal;
        private KASLibrary.TextBoxEx txtAccAkhir;
        private System.Windows.Forms.Label label1;
        private KASLibrary.TextBoxEx txtAccAwal;
        private System.Windows.Forms.Panel panelcct;
        private KASLibrary.TextBoxEx txtcctAkhir;
        private KASLibrary.TextBoxEx txtcctAwal;
        private System.Windows.Forms.Label label4;
    }
}