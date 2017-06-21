namespace CutTheCord.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class schedule7 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Schedules", new[] { "Member_Id" });
            DropIndex("dbo.Schedules", new[] { "Show_id" });
            CreateIndex("dbo.Schedules", "member_Id");
            CreateIndex("dbo.Schedules", "show_id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Schedules", new[] { "show_id" });
            DropIndex("dbo.Schedules", new[] { "member_Id" });
            CreateIndex("dbo.Schedules", "Show_id");
            CreateIndex("dbo.Schedules", "Member_Id");
        }
    }
}
