namespace CutTheCord.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class June20 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.ShowMembers", new[] { "Show_Id" });
            AddColumn("dbo.Shows", "url", c => c.String());
            AddColumn("dbo.Shows", "name", c => c.String());
            AddColumn("dbo.Shows", "type", c => c.String());
            AddColumn("dbo.Shows", "premiered", c => c.String());
            AddColumn("dbo.Shows", "image", c => c.String());
            AddColumn("dbo.Shows", "summary", c => c.String());
            CreateIndex("dbo.ShowMembers", "Show_id");
            DropColumn("dbo.Shows", "Title");
            DropColumn("dbo.Shows", "PremierDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Shows", "PremierDate", c => c.String());
            AddColumn("dbo.Shows", "Title", c => c.String());
            DropIndex("dbo.ShowMembers", new[] { "Show_id" });
            DropColumn("dbo.Shows", "summary");
            DropColumn("dbo.Shows", "image");
            DropColumn("dbo.Shows", "premiered");
            DropColumn("dbo.Shows", "type");
            DropColumn("dbo.Shows", "name");
            DropColumn("dbo.Shows", "url");
            CreateIndex("dbo.ShowMembers", "Show_Id");
        }
    }
}
