using System;

namespace STM301364068
{
    public struct Task
    {
        public string Description;
        private bool done;
        public DateTime DueDate;
        
        //Properties
        public bool Done
        {
            get
            {
                return done;
            }
            set
            {
                done = value;
            }
        }

        //Methods
        public Task(string description) : this()
        {
            Description = description;
            DueDate = DateTime.MaxValue;
            Done = false;
            

        }

        public override string ToString()
        {
            var taskStatus = Done ? "Complete" : "Not Complete";
            return $" Task Description: {Description} \n Task Due Date: {DueDate} \n Task Status: {taskStatus}";
        }
    }
}