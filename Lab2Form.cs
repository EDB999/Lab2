using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Lab2Form : Form
    {
        public Lab2Form()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double sum;
            double proiz;
            if (a != b)
            {
                sum = a + b;
                proiz = a * b;
                label3.Text = "Сумма введёных чисел: " + sum;
                label4.Text = "Произведение введёных чисел: " + proiz;
            }
            else label3.Text = "Введите числа неравные друг другу";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
