using EntityLayer.Concrete;

namespace BussinessLayer.Abstract
{
	public interface IBlogService : IGenericService<Blog>
    {		 
		List<Blog> GetBlogListWithCategory();
		List<Blog> GetBlogListByWriter(int id);
    }
}