using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Task2
{
    public class Book
    {
        string author_first_name;
        string author_middle_name;
        string author_last_name;
        string book_name;
        string id;
        string date;
        int pages;
        string genre;
        public Book()
        { }
        public Book(string book_name, string author_first_name, string author_middle_name, string author_last_name, string date, string id, int pages, string genre)
        {
            this.author_first_name = author_first_name;
            this.author_middle_name = author_middle_name;
            this.author_last_name = author_last_name;
            this.book_name = book_name;
            this.id = id;
            this.date = date;
            this.pages = pages;
            this.genre = genre;
        }
        public string GetId
        {
            get
            {
                return id;
            }
        }

        public int GetPages
        {
            get
            {
                return pages;
            }
        }

        public string GetBookName
        {
            get
            {
                return book_name;
            }
        }
        public override string ToString()
        {
            string info;
            info = "Book Name : " + book_name + "\nAuthor : " + author_first_name + " " + author_middle_name + " " + author_last_name + "\nYear Of Publication : " + date + "\nGenre : " + genre + "\nNumber Of Pages : " + pages + "\n";
            return info;
        }
    }
}
