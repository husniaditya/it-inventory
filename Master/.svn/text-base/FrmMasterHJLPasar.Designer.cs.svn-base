namespace CAS.Master
{
    partial class FrmMasterHJLPasar
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
            System.Windows.Forms.Label invLabel;
            System.Windows.Forms.Label nameLabel;
            this.casDataSet = new CAS.casDataSet();
            this.invBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invTableAdapter = new CAS.casDataSetTableAdapters.invTableAdapter();
            this.invTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hjlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hjlTableAdapter = new CAS.casDataSetTableAdapters.hjlTableAdapter();
            this.gcHjl = new KASLibrary.GridControlEx();
            invLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hjlBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.gcHjl);
            this.pnlDetail.Controls.Add(nameLabel);
            this.pnlDetail.Controls.Add(this.nameTextEdit);
            this.pnlDetail.Size = new System.Drawing.Size(632, 375);
            // 
            // pnlKey
            // 
            this.pnlKey.Controls.Add(invLabel);
            this.pnlKey.Controls.Add(this.invTextEdit);
            this.pnlKey.Size = new System.Drawing.Size(632, 56);
            // 
            // invLabel
            // 
            invLabel.AutoSize = true;
            invLabel.Location = new System.Drawing.Point(58, 19);
            invLabel.Name = "invLabel";
            invLabel.Size = new System.Drawing.Size(25, 13);
            invLabel.TabIndex = 0;
            invLabel.Text = "inv:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(46, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(37, 13);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "name:";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invBindingSource
            // 
            this.invBindingSource.DataMember = "inv";
            this.invBindingSource.DataSource = this.casDataSet;
            // 
            // invTableAdapter
            // 
            this.invTableAdapter.ClearBeforeFill = true;
            // 
            // invTextEdit
            // 
            this.invTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.invBindingSource, "inv", true));
            this.invTextEdit.Enabled = false;
            this.invTextEdit.Location = new System.Drawing.Point(89, 16);
            this.invTextEdit.Name = "invTextEdit";
            this.invTextEdit.Size = new System.Drawing.Size(100, 20);
            this.invTextEdit.TabIndex = 1;
            this.invTextEdit.EditValueChanged += new System.EventHandler(this.invTextEdit_EditValueChanged);
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.invBindingSource, "name", true));
            this.nameTextEdit.Enabled = false;
            this.nameTextEdit.Location = new System.Drawing.Point(89, 6);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(100, 20);
            this.nameTextEdit.TabIndex = 1;
            // 
            // hjlBindingSource
            // 
            this.hjlBindingSource.DataMember = "hjl";
            this.hjlBindingSource.DataSource = this.casDataSet;
            // 
            // hjlTableAdapter
            // 
            this.hjlTableAdapter.ClearBeforeFill = true;
            // 
            // gcHjl
            // 
            this.gcHjl.BestFitColumn = true;
            this.gcHjl.ExAutoSize = false;
            this.gcHjl.Location = new System.Drawing.Point(35, 45);
            this.gcHjl.Name = "gcHjl";
            this.gcHjl.Size = new System.Drawing.Size(527, 271);
            this.gcHjl.TabIndex = 3;
            // 
            // FrmMasterHJLPasar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(632, 523);
            this.MasterBindingSource = this.invBindingSource;
            this.MasterQuery = "select * from inv ";
            this.MasterTable = this.casDataSet.inv;
            this.Name = "FrmMasterHJLPasar";
            this.Text = "Master Harga Jual Pasar";
            this.Load += new System.EventHandler(this.FrmMasterHJLPasar_Load);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.pnlKey.ResumeLayout(false);
            this.pnlKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hjlBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource invBindingSource;
        private CAS.casDataSetTableAdapters.invTableAdapter invTableAdapter;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.TextEdit invTextEdit;
        private System.Windows.Forms.BindingSource hjlBindingSource;
        private CAS.casDataSetTableAdapters.hjlTableAdapter hjlTableAdapter;
        private KASLibrary.GridControlEx gcHjl;
    }
}
