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
    public partial class Form_Prices : Form
    {
        SqlConnection con4 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\My Documents\ESOFT\Educational\Projects\Our Project\Software\PROJECT-Final\Stoke Valuation And Sales Analysis System\WindowsFormsApplication11\Database1.mdf;Integrated Security=True;User Instance=True");
        public Form_Prices()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Owner frm3 = new Form_Owner();
            frm3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String key="key";
            SqlDataReader dr2 = null;
            SqlCommand com1 = new SqlCommand("SELECT * FROM Table_Prices WHERE TheKey='" + key + "'", con4);

            try
            {
                con4.Open();
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
            con4.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult dr2 = MessageBox.Show("Are you sure you want to 'UPDATE' Prices?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dr2 == DialogResult.Yes)
            {
                String key = "key";
                SqlCommand comm = new SqlCommand("UPDATE Table_Prices SET Roll=@roll , Bun=@bun , FishBun=@fishbun , EggBun=@eggBun , Pastry=@pastry , Vade=@vade , UlunduVade=@ulunduvade , CupCake=@cupcake , Patis=@patis , Rotti=@rotti WHERE TheKey=@thekey", con4);
                comm.Parameters.Add("@thekey", key);
                comm.Parameters.Add("@roll", textBox1.Text);
                comm.Parameters.Add("@bun", textBox2.Text);
                comm.Parameters.Add("@fishbun", textBox3.Text);
                comm.Parameters.Add("@eggBun", textBox4.Text);
                comm.Parameters.Add("@pastry", textBox5.Text);
                comm.Parameters.Add("@vade", textBox6.Text);
                comm.Parameters.Add("@ulunduvade", textBox7.Text);
                comm.Parameters.Add("@cupcake", textBox8.Text);
                comm.Parameters.Add("@patis", textBox9.Text);
                comm.Parameters.Add("@rotti", textBox10.Text);

                con4.Open();
                comm.ExecuteNonQuery();
                MessageBox.Show("Update Successful");
                con4.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox7.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox8.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox9.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox10.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
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

        private void Form_Prices_Load(object sender, EventArgs e)
        {

        }
    }
}
