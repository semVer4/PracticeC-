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

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            int len = str.Length;

            int i = 0;
            var str1 = new StringBuilder();

            for (char j = 'а'; j <= 'я'; j++)
            {
                str1.Append(j.ToString());
                
                foreach (char c in str)
                {
                    if (Convert.ToString(c) == j.ToString())
                    {
                        label3.Text = str.Replace(j.ToString(), "+");
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Hello, Wоrld!");
            listBox1.Items.Add("Hоw аre yоu?");
            listBox1.Items.Add("testп");
        }
    }
}
