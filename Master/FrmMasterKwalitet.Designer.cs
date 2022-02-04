namespace CAS.Master
{
    partial class FrmMasterKwalitet
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
            System.Windows.Forms.Label lapisLabel;
            System.Windows.Forms.Label groupLabel;
            System.Windows.Forms.Label kelompokLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.ludKode1 = new DevExpress.XtraEditors.LookUpEdit();
            this.casDataSet = new CAS.casDataSet();
            this.ukuranBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ukuranTableAdapter = new CAS.casDataSetTableAdapters.ukuranTableAdapter();
            this.ludKode2 = new DevExpress.XtraEditors.LookUpEdit();
            this.ludKode3 = new DevExpress.XtraEditors.LookUpEdit();
            this.ludKode4 = new DevExpress.XtraEditors.LookUpEdit();
            this.ludKode5 = new DevExpress.XtraEditors.LookUpEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kwalitetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kwalitetTableAdapter = new CAS.casDataSetTableAdapters.kwalitetTableAdapter();
            this.lapisTextBoxEx = new KASLibrary.TextBoxEx();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBerat = new DevExpress.XtraEditors.TextEdit();
            this.groupCheckBox = new System.Windows.Forms.CheckBox();
            this.kelompokTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.btnProses = new DevExpress.XtraEditors.SimpleButton();
            lapisLabel = new System.Windows.Forms.Label();
            groupLabel = new System.Windows.Forms.Label();
            kelompokLabel = new System.Windows.Forms.Label();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ludKode1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ukuranBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludKode2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludKode3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludKode4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludKode5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kwalitetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lapisTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBerat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelompokTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.btnProses);
            this.pnlDetail.Controls.Add(this.label3);
            this.pnlDetail.Controls.Add(kelompokLabel);
            this.pnlDetail.Controls.Add(this.label2);
            this.pnlDetail.Controls.Add(this.kelompokTextEdit);
            this.pnlDetail.Controls.Add(this.ludKode5);
            this.pnlDetail.Controls.Add(groupLabel);
            this.pnlDetail.Controls.Add(this.ludKode4);
            this.pnlDetail.Controls.Add(this.groupCheckBox);
            this.pnlDetail.Controls.Add(this.ludKode3);
            this.pnlDetail.Controls.Add(this.txtBerat);
            this.pnlDetail.Controls.Add(this.ludKode2);
            this.pnlDetail.Controls.Add(this.ludKode1);
            this.pnlDetail.Controls.Add(this.label4);
            this.pnlDetail.Controls.Add(this.label1);
            this.pnlDetail.Controls.Add(lapisLabel);
            this.pnlDetail.Controls.Add(this.lapisTextBoxEx);
            this.pnlDetail.Location = new System.Drawing.Point(0, 35);
            this.pnlDetail.Size = new System.Drawing.Size(525, 167);
            // 
            // pnlKey
            // 
            this.pnlKey.Size = new System.Drawing.Size(525, 10);
            // 
            // lapisLabel
            // 
            lapisLabel.AutoSize = true;
            lapisLabel.Location = new System.Drawing.Point(27, 44);
            lapisLabel.Name = "lapisLabel";
            lapisLabel.Size = new System.Drawing.Size(44, 13);
            lapisLabel.TabIndex = 0;
            lapisLabel.Text = "SW/DW";
            // 
            // groupLabel
            // 
            groupLabel.AutoSize = true;
            groupLabel.Location = new System.Drawing.Point(39, 98);
            groupLabel.Name = "groupLabel";
            groupLabel.Size = new System.Drawing.Size(36, 13);
            groupLabel.TabIndex = 4;
            groupLabel.Text = "Group";
            // 
            // kelompokLabel
            // 
            kelompokLabel.AutoSize = true;
            kelompokLabel.Location = new System.Drawing.Point(21, 126);
            kelompokLabel.Name = "kelompokLabel";
            kelompokLabel.Size = new System.Drawing.Size(52, 13);
            kelompokLabel.TabIndex = 6;
            kelompokLabel.Text = "Kelompok";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kwalitet";
            // 
            // ludKode1
            // 
            this.ludKode1.Location = new System.Drawing.Point(82, 15);
            this.ludKode1.Name = "ludKode1";
            this.ludKode1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ludKode1.Properties.NullText = " ";
            this.ludKode1.Size = new System.Drawing.Size(60, 20);
            this.ludKode1.TabIndex = 6;
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ukuranBindingSource
            // 
            this.ukuranBindingSource.DataMember = "ukuran";
            this.ukuranBindingSource.DataSource = this.casDataSet;
            // 
            // ukuranTableAdapter
            // 
            this.ukuranTableAdapter.ClearBeforeFill = true;
            // 
            // ludKode2
            // 
            this.ludKode2.Location = new System.Drawing.Point(159, 15);
            this.ludKode2.Name = "ludKode2";
            this.ludKode2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ludKode2.Properties.NullText = " ";
            this.ludKode2.Size = new System.Drawing.Size(60, 20);
            this.ludKode2.TabIndex = 7;
            // 
            // ludKode3
            // 
            this.ludKode3.Location = new System.Drawing.Point(225, 15);
            this.ludKode3.Name = "ludKode3";
            this.ludKode3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ludKode3.Properties.NullText = " ";
            this.ludKode3.Size = new System.Drawing.Size(60, 20);
            this.ludKode3.TabIndex = 8;
            // 
            // ludKode4
            // 
            this.ludKode4.Location = new System.Drawing.Point(291, 15);
            this.ludKode4.Name = "ludKode4";
            this.ludKode4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ludKode4.Properties.NullText = " ";
            this.ludKode4.Size = new System.Drawing.Size(60, 20);
            this.ludKode4.TabIndex = 9;
            // 
            // ludKode5
            // 
            this.ludKode5.Location = new System.Drawing.Point(368, 15);
            this.ludKode5.Name = "ludKode5";
            this.ludKode5.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ludKode5.Properties.NullText = " ";
            this.ludKode5.Size = new System.Drawing.Size(60, 20);
            this.ludKode5.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(353, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "/";
            // 
            // kwalitetBindingSource
            // 
            this.kwalitetBindingSource.DataMember = "kwalitet";
            this.kwalitetBindingSource.DataSource = this.casDataSet;
            this.kwalitetBindingSource.PositionChanged += new System.EventHandler(this.kwalitetBindingSource_PositionChanged);
            // 
            // kwalitetTableAdapter
            // 
            this.kwalitetTableAdapter.ClearBeforeFill = true;
            // 
            // lapisTextBoxEx
            // 
            this.lapisTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kwalitetBindingSource, "lapis", true));
            this.lapisTextBoxEx.ExAllowEmptyString = true;
            this.lapisTextBoxEx.ExAllowNonDBData = false;
            this.lapisTextBoxEx.ExAutoCheck = true;
            this.lapisTextBoxEx.ExAutoShowResult = false;
            this.lapisTextBoxEx.ExCondition = "";
            this.lapisTextBoxEx.ExDialogTitle = "Rumus";
            this.lapisTextBoxEx.ExFieldName = "kode";
            this.lapisTextBoxEx.ExFilterFields = new string[0];
            this.lapisTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.lapisTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.lapisTextBoxEx.ExLabelContainer = null;
            this.lapisTextBoxEx.ExLabelField = "ket";
            this.lapisTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.lapisTextBoxEx.ExLabelVisible = false;
            this.lapisTextBoxEx.ExSelectFields = new string[0];
            this.lapisTextBoxEx.ExShowDialog = true;
            this.lapisTextBoxEx.ExSimpleMode = true;
            this.lapisTextBoxEx.ExSqlInstance = null;
            this.lapisTextBoxEx.ExSqlQuery = "";
            this.lapisTextBoxEx.ExTableName = "rumus";
            this.lapisTextBoxEx.Location = new System.Drawing.Point(82, 41);
            this.lapisTextBoxEx.Name = "lapisTextBoxEx";
            this.lapisTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.lapisTextBoxEx.Size = new System.Drawing.Size(100, 20);
            this.lapisTextBoxEx.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Berat";
            // 
            // txtBerat
            // 
            this.txtBerat.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kwalitetBindingSource, "berat", true));
            this.txtBerat.Location = new System.Drawing.Point(82, 67);
            this.txtBerat.Name = "txtBerat";
            this.txtBerat.Properties.Appearance.Options.UseTextOptions = true;
            this.txtBerat.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtBerat.Size = new System.Drawing.Size(100, 20);
            this.txtBerat.TabIndex = 3;
            // 
            // groupCheckBox
            // 
            this.groupCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.kwalitetBindingSource, "group", true));
            this.groupCheckBox.Location = new System.Drawing.Point(82, 93);
            this.groupCheckBox.Name = "groupCheckBox";
            this.groupCheckBox.Size = new System.Drawing.Size(30, 24);
            this.groupCheckBox.TabIndex = 5;
            // 
            // kelompokTextEdit
            // 
            this.kelompokTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kwalitetBindingSource, "kelompok", true));
            this.kelompokTextEdit.Location = new System.Drawing.Point(82, 123);
            this.kelompokTextEdit.Name = "kelompokTextEdit";
            this.kelompokTextEdit.Size = new System.Drawing.Size(100, 20);
            this.kelompokTextEdit.TabIndex = 7;
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(188, 67);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(51, 23);
            this.btnProses.TabIndex = 12;
            this.btnProses.Text = "Proses";
            this.btnProses.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FrmMasterKwalitet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(525, 269);
            this.MasterBindingSource = this.kwalitetBindingSource;
            this.MasterQuery = "select * from kwalitet";
            this.MasterTable = this.casDataSet.kwalitet;
            this.Name = "FrmMasterKwalitet";
            this.Text = "Master Kwalitet";
            this.Load += new System.EventHandler(this.FrmMasterKwalitet_Load);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ludKode1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ukuranBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludKode2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludKode3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludKode4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludKode5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kwalitetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lapisTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBerat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelompokTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        protected DevExpress.XtraEditors.LookUpEdit ludKode1;
        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource ukuranBindingSource;
        private CAS.casDataSetTableAdapters.ukuranTableAdapter ukuranTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        protected DevExpress.XtraEditors.LookUpEdit ludKode5;
        protected DevExpress.XtraEditors.LookUpEdit ludKode4;
        protected DevExpress.XtraEditors.LookUpEdit ludKode3;
        protected DevExpress.XtraEditors.LookUpEdit ludKode2;
        private System.Windows.Forms.BindingSource kwalitetBindingSource;
        private CAS.casDataSetTableAdapters.kwalitetTableAdapter kwalitetTableAdapter;
        private KASLibrary.TextBoxEx lapisTextBoxEx;
        private DevExpress.XtraEditors.TextEdit txtBerat;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit kelompokTextEdit;
        private System.Windows.Forms.CheckBox groupCheckBox;
        private DevExpress.XtraEditors.SimpleButton btnProses;
    }
}
