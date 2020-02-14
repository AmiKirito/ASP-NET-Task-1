using System;

namespace DAL.Models
{
    /// <summary>
    /// Contains the logic of the survey entity
    /// </summary>
    public class Survey
    {
        public string Id { get; set; }
        public string AuthorName{ get; set; }
        public DateTime PostDate { get; set; }
        public string ReviewText { get; set; }
    }
}