namespace Central_Juan_Payroll_System
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label4 = new Label();
            btnLogin = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(699, 290);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(453, 330);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Please login first";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MediumTurquoise;
            label4.Location = new Point(208, 72);
            label4.Name = "label4";
            label4.Size = new Size(83, 32);
            label4.TabIndex = 2;
            label4.Text = "Login";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MediumTurquoise;
            btnLogin.FlatAppearance.BorderSize = 2;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.Aqua;
            btnLogin.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(152, 206);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(213, 43);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(152, 162);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(213, 26);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(71, 162);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 122);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 26);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(71, 121);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MediumTurquoise;
            label3.Location = new Point(728, 194);
            label3.Name = "label3";
            label3.Size = new Size(386, 32);
            label3.TabIndex = 1;
            label3.Text = "Payroll Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cj_new_logo_web;
            pictureBox1.Location = new Point(95, 249);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(454, 182);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1366, 768);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnLogin;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
    }
}
