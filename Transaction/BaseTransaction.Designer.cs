namespace CAS.Transaction
{
    partial class BaseTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseTransaction));
            this.txtNo = new DevExpress.XtraEditors.TextEdit();
            this.txtPeriod = new DevExpress.XtraEditors.TextEdit();
            this.ludSeri = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtChTime = new DevExpress.XtraEditors.TextEdit();
            this.tslblRecord = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtChUser = new DevExpress.XtraEditors.TextEdit();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.curLabel1 = new System.Windows.Forms.Label();
            this.kursLabel = new System.Windows.Forms.Label();
            this.curkurs = new DevExpress.XtraEditors.SpinEdit();
            this.curcur = new KASLibrary.TextBoxEx();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateDate = new DevExpress.XtraEditors.DateEdit();
            this.pnlKey = new System.Windows.Forms.Panel();
            this.lblDeleted = new System.Windows.Forms.Label();
            this.btnDocFlow = new DevExpress.XtraEditors.SimpleButton();
            this.pnlChInfo = new System.Windows.Forms.Panel();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.MasterNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.tsbtnFirst = new System.Windows.Forms.ToolStripButton();
            this.tsbtnPrev = new System.Windows.Forms.ToolStripButton();
            this.tsbtnNext = new System.Windows.Forms.ToolStripButton();
            this.tsbtnLast = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnBrowse = new System.Windows.Forms.ToolStripButton();
            this.tsbtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsbtnNew = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCancel = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.tsbtnPrint = new System.Windows.Forms.ToolStripButton();
            this.tsbtnJurnal = new System.Windows.Forms.ToolStripButton();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tsbtnHelp = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludSeri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChUser.Properties)).BeginInit();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.curkurs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curcur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).BeginInit();
            this.pnlKey.SuspendLayout();
            this.pnlChInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MasterNavigator)).BeginInit();
            this.MasterNavigator.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(241, 19);
            this.txtNo.Name = "txtNo";
            this.txtNo.Properties.ReadOnly = true;
            this.txtNo.Size = new System.Drawing.Size(85, 20);
            this.txtNo.TabIndex = 7;
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(192, 19);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Properties.ReadOnly = true;
            this.txtPeriod.Size = new System.Drawing.Size(43, 20);
            this.txtPeriod.TabIndex = 6;
            // 
            // ludSeri
            // 
            this.ludSeri.Location = new System.Drawing.Point(115, 19);
            this.ludSeri.Name = "ludSeri";
            this.ludSeri.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ludSeri.Properties.NullText = "???";
            this.ludSeri.Size = new System.Drawing.Size(71, 23);
            this.ludSeri.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nomer";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(423, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(29, 13);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "User";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(591, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(29, 13);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time";
            // 
            // txtChTime
            // 
            this.txtChTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChTime.Location = new System.Drawing.Point(627, 6);
            this.txtChTime.Name = "txtChTime";
            this.txtChTime.Size = new System.Drawing.Size(100, 20);
            this.txtChTime.TabIndex = 5;
            // 
            // tslblRecord
            // 
            this.tslblRecord.Name = "tslblRecord";
            this.tslblRecord.Size = new System.Drawing.Size(76, 17);
            this.tslblRecord.Text = "Record 1 of 1";
            // 
            // txtChUser
            // 
            this.txtChUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChUser.Location = new System.Drawing.Point(458, 6);
            this.txtChUser.Name = "txtChUser";
            this.txtChUser.Size = new System.Drawing.Size(100, 20);
            this.txtChUser.TabIndex = 6;
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.curLabel1);
            this.pnlDetail.Controls.Add(this.kursLabel);
            this.pnlDetail.Controls.Add(this.curkurs);
            this.pnlDetail.Controls.Add(this.curcur);
            this.pnlDetail.Controls.Add(this.dateLabel);
            this.pnlDetail.Controls.Add(this.dateDate);
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetail.Location = new System.Drawing.Point(0, 75);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(748, 335);
            this.pnlDetail.TabIndex = 10;
            this.pnlDetail.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDetail_Paint);
            // 
            // curLabel1
            // 
            this.curLabel1.AutoSize = true;
            this.curLabel1.Location = new System.Drawing.Point(358, 35);
            this.curLabel1.Name = "curLabel1";
            this.curLabel1.Size = new System.Drawing.Size(24, 13);
            this.curLabel1.TabIndex = 27;
            this.curLabel1.Text = "Cur";
            // 
            // kursLabel
            // 
            this.kursLabel.AutoSize = true;
            this.kursLabel.Location = new System.Drawing.Point(452, 35);
            this.kursLabel.Name = "kursLabel";
            this.kursLabel.Size = new System.Drawing.Size(28, 13);
            this.kursLabel.TabIndex = 25;
            this.kursLabel.Text = "Kurs";
            // 
            // curkurs
            // 
            this.curkurs.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.curkurs.Location = new System.Drawing.Point(488, 32);
            this.curkurs.Name = "curkurs";
            this.curkurs.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.curkurs.Properties.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.curkurs.Properties.UseCtrlIncrement = false;
            this.curkurs.Size = new System.Drawing.Size(73, 20);
            this.curkurs.TabIndex = 26;
            // 
            // curcur
            // 
            this.curcur.ExAllowEmptyString = true;
            this.curcur.ExAllowNonDBData = false;
            this.curcur.ExAutoCheck = false;
            this.curcur.ExAutoShowResult = false;
            this.curcur.ExCondition = "";
            this.curcur.ExDialogTitle = "Currency";
            this.curcur.ExFieldName = "cur";
            this.curcur.ExFilterFields = new string[0];
            this.curcur.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.curcur.ExInvalidForeColor = System.Drawing.Color.Black;
            this.curcur.ExLabelContainer = null;
            this.curcur.ExLabelField = "";
            this.curcur.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.curcur.ExLabelText = "";
            this.curcur.ExLabelVisible = false;
            this.curcur.ExSelectFields = new string[] {
        "cur",
        "name"};
            this.curcur.ExShowDialog = true;
            this.curcur.ExSimpleMode = true;
            this.curcur.ExSqlInstance = null;
            this.curcur.ExSqlQuery = "select cur,name from cur";
            this.curcur.ExTableName = "cur";
            this.curcur.Location = new System.Drawing.Point(389, 32);
            this.curcur.Name = "curcur";
            this.curcur.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.curcur.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.curcur.Properties.Appearance.Options.UseBackColor = true;
            this.curcur.Properties.Appearance.Options.UseForeColor = true;
            this.curcur.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.curcur.Size = new System.Drawing.Size(57, 20);
            this.curcur.TabIndex = 28;
            this.curcur.EditValueChanged += new System.EventHandler(this.txtCur_EditValueChanged);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(337, 9);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(45, 13);
            this.dateLabel.TabIndex = 9;
            this.dateLabel.Text = "Tanggal";
            // 
            // dateDate
            // 
            this.dateDate.EditValue = new System.DateTime(((long)(0)));
            this.dateDate.Location = new System.Drawing.Point(389, 6);
            this.dateDate.Name = "dateDate";
            this.dateDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateDate.Properties.Mask.IgnoreMaskBlank = false;
            this.dateDate.Size = new System.Drawing.Size(100, 23);
            this.dateDate.TabIndex = 8;
            this.dateDate.EditValueChanged += new System.EventHandler(this.dateDate_EditValueChanged);
            // 
            // pnlKey
            // 
            this.pnlKey.Controls.Add(this.lblDeleted);
            this.pnlKey.Controls.Add(this.btnDocFlow);
            this.pnlKey.Controls.Add(this.txtPeriod);
            this.pnlKey.Controls.Add(this.txtNo);
            this.pnlKey.Controls.Add(this.ludSeri);
            this.pnlKey.Controls.Add(this.label1);
            this.pnlKey.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKey.Location = new System.Drawing.Point(0, 25);
            this.pnlKey.Name = "pnlKey";
            this.pnlKey.Size = new System.Drawing.Size(748, 50);
            this.pnlKey.TabIndex = 12;
            // 
            // lblDeleted
            // 
            this.lblDeleted.AutoSize = true;
            this.lblDeleted.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDeleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleted.ForeColor = System.Drawing.Color.Red;
            this.lblDeleted.Location = new System.Drawing.Point(351, 16);
            this.lblDeleted.Name = "lblDeleted";
            this.lblDeleted.Size = new System.Drawing.Size(81, 19);
            this.lblDeleted.TabIndex = 10;
            this.lblDeleted.Text = "DELETED";
            this.lblDeleted.Visible = false;
            // 
            // btnDocFlow
            // 
            this.btnDocFlow.Location = new System.Drawing.Point(466, 16);
            this.btnDocFlow.Name = "btnDocFlow";
            this.btnDocFlow.Size = new System.Drawing.Size(86, 23);
            this.btnDocFlow.TabIndex = 9;
            this.btnDocFlow.Text = "Document &Flow";
            this.btnDocFlow.Visible = false;
            this.btnDocFlow.Click += new System.EventHandler(this.btnDocFlow_Click);
            // 
            // pnlChInfo
            // 
            this.pnlChInfo.Controls.Add(this.txtChUser);
            this.pnlChInfo.Controls.Add(this.txtChTime);
            this.pnlChInfo.Controls.Add(this.lblUser);
            this.pnlChInfo.Controls.Add(this.lblTime);
            this.pnlChInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlChInfo.Location = new System.Drawing.Point(0, 410);
            this.pnlChInfo.Name = "pnlChInfo";
            this.pnlChInfo.Size = new System.Drawing.Size(748, 33);
            this.pnlChInfo.TabIndex = 11;
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // MasterNavigator
            // 
            this.MasterNavigator.AddNewItem = null;
            this.MasterNavigator.CountItem = null;
            this.MasterNavigator.DeleteItem = null;
            this.MasterNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnFirst,
            this.tsbtnPrev,
            this.tsbtnNext,
            this.tsbtnLast,
            this.bindingNavigatorSeparator2,
            this.tsbtnBrowse,
            this.tsbtnRefresh,
            this.tsbtnNew,
            this.tsbtnDelete,
            this.tsbtnEdit,
            this.tsbtnCancel,
            this.tsbtnSave,
            this.tsbtnPrint,
            this.tsbtnJurnal,
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
            this.MasterNavigator.PositionItem = null;
            this.MasterNavigator.Size = new System.Drawing.Size(748, 25);
            this.MasterNavigator.TabIndex = 9;
            this.MasterNavigator.Text = "bindingNavigator1";
            // 
            // tsbtnFirst
            // 
            this.tsbtnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnFirst.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnFirst.Image")));
            this.tsbtnFirst.Name = "tsbtnFirst";
            this.tsbtnFirst.RightToLeftAutoMirrorImage = true;
            this.tsbtnFirst.Size = new System.Drawing.Size(23, 22);
            this.tsbtnFirst.Text = "Move first";
            this.tsbtnFirst.Click += new System.EventHandler(this.tsbtnFirst_Click);
            // 
            // tsbtnPrev
            // 
            this.tsbtnPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnPrev.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnPrev.Image")));
            this.tsbtnPrev.Name = "tsbtnPrev";
            this.tsbtnPrev.RightToLeftAutoMirrorImage = true;
            this.tsbtnPrev.Size = new System.Drawing.Size(23, 22);
            this.tsbtnPrev.Text = "Move previous";
            // 
            // tsbtnNext
            // 
            this.tsbtnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnNext.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnNext.Image")));
            this.tsbtnNext.Name = "tsbtnNext";
            this.tsbtnNext.RightToLeftAutoMirrorImage = true;
            this.tsbtnNext.Size = new System.Drawing.Size(23, 22);
            this.tsbtnNext.Text = "Move next";
            // 
            // tsbtnLast
            // 
            this.tsbtnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnLast.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnLast.Image")));
            this.tsbtnLast.Name = "tsbtnLast";
            this.tsbtnLast.RightToLeftAutoMirrorImage = true;
            this.tsbtnLast.Size = new System.Drawing.Size(23, 22);
            this.tsbtnLast.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnBrowse
            // 
            this.tsbtnBrowse.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnBrowse.Image")));
            this.tsbtnBrowse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnBrowse.Name = "tsbtnBrowse";
            this.tsbtnBrowse.Size = new System.Drawing.Size(65, 22);
            this.tsbtnBrowse.Text = "&Browse";
            this.tsbtnBrowse.Click += new System.EventHandler(this.tsbtnBrowse_Click);
            // 
            // tsbtnRefresh
            // 
            this.tsbtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnRefresh.Image")));
            this.tsbtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRefresh.Name = "tsbtnRefresh";
            this.tsbtnRefresh.Size = new System.Drawing.Size(66, 22);
            this.tsbtnRefresh.Text = "Refresh";
            this.tsbtnRefresh.Click += new System.EventHandler(this.tsbtnRefresh_Click);
            // 
            // tsbtnNew
            // 
            this.tsbtnNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnNew.Image")));
            this.tsbtnNew.Name = "tsbtnNew";
            this.tsbtnNew.RightToLeftAutoMirrorImage = true;
            this.tsbtnNew.Size = new System.Drawing.Size(51, 22);
            this.tsbtnNew.Text = "&New";
            this.tsbtnNew.Click += new System.EventHandler(this.tsbtnNew_Click);
            // 
            // tsbtnDelete
            // 
            this.tsbtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDelete.Image")));
            this.tsbtnDelete.Name = "tsbtnDelete";
            this.tsbtnDelete.RightToLeftAutoMirrorImage = true;
            this.tsbtnDelete.Size = new System.Drawing.Size(60, 22);
            this.tsbtnDelete.Text = "&Delete";
            this.tsbtnDelete.Click += new System.EventHandler(this.tsbtnDelete_Click);
            // 
            // tsbtnEdit
            // 
            this.tsbtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEdit.Image")));
            this.tsbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEdit.Name = "tsbtnEdit";
            this.tsbtnEdit.Size = new System.Drawing.Size(47, 22);
            this.tsbtnEdit.Text = "&Edit";
            this.tsbtnEdit.Click += new System.EventHandler(this.tsbtnEdit_Click);
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
            // tsbtnSave
            // 
            this.tsbtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSave.Image")));
            this.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSave.Name = "tsbtnSave";
            this.tsbtnSave.Size = new System.Drawing.Size(51, 22);
            this.tsbtnSave.Text = "&Save";
            this.tsbtnSave.Click += new System.EventHandler(this.tsbtnSave_Click);
            // 
            // tsbtnPrint
            // 
            this.tsbtnPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnPrint.Image")));
            this.tsbtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPrint.Name = "tsbtnPrint";
            this.tsbtnPrint.Size = new System.Drawing.Size(52, 22);
            this.tsbtnPrint.Text = "&Print";
            // 
            // tsbtnJurnal
            // 
            this.tsbtnJurnal.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnJurnal.Image")));
            this.tsbtnJurnal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnJurnal.Name = "tsbtnJurnal";
            this.tsbtnJurnal.Size = new System.Drawing.Size(58, 22);
            this.tsbtnJurnal.Text = "&Jurnal";
            this.tsbtnJurnal.Click += new System.EventHandler(this.tsbtnJurnal_Click);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton.Text = "&Paste";
            // 
            // tsbtnHelp
            // 
            this.tsbtnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnHelp.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnHelp.Image")));
            this.tsbtnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnHelp.Name = "tsbtnHelp";
            this.tsbtnHelp.Size = new System.Drawing.Size(23, 22);
            this.tsbtnHelp.Text = "He&lp";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblRecord});
            this.statusStrip1.Location = new System.Drawing.Point(0, 443);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(748, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // BaseTransaction
            // 
            this.ClientSize = new System.Drawing.Size(748, 465);
            this.Controls.Add(this.pnlDetail);
            this.Controls.Add(this.pnlKey);
            this.Controls.Add(this.pnlChInfo);
            this.Controls.Add(this.MasterNavigator);
            this.Controls.Add(this.statusStrip1);
            this.Name = "BaseTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.BaseTransaction_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BaseTransaction_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludSeri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChUser.Properties)).EndInit();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.curkurs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curcur.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).EndInit();
            this.pnlKey.ResumeLayout(false);
            this.pnlKey.PerformLayout();
            this.pnlChInfo.ResumeLayout(false);
            this.pnlChInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MasterNavigator)).EndInit();
            this.MasterNavigator.ResumeLayout(false);
            this.MasterNavigator.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected DevExpress.XtraEditors.TextEdit txtNo;
        protected DevExpress.XtraEditors.TextEdit txtPeriod;
        protected DevExpress.XtraEditors.LookUpEdit ludSeri;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        protected System.Windows.Forms.ToolStripButton tsbtnHelp;
        private System.Windows.Forms.Label lblUser;
        protected System.Windows.Forms.ToolStripButton cutToolStripButton;
        protected System.Windows.Forms.ToolStripButton copyToolStripButton;
        protected System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.Label lblTime;
        private DevExpress.XtraEditors.TextEdit txtChTime;
        private System.Windows.Forms.ToolStripStatusLabel tslblRecord;
        private DevExpress.XtraEditors.TextEdit txtChUser;
        protected System.Windows.Forms.Panel pnlDetail;
        protected System.Windows.Forms.Panel pnlKey;
        private System.Windows.Forms.Panel pnlChInfo;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        protected System.Windows.Forms.ToolStripButton tsbtnFirst;
        protected System.Windows.Forms.ToolStripButton tsbtnPrev;
        protected System.Windows.Forms.ToolStripButton tsbtnNext;
        protected System.Windows.Forms.ToolStripButton tsbtnDelete;
        protected System.Windows.Forms.BindingNavigator MasterNavigator;
        protected System.Windows.Forms.ToolStripButton tsbtnNew;
        protected System.Windows.Forms.ToolStripButton tsbtnLast;
        protected System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        protected System.Windows.Forms.ToolStripButton tsbtnEdit;
        protected System.Windows.Forms.ToolStripButton tsbtnCancel;
        protected System.Windows.Forms.ToolStripButton tsbtnSave;
        protected System.Windows.Forms.ToolStripButton tsbtnPrint;
        private System.Windows.Forms.StatusStrip statusStrip1;
        protected DevExpress.XtraEditors.DateEdit dateDate;
        protected System.Windows.Forms.Label dateLabel;
        protected DevExpress.XtraEditors.SpinEdit curkurs;
        protected KASLibrary.TextBoxEx curcur;
        protected System.Windows.Forms.Label curLabel1;
        protected System.Windows.Forms.Label kursLabel;
        private System.Windows.Forms.ToolStripButton tsbtnJurnal;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.ToolStripButton tsbtnRefresh;
        protected DevExpress.XtraEditors.SimpleButton btnDocFlow;
        protected System.Windows.Forms.Label lblDeleted;
        protected System.Windows.Forms.ToolStripButton tsbtnBrowse;

    }
}
