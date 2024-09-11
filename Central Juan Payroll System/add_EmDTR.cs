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
        private string connectionString = "server=10.0.254.222;user=username;password=1234;database=cjis_db";

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

        private string GetEmployeeIdByName(string employeeName)
        {
            string employeeId = "";
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
                        employeeId = result.ToString();
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
            string employeeId = GetEmployeeIdByName(employeeName);

            // Get morning and afternoon time in/out values
            string timeInMorning12Hour = dateTimePickerTimeInMorning.Value.ToString("h:mm tt");
            string timeOutMorning12Hour = dateTimePickerTimeOutMorning.Value.ToString("h:mm tt");
            string timeInAfternoon12Hour = dateTimePickerTimeInAfternoon.Value.ToString("h:mm tt");
            string timeOutAfternoon12Hour = dateTimePickerTimeOutAfternoon.Value.ToString("h:mm tt");

            // Convert to 24-hour format
            string timeInMorning24Hour = ConvertTo24HourFormat(timeInMorning12Hour);
            string timeOutMorning24Hour = ConvertTo24HourFormat(timeOutMorning12Hour);
            string timeInAfternoon24Hour = ConvertTo24HourFormat(timeInAfternoon12Hour);
            string timeOutAfternoon24Hour = ConvertTo24HourFormat(timeOutAfternoon12Hour);

            // Deduction logic for both shifts
            double morningDeduction = CalculateDeductionForShift(timeInMorning24Hour, "morning");
            double afternoonDeduction = CalculateDeductionForShift(timeInAfternoon24Hour, "afternoon");

            double totalDeduction = morningDeduction + afternoonDeduction; // Total deduction for the day
            double daysCredited = 1 - totalDeduction; // Credited days

            // Insert into MySQL database
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO attendance (employee_id, employee_name, attendance_date, time_in_morning, time_out_morning, time_in_afternoon, time_out_afternoon, deducted_days, days_credited) " +
                                   "VALUES (@EmployeeId, @EmployeeName, @AttendanceDate, @TimeInMorning, @TimeOutMorning, @TimeInAfternoon, @TimeOutAfternoon, @DeductedDays, @DaysCredited)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EmployeeId", employeeId);
                    command.Parameters.AddWithValue("@EmployeeName", employeeName);
                    command.Parameters.AddWithValue("@AttendanceDate", dateDTR);
                    command.Parameters.AddWithValue("@TimeInMorning", timeInMorning24Hour);
                    command.Parameters.AddWithValue("@TimeOutMorning", timeOutMorning24Hour);
                    command.Parameters.AddWithValue("@TimeInAfternoon", timeInAfternoon24Hour);
                    command.Parameters.AddWithValue("@TimeOutAfternoon", timeOutAfternoon24Hour);
                    command.Parameters.AddWithValue("@DeductedDays", totalDeduction);
                    command.Parameters.AddWithValue("@DaysCredited", daysCredited);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("DTR saved successfully with deduction and credited days!");
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

        // Deduction calculation for morning and afternoon shifts
        private double CalculateDeductionForShift(string timeIn, string shift)
        {
            TimeSpan startMorning = TimeSpan.Parse("09:00");
            TimeSpan startAfternoon = TimeSpan.Parse("13:00");

            TimeSpan actualTimeIn = TimeSpan.Parse(timeIn);
            int minutesLate = 0;

            if (shift == "morning")
            {
                if (actualTimeIn > startMorning)
                {
                    minutesLate = (int)(actualTimeIn - startMorning).TotalMinutes;
                }
            }
            else if (shift == "afternoon")
            {
                if (actualTimeIn > startAfternoon)
                {
                    minutesLate = (int)(actualTimeIn - startAfternoon).TotalMinutes;
                }
            }

            // Deduction for the shift based on minutes late
            double deduction = CalculateLateDeduction(minutesLate, shift);

            return deduction;
        }

        // Calculate deduction based on lateness
        private double CalculateLateDeduction(int minutesLate, string shift)
        {
            double deduction = 0;

            if (shift == "morning")
            {
                if (minutesLate >= 6 && minutesLate <= 10)
                {
                    deduction = 15.0 / 480.0; // Deduct 15 mins
                }
                else if (minutesLate >= 11 && minutesLate <= 15)
                {
                    deduction = 30.0 / 480.0; // Deduct 30 mins
                }
                else if (minutesLate >= 16 && minutesLate <= 20)
                {
                    deduction = 45.0 / 480.0; // Deduct 45 mins
                }
                else if (minutesLate >= 21 && minutesLate <= 30)
                {
                    deduction = 60.0 / 480.0; // Deduct 1 hour
                }
                else if (minutesLate > 30)
                {
                    // For minutes late over 30, deduct proportional to minutes late
                    deduction = minutesLate / 480.0;
                }
                else if (minutesLate > 0 && minutesLate <= 5)
                {
                    deduction = 0; // No deduction for up to 5 mins late
                }
            }
            else if (shift == "afternoon")
            {
                // Implement deduction logic for afternoon shift if needed
                if (minutesLate > 0)
                {
                    deduction = minutesLate / 480.0; // Deduct proportional to minutes late
                }
            }

            return deduction;
        }

        private string ConvertTo24HourFormat(string time12Hour)
        {
            DateTime time = DateTime.ParseExact(time12Hour, "h:mm tt", CultureInfo.InvariantCulture);
            return time.ToString("HH:mm");
        }



    }
}
