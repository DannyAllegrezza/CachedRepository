using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CachedRepository.Data.Models
{
    public class SeedData
    {
        internal static void Initialize(IServiceProvider services)
        {
            using (var context = new SqliteDbContext(services.GetRequiredService<DbContextOptions<SqliteDbContext>>()))
            {
                if (!context.Manufacturers.Any())
                {
                    context.Manufacturers.AddRange(
                        new VehicleManufacturer
                        {
                            Name = "Honda",
                            Description = "A Japanese car manufacturer.....",
                            Models = new List<VehicleModel>
                            {
                                new VehicleModel
                                {
                                    Name = "Civic"
                                },
                                new VehicleModel
                                {
                                    Name = "Accord"
                                }
                            }
                        },
                        new VehicleManufacturer
                        {
                            Name = "Nissan",
                            Description = "Nissan makes a variety of sport compact cars",
                            Models = new List<VehicleModel>
                            {
                                new VehicleModel
                                {
                                    Name = "240SX"
                                },
                                new VehicleModel
                                {
                                    Name = "300ZX"
                                }
                            }
                        },
                        new VehicleManufacturer
                        {
                            Name = "Toyota",
                            Description = "Toyota was formed a long, long time ago...",
                            Models = new List<VehicleModel>
                            {
                                new VehicleModel
                                {
                                    Name = "Supra"
                                },
                                new VehicleModel
                                {
                                    Name = "Celica"
                                }
                            }
                        }
                        );

                    context.SaveChanges();
                }
            }
        }
    }
}
