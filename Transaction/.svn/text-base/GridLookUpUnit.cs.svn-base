using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using System.Data;
using KASLibrary;

namespace CAS.Transaction
{
    public partial class GridLookUpUnit : GridLookUpEx
    {

        string capt = "Unit";
        public GridLookUpUnit(GridView gridViewContainer)
            : base(DB.sql, "", "konversi", "unit", gridViewContainer, "", false, false, "Konversi Unit")
        {
            InitializeComponent();
            this.MultiSelect = false;
            //this.GridView = gridViewContainer;
            //this.TableName = "konversi";
            //this.FieldName = "unit";
        }

        public GridLookUpUnit(GridView gridViewContainer, string caption) : base(DB.sql, "", "konversi", "unit", gridViewContainer, "", false, false, "Konversi Unit")
        {
            InitializeComponent();
            this.MultiSelect = false;
            capt = caption;
            //this.GridView = gridViewContainer;
            //this.TableName = "konversi";
            //this.FieldName = "unit";
        }

        void GridLookUpUnit_Enter(object sender, EventArgs e)
        {
            this.Query = "select unit as `"+capt+"`, konversi as `Konversi` from konversi where inv='" + GridView.GetFocusedRowCellValue("inv") + "'";
        }

    }
}
