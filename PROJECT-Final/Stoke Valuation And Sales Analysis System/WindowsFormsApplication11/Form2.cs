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
    public partial class Form_Cashier : Form
    {
        public Form_Cashier()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_SelectFoodsCashier frm11 = new Form_SelectFoodsCashier();
            frm11.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_ViewStock frm12 = new Form_ViewStock();
            frm12.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_ViewPrices frm13 = new Form_ViewPrices();
            frm13.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to Log Out?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.Yes)
            {
                Form_Login frm1 = new Form_Login();
                frm1.Show();
                this.Hide();
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form_PasswordChange pc = new Form_PasswordChange();
            pc.Show();
        }

        private void Form_Cashier_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form16 frm16 = new Form16();
            frm16.Show();
        }
    }
}
