using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Restaurant_App
{
    public partial class Cart : Form
    {
        private int userid;

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rahul\Documents\WebFood2.mdf;Integrated Security=True;Connect Timeout=30;");

        public Cart(int uid)
        {
            InitializeComponent();
            userid = uid;
            LoadCart();
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadCart()
        {
            
                con.Open();
                string query = "SELECT ItemName, qty, price FROM cart WHERE userid = @userid";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@userid", userid);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

                // Calculate total amount
                decimal totalAmount = 0;
                foreach (DataRow row in dataTable.Rows)
                {
                    totalAmount += Convert.ToDecimal(row["price"]) * Convert.ToInt32(row["qty"]);
                }

                // Display total amount
                label4.Text = "Total Amount: Rs. " + totalAmount.ToString();

                // Update progress bar
                progressBar.Minimum = 0;
                progressBar.Maximum = 100;
                if (totalAmount >= 2000)
                {
                    progressBar.Value = 100; // Set to maximum if eligible for discount
                }
                else
                {
                    progressBar.Value = (int)((totalAmount / 2000) * 100); // Calculate percentage progress
                    label1.Text = "Add more items worth 2000 for 10% discount / free delivery";
                }


            // Apply discount if total amount is eligible
            if (totalAmount >= 2000)
                {
                    decimal discount = totalAmount * 0.10m; // 10% discount
                    totalAmount -= discount;
                    label1.Text = "You are eligible for 10% off!";
                    label4.Text += " After 10% Discount: Rs. " + totalAmount.ToString("0.00");

                }

            con.Close(); // Close connection after use
            
            // Disable "Proceed Order" button if cart is empty
            proceedOrder.Enabled = dataTable.Rows.Count > 0;

        }

        private void button3_Click(object sender, EventArgs e)
        {// shop more button
            var nextform = new Menu(userid);
            this.Hide();
            nextform.ShowDialog();

        }

        private void removeSelectedItems_Click(object sender, EventArgs e)
        {
            var nextform = new RemoveSelecton(userid);
            this.Hide();
            nextform.ShowDialog();
        }

        private void removeAll_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM cart WHERE userid = @UserID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserID", userid);
                cmd.ExecuteNonQuery();
                MessageBox.Show("All items removed from cart successfully.");
                con.Close();
                LoadCart();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing all items: " + ex.Message);
            }
            
             
            
        }

        private void proceedOrder_Click(object sender, EventArgs e)
        {
            var nextform = new Order(userid);
            this.Hide();
            nextform.ShowDialog();
        }
    }
}


  