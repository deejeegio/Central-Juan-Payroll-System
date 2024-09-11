namespace Central_Juan_Payroll_System
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            btnAttendance = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            addEmployee = new Button();
            button5 = new Button();
            label3 = new Label();
            panel3 = new Panel();
            uC_Attendance1 = new UC_Attendance();
            uC_EmployeeList1 = new UC_EmployeeList();
            uC_Salary1 = new UC_Salary();
            uC_Settings1 = new UC_Settings();
            uC_Employee1 = new UC_AddEmployee();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumTurquoise;
            panel1.Controls.Add(btnAttendance);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(198, 781);
            panel1.TabIndex = 0;
            // 
            // btnAttendance
            // 
            btnAttendance.FlatAppearance.BorderSize = 2;
            btnAttendance.FlatAppearance.MouseOverBackColor = Color.Aqua;
            btnAttendance.FlatStyle = FlatStyle.Flat;
            btnAttendance.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAttendance.ForeColor = Color.White;
            btnAttendance.Image = (Image)resources.GetObject("btnAttendance.Image");
            btnAttendance.ImageAlign = ContentAlignment.TopCenter;
            btnAttendance.Location = new Point(31, 544);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(137, 82);
            btnAttendance.TabIndex = 5;
            btnAttendance.Text = "Attendance";
            btnAttendance.TextAlign = ContentAlignment.BottomCenter;
            btnAttendance.UseVisualStyleBackColor = true;
            btnAttendance.Click += btnAttendance_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatAppearance.MouseOverBackColor = Color.Aqua;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.TopCenter;
            button3.Location = new Point(31, 430);
            button3.Name = "button3";
            button3.Size = new Size(137, 82);
            button3.TabIndex = 4;
            button3.Text = "Salary";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseOverBackColor = Color.Aqua;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(31, 311);
            button2.Name = "button2";
            button2.Size = new Size(137, 82);
            button2.TabIndex = 3;
            button2.Text = "Employee";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseOverBackColor = Color.Aqua;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(31, 198);
            button1.Name = "button1";
            button1.Size = new Size(137, 82);
            button1.TabIndex = 2;
            button1.Text = "Home";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cj_logo_circle;
            pictureBox1.Location = new Point(31, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Right;
            panel2.BackColor = Color.MediumTurquoise;
            panel2.Controls.Add(addEmployee);
            panel2.Controls.Add(button5);
            panel2.Location = new Point(236, 124);
            panel2.Name = "panel2";
            panel2.Size = new Size(1159, 111);
            panel2.TabIndex = 1;
            // 
            // addEmployee
            // 
            addEmployee.FlatAppearance.BorderSize = 2;
            addEmployee.FlatAppearance.MouseOverBackColor = Color.Aqua;
            addEmployee.FlatStyle = FlatStyle.Flat;
            addEmployee.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            addEmployee.ForeColor = Color.White;
            addEmployee.Image = Properties.Resources.add_employee__1_;
            addEmployee.ImageAlign = ContentAlignment.TopCenter;
            addEmployee.Location = new Point(858, 14);
            addEmployee.Name = "addEmployee";
            addEmployee.Size = new Size(137, 82);
            addEmployee.TabIndex = 7;
            addEmployee.Text = "Add Employee";
            addEmployee.TextAlign = ContentAlignment.BottomCenter;
            addEmployee.UseVisualStyleBackColor = true;
            addEmployee.Click += addEmployee_Click;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 2;
            button5.FlatAppearance.MouseOverBackColor = Color.Aqua;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.TopCenter;
            button5.Location = new Point(1001, 14);
            button5.Name = "button5";
            button5.Size = new Size(137, 82);
            button5.TabIndex = 6;
            button5.Text = "Settings";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.MediumTurquoise;
            label3.Location = new Point(568, 19);
            label3.Name = "label3";
            label3.Size = new Size(386, 32);
            label3.TabIndex = 2;
            label3.Text = "Payroll Management System";
            // 
            // panel3
            // 
            panel3.Controls.Add(uC_Attendance1);
            panel3.Controls.Add(uC_EmployeeList1);
            panel3.Controls.Add(uC_Salary1);
            panel3.Controls.Add(uC_Settings1);
            panel3.Controls.Add(uC_Employee1);
            panel3.Location = new Point(204, 185);
            panel3.Name = "panel3";
            panel3.Size = new Size(1152, 552);
            panel3.TabIndex = 3;
            // 
            // uC_Attendance1
            // 
            uC_Attendance1.Location = new Point(0, 3);
            uC_Attendance1.Name = "uC_Attendance1";
            uC_Attendance1.Size = new Size(1152, 552);
            uC_Attendance1.TabIndex = 4;
            // 
            // uC_EmployeeList1
            // 
            uC_EmployeeList1.Location = new Point(0, 3);
            uC_EmployeeList1.Name = "uC_EmployeeList1";
            uC_EmployeeList1.Size = new Size(1152, 552);
            uC_EmployeeList1.TabIndex = 3;
            // 
            // uC_Salary1
            // 
            uC_Salary1.Location = new Point(0, 0);
            uC_Salary1.Name = "uC_Salary1";
            uC_Salary1.Size = new Size(1152, 552);
            uC_Salary1.TabIndex = 2;
            uC_Salary1.Load += uC_Salary1_Load;
            // 
            // uC_Settings1
            // 
            uC_Settings1.Location = new Point(0, 3);
            uC_Settings1.Name = "uC_Settings1";
            uC_Settings1.Size = new Size(1152, 552);
            uC_Settings1.TabIndex = 1;
            // 
            // uC_Employee1
            // 
            uC_Employee1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            uC_Employee1.Location = new Point(0, 1);
            uC_Employee1.Margin = new Padding(4);
            uC_Employee1.Name = "uC_Employee1";
            uC_Employee1.Size = new Size(1152, 552);
            uC_Employee1.TabIndex = 0;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 781);
            Controls.Add(panel3);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Dashboard";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button3;
        private Button button2;
        private Button btnAttendance;
        private Label label3;
        private Button button5;
        private Panel panel3;
        private UC_AddEmployee uC_Employee1;
        private UC_Settings uC_Settings1;
        private UC_Salary uC_Salary1;
        private Button addEmployee;
        private UC_EmployeeList uC_EmployeeList1;
        private UC_Attendance uC_Attendance1;
    }
}