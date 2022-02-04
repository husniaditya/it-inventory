namespace CAS.Master
{
    partial class FrmMasterQOP_Loc
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
            this.label3 = new System.Windows.Forms.Label();
            this.gcPeriod = new KASLibrary.GridControlEx();
            this.casDataSet = new CAS.casDataSet();
            this.prosenbopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prosenbopTableAdapter = new CAS.casDataSetTableAdapters.prosenbopTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosenbopBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(15, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Master Quality Of Product Location";
            // 
            // gcPeriod
            // 
            this.gcPeriod.BestFitColumn = true;
            this.gcPeriod.ExAutoSize = false;
            this.gcPeriod.Location = new System.Drawing.Point(15, 45);
            this.gcPeriod.Name = "gcPeriod";
            this.gcPeriod.Size = new System.Drawing.Size(363, 304);
            this.gcPeriod.TabIndex = 3;
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prosenbopBindingSource
            // 
            this.prosenbopBindingSource.DataMember = "prosenbop";
            this.prosenbopBindingSource.DataSource = this.casDataSet;
            // 
            // prosenbopTableAdapter
            // 
            this.prosenbopTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMasterQOP_Loc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 362);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gcPeriod);
            this.Name = "FrmMasterQOP_Loc";
            this.Text = "FrmMasterProsenBOP";
            this.Load += new System.EventHandler(this.FrmMasterQOP_Loc_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMasterQOP_Loc_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosenbopBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private KASLibrary.GridControlEx gcPeriod;
        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource prosenbopBindingSource;
        private CAS.casDataSetTableAdapters.prosenbopTableAdapter prosenbopTableAdapter;
    }
}