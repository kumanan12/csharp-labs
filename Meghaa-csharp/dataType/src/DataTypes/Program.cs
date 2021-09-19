using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Signed integral types:");

            Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
            Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

            Console.WriteLine("");

            Console.WriteLine("Unsigned integral types:");

            Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
            Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
            Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
            Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

            Console.WriteLine("");
            Console.WriteLine("Floating point types:");
            Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
            Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
            Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

            Console.WriteLine("");
            Console.WriteLine("Reference types: arrays,strings,classes");

            int[] data = new int[3] {9,6,8};
            Console.WriteLine(data[0]);

            Console.WriteLine("");
            Console.WriteLine("adding int and string: ");
            int first = 2;
            string second = "4";
            string Result = first + second;
            Console.WriteLine(Result);

            Console.WriteLine("");
            Console.WriteLine("narrow conversion: ");
            decimal myDecimal = 1.23456789m;
            float myFloat = (float)myDecimal;

            Console.WriteLine($"Decimal: {myDecimal}");
            Console.WriteLine($"Float: {myFloat}");
        
            Console.WriteLine("");
            Console.WriteLine(" using the ToString() method to explicitly convert int values into strings: ");
            int First = 5;
            int Second = 7;
            string message = First.ToString() + Second.ToString();
            Console.WriteLine(message);

            Console.WriteLine("");
            Console.WriteLine("use the Parse() method to convert two strings into int values: ");
            string firsT = "5";
            string seconD = "7";
            int sum = int.Parse(firsT) + int.Parse(seconD);
            Console.WriteLine(sum);         

            Console.WriteLine("");
            Console.WriteLine("to compare casting and converting a decimal into an int: ");
            int value = (int)1.5m; // casting truncates
            Console.WriteLine(value);

            int value2 = Convert.ToInt32(1.5m); // converting rounds up
            Console.WriteLine(value2);

            Console.WriteLine("");
            Console.WriteLine("TryParse() a string into an int: ");
            string Value = "102";
            int result = 0;
            if (int.TryParse(Value, out result))
            {
                Console.WriteLine($"Measurement: {result}");
            }
            else
            {
                Console.WriteLine("Unable to report the measurement.");
            }
            
            //first challenge
            Console.WriteLine("");
            string[] values = { "12.3", "45", "ABC", "11", "DEF" };

            decimal total = 0m;
            string Message = "";

            foreach (var vaLue in values)
            {
                decimal number;
                if (decimal.TryParse(vaLue, out number))
                {
                    total += number;
                } else
                {
                    Message += vaLue;
                }
            }

            Console.WriteLine($"Message: {Message}");
            Console.WriteLine($"Total: {total}");
        }

        /* Console.WriteLine("");
        string[] pallets = { "B14", "A11", "B12", "A13" };
        Console.WriteLine("Sorted...");
        Array.Sort(pallets);
        foreach(var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

        Console.WriteLine("");
        Console.WriteLine("Reversed...");
        Array.Reverse(pallets);
        foreach(var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }
        Console.WriteLine("");

        Array.Clear(pallets, 0, 2);
        Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
        foreach(var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

        Console.WriteLine("");
        Array.Resize(ref pallets, 6);
        Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

        pallets[4] = "C01";
        pallets[5] = "C02";

        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }*/
        
        string parantheses = "Find what is (inside the parentheses)";

        int openingPosition = parantheses.IndexOf('(');
        int closingPosition = parantheses.IndexOf(')');
        int length = closingPosition - openingPosition;
        Console.WriteLine(parantheses.Substring(openingPosition , length));

    }
}
