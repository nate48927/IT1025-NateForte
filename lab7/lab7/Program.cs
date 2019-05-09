using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book();
            myBook.Title = "title";
            myBook.Author = "author";
            myBook.Display(myBook.Title, myBook.Author);

            BookTest myBookTest = new BookTest("title2","Author2");

        }
    }
    public class Book
    {
        public string Title;
        public string Author;
        public string Year;

        public void Display(string title, string author)
        {
        
            Console.WriteLine(title);
            Console.WriteLine(author);
            Console.ReadLine();

        }
        
    }
    public class BookTest
    {
        public BookTest() { }

        public BookTest(string title, string author)
        {
            Book myBookTest = new Book();
            myBookTest.Title = title;
            myBookTest.Author = author;
            myBookTest.Display(myBookTest.Title, myBookTest.Author);


        }

    }

}
