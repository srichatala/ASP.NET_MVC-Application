namespace Coopreport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateusername : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Username", c => c.String(nullable: false, maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Username", c => c.String(nullable: false, maxLength: 9));
        }
    }
}
