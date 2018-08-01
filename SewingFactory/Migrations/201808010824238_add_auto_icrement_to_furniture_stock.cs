namespace SawingFactory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_auto_icrement_to_furniture_stock : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.FurnitureStocks");
            AlterColumn("dbo.FurnitureStocks", "Party", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.FurnitureStocks", new[] { "Party", "FurnitureId" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.FurnitureStocks");
            AlterColumn("dbo.FurnitureStocks", "Party", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.FurnitureStocks", new[] { "Party", "FurnitureId" });
        }
    }
}
