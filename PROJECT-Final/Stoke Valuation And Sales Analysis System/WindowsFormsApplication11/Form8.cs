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
    public partial class Form8 : Form
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
        public Form8()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
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

                this.chart1.Series["Income"].Points.AddXY("Rolls", (salesRolls * PriceRolls));
                this.chart1.Series["Income"].Points.AddXY("Buns", (salesBuns * PriceBuns));
                this.chart1.Series["Income"].Points.AddXY("FishBuns", (salesFishbuns * PriceFishbuns));
                this.chart1.Series["Income"].Points.AddXY("EggBuns", (salesEggbuns * PriceEggbuns));
                this.chart1.Series["Income"].Points.AddXY("Pastry", (salesPastry * PricePastry));
                this.chart1.Series["Income"].Points.AddXY("Vade", (salesVade * PriceVade));
                this.chart1.Series["Income"].Points.AddXY("UlunduVade", (salesUlunduvade * PriceUlunduvade));
                this.chart1.Series["Income"].Points.AddXY("CupCake", (salesCupcake * PriceCupcake));
                this.chart1.Series["Income"].Points.AddXY("Patis", (salesPatis * PricePatis));
                this.chart1.Series["Income"].Points.AddXY("Rotti", (salesRotti * PriceRotti));
            }
            else
            {
                MessageBox.Show("Invalid Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dr2.Close();
            connn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_SalesIncome frmS = new Form_SalesIncome();
            frmS.Show();
            this.Hide();
        }
    }
}
