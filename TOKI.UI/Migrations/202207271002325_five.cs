namespace TOKI.UI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class five : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reports", "FullName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reports", "FullName");
        }
    }
}
