namespace UniManagementApp.Db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Scale : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Scales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Scales = c.Int(nullable: false),
                        ScaleName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Scales");
        }
    }
}
