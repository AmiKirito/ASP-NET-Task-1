using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_NET_Task_1.Models
{
    public static class ArticleData
    {
        public static ICollection<Article> Articles { get; } = new List<Article>()
        {
            new Article()
            {
                Title = "BBC",
                PublishDate = DateTime.Now,
                TextContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat." +
                " Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur." +
                " Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            },
            new Article()
            {
                Title = "Discovery",
                PublishDate = DateTime.Now,
                TextContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat." +
                " Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur." +
                " Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            },
            new Article()
            {
                Title = "Nat Geo Wild",
                PublishDate = DateTime.Now,
                TextContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat." +
                " Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur." +
                " Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            }
            ,
            new Article()
            {
                Title = "TV1000",
                PublishDate = DateTime.Now,
                TextContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat." +
                " Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur." +
                " Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            }

        };
    }
    public static class ReviewsData
    {
        public static ICollection<Survey> Surveys { get; } = new List<Survey>()
        {
            new Survey()
            {
                AuthorName = "John",
                PostDate = DateTime.Now,
                ReviewText = "This is cool blog"
            },
            new Survey()
            {
                AuthorName = "Marcus",
                PostDate = DateTime.Now,
                ReviewText = "Wanna pass the survey again soon"
            },
            new Survey()
            {
                AuthorName = "Phillip",
                PostDate = DateTime.Now,
                ReviewText = "Cool test"
            },
            new Survey()
            {
                AuthorName = "Andrea",
                PostDate = DateTime.Now,
                ReviewText = "Nice styles, lol"
            },
            new Survey()
            {
                AuthorName = "Simon",
                PostDate = DateTime.Now,
                ReviewText = "I wanna hire your web-designer"
            }

        };
    }
}