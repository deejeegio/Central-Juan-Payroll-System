using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Central_Juan_Payroll_System
{
    public partial class SumAtt : Form
    {
        private MySqlConnection mysql_conn;

        public SumAtt()
        {
            InitializeComponent();
            dtpAttendance.ValueChanged += dtpAttendance_ValueChanged; // Event handler for date changes
            LoadEmployeeData(); // Load attendance data when the form opens
        }

        // Method to load attendance data based on the selected date
        private void LoadEmployeeData()
        {
            string selectedDate = dtpAttendance.Value.ToString("yyyy-MM-dd"); // Get the selected date from DateTimePicker

            mysql_conn = new MySqlConnection("server=10.0.254.222;user=username;password=1234;database=cjis_db");
            mysql_conn.Open();

            // Query to get attendance data based on the selected date
            string query = @"SELECT attendance.employee_id, employees.first_name, employees.last_name, 
                             attendance.deducted_days, attendance.days_credited
                             FROM attendance
                             INNER JOIN employees ON attendance.employee_id = employees.employee_id
                             WHERE attendance.attendance_date = @SelectedDate";

            MySqlCommand command = new MySqlCommand(query, mysql_conn);
            command.Parameters.AddWithValue("@SelectedDate", selectedDate);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            // Bind the data to the DataGridView
            dgvAttSumm.DataSource = dt;

            // Set the column headers after data is loaded
            if (dgvAttSumm.Columns.Count > 0)
            {
                dgvAttSumm.Columns["employee_id"].HeaderText = "ID";
                dgvAttSumm.Columns["first_name"].HeaderText = "First Name";
                dgvAttSumm.Columns["last_name"].HeaderText = "Last Name";
                dgvAttSumm.Columns["deducted_days"].HeaderText = "Deduction";
                dgvAttSumm.Columns["days_credited"].HeaderText = "Credit";
            }

            mysql_conn.Close();
        }

        // Event handler to reload data when the selected date changes
        private void dtpAttendance_ValueChanged(object sender, EventArgs e)
        {
            LoadEmployeeData();
        }

        private void btnAttClear_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
