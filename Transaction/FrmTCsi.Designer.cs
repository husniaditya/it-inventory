namespace CAS.Transaction
{
    partial class FrmTCsi
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
            System.Windows.Forms.Label omsLabel;
            this.tabDetil = new DevExpress.XtraTab.XtraTabControl();
            this.TabInvoice = new DevExpress.XtraTab.XtraTabPage();
            this.gccsa = new KASLibrary.GridControlEx();
            this.TabLpb = new DevExpress.XtraTab.XtraTabPage();
            this.gccsl = new KASLibrary.GridControlEx();
            this.TabBiaya = new DevExpress.XtraTab.XtraTabPage();
            this.gccsb = new KASLibrary.GridControlEx();
            this.casDataSet = new CAS.casDataSet();
            this.csiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.csiTableAdapter = new CAS.casDataSetTableAdapters.csiTableAdapter();
            this.omsTextBoxEx = new KASLibrary.TextBoxEx();
            this.csaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.csaTableAdapter = new CAS.casDataSetTableAdapters.csaTableAdapter();
            this.cslBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.csbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.texttotnilai = new DevExpress.XtraEditors.TextEdit();
            this.texttotqty = new DevExpress.XtraEditors.TextEdit();
            this.paneltotal = new System.Windows.Forms.Panel();
            this.textval = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.omdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.omdTableAdapter = new CAS.casDataSetTableAdapters.omdTableAdapter();
            this.txttotalbiaya = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            omsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ludSeri.Properties)).BeginInit();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curkurs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curcur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabDetil)).BeginInit();
            this.tabDetil.SuspendLayout();
            this.TabInvoice.SuspendLayout();
            this.TabLpb.SuspendLayout();
            this.TabBiaya.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.omsTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cslBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.texttotnilai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.texttotqty.Properties)).BeginInit();
            this.paneltotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textval.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.omdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttotalbiaya.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNo
            // 
            // 
            // txtPeriod
            // 
            // 
            // ludSeri
            // 
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.texttotqty);
            this.pnlDetail.Controls.Add(this.label2);
            this.pnlDetail.Controls.Add(omsLabel);
            this.pnlDetail.Controls.Add(this.omsTextBoxEx);
            this.pnlDetail.Controls.Add(this.paneltotal);
            this.pnlDetail.Controls.Add(this.tabDetil);
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.None;
            this.pnlDetail.Size = new System.Drawing.Size(758, 462);
            this.pnlDetail.Controls.SetChildIndex(this.tabDetil, 0);
            this.pnlDetail.Controls.SetChildIndex(this.paneltotal, 0);
            this.pnlDetail.Controls.SetChildIndex(this.omsTextBoxEx, 0);
            this.pnlDetail.Controls.SetChildIndex(omsLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.label2, 0);
            this.pnlDetail.Controls.SetChildIndex(this.texttotqty, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateDate, 0);
            this.pnlDetail.Controls.SetChildIndex(this.dateLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curcur, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curkurs, 0);
            this.pnlDetail.Controls.SetChildIndex(this.kursLabel, 0);
            this.pnlDetail.Controls.SetChildIndex(this.curLabel1, 0);
            // 
            // pnlKey
            // 
            this.pnlKey.Size = new System.Drawing.Size(770, 50);
            // 
            // dateDate
            // 
            this.dateDate.EditValue = new System.DateTime(((long)(0)));
            this.dateDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateDate.Properties.Mask.IgnoreMaskBlank = false;
            // 
            // curkurs
            // 
            this.curkurs.Visible = false;
            // 
            // curcur
            // 
            this.curcur.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.curcur.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.curcur.Properties.Appearance.Options.UseBackColor = true;
            this.curcur.Properties.Appearance.Options.UseForeColor = true;
            this.curcur.Visible = false;
            // 
            // curLabel1
            // 
            this.curLabel1.Visible = false;
            // 
            // kursLabel
            // 
            this.kursLabel.Visible = false;
            // 
            // omsLabel
            // 
            omsLabel.AutoSize = true;
            omsLabel.Location = new System.Drawing.Point(15, 22);
            omsLabel.Name = "omsLabel";
            omsLabel.Size = new System.Drawing.Size(30, 13);
            omsLabel.TabIndex = 29;
            omsLabel.Text = "oms:";
            // 
            // tabDetil
            // 
            this.tabDetil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabDetil.Location = new System.Drawing.Point(18, 51);
            this.tabDetil.Name = "tabDetil";
            this.tabDetil.SelectedTabPage = this.TabInvoice;
            this.tabDetil.Size = new System.Drawing.Size(704, 369);
            this.tabDetil.TabIndex = 29;
            this.tabDetil.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabInvoice,
            this.TabLpb,
            this.TabBiaya});
            this.tabDetil.Text = "TabControl";
            // 
            // TabInvoice
            // 
            this.TabInvoice.Controls.Add(this.gccsa);
            this.TabInvoice.Name = "TabInvoice";
            this.TabInvoice.Size = new System.Drawing.Size(650, 341);
            this.TabInvoice.Text = "Invoice";
            // 
            // gccsa
            // 
            this.gccsa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gccsa.BestFitColumn = true;
            this.gccsa.ExAutoSize = false;
            this.gccsa.Location = new System.Drawing.Point(2, 3);
            this.gccsa.Name = "gccsa";
            this.gccsa.Size = new System.Drawing.Size(648, 335);
            this.gccsa.TabIndex = 0;
            // 
            // TabLpb
            // 
            this.TabLpb.Controls.Add(this.gccsl);
            this.TabLpb.Name = "TabLpb";
            this.TabLpb.Size = new System.Drawing.Size(650, 341);
            this.TabLpb.Text = "Penerimaan Barang";
            // 
            // gccsl
            // 
            this.gccsl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gccsl.BestFitColumn = true;
            this.gccsl.ExAutoSize = false;
            this.gccsl.Location = new System.Drawing.Point(-4, 6);
            this.gccsl.Name = "gccsl";
            this.gccsl.Size = new System.Drawing.Size(648, 335);
            this.gccsl.TabIndex = 0;
            // 
            // TabBiaya
            // 
            this.TabBiaya.Controls.Add(this.gccsb);
            this.TabBiaya.Name = "TabBiaya";
            this.TabBiaya.Size = new System.Drawing.Size(696, 341);
            this.TabBiaya.Text = "Biaya";
            // 
            // gccsb
            // 
            this.gccsb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gccsb.BestFitColumn = true;
            this.gccsb.ExAutoSize = false;
            this.gccsb.Location = new System.Drawing.Point(1, 3);
            this.gccsb.Name = "gccsb";
            this.gccsb.Size = new System.Drawing.Size(694, 335);
            this.gccsb.TabIndex = 0;
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // csiBindingSource
            // 
            this.csiBindingSource.DataMember = "csi";
            this.csiBindingSource.DataSource = this.casDataSet;
            // 
            // csiTableAdapter
            // 
            this.csiTableAdapter.ClearBeforeFill = true;
            // 
            // omsTextBoxEx
            // 
            this.omsTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.csiBindingSource, "oms", true));
            this.omsTextBoxEx.ExAllowEmptyString = true;
            this.omsTextBoxEx.ExAllowNonDBData = false;
            this.omsTextBoxEx.ExAutoCheck = true;
            this.omsTextBoxEx.ExAutoShowResult = false;
            this.omsTextBoxEx.ExCondition = "";
            this.omsTextBoxEx.ExDialogTitle = "";
            this.omsTextBoxEx.ExFieldName = "oms";
            this.omsTextBoxEx.ExFilterFields = new string[0];
            this.omsTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.omsTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.omsTextBoxEx.ExLabelContainer = null;
            this.omsTextBoxEx.ExLabelField = "name";
            this.omsTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.omsTextBoxEx.ExLabelText = "";
            this.omsTextBoxEx.ExLabelVisible = false;
            this.omsTextBoxEx.ExSelectFields = new string[0];
            this.omsTextBoxEx.ExShowDialog = true;
            this.omsTextBoxEx.ExSimpleMode = true;
            this.omsTextBoxEx.ExSqlInstance = null;
            this.omsTextBoxEx.ExSqlQuery = "";
            this.omsTextBoxEx.ExTableName = "csi";
            this.omsTextBoxEx.Location = new System.Drawing.Point(51, 19);
            this.omsTextBoxEx.Name = "omsTextBoxEx";
            this.omsTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.omsTextBoxEx.Size = new System.Drawing.Size(122, 20);
            this.omsTextBoxEx.TabIndex = 30;
            this.omsTextBoxEx.EditValueChanged += new System.EventHandler(this.omsTextBoxEx_EditValueChanged);
            // 
            // csaBindingSource
            // 
            this.csaBindingSource.DataMember = "csa";
            this.csaBindingSource.DataSource = this.casDataSet;
            // 
            // csaTableAdapter
            // 
            this.csaTableAdapter.ClearBeforeFill = true;
            // 
            // cslBindingSource
            // 
            this.cslBindingSource.DataMember = "csl";
            this.cslBindingSource.DataSource = this.casDataSet;
            // 
            // csbBindingSource
            // 
            this.csbBindingSource.DataMember = "csb";
            this.csbBindingSource.DataSource = this.casDataSet;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Total Quantity";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Total Biaya";
            // 
            // texttotnilai
            // 
            this.texttotnilai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.texttotnilai.Location = new System.Drawing.Point(282, 4);
            this.texttotnilai.Name = "texttotnilai";
            this.texttotnilai.Properties.DisplayFormat.FormatString = "n2";
            this.texttotnilai.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.texttotnilai.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.texttotnilai.Size = new System.Drawing.Size(100, 20);
            this.texttotnilai.TabIndex = 35;
            // 
            // texttotqty
            // 
            this.texttotqty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.texttotqty.Location = new System.Drawing.Point(115, 433);
            this.texttotqty.Name = "texttotqty";
            this.texttotqty.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.texttotqty.Size = new System.Drawing.Size(100, 20);
            this.texttotqty.TabIndex = 36;
            // 
            // paneltotal
            // 
            this.paneltotal.Controls.Add(this.label5);
            this.paneltotal.Controls.Add(this.textval);
            this.paneltotal.Controls.Add(this.label4);
            this.paneltotal.Controls.Add(this.texttotnilai);
            this.paneltotal.Controls.Add(this.label3);
            this.paneltotal.Controls.Add(this.txttotalbiaya);
            this.paneltotal.Location = new System.Drawing.Point(12, 429);
            this.paneltotal.Name = "paneltotal";
            this.paneltotal.Size = new System.Drawing.Size(705, 27);
            this.paneltotal.TabIndex = 3;
            // 
            // textval
            // 
            this.textval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textval.Location = new System.Drawing.Point(602, 3);
            this.textval.Name = "textval";
            this.textval.Properties.DisplayFormat.FormatString = "n2";
            this.textval.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.textval.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textval.Size = new System.Drawing.Size(100, 20);
            this.textval.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(566, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Price";
            // 
            // omdBindingSource
            // 
            this.omdBindingSource.DataMember = "omd";
            this.omdBindingSource.DataSource = this.casDataSet;
            // 
            // omdTableAdapter
            // 
            this.omdTableAdapter.ClearBeforeFill = true;
            // 
            // txttotalbiaya
            // 
            this.txttotalbiaya.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txttotalbiaya.Location = new System.Drawing.Point(460, 3);
            this.txttotalbiaya.Name = "txttotalbiaya";
            this.txttotalbiaya.Properties.DisplayFormat.FormatString = "n2";
            this.txttotalbiaya.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txttotalbiaya.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txttotalbiaya.Size = new System.Drawing.Size(100, 20);
            this.txttotalbiaya.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Total Nilai";
            // 
            // FrmTCsi
            // 
            this.ClientSize = new System.Drawing.Size(770, 598);
            this.DetailBindingSource = this.csaBindingSource;
            this.DetailTable = this.casDataSet.csa;
            this.MasterBindingSource = this.csiBindingSource;
            this.MasterTable = this.casDataSet.csi;
            this.Name = "FrmTCsi";
            this.Load += new System.EventHandler(this.FrmTCsi_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.tabDetil)).EndInit();
            this.tabDetil.ResumeLayout(false);
            this.TabInvoice.ResumeLayout(false);
            this.TabLpb.ResumeLayout(false);
            this.TabBiaya.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.omsTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cslBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.texttotnilai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.texttotqty.Properties)).EndInit();
            this.paneltotal.ResumeLayout(false);
            this.paneltotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textval.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.omdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttotalbiaya.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabDetil;
        private DevExpress.XtraTab.XtraTabPage TabInvoice;
        private DevExpress.XtraTab.XtraTabPage TabLpb;
        private KASLibrary.GridControlEx gccsa;
        private KASLibrary.GridControlEx gccsl;
        private DevExpress.XtraTab.XtraTabPage TabBiaya;
        private KASLibrary.GridControlEx gccsb;
        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource csiBindingSource;
        private CAS.casDataSetTableAdapters.csiTableAdapter csiTableAdapter;
        private KASLibrary.TextBoxEx omsTextBoxEx;
        private System.Windows.Forms.BindingSource csaBindingSource;
        private CAS.casDataSetTableAdapters.csaTableAdapter csaTableAdapter;
        private System.Windows.Forms.BindingSource cslBindingSource;
        private System.Windows.Forms.BindingSource csbBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit texttotqty;
        private DevExpress.XtraEditors.TextEdit texttotnilai;
        private System.Windows.Forms.Panel paneltotal;
        private System.Windows.Forms.BindingSource omdBindingSource;
        private CAS.casDataSetTableAdapters.omdTableAdapter omdTableAdapter;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit textval;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txttotalbiaya;
    }
}
