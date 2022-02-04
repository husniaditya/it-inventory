namespace CAS.Transaction
{
    partial class FrmTLpb
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
            System.Windows.Forms.Label nopolLabel;
            System.Windows.Forms.Label remarkLabel1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label bsaLabel;
            this.lphBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casDataSet = new CAS.casDataSet();
            this.nopolTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.remarkMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.gcLpd = new KASLibrary.GridControlEx();
            this.omsTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.spbTextBoxEx = new KASLibrary.TextBoxEx();
            this.lpdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lphTableAdapter = new CAS.casDataSetTableAdapters.lphTableAdapter();
            this.ctrlSub = new CAS.Transaction.CtrlSub();
            this.linkToOms = new CAS.linkToForm();
            this.linkToSpb = new CAS.linkToForm();
            this.textEditPList = new DevExpress.XtraEditors.TextEdit();
            this.textEditNoCont = new DevExpress.XtraEditors.TextEdit();
            this.bsaTextBoxEx = new KASLibrary.TextBoxEx();
            nopolLabel = new System.Windows.Forms.Label();
            remarkLabel1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            bsaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludSeri.Properties)).BeginInit();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curkurs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curcur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lphBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nopolTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.omsTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spbTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lpdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPList.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNoCont.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsaTextBoxEx.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(206, 19);
            this.txtNo.Size = new System.Drawing.Size(85, 26);
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(157, 19);
            this.txtPeriod.Size = new System.Drawing.Size(43, 26);
            // 
            // ludSeri
            // 
            this.ludSeri.Location = new System.Drawing.Point(80, 19);
            this.ludSeri.Size = new System.Drawing.Size(71, 26);
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(bsaLabel);
            this.pnlDetail.Controls.Add(this.bsaTextBoxEx);
            this.pnlDetail.Controls.Add(label3);
            this.pnlDetail.Controls.Add(this.textEditNoCont);
            this.pnlDetail.Controls.Add(label2);
            this.pnlDetail.Controls.Add(this.textEditPList);
            this.pnlDetail.Controls.Add(this.linkToSpb);
            this.pnlDetail.Controls.Add(this.linkToOms);
            this.pnlDetail.Controls.Add(this.ctrlSub);
            this.pnlDetail.Controls.Add(this.spbTextBoxEx);
            this.pnlDetail.Controls.Add(this.omsTextEdit);
            this.pnlDetail.Controls.Add(this.gcLpd);
            this.pnlDetail.Controls.Add(remarkLabel1);
            this.pnlDetail.Controls.Add(this.remarkMemoEdit);
            this.pnlDetail.Controls.Add(nopolLabel);
            this.pnlDetail.Controls.Add(this.nopolTextEdit);
            this.pnlDetail.Location = new System.Drawing.Point(0, 88);
            this.pnlDetail.Size = new System.Drawing.Size(712, 398);
            this.pnlDetail.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDetail_Paint);
            this.pnlDetail.Controls.SetChildIndex(this.dateDate, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curcur, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curkurs, 0);
            this.pnlDetail.Controls.SetChildIndex(this.kursLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curLabel1, 0);
            this.pnlDetail.Controls.SetChildIndex(this.nopolTextEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(nopolLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.remarkMemoEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(remarkLabel1, 0);
            this.pnlDetail.Controls.SetChildIndex(this.gcLpd, 0);
            this.pnlDetail.Controls.SetChildIndex(this.omsTextEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(this.spbTextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(this.ctrlSub, 0);
            this.pnlDetail.Controls.SetChildIndex(this.linkToOms, 0);
            this.pnlDetail.Controls.SetChildIndex(this.linkToSpb, 0);
            this.pnlDetail.Controls.SetChildIndex(this.textEditPList, 0);
            this.pnlDetail.Controls.SetChildIndex(label2, 0);
            this.pnlDetail.Controls.SetChildIndex(this.textEditNoCont, 0);
            this.pnlDetail.Controls.SetChildIndex(label3, 0);
            this.pnlDetail.Controls.SetChildIndex(this.bsaTextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(bsaLabel, 0);
            // 
            // pnlKey
            // 
            this.pnlKey.Size = new System.Drawing.Size(712, 56);
            // 
            // dateDate
            // 
            this.dateDate.EditValue = new System.DateTime(((long)(0)));
            this.dateDate.Location = new System.Drawing.Point(430, 6);
            this.dateDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateDate.Properties.Mask.IgnoreMaskBlank = false;
            this.dateDate.Size = new System.Drawing.Size(100, 26);
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(378, 9);
            // 
            // curkurs
            // 
            this.curkurs.Location = new System.Drawing.Point(529, 32);
            this.curkurs.Visible = false;
            // 
            // curcur
            // 
            this.curcur.Location = new System.Drawing.Point(430, 32);
            this.curcur.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.curcur.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.curcur.Properties.Appearance.Options.UseBackColor = true;
            this.curcur.Properties.Appearance.Options.UseForeColor = true;
            this.curcur.Size = new System.Drawing.Size(57, 26);
            this.curcur.Visible = false;
            // 
            // curLabel1
            // 
            this.curLabel1.Location = new System.Drawing.Point(399, 35);
            this.curLabel1.Visible = false;
            // 
            // kursLabel
            // 
            this.kursLabel.Location = new System.Drawing.Point(493, 35);
            this.kursLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(36, 22);
            // 
            // btnDocFlow
            // 
            this.btnDocFlow.Location = new System.Drawing.Point(558, 16);
            this.btnDocFlow.Visible = true;
            // 
            // nopolLabel
            // 
            nopolLabel.AutoSize = true;
            nopolLabel.Location = new System.Drawing.Point(373, 120);
            nopolLabel.Name = "nopolLabel";
            nopolLabel.Size = new System.Drawing.Size(76, 19);
            nopolLabel.TabIndex = 52;
            nopolLabel.Text = "No. Polisi";
            // 
            // remarkLabel1
            // 
            remarkLabel1.AutoSize = true;
            remarkLabel1.Location = new System.Drawing.Point(363, 144);
            remarkLabel1.Name = "remarkLabel1";
            remarkLabel1.Size = new System.Drawing.Size(88, 19);
            remarkLabel1.TabIndex = 75;
            remarkLabel1.Text = "Keterangan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(361, 64);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(92, 19);
            label2.TabIndex = 86;
            label2.Text = "Packing List";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(353, 90);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(102, 19);
            label3.TabIndex = 88;
            label3.Text = "No Container";
            label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bsaLabel
            // 
            bsaLabel.AutoSize = true;
            bsaLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            bsaLabel.ForeColor = System.Drawing.Color.Red;
            bsaLabel.Location = new System.Drawing.Point(3, 5);
            bsaLabel.Name = "bsaLabel";
            bsaLabel.Size = new System.Drawing.Size(105, 21);
            bsaLabel.TabIndex = 137;
            bsaLabel.Text = "Bisnis Area";
            // 
            // lphBindingSource
            // 
            this.lphBindingSource.DataMember = "lph";
            this.lphBindingSource.DataSource = this.casDataSet;
            this.lphBindingSource.Filter = "SubString(lph,1,3)=\'LPB\'";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nopolTextEdit
            // 
            this.nopolTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lphBindingSource, "nopol", true));
            this.nopolTextEdit.Location = new System.Drawing.Point(432, 117);
            this.nopolTextEdit.Name = "nopolTextEdit";
            this.nopolTextEdit.Size = new System.Drawing.Size(116, 26);
            this.nopolTextEdit.TabIndex = 53;
            // 
            // remarkMemoEdit
            // 
            this.remarkMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lphBindingSource, "remark", true));
            this.remarkMemoEdit.Location = new System.Drawing.Point(431, 143);
            this.remarkMemoEdit.Name = "remarkMemoEdit";
            this.remarkMemoEdit.Size = new System.Drawing.Size(262, 40);
            this.remarkMemoEdit.TabIndex = 76;
            // 
            // gcLpd
            // 
            this.gcLpd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcLpd.BestFitColumn = true;
            this.gcLpd.ExAutoSize = false;
            this.gcLpd.Location = new System.Drawing.Point(12, 199);
            this.gcLpd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gcLpd.Name = "gcLpd";
            this.gcLpd.Size = new System.Drawing.Size(688, 193);
            this.gcLpd.TabIndex = 77;
            // 
            // omsTextEdit
            // 
            this.omsTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lphBindingSource, "oms", true));
            this.omsTextEdit.Location = new System.Drawing.Point(80, 52);
            this.omsTextEdit.Name = "omsTextEdit";
            this.omsTextEdit.Size = new System.Drawing.Size(132, 26);
            this.omsTextEdit.TabIndex = 78;
            this.omsTextEdit.Tag = "";
            // 
            // spbTextBoxEx
            // 
            this.spbTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lphBindingSource, "spb", true));
            this.spbTextBoxEx.ExAllowEmptyString = true;
            this.spbTextBoxEx.ExAllowNonDBData = false;
            this.spbTextBoxEx.ExAutoCheck = false;
            this.spbTextBoxEx.ExAutoShowResult = false;
            this.spbTextBoxEx.ExCondition = "";
            this.spbTextBoxEx.ExDialogTitle = "";
            this.spbTextBoxEx.ExFieldName = "spb";
            this.spbTextBoxEx.ExFilterFields = new string[0];
            this.spbTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.spbTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.spbTextBoxEx.ExLabelContainer = null;
            this.spbTextBoxEx.ExLabelField = "";
            this.spbTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.spbTextBoxEx.ExLabelText = "";
            this.spbTextBoxEx.ExLabelVisible = false;
            this.spbTextBoxEx.ExSelectFields = new string[0];
            this.spbTextBoxEx.ExShowDialog = true;
            this.spbTextBoxEx.ExSimpleMode = true;
            this.spbTextBoxEx.ExSqlInstance = null;
            this.spbTextBoxEx.ExSqlQuery = "";
            this.spbTextBoxEx.ExTableName = "spb";
            this.spbTextBoxEx.Location = new System.Drawing.Point(80, 26);
            this.spbTextBoxEx.Name = "spbTextBoxEx";
            this.spbTextBoxEx.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.spbTextBoxEx.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.spbTextBoxEx.Properties.Appearance.Options.UseBackColor = true;
            this.spbTextBoxEx.Properties.Appearance.Options.UseForeColor = true;
            this.spbTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.spbTextBoxEx.Size = new System.Drawing.Size(132, 26);
            this.spbTextBoxEx.TabIndex = 79;
            this.spbTextBoxEx.EditValueChanged += new System.EventHandler(this.spbTextBoxEx_EditValueChanged);
            this.spbTextBoxEx.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.spbTextBoxEx_ButtonPressed);
            // 
            // lpdBindingSource
            // 
            this.lpdBindingSource.DataMember = "lpd";
            this.lpdBindingSource.DataSource = this.casDataSet;
            // 
            // lphTableAdapter
            // 
            this.lphTableAdapter.ClearBeforeFill = true;
            // 
            // ctrlSub
            // 
            this.ctrlSub.Location = new System.Drawing.Point(16, 78);
            this.ctrlSub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlSub.Name = "ctrlSub";
            this.ctrlSub.ReadOnly = true;
            this.ctrlSub.Size = new System.Drawing.Size(335, 115);
            this.ctrlSub.TabIndex = 80;
            this.ctrlSub.Tag = "ReadOnly";
            this.ctrlSub.Type = CAS.Transaction.CtrlSub.SubType.Supplier;
            // 
            // linkToOms
            // 
            this.linkToOms.AutoSize = true;
            this.linkToOms.FormName = "";
            this.linkToOms.Location = new System.Drawing.Point(19, 55);
            this.linkToOms.Name = "linkToOms";
            this.linkToOms.Size = new System.Drawing.Size(80, 19);
            this.linkToOms.TabIndex = 84;
            this.linkToOms.TabStop = true;
            this.linkToOms.Text = "No. Order";
            this.linkToOms.TxtKode = this.omsTextEdit;
            // 
            // linkToSpb
            // 
            this.linkToSpb.AutoSize = true;
            this.linkToSpb.FormName = "";
            this.linkToSpb.Location = new System.Drawing.Point(26, 30);
            this.linkToSpb.Name = "linkToSpb";
            this.linkToSpb.Size = new System.Drawing.Size(66, 19);
            this.linkToSpb.TabIndex = 85;
            this.linkToSpb.TabStop = true;
            this.linkToSpb.Text = "No. SPB";
            this.linkToSpb.TxtKode = this.spbTextBoxEx;
            // 
            // textEditPList
            // 
            this.textEditPList.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lphBindingSource, "plist", true));
            this.textEditPList.Location = new System.Drawing.Point(431, 61);
            this.textEditPList.Name = "textEditPList";
            this.textEditPList.Size = new System.Drawing.Size(260, 26);
            this.textEditPList.TabIndex = 87;
            // 
            // textEditNoCont
            // 
            this.textEditNoCont.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lphBindingSource, "container", true));
            this.textEditNoCont.Location = new System.Drawing.Point(431, 87);
            this.textEditNoCont.Name = "textEditNoCont";
            this.textEditNoCont.Size = new System.Drawing.Size(260, 26);
            this.textEditNoCont.TabIndex = 89;
            // 
            // bsaTextBoxEx
            // 
            this.bsaTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lphBindingSource, "bsa", true));
            this.bsaTextBoxEx.ExAllowEmptyString = true;
            this.bsaTextBoxEx.ExAllowNonDBData = false;
            this.bsaTextBoxEx.ExAutoCheck = true;
            this.bsaTextBoxEx.ExAutoShowResult = false;
            this.bsaTextBoxEx.ExCondition = "";
            this.bsaTextBoxEx.ExDialogTitle = "";
            this.bsaTextBoxEx.ExFieldName = "Kode Area";
            this.bsaTextBoxEx.ExFilterFields = new string[0];
            this.bsaTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.bsaTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.bsaTextBoxEx.ExLabelContainer = null;
            this.bsaTextBoxEx.ExLabelField = "Area";
            this.bsaTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.bsaTextBoxEx.ExLabelText = "";
            this.bsaTextBoxEx.ExLabelVisible = true;
            this.bsaTextBoxEx.ExSelectFields = new string[0];
            this.bsaTextBoxEx.ExShowDialog = true;
            this.bsaTextBoxEx.ExSimpleMode = true;
            this.bsaTextBoxEx.ExSqlInstance = null;
            this.bsaTextBoxEx.ExSqlQuery = "select bsa `Kode Area`, Area from bsa";
            this.bsaTextBoxEx.ExTableName = "bsa";
            this.bsaTextBoxEx.Location = new System.Drawing.Point(80, 2);
            this.bsaTextBoxEx.Name = "bsaTextBoxEx";
            this.bsaTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.bsaTextBoxEx.Size = new System.Drawing.Size(81, 26);
            this.bsaTextBoxEx.TabIndex = 138;
            // 
            // FrmTLpb
            // 
            this.ClientSize = new System.Drawing.Size(712, 549);
            this.DetailBindingSource = this.lpdBindingSource;
            this.DetailTable = this.casDataSet.lpd;
            this.MasterBindingSource = this.lphBindingSource;
            this.MasterTable = this.casDataSet.lph;
            this.Name = "FrmTLpb";
            this.Text = "Laporan Penerimaan Barang";
            this.Load += new System.EventHandler(this.FrmTLpb_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.lphBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nopolTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.omsTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spbTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lpdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPList.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNoCont.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsaTextBoxEx.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource lphBindingSource;
        private DevExpress.XtraEditors.TextEdit nopolTextEdit;
        private DevExpress.XtraEditors.MemoEdit remarkMemoEdit;
        private KASLibrary.TextBoxEx spbTextBoxEx;
        private DevExpress.XtraEditors.TextEdit omsTextEdit;
        private KASLibrary.GridControlEx gcLpd;
        private System.Windows.Forms.BindingSource lpdBindingSource;
        private CAS.casDataSetTableAdapters.lphTableAdapter lphTableAdapter;
        private CtrlSub ctrlSub;
        private linkToForm linkToOms;
        private linkToForm linkToSpb;
        private DevExpress.XtraEditors.TextEdit textEditNoCont;
        private DevExpress.XtraEditors.TextEdit textEditPList;
        private KASLibrary.TextBoxEx bsaTextBoxEx;
    }
}
