using System;
using System.Collections.Generic;
namespace GradeBook
{
    public class Book
    {
    public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public Statistics GetStats()
        {
            var result = new Statistics();
            result.Average = 0.0;
            var result.High = double.MinValue();
            var result.Low = double.MaxValue(); 
            
            foreach (var grade in grades)
           {
               result.Low = Math.Min(grade, result.Low);
               result.High = Math.Max(grade, result.High);
               result.Average += grade;
           }
           result.Average /= grades.Count; 
           
           return result;
        } 

       private List<double> grades;
       private string name;
    }
}