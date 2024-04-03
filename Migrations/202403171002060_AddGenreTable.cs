namespace exercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenreTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Movies", "genres_Id", c => c.Int());
            CreateIndex("dbo.Movies", "genres_Id");
            AddForeignKey("dbo.Movies", "genres_Id", "dbo.Genres", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "genres_Id", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "genres_Id" });
            DropColumn("dbo.Movies", "genres_Id");
            DropTable("dbo.Genres");
        }
    }
}
