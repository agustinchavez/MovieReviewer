using MovieReviewer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieReviewer
{
    public static class GlobalVariables
    {
        public static List<Movie> Movies { get; set; } = new List<Movie>();
    }
}