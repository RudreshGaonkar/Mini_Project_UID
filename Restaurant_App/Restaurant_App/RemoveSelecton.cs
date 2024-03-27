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

namespace Restaurant_App
{
    public partial class RemoveSelecton : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rahul\Documents\WebFood2.mdf;Integrated Security=True;Connect Timeout=30;");


        private int userid;

        public RemoveSelecton(int uid)
        {
            InitializeComponent();
            userid = uid;

            Loadlist();
        }


        public void Loadlist()
        {
            con.Open();
            string query = "SELECT ItemName, qty, price FROM cart WHERE userid = "+userid;
            SqlCommand cmd = new SqlCommand(query, con);           
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string itemNameToRemove = textBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(itemNameToRemove))
            {
                MessageBox.Show("Please enter an item name to remove.");
                return;
            }


            // Check if the entered item name exists in the cart for the current user
            bool itemExists = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string itemName = row.Cells["ItemName"].Value.ToString();
                if (itemName.Equals(itemNameToRemove, StringComparison.OrdinalIgnoreCase))
                {
                    itemExists = true;
                    break;
                }
            }

            if (!itemExists) // ! stands for "NOT".
            {
                MessageBox.Show($"Item '{itemNameToRemove}' does not exist in the cart.");
                return;
            }



            try
            {
                con.Open();
                string query = "DELETE FROM cart WHERE userid = "+userid+" AND ItemName = '"+itemNameToRemove+"'";
                SqlCommand cmd = new SqlCommand(query, con);
                
                cmd.ExecuteNonQueryAsync();
                MessageBox.Show($"Item '{itemNameToRemove}' removed from cart successfully.");
                con.Close();
                Loadlist();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing item: " + ex.Message);
            }
            
                
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newform = new Cart(userid);
            this.Hide();
            newform.ShowDialog();
        }
    }
}
