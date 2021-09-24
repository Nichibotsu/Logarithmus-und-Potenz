using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parameter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private double Hoch(float x,int y)
        {
            double c = Math.Pow(x, y);
            c = Math.Round(c, 4);
            return c;
            
        }
        private double Log(float h,int i)
        {
            double j = Math.Log(h);
            double k = Math.Log(i);
            double l = k / j;
            l = Math.Round(l, 4);

            return l;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            float d;
            int f;
            float a;
            int b;
            d = float.Parse(textBox1.Text);
            f = Convert.ToInt32(textBox2.Text);
            b = Convert.ToInt32(textBox2.Text);
            a = float.Parse(textBox1.Text);
            Hoch(a, b);
            Log(d, f);

            label4.Text = "Potenz:" + Convert.ToString(Hoch(a,b));
            label3.Text = "Logarithmus:" + Convert.ToString(Log(d, f));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Text = "";
            label3.Text = "Logarithmus";
            label4.Text = "Potenz";

        }
    }
}
