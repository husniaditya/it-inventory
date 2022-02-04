namespace CAS.Master
{
    partial class FrmMasterMsn
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
            System.Windows.Forms.Label aktifLabel;
            this.mtpTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.msnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casDataSet = new CAS.casDataSet();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.msnTableAdapter = new CAS.casDataSetTableAdapters.msnTableAdapter();
            this.aktifCheckBox = new System.Windows.Forms.CheckBox();
            mtpLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            aktifLabel = new System.Windows.Forms.Label();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mtpTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(aktifLabel);
            this.pnlDetail.Controls.Add(nameLabel);
            this.pnlDetail.Controls.Add(this.aktifCheckBox);
            this.pnlDetail.Controls.Add(this.nameTextEdit);
            this.pnlDetail.Location = new System.Drawing.Point(0, 67);
            this.pnlDetail.Size = new System.Drawing.Size(524, 87);
            // 
            // pnlKey
            // 
            this.pnlKey.Controls.Add(mtpLabel);
            this.pnlKey.Controls.Add(this.mtpTextEdit);
            this.pnlKey.Size = new System.Drawing.Size(524, 42);
            // 
            // mtpLabel
            // 
            mtpLabel.AutoSize = true;
            mtpLabel.Location = new System.Drawing.Point(60, 21);
            mtpLabel.Name = "mtpLabel";
            mtpLabel.Size = new System.Drawing.Size(61, 13);
            mtpLabel.TabIndex = 0;
            mtpLabel.Text = "Kode Mesin";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(60, 33);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(64, 13);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Nama Mesin";
            // 
            // aktifLabel
            // 
            aktifLabel.AutoSize = true;
            aktifLabel.Location = new System.Drawing.Point(92, 7);
            aktifLabel.Name = "aktifLabel";
            aktifLabel.Size = new System.Drawing.Size(29, 13);
            aktifLabel.TabIndex = 2;
            aktifLabel.Text = "Aktif";
            // 
            // mtpTextEdit
            // 
            this.mtpTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.msnBindingSource, "msn", true));
            this.mtpTextEdit.Location = new System.Drawing.Point(146, 18);
            this.mtpTextEdit.Name = "mtpTextEdit";
            this.mtpTextEdit.Size = new System.Drawing.Size(100, 20);
            this.mtpTextEdit.TabIndex = 1;
            // 
            // msnBindingSource
            // 
            this.msnBindingSource.DataMember = "msn";
            this.msnBindingSource.DataSource = this.casDataSet;
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.msnBindingSource, "name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(146, 30);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(261, 20);
            this.nameTextEdit.TabIndex = 1;
            // 
            // msnTableAdapter
            // 
            this.msnTableAdapter.ClearBeforeFill = true;
            // 
            // aktifCheckBox
            // 
            this.aktifCheckBox.Checked = true;
            this.aktifCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aktifCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.msnBindingSource, "aktif", true));
            this.aktifCheckBox.Location = new System.Drawing.Point(146, 2);
            this.aktifCheckBox.Name = "aktifCheckBox";
            this.aktifCheckBox.Size = new System.Drawing.Size(26, 24);
            this.aktifCheckBox.TabIndex = 3;
            // 
            // FrmMasterMsn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(524, 221);
            this.MasterBindingSource = this.msnBindingSource;
            this.MasterQuery = "select * from msn order by msn";
            this.MasterTable = this.casDataSet.msn;
            this.Name = "FrmMasterMsn";
            this.Text = "Master Mesin";
            this.Load += new System.EventHandler(this.FrmMasterMtp_Load);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.pnlKey.ResumeLayout(false);
            this.pnlKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mtpTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit mtpTextEdit;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource msnBindingSource;
        private CAS.casDataSetTableAdapters.msnTableAdapter msnTableAdapter;
        private System.Windows.Forms.CheckBox aktifCheckBox;
    }
}
