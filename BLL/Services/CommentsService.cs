using DAL.Repositories;
using DAL.Models;

namespace BLL.Services
{
    public class CommentsService
    {
        CommentsRepository commentsRepository = new CommentsRepository();
        public void Add(Comment comment)
        {
            if(comment != null)
            {
                commentsRepository.AddComment(comment);
            }
        }
    }
}
