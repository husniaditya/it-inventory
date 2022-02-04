namespace CAS.Laporan
{
    partial class FrmLKartuStock
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
            this.dtpTglAwal = new DevExpress.XtraEditors.DateEdit();
            this.txtInvAwal = new KASLibrary.TextBoxEx();
            this.dtpTglAkhir = new DevExpress.XtraEditors.DateEdit();
            this.txtInvAkhir = new KASLibrary.TextBoxEx();
            this.txtLocAwal = new KASLibrary.TextBoxEx();
            this.txtLocAkhir = new KASLibrary.TextBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDsgAwal = new KASLibrary.TextBoxEx();
            this.txtDsgAkhir = new KASLibrary.TextBoxEx();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtJenisAkhir = new KASLibrary.TextBoxEx();
            this.txtJenisAwal = new KASLibrary.TextBoxEx();
            this.label6 = new System.Windows.Forms.Label();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.grpmatTextBoxEx = new KASLibrary.TextBoxEx();
            this.grpmatlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAwal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvAwal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocAwal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDsgAwal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDsgAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJenisAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJenisAwal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpmatTextBoxEx.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(415, 328);
            this.btnClose.LookAndFeel.SkinName = "";
            this.btnClose.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.LookAndFeel.UseWindowsXPTheme = false;
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(293, 328);
            this.btnPreview.LookAndFeel.SkinName = "";
            this.btnPreview.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btnPreview.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnPreview.LookAndFeel.UseWindowsXPTheme = false;
            this.btnPreview.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // printControl
            // 
            this.printControl.Location = new System.Drawing.Point(0, 402);
            this.printControl.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.printControl.Size = new System.Drawing.Size(1077, 482);
            // 
            // printPreviewBar
            // 
            this.printPreviewBar.Location = new System.Drawing.Point(0, 374);
            this.printPreviewBar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.printPreviewBar.Size = new System.Drawing.Size(1077, 28);
            // 
            // printPreviewStatus
            // 
            this.printPreviewStatus.Location = new System.Drawing.Point(0, 884);
            this.printPreviewStatus.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.grpmatTextBoxEx);
            this.pnlFilter.Controls.Add(this.grpmatlbl);
            this.pnlFilter.Controls.Add(this.radioGroup1);
            this.pnlFilter.Controls.Add(this.label6);
            this.pnlFilter.Controls.Add(this.label5);
            this.pnlFilter.Controls.Add(this.txtJenisAkhir);
            this.pnlFilter.Controls.Add(this.txtJenisAwal);
            this.pnlFilter.Controls.Add(this.label1);
            this.pnlFilter.Controls.Add(this.dtpTglAwal);
            this.pnlFilter.Controls.Add(this.dtpTglAkhir);
            this.pnlFilter.Controls.Add(this.txtLocAkhir);
            this.pnlFilter.Controls.Add(this.label3);
            this.pnlFilter.Controls.Add(this.label2);
            this.pnlFilter.Controls.Add(this.txtInvAkhir);
            this.pnlFilter.Controls.Add(this.label4);
            this.pnlFilter.Controls.Add(this.txtLocAwal);
            this.pnlFilter.Controls.Add(this.txtDsgAkhir);
            this.pnlFilter.Controls.Add(this.txtInvAwal);
            this.pnlFilter.Controls.Add(this.txtDsgAwal);
            this.pnlFilter.LookAndFeel.SkinName = "";
            this.pnlFilter.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.pnlFilter.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlFilter.LookAndFeel.UseWindowsXPTheme = false;
            this.pnlFilter.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pnlFilter.Size = new System.Drawing.Size(1077, 374);
            this.pnlFilter.Controls.SetChildIndex(this.txtDsgAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtInvAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtDsgAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtLocAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label4, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtInvAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label2, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label3, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtLocAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dtpTglAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dtpTglAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label1, 0);
            this.pnlFilter.Controls.SetChildIndex(this.btnPreview, 0);
            this.pnlFilter.Controls.SetChildIndex(this.btnClose, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtJenisAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtJenisAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label5, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label6, 0);
            this.pnlFilter.Controls.SetChildIndex(this.radioGroup1, 0);
            this.pnlFilter.Controls.SetChildIndex(this.grpmatlbl, 0);
            this.pnlFilter.Controls.SetChildIndex(this.grpmatTextBoxEx, 0);
            // 
            // dtpTglAwal
            // 
            this.dtpTglAwal.EditValue = new System.DateTime(2008, 8, 20, 15, 40, 28, 0);
            this.dtpTglAwal.Location = new System.Drawing.Point(242, 32);
            this.dtpTglAwal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpTglAwal.Name = "dtpTglAwal";
            this.dtpTglAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTglAwal.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAwal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAwal.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAwal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAwal.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtpTglAwal.Size = new System.Drawing.Size(150, 26);
            this.dtpTglAwal.TabIndex = 3;
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
            this.txtInvAwal.Location = new System.Drawing.Point(242, 134);
            this.txtInvAwal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInvAwal.Name = "txtInvAwal";
            this.txtInvAwal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtInvAwal.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtInvAwal.Properties.Appearance.Options.UseBackColor = true;
            this.txtInvAwal.Properties.Appearance.Options.UseForeColor = true;
            this.txtInvAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtInvAwal.Size = new System.Drawing.Size(150, 26);
            this.txtInvAwal.TabIndex = 4;
            // 
            // dtpTglAkhir
            // 
            this.dtpTglAkhir.EditValue = new System.DateTime(2008, 8, 20, 15, 40, 28, 0);
            this.dtpTglAkhir.Location = new System.Drawing.Point(484, 32);
            this.dtpTglAkhir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpTglAkhir.Name = "dtpTglAkhir";
            this.dtpTglAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTglAkhir.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAkhir.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAkhir.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAkhir.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAkhir.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtpTglAkhir.Size = new System.Drawing.Size(150, 26);
            this.dtpTglAkhir.TabIndex = 3;
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
            this.txtInvAkhir.Location = new System.Drawing.Point(484, 134);
            this.txtInvAkhir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInvAkhir.Name = "txtInvAkhir";
            this.txtInvAkhir.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtInvAkhir.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtInvAkhir.Properties.Appearance.Options.UseBackColor = true;
            this.txtInvAkhir.Properties.Appearance.Options.UseForeColor = true;
            this.txtInvAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtInvAkhir.Size = new System.Drawing.Size(150, 26);
            this.txtInvAkhir.TabIndex = 4;
            // 
            // txtLocAwal
            // 
            this.txtLocAwal.ExAllowEmptyString = true;
            this.txtLocAwal.ExAllowNonDBData = false;
            this.txtLocAwal.ExAutoCheck = true;
            this.txtLocAwal.ExAutoShowResult = false;
            this.txtLocAwal.ExCondition = "";
            this.txtLocAwal.ExDialogTitle = "Location";
            this.txtLocAwal.ExFieldName = "Loc";
            this.txtLocAwal.ExFilterFields = new string[0];
            this.txtLocAwal.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtLocAwal.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtLocAwal.ExLabelContainer = null;
            this.txtLocAwal.ExLabelField = "Nama Lokasi";
            this.txtLocAwal.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtLocAwal.ExLabelText = "";
            this.txtLocAwal.ExLabelVisible = true;
            this.txtLocAwal.ExSelectFields = new string[0];
            this.txtLocAwal.ExShowDialog = true;
            this.txtLocAwal.ExSimpleMode = true;
            this.txtLocAwal.ExSqlInstance = null;
            this.txtLocAwal.ExSqlQuery = "Call SP_LookUp(\'loc\')";
            this.txtLocAwal.ExTableName = "";
            this.txtLocAwal.Location = new System.Drawing.Point(242, 262);
            this.txtLocAwal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLocAwal.Name = "txtLocAwal";
            this.txtLocAwal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtLocAwal.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtLocAwal.Properties.Appearance.Options.UseBackColor = true;
            this.txtLocAwal.Properties.Appearance.Options.UseForeColor = true;
            this.txtLocAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtLocAwal.Size = new System.Drawing.Size(150, 26);
            this.txtLocAwal.TabIndex = 4;
            // 
            // txtLocAkhir
            // 
            this.txtLocAkhir.ExAllowEmptyString = true;
            this.txtLocAkhir.ExAllowNonDBData = false;
            this.txtLocAkhir.ExAutoCheck = true;
            this.txtLocAkhir.ExAutoShowResult = false;
            this.txtLocAkhir.ExCondition = "";
            this.txtLocAkhir.ExDialogTitle = "Location";
            this.txtLocAkhir.ExFieldName = "Loc";
            this.txtLocAkhir.ExFilterFields = new string[0];
            this.txtLocAkhir.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtLocAkhir.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtLocAkhir.ExLabelContainer = null;
            this.txtLocAkhir.ExLabelField = "Nama Lokasi";
            this.txtLocAkhir.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtLocAkhir.ExLabelText = "";
            this.txtLocAkhir.ExLabelVisible = true;
            this.txtLocAkhir.ExSelectFields = new string[0];
            this.txtLocAkhir.ExShowDialog = true;
            this.txtLocAkhir.ExSimpleMode = true;
            this.txtLocAkhir.ExSqlInstance = null;
            this.txtLocAkhir.ExSqlQuery = "Call SP_LookUp(\'loc\')";
            this.txtLocAkhir.ExTableName = "";
            this.txtLocAkhir.Location = new System.Drawing.Point(484, 262);
            this.txtLocAkhir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLocAkhir.Name = "txtLocAkhir";
            this.txtLocAkhir.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtLocAkhir.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtLocAkhir.Properties.Appearance.Options.UseBackColor = true;
            this.txtLocAkhir.Properties.Appearance.Options.UseForeColor = true;
            this.txtLocAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtLocAkhir.Size = new System.Drawing.Size(150, 26);
            this.txtLocAkhir.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tanggal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Persediaan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 266);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lokasi";
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
            this.txtDsgAwal.ExLabelField = "";
            this.txtDsgAwal.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtDsgAwal.ExLabelText = "";
            this.txtDsgAwal.ExLabelVisible = true;
            this.txtDsgAwal.ExSelectFields = new string[0];
            this.txtDsgAwal.ExShowDialog = true;
            this.txtDsgAwal.ExSimpleMode = true;
            this.txtDsgAwal.ExSqlInstance = null;
            this.txtDsgAwal.ExSqlQuery = "SELECT DISTINCT(TRIM(nodsg)) AS `No Design` FROM ind ORDER BY TRIM(nodsg)";
            this.txtDsgAwal.ExTableName = "";
            this.txtDsgAwal.Location = new System.Drawing.Point(242, 197);
            this.txtDsgAwal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDsgAwal.Name = "txtDsgAwal";
            this.txtDsgAwal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtDsgAwal.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtDsgAwal.Properties.Appearance.Options.UseBackColor = true;
            this.txtDsgAwal.Properties.Appearance.Options.UseForeColor = true;
            this.txtDsgAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtDsgAwal.Size = new System.Drawing.Size(150, 26);
            this.txtDsgAwal.TabIndex = 4;
            this.txtDsgAwal.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtDsgAwal_ButtonPressed);
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
            this.txtDsgAkhir.ExLabelField = "";
            this.txtDsgAkhir.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtDsgAkhir.ExLabelText = "";
            this.txtDsgAkhir.ExLabelVisible = true;
            this.txtDsgAkhir.ExSelectFields = new string[0];
            this.txtDsgAkhir.ExShowDialog = true;
            this.txtDsgAkhir.ExSimpleMode = true;
            this.txtDsgAkhir.ExSqlInstance = null;
            this.txtDsgAkhir.ExSqlQuery = "SELECT DISTINCT(TRIM(nodsg)) AS `No Design` FROM ind ORDER BY TRIM(nodsg)";
            this.txtDsgAkhir.ExTableName = "";
            this.txtDsgAkhir.Location = new System.Drawing.Point(484, 197);
            this.txtDsgAkhir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDsgAkhir.Name = "txtDsgAkhir";
            this.txtDsgAkhir.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtDsgAkhir.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtDsgAkhir.Properties.Appearance.Options.UseBackColor = true;
            this.txtDsgAkhir.Properties.Appearance.Options.UseForeColor = true;
            this.txtDsgAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtDsgAkhir.Size = new System.Drawing.Size(150, 26);
            this.txtDsgAkhir.TabIndex = 4;
            this.txtDsgAkhir.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtDsgAkhir_ButtonPressed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "No Design";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 77);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kelompok Persediaan";
            // 
            // txtJenisAkhir
            // 
            this.txtJenisAkhir.ExAllowEmptyString = true;
            this.txtJenisAkhir.ExAllowNonDBData = false;
            this.txtJenisAkhir.ExAutoCheck = true;
            this.txtJenisAkhir.ExAutoShowResult = false;
            this.txtJenisAkhir.ExCondition = "";
            this.txtJenisAkhir.ExDialogTitle = "Kelompok Persediaan";
            this.txtJenisAkhir.ExFieldName = "Jenis";
            this.txtJenisAkhir.ExFilterFields = new string[0];
            this.txtJenisAkhir.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtJenisAkhir.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtJenisAkhir.ExLabelContainer = null;
            this.txtJenisAkhir.ExLabelField = "Nama";
            this.txtJenisAkhir.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtJenisAkhir.ExLabelText = "";
            this.txtJenisAkhir.ExLabelVisible = true;
            this.txtJenisAkhir.ExSelectFields = new string[0];
            this.txtJenisAkhir.ExShowDialog = true;
            this.txtJenisAkhir.ExSimpleMode = true;
            this.txtJenisAkhir.ExSqlInstance = null;
            this.txtJenisAkhir.ExSqlQuery = "Call SP_LookUp(\'jenis\')";
            this.txtJenisAkhir.ExTableName = "";
            this.txtJenisAkhir.Location = new System.Drawing.Point(484, 72);
            this.txtJenisAkhir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtJenisAkhir.Name = "txtJenisAkhir";
            this.txtJenisAkhir.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtJenisAkhir.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtJenisAkhir.Properties.Appearance.Options.UseBackColor = true;
            this.txtJenisAkhir.Properties.Appearance.Options.UseForeColor = true;
            this.txtJenisAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtJenisAkhir.Size = new System.Drawing.Size(150, 26);
            this.txtJenisAkhir.TabIndex = 9;
            // 
            // txtJenisAwal
            // 
            this.txtJenisAwal.ExAllowEmptyString = true;
            this.txtJenisAwal.ExAllowNonDBData = false;
            this.txtJenisAwal.ExAutoCheck = true;
            this.txtJenisAwal.ExAutoShowResult = false;
            this.txtJenisAwal.ExCondition = "";
            this.txtJenisAwal.ExDialogTitle = "Kelompok Persediaan";
            this.txtJenisAwal.ExFieldName = "Jenis";
            this.txtJenisAwal.ExFilterFields = new string[0];
            this.txtJenisAwal.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtJenisAwal.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtJenisAwal.ExLabelContainer = null;
            this.txtJenisAwal.ExLabelField = "Nama";
            this.txtJenisAwal.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtJenisAwal.ExLabelText = "";
            this.txtJenisAwal.ExLabelVisible = true;
            this.txtJenisAwal.ExSelectFields = new string[0];
            this.txtJenisAwal.ExShowDialog = true;
            this.txtJenisAwal.ExSimpleMode = true;
            this.txtJenisAwal.ExSqlInstance = null;
            this.txtJenisAwal.ExSqlQuery = "Call SP_LookUp(\'jenis\')";
            this.txtJenisAwal.ExTableName = "";
            this.txtJenisAwal.Location = new System.Drawing.Point(242, 72);
            this.txtJenisAwal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtJenisAwal.Name = "txtJenisAwal";
            this.txtJenisAwal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtJenisAwal.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtJenisAwal.Properties.Appearance.Options.UseBackColor = true;
            this.txtJenisAwal.Properties.Appearance.Options.UseForeColor = true;
            this.txtJenisAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtJenisAwal.Size = new System.Drawing.Size(150, 26);
            this.txtJenisAwal.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 328);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Satuan";
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(242, 322);
            this.radioGroup1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Columns = 2;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Satuan Kecil"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Satuan Besar")});
            this.radioGroup1.Size = new System.Drawing.Size(393, 35);
            this.radioGroup1.TabIndex = 12;
            // 
            // grpmatTextBoxEx
            // 
            this.grpmatTextBoxEx.ExAllowEmptyString = true;
            this.grpmatTextBoxEx.ExAllowNonDBData = false;
            this.grpmatTextBoxEx.ExAutoCheck = true;
            this.grpmatTextBoxEx.ExAutoShowResult = false;
            this.grpmatTextBoxEx.ExCondition = "";
            this.grpmatTextBoxEx.ExDialogTitle = "Group Purchase";
            this.grpmatTextBoxEx.ExFieldName = "gro";
            this.grpmatTextBoxEx.ExFilterFields = new string[0];
            this.grpmatTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.grpmatTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.grpmatTextBoxEx.ExLabelContainer = null;
            this.grpmatTextBoxEx.ExLabelField = "name";
            this.grpmatTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.grpmatTextBoxEx.ExLabelText = "";
            this.grpmatTextBoxEx.ExLabelVisible = true;
            this.grpmatTextBoxEx.ExSelectFields = new string[0];
            this.grpmatTextBoxEx.ExShowDialog = true;
            this.grpmatTextBoxEx.ExSimpleMode = true;
            this.grpmatTextBoxEx.ExSqlInstance = null;
            this.grpmatTextBoxEx.ExSqlQuery = "select * from gro";
            this.grpmatTextBoxEx.ExTableName = "gro";
            this.grpmatTextBoxEx.Location = new System.Drawing.Point(900, 72);
            this.grpmatTextBoxEx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpmatTextBoxEx.Name = "grpmatTextBoxEx";
            this.grpmatTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.grpmatTextBoxEx.Size = new System.Drawing.Size(150, 26);
            this.grpmatTextBoxEx.TabIndex = 75;
            this.grpmatTextBoxEx.Visible = false;
            // 
            // grpmatlbl
            // 
            this.grpmatlbl.AutoSize = true;
            this.grpmatlbl.Location = new System.Drawing.Point(776, 77);
            this.grpmatlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.grpmatlbl.Name = "grpmatlbl";
            this.grpmatlbl.Size = new System.Drawing.Size(113, 19);
            this.grpmatlbl.TabIndex = 74;
            this.grpmatlbl.Text = "Material Group";
            this.grpmatlbl.Visible = false;
            // 
            // FrmLKartuStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 918);
            this.LookAndFeel.SkinName = "";
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.UseWindowsXPTheme = false;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "FrmLKartuStock";
            this.Text = "Laporan Kartu Persediaan";
            this.Load += new System.EventHandler(this.FrmLKartuStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAwal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvAwal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocAwal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDsgAwal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDsgAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJenisAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJenisAwal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpmatTextBoxEx.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KASLibrary.TextBoxEx txtInvAwal;
        private DevExpress.XtraEditors.DateEdit dtpTglAwal;
        private DevExpress.XtraEditors.DateEdit dtpTglAkhir;
        private KASLibrary.TextBoxEx txtInvAkhir;
        private KASLibrary.TextBoxEx txtLocAwal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private KASLibrary.TextBoxEx txtLocAkhir;
        private System.Windows.Forms.Label label4;
        private KASLibrary.TextBoxEx txtDsgAkhir;
        private KASLibrary.TextBoxEx txtDsgAwal;
        private System.Windows.Forms.Label label5;
        private KASLibrary.TextBoxEx txtJenisAkhir;
        private KASLibrary.TextBoxEx txtJenisAwal;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private KASLibrary.TextBoxEx grpmatTextBoxEx;
        private System.Windows.Forms.Label grpmatlbl;
    }
}