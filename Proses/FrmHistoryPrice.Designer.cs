namespace CAS.Proses
{
    partial class FrmHistoryPrice
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
            this.gcHistory = new KASLibrary.GridControlEx();
            this.SuspendLayout();
            // 
            // gcHistory
            // 
            this.gcHistory.BestFitColumn = true;
            this.gcHistory.ExAutoSize = false;
            this.gcHistory.Location = new System.Drawing.Point(12, 12);
            this.gcHistory.Name = "gcHistory";
            this.gcHistory.Size = new System.Drawing.Size(950, 272);
            this.gcHistory.TabIndex = 0;
            this.gcHistory.Load += new System.EventHandler(this.gcHistory_Load);
            // 
            // FrmHistoryPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 308);
            this.Controls.Add(this.gcHistory);
            this.Name = "FrmHistoryPrice";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.gcHistory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private KASLibrary.GridControlEx gcHistory;
    }
}