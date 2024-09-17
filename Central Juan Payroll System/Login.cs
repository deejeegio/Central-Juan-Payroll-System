using System;
using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Text;
using MySql.Data.MySqlClient; // Use MySQL (or change to SQLite, SQL Server, etc.)

namespace Central_Juan_Payroll_System
{


    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }



        // Method to check the login
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (AuthenticateUser(username, password))
            {
                // If login is successful, open the dashboard
                Dashboard das = new Central_Juan_Payroll_System.Dashboard();
                das.ShowDialog();
                this.Close(); // Close the login form
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to authenticate user
        private bool AuthenticateUser(string username, string password)
        {
            string connectionString = "server=10.0.254.222;user=username;password=1234;database=cjis_db"; // Update your database connection string here
            bool isAuthenticated = false;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM users WHERE username = @username AND password = @password";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password); // Not secure! Use hashing for production.

                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows) // If the user exists
                        {
                            isAuthenticated = true;
                        }

                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error connecting to the database: {ex.Message}");
                }
            }

            return isAuthenticated;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Any initialization code here
        }
    }
}
