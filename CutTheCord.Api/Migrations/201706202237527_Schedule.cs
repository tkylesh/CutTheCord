namespace CutTheCord.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Schedule : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        time = c.String(),
                        member_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Members", t => t.member_Id)
                .Index(t => t.member_Id);
            
            AddColumn("dbo.Shows", "schedule_Id", c => c.Int());
            CreateIndex("dbo.Shows", "schedule_Id");
            AddForeignKey("dbo.Shows", "schedule_Id", "dbo.Schedules", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Shows", "schedule_Id", "dbo.Schedules");
            DropForeignKey("dbo.Schedules", "member_Id", "dbo.Members");
            DropIndex("dbo.Schedules", new[] { "member_Id" });
            DropIndex("dbo.Shows", new[] { "schedule_Id" });
            DropColumn("dbo.Shows", "schedule_Id");
            DropTable("dbo.Schedules");
        }
    }
}
