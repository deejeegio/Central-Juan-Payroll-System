namespace Central_Juan_Payroll_System
{
    partial class add_EmDTR
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
            btnBonusClear = new Button();
            btnDTRSave = new Button();
            dtpDTR = new DateTimePicker();
            label3 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            dateTimePickerTimeInMorning = new DateTimePicker();
            label2 = new Label();
            comboBoxEmployees = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            dateTimePickerTimeOutMorning = new DateTimePicker();
            label6 = new Label();
            dateTimePickerTimeOutAfternoon = new DateTimePicker();
            label7 = new Label();
            dateTimePickerTimeInAfternoon = new DateTimePicker();
            SuspendLayout();
            // 
            // btnBonusClear
            // 
            btnBonusClear.BackColor = Color.MediumTurquoise;
            btnBonusClear.FlatAppearance.BorderSize = 2;
            btnBonusClear.FlatAppearance.MouseOverBackColor = Color.Aqua;
            btnBonusClear.FlatStyle = FlatStyle.Flat;
            btnBonusClear.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBonusClear.ForeColor = Color.White;
            btnBonusClear.Location = new Point(339, 276);
            btnBonusClear.Name = "btnBonusClear";
            btnBonusClear.Size = new Size(97, 31);
            btnBonusClear.TabIndex = 73;
            btnBonusClear.Text = "Clear";
            btnBonusClear.UseVisualStyleBackColor = false;
            // 
            // btnDTRSave
            // 
            btnDTRSave.BackColor = Color.MediumTurquoise;
            btnDTRSave.FlatAppearance.BorderSize = 2;
            btnDTRSave.FlatAppearance.MouseOverBackColor = Color.Aqua;
            btnDTRSave.FlatStyle = FlatStyle.Flat;
            btnDTRSave.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDTRSave.ForeColor = Color.White;
            btnDTRSave.Location = new Point(243, 276);
            btnDTRSave.Name = "btnDTRSave";
            btnDTRSave.Size = new Size(97, 31);
            btnDTRSave.TabIndex = 72;
            btnDTRSave.Text = "Save";
            btnDTRSave.UseVisualStyleBackColor = false;
            btnDTRSave.Click += btnDTRSave_Click;
            // 
            // dtpDTR
            // 
            dtpDTR.Location = new Point(410, 81);
            dtpDTR.Name = "dtpDTR";
            dtpDTR.Size = new Size(218, 23);
            dtpDTR.TabIndex = 71;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F);
            label3.Location = new Point(359, 81);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 66;
            label3.Text = "Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 192, 192);
            label1.Location = new Point(280, 34);
            label1.Name = "label1";
            label1.Size = new Size(139, 25);
            label1.TabIndex = 63;
            label1.Text = "Employee DTR";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 192, 192);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 22);
            panel4.Name = "panel4";
            panel4.Size = new Size(20, 306);
            panel4.TabIndex = 62;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 192, 192);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 328);
            panel3.Name = "panel3";
            panel3.Size = new Size(668, 22);
            panel3.TabIndex = 61;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 192, 192);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(668, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(20, 328);
            panel2.TabIndex = 60;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 192, 192);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(688, 22);
            panel1.TabIndex = 59;
            // 
            // dateTimePickerTimeInMorning
            // 
            dateTimePickerTimeInMorning.Location = new Point(230, 153);
            dateTimePickerTimeInMorning.Name = "dateTimePickerTimeInMorning";
            dateTimePickerTimeInMorning.Size = new Size(81, 23);
            dateTimePickerTimeInMorning.TabIndex = 74;
            dateTimePickerTimeInMorning.Value = new DateTime(2024, 4, 18, 19, 31, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F);
            label2.Location = new Point(45, 78);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 75;
            label2.Text = "Employee:";
            // 
            // comboBoxEmployees
            // 
            comboBoxEmployees.FormattingEnabled = true;
            comboBoxEmployees.Location = new Point(136, 78);
            comboBoxEmployees.Name = "comboBoxEmployees";
            comboBoxEmployees.Size = new Size(175, 23);
            comboBoxEmployees.TabIndex = 76;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F);
            label4.Location = new Point(181, 130);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 77;
            label4.Text = "Time In (AM):";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F);
            label5.Location = new Point(359, 130);
            label5.Name = "label5";
            label5.Size = new Size(115, 20);
            label5.TabIndex = 79;
            label5.Text = "Time Out (AM):";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // dateTimePickerTimeOutMorning
            // 
            dateTimePickerTimeOutMorning.Location = new Point(410, 153);
            dateTimePickerTimeOutMorning.Name = "dateTimePickerTimeOutMorning";
            dateTimePickerTimeOutMorning.Size = new Size(81, 23);
            dateTimePickerTimeOutMorning.TabIndex = 78;
            dateTimePickerTimeOutMorning.Value = new DateTime(2024, 4, 18, 19, 31, 0, 0);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11.25F);
            label6.Location = new Point(359, 183);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 83;
            label6.Text = "Time Out (PM):";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // dateTimePickerTimeOutAfternoon
            // 
            dateTimePickerTimeOutAfternoon.Location = new Point(410, 206);
            dateTimePickerTimeOutAfternoon.Name = "dateTimePickerTimeOutAfternoon";
            dateTimePickerTimeOutAfternoon.Size = new Size(81, 23);
            dateTimePickerTimeOutAfternoon.TabIndex = 82;
            dateTimePickerTimeOutAfternoon.Value = new DateTime(2024, 4, 18, 19, 31, 0, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 11.25F);
            label7.Location = new Point(181, 183);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 81;
            label7.Text = "Time In (PM):";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // dateTimePickerTimeInAfternoon
            // 
            dateTimePickerTimeInAfternoon.Location = new Point(230, 206);
            dateTimePickerTimeInAfternoon.Name = "dateTimePickerTimeInAfternoon";
            dateTimePickerTimeInAfternoon.Size = new Size(81, 23);
            dateTimePickerTimeInAfternoon.TabIndex = 80;
            dateTimePickerTimeInAfternoon.Value = new DateTime(2024, 4, 18, 19, 31, 0, 0);
            // 
            // add_EmDTR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 350);
            Controls.Add(label6);
            Controls.Add(dateTimePickerTimeOutAfternoon);
            Controls.Add(label7);
            Controls.Add(dateTimePickerTimeInAfternoon);
            Controls.Add(label5);
            Controls.Add(dateTimePickerTimeOutMorning);
            Controls.Add(label4);
            Controls.Add(comboBoxEmployees);
            Controls.Add(label2);
            Controls.Add(dateTimePickerTimeInMorning);
            Controls.Add(btnBonusClear);
            Controls.Add(btnDTRSave);
            Controls.Add(dtpDTR);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "add_EmDTR";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DTR";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBonusClear;
        private Button btnDTRSave;
        private DateTimePicker dtpDTR;
        private Label label3;
        private Label label1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private DateTimePicker dateTimePickerTimeInMorning;
        private Label label2;
        private ComboBox comboBoxEmployees;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePickerTimeOutMorning;
        private Label label6;
        private DateTimePicker dateTimePickerTimeOutAfternoon;
        private Label label7;
        private DateTimePicker dateTimePickerTimeInAfternoon;
    }
}