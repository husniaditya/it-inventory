using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KASLibrary
{
    public partial class FrmTextReportVariables : Form
    {
        private DataTable table;
        private FrmTextReportDesigner frmDesigner;

        public FrmTextReportVariables(FrmTextReportDesigner frmDesigner)
        {
            InitializeComponent();
            this.frmDesigner = frmDesigner;
            table = new DataTable();
            DataColumn col = new DataColumn("Name");
            col.ReadOnly = true;
            table.Columns.Add(col);
            col = new DataColumn("Value");
            table.Columns.Add(col);
            DataView dv = table.DefaultView;
            dv.AllowDelete = false;
            dv.AllowNew = false;
            dv.AllowEdit = true;
            dgvVariables.DataSource = table;
            foreach (TextReportField field in frmDesigner.lstField.Items)
            {
                if (field.Column.Trim() == "" && field.Name != "@pg#" && field.Name != "@r#")
                {
                    DataRow r = table.NewRow();
                    r["Name"] = field.Name;
                    r["Value"] = "";
                    table.Rows.Add(r);
                }
            }
            if (table.Rows.Count == 0) this.Close();   
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            frmDesigner.report.Variables.Clear();
            foreach (DataRow r in table.Rows)
            {
                frmDesigner.report.Variables.Add(r["Name"].ToString(), r["Value"].ToString());
            }
            this.Close();
        }
    }
}
