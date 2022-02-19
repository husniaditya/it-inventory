using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Reflection;
using KASLibrary;
using DevExpress.LookAndFeel;

namespace CAS
{
    public partial class FrmHome : XtraForm
    {
        DataTable menuTable;

        public FrmHome()
        {
            InitializeComponent();

            menuTable = DB.sql.Select("select * from perms, menuid where perms.menuid=menuid.menuid and role='" + DB.casUser.Role + "'");
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            lblCompanyName.Text = Utility.GetConfig("Appname");
            lblCompanyAddr.Text = Utility.GetConfig("Slogan");
            lblCopyright.Text = Utility.GetConfig("Copyright");
            foreach(Control control in this.Controls)
                GenerateMenu(control);
            //pnlNotes.FloatForm.Top = this.Bottom - pnlNotes.Height;
            //pnlNotes.FloatForm.Left = this.Right - 10 - pnlNotes.Width;
            //pnlNotes.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
        }

        private void GenerateMenu(Control control)
        {
            if (control is SimpleButton)
            {
                SimpleButton button = control as SimpleButton;
                string menuId = button.Name.Replace("btn", "");
                DataRow[] menuRows = menuTable.Select("menuid='" + menuId + "'");
                if (menuRows.Length == 0)
                {
                    button.Visible = false;
                    return;
                }
                button.Text = menuRows[0]["caption"].ToString();
                button.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                button.Tag = menuRows[0]["formname"].ToString();
                if (menuRows[0]["select"].ToString() == "0" || menuRows[0]["select"].ToString() == "False") button.Visible = false;
                button.Click += new EventHandler(button_Click);
            }
            else if (control.Controls.Count > 0)
            {
                foreach (Control ctrl in control.Controls)
                {
                    GenerateMenu(ctrl);
                }
            }   
        }

        void button_Click(object sender, EventArgs e)
        {
            SimpleButton button = sender as SimpleButton;
            string formName = "CAS." + button.Tag.ToString();

            // search in opened MdiChildren windows
            foreach (Form frmChild in this.MdiParent.MdiChildren)
            {
                if (frmChild.Tag != null && frmChild.Tag.ToString() == button.Name.Replace("btn",""))
                //if (formName.EndsWith(frmChild.Name))
                {
                    frmChild.WindowState = FormWindowState.Normal;
                    frmChild.BringToFront();
                    return;
                }
            }

            Form newForm = CreateForm(formName);
            if (newForm == null)
            {
                MessageBox.Show("Form " + button.Text + " has not been implemented");
                return;
            }
            newForm.Tag = button.Name.Replace("btn","");
            newForm.Name = button.Tag.ToString();
            newForm.Text = button.Text;
            newForm.MdiParent = this.MdiParent;
            newForm.Show(); 
            newForm.KeyPreview = true;
            newForm.KeyUp += new KeyEventHandler(newForm_KeyUp);
        }

        void newForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.W)
            {
                try
                {
                    (sender as Form).Focus();
                    (sender as Form).Close();
                    e.Handled = true;
                }
                catch { }
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

        private void lblStyle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmStyle frmStyle = new FrmStyle();
            //frmStyle.MdiParent = this.MdiParent;
            frmStyle.ShowDialog();

            // apply Skin Style
            foreach (Form frmChild in this.MdiParent.MdiChildren)
            {
                if (frmChild is ISupportLookAndFeel)
                    Utility.ApplySkin((ISupportLookAndFeel)frmChild);
            }
        }      

        private void linkNotes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlNotes.Show();
        }

        private void pnlNotes_ClosingPanel(object sender, DevExpress.XtraBars.Docking.DockPanelCancelEventArgs e)
        {
            pnlNotes.Hide();
            e.Cancel = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}