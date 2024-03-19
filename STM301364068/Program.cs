using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.IO;
using System.Runtime.InteropServices;

//Student ID: 301364068
//Student Name: Anmol Sagar Shrestha
namespace STM301364068
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // 1. Create 2 courses and output them to the console.
            Course course = new Course(1, "COMP123");
            Course course2 = new Course(2, "COMP125");
            
            Console.WriteLine(course);
            Console.WriteLine(course2);
            // 2. Add 2 assignments, quiz, and test to the first course.
            course.AddEvaluation(EvaluationType.Assignment, 20, "A1");
            course.AddEvaluation(EvaluationType.Assignment, 20, "A2");
            course.AddEvaluation(EvaluationType.Quiz, 20, "Q2");
            course.AddEvaluation(EvaluationType.Test,40 , "T1");
            // 3. Add 3 assignments, and test to the second course.
            course2.AddEvaluation(EvaluationType.Assignment, 15, "A1");
            course2.AddEvaluation(EvaluationType.Assignment, 15, "A2");
            course2.AddEvaluation(EvaluationType.Assignment, 15, "A1");
            course2.AddEvaluation(EvaluationType.Test, 55, "T1");

            // 4. Output both courses to the console
            Console.WriteLine(course);
            Console.WriteLine(course2);

            // 5. Set Due date for the first assignment of the first course.
            course.Evaluations[0].DueDate = Convert.ToDateTime("2024-02-02");
            
            // 6. Set grade for the first evaluation of the first course.
            course.Evaluations[0].Grade = 55;
            // 7. Set grade for the second evaluation of the first course.
            course.Evaluations[1].Grade = 100;
            // 8. Output the first course to the console.
            Console.WriteLine(course);
            // 9. Add the task to the first course.
            course.AddTask("Read Chapter 2 - Not done");
         

            // 10. Set a due date for created task.
           
            // 11. Add another task to the first course.
            course.AddTask("Read Chapter 3 - Not done");
            // 12. Output the tasks for the course.
            Console.WriteLine("---------------------Tasks For Course-----------------------");
            Console.WriteLine(course.TasksToString());
            // 13. Add a new task to the second evaluation of the first course.
            course.Evaluations[1].AddTask("Start Assignment - Not done");
            course.Evaluations[1].AddTask("Write Main() Method - Not done");

            // 14. Output the tasks for the second evaluation of the first course!!
            Console.WriteLine("-------------------------------------------------------\n " +
                              "Tasks: Second Evaluation of the First Course" +
                              "\n------------------------------------------------------- ");
            Console.WriteLine(course.Evaluations[1].TasksToString());
            
            // 15. Create new MyDay.
            Console.WriteLine("---------------MyDay--------------------");
            MyDay m1 = MyDay.NewDay();
            // 16. Mark one of the tasks done.
            var mydayTask = course.Tasks[0];
            mydayTask.Done = true;
            // 17. Add any two tasks you created to the day.
            m1.AddDayTask(mydayTask);
            m1.AddDayTask(course.Evaluations[1].Tasks[1]);

            // 18. Output tasks in MyDay. 
            Console.WriteLine(m1);
        }
    }
}