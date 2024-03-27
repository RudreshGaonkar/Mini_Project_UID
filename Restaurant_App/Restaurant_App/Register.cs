using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Restaurant_App
{
    public partial class Register : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rahul\Documents\WebFood2.mdf;Integrated Security=True;Connect Timeout=30;");
        public Register()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var nextform = new Login();
            this.Hide();
            nextform.ShowDialog();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randnum = random.Next(1000, 10000) * 999 - 999;

            con.Open();
            if (registerNameBox.Text != "" && registerEmailBox.Text != "" && registerPasswordBox.Text != "")
            {
                // Validate email format
                if (!IsValidEmail(registerEmailBox.Text))
                {
                    MessageBox.Show("Please enter a valid email address.");
                    return;
                }

                // Check if email already exists
                SqlCommand checkEmailCmd = new SqlCommand("SELECT COUNT(*) FROM [user] WHERE Email = '"+ registerEmailBox.Text + "'", con);
                //checkEmailCmd.Parameters.AddWithValue("@Email", registerEmailBox.Text);
                int emailCount = (int)checkEmailCmd.ExecuteScalar();

                if (emailCount > 0)
                {
                    MessageBox.Show("This email is already registered. Please use a different email.");
                }
                else
                {
                    // Insert new user
                    string query = "INSERT INTO [user] (UserID, Name, Email, Password) VALUES ("+ randnum+",'"+ registerNameBox.Text+"', '"+registerEmailBox.Text+"','"+registerPasswordBox.Text+"')";
                    SqlCommand com = new SqlCommand(query, con);
                    /*com.Parameters.AddWithValue("@UserID", randnum);
                    com.Parameters.AddWithValue("@Name", registerNameBox.Text);
                    com.Parameters.AddWithValue("@Email", registerEmailBox.Text);
                    com.Parameters.AddWithValue("@Password", registerPasswordBox.Text);*/
                    com.ExecuteNonQuery();
                    MessageBox.Show("Data is added successfully");

                    con.Close();

                    var nextform = new Login();
                    this.Hide();
                    nextform.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
                con.Close();
            }





            //clearing textbox data
            registerNameBox.Text = " ";
            registerEmailBox.Text = " ";
            registerPasswordBox.Text = " ";
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
