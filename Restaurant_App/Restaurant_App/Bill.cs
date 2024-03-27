using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Restaurant_App
{
    public partial class Bill : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rahul\Documents\WebFood2.mdf;Integrated Security=True;Connect Timeout=30;");


        private int orderid, userid;

        public Bill(int oid, int uid)
        {
            InitializeComponent();

            orderid = oid;
            userid = uid;

            LoadBill();
        }

        private void LoadBill()
        {
            con.Open();
            string query = "SELECT orderId, userid, name, address, date, paymentMethod, totalAmount FROM [order] WHERE orderId =" + orderid + "AND userid = " + userid;
            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;



            query = "SELECT ItemName, qty, price FROM [orderItems] WHERE userid = " + userid;
            SqlCommand c = new SqlCommand(query, con);
            SqlDataAdapter adapter1 = new SqlDataAdapter(c);
            DataTable dataTable1 = new DataTable();
            adapter1.Fill(dataTable1);
            dataGridView2.DataSource = dataTable1;
            con.Close();
        }

        private void Print_pdf_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The pdf is downloaded in your imagination and food also will come in your imagination 👍😎 Scam 2024.");

            var nextform = new Menu(userid);
            this.Hide();
            nextform.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nextform = new Menu(userid);
            this.Hide();
            nextform.Show();
        }
    }
}
