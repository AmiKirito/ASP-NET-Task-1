using System;
using System.Collections.Generic;

namespace DAL.Models
{
    /// <summary>
    ///  Contains the logic of the survey entity
    /// </summary>
    public class Article
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }
        public string TextContent { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Tag> Tags { get; set; }
    }
}