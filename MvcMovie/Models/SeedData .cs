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
                    Title = "Bahubali",
                    ReleaseDate = DateTime.Parse("2018-2-12"),
                    Genre = "Action",
                    Rating = "R",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Welcome 2 ",
                    ReleaseDate = DateTime.Parse("2012-3-13"),
                    Genre = "Comedy",
                    Rating = "R",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Mahabharat",
                    ReleaseDate = DateTime.Parse("2024-2-23"),
                    Genre = "Action",
                    Rating = "R",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Partner",
                    ReleaseDate = DateTime.Parse("2010-4-15"),
                    Genre = "Comedy",
                    Rating = "R",
                    Price = 3.99M
                }
            );
            context.SaveChanges();
        }
    }
}