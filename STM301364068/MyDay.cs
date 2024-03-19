using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace STM301364068
{
    public class MyDay
    {
        //private
        private static MyDay currentDay;
        private DateTime date;
        private List<Task> todaysTasks = new List<Task>();
        
        //properties
        public List<Task> TodaysTasks
        {
            get { return todaysTasks; }
        }
        
        //Methods
        public void AddDayTask(Task task)
        {
            todaysTasks.Add(task);
        }

        private MyDay()
        {
            date = DateTime.Today;
            todaysTasks = new List<Task>();
        }

        public static MyDay NewDay()
        {
            if (currentDay == null)
            {
                currentDay = new MyDay();
            }

            return currentDay;

        }

        public override string ToString()
        {
            var tasktoday = string.Join("\n", TodaysTasks);
            return $"{tasktoday}";
        }
    }
}