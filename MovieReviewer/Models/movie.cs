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

        public double Rating
        {
            get
            {
                if (Reviews.Any())
                    return Reviews.Average(e => e.Rating);
                else
                    return 0;
            }
        }

        public List<Review> Reviews { get; set; } = new List<Review>();

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