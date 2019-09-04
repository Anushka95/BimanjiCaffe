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
    public partial class Form_SelectFoodsOwner : Form
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

        double stockRolls;
        double stockBuns;
        double stockFishbuns;
        double stockEggbuns;
        double stockPastry;
        double stockVade;
        double stockUlunduvade;
        double stockCupcake;
        double stockPatis;
        double stockRotti;

        SqlConnection connn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\My Documents\ESOFT\Educational\Projects\Our Project\Software\PROJECT-Final\Stoke Valuation And Sales Analysis System\WindowsFormsApplication11\Database1.mdf;Integrated Security=True;User Instance=True");
        public Form_SelectFoodsOwner()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "0";
            comboBox2.Text = "0";
            comboBox3.Text = "0";
            comboBox4.Text = "0";
            comboBox5.Text = "0";
            comboBox6.Text = "0";
            comboBox7.Text = "0";
            comboBox8.Text = "0";
            comboBox9.Text = "0";
            comboBox10.Text = "0";
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Owner frm3 = new Form_Owner();
            frm3.Show();
            this.Hide();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            double slctRolls = double.Parse(comboBox1.Text);
            double slctBuns = double.Parse(comboBox2.Text);
            double slctFishbuns = double.Parse(comboBox3.Text);
            double slctEggbuns = double.Parse(comboBox4.Text);
            double slctPastry = double.Parse(comboBox5.Text);
            double slctVade = double.Parse(comboBox6.Text);
            double slctUlunduvade = double.Parse(comboBox7.Text);
            double slctCupcake = double.Parse(comboBox8.Text);
            double slctPatis = double.Parse(comboBox9.Text);
            double slctRotti = double.Parse(comboBox10.Text);

            String theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            SqlDataReader dr1 = null;
            SqlCommand com2 = new SqlCommand("SELECT*FROM Table_Stock WHERE Date='" + theDate + "'", connn);
            try
            {
                connn.Open();
            }
            catch
            {
                MessageBox.Show("error in searching");
            }
            dr1 = com2.ExecuteReader();

            if (dr1.Read())
            {
                stockRolls = double.Parse(dr1[1].ToString());
                stockBuns = double.Parse(dr1[2].ToString());
                stockFishbuns = double.Parse(dr1[3].ToString());
                stockEggbuns = double.Parse(dr1[4].ToString());
                stockPastry = double.Parse(dr1[5].ToString());
                stockVade = double.Parse(dr1[6].ToString());
                stockUlunduvade = double.Parse(dr1[7].ToString());
                stockCupcake = double.Parse(dr1[8].ToString());
                stockPatis = double.Parse(dr1[9].ToString());
                stockRotti = double.Parse(dr1[10].ToString());
            }
            
            dr1.Close();
            connn.Close();

            
            
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
                MessageBox.Show("Update Successful");


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

            double newstockRolls = stockRolls - slctRolls;
            double newstockBuns = stockBuns - slctBuns;
            double newstockFishbuns = stockFishbuns - slctFishbuns;
            double newstockEggbuns = stockEggbuns - slctEggbuns;
            double newstockPastry = stockPastry - slctPastry;
            double newstockVade = stockVade - slctVade;
            double newstockUlunduvade = stockUlunduvade - slctUlunduvade;
            double newstockCupcake = stockCupcake - slctCupcake;
            double newstockPatis = stockPatis - slctPatis;
            double newstockRotti = stockRotti - slctRotti;

            double newsalesRolls = salesRolls + slctRolls;
            double newsalesBuns = salesBuns + slctBuns;
            double newsalesFishbuns = salesFishbuns + slctFishbuns;
            double newsalesEggbuns = salesEggbuns + slctEggbuns;
            double newsalesPastry = salesPastry + slctPastry;
            double newsalesVade = salesVade + slctVade;
            double newsalesUlunduvade = salesUlunduvade + slctUlunduvade;
            double newsalesCupcake = salesCupcake + slctCupcake;
            double newsalesPatis = salesPatis + slctPatis;
            double newsalesRotti = salesRotti + slctRotti;


            String theDAte = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            SqlCommand comm = new SqlCommand("UPDATE Table_Stock SET Rolls=@rolls , Buns=@buns , FishBuns=@fishbuns , EggBuns=@eggBuns , Pastry=@pastry , Vade=@vade , UlunduVade=@ulunduvade , CupCake=@cupcake , Patis=@patis , Rotti=@rotti WHERE Date=@date", connn);
            comm.Parameters.Add("@date", theDAte);
            comm.Parameters.Add("@rolls", newstockRolls.ToString());
            comm.Parameters.Add("@buns", newstockBuns);
            comm.Parameters.Add("@fishbuns", newstockFishbuns);
            comm.Parameters.Add("@eggBuns", newstockEggbuns);
            comm.Parameters.Add("@pastry", newstockPastry);
            comm.Parameters.Add("@vade", newstockVade);
            comm.Parameters.Add("@ulunduvade", newstockUlunduvade);
            comm.Parameters.Add("@cupcake", newstockCupcake);
            comm.Parameters.Add("@patis", newstockPatis);
            comm.Parameters.Add("@rotti", newstockRotti);

            connn.Open();
            comm.ExecuteNonQuery();
            connn.Close();

            String theDATe = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            SqlCommand commm = new SqlCommand("UPDATE Table_Sales SET Rolls=@rolls , Buns=@buns , FishBuns=@fishbuns , EggBuns=@eggBuns , Pastry=@pastry , Vade=@vade , UlunduVade=@ulunduvade , CupCake=@cupcake , Patis=@patis , Rotti=@rotti WHERE Date=@date", connn);
            commm.Parameters.Add("@date", theDATe);
            commm.Parameters.Add("@rolls", newsalesRolls.ToString());
            commm.Parameters.Add("@buns", newsalesBuns.ToString());
            commm.Parameters.Add("@fishbuns", newsalesFishbuns.ToString());
            commm.Parameters.Add("@eggBuns", newsalesEggbuns.ToString());
            commm.Parameters.Add("@pastry", newsalesPastry.ToString());
            commm.Parameters.Add("@vade", newsalesVade.ToString());
            commm.Parameters.Add("@ulunduvade", newsalesUlunduvade.ToString());
            commm.Parameters.Add("@cupcake", newsalesCupcake.ToString());
            commm.Parameters.Add("@patis", newsalesPatis.ToString());
            commm.Parameters.Add("@rotti", newsalesRotti.ToString());

            connn.Open();
            commm.ExecuteNonQuery();
            connn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double selctRolls = double.Parse(comboBox1.Text);
            double selctBuns = double.Parse(comboBox2.Text);
            double selctFishbuns = double.Parse(comboBox3.Text);
            double selctEggbuns = double.Parse(comboBox4.Text);
            double selctPastry = double.Parse(comboBox5.Text);
            double selctVade = double.Parse(comboBox6.Text);
            double selctUlunduvade = double.Parse(comboBox7.Text);
            double selctCupcake = double.Parse(comboBox8.Text);
            double selctPatis = double.Parse(comboBox9.Text);
            double selctRotti = double.Parse(comboBox10.Text);


            String key = "key";
            SqlDataReader dr6 = null;
            SqlCommand com1 = new SqlCommand("SELECT * FROM Table_Prices WHERE TheKey='" + key + "'", connn);

            try
            {
                connn.Open();
            }
            catch
            {
                MessageBox.Show("error in searcing");
            }
            dr6 = com1.ExecuteReader();

            if (dr6.Read())
            {
                PriceRolls = double.Parse(dr6[1].ToString());
                PriceBuns = double.Parse(dr6[2].ToString());
                PriceFishbuns = double.Parse(dr6[3].ToString());
                PriceEggbuns = double.Parse(dr6[4].ToString());
                PricePastry = double.Parse(dr6[5].ToString());
                PriceVade = double.Parse(dr6[6].ToString());
                PriceUlunduvade = double.Parse(dr6[7].ToString());
                PriceCupcake = double.Parse(dr6[8].ToString());
                PricePatis = double.Parse(dr6[9].ToString());
                PriceRotti = double.Parse(dr6[10].ToString());
            }
            else
                MessageBox.Show("Invalid Total search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dr6.Close();
            connn.Close();

            double costRolls = selctRolls * PriceRolls;
            double costBuns = selctBuns * PriceBuns;
            double costFishbuns = selctFishbuns * PriceFishbuns;
            double costEggbuns = selctEggbuns * PriceEggbuns;
            double costPastry = selctPastry * PricePastry;
            double costVade = selctVade * PriceVade;
            double costUlunduvade = selctUlunduvade * PriceUlunduvade;
            double costCupcake = selctCupcake * PriceCupcake;
            double costPatis = selctPatis * PricePatis;
            double costRotti = selctRotti * PriceRotti;

            textBox1.Text = (costRolls + costBuns + costFishbuns + costEggbuns + costPastry + costVade + costUlunduvade + costCupcake + costPatis + costRotti).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "0";
            comboBox2.Text = "0";
            comboBox3.Text = "0";
            comboBox4.Text = "0";
            comboBox5.Text = "0";
            comboBox6.Text = "0";
            comboBox7.Text = "0";
            comboBox8.Text = "0";
            comboBox9.Text = "0";
            comboBox10.Text = "0";
            textBox1.Clear();
        }
    }
}