using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public delegate bool FindStudent(Student std);

   
    internal class LinqDemo
    {

        Student[] studentArray = {
            new Student() { StudentID = 1, StudentName = "John", Age = 18 },
            new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 },
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 },
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 },
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 },
            new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 },
            new Student() { StudentID = 7, StudentName = "Rob",Age = 19  },
        };

        //FindStudent find => student => student.Age > 12 && student.Age < 20;
        FindStudent find = ISStudentWithInRange;


        public static bool ISStudentWithInRange(Student student)
        {
            return student.Age > 12 && student.Age < 20;
        }
        public List<Student> FindStudentsWhoAreAbove12AndLessThan20()
        {
            List<Student> students = new List<Student>();
            foreach (var std in studentArray)
            {
                if (std.Age > 12 && std.Age < 20)
                {
                    students.Add(std);
                }
            }

            return students;
        }

        public List<Student> SimpleFind()
        {
            var students = StudentExtension.Where(studentArray, find);
            return students;
            
        }




    }
}
