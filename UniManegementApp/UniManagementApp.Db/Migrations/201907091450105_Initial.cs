namespace UniManagementApp.Db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdminScales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Scale = c.Int(nullable: false),
                        ScaleName = c.String(),
                        AppluForId = c.Int(nullable: false),
                        ApplyFor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplyFors", t => t.ApplyFor_Id)
                .Index(t => t.ApplyFor_Id);
            
            CreateTable(
                "dbo.ApplyFors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AdminScales", "ApplyFor_Id", "dbo.ApplyFors");
            DropIndex("dbo.AdminScales", new[] { "ApplyFor_Id" });
            DropTable("dbo.ApplyFors");
            DropTable("dbo.AdminScales");
        }
    }
}
