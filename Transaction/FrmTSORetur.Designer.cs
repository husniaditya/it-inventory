namespace CAS.Transaction
{
    partial class FrmTSORetur
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label remarkLabel;
            System.Windows.Forms.Label duedateLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label ppnLabel;
            System.Windows.Forms.Label closeLabel;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label nopocLabel;
            this.ctrlSub = new CAS.Transaction.CtrlSub();
            this.casDataSet = new CAS.casDataSet();
            this.rsmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rsmTableAdapter = new CAS.casDataSetTableAdapters.rsmTableAdapter();
            this.remarkMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.TOPSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.ppnCheckBox = new System.Windows.Forms.CheckBox();
            this.closeCheckBox = new System.Windows.Forms.CheckBox();
            this.gcxRsmd = new KASLibrary.GridControlEx();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.txtSubtotal = new DevExpress.XtraEditors.TextEdit();
            this.txtPPN = new DevExpress.XtraEditors.TextEdit();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.rsmdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rsmdTableAdapter = new CAS.casDataSetTableAdapters.rsmdTableAdapter();
            this.nopocTextEdit = new DevExpress.XtraEditors.TextEdit();
            remarkLabel = new System.Windows.Forms.Label();
            duedateLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ppnLabel = new System.Windows.Forms.Label();
            closeLabel = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            nopocLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludSeri.Properties)).BeginInit();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curkurs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curcur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TOPSpinEdit.Properties)).BeginInit();
            this.pnlTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubtotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPPN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsmdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nopocTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNo
            // 
            this.txtNo.EditValueChanged += new System.EventHandler(this.txtNo_EditValueChanged);
            // 
            // txtPeriod
            // 
            // 
            // ludSeri
            // 
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(nopocLabel);
            this.pnlDetail.Controls.Add(this.nopocTextEdit);
            this.pnlDetail.Controls.Add(this.pnlTotal);
            this.pnlDetail.Controls.Add(this.gcxRsmd);
            this.pnlDetail.Controls.Add(closeLabel);
            this.pnlDetail.Controls.Add(this.closeCheckBox);
            this.pnlDetail.Controls.Add(ppnLabel);
            this.pnlDetail.Controls.Add(this.ppnCheckBox);
            this.pnlDetail.Controls.Add(label2);
            this.pnlDetail.Controls.Add(this.TOPSpinEdit);
            this.pnlDetail.Controls.Add(duedateLabel);
            this.pnlDetail.Controls.Add(remarkLabel);
            this.pnlDetail.Controls.Add(this.remarkMemoEdit);
            this.pnlDetail.Controls.Add(this.ctrlSub);
            this.pnlDetail.Size = new System.Drawing.Size(663, 589);
            this.pnlDetail.Controls.SetChildIndex(this.ctrlSub, 0);
            this.pnlDetail.Controls.SetChildIndex(this.remarkMemoEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(remarkLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(duedateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.TOPSpinEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(label2, 0);
            this.pnlDetail.Controls.SetChildIndex(this.ppnCheckBox, 0);
            this.pnlDetail.Controls.SetChildIndex(ppnLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.closeCheckBox, 0);
            this.pnlDetail.Controls.SetChildIndex(closeLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.gcxRsmd, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curLabel1, 0);
            this.pnlDetail.Controls.SetChildIndex(this.kursLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curkurs, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curcur, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateDate, 0);
            this.pnlDetail.Controls.SetChildIndex(this.pnlTotal, 0);
            this.pnlDetail.Controls.SetChildIndex(this.nopocTextEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(nopocLabel, 0);
            // 
            // pnlKey
            // 
            this.pnlKey.Size = new System.Drawing.Size(663, 50);
            // 
            // dateDate
            // 
            this.dateDate.EditValue = new System.DateTime(((long)(0)));
            this.dateDate.Location = new System.Drawing.Point(461, 12);
            this.dateDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateDate.Properties.Mask.IgnoreMaskBlank = false;
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(409, 15);
            // 
            // curkurs
            // 
            this.curkurs.Location = new System.Drawing.Point(560, 38);
            // 
            // curcur
            // 
            this.curcur.Location = new System.Drawing.Point(461, 38);
            this.curcur.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.curcur.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.curcur.Properties.Appearance.Options.UseBackColor = true;
            this.curcur.Properties.Appearance.Options.UseForeColor = true;
            // 
            // curLabel1
            // 
            this.curLabel1.Location = new System.Drawing.Point(430, 41);
            // 
            // kursLabel
            // 
            this.kursLabel.Location = new System.Drawing.Point(524, 41);
            // 
            // btnDocFlow
            // 
            this.btnDocFlow.Visible = true;
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(16, 164);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(63, 13);
            remarkLabel.TabIndex = 29;
            remarkLabel.Text = "Keterangan";
            // 
            // duedateLabel
            // 
            duedateLabel.AutoSize = true;
            duedateLabel.Location = new System.Drawing.Point(427, 67);
            duedateLabel.Name = "duedateLabel";
            duedateLabel.Size = new System.Drawing.Size(27, 13);
            duedateLabel.TabIndex = 88;
            duedateLabel.Text = "TOP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(524, 67);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(31, 13);
            label2.TabIndex = 90;
            label2.Text = "Days";
            // 
            // ppnLabel
            // 
            ppnLabel.AutoSize = true;
            ppnLabel.Location = new System.Drawing.Point(427, 96);
            ppnLabel.Name = "ppnLabel";
            ppnLabel.Size = new System.Drawing.Size(26, 13);
            ppnLabel.TabIndex = 90;
            ppnLabel.Text = "PPN";
            // 
            // closeLabel
            // 
            closeLabel.AutoSize = true;
            closeLabel.Location = new System.Drawing.Point(426, 122);
            closeLabel.Name = "closeLabel";
            closeLabel.Size = new System.Drawing.Size(33, 13);
            closeLabel.TabIndex = 92;
            closeLabel.Text = "Close";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(13, 10);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(52, 13);
            label6.TabIndex = 111;
            label6.Text = "Sub Total";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(13, 54);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(31, 13);
            label9.TabIndex = 113;
            label9.Text = "Total";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(13, 33);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(26, 13);
            label8.TabIndex = 112;
            label8.Text = "PPN";
            // 
            // nopocLabel
            // 
            nopocLabel.AutoSize = true;
            nopocLabel.Location = new System.Drawing.Point(32, 140);
            nopocLabel.Name = "nopocLabel";
            nopocLabel.Size = new System.Drawing.Size(46, 13);
            nopocLabel.TabIndex = 117;
            nopocLabel.Text = "PO Cust";
            // 
            // ctrlSub
            // 
            this.ctrlSub.Location = new System.Drawing.Point(21, 9);
            this.ctrlSub.Name = "ctrlSub";
            this.ctrlSub.ReadOnly = true;
            this.ctrlSub.Size = new System.Drawing.Size(335, 115);
            this.ctrlSub.TabIndex = 29;
            this.ctrlSub.Type = CAS.Transaction.CtrlSub.SubType.Customer;
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rsmBindingSource
            // 
            this.rsmBindingSource.DataMember = "rsm";
            this.rsmBindingSource.DataSource = this.casDataSet;
            // 
            // rsmTableAdapter
            // 
            this.rsmTableAdapter.ClearBeforeFill = true;
            // 
            // remarkMemoEdit
            // 
            this.remarkMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rsmBindingSource, "remark", true));
            this.remarkMemoEdit.Location = new System.Drawing.Point(84, 162);
            this.remarkMemoEdit.Name = "remarkMemoEdit";
            this.remarkMemoEdit.Size = new System.Drawing.Size(261, 46);
            this.remarkMemoEdit.TabIndex = 30;
            // 
            // TOPSpinEdit
            // 
            this.TOPSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.TOPSpinEdit.Location = new System.Drawing.Point(461, 64);
            this.TOPSpinEdit.Name = "TOPSpinEdit";
            this.TOPSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.TOPSpinEdit.Properties.UseCtrlIncrement = false;
            this.TOPSpinEdit.Size = new System.Drawing.Size(57, 20);
            this.TOPSpinEdit.TabIndex = 89;
            // 
            // ppnCheckBox
            // 
            this.ppnCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.rsmBindingSource, "ppn", true));
            this.ppnCheckBox.Location = new System.Drawing.Point(461, 91);
            this.ppnCheckBox.Name = "ppnCheckBox";
            this.ppnCheckBox.Size = new System.Drawing.Size(29, 24);
            this.ppnCheckBox.TabIndex = 91;
            // 
            // closeCheckBox
            // 
            this.closeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.rsmBindingSource, "close", true));
            this.closeCheckBox.Location = new System.Drawing.Point(461, 117);
            this.closeCheckBox.Name = "closeCheckBox";
            this.closeCheckBox.Size = new System.Drawing.Size(34, 24);
            this.closeCheckBox.TabIndex = 93;
            // 
            // gcxRsmd
            // 
            this.gcxRsmd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcxRsmd.BestFitColumn = true;
            this.gcxRsmd.ExAutoSize = false;
            this.gcxRsmd.Location = new System.Drawing.Point(21, 225);
            this.gcxRsmd.Name = "gcxRsmd";
            this.gcxRsmd.Size = new System.Drawing.Size(621, 273);
            this.gcxRsmd.TabIndex = 94;
            // 
            // pnlTotal
            // 
            this.pnlTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTotal.Controls.Add(label6);
            this.pnlTotal.Controls.Add(this.txtSubtotal);
            this.pnlTotal.Controls.Add(this.txtPPN);
            this.pnlTotal.Controls.Add(label9);
            this.pnlTotal.Controls.Add(this.txtTotal);
            this.pnlTotal.Controls.Add(label8);
            this.pnlTotal.Location = new System.Drawing.Point(429, 504);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(213, 79);
            this.pnlTotal.TabIndex = 117;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(79, 8);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSubtotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSubtotal.Size = new System.Drawing.Size(121, 20);
            this.txtSubtotal.TabIndex = 108;
            // 
            // txtPPN
            // 
            this.txtPPN.Enabled = false;
            this.txtPPN.Location = new System.Drawing.Point(79, 30);
            this.txtPPN.Name = "txtPPN";
            this.txtPPN.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPPN.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtPPN.Size = new System.Drawing.Size(121, 20);
            this.txtPPN.TabIndex = 109;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(79, 51);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotal.Size = new System.Drawing.Size(121, 20);
            this.txtTotal.TabIndex = 110;
            // 
            // rsmdBindingSource
            // 
            this.rsmdBindingSource.DataMember = "rsmd";
            this.rsmdBindingSource.DataSource = this.casDataSet;
            // 
            // rsmdTableAdapter
            // 
            this.rsmdTableAdapter.ClearBeforeFill = true;
            // 
            // nopocTextEdit
            // 
            this.nopocTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rsmBindingSource, "nopoc", true));
            this.nopocTextEdit.Location = new System.Drawing.Point(84, 137);
            this.nopocTextEdit.Name = "nopocTextEdit";
            this.nopocTextEdit.Size = new System.Drawing.Size(151, 20);
            this.nopocTextEdit.TabIndex = 118;
            // 
            // FrmTSORetur
            // 
            this.ClientSize = new System.Drawing.Size(663, 719);
            this.DetailBindingSource = this.rsmdBindingSource;
            this.DetailTable = this.casDataSet.rsmd;
            this.MasterBindingSource = this.rsmBindingSource;
            this.MasterTable = this.casDataSet.rsm;
            this.Name = "FrmTSORetur";
            this.Text = "SO Retur";
            this.Load += new System.EventHandler(this.FrmTSORetur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludSeri.Properties)).EndInit();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.pnlKey.ResumeLayout(false);
            this.pnlKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curkurs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curcur.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TOPSpinEdit.Properties)).EndInit();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubtotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPPN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsmdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nopocTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CtrlSub ctrlSub;
        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource rsmBindingSource;
        private CAS.casDataSetTableAdapters.rsmTableAdapter rsmTableAdapter;
        private DevExpress.XtraEditors.MemoEdit remarkMemoEdit;
        private DevExpress.XtraEditors.SpinEdit TOPSpinEdit;
        private System.Windows.Forms.CheckBox ppnCheckBox;
        private System.Windows.Forms.CheckBox closeCheckBox;
        private KASLibrary.GridControlEx gcxRsmd;
        private System.Windows.Forms.Panel pnlTotal;
        private DevExpress.XtraEditors.TextEdit txtSubtotal;
        private DevExpress.XtraEditors.TextEdit txtPPN;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private System.Windows.Forms.BindingSource rsmdBindingSource;
        private CAS.casDataSetTableAdapters.rsmdTableAdapter rsmdTableAdapter;
        private DevExpress.XtraEditors.TextEdit nopocTextEdit;
    }
}
