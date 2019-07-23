namespace UniManagementApp.Db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationOnLoan : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Places", "NoOfDependent", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Places", "NoOfDependent", c => c.String(nullable: false));
        }
    }
}
