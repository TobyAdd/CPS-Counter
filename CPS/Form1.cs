using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPS
{
    public partial class Form1 : Form
    {
        int cps = 0;
        int best = 0;
        public Form1()
        {
            InitializeComponent();
        }



        private void UpdateCPS_Tick(object sender, EventArgs e)
        {
            if (cps>best)
            {
                best = cps;
                label2.Text = "Best Record: " + best.ToString();
            }
            label1.Text = "CPS: 0";
            cps = 0;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (button1.Text == "Start")
            {
                button1.Text = "Click";
                UpdateCPS.Enabled = true;
            }
            else if (button1.Text == "Click")
            {
                cps = cps + 1;
                label1.Text = "CPS: " + cps.ToString();
            }
        }
    }
}
