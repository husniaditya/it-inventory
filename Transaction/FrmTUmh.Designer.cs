namespace CAS.Transaction
{
    partial class FrmTUmh
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
            System.Windows.Forms.Label omsLabel;
            System.Windows.Forms.Label sspdateLabel;
            System.Windows.Forms.Label fakdateLabel;
            System.Windows.Forms.Label pibLabel;
            System.Windows.Forms.Label bankLabel;
            System.Windows.Forms.Label remarkLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label bsaLabel;
            this.casDataSet = new CAS.casDataSet();
            this.umhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.umhTableAdapter = new CAS.casDataSetTableAdapters.umhTableAdapter();
            this.sspdateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.fakdateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.pibTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.bankTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.gcumh = new KASLibrary.GridControlEx();
            this.umdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ctrlSub = new CAS.Transaction.CtrlSub();
            this.remarkMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.omsTextBoxEx = new KASLibrary.TextBoxEx();
            this.txtTotalDebet = new DevExpress.XtraEditors.TextEdit();
            this.txtTotalKredit = new DevExpress.XtraEditors.TextEdit();
            this.txtSelisih = new DevExpress.XtraEditors.TextEdit();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.bsaTextBoxEx = new KASLibrary.TextBoxEx();
            omsLabel = new System.Windows.Forms.Label();
            sspdateLabel = new System.Windows.Forms.Label();
            fakdateLabel = new System.Windows.Forms.Label();
            pibLabel = new System.Windows.Forms.Label();
            bankLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.umhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sspdateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakdateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.umdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.omsTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalDebet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalKredit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSelisih.Properties)).BeginInit();
            this.pnlTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsaTextBoxEx.Properties)).BeginInit();
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
            this.pnlDetail.Controls.Add(bsaLabel);
            this.pnlDetail.Controls.Add(this.bsaTextBoxEx);
            this.pnlDetail.Controls.Add(this.pnlTotal);
            this.pnlDetail.Controls.Add(this.omsTextBoxEx);
            this.pnlDetail.Controls.Add(remarkLabel);
            this.pnlDetail.Controls.Add(this.remarkMemoEdit);
            this.pnlDetail.Controls.Add(this.ctrlSub);
            this.pnlDetail.Controls.Add(omsLabel);
            this.pnlDetail.Controls.Add(this.gcumh);
            this.pnlDetail.Controls.Add(this.bankTextEdit);
            this.pnlDetail.Controls.Add(bankLabel);
            this.pnlDetail.Controls.Add(this.pibTextEdit);
            this.pnlDetail.Controls.Add(pibLabel);
            this.pnlDetail.Controls.Add(this.fakdateDateEdit);
            this.pnlDetail.Controls.Add(sspdateLabel);
            this.pnlDetail.Controls.Add(this.sspdateDateEdit);
            this.pnlDetail.Controls.Add(fakdateLabel);
            this.pnlDetail.Location = new System.Drawing.Point(0, 81);
            this.pnlDetail.Size = new System.Drawing.Size(713, 530);
            this.pnlDetail.Controls.SetChildIndex(fakdateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.sspdateDateEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(sspdateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.fakdateDateEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(pibLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.pibTextEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateDate, 0);
            this.pnlDetail.Controls.SetChildIndex(bankLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curcur, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curkurs, 0);
            this.pnlDetail.Controls.SetChildIndex(this.kursLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curLabel1, 0);
            this.pnlDetail.Controls.SetChildIndex(this.bankTextEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(this.gcumh, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(omsLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.ctrlSub, 0);
            this.pnlDetail.Controls.SetChildIndex(this.remarkMemoEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(remarkLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.omsTextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(this.pnlTotal, 0);
            this.pnlDetail.Controls.SetChildIndex(this.bsaTextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(bsaLabel, 0);
            // 
            // pnlKey
            // 
            this.pnlKey.Size = new System.Drawing.Size(713, 56);
            // 
            // dateDate
            // 
            this.dateDate.EditValue = new System.DateTime(((long)(0)));
            this.dateDate.Location = new System.Drawing.Point(415, 3);
            this.dateDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateDate.Properties.Mask.IgnoreMaskBlank = false;
            this.dateDate.Size = new System.Drawing.Size(86, 23);
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(363, 6);
            // 
            // curkurs
            // 
            this.curkurs.Location = new System.Drawing.Point(510, 29);
            // 
            // curcur
            // 
            this.curcur.Location = new System.Drawing.Point(415, 29);
            this.curcur.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.curcur.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.curcur.Properties.Appearance.Options.UseBackColor = true;
            this.curcur.Properties.Appearance.Options.UseForeColor = true;
            // 
            // curLabel1
            // 
            this.curLabel1.Location = new System.Drawing.Point(384, 32);
            // 
            // kursLabel
            // 
            this.kursLabel.Location = new System.Drawing.Point(477, 32);
            // 
            // omsLabel
            // 
            omsLabel.AutoSize = true;
            omsLabel.Location = new System.Drawing.Point(34, 31);
            omsLabel.Name = "omsLabel";
            omsLabel.Size = new System.Drawing.Size(51, 13);
            omsLabel.TabIndex = 44;
            omsLabel.Text = "No Order";
            // 
            // sspdateLabel
            // 
            sspdateLabel.AutoSize = true;
            sspdateLabel.Location = new System.Drawing.Point(358, 55);
            sspdateLabel.Name = "sspdateLabel";
            sspdateLabel.Size = new System.Drawing.Size(47, 13);
            sspdateLabel.TabIndex = 46;
            sspdateLabel.Text = "SSPdate";
            // 
            // fakdateLabel
            // 
            fakdateLabel.AutoSize = true;
            fakdateLabel.Location = new System.Drawing.Point(363, 81);
            fakdateLabel.Name = "fakdateLabel";
            fakdateLabel.Size = new System.Drawing.Size(46, 13);
            fakdateLabel.TabIndex = 48;
            fakdateLabel.Text = "FPJdate";
            // 
            // pibLabel
            // 
            pibLabel.AutoSize = true;
            pibLabel.Location = new System.Drawing.Point(515, 55);
            pibLabel.Name = "pibLabel";
            pibLabel.Size = new System.Drawing.Size(40, 13);
            pibLabel.TabIndex = 50;
            pibLabel.Text = "No.PIB";
            // 
            // bankLabel
            // 
            bankLabel.AutoSize = true;
            bankLabel.Location = new System.Drawing.Point(524, 81);
            bankLabel.Name = "bankLabel";
            bankLabel.Size = new System.Drawing.Size(30, 13);
            bankLabel.TabIndex = 52;
            bankLabel.Text = "Bank";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(350, 106);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(63, 13);
            remarkLabel.TabIndex = 59;
            remarkLabel.Text = "Keterangan";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(-2, 28);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(62, 13);
            label3.TabIndex = 66;
            label3.Text = "Total Kredit";
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
            // bsaLabel
            // 
            bsaLabel.AutoSize = true;
            bsaLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            bsaLabel.ForeColor = System.Drawing.Color.Red;
            bsaLabel.Location = new System.Drawing.Point(16, 4);
            bsaLabel.Name = "bsaLabel";
            bsaLabel.Size = new System.Drawing.Size(69, 13);
            bsaLabel.TabIndex = 139;
            bsaLabel.Text = "Bisnis Area";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // umhBindingSource
            // 
            this.umhBindingSource.DataMember = "umh";
            this.umhBindingSource.DataSource = this.casDataSet;
            // 
            // umhTableAdapter
            // 
            this.umhTableAdapter.ClearBeforeFill = true;
            // 
            // sspdateDateEdit
            // 
            this.sspdateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.umhBindingSource, "sspdate", true));
            this.sspdateDateEdit.EditValue = null;
            this.sspdateDateEdit.Location = new System.Drawing.Point(415, 52);
            this.sspdateDateEdit.Name = "sspdateDateEdit";
            this.sspdateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sspdateDateEdit.Size = new System.Drawing.Size(94, 23);
            this.sspdateDateEdit.TabIndex = 47;
            // 
            // fakdateDateEdit
            // 
            this.fakdateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.umhBindingSource, "fakdate", true));
            this.fakdateDateEdit.EditValue = null;
            this.fakdateDateEdit.Location = new System.Drawing.Point(415, 78);
            this.fakdateDateEdit.Name = "fakdateDateEdit";
            this.fakdateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fakdateDateEdit.Size = new System.Drawing.Size(94, 23);
            this.fakdateDateEdit.TabIndex = 49;
            // 
            // pibTextEdit
            // 
            this.pibTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.umhBindingSource, "pib", true));
            this.pibTextEdit.Location = new System.Drawing.Point(559, 52);
            this.pibTextEdit.Name = "pibTextEdit";
            this.pibTextEdit.Size = new System.Drawing.Size(100, 20);
            this.pibTextEdit.TabIndex = 51;
            // 
            // bankTextEdit
            // 
            this.bankTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.umhBindingSource, "bank", true));
            this.bankTextEdit.Location = new System.Drawing.Point(559, 78);
            this.bankTextEdit.Name = "bankTextEdit";
            this.bankTextEdit.Size = new System.Drawing.Size(100, 20);
            this.bankTextEdit.TabIndex = 53;
            // 
            // gcumh
            // 
            this.gcumh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcumh.BestFitColumn = true;
            this.gcumh.ExAutoSize = false;
            this.gcumh.Location = new System.Drawing.Point(12, 174);
            this.gcumh.Name = "gcumh";
            this.gcumh.Size = new System.Drawing.Size(680, 261);
            this.gcumh.TabIndex = 58;
            // 
            // umdBindingSource
            // 
            this.umdBindingSource.DataMember = "umd";
            this.umdBindingSource.DataSource = this.casDataSet;
            // 
            // ctrlSub
            // 
            this.ctrlSub.Location = new System.Drawing.Point(13, 53);
            this.ctrlSub.Name = "ctrlSub";
            this.ctrlSub.ReadOnly = true;
            this.ctrlSub.Size = new System.Drawing.Size(335, 115);
            this.ctrlSub.TabIndex = 59;
            this.ctrlSub.Type = CAS.Transaction.CtrlSub.SubType.All;
            // 
            // remarkMemoEdit
            // 
            this.remarkMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.umhBindingSource, "remark", true));
            this.remarkMemoEdit.Location = new System.Drawing.Point(415, 106);
            this.remarkMemoEdit.Name = "remarkMemoEdit";
            this.remarkMemoEdit.Size = new System.Drawing.Size(270, 62);
            this.remarkMemoEdit.TabIndex = 60;
            // 
            // omsTextBoxEx
            // 
            this.omsTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.umhBindingSource, "oms", true));
            this.omsTextBoxEx.ExAllowEmptyString = true;
            this.omsTextBoxEx.ExAllowNonDBData = false;
            this.omsTextBoxEx.ExAutoCheck = true;
            this.omsTextBoxEx.ExAutoShowResult = false;
            this.omsTextBoxEx.ExCondition = "";
            this.omsTextBoxEx.ExDialogTitle = "";
            this.omsTextBoxEx.ExFieldName = "oms";
            this.omsTextBoxEx.ExFilterFields = new string[0];
            this.omsTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.omsTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.omsTextBoxEx.ExLabelContainer = null;
            this.omsTextBoxEx.ExLabelField = "";
            this.omsTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.omsTextBoxEx.ExLabelText = "";
            this.omsTextBoxEx.ExLabelVisible = false;
            this.omsTextBoxEx.ExSelectFields = new string[0];
            this.omsTextBoxEx.ExShowDialog = true;
            this.omsTextBoxEx.ExSimpleMode = true;
            this.omsTextBoxEx.ExSqlInstance = null;
            this.omsTextBoxEx.ExSqlQuery = "";
            this.omsTextBoxEx.ExTableName = "oms";
            this.omsTextBoxEx.Location = new System.Drawing.Point(94, 28);
            this.omsTextBoxEx.Name = "omsTextBoxEx";
            this.omsTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.omsTextBoxEx.Size = new System.Drawing.Size(135, 20);
            this.omsTextBoxEx.TabIndex = 61;
            this.omsTextBoxEx.EditValueChanged += new System.EventHandler(this.omsTextBoxEx_EditValueChanged);
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
            // pnlTotal
            // 
            this.pnlTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTotal.Controls.Add(this.txtTotalDebet);
            this.pnlTotal.Controls.Add(label4);
            this.pnlTotal.Controls.Add(this.txtTotalKredit);
            this.pnlTotal.Controls.Add(label3);
            this.pnlTotal.Controls.Add(this.txtSelisih);
            this.pnlTotal.Controls.Add(label2);
            this.pnlTotal.Location = new System.Drawing.Point(443, 441);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(249, 74);
            this.pnlTotal.TabIndex = 68;
            // 
            // bsaTextBoxEx
            // 
            this.bsaTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.umhBindingSource, "bsa", true));
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
            this.bsaTextBoxEx.Location = new System.Drawing.Point(94, 3);
            this.bsaTextBoxEx.Name = "bsaTextBoxEx";
            this.bsaTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.bsaTextBoxEx.Size = new System.Drawing.Size(81, 20);
            this.bsaTextBoxEx.TabIndex = 140;
            // 
            // FrmTUmh
            // 
            this.ClientSize = new System.Drawing.Size(713, 666);
            this.DetailBindingSource = this.umdBindingSource;
            this.DetailTable = this.casDataSet.umd;
            this.MasterBindingSource = this.umhBindingSource;
            this.MasterTable = this.casDataSet.umh;
            this.Name = "FrmTUmh";
            this.Text = "Jurnal Perkiraan";
            this.Load += new System.EventHandler(this.FrmTUmh_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.umhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sspdateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakdateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.umdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.omsTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalDebet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalKredit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSelisih.Properties)).EndInit();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsaTextBoxEx.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource umhBindingSource;
        private CAS.casDataSetTableAdapters.umhTableAdapter umhTableAdapter;
        private DevExpress.XtraEditors.DateEdit sspdateDateEdit;
        private DevExpress.XtraEditors.DateEdit fakdateDateEdit;
        private DevExpress.XtraEditors.TextEdit pibTextEdit;
        private DevExpress.XtraEditors.TextEdit bankTextEdit;
        private KASLibrary.GridControlEx gcumh;
        private System.Windows.Forms.BindingSource umdBindingSource;
        private DevExpress.XtraEditors.MemoEdit remarkMemoEdit;
        private CtrlSub ctrlSub;
        private KASLibrary.TextBoxEx omsTextBoxEx;
        private DevExpress.XtraEditors.TextEdit txtSelisih;
        private DevExpress.XtraEditors.TextEdit txtTotalKredit;
        private DevExpress.XtraEditors.TextEdit txtTotalDebet;
        private System.Windows.Forms.Panel pnlTotal;
        private KASLibrary.TextBoxEx bsaTextBoxEx;
    }
}
