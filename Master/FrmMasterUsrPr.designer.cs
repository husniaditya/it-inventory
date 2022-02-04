namespace CAS.Master
{
    partial class FrmMasterUsrPr
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
            System.Windows.Forms.Label mtpLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label aktifLabel;
            System.Windows.Forms.Label kabagLabel;
            this.casDataSet = new CAS.casDataSet();
            this.aktifCheckBox = new System.Windows.Forms.CheckBox();
            this.usrprBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usrprTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.usrprTableAdapter = new CAS.casDataSetTableAdapters.usrprTableAdapter();
            this.kabagTextBoxEx = new KASLibrary.TextBoxEx();
            mtpLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            aktifLabel = new System.Windows.Forms.Label();
            kabagLabel = new System.Windows.Forms.Label();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrprBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kabagTextBoxEx.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(kabagLabel);
            this.pnlDetail.Controls.Add(this.kabagTextBoxEx);
            this.pnlDetail.Controls.Add(this.nameTextBox);
            this.pnlDetail.Controls.Add(aktifLabel);
            this.pnlDetail.Controls.Add(this.aktifCheckBox);
            this.pnlDetail.Controls.Add(nameLabel);
            this.pnlDetail.Location = new System.Drawing.Point(0, 92);
            this.pnlDetail.Size = new System.Drawing.Size(498, 113);
            // 
            // pnlKey
            // 
            this.pnlKey.Controls.Add(this.usrprTextBox);
            this.pnlKey.Controls.Add(mtpLabel);
            this.pnlKey.Size = new System.Drawing.Size(498, 67);
            // 
            // mtpLabel
            // 
            mtpLabel.AutoSize = true;
            mtpLabel.Location = new System.Drawing.Point(60, 26);
            mtpLabel.Name = "mtpLabel";
            mtpLabel.Size = new System.Drawing.Size(59, 13);
            mtpLabel.TabIndex = 0;
            mtpLabel.Text = "Alias Name";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(96, 16);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(34, 13);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name";
            // 
            // aktifLabel
            // 
            aktifLabel.AutoSize = true;
            aktifLabel.Location = new System.Drawing.Point(96, 46);
            aktifLabel.Name = "aktifLabel";
            aktifLabel.Size = new System.Drawing.Size(29, 13);
            aktifLabel.TabIndex = 2;
            aktifLabel.Text = "Aktif";
            // 
            // kabagLabel
            // 
            kabagLabel.AutoSize = true;
            kabagLabel.Location = new System.Drawing.Point(96, 74);
            kabagLabel.Name = "kabagLabel";
            kabagLabel.Size = new System.Drawing.Size(37, 13);
            kabagLabel.TabIndex = 4;
            kabagLabel.Text = "Kabag";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aktifCheckBox
            // 
            this.aktifCheckBox.Checked = true;
            this.aktifCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aktifCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.usrprBindingSource, "aktif", true));
            this.aktifCheckBox.Location = new System.Drawing.Point(149, 41);
            this.aktifCheckBox.Name = "aktifCheckBox";
            this.aktifCheckBox.Size = new System.Drawing.Size(104, 24);
            this.aktifCheckBox.TabIndex = 3;
            // 
            // usrprBindingSource
            // 
            this.usrprBindingSource.DataMember = "usrpr";
            this.usrprBindingSource.DataSource = this.casDataSet;
            // 
            // usrprTextBox
            // 
            this.usrprTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usrprBindingSource, "usrpr", true));
            this.usrprTextBox.Location = new System.Drawing.Point(138, 23);
            this.usrprTextBox.MaxLength = 15;
            this.usrprTextBox.Name = "usrprTextBox";
            this.usrprTextBox.Size = new System.Drawing.Size(100, 20);
            this.usrprTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usrprBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(149, 13);
            this.nameTextBox.MaxLength = 50;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(283, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // usrprTableAdapter
            // 
            this.usrprTableAdapter.ClearBeforeFill = true;
            // 
            // kabagTextBoxEx
            // 
            this.kabagTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.usrprBindingSource, "kabag", true));
            this.kabagTextBoxEx.ExAllowEmptyString = true;
            this.kabagTextBoxEx.ExAllowNonDBData = false;
            this.kabagTextBoxEx.ExAutoCheck = true;
            this.kabagTextBoxEx.ExAutoShowResult = false;
            this.kabagTextBoxEx.ExCondition = "";
            this.kabagTextBoxEx.ExDialogTitle = "Kabag User PR";
            this.kabagTextBoxEx.ExFieldName = "user";
            this.kabagTextBoxEx.ExFilterFields = new string[0];
            this.kabagTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.kabagTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.kabagTextBoxEx.ExLabelContainer = null;
            this.kabagTextBoxEx.ExLabelField = "name";
            this.kabagTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.kabagTextBoxEx.ExLabelText = "";
            this.kabagTextBoxEx.ExLabelVisible = true;
            this.kabagTextBoxEx.ExSelectFields = new string[0];
            this.kabagTextBoxEx.ExShowDialog = true;
            this.kabagTextBoxEx.ExSimpleMode = true;
            this.kabagTextBoxEx.ExSqlInstance = null;
            this.kabagTextBoxEx.ExSqlQuery = "select user,name from usr";
            this.kabagTextBoxEx.ExTableName = "usr";
            this.kabagTextBoxEx.Location = new System.Drawing.Point(149, 71);
            this.kabagTextBoxEx.Name = "kabagTextBoxEx";
            this.kabagTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.kabagTextBoxEx.Size = new System.Drawing.Size(104, 20);
            this.kabagTextBoxEx.TabIndex = 5;
            // 
            // FrmMasterUsrPr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(498, 272);
            this.MasterBindingSource = this.usrprBindingSource;
            this.MasterQuery = "select * from usrpr order by usrpr";
            this.MasterTable = this.casDataSet.usrpr;
            this.Name = "FrmMasterUsrPr";
            this.Text = "Master User Requisitioner";
            this.Load += new System.EventHandler(this.FrmMasterUsrPr_Load);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.pnlKey.ResumeLayout(false);
            this.pnlKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrprBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kabagTextBoxEx.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private System.Windows.Forms.CheckBox aktifCheckBox;
        private System.Windows.Forms.BindingSource usrprBindingSource;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox usrprTextBox;
        private KASLibrary.TextBoxEx kabagTextBoxEx;
        private CAS.casDataSetTableAdapters.usrprTableAdapter usrprTableAdapter;
    }
}
