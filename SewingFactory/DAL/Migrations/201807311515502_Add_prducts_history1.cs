namespace SawingFactory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_prducts_history1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductsFurnitureHisotries",
                c => new
                    {
                        SpecId = c.Int(nullable: false),
                        FurnitureId = c.Int(nullable: false),
                        Placing = c.String(nullable: false),
                        Width = c.Double(),
                        WidthUnit = c.String(),
                        Length = c.Double(),
                        LengthUnit = c.String(),
                        Rotation = c.Double(),
                        Quantity = c.Int(nullable: false),
                        Furniture_FurnitureId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.SpecId, t.FurnitureId })
                .ForeignKey("dbo.Furnitures", t => t.Furniture_FurnitureId)
                .Index(t => t.Furniture_FurnitureId);
            
            CreateTable(
                "dbo.ProductsHistories",
                c => new
                    {
                        SpecId = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Product_ProductId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.SpecId)
                .ForeignKey("dbo.Products", t => t.Product_ProductId)
                .Index(t => t.Product_ProductId);
            
            AddColumn("dbo.Materials", "ProductsHistory_SpecId", c => c.Int());
            CreateIndex("dbo.Materials", "ProductsHistory_SpecId");
            AddForeignKey("dbo.Materials", "ProductsHistory_SpecId", "dbo.ProductsHistories", "SpecId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductsHistories", "Product_ProductId", "dbo.Products");
            DropForeignKey("dbo.Materials", "ProductsHistory_SpecId", "dbo.ProductsHistories");
            DropForeignKey("dbo.ProductsFurnitureHisotries", "Furniture_FurnitureId", "dbo.Furnitures");
            DropIndex("dbo.ProductsHistories", new[] { "Product_ProductId" });
            DropIndex("dbo.ProductsFurnitureHisotries", new[] { "Furniture_FurnitureId" });
            DropIndex("dbo.Materials", new[] { "ProductsHistory_SpecId" });
            DropColumn("dbo.Materials", "ProductsHistory_SpecId");
            DropTable("dbo.ProductsHistories");
            DropTable("dbo.ProductsFurnitureHisotries");
        }
    }
}
