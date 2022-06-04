namespace Ems.DataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWords : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Words",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        UserId = c.Long(nullable: false),
                        Value = c.String(),
                        Translate = c.String(),
                        Count = c.Int(nullable: false),
                        State = c.Int(nullable: false),
                        IsFavorite = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Words", "UserId", "dbo.Users");
            DropIndex("dbo.Words", new[] { "UserId" });
            DropTable("dbo.Words");
        }
    }
}
