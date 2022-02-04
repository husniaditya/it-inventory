using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using KASLibrary;

namespace CAS.Master
{
    public partial class FrmMasterDesignVar : Form
    {
        MySqlDataAdapter[] da = new MySqlDataAdapter[5];
        DataTable[] dt = new DataTable[5];

        public FrmMasterDesignVar()
        {
            InitializeComponent();

            //tab Type
            da[0] = DB.sql.SelectAdapter("Select type, ket from type");
            dt[0] = new DataTable();
            da[0].Fill(dt[0]);
            gcxType.ExGridControl.DataSource = dt[0];
            gcxType.ExTitleLabel.Text = "";
            gcxType.ExToolStrip.Items["tsbtnNew"].Visible = false;
            gcxType.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(typeDelete_Click);
            gcxType.ExGridView.OptionsBehavior.Editable = true;
            gcxType.ExGridView.OptionsSelection.MultiSelect = true;
            gcxType.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gcxType.ExGridView.Columns["type"].Caption = "Type";
            gcxType.ExGridView.Columns["ket"].Caption = "Keterangan";
            gcxType.ExGridView.BestFitColumns();

            //tab Rumus
            da[1] = DB.sql.SelectAdapter("Select kode, ket, pjg, lbr, tgi, L1, T, L2, P, L, kali, tambah, prod from rumus");
            dt[1] = new DataTable();
            da[1].Fill(dt[1]);
            gcxRumus.ExGridControl.DataSource = dt[1];
            gcxRumus.ExTitleLabel.Text = "";
            gcxRumus.ExToolStrip.Items["tsbtnNew"].Visible = false;
            gcxRumus.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(rumusDelete_Click);
            gcxRumus.ExGridView.OptionsBehavior.Editable = true;
            gcxRumus.ExGridView.OptionsSelection.MultiSelect = true;
            gcxRumus.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gcxRumus.ExGridView.Columns["kode"].Caption = "Kode";
            gcxRumus.ExGridView.Columns["ket"].Caption = "Keterangan";
            gcxRumus.ExGridView.Columns["pjg"].Caption = "Panjang";
            gcxRumus.ExGridView.Columns["lbr"].Caption = "Lebar";
            gcxRumus.ExGridView.Columns["tgi"].Caption = "Tinggi";
            gcxRumus.ExGridView.Columns["kali"].Caption = "Kali";
            gcxRumus.ExGridView.Columns["tambah"].Caption = "Tambah";
            gcxRumus.ExGridView.Columns["prod"].Caption = "Produksi";
            gcxRumus.ExGridView.Columns["pjg"].ColumnEdit = new GridNumEx();
            gcxRumus.ExGridView.Columns["lbr"].ColumnEdit = new GridNumEx();
            gcxRumus.ExGridView.Columns["tgi"].ColumnEdit = new GridNumEx();
            gcxRumus.ExGridView.Columns["L1"].ColumnEdit = new GridNumEx();
            gcxRumus.ExGridView.Columns["T"].ColumnEdit = new GridNumEx();
            gcxRumus.ExGridView.Columns["L2"].ColumnEdit = new GridNumEx();
            gcxRumus.ExGridView.Columns["P"].ColumnEdit = new GridNumEx();
            gcxRumus.ExGridView.Columns["L"].ColumnEdit = new GridNumEx();
            gcxRumus.ExGridView.Columns["kali"].ColumnEdit = new GridNumEx();
            gcxRumus.ExGridView.Columns["tambah"].ColumnEdit = new GridNumEx();
            gcxRumus.ExGridView.Columns["prod"].ColumnEdit = new GridNumEx(500);
            gcxRumus.ExGridView.BestFitColumns();

            //tab ukuran
            da[2] = DB.sql.SelectAdapter("select kode, ket from ukuran");
            dt[2] = new DataTable();
            da[2].Fill(dt[2]);
            gcxUkuran.ExGridControl.DataSource = dt[2];
            gcxUkuran.ExTitleLabel.Text = "";
            gcxUkuran.ExToolStrip.Items["tsbtnNew"].Visible = false;
            gcxUkuran.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(ukuranDelete_Click);
            gcxUkuran.ExGridView.OptionsBehavior.Editable = true;
            gcxUkuran.ExGridView.OptionsSelection.MultiSelect = true;
            gcxUkuran.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gcxUkuran.ExGridView.Columns["kode"].Caption = "Kode";
            gcxUkuran.ExGridView.Columns["ket"].Caption = "Keterangan";
            gcxUkuran.ExGridView.BestFitColumns();

            //tab Warna
            da[3] = DB.sql.SelectAdapter("select * from color");
            dt[3] = new DataTable();
            da[3].Fill(dt[3]);
            gcxWarna.ExGridControl.DataSource = dt[3];
            gcxWarna.ExTitleLabel.Text = "";
            gcxWarna.ExToolStrip.Items["tsbtnNew"].Visible = false;
            gcxWarna.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(warnaDelete_Click);
            gcxWarna.ExGridView.OptionsBehavior.Editable = true;
            gcxWarna.ExGridView.OptionsSelection.MultiSelect = true;
            gcxWarna.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gcxWarna.ExGridView.Columns["kode"].Caption = "Kode";
            gcxWarna.ExGridView.Columns["warna"].Caption = "Warna";
            gcxWarna.ExGridView.Columns["ket"].Caption = "Keterangan";
            gcxWarna.ExGridView.BestFitColumns();

            da[4] = DB.sql.SelectAdapter("select kode, nama from mkertas");
            dt[4] = new DataTable();
            da[4].Fill(dt[4]);
            gcxKertas.ExGridControl.DataSource = dt[4];
            gcxKertas.ExTitleLabel.Text = "";
            gcxKertas.ExToolStrip.Items["tsbtnNew"].Visible = false;
            gcxKertas.ExToolStrip.Items["tsbtnDelete"].Click += new EventHandler(kertasDelete_Click);
            gcxKertas.ExGridView.OptionsBehavior.Editable = true;
            gcxKertas.ExGridView.OptionsSelection.MultiSelect = true;
            gcxKertas.ExGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gcxKertas.ExGridView.Columns["kode"].Caption = "Kode";
            gcxKertas.ExGridView.Columns["nama"].Caption = "Nama";
            gcxKertas.ExGridView.BestFitColumns();
        }

        void kertasDelete_Click(object sender, EventArgs e)
        {
            gcxKertas.ExGridView.DeleteSelectedRows();
        }

        void warnaDelete_Click(object sender, EventArgs e)
        {
            gcxWarna.ExGridView.DeleteSelectedRows();
        }

        void ukuranDelete_Click(object sender, EventArgs e)
        {
            gcxUkuran.ExGridView.DeleteSelectedRows();
        }

        private void FrmMasterDesignVar_Load(object sender, EventArgs e)
        {            
        }

        void typeDelete_Click(object sender, EventArgs e)
        {
            gcxType.ExGridView.DeleteSelectedRows();
        }

        void rumusDelete_Click(object sender, EventArgs e)
        {
            gcxRumus.ExGridView.DeleteSelectedRows();
        }

        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                da[tabControl1.SelectedIndex].Update(dt[tabControl1.SelectedIndex]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tsbtnCancel_Click(object sender, EventArgs e)
        {
            dt[tabControl1.SelectedIndex].RejectChanges();
        }
    }
}