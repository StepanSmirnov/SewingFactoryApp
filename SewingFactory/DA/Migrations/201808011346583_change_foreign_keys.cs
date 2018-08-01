namespace SawingFactory.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change_foreign_keys : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Orders", name: "Customer_Login", newName: "CustomerLogin");
            RenameColumn(table: "dbo.Orders", name: "Customer_Password", newName: "CustomerPassword");
            RenameColumn(table: "dbo.Orders", name: "Manager_Login", newName: "ManagerLogin");
            RenameColumn(table: "dbo.Orders", name: "Manager_Password", newName: "ManagerPassword");
            RenameIndex(table: "dbo.Orders", name: "IX_Customer_Login_Customer_Password", newName: "IX_CustomerLogin_CustomerPassword");
            RenameIndex(table: "dbo.Orders", name: "IX_Manager_Login_Manager_Password", newName: "IX_ManagerLogin_ManagerPassword");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Orders", name: "IX_ManagerLogin_ManagerPassword", newName: "IX_Manager_Login_Manager_Password");
            RenameIndex(table: "dbo.Orders", name: "IX_CustomerLogin_CustomerPassword", newName: "IX_Customer_Login_Customer_Password");
            RenameColumn(table: "dbo.Orders", name: "ManagerPassword", newName: "Manager_Password");
            RenameColumn(table: "dbo.Orders", name: "ManagerLogin", newName: "Manager_Login");
            RenameColumn(table: "dbo.Orders", name: "CustomerPassword", newName: "Customer_Password");
            RenameColumn(table: "dbo.Orders", name: "CustomerLogin", newName: "Customer_Login");
        }
    }
}
