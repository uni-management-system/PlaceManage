namespace UniManagementApp.Db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Places", "HouseCategory", c => c.String(nullable: false));
            AlterColumn("dbo.Places", "HaveHome", c => c.String());
            DropColumn("dbo.Places", "BPS");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Places", "BPS", c => c.String(nullable: false));
            AlterColumn("dbo.Places", "HaveHome", c => c.Boolean(nullable: false));
            DropColumn("dbo.Places", "HouseCategory");
        }
    }
}
