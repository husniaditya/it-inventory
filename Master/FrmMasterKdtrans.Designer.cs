namespace CAS.Master
{
    partial class FrmMasterKdtrans
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label accLabel;
            this.casDataSet = new CAS.casDataSet();
            this.kodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.kodeTableAdapter = new CAS.casDataSetTableAdapters.kodeTableAdapter();
            this.accTextBoxEx = new KASLibrary.TextBoxEx();
            kodeLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            accLabel = new System.Windows.Forms.Label();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kodeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accTextBoxEx.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(accLabel);
            this.pnlDetail.Controls.Add(this.accTextBoxEx);
            this.pnlDetail.Controls.Add(nameLabel);
            this.pnlDetail.Controls.Add(this.nameTextEdit);
            this.pnlDetail.Location = new System.Drawing.Point(0, 84);
            this.pnlDetail.Size = new System.Drawing.Size(530, 75);
            // 
            // pnlKey
            // 
            this.pnlKey.Controls.Add(kodeLabel);
            this.pnlKey.Controls.Add(this.kodeTextEdit);
            this.pnlKey.Size = new System.Drawing.Size(530, 59);
            // 
            // kodeLabel
            // 
            kodeLabel.AutoSize = true;
            kodeLabel.Location = new System.Drawing.Point(29, 36);
            kodeLabel.Name = "kodeLabel";
            kodeLabel.Size = new System.Drawing.Size(79, 13);
            kodeLabel.TabIndex = 0;
            kodeLabel.Text = "Kode Transaksi";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(75, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(34, 13);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Nama";
            // 
            // accLabel
            // 
            accLabel.AutoSize = true;
            accLabel.Location = new System.Drawing.Point(63, 35);
            accLabel.Name = "accLabel";
            accLabel.Size = new System.Drawing.Size(46, 13);
            accLabel.TabIndex = 2;
            accLabel.Text = "Account";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kodeBindingSource
            // 
            this.kodeBindingSource.DataMember = "kode";
            this.kodeBindingSource.DataSource = this.casDataSet;
            // 
            // kodeTextEdit
            // 
            this.kodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kodeBindingSource, "kode", true));
            this.kodeTextEdit.Location = new System.Drawing.Point(116, 33);
            this.kodeTextEdit.Name = "kodeTextEdit";
            this.kodeTextEdit.Size = new System.Drawing.Size(100, 20);
            this.kodeTextEdit.TabIndex = 1;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kodeBindingSource, "name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(116, 6);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(261, 20);
            this.nameTextEdit.TabIndex = 1;
            // 
            // kodeTableAdapter
            // 
            this.kodeTableAdapter.ClearBeforeFill = true;
            // 
            // accTextBoxEx
            // 
            this.accTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kodeBindingSource, "acc", true));
            this.accTextBoxEx.ExAllowEmptyString = true;
            this.accTextBoxEx.ExAllowNonDBData = false;
            this.accTextBoxEx.ExAutoCheck = true;
            this.accTextBoxEx.ExAutoShowResult = false;
            this.accTextBoxEx.ExCondition = "";
            this.accTextBoxEx.ExDialogTitle = "";
            this.accTextBoxEx.ExFieldName = "Kode Akun";
            this.accTextBoxEx.ExFilterFields = new string[0];
            this.accTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.accTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.accTextBoxEx.ExLabelContainer = null;
            this.accTextBoxEx.ExLabelField = "Keterangan";
            this.accTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.accTextBoxEx.ExLabelVisible = true;
            this.accTextBoxEx.ExSelectFields = new string[0];
            this.accTextBoxEx.ExShowDialog = true;
            this.accTextBoxEx.ExSimpleMode = true;
            this.accTextBoxEx.ExSqlInstance = null;
            this.accTextBoxEx.ExSqlQuery = "Call SP_LookUp(\'acc\')";
            this.accTextBoxEx.ExTableName = "acc";
            this.accTextBoxEx.Location = new System.Drawing.Point(116, 32);
            this.accTextBoxEx.Name = "accTextBoxEx";
            this.accTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.accTextBoxEx.Size = new System.Drawing.Size(100, 20);
            this.accTextBoxEx.TabIndex = 3;
            // 
            // FrmMasterKdtrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(530, 226);
            this.MasterBindingSource = this.kodeBindingSource;
            this.MasterQuery = "select * from kode order by kode";
            this.MasterTable = this.casDataSet.kode;
            this.Name = "FrmMasterKdtrans";
            this.Text = "Master Kode Transaksi";
            this.Load += new System.EventHandler(this.FrmMasterKdtrans_Load);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.pnlKey.ResumeLayout(false);
            this.pnlKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accTextBoxEx.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource kodeBindingSource;
        private DevExpress.XtraEditors.TextEdit kodeTextEdit;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private KASLibrary.TextBoxEx accTextBoxEx;
        private CAS.casDataSetTableAdapters.kodeTableAdapter kodeTableAdapter;
    }
}
