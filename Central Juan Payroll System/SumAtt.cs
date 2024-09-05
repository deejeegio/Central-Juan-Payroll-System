using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Central_Juan_Payroll_System
{
    public partial class SumAtt : Form
    {

        private SQLiteConnection sqlite_conn;
        public SumAtt()
        {
            InitializeComponent();
            LoadEmployeeData();
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            // Set column headers
            dgvAttSumm.Columns["employee_id"].HeaderText = "ID";
            dgvAttSumm.Columns["firstname"].HeaderText = "First Name";
            dgvAttSumm.Columns["lastname"].HeaderText = "Last Name";
            dgvAttSumm.Columns["total_days_present"].HeaderText = "Total Hours Present";
            dgvAttSumm.Columns["late_absent_days"].HeaderText = "Total Late/Absent";
        }

        private void LoadEmployeeData()
        {
            sqlite_conn = new SQLiteConnection("Data Source=C:\\sqlite\\cj.db");
            sqlite_conn.Open();

            string query = "SELECT EmployeeDTR.employee_id, Employee.firstname, Employee.lastname, EmployeeDTR.total_days_present, EmployeeDTR.late_absent_days FROM EmployeeDTR INNER JOIN Employee ON EmployeeDTR.employee_id = Employee.id";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, sqlite_conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgvAttSumm.DataSource = dt;


            sqlite_conn.Close();
        }

        

    }
}
