using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk7Ex1
{
    class Book //create book class
    {
        //declarations
        public string Title; 
        public string Author;
        public string Genre;
        public double Price;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book> //create a new list to store books
            {
            new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", Genre = "Fiction", Price = 15.99 },
            new Book { Title = "1984", Author = "George Orwell", Genre = "Dystopian", Price = 12.99 },
            new Book { Title = "Pride and Prejudice", Author = "Jane Austen", Genre = "Romance", Price = 9.99 },
            new Book { Title = "Moby Dick", Author = "Herman Melville", Genre = "Adventure", Price = 18.99 },
            new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Genre = "Fiction", Price = 10.99 },
            new Book { Title = "Brave New World", Author = "Aldous Huxley", Genre = "Dystopian", Price = 14.99 },
            new Book { Title = "War and Peace", Author = "Leo Tolstoy", Genre = "Historical Fiction", Price = 25.99 }
            };

            var expensiveBooks = books.Where(b => b.Price > 12); //use linq to find books that cost more that 12
            Console.WriteLine("Books that cost more than $12:"); //print
            foreach (var book in expensiveBooks)                 //loop to print each book and the price
            {
                Console.WriteLine($"{book.Title} - ${book.Price}"); //print title and price
            }

            Console.WriteLine(); //blank line for readability

            var orderedBooks = books.OrderBy(b => b.Price); //linq to order books by price
            Console.WriteLine("Books ordered by price (ascending):"); //print 
            foreach (var book in orderedBooks) //loop to print each book and price
            {
                Console.WriteLine($"{book.Title} - ${book.Price}"); //print title and price
            }

            Console.WriteLine(); //blank for readability

            var groupedBooks = books.GroupBy(b => b.Genre); //linq to group book by genre
            Console.WriteLine("Books grouped by genre:"); //print
            foreach (var group in groupedBooks) //loop to print books in each genre
            {
                Console.WriteLine($"Genre: {group.Key}"); //group by genre
                foreach (var book in group) //loop to print out each book
                {
                    Console.WriteLine($"   {book.Title}"); //print out title
                }
            }

            Console.WriteLine(); //blank for readability

            var titleAuthor = books.Select(b => new { b.Title, b.Author }); //linq to select only the title and authors
            Console.WriteLine("Titles and Authors:"); //print
            foreach (var book in titleAuthor) //loop to print out books
            {
                Console.WriteLine($"{book.Title} by {book.Author}"); //print out book title and author
            }
        }
    }
}
