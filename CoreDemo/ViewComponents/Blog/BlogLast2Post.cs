using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Blog
{
	public class BlogLast2Post : ViewComponent
	{
		BlogManager bm = new BlogManager(new EfBlogRepository());
		public IViewComponentResult Invoke()
		{
			var values = bm.GetLastNumberBlog().Take(2).ToList();
            return View(values);
		}
	}
}