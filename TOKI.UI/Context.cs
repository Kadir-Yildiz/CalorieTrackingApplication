using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOKI.UI
{
    public class Context : DbContext
    {
        public DbSet<Food> Foods { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<FoodCategory> FoodCategories { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<MealType> MealTypes { get; set; }
    }
}
