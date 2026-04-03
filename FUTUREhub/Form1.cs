using Microsoft.Data.SqlClient;

namespace FUTUREhub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6P544O0\SQLEXPRESS;Initial Catalog=fleDB;Integrated Security=True;TrustServerCertificate=True");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();

            string username = textBox1.Text;
            string password = textBox2.Text;

            string query_select = "SELECT * FROM loginDetails WHERE username = '" + username + "' AND password = '" + password + "'";
            SqlCommand cmnd = new SqlCommand(query_select, con);
            SqlDataReader row = cmnd.ExecuteReader();

            if (row.HasRows)
            {
                this.Hide();
                Mainboard obj = new Mainboard();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login Credentials, Please check Username & Password and try again!", "Invalid Login Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
