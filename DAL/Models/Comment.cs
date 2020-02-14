using System;

namespace DAL.Models
{
    public class Comment
    {
        public string Id { get; set; }
        public string AuthorName { get; set; }
        public DateTime PostDate { get; set; }
        public string ReviewText { get; set; }
        public string ArticleId { get; set; }
        public Article Article { get; set; }
    }
}