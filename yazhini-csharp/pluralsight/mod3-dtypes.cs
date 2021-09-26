using System;

namespace PieShop_NinjaCoders_Yazhini
{
    class Program
    {
        static void Main(string[] args)
        {

            /* int monthlyWage = 300;
             int months = 12;
             int bonus;

             double rating = 78.34;
             bool isActive = true;

             double ratePerHour = 12.34;
             int noHoursWorked = 123;

             double totalWage = ratePerHour * noHoursWorked;

             Console.WriteLine(totalWage);

             if (totalWage > 2000)
             {
                 Console.WriteLine("good employee");
             }
             else
             {
                 Console.WriteLine("work hard!!!");
             }

            char a = 'a';
            bool isWhitespace = char.IsWhiteSpace(a);
            bool isDigit = char.IsDigit(a);
            bool ispunctuation = char.IsPunctuation(a);

            Console.WriteLine(isWhitespace);
            Console.WriteLine(isDigit);
            Console.WriteLine(ispunctuation);*/

            DateTime currentDate = DateTime.Now;

            DateTime hiredDate = new DateTime(2021,12,23, 10,0,0);
            DateTime fullTimeEmployee = hiredDate.AddDays(10);




            Console.ReadLine();
        }
    }
}