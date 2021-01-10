namespace RealEstate.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using RealEstate.Data.Models;

    public class EstateCategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.EstateCategories.Any())
            {
                return;
            }

            await dbContext.EstateCategories.AddAsync(new EstateCategory { Name = "Terraced" });
            await dbContext.EstateCategories.AddAsync(new EstateCategory { Name = "Semi-Detached" });
            await dbContext.EstateCategories.AddAsync(new EstateCategory { Name = "Detached" });
        }
    }
}
