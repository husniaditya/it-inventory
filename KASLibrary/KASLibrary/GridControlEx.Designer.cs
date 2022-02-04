namespace KASLibrary
{
    partial class GridControlEx
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridControlEx));
            this.lblTitle = new System.Windows.Forms.Label();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsbtnSelectAll = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiSelectNone = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSelectInverse = new System.Windows.Forms.ToolStripMenuItem();
            this.tslblRow = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiSaveExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveText = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveHTML = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnNew = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiCopyCell = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopyRow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnShow = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiShowFilterRow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowGroupHeader = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowColumnChooser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowAllColumns = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.savFile = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(406, 23);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "TITLE HERE";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.gridControl.EmbeddedNavigator.Name = "";
            this.gridControl.Location = new System.Drawing.Point(0, 48);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(406, 258);
            this.gridControl.TabIndex = 4;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnSelectAll,
            this.tslblRow});
            this.statusStrip1.Location = new System.Drawing.Point(0, 306);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(406, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsbtnSelectAll
            // 
            this.tsbtnSelectAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnSelectAll.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSelectNone,
            this.tsmiSelectInverse});
            this.tsbtnSelectAll.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSelectAll.Image")));
            this.tsbtnSelectAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSelectAll.Name = "tsbtnSelectAll";
            this.tsbtnSelectAll.Size = new System.Drawing.Size(71, 20);
            this.tsbtnSelectAll.Text = "Select &All";
            this.tsbtnSelectAll.ButtonClick += new System.EventHandler(this.tsbtnSelectAll_ButtonClick);
            // 
            // tsmiSelectNone
            // 
            this.tsmiSelectNone.Name = "tsmiSelectNone";
            this.tsmiSelectNone.Size = new System.Drawing.Size(145, 22);
            this.tsmiSelectNone.Text = "Select None";
            this.tsmiSelectNone.Click += new System.EventHandler(this.tsmiSelectNone_Click);
            // 
            // tsmiSelectInverse
            // 
            this.tsmiSelectInverse.Name = "tsmiSelectInverse";
            this.tsmiSelectInverse.Size = new System.Drawing.Size(145, 22);
            this.tsmiSelectInverse.Text = "Select Inverse";
            this.tsmiSelectInverse.Click += new System.EventHandler(this.tsmiSelectInverse_Click);
            // 
            // tslblRow
            // 
            this.tslblRow.BackColor = System.Drawing.Color.Transparent;
            this.tslblRow.Name = "tslblRow";
            this.tslblRow.Size = new System.Drawing.Size(320, 17);
            this.tslblRow.Spring = true;
            this.tslblRow.Text = "0 row(s) returned. 0 row(s) selected";
            this.tslblRow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.tsbtnNew,
            this.tsbtnDelete,
            this.copyToolStripButton,
            this.toolStripSeparator1,
            this.tsbtnShow,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 23);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(406, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSaveExcel,
            this.tsmiSaveText,
            this.tsmiSaveHTML});
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(89, 22);
            this.saveToolStripButton.Text = "&Export To";
            this.saveToolStripButton.ButtonClick += new System.EventHandler(this.saveToolStripButton_ButtonClick);
            // 
            // tsmiSaveExcel
            // 
            this.tsmiSaveExcel.Name = "tsmiSaveExcel";
            this.tsmiSaveExcel.Size = new System.Drawing.Size(107, 22);
            this.tsmiSaveExcel.Text = "Excel";
            this.tsmiSaveExcel.Click += new System.EventHandler(this.tsmiSaveExcel_Click);
            // 
            // tsmiSaveText
            // 
            this.tsmiSaveText.Name = "tsmiSaveText";
            this.tsmiSaveText.Size = new System.Drawing.Size(107, 22);
            this.tsmiSaveText.Text = "Text";
            this.tsmiSaveText.Click += new System.EventHandler(this.tsmiSaveText_Click);
            // 
            // tsmiSaveHTML
            // 
            this.tsmiSaveHTML.Name = "tsmiSaveHTML";
            this.tsmiSaveHTML.Size = new System.Drawing.Size(107, 22);
            this.tsmiSaveHTML.Text = "HTML";
            this.tsmiSaveHTML.Click += new System.EventHandler(this.tsmiSaveHTML_Click);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(52, 22);
            this.printToolStripButton.Text = "&Print";
            this.printToolStripButton.Click += new System.EventHandler(this.printToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnNew
            // 
            this.tsbtnNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnNew.Image")));
            this.tsbtnNew.Name = "tsbtnNew";
            this.tsbtnNew.RightToLeftAutoMirrorImage = true;
            this.tsbtnNew.Size = new System.Drawing.Size(51, 22);
            this.tsbtnNew.Text = "&New";
            // 
            // tsbtnDelete
            // 
            this.tsbtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDelete.Image")));
            this.tsbtnDelete.Name = "tsbtnDelete";
            this.tsbtnDelete.RightToLeftAutoMirrorImage = true;
            this.tsbtnDelete.Size = new System.Drawing.Size(60, 22);
            this.tsbtnDelete.Text = "&Delete";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCopyCell,
            this.tsmiCopyRow});
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(64, 22);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // tsmiCopyCell
            // 
            this.tsmiCopyCell.Name = "tsmiCopyCell";
            this.tsmiCopyCell.Size = new System.Drawing.Size(110, 22);
            this.tsmiCopyCell.Text = "Cell";
            this.tsmiCopyCell.Click += new System.EventHandler(this.tsmiCopyCell_Click);
            // 
            // tsmiCopyRow
            // 
            this.tsmiCopyRow.Name = "tsmiCopyRow";
            this.tsmiCopyRow.Size = new System.Drawing.Size(110, 22);
            this.tsmiCopyRow.Text = "Row(s)";
            this.tsmiCopyRow.Click += new System.EventHandler(this.tsmiCopyRow_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnShow
            // 
            this.tsbtnShow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnShow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowFilterRow,
            this.tsmiShowGroupHeader,
            this.tsmiShowColumnChooser,
            this.tsmiShowAllColumns});
            this.tsbtnShow.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnShow.Image")));
            this.tsbtnShow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnShow.Name = "tsbtnShow";
            this.tsbtnShow.Size = new System.Drawing.Size(49, 22);
            this.tsbtnShow.Text = "Show";
            // 
            // tsmiShowFilterRow
            // 
            this.tsmiShowFilterRow.CheckOnClick = true;
            this.tsmiShowFilterRow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmiShowFilterRow.Name = "tsmiShowFilterRow";
            this.tsmiShowFilterRow.Size = new System.Drawing.Size(164, 22);
            this.tsmiShowFilterRow.Text = "Filter Row";
            this.tsmiShowFilterRow.CheckedChanged += new System.EventHandler(this.tsmiShowFilterRow_CheckedChanged);
            // 
            // tsmiShowGroupHeader
            // 
            this.tsmiShowGroupHeader.CheckOnClick = true;
            this.tsmiShowGroupHeader.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmiShowGroupHeader.Name = "tsmiShowGroupHeader";
            this.tsmiShowGroupHeader.Size = new System.Drawing.Size(164, 22);
            this.tsmiShowGroupHeader.Text = "Group Header";
            this.tsmiShowGroupHeader.CheckedChanged += new System.EventHandler(this.tsmiShowGroupHeader_CheckedChanged);
            // 
            // tsmiShowColumnChooser
            // 
            this.tsmiShowColumnChooser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmiShowColumnChooser.Name = "tsmiShowColumnChooser";
            this.tsmiShowColumnChooser.Size = new System.Drawing.Size(164, 22);
            this.tsmiShowColumnChooser.Text = "Column Chooser";
            this.tsmiShowColumnChooser.Click += new System.EventHandler(this.tsmiShowColumnChooser_Click);
            // 
            // tsmiShowAllColumns
            // 
            this.tsmiShowAllColumns.CheckOnClick = true;
            this.tsmiShowAllColumns.Name = "tsmiShowAllColumns";
            this.tsmiShowAllColumns.Size = new System.Drawing.Size(164, 22);
            this.tsmiShowAllColumns.Text = "All Columns";
            this.tsmiShowAllColumns.CheckedChanged += new System.EventHandler(this.tsmiShowAllColumns_CheckedChanged);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(52, 20);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // savFile
            // 
            this.savFile.Title = "Save As";
            // 
            // GridControlEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.statusStrip1);
            this.Name = "GridControlEx";
            this.Size = new System.Drawing.Size(406, 328);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private DevExpress.XtraGrid.GridControl gridControl;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSplitButton tsbtnSelectAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectNone;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectInverse;
        private System.Windows.Forms.ToolStripStatusLabel tslblRow;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.SaveFileDialog savFile;
        private System.Windows.Forms.ToolStripButton tsbtnNew;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripDropDownButton tsbtnShow;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowFilterRow;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowGroupHeader;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowColumnChooser;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowAllColumns;
        private System.Windows.Forms.ToolStripDropDownButton copyToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopyCell;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopyRow;
        private System.Windows.Forms.ToolStripSplitButton saveToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveExcel;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveText;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveHTML;
    }
}
