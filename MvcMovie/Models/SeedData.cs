using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "Home Teachers",
                    ReleaseDate = DateTime.Parse("2004-01-08"),
                    Genre = "Comedy",
                    Price = 4.99M,
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "The Cokeville Miracle",
                    ReleaseDate = DateTime.Parse("2015-06-04"),
                    Genre = "Drama",
                    Price = 9.99M,
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "Saints and Soldiers",
                    ReleaseDate = DateTime.Parse("2003-03-24"),
                    Genre = "Action",
                    Price = 9.99M,
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "Singles 2nd Ward",
                    ReleaseDate = DateTime.Parse("2007-12-10"),
                    Genre = "Romantic Comedy",
                    Price = 4.99M,
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "Meet the Mormons",
                    ReleaseDate = DateTime.Parse("2014-02-25"),
                    Genre = "Documentary",
                    Price = 4.99M,
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "Veggie Tales: Noah's Ark",
                    ReleaseDate = DateTime.Parse("2015-03-02"),
                    Genre = "Family",
                    Price = 9.99M,
                    Rating = "TV-Y7"
                }
            );
            context.SaveChanges();
        }
    }
}