namespace CT2_Company___Management_App.GUI
{
    partial class ManagerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.tbcManager = new System.Windows.Forms.TabControl();
            this.tpEmployees = new System.Windows.Forms.TabPage();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.txtEmployeeSearch = new System.Windows.Forms.TextBox();
            this.btnCancelEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnSaveEmployee = new System.Windows.Forms.Button();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.tpTasks = new System.Windows.Forms.TabPage();
            this.cbAssignedEmployee = new System.Windows.Forms.ComboBox();
            this.dtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.txtTaskSearch = new System.Windows.Forms.TextBox();
            this.btnCancelTask = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnSaveTask = new System.Windows.Forms.Button();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.txtTaskCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProjectTitle = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLastLogin = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblFullName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbcManager.SuspendLayout();
            this.tpEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.tpTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Position:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(439, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password:";
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Location = new System.Drawing.Point(177, 41);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(188, 31);
            this.txtEmployeeId.TabIndex = 1;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(177, 94);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(188, 31);
            this.txtFullName.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(526, 41);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(188, 31);
            this.txtPhone.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(526, 94);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(188, 31);
            this.txtEmail.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(526, 147);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(188, 31);
            this.txtPassword.TabIndex = 6;
            // 
            // tbcManager
            // 
            this.tbcManager.Controls.Add(this.tpEmployees);
            this.tbcManager.Controls.Add(this.tpTasks);
            this.tbcManager.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbcManager.Location = new System.Drawing.Point(32, 112);
            this.tbcManager.Name = "tbcManager";
            this.tbcManager.SelectedIndex = 0;
            this.tbcManager.Size = new System.Drawing.Size(1029, 717);
            this.tbcManager.TabIndex = 12;
            // 
            // tpEmployees
            // 
            this.tpEmployees.Controls.Add(this.cbPosition);
            this.tpEmployees.Controls.Add(this.txtEmployeeSearch);
            this.tpEmployees.Controls.Add(this.btnCancelEmployee);
            this.tpEmployees.Controls.Add(this.btnDeleteEmployee);
            this.tpEmployees.Controls.Add(this.btnSaveEmployee);
            this.tpEmployees.Controls.Add(this.dgvEmployee);
            this.tpEmployees.Controls.Add(this.txtEmployeeId);
            this.tpEmployees.Controls.Add(this.txtPassword);
            this.tpEmployees.Controls.Add(this.label1);
            this.tpEmployees.Controls.Add(this.txtEmail);
            this.tpEmployees.Controls.Add(this.label2);
            this.tpEmployees.Controls.Add(this.txtPhone);
            this.tpEmployees.Controls.Add(this.label3);
            this.tpEmployees.Controls.Add(this.label4);
            this.tpEmployees.Controls.Add(this.txtFullName);
            this.tpEmployees.Controls.Add(this.label5);
            this.tpEmployees.Controls.Add(this.label6);
            this.tpEmployees.Location = new System.Drawing.Point(4, 34);
            this.tpEmployees.Name = "tpEmployees";
            this.tpEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmployees.Size = new System.Drawing.Size(1021, 679);
            this.tpEmployees.TabIndex = 0;
            this.tpEmployees.Text = "Manage Employees";
            this.tpEmployees.UseVisualStyleBackColor = true;
            // 
            // cbPosition
            // 
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(177, 147);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(188, 33);
            this.cbPosition.TabIndex = 3;
            // 
            // txtEmployeeSearch
            // 
            this.txtEmployeeSearch.Location = new System.Drawing.Point(75, 210);
            this.txtEmployeeSearch.Name = "txtEmployeeSearch";
            this.txtEmployeeSearch.PlaceholderText = "Type something to search...";
            this.txtEmployeeSearch.Size = new System.Drawing.Size(869, 31);
            this.txtEmployeeSearch.TabIndex = 10;
            this.txtEmployeeSearch.TextChanged += new System.EventHandler(this.txtEmployeeSearch_TextChanged);
            // 
            // btnCancelEmployee
            // 
            this.btnCancelEmployee.Location = new System.Drawing.Point(799, 146);
            this.btnCancelEmployee.Name = "btnCancelEmployee";
            this.btnCancelEmployee.Size = new System.Drawing.Size(94, 42);
            this.btnCancelEmployee.TabIndex = 9;
            this.btnCancelEmployee.Text = "Cancel";
            this.btnCancelEmployee.UseVisualStyleBackColor = true;
            this.btnCancelEmployee.Click += new System.EventHandler(this.btnCancelEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Enabled = false;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(799, 93);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(94, 42);
            this.btnDeleteEmployee.TabIndex = 8;
            this.btnDeleteEmployee.Text = "Delete";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnSaveEmployee
            // 
            this.btnSaveEmployee.Location = new System.Drawing.Point(799, 39);
            this.btnSaveEmployee.Name = "btnSaveEmployee";
            this.btnSaveEmployee.Size = new System.Drawing.Size(94, 42);
            this.btnSaveEmployee.TabIndex = 7;
            this.btnSaveEmployee.Text = "Save";
            this.btnSaveEmployee.UseVisualStyleBackColor = true;
            this.btnSaveEmployee.Click += new System.EventHandler(this.btnSaveEmployee_Click);
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(46, 256);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 29;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(937, 392);
            this.dgvEmployee.TabIndex = 12;
            this.dgvEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellClick);
            // 
            // tpTasks
            // 
            this.tpTasks.Controls.Add(this.cbAssignedEmployee);
            this.tpTasks.Controls.Add(this.dtpDeadline);
            this.tpTasks.Controls.Add(this.txtTaskSearch);
            this.tpTasks.Controls.Add(this.btnCancelTask);
            this.tpTasks.Controls.Add(this.btnDeleteTask);
            this.tpTasks.Controls.Add(this.btnSaveTask);
            this.tpTasks.Controls.Add(this.dgvTasks);
            this.tpTasks.Controls.Add(this.txtTaskCode);
            this.tpTasks.Controls.Add(this.label7);
            this.tpTasks.Controls.Add(this.label8);
            this.tpTasks.Controls.Add(this.label9);
            this.tpTasks.Controls.Add(this.label10);
            this.tpTasks.Controls.Add(this.txtProjectTitle);
            this.tpTasks.Location = new System.Drawing.Point(4, 34);
            this.tpTasks.Name = "tpTasks";
            this.tpTasks.Padding = new System.Windows.Forms.Padding(3);
            this.tpTasks.Size = new System.Drawing.Size(1021, 679);
            this.tpTasks.TabIndex = 1;
            this.tpTasks.Text = "Manage Tasks";
            this.tpTasks.UseVisualStyleBackColor = true;
            // 
            // cbAssignedEmployee
            // 
            this.cbAssignedEmployee.FormattingEnabled = true;
            this.cbAssignedEmployee.Location = new System.Drawing.Point(526, 94);
            this.cbAssignedEmployee.Name = "cbAssignedEmployee";
            this.cbAssignedEmployee.Size = new System.Drawing.Size(188, 33);
            this.cbAssignedEmployee.TabIndex = 103;
            // 
            // dtpDeadline
            // 
            this.dtpDeadline.Location = new System.Drawing.Point(526, 42);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Size = new System.Drawing.Size(188, 31);
            this.dtpDeadline.TabIndex = 102;
            // 
            // txtTaskSearch
            // 
            this.txtTaskSearch.Location = new System.Drawing.Point(75, 210);
            this.txtTaskSearch.Name = "txtTaskSearch";
            this.txtTaskSearch.PlaceholderText = "Type something to search...";
            this.txtTaskSearch.Size = new System.Drawing.Size(869, 31);
            this.txtTaskSearch.TabIndex = 107;
            this.txtTaskSearch.TextChanged += new System.EventHandler(this.txtTaskSearch_TextChanged);
            // 
            // btnCancelTask
            // 
            this.btnCancelTask.Location = new System.Drawing.Point(799, 146);
            this.btnCancelTask.Name = "btnCancelTask";
            this.btnCancelTask.Size = new System.Drawing.Size(94, 41);
            this.btnCancelTask.TabIndex = 106;
            this.btnCancelTask.Text = "Cancel";
            this.btnCancelTask.UseVisualStyleBackColor = true;
            this.btnCancelTask.Click += new System.EventHandler(this.btnCancelTask_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Enabled = false;
            this.btnDeleteTask.Location = new System.Drawing.Point(799, 93);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(94, 41);
            this.btnDeleteTask.TabIndex = 105;
            this.btnDeleteTask.Text = "Delete";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnSaveTask
            // 
            this.btnSaveTask.Location = new System.Drawing.Point(799, 39);
            this.btnSaveTask.Name = "btnSaveTask";
            this.btnSaveTask.Size = new System.Drawing.Size(94, 41);
            this.btnSaveTask.TabIndex = 104;
            this.btnSaveTask.Text = "Save";
            this.btnSaveTask.UseVisualStyleBackColor = true;
            this.btnSaveTask.Click += new System.EventHandler(this.btnSaveTask_Click);
            // 
            // dgvTasks
            // 
            this.dgvTasks.AllowUserToAddRows = false;
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Location = new System.Drawing.Point(46, 256);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.RowHeadersWidth = 51;
            this.dgvTasks.RowTemplate.Height = 29;
            this.dgvTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTasks.Size = new System.Drawing.Size(937, 392);
            this.dgvTasks.TabIndex = 200;
            this.dgvTasks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTasks_CellClick);
            // 
            // txtTaskCode
            // 
            this.txtTaskCode.Location = new System.Drawing.Point(177, 41);
            this.txtTaskCode.Name = "txtTaskCode";
            this.txtTaskCode.Size = new System.Drawing.Size(188, 31);
            this.txtTaskCode.TabIndex = 100;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Task Code:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Project Title:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(416, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Deadline:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(396, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "Assigned To:";
            // 
            // txtProjectTitle
            // 
            this.txtProjectTitle.Location = new System.Drawing.Point(177, 94);
            this.txtProjectTitle.Name = "txtProjectTitle";
            this.txtProjectTitle.Size = new System.Drawing.Size(188, 31);
            this.txtProjectTitle.TabIndex = 101;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Controls.Add(this.lblLastLogin);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.lblFullName);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(36, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 69);
            this.panel1.TabIndex = 215;
            // 
            // lblLastLogin
            // 
            this.lblLastLogin.AutoSize = true;
            this.lblLastLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLastLogin.Location = new System.Drawing.Point(521, 21);
            this.lblLastLogin.Name = "lblLastLogin";
            this.lblLastLogin.Size = new System.Drawing.Size(53, 28);
            this.lblLastLogin.TabIndex = 4;
            this.lblLastLogin.Text = "Date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(415, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 28);
            this.label13.TabIndex = 3;
            this.label13.Text = "Last login:";
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(850, 13);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(94, 46);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFullName.Location = new System.Drawing.Point(150, 21);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(64, 28);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(77, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 28);
            this.label11.TabIndex = 0;
            this.label11.Text = "Hello, ";
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 837);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbcManager);
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerForm";
            this.tbcManager.ResumeLayout(false);
            this.tpEmployees.ResumeLayout(false);
            this.tpEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.tpTasks.ResumeLayout(false);
            this.tpTasks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TabControl tbcManager;
        private System.Windows.Forms.TabPage tpEmployees;
        private System.Windows.Forms.TextBox txtEmployeeSearch;
        private System.Windows.Forms.Button btnCancelEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnSaveEmployee;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.TabPage tpTasks;
        private System.Windows.Forms.ComboBox cbAssignedEmployee;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
        private System.Windows.Forms.TextBox txtTaskSearch;
        private System.Windows.Forms.Button btnCancelTask;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnSaveTask;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.TextBox txtTaskCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtProjectTitle;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblLastLogin;
        private System.Windows.Forms.Label label13;
    }
}