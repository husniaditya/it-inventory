namespace CAS.Transaction
{
    partial class FrmTPrj
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
            System.Windows.Forms.Label aprovLabel;
            System.Windows.Forms.Label closeLabel;
            this.casDataSet = new CAS.casDataSet();
            this.rmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remarkMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.gcRma = new KASLibrary.GridControlEx();
            this.rmbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rmaTableAdapter = new CAS.casDataSetTableAdapters.rmaTableAdapter();
            this.aprovCheckBox = new System.Windows.Forms.CheckBox();
            this.closeCheckBox = new System.Windows.Forms.CheckBox();
            label2 = new System.Windows.Forms.Label();
            aprovLabel = new System.Windows.Forms.Label();
            closeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludSeri.Properties)).BeginInit();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curkurs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curcur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rmbBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(217, 19);
            this.txtNo.Size = new System.Drawing.Size(85, 26);
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(168, 19);
            this.txtPeriod.Size = new System.Drawing.Size(43, 26);
            // 
            // ludSeri
            // 
            this.ludSeri.Location = new System.Drawing.Point(91, 19);
            this.ludSeri.Size = new System.Drawing.Size(71, 26);
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(closeLabel);
            this.pnlDetail.Controls.Add(this.closeCheckBox);
            this.pnlDetail.Controls.Add(aprovLabel);
            this.pnlDetail.Controls.Add(this.aprovCheckBox);
            this.pnlDetail.Controls.Add(this.gcRma);
            this.pnlDetail.Controls.Add(this.remarkMemoEdit);
            this.pnlDetail.Controls.Add(label2);
            this.pnlDetail.Location = new System.Drawing.Point(0, 88);
            this.pnlDetail.Size = new System.Drawing.Size(816, 457);
            this.pnlDetail.Controls.SetChildIndex(label2, 0);
            this.pnlDetail.Controls.SetChildIndex(this.remarkMemoEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(this.gcRma, 0);
            this.pnlDetail.Controls.SetChildIndex(this.aprovCheckBox, 0);
            this.pnlDetail.Controls.SetChildIndex(aprovLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.closeCheckBox, 0);
            this.pnlDetail.Controls.SetChildIndex(closeLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateDate, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curcur, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curkurs, 0);
            this.pnlDetail.Controls.SetChildIndex(this.kursLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curLabel1, 0);
            // 
            // pnlKey
            // 
            this.pnlKey.Size = new System.Drawing.Size(816, 56);
            // 
            // dateDate
            // 
            this.dateDate.EditValue = new System.DateTime(((long)(0)));
            this.dateDate.Location = new System.Drawing.Point(446, 12);
            this.dateDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateDate.Properties.Mask.IgnoreMaskBlank = false;
            this.dateDate.Size = new System.Drawing.Size(100, 26);
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(394, 15);
            // 
            // curkurs
            // 
            this.curkurs.Location = new System.Drawing.Point(183, 140);
            this.curkurs.Visible = false;
            // 
            // curcur
            // 
            this.curcur.Location = new System.Drawing.Point(84, 140);
            this.curcur.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.curcur.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.curcur.Properties.Appearance.Options.UseBackColor = true;
            this.curcur.Properties.Appearance.Options.UseForeColor = true;
            this.curcur.Size = new System.Drawing.Size(57, 26);
            this.curcur.Visible = false;
            // 
            // curLabel1
            // 
            this.curLabel1.Location = new System.Drawing.Point(53, 143);
            this.curLabel1.Visible = false;
            // 
            // kursLabel
            // 
            this.kursLabel.Location = new System.Drawing.Point(147, 143);
            this.kursLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(37, 22);
            // 
            // btnDocFlow
            // 
            this.btnDocFlow.Visible = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(25, 15);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(88, 19);
            label2.TabIndex = 79;
            label2.Text = "Keterangan";
            // 
            // aprovLabel
            // 
            aprovLabel.AutoSize = true;
            aprovLabel.Location = new System.Drawing.Point(394, 46);
            aprovLabel.Name = "aprovLabel";
            aprovLabel.Size = new System.Drawing.Size(69, 19);
            aprovLabel.TabIndex = 84;
            aprovLabel.Text = "Approve";
            // 
            // closeLabel
            // 
            closeLabel.AutoSize = true;
            closeLabel.Location = new System.Drawing.Point(482, 46);
            closeLabel.Name = "closeLabel";
            closeLabel.Size = new System.Drawing.Size(47, 19);
            closeLabel.TabIndex = 85;
            closeLabel.Text = "Close";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rmaBindingSource
            // 
            this.rmaBindingSource.DataMember = "rma";
            this.rmaBindingSource.DataSource = this.casDataSet;
            this.rmaBindingSource.Filter = "group_=2";
            // 
            // remarkMemoEdit
            // 
            this.remarkMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rmaBindingSource, "remark", true));
            this.remarkMemoEdit.Location = new System.Drawing.Point(91, 15);
            this.remarkMemoEdit.Name = "remarkMemoEdit";
            this.remarkMemoEdit.Size = new System.Drawing.Size(256, 56);
            this.remarkMemoEdit.TabIndex = 82;
            // 
            // gcRma
            // 
            this.gcRma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcRma.BestFitColumn = true;
            this.gcRma.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gcRma.ExAutoSize = false;
            this.gcRma.Location = new System.Drawing.Point(12, 149);
            this.gcRma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gcRma.Name = "gcRma";
            this.gcRma.Size = new System.Drawing.Size(792, 305);
            this.gcRma.TabIndex = 83;
            // 
            // rmbBindingSource
            // 
            this.rmbBindingSource.DataMember = "rmb";
            this.rmbBindingSource.DataSource = this.casDataSet;
            // 
            // rmaTableAdapter
            // 
            this.rmaTableAdapter.ClearBeforeFill = true;
            // 
            // aprovCheckBox
            // 
            this.aprovCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.rmaBindingSource, "aprov", true));
            this.aprovCheckBox.Location = new System.Drawing.Point(446, 41);
            this.aprovCheckBox.Name = "aprovCheckBox";
            this.aprovCheckBox.Size = new System.Drawing.Size(30, 24);
            this.aprovCheckBox.TabIndex = 85;
            // 
            // closeCheckBox
            // 
            this.closeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.rmaBindingSource, "close", true));
            this.closeCheckBox.Location = new System.Drawing.Point(523, 41);
            this.closeCheckBox.Name = "closeCheckBox";
            this.closeCheckBox.Size = new System.Drawing.Size(39, 24);
            this.closeCheckBox.TabIndex = 86;
            // 
            // FrmTPrj
            // 
            this.ClientSize = new System.Drawing.Size(816, 608);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DetailBindingSource = this.rmbBindingSource;
            this.DetailTable = this.casDataSet.rmb;
            this.MasterBindingSource = this.rmaBindingSource;
            this.MasterTable = this.casDataSet.rma;
            this.Name = "FrmTPrj";
            this.Text = "PR Jasa";
            this.Load += new System.EventHandler(this.FrmTPrj_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.rmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rmbBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource rmaBindingSource;
        private KASLibrary.GridControlEx gcRma;
        private DevExpress.XtraEditors.MemoEdit remarkMemoEdit;
        private System.Windows.Forms.BindingSource rmbBindingSource;
        private System.Windows.Forms.CheckBox closeCheckBox;
        private System.Windows.Forms.CheckBox aprovCheckBox;
        private CAS.casDataSetTableAdapters.rmaTableAdapter rmaTableAdapter;
    }
}
