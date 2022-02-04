using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KASLibrary;

namespace CAS
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                    if (DB.acl == null)
                    //DB.acl = new ACL("root", Utility.DecryptTripleDES(Utility.GetConfig("Password"), "Hello World!"));
                    DB.acl = new ACL(txtUsername.Text, txtPassword.Text);
                    //DB.acl = new ACL("root", "database");
            }
            catch (Exception exp)
            {
                MessageBox.Show("Database Connection Error. Please contact your administrator.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnLogin.Enabled = false;

            string status = "";

            DB.casUser = DB.acl.Login(txtUsername.Text, txtPassword.Text, out status);
            if (status == "Logged In")
            {
                //DB.sql = new SQL(txtUsername.Text, txtPassword.Text);
                DB.sql = DB.acl.sql;
                DB.loginDate = dtpLogin.Value.Date;
                DB.loginPeriod = DB.loginDate.ToString("yyMM");   
                this.DialogResult = DialogResult.OK;
                Program.EndWait(this);
            }
            else if (status == "Blocked")
            {
                MessageBox.Show("Your username is blocked. Please contact Admin", "Login Error");
                this.DialogResult = DialogResult.Retry;
            }
            else
            {
                MessageBox.Show("Invalid username and/or password", "Login Error");
                this.DialogResult = DialogResult.Retry;
            }

            btnLogin.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.Retry)
            {
                e.Cancel = true;
            }
        }
    }
}