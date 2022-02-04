namespace CAS.Transaction
{
    partial class FrmTRkl
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label remarkLabel;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label8;
            this.ctrlSub = new CAS.Transaction.CtrlSub();
            this.spinTOP = new DevExpress.XtraEditors.SpinEdit();
            this.casDataSet = new CAS.casDataSet();
            this.rklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remarkMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.rkdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.txtSubTotal = new DevExpress.XtraEditors.TextEdit();
            this.txtPPN = new DevExpress.XtraEditors.TextEdit();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.tabDetails = new DevExpress.XtraTab.XtraTabControl();
            this.tabSO = new DevExpress.XtraTab.XtraTabPage();
            this.gcxRll = new KASLibrary.GridControlEx();
            this.listRsm = new DevExpress.XtraEditors.ListBoxControl();
            this.btnDeleteRsm = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddRsm = new DevExpress.XtraEditors.SimpleButton();
            this.tabInvoice = new DevExpress.XtraTab.XtraTabPage();
            this.gcxRkd = new KASLibrary.GridControlEx();
            this.tabBarang = new DevExpress.XtraTab.XtraTabPage();
            this.gcxRkb = new KASLibrary.GridControlEx();
            this.rllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludSeri.Properties)).BeginInit();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curkurs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curcur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTOP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rklBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rkdBindingSource)).BeginInit();
            this.pnlTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPPN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabDetails)).BeginInit();
            this.tabDetails.SuspendLayout();
            this.tabSO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listRsm)).BeginInit();
            this.tabInvoice.SuspendLayout();
            this.tabBarang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rllBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNo
            // 
            this.txtNo.EditValueChanged += new System.EventHandler(this.txtNo_EditValueChanged);
            // 
            // txtPeriod
            // 
            // 
            // ludSeri
            // 
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.tabDetails);
            this.pnlDetail.Controls.Add(this.pnlTotal);
            this.pnlDetail.Controls.Add(remarkLabel);
            this.pnlDetail.Controls.Add(this.remarkMemoEdit);
            this.pnlDetail.Controls.Add(label3);
            this.pnlDetail.Controls.Add(label2);
            this.pnlDetail.Controls.Add(this.spinTOP);
            this.pnlDetail.Controls.Add(this.ctrlSub);
            this.pnlDetail.Size = new System.Drawing.Size(783, 542);
            this.pnlDetail.Controls.SetChildIndex(this.dateDate, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curcur, 0);
            this.pnlDetail.Controls.SetChildIndex(this.kursLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curLabel1, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curkurs, 0);
            this.pnlDetail.Controls.SetChildIndex(this.ctrlSub, 0);
            this.pnlDetail.Controls.SetChildIndex(this.spinTOP, 0);
            this.pnlDetail.Controls.SetChildIndex(label2, 0);
            this.pnlDetail.Controls.SetChildIndex(label3, 0);
            this.pnlDetail.Controls.SetChildIndex(this.remarkMemoEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(remarkLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.pnlTotal, 0);
            this.pnlDetail.Controls.SetChildIndex(this.tabDetails, 0);
            // 
            // pnlKey
            // 
            this.pnlKey.Size = new System.Drawing.Size(783, 50);
            // 
            // dateDate
            // 
            this.dateDate.EditValue = new System.DateTime(((long)(0)));
            this.dateDate.Location = new System.Drawing.Point(481, 12);
            this.dateDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateDate.Properties.Mask.IgnoreMaskBlank = false;
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(429, 15);
            // 
            // curkurs
            // 
            this.curkurs.Location = new System.Drawing.Point(580, 38);
            // 
            // curcur
            // 
            this.curcur.Location = new System.Drawing.Point(481, 38);
            this.curcur.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.curcur.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.curcur.Properties.Appearance.Options.UseBackColor = true;
            this.curcur.Properties.Appearance.Options.UseForeColor = true;
            // 
            // curLabel1
            // 
            this.curLabel1.Location = new System.Drawing.Point(450, 41);
            // 
            // kursLabel
            // 
            this.kursLabel.Location = new System.Drawing.Point(544, 41);
            // 
            // btnDocFlow
            // 
            this.btnDocFlow.Visible = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(555, 67);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(31, 13);
            label3.TabIndex = 39;
            label3.Text = "Days";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(444, 67);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(27, 13);
            label2.TabIndex = 38;
            label2.Text = "TOP";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(413, 91);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(63, 13);
            remarkLabel.TabIndex = 39;
            remarkLabel.Text = "Keterangan";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(13, 8);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(52, 13);
            label6.TabIndex = 111;
            label6.Text = "Sub Total";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(13, 58);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(31, 13);
            label9.TabIndex = 113;
            label9.Text = "Total";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(13, 33);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(26, 13);
            label8.TabIndex = 112;
            label8.Text = "PPN";
            // 
            // ctrlSub
            // 
            this.ctrlSub.Location = new System.Drawing.Point(32, 6);
            this.ctrlSub.Name = "ctrlSub";
            this.ctrlSub.ReadOnly = true;
            this.ctrlSub.Size = new System.Drawing.Size(335, 115);
            this.ctrlSub.TabIndex = 29;
            this.ctrlSub.Type = CAS.Transaction.CtrlSub.SubType.Customer;
            this.ctrlSub.Load += new System.EventHandler(this.ctrlSub_Load);
            // 
            // spinTOP
            // 
            this.spinTOP.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinTOP.Location = new System.Drawing.Point(481, 64);
            this.spinTOP.Name = "spinTOP";
            this.spinTOP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinTOP.Properties.UseCtrlIncrement = false;
            this.spinTOP.Size = new System.Drawing.Size(68, 20);
            this.spinTOP.TabIndex = 37;
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rklBindingSource
            // 
            this.rklBindingSource.DataMember = "rkl";
            this.rklBindingSource.DataSource = this.casDataSet;
            // 
            // remarkMemoEdit
            // 
            this.remarkMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rklBindingSource, "remark", true));
            this.remarkMemoEdit.Location = new System.Drawing.Point(481, 90);
            this.remarkMemoEdit.Name = "remarkMemoEdit";
            this.remarkMemoEdit.Size = new System.Drawing.Size(272, 45);
            this.remarkMemoEdit.TabIndex = 40;
            // 
            // rkdBindingSource
            // 
            this.rkdBindingSource.DataMember = "rkd";
            this.rkdBindingSource.DataSource = this.casDataSet;
            // 
            // pnlTotal
            // 
            this.pnlTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTotal.Controls.Add(label6);
            this.pnlTotal.Controls.Add(this.txtSubTotal);
            this.pnlTotal.Controls.Add(this.txtPPN);
            this.pnlTotal.Controls.Add(label9);
            this.pnlTotal.Controls.Add(this.txtTotal);
            this.pnlTotal.Controls.Add(label8);
            this.pnlTotal.Location = new System.Drawing.Point(558, 457);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(213, 79);
            this.pnlTotal.TabIndex = 118;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Location = new System.Drawing.Point(75, 4);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSubTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSubTotal.Size = new System.Drawing.Size(121, 20);
            this.txtSubTotal.TabIndex = 108;
            // 
            // txtPPN
            // 
            this.txtPPN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rklBindingSource, "ppn", true));
            this.txtPPN.Enabled = false;
            this.txtPPN.Location = new System.Drawing.Point(75, 29);
            this.txtPPN.Name = "txtPPN";
            this.txtPPN.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPPN.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtPPN.Size = new System.Drawing.Size(121, 20);
            this.txtPPN.TabIndex = 109;
            // 
            // txtTotal
            // 
            this.txtTotal.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rklBindingSource, "val", true));
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(75, 54);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotal.Size = new System.Drawing.Size(121, 20);
            this.txtTotal.TabIndex = 110;
            // 
            // tabDetails
            // 
            this.tabDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabDetails.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.True;
            this.tabDetails.Location = new System.Drawing.Point(12, 150);
            this.tabDetails.Name = "tabDetails";
            this.tabDetails.SelectedTabPage = this.tabSO;
            this.tabDetails.Size = new System.Drawing.Size(762, 292);
            this.tabDetails.TabIndex = 121;
            this.tabDetails.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabSO,
            this.tabInvoice,
            this.tabBarang});
            this.tabDetails.Text = "List PO";
            // 
            // tabSO
            // 
            this.tabSO.AutoScroll = true;
            this.tabSO.Controls.Add(this.gcxRll);
            this.tabSO.Controls.Add(this.listRsm);
            this.tabSO.Controls.Add(this.btnDeleteRsm);
            this.tabSO.Controls.Add(this.btnAddRsm);
            this.tabSO.Name = "tabSO";
            this.tabSO.Size = new System.Drawing.Size(754, 264);
            this.tabSO.Text = "List SO Retur";
            // 
            // gcxRll
            // 
            this.gcxRll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcxRll.BestFitColumn = true;
            this.gcxRll.ExAutoSize = false;
            this.gcxRll.Location = new System.Drawing.Point(173, 3);
            this.gcxRll.Name = "gcxRll";
            this.gcxRll.Size = new System.Drawing.Size(566, 247);
            this.gcxRll.TabIndex = 3;
            // 
            // listRsm
            // 
            this.listRsm.Location = new System.Drawing.Point(27, 26);
            this.listRsm.Name = "listRsm";
            this.listRsm.Size = new System.Drawing.Size(129, 163);
            this.listRsm.TabIndex = 2;
            this.listRsm.SelectedIndexChanged += new System.EventHandler(this.listRsm_SelectedIndexChanged);
            // 
            // btnDeleteRsm
            // 
            this.btnDeleteRsm.Location = new System.Drawing.Point(55, 195);
            this.btnDeleteRsm.Name = "btnDeleteRsm";
            this.btnDeleteRsm.Size = new System.Drawing.Size(22, 20);
            this.btnDeleteRsm.TabIndex = 1;
            this.btnDeleteRsm.Text = "—";
            this.btnDeleteRsm.Click += new System.EventHandler(this.btnDeleteRsm_Click);
            // 
            // btnAddRsm
            // 
            this.btnAddRsm.Location = new System.Drawing.Point(27, 195);
            this.btnAddRsm.Name = "btnAddRsm";
            this.btnAddRsm.Size = new System.Drawing.Size(22, 20);
            this.btnAddRsm.TabIndex = 1;
            this.btnAddRsm.Text = "+";
            this.btnAddRsm.Click += new System.EventHandler(this.btnAddRsm_Click);
            // 
            // tabInvoice
            // 
            this.tabInvoice.Controls.Add(this.gcxRkd);
            this.tabInvoice.Name = "tabInvoice";
            this.tabInvoice.Size = new System.Drawing.Size(754, 264);
            this.tabInvoice.Text = "Invoice";
            // 
            // gcxRkd
            // 
            this.gcxRkd.BestFitColumn = true;
            this.gcxRkd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcxRkd.ExAutoSize = false;
            this.gcxRkd.Location = new System.Drawing.Point(0, 0);
            this.gcxRkd.Name = "gcxRkd";
            this.gcxRkd.Size = new System.Drawing.Size(754, 264);
            this.gcxRkd.TabIndex = 83;
            // 
            // tabBarang
            // 
            this.tabBarang.Controls.Add(this.gcxRkb);
            this.tabBarang.Name = "tabBarang";
            this.tabBarang.Size = new System.Drawing.Size(754, 264);
            this.tabBarang.Text = "Penerimaan Barang";
            // 
            // gcxRkb
            // 
            this.gcxRkb.BestFitColumn = true;
            this.gcxRkb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcxRkb.ExAutoSize = false;
            this.gcxRkb.Location = new System.Drawing.Point(0, 0);
            this.gcxRkb.Name = "gcxRkb";
            this.gcxRkb.Size = new System.Drawing.Size(754, 264);
            this.gcxRkb.TabIndex = 0;
            // 
            // rllBindingSource
            // 
            this.rllBindingSource.DataMember = "rll";
            this.rllBindingSource.DataSource = this.casDataSet;
            // 
            // FrmTRkl
            // 
            this.ClientSize = new System.Drawing.Size(783, 672);
            this.DetailBindingSource = this.rkdBindingSource;
            this.DetailTable = this.casDataSet.rkd;
            this.MasterBindingSource = this.rklBindingSource;
            this.MasterTable = this.casDataSet.rkl;
            this.Name = "FrmTRkl";
            this.Load += new System.EventHandler(this.FrmTRkl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludSeri.Properties)).EndInit();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.pnlKey.ResumeLayout(false);
            this.pnlKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curkurs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curcur.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTOP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rklBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rkdBindingSource)).EndInit();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPPN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabDetails)).EndInit();
            this.tabDetails.ResumeLayout(false);
            this.tabSO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listRsm)).EndInit();
            this.tabInvoice.ResumeLayout(false);
            this.tabBarang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rllBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CtrlSub ctrlSub;
        private DevExpress.XtraEditors.SpinEdit spinTOP;
        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource rklBindingSource;
        private DevExpress.XtraEditors.MemoEdit remarkMemoEdit;
        private System.Windows.Forms.BindingSource rkdBindingSource;
        private System.Windows.Forms.Panel pnlTotal;
        private DevExpress.XtraEditors.TextEdit txtSubTotal;
        private DevExpress.XtraEditors.TextEdit txtPPN;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private DevExpress.XtraTab.XtraTabControl tabDetails;
        private DevExpress.XtraTab.XtraTabPage tabSO;
        private KASLibrary.GridControlEx gcxRll;
        private DevExpress.XtraEditors.ListBoxControl listRsm;
        private DevExpress.XtraEditors.SimpleButton btnDeleteRsm;
        private DevExpress.XtraEditors.SimpleButton btnAddRsm;
        private DevExpress.XtraTab.XtraTabPage tabInvoice;
        private KASLibrary.GridControlEx gcxRkd;
        private DevExpress.XtraTab.XtraTabPage tabBarang;
        private KASLibrary.GridControlEx gcxRkb;
        private System.Windows.Forms.BindingSource rllBindingSource;
    }
}
