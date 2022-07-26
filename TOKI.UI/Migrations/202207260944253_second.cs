namespace TOKI.UI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.FoodCategories", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FoodCategories", "Name", c => c.Int(nullable: false));
        }
    }
}
