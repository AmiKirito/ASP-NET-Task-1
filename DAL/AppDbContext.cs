using System.Data.Entity;
using DAL.Models;
using DAL.ExtensionMethods;

namespace DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base ("MyBlogDB")
        {
            Database.SetInitializer(new DbContextInizializer());
        }
        public AppDbContext(string nameOrConnectionString) : base(nameOrConnectionString) { }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}
