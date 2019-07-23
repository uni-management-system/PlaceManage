namespace UniManagementApp.Db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationOnMobile : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Places", "MobileNo", c => c.String(nullable: false, maxLength: 11));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Places", "MobileNo", c => c.Int(nullable: false));
        }
    }
}
