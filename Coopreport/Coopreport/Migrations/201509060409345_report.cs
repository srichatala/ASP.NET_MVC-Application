namespace Coopreport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class report : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Report",
                c => new
                    {
                        ReportId = c.Int(nullable: false, identity: true),
                        StudentID = c.String(),
                        StudentName = c.String(),
                        AdvisorName = c.String(),
                        Oraganization = c.String(),
                        WorkTerm = c.String(),
                        Year = c.Int(nullable: false),
                        ReportMonth = c.String(),
                        JobTitle = c.String(),
                        LikeIntership = c.String(),
                        AdequatelyPrepared = c.String(),
                        Curriculum = c.String(),
                        Expectation = c.String(),
                        Requirement = c.String(),
                        AboutCoopAdvisor = c.String(),
                        AgencySupervisor = c.String(),
                        SupervisorActive = c.String(),
                        Attendance = c.String(),
                        Punctuality = c.String(),
                        Structured = c.String(),
                        OverStructured = c.String(),
                        Problems = c.String(),
                        HelpProblems = c.String(),
                        Learning = c.String(),
                        Rewarding = c.String(),
                        ObjectiveEstablished = c.String(),
                        Recommend = c.String(),
                        SelfEvaluation = c.String(),
                        DutiesPerformed = c.String(),
                        Comments = c.String(),
                        Questionnaires = c.String(),
                    })
                .PrimaryKey(t => t.ReportId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Report");
        }
    }
}
