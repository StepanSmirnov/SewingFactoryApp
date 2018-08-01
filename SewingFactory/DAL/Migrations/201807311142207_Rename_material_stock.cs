namespace SawingFactory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rename_material_stock : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MaterialStocks", "MaterialId", "dbo.Materials");
            DropIndex("dbo.MaterialStocks", new[] { "MaterialId" });
            CreateTable(
                "dbo.MaterialRolls",
                c => new
                    {
                        RollId = c.Int(nullable: false, identity: true),
                        MaterialId = c.String(nullable: false, maxLength: 128),
                        Width = c.Double(nullable: false),
                        WidthUnit = c.String(nullable: false),
                        Length = c.Double(nullable: false),
                        LengthUnit = c.String(nullable: false),
                    })
                .PrimaryKey(t => new { t.RollId, t.MaterialId })
                .ForeignKey("dbo.Materials", t => t.MaterialId, cascadeDelete: true)
                .Index(t => t.MaterialId);
            
            DropTable("dbo.MaterialStocks");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.MaterialStocks",
                c => new
                    {
                        RollId = c.Int(nullable: false),
                        MaterialId = c.String(nullable: false, maxLength: 128),
                        Length = c.Double(nullable: false),
                    })
                .PrimaryKey(t => new { t.RollId, t.MaterialId });
            
            DropForeignKey("dbo.MaterialRolls", "MaterialId", "dbo.Materials");
            DropIndex("dbo.MaterialRolls", new[] { "MaterialId" });
            DropTable("dbo.MaterialRolls");
            CreateIndex("dbo.MaterialStocks", "MaterialId");
            AddForeignKey("dbo.MaterialStocks", "MaterialId", "dbo.Materials", "MaterialId", cascadeDelete: true);
        }
    }
}
