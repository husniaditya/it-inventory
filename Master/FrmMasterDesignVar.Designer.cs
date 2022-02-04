namespace CAS.Master
{
    partial class FrmMasterDesignVar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMasterDesignVar));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpType = new System.Windows.Forms.TabPage();
            this.gcxType = new KASLibrary.GridControlEx();
            this.tpRumus = new System.Windows.Forms.TabPage();
            this.gcxRumus = new KASLibrary.GridControlEx();
            this.tpUkuran = new System.Windows.Forms.TabPage();
            this.gcxUkuran = new KASLibrary.GridControlEx();
            this.tpWarna = new System.Windows.Forms.TabPage();
            this.gcxWarna = new KASLibrary.GridControlEx();
            this.toolStripMasterDesingVar = new System.Windows.Forms.ToolStrip();
            this.tsbtnCancel = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casDataSet = new CAS.casDataSet();
            this.typeTableAdapter = new CAS.casDataSetTableAdapters.typeTableAdapter();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gcxKertas = new KASLibrary.GridControlEx();
            this.tabControl1.SuspendLayout();
            this.tpType.SuspendLayout();
            this.tpRumus.SuspendLayout();
            this.tpUkuran.SuspendLayout();
            this.tpWarna.SuspendLayout();
            this.toolStripMasterDesingVar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpType);
            this.tabControl1.Controls.Add(this.tpRumus);
            this.tabControl1.Controls.Add(this.tpUkuran);
            this.tabControl1.Controls.Add(this.tpWarna);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(569, 318);
            this.tabControl1.TabIndex = 0;
            // 
            // tpType
            // 
            this.tpType.Controls.Add(this.gcxType);
            this.tpType.Location = new System.Drawing.Point(4, 22);
            this.tpType.Name = "tpType";
            this.tpType.Padding = new System.Windows.Forms.Padding(3);
            this.tpType.Size = new System.Drawing.Size(561, 292);
            this.tpType.TabIndex = 0;
            this.tpType.Text = "Type";
            this.tpType.UseVisualStyleBackColor = true;
            // 
            // gcxType
            // 
            this.gcxType.BestFitColumn = true;
            this.gcxType.ExAutoSize = false;
            this.gcxType.Location = new System.Drawing.Point(15, 3);
            this.gcxType.Name = "gcxType";
            this.gcxType.Size = new System.Drawing.Size(406, 239);
            this.gcxType.TabIndex = 0;
            // 
            // tpRumus
            // 
            this.tpRumus.Controls.Add(this.gcxRumus);
            this.tpRumus.Location = new System.Drawing.Point(4, 22);
            this.tpRumus.Name = "tpRumus";
            this.tpRumus.Padding = new System.Windows.Forms.Padding(3);
            this.tpRumus.Size = new System.Drawing.Size(561, 292);
            this.tpRumus.TabIndex = 1;
            this.tpRumus.Text = "Rumus";
            this.tpRumus.UseVisualStyleBackColor = true;
            // 
            // gcxRumus
            // 
            this.gcxRumus.BestFitColumn = true;
            this.gcxRumus.ExAutoSize = false;
            this.gcxRumus.Location = new System.Drawing.Point(15, 6);
            this.gcxRumus.Name = "gcxRumus";
            this.gcxRumus.Size = new System.Drawing.Size(531, 256);
            this.gcxRumus.TabIndex = 0;
            // 
            // tpUkuran
            // 
            this.tpUkuran.Controls.Add(this.gcxUkuran);
            this.tpUkuran.Location = new System.Drawing.Point(4, 22);
            this.tpUkuran.Name = "tpUkuran";
            this.tpUkuran.Padding = new System.Windows.Forms.Padding(3);
            this.tpUkuran.Size = new System.Drawing.Size(561, 292);
            this.tpUkuran.TabIndex = 2;
            this.tpUkuran.Text = "Ukuran";
            this.tpUkuran.UseVisualStyleBackColor = true;
            // 
            // gcxUkuran
            // 
            this.gcxUkuran.BestFitColumn = true;
            this.gcxUkuran.ExAutoSize = false;
            this.gcxUkuran.Location = new System.Drawing.Point(17, 6);
            this.gcxUkuran.Name = "gcxUkuran";
            this.gcxUkuran.Size = new System.Drawing.Size(406, 241);
            this.gcxUkuran.TabIndex = 0;
            // 
            // tpWarna
            // 
            this.tpWarna.Controls.Add(this.gcxWarna);
            this.tpWarna.Location = new System.Drawing.Point(4, 22);
            this.tpWarna.Name = "tpWarna";
            this.tpWarna.Padding = new System.Windows.Forms.Padding(3);
            this.tpWarna.Size = new System.Drawing.Size(561, 292);
            this.tpWarna.TabIndex = 3;
            this.tpWarna.Text = "Warna";
            this.tpWarna.UseVisualStyleBackColor = true;
            // 
            // gcxWarna
            // 
            this.gcxWarna.BestFitColumn = true;
            this.gcxWarna.ExAutoSize = false;
            this.gcxWarna.Location = new System.Drawing.Point(15, 6);
            this.gcxWarna.Name = "gcxWarna";
            this.gcxWarna.Size = new System.Drawing.Size(406, 239);
            this.gcxWarna.TabIndex = 1;
            // 
            // toolStripMasterDesingVar
            // 
            this.toolStripMasterDesingVar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnCancel,
            this.tsbtnSave});
            this.toolStripMasterDesingVar.Location = new System.Drawing.Point(0, 0);
            this.toolStripMasterDesingVar.Name = "toolStripMasterDesingVar";
            this.toolStripMasterDesingVar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripMasterDesingVar.Size = new System.Drawing.Size(572, 25);
            this.toolStripMasterDesingVar.TabIndex = 5;
            this.toolStripMasterDesingVar.Text = "toolStrip1";
            // 
            // tsbtnCancel
            // 
            this.tsbtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCancel.Image")));
            this.tsbtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCancel.Name = "tsbtnCancel";
            this.tsbtnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsbtnCancel.Size = new System.Drawing.Size(59, 22);
            this.tsbtnCancel.Text = "Cancel";
            this.tsbtnCancel.Click += new System.EventHandler(this.tsbtnCancel_Click);
            // 
            // tsbtnSave
            // 
            this.tsbtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSave.Image")));
            this.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSave.Name = "tsbtnSave";
            this.tsbtnSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsbtnSave.Size = new System.Drawing.Size(51, 22);
            this.tsbtnSave.Text = "&Save";
            this.tsbtnSave.Click += new System.EventHandler(this.tsbtnSave_Click);
            // 
            // typeBindingSource
            // 
            this.typeBindingSource.DataMember = "type";
            this.typeBindingSource.DataSource = this.casDataSet;
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeTableAdapter
            // 
            this.typeTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gcxKertas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(561, 292);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Kertas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gcxKertas
            // 
            this.gcxKertas.BestFitColumn = true;
            this.gcxKertas.ExAutoSize = false;
            this.gcxKertas.Location = new System.Drawing.Point(18, 20);
            this.gcxKertas.Name = "gcxKertas";
            this.gcxKertas.Size = new System.Drawing.Size(406, 239);
            this.gcxKertas.TabIndex = 2;
            // 
            // FrmMasterDesignVar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 347);
            this.Controls.Add(this.toolStripMasterDesingVar);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmMasterDesignVar";
            this.Text = "Design Variables";
            this.Load += new System.EventHandler(this.FrmMasterDesignVar_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpType.ResumeLayout(false);
            this.tpRumus.ResumeLayout(false);
            this.tpUkuran.ResumeLayout(false);
            this.tpWarna.ResumeLayout(false);
            this.toolStripMasterDesingVar.ResumeLayout(false);
            this.toolStripMasterDesingVar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpType;
        private System.Windows.Forms.TabPage tpRumus;
        private System.Windows.Forms.TabPage tpUkuran;
        private System.Windows.Forms.BindingSource typeBindingSource;
        private casDataSet casDataSet;
        private CAS.casDataSetTableAdapters.typeTableAdapter typeTableAdapter;
        private KASLibrary.GridControlEx gcxType;
        private System.Windows.Forms.ToolStrip toolStripMasterDesingVar;
        private System.Windows.Forms.ToolStripButton tsbtnCancel;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        private System.Windows.Forms.TabPage tpWarna;
        private KASLibrary.GridControlEx gcxRumus;
        private KASLibrary.GridControlEx gcxUkuran;
        private KASLibrary.GridControlEx gcxWarna;
        private System.Windows.Forms.TabPage tabPage1;
        private KASLibrary.GridControlEx gcxKertas;
    }
}