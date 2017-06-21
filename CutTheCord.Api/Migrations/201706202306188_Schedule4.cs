namespace CutTheCord.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Schedule4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Members", "schedule_Id", "dbo.Schedules");
            DropIndex("dbo.Members", new[] { "schedule_Id" });
            AddColumn("dbo.Schedules", "member_Id", c => c.Int());
            CreateIndex("dbo.Schedules", "member_Id");
            AddForeignKey("dbo.Schedules", "member_Id", "dbo.Members", "Id");
            DropColumn("dbo.Members", "schedule_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Members", "schedule_Id", c => c.Int());
            DropForeignKey("dbo.Schedules", "member_Id", "dbo.Members");
            DropIndex("dbo.Schedules", new[] { "member_Id" });
            DropColumn("dbo.Schedules", "member_Id");
            CreateIndex("dbo.Members", "schedule_Id");
            AddForeignKey("dbo.Members", "schedule_Id", "dbo.Schedules", "Id");
        }
    }
}
