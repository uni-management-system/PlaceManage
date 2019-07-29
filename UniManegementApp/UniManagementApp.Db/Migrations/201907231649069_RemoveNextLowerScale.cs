namespace UniManagementApp.Db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveNextLowerScale : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Places", "NextLowerScaleAppointmentDate3");
            DropColumn("dbo.Places", "NextLowerScaleLength3");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Places", "NextLowerScaleLength3", c => c.String());
            AddColumn("dbo.Places", "NextLowerScaleAppointmentDate3", c => c.DateTime());
        }
    }
}
