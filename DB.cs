using System;
using System.Collections.Generic;
using System.Text;
using KASLibrary;
using System.Data;
using MySql.Data.MySqlClient;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;  

namespace CAS
{
    static class DB
    {
        public static SQL sql;
        public static ACL acl;
        public static CASUser casUser;
        public static DateTime loginDate;
        public static string loginPeriod;
        public static DataTable dtUnit,dtNamaRek;
        public static DataTable menuTable;

        public static void Load()
        {
            DB.dtUnit = new DataTable();
            dtUnit = DB.GetBaseUnitTable();
            DB.dtNamaRek = new DataTable();
            dtNamaRek = DB.GetNamaRekeningTable();
        }

        //from alternative to base
        public static double GetQtyInBaseUom(string inv, string unit, double qty1)
        {
            DataTable dt = sql.Select("Select * from konversi where inv='" + inv + "' and unit='" + unit + "'");
            if (dt.Rows.Count == 0) return qty1;
            double qty = 0;
            if (dt.Rows[0]["konversi"] != DBNull.Value)
                qty = (double)dt.Rows[0]["konversi"] * qty1;
            return qty;
        }

        //from alternative to base spb pembulatan
        public static double GetQtyInBaseUomSpb(string inv, string unit, double qty1)
        {
            DataTable dt = sql.Select("Select * from konversi where inv='" + inv + "' and unit='" + unit + "'");
            if (dt.Rows.Count == 0) return qty1;
            double qty = 0;
            if (dt.Rows[0]["konversi"] != DBNull.Value)
                qty = Math.Ceiling((double)dt.Rows[0]["konversi"] * qty1);
            return qty;
        }

        //from base to alternative
        public static double GetQtyInAlternativeUom(string inv, string unit, double qty)
        {
            DataTable dt = sql.Select("Select * from konversi where inv='" + inv + "' and unit='" + unit + "'");
            if (dt.Rows.Count == 0) return qty;
            double qty1 = 0;
            if (dt.Rows[0]["konversi"] != DBNull.Value)
                qty1 = qty / (double)dt.Rows[0]["konversi"];
            return qty1;
        }

        //from alternative to alternative
        public static double GetQtyInAlternativeUom(string inv, string fromUnit, double qty, string toUnit)
        {
            double baseQty = GetQtyInBaseUom(inv, fromUnit, qty);
            return GetQtyInAlternativeUom(inv, toUnit, baseQty);
        }

        public static string GetBaseUnit(string inv)
        {
            if (dtUnit == null) dtUnit = DB.GetBaseUnitTable();
            DataRow[] temp = dtUnit.Select("inv='" + inv + "'");
            if (temp.Length > 0)
                return temp[0]["unit"].ToString();
            return "";
        }

        public static string GetNamaRekening(string acc)
        {
            if (dtNamaRek == null) dtNamaRek = DB.GetNamaRekeningTable();
            DataRow[] temp = dtNamaRek.Select("acc='" + acc + "'");
            if (temp.Length > 0)
                return temp[0]["name"].ToString();
            return "";
        }

        public static DataTable GetBaseUnitTable()
        {
            if (sql == null) return null;
            string query = "select inv,unit from inv";
            return sql.Select(query);
        }

        public static DataTable GetNamaRekeningTable()
        {
            if (sql == null) return null;
            string query = "select acc,name from acc";
            return sql.Select(query);
        }

        public static DataTable GetKodeTransaksiTable()
        {
            if (sql == null) return null;
            string query = "select kode, acc from kode";
            return sql.Select(query);
        }

        public static Double GetToleransi(string sub)
        {
            if (sub == "")
                return 0;
            DataTable dt = sql.Select("select ifnull(toleransi,0) as toleransi from sub where sub='" + sub + "'");
            if (dt.Rows.Count > 0)
                return Convert.ToDouble(dt.Rows[0][0]);
            return 0;
        }
        
        public static DataTable PopulateUnitBase(DataTable Detail, String ColumnName)
        {
            DataTable result = Detail;
            for (int i = result.Rows.Count - 1; i >= 0; i--)
            {
                DataRow row = Detail.Rows[i];
                if (row != null && row.RowState != DataRowState.Deleted)
                {
                    if (row["inv"].ToString() != "")
                    {
                        if (row["inv"].ToString().Substring(0, 1) == "9")
                            row[ColumnName] = row["Unit"];
                        else
                            row[ColumnName] = GetBaseUnit(row["inv"].ToString());
                    }
                }
            }
            return result;
        }

        public static DataTable PopulateSelisih(DataTable Detail,string noseri)
        {
            DataTable result = Detail;
            if (noseri == "SPB" || noseri == "SPM")
            {                
                for (int i = result.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = Detail.Rows[i];
                    if (row != null && row.RowState != DataRowState.Deleted)
                    {
                        if (row["qtytim"].ToString() == "") row["qtytim"] = 0;
                        if (noseri=="SPB")
                            row["Beda"] = ((Convert.ToDouble(row["qtygd"].ToString()) - Convert.ToDouble(row["qtytim"].ToString())) / (Convert.ToDouble(row["qtygd"].ToString()) == 0 ? 1 : Convert.ToDouble(row["qtygd"].ToString()))*100);
                        else
                             row["Beda"] = Math.Round(((Convert.ToDouble(row["qtygudang"].ToString()) - Convert.ToDouble(row["qtytim"].ToString())) / Convert.ToDouble(row["qtygudang"].ToString())) * 100,3);

                         row["Beda"] = Convert.ToString(Math.Round(Convert.ToDouble(row["Beda"].ToString()),3)).ToString()+'%' ;
                    }
                }
            }
            //else
            //{
            //   for (int i = result.Rows.Count - 1; i >= 0; i--)
            //    {
            //        DataRow row = Detail.Rows[i];
            //        if (row != null && row.RowState != DataRowState.Deleted)
            //        {
            //            if (row["qtyc"].ToString() == "") row["qtyc"] = 0;
            //            row["Qty Selisih"] = Convert.ToDouble(row["qty"].ToString()) - Convert.ToDouble(row["qtyc"].ToString());
            //        }
            //    }
            //}
            return result;
        }

        public static DataTable PopulateNamaRekening(DataTable Detail, String ColumnName)
        {
            DataTable result = Detail;
            for (int i = result.Rows.Count - 1; i >= 0; i--)
            {
                DataRow row = Detail.Rows[i];
                if (row != null && row.RowState != DataRowState.Deleted)
                {
                    row[ColumnName] = GetNamaRekening(row["acc"].ToString());
                }
            }
            return result;
        }

        public static string GetNewKeyCode(string tableName, string kode)
        {
            int lastNum = 1;
            DataTable maxNum = sql.Select("select max(right(" + tableName + ",6)) from " + tableName + " where period='" + loginPeriod + "' and left(" + tableName + ",3)='" + kode + "'") ;
            if (maxNum.Rows[0][0] != DBNull.Value)
                lastNum = int.Parse(maxNum.Rows[0][0].ToString()) + 1;
            return lastNum.ToString("000000");
        }

        public static void InsertDetailRows(GridView gridView, DataRow newRow)
        {
            int idx = gridView.FocusedRowHandle;
            if (idx < 0)
            {                             
                //idx = gridView.GetSelectedRows()[0];
                return;
            }

            for (int i = gridView.RowCount - 1; i >= idx; i--)
            {
                foreach (DataColumn col in newRow.Table.Columns)
                {
                    if (gridView.GetDataRow(i) == null) continue;

                    if (i == idx)
                    {
                        if (col != newRow.Table.Columns[0] && col.ColumnName != "no")
                            gridView.GetDataRow(i)[col] = col.DefaultValue;
                    }
                    else
                    {
                        if (col.ColumnName != "no")
                            gridView.GetDataRow(i)[col] = gridView.GetDataRow(i - 1)[col];
                    }
                }
            }
        }

        public static int DeleteDetailRows(GridView gridView)
        {
            int[] selectedIndex = gridView.GetSelectedRows();

            if (selectedIndex == null || selectedIndex.Length == 0) return 0;

            int lastno = 9999;
            for (int i = 0; i < selectedIndex.Length; i++)
            {
                //gridView.GetDataRow(i)["no"] = lastno++;
                gridView.GetDataRow(selectedIndex[i])["no"] = lastno++;
            }
            gridView.DeleteSelectedRows();
            
            int no = 1;
            for (int i = 0; i < gridView.RowCount; i++)
            {
                if (gridView.GetDataRow(i) != null)
                    gridView.GetDataRow(i)["no"] = no++;
            }

            return selectedIndex.Length;
        }

        public static int DeleteDetailRows2(GridView gridView)
        {
            int[] selectedIndex = gridView.GetSelectedRows();
            if (selectedIndex == null || selectedIndex.Length == 0) return 0;
            gridView.DeleteSelectedRows();
            return selectedIndex.Length;
        }

        public static void CancelDetailRows(DataTable dtDetail)
        {
            if (dtDetail.GetChanges() != null)
            {
                for (int i = dtDetail.Rows.Count - 1; i >= 0; i--)
                {
                    if (dtDetail.Rows[i].RowState != DataRowState.Deleted)
                        dtDetail.Rows[i]["no"] = i + 1;
                }
            }
        }

        public static string SetFilterText(string filterAwal, string filterAkhir, DataRow drAwal, DataRow drAkhir, string labelFieldName)
        {
            if (filterAwal == "" && filterAkhir == "")
                return "All";
            else
            {
                if (filterAwal != "" && filterAkhir == "")
                    return "[" + filterAwal + "] " + drAwal[labelFieldName].ToString();
                else if (filterAwal == "" && filterAkhir != "")
                    return "[" + filterAkhir + "] " + drAkhir[labelFieldName].ToString();
                else
                    return "[" + filterAwal + "] " + drAwal[labelFieldName].ToString() + " - " +
                           "[" + filterAkhir + "] " + drAkhir[labelFieldName].ToString();
            }
            return "";
        }

        public static void SetNumberFormat(GridView gridView, string formatString)
        {
            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                if (gridView.Columns[i].FieldName == "val" ||
                    gridView.Columns[i].FieldName == "valrp" ||
                    gridView.Columns[i].FieldName == "disc" ||
                    gridView.Columns[i].FieldName == "price" ||
                    gridView.Columns[i].FieldName == "ppn" ||
                    gridView.Columns[i].FieldName == "dpp" ||
                    gridView.Columns[i].FieldName == "kurs" ||
                    gridView.Columns[i].FieldName == "subtotal" ||
                    gridView.Columns[i].FieldName == "total" ||
                    gridView.Columns[i].FieldName == "Price" ||
                    gridView.Columns[i].FieldName == "Packaging" ||
                    gridView.Columns[i].FieldName == "jumlah" ||
                    gridView.Columns[i].FieldName == "pph23" ||
                    gridView.Columns[i].FieldName == "pph4ay2" ||
                    gridView.Columns[i].FieldName == "pph15" ||
                    gridView.Columns[i].FieldName == "hargapokokproduksi" ||
                     gridView.Columns[i].FieldName == "valppn" ||
                    gridView.Columns[i].FieldName == "valdpp" ||
                    gridView.Columns[i].FieldName == "valsubtotal")
                {
                    gridView.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    if (Utility.GetConfig("LanguageID") != "")
                      gridView.Columns[i].DisplayFormat.Format = System.Globalization.CultureInfo.CreateSpecificCulture(Utility.GetConfig("LanguageID")).NumberFormat;
                    gridView.Columns[i].DisplayFormat.FormatString = formatString;
                }
                if (gridView.Columns[i].FieldName == "qty" ||
                 gridView.Columns[i].FieldName == "qty1" ||
                 gridView.Columns[i].FieldName == "qtypo")
                {
                    gridView.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    if (Utility.GetConfig("LanguageID") != "")
                        gridView.Columns[i].DisplayFormat.Format = System.Globalization.CultureInfo.CreateSpecificCulture(Utility.GetConfig("LanguageID")).NumberFormat;
                    gridView.Columns[i].DisplayFormat.FormatString = "#,#";
                }
            }
        }

        public static DataTable GetMasterSetting(string name)
        {
            DataTable dt = new DataTable();
            dt = sql.Select("select * from msetting where name like '" + name + "%'");
            return dt;
        }

        public static bool isBiaya(string inv)
        {
            DataTable dt = DB.sql.Select("select mtp.* from mtp, inv, jenis where inv.inv='" + inv + "' and inv.jenis = jenis.jenis and jenis.mtp = mtp.mtp");
            if (dt.Rows.Count > 0)
            {
                string mtpName = dt.Rows[0]["name"].ToString().ToUpper();
                if (mtpName.IndexOf("JASA") >= 0)
                    return true;
            }
            return false;
        }

        //public static double GetQtyToleransi(string tablename, string fieldname, string kode, string inv, string loc_remark, string curUnit, string mode)
        public static double GetQtyToleransi(string query, string inv, string curUnit, string baseUnit)
        {
            //select sum(qty) in base unit
            DataTable dt = DB.sql.Select(query);

            //if (mode == "SO")
            //    //dt = DB.sql.Select("select qty1, toleransi, unit from " + tablename + " where " + fieldname + "='" + kode + "' and inv='" + inv + "' and loc='" + loc_remark + "'");
            //    dt = DB.sql.Select("select qty1, toleransi, unit from " + tablename + " where " + fieldname + "='" + kode + "' and inv='" + inv + "'");
            //else if (mode == "Retur")
            //    dt = DB.sql.Select("select qty1, toleransi, unit from " + tablename + " where " + fieldname + "='" + kode + "' and inv='" + inv + "' and remark='" + loc_remark + "'");
        
            if (dt.Rows.Count > 0)
            {
                double qty = (double)dt.Rows[0]["qty"];
                if (curUnit != baseUnit)
                {
                //    double qtyToleransiPO = Convert.ToDouble(dt.Rows[0]["qty1"]) * (Convert.ToDouble(dt.Rows[0]["toleransi"]) / 100);
                //    double baseQtyToleransiPO = GetQtyInBaseUom(inv, dt.Rows[0]["unit"].ToString(), qtyToleransiPO);
                //    return GetQtyInAlternativeUom(inv, curUnit, baseQtyToleransiPO);
                    qty = GetQtyInAlternativeUom(inv, curUnit, qty);
                    return qty * (double)dt.Rows[0]["toleransi"] / 100;
                }
                else
                    return qty * (double)dt.Rows[0]["toleransi"] / 100;
            }
            else
                return 0;
        }

        public static int GetRowCount(DataTable dt)
        {
            int count = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i].RowState != DataRowState.Deleted)
                    count++;
            }
            return count;
        }

        /// <summary>
        /// Used in Laporan forms to check values of two textboxes
        /// </summary>
        /// <param name="txtAwal">TextBoxEx awal</param>
        /// <param name="txtAkhir">TextBoxEx akhir</param>
        /// <param name="order">0=awal, 1=akhir</param>
        /// <returns></returns>
        public static string GetRangeValue(TextBoxEx txtAwal, TextBoxEx txtAkhir, int order)
        {
            if (txtAwal.Text == "" && txtAkhir.Text == "")
                if (order == 0)
                    return "";
                else
                    return "ZZZZZZZ";

            if (txtAwal.Text == "")
                return txtAkhir.Text;

            if (txtAkhir.Text == "")
                return txtAwal.Text;

            // txtAwal & txtAkhir both have texts
            if (order == 0) 
                return txtAwal.Text;
            else
                return txtAkhir.Text;
        }

        public static double GetKurs(string currency, DateTime date)
        {
            double kurs = 0;
            DataTable dtKhr = new DataTable();
            dtKhr = DB.sql.Select("select * from khr where cur='" + currency
                + "' and period='" + date.ToString("yyMM")
                + "' and date <= " + date.ToString("yyyyMMdd") + " and valbi>0 order by date desc LIMIT 1");
            if (dtKhr.Rows.Count == 0)
            {
                dtKhr = DB.sql.Select("select * from khr where cur='" + currency
                  + "' and date <= " + date.ToString("yyyyMMdd") + " and valbi>0 order by period desc, date desc LIMIT 1");
            }
            if (dtKhr.Rows.Count > 0)
            {
                if (dtKhr.Rows[0].IsNull("valbi"))
                    return 0;
                else
                    return (double)dtKhr.Rows[0]["valbi"];
            }
            else
                return 0;
        }

        public static double GetKursPJK(string currency, DateTime date)
        {
            double kurs = 0;
            DataTable dtKhr = new DataTable();
            dtKhr = DB.sql.Select("select * from khr where cur='" + currency
                + "' and period='" + DB.loginPeriod
                + "' and date <= " + date.ToString("yyyyMMdd") + " and val>0 order by date desc LIMIT 1");
            if (dtKhr.Rows.Count == 0)
            {
                dtKhr = DB.sql.Select("select * from khr where cur='" + currency
                  + "' and date <= " + date.ToString("yyyyMMdd") + " and val>0 order by period desc, date desc LIMIT 1");
            }
            if (dtKhr.Rows.Count > 0)
            {
                if (dtKhr.Rows[0].IsNull("val"))
                    return 0;
                else
                    return (double)dtKhr.Rows[0]["val"];
            }
            else
                return 0;
        }

        private static double GetMValue(string value, string lapis, double pengaliBF, double pengaliCF)
        {
            if (lapis.Contains("BF"))
                return Convert.ToDouble(value) * pengaliBF;
            else
                return Convert.ToDouble(value) * pengaliCF;
        }

        //get Medium Value from kwalitet combination
        public static double GetMediumValue(double pengaliBF, double pengaliCF, string[] kwa, string lapis, ref bool leftIsM, ref bool rightIsM)
        {
            double m = 0;
            //cek tengah
            if (lapis.Contains("SW"))
            {
                //tipe medium (nilai tengah)
                if (kwa[1].ToString().Length <= 3 && kwa[1].ToString() != " ")
                    m = GetMValue(kwa[1].ToString(), lapis, pengaliBF, pengaliCF);
                if (kwa[2].ToString().Length <= 3 && kwa[2].ToString() != " ")
                    m = GetMValue(kwa[2].ToString(), lapis, pengaliBF, pengaliCF);
                if (kwa[3].ToString().Length <= 3 && kwa[3].ToString() != " ")
                    m = GetMValue(kwa[3].ToString(), lapis, pengaliBF, pengaliCF);
            }
            else if (lapis.Contains("DW"))
            {
                m = GetMValue(kwa[1].ToString(), "BF", pengaliBF, pengaliCF);
                m = m + Convert.ToDouble(kwa[2]);
                m = m + GetMValue(kwa[3].ToString(), "CF", pengaliBF, pengaliCF);
            }

            //cek kiri kanan
            leftIsM = rightIsM = false;
            if (kwa[0].ToString().Length <= 3 && kwa[0].ToString() != " ")
            {
                m = m + ((Convert.ToDouble(kwa[0]) == 127) ? 125 : Convert.ToDouble(kwa[0]));
                leftIsM = true;
            }
            if (kwa[4].ToString().Length <= 3 && kwa[4].ToString() != " ")
            {
                m = m + ((Convert.ToDouble(kwa[4]) == 127) ? 125 : Convert.ToDouble(kwa[4]));
                rightIsM = true;
            }
            return m;
        }

        public static void SaveDatalog(DataTable dtChanged)
        {
            if (dtChanged == null) return;

            DB.sql.LogData = false;

            string query = "";

            foreach (DataRow dRow in dtChanged.Rows)
            {
                if (dRow.RowState == DataRowState.Deleted)
                    continue;

                if (dRow.RowState == DataRowState.Added)
                {
                    // insert
                    query = "insert into " + dtChanged.TableName + " set ";
                }
                else if (dRow.RowState == DataRowState.Modified)
                {
                    // update
                    query = "update " + dtChanged.TableName + " set ";
                }

                foreach (DataColumn dCol in dtChanged.Columns)
                {
                    string value = dRow[dCol.ColumnName].ToString();
                    query += dCol.ColumnName + "=";
                    switch (dCol.DataType.Name)
                    {
                        case "String":
                            query += "'" + value.Replace("'","\\'").Replace("\"","\\\"") + "'";
                            break;
                        case "DateTime":
                            query += (value == "") ? "null" : DateTime.Parse(value).ToString("yyyyMMdd");
                            break;
                        case "TimeSpan":
                            query += (value == "") ? "null" : value.Replace(":", "");
                            break;
                        default:
                            query += (value == "") ? "0" : value;
                            break;
                    }
                    query += ",";
                }
              
                query = query.Substring(0, query.Length - 1);

                if (dRow.RowState == DataRowState.Modified)
                    query += " where " + dtChanged.Columns[0].ColumnName + "=\'" + dRow[0].ToString() + "\'";

                query += ";";

                DB.sql.Execute("insert into historymdu.datalog values(" + DateTime.Now.ToString("yyyyMMdd") +
                    "," + DateTime.Now.ToString("HHmmss") + ",'" + DB.casUser.User + "',\""+ query + "\")");  
            }

            //save log for deleted rows
            DataView dv = new DataView(dtChanged, null, null, DataViewRowState.Deleted);
            DataTable dt = dv.ToTable();
            foreach (DataRow dRow in dt.Rows)
            {
                query = "delete from " + dtChanged.TableName + " where ";
                foreach (DataColumn dCol in dtChanged.Columns)
                {
                    string value = dRow[dCol.ColumnName].ToString();
                    query += dCol.ColumnName + "=";
                    switch (dCol.DataType.Name)
                    {
                        case "String":
                            query += "'" + value.Replace("'", "\\'").Replace("\"", "\\\"") + "'";
                            break;
                        case "DateTime":
                            query += (value == "") ? "null" : DateTime.Parse(value).ToString("yyyyMMdd");
                            break;
                        case "TimeSpan":
                            query += (value == "") ? "null" : value.Replace(":", "");
                            break;
                        default:
                            query += (value == "") ? "0" : value;
                            break;
                    }
                    query += " and ";
                }
                query = query.Substring(0, query.Length - 1);
                query += ";";
                DB.sql.Execute("insert into historymdu.datalog values(" + DateTime.Now.ToString("yyyyMMdd") +
                    "," + DateTime.Now.ToString("HHmmss") + ",'" + DB.casUser.User + "',\"" + query + "\")");  
            }

            DB.sql.LogData = true;
        }
    }
}
