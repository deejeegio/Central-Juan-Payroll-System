namespace Central_Juan_Payroll_System
{
    partial class add_GovtLoan
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
            button3 = new Button();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBox4 = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            cbGov = new ComboBox();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.MediumTurquoise;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatAppearance.MouseOverBackColor = Color.Aqua;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(357, 248);
            button3.Name = "button3";
            button3.Size = new Size(97, 31);
            button3.TabIndex = 90;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumTurquoise;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseOverBackColor = Color.Aqua;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(215, 248);
            button2.Name = "button2";
            button2.Size = new Size(97, 31);
            button2.TabIndex = 89;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(274, 137);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(218, 23);
            dateTimePicker1.TabIndex = 88;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(274, 178);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(218, 23);
            textBox4.TabIndex = 87;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F);
            label5.Location = new Point(202, 177);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 86;
            label5.Text = "ID No.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F);
            label3.Location = new Point(215, 135);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 85;
            label3.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F);
            label2.Location = new Point(170, 100);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 83;
            label2.Text = "Loan Type:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 192, 192);
            label1.Location = new Point(191, 41);
            label1.Name = "label1";
            label1.Size = new Size(287, 25);
            label1.TabIndex = 82;
            label1.Text = "Add Government Contribution";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 192, 192);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 22);
            panel4.Name = "panel4";
            panel4.Size = new Size(20, 272);
            panel4.TabIndex = 81;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 192, 192);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 294);
            panel3.Name = "panel3";
            panel3.Size = new Size(668, 22);
            panel3.TabIndex = 80;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 192, 192);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(668, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(20, 294);
            panel2.TabIndex = 79;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 192, 192);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(688, 22);
            panel1.TabIndex = 78;
            // 
            // cbGov
            // 
            cbGov.FormattingEnabled = true;
            cbGov.Items.AddRange(new object[] { "PAG-IBIG", "SSS", "PHILHEALTH" });
            cbGov.Location = new Point(274, 101);
            cbGov.Name = "cbGov";
            cbGov.Size = new Size(218, 23);
            cbGov.TabIndex = 95;
            // 
            // add_GovtLoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 316);
            Controls.Add(cbGov);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "add_GovtLoan";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox4;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private ComboBox cbGov;
    }
}