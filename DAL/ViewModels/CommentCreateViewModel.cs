using System.ComponentModel.DataAnnotations;

namespace DAL.ViewModels
{
    public class CommentCreateViewModel
    {
        [Required]
        public string ArticleId { get; set; }
        [Required(ErrorMessage = "The Name field is required!")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Name should contain at least 3 symbols")]
        public string AuthorName { get; set; }
        [Required(ErrorMessage = "The Text field is required!")]
        [StringLength(256, MinimumLength = 3, ErrorMessage = "Text should contain at least 3 symbols")]

        public string Text { get; set; }

    }
}
