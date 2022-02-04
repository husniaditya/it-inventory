namespace CAS.Laporan
{
    partial class FrmLNeracaSaldo
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
            System.Windows.Forms.Label nopocLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateDate1 = new DevExpress.XtraEditors.DateEdit();
            this.dateDate2 = new DevExpress.XtraEditors.DateEdit();
            this.spinLvl = new DevExpress.XtraEditors.SpinEdit();
            this.txtarea = new KASLibrary.TextBoxEx();
            nopocLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinLvl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtarea.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(600, 68);
            this.btnClose.LookAndFeel.SkinName = "";
            this.btnClose.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.LookAndFeel.UseWindowsXPTheme = false;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(519, 68);
            this.btnPreview.LookAndFeel.SkinName = "";
            this.btnPreview.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btnPreview.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnPreview.LookAndFeel.UseWindowsXPTheme = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // printControl
            // 
            this.printControl.Location = new System.Drawing.Point(0, 126);
            this.printControl.Size = new System.Drawing.Size(712, 431);
            // 
            // printPreviewBar
            // 
            this.printPreviewBar.Location = new System.Drawing.Point(0, 98);
            this.printPreviewBar.Size = new System.Drawing.Size(712, 28);
            // 
            // printPreviewStatus
            // 
            this.printPreviewStatus.Location = new System.Drawing.Point(0, 557);
            this.printPreviewStatus.Size = new System.Drawing.Size(712, 22);
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(label2);
            this.pnlFilter.Controls.Add(this.txtarea);
            this.pnlFilter.Controls.Add(this.spinLvl);
            this.pnlFilter.Controls.Add(label1);
            this.pnlFilter.Controls.Add(nopocLabel);
            this.pnlFilter.Controls.Add(this.dateDate2);
            this.pnlFilter.Controls.Add(this.dateLabel);
            this.pnlFilter.Controls.Add(this.dateDate1);
            this.pnlFilter.LookAndFeel.SkinName = "";
            this.pnlFilter.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.pnlFilter.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlFilter.LookAndFeel.UseWindowsXPTheme = false;
            this.pnlFilter.Size = new System.Drawing.Size(712, 98);
            this.pnlFilter.Controls.SetChildIndex(this.btnPreview, 0);
            this.pnlFilter.Controls.SetChildIndex(this.btnClose, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dateDate1, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dateLabel, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dateDate2, 0);
            this.pnlFilter.Controls.SetChildIndex(nopocLabel, 0);
            this.pnlFilter.Controls.SetChildIndex(label1, 0);
            this.pnlFilter.Controls.SetChildIndex(this.spinLvl, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtarea, 0);
            this.pnlFilter.Controls.SetChildIndex(label2, 0);
            // 
            // nopocLabel
            // 
            nopocLabel.AutoSize = true;
            nopocLabel.Location = new System.Drawing.Point(49, 42);
            nopocLabel.Name = "nopocLabel";
            nopocLabel.Size = new System.Drawing.Size(32, 13);
            nopocLabel.TabIndex = 58;
            nopocLabel.Text = "Level";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(30, 55);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(52, 13);
            label1.TabIndex = 60;
            label1.Text = "Perkiraan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(376, 18);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 13);
            label2.TabIndex = 115;
            label2.Text = "Bisnis Area";
            label2.Visible = false;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(36, 15);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(45, 13);
            this.dateLabel.TabIndex = 11;
            this.dateLabel.Text = "Tanggal";
            // 
            // dateDate1
            // 
            this.dateDate1.EditValue = new System.DateTime(((long)(0)));
            this.dateDate1.Location = new System.Drawing.Point(88, 12);
            this.dateDate1.Name = "dateDate1";
            this.dateDate1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDate1.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateDate1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateDate1.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateDate1.Properties.Mask.IgnoreMaskBlank = false;
            this.dateDate1.Size = new System.Drawing.Size(100, 20);
            this.dateDate1.TabIndex = 10;
            // 
            // dateDate2
            // 
            this.dateDate2.EditValue = new System.DateTime(((long)(0)));
            this.dateDate2.Location = new System.Drawing.Point(207, 12);
            this.dateDate2.Name = "dateDate2";
            this.dateDate2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDate2.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateDate2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateDate2.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateDate2.Properties.Mask.IgnoreMaskBlank = false;
            this.dateDate2.Size = new System.Drawing.Size(100, 20);
            this.dateDate2.TabIndex = 12;
            // 
            // spinLvl
            // 
            this.spinLvl.EditValue = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.spinLvl.Location = new System.Drawing.Point(88, 48);
            this.spinLvl.Name = "spinLvl";
            this.spinLvl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinLvl.Properties.UseCtrlIncrement = false;
            this.spinLvl.Size = new System.Drawing.Size(56, 20);
            this.spinLvl.TabIndex = 113;
            // 
            // txtarea
            // 
            this.txtarea.ExAllowEmptyString = true;
            this.txtarea.ExAllowNonDBData = false;
            this.txtarea.ExAutoCheck = true;
            this.txtarea.ExAutoShowResult = false;
            this.txtarea.ExCondition = "";
            this.txtarea.ExDialogTitle = "Inventory";
            this.txtarea.ExFieldName = "Kode Akun";
            this.txtarea.ExFilterFields = new string[0];
            this.txtarea.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtarea.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtarea.ExLabelContainer = null;
            this.txtarea.ExLabelField = "Keterangan";
            this.txtarea.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtarea.ExLabelText = "";
            this.txtarea.ExLabelVisible = true;
            this.txtarea.ExSelectFields = new string[0];
            this.txtarea.ExShowDialog = true;
            this.txtarea.ExSimpleMode = true;
            this.txtarea.ExSqlInstance = null;
            this.txtarea.ExSqlQuery = "Call SP_LookUp(\'acc\')";
            this.txtarea.ExTableName = "";
            this.txtarea.Location = new System.Drawing.Point(441, 15);
            this.txtarea.Name = "txtarea";
            this.txtarea.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtarea.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtarea.Properties.Appearance.Options.UseBackColor = true;
            this.txtarea.Properties.Appearance.Options.UseForeColor = true;
            this.txtarea.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtarea.Size = new System.Drawing.Size(100, 20);
            this.txtarea.TabIndex = 114;
            this.txtarea.Visible = false;
            // 
            // FrmLNeracaSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 579);
            this.LookAndFeel.SkinName = "";
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.UseWindowsXPTheme = false;
            this.Name = "FrmLNeracaSaldo";
            this.Text = "Laporan Neraca Saldo";
            this.Load += new System.EventHandler(this.FrmLNeracaSaldo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinLvl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtarea.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected DevExpress.XtraEditors.DateEdit dateDate2;
        protected System.Windows.Forms.Label dateLabel;
        protected DevExpress.XtraEditors.DateEdit dateDate1;
        private DevExpress.XtraEditors.SpinEdit spinLvl;
        private KASLibrary.TextBoxEx txtarea;
    }
}