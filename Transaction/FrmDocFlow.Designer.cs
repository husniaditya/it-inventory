namespace CAS.Transaction
{
    partial class FrmDocFlow
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
            this.gcxDoc = new KASLibrary.GridControlEx();
            this.SuspendLayout();
            // 
            // tsbtnClose
            // 
            this.tsbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tsbtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.tsbtnClose.Location = new System.Drawing.Point(524, 286);
            this.tsbtnClose.Name = "tsbtnClose";
            this.tsbtnClose.Size = new System.Drawing.Size(75, 23);
            this.tsbtnClose.TabIndex = 3;
            this.tsbtnClose.Text = "&Close";
            this.tsbtnClose.Click += new System.EventHandler(this.tsbtnClose_Click);
            // 
            // gcxDoc
            // 
            this.gcxDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcxDoc.BestFitColumn = true;
            this.gcxDoc.ExAutoSize = false;
            this.gcxDoc.Location = new System.Drawing.Point(12, 7);
            this.gcxDoc.Name = "gcxDoc";
            this.gcxDoc.Size = new System.Drawing.Size(587, 271);
            this.gcxDoc.TabIndex = 2;
            // 
            // FrmDocFlow
            // 
            this.AcceptButton = this.tsbtnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.tsbtnClose;
            this.ClientSize = new System.Drawing.Size(611, 317);
            this.Controls.Add(this.tsbtnClose);
            this.Controls.Add(this.gcxDoc);
            this.Name = "FrmDocFlow";
            this.ShowInTaskbar = false;
            this.Text = "Document Flow";
            this.Load += new System.EventHandler(this.FrmDocFlow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton tsbtnClose;
        private KASLibrary.GridControlEx gcxDoc;
    }
}