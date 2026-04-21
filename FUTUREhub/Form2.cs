using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FUTUREhub
{
    public partial class Form2 : Form
    {
        private string in_username;
        private string in_password;

        public Form2(string username, string password)
        {
            InitializeComponent();
            this.in_username = username;
            this.in_password = password;
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6P544O0\SQLEXPRESS;Initial Catalog=fleDB;Integrated Security=True;Trust Server Certificate=True");

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            string query_insert = "UPDATE employeeDetails SET username = '" + username + "', password = '" + password + "' WHERE username = '" + in_username + "' AND password = '" + in_password + "'";
            con.Open();
            SqlCommand cmnd = new SqlCommand(query_insert, con);
            cmnd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record updated successfully!", "Updated Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            var parent = this.MdiParent ?? Application.OpenForms.OfType<Mainboard>().FirstOrDefault();
            parent?.Show();
        }

        
    }
}
