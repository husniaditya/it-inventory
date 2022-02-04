namespace CAS.Transaction
{
    partial class FrmTKBM
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
            System.Windows.Forms.Label tobepaidLabel;
            System.Windows.Forms.Label remarkLabel;
            System.Windows.Forms.Label accLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label subLabel;
            this.casDataSet = new CAS.casDataSet();
            this.kasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxEx1 = new KASLibrary.TextBoxEx();
            this.tobepaidTextBox = new System.Windows.Forms.TextBox();
            this.remarkTextBox = new System.Windows.Forms.TextBox();
            this.textEditKredit = new DevExpress.XtraEditors.TextEdit();
            this.textEditDebet = new DevExpress.XtraEditors.TextEdit();
            this.gcKBM = new KASLibrary.GridControlEx();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.spinEditNilaiKasBank = new DevExpress.XtraEditors.SpinEdit();
            this.txtCustomer = new KASLibrary.TextBoxEx();
            tobepaidLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            accLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.kadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxEx1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditKredit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDebet.Properties)).BeginInit();
            this.pnlTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditNilaiKasBank.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(362, 29);
            this.txtNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNo.Size = new System.Drawing.Size(128, 26);
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(288, 29);
            this.txtPeriod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPeriod.Size = new System.Drawing.Size(64, 26);
            // 
            // ludSeri
            // 
            this.ludSeri.Location = new System.Drawing.Point(172, 29);
            this.ludSeri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ludSeri.Size = new System.Drawing.Size(106, 26);
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(subLabel);
            this.pnlDetail.Controls.Add(this.txtCustomer);
            this.pnlDetail.Controls.Add(this.spinEditNilaiKasBank);
            this.pnlDetail.Controls.Add(this.pnlTotal);
            this.pnlDetail.Controls.Add(label2);
            this.pnlDetail.Controls.Add(this.gcKBM);
            this.pnlDetail.Controls.Add(this.textBoxEx1);
            this.pnlDetail.Controls.Add(this.remarkTextBox);
            this.pnlDetail.Controls.Add(remarkLabel);
            this.pnlDetail.Controls.Add(accLabel);
            this.pnlDetail.Controls.Add(this.tobepaidTextBox);
            this.pnlDetail.Controls.Add(tobepaidLabel);
            this.pnlDetail.Location = new System.Drawing.Point(0, 109);
            this.pnlDetail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlDetail.Size = new System.Drawing.Size(1034, 696);
            this.pnlDetail.Controls.SetChildIndex(this.dateDate, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curcur, 0);
            this.pnlDetail.Controls.SetChildIndex(tobepaidLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.kursLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curLabel1, 0);
            this.pnlDetail.Controls.SetChildIndex(this.tobepaidTextBox, 0);
            this.pnlDetail.Controls.SetChildIndex(accLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curkurs, 0);
            this.pnlDetail.Controls.SetChildIndex(remarkLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.remarkTextBox, 0);
            this.pnlDetail.Controls.SetChildIndex(this.textBoxEx1, 0);
            this.pnlDetail.Controls.SetChildIndex(this.gcKBM, 0);
            this.pnlDetail.Controls.SetChildIndex(label2, 0);
            this.pnlDetail.Controls.SetChildIndex(this.pnlTotal, 0);
            this.pnlDetail.Controls.SetChildIndex(this.spinEditNilaiKasBank, 0);
            this.pnlDetail.Controls.SetChildIndex(this.txtCustomer, 0);
            this.pnlDetail.Controls.SetChildIndex(subLabel, 0);
            // 
            // pnlKey
            // 
            this.pnlKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlKey.Size = new System.Drawing.Size(1034, 77);
            // 
            // dateDate
            // 
            this.dateDate.EditValue = new System.DateTime(((long)(0)));
            this.dateDate.Location = new System.Drawing.Point(693, 18);
            this.dateDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateDate.Properties.Mask.IgnoreMaskBlank = false;
            this.dateDate.Size = new System.Drawing.Size(150, 26);
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(615, 23);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // curkurs
            // 
            this.curkurs.Location = new System.Drawing.Point(842, 58);
            this.curkurs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.curkurs.Size = new System.Drawing.Size(110, 26);
            // 
            // curcur
            // 
            this.curcur.Location = new System.Drawing.Point(693, 58);
            this.curcur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.curcur.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.curcur.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.curcur.Properties.Appearance.Options.UseBackColor = true;
            this.curcur.Properties.Appearance.Options.UseForeColor = true;
            this.curcur.Size = new System.Drawing.Size(86, 26);
            // 
            // curLabel1
            // 
            this.curLabel1.Location = new System.Drawing.Point(646, 63);
            this.curLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // kursLabel
            // 
            this.kursLabel.Location = new System.Drawing.Point(788, 63);
            this.kursLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(92, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // btnDocFlow
            // 
            this.btnDocFlow.Location = new System.Drawing.Point(699, 25);
            this.btnDocFlow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDocFlow.Size = new System.Drawing.Size(129, 35);
            // 
            // lblDeleted
            // 
            this.lblDeleted.Location = new System.Drawing.Point(526, 25);
            this.lblDeleted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // tobepaidLabel
            // 
            tobepaidLabel.AutoSize = true;
            tobepaidLabel.Location = new System.Drawing.Point(16, 98);
            tobepaidLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tobepaidLabel.Name = "tobepaidLabel";
            tobepaidLabel.Size = new System.Drawing.Size(85, 19);
            tobepaidLabel.TabIndex = 115;
            tobepaidLabel.Text = "To Be Paid";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(16, 54);
            remarkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(88, 19);
            remarkLabel.TabIndex = 114;
            remarkLabel.Text = "Keterangan";
            // 
            // accLabel
            // 
            accLabel.AutoSize = true;
            accLabel.Location = new System.Drawing.Point(18, 18);
            accLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            accLabel.Name = "accLabel";
            accLabel.Size = new System.Drawing.Size(83, 19);
            accLabel.TabIndex = 113;
            accLabel.Text = "Kas / Bank";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(10, 12);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(91, 19);
            label3.TabIndex = 125;
            label3.Text = "Total Kredit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(15, 138);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(109, 19);
            label2.TabIndex = 123;
            label2.Text = "Nilai Kas/Bank";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(10, 52);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(91, 19);
            label9.TabIndex = 121;
            label9.Text = "Total Debet";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kasBindingSource
            // 
            this.kasBindingSource.DataMember = "kas";
            this.kasBindingSource.DataSource = this.casDataSet;
            this.kasBindingSource.Filter = "group_=4";
            // 
            // kadBindingSource
            // 
            this.kadBindingSource.DataMember = "kad";
            this.kadBindingSource.DataSource = this.casDataSet;
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
            this.textBoxEx1.Location = new System.Drawing.Point(140, 14);
            this.textBoxEx1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEx1.Name = "textBoxEx1";
            this.textBoxEx1.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxEx1.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.textBoxEx1.Properties.Appearance.Options.UseBackColor = true;
            this.textBoxEx1.Properties.Appearance.Options.UseForeColor = true;
            this.textBoxEx1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.textBoxEx1.Size = new System.Drawing.Size(150, 26);
            this.textBoxEx1.TabIndex = 118;
            // 
            // tobepaidTextBox
            // 
            this.tobepaidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kasBindingSource, "tobepaid", true));
            this.tobepaidTextBox.Location = new System.Drawing.Point(140, 94);
            this.tobepaidTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tobepaidTextBox.Name = "tobepaidTextBox";
            this.tobepaidTextBox.Size = new System.Drawing.Size(326, 26);
            this.tobepaidTextBox.TabIndex = 117;
            // 
            // remarkTextBox
            // 
            this.remarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kasBindingSource, "remark", true));
            this.remarkTextBox.Location = new System.Drawing.Point(140, 54);
            this.remarkTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.remarkTextBox.Name = "remarkTextBox";
            this.remarkTextBox.Size = new System.Drawing.Size(409, 26);
            this.remarkTextBox.TabIndex = 116;
            // 
            // textEditKredit
            // 
            this.textEditKredit.Enabled = false;
            this.textEditKredit.Location = new System.Drawing.Point(134, 8);
            this.textEditKredit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEditKredit.Name = "textEditKredit";
            this.textEditKredit.Properties.Appearance.Options.UseTextOptions = true;
            this.textEditKredit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.textEditKredit.Size = new System.Drawing.Size(182, 26);
            this.textEditKredit.TabIndex = 124;
            // 
            // textEditDebet
            // 
            this.textEditDebet.Enabled = false;
            this.textEditDebet.Location = new System.Drawing.Point(134, 48);
            this.textEditDebet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEditDebet.Name = "textEditDebet";
            this.textEditDebet.Properties.Appearance.Options.UseTextOptions = true;
            this.textEditDebet.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.textEditDebet.Size = new System.Drawing.Size(182, 26);
            this.textEditDebet.TabIndex = 120;
            // 
            // gcKBM
            // 
            this.gcKBM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcKBM.BestFitColumn = true;
            this.gcKBM.ExAutoSize = false;
            this.gcKBM.Location = new System.Drawing.Point(22, 152);
            this.gcKBM.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.gcKBM.Name = "gcKBM";
            this.gcKBM.Size = new System.Drawing.Size(986, 415);
            this.gcKBM.TabIndex = 119;
            // 
            // pnlTotal
            // 
            this.pnlTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTotal.Controls.Add(this.textEditDebet);
            this.pnlTotal.Controls.Add(this.textEditKredit);
            this.pnlTotal.Controls.Add(label9);
            this.pnlTotal.Controls.Add(label3);
            this.pnlTotal.Location = new System.Drawing.Point(677, 589);
            this.pnlTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(326, 98);
            this.pnlTotal.TabIndex = 126;
            // 
            // spinEditNilaiKasBank
            // 
            this.spinEditNilaiKasBank.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kasBindingSource, "val", true));
            this.spinEditNilaiKasBank.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditNilaiKasBank.Location = new System.Drawing.Point(140, 134);
            this.spinEditNilaiKasBank.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.spinEditNilaiKasBank.Name = "spinEditNilaiKasBank";
            this.spinEditNilaiKasBank.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEditNilaiKasBank.Properties.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.spinEditNilaiKasBank.Properties.UseCtrlIncrement = false;
            this.spinEditNilaiKasBank.Size = new System.Drawing.Size(196, 26);
            this.spinEditNilaiKasBank.TabIndex = 127;
            // 
            // txtCustomer
            // 
            this.txtCustomer.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kasBindingSource, "sub", true));
            this.txtCustomer.ExAllowEmptyString = true;
            this.txtCustomer.ExAllowNonDBData = false;
            this.txtCustomer.ExAutoCheck = true;
            this.txtCustomer.ExAutoShowResult = false;
            this.txtCustomer.ExCondition = "";
            this.txtCustomer.ExDialogTitle = "Customer";
            this.txtCustomer.ExFieldName = "Kode";
            this.txtCustomer.ExFilterFields = new string[0];
            this.txtCustomer.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtCustomer.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtCustomer.ExLabelContainer = null;
            this.txtCustomer.ExLabelField = "Nama";
            this.txtCustomer.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.txtCustomer.ExLabelText = "";
            this.txtCustomer.ExLabelVisible = true;
            this.txtCustomer.ExSelectFields = new string[0];
            this.txtCustomer.ExShowDialog = true;
            this.txtCustomer.ExSimpleMode = false;
            this.txtCustomer.ExSqlInstance = null;
            this.txtCustomer.ExSqlQuery = "Call SP_LookUp(\'sub\')";
            this.txtCustomer.ExTableName = "";
            this.txtCustomer.Location = new System.Drawing.Point(693, 98);
            this.txtCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtCustomer.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtCustomer.Properties.Appearance.Options.UseBackColor = true;
            this.txtCustomer.Properties.Appearance.Options.UseForeColor = true;
            this.txtCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtCustomer.Size = new System.Drawing.Size(150, 26);
            this.txtCustomer.TabIndex = 128;
            // 
            // subLabel
            // 
            subLabel.AutoSize = true;
            subLabel.Location = new System.Drawing.Point(529, 101);
            subLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            subLabel.Name = "subLabel";
            subLabel.Size = new System.Drawing.Size(152, 19);
            subLabel.TabIndex = 129;
            subLabel.Text = "Supplier/Customer :";
            // 
            // FrmTKBM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 886);
            this.DetailBindingSource = this.kadBindingSource;
            this.DetailTable = this.casDataSet.kad;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MasterBindingSource = this.kasBindingSource;
            this.MasterTable = this.casDataSet.kas;
            this.Name = "FrmTKBM";
            this.Text = "Kas & Bank Masuk";
            this.Load += new System.EventHandler(this.FrmTKBM_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.kadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxEx1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditKredit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDebet.Properties)).EndInit();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditNilaiKasBank.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource kasBindingSource;
        private System.Windows.Forms.BindingSource kadBindingSource;
        private KASLibrary.TextBoxEx textBoxEx1;
        private System.Windows.Forms.TextBox tobepaidTextBox;
        private System.Windows.Forms.TextBox remarkTextBox;
        private DevExpress.XtraEditors.TextEdit textEditKredit;
        private DevExpress.XtraEditors.TextEdit textEditDebet;
        private KASLibrary.GridControlEx gcKBM;
        private System.Windows.Forms.Panel pnlTotal;
        private DevExpress.XtraEditors.SpinEdit spinEditNilaiKasBank;
        private KASLibrary.TextBoxEx txtCustomer;
    }
}