using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractionCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox3.Text);
            int den1 = Convert.ToInt32(textBox2.Text);
            int den2 = Convert.ToInt32(textBox4.Text);
            Fraction f5 = new Fraction(num1, den1);
            Fraction f6 = new Fraction(num2, den2);
            Fraction ris = f5.Sub(f6);
            label10.Text = ris.Extractnumerator().ToString();
            label11.Text = ris.Extractdenominator().ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox3.Text);
            int den1 = Convert.ToInt32(textBox2.Text);
            int den2 = Convert.ToInt32(textBox4.Text);
            Fraction f5 = new Fraction(num1, den1);
            Fraction f6 = new Fraction(num2, den2);
            Fraction ris = f5.Add(f6);
            label8.Text = ris.Extractnumerator().ToString();
            label9.Text = ris.Extractdenominator().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox3.Text);
            int den1 = Convert.ToInt32(textBox2.Text);
            int den2 = Convert.ToInt32(textBox4.Text);
            Fraction f3 = new Fraction(num1, den1);
            Fraction f4 = new Fraction(num2, den2);
            Fraction ris = f3.Moltiplication(f4);
            label12.Text = ris.Extractnumerator().ToString();
            label13.Text = ris.Extractdenominator().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox4.Text);
            int den1 = Convert.ToInt32(textBox3.Text);
            int den2 = Convert.ToInt32(textBox2.Text);
            Fraction f3 = new Fraction(num1, den1);
            Fraction f4 = new Fraction(num2, den2);
            Fraction ris = f3.Moltiplication(f4);
            label14.Text = ris.Extractnumerator().ToString();
            label15.Text = ris.Extractdenominator().ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
