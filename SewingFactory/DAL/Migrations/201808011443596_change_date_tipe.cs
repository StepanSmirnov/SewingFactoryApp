namespace SawingFactory.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change_date_tipe : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderedProducts", new[] { "Order_OrderId", "Order_Date" }, "dbo.Orders");
            DropIndex("dbo.OrderedProducts", new[] { "Order_OrderId", "Order_Date" });
            DropPrimaryKey("dbo.Orders");
            AlterColumn("dbo.OrderedProducts", "Order_Date", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Orders", "Date", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AddPrimaryKey("dbo.Orders", new[] { "OrderId", "Date" });
            CreateIndex("dbo.OrderedProducts", new[] { "Order_OrderId", "Order_Date" });
            AddForeignKey("dbo.OrderedProducts", new[] { "Order_OrderId", "Order_Date" }, "dbo.Orders", new[] { "OrderId", "Date" });
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderedProducts", new[] { "Order_OrderId", "Order_Date" }, "dbo.Orders");
            DropIndex("dbo.OrderedProducts", new[] { "Order_OrderId", "Order_Date" });
            DropPrimaryKey("dbo.Orders");
            AlterColumn("dbo.Orders", "Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.OrderedProducts", "Order_Date", c => c.DateTime());
            AddPrimaryKey("dbo.Orders", new[] { "OrderId", "Date" });
            CreateIndex("dbo.OrderedProducts", new[] { "Order_OrderId", "Order_Date" });
            AddForeignKey("dbo.OrderedProducts", new[] { "Order_OrderId", "Order_Date" }, "dbo.Orders", new[] { "OrderId", "Date" });
        }
    }
}
