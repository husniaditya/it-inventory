using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using KASLibrary;
using DevExpress.XtraEditors;

namespace CAS
{
    public partial class PassOto : Form
    {
        public PassOto()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = DB.sql.Select("SELECT usr.* FROM usr,usrlevel where usr.role=usrlevel.role and otolevel_=1 and trim(user) ='" + txtUsername.Text.Trim() + "'");
            if (dt.Rows.Count == 0)
                MessageBox.Show("User anda belum terdaftar atau tidak diperkenankan");
            else
                if (txtPassword.Text.Trim() == dt.Rows[0]["pswd"].ToString() && txtPassword.Text.Trim() != "")
                {
          //          MessageBox.Show("password benar");
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Password anda salah");
     
      
                 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}