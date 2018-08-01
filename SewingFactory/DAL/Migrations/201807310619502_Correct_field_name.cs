namespace SawingFactory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Correct_field_name : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Furnitures", "WidthUnit", c => c.String());
            AddColumn("dbo.Materials", "WidthUnit", c => c.String(nullable: false));
            AddColumn("dbo.Products", "WidthUnit", c => c.String(nullable: false));
            AddColumn("dbo.ProductsFurnitures", "WidthUnit", c => c.String());
            DropColumn("dbo.Furnitures", "WidhtUnit");
            DropColumn("dbo.Materials", "WidhtUnit");
            DropColumn("dbo.Products", "WidhtUnit");
            DropColumn("dbo.ProductsFurnitures", "WidhtUnit");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductsFurnitures", "WidhtUnit", c => c.String());
            AddColumn("dbo.Products", "WidhtUnit", c => c.String(nullable: false));
            AddColumn("dbo.Materials", "WidhtUnit", c => c.String(nullable: false));
            AddColumn("dbo.Furnitures", "WidhtUnit", c => c.String());
            DropColumn("dbo.ProductsFurnitures", "WidthUnit");
            DropColumn("dbo.Products", "WidthUnit");
            DropColumn("dbo.Materials", "WidthUnit");
            DropColumn("dbo.Furnitures", "WidthUnit");
        }
    }
}
