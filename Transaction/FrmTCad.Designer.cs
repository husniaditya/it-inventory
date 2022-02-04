namespace CAS.Transaction
{
    partial class FrmTCad
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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            this.remarkLabel = new System.Windows.Forms.Label();
            this.casDataSet = new CAS.casDataSet();
            this.cadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadTableAdapter = new CAS.casDataSetTableAdapters.cadTableAdapter();
            this.remarkMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.gccad = new KASLibrary.GridControlEx();
            this.ctrlSub = new CAS.Transaction.CtrlSub();
            this.cadetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadetTableAdapter = new CAS.casDataSetTableAdapters.cadetTableAdapter();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.txtTotalDebet = new DevExpress.XtraEditors.TextEdit();
            this.txtTotalKredit = new DevExpress.XtraEditors.TextEdit();
            this.txtSelisih = new DevExpress.XtraEditors.TextEdit();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludSeri.Properties)).BeginInit();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curkurs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curcur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadetBindingSource)).BeginInit();
            this.pnlTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalDebet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalKredit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSelisih.Properties)).BeginInit();
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
            this.pnlDetail.Controls.Add(this.pnlTotal);
            this.pnlDetail.Controls.Add(this.ctrlSub);
            this.pnlDetail.Controls.Add(this.gccad);
            this.pnlDetail.Controls.Add(this.remarkLabel);
            this.pnlDetail.Controls.Add(this.remarkMemoEdit);
            this.pnlDetail.Size = new System.Drawing.Size(743, 437);
            this.pnlDetail.Controls.SetChildIndex(this.dateDate, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curcur, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curkurs, 0);
            this.pnlDetail.Controls.SetChildIndex(this.kursLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curLabel1, 0);
            this.pnlDetail.Controls.SetChildIndex(this.remarkMemoEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(this.remarkLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.gccad, 0);
            this.pnlDetail.Controls.SetChildIndex(this.ctrlSub, 0);
            this.pnlDetail.Controls.SetChildIndex(this.pnlTotal, 0);
            // 
            // pnlKey
            // 
            this.pnlKey.Size = new System.Drawing.Size(743, 50);
            // 
            // dateDate
            // 
            this.dateDate.EditValue = new System.DateTime(((long)(0)));
            this.dateDate.Location = new System.Drawing.Point(436, 9);
            this.dateDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateDate.Properties.Mask.IgnoreMaskBlank = false;
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(384, 12);
            // 
            // curkurs
            // 
            this.curkurs.Location = new System.Drawing.Point(535, 35);
            // 
            // curcur
            // 
            this.curcur.Location = new System.Drawing.Point(436, 35);
            this.curcur.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.curcur.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.curcur.Properties.Appearance.Options.UseBackColor = true;
            this.curcur.Properties.Appearance.Options.UseForeColor = true;
            // 
            // curLabel1
            // 
            this.curLabel1.Location = new System.Drawing.Point(405, 38);
            // 
            // kursLabel
            // 
            this.kursLabel.Location = new System.Drawing.Point(499, 38);
            // 
            // btnDocFlow
            // 
            this.btnDocFlow.Visible = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(20, 50);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(36, 13);
            label4.TabIndex = 67;
            label4.Text = "Selisih";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(-2, 28);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(62, 13);
            label3.TabIndex = 66;
            label3.Text = "Total Kredit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(-2, 6);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(63, 13);
            label2.TabIndex = 65;
            label2.Text = "Total Debet";
            // 
            // remarkLabel
            // 
            this.remarkLabel.AutoSize = true;
            this.remarkLabel.Location = new System.Drawing.Point(386, 73);
            this.remarkLabel.Name = "remarkLabel";
            this.remarkLabel.Size = new System.Drawing.Size(44, 13);
            this.remarkLabel.TabIndex = 28;
            this.remarkLabel.Text = "remark:";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadBindingSource
            // 
            this.cadBindingSource.DataMember = "cad";
            this.cadBindingSource.DataSource = this.casDataSet;
            // 
            // cadTableAdapter
            // 
            this.cadTableAdapter.ClearBeforeFill = true;
            // 
            // remarkMemoEdit
            // 
            this.remarkMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cadBindingSource, "remark", true));
            this.remarkMemoEdit.Location = new System.Drawing.Point(436, 70);
            this.remarkMemoEdit.Name = "remarkMemoEdit";
            this.remarkMemoEdit.Size = new System.Drawing.Size(234, 66);
            this.remarkMemoEdit.TabIndex = 29;
            // 
            // gccad
            // 
            this.gccad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gccad.BestFitColumn = true;
            this.gccad.ExAutoSize = false;
            this.gccad.Location = new System.Drawing.Point(12, 151);
            this.gccad.Name = "gccad";
            this.gccad.Size = new System.Drawing.Size(658, 190);
            this.gccad.TabIndex = 31;
            // 
            // ctrlSub
            // 
            this.ctrlSub.Location = new System.Drawing.Point(12, 12);
            this.ctrlSub.Name = "ctrlSub";
            this.ctrlSub.ReadOnly = true;
            this.ctrlSub.Size = new System.Drawing.Size(335, 115);
            this.ctrlSub.TabIndex = 60;
            this.ctrlSub.Type = CAS.Transaction.CtrlSub.SubType.All;
            // 
            // cadetBindingSource
            // 
            this.cadetBindingSource.DataMember = "cadet";
            this.cadetBindingSource.DataSource = this.casDataSet;
            // 
            // cadetTableAdapter
            // 
            this.cadetTableAdapter.ClearBeforeFill = true;
            // 
            // pnlTotal
            // 
            this.pnlTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTotal.Controls.Add(this.txtTotalDebet);
            this.pnlTotal.Controls.Add(label4);
            this.pnlTotal.Controls.Add(this.txtTotalKredit);
            this.pnlTotal.Controls.Add(label3);
            this.pnlTotal.Controls.Add(this.txtSelisih);
            this.pnlTotal.Controls.Add(label2);
            this.pnlTotal.Location = new System.Drawing.Point(421, 347);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(249, 74);
            this.pnlTotal.TabIndex = 69;
            // 
            // txtTotalDebet
            // 
            this.txtTotalDebet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalDebet.Location = new System.Drawing.Point(70, 3);
            this.txtTotalDebet.Name = "txtTotalDebet";
            this.txtTotalDebet.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotalDebet.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotalDebet.Size = new System.Drawing.Size(174, 20);
            this.txtTotalDebet.TabIndex = 62;
            // 
            // txtTotalKredit
            // 
            this.txtTotalKredit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalKredit.Location = new System.Drawing.Point(70, 25);
            this.txtTotalKredit.Name = "txtTotalKredit";
            this.txtTotalKredit.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotalKredit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotalKredit.Size = new System.Drawing.Size(174, 20);
            this.txtTotalKredit.TabIndex = 63;
            // 
            // txtSelisih
            // 
            this.txtSelisih.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSelisih.Location = new System.Drawing.Point(70, 47);
            this.txtSelisih.Name = "txtSelisih";
            this.txtSelisih.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSelisih.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSelisih.Size = new System.Drawing.Size(174, 20);
            this.txtSelisih.TabIndex = 64;
            // 
            // FrmTCad
            // 
            this.ClientSize = new System.Drawing.Size(743, 567);
            this.DetailBindingSource = this.cadetBindingSource;
            this.DetailTable = this.casDataSet.cadet;
            this.MasterBindingSource = this.cadBindingSource;
            this.MasterTable = this.casDataSet.cad;
            this.Name = "FrmTCad";
            this.Load += new System.EventHandler(this.FrmTCad_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.cadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadetBindingSource)).EndInit();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalDebet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalKredit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSelisih.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource cadBindingSource;
        private CAS.casDataSetTableAdapters.cadTableAdapter cadTableAdapter;
        private DevExpress.XtraEditors.MemoEdit remarkMemoEdit;
        private KASLibrary.GridControlEx gccad;
        private CtrlSub ctrlSub;
        private System.Windows.Forms.Label remarkLabel;
        private System.Windows.Forms.BindingSource cadetBindingSource;
        private CAS.casDataSetTableAdapters.cadetTableAdapter cadetTableAdapter;
        private System.Windows.Forms.Panel pnlTotal;
        private DevExpress.XtraEditors.TextEdit txtTotalDebet;
        private DevExpress.XtraEditors.TextEdit txtTotalKredit;
        private DevExpress.XtraEditors.TextEdit txtSelisih;
    }
}
