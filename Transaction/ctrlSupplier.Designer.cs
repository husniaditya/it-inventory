using DevExpress.XtraEditors;
namespace CAS.Transaction
{
    partial class CtrlSub
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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label1;
            this.grpSub = new DevExpress.XtraEditors.GroupControl();
            this.linkToSub = new CAS.linkToForm();
            this.subTextBoxEx = new KASLibrary.TextBoxEx();
            this.txtNPWP = new DevExpress.XtraEditors.TextEdit();
            this.txtKota = new DevExpress.XtraEditors.TextEdit();
            this.txtAlamat = new DevExpress.XtraEditors.TextEdit();
            this.txtNama = new DevExpress.XtraEditors.TextEdit();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grpSub)).BeginInit();
            this.grpSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subTextBoxEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNPWP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKota.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlamat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNama.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(29, 71);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(29, 13);
            label4.TabIndex = 115;
            label4.Text = "Kota";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(19, 48);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(39, 13);
            label3.TabIndex = 114;
            label3.Text = "Alamat";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(21, 93);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(40, 13);
            label1.TabIndex = 115;
            label1.Text = "NPWP";
            // 
            // grpSub
            // 
            this.grpSub.Controls.Add(this.linkToSub);
            this.grpSub.Controls.Add(this.subTextBoxEx);
            this.grpSub.Controls.Add(label1);
            this.grpSub.Controls.Add(label4);
            this.grpSub.Controls.Add(label3);
            this.grpSub.Controls.Add(this.txtNPWP);
            this.grpSub.Controls.Add(this.txtKota);
            this.grpSub.Controls.Add(this.txtAlamat);
            this.grpSub.Controls.Add(this.txtNama);
            this.grpSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSub.Location = new System.Drawing.Point(0, 0);
            this.grpSub.Name = "grpSub";
            this.grpSub.Size = new System.Drawing.Size(335, 115);
            this.grpSub.TabIndex = 0;
            this.grpSub.Text = "Supplier/Customer";
            // 
            // linkToSub
            // 
            this.linkToSub.AutoSize = true;
            this.linkToSub.FormName = "MasterSupplier";
            this.linkToSub.Location = new System.Drawing.Point(26, 25);
            this.linkToSub.Name = "linkToSub";
            this.linkToSub.Size = new System.Drawing.Size(32, 13);
            this.linkToSub.TabIndex = 117;
            this.linkToSub.TabStop = true;
            this.linkToSub.Text = "Kode";
            this.linkToSub.TxtKode = this.subTextBoxEx;
            // 
            // subTextBoxEx
            // 
            this.subTextBoxEx.ExAllowEmptyString = true;
            this.subTextBoxEx.ExAllowNonDBData = false;
            this.subTextBoxEx.ExAutoCheck = true;
            this.subTextBoxEx.ExAutoShowResult = false;
            this.subTextBoxEx.ExCondition = "group_=1";
            this.subTextBoxEx.ExDialogTitle = "Supplier";
            this.subTextBoxEx.ExFieldName = "Kode";
            this.subTextBoxEx.ExFilterFields = new string[0];
            this.subTextBoxEx.ExInvalidBackColor = System.Drawing.Color.Yellow;
            this.subTextBoxEx.ExInvalidForeColor = System.Drawing.Color.Black;
            this.subTextBoxEx.ExLabelContainer = null;
            this.subTextBoxEx.ExLabelField = "";
            this.subTextBoxEx.ExLabelLocation = KASLibrary.TextBoxEx.LabelLocation.Bottom;
            this.subTextBoxEx.ExLabelText = "";
            this.subTextBoxEx.ExLabelVisible = false;
            this.subTextBoxEx.ExSelectFields = new string[0];
            this.subTextBoxEx.ExShowDialog = true;
            this.subTextBoxEx.ExSimpleMode = true;
            this.subTextBoxEx.ExSqlInstance = null;
            this.subTextBoxEx.ExSqlQuery = "";
            this.subTextBoxEx.ExTableName = "sub";
            this.subTextBoxEx.Location = new System.Drawing.Point(64, 21);
            this.subTextBoxEx.Name = "subTextBoxEx";
            this.subTextBoxEx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.subTextBoxEx.Size = new System.Drawing.Size(81, 20);
            this.subTextBoxEx.TabIndex = 116;
            this.subTextBoxEx.EditValueChanged += new System.EventHandler(this.subTextBoxEx_EditValueChanged);
            // 
            // txtNPWP
            // 
            this.txtNPWP.Location = new System.Drawing.Point(64, 90);
            this.txtNPWP.Name = "txtNPWP";
            this.txtNPWP.Size = new System.Drawing.Size(156, 20);
            this.txtNPWP.TabIndex = 112;
            this.txtNPWP.Tag = "ReadOnly";
            // 
            // txtKota
            // 
            this.txtKota.Location = new System.Drawing.Point(64, 67);
            this.txtKota.Name = "txtKota";
            this.txtKota.Size = new System.Drawing.Size(156, 20);
            this.txtKota.TabIndex = 112;
            this.txtKota.Tag = "ReadOnly";
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(64, 44);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(263, 20);
            this.txtAlamat.TabIndex = 111;
            this.txtAlamat.Tag = "ReadOnly";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(146, 21);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(181, 20);
            this.txtNama.TabIndex = 110;
            this.txtNama.Tag = "ReadOnly";
            // 
            // CtrlSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpSub);
            this.Name = "CtrlSub";
            this.Size = new System.Drawing.Size(335, 115);
            ((System.ComponentModel.ISupportInitialize)(this.grpSub)).EndInit();
            this.grpSub.ResumeLayout(false);
            this.grpSub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subTextBoxEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNPWP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKota.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlamat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNama.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TextEdit txtKota;
        private TextEdit txtAlamat;
        private TextEdit txtNama;
        protected KASLibrary.TextBoxEx subTextBoxEx;
        protected DevExpress.XtraEditors.GroupControl grpSub;
        private linkToForm linkToSub;
        private TextEdit txtNPWP;
    }
}
