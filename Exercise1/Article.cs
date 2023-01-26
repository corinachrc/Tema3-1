using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Article
    {
        
        public string _libraryName;
        private string _articleNumber;
        List<Article> articles = new List<Article>();
        //PROPERTIES
        public string ArticleNumber {
            get {
                return _articleNumber; 
            }
            set {
                _articleNumber= value[0].ToString().ToUpper() + value.Substring(1); ; 
            }
        }
        public string Title { get; set; }
        public int PageNumber { get; set; }
        public bool IsAvailable { get; set; }

        //CONSTRUCTORS   
        public Article() { IsAvailable = true; }

        //METHODS
        public void DisplayDetails()
        {
            Console.WriteLine("Detalii carte/revista: ");
            Console.WriteLine("Article number: "+ArticleNumber);
            Console.WriteLine("Title:"+Title);
            Console.WriteLine("Number of pages: "+PageNumber);
            


        }
        
        

        
        
    }
}
