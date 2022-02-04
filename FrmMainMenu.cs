using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using KASLibrary;
using CAS.Master;
using CAS.Transaction;
using System.Reflection;
using DevExpress.XtraBars;

namespace CAS
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
            Program.frmWait = new FrmWait();
        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            try
            {
                LoadLoginForm("Exit");
                if (Utility.GetConfig("WindowsMode") == "Tab") xtraTabbedMdiManager1.MdiParent = this;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void LoadLoginForm(string cancelAction)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
            if (this.MdiChildren.Length > 0) return;

            FrmLogin frmLogin = new FrmLogin();
            Utility.ApplySkin(frmLogin);
            this.Enabled = false;
            CASUser oldUser = DB.casUser;
            DB.acl = null;
            if (frmLogin.ShowDialog(this) == DialogResult.OK)
            {
                if (cancelAction == "Nothing")//User do logout
                {
                    DB.casUser.Logout();
                }
                this.WindowState = FormWindowState.Maximized;
                this.Text = Utility.GetConfig("Title") + " - " + Utility.ToTitleCase(DB.casUser.Name) + " [" +
                    DB.casUser.RoleName + "] - Periode: " + DB.loginDate.ToString("MMM yyyy");

                GenerateMenu();
                FrmHome frmHome = new FrmHome();
                Utility.ApplySkin(frmHome);
                frmHome.MdiParent = this;
                frmHome.Show();
            }
            else
            {
                DB.casUser = oldUser;
                if (cancelAction == "Exit")
                {
                    this.WindowState = FormWindowState.Minimized;
                    Application.Exit(); //Bypass Closing Event Handler that asks for confirmation
                }
            }
            this.Enabled = true;
        }

        private void GenerateMenu()
        {
            // clear BarManager and BarMenu
            barMenu.ItemLinks.Clear();
            barManager1.Items.Clear();

            DB.menuTable = DB.sql.Select("select * from perms, menuid where perms.menuid=menuid.menuid and role='" + DB.casUser.Role + "'");

            bool newGroup = false;

            foreach (DataRow menuRow in DB.menuTable.Rows)
            {                
                string menuId = menuRow["menuid"].ToString();
                string caption = menuRow["caption"].ToString();
                string formName = menuRow["formname"].ToString();

                if (menuRow["select"].ToString() == "False" || menuRow["select"].ToString() == "0") continue;

                if (caption == "\\-")   // separator
                {
                    newGroup = true;
                    continue;
                }

                BarItem subItem = new BarSubItem();

                // Check if opening a form
                if (formName != "")
                {
                    subItem = new BarButtonItem();
                    subItem.Tag = formName;
                    subItem.ItemClick += new ItemClickEventHandler(subItem_ItemClick);
                }
                
                subItem.Name = menuId;
                subItem.Caption = caption;

                // First, add to barManager
                barManager1.Items.Add(subItem);

                if (menuId.Length == 1)
                    barMenu.AddItem(subItem);   // add to BarMenu
                else
                {
                    // add to Parent
                    string parent = menuId.Substring(0, menuId.Length - 1);
                    BarItemLink newItemLink = (barManager1.Items[parent] as BarSubItem).ItemLinks.Add(subItem);
                    newItemLink.BeginGroup = newGroup;
                }

                newGroup = false;
            }

            foreach (BarItem barItem in barManager1.Items)
            {
                if (barItem is BarSubItem)
                    if (((BarSubItem)barItem).ItemLinks.Count == 0 && barItem.Tag == null)
                        barItem.Visibility = BarItemVisibility.OnlyInCustomizing;
            }

            // Add Windows Operations & Windows List Menu
            #region " Windows Menu "
            BarSubItem winMenu = new BarSubItem();
            winMenu.Caption = "Windows";
            barManager1.Items.Add(winMenu);
            barMenu.AddItem(winMenu);

            BarButtonItem tileVerItem = new BarButtonItem();
            tileVerItem.Caption = "Tile &Vertical";
            tileVerItem.ItemClick += new ItemClickEventHandler(windowsItem_ItemClick);
            barManager1.Items.Add(tileVerItem);
            winMenu.ItemLinks.Add(tileVerItem);

            BarButtonItem tileHorItem = new BarButtonItem();
            tileHorItem.Caption = "Tile &Horizontal";
            tileHorItem.ItemClick += new ItemClickEventHandler(windowsItem_ItemClick);
            barManager1.Items.Add(tileHorItem);
            winMenu.ItemLinks.Add(tileHorItem);

            BarButtonItem winCascadeItem = new BarButtonItem();
            winCascadeItem.Caption = "&Cascade";
            winCascadeItem.ItemClick += new ItemClickEventHandler(windowsItem_ItemClick);
            barManager1.Items.Add(winCascadeItem);
            winMenu.ItemLinks.Add(winCascadeItem);

            BarButtonItem winMinimizeItem = new BarButtonItem();
            winMinimizeItem.Caption = "&Minimize All";
            winMinimizeItem.ItemClick += new ItemClickEventHandler(windowsItem_ItemClick);
            barManager1.Items.Add(winMinimizeItem);
            winMenu.ItemLinks.Add(winMinimizeItem);

            BarButtonItem winRestoreItem = new BarButtonItem();
            winRestoreItem.Caption = "&Restore All";
            winRestoreItem.ItemClick += new ItemClickEventHandler(windowsItem_ItemClick);
            barManager1.Items.Add(winRestoreItem);
            winMenu.ItemLinks.Add(winRestoreItem);

            // Add MdiChildrenList MenuItem
            BarMdiChildrenListItem windowsItem = new BarMdiChildrenListItem();
            barManager1.Items.Add(windowsItem);
            winMenu.ItemLinks.Add(windowsItem).BeginGroup = true;
            #endregion
        }

        void windowsItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            switch (((BarButtonItem)e.Item).Caption)
            {
                case "Tile &Vertical":
                    LayoutMdi(MdiLayout.TileVertical);
                    break;
                case "Tile &Horizontal":
                    LayoutMdi(MdiLayout.TileHorizontal);
                    break;
                case "&Cascade":
                    LayoutMdi(MdiLayout.Cascade);
                    break;
                case "&Minimize All":
                    Form[] mdiChildren = this.MdiChildren;
                    foreach (Form mdiForm in mdiChildren)
                        mdiForm.WindowState = FormWindowState.Minimized;
                    break;
                case "&Restore All":
                    Form[] mdiForms = this.MdiChildren;
                    foreach (Form mdiForm in mdiForms)
                        mdiForm.WindowState = FormWindowState.Normal;
                    break;
            }
        }

        void subItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            // special case for LogOut
            if (e.Item.Tag.ToString() == this.Name)
            {
                LoadLoginForm("Exit");
                return;
            }

            string formName = "CAS." + e.Item.Tag;

            // search in opened MdiChildren windows
            foreach (Form frmChild in this.MdiChildren)
            {
                if (frmChild.Tag !=null && frmChild.Tag.ToString() == e.Item.Name)
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
                MessageBox.Show("Form " + e.Item.Caption + " has not been implemented");
                return;
            }
            newForm.Tag = e.Item.Name;
            newForm.Name = e.Item.Tag.ToString();
            newForm.Text = e.Item.Caption;
            newForm.MdiParent = this;
            newForm.Show();
            newForm.KeyPreview = true;
            newForm.KeyDown += new KeyEventHandler(newForm_KeyDown);
        }

        void newForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.W)
            {
                try
                {
                    (sender as Form).Close();
                }
                catch { }
            }
        }

        private void FrmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall) return;
            if (e.Cancel) return;
            if (MessageBox.Show("Are you sure want to quit from the system?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (DB.casUser != null) DB.casUser.Logout();
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
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
