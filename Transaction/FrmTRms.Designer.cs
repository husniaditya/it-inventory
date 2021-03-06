namespace CAS.Transaction
{
    partial class FrmTRms
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
            System.Windows.Forms.Label discLabel;
            System.Windows.Forms.Label ppnLabel;
            System.Windows.Forms.Label remarkLabel;
            System.Windows.Forms.Label fpjLabel;
            System.Windows.Forms.Label fpjdateLabel;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label approveLabel;
            System.Windows.Forms.Label closeLabel;
            this.TOPSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.gcxRmd = new KASLibrary.GridControlEx();
            this.rmdTableAdapter = new CAS.casDataSetTableAdapters.rmdTableAdapter();
            this.rmdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casDataSet = new CAS.casDataSet();
            this.rmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rmsTableAdapter = new CAS.casDataSetTableAdapters.rmsTableAdapter();
            this.rmaTextBoxEx = new KASLibrary.TextBoxEx();
            this.remarkMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.fpjTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.fpjdateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ppnCheckBox = new System.Windows.Forms.CheckBox();
            this.discSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.ctrlSub = new CAS.Transaction.CtrlSub();
            this.txtDisc = new DevExpress.XtraEditors.TextEdit();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.txtPPN = new DevExpress.XtraEditors.TextEdit();
            this.txtSubtotal = new DevExpress.XtraEditors.TextEdit();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.aprovCheckBox = new System.Windows.Forms.CheckBox();
            this.linkToForm1 = new CAS.linkToForm();
            this.closeCheckBox = new System.Windows.Forms.CheckBox();
            duedateLabel = new System.Windows.Forms.Label();
            discLabel = new System.Windows.Forms.Label();
            ppnLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            fpjLabel = new System.Windows.Forms.Label();
            fpjdateLabel = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            approveLabel = new System.Windows.Forms.Label();
            closeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludSeri.Properties)).BeginInit();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curkurs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curcur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TOPSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rmdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rmsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rmaTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpjTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpjdateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDisc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPPN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubtotal.Properties)).BeginInit();
            this.pnlTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNo
            // 
            this.txtNo.Size = new System.Drawing.Size(85, 26);
            this.txtNo.EditValueChanged += new System.EventHandler(this.txtNo_EditValueChanged);
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
            this.pnlDetail.Controls.Add(closeLabel);
            this.pnlDetail.Controls.Add(this.closeCheckBox);
            this.pnlDetail.Controls.Add(this.linkToForm1);
            this.pnlDetail.Controls.Add(label10);
            this.pnlDetail.Controls.Add(approveLabel);
            this.pnlDetail.Controls.Add(this.aprovCheckBox);
            this.pnlDetail.Controls.Add(this.txtDisc);
            this.pnlDetail.Controls.Add(this.pnlTotal);
            this.pnlDetail.Controls.Add(this.ctrlSub);
            this.pnlDetail.Controls.Add(this.discSpinEdit);
            this.pnlDetail.Controls.Add(this.ppnCheckBox);
            this.pnlDetail.Controls.Add(fpjdateLabel);
            this.pnlDetail.Controls.Add(this.fpjdateDateEdit);
            this.pnlDetail.Controls.Add(fpjLabel);
            this.pnlDetail.Controls.Add(this.fpjTextEdit);
            this.pnlDetail.Controls.Add(remarkLabel);
            this.pnlDetail.Controls.Add(this.remarkMemoEdit);
            this.pnlDetail.Controls.Add(this.rmaTextBoxEx);
            this.pnlDetail.Controls.Add(this.gcxRmd);
            this.pnlDetail.Controls.Add(ppnLabel);
            this.pnlDetail.Controls.Add(this.TOPSpinEdit);
            this.pnlDetail.Controls.Add(discLabel);
            this.pnlDetail.Controls.Add(duedateLabel);
            this.pnlDetail.Location = new System.Drawing.Point(0, 88);
            this.pnlDetail.Size = new System.Drawing.Size(796, 518);
            this.pnlDetail.Controls.SetChildIndex(duedateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(discLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.TOPSpinEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(ppnLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curcur, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curkurs, 0);
            this.pnlDetail.Controls.SetChildIndex(this.kursLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curLabel1, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateDate, 0);
            this.pnlDetail.Controls.SetChildIndex(this.gcxRmd, 0);
            this.pnlDetail.Controls.SetChildIndex(this.rmaTextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(this.remarkMemoEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(remarkLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.fpjTextEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(fpjLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.fpjdateDateEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(fpjdateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.ppnCheckBox, 0);
            this.pnlDetail.Controls.SetChildIndex(this.discSpinEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(this.ctrlSub, 0);
            this.pnlDetail.Controls.SetChildIndex(this.pnlTotal, 0);
            this.pnlDetail.Controls.SetChildIndex(this.txtDisc, 0);
            this.pnlDetail.Controls.SetChildIndex(this.aprovCheckBox, 0);
            this.pnlDetail.Controls.SetChildIndex(approveLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(label10, 0);
            this.pnlDetail.Controls.SetChildIndex(this.linkToForm1, 0);
            this.pnlDetail.Controls.SetChildIndex(this.closeCheckBox, 0);
            this.pnlDetail.Controls.SetChildIndex(closeLabel, 0);
            // 
            // pnlKey
            // 
            this.pnlKey.Size = new System.Drawing.Size(796, 56);
            // 
            // dateDate
            // 
            this.dateDate.EditValue = new System.DateTime(((long)(0)));
            this.dateDate.Location = new System.Drawing.Point(498, 8);
            this.dateDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.dateDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateDate.Properties.EditFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.dateDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateDate.Properties.Mask.EditMask = "dd/MM/yyyy HH:mm:ss";
            this.dateDate.Properties.Mask.IgnoreMaskBlank = false;
            this.dateDate.Size = new System.Drawing.Size(131, 26);
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(446, 11);
            // 
            // curkurs
            // 
            this.curkurs.Location = new System.Drawing.Point(597, 32);
            // 
            // curcur
            // 
            this.curcur.Location = new System.Drawing.Point(498, 32);
            this.curcur.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.curcur.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.curcur.Properties.Appearance.Options.UseBackColor = true;
            this.curcur.Properties.Appearance.Options.UseForeColor = true;
            this.curcur.Size = new System.Drawing.Size(57, 26);
            // 
            // curLabel1
            // 
            this.curLabel1.Location = new System.Drawing.Point(467, 35);
            // 
            // kursLabel
            // 
            this.kursLabel.Location = new System.Drawing.Point(561, 35);
            // 
            // btnDocFlow
            // 
            this.btnDocFlow.Visible = true;
            // 
            // duedateLabel
            // 
            duedateLabel.AutoSize = true;
            duedateLabel.Location = new System.Drawing.Point(464, 60);
            duedateLabel.Name = "duedateLabel";
            duedateLabel.Size = new System.Drawing.Size(40, 19);
            duedateLabel.TabIndex = 32;
            duedateLabel.Text = "TOP";
            // 
            // discLabel
            // 
            discLabel.AutoSize = true;
            discLabel.Location = new System.Drawing.Point(528, 84);
            discLabel.Name = "discLabel";
            discLabel.Size = new System.Drawing.Size(38, 19);
            discLabel.TabIndex = 38;
            discLabel.Text = "Disc";
            discLabel.Visible = false;
            // 
            // ppnLabel
            // 
            ppnLabel.AutoSize = true;
            ppnLabel.Location = new System.Drawing.Point(461, 86);
            ppnLabel.Name = "ppnLabel";
            ppnLabel.Size = new System.Drawing.Size(38, 19);
            ppnLabel.TabIndex = 89;
            ppnLabel.Text = "PPN";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(37, 162);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(88, 19);
            remarkLabel.TabIndex = 91;
            remarkLabel.Text = "Keterangan";
            // 
            // fpjLabel
            // 
            fpjLabel.AutoSize = true;
            fpjLabel.Location = new System.Drawing.Point(402, 116);
            fpjLabel.Name = "fpjLabel";
            fpjLabel.Size = new System.Drawing.Size(132, 19);
            fpjLabel.TabIndex = 92;
            fpjLabel.Text = "Atas Faktur Pajak";
            // 
            // fpjdateLabel
            // 
            fpjdateLabel.AutoSize = true;
            fpjdateLabel.Location = new System.Drawing.Point(430, 138);
            fpjdateLabel.Name = "fpjdateLabel";
            fpjdateLabel.Size = new System.Drawing.Size(88, 19);
            fpjdateLabel.TabIndex = 93;
            fpjdateLabel.Text = "Tanggal FP";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(303, 484);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(70, 19);
            label10.TabIndex = 115;
            label10.Text = "Discount";
            label10.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(13, 54);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(45, 19);
            label9.TabIndex = 113;
            label9.Text = "Total";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(13, 33);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(38, 19);
            label8.TabIndex = 112;
            label8.Text = "PPN";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(13, 10);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(77, 19);
            label6.TabIndex = 111;
            label6.Text = "Sub Total";
            // 
            // approveLabel
            // 
            approveLabel.AutoSize = true;
            approveLabel.Location = new System.Drawing.Point(443, 169);
            approveLabel.Name = "approveLabel";
            approveLabel.Size = new System.Drawing.Size(69, 19);
            approveLabel.TabIndex = 116;
            approveLabel.Text = "Approve";
            approveLabel.Visible = false;
            // 
            // closeLabel
            // 
            closeLabel.AutoSize = true;
            closeLabel.Location = new System.Drawing.Point(546, 169);
            closeLabel.Name = "closeLabel";
            closeLabel.Size = new System.Drawing.Size(47, 19);
            closeLabel.TabIndex = 118;
            closeLabel.Text = "Close";
            closeLabel.Visible = false;
            // 
            // TOPSpinEdit
            // 
            this.TOPSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.TOPSpinEdit.Location = new System.Drawing.Point(498, 57);
            this.TOPSpinEdit.Name = "TOPSpinEdit";
            this.TOPSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.TOPSpinEdit.Properties.UseCtrlIncrement = false;
            this.TOPSpinEdit.Size = new System.Drawing.Size(91, 26);
            this.TOPSpinEdit.TabIndex = 87;
            // 
            // gcxRmd
            // 
            this.gcxRmd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcxRmd.BestFitColumn = true;
            this.gcxRmd.ExAutoSize = false;
            this.gcxRmd.Location = new System.Drawing.Point(12, 222);
            this.gcxRmd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gcxRmd.Name = "gcxRmd";
            this.gcxRmd.Size = new System.Drawing.Size(772, 219);
            this.gcxRmd.TabIndex = 86;
            // 
            // rmdTableAdapter
            // 
            this.rmdTableAdapter.ClearBeforeFill = true;
            // 
            // rmdBindingSource
            // 
            this.rmdBindingSource.DataMember = "rmd";
            this.rmdBindingSource.DataSource = this.casDataSet;
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rmsBindingSource
            // 
            this.rmsBindingSource.DataMember = "rms";
            this.rmsBindingSource.DataSource = this.casDataSet;
            // 
            // rmsTableAdapter
            // 
            this.rmsTableAdapter.ClearBeforeFill = true;
            // 
            // rmaTextBoxEx
            // 
            this.rmaTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rmsBindingSource, "rma", true));
            this.rmaTextBoxEx.ExAllowEmptyString = true;
            this.rmaTextBoxEx.ExAllowNonDBData = false;
            this.rmaTextBoxEx.ExAutoCheck = false;
            this.rmaTextBoxEx.ExAutoShowResult = false;
            this.rmaTextBoxEx.ExCondition = "";
            this.rmaTextBoxEx.ExDialogTitle = "Pengembalian Barang";
            this.rmaTextBoxEx.ExFieldName = "PO Jasa";
            this.rmaTextBoxEx.ExFilterFields = new string[0];
            this.rmaTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.rmaTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.rmaTextBoxEx.ExLabelContainer = null;
            this.rmaTextBoxEx.ExLabelField = "";
            this.rmaTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.rmaTextBoxEx.ExLabelText = "";
            this.rmaTextBoxEx.ExLabelVisible = false;
            this.rmaTextBoxEx.ExSelectFields = new string[0];
            this.rmaTextBoxEx.ExShowDialog = true;
            this.rmaTextBoxEx.ExSimpleMode = true;
            this.rmaTextBoxEx.ExSqlInstance = null;
            this.rmaTextBoxEx.ExSqlQuery = "CALL sp_selectporforrms()";
            this.rmaTextBoxEx.ExTableName = "rma";
            this.rmaTextBoxEx.Location = new System.Drawing.Point(105, 8);
            this.rmaTextBoxEx.Name = "rmaTextBoxEx";
            this.rmaTextBoxEx.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.rmaTextBoxEx.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.rmaTextBoxEx.Properties.Appearance.Options.UseBackColor = true;
            this.rmaTextBoxEx.Properties.Appearance.Options.UseForeColor = true;
            this.rmaTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.rmaTextBoxEx.Size = new System.Drawing.Size(149, 26);
            this.rmaTextBoxEx.TabIndex = 90;
            this.rmaTextBoxEx.EditValueChanged += new System.EventHandler(this.rmaTextBoxEx_EditValueChanged);
            // 
            // remarkMemoEdit
            // 
            this.remarkMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rmsBindingSource, "remark", true));
            this.remarkMemoEdit.Location = new System.Drawing.Point(105, 160);
            this.remarkMemoEdit.Name = "remarkMemoEdit";
            this.remarkMemoEdit.Size = new System.Drawing.Size(260, 56);
            this.remarkMemoEdit.TabIndex = 92;
            // 
            // fpjTextEdit
            // 
            this.fpjTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rmsBindingSource, "fpj", true));
            this.fpjTextEdit.Location = new System.Drawing.Point(498, 109);
            this.fpjTextEdit.Name = "fpjTextEdit";
            this.fpjTextEdit.Size = new System.Drawing.Size(139, 26);
            this.fpjTextEdit.TabIndex = 93;
            // 
            // fpjdateDateEdit
            // 
            this.fpjdateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rmsBindingSource, "fpjdate", true));
            this.fpjdateDateEdit.EditValue = new System.DateTime(2008, 7, 5, 19, 53, 41, 0);
            this.fpjdateDateEdit.Location = new System.Drawing.Point(498, 135);
            this.fpjdateDateEdit.Name = "fpjdateDateEdit";
            this.fpjdateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fpjdateDateEdit.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.fpjdateDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.fpjdateDateEdit.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.fpjdateDateEdit.Size = new System.Drawing.Size(100, 26);
            this.fpjdateDateEdit.TabIndex = 94;
            // 
            // ppnCheckBox
            // 
            this.ppnCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.rmsBindingSource, "ppn", true));
            this.ppnCheckBox.Location = new System.Drawing.Point(498, 79);
            this.ppnCheckBox.Name = "ppnCheckBox";
            this.ppnCheckBox.Size = new System.Drawing.Size(26, 24);
            this.ppnCheckBox.TabIndex = 95;
            this.ppnCheckBox.CheckedChanged += new System.EventHandler(this.ppnCheckBox_CheckedChanged);
            // 
            // discSpinEdit
            // 
            this.discSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rmsBindingSource, "disc", true));
            this.discSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.discSpinEdit.Location = new System.Drawing.Point(562, 81);
            this.discSpinEdit.Name = "discSpinEdit";
            this.discSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.discSpinEdit.Properties.UseCtrlIncrement = false;
            this.discSpinEdit.Size = new System.Drawing.Size(67, 26);
            this.discSpinEdit.TabIndex = 96;
            this.discSpinEdit.Visible = false;
            this.discSpinEdit.EditValueChanged += new System.EventHandler(this.discSpinEdit_EditValueChanged);
            // 
            // ctrlSub
            // 
            this.ctrlSub.Location = new System.Drawing.Point(41, 32);
            this.ctrlSub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlSub.Name = "ctrlSub";
            this.ctrlSub.ReadOnly = true;
            this.ctrlSub.Size = new System.Drawing.Size(335, 115);
            this.ctrlSub.TabIndex = 97;
            this.ctrlSub.Type = CAS.Transaction.CtrlSub.SubType.Supplier;
            // 
            // txtDisc
            // 
            this.txtDisc.Enabled = false;
            this.txtDisc.Location = new System.Drawing.Point(369, 481);
            this.txtDisc.Name = "txtDisc";
            this.txtDisc.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDisc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtDisc.Size = new System.Drawing.Size(121, 26);
            this.txtDisc.TabIndex = 114;
            this.txtDisc.Visible = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(79, 51);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotal.Size = new System.Drawing.Size(121, 26);
            this.txtTotal.TabIndex = 110;
            // 
            // txtPPN
            // 
            this.txtPPN.Location = new System.Drawing.Point(79, 30);
            this.txtPPN.Name = "txtPPN";
            this.txtPPN.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPPN.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtPPN.Size = new System.Drawing.Size(121, 26);
            this.txtPPN.TabIndex = 109;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(79, 8);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSubtotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSubtotal.Size = new System.Drawing.Size(121, 26);
            this.txtSubtotal.TabIndex = 108;
            // 
            // pnlTotal
            // 
            this.pnlTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTotal.Controls.Add(label6);
            this.pnlTotal.Controls.Add(this.txtSubtotal);
            this.pnlTotal.Controls.Add(this.txtPPN);
            this.pnlTotal.Controls.Add(label9);
            this.pnlTotal.Controls.Add(this.txtTotal);
            this.pnlTotal.Controls.Add(label8);
            this.pnlTotal.Location = new System.Drawing.Point(571, 439);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(213, 79);
            this.pnlTotal.TabIndex = 116;
            // 
            // aprovCheckBox
            // 
            this.aprovCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.rmsBindingSource, "aprov", true));
            this.aprovCheckBox.Location = new System.Drawing.Point(498, 164);
            this.aprovCheckBox.Name = "aprovCheckBox";
            this.aprovCheckBox.Size = new System.Drawing.Size(26, 24);
            this.aprovCheckBox.TabIndex = 117;
            this.aprovCheckBox.Visible = false;
            // 
            // linkToForm1
            // 
            this.linkToForm1.AutoSize = true;
            this.linkToForm1.FormName = "FrmTSJRetur";
            this.linkToForm1.Location = new System.Drawing.Point(9, 11);
            this.linkToForm1.Name = "linkToForm1";
            this.linkToForm1.Size = new System.Drawing.Size(119, 19);
            this.linkToForm1.TabIndex = 118;
            this.linkToForm1.TabStop = true;
            this.linkToForm1.Text = "PO Jasa / Retur";
            this.linkToForm1.TxtKode = this.rmaTextBoxEx;
            // 
            // closeCheckBox
            // 
            this.closeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.rmsBindingSource, "close", true));
            this.closeCheckBox.Location = new System.Drawing.Point(587, 164);
            this.closeCheckBox.Name = "closeCheckBox";
            this.closeCheckBox.Size = new System.Drawing.Size(28, 24);
            this.closeCheckBox.TabIndex = 119;
            this.closeCheckBox.Visible = false;
            // 
            // FrmTRms
            // 
            this.ClientSize = new System.Drawing.Size(796, 669);
            this.DetailBindingSource = this.rmdBindingSource;
            this.DetailTable = this.casDataSet.rmd;
            this.MasterBindingSource = this.rmsBindingSource;
            this.MasterTable = this.casDataSet.rms;
            this.Name = "FrmTRms";
            this.Text = "PO Retur";
            this.Load += new System.EventHandler(this.FrmTRms_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.TOPSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rmdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rmsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rmaTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpjTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpjdateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDisc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPPN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubtotal.Properties)).EndInit();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SpinEdit TOPSpinEdit;
        private KASLibrary.GridControlEx gcxRmd;
        private CAS.casDataSetTableAdapters.rmdTableAdapter rmdTableAdapter;
        private System.Windows.Forms.BindingSource rmdBindingSource;
        private System.Windows.Forms.BindingSource rmsBindingSource;
        private CAS.casDataSetTableAdapters.rmsTableAdapter rmsTableAdapter;
        private DevExpress.XtraEditors.DateEdit fpjdateDateEdit;
        private DevExpress.XtraEditors.TextEdit fpjTextEdit;
        private DevExpress.XtraEditors.MemoEdit remarkMemoEdit;
        private KASLibrary.TextBoxEx rmaTextBoxEx;
        private DevExpress.XtraEditors.SpinEdit discSpinEdit;
        private System.Windows.Forms.CheckBox ppnCheckBox;
        private casDataSet casDataSet;
        private CtrlSub ctrlSub;
        private DevExpress.XtraEditors.TextEdit txtDisc;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private DevExpress.XtraEditors.TextEdit txtPPN;
        private DevExpress.XtraEditors.TextEdit txtSubtotal;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.CheckBox aprovCheckBox;
        private linkToForm linkToForm1;
        private System.Windows.Forms.CheckBox closeCheckBox;
    }
}
