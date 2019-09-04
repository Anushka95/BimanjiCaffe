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
    public partial class Form_Stock : Form
    {
        SqlConnection con2 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\My Documents\ESOFT\Educational\Projects\Our Project\Software\PROJECT-Final\Stoke Valuation And Sales Analysis System\WindowsFormsApplication11\Database1.mdf;Integrated Security=True;User Instance=True");
        public Form_Stock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Owner frm3 = new Form_Owner();
            frm3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            DialogResult dr1 = MessageBox.Show("Are you sure you want to 'INSERT' Stock for "+theDate+"?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dr1 == DialogResult.Yes)
            {

                SqlCommand comm = new SqlCommand("INSERT INTO Table_Stock(Date,Rolls,Buns,FishBuns,EggBuns,Pastry,Vade,UlunduVade,CupCake,Patis,Rotti)Values(@date,@rolls,@buns,@fishbuns,@eggbuns,@pastry,@vade,@ulunduvade,@cupcake,@patis,@rotti)", con2);
                comm.Parameters.Add("@date", theDate);
                comm.Parameters.Add("@rolls", textBox1.Text);
                comm.Parameters.Add("@buns", textBox2.Text);
                comm.Parameters.Add("@fishbuns", textBox3.Text);
                comm.Parameters.Add("@eggbuns", textBox4.Text);
                comm.Parameters.Add("@pastry", textBox5.Text);
                comm.Parameters.Add("@vade", textBox6.Text);
                comm.Parameters.Add("@ulunduvade", textBox7.Text);
                comm.Parameters.Add("@cupcake", textBox8.Text);
                comm.Parameters.Add("@patis", textBox9.Text);
                comm.Parameters.Add("@rotti", textBox10.Text);



                SqlCommand com5 = new SqlCommand("INSERT INTO Table_Sales(Date,Rolls,Buns,FishBuns,EggBuns,Pastry,Vade,UlunduVade,CupCake,Patis,Rotti)Values(@date,@rolls,@buns,@fishbuns,@eggbuns,@pastry,@vade,@ulunduvade,@cupcake,@patis,@rotti)", con2);
                com5.Parameters.Add("@date", theDate);
                com5.Parameters.Add("@rolls", "0");
                com5.Parameters.Add("@buns", "0");
                com5.Parameters.Add("@fishbuns", "0");
                com5.Parameters.Add("@eggbuns", "0");
                com5.Parameters.Add("@pastry", "0");
                com5.Parameters.Add("@vade", "0");
                com5.Parameters.Add("@ulunduvade", "0");
                com5.Parameters.Add("@cupcake", "0");
                com5.Parameters.Add("@patis", "0");
                com5.Parameters.Add("@rotti", "0");

                con2.Open();
                comm.ExecuteNonQuery();
                com5.ExecuteNonQuery();
                MessageBox.Show("Insert Successful");
                con2.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            SqlDataReader dr1 = null;
            SqlCommand com2 = new SqlCommand("SELECT*FROM Table_Stock WHERE Date='" + theDate + "'", con2);
            try
            {
                con2.Open();
            }
            catch
            {
                MessageBox.Show("error in searching");
            }
            dr1 = com2.ExecuteReader();

            if (dr1.Read())
            {
                textBox1.Text = dr1[1].ToString();
                textBox2.Text = dr1[2].ToString();
                textBox3.Text = dr1[3].ToString();
                textBox4.Text = dr1[4].ToString();
                textBox5.Text = dr1[5].ToString();
                textBox6.Text = dr1[6].ToString();
                textBox7.Text = dr1[7].ToString();
                textBox8.Text = dr1[8].ToString();
                textBox9.Text = dr1[9].ToString();
                textBox10.Text = dr1[10].ToString();

            }
            else
                MessageBox.Show("Invalid Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dr1.Close();
            con2.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            DialogResult dr = MessageBox.Show("Are you sure you want to 'DELETE' Stock for "+theDate+"?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.Yes)
            {
                SqlCommand comm = new SqlCommand("DELETE FROM Table_Stock WHERE Date=@date", con2);
                comm.Parameters.Add("@date", theDate);

                con2.Open();
                comm.ExecuteNonQuery();
                con2.Close();

                SqlCommand commn = new SqlCommand("DELETE FROM Table_Sales WHERE Date=@date", con2);
                commn.Parameters.Add("@date", theDate);

                con2.Open();
                commn.ExecuteNonQuery();
                MessageBox.Show("Delete Successful");
                con2.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            DialogResult dr2 = MessageBox.Show("Are you sure you want to 'UPDATE' Stock for "+theDate+"?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dr2 == DialogResult.Yes)
            {
                SqlCommand comm = new SqlCommand("UPDATE Table_Stock SET Rolls=@rolls , Buns=@buns , FishBuns=@fishbuns , EggBuns=@eggBuns , Pastry=@pastry , Vade=@vade , UlunduVade=@ulunduvade , CupCake=@cupcake , Patis=@patis , Rotti=@rotti WHERE Date=@date", con2);
                comm.Parameters.Add("@date", theDate);
                comm.Parameters.Add("@rolls", textBox1.Text);
                comm.Parameters.Add("@buns", textBox2.Text);
                comm.Parameters.Add("@fishbuns", textBox3.Text);
                comm.Parameters.Add("@eggBuns", textBox4.Text);
                comm.Parameters.Add("@pastry", textBox5.Text);
                comm.Parameters.Add("@vade", textBox6.Text);
                comm.Parameters.Add("@ulunduvade", textBox7.Text);
                comm.Parameters.Add("@cupcake", textBox8.Text);
                comm.Parameters.Add("@patis", textBox9.Text);
                comm.Parameters.Add("@rotti", textBox10.Text);

                con2.Open();
                comm.ExecuteNonQuery();
                MessageBox.Show("Update Successful");
                con2.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
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

        private void Form_Stock_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox4.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox7.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox8.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox9.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox10.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 frm10 = new Form10();
            frm10.Show();
        }
    }
}
