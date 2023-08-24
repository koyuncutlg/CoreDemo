using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Xml.Schema;

namespace DataAccessLayer.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> GetListCategoryByBlog(int id)
        {
            using (var c = new Context())
            {
                return c.Blogs.Include(x => x.Category).Where(x => x.BlogID == id).ToList();
            }
        }

        public List<Blog> GetListCategoryByWriter(int id)
        {
            using (var c = new Context())
            {
                return c.Blogs.Include(x => x.Category).Where(x =>x.WriterID==id).ToList();
            }
        }

        public List<Blog> GetListWithCategory()
        {
            using (var c = new Context())
            {
                return c.Blogs.Include(x => x.Category).ToList();
            }
        }

    }
}