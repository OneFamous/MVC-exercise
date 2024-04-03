namespace exercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Name) VALUES ('Comedy')");
            Sql("INSERT INTO Genres(Name) VALUES ('Action')");
            Sql("INSERT INTO Genres(Name) VALUES ('Family')");
            Sql("INSERT INTO Genres(Name) VALUES ('Romance')");
            Sql("INSERT INTO Genres(Name) VALUES ('Cartoon')");
            Sql("INSERT INTO Genres(Name) VALUES ('Sci-fi')");
        }
        
        public override void Down()
        {
        }
    }
}
