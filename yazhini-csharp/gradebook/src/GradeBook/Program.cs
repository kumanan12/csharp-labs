using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 12.1;
            var y = 10.1;
            var result = x+y;
            Console.WriteLine(result);

            var number = new double[3];
            number[0] = 10;
            number[1] = 12;
            number[2] = 10;
            var result1 = number[0] + number[1] + number[2];
            Console.WriteLine(result1) 
            // if(args.Length > 0)
            // {
            //     Console.WriteLine($"Hello {args[0]}!");
            // } 
            // else{
            //     Console.WriteLine("Hello!");
            // }

            
        }
    }
}
