using System.Text;
using System.Reflection;
using System.Reflection.Metadata;
using System.Threading.Tasks.Dataflow;
using System;
using Xunit;

namespace GradeBook.Tests
{
    public class  TypeTests
    {
       [Fact]
       public void Test1()
       {
           var x = GetInt();
           SetInt(out x);

           Assert.Equal(42,x);
       }

       private void SetInt(out int x)
       {
           x = 42;
       }

       private int GetInt()
       {
           return 3;
       }   

        [Fact]
        public void CsharpCanPassByRef()
        {
           var book1 = GetBook("Book 1");
           GetBookSetName(ref book1,"New Name");
            
           Assert.Equal("New Name",book1.Name);
        }

        private void GetBookSetName(ref Book book,string name)
        {
            book = new Book(name);
        }
        
        [Fact]
        public void CsharpIsPassByValue()
        {
           var book1 = GetBook("Book 1");
           GetBookSetName(book1,"New Name");
            
           Assert.Equal("Book 1",book1.Name);
        }

        private void GetBookSetName(Book book,string name)
        {
            book = new Book(name);
        }
        
        [Fact]
        public void CanSetNameFromReference()
        {
           var book1 = GetBook("Book 1");
           SetName(book1,"New Name");
            
            Assert.Equal("New Name",book1.Name);
            
        }

        private void SetName(Book book,string name)
        {
            book.Name = name;
        }
        
        [Fact]
        public void StringCanBehaveLikeValueTypes()
        {
            string name = "Meghaa";
            var upper = MakeUpperCase(name);

            Assert.Equal("Meghaa",name);
            Assert.Equal("MEGHAA",upper);
        }
        
        private string MakeUpperCase(string parameter)
        {
           return parameter.ToUpper();
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
           var book1 = GetBook("Book 1");
           var book2 = GetBook("Book 2");
            
            Assert.Equal("Book 1",book1.Name);
            Assert.Equal("Book 2",book2.Name);
            Assert.NotSame(book1,book2);
        }

         [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
           var book1 = GetBook("Book 1");
           var book2 = book1;
            
            Assert.Same(book1,book2);
            Assert.True(Object.ReferenceEquals(book1,book2));
            
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
