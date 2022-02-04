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

namespace CAS.Fungsi
{
    public partial class FrmUser : XtraForm
    {
        public enum Mode { Edit, View, New };
        private Mode mode;
        private MySqlDataAdapter daRole = null;
        private MySqlDataAdapter daUser = null;
        private DataTable dtRole = null;
        private string pass = "";
        
        public FrmUser()
        {
            InitializeComponent();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            if (DB.sql == null) return;

            try
            {
                PopulateUsrLevel();
                if (this.Tag.ToString() == "18")        // Change Password Form
                {
                    setMode(Mode.Edit);
                    ludRole.Visible = txtName.Visible = roleLabel.Visible = nameLabel.Visible = false;
                    tsbtnDelete.Enabled = false;
                    usrGridControl.Top = MasterNavigator.Bottom + 10;
                    usrGridControl.Height = 100;
                    this.Height = usrGridControl.Bottom + 50;
                    cardView1.FocusedRowHandle = usrBindingSource.Find("user", DB.casUser.User);
                    cardView1.SetFocusedRowCellValue(cardView1.Columns["chusr"], DB.casUser.User);
                    cardView1.SetFocusedRowCellValue(cardView1.Columns["chtime"], DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                    cardView1.FocusedColumn = cardView1.Columns["user"];
                    cardView1.ShowEditor();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            setMode(Mode.View);
        }

        private void PopulateUsrLevel()
        {
            casDataSet.usrlevel.Clear();
            daRole = DB.sql.SelectAdapter("select * from usrlevel");
            daRole.Fill(casDataSet.usrlevel);
            DataRow allRow = casDataSet.usrlevel.NewRow();
            allRow[0] = "ALL";
            allRow[1] = "ALL";
            casDataSet.usrlevel.Rows.InsertAt(allRow, 0);
            dtRole = new DataTable();
            daRole.Fill(dtRole);
            repludRole.DataSource = dtRole;
            ludRole.Properties.PopupWidth = 200;
            ludRole.Properties.BestFit();
            ludRole.ItemIndex = 0;
        }

        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            setMode(Mode.Edit);
            cardView1.FocusedRowHandle = gridView1.FocusedRowHandle;
            cardView1.SetFocusedRowCellValue(cardView1.Columns["chusr"], DB.casUser.User);
            cardView1.SetFocusedRowCellValue(cardView1.Columns["chtime"], DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            cardView1.FocusedColumn = cardView1.Columns["user"];
            cardView1.ShowEditor();
        }

        private void tsbtnCancel_Click(object sender, EventArgs e)
        {
            casDataSet.usr.RejectChanges();
            usrBindingSource.CancelEdit();
            if (this.Tag.ToString() == "18")        // Change Password Form
            {
                this.Close();
                return;
            }
            setMode(Mode.View);
        }

        private void tsbtnNew_Click(object sender, EventArgs e)
        {
            setMode(Mode.New);
            cardView1.AddNewRow();
            cardView1.SetFocusedRowCellValue(cardView1.Columns["role"], ludRole.EditValue);
            cardView1.SetFocusedRowCellValue(cardView1.Columns["chusr"], DB.casUser.User);
            cardView1.SetFocusedRowCellValue(cardView1.Columns["chtime"], DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            cardView1.FocusedColumn = cardView1.Columns["user"];
            cardView1.ShowEditor();
        }

        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            // Validate controls
            this.ValidateChildren();

            string user = cardView1.GetFocusedRowCellValue("user").ToString();
            string name = cardView1.GetFocusedRowCellValue("name").ToString();
            string role = cardView1.GetFocusedRowCellValue("role").ToString();

            if (mode == Mode.New)
            {
                // new row
                if (pass == "")
                {
                    MessageBox.Show("Please input password!");
                    return;
                }
    
                // check if user exists in database
                {
                    try
                    {
                        // create new user
                        DB.acl.CreateUser(user, pass, name, role);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
            }
            else if (pass != "")
            {
                // Change password
                if (MessageBox.Show("Are you sure you want to change the password of user " + user + "?", "Confirmation",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                     == DialogResult.Yes)
                {
                    CASUser casUser = DB.acl.GetUser(user);
                    casUser.ChangePassword(pass);
                }
                else
                {
                    cardView1.FocusedColumn = cardView1.Columns["password"];
                    cardView1.ShowEditor();
                    return;
                }
            }
            usrBindingSource.EndEdit();
            daUser.Update(casDataSet.usr);
            if (this.Tag.ToString() == "18")        // Change Password Form
            {
                this.Close();
                return;
            }
            setMode(Mode.View);
            PopulateGCUser();
        }

        private void setMode(Mode newMode)
        {
            this.mode = newMode;
            switch (newMode)
            {
                case Mode.New:
                case Mode.Edit:
                    tsbtnSave.Enabled = true;
                    tsbtnCancel.Enabled = true;
                    tsbtnEdit.Enabled = false;
                    tsbtnNew.Enabled = false;
                    usrGridControl.MainView = cardView1;
                    pass = "";
                    break;
                case Mode.View:
                    tsbtnSave.Enabled = false;
                    tsbtnCancel.Enabled = false;
                    tsbtnNew.Enabled = true;
                    tsbtnEdit.Enabled = true;
                    usrGridControl.MainView = gridView1;
                    break;
            }
        }

        private void ludRole_EditValueChanged(object sender, EventArgs e)
        {
            if (ludRole.ItemIndex < 0) return;
            PopulateGCUser();
        }

        private void PopulateGCUser()
        {
            txtName.EditValue = casDataSet.usrlevel.Rows[ludRole.ItemIndex]["name"];
            casDataSet.usr.Clear();
            string query = "select * from usr";
            if (ludRole.Text != "ALL") query += " where role='" + ludRole.EditValue + "'";
            daUser = DB.sql.SelectAdapter(query);
            daUser.Fill(casDataSet.usr);
        }

        private void cardView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "password" && e.IsGetData)
                e.Value = pass;
            if (e.Column.FieldName == "password" && e.IsSetData)
                pass = (string)e.Value;
        }

        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount == 0) return;
            string user = gridView1.GetDataRow(gridView1.GetSelectedRows()[0])["user"].ToString();
            if (MessageBox.Show("Are you sure you want to delete user " + user + "?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                    == DialogResult.Yes)
            {
                DB.acl.DeleteUser(user);
            }
            PopulateGCUser();
        }
    }
}