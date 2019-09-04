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
    public partial class Form_PasswordChange : Form
    {
        public Form_PasswordChange()
        {
            InitializeComponent();
        }

        SqlConnection con3 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\My Documents\ESOFT\Educational\Projects\Our Project\Software\PROJECT-Final\Stoke Valuation And Sales Analysis System\WindowsFormsApplication11\Database1.mdf;Integrated Security=True;User Instance=True");
        private void button1_Click(object sender, EventArgs e)
        {

            SqlDataAdapter ASDF = new SqlDataAdapter("SELECT COUNT(*) FROM Table_Login WHERE UserName='" + textBox1.Text + "' AND Passward='" + textBox2.Text + "'", con3);
            DataTable dt = new DataTable();
            ASDF.Fill(dt);

            errorProvider1.Clear();

            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Please Enter User Name");
                MessageBox.Show("Please Enter User Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            else if (textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, "Please Enter Password");
                MessageBox.Show("Please Enter Old Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }

            else if (dt.Rows[0][0].ToString() == "1")
            {
                if (textBox3.Text == "")
                {
                    errorProvider1.SetError(textBox3, "Please Enter New Password");
                    MessageBox.Show("Please Enter New Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox3.Focus();
                    return;
                }

                else if (textBox4.Text == "")
                {
                    errorProvider1.SetError(textBox4, "Please Enter New Password");
                    MessageBox.Show("Please Enter New Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox4.Focus();
                    return;
                }

                else if (textBox3.Text == textBox4.Text)
                {
                    SqlDataAdapter cc = new SqlDataAdapter("UPDATE Table_Login SET passward='" + textBox3.Text + "' WHERE username= '" + textBox1.Text + "' AND passward='" + textBox2.Text + "' ", con3);
                    DataTable ds = new DataTable();
                    cc.Fill(ds);
                    MessageBox.Show("Password changed", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    errorProvider1.SetError(textBox3, "Unmatched Password");
                    errorProvider1.SetError(textBox4, "Unmatched Password");
                    MessageBox.Show("Unmatched Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox3.Focus();
                    textBox4.Focus();
                    return;
                }
            }
            else
            {
                errorProvider1.SetError(textBox1, "Incorrect User Name");
                errorProvider1.SetError(textBox2, "Incorrect Password");
                MessageBox.Show("Incorrect User Name Or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            errorProvider1.Clear();
        }
    }
}
