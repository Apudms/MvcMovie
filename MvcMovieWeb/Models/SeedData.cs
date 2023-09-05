using Microsoft.EntityFrameworkCore;
using MvcMovieWeb.Data;

namespace MvcMovieWeb.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieWebContext(serviceProvider.GetRequiredService<DbContextOptions<MvcMovieWebContext>>()))
            {
                // Cari film apa saja.
                if (context.Movie.Any())
                {
                    return; // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The Friendship Game",
                        ReleaseDate = DateTime.Parse("2023-8-30"),
                        Genre = "Horror, Sci-Fi",
                        Rating = "R",
                        Price = 3.99M
                    },
                    new Movie
                    {
                        Title = "Satu Hari dengan Ibu",
                        ReleaseDate = DateTime.Parse("2023-9-21"),
                        Genre = "Drama, Family",
                        Rating = "R",
                        Price = 3.49M
                    },
                    new Movie
                    {
                        Title = "No Hard Feelings",
                        ReleaseDate = DateTime.Parse("2023-9-14"),
                        Genre = "Comedy, Romance",
                        Rating = "R",
                        Price = 4.49M
                    },
                    new Movie
                    {
                        Title = "The Nun II",
                        ReleaseDate = DateTime.Parse("2023-9-21"),
                        Genre = "Horror, Mystery",
                        Rating = "R",
                        Price = 4.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
