using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string id;
            Library library = new Library();

            Book b1 = new Book("A Reminiscence of Dr.Samuel Johnson", "Howard", "Phillips", "Lovecraft", "1917", "1", 10, "Fantasy novel");
            Book b2 = new Book("Of Mice and Men", "John", "", "Steinbeck", "1937", "2", 187, "Novel");
            Book b3 = new Book("Captain Blood: His Odyssey", "Rafael", "", "Sabatini", "1922", "3", 236, "Adventure novel");
            Book b4 = new Book("A Christmas Carol", "Charles", "", "Dickens", "1843", "4", 110, "Novel");
            Book b5 = new Book("The Last of the Mohicans", "James", "Fenimore", "Cooper", "1826", "5", 364, "Historical novel");

            library.AddBook(b1);
            library.AddBook(b2);
            library.AddBook(b3);
            library.AddBook(b4);
            library.AddBook(b5);

            library.Get_Info();
            Console.Write("Input Book Id : ");
            id = Console.ReadLine();
            library.FindBookById(id);
            string id1 = "1", id2 = "4";
            Console.WriteLine("Comparison of books №1 and №4 in library");
            library.Compare(id1, id2);

            Console.ReadKey();
        }
    }
}
