namespace CAS.Master
{
    partial class FrmMasterSales
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
            System.Windows.Forms.Label salesLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label remarkLabel;
            System.Windows.Forms.Label accLabel;
            this.casDataSet = new CAS.casDataSet();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter = new CAS.casDataSetTableAdapters.salesTableAdapter();
            this.salesTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.cityTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.phoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.remarkTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.addressMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.accTextBoxEx = new KASLibrary.TextBoxEx();
            salesLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            accLabel = new System.Windows.Forms.Label();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accTextBoxEx.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.accTextBoxEx);
            this.pnlDetail.Controls.Add(this.addressMemoEdit);
            this.pnlDetail.Controls.Add(accLabel);
            this.pnlDetail.Controls.Add(nameLabel);
            this.pnlDetail.Controls.Add(this.nameTextEdit);
            this.pnlDetail.Controls.Add(remarkLabel);
            this.pnlDetail.Controls.Add(this.remarkTextEdit);
            this.pnlDetail.Controls.Add(addressLabel);
            this.pnlDetail.Controls.Add(phoneLabel);
            this.pnlDetail.Controls.Add(this.cityTextEdit);
            this.pnlDetail.Controls.Add(this.phoneTextEdit);
            this.pnlDetail.Controls.Add(cityLabel);
            this.pnlDetail.Size = new System.Drawing.Size(526, 195);
            // 
            // pnlKey
            // 
            this.pnlKey.Controls.Add(this.salesTextEdit);
            this.pnlKey.Controls.Add(salesLabel);
            this.pnlKey.Size = new System.Drawing.Size(526, 56);
            // 
            // salesLabel
            // 
            salesLabel.AutoSize = true;
            salesLabel.Location = new System.Drawing.Point(71, 33);
            salesLabel.Name = "salesLabel";
            salesLabel.Size = new System.Drawing.Size(59, 13);
            salesLabel.TabIndex = 1;
            salesLabel.Text = "Kode Sales";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(63, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(62, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Nama Sales";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(88, 36);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(40, 13);
            addressLabel.TabIndex = 5;
            addressLabel.Text = "Alamat";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(98, 93);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(29, 13);
            cityLabel.TabIndex = 7;
            cityLabel.Text = "Kota";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(96, 116);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(31, 13);
            phoneLabel.TabIndex = 9;
            phoneLabel.Text = "Telp.";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(65, 139);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(63, 13);
            remarkLabel.TabIndex = 11;
            remarkLabel.Text = "Keterangan";
            // 
            // accLabel
            // 
            accLabel.AutoSize = true;
            accLabel.Location = new System.Drawing.Point(41, 165);
            accLabel.Name = "accLabel";
            accLabel.Size = new System.Drawing.Size(85, 13);
            accLabel.TabIndex = 13;
            accLabel.Text = "Account Piutang";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "sales";
            this.salesBindingSource.DataSource = this.casDataSet;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // salesTextEdit
            // 
            this.salesTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.salesBindingSource, "sales", true));
            this.salesTextEdit.Location = new System.Drawing.Point(133, 30);
            this.salesTextEdit.Name = "salesTextEdit";
            this.salesTextEdit.Size = new System.Drawing.Size(100, 20);
            this.salesTextEdit.TabIndex = 2;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.salesBindingSource, "name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(133, 6);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(260, 20);
            this.nameTextEdit.TabIndex = 4;
            // 
            // cityTextEdit
            // 
            this.cityTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.salesBindingSource, "city", true));
            this.cityTextEdit.Location = new System.Drawing.Point(133, 90);
            this.cityTextEdit.Name = "cityTextEdit";
            this.cityTextEdit.Size = new System.Drawing.Size(100, 20);
            this.cityTextEdit.TabIndex = 8;
            // 
            // phoneTextEdit
            // 
            this.phoneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.salesBindingSource, "phone", true));
            this.phoneTextEdit.Location = new System.Drawing.Point(133, 113);
            this.phoneTextEdit.Name = "phoneTextEdit";
            this.phoneTextEdit.Size = new System.Drawing.Size(100, 20);
            this.phoneTextEdit.TabIndex = 10;
            // 
            // remarkTextEdit
            // 
            this.remarkTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.salesBindingSource, "remark", true));
            this.remarkTextEdit.Location = new System.Drawing.Point(133, 136);
            this.remarkTextEdit.Name = "remarkTextEdit";
            this.remarkTextEdit.Size = new System.Drawing.Size(260, 20);
            this.remarkTextEdit.TabIndex = 12;
            // 
            // addressMemoEdit
            // 
            this.addressMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.salesBindingSource, "address", true));
            this.addressMemoEdit.Location = new System.Drawing.Point(133, 32);
            this.addressMemoEdit.Name = "addressMemoEdit";
            this.addressMemoEdit.Size = new System.Drawing.Size(260, 52);
            this.addressMemoEdit.TabIndex = 15;
            // 
            // accTextBoxEx
            // 
            this.accTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.salesBindingSource, "acc", true));
            this.accTextBoxEx.ExAllowEmptyString = true;
            this.accTextBoxEx.ExAllowNonDBData = false;
            this.accTextBoxEx.ExAutoCheck = true;
            this.accTextBoxEx.ExAutoShowResult = false;
            this.accTextBoxEx.ExCondition = "";
            this.accTextBoxEx.ExDialogTitle = "";
            this.accTextBoxEx.ExFieldName = "Kode Akun";
            this.accTextBoxEx.ExFilterFields = new string[0];
            this.accTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.accTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.accTextBoxEx.ExLabelContainer = null;
            this.accTextBoxEx.ExLabelField = "Keterangan";
            this.accTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.accTextBoxEx.ExLabelVisible = true;
            this.accTextBoxEx.ExSelectFields = new string[0];
            this.accTextBoxEx.ExShowDialog = true;
            this.accTextBoxEx.ExSimpleMode = true;
            this.accTextBoxEx.ExSqlInstance = null;
            this.accTextBoxEx.ExSqlQuery = "Call SP_LookUp(\'acc\')";
            this.accTextBoxEx.ExTableName = "acc";
            this.accTextBoxEx.Location = new System.Drawing.Point(133, 162);
            this.accTextBoxEx.Name = "accTextBoxEx";
            this.accTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.accTextBoxEx.Size = new System.Drawing.Size(100, 20);
            this.accTextBoxEx.TabIndex = 16;
            // 
            // FrmMasterSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(526, 343);
            this.MasterBindingSource = this.salesBindingSource;
            this.MasterQuery = "select * from sales";
            this.MasterTable = this.casDataSet.sales;
            this.Name = "FrmMasterSales";
            this.Text = "Master Sales";
            this.Load += new System.EventHandler(this.FrmMasterSales_Load);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.pnlKey.ResumeLayout(false);
            this.pnlKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accTextBoxEx.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private CAS.casDataSetTableAdapters.salesTableAdapter salesTableAdapter;
        private DevExpress.XtraEditors.TextEdit salesTextEdit;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.TextEdit cityTextEdit;
        private DevExpress.XtraEditors.TextEdit phoneTextEdit;
        private DevExpress.XtraEditors.TextEdit remarkTextEdit;
        private KASLibrary.TextBoxEx accTextBoxEx;
        private DevExpress.XtraEditors.MemoEdit addressMemoEdit;
    }
}
