using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Task2
{
    public class Library
    {
        List<Book> book = new List<Book>();

        public Library()
        {

        }

        public void AddBook(Book b)
        {
            book.Add(b);
        }

        public void FindBookById(string id)
        {
            if (book.Count == 0)
            {
                Console.WriteLine("There are no books in library");
                return;
            }
            foreach (Book item in book)
            {
                if (item.GetId == id)
                {
                    Console.WriteLine(item);
                    return;
                }
            }
            Console.WriteLine("Book not found");
        }

        public void Compare(string id1, string id2)
        {
            bool compare1 = false;
            bool compare2 = false;
            for (int i = 0; i < book.Count; i++)
            {
                if (id1 == book[i].GetId)
                {
                    compare1 = true;
                }
                else if (id2 == book[i].GetId)
                {
                    compare2 = true;
                }
            }

            if (compare1 == false)
            {
                Console.WriteLine("No book in the library with id: " + id1);
                return;
            }
            else if (compare2 == false)
            {
                Console.WriteLine("No book in the library with id: " + id2);
                return;
            }

            Book itemOne = book[Convert.ToInt32(id1)];
            Book itemTwo = book[Convert.ToInt32(id2)];

            if (itemOne.GetPages > itemTwo.GetPages)
            {
                Console.WriteLine(itemOne.GetBookName + "Has more pages than " + itemTwo.GetBookName);
            }
            else if (itemOne.GetPages == itemTwo.GetPages)
            {
                Console.WriteLine("These books have the same number of pages");
            }
            else
            {
                Console.WriteLine(itemTwo.GetBookName + " Has more pages than " + itemOne.GetBookName);
            }
        }

        public void Get_Info()
        {
            foreach (Book item in book)
            {
                Console.WriteLine(item);
            }
        }
    }
}
