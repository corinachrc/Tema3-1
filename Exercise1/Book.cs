using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Book:Article
    {
        private string _author;
        private static List<string> _authors=new List<string>();
        //PROPERTIES
        public string PublishingHouse { get; set; } = "Cora";
        public int Year { get; set; }
        public string CoverType { get; set; }
        public string Author
        {
            get
            { return _author; }

            set
            {
                _author= value;
                if (!_authors.Contains(_author))
                {
                    _authors.Add(_author);
                }
            }
        }

        //CONSTRUCTORS
        public Book() {}
        public Book(string articleNumber, string title, string author, string publishingHouse, int numberOfPages, int year, string coverType)
        {
            ArticleNumber = articleNumber;
            Title = title;
            Author = author;
            PublishingHouse = publishingHouse;
            PageNumber = numberOfPages;
            Year = year;
            CoverType = coverType;
            IsAvailable = true;
        }
        public Book(Book book)
        {
            ArticleNumber = book.ArticleNumber;
            Title = book.Title;
            Author = book.Author;
            PublishingHouse = book.PublishingHouse;
            PageNumber = book.PageNumber;
            Year = book.Year;
            CoverType = book.CoverType;
            IsAvailable = book.IsAvailable;
        }

        //METHODS
        public static List<string> GetAllAuthors()
        {
            return _authors;
        }
    }
}
