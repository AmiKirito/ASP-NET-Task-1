using DAL.Models;

namespace DAL.Repositories
{
    public class CommentsRepository
    {
        AppDbContext context = new AppDbContext();
        public void AddComment(Comment comment)
        {
            if(comment != null)
            {
                try
                {
                    context.Comments.Add(comment);
                    context.SaveChanges();
                }
                catch { }
            }
        }
    }
}
