namespace Coopreport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Registrations",
                c => new
                    {
                        RegistrationID = c.Int(nullable: false, identity: true),
                        StudentID = c.String(nullable: false, maxLength: 9),
                        SFName = c.String(nullable: false),
                        SLName = c.String(nullable: false),
                        SProgram = c.String(nullable: false),
                        SEmail = c.String(nullable: false),
                        Address1 = c.String(),
                        Address2 = c.String(),
                        City = c.String(),
                        Provience = c.String(),
                        PostalCode = c.String(),
                        Phone = c.String(),
                        Cell = c.String(),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.RegistrationID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Registrations");
        }
    }
}
