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
    public partial class add_13th : Form
    {
        // Connection string for the MySQL database
        private string connectionString = "server=10.0.254.222;user=username;password=1234;database=cjis_db";

        public add_13th()
        {
            InitializeComponent();
            LoadYearRange();
            LoadEmployees();
        }

        // Populate the year ComboBox with values from 2020 to 2030
        private void LoadYearRange()
        {
            for (int year = 2020; year <= 2030; year++)
            {
                cb13_year.Items.Add(year.ToString());
            }
        }

        // Load employee names into the ComboBox
        private void LoadEmployees()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT employee_name FROM salary_grades";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        cb13_emp.Items.Add(reader["employee_name"].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading employees: " + ex.Message);
                }
            }
        }

        // Handle Save button click
        private void cb13_save_Click(object sender, EventArgs e)
        {
            if (cb13_emp.SelectedItem != null && cb13_year.SelectedItem != null)
            {
                string employeeName = cb13_emp.SelectedItem.ToString();
                int year = int.Parse(cb13_year.SelectedItem.ToString());
                decimal basicSalary = 0;

                // Step 1: Fetch basic salary from salary_grades table
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = @"
                            SELECT daily_salary
                            FROM salary_grades
                            WHERE employee_name = @EmployeeName";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@EmployeeName", employeeName);

                        object result = command.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            basicSalary = Convert.ToDecimal(result);
                        }
                        else
                        {
                            MessageBox.Show("No salary records found for the selected employee.");
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error fetching salary data: " + ex.Message);
                        return;
                    }
                }

                // Step 2: Calculate total basic salary for the year
                decimal totalBasicSalary = basicSalary * 12;

                // Step 3: Calculate 13th Month Pay
                decimal thirteenthMonthPay = totalBasicSalary / 12;

                // Step 4: Save the 13th Month Pay record to the database
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = @"
                            INSERT INTO thirteenth_month_pays (employee_name    , year, total_basic_salary, thirteenth_month_pay)
                            VALUES (@EmployeeName, @Year, @TotalBasicSalary, @ThirteenthMonthPay)";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@EmployeeName", employeeName);
                        command.Parameters.AddWithValue("@Year", year);
                        command.Parameters.AddWithValue("@TotalBasicSalary", totalBasicSalary);
                        command.Parameters.AddWithValue("@ThirteenthMonthPay", thirteenthMonthPay);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("13th Month Pay saved successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to save 13th Month Pay.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving 13th Month Pay: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select both an employee and a year.");
            }
        }

        // Handle Clear button click
        private void button3_Click(object sender, EventArgs e)
        {
            cb13_emp.SelectedIndex = -1;
            cb13_year.SelectedIndex = -1;
        }
    }
}