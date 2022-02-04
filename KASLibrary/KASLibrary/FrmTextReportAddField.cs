using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KASLibrary
{
    public partial class FrmTextReportAddField : Form
    {
        private FrmTextReportDesigner frmDesigner;

        public FrmTextReportAddField(string mode,FrmTextReportDesigner frmDesigner)
        {
            InitializeComponent();
            this.frmDesigner = frmDesigner; 
            cmbAlignment.SelectedIndex = 0;
            cmbColumn.Items.Add("");   
            foreach (DataColumn column in frmDesigner.table.Columns)
            {
                cmbColumn.Items.Add(column.ColumnName);    
            }
            cmbColumn.SelectedIndex = 0; 
            if (mode == "EDIT")
            {
                this.Text = "Edit Field Dialog";
                btnAddField.Text = "Update";
                TextReportField field = (TextReportField)frmDesigner.lstField.SelectedItem;
                txtName.Text = field.Name;
                txtName.Enabled = false; 
                cmbColumn.SelectedItem = field.Column;
                txtFormat.Text = field.Format;
                txtSize.Text = field.Size.ToString();
                cmbAlignment.SelectedItem = field.Alignment;
                cmbSummary.SelectedItem = field.Summary; 
             }
        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int.Parse(txtSize.Text);
            }
            catch 
            {
                MessageBox.Show("Size must be an integer!","Error",MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (btnAddField.Text == "Update")
            {
                TextReportField field = (TextReportField)frmDesigner.lstField.SelectedItem;                       
                field.Name = txtName.Text;
                field.Column = cmbColumn.Text;
                field.Format = txtFormat.Text;
                field.Size = int.Parse(txtSize.Text);
                field.Alignment = cmbAlignment.Text;
                field.Summary = cmbSummary.Text; 
            }
            else
            {
                TextReportField field = new TextReportField();
                field.Name = txtName.Text;
                field.Column = cmbColumn.Text;
                field.Format = txtFormat.Text;
                field.Size = int.Parse(txtSize.Text);
                field.Alignment = cmbAlignment.Text;
                field.Summary = cmbSummary.Text;  
                frmDesigner.lstField.Items.Add(field);
                frmDesigner.report.Fields.Add(field);    
            }
            this.DialogResult = DialogResult.OK;
            this.Close(); 
        }
    }
}