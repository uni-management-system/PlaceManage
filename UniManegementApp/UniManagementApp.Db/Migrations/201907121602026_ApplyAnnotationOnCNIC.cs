namespace UniManagementApp.Db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationOnCNIC : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Places", "CNIC", c => c.String(nullable: false, maxLength: 13));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Places", "CNIC", c => c.String(nullable: false));
        }
    }
}
