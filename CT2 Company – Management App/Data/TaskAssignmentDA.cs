using CT2_Company___Management_App.Business;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CT2_Company___Management_App.Data
{
    public static class TaskAssignmentDA
    {
        private static string txtTaskFilePath = @"../../../Data/Tasks.dat";

        static private void SaveTasks(List<Task> tasks)
        {
            using (StreamWriter writer = File.CreateText(txtTaskFilePath))
            {
                foreach (Task task in tasks)
                {
                    writer.WriteLine(task.TaskCode + "|" + task.ProjectTitle + "|" + task.Deadline + "|" + task.IsAssigned + "|" + task.EmployeeId);
                }
            }
        }


        static private List<Task> ReadTasks()
        {
            StreamReader reader = new StreamReader(txtTaskFilePath);

            List<Task> tasks = new List<Task>();

            string line = null;
            while ((line = reader.ReadLine()) != null)
            {
                string[] variables = line.Split('|');
                tasks.Add(new Task(variables[0], variables[1], Convert.ToDateTime(variables[2]), Convert.ToBoolean(variables[3]),variables[4]));
            }
            reader.Close();

            return tasks;
        }
        static public List<Task> ReadAllTasks()
        {
            return ReadTasks();
        }

        static public bool AssignTask(string employeeId, string taskCode)
        {
            bool result = false;
            List<Task> tasks = ReadTasks();
            foreach(Task task in tasks)
            {
                if(task.TaskCode == taskCode && task.IsAssigned == false)
                {
                    task.IsAssigned = true;
                    task.EmployeeId = employeeId;
                    result = true;
                }
            }
            SaveTasks(tasks);
            return result;
        }

        static public void ReleaseTask(string employeeId)
        {
            List<Task> tasks = ReadTasks();
            foreach (Task task in tasks)
            {
                if (task.EmployeeId == employeeId)
                {
                    task.IsAssigned = false;
                    task.EmployeeId = "";
                }
            }
            SaveTasks(tasks);
        }
        public static void Remove(string taskCode)
        {
            List<Task> tasks = ReadAllTasks();
            tasks.Remove(tasks.Find(tsk => tsk.TaskCode == taskCode));
            SaveTasks(tasks);
        }

        public static void Edit(Task task)
        {
            List<Task> tasks = ReadAllTasks();
            foreach(Task tsk in tasks)
            {
                if(tsk.TaskCode == task.TaskCode)
                {
                    tsk.ProjectTitle = task.ProjectTitle;
                    tsk.Deadline = task.Deadline;
                    tsk.EmployeeId = task.EmployeeId;
                    tsk.IsAssigned = task.IsAssigned;
                }
            }
            SaveTasks(tasks);
        }

        public static void Save(Task task)
        {
            List<Task> tasks = ReadAllTasks();
            tasks.Add(task);
            SaveTasks(tasks);
        }

        static public List<Task> SearchTasks(string search)
        {
            return ReadTasks().FindAll(tsk => tsk.ProjectTitle.ToLower().Contains(search.ToLower()) || tsk.Deadline.ToString().ToLower().Contains(search.ToLower()));
        }
    }
}
