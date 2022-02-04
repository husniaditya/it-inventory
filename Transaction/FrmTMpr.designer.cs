namespace CAS.Transaction
{
    partial class FrmTMpr
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
            System.Windows.Forms.Label withPOLabel;
            System.Windows.Forms.Label aprovLabel;
            System.Windows.Forms.Label closeLabel;
            this.casDataSet = new CAS.casDataSet();
            this.gcPrq = new KASLibrary.GridControlEx();
            this.memoRemark = new DevExpress.XtraEditors.MemoEdit();
            this.mprBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.withPOCheckBox = new System.Windows.Forms.CheckBox();
            this.aprovCheckBox = new System.Windows.Forms.CheckBox();
            this.closeCheckBox = new System.Windows.Forms.CheckBox();
            this.personTextBoxEx = new KASLibrary.TextBoxEx();
            this.mprTableAdapter = new CAS.casDataSetTableAdapters.mprTableAdapter();
            this.mpdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mpdTableAdapter = new CAS.casDataSetTableAdapters.mpdTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            withPOLabel = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.memoRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mprBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(202, 20);
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(153, 20);
            // 
            // ludSeri
            // 
            this.ludSeri.Location = new System.Drawing.Point(76, 19);
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.label2);
            this.pnlDetail.Controls.Add(this.personTextBoxEx);
            this.pnlDetail.Controls.Add(closeLabel);
            this.pnlDetail.Controls.Add(this.closeCheckBox);
            this.pnlDetail.Controls.Add(aprovLabel);
            this.pnlDetail.Controls.Add(this.aprovCheckBox);
            this.pnlDetail.Controls.Add(this.memoRemark);
            this.pnlDetail.Controls.Add(remarkLabel);
            this.pnlDetail.Controls.Add(withPOLabel);
            this.pnlDetail.Controls.Add(this.withPOCheckBox);
            this.pnlDetail.Controls.Add(this.gcPrq);
            this.pnlDetail.Location = new System.Drawing.Point(0, 86);
            this.pnlDetail.Size = new System.Drawing.Size(746, 447);
            this.pnlDetail.Controls.SetChildIndex(this.kursLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curLabel1, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curcur, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curkurs, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateDate, 0);
            this.pnlDetail.Controls.SetChildIndex(this.gcPrq, 0);
            this.pnlDetail.Controls.SetChildIndex(this.withPOCheckBox, 0);
            this.pnlDetail.Controls.SetChildIndex(withPOLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(remarkLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.memoRemark, 0);
            this.pnlDetail.Controls.SetChildIndex(this.aprovCheckBox, 0);
            this.pnlDetail.Controls.SetChildIndex(aprovLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.closeCheckBox, 0);
            this.pnlDetail.Controls.SetChildIndex(closeLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.personTextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(this.label2, 0);
            // 
            // pnlKey
            // 
            this.pnlKey.Size = new System.Drawing.Size(746, 61);
            // 
            // dateDate
            // 
            this.dateDate.EditValue = null;
            this.dateDate.Location = new System.Drawing.Point(76, 6);
            this.dateDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateDate.Properties.Mask.IgnoreMaskBlank = false;
            this.dateDate.Size = new System.Drawing.Size(93, 23);
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(24, 9);
            // 
            // curkurs
            // 
            this.curkurs.Location = new System.Drawing.Point(532, 67);
            this.curkurs.Visible = false;
            // 
            // curcur
            // 
            this.curcur.Location = new System.Drawing.Point(437, 65);
            this.curcur.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.curcur.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.curcur.Properties.Appearance.Options.UseBackColor = true;
            this.curcur.Properties.Appearance.Options.UseForeColor = true;
            this.curcur.Visible = false;
            // 
            // curLabel1
            // 
            this.curLabel1.Location = new System.Drawing.Point(406, 70);
            this.curLabel1.Visible = false;
            // 
            // kursLabel
            // 
            this.kursLabel.Location = new System.Drawing.Point(500, 70);
            this.kursLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 23);
            // 
            // btnDocFlow
            // 
            this.btnDocFlow.Location = new System.Drawing.Point(566, 16);
            this.btnDocFlow.Visible = true;
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(21, 41);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(63, 13);
            remarkLabel.TabIndex = 38;
            remarkLabel.Text = "Keterangan";
            // 
            // withPOLabel
            // 
            withPOLabel.AutoSize = true;
            withPOLabel.Location = new System.Drawing.Point(22, 43);
            withPOLabel.Name = "withPOLabel";
            withPOLabel.Size = new System.Drawing.Size(46, 13);
            withPOLabel.TabIndex = 40;
            withPOLabel.Text = "With PO";
            withPOLabel.Visible = false;
            // 
            // aprovLabel
            // 
            aprovLabel.AutoSize = true;
            aprovLabel.Location = new System.Drawing.Point(210, 10);
            aprovLabel.Name = "aprovLabel";
            aprovLabel.Size = new System.Drawing.Size(48, 13);
            aprovLabel.TabIndex = 41;
            aprovLabel.Text = "Approve";
            // 
            // closeLabel
            // 
            closeLabel.AutoSize = true;
            closeLabel.Location = new System.Drawing.Point(194, 43);
            closeLabel.Name = "closeLabel";
            closeLabel.Size = new System.Drawing.Size(33, 13);
            closeLabel.TabIndex = 42;
            closeLabel.Text = "Close";
            closeLabel.Visible = false;
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gcPrq
            // 
            this.gcPrq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcPrq.BestFitColumn = true;
            this.gcPrq.ExAutoSize = false;
            this.gcPrq.Location = new System.Drawing.Point(12, 96);
            this.gcPrq.Name = "gcPrq";
            this.gcPrq.Size = new System.Drawing.Size(722, 331);
            this.gcPrq.TabIndex = 30;
            // 
            // memoRemark
            // 
            this.memoRemark.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mprBindingSource, "remark", true));
            this.memoRemark.Location = new System.Drawing.Point(96, 41);
            this.memoRemark.Name = "memoRemark";
            this.memoRemark.Size = new System.Drawing.Size(283, 53);
            this.memoRemark.TabIndex = 39;
            // 
            // mprBindingSource
            // 
            this.mprBindingSource.DataMember = "mpr";
            this.mprBindingSource.DataSource = this.casDataSet;
            // 
            // withPOCheckBox
            // 
            this.withPOCheckBox.Location = new System.Drawing.Point(76, 41);
            this.withPOCheckBox.Name = "withPOCheckBox";
            this.withPOCheckBox.Size = new System.Drawing.Size(24, 18);
            this.withPOCheckBox.TabIndex = 41;
            this.withPOCheckBox.Visible = false;
            // 
            // aprovCheckBox
            // 
            this.aprovCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.mprBindingSource, "aprov", true));
            this.aprovCheckBox.Location = new System.Drawing.Point(266, 8);
            this.aprovCheckBox.Name = "aprovCheckBox";
            this.aprovCheckBox.Size = new System.Drawing.Size(38, 18);
            this.aprovCheckBox.TabIndex = 42;
            this.aprovCheckBox.CheckedChanged += new System.EventHandler(this.aprovCheckBox_CheckedChanged);
            // 
            // closeCheckBox
            // 
            this.closeCheckBox.Location = new System.Drawing.Point(233, 41);
            this.closeCheckBox.Name = "closeCheckBox";
            this.closeCheckBox.Size = new System.Drawing.Size(25, 18);
            this.closeCheckBox.TabIndex = 43;
            this.closeCheckBox.Visible = false;
            // 
            // personTextBoxEx
            // 
            this.personTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mprBindingSource, "usrpr", true));
            this.personTextBoxEx.ExAllowEmptyString = true;
            this.personTextBoxEx.ExAllowNonDBData = false;
            this.personTextBoxEx.ExAutoCheck = true;
            this.personTextBoxEx.ExAutoShowResult = false;
            this.personTextBoxEx.ExCondition = "";
            this.personTextBoxEx.ExDialogTitle = "";
            this.personTextBoxEx.ExFieldName = "usrpr";
            this.personTextBoxEx.ExFilterFields = new string[0];
            this.personTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.personTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.personTextBoxEx.ExLabelContainer = null;
            this.personTextBoxEx.ExLabelField = "name";
            this.personTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.personTextBoxEx.ExLabelText = "";
            this.personTextBoxEx.ExLabelVisible = true;
            this.personTextBoxEx.ExSelectFields = new string[0];
            this.personTextBoxEx.ExShowDialog = true;
            this.personTextBoxEx.ExSimpleMode = true;
            this.personTextBoxEx.ExSqlInstance = null;
            this.personTextBoxEx.ExSqlQuery = "select * from usrpr where aktif=1";
            this.personTextBoxEx.ExTableName = "usrpr";
            this.personTextBoxEx.Location = new System.Drawing.Point(532, 36);
            this.personTextBoxEx.Name = "personTextBoxEx";
            this.personTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.personTextBoxEx.Size = new System.Drawing.Size(99, 20);
            this.personTextBoxEx.TabIndex = 123;
            this.personTextBoxEx.EditValueChanged += new System.EventHandler(this.personTextBoxEx_EditValueChanged);
            // 
            // mprTableAdapter
            // 
            this.mprTableAdapter.ClearBeforeFill = true;
            // 
            // mpdBindingSource
            // 
            this.mpdBindingSource.DataMember = "mpd";
            this.mpdBindingSource.DataSource = this.casDataSet;
            // 
            // mpdTableAdapter
            // 
            this.mpdTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 125;
            this.label2.Text = "Nama Requisitioner";
            // 
            // FrmTMpr
            // 
            this.ClientSize = new System.Drawing.Size(746, 588);
            this.DetailBindingSource = this.mpdBindingSource;
            this.DetailTable = this.casDataSet.mpd;
            this.MasterBindingSource = this.mprBindingSource;
            this.MasterTable = this.casDataSet.mpr;
            this.Name = "FrmTMpr";
            this.Text = "Purchase Memo Request";
            this.Load += new System.EventHandler(this.FrmTPrq_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.memoRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mprBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpdBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private KASLibrary.GridControlEx gcPrq;
        private DevExpress.XtraEditors.MemoEdit memoRemark;
        private System.Windows.Forms.CheckBox withPOCheckBox;
        private System.Windows.Forms.CheckBox closeCheckBox;
        private System.Windows.Forms.CheckBox aprovCheckBox;
        private KASLibrary.TextBoxEx personTextBoxEx;
        private System.Windows.Forms.BindingSource mprBindingSource;
        private CAS.casDataSetTableAdapters.mprTableAdapter mprTableAdapter;
        private System.Windows.Forms.BindingSource mpdBindingSource;
        private CAS.casDataSetTableAdapters.mpdTableAdapter mpdTableAdapter;
        private System.Windows.Forms.Label label2;
    }
}
