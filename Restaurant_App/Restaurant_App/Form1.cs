namespace Restaurant_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nextform = new Register();
            this.Hide();
            nextform.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var nextform = new Login();
            this.Hide();
            nextform.ShowDialog();
        }
    }
}
