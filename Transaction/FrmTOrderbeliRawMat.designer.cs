namespace CAS.Transaction
{
    partial class FrmTOrderbeliRM
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
            System.Windows.Forms.Label duedateLabel;
            System.Windows.Forms.Label ppnLabel;
            System.Windows.Forms.Label discLabel;
            System.Windows.Forms.Label aprovLabel1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label ppnLabel1;
            System.Windows.Forms.Label closedLabel;
            System.Windows.Forms.Label jenispoLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label personLabel;
            System.Windows.Forms.Label locLabel;
            this.casDataSet = new CAS.casDataSet();
            this.omsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.duedateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.spinDisc = new DevExpress.XtraEditors.SpinEdit();
            this.omdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remarkMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.txtDisc = new DevExpress.XtraEditors.TextEdit();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.txtPPN = new DevExpress.XtraEditors.TextEdit();
            this.txtSubtotal = new DevExpress.XtraEditors.TextEdit();
            this.spinTOP = new DevExpress.XtraEditors.SpinEdit();
            this.cbPPN = new System.Windows.Forms.CheckBox();
            this.closedCheckBox = new System.Windows.Forms.CheckBox();
            this.jenispoRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.ctrlSub = new CAS.Transaction.CtrlSub();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.gcOmd = new KASLibrary.GridControlEx();
            this.no_kon = new KASLibrary.TextBoxEx();
            this.aprovCheckBox = new System.Windows.Forms.CheckBox();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.personTextBoxEx = new KASLibrary.TextBoxEx();
            this.omsTableAdapter = new CAS.casDataSetTableAdapters.omsTableAdapter();
            this.locTextEdit = new DevExpress.XtraEditors.TextEdit();
            duedateLabel = new System.Windows.Forms.Label();
            ppnLabel = new System.Windows.Forms.Label();
            discLabel = new System.Windows.Forms.Label();
            aprovLabel1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            ppnLabel1 = new System.Windows.Forms.Label();
            closedLabel = new System.Windows.Forms.Label();
            jenispoLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            personLabel = new System.Windows.Forms.Label();
            locLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludSeri.Properties)).BeginInit();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curkurs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curcur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.omsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duedateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDisc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.omdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDisc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPPN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubtotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTOP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenispoRadioGroup.Properties)).BeginInit();
            this.pnlTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.no_kon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locTextEdit.Properties)).BeginInit();
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
            this.pnlDetail.Controls.Add(locLabel);
            this.pnlDetail.Controls.Add(this.locTextEdit);
            this.pnlDetail.Controls.Add(this.remarkMemoEdit);
            this.pnlDetail.Controls.Add(personLabel);
            this.pnlDetail.Controls.Add(this.personTextBoxEx);
            this.pnlDetail.Controls.Add(this.memoEdit1);
            this.pnlDetail.Controls.Add(label4);
            this.pnlDetail.Controls.Add(this.aprovCheckBox);
            this.pnlDetail.Controls.Add(label3);
            this.pnlDetail.Controls.Add(this.ctrlSub);
            this.pnlDetail.Controls.Add(jenispoLabel);
            this.pnlDetail.Controls.Add(this.jenispoRadioGroup);
            this.pnlDetail.Controls.Add(ppnLabel1);
            this.pnlDetail.Controls.Add(this.cbPPN);
            this.pnlDetail.Controls.Add(label7);
            this.pnlDetail.Controls.Add(this.no_kon);
            this.pnlDetail.Controls.Add(this.spinTOP);
            this.pnlDetail.Controls.Add(aprovLabel1);
            this.pnlDetail.Controls.Add(discLabel);
            this.pnlDetail.Controls.Add(this.spinDisc);
            this.pnlDetail.Controls.Add(ppnLabel);
            this.pnlDetail.Controls.Add(duedateLabel);
            this.pnlDetail.Controls.Add(label2);
            this.pnlDetail.Controls.Add(this.duedateDateEdit);
            this.pnlDetail.Controls.Add(this.gcOmd);
            this.pnlDetail.Controls.Add(this.pnlTotal);
            this.pnlDetail.Location = new System.Drawing.Point(0, 72);
            this.pnlDetail.Size = new System.Drawing.Size(811, 615);
            this.pnlDetail.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDetail_Paint);
            this.pnlDetail.Controls.SetChildIndex(this.pnlTotal, 0);
            this.pnlDetail.Controls.SetChildIndex(this.gcOmd, 0);
            this.pnlDetail.Controls.SetChildIndex(this.duedateDateEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(label2, 0);
            this.pnlDetail.Controls.SetChildIndex(duedateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(ppnLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.spinDisc, 0);
            this.pnlDetail.Controls.SetChildIndex(discLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(aprovLabel1, 0);
            this.pnlDetail.Controls.SetChildIndex(this.spinTOP, 0);
            this.pnlDetail.Controls.SetChildIndex(this.no_kon, 0);
            this.pnlDetail.Controls.SetChildIndex(label7, 0);
            this.pnlDetail.Controls.SetChildIndex(this.cbPPN, 0);
            this.pnlDetail.Controls.SetChildIndex(ppnLabel1, 0);
            this.pnlDetail.Controls.SetChildIndex(this.jenispoRadioGroup, 0);
            this.pnlDetail.Controls.SetChildIndex(jenispoLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.ctrlSub, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curcur, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curkurs, 0);
            this.pnlDetail.Controls.SetChildIndex(this.kursLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curLabel1, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateDate, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(label3, 0);
            this.pnlDetail.Controls.SetChildIndex(this.aprovCheckBox, 0);
            this.pnlDetail.Controls.SetChildIndex(label4, 0);
            this.pnlDetail.Controls.SetChildIndex(this.memoEdit1, 0);
            this.pnlDetail.Controls.SetChildIndex(this.personTextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(personLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.remarkMemoEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(this.locTextEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(locLabel, 0);
            // 
            // pnlKey
            // 
            this.pnlKey.Controls.Add(this.closedCheckBox);
            this.pnlKey.Controls.Add(closedLabel);
            this.pnlKey.Size = new System.Drawing.Size(811, 47);
            this.pnlKey.Controls.SetChildIndex(closedLabel, 0);
            this.pnlKey.Controls.SetChildIndex(this.closedCheckBox, 0);
            this.pnlKey.Controls.SetChildIndex(this.label1, 0);
            this.pnlKey.Controls.SetChildIndex(this.ludSeri, 0);
            this.pnlKey.Controls.SetChildIndex(this.txtNo, 0);
            this.pnlKey.Controls.SetChildIndex(this.txtPeriod, 0);
            this.pnlKey.Controls.SetChildIndex(this.btnDocFlow, 0);
            this.pnlKey.Controls.SetChildIndex(this.lblDeleted, 0);
            // 
            // dateDate
            // 
            this.dateDate.EditValue = new System.DateTime(((long)(0)));
            this.dateDate.Location = new System.Drawing.Point(486, 6);
            this.dateDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateDate.Properties.Mask.IgnoreMaskBlank = false;
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(436, 9);
            // 
            // curkurs
            // 
            this.curkurs.Location = new System.Drawing.Point(584, 31);
            // 
            // curcur
            // 
            this.curcur.Location = new System.Drawing.Point(487, 31);
            this.curcur.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.curcur.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.curcur.Properties.Appearance.Options.UseBackColor = true;
            this.curcur.Properties.Appearance.Options.UseForeColor = true;
            // 
            // curLabel1
            // 
            this.curLabel1.Location = new System.Drawing.Point(459, 34);
            // 
            // kursLabel
            // 
            this.kursLabel.Location = new System.Drawing.Point(550, 34);
            // 
            // btnDocFlow
            // 
            this.btnDocFlow.Location = new System.Drawing.Point(658, 18);
            this.btnDocFlow.Visible = true;
            this.btnDocFlow.Click += new System.EventHandler(this.btnDocFlow_Click);
            // 
            // duedateLabel
            // 
            duedateLabel.AutoSize = true;
            duedateLabel.Location = new System.Drawing.Point(453, 59);
            duedateLabel.Name = "duedateLabel";
            duedateLabel.Size = new System.Drawing.Size(27, 13);
            duedateLabel.TabIndex = 9;
            duedateLabel.Text = "TOP";
            // 
            // ppnLabel
            // 
            ppnLabel.AutoSize = true;
            ppnLabel.Location = new System.Drawing.Point(-110, 120);
            ppnLabel.Name = "ppnLabel";
            ppnLabel.Size = new System.Drawing.Size(29, 13);
            ppnLabel.TabIndex = 11;
            ppnLabel.Text = "ppn:";
            // 
            // discLabel
            // 
            discLabel.AutoSize = true;
            discLabel.Location = new System.Drawing.Point(523, 84);
            discLabel.Name = "discLabel";
            discLabel.Size = new System.Drawing.Size(26, 13);
            discLabel.TabIndex = 12;
            discLabel.Text = "Disc";
            discLabel.Visible = false;
            // 
            // aprovLabel1
            // 
            aprovLabel1.AutoSize = true;
            aprovLabel1.Location = new System.Drawing.Point(435, 111);
            aprovLabel1.Name = "aprovLabel1";
            aprovLabel1.Size = new System.Drawing.Size(48, 13);
            aprovLabel1.TabIndex = 18;
            aprovLabel1.Text = "Approve";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(17, 127);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(79, 13);
            label2.TabIndex = 44;
            label2.Text = "Keterangan PR";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(10, 30);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(48, 13);
            label10.TabIndex = 107;
            label10.Text = "Discount";
            label10.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(10, 51);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(31, 13);
            label9.TabIndex = 105;
            label9.Text = "Total";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(10, 30);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(26, 13);
            label8.TabIndex = 104;
            label8.Text = "PPN";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(10, 8);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(52, 13);
            label6.TabIndex = 102;
            label6.Text = "Sub Total";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(547, 59);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(31, 13);
            label7.TabIndex = 110;
            label7.Text = "Days";
            // 
            // ppnLabel1
            // 
            ppnLabel1.AutoSize = true;
            ppnLabel1.Location = new System.Drawing.Point(453, 84);
            ppnLabel1.Name = "ppnLabel1";
            ppnLabel1.Size = new System.Drawing.Size(26, 13);
            ppnLabel1.TabIndex = 110;
            ppnLabel1.Text = "PPN";
            // 
            // closedLabel
            // 
            closedLabel.AutoSize = true;
            closedLabel.Location = new System.Drawing.Point(451, 18);
            closedLabel.Name = "closedLabel";
            closedLabel.Size = new System.Drawing.Size(33, 13);
            closedLabel.TabIndex = 111;
            closedLabel.Text = "Close";
            // 
            // jenispoLabel
            // 
            jenispoLabel.AutoSize = true;
            jenispoLabel.Location = new System.Drawing.Point(433, 139);
            jenispoLabel.Name = "jenispoLabel";
            jenispoLabel.Size = new System.Drawing.Size(48, 13);
            jenispoLabel.TabIndex = 112;
            jenispoLabel.Text = "Jenis PO";
            jenispoLabel.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(30, 127);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(60, 13);
            label3.TabIndex = 117;
            label3.Text = "No Kontrak";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(11, 192);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(80, 13);
            label4.TabIndex = 119;
            label4.Text = "Keterangan PO";
            // 
            // personLabel
            // 
            personLabel.AutoSize = true;
            personLabel.Location = new System.Drawing.Point(423, 218);
            personLabel.Name = "personLabel";
            personLabel.Size = new System.Drawing.Size(55, 13);
            personLabel.TabIndex = 122;
            personLabel.Text = "Purchaser";
            // 
            // locLabel
            // 
            locLabel.AutoSize = true;
            locLabel.Location = new System.Drawing.Point(387, 192);
            locLabel.Name = "locLabel";
            locLabel.Size = new System.Drawing.Size(91, 13);
            locLabel.TabIndex = 125;
            locLabel.Text = "Lokasi Pengiriman";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // omsBindingSource
            // 
            this.omsBindingSource.DataMember = "oms";
            this.omsBindingSource.DataSource = this.casDataSet;
            this.omsBindingSource.Filter = "group_=2";
            // 
            // duedateDateEdit
            // 
            this.duedateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.omsBindingSource, "duedate", true));
            this.duedateDateEdit.EditValue = null;
            this.duedateDateEdit.Location = new System.Drawing.Point(615, 7);
            this.duedateDateEdit.Name = "duedateDateEdit";
            this.duedateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.duedateDateEdit.Size = new System.Drawing.Size(100, 23);
            this.duedateDateEdit.TabIndex = 10;
            this.duedateDateEdit.Visible = false;
            // 
            // spinDisc
            // 
            this.spinDisc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.omsBindingSource, "disc", true));
            this.spinDisc.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinDisc.Location = new System.Drawing.Point(557, 81);
            this.spinDisc.Name = "spinDisc";
            this.spinDisc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinDisc.Properties.UseCtrlIncrement = false;
            this.spinDisc.Size = new System.Drawing.Size(100, 20);
            this.spinDisc.TabIndex = 13;
            this.spinDisc.Visible = false;
            this.spinDisc.EditValueChanged += new System.EventHandler(this.spinDisc_EditValueChanged);
            // 
            // omdBindingSource
            // 
            this.omdBindingSource.DataMember = "omd";
            this.omdBindingSource.DataSource = this.casDataSet;
            // 
            // remarkMemoEdit
            // 
            this.remarkMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.omsBindingSource, "remark", true));
            this.remarkMemoEdit.Enabled = false;
            this.remarkMemoEdit.Location = new System.Drawing.Point(95, 124);
            this.remarkMemoEdit.Name = "remarkMemoEdit";
            this.remarkMemoEdit.Properties.ReadOnly = true;
            this.remarkMemoEdit.Size = new System.Drawing.Size(283, 59);
            this.remarkMemoEdit.TabIndex = 46;
            // 
            // txtDisc
            // 
            this.txtDisc.Enabled = false;
            this.txtDisc.Location = new System.Drawing.Point(76, 27);
            this.txtDisc.Name = "txtDisc";
            this.txtDisc.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDisc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtDisc.Size = new System.Drawing.Size(121, 20);
            this.txtDisc.TabIndex = 106;
            this.txtDisc.Visible = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(76, 48);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtTotal.Properties.Appearance.Options.UseFont = true;
            this.txtTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotal.Size = new System.Drawing.Size(121, 20);
            this.txtTotal.TabIndex = 101;
            // 
            // txtPPN
            // 
            this.txtPPN.Location = new System.Drawing.Point(76, 27);
            this.txtPPN.Name = "txtPPN";
            this.txtPPN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtPPN.Properties.Appearance.Options.UseFont = true;
            this.txtPPN.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPPN.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtPPN.Size = new System.Drawing.Size(121, 20);
            this.txtPPN.TabIndex = 100;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(76, 6);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtSubtotal.Properties.Appearance.Options.UseFont = true;
            this.txtSubtotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSubtotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSubtotal.Size = new System.Drawing.Size(121, 20);
            this.txtSubtotal.TabIndex = 98;
            // 
            // spinTOP
            // 
            this.spinTOP.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinTOP.Location = new System.Drawing.Point(487, 57);
            this.spinTOP.Name = "spinTOP";
            this.spinTOP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinTOP.Properties.UseCtrlIncrement = false;
            this.spinTOP.Size = new System.Drawing.Size(56, 20);
            this.spinTOP.TabIndex = 109;
            // 
            // cbPPN
            // 
            this.cbPPN.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.omsBindingSource, "ppn", true));
            this.cbPPN.Location = new System.Drawing.Point(487, 79);
            this.cbPPN.Name = "cbPPN";
            this.cbPPN.Size = new System.Drawing.Size(22, 24);
            this.cbPPN.TabIndex = 111;
            this.cbPPN.CheckedChanged += new System.EventHandler(this.cbPPN_CheckedChanged);
            // 
            // closedCheckBox
            // 
            this.closedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.omsBindingSource, "close", true));
            this.closedCheckBox.Location = new System.Drawing.Point(489, 13);
            this.closedCheckBox.Name = "closedCheckBox";
            this.closedCheckBox.Size = new System.Drawing.Size(21, 24);
            this.closedCheckBox.TabIndex = 112;
            // 
            // jenispoRadioGroup
            // 
            this.jenispoRadioGroup.Location = new System.Drawing.Point(487, 136);
            this.jenispoRadioGroup.Name = "jenispoRadioGroup";
            this.jenispoRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "PO. SparePart"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "PO. IT (Computer)")});
            this.jenispoRadioGroup.Size = new System.Drawing.Size(192, 45);
            this.jenispoRadioGroup.TabIndex = 113;
            this.jenispoRadioGroup.Visible = false;
            this.jenispoRadioGroup.SelectedIndexChanged += new System.EventHandler(this.jenispoRadioGroup_SelectedIndexChanged);
            // 
            // ctrlSub
            // 
            this.ctrlSub.Location = new System.Drawing.Point(33, 6);
            this.ctrlSub.Name = "ctrlSub";
            this.ctrlSub.ReadOnly = true;
            this.ctrlSub.Size = new System.Drawing.Size(335, 115);
            this.ctrlSub.TabIndex = 114;
            this.ctrlSub.Type = CAS.Transaction.CtrlSub.SubType.Supplier;
            this.ctrlSub.Load += new System.EventHandler(this.ctrlSub_Load);
            // 
            // pnlTotal
            // 
            this.pnlTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTotal.CausesValidation = false;
            this.pnlTotal.Controls.Add(this.txtSubtotal);
            this.pnlTotal.Controls.Add(this.txtPPN);
            this.pnlTotal.Controls.Add(this.txtTotal);
            this.pnlTotal.Controls.Add(label6);
            this.pnlTotal.Controls.Add(label8);
            this.pnlTotal.Controls.Add(label9);
            this.pnlTotal.Controls.Add(this.txtDisc);
            this.pnlTotal.Controls.Add(label10);
            this.pnlTotal.Location = new System.Drawing.Point(590, 537);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(200, 75);
            this.pnlTotal.TabIndex = 115;
            // 
            // gcOmd
            // 
            this.gcOmd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcOmd.BestFitColumn = true;
            this.gcOmd.ExAutoSize = false;
            this.gcOmd.Location = new System.Drawing.Point(20, 261);
            this.gcOmd.Name = "gcOmd";
            this.gcOmd.Size = new System.Drawing.Size(788, 270);
            this.gcOmd.TabIndex = 18;
            // 
            // no_kon
            // 
            this.no_kon.ExAllowEmptyString = true;
            this.no_kon.ExAllowNonDBData = false;
            this.no_kon.ExAutoCheck = true;
            this.no_kon.ExAutoShowResult = false;
            this.no_kon.ExCondition = "";
            this.no_kon.ExDialogTitle = "";
            this.no_kon.ExFieldName = "vpo";
            this.no_kon.ExFilterFields = new string[0];
            this.no_kon.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.no_kon.ExInvalidForeColor = System.Drawing.Color.Black;
            this.no_kon.ExLabelContainer = null;
            this.no_kon.ExLabelField = "";
            this.no_kon.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.no_kon.ExLabelText = "";
            this.no_kon.ExLabelVisible = false;
            this.no_kon.ExSelectFields = new string[0];
            this.no_kon.ExShowDialog = true;
            this.no_kon.ExSimpleMode = true;
            this.no_kon.ExSqlInstance = null;
            this.no_kon.ExSqlQuery = "select * from vpo";
            this.no_kon.ExTableName = "vpo";
            this.no_kon.Location = new System.Drawing.Point(95, 124);
            this.no_kon.Name = "no_kon";
            this.no_kon.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.no_kon.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.no_kon.Properties.Appearance.Options.UseBackColor = true;
            this.no_kon.Properties.Appearance.Options.UseForeColor = true;
            this.no_kon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.no_kon.Size = new System.Drawing.Size(140, 20);
            this.no_kon.TabIndex = 116;
            this.no_kon.Visible = false;
            this.no_kon.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.no_kon_ButtonClick);
            this.no_kon.EditValueChanged += new System.EventHandler(this.no_kon_EditValueChanged);
            // 
            // aprovCheckBox
            // 
            this.aprovCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.omsBindingSource, "aprov", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.aprovCheckBox.Location = new System.Drawing.Point(487, 106);
            this.aprovCheckBox.Name = "aprovCheckBox";
            this.aprovCheckBox.Size = new System.Drawing.Size(23, 24);
            this.aprovCheckBox.TabIndex = 118;
            this.aprovCheckBox.CheckedChanged += new System.EventHandler(this.aprovCheckBox_CheckedChanged);
            // 
            // memoEdit1
            // 
            this.memoEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.omsBindingSource, "addnote", true));
            this.memoEdit1.Location = new System.Drawing.Point(95, 190);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(283, 58);
            this.memoEdit1.TabIndex = 120;
            // 
            // personTextBoxEx
            // 
            this.personTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.omsBindingSource, "person", true));
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
            this.personTextBoxEx.Location = new System.Drawing.Point(486, 215);
            this.personTextBoxEx.Name = "personTextBoxEx";
            this.personTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.personTextBoxEx.Size = new System.Drawing.Size(99, 20);
            this.personTextBoxEx.TabIndex = 123;
            // 
            // omsTableAdapter
            // 
            this.omsTableAdapter.ClearBeforeFill = true;
            // 
            // locTextEdit
            // 
            this.locTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.omsBindingSource, "loc", true));
            this.locTextEdit.Location = new System.Drawing.Point(487, 189);
            this.locTextEdit.Name = "locTextEdit";
            this.locTextEdit.Properties.MaxLength = 60;
            this.locTextEdit.Size = new System.Drawing.Size(304, 20);
            this.locTextEdit.TabIndex = 126;
            // 
            // FrmTOrderbeliRM
            // 
            this.ClientSize = new System.Drawing.Size(811, 742);
            this.DetailBindingSource = this.omdBindingSource;
            this.DetailTable = this.casDataSet.omd;
            this.MasterBindingSource = this.omsBindingSource;
            this.MasterTable = this.casDataSet.oms;
            this.Name = "FrmTOrderbeliRM";
            this.Text = "Purchase Order";
            this.Load += new System.EventHandler(this.FrmTOrderbeli_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.omsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duedateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDisc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.omdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDisc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPPN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubtotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTOP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenispoRadioGroup.Properties)).EndInit();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.no_kon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource omsBindingSource;
        private DevExpress.XtraEditors.SpinEdit spinDisc;
        private DevExpress.XtraEditors.DateEdit duedateDateEdit;
        private System.Windows.Forms.BindingSource omdBindingSource;
        private DevExpress.XtraEditors.MemoEdit remarkMemoEdit;
        private DevExpress.XtraEditors.TextEdit txtDisc;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private DevExpress.XtraEditors.TextEdit txtPPN;
        private DevExpress.XtraEditors.TextEdit txtSubtotal;
        private DevExpress.XtraEditors.SpinEdit spinTOP;
        private System.Windows.Forms.CheckBox closedCheckBox;
        private System.Windows.Forms.CheckBox cbPPN;
        private DevExpress.XtraEditors.RadioGroup jenispoRadioGroup;
        private CtrlSub ctrlSub;
        private System.Windows.Forms.Panel pnlTotal;
        private KASLibrary.GridControlEx gcOmd;
        private KASLibrary.TextBoxEx no_kon;
        private System.Windows.Forms.CheckBox aprovCheckBox;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private KASLibrary.TextBoxEx personTextBoxEx;
        private CAS.casDataSetTableAdapters.omsTableAdapter omsTableAdapter;
        private DevExpress.XtraEditors.TextEdit locTextEdit;
    }
}
