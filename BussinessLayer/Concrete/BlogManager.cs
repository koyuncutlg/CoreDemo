using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace BussinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }
        public List<Blog> GetListWithCategoryByWriterBm(int id)
        {
            return _blogDal.GetListCategoryByWriter(id);
        }
        public List<Blog> GetListWithCategoryByBlogBm(int id)
        {
            return _blogDal.GetListCategoryByBlog(id);
        }
        public Blog TGetById(int id)
        {
           return _blogDal.GetById(id);
        }
        public List<Blog> GetBlogByID(int id)
        {
            return _blogDal.GetListAll(x => x.BlogID == id);
        }
        public List<Blog> GetList()
        {
            return _blogDal.GetListAll();
        }    
        public List<Blog> GetLastNumberBlog()
        {
            return _blogDal.GetListAll();
        }
        public List<Blog> GetBlogListByWriter(int id)
        {
            return _blogDal.GetListAll(x => x.WriterID == id);
        }
        public void TAdd(Blog t)
        {            
            _blogDal.Insert(t);
        }
        public void TDelete(Blog t)
        {
            _blogDal.Delete(t);
        }
        public void TUpdate(Blog t)
        {
            _blogDal.Update(t);
        }         
    }
}