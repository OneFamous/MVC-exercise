namespace exercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomersBirthDate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = '2001-09-25' WHERE Id = 1");
            Sql("UPDATE Customers SET BirthDate = '1990-01-01' WHERE Id = 2");
            Sql("UPDATE Customers SET BirthDate = '1970-05-07' WHERE Id = 3");
        }
        
        public override void Down()
        {
        }
    }
}
