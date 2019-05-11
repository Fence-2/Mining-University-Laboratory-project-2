using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0,4e+4";
            textBox2.Text = "-0,875";
            textBox3.Text = "-0,475e-3";

            this.Text = "Лаб. работа №2.3 Чистякова Дмитрия, ИАС-18-2";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = "Лаб. работа №2.3 Чистякова Дмитрия, ИАС-18-2";

            double x = double.Parse(textBox1.Text);
            textBox4.Text += Environment.NewLine + "X = " + x.ToString();

            double y = double.Parse(textBox2.Text);
            textBox4.Text += Environment.NewLine + "Y = " + y.ToString();

            double z = double.Parse(textBox3.Text);
            textBox4.Text += Environment.NewLine + "Z = " + z.ToString();

            double a = 1 + 2 * Math.Sin(y) * Math.Sin(y);
            double b = Math.Abs(Math.Cos(x) - Math.Cos(y));
            double c = 1 + z + z * z / 2 + Math.Pow(z, 3) / 3 + Math.Pow(z, 4) / 4;
            b = Math.Pow(b, a);
            double v = b * c;


            textBox4.Text += Environment.NewLine + "Результат v = " + v.ToString();
        }

    }
}
