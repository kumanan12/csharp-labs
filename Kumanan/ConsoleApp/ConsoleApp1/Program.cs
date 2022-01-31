using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
//using FinanceLib;
//using Math = FinanceLib.Math;
using HB.DataAccess;
using System.Security.Cryptography;
using System.Text;
using System.Collections;

namespace ConsoleApp

{
    public class Person
    {
        public Person(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
    class Program
    {
        FindStudent filter => student => student.Age > 12 && student.Age < 20;
        static Dictionary<int, Student> studentDictionary = new Dictionary<int, Student>();
        static List<Student> students = new List<Student>
{
    new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores= new List<int> {97, 92, 81, 60}},
    new Student {First="Claire", Last="O'Donnell", ID=112, Scores= new List<int> {75, 84, 91, 39}},
    new Student {First="Sven", Last="Mortensen", ID=113, Scores= new List<int> {88, 94, 65, 91}},
    new Student {First="Cesar", Last="Garcia", ID=114, Scores= new List<int> {97, 89, 85, 82}},
    new Student {First="Debra", Last="Garcia", ID=115, Scores= new List<int> {35, 72, 91, 70}},
    new Student {First="Fadi", Last="Fakhouri", ID=116, Scores= new List<int> {99, 86, 90, 94}},
    new Student {First="Cesar", Last="Feng", ID=117, Scores= new List<int> {93, 92, 80, 87}},
    new Student {First="Hugo", Last="Garcia", ID=118, Scores= new List<int> {92, 90, 83, 78}},
    new Student {First="Lance", Last="Tucker", ID=119, Scores= new List<int> {68, 79, 88, 92}},
    new Student {First="Terry", Last="Adams", ID=120, Scores= new List<int> {99, 82, 81, 79}},
    new Student {First="Eugene", Last="Zabokritski", ID=121, Scores= new List<int> {96, 85, 91, 60}},
    new Student {First="Michael", Last="Tucker", ID=122, Scores= new List<int> {94, 92, 91, 91}}
};

        static void Main2(string[] args)
        {
            var cities = new Hashtable(){
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };

          
            var input = Console.ReadLine();
            string source = "Hello World";
            using (SHA256 sha256Hash = SHA256.Create())
            {
                string hash = GetHash(sha256Hash, source);


                Console.WriteLine($"The SHA256 hash of {source} is: {hash}.");

                Console.WriteLine("Verifying the hash...");

                if (VerifyHash(sha256Hash, input, hash))
                {
                    Console.WriteLine("The hashes are the same.");
                }
                else
                {
                    Console.WriteLine("The hashes are not same.");
                }
            }
        }

        private static string GetHash(HashAlgorithm hashAlgorithm, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            var sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        private static bool VerifyHash(HashAlgorithm hashAlgorithm, string input, string hash)
        {
            // Hash the input.
            var hashOfInput = GetHash(hashAlgorithm, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            return comparer.Compare(hashOfInput, hash) == 0;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("hello");
            var linqDemo = new LinqDemo();
            // var students = linqDemo.FindStudentsWhoAreAbove12AndLessThan20();
            var students = linqDemo.SimpleFind();
            Console.WriteLine($"The length of students is {students.Count}");
        }
        static void Main3(string[] args)
        {

            var s1 = new Student { First = "Svetlana", Last = "Omelchenko", ID = 111, Scores = new List<int> { 97, 92, 81, 60 } };
            var s2 = new Student { First = "Claire", Last = "O'Donnell", ID = 112, Scores = new List<int> { 75, 84, 91, 39 } };
            var s3 = new Student { First = "Sven", Last = "Mortensen", ID = 113, Scores = new List<int> { 88, 94, 65, 91 } };

            studentDictionary.Add(111, s1);
            studentDictionary.Add(112, s2);
            studentDictionary.Add(113, s3);


            Console.WriteLine(studentDictionary.ContainsKey(117));
            //for (int i = 0; i < students.Count; i++)
            //{
            //    var student = students[i];

            //    if (student.First == "Cesar")
            //    {
            //        Console.WriteLine("Match found");
            //        Console.WriteLine(student.First);

            //        // LINQ 
            //    }

            //}
            // students.ForEach(student =>
            var matchingStudents = students.Any(y => (y.First == "Cesar") || (y.Last == "Adams"));

            //matchingStudents.ForEach(y => Console.WriteLine(y.First));
            //tertiary operator

            // Console.WriteLine(student1?.First);
            //Console.WriteLine((student1 == null)? "Not found" : student1.First);
            Console.WriteLine("Done");

        }


    }


}



