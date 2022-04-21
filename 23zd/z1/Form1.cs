using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "3,251";
            textBox2.Text = "0,325";
            textBox3.Text = "0,466";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            textBox4.Text += Environment.NewLine +
                "X = " + x.ToString();

            double y = Convert.ToDouble(textBox2.Text); 
            textBox4.Text += Environment.NewLine +
                "Y = " + y.ToString();

            double z = Convert.ToDouble(textBox3.Text); 
            textBox4.Text += Environment.NewLine +
                "Z = " + z.ToString();

            double a = Math.Pow(y+Math.Pow(x - 1, 1 / 3), 1 / 4);
            double b = Math.Abs(x - y) * (Math.Sin(Math.Pow(2, z)) + Math.Tau);

            double print = a / b;
            textBox4.Text += Environment.NewLine +
                "Ответ = " + print.ToString();
        }
    }
}
