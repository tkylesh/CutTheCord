namespace CutTheCord.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Schedule6 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Shows", "schedule_Id", "dbo.Schedules");
            DropIndex("dbo.Shows", new[] { "schedule_Id" });
            DropColumn("dbo.Shows", "schedule_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Shows", "schedule_Id", c => c.Int());
            CreateIndex("dbo.Shows", "schedule_Id");
            AddForeignKey("dbo.Shows", "schedule_Id", "dbo.Schedules", "Id");
        }
    }
}
