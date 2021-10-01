using System.Threading.Tasks.Dataflow;
using System;
using System.Collections.Generic;
namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
           var book = new Book("Schott's Grade Book");
           
           while (true)
           {
                Console.WriteLine("Enter a GRADE or 'q' to quit: ");
                var input = Console.ReadLine();

                if(input == "q")
                {
                    break;
                }

                try
                {
                    var grade =  double.Parse(input);
                    book.AddGrade(grade); 
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }
           }

           var stats = book.GetStats();

           Console.WriteLine($"The lowest grade is {stats.Low}");
           Console.WriteLine($"The highest grade is {stats.High}");
           Console.WriteLine($"The average grade is {stats.Average:N1}");
           Console.WriteLine($"The letter Grade is {stats.Letter}");
        }
    }
}
