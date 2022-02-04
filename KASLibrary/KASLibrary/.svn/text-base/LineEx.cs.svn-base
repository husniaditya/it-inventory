using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace KASLibrary
{
    public partial class LineEx : UserControl
    {
        public enum Direction { Horizontal, Vertical };

        private int exSolidWidth;
        private int exGapWidth;
        private int exLineSize;
        private Direction exLineDirection;

        public LineEx()
        {
            InitializeComponent();
            exSolidWidth = 10;
            exGapWidth = 0;
            exLineSize = 1;
            exLineDirection = Direction.Horizontal;  
        }

        public int ExSolidWidth
        {
            get { return exSolidWidth; }
            set { exSolidWidth = value; this.Invalidate(); }
        }

        public int ExGapWidth
        {
            get { return exGapWidth; }
            set { exGapWidth = value; this.Invalidate(); }
        }

        public int ExLineSize
        {
            get { return exLineSize; }
            set { exLineSize = value; this.Invalidate(); }
        }

        public Direction ExLineDirection
        {
            get { return exLineDirection; }
            set { exLineDirection = value; this.Invalidate(); }
        }

        private void LineEx_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen exPen = new Pen(this.ForeColor, exLineSize);
            
            if (exLineDirection == Direction.Horizontal)
            {    
                int y = e.ClipRectangle.Y;
                int x = e.ClipRectangle.X;
                int x2 = x + e.ClipRectangle.Width;
                bool isSolid = true;
                while (x < x2)
                {
                    if (isSolid)
                    {
                        if (x + exSolidWidth <= x2)
                            g.DrawLine(exPen, x, y, x + exSolidWidth, y);
                        else
                            g.DrawLine(exPen, x, y, x2, y);
                        x += exSolidWidth;
                        isSolid = false;
                    }
                    else
                    {
                        x += exGapWidth;
                        isSolid = true;
                    }
                }
            }
            else
            {
                int x = e.ClipRectangle.X;
                int y = e.ClipRectangle.Y;
                int y2 = y + e.ClipRectangle.Height;
                bool isSolid = true;
                while (y < y2)
                {
                    if (isSolid)
                    {
                        if (y + exSolidWidth <= y2)
                            g.DrawLine(exPen, x, y, x, y + exSolidWidth);
                        else
                            g.DrawLine(exPen, x, y, x, y2);
                        y += exSolidWidth;
                        isSolid = false;
                    }
                    else
                    {
                        y += exGapWidth;
                        isSolid = true;
                    }
                }
            }
        }

        private void LineEx_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate(); 
        }
    }
}
