using System;

namespace gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new double[] {10,20,30,40};
            double result=0;
            foreach(double numbers in array)
            {
                result+=numbers;
            }
            Console.WriteLine($"Result :{result}");
        }
    };
}
