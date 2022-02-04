using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CAS.Master;
using KASLibrary;
using DevExpress.XtraReports.UI;
using System.IO;

namespace CAS.Transaction
{
    public partial class FrmTTtf : BaseMaster
    {
        //string query;
        private int lastPos = 0;
        bool close = false;
        public FrmTTtf()
        {
            InitializeComponent();

            ToolStripMenuItem tsmiPrintPreview = new ToolStripMenuItem("Print Preview", null, new EventHandler(tsmiPrintPreview_Click));
            ToolStripMenuItem tsmiPrintDirectly = new ToolStripMenuItem("Print Directly", null, new EventHandler(tsmiPrintDirectly_Click));
            ToolStripDropDownButton tsbtnPrint = new ToolStripDropDownButton("Print", null, tsmiPrintPreview, tsmiPrintDirectly);
            tsbtnPrint.Image = MasterNavigator.Items["tsbtnPrint"].Image;
            MasterNavigator.Items.Insert(MasterNavigator.Items.IndexOfKey("tsbtnPrint"), tsbtnPrint);

            MasterNavigator.Items.RemoveByKey("tsbtnPrint");
            this.MasterQuery = "select * from ttf where period='" + DB.loginPeriod + "'";
            Utility.SetSqlInstance(pnlDetail, DB.sql);


            this.MasterBindingSource.PositionChanged += new EventHandler(MasterBindingSource_PositionChanged);
            this.tsbtnNew.Click += new EventHandler(tsbtnNew_Click);
            this.tsbtnEdit.Click += new EventHandler(tsbtnEdit_Click);
            this.tsbtnCancel.Click += new EventHandler(tsbtnCancel_Click);
            this.Load += new EventHandler(FrmTTtf_Load);
            txtNo.Properties.ReadOnly = true;
            txtPeriod.Properties.ReadOnly = true;            
        }

        void tsmiPrintPreview_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepTTF" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_PrintInvoice('Transaction.FrmTTF','" + this.NoDocument + "')");
        //    report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
            report.PaperName = "1/2A4";
            report.ShowPreview();
        }

        void tsmiPrintDirectly_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Reports\\" + "RepTTF" + ".repx";
            XtraReport report = new XtraReport();
            report.LoadState(path);
            report.DataSource = DB.sql.Select("call SP_PrintInvoice('Transaction.FrmTTF','" + this.NoDocument + "')");
            report.PrintingSystem.ShowMarginsWarning = false;
            report.PaperName = "1/2A4";
       //     report.Bands[BandKind.PageFooter].Controls["lblUser"].Text = DB.casUser.Name;
            report.Print();
        }

        protected override void setMode(BaseMaster.Mode newMode)
        {
            string query = "select * from _close where period='" + DB.loginPeriod + "'";
            DataTable CPeriod = DB.sql.Select(query);

            if (MasterTable.Rows.Count == 0 && DB.casUser.AllowInsert(this.Tag.ToString()))
                newMode = Mode.New;

            if (CPeriod.Rows.Count > 0)
            {
                newMode = Mode.View;
                close = true;
            }
            base.setMode(newMode);
            if (CPeriod.Rows.Count > 0)
            {
                tsbtnNew.Enabled = false;
                tsbtnEdit.Enabled = false;
                tsbtnDelete.Enabled = false;
            }
        }

        private void FrmTTtf_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'casDataSet.ttf' table. You can move, or remove it, as needed.
             if (DB.sql == null) return;
            string query = "select noseri from moduld where role='" + DB.casUser.Role + "' and noseri in (select noseri from modul where menuid='" + this.Tag.ToString() + "')";

            ludSeri.Properties.DataSource = DB.sql.Select(query);
            ludSeri.Properties.DisplayMember = "noseri";
            ludSeri.Properties.ValueMember = "noseri";
            dateDate.Value = DateTime.Now;
            //txtPeriod.DataBindings.Add("EditValue", MasterBindingSource, "period");
            txtPeriod.EditValue = DB.loginPeriod;
            ludSeri.ItemIndex = 0;
            ludSeri_EditValueChanged(sender, e);

             setMode(Mode.View);
             richTextBox1.LoadFile("NOTES.rtf");
        }

        void MasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
          {
             if (MasterBindingSource.Position < 0)
                //MasterBindingSource.Position = 0;
                return;

            //if (MasterBindingSource.Position == MasterTable.Rows.Count)
            //if (MasterBindingSource.Position == MasterTable.Select(MasterBindingSource.Filter).Length)
            if (mode == Mode.New)
            {
                lblDeleted.Visible = false;
                 return;
            }

           //tslblRecord.Text = "Record " + (MasterBindingSource.Position + 1).ToString() + " of " + MasterTable.Select(MasterBindingSource.Filter).Length;
            if (this.mode == Mode.View)
            {
               setMode(Mode.View);
            }
            if (Convert.ToUInt64(((DataRowView)MasterBindingSource.Current).Row["delete"]) == 1)
            {
                lblDeleted.Visible = true;
            }
            else
            {
                lblDeleted.Visible = false;
            }

           if (MasterBindingSource.Position >= MasterTable.Rows.Count) return;
           }
             if (close)
    
            {
                tsbtnEdit.Enabled = false;
            }
            if (MasterBindingSource.Position < 0)
                //MasterBindingSource.Position = 0;
                return;
            if (MasterBindingSource.Position >= MasterTable.Rows.Count) return;
            ParseNoSeri();
            
          }

      
        void tsbtnCancel_Click(object sender, EventArgs e)
        {
            if (this.mode == Mode.View)
            {
                ParseNoSeri();
                //nobgTextBoxEx.ExSqlQuery = query;
             //   nobgTextBoxEx.ExSqlQuery = "select nobg as `No BG` from cgr";
            }
              setMode(Mode.View);
            if (MasterBindingSource.Position == lastPos)
                MasterBindingSource_PositionChanged(MasterBindingSource, new EventArgs());
            else
                MasterBindingSource.Position = lastPos;

            if (MasterBindingSource.Position != MasterTable.Rows.Count)
                jns.EditValue = Convert.ToInt32(MasterTable.Rows[MasterBindingSource.Position]["jnsbyr"]);
          
        }

        void tsbtnEdit_Click(object sender, EventArgs e)
        {
           
            //subTextBoxEx.Properties.ReadOnly = true;
            //accTextBoxEx.Properties.ReadOnly = true;
            //accbankTextBoxEx.Properties.ReadOnly = true;
            //bankTextEdit.Properties.ReadOnly = true;
            //acbankTextEdit.Properties.ReadOnly = true;
            //bgdateDateEdit.Properties.ReadOnly = true;
            //bgduedateDateEdit.Properties.ReadOnly = true;
            //bgvalSpinEdit.Properties.ReadOnly = true;
            txtNo.Properties.ReadOnly = true;
            txtPeriod.Properties.ReadOnly = true;
            lastPos = MasterBindingSource.Position;
        }

        void tsbtnNew_Click(object sender, EventArgs e)
        {
            lastPos = MasterBindingSource.Position;
            txtPeriod.EditValue = DB.loginPeriod;
            dateDate.Value = DateTime.Now;
            curcur.EditValue = "IDR";
            curcur1.EditValue = "IDR";

            ludSeri.ItemIndex = 0;
            if (ludSeri.ItemIndex == -1)
            {
                txtNo.EditValue = DB.GetNewKeyCode(MasterTable.TableName, "TTF");
            }
            else
            {
                txtNo.EditValue = DB.GetNewKeyCode(MasterTable.TableName, ludSeri.EditValue.ToString());
            }
            //subTextBoxEx.Properties.ReadOnly = true;
            //accbankTextBoxEx.Properties.ReadOnly = true;
            //accTextBoxEx.Properties.ReadOnly = true;
            //acbankTextEdit.Properties.ReadOnly = true;
            //bankTextEdit.Properties.ReadOnly = true;
            //bgdateDateEdit.Properties.ReadOnly = true;
            //bgduedateDateEdit.Properties.ReadOnly = true;
            //bgduedateDateEdit.DateTime = dateDateEdit.DateTime = DateTime.Today;
            //bgvalSpinEdit.Properties.ReadOnly = true;
            txtNo.Properties.ReadOnly = true;
            txtPeriod.Properties.ReadOnly = true;
        }

        private void txtNo_EditValueChanged(object sender, EventArgs e)
        {
            //if (MasterBindingSource.Position != MasterTable.Rows.Count)
            //{
            //    int jenisgiro = Convert.ToInt32(MasterTable.Rows[MasterBindingSource.Position]["dk"]);
            //    jenisRadioGroup.SelectedIndex = jenisgiro;
            //}
            if (MasterBindingSource.Position != MasterTable.Rows.Count)
               jns.EditValue = Convert.ToInt32(MasterTable.Rows[MasterBindingSource.Position]["jnsbyr"]);
          
        }

        //private void nobgTextBoxEx_EditValueChanged(object sender, EventArgs e)
        //{
        //    //DataTable info = DB.sql.Select("select kag.nobg,kas.date,kas.sub,kag.bank,kag.acbank,kag.duedate,kag.val,kag.acc from kas,kag where kag.kas = kas.kas and kag.nobg='" + nobgTextBoxEx.Text + "'");
        //    //if (info.Rows.Count == 1)
        //    //{
        //    //    bankTextEdit.Text = info.Rows[0]["bank"].ToString();
        //    //    acbankTextEdit.Text = info.Rows[0]["acbank"].ToString();
        //    //    bgdateDateEdit.DateTime = Convert.ToDateTime(info.Rows[0]["date"]);
        //    //    bgduedateDateEdit.DateTime = Convert.ToDateTime(info.Rows[0]["duedate"]);
        //    //    bgvalSpinEdit.EditValue = Convert.ToInt32(info.Rows[0]["val"]);
        //    //    subTextBoxEx.Text = info.Rows[0]["sub"].ToString();
        //    //    accbankTextBoxEx.Text = info.Rows[0]["acc"].ToString();
        //    //}
        //    //else
        //    //{
        //    //    tsbtnCancel.PerformClick();
        //    //    if (nobgTextBoxEx.Text != "")
        //    //        MessageBox.Show("Data BG tidak valid");
        //    //}

        //    if (!nobgTextBoxEx.Properties.ReadOnly)
        //    //if (nobgTextBoxEx
        //    {
        //        DataRow row = nobgTextBoxEx.ExGetDataRow();
        //        if (row == null)
        //        {
        //            bankTextEdit.EditValue = "";
        //            acbankTextEdit.EditValue = "";
        //            bgdateDateEdit.DateTime = DateTime.Today;
        //            bgduedateDateEdit.DateTime = DateTime.Today;
        //            bgvalSpinEdit.EditValue = 0;
        //            subTextBoxEx.EditValue = "";
        //            accbankTextBoxEx.EditValue = "";
        //            return;
        //        }
        //        bankTextEdit.EditValue = row["Bank"].ToString();
        //        acbankTextEdit.EditValue = row["AC Bank"].ToString();
        //        bgdateDateEdit.DateTime = Convert.ToDateTime(row["Tanggal"]);
        //        if (row["Jatuh Tempo"] != DBNull.Value)
        //            bgduedateDateEdit.DateTime = Convert.ToDateTime(row["Jatuh Tempo"]);
        //        bgvalSpinEdit.EditValue = Convert.ToDouble(row["Nilai"]);
        //        subTextBoxEx.EditValue = row["Supplier/Customer"].ToString();
        //        accbankTextBoxEx.EditValue = row["Acc Bank"].ToString();
        //        accTextBoxEx.EditValue = row["Acc Giro"].ToString();
        //    }
        //}

        private void ludSeri_EditValueChanged(object sender, EventArgs e)
        {
            if (ludSeri.EditValue == null) return;
        }

        public string NoDocument
        {
            get { return ludSeri.Text + "-" + txtPeriod.Text + "-" + txtNo.Text; }
        }

        private void ParseNoSeri()
        {
            if (MasterBindingSource.Position < 0) return;

            string no = MasterTable.Rows[MasterBindingSource.Position][0].ToString();
            ludSeri.EditValue = no.Split('-')[0];
            txtPeriod.EditValue = no.Split('-')[1];
            txtNo.EditValue = no.Split('-')[2];
        }
        
        protected override void tsbtnBrowse_Click(object sender, EventArgs e)
        {
            string keyfield = MasterTable.Columns[0].ColumnName;
            //string condition = "";
            //int indexOfWhere = MasterQuery.ToLower().IndexOf("where");
            //if (indexOfWhere > 0)
            //    condition = MasterQuery.Substring(indexOfWhere + 6);
            string query = "Call SP_Browse('" + this.Name + "','" + DB.loginPeriod + "')";
            FrmDialog frmDialog = new FrmDialog(this.Text, DB.sql, query);
            if (frmDialog.ShowDialog() == DialogResult.OK)
            {
                MasterBindingSource.Position = MasterBindingSource.Find(keyfield, frmDialog.ResultRows[0][0].ToString());
            }
        }

        protected override void tsbtnDelete_Click(object sender, EventArgs e)
        {
            lastPos = MasterBindingSource.Position;
           // base.tsbtnDelete_Click(sender, e);
            //if (Convert.ToInt32(MasterTable.Rows[MasterBindingSource.Position]["delete"]) == 1)
              //  DB.sql.Execute("Call SP_Delete('CGR'" + ",'" + NoDocument + "')");
            if (MessageBox.Show("Are you sure you want to delete this item?", "Confirmation",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                lblDeleted.Visible = true;
                ((DataRowView)MasterBindingSource.Current).Row["delete"] = 1;
                ((DataRowView)MasterBindingSource.Current).Row["chusr"] = DB.casUser.User;
                ((DataRowView)MasterBindingSource.Current).Row["chtime"] = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

                //MasterBindingSource.RemoveCurrent();
                MasterAdapter.Update(MasterTable);
                //call SP_Delete
                //DB.sql.Execute("Call SP_Delete('" + MasterTable.TableName.ToString() + "','" + NoDocument + "')");
                //DB.sql.Execute("Call SP_OpenTransaction('" + MasterTable.TableName.ToString() + "','" + NoDocument + "')");
                ////query = "Delete from " + DetailTable.TableName.ToString() + " where " + DetailTable.Columns[0].ColumnName.ToString() + " ='" + kodetrans + "'";
                ////DB.sql.Execute(query);
                MessageBox.Show("Kode: " + NoDocument + " Deleted Successfully");
                ////tsbtnLast.PerformClick();
                tsbtnRefresh.PerformClick();
            }
        }
        
        protected override void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidateChildren();
             
                if (((DataRowView)MasterBindingSource.Current).Row.RowState == DataRowState.Detached)
                {
                    txtNo.Text = DB.GetNewKeyCode(MasterTable.TableName, ludSeri.EditValue.ToString());
                    //string newKeyCode = NoDocument;
                    ((DataRowView)MasterBindingSource.Current).Row[0] = NoDocument;
                }
                else
                    ((DataRowView)MasterBindingSource.Current).Row[0] = NoDocument;
                //if (MasterBindingSource.Position == MasterTable.Rows.Count)
                ((DataRowView)MasterBindingSource.Current).Row["period"] = txtPeriod.EditValue.ToString();
                ((DataRowView)MasterBindingSource.Current).Row["date"] = dateDate.Value;
                ((DataRowView)MasterBindingSource.Current).Row["jnsbyr"] =  jns.EditValue;
             //   dateDate.Value = dateDate.DateTime.Add(DateTime.Now.TimeOfDay);
                
                base.tsbtnSave_Click(sender, e);

                if (MasterBindingSource.Position != MasterTable.Rows.Count)
                    jns.EditValue = Convert.ToInt32(MasterTable.Rows[MasterBindingSource.Position]["jnsbyr"]);
          
                //nobgTextBoxEx.ExSqlQuery = query;
            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void titipTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pnlDetail_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.FileStream outStream = File.Create("NOTES.rtf");

            //Create a variable
            string data = richTextBox1.Rtf;

            //Save 
            StreamWriter sw = new StreamWriter(outStream);
            sw.WriteLine(data);
            sw.Flush();
            sw.Close();
        }

        private void FrmTTtf_FormClosed(object sender, FormClosedEventArgs e)
        {
            button1_Click(sender, e); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tsmiPrintDirectly_Click(sender, e);
        }

        private void byrTextEdit_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                byrTextEdit.Text = (System.String)e.Data.GetData(typeof(System.String));
            }
        }

        private void byrTextEdit_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void kmbl_tglTextEdit_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                kmbl_tglTextEdit.Text = (System.String)e.Data.GetData(typeof(System.String));
            }
        }

        private void kmbl_tglTextEdit_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void titipTextEdit_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                titipTextEdit.Text = (System.String)e.Data.GetData(typeof(System.String));
            }
        }

        private void titipTextEdit_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void txtSub_EditValueChanged(object sender, EventArgs e)
        {
            DataTable dtResult = new DataTable();
            if (txtSub.EditValue.ToString().Trim() != "")
            {
                string query = "select * from ttf where sub ='" + txtSub.EditValue.ToString() + "' order by date desc limit 1";
                dtResult = DB.sql.Select(query);
                if (dtResult.Rows.Count > 0)
                {
                    titipTextEdit.Text = dtResult.Rows[0]["titip"].ToString();
                    byrTextEdit.Text = dtResult.Rows[0]["byr"].ToString();
                    kmbl_tglTextEdit.Text = dtResult.Rows[0]["kmbl_tgl"].ToString();
                }
            }
        }        

        //private void nobgTextBoxEx_Enter(object sender, EventArgs e)
        //{
        //    //jika mode edit
        //    if (!nobgTextBoxEx.Properties.ReadOnly)
        //    {
        //        string tglAwal = Utility.FirstDateInMonth(DB.loginDate).ToString("yyyyMMdd");
        //        string tglAkhir = Utility.LastDateInMonth(DB.loginDate).ToString("yyyyMMdd");
        //        //giro masuk = piutang
        //        if (jenisRadioGroup.SelectedIndex == 0)
        //            nobgTextBoxEx.ExSqlQuery = "Call SP_LookUpCgr('" + DB.loginPeriod + "'," + tglAwal + "," + tglAkhir + ",'2')";
        //        else
        //            nobgTextBoxEx.ExSqlQuery = "Call SP_LookUpCgr('" + DB.loginPeriod + "'," + tglAwal + "," + tglAkhir + ",'1')";
        //    }
        //}
    }
}
