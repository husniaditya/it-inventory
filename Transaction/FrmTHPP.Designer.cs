namespace CAS.Transaction
{
    partial class FrmTHPP
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
            System.Windows.Forms.Label label4;
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxExLoc = new KASLibrary.TextBoxEx();
            this.remarkTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEx1 = new KASLibrary.TextBoxEx();
            this.hproBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casDataSet = new CAS.casDataSet();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.gcHPP = new KASLibrary.GridControlEx();
            this.hprodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCct = new KASLibrary.TextBoxEx();
            remarkLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludSeri.Properties)).BeginInit();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curkurs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curcur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExLoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxEx1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hproBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hprodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCct.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(224, 19);
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(175, 19);
            // 
            // ludSeri
            // 
            this.ludSeri.Location = new System.Drawing.Point(98, 19);
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.label6);
            this.pnlDetail.Controls.Add(this.txtCct);
            this.pnlDetail.Controls.Add(this.dateEdit1);
            this.pnlDetail.Controls.Add(this.gcHPP);
            this.pnlDetail.Controls.Add(this.label3);
            this.pnlDetail.Controls.Add(this.textBoxEx1);
            this.pnlDetail.Controls.Add(label4);
            this.pnlDetail.Controls.Add(this.textEdit1);
            this.pnlDetail.Controls.Add(this.label2);
            this.pnlDetail.Controls.Add(this.label5);
            this.pnlDetail.Controls.Add(this.textBoxExLoc);
            this.pnlDetail.Controls.Add(remarkLabel);
            this.pnlDetail.Controls.Add(this.remarkTextEdit);
            this.pnlDetail.Location = new System.Drawing.Point(0, 77);
            this.pnlDetail.Size = new System.Drawing.Size(731, 361);
            this.pnlDetail.Controls.SetChildIndex(this.remarkTextEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(remarkLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.textBoxExLoc, 0);
            this.pnlDetail.Controls.SetChildIndex(this.label5, 0);
            this.pnlDetail.Controls.SetChildIndex(this.label2, 0);
            this.pnlDetail.Controls.SetChildIndex(this.textEdit1, 0);
            this.pnlDetail.Controls.SetChildIndex(label4, 0);
            this.pnlDetail.Controls.SetChildIndex(this.textBoxEx1, 0);
            this.pnlDetail.Controls.SetChildIndex(this.label3, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateDate, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.gcHPP, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curLabel1, 0);
            this.pnlDetail.Controls.SetChildIndex(this.kursLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curcur, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curkurs, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateEdit1, 0);
            this.pnlDetail.Controls.SetChildIndex(this.txtCct, 0);
            this.pnlDetail.Controls.SetChildIndex(this.label6, 0);
            // 
            // pnlKey
            // 
            this.pnlKey.Size = new System.Drawing.Size(731, 52);
            // 
            // dateDate
            // 
            this.dateDate.EditValue = null;
            this.dateDate.Location = new System.Drawing.Point(470, 7);
            this.dateDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateDate.Properties.Mask.IgnoreMaskBlank = false;
            this.dateDate.EditValueChanged += new System.EventHandler(this.dateDate_EditValueChanged);
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(387, 10);
            this.dateLabel.Size = new System.Drawing.Size(71, 13);
            this.dateLabel.Text = "Tanggal Awal";
            // 
            // curkurs
            // 
            this.curkurs.Location = new System.Drawing.Point(628, 10);
            this.curkurs.Visible = false;
            // 
            // curcur
            // 
            this.curcur.Location = new System.Drawing.Point(628, 32);
            this.curcur.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.curcur.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.curcur.Properties.Appearance.Options.UseBackColor = true;
            this.curcur.Properties.Appearance.Options.UseForeColor = true;
            this.curcur.Visible = false;
            // 
            // curLabel1
            // 
            this.curLabel1.Location = new System.Drawing.Point(599, 35);
            this.curLabel1.Visible = false;
            // 
            // kursLabel
            // 
            this.kursLabel.Location = new System.Drawing.Point(592, 13);
            this.kursLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(50, 22);
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(66, -63);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(70, 13);
            remarkLabel.TabIndex = 71;
            remarkLabel.Text = "Keterangan :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(25, 35);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(63, 13);
            label4.TabIndex = 75;
            label4.Text = "Keterangan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, -115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Gudang :";
            // 
            // textBoxExLoc
            // 
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
            this.textBoxExLoc.Location = new System.Drawing.Point(140, -118);
            this.textBoxExLoc.Name = "textBoxExLoc";
            this.textBoxExLoc.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxExLoc.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.textBoxExLoc.Properties.Appearance.Options.UseBackColor = true;
            this.textBoxExLoc.Properties.Appearance.Options.UseForeColor = true;
            this.textBoxExLoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.textBoxExLoc.Size = new System.Drawing.Size(100, 20);
            this.textBoxExLoc.TabIndex = 70;
            // 
            // remarkTextEdit
            // 
            this.remarkTextEdit.Location = new System.Drawing.Point(140, -66);
            this.remarkTextEdit.Name = "remarkTextEdit";
            this.remarkTextEdit.Size = new System.Drawing.Size(258, 20);
            this.remarkTextEdit.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "Gudang";
            // 
            // textBoxEx1
            // 
            this.textBoxEx1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hproBindingSource, "loc", true));
            this.textBoxEx1.ExAllowEmptyString = true;
            this.textBoxEx1.ExAllowNonDBData = false;
            this.textBoxEx1.ExAutoCheck = true;
            this.textBoxEx1.ExAutoShowResult = false;
            this.textBoxEx1.ExCondition = "";
            this.textBoxEx1.ExDialogTitle = "";
            this.textBoxEx1.ExFieldName = "Kode Lokasi";
            this.textBoxEx1.ExFilterFields = new string[0];
            this.textBoxEx1.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.textBoxEx1.ExInvalidForeColor = System.Drawing.Color.Black;
            this.textBoxEx1.ExLabelContainer = null;
            this.textBoxEx1.ExLabelField = "Nama Lokasi";
            this.textBoxEx1.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.textBoxEx1.ExLabelText = "";
            this.textBoxEx1.ExLabelVisible = true;
            this.textBoxEx1.ExSelectFields = new string[0];
            this.textBoxEx1.ExShowDialog = true;
            this.textBoxEx1.ExSimpleMode = false;
            this.textBoxEx1.ExSqlInstance = null;
            this.textBoxEx1.ExSqlQuery = "Call SP_BrowseM(\'Master.FrmMasterLoc\')";
            this.textBoxEx1.ExTableName = "";
            this.textBoxEx1.Location = new System.Drawing.Point(98, 6);
            this.textBoxEx1.Name = "textBoxEx1";
            this.textBoxEx1.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxEx1.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.textBoxEx1.Properties.Appearance.Options.UseBackColor = true;
            this.textBoxEx1.Properties.Appearance.Options.UseForeColor = true;
            this.textBoxEx1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.textBoxEx1.Size = new System.Drawing.Size(100, 20);
            this.textBoxEx1.TabIndex = 74;
            // 
            // hproBindingSource
            // 
            this.hproBindingSource.DataMember = "hpro";
            this.hproBindingSource.DataSource = this.casDataSet;
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hproBindingSource, "remark", true));
            this.textEdit1.Location = new System.Drawing.Point(98, 32);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(258, 20);
            this.textEdit1.TabIndex = 76;
            // 
            // gcHPP
            // 
            this.gcHPP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcHPP.BestFitColumn = true;
            this.gcHPP.ExAutoSize = false;
            this.gcHPP.Location = new System.Drawing.Point(12, 84);
            this.gcHPP.Name = "gcHPP";
            this.gcHPP.Size = new System.Drawing.Size(707, 261);
            this.gcHPP.TabIndex = 78;
            // 
            // hprodBindingSource
            // 
            this.hprodBindingSource.DataMember = "hprod";
            this.hprodBindingSource.DataSource = this.casDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 80;
            this.label5.Text = "Tanggal Akhir";
            // 
            // dateEdit1
            // 
            this.dateEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hproBindingSource, "datez", true));
            this.dateEdit1.EditValue = new System.DateTime(2010, 7, 1, 9, 13, 21, 500);
            this.dateEdit1.Location = new System.Drawing.Point(470, 32);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateEdit1.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateEdit1.Properties.Mask.IgnoreMaskBlank = false;
            this.dateEdit1.Size = new System.Drawing.Size(100, 23);
            this.dateEdit1.TabIndex = 81;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 339;
            this.label6.Text = "Cost Center";
            // 
            // txtCct
            // 
            this.txtCct.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hproBindingSource, "cct", true));
            this.txtCct.ExAllowEmptyString = true;
            this.txtCct.ExAllowNonDBData = false;
            this.txtCct.ExAutoCheck = true;
            this.txtCct.ExAutoShowResult = false;
            this.txtCct.ExCondition = "";
            this.txtCct.ExDialogTitle = "";
            this.txtCct.ExFieldName = "cct";
            this.txtCct.ExFilterFields = new string[0];
            this.txtCct.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtCct.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtCct.ExLabelContainer = null;
            this.txtCct.ExLabelField = "name";
            this.txtCct.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.txtCct.ExLabelText = "";
            this.txtCct.ExLabelVisible = true;
            this.txtCct.ExSelectFields = new string[0];
            this.txtCct.ExShowDialog = true;
            this.txtCct.ExSimpleMode = false;
            this.txtCct.ExSqlInstance = null;
            this.txtCct.ExSqlQuery = "select * from cct where cct like \'111%\'";
            this.txtCct.ExTableName = "";
            this.txtCct.Location = new System.Drawing.Point(98, 58);
            this.txtCct.Name = "txtCct";
            this.txtCct.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtCct.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtCct.Properties.Appearance.Options.UseBackColor = true;
            this.txtCct.Properties.Appearance.Options.UseForeColor = true;
            this.txtCct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtCct.Size = new System.Drawing.Size(100, 20);
            this.txtCct.TabIndex = 338;
            this.txtCct.EditValueChanged += new System.EventHandler(this.txtCct_EditValueChanged);
            // 
            // FrmTHPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 493);
            this.DetailBindingSource = this.hprodBindingSource;
            this.DetailTable = this.casDataSet.hprod;
            this.MasterBindingSource = this.hproBindingSource;
            this.MasterTable = this.casDataSet.hpro;
            this.Name = "FrmTHPP";
            this.Text = "Harga Pokok Produksi";
            this.Load += new System.EventHandler(this.FrmTHPP_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExLoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxEx1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hproBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hprodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCct.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private KASLibrary.TextBoxEx textBoxExLoc;
        private DevExpress.XtraEditors.TextEdit remarkTextEdit;
        private System.Windows.Forms.Label label3;
        private KASLibrary.TextBoxEx textBoxEx1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private KASLibrary.GridControlEx gcHPP;
        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource hproBindingSource;
        private System.Windows.Forms.BindingSource hprodBindingSource;
        private System.Windows.Forms.Label label5;
        protected DevExpress.XtraEditors.DateEdit dateEdit1;
        private System.Windows.Forms.Label label6;
        private KASLibrary.TextBoxEx txtCct;
    }
}