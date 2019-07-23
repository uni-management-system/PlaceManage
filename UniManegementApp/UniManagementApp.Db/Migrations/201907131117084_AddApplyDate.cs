namespace UniManagementApp.Db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddApplyDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Places", "ApplyDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Places", "ApplyDate");
        }
    }
}
