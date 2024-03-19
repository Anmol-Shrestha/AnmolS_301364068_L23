using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace STM301364068
{

    public class Evaluation
    {
        //Fields
        private Course course;
        private DateTime dueDate;
        private byte grade;
        private Guid id;
        private string name;
        private List<Task> tasks = new List<Task>();
        private string textFile;
        private EvaluationType type;
        private byte weight;
        
        //Properties
        public Course Course
        {
            get { return course; }
        }
        public DateTime DueDate
        {
            get { return dueDate;}
            set { dueDate = value; }
        }

        public byte Grade
        {
            get { return grade; } 
            set { grade = value; }
        }
        public Guid Id { get { return id; } }

        public string Name
        {
            get { return name; } 
            set { name = value; }
        }

        public List<Task> Tasks
        {
            get { return tasks; }
        }

        public string TextFile
        {
            get { return textFile; } 
            set { textFile = value; }
        }
        public EvaluationType Type { 
            get { return type; } 
            set { type = value ; } }
        public byte Weight { 
            get { return weight; } 
            set { weight = value; }
            
        }
        
        //Methods
        public Task AddTask(string description)
        {
            Task newtask = new Task(description);
            Tasks.Add(newtask);
            return newtask;
        }

        public Evaluation(Course course, EvaluationType type, byte weight)
        {
            this.course = course;
            Type = type;
            Weight = weight;
        }

        public string TasksToString()
        {
            var evaluationTask = string.Join("\n", Tasks);
            return $"{evaluationTask}";
        }

        public override string ToString()
        {
            var fDuedate = DueDate != null ? $"{DueDate}" : "no due date";
            return $" {Type} : {Weight}% : {fDuedate} : {Grade} ";
        }
    }
   
}