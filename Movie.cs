using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    class Movie
    {
        public string title;
        public string director;
        private double rating;
        public Movie(string atitle, string adirector, double arating)
        {
            title = atitle;
            director = adirector;
            Rating = arating;
        }
        public double Rating
        {
            get
            {
               //rating = Convert.ToDouble(rating);
                return rating;
            }
            set
            {
                if(value>1 || value < 10)
                {
                   rating= value;
                }
                else
                {
                    rating = 0;
                }
            }

        }

        public void print()
        {
            Console.WriteLine(rating);
        }
    }
}
