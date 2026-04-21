using Microsoft.Data.SqlClient;

namespace FUTUREhub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6P544O0\SQLEXPRESS;Initial Catalog=fleDB;Integrated Security=True;Trust Server Certificate=True");

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

            string query_select = "SELECT * FROM employeeDetails WHERE username=@username AND password=@password";
            SqlCommand cmnd = new SqlCommand(query_select, con);
            cmnd.Parameters.AddWithValue("@username", username);
            cmnd.Parameters.AddWithValue("@password", password);

            SqlDataReader reader = cmnd.ExecuteReader();

            if (reader.Read())
            {
                string name = reader["name"] as string ?? string.Empty;
                string email = reader["email"] as string ?? string.Empty;
                string mobile = reader["mobile"] as string ?? string.Empty;
                string user = reader["username"] as string ?? string.Empty;
                string pwd = reader["password"] as string ?? string.Empty;

                this.Hide();
                Mainboard obj = new Mainboard(name, email, mobile, user, pwd);
                obj.Show();
            }

            else
            {
                MessageBox.Show("Invalid Login Credentials, Please check Username & Password and try again!", "Invalid Login Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }
    }
}
