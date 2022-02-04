using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using DevExpress.XtraEditors;

namespace KASLibrary
{
    public partial class FrmAppConfig : XtraForm
    {
        Label[] lblKeys;
        TextBox[] textValues;

        public FrmAppConfig()
        {
            InitializeComponent();
        }

        private void FrmAppConfig_Load(object sender, EventArgs e)
        {
            // Open Exe Configuration File
            Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            string[] keys = configFile.AppSettings.Settings.AllKeys;

            lblKeys = new Label[keys.Length];
            textValues = new TextBox[keys.Length];

            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            for(int i=0;i<keys.Length;i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                lblKeys[i] = new Label();
                lblKeys[i].TextAlign = ContentAlignment.MiddleLeft;
                lblKeys[i].Text = keys[i];               
                tableLayoutPanel1.Controls.Add(lblKeys[i]);
                textValues[i] = new TextBox();
                textValues[i].Text = Utility.GetConfig(keys[i]);
                textValues[i].Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                tableLayoutPanel1.Controls.Add(textValues[i]);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lblKeys.Length; i++)
            {
                Utility.SetConfig(lblKeys[i].Text, textValues[i].Text);
            }
            MessageBox.Show("App config saved. Please re-login to apply changes!");
        }
    }
}