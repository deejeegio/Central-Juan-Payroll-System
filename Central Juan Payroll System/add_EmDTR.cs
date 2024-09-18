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

            // Time inputs for morning and afternoon
            TimeSpan timeInMorning = dateTimePickerTimeInMorning.Value.TimeOfDay;
            TimeSpan timeOutMorning = dateTimePickerTimeOutMorning.Value.TimeOfDay;
            TimeSpan timeInAfternoon = dateTimePickerTimeInAfternoon.Value.TimeOfDay;
            TimeSpan timeOutAfternoon = dateTimePickerTimeOutAfternoon.Value.TimeOfDay;

            // Define work hours
            TimeSpan startMorning = new TimeSpan(9, 0, 0); // 9:00 AM
            TimeSpan endMorning = new TimeSpan(12, 0, 0); // 12:00 PM
            TimeSpan startAfternoon = new TimeSpan(13, 0, 0); // 1:00 PM
            TimeSpan endAfternoon = new TimeSpan(18, 0, 0); // 6:00 PM
            int totalWorkMinutes = 480; // Total 8 work hours = 480 minutes

            // Late deduction logic for morning
            int lateMorningMinutes = 0;
            if (timeInMorning > startMorning)
            {
                if (timeInMorning >= new TimeSpan(9, 6, 0) && timeInMorning <= new TimeSpan(9, 10, 0))
                {
                    lateMorningMinutes = 15;
                }
                else if (timeInMorning >= new TimeSpan(9, 11, 0) && timeInMorning <= new TimeSpan(9, 15, 0))
                {
                    lateMorningMinutes = 30;
                }
                else if (timeInMorning >= new TimeSpan(9, 16, 0) && timeInMorning <= new TimeSpan(9, 20, 0))
                {
                    lateMorningMinutes = 45;
                }
                else if (timeInMorning >= new TimeSpan(9, 21, 0) && timeInMorning <= new TimeSpan(9, 30, 0))
                {
                    lateMorningMinutes = 60; // 1 hour
                }
                else if (timeInMorning >= new TimeSpan(9, 31, 0) && timeInMorning <= new TimeSpan(9, 59, 59))
                {
                    lateMorningMinutes = 80; // 50 minutes late with compounded late penalty
                }
                else
                {
                    lateMorningMinutes = (int)(timeInMorning - startMorning).TotalMinutes;
                }
            }

            // Late deduction logic for afternoon (use actual late minutes)
            int lateAfternoonMinutes = 0;
            if (timeInAfternoon > startAfternoon)
            {
                lateAfternoonMinutes = (int)(timeInAfternoon - startAfternoon).TotalMinutes;
            }

            // Early out deduction logic for afternoon
            int earlyOutMinutes = 0;
            if (timeOutAfternoon < endAfternoon)
            {
                earlyOutMinutes = (int)(endAfternoon - timeOutAfternoon).TotalMinutes;
            }

            // Total late and early out minutes in the day
            int totalLateMinutes = lateMorningMinutes + lateAfternoonMinutes + earlyOutMinutes;

            // Deducted days and credited days calculation
            double deductedDays = (double)totalLateMinutes / totalWorkMinutes;
            double creditedDays = 1.0 - deductedDays;

            // Calculate overtime if applicable (only count if more than 30 minutes)
            TimeSpan overtime = timeOutAfternoon - endAfternoon;
            if (overtime.TotalMinutes > 30)
            {
                creditedDays += overtime.TotalMinutes / totalWorkMinutes;
            }

            // Round the results to 2 decimal places
            deductedDays = Math.Round(deductedDays, 2);
            creditedDays = Math.Round(creditedDays, 2);

            // Insert the data into the MySQL database
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO attendance (employee_id, employee_name, attendance_date, time_in_morning, time_out_morning, time_in_afternoon, time_out_afternoon, days_credited, deducted_days) " +
                                   "VALUES (@EmployeeId, @EmployeeName, @AttendanceDate, @TimeInMorning, @TimeOutMorning, @TimeInAfternoon, @TimeOutAfternoon, @DaysCredited, @DaysDeducted)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EmployeeId", employeeId);
                    command.Parameters.AddWithValue("@EmployeeName", employeeName);
                    command.Parameters.AddWithValue("@AttendanceDate", dateDTR);
                    command.Parameters.AddWithValue("@TimeInMorning", timeInMorning.ToString(@"hh\:mm"));
                    command.Parameters.AddWithValue("@TimeOutMorning", timeOutMorning.ToString(@"hh\:mm"));
                    command.Parameters.AddWithValue("@TimeInAfternoon", timeInAfternoon.ToString(@"hh\:mm"));
                    command.Parameters.AddWithValue("@TimeOutAfternoon", timeOutAfternoon.ToString(@"hh\:mm"));
                    command.Parameters.AddWithValue("@DaysCredited", creditedDays);
                    command.Parameters.AddWithValue("@DaysDeducted", deductedDays);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("DTR saved successfully!");
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
            int totalShiftMinutes = shift == "morning" ? 180 : 300; // Morning: 180 minutes, Afternoon: 300 minutes

            // Handle full absence for the morning
            if (shift == "morning" && timeIn == "00:00")
            {
                return 0.375; // Full 3-hour deduction (3/8 = 0.375 days deduction)
            }

            // Late for morning or afternoon
            if (shift == "morning" && actualTimeIn > startMorning)
            {
                minutesLate = (int)(actualTimeIn - startMorning).TotalMinutes;
            }
            else if (shift == "afternoon" && actualTimeIn > startAfternoon)
            {
                minutesLate = (int)(actualTimeIn - startAfternoon).TotalMinutes;
            }

            // Deduction for the shift based on minutes late
            double deduction = CalculateLateDeduction(minutesLate, totalShiftMinutes, shift);

            return deduction;
        }

        // Calculate deduction based on lateness, adjusted for morning and afternoon shifts
        private double CalculateLateDeduction(int minutesLate, int totalShiftMinutes, string shift)
        {
            double deduction = 0;

            if (minutesLate > 0)
            {
                deduction = (double)minutesLate / totalShiftMinutes; // Deduction proportional to shift minutes
                if (shift == "morning")
                {
                    deduction *= 0.375; // Morning is 3 hours out of 8 (3/8 = 0.375)
                }
                else
                {
                    deduction *= 0.625; // Afternoon is 5 hours out of 8 (5/8 = 0.625)
                }
            }

            return deduction;
        }

        // Calculate overtime hours (only count overtime if it's more than 30 minutes past 6:00 PM)
        private double CalculateOvertime(string timeOutAfternoon24Hour)
        {
            TimeSpan endOfDay = TimeSpan.Parse("18:00");
            TimeSpan actualTimeOut = TimeSpan.Parse(timeOutAfternoon24Hour);

            if (actualTimeOut > endOfDay)
            {
                int overtimeMinutes = (int)(actualTimeOut - endOfDay).TotalMinutes;

                // Only count overtime if it's over 30 minutes
                if (overtimeMinutes > 30)
                {
                    return (overtimeMinutes - 30) / 60.0; // Convert minutes to hours, subtracting the 30-minute threshold
                }
            }

            return 0; // No overtime if less than 30 minutes past 6:00 PM
        }

        private string ConvertTo24HourFormat(string time12Hour)
        {
            DateTime time = DateTime.ParseExact(time12Hour, "h:mm tt", CultureInfo.InvariantCulture);
            return time.ToString("HH:mm");
        }



    }
}
