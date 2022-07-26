namespace TOKI.UI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class third : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reports", "FoodCal", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reports", "FoodCal");
        }
    }
}
