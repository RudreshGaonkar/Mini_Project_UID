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
    public partial class Order : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rahul\Documents\WebFood2.mdf;Integrated Security=True;Connect Timeout=30;");


        private int userid, orderid;

        public int amount = 0;
        public Order(int uid)
        {
            InitializeComponent();

            userid = uid;

            loadlist();
        }


        void loadlist()
        {
            con.Open();
            string query = "SELECT ItemName, qty, price FROM cart WHERE userid = " + userid;
            SqlCommand cmd = new SqlCommand(query, con);
            //cmd.Parameters.AddWithValue("@userid", userid);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            // Calculate total amount
            decimal totalamount = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                totalamount += Convert.ToDecimal(row["price"]) * Convert.ToInt32(row["qty"]);
            }

            label3.Text += totalamount.ToString();

            amount = Convert.ToInt32(totalamount);

            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Confirm_Order_Click(object sender, EventArgs e)
        {


            con.Open();

            // Fetch user's name
            string selectUserQuery = "SELECT Name FROM [user] WHERE UserID = " + userid;
            SqlCommand selectUserCmd = new SqlCommand(selectUserQuery, con);
            string username = selectUserCmd.ExecuteScalar()?.ToString();

            // Generate order ID
            Random random = new Random();
            orderid = random.Next(10000, 99999) * 999 - 999;

            //Date generate
            // Get the current date and time
            //DateTime date = DateTime.Now;

            





            string payment = "";

            if (radioButton1.Checked)
            {
                payment = radioButton1.Text;
            }


            // Insert order into order table
            string insertOrderQuery = "INSERT INTO [order] (orderId, userid, name, address, date, paymentMethod, totalAmount) VALUES (" + orderid + ", " + userid + ", '" + username + "', '" + textBox1.Text + "', @date,'" + payment + "',"+amount+")";
            SqlCommand insertOrderCmd = new SqlCommand(insertOrderQuery, con);
            insertOrderCmd.Parameters.AddWithValue("@date", DateTime.Now);
            insertOrderCmd.ExecuteNonQuery();



            string query = "SELECT ItemName, qty, price FROM cart WHERE userid = " + userid;
            SqlCommand cmd = new SqlCommand(query, con);
            //cmd.Parameters.AddWithValue("@userid", userid);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Insert items into orderItems table
            foreach (DataRow row in dataTable.Rows)
            {
                string itemName = row["ItemName"].ToString();
                int qty = Convert.ToInt32(row["qty"]);
                int price = Convert.ToInt32(row["price"]);

                string insertOrderItemQuery = "INSERT INTO [orderItems] (userid, itemname, qty, price) VALUES (" + userid + ", '" + itemName + "', '" + qty + "' ," + price + ")";
                SqlCommand insertOrderItemCmd = new SqlCommand(insertOrderItemQuery, con);

                insertOrderItemCmd.ExecuteNonQuery();
            }

            // Remove items from the cart table
            string deleteCartItemsQuery = "DELETE FROM cart WHERE userid = "+userid;
            SqlCommand deleteCartItemsCmd = new SqlCommand(deleteCartItemsQuery, con);



            var nextform = new Bill(orderid, userid);
            this.Hide();
            nextform.Show();

            MessageBox.Show("Order confirmed. Order ID: " + orderid);

            
            deleteCartItemsCmd.ExecuteNonQuery();

            con.Close();

            /*catch (Exception ex)
            {
                MessageBox.Show("Error confirming order: " + ex.Message);
            }
            finally
            {
                con.Close();
            }*/



        }

        private void Back_to_cart_Click(object sender, EventArgs e)
        {
            var nextform = new Cart(userid);
            this.Hide();
            nextform.Show();
        }

        private void button1_Click(object sender, EventArgs e) //  only for admin which sometimes exists
        {
            try
            {
                con.Open();
                string deleteOrderItemsQuery = "DELETE FROM orderItems WHERE userid = @userid";
                SqlCommand deleteOrderItemsCmd = new SqlCommand(deleteOrderItemsQuery, con);
                deleteOrderItemsCmd.Parameters.AddWithValue("@userid", userid);
                deleteOrderItemsCmd.ExecuteNonQuery();
                MessageBox.Show("Items deleted successfully from the order.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting items from the order: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}


