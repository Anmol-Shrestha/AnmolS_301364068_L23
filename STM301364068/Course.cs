using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace STM301364068
{
    public class Course
    {
        //Fields
        private string code;
        private List<Evaluation> evaluations = new List<Evaluation>();
        private uint id;
        private string name;
        private byte semester;
        private List<Task> tasks = new List<Task>();
        
        //Properties
        public string Code
        {
            get { return code;}
            set { code = value; }
        }

        public List<Evaluation> Evaluations
        {
            get
            {
                return evaluations;
            }
        }

        public ushort Grade
        {
            get
            {
                if (evaluations == null)
                {
                    return 0;
                }
                double sum=0;
                foreach (Evaluation evaluation in evaluations)
                {
                    sum += evaluation.Weight * evaluation.Grade;
                }
                return (ushort)sum ;
            }
        }
        public uint Id { get;  }
        public string Name { get; set; }
        public byte Semester { get; set; }

        public List<Task> Tasks
        {
            get { return tasks; }
        }

       
        
        //Methods
        public void AddEvaluation(EvaluationType type, byte weight, string name)
        {
            
            Course courseobject = new Course(Id, Code);
            Evaluation e1 = new Evaluation(courseobject, type, weight);
            evaluations.Add(e1);
        }

        public Task AddTask(string description)
        {
            Task newtask = new Task(description);
            Tasks.Add(newtask);
            return newtask;
        }

        //Constructor
        public Course(uint id, string code)
        {
            Id = id;
            Code = code;
        }

        public string TasksToString()
        {
            var courseTask = string.Join("\n", Tasks);
            return $"{courseTask}";
        }

        public override string ToString()
        {
            var cEvaluations = Evaluations != null ? string.Join("\n", Evaluations) : "No evaluations";
            
            return $"---------------------------------------------------------- \n " +
                   $"{Code}\nEvaluations:\n" +
                   $"{cEvaluations} \n" +
                   $"Total Grade:{Grade} \n" +
                   $"---------------------------------------------------------";
        }
    }
}