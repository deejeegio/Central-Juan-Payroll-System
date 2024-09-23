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
    public partial class UC_Salary : UserControl
    {
        public UC_Salary()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (add_basic_salary abs = new Central_Juan_Payroll_System.add_basic_salary())
            {
                abs.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (add_payslip aps = new Central_Juan_Payroll_System.add_payslip())
            {
                aps.ShowDialog();
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            using (issue_advance_salary ias = new Central_Juan_Payroll_System.issue_advance_salary())
            {
                ias.ShowDialog();
            }
        }
    }
}
