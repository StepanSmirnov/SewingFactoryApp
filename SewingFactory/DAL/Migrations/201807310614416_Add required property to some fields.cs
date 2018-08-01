namespace SawingFactory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addrequiredpropertytosomefields : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", new[] { "Customer_Login", "Customer_Password" }, "dbo.Users");
            DropIndex("dbo.Orders", new[] { "Customer_Login", "Customer_Password" });
            AddColumn("dbo.Orders", "Price", c => c.Double());
            AlterColumn("dbo.Furnitures", "Width", c => c.Double());
            AlterColumn("dbo.Furnitures", "Length", c => c.Double());
            AlterColumn("dbo.Furnitures", "Weight", c => c.Double());
            AlterColumn("dbo.Materials", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Materials", "WidhtUnit", c => c.String(nullable: false));
            AlterColumn("dbo.Materials", "LengthUnit", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "WidhtUnit", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "LengthUnit", c => c.String(nullable: false));
            AlterColumn("dbo.Orders", "Stage", c => c.String(nullable: false));
            AlterColumn("dbo.Orders", "Customer_Login", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Orders", "Customer_Password", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Users", "Role", c => c.String(nullable: false));
            AlterColumn("dbo.ProductsFurnitures", "Placing", c => c.String(nullable: false));
            AlterColumn("dbo.ProductsFurnitures", "Width", c => c.Double());
            AlterColumn("dbo.ProductsFurnitures", "Length", c => c.Double());
            AlterColumn("dbo.ProductsFurnitures", "Rotation", c => c.Double());
            CreateIndex("dbo.Orders", new[] { "Customer_Login", "Customer_Password" });
            AddForeignKey("dbo.Orders", new[] { "Customer_Login", "Customer_Password" }, "dbo.Users", new[] { "Login", "Password" }, cascadeDelete: true);
            DropColumn("dbo.Orders", "Quantity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Quantity", c => c.Int(nullable: false));
            DropForeignKey("dbo.Orders", new[] { "Customer_Login", "Customer_Password" }, "dbo.Users");
            DropIndex("dbo.Orders", new[] { "Customer_Login", "Customer_Password" });
            AlterColumn("dbo.ProductsFurnitures", "Rotation", c => c.Double(nullable: false));
            AlterColumn("dbo.ProductsFurnitures", "Length", c => c.Double(nullable: false));
            AlterColumn("dbo.ProductsFurnitures", "Width", c => c.Double(nullable: false));
            AlterColumn("dbo.ProductsFurnitures", "Placing", c => c.String());
            AlterColumn("dbo.Users", "Role", c => c.String());
            AlterColumn("dbo.Orders", "Customer_Password", c => c.String(maxLength: 128));
            AlterColumn("dbo.Orders", "Customer_Login", c => c.String(maxLength: 128));
            AlterColumn("dbo.Orders", "Stage", c => c.String());
            AlterColumn("dbo.Products", "LengthUnit", c => c.String());
            AlterColumn("dbo.Products", "WidhtUnit", c => c.String());
            AlterColumn("dbo.Products", "Name", c => c.String());
            AlterColumn("dbo.Materials", "LengthUnit", c => c.String());
            AlterColumn("dbo.Materials", "WidhtUnit", c => c.String());
            AlterColumn("dbo.Materials", "Name", c => c.String());
            AlterColumn("dbo.Furnitures", "Weight", c => c.Double(nullable: false));
            AlterColumn("dbo.Furnitures", "Length", c => c.Double(nullable: false));
            AlterColumn("dbo.Furnitures", "Width", c => c.Double(nullable: false));
            DropColumn("dbo.Orders", "Price");
            CreateIndex("dbo.Orders", new[] { "Customer_Login", "Customer_Password" });
            AddForeignKey("dbo.Orders", new[] { "Customer_Login", "Customer_Password" }, "dbo.Users", new[] { "Login", "Password" });
        }
    }
}
