namespace Coopreport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedProfile : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Profiles", "Username", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Profiles", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Profiles", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Profiles", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Profiles", "PhoneNo", c => c.String(nullable: false));
            AlterColumn("dbo.Profiles", "Course", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Profiles", "Course", c => c.String());
            AlterColumn("dbo.Profiles", "PhoneNo", c => c.String());
            AlterColumn("dbo.Profiles", "Email", c => c.String());
            AlterColumn("dbo.Profiles", "LastName", c => c.String());
            AlterColumn("dbo.Profiles", "FirstName", c => c.String());
            AlterColumn("dbo.Profiles", "Username", c => c.String());
        }
    }
}
