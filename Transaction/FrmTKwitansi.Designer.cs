namespace CAS.Transaction
{
    partial class FrmTKwitansi
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label fpjdateLabel;
            System.Windows.Forms.Label revkwtLabel;
            this.ctrlSub = new CAS.Transaction.CtrlSub();
            this.gckwt = new KASLibrary.GridControlEx();
            this.remarkMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.kwtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casDataSet = new CAS.casDataSet();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.kwdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kwtTableAdapter = new CAS.casDataSetTableAdapters.kwtTableAdapter();
            this.fpjdateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.revkwtTextBoxEx = new KASLibrary.TextBoxEx();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            fpjdateLabel = new System.Windows.Forms.Label();
            revkwtLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludSeri.Properties)).BeginInit();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curkurs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curcur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kwtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kwdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpjdateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revkwtTextBoxEx.Properties)).BeginInit();
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
            this.pnlDetail.Controls.Add(revkwtLabel);
            this.pnlDetail.Controls.Add(this.revkwtTextBoxEx);
            this.pnlDetail.Controls.Add(fpjdateLabel);
            this.pnlDetail.Controls.Add(this.fpjdateDateEdit);
            this.pnlDetail.Controls.Add(this.txtTotal);
            this.pnlDetail.Controls.Add(label3);
            this.pnlDetail.Controls.Add(this.gckwt);
            this.pnlDetail.Controls.Add(this.remarkMemoEdit);
            this.pnlDetail.Controls.Add(label2);
            this.pnlDetail.Controls.Add(this.ctrlSub);
            this.pnlDetail.Size = new System.Drawing.Size(752, 413);
            this.pnlDetail.Controls.SetChildIndex(this.dateDate, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curcur, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curkurs, 0);
            this.pnlDetail.Controls.SetChildIndex(this.kursLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curLabel1, 0);
            this.pnlDetail.Controls.SetChildIndex(this.ctrlSub, 0);
            this.pnlDetail.Controls.SetChildIndex(label2, 0);
            this.pnlDetail.Controls.SetChildIndex(this.remarkMemoEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(this.gckwt, 0);
            this.pnlDetail.Controls.SetChildIndex(label3, 0);
            this.pnlDetail.Controls.SetChildIndex(this.txtTotal, 0);
            this.pnlDetail.Controls.SetChildIndex(this.fpjdateDateEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(fpjdateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.revkwtTextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(revkwtLabel, 0);
            // 
            // pnlKey
            // 
            this.pnlKey.Size = new System.Drawing.Size(752, 50);
            // 
            // dateDate
            // 
            this.dateDate.EditValue = new System.DateTime(((long)(0)));
            this.dateDate.Location = new System.Drawing.Point(445, 15);
            this.dateDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateDate.Properties.Mask.IgnoreMaskBlank = false;
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(370, 18);
            // 
            // curkurs
            // 
            this.curkurs.Location = new System.Drawing.Point(610, 44);
            this.curkurs.Visible = false;
            // 
            // curcur
            // 
            this.curcur.Location = new System.Drawing.Point(511, 44);
            this.curcur.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.curcur.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.curcur.Properties.Appearance.Options.UseBackColor = true;
            this.curcur.Properties.Appearance.Options.UseForeColor = true;
            this.curcur.Visible = false;
            // 
            // curLabel1
            // 
            this.curLabel1.Location = new System.Drawing.Point(480, 47);
            this.curLabel1.Visible = false;
            // 
            // kursLabel
            // 
            this.kursLabel.Location = new System.Drawing.Point(574, 47);
            this.kursLabel.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(370, 71);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(63, 13);
            label2.TabIndex = 130;
            label2.Text = "Keterangan";
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(571, 378);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(31, 13);
            label3.TabIndex = 134;
            label3.Text = "Total";
            // 
            // fpjdateLabel
            // 
            fpjdateLabel.AutoSize = true;
            fpjdateLabel.Location = new System.Drawing.Point(370, 48);
            fpjdateLabel.Name = "fpjdateLabel";
            fpjdateLabel.Size = new System.Drawing.Size(69, 13);
            fpjdateLabel.TabIndex = 134;
            fpjdateLabel.Text = "Jatuh Tempo";
            // 
            // revkwtLabel
            // 
            revkwtLabel.AutoSize = true;
            revkwtLabel.Location = new System.Drawing.Point(24, 137);
            revkwtLabel.Name = "revkwtLabel";
            revkwtLabel.Size = new System.Drawing.Size(105, 13);
            revkwtLabel.TabIndex = 135;
            revkwtLabel.Text = "Kwitansi Pembetulan";
            // 
            // ctrlSub
            // 
            this.ctrlSub.Location = new System.Drawing.Point(12, 9);
            this.ctrlSub.Name = "ctrlSub";
            this.ctrlSub.ReadOnly = true;
            this.ctrlSub.Size = new System.Drawing.Size(335, 115);
            this.ctrlSub.TabIndex = 120;
            this.ctrlSub.Type = CAS.Transaction.CtrlSub.SubType.Customer;
            // 
            // gckwt
            // 
            this.gckwt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gckwt.BestFitColumn = true;
            this.gckwt.ExAutoSize = false;
            this.gckwt.Location = new System.Drawing.Point(6, 160);
            this.gckwt.Name = "gckwt";
            this.gckwt.Size = new System.Drawing.Size(734, 209);
            this.gckwt.TabIndex = 132;
            // 
            // remarkMemoEdit
            // 
            this.remarkMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kwtBindingSource, "remark", true));
            this.remarkMemoEdit.Location = new System.Drawing.Point(372, 87);
            this.remarkMemoEdit.Name = "remarkMemoEdit";
            this.remarkMemoEdit.Size = new System.Drawing.Size(288, 37);
            this.remarkMemoEdit.TabIndex = 131;
            this.remarkMemoEdit.EditValueChanged += new System.EventHandler(this.remarkMemoEdit_EditValueChanged);
            // 
            // kwtBindingSource
            // 
            this.kwtBindingSource.DataMember = "kwt";
            this.kwtBindingSource.DataSource = this.casDataSet;
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Location = new System.Drawing.Point(619, 375);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtTotal.Properties.Appearance.Options.UseFont = true;
            this.txtTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotal.Properties.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(121, 20);
            this.txtTotal.TabIndex = 133;
            // 
            // kwdBindingSource
            // 
            this.kwdBindingSource.DataMember = "kwd";
            this.kwdBindingSource.DataSource = this.casDataSet;
            // 
            // kwtTableAdapter
            // 
            this.kwtTableAdapter.ClearBeforeFill = true;
            // 
            // fpjdateDateEdit
            // 
            this.fpjdateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kwtBindingSource, "fpjdate", true));
            this.fpjdateDateEdit.EditValue = null;
            this.fpjdateDateEdit.Location = new System.Drawing.Point(445, 44);
            this.fpjdateDateEdit.Name = "fpjdateDateEdit";
            this.fpjdateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fpjdateDateEdit.Size = new System.Drawing.Size(100, 23);
            this.fpjdateDateEdit.TabIndex = 135;
            // 
            // revkwtTextBoxEx
            // 
            this.revkwtTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kwtBindingSource, "revkwt", true));
            this.revkwtTextBoxEx.ExAllowEmptyString = true;
            this.revkwtTextBoxEx.ExAllowNonDBData = false;
            this.revkwtTextBoxEx.ExAutoCheck = true;
            this.revkwtTextBoxEx.ExAutoShowResult = false;
            this.revkwtTextBoxEx.ExCondition = "";
            this.revkwtTextBoxEx.ExDialogTitle = "";
            this.revkwtTextBoxEx.ExFieldName = "kwt";
            this.revkwtTextBoxEx.ExFilterFields = new string[0];
            this.revkwtTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.revkwtTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.revkwtTextBoxEx.ExLabelContainer = null;
            this.revkwtTextBoxEx.ExLabelField = "kwt";
            this.revkwtTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.revkwtTextBoxEx.ExLabelText = "";
            this.revkwtTextBoxEx.ExLabelVisible = false;
            this.revkwtTextBoxEx.ExSelectFields = new string[0];
            this.revkwtTextBoxEx.ExShowDialog = true;
            this.revkwtTextBoxEx.ExSimpleMode = true;
            this.revkwtTextBoxEx.ExSqlInstance = null;
            this.revkwtTextBoxEx.ExSqlQuery = "select kwt,date,sub as kodecustomer from kwt where kwt.date >= adddate(date(now()" +
                "),interval -1 year)";
            this.revkwtTextBoxEx.ExTableName = "";
            this.revkwtTextBoxEx.Location = new System.Drawing.Point(134, 134);
            this.revkwtTextBoxEx.Name = "revkwtTextBoxEx";
            this.revkwtTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.revkwtTextBoxEx.Size = new System.Drawing.Size(136, 20);
            this.revkwtTextBoxEx.TabIndex = 136;
            this.revkwtTextBoxEx.EditValueChanged += new System.EventHandler(this.revkwtTextBoxEx_EditValueChanged);
            // 
            // FrmTKwitansi
            // 
            this.ClientSize = new System.Drawing.Size(752, 543);
            this.DetailBindingSource = this.kwtBindingSource;
            this.DetailTable = this.casDataSet.kwd;
            this.MasterBindingSource = this.kwtBindingSource;
            this.MasterTable = this.casDataSet.kwt;
            this.Name = "FrmTKwitansi";
            this.Load += new System.EventHandler(this.FrmTKwitansi_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kwtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kwdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpjdateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revkwtTextBoxEx.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CtrlSub ctrlSub;
        private KASLibrary.GridControlEx gckwt;
        private DevExpress.XtraEditors.MemoEdit remarkMemoEdit;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource kwtBindingSource;
        private System.Windows.Forms.BindingSource kwdBindingSource;
        private DevExpress.XtraEditors.DateEdit fpjdateDateEdit;
        private CAS.casDataSetTableAdapters.kwtTableAdapter kwtTableAdapter;
        private KASLibrary.TextBoxEx revkwtTextBoxEx;
    }
}
