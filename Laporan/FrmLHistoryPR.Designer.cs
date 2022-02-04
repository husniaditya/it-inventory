namespace CAS.Laporan
{
    partial class FrmLHistoryPR
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
            this.txtSubAkhir = new KASLibrary.TextBoxEx();
            this.txtSubAwal = new KASLibrary.TextBoxEx();
            this.lblSupplier = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAwal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrqAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrqAwal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubAwal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(415, 206);
            this.btnClose.LookAndFeel.SkinName = "";
            this.btnClose.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.LookAndFeel.UseWindowsXPTheme = false;
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(293, 206);
            this.btnPreview.LookAndFeel.SkinName = "";
            this.btnPreview.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btnPreview.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnPreview.LookAndFeel.UseWindowsXPTheme = false;
            this.btnPreview.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // printControl
            // 
            this.printControl.Location = new System.Drawing.Point(0, 280);
            this.printControl.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.printControl.Size = new System.Drawing.Size(1077, 520);
            // 
            // printPreviewBar
            // 
            this.printPreviewBar.Location = new System.Drawing.Point(0, 252);
            this.printPreviewBar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.printPreviewBar.Size = new System.Drawing.Size(1077, 28);
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.txtSubAkhir);
            this.pnlFilter.Controls.Add(this.txtSubAwal);
            this.pnlFilter.Controls.Add(this.lblSupplier);
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
            this.pnlFilter.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pnlFilter.Size = new System.Drawing.Size(1077, 252);
            this.pnlFilter.Controls.SetChildIndex(this.btnPreview, 0);
            this.pnlFilter.Controls.SetChildIndex(this.btnClose, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label1, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtPrqAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtPrqAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label3, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dtpTglAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dtpTglAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.lblSupplier, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtSubAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtSubAkhir, 0);
            // 
            // dtpTglAkhir
            // 
            this.dtpTglAkhir.EditValue = new System.DateTime(2008, 10, 11, 0, 0, 0, 0);
            this.dtpTglAkhir.Location = new System.Drawing.Point(459, 51);
            this.dtpTglAkhir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpTglAkhir.Name = "dtpTglAkhir";
            this.dtpTglAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTglAkhir.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAkhir.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAkhir.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAkhir.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAkhir.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtpTglAkhir.Size = new System.Drawing.Size(171, 26);
            this.dtpTglAkhir.TabIndex = 29;
            // 
            // dtpTglAwal
            // 
            this.dtpTglAwal.EditValue = new System.DateTime(2008, 10, 11, 0, 0, 0, 0);
            this.dtpTglAwal.Location = new System.Drawing.Point(176, 51);
            this.dtpTglAwal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpTglAwal.Name = "dtpTglAwal";
            this.dtpTglAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTglAwal.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAwal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAwal.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAwal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAwal.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtpTglAwal.Size = new System.Drawing.Size(171, 26);
            this.dtpTglAwal.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
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
            this.txtPrqAkhir.ExDialogTitle = "Purchase Request";
            this.txtPrqAkhir.ExFieldName = "No PR";
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
            this.txtPrqAkhir.ExSqlQuery = "select prq as `No PR`, `date` as Tanggal, remark as Keterangan from prq where `de" +
                "lete`=0";
            this.txtPrqAkhir.ExTableName = "oms";
            this.txtPrqAkhir.Location = new System.Drawing.Point(459, 95);
            this.txtPrqAkhir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrqAkhir.Name = "txtPrqAkhir";
            this.txtPrqAkhir.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrqAkhir.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtPrqAkhir.Properties.Appearance.Options.UseBackColor = true;
            this.txtPrqAkhir.Properties.Appearance.Options.UseForeColor = true;
            this.txtPrqAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtPrqAkhir.Size = new System.Drawing.Size(171, 26);
            this.txtPrqAkhir.TabIndex = 26;
            // 
            // txtPrqAwal
            // 
            this.txtPrqAwal.ExAllowEmptyString = true;
            this.txtPrqAwal.ExAllowNonDBData = false;
            this.txtPrqAwal.ExAutoCheck = true;
            this.txtPrqAwal.ExAutoShowResult = false;
            this.txtPrqAwal.ExCondition = "";
            this.txtPrqAwal.ExDialogTitle = "Purchase Request";
            this.txtPrqAwal.ExFieldName = "No PR";
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
            this.txtPrqAwal.ExSqlQuery = "select prq as `No PR`, `date` as Tanggal, remark as Keterangan from prq where `de" +
                "lete`=0";
            this.txtPrqAwal.ExTableName = "oms";
            this.txtPrqAwal.Location = new System.Drawing.Point(176, 95);
            this.txtPrqAwal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrqAwal.Name = "txtPrqAwal";
            this.txtPrqAwal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrqAwal.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtPrqAwal.Properties.Appearance.Options.UseBackColor = true;
            this.txtPrqAwal.Properties.Appearance.Options.UseForeColor = true;
            this.txtPrqAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtPrqAwal.Size = new System.Drawing.Size(171, 26);
            this.txtPrqAwal.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "No PR";
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
            this.txtSubAkhir.ExSqlQuery = "Call SP_LookUp(\'supplier\')";
            this.txtSubAkhir.ExTableName = "";
            this.txtSubAkhir.Location = new System.Drawing.Point(459, 135);
            this.txtSubAkhir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSubAkhir.Name = "txtSubAkhir";
            this.txtSubAkhir.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtSubAkhir.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtSubAkhir.Properties.Appearance.Options.UseBackColor = true;
            this.txtSubAkhir.Properties.Appearance.Options.UseForeColor = true;
            this.txtSubAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtSubAkhir.Size = new System.Drawing.Size(171, 26);
            this.txtSubAkhir.TabIndex = 32;
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
            this.txtSubAwal.ExSqlQuery = "Call SP_LookUp(\'supplier\')";
            this.txtSubAwal.ExTableName = "";
            this.txtSubAwal.Location = new System.Drawing.Point(176, 135);
            this.txtSubAwal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSubAwal.Name = "txtSubAwal";
            this.txtSubAwal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtSubAwal.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtSubAwal.Properties.Appearance.Options.UseBackColor = true;
            this.txtSubAwal.Properties.Appearance.Options.UseForeColor = true;
            this.txtSubAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtSubAwal.Size = new System.Drawing.Size(171, 26);
            this.txtSubAwal.TabIndex = 31;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(80, 140);
            this.lblSupplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(67, 19);
            this.lblSupplier.TabIndex = 30;
            this.lblSupplier.Text = "Supplier";
            // 
            // FrmLHistoryPR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(1077, 834);
            this.LookAndFeel.SkinName = "";
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.UseWindowsXPTheme = false;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "FrmLHistoryPR";
            this.Load += new System.EventHandler(this.FrmLHistoryPR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAwal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrqAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrqAwal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubAwal.Properties)).EndInit();
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
        private KASLibrary.TextBoxEx txtSubAkhir;
        private KASLibrary.TextBoxEx txtSubAwal;
        private System.Windows.Forms.Label lblSupplier;
    }
}
