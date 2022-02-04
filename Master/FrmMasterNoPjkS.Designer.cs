namespace CAS.Master
{
    partial class FrmMasterNoPjkS
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
            this.casDataSet = new CAS.casDataSet();
            this.curLabel = new System.Windows.Forms.Label();
            this.gcPjks = new KASLibrary.GridControlEx();
            this.subTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.subBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.namaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.subTableAdapter = new CAS.casDataSetTableAdapters.subTableAdapter();
            this.no_pjksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.no_pjksTableAdapter = new CAS.casDataSetTableAdapters.no_pjksTableAdapter();
            nameLabel = new System.Windows.Forms.Label();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_pjksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.namaTextEdit);
            this.pnlDetail.Controls.Add(nameLabel);
            this.pnlDetail.Controls.Add(this.gcPjks);
            this.pnlDetail.Size = new System.Drawing.Size(598, 361);
            // 
            // pnlKey
            // 
            this.pnlKey.Controls.Add(this.subTextEdit);
            this.pnlKey.Controls.Add(this.curLabel);
            this.pnlKey.Size = new System.Drawing.Size(598, 56);
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(32, 21);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(82, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Nama Supplier :";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // curLabel
            // 
            this.curLabel.AutoSize = true;
            this.curLabel.Location = new System.Drawing.Point(32, 17);
            this.curLabel.Name = "curLabel";
            this.curLabel.Size = new System.Drawing.Size(79, 13);
            this.curLabel.TabIndex = 4;
            this.curLabel.Text = "Kode Supplier :";
            // 
            // gcPjks
            // 
            this.gcPjks.BestFitColumn = true;
            this.gcPjks.ExAutoSize = false;
            this.gcPjks.Location = new System.Drawing.Point(25, 47);
            this.gcPjks.Name = "gcPjks";
            this.gcPjks.Size = new System.Drawing.Size(527, 294);
            this.gcPjks.TabIndex = 7;
            // 
            // subTextEdit
            // 
            this.subTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.subBindingSource, "sub", true));
            this.subTextEdit.Location = new System.Drawing.Point(119, 15);
            this.subTextEdit.Name = "subTextEdit";
            this.subTextEdit.Size = new System.Drawing.Size(100, 20);
            this.subTextEdit.TabIndex = 5;
            this.subTextEdit.EditValueChanged += new System.EventHandler(this.subTextEdit_EditValueChanged);
            // 
            // subBindingSource
            // 
            this.subBindingSource.DataMember = "sub";
            this.subBindingSource.DataSource = this.casDataSet;
            // 
            // namaTextEdit
            // 
            this.namaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.subBindingSource, "name", true));
            this.namaTextEdit.Location = new System.Drawing.Point(119, 18);
            this.namaTextEdit.Name = "namaTextEdit";
            this.namaTextEdit.Size = new System.Drawing.Size(264, 20);
            this.namaTextEdit.TabIndex = 6;
            // 
            // subTableAdapter
            // 
            this.subTableAdapter.ClearBeforeFill = true;
            // 
            // no_pjksBindingSource
            // 
            this.no_pjksBindingSource.DataMember = "no_pjks";
            this.no_pjksBindingSource.DataSource = this.casDataSet;
            // 
            // no_pjksTableAdapter
            // 
            this.no_pjksTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMasterNoPjkS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(598, 509);
            this.MasterBindingSource = this.subBindingSource;
            this.MasterQuery = "select * from sub where group_=\'1\'";
            this.MasterTable = this.casDataSet.sub;
            this.Name = "FrmMasterNoPjkS";
            this.Text = "Master Pajak Supplier";
            this.Load += new System.EventHandler(this.FrmMasterNoPjks_Load);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.pnlKey.ResumeLayout(false);
            this.pnlKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_pjksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private DevExpress.XtraEditors.TextEdit namaTextEdit;
        private KASLibrary.GridControlEx gcPjks;
        private DevExpress.XtraEditors.TextEdit subTextEdit;
        private System.Windows.Forms.Label curLabel;
        private System.Windows.Forms.BindingSource subBindingSource;
        private CAS.casDataSetTableAdapters.subTableAdapter subTableAdapter;
        private System.Windows.Forms.BindingSource no_pjksBindingSource;
        private CAS.casDataSetTableAdapters.no_pjksTableAdapter no_pjksTableAdapter;
    }
}
