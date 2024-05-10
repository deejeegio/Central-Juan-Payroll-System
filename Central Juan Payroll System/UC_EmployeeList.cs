using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace Central_Juan_Payroll_System
{
    public partial class UC_EmployeeList : UserControl
    {

        private SQLiteConnection sqlite_conn;

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
            dgvEmployeeList.Columns["id"].HeaderText = "ID";
            dgvEmployeeList.Columns["employee_code"].HeaderText = "Employee Code";
            dgvEmployeeList.Columns["firstname"].HeaderText = "First Name";
            dgvEmployeeList.Columns["middlename"].HeaderText = "Middle Name";
            dgvEmployeeList.Columns["lastname"].HeaderText = "Last Name";
            dgvEmployeeList.Columns["department_id"].HeaderText = "Department ID";
            dgvEmployeeList.Columns["position_id"].HeaderText = "Position ID";
            dgvEmployeeList.Columns["salary"].HeaderText = "Salary";
        }

        private void InitializeDatabase()
        {
            sqlite_conn = new SQLiteConnection("Data Source=C:\\sqlite\\cj.db");
            sqlite_conn.Open();

            string createTableSql = @"
                CREATE TABLE IF NOT EXISTS Employee (
                    id INTEGER PRIMARY KEY,
                    employee_code VARCHAR(100),
                    firstname VARCHAR(250),
                    middlename VARCHAR(250),
                    lastname VARCHAR(250),
                    department_id INTEGER,
                    position_id INTEGER,
                    salary DOUBLE
                );";

            SQLiteCommand createTableCmd = new SQLiteCommand(createTableSql, sqlite_conn);
            createTableCmd.ExecuteNonQuery();
        }

        private void LoadEmployeeData()
        {
            string query = "SELECT * FROM Employee";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, sqlite_conn);
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
