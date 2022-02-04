namespace CAS.Master
{
    partial class FrmMasterNoPajak
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
            this.dtpTgl = new System.Windows.Forms.DateTimePicker();
            this.no_pjkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casDataSet = new CAS.casDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNoAwal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoAkhir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNoSk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gcpjk = new KASLibrary.GridControlEx();
            this.no_pjkTableAdapter = new CAS.casDataSetTableAdapters.no_pjkTableAdapter();
            this.no_pjkdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.no_pjkdTableAdapter = new CAS.casDataSetTableAdapters.no_pjkdTableAdapter();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.no_pjkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_pjkdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.gcpjk);
            this.pnlDetail.Controls.Add(this.dtpTgl);
            this.pnlDetail.Controls.Add(this.label1);
            this.pnlDetail.Controls.Add(this.txtNoAwal);
            this.pnlDetail.Controls.Add(this.label2);
            this.pnlDetail.Controls.Add(this.txtNoAkhir);
            this.pnlDetail.Controls.Add(this.label3);
            this.pnlDetail.Controls.Add(this.txtNoSk);
            this.pnlDetail.Controls.Add(this.label4);
            this.pnlDetail.Location = new System.Drawing.Point(0, 40);
            this.pnlDetail.Size = new System.Drawing.Size(597, 358);
            // 
            // pnlKey
            // 
            this.pnlKey.Size = new System.Drawing.Size(597, 15);
            // 
            // dtpTgl
            // 
            this.dtpTgl.CustomFormat = "dd/MM/yyyy";
            this.dtpTgl.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.no_pjkBindingSource, "tgl", true));
            this.dtpTgl.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTgl.Location = new System.Drawing.Point(82, 19);
            this.dtpTgl.Name = "dtpTgl";
            this.dtpTgl.Size = new System.Drawing.Size(86, 20);
            this.dtpTgl.TabIndex = 54;
            this.dtpTgl.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // no_pjkBindingSource
            // 
            this.no_pjkBindingSource.DataMember = "no_pjk";
            this.no_pjkBindingSource.DataSource = this.casDataSet;
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Tanggal";
            // 
            // txtNoAwal
            // 
            this.txtNoAwal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.no_pjkBindingSource, "no_awal", true));
            this.txtNoAwal.Location = new System.Drawing.Point(82, 71);
            this.txtNoAwal.Name = "txtNoAwal";
            this.txtNoAwal.Size = new System.Drawing.Size(126, 20);
            this.txtNoAwal.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "No. SK";
            // 
            // txtNoAkhir
            // 
            this.txtNoAkhir.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.no_pjkBindingSource, "no_akhir", true));
            this.txtNoAkhir.Location = new System.Drawing.Point(300, 71);
            this.txtNoAkhir.Name = "txtNoAkhir";
            this.txtNoAkhir.Size = new System.Drawing.Size(126, 20);
            this.txtNoAkhir.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "No. Awal";
            // 
            // txtNoSk
            // 
            this.txtNoSk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.no_pjkBindingSource, "no_sk", true));
            this.txtNoSk.Location = new System.Drawing.Point(82, 45);
            this.txtNoSk.Name = "txtNoSk";
            this.txtNoSk.Size = new System.Drawing.Size(284, 20);
            this.txtNoSk.TabIndex = 51;
            this.txtNoSk.TextChanged += new System.EventHandler(this.txtNoSk_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "No. Akhir";
            // 
            // gcpjk
            // 
            this.gcpjk.BestFitColumn = true;
            this.gcpjk.ExAutoSize = false;
            this.gcpjk.Location = new System.Drawing.Point(12, 119);
            this.gcpjk.Name = "gcpjk";
            this.gcpjk.Size = new System.Drawing.Size(569, 233);
            this.gcpjk.TabIndex = 55;
            // 
            // no_pjkTableAdapter
            // 
            this.no_pjkTableAdapter.ClearBeforeFill = true;
            // 
            // no_pjkdBindingSource
            // 
            this.no_pjkdBindingSource.DataMember = "no_pjkd";
            this.no_pjkdBindingSource.DataSource = this.casDataSet;
            // 
            // no_pjkdTableAdapter
            // 
            this.no_pjkdTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMasterNoPajak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(597, 465);
            this.MasterBindingSource = this.no_pjkBindingSource;
            this.MasterQuery = "select * from no_pjk order by tgl";
            this.MasterTable = this.casDataSet.no_pjk;
            this.Name = "FrmMasterNoPajak";
            this.Load += new System.EventHandler(this.FrmMasterNoPajak_Load);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.no_pjkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_pjkdBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private System.Windows.Forms.DateTimePicker dtpTgl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNoAwal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNoAkhir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNoSk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource no_pjkBindingSource;
        private CAS.casDataSetTableAdapters.no_pjkTableAdapter no_pjkTableAdapter;
        private System.Windows.Forms.BindingSource no_pjkdBindingSource;
        private CAS.casDataSetTableAdapters.no_pjkdTableAdapter no_pjkdTableAdapter;
        private KASLibrary.GridControlEx gcpjk;
    }
}
