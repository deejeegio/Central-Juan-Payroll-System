namespace Central_Juan_Payroll_System
{
    partial class UC_Attendance
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
            btnAddDTR = new Button();
            btAttSumm = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(497, 104);
            label1.Name = "label1";
            label1.Size = new Size(169, 32);
            label1.TabIndex = 9;
            label1.Text = "Attendance";
            // 
            // btnAddDTR
            // 
            btnAddDTR.BackColor = Color.MediumTurquoise;
            btnAddDTR.FlatAppearance.BorderSize = 2;
            btnAddDTR.FlatStyle = FlatStyle.Flat;
            btnAddDTR.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddDTR.ForeColor = Color.White;
            btnAddDTR.Image = Properties.Resources.dtr_list_removebg_preview__1_;
            btnAddDTR.Location = new Point(289, 230);
            btnAddDTR.Name = "btnAddDTR";
            btnAddDTR.Size = new Size(214, 147);
            btnAddDTR.TabIndex = 11;
            btnAddDTR.Text = "Employees DTR";
            btnAddDTR.TextAlign = ContentAlignment.BottomCenter;
            btnAddDTR.UseVisualStyleBackColor = false;
            btnAddDTR.Click += btnAddDTR_Click;
            // 
            // btAttSumm
            // 
            btAttSumm.BackColor = Color.MediumTurquoise;
            btAttSumm.FlatAppearance.BorderSize = 2;
            btAttSumm.FlatStyle = FlatStyle.Flat;
            btAttSumm.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAttSumm.ForeColor = Color.White;
            btAttSumm.Image = Properties.Resources.sum_attendance__1__removebg_preview;
            btAttSumm.Location = new Point(658, 230);
            btAttSumm.Name = "btAttSumm";
            btAttSumm.Size = new Size(214, 147);
            btAttSumm.TabIndex = 12;
            btAttSumm.Text = "Attendance Summary";
            btAttSumm.TextAlign = ContentAlignment.BottomCenter;
            btAttSumm.UseVisualStyleBackColor = false;
            btAttSumm.Click += btAttSumm_Click;
            // 
            // UC_Attendance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btAttSumm);
            Controls.Add(btnAddDTR);
            Controls.Add(label1);
            Name = "UC_Attendance";
            Size = new Size(1152, 552);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnAddDTR;
        private Button btAttSumm;
    }
}
