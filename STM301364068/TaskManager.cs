using System;
using System.Collections.Generic;

namespace STM301364068
{
    public static class TaskManager
    {
        private static List<Task> tasks;

        public static List<Task> Tasks
        {
            get;
        }
       
        public static string AllTaskToString()
        {
            var formatTasks = string.Join("\n", Tasks);
            return formatTasks;
        }

        public static Task CreateTask(string description)
        {
            Task newTask = new Task();
            tasks.Add(newTask);
            return newTask ;
        }
        
    }
}