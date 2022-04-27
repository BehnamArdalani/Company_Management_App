using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT2_Company___Management_App.Business
{
    public class TaskAssignment
    {
        public TaskAssignment(string employeeId, string taskCode)
        {
            EmployeeId = employeeId;
            TaskCode = taskCode;
        }

        private string EmployeeId { get; set; }
        private string TaskCode { get; set; }
    }
}
