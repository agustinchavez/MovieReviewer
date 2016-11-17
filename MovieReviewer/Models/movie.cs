using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieReviewer.Models
{
    public class Movie
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Review> Reviews { get; set; }

        public static void Create(Movie movie)
        {
            GlobalVariables.Movies.Add(movie);
        }

        public static List<Movie> ReadAll()
        {
            return GlobalVariables.Movies;
        }

        public static Movie Read(string name)
        {
            foreach (var movie in GlobalVariables.Movies)
            {
                if (movie.Name == name)
                    return movie;
            }
            return null;
        }

        public void AddReviewToMovie(Review review)
        {
            Reviews.Add(review);
        }
    }
}