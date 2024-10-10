using ExpenseTracker.Models;

namespace ExpenseTracker.Data
{
    public class CategorySeeder
    {
        public static async Task SeedCategoriesAsync(ApplicationDbContext context)
        {
            if (!context.Categories.Any())
            {
                var categories = new[]
                {
                    new Category { Name = "Groceries" },
                    new Category { Name = "Rent" },
                    new Category { Name = "Utilities" },
                    new Category { Name = "Transportation" },
                    new Category { Name = "Entertainment" }
                };

                await context.Categories.AddRangeAsync(categories);
                await context.SaveChangesAsync();
            }
        }
    }
}
