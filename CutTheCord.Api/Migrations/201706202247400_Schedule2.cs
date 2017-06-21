namespace CutTheCord.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Schedule2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Schedules", "days", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Schedules", "days");
        }
    }
}
