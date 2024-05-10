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
using System.Globalization;

namespace Central_Juan_Payroll_System
{
    public partial class add_EmDTR : Form
    {

        // Connection string for MySQL database
        private string connectionString = "server=localhost;user=root;password=1234;database=central_juan_db";

        public add_EmDTR()
        {
            InitializeComponent();

            // Configure DateTimePicker controls for time selection only
            dateTimePickerTimeInMorning.Format = DateTimePickerFormat.Custom;
            dateTimePickerTimeInMorning.CustomFormat = "h:mm tt";
            dateTimePickerTimeOutMorning.Format = DateTimePickerFormat.Custom;
            dateTimePickerTimeOutMorning.CustomFormat = "h:mm tt";
            dateTimePickerTimeInAfternoon.Format = DateTimePickerFormat.Custom;
            dateTimePickerTimeInAfternoon.CustomFormat = "h:mm tt";
            dateTimePickerTimeOutAfternoon.Format = DateTimePickerFormat.Custom;
            dateTimePickerTimeOutAfternoon.CustomFormat = "h:mm tt";

            // Populate ComboBox with employee names when the form loads
            PopulateEmployeeComboBox();
        }

        // Method to populate ComboBox with employee names
        private void PopulateEmployeeComboBox()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT CONCAT(first_name, ' ', last_name) AS FullName FROM Employees";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBoxEmployees.Items.Add(reader["FullName"].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private long GetEmployeeIdByName(string employeeName)
        {
            long employeeId = 0;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT employee_id FROM Employees WHERE CONCAT(first_name, ' ', last_name) = @EmployeeName";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EmployeeName", employeeName);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        employeeId = Convert.ToInt64(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return employeeId;
        }

        // Save Button Click Event
        private void btnDTRSave_Click(object sender, EventArgs e)
        {
            string employeeName = comboBoxEmployees.SelectedItem.ToString();
            DateTime dateDTR = dtpDTR.Value.Date;
            long employeeId = GetEmployeeIdByName(employeeName);
            string timeInMorning12Hour = dateTimePickerTimeInMorning.Value.ToString("h:mm tt"); // Use "h:mm tt" format for 12-hour time with AM/PM
            string timeOutMorning12Hour = dateTimePickerTimeOutMorning.Value.ToString("h:mm tt"); // Use "h:mm tt" format for 12-hour time with AM/PM
            string timeInAfternoon12Hour = dateTimePickerTimeInAfternoon.Value.ToString("h:mm tt"); // Use "h:mm tt" format for 12-hour time with AM/PM
            string timeOutAfternoon12Hour = dateTimePickerTimeOutAfternoon.Value.ToString("h:mm tt"); // Use "h:mm tt" format for 12-hour time with AM/PM

            // Convert 12-hour format to 24-hour format
            string timeInMorning24Hour = ConvertTo24HourFormat(timeInMorning12Hour);
            string timeOutMorning24Hour = ConvertTo24HourFormat(timeOutMorning12Hour);
            string timeInAfternoon24Hour = ConvertTo24HourFormat(timeInAfternoon12Hour);
            string timeOutAfternoon24Hour = ConvertTo24HourFormat(timeOutAfternoon12Hour);


            // Insert the data into the MySQL database
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO attendance (employee_id, employee_name, attendance_date, time_in_morning, time_out_morning, time_in_afternoon, time_out_afternoon) " +
                                   "VALUES (@EmployeeId, @EmployeeName, @AttendanceDate, @TimeInMorning, @TimeOutMorning, @TimeInAfternoon, @TimeOutAfternoon)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EmployeeId", employeeId);
                    command.Parameters.AddWithValue("@EmployeeName", employeeName);
                    command.Parameters.AddWithValue("@AttendanceDate", dateDTR);
                    command.Parameters.AddWithValue("@TimeInMorning", timeInMorning24Hour);
                    command.Parameters.AddWithValue("@TimeOutMorning", timeOutMorning24Hour);
                    command.Parameters.AddWithValue("@TimeInAfternoon", timeInAfternoon24Hour);
                    command.Parameters.AddWithValue("@TimeOutAfternoon", timeOutAfternoon24Hour);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("DTR saved successfully!");
                        // Optionally, clear the form controls after saving
                        // ClearFormControls();
                    }
                    else
                    {
                        MessageBox.Show("Failed to save DTR.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void btnBonusClear_Click(object sender, EventArgs e)
        {

        }

        private string ConvertTo24HourFormat(string time12Hour)
        {
            DateTime time = DateTime.ParseExact(time12Hour, "h:mm tt", CultureInfo.InvariantCulture);
            return time.ToString("HH:mm");
        }

    }
}
