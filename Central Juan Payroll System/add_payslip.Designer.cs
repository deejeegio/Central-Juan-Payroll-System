namespace Central_Juan_Payroll_System
{
    partial class add_payslip
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
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            btnClear = new Button();
            btnPaySave = new Button();
            dtpPayslip = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 192, 192);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 22);
            panel4.Name = "panel4";
            panel4.Size = new Size(20, 259);
            panel4.TabIndex = 43;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 192, 192);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 281);
            panel3.Name = "panel3";
            panel3.Size = new Size(668, 22);
            panel3.TabIndex = 42;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 192, 192);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(668, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(20, 281);
            panel2.TabIndex = 41;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 192, 192);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(688, 22);
            panel1.TabIndex = 40;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(290, 101);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(218, 23);
            comboBox1.TabIndex = 111;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(157, 101);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 110;
            label2.Text = "Employee Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 192, 192);
            label1.Location = new Point(290, 41);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 112;
            label1.Text = "Issue Payslip";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.MediumTurquoise;
            btnClear.FlatAppearance.BorderSize = 2;
            btnClear.FlatAppearance.MouseOverBackColor = Color.Aqua;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(427, 218);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(97, 31);
            btnClear.TabIndex = 114;
            btnClear.Text = "Close";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnPaySave
            // 
            btnPaySave.BackColor = Color.MediumTurquoise;
            btnPaySave.FlatAppearance.BorderSize = 2;
            btnPaySave.FlatAppearance.MouseOverBackColor = Color.Aqua;
            btnPaySave.FlatStyle = FlatStyle.Flat;
            btnPaySave.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPaySave.ForeColor = Color.White;
            btnPaySave.Location = new Point(173, 218);
            btnPaySave.Name = "btnPaySave";
            btnPaySave.Size = new Size(97, 31);
            btnPaySave.TabIndex = 113;
            btnPaySave.Text = "Save";
            btnPaySave.UseVisualStyleBackColor = false;
            // 
            // dtpPayslip
            // 
            dtpPayslip.Location = new Point(183, 145);
            dtpPayslip.Name = "dtpPayslip";
            dtpPayslip.Size = new Size(162, 23);
            dtpPayslip.TabIndex = 116;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(132, 145);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 115;
            label3.Text = "From:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(351, 148);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 117;
            label4.Text = "until";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(395, 146);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(162, 23);
            dateTimePicker1.TabIndex = 118;
            // 
            // add_payslip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 303);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(dtpPayslip);
            Controls.Add(label3);
            Controls.Add(btnClear);
            Controls.Add(btnPaySave);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "add_payslip";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "add_bonus";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
        private Button btnClear;
        private Button btnPaySave;
        private DateTimePicker dtpPayslip;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
    }
}