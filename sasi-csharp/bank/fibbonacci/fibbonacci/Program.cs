using System;

namespace fibbonacci
{
    class Program
    {
        public static void Main(string[] args)
        {
            int no = 0, f1 = -1, f2 = 1, f3 = 0;

            Console.WriteLine("Enter the Number of elements:");
            no = int.Parse(Console.ReadLine());
            Console.WriteLine("The fibbonacci series is:");
            for(int i=0;i<no;i++)
            {
                f3 = f1 + f2;
                f1 = f2;
                f2 = f3;
                Console.WriteLine(f3);
            }
        }
    }
}