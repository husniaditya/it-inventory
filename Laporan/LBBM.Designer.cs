namespace CAS.Laporan
{
    partial class FrmLBBM
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
            this.dtpTglAkhir = new DevExpress.XtraEditors.DateEdit();
            this.dtpTglAwal = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BBKEx1 = new KASLibrary.TextBoxEx();
            this.BBKEx2 = new KASLibrary.TextBoxEx();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubAwal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAwal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BBKEx1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BBKEx2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(415, 154);
            this.btnClose.LookAndFeel.SkinName = "";
            this.btnClose.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.LookAndFeel.UseWindowsXPTheme = false;
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(293, 154);
            this.btnPreview.LookAndFeel.SkinName = "";
            this.btnPreview.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btnPreview.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnPreview.LookAndFeel.UseWindowsXPTheme = false;
            this.btnPreview.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // printControl
            // 
            this.printControl.Location = new System.Drawing.Point(0, 228);
            this.printControl.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.printControl.Size = new System.Drawing.Size(1077, 572);
            // 
            // printPreviewBar
            // 
            this.printPreviewBar.Location = new System.Drawing.Point(0, 200);
            this.printPreviewBar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.printPreviewBar.Size = new System.Drawing.Size(1077, 28);
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.BBKEx2);
            this.pnlFilter.Controls.Add(this.BBKEx1);
            this.pnlFilter.Controls.Add(this.label1);
            this.pnlFilter.Controls.Add(this.dtpTglAkhir);
            this.pnlFilter.Controls.Add(this.dtpTglAwal);
            this.pnlFilter.Controls.Add(this.label3);
            this.pnlFilter.Controls.Add(this.txtSubAkhir);
            this.pnlFilter.Controls.Add(this.txtSubAwal);
            this.pnlFilter.Controls.Add(this.label2);
            this.pnlFilter.LookAndFeel.SkinName = "";
            this.pnlFilter.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.pnlFilter.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlFilter.LookAndFeel.UseWindowsXPTheme = false;
            this.pnlFilter.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pnlFilter.Size = new System.Drawing.Size(1077, 200);
            this.pnlFilter.Controls.SetChildIndex(this.btnPreview, 0);
            this.pnlFilter.Controls.SetChildIndex(this.btnClose, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label2, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtSubAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtSubAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label3, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dtpTglAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dtpTglAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label1, 0);
            this.pnlFilter.Controls.SetChildIndex(this.BBKEx1, 0);
            this.pnlFilter.Controls.SetChildIndex(this.BBKEx2, 0);
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
            this.txtSubAkhir.ExSqlQuery = "Call SP_LookUp(\'supplier\')";
            this.txtSubAkhir.ExTableName = "";
            this.txtSubAkhir.Location = new System.Drawing.Point(478, 72);
            this.txtSubAkhir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSubAkhir.Name = "txtSubAkhir";
            this.txtSubAkhir.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtSubAkhir.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtSubAkhir.Properties.Appearance.Options.UseBackColor = true;
            this.txtSubAkhir.Properties.Appearance.Options.UseForeColor = true;
            this.txtSubAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtSubAkhir.Size = new System.Drawing.Size(171, 26);
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
            this.txtSubAwal.ExSqlQuery = "Call SP_LookUp(\'supplier\')";
            this.txtSubAwal.ExTableName = "";
            this.txtSubAwal.Location = new System.Drawing.Point(195, 72);
            this.txtSubAwal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSubAwal.Name = "txtSubAwal";
            this.txtSubAwal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtSubAwal.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtSubAwal.Properties.Appearance.Options.UseBackColor = true;
            this.txtSubAwal.Properties.Appearance.Options.UseForeColor = true;
            this.txtSubAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtSubAwal.Size = new System.Drawing.Size(171, 26);
            this.txtSubAwal.TabIndex = 123;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 122;
            this.label2.Text = "Supplier";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtpTglAkhir
            // 
            this.dtpTglAkhir.EditValue = new System.DateTime(2008, 8, 20, 15, 40, 28, 0);
            this.dtpTglAkhir.Location = new System.Drawing.Point(478, 32);
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
            this.dtpTglAkhir.TabIndex = 130;
            // 
            // dtpTglAwal
            // 
            this.dtpTglAwal.EditValue = new System.DateTime(2008, 8, 20, 15, 40, 28, 0);
            this.dtpTglAwal.Location = new System.Drawing.Point(195, 32);
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
            this.dtpTglAwal.TabIndex = 129;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 128;
            this.label3.Text = "Tanggal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 131;
            this.label1.Text = "BBM No";
            // 
            // BBKEx1
            // 
            this.BBKEx1.ExAllowEmptyString = true;
            this.BBKEx1.ExAllowNonDBData = false;
            this.BBKEx1.ExAutoCheck = true;
            this.BBKEx1.ExAutoShowResult = false;
            this.BBKEx1.ExCondition = "";
            this.BBKEx1.ExDialogTitle = "BBK No";
            this.BBKEx1.ExFieldName = "BBK";
            this.BBKEx1.ExFilterFields = new string[0];
            this.BBKEx1.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.BBKEx1.ExInvalidForeColor = System.Drawing.Color.Black;
            this.BBKEx1.ExLabelContainer = null;
            this.BBKEx1.ExLabelField = "";
            this.BBKEx1.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.BBKEx1.ExLabelText = "";
            this.BBKEx1.ExLabelVisible = false;
            this.BBKEx1.ExSelectFields = new string[0];
            this.BBKEx1.ExShowDialog = true;
            this.BBKEx1.ExSimpleMode = true;
            this.BBKEx1.ExSqlInstance = null;
            this.BBKEx1.ExSqlQuery = "Select kas as BBK,kas.date from kas where left(kas,3) = \'BBM\'";
            this.BBKEx1.ExTableName = "";
            this.BBKEx1.Location = new System.Drawing.Point(195, 117);
            this.BBKEx1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BBKEx1.Name = "BBKEx1";
            this.BBKEx1.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.BBKEx1.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BBKEx1.Properties.Appearance.Options.UseBackColor = true;
            this.BBKEx1.Properties.Appearance.Options.UseForeColor = true;
            this.BBKEx1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.BBKEx1.Size = new System.Drawing.Size(171, 26);
            this.BBKEx1.TabIndex = 132;
            // 
            // BBKEx2
            // 
            this.BBKEx2.ExAllowEmptyString = true;
            this.BBKEx2.ExAllowNonDBData = false;
            this.BBKEx2.ExAutoCheck = true;
            this.BBKEx2.ExAutoShowResult = false;
            this.BBKEx2.ExCondition = "";
            this.BBKEx2.ExDialogTitle = "BBK No";
            this.BBKEx2.ExFieldName = "BBK";
            this.BBKEx2.ExFilterFields = new string[0];
            this.BBKEx2.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.BBKEx2.ExInvalidForeColor = System.Drawing.Color.Black;
            this.BBKEx2.ExLabelContainer = null;
            this.BBKEx2.ExLabelField = "";
            this.BBKEx2.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.BBKEx2.ExLabelText = "";
            this.BBKEx2.ExLabelVisible = false;
            this.BBKEx2.ExSelectFields = new string[0];
            this.BBKEx2.ExShowDialog = true;
            this.BBKEx2.ExSimpleMode = true;
            this.BBKEx2.ExSqlInstance = null;
            this.BBKEx2.ExSqlQuery = "Select kas as BBK,kas.date from kas where left(kas,3) = \'BBM\'";
            this.BBKEx2.ExTableName = "";
            this.BBKEx2.Location = new System.Drawing.Point(478, 117);
            this.BBKEx2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BBKEx2.Name = "BBKEx2";
            this.BBKEx2.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.BBKEx2.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BBKEx2.Properties.Appearance.Options.UseBackColor = true;
            this.BBKEx2.Properties.Appearance.Options.UseForeColor = true;
            this.BBKEx2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.BBKEx2.Size = new System.Drawing.Size(171, 26);
            this.BBKEx2.TabIndex = 133;
            // 
            // FrmLBBM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(1077, 834);
            this.LookAndFeel.SkinName = "";
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.UseWindowsXPTheme = false;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "FrmLBBM";
            this.Load += new System.EventHandler(this.FrmLBBM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubAwal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAwal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BBKEx1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BBKEx2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KASLibrary.TextBoxEx txtSubAkhir;
        private KASLibrary.TextBoxEx txtSubAwal;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit dtpTglAkhir;
        private DevExpress.XtraEditors.DateEdit dtpTglAwal;
        private System.Windows.Forms.Label label3;
        private KASLibrary.TextBoxEx BBKEx1;
        private System.Windows.Forms.Label label1;
        private KASLibrary.TextBoxEx BBKEx2;
    }
}
