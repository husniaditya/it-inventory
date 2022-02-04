namespace CAS.Laporan
{
    partial class FrmLAvgPembelian
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
            this.txtInvAkhir = new KASLibrary.TextBoxEx();
            this.txtInvAwal = new KASLibrary.TextBoxEx();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTglAkhir = new DevExpress.XtraEditors.DateEdit();
            this.dtpTglAwal = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtJenisAkhir = new KASLibrary.TextBoxEx();
            this.txtJenisAwal = new KASLibrary.TextBoxEx();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvAwal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAwal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJenisAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJenisAwal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(631, 70);
            this.btnClose.LookAndFeel.SkinName = "";
            this.btnClose.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.LookAndFeel.UseWindowsXPTheme = false;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(550, 70);
            this.btnPreview.LookAndFeel.SkinName = "";
            this.btnPreview.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btnPreview.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnPreview.LookAndFeel.UseWindowsXPTheme = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // printControl
            // 
            this.printControl.Location = new System.Drawing.Point(0, 147);
            this.printControl.Size = new System.Drawing.Size(718, 373);
            // 
            // printPreviewBar
            // 
            this.printPreviewBar.Location = new System.Drawing.Point(0, 119);
            this.printPreviewBar.Size = new System.Drawing.Size(718, 28);
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.label6);
            this.pnlFilter.Controls.Add(this.txtJenisAkhir);
            this.pnlFilter.Controls.Add(this.txtJenisAwal);
            this.pnlFilter.Controls.Add(this.txtInvAkhir);
            this.pnlFilter.Controls.Add(this.txtInvAwal);
            this.pnlFilter.Controls.Add(this.label3);
            this.pnlFilter.Controls.Add(this.dtpTglAkhir);
            this.pnlFilter.Controls.Add(this.dtpTglAwal);
            this.pnlFilter.Controls.Add(this.label1);
            this.pnlFilter.LookAndFeel.SkinName = "";
            this.pnlFilter.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.pnlFilter.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlFilter.LookAndFeel.UseWindowsXPTheme = false;
            this.pnlFilter.Size = new System.Drawing.Size(718, 119);
            this.pnlFilter.Controls.SetChildIndex(this.btnPreview, 0);
            this.pnlFilter.Controls.SetChildIndex(this.btnClose, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label1, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dtpTglAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dtpTglAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label3, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtInvAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtInvAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtJenisAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtJenisAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label6, 0);
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
            this.txtInvAkhir.ExSqlQuery = "Call SP_LookUp(\'inv1\')";
            this.txtInvAkhir.ExTableName = "";
            this.txtInvAkhir.Location = new System.Drawing.Point(346, 73);
            this.txtInvAkhir.Name = "txtInvAkhir";
            this.txtInvAkhir.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtInvAkhir.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtInvAkhir.Properties.Appearance.Options.UseBackColor = true;
            this.txtInvAkhir.Properties.Appearance.Options.UseForeColor = true;
            this.txtInvAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtInvAkhir.Size = new System.Drawing.Size(114, 20);
            this.txtInvAkhir.TabIndex = 121;
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
            this.txtInvAwal.ExSqlQuery = "Call SP_LookUp(\'inv1\')";
            this.txtInvAwal.ExTableName = "";
            this.txtInvAwal.Location = new System.Drawing.Point(157, 73);
            this.txtInvAwal.Name = "txtInvAwal";
            this.txtInvAwal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtInvAwal.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtInvAwal.Properties.Appearance.Options.UseBackColor = true;
            this.txtInvAwal.Properties.Appearance.Options.UseForeColor = true;
            this.txtInvAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtInvAwal.Size = new System.Drawing.Size(114, 20);
            this.txtInvAwal.TabIndex = 120;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 119;
            this.label3.Text = "Persediaan";
            // 
            // dtpTglAkhir
            // 
            this.dtpTglAkhir.EditValue = new System.DateTime(2008, 8, 20, 15, 40, 28, 0);
            this.dtpTglAkhir.Location = new System.Drawing.Point(346, 12);
            this.dtpTglAkhir.Name = "dtpTglAkhir";
            this.dtpTglAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTglAkhir.Properties.DisplayFormat.FormatString = "MMMM yyyy";
            this.dtpTglAkhir.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAkhir.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAkhir.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAkhir.Properties.Mask.EditMask = "MMMM yyyy";
            this.dtpTglAkhir.Size = new System.Drawing.Size(114, 20);
            this.dtpTglAkhir.TabIndex = 118;
            // 
            // dtpTglAwal
            // 
            this.dtpTglAwal.EditValue = new System.DateTime(2008, 8, 20, 15, 40, 28, 0);
            this.dtpTglAwal.Location = new System.Drawing.Point(157, 12);
            this.dtpTglAwal.Name = "dtpTglAwal";
            this.dtpTglAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTglAwal.Properties.DisplayFormat.FormatString = "MMMM yyyy";
            this.dtpTglAwal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAwal.Properties.EditFormat.FormatString = "MMMM yyyy";
            this.dtpTglAwal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAwal.Properties.Mask.EditMask = "MMMM yyyy";
            this.dtpTglAwal.Size = new System.Drawing.Size(114, 20);
            this.dtpTglAwal.TabIndex = 117;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 116;
            this.label1.Text = "Tanggal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 129;
            this.label6.Text = "Kelompok Persediaan";
            // 
            // txtJenisAkhir
            // 
            this.txtJenisAkhir.ExAllowEmptyString = true;
            this.txtJenisAkhir.ExAllowNonDBData = false;
            this.txtJenisAkhir.ExAutoCheck = true;
            this.txtJenisAkhir.ExAutoShowResult = false;
            this.txtJenisAkhir.ExCondition = "";
            this.txtJenisAkhir.ExDialogTitle = "Kelompok Persediaan";
            this.txtJenisAkhir.ExFieldName = "Jenis";
            this.txtJenisAkhir.ExFilterFields = new string[0];
            this.txtJenisAkhir.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtJenisAkhir.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtJenisAkhir.ExLabelContainer = null;
            this.txtJenisAkhir.ExLabelField = "Nama";
            this.txtJenisAkhir.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtJenisAkhir.ExLabelText = "";
            this.txtJenisAkhir.ExLabelVisible = true;
            this.txtJenisAkhir.ExSelectFields = new string[0];
            this.txtJenisAkhir.ExShowDialog = true;
            this.txtJenisAkhir.ExSimpleMode = true;
            this.txtJenisAkhir.ExSqlInstance = null;
            this.txtJenisAkhir.ExSqlQuery = "Call SP_LookUp(\'jenis1\')";
            this.txtJenisAkhir.ExTableName = "";
            this.txtJenisAkhir.Location = new System.Drawing.Point(346, 38);
            this.txtJenisAkhir.Name = "txtJenisAkhir";
            this.txtJenisAkhir.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtJenisAkhir.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtJenisAkhir.Properties.Appearance.Options.UseBackColor = true;
            this.txtJenisAkhir.Properties.Appearance.Options.UseForeColor = true;
            this.txtJenisAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtJenisAkhir.Size = new System.Drawing.Size(114, 20);
            this.txtJenisAkhir.TabIndex = 128;
            // 
            // txtJenisAwal
            // 
            this.txtJenisAwal.ExAllowEmptyString = true;
            this.txtJenisAwal.ExAllowNonDBData = false;
            this.txtJenisAwal.ExAutoCheck = true;
            this.txtJenisAwal.ExAutoShowResult = false;
            this.txtJenisAwal.ExCondition = "";
            this.txtJenisAwal.ExDialogTitle = "Kelompok Persediaan";
            this.txtJenisAwal.ExFieldName = "Jenis";
            this.txtJenisAwal.ExFilterFields = new string[0];
            this.txtJenisAwal.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtJenisAwal.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtJenisAwal.ExLabelContainer = null;
            this.txtJenisAwal.ExLabelField = "Nama";
            this.txtJenisAwal.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtJenisAwal.ExLabelText = "";
            this.txtJenisAwal.ExLabelVisible = true;
            this.txtJenisAwal.ExSelectFields = new string[0];
            this.txtJenisAwal.ExShowDialog = true;
            this.txtJenisAwal.ExSimpleMode = true;
            this.txtJenisAwal.ExSqlInstance = null;
            this.txtJenisAwal.ExSqlQuery = "Call SP_LookUp(\'jenis1\')";
            this.txtJenisAwal.ExTableName = "";
            this.txtJenisAwal.Location = new System.Drawing.Point(157, 38);
            this.txtJenisAwal.Name = "txtJenisAwal";
            this.txtJenisAwal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtJenisAwal.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtJenisAwal.Properties.Appearance.Options.UseBackColor = true;
            this.txtJenisAwal.Properties.Appearance.Options.UseForeColor = true;
            this.txtJenisAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtJenisAwal.Size = new System.Drawing.Size(114, 20);
            this.txtJenisAwal.TabIndex = 127;
            // 
            // FrmLAvgPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 542);
            this.LookAndFeel.SkinName = "";
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.UseWindowsXPTheme = false;
            this.Name = "FrmLAvgPembelian";
            this.Text = "Pembelian";
            this.Load += new System.EventHandler(this.FrmLAvgPembelian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvAwal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAwal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJenisAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJenisAwal.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KASLibrary.TextBoxEx txtInvAkhir;
        private KASLibrary.TextBoxEx txtInvAwal;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.DateEdit dtpTglAkhir;
        private DevExpress.XtraEditors.DateEdit dtpTglAwal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private KASLibrary.TextBoxEx txtJenisAkhir;
        private KASLibrary.TextBoxEx txtJenisAwal;
    }
}