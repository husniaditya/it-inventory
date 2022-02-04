namespace KASLibrary
{
    partial class FrmTextReportViewer
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
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.txtPage = new System.Windows.Forms.NumericUpDown();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblPage = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.pnlDocument = new System.Windows.Forms.Panel();
            this.pctDocument = new System.Windows.Forms.PictureBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPage)).BeginInit();
            this.pnlDocument.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctDocument)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.btnFind);
            this.pnlControls.Controls.Add(this.txtFind);
            this.pnlControls.Controls.Add(this.btnExport);
            this.pnlControls.Controls.Add(this.txtPage);
            this.pnlControls.Controls.Add(this.btnPrint);
            this.pnlControls.Controls.Add(this.btnLastPage);
            this.pnlControls.Controls.Add(this.btnNext);
            this.pnlControls.Controls.Add(this.lblPage);
            this.pnlControls.Controls.Add(this.btnPrevious);
            this.pnlControls.Controls.Add(this.btnFirstPage);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControls.Location = new System.Drawing.Point(0, 714);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(997, 28);
            this.pnlControls.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(540, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(82, 24);
            this.btnExport.TabIndex = 52;
            this.btnExport.Text = "&Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // txtPage
            // 
            this.txtPage.Location = new System.Drawing.Point(173, 5);
            this.txtPage.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(53, 20);
            this.txtPage.TabIndex = 51;
            this.txtPage.ValueChanged += new System.EventHandler(this.txtPage_ValueChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(458, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(82, 24);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.Location = new System.Drawing.Point(376, 4);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(82, 24);
            this.btnLastPage.TabIndex = 2;
            this.btnLastPage.Text = "Last Page";
            this.btnLastPage.UseVisualStyleBackColor = true;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(293, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(82, 24);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(232, 10);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(18, 13);
            this.lblPage.TabIndex = 3;
            this.lblPage.Text = "/0";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(85, 4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(82, 24);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Location = new System.Drawing.Point(3, 4);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(82, 24);
            this.btnFirstPage.TabIndex = 0;
            this.btnFirstPage.Text = "First Page";
            this.btnFirstPage.UseVisualStyleBackColor = true;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // pnlDocument
            // 
            this.pnlDocument.Controls.Add(this.pctDocument);
            this.pnlDocument.Location = new System.Drawing.Point(0, 0);
            this.pnlDocument.Name = "pnlDocument";
            this.pnlDocument.Size = new System.Drawing.Size(979, 693);
            this.pnlDocument.TabIndex = 1;
            // 
            // pctDocument
            // 
            this.pctDocument.Location = new System.Drawing.Point(120, 186);
            this.pctDocument.Name = "pctDocument";
            this.pctDocument.Size = new System.Drawing.Size(106, 87);
            this.pctDocument.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctDocument.TabIndex = 0;
            this.pctDocument.TabStop = false;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.LargeChange = 50;
            this.vScrollBar1.Location = new System.Drawing.Point(982, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(15, 696);
            this.vScrollBar1.SmallChange = 10;
            this.vScrollBar1.TabIndex = 47;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 50;
            this.hScrollBar1.Location = new System.Drawing.Point(0, 696);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(997, 15);
            this.hScrollBar1.SmallChange = 10;
            this.hScrollBar1.TabIndex = 48;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(628, 6);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(137, 20);
            this.txtFind.TabIndex = 53;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(771, 4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(82, 24);
            this.btnFind.TabIndex = 54;
            this.btnFind.Text = "&Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // FrmTextReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 742);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.pnlDocument);
            this.Controls.Add(this.pnlControls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmTextReportViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Report Viewer";
            this.TopMost = true;
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPage)).EndInit();
            this.pnlDocument.ResumeLayout(false);
            this.pnlDocument.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctDocument)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel pnlDocument;
        private System.Windows.Forms.PictureBox pctDocument;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.NumericUpDown txtPage;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFind;
    }
}