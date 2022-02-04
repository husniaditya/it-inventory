namespace CAS.Master
{
    partial class FrmMGrpHarga
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
            System.Windows.Forms.Label kodeLabel;
            System.Windows.Forms.Label namaLabel;
            System.Windows.Forms.Label ongkosLabel;
            this.casDataSet = new CAS.casDataSet();
            this.grphrgdasarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grphrgdasarTableAdapter = new CAS.casDataSetTableAdapters.grphrgdasarTableAdapter();
            this.kodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.namaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ongkosSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            kodeLabel = new System.Windows.Forms.Label();
            namaLabel = new System.Windows.Forms.Label();
            ongkosLabel = new System.Windows.Forms.Label();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grphrgdasarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongkosSpinEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(ongkosLabel);
            this.pnlDetail.Controls.Add(this.ongkosSpinEdit);
            this.pnlDetail.Controls.Add(namaLabel);
            this.pnlDetail.Controls.Add(this.namaTextEdit);
            this.pnlDetail.Location = new System.Drawing.Point(0, 68);
            this.pnlDetail.Size = new System.Drawing.Size(597, 70);
            // 
            // pnlKey
            // 
            this.pnlKey.Controls.Add(kodeLabel);
            this.pnlKey.Controls.Add(this.kodeTextEdit);
            this.pnlKey.Size = new System.Drawing.Size(597, 43);
            // 
            // kodeLabel
            // 
            kodeLabel.AutoSize = true;
            kodeLabel.Location = new System.Drawing.Point(45, 23);
            kodeLabel.Name = "kodeLabel";
            kodeLabel.Size = new System.Drawing.Size(68, 13);
            kodeLabel.TabIndex = 0;
            kodeLabel.Text = "Group Harga";
            // 
            // namaLabel
            // 
            namaLabel.AutoSize = true;
            namaLabel.Location = new System.Drawing.Point(79, 9);
            namaLabel.Name = "namaLabel";
            namaLabel.Size = new System.Drawing.Size(34, 13);
            namaLabel.TabIndex = 0;
            namaLabel.Text = "Nama";
            // 
            // ongkosLabel
            // 
            ongkosLabel.AutoSize = true;
            ongkosLabel.Location = new System.Drawing.Point(68, 35);
            ongkosLabel.Name = "ongkosLabel";
            ongkosLabel.Size = new System.Drawing.Size(43, 13);
            ongkosLabel.TabIndex = 2;
            ongkosLabel.Text = "Ongkos";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grphrgdasarBindingSource
            // 
            this.grphrgdasarBindingSource.DataMember = "grphrgdasar";
            this.grphrgdasarBindingSource.DataSource = this.casDataSet;
            // 
            // grphrgdasarTableAdapter
            // 
            this.grphrgdasarTableAdapter.ClearBeforeFill = true;
            // 
            // kodeTextEdit
            // 
            this.kodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.grphrgdasarBindingSource, "kode", true));
            this.kodeTextEdit.Location = new System.Drawing.Point(119, 20);
            this.kodeTextEdit.Name = "kodeTextEdit";
            this.kodeTextEdit.Size = new System.Drawing.Size(145, 20);
            this.kodeTextEdit.TabIndex = 1;
            // 
            // namaTextEdit
            // 
            this.namaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.grphrgdasarBindingSource, "nama", true));
            this.namaTextEdit.Location = new System.Drawing.Point(119, 6);
            this.namaTextEdit.Name = "namaTextEdit";
            this.namaTextEdit.Size = new System.Drawing.Size(296, 20);
            this.namaTextEdit.TabIndex = 1;
            // 
            // ongkosSpinEdit
            // 
            this.ongkosSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.grphrgdasarBindingSource, "ongkos", true));
            this.ongkosSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ongkosSpinEdit.Location = new System.Drawing.Point(119, 32);
            this.ongkosSpinEdit.Name = "ongkosSpinEdit";
            this.ongkosSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.ongkosSpinEdit.Properties.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.ongkosSpinEdit.Properties.UseCtrlIncrement = false;
            this.ongkosSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.ongkosSpinEdit.TabIndex = 3;
            // 
            // FrmMGrpHarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(597, 205);
            this.MasterBindingSource = this.grphrgdasarBindingSource;
            this.MasterQuery = "select * from grphrgdasar";
            this.MasterTable = this.casDataSet.grphrgdasar;
            this.Name = "FrmMGrpHarga";
            this.Load += new System.EventHandler(this.FrmMGrpHarga_Load);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.pnlKey.ResumeLayout(false);
            this.pnlKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grphrgdasarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongkosSpinEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource grphrgdasarBindingSource;
        private CAS.casDataSetTableAdapters.grphrgdasarTableAdapter grphrgdasarTableAdapter;
        private DevExpress.XtraEditors.TextEdit kodeTextEdit;
        private DevExpress.XtraEditors.SpinEdit ongkosSpinEdit;
        private DevExpress.XtraEditors.TextEdit namaTextEdit;
    }
}
