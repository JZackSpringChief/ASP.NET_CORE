using Microsoft.EntityFrameworkCore;

namespace HPlusSport.API.Models;
public static class ModelBuilderExtentions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Active wear - size 4" },
            new Category { Id = 2, Name = "Active wear - size 3" },
            new Category { Id = 3, Name = "Mineral Water" },
            new Category { Id = 4, Name = "Publications" },
            new Category { Id = 5, Name = "Supplements" }
        );
        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, CategoryId = 1, Name = "red1" },
            new Product { Id = 2, CategoryId = 1, Name = "red2" },
            new Product { Id = 3, CategoryId = 1, Name = "red3" },
            new Product { Id = 4, CategoryId = 1, Name = "red4" },
            new Product { Id = 5, CategoryId = 1, Name = "red5" },
            new Product { Id = 6, CategoryId = 2, Name = "green1" },
            new Product { Id = 7, CategoryId = 2, Name = "green2" },
            new Product { Id = 8, CategoryId = 2, Name = "green3" },
            new Product { Id = 9, CategoryId = 2, Name = "green4" },
            new Product { Id = 10, CategoryId = 2, Name = "green5" },
            new Product { Id = 11, CategoryId = 3, Name = "blue" },
            new Product { Id = 12, CategoryId = 3, Name = "Purple" },
            new Product { Id = 13, CategoryId = 3, Name = "Yellow" },
            new Product { Id = 14, CategoryId = 3, Name = "Orange" },
            new Product { Id = 15, CategoryId = 3, Name = "White" },
            new Product { Id = 16, CategoryId = 3, Name = "Saffire" },
            new Product { Id = 17, CategoryId = 3, Name = "Diamond" },
            new Product { Id = 18, CategoryId = 3, Name = "Emerald" },
            new Product { Id = 19, CategoryId = 4, Name = "Z" },
            new Product { Id = 20, CategoryId = 4, Name = "A" },
            new Product { Id = 21, CategoryId = 4, Name = "C" },
            new Product { Id = 22, CategoryId = 4, Name = "K" },
            new Product { Id = 23, CategoryId = 4, Name = "S" },
            new Product { Id = 24, CategoryId = 4, Name = "P" },
            new Product { Id = 25, CategoryId = 4, Name = "R" },
            new Product { Id = 26, CategoryId = 4, Name = "I" },
            new Product { Id = 27, CategoryId = 5, Name = "Protein" },
            new Product { Id = 28, CategoryId = 5, Name = "Creatine" },
            new Product { Id = 29, CategoryId = 5, Name = "Gravol" },
            new Product { Id = 30, CategoryId = 5, Name = "Pepto" },
            new Product { Id = 31, CategoryId = 5, Name = "Bismol" },
            new Product { Id = 32, CategoryId = 5, Name = "Drugs" },
            new Product { Id = 33, CategoryId = 5, Name = "Pugs" }

        );
    }
}