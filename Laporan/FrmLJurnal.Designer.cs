namespace CAS.Laporan
{
    partial class FrmLJurnal
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTglAwal = new DevExpress.XtraEditors.DateEdit();
            this.dtpTglAkhir = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoSeriAkhir = new KASLibrary.TextBoxEx();
            this.txtNoSeriAwal = new KASLibrary.TextBoxEx();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAwal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoSeriAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoSeriAwal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(638, 106);
            this.btnClose.LookAndFeel.SkinName = "";
            this.btnClose.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.LookAndFeel.UseWindowsXPTheme = false;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(557, 106);
            this.btnPreview.LookAndFeel.SkinName = "";
            this.btnPreview.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btnPreview.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnPreview.LookAndFeel.UseWindowsXPTheme = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // printControl
            // 
            this.printControl.Location = new System.Drawing.Point(0, 162);
            this.printControl.Size = new System.Drawing.Size(718, 358);
            // 
            // printPreviewBar
            // 
            this.printPreviewBar.Location = new System.Drawing.Point(0, 134);
            this.printPreviewBar.Size = new System.Drawing.Size(718, 28);
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.label2);
            this.pnlFilter.Controls.Add(this.txtNoSeriAkhir);
            this.pnlFilter.Controls.Add(this.txtNoSeriAwal);
            this.pnlFilter.Controls.Add(this.label1);
            this.pnlFilter.Controls.Add(this.dtpTglAwal);
            this.pnlFilter.Controls.Add(this.dtpTglAkhir);
            this.pnlFilter.LookAndFeel.SkinName = "";
            this.pnlFilter.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.pnlFilter.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlFilter.LookAndFeel.UseWindowsXPTheme = false;
            this.pnlFilter.Size = new System.Drawing.Size(718, 134);
            this.pnlFilter.Controls.SetChildIndex(this.btnPreview, 0);
            this.pnlFilter.Controls.SetChildIndex(this.btnClose, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dtpTglAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dtpTglAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label1, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtNoSeriAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtNoSeriAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label2, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tanggal";
            // 
            // dtpTglAwal
            // 
            this.dtpTglAwal.EditValue = new System.DateTime(2008, 8, 20, 15, 40, 28, 0);
            this.dtpTglAwal.Location = new System.Drawing.Point(157, 23);
            this.dtpTglAwal.Name = "dtpTglAwal";
            this.dtpTglAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTglAwal.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAwal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAwal.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAwal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAwal.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtpTglAwal.Size = new System.Drawing.Size(100, 20);
            this.dtpTglAwal.TabIndex = 13;
            // 
            // dtpTglAkhir
            // 
            this.dtpTglAkhir.EditValue = new System.DateTime(2008, 8, 20, 15, 40, 28, 0);
            this.dtpTglAkhir.Location = new System.Drawing.Point(319, 23);
            this.dtpTglAkhir.Name = "dtpTglAkhir";
            this.dtpTglAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTglAkhir.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAkhir.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAkhir.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAkhir.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAkhir.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtpTglAkhir.Size = new System.Drawing.Size(100, 20);
            this.dtpTglAkhir.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "No Seri";
            // 
            // txtNoSeriAkhir
            // 
            this.txtNoSeriAkhir.ExAllowEmptyString = true;
            this.txtNoSeriAkhir.ExAllowNonDBData = false;
            this.txtNoSeriAkhir.ExAutoCheck = true;
            this.txtNoSeriAkhir.ExAutoShowResult = false;
            this.txtNoSeriAkhir.ExCondition = "";
            this.txtNoSeriAkhir.ExDialogTitle = "No Seri";
            this.txtNoSeriAkhir.ExFieldName = "No Seri";
            this.txtNoSeriAkhir.ExFilterFields = new string[0];
            this.txtNoSeriAkhir.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtNoSeriAkhir.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtNoSeriAkhir.ExLabelContainer = null;
            this.txtNoSeriAkhir.ExLabelField = "Keterangan";
            this.txtNoSeriAkhir.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtNoSeriAkhir.ExLabelVisible = true;
            this.txtNoSeriAkhir.ExSelectFields = new string[0];
            this.txtNoSeriAkhir.ExShowDialog = true;
            this.txtNoSeriAkhir.ExSimpleMode = true;
            this.txtNoSeriAkhir.ExSqlInstance = null;
            this.txtNoSeriAkhir.ExSqlQuery = "Call SP_LookUp(\'noseri\')";
            this.txtNoSeriAkhir.ExTableName = "";
            this.txtNoSeriAkhir.Location = new System.Drawing.Point(319, 61);
            this.txtNoSeriAkhir.Name = "txtNoSeriAkhir";
            this.txtNoSeriAkhir.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtNoSeriAkhir.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtNoSeriAkhir.Properties.Appearance.Options.UseBackColor = true;
            this.txtNoSeriAkhir.Properties.Appearance.Options.UseForeColor = true;
            this.txtNoSeriAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtNoSeriAkhir.Size = new System.Drawing.Size(100, 20);
            this.txtNoSeriAkhir.TabIndex = 17;
            // 
            // txtNoSeriAwal
            // 
            this.txtNoSeriAwal.ExAllowEmptyString = true;
            this.txtNoSeriAwal.ExAllowNonDBData = false;
            this.txtNoSeriAwal.ExAutoCheck = true;
            this.txtNoSeriAwal.ExAutoShowResult = false;
            this.txtNoSeriAwal.ExCondition = "";
            this.txtNoSeriAwal.ExDialogTitle = "No Seri";
            this.txtNoSeriAwal.ExFieldName = "No Seri";
            this.txtNoSeriAwal.ExFilterFields = new string[0];
            this.txtNoSeriAwal.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtNoSeriAwal.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtNoSeriAwal.ExLabelContainer = null;
            this.txtNoSeriAwal.ExLabelField = "Keterangan";
            this.txtNoSeriAwal.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtNoSeriAwal.ExLabelVisible = true;
            this.txtNoSeriAwal.ExSelectFields = new string[0];
            this.txtNoSeriAwal.ExShowDialog = true;
            this.txtNoSeriAwal.ExSimpleMode = true;
            this.txtNoSeriAwal.ExSqlInstance = null;
            this.txtNoSeriAwal.ExSqlQuery = "Call SP_LookUp(\'noseri\')";
            this.txtNoSeriAwal.ExTableName = "";
            this.txtNoSeriAwal.Location = new System.Drawing.Point(157, 61);
            this.txtNoSeriAwal.Name = "txtNoSeriAwal";
            this.txtNoSeriAwal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtNoSeriAwal.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtNoSeriAwal.Properties.Appearance.Options.UseBackColor = true;
            this.txtNoSeriAwal.Properties.Appearance.Options.UseForeColor = true;
            this.txtNoSeriAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtNoSeriAwal.Size = new System.Drawing.Size(100, 20);
            this.txtNoSeriAwal.TabIndex = 16;
            // 
            // FrmLJurnal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 542);
            this.LookAndFeel.SkinName = "";
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.UseWindowsXPTheme = false;
            this.Name = "FrmLJurnal";
            this.Text = "FrmLJurnal";
            this.Load += new System.EventHandler(this.FrmLJurnal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAwal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoSeriAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoSeriAwal.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit dtpTglAwal;
        private DevExpress.XtraEditors.DateEdit dtpTglAkhir;
        private System.Windows.Forms.Label label2;
        private KASLibrary.TextBoxEx txtNoSeriAkhir;
        private KASLibrary.TextBoxEx txtNoSeriAwal;
    }
}