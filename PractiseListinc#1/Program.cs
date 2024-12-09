using System;
using System.Collections.Generic;

namespace Coding.Exercise
{
    public class TaskManager
    {
        private List<string> tasks = new List<string>();

        public void AddTask(string task)
        {
            if (!string.IsNullOrEmpty(task))
            {
                tasks.Add(task);
                Console.WriteLine($"Task '{task}' added.");
            }
            else
            {
                Console.WriteLine("Invalid task. Task cannot be empty.");
            }
        }


        public void RemoveTask(string task)
        {
            if (tasks.Contains(task))
            {
                tasks.Remove(task);
                Console.WriteLine($"Task '{task}' removed.");
            }
            else
            {
                Console.WriteLine($"Task '{task}' not found.");
            }
        }

        public List<string> GetTasks()
        {
            return tasks;
        }
    }
}
