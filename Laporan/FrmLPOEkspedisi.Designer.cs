namespace CAS.Laporan
{
    partial class FrmLPOEkspedisi
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
            this.txtOmsAkhir = new KASLibrary.TextBoxEx();
            this.txtOmsAwal = new KASLibrary.TextBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOmsAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOmsAwal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(509, 104);
            this.btnClose.LookAndFeel.SkinName = "";
            this.btnClose.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.LookAndFeel.UseWindowsXPTheme = false;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(428, 104);
            this.btnPreview.LookAndFeel.SkinName = "";
            this.btnPreview.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btnPreview.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnPreview.LookAndFeel.UseWindowsXPTheme = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // printControl
            // 
            this.printControl.Location = new System.Drawing.Point(0, 160);
            this.printControl.Size = new System.Drawing.Size(675, 246);
            // 
            // printPreviewBar
            // 
            this.printPreviewBar.Size = new System.Drawing.Size(675, 28);
            // 
            // printPreviewStatus
            // 
            this.printPreviewStatus.Location = new System.Drawing.Point(0, 406);
            this.printPreviewStatus.Size = new System.Drawing.Size(675, 22);
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.txtOmsAkhir);
            this.pnlFilter.Controls.Add(this.txtOmsAwal);
            this.pnlFilter.Controls.Add(this.label1);
            this.pnlFilter.LookAndFeel.SkinName = "";
            this.pnlFilter.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.pnlFilter.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlFilter.LookAndFeel.UseWindowsXPTheme = false;
            this.pnlFilter.Size = new System.Drawing.Size(675, 132);
            this.pnlFilter.Controls.SetChildIndex(this.btnPreview, 0);
            this.pnlFilter.Controls.SetChildIndex(this.btnClose, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label1, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtOmsAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtOmsAkhir, 0);
            // 
            // txtOmsAkhir
            // 
            this.txtOmsAkhir.ExAllowEmptyString = true;
            this.txtOmsAkhir.ExAllowNonDBData = false;
            this.txtOmsAkhir.ExAutoCheck = true;
            this.txtOmsAkhir.ExAutoShowResult = false;
            this.txtOmsAkhir.ExCondition = "";
            this.txtOmsAkhir.ExDialogTitle = "Order Pembelian";
            this.txtOmsAkhir.ExFieldName = "No PO";
            this.txtOmsAkhir.ExFilterFields = new string[0];
            this.txtOmsAkhir.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtOmsAkhir.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtOmsAkhir.ExLabelContainer = null;
            this.txtOmsAkhir.ExLabelField = "";
            this.txtOmsAkhir.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtOmsAkhir.ExLabelText = "";
            this.txtOmsAkhir.ExLabelVisible = false;
            this.txtOmsAkhir.ExSelectFields = new string[0];
            this.txtOmsAkhir.ExShowDialog = true;
            this.txtOmsAkhir.ExSimpleMode = true;
            this.txtOmsAkhir.ExSqlInstance = null;
            this.txtOmsAkhir.ExSqlQuery = "select oms as `No PO`, `date` as Tanggal, remark as Keterangan from oms where `de" +
                "lete`=0";
            this.txtOmsAkhir.ExTableName = "oms";
            this.txtOmsAkhir.Location = new System.Drawing.Point(273, 35);
            this.txtOmsAkhir.Name = "txtOmsAkhir";
            this.txtOmsAkhir.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtOmsAkhir.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtOmsAkhir.Properties.Appearance.Options.UseBackColor = true;
            this.txtOmsAkhir.Properties.Appearance.Options.UseForeColor = true;
            this.txtOmsAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtOmsAkhir.Size = new System.Drawing.Size(114, 20);
            this.txtOmsAkhir.TabIndex = 21;
            // 
            // txtOmsAwal
            // 
            this.txtOmsAwal.ExAllowEmptyString = true;
            this.txtOmsAwal.ExAllowNonDBData = false;
            this.txtOmsAwal.ExAutoCheck = true;
            this.txtOmsAwal.ExAutoShowResult = false;
            this.txtOmsAwal.ExCondition = "";
            this.txtOmsAwal.ExDialogTitle = "Order Pembelian";
            this.txtOmsAwal.ExFieldName = "No PO";
            this.txtOmsAwal.ExFilterFields = new string[0];
            this.txtOmsAwal.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtOmsAwal.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtOmsAwal.ExLabelContainer = null;
            this.txtOmsAwal.ExLabelField = "";
            this.txtOmsAwal.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtOmsAwal.ExLabelText = "";
            this.txtOmsAwal.ExLabelVisible = false;
            this.txtOmsAwal.ExSelectFields = new string[0];
            this.txtOmsAwal.ExShowDialog = true;
            this.txtOmsAwal.ExSimpleMode = true;
            this.txtOmsAwal.ExSqlInstance = null;
            this.txtOmsAwal.ExSqlQuery = "select oms as `No PO`, `date` as Tanggal, remark as Keterangan from oms where `de" +
                "lete`=0";
            this.txtOmsAwal.ExTableName = "oms";
            this.txtOmsAwal.Location = new System.Drawing.Point(84, 35);
            this.txtOmsAwal.Name = "txtOmsAwal";
            this.txtOmsAwal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtOmsAwal.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtOmsAwal.Properties.Appearance.Options.UseBackColor = true;
            this.txtOmsAwal.Properties.Appearance.Options.UseForeColor = true;
            this.txtOmsAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtOmsAwal.Size = new System.Drawing.Size(114, 20);
            this.txtOmsAwal.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "No PO";
            // 
            // FrmLPOEkspedisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 428);
            this.LookAndFeel.SkinName = "";
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.UseWindowsXPTheme = false;
            this.Name = "FrmLPOEkspedisi";
            this.Text = "FrmLPOEkspedisi";
            this.Load += new System.EventHandler(this.FrmLPOEkspedisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOmsAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOmsAwal.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KASLibrary.TextBoxEx txtOmsAkhir;
        private KASLibrary.TextBoxEx txtOmsAwal;
        private System.Windows.Forms.Label label1;
    }
}