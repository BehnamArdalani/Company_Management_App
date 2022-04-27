using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT2_Company___Management_App.Business
{
    public class Employee:Person
    {
        public Employee(string fullName):base(fullName) { }

        public Employee(string employeeId, string fullName, string position, string phone, string email, string password) : base(fullName)
        {
            EmployeeId = employeeId;
            Position = position;
            Phone = phone;
            Email = email;
            Password = password;
            LastLogin = "First login!";
        }

        public Employee(string employeeId, string fullName, string position, string phone, string email, string password, string lastLogin):base(fullName)
        {
            EmployeeId = employeeId;
            Position = position;
            Phone = phone;
            Email = email;
            Password = password;
            LastLogin = lastLogin.Trim().Length == 0 ? "First login!" : lastLogin;
        }

        public string EmployeeId { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string LastLogin { get; set; }

        public override string ToString()
        {
            return FullName + " (ID: " + EmployeeId + " )";
        }
    }
}
