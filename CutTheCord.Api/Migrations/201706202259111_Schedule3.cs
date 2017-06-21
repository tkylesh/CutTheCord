namespace CutTheCord.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Schedule3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Schedules", "member_Id", "dbo.Members");
            DropIndex("dbo.Schedules", new[] { "member_Id" });
            AddColumn("dbo.Members", "schedule_Id", c => c.Int());
            CreateIndex("dbo.Members", "schedule_Id");
            AddForeignKey("dbo.Members", "schedule_Id", "dbo.Schedules", "Id");
            DropColumn("dbo.Schedules", "member_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Schedules", "member_Id", c => c.Int());
            DropForeignKey("dbo.Members", "schedule_Id", "dbo.Schedules");
            DropIndex("dbo.Members", new[] { "schedule_Id" });
            DropColumn("dbo.Members", "schedule_Id");
            CreateIndex("dbo.Schedules", "member_Id");
            AddForeignKey("dbo.Schedules", "member_Id", "dbo.Members", "Id");
        }
    }
}
