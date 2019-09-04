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
    public partial class Form10 : Form
    {
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

        SqlConnection connn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\My Documents\ESOFT\Educational\Projects\Our Project\Software\PROJECT-Final\Stoke Valuation And Sales Analysis System\WindowsFormsApplication11\Database1.mdf;Integrated Security=True;User Instance=True");

        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Stock frm6 = new Form_Stock();
            frm6.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
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

            SqlDataReader dr2 = null;
            SqlCommand com3 = new SqlCommand("SELECT*FROM Table_Sales WHERE Date='" + theDate + "'", connn);
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
                
                this.chart1.Series["Sales"].Points.AddXY("Rolls", salesRolls);
                this.chart1.Series["Stock"].Points.AddXY("Rolls", stockRolls);

                this.chart1.Series["Sales"].Points.AddXY("Buns", salesBuns);
                this.chart1.Series["Stock"].Points.AddXY("Buns", stockBuns);

                this.chart1.Series["Sales"].Points.AddXY("FishBuns", salesFishbuns);
                this.chart1.Series["Stock"].Points.AddXY("FishBuns", stockFishbuns);

                this.chart1.Series["Sales"].Points.AddXY("EggBuns", salesEggbuns);
                this.chart1.Series["Stock"].Points.AddXY("EggBuns", stockEggbuns);

                this.chart1.Series["Sales"].Points.AddXY("Pastry", salesPastry);
                this.chart1.Series["Stock"].Points.AddXY("Pastry", stockPastry);

                this.chart1.Series["Sales"].Points.AddXY("Vade", salesVade);
                this.chart1.Series["Stock"].Points.AddXY("Vade", stockVade);

                this.chart1.Series["Sales"].Points.AddXY("UlunduVade", salesUlunduvade);
                this.chart1.Series["Stock"].Points.AddXY("UlunduVade", stockUlunduvade);

                this.chart1.Series["Sales"].Points.AddXY("CupCake", salesCupcake);
                this.chart1.Series["Stock"].Points.AddXY("CupCake", stockCupcake);

                this.chart1.Series["Sales"].Points.AddXY("Patis", salesPatis);
                this.chart1.Series["Stock"].Points.AddXY("Patis", stockPatis);

                this.chart1.Series["Sales"].Points.AddXY("Rotti", salesRotti);
                this.chart1.Series["Stock"].Points.AddXY("Rotti", stockRotti);
            }
            else
            {
                MessageBox.Show("Invalid Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dr2.Close();
            connn.Close();
        }
    }
}
