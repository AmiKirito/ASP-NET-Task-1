using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DAL.Models;

namespace DAL
{
    class DbContextInizializer : DropCreateDatabaseAlways<AppDbContext>
    {
        protected override void Seed(AppDbContext context)
        {
            List<Tag> tags = new List<Tag>()
            {
                new Tag()
                {
                    Id = "1",
                    Value = "BBC"
                },
                new Tag()
                {
                    Id = "2",
                    Value = "science"
                },
                new Tag()
                {
                    Id = "3",
                    Value = "fiction"
                },
                new Tag()
                {
                    Id = "4",
                    Value = "Discovery"
                },
                new Tag()
                {
                    Id = "5",
                    Value = "Nat Geo Wild"
                },
                new Tag()
                {
                    Id = "6",
                    Value = "TV1000"
                }
            };
            tags.ForEach(t => context.Tags.Add(t));
            context.SaveChanges();

            Article art1 = new Article()
            {
                Id = "1",
                Title = "BBC",
                PublishDate = DateTime.Now,
                TextContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat." +
                " Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur." +
                " Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                Tags = new List<Tag>()
            };
            Article art2 = new Article()
            {
                Id = "2",
                Title = "Discovery",
                PublishDate = DateTime.Now,
                TextContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat." +
                " Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur." +
                " Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                Tags = new List<Tag>()
            };
            Article art3 = new Article()
            {
                Id = "3",
                Title = "Nat Geo Wild",
                PublishDate = DateTime.Now,
                TextContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat." +
                " Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur." +
                " Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                Tags = new List<Tag>()
            };
            Article art4 = new Article()
            {
                Id = "4",
                Title = "TV1000",
                PublishDate = DateTime.Now,
                TextContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat." +
                " Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur." +
                " Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                Tags = new List<Tag>()
            };
            context.Articles.Add(art1);
            context.Articles.Add(art2);
            context.Articles.Add(art3);
            context.Articles.Add(art4);

            context.SaveChanges();

            AddTag(context, "BBC", "BBC");
            AddTag(context, "BBC", "science");
            AddTag(context, "Discovery", "science");
            AddTag(context, "Nat Geo Wild", "science");
            AddTag(context, "TV1000", "fiction");
            AddTag(context, "Discovery", "Discovery");
            AddTag(context, "Nat Geo Wild", "Nat Geo Wild");
            AddTag(context, "TV1000", "TV1000");
            context.SaveChanges();

            Comment cmt1 = new Comment()
            {
                Id = "1",
                AuthorName = "John",
                PostDate = DateTime.Now,
                ReviewText = "Nice article",
                ArticleId = "1"
            };
            Comment cmt2 = new Comment()
            {
                Id = "2",
                AuthorName = "Marcus",
                PostDate = DateTime.Now,
                ReviewText = "Good job",
                ArticleId = "1"
            };
            Comment cmt3 = new Comment()
            {
                Id = "3",
                AuthorName = "Phillip",
                PostDate = DateTime.Now,
                ReviewText = "Awesome article!",
                ArticleId = "2"
            };
            Comment cmt4 = new Comment()
            {
                Id = "4",
                AuthorName = "Andrea",
                PostDate = DateTime.Now,
                ReviewText = "I really liked it",
                ArticleId = "3"
            };
            Comment cmt5 = new Comment()
            {
                Id = "5",
                AuthorName = "Simon",
                PostDate = DateTime.Now,
                ReviewText = "Looking forward for a new one",
                ArticleId = "3"
            };
            Comment cmt6 = new Comment()
            {
                Id = "6",
                AuthorName = "Dennys",
                PostDate = DateTime.Now,
                ReviewText = "Nice",
                ArticleId = "4"
            };
            context.Comments.Add(cmt1);
            context.Comments.Add(cmt2);
            context.Comments.Add(cmt3);
            context.Comments.Add(cmt4);
            context.Comments.Add(cmt5);
            context.Comments.Add(cmt6);

            context.SaveChanges();
            base.Seed(context);
        }
        void AddTag(AppDbContext context, string articleTitle, string tagValue)
        {
            var art = context.Articles.SingleOrDefault(a => a.Title == articleTitle);
            var tgs = art.Tags.SingleOrDefault(t => t.Value == tagValue);
            if (tgs == null)
                art.Tags.Add(context.Tags.Single(t => t.Value == tagValue));
        }
    }
}
