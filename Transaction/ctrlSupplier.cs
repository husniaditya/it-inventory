using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using KASLibrary;

namespace CAS.Transaction
{
    public partial class CtrlSub : UserControl
    {
        public enum SubType { Supplier, Customer, All, SupplierLokal, SupplierImport, Shipper, Shippto, Emkl, Notify };

        private SubType m_subType;

        public SubType Type
        {
            set 
            { 
                m_subType = value;
                if (value == SubType.Supplier)
                {
                    //subTextBoxEx.ExCondition = "group_=1";
                    subTextBoxEx.ExSqlQuery = "Call SP_LookUp('supplier')";
                    subTextBoxEx.ExDialogTitle = "Supplier";
                    grpSub.Text = "Supplier";
                    linkToSub.FormName = "MasterSupplier";
                }
                else if (value == SubType.Customer)
                {
                    //subTextBoxEx.ExCondition = "group_=2";
                    subTextBoxEx.ExSqlQuery = "Call SP_LookUp('customer')";
                    subTextBoxEx.ExDialogTitle = "Customer";
                    grpSub.Text = "Customer";
                    linkToSub.FormName = "MasterCustomer";
                }
                else if (value == SubType.All)
                {
                    //subTextBoxEx.ExCondition = "";
                    subTextBoxEx.ExSqlQuery = "Call SP_LookUp('sub')";
                    subTextBoxEx.ExDialogTitle = "Supplier/Customer";
                    grpSub.Text = "Supplier/Customer";
                    linkToSub.FormName = "";
                }
                else if (value == SubType.SupplierImport)
                {
                    subTextBoxEx.ExSqlQuery = "Call SP_LookUp('supplier_im')";
                    subTextBoxEx.ExDialogTitle = "Supplier Import";
                    grpSub.Text = "Supplier Import";
                    linkToSub.FormName = "";
                }
                else if (value == SubType.SupplierLokal)
                {
                    subTextBoxEx.ExSqlQuery = "Call SP_LookUp('supplier_lok')";
                    subTextBoxEx.ExDialogTitle = "Supplier Lokal";
                    grpSub.Text = "Supplier Lokal";
                    linkToSub.FormName = "";
                }
                else if (value == SubType.Shipper)
                {
                    subTextBoxEx.ExSqlQuery = "Call SP_LookUp('shipper')";
                    subTextBoxEx.ExDialogTitle = "Shipper";
                    grpSub.Text = "Shipper";
                    linkToSub.FormName = "";
                }
                else if (value == SubType.Shippto)
                {
                    subTextBoxEx.ExSqlQuery = "Call SP_LookUp('shippto')";
                    subTextBoxEx.ExDialogTitle = "ShippTo";
                    grpSub.Text = "ShippTo";
                    linkToSub.FormName = "";
                }
                else if (value == SubType.Notify)
                {
                    subTextBoxEx.ExSqlQuery = "Call SP_LookUp('notify')";
                    subTextBoxEx.ExDialogTitle = "Notyfy Party";
                    grpSub.Text = "Notify Party";
                    linkToSub.FormName = "";
                }
                else if (value == SubType.Emkl)
                {
                    subTextBoxEx.ExSqlQuery = "Call SP_LookUp('emkl')";
                    subTextBoxEx.ExDialogTitle = "EMKL";
                    grpSub.Text = "EMKL";
                    linkToSub.FormName = "";
                }
            }
            get { return m_subType; }
        }

        private bool m_readOnly;

        public bool ReadOnly
        {
            set 
            { 
                m_readOnly = value;
                Utility.SetReadOnly(subTextBoxEx, m_readOnly);
            }
            get { return m_readOnly; }
        }

        public TextBoxEx txtSub
        {
            get { return subTextBoxEx; }
        }

        public CtrlSub()
        {
            InitializeComponent();
            subTextBoxEx.ExSqlInstance = DB.sql;
            ReadOnly = true;
            Type = SubType.Supplier;
        }

        private void subTextBoxEx_EditValueChanged(object sender, EventArgs e)
        {
            if (subTextBoxEx.Text.Length >= 7)
            {
            DataRow row = subTextBoxEx.ExGetDataRow();
            if (row == null)
            {
                txtNama.Text = "";
                txtAlamat.Text = "";
                txtKota.Text = "";
                txtNPWP.Text = "";
                return;
            }
            txtNama.Text = row["Nama"].ToString();
            txtAlamat.Text = row["Alamat"].ToString();
            txtKota.Text = row["Kota"].ToString();
         //   txtNPWP.Text = row["NPWP"].ToString();
            }
        }
    }
}
