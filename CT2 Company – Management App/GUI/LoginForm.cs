using CT2_Company___Management_App.Business;
using CT2_Company___Management_App.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CT2_Company___Management_App.GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim().Length < 5 || txtPassword.Text.Trim().Length < 3)
            {
                lblMessage.Visible = true;
            }
            else 
            {
                Employee employee = EmployeeDA.Login(txtEmail.Text, txtPassword.Text);
                if (employee == null)
                {
                    lblMessage.Visible = true;
                }
                else if(employee.Position == "Manager")
                {
                    lblMessage.Visible = false;
                    this.Hide();
                    ManagerForm managerForm = new ManagerForm(employee);
                    managerForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    lblMessage.Visible = false;
                    this.Hide();
                    EmployeeForm employeeForm = new EmployeeForm(employee);
                    employeeForm.ShowDialog();
                    this.Close();
                }
            }
            ;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
        }
    }
}
