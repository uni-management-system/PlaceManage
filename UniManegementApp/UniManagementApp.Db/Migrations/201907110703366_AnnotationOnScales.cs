namespace UniManagementApp.Db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AnnotationOnScales : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Places", "ImmediateLowerScaleLength", c => c.String());
            AlterColumn("dbo.Places", "NextLowerScaleLength", c => c.String());
            AlterColumn("dbo.Places", "NextLowerScaleLength1", c => c.String());
            AlterColumn("dbo.Places", "NextLowerScaleLength2", c => c.String());
            AlterColumn("dbo.Places", "NextLowerScaleLength3", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Places", "NextLowerScaleLength3", c => c.String(nullable: false));
            AlterColumn("dbo.Places", "NextLowerScaleLength2", c => c.String(nullable: false));
            AlterColumn("dbo.Places", "NextLowerScaleLength1", c => c.String(nullable: false));
            AlterColumn("dbo.Places", "NextLowerScaleLength", c => c.String(nullable: false));
            AlterColumn("dbo.Places", "ImmediateLowerScaleLength", c => c.String(nullable: false));
        }
    }
}
