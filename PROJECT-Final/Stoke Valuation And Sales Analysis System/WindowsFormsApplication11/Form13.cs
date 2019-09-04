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
    public partial class Form_ViewPrices : Form
    {
        SqlConnection connnm = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\My Documents\ESOFT\Educational\Projects\Our Project\Software\PROJECT-Final\Stoke Valuation And Sales Analysis System\WindowsFormsApplication11\Database1.mdf;Integrated Security=True;User Instance=True");

        public Form_ViewPrices()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Cashier frm2 = new Form_Cashier();
            frm2.Show();
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String key = "key";
            SqlDataReader dr2 = null;
            SqlCommand com1 = new SqlCommand("SELECT * FROM Table_Prices WHERE TheKey='" + key + "'", connnm);

            try
            {
                connnm.Open();
            }
            catch
            {
                MessageBox.Show("error in searcing");
            }
            dr2 = com1.ExecuteReader();

            if (dr2.Read())
            {
                textBox1.Text = dr2[1].ToString();
                textBox2.Text = dr2[2].ToString();
                textBox3.Text = dr2[3].ToString();
                textBox4.Text = dr2[4].ToString();
                textBox5.Text = dr2[5].ToString();
                textBox6.Text = dr2[6].ToString();
                textBox7.Text = dr2[7].ToString();
                textBox8.Text = dr2[8].ToString();
                textBox9.Text = dr2[9].ToString();
                textBox10.Text = dr2[10].ToString();
            }
            else
                MessageBox.Show("Invalid search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dr2.Close();
            connnm.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
        }
    }
}
