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
    public partial class UC_AddEmployee : UserControl
    {



        private string connectionString = "server=10.0.254.222;port=3306;user=username;password=1234;database=cjis_db";
            

        public UC_AddEmployee()
        {
            InitializeComponent();
            PopulateDepartmentComboBox();
        }

        private void PopulateDepartmentComboBox()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT department_id, department_name FROM departments";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    departmentComboBox.DataSource = dt;
                    departmentComboBox.DisplayMember = "department_name";
                    departmentComboBox.ValueMember = "department_id";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnEmployeeSave_Click(object sender, EventArgs e)
        {
            string employeeCode = employeeCodeTextBox.Text;
            string firstName = firstNameTextBox.Text;
            string middleName = middleNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string email = emailTxt.Text;
            string contactNumber = contactNo.Text;
            DateTime dateOfBirth = birthDate.Value;
            int departmentId = Convert.ToInt32(departmentComboBox.SelectedValue);
            string positionTitle = positionBox.Text;


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO employees (employee_id, first_name, middle_name, last_name, email, contact_number, date_of_birth, department_id, position_title) " +
                                   "VALUES (@EmployeeCode, @FirstName, @MiddleName, @LastName, @Email, @ContactNumber, @DateOfBirth, @DepartmentId, @PositionTitle)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EmployeeCode", employeeCode);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@MiddleName", middleName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@ContactNumber", contactNumber);
                    command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                    command.Parameters.AddWithValue("@DepartmentId", departmentId);
                    command.Parameters.AddWithValue("@PositionTitle", positionTitle);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Employee information saved successfully!");
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to save employee information.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }

        private void ClearFields()
        {
            employeeCodeTextBox.Text = string.Empty;
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            middleNameTextBox.Text = string.Empty;
            emailTxt.Text = string.Empty;
            contactNo.Text = string.Empty;
            positionBox.Text = string.Empty;
            birthDate.Value = DateTime.Today;
            departmentComboBox.SelectedIndex = -1;
        }

    }
}
