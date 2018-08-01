namespace SawingFactory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_produced_poducts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PruducedProducts",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        Product_ProductId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Products", t => t.Product_ProductId)
                .Index(t => t.Product_ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PruducedProducts", "Product_ProductId", "dbo.Products");
            DropIndex("dbo.PruducedProducts", new[] { "Product_ProductId" });
            DropTable("dbo.PruducedProducts");
        }
    }
}
