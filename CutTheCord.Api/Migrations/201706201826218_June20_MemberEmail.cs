namespace CutTheCord.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class June20_MemberEmail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Members", "Email");
        }
    }
}
