namespace CutTheCord.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class June17 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Shows", "PremierDate", c => c.String());
            DropColumn("dbo.Shows", "EndDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Shows", "EndDate", c => c.DateTime());
            AlterColumn("dbo.Shows", "PremierDate", c => c.DateTime(nullable: false));
        }
    }
}
