namespace UniManagementApp.Db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPlace : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Places",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ApplyForId = c.Int(nullable: false),
                        ScaleNoId = c.Int(nullable: false),
                        JobName = c.String(nullable: false),
                        Allotment = c.String(nullable: false),
                        Reason = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        BPS = c.String(nullable: false),
                        DesignationId = c.Int(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                        MaritalStatus = c.String(nullable: false),
                        NoOfDependent = c.String(nullable: false),
                        DomicileId = c.Int(nullable: false),
                        Address = c.String(nullable: false),
                        PhoneNo = c.String(),
                        MobileNo = c.String(nullable: false),
                        DOB = c.DateTime(nullable: false),
                        Age = c.String(nullable: false),
                        StatusId = c.Int(nullable: false),
                        Deputation = c.String(nullable: false),
                        HaveHome = c.Boolean(nullable: false),
                        Loan = c.String(nullable: false),
                        AppointmentDate = c.DateTime(nullable: false),
                        CurrentScaleAppointmentDate = c.DateTime(nullable: false),
                        CurrentScaleLength = c.String(nullable: false),
                        ImmediateLowerScaleAppointmentDate = c.DateTime(nullable: false),
                        ImmediateLowerScaleLength = c.String(nullable: false),
                        NextLowerScaleAppointmentDate = c.DateTime(nullable: false),
                        NextLowerScaleLength = c.String(nullable: false),
                        NextLowerScaleAppointmentDate1 = c.DateTime(nullable: false),
                        NextLowerScaleLength1 = c.String(nullable: false),
                        NextLowerScaleAppointmentDate2 = c.DateTime(nullable: false),
                        NextLowerScaleLength2 = c.String(nullable: false),
                        NextLowerScaleAppointmentDate3 = c.DateTime(nullable: false),
                        NextLowerScaleLength3 = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplyFors", t => t.ApplyForId, cascadeDelete: true)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.Designations", t => t.DesignationId, cascadeDelete: true)
                .ForeignKey("dbo.Domiciles", t => t.DomicileId, cascadeDelete: true)
                .ForeignKey("dbo.ScaleNoes", t => t.ScaleNoId, cascadeDelete: true)
                .ForeignKey("dbo.Status", t => t.StatusId, cascadeDelete: true)
                .Index(t => t.ApplyForId)
                .Index(t => t.ScaleNoId)
                .Index(t => t.DesignationId)
                .Index(t => t.DepartmentId)
                .Index(t => t.DomicileId)
                .Index(t => t.StatusId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Places", "StatusId", "dbo.Status");
            DropForeignKey("dbo.Places", "ScaleNoId", "dbo.ScaleNoes");
            DropForeignKey("dbo.Places", "DomicileId", "dbo.Domiciles");
            DropForeignKey("dbo.Places", "DesignationId", "dbo.Designations");
            DropForeignKey("dbo.Places", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Places", "ApplyForId", "dbo.ApplyFors");
            DropIndex("dbo.Places", new[] { "StatusId" });
            DropIndex("dbo.Places", new[] { "DomicileId" });
            DropIndex("dbo.Places", new[] { "DepartmentId" });
            DropIndex("dbo.Places", new[] { "DesignationId" });
            DropIndex("dbo.Places", new[] { "ScaleNoId" });
            DropIndex("dbo.Places", new[] { "ApplyForId" });
            DropTable("dbo.Places");
        }
    }
}
