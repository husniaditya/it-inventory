namespace CAS.Transaction
{
    partial class FrmJurnal
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
            this.tsbtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.gcxAcd = new KASLibrary.GridControlEx();
            this.SuspendLayout();
            // 
            // tsbtnClose
            // 
            this.tsbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tsbtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.tsbtnClose.Location = new System.Drawing.Point(786, 438);
            this.tsbtnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tsbtnClose.Name = "tsbtnClose";
            this.tsbtnClose.Size = new System.Drawing.Size(112, 35);
            this.tsbtnClose.TabIndex = 1;
            this.tsbtnClose.Text = "&Close";
            this.tsbtnClose.Click += new System.EventHandler(this.tsbtnClose_Click);
            // 
            // gcxAcd
            // 
            this.gcxAcd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcxAcd.BestFitColumn = true;
            this.gcxAcd.ExAutoSize = false;
            this.gcxAcd.Location = new System.Drawing.Point(18, 9);
            this.gcxAcd.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.gcxAcd.Name = "gcxAcd";
            this.gcxAcd.Size = new System.Drawing.Size(880, 417);
            this.gcxAcd.TabIndex = 0;
            // 
            // FrmJurnal
            // 
            this.AcceptButton = this.tsbtnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.tsbtnClose;
            this.ClientSize = new System.Drawing.Size(916, 488);
            this.Controls.Add(this.tsbtnClose);
            this.Controls.Add(this.gcxAcd);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmJurnal";
            this.ShowInTaskbar = false;
            this.Text = "Jurnal";
            this.Load += new System.EventHandler(this.FrmJurnal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private KASLibrary.GridControlEx gcxAcd;
        private DevExpress.XtraEditors.SimpleButton tsbtnClose;
    }
}