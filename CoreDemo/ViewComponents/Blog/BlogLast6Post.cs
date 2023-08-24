using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Blog
{
    public class BlogLast6Post : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke()
        {
            var values = bm.GetLastNumberBlog().Take(6).ToList();
            return View(values);    
        }
    }
}