namespace CAS.Master
{
    partial class FrmMasterDpt
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
            this.casDataSet = new CAS.casDataSet();
            this.deptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deptTableAdapter = new CAS.casDataSetTableAdapters.deptTableAdapter();
            this.deptTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.namaTextEdit = new DevExpress.XtraEditors.TextEdit();
            mtpLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namaTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.namaTextEdit);
            this.pnlDetail.Controls.Add(nameLabel);
            this.pnlDetail.Location = new System.Drawing.Point(0, 79);
            this.pnlDetail.Size = new System.Drawing.Size(524, 75);
            // 
            // pnlKey
            // 
            this.pnlKey.Controls.Add(this.deptTextEdit);
            this.pnlKey.Controls.Add(mtpLabel);
            this.pnlKey.Size = new System.Drawing.Size(524, 54);
            // 
            // mtpLabel
            // 
            mtpLabel.AutoSize = true;
            mtpLabel.Location = new System.Drawing.Point(60, 21);
            mtpLabel.Name = "mtpLabel";
            mtpLabel.Size = new System.Drawing.Size(93, 13);
            mtpLabel.TabIndex = 0;
            mtpLabel.Text = "Kode Departemen";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(60, 19);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(96, 13);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Nama Departemen";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deptBindingSource
            // 
            this.deptBindingSource.DataMember = "dept";
            this.deptBindingSource.DataSource = this.casDataSet;
            // 
            // deptTableAdapter
            // 
            this.deptTableAdapter.ClearBeforeFill = true;
            // 
            // deptTextEdit
            // 
            this.deptTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.deptBindingSource, "dept", true));
            this.deptTextEdit.Location = new System.Drawing.Point(157, 18);
            this.deptTextEdit.Name = "deptTextEdit";
            this.deptTextEdit.Size = new System.Drawing.Size(100, 20);
            this.deptTextEdit.TabIndex = 2;
            // 
            // namaTextEdit
            // 
            this.namaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.deptBindingSource, "nama", true));
            this.namaTextEdit.Location = new System.Drawing.Point(157, 16);
            this.namaTextEdit.Name = "namaTextEdit";
            this.namaTextEdit.Size = new System.Drawing.Size(308, 20);
            this.namaTextEdit.TabIndex = 2;
            // 
            // FrmMasterDpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(524, 221);
            this.MasterBindingSource = this.deptBindingSource;
            this.MasterQuery = "select * from dept order by dept";
            this.MasterTable = this.casDataSet.dept;
            this.Name = "FrmMasterDpt";
            this.Text = "Master Departement";
            this.Load += new System.EventHandler(this.FrmMasterDpt_Load);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.pnlKey.ResumeLayout(false);
            this.pnlKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namaTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource deptBindingSource;
        private CAS.casDataSetTableAdapters.deptTableAdapter deptTableAdapter;
        private DevExpress.XtraEditors.TextEdit deptTextEdit;
        private DevExpress.XtraEditors.TextEdit namaTextEdit;
    }
}
