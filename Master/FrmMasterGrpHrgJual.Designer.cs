namespace CAS.Master
{
    partial class FrmMasterGrpHrgJual
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
            System.Windows.Forms.Label grphrgjlLabel;
            System.Windows.Forms.Label keteranganLabel;
            this.casDataSet = new CAS.casDataSet();
            this.grphrgjlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grphrgjlTableAdapter = new CAS.casDataSetTableAdapters.grphrgjlTableAdapter();
            this.grphrgjlTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.keteranganTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.gcsubto = new KASLibrary.GridControlEx();
            this.grphrgjldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grphrgjldTableAdapter = new CAS.casDataSetTableAdapters.grphrgjldTableAdapter();
            grphrgjlLabel = new System.Windows.Forms.Label();
            keteranganLabel = new System.Windows.Forms.Label();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grphrgjlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grphrgjlTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keteranganTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grphrgjldBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.gcsubto);
            this.pnlDetail.Controls.Add(keteranganLabel);
            this.pnlDetail.Controls.Add(this.keteranganTextEdit);
            this.pnlDetail.Size = new System.Drawing.Size(585, 439);
            // 
            // pnlKey
            // 
            this.pnlKey.Controls.Add(this.grphrgjlTextEdit);
            this.pnlKey.Controls.Add(grphrgjlLabel);
            this.pnlKey.Size = new System.Drawing.Size(585, 56);
            // 
            // grphrgjlLabel
            // 
            grphrgjlLabel.AutoSize = true;
            grphrgjlLabel.Location = new System.Drawing.Point(30, 33);
            grphrgjlLabel.Name = "grphrgjlLabel";
            grphrgjlLabel.Size = new System.Drawing.Size(112, 13);
            grphrgjlLabel.TabIndex = 0;
            grphrgjlLabel.Text = "Kode Group Customer";
            // 
            // keteranganLabel
            // 
            keteranganLabel.AutoSize = true;
            keteranganLabel.Location = new System.Drawing.Point(79, 18);
            keteranganLabel.Name = "keteranganLabel";
            keteranganLabel.Size = new System.Drawing.Size(63, 13);
            keteranganLabel.TabIndex = 2;
            keteranganLabel.Text = "Keterangan";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grphrgjlBindingSource
            // 
            this.grphrgjlBindingSource.DataMember = "grphrgjl";
            this.grphrgjlBindingSource.DataSource = this.casDataSet;
            // 
            // grphrgjlTableAdapter
            // 
            this.grphrgjlTableAdapter.ClearBeforeFill = true;
            // 
            // grphrgjlTextEdit
            // 
            this.grphrgjlTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.grphrgjlBindingSource, "grphrgjl", true));
            this.grphrgjlTextEdit.Location = new System.Drawing.Point(148, 30);
            this.grphrgjlTextEdit.Name = "grphrgjlTextEdit";
            this.grphrgjlTextEdit.Size = new System.Drawing.Size(100, 20);
            this.grphrgjlTextEdit.TabIndex = 1;
            this.grphrgjlTextEdit.EditValueChanged += new System.EventHandler(this.grphrgjlTextEdit_EditValueChanged);
            // 
            // keteranganTextEdit
            // 
            this.keteranganTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.grphrgjlBindingSource, "keterangan", true));
            this.keteranganTextEdit.Location = new System.Drawing.Point(148, 15);
            this.keteranganTextEdit.Name = "keteranganTextEdit";
            this.keteranganTextEdit.Size = new System.Drawing.Size(100, 20);
            this.keteranganTextEdit.TabIndex = 3;
            // 
            // gcsubto
            // 
            this.gcsubto.BestFitColumn = true;
            this.gcsubto.ExAutoSize = false;
            this.gcsubto.Location = new System.Drawing.Point(33, 63);
            this.gcsubto.Name = "gcsubto";
            this.gcsubto.Size = new System.Drawing.Size(540, 352);
            this.gcsubto.TabIndex = 58;
            // 
            // grphrgjldBindingSource
            // 
            this.grphrgjldBindingSource.DataMember = "grphrgjld";
            this.grphrgjldBindingSource.DataSource = this.casDataSet;
            // 
            // grphrgjldTableAdapter
            // 
            this.grphrgjldTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMasterGrpHrgJual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(585, 587);
            this.MasterBindingSource = this.grphrgjlBindingSource;
            this.MasterQuery = "select * from grphrgjl";
            this.MasterTable = this.casDataSet.grphrgjl;
            this.Name = "FrmMasterGrpHrgJual";
            this.Load += new System.EventHandler(this.FrmMasterGrpHrgJual_Load);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.pnlKey.ResumeLayout(false);
            this.pnlKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grphrgjlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grphrgjlTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keteranganTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grphrgjldBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource grphrgjlBindingSource;
        private CAS.casDataSetTableAdapters.grphrgjlTableAdapter grphrgjlTableAdapter;
        private DevExpress.XtraEditors.TextEdit grphrgjlTextEdit;
        private DevExpress.XtraEditors.TextEdit keteranganTextEdit;
        private KASLibrary.GridControlEx gcsubto;
        private System.Windows.Forms.BindingSource grphrgjldBindingSource;
        private CAS.casDataSetTableAdapters.grphrgjldTableAdapter grphrgjldTableAdapter;
    }
}
