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
    public partial class Menu : Form
    {
        private int userId;

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rahul\Documents\WebFood2.mdf;Integrated Security=True;Connect Timeout=30;");
        public Menu(int uid)
        {
            InitializeComponent();

            userId = uid;
        }

        public Menu()
        {
            InitializeComponent();

        }


        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void cakebtn_Click(object sender, EventArgs e)
        {
            string itemName = cakeName.Text;
            int quantity = Convert.ToInt32(cakeqty.Text); // Get the selected quantity
            int price = Convert.ToInt32(cakeprice.Text);

            AddOrUpdateCartItem(itemName, quantity, price);
        }

        private void icebtn_Click(object sender, EventArgs e)
        {
            string itemName = icename.Text;
            int quantity = Convert.ToInt32(iceqty.SelectedItem); // Get the selected quantity
            int price = Convert.ToInt32(iceprice.Text);

            AddOrUpdateCartItem(itemName, quantity, price);
        }

        private void puddingbtn_Click(object sender, EventArgs e)
        {
            string itemName = puddingname.Text;
            int quantity = Convert.ToInt32(puddingqty.SelectedItem); // Get the selected quantity
            int price = Convert.ToInt32(puddingprice.Text);

            AddOrUpdateCartItem(itemName, quantity, price);
        }

        private void friedbtn_Click(object sender, EventArgs e)
        {
            string itemName = friedname.Text;
            int quantity = Convert.ToInt32(friedqty.SelectedItem); // Get the selected quantity
            int price = Convert.ToInt32(friedprice.Text);

            AddOrUpdateCartItem(itemName, quantity, price);
        }

        private void biryanibtn_Click(object sender, EventArgs e)
        {
            string itemName = biryaniname.Text;
            int quantity = Convert.ToInt32(biryaniqty.SelectedItem); // Get the selected quantity
            int price = Convert.ToInt32(biryaniprice.Text);

            AddOrUpdateCartItem(itemName, quantity, price);
        }

        private void button8_Click(object sender, EventArgs e) // pasta
        {
            string itemName = pastaname.Text;
            int quantity = Convert.ToInt32(pastaqty.SelectedItem); // Get the selected quantity
            int price = Convert.ToInt32(pastaprice.Text);

            AddOrUpdateCartItem(itemName, quantity, price);
        }

        private void button3_Click(object sender, EventArgs e) // sandwish button
        {
            string itemName = sandwishname.Text;
            int quantity = Convert.ToInt32(sandwishqty.SelectedItem); // Get the selected quantity
            int price = Convert.ToInt32(sandwishprice.Text);

            AddOrUpdateCartItem(itemName, quantity, price);
        }

        private void button6_Click(object sender, EventArgs e) // pizza button
        {
            string itemName = pizzaname.Text;
            int quantity = Convert.ToInt32(pizzaqty.SelectedItem); // Get the selected quantity
            int price = Convert.ToInt32(pizzaprice.Text);

            AddOrUpdateCartItem(itemName, quantity, price);
        }

        private void bugerbtn_Click(object sender, EventArgs e)
        {
            string itemName = burgername.Text;
            int quantity = Convert.ToInt32(burgerqty.SelectedItem); // Get the selected quantity
            int price = Convert.ToInt32(burgerprice.Text);

            AddOrUpdateCartItem(itemName, quantity, price);
        }

        private void button1_Click(object sender, EventArgs e)// cart
        {
            //cart

            var newform = new Cart(userId);
            this.Hide();
            newform.ShowDialog();
        }


        private void AddOrUpdateCartItem(string itemName, int quantity, int price)
        {
            try
            {
                con.Open();



                // Check if the item already exists for the user
                string selectQuery = "SELECT COUNT(*) FROM cart WHERE ItemName = '"+itemName+"' AND userid = "+userId;
                SqlCommand selectCmd = new SqlCommand(selectQuery, con);
                selectCmd.Parameters.AddWithValue("@ItemName", itemName);
                selectCmd.Parameters.AddWithValue("@UserID", userId);
                int existingItemCount = (int)selectCmd.ExecuteScalar();

                if (existingItemCount > 0)
                {
                    // Item exists, update the quantity
                    string updateQuery = "UPDATE cart SET qty = qty + " + quantity + " WHERE ItemName = '" + itemName + "' AND userid = " + userId;
                    SqlCommand updateCmd = new SqlCommand(updateQuery, con);
                    updateCmd.ExecuteNonQuery();
                    MessageBox.Show("Item quantity updated in cart successfully.");
                }
                else
                {
                    // Item does not exist, insert new item
                    string insertQuery = "INSERT INTO cart (ItemName, qty, price, userid) VALUES  ('" + itemName + "', '" + quantity + "'," + price + "," + userId + ")";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, con);
                    insertCmd.ExecuteNonQuery();
                    MessageBox.Show("Item added to cart successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding/updating item in cart: " + ex.Message);
            }


            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var nextform = new Login();
            this.Hide();
            nextform.ShowDialog();
        }
    }
}
