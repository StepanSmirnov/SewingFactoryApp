namespace SawingFactory.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_auto_increment_to_order : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderedProducts", new[] { "Order_OrderId", "Order_Date" }, "dbo.Orders");
            DropPrimaryKey("dbo.Orders");
            AlterColumn("dbo.Orders", "OrderId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Orders", new[] { "OrderId", "Date" });
            AddForeignKey("dbo.OrderedProducts", new[] { "Order_OrderId", "Order_Date" }, "dbo.Orders", new[] { "OrderId", "Date" });
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderedProducts", new[] { "Order_OrderId", "Order_Date" }, "dbo.Orders");
            DropPrimaryKey("dbo.Orders");
            AlterColumn("dbo.Orders", "OrderId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Orders", new[] { "OrderId", "Date" });
            AddForeignKey("dbo.OrderedProducts", new[] { "Order_OrderId", "Order_Date" }, "dbo.Orders", new[] { "OrderId", "Date" });
        }
    }
}
