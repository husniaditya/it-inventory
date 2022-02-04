namespace CAS.Master
{
    partial class FrmMasterCct
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
            System.Windows.Forms.Label cctLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label parentLabel;
            System.Windows.Forms.Label detilLabel;
            System.Windows.Forms.Label level_Label;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMasterCct));
            this.cctBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casDataSet = new CAS.casDataSet();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.gcxAcb = new KASLibrary.GridControlEx();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.gcxCca = new KASLibrary.GridControlEx();
            this.level_SpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.detilCheckBox = new System.Windows.Forms.CheckBox();
            this.parentTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.cctTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.pnlChInfo = new System.Windows.Forms.Panel();
            this.txtChTime = new DevExpress.XtraEditors.TextEdit();
            this.txtChUser = new DevExpress.XtraEditors.TextEdit();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.tsbtnHelp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnPrint = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.colgroup_ = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.MasterNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.collevel_ = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeCct = new DevExpress.XtraTreeList.TreeList();
            this.colname = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.coldetil = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ccaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cctTableAdapter = new CAS.casDataSetTableAdapters.cctTableAdapter();
            this.acbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            cctLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            parentLabel = new System.Windows.Forms.Label();
            detilLabel = new System.Windows.Forms.Label();
            level_Label = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cctBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level_SpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cctTextEdit.Properties)).BeginInit();
            this.pnlChInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtChTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterNavigator)).BeginInit();
            this.MasterNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeCct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acbBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cctLabel
            // 
            cctLabel.AutoSize = true;
            cctLabel.Location = new System.Drawing.Point(27, 37);
            cctLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cctLabel.Name = "cctLabel";
            cctLabel.Size = new System.Drawing.Size(91, 19);
            cctLabel.TabIndex = 18;
            cctLabel.Text = "Cost Center";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(68, 100);
            nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(50, 19);
            nameLabel.TabIndex = 19;
            nameLabel.Text = "Name";
            // 
            // parentLabel
            // 
            parentLabel.AutoSize = true;
            parentLabel.Location = new System.Drawing.Point(63, 163);
            parentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            parentLabel.Name = "parentLabel";
            parentLabel.Size = new System.Drawing.Size(54, 19);
            parentLabel.TabIndex = 20;
            parentLabel.Text = "Parent";
            // 
            // detilLabel
            // 
            detilLabel.AutoSize = true;
            detilLabel.Location = new System.Drawing.Point(496, 163);
            detilLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            detilLabel.Name = "detilLabel";
            detilLabel.Size = new System.Drawing.Size(41, 19);
            detilLabel.TabIndex = 21;
            detilLabel.Text = "Detil";
            // 
            // level_Label
            // 
            level_Label.AutoSize = true;
            level_Label.Location = new System.Drawing.Point(333, 163);
            level_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            level_Label.Name = "level_Label";
            level_Label.Size = new System.Drawing.Size(45, 19);
            level_Label.TabIndex = 22;
            level_Label.Text = "Level";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(63, 221);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 19);
            label1.TabIndex = 25;
            label1.Text = "Budget";
            // 
            // cctBindingSource
            // 
            this.cctBindingSource.DataMember = "cct";
            this.cctBindingSource.DataSource = this.casDataSet;
            this.cctBindingSource.PositionChanged += new System.EventHandler(this.cctBindingSource_PositionChanged);
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.gcxAcb);
            this.pnlDetail.Controls.Add(label1);
            this.pnlDetail.Controls.Add(this.textEdit1);
            this.pnlDetail.Controls.Add(this.gcxCca);
            this.pnlDetail.Controls.Add(level_Label);
            this.pnlDetail.Controls.Add(this.level_SpinEdit);
            this.pnlDetail.Controls.Add(detilLabel);
            this.pnlDetail.Controls.Add(this.detilCheckBox);
            this.pnlDetail.Controls.Add(parentLabel);
            this.pnlDetail.Controls.Add(this.parentTextEdit);
            this.pnlDetail.Controls.Add(nameLabel);
            this.pnlDetail.Controls.Add(this.nameTextEdit);
            this.pnlDetail.Controls.Add(cctLabel);
            this.pnlDetail.Controls.Add(this.cctTextEdit);
            this.pnlDetail.Controls.Add(this.pnlChInfo);
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetail.Location = new System.Drawing.Point(458, 32);
            this.pnlDetail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(1276, 710);
            this.pnlDetail.TabIndex = 13;
            // 
            // gcxAcb
            // 
            this.gcxAcb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcxAcb.BestFitColumn = true;
            this.gcxAcb.ExAutoSize = false;
            this.gcxAcb.Location = new System.Drawing.Point(735, 260);
            this.gcxAcb.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.gcxAcb.Name = "gcxAcb";
            this.gcxAcb.Size = new System.Drawing.Size(541, 393);
            this.gcxAcb.TabIndex = 27;
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cctBindingSource, "budget", true));
            this.textEdit1.Location = new System.Drawing.Point(129, 216);
            this.textEdit1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(150, 26);
            this.textEdit1.TabIndex = 26;
            // 
            // gcxCca
            // 
            this.gcxCca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcxCca.BestFitColumn = true;
            this.gcxCca.ExAutoSize = false;
            this.gcxCca.Location = new System.Drawing.Point(0, 260);
            this.gcxCca.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.gcxCca.Name = "gcxCca";
            this.gcxCca.Size = new System.Drawing.Size(570, 393);
            this.gcxCca.TabIndex = 24;
            // 
            // level_SpinEdit
            // 
            this.level_SpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cctBindingSource, "level_", true));
            this.level_SpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.level_SpinEdit.Location = new System.Drawing.Point(392, 158);
            this.level_SpinEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.level_SpinEdit.Name = "level_SpinEdit";
            this.level_SpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.level_SpinEdit.Properties.ReadOnly = true;
            this.level_SpinEdit.Properties.UseCtrlIncrement = false;
            this.level_SpinEdit.Size = new System.Drawing.Size(52, 26);
            this.level_SpinEdit.TabIndex = 23;
            // 
            // detilCheckBox
            // 
            this.detilCheckBox.AutoCheck = false;
            this.detilCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.cctBindingSource, "detil", true));
            this.detilCheckBox.Location = new System.Drawing.Point(549, 155);
            this.detilCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.detilCheckBox.Name = "detilCheckBox";
            this.detilCheckBox.Size = new System.Drawing.Size(36, 37);
            this.detilCheckBox.TabIndex = 22;
            // 
            // parentTextEdit
            // 
            this.parentTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cctBindingSource, "parent", true));
            this.parentTextEdit.Location = new System.Drawing.Point(129, 158);
            this.parentTextEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.parentTextEdit.Name = "parentTextEdit";
            this.parentTextEdit.Size = new System.Drawing.Size(150, 26);
            this.parentTextEdit.TabIndex = 21;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cctBindingSource, "name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(129, 95);
            this.nameTextEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(428, 26);
            this.nameTextEdit.TabIndex = 20;
            // 
            // cctTextEdit
            // 
            this.cctTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cctBindingSource, "cct", true));
            this.cctTextEdit.Location = new System.Drawing.Point(129, 32);
            this.cctTextEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cctTextEdit.Name = "cctTextEdit";
            this.cctTextEdit.Size = new System.Drawing.Size(150, 26);
            this.cctTextEdit.TabIndex = 19;
            this.cctTextEdit.EditValueChanged += new System.EventHandler(this.cctTextEdit_EditValueChanged);
            // 
            // pnlChInfo
            // 
            this.pnlChInfo.AutoScroll = true;
            this.pnlChInfo.Controls.Add(this.txtChTime);
            this.pnlChInfo.Controls.Add(this.txtChUser);
            this.pnlChInfo.Controls.Add(this.lblTime);
            this.pnlChInfo.Controls.Add(this.lblUser);
            this.pnlChInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlChInfo.Location = new System.Drawing.Point(0, 650);
            this.pnlChInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlChInfo.Name = "pnlChInfo";
            this.pnlChInfo.Size = new System.Drawing.Size(1276, 60);
            this.pnlChInfo.TabIndex = 18;
            // 
            // txtChTime
            // 
            this.txtChTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtChTime.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cctBindingSource, "chtime", true));
            this.txtChTime.Location = new System.Drawing.Point(1074, 14);
            this.txtChTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChTime.Name = "txtChTime";
            this.txtChTime.Size = new System.Drawing.Size(150, 26);
            this.txtChTime.TabIndex = 10;
            // 
            // txtChUser
            // 
            this.txtChUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtChUser.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cctBindingSource, "chusr", true));
            this.txtChUser.Location = new System.Drawing.Point(812, 14);
            this.txtChUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChUser.Name = "txtChUser";
            this.txtChUser.Size = new System.Drawing.Size(150, 26);
            this.txtChUser.TabIndex = 9;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(1004, 20);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(45, 19);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Time";
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(752, 20);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(41, 19);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "User";
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 32);
            // 
            // tsbtnPrint
            // 
            this.tsbtnPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnPrint.Image")));
            this.tsbtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPrint.Name = "tsbtnPrint";
            this.tsbtnPrint.Size = new System.Drawing.Size(68, 29);
            this.tsbtnPrint.Text = "&Print";
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
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 29);
            this.pasteToolStripButton.Text = "&Paste";
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
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 29);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(454, 32);
            this.splitterControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(4, 710);
            this.splitterControl1.TabIndex = 14;
            this.splitterControl1.TabStop = false;
            // 
            // colgroup_
            // 
            this.colgroup_.Caption = "group_";
            this.colgroup_.FieldName = "group_";
            this.colgroup_.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colgroup_.Name = "colgroup_";
            this.colgroup_.Width = 50;
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
            // MasterNavigator
            // 
            this.MasterNavigator.AddNewItem = null;
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
            this.MasterNavigator.Size = new System.Drawing.Size(1734, 32);
            this.MasterNavigator.TabIndex = 12;
            this.MasterNavigator.Text = "bindingNavigator1";
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
            // collevel_
            // 
            this.collevel_.Caption = "level_";
            this.collevel_.FieldName = "level_";
            this.collevel_.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.collevel_.Name = "collevel_";
            this.collevel_.Width = 50;
            // 
            // treeCct
            // 
            this.treeCct.BestFitVisibleOnly = true;
            this.treeCct.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colname,
            this.coldetil,
            this.collevel_,
            this.colgroup_});
            this.treeCct.CustomizationFormBounds = new System.Drawing.Rectangle(659, 411, 208, 156);
            this.treeCct.DataSource = this.cctBindingSource;
            this.treeCct.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeCct.KeyFieldName = "cct";
            this.treeCct.Location = new System.Drawing.Point(0, 32);
            this.treeCct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.treeCct.Name = "treeCct";
            this.treeCct.OptionsBehavior.Editable = false;
            this.treeCct.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.treeCct.OptionsView.ShowColumns = false;
            this.treeCct.OptionsView.ShowIndicator = false;
            this.treeCct.ParentFieldName = "parent";
            this.treeCct.Size = new System.Drawing.Size(454, 710);
            this.treeCct.TabIndex = 11;
            this.treeCct.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeCct_FocusedNodeChanged);
            this.treeCct.BeforeFocusNode += new DevExpress.XtraTreeList.BeforeFocusNodeEventHandler(this.treeCct_BeforeFocusNode);
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
            // ccaBindingSource
            // 
            this.ccaBindingSource.DataMember = "cca";
            this.ccaBindingSource.DataSource = this.casDataSet;
            // 
            // cctTableAdapter
            // 
            this.cctTableAdapter.ClearBeforeFill = true;
            // 
            // acbBindingSource
            // 
            this.acbBindingSource.DataMember = "acb";
            this.acbBindingSource.DataSource = this.casDataSet;
            // 
            // FrmMasterCct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1734, 742);
            this.Controls.Add(this.pnlDetail);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.treeCct);
            this.Controls.Add(this.MasterNavigator);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMasterCct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Master Cost Center";
            this.Load += new System.EventHandler(this.FrmMasterCct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cctBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level_SpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cctTextEdit.Properties)).EndInit();
            this.pnlChInfo.ResumeLayout(false);
            this.pnlChInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtChTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterNavigator)).EndInit();
            this.MasterNavigator.ResumeLayout(false);
            this.MasterNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeCct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acbBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        protected System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.Panel pnlChInfo;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblUser;
        protected System.Windows.Forms.ToolStripButton tsbtnHelp;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        protected System.Windows.Forms.ToolStripButton tsbtnPrint;
        protected System.Windows.Forms.ToolStripButton tsbtnSave;
        protected System.Windows.Forms.ToolStripButton pasteToolStripButton;
        protected System.Windows.Forms.ToolStripButton copyToolStripButton;
        protected System.Windows.Forms.ToolStripButton cutToolStripButton;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colgroup_;
        protected System.Windows.Forms.ToolStripButton tsbtnDelete;
        protected System.Windows.Forms.BindingNavigator MasterNavigator;
        protected System.Windows.Forms.ToolStripButton tsbtnFirst;
        protected System.Windows.Forms.ToolStripButton tsbtnPrev;
        protected System.Windows.Forms.ToolStripButton tsbtnNext;
        protected System.Windows.Forms.ToolStripButton tsbtnLast;
        protected System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnBrowse;
        protected System.Windows.Forms.ToolStripDropDownButton tsbtnNew;
        private System.Windows.Forms.ToolStripMenuItem tsbtnNewRoot;
        private System.Windows.Forms.ToolStripMenuItem tsbtnNewChild;
        protected System.Windows.Forms.ToolStripButton tsbtnEdit;
        protected System.Windows.Forms.ToolStripButton tsbtnCancel;
        private DevExpress.XtraTreeList.Columns.TreeListColumn collevel_;
        private DevExpress.XtraTreeList.TreeList treeCct;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colname;
        private DevExpress.XtraTreeList.Columns.TreeListColumn coldetil;
        private System.Windows.Forms.BindingSource cctBindingSource;
        private DevExpress.XtraEditors.SpinEdit level_SpinEdit;
        private System.Windows.Forms.CheckBox detilCheckBox;
        private DevExpress.XtraEditors.TextEdit parentTextEdit;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.TextEdit cctTextEdit;
        private KASLibrary.GridControlEx gcxCca;
        private System.Windows.Forms.BindingSource ccaBindingSource;
        private DevExpress.XtraEditors.TextEdit txtChTime;
        private DevExpress.XtraEditors.TextEdit txtChUser;
        private CAS.casDataSetTableAdapters.cctTableAdapter cctTableAdapter;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private KASLibrary.GridControlEx gcxAcb;
        private System.Windows.Forms.BindingSource acbBindingSource;
    }
}