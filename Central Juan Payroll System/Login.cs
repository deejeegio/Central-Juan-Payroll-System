namespace Central_Juan_Payroll_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard das = new Central_Juan_Payroll_System.Dashboard();
            das.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
