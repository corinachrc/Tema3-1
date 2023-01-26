using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Library
    {
        List<Article> articles= new List<Article>();
        public IDictionary<string, string> _schedule = new Dictionary<string, string>();
        
        //PROPERTIES
        public string Name { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public int EmployeeNumber { get; set; }


        //CONSTRUCTORS
        public Library() { }



        //METHODS
        public void AddToLibrary(Article article)
        {
           
            articles.Add(article);
            
        }
        
        public List<Article> GetAllArticles()
        {
            
            return articles;
        }
        public void DisplaySchedule()
        {
            Console.WriteLine(Name);
            Console.WriteLine("Program: ");
            foreach(KeyValuePair<string, string> sch in _schedule)
            {
                Console.WriteLine(sch.Key + ": "+sch.Value);
            }
        }
        public void DisplayAllBooks()
        {
            Console.WriteLine("Library " + Name + " > Carti");
            foreach (Article artc in articles)
            {               
                if (artc.GetType() == typeof(Book))
                Console.WriteLine(artc.Title);
            }
        }
        public void DisplayAlMagazine()
        {
            Console.WriteLine("Library " + Name + " > Reviste");
            foreach (Article artc in articles)
            {
                if (artc.GetType() == typeof(Magazine))
                    Console.WriteLine(artc.Title);
            }
        }
    }
}
