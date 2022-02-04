namespace CAS.Transaction
{
    partial class FrmTLpbRetur
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
            System.Windows.Forms.Label noreturLabel;
            System.Windows.Forms.Label remarkLabel;
            System.Windows.Forms.Label nopolLabel;
            System.Windows.Forms.Label docLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label duedateLabel;
            System.Windows.Forms.Label tglproformaLabel;
            this.casDataSet = new CAS.casDataSet();
            this.rkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rkaTableAdapter = new CAS.casDataSetTableAdapters.rkaTableAdapter();
            this.ctrlSub = new CAS.Transaction.CtrlSub();
            this.sprTextBoxEx = new KASLibrary.TextBoxEx();
            this.rsmTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.linkToForm1 = new CAS.linkToForm();
            this.linkToForm2 = new CAS.linkToForm();
            this.noreturTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.remarkMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.rkbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rkbTableAdapter = new CAS.casDataSetTableAdapters.rkbTableAdapter();
            this.gcxRkb = new KASLibrary.GridControlEx();
            this.nopolTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.docTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.jnspaTextBoxEx = new KASLibrary.TextBoxEx();
            this.sprTableAdapter = new CAS.casDataSetTableAdapters.sprTableAdapter();
            this.duedateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.tglbc = new DevExpress.XtraEditors.DateEdit();
            noreturLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            nopolLabel = new System.Windows.Forms.Label();
            docLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            duedateLabel = new System.Windows.Forms.Label();
            tglproformaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludSeri.Properties)).BeginInit();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curkurs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curcur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsmTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noreturTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rkbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nopolTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jnspaTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duedateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglbc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNo
            // 
            // 
            // txtPeriod
            // 
            // 
            // ludSeri
            // 
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(tglproformaLabel);
            this.pnlDetail.Controls.Add(this.tglbc);
            this.pnlDetail.Controls.Add(duedateLabel);
            this.pnlDetail.Controls.Add(this.duedateDateEdit);
            this.pnlDetail.Controls.Add(docLabel);
            this.pnlDetail.Controls.Add(this.docTextEdit);
            this.pnlDetail.Controls.Add(label2);
            this.pnlDetail.Controls.Add(this.jnspaTextBoxEx);
            this.pnlDetail.Controls.Add(nopolLabel);
            this.pnlDetail.Controls.Add(this.nopolTextEdit);
            this.pnlDetail.Controls.Add(this.gcxRkb);
            this.pnlDetail.Controls.Add(remarkLabel);
            this.pnlDetail.Controls.Add(this.remarkMemoEdit);
            this.pnlDetail.Controls.Add(noreturLabel);
            this.pnlDetail.Controls.Add(this.noreturTextEdit);
            this.pnlDetail.Controls.Add(this.linkToForm2);
            this.pnlDetail.Controls.Add(this.linkToForm1);
            this.pnlDetail.Controls.Add(this.rsmTextEdit);
            this.pnlDetail.Controls.Add(this.sprTextBoxEx);
            this.pnlDetail.Controls.Add(this.ctrlSub);
            this.pnlDetail.Size = new System.Drawing.Size(819, 428);
            this.pnlDetail.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDetail_Paint);
            this.pnlDetail.Controls.SetChildIndex(this.dateDate, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curcur, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curkurs, 0);
            this.pnlDetail.Controls.SetChildIndex(this.kursLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curLabel1, 0);
            this.pnlDetail.Controls.SetChildIndex(this.ctrlSub, 0);
            this.pnlDetail.Controls.SetChildIndex(this.sprTextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(this.rsmTextEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(this.linkToForm1, 0);
            this.pnlDetail.Controls.SetChildIndex(this.linkToForm2, 0);
            this.pnlDetail.Controls.SetChildIndex(this.noreturTextEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(noreturLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.remarkMemoEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(remarkLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.gcxRkb, 0);
            this.pnlDetail.Controls.SetChildIndex(this.nopolTextEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(nopolLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.jnspaTextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(label2, 0);
            this.pnlDetail.Controls.SetChildIndex(this.docTextEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(docLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.duedateDateEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(duedateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.tglbc, 0);
            this.pnlDetail.Controls.SetChildIndex(tglproformaLabel, 0);
            // 
            // pnlKey
            // 
            this.pnlKey.Size = new System.Drawing.Size(819, 50);
            // 
            // dateDate
            // 
            this.dateDate.EditValue = new System.DateTime(((long)(0)));
            this.dateDate.Location = new System.Drawing.Point(442, 10);
            this.dateDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateDate.Properties.Mask.IgnoreMaskBlank = false;
            this.dateDate.EditValueChanged += new System.EventHandler(this.dateDate_EditValueChanged);
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(390, 13);
            // 
            // curkurs
            // 
            this.curkurs.Location = new System.Drawing.Point(541, 36);
            this.curkurs.Visible = false;
            // 
            // curcur
            // 
            this.curcur.Location = new System.Drawing.Point(442, 36);
            this.curcur.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.curcur.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.curcur.Properties.Appearance.Options.UseBackColor = true;
            this.curcur.Properties.Appearance.Options.UseForeColor = true;
            this.curcur.Visible = false;
            // 
            // curLabel1
            // 
            this.curLabel1.Location = new System.Drawing.Point(411, 39);
            this.curLabel1.Visible = false;
            // 
            // kursLabel
            // 
            this.kursLabel.Location = new System.Drawing.Point(505, 39);
            this.kursLabel.Visible = false;
            // 
            // btnDocFlow
            // 
            this.btnDocFlow.Visible = true;
            // 
            // noreturLabel
            // 
            noreturLabel.AutoSize = true;
            noreturLabel.Location = new System.Drawing.Point(16, 159);
            noreturLabel.Name = "noreturLabel";
            noreturLabel.Size = new System.Drawing.Size(67, 13);
            noreturLabel.TabIndex = 85;
            noreturLabel.Text = "No SO Retur";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(374, 115);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(63, 13);
            remarkLabel.TabIndex = 86;
            remarkLabel.Text = "Keterangan";
            // 
            // nopolLabel
            // 
            nopolLabel.AutoSize = true;
            nopolLabel.Location = new System.Drawing.Point(388, 65);
            nopolLabel.Name = "nopolLabel";
            nopolLabel.Size = new System.Drawing.Size(46, 13);
            nopolLabel.TabIndex = 88;
            nopolLabel.Text = "No Polisi";
            // 
            // docLabel
            // 
            docLabel.AutoSize = true;
            docLabel.Location = new System.Drawing.Point(546, 171);
            docLabel.Name = "docLabel";
            docLabel.Size = new System.Drawing.Size(41, 13);
            docLabel.TabIndex = 141;
            docLabel.Text = "No Doc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(380, 171);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(52, 13);
            label2.TabIndex = 140;
            label2.Text = "Jenis Doc";
            // 
            // duedateLabel
            // 
            duedateLabel.AutoSize = true;
            duedateLabel.Location = new System.Drawing.Point(711, 144);
            duedateLabel.Name = "duedateLabel";
            duedateLabel.Size = new System.Drawing.Size(95, 13);
            duedateLabel.TabIndex = 142;
            duedateLabel.Text = "Tgl Doc Pelabuhan";
            // 
            // tglproformaLabel
            // 
            tglproformaLabel.AutoSize = true;
            tglproformaLabel.Location = new System.Drawing.Point(600, 13);
            tglproformaLabel.Name = "tglproformaLabel";
            tglproformaLabel.Size = new System.Drawing.Size(101, 13);
            tglproformaLabel.TabIndex = 144;
            tglproformaLabel.Text = "Tgl Rekam Beacukai";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rkaBindingSource
            // 
            this.rkaBindingSource.DataMember = "rka";
            this.rkaBindingSource.DataSource = this.casDataSet;
            // 
            // rkaTableAdapter
            // 
            this.rkaTableAdapter.ClearBeforeFill = true;
            // 
            // ctrlSub
            // 
            this.ctrlSub.Location = new System.Drawing.Point(15, 35);
            this.ctrlSub.Name = "ctrlSub";
            this.ctrlSub.ReadOnly = true;
            this.ctrlSub.Size = new System.Drawing.Size(335, 115);
            this.ctrlSub.TabIndex = 81;
            this.ctrlSub.Tag = "ReadOnly";
            this.ctrlSub.Type = CAS.Transaction.CtrlSub.SubType.Customer;
            // 
            // sprTextBoxEx
            // 
            this.sprTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rkaBindingSource, "spr", true));
            this.sprTextBoxEx.ExAllowEmptyString = true;
            this.sprTextBoxEx.ExAllowNonDBData = false;
            this.sprTextBoxEx.ExAutoCheck = true;
            this.sprTextBoxEx.ExAutoShowResult = false;
            this.sprTextBoxEx.ExCondition = "";
            this.sprTextBoxEx.ExDialogTitle = "";
            this.sprTextBoxEx.ExFieldName = "SPB Retur";
            this.sprTextBoxEx.ExFilterFields = new string[0];
            this.sprTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.sprTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.sprTextBoxEx.ExLabelContainer = null;
            this.sprTextBoxEx.ExLabelField = "";
            this.sprTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.sprTextBoxEx.ExLabelText = "";
            this.sprTextBoxEx.ExLabelVisible = false;
            this.sprTextBoxEx.ExSelectFields = new string[0];
            this.sprTextBoxEx.ExShowDialog = true;
            this.sprTextBoxEx.ExSimpleMode = false;
            this.sprTextBoxEx.ExSqlInstance = null;
            this.sprTextBoxEx.ExSqlQuery = "Call SP_SelectSPBReturforLPBRetur()";
            this.sprTextBoxEx.ExTableName = "spr";
            this.sprTextBoxEx.Location = new System.Drawing.Point(79, 11);
            this.sprTextBoxEx.Name = "sprTextBoxEx";
            this.sprTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.sprTextBoxEx.Size = new System.Drawing.Size(145, 20);
            this.sprTextBoxEx.TabIndex = 82;
            this.sprTextBoxEx.EditValueChanged += new System.EventHandler(this.sprTextBoxEx_EditValueChanged);
            this.sprTextBoxEx.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.sprTextBoxEx_ButtonPressed);
            // 
            // rsmTextEdit
            // 
            this.rsmTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rkaBindingSource, "rsm", true));
            this.rsmTextEdit.Location = new System.Drawing.Point(98, 156);
            this.rsmTextEdit.Name = "rsmTextEdit";
            this.rsmTextEdit.Properties.ReadOnly = true;
            this.rsmTextEdit.Size = new System.Drawing.Size(145, 20);
            this.rsmTextEdit.TabIndex = 83;
            // 
            // linkToForm1
            // 
            this.linkToForm1.AutoSize = true;
            this.linkToForm1.FormName = "FrmTSpbRetur";
            this.linkToForm1.Location = new System.Drawing.Point(16, 14);
            this.linkToForm1.Name = "linkToForm1";
            this.linkToForm1.Size = new System.Drawing.Size(55, 13);
            this.linkToForm1.TabIndex = 84;
            this.linkToForm1.TabStop = true;
            this.linkToForm1.Text = "SPB Retur";
            this.linkToForm1.TxtKode = this.sprTextBoxEx;
            // 
            // linkToForm2
            // 
            this.linkToForm2.AutoSize = true;
            this.linkToForm2.FormName = "FrmTSORetur";
            this.linkToForm2.Location = new System.Drawing.Point(10, 185);
            this.linkToForm2.Name = "linkToForm2";
            this.linkToForm2.Size = new System.Drawing.Size(82, 13);
            this.linkToForm2.TabIndex = 85;
            this.linkToForm2.TabStop = true;
            this.linkToForm2.Text = "No. SJ di Retur ";
            this.linkToForm2.TxtKode = this.rsmTextEdit;
            // 
            // noreturTextEdit
            // 
            this.noreturTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rkaBindingSource, "noretur", true));
            this.noreturTextEdit.Location = new System.Drawing.Point(98, 182);
            this.noreturTextEdit.Name = "noreturTextEdit";
            this.noreturTextEdit.Size = new System.Drawing.Size(116, 20);
            this.noreturTextEdit.TabIndex = 86;
            // 
            // remarkMemoEdit
            // 
            this.remarkMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rkaBindingSource, "remark", true));
            this.remarkMemoEdit.Location = new System.Drawing.Point(442, 113);
            this.remarkMemoEdit.Name = "remarkMemoEdit";
            this.remarkMemoEdit.Size = new System.Drawing.Size(214, 49);
            this.remarkMemoEdit.TabIndex = 87;
            // 
            // rkbBindingSource
            // 
            this.rkbBindingSource.DataMember = "rkb";
            this.rkbBindingSource.DataSource = this.casDataSet;
            // 
            // rkbTableAdapter
            // 
            this.rkbTableAdapter.ClearBeforeFill = true;
            // 
            // gcxRkb
            // 
            this.gcxRkb.BestFitColumn = true;
            this.gcxRkb.ExAutoSize = false;
            this.gcxRkb.Location = new System.Drawing.Point(15, 208);
            this.gcxRkb.Name = "gcxRkb";
            this.gcxRkb.Size = new System.Drawing.Size(783, 188);
            this.gcxRkb.TabIndex = 88;
            // 
            // nopolTextEdit
            // 
            this.nopolTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rkaBindingSource, "nopol", true));
            this.nopolTextEdit.Location = new System.Drawing.Point(442, 62);
            this.nopolTextEdit.Name = "nopolTextEdit";
            this.nopolTextEdit.Size = new System.Drawing.Size(137, 20);
            this.nopolTextEdit.TabIndex = 89;
            // 
            // docTextEdit
            // 
            this.docTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rkaBindingSource, "doc", true));
            this.docTextEdit.Location = new System.Drawing.Point(589, 168);
            this.docTextEdit.Name = "docTextEdit";
            this.docTextEdit.Size = new System.Drawing.Size(100, 20);
            this.docTextEdit.TabIndex = 142;
            // 
            // jnspaTextBoxEx
            // 
            this.jnspaTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rkaBindingSource, "jnsdoc", true));
            this.jnspaTextBoxEx.ExAllowEmptyString = true;
            this.jnspaTextBoxEx.ExAllowNonDBData = false;
            this.jnspaTextBoxEx.ExAutoCheck = true;
            this.jnspaTextBoxEx.ExAutoShowResult = false;
            this.jnspaTextBoxEx.ExCondition = "";
            this.jnspaTextBoxEx.ExDialogTitle = "";
            this.jnspaTextBoxEx.ExFieldName = "jnsp";
            this.jnspaTextBoxEx.ExFilterFields = new string[0];
            this.jnspaTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.jnspaTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.jnspaTextBoxEx.ExLabelContainer = null;
            this.jnspaTextBoxEx.ExLabelField = "jnsp";
            this.jnspaTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.jnspaTextBoxEx.ExLabelText = "";
            this.jnspaTextBoxEx.ExLabelVisible = false;
            this.jnspaTextBoxEx.ExSelectFields = new string[0];
            this.jnspaTextBoxEx.ExShowDialog = true;
            this.jnspaTextBoxEx.ExSimpleMode = true;
            this.jnspaTextBoxEx.ExSqlInstance = null;
            this.jnspaTextBoxEx.ExSqlQuery = "select * from jnsp";
            this.jnspaTextBoxEx.ExTableName = "";
            this.jnspaTextBoxEx.Location = new System.Drawing.Point(440, 168);
            this.jnspaTextBoxEx.Name = "jnspaTextBoxEx";
            this.jnspaTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.jnspaTextBoxEx.Size = new System.Drawing.Size(100, 20);
            this.jnspaTextBoxEx.TabIndex = 139;
            // 
            // sprTableAdapter
            // 
            this.sprTableAdapter.ClearBeforeFill = true;
            // 
            // duedateDateEdit
            // 
            this.duedateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rkaBindingSource, "duedate", true));
            this.duedateDateEdit.EditValue = null;
            this.duedateDateEdit.Location = new System.Drawing.Point(712, 165);
            this.duedateDateEdit.Name = "duedateDateEdit";
            this.duedateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.duedateDateEdit.Size = new System.Drawing.Size(100, 23);
            this.duedateDateEdit.TabIndex = 143;
            // 
            // tglbc
            // 
            this.tglbc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rkaBindingSource, "tgl_bc", true));
            this.tglbc.EditValue = null;
            this.tglbc.Location = new System.Drawing.Point(707, 9);
            this.tglbc.Name = "tglbc";
            this.tglbc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tglbc.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.tglbc.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.tglbc.Properties.EditFormat.FormatString = "d";
            this.tglbc.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.tglbc.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.tglbc.Size = new System.Drawing.Size(100, 23);
            this.tglbc.TabIndex = 145;
            // 
            // FrmTLpbRetur
            // 
            this.ClientSize = new System.Drawing.Size(819, 558);
            this.DetailBindingSource = this.rkbBindingSource;
            this.DetailTable = this.casDataSet.rkb;
            this.MasterBindingSource = this.rkaBindingSource;
            this.MasterTable = this.casDataSet.rka;
            this.Name = "FrmTLpbRetur";
            this.Load += new System.EventHandler(this.FrmTLpbRetur_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.rkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsmTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noreturTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rkbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nopolTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jnspaTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duedateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglbc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource rkaBindingSource;
        private CAS.casDataSetTableAdapters.rkaTableAdapter rkaTableAdapter;
        private KASLibrary.TextBoxEx sprTextBoxEx;
        private CtrlSub ctrlSub;
        private linkToForm linkToForm2;
        private linkToForm linkToForm1;
        private DevExpress.XtraEditors.TextEdit rsmTextEdit;
        private DevExpress.XtraEditors.MemoEdit remarkMemoEdit;
        private DevExpress.XtraEditors.TextEdit noreturTextEdit;
        private System.Windows.Forms.BindingSource rkbBindingSource;
        private CAS.casDataSetTableAdapters.rkbTableAdapter rkbTableAdapter;
        private KASLibrary.GridControlEx gcxRkb;
        private DevExpress.XtraEditors.TextEdit nopolTextEdit;
        private DevExpress.XtraEditors.TextEdit docTextEdit;
        private KASLibrary.TextBoxEx jnspaTextBoxEx;
        private CAS.casDataSetTableAdapters.sprTableAdapter sprTableAdapter;
        private DevExpress.XtraEditors.DateEdit duedateDateEdit;
        private DevExpress.XtraEditors.DateEdit tglbc;
    }
}
