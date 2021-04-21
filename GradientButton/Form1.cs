using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradientButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gradientBT1_Click(object sender, EventArgs e)
        {
            gradientBT1.Selected = true;
            gradientBT2.Selected = false;
            gradientBT3.Selected = false;
            gradientBT4.Selected = false;

            gradientBT1.Bt_Animation();
        }

        private void gradientBT2_Click(object sender, EventArgs e)
        {
            gradientBT1.Selected = false;
            gradientBT2.Selected = true;
            gradientBT3.Selected = false;
            gradientBT4.Selected = false;

            gradientBT2.Bt_Animation();
        }

        private void gradientBT3_Click(object sender, EventArgs e)
        {
            gradientBT1.Selected = false;
            gradientBT2.Selected = false;
            gradientBT3.Selected = true;
            gradientBT4.Selected = false;

            gradientBT3.Bt_Animation();
        }

        private void gradientBT4_Click(object sender, EventArgs e)
        {
            gradientBT1.Selected = false;
            gradientBT2.Selected = false;
            gradientBT3.Selected = false;
            gradientBT4.Selected = true;

            gradientBT4.Bt_Animation();
        }
    }
}
