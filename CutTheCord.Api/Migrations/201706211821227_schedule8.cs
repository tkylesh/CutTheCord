namespace CutTheCord.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class schedule8 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Schedules", new[] { "member_Id" });
            CreateIndex("dbo.Schedules", "Member_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Schedules", new[] { "Member_Id" });
            CreateIndex("dbo.Schedules", "member_Id");
        }
    }
}
