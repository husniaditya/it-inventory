namespace CAS.Master
{
    partial class FrmMasterAcc
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
            System.Windows.Forms.Label accLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label parentLabel;
            System.Windows.Forms.Label group_Label;
            System.Windows.Forms.Label detilLabel;
            System.Windows.Forms.Label level_Label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMasterAcc));
            this.treeAcc = new DevExpress.XtraTreeList.TreeList();
            this.colname = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.coldetil = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.collevel_ = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colgroup_ = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.accBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casDataSet = new CAS.casDataSet();
            this.MasterNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbtnFirst = new System.Windows.Forms.ToolStripButton();
            this.tsbtnPrev = new System.Windows.Forms.ToolStripButton();
            this.tsbtnNext = new System.Windows.Forms.ToolStripButton();
            this.tsbtnLast = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnBrowse = new System.Windows.Forms.ToolStripButton();
            this.tsbtnNew = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsbtnNewRoot = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnNewChild = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCancel = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.tsbtnPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnHelp = new System.Windows.Forms.ToolStripButton();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.gcxAcb = new KASLibrary.GridControlEx();
            this.pnlChInfo = new System.Windows.Forms.Panel();
            this.txtChUser = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtChTime = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.level_SpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.detilCheckBox = new System.Windows.Forms.CheckBox();
            this.group_ComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.parentTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.accTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.accTableAdapter = new CAS.casDataSetTableAdapters.accTableAdapter();
            this.acbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            accLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            parentLabel = new System.Windows.Forms.Label();
            group_Label = new System.Windows.Forms.Label();
            detilLabel = new System.Windows.Forms.Label();
            level_Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.treeAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterNavigator)).BeginInit();
            this.MasterNavigator.SuspendLayout();
            this.pnlDetail.SuspendLayout();
            this.pnlChInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.level_SpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.group_ComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acbBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // accLabel
            // 
            accLabel.AutoSize = true;
            accLabel.Location = new System.Drawing.Point(70, 86);
            accLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            accLabel.Name = "accLabel";
            accLabel.Size = new System.Drawing.Size(107, 19);
            accLabel.TabIndex = 9;
            accLabel.Text = "Account Code";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(66, 137);
            nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(112, 19);
            nameLabel.TabIndex = 10;
            nameLabel.Text = "Account Name";
            // 
            // parentLabel
            // 
            parentLabel.AutoSize = true;
            parentLabel.Location = new System.Drawing.Point(126, 191);
            parentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            parentLabel.Name = "parentLabel";
            parentLabel.Size = new System.Drawing.Size(54, 19);
            parentLabel.TabIndex = 11;
            parentLabel.Text = "Parent";
            // 
            // group_Label
            // 
            group_Label.AutoSize = true;
            group_Label.Location = new System.Drawing.Point(134, 337);
            group_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            group_Label.Name = "group_Label";
            group_Label.Size = new System.Drawing.Size(53, 19);
            group_Label.TabIndex = 13;
            group_Label.Text = "Group";
            // 
            // detilLabel
            // 
            detilLabel.AutoSize = true;
            detilLabel.Location = new System.Drawing.Point(141, 237);
            detilLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            detilLabel.Name = "detilLabel";
            detilLabel.Size = new System.Drawing.Size(41, 19);
            detilLabel.TabIndex = 14;
            detilLabel.Text = "Detil";
            // 
            // level_Label1
            // 
            level_Label1.AutoSize = true;
            level_Label1.Location = new System.Drawing.Point(129, 285);
            level_Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            level_Label1.Name = "level_Label1";
            level_Label1.Size = new System.Drawing.Size(50, 19);
            level_Label1.TabIndex = 16;
            level_Label1.Text = "Level ";
            // 
            // treeAcc
            // 
            this.treeAcc.BestFitVisibleOnly = true;
            this.treeAcc.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colname,
            this.coldetil,
            this.collevel_,
            this.colgroup_});
            this.treeAcc.CustomizationFormBounds = new System.Drawing.Rectangle(659, 411, 208, 156);
            this.treeAcc.DataSource = this.accBindingSource;
            this.treeAcc.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeAcc.KeyFieldName = "acc";
            this.treeAcc.Location = new System.Drawing.Point(0, 32);
            this.treeAcc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.treeAcc.Name = "treeAcc";
            this.treeAcc.OptionsBehavior.Editable = false;
            this.treeAcc.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.treeAcc.OptionsView.ShowColumns = false;
            this.treeAcc.OptionsView.ShowIndicator = false;
            this.treeAcc.ParentFieldName = "parent";
            this.treeAcc.Size = new System.Drawing.Size(454, 839);
            this.treeAcc.TabIndex = 0;
            this.treeAcc.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeAcc_FocusedNodeChanged);
            this.treeAcc.BeforeFocusNode += new DevExpress.XtraTreeList.BeforeFocusNodeEventHandler(this.treeAcc_BeforeFocusNode);
            // 
            // colname
            // 
            this.colname.Caption = "name";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.VisibleIndex = 0;
            this.colname.Width = 50;
            // 
            // coldetil
            // 
            this.coldetil.Caption = "detil";
            this.coldetil.FieldName = "detil";
            this.coldetil.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldetil.Name = "coldetil";
            this.coldetil.Width = 50;
            // 
            // collevel_
            // 
            this.collevel_.Caption = "level_";
            this.collevel_.FieldName = "level_";
            this.collevel_.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.collevel_.Name = "collevel_";
            this.collevel_.Width = 50;
            // 
            // colgroup_
            // 
            this.colgroup_.Caption = "group_";
            this.colgroup_.FieldName = "group_";
            this.colgroup_.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colgroup_.Name = "colgroup_";
            this.colgroup_.Width = 50;
            // 
            // accBindingSource
            // 
            this.accBindingSource.DataMember = "acc";
            this.accBindingSource.DataSource = this.casDataSet;
            this.accBindingSource.PositionChanged += new System.EventHandler(this.accBindingSource_PositionChanged);
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MasterNavigator
            // 
            this.MasterNavigator.AddNewItem = null;
            this.MasterNavigator.BindingSource = this.accBindingSource;
            this.MasterNavigator.CountItem = null;
            this.MasterNavigator.DeleteItem = this.tsbtnDelete;
            this.MasterNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnFirst,
            this.tsbtnPrev,
            this.tsbtnNext,
            this.tsbtnLast,
            this.bindingNavigatorSeparator2,
            this.tsbtnBrowse,
            this.tsbtnNew,
            this.tsbtnDelete,
            this.tsbtnEdit,
            this.tsbtnCancel,
            this.tsbtnSave,
            this.tsbtnPrint,
            this.toolStripSeparator,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator1,
            this.tsbtnHelp});
            this.MasterNavigator.Location = new System.Drawing.Point(0, 0);
            this.MasterNavigator.MoveFirstItem = this.tsbtnFirst;
            this.MasterNavigator.MoveLastItem = this.tsbtnLast;
            this.MasterNavigator.MoveNextItem = this.tsbtnNext;
            this.MasterNavigator.MovePreviousItem = this.tsbtnPrev;
            this.MasterNavigator.Name = "MasterNavigator";
            this.MasterNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.MasterNavigator.PositionItem = null;
            this.MasterNavigator.Size = new System.Drawing.Size(1254, 32);
            this.MasterNavigator.TabIndex = 1;
            this.MasterNavigator.Text = "bindingNavigator1";
            // 
            // tsbtnDelete
            // 
            this.tsbtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDelete.Image")));
            this.tsbtnDelete.Name = "tsbtnDelete";
            this.tsbtnDelete.RightToLeftAutoMirrorImage = true;
            this.tsbtnDelete.Size = new System.Drawing.Size(82, 29);
            this.tsbtnDelete.Text = "&Delete";
            this.tsbtnDelete.Click += new System.EventHandler(this.tsbtnDelete_Click);
            // 
            // tsbtnFirst
            // 
            this.tsbtnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnFirst.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnFirst.Image")));
            this.tsbtnFirst.Name = "tsbtnFirst";
            this.tsbtnFirst.RightToLeftAutoMirrorImage = true;
            this.tsbtnFirst.Size = new System.Drawing.Size(23, 29);
            this.tsbtnFirst.Text = "Move first";
            // 
            // tsbtnPrev
            // 
            this.tsbtnPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnPrev.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnPrev.Image")));
            this.tsbtnPrev.Name = "tsbtnPrev";
            this.tsbtnPrev.RightToLeftAutoMirrorImage = true;
            this.tsbtnPrev.Size = new System.Drawing.Size(23, 29);
            this.tsbtnPrev.Text = "Move previous";
            // 
            // tsbtnNext
            // 
            this.tsbtnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnNext.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnNext.Image")));
            this.tsbtnNext.Name = "tsbtnNext";
            this.tsbtnNext.RightToLeftAutoMirrorImage = true;
            this.tsbtnNext.Size = new System.Drawing.Size(23, 29);
            this.tsbtnNext.Text = "Move next";
            // 
            // tsbtnLast
            // 
            this.tsbtnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnLast.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnLast.Image")));
            this.tsbtnLast.Name = "tsbtnLast";
            this.tsbtnLast.RightToLeftAutoMirrorImage = true;
            this.tsbtnLast.Size = new System.Drawing.Size(23, 29);
            this.tsbtnLast.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // tsbtnBrowse
            // 
            this.tsbtnBrowse.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnBrowse.Image")));
            this.tsbtnBrowse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnBrowse.Name = "tsbtnBrowse";
            this.tsbtnBrowse.Size = new System.Drawing.Size(89, 29);
            this.tsbtnBrowse.Text = "&Browse";
            this.tsbtnBrowse.Click += new System.EventHandler(this.tsbtnBrowse_Click);
            // 
            // tsbtnNew
            // 
            this.tsbtnNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnNewRoot,
            this.tsbtnNewChild});
            this.tsbtnNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnNew.Image")));
            this.tsbtnNew.Name = "tsbtnNew";
            this.tsbtnNew.RightToLeftAutoMirrorImage = true;
            this.tsbtnNew.Size = new System.Drawing.Size(76, 29);
            this.tsbtnNew.Text = "&New";
            // 
            // tsbtnNewRoot
            // 
            this.tsbtnNewRoot.Name = "tsbtnNewRoot";
            this.tsbtnNewRoot.Size = new System.Drawing.Size(124, 30);
            this.tsbtnNewRoot.Text = "Root";
            this.tsbtnNewRoot.Click += new System.EventHandler(this.tsbtnNewRoot_Click);
            // 
            // tsbtnNewChild
            // 
            this.tsbtnNewChild.Name = "tsbtnNewChild";
            this.tsbtnNewChild.Size = new System.Drawing.Size(124, 30);
            this.tsbtnNewChild.Text = "Child";
            this.tsbtnNewChild.Click += new System.EventHandler(this.tsbtnNewChild_Click);
            // 
            // tsbtnEdit
            // 
            this.tsbtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEdit.Image")));
            this.tsbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEdit.Name = "tsbtnEdit";
            this.tsbtnEdit.Size = new System.Drawing.Size(62, 29);
            this.tsbtnEdit.Text = "&Edit";
            this.tsbtnEdit.Click += new System.EventHandler(this.tsbtnEdit_Click);
            // 
            // tsbtnCancel
            // 
            this.tsbtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCancel.Image")));
            this.tsbtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCancel.Name = "tsbtnCancel";
            this.tsbtnCancel.Size = new System.Drawing.Size(83, 29);
            this.tsbtnCancel.Text = "&Cancel";
            this.tsbtnCancel.Click += new System.EventHandler(this.tsbtnCancel_Click);
            // 
            // tsbtnSave
            // 
            this.tsbtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSave.Image")));
            this.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSave.Name = "tsbtnSave";
            this.tsbtnSave.Size = new System.Drawing.Size(69, 29);
            this.tsbtnSave.Text = "&Save";
            this.tsbtnSave.Click += new System.EventHandler(this.tsbtnSave_Click);
            // 
            // tsbtnPrint
            // 
            this.tsbtnPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnPrint.Image")));
            this.tsbtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPrint.Name = "tsbtnPrint";
            this.tsbtnPrint.Size = new System.Drawing.Size(68, 29);
            this.tsbtnPrint.Text = "&Print";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 32);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 29);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 29);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 29);
            this.pasteToolStripButton.Text = "&Paste";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // tsbtnHelp
            // 
            this.tsbtnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnHelp.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnHelp.Image")));
            this.tsbtnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnHelp.Name = "tsbtnHelp";
            this.tsbtnHelp.Size = new System.Drawing.Size(23, 29);
            this.tsbtnHelp.Text = "He&lp";
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.gcxAcb);
            this.pnlDetail.Controls.Add(this.pnlChInfo);
            this.pnlDetail.Controls.Add(level_Label1);
            this.pnlDetail.Controls.Add(this.level_SpinEdit);
            this.pnlDetail.Controls.Add(detilLabel);
            this.pnlDetail.Controls.Add(this.detilCheckBox);
            this.pnlDetail.Controls.Add(group_Label);
            this.pnlDetail.Controls.Add(this.group_ComboBoxEdit);
            this.pnlDetail.Controls.Add(parentLabel);
            this.pnlDetail.Controls.Add(this.parentTextEdit);
            this.pnlDetail.Controls.Add(nameLabel);
            this.pnlDetail.Controls.Add(this.nameTextEdit);
            this.pnlDetail.Controls.Add(accLabel);
            this.pnlDetail.Controls.Add(this.accTextEdit);
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetail.Location = new System.Drawing.Point(454, 32);
            this.pnlDetail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(800, 839);
            this.pnlDetail.TabIndex = 6;
            // 
            // gcxAcb
            // 
            this.gcxAcb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcxAcb.BestFitColumn = true;
            this.gcxAcb.ExAutoSize = false;
            this.gcxAcb.Location = new System.Drawing.Point(0, 401);
            this.gcxAcb.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.gcxAcb.Name = "gcxAcb";
            this.gcxAcb.Size = new System.Drawing.Size(844, 345);
            this.gcxAcb.TabIndex = 25;
            // 
            // pnlChInfo
            // 
            this.pnlChInfo.Controls.Add(this.txtChUser);
            this.pnlChInfo.Controls.Add(this.lblTime);
            this.pnlChInfo.Controls.Add(this.txtChTime);
            this.pnlChInfo.Controls.Add(this.lblUser);
            this.pnlChInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlChInfo.Location = new System.Drawing.Point(0, 759);
            this.pnlChInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlChInfo.Name = "pnlChInfo";
            this.pnlChInfo.Size = new System.Drawing.Size(800, 80);
            this.pnlChInfo.TabIndex = 18;
            // 
            // txtChUser
            // 
            this.txtChUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accBindingSource, "chusr", true));
            this.txtChUser.Location = new System.Drawing.Point(378, 25);
            this.txtChUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChUser.Name = "txtChUser";
            this.txtChUser.ReadOnly = true;
            this.txtChUser.Size = new System.Drawing.Size(148, 26);
            this.txtChUser.TabIndex = 7;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(562, 29);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(45, 19);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Time";
            // 
            // txtChTime
            // 
            this.txtChTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accBindingSource, "chtime", true));
            this.txtChTime.Location = new System.Drawing.Point(630, 25);
            this.txtChTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChTime.Name = "txtChTime";
            this.txtChTime.ReadOnly = true;
            this.txtChTime.Size = new System.Drawing.Size(148, 26);
            this.txtChTime.TabIndex = 9;
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(310, 29);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(41, 19);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "User";
            // 
            // level_SpinEdit
            // 
            this.level_SpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.accBindingSource, "level_", true));
            this.level_SpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.level_SpinEdit.Location = new System.Drawing.Point(225, 280);
            this.level_SpinEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.level_SpinEdit.Name = "level_SpinEdit";
            this.level_SpinEdit.Properties.IsFloatValue = false;
            this.level_SpinEdit.Properties.Mask.EditMask = "N00";
            this.level_SpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.level_SpinEdit.Properties.ReadOnly = true;
            this.level_SpinEdit.Properties.UseCtrlIncrement = false;
            this.level_SpinEdit.Size = new System.Drawing.Size(52, 26);
            this.level_SpinEdit.TabIndex = 17;
            // 
            // detilCheckBox
            // 
            this.detilCheckBox.AutoCheck = false;
            this.detilCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.accBindingSource, "detil", true));
            this.detilCheckBox.Location = new System.Drawing.Point(225, 229);
            this.detilCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.detilCheckBox.Name = "detilCheckBox";
            this.detilCheckBox.Size = new System.Drawing.Size(75, 37);
            this.detilCheckBox.TabIndex = 15;
            // 
            // group_ComboBoxEdit
            // 
            this.group_ComboBoxEdit.Location = new System.Drawing.Point(224, 328);
            this.group_ComboBoxEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.group_ComboBoxEdit.Name = "group_ComboBoxEdit";
            this.group_ComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.group_ComboBoxEdit.Properties.Items.AddRange(new object[] {
            "1   Aktiva",
            "2   Pasiva",
            "3   Modal",
            "4   Pendapatan",
            "5   Biaya",
            "6   Pendapatan Di Luar Usaha",
            "7   Biaya Di Luar  Usaha",
            "8   Lain-Lain"});
            this.group_ComboBoxEdit.Size = new System.Drawing.Size(150, 26);
            this.group_ComboBoxEdit.TabIndex = 14;
            // 
            // parentTextEdit
            // 
            this.parentTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.accBindingSource, "parent", true));
            this.parentTextEdit.EditValue = "";
            this.parentTextEdit.Location = new System.Drawing.Point(224, 186);
            this.parentTextEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.parentTextEdit.Name = "parentTextEdit";
            this.parentTextEdit.Size = new System.Drawing.Size(150, 26);
            this.parentTextEdit.TabIndex = 12;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.accBindingSource, "name", true));
            this.nameTextEdit.EditValue = "";
            this.nameTextEdit.Location = new System.Drawing.Point(224, 132);
            this.nameTextEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(386, 26);
            this.nameTextEdit.TabIndex = 11;
            this.nameTextEdit.EditValueChanged += new System.EventHandler(this.accTextEdit_EditValueChanged);
            // 
            // accTextEdit
            // 
            this.accTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.accBindingSource, "acc", true));
            this.accTextEdit.Location = new System.Drawing.Point(224, 82);
            this.accTextEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.accTextEdit.Name = "accTextEdit";
            this.accTextEdit.Size = new System.Drawing.Size(150, 26);
            this.accTextEdit.TabIndex = 10;
            this.accTextEdit.EditValueChanged += new System.EventHandler(this.accTextEdit_EditValueChanged);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(454, 32);
            this.splitterControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(4, 839);
            this.splitterControl1.TabIndex = 10;
            this.splitterControl1.TabStop = false;
            // 
            // accTableAdapter
            // 
            this.accTableAdapter.ClearBeforeFill = true;
            // 
            // acbBindingSource
            // 
            this.acbBindingSource.DataMember = "acb";
            this.acbBindingSource.DataSource = this.casDataSet;
            // 
            // FrmMasterAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 871);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.pnlDetail);
            this.Controls.Add(this.treeAcc);
            this.Controls.Add(this.MasterNavigator);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMasterAcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Master Persediaan";
            this.Load += new System.EventHandler(this.FrmMasterAcc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterNavigator)).EndInit();
            this.MasterNavigator.ResumeLayout(false);
            this.MasterNavigator.PerformLayout();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.pnlChInfo.ResumeLayout(false);
            this.pnlChInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.level_SpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.group_ComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acbBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeAcc;
        protected System.Windows.Forms.BindingNavigator MasterNavigator;
        protected System.Windows.Forms.ToolStripButton tsbtnDelete;
        protected System.Windows.Forms.ToolStripButton tsbtnFirst;
        protected System.Windows.Forms.ToolStripButton tsbtnPrev;
        protected System.Windows.Forms.ToolStripButton tsbtnNext;
        protected System.Windows.Forms.ToolStripButton tsbtnLast;
        protected System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnBrowse;
        protected System.Windows.Forms.ToolStripButton tsbtnEdit;
        protected System.Windows.Forms.ToolStripButton tsbtnCancel;
        protected System.Windows.Forms.ToolStripButton tsbtnSave;
        protected System.Windows.Forms.ToolStripButton tsbtnPrint;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        protected System.Windows.Forms.ToolStripButton cutToolStripButton;
        protected System.Windows.Forms.ToolStripButton copyToolStripButton;
        protected System.Windows.Forms.ToolStripButton pasteToolStripButton;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        protected System.Windows.Forms.ToolStripButton tsbtnHelp;
        protected System.Windows.Forms.Panel pnlDetail;
        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource accBindingSource;
        private System.Windows.Forms.TextBox txtChUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtChTime;
        private System.Windows.Forms.Label lblTime;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.ComboBoxEdit group_ComboBoxEdit;
        private DevExpress.XtraEditors.TextEdit parentTextEdit;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.TextEdit accTextEdit;
        private CAS.casDataSetTableAdapters.accTableAdapter accTableAdapter;
        protected System.Windows.Forms.ToolStripDropDownButton tsbtnNew;
        private System.Windows.Forms.ToolStripMenuItem tsbtnNewRoot;
        private System.Windows.Forms.ToolStripMenuItem tsbtnNewChild;
        private System.Windows.Forms.CheckBox detilCheckBox;
        private DevExpress.XtraEditors.SpinEdit level_SpinEdit;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colname;
        private DevExpress.XtraTreeList.Columns.TreeListColumn coldetil;
        private DevExpress.XtraTreeList.Columns.TreeListColumn collevel_;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colgroup_;
        private System.Windows.Forms.Panel pnlChInfo;
        private KASLibrary.GridControlEx gcxAcb;
        private System.Windows.Forms.BindingSource acbBindingSource;
    }
}