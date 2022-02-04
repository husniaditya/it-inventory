namespace CAS.Master
{
    partial class FrmMasterHJL1
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
            System.Windows.Forms.Label invLabel;
            this.casDataSet = new CAS.casDataSet();
            this.gcHJL = new KASLibrary.GridControlEx();
            this.invTextBoxEx = new KASLibrary.TextBoxEx();
            this.hjlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hjlTableAdapter = new CAS.casDataSetTableAdapters.hjlTableAdapter();
            invLabel = new System.Windows.Forms.Label();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hjlBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.gcHJL);
            this.pnlDetail.Location = new System.Drawing.Point(0, 110);
            this.pnlDetail.Size = new System.Drawing.Size(597, 288);
            // 
            // pnlKey
            // 
            this.pnlKey.Controls.Add(invLabel);
            this.pnlKey.Controls.Add(this.invTextBoxEx);
            this.pnlKey.Size = new System.Drawing.Size(597, 85);
            // 
            // invLabel
            // 
            invLabel.AutoSize = true;
            invLabel.Location = new System.Drawing.Point(49, 31);
            invLabel.Name = "invLabel";
            invLabel.Size = new System.Drawing.Size(25, 13);
            invLabel.TabIndex = 0;
            invLabel.Text = "inv:";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gcHJL
            // 
            this.gcHJL.BestFitColumn = true;
            this.gcHJL.ExAutoSize = false;
            this.gcHJL.Location = new System.Drawing.Point(12, 6);
            this.gcHJL.Name = "gcHJL";
            this.gcHJL.Size = new System.Drawing.Size(573, 288);
            this.gcHJL.TabIndex = 0;
            // 
            // invTextBoxEx
            // 
            this.invTextBoxEx.ExAllowEmptyString = true;
            this.invTextBoxEx.ExAllowNonDBData = false;
            this.invTextBoxEx.ExAutoCheck = true;
            this.invTextBoxEx.ExAutoShowResult = false;
            this.invTextBoxEx.ExCondition = "";
            this.invTextBoxEx.ExDialogTitle = "";
            this.invTextBoxEx.ExFieldName = "Kode Barang";
            this.invTextBoxEx.ExFilterFields = new string[0];
            this.invTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.invTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.invTextBoxEx.ExLabelContainer = null;
            this.invTextBoxEx.ExLabelField = "Nama Barang";
            this.invTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.invTextBoxEx.ExLabelText = "";
            this.invTextBoxEx.ExLabelVisible = true;
            this.invTextBoxEx.ExSelectFields = new string[0];
            this.invTextBoxEx.ExShowDialog = true;
            this.invTextBoxEx.ExSimpleMode = false;
            this.invTextBoxEx.ExSqlInstance = null;
            this.invTextBoxEx.ExSqlQuery = "Call SP_LookUp(\'inv\')";
            this.invTextBoxEx.ExTableName = "";
            this.invTextBoxEx.Location = new System.Drawing.Point(80, 28);
            this.invTextBoxEx.Name = "invTextBoxEx";
            this.invTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.invTextBoxEx.Size = new System.Drawing.Size(100, 20);
            this.invTextBoxEx.TabIndex = 1;
            // 
            // hjlBindingSource
            // 
            this.hjlBindingSource.DataMember = "hjl";
            this.hjlBindingSource.DataSource = this.casDataSet;
            // 
            // hjlTableAdapter
            // 
            this.hjlTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMasterHJL1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(597, 465);
            this.MasterBindingSource = this.hjlBindingSource;
            this.MasterTable = this.casDataSet.hjl;
            this.Name = "FrmMasterHJL1";
            this.Load += new System.EventHandler(this.FrmMasterHJL1_Load);
            this.pnlDetail.ResumeLayout(false);
            this.pnlKey.ResumeLayout(false);
            this.pnlKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hjlBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private KASLibrary.GridControlEx gcHJL;
        private KASLibrary.TextBoxEx invTextBoxEx;
        private System.Windows.Forms.BindingSource hjlBindingSource;
        private CAS.casDataSetTableAdapters.hjlTableAdapter hjlTableAdapter;
    }
}
