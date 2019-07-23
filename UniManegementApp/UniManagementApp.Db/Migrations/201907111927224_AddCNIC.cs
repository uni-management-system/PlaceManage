namespace UniManagementApp.Db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCNIC : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Places", "CNIC", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Places", "CNIC");
        }
    }
}
