namespace CAS.Laporan
{
    partial class FrmLNeraca
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
            this.spinLvl = new DevExpress.XtraEditors.SpinEdit();
            this.dateDate2 = new DevExpress.XtraEditors.DateEdit();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateDate1 = new DevExpress.XtraEditors.DateEdit();
            this.Level = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinLvl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate1.Properties)).BeginInit();
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
            this.printControl.Location = new System.Drawing.Point(0, 231);
            this.printControl.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.printControl.Size = new System.Drawing.Size(1077, 569);
            // 
            // printPreviewBar
            // 
            this.printPreviewBar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.printPreviewBar.Size = new System.Drawing.Size(1077, 28);
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.Level);
            this.pnlFilter.Controls.Add(this.spinLvl);
            this.pnlFilter.Controls.Add(this.dateDate2);
            this.pnlFilter.Controls.Add(this.dateLabel);
            this.pnlFilter.Controls.Add(this.dateDate1);
            this.pnlFilter.LookAndFeel.SkinName = "";
            this.pnlFilter.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.pnlFilter.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlFilter.LookAndFeel.UseWindowsXPTheme = false;
            this.pnlFilter.Controls.SetChildIndex(this.btnPreview, 0);
            this.pnlFilter.Controls.SetChildIndex(this.btnClose, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dateDate1, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dateLabel, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dateDate2, 0);
            this.pnlFilter.Controls.SetChildIndex(this.spinLvl, 0);
            this.pnlFilter.Controls.SetChildIndex(this.Level, 0);
            // 
            // spinLvl
            // 
            this.spinLvl.EditValue = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.spinLvl.Location = new System.Drawing.Point(93, 74);
            this.spinLvl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.spinLvl.Name = "spinLvl";
            this.spinLvl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinLvl.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinLvl.Properties.IsFloatValue = false;
            this.spinLvl.Properties.Mask.EditMask = "N00";
            this.spinLvl.Properties.UseCtrlIncrement = false;
            this.spinLvl.Size = new System.Drawing.Size(84, 26);
            this.spinLvl.TabIndex = 119;
            // 
            // dateDate2
            // 
            this.dateDate2.EditValue = new System.DateTime(((long)(0)));
            this.dateDate2.Location = new System.Drawing.Point(272, 18);
            this.dateDate2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateDate2.Name = "dateDate2";
            this.dateDate2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDate2.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateDate2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateDate2.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateDate2.Properties.Mask.IgnoreMaskBlank = false;
            this.dateDate2.Size = new System.Drawing.Size(150, 26);
            this.dateDate2.TabIndex = 116;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(15, 23);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(66, 19);
            this.dateLabel.TabIndex = 115;
            this.dateLabel.Text = "Tanggal";
            // 
            // dateDate1
            // 
            this.dateDate1.EditValue = new System.DateTime(((long)(0)));
            this.dateDate1.Location = new System.Drawing.Point(93, 18);
            this.dateDate1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateDate1.Name = "dateDate1";
            this.dateDate1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDate1.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateDate1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateDate1.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateDate1.Properties.Mask.IgnoreMaskBlank = false;
            this.dateDate1.Size = new System.Drawing.Size(150, 26);
            this.dateDate1.TabIndex = 114;
            // 
            // Level
            // 
            this.Level.AutoSize = true;
            this.Level.Location = new System.Drawing.Point(32, 78);
            this.Level.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(45, 19);
            this.Level.TabIndex = 120;
            this.Level.Text = "Level";
            // 
            // FrmLNeraca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 834);
            this.LookAndFeel.SkinName = "";
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.UseWindowsXPTheme = false;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "FrmLNeraca";
            this.Text = "FrmLNeraca";
            this.Load += new System.EventHandler(this.FrmLNeraca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinLvl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SpinEdit spinLvl;
        protected DevExpress.XtraEditors.DateEdit dateDate2;
        protected System.Windows.Forms.Label dateLabel;
        protected DevExpress.XtraEditors.DateEdit dateDate1;
        protected System.Windows.Forms.Label Level;
    }
}