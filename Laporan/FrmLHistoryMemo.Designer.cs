namespace CAS.Laporan
{
    partial class FrmLHistoryMemo
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
            this.dtpTglAkhir = new DevExpress.XtraEditors.DateEdit();
            this.dtpTglAwal = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrqAkhir = new KASLibrary.TextBoxEx();
            this.txtPrqAwal = new KASLibrary.TextBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAwal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrqAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrqAwal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(636, 134);
            this.btnClose.LookAndFeel.SkinName = "";
            this.btnClose.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.LookAndFeel.UseWindowsXPTheme = false;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(555, 134);
            this.btnPreview.LookAndFeel.SkinName = "";
            this.btnPreview.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btnPreview.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnPreview.LookAndFeel.UseWindowsXPTheme = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // printControl
            // 
            this.printControl.Location = new System.Drawing.Point(0, 192);
            this.printControl.Size = new System.Drawing.Size(718, 328);
            // 
            // printPreviewBar
            // 
            this.printPreviewBar.Location = new System.Drawing.Point(0, 164);
            this.printPreviewBar.Size = new System.Drawing.Size(718, 28);
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.dtpTglAkhir);
            this.pnlFilter.Controls.Add(this.dtpTglAwal);
            this.pnlFilter.Controls.Add(this.label3);
            this.pnlFilter.Controls.Add(this.txtPrqAkhir);
            this.pnlFilter.Controls.Add(this.txtPrqAwal);
            this.pnlFilter.Controls.Add(this.label1);
            this.pnlFilter.LookAndFeel.SkinName = "";
            this.pnlFilter.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.pnlFilter.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlFilter.LookAndFeel.UseWindowsXPTheme = false;
            this.pnlFilter.Size = new System.Drawing.Size(718, 164);
            this.pnlFilter.Controls.SetChildIndex(this.btnPreview, 0);
            this.pnlFilter.Controls.SetChildIndex(this.btnClose, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label1, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtPrqAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtPrqAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label3, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dtpTglAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dtpTglAkhir, 0);
            // 
            // dtpTglAkhir
            // 
            this.dtpTglAkhir.EditValue = new System.DateTime(2008, 10, 11, 0, 0, 0, 0);
            this.dtpTglAkhir.Location = new System.Drawing.Point(306, 33);
            this.dtpTglAkhir.Name = "dtpTglAkhir";
            this.dtpTglAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTglAkhir.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAkhir.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAkhir.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAkhir.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAkhir.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtpTglAkhir.Size = new System.Drawing.Size(114, 20);
            this.dtpTglAkhir.TabIndex = 29;
            // 
            // dtpTglAwal
            // 
            this.dtpTglAwal.EditValue = new System.DateTime(2008, 10, 11, 0, 0, 0, 0);
            this.dtpTglAwal.Location = new System.Drawing.Point(117, 33);
            this.dtpTglAwal.Name = "dtpTglAwal";
            this.dtpTglAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTglAwal.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAwal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAwal.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAwal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAwal.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtpTglAwal.Size = new System.Drawing.Size(114, 20);
            this.dtpTglAwal.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tanggal";
            // 
            // txtPrqAkhir
            // 
            this.txtPrqAkhir.ExAllowEmptyString = true;
            this.txtPrqAkhir.ExAllowNonDBData = false;
            this.txtPrqAkhir.ExAutoCheck = true;
            this.txtPrqAkhir.ExAutoShowResult = false;
            this.txtPrqAkhir.ExCondition = "";
            this.txtPrqAkhir.ExDialogTitle = "Memo Purchase Request";
            this.txtPrqAkhir.ExFieldName = "Memo PR";
            this.txtPrqAkhir.ExFilterFields = new string[0];
            this.txtPrqAkhir.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtPrqAkhir.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtPrqAkhir.ExLabelContainer = null;
            this.txtPrqAkhir.ExLabelField = "";
            this.txtPrqAkhir.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtPrqAkhir.ExLabelText = "";
            this.txtPrqAkhir.ExLabelVisible = false;
            this.txtPrqAkhir.ExSelectFields = new string[0];
            this.txtPrqAkhir.ExShowDialog = true;
            this.txtPrqAkhir.ExSimpleMode = true;
            this.txtPrqAkhir.ExSqlInstance = null;
            this.txtPrqAkhir.ExSqlQuery = "select Mpr as `Memo PR`, `date` as Tanggal, remark as Keterangan from mpr where `" +
                "delete`=0";
            this.txtPrqAkhir.ExTableName = "mpr";
            this.txtPrqAkhir.Location = new System.Drawing.Point(306, 62);
            this.txtPrqAkhir.Name = "txtPrqAkhir";
            this.txtPrqAkhir.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrqAkhir.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtPrqAkhir.Properties.Appearance.Options.UseBackColor = true;
            this.txtPrqAkhir.Properties.Appearance.Options.UseForeColor = true;
            this.txtPrqAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtPrqAkhir.Size = new System.Drawing.Size(114, 20);
            this.txtPrqAkhir.TabIndex = 26;
            // 
            // txtPrqAwal
            // 
            this.txtPrqAwal.ExAllowEmptyString = true;
            this.txtPrqAwal.ExAllowNonDBData = false;
            this.txtPrqAwal.ExAutoCheck = true;
            this.txtPrqAwal.ExAutoShowResult = false;
            this.txtPrqAwal.ExCondition = "";
            this.txtPrqAwal.ExDialogTitle = "Memo Purchase Request";
            this.txtPrqAwal.ExFieldName = "Memo PR";
            this.txtPrqAwal.ExFilterFields = new string[0];
            this.txtPrqAwal.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtPrqAwal.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtPrqAwal.ExLabelContainer = null;
            this.txtPrqAwal.ExLabelField = "";
            this.txtPrqAwal.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtPrqAwal.ExLabelText = "";
            this.txtPrqAwal.ExLabelVisible = false;
            this.txtPrqAwal.ExSelectFields = new string[0];
            this.txtPrqAwal.ExShowDialog = true;
            this.txtPrqAwal.ExSimpleMode = true;
            this.txtPrqAwal.ExSqlInstance = null;
            this.txtPrqAwal.ExSqlQuery = "select Mpr as `Memo PR`, `date` as Tanggal, remark as Keterangan from mpr where `" +
                "delete`=0";
            this.txtPrqAwal.ExTableName = "mpr";
            this.txtPrqAwal.Location = new System.Drawing.Point(117, 62);
            this.txtPrqAwal.Name = "txtPrqAwal";
            this.txtPrqAwal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrqAwal.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtPrqAwal.Properties.Appearance.Options.UseBackColor = true;
            this.txtPrqAwal.Properties.Appearance.Options.UseForeColor = true;
            this.txtPrqAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtPrqAwal.Size = new System.Drawing.Size(114, 20);
            this.txtPrqAwal.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "No Memo";
            // 
            // FrmLHistoryMemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(718, 542);
            this.LookAndFeel.SkinName = "";
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.UseWindowsXPTheme = false;
            this.Name = "FrmLHistoryMemo";
            this.Load += new System.EventHandler(this.FrmLHistoryMemo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAwal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrqAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrqAwal.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dtpTglAkhir;
        private DevExpress.XtraEditors.DateEdit dtpTglAwal;
        private System.Windows.Forms.Label label3;
        private KASLibrary.TextBoxEx txtPrqAkhir;
        private KASLibrary.TextBoxEx txtPrqAwal;
        private System.Windows.Forms.Label label1;
    }
}
