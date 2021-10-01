using System.Runtime.Intrinsics.X86;
using System.Reflection;
using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
           //arrange section
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            //act section
            var result = book.GetStats();
            
            //assert section
            Assert.Equal(85.6,result.Average,1);
            Assert.Equal(90.5,result.High,1);
            Assert.Equal(77.3,result.Low,1);
            Assert.Equal('B',result.Letter);
        }
    }
}
