namespace CutTheCord.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Schedule5 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Schedules", new[] { "member_Id" });
            AddColumn("dbo.Schedules", "Show_id", c => c.Int());
            CreateIndex("dbo.Schedules", "Member_Id");
            CreateIndex("dbo.Schedules", "Show_id");
            AddForeignKey("dbo.Schedules", "Show_id", "dbo.Shows", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Schedules", "Show_id", "dbo.Shows");
            DropIndex("dbo.Schedules", new[] { "Show_id" });
            DropIndex("dbo.Schedules", new[] { "Member_Id" });
            DropColumn("dbo.Schedules", "Show_id");
            CreateIndex("dbo.Schedules", "member_Id");
        }
    }
}
