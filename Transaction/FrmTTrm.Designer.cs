namespace CAS.Transaction
{
    partial class FrmTTrm
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
            System.Windows.Forms.Label lockLabel;
            System.Windows.Forms.Label locdLabel;
            System.Windows.Forms.Label remarkLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label bsaLabel;
            this.casDataSet = new CAS.casDataSet();
            this.trmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trmTableAdapter = new CAS.casDataSetTableAdapters.trmTableAdapter();
            this.lockTextBoxEx = new KASLibrary.TextBoxEx();
            this.locdTextBoxEx = new KASLibrary.TextBoxEx();
            this.remarkTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.gctrm = new KASLibrary.GridControlEx();
            this.trdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trdTableAdapter = new CAS.casDataSetTableAdapters.trdTableAdapter();
            this.txtLhp = new KASLibrary.TextBoxEx();
            this.bsaTextBoxEx = new KASLibrary.TextBoxEx();
            lockLabel = new System.Windows.Forms.Label();
            locdLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            bsaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludSeri.Properties)).BeginInit();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curkurs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curcur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locdTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLhp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsaTextBoxEx.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNo
            // 
            this.txtNo.Size = new System.Drawing.Size(85, 26);
            // 
            // txtPeriod
            // 
            this.txtPeriod.Size = new System.Drawing.Size(43, 26);
            // 
            // ludSeri
            // 
            this.ludSeri.Size = new System.Drawing.Size(71, 26);
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(bsaLabel);
            this.pnlDetail.Controls.Add(this.bsaTextBoxEx);
            this.pnlDetail.Controls.Add(this.txtLhp);
            this.pnlDetail.Controls.Add(label2);
            this.pnlDetail.Controls.Add(this.gctrm);
            this.pnlDetail.Controls.Add(remarkLabel);
            this.pnlDetail.Controls.Add(this.remarkTextEdit);
            this.pnlDetail.Controls.Add(locdLabel);
            this.pnlDetail.Controls.Add(this.locdTextBoxEx);
            this.pnlDetail.Controls.Add(lockLabel);
            this.pnlDetail.Controls.Add(this.lockTextBoxEx);
            this.pnlDetail.Size = new System.Drawing.Size(659, 370);
            this.pnlDetail.Controls.SetChildIndex(this.dateDate, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curcur, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curkurs, 0);
            this.pnlDetail.Controls.SetChildIndex(this.kursLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curLabel1, 0);
            this.pnlDetail.Controls.SetChildIndex(this.lockTextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(lockLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.locdTextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(locdLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.remarkTextEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(remarkLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.gctrm, 0);
            this.pnlDetail.Controls.SetChildIndex(label2, 0);
            this.pnlDetail.Controls.SetChildIndex(this.txtLhp, 0);
            this.pnlDetail.Controls.SetChildIndex(this.bsaTextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(bsaLabel, 0);
            // 
            // pnlKey
            // 
            this.pnlKey.Size = new System.Drawing.Size(659, 50);
            // 
            // dateDate
            // 
            this.dateDate.EditValue = new System.DateTime(((long)(0)));
            this.dateDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.dateDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateDate.Properties.Mask.EditMask = "dd/MM/yyyy HH:mm:ss";
            this.dateDate.Properties.Mask.IgnoreMaskBlank = false;
            this.dateDate.Size = new System.Drawing.Size(163, 26);
            // 
            // curkurs
            // 
            this.curkurs.Visible = false;
            // 
            // curcur
            // 
            this.curcur.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.curcur.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.curcur.Properties.Appearance.Options.UseBackColor = true;
            this.curcur.Properties.Appearance.Options.UseForeColor = true;
            this.curcur.Size = new System.Drawing.Size(57, 26);
            this.curcur.Visible = false;
            // 
            // curLabel1
            // 
            this.curLabel1.Visible = false;
            // 
            // kursLabel
            // 
            this.kursLabel.Visible = false;
            // 
            // lockLabel
            // 
            lockLabel.AutoSize = true;
            lockLabel.Location = new System.Drawing.Point(49, 34);
            lockLabel.Name = "lockLabel";
            lockLabel.Size = new System.Drawing.Size(68, 19);
            lockLabel.TabIndex = 28;
            lockLabel.Text = "Loc Asal";
            // 
            // locdLabel
            // 
            locdLabel.AutoSize = true;
            locdLabel.Location = new System.Drawing.Point(37, 58);
            locdLabel.Name = "locdLabel";
            locdLabel.Size = new System.Drawing.Size(88, 19);
            locdLabel.TabIndex = 29;
            locdLabel.Text = "Loc Tujuan";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(35, 82);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(88, 19);
            remarkLabel.TabIndex = 30;
            remarkLabel.Text = "Keterangan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(21, 104);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(110, 19);
            label2.TabIndex = 34;
            label2.Text = "Copy dari LHP";
            // 
            // bsaLabel
            // 
            bsaLabel.AutoSize = true;
            bsaLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            bsaLabel.ForeColor = System.Drawing.Color.Red;
            bsaLabel.Location = new System.Drawing.Point(26, 9);
            bsaLabel.Name = "bsaLabel";
            bsaLabel.Size = new System.Drawing.Size(105, 21);
            bsaLabel.TabIndex = 139;
            bsaLabel.Text = "Bisnis Area";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trmBindingSource
            // 
            this.trmBindingSource.DataMember = "trm";
            this.trmBindingSource.DataSource = this.casDataSet;
            // 
            // trmTableAdapter
            // 
            this.trmTableAdapter.ClearBeforeFill = true;
            // 
            // lockTextBoxEx
            // 
            this.lockTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.trmBindingSource, "lock", true));
            this.lockTextBoxEx.ExAllowEmptyString = true;
            this.lockTextBoxEx.ExAllowNonDBData = false;
            this.lockTextBoxEx.ExAutoCheck = true;
            this.lockTextBoxEx.ExAutoShowResult = false;
            this.lockTextBoxEx.ExCondition = "";
            this.lockTextBoxEx.ExDialogTitle = "";
            this.lockTextBoxEx.ExFieldName = "Loc";
            this.lockTextBoxEx.ExFilterFields = new string[0];
            this.lockTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.lockTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.lockTextBoxEx.ExLabelContainer = null;
            this.lockTextBoxEx.ExLabelField = "Nama Lokasi";
            this.lockTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.lockTextBoxEx.ExLabelText = "";
            this.lockTextBoxEx.ExLabelVisible = true;
            this.lockTextBoxEx.ExSelectFields = new string[0];
            this.lockTextBoxEx.ExShowDialog = true;
            this.lockTextBoxEx.ExSimpleMode = true;
            this.lockTextBoxEx.ExSqlInstance = null;
            this.lockTextBoxEx.ExSqlQuery = "Call SP_LookUp(\'loc\')";
            this.lockTextBoxEx.ExTableName = "loc";
            this.lockTextBoxEx.Location = new System.Drawing.Point(103, 31);
            this.lockTextBoxEx.Name = "lockTextBoxEx";
            this.lockTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.lockTextBoxEx.Size = new System.Drawing.Size(100, 26);
            this.lockTextBoxEx.TabIndex = 29;
            // 
            // locdTextBoxEx
            // 
            this.locdTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.trmBindingSource, "locd", true));
            this.locdTextBoxEx.ExAllowEmptyString = true;
            this.locdTextBoxEx.ExAllowNonDBData = false;
            this.locdTextBoxEx.ExAutoCheck = true;
            this.locdTextBoxEx.ExAutoShowResult = false;
            this.locdTextBoxEx.ExCondition = "";
            this.locdTextBoxEx.ExDialogTitle = "";
            this.locdTextBoxEx.ExFieldName = "Loc";
            this.locdTextBoxEx.ExFilterFields = new string[0];
            this.locdTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.locdTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.locdTextBoxEx.ExLabelContainer = null;
            this.locdTextBoxEx.ExLabelField = "Nama Lokasi";
            this.locdTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.locdTextBoxEx.ExLabelText = "";
            this.locdTextBoxEx.ExLabelVisible = true;
            this.locdTextBoxEx.ExSelectFields = new string[0];
            this.locdTextBoxEx.ExShowDialog = true;
            this.locdTextBoxEx.ExSimpleMode = true;
            this.locdTextBoxEx.ExSqlInstance = null;
            this.locdTextBoxEx.ExSqlQuery = "Call SP_LookUp(\'loc\')";
            this.locdTextBoxEx.ExTableName = "loc";
            this.locdTextBoxEx.Location = new System.Drawing.Point(103, 55);
            this.locdTextBoxEx.Name = "locdTextBoxEx";
            this.locdTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.locdTextBoxEx.Size = new System.Drawing.Size(100, 26);
            this.locdTextBoxEx.TabIndex = 30;
            // 
            // remarkTextEdit
            // 
            this.remarkTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.trmBindingSource, "remark", true));
            this.remarkTextEdit.Location = new System.Drawing.Point(103, 79);
            this.remarkTextEdit.Name = "remarkTextEdit";
            this.remarkTextEdit.Size = new System.Drawing.Size(352, 26);
            this.remarkTextEdit.TabIndex = 31;
            // 
            // gctrm
            // 
            this.gctrm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gctrm.BestFitColumn = true;
            this.gctrm.ExAutoSize = false;
            this.gctrm.Location = new System.Drawing.Point(19, 129);
            this.gctrm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gctrm.Name = "gctrm";
            this.gctrm.Size = new System.Drawing.Size(619, 225);
            this.gctrm.TabIndex = 32;
            // 
            // trdBindingSource
            // 
            this.trdBindingSource.DataMember = "trd";
            this.trdBindingSource.DataSource = this.casDataSet;
            // 
            // trdTableAdapter
            // 
            this.trdTableAdapter.ClearBeforeFill = true;
            // 
            // txtLhp
            // 
            this.txtLhp.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.trmBindingSource, "lhp", true));
            this.txtLhp.ExAllowEmptyString = true;
            this.txtLhp.ExAllowNonDBData = false;
            this.txtLhp.ExAutoCheck = true;
            this.txtLhp.ExAutoShowResult = false;
            this.txtLhp.ExCondition = "";
            this.txtLhp.ExDialogTitle = "";
            this.txtLhp.ExFieldName = "LHP";
            this.txtLhp.ExFilterFields = new string[0];
            this.txtLhp.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtLhp.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtLhp.ExLabelContainer = null;
            this.txtLhp.ExLabelField = "";
            this.txtLhp.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.txtLhp.ExLabelText = "";
            this.txtLhp.ExLabelVisible = false;
            this.txtLhp.ExSelectFields = new string[0];
            this.txtLhp.ExShowDialog = true;
            this.txtLhp.ExSimpleMode = true;
            this.txtLhp.ExSqlInstance = null;
            this.txtLhp.ExSqlQuery = "";
            this.txtLhp.ExTableName = "lhp";
            this.txtLhp.Location = new System.Drawing.Point(103, 101);
            this.txtLhp.Name = "txtLhp";
            this.txtLhp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtLhp.Size = new System.Drawing.Size(121, 26);
            this.txtLhp.TabIndex = 35;
            this.txtLhp.EditValueChanged += new System.EventHandler(this.txtLhp_EditValueChanged);
            // 
            // bsaTextBoxEx
            // 
            this.bsaTextBoxEx.Enabled = false;
            this.bsaTextBoxEx.ExAllowEmptyString = true;
            this.bsaTextBoxEx.ExAllowNonDBData = false;
            this.bsaTextBoxEx.ExAutoCheck = true;
            this.bsaTextBoxEx.ExAutoShowResult = false;
            this.bsaTextBoxEx.ExCondition = "";
            this.bsaTextBoxEx.ExDialogTitle = "";
            this.bsaTextBoxEx.ExFieldName = "Kode Area";
            this.bsaTextBoxEx.ExFilterFields = new string[0];
            this.bsaTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.bsaTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.bsaTextBoxEx.ExLabelContainer = null;
            this.bsaTextBoxEx.ExLabelField = "Area";
            this.bsaTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.bsaTextBoxEx.ExLabelText = "";
            this.bsaTextBoxEx.ExLabelVisible = true;
            this.bsaTextBoxEx.ExSelectFields = new string[0];
            this.bsaTextBoxEx.ExShowDialog = true;
            this.bsaTextBoxEx.ExSimpleMode = true;
            this.bsaTextBoxEx.ExSqlInstance = null;
            this.bsaTextBoxEx.ExSqlQuery = "select bsa `Kode Area`, Area from bsa";
            this.bsaTextBoxEx.ExTableName = "bsa";
            this.bsaTextBoxEx.Location = new System.Drawing.Point(103, 6);
            this.bsaTextBoxEx.Name = "bsaTextBoxEx";
            this.bsaTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.bsaTextBoxEx.Size = new System.Drawing.Size(81, 26);
            this.bsaTextBoxEx.TabIndex = 140;
            // 
            // FrmTTrm
            // 
            this.ClientSize = new System.Drawing.Size(659, 515);
            this.DetailBindingSource = this.trdBindingSource;
            this.DetailTable = this.casDataSet.trd;
            this.MasterBindingSource = this.trmBindingSource;
            this.MasterTable = this.casDataSet.trm;
            this.Name = "FrmTTrm";
            this.Text = "Transfer/Pemindahan Barang";
            this.Load += new System.EventHandler(this.FrmTTrm_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.trmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locdTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLhp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsaTextBoxEx.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource trmBindingSource;
        private CAS.casDataSetTableAdapters.trmTableAdapter trmTableAdapter;
        private KASLibrary.TextBoxEx lockTextBoxEx;
        private KASLibrary.TextBoxEx locdTextBoxEx;
        private DevExpress.XtraEditors.TextEdit remarkTextEdit;
        private KASLibrary.GridControlEx gctrm;
        private System.Windows.Forms.BindingSource trdBindingSource;
        private CAS.casDataSetTableAdapters.trdTableAdapter trdTableAdapter;
        private KASLibrary.TextBoxEx txtLhp;
        private KASLibrary.TextBoxEx bsaTextBoxEx;
    }
}
