using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT2_Company___Management_App.Business
{
    public class Task
    {
        public Task(string taskCode, string projectTitle, DateTime deadline)
        {
            TaskCode = taskCode;
            ProjectTitle = projectTitle;
            Deadline = deadline;
            IsAssigned = false;
            EmployeeId = "";
        }
        public Task(string taskCode, string projectTitle, DateTime deadline, bool isAssigned, string employeeId)
        {
            TaskCode = taskCode;
            ProjectTitle = projectTitle;
            Deadline = deadline;
            IsAssigned = isAssigned;
            EmployeeId = employeeId;
        }

        public string TaskCode { get; set; }
        public string ProjectTitle { get; set; }
        public DateTime Deadline { get; set; }
        public bool IsAssigned { get; set; }

        public string EmployeeId { get; set; }

    }
}
