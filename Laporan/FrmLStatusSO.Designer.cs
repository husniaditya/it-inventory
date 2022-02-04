namespace CAS.Laporan
{
    partial class FrmLStatusSO
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
            this.label4 = new System.Windows.Forms.Label();
            this.rgStatusSO = new DevExpress.XtraEditors.RadioGroup();
            this.txtInvAkhir = new KASLibrary.TextBoxEx();
            this.txtInvAwal = new KASLibrary.TextBoxEx();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubAkhir = new KASLibrary.TextBoxEx();
            this.txtSubAwal = new KASLibrary.TextBoxEx();
            this.dtpTglAkhir = new DevExpress.XtraEditors.DateEdit();
            this.dtpTglAwal = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDsgAkhir = new KASLibrary.TextBoxEx();
            this.txtDsgAwal = new KASLibrary.TextBoxEx();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSOAkhir = new KASLibrary.TextBoxEx();
            this.txtSOAwal = new KASLibrary.TextBoxEx();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgStatusSO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvAwal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubAwal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAwal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDsgAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDsgAwal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOAwal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(636, 269);
            this.btnClose.LookAndFeel.SkinName = "";
            this.btnClose.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.LookAndFeel.UseWindowsXPTheme = false;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(555, 269);
            this.btnPreview.LookAndFeel.SkinName = "";
            this.btnPreview.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btnPreview.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnPreview.LookAndFeel.UseWindowsXPTheme = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // printControl
            // 
            this.printControl.Location = new System.Drawing.Point(0, 327);
            this.printControl.Size = new System.Drawing.Size(718, 326);
            // 
            // printPreviewBar
            // 
            this.printPreviewBar.Location = new System.Drawing.Point(0, 299);
            this.printPreviewBar.Size = new System.Drawing.Size(718, 28);
            // 
            // printPreviewStatus
            // 
            this.printPreviewStatus.Location = new System.Drawing.Point(0, 653);
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.txtSOAkhir);
            this.pnlFilter.Controls.Add(this.txtSOAwal);
            this.pnlFilter.Controls.Add(this.label6);
            this.pnlFilter.Controls.Add(this.txtDsgAkhir);
            this.pnlFilter.Controls.Add(this.txtDsgAwal);
            this.pnlFilter.Controls.Add(this.label5);
            this.pnlFilter.Controls.Add(this.label4);
            this.pnlFilter.Controls.Add(this.rgStatusSO);
            this.pnlFilter.Controls.Add(this.txtInvAkhir);
            this.pnlFilter.Controls.Add(this.txtInvAwal);
            this.pnlFilter.Controls.Add(this.label3);
            this.pnlFilter.Controls.Add(this.txtSubAkhir);
            this.pnlFilter.Controls.Add(this.txtSubAwal);
            this.pnlFilter.Controls.Add(this.dtpTglAkhir);
            this.pnlFilter.Controls.Add(this.dtpTglAwal);
            this.pnlFilter.Controls.Add(this.label2);
            this.pnlFilter.Controls.Add(this.label1);
            this.pnlFilter.LookAndFeel.SkinName = "";
            this.pnlFilter.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.pnlFilter.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlFilter.LookAndFeel.UseWindowsXPTheme = false;
            this.pnlFilter.Size = new System.Drawing.Size(718, 299);
            this.pnlFilter.Controls.SetChildIndex(this.btnPreview, 0);
            this.pnlFilter.Controls.SetChildIndex(this.btnClose, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label1, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label2, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dtpTglAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dtpTglAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtSubAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtSubAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label3, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtInvAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtInvAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.rgStatusSO, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label4, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label5, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtDsgAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtDsgAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label6, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtSOAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtSOAkhir, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 126;
            this.label4.Text = "Status SO";
            // 
            // rgStatusSO
            // 
            this.rgStatusSO.Location = new System.Drawing.Point(148, 224);
            this.rgStatusSO.Name = "rgStatusSO";
            this.rgStatusSO.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Open"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Close"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "All")});
            this.rgStatusSO.Size = new System.Drawing.Size(173, 27);
            this.rgStatusSO.TabIndex = 125;
            // 
            // txtInvAkhir
            // 
            this.txtInvAkhir.ExAllowEmptyString = true;
            this.txtInvAkhir.ExAllowNonDBData = false;
            this.txtInvAkhir.ExAutoCheck = true;
            this.txtInvAkhir.ExAutoShowResult = false;
            this.txtInvAkhir.ExCondition = "";
            this.txtInvAkhir.ExDialogTitle = "Inventory";
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
            this.txtInvAkhir.Location = new System.Drawing.Point(337, 143);
            this.txtInvAkhir.Name = "txtInvAkhir";
            this.txtInvAkhir.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtInvAkhir.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtInvAkhir.Properties.Appearance.Options.UseBackColor = true;
            this.txtInvAkhir.Properties.Appearance.Options.UseForeColor = true;
            this.txtInvAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtInvAkhir.Size = new System.Drawing.Size(114, 20);
            this.txtInvAkhir.TabIndex = 124;
            // 
            // txtInvAwal
            // 
            this.txtInvAwal.ExAllowEmptyString = true;
            this.txtInvAwal.ExAllowNonDBData = false;
            this.txtInvAwal.ExAutoCheck = true;
            this.txtInvAwal.ExAutoShowResult = false;
            this.txtInvAwal.ExCondition = "";
            this.txtInvAwal.ExDialogTitle = "Inventory";
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
            this.txtInvAwal.Location = new System.Drawing.Point(148, 143);
            this.txtInvAwal.Name = "txtInvAwal";
            this.txtInvAwal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtInvAwal.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtInvAwal.Properties.Appearance.Options.UseBackColor = true;
            this.txtInvAwal.Properties.Appearance.Options.UseForeColor = true;
            this.txtInvAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtInvAwal.Size = new System.Drawing.Size(114, 20);
            this.txtInvAwal.TabIndex = 123;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 122;
            this.label3.Text = "Persediaan";
            // 
            // txtSubAkhir
            // 
            this.txtSubAkhir.ExAllowEmptyString = true;
            this.txtSubAkhir.ExAllowNonDBData = false;
            this.txtSubAkhir.ExAutoCheck = true;
            this.txtSubAkhir.ExAutoShowResult = false;
            this.txtSubAkhir.ExCondition = "";
            this.txtSubAkhir.ExDialogTitle = "Customer";
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
            this.txtSubAkhir.ExSqlQuery = "Call SP_LookUp(\'customer\')";
            this.txtSubAkhir.ExTableName = "";
            this.txtSubAkhir.Location = new System.Drawing.Point(337, 54);
            this.txtSubAkhir.Name = "txtSubAkhir";
            this.txtSubAkhir.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtSubAkhir.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtSubAkhir.Properties.Appearance.Options.UseBackColor = true;
            this.txtSubAkhir.Properties.Appearance.Options.UseForeColor = true;
            this.txtSubAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtSubAkhir.Size = new System.Drawing.Size(114, 20);
            this.txtSubAkhir.TabIndex = 121;
            // 
            // txtSubAwal
            // 
            this.txtSubAwal.ExAllowEmptyString = true;
            this.txtSubAwal.ExAllowNonDBData = false;
            this.txtSubAwal.ExAutoCheck = true;
            this.txtSubAwal.ExAutoShowResult = false;
            this.txtSubAwal.ExCondition = "";
            this.txtSubAwal.ExDialogTitle = "Customer";
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
            this.txtSubAwal.ExSqlQuery = "Call SP_LookUp(\'customer\')";
            this.txtSubAwal.ExTableName = "";
            this.txtSubAwal.Location = new System.Drawing.Point(148, 54);
            this.txtSubAwal.Name = "txtSubAwal";
            this.txtSubAwal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtSubAwal.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtSubAwal.Properties.Appearance.Options.UseBackColor = true;
            this.txtSubAwal.Properties.Appearance.Options.UseForeColor = true;
            this.txtSubAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtSubAwal.Size = new System.Drawing.Size(114, 20);
            this.txtSubAwal.TabIndex = 120;
            // 
            // dtpTglAkhir
            // 
            this.dtpTglAkhir.EditValue = new System.DateTime(2008, 8, 20, 15, 40, 28, 0);
            this.dtpTglAkhir.Location = new System.Drawing.Point(337, 24);
            this.dtpTglAkhir.Name = "dtpTglAkhir";
            this.dtpTglAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTglAkhir.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAkhir.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAkhir.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAkhir.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAkhir.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtpTglAkhir.Size = new System.Drawing.Size(114, 20);
            this.dtpTglAkhir.TabIndex = 119;
            // 
            // dtpTglAwal
            // 
            this.dtpTglAwal.EditValue = new System.DateTime(2008, 8, 20, 15, 40, 28, 0);
            this.dtpTglAwal.Location = new System.Drawing.Point(148, 24);
            this.dtpTglAwal.Name = "dtpTglAwal";
            this.dtpTglAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTglAwal.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAwal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAwal.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAwal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAwal.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtpTglAwal.Size = new System.Drawing.Size(114, 20);
            this.dtpTglAwal.TabIndex = 118;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 117;
            this.label2.Text = "Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 116;
            this.label1.Text = "Tanggal";
            // 
            // txtDsgAkhir
            // 
            this.txtDsgAkhir.ExAllowEmptyString = true;
            this.txtDsgAkhir.ExAllowNonDBData = false;
            this.txtDsgAkhir.ExAutoCheck = true;
            this.txtDsgAkhir.ExAutoShowResult = false;
            this.txtDsgAkhir.ExCondition = "";
            this.txtDsgAkhir.ExDialogTitle = "Inventory";
            this.txtDsgAkhir.ExFieldName = "No Design";
            this.txtDsgAkhir.ExFilterFields = new string[0];
            this.txtDsgAkhir.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtDsgAkhir.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtDsgAkhir.ExLabelContainer = null;
            this.txtDsgAkhir.ExLabelField = "Nama";
            this.txtDsgAkhir.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtDsgAkhir.ExLabelText = "";
            this.txtDsgAkhir.ExLabelVisible = true;
            this.txtDsgAkhir.ExSelectFields = new string[0];
            this.txtDsgAkhir.ExShowDialog = true;
            this.txtDsgAkhir.ExSimpleMode = true;
            this.txtDsgAkhir.ExSqlInstance = null;
            this.txtDsgAkhir.ExSqlQuery = "Call SP_LookUp(\'dsg\')";
            this.txtDsgAkhir.ExTableName = "";
            this.txtDsgAkhir.Location = new System.Drawing.Point(337, 97);
            this.txtDsgAkhir.Name = "txtDsgAkhir";
            this.txtDsgAkhir.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtDsgAkhir.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtDsgAkhir.Properties.Appearance.Options.UseBackColor = true;
            this.txtDsgAkhir.Properties.Appearance.Options.UseForeColor = true;
            this.txtDsgAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtDsgAkhir.Size = new System.Drawing.Size(114, 20);
            this.txtDsgAkhir.TabIndex = 129;
            // 
            // txtDsgAwal
            // 
            this.txtDsgAwal.ExAllowEmptyString = true;
            this.txtDsgAwal.ExAllowNonDBData = false;
            this.txtDsgAwal.ExAutoCheck = true;
            this.txtDsgAwal.ExAutoShowResult = false;
            this.txtDsgAwal.ExCondition = "";
            this.txtDsgAwal.ExDialogTitle = "Inventory";
            this.txtDsgAwal.ExFieldName = "No Design";
            this.txtDsgAwal.ExFilterFields = new string[0];
            this.txtDsgAwal.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtDsgAwal.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtDsgAwal.ExLabelContainer = null;
            this.txtDsgAwal.ExLabelField = "Nama";
            this.txtDsgAwal.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtDsgAwal.ExLabelText = "";
            this.txtDsgAwal.ExLabelVisible = true;
            this.txtDsgAwal.ExSelectFields = new string[0];
            this.txtDsgAwal.ExShowDialog = true;
            this.txtDsgAwal.ExSimpleMode = true;
            this.txtDsgAwal.ExSqlInstance = null;
            this.txtDsgAwal.ExSqlQuery = "Call SP_LookUp(\'dsg\')";
            this.txtDsgAwal.ExTableName = "";
            this.txtDsgAwal.Location = new System.Drawing.Point(148, 97);
            this.txtDsgAwal.Name = "txtDsgAwal";
            this.txtDsgAwal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtDsgAwal.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtDsgAwal.Properties.Appearance.Options.UseBackColor = true;
            this.txtDsgAwal.Properties.Appearance.Options.UseForeColor = true;
            this.txtDsgAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtDsgAwal.Size = new System.Drawing.Size(114, 20);
            this.txtDsgAwal.TabIndex = 128;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 127;
            this.label5.Text = "Design";
            // 
            // txtSOAkhir
            // 
            this.txtSOAkhir.ExAllowEmptyString = true;
            this.txtSOAkhir.ExAllowNonDBData = false;
            this.txtSOAkhir.ExAutoCheck = true;
            this.txtSOAkhir.ExAutoShowResult = false;
            this.txtSOAkhir.ExCondition = "";
            this.txtSOAkhir.ExDialogTitle = "Sales Order";
            this.txtSOAkhir.ExFieldName = "No SO";
            this.txtSOAkhir.ExFilterFields = new string[0];
            this.txtSOAkhir.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtSOAkhir.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtSOAkhir.ExLabelContainer = null;
            this.txtSOAkhir.ExLabelField = "";
            this.txtSOAkhir.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtSOAkhir.ExLabelText = "";
            this.txtSOAkhir.ExLabelVisible = false;
            this.txtSOAkhir.ExSelectFields = new string[0];
            this.txtSOAkhir.ExShowDialog = true;
            this.txtSOAkhir.ExSimpleMode = true;
            this.txtSOAkhir.ExSqlInstance = null;
            this.txtSOAkhir.ExSqlQuery = "Call SP_LookUp(\'so\')";
            this.txtSOAkhir.ExTableName = "";
            this.txtSOAkhir.Location = new System.Drawing.Point(337, 190);
            this.txtSOAkhir.Name = "txtSOAkhir";
            this.txtSOAkhir.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtSOAkhir.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtSOAkhir.Properties.Appearance.Options.UseBackColor = true;
            this.txtSOAkhir.Properties.Appearance.Options.UseForeColor = true;
            this.txtSOAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtSOAkhir.Size = new System.Drawing.Size(114, 20);
            this.txtSOAkhir.TabIndex = 132;
            // 
            // txtSOAwal
            // 
            this.txtSOAwal.ExAllowEmptyString = true;
            this.txtSOAwal.ExAllowNonDBData = false;
            this.txtSOAwal.ExAutoCheck = true;
            this.txtSOAwal.ExAutoShowResult = false;
            this.txtSOAwal.ExCondition = "";
            this.txtSOAwal.ExDialogTitle = "Sales Order";
            this.txtSOAwal.ExFieldName = "No SO";
            this.txtSOAwal.ExFilterFields = new string[0];
            this.txtSOAwal.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtSOAwal.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtSOAwal.ExLabelContainer = null;
            this.txtSOAwal.ExLabelField = "";
            this.txtSOAwal.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtSOAwal.ExLabelText = "";
            this.txtSOAwal.ExLabelVisible = false;
            this.txtSOAwal.ExSelectFields = new string[0];
            this.txtSOAwal.ExShowDialog = true;
            this.txtSOAwal.ExSimpleMode = true;
            this.txtSOAwal.ExSqlInstance = null;
            this.txtSOAwal.ExSqlQuery = "Call SP_LookUp(\'so\')";
            this.txtSOAwal.ExTableName = "";
            this.txtSOAwal.Location = new System.Drawing.Point(148, 190);
            this.txtSOAwal.Name = "txtSOAwal";
            this.txtSOAwal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtSOAwal.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtSOAwal.Properties.Appearance.Options.UseBackColor = true;
            this.txtSOAwal.Properties.Appearance.Options.UseForeColor = true;
            this.txtSOAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtSOAwal.Size = new System.Drawing.Size(114, 20);
            this.txtSOAwal.TabIndex = 131;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 130;
            this.label6.Text = "Sales Order";
            // 
            // FrmLStatusSO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(718, 675);
            this.LookAndFeel.SkinName = "";
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.UseWindowsXPTheme = false;
            this.Name = "FrmLStatusSO";
            this.Load += new System.EventHandler(this.FrmLStatusSO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgStatusSO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvAwal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubAwal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAwal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDsgAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDsgAwal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOAwal.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.RadioGroup rgStatusSO;
        private KASLibrary.TextBoxEx txtInvAkhir;
        private KASLibrary.TextBoxEx txtInvAwal;
        private System.Windows.Forms.Label label3;
        private KASLibrary.TextBoxEx txtSubAkhir;
        private KASLibrary.TextBoxEx txtSubAwal;
        private DevExpress.XtraEditors.DateEdit dtpTglAkhir;
        private DevExpress.XtraEditors.DateEdit dtpTglAwal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private KASLibrary.TextBoxEx txtDsgAkhir;
        private KASLibrary.TextBoxEx txtDsgAwal;
        private System.Windows.Forms.Label label5;
        private KASLibrary.TextBoxEx txtSOAkhir;
        private KASLibrary.TextBoxEx txtSOAwal;
        private System.Windows.Forms.Label label6;
    }
}
