using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text.Replace(".", ","));
            int n = int.Parse(comboBox1.Text);
            double E = double.Parse(textBox2.Text.Replace(".", ","));
            double lastElem = 0;
            double Atg = MyMath.Arctg(x, n, ref lastElem);
            textBox6.Text = Convert.ToString(Math.Atan(x));
            textBox3.Text = Convert.ToString(Atg);
            textBox4.Text = Convert.ToString((Math.Abs(Math.Atan(x) - Atg)));
            if (Math.Log(1 + x) - Atg > Math.Abs(lastElem)) textBox5.Text = "Погрешность больше модуля последнего слогаемого";
            else textBox5.Text = "Погрешность меньше модуля последнего слогаемого";
            int N = 0;
            textBox7.Text = Convert.ToString(MyMath.SumLast(x, E, ref N));
            textBox8.Text = Convert.ToString(N);
            textBox9.Text = Convert.ToString(MyMath.SumLast(x, E / 10, ref N));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
