﻿using System;
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



        private string connectionString = "server=localhost;user=root;password=1234;database=central_juan_db";


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
                    string query = "SELECT id, department_name FROM Department";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    departmentComboBox.DataSource = dt;
                    departmentComboBox.DisplayMember = "department_name";
                    departmentComboBox.ValueMember = "id";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnEmployeeSave_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string middleName = middleNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string email = emailTxt.Text;
            string contactNumber = contactNo.Text;
            DateTime dateOfBirth = birthDate.Value;
            int departmentId = Convert.ToInt32(departmentComboBox.SelectedValue);

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Employees (first_name, middle_name, last_name, email, contact_no, birth_date, department_id) " +
                                   "VALUES (@FirstName, @MiddleName, @LastName, @Email, @ContactNumber, @DateOfBirth, @DepartmentId)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@MiddleName", middleName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@ContactNumber", contactNumber);
                    command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                    command.Parameters.AddWithValue("@DepartmentId", departmentId);
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
            firstNameTextBox.Text = string.Empty;
                lastNameTextBox.Text = string.Empty;
                middleNameTextBox.Text = string.Empty;
                emailTxt.Text = string.Empty;
                contactNo.Text = string.Empty;
                birthDate.Value = DateTime.Today;
                departmentComboBox.SelectedIndex = -1;
         }

    }
}
