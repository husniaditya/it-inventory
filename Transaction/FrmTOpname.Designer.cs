namespace CAS.Transaction
{
    partial class FrmTOpname
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
            this.gcOpm = new KASLibrary.GridControlEx();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.remarkTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.opnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casDataSet = new CAS.casDataSet();
            this.textBoxExCct = new KASLibrary.TextBoxEx();
            this.textBoxExLoc = new KASLibrary.TextBoxEx();
            this.opdTableAdapter = new CAS.casDataSetTableAdapters.opdTableAdapter();
            this.opdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.opnTableAdapter = new CAS.casDataSetTableAdapters.opnTableAdapter();
            remarkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludSeri.Properties)).BeginInit();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curkurs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curcur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExCct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExLoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opdBindingSource)).BeginInit();
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
            this.pnlDetail.Controls.Add(this.label3);
            this.pnlDetail.Controls.Add(this.label2);
            this.pnlDetail.Controls.Add(this.textBoxExLoc);
            this.pnlDetail.Controls.Add(remarkLabel);
            this.pnlDetail.Controls.Add(this.textBoxExCct);
            this.pnlDetail.Controls.Add(this.remarkTextEdit);
            this.pnlDetail.Controls.Add(this.gcOpm);
            this.pnlDetail.Size = new System.Drawing.Size(605, 379);
            this.pnlDetail.Controls.SetChildIndex(this.gcOpm, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateDate, 0);
            this.pnlDetail.Controls.SetChildIndex(this.remarkTextEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curcur, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curkurs, 0);
            this.pnlDetail.Controls.SetChildIndex(this.kursLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curLabel1, 0);
            this.pnlDetail.Controls.SetChildIndex(this.textBoxExCct, 0);
            this.pnlDetail.Controls.SetChildIndex(remarkLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.textBoxExLoc, 0);
            this.pnlDetail.Controls.SetChildIndex(this.label2, 0);
            this.pnlDetail.Controls.SetChildIndex(this.label3, 0);
            // 
            // pnlKey
            // 
            this.pnlKey.Size = new System.Drawing.Size(605, 50);
            // 
            // dateDate
            // 
            this.dateDate.EditValue = new System.DateTime(((long)(0)));
            this.dateDate.Location = new System.Drawing.Point(493, 7);
            this.dateDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateDate.Properties.Mask.IgnoreMaskBlank = false;
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(441, 10);
            // 
            // curkurs
            // 
            this.curkurs.Location = new System.Drawing.Point(520, 33);
            this.curkurs.Visible = false;
            // 
            // curcur
            // 
            this.curcur.Location = new System.Drawing.Point(421, 33);
            this.curcur.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.curcur.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.curcur.Properties.Appearance.Options.UseBackColor = true;
            this.curcur.Properties.Appearance.Options.UseForeColor = true;
            this.curcur.Visible = false;
            // 
            // curLabel1
            // 
            this.curLabel1.Location = new System.Drawing.Point(390, 36);
            this.curLabel1.Visible = false;
            // 
            // kursLabel
            // 
            this.kursLabel.Location = new System.Drawing.Point(484, 36);
            this.kursLabel.Visible = false;
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(44, 62);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(70, 13);
            remarkLabel.TabIndex = 64;
            remarkLabel.Text = "Keterangan :";
            // 
            // gcOpm
            // 
            this.gcOpm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcOpm.BestFitColumn = true;
            this.gcOpm.ExAutoSize = false;
            this.gcOpm.Location = new System.Drawing.Point(12, 85);
            this.gcOpm.Name = "gcOpm";
            this.gcOpm.Size = new System.Drawing.Size(581, 265);
            this.gcOpm.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Cost Center :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Gudang :";
            // 
            // remarkTextEdit
            // 
            this.remarkTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.opnBindingSource, "remark", true));
            this.remarkTextEdit.Location = new System.Drawing.Point(118, 59);
            this.remarkTextEdit.Name = "remarkTextEdit";
            this.remarkTextEdit.Size = new System.Drawing.Size(258, 20);
            this.remarkTextEdit.TabIndex = 66;
            // 
            // opnBindingSource
            // 
            this.opnBindingSource.DataMember = "opn";
            this.opnBindingSource.DataSource = this.casDataSet;
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxExCct
            // 
            this.textBoxExCct.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.opnBindingSource, "cct", true));
            this.textBoxExCct.ExAllowEmptyString = true;
            this.textBoxExCct.ExAllowNonDBData = false;
            this.textBoxExCct.ExAutoCheck = true;
            this.textBoxExCct.ExAutoShowResult = false;
            this.textBoxExCct.ExCondition = "";
            this.textBoxExCct.ExDialogTitle = "";
            this.textBoxExCct.ExFieldName = "Cost Center";
            this.textBoxExCct.ExFilterFields = new string[0];
            this.textBoxExCct.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.textBoxExCct.ExInvalidForeColor = System.Drawing.Color.Black;
            this.textBoxExCct.ExLabelContainer = null;
            this.textBoxExCct.ExLabelField = "Nama";
            this.textBoxExCct.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.textBoxExCct.ExLabelText = "";
            this.textBoxExCct.ExLabelVisible = true;
            this.textBoxExCct.ExSelectFields = new string[0];
            this.textBoxExCct.ExShowDialog = true;
            this.textBoxExCct.ExSimpleMode = false;
            this.textBoxExCct.ExSqlInstance = null;
            this.textBoxExCct.ExSqlQuery = "Call SP_BrowseM(\'Master.FrmMasterCct\')";
            this.textBoxExCct.ExTableName = "";
            this.textBoxExCct.Location = new System.Drawing.Point(118, 33);
            this.textBoxExCct.Name = "textBoxExCct";
            this.textBoxExCct.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxExCct.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.textBoxExCct.Properties.Appearance.Options.UseBackColor = true;
            this.textBoxExCct.Properties.Appearance.Options.UseForeColor = true;
            this.textBoxExCct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.textBoxExCct.Size = new System.Drawing.Size(100, 20);
            this.textBoxExCct.TabIndex = 65;
            // 
            // textBoxExLoc
            // 
            this.textBoxExLoc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.opnBindingSource, "loc", true));
            this.textBoxExLoc.ExAllowEmptyString = true;
            this.textBoxExLoc.ExAllowNonDBData = false;
            this.textBoxExLoc.ExAutoCheck = true;
            this.textBoxExLoc.ExAutoShowResult = false;
            this.textBoxExLoc.ExCondition = "";
            this.textBoxExLoc.ExDialogTitle = "";
            this.textBoxExLoc.ExFieldName = "Kode Lokasi";
            this.textBoxExLoc.ExFilterFields = new string[0];
            this.textBoxExLoc.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.textBoxExLoc.ExInvalidForeColor = System.Drawing.Color.Black;
            this.textBoxExLoc.ExLabelContainer = null;
            this.textBoxExLoc.ExLabelField = "Nama Lokasi";
            this.textBoxExLoc.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.textBoxExLoc.ExLabelText = "";
            this.textBoxExLoc.ExLabelVisible = true;
            this.textBoxExLoc.ExSelectFields = new string[0];
            this.textBoxExLoc.ExShowDialog = true;
            this.textBoxExLoc.ExSimpleMode = false;
            this.textBoxExLoc.ExSqlInstance = null;
            this.textBoxExLoc.ExSqlQuery = "Call SP_BrowseM(\'Master.FrmMasterLoc\')";
            this.textBoxExLoc.ExTableName = "";
            this.textBoxExLoc.Location = new System.Drawing.Point(118, 7);
            this.textBoxExLoc.Name = "textBoxExLoc";
            this.textBoxExLoc.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxExLoc.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.textBoxExLoc.Properties.Appearance.Options.UseBackColor = true;
            this.textBoxExLoc.Properties.Appearance.Options.UseForeColor = true;
            this.textBoxExLoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.textBoxExLoc.Size = new System.Drawing.Size(100, 20);
            this.textBoxExLoc.TabIndex = 63;
            this.textBoxExLoc.EditValueChanged += new System.EventHandler(this.textBoxExLoc_EditValueChanged);
            // 
            // opdTableAdapter
            // 
            this.opdTableAdapter.ClearBeforeFill = true;
            // 
            // opdBindingSource
            // 
            this.opdBindingSource.DataMember = "opd";
            this.opdBindingSource.DataSource = this.casDataSet;
            // 
            // opnTableAdapter
            // 
            this.opnTableAdapter.ClearBeforeFill = true;
            // 
            // FrmTOpname
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 509);
            this.DetailBindingSource = this.opdBindingSource;
            this.DetailTable = this.casDataSet.opd;
            this.MasterBindingSource = this.opnBindingSource;
            this.MasterTable = this.casDataSet.opn;
            this.Name = "FrmTOpname";
            this.Text = "Stok Opname";
            this.Load += new System.EventHandler(this.FrmTOpname_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.opnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExCct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExLoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opdBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KASLibrary.GridControlEx gcOpm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private KASLibrary.TextBoxEx textBoxExLoc;
        private KASLibrary.TextBoxEx textBoxExCct;
        private DevExpress.XtraEditors.TextEdit remarkTextEdit;
        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource opnBindingSource;
        private CAS.casDataSetTableAdapters.opdTableAdapter opdTableAdapter;
        private System.Windows.Forms.BindingSource opdBindingSource;
        private CAS.casDataSetTableAdapters.opnTableAdapter opnTableAdapter;
    }
}