using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Central_Juan_Payroll_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uC_EmployeeList1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            uC_Settings1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            uC_Salary1.BringToFront();
        }

        private void uC_Salary1_Load(object sender, EventArgs e)
        {

        }

        private void addEmployee_Click(object sender, EventArgs e)
        {
            uC_Employee1.BringToFront();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            uC_Attendance1.BringToFront();
        }
    }
}
