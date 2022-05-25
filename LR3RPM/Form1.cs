using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR3RPM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            
            textBox4.Text = "Результаты работы программы " +
              "ст. Сабарайкина М.А " +
              Environment.NewLine;
            textBox4.Text += "При X = " + textBox1.Text +
                     Environment.NewLine;
            textBox4.Text += "При Y = " + textBox2.Text +
                     Environment.NewLine;

            double d, f = x;
            if (radioButton1.Checked)
                f = Math.Sinh(x);
            else if (radioButton2.Checked)
                f = Math.Pow(x, 2);
            else if (radioButton3.Checked)
                f = Math.Exp(x);

            if (x > y)
                d = Math.Pow((f - y), 3) + Math.Atan(f);
            else
                d = Math.Pow((y - f), 3) + Math.Atan(f);
            if (y == x)
                d = Math.Pow((y + f), 3) + 0.5;
            textBox4.Text += "d = " + d.ToString() +
                     Environment.NewLine;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
