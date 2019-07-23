namespace UniManagementApp.Db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ScaleNo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ScaleNoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ScaleNum = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ScaleNoes");
        }
    }
}
