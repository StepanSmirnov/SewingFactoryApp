namespace SawingFactory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Furnitures",
                c => new
                    {
                        FurnitureId = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Type = c.String(),
                        Width = c.Double(nullable: false),
                        WidthUnit = c.String(),
                        Length = c.Double(nullable: false),
                        LengthUnit = c.String(),
                        Weight = c.Double(nullable: false),
                        WeightUnit = c.String(),
                        Image = c.Binary(),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.FurnitureId);
            
            CreateTable(
                "dbo.FurnitureStocks",
                c => new
                    {
                        Party = c.Int(nullable: false),
                        FurnitureId = c.String(nullable: false, maxLength: 128),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Party, t.FurnitureId })
                .ForeignKey("dbo.Furnitures", t => t.FurnitureId, cascadeDelete: true)
                .Index(t => t.FurnitureId);
            
            CreateTable(
                "dbo.Materials",
                c => new
                    {
                        MaterialId = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Color = c.String(),
                        Pattern = c.String(),
                        Image = c.Binary(),
                        Consist = c.String(),
                        Width = c.Double(nullable: false),
                        WidthUnit = c.String(),
                        Length = c.Double(nullable: false),
                        LengthUnit = c.String(),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.MaterialId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Width = c.Double(nullable: false),
                        WidthUnit = c.String(),
                        Length = c.Double(nullable: false),
                        LengthUnit = c.String(),
                        Image = c.Binary(),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.ProductId);
            
            CreateTable(
                "dbo.MaterialStocks",
                c => new
                    {
                        RollId = c.Int(nullable: false),
                        MaterialId = c.String(nullable: false, maxLength: 128),
                        Length = c.Double(nullable: false),
                    })
                .PrimaryKey(t => new { t.RollId, t.MaterialId })
                .ForeignKey("dbo.Materials", t => t.MaterialId, cascadeDelete: true)
                .Index(t => t.MaterialId);
            
            CreateTable(
                "dbo.OrderedProducts",
                c => new
                    {
                        ProductId = c.String(nullable: false, maxLength: 128),
                        OrderId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Order_OrderId = c.Int(),
                        Order_Date = c.DateTime(),
                    })
                .PrimaryKey(t => new { t.ProductId, t.OrderId })
                .ForeignKey("dbo.Orders", t => new { t.Order_OrderId, t.Order_Date })
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => new { t.Order_OrderId, t.Order_Date });
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Stage = c.String(),
                        Quantity = c.Int(nullable: false),
                        Customer_Login = c.String(maxLength: 128),
                        Customer_Password = c.String(maxLength: 128),
                        Manager_Login = c.String(maxLength: 128),
                        Manager_Password = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.OrderId, t.Date })
                .ForeignKey("dbo.Users", t => new { t.Customer_Login, t.Customer_Password })
                .ForeignKey("dbo.Users", t => new { t.Manager_Login, t.Manager_Password })
                .Index(t => new { t.Customer_Login, t.Customer_Password })
                .Index(t => new { t.Manager_Login, t.Manager_Password });
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Login = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false, maxLength: 128),
                        Role = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => new { t.Login, t.Password });
            
            CreateTable(
                "dbo.ProductsFurnitures",
                c => new
                    {
                        FurnitureId = c.String(nullable: false, maxLength: 128),
                        ProductId = c.String(nullable: false, maxLength: 128),
                        Placing = c.String(),
                        Width = c.Double(nullable: false),
                        WidthUnit = c.String(),
                        Length = c.Double(nullable: false),
                        LengthUnit = c.String(),
                        Rotation = c.Double(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.FurnitureId, t.ProductId })
                .ForeignKey("dbo.Furnitures", t => t.FurnitureId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.FurnitureId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.ProductMaterials",
                c => new
                    {
                        Product_ProductId = c.String(nullable: false, maxLength: 128),
                        Material_MaterialId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Product_ProductId, t.Material_MaterialId })
                .ForeignKey("dbo.Products", t => t.Product_ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Materials", t => t.Material_MaterialId, cascadeDelete: true)
                .Index(t => t.Product_ProductId)
                .Index(t => t.Material_MaterialId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductsFurnitures", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductsFurnitures", "FurnitureId", "dbo.Furnitures");
            DropForeignKey("dbo.OrderedProducts", "ProductId", "dbo.Products");
            DropForeignKey("dbo.OrderedProducts", new[] { "Order_OrderId", "Order_Date" }, "dbo.Orders");
            DropForeignKey("dbo.Orders", new[] { "Manager_Login", "Manager_Password" }, "dbo.Users");
            DropForeignKey("dbo.Orders", new[] { "Customer_Login", "Customer_Password" }, "dbo.Users");
            DropForeignKey("dbo.MaterialStocks", "MaterialId", "dbo.Materials");
            DropForeignKey("dbo.ProductMaterials", "Material_MaterialId", "dbo.Materials");
            DropForeignKey("dbo.ProductMaterials", "Product_ProductId", "dbo.Products");
            DropForeignKey("dbo.FurnitureStocks", "FurnitureId", "dbo.Furnitures");
            DropIndex("dbo.ProductMaterials", new[] { "Material_MaterialId" });
            DropIndex("dbo.ProductMaterials", new[] { "Product_ProductId" });
            DropIndex("dbo.ProductsFurnitures", new[] { "ProductId" });
            DropIndex("dbo.ProductsFurnitures", new[] { "FurnitureId" });
            DropIndex("dbo.Orders", new[] { "Manager_Login", "Manager_Password" });
            DropIndex("dbo.Orders", new[] { "Customer_Login", "Customer_Password" });
            DropIndex("dbo.OrderedProducts", new[] { "Order_OrderId", "Order_Date" });
            DropIndex("dbo.OrderedProducts", new[] { "ProductId" });
            DropIndex("dbo.MaterialStocks", new[] { "MaterialId" });
            DropIndex("dbo.FurnitureStocks", new[] { "FurnitureId" });
            DropTable("dbo.ProductMaterials");
            DropTable("dbo.ProductsFurnitures");
            DropTable("dbo.Users");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderedProducts");
            DropTable("dbo.MaterialStocks");
            DropTable("dbo.Products");
            DropTable("dbo.Materials");
            DropTable("dbo.FurnitureStocks");
            DropTable("dbo.Furnitures");
        }
    }
}
