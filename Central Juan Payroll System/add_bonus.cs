using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Central_Juan_Payroll_System
{
    public partial class add_bonus : Form
    {
        SQLiteConnection sqlite_conn;

        public add_bonus()
        {
            InitializeComponent();
            // Initialize SQLite connection
            sqlite_conn = new SQLiteConnection("Data Source=C:\\sqlite\\cj.db");
            sqlite_conn.Open();
        }


            
    }
}
