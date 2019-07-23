namespace UniManagementApp.Db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationOnName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ApplyFors", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ApplyFors", "Name", c => c.Int(nullable: false));
        }
    }
}
