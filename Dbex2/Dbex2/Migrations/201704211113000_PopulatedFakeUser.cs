namespace Dbex2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatedFakeUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FakeUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FakeName = c.String(),
                        FakeDate = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FakeUsers");
        }
    }
}
