using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_App
{
    public partial class UpdatePassword : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rahul\Documents\WebFood2.mdf;Integrated Security=True;Connect Timeout=30;");
        public UpdatePassword()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void changepassword_Click(object sender, EventArgs e)
        {
            string email = Emailbox.Text;
            string newPassword = newpassword.Text;
            string confirmPassword = confirmpassword.Text;

            // Validate input
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirm password do not match.");
                return;
            }

            try
            {
                con.Open();

                // Check if the email exists in the database
                string checkEmailQuery = "SELECT COUNT(*) FROM [user] WHERE Email = '"+email+"'";
                SqlCommand checkEmailCmd = new SqlCommand(checkEmailQuery, con);
                
                int emailCount = (int)checkEmailCmd.ExecuteScalar();

                if (emailCount == 0)
                {
                    MessageBox.Show("Email does not exist.");
                    return;
                }

                // Update password in the database
                string updatePasswordQuery = "UPDATE [user] SET Password = '"+newPassword +"' WHERE Email = '"+email+"'";
                SqlCommand cmd = new SqlCommand(updatePasswordQuery, con);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Password updated successfully.");
                    con.Close();
                    var nextform = new Login();
                    this.Hide();
                    nextform.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Failed to update password. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var nextform = new Register();
            this.Hide();
            nextform.Show();
        }
    }
}
