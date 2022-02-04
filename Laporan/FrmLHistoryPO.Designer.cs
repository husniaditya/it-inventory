namespace CAS.Laporan
{
    partial class FrmLHistoryPO
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
            System.Windows.Forms.Label personLabel;
            this.label2 = new System.Windows.Forms.Label();
            this.txtOmsAwal = new KASLibrary.TextBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOmsAkhir = new KASLibrary.TextBoxEx();
            this.txtSubAkhir = new KASLibrary.TextBoxEx();
            this.txtSubAwal = new KASLibrary.TextBoxEx();
            this.dtpTglAkhir = new DevExpress.XtraEditors.DateEdit();
            this.dtpTglAwal = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rgStatusPO = new DevExpress.XtraEditors.RadioGroup();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInvAkhir = new KASLibrary.TextBoxEx();
            this.txtInvAwal = new KASLibrary.TextBoxEx();
            this.personTextBoxEx = new KASLibrary.TextBoxEx();
            personLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOmsAwal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOmsAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubAwal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAwal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgStatusPO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvAwal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personTextBoxEx.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(636, 190);
            this.btnClose.LookAndFeel.SkinName = "";
            this.btnClose.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.LookAndFeel.UseWindowsXPTheme = false;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(555, 190);
            this.btnPreview.LookAndFeel.SkinName = "";
            this.btnPreview.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btnPreview.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnPreview.LookAndFeel.UseWindowsXPTheme = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // printControl
            // 
            this.printControl.Location = new System.Drawing.Point(0, 248);
            this.printControl.Size = new System.Drawing.Size(718, 272);
            // 
            // printPreviewBar
            // 
            this.printPreviewBar.Location = new System.Drawing.Point(0, 220);
            this.printPreviewBar.Size = new System.Drawing.Size(718, 28);
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(personLabel);
            this.pnlFilter.Controls.Add(this.personTextBoxEx);
            this.pnlFilter.Controls.Add(this.label5);
            this.pnlFilter.Controls.Add(this.label4);
            this.pnlFilter.Controls.Add(this.txtInvAkhir);
            this.pnlFilter.Controls.Add(this.txtInvAwal);
            this.pnlFilter.Controls.Add(this.rgStatusPO);
            this.pnlFilter.Controls.Add(this.dtpTglAkhir);
            this.pnlFilter.Controls.Add(this.dtpTglAwal);
            this.pnlFilter.Controls.Add(this.label3);
            this.pnlFilter.Controls.Add(this.txtSubAkhir);
            this.pnlFilter.Controls.Add(this.txtSubAwal);
            this.pnlFilter.Controls.Add(this.txtOmsAkhir);
            this.pnlFilter.Controls.Add(this.txtOmsAwal);
            this.pnlFilter.Controls.Add(this.label1);
            this.pnlFilter.Controls.Add(this.label2);
            this.pnlFilter.LookAndFeel.SkinName = "";
            this.pnlFilter.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.pnlFilter.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlFilter.LookAndFeel.UseWindowsXPTheme = false;
            this.pnlFilter.Size = new System.Drawing.Size(718, 220);
            this.pnlFilter.Controls.SetChildIndex(this.btnPreview, 0);
            this.pnlFilter.Controls.SetChildIndex(this.btnClose, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label2, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label1, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtOmsAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtOmsAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtSubAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtSubAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label3, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dtpTglAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dtpTglAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.rgStatusPO, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtInvAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtInvAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label4, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label5, 0);
            this.pnlFilter.Controls.SetChildIndex(this.personTextBoxEx, 0);
            this.pnlFilter.Controls.SetChildIndex(personLabel, 0);
            // 
            // personLabel
            // 
            personLabel.AutoSize = true;
            personLabel.Location = new System.Drawing.Point(329, 191);
            personLabel.Name = "personLabel";
            personLabel.Size = new System.Drawing.Size(75, 13);
            personLabel.TabIndex = 147;
            personLabel.Text = "User Pemesan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Supplier";
            // 
            // txtOmsAwal
            // 
            this.txtOmsAwal.ExAllowEmptyString = true;
            this.txtOmsAwal.ExAllowNonDBData = false;
            this.txtOmsAwal.ExAutoCheck = true;
            this.txtOmsAwal.ExAutoShowResult = false;
            this.txtOmsAwal.ExCondition = "";
            this.txtOmsAwal.ExDialogTitle = "Order Pembelian";
            this.txtOmsAwal.ExFieldName = "No PO";
            this.txtOmsAwal.ExFilterFields = new string[0];
            this.txtOmsAwal.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtOmsAwal.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtOmsAwal.ExLabelContainer = null;
            this.txtOmsAwal.ExLabelField = "";
            this.txtOmsAwal.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtOmsAwal.ExLabelText = "";
            this.txtOmsAwal.ExLabelVisible = false;
            this.txtOmsAwal.ExSelectFields = new string[0];
            this.txtOmsAwal.ExShowDialog = true;
            this.txtOmsAwal.ExSimpleMode = true;
            this.txtOmsAwal.ExSqlInstance = null;
            this.txtOmsAwal.ExSqlQuery = "select oms as `No PO`, `date` as Tanggal, remark as Keterangan from oms where `de" +
                "lete`=0";
            this.txtOmsAwal.ExTableName = "oms";
            this.txtOmsAwal.Location = new System.Drawing.Point(132, 98);
            this.txtOmsAwal.Name = "txtOmsAwal";
            this.txtOmsAwal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtOmsAwal.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtOmsAwal.Properties.Appearance.Options.UseBackColor = true;
            this.txtOmsAwal.Properties.Appearance.Options.UseForeColor = true;
            this.txtOmsAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtOmsAwal.Size = new System.Drawing.Size(114, 20);
            this.txtOmsAwal.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "No PO";
            // 
            // txtOmsAkhir
            // 
            this.txtOmsAkhir.ExAllowEmptyString = true;
            this.txtOmsAkhir.ExAllowNonDBData = false;
            this.txtOmsAkhir.ExAutoCheck = true;
            this.txtOmsAkhir.ExAutoShowResult = false;
            this.txtOmsAkhir.ExCondition = "";
            this.txtOmsAkhir.ExDialogTitle = "Order Pembelian";
            this.txtOmsAkhir.ExFieldName = "No PO";
            this.txtOmsAkhir.ExFilterFields = new string[0];
            this.txtOmsAkhir.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtOmsAkhir.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtOmsAkhir.ExLabelContainer = null;
            this.txtOmsAkhir.ExLabelField = "";
            this.txtOmsAkhir.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtOmsAkhir.ExLabelText = "";
            this.txtOmsAkhir.ExLabelVisible = false;
            this.txtOmsAkhir.ExSelectFields = new string[0];
            this.txtOmsAkhir.ExShowDialog = true;
            this.txtOmsAkhir.ExSimpleMode = true;
            this.txtOmsAkhir.ExSqlInstance = null;
            this.txtOmsAkhir.ExSqlQuery = "select oms as `No PO`, `date` as Tanggal, remark as Keterangan from oms where `de" +
                "lete`=0";
            this.txtOmsAkhir.ExTableName = "oms";
            this.txtOmsAkhir.Location = new System.Drawing.Point(321, 98);
            this.txtOmsAkhir.Name = "txtOmsAkhir";
            this.txtOmsAkhir.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtOmsAkhir.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtOmsAkhir.Properties.Appearance.Options.UseBackColor = true;
            this.txtOmsAkhir.Properties.Appearance.Options.UseForeColor = true;
            this.txtOmsAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtOmsAkhir.Size = new System.Drawing.Size(114, 20);
            this.txtOmsAkhir.TabIndex = 18;
            // 
            // txtSubAkhir
            // 
            this.txtSubAkhir.ExAllowEmptyString = true;
            this.txtSubAkhir.ExAllowNonDBData = false;
            this.txtSubAkhir.ExAutoCheck = true;
            this.txtSubAkhir.ExAutoShowResult = false;
            this.txtSubAkhir.ExCondition = "";
            this.txtSubAkhir.ExDialogTitle = "Supplier";
            this.txtSubAkhir.ExFieldName = "Kode";
            this.txtSubAkhir.ExFilterFields = new string[0];
            this.txtSubAkhir.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtSubAkhir.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtSubAkhir.ExLabelContainer = null;
            this.txtSubAkhir.ExLabelField = "Nama";
            this.txtSubAkhir.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtSubAkhir.ExLabelText = "";
            this.txtSubAkhir.ExLabelVisible = true;
            this.txtSubAkhir.ExSelectFields = new string[0];
            this.txtSubAkhir.ExShowDialog = true;
            this.txtSubAkhir.ExSimpleMode = true;
            this.txtSubAkhir.ExSqlInstance = null;
            this.txtSubAkhir.ExSqlQuery = "Call SP_LookUp(\'supplier\')";
            this.txtSubAkhir.ExTableName = "";
            this.txtSubAkhir.Location = new System.Drawing.Point(321, 54);
            this.txtSubAkhir.Name = "txtSubAkhir";
            this.txtSubAkhir.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtSubAkhir.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtSubAkhir.Properties.Appearance.Options.UseBackColor = true;
            this.txtSubAkhir.Properties.Appearance.Options.UseForeColor = true;
            this.txtSubAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtSubAkhir.Size = new System.Drawing.Size(114, 20);
            this.txtSubAkhir.TabIndex = 20;
            // 
            // txtSubAwal
            // 
            this.txtSubAwal.ExAllowEmptyString = true;
            this.txtSubAwal.ExAllowNonDBData = false;
            this.txtSubAwal.ExAutoCheck = true;
            this.txtSubAwal.ExAutoShowResult = false;
            this.txtSubAwal.ExCondition = "";
            this.txtSubAwal.ExDialogTitle = "Supplier";
            this.txtSubAwal.ExFieldName = "Kode";
            this.txtSubAwal.ExFilterFields = new string[0];
            this.txtSubAwal.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtSubAwal.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtSubAwal.ExLabelContainer = null;
            this.txtSubAwal.ExLabelField = "Nama";
            this.txtSubAwal.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtSubAwal.ExLabelText = "";
            this.txtSubAwal.ExLabelVisible = true;
            this.txtSubAwal.ExSelectFields = new string[0];
            this.txtSubAwal.ExShowDialog = true;
            this.txtSubAwal.ExSimpleMode = true;
            this.txtSubAwal.ExSqlInstance = null;
            this.txtSubAwal.ExSqlQuery = "Call SP_LookUp(\'supplier\')";
            this.txtSubAwal.ExTableName = "";
            this.txtSubAwal.Location = new System.Drawing.Point(132, 54);
            this.txtSubAwal.Name = "txtSubAwal";
            this.txtSubAwal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtSubAwal.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtSubAwal.Properties.Appearance.Options.UseBackColor = true;
            this.txtSubAwal.Properties.Appearance.Options.UseForeColor = true;
            this.txtSubAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtSubAwal.Size = new System.Drawing.Size(114, 20);
            this.txtSubAwal.TabIndex = 19;
            this.txtSubAwal.EditValueChanged += new System.EventHandler(this.txtSubAwal_EditValueChanged);
            // 
            // dtpTglAkhir
            // 
            this.dtpTglAkhir.EditValue = new System.DateTime(2008, 10, 11, 0, 0, 0, 0);
            this.dtpTglAkhir.Location = new System.Drawing.Point(321, 25);
            this.dtpTglAkhir.Name = "dtpTglAkhir";
            this.dtpTglAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTglAkhir.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAkhir.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAkhir.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAkhir.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAkhir.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtpTglAkhir.Size = new System.Drawing.Size(114, 20);
            this.dtpTglAkhir.TabIndex = 23;
            // 
            // dtpTglAwal
            // 
            this.dtpTglAwal.EditValue = new System.DateTime(2008, 10, 11, 0, 0, 0, 0);
            this.dtpTglAwal.Location = new System.Drawing.Point(132, 25);
            this.dtpTglAwal.Name = "dtpTglAwal";
            this.dtpTglAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTglAwal.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAwal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAwal.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAwal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAwal.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtpTglAwal.Size = new System.Drawing.Size(114, 20);
            this.dtpTglAwal.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tanggal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 117;
            this.label4.Text = "Status PO";
            // 
            // rgStatusPO
            // 
            this.rgStatusPO.EditValue = 3;
            this.rgStatusPO.Location = new System.Drawing.Point(132, 186);
            this.rgStatusPO.Name = "rgStatusPO";
            this.rgStatusPO.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Open"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Close"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "All")});
            this.rgStatusPO.Size = new System.Drawing.Size(173, 27);
            this.rgStatusPO.TabIndex = 116;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Kode Barang";
            // 
            // txtInvAkhir
            // 
            this.txtInvAkhir.ExAllowEmptyString = true;
            this.txtInvAkhir.ExAllowNonDBData = false;
            this.txtInvAkhir.ExAutoCheck = true;
            this.txtInvAkhir.ExAutoShowResult = false;
            this.txtInvAkhir.ExCondition = "";
            this.txtInvAkhir.ExDialogTitle = "Barang";
            this.txtInvAkhir.ExFieldName = "Kode Barang";
            this.txtInvAkhir.ExFilterFields = new string[0];
            this.txtInvAkhir.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtInvAkhir.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtInvAkhir.ExLabelContainer = null;
            this.txtInvAkhir.ExLabelField = "Nama Barang";
            this.txtInvAkhir.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtInvAkhir.ExLabelText = "";
            this.txtInvAkhir.ExLabelVisible = true;
            this.txtInvAkhir.ExSelectFields = new string[0];
            this.txtInvAkhir.ExShowDialog = true;
            this.txtInvAkhir.ExSimpleMode = true;
            this.txtInvAkhir.ExSqlInstance = null;
            this.txtInvAkhir.ExSqlQuery = "Call SP_LookUp(\'inv\')";
            this.txtInvAkhir.ExTableName = "";
            this.txtInvAkhir.Location = new System.Drawing.Point(321, 142);
            this.txtInvAkhir.Name = "txtInvAkhir";
            this.txtInvAkhir.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtInvAkhir.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtInvAkhir.Properties.Appearance.Options.UseBackColor = true;
            this.txtInvAkhir.Properties.Appearance.Options.UseForeColor = true;
            this.txtInvAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtInvAkhir.Size = new System.Drawing.Size(114, 20);
            this.txtInvAkhir.TabIndex = 32;
            // 
            // txtInvAwal
            // 
            this.txtInvAwal.ExAllowEmptyString = true;
            this.txtInvAwal.ExAllowNonDBData = false;
            this.txtInvAwal.ExAutoCheck = true;
            this.txtInvAwal.ExAutoShowResult = false;
            this.txtInvAwal.ExCondition = "";
            this.txtInvAwal.ExDialogTitle = "Barang";
            this.txtInvAwal.ExFieldName = "Kode Barang";
            this.txtInvAwal.ExFilterFields = new string[0];
            this.txtInvAwal.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtInvAwal.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtInvAwal.ExLabelContainer = null;
            this.txtInvAwal.ExLabelField = "Nama Barang";
            this.txtInvAwal.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtInvAwal.ExLabelText = "";
            this.txtInvAwal.ExLabelVisible = true;
            this.txtInvAwal.ExSelectFields = new string[0];
            this.txtInvAwal.ExShowDialog = true;
            this.txtInvAwal.ExSimpleMode = true;
            this.txtInvAwal.ExSqlInstance = null;
            this.txtInvAwal.ExSqlQuery = "Call SP_LookUp(\'inv\')";
            this.txtInvAwal.ExTableName = "";
            this.txtInvAwal.Location = new System.Drawing.Point(132, 142);
            this.txtInvAwal.Name = "txtInvAwal";
            this.txtInvAwal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtInvAwal.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtInvAwal.Properties.Appearance.Options.UseBackColor = true;
            this.txtInvAwal.Properties.Appearance.Options.UseForeColor = true;
            this.txtInvAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtInvAwal.Size = new System.Drawing.Size(114, 20);
            this.txtInvAwal.TabIndex = 33;
            // 
            // personTextBoxEx
            // 
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
            this.personTextBoxEx.Location = new System.Drawing.Point(410, 188);
            this.personTextBoxEx.Name = "personTextBoxEx";
            this.personTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.personTextBoxEx.Size = new System.Drawing.Size(99, 20);
            this.personTextBoxEx.TabIndex = 148;
            // 
            // FrmLHistoryPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(718, 542);
            this.LookAndFeel.SkinName = "";
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.UseWindowsXPTheme = false;
            this.Name = "FrmLHistoryPO";
            this.Load += new System.EventHandler(this.FrmLHistoryPO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOmsAwal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOmsAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubAwal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAwal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgStatusPO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvAwal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personTextBoxEx.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KASLibrary.TextBoxEx txtOmsAwal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private KASLibrary.TextBoxEx txtOmsAkhir;
        private KASLibrary.TextBoxEx txtSubAkhir;
        private KASLibrary.TextBoxEx txtSubAwal;
        private DevExpress.XtraEditors.DateEdit dtpTglAkhir;
        private DevExpress.XtraEditors.DateEdit dtpTglAwal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.RadioGroup rgStatusPO;
        private System.Windows.Forms.Label label5;
        private KASLibrary.TextBoxEx txtInvAkhir;
        private KASLibrary.TextBoxEx txtInvAwal;
        private KASLibrary.TextBoxEx personTextBoxEx;
    }
}
