using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using DevExpress.XtraEditors.Repository;
using System.Windows.Forms;

namespace KASLibrary
{
    public partial class GridNumEx : RepositoryItemSpinEdit
    {
        bool selected;

        //public GridNumEx(bool allowNegative, bool allowDecimal, double minValue, double maxValue, double increment, bool spinButton)
        public GridNumEx(bool allowNegative, bool allowDecimal, decimal minValue, decimal maxValue, double increment, bool spinButton)
        {
            InitializeComponent();
            this.MinValue = (allowNegative) ? (decimal)minValue : 0;
            this.MaxValue = (decimal)maxValue;
            this.Increment = (decimal)increment;
            this.IsFloatValue = allowDecimal;
            this.Buttons[0].Visible = spinButton;
            this.Click += new EventHandler(GridNumEx_Click);
            this.Enter += new EventHandler(GridNumEx_Enter);
            selected = false;
        }

        void GridNumEx_Enter(object sender, EventArgs e)
        {
            selected = false;
        }

        void GridNumEx_Click(object sender, EventArgs e)
        {
            if (!selected) SendKeys.Send("{F2}");
            selected = !selected;
        }

        //public GridNumEx() : this(false, true, 0, Int32.MaxValue, 1, false)
        public GridNumEx() : this(false, true, 0, decimal.MaxValue, 1, false)
        {
        }

        //public GridNumEx(double increment) : this(false, true, 0, Int32.MaxValue, increment, false)
        public GridNumEx(double increment) : this(false, true, 0, decimal.MaxValue, increment, false)
        {
        }

        public GridNumEx(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
