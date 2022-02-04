namespace CAS.Master
{
    partial class FrmMasterReason
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
            this.casDataSet = new CAS.casDataSet();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.rsnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usrpTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.aktifCheckBox = new System.Windows.Forms.CheckBox();
            this.rsnTableAdapter = new CAS.casDataSetTableAdapters.rsnTableAdapter();
            mtpLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            aktifLabel = new System.Windows.Forms.Label();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrpTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(aktifLabel);
            this.pnlDetail.Controls.Add(this.aktifCheckBox);
            this.pnlDetail.Controls.Add(this.nameTextEdit);
            this.pnlDetail.Controls.Add(nameLabel);
            this.pnlDetail.Location = new System.Drawing.Point(0, 76);
            this.pnlDetail.Size = new System.Drawing.Size(498, 134);
            // 
            // pnlKey
            // 
            this.pnlKey.Controls.Add(this.usrpTextEdit);
            this.pnlKey.Controls.Add(mtpLabel);
            this.pnlKey.Size = new System.Drawing.Size(498, 51);
            // 
            // mtpLabel
            // 
            mtpLabel.AutoSize = true;
            mtpLabel.Location = new System.Drawing.Point(60, 26);
            mtpLabel.Name = "mtpLabel";
            mtpLabel.Size = new System.Drawing.Size(43, 13);
            mtpLabel.TabIndex = 0;
            mtpLabel.Text = "Reason";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(62, 16);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(63, 13);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Keterangan";
            // 
            // aktifLabel
            // 
            aktifLabel.AutoSize = true;
            aktifLabel.Location = new System.Drawing.Point(96, 53);
            aktifLabel.Name = "aktifLabel";
            aktifLabel.Size = new System.Drawing.Size(29, 13);
            aktifLabel.TabIndex = 4;
            aktifLabel.Text = "Aktif";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rsnBindingSource, "remmark", true));
            this.nameTextEdit.Location = new System.Drawing.Point(149, 9);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nameTextEdit.Properties.MaxLength = 40;
            this.nameTextEdit.Size = new System.Drawing.Size(328, 20);
            this.nameTextEdit.TabIndex = 2;
            // 
            // rsnBindingSource
            // 
            this.rsnBindingSource.DataMember = "rsn";
            this.rsnBindingSource.DataSource = this.casDataSet;
            // 
            // usrpTextEdit
            // 
            this.usrpTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rsnBindingSource, "rsn", true));
            this.usrpTextEdit.Location = new System.Drawing.Point(149, 23);
            this.usrpTextEdit.Name = "usrpTextEdit";
            this.usrpTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.usrpTextEdit.Properties.MaxLength = 40;
            this.usrpTextEdit.Size = new System.Drawing.Size(328, 20);
            this.usrpTextEdit.TabIndex = 2;
            // 
            // aktifCheckBox
            // 
            this.aktifCheckBox.Checked = true;
            this.aktifCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aktifCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.rsnBindingSource, "aktif", true));
            this.aktifCheckBox.Location = new System.Drawing.Point(149, 48);
            this.aktifCheckBox.Name = "aktifCheckBox";
            this.aktifCheckBox.Size = new System.Drawing.Size(104, 24);
            this.aktifCheckBox.TabIndex = 5;
            // 
            // rsnTableAdapter
            // 
            this.rsnTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMasterReason
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(498, 277);
            this.MasterBindingSource = this.rsnBindingSource;
            this.MasterQuery = "select * from rsn order by rsn";
            this.MasterTable = this.casDataSet.rsn;
            this.Name = "FrmMasterReason";
            this.Text = "Master Reason";
            this.Load += new System.EventHandler(this.FrmMasterReason_Load);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.pnlKey.ResumeLayout(false);
            this.pnlKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrpTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.TextEdit usrpTextEdit;
        private System.Windows.Forms.CheckBox aktifCheckBox;
        private System.Windows.Forms.BindingSource rsnBindingSource;
        private CAS.casDataSetTableAdapters.rsnTableAdapter rsnTableAdapter;
    }
}
