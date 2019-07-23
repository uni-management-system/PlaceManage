namespace UniManagementApp.Db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationOnPlace : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Places", "Deputation");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Places", "Deputation", c => c.String(nullable: false));
        }
    }
}
