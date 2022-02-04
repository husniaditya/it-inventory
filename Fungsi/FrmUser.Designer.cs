namespace CAS.Fungsi
{
    partial class FrmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUser));
            this.roleLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tsbtnNew = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repludRole = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.casDataSet = new CAS.casDataSet();
            this.usrlevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reptxtPassword = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tsbtnPrint = new System.Windows.Forms.ToolStripButton();
            this.ludRole = new DevExpress.XtraEditors.LookUpEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.tsbtnCancel = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.MasterNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.usrGridControl = new DevExpress.XtraGrid.GridControl();
            this.usrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coluser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colchtime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colchusr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrole = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaprovname = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.repludRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrlevelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reptxtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludRole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterNavigator)).BeginInit();
            this.MasterNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usrGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(36, 53);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(29, 13);
            this.roleLabel.TabIndex = 6;
            this.roleLabel.Text = "role:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(36, 85);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(37, 13);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "name:";
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Aproval Name";
            this.gridColumn7.FieldName = "aprovname";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            // 
            // tsbtnNew
            // 
            this.tsbtnNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnNew.Image")));
            this.tsbtnNew.Name = "tsbtnNew";
            this.tsbtnNew.RightToLeftAutoMirrorImage = true;
            this.tsbtnNew.Size = new System.Drawing.Size(77, 22);
            this.tsbtnNew.Text = "&New User";
            this.tsbtnNew.Click += new System.EventHandler(this.tsbtnNew_Click);
            // 
            // tsbtnDelete
            // 
            this.tsbtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDelete.Image")));
            this.tsbtnDelete.Name = "tsbtnDelete";
            this.tsbtnDelete.RightToLeftAutoMirrorImage = true;
            this.tsbtnDelete.Size = new System.Drawing.Size(86, 22);
            this.tsbtnDelete.Text = "&Delete User";
            this.tsbtnDelete.Click += new System.EventHandler(this.tsbtnDelete_Click);
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Role";
            this.gridColumn6.ColumnEdit = this.repludRole;
            this.gridColumn6.FieldName = "role";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            // 
            // repludRole
            // 
            this.repludRole.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repludRole.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("role", "role", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repludRole.DisplayMember = "name";
            this.repludRole.Name = "repludRole";
            this.repludRole.ValueMember = "role";
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
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Password";
            this.gridColumn3.ColumnEdit = this.reptxtPassword;
            this.gridColumn3.FieldName = "password";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // reptxtPassword
            // 
            this.reptxtPassword.AutoHeight = false;
            this.reptxtPassword.MaxLength = 16;
            this.reptxtPassword.Name = "reptxtPassword";
            this.reptxtPassword.PasswordChar = '*';
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "chtime";
            this.gridColumn4.FieldName = "chtime";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "chusr";
            this.gridColumn5.FieldName = "chusr";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // tsbtnPrint
            // 
            this.tsbtnPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnPrint.Image")));
            this.tsbtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPrint.Name = "tsbtnPrint";
            this.tsbtnPrint.Size = new System.Drawing.Size(52, 20);
            this.tsbtnPrint.Text = "&Print";
            // 
            // ludRole
            // 
            this.ludRole.Location = new System.Drawing.Point(92, 50);
            this.ludRole.Name = "ludRole";
            this.ludRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ludRole.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("role", "Role", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Name", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.ludRole.Properties.DataSource = this.usrlevelBindingSource;
            this.ludRole.Properties.DisplayMember = "role";
            this.ludRole.Properties.ValueMember = "role";
            this.ludRole.Size = new System.Drawing.Size(100, 23);
            this.ludRole.TabIndex = 7;
            this.ludRole.EditValueChanged += new System.EventHandler(this.ludRole_EditValueChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(92, 82);
            this.txtName.Name = "txtName";
            this.txtName.Properties.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(196, 20);
            this.txtName.TabIndex = 9;
            // 
            // tsbtnCancel
            // 
            this.tsbtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCancel.Image")));
            this.tsbtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCancel.Name = "tsbtnCancel";
            this.tsbtnCancel.Size = new System.Drawing.Size(63, 22);
            this.tsbtnCancel.Text = "&Cancel";
            this.tsbtnCancel.Click += new System.EventHandler(this.tsbtnCancel_Click);
            // 
            // tsbtnEdit
            // 
            this.tsbtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEdit.Image")));
            this.tsbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEdit.Name = "tsbtnEdit";
            this.tsbtnEdit.Size = new System.Drawing.Size(73, 22);
            this.tsbtnEdit.Text = "&Edit User";
            this.tsbtnEdit.Click += new System.EventHandler(this.tsbtnEdit_Click);
            // 
            // tsbtnSave
            // 
            this.tsbtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSave.Image")));
            this.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSave.Name = "tsbtnSave";
            this.tsbtnSave.Size = new System.Drawing.Size(51, 22);
            this.tsbtnSave.Text = "&Save";
            this.tsbtnSave.Click += new System.EventHandler(this.tsbtnSave_Click);
            // 
            // MasterNavigator
            // 
            this.MasterNavigator.AddNewItem = null;
            this.MasterNavigator.CountItem = null;
            this.MasterNavigator.DeleteItem = null;
            this.MasterNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnNew,
            this.tsbtnDelete,
            this.tsbtnEdit,
            this.tsbtnCancel,
            this.tsbtnSave,
            this.tsbtnPrint});
            this.MasterNavigator.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MasterNavigator.Location = new System.Drawing.Point(0, 0);
            this.MasterNavigator.MoveFirstItem = null;
            this.MasterNavigator.MoveLastItem = null;
            this.MasterNavigator.MoveNextItem = null;
            this.MasterNavigator.MovePreviousItem = null;
            this.MasterNavigator.Name = "MasterNavigator";
            this.MasterNavigator.PositionItem = null;
            this.MasterNavigator.Size = new System.Drawing.Size(401, 25);
            this.MasterNavigator.TabIndex = 11;
            this.MasterNavigator.Text = "bindingNavigator1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Name";
            this.gridColumn2.FieldName = "name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // usrGridControl
            // 
            this.usrGridControl.DataSource = this.usrBindingSource;
            this.usrGridControl.EmbeddedNavigator.Name = "";
            this.usrGridControl.Location = new System.Drawing.Point(26, 123);
            this.usrGridControl.MainView = this.gridView1;
            this.usrGridControl.Name = "usrGridControl";
            this.usrGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reptxtPassword,
            this.repludRole});
            this.usrGridControl.Size = new System.Drawing.Size(332, 265);
            this.usrGridControl.TabIndex = 10;
            this.usrGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1,
            this.gridView1});
            // 
            // usrBindingSource
            // 
            this.usrBindingSource.DataMember = "usr";
            this.usrBindingSource.DataSource = this.casDataSet;
            // 
            // cardView1
            // 
            this.cardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.cardView1.FocusedCardTopFieldIndex = 0;
            this.cardView1.GridControl = this.usrGridControl;
            this.cardView1.MaximumCardColumns = 1;
            this.cardView1.MaximumCardRows = 1;
            this.cardView1.Name = "cardView1";
            this.cardView1.OptionsBehavior.AutoHorzWidth = true;
            this.cardView1.OptionsBehavior.UseTabKey = true;
            this.cardView1.OptionsView.ShowCardExpandButton = false;
            this.cardView1.OptionsView.ShowHorzScrollBar = false;
            this.cardView1.OptionsView.ShowLines = false;
            this.cardView1.OptionsView.ShowQuickCustomizeButton = false;
            this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            this.cardView1.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.cardView1_CustomUnboundColumnData);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "User";
            this.gridColumn1.FieldName = "user";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Otorisasi Password";
            this.gridColumn8.FieldName = "pswd";
            this.gridColumn8.MinWidth = 10;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 4;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coluser,
            this.colname,
            this.colchtime,
            this.colchusr,
            this.colrole,
            this.colaprovname});
            this.gridView1.GridControl = this.usrGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // coluser
            // 
            this.coluser.Caption = "User";
            this.coluser.FieldName = "user";
            this.coluser.Name = "coluser";
            this.coluser.Visible = true;
            this.coluser.VisibleIndex = 0;
            // 
            // colname
            // 
            this.colname.Caption = "Name";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            // 
            // colchtime
            // 
            this.colchtime.Caption = "chtime";
            this.colchtime.FieldName = "chtime";
            this.colchtime.Name = "colchtime";
            // 
            // colchusr
            // 
            this.colchusr.Caption = "chusr";
            this.colchusr.FieldName = "chusr";
            this.colchusr.Name = "colchusr";
            // 
            // colrole
            // 
            this.colrole.Caption = "Role";
            this.colrole.ColumnEdit = this.repludRole;
            this.colrole.FieldName = "role";
            this.colrole.Name = "colrole";
            this.colrole.Visible = true;
            this.colrole.VisibleIndex = 2;
            // 
            // colaprovname
            // 
            this.colaprovname.Caption = "Nama Aproval";
            this.colaprovname.FieldName = "aprovname";
            this.colaprovname.Name = "colaprovname";
            this.colaprovname.Visible = true;
            this.colaprovname.VisibleIndex = 3;
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 409);
            this.Controls.Add(this.ludRole);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.MasterNavigator);
            this.Controls.Add(this.usrGridControl);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUser";
            this.Text = "User Management";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repludRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrlevelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reptxtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludRole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterNavigator)).EndInit();
            this.MasterNavigator.ResumeLayout(false);
            this.MasterNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usrGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        protected System.Windows.Forms.ToolStripButton tsbtnNew;
        protected System.Windows.Forms.ToolStripButton tsbtnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private System.Windows.Forms.BindingSource usrlevelBindingSource;
        private casDataSet casDataSet;
        protected System.Windows.Forms.ToolStripButton tsbtnPrint;
        private DevExpress.XtraEditors.LookUpEdit ludRole;
        private DevExpress.XtraEditors.TextEdit txtName;
        protected System.Windows.Forms.ToolStripButton tsbtnCancel;
        protected System.Windows.Forms.ToolStripButton tsbtnEdit;
        protected System.Windows.Forms.ToolStripButton tsbtnSave;
        protected System.Windows.Forms.BindingNavigator MasterNavigator;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.GridControl usrGridControl;
        private System.Windows.Forms.BindingSource usrBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn coluser;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colchtime;
        private DevExpress.XtraGrid.Columns.GridColumn colchusr;
        private DevExpress.XtraGrid.Columns.GridColumn colrole;
        private DevExpress.XtraGrid.Columns.GridColumn colaprovname;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit reptxtPassword;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repludRole;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Label nameLabel;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;



    }
}