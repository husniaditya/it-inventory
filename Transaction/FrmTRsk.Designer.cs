namespace CAS.Transaction
{
    partial class FrmTRsk
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
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label duedateLabel;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label tglfpLabel;
            System.Windows.Forms.Label tglsfpLabel;
            System.Windows.Forms.Label nofpLabel;
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.txtSubTotal = new DevExpress.XtraEditors.TextEdit();
            this.txtPPN = new DevExpress.XtraEditors.TextEdit();
            this.rskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casDataSet = new CAS.casDataSet();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.ctrlSub = new CAS.Transaction.CtrlSub();
            this.spinTOP = new DevExpress.XtraEditors.SpinEdit();
            this.tabDetails = new DevExpress.XtraTab.XtraTabControl();
            this.tabPO = new DevExpress.XtraTab.XtraTabPage();
            this.gcxRsl = new KASLibrary.GridControlEx();
            this.listRms = new DevExpress.XtraEditors.ListBoxControl();
            this.btnDeleteRms = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddRms = new DevExpress.XtraEditors.SimpleButton();
            this.tabInvoice = new DevExpress.XtraTab.XtraTabPage();
            this.gcxRsd = new KASLibrary.GridControlEx();
            this.tabBarang = new DevExpress.XtraTab.XtraTabPage();
            this.gcxSjrd = new KASLibrary.GridControlEx();
            this.remarkMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.rsdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rslBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rskTableAdapter = new CAS.casDataSetTableAdapters.rskTableAdapter();
            this.tglfpDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.tglsfpDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.nofpTextEdit = new DevExpress.XtraEditors.TextEdit();
            label6 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            duedateLabel = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            tglfpLabel = new System.Windows.Forms.Label();
            tglsfpLabel = new System.Windows.Forms.Label();
            nofpLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludSeri.Properties)).BeginInit();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curkurs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curcur.Properties)).BeginInit();
            this.pnlTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPPN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTOP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabDetails)).BeginInit();
            this.tabDetails.SuspendLayout();
            this.tabPO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listRms)).BeginInit();
            this.tabInvoice.SuspendLayout();
            this.tabBarang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rslBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglfpDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglsfpDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nofpTextEdit.Properties)).BeginInit();
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
            this.pnlDetail.Controls.Add(nofpLabel);
            this.pnlDetail.Controls.Add(this.nofpTextEdit);
            this.pnlDetail.Controls.Add(tglsfpLabel);
            this.pnlDetail.Controls.Add(this.tglsfpDateEdit);
            this.pnlDetail.Controls.Add(tglfpLabel);
            this.pnlDetail.Controls.Add(this.tglfpDateEdit);
            this.pnlDetail.Controls.Add(label11);
            this.pnlDetail.Controls.Add(this.pnlTotal);
            this.pnlDetail.Controls.Add(this.ctrlSub);
            this.pnlDetail.Controls.Add(this.spinTOP);
            this.pnlDetail.Controls.Add(this.remarkMemoEdit);
            this.pnlDetail.Controls.Add(duedateLabel);
            this.pnlDetail.Controls.Add(label2);
            this.pnlDetail.Size = new System.Drawing.Size(775, 612);
            this.pnlDetail.Controls.SetChildIndex(label2, 0);
            this.pnlDetail.Controls.SetChildIndex(duedateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.remarkMemoEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(this.spinTOP, 0);
            this.pnlDetail.Controls.SetChildIndex(this.ctrlSub, 0);
            this.pnlDetail.Controls.SetChildIndex(this.pnlTotal, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curkurs, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateDate, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curcur, 0);
            this.pnlDetail.Controls.SetChildIndex(this.kursLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curLabel1, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(label11, 0);
            this.pnlDetail.Controls.SetChildIndex(this.tglfpDateEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(tglfpLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.tglsfpDateEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(tglsfpLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.nofpTextEdit, 0);
            this.pnlDetail.Controls.SetChildIndex(nofpLabel, 0);
            // 
            // pnlKey
            // 
            this.pnlKey.Size = new System.Drawing.Size(775, 50);
            // 
            // dateDate
            // 
            this.dateDate.EditValue = new System.DateTime(((long)(0)));
            this.dateDate.Location = new System.Drawing.Point(474, 13);
            this.dateDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateDate.Properties.Mask.IgnoreMaskBlank = false;
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(422, 16);
            // 
            // curkurs
            // 
            this.curkurs.Location = new System.Drawing.Point(601, 39);
            this.curkurs.Visible = false;
            // 
            // curcur
            // 
            this.curcur.Location = new System.Drawing.Point(474, 39);
            this.curcur.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.curcur.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.curcur.Properties.Appearance.Options.UseBackColor = true;
            this.curcur.Properties.Appearance.Options.UseForeColor = true;
            // 
            // curLabel1
            // 
            this.curLabel1.Location = new System.Drawing.Point(443, 42);
            // 
            // kursLabel
            // 
            this.kursLabel.Location = new System.Drawing.Point(565, 42);
            this.kursLabel.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(10, 7);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(52, 13);
            label6.TabIndex = 92;
            label6.Text = "Sub Total";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(10, 33);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(26, 13);
            label8.TabIndex = 94;
            label8.Text = "PPN";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(10, 59);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(31, 13);
            label9.TabIndex = 95;
            label9.Text = "Total";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(406, 91);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(63, 13);
            label2.TabIndex = 118;
            label2.Text = "Keterangan";
            // 
            // duedateLabel
            // 
            duedateLabel.AutoSize = true;
            duedateLabel.Location = new System.Drawing.Point(442, 66);
            duedateLabel.Name = "duedateLabel";
            duedateLabel.Size = new System.Drawing.Size(27, 13);
            duedateLabel.TabIndex = 117;
            duedateLabel.Text = "TOP";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(536, 66);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(31, 13);
            label11.TabIndex = 124;
            label11.Text = "Days";
            // 
            // tglfpLabel
            // 
            tglfpLabel.AutoSize = true;
            tglfpLabel.Location = new System.Drawing.Point(43, 166);
            tglfpLabel.Name = "tglfpLabel";
            tglfpLabel.Size = new System.Drawing.Size(36, 13);
            tglfpLabel.TabIndex = 124;
            tglfpLabel.Text = "Tgl FP";
            // 
            // tglsfpLabel
            // 
            tglsfpLabel.AutoSize = true;
            tglsfpLabel.Location = new System.Drawing.Point(204, 166);
            tglsfpLabel.Name = "tglsfpLabel";
            tglsfpLabel.Size = new System.Drawing.Size(65, 13);
            tglsfpLabel.TabIndex = 125;
            tglsfpLabel.Text = "Tgl Setor FP";
            // 
            // nofpLabel
            // 
            nofpLabel.AutoSize = true;
            nofpLabel.Location = new System.Drawing.Point(14, 140);
            nofpLabel.Name = "nofpLabel";
            nofpLabel.Size = new System.Drawing.Size(65, 13);
            nofpLabel.TabIndex = 126;
            nofpLabel.Text = "No Retur FP";
            // 
            // pnlTotal
            // 
            this.pnlTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTotal.Controls.Add(this.txtSubTotal);
            this.pnlTotal.Controls.Add(this.txtPPN);
            this.pnlTotal.Controls.Add(label6);
            this.pnlTotal.Controls.Add(this.txtTotal);
            this.pnlTotal.Controls.Add(label8);
            this.pnlTotal.Controls.Add(label9);
            this.pnlTotal.Location = new System.Drawing.Point(544, 528);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(200, 78);
            this.pnlTotal.TabIndex = 123;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Location = new System.Drawing.Point(76, 3);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSubTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSubTotal.Size = new System.Drawing.Size(121, 20);
            this.txtSubTotal.TabIndex = 88;
            // 
            // txtPPN
            // 
            this.txtPPN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rskBindingSource, "ppn", true));
            this.txtPPN.Enabled = false;
            this.txtPPN.Location = new System.Drawing.Point(76, 29);
            this.txtPPN.Name = "txtPPN";
            this.txtPPN.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPPN.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtPPN.Size = new System.Drawing.Size(121, 20);
            this.txtPPN.TabIndex = 114;
            // 
            // rskBindingSource
            // 
            this.rskBindingSource.DataMember = "rsk";
            this.rskBindingSource.DataSource = this.casDataSet;
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTotal
            // 
            this.txtTotal.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rskBindingSource, "val", true));
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(76, 55);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotal.Size = new System.Drawing.Size(121, 20);
            this.txtTotal.TabIndex = 113;
            // 
            // ctrlSub
            // 
            this.ctrlSub.Location = new System.Drawing.Point(21, 15);
            this.ctrlSub.Name = "ctrlSub";
            this.ctrlSub.ReadOnly = true;
            this.ctrlSub.Size = new System.Drawing.Size(335, 115);
            this.ctrlSub.TabIndex = 122;
            this.ctrlSub.Type = CAS.Transaction.CtrlSub.SubType.Supplier;
            // 
            // spinTOP
            // 
            this.spinTOP.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinTOP.Location = new System.Drawing.Point(474, 63);
            this.spinTOP.Name = "spinTOP";
            this.spinTOP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinTOP.Properties.UseCtrlIncrement = false;
            this.spinTOP.Size = new System.Drawing.Size(56, 20);
            this.spinTOP.TabIndex = 121;
            // 
            // tabDetails
            // 
            this.tabDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabDetails.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.True;
            this.tabDetails.Location = new System.Drawing.Point(12, 273);
            this.tabDetails.Name = "tabDetails";
            this.tabDetails.SelectedTabPage = this.tabPO;
            this.tabDetails.Size = new System.Drawing.Size(751, 315);
            this.tabDetails.TabIndex = 120;
            this.tabDetails.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPO,
            this.tabInvoice,
            this.tabBarang});
            this.tabDetails.Text = "List PO";
            // 
            // tabPO
            // 
            this.tabPO.AutoScroll = true;
            this.tabPO.Controls.Add(this.gcxRsl);
            this.tabPO.Controls.Add(this.listRms);
            this.tabPO.Controls.Add(this.btnDeleteRms);
            this.tabPO.Controls.Add(this.btnAddRms);
            this.tabPO.Name = "tabPO";
            this.tabPO.Size = new System.Drawing.Size(743, 287);
            this.tabPO.Text = "List PO Retur";
            // 
            // gcxRsl
            // 
            this.gcxRsl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcxRsl.BestFitColumn = true;
            this.gcxRsl.ExAutoSize = false;
            this.gcxRsl.Location = new System.Drawing.Point(173, 3);
            this.gcxRsl.Name = "gcxRsl";
            this.gcxRsl.Size = new System.Drawing.Size(557, 272);
            this.gcxRsl.TabIndex = 3;
            // 
            // listRms
            // 
            this.listRms.Location = new System.Drawing.Point(27, 26);
            this.listRms.Name = "listRms";
            this.listRms.Size = new System.Drawing.Size(129, 163);
            this.listRms.TabIndex = 2;
            this.listRms.SelectedIndexChanged += new System.EventHandler(this.listRms_SelectedIndexChanged);
            // 
            // btnDeleteRms
            // 
            this.btnDeleteRms.Location = new System.Drawing.Point(55, 195);
            this.btnDeleteRms.Name = "btnDeleteRms";
            this.btnDeleteRms.Size = new System.Drawing.Size(22, 20);
            this.btnDeleteRms.TabIndex = 1;
            this.btnDeleteRms.Text = "?";
            this.btnDeleteRms.Click += new System.EventHandler(this.btnDeleteRms_Click);
            // 
            // btnAddRms
            // 
            this.btnAddRms.Location = new System.Drawing.Point(27, 195);
            this.btnAddRms.Name = "btnAddRms";
            this.btnAddRms.Size = new System.Drawing.Size(22, 20);
            this.btnAddRms.TabIndex = 1;
            this.btnAddRms.Text = "+";
            this.btnAddRms.Click += new System.EventHandler(this.btnAddRms_Click);
            // 
            // tabInvoice
            // 
            this.tabInvoice.Controls.Add(this.gcxRsd);
            this.tabInvoice.Name = "tabInvoice";
            this.tabInvoice.Size = new System.Drawing.Size(743, 287);
            this.tabInvoice.Text = "Invoice";
            // 
            // gcxRsd
            // 
            this.gcxRsd.BestFitColumn = true;
            this.gcxRsd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcxRsd.ExAutoSize = false;
            this.gcxRsd.Location = new System.Drawing.Point(0, 0);
            this.gcxRsd.Name = "gcxRsd";
            this.gcxRsd.Size = new System.Drawing.Size(743, 287);
            this.gcxRsd.TabIndex = 83;
            // 
            // tabBarang
            // 
            this.tabBarang.Controls.Add(this.gcxSjrd);
            this.tabBarang.Name = "tabBarang";
            this.tabBarang.Size = new System.Drawing.Size(743, 287);
            this.tabBarang.Text = "Pengiriman Barang";
            // 
            // gcxSjrd
            // 
            this.gcxSjrd.BestFitColumn = true;
            this.gcxSjrd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcxSjrd.ExAutoSize = false;
            this.gcxSjrd.Location = new System.Drawing.Point(0, 0);
            this.gcxSjrd.Name = "gcxSjrd";
            this.gcxSjrd.Size = new System.Drawing.Size(743, 287);
            this.gcxSjrd.TabIndex = 0;
            // 
            // remarkMemoEdit
            // 
            this.remarkMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rskBindingSource, "remark", true));
            this.remarkMemoEdit.Location = new System.Drawing.Point(474, 89);
            this.remarkMemoEdit.Name = "remarkMemoEdit";
            this.remarkMemoEdit.Size = new System.Drawing.Size(253, 43);
            this.remarkMemoEdit.TabIndex = 119;
            // 
            // rsdBindingSource
            // 
            this.rsdBindingSource.DataMember = "rsd";
            this.rsdBindingSource.DataSource = this.casDataSet;
            // 
            // rslBindingSource
            // 
            this.rslBindingSource.DataMember = "rsl";
            this.rslBindingSource.DataSource = this.casDataSet;
            // 
            // rskTableAdapter
            // 
            this.rskTableAdapter.ClearBeforeFill = true;
            // 
            // tglfpDateEdit
            // 
            this.tglfpDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rskBindingSource, "tglfp", true));
            this.tglfpDateEdit.EditValue = null;
            this.tglfpDateEdit.Location = new System.Drawing.Point(85, 163);
            this.tglfpDateEdit.Name = "tglfpDateEdit";
            this.tglfpDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tglfpDateEdit.Size = new System.Drawing.Size(100, 23);
            this.tglfpDateEdit.TabIndex = 125;
            this.tglfpDateEdit.EditValueChanged += new System.EventHandler(this.tglfpDateEdit_EditValueChanged);
            // 
            // tglsfpDateEdit
            // 
            this.tglsfpDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rskBindingSource, "tglsfp", true));
            this.tglsfpDateEdit.EditValue = null;
            this.tglsfpDateEdit.Location = new System.Drawing.Point(275, 163);
            this.tglsfpDateEdit.Name = "tglsfpDateEdit";
            this.tglsfpDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tglsfpDateEdit.Size = new System.Drawing.Size(100, 23);
            this.tglsfpDateEdit.TabIndex = 126;
            // 
            // nofpTextEdit
            // 
            this.nofpTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rskBindingSource, "nofp", true));
            this.nofpTextEdit.Location = new System.Drawing.Point(85, 137);
            this.nofpTextEdit.Name = "nofpTextEdit";
            this.nofpTextEdit.Size = new System.Drawing.Size(157, 20);
            this.nofpTextEdit.TabIndex = 127;
            // 
            // FrmTRsk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 742);
            this.Controls.Add(this.tabDetails);
            this.DetailBindingSource = this.rsdBindingSource;
            this.DetailTable = this.casDataSet.rsd;
            this.MasterBindingSource = this.rskBindingSource;
            this.MasterTable = this.casDataSet.rsk;
            this.Name = "FrmTRsk";
            this.Text = "Retur Pembelian";
            this.Load += new System.EventHandler(this.FrmTRsk_Load);
            this.Controls.SetChildIndex(this.pnlKey, 0);
            this.Controls.SetChildIndex(this.pnlDetail, 0);
            this.Controls.SetChildIndex(this.tabDetails, 0);
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
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPPN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTOP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabDetails)).EndInit();
            this.tabDetails.ResumeLayout(false);
            this.tabPO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listRms)).EndInit();
            this.tabInvoice.ResumeLayout(false);
            this.tabBarang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rslBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglfpDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglsfpDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nofpTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CtrlSub ctrlSub;
        private System.Windows.Forms.Panel pnlTotal;
        private DevExpress.XtraEditors.TextEdit txtSubTotal;
        private DevExpress.XtraEditors.TextEdit txtPPN;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private DevExpress.XtraEditors.SpinEdit spinTOP;
        private DevExpress.XtraTab.XtraTabControl tabDetails;
        private DevExpress.XtraTab.XtraTabPage tabPO;
        private KASLibrary.GridControlEx gcxRsl;
        private DevExpress.XtraEditors.ListBoxControl listRms;
        private DevExpress.XtraEditors.SimpleButton btnDeleteRms;
        private DevExpress.XtraEditors.SimpleButton btnAddRms;
        private DevExpress.XtraTab.XtraTabPage tabInvoice;
        private KASLibrary.GridControlEx gcxRsd;
        private DevExpress.XtraTab.XtraTabPage tabBarang;
        private KASLibrary.GridControlEx gcxSjrd;
        private DevExpress.XtraEditors.MemoEdit remarkMemoEdit;
        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource rskBindingSource;
        private System.Windows.Forms.BindingSource rsdBindingSource;
        private System.Windows.Forms.BindingSource rslBindingSource;
        private DevExpress.XtraEditors.DateEdit tglsfpDateEdit;
        private DevExpress.XtraEditors.DateEdit tglfpDateEdit;
        private CAS.casDataSetTableAdapters.rskTableAdapter rskTableAdapter;
        private DevExpress.XtraEditors.TextEdit nofpTextEdit;

    }
}