namespace CAS.Master
{
    partial class FrmMHrgGroup
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
            System.Windows.Forms.Label tglawalLabel;
            System.Windows.Forms.Label tglakhirLabel;
            System.Windows.Forms.Label aktifLabel;
            System.Windows.Forms.Label grpLabel;
            this.casDataSet = new CAS.casDataSet();
            this.hrgdasarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hrgdasarTableAdapter = new CAS.casDataSetTableAdapters.hrgdasarTableAdapter();
            this.tglawalDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.tglakhirDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.aktifCheckBox = new System.Windows.Forms.CheckBox();
            this.gcDHargaGroup = new KASLibrary.GridControlEx();
            this.btnHitung = new DevExpress.XtraEditors.SimpleButton();
            this.dhrggroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dhrggroupTableAdapter = new CAS.casDataSetTableAdapters.dhrggroupTableAdapter();
            this.btnPrintPriceList = new DevExpress.XtraEditors.SimpleButton();
            this.grpTextBoxEx = new KASLibrary.TextBoxEx();
            tglawalLabel = new System.Windows.Forms.Label();
            tglakhirLabel = new System.Windows.Forms.Label();
            aktifLabel = new System.Windows.Forms.Label();
            grpLabel = new System.Windows.Forms.Label();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrgdasarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglawalDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglakhirDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dhrggroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTextBoxEx.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.btnPrintPriceList);
            this.pnlDetail.Controls.Add(this.btnHitung);
            this.pnlDetail.Controls.Add(this.gcDHargaGroup);
            this.pnlDetail.Location = new System.Drawing.Point(0, 128);
            this.pnlDetail.Size = new System.Drawing.Size(760, 331);
            // 
            // pnlKey
            // 
            this.pnlKey.Controls.Add(grpLabel);
            this.pnlKey.Controls.Add(this.grpTextBoxEx);
            this.pnlKey.Controls.Add(aktifLabel);
            this.pnlKey.Controls.Add(this.aktifCheckBox);
            this.pnlKey.Controls.Add(tglakhirLabel);
            this.pnlKey.Controls.Add(this.tglakhirDateEdit);
            this.pnlKey.Controls.Add(tglawalLabel);
            this.pnlKey.Controls.Add(this.tglawalDateEdit);
            this.pnlKey.Size = new System.Drawing.Size(760, 103);
            // 
            // tglawalLabel
            // 
            tglawalLabel.AutoSize = true;
            tglawalLabel.Location = new System.Drawing.Point(51, 27);
            tglawalLabel.Name = "tglawalLabel";
            tglawalLabel.Size = new System.Drawing.Size(47, 13);
            tglawalLabel.TabIndex = 0;
            tglawalLabel.Text = "Tgl Awal";
            // 
            // tglakhirLabel
            // 
            tglakhirLabel.AutoSize = true;
            tglakhirLabel.Location = new System.Drawing.Point(50, 53);
            tglakhirLabel.Name = "tglakhirLabel";
            tglakhirLabel.Size = new System.Drawing.Size(48, 13);
            tglakhirLabel.TabIndex = 2;
            tglakhirLabel.Text = "Tgl Akhir";
            // 
            // aktifLabel
            // 
            aktifLabel.AutoSize = true;
            aktifLabel.Location = new System.Drawing.Point(225, 27);
            aktifLabel.Name = "aktifLabel";
            aktifLabel.Size = new System.Drawing.Size(29, 13);
            aktifLabel.TabIndex = 4;
            aktifLabel.Text = "Aktif";
            // 
            // grpLabel
            // 
            grpLabel.AutoSize = true;
            grpLabel.Location = new System.Drawing.Point(59, 79);
            grpLabel.Name = "grpLabel";
            grpLabel.Size = new System.Drawing.Size(36, 13);
            grpLabel.TabIndex = 12;
            grpLabel.Text = "Group";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hrgdasarBindingSource
            // 
            this.hrgdasarBindingSource.DataMember = "hrgdasar";
            this.hrgdasarBindingSource.DataSource = this.casDataSet;
            this.hrgdasarBindingSource.PositionChanged += new System.EventHandler(this.hrgdasarBindingSource_PositionChanged);
            // 
            // hrgdasarTableAdapter
            // 
            this.hrgdasarTableAdapter.ClearBeforeFill = true;
            // 
            // tglawalDateEdit
            // 
            this.tglawalDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hrgdasarBindingSource, "tglawal", true));
            this.tglawalDateEdit.EditValue = null;
            this.tglawalDateEdit.Location = new System.Drawing.Point(102, 24);
            this.tglawalDateEdit.Name = "tglawalDateEdit";
            this.tglawalDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tglawalDateEdit.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.tglawalDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.tglawalDateEdit.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.tglawalDateEdit.Size = new System.Drawing.Size(100, 20);
            this.tglawalDateEdit.TabIndex = 1;
            // 
            // tglakhirDateEdit
            // 
            this.tglakhirDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hrgdasarBindingSource, "tglakhir", true));
            this.tglakhirDateEdit.EditValue = null;
            this.tglakhirDateEdit.Location = new System.Drawing.Point(102, 50);
            this.tglakhirDateEdit.Name = "tglakhirDateEdit";
            this.tglakhirDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tglakhirDateEdit.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.tglakhirDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.tglakhirDateEdit.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.tglakhirDateEdit.Size = new System.Drawing.Size(100, 20);
            this.tglakhirDateEdit.TabIndex = 3;
            // 
            // aktifCheckBox
            // 
            this.aktifCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.hrgdasarBindingSource, "aktif", true));
            this.aktifCheckBox.Location = new System.Drawing.Point(263, 22);
            this.aktifCheckBox.Name = "aktifCheckBox";
            this.aktifCheckBox.Size = new System.Drawing.Size(39, 24);
            this.aktifCheckBox.TabIndex = 5;
            // 
            // gcDHargaGroup
            // 
            this.gcDHargaGroup.BestFitColumn = true;
            this.gcDHargaGroup.ExAutoSize = false;
            this.gcDHargaGroup.Location = new System.Drawing.Point(23, 6);
            this.gcDHargaGroup.Name = "gcDHargaGroup";
            this.gcDHargaGroup.Size = new System.Drawing.Size(704, 269);
            this.gcDHargaGroup.TabIndex = 4;
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(23, 293);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(156, 23);
            this.btnHitung.TabIndex = 5;
            this.btnHitung.Text = "Hitung Harga Barang";
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // dhrggroupBindingSource
            // 
            this.dhrggroupBindingSource.DataMember = "dhrggroup";
            this.dhrggroupBindingSource.DataSource = this.casDataSet;
            // 
            // dhrggroupTableAdapter
            // 
            this.dhrggroupTableAdapter.ClearBeforeFill = true;
            // 
            // btnPrintPriceList
            // 
            this.btnPrintPriceList.Location = new System.Drawing.Point(607, 293);
            this.btnPrintPriceList.Name = "btnPrintPriceList";
            this.btnPrintPriceList.Size = new System.Drawing.Size(120, 23);
            this.btnPrintPriceList.TabIndex = 6;
            this.btnPrintPriceList.Text = "Lihat Daftar";
            this.btnPrintPriceList.Click += new System.EventHandler(this.btnPrintPriceList_Click);
            // 
            // grpTextBoxEx
            // 
            this.grpTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hrgdasarBindingSource, "grp", true));
            this.grpTextBoxEx.ExAllowEmptyString = true;
            this.grpTextBoxEx.ExAllowNonDBData = false;
            this.grpTextBoxEx.ExAutoCheck = true;
            this.grpTextBoxEx.ExAutoShowResult = false;
            this.grpTextBoxEx.ExCondition = "";
            this.grpTextBoxEx.ExDialogTitle = "Group";
            this.grpTextBoxEx.ExFieldName = "Group";
            this.grpTextBoxEx.ExFilterFields = new string[0];
            this.grpTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.grpTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.grpTextBoxEx.ExLabelContainer = this.pnlKey;
            this.grpTextBoxEx.ExLabelField = "Keterangan";
            this.grpTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.grpTextBoxEx.ExLabelVisible = true;
            this.grpTextBoxEx.ExSelectFields = new string[0];
            this.grpTextBoxEx.ExShowDialog = true;
            this.grpTextBoxEx.ExSimpleMode = true;
            this.grpTextBoxEx.ExSqlInstance = null;
            this.grpTextBoxEx.ExSqlQuery = "Call SP_LookUp(\'grphrgdasar\')";
            this.grpTextBoxEx.ExTableName = "grphrgdasar";
            this.grpTextBoxEx.Location = new System.Drawing.Point(102, 76);
            this.grpTextBoxEx.Name = "grpTextBoxEx";
            this.grpTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.grpTextBoxEx.Size = new System.Drawing.Size(115, 20);
            this.grpTextBoxEx.TabIndex = 13;
            // 
            // FrmMHrgGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(760, 526);
            this.MasterBindingSource = this.hrgdasarBindingSource;
            this.MasterQuery = "select * from hrgdasar";
            this.MasterTable = this.casDataSet.hrgdasar;
            this.Name = "FrmMHrgGroup";
            this.Load += new System.EventHandler(this.FrmMHrgGroup_Load);
            this.pnlDetail.ResumeLayout(false);
            this.pnlKey.ResumeLayout(false);
            this.pnlKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrgdasarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglawalDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglakhirDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dhrggroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTextBoxEx.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource hrgdasarBindingSource;
        private CAS.casDataSetTableAdapters.hrgdasarTableAdapter hrgdasarTableAdapter;
        private DevExpress.XtraEditors.DateEdit tglawalDateEdit;
        private DevExpress.XtraEditors.DateEdit tglakhirDateEdit;
        private System.Windows.Forms.CheckBox aktifCheckBox;
        private KASLibrary.GridControlEx gcDHargaGroup;
        private DevExpress.XtraEditors.SimpleButton btnHitung;
        private System.Windows.Forms.BindingSource dhrggroupBindingSource;
        private CAS.casDataSetTableAdapters.dhrggroupTableAdapter dhrggroupTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnPrintPriceList;
        private KASLibrary.TextBoxEx grpTextBoxEx;
    }
}
