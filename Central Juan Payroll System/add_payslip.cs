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
    public partial class add_payslip : Form
    {

        // Connection string for MySQL database
        private string connectionString = "server=10.0.254.222;user=username;password=1234;database=cjis_db";

        public add_payslip()
        {
            InitializeComponent();
            LoadEmployees();
        }

        // Load employee names into the ComboBox from the database
        private void LoadEmployees()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT employee_id, employee_name FROM salary_grades";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        comboEmployee.Items.Add(new ComboBoxItem(reader["employee_name"].ToString(), reader["employee_id"].ToString()));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading employees: " + ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnPaySave_Click(object sender, EventArgs e)
        {
            // Fetch the selected employee
            if (comboEmployee.SelectedItem is ComboBoxItem selectedEmployee)
            {
                string employeeId = selectedEmployee.Value; // Now employeeId is a string
                string employeeName = selectedEmployee.Text;
                DateTime startDate = dtpFromPayslip.Value.Date;
                DateTime endDate = dtpUntilPayslip.Value.Date;

                decimal dailySalary = 0;

                // Step 1: Retrieve the employee's daily salary
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT daily_salary FROM salary_grades WHERE employee_id = @EmployeeId";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@EmployeeId", employeeId);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                dailySalary = reader.GetDecimal("daily_salary");
                            }
                            else
                            {
                                MessageBox.Show("Employee not found!");
                                return;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error fetching employee data: " + ex.Message);
                        return;
                    }
                }

                // Step 2: Calculate the total days credited for the payslip period
                decimal totalDaysCredited = 0;

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = @"
                            SELECT SUM(days_credited) 
                            FROM attendance 
                            WHERE employee_id = @EmployeeId 
                            AND attendance_date BETWEEN @StartDate AND @EndDate";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@EmployeeId", employeeId);
                        command.Parameters.AddWithValue("@StartDate", startDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);

                        totalDaysCredited = Convert.ToDecimal(command.ExecuteScalar());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error calculating attendance: " + ex.Message);
                        return;
                    }
                }

                // Step 3: Calculate total salary
                decimal totalSalary = totalDaysCredited * dailySalary;

                // Step 4: Insert the generated payslip into the payslips table
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = @"
                            INSERT INTO payslips (employee_id, employee_name, date_from, date_until, total_days, total_salary)
                            VALUES (@EmployeeId, @EmployeeName, @DateFrom, @DateUntil, @TotalDays, @TotalSalary)";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@EmployeeId", employeeId);
                        command.Parameters.AddWithValue("@EmployeeName", employeeName);
                        command.Parameters.AddWithValue("@DateFrom", startDate);
                        command.Parameters.AddWithValue("@DateUntil", endDate);
                        command.Parameters.AddWithValue("@TotalDays", totalDaysCredited);
                        command.Parameters.AddWithValue("@TotalSalary", totalSalary);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Payslip generated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to generate payslip.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving payslip: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an employee.");
            }
        }

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public ComboBoxItem(string text, string value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text; // This is what is displayed in the ComboBox
            }
        }


    }
}

    

