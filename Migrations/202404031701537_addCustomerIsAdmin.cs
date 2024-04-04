namespace exercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCustomerIsAdmin : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsAdmin", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "IsAdmin");
        }
    }
}
