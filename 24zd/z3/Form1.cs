using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Print(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawEllipse(new Pen(Color.Green, 5), 50, 50, 100, 100);
            g.FillEllipse(new SolidBrush(Color.Blue), 50, 50, 100, 100);
            g.FillEllipse(new SolidBrush(Color.Yellow), 70, 80, 12, 12);
            g.FillEllipse(new SolidBrush(Color.Yellow), 120, 80, 12, 12);
            g.DrawArc(new Pen(Color.Azure, 3), 85, 110, 30, 20, 0, 180);
        }
    }
}
