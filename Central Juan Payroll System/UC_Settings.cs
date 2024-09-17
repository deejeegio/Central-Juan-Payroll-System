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
    public partial class UC_Settings : UserControl
    {
        public UC_Settings()
        {
            InitializeComponent();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            using (add_payslip abn = new Central_Juan_Payroll_System.add_payslip())
            {
                abn.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (add_allowances all = new Central_Juan_Payroll_System.add_allowances())
            {
                all.ShowDialog();
            }
        }
    }
}
