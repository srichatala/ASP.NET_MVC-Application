namespace Coopreport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class user : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Profile", "UserID", "dbo.User");
            DropIndex("dbo.Profile", new[] { "UserID" });
            AddColumn("dbo.User", "FirstName", c => c.String());
            AddColumn("dbo.User", "LastName", c => c.String());
            AddColumn("dbo.User", "Email", c => c.String());
            AddColumn("dbo.User", "PhoneNo", c => c.String());
            AddColumn("dbo.User", "Course", c => c.String());
            DropTable("dbo.Profile");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Profile",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        Username = c.String(nullable: false, maxLength: 10),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        PhoneNo = c.String(nullable: false),
                        Course = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
            DropColumn("dbo.User", "Course");
            DropColumn("dbo.User", "PhoneNo");
            DropColumn("dbo.User", "Email");
            DropColumn("dbo.User", "LastName");
            DropColumn("dbo.User", "FirstName");
            CreateIndex("dbo.Profile", "UserID");
            AddForeignKey("dbo.Profile", "UserID", "dbo.User", "UserID");
        }
    }
}
