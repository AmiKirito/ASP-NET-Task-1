using System;
using System.Collections.Generic;

namespace DAL.Models
{
    /// <summary>
    /// Contains test data of the guest page
    /// </summary>
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