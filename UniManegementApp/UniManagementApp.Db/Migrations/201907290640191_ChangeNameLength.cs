namespace UniManagementApp.Db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeNameLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Places", "Name", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Places", "Name", c => c.String(nullable: false, maxLength: 5));
        }
    }
}
