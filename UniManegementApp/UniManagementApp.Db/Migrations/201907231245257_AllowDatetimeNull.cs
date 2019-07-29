namespace UniManagementApp.Db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllowDatetimeNull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Places", "ImmediateLowerScaleAppointmentDate", c => c.DateTime());
            AlterColumn("dbo.Places", "NextLowerScaleAppointmentDate", c => c.DateTime());
            AlterColumn("dbo.Places", "NextLowerScaleAppointmentDate1", c => c.DateTime());
            AlterColumn("dbo.Places", "NextLowerScaleAppointmentDate2", c => c.DateTime());
            AlterColumn("dbo.Places", "NextLowerScaleAppointmentDate3", c => c.DateTime());
            AlterColumn("dbo.Places", "ApplyDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Places", "ApplyDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Places", "NextLowerScaleAppointmentDate3", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Places", "NextLowerScaleAppointmentDate2", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Places", "NextLowerScaleAppointmentDate1", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Places", "NextLowerScaleAppointmentDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Places", "ImmediateLowerScaleAppointmentDate", c => c.DateTime(nullable: false));
        }
    }
}
