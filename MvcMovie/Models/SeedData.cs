using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                     new Movie
                     {
                         Title = "The RM ",
                         Rating = "PG" ,
                         ReleaseDate = DateTime.Parse("2003-1-31"),
                         Genre = "Romantic Comedy",
                         Price = 7.99M ,
                       
                     },

                     new Movie
                     {
                         Title = "Singles Ward ",
                         Rating = "PG-13" ,
                         ReleaseDate = DateTime.Parse("1992-9-18"),
                         Genre = "Comedy",
                         Price = 8.99M 
                        

                     },

                     new Movie
                     {
                         Title = "Other Side of Heaven ",
                         Rating = "PG" ,
                         ReleaseDate = DateTime.Parse("2002-4-12"),
                         Genre = "Adventure",
                         Price = 9.99M 
                         
                     },

                   new Movie
                   {                                  
                       Title = "Saints and Soldiers" ,
                       Rating = "PG-13",
                       ReleaseDate = DateTime.Parse("2005-3-25"),
                       Genre = "Action",
                       Price = 3.99M 
                       
                   }
                );
                context.SaveChanges();
            }
        }
    }
}

