namespace CAS.Transaction
{
    partial class FrmTPPiutang
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
            System.Windows.Forms.Label subLabel;
            System.Windows.Forms.Label accLabel;
            System.Windows.Forms.Label valLabel;
            System.Windows.Forms.Label remarkLabel;
            System.Windows.Forms.Label bilusLabel;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label2;
            this.casDataSet = new CAS.casDataSet();
            this.kasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remarkTextBox = new System.Windows.Forms.TextBox();
            this.bilusLabel2 = new System.Windows.Forms.Label();
            this.txtCustomer = new KASLibrary.TextBoxEx();
            this.txtNoAkun = new KASLibrary.TextBoxEx();
            this.gcKAG = new KASLibrary.GridControlEx();
            this.kagBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gcKAD = new KASLibrary.GridControlEx();
            this.kadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTotalKAG = new DevExpress.XtraEditors.TextEdit();
            this.txtTotalKAD = new DevExpress.XtraEditors.TextEdit();
            this.kasTableAdapter = new CAS.casDataSetTableAdapters.kasTableAdapter();
            this.valSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            subLabel = new System.Windows.Forms.Label();
            accLabel = new System.Windows.Forms.Label();
            valLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            bilusLabel = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludSeri.Properties)).BeginInit();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curkurs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curcur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoAkun.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kagBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalKAG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalKAD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNo
            // 
            this.txtNo.EditValueChanged += new System.EventHandler(this.txtNo_EditValueChanged);
            // 
            // txtPeriod
            // 
            // 
            // ludSeri
            // 
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.checkEdit1);
            this.pnlDetail.Controls.Add(this.valSpinEdit);
            this.pnlDetail.Controls.Add(this.txtTotalKAD);
            this.pnlDetail.Controls.Add(label2);
            this.pnlDetail.Controls.Add(this.txtTotalKAG);
            this.pnlDetail.Controls.Add(label9);
            this.pnlDetail.Controls.Add(this.gcKAD);
            this.pnlDetail.Controls.Add(this.gcKAG);
            this.pnlDetail.Controls.Add(this.txtNoAkun);
            this.pnlDetail.Controls.Add(this.txtCustomer);
            this.pnlDetail.Controls.Add(this.bilusLabel2);
            this.pnlDetail.Controls.Add(bilusLabel);
            this.pnlDetail.Controls.Add(remarkLabel);
            this.pnlDetail.Controls.Add(this.remarkTextBox);
            this.pnlDetail.Controls.Add(valLabel);
            this.pnlDetail.Controls.Add(accLabel);
            this.pnlDetail.Controls.Add(subLabel);
            this.pnlDetail.Size = new System.Drawing.Size(723, 546);
            this.pnlDetail.Controls.SetChildIndex(this.curLabel1, 0);
            this.pnlDetail.Controls.SetChildIndex(this.kursLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curkurs, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curcur, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateDate, 0);
            this.pnlDetail.Controls.SetChildIndex(subLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(accLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(valLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.remarkTextBox, 0);
            this.pnlDetail.Controls.SetChildIndex(remarkLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(bilusLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.bilusLabel2, 0);
            this.pnlDetail.Controls.SetChildIndex(this.txtCustomer, 0);
            this.pnlDetail.Controls.SetChildIndex(this.txtNoAkun, 0);
            this.pnlDetail.Controls.SetChildIndex(this.gcKAG, 0);
            this.pnlDetail.Controls.SetChildIndex(this.gcKAD, 0);
            this.pnlDetail.Controls.SetChildIndex(label9, 0);
            this.pnlDetail.Controls.SetChildIndex(this.txtTotalKAG, 0);
            this.pnlDetail.Controls.SetChildIndex(label2, 0);
            this.pnlDetail.Controls.SetChildIndex(this.txtTotalKAD, 0);
            this.pnlDetail.Controls.SetChildIndex(this.valSpinEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(this.checkEdit1, 0);
            // 
            // pnlKey
            // 
            this.pnlKey.Size = new System.Drawing.Size(723, 50);
            // 
            // dateDate
            // 
            this.dateDate.EditValue = new System.DateTime(((long)(0)));
            this.dateDate.Location = new System.Drawing.Point(523, 5);
            this.dateDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateDate.Properties.Mask.IgnoreMaskBlank = false;
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(471, 8);
            // 
            // curkurs
            // 
            this.curkurs.Location = new System.Drawing.Point(622, 31);
            // 
            // curcur
            // 
            this.curcur.Location = new System.Drawing.Point(523, 31);
            this.curcur.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.curcur.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.curcur.Properties.Appearance.Options.UseBackColor = true;
            this.curcur.Properties.Appearance.Options.UseForeColor = true;
            this.curcur.EditValueChanged += new System.EventHandler(this.curcur_EditValueChanged);
            // 
            // curLabel1
            // 
            this.curLabel1.Location = new System.Drawing.Point(492, 34);
            // 
            // kursLabel
            // 
            this.kursLabel.Location = new System.Drawing.Point(586, 34);
            // 
            // subLabel
            // 
            subLabel.AutoSize = true;
            subLabel.Location = new System.Drawing.Point(9, 8);
            subLabel.Name = "subLabel";
            subLabel.Size = new System.Drawing.Size(102, 13);
            subLabel.TabIndex = 28;
            subLabel.Text = "Supplier/Customer :";
            // 
            // accLabel
            // 
            accLabel.AutoSize = true;
            accLabel.Location = new System.Drawing.Point(39, 32);
            accLabel.Name = "accLabel";
            accLabel.Size = new System.Drawing.Size(72, 13);
            accLabel.TabIndex = 29;
            accLabel.Text = "Nomor Akun :";
            // 
            // valLabel
            // 
            valLabel.AutoSize = true;
            valLabel.Location = new System.Drawing.Point(78, 55);
            valLabel.Name = "valLabel";
            valLabel.Size = new System.Drawing.Size(33, 13);
            valLabel.TabIndex = 30;
            valLabel.Text = "Nilai :";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(41, 102);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(70, 13);
            remarkLabel.TabIndex = 31;
            remarkLabel.Text = "Keterangan :";
            // 
            // bilusLabel
            // 
            bilusLabel.AutoSize = true;
            bilusLabel.Location = new System.Drawing.Point(53, 79);
            bilusLabel.Name = "bilusLabel";
            bilusLabel.Size = new System.Drawing.Size(58, 13);
            bilusLabel.TabIndex = 33;
            bilusLabel.Text = "Terbilang :";
            // 
            // label9
            // 
            label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(505, 331);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(31, 13);
            label9.TabIndex = 123;
            label9.Text = "Total";
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(505, 523);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(31, 13);
            label2.TabIndex = 125;
            label2.Text = "Total";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kasBindingSource
            // 
            this.kasBindingSource.DataMember = "kas";
            this.kasBindingSource.DataSource = this.casDataSet;
            this.kasBindingSource.Filter = "group_=2";
            // 
            // remarkTextBox
            // 
            this.remarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kasBindingSource, "remark", true));
            this.remarkTextBox.Location = new System.Drawing.Point(115, 99);
            this.remarkTextBox.Multiline = true;
            this.remarkTextBox.Name = "remarkTextBox";
            this.remarkTextBox.Size = new System.Drawing.Size(240, 51);
            this.remarkTextBox.TabIndex = 32;
            this.remarkTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.remarkTextBox_KeyPress);
            // 
            // bilusLabel2
            // 
            this.bilusLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bilusLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kasBindingSource, "bilus", true));
            this.bilusLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bilusLabel2.Location = new System.Drawing.Point(112, 76);
            this.bilusLabel2.Name = "bilusLabel2";
            this.bilusLabel2.Size = new System.Drawing.Size(384, 18);
            this.bilusLabel2.TabIndex = 34;
            this.bilusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCustomer
            // 
            this.txtCustomer.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kasBindingSource, "sub", true));
            this.txtCustomer.ExAllowEmptyString = true;
            this.txtCustomer.ExAllowNonDBData = false;
            this.txtCustomer.ExAutoCheck = true;
            this.txtCustomer.ExAutoShowResult = false;
            this.txtCustomer.ExCondition = "";
            this.txtCustomer.ExDialogTitle = "Customer";
            this.txtCustomer.ExFieldName = "Kode";
            this.txtCustomer.ExFilterFields = new string[0];
            this.txtCustomer.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtCustomer.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtCustomer.ExLabelContainer = null;
            this.txtCustomer.ExLabelField = "Nama";
            this.txtCustomer.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.txtCustomer.ExLabelText = "";
            this.txtCustomer.ExLabelVisible = true;
            this.txtCustomer.ExSelectFields = new string[0];
            this.txtCustomer.ExShowDialog = true;
            this.txtCustomer.ExSimpleMode = false;
            this.txtCustomer.ExSqlInstance = null;
            this.txtCustomer.ExSqlQuery = "Call SP_LookUp(\'sub\')";
            this.txtCustomer.ExTableName = "";
            this.txtCustomer.Location = new System.Drawing.Point(115, 5);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtCustomer.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtCustomer.Properties.Appearance.Options.UseBackColor = true;
            this.txtCustomer.Properties.Appearance.Options.UseForeColor = true;
            this.txtCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtCustomer.Size = new System.Drawing.Size(100, 20);
            this.txtCustomer.TabIndex = 113;
            this.txtCustomer.EditValueChanged += new System.EventHandler(this.textBoxEx1_EditValueChanged);
            // 
            // txtNoAkun
            // 
            this.txtNoAkun.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kasBindingSource, "acc", true));
            this.txtNoAkun.ExAllowEmptyString = true;
            this.txtNoAkun.ExAllowNonDBData = false;
            this.txtNoAkun.ExAutoCheck = true;
            this.txtNoAkun.ExAutoShowResult = false;
            this.txtNoAkun.ExCondition = "";
            this.txtNoAkun.ExDialogTitle = "";
            this.txtNoAkun.ExFieldName = "Nomor Akun";
            this.txtNoAkun.ExFilterFields = new string[0];
            this.txtNoAkun.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtNoAkun.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtNoAkun.ExLabelContainer = null;
            this.txtNoAkun.ExLabelField = "Nama Akun";
            this.txtNoAkun.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.txtNoAkun.ExLabelText = "";
            this.txtNoAkun.ExLabelVisible = true;
            this.txtNoAkun.ExSelectFields = new string[0];
            this.txtNoAkun.ExShowDialog = true;
            this.txtNoAkun.ExSimpleMode = false;
            this.txtNoAkun.ExSqlInstance = null;
            this.txtNoAkun.ExSqlQuery = "Call SP_BrowseM(\'Master.FrmKAS\')";
            this.txtNoAkun.ExTableName = "";
            this.txtNoAkun.Location = new System.Drawing.Point(115, 27);
            this.txtNoAkun.Name = "txtNoAkun";
            this.txtNoAkun.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtNoAkun.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtNoAkun.Properties.Appearance.Options.UseBackColor = true;
            this.txtNoAkun.Properties.Appearance.Options.UseForeColor = true;
            this.txtNoAkun.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtNoAkun.Size = new System.Drawing.Size(100, 20);
            this.txtNoAkun.TabIndex = 113;
            // 
            // gcKAG
            // 
            this.gcKAG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcKAG.BestFitColumn = true;
            this.gcKAG.ExAutoSize = false;
            this.gcKAG.Location = new System.Drawing.Point(16, 154);
            this.gcKAG.Name = "gcKAG";
            this.gcKAG.Size = new System.Drawing.Size(695, 170);
            this.gcKAG.TabIndex = 114;
            // 
            // kagBindingSource
            // 
            this.kagBindingSource.DataMember = "kag";
            this.kagBindingSource.DataSource = this.casDataSet;
            // 
            // gcKAD
            // 
            this.gcKAD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcKAD.BestFitColumn = true;
            this.gcKAD.ExAutoSize = false;
            this.gcKAD.Location = new System.Drawing.Point(15, 350);
            this.gcKAD.Name = "gcKAD";
            this.gcKAD.Size = new System.Drawing.Size(695, 166);
            this.gcKAD.TabIndex = 115;
            // 
            // kadBindingSource
            // 
            this.kadBindingSource.DataMember = "kad";
            this.kadBindingSource.DataSource = this.casDataSet;
            // 
            // txtTotalKAG
            // 
            this.txtTotalKAG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalKAG.Location = new System.Drawing.Point(571, 327);
            this.txtTotalKAG.Name = "txtTotalKAG";
            this.txtTotalKAG.Properties.AllowFocused = false;
            this.txtTotalKAG.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotalKAG.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotalKAG.Properties.ReadOnly = true;
            this.txtTotalKAG.Size = new System.Drawing.Size(121, 20);
            this.txtTotalKAG.TabIndex = 122;
            // 
            // txtTotalKAD
            // 
            this.txtTotalKAD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalKAD.Location = new System.Drawing.Point(571, 519);
            this.txtTotalKAD.Name = "txtTotalKAD";
            this.txtTotalKAD.Properties.AllowFocused = false;
            this.txtTotalKAD.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotalKAD.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotalKAD.Properties.ReadOnly = true;
            this.txtTotalKAD.Size = new System.Drawing.Size(121, 20);
            this.txtTotalKAD.TabIndex = 124;
            // 
            // kasTableAdapter
            // 
            this.kasTableAdapter.ClearBeforeFill = true;
            // 
            // valSpinEdit
            // 
            this.valSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kasBindingSource, "val", true));
            this.valSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.valSpinEdit.Location = new System.Drawing.Point(115, 50);
            this.valSpinEdit.Name = "valSpinEdit";
            this.valSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.valSpinEdit.Properties.UseCtrlIncrement = false;
            this.valSpinEdit.Size = new System.Drawing.Size(130, 20);
            this.valSpinEdit.TabIndex = 126;
            this.valSpinEdit.Leave += new System.EventHandler(this.valSpinEdit_Leave);
            // 
            // checkEdit1
            // 
            this.checkEdit1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.kasBindingSource, "tcsi", true));
            this.checkEdit1.Location = new System.Drawing.Point(495, 57);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Tunai";
            this.checkEdit1.Size = new System.Drawing.Size(75, 18);
            this.checkEdit1.TabIndex = 116;
            // 
            // FrmTPPiutang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 676);
            this.DetailBindingSource = this.kagBindingSource;
            this.DetailTable = this.casDataSet.kag;
            this.MasterBindingSource = this.kasBindingSource;
            this.MasterTable = this.casDataSet.kas;
            this.Name = "FrmTPPiutang";
            this.Text = "Pelunasan Piutang";
            this.Load += new System.EventHandler(this.FrmTPPiutang_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.kasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoAkun.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kagBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalKAG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalKAD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource kasBindingSource;
        private System.Windows.Forms.TextBox remarkTextBox;
        private System.Windows.Forms.Label bilusLabel2;
        private KASLibrary.TextBoxEx txtNoAkun;
        private KASLibrary.TextBoxEx txtCustomer;
        private KASLibrary.GridControlEx gcKAG;
        private System.Windows.Forms.BindingSource kagBindingSource;
        private KASLibrary.GridControlEx gcKAD;
        private System.Windows.Forms.BindingSource kadBindingSource;
        private DevExpress.XtraEditors.TextEdit txtTotalKAD;
        private DevExpress.XtraEditors.TextEdit txtTotalKAG;
        private CAS.casDataSetTableAdapters.kasTableAdapter kasTableAdapter;
        private DevExpress.XtraEditors.SpinEdit valSpinEdit;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
    }
}