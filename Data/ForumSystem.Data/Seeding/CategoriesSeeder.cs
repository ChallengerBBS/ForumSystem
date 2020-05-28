namespace ForumSystem.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using ForumSystem.Data.Models;
    using Microsoft.EntityFrameworkCore.Internal;

    public class CategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (!dbContext.Categories.Any())
            {
                var categories = new List<string> { "Sport", "Coronavirus", "News", "Music", "Cats" };

                foreach (var category in categories)
                {
                    await dbContext.Categories.AddRangeAsync(new Category
                    {
                        Name = category,
                        Description = category,
                        Title = category,
                    });
                }
            }
        }
    }
}
