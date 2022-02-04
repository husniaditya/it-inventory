namespace CAS.Master
{
    partial class FrmMasterShipper
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
            System.Windows.Forms.Label mtpLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label addressLabel;
            this.casDataSet = new CAS.casDataSet();
            this.shipperTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ShipperbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.remarkTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.m_shipperTableAdapter = new CAS.casDataSetTableAdapters.m_shipperTableAdapter();
            this.negaraTextEdit = new KASLibrary.TextBoxEx();
            this.referensinegaraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            mtpLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipperTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShipperbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.negaraTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referensinegaraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressMemoEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.addressMemoEdit);
            this.pnlDetail.Controls.Add(addressLabel);
            this.pnlDetail.Controls.Add(this.negaraTextEdit);
            this.pnlDetail.Controls.Add(countryLabel);
            this.pnlDetail.Controls.Add(label1);
            this.pnlDetail.Controls.Add(this.remarkTextEdit);
            this.pnlDetail.Controls.Add(nameLabel);
            this.pnlDetail.Controls.Add(this.nameTextEdit);
            this.pnlDetail.Location = new System.Drawing.Point(0, 127);
            this.pnlDetail.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pnlDetail.Size = new System.Drawing.Size(747, 114);
            // 
            // pnlKey
            // 
            this.pnlKey.Controls.Add(mtpLabel);
            this.pnlKey.Controls.Add(this.shipperTextEdit);
            this.pnlKey.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pnlKey.Size = new System.Drawing.Size(747, 95);
            // 
            // pnlChInfo
            // 
            this.pnlChInfo.Location = new System.Drawing.Point(0, 241);
            this.pnlChInfo.Size = new System.Drawing.Size(747, 69);
            // 
            // mtpLabel
            // 
            mtpLabel.AutoSize = true;
            mtpLabel.Location = new System.Drawing.Point(90, 40);
            mtpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mtpLabel.Name = "mtpLabel";
            mtpLabel.Size = new System.Drawing.Size(104, 19);
            mtpLabel.TabIndex = 0;
            mtpLabel.Text = "Shipper Code";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(27, 10);
            nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(50, 19);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(27, 46);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(63, 19);
            label1.TabIndex = 2;
            label1.Text = "Remark";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(372, 9);
            countryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(59, 19);
            countryLabel.TabIndex = 79;
            countryLabel.Text = "Negara";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(372, 46);
            addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(59, 19);
            addressLabel.TabIndex = 81;
            addressLabel.Text = "Alamat";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shipperTextEdit
            // 
            this.shipperTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ShipperbindingSource, "kode_shipper", true));
            this.shipperTextEdit.Location = new System.Drawing.Point(219, 35);
            this.shipperTextEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shipperTextEdit.Name = "shipperTextEdit";
            this.shipperTextEdit.Size = new System.Drawing.Size(150, 26);
            this.shipperTextEdit.TabIndex = 1;
            // 
            // ShipperbindingSource
            // 
            this.ShipperbindingSource.DataMember = "m_shipper";
            this.ShipperbindingSource.DataSource = this.casDataSet;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ShipperbindingSource, "nama_shipper", true));
            this.nameTextEdit.Location = new System.Drawing.Point(102, 6);
            this.nameTextEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(240, 26);
            this.nameTextEdit.TabIndex = 1;
            // 
            // remarkTextEdit
            // 
            this.remarkTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ShipperbindingSource, "keterangan", true));
            this.remarkTextEdit.Location = new System.Drawing.Point(102, 42);
            this.remarkTextEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.remarkTextEdit.Name = "remarkTextEdit";
            this.remarkTextEdit.Size = new System.Drawing.Size(240, 26);
            this.remarkTextEdit.TabIndex = 3;
            // 
            // m_shipperTableAdapter
            // 
            this.m_shipperTableAdapter.ClearBeforeFill = true;
            // 
            // negaraTextEdit
            // 
            this.negaraTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ShipperbindingSource, "kode_negara", true));
            this.negaraTextEdit.ExAllowEmptyString = true;
            this.negaraTextEdit.ExAllowNonDBData = false;
            this.negaraTextEdit.ExAutoCheck = true;
            this.negaraTextEdit.ExAutoShowResult = false;
            this.negaraTextEdit.ExCondition = "";
            this.negaraTextEdit.ExDialogTitle = "referensi_negara";
            this.negaraTextEdit.ExFieldName = "KODE_NEGARA";
            this.negaraTextEdit.ExFilterFields = new string[] {
        "KODE_NEGARA",
        "URAIAN_NEGARA"};
            this.negaraTextEdit.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.negaraTextEdit.ExInvalidForeColor = System.Drawing.Color.Black;
            this.negaraTextEdit.ExLabelContainer = null;
            this.negaraTextEdit.ExLabelField = "URAIAN_NEGARA";
            this.negaraTextEdit.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.negaraTextEdit.ExLabelText = "";
            this.negaraTextEdit.ExLabelVisible = true;
            this.negaraTextEdit.ExSelectFields = new string[] {
        "KODE_NEGARA",
        "URAIAN_NEGARA"};
            this.negaraTextEdit.ExShowDialog = true;
            this.negaraTextEdit.ExSimpleMode = true;
            this.negaraTextEdit.ExSqlInstance = null;
            this.negaraTextEdit.ExSqlQuery = "SELECT KODE_NEGARA,URAIAN_NEGARA from tpbdb.referensi_negara";
            this.negaraTextEdit.ExTableName = "referensi_negara";
            this.negaraTextEdit.Location = new System.Drawing.Point(439, 7);
            this.negaraTextEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.negaraTextEdit.Name = "negaraTextEdit";
            this.negaraTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.negaraTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.negaraTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.negaraTextEdit.Properties.Appearance.Options.UseForeColor = true;
            this.negaraTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.negaraTextEdit.Size = new System.Drawing.Size(150, 26);
            this.negaraTextEdit.TabIndex = 80;
            // 
            // referensinegaraBindingSource
            // 
            this.referensinegaraBindingSource.DataMember = "referensi_negara";
            this.referensinegaraBindingSource.DataSource = this.casDataSet;
            // 
            // addressMemoEdit
            // 
            this.addressMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ShipperbindingSource, "alamat", true));
            this.addressMemoEdit.Location = new System.Drawing.Point(440, 43);
            this.addressMemoEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addressMemoEdit.Name = "addressMemoEdit";
            this.addressMemoEdit.Size = new System.Drawing.Size(370, 86);
            this.addressMemoEdit.TabIndex = 82;
            // 
            // FrmMasterShipper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(747, 340);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MasterBindingSource = this.ShipperbindingSource;
            this.MasterQuery = "select * from m_shipper order by kode_shipper";
            this.MasterTable = this.casDataSet.m_shipper;
            this.Name = "FrmMasterShipper";
            this.Text = "Master Shipper";
            this.Load += new System.EventHandler(this.FrmMasterShipper_Load_1);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.pnlKey.ResumeLayout(false);
            this.pnlKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipperTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShipperbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.negaraTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referensinegaraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressMemoEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private DevExpress.XtraEditors.TextEdit shipperTextEdit;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.TextEdit remarkTextEdit;
        private CAS.casDataSetTableAdapters.m_shipperTableAdapter m_shipperTableAdapter;
        private System.Windows.Forms.BindingSource ShipperbindingSource;
        private KASLibrary.TextBoxEx negaraTextEdit;
        private DevExpress.XtraEditors.MemoEdit addressMemoEdit;
        private System.Windows.Forms.BindingSource referensinegaraBindingSource;
    }
}
