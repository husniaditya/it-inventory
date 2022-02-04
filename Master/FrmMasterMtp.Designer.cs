namespace CAS.Master
{
    partial class FrmMasterMtp
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
            this.mtpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mtpTableAdapter = new CAS.casDataSetTableAdapters.mtpTableAdapter();
            this.mtpTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            mtpLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtpTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(nameLabel);
            this.pnlDetail.Controls.Add(this.nameTextEdit);
            this.pnlDetail.Location = new System.Drawing.Point(0, 87);
            this.pnlDetail.Size = new System.Drawing.Size(498, 67);
            // 
            // pnlKey
            // 
            this.pnlKey.Controls.Add(mtpLabel);
            this.pnlKey.Controls.Add(this.mtpTextEdit);
            this.pnlKey.Size = new System.Drawing.Size(498, 62);
            // 
            // mtpLabel
            // 
            mtpLabel.AutoSize = true;
            mtpLabel.Location = new System.Drawing.Point(60, 26);
            mtpLabel.Name = "mtpLabel";
            mtpLabel.Size = new System.Drawing.Size(71, 13);
            mtpLabel.TabIndex = 0;
            mtpLabel.Text = "Material Type";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(96, 25);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(35, 13);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mtpBindingSource
            // 
            this.mtpBindingSource.DataMember = "mtp";
            this.mtpBindingSource.DataSource = this.casDataSet;
            // 
            // mtpTableAdapter
            // 
            this.mtpTableAdapter.ClearBeforeFill = true;
            // 
            // mtpTextEdit
            // 
            this.mtpTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mtpBindingSource, "mtp", true));
            this.mtpTextEdit.Location = new System.Drawing.Point(146, 23);
            this.mtpTextEdit.Name = "mtpTextEdit";
            this.mtpTextEdit.Size = new System.Drawing.Size(100, 20);
            this.mtpTextEdit.TabIndex = 1;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mtpBindingSource, "name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(146, 22);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(261, 20);
            this.nameTextEdit.TabIndex = 1;
            // 
            // FrmMasterMtp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(498, 221);
            this.MasterBindingSource = this.mtpBindingSource;
            this.MasterQuery = "select * from mtp order by mtp";
            this.MasterTable = this.casDataSet.mtp;
            this.Name = "FrmMasterMtp";
            this.Text = "Master Material Type";
            this.Load += new System.EventHandler(this.FrmMasterMtp_Load);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.pnlKey.ResumeLayout(false);
            this.pnlKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtpTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource mtpBindingSource;
        private CAS.casDataSetTableAdapters.mtpTableAdapter mtpTableAdapter;
        private DevExpress.XtraEditors.TextEdit mtpTextEdit;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
    }
}
