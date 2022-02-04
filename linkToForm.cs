using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace CAS
{
    public partial class linkToForm : LinkLabel
    {
        private string m_formName;
        private Control m_txtKode;

        public string FormName
        {
            set { m_formName = value; }
            get { return m_formName; }
        }

        public Control TxtKode
        {
            set { m_txtKode = value; }
            get { return m_txtKode; }
        }

        public linkToForm()
        {
            InitializeComponent();
        }

        private void linkToForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (m_txtKode.Text == "") return;

            DataTable dtMenu = null;
            if (m_formName == "")
                // get Transaction Form from NoSeri
                dtMenu = DB.sql.Select("select m.menuid, m.formname from menuid m, modul d where m.menuid=d.menuid and noseri='" + TxtKode.Text.Substring(0, 3) + "'");
            else
                dtMenu = DB.sql.Select("select menuid, formname from menuid where formname like '%" + m_formName + "'");
            
            //cek permission
            DataRow dr = DB.menuTable.Select("menuid='" + dtMenu.Rows[0]["menuid"] + "'")[0];          

            if ((dr["select"].ToString() == "True" || dr["select"].ToString() == "1") && dtMenu.Rows.Count == 1)
            {
                string formName = "CAS." + dtMenu.Rows[0]["formname"].ToString();
                Form newForm = CreateForm(formName);
                if (newForm == null)
                {
                    //MessageBox.Show("Form " + m_formName + " has not been implemented");
                    return;
                }
                newForm.Name = dtMenu.Rows[0]["formname"].ToString();
                newForm.Tag = dtMenu.Rows[0]["menuid"].ToString();
                newForm.MdiParent = this.FindForm().MdiParent;

                if (formName.Contains("Transaction"))
                    ((Transaction.BaseTransaction)newForm).NoJurnal = m_txtKode.Text;
                else if (formName.Contains("Master"))
                    ((Master.BaseMaster)newForm).NoKode = m_txtKode.Text;

                newForm.Show();
            }
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
