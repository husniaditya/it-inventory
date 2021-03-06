namespace CAS.Master
{
    partial class FrmMasterFormula
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label nameLabel;
            this.casDataSet = new CAS.casDataSet();
            this.gcfmd = new KASLibrary.GridControlEx();
            this.keteranganTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.fmlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.fmlLabel = new System.Windows.Forms.Label();
            this.fmlTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.fmlTableAdapter = new CAS.casDataSetTableAdapters.fmlTableAdapter();
            this.fmdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fmdTableAdapter = new CAS.casDataSetTableAdapters.fmdTableAdapter();
            this.gcfmc = new KASLibrary.GridControlEx();
            this.fmcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fmcTableAdapter = new CAS.casDataSetTableAdapters.fmcTableAdapter();
            label2 = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keteranganTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fmlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fmlTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fmdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fmcBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.gcfmc);
            this.pnlDetail.Controls.Add(this.keteranganTextEdit);
            this.pnlDetail.Controls.Add(label2);
            this.pnlDetail.Controls.Add(nameLabel);
            this.pnlDetail.Controls.Add(this.nameTextEdit);
            this.pnlDetail.Controls.Add(this.fmlLabel);
            this.pnlDetail.Controls.Add(this.fmlTextEdit);
            this.pnlDetail.Controls.Add(this.gcfmd);
            this.pnlDetail.Location = new System.Drawing.Point(0, 35);
            this.pnlDetail.Size = new System.Drawing.Size(625, 489);
            // 
            // pnlKey
            // 
            this.pnlKey.Size = new System.Drawing.Size(625, 10);
            // 
            // pnlChInfo
            // 
            this.pnlChInfo.Location = new System.Drawing.Point(0, 524);
            this.pnlChInfo.Size = new System.Drawing.Size(625, 45);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(25, 60);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(63, 13);
            label2.TabIndex = 33;
            label2.Text = "Desciption :";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(47, 34);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(41, 13);
            nameLabel.TabIndex = 31;
            nameLabel.Text = "Name :";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gcfmd
            // 
            this.gcfmd.BestFitColumn = true;
            this.gcfmd.ExAutoSize = false;
            this.gcfmd.Location = new System.Drawing.Point(28, 81);
            this.gcfmd.Name = "gcfmd";
            this.gcfmd.Size = new System.Drawing.Size(571, 196);
            this.gcfmd.TabIndex = 28;
            // 
            // keteranganTextEdit
            // 
            this.keteranganTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.fmlBindingSource, "desc", true));
            this.keteranganTextEdit.Location = new System.Drawing.Point(94, 57);
            this.keteranganTextEdit.Name = "keteranganTextEdit";
            this.keteranganTextEdit.Size = new System.Drawing.Size(461, 20);
            this.keteranganTextEdit.TabIndex = 34;
            // 
            // fmlBindingSource
            // 
            this.fmlBindingSource.DataMember = "fml";
            this.fmlBindingSource.DataSource = this.casDataSet;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.fmlBindingSource, "name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(94, 31);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(264, 20);
            this.nameTextEdit.TabIndex = 32;
            // 
            // fmlLabel
            // 
            this.fmlLabel.AutoSize = true;
            this.fmlLabel.Location = new System.Drawing.Point(36, 8);
            this.fmlLabel.Name = "fmlLabel";
            this.fmlLabel.Size = new System.Drawing.Size(52, 13);
            this.fmlLabel.TabIndex = 29;
            this.fmlLabel.Text = "Formula :";
            // 
            // fmlTextEdit
            // 
            this.fmlTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.fmlBindingSource, "fml", true));
            this.fmlTextEdit.Location = new System.Drawing.Point(94, 5);
            this.fmlTextEdit.Name = "fmlTextEdit";
            this.fmlTextEdit.Size = new System.Drawing.Size(100, 20);
            this.fmlTextEdit.TabIndex = 30;
            this.fmlTextEdit.EditValueChanged += new System.EventHandler(this.fmlTextEdit_EditValueChanged);
            // 
            // fmlTableAdapter
            // 
            this.fmlTableAdapter.ClearBeforeFill = true;
            // 
            // fmdBindingSource
            // 
            this.fmdBindingSource.DataMember = "fmd";
            this.fmdBindingSource.DataSource = this.casDataSet;
            // 
            // fmdTableAdapter
            // 
            this.fmdTableAdapter.ClearBeforeFill = true;
            // 
            // gcfmc
            // 
            this.gcfmc.BestFitColumn = true;
            this.gcfmc.ExAutoSize = false;
            this.gcfmc.Location = new System.Drawing.Point(28, 282);
            this.gcfmc.Name = "gcfmc";
            this.gcfmc.Size = new System.Drawing.Size(571, 196);
            this.gcfmc.TabIndex = 35;
            // 
            // fmcBindingSource
            // 
            this.fmcBindingSource.DataMember = "fmc";
            this.fmcBindingSource.DataSource = this.casDataSet;
            // 
            // fmcTableAdapter
            // 
            this.fmcTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMasterFormula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(625, 591);
            this.MasterBindingSource = this.fmlBindingSource;
            this.MasterQuery = "select * from fml";
            this.MasterTable = this.casDataSet.fml;
            this.Name = "FrmMasterFormula";
            this.Load += new System.EventHandler(this.FrmMasterFormula_Load);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keteranganTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fmlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fmlTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fmdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fmcBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private KASLibrary.GridControlEx gcfmd;
        private DevExpress.XtraEditors.TextEdit keteranganTextEdit;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private System.Windows.Forms.Label fmlLabel;
        private DevExpress.XtraEditors.TextEdit fmlTextEdit;
        private System.Windows.Forms.BindingSource fmlBindingSource;
        private CAS.casDataSetTableAdapters.fmlTableAdapter fmlTableAdapter;
        private System.Windows.Forms.BindingSource fmdBindingSource;
        private CAS.casDataSetTableAdapters.fmdTableAdapter fmdTableAdapter;
        private KASLibrary.GridControlEx gcfmc;
        private System.Windows.Forms.BindingSource fmcBindingSource;
        private CAS.casDataSetTableAdapters.fmcTableAdapter fmcTableAdapter;
    }
}
