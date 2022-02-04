using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using DevExpress.XtraNavBar.ViewInfo;  
using KASLibrary;

namespace KASLibrary
{
    public partial class FrmStyle : XtraForm
    {
        private NavBarControl navBarControl;
        private string view;
        private string skin;

        public FrmStyle(NavBarControl navBarControl)
        {
            InitializeComponent();
            this.navBarControl = navBarControl;
            view = Utility.GetConfig("View");
            for (int i = 0; i < navBarControl.AvailableNavBarViews.Count; i++)
            {
                cboView.Items.Add(navBarControl.AvailableNavBarViews[i]);
                if (view == navBarControl.AvailableNavBarViews[i].ViewName)
                    cboView.SelectedIndex = i; 
            }

            skin = Utility.GetConfig("Skin");
            cboSkin.SelectedItem = skin; 
        }

        public FrmStyle()
        {
            InitializeComponent();
            view = Utility.GetConfig("View");
            label1.Visible = false;
            cboView.Visible = false;
            skin = Utility.GetConfig("Skin");
            cboSkin.SelectedItem = skin;
        }

        private void cboView_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utility.SetConfig("View", ((BaseViewInfoRegistrator)cboView.Items[cboView.SelectedIndex]).ViewName);
            Utility.ApplyView(navBarControl);   
        }

        private void cboSkin_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utility.SetConfig("Skin",cboSkin.SelectedItem.ToString());
            Utility.ApplySkin(this);
            if (this.MdiParent != null)
            {
                try
                {
                    Utility.ApplySkin((XtraForm)this.MdiParent);
                }
                catch { }
                for (int i = 0; i < this.MdiParent.MdiChildren.Length; i++)
                {
                    try
                    {
                        Utility.ApplySkin((XtraForm)this.MdiParent.MdiChildren[i]);
                    }
                    catch { }
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Utility.SetConfig("View", view);
            Utility.SetConfig("Skin", skin);
            if (navBarControl != null)
                Utility.ApplyView(navBarControl);
            Utility.ApplySkin(this);
            if (this.MdiParent != null)
            {
                for (int i = 0; i < this.MdiParent.MdiChildren.Length; i++)
                {
                    try
                    {
                        Utility.ApplySkin((XtraForm)this.MdiParent.MdiChildren[i]);
                    }
                    catch { }
                }
            }
            this.Close(); 
        }
    }
}