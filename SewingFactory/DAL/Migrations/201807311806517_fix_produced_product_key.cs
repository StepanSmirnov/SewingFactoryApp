namespace SawingFactory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix_produced_product_key : DbMigration
    {
        public override void Up()
        {
            //DropIndex("dbo.PruducedProducts", new[] { "Product_ProductId" });
            //DropColumn("dbo.PruducedProducts", "ProductId");
            RenameColumn(table: "dbo.PruducedProducts", name: "Product_ProductId", newName: "ProductId");
            //DropPrimaryKey("dbo.PruducedProducts");
            //AlterColumn("dbo.PruducedProducts", "ProductId", c => c.String(nullable: false, maxLength: 128));
            //AlterColumn("dbo.PruducedProducts", "ProductId", c => c.String(nullable: false, maxLength: 128));
            //AddPrimaryKey("dbo.PruducedProducts", "ProductId");
            CreateIndex("dbo.PruducedProducts", "ProductId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.PruducedProducts", new[] { "ProductId" });
            DropPrimaryKey("dbo.PruducedProducts");
            AlterColumn("dbo.PruducedProducts", "ProductId", c => c.String(maxLength: 128));
            AlterColumn("dbo.PruducedProducts", "ProductId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.PruducedProducts", "ProductId");
            RenameColumn(table: "dbo.PruducedProducts", name: "ProductId", newName: "Product_ProductId");
            AddColumn("dbo.PruducedProducts", "ProductId", c => c.Int(nullable: false, identity: true));
            CreateIndex("dbo.PruducedProducts", "Product_ProductId");
        }
    }
}
