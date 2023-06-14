using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemo.ViewComponents.Blog
{
    public class BlogListLast3 : ViewComponent
    {
        public IBlogService blogService = new BlogManager(new EfBlogRepostory());
        public IViewComponentResult Invoke()
        {
            var val = blogService.GetAllList().TakeLast(3).Reverse().ToList();
			return View(val);
        }

    }
}
