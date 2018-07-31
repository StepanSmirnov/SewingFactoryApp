namespace SawingFactory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Forimport : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Materials", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Materials", "Name", c => c.String(nullable: false));
        }
    }
}
