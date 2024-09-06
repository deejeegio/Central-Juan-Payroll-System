using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Central_Juan_Payroll_System
{
    public partial class UC_EmployeeList : UserControl
    {
        // MySQL connection string
        private MySqlConnection mysql_conn;

        public UC_EmployeeList()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadEmployeeData();
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            // Set column headers
            dgvEmployeeList.Columns["employee_id"].HeaderText = "ID";
            dgvEmployeeList.Columns["first_name"].HeaderText = "First Name";
            dgvEmployeeList.Columns["middle_name"].HeaderText = "Middle Name";
            dgvEmployeeList.Columns["last_name"].HeaderText = "Last Name";
            dgvEmployeeList.Columns["email"].HeaderText = "Department ID";
            dgvEmployeeList.Columns["contact_number"].HeaderText = "Contact #";
            dgvEmployeeList.Columns["date_of_birth"].HeaderText = "DOB";
            dgvEmployeeList.Columns["department_id"].HeaderText = "Department ID";
            dgvEmployeeList.Columns["position_title"].HeaderText = "Position ID";
        }

        private void InitializeDatabase()
        {
            // MySQL connection string - replace with your actual database details
            string connectionString = "server=10.0.254.222;port=3306;user=username;password=1234;database=cjis_db";
            mysql_conn = new MySqlConnection(connectionString);
            mysql_conn.Open();

            string createTableSql = @"
                CREATE TABLE IF NOT EXISTS employees (
                    employee_id INT AUTO_INCREMENT PRIMARY KEY,
                    employee_code VARCHAR(100),
                    first_name VARCHAR(250),
                    middle_name VARCHAR(250),
                    last_name VARCHAR(250),
                    department_id INT,
                    position_id INT,
                    FOREIGN KEY (department_id) REFERENCES Departments(department_id),
                    FOREIGN KEY (position_id) REFERENCES Positions(position_id)
                );";

            MySqlCommand createTableCmd = new MySqlCommand(createTableSql, mysql_conn);
            createTableCmd.ExecuteNonQuery();
        }

        private void LoadEmployeeData()
        {
            string query = "SELECT * FROM employees";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, mysql_conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

           dgvEmployeeList.DataSource = dt;
        }

        public void RefreshEmployeeList()
        {
            LoadEmployeeData(); // Reload the employee data from the database
        }
    }
}
