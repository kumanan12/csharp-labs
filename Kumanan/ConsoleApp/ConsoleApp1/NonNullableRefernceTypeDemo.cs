using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class NonNullableRefernceTypeDemo
    {
        public void PrintText(string? name)
        {
            if (string.IsNullOrEmpty(name))
            {
                // log to the logging system.
                throw new ApplicationException("name cannot be null");
            }
            var newString = name ?? "Value IS NULL";
            Console.WriteLine(newString.ToLower()); ;
        }


    }
}
