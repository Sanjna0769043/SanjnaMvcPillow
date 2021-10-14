using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SanjnaMvcPillow.Data;
using System;
using System.Linq;

namespace SanjnaMvcPillow.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SanjnaMvcPillowContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SanjnaMvcPillowContext>>()))
            {
                // Look for any Pillows.
                if (context.Pillow.Any())
                {
                    return;   // DB has been seeded
                }

                context.Pillow.AddRange(                    // autometic added ten enteries to db 
                    new Pillow
                    {
                        ProductName = "Parachute Down Pillow",
                        Material = "Cotton",
                        size = "XL",
                        Color = "Green",
                        Price = 700,
                        Rating = "A"
                    },

                     new Pillow
                     {
                         ProductName = "Brooklinen Down Pillow",
                         Material = "Silk",
                         size = "XLL",
                         Color = "Pink",
                         Price = 300,
                         Rating = "N"
                     },

                    new Pillow
                    {
                        ProductName = "Simba Pillow",
                        Material = "Cotton",
                        size = "XL",
                        Color = "Green",
                        Price = 450,
                        Rating = "R"
                    },

                     new Pillow
                     {
                         ProductName = "Le’vista Pillows",
                         Material = "Cotton",
                         size = "XL",
                         Color = "Green",
                         Price = 660,
                         Rating = "B"
                     },
                      new Pillow
                      {
                          ProductName = "Best down-alternative pillow",
                          Material = "Cotton",
                          size = "XL",
                          Color = "Green",
                          Price = 660,
                          Rating = "E"
                      },
                    new Pillow
                     {
                       ProductName = "down pillow twofer",
                       Material = "Cotton",
                       size = "XL",
                       Color = "Green",
                       Price = 700,
                       Rating = "W"
                     },

                     new Pillow
                     {
                         ProductName = "Parachute down pillow",
                         Material = "Silk",
                         size = "XLL",
                         Color = "Pink",
                         Price = 300,
                         Rating = "G"
                     },

                    new Pillow
                    {
                        ProductName = "Helix Down and Feather Pillow",
                        Material = "fiber",
                        size = "XL",
                        Color = "Green",
                        Price = 450
                    },

                     new Pillow
                     {
                         ProductName = "Kassatex European White Goose",
                         Material = "Cotton",
                         size = "M",
                         Color = "white",
                         Price = 660
                     },
                      new Pillow
                      {
                          ProductName = "Pacific Coast",
                          Material = "Cotton",
                          size = "S",
                          Color = "Gray",
                          Price = 660
                      }
                );
                context.SaveChanges();
            }
        }
    }
}