using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Restaurant_App
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rahul\Documents\WebFood2.mdf;Integrated Security=True;Connect Timeout=30;");
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var nextform = new UpdatePassword();
            this.Hide();
            nextform.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e) // login in button fun()
        {
            con.Open();
            errorLabel.Text = "";

            // Check if both email and password are provided
            if (string.IsNullOrWhiteSpace(loginEmail.Text) || string.IsNullOrWhiteSpace(loginPassword.Text))
            {
                MessageBox.Show("Please enter both email and password.");
                //con.Close();
                return;
            }
            // if the guy dirctly press login without typing anything. 
            if(string.IsNullOrWhiteSpace(loginEmail.Text) && string.IsNullOrWhiteSpace(loginPassword.Text))
            {
                MessageBox.Show("Please enter both email and password.");
                //con.Close();
                return;
            }

            // Check if the user exists in the database
            SqlCommand checkUserCmd = new SqlCommand("SELECT UserID, Password FROM [user] WHERE Email = '"+ loginEmail.Text + "'", con);
           
            SqlDataReader reader = checkUserCmd.ExecuteReader();
            if (reader.Read())
            {
                // User exists, check password
                string storedPassword = reader["Password"].ToString().Trim();
                int userID = Convert.ToInt32(reader["UserID"]);
                //MessageBox.Show("Stored Password: " + storedPassword); // Show stored password

                // Check if the entered password matches the stored password
                //MessageBox.Show("Entered Password: " + loginPassword.Text.ToString());
                string enteredPassword = loginPassword.Text.Trim();
                if (storedPassword.Equals(enteredPassword))
                {
                    // Passwords match, login successful
                    MessageBox.Show("Login successful.");

                    

                    // Proceed to the next form or activity
                    var nextForm = new Menu(userID);
                    this.Hide();
                    reader.Close();
                    con.Close();
                    nextForm.ShowDialog();

                }
                else
                {
                    // Passwords do not match
                    //MessageBox.Show("Incorrect password.");
                    errorLabel.Text = "*Invalid";
                }
            }
            else
            {
                // User does not exist
                MessageBox.Show("User with this email does not exist or incorrect email.Check email or create a new account");
            }

            reader.Close();
            con.Close();
        }

        private void back_to_sign_in_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var nextform = new Register();
            this.Hide();
            nextform.ShowDialog();
        }
    }
}


