namespace CAS.Laporan
{
    partial class FrmLLPB
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
            System.Windows.Forms.Label label7;
            this.dtpTglAkhir = new DevExpress.XtraEditors.DateEdit();
            this.dtpTglAwal = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubAkhir = new KASLibrary.TextBoxEx();
            this.txtSubAwal = new KASLibrary.TextBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInvAkhir = new KASLibrary.TextBoxEx();
            this.txtInvAwal = new KASLibrary.TextBoxEx();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLPBawal = new KASLibrary.TextBoxEx();
            this.txtLPBAkhir = new KASLibrary.TextBoxEx();
            this.txtOmsAwal = new KASLibrary.TextBoxEx();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLocAkhir = new KASLibrary.TextBoxEx();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLocAwal = new KASLibrary.TextBoxEx();
            this.textBoxEx1 = new KASLibrary.TextBoxEx();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAwal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubAwal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvAwal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLPBawal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLPBAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOmsAwal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocAwal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxEx1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Location = new System.Drawing.Point(1047, 188);
            this.btnClose.LookAndFeel.SkinName = "";
            this.btnClose.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.LookAndFeel.UseWindowsXPTheme = false;
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPreview.Location = new System.Drawing.Point(908, 188);
            this.btnPreview.LookAndFeel.SkinName = "";
            this.btnPreview.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btnPreview.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnPreview.LookAndFeel.UseWindowsXPTheme = false;
            this.btnPreview.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // printControl
            // 
            this.printControl.Location = new System.Drawing.Point(0, 299);
            this.printControl.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.printControl.Size = new System.Drawing.Size(1590, 501);
            // 
            // printPreviewBar
            // 
            this.printPreviewBar.Location = new System.Drawing.Point(0, 271);
            this.printPreviewBar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.printPreviewBar.Size = new System.Drawing.Size(1590, 28);
            // 
            // printPreviewStatus
            // 
            this.printPreviewStatus.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.printPreviewStatus.Size = new System.Drawing.Size(1590, 34);
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(label7);
            this.pnlFilter.Controls.Add(this.textBoxEx1);
            this.pnlFilter.Controls.Add(this.txtLocAkhir);
            this.pnlFilter.Controls.Add(this.label6);
            this.pnlFilter.Controls.Add(this.txtLocAwal);
            this.pnlFilter.Controls.Add(this.txtOmsAwal);
            this.pnlFilter.Controls.Add(this.label5);
            this.pnlFilter.Controls.Add(this.txtLPBAkhir);
            this.pnlFilter.Controls.Add(this.label4);
            this.pnlFilter.Controls.Add(this.txtLPBawal);
            this.pnlFilter.Controls.Add(this.dtpTglAkhir);
            this.pnlFilter.Controls.Add(this.label1);
            this.pnlFilter.Controls.Add(this.txtInvAkhir);
            this.pnlFilter.Controls.Add(this.txtInvAwal);
            this.pnlFilter.Controls.Add(this.dtpTglAwal);
            this.pnlFilter.Controls.Add(this.label3);
            this.pnlFilter.Controls.Add(this.txtSubAwal);
            this.pnlFilter.Controls.Add(this.label2);
            this.pnlFilter.Controls.Add(this.txtSubAkhir);
            this.pnlFilter.LookAndFeel.SkinName = "";
            this.pnlFilter.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.pnlFilter.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlFilter.LookAndFeel.UseWindowsXPTheme = false;
            this.pnlFilter.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pnlFilter.Size = new System.Drawing.Size(1590, 271);
            this.pnlFilter.Controls.SetChildIndex(this.txtSubAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label2, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtSubAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label3, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dtpTglAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtInvAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtInvAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.btnPreview, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label1, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dtpTglAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.btnClose, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtLPBawal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label4, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtLPBAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label5, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtOmsAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtLocAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label6, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtLocAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.textBoxEx1, 0);
            this.pnlFilter.Controls.SetChildIndex(label7, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(786, 128);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(109, 19);
            label7.TabIndex = 149;
            label7.Text = "User Pemesan";
            // 
            // dtpTglAkhir
            // 
            this.dtpTglAkhir.EditValue = new System.DateTime(2008, 10, 11, 0, 0, 0, 0);
            this.dtpTglAkhir.Location = new System.Drawing.Point(562, 20);
            this.dtpTglAkhir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpTglAkhir.Name = "dtpTglAkhir";
            this.dtpTglAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTglAkhir.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAkhir.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAkhir.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAkhir.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAkhir.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtpTglAkhir.Size = new System.Drawing.Size(171, 26);
            this.dtpTglAkhir.TabIndex = 35;
            // 
            // dtpTglAwal
            // 
            this.dtpTglAwal.EditValue = new System.DateTime(2008, 10, 11, 0, 0, 0, 0);
            this.dtpTglAwal.Location = new System.Drawing.Point(159, 18);
            this.dtpTglAwal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpTglAwal.Name = "dtpTglAwal";
            this.dtpTglAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTglAwal.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAwal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAwal.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAwal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAwal.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtpTglAwal.Size = new System.Drawing.Size(171, 26);
            this.dtpTglAwal.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 33;
            this.label3.Text = "Tanggal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Supplier";
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
            this.txtSubAkhir.Location = new System.Drawing.Point(562, 65);
            this.txtSubAkhir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSubAkhir.Name = "txtSubAkhir";
            this.txtSubAkhir.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtSubAkhir.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtSubAkhir.Properties.Appearance.Options.UseBackColor = true;
            this.txtSubAkhir.Properties.Appearance.Options.UseForeColor = true;
            this.txtSubAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtSubAkhir.Size = new System.Drawing.Size(171, 26);
            this.txtSubAkhir.TabIndex = 32;
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
            this.txtSubAwal.Location = new System.Drawing.Point(159, 63);
            this.txtSubAwal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSubAwal.Name = "txtSubAwal";
            this.txtSubAwal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtSubAwal.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtSubAwal.Properties.Appearance.Options.UseBackColor = true;
            this.txtSubAwal.Properties.Appearance.Options.UseForeColor = true;
            this.txtSubAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtSubAwal.Size = new System.Drawing.Size(171, 26);
            this.txtSubAwal.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Material";
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
            this.txtInvAkhir.ExSqlQuery = "Call SP_LookUp(\'invpemb\')";
            this.txtInvAkhir.ExTableName = "";
            this.txtInvAkhir.Location = new System.Drawing.Point(562, 122);
            this.txtInvAkhir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInvAkhir.Name = "txtInvAkhir";
            this.txtInvAkhir.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtInvAkhir.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtInvAkhir.Properties.Appearance.Options.UseBackColor = true;
            this.txtInvAkhir.Properties.Appearance.Options.UseForeColor = true;
            this.txtInvAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtInvAkhir.Size = new System.Drawing.Size(171, 26);
            this.txtInvAkhir.TabIndex = 9;
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
            this.txtInvAwal.ExSqlQuery = "Call SP_LookUp(\'invpemb\')";
            this.txtInvAwal.ExTableName = "";
            this.txtInvAwal.Location = new System.Drawing.Point(159, 122);
            this.txtInvAwal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInvAwal.Name = "txtInvAwal";
            this.txtInvAwal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtInvAwal.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtInvAwal.Properties.Appearance.Options.UseBackColor = true;
            this.txtInvAwal.Properties.Appearance.Options.UseForeColor = true;
            this.txtInvAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtInvAwal.Size = new System.Drawing.Size(171, 26);
            this.txtInvAwal.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 19);
            this.label4.TabIndex = 37;
            this.label4.Text = "LPB";
            // 
            // txtLPBawal
            // 
            this.txtLPBawal.ExAllowEmptyString = true;
            this.txtLPBawal.ExAllowNonDBData = false;
            this.txtLPBawal.ExAutoCheck = true;
            this.txtLPBawal.ExAutoShowResult = false;
            this.txtLPBawal.ExCondition = "";
            this.txtLPBawal.ExDialogTitle = "LPB";
            this.txtLPBawal.ExFieldName = "No LPB";
            this.txtLPBawal.ExFilterFields = new string[0];
            this.txtLPBawal.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtLPBawal.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtLPBawal.ExLabelContainer = null;
            this.txtLPBawal.ExLabelField = "Tanggal";
            this.txtLPBawal.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtLPBawal.ExLabelText = "";
            this.txtLPBawal.ExLabelVisible = false;
            this.txtLPBawal.ExSelectFields = new string[0];
            this.txtLPBawal.ExShowDialog = true;
            this.txtLPBawal.ExSimpleMode = true;
            this.txtLPBawal.ExSqlInstance = null;
            this.txtLPBawal.ExSqlQuery = "Call SP_LookUp(\'lpb\')";
            this.txtLPBawal.ExTableName = "";
            this.txtLPBawal.Location = new System.Drawing.Point(159, 183);
            this.txtLPBawal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLPBawal.Name = "txtLPBawal";
            this.txtLPBawal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtLPBawal.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtLPBawal.Properties.Appearance.Options.UseBackColor = true;
            this.txtLPBawal.Properties.Appearance.Options.UseForeColor = true;
            this.txtLPBawal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtLPBawal.Size = new System.Drawing.Size(171, 26);
            this.txtLPBawal.TabIndex = 36;
            // 
            // txtLPBAkhir
            // 
            this.txtLPBAkhir.ExAllowEmptyString = true;
            this.txtLPBAkhir.ExAllowNonDBData = false;
            this.txtLPBAkhir.ExAutoCheck = true;
            this.txtLPBAkhir.ExAutoShowResult = false;
            this.txtLPBAkhir.ExCondition = "";
            this.txtLPBAkhir.ExDialogTitle = "LPB";
            this.txtLPBAkhir.ExFieldName = "No LPB";
            this.txtLPBAkhir.ExFilterFields = new string[0];
            this.txtLPBAkhir.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtLPBAkhir.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtLPBAkhir.ExLabelContainer = null;
            this.txtLPBAkhir.ExLabelField = "Tanggal";
            this.txtLPBAkhir.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.txtLPBAkhir.ExLabelText = "";
            this.txtLPBAkhir.ExLabelVisible = false;
            this.txtLPBAkhir.ExSelectFields = new string[0];
            this.txtLPBAkhir.ExShowDialog = true;
            this.txtLPBAkhir.ExSimpleMode = true;
            this.txtLPBAkhir.ExSqlInstance = null;
            this.txtLPBAkhir.ExSqlQuery = "Call SP_LookUp(\'lpb\')";
            this.txtLPBAkhir.ExTableName = "";
            this.txtLPBAkhir.Location = new System.Drawing.Point(562, 183);
            this.txtLPBAkhir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLPBAkhir.Name = "txtLPBAkhir";
            this.txtLPBAkhir.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtLPBAkhir.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtLPBAkhir.Properties.Appearance.Options.UseBackColor = true;
            this.txtLPBAkhir.Properties.Appearance.Options.UseForeColor = true;
            this.txtLPBAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtLPBAkhir.Size = new System.Drawing.Size(171, 26);
            this.txtLPBAkhir.TabIndex = 38;
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
            this.txtOmsAwal.Location = new System.Drawing.Point(906, 25);
            this.txtOmsAwal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOmsAwal.Name = "txtOmsAwal";
            this.txtOmsAwal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtOmsAwal.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtOmsAwal.Properties.Appearance.Options.UseBackColor = true;
            this.txtOmsAwal.Properties.Appearance.Options.UseForeColor = true;
            this.txtOmsAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtOmsAwal.Size = new System.Drawing.Size(171, 26);
            this.txtOmsAwal.TabIndex = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(819, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 124;
            this.label5.Text = "No PO";
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
            this.txtLocAkhir.Location = new System.Drawing.Point(1149, 63);
            this.txtLocAkhir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLocAkhir.Name = "txtLocAkhir";
            this.txtLocAkhir.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtLocAkhir.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtLocAkhir.Properties.Appearance.Options.UseBackColor = true;
            this.txtLocAkhir.Properties.Appearance.Options.UseForeColor = true;
            this.txtLocAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtLocAkhir.Size = new System.Drawing.Size(189, 26);
            this.txtLocAkhir.TabIndex = 127;
            this.txtLocAkhir.EditValueChanged += new System.EventHandler(this.txtLocAkhir_EditValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(813, 68);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 128;
            this.label6.Text = "Lokasi";
            this.label6.Click += new System.EventHandler(this.label6_Click);
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
            this.txtLocAwal.Location = new System.Drawing.Point(906, 63);
            this.txtLocAwal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLocAwal.Name = "txtLocAwal";
            this.txtLocAwal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtLocAwal.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtLocAwal.Properties.Appearance.Options.UseBackColor = true;
            this.txtLocAwal.Properties.Appearance.Options.UseForeColor = true;
            this.txtLocAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtLocAwal.Size = new System.Drawing.Size(171, 26);
            this.txtLocAwal.TabIndex = 126;
            this.txtLocAwal.EditValueChanged += new System.EventHandler(this.txtLocAwal_EditValueChanged);
            // 
            // textBoxEx1
            // 
            this.textBoxEx1.ExAllowEmptyString = true;
            this.textBoxEx1.ExAllowNonDBData = false;
            this.textBoxEx1.ExAutoCheck = true;
            this.textBoxEx1.ExAutoShowResult = false;
            this.textBoxEx1.ExCondition = "";
            this.textBoxEx1.ExDialogTitle = "";
            this.textBoxEx1.ExFieldName = "usrp";
            this.textBoxEx1.ExFilterFields = new string[0];
            this.textBoxEx1.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.textBoxEx1.ExInvalidForeColor = System.Drawing.Color.Black;
            this.textBoxEx1.ExLabelContainer = null;
            this.textBoxEx1.ExLabelField = "name";
            this.textBoxEx1.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.textBoxEx1.ExLabelText = "nama";
            this.textBoxEx1.ExLabelVisible = true;
            this.textBoxEx1.ExSelectFields = new string[0];
            this.textBoxEx1.ExShowDialog = true;
            this.textBoxEx1.ExSimpleMode = true;
            this.textBoxEx1.ExSqlInstance = null;
            this.textBoxEx1.ExSqlQuery = "select * from usrp where aktif=1";
            this.textBoxEx1.ExTableName = "usrp";
            this.textBoxEx1.Location = new System.Drawing.Point(908, 123);
            this.textBoxEx1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEx1.Name = "textBoxEx1";
            this.textBoxEx1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.textBoxEx1.Size = new System.Drawing.Size(148, 26);
            this.textBoxEx1.TabIndex = 150;
            // 
            // FrmLLPB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1590, 834);
            this.LookAndFeel.SkinName = "";
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.UseWindowsXPTheme = false;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "FrmLLPB";
            this.Text = "FrmLLPB";
            this.Load += new System.EventHandler(this.FrmLLPB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAwal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubAwal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvAwal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLPBawal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLPBAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOmsAwal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocAwal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxEx1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dtpTglAkhir;
        private DevExpress.XtraEditors.DateEdit dtpTglAwal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private KASLibrary.TextBoxEx txtSubAkhir;
        private KASLibrary.TextBoxEx txtSubAwal;
        private System.Windows.Forms.Label label1;
        private KASLibrary.TextBoxEx txtInvAkhir;
        private KASLibrary.TextBoxEx txtInvAwal;
        private System.Windows.Forms.Label label4;
        private KASLibrary.TextBoxEx txtLPBawal;
        private KASLibrary.TextBoxEx txtLPBAkhir;
        private KASLibrary.TextBoxEx txtOmsAwal;
        private System.Windows.Forms.Label label5;
        private KASLibrary.TextBoxEx txtLocAkhir;
        private System.Windows.Forms.Label label6;
        private KASLibrary.TextBoxEx txtLocAwal;
        private KASLibrary.TextBoxEx textBoxEx1;
    }
}