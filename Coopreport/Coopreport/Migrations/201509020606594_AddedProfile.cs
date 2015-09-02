namespace Coopreport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedProfile : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Profiles",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        Username = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        PhoneNo = c.String(),
                        Course = c.String(),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.Users", t => t.UserID)
                .Index(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Profiles", "UserID", "dbo.Users");
            DropIndex("dbo.Profiles", new[] { "UserID" });
            DropTable("dbo.Profiles");
        }
    }
}
