using EntityLayer.Concrete;

namespace BussinessLayer.Abstract
{
    public interface ICommentService
    {
        void CommentAdd(Comment comment);
        // void CategoryDelete(Comment comment);
        //  void CategoryUpdate(Comment comment);
        List<Comment> GetList(int id);
        //  Category GetById(int id);
    }
}