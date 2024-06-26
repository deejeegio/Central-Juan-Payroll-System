﻿namespace Central_Juan_Payroll_System
{
    partial class UC_AddEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            firstNameTextBox = new TextBox();
            middleNameTextBox = new TextBox();
            label2 = new Label();
            lastNameTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            emailTxt = new TextBox();
            label6 = new Label();
            btnEmployeeSave = new Button();
            button3 = new Button();
            label7 = new Label();
            label5 = new Label();
            birthDate = new DateTimePicker();
            departmentComboBox = new ComboBox();
            label11 = new Label();
            contactNo = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(427, 125);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(516, 122);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(215, 26);
            firstNameTextBox.TabIndex = 1;
            // 
            // middleNameTextBox
            // 
            middleNameTextBox.Location = new Point(516, 172);
            middleNameTextBox.Name = "middleNameTextBox";
            middleNameTextBox.Size = new Size(215, 26);
            middleNameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(402, 175);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 2;
            label2.Text = "Middle Name";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(516, 217);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(215, 26);
            lastNameTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(425, 223);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 4;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(411, 264);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 6;
            label4.Text = "Department:";
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(516, 348);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(215, 26);
            emailTxt.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(460, 351);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 10;
            label6.Text = "Email:";
            // 
            // btnEmployeeSave
            // 
            btnEmployeeSave.BackColor = Color.MediumTurquoise;
            btnEmployeeSave.FlatAppearance.BorderSize = 2;
            btnEmployeeSave.FlatAppearance.MouseOverBackColor = Color.Aqua;
            btnEmployeeSave.FlatStyle = FlatStyle.Flat;
            btnEmployeeSave.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmployeeSave.ForeColor = Color.White;
            btnEmployeeSave.Location = new Point(455, 491);
            btnEmployeeSave.Name = "btnEmployeeSave";
            btnEmployeeSave.Size = new Size(125, 36);
            btnEmployeeSave.TabIndex = 32;
            btnEmployeeSave.Text = "Save";
            btnEmployeeSave.UseVisualStyleBackColor = false;
            btnEmployeeSave.Click += btnEmployeeSave_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumTurquoise;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatAppearance.MouseOverBackColor = Color.Aqua;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(586, 491);
            button3.Name = "button3";
            button3.Size = new Size(125, 36);
            button3.TabIndex = 33;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(516, 43);
            label7.Name = "label7";
            label7.Size = new Size(148, 23);
            label7.TabIndex = 39;
            label7.Text = "Add Employee";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(411, 305);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 8;
            label5.Text = "Date of Birth";
            // 
            // birthDate
            // 
            birthDate.Format = DateTimePickerFormat.Short;
            birthDate.Location = new Point(516, 305);
            birthDate.Name = "birthDate";
            birthDate.Size = new Size(215, 26);
            birthDate.TabIndex = 9;
            // 
            // departmentComboBox
            // 
            departmentComboBox.FormattingEnabled = true;
            departmentComboBox.Items.AddRange(new object[] { "STORE", "ADMIN", "SERVICE" });
            departmentComboBox.Location = new Point(516, 261);
            departmentComboBox.Name = "departmentComboBox";
            departmentComboBox.Size = new Size(215, 28);
            departmentComboBox.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(413, 401);
            label11.Name = "label11";
            label11.Size = new Size(99, 20);
            label11.TabIndex = 24;
            label11.Text = "Contact No:";
            // 
            // contactNo
            // 
            contactNo.Location = new Point(516, 398);
            contactNo.Name = "contactNo";
            contactNo.Size = new Size(215, 26);
            contactNo.TabIndex = 40;
            // 
            // UC_AddEmployee
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(contactNo);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(btnEmployeeSave);
            Controls.Add(departmentComboBox);
            Controls.Add(label11);
            Controls.Add(emailTxt);
            Controls.Add(label6);
            Controls.Add(birthDate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lastNameTextBox);
            Controls.Add(label3);
            Controls.Add(middleNameTextBox);
            Controls.Add(label2);
            Controls.Add(firstNameTextBox);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "UC_AddEmployee";
            Size = new Size(1152, 552);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox firstNameTextBox;
        private TextBox middleNameTextBox;
        private Label label2;
        private TextBox lastNameTextBox;
        private Label label3;
        private Label label4;
        private TextBox emailTxt;
        private Label label6;
        private Button btnEmployeeSave;
        private Button button3;
        private Label label7;
        private Label label5;
        private DateTimePicker birthDate;
        private ComboBox departmentComboBox;
        private Label label11;
        private TextBox contactNo;
    }
}
