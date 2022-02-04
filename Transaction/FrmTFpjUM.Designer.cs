namespace CAS.Transaction
{
    partial class FrmTFpjUM
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
            System.Windows.Forms.Label umkLabel;
            System.Windows.Forms.Label fpjdateLabel;
            System.Windows.Forms.Label nofpjLabel;
            System.Windows.Forms.Label fpgantiLabel1;
            System.Windows.Forms.Label label3;
            this.ctrlSub = new CAS.Transaction.CtrlSub();
            this.casDataSet = new CAS.casDataSet();
            this.fpjumkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fpjumkTableAdapter = new CAS.casDataSetTableAdapters.fpjumkTableAdapter();
            this.umkSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.fpjdateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.gcxFpjUM = new KASLibrary.GridControlEx();
            this.fpjumdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fpjumdTableAdapter = new CAS.casDataSetTableAdapters.fpjumdTableAdapter();
            this.maskfpj = new System.Windows.Forms.MaskedTextBox();
            this.remarkMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.fpgantiCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.jenis = new DevExpress.XtraEditors.RadioGroup();
            umkLabel = new System.Windows.Forms.Label();
            fpjdateLabel = new System.Windows.Forms.Label();
            nofpjLabel = new System.Windows.Forms.Label();
            fpgantiLabel1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludSeri.Properties)).BeginInit();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curkurs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curcur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpjumkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.umkSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpjdateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpjumdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenis.Properties)).BeginInit();
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
            this.pnlDetail.Controls.Add(label3);
            this.pnlDetail.Controls.Add(this.jenis);
            this.pnlDetail.Controls.Add(this.label2);
            this.pnlDetail.Controls.Add(fpgantiLabel1);
            this.pnlDetail.Controls.Add(this.fpgantiCheckBox);
            this.pnlDetail.Controls.Add(this.remarkMemoEdit);
            this.pnlDetail.Controls.Add(nofpjLabel);
            this.pnlDetail.Controls.Add(this.maskfpj);
            this.pnlDetail.Controls.Add(this.gcxFpjUM);
            this.pnlDetail.Controls.Add(fpjdateLabel);
            this.pnlDetail.Controls.Add(this.fpjdateDateEdit);
            this.pnlDetail.Controls.Add(umkLabel);
            this.pnlDetail.Controls.Add(this.umkSpinEdit);
            this.pnlDetail.Controls.Add(this.ctrlSub);
            this.pnlDetail.Size = new System.Drawing.Size(893, 507);
            this.pnlDetail.Controls.SetChildIndex(this.curLabel1, 0);
            this.pnlDetail.Controls.SetChildIndex(this.kursLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curkurs, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curcur, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateDate, 0);
            this.pnlDetail.Controls.SetChildIndex(this.ctrlSub, 0);
            this.pnlDetail.Controls.SetChildIndex(this.umkSpinEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(umkLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.fpjdateDateEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(fpjdateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.gcxFpjUM, 0);
            this.pnlDetail.Controls.SetChildIndex(this.maskfpj, 0);
            this.pnlDetail.Controls.SetChildIndex(nofpjLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.remarkMemoEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(this.fpgantiCheckBox, 0);
            this.pnlDetail.Controls.SetChildIndex(fpgantiLabel1, 0);
            this.pnlDetail.Controls.SetChildIndex(this.label2, 0);
            this.pnlDetail.Controls.SetChildIndex(this.jenis, 0);
            this.pnlDetail.Controls.SetChildIndex(label3, 0);
            // 
            // pnlKey
            // 
            this.pnlKey.Size = new System.Drawing.Size(893, 50);
            // 
            // dateDate
            // 
            this.dateDate.EditValue = new System.DateTime(((long)(0)));
            this.dateDate.Location = new System.Drawing.Point(520, 18);
            this.dateDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateDate.Properties.Mask.IgnoreMaskBlank = false;
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(468, 21);
            // 
            // curkurs
            // 
            this.curkurs.Location = new System.Drawing.Point(619, 44);
            // 
            // curcur
            // 
            this.curcur.Location = new System.Drawing.Point(520, 44);
            this.curcur.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.curcur.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.curcur.Properties.Appearance.Options.UseBackColor = true;
            this.curcur.Properties.Appearance.Options.UseForeColor = true;
            this.curcur.EditValueChanged += new System.EventHandler(this.curcur_EditValueChanged);
            // 
            // curLabel1
            // 
            this.curLabel1.Location = new System.Drawing.Point(489, 47);
            // 
            // kursLabel
            // 
            this.kursLabel.Location = new System.Drawing.Point(583, 47);
            // 
            // umkLabel
            // 
            umkLabel.AutoSize = true;
            umkLabel.Location = new System.Drawing.Point(616, 425);
            umkLabel.Name = "umkLabel";
            umkLabel.Size = new System.Drawing.Size(26, 13);
            umkLabel.TabIndex = 29;
            umkLabel.Text = "Nilai";
            // 
            // fpjdateLabel
            // 
            fpjdateLabel.AutoSize = true;
            fpjdateLabel.Location = new System.Drawing.Point(453, 73);
            fpjdateLabel.Name = "fpjdateLabel";
            fpjdateLabel.Size = new System.Drawing.Size(60, 13);
            fpjdateLabel.TabIndex = 30;
            fpjdateLabel.Text = "Tanggal FP";
            // 
            // nofpjLabel
            // 
            nofpjLabel.AutoSize = true;
            nofpjLabel.Location = new System.Drawing.Point(61, 12);
            nofpjLabel.Name = "nofpjLabel";
            nofpjLabel.Size = new System.Drawing.Size(35, 13);
            nofpjLabel.TabIndex = 32;
            nofpjLabel.Text = "No FP";
            // 
            // fpgantiLabel1
            // 
            fpgantiLabel1.AutoSize = true;
            fpgantiLabel1.Location = new System.Drawing.Point(387, 94);
            fpgantiLabel1.Name = "fpgantiLabel1";
            fpgantiLabel1.Size = new System.Drawing.Size(45, 13);
            fpgantiLabel1.TabIndex = 67;
            fpgantiLabel1.Text = "fpganti:";
            fpgantiLabel1.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(658, 15);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(94, 13);
            label3.TabIndex = 115;
            label3.Text = "Type Faktur Pajak";
            // 
            // ctrlSub
            // 
            this.ctrlSub.Location = new System.Drawing.Point(35, 38);
            this.ctrlSub.Name = "ctrlSub";
            this.ctrlSub.ReadOnly = true;
            this.ctrlSub.Size = new System.Drawing.Size(335, 115);
            this.ctrlSub.TabIndex = 29;
            this.ctrlSub.Type = CAS.Transaction.CtrlSub.SubType.Customer;
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fpjumkBindingSource
            // 
            this.fpjumkBindingSource.DataMember = "fpjumk";
            this.fpjumkBindingSource.DataSource = this.casDataSet;
            // 
            // fpjumkTableAdapter
            // 
            this.fpjumkTableAdapter.ClearBeforeFill = true;
            // 
            // umkSpinEdit
            // 
            this.umkSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.fpjumkBindingSource, "umk", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.umkSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.umkSpinEdit.Location = new System.Drawing.Point(648, 422);
            this.umkSpinEdit.Name = "umkSpinEdit";
            this.umkSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.umkSpinEdit.Properties.UseCtrlIncrement = false;
            this.umkSpinEdit.Size = new System.Drawing.Size(123, 20);
            this.umkSpinEdit.TabIndex = 30;
            // 
            // fpjdateDateEdit
            // 
            this.fpjdateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.fpjumkBindingSource, "fpjdate", true));
            this.fpjdateDateEdit.EditValue = null;
            this.fpjdateDateEdit.Location = new System.Drawing.Point(520, 70);
            this.fpjdateDateEdit.Name = "fpjdateDateEdit";
            this.fpjdateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fpjdateDateEdit.Size = new System.Drawing.Size(100, 23);
            this.fpjdateDateEdit.TabIndex = 31;
            // 
            // gcxFpjUM
            // 
            this.gcxFpjUM.BestFitColumn = true;
            this.gcxFpjUM.ExAutoSize = false;
            this.gcxFpjUM.Location = new System.Drawing.Point(12, 159);
            this.gcxFpjUM.Name = "gcxFpjUM";
            this.gcxFpjUM.Size = new System.Drawing.Size(759, 245);
            this.gcxFpjUM.TabIndex = 32;
            // 
            // fpjumdBindingSource
            // 
            this.fpjumdBindingSource.DataMember = "fpjumd";
            this.fpjumdBindingSource.DataSource = this.casDataSet;
            // 
            // fpjumdTableAdapter
            // 
            this.fpjumdTableAdapter.ClearBeforeFill = true;
            // 
            // maskfpj
            // 
            this.maskfpj.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fpjumkBindingSource, "nofpj", true));
            this.maskfpj.Location = new System.Drawing.Point(115, 12);
            this.maskfpj.Mask = "000.000-00.00000000";
            this.maskfpj.Name = "maskfpj";
            this.maskfpj.Size = new System.Drawing.Size(141, 20);
            this.maskfpj.TabIndex = 33;
            // 
            // remarkMemoEdit
            // 
            this.remarkMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fpjumkBindingSource, "remark", true));
            this.remarkMemoEdit.Location = new System.Drawing.Point(520, 112);
            this.remarkMemoEdit.Name = "remarkMemoEdit";
            this.remarkMemoEdit.Size = new System.Drawing.Size(229, 43);
            this.remarkMemoEdit.TabIndex = 67;
            // 
            // fpgantiCheckBox
            // 
            this.fpgantiCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.fpjumkBindingSource, "fpganti", true));
            this.fpgantiCheckBox.Location = new System.Drawing.Point(438, 89);
            this.fpgantiCheckBox.Name = "fpgantiCheckBox";
            this.fpgantiCheckBox.Size = new System.Drawing.Size(19, 24);
            this.fpgantiCheckBox.TabIndex = 68;
            this.fpgantiCheckBox.Visible = false;
            this.fpgantiCheckBox.CheckedChanged += new System.EventHandler(this.fpgantiCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(372, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 69;
            this.label2.Text = "Keterangan";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // jenis
            // 
            this.jenis.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.fpjumkBindingSource, "fpganti", true));
            this.jenis.Location = new System.Drawing.Point(758, 12);
            this.jenis.Name = "jenis";
            this.jenis.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "FPJ Uang Muka"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "FPJ Ganti"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "FPJ Standart"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "FPJ Jasa")});
            this.jenis.Size = new System.Drawing.Size(132, 95);
            this.jenis.TabIndex = 114;
            this.jenis.SelectedIndexChanged += new System.EventHandler(this.jenis_SelectedIndexChanged);
            // 
            // FrmTFpjUM
            // 
            this.ClientSize = new System.Drawing.Size(893, 637);
            this.DetailBindingSource = this.fpjumdBindingSource;
            this.DetailTable = this.casDataSet.fpjumd;
            this.MasterBindingSource = this.fpjumkBindingSource;
            this.MasterTable = this.casDataSet.fpjumk;
            this.Name = "FrmTFpjUM";
            this.Text = "Faktur Pajak Uang Muka";
            this.Load += new System.EventHandler(this.FrmTFpjUM_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.fpjumkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.umkSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpjdateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpjumdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenis.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CtrlSub ctrlSub;
        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource fpjumkBindingSource;
        private CAS.casDataSetTableAdapters.fpjumkTableAdapter fpjumkTableAdapter;
        private DevExpress.XtraEditors.DateEdit fpjdateDateEdit;
        private DevExpress.XtraEditors.SpinEdit umkSpinEdit;
        private KASLibrary.GridControlEx gcxFpjUM;
        private System.Windows.Forms.BindingSource fpjumdBindingSource;
        private CAS.casDataSetTableAdapters.fpjumdTableAdapter fpjumdTableAdapter;
        private System.Windows.Forms.MaskedTextBox maskfpj;
        private DevExpress.XtraEditors.MemoEdit remarkMemoEdit;
        private System.Windows.Forms.CheckBox fpgantiCheckBox;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.RadioGroup jenis;
    }
}
