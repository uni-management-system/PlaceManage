namespace UniManagementApp.Db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotation1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Places", "DesignationId", "dbo.Designations");
            DropIndex("dbo.Places", new[] { "DesignationId" });
            AddColumn("dbo.Places", "Designation_Id", c => c.Int());
            AlterColumn("dbo.Places", "DesignationId", c => c.String(nullable: false));
            AlterColumn("dbo.Places", "Loan", c => c.String());
            CreateIndex("dbo.Places", "Designation_Id");
            AddForeignKey("dbo.Places", "Designation_Id", "dbo.Designations", "Id");
            DropColumn("dbo.Places", "JobName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Places", "JobName", c => c.String(nullable: false));
            DropForeignKey("dbo.Places", "Designation_Id", "dbo.Designations");
            DropIndex("dbo.Places", new[] { "Designation_Id" });
            AlterColumn("dbo.Places", "Loan", c => c.String(nullable: false));
            AlterColumn("dbo.Places", "DesignationId", c => c.Int(nullable: false));
            DropColumn("dbo.Places", "Designation_Id");
            CreateIndex("dbo.Places", "DesignationId");
            AddForeignKey("dbo.Places", "DesignationId", "dbo.Designations", "Id", cascadeDelete: true);
        }
    }
}
