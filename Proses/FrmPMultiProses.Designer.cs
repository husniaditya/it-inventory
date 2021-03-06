namespace CAS.Proses
{
    partial class FrmPMultiProses
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
            this.gcxResult = new KASLibrary.GridControlEx();
            this.btnShow = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rgAction = new DevExpress.XtraEditors.RadioGroup();
            this.label1 = new System.Windows.Forms.Label();
            this.chkPeriode = new DevExpress.XtraEditors.CheckEdit();
            this.dateFrom = new DevExpress.XtraEditors.DateEdit();
            this.dateTo = new DevExpress.XtraEditors.DateEdit();
            this.btnAction = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.ludTransactions = new DevExpress.XtraEditors.LookUpEdit();
            this.checkapp = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.rgAction.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPeriode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludTransactions.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcxResult
            // 
            this.gcxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcxResult.BestFitColumn = true;
            this.gcxResult.ExAutoSize = false;
            this.gcxResult.Location = new System.Drawing.Point(12, 146);
            this.gcxResult.Name = "gcxResult";
            this.gcxResult.Size = new System.Drawing.Size(706, 324);
            this.gcxResult.TabIndex = 0;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(383, 85);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "S&how";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 117;
            this.label4.Text = "Action";
            // 
            // rgAction
            // 
            this.rgAction.Location = new System.Drawing.Point(91, 85);
            this.rgAction.Name = "rgAction";
            this.rgAction.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("aprov", "Approve"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("close", "Close"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("delete", "Delete"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("print", "Print"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("closeitem", "Close Item PO")});
            this.rgAction.Size = new System.Drawing.Size(286, 55);
            this.rgAction.TabIndex = 116;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 117;
            this.label1.Text = "Transaction";
            // 
            // chkPeriode
            // 
            this.chkPeriode.EditValue = true;
            this.chkPeriode.Location = new System.Drawing.Point(21, 54);
            this.chkPeriode.Name = "chkPeriode";
            this.chkPeriode.Properties.Caption = "Periode";
            this.chkPeriode.Size = new System.Drawing.Size(68, 18);
            this.chkPeriode.TabIndex = 120;
            this.chkPeriode.CheckedChanged += new System.EventHandler(this.chkPeriode_CheckedChanged);
            // 
            // dateFrom
            // 
            this.dateFrom.EditValue = new System.DateTime(((long)(0)));
            this.dateFrom.Location = new System.Drawing.Point(91, 52);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFrom.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateFrom.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateFrom.Properties.Mask.IgnoreMaskBlank = false;
            this.dateFrom.Size = new System.Drawing.Size(100, 23);
            this.dateFrom.TabIndex = 121;
            // 
            // dateTo
            // 
            this.dateTo.EditValue = new System.DateTime(((long)(0)));
            this.dateTo.Location = new System.Drawing.Point(209, 52);
            this.dateTo.Name = "dateTo";
            this.dateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTo.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateTo.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateTo.Properties.Mask.IgnoreMaskBlank = false;
            this.dateTo.Size = new System.Drawing.Size(100, 23);
            this.dateTo.TabIndex = 121;
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(483, 117);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(106, 23);
            this.btnAction.TabIndex = 2;
            this.btnAction.Text = "&All";
            this.btnAction.Visible = false;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(595, 117);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ludTransactions
            // 
            this.ludTransactions.Location = new System.Drawing.Point(91, 18);
            this.ludTransactions.Name = "ludTransactions";
            this.ludTransactions.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ludTransactions.Size = new System.Drawing.Size(218, 23);
            this.ludTransactions.TabIndex = 122;
            // 
            // checkapp
            // 
            this.checkapp.AutoSize = true;
            this.checkapp.Location = new System.Drawing.Point(383, 20);
            this.checkapp.Name = "checkapp";
            this.checkapp.Size = new System.Drawing.Size(180, 17);
            this.checkapp.TabIndex = 123;
            this.checkapp.Text = "Show all aproval PO Transaction";
            this.checkapp.UseVisualStyleBackColor = true;
            // 
            // FrmPMultiProses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 482);
            this.Controls.Add(this.gcxResult);
            this.Controls.Add(this.checkapp);
            this.Controls.Add(this.ludTransactions);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.chkPeriode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rgAction);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.btnShow);
            this.Name = "FrmPMultiProses";
            this.Text = "FrmPMultiProses";
            this.Load += new System.EventHandler(this.FrmPMultiProses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgAction.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPeriode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludTransactions.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KASLibrary.GridControlEx gcxResult;
        private DevExpress.XtraEditors.SimpleButton btnShow;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.RadioGroup rgAction;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.CheckEdit chkPeriode;
        protected DevExpress.XtraEditors.DateEdit dateFrom;
        protected DevExpress.XtraEditors.DateEdit dateTo;
        private DevExpress.XtraEditors.SimpleButton btnAction;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LookUpEdit ludTransactions;
        private System.Windows.Forms.CheckBox checkapp;
    }
}