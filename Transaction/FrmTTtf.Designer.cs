namespace CAS.Transaction
{
    partial class FrmTTtf
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
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label label6;
            this.casDataSet = new CAS.casDataSet();
            this.ttfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPeriod = new DevExpress.XtraEditors.TextEdit();
            this.txtNo = new DevExpress.XtraEditors.TextEdit();
            this.ludSeri = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.ttfTableAdapter = new CAS.casDataSetTableAdapters.ttfTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSub = new KASLibrary.TextBoxEx();
            this.titipTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.byrTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.jmlSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.kmbl_tglTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.lblDeleted = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.curcur = new KASLibrary.TextBoxEx();
            this.curcur1 = new KASLibrary.TextBoxEx();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.jns = new DevExpress.XtraEditors.RadioGroup();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateDate = new System.Windows.Forms.DateTimePicker();
            dateLabel = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttfBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludSeri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSub.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titipTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.byrTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jmlSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kmbl_tglTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curcur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curcur1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jns.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.dateDate);
            this.pnlDetail.Controls.Add(this.jns);
            this.pnlDetail.Controls.Add(this.button2);
            this.pnlDetail.Controls.Add(this.button1);
            this.pnlDetail.Controls.Add(this.label10);
            this.pnlDetail.Controls.Add(this.richTextBox1);
            this.pnlDetail.Controls.Add(this.label9);
            this.pnlDetail.Controls.Add(this.textEdit1);
            this.pnlDetail.Controls.Add(this.curcur1);
            this.pnlDetail.Controls.Add(this.curcur);
            this.pnlDetail.Controls.Add(this.spinEdit1);
            this.pnlDetail.Controls.Add(this.label8);
            this.pnlDetail.Controls.Add(label6);
            this.pnlDetail.Controls.Add(this.kmbl_tglTextEdit);
            this.pnlDetail.Controls.Add(this.jmlSpinEdit);
            this.pnlDetail.Controls.Add(dateLabel);
            this.pnlDetail.Controls.Add(this.byrTextEdit);
            this.pnlDetail.Controls.Add(this.titipTextEdit);
            this.pnlDetail.Controls.Add(this.txtSub);
            this.pnlDetail.Controls.Add(this.label7);
            this.pnlDetail.Controls.Add(this.label5);
            this.pnlDetail.Controls.Add(this.label4);
            this.pnlDetail.Controls.Add(this.label3);
            this.pnlDetail.Controls.Add(this.label2);
            this.pnlDetail.Size = new System.Drawing.Size(699, 384);
            this.pnlDetail.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDetail_Paint);
            // 
            // pnlKey
            // 
            this.pnlKey.Controls.Add(this.textBox1);
            this.pnlKey.Controls.Add(this.lblDeleted);
            this.pnlKey.Controls.Add(this.txtPeriod);
            this.pnlKey.Controls.Add(this.txtNo);
            this.pnlKey.Controls.Add(this.label1);
            this.pnlKey.Controls.Add(this.ludSeri);
            this.pnlKey.Size = new System.Drawing.Size(699, 56);
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(33, 82);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(52, 13);
            dateLabel.TabIndex = 172;
            dateLabel.Text = "Tanggal :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Tahoma", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            label6.ForeColor = System.Drawing.Color.Navy;
            label6.Location = new System.Drawing.Point(12, 16);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(155, 28);
            label6.TabIndex = 176;
            label6.Text = "P T .  K I A S";
            label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ttfBindingSource
            // 
            this.ttfBindingSource.DataMember = "ttf";
            this.ttfBindingSource.DataSource = this.casDataSet;
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(219, 18);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Properties.ReadOnly = true;
            this.txtPeriod.Size = new System.Drawing.Size(43, 20);
            this.txtPeriod.TabIndex = 14;
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(303, 18);
            this.txtNo.Name = "txtNo";
            this.txtNo.Properties.ReadOnly = true;
            this.txtNo.Size = new System.Drawing.Size(85, 20);
            this.txtNo.TabIndex = 15;
            this.txtNo.EditValueChanged += new System.EventHandler(this.txtNo_EditValueChanged);
            // 
            // ludSeri
            // 
            this.ludSeri.Location = new System.Drawing.Point(142, 18);
            this.ludSeri.Name = "ludSeri";
            this.ludSeri.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ludSeri.Properties.NullText = "???";
            this.ludSeri.Size = new System.Drawing.Size(71, 23);
            this.ludSeri.TabIndex = 13;
            this.ludSeri.EditValueChanged += new System.EventHandler(this.ludSeri_EditValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nomer";
            // 
            // ttfTableAdapter
            // 
            this.ttfTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 155;
            this.label7.Text = "Kembali Tgl";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 154;
            this.label5.Text = "Pembayaran";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 153;
            this.label4.Text = "Jumlah";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 152;
            this.label3.Text = "Titipan dari";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 151;
            this.label2.Text = "Terima dari";
            // 
            // txtSub
            // 
            this.txtSub.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ttfBindingSource, "sub", true));
            this.txtSub.ExAllowEmptyString = true;
            this.txtSub.ExAllowNonDBData = false;
            this.txtSub.ExAutoCheck = true;
            this.txtSub.ExAutoShowResult = false;
            this.txtSub.ExCondition = "";
            this.txtSub.ExDialogTitle = "";
            this.txtSub.ExFieldName = "sub";
            this.txtSub.ExFilterFields = new string[0];
            this.txtSub.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtSub.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtSub.ExLabelContainer = null;
            this.txtSub.ExLabelField = "name";
            this.txtSub.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.txtSub.ExLabelText = "";
            this.txtSub.ExLabelVisible = true;
            this.txtSub.ExSelectFields = new string[0];
            this.txtSub.ExShowDialog = true;
            this.txtSub.ExSimpleMode = true;
            this.txtSub.ExSqlInstance = null;
            this.txtSub.ExSqlQuery = "select sub, name from sub where group_= 1";
            this.txtSub.ExTableName = "sub";
            this.txtSub.Location = new System.Drawing.Point(142, 106);
            this.txtSub.Name = "txtSub";
            this.txtSub.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtSub.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtSub.Properties.Appearance.Options.UseBackColor = true;
            this.txtSub.Properties.Appearance.Options.UseForeColor = true;
            this.txtSub.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtSub.Size = new System.Drawing.Size(107, 20);
            this.txtSub.TabIndex = 167;
            this.txtSub.EditValueChanged += new System.EventHandler(this.txtSub_EditValueChanged);
            // 
            // titipTextEdit
            // 
            this.titipTextEdit.AllowDrop = true;
            this.titipTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ttfBindingSource, "titip", true));
            this.titipTextEdit.Location = new System.Drawing.Point(142, 161);
            this.titipTextEdit.Name = "titipTextEdit";
            this.titipTextEdit.Size = new System.Drawing.Size(291, 20);
            this.titipTextEdit.TabIndex = 168;
            this.titipTextEdit.EditValueChanged += new System.EventHandler(this.titipTextEdit_EditValueChanged);
            this.titipTextEdit.DragDrop += new System.Windows.Forms.DragEventHandler(this.titipTextEdit_DragDrop);
            this.titipTextEdit.DragEnter += new System.Windows.Forms.DragEventHandler(this.titipTextEdit_DragEnter);
            // 
            // byrTextEdit
            // 
            this.byrTextEdit.AllowDrop = true;
            this.byrTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ttfBindingSource, "byr", true));
            this.byrTextEdit.Location = new System.Drawing.Point(142, 282);
            this.byrTextEdit.Name = "byrTextEdit";
            this.byrTextEdit.Size = new System.Drawing.Size(291, 20);
            this.byrTextEdit.TabIndex = 170;
            this.byrTextEdit.DragDrop += new System.Windows.Forms.DragEventHandler(this.byrTextEdit_DragDrop);
            this.byrTextEdit.DragEnter += new System.Windows.Forms.DragEventHandler(this.byrTextEdit_DragEnter);
            // 
            // jmlSpinEdit
            // 
            this.jmlSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ttfBindingSource, "jml", true));
            this.jmlSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.jmlSpinEdit.Location = new System.Drawing.Point(219, 190);
            this.jmlSpinEdit.Name = "jmlSpinEdit";
            this.jmlSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.jmlSpinEdit.Properties.DisplayFormat.FormatString = "{0:n2}";
            this.jmlSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.jmlSpinEdit.Properties.UseCtrlIncrement = false;
            this.jmlSpinEdit.Size = new System.Drawing.Size(137, 20);
            this.jmlSpinEdit.TabIndex = 174;
            // 
            // kmbl_tglTextEdit
            // 
            this.kmbl_tglTextEdit.AllowDrop = true;
            this.kmbl_tglTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ttfBindingSource, "kmbl_tgl", true));
            this.kmbl_tglTextEdit.Location = new System.Drawing.Point(142, 308);
            this.kmbl_tglTextEdit.Name = "kmbl_tglTextEdit";
            this.kmbl_tglTextEdit.Properties.MaxLength = 50;
            this.kmbl_tglTextEdit.Size = new System.Drawing.Size(231, 20);
            this.kmbl_tglTextEdit.TabIndex = 175;
            this.kmbl_tglTextEdit.DragDrop += new System.Windows.Forms.DragEventHandler(this.kmbl_tglTextEdit_DragDrop);
            this.kmbl_tglTextEdit.DragEnter += new System.Windows.Forms.DragEventHandler(this.kmbl_tglTextEdit_DragEnter);
            // 
            // lblDeleted
            // 
            this.lblDeleted.AutoSize = true;
            this.lblDeleted.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDeleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleted.ForeColor = System.Drawing.Color.Red;
            this.lblDeleted.Location = new System.Drawing.Point(445, 15);
            this.lblDeleted.Name = "lblDeleted";
            this.lblDeleted.Size = new System.Drawing.Size(81, 19);
            this.lblDeleted.TabIndex = 16;
            this.lblDeleted.Text = "DELETED";
            this.lblDeleted.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 177;
            this.label8.Text = "Supplier One Time";
            // 
            // spinEdit1
            // 
            this.spinEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ttfBindingSource, "jml2", true));
            this.spinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(219, 216);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEdit1.Properties.DisplayFormat.FormatString = "{0:n2}";
            this.spinEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinEdit1.Properties.UseCtrlIncrement = false;
            this.spinEdit1.Size = new System.Drawing.Size(137, 20);
            this.spinEdit1.TabIndex = 178;
            // 
            // curcur
            // 
            this.curcur.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ttfBindingSource, "cur1", true));
            this.curcur.EditValue = "IDR";
            this.curcur.ExAllowEmptyString = true;
            this.curcur.ExAllowNonDBData = false;
            this.curcur.ExAutoCheck = false;
            this.curcur.ExAutoShowResult = false;
            this.curcur.ExCondition = "";
            this.curcur.ExDialogTitle = "Currency";
            this.curcur.ExFieldName = "cur";
            this.curcur.ExFilterFields = new string[0];
            this.curcur.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.curcur.ExInvalidForeColor = System.Drawing.Color.Black;
            this.curcur.ExLabelContainer = null;
            this.curcur.ExLabelField = "";
            this.curcur.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.curcur.ExLabelText = "";
            this.curcur.ExLabelVisible = false;
            this.curcur.ExSelectFields = new string[] {
        "cur",
        "name"};
            this.curcur.ExShowDialog = true;
            this.curcur.ExSimpleMode = true;
            this.curcur.ExSqlInstance = null;
            this.curcur.ExSqlQuery = "select cur,name from cur";
            this.curcur.ExTableName = "cur";
            this.curcur.Location = new System.Drawing.Point(142, 190);
            this.curcur.Name = "curcur";
            this.curcur.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.curcur.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.curcur.Properties.Appearance.Options.UseBackColor = true;
            this.curcur.Properties.Appearance.Options.UseForeColor = true;
            this.curcur.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.curcur.Size = new System.Drawing.Size(57, 20);
            this.curcur.TabIndex = 179;
            // 
            // curcur1
            // 
            this.curcur1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ttfBindingSource, "cur2", true));
            this.curcur1.EditValue = "IDR";
            this.curcur1.ExAllowEmptyString = true;
            this.curcur1.ExAllowNonDBData = false;
            this.curcur1.ExAutoCheck = false;
            this.curcur1.ExAutoShowResult = false;
            this.curcur1.ExCondition = "";
            this.curcur1.ExDialogTitle = "Currency";
            this.curcur1.ExFieldName = "cur";
            this.curcur1.ExFilterFields = new string[0];
            this.curcur1.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.curcur1.ExInvalidForeColor = System.Drawing.Color.Black;
            this.curcur1.ExLabelContainer = null;
            this.curcur1.ExLabelField = "";
            this.curcur1.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.curcur1.ExLabelText = "";
            this.curcur1.ExLabelVisible = false;
            this.curcur1.ExSelectFields = new string[] {
        "cur",
        "name"};
            this.curcur1.ExShowDialog = true;
            this.curcur1.ExSimpleMode = true;
            this.curcur1.ExSqlInstance = null;
            this.curcur1.ExSqlQuery = "select cur,name from cur";
            this.curcur1.ExTableName = "cur";
            this.curcur1.Location = new System.Drawing.Point(142, 216);
            this.curcur1.Name = "curcur1";
            this.curcur1.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.curcur1.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.curcur1.Properties.Appearance.Options.UseBackColor = true;
            this.curcur1.Properties.Appearance.Options.UseForeColor = true;
            this.curcur1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.curcur1.Size = new System.Drawing.Size(57, 20);
            this.curcur1.TabIndex = 180;
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ttfBindingSource, "unsub", true));
            this.textEdit1.Location = new System.Drawing.Point(142, 132);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(291, 20);
            this.textEdit1.TabIndex = 181;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 183;
            this.label9.Text = "Keterangan";
            // 
            // richTextBox1
            // 
            this.richTextBox1.EnableAutoDragDrop = true;
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.richTextBox1.Location = new System.Drawing.Point(458, 37);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(229, 315);
            this.richTextBox1.TabIndex = 184;
            this.richTextBox1.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(455, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 185;
            this.label10.Text = "Notes";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(545, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 186;
            this.button1.Text = "Save Note";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(317, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 187;
            this.button2.Text = "Print Directly";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // jns
            // 
            this.jns.Location = new System.Drawing.Point(142, 249);
            this.jns.Name = "jns";
            this.jns.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "GIRO"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "CEK"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "TUNAI"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "TRANSFER")});
            this.jns.Size = new System.Drawing.Size(291, 27);
            this.jns.TabIndex = 188;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(273, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(24, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateDate
            // 
            this.dateDate.CustomFormat = "dd/MM/yyyy";
            this.dateDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ttfBindingSource, "date", true));
            this.dateDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDate.Location = new System.Drawing.Point(142, 75);
            this.dateDate.Name = "dateDate";
            this.dateDate.Size = new System.Drawing.Size(86, 20);
            this.dateDate.TabIndex = 189;
            this.dateDate.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // FrmTTtf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 532);
            this.MasterBindingSource = this.ttfBindingSource;
            this.MasterQuery = "select * from ttf";
            this.MasterTable = this.casDataSet.ttf;
            this.Name = "FrmTTtf";
            this.Text = "TTF";
            this.Load += new System.EventHandler(this.FrmTTtf_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmTTtf_FormClosed);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.pnlKey.ResumeLayout(false);
            this.pnlKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttfBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludSeri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSub.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titipTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.byrTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jmlSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kmbl_tglTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curcur.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curcur1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jns.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected DevExpress.XtraEditors.TextEdit txtPeriod;
        protected DevExpress.XtraEditors.TextEdit txtNo;
        protected System.Windows.Forms.Label label1;
        protected DevExpress.XtraEditors.LookUpEdit ludSeri;
        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource ttfBindingSource;
        private CAS.casDataSetTableAdapters.ttfTableAdapter ttfTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private KASLibrary.TextBoxEx txtSub;
        private DevExpress.XtraEditors.TextEdit byrTextEdit;
        private DevExpress.XtraEditors.TextEdit titipTextEdit;
        private DevExpress.XtraEditors.SpinEdit jmlSpinEdit;
        private DevExpress.XtraEditors.TextEdit kmbl_tglTextEdit;
        protected System.Windows.Forms.Label lblDeleted;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        protected KASLibrary.TextBoxEx curcur1;
        protected KASLibrary.TextBoxEx curcur;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private DevExpress.XtraEditors.RadioGroup jns;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateDate;
    }
}