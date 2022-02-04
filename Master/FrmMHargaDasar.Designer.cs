namespace CAS.Master
{
    partial class FrmMHargaDasar
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
            System.Windows.Forms.Label tglawalLabel;
            System.Windows.Forms.Label tglakhirLabel;
            System.Windows.Forms.Label aktifLabel;
            this.tglawalDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.hrgdasarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casDataSet = new CAS.casDataSet();
            this.tglakhirDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.gcDHarga = new KASLibrary.GridControlEx();
            this.aktifCheckBox = new System.Windows.Forms.CheckBox();
            this.hrgdasarTableAdapter = new CAS.casDataSetTableAdapters.hrgdasarTableAdapter();
            this.dhrgdasarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dhrgdasarTableAdapter = new CAS.casDataSetTableAdapters.dhrgdasarTableAdapter();
            this.btnProses = new DevExpress.XtraEditors.SimpleButton();
            tglawalLabel = new System.Windows.Forms.Label();
            tglakhirLabel = new System.Windows.Forms.Label();
            aktifLabel = new System.Windows.Forms.Label();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tglawalDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrgdasarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglakhirDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dhrgdasarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.tglawalDateEdit);
            this.pnlDetail.Controls.Add(this.tglakhirDateEdit);
            this.pnlDetail.Controls.Add(this.btnProses);
            this.pnlDetail.Controls.Add(aktifLabel);
            this.pnlDetail.Controls.Add(this.gcDHarga);
            this.pnlDetail.Controls.Add(this.aktifCheckBox);
            this.pnlDetail.Controls.Add(tglakhirLabel);
            this.pnlDetail.Controls.Add(tglawalLabel);
            this.pnlDetail.Location = new System.Drawing.Point(0, 45);
            this.pnlDetail.Size = new System.Drawing.Size(513, 379);
            // 
            // pnlKey
            // 
            this.pnlKey.Size = new System.Drawing.Size(513, 20);
            // 
            // pnlChInfo
            // 
            this.pnlChInfo.Location = new System.Drawing.Point(0, 424);
            this.pnlChInfo.Size = new System.Drawing.Size(513, 45);
            // 
            // tglawalLabel
            // 
            tglawalLabel.AutoSize = true;
            tglawalLabel.Location = new System.Drawing.Point(27, 14);
            tglawalLabel.Name = "tglawalLabel";
            tglawalLabel.Size = new System.Drawing.Size(47, 13);
            tglawalLabel.TabIndex = 0;
            tglawalLabel.Text = "Tgl Awal";
            // 
            // tglakhirLabel
            // 
            tglakhirLabel.AutoSize = true;
            tglakhirLabel.Location = new System.Drawing.Point(27, 41);
            tglakhirLabel.Name = "tglakhirLabel";
            tglakhirLabel.Size = new System.Drawing.Size(48, 13);
            tglakhirLabel.TabIndex = 2;
            tglakhirLabel.Text = "Tgl Akhir";
            // 
            // aktifLabel
            // 
            aktifLabel.AutoSize = true;
            aktifLabel.Location = new System.Drawing.Point(210, 14);
            aktifLabel.Name = "aktifLabel";
            aktifLabel.Size = new System.Drawing.Size(29, 13);
            aktifLabel.TabIndex = 4;
            aktifLabel.Text = "Aktif";
            // 
            // tglawalDateEdit
            // 
            this.tglawalDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hrgdasarBindingSource, "tglawal", true));
            this.tglawalDateEdit.EditValue = null;
            this.tglawalDateEdit.Location = new System.Drawing.Point(80, 11);
            this.tglawalDateEdit.Name = "tglawalDateEdit";
            this.tglawalDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tglawalDateEdit.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.tglawalDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.tglawalDateEdit.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.tglawalDateEdit.Size = new System.Drawing.Size(100, 23);
            this.tglawalDateEdit.TabIndex = 1;
            // 
            // hrgdasarBindingSource
            // 
            this.hrgdasarBindingSource.DataMember = "hrgdasar";
            this.hrgdasarBindingSource.DataSource = this.casDataSet;
            this.hrgdasarBindingSource.PositionChanged += new System.EventHandler(this.hrgdasarBindingSource_PositionChanged);
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tglakhirDateEdit
            // 
            this.tglakhirDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hrgdasarBindingSource, "tglakhir", true));
            this.tglakhirDateEdit.EditValue = null;
            this.tglakhirDateEdit.Location = new System.Drawing.Point(81, 37);
            this.tglakhirDateEdit.Name = "tglakhirDateEdit";
            this.tglakhirDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tglakhirDateEdit.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.tglakhirDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.tglakhirDateEdit.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.tglakhirDateEdit.Size = new System.Drawing.Size(100, 23);
            this.tglakhirDateEdit.TabIndex = 3;
            // 
            // gcDHarga
            // 
            this.gcDHarga.BestFitColumn = true;
            this.gcDHarga.ExAutoSize = false;
            this.gcDHarga.Location = new System.Drawing.Point(30, 66);
            this.gcDHarga.Name = "gcDHarga";
            this.gcDHarga.Size = new System.Drawing.Size(456, 255);
            this.gcDHarga.TabIndex = 3;
            // 
            // aktifCheckBox
            // 
            this.aktifCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.hrgdasarBindingSource, "aktif", true));
            this.aktifCheckBox.Location = new System.Drawing.Point(248, 9);
            this.aktifCheckBox.Name = "aktifCheckBox";
            this.aktifCheckBox.Size = new System.Drawing.Size(33, 24);
            this.aktifCheckBox.TabIndex = 5;
            // 
            // hrgdasarTableAdapter
            // 
            this.hrgdasarTableAdapter.ClearBeforeFill = true;
            // 
            // dhrgdasarBindingSource
            // 
            this.dhrgdasarBindingSource.DataMember = "dhrgdasar";
            this.dhrgdasarBindingSource.DataSource = this.casDataSet;
            // 
            // dhrgdasarTableAdapter
            // 
            this.dhrgdasarTableAdapter.ClearBeforeFill = true;
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(400, 336);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(86, 23);
            this.btnProses.TabIndex = 10;
            this.btnProses.Text = "Proses";
            this.btnProses.Visible = false;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // FrmMHargaDasar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(513, 491);
            this.MasterBindingSource = this.hrgdasarBindingSource;
            this.MasterQuery = "select * from hrgdasar";
            this.MasterTable = this.casDataSet.hrgdasar;
            this.Name = "FrmMHargaDasar";
            this.Load += new System.EventHandler(this.FrmMHargaDasar_Load);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tglawalDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrgdasarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglakhirDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dhrgdasarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource hrgdasarBindingSource;
        private CAS.casDataSetTableAdapters.hrgdasarTableAdapter hrgdasarTableAdapter;
        private DevExpress.XtraEditors.DateEdit tglakhirDateEdit;
        private DevExpress.XtraEditors.DateEdit tglawalDateEdit;
        private System.Windows.Forms.BindingSource dhrgdasarBindingSource;
        private CAS.casDataSetTableAdapters.dhrgdasarTableAdapter dhrgdasarTableAdapter;
        private KASLibrary.GridControlEx gcDHarga;
        private System.Windows.Forms.CheckBox aktifCheckBox;
        protected DevExpress.XtraEditors.SimpleButton btnProses;
    }
}
