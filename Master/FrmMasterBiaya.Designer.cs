namespace CAS.Master
{
    partial class FrmMasterBiaya
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label namaLabel;
            this.casDataSet = new CAS.casDataSet();
            this.mbyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mbyTableAdapter = new CAS.casDataSetTableAdapters.mbyTableAdapter();
            this.kode_byTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.remarkTextEdit = new DevExpress.XtraEditors.TextEdit();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            namaLabel = new System.Windows.Forms.Label();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mbyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kode_byTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(label1);
            this.pnlDetail.Controls.Add(namaLabel);
            this.pnlDetail.Controls.Add(label2);
            this.pnlDetail.Controls.Add(this.nameTextEdit);
            this.pnlDetail.Controls.Add(this.remarkTextEdit);
            this.pnlDetail.Location = new System.Drawing.Point(0, 64);
            this.pnlDetail.Size = new System.Drawing.Size(597, 97);
            // 
            // pnlKey
            // 
            this.pnlKey.Controls.Add(this.kode_byTextEdit);
            this.pnlKey.Controls.Add(label3);
            this.pnlKey.Size = new System.Drawing.Size(597, 39);
            // 
            // pnlChInfo
            // 
            this.pnlChInfo.Location = new System.Drawing.Point(0, 161);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.ForestGreen;
            label1.Location = new System.Drawing.Point(51, 68);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(396, 13);
            label1.TabIndex = 10;
            label1.Text = "Digunakan untuk mengelompokan biaya freight dan trucking di transaksi cossheet";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(40, 32);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(63, 13);
            label2.TabIndex = 9;
            label2.Text = "Keterangan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(40, 15);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(60, 13);
            label3.TabIndex = 7;
            label3.Text = "Kode Biaya";
            // 
            // namaLabel
            // 
            namaLabel.AutoSize = true;
            namaLabel.Location = new System.Drawing.Point(40, 6);
            namaLabel.Name = "namaLabel";
            namaLabel.Size = new System.Drawing.Size(63, 13);
            namaLabel.TabIndex = 8;
            namaLabel.Text = "Nama Biaya";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mbyBindingSource
            // 
            this.mbyBindingSource.DataMember = "mby";
            this.mbyBindingSource.DataSource = this.casDataSet;
            // 
            // mbyTableAdapter
            // 
            this.mbyTableAdapter.ClearBeforeFill = true;
            // 
            // kode_byTextEdit
            // 
            this.kode_byTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mbyBindingSource, "kode_by", true));
            this.kode_byTextEdit.Location = new System.Drawing.Point(117, 15);
            this.kode_byTextEdit.Name = "kode_byTextEdit";
            this.kode_byTextEdit.Size = new System.Drawing.Size(100, 20);
            this.kode_byTextEdit.TabIndex = 1;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mbyBindingSource, "name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(117, 6);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(281, 20);
            this.nameTextEdit.TabIndex = 3;
            // 
            // remarkTextEdit
            // 
            this.remarkTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mbyBindingSource, "remark", true));
            this.remarkTextEdit.Location = new System.Drawing.Point(117, 32);
            this.remarkTextEdit.Name = "remarkTextEdit";
            this.remarkTextEdit.Size = new System.Drawing.Size(365, 20);
            this.remarkTextEdit.TabIndex = 5;
            // 
            // FrmMasterBiaya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(597, 228);
            this.MasterBindingSource = this.mbyBindingSource;
            this.MasterQuery = "select * from mby";
            this.MasterTable = this.casDataSet.mby;
            this.Name = "FrmMasterBiaya";
            this.Load += new System.EventHandler(this.FrmMasterBiaya_Load);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.pnlKey.ResumeLayout(false);
            this.pnlKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mbyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kode_byTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource mbyBindingSource;
        private CAS.casDataSetTableAdapters.mbyTableAdapter mbyTableAdapter;
        private DevExpress.XtraEditors.TextEdit kode_byTextEdit;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.TextEdit remarkTextEdit;
    }
}
