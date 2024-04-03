namespace exercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomerTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers(Name) VALUES ('Fatih Ates')");
            Sql("INSERT INTO Customers(Name) VALUES ('John Smith')");
            Sql("INSERT INTO Customers(Name) VALUES ('Marry Williams')");
        }

        public override void Down()
        {
        }
    }
}
