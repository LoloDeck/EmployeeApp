namespace EmployeeApp
{
    partial class frmComputeSalary
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
            lblFirstname = new Label();
            lblLastname = new Label();
            lblDepartment = new Label();
            lblJobTitle = new Label();
            firstNameTxtbox = new TextBox();
            lastNametxtbox = new TextBox();
            departmentTxtbox = new TextBox();
            jobTitleTxtbox = new TextBox();
            lblRateperHour = new Label();
            lblTotalHoursWorked = new Label();
            ratePerHourTxtbox = new TextBox();
            totalHoursWorkedTxtbox = new TextBox();
            ComputeBtn = new Button();
            firstNamelbl = new Label();
            lastNameLbl = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // lblFirstname
            // 
            lblFirstname.AutoSize = true;
            lblFirstname.Font = new Font("Segoe UI", 11F);
            lblFirstname.Location = new Point(27, 39);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(77, 20);
            lblFirstname.TabIndex = 0;
            lblFirstname.Text = "First name";
            // 
            // lblLastname
            // 
            lblLastname.AutoSize = true;
            lblLastname.Font = new Font("Segoe UI", 11F);
            lblLastname.Location = new Point(249, 39);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(76, 20);
            lblLastname.TabIndex = 1;
            lblLastname.Text = "Last name";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Font = new Font("Segoe UI", 11F);
            lblDepartment.Location = new Point(27, 112);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(89, 20);
            lblDepartment.TabIndex = 2;
            lblDepartment.Text = "Department";
            // 
            // lblJobTitle
            // 
            lblJobTitle.AutoSize = true;
            lblJobTitle.Font = new Font("Segoe UI", 11F);
            lblJobTitle.Location = new Point(249, 112);
            lblJobTitle.Name = "lblJobTitle";
            lblJobTitle.Size = new Size(62, 20);
            lblJobTitle.TabIndex = 3;
            lblJobTitle.Text = "Job title";
            // 
            // firstNameTxtbox
            // 
            firstNameTxtbox.Font = new Font("Segoe UI", 11F);
            firstNameTxtbox.Location = new Point(27, 62);
            firstNameTxtbox.Name = "firstNameTxtbox";
            firstNameTxtbox.Size = new Size(199, 27);
            firstNameTxtbox.TabIndex = 4;
            // 
            // lastNametxtbox
            // 
            lastNametxtbox.Font = new Font("Segoe UI", 11F);
            lastNametxtbox.Location = new Point(249, 62);
            lastNametxtbox.Name = "lastNametxtbox";
            lastNametxtbox.Size = new Size(199, 27);
            lastNametxtbox.TabIndex = 5;
            // 
            // departmentTxtbox
            // 
            departmentTxtbox.Font = new Font("Segoe UI", 11F);
            departmentTxtbox.Location = new Point(27, 135);
            departmentTxtbox.Name = "departmentTxtbox";
            departmentTxtbox.Size = new Size(199, 27);
            departmentTxtbox.TabIndex = 6;
            // 
            // jobTitleTxtbox
            // 
            jobTitleTxtbox.Font = new Font("Segoe UI", 11F);
            jobTitleTxtbox.Location = new Point(249, 135);
            jobTitleTxtbox.Name = "jobTitleTxtbox";
            jobTitleTxtbox.Size = new Size(199, 27);
            jobTitleTxtbox.TabIndex = 7;
            // 
            // lblRateperHour
            // 
            lblRateperHour.AutoSize = true;
            lblRateperHour.Font = new Font("Segoe UI", 11F);
            lblRateperHour.Location = new Point(27, 217);
            lblRateperHour.Name = "lblRateperHour";
            lblRateperHour.Size = new Size(99, 20);
            lblRateperHour.TabIndex = 8;
            lblRateperHour.Text = "Rate per hour";
            // 
            // lblTotalHoursWorked
            // 
            lblTotalHoursWorked.AutoSize = true;
            lblTotalHoursWorked.Font = new Font("Segoe UI", 11F);
            lblTotalHoursWorked.Location = new Point(249, 217);
            lblTotalHoursWorked.Name = "lblTotalHoursWorked";
            lblTotalHoursWorked.Size = new Size(135, 20);
            lblTotalHoursWorked.TabIndex = 9;
            lblTotalHoursWorked.Text = "Total hours worked";
            // 
            // ratePerHourTxtbox
            // 
            ratePerHourTxtbox.Font = new Font("Segoe UI", 11F);
            ratePerHourTxtbox.Location = new Point(27, 240);
            ratePerHourTxtbox.Name = "ratePerHourTxtbox";
            ratePerHourTxtbox.Size = new Size(199, 27);
            ratePerHourTxtbox.TabIndex = 10;
            // 
            // totalHoursWorkedTxtbox
            // 
            totalHoursWorkedTxtbox.Font = new Font("Segoe UI", 11F);
            totalHoursWorkedTxtbox.Location = new Point(249, 240);
            totalHoursWorkedTxtbox.Name = "totalHoursWorkedTxtbox";
            totalHoursWorkedTxtbox.Size = new Size(199, 27);
            totalHoursWorkedTxtbox.TabIndex = 11;
            // 
            // ComputeBtn
            // 
            ComputeBtn.BackColor = Color.Crimson;
            ComputeBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ComputeBtn.Location = new Point(165, 286);
            ComputeBtn.Name = "ComputeBtn";
            ComputeBtn.Size = new Size(146, 40);
            ComputeBtn.TabIndex = 12;
            ComputeBtn.Text = "Compute Salary";
            ComputeBtn.UseVisualStyleBackColor = false;
            ComputeBtn.Click += ComputeBtn_Click;
            // 
            // firstNamelbl
            // 
            firstNamelbl.AutoSize = true;
            firstNamelbl.Font = new Font("Segoe UI", 11F);
            firstNamelbl.Location = new Point(165, 350);
            firstNamelbl.Name = "firstNamelbl";
            firstNamelbl.Size = new Size(130, 20);
            firstNamelbl.TabIndex = 13;
            firstNamelbl.Text = "<First name here>";
            // 
            // lastNameLbl
            // 
            lastNameLbl.AutoSize = true;
            lastNameLbl.Font = new Font("Segoe UI", 11F);
            lastNameLbl.Location = new Point(165, 380);
            lastNameLbl.Name = "lastNameLbl";
            lastNameLbl.Size = new Size(129, 20);
            lastNameLbl.TabIndex = 14;
            lastNameLbl.Text = "<Last name here>";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(165, 412);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 15;
            label1.Text = "00.00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(27, 350);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 16;
            label2.Text = "First name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(27, 380);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 17;
            label3.Text = "Last name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(27, 412);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 18;
            label4.Text = "Basic Salary:";
            // 
            // frmComputeSalary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 470);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lastNameLbl);
            Controls.Add(firstNamelbl);
            Controls.Add(ComputeBtn);
            Controls.Add(totalHoursWorkedTxtbox);
            Controls.Add(ratePerHourTxtbox);
            Controls.Add(lblTotalHoursWorked);
            Controls.Add(lblRateperHour);
            Controls.Add(jobTitleTxtbox);
            Controls.Add(departmentTxtbox);
            Controls.Add(lastNametxtbox);
            Controls.Add(firstNameTxtbox);
            Controls.Add(lblJobTitle);
            Controls.Add(lblDepartment);
            Controls.Add(lblLastname);
            Controls.Add(lblFirstname);
            Name = "frmComputeSalary";
            Text = "Employee Salary Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstname;
        private Label lblLastname;
        private Label lblDepartment;
        private Label lblJobTitle;
        private TextBox firstNameTxtbox;
        private TextBox lastNametxtbox;
        private TextBox departmentTxtbox;
        private TextBox jobTitleTxtbox;
        private Label lblRateperHour;
        private Label lblTotalHoursWorked;
        private TextBox ratePerHourTxtbox;
        private TextBox totalHoursWorkedTxtbox;
        private Button ComputeBtn;
        private Label firstNamelbl;
        private Label lastNameLbl;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
