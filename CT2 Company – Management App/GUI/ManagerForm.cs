using CT2_Company___Management_App.Business;
using CT2_Company___Management_App.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CT2_Company___Management_App.GUI
{
    public partial class ManagerForm : Form
    {
        public ManagerForm(Employee employee)
        {
            InitializeComponent();

            lblFullName.Text = employee.FullName;
            lblLastLogin.Text = employee.LastLogin;
            employee.LastLogin = DateTime.Now.ToString();

            EmployeeDA.Edit(employee);

            RefreshData();

            cbPosition.Items.Add("Administrator");
            cbPosition.Items.Add("Branch Agent");
            cbPosition.Items.Add("Salesman");
            cbPosition.Items.Add("Technician");
            cbPosition.Items.Add("Manager");

        }

        private void RefreshData()
        {

            List<Employee> employees = new List<Employee>();
            employees = EmployeeDA.ReadAllEmployees();
            var employeesSource = new BindingSource();
            employeesSource.DataSource = employees;
            dgvEmployee.DataSource = employeesSource;
            dgvEmployee.Columns["Password"].Visible = false;

            List<Task> tasks = new List<Task>();
            tasks = TaskAssignmentDA.ReadAllTasks();
            var tasksSource = new BindingSource();
            tasksSource.DataSource = tasks;
            dgvTasks.DataSource = tasksSource;

            cbAssignedEmployee.Items.Clear();
            foreach (Employee emp in EmployeeDA.ReadAllEmployees())
            {
                cbAssignedEmployee.Items.Add(emp);
            }
        }

        private void ResetForm(string tabName)
        {
            btnDeleteEmployee.Enabled = false;
            btnDeleteTask.Enabled = false;
            foreach (TabPage tp in tbcManager.TabPages)
            {
                if (tp.Name == tabName)
                {
                    foreach (TextBox tb in tp.Controls.OfType<TextBox>())
                    {
                        tb.Clear();
                        tb.Enabled = true;
                    }
                    foreach (DateTimePicker dtp in tp.Controls.OfType<DateTimePicker>())
                    {
                        dtp.Value = DateTime.Now;
                        dtp.Enabled = true;
                    }
                    foreach (ComboBox cb in tp.Controls.OfType<ComboBox>())
                    {
                        cb.SelectedIndex = -1;
                        cb.Enabled = true;
                    }
                }

            }
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDeleteEmployee.Enabled = true;
            txtEmployeeId.Enabled = false;
            txtEmployeeId.Text = dgvEmployee.CurrentRow.Cells["EmployeeId"].Value.ToString();
            txtFullName.Text = dgvEmployee.CurrentRow.Cells["FullName"].Value.ToString();
            cbPosition.Text = dgvEmployee.CurrentRow.Cells["Position"].Value.ToString();
            txtPhone.Text = dgvEmployee.CurrentRow.Cells["Phone"].Value.ToString();
            txtEmail.Text = dgvEmployee.CurrentRow.Cells["Email"].Value.ToString();
            txtPassword.Text = dgvEmployee.CurrentRow.Cells["Password"].Value.ToString();
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            EmployeeDA.Remove(txtEmployeeId.Text);
            ResetForm("tpEmployees");
            RefreshData();
        }

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(txtEmployeeId.Text, txtFullName.Text, cbPosition.Text, txtPhone.Text, txtEmail.Text, txtPassword.Text);

            if (!txtEmployeeId.Enabled)
            {
                EmployeeDA.Edit(employee);
            }
            else
            {
                EmployeeDA.Save(employee);
            }
            ResetForm("tpEmployees");
            RefreshData();
        }

        private void btnCancelEmployee_Click(object sender, EventArgs e)
        {
            ResetForm("tpEmployees");
            RefreshData();
        }

        private void txtEmployeeSearch_TextChanged(object sender, EventArgs e)
        {
            List<Employee> employees = new List<Employee>();
            employees = EmployeeDA.SearchEmployees(txtEmployeeSearch.Text);
            var employeesSource = new BindingSource();
            employeesSource.DataSource = employees;
            dgvEmployee.DataSource = employeesSource;
            dgvEmployee.Columns["Password"].Visible = false;
        }

        private void btnSaveTask_Click(object sender, EventArgs e)
        {
            Employee employee = EmployeeDA.ReadAllEmployees().Find(emp => cbAssignedEmployee.Text.Contains(emp.EmployeeId));
            Task task;
            if (employee == null)
                task = new Task(txtTaskCode.Text,txtProjectTitle.Text,dtpDeadline.Value);
            else
                task = new Task(txtTaskCode.Text, txtProjectTitle.Text, dtpDeadline.Value, cbAssignedEmployee.Text.Trim().Length == 0 ? false : true, employee.EmployeeId);

            if (!txtTaskCode.Enabled)
            {
                TaskAssignmentDA.Edit(task);
            }
            else
            {
                TaskAssignmentDA.Save(task);
            }
            ResetForm("tpTasks");
            RefreshData();
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            TaskAssignmentDA.Remove(txtTaskCode.Text);
            ResetForm("tpTasks");
            RefreshData();
        }

        private void btnCancelTask_Click(object sender, EventArgs e)
        {
            ResetForm("tpTasks");
            RefreshData();
        }

        private void dgvTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTaskCode.Enabled = false;
            btnDeleteTask.Enabled = true;

            txtTaskCode.Text = dgvTasks.CurrentRow.Cells["TaskCode"].Value.ToString();
            txtProjectTitle.Text = dgvTasks.CurrentRow.Cells["ProjectTitle"].Value.ToString();
            dtpDeadline.Value = Convert.ToDateTime(dgvTasks.CurrentRow.Cells["Deadline"].Value);

            if (Convert.ToBoolean(dgvTasks.CurrentRow.Cells["IsAssigned"].Value))
            {
                Employee emp = EmployeeDA.ReadAllEmployees().Find(emp => emp.EmployeeId == dgvTasks.CurrentRow.Cells["EmployeeId"].Value.ToString());
                cbAssignedEmployee.Text = emp.FullName + " (ID: " + emp.EmployeeId + " )";
            }
            else
                cbAssignedEmployee.SelectedIndex = -1;

            cbAssignedEmployee.Enabled = dtpDeadline.Value >= DateTime.Now ? true : false;
        }

        private void txtTaskSearch_TextChanged(object sender, EventArgs e)
        {
            List<Task> tasks = new List<Task>();
            tasks = TaskAssignmentDA.SearchTasks(txtTaskSearch.Text);
            var tasksSource = new BindingSource();
            tasksSource.DataSource = tasks;
            dgvTasks.DataSource = tasksSource;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
