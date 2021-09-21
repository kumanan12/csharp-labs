using System.Collections.Generic;
namespace book
{
    class book
    {
        public book()
        {
              grades =new List<double>();
        }
        public void Addgrade(double grade)
        {
             grades.Add(grade);   
        }
        List<double> grades;
    }
    
}