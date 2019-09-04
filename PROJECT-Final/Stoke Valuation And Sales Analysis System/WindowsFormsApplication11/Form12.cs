using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication11
{
    public partial class Form_ViewStock : Form
    {
        SqlConnection connm = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\My Documents\ESOFT\Educational\Projects\Our Project\Software\PROJECT-Final\Stoke Valuation And Sales Analysis System\WindowsFormsApplication11\Database1.mdf;Integrated Security=True;User Instance=True");

        public Form_ViewStock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Cashier frm2 = new Form_Cashier();
            frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            SqlDataReader dr1 = null;
            SqlCommand com2 = new SqlCommand("SELECT*FROM Table_Stock WHERE Date='" + theDate + "'", connm);
            try
            {
                connm.Open();
            }
            catch
            {
                MessageBox.Show("error in searching");
            }
            dr1 = com2.ExecuteReader();

            if (dr1.Read())
            {
                textBox10.Text = dr1[1].ToString();
                textBox9.Text = dr1[2].ToString();
                textBox3.Text = dr1[3].ToString();
                textBox4.Text = dr1[4].ToString();
                textBox5.Text = dr1[5].ToString();
                textBox6.Text = dr1[6].ToString();
                textBox7.Text = dr1[7].ToString();
                textBox8.Text = dr1[8].ToString();
                textBox11.Text = dr1[9].ToString();
                textBox12.Text = dr1[10].ToString();

            }
            else
            {
                MessageBox.Show("Invalid Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBox10.Clear();
                textBox9.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox11.Clear();
                textBox12.Clear();

            }

            dr1.Close();
            connm.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox10.Clear();
            textBox9.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox11.Clear();
            textBox12.Clear();
        }

        private void Form_ViewStock_Load(object sender, EventArgs e)
        {
            
        }
    }
}
