using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Magazine:Article
    {
        //FIELDS
        public string _edition;
        public int _frequency;
        public int _magazineNumber;

        //PROPERTIES
        public int MagazineNumber
        {
            get
            {
                if (_magazineNumber == 0) { return 1; }
                else { return _magazineNumber; }
                ;
            }
            set
            {
                _magazineNumber = value;
            }
        }
        public string Edition { get; set; }

        //CONSTRUCTORS
        public Magazine(string articleNumber, string title, int numberOfPages, string edition, int frequency)
        {
            ArticleNumber = articleNumber;
            Title = title;
            PageNumber = numberOfPages;
            Edition = edition;
            _frequency = frequency;
            IsAvailable = true;
        }
        public Magazine()
        {

        }
        //METHODS
    }
}
