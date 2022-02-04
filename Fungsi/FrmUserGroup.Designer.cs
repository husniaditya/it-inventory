namespace CAS.Fungsi
{
    partial class FrmUserGroup
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
            System.Windows.Forms.Label roleLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label otolevel_Label;
            this.casDataSet = new CAS.casDataSet();
            this.usrlevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roleTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.otolevel_CheckBox = new System.Windows.Forms.CheckBox();
            this.permsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treeMenu = new DevExpress.XtraTreeList.TreeList();
            this.chkInsert = new System.Windows.Forms.CheckBox();
            this.chkUpdate = new System.Windows.Forms.CheckBox();
            this.chkDelete = new System.Windows.Forms.CheckBox();
            this.chkPrint = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkSelect = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkApprove = new System.Windows.Forms.CheckBox();
            this.moduldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gcxModuld = new KASLibrary.GridControlEx();
            this.chkJurnal = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            roleLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            otolevel_Label = new System.Windows.Forms.Label();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrlevelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduldBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(otolevel_Label);
            this.pnlDetail.Controls.Add(this.gcxModuld);
            this.pnlDetail.Controls.Add(this.label8);
            this.pnlDetail.Controls.Add(this.chkJurnal);
            this.pnlDetail.Controls.Add(this.label7);
            this.pnlDetail.Controls.Add(this.chkApprove);
            this.pnlDetail.Controls.Add(this.label5);
            this.pnlDetail.Controls.Add(this.label4);
            this.pnlDetail.Controls.Add(this.label3);
            this.pnlDetail.Controls.Add(this.label2);
            this.pnlDetail.Controls.Add(this.label6);
            this.pnlDetail.Controls.Add(this.label1);
            this.pnlDetail.Controls.Add(this.chkPrint);
            this.pnlDetail.Controls.Add(this.chkDelete);
            this.pnlDetail.Controls.Add(this.chkUpdate);
            this.pnlDetail.Controls.Add(this.chkInsert);
            this.pnlDetail.Controls.Add(this.chkSelect);
            this.pnlDetail.Controls.Add(this.treeMenu);
            this.pnlDetail.Controls.Add(this.otolevel_CheckBox);
            this.pnlDetail.Controls.Add(nameLabel);
            this.pnlDetail.Controls.Add(this.nameTextEdit);
            this.pnlDetail.Location = new System.Drawing.Point(0, 73);
            this.pnlDetail.Size = new System.Drawing.Size(730, 341);
            // 
            // pnlKey
            // 
            this.pnlKey.Controls.Add(this.roleTextEdit);
            this.pnlKey.Controls.Add(roleLabel);
            this.pnlKey.Size = new System.Drawing.Size(730, 48);
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Location = new System.Drawing.Point(22, 20);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new System.Drawing.Size(28, 13);
            roleLabel.TabIndex = 0;
            roleLabel.Text = "Role";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(22, 15);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(34, 13);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name";
            // 
            // otolevel_Label
            // 
            otolevel_Label.AutoSize = true;
            otolevel_Label.Location = new System.Drawing.Point(338, 20);
            otolevel_Label.Name = "otolevel_Label";
            otolevel_Label.Size = new System.Drawing.Size(123, 13);
            otolevel_Label.TabIndex = 16;
            otolevel_Label.Text = "High Level Authorization";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usrlevelBindingSource
            // 
            this.usrlevelBindingSource.DataMember = "usrlevel";
            this.usrlevelBindingSource.DataSource = this.casDataSet;
            // 
            // roleTextEdit
            // 
            this.roleTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.usrlevelBindingSource, "role", true));
            this.roleTextEdit.Location = new System.Drawing.Point(78, 17);
            this.roleTextEdit.Name = "roleTextEdit";
            this.roleTextEdit.Size = new System.Drawing.Size(100, 20);
            this.roleTextEdit.TabIndex = 1;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.usrlevelBindingSource, "name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(78, 12);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(241, 20);
            this.nameTextEdit.TabIndex = 3;
            // 
            // otolevel_CheckBox
            // 
            this.otolevel_CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.usrlevelBindingSource, "otolevel_", true));
            this.otolevel_CheckBox.Location = new System.Drawing.Point(467, 15);
            this.otolevel_CheckBox.Name = "otolevel_CheckBox";
            this.otolevel_CheckBox.Size = new System.Drawing.Size(31, 24);
            this.otolevel_CheckBox.TabIndex = 5;
            // 
            // permsBindingSource
            // 
            this.permsBindingSource.DataMember = "perms";
            this.permsBindingSource.DataSource = this.casDataSet;
            // 
            // treeMenu
            // 
            this.treeMenu.KeyFieldName = "menuid";
            this.treeMenu.Location = new System.Drawing.Point(25, 55);
            this.treeMenu.Name = "treeMenu";
            this.treeMenu.OptionsBehavior.Editable = false;
            this.treeMenu.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.treeMenu.OptionsView.ShowIndicator = false;
            this.treeMenu.ParentFieldName = "parent";
            this.treeMenu.Size = new System.Drawing.Size(294, 270);
            this.treeMenu.TabIndex = 6;
            this.treeMenu.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeMenu_FocusedNodeChanged);
            this.treeMenu.ShowTreeListMenu += new DevExpress.XtraTreeList.TreeListMenuEventHandler(this.treeMenu_ShowTreeListMenu);
            // 
            // chkInsert
            // 
            this.chkInsert.AutoSize = true;
            this.chkInsert.Location = new System.Drawing.Point(369, 122);
            this.chkInsert.Name = "chkInsert";
            this.chkInsert.Size = new System.Drawing.Size(15, 14);
            this.chkInsert.TabIndex = 8;
            this.chkInsert.Tag = "insert";
            this.chkInsert.UseVisualStyleBackColor = true;
            this.chkInsert.CheckedChanged += new System.EventHandler(this.chkInsert_CheckedChanged);
            // 
            // chkUpdate
            // 
            this.chkUpdate.AutoSize = true;
            this.chkUpdate.Location = new System.Drawing.Point(369, 154);
            this.chkUpdate.Name = "chkUpdate";
            this.chkUpdate.Size = new System.Drawing.Size(15, 14);
            this.chkUpdate.TabIndex = 9;
            this.chkUpdate.Tag = "update";
            this.chkUpdate.UseVisualStyleBackColor = true;
            this.chkUpdate.CheckedChanged += new System.EventHandler(this.chkInsert_CheckedChanged);
            // 
            // chkDelete
            // 
            this.chkDelete.AutoSize = true;
            this.chkDelete.Location = new System.Drawing.Point(369, 186);
            this.chkDelete.Name = "chkDelete";
            this.chkDelete.Size = new System.Drawing.Size(15, 14);
            this.chkDelete.TabIndex = 10;
            this.chkDelete.Tag = "delete";
            this.chkDelete.UseVisualStyleBackColor = true;
            this.chkDelete.CheckedChanged += new System.EventHandler(this.chkInsert_CheckedChanged);
            // 
            // chkPrint
            // 
            this.chkPrint.AutoSize = true;
            this.chkPrint.Location = new System.Drawing.Point(369, 218);
            this.chkPrint.Name = "chkPrint";
            this.chkPrint.Size = new System.Drawing.Size(15, 14);
            this.chkPrint.TabIndex = 11;
            this.chkPrint.Tag = "print";
            this.chkPrint.UseVisualStyleBackColor = true;
            this.chkPrint.CheckedChanged += new System.EventHandler(this.chkInsert_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select Menu";
            // 
            // chkSelect
            // 
            this.chkSelect.AutoSize = true;
            this.chkSelect.Location = new System.Drawing.Point(341, 85);
            this.chkSelect.Name = "chkSelect";
            this.chkSelect.Size = new System.Drawing.Size(15, 14);
            this.chkSelect.TabIndex = 7;
            this.chkSelect.Tag = "select";
            this.chkSelect.UseVisualStyleBackColor = true;
            this.chkSelect.CheckedChanged += new System.EventHandler(this.chkSelect_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Insert";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Update";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Delete";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Print";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Role Priveleges";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(390, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Approve";
            // 
            // chkApprove
            // 
            this.chkApprove.AutoSize = true;
            this.chkApprove.Location = new System.Drawing.Point(369, 250);
            this.chkApprove.Name = "chkApprove";
            this.chkApprove.Size = new System.Drawing.Size(15, 14);
            this.chkApprove.TabIndex = 13;
            this.chkApprove.Tag = "approve";
            this.chkApprove.UseVisualStyleBackColor = true;
            this.chkApprove.CheckedChanged += new System.EventHandler(this.chkInsert_CheckedChanged);
            // 
            // moduldBindingSource
            // 
            this.moduldBindingSource.DataMember = "moduld";
            this.moduldBindingSource.DataSource = this.casDataSet;
            // 
            // gcxModuld
            // 
            this.gcxModuld.BestFitColumn = true;
            this.gcxModuld.ExAutoSize = false;
            this.gcxModuld.Location = new System.Drawing.Point(461, 55);
            this.gcxModuld.Name = "gcxModuld";
            this.gcxModuld.Size = new System.Drawing.Size(248, 270);
            this.gcxModuld.TabIndex = 15;
            // 
            // chkJurnal
            // 
            this.chkJurnal.AutoSize = true;
            this.chkJurnal.Location = new System.Drawing.Point(369, 282);
            this.chkJurnal.Name = "chkJurnal";
            this.chkJurnal.Size = new System.Drawing.Size(15, 14);
            this.chkJurnal.TabIndex = 13;
            this.chkJurnal.Tag = "jurnal";
            this.chkJurnal.UseVisualStyleBackColor = true;
            this.chkJurnal.CheckedChanged += new System.EventHandler(this.chkInsert_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(390, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Jurnal";
            // 
            // FrmUserGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 481);
            this.MasterBindingSource = this.usrlevelBindingSource;
            this.MasterQuery = "select * from usrlevel";
            this.MasterTable = this.casDataSet.usrlevel;
            this.Name = "FrmUserGroup";
            this.Text = "FrmUserGroup";
            this.Load += new System.EventHandler(this.FrmUserGroup_Load);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.pnlKey.ResumeLayout(false);
            this.pnlKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrlevelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduldBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource usrlevelBindingSource;
        private System.Windows.Forms.CheckBox otolevel_CheckBox;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.TextEdit roleTextEdit;
        private System.Windows.Forms.BindingSource permsBindingSource;
        private System.Windows.Forms.CheckBox chkPrint;
        private System.Windows.Forms.CheckBox chkDelete;
        private System.Windows.Forms.CheckBox chkUpdate;
        private System.Windows.Forms.CheckBox chkInsert;
        private DevExpress.XtraTreeList.TreeList treeMenu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkSelect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkApprove;
        private System.Windows.Forms.BindingSource moduldBindingSource;
        private KASLibrary.GridControlEx gcxModuld;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkJurnal;
    }
}