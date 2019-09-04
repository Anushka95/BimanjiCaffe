using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Please Enter First Input");
            }
            else if (textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, "Please Enter Second Input");
            }
            else
            {
                double no1 = double.Parse(textBox1.Text);
                double no2 = double.Parse(textBox2.Text);
                double sum = no1 + no2;
                label3.Text = "SUM";
                label5.Text = textBox1.Text + " + " + textBox2.Text;
                textBox3.Text = sum.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {errorProvider1.Clear();
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Please Enter First Input");
            }
            else if (textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, "Please Enter Second Input");
            }
            else
            {
                double no1 = double.Parse(textBox1.Text);
                double no2 = double.Parse(textBox2.Text);
                double sub = no1 - no2;
                label3.Text = "SUB";
                label5.Text = textBox1.Text + " - " + textBox2.Text;
                textBox3.Text = sub.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Please Enter First Input");
            }
            else if (textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, "Please Enter Second Input");
            }
            else
            {
                double no1 = double.Parse(textBox1.Text);
                double no2 = double.Parse(textBox2.Text);
                double mul = no1 * no2;
                label3.Text = "MUL";
                label5.Text = textBox1.Text + " * " + textBox2.Text;
                textBox3.Text = mul.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Please Enter First Input");
            }
            else if (textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, "Please Enter Second Input");
            }
            else
            {
                double no1 = double.Parse(textBox1.Text);
                double no2 = double.Parse(textBox2.Text);
                double div = no1 / no2;
                label3.Text = "DIV";
                label5.Text = textBox1.Text + " / " + textBox2.Text;
                textBox3.Text = div.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Text = textBox3.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox2.Text = textBox3.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
