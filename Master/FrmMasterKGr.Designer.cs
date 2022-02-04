namespace CAS.Master
{
    partial class FrmMasterKGr
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
            System.Windows.Forms.Label bankLabel;
            System.Windows.Forms.Label no_rekLabel;
            System.Windows.Forms.Label gironameLabel;
            System.Windows.Forms.Label namavendorLabel;
            System.Windows.Forms.Label adressbankLabel;
            System.Windows.Forms.Label citybankLabel;
            System.Windows.Forms.Label nomorLabel;
            this.casDataSet = new CAS.casDataSet();
            this.accbankBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accbankTableAdapter = new CAS.casDataSetTableAdapters.accbankTableAdapter();
            this.textBoxEx1 = new KASLibrary.TextBoxEx();
            this.gironameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.namavendorTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.adressbankTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.citybankTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.no_rekTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.bankTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nomorSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            subLabel = new System.Windows.Forms.Label();
            bankLabel = new System.Windows.Forms.Label();
            no_rekLabel = new System.Windows.Forms.Label();
            gironameLabel = new System.Windows.Forms.Label();
            namavendorLabel = new System.Windows.Forms.Label();
            adressbankLabel = new System.Windows.Forms.Label();
            citybankLabel = new System.Windows.Forms.Label();
            nomorLabel = new System.Windows.Forms.Label();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accbankBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxEx1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gironameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namavendorTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adressbankTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citybankTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_rekTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomorSpinEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.no_rekTextEdit);
            this.pnlDetail.Controls.Add(no_rekLabel);
            this.pnlDetail.Controls.Add(this.bankTextEdit);
            this.pnlDetail.Controls.Add(citybankLabel);
            this.pnlDetail.Controls.Add(this.citybankTextEdit);
            this.pnlDetail.Controls.Add(adressbankLabel);
            this.pnlDetail.Controls.Add(this.adressbankTextEdit);
            this.pnlDetail.Controls.Add(namavendorLabel);
            this.pnlDetail.Controls.Add(this.namavendorTextEdit);
            this.pnlDetail.Controls.Add(gironameLabel);
            this.pnlDetail.Controls.Add(this.gironameTextEdit);
            this.pnlDetail.Controls.Add(this.textBoxEx1);
            this.pnlDetail.Controls.Add(bankLabel);
            this.pnlDetail.Controls.Add(subLabel);
            this.pnlDetail.Location = new System.Drawing.Point(0, 59);
            this.pnlDetail.Size = new System.Drawing.Size(583, 269);
            // 
            // pnlKey
            // 
            this.pnlKey.Controls.Add(nomorLabel);
            this.pnlKey.Controls.Add(this.nomorSpinEdit);
            this.pnlKey.Size = new System.Drawing.Size(583, 34);
            // 
            // pnlChInfo
            // 
            this.pnlChInfo.Location = new System.Drawing.Point(0, 328);
            this.pnlChInfo.Size = new System.Drawing.Size(583, 45);
            // 
            // subLabel
            // 
            subLabel.AutoSize = true;
            subLabel.Location = new System.Drawing.Point(59, 35);
            subLabel.Name = "subLabel";
            subLabel.Size = new System.Drawing.Size(68, 13);
            subLabel.TabIndex = 0;
            subLabel.Text = "Kode Vendor";
            // 
            // bankLabel
            // 
            bankLabel.AutoSize = true;
            bankLabel.Location = new System.Drawing.Point(97, 87);
            bankLabel.Name = "bankLabel";
            bankLabel.Size = new System.Drawing.Size(30, 13);
            bankLabel.TabIndex = 2;
            bankLabel.Text = "Bank";
            // 
            // no_rekLabel
            // 
            no_rekLabel.AutoSize = true;
            no_rekLabel.Location = new System.Drawing.Point(62, 9);
            no_rekLabel.Name = "no_rekLabel";
            no_rekLabel.Size = new System.Drawing.Size(67, 13);
            no_rekLabel.TabIndex = 4;
            no_rekLabel.Text = "No Rekening";
            // 
            // gironameLabel
            // 
            gironameLabel.AutoSize = true;
            gironameLabel.Location = new System.Drawing.Point(21, 113);
            gironameLabel.Name = "gironameLabel";
            gironameLabel.Size = new System.Drawing.Size(106, 13);
            gironameLabel.TabIndex = 136;
            gironameLabel.Text = "Rekening Atas Nama";
            // 
            // namavendorLabel
            // 
            namavendorLabel.AutoSize = true;
            namavendorLabel.Location = new System.Drawing.Point(93, 61);
            namavendorLabel.Name = "namavendorLabel";
            namavendorLabel.Size = new System.Drawing.Size(34, 13);
            namavendorLabel.TabIndex = 137;
            namavendorLabel.Text = "Nama";
            namavendorLabel.Click += new System.EventHandler(this.namavendorLabel_Click);
            // 
            // adressbankLabel
            // 
            adressbankLabel.AutoSize = true;
            adressbankLabel.Location = new System.Drawing.Point(61, 140);
            adressbankLabel.Name = "adressbankLabel";
            adressbankLabel.Size = new System.Drawing.Size(66, 13);
            adressbankLabel.TabIndex = 138;
            adressbankLabel.Text = "Alamat Bank";
            // 
            // citybankLabel
            // 
            citybankLabel.AutoSize = true;
            citybankLabel.Location = new System.Drawing.Point(72, 173);
            citybankLabel.Name = "citybankLabel";
            citybankLabel.Size = new System.Drawing.Size(55, 13);
            citybankLabel.TabIndex = 139;
            citybankLabel.Text = "Kota Bank";
            citybankLabel.Click += new System.EventHandler(this.citybankLabel_Click);
            // 
            // nomorLabel
            // 
            nomorLabel.AutoSize = true;
            nomorLabel.Location = new System.Drawing.Point(18, 11);
            nomorLabel.Name = "nomorLabel";
            nomorLabel.Size = new System.Drawing.Size(41, 13);
            nomorLabel.TabIndex = 0;
            nomorLabel.Text = "nomor:";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accbankBindingSource
            // 
            this.accbankBindingSource.DataMember = "accbank";
            this.accbankBindingSource.DataSource = this.casDataSet;
            // 
            // accbankTableAdapter
            // 
            this.accbankTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxEx1
            // 
            this.textBoxEx1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.accbankBindingSource, "sub", true));
            this.textBoxEx1.ExAllowEmptyString = true;
            this.textBoxEx1.ExAllowNonDBData = false;
            this.textBoxEx1.ExAutoCheck = false;
            this.textBoxEx1.ExAutoShowResult = false;
            this.textBoxEx1.ExCondition = "";
            this.textBoxEx1.ExDialogTitle = "Supplier";
            this.textBoxEx1.ExFieldName = "Kode";
            this.textBoxEx1.ExFilterFields = new string[0];
            this.textBoxEx1.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.textBoxEx1.ExInvalidForeColor = System.Drawing.Color.Black;
            this.textBoxEx1.ExLabelContainer = null;
            this.textBoxEx1.ExLabelField = "Nama";
            this.textBoxEx1.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.textBoxEx1.ExLabelText = "";
            this.textBoxEx1.ExLabelVisible = false;
            this.textBoxEx1.ExSelectFields = new string[0];
            this.textBoxEx1.ExShowDialog = true;
            this.textBoxEx1.ExSimpleMode = false;
            this.textBoxEx1.ExSqlInstance = null;
            this.textBoxEx1.ExSqlQuery = "Call SP_LookUp(\'vendor\')";
            this.textBoxEx1.ExTableName = "sub";
            this.textBoxEx1.Location = new System.Drawing.Point(142, 32);
            this.textBoxEx1.Name = "textBoxEx1";
            this.textBoxEx1.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxEx1.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.textBoxEx1.Properties.Appearance.Options.UseBackColor = true;
            this.textBoxEx1.Properties.Appearance.Options.UseForeColor = true;
            this.textBoxEx1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.textBoxEx1.Size = new System.Drawing.Size(115, 20);
            this.textBoxEx1.TabIndex = 135;
            this.textBoxEx1.EditValueChanged += new System.EventHandler(this.textBoxEx1_EditValueChanged);
            // 
            // gironameTextEdit
            // 
            this.gironameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.accbankBindingSource, "gironame", true));
            this.gironameTextEdit.Location = new System.Drawing.Point(142, 110);
            this.gironameTextEdit.Name = "gironameTextEdit";
            this.gironameTextEdit.Size = new System.Drawing.Size(420, 20);
            this.gironameTextEdit.TabIndex = 137;
            // 
            // namavendorTextEdit
            // 
            this.namavendorTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.accbankBindingSource, "namavendor", true));
            this.namavendorTextEdit.Location = new System.Drawing.Point(142, 58);
            this.namavendorTextEdit.Name = "namavendorTextEdit";
            this.namavendorTextEdit.Size = new System.Drawing.Size(420, 20);
            this.namavendorTextEdit.TabIndex = 138;
            this.namavendorTextEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.namavendorTextEdit_KeyPress);
            // 
            // adressbankTextEdit
            // 
            this.adressbankTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.accbankBindingSource, "adressbank", true));
            this.adressbankTextEdit.Location = new System.Drawing.Point(142, 140);
            this.adressbankTextEdit.Name = "adressbankTextEdit";
            this.adressbankTextEdit.Size = new System.Drawing.Size(319, 20);
            this.adressbankTextEdit.TabIndex = 139;
            // 
            // citybankTextEdit
            // 
            this.citybankTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.accbankBindingSource, "citybank", true));
            this.citybankTextEdit.Location = new System.Drawing.Point(142, 166);
            this.citybankTextEdit.Name = "citybankTextEdit";
            this.citybankTextEdit.Size = new System.Drawing.Size(100, 20);
            this.citybankTextEdit.TabIndex = 140;
            // 
            // no_rekTextEdit
            // 
            this.no_rekTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.accbankBindingSource, "no_rek", true));
            this.no_rekTextEdit.Location = new System.Drawing.Point(142, 6);
            this.no_rekTextEdit.Name = "no_rekTextEdit";
            this.no_rekTextEdit.Size = new System.Drawing.Size(199, 20);
            this.no_rekTextEdit.TabIndex = 141;
            // 
            // bankTextEdit
            // 
            this.bankTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.accbankBindingSource, "bank", true));
            this.bankTextEdit.Location = new System.Drawing.Point(142, 84);
            this.bankTextEdit.Name = "bankTextEdit";
            this.bankTextEdit.Size = new System.Drawing.Size(199, 20);
            this.bankTextEdit.TabIndex = 142;
            // 
            // nomorSpinEdit
            // 
            this.nomorSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.accbankBindingSource, "nomor", true));
            this.nomorSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nomorSpinEdit.Enabled = false;
            this.nomorSpinEdit.Location = new System.Drawing.Point(65, 8);
            this.nomorSpinEdit.Name = "nomorSpinEdit";
            this.nomorSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.nomorSpinEdit.Properties.UseCtrlIncrement = false;
            this.nomorSpinEdit.Size = new System.Drawing.Size(83, 20);
            this.nomorSpinEdit.TabIndex = 1;
            // 
            // FrmMasterKGr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 395);
            this.MasterBindingSource = this.accbankBindingSource;
            this.MasterQuery = "select  nomor,no_rek,bank,sub,acc,chtime,chusr,gironame,namavendor,adressbank,cit" +
                "ybank,group_ from accbank";
            this.MasterTable = this.casDataSet.accbank;
            this.Name = "FrmMasterKGr";
            this.Text = "Master Rekening";
            this.Load += new System.EventHandler(this.FrmMasterKGr_Load);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.pnlKey.ResumeLayout(false);
            this.pnlKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accbankBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxEx1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gironameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namavendorTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adressbankTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citybankTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_rekTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomorSpinEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource accbankBindingSource;
        private CAS.casDataSetTableAdapters.accbankTableAdapter accbankTableAdapter;
        private KASLibrary.TextBoxEx textBoxEx1;
        private DevExpress.XtraEditors.TextEdit namavendorTextEdit;
        private DevExpress.XtraEditors.TextEdit gironameTextEdit;
        private DevExpress.XtraEditors.TextEdit citybankTextEdit;
        private DevExpress.XtraEditors.TextEdit adressbankTextEdit;
        private DevExpress.XtraEditors.TextEdit bankTextEdit;
        private DevExpress.XtraEditors.TextEdit no_rekTextEdit;
        private DevExpress.XtraEditors.SpinEdit nomorSpinEdit;
    }
}