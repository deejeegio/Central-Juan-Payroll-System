namespace Central_Juan_Payroll_System
{
    partial class add_13th
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
            cb13_year = new ComboBox();
            button3 = new Button();
            cb13_save = new Button();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            cb13_emp = new ComboBox();
            SuspendLayout();
            // 
            // cb13_year
            // 
            cb13_year.FormattingEnabled = true;
            cb13_year.Location = new Point(274, 113);
            cb13_year.Name = "cb13_year";
            cb13_year.Size = new Size(218, 23);
            cb13_year.TabIndex = 108;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumTurquoise;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatAppearance.MouseOverBackColor = Color.Aqua;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(375, 219);
            button3.Name = "button3";
            button3.Size = new Size(97, 31);
            button3.TabIndex = 107;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = false;
            // 
            // cb13_save
            // 
            cb13_save.BackColor = Color.MediumTurquoise;
            cb13_save.FlatAppearance.BorderSize = 2;
            cb13_save.FlatAppearance.MouseOverBackColor = Color.Aqua;
            cb13_save.FlatStyle = FlatStyle.Flat;
            cb13_save.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            cb13_save.ForeColor = Color.White;
            cb13_save.Location = new Point(233, 219);
            cb13_save.Name = "cb13_save";
            cb13_save.Size = new Size(97, 31);
            cb13_save.TabIndex = 106;
            cb13_save.Text = "Save";
            cb13_save.UseVisualStyleBackColor = false;
            cb13_save.Click += cb13_save_Click; 
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(183, 146);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 103;
            label5.Text = "Employee:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(215, 113);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 101;
            label2.Text = "Year:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 192, 192);
            label1.Location = new Point(274, 39);
            label1.Name = "label1";
            label1.Size = new Size(154, 25);
            label1.TabIndex = 100;
            label1.Text = "13th Month Pay";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 192, 192);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 22);
            panel4.Name = "panel4";
            panel4.Size = new Size(20, 272);
            panel4.TabIndex = 99;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 192, 192);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 294);
            panel3.Name = "panel3";
            panel3.Size = new Size(668, 22);
            panel3.TabIndex = 98;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 192, 192);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(668, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(20, 294);
            panel2.TabIndex = 97;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 192, 192);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(688, 22);
            panel1.TabIndex = 96;
            // 
            // cb13_emp
            // 
            cb13_emp.FormattingEnabled = true;
            cb13_emp.Location = new Point(274, 146);
            cb13_emp.Name = "cb13_emp";
            cb13_emp.Size = new Size(218, 23);
            cb13_emp.TabIndex = 109;
            // 
            // add_13th
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 316);
            Controls.Add(cb13_emp);
            Controls.Add(cb13_year);
            Controls.Add(button3);
            Controls.Add(cb13_save);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "add_13th";
            Text = "add_13th";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb13_year;
        private Button button3;
        private Button cb13_save;
        private Label label5;
        private Label label2;
        private Label label1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private ComboBox cb13_emp;
    }
}