namespace UniManagementApp.Db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveCNICLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Places", "Name", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Places", "CNIC", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Places", "CNIC", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Places", "Name", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
