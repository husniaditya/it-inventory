using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.Reflection;
using DevExpress.XtraEditors;
using KASLibrary;

namespace CAS.Transaction
{
    public partial class FrmDocFlow : XtraForm
    {
        string m_jurnal;

        public FrmDocFlow(string jurnal)
        {
            InitializeComponent();
            m_jurnal = jurnal;
        }

        private void FrmDocFlow_Load(object sender, EventArgs e)
        {
            try { Utility.ApplySkin(this); }
            catch { }
            string query = "Call SP_DocFlow('" + m_jurnal + "')";
            gcxDoc.ExGridControl.DataSource = DB.sql.Select(query);
            gcxDoc.ExTitleLabel.Text = "Document Flow for " + m_jurnal;
            gcxDoc.ExGridView.MouseDown += new MouseEventHandler(ExGridView_MouseDown);
        }

        void ExGridView_MouseDown(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            
            // obtaining hit info
            GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
            if (e.Button == MouseButtons.Left && e.Clicks == 2 && (hitInfo.InRow) && (!view.IsGroupRow(hitInfo.RowHandle)))
            {
                // switching focus
                view.FocusedRowHandle = hitInfo.RowHandle;

                if (view.FocusedColumn.AbsoluteIndex != 0) return;
                string noJurnal = view.GetFocusedDisplayText();
                //if (noJurnal.IndexOf("-") < 0) return;

                // Open Document Flow for selected Jurnal
                FrmDocFlow frmDoc = new FrmDocFlow(noJurnal);
                frmDoc.MdiParent = this.MdiParent;
                frmDoc.Show();

                // COMMENTED: Open Transaction Form for selected Jurnal
                //DataTable dtMenu = DB.sql.Select("select m.menuid, m.formname from menuid m, modul d where m.menuid=d.menuid and noseri='" + noJurnal.Substring(0,3) + "'");

                //if (dtMenu.Rows.Count == 1)
                //{
                //    string formName = "CAS." + dtMenu.Rows[0]["formname"].ToString();
                //    Form newForm = CreateForm(formName);
                //    if (newForm == null)
                //    {
                //        //MessageBox.Show("Form " + m_formName + " has not been implemented");
                //        return;
                //    }
                //    newForm.Name = dtMenu.Rows[0]["formname"].ToString();
                //    newForm.Tag = dtMenu.Rows[0]["menuid"].ToString();
                //    newForm.MdiParent = this.MdiParent;

                //    if (formName.Contains("Transaction"))
                //        ((Transaction.BaseTransaction)newForm).NoJurnal = noJurnal;
                //    else if (formName.Contains("Master"))
                //        ((Master.BaseMaster)newForm).NoKode = noJurnal;

                //    newForm.Show();
                //}
            }        
        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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