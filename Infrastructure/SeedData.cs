using Microsoft.EntityFrameworkCore;
using RVACart.Models;

namespace RVACart.Infrastructure
{

    public class SeedData
    {
        public static void SeedDatabase(DataContext context)
        {
            context.Database.Migrate();

            if (!context.Articles.Any())
            {
                Category laptops = new Category { Name = "Laptops", Slug="Laptops"};
                Category mobilePhones= new Category { Name = "Mobile phones", Slug="Mobile phones" };

                context.Articles.AddRange(
                        new Article
                        {
                            Name = "Lenovo",
                            Slug = "Laptops",
                            Description = "ThinkPad 14",
                            Price = 1543.22,
                            Category = laptops,
                            CategoryId = 1
                        },
                        new Article
                        {
                            Name = "Dell",
                            Slug = "Laptops",
                            Description = "Vostro",
                            Price = 1323.43,
                            Category = laptops,
                            CategoryId = 1
                        },
                        new Article
                        {
                            Name = "HP",
                            Slug = "Laptops",
                            Description = "Probook",
                            Price = 1299.88,
                            Category = laptops,
                            CategoryId = 1
                        },
                        new Article
                        {
                            Name = "Macbook",
                            Slug = "Laptops",
                            Description = "Air m2",
                            Price = 1454.75,
                            Category = laptops,
                            CategoryId = 1
                        },
                        new Article
                        {
                            Name = "Xiaomi",
                            Slug = "Mobile phones",
                            Description = "Redmi Note",
                            Price = 688.99,
                            Category = mobilePhones,
                            CategoryId = 2
                        },
                        new Article
                        {
                            Name = "Samsung",
                            Slug = "Mobile phones", 
                            Description = "Z Fold 4",
                            Price = 975.12,
                            Category = mobilePhones,
                            CategoryId = 2
                        },
                        new Article
                        {
                            Name = "Iphone",
                            Slug = "Mobile phones",
                            Description = "se2022",
                            Price = 450.00,
                            Category = mobilePhones,
                            CategoryId = 2
                        },
                        new Article
                        {
                            Name = "Huawei",
                            Slug = "Mobile phones",
                            Description = "P50 Pro",
                            Price = 1000.23,
                            Category = mobilePhones,
                            CategoryId = 2
                        }
                );

                context.SaveChanges();
            }
        }
    }
}
