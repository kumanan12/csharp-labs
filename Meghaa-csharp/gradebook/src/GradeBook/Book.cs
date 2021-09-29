using System.Globalization;
using System;
using System.Collections.Generic;
namespace GradeBook
{
    public class Book
    {
    public Book(string name)
        {
            grades[index] = new List<double>();
            Name = name;
        }
        
        public void AddGrade(double grades[index])
        {
            if (grades[index] <= 100 && grades[index] >= 0)
            {
                grades[index].Add(grades[index]);
            }
            else
            {
                Console.WriteLine("Invalid Value!");
            }
            
        }

        public Statistics GetStats()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue; 
            
            for(var index = 0;index<grades.Count;index+=1)
            {
               result.Low = Math.Min(grades[index], result.Low);
               result.High = Math.Max(grades[index], result.High);
               result.Average += grades[index];
            } 
           result.Average /= grades.Count; 
           
           return result;
        } 

       private List<double> grades[index];
       public string Name;
    }
}