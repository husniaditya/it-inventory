namespace CAS.Master
{
    partial class FrmMasterCur
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
            this.curLabel = new System.Windows.Forms.Label();
            this.casDataSet = new CAS.casDataSet();
            this.curBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.curTableAdapter = new CAS.casDataSetTableAdapters.curTableAdapter();
            this.curTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.khrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khrTableAdapter = new CAS.casDataSetTableAdapters.khrTableAdapter();
            this.gcKhr = new KASLibrary.GridControlEx();
            nameLabel = new System.Windows.Forms.Label();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khrBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.gcKhr);
            this.pnlDetail.Controls.Add(nameLabel);
            this.pnlDetail.Controls.Add(this.nameTextEdit);
            this.pnlDetail.Size = new System.Drawing.Size(635, 354);
            // 
            // pnlKey
            // 
            this.pnlKey.Controls.Add(this.curLabel);
            this.pnlKey.Controls.Add(this.curTextEdit);
            this.pnlKey.Size = new System.Drawing.Size(635, 56);
            // 
            // pnlChInfo
            // 
            this.pnlChInfo.Location = new System.Drawing.Point(0, 435);
            this.pnlChInfo.Size = new System.Drawing.Size(635, 45);
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(32, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(41, 13);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name :";
            // 
            // curLabel
            // 
            this.curLabel.AutoSize = true;
            this.curLabel.Location = new System.Drawing.Point(43, 30);
            this.curLabel.Name = "curLabel";
            this.curLabel.Size = new System.Drawing.Size(31, 13);
            this.curLabel.TabIndex = 0;
            this.curLabel.Text = "Cur :";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // curBindingSource
            // 
            this.curBindingSource.DataMember = "cur";
            this.curBindingSource.DataSource = this.casDataSet;
            // 
            // curTableAdapter
            // 
            this.curTableAdapter.ClearBeforeFill = true;
            // 
            // curTextEdit
            // 
            this.curTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.curBindingSource, "cur", true));
            this.curTextEdit.Location = new System.Drawing.Point(74, 30);
            this.curTextEdit.Name = "curTextEdit";
            this.curTextEdit.Size = new System.Drawing.Size(100, 20);
            this.curTextEdit.TabIndex = 1;
            this.curTextEdit.EditValueChanged += new System.EventHandler(this.curTextEdit_EditValueChanged);
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.curBindingSource, "name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(74, 6);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(264, 20);
            this.nameTextEdit.TabIndex = 1;
            // 
            // khrBindingSource
            // 
            this.khrBindingSource.DataMember = "khr";
            this.khrBindingSource.DataSource = this.casDataSet;
            // 
            // khrTableAdapter
            // 
            this.khrTableAdapter.ClearBeforeFill = true;
            // 
            // gcKhr
            // 
            this.gcKhr.BestFitColumn = true;
            this.gcKhr.ExAutoSize = false;
            this.gcKhr.Location = new System.Drawing.Point(22, 39);
            this.gcKhr.Name = "gcKhr";
            this.gcKhr.Size = new System.Drawing.Size(593, 294);
            this.gcKhr.TabIndex = 2;
            // 
            // FrmMasterCur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(635, 502);
            this.MasterBindingSource = this.curBindingSource;
            this.MasterQuery = "select * from cur";
            this.MasterTable = this.casDataSet.cur;
            this.Name = "FrmMasterCur";
            this.Text = "Master Currency";
            this.Load += new System.EventHandler(this.FrmMasterCur_Load);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.pnlKey.ResumeLayout(false);
            this.pnlKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khrBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource curBindingSource;
        private CAS.casDataSetTableAdapters.curTableAdapter curTableAdapter;
        private DevExpress.XtraEditors.TextEdit curTextEdit;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private System.Windows.Forms.BindingSource khrBindingSource;
        private CAS.casDataSetTableAdapters.khrTableAdapter khrTableAdapter;
        private KASLibrary.GridControlEx gcKhr;
        private System.Windows.Forms.Label curLabel;
    }
}
