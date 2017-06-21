namespace CutTheCord.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeShowMembers : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ShowMembers", "Show_id", "dbo.Shows");
            DropForeignKey("dbo.ShowMembers", "Member_Id", "dbo.Members");
            DropIndex("dbo.ShowMembers", new[] { "Show_id" });
            DropIndex("dbo.ShowMembers", new[] { "Member_Id" });
            AddColumn("dbo.Shows", "Member_Id", c => c.Int());
            CreateIndex("dbo.Shows", "Member_Id");
            AddForeignKey("dbo.Shows", "Member_Id", "dbo.Members", "Id");
            DropTable("dbo.ShowMembers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ShowMembers",
                c => new
                    {
                        Show_id = c.Int(nullable: false),
                        Member_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Show_id, t.Member_Id });
            
            DropForeignKey("dbo.Shows", "Member_Id", "dbo.Members");
            DropIndex("dbo.Shows", new[] { "Member_Id" });
            DropColumn("dbo.Shows", "Member_Id");
            CreateIndex("dbo.ShowMembers", "Member_Id");
            CreateIndex("dbo.ShowMembers", "Show_id");
            AddForeignKey("dbo.ShowMembers", "Member_Id", "dbo.Members", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ShowMembers", "Show_id", "dbo.Shows", "id", cascadeDelete: true);
        }
    }
}
