namespace Central_Juan_Payroll_System
{
    partial class SumAtt
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
            dgvAttSumm = new DataGridView();
            btnAttClear = new Button();
            dtpAttendance = new DateTimePicker();
            label1 = new Label();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvAttSumm).BeginInit();
            SuspendLayout();
            // 
            // dgvAttSumm
            // 
            dgvAttSumm.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAttSumm.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAttSumm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttSumm.Location = new Point(41, 118);
            dgvAttSumm.Name = "dgvAttSumm";
            dgvAttSumm.Size = new Size(609, 279);
            dgvAttSumm.TabIndex = 84;
            // 
            // btnAttClear
            // 
            btnAttClear.BackColor = Color.MediumTurquoise;
            btnAttClear.FlatAppearance.BorderSize = 2;
            btnAttClear.FlatAppearance.MouseOverBackColor = Color.Aqua;
            btnAttClear.FlatStyle = FlatStyle.Flat;
            btnAttClear.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAttClear.ForeColor = Color.White;
            btnAttClear.Location = new Point(304, 403);
            btnAttClear.Name = "btnAttClear";
            btnAttClear.Size = new Size(97, 31);
            btnAttClear.TabIndex = 83;
            btnAttClear.Text = "Close";
            btnAttClear.UseVisualStyleBackColor = false;
            btnAttClear.Click += btnAttClear_Click;
            // 
            // dtpAttendance
            // 
            dtpAttendance.Location = new Point(75, 80);
            dtpAttendance.Name = "dtpAttendance";
            dtpAttendance.Size = new Size(218, 23);
            dtpAttendance.TabIndex = 81;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 192, 192);
            label1.Location = new Point(244, 40);
            label1.Name = "label1";
            label1.Size = new Size(205, 25);
            label1.TabIndex = 79;
            label1.Text = "Attendance Summary";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 192, 192);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 22);
            panel4.Name = "panel4";
            panel4.Size = new Size(20, 418);
            panel4.TabIndex = 78;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 192, 192);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 440);
            panel3.Name = "panel3";
            panel3.Size = new Size(668, 22);
            panel3.TabIndex = 77;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 192, 192);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(668, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(20, 440);
            panel2.TabIndex = 76;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 192, 192);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(688, 22);
            panel1.TabIndex = 75;
            // 
            // SumAtt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 462);
            Controls.Add(dgvAttSumm);
            Controls.Add(btnAttClear);
            Controls.Add(dtpAttendance);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SumAtt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Attendance Summary";
            ((System.ComponentModel.ISupportInitialize)dgvAttSumm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAttSumm;
        private Button btnAttClear;
        private DateTimePicker dtpAttendance;
        private Label label1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
    }
}