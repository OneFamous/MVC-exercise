namespace exercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypeTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes(Name) VALUES ('Pay as You Go')");
            Sql("INSERT INTO MembershipTypes(Name) VALUES ('Monthly')");
            Sql("INSERT INTO MembershipTypes(Name) VALUES ('Year Pass')");
            Sql("INSERT INTO MembershipTypes(Name) VALUES ('Student Pass')");
            Sql("INSERT INTO MembershipTypes(Name) VALUES ('Pay to Win')");
        }
        
        public override void Down()
        {
        }
    }
}
