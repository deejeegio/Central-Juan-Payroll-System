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
            string timeInMorning12Hour = dateTimePickerTimeInMorning.Value.ToString("h:mm tt");
            string timeOutMorning12Hour = dateTimePickerTimeOutMorning.Value.ToString("h:mm tt");
            string timeInAfternoon12Hour = dateTimePickerTimeInAfternoon.Value.ToString("h:mm tt");
            string timeOutAfternoon12Hour = dateTimePickerTimeOutAfternoon.Value.ToString("h:mm tt");

            // Convert to 24-hour format
            string timeInMorning24Hour = ConvertTo24HourFormat(timeInMorning12Hour);
            string timeOutMorning24Hour = ConvertTo24HourFormat(timeOutMorning12Hour);
            string timeInAfternoon24Hour = ConvertTo24HourFormat(timeInAfternoon12Hour);
            string timeOutAfternoon24Hour = ConvertTo24HourFormat(timeOutAfternoon12Hour);

            // Deduction logic
            double deductedDays = CalculateDeduction(timeInMorning24Hour);

            // Insert into MySQL database
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO attendance (employee_id, employee_name, attendance_date, time_in_morning, time_out_morning, time_in_afternoon, time_out_afternoon, deducted_days) " +
                                   "VALUES (@EmployeeId, @EmployeeName, @AttendanceDate, @TimeInMorning, @TimeOutMorning, @TimeInAfternoon, @TimeOutAfternoon, @DeductedDays)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EmployeeId", employeeId);
                    command.Parameters.AddWithValue("@EmployeeName", employeeName);
                    command.Parameters.AddWithValue("@AttendanceDate", dateDTR);
                    command.Parameters.AddWithValue("@TimeInMorning", timeInMorning24Hour);
                    command.Parameters.AddWithValue("@TimeOutMorning", timeOutMorning24Hour);
                    command.Parameters.AddWithValue("@TimeInAfternoon", timeInAfternoon24Hour);
                    command.Parameters.AddWithValue("@TimeOutAfternoon", timeOutAfternoon24Hour);
                    command.Parameters.AddWithValue("@DeductedDays", deductedDays);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("DTR saved successfully with deduction!");
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

        private double CalculateDeduction(string timeInMorning)
        {
            TimeSpan startMorning = TimeSpan.Parse("09:00");
            TimeSpan actualTimeInMorning = TimeSpan.Parse(timeInMorning);

            int minutesLate = (actualTimeInMorning > startMorning) ? (int)(actualTimeInMorning - startMorning).TotalMinutes : 0;
            double deduction = 0;

            // Deduction logic based on lateness intervals
            if (minutesLate > 0 && minutesLate <= 5)
            {
                deduction = 0; // No deduction if late for 0-5 minutes
            }
            else if (minutesLate >= 6 && minutesLate <= 10)
            {
                deduction = CalculateProportionalDeduction(15);
            }
            else if (minutesLate >= 11 && minutesLate <= 15)
            {
                deduction = CalculateProportionalDeduction(30);
            }
            else if (minutesLate >= 16 && minutesLate <= 20)
            {
                deduction = CalculateProportionalDeduction(45);
            }
            else if (minutesLate >= 21 && minutesLate <= 30)
            {
                deduction = CalculateProportionalDeduction(60);
            }
            else if (minutesLate > 30)
            {
                // Calculate additional deduction for every minute beyond 9:30 AM
                int extraMinutesLate = minutesLate - 30;
                deduction = CalculateProportionalDeduction(60 + extraMinutesLate);
            }

            return deduction;
        }

        // Proportional deduction calculation
        private double CalculateProportionalDeduction(int lateMinutes)
        {
            const int fullDayMinutes = 480; // Full day is 8 hours = 480 minutes
            int workingMinutesAfterLate = fullDayMinutes - lateMinutes;

            // Calculate the deducted days based on the ratio of late minutes to full day
            double deductionRatio = (double)workingMinutesAfterLate / fullDayMinutes;

            // Return the deduction as days (e.g., 0.91 for 9:17am arrival)
            return Math.Round(1 - deductionRatio, 2); // 1 represents full day, subtracting ratio gives the deducted portion
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
