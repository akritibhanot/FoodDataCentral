using Microsoft.EntityFrameworkCore;

namespace FoodDataCentral.Models
{
    public class FoodDataCentralApplicationDbContext : DbContext
    {
        public FoodDataCentralApplicationDbContext(DbContextOptions<FoodDataCentralApplicationDbContext> options) :
            base(options)
        {
        }
        
        public DbSet<Food> Foods { get; set; }
        public DbSet<FoodNutrient> FoodNutrients { get; set; }
        
    }
}