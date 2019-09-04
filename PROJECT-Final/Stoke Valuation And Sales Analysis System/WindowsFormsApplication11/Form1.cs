using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace WindowsFormsApplication11
{
    public partial class Form_Login : Form
    {

        public Form_Login()
        {
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            Thread.Sleep(5000);

            InitializeComponent();

            t.Abort();
        }

        public void SplashStart() 
        {
            Application.Run(new Form_Splash());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String Password;
            String Username;
            Username = comboBox1.Text;
            Password = textBox1.Text;
            {
                errorProvider1.Clear();
                if (comboBox1.Text == "")
                {
                    errorProvider1.SetError(comboBox1, "Select UserName");
                    MessageBox.Show("Please select Username", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboBox1.Focus();
                    return;
                }
                if (textBox1.Text == "")
                {
                    errorProvider1.SetError(textBox1, "Insert Password");
                    MessageBox.Show("Please enter Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Focus();
                    return;
                }

                SqlConnection con1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\My Documents\ESOFT\Educational\Projects\Our Project\Software\PROJECT-Final\Stoke Valuation And Sales Analysis System\WindowsFormsApplication11\Database1.mdf;Integrated Security=True;User Instance=True");

                SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) from Table_Login Where UserName  ='" + comboBox1.Text + "' and Passward  ='" + textBox1.Text + "'  ", con1);
                DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    if (comboBox1.Text == "Owner")
                    {
                        this.Hide();
                        Form_Owner fo = new Form_Owner();
                        fo.Show();
                    }
                    else if (comboBox1.Text == "Cashier")
                    {
                        this.Hide();
                        Form_Cashier fc = new Form_Cashier();
                        fc.Show();
                    }
                }

                else
                {
                    errorProvider1.SetError(textBox1, "Enter valid Password");
                    textBox1.Text = "";
                    MessageBox.Show("Please enter a valid password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form15 frm15 = new Form15();
            frm15.Show();
        }
    }
}
