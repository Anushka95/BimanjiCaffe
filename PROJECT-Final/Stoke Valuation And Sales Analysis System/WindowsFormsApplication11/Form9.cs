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
    public partial class Form_SalesIncome : Form
    {
        double salesRolls;
        double salesBuns;
        double salesFishbuns;
        double salesEggbuns;
        double salesPastry;
        double salesVade;
        double salesUlunduvade;
        double salesCupcake;
        double salesPatis;
        double salesRotti;

        double PriceRolls;
        double PriceBuns;
        double PriceFishbuns;
        double PriceEggbuns;
        double PricePastry;
        double PriceVade;
        double PriceUlunduvade;
        double PriceCupcake;
        double PricePatis;
        double PriceRotti;

        SqlConnection connn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\My Documents\ESOFT\Educational\Projects\Our Project\Software\PROJECT-Final\Stoke Valuation And Sales Analysis System\WindowsFormsApplication11\Database1.mdf;Integrated Security=True;User Instance=True");

        public Form_SalesIncome()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_Owner frm3 = new Form_Owner();
            frm3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String thedate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            SqlDataReader dr2 = null;
            SqlCommand com3 = new SqlCommand("SELECT*FROM Table_Sales WHERE Date='" + thedate + "'", connn);
            try
            {
                connn.Open();
            }
            catch
            {
                MessageBox.Show("error in searching");
            }
            dr2 = com3.ExecuteReader();

            if (dr2.Read())
            {
                salesRolls = double.Parse(dr2[1].ToString());
                salesBuns = double.Parse(dr2[2].ToString());
                salesFishbuns = double.Parse(dr2[3].ToString());
                salesEggbuns = double.Parse(dr2[4].ToString());
                salesPastry = double.Parse(dr2[5].ToString());
                salesVade = double.Parse(dr2[6].ToString());
                salesUlunduvade = double.Parse(dr2[7].ToString());
                salesCupcake = double.Parse(dr2[8].ToString());
                salesPatis = double.Parse(dr2[9].ToString());
                salesRotti = double.Parse(dr2[10].ToString());


            }
            else
            {
                MessageBox.Show("Invalid Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dr2.Close();
            connn.Close();


            String key = "key";
            SqlDataReader dr3 = null;
            SqlCommand com1 = new SqlCommand("SELECT * FROM Table_Prices WHERE TheKey='" + key + "'", connn);

            try
            {
                connn.Open();
            }
            catch
            {
                MessageBox.Show("error in searcing");
            }
            dr3 = com1.ExecuteReader();

            if (dr3.Read())
            {
                PriceRolls = double.Parse(dr3[1].ToString());
                PriceBuns = double.Parse(dr3[2].ToString());
                PriceFishbuns = double.Parse(dr3[3].ToString());
                PriceEggbuns = double.Parse(dr3[4].ToString());
                PricePastry = double.Parse(dr3[5].ToString());
                PriceVade = double.Parse(dr3[6].ToString());
                PriceUlunduvade = double.Parse(dr3[7].ToString());
                PriceCupcake = double.Parse(dr3[8].ToString());
                PricePatis = double.Parse(dr3[9].ToString());
                PriceRotti = double.Parse(dr3[10].ToString());
            }
            else
                MessageBox.Show("Invalid search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dr3.Close();
            connn.Close();

            textBox1.Text = salesRolls.ToString();
            textBox2.Text = salesBuns.ToString();
            textBox3.Text = salesFishbuns.ToString();
            textBox4.Text = salesEggbuns.ToString();
            textBox5.Text = salesPastry.ToString();
            textBox6.Text = salesVade.ToString();
            textBox7.Text = salesUlunduvade.ToString();
            textBox8.Text = salesCupcake.ToString();
            textBox21.Text = salesPatis.ToString();
            textBox22.Text = salesRotti.ToString();
            textBox9.Text = (salesRolls + salesBuns + salesFishbuns + salesEggbuns + salesPastry + salesVade + salesUlunduvade + salesCupcake + salesPatis + salesRotti).ToString();

            double in1 = salesRolls * PriceRolls;
            double in2 = salesBuns * PriceBuns;
            double in3 = salesFishbuns * PriceFishbuns;
            double in4 = salesEggbuns * PriceEggbuns;
            double in5 = salesPastry * PricePastry;
            double in6 = salesVade * PriceVade;
            double in7 = salesUlunduvade * PriceUlunduvade;
            double in8 = salesCupcake * PriceCupcake;
            double in9 = salesPatis * PricePatis;
            double in10 = salesRotti * PriceRotti;

            textBox18.Text = in1.ToString();
            textBox17.Text = in2.ToString();
            textBox16.Text = in3.ToString();
            textBox15.Text = in4.ToString();
            textBox14.Text = in5.ToString();
            textBox13.Text = in6.ToString();
            textBox12.Text = in7.ToString();
            textBox11.Text = in8.ToString();
            textBox19.Text = in9.ToString();
            textBox20.Text = in10.ToString();
            textBox10.Text = (in1 + in2 + in3 + in4 + in5 + in6 + in7 + in8 + in9 + in10).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox21.Clear();
            textBox22.Clear();
            textBox9.Clear();
            textBox18.Clear();
            textBox17.Clear();
            textBox16.Clear();
            textBox15.Clear();
            textBox14.Clear();
            textBox13.Clear();
            textBox12.Clear();
            textBox11.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox10.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.Show();
            this.Hide();
        }
    }
}
