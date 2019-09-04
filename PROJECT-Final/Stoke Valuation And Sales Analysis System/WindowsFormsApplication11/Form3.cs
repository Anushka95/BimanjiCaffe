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
    public partial class Form_Owner : Form
    {
        public Form_Owner()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_SalesIncome frm7 = new Form_SalesIncome();
            frm7.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form_SalesIncome frm9 = new Form_SalesIncome();
            frm9.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_SelectFoodsOwner frm4 = new Form_SelectFoodsOwner();
            frm4.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_Stock frm5 = new Form_Stock();
            frm5.Show();
            this.Hide();
            MessageBox.Show("Please 'INSERT' the 'STOCK' for a new day.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_Prices frm6 = new Form_Prices();
            frm6.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Stock frm5 = new Form_Stock();
            frm5.Show();
            this.Hide();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to Log Out?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.Yes)
            {
                Form_Login frm1 = new Form_Login();
                frm1.Show();
                this.Hide();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form_PasswordChange pc = new Form_PasswordChange();
            pc.Show();
        }

        private void Form_Owner_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form16 frm16 = new Form16();
            frm16.Show();
        }
    }
}
