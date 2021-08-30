using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcPelis.Data;
using System;
using System.Linq;

namespace MvcPelis.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcPelisContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcPelisContext>>()))
            {
                // Look for any movies.
                if (context.Pelicula.Any())
                {
                    return;   // DB has been seeded
                }

                context.Pelicula.AddRange(
                    new Pelicula
                    {
                        Titulo = "When Harry Met Sally",
                        FechaLanzamiento = DateTime.Parse("1989-2-12"),
                        Genero = "Romantic Comedy",
                        Precio = 7.99M
                    },

                    new Pelicula
                    {
                        Titulo = "Ghostbusters ",
                        FechaLanzamiento = DateTime.Parse("1984-3-13"),
                        Genero = "Comedy",
                        Precio = 8.99M
                    },

                    new Pelicula
                    {
                        Titulo = "Ghostbusters 2",
                        FechaLanzamiento = DateTime.Parse("1986-2-23"),
                        Genero = "Comedy",
                        Precio = 9.99M
                    },

                    new Pelicula
                    {
                        Titulo = "Rio Bravo",
                        FechaLanzamiento = DateTime.Parse("1959-4-15"),
                        Genero = "Western",
                        Precio = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
