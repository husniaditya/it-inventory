namespace CAS.Master
{
    partial class FrmMasterLoc
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label locLabel;
            System.Windows.Forms.Label remarkLabel;
            this.casDataSet = new CAS.casDataSet();
            this.locBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.locTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.remarkTextEdit = new DevExpress.XtraEditors.TextEdit();
            nameLabel = new System.Windows.Forms.Label();
            locLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(remarkLabel);
            this.pnlDetail.Controls.Add(this.remarkTextEdit);
            this.pnlDetail.Controls.Add(nameLabel);
            this.pnlDetail.Controls.Add(this.nameTextEdit);
            this.pnlDetail.Location = new System.Drawing.Point(0, 91);
            this.pnlDetail.Size = new System.Drawing.Size(536, 167);
            // 
            // pnlKey
            // 
            this.pnlKey.Controls.Add(locLabel);
            this.pnlKey.Controls.Add(this.locTextEdit);
            this.pnlKey.Size = new System.Drawing.Size(536, 66);
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(35, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(66, 13);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Nama Lokasi";
            // 
            // locLabel
            // 
            locLabel.AutoSize = true;
            locLabel.Location = new System.Drawing.Point(38, 43);
            locLabel.Name = "locLabel";
            locLabel.Size = new System.Drawing.Size(63, 13);
            locLabel.TabIndex = 0;
            locLabel.Text = "Kode Lokasi";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(42, 35);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(63, 13);
            remarkLabel.TabIndex = 2;
            remarkLabel.Text = "Keterangan";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locBindingSource
            // 
            this.locBindingSource.DataMember = "loc";
            this.locBindingSource.DataSource = this.casDataSet;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.locBindingSource, "name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(110, 6);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(261, 20);
            this.nameTextEdit.TabIndex = 1;
            // 
            // locTextEdit
            // 
            this.locTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.locBindingSource, "loc", true));
            this.locTextEdit.Location = new System.Drawing.Point(110, 40);
            this.locTextEdit.Name = "locTextEdit";
            this.locTextEdit.Size = new System.Drawing.Size(100, 20);
            this.locTextEdit.TabIndex = 1;
            // 
            // remarkTextEdit
            // 
            this.remarkTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.locBindingSource, "remark", true));
            this.remarkTextEdit.Location = new System.Drawing.Point(110, 32);
            this.remarkTextEdit.Name = "remarkTextEdit";
            this.remarkTextEdit.Size = new System.Drawing.Size(322, 20);
            this.remarkTextEdit.TabIndex = 3;
            // 
            // FrmMasterLoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(536, 325);
            this.MasterBindingSource = this.locBindingSource;
            this.MasterQuery = "select * from loc order by loc";
            this.MasterTable = this.casDataSet.loc;
            this.Name = "FrmMasterLoc";
            this.Text = "Master Gudang/Lokasi";
            this.Load += new System.EventHandler(this.FrmMasterLoc_Load);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.pnlKey.ResumeLayout(false);
            this.pnlKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource locBindingSource;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.TextEdit remarkTextEdit;
        private DevExpress.XtraEditors.TextEdit locTextEdit;
    }
}
