namespace CAS.Master
{
    partial class FrmUserLoc
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
            System.Windows.Forms.Label personLabel;
            this.casDataSet = new CAS.casDataSet();
            this.usrlocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usrlocTableAdapter = new CAS.casDataSetTableAdapters.usrlocTableAdapter();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gcPeriod = new KASLibrary.GridControlEx();
            this.usrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usrTableAdapter = new CAS.casDataSetTableAdapters.usrTableAdapter();
            this.userTextEdit = new DevExpress.XtraEditors.TextEdit();
            personLabel = new System.Windows.Forms.Label();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrlocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.gcPeriod);
            this.pnlDetail.Location = new System.Drawing.Point(0, 84);
            this.pnlDetail.Size = new System.Drawing.Size(762, 234);
            // 
            // pnlKey
            // 
            this.pnlKey.Controls.Add(this.userTextEdit);
            this.pnlKey.Controls.Add(personLabel);
            this.pnlKey.Size = new System.Drawing.Size(762, 59);
            // 
            // personLabel
            // 
            personLabel.AutoSize = true;
            personLabel.Location = new System.Drawing.Point(80, 20);
            personLabel.Name = "personLabel";
            personLabel.Size = new System.Drawing.Size(42, 13);
            personLabel.TabIndex = 126;
            personLabel.Text = "User Id";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usrlocBindingSource
            // 
            this.usrlocBindingSource.DataMember = "usrloc";
            this.usrlocBindingSource.DataSource = this.casDataSet;
            // 
            // usrlocTableAdapter
            // 
            this.usrlocTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // gcPeriod
            // 
            this.gcPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.gcPeriod.BestFitColumn = true;
            this.gcPeriod.ExAutoSize = false;
            this.gcPeriod.Location = new System.Drawing.Point(71, 6);
            this.gcPeriod.Name = "gcPeriod";
            this.gcPeriod.Size = new System.Drawing.Size(372, 207);
            this.gcPeriod.TabIndex = 4;
            // 
            // usrBindingSource
            // 
            this.usrBindingSource.DataMember = "usr";
            this.usrBindingSource.DataSource = this.casDataSet;
            // 
            // usrTableAdapter
            // 
            this.usrTableAdapter.ClearBeforeFill = true;
            // 
            // userTextEdit
            // 
            this.userTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.usrBindingSource, "user", true));
            this.userTextEdit.Location = new System.Drawing.Point(135, 17);
            this.userTextEdit.Name = "userTextEdit";
            this.userTextEdit.Size = new System.Drawing.Size(174, 20);
            this.userTextEdit.TabIndex = 127;
            // 
            // FrmUserLoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 385);
            this.MasterBindingSource = this.usrBindingSource;
            this.MasterQuery = "select user from usr";
            this.MasterTable = this.casDataSet.usr;
            this.Name = "FrmUserLoc";
            this.Text = "FrmMasterProsenBOP";
            this.Load += new System.EventHandler(this.FrmMasterProsenBOP_Load);
            this.pnlDetail.ResumeLayout(false);
            this.pnlKey.ResumeLayout(false);
            this.pnlKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrlocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource usrlocBindingSource;
        private CAS.casDataSetTableAdapters.usrlocTableAdapter usrlocTableAdapter;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private KASLibrary.GridControlEx gcPeriod;
        private System.Windows.Forms.BindingSource usrBindingSource;
        private CAS.casDataSetTableAdapters.usrTableAdapter usrTableAdapter;
        private DevExpress.XtraEditors.TextEdit userTextEdit;
    }
}