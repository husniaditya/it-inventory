namespace CAS.Transaction
{
    partial class FrmTCostAll
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
            System.Windows.Forms.Label periodLabel;
            System.Windows.Forms.Label plantLabel;
            this.txtPeriod = new DevExpress.XtraEditors.TextEdit();
            this.ctaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casDataSet = new CAS.casDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.ctdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ctdTableAdapter = new CAS.casDataSetTableAdapters.ctdTableAdapter();
            this.ctaTableAdapter = new CAS.casDataSetTableAdapters.ctaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCounter = new DevExpress.XtraEditors.SpinEdit();
            this.txtActual = new DevExpress.XtraEditors.SpinEdit();
            this.txtWaste = new DevExpress.XtraEditors.SpinEdit();
            this.txtCfit3 = new DevExpress.XtraEditors.SpinEdit();
            this.txtWastePersen = new DevExpress.XtraEditors.SpinEdit();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gcCtd = new KASLibrary.GridControlEx();
            this.txtCct = new KASLibrary.TextBoxEx();
            this.plantComboBox = new System.Windows.Forms.ComboBox();
            periodLabel = new System.Windows.Forms.Label();
            plantLabel = new System.Windows.Forms.Label();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCounter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActual.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWaste.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCfit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWastePersen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCct.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.txtWastePersen);
            this.pnlDetail.Controls.Add(this.txtCfit3);
            this.pnlDetail.Controls.Add(this.txtWaste);
            this.pnlDetail.Controls.Add(this.txtActual);
            this.pnlDetail.Controls.Add(this.txtCounter);
            this.pnlDetail.Controls.Add(this.label7);
            this.pnlDetail.Controls.Add(this.label8);
            this.pnlDetail.Controls.Add(this.label9);
            this.pnlDetail.Controls.Add(this.label6);
            this.pnlDetail.Controls.Add(this.label5);
            this.pnlDetail.Controls.Add(this.label4);
            this.pnlDetail.Controls.Add(this.label1);
            this.pnlDetail.Controls.Add(this.gcCtd);
            this.pnlDetail.Location = new System.Drawing.Point(0, 108);
            this.pnlDetail.Size = new System.Drawing.Size(980, 327);
            // 
            // pnlKey
            // 
            this.pnlKey.Controls.Add(plantLabel);
            this.pnlKey.Controls.Add(this.plantComboBox);
            this.pnlKey.Controls.Add(this.btnUpdate);
            this.pnlKey.Controls.Add(periodLabel);
            this.pnlKey.Controls.Add(this.txtPeriod);
            this.pnlKey.Controls.Add(this.label3);
            this.pnlKey.Controls.Add(this.txtCct);
            this.pnlKey.Size = new System.Drawing.Size(980, 83);
            // 
            // pnlChInfo
            // 
            this.pnlChInfo.Location = new System.Drawing.Point(0, 435);
            this.pnlChInfo.Size = new System.Drawing.Size(980, 45);
            // 
            // periodLabel
            // 
            periodLabel.AutoSize = true;
            periodLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            periodLabel.Location = new System.Drawing.Point(24, 11);
            periodLabel.Name = "periodLabel";
            periodLabel.Size = new System.Drawing.Size(43, 13);
            periodLabel.TabIndex = 338;
            periodLabel.Text = "Period";
            // 
            // plantLabel
            // 
            plantLabel.AutoSize = true;
            plantLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            plantLabel.Location = new System.Drawing.Point(23, 37);
            plantLabel.Name = "plantLabel";
            plantLabel.Size = new System.Drawing.Size(36, 13);
            plantLabel.TabIndex = 359;
            plantLabel.Text = "Plant";
            // 
            // txtPeriod
            // 
            this.txtPeriod.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ctaBindingSource, "period", true));
            this.txtPeriod.Location = new System.Drawing.Point(106, 8);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(100, 20);
            this.txtPeriod.TabIndex = 339;
            // 
            // ctaBindingSource
            // 
            this.ctaBindingSource.DataMember = "cta";
            this.ctaBindingSource.DataSource = this.casDataSet;
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(23, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 337;
            this.label3.Text = "Cost Center";
            // 
            // ctdBindingSource
            // 
            this.ctdBindingSource.DataMember = "ctd";
            this.ctdBindingSource.DataSource = this.casDataSet;
            // 
            // ctdTableAdapter
            // 
            this.ctdTableAdapter.ClearBeforeFill = true;
            // 
            // ctaTableAdapter
            // 
            this.ctaTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(673, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 14);
            this.label1.TabIndex = 341;
            this.label1.Text = "FINISHED && TRANSFERRED :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 14);
            this.label4.TabIndex = 343;
            this.label4.Text = "Counter";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 14);
            this.label5.TabIndex = 344;
            this.label5.Text = "Actual";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 14);
            this.label6.TabIndex = 345;
            this.label6.Text = "Waste";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(86, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 14);
            this.label7.TabIndex = 348;
            this.label7.Text = ":";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(86, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 14);
            this.label8.TabIndex = 347;
            this.label8.Text = ":";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(86, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 14);
            this.label9.TabIndex = 346;
            this.label9.Text = ":";
            this.label9.Visible = false;
            // 
            // txtCounter
            // 
            this.txtCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCounter.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtCounter.Location = new System.Drawing.Point(103, 245);
            this.txtCounter.Name = "txtCounter";
            this.txtCounter.Properties.AllowFocused = false;
            this.txtCounter.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtCounter.Properties.Appearance.Options.UseBackColor = true;
            this.txtCounter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.Utils.HorzAlignment.Center, null)});
            this.txtCounter.Properties.DisplayFormat.FormatString = "n0";
            this.txtCounter.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCounter.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCounter.Properties.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtCounter.Properties.ReadOnly = true;
            this.txtCounter.Properties.SpinStyle = DevExpress.XtraEditors.Controls.SpinStyles.Horizontal;
            this.txtCounter.Properties.UseCtrlIncrement = false;
            this.txtCounter.Size = new System.Drawing.Size(113, 20);
            this.txtCounter.TabIndex = 349;
            this.txtCounter.Visible = false;
            // 
            // txtActual
            // 
            this.txtActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtActual.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtActual.Location = new System.Drawing.Point(103, 268);
            this.txtActual.Name = "txtActual";
            this.txtActual.Properties.AllowFocused = false;
            this.txtActual.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtActual.Properties.Appearance.Options.UseBackColor = true;
            this.txtActual.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.Utils.HorzAlignment.Center, null)});
            this.txtActual.Properties.DisplayFormat.FormatString = "n0";
            this.txtActual.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtActual.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtActual.Properties.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtActual.Properties.ReadOnly = true;
            this.txtActual.Properties.SpinStyle = DevExpress.XtraEditors.Controls.SpinStyles.Horizontal;
            this.txtActual.Properties.UseCtrlIncrement = false;
            this.txtActual.Size = new System.Drawing.Size(113, 20);
            this.txtActual.TabIndex = 350;
            this.txtActual.Visible = false;
            // 
            // txtWaste
            // 
            this.txtWaste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtWaste.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtWaste.Location = new System.Drawing.Point(103, 291);
            this.txtWaste.Name = "txtWaste";
            this.txtWaste.Properties.AllowFocused = false;
            this.txtWaste.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtWaste.Properties.Appearance.Options.UseBackColor = true;
            this.txtWaste.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.Utils.HorzAlignment.Center, null)});
            this.txtWaste.Properties.DisplayFormat.FormatString = "n0";
            this.txtWaste.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtWaste.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtWaste.Properties.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtWaste.Properties.ReadOnly = true;
            this.txtWaste.Properties.SpinStyle = DevExpress.XtraEditors.Controls.SpinStyles.Horizontal;
            this.txtWaste.Properties.UseCtrlIncrement = false;
            this.txtWaste.Size = new System.Drawing.Size(113, 20);
            this.txtWaste.TabIndex = 351;
            this.txtWaste.Visible = false;
            // 
            // txtCfit3
            // 
            this.txtCfit3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCfit3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ctaBindingSource, "cfit3", true));
            this.txtCfit3.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtCfit3.Location = new System.Drawing.Point(855, 245);
            this.txtCfit3.Name = "txtCfit3";
            this.txtCfit3.Properties.AllowFocused = false;
            this.txtCfit3.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtCfit3.Properties.Appearance.Options.UseBackColor = true;
            this.txtCfit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.Utils.HorzAlignment.Center, null)});
            this.txtCfit3.Properties.DisplayFormat.FormatString = "n0";
            this.txtCfit3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCfit3.Properties.EditFormat.FormatString = "n0";
            this.txtCfit3.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCfit3.Properties.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtCfit3.Properties.ReadOnly = true;
            this.txtCfit3.Properties.SpinStyle = DevExpress.XtraEditors.Controls.SpinStyles.Horizontal;
            this.txtCfit3.Properties.UseCtrlIncrement = false;
            this.txtCfit3.Size = new System.Drawing.Size(101, 20);
            this.txtCfit3.TabIndex = 352;
            // 
            // txtWastePersen
            // 
            this.txtWastePersen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtWastePersen.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtWastePersen.Location = new System.Drawing.Point(222, 291);
            this.txtWastePersen.Name = "txtWastePersen";
            this.txtWastePersen.Properties.AllowFocused = false;
            this.txtWastePersen.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtWastePersen.Properties.Appearance.Options.UseBackColor = true;
            this.txtWastePersen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.Utils.HorzAlignment.Center, null)});
            this.txtWastePersen.Properties.DisplayFormat.FormatString = "{0:###,##.##}%";
            this.txtWastePersen.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtWastePersen.Properties.EditFormat.FormatString = "{0:###,##.##}%";
            this.txtWastePersen.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtWastePersen.Properties.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtWastePersen.Properties.ReadOnly = true;
            this.txtWastePersen.Properties.SpinStyle = DevExpress.XtraEditors.Controls.SpinStyles.Horizontal;
            this.txtWastePersen.Properties.UseCtrlIncrement = false;
            this.txtWastePersen.Size = new System.Drawing.Size(55, 20);
            this.txtWastePersen.TabIndex = 353;
            this.txtWastePersen.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(859, 13);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 36);
            this.btnUpdate.TabIndex = 341;
            this.btnUpdate.Text = "Update Values";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gcCtd
            // 
            this.gcCtd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcCtd.BestFitColumn = true;
            this.gcCtd.ExAutoSize = false;
            this.gcCtd.Location = new System.Drawing.Point(22, 6);
            this.gcCtd.Name = "gcCtd";
            this.gcCtd.Size = new System.Drawing.Size(934, 228);
            this.gcCtd.TabIndex = 2;
            // 
            // txtCct
            // 
            this.txtCct.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ctaBindingSource, "cct", true));
            this.txtCct.ExAllowEmptyString = true;
            this.txtCct.ExAllowNonDBData = false;
            this.txtCct.ExAutoCheck = true;
            this.txtCct.ExAutoShowResult = false;
            this.txtCct.ExCondition = "";
            this.txtCct.ExDialogTitle = "";
            this.txtCct.ExFieldName = "cct";
            this.txtCct.ExFilterFields = new string[0];
            this.txtCct.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.txtCct.ExInvalidForeColor = System.Drawing.Color.Black;
            this.txtCct.ExLabelContainer = null;
            this.txtCct.ExLabelField = "name";
            this.txtCct.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.txtCct.ExLabelText = "";
            this.txtCct.ExLabelVisible = true;
            this.txtCct.ExSelectFields = new string[0];
            this.txtCct.ExShowDialog = true;
            this.txtCct.ExSimpleMode = false;
            this.txtCct.ExSqlInstance = null;
            this.txtCct.ExSqlQuery = "select * from cct where cct like \'111%\'";
            this.txtCct.ExTableName = "";
            this.txtCct.Location = new System.Drawing.Point(106, 61);
            this.txtCct.Name = "txtCct";
            this.txtCct.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtCct.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtCct.Properties.Appearance.Options.UseBackColor = true;
            this.txtCct.Properties.Appearance.Options.UseForeColor = true;
            this.txtCct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.txtCct.Size = new System.Drawing.Size(100, 20);
            this.txtCct.TabIndex = 336;
            this.txtCct.EditValueChanged += new System.EventHandler(this.txtCct_EditValueChanged);
            // 
            // plantComboBox
            // 
            this.plantComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ctaBindingSource, "plant", true));
            this.plantComboBox.FormattingEnabled = true;
            this.plantComboBox.Location = new System.Drawing.Point(106, 33);
            this.plantComboBox.Name = "plantComboBox";
            this.plantComboBox.Size = new System.Drawing.Size(121, 21);
            this.plantComboBox.TabIndex = 360;
            // 
            // FrmTCostAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(980, 502);
            this.MasterBindingSource = this.ctaBindingSource;
            this.MasterQuery = "select * from cta";
            this.MasterTable = this.casDataSet.cta;
            this.Name = "FrmTCostAll";
            this.Text = "Cost Allocation";
            this.Load += new System.EventHandler(this.FrmTCostAll_Load);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.pnlKey.ResumeLayout(false);
            this.pnlKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCounter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActual.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWaste.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCfit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWastePersen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCct.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KASLibrary.GridControlEx gcCtd;
        private DevExpress.XtraEditors.TextEdit txtPeriod;
        private System.Windows.Forms.Label label3;
        private KASLibrary.TextBoxEx txtCct;
        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource ctdBindingSource;
        private CAS.casDataSetTableAdapters.ctdTableAdapter ctdTableAdapter;
        private System.Windows.Forms.BindingSource ctaBindingSource;
        private CAS.casDataSetTableAdapters.ctaTableAdapter ctaTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SpinEdit txtCfit3;
        private DevExpress.XtraEditors.SpinEdit txtWaste;
        private DevExpress.XtraEditors.SpinEdit txtActual;
        private DevExpress.XtraEditors.SpinEdit txtCounter;
        private DevExpress.XtraEditors.SpinEdit txtWastePersen;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox plantComboBox;
    }
}
