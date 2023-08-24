using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal : IGenericDal<Blog>
    {
        List<Blog> GetListWithCategory();
        List<Blog> GetListCategoryByWriter(int id);
        List<Blog> GetListCategoryByBlog(int id);
    }
}