using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ClassicCar.Data;

namespace ClassicCar.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CarDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CarDbContext>>()))
            {
                // Look for any CARS.
                if (context.Car.Any())
                {
                    return;   // DB has been seeded
                }

                context.Car.AddRange(
                    new Car
                    {
                        Model = "Ford Mustang",
                        Color = "White",
                        Transmission = "Automatic",
                        AdDate = DateTime.Parse("1989-2-12"),
                        Fuel = "Gas",
                        Price = 49.99M,
                        Rating = "4"
                        
                    },

                    new Car
                    {
                        Model = "Ford RS200",
                        Color = "White",
                        Transmission = "Automatic",
                        AdDate = DateTime.Parse("1989-2-12"),
                        Fuel = "Gas",
                        Price = 400.99M,
                        Rating = "3"
                    },

                    new Car
                    {
                        Model = "Pontiac Ventura",
                        Color = "Champagne",
                        Transmission = "Automatic",
                        AdDate = DateTime.Parse("1989-2-12"),
                        Fuel = "Gas",
                        Price = 47.99M,
                        Rating = "2"
                    },

                    new Car
                    {
                        Model = "Porsche 911T",
                        Color = "Red",
                        Transmission = "Automatic",
                        AdDate = DateTime.Parse("1972-2-12"),
                        Fuel = "Gas",
                        Price = 139.99M,
                        Rating = "4"
                    },
                     new Car
                     {
                         Model = "Porsche 911 Targa",
                         Color = "White",
                         Transmission = "Manual",
                         AdDate = DateTime.Parse("1980-2-12"),
                         Fuel = "Gas",
                         Price = 44.99M,
                         Rating = "5"
                     },
                      new Car
                      {
                          Model = "Ford Mustang",
                          Color = "Red",
                          Transmission = "Manual",
                          AdDate = DateTime.Parse("1967-2-12"),
                          Fuel = "Gas",
                          Price = 129.99M,
                          Rating = "3"

                      },
                       new Car
                       {
                           Model = "Ford Woody Wagon",
                           Color = "Black/Wood",
                           Transmission = "Automatic",
                           AdDate = DateTime.Parse("1989-2-12"),
                           Fuel = "Gas",
                           Price = 113.99M,
                           Rating = "2"
                       },
                        new Car
                        {
                            Model = "Dodge D100",
                            Color = "White",
                            Transmission = "Manual",
                            AdDate = DateTime.Parse("1989-2-12"),
                            Fuel = "Gas",
                            Price = 18.99M,
                            Rating = "5"
                        },
                         new Car
                         {
                             Model = "Chevrolet Bel Air",
                             Color = "Black",
                             Transmission = "Manual",
                             AdDate = DateTime.Parse("1989-2-12"),
                             Fuel = "Gas",
                             Price = 100.99M,
                             Rating = "3"
                         },
                          new Car
                          {
                              Model = "Oldsmobile",
                              Color = "Blue",
                              Transmission = "Automatic",
                              AdDate = DateTime.Parse("1989-2-12"),
                              Fuel = "Gas",
                              Price = 109.99M,
                              Rating = "4"
                          }
                );
                context.SaveChanges();
            }
        }
    }
}