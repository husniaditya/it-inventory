namespace CAS.Transaction
{
    partial class FrmTPoj
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
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label remarkLabel;
            System.Windows.Forms.Label ppnLabel;
            System.Windows.Forms.Label discLabel;
            System.Windows.Forms.Label fpjLabel;
            System.Windows.Forms.Label fpjdateLabel;
            System.Windows.Forms.Label approveLabel;
            System.Windows.Forms.Label closeLabel;
            System.Windows.Forms.Label personLabel;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label13;
            this.ctrlSub = new CAS.Transaction.CtrlSub();
            this.casDataSet = new CAS.casDataSet();
            this.gcxRmd = new KASLibrary.GridControlEx();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.txtPPH = new DevExpress.XtraEditors.TextEdit();
            this.txtPPNP = new DevExpress.XtraEditors.TextEdit();
            this.txtSubtotal = new DevExpress.XtraEditors.TextEdit();
            this.txtPPN = new DevExpress.XtraEditors.TextEdit();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.txtDisc = new DevExpress.XtraEditors.TextEdit();
            this.remarkMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.ppnCheckBox = new System.Windows.Forms.CheckBox();
            this.porBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.discSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.fpjTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.fpjdateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.aprovCheckBox = new System.Windows.Forms.CheckBox();
            this.closeCheckBox = new System.Windows.Forms.CheckBox();
            this.TOPSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.porTableAdapter = new CAS.casDataSetTableAdapters.porTableAdapter();
            this.pordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pordTableAdapter = new CAS.casDataSetTableAdapters.pordTableAdapter();
            this.personTextBoxEx = new KASLibrary.TextBoxEx();
            this.cbPPNGanti = new System.Windows.Forms.CheckBox();
            this.cbPPNBebas = new System.Windows.Forms.CheckBox();
            label6 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            ppnLabel = new System.Windows.Forms.Label();
            discLabel = new System.Windows.Forms.Label();
            fpjLabel = new System.Windows.Forms.Label();
            fpjdateLabel = new System.Windows.Forms.Label();
            approveLabel = new System.Windows.Forms.Label();
            closeLabel = new System.Windows.Forms.Label();
            personLabel = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludSeri.Properties)).BeginInit();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curkurs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curcur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            this.pnlTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPPH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPPNP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubtotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPPN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDisc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpjTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpjdateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TOPSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personTextBoxEx.Properties)).BeginInit();
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
            this.pnlDetail.Controls.Add(label12);
            this.pnlDetail.Controls.Add(label11);
            this.pnlDetail.Controls.Add(this.cbPPNGanti);
            this.pnlDetail.Controls.Add(this.cbPPNBebas);
            this.pnlDetail.Controls.Add(this.personTextBoxEx);
            this.pnlDetail.Controls.Add(personLabel);
            this.pnlDetail.Controls.Add(this.label2);
            this.pnlDetail.Controls.Add(this.TOPSpinEdit);
            this.pnlDetail.Controls.Add(closeLabel);
            this.pnlDetail.Controls.Add(this.closeCheckBox);
            this.pnlDetail.Controls.Add(approveLabel);
            this.pnlDetail.Controls.Add(this.aprovCheckBox);
            this.pnlDetail.Controls.Add(fpjdateLabel);
            this.pnlDetail.Controls.Add(this.fpjdateDateEdit);
            this.pnlDetail.Controls.Add(fpjLabel);
            this.pnlDetail.Controls.Add(this.fpjTextEdit);
            this.pnlDetail.Controls.Add(discLabel);
            this.pnlDetail.Controls.Add(this.discSpinEdit);
            this.pnlDetail.Controls.Add(ppnLabel);
            this.pnlDetail.Controls.Add(this.ppnCheckBox);
            this.pnlDetail.Controls.Add(remarkLabel);
            this.pnlDetail.Controls.Add(this.remarkMemoEdit);
            this.pnlDetail.Controls.Add(label10);
            this.pnlDetail.Controls.Add(this.txtDisc);
            this.pnlDetail.Controls.Add(this.pnlTotal);
            this.pnlDetail.Controls.Add(this.gcxRmd);
            this.pnlDetail.Controls.Add(this.ctrlSub);
            this.pnlDetail.Size = new System.Drawing.Size(1109, 597);
            this.pnlDetail.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDetail_Paint);
            this.pnlDetail.Controls.SetChildIndex(this.ctrlSub, 0);
            this.pnlDetail.Controls.SetChildIndex(this.gcxRmd, 0);
            this.pnlDetail.Controls.SetChildIndex(this.pnlTotal, 0);
            this.pnlDetail.Controls.SetChildIndex(this.txtDisc, 0);
            this.pnlDetail.Controls.SetChildIndex(label10, 0);
            this.pnlDetail.Controls.SetChildIndex(this.remarkMemoEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(remarkLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.ppnCheckBox, 0);
            this.pnlDetail.Controls.SetChildIndex(ppnLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.discSpinEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(discLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.fpjTextEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(fpjLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.fpjdateDateEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(fpjdateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.aprovCheckBox, 0);
            this.pnlDetail.Controls.SetChildIndex(approveLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.closeCheckBox, 0);
            this.pnlDetail.Controls.SetChildIndex(closeLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.TOPSpinEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(this.label2, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curLabel1, 0);
            this.pnlDetail.Controls.SetChildIndex(this.kursLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curkurs, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curcur, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateDate, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(personLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.personTextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(this.cbPPNBebas, 0);
            this.pnlDetail.Controls.SetChildIndex(this.cbPPNGanti, 0);
            this.pnlDetail.Controls.SetChildIndex(label11, 0);
            this.pnlDetail.Controls.SetChildIndex(label12, 0);
            // 
            // pnlKey
            // 
            this.pnlKey.Size = new System.Drawing.Size(1109, 50);
            // 
            // dateDate
            // 
            this.dateDate.EditValue = new System.DateTime(((long)(0)));
            this.dateDate.Location = new System.Drawing.Point(515, 11);
            this.dateDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateDate.Properties.Mask.IgnoreMaskBlank = false;
            this.dateDate.Size = new System.Drawing.Size(100, 26);
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(463, 14);
            // 
            // curkurs
            // 
            this.curkurs.Location = new System.Drawing.Point(614, 37);
            // 
            // curcur
            // 
            this.curcur.Location = new System.Drawing.Point(515, 37);
            this.curcur.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.curcur.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.curcur.Properties.Appearance.Options.UseBackColor = true;
            this.curcur.Properties.Appearance.Options.UseForeColor = true;
            this.curcur.Size = new System.Drawing.Size(57, 26);
            // 
            // curLabel1
            // 
            this.curLabel1.Location = new System.Drawing.Point(484, 40);
            // 
            // kursLabel
            // 
            this.kursLabel.Location = new System.Drawing.Point(578, 40);
            // 
            // btnDocFlow
            // 
            this.btnDocFlow.Visible = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(239, 10);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(77, 19);
            label6.TabIndex = 111;
            label6.Text = "Sub Total";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(239, 54);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(45, 19);
            label9.TabIndex = 113;
            label9.Text = "Total";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(239, 33);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(38, 19);
            label8.TabIndex = 112;
            label8.Text = "PPN";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(385, 617);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(70, 19);
            label10.TabIndex = 119;
            label10.Text = "Discount";
            label10.Visible = false;
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(10, 136);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(88, 19);
            remarkLabel.TabIndex = 119;
            remarkLabel.Text = "Keterangan";
            remarkLabel.Click += new System.EventHandler(this.remarkLabel_Click);
            // 
            // ppnLabel
            // 
            ppnLabel.AutoSize = true;
            ppnLabel.Location = new System.Drawing.Point(480, 99);
            ppnLabel.Name = "ppnLabel";
            ppnLabel.Size = new System.Drawing.Size(38, 19);
            ppnLabel.TabIndex = 120;
            ppnLabel.Text = "PPN";
            // 
            // discLabel
            // 
            discLabel.AutoSize = true;
            discLabel.Location = new System.Drawing.Point(546, 99);
            discLabel.Name = "discLabel";
            discLabel.Size = new System.Drawing.Size(38, 19);
            discLabel.TabIndex = 121;
            discLabel.Text = "Disc";
            discLabel.Visible = false;
            // 
            // fpjLabel
            // 
            fpjLabel.AutoSize = true;
            fpjLabel.Location = new System.Drawing.Point(416, 127);
            fpjLabel.Name = "fpjLabel";
            fpjLabel.Size = new System.Drawing.Size(132, 19);
            fpjLabel.TabIndex = 122;
            fpjLabel.Text = "Atas Faktur Pajak";
            // 
            // fpjdateLabel
            // 
            fpjdateLabel.AutoSize = true;
            fpjdateLabel.Location = new System.Drawing.Point(732, 17);
            fpjdateLabel.Name = "fpjdateLabel";
            fpjdateLabel.Size = new System.Drawing.Size(88, 19);
            fpjdateLabel.TabIndex = 123;
            fpjdateLabel.Text = "Tanggal FP";
            // 
            // approveLabel
            // 
            approveLabel.AutoSize = true;
            approveLabel.Location = new System.Drawing.Point(749, 45);
            approveLabel.Name = "approveLabel";
            approveLabel.Size = new System.Drawing.Size(69, 19);
            approveLabel.TabIndex = 124;
            approveLabel.Text = "Approve";
            approveLabel.Visible = false;
            // 
            // closeLabel
            // 
            closeLabel.AutoSize = true;
            closeLabel.Location = new System.Drawing.Point(854, 45);
            closeLabel.Name = "closeLabel";
            closeLabel.Size = new System.Drawing.Size(47, 19);
            closeLabel.TabIndex = 125;
            closeLabel.Text = "Close";
            closeLabel.Visible = false;
            // 
            // personLabel
            // 
            personLabel.AutoSize = true;
            personLabel.Location = new System.Drawing.Point(431, 164);
            personLabel.Name = "personLabel";
            personLabel.Size = new System.Drawing.Size(109, 19);
            personLabel.TabIndex = 131;
            personLabel.Text = "User Pemesan";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(546, 99);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(47, 19);
            label12.TabIndex = 136;
            label12.Text = "PPNP";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(634, 99);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(124, 19);
            label11.TabIndex = 138;
            label11.Text = "PPN Dibebaskan";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(46, 38);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(38, 19);
            label14.TabIndex = 117;
            label14.Text = "PPH";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(46, 11);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(47, 19);
            label13.TabIndex = 115;
            label13.Text = "PPNP";
            // 
            // ctrlSub
            // 
            this.ctrlSub.Location = new System.Drawing.Point(12, 13);
            this.ctrlSub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlSub.Name = "ctrlSub";
            this.ctrlSub.ReadOnly = true;
            this.ctrlSub.Size = new System.Drawing.Size(335, 115);
            this.ctrlSub.TabIndex = 29;
            this.ctrlSub.Type = CAS.Transaction.CtrlSub.SubType.Supplier;
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gcxRmd
            // 
            this.gcxRmd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcxRmd.BestFitColumn = true;
            this.gcxRmd.ExAutoSize = false;
            this.gcxRmd.Location = new System.Drawing.Point(13, 194);
            this.gcxRmd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gcxRmd.Name = "gcxRmd";
            this.gcxRmd.Size = new System.Drawing.Size(1075, 312);
            this.gcxRmd.TabIndex = 40;
            // 
            // pnlTotal
            // 
            this.pnlTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTotal.Controls.Add(this.txtPPH);
            this.pnlTotal.Controls.Add(label14);
            this.pnlTotal.Controls.Add(this.txtPPNP);
            this.pnlTotal.Controls.Add(label13);
            this.pnlTotal.Controls.Add(label6);
            this.pnlTotal.Controls.Add(this.txtSubtotal);
            this.pnlTotal.Controls.Add(this.txtPPN);
            this.pnlTotal.Controls.Add(label9);
            this.pnlTotal.Controls.Add(this.txtTotal);
            this.pnlTotal.Controls.Add(label8);
            this.pnlTotal.Location = new System.Drawing.Point(668, 512);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(429, 79);
            this.pnlTotal.TabIndex = 117;
            // 
            // txtPPH
            // 
            this.txtPPH.Location = new System.Drawing.Point(112, 34);
            this.txtPPH.Name = "txtPPH";
            this.txtPPH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtPPH.Properties.Appearance.Options.UseFont = true;
            this.txtPPH.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPPH.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtPPH.Size = new System.Drawing.Size(121, 27);
            this.txtPPH.TabIndex = 116;
            // 
            // txtPPNP
            // 
            this.txtPPNP.Location = new System.Drawing.Point(112, 7);
            this.txtPPNP.Name = "txtPPNP";
            this.txtPPNP.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtPPNP.Properties.Appearance.Options.UseFont = true;
            this.txtPPNP.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPPNP.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtPPNP.Size = new System.Drawing.Size(121, 27);
            this.txtPPNP.TabIndex = 114;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(305, 8);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSubtotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSubtotal.Size = new System.Drawing.Size(121, 26);
            this.txtSubtotal.TabIndex = 108;
            // 
            // txtPPN
            // 
            this.txtPPN.Location = new System.Drawing.Point(305, 30);
            this.txtPPN.Name = "txtPPN";
            this.txtPPN.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPPN.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtPPN.Size = new System.Drawing.Size(121, 26);
            this.txtPPN.TabIndex = 109;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(305, 51);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotal.Size = new System.Drawing.Size(121, 26);
            this.txtTotal.TabIndex = 110;
            // 
            // txtDisc
            // 
            this.txtDisc.Enabled = false;
            this.txtDisc.Location = new System.Drawing.Point(451, 614);
            this.txtDisc.Name = "txtDisc";
            this.txtDisc.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDisc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtDisc.Size = new System.Drawing.Size(121, 26);
            this.txtDisc.TabIndex = 118;
            this.txtDisc.Visible = false;
            // 
            // remarkMemoEdit
            // 
            this.remarkMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.porBindingSource, "remark", true));
            this.remarkMemoEdit.Location = new System.Drawing.Point(75, 134);
            this.remarkMemoEdit.Name = "remarkMemoEdit";
            this.remarkMemoEdit.Size = new System.Drawing.Size(272, 53);
            this.remarkMemoEdit.TabIndex = 120;
            this.remarkMemoEdit.EditValueChanged += new System.EventHandler(this.remarkMemoEdit_EditValueChanged);
            // 
            // ppnCheckBox
            // 
            this.ppnCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.porBindingSource, "ppn", true));
            this.ppnCheckBox.Location = new System.Drawing.Point(515, 94);
            this.ppnCheckBox.Name = "ppnCheckBox";
            this.ppnCheckBox.Size = new System.Drawing.Size(18, 24);
            this.ppnCheckBox.TabIndex = 121;
            this.ppnCheckBox.CheckedChanged += new System.EventHandler(this.ppnCheckBox_CheckedChanged);
            // 
            // porBindingSource
            // 
            this.porBindingSource.DataMember = "por";
            this.porBindingSource.DataSource = this.casDataSet;
            this.porBindingSource.Filter = "group_=1";
            // 
            // discSpinEdit
            // 
            this.discSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.discSpinEdit.Location = new System.Drawing.Point(581, 96);
            this.discSpinEdit.Name = "discSpinEdit";
            this.discSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.discSpinEdit.Properties.UseCtrlIncrement = false;
            this.discSpinEdit.Size = new System.Drawing.Size(51, 26);
            this.discSpinEdit.TabIndex = 122;
            this.discSpinEdit.Visible = false;
            this.discSpinEdit.EditValueChanged += new System.EventHandler(this.discSpinEdit_EditValueChanged);
            // 
            // fpjTextEdit
            // 
            this.fpjTextEdit.Location = new System.Drawing.Point(515, 124);
            this.fpjTextEdit.Name = "fpjTextEdit";
            this.fpjTextEdit.Size = new System.Drawing.Size(100, 26);
            this.fpjTextEdit.TabIndex = 123;
            // 
            // fpjdateDateEdit
            // 
            this.fpjdateDateEdit.EditValue = null;
            this.fpjdateDateEdit.Location = new System.Drawing.Point(801, 14);
            this.fpjdateDateEdit.Name = "fpjdateDateEdit";
            this.fpjdateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fpjdateDateEdit.Size = new System.Drawing.Size(100, 26);
            this.fpjdateDateEdit.TabIndex = 124;
            // 
            // aprovCheckBox
            // 
            this.aprovCheckBox.Location = new System.Drawing.Point(801, 40);
            this.aprovCheckBox.Name = "aprovCheckBox";
            this.aprovCheckBox.Size = new System.Drawing.Size(18, 24);
            this.aprovCheckBox.TabIndex = 125;
            this.aprovCheckBox.Visible = false;
            this.aprovCheckBox.CheckedChanged += new System.EventHandler(this.aprovCheckBox_CheckedChanged);
            // 
            // closeCheckBox
            // 
            this.closeCheckBox.Location = new System.Drawing.Point(895, 40);
            this.closeCheckBox.Name = "closeCheckBox";
            this.closeCheckBox.Size = new System.Drawing.Size(23, 24);
            this.closeCheckBox.TabIndex = 126;
            this.closeCheckBox.Visible = false;
            // 
            // TOPSpinEdit
            // 
            this.TOPSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.TOPSpinEdit.Location = new System.Drawing.Point(515, 70);
            this.TOPSpinEdit.Name = "TOPSpinEdit";
            this.TOPSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.TOPSpinEdit.Properties.UseCtrlIncrement = false;
            this.TOPSpinEdit.Size = new System.Drawing.Size(100, 26);
            this.TOPSpinEdit.TabIndex = 127;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 129;
            this.label2.Text = "TOP";
            // 
            // porTableAdapter
            // 
            this.porTableAdapter.ClearBeforeFill = true;
            // 
            // pordBindingSource
            // 
            this.pordBindingSource.DataMember = "pord";
            this.pordBindingSource.DataSource = this.casDataSet;
            // 
            // pordTableAdapter
            // 
            this.pordTableAdapter.ClearBeforeFill = true;
            // 
            // personTextBoxEx
            // 
            this.personTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.porBindingSource, "rma", true));
            this.personTextBoxEx.ExAllowEmptyString = true;
            this.personTextBoxEx.ExAllowNonDBData = false;
            this.personTextBoxEx.ExAutoCheck = true;
            this.personTextBoxEx.ExAutoShowResult = false;
            this.personTextBoxEx.ExCondition = "";
            this.personTextBoxEx.ExDialogTitle = "";
            this.personTextBoxEx.ExFieldName = "usrp";
            this.personTextBoxEx.ExFilterFields = new string[0];
            this.personTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.personTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.personTextBoxEx.ExLabelContainer = null;
            this.personTextBoxEx.ExLabelField = "name";
            this.personTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.personTextBoxEx.ExLabelText = "nama";
            this.personTextBoxEx.ExLabelVisible = true;
            this.personTextBoxEx.ExSelectFields = new string[0];
            this.personTextBoxEx.ExShowDialog = true;
            this.personTextBoxEx.ExSimpleMode = true;
            this.personTextBoxEx.ExSqlInstance = null;
            this.personTextBoxEx.ExSqlQuery = "select * from usrp where aktif=1";
            this.personTextBoxEx.ExTableName = "usrp";
            this.personTextBoxEx.Location = new System.Drawing.Point(516, 160);
            this.personTextBoxEx.Name = "personTextBoxEx";
            this.personTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.personTextBoxEx.Size = new System.Drawing.Size(99, 26);
            this.personTextBoxEx.TabIndex = 132;
            // 
            // cbPPNGanti
            // 
            this.cbPPNGanti.Location = new System.Drawing.Point(597, 94);
            this.cbPPNGanti.Name = "cbPPNGanti";
            this.cbPPNGanti.Size = new System.Drawing.Size(22, 24);
            this.cbPPNGanti.TabIndex = 137;
            // 
            // cbPPNBebas
            // 
            this.cbPPNBebas.Location = new System.Drawing.Point(743, 92);
            this.cbPPNBebas.Name = "cbPPNBebas";
            this.cbPPNBebas.Size = new System.Drawing.Size(22, 24);
            this.cbPPNBebas.TabIndex = 139;
            // 
            // FrmTPoj
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1109, 742);
            this.DetailBindingSource = this.pordBindingSource;
            this.DetailTable = this.casDataSet.pord;
            this.MasterBindingSource = this.porBindingSource;
            this.MasterTable = this.casDataSet.por;
            this.Name = "FrmTPoj";
            this.Text = "PO Jasa";
            this.Load += new System.EventHandler(this.FrmTPoj_Load);
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
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPPH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPPNP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubtotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPPN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDisc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpjTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpjdateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TOPSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personTextBoxEx.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CtrlSub ctrlSub;
        private casDataSet casDataSet;
        private KASLibrary.GridControlEx gcxRmd;
        private System.Windows.Forms.Panel pnlTotal;
        private DevExpress.XtraEditors.TextEdit txtSubtotal;
        private DevExpress.XtraEditors.TextEdit txtPPN;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private DevExpress.XtraEditors.TextEdit txtDisc;
        private DevExpress.XtraEditors.MemoEdit remarkMemoEdit;
        private System.Windows.Forms.CheckBox ppnCheckBox;
        private DevExpress.XtraEditors.SpinEdit discSpinEdit;
        private DevExpress.XtraEditors.TextEdit fpjTextEdit;
        private DevExpress.XtraEditors.DateEdit fpjdateDateEdit;
        private System.Windows.Forms.CheckBox aprovCheckBox;
        private System.Windows.Forms.CheckBox closeCheckBox;
        private DevExpress.XtraEditors.SpinEdit TOPSpinEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource porBindingSource;
        private CAS.casDataSetTableAdapters.porTableAdapter porTableAdapter;
        private System.Windows.Forms.BindingSource pordBindingSource;
        private CAS.casDataSetTableAdapters.pordTableAdapter pordTableAdapter;
        private KASLibrary.TextBoxEx personTextBoxEx;
        private System.Windows.Forms.CheckBox cbPPNGanti;
        private System.Windows.Forms.CheckBox cbPPNBebas;
        private DevExpress.XtraEditors.TextEdit txtPPH;
        private DevExpress.XtraEditors.TextEdit txtPPNP;
    }
}
