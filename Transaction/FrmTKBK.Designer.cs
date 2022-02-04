namespace CAS.Transaction
{
    partial class FrmTKBK
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
            System.Windows.Forms.Label accLabel;
            System.Windows.Forms.Label remarkLabel;
            System.Windows.Forms.Label tobepaidLabel;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label subLabel;
            this.casDataSet = new CAS.casDataSet();
            this.remarkTextBox = new System.Windows.Forms.TextBox();
            this.kasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tobepaidTextBox = new System.Windows.Forms.TextBox();
            this.gcKBK = new KASLibrary.GridControlEx();
            this.textEditDebet = new DevExpress.XtraEditors.TextEdit();
            this.textEditKredit = new DevExpress.XtraEditors.TextEdit();
            this.textBoxEx1 = new KASLibrary.TextBoxEx();
            this.kadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.spinEditNilaiKasBank = new DevExpress.XtraEditors.SpinEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.txtSupplier = new KASLibrary.TextBoxEx();
            accLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            tobepaidLabel = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            subLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludSeri.Properties)).BeginInit();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curkurs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curcur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDebet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditKredit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxEx1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kadBindingSource)).BeginInit();
            this.pnlTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditNilaiKasBank.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplier.Properties)).BeginInit();
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
            this.pnlDetail.Controls.Add(this.txtSupplier);
            this.pnlDetail.Controls.Add(subLabel);
            this.pnlDetail.Controls.Add(this.checkEdit1);
            this.pnlDetail.Controls.Add(this.spinEditNilaiKasBank);
            this.pnlDetail.Controls.Add(this.pnlTotal);
            this.pnlDetail.Controls.Add(this.textBoxEx1);
            this.pnlDetail.Controls.Add(label2);
            this.pnlDetail.Controls.Add(this.gcKBK);
            this.pnlDetail.Controls.Add(tobepaidLabel);
            this.pnlDetail.Controls.Add(this.tobepaidTextBox);
            this.pnlDetail.Controls.Add(remarkLabel);
            this.pnlDetail.Controls.Add(this.remarkTextBox);
            this.pnlDetail.Controls.Add(accLabel);
            this.pnlDetail.Size = new System.Drawing.Size(743, 484);
            this.pnlDetail.Controls.SetChildIndex(this.dateDate, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curcur, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curkurs, 0);
            this.pnlDetail.Controls.SetChildIndex(this.kursLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curLabel1, 0);
            this.pnlDetail.Controls.SetChildIndex(accLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.remarkTextBox, 0);
            this.pnlDetail.Controls.SetChildIndex(remarkLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.tobepaidTextBox, 0);
            this.pnlDetail.Controls.SetChildIndex(tobepaidLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.gcKBK, 0);
            this.pnlDetail.Controls.SetChildIndex(label2, 0);
            this.pnlDetail.Controls.SetChildIndex(this.textBoxEx1, 0);
            this.pnlDetail.Controls.SetChildIndex(this.pnlTotal, 0);
            this.pnlDetail.Controls.SetChildIndex(this.spinEditNilaiKasBank, 0);
            this.pnlDetail.Controls.SetChildIndex(this.checkEdit1, 0);
            this.pnlDetail.Controls.SetChildIndex(subLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.txtSupplier, 0);
            // 
            // pnlKey
            // 
            this.pnlKey.Size = new System.Drawing.Size(743, 50);
            // 
            // dateDate
            // 
            this.dateDate.EditValue = new System.DateTime(((long)(0)));
            this.dateDate.Location = new System.Drawing.Point(465, 12);
            this.dateDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateDate.Properties.Mask.IgnoreMaskBlank = false;
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(413, 15);
            // 
            // curkurs
            // 
            this.curkurs.Location = new System.Drawing.Point(564, 38);
            // 
            // curcur
            // 
            this.curcur.Location = new System.Drawing.Point(465, 38);
            this.curcur.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.curcur.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.curcur.Properties.Appearance.Options.UseBackColor = true;
            this.curcur.Properties.Appearance.Options.UseForeColor = true;
            // 
            // curLabel1
            // 
            this.curLabel1.Location = new System.Drawing.Point(434, 41);
            // 
            // kursLabel
            // 
            this.kursLabel.Location = new System.Drawing.Point(528, 41);
            // 
            // accLabel
            // 
            accLabel.AutoSize = true;
            accLabel.Location = new System.Drawing.Point(12, 12);
            accLabel.Name = "accLabel";
            accLabel.Size = new System.Drawing.Size(60, 13);
            accLabel.TabIndex = 28;
            accLabel.Text = "Kas / Bank ";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(11, 35);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(66, 13);
            remarkLabel.TabIndex = 29;
            remarkLabel.Text = "Keterangan ";
            // 
            // tobepaidLabel
            // 
            tobepaidLabel.AutoSize = true;
            tobepaidLabel.Location = new System.Drawing.Point(11, 64);
            tobepaidLabel.Name = "tobepaidLabel";
            tobepaidLabel.Size = new System.Drawing.Size(60, 13);
            tobepaidLabel.TabIndex = 30;
            tobepaidLabel.Text = "To Be Paid ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(1, 6);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(63, 13);
            label9.TabIndex = 107;
            label9.Text = "Total Debet";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(11, 90);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(79, 13);
            label2.TabIndex = 109;
            label2.Text = "Nilai Kas/Bank  ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(1, 32);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(62, 13);
            label3.TabIndex = 111;
            label3.Text = "Total Kredit";
            // 
            // subLabel
            // 
            subLabel.AutoSize = true;
            subLabel.Location = new System.Drawing.Point(360, 67);
            subLabel.Name = "subLabel";
            subLabel.Size = new System.Drawing.Size(102, 13);
            subLabel.TabIndex = 116;
            subLabel.Text = "Supplier/Customer :";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // remarkTextBox
            // 
            this.remarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kasBindingSource, "remark", true));
            this.remarkTextBox.Location = new System.Drawing.Point(94, 35);
            this.remarkTextBox.Name = "remarkTextBox";
            this.remarkTextBox.Size = new System.Drawing.Size(274, 20);
            this.remarkTextBox.TabIndex = 30;
            // 
            // kasBindingSource
            // 
            this.kasBindingSource.DataMember = "kas";
            this.kasBindingSource.DataSource = this.casDataSet;
            this.kasBindingSource.Filter = "group_=3";
            // 
            // tobepaidTextBox
            // 
            this.tobepaidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kasBindingSource, "tobepaid", true));
            this.tobepaidTextBox.Location = new System.Drawing.Point(94, 61);
            this.tobepaidTextBox.Name = "tobepaidTextBox";
            this.tobepaidTextBox.Size = new System.Drawing.Size(219, 20);
            this.tobepaidTextBox.TabIndex = 31;
            // 
            // gcKBK
            // 
            this.gcKBK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcKBK.BestFitColumn = true;
            this.gcKBK.ExAutoSize = false;
            this.gcKBK.Location = new System.Drawing.Point(15, 121);
            this.gcKBK.Name = "gcKBK";
            this.gcKBK.Size = new System.Drawing.Size(711, 297);
            this.gcKBK.TabIndex = 79;
            // 
            // textEditDebet
            // 
            this.textEditDebet.Enabled = false;
            this.textEditDebet.Location = new System.Drawing.Point(83, 3);
            this.textEditDebet.Name = "textEditDebet";
            this.textEditDebet.Properties.Appearance.Options.UseTextOptions = true;
            this.textEditDebet.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.textEditDebet.Size = new System.Drawing.Size(121, 20);
            this.textEditDebet.TabIndex = 106;
            // 
            // textEditKredit
            // 
            this.textEditKredit.Enabled = false;
            this.textEditKredit.Location = new System.Drawing.Point(83, 29);
            this.textEditKredit.Name = "textEditKredit";
            this.textEditKredit.Properties.Appearance.Options.UseTextOptions = true;
            this.textEditKredit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.textEditKredit.Size = new System.Drawing.Size(121, 20);
            this.textEditKredit.TabIndex = 110;
            // 
            // textBoxEx1
            // 
            this.textBoxEx1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kasBindingSource, "acc", true));
            this.textBoxEx1.ExAllowEmptyString = true;
            this.textBoxEx1.ExAllowNonDBData = false;
            this.textBoxEx1.ExAutoCheck = true;
            this.textBoxEx1.ExAutoShowResult = false;
            this.textBoxEx1.ExCondition = "";
            this.textBoxEx1.ExDialogTitle = "";
            this.textBoxEx1.ExFieldName = "Nomor Akun";
            this.textBoxEx1.ExFilterFields = new string[0];
            this.textBoxEx1.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.textBoxEx1.ExInvalidForeColor = System.Drawing.Color.Black;
            this.textBoxEx1.ExLabelContainer = null;
            this.textBoxEx1.ExLabelField = "Nama Akun";
            this.textBoxEx1.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.textBoxEx1.ExLabelText = "";
            this.textBoxEx1.ExLabelVisible = true;
            this.textBoxEx1.ExSelectFields = new string[0];
            this.textBoxEx1.ExShowDialog = true;
            this.textBoxEx1.ExSimpleMode = false;
            this.textBoxEx1.ExSqlInstance = null;
            this.textBoxEx1.ExSqlQuery = "Call SP_BrowseM(\'Master.FrmKAS\')";
            this.textBoxEx1.ExTableName = "";
            this.textBoxEx1.Location = new System.Drawing.Point(94, 9);
            this.textBoxEx1.Name = "textBoxEx1";
            this.textBoxEx1.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxEx1.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.textBoxEx1.Properties.Appearance.Options.UseBackColor = true;
            this.textBoxEx1.Properties.Appearance.Options.UseForeColor = true;
            this.textBoxEx1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.textBoxEx1.Size = new System.Drawing.Size(100, 20);
            this.textBoxEx1.TabIndex = 112;
            // 
            // kadBindingSource
            // 
            this.kadBindingSource.DataMember = "kad";
            this.kadBindingSource.DataSource = this.casDataSet;
            // 
            // pnlTotal
            // 
            this.pnlTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTotal.Controls.Add(this.textEditDebet);
            this.pnlTotal.Controls.Add(label9);
            this.pnlTotal.Controls.Add(this.textEditKredit);
            this.pnlTotal.Controls.Add(label3);
            this.pnlTotal.Location = new System.Drawing.Point(514, 424);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(212, 54);
            this.pnlTotal.TabIndex = 113;
            // 
            // spinEditNilaiKasBank
            // 
            this.spinEditNilaiKasBank.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kasBindingSource, "val", true));
            this.spinEditNilaiKasBank.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditNilaiKasBank.Location = new System.Drawing.Point(94, 87);
            this.spinEditNilaiKasBank.Name = "spinEditNilaiKasBank";
            this.spinEditNilaiKasBank.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEditNilaiKasBank.Properties.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.spinEditNilaiKasBank.Properties.UseCtrlIncrement = false;
            this.spinEditNilaiKasBank.Size = new System.Drawing.Size(116, 20);
            this.spinEditNilaiKasBank.TabIndex = 114;
            // 
            // checkEdit1
            // 
            this.checkEdit1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.kasBindingSource, "tcsi", true));
            this.checkEdit1.Location = new System.Drawing.Point(94, 113);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Tunai";
            this.checkEdit1.Size = new System.Drawing.Size(75, 18);
            this.checkEdit1.TabIndex = 115;
            this.checkEdit1.Visible = false;
            // 
            // txtSupplier
            // 
            this.txtSupplier.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kasBindingSource, "sub", true));
            this.txtSupplier.ExAllowEmptyString = true;
            this.txtSupplier.ExAllowNonDBData = false;
            this.txtSupplier.ExAutoCheck = true;
            this.txtSupplier.ExAutoShowResult = false;
            this.txtSupplier.ExCondition = "";
            this.txtSupplier.ExDialogTitle = "Supplier";
            this.txtSupplier.ExFieldName = "Kode";
            this.txtSupplier.ExFilterFields = new string[0];
            this.txtSupplier.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtSupplier.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtSupplier.ExLabelContainer = null;
            this.txtSupplier.ExLabelField = "Nama";
            this.txtSupplier.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.txtSupplier.ExLabelText = "";
            this.txtSupplier.ExLabelVisible = true;
            this.txtSupplier.ExSelectFields = new string[0];
            this.txtSupplier.ExShowDialog = true;
            this.txtSupplier.ExSimpleMode = false;
            this.txtSupplier.ExSqlInstance = null;
            this.txtSupplier.ExSqlQuery = "Call SP_LookUp(\'sub\')";
            this.txtSupplier.ExTableName = "";
            this.txtSupplier.Location = new System.Drawing.Point(465, 64);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtSupplier.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtSupplier.Properties.Appearance.Options.UseBackColor = true;
            this.txtSupplier.Properties.Appearance.Options.UseForeColor = true;
            this.txtSupplier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtSupplier.Size = new System.Drawing.Size(100, 20);
            this.txtSupplier.TabIndex = 117;
            // 
            // FrmTKBK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 614);
            this.DetailBindingSource = this.kadBindingSource;
            this.DetailTable = this.casDataSet.kad;
            this.MasterBindingSource = this.kasBindingSource;
            this.MasterTable = this.casDataSet.kas;
            this.Name = "FrmTKBK";
            this.Text = "Kas & Bank Keluar";
            this.Load += new System.EventHandler(this.FrmTKBK_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.kasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDebet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditKredit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxEx1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kadBindingSource)).EndInit();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditNilaiKasBank.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplier.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tobepaidTextBox;
        private casDataSet casDataSet;
        private System.Windows.Forms.TextBox remarkTextBox;
        private KASLibrary.GridControlEx gcKBK;
        private DevExpress.XtraEditors.TextEdit textEditKredit;
        private DevExpress.XtraEditors.TextEdit textEditDebet;
        private KASLibrary.TextBoxEx textBoxEx1;
        private System.Windows.Forms.BindingSource kasBindingSource;
        private System.Windows.Forms.BindingSource kadBindingSource;
        private System.Windows.Forms.Panel pnlTotal;
        private DevExpress.XtraEditors.SpinEdit spinEditNilaiKasBank;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private KASLibrary.TextBoxEx txtSupplier;
    }
}