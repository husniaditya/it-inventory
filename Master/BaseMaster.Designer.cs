namespace CAS.Master
{
    partial class BaseMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseMaster));
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
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnHelp = new System.Windows.Forms.ToolStripButton();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.pnlChInfo = new System.Windows.Forms.Panel();
            this.txtChUser = new DevExpress.XtraEditors.TextEdit();
            this.txtChTime = new DevExpress.XtraEditors.TextEdit();
            this.pnlKey = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslblRecord = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.MasterNavigator)).BeginInit();
            this.MasterNavigator.SuspendLayout();
            this.pnlChInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtChUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChTime.Properties)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.MasterNavigator.Size = new System.Drawing.Size(597, 25);
            this.MasterNavigator.TabIndex = 0;
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
            this.tsbtnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnRefresh.Image")));
            this.tsbtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRefresh.Name = "tsbtnRefresh";
            this.tsbtnRefresh.Size = new System.Drawing.Size(23, 22);
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
            this.tsbtnPrint.Click += new System.EventHandler(this.tsbtnPrint_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
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
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 20);
            this.pasteToolStripButton.Text = "&Paste";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnHelp
            // 
            this.tsbtnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnHelp.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnHelp.Image")));
            this.tsbtnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnHelp.Name = "tsbtnHelp";
            this.tsbtnHelp.Size = new System.Drawing.Size(23, 20);
            this.tsbtnHelp.Text = "He&lp";
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(272, 16);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(29, 13);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "User";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(440, 16);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(29, 13);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time";
            // 
            // pnlDetail
            // 
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetail.Location = new System.Drawing.Point(0, 81);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(597, 317);
            this.pnlDetail.TabIndex = 5;
            // 
            // pnlChInfo
            // 
            this.pnlChInfo.Controls.Add(this.txtChUser);
            this.pnlChInfo.Controls.Add(this.txtChTime);
            this.pnlChInfo.Controls.Add(this.lblUser);
            this.pnlChInfo.Controls.Add(this.lblTime);
            this.pnlChInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlChInfo.Location = new System.Drawing.Point(0, 398);
            this.pnlChInfo.Name = "pnlChInfo";
            this.pnlChInfo.Size = new System.Drawing.Size(597, 45);
            this.pnlChInfo.TabIndex = 6;
            // 
            // txtChUser
            // 
            this.txtChUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChUser.Location = new System.Drawing.Point(307, 13);
            this.txtChUser.Name = "txtChUser";
            this.txtChUser.Size = new System.Drawing.Size(100, 20);
            this.txtChUser.TabIndex = 6;
            // 
            // txtChTime
            // 
            this.txtChTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChTime.Location = new System.Drawing.Point(476, 13);
            this.txtChTime.Name = "txtChTime";
            this.txtChTime.Size = new System.Drawing.Size(100, 20);
            this.txtChTime.TabIndex = 5;
            // 
            // pnlKey
            // 
            this.pnlKey.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKey.Location = new System.Drawing.Point(0, 25);
            this.pnlKey.Name = "pnlKey";
            this.pnlKey.Size = new System.Drawing.Size(597, 56);
            this.pnlKey.TabIndex = 7;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblRecord});
            this.statusStrip1.Location = new System.Drawing.Point(0, 443);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(597, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslblRecord
            // 
            this.tslblRecord.Name = "tslblRecord";
            this.tslblRecord.Size = new System.Drawing.Size(76, 17);
            this.tslblRecord.Text = "Record 1 of 1";
            // 
            // BaseMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 465);
            this.Controls.Add(this.pnlDetail);
            this.Controls.Add(this.pnlKey);
            this.Controls.Add(this.pnlChInfo);
            this.Controls.Add(this.MasterNavigator);
            this.Controls.Add(this.statusStrip1);
            this.Name = "BaseMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BaseMaster";
            this.Load += new System.EventHandler(this.BaseMaster_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BaseMaster_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.MasterNavigator)).EndInit();
            this.MasterNavigator.ResumeLayout(false);
            this.MasterNavigator.PerformLayout();
            this.pnlChInfo.ResumeLayout(false);
            this.pnlChInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtChUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChTime.Properties)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.BindingNavigator MasterNavigator;
        protected System.Windows.Forms.ToolStripButton tsbtnNew;
        protected System.Windows.Forms.ToolStripButton tsbtnDelete;
        protected System.Windows.Forms.ToolStripButton tsbtnFirst;
        protected System.Windows.Forms.ToolStripButton tsbtnPrev;
        protected System.Windows.Forms.ToolStripButton tsbtnNext;
        protected System.Windows.Forms.ToolStripButton tsbtnLast;
        protected System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        protected System.Windows.Forms.ToolStripButton tsbtnEdit;
        protected System.Windows.Forms.ToolStripButton tsbtnSave;
        protected System.Windows.Forms.ToolStripButton tsbtnPrint;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        protected System.Windows.Forms.ToolStripButton cutToolStripButton;
        protected System.Windows.Forms.ToolStripButton copyToolStripButton;
        protected System.Windows.Forms.ToolStripButton pasteToolStripButton;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        protected System.Windows.Forms.ToolStripButton tsbtnHelp;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblTime;
        protected System.Windows.Forms.Panel pnlDetail;
        protected System.Windows.Forms.Panel pnlKey;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslblRecord;
        private System.Windows.Forms.ToolStripButton tsbtnBrowse;
        protected System.Windows.Forms.ToolStripButton tsbtnCancel;
        private DevExpress.XtraEditors.TextEdit txtChUser;
        private DevExpress.XtraEditors.TextEdit txtChTime;
        protected System.Windows.Forms.ToolStripButton tsbtnRefresh;
        protected System.Windows.Forms.Panel pnlChInfo;
    }
}