namespace CAS.Laporan
{
    partial class FrmMPerkiraan
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
            System.Windows.Forms.Label level_Label;
            this.casDataSet = new CAS.casDataSet();
            this.accBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accTableAdapter = new CAS.casDataSetTableAdapters.accTableAdapter();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.level_SpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            level_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level_SpinEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(2654, 87);
            this.btnClose.LookAndFeel.SkinName = "";
            this.btnClose.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.LookAndFeel.UseWindowsXPTheme = false;
            this.btnClose.Text = "";
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPreview.Location = new System.Drawing.Point(86, 111);
            this.btnPreview.LookAndFeel.SkinName = "";
            this.btnPreview.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btnPreview.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnPreview.LookAndFeel.UseWindowsXPTheme = false;
            this.btnPreview.Size = new System.Drawing.Size(84, 23);
            this.btnPreview.Text = "Preview";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // printControl
            // 
            this.printControl.Location = new System.Drawing.Point(0, 0);
            this.printControl.Size = new System.Drawing.Size(844, 542);
            this.printControl.Text = "";
            // 
            // printPreviewBar
            // 
            this.printPreviewBar.Location = new System.Drawing.Point(0, 139);
            this.printPreviewBar.Size = new System.Drawing.Size(844, 28);
            // 
            // printPreviewStatus
            // 
            this.printPreviewStatus.Size = new System.Drawing.Size(844, 22);
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.button1);
            this.pnlFilter.Controls.Add(this.checkBox2);
            this.pnlFilter.Controls.Add(level_Label);
            this.pnlFilter.Controls.Add(this.level_SpinEdit);
            this.pnlFilter.Controls.Add(this.checkBox1);
            this.pnlFilter.LookAndFeel.SkinName = "";
            this.pnlFilter.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.pnlFilter.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlFilter.LookAndFeel.UseWindowsXPTheme = false;
            this.pnlFilter.Size = new System.Drawing.Size(844, 139);
            this.pnlFilter.Text = "";
            this.pnlFilter.Controls.SetChildIndex(this.btnClose, 0);
            this.pnlFilter.Controls.SetChildIndex(this.btnPreview, 0);
            this.pnlFilter.Controls.SetChildIndex(this.checkBox1, 0);
            this.pnlFilter.Controls.SetChildIndex(this.level_SpinEdit, 0);
            this.pnlFilter.Controls.SetChildIndex(level_Label, 0);
            this.pnlFilter.Controls.SetChildIndex(this.checkBox2, 0);
            this.pnlFilter.Controls.SetChildIndex(this.button1, 0);
            // 
            // level_Label
            // 
            level_Label.AutoSize = true;
            level_Label.Location = new System.Drawing.Point(32, 43);
            level_Label.Name = "level_Label";
            level_Label.Size = new System.Drawing.Size(32, 13);
            level_Label.TabIndex = 3;
            level_Label.Text = "Level";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accBindingSource
            // 
            this.accBindingSource.DataMember = "acc";
            this.accBindingSource.DataSource = this.casDataSet;
            // 
            // accTableAdapter
            // 
            this.accTableAdapter.ClearBeforeFill = true;
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2,
            this.treeListColumn3});
            this.treeList1.DataSource = this.accBindingSource;
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.KeyFieldName = "acc";
            this.treeList1.Location = new System.Drawing.Point(0, 167);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsView.EnableAppearanceEvenRow = true;
            this.treeList1.OptionsView.EnableAppearanceOddRow = true;
            this.treeList1.OptionsView.ShowIndentAsRowStyle = true;
            this.treeList1.OptionsView.ShowPreview = true;
            this.treeList1.OptionsView.ShowVertLines = false;
            this.treeList1.ParentFieldName = "parent";
            this.treeList1.Size = new System.Drawing.Size(844, 353);
            this.treeList1.TabIndex = 8;
            this.treeList1.NodeCellStyle += new DevExpress.XtraTreeList.GetCustomNodeCellStyleEventHandler(this.treeList1_NodeCellStyle);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Kode Account";
            this.treeListColumn1.FieldName = "acc";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 220;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Nama Account";
            this.treeListColumn2.FieldName = "name";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.VisibleIndex = 1;
            this.treeListColumn2.Width = 468;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "Level";
            this.treeListColumn3.FieldName = "level_";
            this.treeListColumn3.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.VisibleIndex = 2;
            this.treeListColumn3.Width = 135;
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.Caption = "Detil";
            this.treeListColumn4.FieldName = "detil";
            this.treeListColumn4.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.treeListColumn4.Name = "treeListColumn4";
            this.treeListColumn4.VisibleIndex = 3;
            this.treeListColumn4.Width = 84;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(35, 87);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Expand All";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // level_SpinEdit
            // 
            this.level_SpinEdit.EditValue = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.level_SpinEdit.Location = new System.Drawing.Point(74, 40);
            this.level_SpinEdit.Name = "level_SpinEdit";
            this.level_SpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.level_SpinEdit.Properties.UseCtrlIncrement = false;
            this.level_SpinEdit.Size = new System.Drawing.Size(71, 20);
            this.level_SpinEdit.TabIndex = 4;
            this.level_SpinEdit.EditValueChanged += new System.EventHandler(this.level_SpinEdit_EditValueChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(151, 87);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(51, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Color";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Send Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMPerkiraan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(844, 542);
            this.Controls.Add(this.treeList1);
            this.LookAndFeel.SkinName = "";
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.UseWindowsXPTheme = false;
            this.Name = "FrmMPerkiraan";
            this.Text = "";
            this.Load += new System.EventHandler(this.FrmMPerkiraan_Load);
            this.Controls.SetChildIndex(this.printControl, 0);
            this.Controls.SetChildIndex(this.pnlFilter, 0);
            this.Controls.SetChildIndex(this.printPreviewStatus, 0);
            this.Controls.SetChildIndex(this.printPreviewBar, 0);
            this.Controls.SetChildIndex(this.treeList1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level_SpinEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource accBindingSource;
        private CAS.casDataSetTableAdapters.accTableAdapter accTableAdapter;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private System.Windows.Forms.CheckBox checkBox1;
        private DevExpress.XtraEditors.SpinEdit level_SpinEdit;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button1;
    }
}
