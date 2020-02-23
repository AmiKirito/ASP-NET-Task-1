namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TagsAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ArticleTags",
                c => new
                    {
                        ArticleId = c.String(nullable: false, maxLength: 128),
                        TagId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.ArticleId, t.TagId })
                .ForeignKey("dbo.Articles", t => t.ArticleId, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.TagId, cascadeDelete: true)
                .Index(t => t.ArticleId)
                .Index(t => t.TagId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ArticleTags", "TagId", "dbo.Tags");
            DropForeignKey("dbo.ArticleTags", "ArticleId", "dbo.Articles");
            DropIndex("dbo.ArticleTags", new[] { "TagId" });
            DropIndex("dbo.ArticleTags", new[] { "ArticleId" });
            DropTable("dbo.ArticleTags");
            DropTable("dbo.Tags");
        }
    }
}
