namespace CAS.Master
{
    partial class FrmMasterWipLost
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
            this.casDataSet = new CAS.casDataSet();
            this.wip_lostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wip_lostTableAdapter = new CAS.casDataSetTableAdapters.wip_lostTableAdapter();
            this.gcwip = new KASLibrary.GridControlEx();
            this.dateperiod = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wip_lostBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.ExcludeSchema;
            // 
            // wip_lostBindingSource
            // 
            this.wip_lostBindingSource.DataMember = "wip_lost";
            this.wip_lostBindingSource.DataSource = this.casDataSet;
            // 
            // wip_lostTableAdapter
            // 
            this.wip_lostTableAdapter.ClearBeforeFill = true;
            // 
            // gcwip
            // 
            this.gcwip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcwip.BestFitColumn = true;
            this.gcwip.ExAutoSize = false;
            this.gcwip.Location = new System.Drawing.Point(30, 53);
            this.gcwip.Name = "gcwip";
            this.gcwip.Size = new System.Drawing.Size(668, 367);
            this.gcwip.TabIndex = 1;
            // 
            // dateperiod
            // 
            this.dateperiod.CustomFormat = "yyyyMM";
            this.dateperiod.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateperiod.Location = new System.Drawing.Point(82, 24);
            this.dateperiod.Name = "dateperiod";
            this.dateperiod.ShowUpDown = true;
            this.dateperiod.Size = new System.Drawing.Size(67, 20);
            this.dateperiod.TabIndex = 3;
            this.dateperiod.ValueChanged += new System.EventHandler(this.dateperiod_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Period";
            // 
            // FrmMasterWipLost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 432);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateperiod);
            this.Controls.Add(this.gcwip);
            this.Name = "FrmMasterWipLost";
            this.Text = "FrmMasterWipLost";
            this.Load += new System.EventHandler(this.FrmMasterWipLost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wip_lostBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource wip_lostBindingSource;
        private CAS.casDataSetTableAdapters.wip_lostTableAdapter wip_lostTableAdapter;
        private KASLibrary.GridControlEx gcwip;
        private System.Windows.Forms.DateTimePicker dateperiod;
        private System.Windows.Forms.Label label1;
    }
}