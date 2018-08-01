namespace SawingFactory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class remove_width_from_material_roll : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.MaterialRolls", "Width");
            DropColumn("dbo.MaterialRolls", "WidthUnit");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MaterialRolls", "WidthUnit", c => c.String(nullable: false));
            AddColumn("dbo.MaterialRolls", "Width", c => c.Double(nullable: false));
        }
    }
}
