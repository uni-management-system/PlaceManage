namespace UniManagementApp.Db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveMobileLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Places", "MobileNo", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Places", "MobileNo", c => c.String(nullable: false, maxLength: 11));
        }
    }
}
