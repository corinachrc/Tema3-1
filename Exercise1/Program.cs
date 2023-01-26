using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MAGAZINES
            Magazine magazine1=new Magazine();
            magazine1.ArticleNumber = "fr34";
            magazine1.Title = "Planetele";
            magazine1.PageNumber= 1;

            Magazine magazine2 = new Magazine();
            magazine2.ArticleNumber = "ah53";
            magazine2.Title = "Isoscel";
            magazine2.PageNumber = 1;
            magazine2.MagazineNumber = 5;

            Magazine magazine3= new Magazine("kdg","Tabu",5,"February",4);

            Magazine magazine4 = new Magazine("5gd6", "Atlas", 10, "March", 1);


            //BOOKS
            Book book1 = new Book();
            book1.ArticleNumber = "gd5s";
            book1.Author = "Tudor Arghezi";
            book1.Title= "Aaaaaaa";
            book1.PageNumber = 34;
            book1.Year = 2021;
            book1.CoverType = "necartonat";
                        
            Book book2 = new Book();
            book2.ArticleNumber = "ljd7";
            book2.Author = "Mihai Eminescu";
            book2.Title = "Bbbbbbbbb";
            book2.PageNumber = 23;
            book2.PublishingHouse = "Didactica";
            book1.Year = 1999;
            book1.CoverType = "cartonat";

            Book book3 = new Book();
            book3.ArticleNumber = "85g3";
            book3.Author = "Milhail Sadoveanu";
            book3.Title = "Cccccccc";
            book3.PageNumber = 78;
            book3.PublishingHouse = "Edu";
            book3.Year = 2002;
            book3.CoverType = "necartonat";

            Book book4 = new Book(book3);

            //LIBRARIES
            Library library1=new Library();
            library1.Name = "Biblioteca Judeteana";
            library1._schedule.Add("Luni-Vineri", "9-15");
            library1._schedule.Add("Sambata-Duminica", "Inchis");
            library1.AddToLibrary(magazine1);
            library1.AddToLibrary(book1);
            library1.AddToLibrary(magazine3);
            library1.AddToLibrary(magazine4);
            library1.AddToLibrary(book3);

            Library library2=new Library();
            library2.Name = "Biblioteca Universitara";
            library2._schedule.Add("Luni-Vineri", "9-20");
            library2._schedule.Add("Sambata", "9-13");
            library2._schedule.Add("Duminica", "Inchis");
            library2.AddToLibrary(magazine2);
            library2.AddToLibrary(book2);
            library2.AddToLibrary(magazine3);
            library2.AddToLibrary(magazine4);
            library2.AddToLibrary(book3);
            library2.AddToLibrary(book4);


            Console.WriteLine("===========================");
            book4.DisplayDetails();
            Console.WriteLine("===========================");
            Console.WriteLine();


            Console.WriteLine("===========================");
            List<Article> listaArticole=library1.GetAllArticles();
            Console.WriteLine("Articole in " + library1.Name);
            foreach(Article article in listaArticole)
            {
                Console.WriteLine(article.Title);
            }
            Console.WriteLine("===========================");
            Console.WriteLine();

            Console.WriteLine("===========================");
            library2.DisplaySchedule();
            Console.WriteLine("===========================");
            Console.WriteLine();

            Console.WriteLine("===========================");
            List<string> listaAutori = Book.GetAllAuthors();
            Console.WriteLine("Autori: ");
            foreach(string author in listaAutori)
            {
                Console.WriteLine(author);
            }
            Console.WriteLine("===========================");
            Console.WriteLine();

            Console.WriteLine("===========================");
            library1.DisplayAllBooks();
            Console.WriteLine("===========================");
            Console.WriteLine();

            Console.WriteLine("===========================");
            library2.DisplayAlMagazine();
            Console.WriteLine("===========================");
            Console.WriteLine();
        }
    }
}
