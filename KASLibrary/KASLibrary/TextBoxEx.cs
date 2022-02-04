using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace KASLibrary
{

    public partial class TextBoxEx : ButtonEdit
    {
        public enum LabelLocation { Bottom, Right };

        private Label m_Label;
        private string m_LabelField;
        private bool m_LabelVisible;
        private LabelLocation m_LabelLocation;
        private Control m_LabelContainer;

        private bool m_ShowDialog;
        private string m_TableName;
        private string m_FieldName;
        private string m_DialogTitle;
        private string[] m_SelectFields;
        private string[] m_FilterFields;
        private string m_Condition;
        private SQL m_SqlInstance;
        private string m_SqlQuery;

        private bool m_AutoCheck;
        private Color m_InvalidBackColor;
        private Color m_InvalidForeColor;
        private bool m_AllowEmptyString;
        private bool m_AllowNonDBData;
        private bool m_AutoShowResult;
        private bool m_SimpleMode;

        #region " Public Accessors "
        public string ExLabelField
        {
            get { return m_LabelField; }
            set { m_LabelField = value; }
        }

        public string ExLabelText
        {
            get { return m_Label.Text; }
            set { m_Label.Text = value; }
        }

        public bool ExLabelVisible
        {
            get { return m_LabelVisible; }
            set { m_LabelVisible = value; UpdateLabel(); }
        }

        public LabelLocation ExLabelLocation
        {
            get { return m_LabelLocation; }
            set { m_LabelLocation = value; UpdateLabel(); }
        }

        public Control ExLabelContainer
        {
            get { return m_LabelContainer; }
            set { m_LabelContainer = value; }
        }

        public bool ExShowDialog
        {
            get { return m_ShowDialog; }
            set { m_ShowDialog = value; /*UpdateButton();*/ }
        }

        public string ExTableName
        {
            get { return m_TableName; }
            set { m_TableName = value; }
        }

        public string ExFieldName
        {
            get { return m_FieldName; }
            set { m_FieldName = value; }
        }

        public string ExDialogTitle
        {
            get { return m_DialogTitle; }
            set { m_DialogTitle = value; }
        }

        public string[] ExSelectFields
        {
            get { return m_SelectFields; }
            set { m_SelectFields = value; }
        }

        public string[] ExFilterFields
        {
            get { return m_FilterFields; }
            set { m_FilterFields = value; }
        }

        public string ExCondition
        {
            get { return m_Condition; }
            set { m_Condition = value; }
        }

        public SQL ExSqlInstance
        {
            get { return m_SqlInstance; }
            set { m_SqlInstance = value; }
        }

        public string ExSqlQuery
        {
            get { return m_SqlQuery; }
            set { m_SqlQuery = value; }
        }

        public bool ExAutoCheck
        {
            get { return m_AutoCheck; }
            set
            {
                m_AutoCheck = value; 
                if (!m_AutoCheck)
                {
                    this.BackColor = System.Drawing.SystemColors.Window;
                    this.ForeColor = Color.Black;
                }
            }
        }

        public Color ExInvalidBackColor
        {
            get { return m_InvalidBackColor; }
            set { m_InvalidBackColor = value; }
        }

        public Color ExInvalidForeColor
        {
            get { return m_InvalidForeColor; }
            set { m_InvalidForeColor = value; }
        }

        public bool ExAllowEmptyString
        {
            get { return m_AllowEmptyString; }
            set { m_AllowEmptyString = value; }
        }

        public bool ExAllowNonDBData
        {
            get { return m_AllowNonDBData; }
            set { m_AllowNonDBData = value; }
        }

        public bool ExAutoShowResult
        {
            get { return m_AutoShowResult; }
            set { m_AutoShowResult = value; }
        }

        public bool ExSimpleMode
        {
            get { return m_SimpleMode; }
            set { m_SimpleMode = value; }
        }
#endregion

        public TextBoxEx()
        {
            InitializeComponent();
 
            m_Label = new Label();
            m_Label.AutoSize = true;
            m_Label.UseMnemonic = false;
            m_LabelField = "";
            m_LabelVisible = false;
            m_LabelLocation = LabelLocation.Bottom;
            m_LabelContainer = null;

            m_ShowDialog = true;
            m_TableName = "";
            m_FieldName = "";
            m_DialogTitle = "";
            m_SelectFields = new string[0];
            m_FilterFields = new string[0];
            m_Condition = "";
            m_SqlInstance = null;
            m_SqlQuery = "";

            m_AutoCheck = true;
            m_InvalidBackColor = Color.Yellow;
            m_InvalidForeColor = Color.Black; 
            m_AllowEmptyString = true;
            m_AllowNonDBData = false;
            m_AutoShowResult = false;
            m_SimpleMode = false;

            this.KeyDown += new KeyEventHandler(TextBoxEx_KeyDown);
            this.TextChanged += new EventHandler(TextBoxEx_TextChanged);
            this.EnabledChanged += new EventHandler(TextBoxEx_EnabledChanged);
            this.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(TextBoxEx_ButtonClick);
            this.Properties.Buttons.CollectionChanged += new CollectionChangeEventHandler(Buttons_CollectionChanged);  
        }

        void Buttons_CollectionChanged(object sender, CollectionChangeEventArgs e)
        {
            if (this.Properties.Buttons.Count > 0)
            {
                this.Properties.Buttons[0].Visible = m_ShowDialog;
                this.Properties.Buttons[0].Shortcut = new DevExpress.Utils.KeyShortcut(Keys.F4);
            }
        }

        void TextBoxEx_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (this.Properties.ReadOnly) return;
            if (e.Button.Index == 0)
            /*
            TextBoxEx_KeyDown(sender, new KeyEventArgs(Keys.Enter));
            */
            {
                FrmDialog frmDialog;

                if (m_SqlQuery != "")
                    frmDialog = new FrmDialog(m_DialogTitle, m_SqlInstance, m_SqlQuery);

                else if (m_SimpleMode)
                    frmDialog = new FrmDialog(m_DialogTitle, m_SqlInstance,
                        m_TableName, m_FieldName, this.Text, m_Condition);

                else
                    frmDialog = new FrmDialog(m_DialogTitle, m_SqlInstance,
                    m_TableName, m_FieldName, this.Text, m_Condition, m_FilterFields, m_SelectFields, m_AutoShowResult);

                if (frmDialog.ShowDialog() == DialogResult.OK)
                {
                    this.Text = frmDialog.ResultRows[0][m_FieldName].ToString();
                    this.Select(0, 0);
                    if (m_LabelField != "")
                    {
                        m_Label.Text = frmDialog.ResultRows[0][m_LabelField].ToString();
                        UpdateLabel();
                    }
                }
            }
        }

        void TextBoxEx_EnabledChanged(object sender, EventArgs e)
        {
            if (this.Enabled == false)
                this.BackColor = Color.LightGray;
            else
                this.BackColor = Color.White; 
        }

        void TextBoxEx_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || e.KeyCode == Keys.Back ||
                e.KeyCode == Keys.Delete || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.NumPad0 ||
                e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.NumPad4 ||
                e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.NumPad8 ||
                e.KeyCode == Keys.NumPad9)
            {
                m_AutoCheck = false;
                TextBoxEx_TextChanged(sender, e);
            }
            else
            {
                m_AutoCheck = true;
                TextBoxEx_TextChanged(sender, e);
            }
            
            if (e.KeyCode == Keys.Space && m_ShowDialog)
            {
                FrmDialog frmDialog;

                if (m_SqlQuery != "")
                    frmDialog = new FrmDialog(m_DialogTitle, m_SqlInstance, m_SqlQuery);

                else if (m_SimpleMode)
                    frmDialog = new FrmDialog(m_DialogTitle, m_SqlInstance,
                        m_TableName, m_FieldName, this.Text, m_Condition);
                
                else
                    frmDialog = new FrmDialog(m_DialogTitle, m_SqlInstance,
                    m_TableName, m_FieldName, this.Text, m_Condition, m_FilterFields, m_SelectFields, m_AutoShowResult);

                if (frmDialog.ShowDialog() == DialogResult.OK)
                {
                    this.Text = frmDialog.ResultRows[0][m_FieldName].ToString();
                    this.Select(0, 0);
                    if (m_LabelField != "")
                    {
                        m_Label.Text = frmDialog.ResultRows[0][m_LabelField].ToString();
                        UpdateLabel();
                    }
                }
            } 
            
        }

        private void TextBoxEx_TextChanged(object sender, EventArgs e)
        {
            
            if (m_AutoCheck && this.Enabled) 
            {
                if (ExIsValid())
                {
                    this.BackColor = System.Drawing.SystemColors.Window;  
                    this.ForeColor = Color.Black;
                    if (this.Properties.ReadOnly)
                        this.BackColor = System.Drawing.SystemColors.Control;
                }
                else
                {
                    this.BackColor = m_InvalidBackColor;
                    this.ForeColor = m_InvalidForeColor;
                }
            }
        }

        private void UpdateLabel()
        {
            Control container = m_LabelContainer; //Use defined container

            //Container is not defined, try to find the container
            if (container == null)
            {
                if (this.FindForm() == null) return;

                if (this.FindForm().Controls.Contains(this))
                {
                    container = (Control)this.FindForm();
                }
                else
                {
                    foreach (Control control in this.FindForm().Controls)
                    {
                        if (control.Controls.Contains(this))
                        {
                            container = control;
                            break;
                        }
                    }
                }
            }

            //Quit if still unable to find container
            if (container == null) return;

            if (m_LabelVisible)
            {
                if (!container.Controls.Contains(m_Label))
                {
                    container.Controls.Add(m_Label);
                    m_Label.BringToFront();
                }
            }
            else
            {
                if (container.Controls.Contains(m_Label))
                    container.Controls.Remove(m_Label);
            }

           
            if (m_LabelLocation == LabelLocation.Bottom)
            {
                m_Label.Top = this.Bottom;
                m_Label.Left = this.Left;
            }
            else
            {
                m_Label.Top = this.Top + (this.Height - m_Label.Height) / 2;
                m_Label.Left = this.Right;
            }
        }

        /*private void UpdateButton()
        {  
            if (this.Properties.Buttons.Count == 0)
            {
                this.Properties.Buttons.Add(new EditorButton(ButtonPredefines.Ellipsis));
            }
            this.Properties.Buttons[0].Visible = m_ShowDialog;
        }*/

        public DataRow ExGetDataRow()
        {
            string query = "select ";
            if (m_SelectFields.Length == 0)
                query += "* ";
            else
            {
                foreach (string field in m_SelectFields)
                    query += "`" + field + "`,";
                query = query.Substring(0, query.Length - 1);  
            }
            query += " from " + m_TableName + " where ";
            if (m_Condition != "") query += m_Condition + " and ";
            query += "`" + m_FieldName + "`=\"" + this.Text + "\"";

            if (m_SqlQuery != "")
                query = m_SqlQuery;

            DataTable dtTemp = m_SqlInstance.Select(query);

            DataRow[] drTemp = dtTemp.Select("`" + m_FieldName + "`='" + this.Text + "'");
            if (drTemp.Length > 0)
                return drTemp[0];

            //if (dtTemp.Rows.Count > 0)
            //    return dtTemp.Rows[0];
            else
                return null;
        }

        public bool ExIsValid()
        {
            if (this.Text == "") m_Label.Text = ""; 
            if (m_AllowEmptyString && this.Text == "") return true;
            if (!m_AllowEmptyString && this.Text == "") return false;
            if (m_AllowNonDBData) return true; //Bypass database checking 

            if (m_SqlInstance == null) return false; 
            string query = "select `" + m_FieldName + "`";
            if (m_LabelField != "") query += ",`" + m_LabelField + "`";
            query += " from `" + m_TableName + "` where ";
            if (m_Condition != "") query += m_Condition + " and ";
            query += "`" + m_FieldName + "`='" + this.Text + "'";

            if (m_SqlQuery != "")
                query = m_SqlQuery;

            DataTable dtTemp = m_SqlInstance.Select(query);

            if (dtTemp.Rows.Count == 0)
            {
                m_Label.Text = "";
                return false;
            }
            else
            {
                DataRow[] drTemp = dtTemp.Select("`" + m_FieldName + "`='" + this.Text + "'");
                if (drTemp.Length == 0)
                {
                    m_Label.Text = "";
                    return false;
                }
                this.Text = drTemp[0][m_FieldName].ToString();
                this.Select(this.Text.Length, 0);
                if (m_LabelField != "")
                {
                    m_Label.Text = drTemp[0][m_LabelField].ToString();
                    UpdateLabel();
                }
                return true;
            }
        }

        public DataTable ExGetDataTable()
        {
            string query = "select ";
            if (m_SelectFields.Length == 0)
                query += "* ";
            else
            {
                foreach (string field in m_SelectFields)
                    query += "`" + field + "`,";
                query = query.Substring(0, query.Length - 1);
            }
            query += " from " + m_TableName + " where ";
            if (m_Condition != "") query += m_Condition + " and ";
            query += "`" + m_FieldName + "`=\"" + this.Text + "\"";

            if (m_SqlQuery != "")
                query = m_SqlQuery;

            DataTable dtTemp = m_SqlInstance.Select(query);

            return dtTemp;
        }
    }
}
