using DAL.Models;
using System.Data.Entity;

namespace DAL.ExtensionMethods
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>()
                .HasMany<Comment>(a => a.Comments)
                .WithRequired(s => s.Article)
                .WillCascadeOnDelete();
            modelBuilder.Entity<Article>()
                .HasMany<Tag>(a => a.Tags)
                .WithMany(t => t.Articles)
                .Map(m =>
                {
                    m.MapLeftKey("ArticleId");
                    m.MapRightKey("TagId");
                    m.ToTable("ArticleTags");
                });
        }
    }
}
