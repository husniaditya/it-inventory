namespace CAS.Laporan
{
    partial class FrmLKlrPerTanggal
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
            this.dtpTglAkhir = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTglAwal = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInvAkhir = new KASLibrary.TextBoxEx();
            this.txtInvAwal = new KASLibrary.TextBoxEx();
            this.textretawal = new KASLibrary.TextBoxEx();
            this.textretakhir = new KASLibrary.TextBoxEx();
            this.textpjlawal = new KASLibrary.TextBoxEx();
            this.textpjlakhir = new KASLibrary.TextBoxEx();
            this.txtSubAkhir = new KASLibrary.TextBoxEx();
            this.txtSubAwal = new KASLibrary.TextBoxEx();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAwal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvAwal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textretawal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textretakhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textpjlawal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textpjlakhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubAwal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(543, 120);
            this.btnClose.LookAndFeel.SkinName = "";
            this.btnClose.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.LookAndFeel.UseWindowsXPTheme = false;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(462, 120);
            this.btnPreview.LookAndFeel.SkinName = "";
            this.btnPreview.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btnPreview.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnPreview.LookAndFeel.UseWindowsXPTheme = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // printControl
            // 
            this.printControl.Location = new System.Drawing.Point(0, 177);
            this.printControl.Size = new System.Drawing.Size(719, 256);
            // 
            // printPreviewBar
            // 
            this.printPreviewBar.Location = new System.Drawing.Point(0, 149);
            this.printPreviewBar.Size = new System.Drawing.Size(719, 28);
            // 
            // printPreviewStatus
            // 
            this.printPreviewStatus.Location = new System.Drawing.Point(0, 433);
            this.printPreviewStatus.Size = new System.Drawing.Size(719, 22);
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.label6);
            this.pnlFilter.Controls.Add(this.txtInvAkhir);
            this.pnlFilter.Controls.Add(this.txtInvAwal);
            this.pnlFilter.Controls.Add(this.radioGroup1);
            this.pnlFilter.Controls.Add(this.label5);
            this.pnlFilter.Controls.Add(this.label4);
            this.pnlFilter.Controls.Add(this.label3);
            this.pnlFilter.Controls.Add(this.textretawal);
            this.pnlFilter.Controls.Add(this.textretakhir);
            this.pnlFilter.Controls.Add(this.textpjlawal);
            this.pnlFilter.Controls.Add(this.textpjlakhir);
            this.pnlFilter.Controls.Add(this.txtSubAkhir);
            this.pnlFilter.Controls.Add(this.txtSubAwal);
            this.pnlFilter.Controls.Add(this.dtpTglAkhir);
            this.pnlFilter.Controls.Add(this.label1);
            this.pnlFilter.Controls.Add(this.dtpTglAwal);
            this.pnlFilter.Controls.Add(this.label2);
            this.pnlFilter.LookAndFeel.SkinName = "";
            this.pnlFilter.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.pnlFilter.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlFilter.LookAndFeel.UseWindowsXPTheme = false;
            this.pnlFilter.Size = new System.Drawing.Size(719, 149);
            this.pnlFilter.Controls.SetChildIndex(this.btnPreview, 0);
            this.pnlFilter.Controls.SetChildIndex(this.btnClose, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label2, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dtpTglAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label1, 0);
            this.pnlFilter.Controls.SetChildIndex(this.dtpTglAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtSubAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtSubAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.textpjlakhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.textpjlawal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.textretakhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.textretawal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label3, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label4, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label5, 0);
            this.pnlFilter.Controls.SetChildIndex(this.radioGroup1, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtInvAwal, 0);
            this.pnlFilter.Controls.SetChildIndex(this.txtInvAkhir, 0);
            this.pnlFilter.Controls.SetChildIndex(this.label6, 0);
            // 
            // dtpTglAkhir
            // 
            this.dtpTglAkhir.EditValue = new System.DateTime(2008, 8, 20, 15, 40, 28, 0);
            this.dtpTglAkhir.Location = new System.Drawing.Point(223, 21);
            this.dtpTglAkhir.Name = "dtpTglAkhir";
            this.dtpTglAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTglAkhir.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAkhir.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAkhir.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAkhir.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAkhir.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtpTglAkhir.Size = new System.Drawing.Size(114, 20);
            this.dtpTglAkhir.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tanggal";
            // 
            // dtpTglAwal
            // 
            this.dtpTglAwal.EditValue = new System.DateTime(2008, 8, 20, 15, 40, 28, 0);
            this.dtpTglAwal.Location = new System.Drawing.Point(82, 21);
            this.dtpTglAwal.Name = "dtpTglAwal";
            this.dtpTglAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTglAwal.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAwal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAwal.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAwal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAwal.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtpTglAwal.Size = new System.Drawing.Size(114, 20);
            this.dtpTglAwal.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "No Penjualan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "No Retur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Jenis Laporan";
            // 
            // radioGroup1
            // 
            this.radioGroup1.EditValue = "3";
            this.radioGroup1.Location = new System.Drawing.Point(82, 114);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("1", "Penjualan"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("2", "Retur"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("3", "Semua")});
            this.radioGroup1.Size = new System.Drawing.Size(249, 28);
            this.radioGroup1.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Persediaan";
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
            this.txtInvAkhir.Location = new System.Drawing.Point(223, 80);
            this.txtInvAkhir.Name = "txtInvAkhir";
            this.txtInvAkhir.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtInvAkhir.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtInvAkhir.Properties.Appearance.Options.UseBackColor = true;
            this.txtInvAkhir.Properties.Appearance.Options.UseForeColor = true;
            this.txtInvAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtInvAkhir.Size = new System.Drawing.Size(114, 20);
            this.txtInvAkhir.TabIndex = 34;
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
            this.txtInvAwal.Location = new System.Drawing.Point(82, 80);
            this.txtInvAwal.Name = "txtInvAwal";
            this.txtInvAwal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtInvAwal.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtInvAwal.Properties.Appearance.Options.UseBackColor = true;
            this.txtInvAwal.Properties.Appearance.Options.UseForeColor = true;
            this.txtInvAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtInvAwal.Size = new System.Drawing.Size(116, 20);
            this.txtInvAwal.TabIndex = 33;
            // 
            // textretawal
            // 
            this.textretawal.ExAllowEmptyString = true;
            this.textretawal.ExAllowNonDBData = false;
            this.textretawal.ExAutoCheck = true;
            this.textretawal.ExAutoShowResult = false;
            this.textretawal.ExCondition = "";
            this.textretawal.ExDialogTitle = "";
            this.textretawal.ExFieldName = "rkl";
            this.textretawal.ExFilterFields = new string[0];
            this.textretawal.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.textretawal.ExInvalidForeColor = System.Drawing.Color.Black;
            this.textretawal.ExLabelContainer = null;
            this.textretawal.ExLabelField = "remark";
            this.textretawal.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.textretawal.ExLabelText = "";
            this.textretawal.ExLabelVisible = false;
            this.textretawal.ExSelectFields = new string[0];
            this.textretawal.ExShowDialog = true;
            this.textretawal.ExSimpleMode = true;
            this.textretawal.ExSqlInstance = null;
            this.textretawal.ExSqlQuery = "select rkl,date,remark from rkl";
            this.textretawal.ExTableName = "rkl";
            this.textretawal.Location = new System.Drawing.Point(545, 53);
            this.textretawal.Name = "textretawal";
            this.textretawal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.textretawal.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.textretawal.Properties.Appearance.Options.UseBackColor = true;
            this.textretawal.Properties.Appearance.Options.UseForeColor = true;
            this.textretawal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.textretawal.Size = new System.Drawing.Size(100, 20);
            this.textretawal.TabIndex = 28;
            // 
            // textretakhir
            // 
            this.textretakhir.ExAllowEmptyString = true;
            this.textretakhir.ExAllowNonDBData = false;
            this.textretakhir.ExAutoCheck = true;
            this.textretakhir.ExAutoShowResult = false;
            this.textretakhir.ExCondition = "";
            this.textretakhir.ExDialogTitle = "";
            this.textretakhir.ExFieldName = "rkl";
            this.textretakhir.ExFilterFields = new string[0];
            this.textretakhir.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.textretakhir.ExInvalidForeColor = System.Drawing.Color.Black;
            this.textretakhir.ExLabelContainer = null;
            this.textretakhir.ExLabelField = "remark";
            this.textretakhir.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.textretakhir.ExLabelText = "";
            this.textretakhir.ExLabelVisible = false;
            this.textretakhir.ExSelectFields = new string[0];
            this.textretakhir.ExShowDialog = true;
            this.textretakhir.ExSimpleMode = true;
            this.textretakhir.ExSqlInstance = null;
            this.textretakhir.ExSqlQuery = "select rkl,date,remark from rkl";
            this.textretakhir.ExTableName = "rkl";
            this.textretakhir.Location = new System.Drawing.Point(670, 53);
            this.textretakhir.Name = "textretakhir";
            this.textretakhir.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.textretakhir.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.textretakhir.Properties.Appearance.Options.UseBackColor = true;
            this.textretakhir.Properties.Appearance.Options.UseForeColor = true;
            this.textretakhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.textretakhir.Size = new System.Drawing.Size(100, 20);
            this.textretakhir.TabIndex = 27;
            // 
            // textpjlawal
            // 
            this.textpjlawal.ExAllowEmptyString = true;
            this.textpjlawal.ExAllowNonDBData = false;
            this.textpjlawal.ExAutoCheck = true;
            this.textpjlawal.ExAutoShowResult = false;
            this.textpjlawal.ExCondition = "";
            this.textpjlawal.ExDialogTitle = "";
            this.textpjlawal.ExFieldName = "klr";
            this.textpjlawal.ExFilterFields = new string[0];
            this.textpjlawal.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.textpjlawal.ExInvalidForeColor = System.Drawing.Color.Black;
            this.textpjlawal.ExLabelContainer = null;
            this.textpjlawal.ExLabelField = "remark";
            this.textpjlawal.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.textpjlawal.ExLabelText = "";
            this.textpjlawal.ExLabelVisible = false;
            this.textpjlawal.ExSelectFields = new string[0];
            this.textpjlawal.ExShowDialog = true;
            this.textpjlawal.ExSimpleMode = true;
            this.textpjlawal.ExSqlInstance = null;
            this.textpjlawal.ExSqlQuery = "select klr,date,remark from klr";
            this.textpjlawal.ExTableName = "klr";
            this.textpjlawal.Location = new System.Drawing.Point(545, 20);
            this.textpjlawal.Name = "textpjlawal";
            this.textpjlawal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.textpjlawal.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.textpjlawal.Properties.Appearance.Options.UseBackColor = true;
            this.textpjlawal.Properties.Appearance.Options.UseForeColor = true;
            this.textpjlawal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.textpjlawal.Size = new System.Drawing.Size(100, 20);
            this.textpjlawal.TabIndex = 26;
            // 
            // textpjlakhir
            // 
            this.textpjlakhir.ExAllowEmptyString = true;
            this.textpjlakhir.ExAllowNonDBData = false;
            this.textpjlakhir.ExAutoCheck = true;
            this.textpjlakhir.ExAutoShowResult = false;
            this.textpjlakhir.ExCondition = "";
            this.textpjlakhir.ExDialogTitle = "";
            this.textpjlakhir.ExFieldName = "klr";
            this.textpjlakhir.ExFilterFields = new string[0];
            this.textpjlakhir.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.textpjlakhir.ExInvalidForeColor = System.Drawing.Color.Black;
            this.textpjlakhir.ExLabelContainer = null;
            this.textpjlakhir.ExLabelField = "remark";
            this.textpjlakhir.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.textpjlakhir.ExLabelText = "";
            this.textpjlakhir.ExLabelVisible = false;
            this.textpjlakhir.ExSelectFields = new string[0];
            this.textpjlakhir.ExShowDialog = true;
            this.textpjlakhir.ExSimpleMode = true;
            this.textpjlakhir.ExSqlInstance = null;
            this.textpjlakhir.ExSqlQuery = "select klr,date,remark from klr";
            this.textpjlakhir.ExTableName = "klr";
            this.textpjlakhir.Location = new System.Drawing.Point(670, 20);
            this.textpjlakhir.Name = "textpjlakhir";
            this.textpjlakhir.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.textpjlakhir.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.textpjlakhir.Properties.Appearance.Options.UseBackColor = true;
            this.textpjlakhir.Properties.Appearance.Options.UseForeColor = true;
            this.textpjlakhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.textpjlakhir.Size = new System.Drawing.Size(100, 20);
            this.textpjlakhir.TabIndex = 25;
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
            this.txtSubAkhir.ExSqlQuery = "Call SP_LookUp(\'customer\')";
            this.txtSubAkhir.ExTableName = "";
            this.txtSubAkhir.Location = new System.Drawing.Point(223, 47);
            this.txtSubAkhir.Name = "txtSubAkhir";
            this.txtSubAkhir.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtSubAkhir.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtSubAkhir.Properties.Appearance.Options.UseBackColor = true;
            this.txtSubAkhir.Properties.Appearance.Options.UseForeColor = true;
            this.txtSubAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtSubAkhir.Size = new System.Drawing.Size(114, 20);
            this.txtSubAkhir.TabIndex = 24;
            this.txtSubAkhir.EditValueChanged += new System.EventHandler(this.txtSubAkhir_EditValueChanged);
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
            this.txtSubAwal.ExSqlQuery = "Call SP_LookUp(\'customer\')";
            this.txtSubAwal.ExTableName = "";
            this.txtSubAwal.Location = new System.Drawing.Point(82, 47);
            this.txtSubAwal.Name = "txtSubAwal";
            this.txtSubAwal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtSubAwal.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtSubAwal.Properties.Appearance.Options.UseBackColor = true;
            this.txtSubAwal.Properties.Appearance.Options.UseForeColor = true;
            this.txtSubAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtSubAwal.Size = new System.Drawing.Size(114, 20);
            this.txtSubAwal.TabIndex = 23;
            this.txtSubAwal.EditValueChanged += new System.EventHandler(this.txtSubAwal_EditValueChanged);
            // 
            // FrmLKlrPerTanggal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 455);
            this.LookAndFeel.SkinName = "";
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.UseWindowsXPTheme = false;
            this.Name = "FrmLKlrPerTanggal";
            this.Text = "Penjualan / Tanggal";
            this.Load += new System.EventHandler(this.FrmLKlrPerTanggal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAwal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvAwal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textretawal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textretakhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textpjlawal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textpjlakhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubAwal.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KASLibrary.TextBoxEx txtSubAkhir;
        private KASLibrary.TextBoxEx txtSubAwal;
        private DevExpress.XtraEditors.DateEdit dtpTglAkhir;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit dtpTglAwal;
        private System.Windows.Forms.Label label2;
        private KASLibrary.TextBoxEx textpjlawal;
        private KASLibrary.TextBoxEx textpjlakhir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private KASLibrary.TextBoxEx textretawal;
        private KASLibrary.TextBoxEx textretakhir;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private System.Windows.Forms.Label label6;
        private KASLibrary.TextBoxEx txtInvAkhir;
        private KASLibrary.TextBoxEx txtInvAwal;
    }
}