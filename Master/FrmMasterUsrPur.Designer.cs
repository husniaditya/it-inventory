namespace CAS.Master
{
    partial class FrmMasterUsrP
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
            System.Windows.Forms.Label label1;
            this.casDataSet = new CAS.casDataSet();
            this.usrpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usrpTableAdapter = new CAS.casDataSetTableAdapters.usrpTableAdapter();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.usrpTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.aktifCheckBox = new System.Windows.Forms.CheckBox();
            this.textBoxEx1 = new KASLibrary.TextBoxEx();
            mtpLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            aktifLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrpTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxEx1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(label1);
            this.pnlDetail.Controls.Add(this.textBoxEx1);
            this.pnlDetail.Controls.Add(aktifLabel);
            this.pnlDetail.Controls.Add(this.aktifCheckBox);
            this.pnlDetail.Controls.Add(this.nameTextEdit);
            this.pnlDetail.Controls.Add(nameLabel);
            this.pnlDetail.Location = new System.Drawing.Point(0, 76);
            this.pnlDetail.Size = new System.Drawing.Size(498, 122);
            // 
            // pnlKey
            // 
            this.pnlKey.Controls.Add(this.usrpTextEdit);
            this.pnlKey.Controls.Add(mtpLabel);
            this.pnlKey.Size = new System.Drawing.Size(498, 51);
            // 
            // pnlChInfo
            // 
            this.pnlChInfo.Location = new System.Drawing.Point(0, 198);
            this.pnlChInfo.Size = new System.Drawing.Size(498, 45);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(68, 78);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(62, 13);
            label1.TabIndex = 5;
            label1.Text = "Kabag User";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usrpBindingSource
            // 
            this.usrpBindingSource.DataMember = "usrp";
            this.usrpBindingSource.DataSource = this.casDataSet;
            // 
            // usrpTableAdapter
            // 
            this.usrpTableAdapter.ClearBeforeFill = true;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.usrpBindingSource, "name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(149, 9);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nameTextEdit.Size = new System.Drawing.Size(221, 20);
            this.nameTextEdit.TabIndex = 2;
            // 
            // usrpTextEdit
            // 
            this.usrpTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.usrpBindingSource, "usrp", true));
            this.usrpTextEdit.Location = new System.Drawing.Point(149, 23);
            this.usrpTextEdit.Name = "usrpTextEdit";
            this.usrpTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.usrpTextEdit.Size = new System.Drawing.Size(100, 20);
            this.usrpTextEdit.TabIndex = 2;
            // 
            // aktifCheckBox
            // 
            this.aktifCheckBox.Checked = true;
            this.aktifCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aktifCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usrpBindingSource, "aktif", true));
            this.aktifCheckBox.Location = new System.Drawing.Point(149, 41);
            this.aktifCheckBox.Name = "aktifCheckBox";
            this.aktifCheckBox.Size = new System.Drawing.Size(104, 24);
            this.aktifCheckBox.TabIndex = 3;
            // 
            // textBoxEx1
            // 
            this.textBoxEx1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.usrpBindingSource, "kabag", true));
            this.textBoxEx1.ExAllowEmptyString = true;
            this.textBoxEx1.ExAllowNonDBData = false;
            this.textBoxEx1.ExAutoCheck = true;
            this.textBoxEx1.ExAutoShowResult = false;
            this.textBoxEx1.ExCondition = "";
            this.textBoxEx1.ExDialogTitle = "Kabag User";
            this.textBoxEx1.ExFieldName = "kabag";
            this.textBoxEx1.ExFilterFields = new string[0];
            this.textBoxEx1.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.textBoxEx1.ExInvalidForeColor = System.Drawing.Color.Black;
            this.textBoxEx1.ExLabelContainer = null;
            this.textBoxEx1.ExLabelField = "name";
            this.textBoxEx1.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.textBoxEx1.ExLabelText = "";
            this.textBoxEx1.ExLabelVisible = true;
            this.textBoxEx1.ExSelectFields = new string[0];
            this.textBoxEx1.ExShowDialog = true;
            this.textBoxEx1.ExSimpleMode = true;
            this.textBoxEx1.ExSqlInstance = null;
            this.textBoxEx1.ExSqlQuery = "SELECT `user` as kabag,name FROM usr where `role` in (\'Kepala Purch\',\'Master Vend" +
                "or\')";
            this.textBoxEx1.ExTableName = "usr";
            this.textBoxEx1.Location = new System.Drawing.Point(149, 71);
            this.textBoxEx1.Name = "textBoxEx1";
            this.textBoxEx1.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxEx1.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.textBoxEx1.Properties.Appearance.Options.UseBackColor = true;
            this.textBoxEx1.Properties.Appearance.Options.UseForeColor = true;
            this.textBoxEx1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.textBoxEx1.Size = new System.Drawing.Size(100, 20);
            this.textBoxEx1.TabIndex = 4;
            // 
            // FrmMasterUsrP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(498, 265);
            this.MasterBindingSource = this.usrpBindingSource;
            this.MasterQuery = "select * from usrp order by usrp";
            this.MasterTable = this.casDataSet.usrp;
            this.Name = "FrmMasterUsrP";
            this.Text = "Master User Purchase";
            this.Load += new System.EventHandler(this.FrmMasterUsrP_Load);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.pnlKey.ResumeLayout(false);
            this.pnlKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrpTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxEx1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource usrpBindingSource;
        private CAS.casDataSetTableAdapters.usrpTableAdapter usrpTableAdapter;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.TextEdit usrpTextEdit;
        private System.Windows.Forms.CheckBox aktifCheckBox;
        private KASLibrary.TextBoxEx textBoxEx1;
    }
}
