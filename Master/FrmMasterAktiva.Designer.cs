namespace CAS.Master
{
    partial class FrmMasterAktiva
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
            System.Windows.Forms.Label aktLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label accLabel;
            System.Windows.Forms.Label jumlahLabel;
            System.Windows.Forms.Label unitLabel;
            System.Windows.Forms.Label hargaLabel;
            System.Windows.Forms.Label residuLabel;
            System.Windows.Forms.Label tglbeliLabel;
            System.Windows.Forms.Label lokasiLabel;
            System.Windows.Forms.Label prosentaseLabel;
            System.Windows.Forms.Label tgljualLabel;
            System.Windows.Forms.Label tglstopLabel;
            System.Windows.Forms.Label accsusutLabel;
            System.Windows.Forms.Label remarkLabel;
            System.Windows.Forms.Label accbiayaLabel;
            System.Windows.Forms.Label bsaLabel;
            this.casDataSet = new CAS.casDataSet();
            this.aktBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aktTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.jumlahSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.hargaSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.residuSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.tglbeliDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lokasiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.prosentaseSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.tgljualDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tglstopDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.remarkTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.akdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.akdTableAdapter = new CAS.casDataSetTableAdapters.akdTableAdapter();
            this.aktTableAdapter = new CAS.casDataSetTableAdapters.aktTableAdapter();
            this.accbiayaTextBoxEx = new KASLibrary.TextBoxEx();
            this.gcakd = new KASLibrary.GridControlEx();
            this.accTextBoxEx = new KASLibrary.TextBoxEx();
            this.accsusutTextBoxEx = new KASLibrary.TextBoxEx();
            this.bsaTextBoxEx = new KASLibrary.TextBoxEx();
            this.unitTextEdit = new KASLibrary.TextBoxEx();
            aktLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            accLabel = new System.Windows.Forms.Label();
            jumlahLabel = new System.Windows.Forms.Label();
            unitLabel = new System.Windows.Forms.Label();
            hargaLabel = new System.Windows.Forms.Label();
            residuLabel = new System.Windows.Forms.Label();
            tglbeliLabel = new System.Windows.Forms.Label();
            lokasiLabel = new System.Windows.Forms.Label();
            prosentaseLabel = new System.Windows.Forms.Label();
            tgljualLabel = new System.Windows.Forms.Label();
            tglstopLabel = new System.Windows.Forms.Label();
            accsusutLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            accbiayaLabel = new System.Windows.Forms.Label();
            bsaLabel = new System.Windows.Forms.Label();
            this.pnlDetail.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumlahSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hargaSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.residuSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokasiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosentaseSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accbiayaTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accsusutTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsaTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.unitTextEdit);
            this.pnlDetail.Controls.Add(bsaLabel);
            this.pnlDetail.Controls.Add(this.bsaTextBoxEx);
            this.pnlDetail.Controls.Add(accbiayaLabel);
            this.pnlDetail.Controls.Add(this.accbiayaTextBoxEx);
            this.pnlDetail.Controls.Add(this.gcakd);
            this.pnlDetail.Controls.Add(nameLabel);
            this.pnlDetail.Controls.Add(this.nameTextEdit);
            this.pnlDetail.Controls.Add(accLabel);
            this.pnlDetail.Controls.Add(this.accTextBoxEx);
            this.pnlDetail.Controls.Add(jumlahLabel);
            this.pnlDetail.Controls.Add(this.jumlahSpinEdit);
            this.pnlDetail.Controls.Add(unitLabel);
            this.pnlDetail.Controls.Add(hargaLabel);
            this.pnlDetail.Controls.Add(this.hargaSpinEdit);
            this.pnlDetail.Controls.Add(residuLabel);
            this.pnlDetail.Controls.Add(this.residuSpinEdit);
            this.pnlDetail.Controls.Add(tglbeliLabel);
            this.pnlDetail.Controls.Add(this.tglbeliDateTimePicker);
            this.pnlDetail.Controls.Add(lokasiLabel);
            this.pnlDetail.Controls.Add(this.lokasiTextEdit);
            this.pnlDetail.Controls.Add(prosentaseLabel);
            this.pnlDetail.Controls.Add(this.prosentaseSpinEdit);
            this.pnlDetail.Controls.Add(tgljualLabel);
            this.pnlDetail.Controls.Add(this.tgljualDateTimePicker);
            this.pnlDetail.Controls.Add(tglstopLabel);
            this.pnlDetail.Controls.Add(this.tglstopDateTimePicker);
            this.pnlDetail.Controls.Add(accsusutLabel);
            this.pnlDetail.Controls.Add(this.accsusutTextBoxEx);
            this.pnlDetail.Controls.Add(remarkLabel);
            this.pnlDetail.Controls.Add(this.remarkTextEdit);
            this.pnlDetail.Location = new System.Drawing.Point(0, 106);
            this.pnlDetail.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pnlDetail.Size = new System.Drawing.Size(938, 803);
            // 
            // pnlKey
            // 
            this.pnlKey.Controls.Add(this.aktTextEdit);
            this.pnlKey.Controls.Add(aktLabel);
            this.pnlKey.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pnlKey.Size = new System.Drawing.Size(938, 74);
            // 
            // pnlChInfo
            // 
            this.pnlChInfo.Location = new System.Drawing.Point(0, 909);
            this.pnlChInfo.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pnlChInfo.Size = new System.Drawing.Size(938, 69);
            // 
            // aktLabel
            // 
            aktLabel.AutoSize = true;
            aktLabel.Location = new System.Drawing.Point(44, 29);
            aktLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            aktLabel.Name = "aktLabel";
            aktLabel.Size = new System.Drawing.Size(53, 19);
            aktLabel.TabIndex = 0;
            aktLabel.Text = "Aktiva";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(44, 14);
            nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(50, 19);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Nama";
            // 
            // accLabel
            // 
            accLabel.AutoSize = true;
            accLabel.Location = new System.Drawing.Point(44, 54);
            accLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            accLabel.Name = "accLabel";
            accLabel.Size = new System.Drawing.Size(66, 19);
            accLabel.TabIndex = 4;
            accLabel.Text = "Account";
            // 
            // jumlahLabel
            // 
            jumlahLabel.AutoSize = true;
            jumlahLabel.Location = new System.Drawing.Point(44, 134);
            jumlahLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            jumlahLabel.Name = "jumlahLabel";
            jumlahLabel.Size = new System.Drawing.Size(60, 19);
            jumlahLabel.TabIndex = 6;
            jumlahLabel.Text = "Jumlah";
            // 
            // unitLabel
            // 
            unitLabel.AutoSize = true;
            unitLabel.Location = new System.Drawing.Point(321, 134);
            unitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            unitLabel.Name = "unitLabel";
            unitLabel.Size = new System.Drawing.Size(38, 19);
            unitLabel.TabIndex = 8;
            unitLabel.Text = "Unit";
            // 
            // hargaLabel
            // 
            hargaLabel.AutoSize = true;
            hargaLabel.Location = new System.Drawing.Point(44, 94);
            hargaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            hargaLabel.Name = "hargaLabel";
            hargaLabel.Size = new System.Drawing.Size(51, 19);
            hargaLabel.TabIndex = 10;
            hargaLabel.Text = "Harga";
            // 
            // residuLabel
            // 
            residuLabel.AutoSize = true;
            residuLabel.Location = new System.Drawing.Point(321, 214);
            residuLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            residuLabel.Name = "residuLabel";
            residuLabel.Size = new System.Drawing.Size(56, 19);
            residuLabel.TabIndex = 12;
            residuLabel.Text = "Residu";
            // 
            // tglbeliLabel
            // 
            tglbeliLabel.AutoSize = true;
            tglbeliLabel.Location = new System.Drawing.Point(42, 175);
            tglbeliLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tglbeliLabel.Name = "tglbeliLabel";
            tglbeliLabel.Size = new System.Drawing.Size(62, 19);
            tglbeliLabel.TabIndex = 14;
            tglbeliLabel.Text = "Tgl Beli";
            // 
            // lokasiLabel
            // 
            lokasiLabel.AutoSize = true;
            lokasiLabel.Location = new System.Drawing.Point(44, 294);
            lokasiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lokasiLabel.Name = "lokasiLabel";
            lokasiLabel.Size = new System.Drawing.Size(53, 19);
            lokasiLabel.TabIndex = 16;
            lokasiLabel.Text = "Lokasi";
            // 
            // prosentaseLabel
            // 
            prosentaseLabel.AutoSize = true;
            prosentaseLabel.Location = new System.Drawing.Point(42, 214);
            prosentaseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            prosentaseLabel.Name = "prosentaseLabel";
            prosentaseLabel.Size = new System.Drawing.Size(85, 19);
            prosentaseLabel.TabIndex = 18;
            prosentaseLabel.Text = "Prosentase";
            // 
            // tgljualLabel
            // 
            tgljualLabel.AutoSize = true;
            tgljualLabel.Location = new System.Drawing.Point(321, 175);
            tgljualLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tgljualLabel.Name = "tgljualLabel";
            tgljualLabel.Size = new System.Drawing.Size(65, 19);
            tgljualLabel.TabIndex = 20;
            tgljualLabel.Text = "Tgl Jual";
            // 
            // tglstopLabel
            // 
            tglstopLabel.AutoSize = true;
            tglstopLabel.Location = new System.Drawing.Point(42, 255);
            tglstopLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tglstopLabel.Name = "tglstopLabel";
            tglstopLabel.Size = new System.Drawing.Size(69, 19);
            tglstopLabel.TabIndex = 22;
            tglstopLabel.Text = "Tgl Stop";
            // 
            // accsusutLabel
            // 
            accsusutLabel.AutoSize = true;
            accsusutLabel.Location = new System.Drawing.Point(44, 334);
            accsusutLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            accsusutLabel.Name = "accsusutLabel";
            accsusutLabel.Size = new System.Drawing.Size(83, 19);
            accsusutLabel.TabIndex = 24;
            accsusutLabel.Text = "Acc. Susut";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(44, 409);
            remarkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(88, 19);
            remarkLabel.TabIndex = 26;
            remarkLabel.Text = "Keterangan";
            // 
            // accbiayaLabel
            // 
            accbiayaLabel.AutoSize = true;
            accbiayaLabel.Location = new System.Drawing.Point(44, 374);
            accbiayaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            accbiayaLabel.Name = "accbiayaLabel";
            accbiayaLabel.Size = new System.Drawing.Size(81, 19);
            accbiayaLabel.TabIndex = 29;
            accbiayaLabel.Text = "Acc. Biaya";
            // 
            // bsaLabel
            // 
            bsaLabel.AutoSize = true;
            bsaLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            bsaLabel.ForeColor = System.Drawing.Color.Red;
            bsaLabel.Location = new System.Drawing.Point(574, 18);
            bsaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            bsaLabel.Name = "bsaLabel";
            bsaLabel.Size = new System.Drawing.Size(105, 21);
            bsaLabel.TabIndex = 139;
            bsaLabel.Text = "Bisnis Area";
            // 
            // casDataSet
            // 
            this.casDataSet.DataSetName = "casDataSet";
            this.casDataSet.Locale = new System.Globalization.CultureInfo("id-ID");
            this.casDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aktBindingSource
            // 
            this.aktBindingSource.DataMember = "akt";
            this.aktBindingSource.DataSource = this.casDataSet;
            // 
            // aktTextEdit
            // 
            this.aktTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.aktBindingSource, "akt", true));
            this.aktTextEdit.Location = new System.Drawing.Point(146, 25);
            this.aktTextEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aktTextEdit.Name = "aktTextEdit";
            this.aktTextEdit.Size = new System.Drawing.Size(142, 26);
            this.aktTextEdit.TabIndex = 1;
            this.aktTextEdit.EditValueChanged += new System.EventHandler(this.aktTextEdit_EditValueChanged);
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.aktBindingSource, "name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(146, 9);
            this.nameTextEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(378, 26);
            this.nameTextEdit.TabIndex = 3;
            // 
            // jumlahSpinEdit
            // 
            this.jumlahSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.aktBindingSource, "jumlah", true));
            this.jumlahSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.jumlahSpinEdit.Location = new System.Drawing.Point(146, 129);
            this.jumlahSpinEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jumlahSpinEdit.Name = "jumlahSpinEdit";
            this.jumlahSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.jumlahSpinEdit.Properties.UseCtrlIncrement = false;
            this.jumlahSpinEdit.Size = new System.Drawing.Size(78, 26);
            this.jumlahSpinEdit.TabIndex = 7;
            // 
            // hargaSpinEdit
            // 
            this.hargaSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.aktBindingSource, "harga", true));
            this.hargaSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.hargaSpinEdit.Location = new System.Drawing.Point(146, 89);
            this.hargaSpinEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hargaSpinEdit.Name = "hargaSpinEdit";
            this.hargaSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.hargaSpinEdit.Properties.UseCtrlIncrement = false;
            this.hargaSpinEdit.Size = new System.Drawing.Size(236, 26);
            this.hargaSpinEdit.TabIndex = 11;
            // 
            // residuSpinEdit
            // 
            this.residuSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.aktBindingSource, "residu", true));
            this.residuSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.residuSpinEdit.Location = new System.Drawing.Point(394, 209);
            this.residuSpinEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.residuSpinEdit.Name = "residuSpinEdit";
            this.residuSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.residuSpinEdit.Properties.UseCtrlIncrement = false;
            this.residuSpinEdit.Size = new System.Drawing.Size(57, 26);
            this.residuSpinEdit.TabIndex = 13;
            // 
            // tglbeliDateTimePicker
            // 
            this.tglbeliDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.tglbeliDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.aktBindingSource, "tglbeli", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "dd/mm/yyyy"));
            this.tglbeliDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tglbeliDateTimePicker.Location = new System.Drawing.Point(146, 169);
            this.tglbeliDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tglbeliDateTimePicker.Name = "tglbeliDateTimePicker";
            this.tglbeliDateTimePicker.Size = new System.Drawing.Size(127, 26);
            this.tglbeliDateTimePicker.TabIndex = 15;
            this.tglbeliDateTimePicker.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // lokasiTextEdit
            // 
            this.lokasiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.aktBindingSource, "lokasi", true));
            this.lokasiTextEdit.Location = new System.Drawing.Point(146, 289);
            this.lokasiTextEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lokasiTextEdit.Name = "lokasiTextEdit";
            this.lokasiTextEdit.Size = new System.Drawing.Size(378, 26);
            this.lokasiTextEdit.TabIndex = 17;
            // 
            // prosentaseSpinEdit
            // 
            this.prosentaseSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.aktBindingSource, "prosentase", true));
            this.prosentaseSpinEdit.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.prosentaseSpinEdit.Location = new System.Drawing.Point(142, 209);
            this.prosentaseSpinEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prosentaseSpinEdit.Name = "prosentaseSpinEdit";
            this.prosentaseSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.prosentaseSpinEdit.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.prosentaseSpinEdit.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.prosentaseSpinEdit.Properties.UseCtrlIncrement = false;
            this.prosentaseSpinEdit.Size = new System.Drawing.Size(81, 26);
            this.prosentaseSpinEdit.TabIndex = 19;
            this.prosentaseSpinEdit.EditValueChanged += new System.EventHandler(this.prosentaseSpinEdit_EditValueChanged);
            // 
            // tgljualDateTimePicker
            // 
            this.tgljualDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.tgljualDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.aktBindingSource, "tgljual", true));
            this.tgljualDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tgljualDateTimePicker.Location = new System.Drawing.Point(394, 169);
            this.tgljualDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tgljualDateTimePicker.Name = "tgljualDateTimePicker";
            this.tgljualDateTimePicker.Size = new System.Drawing.Size(127, 26);
            this.tgljualDateTimePicker.TabIndex = 21;
            this.tgljualDateTimePicker.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // tglstopDateTimePicker
            // 
            this.tglstopDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.tglstopDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.aktBindingSource, "tglstop", true));
            this.tglstopDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tglstopDateTimePicker.Location = new System.Drawing.Point(146, 249);
            this.tglstopDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tglstopDateTimePicker.Name = "tglstopDateTimePicker";
            this.tglstopDateTimePicker.Size = new System.Drawing.Size(127, 26);
            this.tglstopDateTimePicker.TabIndex = 23;
            // 
            // remarkTextEdit
            // 
            this.remarkTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.aktBindingSource, "remark", true));
            this.remarkTextEdit.Location = new System.Drawing.Point(146, 405);
            this.remarkTextEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.remarkTextEdit.Name = "remarkTextEdit";
            this.remarkTextEdit.Size = new System.Drawing.Size(428, 26);
            this.remarkTextEdit.TabIndex = 27;
            // 
            // akdBindingSource
            // 
            this.akdBindingSource.DataMember = "akd";
            this.akdBindingSource.DataSource = this.casDataSet;
            // 
            // akdTableAdapter
            // 
            this.akdTableAdapter.ClearBeforeFill = true;
            // 
            // aktTableAdapter
            // 
            this.aktTableAdapter.ClearBeforeFill = true;
            // 
            // accbiayaTextBoxEx
            // 
            this.accbiayaTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.aktBindingSource, "accbiaya", true));
            this.accbiayaTextBoxEx.ExAllowEmptyString = true;
            this.accbiayaTextBoxEx.ExAllowNonDBData = false;
            this.accbiayaTextBoxEx.ExAutoCheck = true;
            this.accbiayaTextBoxEx.ExAutoShowResult = false;
            this.accbiayaTextBoxEx.ExCondition = "";
            this.accbiayaTextBoxEx.ExDialogTitle = "";
            this.accbiayaTextBoxEx.ExFieldName = "acc";
            this.accbiayaTextBoxEx.ExFilterFields = new string[0];
            this.accbiayaTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.accbiayaTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.accbiayaTextBoxEx.ExLabelContainer = null;
            this.accbiayaTextBoxEx.ExLabelField = "name";
            this.accbiayaTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.accbiayaTextBoxEx.ExLabelText = "";
            this.accbiayaTextBoxEx.ExLabelVisible = true;
            this.accbiayaTextBoxEx.ExSelectFields = new string[0];
            this.accbiayaTextBoxEx.ExShowDialog = true;
            this.accbiayaTextBoxEx.ExSimpleMode = true;
            this.accbiayaTextBoxEx.ExSqlInstance = null;
            this.accbiayaTextBoxEx.ExSqlQuery = "select acc,name from acc where detil=1";
            this.accbiayaTextBoxEx.ExTableName = "acc";
            this.accbiayaTextBoxEx.Location = new System.Drawing.Point(146, 369);
            this.accbiayaTextBoxEx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.accbiayaTextBoxEx.Name = "accbiayaTextBoxEx";
            this.accbiayaTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.accbiayaTextBoxEx.Size = new System.Drawing.Size(142, 26);
            this.accbiayaTextBoxEx.TabIndex = 30;
            // 
            // gcakd
            // 
            this.gcakd.BestFitColumn = true;
            this.gcakd.ExAutoSize = false;
            this.gcakd.Location = new System.Drawing.Point(31, 444);
            this.gcakd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gcakd.Name = "gcakd";
            this.gcakd.Size = new System.Drawing.Size(571, 276);
            this.gcakd.TabIndex = 28;
            // 
            // accTextBoxEx
            // 
            this.accTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.aktBindingSource, "acc", true));
            this.accTextBoxEx.ExAllowEmptyString = true;
            this.accTextBoxEx.ExAllowNonDBData = false;
            this.accTextBoxEx.ExAutoCheck = true;
            this.accTextBoxEx.ExAutoShowResult = false;
            this.accTextBoxEx.ExCondition = "";
            this.accTextBoxEx.ExDialogTitle = "";
            this.accTextBoxEx.ExFieldName = "acc";
            this.accTextBoxEx.ExFilterFields = new string[0];
            this.accTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.accTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.accTextBoxEx.ExLabelContainer = null;
            this.accTextBoxEx.ExLabelField = "name";
            this.accTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.accTextBoxEx.ExLabelText = "";
            this.accTextBoxEx.ExLabelVisible = true;
            this.accTextBoxEx.ExSelectFields = new string[0];
            this.accTextBoxEx.ExShowDialog = true;
            this.accTextBoxEx.ExSimpleMode = true;
            this.accTextBoxEx.ExSqlInstance = null;
            this.accTextBoxEx.ExSqlQuery = "select * from acc where detil=1";
            this.accTextBoxEx.ExTableName = "acc";
            this.accTextBoxEx.Location = new System.Drawing.Point(146, 49);
            this.accTextBoxEx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.accTextBoxEx.Name = "accTextBoxEx";
            this.accTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.accTextBoxEx.Size = new System.Drawing.Size(142, 26);
            this.accTextBoxEx.TabIndex = 5;
            // 
            // accsusutTextBoxEx
            // 
            this.accsusutTextBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.aktBindingSource, "accsusut", true));
            this.accsusutTextBoxEx.ExAllowEmptyString = true;
            this.accsusutTextBoxEx.ExAllowNonDBData = false;
            this.accsusutTextBoxEx.ExAutoCheck = true;
            this.accsusutTextBoxEx.ExAutoShowResult = false;
            this.accsusutTextBoxEx.ExCondition = "";
            this.accsusutTextBoxEx.ExDialogTitle = "";
            this.accsusutTextBoxEx.ExFieldName = "acc";
            this.accsusutTextBoxEx.ExFilterFields = new string[0];
            this.accsusutTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.accsusutTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.accsusutTextBoxEx.ExLabelContainer = null;
            this.accsusutTextBoxEx.ExLabelField = "name";
            this.accsusutTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.accsusutTextBoxEx.ExLabelText = "";
            this.accsusutTextBoxEx.ExLabelVisible = true;
            this.accsusutTextBoxEx.ExSelectFields = new string[0];
            this.accsusutTextBoxEx.ExShowDialog = true;
            this.accsusutTextBoxEx.ExSimpleMode = true;
            this.accsusutTextBoxEx.ExSqlInstance = null;
            this.accsusutTextBoxEx.ExSqlQuery = "select acc,name from acc where detil=1";
            this.accsusutTextBoxEx.ExTableName = "acc";
            this.accsusutTextBoxEx.Location = new System.Drawing.Point(146, 329);
            this.accsusutTextBoxEx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.accsusutTextBoxEx.Name = "accsusutTextBoxEx";
            this.accsusutTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.accsusutTextBoxEx.Size = new System.Drawing.Size(142, 26);
            this.accsusutTextBoxEx.TabIndex = 25;
            // 
            // bsaTextBoxEx
            // 
            this.bsaTextBoxEx.Enabled = false;
            this.bsaTextBoxEx.ExAllowEmptyString = true;
            this.bsaTextBoxEx.ExAllowNonDBData = false;
            this.bsaTextBoxEx.ExAutoCheck = true;
            this.bsaTextBoxEx.ExAutoShowResult = false;
            this.bsaTextBoxEx.ExCondition = "";
            this.bsaTextBoxEx.ExDialogTitle = "";
            this.bsaTextBoxEx.ExFieldName = "Kode Area";
            this.bsaTextBoxEx.ExFilterFields = new string[0];
            this.bsaTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.bsaTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.bsaTextBoxEx.ExLabelContainer = null;
            this.bsaTextBoxEx.ExLabelField = "Area";
            this.bsaTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.bsaTextBoxEx.ExLabelText = "";
            this.bsaTextBoxEx.ExLabelVisible = true;
            this.bsaTextBoxEx.ExSelectFields = new string[0];
            this.bsaTextBoxEx.ExShowDialog = true;
            this.bsaTextBoxEx.ExSimpleMode = true;
            this.bsaTextBoxEx.ExSqlInstance = null;
            this.bsaTextBoxEx.ExSqlQuery = "select bsa `Kode Area`, Area from bsa";
            this.bsaTextBoxEx.ExTableName = "bsa";
            this.bsaTextBoxEx.Location = new System.Drawing.Point(690, 14);
            this.bsaTextBoxEx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bsaTextBoxEx.Name = "bsaTextBoxEx";
            this.bsaTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.bsaTextBoxEx.Size = new System.Drawing.Size(122, 26);
            this.bsaTextBoxEx.TabIndex = 140;
            // 
            // unitTextEdit
            // 
            this.unitTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.aktBindingSource, "unit", true));
            this.unitTextEdit.ExAllowEmptyString = true;
            this.unitTextEdit.ExAllowNonDBData = false;
            this.unitTextEdit.ExAutoCheck = true;
            this.unitTextEdit.ExAutoShowResult = false;
            this.unitTextEdit.ExCondition = "";
            this.unitTextEdit.ExDialogTitle = "Data Satuan";
            this.unitTextEdit.ExFieldName = "KODE_SATUAN";
            this.unitTextEdit.ExFilterFields = new string[0];
            this.unitTextEdit.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.unitTextEdit.ExInvalidForeColor = System.Drawing.Color.Black;
            this.unitTextEdit.ExLabelContainer = null;
            this.unitTextEdit.ExLabelField = "URAIAN_SATUAN";
            this.unitTextEdit.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Right;
            this.unitTextEdit.ExLabelText = "";
            this.unitTextEdit.ExLabelVisible = true;
            this.unitTextEdit.ExSelectFields = new string[0];
            this.unitTextEdit.ExShowDialog = true;
            this.unitTextEdit.ExSimpleMode = true;
            this.unitTextEdit.ExSqlInstance = null;
            this.unitTextEdit.ExSqlQuery = "select KODE_SATUAN,URAIAN_SATUAN from tpbdb.referensi_satuan";
            this.unitTextEdit.ExTableName = "referensi_satuan";
            this.unitTextEdit.Location = new System.Drawing.Point(394, 131);
            this.unitTextEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.unitTextEdit.Name = "unitTextEdit";
            this.unitTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.unitTextEdit.Size = new System.Drawing.Size(127, 26);
            this.unitTextEdit.TabIndex = 141;
            // 
            // FrmMasterAktiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(938, 1008);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MasterBindingSource = this.aktBindingSource;
            this.MasterQuery = "select * from akt";
            this.MasterTable = this.casDataSet.akt;
            this.Name = "FrmMasterAktiva";
            this.Load += new System.EventHandler(this.FrmMasterAktiva_Load);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.pnlKey.ResumeLayout(false);
            this.pnlKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumlahSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hargaSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.residuSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokasiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosentaseSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accbiayaTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accsusutTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsaTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private casDataSet casDataSet;
        private System.Windows.Forms.BindingSource aktBindingSource;
        private DevExpress.XtraEditors.TextEdit aktTextEdit;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private KASLibrary.TextBoxEx accTextBoxEx;
        private DevExpress.XtraEditors.SpinEdit jumlahSpinEdit;
        private DevExpress.XtraEditors.SpinEdit hargaSpinEdit;
        private DevExpress.XtraEditors.SpinEdit residuSpinEdit;
        private System.Windows.Forms.DateTimePicker tglbeliDateTimePicker;
        private DevExpress.XtraEditors.TextEdit lokasiTextEdit;
        private DevExpress.XtraEditors.SpinEdit prosentaseSpinEdit;
        private System.Windows.Forms.DateTimePicker tgljualDateTimePicker;
        private System.Windows.Forms.DateTimePicker tglstopDateTimePicker;
        private KASLibrary.TextBoxEx accsusutTextBoxEx;
        private DevExpress.XtraEditors.TextEdit remarkTextEdit;
        private System.Windows.Forms.BindingSource akdBindingSource;
        private CAS.casDataSetTableAdapters.akdTableAdapter akdTableAdapter;
        private KASLibrary.GridControlEx gcakd;
        private KASLibrary.TextBoxEx accbiayaTextBoxEx;
        private CAS.casDataSetTableAdapters.aktTableAdapter aktTableAdapter;
        private KASLibrary.TextBoxEx bsaTextBoxEx;
        private KASLibrary.TextBoxEx unitTextEdit;
    }
}
