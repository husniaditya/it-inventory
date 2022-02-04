namespace CAS.Master
{
    partial class FrmMasterStation
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
            System.Windows.Forms.Label tag_numLabel;
            this.casDataSet = new CAS.casDataSet();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.stationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remarkTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.stationTableAdapter = new CAS.casDataSetTableAdapters.stationTableAdapter();
            this.tag_numTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.stationTextBox = new System.Windows.Forms.TextBox();
            nameLabel = new System.Windows.Forms.Label();
            locLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            tag_numLabel = new System.Windows.Forms.Label();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tag_numTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(tag_numLabel);
            this.pnlDetail.Controls.Add(this.tag_numTextEdit);
            this.pnlDetail.Controls.Add(remarkLabel);
            this.pnlDetail.Controls.Add(this.remarkTextEdit);
            this.pnlDetail.Controls.Add(nameLabel);
            this.pnlDetail.Controls.Add(this.nameTextEdit);
            this.pnlDetail.Location = new System.Drawing.Point(0, 101);
            this.pnlDetail.Size = new System.Drawing.Size(546, 113);
            // 
            // pnlKey
            // 
            this.pnlKey.Controls.Add(this.stationTextBox);
            this.pnlKey.Controls.Add(locLabel);
            this.pnlKey.Size = new System.Drawing.Size(546, 76);
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(35, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(71, 13);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Nama Station";
            // 
            // locLabel
            // 
            locLabel.AutoSize = true;
            locLabel.Location = new System.Drawing.Point(38, 43);
            locLabel.Name = "locLabel";
            locLabel.Size = new System.Drawing.Size(68, 13);
            locLabel.TabIndex = 0;
            locLabel.Text = "Kode Station";
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
            // tag_numLabel
            // 
            tag_numLabel.AutoSize = true;
            tag_numLabel.Location = new System.Drawing.Point(41, 61);
            tag_numLabel.Name = "tag_numLabel";
            tag_numLabel.Size = new System.Drawing.Size(63, 13);
            tag_numLabel.TabIndex = 4;
            tag_numLabel.Text = "Nomor Tera";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.stationBindingSource, "station_name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(110, 6);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(261, 20);
            this.nameTextEdit.TabIndex = 1;
            // 
            // stationBindingSource
            // 
            this.stationBindingSource.DataMember = "station";
            this.stationBindingSource.DataSource = this.casDataSet;
            // 
            // remarkTextEdit
            // 
            this.remarkTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.stationBindingSource, "remark", true));
            this.remarkTextEdit.Location = new System.Drawing.Point(110, 32);
            this.remarkTextEdit.Name = "remarkTextEdit";
            this.remarkTextEdit.Size = new System.Drawing.Size(322, 20);
            this.remarkTextEdit.TabIndex = 3;
            // 
            // stationTableAdapter
            // 
            this.stationTableAdapter.ClearBeforeFill = true;
            // 
            // tag_numTextEdit
            // 
            this.tag_numTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.stationBindingSource, "tag_num", true));
            this.tag_numTextEdit.Location = new System.Drawing.Point(110, 58);
            this.tag_numTextEdit.Name = "tag_numTextEdit";
            this.tag_numTextEdit.Size = new System.Drawing.Size(162, 20);
            this.tag_numTextEdit.TabIndex = 5;
            // 
            // stationTextBox
            // 
            this.stationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stationBindingSource, "station", true));
            this.stationTextBox.Location = new System.Drawing.Point(112, 43);
            this.stationTextBox.Name = "stationTextBox";
            this.stationTextBox.Size = new System.Drawing.Size(60, 20);
            this.stationTextBox.TabIndex = 2;
            // 
            // FrmMasterStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(546, 281);
            this.MasterBindingSource = this.stationBindingSource;
            this.MasterQuery = "select * from station order by station";
            this.MasterTable = this.casDataSet.station;
            this.Name = "FrmMasterStation";
            this.Text = "Master Station";
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.pnlKey.ResumeLayout(false);
            this.pnlKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tag_numTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.TextEdit remarkTextEdit;
        private System.Windows.Forms.BindingSource stationBindingSource;
        private CAS.casDataSetTableAdapters.stationTableAdapter stationTableAdapter;
        private DevExpress.XtraEditors.TextEdit tag_numTextEdit;
        private System.Windows.Forms.TextBox stationTextBox;
    }
}
