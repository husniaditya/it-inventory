namespace CAS.Transaction
{
    partial class FrmTLhp
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
            System.Windows.Forms.Label locLabel;
            System.Windows.Forms.Label remarkLabel;
            System.Windows.Forms.Label msnLabel;
            System.Windows.Forms.Label cctLabel;
            System.Windows.Forms.Label plantLabel;
            this.remarkTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.lhpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casDataSet = new CAS.casDataSet();
            this.gclhp = new KASLibrary.GridControlEx();
            this.locTextBoxEx = new KASLibrary.TextBoxEx();
            this.lhpTableAdapter = new CAS.casDataSetTableAdapters.lhpTableAdapter();
            this.lhdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lhcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lhdTableAdapter = new CAS.casDataSetTableAdapters.lhdTableAdapter();
            this.msnTextBoxEx = new KASLibrary.TextBoxEx();
            this.cctTextBoxEx = new KASLibrary.TextBoxEx();
            this.gcbppb = new KASLibrary.GridControlEx();
            this.plantComboBox = new System.Windows.Forms.ComboBox();
            locLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            msnLabel = new System.Windows.Forms.Label();
            cctLabel = new System.Windows.Forms.Label();
            plantLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludSeri.Properties)).BeginInit();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curkurs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curcur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lhpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lhdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lhcBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msnTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cctTextBoxEx.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(210, 20);
            this.txtNo.Size = new System.Drawing.Size(85, 26);
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(161, 20);
            this.txtPeriod.Size = new System.Drawing.Size(43, 26);
            // 
            // ludSeri
            // 
            this.ludSeri.Location = new System.Drawing.Point(84, 19);
            this.ludSeri.Size = new System.Drawing.Size(71, 26);
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(plantLabel);
            this.pnlDetail.Controls.Add(this.plantComboBox);
            this.pnlDetail.Controls.Add(this.gcbppb);
            this.pnlDetail.Controls.Add(cctLabel);
            this.pnlDetail.Controls.Add(this.cctTextBoxEx);
            this.pnlDetail.Controls.Add(this.msnTextBoxEx);
            this.pnlDetail.Controls.Add(msnLabel);
            this.pnlDetail.Controls.Add(this.locTextBoxEx);
            this.pnlDetail.Controls.Add(this.gclhp);
            this.pnlDetail.Controls.Add(remarkLabel);
            this.pnlDetail.Controls.Add(this.remarkTextEdit);
            this.pnlDetail.Controls.Add(locLabel);
            this.pnlDetail.Size = new System.Drawing.Size(797, 422);
            this.pnlDetail.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDetail_Paint);
            this.pnlDetail.Controls.SetChildIndex(this.dateDate, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curcur, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curkurs, 0);
            this.pnlDetail.Controls.SetChildIndex(this.kursLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curLabel1, 0);
            this.pnlDetail.Controls.SetChildIndex(locLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.remarkTextEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(remarkLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.gclhp, 0);
            this.pnlDetail.Controls.SetChildIndex(this.locTextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(msnLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.msnTextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(this.cctTextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(cctLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.gcbppb, 0);
            this.pnlDetail.Controls.SetChildIndex(this.plantComboBox, 0);
            this.pnlDetail.Controls.SetChildIndex(plantLabel, 0);
            // 
            // pnlKey
            // 
            this.pnlKey.Size = new System.Drawing.Size(797, 50);
            // 
            // dateDate
            // 
            this.dateDate.EditValue = new System.DateTime(((long)(0)));
            this.dateDate.Location = new System.Drawing.Point(575, 25);
            this.dateDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateDate.Properties.Mask.IgnoreMaskBlank = false;
            this.dateDate.Size = new System.Drawing.Size(100, 26);
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(523, 28);
            // 
            // curkurs
            // 
            this.curkurs.Location = new System.Drawing.Point(674, 3);
            this.curkurs.Visible = false;
            // 
            // curcur
            // 
            this.curcur.Location = new System.Drawing.Point(575, 3);
            this.curcur.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.curcur.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.curcur.Properties.Appearance.Options.UseBackColor = true;
            this.curcur.Properties.Appearance.Options.UseForeColor = true;
            this.curcur.Size = new System.Drawing.Size(57, 26);
            this.curcur.Visible = false;
            // 
            // curLabel1
            // 
            this.curLabel1.Location = new System.Drawing.Point(544, 6);
            this.curLabel1.Visible = false;
            // 
            // kursLabel
            // 
            this.kursLabel.Location = new System.Drawing.Point(638, 6);
            this.kursLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(35, 24);
            // 
            // btnDocFlow
            // 
            this.btnDocFlow.Visible = true;
            // 
            // locLabel
            // 
            locLabel.AutoSize = true;
            locLabel.Location = new System.Drawing.Point(42, 38);
            locLabel.Name = "locLabel";
            locLabel.Size = new System.Drawing.Size(64, 19);
            locLabel.TabIndex = 28;
            locLabel.Text = "Gudang";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(23, 59);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(88, 19);
            remarkLabel.TabIndex = 29;
            remarkLabel.Text = "Keterangan";
            // 
            // msnLabel
            // 
            msnLabel.AutoSize = true;
            msnLabel.Location = new System.Drawing.Point(9, 81);
            msnLabel.Name = "msnLabel";
            msnLabel.Size = new System.Drawing.Size(115, 19);
            msnLabel.TabIndex = 32;
            msnLabel.Text = "Mesin Produksi";
            // 
            // cctLabel
            // 
            cctLabel.AutoSize = true;
            cctLabel.Location = new System.Drawing.Point(21, 104);
            cctLabel.Name = "cctLabel";
            cctLabel.Size = new System.Drawing.Size(91, 19);
            cctLabel.TabIndex = 33;
            cctLabel.Text = "Cost Center";
            // 
            // plantLabel
            // 
            plantLabel.AutoSize = true;
            plantLabel.Location = new System.Drawing.Point(51, 13);
            plantLabel.Name = "plantLabel";
            plantLabel.Size = new System.Drawing.Size(44, 19);
            plantLabel.TabIndex = 35;
            plantLabel.Text = "Plant";
            // 
            // remarkTextEdit
            // 
            this.remarkTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lhpBindingSource, "remark", true));
            this.remarkTextEdit.Location = new System.Drawing.Point(97, 56);
            this.remarkTextEdit.Name = "remarkTextEdit";
            this.remarkTextEdit.Size = new System.Drawing.Size(379, 26);
            this.remarkTextEdit.TabIndex = 30;
            // 
            // lhpBindingSource
            // 
            this.lhpBindingSource.DataMember = "lhp";
            this.lhpBindingSource.DataSource = this.casDataSet;
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gclhp
            // 
            this.gclhp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gclhp.AutoScroll = true;
            this.gclhp.BestFitColumn = true;
            this.gclhp.ExAutoSize = false;
            this.gclhp.Location = new System.Drawing.Point(11, 325);
            this.gclhp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gclhp.Name = "gclhp";
            this.gclhp.Size = new System.Drawing.Size(773, 89);
            this.gclhp.TabIndex = 31;
            // 
            // locTextBoxEx
            // 
            this.locTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lhpBindingSource, "loc", true));
            this.locTextBoxEx.ExAllowEmptyString = true;
            this.locTextBoxEx.ExAllowNonDBData = false;
            this.locTextBoxEx.ExAutoCheck = true;
            this.locTextBoxEx.ExAutoShowResult = false;
            this.locTextBoxEx.ExCondition = "";
            this.locTextBoxEx.ExDialogTitle = "";
            this.locTextBoxEx.ExFieldName = "Loc";
            this.locTextBoxEx.ExFilterFields = new string[0];
            this.locTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.locTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.locTextBoxEx.ExLabelContainer = null;
            this.locTextBoxEx.ExLabelField = "Nama Lokasi";
            this.locTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.locTextBoxEx.ExLabelText = "";
            this.locTextBoxEx.ExLabelVisible = true;
            this.locTextBoxEx.ExSelectFields = new string[0];
            this.locTextBoxEx.ExShowDialog = true;
            this.locTextBoxEx.ExSimpleMode = true;
            this.locTextBoxEx.ExSqlInstance = null;
            this.locTextBoxEx.ExSqlQuery = "Call SP_LookUp(\'loc\')";
            this.locTextBoxEx.ExTableName = "loc";
            this.locTextBoxEx.Location = new System.Drawing.Point(97, 34);
            this.locTextBoxEx.Name = "locTextBoxEx";
            this.locTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.locTextBoxEx.Size = new System.Drawing.Size(94, 26);
            this.locTextBoxEx.TabIndex = 32;
            // 
            // lhpTableAdapter
            // 
            this.lhpTableAdapter.ClearBeforeFill = true;
            // 
            // lhdBindingSource
            // 
            this.lhdBindingSource.DataMember = "lhd";
            this.lhdBindingSource.DataSource = this.casDataSet;
            // 
            // lhcBindingSource
            // 
            this.lhcBindingSource.DataMember = "lhc";
            this.lhcBindingSource.DataSource = this.casDataSet;
            // 
            // lhdTableAdapter
            // 
            this.lhdTableAdapter.ClearBeforeFill = true;
            // 
            // msnTextBoxEx
            // 
            this.msnTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lhpBindingSource, "msn", true));
            this.msnTextBoxEx.ExAllowEmptyString = true;
            this.msnTextBoxEx.ExAllowNonDBData = false;
            this.msnTextBoxEx.ExAutoCheck = true;
            this.msnTextBoxEx.ExAutoShowResult = false;
            this.msnTextBoxEx.ExCondition = "";
            this.msnTextBoxEx.ExDialogTitle = "";
            this.msnTextBoxEx.ExFieldName = "msn";
            this.msnTextBoxEx.ExFilterFields = new string[0];
            this.msnTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.msnTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.msnTextBoxEx.ExLabelContainer = null;
            this.msnTextBoxEx.ExLabelField = "name";
            this.msnTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.msnTextBoxEx.ExLabelText = "";
            this.msnTextBoxEx.ExLabelVisible = true;
            this.msnTextBoxEx.ExSelectFields = new string[0];
            this.msnTextBoxEx.ExShowDialog = true;
            this.msnTextBoxEx.ExSimpleMode = true;
            this.msnTextBoxEx.ExSqlInstance = null;
            this.msnTextBoxEx.ExSqlQuery = "select * from msn where aktif=1";
            this.msnTextBoxEx.ExTableName = "msn";
            this.msnTextBoxEx.Location = new System.Drawing.Point(97, 78);
            this.msnTextBoxEx.Name = "msnTextBoxEx";
            this.msnTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.msnTextBoxEx.Size = new System.Drawing.Size(100, 26);
            this.msnTextBoxEx.TabIndex = 33;
            // 
            // cctTextBoxEx
            // 
            this.cctTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lhpBindingSource, "cct", true));
            this.cctTextBoxEx.ExAllowEmptyString = true;
            this.cctTextBoxEx.ExAllowNonDBData = false;
            this.cctTextBoxEx.ExAutoCheck = true;
            this.cctTextBoxEx.ExAutoShowResult = false;
            this.cctTextBoxEx.ExCondition = "";
            this.cctTextBoxEx.ExDialogTitle = "";
            this.cctTextBoxEx.ExFieldName = "Cost Center";
            this.cctTextBoxEx.ExFilterFields = new string[0];
            this.cctTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.cctTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.cctTextBoxEx.ExLabelContainer = null;
            this.cctTextBoxEx.ExLabelField = "nama";
            this.cctTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.cctTextBoxEx.ExLabelText = "";
            this.cctTextBoxEx.ExLabelVisible = true;
            this.cctTextBoxEx.ExSelectFields = new string[0];
            this.cctTextBoxEx.ExShowDialog = true;
            this.cctTextBoxEx.ExSimpleMode = true;
            this.cctTextBoxEx.ExSqlInstance = null;
            this.cctTextBoxEx.ExSqlQuery = "Call SP_LookUp(\'cct\')";
            this.cctTextBoxEx.ExTableName = "";
            this.cctTextBoxEx.Location = new System.Drawing.Point(97, 100);
            this.cctTextBoxEx.Name = "cctTextBoxEx";
            this.cctTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.cctTextBoxEx.Size = new System.Drawing.Size(100, 26);
            this.cctTextBoxEx.TabIndex = 34;
            // 
            // gcbppb
            // 
            this.gcbppb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcbppb.AutoScroll = true;
            this.gcbppb.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gcbppb.BestFitColumn = true;
            this.gcbppb.ExAutoSize = true;
            this.gcbppb.Location = new System.Drawing.Point(13, 127);
            this.gcbppb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gcbppb.Name = "gcbppb";
            this.gcbppb.Size = new System.Drawing.Size(771, 98);
            this.gcbppb.TabIndex = 35;
            // 
            // plantComboBox
            // 
            this.plantComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lhpBindingSource, "plant", true));
            this.plantComboBox.FormattingEnabled = true;
            this.plantComboBox.Location = new System.Drawing.Point(97, 6);
            this.plantComboBox.Name = "plantComboBox";
            this.plantComboBox.Size = new System.Drawing.Size(121, 28);
            this.plantComboBox.TabIndex = 36;
            // 
            // FrmTLhp
            // 
            this.ClientSize = new System.Drawing.Size(797, 567);
            this.DetailBindingSource = this.lhcBindingSource;
            this.DetailTable = this.casDataSet.lhd;
            this.MasterBindingSource = this.lhpBindingSource;
            this.MasterTable = this.casDataSet.lhp;
            this.Name = "FrmTLhp";
            this.Text = "Laporan Hasil Produksi";
            this.Load += new System.EventHandler(this.FrmTLhp_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.remarkTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lhpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lhdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lhcBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msnTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cctTextBoxEx.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource lhpBindingSource;
        private CAS.casDataSetTableAdapters.lhpTableAdapter lhpTableAdapter;
        private KASLibrary.GridControlEx gclhp;
        private DevExpress.XtraEditors.TextEdit remarkTextEdit;
        private KASLibrary.TextBoxEx locTextBoxEx;
        private System.Windows.Forms.BindingSource lhdBindingSource;
        private System.Windows.Forms.BindingSource lhcBindingSource;
        private CAS.casDataSetTableAdapters.lhdTableAdapter lhdTableAdapter;
        private KASLibrary.TextBoxEx msnTextBoxEx;
        private KASLibrary.TextBoxEx cctTextBoxEx;
        private KASLibrary.GridControlEx gcbppb;
        private System.Windows.Forms.ComboBox plantComboBox;
    }
}
