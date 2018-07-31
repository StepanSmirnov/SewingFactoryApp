namespace SawingFactory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_prducts_history2 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.ProductsFurnitureHisotries", "SpecId");
            AddForeignKey("dbo.ProductsFurnitureHisotries", "SpecId", "dbo.ProductsHistories", "SpecId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductsFurnitureHisotries", "SpecId", "dbo.ProductsHistories");
            DropIndex("dbo.ProductsFurnitureHisotries", new[] { "SpecId" });
        }
    }
}
