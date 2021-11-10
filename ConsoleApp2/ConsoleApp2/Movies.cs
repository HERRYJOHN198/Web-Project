using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Movies
    {
        public string title;
        public string director;
        private string rating;

        public Movies(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            rating = aRating;
        }
        public string Rating
        {
            get { return Rating; }
            set { 
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else 
                {
                    rating = "NR";
                }
            }
        }
    }
}
