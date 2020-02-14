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
        }
    }
}
