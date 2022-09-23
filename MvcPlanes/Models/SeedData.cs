using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcPlane.Models;
using MvcPlanes.Data;
using System;
using System.Linq;

namespace MvcPlanes.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcPlanesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcPlanesContext>>()))
            {
                // Look for any movies.
                if (context.Plane.Any())
                {
                    return;   // DB has been seeded
                }

                context.Plane.AddRange(
                    new Plane
                    {
                        Name = "Flying Fortress",
                        Departure = DateTime.Parse("2004-11-7"),
                        Model = "B-17",
                        Price = 600M
                    },

                    new Plane
                    {
                        Name = "Stratoliner",
                        Departure = DateTime.Parse("1939-9-1"),
                        Model = "307",
                        Price = 257M
                    },

                    new Plane
                    {
                        Name = "Boeing",
                        Departure = DateTime.Parse("2022-10-31"),
                        Model = "737",
                        Price = 330M
                    },

                    new Plane
                    {
                        Name = "Stratocruiser",
                        Departure = DateTime.Parse("1914-8-27"),
                        Model = "377",
                        Price = 456M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
