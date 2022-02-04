namespace CAS.Master
{
    partial class FrmMasterModul
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label noseriLabel;
            System.Windows.Forms.Label remarkLabel;
            System.Windows.Forms.Label label2;
            this.btnMoveR = new DevExpress.XtraEditors.SimpleButton();
            this.btnMoveRAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnMoveL = new DevExpress.XtraEditors.SimpleButton();
            this.btnMoveLAll = new DevExpress.XtraEditors.SimpleButton();
            this.casDataSet = new CAS.casDataSet();
            this.modulBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modulTableAdapter = new CAS.casDataSetTableAdapters.modulTableAdapter();
            this.txtNoSeri = new DevExpress.XtraEditors.TextEdit();
            this.remarkTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.lookupMenuId = new DevExpress.XtraEditors.LookUpEdit();
            this.menuidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuidTableAdapter = new CAS.casDataSetTableAdapters.menuidTableAdapter();
            this.usrlevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moduldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usrlevelTableAdapter = new CAS.casDataSetTableAdapters.usrlevelTableAdapter();
            this.moduldTableAdapter = new CAS.casDataSetTableAdapters.moduldTableAdapter();
            this.lstAssignedRole = new DevExpress.XtraEditors.ListBoxControl();
            this.lstAvailableRole = new DevExpress.XtraEditors.ListBoxControl();
            this.moduldBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            label1 = new System.Windows.Forms.Label();
            noseriLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoSeri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupMenuId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuidBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrlevelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduldBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstAssignedRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstAvailableRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduldBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.lstAvailableRole);
            this.pnlDetail.Controls.Add(this.lstAssignedRole);
            this.pnlDetail.Controls.Add(label2);
            this.pnlDetail.Controls.Add(this.lookupMenuId);
            this.pnlDetail.Controls.Add(remarkLabel);
            this.pnlDetail.Controls.Add(this.remarkTextEdit);
            this.pnlDetail.Controls.Add(this.btnMoveLAll);
            this.pnlDetail.Controls.Add(this.btnMoveL);
            this.pnlDetail.Controls.Add(this.btnMoveRAll);
            this.pnlDetail.Controls.Add(this.btnMoveR);
            this.pnlDetail.Controls.Add(label1);
            this.pnlDetail.Location = new System.Drawing.Point(0, 89);
            this.pnlDetail.Size = new System.Drawing.Size(477, 309);
            // 
            // pnlKey
            // 
            this.pnlKey.Controls.Add(noseriLabel);
            this.pnlKey.Controls.Add(this.txtNoSeri);
            this.pnlKey.Size = new System.Drawing.Size(477, 64);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(27, 67);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(64, 13);
            label1.TabIndex = 5;
            label1.Text = "Role Access";
            // 
            // noseriLabel
            // 
            noseriLabel.AutoSize = true;
            noseriLabel.Location = new System.Drawing.Point(27, 41);
            noseriLabel.Name = "noseriLabel";
            noseriLabel.Size = new System.Drawing.Size(41, 13);
            noseriLabel.TabIndex = 0;
            noseriLabel.Text = "No Seri";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(27, 38);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(43, 13);
            remarkLabel.TabIndex = 10;
            remarkLabel.Text = "Remark";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(27, 12);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(35, 13);
            label2.TabIndex = 13;
            label2.Text = "Modul";
            // 
            // btnMoveR
            // 
            this.btnMoveR.Location = new System.Drawing.Point(222, 104);
            this.btnMoveR.Name = "btnMoveR";
            this.btnMoveR.Size = new System.Drawing.Size(32, 29);
            this.btnMoveR.TabIndex = 7;
            this.btnMoveR.Text = ">";
            this.btnMoveR.Click += new System.EventHandler(this.btnMoveR_Click);
            // 
            // btnMoveRAll
            // 
            this.btnMoveRAll.Location = new System.Drawing.Point(222, 139);
            this.btnMoveRAll.Name = "btnMoveRAll";
            this.btnMoveRAll.Size = new System.Drawing.Size(32, 29);
            this.btnMoveRAll.TabIndex = 8;
            this.btnMoveRAll.Text = ">>";
            this.btnMoveRAll.Click += new System.EventHandler(this.btnMoveRAll_Click);
            // 
            // btnMoveL
            // 
            this.btnMoveL.Location = new System.Drawing.Point(222, 204);
            this.btnMoveL.Name = "btnMoveL";
            this.btnMoveL.Size = new System.Drawing.Size(32, 29);
            this.btnMoveL.TabIndex = 9;
            this.btnMoveL.Text = "<";
            this.btnMoveL.Click += new System.EventHandler(this.btnMoveL_Click);
            // 
            // btnMoveLAll
            // 
            this.btnMoveLAll.Location = new System.Drawing.Point(222, 239);
            this.btnMoveLAll.Name = "btnMoveLAll";
            this.btnMoveLAll.Size = new System.Drawing.Size(32, 29);
            this.btnMoveLAll.TabIndex = 10;
            this.btnMoveLAll.Text = "<<";
            this.btnMoveLAll.Click += new System.EventHandler(this.btnMoveLAll_Click);
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modulBindingSource
            // 
            this.modulBindingSource.DataMember = "modul";
            this.modulBindingSource.DataSource = this.casDataSet;
            // 
            // modulTableAdapter
            // 
            this.modulTableAdapter.ClearBeforeFill = true;
            // 
            // txtNoSeri
            // 
            this.txtNoSeri.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modulBindingSource, "noseri", true));
            this.txtNoSeri.Location = new System.Drawing.Point(85, 38);
            this.txtNoSeri.Name = "txtNoSeri";
            this.txtNoSeri.Size = new System.Drawing.Size(100, 20);
            this.txtNoSeri.TabIndex = 1;
            this.txtNoSeri.EditValueChanged += new System.EventHandler(this.txtNoSeri_EditValueChanged);
            // 
            // remarkTextEdit
            // 
            this.remarkTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modulBindingSource, "remark", true));
            this.remarkTextEdit.Location = new System.Drawing.Point(85, 35);
            this.remarkTextEdit.Name = "remarkTextEdit";
            this.remarkTextEdit.Size = new System.Drawing.Size(358, 20);
            this.remarkTextEdit.TabIndex = 11;
            // 
            // lookupMenuId
            // 
            this.lookupMenuId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modulBindingSource, "menuid", true));
            this.lookupMenuId.Location = new System.Drawing.Point(85, 9);
            this.lookupMenuId.Name = "lookupMenuId";
            this.lookupMenuId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupMenuId.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("menuid", "Menu Id", 53, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("caption", "Caption", 41, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookupMenuId.Properties.DataSource = this.menuidBindingSource;
            this.lookupMenuId.Properties.DisplayMember = "caption";
            this.lookupMenuId.Properties.ValueMember = "menuid";
            this.lookupMenuId.Size = new System.Drawing.Size(206, 23);
            this.lookupMenuId.TabIndex = 12;
            // 
            // menuidBindingSource
            // 
            this.menuidBindingSource.DataMember = "menuid";
            this.menuidBindingSource.DataSource = this.casDataSet;
            // 
            // menuidTableAdapter
            // 
            this.menuidTableAdapter.ClearBeforeFill = true;
            // 
            // usrlevelBindingSource
            // 
            this.usrlevelBindingSource.DataMember = "usrlevel";
            this.usrlevelBindingSource.DataSource = this.casDataSet;
            // 
            // moduldBindingSource
            // 
            this.moduldBindingSource.DataMember = "moduld";
            this.moduldBindingSource.DataSource = this.casDataSet;
            // 
            // usrlevelTableAdapter
            // 
            this.usrlevelTableAdapter.ClearBeforeFill = true;
            // 
            // moduldTableAdapter
            // 
            this.moduldTableAdapter.ClearBeforeFill = true;
            // 
            // lstAssignedRole
            // 
            this.lstAssignedRole.DataSource = this.moduldBindingSource;
            this.lstAssignedRole.DisplayMember = "role";
            this.lstAssignedRole.Location = new System.Drawing.Point(281, 83);
            this.lstAssignedRole.Name = "lstAssignedRole";
            this.lstAssignedRole.Size = new System.Drawing.Size(162, 199);
            this.lstAssignedRole.TabIndex = 16;
            this.lstAssignedRole.ValueMember = "role";
            this.lstAssignedRole.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstAssignedRole_MouseClick);
            // 
            // lstAvailableRole
            // 
            this.lstAvailableRole.DataSource = this.usrlevelBindingSource;
            this.lstAvailableRole.DisplayMember = "role";
            this.lstAvailableRole.Location = new System.Drawing.Point(30, 83);
            this.lstAvailableRole.Name = "lstAvailableRole";
            this.lstAvailableRole.Size = new System.Drawing.Size(164, 199);
            this.lstAvailableRole.TabIndex = 17;
            this.lstAvailableRole.ValueMember = "role";
            // 
            // moduldBindingSource1
            // 
            this.moduldBindingSource1.DataMember = "moduld";
            this.moduldBindingSource1.DataSource = this.casDataSet;
            // 
            // FrmMasterModul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(477, 465);
            this.MasterBindingSource = this.modulBindingSource;
            this.MasterQuery = "select * from modul";
            this.MasterTable = this.casDataSet.modul;
            this.Name = "FrmMasterModul";
            this.Tag = "modul";
            this.Text = "Master Modul";
            this.Load += new System.EventHandler(this.FrmMasterModul_Load);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.pnlKey.ResumeLayout(false);
            this.pnlKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoSeri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupMenuId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuidBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrlevelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduldBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstAssignedRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstAvailableRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduldBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnMoveLAll;
        private DevExpress.XtraEditors.SimpleButton btnMoveL;
        private DevExpress.XtraEditors.SimpleButton btnMoveRAll;
        private DevExpress.XtraEditors.SimpleButton btnMoveR;
        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource modulBindingSource;
        private CAS.casDataSetTableAdapters.modulTableAdapter modulTableAdapter;
        private DevExpress.XtraEditors.TextEdit remarkTextEdit;
        private DevExpress.XtraEditors.TextEdit txtNoSeri;
        private DevExpress.XtraEditors.LookUpEdit lookupMenuId;
        private System.Windows.Forms.BindingSource menuidBindingSource;
        private CAS.casDataSetTableAdapters.menuidTableAdapter menuidTableAdapter;
        private System.Windows.Forms.BindingSource usrlevelBindingSource;
        private CAS.casDataSetTableAdapters.usrlevelTableAdapter usrlevelTableAdapter;
        private System.Windows.Forms.BindingSource moduldBindingSource;
        private CAS.casDataSetTableAdapters.moduldTableAdapter moduldTableAdapter;
        private DevExpress.XtraEditors.ListBoxControl lstAssignedRole;
        private DevExpress.XtraEditors.ListBoxControl lstAvailableRole;
        private System.Windows.Forms.BindingSource moduldBindingSource1;
    }
}
