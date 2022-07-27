namespace TOKI.UI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class four : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AppUsers", "Password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AppUsers", "Password");
        }
    }
}
