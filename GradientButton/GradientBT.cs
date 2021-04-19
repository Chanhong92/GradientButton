using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GradientButton
{
    class GradientBT:Button
    {
        private Color firstColor = Color.Black;
        private Color secondColor = Color.SkyBlue;
        private float splitLine = 0.5f;
        private float rotate = 0f;
        private bool selected = false;

        public Color FirstColor
        {
            get
            {
                return firstColor;
            }
            set
            {
                firstColor = value;
                this.Invalidate();
            }
        }

        public Color SecondColor
        {
            get
            {
                return secondColor;
            }
            set
            {
                secondColor = value;
                this.Invalidate();
            }
        }

        public float RotateAngle
        {
            get
            {
                return rotate;
            }
            set
            {
                rotate = value;
                this.Invalidate();
            }
        }

        public float SplitLine
        {
            get
            {
                return splitLine;
            }
            set
            {
                splitLine = value;
                this.Invalidate();
            }
        }

        public bool Selected
        {
            get
            {
                return selected;
            }
            set
            {
                selected = value;
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            LinearGradientBrush lgb = new LinearGradientBrush(
                this.ClientRectangle, firstColor, secondColor, 0f);

            ColorBlend cb = new ColorBlend();
            cb.Positions = new float[] { 0, splitLine, 1 };

            if (selected == true) { cb.Colors = new Color[] { firstColor, firstColor, secondColor }; }
            else { cb.Colors = new Color[] { firstColor, firstColor, firstColor }; }
            
            lgb.InterpolationColors = cb;

            lgb.RotateTransform(rotate);

            pevent.Graphics.FillRectangle(lgb, this.ClientRectangle);
            lgb.Dispose();
            SizeF textSize = pevent.Graphics.MeasureString(this.Text, this.Font);
            pevent.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), 
                (Width - textSize.Width) / 2, (Height - textSize.Height) / 2);
        }
    }
}
