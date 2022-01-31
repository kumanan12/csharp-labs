using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public  class StudentExtension
    {
        public static List<Student> Where(Student[] stdArray, FindStudent del)
        {
            List<Student> result = new List<Student>();
            foreach (Student std in stdArray)
                if (del(std))
                {
                    result.Add(std);
                }

            return result;
        }
    }
}
