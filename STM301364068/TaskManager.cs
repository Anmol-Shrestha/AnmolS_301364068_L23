using System;
using System.Collections.Generic;

namespace STM301364068
{
    public class TaskManager
    {
        private List<Task> tasks;

        public List<Task> Tasks
        {
            get;
        }
       
        public string AllTaskToString()
        {
            var formatTasks = string.Join("\n", Tasks);
            return formatTasks;
        }

        public Task CreateTask(string description)
        {
            Task newTask = new Task();
            tasks.Add(newTask);
            return newTask ;
        }
        
    }
}