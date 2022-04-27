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
    public partial class EmployeeForm : Form
    {
        private List<Task> tasks;
        public EmployeeForm(Employee employee)
        {
            InitializeComponent();
            lblFullName.Text = employee.FullName;
            lblLastLogin.Text = employee.LastLogin;
            employee.LastLogin = DateTime.Now.ToString();

            EmployeeDA.Edit(employee);

            //List<Task> tasks = new List<Task>();
            tasks = TaskAssignmentDA.ReadAllTasks().FindAll(tsk => tsk.IsAssigned == true && tsk.EmployeeId == employee.EmployeeId);
            var tasksSource = new BindingSource();
            tasksSource.DataSource = tasks;
            dgvTasks.DataSource = tasksSource;
            dgvTasks.Columns["EmployeeId"].Visible = false;

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }

        private void txtTaskSearch_TextChanged(object sender, EventArgs e)
        {

            var tasksSource = new BindingSource();
            tasksSource.DataSource = tasks.FindAll(tsk => tsk.ProjectTitle.ToLower().Contains(txtTaskSearch.Text.ToLower()) || tsk.TaskCode.ToLower().Contains(txtTaskSearch.Text.ToLower()));
            dgvTasks.DataSource = tasksSource;
            dgvTasks.Columns["EmployeeId"].Visible = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTaskSearch.Text = "";
        }
    }
}
