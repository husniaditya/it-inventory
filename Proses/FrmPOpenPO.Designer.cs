namespace CAS.Proses
{
    partial class FrmPOpenPO
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.casDataSet = new CAS.casDataSet();
            this.openpoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openpoTableAdapter = new CAS.casDataSetTableAdapters.openpoTableAdapter();
            this.gcPeriod = new KASLibrary.GridControlEx();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpTglAkhir = new DevExpress.XtraEditors.DateEdit();
            this.dtpTglAwal = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openpoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAkhir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAwal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(15, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(661, 71);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(819, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Rencana terima di set > 0 maka Open PO akan close jika counternya >= rencana teri" +
                "ma dan juga akan close jika kedatangan >= qty + Toleransi (diambil yang lebih du" +
                "lu)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(523, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Rencana terima default 0 = tak terhingga sehingga Open PO akan close jika kedatan" +
                "gan >= qty + toleransi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(523, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Proses ini akan membuka PO berdasarkan Qty + Toleransi dan berapa kali pengiriman" +
                " untuk close otomatis. ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(15, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Proses Open PO";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // openpoBindingSource
            // 
            this.openpoBindingSource.DataMember = "openpo";
            this.openpoBindingSource.DataSource = this.casDataSet;
            // 
            // openpoTableAdapter
            // 
            this.openpoTableAdapter.ClearBeforeFill = true;
            // 
            // gcPeriod
            // 
            this.gcPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcPeriod.BestFitColumn = true;
            this.gcPeriod.ExAutoSize = false;
            this.gcPeriod.Location = new System.Drawing.Point(19, 135);
            this.gcPeriod.Name = "gcPeriod";
            this.gcPeriod.Size = new System.Drawing.Size(676, 255);
            this.gcPeriod.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 34;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpTglAkhir
            // 
            this.dtpTglAkhir.EditValue = new System.DateTime(2008, 8, 20, 15, 40, 28, 0);
            this.dtpTglAkhir.Location = new System.Drawing.Point(238, 104);
            this.dtpTglAkhir.Name = "dtpTglAkhir";
            this.dtpTglAkhir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTglAkhir.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAkhir.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAkhir.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAkhir.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAkhir.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtpTglAkhir.Size = new System.Drawing.Size(114, 23);
            this.dtpTglAkhir.TabIndex = 37;
            // 
            // dtpTglAwal
            // 
            this.dtpTglAwal.EditValue = new System.DateTime(2008, 8, 20, 15, 40, 28, 0);
            this.dtpTglAwal.Location = new System.Drawing.Point(94, 104);
            this.dtpTglAwal.Name = "dtpTglAwal";
            this.dtpTglAwal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTglAwal.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAwal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAwal.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtpTglAwal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTglAwal.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtpTglAwal.Size = new System.Drawing.Size(114, 23);
            this.dtpTglAwal.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Tanggal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "s/d";
            // 
            // FrmPOpenPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 418);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpTglAkhir);
            this.Controls.Add(this.dtpTglAwal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gcPeriod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmPOpenPO";
            this.Text = "FrmPOpenPO";
            this.Load += new System.EventHandler(this.FrmPOpenPO_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPOpenPO_FormClosing);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openpoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAkhir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglAwal.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource openpoBindingSource;
        private CAS.casDataSetTableAdapters.openpoTableAdapter openpoTableAdapter;
        private KASLibrary.GridControlEx gcPeriod;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.DateEdit dtpTglAkhir;
        private DevExpress.XtraEditors.DateEdit dtpTglAwal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}