using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.Reflection;
using DevExpress.XtraEditors;
using KASLibrary;

namespace CAS.Laporan
{
    /// <summary>
    /// Summary description for GridReport.
    /// </summary>
    public class GridReport : XtraForm
    {
        string m_query;
        private GridControlEx gcxDoc;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public GridReport(string query)
        {
            InitializeComponent();
            m_query = query;
        }

        

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.gcxDoc = new KASLibrary.GridControlEx();
            this.SuspendLayout();
            // 
            // gcxDoc
            // 
            this.gcxDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcxDoc.BestFitColumn = true;
            this.gcxDoc.ExAutoSize = false;
            this.gcxDoc.Location = new System.Drawing.Point(25, 11);
            this.gcxDoc.Name = "gcxDoc";
            this.gcxDoc.Size = new System.Drawing.Size(639, 271);
            this.gcxDoc.TabIndex = 3;
            // 
            // GridReport
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(695, 292);
            this.Controls.Add(this.gcxDoc);
            this.Name = "GridReport";
            this.Text = "GridReport";
            this.Load += new System.EventHandler(this.GridReport_Load);
            this.ResumeLayout(false);

        }
        #endregion

        private void GridReport_Load(object sender, EventArgs e)
        {
            try { Utility.ApplySkin(this); }
            catch { }
            string query = m_query;
            gcxDoc.ExGridControl.DataSource = DB.sql.Select(query);
            gcxDoc.ExTitleLabel.Text = "List MO";
        }

        public Form CreateForm(string formName)
        {
            Type frmType = Assembly.GetExecutingAssembly().GetType(formName);

            if (frmType != null)
                return (Form)Activator.CreateInstance(frmType);
            else
                return null;
        }
    }
}

