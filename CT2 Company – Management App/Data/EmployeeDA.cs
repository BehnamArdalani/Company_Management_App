using CT2_Company___Management_App.Business;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT2_Company___Management_App.Data
{
    public static class EmployeeDA
    {
        private static string txtEmployeeFilePath = @"../../../Data/Employees.dat";

        static private void SaveEmployees(List<Employee> employees)
        {
            using (StreamWriter writer = File.CreateText(txtEmployeeFilePath))
            {
                foreach (Employee employee in employees)
                {
                    writer.WriteLine(employee.EmployeeId + "|" + employee.FullName + "|" + employee.Position + "|" + employee.Phone + "|" + employee.Email + "|" + employee.Password + "|" + employee.LastLogin);
                }
            }
        }


        static private List<Employee> ReadEmployees()
        {
            StreamReader reader = new StreamReader(txtEmployeeFilePath);
            List<Employee> employees = new List<Employee>();

            string line = null;
            while ((line = reader.ReadLine()) != null)
            {
                string[] variables = line.Split('|');
                employees.Add(new Employee(variables[0], variables[1], variables[2], variables[3], variables[4], variables[5], variables[6]));
            }
            reader.Close();

            return employees;
        }

        static public List<Employee> ReadAllEmployees()
        {
            return ReadEmployees();
        }

        static public Employee Login(string email,string password)
        {
            List<Employee> employees = ReadEmployees();
            foreach (Employee employee in employees)
            {
                if (email.Trim().ToLower() == employee.Email.Trim().ToLower() && password.Trim() == employee.Password.Trim())
                {
                    return employee;
                }
            }
            return null;
        }

        static public void Remove(string employeeId)
        {
            List<Employee> employees = ReadEmployees();
            foreach (Employee employee in employees)
            {
                if (employee.EmployeeId == employeeId)
                {
                    employees.Remove(employee);
                    TaskAssignmentDA.ReleaseTask(employee.EmployeeId);
                    break;
                }
            }

            SaveEmployees(employees);
        }
        static public void Save(Employee employee)
        {
            List<Employee> employees = ReadEmployees();
            employees.Add(employee);
            SaveEmployees(employees);
        }

        static public void Edit(Employee employee)
        {
            List<Employee> employees = ReadEmployees();
            foreach (Employee emp in employees)
            {
                if (emp.EmployeeId == employee.EmployeeId)
                {
                    emp.FullName = employee.FullName;
                    emp.Position = employee.Position;
                    emp.Phone = employee.Phone;
                    emp.Email = employee.Email;
                    emp.Password = employee.Password;
                    emp.LastLogin = employee.LastLogin;
                    
                    break;
                }
            }

            SaveEmployees(employees);
        }

        static public List<Employee> SearchEmployees(string search)
        {
            return ReadEmployees().FindAll(emp => emp.FullName.ToLower().Contains(search.ToLower()) || emp.Position.ToLower().Contains(search.ToLower()) || emp.Email.ToLower().Contains(search.ToLower()) || emp.Phone.ToLower().Contains(search.ToLower()));
        }
    }
}
