namespace CAS.Transaction
{
    partial class FrmRFP
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label sspdateLabel;
            System.Windows.Forms.Label fakdateLabel;
            System.Windows.Forms.Label label3;
            this.rfdTableAdapter = new CAS.casDataSetTableAdapters.rfdTableAdapter();
            this.rfpTableAdapter = new CAS.casDataSetTableAdapters.rfpTableAdapter();
            this.casDataSet = new CAS.casDataSet();
            this.rfpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rfdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ctrlSub = new CAS.Transaction.CtrlSub();
            this.remarkMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.kembalidateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.terimadateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.gcRFD = new KASLibrary.GridControlEx();
            label2 = new System.Windows.Forms.Label();
            sspdateLabel = new System.Windows.Forms.Label();
            fakdateLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludSeri.Properties)).BeginInit();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curkurs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curcur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rfpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rfdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kembalidateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terimadateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNo
            // 
            // 
            // txtPeriod
            // 
            // 
            // ludSeri
            // 
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.txtTotal);
            this.pnlDetail.Controls.Add(label3);
            this.pnlDetail.Controls.Add(this.gcRFD);
            this.pnlDetail.Controls.Add(this.kembalidateDateEdit);
            this.pnlDetail.Controls.Add(sspdateLabel);
            this.pnlDetail.Controls.Add(this.terimadateDateEdit);
            this.pnlDetail.Controls.Add(fakdateLabel);
            this.pnlDetail.Controls.Add(this.ctrlSub);
            this.pnlDetail.Controls.Add(this.remarkMemoEdit);
            this.pnlDetail.Controls.Add(label2);
            this.pnlDetail.Size = new System.Drawing.Size(742, 403);
            this.pnlDetail.Controls.SetChildIndex(this.curcur, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curkurs, 0);
            this.pnlDetail.Controls.SetChildIndex(this.kursLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curLabel1, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateDate, 0);
            this.pnlDetail.Controls.SetChildIndex(label2, 0);
            this.pnlDetail.Controls.SetChildIndex(this.remarkMemoEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(this.ctrlSub, 0);
            this.pnlDetail.Controls.SetChildIndex(fakdateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.terimadateDateEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(sspdateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.kembalidateDateEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(this.gcRFD, 0);
            this.pnlDetail.Controls.SetChildIndex(label3, 0);
            this.pnlDetail.Controls.SetChildIndex(this.txtTotal, 0);
            // 
            // pnlKey
            // 
            this.pnlKey.Size = new System.Drawing.Size(742, 50);
            // 
            // dateDate
            // 
            this.dateDate.EditValue = new System.DateTime(((long)(0)));
            this.dateDate.Location = new System.Drawing.Point(488, 9);
            this.dateDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateDate.Properties.Mask.IgnoreMaskBlank = false;
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(436, 12);
            // 
            // curkurs
            // 
            this.curkurs.Location = new System.Drawing.Point(587, 35);
            this.curkurs.Visible = false;
            // 
            // curcur
            // 
            this.curcur.Location = new System.Drawing.Point(488, 35);
            this.curcur.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.curcur.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.curcur.Properties.Appearance.Options.UseBackColor = true;
            this.curcur.Properties.Appearance.Options.UseForeColor = true;
            this.curcur.EditValueChanged += new System.EventHandler(this.curcur_EditValueChanged);
            // 
            // curLabel1
            // 
            this.curLabel1.Location = new System.Drawing.Point(457, 38);
            // 
            // kursLabel
            // 
            this.kursLabel.Location = new System.Drawing.Point(551, 38);
            this.kursLabel.Visible = false;
            // 
            // btnDocFlow
            // 
            this.btnDocFlow.Visible = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(9, 136);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(63, 13);
            label2.TabIndex = 117;
            label2.Text = "Keterangan";
            // 
            // sspdateLabel
            // 
            sspdateLabel.AutoSize = true;
            sspdateLabel.Location = new System.Drawing.Point(393, 65);
            sspdateLabel.Name = "sspdateLabel";
            sspdateLabel.Size = new System.Drawing.Size(86, 13);
            sspdateLabel.TabIndex = 120;
            sspdateLabel.Text = "Tgl Jatuh Tempo";
            // 
            // fakdateLabel
            // 
            fakdateLabel.AutoSize = true;
            fakdateLabel.Location = new System.Drawing.Point(421, 93);
            fakdateLabel.Name = "fakdateLabel";
            fakdateLabel.Size = new System.Drawing.Size(60, 13);
            fakdateLabel.TabIndex = 122;
            fakdateLabel.Text = "Tgl Kembali";
            fakdateLabel.Visible = false;
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(552, 378);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(31, 13);
            label3.TabIndex = 131;
            label3.Text = "Total";
            // 
            // rfdTableAdapter
            // 
            this.rfdTableAdapter.ClearBeforeFill = true;
            // 
            // rfpTableAdapter
            // 
            this.rfpTableAdapter.ClearBeforeFill = true;
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rfpBindingSource
            // 
            this.rfpBindingSource.AllowNew = true;
            this.rfpBindingSource.DataMember = "rfp";
            this.rfpBindingSource.DataSource = this.casDataSet;
            this.rfpBindingSource.Filter = "";
            // 
            // rfdBindingSource
            // 
            this.rfdBindingSource.DataMember = "rfd";
            this.rfdBindingSource.DataSource = this.casDataSet;
            // 
            // ctrlSub
            // 
            this.ctrlSub.Location = new System.Drawing.Point(12, 11);
            this.ctrlSub.Name = "ctrlSub";
            this.ctrlSub.ReadOnly = true;
            this.ctrlSub.Size = new System.Drawing.Size(335, 115);
            this.ctrlSub.TabIndex = 119;
            this.ctrlSub.Type = CAS.Transaction.CtrlSub.SubType.Supplier;
            // 
            // remarkMemoEdit
            // 
            this.remarkMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rfpBindingSource, "remark", true));
            this.remarkMemoEdit.Location = new System.Drawing.Point(76, 134);
            this.remarkMemoEdit.Name = "remarkMemoEdit";
            this.remarkMemoEdit.Size = new System.Drawing.Size(271, 56);
            this.remarkMemoEdit.TabIndex = 118;
            // 
            // kembalidateDateEdit
            // 
            this.kembalidateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rfpBindingSource, "tglkembali", true));
            this.kembalidateDateEdit.EditValue = null;
            this.kembalidateDateEdit.Location = new System.Drawing.Point(485, 90);
            this.kembalidateDateEdit.Name = "kembalidateDateEdit";
            this.kembalidateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.kembalidateDateEdit.Size = new System.Drawing.Size(94, 23);
            this.kembalidateDateEdit.TabIndex = 123;
            this.kembalidateDateEdit.Visible = false;
            // 
            // terimadateDateEdit
            // 
            this.terimadateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rfpBindingSource, "tglterima", true));
            this.terimadateDateEdit.EditValue = null;
            this.terimadateDateEdit.Location = new System.Drawing.Point(485, 61);
            this.terimadateDateEdit.Name = "terimadateDateEdit";
            this.terimadateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.terimadateDateEdit.Size = new System.Drawing.Size(94, 23);
            this.terimadateDateEdit.TabIndex = 121;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rfpBindingSource, "val", true));
            this.txtTotal.Location = new System.Drawing.Point(600, 375);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotal.Properties.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(121, 20);
            this.txtTotal.TabIndex = 130;
            // 
            // gcRFD
            // 
            this.gcRFD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcRFD.BestFitColumn = true;
            this.gcRFD.ExAutoSize = false;
            this.gcRFD.Location = new System.Drawing.Point(12, 196);
            this.gcRFD.Name = "gcRFD";
            this.gcRFD.Size = new System.Drawing.Size(709, 170);
            this.gcRFD.TabIndex = 129;
            // 
            // FrmRFP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 533);
            this.DetailBindingSource = this.rfdBindingSource;
            this.DetailTable = this.casDataSet.rfd;
            this.MasterBindingSource = this.rfpBindingSource;
            this.MasterTable = this.casDataSet.rfp;
            this.Name = "FrmRFP";
            this.Text = "FrmRFP";
            this.Load += new System.EventHandler(this.FrmRFP_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.rfpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rfdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kembalidateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terimadateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource rfpBindingSource;
        private System.Windows.Forms.BindingSource rfdBindingSource;
        private CAS.casDataSetTableAdapters.rfpTableAdapter rfpTableAdapter;
        private CAS.casDataSetTableAdapters.rfdTableAdapter rfdTableAdapter;
        private CtrlSub ctrlSub;
        private DevExpress.XtraEditors.MemoEdit remarkMemoEdit;
        private DevExpress.XtraEditors.DateEdit kembalidateDateEdit;
        private DevExpress.XtraEditors.DateEdit terimadateDateEdit;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private KASLibrary.GridControlEx gcRFD;
    }
}