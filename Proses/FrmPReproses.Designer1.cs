namespace CAS.Proses
{
    partial class FrmPReproses
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
            this.chkProsesUlang = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkTutupBulan = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkCekError = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkReclass = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tsbtnProses = new DevExpress.XtraEditors.SimpleButton();
            this.tsbtnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.lbwait = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkPenyusutan = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.checkstock = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkrhp = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkProsesUlang
            // 
            this.chkProsesUlang.AutoSize = true;
            this.chkProsesUlang.Location = new System.Drawing.Point(31, 12);
            this.chkProsesUlang.Name = "chkProsesUlang";
            this.chkProsesUlang.Size = new System.Drawing.Size(168, 17);
            this.chkProsesUlang.TabIndex = 2;
            this.chkProsesUlang.Text = "Proses Ulang Data Periode Ini";
            this.chkProsesUlang.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(50, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Proses ini akan melakukan perhitungan ulang semua transaksi yang terjadi pada per" +
                "iode ini";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkTutupBulan
            // 
            this.chkTutupBulan.AutoSize = true;
            this.chkTutupBulan.Location = new System.Drawing.Point(31, 155);
            this.chkTutupBulan.Name = "chkTutupBulan";
            this.chkTutupBulan.Size = new System.Drawing.Size(137, 17);
            this.chkTutupBulan.TabIndex = 4;
            this.chkTutupBulan.Text = "Tutup Bulan Periode Ini";
            this.chkTutupBulan.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(50, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "Proses ini akan memindahkan saldo akhir periode ini sebagai saldo awal periode be" +
                "rikutnya";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkCekError
            // 
            this.chkCekError.AutoSize = true;
            this.chkCekError.Location = new System.Drawing.Point(31, 223);
            this.chkCekError.Name = "chkCekError";
            this.chkCekError.Size = new System.Drawing.Size(97, 17);
            this.chkCekError.TabIndex = 6;
            this.chkCekError.Text = "Cek Data Error";
            this.chkCekError.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(50, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "Proses ini akan mengevaluasi apakah terjadi kesalahan entri data master maupun da" +
                "ta transaksi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkReclass
            // 
            this.chkReclass.AutoSize = true;
            this.chkReclass.Location = new System.Drawing.Point(31, 292);
            this.chkReclass.Name = "chkReclass";
            this.chkReclass.Size = new System.Drawing.Size(162, 17);
            this.chkReclass.TabIndex = 8;
            this.chkReclass.Text = "Reclass HPPR Ke Persediaan";
            this.chkReclass.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(50, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 39);
            this.label4.TabIndex = 9;
            this.label4.Text = "Proses ini akan membalik HPPR ke Persediaan Barang Jadi";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsbtnProses
            // 
            this.tsbtnProses.Location = new System.Drawing.Point(79, 438);
            this.tsbtnProses.Name = "tsbtnProses";
            this.tsbtnProses.Size = new System.Drawing.Size(75, 23);
            this.tsbtnProses.TabIndex = 10;
            this.tsbtnProses.Text = "&Proses";
            this.tsbtnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // tsbtnCancel
            // 
            this.tsbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.tsbtnCancel.Location = new System.Drawing.Point(191, 438);
            this.tsbtnCancel.Name = "tsbtnCancel";
            this.tsbtnCancel.Size = new System.Drawing.Size(75, 23);
            this.tsbtnCancel.TabIndex = 11;
            this.tsbtnCancel.Text = "&Cancel";
            this.tsbtnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbwait
            // 
            this.lbwait.AutoSize = true;
            this.lbwait.BackColor = System.Drawing.Color.Pink;
            this.lbwait.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbwait.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbwait.Location = new System.Drawing.Point(355, 145);
            this.lbwait.Name = "lbwait";
            this.lbwait.Size = new System.Drawing.Size(70, 28);
            this.lbwait.TabIndex = 12;
            this.lbwait.Text = "WAIT";
            this.lbwait.Visible = false;
            this.lbwait.Click += new System.EventHandler(this.lbwait_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(50, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 39);
            this.label5.TabIndex = 16;
            this.label5.Text = "Proses ini akan melakukan penyusutan aktiva sesuai dengan nilai pada master aktiv" +
                "a";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkPenyusutan
            // 
            this.chkPenyusutan.AutoSize = true;
            this.chkPenyusutan.Location = new System.Drawing.Point(31, 363);
            this.chkPenyusutan.Name = "chkPenyusutan";
            this.chkPenyusutan.Size = new System.Drawing.Size(87, 17);
            this.chkPenyusutan.TabIndex = 15;
            this.chkPenyusutan.Text = "Fixed Assets";
            this.chkPenyusutan.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 495);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(507, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.AutoToolTip = true;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.RightToLeftLayout = true;
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoToolTip = true;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(65, 17);
            this.toolStripStatusLabel1.Text = "Procentase";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(69, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Proses Ulang Jurnal dan persediaan bulan ini";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // checkstock
            // 
            this.checkstock.AutoSize = true;
            this.checkstock.Location = new System.Drawing.Point(50, 74);
            this.checkstock.Name = "checkstock";
            this.checkstock.Size = new System.Drawing.Size(186, 17);
            this.checkstock.TabIndex = 18;
            this.checkstock.Text = "Proses Ulang Persediaan Bulan ini";
            this.checkstock.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(69, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(252, 19);
            this.label7.TabIndex = 21;
            this.label7.Text = "Proses Ulang Jurnal dan persediaan bulan ini";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkrhp
            // 
            this.checkrhp.AutoSize = true;
            this.checkrhp.Location = new System.Drawing.Point(50, 116);
            this.checkrhp.Name = "checkrhp";
            this.checkrhp.Size = new System.Drawing.Size(178, 17);
            this.checkrhp.TabIndex = 20;
            this.checkrhp.Text = "Proses Register Hutang Piutang";
            this.checkrhp.UseVisualStyleBackColor = true;
            // 
            // FrmPReproses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 517);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkrhp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkstock);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkPenyusutan);
            this.Controls.Add(this.lbwait);
            this.Controls.Add(this.tsbtnCancel);
            this.Controls.Add(this.tsbtnProses);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkReclass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkCekError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkTutupBulan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkProsesUlang);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPReproses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reproses";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkProsesUlang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkTutupBulan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkCekError;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkReclass;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton tsbtnProses;
        private DevExpress.XtraEditors.SimpleButton tsbtnCancel;
        private System.Windows.Forms.Label lbwait;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkPenyusutan;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkstock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkrhp;
    }
}