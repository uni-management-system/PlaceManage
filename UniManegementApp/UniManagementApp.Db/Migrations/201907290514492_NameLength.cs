namespace UniManagementApp.Db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NameLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Places", "Name", c => c.String(nullable: false, maxLength: 5));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Places", "Name", c => c.String(nullable: false));
        }
    }
}
