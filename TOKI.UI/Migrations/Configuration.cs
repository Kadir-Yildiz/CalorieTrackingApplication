﻿namespace TOKI.UI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TOKI.UI.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TOKI.UI.Context context)
        {

            context.MealTypes.Add(new MealType { Name="Breakfast"});
            context.MealTypes.Add(new MealType { Name="Lunch"});
            context.MealTypes.Add(new MealType { Name="Snack"});
            context.MealTypes.Add(new MealType { Name="Dinner"});


            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
