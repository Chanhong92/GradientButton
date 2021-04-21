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
        private float splitLine = 0.3f;
        private float rotate = 70f;
        private bool selected = false;
        private int Interval = 10;

        private float currentLine = 1f;
        private bool isSet = false;

        Timer bt_tmr = new Timer();

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

        public int AniInterval
        {
            get
            {
                return Interval;
            }
            set
            {
                Interval = value;
            }
        }

        private void btTmr_Tick(object sender, EventArgs e)
        {
            if( (currentLine >= splitLine) && (this.selected == true) )
            {
                currentLine -= splitLine / 10;
                this.Invalidate();
            }
            else
            {
                bt_tmr.Stop();
            }
        }

        public void Bt_Animation()
        {
            if(bt_tmr.Enabled == true)
            {
                bt_tmr.Stop();
            }

            if(isSet == false) //bt_tmr.Tick 이 계속 추가돼서...
            {
                isSet = true;
                bt_tmr.Interval = Interval;
                bt_tmr.Tick += btTmr_Tick;
            }

            currentLine = 1f;

            if(Interval > 0)
            {
                bt_tmr.Start();
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            LinearGradientBrush lgb = new LinearGradientBrush(
                this.ClientRectangle, firstColor, secondColor, 0f);

            ColorBlend cb = new ColorBlend();
            cb.Positions = new float[] { 0, currentLine, 1 };

            if (selected == true) { cb.Colors = new Color[] { firstColor, firstColor, secondColor }; }
            else { cb.Colors = new Color[] { firstColor, firstColor, firstColor }; }
            
            lgb.InterpolationColors = cb;

            lgb.RotateTransform(rotate);

            pevent.Graphics.FillRectangle(lgb, this.ClientRectangle);
            lgb.Dispose();
            SizeF textSize = pevent.Graphics.MeasureString(this.Text, this.Font);

            if(selected == true)
            {
                pevent.Graphics.DrawString(this.Text, this.Font, new SolidBrush(secondColor),
                    (Width - textSize.Width) / 2, (Height - textSize.Height) / 2);
            }
            else
            {
                pevent.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor),
                    (Width - textSize.Width) / 2, (Height - textSize.Height) / 2);
            }
            
        }
    }
}
