using System;
using System.Collections.Generic;
namespace book
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new book();

            var grades = new List<double>() {50.93,61.74,80.54 };
            
            book.Addgrade(70.04);
            var result = 0.0;
            foreach(var number in grades)
            {
               result += number; 
            }
            result /= grades.Count;
            Console.WriteLine($"The Average grade is {result:N3}");
        }
    }
}
